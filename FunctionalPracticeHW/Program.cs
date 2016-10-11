
using System;
using System.Diagnostics;
using System.Linq;
using System.Collections.Generic;

public class Program
{

    /**
     * PART 0
     *
     * Write a function that calculates the sum of all the numbers in an array
     */

    public static int sumOfArray(int[] arr)
    {
        int sum = 0;
        foreach( int number in arr)
        {
            sum += number;
        }
        return sum;
    }

    /**
     * PART 1
     *
     * Write a function that takes two numbers as
     * arguments and computes the sum of those two numbers.
     */

    public static int sum(int a, int b)
    {
        // YOUR CODE HERE
        return a + b;
    }

    /**
     * PART 1B
     *
     * Write a function that handles any amount of numbers as input and
     * computes the sum of those numbers
     */

    public static int sumAll(params int[] nums)
    {
        // YOUR CODE HERE
        return sumOfArray(nums);
        //int sum = 0;
        //foreach (int num in nums)
        //{
        //    sum += num;
        //}

        //return sum;
    }

    /**
     * PART 2
     *
     * write a function that finds the Greatest Common Denominator of two numbers
     * - if no GCD exists, return 1
     */

    public static int GCD(int a, int b)
    {
        List<int> aFactors = new List<int>();
        List<int> bFactors = new List<int>();
        int gcd = 1;
        
        for (int i = 1; i <= a; i++)
        {
            if (a % i == 0)
            {
                aFactors.Add(i);
            }
        }
        for (int i = 1; i <= b; i++)
        {
            if (b % i == 0)
            {
                bFactors.Add(i);
            }
        }
        foreach (int aFactor in aFactors)
        {
            foreach (int bFactor in bFactors)
            {
                if (aFactor == bFactor)
                {
                    gcd = aFactor;
                }
            }
        }
        return gcd;
    }

    /**
     * PART 3
     *
     * write a function that prints out the Least Common Multiple of two numbers
     */

    public static int LCM(int a, int b)
    {
        // YOUR CODE HERE
        int gcd = GCD(a, b);
        int lcm = ((a * b) / gcd);
        if (lcm == 0)
        {
            lcm = 1;
        }
        return lcm;
    }

    /**
     * Part 4
     *
     * write a function the returns a FizzBuzz string for some number N (counting up from 1).
     * - for every number that isn't a multiple of 3 or 5, return a period "."
     * - for every number that is a multiple of 3 (but not 5), return "fizz"
     * - for every number that is a multiple of 5 (but not 3), return "buzz"
     * - for every number that is a multiple of 3 and 5, return "fizzbuzz"
     */

    public static string fizzbuzz(int n)
    {
        string[] text = new string[n];
        string fizzedText;
        for (int i = 1; i <= n; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                text[i - 1] = "fizzbuzz";
            } else if (i % 5 == 0 && i % 3 != 0)
            {
                text[i - 1] = "buzz";
            } else if (i % 3 == 0 && i % 5 != 0)
            {
                text[i - 1] = "fizz";
            } else
            {
                text[i - 1] = ".";
            }
        }
        fizzedText = string.Join("", text);
        return fizzedText;
    }

    /**
     * PART 5
     *
     * Define a function max() that takes two numbers as arguments
     * and returns the largest of them.
     */

    public static int max(int a, int b)
    {
        int maxNumber;
        if (a > b)
        {
            maxNumber =  a;
        } else
        {
            maxNumber = b;
        }
        
        return maxNumber;
    }

    /**
     * PART 6
     *
     * Define a function maxOfThree() that takes three
     * numbers as arguments and returns the largest of them.
     */

    public static int maxOfThree(int a, int b, int c)
    {
        // YOUR CODE HERE
        int maxNumber;
        if (a > b && a > c)
        {
            maxNumber = a;
        } else if (b > a && b > c)
        {
            maxNumber = b;
        } else
        {
            maxNumber = c;
        }
        return maxNumber;
    }

    /**
     * PART 6B
     *
     * Define a function maxOfAll() that takes any amount of
     * numbers as arguments and returns the largest of them.
     */

    public static int maxOfAll(params int[] nums)
    {
        // YOUR CODE HERE
        for (int i = 0; i < nums.Length; i++)
        {
            if(nums[0] < nums[i])
            {
                nums[0] = nums[i];
            }
        }
        return nums[0];
    }

    /**
     * PART 7
     *
     * Write a function isVowel() that takes a character (i.e. a string of length 1)
     * and returns true if it is a vowel, false otherwise.
     */

    public static bool isVowel(char c)
    {
        // YOUR CODE HERE
        char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
        int vowelIndex = Array.IndexOf(vowels, c);
        if (vowelIndex != -1)
            {
                return true;
            } else
            {
                return false;
            }
        }

    /**
     * PART 8
     *
     * Write a function rovarspraket() that will translate
     * a text into a "rövarspråket". That is, double every
     * consonant and place an occurrence of "o" in between.
     *
     * For example, rovarspraket("this is fun") should
     * return the string "tothohisos isos fofunon".

     */

    public static string rovarspraket(string s)
    {
        // YOUR CODE HERE
        string convertedString = "";
        foreach(char letter in s)
        {
            if (isVowel(letter))
            {
                convertedString += letter;
            }
            else
            {
                convertedString += (letter + "o" + letter);
            }
        }
        return convertedString;
    }

    /**
     * Part 9
     *
     * Define a function reverse() that computes
     * the reversal of a string. For example,
     * reverse("skoob") should return the
     * string "books".
     */

    public static string reverse(string str)
    {
        // YOUR CODE HERE
        string reversedText = "";
        for (int i = str.Length - 1; i >= 0; i--)
        {
            reversedText += str[i];
        }
        return reversedText;
    }

    /**
     * Part 10
     *
     * Write a function findLongestWord() that takes an
     * string returns the first, longest word in the string.
     *
     * i.e. findLongestWord("book dogs") should return "book"
     */

    public static string findLongestWord(string sentence)
    {
        // YOUR CODE HERE
        //char[] delim = { ' ' };
        string[] eachWord = sentence.Split(new Char[] { ' ', '\''} );
        for (int i = 1; i < eachWord.Length; i++)
        {
            if (eachWord[0].Length < eachWord[i].Length)
            {
                eachWord[0] = eachWord[i];
            }
        }
        string largestWord = eachWord[0];
        return largestWord;
    }

    public static void Main()
    {
        Debug.Assert(sumOfArray(new int[] { 1, 2 }) == 3);
        Debug.Assert(sumOfArray(new int[] { }) == 0);
        Debug.Assert(sumOfArray(new int[] { 1, 2, 3 }) == 6);
        Debug.Assert(sumOfArray(new int[] { 10, 9, 8 }) == 27);

        Debug.Assert(sum(8, 11) == 19);
        Debug.Assert(sum(4, 100) == 104);

        Debug.Assert(sumAll(8, 11) == 19);
        Debug.Assert(sumAll(4, 100) == 104);
        Debug.Assert(sumAll(8, 11, 20, 30, 11) == 80);
        Debug.Assert(sumAll(4, 100, 1, 4, -10, 15, 21) == 135);

        Debug.Assert(GCD(5, 1) == 1);
        Debug.Assert(GCD(15, 3) == 3);
        Debug.Assert(GCD(15, 5) == 5);
        Debug.Assert(GCD(50, 20) == 10);

        Debug.Assert(LCM(10, 10) == 10);
        Debug.Assert(LCM(2, 5) == 10);
        Debug.Assert(LCM(3, 6) == 6);
        Debug.Assert(LCM(0, 1) == 1);

        Debug.Assert(fizzbuzz(1) == ".");
        Debug.Assert(fizzbuzz(2) == "..");
        Debug.Assert(fizzbuzz(3) == "..fizz");
        Debug.Assert(fizzbuzz(5) == "..fizz.buzz");
        Debug.Assert(fizzbuzz(10) == "..fizz.buzzfizz..fizzbuzz");

        Debug.Assert(max(1, 3) == 3);
        Debug.Assert(max(0, 3) == 3);
        Debug.Assert(max(10, 3) == 10);
        Debug.Assert(max(-1, -3) == -1);

        Debug.Assert(maxOfThree(1, 3, 2) == 3);
        Debug.Assert(maxOfThree(0, 3, -1) == 3);
        Debug.Assert(maxOfThree(10, 3, 50) == 50);
        Debug.Assert(maxOfThree(-1, -3, -10) == -1);

        Debug.Assert(maxOfAll(-30, -50, -1, -3, -10, -11, -20) == -1);
        Debug.Assert(maxOfAll(10, 20, 11, 53, 100, 211, -20) == 211);

        Debug.Assert(isVowel('B') == false);
        Debug.Assert(isVowel('b') == false);
        Debug.Assert(isVowel('a') == true);
        Debug.Assert(isVowel('E') == true);

        Debug.Assert(rovarspraket("a") == "a");
        Debug.Assert(rovarspraket("b") == "bob");
        Debug.Assert(rovarspraket("cat") == "cocatot");
        Debug.Assert(rovarspraket("javascript") == "jojavovasoscocroripoptot");

        Debug.Assert(reverse("books") == "skoob");
        Debug.Assert(reverse("we don't want no trouble") == "elbuort on tnaw t'nod ew");

        Debug.Assert(findLongestWord("book dogs") == "book");
        Debug.Assert(findLongestWord("don't mess with Texas") == "Texas");
    }
}

