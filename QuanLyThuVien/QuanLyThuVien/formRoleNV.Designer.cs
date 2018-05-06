namespace QuanLyThuVien
{
    partial class formRoleNV
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
            this.roleIDNV = new System.Windows.Forms.Label();
            this.roleNameNV = new System.Windows.Forms.Label();
            this.descriptionRole = new System.Windows.Forms.Label();
            this.txtRoleID = new System.Windows.Forms.TextBox();
            this.txtRoleName = new System.Windows.Forms.TextBox();
            this.txtDesciption = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnThemRole = new System.Windows.Forms.Button();
            this.btnSuaRole = new System.Windows.Forms.Button();
            this.btnXoaRole = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // roleIDNV
            // 
            this.roleIDNV.AutoSize = true;
            this.roleIDNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roleIDNV.Location = new System.Drawing.Point(262, 35);
            this.roleIDNV.Name = "roleIDNV";
            this.roleIDNV.Size = new System.Drawing.Size(46, 13);
            this.roleIDNV.TabIndex = 0;
            this.roleIDNV.Text = "RoleID";
            // 
            // roleNameNV
            // 
            this.roleNameNV.AutoSize = true;
            this.roleNameNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roleNameNV.Location = new System.Drawing.Point(262, 74);
            this.roleNameNV.Name = "roleNameNV";
            this.roleNameNV.Size = new System.Drawing.Size(35, 13);
            this.roleNameNV.TabIndex = 1;
            this.roleNameNV.Text = "Vị trí";
            this.roleNameNV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // descriptionRole
            // 
            this.descriptionRole.AutoSize = true;
            this.descriptionRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionRole.Location = new System.Drawing.Point(262, 112);
            this.descriptionRole.Name = "descriptionRole";
            this.descriptionRole.Size = new System.Drawing.Size(71, 13);
            this.descriptionRole.TabIndex = 2;
            this.descriptionRole.Text = "Description";
            // 
            // txtRoleID
            // 
            this.txtRoleID.Location = new System.Drawing.Point(348, 28);
            this.txtRoleID.Name = "txtRoleID";
            this.txtRoleID.Size = new System.Drawing.Size(157, 20);
            this.txtRoleID.TabIndex = 3;
            // 
            // txtRoleName
            // 
            this.txtRoleName.Location = new System.Drawing.Point(348, 67);
            this.txtRoleName.Name = "txtRoleName";
            this.txtRoleName.Size = new System.Drawing.Size(157, 20);
            this.txtRoleName.TabIndex = 4;
            // 
            // txtDesciption
            // 
            this.txtDesciption.Location = new System.Drawing.Point(348, 105);
            this.txtDesciption.Name = "txtDesciption";
            this.txtDesciption.Size = new System.Drawing.Size(157, 20);
            this.txtDesciption.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(254, 344);
            this.dataGridView1.TabIndex = 6;
            // 
            // btnThemRole
            // 
            this.btnThemRole.BackColor = System.Drawing.SystemColors.Info;
            this.btnThemRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemRole.Image = global::QuanLyThuVien.Properties.Resources.add_icon;
            this.btnThemRole.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnThemRole.Location = new System.Drawing.Point(265, 172);
            this.btnThemRole.Name = "btnThemRole";
            this.btnThemRole.Size = new System.Drawing.Size(60, 60);
            this.btnThemRole.TabIndex = 7;
            this.btnThemRole.Text = "Thêm";
            this.btnThemRole.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThemRole.UseVisualStyleBackColor = false;
            // 
            // btnSuaRole
            // 
            this.btnSuaRole.BackColor = System.Drawing.SystemColors.Info;
            this.btnSuaRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaRole.Image = global::QuanLyThuVien.Properties.Resources.Pencil_icon;
            this.btnSuaRole.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSuaRole.Location = new System.Drawing.Point(359, 172);
            this.btnSuaRole.Name = "btnSuaRole";
            this.btnSuaRole.Size = new System.Drawing.Size(60, 60);
            this.btnSuaRole.TabIndex = 8;
            this.btnSuaRole.Text = "Sửa";
            this.btnSuaRole.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSuaRole.UseVisualStyleBackColor = false;
            // 
            // btnXoaRole
            // 
            this.btnXoaRole.BackColor = System.Drawing.SystemColors.Info;
            this.btnXoaRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaRole.Image = global::QuanLyThuVien.Properties.Resources.close_icon;
            this.btnXoaRole.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnXoaRole.Location = new System.Drawing.Point(445, 172);
            this.btnXoaRole.Name = "btnXoaRole";
            this.btnXoaRole.Size = new System.Drawing.Size(60, 60);
            this.btnXoaRole.TabIndex = 9;
            this.btnXoaRole.Text = "Xóa";
            this.btnXoaRole.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnXoaRole.UseVisualStyleBackColor = false;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.SystemColors.Info;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Image = global::QuanLyThuVien.Properties.Resources.switch_turn_off_icon;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnThoat.Location = new System.Drawing.Point(359, 263);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(60, 60);
            this.btnThoat.TabIndex = 10;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // formRoleNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 361);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoaRole);
            this.Controls.Add(this.btnSuaRole);
            this.Controls.Add(this.btnThemRole);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtDesciption);
            this.Controls.Add(this.txtRoleName);
            this.Controls.Add(this.txtRoleID);
            this.Controls.Add(this.descriptionRole);
            this.Controls.Add(this.roleNameNV);
            this.Controls.Add(this.roleIDNV);
            this.Name = "formRoleNV";
            this.Text = "RoleNV";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label roleIDNV;
        private System.Windows.Forms.Label roleNameNV;
        private System.Windows.Forms.Label descriptionRole;
        private System.Windows.Forms.TextBox txtRoleID;
        private System.Windows.Forms.TextBox txtRoleName;
        private System.Windows.Forms.TextBox txtDesciption;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnThemRole;
        private System.Windows.Forms.Button btnSuaRole;
        private System.Windows.Forms.Button btnXoaRole;
        private System.Windows.Forms.Button btnThoat;
    }
}