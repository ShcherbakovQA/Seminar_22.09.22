double GetDistance(double x1, double x2,double y1, double y2)
{
    double distance = Math.Sqrt(Math.Pow((x2 - x1),2) + Math.Pow((y2 - y1),2));
    return distance;
}

double Getnumber(string name)
{
    Console.WriteLine("Введите координату " + name);
    return Convert.ToDouble(Console.ReadLine());
}

double x1 = Getnumber("x1");
double x2 = Getnumber("x2");
double y1 = Getnumber("y1");
double y2 = Getnumber("y2"); 

Console.WriteLine("Расстояние между точками = "+ GetDistance(x1, x2, y1, y2));