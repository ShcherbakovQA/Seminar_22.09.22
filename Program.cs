Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());

bool result;
bool del7;
bool del23;

if(a % 7 == 0)
{
    del7 = true;
}
else
{
    del7 = false;
}

if(a % 23 == 0)
{
    del23 = true;
}
else
{
    del23 = false;
}

if (del7 == true && del23 == true)
{
    result = true;
}
else
{
    result = false;
}

if (result == true)
Console.WriteLine("Верно!");

