using System;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            PrintPattern(n);

            int n2 = 6;
            PrintSeries(n2);

            string s = "09:15:35PM";
            string t = UsfTime(s);
            Console.WriteLine(t);

            int n3 = 110;
            int k = 11;
            UsfNumbers(n3, k);

            string[] words = new string[] { "abcd", "dcba", "lls", "s", "sssll" };
            PalindromePairs(words);
        }
        private static void PrintPattern(int n)
        {
            try
            {
                Console.WriteLine();
                for (int i = n; i >= 0; i--)
                {
                    for (int j = 1; j <= i; j++)
                        Console.Write(j.ToString());
                    Console.WriteLine();
                }
            }
            catch
            {
                Console.WriteLine("Exception Occured while computing printPattern");
            }
        }
        private static void PrintSeries(int n2)
        {
            try
            {
                int size = n2; //there are n2 type combinations
                int[] sumArray = new int[size]; //create array to store sums
                for (int i = 0; i < n2; i++)
                {
                    int sum = 0;
                    for (int num = 1; num <= i + 1; num++)
                    {
                        sum = sum + num;
                    }
                    sumArray[i] = sum;
                }
                Console.WriteLine(string.Join(",", sumArray));
            }
            catch
            {
                Console.WriteLine("Exception Occured while computing printSeries");
            }
        }
        public static string UsfTime(string s)
        {
            try
            {
                string s0 = s.Substring(0, 8);
                DateTime d = DateTime.ParseExact(s0, "HH:mm:ss", null);
                if (s[8] == 'P')
                {
                    d = d.AddHours(12);
                }
                string ans;
                int second_amount = d.Hour * 60 * 60 + d.Minute * 60 + d.Second;
                int trans_hour = second_amount / (60 * 45);
                int third_amount = second_amount - trans_hour * 60 * 45;
                int trans_minute = third_amount / 45;
                int trans_second = third_amount % 45;

                ans = trans_hour.ToString() + ":" + trans_minute.ToString() + ":" + trans_second.ToString();

                Console.WriteLine(ans);
            }
            catch
            {
                Console.WriteLine("Exception Occured while computing UsfTime");
            }
            return null;
        }


        public static void UsfNumbers(int n3, int k)
        {
            try
            {
                string n = "";
                int i;
                for (i = 1; i < n3 + 1; i++)
                {
                    if ((i - 1) % 11 == 0)
                    {
                        n += "\n";
                    }
                    if ((i % 3 == 0) && (i % 5 == 0) && (i % 7 == 0))
                    {
                        n += " USF";
                    }
                    if ((i % 5 == 0) && (i % 7 == 0))
                    {
                        n += " SF";
                    }
                    else if ((i % 3 == 0) && (i % 5 == 0))
                    {
                        n += " US";
                    }
                    else if (i % 7 == 0)
                    {
                        n += " F";
                    }
                    else if (i % 5 == 0)
                    {
                        n += " S";
                    }
                    else if (i % 3 == 0)
                    {
                        n += " U";
                    }
                    else
                    {
                        n += (" " + i.ToString());
                    }
                }
                Console.WriteLine(n);
            }
            catch
            {
                Console.WriteLine("Exception Occured while computing UsfTime");
            }
        }
        public static void PalindromePairs(string[] words)
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (IsPalindrome(words[i], words[j]))
                    {
                        Console.WriteLine("[" + i + "," + j + "]");
                    }
                }
            }
        }

        public static bool IsPalindrome(string word1, string word2)
        {
            try
            {
                int i = 0;
                int j = word2.Length - 1;
                while (i < word1.Length && j >= 0)
                {
                    if (word1[i] != word2[j])
                    {
                        return false;
                    }
                    
                    i += 1;
                    j -= 1;

                }
                if (word1.Length < word2.Length)
                {
                    i = 0;
                    while (i < j)
                    {
                        if (word2[i] != word2[j])
                        {
                            return false;
                        }
                   
                        i += 1;
                        j -= 1;
                    }
                }
                else if (word1.Length > word2.Length)
                {
                    j = word1.Length - 1;
                    while (i < j)
                    {
                        if (word1[i] != word1[j])
                        {
                            return false;
                        }
                
                        i += 1;
                        j -= 1;
                    }
                }
                else
                {
                    return true;
                }
            }
            catch
            {

            }

    }
        public static void Stones(int n4)
        {
            try
            {
                // Write your code here
            }
            catch
            {
                Console.WriteLine("Exception occured while computing Stones()");
            }
        }

    }
}
    
