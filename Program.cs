
public class PROGRAM
{
    public static void Main()
    {
        Console.WriteLine("Please enter any string");
        var Str = Console.ReadLine();  

        int VowelsCounter = 0;
        foreach (var item in Str)
        {

            if (item == 'a' || item == 'e' || item == 'i' || item == 'o' || item == 'u' ||
                item == 'A' || item == 'E' || item == 'I' || item == 'O' || item == 'U')
            {
                VowelsCounter++;
            }

        }

        Console.WriteLine("Number of vowels in the string = " + VowelsCounter);
    }
}
