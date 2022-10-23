using Grpc.Net.Client;
using GrpcFromJava;

// The port number must match the port of the gRPC server.
using var channel = GrpcChannel.ForAddress("http://localhost:8080", new GrpcChannelOptions
{
    UnsafeUseInsecureChannelCallCredentials = true
});

var client = new HelloService.HelloServiceClient(channel);


var reply = await client.helloAsync(
    new HelloRequest { FirstName = "Laurex", LastName = "Dopex"});
Console.WriteLine("Response: " + reply.Greeting);
Console.WriteLine("Press any key to exit...");
Console.ReadKey();