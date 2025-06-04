using System.Net;
using System.Net.Sockets;



String[] builtin = { "exit", "echo", "type" };
while (true)
{
    Console.Write("$ ");
    var command = Console.ReadLine();
    if( command.ToLower() == "exit 0")
    {
        break;
    }
    if ( command.ToLower().Contains("echo "))
    {
        var echo = command.Substring(5);
        Console.WriteLine(echo);
        continue;
    }
    if(command.ToLower().Contains("type "))
    {
        var subString = command.Substring(5);
        if (builtin.Any(subString.Contains))
        {
            Console.WriteLine($"{subString} is a shell builtin");
            continue;
        }
        Console.WriteLine($"{subString}: not found");
        continue;
    }
    Console.WriteLine($"{command}: command not found");
    
}
