using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptionCls
{
    public class Encrypt
    {
        

        public static string text(string encrypt)
        {           
            char EncryptionKey = 'i';
            int k = 0;
            string[] t = encrypt.Split(' ');
            char[] cuv = new char[255];
            bool isCons;
            string text = null;
            
            foreach (string i in t)
            {      
                cuv = i.ToCharArray();
                
                Array.Resize(ref cuv, cuv.Length + 3);

                for (int j = 0; j < cuv.Length; j++)
                {
                    if (cuv[j] != '\0')
                    {
                        k++;
                    }
                }
                if ((isCons = "QWRTYPSDFGHJKMNBVCXZqwrtypsdfghjkmnbvcxz".IndexOf(cuv[0].ToString(), StringComparison.InvariantCultureIgnoreCase) >= 0))
                {

                    cuv[k] = cuv[0];
                    cuv[0] = 'L';
                    cuv[k + 1] = EncryptionKey;
                }
                else
            if ((isCons = "AEIOULaeioul".IndexOf(cuv[0].ToString(), StringComparison.InvariantCultureIgnoreCase) >= 0))
                {
                    

                    if (cuv[1] != '\'')
                    {
                        int v;
                        for (v = 0; v < cuv.Length; v++)
                        {
                            if ((isCons = "QWRTYPSDFGHJKMNBVCXZLqwrtypsdfghjkmnbvcxzl".IndexOf(cuv[v].ToString(), StringComparison.InvariantCultureIgnoreCase) >= 0))
                            {
                                break;
                            }
                        }
                        cuv[k] = cuv[v];
                        cuv[v] = 'L';
                        cuv[k + 1] = EncryptionKey;
                    }
                    else if (cuv[1] == '\'')
                    {

                        k = 0;
                        for (int j = 2; j < cuv.Length; j++)
                        {
                            if (cuv[j] != '\0')
                            {
                                k++;
                            }
                        }


                        int v;
                        for (v = 2; v < cuv.Length; v++)
                        {
                            if ((isCons = "QWRTYPSDFGHJKMNBVCXZLqwrtypsdfghjkmnbvcxzl".IndexOf(cuv[v].ToString(), StringComparison.InvariantCultureIgnoreCase) >= 0))
                            {
                                break;
                            }
                        }
                        cuv[k] = cuv[v];
                        cuv[v] = 'L';
                        cuv[k + 1] = EncryptionKey;
                    }


                }

                for (int j = 0; j < cuv.Length - 1; j++)
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
