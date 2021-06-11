﻿using System;
using SecretNest.RemoteAgency;
using SecretNest.RemoteAgency.Attributes;

namespace Test.CSharp.Test9
{
    public interface ITest9
    {
        [AssetIgnored]
        event EventHandler Ignored;

        [OperatingTimeoutTime(1000)]
        event MyEventCallback MyEvent;
        delegate int MyEventCallback([ParameterReturnRequiredProperty("EntityTwoWayProperty", isIncludedWhenExceptionThrown: true)] EntityInTest9 parameter);

        event MyEventWithTwoWayParameterCallback MyEventWithTwoWayParameter;
        [ReturnIgnored()]
        delegate int MyEventWithTwoWayParameterCallback(int parameter, ref int parameter1, out int parameter2, [ParameterIgnored]int ignored);

        [LocalExceptionHandling]
        event EventHandler WithException;

        [EventParameterReturnRequiredProperty("parameter", "TwoWayProperty", isIncludedWhenExceptionThrown: true)]
        event MyEventWithExceptionCallback MyEventWithException;
        [LocalExceptionHandling]
        delegate void MyEventWithExceptionCallback(EntityInTest9B parameter);
    }

    public class EntityInTest9
    {
        public string FromServerToClientProperty { get; set; }

        public string TwoWayProperty { get; set; }
    }

    public class EntityInTest9B
    {
        public string FromServerToClientProperty { get; set; }

        public string TwoWayProperty { get; set; }
    }

    public class Server9 : ITest9
    {
        public event EventHandler Ignored;
        public event ITest9.MyEventCallback MyEvent;
        public event ITest9.MyEventWithTwoWayParameterCallback MyEventWithTwoWayParameter;
        public event EventHandler WithException;
        public event ITest9.MyEventWithExceptionCallback MyEventWithException;

        public void Test()
        {
            Console.WriteLine("Server side: Ignored");
            if (Ignored == null)
            {
                Console.WriteLine("Server side: This is predicted due to ignored.");
            }

            Console.WriteLine("Server side: MyEvent");
            if (MyEvent != null)
            {
                var parameter = new EntityInTest9
                {
                    FromServerToClientProperty = "SetFromServer",
                    TwoWayProperty = "SetFromServer"
                };

                var result = MyEvent.Invoke(parameter);
                Console.WriteLine($"Server side: (100): {result}");
                Console.WriteLine($"Server side: parameter.FromServerToClientProperty (should be SetFromServer): {parameter.FromServerToClientProperty}");
                Console.WriteLine($"Server side: parameter.TwoWayProperty (should be ChangedByClient): {parameter.TwoWayProperty}");
            }

            Console.WriteLine("Server side: MyEventWithTwoWayParameter");
            if (MyEventWithTwoWayParameter != null)
            {
                var p1 = 101;
                var result = MyEventWithTwoWayParameter(100, ref p1, out var p2, 103);
                Console.WriteLine($"Server side: (0 due to return ignored): {result}");
                Console.WriteLine($"Server side: p1=(501): {p1}");
                Console.WriteLine($"Server side: p2=(502): {p2}");
            }

            Console.WriteLine("Server side: WithException");
            if (WithException != null)
            {
                try
                {
                    WithException.Invoke(this, EventArgs.Empty);
                }
#pragma warning disable CA1031 // Do not catch general exception types
                catch (Exception e)
                {
                    Console.WriteLine("Predicted Exception: " + e.Message);
                }
#pragma warning restore CA1031 // Do not catch general exception types
            }

            Console.WriteLine("Server side: MyEventWithException");
            if (MyEventWithException != null)
            {
                var parameter = new EntityInTest9B
                {
                    FromServerToClientProperty = "SetFromServer",
                    TwoWayProperty = "SetFromServer"
                }; 
                try
                {
                    MyEventWithException.Invoke(parameter);
                }
#pragma warning disable CA1031 // Do not catch general exception types
                catch (Exception e)
                {
                    Console.WriteLine($"Server side: parameter.FromServerToClientProperty (should be SetFromServer): {parameter.FromServerToClientProperty}");
                    Console.WriteLine($"Server side: parameter.TwoWayProperty (should be SetBeforeException): {parameter.TwoWayProperty}");
                    Console.WriteLine("Predicted Exception: " + e.Message);
                }
#pragma warning restore CA1031 // Do not catch general exception types
            }
        }
    }

    public static class TestCode
    {
        public static void MyTest()
        {
            //test router
            var router = new RemoteAgencyRouter<byte[], object>();
            
            //Server
            var originalService = new Server9();
            using var serverRemoteAgencyInstance = RemoteAgencyBase.CreateWithBinarySerializer(true);
            router.AddRemoteAgencyInstance(serverRemoteAgencyInstance);
            var serverSiteId = serverRemoteAgencyInstance.SiteId;
            var serviceWrapperInstanceId = serverRemoteAgencyInstance.CreateServiceWrapper(originalService);

            //Client
            using var clientRemoteAgencyInstance = RemoteAgencyBase.CreateWithBinarySerializer(true);
            router.AddRemoteAgencyInstance(clientRemoteAgencyInstance);
            clientRemoteAgencyInstance.ExceptionRedirected += ClientRemoteAgencyInstance_ExceptionRedirected;
            var clientProxy = clientRemoteAgencyInstance.CreateProxy<ITest9>(serverSiteId, serviceWrapperInstanceId).ProxyGeneric;

            //Run test
            Console.WriteLine("Ignored Add(Exception):");
            try
            {
                //ReSharper disable UnusedParameter.Local
                clientProxy.Ignored += (sender, args) => { };
                //ReSharper enable UnusedParameter.Local
            }
#pragma warning disable CA1031 // Do not catch general exception types
            catch (Exception e)
            {
                Console.WriteLine("Predicted Exception: " + e);
            }
#pragma warning restore CA1031 // Do not catch general exception types

            clientProxy.MyEvent += parameter =>
            {
                parameter.FromServerToClientProperty = "ChangedByClient";
                parameter.TwoWayProperty =  "ChangedByClient";
                return 100;
            };

            clientProxy.MyEventWithTwoWayParameter +=
                (int parameter, ref int parameter1, out int parameter2, int ignored) =>
                {
                    Console.WriteLine($"parameter: (100): {parameter}");
                    Console.WriteLine($"parameter1: (101): {parameter1}");
                    Console.WriteLine($"ignored: (0): {ignored}");
                    parameter1 = 501;
                    parameter2 = 502;
                    return 1;
                };

            //ReSharper disable UnusedParameter.Local
            clientProxy.WithException += (sender, args) => throw new Exception("oops.");
            //ReSharper enable UnusedParameter.Local

            clientProxy.MyEventWithException += (parameter) =>
            {
                parameter.FromServerToClientProperty = "ChangedByClient";
                parameter.TwoWayProperty = "SetBeforeException";
                throw new Exception("oops.");
            };

            Console.WriteLine("Run:");
            originalService.Test();

            Console.Write("Press any key to continue...");
            Console.ReadKey(true);
            Console.WriteLine();
        }

        private static void ClientRemoteAgencyInstance_ExceptionRedirected(object sender, ExceptionRedirectedEventArgs e)
        {   
            Console.WriteLine($"Client side exception: \n  Interface:{e.ServiceContractInterface.FullName}\n  InstanceId: {e.InstanceId}\n  AssetName: {e.AssetName}\n  ExceptionType: {e.RedirectedException.GetType().FullName}\n  ExceptionMessage: {e.RedirectedException.Message}");
        }
    }
}