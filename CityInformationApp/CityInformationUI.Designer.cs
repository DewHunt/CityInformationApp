namespace CityInformationApp
{
    partial class CityInformationUI
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.countryTextBox = new System.Windows.Forms.TextBox();
            this.aboutTextBox = new System.Windows.Forms.TextBox();
            this.cityNameTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchCountryRadioButton = new System.Windows.Forms.RadioButton();
            this.searchcityRadioButton = new System.Windows.Forms.RadioButton();
            this.showListView = new System.Windows.Forms.ListView();
            this.serialColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cityNameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.aboutColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.countryColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.saveButton);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.countryTextBox);
            this.groupBox1.Controls.Add(this.aboutTextBox);
            this.groupBox1.Controls.Add(this.cityNameTextBox);
            this.groupBox1.Location = new System.Drawing.Point(94, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(425, 169);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "City Information";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(318, 136);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Country";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "About";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "City Name";
            // 
            // countryTextBox
            // 
            this.countryTextBox.Location = new System.Drawing.Point(122, 110);
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.Size = new System.Drawing.Size(271, 20);
            this.countryTextBox.TabIndex = 2;
            // 
            // aboutTextBox
            // 
            this.aboutTextBox.Location = new System.Drawing.Point(122, 44);
            this.aboutTextBox.Multiline = true;
            this.aboutTextBox.Name = "aboutTextBox";
            this.aboutTextBox.Size = new System.Drawing.Size(271, 60);
            this.aboutTextBox.TabIndex = 1;
            // 
            // cityNameTextBox
            // 
            this.cityNameTextBox.Location = new System.Drawing.Point(122, 18);
            this.cityNameTextBox.Name = "cityNameTextBox";
            this.cityNameTextBox.Size = new System.Drawing.Size(271, 20);
            this.cityNameTextBox.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.searchButton);
            this.groupBox2.Controls.Add(this.searchTextBox);
            this.groupBox2.Controls.Add(this.searchCountryRadioButton);
            this.groupBox2.Controls.Add(this.searchcityRadioButton);
            this.groupBox2.Location = new System.Drawing.Point(94, 202);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(425, 67);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(326, 19);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(146, 19);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(174, 20);
            this.searchTextBox.TabIndex = 2;
            // 
            // searchCountryRadioButton
            // 
            this.searchCountryRadioButton.AutoSize = true;
            this.searchCountryRadioButton.Location = new System.Drawing.Point(26, 40);
            this.searchCountryRadioButton.Name = "searchCountryRadioButton";
            this.searchCountryRadioButton.Size = new System.Drawing.Size(113, 17);
            this.searchCountryRadioButton.TabIndex = 1;
            this.searchCountryRadioButton.TabStop = true;
            this.searchCountryRadioButton.Text = "Search By Country";
            this.searchCountryRadioButton.UseVisualStyleBackColor = true;
            // 
            // searchcityRadioButton
            // 
            this.searchcityRadioButton.AutoSize = true;
            this.searchcityRadioButton.Location = new System.Drawing.Point(26, 17);
            this.searchcityRadioButton.Name = "searchcityRadioButton";
            this.searchcityRadioButton.Size = new System.Drawing.Size(94, 17);
            this.searchcityRadioButton.TabIndex = 0;
            this.searchcityRadioButton.TabStop = true;
            this.searchcityRadioButton.Text = "Search By City";
            this.searchcityRadioButton.UseVisualStyleBackColor = true;
            // 
            // showListView
            // 
            this.showListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.serialColumnHeader,
            this.cityNameColumnHeader,
            this.aboutColumnHeader,
            this.countryColumnHeader});
            this.showListView.FullRowSelect = true;
            this.showListView.Location = new System.Drawing.Point(35, 288);
            this.showListView.Name = "showListView";
            this.showListView.Size = new System.Drawing.Size(558, 190);
            this.showListView.TabIndex = 2;
            this.showListView.UseCompatibleStateImageBehavior = false;
            this.showListView.View = System.Windows.Forms.View.Details;
            this.showListView.DoubleClick += new System.EventHandler(this.showListView_DoubleClick);
            // 
            // serialColumnHeader
            // 
            this.serialColumnHeader.Text = "Serial No.";
            this.serialColumnHeader.Width = 63;
            // 
            // cityNameColumnHeader
            // 
            this.cityNameColumnHeader.Text = "City Name";
            this.cityNameColumnHeader.Width = 115;
            // 
            // aboutColumnHeader
            // 
            this.aboutColumnHeader.Text = "About";
            this.aboutColumnHeader.Width = 203;
            // 
            // countryColumnHeader
            // 
            this.countryColumnHeader.Text = "Country";
            // 
            // CityInformationUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 496);
            this.Controls.Add(this.showListView);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "CityInformationUI";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.CityInformationUI_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox countryTextBox;
        private System.Windows.Forms.TextBox aboutTextBox;
        private System.Windows.Forms.TextBox cityNameTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.RadioButton searchCountryRadioButton;
        private System.Windows.Forms.RadioButton searchcityRadioButton;
        private System.Windows.Forms.ListView showListView;
        private System.Windows.Forms.ColumnHeader serialColumnHeader;
        private System.Windows.Forms.ColumnHeader cityNameColumnHeader;
        private System.Windows.Forms.ColumnHeader aboutColumnHeader;
        private System.Windows.Forms.ColumnHeader countryColumnHeader;
    }
}

