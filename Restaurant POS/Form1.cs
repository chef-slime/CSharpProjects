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
            double tax = 0.06 * Cost_of_Item();
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
            double cost = MenuDataset.ItemCost["Korokke"];
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                if (row.Cells[0]?.Value?.ToString() == MenuDataset.Korokke && MenuDataset.ItemCost.TryGetValue(MenuDataset.Korokke, out cost))
                {
                    row.Cells[1].Value = double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[1].Value = double.Parse((string)row.Cells[1].Value) * cost;
                }
            }
            dataGridView1.Rows.Add(MenuDataset.Korokke, "1", cost);
            AddCost();

        }

        private void btnGyoza_Click(object sender, EventArgs e)
        {
            double cost = MenuDataset.ItemCost["Gyoza"];

            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                if (row.Cells[0]?.Value?.ToString() == MenuDataset.Gyoza && MenuDataset.ItemCost.TryGetValue(MenuDataset.Gyoza, out cost))
                {
                    row.Cells[1].Value = double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[1].Value = double.Parse((string)row.Cells[1].Value) * cost;
                }
            }
            dataGridView1.Rows.Add(MenuDataset.Gyoza, "1", cost);
            AddCost();
        }

        private void btnBao_Click(object sender, EventArgs e)
        {
            double cost = MenuDataset.ItemCost["Teriyaki Bao"];

            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                if (row.Cells[0]?.Value?.ToString() == MenuDataset.Teriyaki_Bao && MenuDataset.ItemCost.TryGetValue(MenuDataset.Teriyaki_Bao, out cost))
                {
                    row.Cells[1].Value = double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[1].Value = double.Parse((string)row.Cells[1].Value) * cost;
                }
            }
            dataGridView1.Rows.Add(MenuDataset.Teriyaki_Bao, "1", cost);
            AddCost();
        }

        private void btnOkonomiyaki_Click(object sender, EventArgs e)
        {
            double cost = MenuDataset.ItemCost["Okonomiyaki"];

            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                if (row.Cells[0]?.Value?.ToString() == MenuDataset.Okonomiyaki && MenuDataset.ItemCost.TryGetValue(MenuDataset.Okonomiyaki, out cost))
                {
                    row.Cells[1].Value = double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[1].Value = double.Parse((string)row.Cells[1].Value) * cost;
                }
            }
            dataGridView1.Rows.Add(MenuDataset.Okonomiyaki, "1", cost);
            AddCost();
        }

        private void btnYakitori_Click(object sender, EventArgs e)
        {
            double cost = MenuDataset.ItemCost["Yakitori"];

            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                if (row.Cells[0]?.Value?.ToString() == MenuDataset.Yakitori && MenuDataset.ItemCost.TryGetValue(MenuDataset.Yakitori, out cost))
                {
                    row.Cells[1].Value = double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[1].Value = double.Parse((string)row.Cells[1].Value) * cost;
                }
            }
            dataGridView1.Rows.Add(MenuDataset.Yakitori, "1", cost);
            AddCost();
        }

        private void btnTonkotsuRamen_Click(object sender, EventArgs e)
        {
            double cost = MenuDataset.ItemCost["Tonkotsu Ramen"];

            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                if (row.Cells[0]?.Value?.ToString() == MenuDataset.Tonkotsu_Ramen && MenuDataset.ItemCost.TryGetValue(MenuDataset.Tonkotsu_Ramen, out cost))
                {
                    row.Cells[1].Value = double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[1].Value = double.Parse((string)row.Cells[1].Value) * cost;
                }
            }
            dataGridView1.Rows.Add(MenuDataset.Tonkotsu_Ramen, "1", cost);
            AddCost();
        }

        private void btnShoyuRamen_Click(object sender, EventArgs e)
        {
            double cost = MenuDataset.ItemCost["Shoyu Ramen"];

            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                if (row.Cells[0]?.Value?.ToString() == MenuDataset.Shoyu_Ramen && MenuDataset.ItemCost.TryGetValue(MenuDataset.Shoyu_Ramen, out cost))
                {
                    row.Cells[1].Value = double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[1].Value = double.Parse((string)row.Cells[1].Value) * cost;
                }
            }
            dataGridView1.Rows.Add(MenuDataset.Shoyu_Ramen, "1", cost);
            AddCost();
        }

        private void btnTonjiru_Click(object sender, EventArgs e)
        {
            double cost = MenuDataset.ItemCost["Tonjiru"];

            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                if (row.Cells[0]?.Value?.ToString() == MenuDataset.Tonjiru && MenuDataset.ItemCost.TryGetValue(MenuDataset.Tonjiru, out cost))
                {
                    row.Cells[1].Value = double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[1].Value = double.Parse((string)row.Cells[1].Value) * cost;
                }
            }
            dataGridView1.Rows.Add(MenuDataset.Tonjiru, "1", cost);
            AddCost();
        }

        private void btnCurry_Click(object sender, EventArgs e)
        {
            double cost = MenuDataset.ItemCost["Katsu Curry"];

            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                if (row.Cells[0]?.Value?.ToString() == MenuDataset.Katsu_Curry && MenuDataset.ItemCost.TryGetValue(MenuDataset.Katsu_Curry, out cost))
                {
                    row.Cells[1].Value = double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[1].Value = double.Parse((string)row.Cells[1].Value) * cost;
                }
            }
            dataGridView1.Rows.Add(MenuDataset.Katsu_Curry, "1", cost);
            AddCost();
        }

        private void btnOmurice_Click(object sender, EventArgs e)
        {
            double cost = MenuDataset.ItemCost["Omurice"];

            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                if (row.Cells[0]?.Value?.ToString() == MenuDataset.Omurice && MenuDataset.ItemCost.TryGetValue(MenuDataset.Omurice, out cost))
                {
                    row.Cells[1].Value = double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[1].Value = double.Parse((string)row.Cells[1].Value) * cost;
                }
            }
            dataGridView1.Rows.Add(MenuDataset.Omurice, "1", cost);
            AddCost();
        }

        private void btnDorayaki_Click(object sender, EventArgs e)
        {
            double cost = MenuDataset.ItemCost["Dorayaki"];

            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                if (row.Cells[0]?.Value?.ToString() == MenuDataset.Dorayaki && MenuDataset.ItemCost.TryGetValue(MenuDataset.Dorayaki, out cost))
                {
                    row.Cells[1].Value = double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[1].Value = double.Parse((string)row.Cells[1].Value) * cost;
                }
            }
            dataGridView1.Rows.Add(MenuDataset.Dorayaki, "1", cost);
            AddCost();
        }

        private void btnTaiyaki_Click(object sender, EventArgs e)
        {
            double cost = MenuDataset.ItemCost["Taiyaki"];

            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                if (row.Cells[0]?.Value?.ToString() == MenuDataset.Taiyaki && MenuDataset.ItemCost.TryGetValue(MenuDataset.Taiyaki, out cost))
                {
                    row.Cells[1].Value = double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[1].Value = double.Parse((string)row.Cells[1].Value) * cost;
                }
            }
            dataGridView1.Rows.Add(MenuDataset.Taiyaki, "1", cost);
            AddCost();
        }

        private void btnKakigori_Click(object sender, EventArgs e)
        {
            double cost = MenuDataset.ItemCost["Kakigori"];

            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                if (row.Cells[0]?.Value?.ToString() == MenuDataset.Kakigori && MenuDataset.ItemCost.TryGetValue(MenuDataset.Kakigori, out cost))
                {
                    row.Cells[1].Value = double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[1].Value = double.Parse((string)row.Cells[1].Value) * cost;
                }
            }
            dataGridView1.Rows.Add(MenuDataset.Kakigori, "1", cost);
            AddCost();
        }

        private void btnDaifuku_Click(object sender, EventArgs e)
        {
            double cost = MenuDataset.ItemCost["Daifuku"];

            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                if (row.Cells[0]?.Value?.ToString() == MenuDataset.Daifuku && MenuDataset.ItemCost.TryGetValue(MenuDataset.Daifuku, out cost))
                {
                    row.Cells[1].Value = double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[1].Value = double.Parse((string)row.Cells[1].Value) * cost;
                }
            }
            dataGridView1.Rows.Add(MenuDataset.Daifuku, "1", cost);
            AddCost();
        }

        private void btnDango_Click(object sender, EventArgs e)
        {
            double cost = MenuDataset.ItemCost["Dango"];

            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                if (row.Cells[0]?.Value?.ToString() == MenuDataset.Dango && MenuDataset.ItemCost.TryGetValue(MenuDataset.Dango, out cost))
                {
                    row.Cells[1].Value = double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[1].Value = double.Parse((string)row.Cells[1].Value) * cost;
                }
            }
            dataGridView1.Rows.Add(MenuDataset.Dango, "1", cost);
            AddCost();
        }

        private void btnCalpis_Click(object sender, EventArgs e)
        {
            double cost = MenuDataset.ItemCost["Calpis"];

            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                if (row.Cells[0]?.Value?.ToString() == MenuDataset.Calpis && MenuDataset.ItemCost.TryGetValue(MenuDataset.Calpis, out cost))
                {
                    row.Cells[1].Value = double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[1].Value = double.Parse((string)row.Cells[1].Value) * cost;
                }
            }
            dataGridView1.Rows.Add(MenuDataset.Calpis, "1", cost);
            AddCost();
        }

        private void btnRamune_Click(object sender, EventArgs e)
        {
            double cost = MenuDataset.ItemCost["Ramune"];

            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                if (row.Cells[0]?.Value?.ToString() == MenuDataset.Ramune && MenuDataset.ItemCost.TryGetValue(MenuDataset.Ramune, out cost))
                {
                    row.Cells[1].Value = double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[1].Value = double.Parse((string)row.Cells[1].Value) * cost;
                }
            }
            dataGridView1.Rows.Add(MenuDataset.Ramune, "1", cost);
            AddCost();
        }

        private void btnQoo_Click(object sender, EventArgs e)
        {
            double cost = MenuDataset.ItemCost["Qoo"];

            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                if (row.Cells[0]?.Value?.ToString() == MenuDataset.Qoo && MenuDataset.ItemCost.TryGetValue(MenuDataset.Qoo, out cost))
                {
                    row.Cells[1].Value = double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[1].Value = double.Parse((string)row.Cells[1].Value) * cost;
                }
            }
            dataGridView1.Rows.Add(MenuDataset.Qoo, "1", cost);
            AddCost();
        }

        private void btnLatte_Click(object sender, EventArgs e)
        {
            double cost = MenuDataset.ItemCost["Matcha Latte"];

            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                if (row.Cells[0]?.Value?.ToString() == MenuDataset.Matcha_Latte && MenuDataset.ItemCost.TryGetValue(MenuDataset.Matcha_Latte, out cost))
                {
                    row.Cells[1].Value = double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[1].Value = double.Parse((string)row.Cells[1].Value) * cost;
                }
            }
            dataGridView1.Rows.Add(MenuDataset.Matcha_Latte, "1", cost);
            AddCost();
        }

        private void btnTea_Click(object sender, EventArgs e)
        {
            double cost = MenuDataset.ItemCost["Barley Tea"];

            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                if (row.Cells[0]?.Value?.ToString() == MenuDataset.Barley_Tea  // Equal to: row.Cells[0] != null && row.Cells[0].Value != null && row.Cells[0].Value..ToString() == "Barley Tea"
                    && MenuDataset.ItemCost.TryGetValue(MenuDataset.Barley_Tea, out cost))
                {
                    row.Cells[1].Value = double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[1].Value = double.Parse((string)row.Cells[1].Value) * cost;
                }
            }
            dataGridView1.Rows.Add(MenuDataset.Barley_Tea, "1", cost);
            AddCost();
        }
    }
}
