namespace EasyWindowsShutDown
{
    partial class FormMain
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
            this.labelHours = new System.Windows.Forms.Label();
            this.labelMinutes = new System.Windows.Forms.Label();
            this.labelSecounds = new System.Windows.Forms.Label();
            this.textBoxHours = new System.Windows.Forms.TextBox();
            this.textBoxMinutes = new System.Windows.Forms.TextBox();
            this.textBoxSecounds = new System.Windows.Forms.TextBox();
            this.buttonShutDown = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelHours
            // 
            this.labelHours.AutoSize = true;
            this.labelHours.Location = new System.Drawing.Point(23, 27);
            this.labelHours.Name = "labelHours";
            this.labelHours.Size = new System.Drawing.Size(51, 13);
            this.labelHours.TabIndex = 0;
            this.labelHours.Text = "Godziny: ";
            // 
            // labelMinutes
            // 
            this.labelMinutes.AutoSize = true;
            this.labelMinutes.Location = new System.Drawing.Point(23, 56);
            this.labelMinutes.Name = "labelMinutes";
            this.labelMinutes.Size = new System.Drawing.Size(41, 13);
            this.labelMinutes.TabIndex = 1;
            this.labelMinutes.Text = "Minuty:";
            // 
            // labelSecounds
            // 
            this.labelSecounds.AutoSize = true;
            this.labelSecounds.Location = new System.Drawing.Point(23, 82);
            this.labelSecounds.Name = "labelSecounds";
            this.labelSecounds.Size = new System.Drawing.Size(55, 13);
            this.labelSecounds.TabIndex = 2;
            this.labelSecounds.Text = "Sekundy: ";
            // 
            // textBoxHours
            // 
            this.textBoxHours.Location = new System.Drawing.Point(84, 27);
            this.textBoxHours.Name = "textBoxHours";
            this.textBoxHours.Size = new System.Drawing.Size(100, 20);
            this.textBoxHours.TabIndex = 3;
            // 
            // textBoxMinutes
            // 
            this.textBoxMinutes.Location = new System.Drawing.Point(84, 53);
            this.textBoxMinutes.Name = "textBoxMinutes";
            this.textBoxMinutes.Size = new System.Drawing.Size(100, 20);
            this.textBoxMinutes.TabIndex = 4;
            // 
            // textBoxSecounds
            // 
            this.textBoxSecounds.Location = new System.Drawing.Point(84, 79);
            this.textBoxSecounds.Name = "textBoxSecounds";
            this.textBoxSecounds.Size = new System.Drawing.Size(100, 20);
            this.textBoxSecounds.TabIndex = 5;
            // 
            // buttonShutDown
            // 
            this.buttonShutDown.Location = new System.Drawing.Point(84, 115);
            this.buttonShutDown.Name = "buttonShutDown";
            this.buttonShutDown.Size = new System.Drawing.Size(100, 23);
            this.buttonShutDown.TabIndex = 6;
            this.buttonShutDown.Text = "Wyłącz";
            this.buttonShutDown.UseVisualStyleBackColor = true;
            this.buttonShutDown.Click += new System.EventHandler(this.buttonShutDown_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 175);
            this.Controls.Add(this.buttonShutDown);
            this.Controls.Add(this.textBoxSecounds);
            this.Controls.Add(this.textBoxMinutes);
            this.Controls.Add(this.textBoxHours);
            this.Controls.Add(this.labelSecounds);
            this.Controls.Add(this.labelMinutes);
            this.Controls.Add(this.labelHours);
            this.Name = "FormMain";
            this.Text = "EaseWindowsShutDown";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHours;
        private System.Windows.Forms.Label labelMinutes;
        private System.Windows.Forms.Label labelSecounds;
        private System.Windows.Forms.TextBox textBoxHours;
        private System.Windows.Forms.TextBox textBoxMinutes;
        private System.Windows.Forms.TextBox textBoxSecounds;
        private System.Windows.Forms.Button buttonShutDown;
    }
}

