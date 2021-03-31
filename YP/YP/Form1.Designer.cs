namespace YP
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Bands = new System.Windows.Forms.GroupBox();
            this.buttonEditBands = new System.Windows.Forms.Button();
            this.buttonSeeBands = new System.Windows.Forms.Button();
            this.listBands = new System.Windows.Forms.ListBox();
            this.Musicians = new System.Windows.Forms.GroupBox();
            this.buttonEditMusicians = new System.Windows.Forms.Button();
            this.buttonSeeMusicians = new System.Windows.Forms.Button();
            this.listMusicians = new System.Windows.Forms.ListBox();
            this.PerfomedSongs = new System.Windows.Forms.GroupBox();
            this.buttonEditDiscs = new System.Windows.Forms.Button();
            this.buttonSeeDiscs = new System.Windows.Forms.Button();
            this.buttonEditPerfomances = new System.Windows.Forms.Button();
            this.buttonSeePerfomances = new System.Windows.Forms.Button();
            this.listDiscs = new System.Windows.Forms.ListBox();
            this.listPerfomances = new System.Windows.Forms.ListBox();
            this.Bands.SuspendLayout();
            this.Musicians.SuspendLayout();
            this.PerfomedSongs.SuspendLayout();
            this.SuspendLayout();
            // 
            // Bands
            // 
            this.Bands.Controls.Add(this.buttonEditBands);
            this.Bands.Controls.Add(this.buttonSeeBands);
            this.Bands.Controls.Add(this.listBands);
            this.Bands.Location = new System.Drawing.Point(36, 28);
            this.Bands.Name = "Bands";
            this.Bands.Size = new System.Drawing.Size(438, 286);
            this.Bands.TabIndex = 0;
            this.Bands.TabStop = false;
            this.Bands.Text = "Bands";
            // 
            // buttonEditBands
            // 
            this.buttonEditBands.Location = new System.Drawing.Point(24, 125);
            this.buttonEditBands.Name = "buttonEditBands";
            this.buttonEditBands.Size = new System.Drawing.Size(123, 54);
            this.buttonEditBands.TabIndex = 2;
            this.buttonEditBands.Text = "Edit bands";
            this.buttonEditBands.UseVisualStyleBackColor = true;
            this.buttonEditBands.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonSeeBands
            // 
            this.buttonSeeBands.Location = new System.Drawing.Point(24, 57);
            this.buttonSeeBands.Name = "buttonSeeBands";
            this.buttonSeeBands.Size = new System.Drawing.Size(123, 52);
            this.buttonSeeBands.TabIndex = 1;
            this.buttonSeeBands.Text = "See bands";
            this.buttonSeeBands.UseVisualStyleBackColor = true;
            this.buttonSeeBands.Click += new System.EventHandler(this.buttonSeeBands_Click);
            // 
            // listBands
            // 
            this.listBands.FormattingEnabled = true;
            this.listBands.HorizontalScrollbar = true;
            this.listBands.ItemHeight = 20;
            this.listBands.Location = new System.Drawing.Point(171, 26);
            this.listBands.Name = "listBands";
            this.listBands.Size = new System.Drawing.Size(247, 244);
            this.listBands.TabIndex = 0;
            // 
            // Musicians
            // 
            this.Musicians.Controls.Add(this.buttonEditMusicians);
            this.Musicians.Controls.Add(this.buttonSeeMusicians);
            this.Musicians.Controls.Add(this.listMusicians);
            this.Musicians.Location = new System.Drawing.Point(507, 28);
            this.Musicians.Name = "Musicians";
            this.Musicians.Size = new System.Drawing.Size(556, 286);
            this.Musicians.TabIndex = 1;
            this.Musicians.TabStop = false;
            this.Musicians.Text = "Musicians";
            // 
            // buttonEditMusicians
            // 
            this.buttonEditMusicians.Location = new System.Drawing.Point(20, 125);
            this.buttonEditMusicians.Name = "buttonEditMusicians";
            this.buttonEditMusicians.Size = new System.Drawing.Size(128, 54);
            this.buttonEditMusicians.TabIndex = 2;
            this.buttonEditMusicians.Text = "Edit musicians";
            this.buttonEditMusicians.UseVisualStyleBackColor = true;
            this.buttonEditMusicians.Click += new System.EventHandler(this.button4_Click);
            // 
            // buttonSeeMusicians
            // 
            this.buttonSeeMusicians.Location = new System.Drawing.Point(20, 57);
            this.buttonSeeMusicians.Name = "buttonSeeMusicians";
            this.buttonSeeMusicians.Size = new System.Drawing.Size(128, 52);
            this.buttonSeeMusicians.TabIndex = 1;
            this.buttonSeeMusicians.Text = "See musicians";
            this.buttonSeeMusicians.UseVisualStyleBackColor = true;
            this.buttonSeeMusicians.Click += new System.EventHandler(this.buttonSeeMusicians_Click);
            // 
            // listMusicians
            // 
            this.listMusicians.FormattingEnabled = true;
            this.listMusicians.HorizontalScrollbar = true;
            this.listMusicians.ItemHeight = 20;
            this.listMusicians.Location = new System.Drawing.Point(217, 26);
            this.listMusicians.Name = "listMusicians";
            this.listMusicians.Size = new System.Drawing.Size(322, 244);
            this.listMusicians.TabIndex = 0;
            // 
            // PerfomedSongs
            // 
            this.PerfomedSongs.Controls.Add(this.buttonEditDiscs);
            this.PerfomedSongs.Controls.Add(this.buttonSeeDiscs);
            this.PerfomedSongs.Controls.Add(this.buttonEditPerfomances);
            this.PerfomedSongs.Controls.Add(this.buttonSeePerfomances);
            this.PerfomedSongs.Controls.Add(this.listDiscs);
            this.PerfomedSongs.Controls.Add(this.listPerfomances);
            this.PerfomedSongs.Location = new System.Drawing.Point(36, 331);
            this.PerfomedSongs.Name = "PerfomedSongs";
            this.PerfomedSongs.Size = new System.Drawing.Size(1027, 385);
            this.PerfomedSongs.TabIndex = 2;
            this.PerfomedSongs.TabStop = false;
            this.PerfomedSongs.Text = "Discs and Performances";
            // 
            // buttonEditDiscs
            // 
            this.buttonEditDiscs.Location = new System.Drawing.Point(491, 134);
            this.buttonEditDiscs.Name = "buttonEditDiscs";
            this.buttonEditDiscs.Size = new System.Drawing.Size(128, 51);
            this.buttonEditDiscs.TabIndex = 5;
            this.buttonEditDiscs.Text = "Edit discs";
            this.buttonEditDiscs.UseVisualStyleBackColor = true;
            this.buttonEditDiscs.Click += new System.EventHandler(this.buttonEditDiscs_Click);
            // 
            // buttonSeeDiscs
            // 
            this.buttonSeeDiscs.Location = new System.Drawing.Point(491, 69);
            this.buttonSeeDiscs.Name = "buttonSeeDiscs";
            this.buttonSeeDiscs.Size = new System.Drawing.Size(128, 52);
            this.buttonSeeDiscs.TabIndex = 4;
            this.buttonSeeDiscs.Text = "See discs";
            this.buttonSeeDiscs.UseVisualStyleBackColor = true;
            this.buttonSeeDiscs.Click += new System.EventHandler(this.buttonSeeDiscs_Click);
            // 
            // buttonEditPerfomances
            // 
            this.buttonEditPerfomances.Location = new System.Drawing.Point(24, 134);
            this.buttonEditPerfomances.Name = "buttonEditPerfomances";
            this.buttonEditPerfomances.Size = new System.Drawing.Size(123, 51);
            this.buttonEditPerfomances.TabIndex = 3;
            this.buttonEditPerfomances.Text = "Edit perfomances";
            this.buttonEditPerfomances.UseVisualStyleBackColor = true;
            this.buttonEditPerfomances.Click += new System.EventHandler(this.buttonEditPerfomances_Click);
            // 
            // buttonSeePerfomances
            // 
            this.buttonSeePerfomances.Location = new System.Drawing.Point(24, 69);
            this.buttonSeePerfomances.Name = "buttonSeePerfomances";
            this.buttonSeePerfomances.Size = new System.Drawing.Size(123, 52);
            this.buttonSeePerfomances.TabIndex = 2;
            this.buttonSeePerfomances.Text = "See perfomances";
            this.buttonSeePerfomances.UseVisualStyleBackColor = true;
            // 
            // listDiscs
            // 
            this.listDiscs.FormattingEnabled = true;
            this.listDiscs.HorizontalScrollbar = true;
            this.listDiscs.ItemHeight = 20;
            this.listDiscs.Location = new System.Drawing.Point(664, 26);
            this.listDiscs.Name = "listDiscs";
            this.listDiscs.Size = new System.Drawing.Size(346, 344);
            this.listDiscs.TabIndex = 1;
            // 
            // listPerfomances
            // 
            this.listPerfomances.FormattingEnabled = true;
            this.listPerfomances.HorizontalScrollbar = true;
            this.listPerfomances.ItemHeight = 20;
            this.listPerfomances.Location = new System.Drawing.Point(171, 26);
            this.listPerfomances.Name = "listPerfomances";
            this.listPerfomances.Size = new System.Drawing.Size(254, 344);
            this.listPerfomances.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 738);
            this.Controls.Add(this.PerfomedSongs);
            this.Controls.Add(this.Musicians);
            this.Controls.Add(this.Bands);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Bands.ResumeLayout(false);
            this.Musicians.ResumeLayout(false);
            this.PerfomedSongs.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Bands;
        private System.Windows.Forms.GroupBox Musicians;
        private System.Windows.Forms.GroupBox PerfomedSongs;
        private System.Windows.Forms.Button buttonEditBands;
        private System.Windows.Forms.Button buttonSeeBands;
        private System.Windows.Forms.ListBox listBands;
        private System.Windows.Forms.Button buttonEditMusicians;
        private System.Windows.Forms.Button buttonMusicians;
        private System.Windows.Forms.ListBox listMusicians;
        private System.Windows.Forms.Button buttonEditDiscs;
        private System.Windows.Forms.Button buttonSeeDiscs;
        private System.Windows.Forms.Button buttonEditPerfomances;
        private System.Windows.Forms.Button buttonSeePerfomances;
        private System.Windows.Forms.ListBox listDiscs;
        private System.Windows.Forms.ListBox listPerfomances;
        private System.Windows.Forms.Button buttonSeeMusicians;
    }
}

