using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegForm
{
    public partial class Form1 : Form
    {
        List<Person> user = new List<Person>();
        public Form1()
        {
            InitializeComponent();
        }

        private void signUp_Click(object sender, EventArgs e)
        {
            user.Add(new Person() { Login = loginBox.Text, Password = passBox.Text, Name=nameBox.Text});
            
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
                foreach (Person person in user)
                {
                    if (loginBox1.Text == person.Login && passBox1.Text == person.Password)
                    {
                        MessageBox.Show("Welcome to App");
                    }
                    else
                    {
                        MessageBox.Show("Baaad job");
                    }
                }                       
        }
    }
}
