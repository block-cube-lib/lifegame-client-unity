using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Grpc.Core;
using Helloworld;
using UnityEngine;

public class Greeter : MonoBehaviour
{
    const int Port = 50051;
    Server server = null;

    // Start is called before the first frame update
    void Start ()
    {
        //server = StartServer();
        Greet("start user");
    }

    // Update is called once per frame
    void Update ()
    {
        if (Input.anyKeyDown)
        {
            Greet("update");
        }
    }

    void Greet (string user)
    {
        Channel channel = new Channel ($"127.0.0.1:{Port}", ChannelCredentials.Insecure);

        var client = new Helloworld.Greeter.GreeterClient (channel);

        var reply = client.SayHello (new HelloRequest { Name = user });
        Debug.Log ("Greeting: " + reply.Message);

        channel.ShutdownAsync ().Wait ();
    }

    class GreeterImpl : Helloworld.Greeter.GreeterBase
    {
        // Server side handler of the SayHello RPC
        public override Task<HelloReply> SayHello (HelloRequest request, ServerCallContext context) {
            return Task.FromResult (new HelloReply { Message = "Hello " + request.Name });
        }
    }

    Server StartServer ()
    {
        Server server = new Server {
            Services = { Helloworld.Greeter.BindService (new GreeterImpl ()) },
            Ports = { new ServerPort ("localhost", Port, ServerCredentials.Insecure) }
        };
        server.Start ();

        Debug.Log ("Greeter server listening on port " + Port);

        return server;
    }

    void OnDisable()
    {
        if (server != null)
        {
            server.ShutdownAsync().Wait();
            Debug.Log("server shutdown");
        }
    }
}
