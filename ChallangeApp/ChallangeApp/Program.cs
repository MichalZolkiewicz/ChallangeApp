int number = 10101010;
string numberAsString = number.ToString();
char[] letters = numberAsString.ToArray();

int couter0 = 0;
int couter1 = 0;
int couter2 = 0;
int couter3 = 0;
int couter4 = 0;
int couter5 = 0;
int couter6 = 0;
int couter7 = 0;
int couter8 = 0;
int couter9 = 0;

foreach(char letter in letters)
{
    if(letter == '0')
    {
        couter0++;
    }
    else if(letter == '1')
    {
        couter1++;
    }
    else if (letter == '2')
    {
        couter2++;
    }
    else if (letter == '3')
    {
        couter3++;
    }
    else if (letter == '4')
    {
        couter4++;
    }
    else if (letter == '5')
    {
        couter5++;
    }
    else if (letter == '6')
    {
        couter6++;
    }
    else if (letter == '7')
    {
        couter7++;
    }
    else if (letter == '8')
    {
        couter8++;
    }
    else if (letter == '9')
    {
        couter9++;
    }
}

Console.WriteLine("0 => " + couter0);
Console.WriteLine("1 => " + couter1);
Console.WriteLine("2 => " + couter2);
Console.WriteLine("3 => " + couter3);
Console.WriteLine("4 => " + couter4);
Console.WriteLine("5 => " + couter5);
Console.WriteLine("6 => " + couter6);
Console.WriteLine("7 => " + couter7);
Console.WriteLine("8 => " + couter8);
Console.WriteLine("9 => " + couter9);

Console.ReadKey();