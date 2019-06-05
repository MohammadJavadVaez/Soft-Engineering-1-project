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
    public partial class home : Form
    {
        public int musicid,userid,uid;
        public bool  ismodir=false;
        public home(int userid,bool ism)
        {
           
            InitializeComponent();
            uid = userid;
            ismodir = ism;
            if(ismodir)
            {
               
            }
            else
            {
                button7.Hide();
                button8.Hide();
                button9.Hide();
                button10.Hide();
            }
             var nw = new DataClasses2DataContext();
            var musicinfo = from a in nw.musics join 
                                 b in  nw.likeds on a.id equals b.musicid 
                            where b.userid == userid
                            select new
                            {
                                id = a.id,
                                name = a.name,
                                jhanr = a.jhanrid,
                                path = a.fileaddress
                            };
            dataGridView2.DataSource = musicinfo;


            //
             nw = new DataClasses2DataContext();
            var musici = from a in nw.musics
                            join
                                b in nw.suggestions on a.id equals b.musicid
                            where b.userid == userid
                            select new
                            {
                                id = a.id,
                                name = a.name,
                                jhanr = a.jhanrid,
                                path = a.fileaddress
                            };
            dataGridView3.DataSource = musicinfo;

            Console.WriteLine("home is runnning");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var nw = new DataClasses2DataContext();
            var musicinfo = from p in nw.musics
                            where p.name.Contains(textBox1.Text) 
                            select new
                            {
                                id = p.id,
                                name = p.name,
                                p.jhanrid,
                                path = p.fileaddress
                            };
            dataGridView1.DataSource = musicinfo;
           
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                musicid = Int32.Parse(row.Cells["id"].Value.ToString());
                Console.WriteLine(row.Cells["path"].Value.ToString());
                axWindowsMediaPlayer1.URL = row.Cells["path"].Value.ToString();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                DataClasses2DataContext db = new DataClasses2DataContext();

                liked a = new liked();

                a.musicid = musicid;
                a.userid = userid;

                db.likeds.InsertOnSubmit(a);

                db.SubmitChanges();
            }
            
            catch
            {
                Console.WriteLine("has been aded befor!!");
            }

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView2.Rows[e.RowIndex];
                musicid = Int32.Parse(row.Cells["id"].Value.ToString());
                Console.WriteLine(row.Cells["path"].Value.ToString());
                axWindowsMediaPlayer1.URL = row.Cells["path"].Value.ToString();

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            userid = uid;
            var nw = new DataClasses2DataContext();
            var musicinfo = from a in nw.musics
                            join
                                b in nw.likeds on a.id equals b.musicid
                            where b.userid == uid
                            select new
                            {
                                id = a.id,
                                name = a.name,
                                jhanr = a.jhanrid,
                                path = a.fileaddress
                            };
            dataGridView2.DataSource = musicinfo;
            Console.WriteLine("ref reshing");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var nw = new DataClasses2DataContext();
            liked removeFromGroup = (from gm in nw.likeds
                                           where (gm.userid == userid) && (gm.musicid == musicid)
                                           select gm).SingleOrDefault();

            try
            {
                nw.likeds.DeleteOnSubmit(removeFromGroup);
                nw.SubmitChanges();



                 nw = new DataClasses2DataContext();
                var musicinfo = from a in nw.musics
                                join
                                    b in nw.likeds on a.id equals b.musicid
                                where b.userid == uid
                                select new
                                {
                                    id = a.id,
                                    name = a.name,
                                    jhanr = a.jhanrid,
                                    path = a.fileaddress
                                };
                dataGridView2.DataSource = musicinfo;
            }
            catch
            {
                Console.WriteLine("has been deleted befor!!");

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //change password
            change_password a = new change_password(userid);
            a.Show();
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Request_music a = new Request_music(userid);
            a.Show();
        }

        private void home_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db3DataSet.users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.db3DataSet.users);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            usermanagement a = new usermanagement();
            a.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            list_resquest a = new list_resquest();
            a.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            add_music a = new add_music();
            a.Show();
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView3.Rows[e.RowIndex];
                musicid = Int32.Parse(row.Cells["id"].Value.ToString());
                Console.WriteLine(row.Cells["path"].Value.ToString());
                axWindowsMediaPlayer1.URL = row.Cells["path"].Value.ToString();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {

            try
            {
                DataClasses2DataContext db = new DataClasses2DataContext();

                liked a = new liked();

                a.musicid = musicid;
                a.userid = userid;

                db.likeds.InsertOnSubmit(a);

                db.SubmitChanges();
            }

            catch
            {
                Console.WriteLine("has been aded befor!!");
            }

        }

        private void button11_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
