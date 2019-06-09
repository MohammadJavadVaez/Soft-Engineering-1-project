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
    public partial class add_music : Form
    {
        public add_music()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var dbn = new DataClasses2DataContext();
            var query = from c in dbn.musics
                        select c;
            DataClasses2DataContext db = new DataClasses2DataContext();

            music myp = new music();

            myp.fileaddress = textBox1.Text;
            myp.name = textBox2.Text;
            myp.jhanrid = Int32.Parse(textBox3.Text);
            db.musics.InsertOnSubmit(myp);
            db.SubmitChanges();
            MessageBox.Show("added!");
            //this.Close();
        }
    }
}
