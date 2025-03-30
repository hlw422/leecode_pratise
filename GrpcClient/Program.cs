namespace GrpcClient;
using Grpc.Net.Client;
class Program
{
    async static Task Main(string[] args)
    {
        using var channel = GrpcChannel.ForAddress("http://localhost:5162");
        var client = new Greeter.GreeterClient(channel);
        var reply = await client.SayHelloAsync(
            new HelloRequest { Name = "GreeterClient" });
        Console.WriteLine("Greeting: " + reply.Message);
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}