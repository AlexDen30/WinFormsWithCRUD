namespace YP
{
    partial class EditPerformance
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonDeletePerformance = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDeleteId = new System.Windows.Forms.TextBox();
            this.textBoxPerformanceId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonInsertPerfomance = new System.Windows.Forms.Button();
            this.buttonUpdatePerformance = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxSongName = new System.Windows.Forms.TextBox();
            this.textBoxCircumstancesPerformance = new System.Windows.Forms.TextBox();
            this.groupBoxDeletePerformance = new System.Windows.Forms.GroupBox();
            this.groupBoxPerfomanceCreateUpdate = new System.Windows.Forms.GroupBox();
            this.textBoxAuthorId = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBoxDeletePerformance.SuspendLayout();
            this.groupBoxPerfomanceCreateUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(234, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Surname:";
            // 
            // buttonDeletePerformance
            // 
            this.buttonDeletePerformance.Location = new System.Drawing.Point(20, 126);
            this.buttonDeletePerformance.Name = "buttonDeletePerformance";
            this.buttonDeletePerformance.Size = new System.Drawing.Size(94, 29);
            this.buttonDeletePerformance.TabIndex = 3;
            this.buttonDeletePerformance.Text = "Delete";
            this.buttonDeletePerformance.UseVisualStyleBackColor = true;
            this.buttonDeletePerformance.Click += new System.EventHandler(this.buttonDeletePerformance_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Performance id:";
            // 
            // textBoxDeleteId
            // 
            this.textBoxDeleteId.Location = new System.Drawing.Point(20, 76);
            this.textBoxDeleteId.Name = "textBoxDeleteId";
            this.textBoxDeleteId.Size = new System.Drawing.Size(196, 27);
            this.textBoxDeleteId.TabIndex = 0;
            // 
            // textBoxPerformanceId
            // 
            this.textBoxPerformanceId.Location = new System.Drawing.Point(40, 201);
            this.textBoxPerformanceId.Name = "textBoxPerformanceId";
            this.textBoxPerformanceId.Size = new System.Drawing.Size(191, 27);
            this.textBoxPerformanceId.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Band:";
            // 
            // buttonInsertPerfomance
            // 
            this.buttonInsertPerfomance.Location = new System.Drawing.Point(356, 201);
            this.buttonInsertPerfomance.Name = "buttonInsertPerfomance";
            this.buttonInsertPerfomance.Size = new System.Drawing.Size(230, 64);
            this.buttonInsertPerfomance.TabIndex = 7;
            this.buttonInsertPerfomance.Text = "Insert performance";
            this.buttonInsertPerfomance.UseVisualStyleBackColor = true;
            this.buttonInsertPerfomance.Click += new System.EventHandler(this.buttonInsertPerfomance_Click);
            // 
            // buttonUpdatePerformance
            // 
            this.buttonUpdatePerformance.Location = new System.Drawing.Point(356, 76);
            this.buttonUpdatePerformance.Name = "buttonUpdatePerformance";
            this.buttonUpdatePerformance.Size = new System.Drawing.Size(230, 64);
            this.buttonUpdatePerformance.TabIndex = 6;
            this.buttonUpdatePerformance.Text = "Update by performance id";
            this.buttonUpdatePerformance.UseVisualStyleBackColor = true;
            this.buttonUpdatePerformance.Click += new System.EventHandler(this.buttonUpdatePerformance_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Description of musician role:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(306, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Circumstances of perfomance(m.b. updated):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Song name:";
            // 
            // textBoxSongName
            // 
            this.textBoxSongName.Location = new System.Drawing.Point(40, 65);
            this.textBoxSongName.Name = "textBoxSongName";
            this.textBoxSongName.Size = new System.Drawing.Size(191, 27);
            this.textBoxSongName.TabIndex = 1;
            // 
            // textBoxCircumstancesPerformance
            // 
            this.textBoxCircumstancesPerformance.Location = new System.Drawing.Point(40, 134);
            this.textBoxCircumstancesPerformance.Name = "textBoxCircumstancesPerformance";
            this.textBoxCircumstancesPerformance.Size = new System.Drawing.Size(191, 27);
            this.textBoxCircumstancesPerformance.TabIndex = 0;
            // 
            // groupBoxDeletePerformance
            // 
            this.groupBoxDeletePerformance.Controls.Add(this.buttonDeletePerformance);
            this.groupBoxDeletePerformance.Controls.Add(this.label2);
            this.groupBoxDeletePerformance.Controls.Add(this.textBoxDeleteId);
            this.groupBoxDeletePerformance.Location = new System.Drawing.Point(188, 463);
            this.groupBoxDeletePerformance.Name = "groupBoxDeletePerformance";
            this.groupBoxDeletePerformance.Size = new System.Drawing.Size(273, 179);
            this.groupBoxDeletePerformance.TabIndex = 3;
            this.groupBoxDeletePerformance.TabStop = false;
            this.groupBoxDeletePerformance.Text = "Delete performance by id:";
            // 
            // groupBoxPerfomanceCreateUpdate
            // 
            this.groupBoxPerfomanceCreateUpdate.Controls.Add(this.textBoxAuthorId);
            this.groupBoxPerfomanceCreateUpdate.Controls.Add(this.label8);
            this.groupBoxPerfomanceCreateUpdate.Controls.Add(this.label7);
            this.groupBoxPerfomanceCreateUpdate.Controls.Add(this.textBoxPerformanceId);
            this.groupBoxPerfomanceCreateUpdate.Controls.Add(this.buttonInsertPerfomance);
            this.groupBoxPerfomanceCreateUpdate.Controls.Add(this.buttonUpdatePerformance);
            this.groupBoxPerfomanceCreateUpdate.Controls.Add(this.label5);
            this.groupBoxPerfomanceCreateUpdate.Controls.Add(this.label6);
            this.groupBoxPerfomanceCreateUpdate.Controls.Add(this.textBoxSongName);
            this.groupBoxPerfomanceCreateUpdate.Controls.Add(this.textBoxCircumstancesPerformance);
            this.groupBoxPerfomanceCreateUpdate.Location = new System.Drawing.Point(44, 44);
            this.groupBoxPerfomanceCreateUpdate.Name = "groupBoxPerfomanceCreateUpdate";
            this.groupBoxPerfomanceCreateUpdate.Size = new System.Drawing.Size(647, 391);
            this.groupBoxPerfomanceCreateUpdate.TabIndex = 4;
            this.groupBoxPerfomanceCreateUpdate.TabStop = false;
            this.groupBoxPerfomanceCreateUpdate.Text = "Create and update perfomance";
            // 
            // textBoxAuthorId
            // 
            this.textBoxAuthorId.Location = new System.Drawing.Point(40, 268);
            this.textBoxAuthorId.Name = "textBoxAuthorId";
            this.textBoxAuthorId.Size = new System.Drawing.Size(191, 27);
            this.textBoxAuthorId.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 245);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "Author id:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(188, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Perfomance id(for update):";
            // 
            // EditPerformance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 663);
            this.Controls.Add(this.groupBoxPerfomanceCreateUpdate);
            this.Controls.Add(this.groupBoxDeletePerformance);
            this.Name = "EditPerformance";
            this.Text = "EditPerformance";
            this.groupBoxDeletePerformance.ResumeLayout(false);
            this.groupBoxDeletePerformance.PerformLayout();
            this.groupBoxPerfomanceCreateUpdate.ResumeLayout(false);
            this.groupBoxPerfomanceCreateUpdate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonDeletePerformance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxDeleteId;
        private System.Windows.Forms.TextBox textBoxPerformanceId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonInsertPerfomance;
        private System.Windows.Forms.Button buttonUpdatePerformance;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxSongName;
        private System.Windows.Forms.TextBox textBoxCircumstancesPerformance;
        private System.Windows.Forms.GroupBox groupBoxDeletePerformance;
        private System.Windows.Forms.GroupBox groupBoxPerfomanceCreateUpdate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxAuthorId;
        private System.Windows.Forms.Label label8;
    }
}