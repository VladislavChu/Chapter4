using System;



AddWrapperWithStatic(3, 4);



static int AddWrapperWithStatic(int x, int y)
    {
    //здесь должна быть какая-то проверка
    return Add(x, y);
    static int Add(int x, int y)
        {
            return x + y;
        }
    }
