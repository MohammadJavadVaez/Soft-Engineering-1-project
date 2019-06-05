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
    public partial class Request_music : Form
    {
        public int uid;
        public Request_music(int a)
        {

            InitializeComponent();
            uid = a;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var dbn = new DataClasses2DataContext();
            var query = from c in dbn.pishnahads

                        select c;
            DataClasses2DataContext db = new DataClasses2DataContext();

            pishnahad myp = new pishnahad();

            myp.name_new_music_pishnahadi = textBox1.Text;
            myp.userid = uid;

            db.pishnahads.InsertOnSubmit(myp);
            db.SubmitChanges();
            MessageBox.Show("sent!");
            this.Close();

        }

        private void Request_music_Load(object sender, EventArgs e)
        {
            
        }
    }
}
