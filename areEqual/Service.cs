using System.Collections.Generic;
namespace areEqual
{
    public static class Service
    {
        private static List<char> AddValues(List<char> list, int count)
        {
            List<char> newList = list;
            for (int i = 0; i < count; i++)
            {
                newList.Add('-');
            }
            return newList;
        }

        private static List<char> ConvertToList(string text)
        {
            List<char> newList = new List<char>();

            foreach(char n in text)
            {
                newList.Add(n);
            }

            return newList;
        }

        private static string ConvertToString(List<string> list)
        {
            return string.Join("", list);
        }

        public static string CheckStrings(string one, string two)
        {
            if (one == two)
            {
                return "strings are identical";
            }
            else
            {
                return SearchInequality(one, two);
            }
        }

        public static string SearchInequality(string one, string two)
        {
            List<char> listOne = ConvertToList(one);
            List<char> listTwo = ConvertToList(two);

            List<string> finalList = new List<string>();
            int count;
            int diff;

            if (listOne.Count < listTwo.Count)
            {
                count = listTwo.Count;
                diff = listTwo.Count - listOne.Count;
                listOne = AddValues(listOne, diff);
            }
            else if(listOne.Count > listTwo.Count)
            {
                count = listOne.Count;
                diff = listOne.Count - listTwo.Count;
                listTwo = AddValues(listTwo, diff);
            }
            else
            {
                count = listOne.Count;
            }

            for (int index = 0; index < count; index++)
            {
                if (listOne[index] == listTwo[index])
                {
                    finalList.Add(listOne[index].ToString());
                }
                else
                {
                    finalList.Add("[" + listOne[index] + "|" + listTwo[index] + "]");
                }
            }
            return ConvertToString(finalList);
        }
    }
}


