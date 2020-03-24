namespace Russian_Roullete
{
    partial class Game
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
            this.label1 = new System.Windows.Forms.Label();
            this.Load_btn = new System.Windows.Forms.Button();
            this.Spin_btn = new System.Windows.Forms.Button();
            this.Shoot_btn = new System.Windows.Forms.Button();
            this.ShootAway_btn = new System.Windows.Forms.Button();
            this.PlayAgain_btn = new System.Windows.Forms.Button();
            this.gifplay = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gifplay)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(286, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Russian Roullete";
            // 
            // Load_btn
            // 
            this.Load_btn.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Load_btn.ForeColor = System.Drawing.Color.Red;
            this.Load_btn.Location = new System.Drawing.Point(33, 69);
            this.Load_btn.Name = "Load_btn";
            this.Load_btn.Size = new System.Drawing.Size(140, 66);
            this.Load_btn.TabIndex = 1;
            this.Load_btn.Text = "Load";
            this.Load_btn.UseVisualStyleBackColor = true;
            this.Load_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Spin_btn
            // 
            this.Spin_btn.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Spin_btn.ForeColor = System.Drawing.Color.Red;
            this.Spin_btn.Location = new System.Drawing.Point(33, 198);
            this.Spin_btn.Name = "Spin_btn";
            this.Spin_btn.Size = new System.Drawing.Size(140, 66);
            this.Spin_btn.TabIndex = 2;
            this.Spin_btn.Text = "Spin";
            this.Spin_btn.UseVisualStyleBackColor = true;
            this.Spin_btn.Click += new System.EventHandler(this.Spin_btn_Click);
            // 
            // Shoot_btn
            // 
            this.Shoot_btn.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Shoot_btn.ForeColor = System.Drawing.Color.Red;
            this.Shoot_btn.Location = new System.Drawing.Point(33, 338);
            this.Shoot_btn.Name = "Shoot_btn";
            this.Shoot_btn.Size = new System.Drawing.Size(140, 66);
            this.Shoot_btn.TabIndex = 3;
            this.Shoot_btn.Text = "Shoot";
            this.Shoot_btn.UseVisualStyleBackColor = true;
            this.Shoot_btn.Click += new System.EventHandler(this.Shoot_btn_Click);
            // 
            // ShootAway_btn
            // 
            this.ShootAway_btn.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShootAway_btn.ForeColor = System.Drawing.Color.Red;
            this.ShootAway_btn.Location = new System.Drawing.Point(344, 338);
            this.ShootAway_btn.Name = "ShootAway_btn";
            this.ShootAway_btn.Size = new System.Drawing.Size(140, 66);
            this.ShootAway_btn.TabIndex = 4;
            this.ShootAway_btn.Text = "ShootAway";
            this.ShootAway_btn.UseVisualStyleBackColor = true;
            this.ShootAway_btn.Click += new System.EventHandler(this.ShootAway_btn_Click);
            // 
            // PlayAgain_btn
            // 
            this.PlayAgain_btn.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayAgain_btn.ForeColor = System.Drawing.Color.Red;
            this.PlayAgain_btn.Location = new System.Drawing.Point(614, 338);
            this.PlayAgain_btn.Name = "PlayAgain_btn";
            this.PlayAgain_btn.Size = new System.Drawing.Size(140, 66);
            this.PlayAgain_btn.TabIndex = 5;
            this.PlayAgain_btn.Text = "PlayAgain";
            this.PlayAgain_btn.UseVisualStyleBackColor = true;
            this.PlayAgain_btn.Click += new System.EventHandler(this.PlayAgain_btn_Click);
            // 
            // pictureBox1
            // 
            this.gifplay.Location = new System.Drawing.Point(241, 69);
            this.gifplay.Name = "pictureBox1";
            this.gifplay.Size = new System.Drawing.Size(486, 254);
            this.gifplay.TabIndex = 6;
            this.gifplay.TabStop = false;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gifplay);
            this.Controls.Add(this.PlayAgain_btn);
            this.Controls.Add(this.ShootAway_btn);
            this.Controls.Add(this.Shoot_btn);
            this.Controls.Add(this.Spin_btn);
            this.Controls.Add(this.Load_btn);
            this.Controls.Add(this.label1);
            this.Name = "Game";
            this.Text = "Game";
            this.Load += new System.EventHandler(this.Game_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gifplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Load_btn;
        private System.Windows.Forms.Button Spin_btn;
        private System.Windows.Forms.Button Shoot_btn;
        private System.Windows.Forms.Button ShootAway_btn;
        private System.Windows.Forms.Button PlayAgain_btn;
        private System.Windows.Forms.PictureBox gifplay;
    }
}