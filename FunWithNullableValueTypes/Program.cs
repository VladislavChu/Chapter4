using System;




static void LocalNullableVariables()
{
    int? nullableInt = 10;
    double? nullableDouble = 3.14;
    bool? nullableBool = null;
    char? nullableChar = 'a';
    int?[] ArrayOfNullableInts = new int?[10];
}


/* Так как "?" это просто сокращение от System.Nullable<T>, то мы могли бы написать метод LocalNullableVariables следующим образом:
 * static void LocalNullableVariablesUsingNullable()
{
    Nullable<int> nullableInt = 10;
    Nullable<double> nullableDouble = 3.14;
    Nullable<bool> nullableBool = null;
    Nullable<char> nullableChar = 'a';
    Nullable<int>[] ArrayOfNullableInts = new Nullable<int>[10];
}
*/