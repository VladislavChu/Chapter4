using System;
using System.Security.Authentication;

Console.WriteLine("*****Fun with methods*****");
DisplayFancyMessage(message: "Wow! Very Fancy indeed!", textColor: ConsoleColor.DarkRed, backgroundColor: ConsoleColor.White);

DisplayFancyMessage(backgroundColor: ConsoleColor.Cyan, message: "Vladik is the best!!!!", textColor: ConsoleColor.Magenta);

DisplayFancyMessage(textColor: ConsoleColor.Magenta, ConsoleColor.Cyan, "Vladik is the best!!!!");




static void DisplayFancyMessage(ConsoleColor textColor, ConsoleColor backgroundColor, string message)
{
    //сохранить старые цвета для их восстановления после вывода сообщения
    ConsoleColor oldTextColor = Console.ForegroundColor;
    ConsoleColor oldBackgroundColor = Console.BackgroundColor;

    // установить новые цвета и вывести сообщение
    Console.ForegroundColor = textColor;
    Console.BackgroundColor = backgroundColor;
    Console.WriteLine(message);

    //вернуть цвета обратно
    Console.ForegroundColor = oldTextColor;
    Console.BackgroundColor = oldBackgroundColor;

    /*Console.ForegroundColor = textColor;
    Console.BackgroundColor = backgroundColor;
    Console.WriteLine(message);
    */
}
