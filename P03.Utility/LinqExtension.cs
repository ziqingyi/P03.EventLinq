using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03.Utility
{
    public static class LinqExtension
    {
        // this only apply on list, not for all collection
        public static List<T> GetRandomList<T>(this List<T> t, int length)
        {
            if (t == null || !t.Any())
            {
                return null;
            }

            var totalCount = t.Count;
            if (totalCount < length)
            {
                return t;
            }

            return GetRandomListCore(t, length);
        }

        private static List<T> GetRandomListCore<T>(this List<T> tList, int length)
        {
            List<int> randomList = GetRandomList4Int(length, tList.Count);

            List<T> result = new List<T>();
            //for (int i = 0; i < tList.Count; i++)
            //{
            //    if (!randomList.Contains(i))
            //    {
            //        continue;
            //    }
            //    result.Add(tList[i]);
            //}

            foreach (int i in randomList)
            {
                result.Add(tList[i]);
            }


            return result;
        }

        private static List<int> GetRandomList4Int(int length, int maxValue)
        {
            Random rd = new Random();
            List<int> randomList = new List<int>();

            while (true)
            {
                if (randomList.Count >= length)
                {
                    break;
                }

                var randomIndex = rd.Next(maxValue);
                if (randomList.Contains(randomIndex))
                {
                    //how to define same? can use delegate to compare same or diff. eg.same id
                    continue;
                }

                randomList.Add(randomIndex);
            }
            return randomList;
        }
    }
}
