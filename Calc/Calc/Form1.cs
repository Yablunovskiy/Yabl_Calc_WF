using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Calc
{
    public partial class Calc : Form
    {

        double Ferst = 0;
        double Second = 0;
        double Rez = 0;

        bool enter = false;
        bool convert = false;
        bool func = false;
        bool inv = false;
        string Operation = "";
        

        public Calc()
        {
            InitializeComponent();
        }

        private void engineering_CheckedChanged(object sender, EventArgs e)
        {
            this.Size = new Size(515, 378);
            Hide(0);
        }

        private void usual_CheckedChanged(object sender, EventArgs e)
        {
            this.Size = new Size(265, 378);
            Hide(245);
        }

        private void Hide(int x)
        {
            this.textBox1.Size = new System.Drawing.Size(473 - x, 29);
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            // 
            // Pi
            // 
            this.Pi.Location = new System.Drawing.Point(12 - x, 247);
            // 
            // F_E
            // 
            this.F_E.Location = new System.Drawing.Point(12 - x, 289);
            // 
            // tanh
            // 
            this.tanh.Location = new System.Drawing.Point(60 - x, 247);
            // 
            // Mod
            // 
            this.Mod.Location = new System.Drawing.Point(107 - x, 289);
            // 
            // log
            // 
            this.log.Location = new System.Drawing.Point(155 - x, 289);
            // 
            // x10
            // 
            this.x10.Location = new System.Drawing.Point(203 - x, 289);
            // 
            // x3
            // 
            this.x3.Location = new System.Drawing.Point(155 - x, 247);
            // 
            // tan
            // 
            this.tan.Location = new System.Drawing.Point(107 - x, 247);
            // 
            // Cos
            // 
            this.Cos.Location = new System.Drawing.Point(107 - x, 205);
            // 
            // xy
            // 
            this.xy.Location = new System.Drawing.Point(155 - x, 205);
            // 
            // Cosh
            // 
            this.Cosh.Location = new System.Drawing.Point(60 - x, 205);
            // 
            // dms
            // 
            this.dms.Location = new System.Drawing.Point(12 - x, 205);
            // 
            // Sin
            // 
            this.Sin.Location = new System.Drawing.Point(107 - x, 163);
            // 
            // x2
            // 
            this.x2.Location = new System.Drawing.Point(155 - x, 163);
            // 
            // Sinh
            // 
            this.Sinh.Location = new System.Drawing.Point(60 - x, 163);
            // 
            // Int
            // 
            this.Int.Location = new System.Drawing.Point(12 - x, 163);
            // 
            // In
            // 
            this.In.Location = new System.Drawing.Point(107 - x, 121);
            // 
            // Open
            // 
            this.Open.Location = new System.Drawing.Point(155 - x, 121);
            // 
            // Inv
            // 
            this.Inv.Location = new System.Drawing.Point(60 - x, 121);
            // 
            // Nul
            // 
            this.Nul.Location = new System.Drawing.Point(12 - x, 121);
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(203 - x, 121);
            // 
            // Fact
            // 
            this.Fact.Location = new System.Drawing.Point(203 - x, 163);
            // 
            // xsqry
            // 
            this.xsqry.Location = new System.Drawing.Point(203 - x, 205);
            // 
            // usual
            // 
            this.usual.Location = new System.Drawing.Point(3, 3);
            // 
            // engineering
            // 
            this.engineering.Location = new System.Drawing.Point(81, 3);
            // 
            // M_min
            // 
            this.M_min.Location = new System.Drawing.Point(443 - x, 79);
            // 
            // sqr
            // 
            this.sqr.Location = new System.Drawing.Point(443 - x, 121);
            // 
            // Proc
            // 
            this.Proc.Location = new System.Drawing.Point(443 - x, 163);
            // 
            // x_1
            // 
            this.x_1.Location = new System.Drawing.Point(443 - x, 205);
            // 
            // MS
            // 
            this.MS.Location = new System.Drawing.Point(347 - x, 79);
            // 
            // M_plus
            // 
            this.M_plus.Location = new System.Drawing.Point(395 - x, 79);
            // 
            // MR
            // 
            this.MR.Location = new System.Drawing.Point(300 - x, 79);
            // 
            // MC
            // 
            this.MC.Location = new System.Drawing.Point(252 - x, 79);
            // 
            // C
            // 
            this.C.Location = new System.Drawing.Point(347 - x, 121);
            // 
            // plus_min
            // 
            this.plus_min.Location = new System.Drawing.Point(395 - x, 121);
            // 
            // CE
            // 
            this.CE.Location = new System.Drawing.Point(300 - x, 121);
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(252 - x, 121);
            // 
            // n9
            // 
            this.n9.Location = new System.Drawing.Point(347 - x, 163);
            // 
            // Del
            // 
            this.Del.Location = new System.Drawing.Point(395 - x, 163);
            // 
            // n8
            // 
            this.n8.Location = new System.Drawing.Point(300 - x, 163);
            // 
            // n7
            // 
            this.n7.Location = new System.Drawing.Point(252 - x, 163);
            // 
            // n6
            // 
            this.n6.Location = new System.Drawing.Point(347 - x, 205);
            // 
            // Umn
            // 
            this.Umn.Location = new System.Drawing.Point(395 - x, 205);
            // 
            // n5
            // 
            this.n5.Location = new System.Drawing.Point(300 - x, 205);
            // 
            // n4
            // 
            this.n4.Location = new System.Drawing.Point(252 - x, 205);
            // 
            // N3
            // 
            this.N3.Location = new System.Drawing.Point(347 - x, 247);
            // 
            // Minus
            // 
            this.Minus.Location = new System.Drawing.Point(395 - x, 247);
            // 
            // Enter
            // 
            this.Enter.Location = new System.Drawing.Point(443 - x, 247);
            // 
            // Plus
            // 
            this.Plus.Location = new System.Drawing.Point(395 - x, 289);
            // 
            // Point
            // 
            this.Point.Location = new System.Drawing.Point(347 - x, 289);
            // 
            // n2
            // 
            this.n2.Location = new System.Drawing.Point(300 - x, 247);
            // 
            // N0
            // 
            this.N0.Location = new System.Drawing.Point(252 - x, 289);
            // 
            // n1
            // 
            this.n1.Location = new System.Drawing.Point(252 - x, 247);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(256 - x, 49);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(12 - x, 82);
            // 
            // xsqr3
            // 
            this.xsqr3.Location = new System.Drawing.Point(203 - x, 247);
            // 
            // Exp
            // 
            this.Exp.Location = new System.Drawing.Point(59 - x, 289);
            // 
            // radioButton1
            // 
            this.radioButton1.Location = new System.Drawing.Point(5 - x, 3);
            // 
            // radioButton2
            // 
            this.radioButton2.Location = new System.Drawing.Point(78 - x, 3);
            // 
            // radioButton3
            // 
            this.radioButton3.Location = new System.Drawing.Point(153 - x, 3);
        }

        private void n1_Click(object sender, EventArgs e)
        {
            Ent(n1.Text);
        }

        private void n2_Click(object sender, EventArgs e)
        {
            Ent(n2.Text);
        }

        private void N3_Click(object sender, EventArgs e)
        {
            Ent(N3.Text);
        }

        private void n4_Click(object sender, EventArgs e)
        {
            Ent(n4.Text);
        }

        private void n5_Click(object sender, EventArgs e)
        {
            Ent(n5.Text);
        }

        private void n6_Click(object sender, EventArgs e)
        {
            Ent(n6.Text);
        }

        private void n7_Click(object sender, EventArgs e)
        {
            Ent(n7.Text);
        }

        private void n8_Click(object sender, EventArgs e)
        {
            Ent(n8.Text);
        }

        private void n9_Click(object sender, EventArgs e)
        {
            Ent(n9.Text);
        }

        private void N0_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
                Ent(N0.Text);
        }

        private void Ent(string T)
        {
            if (func)
            {
                textBox1.Text = "";
                textBox1.Text += T;
            }
            else
                textBox1.Text += T;
            func = false;
        }

        private void Point_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                Ent("0");
                Ent(Point.Text);
            }
            else
                Ent(Point.Text);
        }

        private void Plus_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                Ferst = 0;
            else if (Ferst == 0)
                Ferst = Convert.ToDouble(textBox1.Text);
            else if (convert)
            {
                Ferst = Convert.ToDouble(textBox1.Text);
                convert = false;
            }
            if (Operation == "+" && !enter)
            {
                enter = true;
                EnteR();
                Ferst = Rez;
                enter = false;
            }
            func = true;
            Operation = Plus.Text;
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                Ferst = 0;
            else if (Ferst == 0)
                Ferst = Convert.ToDouble(textBox1.Text);
            else if (convert)
            {
                Ferst = Convert.ToDouble(textBox1.Text);
                convert = false;
            }
            if (Operation == "-" && !enter)
            {
                enter = true;
                EnteR();
                Ferst = Rez;
                enter = false;
            }
            func = true;
            Operation = Minus.Text;
        }

        private void Umn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                Ferst = 0;
            else if (Ferst == 0)
                Ferst = Convert.ToDouble(textBox1.Text);
            else if (convert)
            {
                Ferst = Convert.ToDouble(textBox1.Text);
                convert = false;
            }
            if (Operation == "*" && !enter)
            {
                enter = true;
                EnteR();
                Ferst = Rez;
                enter = false;
            }
            func = true;
            Operation = Umn.Text;
        }

        private void Del_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                Ferst = 0;
            else if (Ferst == 0)
                Ferst = Convert.ToDouble(textBox1.Text);
            else if (convert)
            {
                Ferst = Convert.ToDouble(textBox1.Text);
                convert = false;
            }
            if (Operation == "/" && !enter)
            {
                enter = true;
                EnteR();
                Ferst = Rez;
                enter = false;
            }
            func = true;
            Operation = Del.Text;
        }

        private void Enter_Click(object sender, EventArgs e)
        {
            //enter = true;
            EnteR();
            Ferst = Rez;
            enter = true;
        }

        private void EnteR()
        {
            if (Ferst != Rez || !func)
            {
                Second = Convert.ToDouble(textBox1.Text);
            }
             switch (Operation)
            {
                case "+":
                    Rez = Ferst + Second;
                    break;
                case "-":
                    Rez = Ferst - Second;
                    break;
                case "*":
                    Rez = Ferst * Second;
                    break;
                case "/":
                    Rez = Ferst / Second;
                    break;
            }
            textBox1.Text = Rez.ToString();
            func = true;

        }

        private void C_Click(object sender, EventArgs e)
        {
            func = true;
            enter = false;
            Ferst = Second = Rez = 0;
            textBox1.Text = "0";
            Operation = "";
        }

        private void CE_Click(object sender, EventArgs e)
        {
            func = true;
            Second = 0;
            textBox1.Text = "0";
        }

        private void Back_Click(object sender, EventArgs e)
        {
            textBox1.Text = (textBox1.Text.ToString()).Remove(textBox1.Text.ToString().Length - 1);
        }

        private void plus_min_Click(object sender, EventArgs e)
        {
            double ent = Convert.ToDouble(textBox1.Text);
            if (ent > 0)
                ent = -ent;
            else
                ent -= ent * 2;
            textBox1.Text = ent.ToString();
            convert = true;
        }

        private void x_1_Click(object sender, EventArgs e)
        {
            textBox1.Text = (1 / Convert.ToDouble(textBox1.Text)).ToString();
            convert = true;
        }

        private void sqr_Click(object sender, EventArgs e)
        {
            textBox1.Text = (Math.Sqrt(Convert.ToDouble(textBox1.Text))).ToString();
            convert = true;
        }

        private void x10_Click(object sender, EventArgs e)
        {
            textBox1.Text = (Math.Pow(10, Convert.ToDouble(textBox1.Text))).ToString();
            convert = true;
        }

        private void Proc_Click(object sender, EventArgs e)
        {
            textBox1.Text = (Convert.ToDouble(textBox1.Text) * Ferst / 100).ToString();
            convert = true;
        }

        private void xsqr3_Click(object sender, EventArgs e)
        {
            textBox1.Text = (Math.Pow(Convert.ToDouble(textBox1.Text), (1.0 / 3))).ToString();
            convert = true;
        }

        private void x2_Click(object sender, EventArgs e)
        {
            textBox1.Text = (Math.Pow(Convert.ToDouble(textBox1.Text), 2)).ToString();
            convert = true;
        }

        private void x3_Click(object sender, EventArgs e)
        {
            textBox1.Text = (Math.Pow(Convert.ToDouble(textBox1.Text), 3)).ToString();
            convert = true;
        }

        private void Pi_Click(object sender, EventArgs e)
        {
            if (this.Pi.Text == "Pi")
                textBox1.Text = Math.PI.ToString();
            else
                textBox1.Text = (2 * (Math.PI)).ToString();
            convert = true;
        }

        private void Sin_Click(object sender, EventArgs e)
        {
            if (this.Sin.Text == "Sin")
                textBox1.Text = (Math.Sin(Convert.ToDouble(textBox1.Text))).ToString();
            else
                textBox1.Text = (1/Math.Sin(Convert.ToDouble(textBox1.Text))).ToString();
            convert = true;
        }

        private void Cos_Click(object sender, EventArgs e)
        {
            textBox1.Text = (Math.Cos(Convert.ToDouble(textBox1.Text))).ToString();
            convert = true;
        }

        private void tan_Click(object sender, EventArgs e)
        {
            textBox1.Text = (Math.Tan(Convert.ToDouble(textBox1.Text))).ToString();
            convert = true;
        }

        private void tanh_Click(object sender, EventArgs e)
        {
            textBox1.Text = (Math.Tanh(Convert.ToDouble(textBox1.Text))).ToString();
            convert = true;
        }

        private void log_Click(object sender, EventArgs e)
        {
            textBox1.Text = (Math.Log10(Convert.ToDouble(textBox1.Text))).ToString();
            convert = true;
        }

        private void Cosh_Click(object sender, EventArgs e)
        {
            textBox1.Text = (Math.Cosh(Convert.ToDouble(textBox1.Text))).ToString();
            convert = true;
        }

        private void Sinh_Click(object sender, EventArgs e)
        {
            textBox1.Text = (Math.Sinh(Convert.ToDouble(textBox1.Text))).ToString();
            convert = true;
        }

        private void In_Click(object sender, EventArgs e)
        {
            if (this.In.Text == "In")
                textBox1.Text = (Math.Log(Convert.ToDouble(textBox1.Text))).ToString();
            else
                textBox1.Text = (Math.Exp(Convert.ToDouble(textBox1.Text))).ToString();
            convert = true;
        }

        private void Inv_Click(object sender, EventArgs e)
        {
            if (!inv)
            {
                this.Pi.Text = "2*Pi";
                this.In.Text = "Ex";
                this.dms.Text = "deg";
                this.Int.Text = "Frac";
                this.Int.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                this.Sinh.Text = "1/Sinh";
                this.Sinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                this.Cosh.Text = "1/Cosh";
                this.Cosh.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                this.Sin.Text = "1/Sin";
                this.Sin.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                this.Cos.Text = "1/Cos";
                this.Cos.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                this.tanh.Text = "1/tanh";
                this.tanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                this.tan.Text = "1/tan";
                this.tan.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                
            
                inv = true;
            }
            else
            {
                this.Pi.Text = "Pi";
                this.In.Text = "In";
                this.dms.Text = "dms";
                this.Int.Text = "Int";
                this.Int.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                this.Sinh.Text = "Sinh";
                this.Sinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                this.Cosh.Text = "Cosh";
                this.Cosh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                this.Sin.Text = "Sin";
                this.Sin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                this.Cos.Text = "Cos";
                this.Cos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                this.tanh.Text = "tanh";
                this.tanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                this.tan.Text = "tan";
                this.tan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                
                inv = false;
            }
            
        }

        private void Enter_MouseLeave(object sender, EventArgs e)
        {
            //this.Enter.BackColor = System.Drawing.Color.LightSkyBlue;
            var btn = (sender as Button);
            if (btn == null) return;
            btn.BackColor = Color.LightSkyBlue;
        }

        private void Enter_MouseHover(object sender, EventArgs e)
        {
            //this.Enter.BackColor = System.Drawing.Color.Yellow;
            var btn = (sender as Button);
            if (btn == null) return;
            btn.BackColor = Color.Yellow;
        }

        private void Enter_MouseDown(object sender, MouseEventArgs e)
        {
            //this.Enter.BackColor = System.Drawing.Color.Red;
            var btn = (sender as Button);
            if (btn == null) return;
            btn.BackColor = Color.Red;
        }

        private void Enter_MouseHover(object sender, MouseEventArgs e)
        {
            //this.Enter.BackColor = System.Drawing.Color.Yellow;
            var btn = (sender as Button);
            if (btn == null) return;
            btn.BackColor = Color.Yellow;
        }

        
    }
}
