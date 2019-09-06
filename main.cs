using System;

class Coinstar
{
    static void Main()
    {
       
       double Qd;
       double Dd;
       double Nd;
       double Pd;
       double money;
       double moneysort;
       double final;
       string moneyString;

       Console.WriteLine("How much money do you want to enter?");

       moneyString = Console.ReadLine();
       money = double.Parse(moneyString);
       //Qd = money/25
       //Q = money%25
       Qd = money/.25;
       int Q = (int)Qd;
       moneysort = money-(Q*.25);
       //Dd = moneysort/10
       //D = moneysort%10
       Dd = moneysort/.10;
       int D = (int)Dd;
       moneysort = moneysort-(D*.10);
       //Nd = moneysort/5
       //N = moneysort%5
       Nd = moneysort/.05;
       int N = (int)Nd;
       moneysort = moneysort-(N*.05);

       Pd = moneysort/.01;
       int P = (int)Pd;
       moneysort = moneysort-(P*.01);
       
       final = money-(money*0.109);
       final = Math.Round(final, 2);

       Console.WriteLine("You've entered "+Q+" quarters, "+D+" dimes, "+N+" nickels, "+P+" pennies for a total of $"+money+".");

       Console.WriteLine("After fees, you have $" +final+ "!");


       
    }
}
