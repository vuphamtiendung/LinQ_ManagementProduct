using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FinalExcercise03
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        /* Setup Function */
        /* Input Output */
        List<Product> listProduct = new List<Product>();

        public void InputData()
        {
            try
            {
                Product product = new Product()
                {
                    productCode = Convert.ToDouble(txtProductCode.Text),
                    productName = txtProductName.Text,
                    productAmount = Convert.ToDouble(txtProductAmount.Text),
                    productCost = Convert.ToDouble(txtProductCost.Text),
                    productOrigin = txtProductOrigin.Text,
                    productOutOfDate = Convert.ToDateTime(dtpProductOutOfDate.Text)
                };
                double checkCode = Convert.ToDouble(txtProductCode.Text);
                var check = listProduct.Exists(x => x.productCode == checkCode);
                if (check == true)
                {
                    MessageBox.Show("Key này đã có trong hệ thống");
                }
                else
                {
                    listProduct.Add(product);
                }
            }
            catch(Exception ex)
            {
                txtProductCode.Clear();
                txtProductName.Clear();
                txtProductAmount.Clear();
                txtProductCost.Clear();
                txtProductOrigin.Clear();
            }
        }

        public void ShowData()
        {
            lsvProduct.Items.Clear();
            listProduct.ForEach(x =>
            {
                ListViewItem item = new ListViewItem(x.productCode + "");
                item.SubItems.Add(x.productName);
                item.SubItems.Add(x.productAmount + "");
                item.SubItems.Add(x.productCost + "");
                item.SubItems.Add(x.productOrigin);
                item.SubItems.Add(x.productOutOfDate + "");
                lsvProduct.Items.Add(item);
            });
        }

        /* Delete block code */

        public void DeleteAt()
        {
            if(lsvProduct.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Bạn chưa chọn dữ liệu nào.");
                return;
            }
            int position = lsvProduct.SelectedIndices[0];
            listProduct.RemoveAt(position);
            ShowData();
        }   

        public void DeleteByName()
        {
            for(int i = listProduct.Count - 1; i>=0; --i)
            {
                string find = txtFindOrigin.Text;
                if (string.Compare(listProduct[i].productOrigin, find, true) == 0)
                {
                    listProduct.RemoveAt(i);
                }
            }
            ShowData();
        }

        public void DeleteAllWareHouse()
        {
            listProduct.Clear();
            ShowData();
        }

        public void DeleteOutOfDate()
        {
            listProduct.RemoveAll(x => x.productOutOfDate.Date < DateTime.Now.Date);
            ShowData();
        }

        /* Check block code */
        
        public void Check()
        {
            bool check = listProduct.Exists(x => x.productOutOfDate.Date < DateTime.Now.Date);
            if(check == false)
            {
                MessageBox.Show("Không có sản phẩm nào hết hạn");
            }
            else
            {
                MessageBox.Show("Có sản phẩm hết hạn");
            }
        }

        /* Browse the list */

        // MaxCost in listProduct
        public void MaxCost()
        {
            lsvTask.Items.Clear();
            try
            {
                double max = listProduct.Max(x => x.productCost);
                var list = from i in listProduct
                           where i.productCost == max
                           select i;
                list.ToList().ForEach(x =>
                {
                    ListViewItem item = new ListViewItem(x.productCode + "");
                    item.SubItems.Add(x.productName);
                    item.SubItems.Add(x.productAmount + "");
                    item.SubItems.Add(x.productCost + "");
                    item.SubItems.Add(x.productOrigin);
                    item.SubItems.Add(x.productOutOfDate + "");
                    lsvTask.Items.Add(item);
                });
            }
            catch(Exception ex)
            {
                MessageBox.Show("Thông tin về lỗi, chi tiết: " + ex.Message);
            }
            
        }

        // Product from Japan
        public void ProductFromJapan()
        {
            lsvTask.Items.Clear();
            List<Product> list = listProduct.FindAll(x => x.productOrigin == "Nhật Bản" || x.productOrigin == "Nhật bản"
            || x.productOrigin == "Nhật" || x.productOrigin == "nhật" || x.productOrigin == "Japan" || x.productOrigin == "japan");
            list.ToList().ForEach(x =>
            {
                ListViewItem item = new ListViewItem(x.productCode + "");
                item.SubItems.Add(x.productName);
                item.SubItems.Add(x.productAmount + "");
                item.SubItems.Add(x.productCost + "");
                item.SubItems.Add(x.productOrigin);
                item.SubItems.Add(x.productOutOfDate + "");
                lsvTask.Items.Add(item);
            });
        }

        // product Out of Date
        public void ProductOD()
        {
            List<Product> list = listProduct.FindAll(x => x.productOutOfDate.Date < DateTime.Now.Date); lsvTask.Items.Clear();
            lsvTask.Items.Clear();
            list.ToList().ForEach(x =>
            {
                ListViewItem item = new ListViewItem(x.productCode + "");
                item.SubItems.Add(x.productName);
                item.SubItems.Add(x.productAmount + "");
                item.SubItems.Add(x.productCost + "");
                item.SubItems.Add(x.productOrigin);
                item.SubItems.Add(x.productOutOfDate + "");
                lsvTask.Items.Add(item);
            });
        }

        //product have cost from A to B
        public void ProductFilterCost()
        {
            try
            {
                if (txtCostFrom.Text == "" || txtCostTo.Text == "")
                {
                    MessageBox.Show("Bạn đang để trống giá cần lọc");
                }
                double costFrom = Convert.ToDouble(txtCostFrom);
                double costTo = Convert.ToDouble(txtCostTo);
                var list = listProduct.FindAll(x => x.productCost >= costFrom && x.productCost <= costTo);
                lsvTask.Items.Clear();
                list.ToList().ForEach(x =>
                {
                    ListViewItem item = new ListViewItem(x.productCode + "");
                    item.SubItems.Add(x.productName);
                    item.SubItems.Add(x.productAmount + "");
                    item.SubItems.Add(x.productCost + "");
                    item.SubItems.Add(x.productOrigin);
                    item.SubItems.Add(x.productOutOfDate + "");
                    lsvTask.Items.Add(item);
                });
            }
            catch(Exception ex)
            {
                MessageBox.Show("Bạn nhập sai định dạng vùng giá cần lọc, chi tiết: " + ex.Message);
            }
            
        }

        /* Statement */
        private void sbtnAdd_Click(object sender, EventArgs e)
        {
            InputData();
            ShowData();
        }

        private void sbtnRemoveProduct_Click(object sender, EventArgs e)
        {
            DeleteAt();
        }

        private void sbtnRemove_Click(object sender, EventArgs e)
        {
            DeleteByName();
        }

        private void sbtnProductOutOfDate_Click(object sender, EventArgs e)
        {
            Check();
        }

        private void sbtnRemoveAll_Click(object sender, EventArgs e)
        {
            DeleteAllWareHouse();
        }

        private void sbtnRemoveOutOfDate_Click(object sender, EventArgs e)
        {
            DeleteOutOfDate();
        }

        private void sbtnMaxScost_Click(object sender, EventArgs e)
        {
            MaxCost();
        }

        private void sbtnProductJapanese_Click(object sender, EventArgs e)
        {
            ProductFromJapan();
        }

        private void sbtnOutOfDate_Click(object sender, EventArgs e)
        {
            ProductOD();
        }

        private void sbtnCostFromTo_Click(object sender, EventArgs e)
        {
            ProductFilterCost();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
