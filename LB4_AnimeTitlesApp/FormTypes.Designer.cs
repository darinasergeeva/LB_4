﻿namespace LB4_AnimeTitlesApp
{
    partial class FormTypes
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
            flowLayoutPanelTop = new FlowLayoutPanel();
            buttonTypeAdd = new Button();
            button2 = new Button();
            buttonTypeDelete = new Button();
            panelFill = new Panel();
            dataGridViewTypes = new DataGridView();
            flowLayoutPanelTop.SuspendLayout();
            panelFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTypes).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanelTop
            // 
            flowLayoutPanelTop.AutoSize = true;
            flowLayoutPanelTop.Controls.Add(buttonTypeAdd);
            flowLayoutPanelTop.Controls.Add(button2);
            flowLayoutPanelTop.Controls.Add(buttonTypeDelete);
            flowLayoutPanelTop.Dock = DockStyle.Top;
            flowLayoutPanelTop.Location = new Point(0, 0);
            flowLayoutPanelTop.Name = "flowLayoutPanelTop";
            flowLayoutPanelTop.Padding = new Padding(10);
            flowLayoutPanelTop.Size = new Size(1257, 61);
            flowLayoutPanelTop.TabIndex = 0;
            // 
            // buttonTypeAdd
            // 
            buttonTypeAdd.Location = new Point(13, 13);
            buttonTypeAdd.Name = "buttonTypeAdd";
            buttonTypeAdd.Size = new Size(150, 35);
            buttonTypeAdd.TabIndex = 0;
            buttonTypeAdd.Text = "Добавить";
            buttonTypeAdd.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(169, 13);
            button2.Name = "button2";
            button2.Size = new Size(150, 35);
            button2.TabIndex = 1;
            button2.Text = "Редактировать";
            button2.UseVisualStyleBackColor = true;
            // 
            // buttonTypeDelete
            // 
            buttonTypeDelete.Location = new Point(325, 13);
            buttonTypeDelete.Name = "buttonTypeDelete";
            buttonTypeDelete.Size = new Size(150, 35);
            buttonTypeDelete.TabIndex = 2;
            buttonTypeDelete.Text = "Удалить";
            buttonTypeDelete.UseVisualStyleBackColor = true;
            // 
            // panelFill
            // 
            panelFill.Controls.Add(dataGridViewTypes);
            panelFill.Dock = DockStyle.Fill;
            panelFill.Location = new Point(0, 61);
            panelFill.Name = "panelFill";
            panelFill.Padding = new Padding(10);
            panelFill.Size = new Size(1257, 689);
            panelFill.TabIndex = 1;
            // 
            // dataGridViewTypes
            // 
            dataGridViewTypes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            dataGridViewTypes.BackgroundColor = Color.White;
            dataGridViewTypes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTypes.Dock = DockStyle.Fill;
            dataGridViewTypes.Location = new Point(10, 10);
            dataGridViewTypes.MultiSelect = false;
            dataGridViewTypes.Name = "dataGridViewTypes";
            dataGridViewTypes.ReadOnly = true;
            dataGridViewTypes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewTypes.Size = new Size(1237, 669);
            dataGridViewTypes.TabIndex = 0;
            // 
            // FormTypes
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1257, 750);
            Controls.Add(panelFill);
            Controls.Add(flowLayoutPanelTop);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(5);
            Name = "FormTypes";
            Text = "Типы аниме";
            Load += FormTypes_Load;
            flowLayoutPanelTop.ResumeLayout(false);
            panelFill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewTypes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanelTop;
        private Button buttonTypeAdd;
        private Button button2;
        private Button buttonTypeDelete;
        private Panel panelFill;
        private DataGridView dataGridViewTypes;
    }
}