using System.Net.Http.Headers;

{
Console.WriteLine("är det fint väder");
string svar = Console.ReadLine();
if(svar == "j" || svar == "J")
Console.Write("Vi går på picknick");
else if(svar == "n" || svar == "N")
Console.Write("vi stannar inne och spelar dator");
else
Console.WriteLine("jag förstår inte");
}

