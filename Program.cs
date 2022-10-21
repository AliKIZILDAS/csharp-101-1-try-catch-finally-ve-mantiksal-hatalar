using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Br sayi giriniz:");
                int sayi=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Girmiş olduğunuz sayi:"+sayi);
            }
            
            catch (Exception ex)
            {
                Console.WriteLine("Hata "+ex.Message.ToString());
            }
            
            finally
            {
                Console.WriteLine("İşlem tamamlandı.");    
            }
            try
            {
               //int a=int.Parse(null);
               //int a=int.Parse("test");
                int a=int.Parse("200000000000");               
            }
            catch (ArgumentNullException ex)
            {                
                Console.WriteLine("Boş değer girdiniz.");
                Console.WriteLine(ex);
            }
            catch (FormatException ex)
            {                
                Console.WriteLine("Veri tipi uygun değil.");
                Console.WriteLine(ex);
            }
            catch (OverflowException ex)
            {                
                Console.WriteLine("Çok küçük yada çok büyük değer girdiniz.");
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("İşlem başarıyla tamamlandı.");
            }   

            bool b=int.TryParse(Console.ReadLine(), out int result);
            Console.WriteLine(b);      
                       
        }
    }
}