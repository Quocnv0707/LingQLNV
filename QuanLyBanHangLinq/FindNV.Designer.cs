
namespace QuanLyBanHangLinq
{
    partial class FindNV
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
            this.txtInFor = new System.Windows.Forms.TextBox();
            this.hoTenNhanVienLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdMa = new System.Windows.Forms.RadioButton();
            this.rdTen = new System.Windows.Forms.RadioButton();
            this.rdHo = new System.Windows.Forms.RadioButton();
            this.btTim = new System.Windows.Forms.Button();
            this.gVTK = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gVTK)).BeginInit();
            this.SuspendLayout();
            // 
            // txtInFor
            // 
            this.txtInFor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInFor.Location = new System.Drawing.Point(185, 38);
            this.txtInFor.Margin = new System.Windows.Forms.Padding(4);
            this.txtInFor.Name = "txtInFor";
            this.txtInFor.Size = new System.Drawing.Size(367, 30);
            this.txtInFor.TabIndex = 3;
            // 
            // hoTenNhanVienLabel
            // 
            this.hoTenNhanVienLabel.AutoSize = true;
            this.hoTenNhanVienLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoTenNhanVienLabel.Location = new System.Drawing.Point(77, 38);
            this.hoTenNhanVienLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.hoTenNhanVienLabel.Name = "hoTenNhanVienLabel";
            this.hoTenNhanVienLabel.Size = new System.Drawing.Size(70, 25);
            this.hoTenNhanVienLabel.TabIndex = 2;
            this.hoTenNhanVienLabel.Text = "Nhập: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btTim);
            this.groupBox1.Controls.Add(this.rdHo);
            this.groupBox1.Controls.Add(this.rdTen);
            this.groupBox1.Controls.Add(this.rdMa);
            this.groupBox1.Controls.Add(this.hoTenNhanVienLabel);
            this.groupBox1.Controls.Add(this.txtInFor);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(669, 184);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm nhân viên";
            // 
            // rdMa
            // 
            this.rdMa.AutoSize = true;
            this.rdMa.Checked = true;
            this.rdMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdMa.Location = new System.Drawing.Point(2, 86);
            this.rdMa.Name = "rdMa";
            this.rdMa.Size = new System.Drawing.Size(163, 24);
            this.rdMa.TabIndex = 4;
            this.rdMa.TabStop = true;
            this.rdMa.Text = "Tìm kiếm theo mã";
            this.rdMa.UseVisualStyleBackColor = true;
            // 
            // rdTen
            // 
            this.rdTen.AutoSize = true;
            this.rdTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdTen.Location = new System.Drawing.Point(246, 86);
            this.rdTen.Name = "rdTen";
            this.rdTen.Size = new System.Drawing.Size(163, 24);
            this.rdTen.TabIndex = 4;
            this.rdTen.Text = "Tìm kiếm theo tên";
            this.rdTen.UseVisualStyleBackColor = true;
            // 
            // rdHo
            // 
            this.rdHo.AutoSize = true;
            this.rdHo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdHo.Location = new System.Drawing.Point(499, 86);
            this.rdHo.Name = "rdHo";
            this.rdHo.Size = new System.Drawing.Size(158, 24);
            this.rdHo.TabIndex = 4;
            this.rdHo.Text = "Tìm kiếm theo họ";
            this.rdHo.UseVisualStyleBackColor = true;
            // 
            // btTim
            // 
            this.btTim.Location = new System.Drawing.Point(284, 134);
            this.btTim.Name = "btTim";
            this.btTim.Size = new System.Drawing.Size(101, 37);
            this.btTim.TabIndex = 5;
            this.btTim.Text = "Tìm";
            this.btTim.UseVisualStyleBackColor = true;
            this.btTim.Click += new System.EventHandler(this.btTim_Click);
            // 
            // gVTK
            // 
            this.gVTK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gVTK.Location = new System.Drawing.Point(13, 204);
            this.gVTK.Name = "gVTK";
            this.gVTK.RowHeadersWidth = 51;
            this.gVTK.RowTemplate.Height = 24;
            this.gVTK.Size = new System.Drawing.Size(670, 234);
            this.gVTK.TabIndex = 3;
            // 
            // FindNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 450);
            this.Controls.Add(this.gVTK);
            this.Controls.Add(this.groupBox1);
            this.Name = "FindNV";
            this.Text = "FindNV";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gVTK)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtInFor;
        private System.Windows.Forms.Label hoTenNhanVienLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdHo;
        private System.Windows.Forms.RadioButton rdTen;
        private System.Windows.Forms.RadioButton rdMa;
        private System.Windows.Forms.Button btTim;
        private System.Windows.Forms.DataGridView gVTK;
    }
}