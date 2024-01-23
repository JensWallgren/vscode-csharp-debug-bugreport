using System;
using System.Threading.Tasks;

class Writer(string Message)
{
    public void Write()
    {
        var message = Message;
        Console.WriteLine(message);
    }

    public async Task WriteAsync()
    {
        var message = Message;
        Console.WriteLine(message);
    }
}
