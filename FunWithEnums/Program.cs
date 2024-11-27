using System;




Console.WriteLine("***** Fun with Enums *****");
//EmpTypeEnum emp = Enum.GetValues(typeof(EmpTypeEnum);
//AskForBonus(emp);
//Console.WriteLine($"EmpTypeEnum uses a {Enum.GetUnderlyingType(emp.GetType())} for storage");

foreach (EmpTypeEnum i in EmpTypeEnum.GetValues(typeof(EmpTypeEnum)))
{
    AskForBonus(i);
}
Console.WriteLine($"EmpTypeEnum uses a {Enum.GetUnderlyingType(typeof(EmpTypeEnum))} for storage");
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





enum EmpTypeEnum : byte
{
    Manager,        //0
    Grunt,          //1
    Contractor,     //2
    VicePresident   //3
}