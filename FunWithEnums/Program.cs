using System;



Console.WriteLine("***** Fun with Enums *****");
EmpTypeEnum emp = EmpTypeEnum.Contractor;
AskForBonus(emp);
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