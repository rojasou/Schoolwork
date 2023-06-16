using System.Drawing;

namespace PA4Draft
{
    partial class PickSolidBrush
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
            this.color = new System.Windows.Forms.Button();
            this.ok = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.opacity = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.opacity)).BeginInit();
            this.SuspendLayout();
            // 
            // color
            // 
            this.color.Location = new System.Drawing.Point(203, 178);
            this.color.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.color.Name = "color";
            this.color.Size = new System.Drawing.Size(100, 28);
            this.color.TabIndex = 1;
            this.color.Text = "Pick a Color";
            this.color.UseVisualStyleBackColor = true;
            this.color.Click += new System.EventHandler(this.Color_Click);
            // 
            // ok
            // 
            this.ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ok.Location = new System.Drawing.Point(93, 300);
            this.ok.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(100, 28);
            this.ok.TabIndex = 2;
            this.ok.Text = "OK";
            this.ok.UseVisualStyleBackColor = true;
            // 
            // cancel
            // 
            this.cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel.Location = new System.Drawing.Point(296, 300);
            this.cancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(100, 28);
            this.cancel.TabIndex = 3;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            // 
            // opacity
            // 
            this.opacity.Location = new System.Drawing.Point(16, 214);
            this.opacity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.opacity.Maximum = 255;
            this.opacity.Name = "opacity";
            this.opacity.Size = new System.Drawing.Size(479, 56);
            this.opacity.SmallChange = 5;
            this.opacity.TabIndex = 4;
            this.opacity.Value = 255;
            this.opacity.Scroll += new System.EventHandler(this.opacity_Scroll);
            this.opacity.ValueChanged += new System.EventHandler(this.Opacity_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 191);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Opacity";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // PickSolidBrush
            // 
            this.AcceptButton = this.ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancel;
            this.ClientSize = new System.Drawing.Size(511, 343);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.opacity);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.color);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PickSolidBrush";
            this.Text = "Pick Solid Brush";
            ((System.ComponentModel.ISupportInitialize)(this.opacity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button color;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.ColorDialog colorDialog1;
        internal Color pickedColor;
        private System.Windows.Forms.TrackBar opacity;
        private System.Windows.Forms.Label label1;
    }
}