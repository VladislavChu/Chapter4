using System;


RectMultidimentionalArray();
JaggedMultidimentionalArray();




static void RectMultidimentionalArray()
{
    Console.WriteLine("=> Rectangular multidimentional array.");

    int[,] myMatrix = new int[3, 4];

    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            myMatrix[i, j] = i * j;
        }

    }   
    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            Console.Write(myMatrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();


}



static void JaggedMultidimentionalArray()
{
    Console.WriteLine("=> Jagged multidimentional array.");

    int[][] myJagArray = new int[5][];

    for (int i = 0; i < myJagArray.Length; i++)
    {
        myJagArray[i] = new int[i + 7];
    }

    for (int i = 0; i < 5; i++)
    {
        for (int j = 0; j < myJagArray[i].Length; j++)
        {
            Console.Write(myJagArray[i][j] + " ");
        }
        Console.WriteLine();
    }

}
