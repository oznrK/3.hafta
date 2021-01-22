using System;

namespace _3.hafta
{
    class Program
    {
        static void Main(string[] args)
        {
            //Add();
            //Add();
            //Add();
            //Add();
            //var result = Add2(20, 30);

            //int number1 = 20;
            //int number2 = 100;
            //var result2 = Add3(number1, number2);
            //Console.WriteLine(result2);
            
            Console.WriteLine(Multiply(2,4,5));

            Console.WriteLine(Add4(1,2,3,4,5,6));
            Console.ReadLine();
        }

        static void Add()
        {
            Console.WriteLine("Added!  ");
        }

        static int Add2(ref int number1, int number2=30 )  //=30 demek; eğer number2 değeri verlmezse 30 olarak kulan verilirse verileni kullan. buna default değer denir ve her zaman en sondaki değere veilir 
            //yani number1 e verilmez. ama birden fazla default verilebilir sondaki değerler olmak şartıyla
        {
            var result = number1 + number2;
            return result; //void git şu işlemi yap demek 
        }

        static int Add3(int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;
        } //ref de num1 in mutlaka değer set edilmş olması gerekiyor out da böyle bir zorunluluk yok 

        static int Multiply(int number1, int number2, int number3)
        {
            return number1 * number2 * number3;
        }
        static int Add4(params int[] numbers)
        {
            return numbers.Sum();
        }
    }
}
