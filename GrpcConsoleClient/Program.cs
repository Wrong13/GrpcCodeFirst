using GrpcMidle;
using ProtoBuf.Grpc.Client;
using Grpc.Net.Client;

var channel = GrpcChannel.ForAddress("http://localhost:5163");
var client = channel.CreateGrpcService<Class1.IGreeterService>();

var reply = await client.SayHelloAsync(
    new Class1.HelloRequest { Name = "Козлов"});

Console.WriteLine(reply.Message);
Console.ReadKey();