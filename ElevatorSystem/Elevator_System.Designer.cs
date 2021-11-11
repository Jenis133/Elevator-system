namespace ElevatorSystem
{
    partial class Elevator_System
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Elevator_System));
            this.panel1 = new System.Windows.Forms.Panel();
            this.door00 = new System.Windows.Forms.PictureBox();
            this.door0 = new System.Windows.Forms.PictureBox();
            this.door11 = new System.Windows.Forms.PictureBox();
            this.door1 = new System.Windows.Forms.PictureBox();
            this.elevator = new System.Windows.Forms.PictureBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.Controlpanel = new System.Windows.Forms.Label();
            this.up = new System.Windows.Forms.Button();
            this.down = new System.Windows.Forms.Button();
            this.btnopen = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.timer5 = new System.Windows.Forms.Timer(this.components);
            this.timer6 = new System.Windows.Forms.Timer(this.components);
            this.timer7 = new System.Windows.Forms.Timer(this.components);
            this.timer8 = new System.Windows.Forms.Timer(this.components);
            this.lblfloor = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.door00)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.door0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.door11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.door1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elevator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.door00);
            this.panel1.Controls.Add(this.door0);
            this.panel1.Controls.Add(this.door11);
            this.panel1.Controls.Add(this.door1);
            this.panel1.Controls.Add(this.elevator);
            this.panel1.Location = new System.Drawing.Point(283, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(187, 797);
            this.panel1.TabIndex = 0;
            // 
            // door00
            // 
            this.door00.Image = ((System.Drawing.Image)(resources.GetObject("door00.Image")));
            this.door00.Location = new System.Drawing.Point(91, 525);
            this.door00.Name = "door00";
            this.door00.Size = new System.Drawing.Size(96, 273);
            this.door00.TabIndex = 4;
            this.door00.TabStop = false;
            this.door00.Click += new System.EventHandler(this.door00_Click);
            // 
            // door0
            // 
            this.door0.Image = ((System.Drawing.Image)(resources.GetObject("door0.Image")));
            this.door0.Location = new System.Drawing.Point(0, 525);
            this.door0.Name = "door0";
            this.door0.Size = new System.Drawing.Size(97, 272);
            this.door0.TabIndex = 3;
            this.door0.TabStop = false;
            // 
            // door11
            // 
            this.door11.Image = ((System.Drawing.Image)(resources.GetObject("door11.Image")));
            this.door11.Location = new System.Drawing.Point(90, 0);
            this.door11.Name = "door11";
            this.door11.Size = new System.Drawing.Size(97, 273);
            this.door11.TabIndex = 2;
            this.door11.TabStop = false;
            // 
            // door1
            // 
            this.door1.Image = ((System.Drawing.Image)(resources.GetObject("door1.Image")));
            this.door1.Location = new System.Drawing.Point(0, 0);
            this.door1.Name = "door1";
            this.door1.Size = new System.Drawing.Size(96, 273);
            this.door1.TabIndex = 1;
            this.door1.TabStop = false;
            // 
            // elevator
            // 
            this.elevator.Image = ((System.Drawing.Image)(resources.GetObject("elevator.Image")));
            this.elevator.Location = new System.Drawing.Point(3, 3);
            this.elevator.Name = "elevator";
            this.elevator.Size = new System.Drawing.Size(184, 266);
            this.elevator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.elevator.TabIndex = 0;
            this.elevator.TabStop = false;
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.Silver;
            this.btn1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn1.BackgroundImage")));
            this.btn1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn1.Location = new System.Drawing.Point(504, 118);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(36, 35);
            this.btn1.TabIndex = 1;
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.Silver;
            this.btn0.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn0.BackgroundImage")));
            this.btn0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn0.Location = new System.Drawing.Point(515, 668);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(36, 35);
            this.btn0.TabIndex = 2;
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // Controlpanel
            // 
            this.Controlpanel.AutoSize = true;
            this.Controlpanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Controlpanel.Location = new System.Drawing.Point(719, 154);
            this.Controlpanel.Name = "Controlpanel";
            this.Controlpanel.Size = new System.Drawing.Size(201, 32);
            this.Controlpanel.TabIndex = 3;
            this.Controlpanel.Text = "Control Panel";
            // 
            // up
            // 
            this.up.BackColor = System.Drawing.Color.Silver;
            this.up.Location = new System.Drawing.Point(736, 257);
            this.up.Name = "up";
            this.up.Size = new System.Drawing.Size(75, 23);
            this.up.TabIndex = 4;
            this.up.Text = "UP";
            this.up.UseVisualStyleBackColor = false;
            this.up.Click += new System.EventHandler(this.up_Click);
            // 
            // down
            // 
            this.down.BackColor = System.Drawing.Color.Silver;
            this.down.Location = new System.Drawing.Point(736, 302);
            this.down.Name = "down";
            this.down.Size = new System.Drawing.Size(75, 23);
            this.down.TabIndex = 5;
            this.down.Text = "DOWN";
            this.down.UseVisualStyleBackColor = false;
            this.down.Click += new System.EventHandler(this.down_Click);
            // 
            // btnopen
            // 
            this.btnopen.BackColor = System.Drawing.Color.Silver;
            this.btnopen.Location = new System.Drawing.Point(845, 258);
            this.btnopen.Name = "btnopen";
            this.btnopen.Size = new System.Drawing.Size(75, 23);
            this.btnopen.TabIndex = 6;
            this.btnopen.Text = "OPEN";
            this.btnopen.UseVisualStyleBackColor = false;
            this.btnopen.Click += new System.EventHandler(this.btnopen_Click);
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.Silver;
            this.btnclose.Location = new System.Drawing.Point(845, 302);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(75, 23);
            this.btnclose.TabIndex = 7;
            this.btnclose.Text = "CLOSE";
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 40;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 20;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 500;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timer4
            // 
            this.timer4.Interval = 20;
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // timer5
            // 
            this.timer5.Interval = 40;
            this.timer5.Tick += new System.EventHandler(this.timer5_Tick);
            // 
            // timer6
            // 
            this.timer6.Interval = 20;
            this.timer6.Tick += new System.EventHandler(this.timer6_Tick);
            // 
            // timer7
            // 
            this.timer7.Interval = 500;
            this.timer7.Tick += new System.EventHandler(this.timer7_Tick);
            // 
            // timer8
            // 
            this.timer8.Interval = 20;
            this.timer8.Tick += new System.EventHandler(this.timer8_Tick);
            // 
            // lblfloor
            // 
            this.lblfloor.AutoSize = true;
            this.lblfloor.BackColor = System.Drawing.Color.Black;
            this.lblfloor.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfloor.ForeColor = System.Drawing.Color.Red;
            this.lblfloor.Location = new System.Drawing.Point(810, 198);
            this.lblfloor.Name = "lblfloor";
            this.lblfloor.Size = new System.Drawing.Size(33, 36);
            this.lblfloor.TabIndex = 8;
            this.lblfloor.Text = "1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(633, 380);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(413, 395);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Elevator_System
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 1055);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblfloor);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnopen);
            this.Controls.Add(this.down);
            this.Controls.Add(this.up);
            this.Controls.Add(this.Controlpanel);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.panel1);
            this.Name = "Elevator_System";
            this.Text = "Elevator System";
            this.Load += new System.EventHandler(this.Elevator_System_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.door00)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.door0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.door11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.door1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elevator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox elevator;
        private System.Windows.Forms.PictureBox door11;
        private System.Windows.Forms.PictureBox door1;
        private System.Windows.Forms.PictureBox door00;
        private System.Windows.Forms.PictureBox door0;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Label Controlpanel;
        private System.Windows.Forms.Button up;
        private System.Windows.Forms.Button down;
        private System.Windows.Forms.Button btnopen;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Timer timer5;
        private System.Windows.Forms.Timer timer6;
        private System.Windows.Forms.Timer timer7;
        private System.Windows.Forms.Timer timer8;
        private System.Windows.Forms.Label lblfloor;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

