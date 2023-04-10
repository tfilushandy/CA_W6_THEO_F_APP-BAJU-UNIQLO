using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataTable save = new DataTable();
        int x = 27;
        int y = 23;
        int varbaju = 0;
        List<string> list = new List<string>() {
                "U Crew Neck Short-Sleeve T-Shirt", // 0 tshirt
                "DRY-EX Crew Neck Short-Sleeve T-Shirt",
                "Supima Cotton Crew Neck Short-Sleeve T-Shirt",
                "Premium Linen Long-Sleeve Shirt", // 3 shirt
                "DRY-EX Short-Sleeve Polo Shirt",
                "Open Collar Short-Sleeve Shirt",
                "Baker Pants", // 6 short
                "AIRism UV Protection Pocketed Soft Leggings",
                "AIRism Soft Flare Leggings",
                "Dry Stretch Easy Shorts (Leaf)", // 9 longpants
                "Chino Shorts",
                "Linen Blend Shorts",
                "ADIDAS KW", //12 shoes
                "Adidas Ori",
                "Nike Air Force 20",
                "Kalung gaje", //15 jewell
                "Cincin",
                "Ayam goreng",
        };
        List<string> listharga= new List<string>() {
                "170000", // 0 tshirt
                "220000",
                "270000",
                "350000", // 3 shirt
                "230000",
                "450000",
                "450000", // 6 short
                "350000",
                "350000",
                "350000", // 9 longpants
                "450000",
                "450000",
                "1000000", // 12 shoes
                "2200000",
                "1800000",
                "1200000", // 15 jewell
                "2400000",
                "1100000",
        };
        private void Form1_Load(object sender, EventArgs e)
        {
            save.Columns.Add("Item");
            save.Columns.Add("City");
            save.Columns.Add("Price");
            save.Columns.Add("Total");
            dataGridView1.DataSource = save;
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void tOPWEARToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        
        private void tSHIRTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            varbaju = 0;
            x = 27;
            panel1.Visible = true;
            panel1.Controls.Clear();
            for (int i = 0; i < 3; i++)
            {
                PictureBox baru = new PictureBox();
                baru.Size = new Size(90, 158);
                baru.Location = new Point(x, y);
                baru.Image = daftargambartshirt.Images[i];
                Button btnnew = new Button();
                btnnew.Size = new Size(90, 23);
                btnnew.Location = new Point(x, 240);
                btnnew.Text = "Add To Cart";
                btnnew.Tag = varbaju;
                btnnew.Click += Btnnew_Click;
                Label lblnew1 = new Label();
                lblnew1.Text = list[varbaju];
                lblnew1.Location = new Point(x,191);
                Label lblnew2 = new Label();
                lblnew2.Text = listharga[varbaju];
                lblnew2.Location = new Point(x, 220);
                varbaju++;
                x += 150;
                panel1.Controls.Add(btnnew);
                panel1.Controls.Add(lblnew1);
                panel1.Controls.Add(lblnew2);
                panel1.Controls.Add(baru);
            }
        }

        private void sHIRTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            varbaju = 3;
            x = 27;
            panel1.Visible = true;
            panel1.Controls.Clear();
            for (int i = 0; i < 3; i++)
            {
                PictureBox baru = new PictureBox();
                baru.Size = new Size(90, 158);
                baru.Location = new Point(x, y);
                baru.Image = daftargambarshirt.Images[i];
                Button btnnew = new Button();
                btnnew.Size = new Size(90, 23);
                btnnew.Location = new Point(x, 240);
                btnnew.Text = "Add To Cart";
                btnnew.Tag = varbaju;
                btnnew.Click += Btnnew_Click;
                Label lblnew1 = new Label();
                lblnew1.Text = list[varbaju];
                lblnew1.Location = new Point(x, 191);
                Label lblnew2 = new Label();
                lblnew2.Text = listharga[varbaju];
                lblnew2.Location = new Point(x, 220);
                varbaju++;
                x += 150;
                panel1.Controls.Add(btnnew);
                panel1.Controls.Add(lblnew1);
                panel1.Controls.Add(lblnew2);
                panel1.Controls.Add(baru);
            }
        }

        private void Btnnew_Click(object sender, EventArgs e)
        {
            Button apa = sender as Button;
            bool cek = false; int trans = 0;
            for(int i = 0;i<save.Rows.Count;i++)
            {
                if (save.Rows[i][0].ToString() == list[Convert.ToInt32(apa.Tag)])
                {
                    cek = true;
                    trans = i;
                }
            }
            if(cek == true)
            {
                save.Rows[trans][1] = Convert.ToInt32(save.Rows[trans][1]) + 1;
                save.Rows[trans][3] = Convert.ToInt32(save.Rows[trans][1]) * Convert.ToInt32(listharga[Convert.ToInt32(apa.Tag)]);
            }
            else
            {
                int jumlah = 1;
                save.Rows.Add(list[Convert.ToInt32(apa.Tag)], jumlah.ToString(), listharga[Convert.ToInt32(apa.Tag)], jumlah * Convert.ToInt32(listharga[Convert.ToInt32(apa.Tag)]));
                jumlah++;
            }
            int result = 0;
            for (int i = 0; i < save.Rows.Count; i++)
            {
                result += Convert.ToInt32(save.Rows[i][3]);
            }
            textBox1.Text =  result.ToString();
            textBox2.Text =  (result + (result * 10 / 100)).ToString();
        }

        private void sHORTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            varbaju = 6;
            x = 27;
            panel1.Visible = true;
            panel1.Controls.Clear();
            for (int i = 0; i < 3; i++)
            {
                PictureBox baru = new PictureBox();
                baru.Size = new Size(90, 158);
                baru.Location = new Point(x, y);
                baru.Image = daftargambarshorts.Images[i];
                Button btnnew = new Button();
                btnnew.Size = new Size(90, 23);
                btnnew.Location = new Point(x, 240);
                btnnew.Tag = varbaju;
                btnnew.Text = "Add To Cart";
                btnnew.Click += Btnnew_Click;
                Label lblnew1 = new Label();
                lblnew1.Text = list[varbaju];
                lblnew1.Location = new Point(x, 191);
                Label lblnew2 = new Label();
                lblnew2.Text = listharga[varbaju];
                lblnew2.Location = new Point(x, 220);
                varbaju++;
                x += 150;
                panel1.Controls.Add(btnnew);
                panel1.Controls.Add(lblnew1);
                panel1.Controls.Add(lblnew2);
                panel1.Controls.Add(baru);
            }
        }

        private void lONGPANTSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            varbaju = 9;
            x = 27;
            panel1.Visible = true;
            panel1.Controls.Clear();
            for (int i = 0; i < 3; i++)
            {
                PictureBox baru = new PictureBox();
                baru.Size = new Size(90, 158);
                baru.Location = new Point(x, y);
                baru.Image = daftargambarlongpants.Images[i];
                Button btnnew = new Button();
                btnnew.Size = new Size(90, 23);
                btnnew.Location = new Point(x, 240);
                btnnew.Tag = varbaju;
                btnnew.Text = "Add To Cart";
                btnnew.Click += Btnnew_Click;
                Label lblnew1 = new Label();
                lblnew1.Text = list[varbaju];
                lblnew1.Location = new Point(x, 191);
                Label lblnew2 = new Label();
                lblnew2.Text = listharga[varbaju];
                lblnew2.Location = new Point(x, 220);
                varbaju++;
                x += 150;
                panel1.Controls.Add(btnnew);
                panel1.Controls.Add(lblnew1);
                panel1.Controls.Add(lblnew2);
                panel1.Controls.Add(baru);
            }
        }

        private void jEWELLRIESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            varbaju = 15;
            x = 27;
            panel1.Visible = true;
            panel1.Controls.Clear();
            for (int i = 0; i < 3; i++)
            {
                PictureBox baru = new PictureBox();
                baru.Size = new Size(90, 158);
                baru.Location = new Point(x, y);
                baru.Image = daftargambarjewell.Images[i];
                Button btnnew = new Button();
                btnnew.Size = new Size(90, 23);
                btnnew.Location = new Point(x, 240);
                btnnew.Tag = varbaju;
                btnnew.Text = "Add To Cart";
                btnnew.Click += Btnnew_Click;
                Label lblnew1 = new Label();
                lblnew1.Text = list[varbaju];
                lblnew1.Location = new Point(x, 191);
                Label lblnew2 = new Label();
                lblnew2.Text = listharga[varbaju];
                lblnew2.Location = new Point(x, 220);
                varbaju++;
                x += 150;
                panel1.Controls.Add(btnnew);
                panel1.Controls.Add(lblnew1);
                panel1.Controls.Add(lblnew2);
                panel1.Controls.Add(baru);
            }
        }

        private void sHOESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            varbaju = 12;
            x = 27;
            panel1.Visible = true;
            panel1.Controls.Clear();
            for (int i = 0; i < 3; i++)
            {
                PictureBox baru = new PictureBox();
                baru.Size = new Size(90, 158);
                baru.Location = new Point(x, y);
                baru.Image = daftargambarshoes.Images[i];
                Button btnnew = new Button();
                btnnew.Size = new Size(90, 23);
                btnnew.Location = new Point(x, 240);
                btnnew.Tag = varbaju;
                btnnew.Text = "Add To Cart";
                btnnew.Click += Btnnew_Click;
                Label lblnew1 = new Label();
                lblnew1.Text = list[varbaju];
                lblnew1.Location = new Point(x, 191);
                Label lblnew2 = new Label();
                lblnew2.Text = listharga[varbaju];
                lblnew2.Location = new Point(x, 220);
                varbaju++;
                x += 150;
                panel1.Controls.Add(btnnew);
                panel1.Controls.Add(lblnew1);
                panel1.Controls.Add(lblnew2);
                panel1.Controls.Add(baru);
            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //save.Rows[e.RowIndex][3] = Convert.ToInt32(save.Rows[e.RowIndex][2]) * Convert.ToInt32(save.Rows[e.RowIndex][1]);
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            save.Rows[e.RowIndex][3] = Convert.ToInt32(save.Rows[e.RowIndex][2]) * Convert.ToInt32(save.Rows[e.RowIndex][1]);
            if(save.Rows[e.RowIndex][3].ToString() == "0")
            {
                save.Rows.Remove(save.Rows[e.RowIndex]);
            }
            int result = 0;
            for (int i = 0; i < save.Rows.Count; i++)
            {
                result += Convert.ToInt32(save.Rows[i][3]);
            }
            textBox1.Text = result.ToString();
            textBox2.Text = (result + (result % 10)).ToString();
        }
        public void Update(object sender, EventArgs e)
        {
            int result = 0;
            for (int i = 0; i < save.Rows.Count; i++)
            {
                result += Convert.ToInt32(save.Rows[i][3]);
            }
            textBox1.Text = result.ToString();
            textBox2.Text = (result + (result * 10 / 100)).ToString();
        }
    }
}
