using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03.Utility
{
    public static class LinqExtension
    {
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

            List<int> randomList = GetRandomList4Int(length,totalCount);

            List<T> result = new List<T>();
            for (int i = 0; i < totalCount; i++)
            {
                if (!randomList.Contains(i))
                {
                    continue;
                }
                result.Add(t[i]);
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
