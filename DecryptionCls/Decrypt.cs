using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecryptionCls
{
    public class Decrypt
    {

        public static string text( string decryption)
        {
            int k = 0;
            string[] t = decryption.Split(' ');
            char[] cuv = new char[255];
            bool isCons;
            string text = null;

            foreach (string i in t)
            {
                cuv = i.ToCharArray();
                Console.WriteLine(cuv);
                for (int j = 0; j < cuv.Length; j++)
                {
                    if (cuv[j] != '\0')
                    {
                        k++;
                    }
                }

                if ((isCons = "AEIOULaeioul".IndexOf(cuv[0].ToString(), StringComparison.InvariantCultureIgnoreCase) >= 0))
                {
                    int v;
                    for (v = 0; v < cuv.Length; v++)
                    {
                        if ((isCons = "L".IndexOf(cuv[v].ToString(), StringComparison.InvariantCultureIgnoreCase) >= 0))
                        {
                            break;
                        }
                    }
                    cuv[v] = cuv[k - 2];
                    cuv[k - 2] = '\0';

                }

                for (int j = 0; j < cuv.Length - 2; j++)
                {
                    text = string.Concat(text, cuv[j].ToString());
                }
                text = text + " ";

                k = 0;

            }
            return text;
        }
    }
}
