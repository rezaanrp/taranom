namespace Payazob.FRM.NonConforming
{
    partial class frmNonConformingType
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
            this.btn_edit = new System.Windows.Forms.Button();
            this.txt_NodeText = new System.Windows.Forms.TextBox();
            this.btn_AddTree = new System.Windows.Forms.Button();
            this.treeView_DownTime = new System.Windows.Forms.TreeView();
            this.btn_Tree = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(80, 18);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(62, 33);
            this.btn_edit.TabIndex = 10;
            this.btn_edit.Text = "ویرایش";
            this.btn_edit.UseVisualStyleBackColor = true;
            // 
            // txt_NodeText
            // 
            this.txt_NodeText.Location = new System.Drawing.Point(216, 25);
            this.txt_NodeText.Name = "txt_NodeText";
            this.txt_NodeText.Size = new System.Drawing.Size(138, 21);
            this.txt_NodeText.TabIndex = 9;
            // 
            // btn_AddTree
            // 
            this.btn_AddTree.Location = new System.Drawing.Point(148, 18);
            this.btn_AddTree.Name = "btn_AddTree";
            this.btn_AddTree.Size = new System.Drawing.Size(62, 33);
            this.btn_AddTree.TabIndex = 8;
            this.btn_AddTree.Text = "اضافه";
            this.btn_AddTree.UseVisualStyleBackColor = true;
            // 
            // treeView_DownTime
            // 
            this.treeView_DownTime.Location = new System.Drawing.Point(10, 57);
            this.treeView_DownTime.Name = "treeView_DownTime";
            this.treeView_DownTime.Size = new System.Drawing.Size(344, 369);
            this.treeView_DownTime.TabIndex = 6;
            this.treeView_DownTime.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView_DownTime_NodeMouseDoubleClick);
            // 
            // btn_Tree
            // 
            this.btn_Tree.BackgroundImage = global::Payazob.Properties.Resources.software_update;
            this.btn_Tree.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Tree.Location = new System.Drawing.Point(12, 18);
            this.btn_Tree.Name = "btn_Tree";
            this.btn_Tree.Size = new System.Drawing.Size(62, 33);
            this.btn_Tree.TabIndex = 7;
            this.btn_Tree.UseVisualStyleBackColor = true;
            this.btn_Tree.Click += new System.EventHandler(this.btn_Tree_Click);
            // 
            // frmNonConformingType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 444);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.txt_NodeText);
            this.Controls.Add(this.btn_AddTree);
            this.Controls.Add(this.btn_Tree);
            this.Controls.Add(this.treeView_DownTime);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.Name = "frmNonConformingType";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "نوع عدم انطباق";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.TextBox txt_NodeText;
        private System.Windows.Forms.Button btn_AddTree;
        private System.Windows.Forms.Button btn_Tree;
        private System.Windows.Forms.TreeView treeView_DownTime;
    }
}