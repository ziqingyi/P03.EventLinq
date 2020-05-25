using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03.Utility
{
    public static class LinqCollectionExtension
    {
        public static IEnumerable<T> GetRandomInCollection<T>(this IEnumerable<T> t, int length)
        {

            if (t == null || !t.Any())
            {
                return null;
            }

            var totalCount = t.Count();
            if (totalCount < length)
            {
                return t;
            }

            return GetRandomListCore(t, length);


        }

        private static IEnumerable<T> GetRandomListCore<T>(this IEnumerable<T> t, int length)
        {
            List<int> randomList = GetRandomList4Int(length, t.Count());

            List<T> result = new List<T>();

            foreach (int i in randomList)
            {
                result.Add(t.ElementAt(i));
            }
            return result;
        }

        private static List<int> GetRandomList4Int(int lenght, int maxValue)
        {
            Random rd = new Random();
            List<int> randomList = new List<int>();

            while (true)
            {
                if (randomList.Count >= lenght)
                {
                    break;
                }

                var randomIndex = rd.Next(maxValue);
                if (randomList.Contains(randomIndex))
                {
                    continue;
                }

                randomList.Add(randomIndex);
            }
            return randomList;
        }



    }
}
