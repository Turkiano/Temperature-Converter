using System.Xml.XPath;
//to prompt into to users to interact
Console.WriteLine("Type the tempature and its unit (C or F)");
// to capture data from users



while (true)


{
    string? input = Console.ReadLine();
    //we have 3 conditions here, ToLower ()= if we typed exit
    if (input == "" || input is null || input.ToLower() == "exit")
    {

        //this is the return
        Console.WriteLine("Terminated");
        break; // to stop the looping
    }


    try
    {
        //to convert string to int 
        int temp = int.Parse(input.Split()[0]);

        {
            Console.WriteLine("This is an INT");
        }

        //to convert string to  char
        char unit = Convert.ToChar(input.Split()[1]);


        var result = unit switch
        {
            'F' => (temp - 32) * (5.0 / 9.0), // to convert from F to C
            'C' => (temp * 9) / 5 + 32, // to convert from C to F
            _ => throw new FormatException("Invalid unit, type C/F") // to validate unit error

        };

        Console.WriteLine("result:" + result);

    }
    catch (FormatException ex) //to validate errors
    {
        Console.WriteLine("Invalid input");

        Console.WriteLine(ex.Message);// to customize validation messages
        continue;
    }

    catch (Exception)
    {

        throw;
    }





}

