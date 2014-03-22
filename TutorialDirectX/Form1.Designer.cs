namespace TutorialDirectX
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
            this.label1 = new System.Windows.Forms.Label();
            this.hScrollBarXRot = new System.Windows.Forms.HScrollBar();
            this.hScrollBarYRot = new System.Windows.Forms.HScrollBar();
            this.hScrollBarZRot = new System.Windows.Forms.HScrollBar();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.vScrollBar4 = new System.Windows.Forms.VScrollBar();
            this.vScrollBar3 = new System.Windows.Forms.VScrollBar();
            this.vScrollBar2 = new System.Windows.Forms.VScrollBar();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // hScrollBarXRot
            // 
            this.hScrollBarXRot.Location = new System.Drawing.Point(9, 214);
            this.hScrollBarXRot.Name = "hScrollBarXRot";
            this.hScrollBarXRot.Size = new System.Drawing.Size(347, 10);
            this.hScrollBarXRot.TabIndex = 5;
            this.hScrollBarXRot.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBarXRot_Scroll);
            // 
            // hScrollBarYRot
            // 
            this.hScrollBarYRot.Location = new System.Drawing.Point(9, 225);
            this.hScrollBarYRot.Name = "hScrollBarYRot";
            this.hScrollBarYRot.Size = new System.Drawing.Size(347, 10);
            this.hScrollBarYRot.TabIndex = 6;
            this.hScrollBarYRot.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBarYRot_Scroll);
            // 
            // hScrollBarZRot
            // 
            this.hScrollBarZRot.Location = new System.Drawing.Point(9, 235);
            this.hScrollBarZRot.Name = "hScrollBarZRot";
            this.hScrollBarZRot.Size = new System.Drawing.Size(347, 10);
            this.hScrollBarZRot.TabIndex = 7;
            this.hScrollBarZRot.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBarZRot_Scroll);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(31, 74);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 80);
            this.vScrollBar1.TabIndex = 8;
            this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
            // 
            // vScrollBar4
            // 
            this.vScrollBar4.Location = new System.Drawing.Point(83, 74);
            this.vScrollBar4.Name = "vScrollBar4";
            this.vScrollBar4.Size = new System.Drawing.Size(17, 80);
            this.vScrollBar4.TabIndex = 9;
            this.vScrollBar4.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar4_Scroll);
            // 
            // vScrollBar3
            // 
            this.vScrollBar3.Location = new System.Drawing.Point(65, 74);
            this.vScrollBar3.Name = "vScrollBar3";
            this.vScrollBar3.Size = new System.Drawing.Size(17, 80);
            this.vScrollBar3.TabIndex = 10;
            this.vScrollBar3.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar3_Scroll);
            // 
            // vScrollBar2
            // 
            this.vScrollBar2.Location = new System.Drawing.Point(48, 74);
            this.vScrollBar2.Name = "vScrollBar2";
            this.vScrollBar2.Size = new System.Drawing.Size(17, 80);
            this.vScrollBar2.TabIndex = 11;
            this.vScrollBar2.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar2_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 258);
            this.Controls.Add(this.vScrollBar2);
            this.Controls.Add(this.vScrollBar3);
            this.Controls.Add(this.vScrollBar4);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.hScrollBarZRot);
            this.Controls.Add(this.hScrollBarYRot);
            this.Controls.Add(this.hScrollBarXRot);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.HScrollBar hScrollBarXRot;
        private System.Windows.Forms.HScrollBar hScrollBarYRot;
        private System.Windows.Forms.HScrollBar hScrollBarZRot;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.VScrollBar vScrollBar4;
        private System.Windows.Forms.VScrollBar vScrollBar3;
        private System.Windows.Forms.VScrollBar vScrollBar2;
    }
}

