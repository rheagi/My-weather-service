
static int DigitForNumber(int number, int digitNumber)
{
    int rightNumbers = number % (int)Math.Pow(10, digitNumber);
    int digit = rightNumbers / (int)Math.Pow(10, digitNumber - 1);
    return digit;
}

static int NumberLength(int number)
{
    int i = 0;
    int result = number / (int)Math.Pow(10, i);

    if (number == 0)
    {
        return 1;
    }

    while (result > 0)
    {
        result = number / (int)Math.Pow(10, i);
        i++;
    }
    i--;

    return i;
}

Console.Write("Hello! This program can check if your number is palindrome or not. \nType any number: ");
int number = Convert.ToInt32(Console.ReadLine());

int rightPosition = 1;
int leftPosition = NumberLength(number);

while (leftPosition > rightPosition)
{
    int rightValue = DigitForNumber(number, rightPosition);
    int leftValue = DigitForNumber(number, leftPosition);
    if (rightValue != leftValue)
    {
        Console.WriteLine("Your number is not a palindrome.");
        return;
    }
    rightPosition++;
    leftPosition--;
}
Console.WriteLine("Your number is a palindrome.");
