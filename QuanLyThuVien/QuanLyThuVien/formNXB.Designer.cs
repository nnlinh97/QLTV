namespace QuanLyThuVien
{
    partial class formNXB
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
            this.txtMaNXB = new System.Windows.Forms.TextBox();
            this.txtTenNXB = new System.Windows.Forms.TextBox();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.gvNXB = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvNXB)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã NXB";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên NXB";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mô Tả";
            // 
            // txtMaNXB
            // 
            this.txtMaNXB.AcceptsTab = true;
            this.txtMaNXB.Location = new System.Drawing.Point(120, 28);
            this.txtMaNXB.Name = "txtMaNXB";
            this.txtMaNXB.Size = new System.Drawing.Size(316, 22);
            this.txtMaNXB.TabIndex = 1;
            // 
            // txtTenNXB
            // 
            this.txtTenNXB.Location = new System.Drawing.Point(120, 65);
            this.txtTenNXB.Name = "txtTenNXB";
            this.txtTenNXB.Size = new System.Drawing.Size(316, 22);
            this.txtTenNXB.TabIndex = 2;
            // 
            // txtMoTa
            // 
            this.txtMoTa.Location = new System.Drawing.Point(120, 106);
            this.txtMoTa.Multiline = true;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(316, 82);
            this.txtMoTa.TabIndex = 3;
            // 
            // gvNXB
            // 
            this.gvNXB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvNXB.Location = new System.Drawing.Point(37, 208);
            this.gvNXB.Name = "gvNXB";
            this.gvNXB.RowTemplate.Height = 24;
            this.gvNXB.Size = new System.Drawing.Size(399, 286);
            this.gvNXB.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Image = global::QuanLyThuVien.Properties.Resources.add_icon;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(475, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 68);
            this.button1.TabIndex = 5;
            this.button1.Text = "Thêm";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Image = global::QuanLyThuVien.Properties.Resources.Pencil_icon;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(475, 145);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 68);
            this.button2.TabIndex = 5;
            this.button2.Text = "Sửa";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Image = global::QuanLyThuVien.Properties.Resources.close_icon;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.Location = new System.Drawing.Point(475, 231);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 68);
            this.button3.TabIndex = 5;
            this.button3.Text = "Xóa";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Image = global::QuanLyThuVien.Properties.Resources.Actions_document_save_icon;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button4.Location = new System.Drawing.Point(475, 315);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 68);
            this.button4.TabIndex = 5;
            this.button4.Text = "Lưu";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Image = global::QuanLyThuVien.Properties.Resources.switch_turn_off_icon;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button5.Location = new System.Drawing.Point(475, 398);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 68);
            this.button5.TabIndex = 5;
            this.button5.Text = "Thoát";
            this.button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // formNXB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 506);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gvNXB);
            this.Controls.Add(this.txtMoTa);
            this.Controls.Add(this.txtTenNXB);
            this.Controls.Add(this.txtMaNXB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "formNXB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhà Xuất Bản";
            ((System.ComponentModel.ISupportInitialize)(this.gvNXB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaNXB;
        private System.Windows.Forms.TextBox txtTenNXB;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.DataGridView gvNXB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}