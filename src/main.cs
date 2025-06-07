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
    else if(command.ToLower().Contains("type "))
    {

        var isFound = false;
        var subString = command.Substring(5);
        if (builtin.Any(subString.Contains))
        {
            Console.WriteLine($"{subString} is a shell builtin");
            continue;
        }
        foreach (string test in (Environment.GetEnvironmentVariable("PATH")).Split(':'))
        {   
            string path = test.Trim();
            if ( File.Exists(path = Path.Combine(path, subString)))
            {
                Console.WriteLine($"{subString} is {path}");
                isFound = true;
                break;               
            }            
        }
        if(isFound == false )
        {
            Console.WriteLine($"{subString}: not found");
        }
    }
    else
    {
        Console.WriteLine($"{command}: command not found");
    }

}

