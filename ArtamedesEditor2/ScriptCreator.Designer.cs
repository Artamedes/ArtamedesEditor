namespace ArtamedesEditor2
{
    partial class ScriptCreator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScriptCreator));
            this.Type = new System.Windows.Forms.ComboBox();
            this.Name = new System.Windows.Forms.TextBox();
            this.Entry = new System.Windows.Forms.TextBox();
            this.EntryLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.Output = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Type
            // 
            this.Type.BackColor = System.Drawing.Color.Black;
            this.Type.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Type.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Type.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Type.FormattingEnabled = true;
            this.Type.Items.AddRange(new object[] {
            "ScriptedAI",
            "InstanceScript",
            "CreatureScript",
            "SpellScript",
            "AuraScript"});
            this.Type.Location = new System.Drawing.Point(12, 69);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(219, 26);
            this.Type.TabIndex = 0;
            this.Type.SelectedIndexChanged += new System.EventHandler(this.Type_SelectedIndexChanged);
            // 
            // Name
            // 
            this.Name.BackColor = System.Drawing.SystemColors.InfoText;
            this.Name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Name.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Name.Location = new System.Drawing.Point(12, 166);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(219, 19);
            this.Name.TabIndex = 1;
            this.Name.TextChanged += new System.EventHandler(this.Name_TextChanged);
            // 
            // Entry
            // 
            this.Entry.BackColor = System.Drawing.SystemColors.InfoText;
            this.Entry.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Entry.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Entry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Entry.Location = new System.Drawing.Point(12, 141);
            this.Entry.Name = "Entry";
            this.Entry.Size = new System.Drawing.Size(219, 19);
            this.Entry.TabIndex = 2;
            this.Entry.TextChanged += new System.EventHandler(this.Entry_TextChanged);
            // 
            // EntryLabel
            // 
            this.EntryLabel.AutoSize = true;
            this.EntryLabel.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EntryLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.EntryLabel.Location = new System.Drawing.Point(238, 141);
            this.EntryLabel.Name = "EntryLabel";
            this.EntryLabel.Size = new System.Drawing.Size(47, 18);
            this.EntryLabel.TabIndex = 3;
            this.EntryLabel.Text = "Entry";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.NameLabel.Location = new System.Drawing.Point(238, 167);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(52, 18);
            this.NameLabel.TabIndex = 4;
            this.NameLabel.Text = "Name";
            this.NameLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TypeLabel.Location = new System.Drawing.Point(238, 77);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(43, 18);
            this.TypeLabel.TabIndex = 5;
            this.TypeLabel.Text = "Type";
            // 
            // Output
            // 
            this.Output.BackColor = System.Drawing.SystemColors.Desktop;
            this.Output.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Output.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Output.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Output.Location = new System.Drawing.Point(601, -1);
            this.Output.Multiline = true;
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(1004, 855);
            this.Output.TabIndex = 6;
            // 
            // ScriptCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(61)))));
            this.BackgroundImage = global::ArtamedesEditor2.Properties.Resources._55539278_2070734149711546_8815038603986993152_n;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1607, 847);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.TypeLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.EntryLabel);
            this.Controls.Add(this.Entry);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.Type);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            ///this.Name = "ScriptCreator";
            this.Text = "ScriptCreator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Type;
        private System.Windows.Forms.TextBox Name;
        private System.Windows.Forms.TextBox Entry;
        private System.Windows.Forms.Label EntryLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.TextBox Output;
    }
}