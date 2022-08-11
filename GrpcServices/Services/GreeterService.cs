using Grpc.Core;
using GrpcMidle;
using GrpcServices;
using ProtoBuf.Grpc;

namespace GrpcServices.Services
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