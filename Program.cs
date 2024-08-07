double bmi;
Console.WriteLine("Please enter a height");
float height = float.Parse(Console.ReadLine());
Console.WriteLine("Please enter your weight");
float weight = float.Parse(Console.ReadLine());;
 bmi = weight / (height*height);
Console.WriteLine(bmi);
if (bmi < 18.5)
{
    Console.WriteLine("Underweight");
}
else if (bmi < 25.0)
{
    Console.WriteLine(" Normal");
}
else if (bmi < 30.0)
{
    Console.WriteLine(" Overweight");

}
else
{
    Console.WriteLine(" Obese");
}
