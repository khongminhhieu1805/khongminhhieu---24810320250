namespace hoccsharp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.menuHeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.menuXuatCsv = new System.Windows.Forms.ToolStripMenuItem();
            this.menuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStripMain = new System.Windows.Forms.StatusStrip();
            this.lblTongSoSP = new System.Windows.Forms.ToolStripStatusLabel();
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.pnlTrai = new System.Windows.Forms.Panel();
            this.grpNhapLieu = new System.Windows.Forms.GroupBox();
            this.lblMaSP = new System.Windows.Forms.Label();
            this.txtProductId = new System.Windows.Forms.TextBox();
            this.lblTenSP = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lblDanhMuc = new System.Windows.Forms.Label();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.lblDonGia = new System.Windows.Forms.Label();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblAnh = new System.Windows.Forms.Label();
            this.picAvatar = new System.Windows.Forms.PictureBox();
            this.btnChooseImage = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.pnlPhai = new System.Windows.Forms.Panel();
            this.grpBangDuLieu = new System.Windows.Forms.GroupBox();
            this.lblTimKiem = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.colMaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDanhMuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.openFileDialogImage = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogCsv = new System.Windows.Forms.SaveFileDialog();
            this.menuStripMain.SuspendLayout();
            this.statusStripMain.SuspendLayout();
            this.tableLayoutPanelMain.SuspendLayout();
            this.pnlTrai.SuspendLayout();
            this.grpNhapLieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.pnlPhai.SuspendLayout();
            this.grpBangDuLieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();

            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuHeThong});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(984, 24);
            this.menuStripMain.TabIndex = 0;

            this.menuHeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuXuatCsv,
            this.menuThoat});
            this.menuHeThong.Name = "menuHeThong";
            this.menuHeThong.Size = new System.Drawing.Size(69, 20);
            this.menuHeThong.Text = "Hệ Thống";

            this.menuXuatCsv.Name = "menuXuatCsv";
            this.menuXuatCsv.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.menuXuatCsv.Size = new System.Drawing.Size(173, 22);
            this.menuXuatCsv.Text = "Xuất CSV";
            this.menuXuatCsv.Click += new System.EventHandler(this.menuXuatCsv_Click);

            this.menuThoat.Name = "menuThoat";
            this.menuThoat.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.menuThoat.Size = new System.Drawing.Size(173, 22);
            this.menuThoat.Text = "Thoát";
            this.menuThoat.Click += new System.EventHandler(this.menuThoat_Click);

            this.statusStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblTongSoSP});
            this.statusStripMain.Location = new System.Drawing.Point(0, 539);
            this.statusStripMain.Name = "statusStripMain";
            this.statusStripMain.Size = new System.Drawing.Size(984, 22);
            this.statusStripMain.TabIndex = 1;

            this.lblTongSoSP.Name = "lblTongSoSP";
            this.lblTongSoSP.Size = new System.Drawing.Size(118, 17);
            this.lblTongSoSP.Text = "Tổng số sản phẩm: 0";

            this.tableLayoutPanelMain.ColumnCount = 2;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanelMain.Controls.Add(this.pnlTrai, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.pnlPhai, 1, 0);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 1;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(984, 515);
            this.tableLayoutPanelMain.TabIndex = 2;

            this.pnlTrai.Controls.Add(this.grpNhapLieu);
            this.pnlTrai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTrai.Location = new System.Drawing.Point(3, 3);
            this.pnlTrai.Name = "pnlTrai";
            this.pnlTrai.Size = new System.Drawing.Size(338, 509);
            this.pnlTrai.TabIndex = 0;

            this.grpNhapLieu.Controls.Add(this.lblMaSP);
            this.grpNhapLieu.Controls.Add(this.txtProductId);
            this.grpNhapLieu.Controls.Add(this.lblTenSP);
            this.grpNhapLieu.Controls.Add(this.txtProductName);
            this.grpNhapLieu.Controls.Add(this.lblDanhMuc);
            this.grpNhapLieu.Controls.Add(this.cboCategory);
            this.grpNhapLieu.Controls.Add(this.lblDonGia);
            this.grpNhapLieu.Controls.Add(this.txtUnitPrice);
            this.grpNhapLieu.Controls.Add(this.lblSoLuong);
            this.grpNhapLieu.Controls.Add(this.txtQuantity);
            this.grpNhapLieu.Controls.Add(this.lblAnh);
            this.grpNhapLieu.Controls.Add(this.picAvatar);
            this.grpNhapLieu.Controls.Add(this.btnChooseImage);
            this.grpNhapLieu.Controls.Add(this.btnAdd);
            this.grpNhapLieu.Controls.Add(this.btnUpdate);
            this.grpNhapLieu.Controls.Add(this.btnDelete);
            this.grpNhapLieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpNhapLieu.Location = new System.Drawing.Point(0, 0);
            this.grpNhapLieu.Name = "grpNhapLieu";
            this.grpNhapLieu.Size = new System.Drawing.Size(338, 509);
            this.grpNhapLieu.TabIndex = 0;
            this.grpNhapLieu.TabStop = false;
            this.grpNhapLieu.Text = "Khung Nhập Liệu";

            this.lblMaSP.Location = new System.Drawing.Point(12, 25);
            this.lblMaSP.Name = "lblMaSP";
            this.lblMaSP.Size = new System.Drawing.Size(80, 20);
            this.lblMaSP.Text = "Mã SP:";

            this.txtProductId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProductId.Location = new System.Drawing.Point(98, 22);
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.Size = new System.Drawing.Size(210, 20);

            this.lblTenSP.Location = new System.Drawing.Point(12, 55);
            this.lblTenSP.Name = "lblTenSP";
            this.lblTenSP.Size = new System.Drawing.Size(80, 20);
            this.lblTenSP.Text = "Tên SP:";

            this.txtProductName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProductName.Location = new System.Drawing.Point(98, 52);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(210, 20);

            this.lblDanhMuc.Location = new System.Drawing.Point(12, 85);
            this.lblDanhMuc.Name = "lblDanhMuc";
            this.lblDanhMuc.Size = new System.Drawing.Size(80, 20);
            this.lblDanhMuc.Text = "Danh mục:";

            this.cboCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategory.Location = new System.Drawing.Point(98, 82);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(210, 21);

            this.lblDonGia.Location = new System.Drawing.Point(12, 115);
            this.lblDonGia.Name = "lblDonGia";
            this.lblDonGia.Size = new System.Drawing.Size(80, 20);
            this.lblDonGia.Text = "Đơn giá:";

            this.txtUnitPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUnitPrice.Location = new System.Drawing.Point(98, 112);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(210, 20);

            this.lblSoLuong.Location = new System.Drawing.Point(12, 145);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(80, 20);
            this.lblSoLuong.Text = "Số lượng:";

            this.txtQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQuantity.Location = new System.Drawing.Point(98, 142);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(210, 20);

            this.lblAnh.Location = new System.Drawing.Point(12, 175);
            this.lblAnh.Name = "lblAnh";
            this.lblAnh.Size = new System.Drawing.Size(80, 20);
            this.lblAnh.Text = "Ảnh đại diện:";

            this.picAvatar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picAvatar.Location = new System.Drawing.Point(98, 175);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(120, 110);
            this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;

            this.btnChooseImage.Location = new System.Drawing.Point(224, 175);
            this.btnChooseImage.Name = "btnChooseImage";
            this.btnChooseImage.Size = new System.Drawing.Size(84, 30);
            this.btnChooseImage.Text = "Chọn Ảnh";
            this.btnChooseImage.Click += new System.EventHandler(this.btnChooseImage_Click);

            this.btnAdd.Location = new System.Drawing.Point(15, 305);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 32);
            this.btnAdd.Text = "Thêm mới";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            this.btnUpdate.Location = new System.Drawing.Point(118, 305);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(90, 32);
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);

            this.btnDelete.Location = new System.Drawing.Point(221, 305);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 32);
            this.btnDelete.Text = "Xóa";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            this.pnlPhai.Controls.Add(this.grpBangDuLieu);
            this.pnlPhai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPhai.Location = new System.Drawing.Point(347, 3);
            this.pnlPhai.Name = "pnlPhai";
            this.pnlPhai.Size = new System.Drawing.Size(634, 509);
            this.pnlPhai.TabIndex = 1;

            this.grpBangDuLieu.Controls.Add(this.lblTimKiem);
            this.grpBangDuLieu.Controls.Add(this.txtSearch);
            this.grpBangDuLieu.Controls.Add(this.dgvProducts);
            this.grpBangDuLieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBangDuLieu.Location = new System.Drawing.Point(0, 0);
            this.grpBangDuLieu.Name = "grpBangDuLieu";
            this.grpBangDuLieu.Size = new System.Drawing.Size(634, 509);
            this.grpBangDuLieu.TabIndex = 0;
            this.grpBangDuLieu.TabStop = false;
            this.grpBangDuLieu.Text = "Bảng Dữ Liệu Sản Phẩm";

            this.lblTimKiem.Location = new System.Drawing.Point(12, 25);
            this.lblTimKiem.Name = "lblTimKiem";
            this.lblTimKiem.Size = new System.Drawing.Size(120, 20);
            this.lblTimKiem.Text = "Tìm kiếm theo tên:";

            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(138, 22);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(480, 20);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);

            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProducts.AutoGenerateColumns = false;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaSP,
            this.colTenSP,
            this.colDanhMuc,
            this.colDonGia,
            this.colSoLuong});
            this.dgvProducts.Location = new System.Drawing.Point(15, 55);
            this.dgvProducts.MultiSelect = false;
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.Size = new System.Drawing.Size(603, 438);
            this.dgvProducts.TabIndex = 2;
            this.dgvProducts.SelectionChanged += new System.EventHandler(this.dgvProducts_SelectionChanged);

            this.colMaSP.DataPropertyName = "MaSP";
            this.colMaSP.HeaderText = "Mã SP";
            this.colMaSP.Name = "colMaSP";
            this.colMaSP.ReadOnly = true;

            this.colTenSP.DataPropertyName = "TenSP";
            this.colTenSP.HeaderText = "Tên SP";
            this.colTenSP.Name = "colTenSP";
            this.colTenSP.ReadOnly = true;
            this.colTenSP.Width = 150;

            this.colDanhMuc.DataPropertyName = "DanhMuc";
            this.colDanhMuc.HeaderText = "Danh Mục";
            this.colDanhMuc.Name = "colDanhMuc";
            this.colDanhMuc.ReadOnly = true;

            this.colDonGia.DataPropertyName = "DonGia";
            this.colDonGia.DefaultCellStyle.Format = "N0";
            this.colDonGia.HeaderText = "Đơn Giá";
            this.colDonGia.Name = "colDonGia";
            this.colDonGia.ReadOnly = true;

            this.colSoLuong.DataPropertyName = "SoLuong";
            this.colSoLuong.HeaderText = "Số Lượng";
            this.colSoLuong.Name = "colSoLuong";
            this.colSoLuong.ReadOnly = true;

            this.errorProvider1.ContainerControl = this;

            this.openFileDialogImage.Filter = "Tệp hình ảnh|*.png;*.jpg;*.jpeg;*.bmp;*.gif|Tất cả tệp|*.*";

            this.saveFileDialogCsv.DefaultExt = "csv";
            this.saveFileDialogCsv.Filter = "Tệp CSV (*.csv)|*.csv|Tất cả tệp (*.*)|*.*";

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.Controls.Add(this.statusStripMain);
            this.Controls.Add(this.menuStripMain);
            this.MainMenuStrip = this.menuStripMain;
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Danh Mục Thiết Bị Công Nghệ (TechMart)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.statusStripMain.ResumeLayout(false);
            this.statusStripMain.PerformLayout();
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.pnlTrai.ResumeLayout(false);
            this.grpNhapLieu.ResumeLayout(false);
            this.grpNhapLieu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.pnlPhai.ResumeLayout(false);
            this.grpBangDuLieu.ResumeLayout(false);
            this.grpBangDuLieu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem menuHeThong;
        private System.Windows.Forms.ToolStripMenuItem menuXuatCsv;
        private System.Windows.Forms.ToolStripMenuItem menuThoat;
        private System.Windows.Forms.StatusStrip statusStripMain;
        private System.Windows.Forms.ToolStripStatusLabel lblTongSoSP;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.Panel pnlTrai;
        private System.Windows.Forms.GroupBox grpNhapLieu;
        private System.Windows.Forms.Label lblMaSP;
        private System.Windows.Forms.TextBox txtProductId;
        private System.Windows.Forms.Label lblTenSP;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lblDanhMuc;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.Label lblDonGia;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblAnh;
        private System.Windows.Forms.PictureBox picAvatar;
        private System.Windows.Forms.Button btnChooseImage;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel pnlPhai;
        private System.Windows.Forms.GroupBox grpBangDuLieu;
        private System.Windows.Forms.Label lblTimKiem;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDanhMuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuong;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.OpenFileDialog openFileDialogImage;
        private System.Windows.Forms.SaveFileDialog saveFileDialogCsv;
    }
}