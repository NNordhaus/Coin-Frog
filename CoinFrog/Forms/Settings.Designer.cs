﻿namespace CoinFrog.Forms
{
    partial class Settings
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.nudDaysToForecast = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lvStatuses = new System.Windows.Forms.ListView();
            this.colStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSetTextColor = new System.Windows.Forms.Button();
            this.btnSetBackColor = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnMoveDown = new System.Windows.Forms.Button();
            this.btnMoveUp = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.nudDaysToCalculate = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudDaysToForecast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDaysToCalculate)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(304, 420);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(223, 420);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // nudDaysToForecast
            // 
            this.nudDaysToForecast.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudDaysToForecast.Location = new System.Drawing.Point(308, 24);
            this.nudDaysToForecast.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudDaysToForecast.Name = "nudDaysToForecast";
            this.nudDaysToForecast.Size = new System.Drawing.Size(59, 21);
            this.nudDaysToForecast.TabIndex = 14;
            this.nudDaysToForecast.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudDaysToForecast.ThousandsSeparator = true;
            this.nudDaysToForecast.Value = new decimal(new int[] {
            92,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "Days into the future to forecast:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Transaction Statuses:";
            // 
            // lvStatuses
            // 
            this.lvStatuses.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colStatus});
            this.lvStatuses.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvStatuses.FullRowSelect = true;
            this.lvStatuses.HideSelection = false;
            this.lvStatuses.Location = new System.Drawing.Point(15, 108);
            this.lvStatuses.MultiSelect = false;
            this.lvStatuses.Name = "lvStatuses";
            this.lvStatuses.Size = new System.Drawing.Size(208, 289);
            this.lvStatuses.TabIndex = 17;
            this.lvStatuses.UseCompatibleStateImageBehavior = false;
            this.lvStatuses.View = System.Windows.Forms.View.Details;
            this.lvStatuses.SelectedIndexChanged += new System.EventHandler(this.lvStatuses_SelectedIndexChanged);
            // 
            // colStatus
            // 
            this.colStatus.Text = "Status";
            this.colStatus.Width = 170;
            // 
            // btnSetTextColor
            // 
            this.btnSetTextColor.Enabled = false;
            this.btnSetTextColor.Location = new System.Drawing.Point(233, 108);
            this.btnSetTextColor.Name = "btnSetTextColor";
            this.btnSetTextColor.Size = new System.Drawing.Size(96, 23);
            this.btnSetTextColor.TabIndex = 18;
            this.btnSetTextColor.Text = "Set Text Color...";
            this.btnSetTextColor.UseVisualStyleBackColor = true;
            this.btnSetTextColor.Click += new System.EventHandler(this.btnSetTextColor_Click);
            // 
            // btnSetBackColor
            // 
            this.btnSetBackColor.Enabled = false;
            this.btnSetBackColor.Location = new System.Drawing.Point(233, 137);
            this.btnSetBackColor.Name = "btnSetBackColor";
            this.btnSetBackColor.Size = new System.Drawing.Size(96, 23);
            this.btnSetBackColor.TabIndex = 19;
            this.btnSetBackColor.Text = "Set Back Color...";
            this.btnSetBackColor.UseVisualStyleBackColor = true;
            this.btnSetBackColor.Click += new System.EventHandler(this.btnSetBackColor_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(233, 218);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(96, 23);
            this.btnAdd.TabIndex = 20;
            this.btnAdd.Text = "Add New...";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(233, 247);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(96, 23);
            this.btnDelete.TabIndex = 21;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnMoveDown
            // 
            this.btnMoveDown.Enabled = false;
            this.btnMoveDown.Location = new System.Drawing.Point(233, 339);
            this.btnMoveDown.Name = "btnMoveDown";
            this.btnMoveDown.Size = new System.Drawing.Size(96, 23);
            this.btnMoveDown.TabIndex = 23;
            this.btnMoveDown.Text = "Move Down";
            this.btnMoveDown.UseVisualStyleBackColor = true;
            // 
            // btnMoveUp
            // 
            this.btnMoveUp.Enabled = false;
            this.btnMoveUp.Location = new System.Drawing.Point(233, 310);
            this.btnMoveUp.Name = "btnMoveUp";
            this.btnMoveUp.Size = new System.Drawing.Size(96, 23);
            this.btnMoveUp.TabIndex = 22;
            this.btnMoveUp.Text = "Move Up";
            this.btnMoveUp.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(290, 15);
            this.label3.TabIndex = 25;
            this.label3.Text = "Days into the future to calculate Minimum && Average";
            // 
            // nudDaysToCalculate
            // 
            this.nudDaysToCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudDaysToCalculate.Location = new System.Drawing.Point(308, 50);
            this.nudDaysToCalculate.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudDaysToCalculate.Name = "nudDaysToCalculate";
            this.nudDaysToCalculate.Size = new System.Drawing.Size(59, 21);
            this.nudDaysToCalculate.TabIndex = 24;
            this.nudDaysToCalculate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudDaysToCalculate.ThousandsSeparator = true;
            this.nudDaysToCalculate.Value = new decimal(new int[] {
            92,
            0,
            0,
            0});
            // 
            // Settings
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(391, 455);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudDaysToCalculate);
            this.Controls.Add(this.btnMoveDown);
            this.Controls.Add(this.btnMoveUp);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSetBackColor);
            this.Controls.Add(this.btnSetTextColor);
            this.Controls.Add(this.lvStatuses);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudDaysToForecast);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Name = "Settings";
            this.Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)(this.nudDaysToForecast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDaysToCalculate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.NumericUpDown nudDaysToForecast;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lvStatuses;
        private System.Windows.Forms.Button btnSetTextColor;
        private System.Windows.Forms.Button btnSetBackColor;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnMoveDown;
        private System.Windows.Forms.Button btnMoveUp;
        private System.Windows.Forms.ColumnHeader colStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudDaysToCalculate;

    }
}