namespace Test_H5_Klasse_Pokemon_LEEG
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
            this.labelSpeler1 = new System.Windows.Forms.Label();
            this.labelSpeler2 = new System.Windows.Forms.Label();
            this.buttonValAan1 = new System.Windows.Forms.Button();
            this.buttonValAan2 = new System.Windows.Forms.Button();
            this.labelGezondheid1 = new System.Windows.Forms.Label();
            this.labelGezondheid2 = new System.Windows.Forms.Label();
            this.buttonGenees1 = new System.Windows.Forms.Button();
            this.buttonGenees2 = new System.Windows.Forms.Button();
            this.buttonToonPos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelSpeler1
            // 
            this.labelSpeler1.AutoSize = true;
            this.labelSpeler1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSpeler1.Location = new System.Drawing.Point(66, 32);
            this.labelSpeler1.Name = "labelSpeler1";
            this.labelSpeler1.Size = new System.Drawing.Size(146, 38);
            this.labelSpeler1.TabIndex = 0;
            this.labelSpeler1.Text = "Speler 1";
            // 
            // labelSpeler2
            // 
            this.labelSpeler2.AutoSize = true;
            this.labelSpeler2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSpeler2.Location = new System.Drawing.Point(393, 32);
            this.labelSpeler2.Name = "labelSpeler2";
            this.labelSpeler2.Size = new System.Drawing.Size(146, 38);
            this.labelSpeler2.TabIndex = 2;
            this.labelSpeler2.Text = "Speler 2";
            // 
            // buttonValAan1
            // 
            this.buttonValAan1.Location = new System.Drawing.Point(74, 135);
            this.buttonValAan1.Name = "buttonValAan1";
            this.buttonValAan1.Size = new System.Drawing.Size(174, 29);
            this.buttonValAan1.TabIndex = 3;
            this.buttonValAan1.Text = "Val speler 2 aan...";
            this.buttonValAan1.UseVisualStyleBackColor = true;
            this.buttonValAan1.Click += new System.EventHandler(this.buttonValAan1_Click);
            // 
            // buttonValAan2
            // 
            this.buttonValAan2.Location = new System.Drawing.Point(384, 135);
            this.buttonValAan2.Name = "buttonValAan2";
            this.buttonValAan2.Size = new System.Drawing.Size(174, 29);
            this.buttonValAan2.TabIndex = 4;
            this.buttonValAan2.Text = "Val speler 1 aan...";
            this.buttonValAan2.UseVisualStyleBackColor = true;
            this.buttonValAan2.Click += new System.EventHandler(this.buttonValAan2_Click);
            // 
            // labelGezondheid1
            // 
            this.labelGezondheid1.AutoSize = true;
            this.labelGezondheid1.Location = new System.Drawing.Point(69, 94);
            this.labelGezondheid1.Name = "labelGezondheid1";
            this.labelGezondheid1.Size = new System.Drawing.Size(104, 20);
            this.labelGezondheid1.TabIndex = 5;
            this.labelGezondheid1.Text = "Gezondheid: ";
            // 
            // labelGezondheid2
            // 
            this.labelGezondheid2.AutoSize = true;
            this.labelGezondheid2.Location = new System.Drawing.Point(396, 94);
            this.labelGezondheid2.Name = "labelGezondheid2";
            this.labelGezondheid2.Size = new System.Drawing.Size(104, 20);
            this.labelGezondheid2.TabIndex = 6;
            this.labelGezondheid2.Text = "Gezondheid: ";
            // 
            // buttonGenees1
            // 
            this.buttonGenees1.Location = new System.Drawing.Point(74, 185);
            this.buttonGenees1.Name = "buttonGenees1";
            this.buttonGenees1.Size = new System.Drawing.Size(174, 29);
            this.buttonGenees1.TabIndex = 7;
            this.buttonGenees1.Text = "Genees";
            this.buttonGenees1.UseVisualStyleBackColor = true;
            this.buttonGenees1.Click += new System.EventHandler(this.buttonGenees1_Click);
            // 
            // buttonGenees2
            // 
            this.buttonGenees2.Location = new System.Drawing.Point(384, 185);
            this.buttonGenees2.Name = "buttonGenees2";
            this.buttonGenees2.Size = new System.Drawing.Size(174, 29);
            this.buttonGenees2.TabIndex = 8;
            this.buttonGenees2.Text = "Genees";
            this.buttonGenees2.UseVisualStyleBackColor = true;
            this.buttonGenees2.Click += new System.EventHandler(this.buttonGenees2_Click);
            // 
            // buttonToonPos
            // 
            this.buttonToonPos.Location = new System.Drawing.Point(228, 248);
            this.buttonToonPos.Name = "buttonToonPos";
            this.buttonToonPos.Size = new System.Drawing.Size(196, 29);
            this.buttonToonPos.TabIndex = 9;
            this.buttonToonPos.Text = "Toon posities";
            this.buttonToonPos.UseVisualStyleBackColor = true;
            this.buttonToonPos.Click += new System.EventHandler(this.buttonToonPos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 303);
            this.Controls.Add(this.buttonToonPos);
            this.Controls.Add(this.buttonGenees2);
            this.Controls.Add(this.buttonGenees1);
            this.Controls.Add(this.labelGezondheid2);
            this.Controls.Add(this.labelGezondheid1);
            this.Controls.Add(this.buttonValAan2);
            this.Controls.Add(this.buttonValAan1);
            this.Controls.Add(this.labelSpeler2);
            this.Controls.Add(this.labelSpeler1);
            this.Name = "Form1";
            this.Text = "Pokemon game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSpeler1;
        private System.Windows.Forms.Label labelSpeler2;
        private System.Windows.Forms.Button buttonValAan1;
        private System.Windows.Forms.Button buttonValAan2;
        private System.Windows.Forms.Label labelGezondheid1;
        private System.Windows.Forms.Label labelGezondheid2;
        private System.Windows.Forms.Button buttonGenees1;
        private System.Windows.Forms.Button buttonGenees2;
        private System.Windows.Forms.Button buttonToonPos;
    }
}

