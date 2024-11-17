using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCodeLanguage
{
    internal class DataTypesDemo
    {
        internal static void BytesDemo()
        {
            Console.WriteLine("SByte Demo");
            sbyte val = -128;
            Console.WriteLine(val);
            Console.WriteLine(val.GetTypeCode());
            Console.WriteLine("Minimum value of SByte = "+ sbyte.MinValue);
            Console.WriteLine("Maximum value of SByte = "+sbyte.MaxValue);
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Byte Demo");
            byte val2 = 255;
            Console.WriteLine(val2);
            Console.WriteLine(val2.GetTypeCode());
            Console.WriteLine("Minimum value of Byte = " + byte.MinValue);
            Console.WriteLine("Maximum value of Byte = " + byte.MaxValue);

            Console.ReadKey();
            ShortsDemo();
        }

        internal static void ShortsDemo()
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine("UShort Demo");
            ushort val = 65000;
            Console.WriteLine(val);
            Console.WriteLine(val.GetTypeCode());
            Console.WriteLine("Minimum value = " + ushort.MinValue);
            Console.WriteLine("Maximum value = "+ushort.MaxValue);
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Short Demo");
            short val2 = 25000;
            Console.WriteLine(val2);
            Console.WriteLine(val2.GetTypeCode());
            Console.WriteLine("Minimum value = " + short.MinValue);
            Console.WriteLine("Maximum value = "+short.MaxValue);

            Console.ReadKey();
            IntegersDemo();
        }

        internal static void IntegersDemo()
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine("UInt Demo");
            uint val = 4000000000;
            Console.WriteLine(val);
            Console.WriteLine(val.GetTypeCode());
            Console.WriteLine("Minimum value = " + uint.MinValue);
            Console.WriteLine("Maximum value = " + uint.MaxValue);
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Int Demo");
            int val2 = 999999999;
            Console.WriteLine(val2);
            Console.WriteLine(val2.GetTypeCode());
            Console.WriteLine("Minimum value = " + int.MinValue);
            Console.WriteLine("Maximum value = " + int.MaxValue);

            Console.ReadKey();
            LongsDemo();
        }

        internal static void LongsDemo()
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine("ULong Demo");
            ulong val = 123456789012;
            Console.WriteLine(val);
            Console.WriteLine(val.GetTypeCode());
            Console.WriteLine("Minimum value = " + ulong.MinValue);
            Console.WriteLine("Maximum value = " + ulong.MaxValue);
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Long Demo");
            long val2 = -12342337363839;
            Console.WriteLine(val2);
            Console.WriteLine(val2.GetTypeCode());
            Console.WriteLine("Minimum value = " + long.MinValue);
            Console.WriteLine("Maximum value = " + long.MaxValue);

            Console.ReadKey();
            FloatDemo();
        }

        internal static void FloatDemo()
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Float Demo");
            float value = 12F;
            Console.WriteLine(value);
            Console.WriteLine(value.GetTypeCode());
            Console.WriteLine("Minimum value = " + float.MinValue);
            Console.WriteLine("Maximum value = " + float.MaxValue);

            float val2 = 12.243f;
            Console.WriteLine(val2);

            Console.ReadKey();
            DoubleDemo();
        }

        internal static void DoubleDemo()
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Double Demo");
            double value = 12D;
            Console.WriteLine(value);
            Console.WriteLine(value.GetTypeCode());
            Console.WriteLine("Minimum value = " + double.MinValue);
            Console.WriteLine("Maximum value = " + double.MaxValue);

            double val2 = 13.2d;
            Console.WriteLine(val2);

            Console.ReadKey();
            DecimalDemo();
        }

        internal static void DecimalDemo()
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Decimal Demo");
            decimal value = 12m;
            Console.WriteLine(value);
            Console.WriteLine(value.GetTypeCode());
            Console.WriteLine("Minimum value = " + decimal.MinValue);
            Console.WriteLine("Maximum value = " + decimal.MaxValue);

            decimal val2 = 12.34m;
            Console.WriteLine(val2);

            Console.ReadKey();
            CharacterDemo();
        }

        internal static void CharacterDemo()
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Character Demo");
            char ch = 'q';
            Console.WriteLine(ch);

            Console.ReadKey();
            StringDemo();
        }

        internal static void StringDemo()
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine("String Demo");
            string name = "Shiva Krishna Beeraboina";
            Console.WriteLine(name);
            BooleanDemo();
        }

        internal static void BooleanDemo()
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Boolean Values");
            bool value = true;
            Console.WriteLine(value);
            GetAllDefaultValues();
        }

        internal static void GetAllDefaultValues()
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine(default(string));
            Console.WriteLine(default(char));
            Console.WriteLine(default(sbyte));
            Console.WriteLine(default(byte));
            Console.WriteLine(default(short));
            Console.WriteLine(default(ushort));
            Console.WriteLine(default(int));
            Console.WriteLine(default(uint));
            Console.WriteLine(default(long));
            Console.WriteLine(default(ulong));
            Console.WriteLine(default(float));
            Console.WriteLine(default(double));
            Console.WriteLine(default(decimal));
            Console.WriteLine(default(bool));
        }

    }
}
