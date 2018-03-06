using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Mobile
{
    [StructLayout(LayoutKind.Sequential)]
    class Program : SmartPhone
    {
        public int a = 10;
        static void Main(string[] args)
        {
            ISmartPhone isp = new SmartPhone() { ModelName = "ABC", BrandName = "DEF", Os = "AAA", Id = -1 };
            IBasicPhone ibp = new BasicPhone() { ModelName = "ABC", BrandName = "DEF", SoftwareType = "BBB", Id = -1 };


            ibp.GetMacId(ibp.BrandName, ibp.Id);
            isp.GetMacId(isp.BrandName, isp.Id);

            Example.main();

            Console.WriteLine(System.Runtime.InteropServices.Marshal.SizeOf(typeof(SmartPhone)));
            Console.WriteLine(System.Runtime.InteropServices.Marshal.SizeOf(typeof(Program)));
        }
    }

    [StructLayout(LayoutKind.Sequential)]
    class SmartPhone : ISmartPhone
    {
        public string ModelName { get; set; }
        public int Id { get; set; }
        public string BrandName { get; set; }
        public string GetMacId(string brandname, int id)
        {
            try
            {
                if (id < 0)
                {
                    throw new NegativeNumberException("Got Negative Number");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }


            return brandname + id;
        }

        public string Os { get; set; }
    }

    class BasicPhone : IBasicPhone
    {
        public string ModelName { get; set; }
        public int Id { get; set; }
        public string BrandName { get; set; }
        public string GetMacId(string brandname, int id)
        {
            try
            {
                if (id < 0)
                {
                    throw new NegativeNumberException("Got Negative Number");
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return brandname + id;
        }

        public string SoftwareType { get; set; }
    }
}
