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
    public partial class signup : Form
    {
        public signup()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var dbn = new DataClasses2DataContext();
            var query = from c in dbn.users
                        
                        select c;
            DataClasses2DataContext db = new DataClasses2DataContext();

            user emp = new user();

            emp.username = textBox1.Text;

            emp.pas = textBox2.Text;
            emp.name = textBox3.Text;
            emp.email = textBox5.Text;
            emp.ismodir = "no";
            emp.saletavalod = Int32.Parse(textBox4.Text); 
            db.users.InsertOnSubmit(emp);

            db.SubmitChanges();
            this.Close();
            //
        }
    }
}
