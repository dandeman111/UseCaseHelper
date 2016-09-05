namespace UseCaseHelper
{
    partial class ActorName
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
            this.lblNaam = new System.Windows.Forms.Label();
            this.tbActorName = new System.Windows.Forms.TextBox();
            this.btnKlaar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNaam
            // 
            this.lblNaam.AutoSize = true;
            this.lblNaam.Location = new System.Drawing.Point(49, 48);
            this.lblNaam.Name = "lblNaam";
            this.lblNaam.Size = new System.Drawing.Size(128, 17);
            this.lblNaam.TabIndex = 0;
            this.lblNaam.Text = "Voer een naam in ;";
            // 
            // tbActorName
            // 
            this.tbActorName.Location = new System.Drawing.Point(52, 91);
            this.tbActorName.Name = "tbActorName";
            this.tbActorName.Size = new System.Drawing.Size(333, 22);
            this.tbActorName.TabIndex = 1;
            // 
            // btnKlaar
            // 
            this.btnKlaar.Location = new System.Drawing.Point(298, 131);
            this.btnKlaar.Name = "btnKlaar";
            this.btnKlaar.Size = new System.Drawing.Size(124, 23);
            this.btnKlaar.TabIndex = 2;
            this.btnKlaar.Text = "Klaar";
            this.btnKlaar.UseVisualStyleBackColor = true;
            this.btnKlaar.Click += new System.EventHandler(this.btnKlaar_Click);
            // 
            // ActorName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 166);
            this.Controls.Add(this.btnKlaar);
            this.Controls.Add(this.tbActorName);
            this.Controls.Add(this.lblNaam);
            this.Name = "ActorName";
            this.Text = "ActorName";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNaam;
        private System.Windows.Forms.TextBox tbActorName;
        private System.Windows.Forms.Button btnKlaar;
    }
}