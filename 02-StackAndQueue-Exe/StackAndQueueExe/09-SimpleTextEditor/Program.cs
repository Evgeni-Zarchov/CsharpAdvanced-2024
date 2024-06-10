


Stack<string> undoChat = new Stack<string>();

int n = int.Parse(Console.ReadLine());

string chat = string.Empty;

for (int i = 0; i < n; i++)
{
    string[] input = Console.ReadLine().Split();

    if (input[0] == "1")
    {
        undoChat.Push(chat);

        chat += input[1];
    }
    else if (input[0] == "2")
    {
        undoChat.Push(chat);

        int count = int.Parse(input[1]);

        chat = chat.Substring(0, chat.Length - count);
    }
    else if (input[0] == "3")
    {

        int index = int.Parse(input[1]);

        Console.WriteLine(chat[index - 1]);
    }
    else if (input[0] == "4")
    {
        chat = undoChat.Pop();
    }
}
