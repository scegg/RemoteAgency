﻿using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SecretNest.RemoteAgency
{
    partial class RemoteAgencyManagingObject
    {
        readonly ConcurrentDictionary<Guid, ResponderItem> _responders = new ConcurrentDictionary<Guid, ResponderItem>();

        IRemoteAgencyMessage ProcessRequestAndWaitResponse(IRemoteAgencyMessage message,
            Action<IRemoteAgencyMessage> afterPreparedCallback, int millisecondsTimeout)
        {
            using (ResponderItem responder = new ResponderItem())
            {
                _responders[message.MessageId] = responder;
                afterPreparedCallback(message);

                if (responder.GetResult(millisecondsTimeout, out var response))
                {
                    _responders.TryRemove(message.MessageId, out _);
                    return response;
                }
                else
                {
                    _responders.TryRemove(message.MessageId, out _);
                    throw new AccessingTimeOutException();
                }
            }
        }

        protected void OnResponseReceived(IRemoteAgencyMessage message)
        {
            if (_responders.TryGetValue(message.MessageId, out var responder))
            {
                responder.SetResult(message);
            }
        }

        class ResponderItem : IDisposable
        {
            private IRemoteAgencyMessage _value;

            readonly ManualResetEvent _waitHandle = new ManualResetEvent(false);

            public void SetResult(IRemoteAgencyMessage value)
            {
                _value = value;
                _waitHandle?.Set();
            }

            public bool GetResult(int millisecondsTimeout, out IRemoteAgencyMessage value)
            {
                if (_waitHandle.WaitOne(millisecondsTimeout))
                {
                    value = _value;
                    return true;
                }
                else
                {
                    value = default;
                    return false;
                }
            }

            public void Dispose()
            {
                _waitHandle?.Dispose();
            }
        }
    }
}
