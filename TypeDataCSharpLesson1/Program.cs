using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeDataCSharpLesson1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Integer types
            // An unsigned integer
            byte a = byte.MinValue; //this is alias
            Byte b = byte.MaxValue;
            Console.WriteLine($"Byte type - range is {a} to {b}");
            a = default;
            Console.WriteLine("default byte " + a);

            // Signed integer
            sbyte c = sbyte.MinValue; // this is alias
            SByte d = SByte.MaxValue;
            Console.WriteLine($"SByte type - range is {c} to {d}");
            c = default;
            Console.WriteLine("default sbyte " + c);

            // An unsigned integer
            ushort e = ushort.MinValue; // this is alias
            UInt16 f = UInt16.MaxValue;
            Console.WriteLine($"Ushort type - range is {e} to {f}");
            e = default;
            Console.WriteLine("default ushort " + e);

            // Signed integer
            short g = short.MinValue; // this is alias
            Int16 h = Int16.MaxValue;
            Console.WriteLine($"Short type - range is {g} to {h}");
            g = default;
            Console.WriteLine("default short " + g);

            // An signed integer
            uint i = uint.MinValue; // this is alias
            UInt32 j = UInt32.MaxValue;
            Console.WriteLine($"Uint type - range is {i} to {j}");
            i = default;
            Console.WriteLine("default uint " + i);

            // Signed integer
            int k = int.MinValue; // this is alias
            Int32 l = Int32.MaxValue;
            Console.WriteLine($"Int type - range is {k} to {l}");
            k = default;
            Console.WriteLine("default int " + k);

            // An unsigned integer
            ulong m = ulong.MinValue; // this is alias
            UInt64 n = UInt64.MaxValue;
            Console.WriteLine($"Ulong type - range is {m} to {n}");
            m = default;
            Console.WriteLine("default ulong " + m);

            // Signed integer
            long o = long.MinValue; // this is alias
            Int64 p = Int64.MaxValue;
            Console.WriteLine($"Long type - range is {o} to {p}");
            p = default;
            Console.WriteLine("default long " + p);
            #endregion

            #region Real type
            // Real types are designed to represent fractional numbers

            // Signed real
            float q = float.MinValue; // this is alias
            Single r = Single.MaxValue;
            Console.WriteLine($"Float type - range is {q} to {r}");
            q = default;
            Console.WriteLine("default float " + q);

            double s = double.MinValue; // this is alias
            Double t = Double.MaxValue;
            Console.WriteLine($"Double type - range is {s} to {t}");
            s = default;
            Console.WriteLine("default double " + s);
            #endregion

            #region Decimal type
            decimal u = decimal.MinValue; // this is alias
            Decimal v = Decimal.MaxValue;
            Console.WriteLine($"Decimal type - range is {u} to {v}");
            u = default;
            Console.WriteLine("default decimal " + u);
            #endregion

            #region Logical type
            bool w = true; // this is alias
            Boolean x = false;
            Console.WriteLine($"Boolean type {w} or {x}");
            w = default;
            Console.WriteLine("default boolean " + w);
            #endregion

            #region Character type
            char y = 'a'; // this is alias
            Char z = 'A';
            Console.WriteLine($"Char type - {y} and {z}");
            y = default;
            Console.WriteLine("default char " + y); // default char is \0 or U+0000
            #endregion

            #region String type
            string firstString = "Hello"; // this is alias
            String secondString = "world!!!";
            Console.WriteLine(firstString + " " + secondString);
            firstString = default;
            Console.WriteLine("default string " + firstString); //defaut string is null
            #endregion
        }
    }
}
