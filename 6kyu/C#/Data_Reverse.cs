// A stream of data is received and needs to be reversed.

// Each segment is 8 bits long, meaning the order of these segments needs to be reversed, for example:

// 11111111  00000000  00001111  10101010
//  (byte1)   (byte2)   (byte3)   (byte4)
// should become:

// 10101010  00001111  00000000  11111111
//  (byte4)   (byte3)   (byte2)   (byte1)
// The total number of bits will always be a multiple of 8.

// The data is given in an array as such:

// [1,1,1,1,1,1,1,1,0,0,0,0,0,0,0,0,0,0,0,0,1,1,1,1,1,0,1,0,1,0,1,0]

using System;

namespace Main
{
    public class Kata
    {
        public static int[] DataReverse(int[] data)
        {
            // Convert the bit array into a byte array
            byte[] byteArray = ConvertBitArrayToByteArray(data);

            // Reverse the byte array
            Array.Reverse(byteArray);

            // Convert the reversed byte array back into a bit array
            int[] reversedBits = ConvertByteArrayToBitArray(byteArray);

            return reversedBits;
        }

        static byte[] ConvertBitArrayToByteArray(int[] bits)
        {
            int byteCount = bits.Length / 8;
            byte[] byteArray = new byte[byteCount];

            for (int i = 0; i < byteCount; i++)
            {
                int startIndex = i * 8;
                for (int j = 0; j < 8; j++)
                {
                    byteArray[i] |= (byte)(bits[startIndex + j] << (7 - j));
                }
            }

            return byteArray;
        }

        static int[] ConvertByteArrayToBitArray(byte[] byteArray)
        {
            int bitCount = byteArray.Length * 8;
            int[] bitArray = new int[bitCount];

            for (int i = 0; i < byteArray.Length; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    bitArray[i * 8 + j] = (byteArray[i] >> (7 - j)) & 1;
                }
            }

            return bitArray;
        }
    }
}