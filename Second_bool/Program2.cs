int GetNumber()
{
    Console.WriteLine("Введите число");
    return Convert.ToInt32(Console.ReadLine());
}

bool CheckMod(int a,int mod)
{
    return (a % mod == 0);
}

int a = GetNumber();
bool result = (CheckMod(a,7) && CheckMod(a,23));

if (CheckMod(a,7) && CheckMod(a,23))
Console.WriteLine("Верно!");
else
Console.WriteLine("Не верно!");




//if(a % 7 == 0)
//{
//    del7 = true;
//}
//else
//{
//    del7 = false;
//}
//if(a % 23 == 0)
//{
//    del23 = true;
//}
//else
//{
//    del23 = false;
//}

// if (del7 == true && del23 == true)
// {
//    result = true;
// }
// else
// {
//    result = false;
// }
















