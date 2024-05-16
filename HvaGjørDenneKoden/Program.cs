var range = 250;
var counts = new int[range];
var totalcount = 0;
string text = "something";
while (!string.IsNullOrWhiteSpace(text))
{
    text = Console.ReadLine();
    foreach (var character in text.ToLower() ?? string.Empty)
    {
        totalcount++;
        counts[character]++;
    }
    for (var i = 0; i < range; i++)
    {
        if (counts[i] > 0)
        {
            var character = (char)i;
            var percentage = 100 * counts[i] / totalcount ;
            string answer = character + " - " + percentage + "%";
            Console.CursorLeft = 20;//Console.BufferWidth - answer.Length - 1;
            Console.WriteLine(answer);
        }
    }
}