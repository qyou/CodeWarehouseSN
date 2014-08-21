using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeWarehoseCrack
{
    public class KeyGen
    {
        // Fields
        private long count;
        private long inKeyHi;
        private long inKeyLo;
        private StringBuilder keyBuilder;
        private long seed;

        // Methods
        public KeyGen(long seed)
        {
            this.SetKeyGenerationSeed(seed);
        }

        public string GenerateNextKey()
        {
            long num = this.seed & 1L;
            num ^= (this.seed & 2L) >> 1;
            num ^= (this.seed & 0x10L) >> 4;
            num ^= (this.seed & 0x40L) >> 6;
            this.seed = (num << 0x1d) | (this.seed >> 1);
            if (this.count == 0x1000000L)
            {
                throw new Exception("Error - number of calls to GenerateNextKey() exceded 2^24.");
            }
            this.count += 1L;
            long num2 = this.seed + (this.seed << 30);
            long num3 = num2;
            num3 = (num3 ^ 0x89b01d3da4d55a9L) ^ this.inKeyLo;
            num2 = (num2 ^ 0x8bc9f8bd58b03d5L) ^ this.inKeyHi;
            if (this.keyBuilder == null)
            {
                this.keyBuilder = new StringBuilder(0x18);
                this.keyBuilder.Length = 0x18;
            }
            for (int i = 0; i < 0x18; i++)
            {
                long num5 = (i >= 12) ? num2 : num3;
                num5 = (num5 >> ((i % 12) * 5)) & 0x1fL;
                char ch = (char)((ushort)num5);
                if ((num5 >= 0L) && (num5 <= 9L))
                {
                    this.keyBuilder[i] = (char)('0' + ch);
                }
                if ((num5 >= 10L) && (num5 <= 0x11L))
                {
                    this.keyBuilder[i] = (char)(('A' + ch) - 10);
                }
                if ((num5 >= 0x12L) && (num5 <= 0x13L))
                {
                    this.keyBuilder[i] = (char)(('A' + ch) - 9);
                }
                if ((num5 >= 20L) && (num5 <= 0x15L))
                {
                    this.keyBuilder[i] = (char)(('A' + ch) - 8);
                }
                if ((num5 >= 0x16L) && (num5 <= 0x18L))
                {
                    this.keyBuilder[i] = (char)(('A' + ch) - 7);
                }
                if ((num5 >= 0x19L) && (num5 <= 0x1fL))
                {
                    this.keyBuilder[i] = (char)(('A' + ch) - 6);
                }
            }
            return this.keyBuilder.ToString();
        }

        public void SetKeyGenerationSeed(long seed)
        {
            this.seed = seed;
            this.count = 0L;
            this.inKeyLo = seed & 0xffL;
            this.inKeyHi = 0L;
            for (int i = 0; i < 0x1a; i++)
            {
                this.inKeyLo |= ((seed >> ((i + 8) & 0x3f)) & 1L) << ((2 * i) + 8);
            }
            for (int j = 0; j < 30; j++)
            {
                this.inKeyHi |= ((seed >> (((0x1a + j) + 8) & 0x3f)) & 1L) << (2 * j);
            }
        }

        public bool ValidateKey(string key)
        {
            if (string.IsNullOrEmpty(key))
            {
                return false;
            }
            char[] chArray = new char[0x18];
            int index = 0;
            for (int i = 0; (i < key.Length) && (index < 0x18); i++)
            {
                char ch = key[i];
                if ((((ch >= '0') && (ch <= '9')) || ((ch >= 'a') && (ch <= 'z'))) || ((ch >= 'A') && (ch <= 'Z')))
                {
                    chArray[index++] = key[i];
                }
            }
            for (int j = 0; j < chArray.Length; j++)
            {
                if ((chArray[j] >= 'a') && (chArray[j] <= 'z'))
                {
                    chArray[j] = (char)((chArray[j] + 'A') - 0x61);
                }
            }
            for (index = 0; index < chArray.Length; index++)
            {
                if (chArray[index] == 'I')
                {
                    chArray[index] = '1';
                }
                if (chArray[index] == 'L')
                {
                    chArray[index] = '1';
                }
                if (chArray[index] == 'O')
                {
                    chArray[index] = '0';
                }
                if (chArray[index] == 'S')
                {
                    chArray[index] = '5';
                }
            }
            for (int k = 0; k < chArray.Length; k++)
            {
                char[] chArray2;
                int num5;
                if ((chArray[k] >= '0') && (chArray[k] <= '9'))
                {
                    (chArray2 = chArray)[num5 = k] = (char)(chArray2[num5] - '0');
                }
                if ((chArray[k] >= 'A') && (chArray[k] <= 'H'))
                {
                    (chArray2 = chArray)[num5 = k] = (char)(chArray2[num5] - '7');
                }
                if ((chArray[k] >= 'J') && (chArray[k] <= 'K'))
                {
                    (chArray2 = chArray)[num5 = k] = (char)(chArray2[num5] - '8');
                }
                if ((chArray[k] >= 'M') && (chArray[k] <= 'N'))
                {
                    (chArray2 = chArray)[num5 = k] = (char)(chArray2[num5] - '9');
                }
                if ((chArray[k] >= 'P') && (chArray[k] <= 'R'))
                {
                    (chArray2 = chArray)[num5 = k] = (char)(chArray2[num5] - ':');
                }
                if ((chArray[k] >= 'T') && (chArray[k] <= 'Z'))
                {
                    (chArray2 = chArray)[num5 = k] = (char)(chArray2[num5] - ';');
                }
            }
            long num6 = 0L;
            long num7 = 0L;
            long num8 = 1L;
            for (int m = 0; m < 12; m++)
            {
                num6 += chArray[m] * num8;
                num8 *= 0x20L;
            }
            num8 = 1L;
            for (int n = 12; n < 0x18; n++)
            {
                num7 += chArray[n] * num8;
                num8 *= 0x20L;
            }
            num6 = (num6 ^ 0x89b01d3da4d55a9L) ^ this.inKeyLo;
            num7 = (num7 ^ 0x8bc9f8bd58b03d5L) ^ this.inKeyHi;
            long num11 = num6 & 0x3fffffffL;
            long num12 = (num6 & 0xfffffffc0000000L) >> 30;
            long num13 = num7 & 0x3fffffffL;
            long num14 = (num7 & 0xfffffffc0000000L) >> 30;
            return (((num11 == num12) && (num11 == num13)) && (num11 == num14));
        }
    }


}
