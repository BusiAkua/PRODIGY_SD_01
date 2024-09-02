
namespace Temperature
{
    partial class CfrmMiain
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
            this.lblFahren = new System.Windows.Forms.Label();
            this.lblCel = new System.Windows.Forms.Label();
            this.txtFahren = new System.Windows.Forms.TextBox();
            this.txtCelsius = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblFahren
            // 
            this.lblFahren.AutoSize = true;
            this.lblFahren.Location = new System.Drawing.Point(32, 57);
            this.lblFahren.Name = "lblFahren";
            this.lblFahren.Size = new System.Drawing.Size(57, 13);
            this.lblFahren.TabIndex = 0;
            this.lblFahren.Text = "Fahrenheit";
            // 
            // lblCel
            // 
            this.lblCel.AutoSize = true;
            this.lblCel.Location = new System.Drawing.Point(208, 57);
            this.lblCel.Name = "lblCel";
            this.lblCel.Size = new System.Drawing.Size(40, 13);
            this.lblCel.TabIndex = 1;
            this.lblCel.Text = "Celsius";
            // 
            // txtFahren
            // 
            this.txtFahren.Location = new System.Drawing.Point(12, 86);
            this.txtFahren.Name = "txtFahren";
            this.txtFahren.Size = new System.Drawing.Size(100, 20);
            this.txtFahren.TabIndex = 2;
            this.txtFahren.TextChanged += new System.EventHandler(this.txtFahren_TextChanged);
            // 
            // txtCelsius
            // 
            this.txtCelsius.Location = new System.Drawing.Point(185, 86);
            this.txtCelsius.Name = "txtCelsius";
            this.txtCelsius.Size = new System.Drawing.Size(100, 20);
            this.txtCelsius.TabIndex = 3;
            this.txtCelsius.TextChanged += new System.EventHandler(this.txtCelsius_TextChanged);
            // 
            // CfrmMiain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 153);
            this.Controls.Add(this.txtCelsius);
            this.Controls.Add(this.txtFahren);
            this.Controls.Add(this.lblCel);
            this.Controls.Add(this.lblFahren);
            this.Name = "CfrmMiain";
            this.Text = "Temperature_Coverter";
            this.Load += new System.EventHandler(this.CfrmMiain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFahren;
        private System.Windows.Forms.Label lblCel;
        private System.Windows.Forms.TextBox txtFahren;
        private System.Windows.Forms.TextBox txtCelsius;
    }
}

