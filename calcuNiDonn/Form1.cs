using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calcuNiDonn
{
    public partial class Form1 : Form
    {
        string textOutput = "";
        List<string> operation = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void output(string s)
        {
            if (s.Equals(".") && t_display.Text.Length != 0)
            {
                if (t_display.Text[t_display.Text.Length - 1] == '.')
                {
                    return;
                }

            }
            textOutput += s;
            t_display.Text = textOutput;
        }

        private void sanitize(string s)
        {
            string txt = s;
            List<int> j = new List<int>();
            for (int i = 0; i < txt.Length; i++)
            {
                if (txt[i] == '√')
                {
                    j.Add(i);
                }
            }

            List<string> squarert = new List<string>();

            squarert = txt.Split('√').ToList();
            squarert.RemoveAll(string.IsNullOrEmpty);
            foreach (int i in j)
            {
                squarert.Insert(i, "√");
            }


            foreach (string item in squarert)
            {
                operation.Add(item);
                Console.WriteLine($"<{item}>");
            }

        }

        private void addOp(string op)
        {
            if (string.IsNullOrEmpty(textOutput))
            {
                return;
            }
            if (t_display.Text.Contains("√"))
            {
                sanitize(t_display.Text);
                operation.Add(op);
                t_display.Text = "0";
                textOutput = "";
                Console.WriteLine(operation.Count);
                return;
            }
            operation.Add(t_display.Text);
            operation.Add(op);
            t_display.Text = t_display.Text;
            textOutput = "";
            Console.WriteLine(operation.Count);
        }

        private bool sqrt()
        {
            double ans = 0;
            for (int i = 0; i < operation.Count; i++)
            {
                if (i == 0 && operation[i].Equals("√"))
                {
                    if (i + 1 > operation.Count - 1)
                    {
                        error("Syntax error");
                        return false;
                    }
                    if (!double.TryParse(operation[i + 1], out _)) 
                    {
                        error("Syntax error");
                        return false;
                    }
                    ans = Math.Sqrt(double.Parse(operation[i + 1]));
                    operation.RemoveAt(i);
                    operation.RemoveAt(i);
                    operation.Insert(i, ans.ToString());
                }

                if (operation[i].Equals("√"))
                {
                    if (i + 1 > operation.Count - 1)
                    {
                        error("Syntax error");
                        return false;
                    }
                    if (!double.TryParse(operation[i + 1], out _) || double.TryParse(operation[i - 1], out _))
                    {
                        error("Syntax error");
                        return false;
                    }
                    ans = Math.Sqrt(double.Parse(operation[i + 1]));
                    operation.RemoveAt(i);
                    operation.RemoveAt(i);
                    operation.Insert(i, ans.ToString());
                }
            }
            return true;
        }

        private void equals()
        {
            operation.Add(t_display.Text);
            int last = operation.Count - 1;
            if (operation.Count == 1 && operation[0].Contains("√"))
            {
                sanitize(t_display.Text);
                operation.RemoveAt(0);
            } 
            else if (operation[last].Contains("√"))
            {
                sanitize(t_display.Text);
                operation.RemoveAt(last);
            }

            

            if (operation.Contains("/") || operation.Contains("*") || operation.Contains("^") || operation.Contains("%") || operation.Contains("√"))
            {
                if (!sqrt())
                {
                    return;
                } 
                exp();
                multiply();
                if (!division())
                {
                    return;
                }
            }
            double ans = double.Parse(operation[0]);

            for (int i = 0; i < operation.Count; i+=2)
            {
                if (i == operation.Count - 1)
                {
                    break;
                }

                switch (operation[i + 1]) 
                {
                    case "+":
                        ans += double.Parse(operation[i + 2]);
                        break;
                    case "-":
                        ans -= double.Parse(operation[i + 2]);
                        break;
                }
            }

            t_display.Text = ans.ToString();
            Console.WriteLine(ans);
            textOutput = "";
            operation.Clear();
        }

        private bool division()
        {
            int end = operation.Count - 2;
            double ans = 0;
            for (int i = end; i > 0; i-=2)
            {
                if (operation[i] == "/")
                {
                    if (operation[i + 1] == "0")
                    {
                        error("Math error");
                        return false;
                    }
                    ans = double.Parse(operation[i - 1]);
                    ans /= double.Parse(operation[i + 1]);
                    operation.RemoveAt(i - 1);
                    operation.RemoveAt(i - 1);
                    operation.RemoveAt(i - 1);
                    operation.Insert(i - 1, ans.ToString());
                }
            }
            return true;
        }

        private void multiply()
        {
            int end = operation.Count - 2;
            double ans = 0;
            for (int i = end; i > 0; i -= 2)
            {
                if (operation[i] == "*")
                {
                    ans = double.Parse(operation[i - 1]);
                    ans *= double.Parse(operation[i + 1]);
                    operation.RemoveAt(i - 1);
                    operation.RemoveAt(i - 1);
                    operation.RemoveAt(i - 1);
                    operation.Insert(i - 1, ans.ToString());
                }
            }
        }

        private void exp()
        {
            int end = operation.Count - 2;
            double ans = 0;
            for (int i = end; i > 0; i -= 2)
            {
                if (operation[i] == "^")
                {
                    ans = double.Parse(operation[i - 1]);
                    ans = Math.Pow(ans, double.Parse(operation[i + 1]));
                    operation.RemoveAt(i - 1);
                    operation.RemoveAt(i - 1);
                    operation.RemoveAt(i - 1);
                    operation.Insert(i - 1, ans.ToString());
                }
            }
        }

        private void error(string e)
        {
            clear();
            t_display.Text = e;
        }

        private void b_00_Click(object sender, EventArgs e)
        {
            output(b_00.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            t_display.Text = "0";
        }

        private void b_0_Click(object sender, EventArgs e)
        {
            output(b_0.Text);
        }

        private void b_dot_Click(object sender, EventArgs e)
        {
            output(b_dot.Text);
        }

        private void b_1_Click(object sender, EventArgs e)
        {
            output(b_1.Text);
        }

        private void b_2_Click(object sender, EventArgs e)
        {
            output(b_2.Text);
        }

        private void b_3_Click(object sender, EventArgs e)
        {
            output(b_3.Text);
        }

        private void b_4_Click(object sender, EventArgs e)
        {
            output(b_4.Text);
        }

        private void b_5_Click(object sender, EventArgs e)
        {
            output(b_5.Text);
        }

        private void b_6_Click(object sender, EventArgs e)
        {
            output(b_6.Text);
        }

        private void b_7_Click(object sender, EventArgs e)
        {
            output(b_7.Text);
        }

        private void b_8_Click(object sender, EventArgs e)
        {
            output(b_8.Text);
        }

        private void b_9_Click(object sender, EventArgs e)
        {
            output(b_9.Text);
        }

        private void b_clear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void clear()
        {
            t_display.Text = "0";
            textOutput = "";
            operation.Clear();
        }

        private void b_add_Click(object sender, EventArgs e)
        {
            addOp(b_add.Text);
        }

        private void b_equals_Click(object sender, EventArgs e)
        {
            equals();
        }

        private void b_minus_Click(object sender, EventArgs e)
        {
            addOp(b_minus.Text);
        }

        private void b_times_Click(object sender, EventArgs e)
        {
            addOp(b_times.Text);
        }

        private void b_divide_Click(object sender, EventArgs e)
        {
            addOp("/");
        }

        private void b_pow_Click(object sender, EventArgs e)
        {
            addOp(b_pow.Text);
        }

        private void b_percent_Click(object sender, EventArgs e)
        {
            output("√");
        }
    }
}
