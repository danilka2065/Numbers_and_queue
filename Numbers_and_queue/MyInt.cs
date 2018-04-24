using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs
{
    public class MyInt
    {
        public string Value = "";

        //Конструкторы
        public MyInt()
        {
            Value = "";
        }
        public MyInt(int so_znach_vvod)
        {
            Value = ToStr(so_znach_vvod);

        }
        public MyInt(string so_znach_vvod)
        {
            Value = so_znach_vvod;
        }
        public MyInt(int[] so_mas)
        {
            for (int i = 0; i < so_mas.Length; i++)
            {
                if (i == 0)
                {
                    if (so_mas[i] == 1) Value = "-";
                    else if (so_mas[i] == 0) Value = "";
                }
                else
                {
                    Value = Value + so_mas[i];
                }
            }
        }


        //Арифметические методы
        public MyInt Add(MyInt vhod_zhach)
        {

            string answer = "";
            string param1 = this.Value;
            string param2 = vhod_zhach.Value;

            int param1_znak = 0;
            int param2_znak = 0;

            if (param1[0] == '-')
            {
                param1_znak = 1;
                param1 = param1.Substring(1);
            }
            if (param2[0] == '-')
            {
                param2_znak = 1;
                param2 = param2.Substring(1);
            }
            char[] arr = param1.ToCharArray();
            Array.Reverse(arr);
            param1 = new string(arr);
            arr = param2.ToCharArray();
            Array.Reverse(arr);
            param2 = new string(arr);

            int r = param1.Length - param2.Length;
            if (r > 0)
            {
                for (int i = 0; i < r; i++)
                {
                    param2 = param2 + "0";
                }
            }
            else if (r < 0)
            {
                r = -r;
                for (int i = 0; i < r; i++)
                {
                    param1 = param1 + "0";
                }
            }


            if (param1_znak != param2_znak)
            {
                if (this.compareTo(vhod_zhach)) return new MyInt("0");
                else
                {
                    if (this.abs().Value == this.abs().Max(vhod_zhach.abs()).Value)
                    {
                        answer = subs(param1, param2);
                        bool isOver = false;
                        int cc = 0;
                        for (int i = 0; i < answer.Length; i++)
                        {

                            if (answer[i] != '0') isOver = true;
                            else cc++;

                            if (isOver)
                            {
                                answer = answer.Substring(cc);
                                break;
                            }
                        }
                        if (param1_znak == 1) answer = "-" + answer;

                    }
                    else if (vhod_zhach.abs().Value == (this.abs().Max(vhod_zhach.abs())).Value)
                    {
                        answer = subs(param2, param1);
                        bool isOver = false;
                        int cc = 0;
                        for (int i = 0; i < answer.Length; i++)
                        {

                            if (answer[i] != '0') isOver = true;
                            else cc++;

                            if (isOver)
                            {
                                answer = answer.Substring(cc);
                                break;
                            }
                        }
                        if (param2_znak == 1) answer = "-" + answer;
                    }
                }
            }
            else
            {
                answer = adds(param1, param2);
                if (param1_znak == 1) answer = "-" + answer;
            }



            return new MyInt(answer);
        }
        public MyInt abs()
        {
            if (Value[0] == '-') Value = Value.Substring(1);
            return new MyInt(Value);
        }
        public MyInt Sub(MyInt vhod_zhach)
        {
            MyInt answer;

            if (vhod_zhach.Value[0] != '-') vhod_zhach = new MyInt("-" + vhod_zhach.Value);
            else vhod_zhach = vhod_zhach.abs();

            answer = this.Add(vhod_zhach);
            return answer;
        }
        public MyInt Multiply(MyInt vhod_zhach)
        {
            MyInt ans = new MyInt("0");
            string param1 = this.Value;
            string param2 = vhod_zhach.Value;

            if (param1 == "0" || param2 == "0")
                return ans;
            else
            {
                int param1_znak = 0;
                int param2_znak = 0;


                if (param1[0] == '-')
                {
                    param1_znak = 1;
                    //A = A.Substring(1);
                }
                if (param2[0] == '-')
                {
                    param2_znak = 1;
                    param2 = param2.Substring(1);
                }

                char[] arr = param2.ToCharArray();
                Array.Reverse(arr);
                param2 = new string(arr);

                int multer = 1;


                for (int i = 0; i < param2.Length; i++)
                {
                    int n = int.Parse(param2[i].ToString());
                    n = n * (int)Math.Pow(10, i);
                    for (int j = 0; j < n; j++)
                    {
                        ans = ans.Add(this.abs());
                        string val = ans.Value;
                    }
                    multer++;
                }
                if (param1_znak != param2_znak)
                {
                    ans = new MyInt("-" + ans.Value);
                }
            }

            return ans;

        }


        //Методы сравнения

        public MyInt Max(MyInt vhod_zhach)
        {
            string param1 = Value;
            string param2 = vhod_zhach.Value;
            int param1_znak = 0;
            int param2_znak = 0;

            if (param1[0] == '-')
            {
                param1_znak = 1;
                param1 = param1.Substring(1);
            }
            if (param2[0] == '-')
            {
                param2_znak = 1;
                param2 = param2.Substring(1);
            }

            if (param1_znak == 0 && param2_znak == 1) return this;
            else if (param1_znak == 1 && param2_znak == 0) return vhod_zhach;
            else
            {
                if (param1.Length > param2.Length) return this;
                else if (param2.Length > param1.Length) return vhod_zhach;
                else
                {
                    bool isAmax = true;
                    for (int i = 0; i < param1.Length; i++)
                    {
                        if (int.Parse(param1[i].ToString()) > int.Parse(param2[i].ToString())) break;
                        else if (int.Parse(param1[i].ToString()) < int.Parse(param2[i].ToString()))
                        {
                            isAmax = false;
                            break;
                        }
                    }

                    if (isAmax) return this;
                    else return vhod_zhach;
                }
            }

        }
        public bool compareTo(MyInt vhod_zhach)
        {
            if (Value == vhod_zhach.Value) return true;
            else return false;
        }
        public MyInt Min(MyInt vhod_zhach)
        {
            MyInt lel = this.Max(vhod_zhach);

            if (lel.Equals(this)) return vhod_zhach;
            else return this;
        }


        //Нахождение НОД

        public MyInt Gcd(MyInt vhod_zhach)
        {
            string what = "";
            MyInt answer = new MyInt("0");
            this.abs();
            vhod_zhach = vhod_zhach.abs();
            if (this.abs().Value == this.abs().Max(vhod_zhach.abs()).Value)
            {
                answer = this;
                while (answer.Value != "0")
                {
                    answer = answer.Sub(vhod_zhach.abs());
                    what = answer.Value;
                    if (answer.abs().Value == answer.abs().Min(vhod_zhach.abs()).Value)
                    {
                        MyInt rparam1_znak = vhod_zhach;
                        vhod_zhach = answer;
                        answer = rparam1_znak;
                    }
                    if (vhod_zhach.Value == answer.Value) break;
                }
                return answer;

            }
            else if (vhod_zhach.abs().Value == (this.abs().Max(vhod_zhach.abs())).Value)
            {
                MyInt subber = this;
                answer = vhod_zhach;
                while (answer.abs().Value != "0")
                {
                    answer = answer.Sub(subber.abs());
                    what = answer.Value;
                    if (answer.abs().Value == answer.abs().Min(subber.abs()).Value)
                    {
                        MyInt rparam1_znak = subber;
                        subber = answer;
                        answer = rparam1_znak;
                    }
                    if (subber.Value == answer.Value) break;
                }
                return answer;

            }
            else return this;
        }

        //Служебные всякие методы
        public long longValue()
        {
            long answer = 0;
            int range = 19;
            int param1_znak = 0;
            string loli = "";
            if (Value[0] == '-')
            {
                loli = Value.Substring(1);
                param1_znak = 1;
            }
            else loli = Value;
            int pow = loli.Length - 1;
            int j = 0;
            for (int i = pow; i > -1 && range > 0; i--)
            {
                int a = int.Parse(loli[j].ToString());
                answer += a * (long)Math.Pow(10, i);
                j++;
                range--;
            }

            if (param1_znak == 1) answer = -answer;

            return answer;
        }
        public string ToStr(int val)
        {
            bool isMin = false;
            if (val < 0)
            {
                isMin = true;
                val = -val;
            }


            string result = "";

            long div = 10;
            long ost = 0;
            long dep = val;

            for (int i = 0; dep > 0; i++)
            {
                ost = dep % div;
                result = ost + result;
                dep = dep / div;

            }

            if (isMin) result = "-" + result;
            return result;
        }
        private string subs(string str1, string str2)
        {
            string result = "";
            int mind = 0;
            int a = 0;
            int b = 0;
            int c = 0;

            for (int i = 0; i < str1.Length; i++)
            {

                a = int.Parse(str1[i].ToString());
                b = int.Parse(str2[i].ToString());


                if (a < mind)
                {
                    a = a + 10 - mind;
                    mind = 1;
                }
                else
                {
                    a = a - mind;
                    mind = 0;
                }

                if (a < b)
                {
                    c = a + 10 - b;
                    mind = 1;
                }
                else c = a - b;

                result = c + result;
            }
            return result;
        }
        private string adds(string str1, string str2)
        {
            string result = "";

            int mind = 0;
            int a = 0;
            int b = 0;
            int c = 0;

            for (int i = 0; i < str1.Length; i++)
            {

                a = int.Parse(str1[i].ToString());
                b = int.Parse(str2[i].ToString());

                a = a + mind;
                if (a < 10)
                {
                    mind = 0;
                }
                else
                {
                    a = a % 10;
                    mind = 1;
                }

                c = a + b;
                if (c > 9)
                {
                    c = c % 10;
                    mind = 1;
                }

                result = c + result;
            }
            if (mind == 1)
            {
                result = "1" + result;
            }

            return result;
        }
    }
}
