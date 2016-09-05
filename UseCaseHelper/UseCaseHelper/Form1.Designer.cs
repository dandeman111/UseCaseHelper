namespace UseCaseHelper
{
    partial class Form1
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
            this.gbModes = new System.Windows.Forms.GroupBox();
            this.rbSelect = new System.Windows.Forms.RadioButton();
            this.rbCreate = new System.Windows.Forms.RadioButton();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rbActor = new System.Windows.Forms.RadioButton();
            this.rbUseCase = new System.Windows.Forms.RadioButton();
            this.rbLine = new System.Windows.Forms.RadioButton();
            this.gbElementen = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbElementen.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbModes
            // 
            this.gbModes.Location = new System.Drawing.Point(221, 12);
            this.gbModes.Name = "gbModes";
            this.gbModes.Size = new System.Drawing.Size(171, 134);
            this.gbModes.TabIndex = 1;
            this.gbModes.TabStop = false;
            this.gbModes.Text = "Modes";
            // 
            // rbSelect
            // 
            this.rbSelect.AutoSize = true;
            this.rbSelect.Location = new System.Drawing.Point(6, 134);
            this.rbSelect.Name = "rbSelect";
            this.rbSelect.Size = new System.Drawing.Size(68, 21);
            this.rbSelect.TabIndex = 1;
            this.rbSelect.TabStop = true;
            this.rbSelect.Text = "Select";
            this.rbSelect.UseVisualStyleBackColor = true;
            // 
            // rbCreate
            // 
            this.rbCreate.AutoSize = true;
            this.rbCreate.Location = new System.Drawing.Point(7, 109);
            this.rbCreate.Name = "rbCreate";
            this.rbCreate.Size = new System.Drawing.Size(71, 21);
            this.rbCreate.TabIndex = 0;
            this.rbCreate.TabStop = true;
            this.rbCreate.Text = "Create";
            this.rbCreate.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(475, 29);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(89, 33);
            this.btnClear.TabIndex = 0;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(475, 111);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(89, 35);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(12, 195);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(922, 349);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // rbActor
            // 
            this.rbActor.AutoSize = true;
            this.rbActor.Location = new System.Drawing.Point(7, 28);
            this.rbActor.Name = "rbActor";
            this.rbActor.Size = new System.Drawing.Size(62, 21);
            this.rbActor.TabIndex = 0;
            this.rbActor.TabStop = true;
            this.rbActor.Text = "Actor";
            this.rbActor.UseVisualStyleBackColor = true;
            // 
            // rbUseCase
            // 
            this.rbUseCase.AutoSize = true;
            this.rbUseCase.Location = new System.Drawing.Point(7, 55);
            this.rbUseCase.Name = "rbUseCase";
            this.rbUseCase.Size = new System.Drawing.Size(90, 21);
            this.rbUseCase.TabIndex = 1;
            this.rbUseCase.TabStop = true;
            this.rbUseCase.Text = "Use Case";
            this.rbUseCase.UseVisualStyleBackColor = true;
            // 
            // rbLine
            // 
            this.rbLine.AutoSize = true;
            this.rbLine.Location = new System.Drawing.Point(6, 82);
            this.rbLine.Name = "rbLine";
            this.rbLine.Size = new System.Drawing.Size(56, 21);
            this.rbLine.TabIndex = 2;
            this.rbLine.TabStop = true;
            this.rbLine.Text = "Line";
            this.rbLine.UseVisualStyleBackColor = true;
            // 
            // gbElementen
            // 
            this.gbElementen.Controls.Add(this.rbSelect);
            this.gbElementen.Controls.Add(this.rbLine);
            this.gbElementen.Controls.Add(this.rbCreate);
            this.gbElementen.Controls.Add(this.rbUseCase);
            this.gbElementen.Controls.Add(this.rbActor);
            this.gbElementen.Location = new System.Drawing.Point(24, 12);
            this.gbElementen.Name = "gbElementen";
            this.gbElementen.Size = new System.Drawing.Size(174, 177);
            this.gbElementen.TabIndex = 0;
            this.gbElementen.TabStop = false;
            this.gbElementen.Text = "Elementen";
            this.gbElementen.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 556);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.gbModes);
            this.Controls.Add(this.gbElementen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbElementen.ResumeLayout(false);
            this.gbElementen.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbModes;
        private System.Windows.Forms.RadioButton rbSelect;
        private System.Windows.Forms.RadioButton rbCreate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton rbActor;
        private System.Windows.Forms.RadioButton rbUseCase;
        private System.Windows.Forms.RadioButton rbLine;
        private System.Windows.Forms.GroupBox gbElementen;
    }
}

