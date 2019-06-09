using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace WindowsFormsApplication1
{
    public partial class homee : Form
    {
        public int userid,musicid;
        public homee()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            var dbn = new DataClasses2DataContext();
            var query = from c in dbn.users
                        where c.username == textBox1.Text &&
                        c.pas == textBox2.Text
                            select c;
            foreach (var c in query)
            {
                bool ismodir;
                userid = c.id;
               // MessageBox.Show(c.ismodir);
                if (c.ismodir.Contains("yes"))
                {
               //     MessageBox.Show("in yes");
                    ismodir = true;
                }
                else
                {
               //     MessageBox.Show("in no");
                    ismodir = false;
                }
                this.Hide();
                home a = new home(userid,ismodir);
                a.Show();
                a.userid = userid;
               
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            signup s = new signup();
            s.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Forgetpassword a = new Forgetpassword();
            a.Show();
        }
    }
}
