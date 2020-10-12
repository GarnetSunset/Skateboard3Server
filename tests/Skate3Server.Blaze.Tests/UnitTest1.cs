using System;
using System.IO;
using System.Net;
using Skate3Server.Blaze.Handlers.Redirector.Messages;
using Skate3Server.Blaze.Responses;
using Skate3Server.Blaze.Serializer;
using Xunit;

namespace Skate3Server.Blaze.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var response = new RedirectorServerInfoResponse
            {
                Address = new NetworkAddress
                {
                    Host = "localhost",
                    Ip = Convert.ToUInt32(IPAddress.Parse("127.0.0.1").Address),
                    Port = 10744
                },
                AddressType = NetworkAddressType.Client,
                Secure = 0,
                Xdns = 0
            };

            var requestHeader = new BlazeHeader
            {
                Command = 1,
                Component = BlazeComponent.Redirector,
                ErrorCode = 0,
                MessageType = BlazeMessageType.Message,
                MessageId = 100
            };

            var test = new BlazeSerializer();

            var stream = new MemoryStream();

            test.Serialize(stream, requestHeader, response);
            stream.Position = 0;
            var messageHex = BitConverter.ToString(stream.ToArray()).Replace("-", " ");

            Console.WriteLine("Hi");
        }

        [Fact]
        public void StructTest()
        {
            var response = new DummyResponse
            {
                SomeStruct = new DummyStruct
                {
                    Dumb = "Hello"
                }
            };

            var requestHeader = new BlazeHeader
            {
                Command = 1,
                Component = BlazeComponent.Redirector,
                ErrorCode = 0,
                MessageType = BlazeMessageType.Message,
                MessageId = 100
            };

            var test = new BlazeSerializer();

            var stream = new MemoryStream();

            test.Serialize(stream, requestHeader, response);
            stream.Position = 0;
            var messageHex = BitConverter.ToString(stream.ToArray()).Replace("-", " ");

            Console.WriteLine("Hi");
        }
    }
}