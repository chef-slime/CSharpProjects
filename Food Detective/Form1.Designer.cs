using System.Windows.Forms;
namespace Harmful_Ingredients_Search
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.myToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.inputTxtBox = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.foodListBox = new System.Windows.Forms.ListBox();
            this.appIcon = new System.Windows.Forms.PictureBox();
            this.accessPanel = new System.Windows.Forms.Panel();
            this.disclaimerIcon = new System.Windows.Forms.PictureBox();
            this.disclaimerBtn = new System.Windows.Forms.Button();
            this.sourcesIcon = new System.Windows.Forms.PictureBox();
            this.sourcesBtn = new System.Windows.Forms.Button();
            this.aboutBtn = new System.Windows.Forms.Button();
            this.homeBtn = new System.Windows.Forms.Button();
            this.indicatorPanel = new System.Windows.Forms.Panel();
            this.searchIcon = new System.Windows.Forms.PictureBox();
            this.homeIcon = new System.Windows.Forms.PictureBox();
            this.donateBtn = new System.Windows.Forms.Button();
            this.minBtn = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.aboutTextLbl = new System.Windows.Forms.Label();
            this.aboutLbl = new System.Windows.Forms.Label();
            this.bad_ingredients_Pnl = new System.Windows.Forms.Panel();
            this.resetBtn = new System.Windows.Forms.Button();
            this.allBtn = new System.Windows.Forms.Button();
            this.badingredientsLb = new System.Windows.Forms.ListBox();
            this.resetBtn2 = new System.Windows.Forms.Button();
            this.badBtn = new System.Windows.Forms.Button();
            this.ingredientsTb = new System.Windows.Forms.RichTextBox();
            this.sourcesPnl = new System.Windows.Forms.Panel();
            this.sourcesTitle = new System.Windows.Forms.Label();
            this.sourcesLinkLbl = new System.Windows.Forms.LinkLabel();
            this.sourcesLbl = new System.Windows.Forms.Label();
            this.disclaimerPnl = new System.Windows.Forms.Panel();
            this.disclaimerLbl = new System.Windows.Forms.Label();
            this.disclaimerTitle = new System.Windows.Forms.Label();
            this.all_ingredients_Pnl = new System.Windows.Forms.Panel();
            this.aboutPnl = new System.Windows.Forms.Panel();
            this.referencesLbl = new System.Windows.Forms.Label();
            this.wcLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.appIcon)).BeginInit();
            this.accessPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.disclaimerIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sourcesIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeIcon)).BeginInit();
            this.bad_ingredients_Pnl.SuspendLayout();
            this.sourcesPnl.SuspendLayout();
            this.disclaimerPnl.SuspendLayout();
            this.all_ingredients_Pnl.SuspendLayout();
            this.aboutPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputTxtBox
            // 
            this.inputTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(241)))), ((int)(((byte)(232)))));
            this.inputTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputTxtBox.Font = new System.Drawing.Font("Rockwell", 20.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputTxtBox.Location = new System.Drawing.Point(329, 211);
            this.inputTxtBox.Name = "inputTxtBox";
            this.inputTxtBox.Size = new System.Drawing.Size(613, 32);
            this.inputTxtBox.TabIndex = 13;
            this.myToolTip.SetToolTip(this.inputTxtBox, "Enter a food");
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(241)))), ((int)(((byte)(232)))));
            this.searchBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchBtn.BackgroundImage")));
            this.searchBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.searchBtn.FlatAppearance.BorderSize = 0;
            this.searchBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.searchBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(241)))), ((int)(((byte)(232)))));
            this.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.searchBtn.Location = new System.Drawing.Point(949, 211);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(25, 32);
            this.searchBtn.TabIndex = 14;
            this.myToolTip.SetToolTip(this.searchBtn, "Search for a food");
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // foodListBox
            // 
            this.foodListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(241)))), ((int)(((byte)(232)))));
            this.foodListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.foodListBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.foodListBox.Font = new System.Drawing.Font("Rockwell", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foodListBox.FormattingEnabled = true;
            this.foodListBox.IntegralHeight = false;
            this.foodListBox.ItemHeight = 23;
            this.foodListBox.Location = new System.Drawing.Point(329, 309);
            this.foodListBox.Name = "foodListBox";
            this.foodListBox.Size = new System.Drawing.Size(613, 411);
            this.foodListBox.TabIndex = 15;
            this.myToolTip.SetToolTip(this.foodListBox, "Foods similar to the one searched");
            this.foodListBox.Click += new System.EventHandler(this.foodListBox_Click);
            // 
            // appIcon
            // 
            this.appIcon.BackColor = System.Drawing.Color.Transparent;
            this.appIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("appIcon.BackgroundImage")));
            this.appIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.appIcon.Location = new System.Drawing.Point(28, 5);
            this.appIcon.Name = "appIcon";
            this.appIcon.Size = new System.Drawing.Size(218, 184);
            this.appIcon.TabIndex = 0;
            this.appIcon.TabStop = false;
            this.appIcon.MouseDown += new System.Windows.Forms.MouseEventHandler(this.initialForm_MouseDown);
            // 
            // accessPanel
            // 
            this.accessPanel.BackColor = System.Drawing.Color.Transparent;
            this.accessPanel.Controls.Add(this.disclaimerIcon);
            this.accessPanel.Controls.Add(this.disclaimerBtn);
            this.accessPanel.Controls.Add(this.sourcesIcon);
            this.accessPanel.Controls.Add(this.sourcesBtn);
            this.accessPanel.Controls.Add(this.aboutBtn);
            this.accessPanel.Controls.Add(this.homeBtn);
            this.accessPanel.Controls.Add(this.indicatorPanel);
            this.accessPanel.Controls.Add(this.searchIcon);
            this.accessPanel.Controls.Add(this.homeIcon);
            this.accessPanel.Controls.Add(this.appIcon);
            this.accessPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.accessPanel.Location = new System.Drawing.Point(0, 0);
            this.accessPanel.Name = "accessPanel";
            this.accessPanel.Size = new System.Drawing.Size(312, 720);
            this.accessPanel.TabIndex = 1;
            this.accessPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.initialForm_MouseDown);
            // 
            // disclaimerIcon
            // 
            this.disclaimerIcon.BackColor = System.Drawing.Color.Transparent;
            this.disclaimerIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("disclaimerIcon.BackgroundImage")));
            this.disclaimerIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.disclaimerIcon.Location = new System.Drawing.Point(44, 509);
            this.disclaimerIcon.Name = "disclaimerIcon";
            this.disclaimerIcon.Size = new System.Drawing.Size(67, 68);
            this.disclaimerIcon.TabIndex = 13;
            this.disclaimerIcon.TabStop = false;
            // 
            // disclaimerBtn
            // 
            this.disclaimerBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.disclaimerBtn.FlatAppearance.BorderSize = 0;
            this.disclaimerBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(241)))), ((int)(((byte)(232)))));
            this.disclaimerBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.disclaimerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.disclaimerBtn.Font = new System.Drawing.Font("Rockwell", 21.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disclaimerBtn.Location = new System.Drawing.Point(117, 509);
            this.disclaimerBtn.Name = "disclaimerBtn";
            this.disclaimerBtn.Size = new System.Drawing.Size(192, 77);
            this.disclaimerBtn.TabIndex = 12;
            this.disclaimerBtn.Text = "Disclaimer";
            this.disclaimerBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.disclaimerBtn.UseVisualStyleBackColor = true;
            this.disclaimerBtn.Click += new System.EventHandler(this.disclaimerBtn_Click);
            // 
            // sourcesIcon
            // 
            this.sourcesIcon.BackColor = System.Drawing.Color.Transparent;
            this.sourcesIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sourcesIcon.BackgroundImage")));
            this.sourcesIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.sourcesIcon.Location = new System.Drawing.Point(44, 404);
            this.sourcesIcon.Name = "sourcesIcon";
            this.sourcesIcon.Size = new System.Drawing.Size(67, 68);
            this.sourcesIcon.TabIndex = 11;
            this.sourcesIcon.TabStop = false;
            // 
            // sourcesBtn
            // 
            this.sourcesBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.sourcesBtn.FlatAppearance.BorderSize = 0;
            this.sourcesBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(241)))), ((int)(((byte)(232)))));
            this.sourcesBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.sourcesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sourcesBtn.Font = new System.Drawing.Font("Rockwell", 21.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sourcesBtn.Location = new System.Drawing.Point(117, 404);
            this.sourcesBtn.Name = "sourcesBtn";
            this.sourcesBtn.Size = new System.Drawing.Size(151, 77);
            this.sourcesBtn.TabIndex = 10;
            this.sourcesBtn.Text = "Sources";
            this.sourcesBtn.UseVisualStyleBackColor = true;
            this.sourcesBtn.Click += new System.EventHandler(this.sourcesBtn_Click);
            // 
            // aboutBtn
            // 
            this.aboutBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.aboutBtn.FlatAppearance.BorderSize = 0;
            this.aboutBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(241)))), ((int)(((byte)(232)))));
            this.aboutBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.aboutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aboutBtn.Font = new System.Drawing.Font("Rockwell", 21.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutBtn.Location = new System.Drawing.Point(117, 299);
            this.aboutBtn.Name = "aboutBtn";
            this.aboutBtn.Size = new System.Drawing.Size(151, 77);
            this.aboutBtn.TabIndex = 9;
            this.aboutBtn.Text = "About";
            this.aboutBtn.UseVisualStyleBackColor = true;
            this.aboutBtn.Click += new System.EventHandler(this.aboutBtn_Click);
            // 
            // homeBtn
            // 
            this.homeBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.homeBtn.FlatAppearance.BorderSize = 0;
            this.homeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(241)))), ((int)(((byte)(232)))));
            this.homeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.homeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeBtn.Font = new System.Drawing.Font("Rockwell", 21.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeBtn.Location = new System.Drawing.Point(117, 194);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(151, 77);
            this.homeBtn.TabIndex = 8;
            this.homeBtn.Text = "Home";
            this.homeBtn.UseVisualStyleBackColor = true;
            this.homeBtn.Click += new System.EventHandler(this.homeBtn_Click);
            // 
            // indicatorPanel
            // 
            this.indicatorPanel.BackColor = System.Drawing.Color.White;
            this.indicatorPanel.Location = new System.Drawing.Point(12, 195);
            this.indicatorPanel.Name = "indicatorPanel";
            this.indicatorPanel.Size = new System.Drawing.Size(10, 60);
            this.indicatorPanel.TabIndex = 2;
            // 
            // searchIcon
            // 
            this.searchIcon.BackColor = System.Drawing.Color.Transparent;
            this.searchIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchIcon.BackgroundImage")));
            this.searchIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.searchIcon.Location = new System.Drawing.Point(44, 299);
            this.searchIcon.Name = "searchIcon";
            this.searchIcon.Size = new System.Drawing.Size(67, 68);
            this.searchIcon.TabIndex = 3;
            this.searchIcon.TabStop = false;
            // 
            // homeIcon
            // 
            this.homeIcon.BackColor = System.Drawing.Color.Transparent;
            this.homeIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("homeIcon.BackgroundImage")));
            this.homeIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.homeIcon.Location = new System.Drawing.Point(44, 194);
            this.homeIcon.Name = "homeIcon";
            this.homeIcon.Size = new System.Drawing.Size(67, 68);
            this.homeIcon.TabIndex = 1;
            this.homeIcon.TabStop = false;
            // 
            // donateBtn
            // 
            this.donateBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.donateBtn.BackColor = System.Drawing.Color.MediumOrchid;
            this.donateBtn.FlatAppearance.BorderSize = 0;
            this.donateBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(241)))), ((int)(((byte)(232)))));
            this.donateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.donateBtn.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.donateBtn.Location = new System.Drawing.Point(766, 0);
            this.donateBtn.Name = "donateBtn";
            this.donateBtn.Size = new System.Drawing.Size(75, 25);
            this.donateBtn.TabIndex = 4;
            this.donateBtn.Text = "Donate";
            this.donateBtn.UseVisualStyleBackColor = false;
            this.donateBtn.Click += new System.EventHandler(this.donateBtn_Click);
            // 
            // minBtn
            // 
            this.minBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.minBtn.BackColor = System.Drawing.Color.Gold;
            this.minBtn.FlatAppearance.BorderSize = 0;
            this.minBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(241)))), ((int)(((byte)(232)))));
            this.minBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minBtn.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minBtn.Location = new System.Drawing.Point(847, 0);
            this.minBtn.Name = "minBtn";
            this.minBtn.Size = new System.Drawing.Size(63, 25);
            this.minBtn.TabIndex = 6;
            this.minBtn.Text = "-";
            this.minBtn.UseVisualStyleBackColor = false;
            this.minBtn.Click += new System.EventHandler(this.minBtn_Click);
            // 
            // exitButton
            // 
            this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitButton.BackColor = System.Drawing.Color.IndianRed;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(241)))), ((int)(((byte)(232)))));
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(916, 0);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(63, 25);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "x";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.BackColor = System.Drawing.Color.Transparent;
            this.welcomeLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.welcomeLabel.Font = new System.Drawing.Font("Rockwell", 38.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.Location = new System.Drawing.Point(334, 43);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(645, 131);
            this.welcomeLabel.TabIndex = 2;
            this.welcomeLabel.Text = "Food Detective";
            this.welcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.welcomeLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.initialForm_MouseDown);
            // 
            // aboutTextLbl
            // 
            this.aboutTextLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aboutTextLbl.Font = new System.Drawing.Font("Rockwell", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutTextLbl.ForeColor = System.Drawing.Color.White;
            this.aboutTextLbl.Location = new System.Drawing.Point(0, 98);
            this.aboutTextLbl.Name = "aboutTextLbl";
            this.aboutTextLbl.Size = new System.Drawing.Size(645, 277);
            this.aboutTextLbl.TabIndex = 2;
            this.aboutTextLbl.Text = resources.GetString("aboutTextLbl.Text");
            // 
            // aboutLbl
            // 
            this.aboutLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aboutLbl.Font = new System.Drawing.Font("Rockwell", 32F);
            this.aboutLbl.ForeColor = System.Drawing.Color.White;
            this.aboutLbl.Location = new System.Drawing.Point(0, 0);
            this.aboutLbl.Name = "aboutLbl";
            this.aboutLbl.Size = new System.Drawing.Size(645, 94);
            this.aboutLbl.TabIndex = 1;
            this.aboutLbl.Text = "About";
            this.aboutLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bad_ingredients_Pnl
            // 
            this.bad_ingredients_Pnl.BackColor = System.Drawing.Color.Transparent;
            this.bad_ingredients_Pnl.Controls.Add(this.resetBtn);
            this.bad_ingredients_Pnl.Controls.Add(this.allBtn);
            this.bad_ingredients_Pnl.Controls.Add(this.badingredientsLb);
            this.bad_ingredients_Pnl.Location = new System.Drawing.Point(329, 260);
            this.bad_ingredients_Pnl.Name = "bad_ingredients_Pnl";
            this.bad_ingredients_Pnl.Size = new System.Drawing.Size(613, 460);
            this.bad_ingredients_Pnl.TabIndex = 5;
            this.bad_ingredients_Pnl.Visible = false;
            // 
            // resetBtn
            // 
            this.resetBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(223)))), ((int)(((byte)(246)))));
            this.resetBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.resetBtn.FlatAppearance.BorderSize = 0;
            this.resetBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.resetBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(241)))), ((int)(((byte)(232)))));
            this.resetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetBtn.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetBtn.Location = new System.Drawing.Point(485, 0);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(131, 43);
            this.resetBtn.TabIndex = 22;
            this.resetBtn.Text = "Reset";
            this.resetBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.resetBtn.UseVisualStyleBackColor = false;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // allBtn
            // 
            this.allBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(214)))), ((int)(((byte)(187)))));
            this.allBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.allBtn.FlatAppearance.BorderSize = 0;
            this.allBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.allBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(241)))), ((int)(((byte)(232)))));
            this.allBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.allBtn.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allBtn.Location = new System.Drawing.Point(0, 0);
            this.allBtn.Name = "allBtn";
            this.allBtn.Size = new System.Drawing.Size(283, 43);
            this.allBtn.TabIndex = 21;
            this.allBtn.Text = "All Ingredients";
            this.allBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.allBtn.UseVisualStyleBackColor = false;
            this.allBtn.Click += new System.EventHandler(this.allBtn_Click);
            // 
            // badingredientsLb
            // 
            this.badingredientsLb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(241)))), ((int)(((byte)(232)))));
            this.badingredientsLb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.badingredientsLb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.badingredientsLb.Font = new System.Drawing.Font("Rockwell", 15.75F);
            this.badingredientsLb.FormattingEnabled = true;
            this.badingredientsLb.ItemHeight = 23;
            this.badingredientsLb.Location = new System.Drawing.Point(0, 49);
            this.badingredientsLb.Name = "badingredientsLb";
            this.badingredientsLb.Size = new System.Drawing.Size(613, 414);
            this.badingredientsLb.TabIndex = 23;
            this.badingredientsLb.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.badingredientsLb_DrawItem);
            // 
            // resetBtn2
            // 
            this.resetBtn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(223)))), ((int)(((byte)(246)))));
            this.resetBtn2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.resetBtn2.FlatAppearance.BorderSize = 0;
            this.resetBtn2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.resetBtn2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(241)))), ((int)(((byte)(232)))));
            this.resetBtn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetBtn2.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetBtn2.Location = new System.Drawing.Point(485, 0);
            this.resetBtn2.Name = "resetBtn2";
            this.resetBtn2.Size = new System.Drawing.Size(128, 43);
            this.resetBtn2.TabIndex = 19;
            this.resetBtn2.Text = "Reset";
            this.resetBtn2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.resetBtn2.UseVisualStyleBackColor = false;
            this.resetBtn2.Click += new System.EventHandler(this.resetBtn2_Click);
            // 
            // badBtn
            // 
            this.badBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(214)))), ((int)(((byte)(187)))));
            this.badBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.badBtn.FlatAppearance.BorderSize = 0;
            this.badBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.badBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(241)))), ((int)(((byte)(232)))));
            this.badBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.badBtn.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.badBtn.Location = new System.Drawing.Point(0, 0);
            this.badBtn.Name = "badBtn";
            this.badBtn.Size = new System.Drawing.Size(283, 43);
            this.badBtn.TabIndex = 18;
            this.badBtn.Text = "Bad Ingredients";
            this.badBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.badBtn.UseVisualStyleBackColor = false;
            this.badBtn.Click += new System.EventHandler(this.badBtn_Click);
            // 
            // ingredientsTb
            // 
            this.ingredientsTb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(241)))), ((int)(((byte)(232)))));
            this.ingredientsTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ingredientsTb.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingredientsTb.Location = new System.Drawing.Point(0, 49);
            this.ingredientsTb.Name = "ingredientsTb";
            this.ingredientsTb.ReadOnly = true;
            this.ingredientsTb.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.ingredientsTb.Size = new System.Drawing.Size(613, 411);
            this.ingredientsTb.TabIndex = 25;
            this.ingredientsTb.Text = "";
            this.ingredientsTb.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ingredientsTb_MouseClick);
            this.ingredientsTb.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ingredientsTb_MouseDown);
            // 
            // sourcesPnl
            // 
            this.sourcesPnl.BackColor = System.Drawing.Color.Transparent;
            this.sourcesPnl.Controls.Add(this.sourcesTitle);
            this.sourcesPnl.Controls.Add(this.sourcesLinkLbl);
            this.sourcesPnl.Controls.Add(this.sourcesLbl);
            this.sourcesPnl.Location = new System.Drawing.Point(329, 211);
            this.sourcesPnl.Name = "sourcesPnl";
            this.sourcesPnl.Size = new System.Drawing.Size(650, 509);
            this.sourcesPnl.TabIndex = 5;
            this.sourcesPnl.Visible = false;
            // 
            // sourcesTitle
            // 
            this.sourcesTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sourcesTitle.Font = new System.Drawing.Font("Rockwell", 32F);
            this.sourcesTitle.ForeColor = System.Drawing.Color.White;
            this.sourcesTitle.Location = new System.Drawing.Point(0, 0);
            this.sourcesTitle.Name = "sourcesTitle";
            this.sourcesTitle.Size = new System.Drawing.Size(645, 94);
            this.sourcesTitle.TabIndex = 3;
            this.sourcesTitle.Text = "Sources";
            this.sourcesTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // sourcesLinkLbl
            // 
            this.sourcesLinkLbl.AutoSize = true;
            this.sourcesLinkLbl.BackColor = System.Drawing.Color.Transparent;
            this.sourcesLinkLbl.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sourcesLinkLbl.Location = new System.Drawing.Point(368, 188);
            this.sourcesLinkLbl.Name = "sourcesLinkLbl";
            this.sourcesLinkLbl.Size = new System.Drawing.Size(128, 23);
            this.sourcesLinkLbl.TabIndex = 1;
            this.sourcesLinkLbl.TabStop = true;
            this.sourcesLinkLbl.Text = "Sources File";
            this.sourcesLinkLbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.sourcesLinkLbl_LinkClicked);
            // 
            // sourcesLbl
            // 
            this.sourcesLbl.BackColor = System.Drawing.Color.Transparent;
            this.sourcesLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sourcesLbl.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sourcesLbl.ForeColor = System.Drawing.Color.White;
            this.sourcesLbl.Location = new System.Drawing.Point(0, 98);
            this.sourcesLbl.Name = "sourcesLbl";
            this.sourcesLbl.Size = new System.Drawing.Size(650, 116);
            this.sourcesLbl.TabIndex = 2;
            this.sourcesLbl.Text = "The list of harmful ingredients was created based on scientific evidence about th" +
    "em and the symptoms exhibited by those exposed to them. \r\n\r\nHere are the sources" +
    " behind this list: ";
            // 
            // disclaimerPnl
            // 
            this.disclaimerPnl.BackColor = System.Drawing.Color.Transparent;
            this.disclaimerPnl.Controls.Add(this.disclaimerLbl);
            this.disclaimerPnl.Controls.Add(this.disclaimerTitle);
            this.disclaimerPnl.Location = new System.Drawing.Point(329, 211);
            this.disclaimerPnl.Name = "disclaimerPnl";
            this.disclaimerPnl.Size = new System.Drawing.Size(650, 509);
            this.disclaimerPnl.TabIndex = 26;
            this.disclaimerPnl.Visible = false;
            // 
            // disclaimerLbl
            // 
            this.disclaimerLbl.BackColor = System.Drawing.Color.Transparent;
            this.disclaimerLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.disclaimerLbl.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disclaimerLbl.ForeColor = System.Drawing.Color.White;
            this.disclaimerLbl.Location = new System.Drawing.Point(0, 98);
            this.disclaimerLbl.Name = "disclaimerLbl";
            this.disclaimerLbl.Size = new System.Drawing.Size(650, 278);
            this.disclaimerLbl.TabIndex = 26;
            this.disclaimerLbl.Text = resources.GetString("disclaimerLbl.Text");
            // 
            // disclaimerTitle
            // 
            this.disclaimerTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.disclaimerTitle.Font = new System.Drawing.Font("Rockwell", 32F);
            this.disclaimerTitle.ForeColor = System.Drawing.Color.White;
            this.disclaimerTitle.Location = new System.Drawing.Point(0, 0);
            this.disclaimerTitle.Name = "disclaimerTitle";
            this.disclaimerTitle.Size = new System.Drawing.Size(645, 94);
            this.disclaimerTitle.TabIndex = 27;
            this.disclaimerTitle.Text = "Disclaimer";
            this.disclaimerTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // all_ingredients_Pnl
            // 
            this.all_ingredients_Pnl.BackColor = System.Drawing.Color.Transparent;
            this.all_ingredients_Pnl.Controls.Add(this.resetBtn2);
            this.all_ingredients_Pnl.Controls.Add(this.badBtn);
            this.all_ingredients_Pnl.Controls.Add(this.ingredientsTb);
            this.all_ingredients_Pnl.Location = new System.Drawing.Point(329, 260);
            this.all_ingredients_Pnl.Name = "all_ingredients_Pnl";
            this.all_ingredients_Pnl.Size = new System.Drawing.Size(613, 460);
            this.all_ingredients_Pnl.TabIndex = 24;
            this.all_ingredients_Pnl.Visible = false;
            // 
            // aboutPnl
            // 
            this.aboutPnl.BackColor = System.Drawing.Color.Transparent;
            this.aboutPnl.Controls.Add(this.referencesLbl);
            this.aboutPnl.Controls.Add(this.wcLbl);
            this.aboutPnl.Controls.Add(this.aboutLbl);
            this.aboutPnl.Controls.Add(this.aboutTextLbl);
            this.aboutPnl.Location = new System.Drawing.Point(329, 211);
            this.aboutPnl.Name = "aboutPnl";
            this.aboutPnl.Size = new System.Drawing.Size(650, 509);
            this.aboutPnl.TabIndex = 16;
            this.aboutPnl.Visible = false;
            // 
            // referencesLbl
            // 
            this.referencesLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.referencesLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.referencesLbl.Font = new System.Drawing.Font("Rockwell", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.referencesLbl.ForeColor = System.Drawing.Color.White;
            this.referencesLbl.Location = new System.Drawing.Point(0, 418);
            this.referencesLbl.Name = "referencesLbl";
            this.referencesLbl.Size = new System.Drawing.Size(650, 91);
            this.referencesLbl.TabIndex = 4;
            this.referencesLbl.Text = resources.GetString("referencesLbl.Text");
            // 
            // wcLbl
            // 
            this.wcLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.wcLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wcLbl.Font = new System.Drawing.Font("Rockwell", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wcLbl.ForeColor = System.Drawing.Color.White;
            this.wcLbl.Location = new System.Drawing.Point(0, 366);
            this.wcLbl.Name = "wcLbl";
            this.wcLbl.Size = new System.Drawing.Size(650, 22);
            this.wcLbl.TabIndex = 3;
            this.wcLbl.Text = "Works Cited";
            this.wcLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AcceptButton = this.searchBtn;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(977, 720);
            this.Controls.Add(this.donateBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.minBtn);
            this.Controls.Add(this.inputTxtBox);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.accessPanel);
            this.Controls.Add(this.sourcesPnl);
            this.Controls.Add(this.bad_ingredients_Pnl);
            this.Controls.Add(this.all_ingredients_Pnl);
            this.Controls.Add(this.foodListBox);
            this.Controls.Add(this.aboutPnl);
            this.Controls.Add(this.disclaimerPnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1600, 900);
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Food Detective";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.initialForm_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.appIcon)).EndInit();
            this.accessPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.disclaimerIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sourcesIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeIcon)).EndInit();
            this.bad_ingredients_Pnl.ResumeLayout(false);
            this.sourcesPnl.ResumeLayout(false);
            this.sourcesPnl.PerformLayout();
            this.disclaimerPnl.ResumeLayout(false);
            this.all_ingredients_Pnl.ResumeLayout(false);
            this.aboutPnl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox appIcon;
        private System.Windows.Forms.Panel accessPanel;
        private System.Windows.Forms.PictureBox searchIcon;
        private System.Windows.Forms.PictureBox homeIcon;
        private System.Windows.Forms.Panel indicatorPanel;
        private System.Windows.Forms.Button aboutBtn;
        private System.Windows.Forms.Button homeBtn;
        private System.Windows.Forms.Button minBtn;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button donateBtn;
        private System.Windows.Forms.Label welcomeLabel;
        public System.Windows.Forms.TextBox inputTxtBox;
        private System.Windows.Forms.Button searchBtn;
        public System.Windows.Forms.ListBox foodListBox;
        private System.Windows.Forms.Label aboutLbl;
        private System.Windows.Forms.Label aboutTextLbl;
        private System.Windows.Forms.Button sourcesBtn;
        private System.Windows.Forms.PictureBox sourcesIcon;
        private System.Windows.Forms.Panel bad_ingredients_Pnl;
        private System.Windows.Forms.Button allBtn;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.ListBox badingredientsLb;
        private System.Windows.Forms.Button badBtn;
        private System.Windows.Forms.Button resetBtn2;
        public System.Windows.Forms.RichTextBox ingredientsTb;
        private System.Windows.Forms.Panel sourcesPnl;
        private System.Windows.Forms.LinkLabel sourcesLinkLbl;
        private System.Windows.Forms.Label sourcesLbl;
        private System.Windows.Forms.Button disclaimerBtn;
        private System.Windows.Forms.PictureBox disclaimerIcon;
        private System.Windows.Forms.Panel disclaimerPnl;
        private System.Windows.Forms.Label disclaimerLbl;
        private System.Windows.Forms.Label sourcesTitle;
        private System.Windows.Forms.Label disclaimerTitle;
        private ToolTip myToolTip;
        private Panel all_ingredients_Pnl;
        private Panel aboutPnl;
        private Label wcLbl;
        private Label referencesLbl;
    }
}

