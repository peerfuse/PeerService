using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

class PeerToPeerServer
{
    private static Socket serverSocket;

    static void Main()
    {
        StartServer();
    }

    static void StartServer()
    {
        serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        serverSocket.Bind(new IPEndPoint(IPAddress.Any, 12345));
        serverSocket.Listen(10);

        Console.WriteLine("Servidor iniciado. Aguardando conexões...");

        // Thread para aceitar conexões
        Thread acceptThread = new Thread(AcceptConnections);
        acceptThread.Start();

        while (true)
        {
            // Thread para enviar dados simultaneamente
            Thread sendThread = new Thread(SendData);
            sendThread.Start();

            // Aguardar um pouco antes de iniciar uma nova thread de envio
            Thread.Sleep(1000);
        }
    }

    static void AcceptConnections()
    {
        try
        {
            while (true)
            {
                Socket clientSocket = serverSocket.Accept();

                // Iniciar uma nova thread para lidar com a conexão do cliente
                Thread clientThread = new Thread(HandleClient);
                clientThread.Start(clientSocket);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Erro ao aceitar conexões: " + ex.Message);
        }
    }

    static void HandleClient(object obj)
    {
        Socket clientSocket = (Socket)obj;

        try
        {
            while (true)
            {
                byte[] message = new byte[4096];
                int bytesRead = clientSocket.Receive(message);

                if (bytesRead == 0)
                {
                    // O cliente se desconectou
                    Console.WriteLine("Cliente desconectado.");
                    break;
                }

                // Processar a mensagem recebida do cliente (implementação personalizada)
                string receivedMessage = Encoding.UTF8.GetString(message, 0, bytesRead);
                Console.WriteLine($"Mensagem recebida: {receivedMessage}");

                // Enviar uma resposta (implementação personalizada)
                string responseMessage = "Mensagem recebida com sucesso!";
                byte[] responseData = Encoding.UTF8.GetBytes(responseMessage);
                clientSocket.Send(responseData);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Erro de comunicação: " + ex.Message);
        }
        finally
        {
            clientSocket.Close();
        }
    }

    static void SendData()
    {
        try
        {
            // Aqui você pode colocar lógica para enviar dados aos clientes
            // Exemplo: serverSocket.Send(dataToSend);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Erro ao enviar dados: " + ex.Message);
        }
    }
}