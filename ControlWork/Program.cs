using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlWork
{
    struct city
    {
        public int population;
        public string name;
        public int den;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter");
            //string text = Console.ReadLine();
            string text = "Kharkiv = 234235,345;Kiev = 3465688,456;Vegas = 7809078,908";
            string[] result = text.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
            city[] cities = new city[result.Length];
            for (int i = 0; i < result.Length; i++)
            {
                string[] nameSplit = result[i].Split('=');
                string[] valueSplit = nameSplit[i].Split(',');
                string b = nameSplit[0];
                int a = int.Parse(valueSplit[0]);
                int c = int.Parse(valueSplit[1]);
            }
            for (int i = 0; i < Length; i++)
            {

            }
        }
    }
}
