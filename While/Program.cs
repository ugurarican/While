Console.WriteLine("While döngü kullanım projesine giriş yaptınız.");
Console.WriteLine("İlgili tuşlamaları yaparak programları çalıştırabilirisiz.");
Console.WriteLine("Hatırlatma: Yanlış tuşlama yapmayınız !!!");
Console.WriteLine("1-> Kendime inanıyorum yazar.");
Console.WriteLine("2-> 1 ile 20 arasındaki sayıları yazar.");
Console.WriteLine("3-> 1 ile 20 arasındaki çift sayıları yazar.");
Console.WriteLine("4-> 50 ile 150 arasındaki sayıları toplar.");
Console.WriteLine("5->1 ile 120 arasındaki tek ve çift sayıları toplar.");

void ILoveMe()
{
    int i=0;
    while (i <= 10) { 
    Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim!");
    i++;
    }
}
void Consecutive()
{
    int i=2;
    while (i < 20)
    {
        Console.WriteLine(i);
        i++;
    }
}
void Twin()
{
    int i=1;
    while (i < 20)
    {
        if (i % 2 == 0) { Console.WriteLine(i); i++; }
        else i++;
    }
}
void Total()
{
    int i = 51;
    int total = 0;
    while (i < 150)
    {
        total = total + i;
        i++;
    }
    Console.WriteLine($"50 ie 150 arasındaki sayıların toplam: {total}");
}
void OddEven()
{
    int odd = 0;
    int even = 0;
    int i = 0;
    while(i < 120)
    {
        if ((i % 2) == 0)
        {
            even = even + i;
            i++;
        }
        else
        {
            odd = odd + i;
            i++;
        }
    }
    Console.WriteLine($"1 ile 120 arasındaki tek sayıların toplamı: {odd}");
    Console.WriteLine($"1 ile 120 arasındaki çift sayıların toplamı: {even}");
}
string input = Console.ReadLine();
switch (input)
{
    case "1":
        ILoveMe();
        break;
    case "2":
        Consecutive();
        break;
    case "3":
        Twin();
        break;
    case "4":
        Total();
        break;
    case "5":
        OddEven();
        break;
    default:
        Console.WriteLine("Dünyayı yoketme başlatılıyor ..");
        int i = 10;
        while (i >= 0)
        {
            Console.WriteLine(i);
            Thread.Sleep(500);
            i --;
        }    
        break;
}