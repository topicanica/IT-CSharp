using System;

namespace zad1i2
{
    class Program
    {
        /* 2.Napisati program koji sadrži dvije varijable, jednu tipa int, a drugu tipa long u koju će
        biti zapisana najveća moguća vrijednost za tip long. Varijablu tipa long treba
        pridružiti varijabli tipa int, s tim da se obradi iznimka ako dođe do preljeva
        (overflow).*/
        public int CheckedMethod(long longNumber,int intNumber)
        {
            int z = 0;
            try
            {
                z = checked((int)longNumber + intNumber);
            }
            catch (System.OverflowException e)
            {
                Console.WriteLine("CHECKED and CAUGHT:  " + e.ToString());
            }
            return z;
            
        }
        public void Add()
        {
            long longNumber = long.MaxValue;
            int intNumber = 2;
            int result = CheckedMethod(longNumber, intNumber);
            if (result!=0)
                Console.WriteLine($"Result is: {result}");

        }
        static void Main(string[] args)
        {
            /*1.Napisati program koji upisuje dva cjelobrojna broja i ispisuje rezultat dijeljenja ta dva
            broja. Rezultat treba ispisati u sljedećim formatima (Currency, Integer, Scientific,
            Fixed-point, General, Number, Hexadecimal).
            Prilikom upisa nekog podatka sa tipkovnice, podatak se učitava kao tip string, a ako
            nam treba tip int moramo ga pretvoriti uz pomoć ugrađenih metoda.
            Pripaziti da se obrade sve iznimke 
            */
            Console.WriteLine("Enter two numbers:");
            string num1=Console.ReadLine();
            string num2 = Console.ReadLine();
            int result = Convert.ToInt32(num1) / Convert.ToInt32(num2);

            //Currency
            decimal moneyValue = Convert.ToDecimal(num1) / Convert.ToDecimal(num2);
            Console.WriteLine(moneyValue.ToString("C2", System.Globalization.CultureInfo.GetCultureInfo("en-au")));
            //Console.WriteLine(String.Format("{0:C2}", moneyValue));

            //Intiger
            Console.WriteLine($"result in intiger is: {result}");

            //Scientific 
            Console.WriteLine("result in scinetific is: ", String.Format("{0:E2}", result));

            //Fixed point
            Console.WriteLine("result in fixed point is: ",String.Format("{0:F2}", result));

            //General
            Console.WriteLine("result in general is: ", String.Format("{0:G2}", result));

            //Number
            Console.WriteLine("result in number is: ", String.Format("{0:N}", result));
            Console.WriteLine(result.ToString("N"));

            //Hexadecimal
            Console.WriteLine("result in hexadecimal is: ", result.ToString("X"));

            var p = new Program();
            p.Add();

        }
    }
}

