using System;
using System.Windows.Forms;

namespace ExtruderHesap
{
    public partial class PasswordForm : Form
    {
        public PasswordForm()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string password = "Nexans2024*"; // Belirlediğiniz şifre

            if (txtPassword.Text == password)
            {
                this.DialogResult = DialogResult.OK;
                this.Close(); // Formun kapanmasını sağla
            }
            else
            {
                MessageBox.Show("Hatalı şifre!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
