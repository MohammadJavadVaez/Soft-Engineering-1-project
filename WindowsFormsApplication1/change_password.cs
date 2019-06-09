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
    public partial class change_password : Form
    {
        public int uid;
        public change_password(int a)
        {
            InitializeComponent();
            uid = a;
        }

        private void change_password_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var db = new DataClasses2DataContext();
                user myuser = db.users.Single(p => p.id == uid);
                myuser.pas = textBox1.Text;
                db.SubmitChanges();
                string message = "password changed!";
                MessageBox.Show(message);
                this.Close();
            }
            catch
            {
                MessageBox.Show("password not changed");
            }
        }
    }
}
