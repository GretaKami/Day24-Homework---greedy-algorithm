int coin2Euro = 0;
int coin1Euro = 0;
int coin50Cents = 0;
int coin20Cents = 0;
int coin10Cents = 0;
int coin5Cents = 0;
int coin2Cents = 0;
int coin1Cent = 0;

Console.Write($"Please enter the cost:  ");
double.TryParse(Console.ReadLine(), out double price);
Console.Write($"Please enter the amount paid: ");
double.TryParse(Console.ReadLine(), out double paidAmount);


double change = Math.Round(paidAmount - price, 2);
Console.WriteLine($"\nChange is {change}\n");

coin2Euro = (int) (change / 2);
change -= coin2Euro*2;
coin1Euro = (int) (change / 1);
change -= coin1Euro*1;
coin50Cents = (int)(Math.Round(change, 2) / 0.5);
change -= coin50Cents*0.5;
coin20Cents = (int)(Math.Round(change, 2) / 0.2);
change -= coin20Cents * 0.2;
coin10Cents = (int)(Math.Round(change, 2) / 0.1);
change -= coin10Cents * 0.1;
coin5Cents = (int)(Math.Round(change, 2) / 0.05);
change -= coin5Cents * 0.05;
coin2Cents = (int)(Math.Round(change, 2) / 0.02);
change -= coin2Cents * 0.02;
coin1Cent = (int)(Math.Round(change,2) / 0.01);

Console.WriteLine($"Coins given:");
Console.WriteLine($"2 euro coin - {coin2Euro}\n" +
    $"1 euro coin - {coin1Euro}\n" +
    $"50 cent coin - {coin50Cents}\n" +
    $"20 cent coin - {coin20Cents}\n" +
    $"10 cent coin - {coin10Cents}\n" +
    $"5 cent coin - {coin5Cents}\n" +
    $"2 cent coin - {coin2Cents}\n" +
    $"1 cent coin - {coin1Cent}");

