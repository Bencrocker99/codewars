//Complete the function that takes a non-negative integer n as input, and returns a list of all the powers of 2 with the exponent ranging from 0 to n ( inclusive ).

//Examples
//n = 0  ==> [1]        # [2^0]
//n = 1  ==> [1, 2]     # [2^0, 2^1]
//n = 2  ==> [1, 2, 4]  # [2^0, 2^1, 2^2]Complete the function that takes a non-negative integer n as input, and returns a list of all the powers of 2 with the exponent ranging from 0 to n ( inclusive ).

//Examples
//n = 0  ==> [1]        # [2^0]
//n = 1  ==> [1, 2]     # [2^0, 2^1]
//n = 2  ==> [1, 2, 4]  # [2^0, 2^1, 2^2]


//My Solution

using System.Numerics;
using System;

public class Kata
{
    public static BigInteger[] PowersOfTwo(int n)
    {
        BigInteger[] correctedArray = new BigInteger[n + 1];
        for (int i = 0; i <= n; i++)
        {
            correctedArray[i] = (BigInteger)(Math.Pow(2.00, (double)i));
        }
        return correctedArray;
    }
}