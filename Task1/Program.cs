//change next variables only incase price or tax change and it will change in all program
int forSmall = 25; //$
int forLarge = 35; //$
double taxRate = 0.06; 

Console.WriteLine("Islam's Carpet Cleaning Service");
Console.WriteLine("======================================");
Console.WriteLine("Charges:");
Console.WriteLine($"{forSmall:c} per small room");
Console.WriteLine($"{forLarge:c} per large room");
Console.WriteLine($"Sales tax rate is {taxRate:p}");
Console.WriteLine($"Estimates are valid for 30 days");
Console.WriteLine("======================================");

Console.WriteLine("Please Enter Number of small carpets: ");
int noOfSmall = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please Enter Number of large carpets: ");
int noOfLarge = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("======================================");
int cost= (noOfSmall*forSmall) + (noOfLarge*forLarge);
double tax = (cost * taxRate);
double totalEstimate = cost + tax;

Console.WriteLine($"Cost: {cost:c}");
Console.WriteLine($"Tax: {tax:c}");
Console.WriteLine("======================================");
Console.WriteLine($"Total estimate: {totalEstimate:c}");
Console.WriteLine($"This estimate is valid for 30 days");
