using System;
using System.Collections.Generic;
using System.Text;


namespace ExtendTest
{
    class Program
    {
        public static void ExtendTest()
        {
            var ct = SprotoType.RegisterEntry.GetClassTypes();

            var md = new SprotoType.MyData();
            md.type = SprotoType.MyCar.Pig;
            md.name = "pig";
            md.int64 = Int64.MaxValue;
            md.uint64 = UInt64.MaxValue;
            md.uint32 = UInt32.MaxValue;
            md.Stream = new byte[] { 1, 2, 3, 4 };

            var data = md.encode();

            var md2 = new SprotoType.MyData(data);
            assert(md2.name == "pig");
            assert(md2.type == SprotoType.MyCar.Pig);
            assert(md2.int64 == Int64.MaxValue);
            assert(md2.uint64 == UInt64.MaxValue);
            assert(md2.uint32 == UInt32.MaxValue);
        }

        public static void UnknownFieldTest()
        {
            var md = new SprotoType.MyData();
            md.type = SprotoType.MyCar.Pig;
            md.name = "pig";
            md.address = "techotaku";
            md.int64 = Int64.MaxValue;
            md.uint64 = UInt64.MaxValue;
            md.uint32 = UInt32.MaxValue;

            var data = md.encode();

            var md2 = new SprotoType.FakeMyData(data);


        }

        public static void assert(bool condition)
        {
            if (!condition)
                throw new Exception();
        }


        static void Main(string[] args)
        {
            UnknownFieldTest();
            ExtendTest();
            
        }
    }
}
