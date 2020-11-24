using System;

namespace Ativi18_fixacao_Phillipe
{
    class Program
    {
        static void Main(string[] args)
        {
            Nullable<int> x = null;
            long? y = null;
            ushort? z = null;
            double? t = null;
            x = 34;
            y = 65000000;
            z = 500;
            t = 7.50;
            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.HasValue);
            Console.WriteLine(z.Value) ;
        }
    }
}
