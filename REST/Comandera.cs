using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace REST
{
    public partial class Comandera : Form
    {
        public Comandera()
        {
            InitializeComponent();
            
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Comandera_Load(object sender, EventArgs e)
        {
          
        }
        

            private void Button2_Click(object sender, EventArgs e)
        {
            //int cant = int.Parse(txt_cantidad.Text);
            
            
            dataGridView1.Rows.Add(1,"hamburguesa",25,25);

            

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(1, "Hot dog sencillo", 20, 20);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(1, "Rebanadad de pizza", 30, 30);
        }

        private void Txt_total_TextChanged(object sender, EventArgs e)
        {
            
        }

        public  void Button1_Click(object sender, EventArgs e)
        {
            int total = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                total += Convert.ToInt32(row.Cells["subtotal"].Value);
            }
            txt_total.Text = Convert.ToString(total);
        }
    }
}
