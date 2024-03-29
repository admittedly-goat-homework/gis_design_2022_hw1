﻿
namespace MyMapObjectsDemo2022
{
    partial class SimpleRendererPoint
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Circle = new System.Windows.Forms.RadioButton();
            this.SolidCircle = new System.Windows.Forms.RadioButton();
            this.Triangle = new System.Windows.Forms.RadioButton();
            this.SolidTriangle = new System.Windows.Forms.RadioButton();
            this.Square = new System.Windows.Forms.RadioButton();
            this.SolidSquare = new System.Windows.Forms.RadioButton();
            this.CircleDot = new System.Windows.Forms.RadioButton();
            this.CircleCircle = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F);
            this.label1.Location = new System.Drawing.Point(150, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "选择点要素的形状：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(219, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 12);
            this.label2.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F);
            this.label3.Location = new System.Drawing.Point(150, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "设置点要素的大小：";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.Location = new System.Drawing.Point(308, 241);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 16;
            // 
            // Circle
            // 
            this.Circle.AutoSize = true;
            this.Circle.Font = new System.Drawing.Font("宋体", 16F);
            this.Circle.Location = new System.Drawing.Point(196, 98);
            this.Circle.Name = "Circle";
            this.Circle.Size = new System.Drawing.Size(50, 26);
            this.Circle.TabIndex = 18;
            this.Circle.Text = "○";
            this.Circle.UseVisualStyleBackColor = true;
            // 
            // SolidCircle
            // 
            this.SolidCircle.AutoSize = true;
            this.SolidCircle.Font = new System.Drawing.Font("宋体", 16F);
            this.SolidCircle.Location = new System.Drawing.Point(196, 161);
            this.SolidCircle.Name = "SolidCircle";
            this.SolidCircle.Size = new System.Drawing.Size(50, 26);
            this.SolidCircle.TabIndex = 19;
            this.SolidCircle.Text = "●";
            this.SolidCircle.UseVisualStyleBackColor = true;
            this.SolidCircle.CheckedChanged += new System.EventHandler(this.SolidCircle_CheckedChanged);
            // 
            // Triangle
            // 
            this.Triangle.AutoSize = true;
            this.Triangle.Font = new System.Drawing.Font("宋体", 16F);
            this.Triangle.Location = new System.Drawing.Point(325, 98);
            this.Triangle.Name = "Triangle";
            this.Triangle.Size = new System.Drawing.Size(50, 26);
            this.Triangle.TabIndex = 20;
            this.Triangle.Text = "△";
            this.Triangle.UseVisualStyleBackColor = true;
            // 
            // SolidTriangle
            // 
            this.SolidTriangle.AutoSize = true;
            this.SolidTriangle.Font = new System.Drawing.Font("宋体", 16F);
            this.SolidTriangle.Location = new System.Drawing.Point(325, 161);
            this.SolidTriangle.Name = "SolidTriangle";
            this.SolidTriangle.Size = new System.Drawing.Size(50, 26);
            this.SolidTriangle.TabIndex = 21;
            this.SolidTriangle.Text = "▲";
            this.SolidTriangle.UseVisualStyleBackColor = true;
            // 
            // Square
            // 
            this.Square.AutoSize = true;
            this.Square.Font = new System.Drawing.Font("宋体", 16F);
            this.Square.ForeColor = System.Drawing.Color.MediumPurple;
            this.Square.Location = new System.Drawing.Point(453, 98);
            this.Square.Name = "Square";
            this.Square.Size = new System.Drawing.Size(50, 26);
            this.Square.TabIndex = 22;
            this.Square.Text = "□";
            this.Square.UseVisualStyleBackColor = true;
            // 
            // SolidSquare
            // 
            this.SolidSquare.AutoSize = true;
            this.SolidSquare.Font = new System.Drawing.Font("宋体", 16F);
            this.SolidSquare.Location = new System.Drawing.Point(453, 161);
            this.SolidSquare.Name = "SolidSquare";
            this.SolidSquare.Size = new System.Drawing.Size(50, 26);
            this.SolidSquare.TabIndex = 23;
            this.SolidSquare.Text = "■";
            this.SolidSquare.UseVisualStyleBackColor = true;
            // 
            // CircleDot
            // 
            this.CircleDot.AutoSize = true;
            this.CircleDot.Font = new System.Drawing.Font("宋体", 16F);
            this.CircleDot.Location = new System.Drawing.Point(572, 98);
            this.CircleDot.Name = "CircleDot";
            this.CircleDot.Size = new System.Drawing.Size(50, 26);
            this.CircleDot.TabIndex = 24;
            this.CircleDot.Text = "☉";
            this.CircleDot.UseVisualStyleBackColor = true;
            // 
            // CircleCircle
            // 
            this.CircleCircle.AutoSize = true;
            this.CircleCircle.Font = new System.Drawing.Font("宋体", 16F);
            this.CircleCircle.Location = new System.Drawing.Point(572, 161);
            this.CircleCircle.Name = "CircleCircle";
            this.CircleCircle.Size = new System.Drawing.Size(50, 26);
            this.CircleCircle.TabIndex = 25;
            this.CircleCircle.Text = "◎";
            this.CircleCircle.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(277, 355);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 31);
            this.button1.TabIndex = 26;
            this.button1.Text = "确定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.MediumPurple;
            this.button2.FlatAppearance.BorderSize = 10;
            this.button2.Location = new System.Drawing.Point(453, 355);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(78, 31);
            this.button2.TabIndex = 27;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(433, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 28;
            this.label4.Text = "毫米";
            // 
            // SimpleRendererPoint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 448);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CircleCircle);
            this.Controls.Add(this.CircleDot);
            this.Controls.Add(this.SolidSquare);
            this.Controls.Add(this.Square);
            this.Controls.Add(this.SolidTriangle);
            this.Controls.Add(this.Triangle);
            this.Controls.Add(this.SolidCircle);
            this.Controls.Add(this.Circle);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "SimpleRendererPoint";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "选择点要素样式";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton Circle;
        private System.Windows.Forms.RadioButton SolidCircle;
        private System.Windows.Forms.RadioButton Triangle;
        private System.Windows.Forms.RadioButton SolidTriangle;
        private System.Windows.Forms.RadioButton Square;
        private System.Windows.Forms.RadioButton SolidSquare;
        private System.Windows.Forms.RadioButton CircleDot;
        private System.Windows.Forms.RadioButton CircleCircle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label4;
    }
}