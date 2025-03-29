using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.Json; // for JSON serialization

public class SimpleServer
{
    public static void Main(string[] args)
    {
        try
        {
            // Set the IP address and port
            IPAddress ipAddress = IPAddress.Loopback;
            int port = 8080;

            // Create a TCP listener
            TcpListener listener = new TcpListener(ipAddress, port);

            // Start listening
            listener.Start();
            Console.WriteLine($"Server listening on {ipAddress}:{port}");

            while (true) // Keep the server running to handle multiple connections
            {
                // Accept a client
                TcpClient client = listener.AcceptTcpClient();
                Console.WriteLine("Client connected.");

                // Get the stream
                NetworkStream stream = client.GetStream();

                // Send the response as a JSON array
                string[] responseArray = { "Python", "Java", "JavaScript", "C#", "C++" };
                string jsonResponse = JsonSerializer.Serialize(responseArray); // Serialize to JSON
                byte[] responseBytes = Encoding.UTF8.GetBytes(jsonResponse); // Use UTF8 for JSON
                stream.Write(responseBytes, 0, responseBytes.Length);

                // Close the connection
                stream.Close();
                client.Close();
                Console.WriteLine("Client disconnected.");
            }
            // Note:  It's good practice to have a way to stop the listener,
            //        but for this simple example, it will run until you
            //        manually terminate the program (e.g., Ctrl+C in the console).
            // listener.Stop(); // This line would stop the listener, but the server is in an infinite loop.

        }
        catch (Exception e)
        {
            Console.WriteLine($"Error: {e.Message}");
        }
    }
}
