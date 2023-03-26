namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hesap Makinesi\n");
            Console.Write("işlem yapmak istediğiniz 1. sayıyı giriniz: ");
            double sayi1=double.Parse(Console.ReadLine());
            Console.Write("yapmak istediğiniz işlemi seçiniz(+),(-),(/),(*),(%): ");
            string islem=Console.ReadLine();    
            Console.Write("işlem yapmak istediğiniz 2. sayıyı giriniz: ");
            double sayi2=double.Parse(Console.ReadLine());

        }
    }
}