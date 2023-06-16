using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace PA4Draft
{
    partial class PickHatchBrush
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ok = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.opacity1 = new System.Windows.Forms.TrackBar();
            this.opacity2 = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.opacity1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.opacity2)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 44);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(205, 164);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hatchstyle";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(284, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "Pick Foreground Color";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(284, 157);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(163, 28);
            this.button2.TabIndex = 3;
            this.button2.Text = "Pick Background Color";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ok
            // 
            this.ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ok.Location = new System.Drawing.Point(75, 275);
            this.ok.Margin = new System.Windows.Forms.Padding(4);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(100, 28);
            this.ok.TabIndex = 4;
            this.ok.Text = "OK";
            this.ok.UseVisualStyleBackColor = true;
            // 
            // cancel
            // 
            this.cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel.Location = new System.Drawing.Point(284, 275);
            this.cancel.Margin = new System.Windows.Forms.Padding(4);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(100, 28);
            this.cancel.TabIndex = 5;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            // 
            // opacity1
            // 
            this.opacity1.Location = new System.Drawing.Point(223, 95);
            this.opacity1.Margin = new System.Windows.Forms.Padding(4);
            this.opacity1.Maximum = 255;
            this.opacity1.Name = "opacity1";
            this.opacity1.Size = new System.Drawing.Size(284, 56);
            this.opacity1.SmallChange = 5;
            this.opacity1.TabIndex = 4;
            this.opacity1.Value = 255;
            this.opacity1.Scroll += new System.EventHandler(this.opacity1_Scroll);
            this.opacity1.ValueChanged += new System.EventHandler(this.Opacity_ValueChanged);
            // 
            // opacity2
            // 
            this.opacity2.Location = new System.Drawing.Point(226, 212);
            this.opacity2.Margin = new System.Windows.Forms.Padding(4);
            this.opacity2.Maximum = 255;
            this.opacity2.Name = "opacity2";
            this.opacity2.Size = new System.Drawing.Size(284, 56);
            this.opacity2.SmallChange = 5;
            this.opacity2.TabIndex = 4;
            this.opacity2.Value = 255;
            this.opacity2.Scroll += new System.EventHandler(this.opacity2_Scroll);
            this.opacity2.ValueChanged += new System.EventHandler(this.Opacity2_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(223, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Opacity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(223, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Opacity";
            // 
            // PickHatchBrush
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 343);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.opacity2);
            this.Controls.Add(this.opacity1);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Name = "PickHatchBrush";
            this.Text = "PickHatchBrush";
            ((System.ComponentModel.ISupportInitialize)(this.opacity1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.opacity2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.Button cancel;
        internal Color pickedColor;
        internal Color pickedColor1;
        internal HatchStyle hStyle;
        private System.Windows.Forms.TrackBar opacity1;
        private System.Windows.Forms.TrackBar opacity2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColorDialog colorDialog2;
    }
}