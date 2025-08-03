// نسال عن عدد السجاد الصغير
Console.Write("Enter number of small rugs");
int smallrugs =
int.Parse(Console.ReadLine());
//نساب عن عدد السجاد الكبير
Console.Write("Enter number of large rugs");
int largerags =
    int.Parse(Console.ReadLine());
//السعر والضريبه6ز6
double smallragPrice = 25.0;
double largerugPraice = 35.0;
double taxRate = 0.06;
//الاجمالي قبل الضريبه
double totalBeforeTax = (smallrugs * smallragPrice)+ (largerags * largerugPraice);
//الضريبه
double taxAmount = totalBeforeTax * taxRate;
double total = totalBeforeTax + taxAmount;
//الفتوره
Console.WriteLine();
Console.WriteLine("bill");
Console.WriteLine("small rug price: 25$");
Console.WriteLine("large rug price:35$");
Console.WriteLine("tax rate:6%");
Console.WriteLine($"total before tax : {taxAmount:f2}");
Console.WriteLine($"tax amount: {total:f2}");
Console.WriteLine($" total after tax : {total :f2}");
Console.WriteLine("this offer is valid for 30 days only");
Console.WriteLine();










