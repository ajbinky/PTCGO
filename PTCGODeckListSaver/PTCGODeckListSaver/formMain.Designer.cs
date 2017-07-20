namespace PTCGODeckListSaver
{
    partial class formMain
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
            this.btnSave = new System.Windows.Forms.Button();
            this.cbVictory = new System.Windows.Forms.CheckBox();
            this.tbDeckName = new System.Windows.Forms.TextBox();
            this.fbd = new System.Windows.Forms.FolderBrowserDialog();
            this.btnFolder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(82, 44);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(233, 77);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "SAVE DECK LIST";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbVictory
            // 
            this.cbVictory.AutoSize = true;
            this.cbVictory.Checked = true;
            this.cbVictory.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbVictory.Location = new System.Drawing.Point(12, 44);
            this.cbVictory.Name = "cbVictory";
            this.cbVictory.Size = new System.Drawing.Size(64, 17);
            this.cbVictory.TabIndex = 3;
            this.cbVictory.Text = "Victory?";
            this.cbVictory.UseVisualStyleBackColor = true;
            // 
            // tbDeckName
            // 
            this.tbDeckName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDeckName.Location = new System.Drawing.Point(12, 12);
            this.tbDeckName.Name = "tbDeckName";
            this.tbDeckName.Size = new System.Drawing.Size(303, 26);
            this.tbDeckName.TabIndex = 4;
            this.tbDeckName.Text = "Deck Name";
            // 
            // btnFolder
            // 
            this.btnFolder.Location = new System.Drawing.Point(12, 67);
            this.btnFolder.Name = "btnFolder";
            this.btnFolder.Size = new System.Drawing.Size(64, 54);
            this.btnFolder.TabIndex = 5;
            this.btnFolder.Text = "Save Location";
            this.btnFolder.UseVisualStyleBackColor = true;
            this.btnFolder.Click += new System.EventHandler(this.btnFolder_Click);
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 129);
            this.Controls.Add(this.btnFolder);
            this.Controls.Add(this.tbDeckName);
            this.Controls.Add(this.cbVictory);
            this.Controls.Add(this.btnSave);
            this.Name = "formMain";
            this.Text = "Deck List Utility";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox cbVictory;
        private System.Windows.Forms.TextBox tbDeckName;
        private System.Windows.Forms.FolderBrowserDialog fbd;
        private System.Windows.Forms.Button btnFolder;
    }
}

