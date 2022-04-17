namespace tic_tac_toe_game
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.b1 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b5 = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.b6 = new System.Windows.Forms.Button();
            this.b9 = new System.Windows.Forms.Button();
            this.b8 = new System.Windows.Forms.Button();
            this.b7 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.player1 = new System.Windows.Forms.Label();
            this.player2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // b1
            // 
            this.b1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.b1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b1.Font = new System.Drawing.Font("Book Antiqua", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.b1.Location = new System.Drawing.Point(25, 25);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(120, 120);
            this.b1.TabIndex = 0;
            this.b1.UseVisualStyleBackColor = false;
            this.b1.Click += new System.EventHandler(this.button1_Click);
            // 
            // b2
            // 
            this.b2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.b2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b2.Font = new System.Drawing.Font("Book Antiqua", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.b2.Location = new System.Drawing.Point(151, 26);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(120, 120);
            this.b2.TabIndex = 1;
            this.b2.UseVisualStyleBackColor = false;
            this.b2.Click += new System.EventHandler(this.button2_Click);
            // 
            // b5
            // 
            this.b5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.b5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b5.Font = new System.Drawing.Font("Book Antiqua", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.b5.Location = new System.Drawing.Point(151, 152);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(120, 120);
            this.b5.TabIndex = 2;
            this.b5.UseVisualStyleBackColor = false;
            this.b5.Click += new System.EventHandler(this.button3_Click);
            // 
            // b4
            // 
            this.b4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.b4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b4.Font = new System.Drawing.Font("Book Antiqua", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.b4.Location = new System.Drawing.Point(25, 151);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(120, 120);
            this.b4.TabIndex = 3;
            this.b4.UseVisualStyleBackColor = false;
            this.b4.Click += new System.EventHandler(this.button4_Click);
            // 
            // b3
            // 
            this.b3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.b3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b3.Font = new System.Drawing.Font("Book Antiqua", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.b3.Location = new System.Drawing.Point(277, 26);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(120, 120);
            this.b3.TabIndex = 4;
            this.b3.UseVisualStyleBackColor = false;
            this.b3.Click += new System.EventHandler(this.button5_Click);
            // 
            // b6
            // 
            this.b6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.b6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b6.Font = new System.Drawing.Font("Book Antiqua", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.b6.Location = new System.Drawing.Point(277, 151);
            this.b6.Name = "b6";
            this.b6.Size = new System.Drawing.Size(120, 120);
            this.b6.TabIndex = 5;
            this.b6.UseVisualStyleBackColor = false;
            this.b6.Click += new System.EventHandler(this.button6_Click);
            // 
            // b9
            // 
            this.b9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.b9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b9.Font = new System.Drawing.Font("Book Antiqua", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.b9.Location = new System.Drawing.Point(277, 277);
            this.b9.Name = "b9";
            this.b9.Size = new System.Drawing.Size(120, 120);
            this.b9.TabIndex = 6;
            this.b9.UseVisualStyleBackColor = false;
            this.b9.Click += new System.EventHandler(this.button7_Click);
            // 
            // b8
            // 
            this.b8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.b8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b8.Font = new System.Drawing.Font("Book Antiqua", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.b8.Location = new System.Drawing.Point(151, 277);
            this.b8.Name = "b8";
            this.b8.Size = new System.Drawing.Size(120, 120);
            this.b8.TabIndex = 7;
            this.b8.UseVisualStyleBackColor = false;
            this.b8.Click += new System.EventHandler(this.button8_Click);
            // 
            // b7
            // 
            this.b7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.b7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b7.Font = new System.Drawing.Font("Book Antiqua", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.b7.Location = new System.Drawing.Point(25, 277);
            this.b7.Name = "b7";
            this.b7.Size = new System.Drawing.Size(120, 120);
            this.b7.TabIndex = 8;
            this.b7.UseVisualStyleBackColor = false;
            this.b7.Click += new System.EventHandler(this.button9_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.Plum;
            this.panel1.Controls.Add(this.b1);
            this.panel1.Controls.Add(this.b7);
            this.panel1.Controls.Add(this.b2);
            this.panel1.Controls.Add(this.b8);
            this.panel1.Controls.Add(this.b5);
            this.panel1.Controls.Add(this.b9);
            this.panel1.Controls.Add(this.b4);
            this.panel1.Controls.Add(this.b6);
            this.panel1.Controls.Add(this.b3);
            this.panel1.Location = new System.Drawing.Point(76, 155);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 422);
            this.panel1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(351, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 32);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tic Tac Toe Game";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(6, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 32);
            this.label2.TabIndex = 11;
            this.label2.Text = "Player 2 - O";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(6, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 32);
            this.label3.TabIndex = 12;
            this.label3.Text = "Player 1 - X ";
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.DarkGray;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(645, 319);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(222, 87);
            this.button1.TabIndex = 9;
            this.button1.Text = "Başla";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(245, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(476, 38);
            this.label4.TabIndex = 13;
            this.label4.Text = "            GAME OVER             ";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(370, 597);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 38);
            this.label5.TabIndex = 14;
            // 
            // player1
            // 
            this.player1.AutoSize = true;
            this.player1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.player1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.player1.Location = new System.Drawing.Point(19, 14);
            this.player1.Name = "player1";
            this.player1.Size = new System.Drawing.Size(33, 36);
            this.player1.TabIndex = 16;
            this.player1.Text = "0";
            // 
            // player2
            // 
            this.player2.AutoSize = true;
            this.player2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.player2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.player2.Location = new System.Drawing.Point(19, 69);
            this.player2.Name = "player2";
            this.player2.Size = new System.Drawing.Size(33, 36);
            this.player2.TabIndex = 17;
            this.player2.Text = "0";
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Cursor = System.Windows.Forms.Cursors.No;
            this.panel2.Location = new System.Drawing.Point(618, 180);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(194, 123);
            this.panel2.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel3.Controls.Add(this.player2);
            this.panel3.Controls.Add(this.player1);
            this.panel3.Cursor = System.Windows.Forms.Cursors.No;
            this.panel3.Location = new System.Drawing.Point(825, 180);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(68, 123);
            this.panel3.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Cursor = System.Windows.Forms.Cursors.No;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(828, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 22);
            this.label8.TabIndex = 13;
            this.label8.Text = "SKOR";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(312, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(348, 38);
            this.label6.TabIndex = 15;
            this.label6.Text = "             Draw            ";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(125, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 32);
            this.label9.TabIndex = 21;
            this.label9.Text = ":";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(62, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 32);
            this.label10.TabIndex = 20;
            this.label10.Text = ":";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(144, 34);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 32);
            this.label11.TabIndex = 19;
            this.label11.Text = "00";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(76, 34);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 32);
            this.label12.TabIndex = 18;
            this.label12.Text = "00";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(18, 34);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 32);
            this.label13.TabIndex = 17;
            this.label13.Text = "00";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Red;
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Location = new System.Drawing.Point(-6, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(227, 100);
            this.panel4.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(941, 690);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XOX GAME";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b5;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button b6;
        private System.Windows.Forms.Button b9;
        private System.Windows.Forms.Button b8;
        private System.Windows.Forms.Button b7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label player1;
        private System.Windows.Forms.Label player2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel4;
    }
}

