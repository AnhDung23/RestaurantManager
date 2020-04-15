using BUS_QuanLy;
using DTO_QuanLy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QuanLy
{
    public partial class fQuanLy : Form
    {
        TableFoodBUS busTable = new TableFoodBUS();
        BillBUS busBill = new BillBUS();
        BillInfoBUS busBillInfo = new BillInfoBUS();
        CategoryBUS busCate = new CategoryBUS();
        FoodBUS busFood = new FoodBUS();
        AccountDTO accountLogin;
        public fQuanLy(AccountDTO account)
        {
            accountLogin = account;
            InitializeComponent();
            LoadTable();
            LoadCategory();
            if (account.Role.Equals("member"))
            {
                adminToolStripMenuItem.Enabled = false;
            }
        }

        private void LoadTable()
        {          
            List<TableFoodDTO> listTable = busTable.LoadAllTable();
            foreach (TableFoodDTO dto in listTable)
            {
                Button btn = new Button() { Width = 80, Height = 80 };
                btn.Text = dto.Name + "\n" + dto.Status;

                btn.Click += btn_Click;
                btn.Tag = dto;
                if (dto.Status.Equals("Trống"))
                {
                    btn.BackColor = Color.Aqua;
                }
                else if (dto.Status.Equals("Có người"))
                {
                    btn.BackColor = Color.Pink;
                }

                flpTable.Controls.Add(btn);
            }

        }

        private void LoadCategory()
        {
            List<CategoryDTO> listCate = busCate.getListCategory();
            cbxCategory.DataSource = listCate;
            cbxCategory.DisplayMember = "name";
        }

        private void LoadListFoodByCateID(int idCate)
        {
            List<FoodDTO> listFood = busFood.getListFoodByCateID(idCate);
            cbxFood.DataSource = listFood;
            cbxFood.DisplayMember = "name";
        }

        private void ShowBillInfo(string nameTable, int idBill)
        {
            int totalBill = 0;
            lsvBill.Items.Clear();
            List<BillInfoDTO> list = busBillInfo.getListBillInfoByIdBill(idBill);
            foreach(BillInfoDTO dto in list)
            {
                ListViewItem lsvItem = new ListViewItem(dto.NameFood);               
                lsvItem.SubItems.Add(dto.Quantity.ToString());

                FoodDTO dtoFood = busFood.getFoodByName(dto.NameFood);
                lsvItem.SubItems.Add(dtoFood.Price.ToString());
                lsvItem.SubItems.Add((dto.Quantity * dtoFood.Price).ToString());
                totalBill += dto.Quantity * dtoFood.Price;
                lsvBill.Items.Add(lsvItem);
            }
            txtTotalBill.Text = totalBill.ToString();
        }
        private void btn_Click(object sender, EventArgs e)
        {
            string nameTable = ((sender as Button).Tag as TableFoodDTO).Name;
            lsvBill.Tag = (sender as Button).Tag;
            int idBill = busBill.getBillUnCheckoutByNameTable(nameTable);
            ShowBillInfo(nameTable, idBill);
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAccountProfile f = new fAccountProfile(accountLogin);
            f.ShowDialog();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAdmin f = new fAdmin();
            f.ShowDialog();
            LoadCategory();
            flpTable.Controls.Clear();
            LoadTable();
        }

        private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;
            ComboBox cb = sender as ComboBox;

            CategoryDTO cateSelected = cb.SelectedItem as CategoryDTO;
            id = cateSelected.Id;

            LoadListFoodByCateID(id);
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            TableFoodDTO table = lsvBill.Tag as TableFoodDTO;
            string food = cbxFood.Text;
            int quantity = Convert.ToInt32(nudQuantity.Value);

            if (table == null)
            {
                MessageBox.Show("Bạn chưa chọn bàn");
            }
            else
            {
                int idBill = busBillInfo.insertBillInfo(table, food, quantity);
                if(idBill == -1)
                {
                    MessageBox.Show("Lỗi");
                } else
                {
                    flpTable.Controls.Clear();
                    LoadTable();
                    ShowBillInfo(table.Name, idBill);
                }
            }
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            bool check = false;
            TableFoodDTO table = lsvBill.Tag as TableFoodDTO;
            if (table == null)
            {
                MessageBox.Show("Bạn chưa chọn bàn");
            }
            else
            {
                if (MessageBox.Show("Xác nhận thanh toán " + table.Name, "Thông báo", MessageBoxButtons.OKCancel)
                    == System.Windows.Forms.DialogResult.OK)
                {
                    string staff = accountLogin.Username;
                    int total = Convert.ToInt32(txtTotalBill.Text);
                    check = busBill.checkoutBill(table, staff, total);
                    if (check)
                    {
                        MessageBox.Show("Thanh toán thành công");
                        flpTable.Controls.Clear();
                        LoadTable();
                        lsvBill.Items.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Lỗi");
                    }
                }
            }           
        }
    }
}
