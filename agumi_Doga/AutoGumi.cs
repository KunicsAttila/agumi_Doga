using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace agumi_Doga
{
    class AutoGumi : UserControl, Ialkatresz
    {
        public GroupBox groupBox1;
        public Label gumiNev;
        public TextBox tb_ar;
        public TextBox tb_anyag;
        public TextBox tb_nev;
        public Label gumiAr;
        public Label gumiAnyag;
        public ContextMenuStrip contextMenuStrip1;
        private System.ComponentModel.IContainer components;
        private Button button_Add;
        public GroupBox groupBox2;

        public AutoGumi(string nev, string anyag, int ar)
        {
            gumiNev = nev;
            gumiAnyag = anyag;
            gumiAr = ar;
        }
        string nev { get; set; }
        string anyag { get; set; }
        int ar { get; set; }
        /*public GroupBox groupBox1 { get; set; }
        public Label gumiNev { get; set; }
        public TextBox tb_ar { get; set; }
        public TextBox tb_anyag { get; set; }
        public TextBox tb_nev { get; set; }
        public Label gumiAr { get; set; }
        public Label gumiAnyag { get; set; }
        public ContextMenuStrip contextMenuStrip1 { get; set; }
        public System.ComponentModel.IContainer components { get; set; }
        public GroupBox groupBox2 { get; set; }*/

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_ar = new System.Windows.Forms.TextBox();
            this.tb_anyag = new System.Windows.Forms.TextBox();
            this.tb_nev = new System.Windows.Forms.TextBox();
            this.gumiAr = new System.Windows.Forms.Label();
            this.gumiAnyag = new System.Windows.Forms.Label();
            this.gumiNev = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.button_Add = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Lime;
            this.groupBox1.Controls.Add(this.button_Add);
            this.groupBox1.Controls.Add(this.tb_ar);
            this.groupBox1.Controls.Add(this.tb_anyag);
            this.groupBox1.Controls.Add(this.tb_nev);
            this.groupBox1.Controls.Add(this.gumiAr);
            this.groupBox1.Controls.Add(this.gumiAnyag);
            this.groupBox1.Controls.Add(this.gumiNev);
            this.groupBox1.Location = new System.Drawing.Point(15, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(229, 173);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gumi";
            // 
            // tb_ar
            // 
            this.tb_ar.Location = new System.Drawing.Point(98, 85);
            this.tb_ar.Name = "tb_ar";
            this.tb_ar.Size = new System.Drawing.Size(100, 20);
            this.tb_ar.TabIndex = 6;
            // 
            // tb_anyag
            // 
            this.tb_anyag.Location = new System.Drawing.Point(98, 51);
            this.tb_anyag.Name = "tb_anyag";
            this.tb_anyag.Size = new System.Drawing.Size(100, 20);
            this.tb_anyag.TabIndex = 5;
            // 
            // tb_nev
            // 
            this.tb_nev.Location = new System.Drawing.Point(98, 20);
            this.tb_nev.Name = "tb_nev";
            this.tb_nev.Size = new System.Drawing.Size(100, 20);
            this.tb_nev.TabIndex = 4;
            // 
            // gumiAr
            // 
            this.gumiAr.AutoSize = true;
            this.gumiAr.Location = new System.Drawing.Point(28, 85);
            this.gumiAr.Name = "gumiAr";
            this.gumiAr.Size = new System.Drawing.Size(17, 13);
            this.gumiAr.TabIndex = 3;
            this.gumiAr.Text = "Ár";
            // 
            // gumiAnyag
            // 
            this.gumiAnyag.AutoSize = true;
            this.gumiAnyag.Location = new System.Drawing.Point(18, 54);
            this.gumiAnyag.Name = "gumiAnyag";
            this.gumiAnyag.Size = new System.Drawing.Size(37, 13);
            this.gumiAnyag.TabIndex = 1;
            this.gumiAnyag.Text = "Anyag";
            // 
            // gumiNev
            // 
            this.gumiNev.AutoSize = true;
            this.gumiNev.Location = new System.Drawing.Point(18, 23);
            this.gumiNev.Name = "gumiNev";
            this.gumiNev.Size = new System.Drawing.Size(27, 13);
            this.gumiNev.TabIndex = 0;
            this.gumiNev.Text = "Név";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(367, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(229, 173);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "TeliGumi";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(68, 124);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(75, 23);
            this.button_Add.TabIndex = 7;
            this.button_Add.Text = "Hozzáadás";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // AutoGumi
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AutoGumi";
            this.Size = new System.Drawing.Size(726, 196);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"A gumi anyaga: { anyag }", "ára: { ar}");
        }
    }
}
