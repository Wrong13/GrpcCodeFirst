using AspServices;
using GrpcMidle;
using Grpc.Core;
using ProtoBuf.Grpc;

namespace AspServices.Services
{
    public class GreeterService : Class1.IGreeterService
    {
        public Task<Class1.HelloReply> SayHelloAsync(Class1.HelloRequest request, CallContext context = default)
        {
            return Task.FromResult(
                new Class1.HelloReply
                {
                    Message = $"Здрасте {request.Name}"
                });
        }
    }
}