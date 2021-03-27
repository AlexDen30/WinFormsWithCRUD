namespace YP
{
    partial class EditBand
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxDelete = new System.Windows.Forms.GroupBox();
            this.buttonDeleteBand = new System.Windows.Forms.Button();
            this.groupBoxCreateUpdate = new System.Windows.Forms.GroupBox();
            this.buttonInsertBand = new System.Windows.Forms.Button();
            this.buttonUpdateBand = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBoxDelete.SuspendLayout();
            this.groupBoxCreateUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(20, 76);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(196, 27);
            this.textBox1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name:";
            // 
            // groupBoxDelete
            // 
            this.groupBoxDelete.Controls.Add(this.buttonDeleteBand);
            this.groupBoxDelete.Controls.Add(this.label2);
            this.groupBoxDelete.Controls.Add(this.textBox1);
            this.groupBoxDelete.Location = new System.Drawing.Point(250, 324);
            this.groupBoxDelete.Name = "groupBoxDelete";
            this.groupBoxDelete.Size = new System.Drawing.Size(250, 179);
            this.groupBoxDelete.TabIndex = 3;
            this.groupBoxDelete.TabStop = false;
            this.groupBoxDelete.Text = "Delete band by name:";
            // 
            // buttonDeleteBand
            // 
            this.buttonDeleteBand.Location = new System.Drawing.Point(20, 126);
            this.buttonDeleteBand.Name = "buttonDeleteBand";
            this.buttonDeleteBand.Size = new System.Drawing.Size(94, 29);
            this.buttonDeleteBand.TabIndex = 3;
            this.buttonDeleteBand.Text = "Delete";
            this.buttonDeleteBand.UseVisualStyleBackColor = true;
            this.buttonDeleteBand.Click += new System.EventHandler(this.buttonDeleteBand_Click);
            // 
            // groupBoxCreateUpdate
            // 
            this.groupBoxCreateUpdate.Controls.Add(this.buttonInsertBand);
            this.groupBoxCreateUpdate.Controls.Add(this.buttonUpdateBand);
            this.groupBoxCreateUpdate.Controls.Add(this.textBox4);
            this.groupBoxCreateUpdate.Controls.Add(this.label4);
            this.groupBoxCreateUpdate.Controls.Add(this.label3);
            this.groupBoxCreateUpdate.Controls.Add(this.label1);
            this.groupBoxCreateUpdate.Controls.Add(this.textBox3);
            this.groupBoxCreateUpdate.Controls.Add(this.textBox2);
            this.groupBoxCreateUpdate.Location = new System.Drawing.Point(35, 28);
            this.groupBoxCreateUpdate.Name = "groupBoxCreateUpdate";
            this.groupBoxCreateUpdate.Size = new System.Drawing.Size(713, 290);
            this.groupBoxCreateUpdate.TabIndex = 4;
            this.groupBoxCreateUpdate.TabStop = false;
            this.groupBoxCreateUpdate.Text = "Create and update band:";
            // 
            // buttonInsertBand
            // 
            this.buttonInsertBand.Location = new System.Drawing.Point(393, 156);
            this.buttonInsertBand.Name = "buttonInsertBand";
            this.buttonInsertBand.Size = new System.Drawing.Size(230, 64);
            this.buttonInsertBand.TabIndex = 7;
            this.buttonInsertBand.Text = "Insert band";
            this.buttonInsertBand.UseVisualStyleBackColor = true;
            // 
            // buttonUpdateBand
            // 
            this.buttonUpdateBand.Location = new System.Drawing.Point(393, 76);
            this.buttonUpdateBand.Name = "buttonUpdateBand";
            this.buttonUpdateBand.Size = new System.Drawing.Size(230, 64);
            this.buttonUpdateBand.TabIndex = 6;
            this.buttonUpdateBand.Text = "Update by name";
            this.buttonUpdateBand.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(40, 243);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(191, 27);
            this.textBox4.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Description of type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Type of band:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name of band:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(40, 76);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(191, 27);
            this.textBox3.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(40, 156);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(191, 27);
            this.textBox2.TabIndex = 0;
            // 
            // EditBands
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 529);
            this.Controls.Add(this.groupBoxCreateUpdate);
            this.Controls.Add(this.groupBoxDelete);
            this.Name = "EditBands";
            this.Text = "EditBands";
            this.groupBoxDelete.ResumeLayout(false);
            this.groupBoxDelete.PerformLayout();
            this.groupBoxCreateUpdate.ResumeLayout(false);
            this.groupBoxCreateUpdate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBoxDelete;
        private System.Windows.Forms.Button buttonDeleteBand;
        private System.Windows.Forms.GroupBox groupBoxCreateUpdate;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonInsertBand;
        private System.Windows.Forms.Button buttonUpdateBand;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}