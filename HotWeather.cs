using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocTest
{
    public class HotWeather : BusinessRules
    {
        public static String[] HOT = { "fail", "sandals", "sun visor", "fail", "t-shirt", "fail", "shorts", "leaving house", "Removing PJs" };
        public static Boolean[] all_clothes = new Boolean[9];
        public StringBuilder op;

        public String checkShirtBeforeJacket(StringBuilder op, int v)
        {
            
                op.Append("fail");
                all_clothes[5] = true;
                return op.ToString();
    
        }
        public String checkForNoSocks(StringBuilder op, int v)
        {

            op.Append("fail");
            all_clothes[3] = true;
            return op.ToString();

        }

        public String checkAllClothesWorn(StringBuilder op, int v)
        {
            all_clothes[3] = all_clothes[5] = all_clothes[7] = true;
            for (int i = 1; i < 9; i++)
            { 
                if (all_clothes[i] != true)
                {

                    op.Append("fail");
                    return op.ToString();

                }
            }
            op.Append(HOT[v]);
            return op.ToString();



        }

        public String checkShirtBeforeHeadWear(StringBuilder op, int v)
        {
            if (all_clothes[4] == true)
            {
                op.Append(HOT[v]);
                op.Append(",");
                all_clothes[2] = true;
                return op.ToString();

            }
            else
            {
                op.Append("fail");
                return op.ToString();
            }
        }


        public String checkForShoes(StringBuilder op, int v)
        {
            if (all_clothes[6] == true && all_clothes[3] == false)
            {
                op.Append(HOT[v]);
                op.Append(",");
                all_clothes[1] = true;
                return op.ToString();

            }
            else
            {
                op.Append("fail");
                return op.ToString();
            }
        }


        public String hotValue(int[] values)
        {
           
            if(values==null||values[0]==0||values.Length==0)
                return ("Invalid Command");
            //Checking :Initial state is in your house with your pajamas on
            if (values[0] != 8)
            {
                return "fail";
            }

            else
            {
                StringBuilder op = new StringBuilder();
                foreach (int v in values) //process the  inputs
                {
                    if(v>=9||v<=0|| values==null)
                        return ("Invalid Command");

                    String ab = HOT[v];
                    
                    //Checking if already worn and if you cannot wear
                    if (op.ToString().IndexOf(ab) != -1 || ab.Equals("fail"))
                    {
                        op.Append("fail");
                        return op.ToString();
                    }
                    else
                    {
                        //checking if everything is worn 
                        if (v == 7)
                        {
                            if (op.ToString().IndexOf(ab) != -1)
                                return op.Append("fail").ToString();

                         
                            String a = checkAllClothesWorn(op, v);
                            if(a.Contains("fail"))
                            return a;


                        } //check everything



                        //no jacket
                        if (v == 5)
                        {
                            /*if (all_clothes[4] == true)
                            {
                                op.Append(HOT[v]);
                                op.Append(",");
                                all_clothes[5] = true;

                            }
                            else
                            {
                                op.Append("fail");
                                return op.ToString();
                            }*/

                            String jacket = checkShirtBeforeJacket(op, v);
                            if (jacket.Contains("fail"))
                                return jacket;

                        }   //shirt must be put on before the jacket


                        // checking :shirt must be put on before the headwear 
                        if (v == 2)
                        {

                            String shirt = checkShirtBeforeHeadWear(op, v);
                            if (shirt.Contains("fail"))
                                return shirt;


                        }   //shirt must be put on before the headwear


                        if (v == 3)
                        {

                            String socks = checkForNoSocks(op, v);
                            if (socks.Contains("fail"))
                                return socks;


                        }

                        //checking :pants before shoes
                        if (v == 1)
                        {
                           
                            String shoes = checkForShoes(op, v);
                            if (shoes.Contains("fail"))
                                return shoes;


                        }//checking :pants before shoes

                        //normal execution
                        if (all_clothes[v] == false && op.ToString().IndexOf(ab) == -1)
                        {
                            op.Append(HOT[v]);
                            op.Append(",");
                            all_clothes[v] = true;
                        }

                    }

                }//for
                return op.ToString();
            }//else

        }//hotValue



    }
}
