using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocTest
{
  public  class CommandExecutor
    {
        public static int[] values;
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Enter Temperature type");
            String temp_type= Console.ReadLine();
            Console.WriteLine("Enter Commands comma separated");
            String command_in = Console.ReadLine();
            values = cleanUpInput(command_in);
            switch (temp_type)
            {
                case "HOT":
                    HotWeather hw = new HotWeather();
                    String hot_output = hw.hotValue(values);
                     Console.WriteLine("Output :" + hot_output);
                    Console.ReadLine();
                    break;
                case "COLD":
                    ColdWeather cw = new ColdWeather();
                    String cold_output = cw.coldValue(values);
                    Console.WriteLine("Output :" + cold_output);
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Invalid Weather Type");
                    Console.WriteLine("Weather Type must be either COLD or HOT");
                    Console.ReadLine();
                    break;

            }//switch

        }//main
        public static int[] cleanUpInput(String command_in) 
        {

            String[] ab = command_in.Split(',');
            int[] val = new int[ab.Length];
            for (int i = 0; i < ab.Length; i++)
                val[i] = Convert.ToInt32(ab[i]);

            return val;
        }


    }
}

