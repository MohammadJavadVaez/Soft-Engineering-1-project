using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net.Mail;
using System.Text;

namespace WindowsFormsApplication1
{
    public partial class Forgetpassword : Form
    {
        public Forgetpassword()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("no internet connection");
        }

        private void Forgetpassword_Load(object sender, EventArgs e)
        {

            // Command line argument must the the SMTP host.
            SmtpClient client = new SmtpClient();
            client.Port = 587;
            client.Host = "smtp.gmail.com";
            client.EnableSsl = true;
            client.Timeout = 10000;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            client.Credentials = new System.Net.NetworkCredential("mahdi1468@gmail.com", "77311377mM*");

            MailMessage mm = new MailMessage("mi1468@yahoo.com", "mi1468@yahoo.com", "test", "test");
            mm.BodyEncoding = UTF8Encoding.UTF8;
            mm.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;

            client.Send(mm);      
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
