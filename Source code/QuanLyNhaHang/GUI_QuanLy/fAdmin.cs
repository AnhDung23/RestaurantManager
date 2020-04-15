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
    public partial class fAdmin : Form
    {
        BillBUS busBill = new BillBUS();
        FoodBUS busFood = new FoodBUS();
        CategoryBUS busCate = new CategoryBUS();
        AccountBUS busAccount = new AccountBUS();
        TableFoodBUS busTable = new TableFoodBUS();
        public fAdmin()
        {
            InitializeComponent();
            loadListFood();
            LoadCategory();
            loadListUser();
            loadListCate();
            loadListTable();
            bindingsFood();
            bindingsAccount();
            bindingsCate();
            bindingsTable();
        }

        private void getListBill(DateTime dateFrom, DateTime dateTo)
        {
            dtgvBill.DataSource = busBill.getListBillByDate(dateFrom, dateTo);
            dtgvBill.Columns[0].HeaderText = "ID Bill";
            dtgvBill.Columns[0].Width = 58;
            dtgvBill.Columns[1].HeaderText = "Check In";
            dtgvBill.Columns[1].Width = 128;
            dtgvBill.Columns[2].HeaderText = "Check Out";
            dtgvBill.Columns[2].Width = 128;
            dtgvBill.Columns[3].HeaderText = "Table";
            dtgvBill.Columns[3].Width = 50;
            dtgvBill.Columns[4].HeaderText = "Status";
            dtgvBill.Columns[4].Width = 80;
            dtgvBill.Columns[5].HeaderText = "Staff";
            dtgvBill.Columns[5].Width = 100;
            dtgvBill.Columns[6].HeaderText = "Total";
            dtgvBill.Columns[6].Width = 100;
        }

        private void loadListFood()
        {
            dtgvFood.DataSource = busFood.loadFood();
        }

        private void loadListUser()
        {
            dtgvUser.DataSource = busAccount.loadListUser();
        }

        private void loadListTable()
        {
            dtgvTable.DataSource = busTable.LoadAllTable();
        }

        private void loadListCate()
        {
            dtgvCategory.DataSource = busCate.getListCategory();
        }
        private void searchFoodByName(string valueSearchFood)
        {
            dtgvFood.DataSource = busFood.searchFoodByName(valueSearchFood);
        }
        private void searchUserByName(string valueSearchUser)
        {
            dtgvUser.DataSource = busAccount.searchUserByName(valueSearchUser);
        }
        private void searchTableByName(string valueSearchTable)
        {
            dtgvTable.DataSource = busTable.searchTableByName(valueSearchTable);
        }
        private void LoadCategory()
        {
            List<CategoryDTO> listCate = busCate.getListCategory();
            cbxFoodCategory.DataSource = listCate;
            cbxFoodCategory.DisplayMember = "name";
        }


        private void bindingsFood()
        {
            txtFoodName.DataBindings.Clear();
            txtFoodPrice.DataBindings.Clear();
            cbxFoodCategory.DataBindings.Clear();
            txtFoodName.DataBindings.Add("Text", dtgvFood.DataSource, "Food", true, DataSourceUpdateMode.Never);
            cbxFoodCategory.DataBindings.Add("Text", dtgvFood.DataSource, "Category", true, DataSourceUpdateMode.Never);
            txtFoodPrice.DataBindings.Add("Text", dtgvFood.DataSource, "Price", true, DataSourceUpdateMode.Never);
        }

        private void bindingsAccount()
        {
            txtUser.DataBindings.Clear();
            txtName.DataBindings.Clear();
            txtUser.DataBindings.Add("Text", dtgvUser.DataSource, "username");
            txtName.DataBindings.Add("Text", dtgvUser.DataSource, "fullname");
        }

        private void bindingsCate()
        {
            txtCategoryID.DataBindings.Clear();
            txtCategoryName.DataBindings.Clear();
            txtCategoryID.DataBindings.Add("Text", dtgvCategory.DataSource, "id", true, DataSourceUpdateMode.Never);
            txtCategoryName.DataBindings.Add("Text", dtgvCategory.DataSource, "name", true, DataSourceUpdateMode.Never);
        }

        private void bindingsTable()
        {
            txtTableName.DataBindings.Clear();
            txtTableName.DataBindings.Add("Text", dtgvTable.DataSource, "name", true, DataSourceUpdateMode.Never);
        }
        private void btnViewBill_Click(object sender, EventArgs e)
        {     
            DateTime dateFrom = dtpkFromDate.Value.Date;
            DateTime dateTo = dtpkToDate.Value;
            getListBill(dateFrom, dateTo);           
        }

        private void btnViewFood_Click(object sender, EventArgs e)
        {
            loadListFood();
            bindingsFood();
            txtSearchFood.Text = "";
        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            string nameFood = txtFoodName.Text.Trim();
            string priceTxt = txtFoodPrice.Text.Trim();
            int idCate = (cbxFoodCategory.SelectedItem as CategoryDTO).Id;

            string message = busFood.addFood(nameFood, priceTxt, idCate);
            MessageBox.Show(message);
            if(message.Equals("Thêm món thành công"))
            {
                loadListFood();
                bindingsFood();
            }        
        }

        private void btnDeleteFood_Click(object sender, EventArgs e)
        {
            string nameFood = txtFoodName.Text.Trim();
            string message = busFood.deleteFood(nameFood);
            MessageBox.Show(message);
            if (message.Equals("Xóa món thành công"))
            {
                string searchvalue = txtSearchFood.Text.Trim();
                if (!searchvalue.Equals(""))
                {
                    searchFoodByName(searchvalue);
                } else
                {
                    loadListFood();
                }
                bindingsFood();
            }                      
        }

        private void btnUpdateFood_Click(object sender, EventArgs e)
        {
            string name = dtgvFood.CurrentRow.Cells["Food"].Value.ToString();
            string nameTextBox = txtFoodName.Text.Trim();
            int idCate = (cbxFoodCategory.SelectedItem as CategoryDTO).Id;
            string priceTxt = txtFoodPrice.Text.Trim();
            string message = busFood.updateFood(name, nameTextBox, idCate, priceTxt);
            MessageBox.Show(message);
            if (message.Equals("Cập nhật món thành công"))
            {
                string searchvalue = txtSearchFood.Text.Trim();
                if (!searchvalue.Equals(""))
                {
                    searchFoodByName(searchvalue);
                }
                else
                {
                    loadListFood();
                }
                bindingsFood();
            }
        }

        private void btnSearchFood_Click(object sender, EventArgs e)
        {
            string valueSearchFood = txtSearchFood.Text.Trim();
            if (valueSearchFood.Equals(""))
            {
                MessageBox.Show("Bạn chưa điền thông tin tìm kiếm");
            } else
            {
                searchFoodByName(valueSearchFood);
            }           
            bindingsFood();
        }

        private void btnSearchUser_Click(object sender, EventArgs e)
        {
            string valueSearchUser = txtSearchUser.Text.Trim();
            if (valueSearchUser.Equals(""))
            {
                MessageBox.Show("Bạn chưa điền thông tin tìm kiếm");
            } else
            {
                searchUserByName(valueSearchUser);
            }
            bindingsAccount();
        }

        private void btnViewUser_Click(object sender, EventArgs e)
        {
            loadListUser();
            bindingsAccount();
            txtSearchUser.Text = "";
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            string username = txtUser.Text.Trim();
            string message = busAccount.deleteAccount(username);
            MessageBox.Show(message);
            if (message.Equals("Xóa người dùng thành công"))
            {
                if (!txtSearchUser.Text.Trim().Equals(""))
                {
                    string valueSearchUser = txtSearchUser.Text;
                    searchUserByName(valueSearchUser);
                }
                else
                {
                    loadListUser();
                }
                bindingsAccount();
            }           
        }

        private void btnViewCategory_Click(object sender, EventArgs e)
        {
            loadListCate();
            bindingsCate();
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            string idCateTxt = txtCategoryID.Text.Trim();
            string nameCate = txtCategoryName.Text.Trim();
            string message = busCate.addCate(idCateTxt, nameCate);
            MessageBox.Show(message);
            if(message.Equals("Thêm danh mục thành công"))
            {
                loadListCate();
                bindingsCate();
                LoadCategory();
                bindingsFood();
            }            
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            string idCateTxt = txtCategoryID.Text.Trim();
            string message = busCate.deleteCate(idCateTxt);
            MessageBox.Show(message);
            if(message.Equals("Xóa danh mục thành công"))
            {
                loadListCate();
                bindingsCate();
                LoadCategory();
                loadListFood();
                bindingsFood();
            }          
        }

        private void btnUpdateCategory_Click(object sender, EventArgs e)
        {
            int id = (int) dtgvCategory.CurrentRow.Cells["id"].Value;
            string idTextBox = txtCategoryID.Text.Trim();
            string nameUpdate = txtCategoryName.Text.Trim();
            string message = busCate.updateCate(id, idTextBox, nameUpdate);
            MessageBox.Show(message);
            if(message.Equals("Cập nhật danh mục thành công"))
            {
                loadListCate();
                bindingsCate();
                LoadCategory();
                loadListFood();
                bindingsFood();
            }
        }

        private void btnViewTable_Click(object sender, EventArgs e)
        {
            loadListTable();
            bindingsTable();
            txtSearchTable.Text = "";
        }

        private void btnSearchTable_Click(object sender, EventArgs e)
        {
            string searchValue = txtSearchTable.Text.Trim();
            if (searchValue.Equals(""))
            {
                MessageBox.Show("Bạn chưa điền thông tin tìm kiếm");
            } 
            else
            {
                searchTableByName(searchValue);
            }
            bindingsTable();
        }

        private void btnAddTable_Click(object sender, EventArgs e)
        {
            string nameTable = txtTableName.Text.Trim();
            string message = busTable.addTable(nameTable);
            MessageBox.Show(message);
            if(message.Equals("Thêm bàn ăn thành công"))
            {
                if (!txtSearchTable.Text.Trim().Equals(""))
                {
                    string valueSearch = txtSearchTable.Text.Trim();
                    searchTableByName(valueSearch);
                }
                else
                {
                    loadListTable();
                }
                bindingsTable();
            }
        }

        private void btnDeleteTable_Click(object sender, EventArgs e)
        {
            string nameTable = txtTableName.Text.Trim();
            string message = busTable.deleteTable(nameTable);
            MessageBox.Show(message);
            if(message.Equals("Xóa bàn ăn thành công"))
            {
                if (!txtSearchTable.Text.Trim().Equals(""))
                {
                    string valueSearch = txtSearchTable.Text.Trim();
                    searchTableByName(valueSearch);
                }
                else
                {
                    loadListTable();
                }
                bindingsTable();
            }
        }
    }
}
