namespace Subiect
{
    partial class Form4
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            dataGridView1 = new DataGridView();
            tabPage2 = new TabPage();
            dataGridView2 = new DataGridView();
            tabPage3 = new TabPage();
            tabControl2 = new TabControl();
            tabPage4 = new TabPage();
            tabPage5 = new TabPage();
            label1 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            tabPage3.SuspendLayout();
            tabControl2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(-3, 64);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(916, 476);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(908, 448);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Carti disponibile";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(908, 448);
            dataGridView1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dataGridView2);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(908, 448);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Carti imprumutate";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(1, 0);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(907, 448);
            dataGridView2.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(tabControl2);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(908, 448);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Statistici biblioteca";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            tabControl2.Controls.Add(tabPage4);
            tabControl2.Controls.Add(tabPage5);
            tabControl2.Location = new Point(0, 0);
            tabControl2.Name = "tabControl2";
            tabControl2.SelectedIndex = 0;
            tabControl2.Size = new Size(912, 452);
            tabControl2.TabIndex = 0;
            // 
            // tabPage4
            // 
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(904, 424);
            tabPage4.TabIndex = 0;
            tabPage4.Text = "Numar Utilizatori";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            tabPage5.Location = new Point(4, 24);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(904, 424);
            tabPage5.TabIndex = 1;
            tabPage5.Text = "Carti Populare";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(39, 21);
            label1.Name = "label1";
            label1.Size = new Size(120, 21);
            label1.TabIndex = 1;
            label1.Text = "Email utilizator: ";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(912, 541);
            Controls.Add(label1);
            Controls.Add(tabControl1);
            Name = "Form4";
            Text = "MeniuFreeBook";
            Load += Form4_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            tabPage3.ResumeLayout(false);
            tabControl2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label1;
        private TabPage tabPage3;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private TabControl tabControl2;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}