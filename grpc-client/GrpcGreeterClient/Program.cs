// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System.Threading.Tasks;
using Grpc.Net.Client;
using GrpcGreeterClient;

// The port number must match the port of the gRPC server.
using var channel = GrpcChannel.ForAddress("https://localhost:7042");
var client = new Greeter.GreeterClient(channel);
HelloRequest helloRequest = new HelloRequest(){ Name ="---> 💟 Arvind"};
var reply = await client.SayHelloAsync(helloRequest);

Console.WriteLine("Greeting: " + reply.Message);
Console.WriteLine("Press any key to exit...");
Console.ReadKey();
