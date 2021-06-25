using System;
using System.Collections.Generic;
using System.Linq;

namespace CommonNumbersTest
{
    public class CommonNumbers
    {
        public CommonNumbers()
        {
        }


        public List<string> CreateList(string[] list1, string[] list2)
        {
            List<string> commonList = new List<string>();
            commonList.Add(FindCommon(list1));
            commonList.Add(FindCommon(list2));

            return commonList;
        }

        public string FindCommon(string[] list)
        {
            string commonNumbers = "";
            string split1 = list[0].Replace(" ", "");
            List<string> string1 = split1.Split(',').ToList();

            string split2 = list[1].Replace(" ", "");
            List<string> string2 = split2.Split(',').ToList();

            foreach (string i in string1)
            {
                foreach (string j in string2)
                {
                    if (i.Equals(j))
                    {
                        commonNumbers += i + ",";
                    }
                }
            }

            return commonNumbers.TrimEnd(',');
        }
    }
}
