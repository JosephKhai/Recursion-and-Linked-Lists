using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercises
{
    public class RecursionLib {

        public int FactorialRec(int num, int ans = 1) {

            if (num == 0) {
                return ans;
            }

            return FactorialRec(num-1, ans*num);
            // return num*FactorialRec(num-1)
        }

        /// <summary>
        /// Creates a list of numbers from 1 to num.  Initialise numsList with empty List.
        /// </summary>
        /// <param name="num"></param>
        /// <param name="numsList"></param>
        /// <returns></returns>
        public List<int> CountRec(int num, List<int> numsList) {
            int i = numsList.Count;
            if(numsList.Count == num)
            {
                return numsList;
            }
            numsList.Add(i + 1);
            return CountRec(num, numsList);
           
        }

        /// <summary>
        /// Returns the result of num to the power of pow.
        /// </summary>
        /// <param name="num"></param>
        /// <param name="pow"></param>
        /// <param name="ans"></param>
        /// <returns></returns>
        public long ExponentialRec(int num, int pow, long ans = 1) {
            if (pow == 0)
            { // base case
                return 1;
            }
            else 
            {
                return num * ExponentialRec(num, pow - 1);
            }
            //return 1;
                        

        }

        /// <summary>
        /// Returns word (string) in reverse order.  Treats all characters the same.
        /// </summary>
        /// <param name="word"></param>
        /// <param name="revWord"></param>
        /// <returns></returns>    
        public string WordReverseRec(string word, string revWord = "") {
            //char[] array = new char[word.Length];
            //int forward = 0;
            //for (int i = word.Length - 1; i >= 0; i--)
            //{
            //    array[forward++] = word[i];
            //}
            //return new string(array);

            if(word.Length == 0)
            {
                return word;
            }
            return word[word.Length - 1] + WordReverseRec(word.Substring(0, word.Length - 1));
        }



    }
}
