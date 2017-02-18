using System;
using System.Collections.Generic;
using System.Text;

namespace sprotoCsharp
{
    class TestCaseExtend : TestCaseBase
    {
        public override void run()
        {
            var md = new SprotoType.MyData();
            md.type = SprotoType.MyCar.Pig;
            md.name = "pig";
            md.int64 = Int64.MaxValue;
            md.uint64 = UInt64.MaxValue;
            md.uint32 = UInt32.MaxValue;

            var data = md.encode();

            var md2 = new SprotoType.MyData(data);
            assert(md2.name == "pig");
            assert(md2.type == SprotoType.MyCar.Pig);
            assert(md2.int64 == Int64.MaxValue);
            assert(md2.uint64 == UInt64.MaxValue);
            assert(md2.uint32 == UInt32.MaxValue);
        }
    }
}
