using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day5
{
    internal static class StringPractice
    {
        public static void ConvertReverse(string str)
        {
            char[] characters = str.ToCharArray();
            for (int i = 0; i < characters.Length / 2; i++)
            {
                char temp = characters[i];
                characters[i] = characters[characters.Length - i - 1];
                characters[characters.Length - i - 1] = temp;
            }

            string newStr = new string(characters);
            Console.WriteLine(newStr);
        }

        public static void PrintReverse(string str)
        {
            for (int i = str.Length-1; i >= 0; i--)
                Console.Write(str[i]);

            Console.WriteLine();
        }

        public static void ReverseWords(string str)
        {
            char[] delimChar = {'.', ',', ':', ';', '=', '(', ')', '&', '[',
                            ']', '\"', '\'', '\\', '/', '!', '?', ' '};
            StringBuilder sb = new StringBuilder();

            List<string> wordsSplit = new List<string>();
            int currentPosition = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (delimChar.Contains(str[i]))
                {
                    if (i - currentPosition != 0)
                        wordsSplit.Add(str.Substring(currentPosition, i - currentPosition));
                    wordsSplit.Add(str[i].ToString());
                    currentPosition = i + 1;
                }
                else if (i == str.Length - 1)
                    wordsSplit.Add(str.Substring(currentPosition));
            }

            currentPosition = wordsSplit.Count - 1;
            for (int i = 0; i < wordsSplit.Count; i++)
            {
                char potential = wordsSplit[i][0];
                if (wordsSplit[i].Length == 1
                        && delimChar.Contains(potential))
                {
                    sb.Append(potential);
                }
                else
                {
                    potential = wordsSplit[currentPosition][0];

                    while (wordsSplit[currentPosition].Length == 1
                            && delimChar.Contains(potential))
                        currentPosition--;

                    sb.Append(wordsSplit[currentPosition]);
                    currentPosition--;
                }
            }

            Console.WriteLine(sb);
        }

        public static void ExtractPalindromes(string str)
        {
            char[] delimChar = {'.', ',', ':', ';', '=', '(', ')', '&', '[',
                            ']', '\"', '\'', '\\', '/', '!', '?', ' '};
            string[] wordsSplit = str.Split(delimChar);

            List<string> palindromeList = new List<string>();

            for (int i = 0; i < wordsSplit.Length; i++)
            {
                string word = wordsSplit[i];
                bool isPalindrome = true;

                if (word.Length == 0)
                    continue;
                for (int j = 0; j < word.Length / 2; j++)
                {
                    if (word[j] != word[word.Length - j - 1])
                    {
                        isPalindrome = false;
                        break;
                    }
                }

                if (isPalindrome)
                    palindromeList.Add(word);
            }

            palindromeList.Sort();

            for (int i = 0; i < palindromeList.Count; i++)
            {
                if (i == 0)
                    Console.Write(palindromeList[i]);
                else
                    Console.Write($", {palindromeList[i]}");
            }
            Console.WriteLine();
        }

        public static void ParseURL(string url )
        {
            Console.WriteLine(url);
            string protocol;
            string server;
            string resource;
            int protocolIndex = url.IndexOf("://");

            if (protocolIndex == -1)
                protocol = "";
            else
            {
                protocol = url.Substring(0, protocolIndex);
                url = url.Substring(protocolIndex + 3);
            }

            int resourceIndex = url.IndexOf('/');
            if (resourceIndex == -1)
                resource = "";
            else
            {
                resource = url.Substring(resourceIndex + 1);
                url = url.Substring(0, resourceIndex);
            }

            server = url;

            Console.WriteLine($"[protocol] = {protocol}");
            Console.WriteLine($"[server] = {server}");
            Console.WriteLine($"[resource] = {resource}");
            Console.WriteLine();
        }
    }
}
