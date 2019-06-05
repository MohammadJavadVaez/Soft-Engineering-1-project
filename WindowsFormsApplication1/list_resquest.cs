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
    public partial class list_resquest : Form
    {
        public list_resquest()
        {
            InitializeComponent();
            var nw = new DataClasses2DataContext();
            var uinfo = from a in nw.pishnahads

                        select new
                        {
                            id = a.id,
                            name = a.name_new_music_pishnahadi,
                            userid = a.userid
                          

                        };
            dataGridView1.DataSource = uinfo;
            Console.WriteLine("usermanagement is runnning");
        }

        private void list_resquest_Load(object sender, EventArgs e)
        {

        }
    }
}
