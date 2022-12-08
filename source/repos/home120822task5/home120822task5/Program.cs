

Console.WriteLine("Zemet olmasa yashinizi daxil edin.");
int Age=Convert.ToInt32 (Console.ReadLine());

if (Age >= 18)
{
    Console.WriteLine("Suruculuk vesiqesi ala bilersiniz");
}
else
{
    int Years = 18 - Age;


    Console.WriteLine("Suruculuk vesiqesi ala bilmek ucun gozlemeli olduqunuz il: " + Years);
}