﻿namespace TARANOM.FRM.WareHouseStock
{
    partial class frmSelectExcelSheet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSelectExcelSheet));
            this.btnOk = new System.Windows.Forms.Button();
            this.lstViewTables = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOk.BackgroundImage")));
            this.btnOk.Location = new System.Drawing.Point(170, 319);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(68, 33);
            this.btnOk.TabIndex = 3;
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // lstViewTables
            // 
            this.lstViewTables.HideSelection = false;
            this.lstViewTables.Location = new System.Drawing.Point(12, 12);
            this.lstViewTables.Name = "lstViewTables";
            this.lstViewTables.Size = new System.Drawing.Size(224, 306);
            this.lstViewTables.TabIndex = 2;
            this.lstViewTables.UseCompatibleStateImageBehavior = false;
            this.lstViewTables.View = System.Windows.Forms.View.List;
            this.lstViewTables.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.LstViewTables_ItemSelectionChanged);
            // 
            // frmSelectExcelSheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 360);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lstViewTables);
            this.Name = "frmSelectExcelSheet";
            this.Text = "frmSelectExcelSheet";
            this.Load += new System.EventHandler(this.FrmSelectExcelSheet_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.ListView lstViewTables;
    }
}