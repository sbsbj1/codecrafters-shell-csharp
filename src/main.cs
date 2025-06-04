using System.Net;
using System.Net.Sockets;




while (true)
{
    Console.Write("$ ");
    var command = Console.ReadLine();
    if( command == "exit 0")
    {
        break;
    }
    if ( command.Contains("echo "))
    {
        var echo = command.Substring(5);
        Console.WriteLine(echo);
        continue;
    }
    Console.WriteLine($"{command}: command not found");
    
}
