﻿
namespace MyMapObjectsDemo2022
{
    partial class LabelRenderer
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
            this.checkBoxShowLabel = new System.Windows.Forms.CheckBox();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.textBoxFontSize = new System.Windows.Forms.TextBox();
            this.comboBoxFontFamily = new System.Windows.Forms.ComboBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.buttonFontColor = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBoxMask = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonMaskColor = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxMaskWidth = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(71, 34);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(159, 88);
            this.listBox1.TabIndex = 0;
            // 
            // checkBoxShowLabel
            // 
            this.checkBoxShowLabel.AutoSize = true;
            this.checkBoxShowLabel.Checked = true;
            this.checkBoxShowLabel.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxShowLabel.Location = new System.Drawing.Point(60, 12);
            this.checkBoxShowLabel.Name = "checkBoxShowLabel";
            this.checkBoxShowLabel.Size = new System.Drawing.Size(120, 16);
            this.checkBoxShowLabel.TabIndex = 1;
            this.checkBoxShowLabel.Text = "是否显示图层注记";
            this.checkBoxShowLabel.UseVisualStyleBackColor = true;
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Location = new System.Drawing.Point(71, 289);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(75, 23);
            this.buttonConfirm.TabIndex = 2;
            this.buttonConfirm.Text = "更改";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // textBoxFontSize
            // 
            this.textBoxFontSize.Location = new System.Drawing.Point(71, 154);
            this.textBoxFontSize.Name = "textBoxFontSize";
            this.textBoxFontSize.Size = new System.Drawing.Size(159, 21);
            this.textBoxFontSize.TabIndex = 3;
            this.textBoxFontSize.Text = "12";
            // 
            // comboBoxFontFamily
            // 
            this.comboBoxFontFamily.FormattingEnabled = true;
            this.comboBoxFontFamily.Location = new System.Drawing.Point(71, 128);
            this.comboBoxFontFamily.Name = "comboBoxFontFamily";
            this.comboBoxFontFamily.Size = new System.Drawing.Size(159, 20);
            this.comboBoxFontFamily.TabIndex = 4;
            this.comboBoxFontFamily.Text = "微软雅黑";
            // 
            // buttonFontColor
            // 
            this.buttonFontColor.Location = new System.Drawing.Point(71, 181);
            this.buttonFontColor.Name = "buttonFontColor";
            this.buttonFontColor.Size = new System.Drawing.Size(159, 23);
            this.buttonFontColor.TabIndex = 5;
            this.buttonFontColor.Text = "更改字体颜色";
            this.buttonFontColor.UseVisualStyleBackColor = true;
            this.buttonFontColor.Click += new System.EventHandler(this.buttonFontColor_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(152, 289);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 6;
            this.buttonCancel.Text = "确定";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "字段";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "字体";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "字体颜色";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "字号";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "显示";
            // 
            // checkBoxMask
            // 
            this.checkBoxMask.AutoSize = true;
            this.checkBoxMask.Location = new System.Drawing.Point(71, 210);
            this.checkBoxMask.Name = "checkBoxMask";
            this.checkBoxMask.Size = new System.Drawing.Size(96, 16);
            this.checkBoxMask.TabIndex = 12;
            this.checkBoxMask.Text = "是否使用描边";
            this.checkBoxMask.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 13;
            this.label6.Text = "描边";
            // 
            // buttonMaskColor
            // 
            this.buttonMaskColor.Location = new System.Drawing.Point(71, 232);
            this.buttonMaskColor.Name = "buttonMaskColor";
            this.buttonMaskColor.Size = new System.Drawing.Size(156, 23);
            this.buttonMaskColor.TabIndex = 14;
            this.buttonMaskColor.Text = "更改描边颜色";
            this.buttonMaskColor.UseVisualStyleBackColor = true;
            this.buttonMaskColor.Click += new System.EventHandler(this.buttonMaskColor_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 237);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 15;
            this.label7.Text = "描边颜色";
            // 
            // textBoxMaskWidth
            // 
            this.textBoxMaskWidth.Location = new System.Drawing.Point(71, 262);
            this.textBoxMaskWidth.Name = "textBoxMaskWidth";
            this.textBoxMaskWidth.Size = new System.Drawing.Size(156, 21);
            this.textBoxMaskWidth.TabIndex = 16;
            this.textBoxMaskWidth.Text = "0.5";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 265);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 17;
            this.label8.Text = "描边宽度";
            // 
            // LabelRenderer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 325);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxMaskWidth);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonMaskColor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.checkBoxMask);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonFontColor);
            this.Controls.Add(this.comboBoxFontFamily);
            this.Controls.Add(this.textBoxFontSize);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.checkBoxShowLabel);
            this.Controls.Add(this.listBox1);
            this.Name = "LabelRenderer";
            this.Text = "LabelRenderer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.CheckBox checkBoxShowLabel;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.TextBox textBoxFontSize;
        private System.Windows.Forms.ComboBox comboBoxFontFamily;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button buttonFontColor;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBoxMask;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonMaskColor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxMaskWidth;
        private System.Windows.Forms.Label label8;
    }
}