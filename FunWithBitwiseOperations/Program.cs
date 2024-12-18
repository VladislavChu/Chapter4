﻿using System;
using FunWithBitwiseOperations;
using static FunWithBitwiseOperations.ContactPreferenceEnum;



//using FunWithBitwiseOperations;

/* Console.WriteLine("Fun wih Bitwise Operations");

Console.WriteLine("6 & 4 = {0} | {1}", 6 & 4, Convert.ToString((6 & 4), 2));

Console.WriteLine("6 | 4 = {0} {1}", 6 | 4, Convert.ToString((6 | 4), 2));

Console.WriteLine("6 ^ 4 = {0} {1}", 6 ^ 4, Convert.ToString((6 ^ 4), 2));

Console.WriteLine("6 « 1 = {0} {1}", 6 << 1, Convert.ToString((6 << 1), 2));

Console.WriteLine("6 » 1 = {0} {1}", 6 >> 1,Convert.ToString((6 >> 1), 2));

Console.WriteLine("~6 = {0}|{1}", ~ 6, Convert.ToString(~((short)6), 2));
Console.WriteLine("Int.MaxValue {0}", Convert.ToString((int.MaxValue), 2));
Console.ReadLine();
*/


ContactPreferenceEnum emailAndPhone = ContactPreferenceEnum.Email | ContactPreferenceEnum.Phone;

Console.WriteLine($"None? {(emailAndPhone | ContactPreferenceEnum.None) == emailAndPhone}");
Console.WriteLine($"Email? {(emailAndPhone | ContactPreferenceEnum.Email) == emailAndPhone}");
Console.WriteLine($"Phone? {(emailAndPhone | ContactPreferenceEnum.Phone) == emailAndPhone}");
Console.WriteLine($"Text? {(emailAndPhone | ContactPreferenceEnum.Text) == emailAndPhone}");