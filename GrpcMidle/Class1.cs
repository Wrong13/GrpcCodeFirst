using ProtoBuf.Grpc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace GrpcMidle
{
    public class Class1
    {
        [DataContract]
        public class HelloReply
        {
            [DataMember(Order = 1)]
            public string Message { get; set; }
        }
        [DataContract]
        public class HelloRequest
        {
            [DataMember(Order = 1)]
            public string Name { get; set; }
        }
        [ServiceContract]
        public interface IGreeterService
        {
            [OperationContract]
            Task<HelloReply> SayHelloAsync(HelloRequest request,
                CallContext context = default);
        }
    }
}
