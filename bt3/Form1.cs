using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bt3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnaddname_Click(object sender, EventArgs e)
        {
            string lastName = txtlastname.Text.Trim();
            string firstName = txtfirstname.Text.Trim();
            string phone = txtphone.Text.Trim();

            // Kiểm tra xem tất cả các TextBox đã nhập dữ liệu chưa
            if (!string.IsNullOrEmpty(lastName) &&
                !string.IsNullOrEmpty(firstName) &&
                !string.IsNullOrEmpty(phone))
            {
                // Tạo một ListViewItem mới
                ListViewItem item = new ListViewItem(lastName); // Cột 1: Họ
                item.SubItems.Add(firstName);                  // Cột 2: Tên
                item.SubItems.Add(phone);                     // Cột 3: Số điện thoại

                // Thêm item vào listView1
                listView1.Items.Add(item);

                // Xóa dữ liệu trong các TextBox sau khi thêm
                txtlastname.Clear();
                txtfirstname.Clear();
                txtphone.Clear();

                // Trả con trỏ về TextBox đầu tiên
                txtlastname.Focus();
            }
            else
            {
                // Hiển thị thông báo nếu chưa nhập đầy đủ
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
        }

        private void btnaddphone_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0) // Kiểm tra có chọn dòng nào không
            {
                // Lấy dòng được chọn
                ListViewItem selectedItem = listView1.SelectedItems[0];

                // Cập nhật số điện thoại
                selectedItem.SubItems[2].Text = txtphone.Text.Trim(); // Cột Số điện thoại

                MessageBox.Show("Đã cập nhật số điện thoại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng cần cập nhật số điện thoại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnxoaten_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0) // Kiểm tra có chọn dòng nào không
            {
                // Xóa dòng được chọn
                listView1.Items.Remove(listView1.SelectedItems[0]);

                MessageBox.Show("Đã xóa dòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnsuaten_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0) // Kiểm tra có chọn dòng nào không
            {
                // Lấy dòng được chọn
                ListViewItem selectedItem = listView1.SelectedItems[0];

                // Cập nhật dữ liệu từ TextBox
                selectedItem.Text = txtlastname.Text.Trim(); // Cột Họ
                selectedItem.SubItems[1].Text = txtfirstname.Text.Trim(); // Cột Tên

                MessageBox.Show("Đã sửa tên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
