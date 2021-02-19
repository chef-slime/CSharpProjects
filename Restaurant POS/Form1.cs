using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Restaurant_POS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            totalpanel.BorderStyle = BorderStyle.None;
            paymentpanel.BorderStyle = BorderStyle.None;
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                    dataGridView1.Columns[column.Index].Width = 100;
            }
        }

        public double Cost_of_Item()
        {
            double sum = 0;
            for (int j = 0; j < dataGridView1.Rows.Count; j++)
            {
                sum = sum + Convert.ToDouble(dataGridView1.Rows[j].Cells[2].Value);
            }
            return sum;
        }

        private void AddCost()
        {
            double tax = 0.06*Cost_of_Item();
            double total = Cost_of_Item() + tax;

            if (dataGridView1.Rows.Count > 0)
            {
                taxamtlbl.Text = string.Format("{0:c}", tax);
                subtotalamtlbl.Text = string.Format("{0:c}", Cost_of_Item());
                totalamtlbl.Text = string.Format("{0:c}", total);
            }
        }

        public void Change()
        {
            double tax = 0.06 * Cost_of_Item();

            if (dataGridView1.Rows.Count > 0)
            {
                double total = Cost_of_Item() + tax;
                double change = Convert.ToDouble(tenderedamtlbl.Text) - total;
                changeamtlbl.Text = string.Format("{0:c}", change);
            }
        }
        Bitmap bitmap;
        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                int height = dataGridView1.Height;
                dataGridView1.Height = dataGridView1.RowCount * dataGridView1.RowTemplate.Height * 2;
                bitmap = new Bitmap(dataGridView1.Width, dataGridView1.Height);
                dataGridView1.DrawToBitmap(bitmap, new Rectangle(0, 0, dataGridView1.Width, dataGridView1.Height));
                printPreviewDialog1.PrintPreviewControl.Zoom = 1;
                printPreviewDialog1.ShowDialog();
                dataGridView1.Height = height;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                Font font = new Font ("Times New Roman", 12);
                SolidBrush drawBrush = new SolidBrush(Color.Black);
                StringFormat drawFormat = new StringFormat();
                e.Graphics.DrawImage(bitmap, 0, 0);
                e.Graphics.DrawString(subtotallbl.Text + " = " + subtotalamtlbl.Text, font, drawBrush, 450.0F, 30.0F, drawFormat);
                e.Graphics.DrawString(taxlbl.Text + " = " + taxamtlbl.Text, font, drawBrush, 450.0F, 60.0F, drawFormat);
                e.Graphics.DrawString(totallbl.Text + " = " + totalamtlbl.Text, font, drawBrush, 450.0F, 90.0F, drawFormat);
                e.Graphics.DrawString(tenderedlbl.Text + " = " + tenderedamtlbl.Text, font, drawBrush, 450.0F, 120.0F, drawFormat);
                e.Graphics.DrawString(changelbl.Text + " = " + changeamtlbl.Text, font, drawBrush, 450.0F, 150.0F, drawFormat);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            try
            {
                subtotalamtlbl.Text = "";
                taxamtlbl.Text = "";
                totalamtlbl.Text = "";
                paycb.Text = "";
                tenderedamtlbl.Text = "0";
                changeamtlbl.Text = "";
                dataGridView1.Rows.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                paycb.Items.Add("Cash");
                paycb.Items.Add("Credit/Debit");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void NumbersOnly(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if (tenderedamtlbl.Text == "0")
            {
                tenderedamtlbl.Text = "";
                tenderedamtlbl.Text = b.Text;
            }

            else if (b.Text == ".")
            {
                if (!tenderedamtlbl.Text.Contains('.'))
                    tenderedamtlbl.Text = tenderedamtlbl.Text + b.Text;
            }

            else
                tenderedamtlbl.Text = tenderedamtlbl.Text + b.Text;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tenderedamtlbl.Text = "0";
        }

        private void paybtn_Click(object sender, EventArgs e)
        {
            if(paycb.Text == "Cash")
            {
                Change();
            }

            else
            {
                changeamtlbl.Text = "";
                tenderedamtlbl.Text = "0";
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.Remove(row);
            }

            AddCost();

            if (paycb.Text == "Cash")
            {
                Change();
            }

            else
            {
                changeamtlbl.Text = "";
                tenderedamtlbl.Text = "0";
            }
        }

        private void btnKorokke_Click(object sender, EventArgs e)
        {
            double cost = 1;
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Korokke"))
                {
                    row.Cells[1].Value = double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[1].Value = double.Parse((string)row.Cells[1].Value) * cost;
                }
            }
                dataGridView1.Rows.Add("Korokke", "1", cost);
            AddCost();

        }

        private void btnGyoza_Click(object sender, EventArgs e)
        {
            double cost = 3;

            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Gyoza"))
                {
                    row.Cells[1].Value = double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[1].Value = double.Parse((string)row.Cells[1].Value) * cost;
                }
            }
            dataGridView1.Rows.Add("Gyoza", "1", cost);
            AddCost();
        }

        private void btnBao_Click(object sender, EventArgs e)
        {
            double cost = 3.75;

            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Teriyaki Bao"))
                {
                    row.Cells[1].Value = double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[1].Value = double.Parse((string)row.Cells[1].Value) * cost;
                }
            }
            dataGridView1.Rows.Add("Teriyaki Bao", "1", cost);
            AddCost();
        }

        private void btnOkonomiyaki_Click(object sender, EventArgs e)
        {
            double cost = 3.5;

            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Okonomiyaki"))
                {
                    row.Cells[1].Value = double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[1].Value = double.Parse((string)row.Cells[1].Value) * cost;
                }
            }
            dataGridView1.Rows.Add("Okonomiyaki", "1", cost);
            AddCost();
        }

        private void btnYakitori_Click(object sender, EventArgs e)
        {
            double cost = 4;

            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Yakitori"))
                {
                    row.Cells[1].Value = double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[1].Value = double.Parse((string)row.Cells[1].Value) * cost;
                }
            }
            dataGridView1.Rows.Add("Yakitori", "1", cost);
            AddCost();
        }

        private void btnTonkotsuRamen_Click(object sender, EventArgs e)
        {
            double cost = 6;

            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Tonkotsu Ramen"))
                {
                    row.Cells[1].Value = double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[1].Value = double.Parse((string)row.Cells[1].Value) * cost;
                }
            }
            dataGridView1.Rows.Add("Tonkotsu Ramen", "1", cost);
            AddCost();
        }

        private void btnShoyuRamen_Click(object sender, EventArgs e)
        {
            double cost = 7.5;

            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Shoyu Ramen"))
                {
                    row.Cells[1].Value = double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[1].Value = double.Parse((string)row.Cells[1].Value) * cost;
                }
            }
            dataGridView1.Rows.Add("Shoyu Ramen", "1", cost);
            AddCost();
        }

        private void btnTonjiru_Click(object sender, EventArgs e)
        {
            double cost = 3.5;

            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Tonjiru"))
                {
                    row.Cells[1].Value = double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[1].Value = double.Parse((string)row.Cells[1].Value) * cost;
                }
            }
            dataGridView1.Rows.Add("Tonjiru", "1", cost);
            AddCost();
        }

        private void btnCurry_Click(object sender, EventArgs e)
        {
            double cost = 11.45;

            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Katsu Curry"))
                {
                    row.Cells[1].Value = double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[1].Value = double.Parse((string)row.Cells[1].Value) * cost;
                }
            }
            dataGridView1.Rows.Add("Katsu Curry", "1", cost);
            AddCost();
        }

        private void btnOmurice_Click(object sender, EventArgs e)
        {
            double cost = 5.28;

            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Omurice"))
                {
                    row.Cells[1].Value = double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[1].Value = double.Parse((string)row.Cells[1].Value) * cost;
                }
            }
            dataGridView1.Rows.Add("Omurice", "1", cost);
            AddCost();
        }

        private void btnDorayaki_Click(object sender, EventArgs e)
        {
            double cost = 1.94;

            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Dorayaki"))
                {
                    row.Cells[1].Value = double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[1].Value = double.Parse((string)row.Cells[1].Value) * cost;
                }
            }
            dataGridView1.Rows.Add("Dorayaki", "1", cost);
            AddCost();
        }

        private void btnTaiyaki_Click(object sender, EventArgs e)
        {
            double cost = 1.42;

            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Taiyaki"))
                {
                    row.Cells[1].Value = double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[1].Value = double.Parse((string)row.Cells[1].Value) * cost;
                }
            }
            dataGridView1.Rows.Add("Taiyaki", "1", cost);
            AddCost();
        }

        private void btnKakigori_Click(object sender, EventArgs e)
        {
            double cost = 8.03;

            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Kakigori"))
                {
                    row.Cells[1].Value = double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[1].Value = double.Parse((string)row.Cells[1].Value) * cost;
                }
            }
            dataGridView1.Rows.Add("Kakigori", "1", cost);
            AddCost();
        }

        private void btnDaifuku_Click(object sender, EventArgs e)
        {
            double cost = 3.5;

            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Daifuku"))
                {
                    row.Cells[1].Value = double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[1].Value = double.Parse((string)row.Cells[1].Value) * cost;
                }
            }
            dataGridView1.Rows.Add("Daifuku", "1", cost);
            AddCost();
        }

        private void btnDango_Click(object sender, EventArgs e)
        {
            double cost = 6.52;

            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Dango"))
                {
                    row.Cells[1].Value = double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[1].Value = double.Parse((string)row.Cells[1].Value) * cost;
                }
            }
            dataGridView1.Rows.Add("Dango", "1", cost);
            AddCost();
        }

        private void btnCalpis_Click(object sender, EventArgs e)
        {
            double cost = 6.18;

            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Calpis"))
                {
                    row.Cells[1].Value = double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[1].Value = double.Parse((string)row.Cells[1].Value) * cost;
                }
            }
            dataGridView1.Rows.Add("Calpis", "1", cost);
            AddCost();
        }

        private void btnRamune_Click(object sender, EventArgs e)
        {
            double cost = 1.5;

            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Ramune"))
                {
                    row.Cells[1].Value = double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[1].Value = double.Parse((string)row.Cells[1].Value) * cost;
                }
            }
            dataGridView1.Rows.Add("Ramune", "1", cost);
            AddCost();
        }

        private void btnQoo_Click(object sender, EventArgs e)
        {
            double cost = 1;

            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Qoo"))
                {
                    row.Cells[1].Value = double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[1].Value = double.Parse((string)row.Cells[1].Value) * cost;
                }
            }
            dataGridView1.Rows.Add("Qoo", "1", cost);
            AddCost();
        }

        private void btnLatte_Click(object sender, EventArgs e)
        {
            double cost = 5.6;

            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Matcha Latte"))
                {
                    row.Cells[1].Value = double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[1].Value = double.Parse((string)row.Cells[1].Value) * cost;
                }
            }
            dataGridView1.Rows.Add("Matcha Latte", "1", cost);
            AddCost();
        }

        private void btnTea_Click(object sender, EventArgs e)
        {
            double cost = 1;

            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Barley Tea"))
                {
                    row.Cells[1].Value = double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[1].Value = double.Parse((string)row.Cells[1].Value) * cost;
                }
            }
            dataGridView1.Rows.Add("Barley Tea", "1", cost);
            AddCost();
        }
    }
}
