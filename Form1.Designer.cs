namespace atvalto_20240926
{
    partial class form
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
            this.lbromai = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txromai = new System.Windows.Forms.TextBox();
            this.txarab = new System.Windows.Forms.TextBox();
            this.btirany = new System.Windows.Forms.Button();
            this.btatvalt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbromai
            // 
            this.lbromai.AutoSize = true;
            this.lbromai.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbromai.Location = new System.Drawing.Point(31, 27);
            this.lbromai.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbromai.Name = "lbromai";
            this.lbromai.Size = new System.Drawing.Size(106, 13);
            this.lbromai.TabIndex = 0;
            this.lbromai.Text = "Római szám [I-X]:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(253, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Arab szám [1-10]:";
            // 
            // txromai
            // 
            this.txromai.Location = new System.Drawing.Point(48, 57);
            this.txromai.Name = "txromai";
            this.txromai.Size = new System.Drawing.Size(76, 20);
            this.txromai.TabIndex = 2;
            // 
            // txarab
            // 
            this.txarab.Enabled = false;
            this.txarab.Location = new System.Drawing.Point(269, 57);
            this.txarab.Name = "txarab";
            this.txarab.Size = new System.Drawing.Size(76, 20);
            this.txarab.TabIndex = 3;
            // 
            // btirany
            // 
            this.btirany.Location = new System.Drawing.Point(163, 27);
            this.btirany.Name = "btirany";
            this.btirany.Size = new System.Drawing.Size(75, 23);
            this.btirany.TabIndex = 4;
            this.btirany.Text = "--->";
            this.btirany.UseVisualStyleBackColor = true;
            this.btirany.Click += new System.EventHandler(this.btirany_Click);
            // 
            // btatvalt
            // 
            this.btatvalt.Location = new System.Drawing.Point(163, 76);
            this.btatvalt.Name = "btatvalt";
            this.btatvalt.Size = new System.Drawing.Size(75, 23);
            this.btatvalt.TabIndex = 5;
            this.btatvalt.Text = "Átvált";
            this.btatvalt.UseVisualStyleBackColor = true;
            this.btatvalt.Click += new System.EventHandler(this.btatvalt_Click);
            // 
            // form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 172);
            this.Controls.Add(this.btatvalt);
            this.Controls.Add(this.btirany);
            this.Controls.Add(this.txarab);
            this.Controls.Add(this.txromai);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbromai);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "form";
            this.Text = "Átváltó";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbromai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txromai;
        private System.Windows.Forms.TextBox txarab;
        private System.Windows.Forms.Button btirany;
        private System.Windows.Forms.Button btatvalt;
    }
}

