namespace ArtamedesEditor2
{
    partial class MainMenu
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
            this.SAIEdit = new System.Windows.Forms.Button();
            this.Waypoints = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SAIEdit
            // 
            this.SAIEdit.BackColor = System.Drawing.Color.Indigo;
            this.SAIEdit.FlatAppearance.BorderSize = 0;
            this.SAIEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SAIEdit.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SAIEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SAIEdit.Location = new System.Drawing.Point(13, 57);
            this.SAIEdit.Name = "SAIEdit";
            this.SAIEdit.Size = new System.Drawing.Size(132, 45);
            this.SAIEdit.TabIndex = 0;
            this.SAIEdit.Text = "SAI Edit";
            this.SAIEdit.UseVisualStyleBackColor = false;
            this.SAIEdit.Click += new System.EventHandler(this.SAIEdit_Click);
            // 
            // Waypoints
            // 
            this.Waypoints.BackColor = System.Drawing.Color.Indigo;
            this.Waypoints.FlatAppearance.BorderSize = 0;
            this.Waypoints.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Waypoints.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Waypoints.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Waypoints.Location = new System.Drawing.Point(151, 57);
            this.Waypoints.Name = "Waypoints";
            this.Waypoints.Size = new System.Drawing.Size(140, 45);
            this.Waypoints.TabIndex = 1;
            this.Waypoints.Text = "Waypoints";
            this.Waypoints.UseVisualStyleBackColor = false;
            this.Waypoints.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ArtamedesEditor2.Properties.Resources.fOUjgGf;
            this.ClientSize = new System.Drawing.Size(897, 591);
            this.Controls.Add(this.Waypoints);
            this.Controls.Add(this.SAIEdit);
            this.Name = "MainMenu";
            this.Text = "ArtamedesEditor";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SAIEdit;
        private System.Windows.Forms.Button Waypoints;
    }
}

