// See https://aka.ms/new-console-template for more information
Console.WriteLine("enter name");
string name= Console.ReadLine();
Console.WriteLine("enter age");
int age=Convert.ToInt32(Console.ReadLine());
if (age>18)
{
    Console.WriteLine("qualified");
    
}
else
{
    Console.WriteLine("underage");

}
Console.WriteLine("enter gender");
char gender=Convert.ToChar(Console.ReadLine());
Console.WriteLine("enter mark");
int mark=Convert.ToInt32(Console.ReadLine());
if(mark>=90 & mark <=100)
{
    Console.WriteLine("excellent");


}

else if (mark >= 80 & mark < 90)
{
    Console.WriteLine("verygood");


}

else if (mark >= 70 & mark < 80)
{
    Console.WriteLine("good");


}

else if (mark >= 60 & mark <70)
{
    Console.WriteLine("avarage");


}

else if (mark >= 50 & mark <60)
{
    Console.WriteLine("poor");


}
else
{
    Console.WriteLine("fail");
}
