string[] text;
Console.WriteLine("Введите массив строк через пробел:");

string stroka = Console.ReadLine();
text = stroka.Split(' ');

var result = new string[text.Length];
var l = 0;

foreach (var value in text)
{
    if (value.Length <= 3)
    {
        result[l] = value;
        l++;
    }
}
Console.Write(string.Join(Environment.NewLine, result, 0, l));
Console.ReadKey(true);