        using System;
        using FunWithEnums;
        using static FunWithEnums.EmpTypeEnum;





        Console.WriteLine("***** Fun with Enums *****");
        EmpTypeEnum emp = EmpTypeEnum.Manager;
        //Console.WriteLine($"emp is a {emp.ToString()}");
        //Console.WriteLine($"{emp.ToString()} = {(byte)emp}");
        DayOfWeek day = DayOfWeek.Monday;
        ConsoleColor color = ConsoleColor.Gray;
        EvaluateEnum(day);
        EvaluateEnum(color);
        EvaluateEnum(emp);



        //AskForBonus(emp);
        //Console.WriteLine($"EmpTypeEnum uses a {Enum.GetUnderlyingType(emp.GetType())} for storage");

        /*foreach (EmpTypeEnum i in EmpTypeEnum.GetValues(typeof(EmpTypeEnum)))
        {
            AskForBonus(i);
        }*/
        //Console.WriteLine($"EmpTypeEnum uses a {Enum.GetUnderlyingType(typeof(EmpTypeEnum))} for storage");
        Console.ReadLine();



        static void AskForBonus(EmpTypeEnum e)
        {
            switch (e)
            {
                case EmpTypeEnum.Manager:
                    Console.WriteLine("How about stock options instead?");
                    break;

                case EmpTypeEnum.Grunt:
                    Console.WriteLine("You have got to be kidding...");
                    break;

                case EmpTypeEnum.Contractor:
                    Console.WriteLine("You already get enough cash...");
                    break;

                case EmpTypeEnum.VicePresident:
                    Console.WriteLine("VERY GOOD, Sir! ");
                    break;
            }
        }


static void EvaluateEnum(System.Enum e)
{
    Console.WriteLine($"=> Information about {e.GetType().Name}");
    Console.WriteLine($"Underlying storage type {Enum.GetUnderlyingType(e.GetType())}");
            
    Array enumData = Enum.GetValues(e.GetType());
    Console.WriteLine($"This enum has members: {enumData.Length}");
            
    for (int i = 0; i < enumData.Length; i++)
    {
        Console.WriteLine($"Name: {enumData.GetValue(i)}, Value: {enumData.GetValue(i):D}");
    }
    Console.WriteLine();
}