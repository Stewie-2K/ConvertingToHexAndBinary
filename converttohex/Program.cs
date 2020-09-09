using System;

namespace converttohex
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            string hex = "";
            int x = 0;
            int pow = 0;
            string ins;
            int intins;
            string[] letters = { "A", "B", "C", "D", "E" };
            string convertto;
            int z=0;

            // selecting what to convert from and to


            Console.WriteLine("What do you want to convert to?");
            convertto = Console.ReadLine();
            if (convertto.ToUpper() == "BINARY")
            {
                z = 2;
            }else if (convertto.ToUpper() == "HEXIDECIMAL")
            {
                z = 16;
            }





                Console.WriteLine("Enter number to be converted to hexidecimal.");
            num = Convert.ToInt32(Console.ReadLine());

            //what power

            if (num > (z-1))
            {
                while (Convert.ToInt32(Math.Floor(num / Math.Pow(z, pow + 1))) >= 1)
                {
                    pow += 1;
                }
            }


            // converting

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

            Console.WriteLine(hex);
            Console.ReadLine();
        }
    }
}
