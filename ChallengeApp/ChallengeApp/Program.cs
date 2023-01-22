int number = 4566;
string numberInString = number.ToString();//zamiana liczby na string
char[] letters = numberInString.ToArray();//zamiana stringa na tablicę char


for (int i = 0; i < 10; i++)
{
    int counter = 0;
    foreach (char letter in letters)
    {
        int charInNumber = letter - '0';//zamiana char na liczbę
        if (charInNumber == i)
        {
            counter++;
        }
    }
    Console.WriteLine(i + "=>" + counter);

}



