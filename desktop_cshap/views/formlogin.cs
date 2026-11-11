using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace desktop_cshap.views
{
    public partial class formlogin : Form
    {
        string koneksi = "server = localhost;username=root;password=;database=db_spp_sekolah_xii;";
        public formlogin()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            txtpassword.UseSystemPasswordChar = true;
           this.AcceptButton = new System.Windows.Forms.Button();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string username = txtusername.Text;
            string password = txtpassword.Text;

            MySqlCommand komando = new MySqlCommand();
            

            //validasi k
            //osong
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password)) {
                MessageBox.Show("jangan ada yang kosong biarkan dompet saya yang kosong", "error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

                txtusername.Focus();
            }

            else
            {
                
            }

            formDasboard well = new formDasboard();
            well.Show();

            formlogin anuanu = new formlogin();
            this.Hide();
       }

       
        

        private void linkregister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            formregisterpetugas formregisterpetugas = new formregisterpetugas();
            formregisterpetugas.Show();

            formlogin aing = new formlogin();
            this.Hide();
            
          
        }
    }
}
