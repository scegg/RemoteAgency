﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SecretNest.RemoteAgency
{
    partial class RemoteAgencyManagingObject
    {
        protected void ProcessResponseMessageReceivedFromInside(IRemoteAgencyMessage message, IRemoteAgencyMessage requestMessage)
        {
            message.MessageId = requestMessage.MessageId;
            message.AssetName = requestMessage.AssetName;
            message.IsOneWay = true;
            //message.Exception set by caller.
            message.SenderInstanceId = InstanceId;
            //message.SenderSiteId leave to manager.
            message.TargetInstanceId = requestMessage.SenderInstanceId;
            message.TargetSiteId = requestMessage.SenderSiteId;
            message.MessageType = requestMessage.MessageType;

            _sendMessageToManagerCallback(message);
        }

        protected void ProcessPreparedRequestMessageReceivedFromInside(IRemoteAgencyMessage message)
        {
            //local site id will be set by manager.
            _sendMessageToManagerCallback(message);
        }
    }

    partial class RemoteAgencyManagingObjectProxy<TEntityBase>
    {
        void PrepareDefaultTargetRequestMessageReceivedFromInside(IRemoteAgencyMessage message, MessageType messageType, bool isOneWay)
        {
            message.MessageId = Guid.NewGuid();
            //message.AssetName set while generating.
            message.IsOneWay = isOneWay;
            //message.Exception = null;
            message.SenderInstanceId = InstanceId;
            //message.SenderSiteId leave to manager.
            message.TargetInstanceId = DefaultTargetInstanceId;
            message.TargetSiteId = TargetSiteId;
            message.MessageType = messageType;
        }

        IRemoteAgencyMessage ProcessMethodMessageReceivedFromInside(IRemoteAgencyMessage message, int timeout)
        {
            PrepareDefaultTargetRequestMessageReceivedFromInside(message, MessageType.Method, false);
            return ProcessRequestAndWaitResponse(message, ProcessPreparedRequestMessageReceivedFromInside, timeout);
        }

        void ProcessOneWayMethodMessageReceivedFromInside(IRemoteAgencyMessage message)
        {
            PrepareDefaultTargetRequestMessageReceivedFromInside(message, MessageType.Method, true);
            ProcessPreparedRequestMessageReceivedFromInside(message);
        }

        void ProcessEventAddMessageReceivedFromInside(MessageType messageType, string assetName, int timeout)
        {
            var message = CreateEmptyMessage();
            message.AssetName = assetName;
            PrepareDefaultTargetRequestMessageReceivedFromInside(message, MessageType.EventAdd, false);
            var response = ProcessRequestAndWaitResponse(message, ProcessPreparedRequestMessageReceivedFromInside, timeout);
            if (response.Exception != null)
                throw response.Exception;
        }

        void ProcessEventRemoveMessageReceivedFromInside(MessageType messageType, string assetName, int timeout)
        {
            var message = CreateEmptyMessage();
            message.AssetName = assetName;
            PrepareDefaultTargetRequestMessageReceivedFromInside(message, MessageType.EventRemove, false);
            var response = ProcessRequestAndWaitResponse(message, ProcessPreparedRequestMessageReceivedFromInside, timeout);
            if (response.Exception != null)
                throw response.Exception;
        }

        void ProcessOneWayEventRemoveMessageReceivedFromInside(MessageType messageType, string assetName)
        {
            var message = CreateEmptyMessage();
            message.AssetName = assetName;
            PrepareDefaultTargetRequestMessageReceivedFromInside(message, MessageType.EventRemove, false);
            ProcessPreparedRequestMessageReceivedFromInside(message);
        }

        IRemoteAgencyMessage ProcessPropertyGetMessageReceivedFromInside(IRemoteAgencyMessage message, int timeout)
        {
            PrepareDefaultTargetRequestMessageReceivedFromInside(message, MessageType.PropertyGet, false);
            return ProcessRequestAndWaitResponse(message, ProcessPreparedRequestMessageReceivedFromInside, timeout);
        }

        void ProcessOneWayPropertyGetMessageReceivedFromInside(IRemoteAgencyMessage message)
        {
            PrepareDefaultTargetRequestMessageReceivedFromInside(message, MessageType.PropertyGet, true);
            ProcessPreparedRequestMessageReceivedFromInside(message);
        }

        IRemoteAgencyMessage ProcessPropertySetMessageReceivedFromInside(IRemoteAgencyMessage message, int timeout)
        {
            PrepareDefaultTargetRequestMessageReceivedFromInside(message, MessageType.PropertySet, false);
            return ProcessRequestAndWaitResponse(message, ProcessPreparedRequestMessageReceivedFromInside, timeout);
        }

        void ProcessOneWayPropertySetMessageReceivedFromInside(IRemoteAgencyMessage message)
        {
            PrepareDefaultTargetRequestMessageReceivedFromInside(message, MessageType.PropertySet, true);
            ProcessPreparedRequestMessageReceivedFromInside(message);
        }
    }

    partial class RemoteAgencyManagingObjectServiceWrapper<TEntityBase>
    {
        void PrepareRequestMessageReceivedFromInside(IRemoteAgencyMessage message, MessageType messageType, bool isOneWay)
        {
            message.MessageId = Guid.NewGuid();
            //message.AssetName set while generating.
            message.IsOneWay = isOneWay;
            //message.Exception = null;
            message.SenderInstanceId = InstanceId;
            //message.SenderSiteId leave to manager.
            //message.TargetInstanceId set while generating.
            //message.TargetSiteId set while generating.
            message.MessageType = messageType;
        }

        IRemoteAgencyMessage ProcessEventMessageReceivedFromInside(IRemoteAgencyMessage message, int timeout)
        {
            PrepareRequestMessageReceivedFromInside(message, MessageType.Event, false);
            return ProcessRequestAndWaitResponse(message, ProcessPreparedRequestMessageReceivedFromInside, timeout);
        }

        void ProcessOneWayEventMessageReceivedFromInside(IRemoteAgencyMessage message)
        {
            PrepareRequestMessageReceivedFromInside(message, MessageType.Event, true);
            ProcessPreparedRequestMessageReceivedFromInside(message);
        }

    }
}