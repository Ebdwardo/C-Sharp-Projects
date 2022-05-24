using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService2
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {

        public int c2f(int c)
        {
            //returning the int after converting it to farenheit
            return (int)(c*(9.0 / 5.0))+32;
        }

        public int f2c(int f)
        {
            //returning the int after converting it to celcius
            return (int)((f-32)*(5.0/9.0));
        }

        public string sort(string s)
        {
            //creating an array to hold the string version of each number
            string[] str = s.Split(',');
            string stri = "";
            int[] array = new int[str.Length];

            //go through the string array and convert and store it to an integer array
            for (int i = 0; i < str.Length; i++)
            {
                array[i] = Int32.Parse(str[i]);
            }

            //sort the array
            Array.Sort(array);

            //convert it back into a string 
            for (int i = 0; i < str.Length; i++)
            {
                str[i] = array[i].ToString();
            }

            //concatinate it into a string
            for (int i = 0; i < str.Length; i++)
            {
                stri = stri + str[i] + ",";
            }

            return stri;
        }
    }
}
