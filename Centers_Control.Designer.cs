namespace Admin_WorkEase
{
    partial class Centers_Control
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.delete_btn = new System.Windows.Forms.Button();
            this.Add_btn = new System.Windows.Forms.Button();
            this.listView2 = new System.Windows.Forms.ListView();
            this.addId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(660, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 62);
            this.label1.TabIndex = 1;
            this.label1.Text = "Centers";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(196)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(302, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1324, 122);
            this.panel1.TabIndex = 2;
            // 
            // delete_btn
            // 
            this.delete_btn.BackColor = System.Drawing.Color.Red;
            this.delete_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.delete_btn.Location = new System.Drawing.Point(1400, 691);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(226, 83);
            this.delete_btn.TabIndex = 3;
            this.delete_btn.Text = "Delete Center ";
            this.delete_btn.UseVisualStyleBackColor = false;
            // 
            // Add_btn
            // 
            this.Add_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(182)))), ((int)(((byte)(255)))));
            this.Add_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Add_btn.Location = new System.Drawing.Point(1129, 691);
            this.Add_btn.Name = "Add_btn";
            this.Add_btn.Size = new System.Drawing.Size(226, 83);
            this.Add_btn.TabIndex = 4;
            this.Add_btn.Text = "Add Center ";
            this.Add_btn.UseVisualStyleBackColor = false;
            // 
            // listView2
            // 
            this.listView2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.listView2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.addId,
            this.columnHeader1});
            this.listView2.GridLines = true;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(302, 133);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(1324, 532);
            this.listView2.TabIndex = 6;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // addId
            // 
            this.addId.Text = "id";
            this.addId.Width = 160;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name of Barangay\'s";
            this.columnHeader1.Width = 190;
            // 
            // Centers_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.Add_btn);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.panel1);
            this.Name = "Centers_Control";
            this.Size = new System.Drawing.Size(1694, 945);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button Add_btn;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader addId;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}
