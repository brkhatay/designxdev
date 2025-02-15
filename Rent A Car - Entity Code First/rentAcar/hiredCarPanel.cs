﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rentAcar
{
    class hiredCarPanel : UserControl
    {
        private curvesGpanel curvesGpanel1;
        private Label lblHireEnd;
        private Label lblHireStart;
        private PictureBox pictureBox1;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label13;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label1;
        private Panel panel1;
        private Label label14;

        private void InitializeComponent()
        {
            this.curvesGpanel1 = new rentAcar.curvesGpanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblHireEnd = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblHireStart = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.curvesGpanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // curvesGpanel1
            // 
            this.curvesGpanel1.Angle = 45F;
            this.curvesGpanel1.BackColor = System.Drawing.Color.Transparent;
            this.curvesGpanel1.borderRadius = 20;
            this.curvesGpanel1.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.curvesGpanel1.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.curvesGpanel1.Controls.Add(this.panel1);
            this.curvesGpanel1.Controls.Add(this.label1);
            this.curvesGpanel1.Controls.Add(this.groupBox2);
            this.curvesGpanel1.Controls.Add(this.groupBox1);
            this.curvesGpanel1.Controls.Add(this.label6);
            this.curvesGpanel1.Controls.Add(this.label7);
            this.curvesGpanel1.Controls.Add(this.label8);
            this.curvesGpanel1.Controls.Add(this.label9);
            this.curvesGpanel1.Controls.Add(this.label10);
            this.curvesGpanel1.Controls.Add(this.label5);
            this.curvesGpanel1.Controls.Add(this.label4);
            this.curvesGpanel1.Controls.Add(this.label3);
            this.curvesGpanel1.Controls.Add(this.label13);
            this.curvesGpanel1.Controls.Add(this.label14);
            this.curvesGpanel1.Controls.Add(this.pictureBox1);
            this.curvesGpanel1.Location = new System.Drawing.Point(3, 3);
            this.curvesGpanel1.Name = "curvesGpanel1";
            this.curvesGpanel1.Size = new System.Drawing.Size(609, 307);
            this.curvesGpanel1.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Location = new System.Drawing.Point(21, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(246, 2);
            this.panel1.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 24);
            this.label1.TabIndex = 29;
            this.label1.Text = "Mevcut Kiraladığınız Araç";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblHireEnd);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(321, 248);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(267, 48);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kiralama Bitiş Tarihi";
            // 
            // lblHireEnd
            // 
            this.lblHireEnd.AutoSize = true;
            this.lblHireEnd.BackColor = System.Drawing.Color.Transparent;
            this.lblHireEnd.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHireEnd.ForeColor = System.Drawing.Color.White;
            this.lblHireEnd.Location = new System.Drawing.Point(6, 22);
            this.lblHireEnd.Name = "lblHireEnd";
            this.lblHireEnd.Size = new System.Drawing.Size(43, 23);
            this.lblHireEnd.TabIndex = 15;
            this.lblHireEnd.Text = "000";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblHireStart);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(24, 248);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 48);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kiralama başlangıç tarihi";
            // 
            // lblHireStart
            // 
            this.lblHireStart.AutoSize = true;
            this.lblHireStart.BackColor = System.Drawing.Color.Transparent;
            this.lblHireStart.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHireStart.ForeColor = System.Drawing.Color.White;
            this.lblHireStart.Location = new System.Drawing.Point(6, 20);
            this.lblHireStart.Name = "lblHireStart";
            this.lblHireStart.Size = new System.Drawing.Size(54, 23);
            this.lblHireStart.TabIndex = 14;
            this.lblHireStart.Text = "0000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(23, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 23);
            this.label6.TabIndex = 26;
            this.label6.Text = "Tip:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(23, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 23);
            this.label7.TabIndex = 25;
            this.label7.Text = "Vites";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(23, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 23);
            this.label8.TabIndex = 24;
            this.label8.Text = "Yakıt:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(23, 103);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 23);
            this.label9.TabIndex = 23;
            this.label9.Text = "Model:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(20, 59);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 24);
            this.label10.TabIndex = 22;
            this.label10.Text = "Marka:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(99, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 23);
            this.label5.TabIndex = 21;
            this.label5.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(99, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 23);
            this.label4.TabIndex = 20;
            this.label4.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(99, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 23);
            this.label3.TabIndex = 19;
            this.label3.Text = "label3";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(99, 103);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 23);
            this.label13.TabIndex = 18;
            this.label13.Text = "label13";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(101, 59);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(76, 24);
            this.label14.TabIndex = 17;
            this.label14.Text = "label14";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(350, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(238, 198);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // hiredCarPanel
            // 
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.curvesGpanel1);
            this.Name = "hiredCarPanel";
            this.Size = new System.Drawing.Size(616, 314);
            this.curvesGpanel1.ResumeLayout(false);
            this.curvesGpanel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }


        public hiredCarPanel()
        {
            InitializeComponent();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        string brand;
        string model;
        string carType;
        string gear;
        string fuel;
        string hireStrart;
        string hireEnd;
        Image Image;

        [Category("Cars")]
        public string Brand { get { return brand; } set { brand = value; label14.Text = value; } }

       [Category("Cars")]
        public string Model { get { return model; } set { model = value; label13.Text = value; } }
        [Category("Cars")]

        public string Gear { get { return gear; } set { gear = value; label4.Text = value; } }
        [Category("Cars")]
        public string Fuel { get { return fuel; } set { fuel = value; label3.Text = value; } }
        [Category("Cars")]
        public string Type { get { return carType; } set { carType = value; label5.Text = value; } }

        [Category("Cars")]
        public string HireStart { get { return hireStrart; } set { hireStrart = value; lblHireStart.Text = value; } }
        [Category("Cars")]
        public string HireEnd { get { return hireEnd; } set { hireEnd = value; lblHireEnd.Text = value; } }

        [Category("Cars")]
        public Image image { get { return Image; } set { Image = value; pictureBox1.Image = value; } }

    }
}
