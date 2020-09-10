using System;

namespace converfromdenary
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            string hex = "";
            int pow = 0;
            
            string convertto;
            int z = 0;

            // selecting what to convert from and to


            Console.WriteLine("What do you want to convert to?");
            convertto = Console.ReadLine();
            if (convertto.ToUpper() == "BINARY")
            {
                z = 2;
            }
            else if (convertto.ToUpper() == "HEXIDECIMAL")
            {
                z = 16;
            }


            Console.WriteLine("Enter number to be converted to hexidecimal.");
            num = Convert.ToInt32(Console.ReadLine());

            //what power

            pow = FindPow(num, z);


            // converting

            hex = ConvertFromDenary(num, z, pow);

            Console.WriteLine(hex);
            Console.ReadLine();
        }
        static int FindPow(int num, int z)
        {
            int pow = 0;
            if (num > (z - 1))
            {
                while (Convert.ToInt32(Math.Floor(num / Math.Pow(z, pow + 1))) >= 1)
                {
                    pow += 1;
                }
            }
            return pow;
        }

        static string ConvertFromDenary(int num, int z, int pow)
        {
            string hex = "";
            string ins;
            int intins;
            string[] letters = { "A", "B", "C", "D", "E" };
            

            for (int y = pow; y >= 0; y--)
            {
                intins = Convert.ToInt32(Math.Floor(num / Math.Pow(z, y)));
                ins = Convert.ToString(intins);

                if (intins > 9)
                {
                    ins = letters[Convert.ToInt32(ins) - 10];
                }
                hex = hex + ins;
                num = Convert.ToInt32(num % (Math.Pow(z, y)));
            }
            return hex;
        }
    }
}
