using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_pkl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
     
        private void btnok_Click(object sender, EventArgs e)
        {
            string nama = txtnama.Text;
            string nis = txtnis.Text;
            if (nama.Length == 0 || nis.Length == 0)
            {
                MessageBox.Show("Ada bagian yang belum diisi\nMohon isi terlebih dahulu!","peringatan",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
                
            }
            lblhasil.Visible = true;
            string a = datePicker.Value.ToLongDateString();
            lblhasil.Text = "Hello "+txtnama.Text+"\n"+txtnis.Text+"\n"+a;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            datePicker.Format = DateTimePickerFormat.Custom;
            datePicker.CustomFormat = "dddd,dd-MM-yy";

        }
    }
}
