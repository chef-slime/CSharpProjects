using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace Harmful_Ingredients_Search
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public Form1()
        {
            InitializeComponent();
        }

        public void Reset()
        {
            inputTxtBox.Clear();
            foodListBox.Items.Clear();
            bad_ingredients_Pnl.Visible = false;
            all_ingredients_Pnl.Visible = false;
            indicatorPanel.Location = new Point(12, 195);
        }

        private void MiddleSearch()
        {
            bad_ingredients_Pnl.Visible = false;
            all_ingredients_Pnl.Visible = false;
        }

        public void DisplayBadIngredients(string selectedFood)
        {
            allingredientsList = new Food_Repository().GetAll_Ingredients(selectedFood);
            harmfulFoods();
            bad_ingredients_Pnl.Visible = true;
            bad_ingredients_Pnl.BringToFront();
        }

        public void ReturnBadIngredients()
        {
            all_ingredients_Pnl.SendToBack();
            bad_ingredients_Pnl.Visible = true;
            bad_ingredients_Pnl.BringToFront();
        }

        public void DisplayAllIngredients(string selectedFood)
        {
            bad_ingredients_Pnl.SendToBack();
            allIngredients();
            all_ingredients_Pnl.Visible = true;
            all_ingredients_Pnl.BringToFront();
        }

        private void donateBtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://secure.everyaction.com/5U6LS7emfUiXFV5qgwF6EA2");
        }

        private void minBtn_Click(object sender, System.EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void exitButton_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void initialForm_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (bad_ingredients_Pnl.Visible == true || all_ingredients_Pnl.Visible == true)
                {
                    MiddleSearch();
                }

                foodListBox.Items.Clear();

                foodListBox.MeasureItem += foodListBox_MeasureItem;

                foodListBox.DrawItem += foodListBox_DrawItem;

                string input = inputTxtBox.Text.Trim();

                foodItems = new Food_Repository().GetFoods(input);

                foodItems.OrderBy(item => item);

                foreach (var element in foodItems)
                {
                    foodListBox.Items.Add(element + "\n\t");
                }

                if (foodListBox.Items.Count == 0)
                {
                    foodListBox.Items.Clear();
                    foodListBox.Items.Add("Sorry. Unknown food item. Please try again.");
                }
            }

            catch (Exception)
            {
                if (inputTxtBox.Text == string.Empty)
                    MessageBox.Show("Input cannot be empty. Please try again.");
                else
                    MessageBox.Show("An error has occurred. Please try again.");
            }
        }

        private void foodListBox_Click(object sender, EventArgs e)
        {
            try
            {
                if (foodListBox.SelectedItem != null)
                {
                    selectedFood = foodListBox.SelectedItem.ToString();

                    selectedFood = selectedFood.Replace("\n\t", "");

                    DisplayBadIngredients(selectedFood);
                }
            }

            catch (Exception)
            {
                    MessageBox.Show("An error has occurred. Please try again.");
            }
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            aboutPnl.Visible = false;
            sourcesPnl.Visible = false;
            disclaimerPnl.Visible = false;
            indicatorPanel.Location = new Point(12, 195);
        }

        private void aboutBtn_Click(object sender, EventArgs e)
        {
            aboutPnl.BringToFront();
            aboutPnl.Visible = true;
            sourcesPnl.Visible = false;
            disclaimerPnl.Visible = false;
            bad_ingredients_Pnl.Visible = false;
            all_ingredients_Pnl.Visible = false;
            indicatorPanel.Location = new Point(12, 300);
        }

        private void sourcesBtn_Click(object sender, EventArgs e)
        {
            sourcesPnl.BringToFront();
            sourcesPnl.Visible = true;
            aboutPnl.Visible = false;
            disclaimerPnl.Visible = false;
            bad_ingredients_Pnl.Visible = false;
            all_ingredients_Pnl.Visible = false;
            indicatorPanel.Location = new Point(12, 405);
        }

        private void sourcesLinkLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://drive.google.com/file/d/1OmCA9SJVmAo8gACEFpMDBsHXgFlta79R/view?usp=sharing");
        }

        private void disclaimerBtn_Click(object sender, EventArgs e)
        {
            disclaimerPnl.BringToFront();
            disclaimerPnl.Visible = true;
            aboutPnl.Visible = false;
            sourcesPnl.Visible = false;
            all_ingredients_Pnl.Visible = false;
            indicatorPanel.Location = new Point(12, 510);
        }

        private void foodListBox_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            e.ItemHeight = (int)e.Graphics.MeasureString(foodListBox.Items[e.Index].ToString(), foodListBox.Font, 600).Height;
        }

        private void foodListBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            e.DrawFocusRectangle();
            e.Graphics.DrawString(foodListBox.Items[e.Index].ToString(), e.Font, new SolidBrush(e.ForeColor), e.Bounds);
        }

        private void allBtn_Click(object sender, EventArgs e)
        {
            allIngredients();
            all_ingredients_Pnl.Visible = true;
            all_ingredients_Pnl.BringToFront();
            bad_ingredients_Pnl.Visible = false;
            disclaimerPnl.Visible = false;
            aboutPnl.Visible = false;
            sourcesPnl.Visible = false;
        }

        private void badBtn_Click(object sender, EventArgs e)
        {
            bad_ingredients_Pnl.Visible = true;
            bad_ingredients_Pnl.BringToFront();
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void resetBtn2_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void harmfulFoods()
        {
            badingredientsLb.Items.Clear();

            try
            {
                if (selectedFood != null)
                {
                    var result = new Food_Repository().GetBad_Ingredients(allingredientsList);

                    lines = SplitByLength(selectedFood, 50).ToArray();

                    badingredientsLb.Items.AddRange(lines);

                    badingredientsLb.Items.Add("");

                    if (result.Count > 0)
                    {
                        badingredientsLb.Items.Add("Harmful Ingredients Detected:");

                        int i = 1;

                        foreach (var element in result)
                        {
                            if (i - 1 < result.Count - 1)
                            {
                                badingredientsLb.Items.Add($"{i}. {element}");
                                i++;
                            }

                            else
                            {
                                badingredientsLb.Items.Add($"{i}. {element}");
                            }
                        }
                    }

                    else
                    {
                        badingredientsLb.Items.Add("No harmful ingredients detected.");
                    }

                    IEnumerable<string> SplitByLength(string selectedFood, int maxLen)
                    {
                        return Regex.Split(selectedFood, @"(.{1," + maxLen + @"})(?:\s|$)")
                                    .Where(x => x.Length > 0)
                                    .Select(x => x.Trim());
                    }
                }
            }

            catch (Exception)
            {
                MessageBox.Show("An error has occurred. Please try again.");
            }
        }

        private void allIngredients()
        {
            try
            {
                ingredientsTb.Text = "Ingredients: ";

                foreach (var element in allingredientsList)
                {
                    ingredientsTb.AppendText(element);
                }
            }

            catch (Exception)
            {
                MessageBox.Show("An error has occurred. Please try again.");
            }
        }

        private void badingredientsLb_DrawItem(object sender, DrawItemEventArgs e)
        {
            SolidBrush cream = new SolidBrush(Color.FromArgb(247, 241, 232));
            e.DrawBackground();
            Graphics g = e.Graphics;
            Brush brush = ((e.State & DrawItemState.Selected) == DrawItemState.Selected) ?
                            cream : cream;
            g.FillRectangle(brush, e.Bounds);
            e.Graphics.DrawString(badingredientsLb.Items[e.Index].ToString(), e.Font,
                        new SolidBrush(Color.Black), e.Bounds, StringFormat.GenericDefault);
            e.DrawFocusRectangle();
        }

        private void ingredientsTb_MouseClick(object sender, MouseEventArgs e)
        {
            resetBtn.Focus();
        }

        private void ingredientsTb_MouseDown(object sender, MouseEventArgs e)
        {
            resetBtn.Focus();
        }

        HashSet<string> foodItems
        {
            get;
            set;
        }

        string selectedFood
        {
            get;
            set;
        }

        List<string> allingredientsList
        {
            get;
            set;
        }

        string[] lines
        {
            get;
            set;
        }

        string userEducation
        {
            get;
            set;
        }

        Dictionary<string,string> links
        {
            get;
            set;
        }

        int index
        {
            get;
            set;
        }
    }
}

