﻿namespace MyMapObjectsDemo2022
{
    partial class propertyTable
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.添加字段ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除字段ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改字段ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.排列字段顺序ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.显示所有已选择要素ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.propertyGrid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.反选ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.propertyGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加字段ToolStripMenuItem,
            this.删除字段ToolStripMenuItem,
            this.修改字段ToolStripMenuItem,
            this.排列字段顺序ToolStripMenuItem,
            this.显示所有已选择要素ToolStripMenuItem,
            this.反选ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(965, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 添加字段ToolStripMenuItem
            // 
            this.添加字段ToolStripMenuItem.Name = "添加字段ToolStripMenuItem";
            this.添加字段ToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.添加字段ToolStripMenuItem.Text = "添加字段";
            this.添加字段ToolStripMenuItem.Click += new System.EventHandler(this.添加字段ToolStripMenuItem_Click);
            // 
            // 删除字段ToolStripMenuItem
            // 
            this.删除字段ToolStripMenuItem.Name = "删除字段ToolStripMenuItem";
            this.删除字段ToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.删除字段ToolStripMenuItem.Text = "删除字段";
            this.删除字段ToolStripMenuItem.Click += new System.EventHandler(this.删除字段ToolStripMenuItem_Click);
            // 
            // 修改字段ToolStripMenuItem
            // 
            this.修改字段ToolStripMenuItem.Name = "修改字段ToolStripMenuItem";
            this.修改字段ToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.修改字段ToolStripMenuItem.Text = "修改字段名称";
            this.修改字段ToolStripMenuItem.Click += new System.EventHandler(this.修改字段ToolStripMenuItem_Click);
            // 
            // 排列字段顺序ToolStripMenuItem
            // 
            this.排列字段顺序ToolStripMenuItem.Name = "排列字段顺序ToolStripMenuItem";
            this.排列字段顺序ToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.排列字段顺序ToolStripMenuItem.Text = "排列字段顺序";
            this.排列字段顺序ToolStripMenuItem.Click += new System.EventHandler(this.排列字段顺序ToolStripMenuItem_Click);
            // 
            // 显示所有已选择要素ToolStripMenuItem
            // 
            this.显示所有已选择要素ToolStripMenuItem.Name = "显示所有已选择要素ToolStripMenuItem";
            this.显示所有已选择要素ToolStripMenuItem.Size = new System.Drawing.Size(141, 20);
            this.显示所有已选择要素ToolStripMenuItem.Text = "显示所有/已选择要素";
            this.显示所有已选择要素ToolStripMenuItem.Click += new System.EventHandler(this.显示所有已选择要素ToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 593);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(965, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(98, 17);
            this.toolStripStatusLabel1.Text = "已选择要素数：";
            // 
            // propertyGrid
            // 
            this.propertyGrid.AllowUserToAddRows = false;
            this.propertyGrid.AllowUserToDeleteRows = false;
            this.propertyGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.propertyGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.propertyGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGrid.Location = new System.Drawing.Point(0, 24);
            this.propertyGrid.Name = "propertyGrid";
            this.propertyGrid.RowTemplate.Height = 23;
            this.propertyGrid.Size = new System.Drawing.Size(965, 569);
            this.propertyGrid.TabIndex = 2;
            this.propertyGrid.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.propertyGrid_CellBeginEdit);
            this.propertyGrid.SelectionChanged += new System.EventHandler(this.propertyGrid_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            // 
            // 反选ToolStripMenuItem
            // 
            this.反选ToolStripMenuItem.Name = "反选ToolStripMenuItem";
            this.反选ToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.反选ToolStripMenuItem.Text = "反选";
            this.反选ToolStripMenuItem.Click += new System.EventHandler(this.反选ToolStripMenuItem_Click);
            // 
            // propertyTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 615);
            this.Controls.Add(this.propertyGrid);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "propertyTable";
            this.Text = "属性表";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.propertyTable_FormClosed);
            this.Load += new System.EventHandler(this.propertyTable_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.propertyGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 添加字段ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除字段ToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem 显示所有已选择要素ToolStripMenuItem;
        private System.Windows.Forms.DataGridView propertyGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.ToolStripMenuItem 修改字段ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 排列字段顺序ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 反选ToolStripMenuItem;
    }
}