using System.Xml.XPath;

Console.WriteLine("Type the tempature and its unit (C or F)");
string? input = Console.ReadLine();



while (true)


{

    if (input == "" || input is null || input.ToLower() == "exit")
    {

        Console.WriteLine("Terminated");
        break;
    }

    int temp = int.Parse(input.Split()[0]);
    char unit = Convert.ToChar(input.Split()[1]);


    // Console.WriteLine($"TEMP ={temp}");
    // Console.WriteLine($"UNIT ={unit}");


    TempConverter.Converter(temp, unit);
    break;
}

class TempConverter
{
    private string _temp;

    public static void Converter(int temp, char unit)
    {
        Console.WriteLine($"TEMP ={temp}");
        Console.WriteLine($"UNIT ={unit}");

        double result = 0;
      
        {
            result = (temp - 32) * (5.0 / 9.0);
        }

        Console.WriteLine($"RESULT {result}");
    }





}