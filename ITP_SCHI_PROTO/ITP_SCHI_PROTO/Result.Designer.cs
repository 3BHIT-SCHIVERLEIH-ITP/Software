namespace ITPPROTO
{
    partial class ResultSelect
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.checkedListBox_kunde = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox_day = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox_month = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox_year = new System.Windows.Forms.CheckedListBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.tabControl1, 12);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(598, 335);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.checkedListBox_day);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(590, 306);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tag";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.checkedListBox_kunde);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(590, 306);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Kunde";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.checkedListBox_month);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(590, 306);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Monat";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.checkedListBox_year);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(590, 306);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Jahr";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 87.58278F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.41722F));
            this.tableLayoutPanel1.Controls.Add(this.tabControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.77458F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.22542F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(604, 417);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // button1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.button1, 2);
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(3, 344);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(598, 70);
            this.button1.TabIndex = 2;
            this.button1.Text = "Anzeigen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkedListBox_kunde
            // 
            this.checkedListBox_kunde.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkedListBox_kunde.FormattingEnabled = true;
            this.checkedListBox_kunde.Location = new System.Drawing.Point(3, 3);
            this.checkedListBox_kunde.Name = "checkedListBox_kunde";
            this.checkedListBox_kunde.Size = new System.Drawing.Size(584, 300);
            this.checkedListBox_kunde.TabIndex = 0;
            this.checkedListBox_kunde.SelectedIndexChanged += new System.EventHandler(this.checkedListBox_kunde_SelectedIndexChanged);
            // 
            // checkedListBox_day
            // 
            this.checkedListBox_day.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkedListBox_day.FormattingEnabled = true;
            this.checkedListBox_day.Location = new System.Drawing.Point(3, 3);
            this.checkedListBox_day.Name = "checkedListBox_day";
            this.checkedListBox_day.Size = new System.Drawing.Size(584, 300);
            this.checkedListBox_day.TabIndex = 1;
            // 
            // checkedListBox_month
            // 
            this.checkedListBox_month.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkedListBox_month.FormattingEnabled = true;
            this.checkedListBox_month.Location = new System.Drawing.Point(0, 0);
            this.checkedListBox_month.Name = "checkedListBox_month";
            this.checkedListBox_month.Size = new System.Drawing.Size(590, 306);
            this.checkedListBox_month.TabIndex = 1;
            // 
            // checkedListBox_year
            // 
            this.checkedListBox_year.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkedListBox_year.FormattingEnabled = true;
            this.checkedListBox_year.Location = new System.Drawing.Point(0, 0);
            this.checkedListBox_year.Name = "checkedListBox_year";
            this.checkedListBox_year.Size = new System.Drawing.Size(590, 306);
            this.checkedListBox_year.TabIndex = 1;
            // 
            // ResultSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 417);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ResultSelect";
            this.Text = "Result";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckedListBox checkedListBox_kunde;
        private System.Windows.Forms.CheckedListBox checkedListBox_day;
        private System.Windows.Forms.CheckedListBox checkedListBox_month;
        private System.Windows.Forms.CheckedListBox checkedListBox_year;
    }
}