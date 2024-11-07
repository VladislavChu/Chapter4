using System;


static int Add(int x, int y)
{
    //здесь должна выполняться проверка достоверности
    return x + y;
}

static int AddWrapper(int x, int y)
{
    //здесь должна выполняться проверка достоверности
    return Add();
    int Add()
    {
        return x + y; 
    }
}
