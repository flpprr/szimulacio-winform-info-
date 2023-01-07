namespace projektt
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.circbutton1 = new projektt.Circbutton();
            this.circbutton2 = new projektt.Circbutton();
            this.circbutton3 = new projektt.Circbutton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(61, 116);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(982, 570);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.DarkSalmon;
            this.label1.Location = new System.Drawing.Point(483, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 40);
            this.label1.TabIndex = 4;
            this.label1.Text = "0";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // circbutton1
            // 
            this.circbutton1.BackColor = System.Drawing.Color.Transparent;
            this.circbutton1.BackgroundImage = global::projektt.Properties.Resources.on;
            this.circbutton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.circbutton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.circbutton1.Location = new System.Drawing.Point(402, 55);
            this.circbutton1.Name = "circbutton1";
            this.circbutton1.Size = new System.Drawing.Size(40, 40);
            this.circbutton1.TabIndex = 5;
            this.circbutton1.UseVisualStyleBackColor = false;
            this.circbutton1.Click += new System.EventHandler(this.circbutton1_Click);
            // 
            // circbutton2
            // 
            this.circbutton2.BackColor = System.Drawing.Color.Transparent;
            this.circbutton2.BackgroundImage = global::projektt.Properties.Resources.off;
            this.circbutton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.circbutton2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.circbutton2.ForeColor = System.Drawing.Color.Transparent;
            this.circbutton2.Location = new System.Drawing.Point(680, 55);
            this.circbutton2.Name = "circbutton2";
            this.circbutton2.Size = new System.Drawing.Size(40, 40);
            this.circbutton2.TabIndex = 6;
            this.circbutton2.UseVisualStyleBackColor = false;
            this.circbutton2.Click += new System.EventHandler(this.circbutton2_Click);
            // 
            // circbutton3
            // 
            this.circbutton3.BackColor = System.Drawing.Color.Transparent;
            this.circbutton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.circbutton3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.circbutton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.circbutton3.Location = new System.Drawing.Point(1056, 3);
            this.circbutton3.Name = "circbutton3";
            this.circbutton3.Size = new System.Drawing.Size(62, 64);
            this.circbutton3.TabIndex = 7;
            this.circbutton3.Text = "X";
            this.circbutton3.UseVisualStyleBackColor = false;
            this.circbutton3.Click += new System.EventHandler(this.circbutton3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::projektt.Properties.Resources.arena2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1120, 735);
            this.Controls.Add(this.circbutton3);
            this.Controls.Add(this.circbutton2);
            this.Controls.Add(this.circbutton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Floating rock paper scissors";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Timer timer1;
        private Circbutton circbutton1;
        private Circbutton circbutton2;
        private Circbutton circbutton3;
    }
}

