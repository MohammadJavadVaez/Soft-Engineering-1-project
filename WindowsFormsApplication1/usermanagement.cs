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
    public partial class usermanagement : Form
    {
        public int userid=-1;
        public usermanagement()
        {
            InitializeComponent();

            /*var nw = new DataClasses2DataContext();
            var uinfo = from a in nw.users
                            
                            select new
                            {
                                id = a.id,
                                name = a.name,
                                jhanr = a.username,
                                path = a.pas,
                                tavalod = a.saletavalod,
                                email = a.email,
                                ismodir = a.ismodir

                            };
            dataGridView1.DataSource = uinfo;
            Console.WriteLine("usermanagement is runnning");
             */ 
            //
           
            //

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                /*
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                userid = Int32.Parse(row.Cells["id"].Value.ToString());
                Console.WriteLine(row.Cells["id"].Value.ToString());
                */

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (userid == -1) 
            {
                MessageBox.Show("no user selected");
                return;
            }
            else MessageBox.Show(userid.ToString());

            var nw = new DataClasses2DataContext();
            user removeFromGroup = (from gm in nw.users
                                     where (gm.id == userid) 
                                     select gm).SingleOrDefault();

            try
            {
                nw.users.DeleteOnSubmit(removeFromGroup);
                nw.SubmitChanges();

                 nw = new DataClasses2DataContext();
                var uinfo = from a in nw.users

                            select new
                            {
                                id = a.id,
                                name = a.name,
                                jhanr = a.username,
                                path = a.pas,
                                tavalod = a.saletavalod,
                                email = a.email,
                                ismodir = a.ismodir

                            };
                dataGridView1.DataSource = uinfo;
                userid = -1;
            }
            catch
            {
                Console.WriteLine("has been deleted befor!!");
                MessageBox.Show("has been deleted befor!!");
                MessageBox.Show(userid.ToString());
            }
        
        }

        private void usermanagement_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db3DataSet1.t2' table. You can move, or remove it, as needed.
            this.t2TableAdapter.Fill(this.db3DataSet1.t2);
            // TODO: This line of code loads data into the 'db3DataSet.users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.db3DataSet.users);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void dataGridView2_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
           
        
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("changed");
            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            Console.WriteLine(row);
            Console.WriteLine(dataGridView1.Rows[e.RowIndex].Cells["id"].Value);
            Console.WriteLine(dataGridView1.Rows[e.RowIndex].Cells["name"].Value);
            Console.WriteLine(dataGridView1.Rows[e.RowIndex].Cells["username"].Value);
            Console.WriteLine(dataGridView1.Rows[e.RowIndex].Cells["pas"].Value);
            Console.WriteLine(dataGridView1.Rows[e.RowIndex].Cells["saletavalod"].Value);
            Console.WriteLine(dataGridView1.Rows[e.RowIndex].Cells["ismodir"].Value);

            try
            {
                var db = new DataClasses2DataContext();
                user myuser = db.users.Single(p => p.id == Int32.Parse(dataGridView1.Rows[e.RowIndex].Cells["id"].Value.ToString()));
                myuser.pas = dataGridView1.Rows[e.RowIndex].Cells["pas"].Value.ToString();
                myuser.name = dataGridView1.Rows[e.RowIndex].Cells["name"].Value.ToString();
                myuser.username = dataGridView1.Rows[e.RowIndex].Cells["username"].Value.ToString();
                myuser.saletavalod = Int32.Parse(dataGridView1.Rows[e.RowIndex].Cells["saletavalod"].Value.ToString());
                myuser.ismodir = dataGridView1.Rows[e.RowIndex].Cells["ismodir"].Value.ToString();
                 db.SubmitChanges();
                string message = "changed!";
                MessageBox.Show(message);
               // this.Close();
            }
            catch
            {
                MessageBox.Show(" not changed");
            }

        }
           
    }
}
