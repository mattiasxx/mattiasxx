using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inlämningsUpggift1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void butSave_Click(object sender, EventArgs e)
        {
            var contact = CreateContact();            
            SaveContactToFile(contact);
        }

        private Contact CreateContact()
        {
            var contact = new Contact()
            {
                FirstName = txtFirstname.Text,
                LastName = txtLastname.Text,
                Address = txtAddress.Text,
                Zip = txtZip.Text,
                Phone = txtPhone.Text,
                Email = txtEmail.Text
            };

            return contact;
        }

        private void SaveContactToFile(Contact contact)
        {
            var sb = new StringBuilder();

            sb.Append(contact.FirstName + ",");
            sb.Append(contact.LastName + ",");
            sb.Append(contact.Address + ";");
            sb.Append(contact.Zip + ",");
            sb.Append(contact.Phone + ",");
            sb.Append(contact.Email + ",");

            try
            {
                using (var sw = new StreamWriter ("AddressBok", true))
                {
                    sw.WriteLine(sb.ToString());
                }
                lblMessage2.ForeColor = Color.Green;
                lblMessage2.Text = @"Contact has been saved";

            }
            catch (Exception)
            {
                lblMessage2.ForeColor = Color.Red;
                lblMessage2.Text = @"Fault, try again";
                
            }

            // todo köaj
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
