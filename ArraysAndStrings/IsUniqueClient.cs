using System;
using System.Collections.Generic;
using System.Text;
using ArraysAndStrings;

namespace ArraysAndStrings
{
    public class IsUniqueClient
    {
        IChapter1 c1;
        public IsUniqueClient(IChapter1 chapter1)
        {
            c1 = chapter1;
        }
        public int isUnique2(string s)
        {
            if (c1.isUniqueString(s))
                return 1;
            else return 2;
        }
    }
}
