using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace EasyManage
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            //this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            //this.WindowState = FormWindowState.Maximized;

        }

        DataSet ds;
        SqlDataAdapter da;
        DataTable dt;
        Panel panel_grid, panel_search;
        Bunifu.Framework.UI.BunifuCustomDataGrid bunifuDataGrid;


        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            if (side_menu.Width == 59)
            {
                side_menu.Visible = false;
                side_menu.Width = 207;
                side_menu_transition.ShowSync(side_menu);              
                
            }
            else
            {
                side_menu.Visible = false;
                side_menu.Width = 59;                
                side_menu_transition.ShowSync(side_menu);
                
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //product type drop down
            productTypeDropdown.Items.Add("AIO");
            productTypeDropdown.Items.Add("Desktop");
            productTypeDropdown.Items.Add("Laptop");
            productTypeDropdown.Items.Add("Tablet");
            productTypeDropdown.Items.Add("Phone");
            productTypeDropdown.Items.Add("Router");
            productTypeDropdown.Items.Add("Switch");
            productTypeDropdown.Items.Add("Access Point");
            productTypeDropdown.Items.Add("UPS");
            productTypeDropdown.Items.Add("Storage");
            productTypeDropdown.Items.Add("Monitor");
            //warrenty drop down
            warrentyDropdown.Items.Add("No Warrenty");
            warrentyDropdown.Items.Add("1 Month");
            warrentyDropdown.Items.Add("3 Month");
            warrentyDropdown.Items.Add("6 Month");
            warrentyDropdown.Items.Add("1 Year");
            warrentyDropdown.Items.Add("2 Year");
            warrentyDropdown.Items.Add("3 Year");
            //location drop down
            locationDropdown.Items.Add("JB Office");
            locationDropdown.Items.Add("SG Office");
            locationDropdown.Items.Add("KL Office");
            locationDropdown.Items.Add("NM Office");
            //department drop down
            departmentDropdown.Items.Add("IT");
            departmentDropdown.Items.Add("Account");
            departmentDropdown.Items.Add("Sales");
            departmentDropdown.Items.Add("MRP");
            departmentDropdown.Items.Add("Quality");
            departmentDropdown.Items.Add("Store");
            departmentDropdown.Items.Add("Packing");
            departmentDropdown.Items.Add("Production");
            departmentDropdown.Items.Add("Purchaseing");
            departmentDropdown.Items.Add("Marketing");
            departmentDropdown.Items.Add("HR/Admin");
            //status drop down
            statusDropdown.Items.Add("Active");
            statusDropdown.Items.Add("Expired");
            statusDropdown.Items.Add("Spoil");
            statusDropdown.Items.Add("Scrap");
            //company drop down
            companyDropdown.Items.Add("MY");
            companyDropdown.Items.Add("SG");
            companyDropdown.Items.Add("IN");
            companyDropdown.Items.Add("ID");
            companyDropdown.Items.Add("TH");

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection();
            try
            {                
                connection.ConnectionString = DbHelper.ConnectionString;
                string sqlQuery = "INSERT INTO InventDetail(VendorId,VendorName,PRFNumber,PONumber,DeliveryDate,ProductType," +
                    "ProductName,Model,SerialNumber,IMEI,Warrenty,WarrentyEnd,Location,Department,[User],Status,Company,Note)" +
                    " VALUES (@VendorId,@VendorName,@PRFNumber,@PONumber,@DeliveryDate,@ProductType,@ProductName,@Model," +
                    " @SerialNumber,@IMEI,@Warrenty,@WarrentyEnd,@Location,@Department,@User,@Status,@Company,@Note)";

                SqlCommand command = new SqlCommand(sqlQuery, connection);
                SqlParameter parmVendorId = new SqlParameter("@VendorId", SqlDbType.VarChar, 50);
                SqlParameter parmVendorName = new SqlParameter("@VendorName", SqlDbType.VarChar, 50);
                SqlParameter parmPRFNumber = new SqlParameter("@PRFNumber", SqlDbType.VarChar, 50);
                SqlParameter parmPONumber = new SqlParameter("@PONumber", SqlDbType.VarChar, 50);
                SqlParameter parmDeliveryDate = new SqlParameter("@DeliveryDate", SqlDbType.Date);
                SqlParameter parmProductType = new SqlParameter("@ProductType", SqlDbType.VarChar, 50);
                SqlParameter parmProductName = new SqlParameter("@ProductName", SqlDbType.VarChar, 50);
                SqlParameter parmModel = new SqlParameter("@Model", SqlDbType.VarChar, 50);
                SqlParameter parmSerialNumber = new SqlParameter("@SerialNumber", SqlDbType.VarChar, 50);
                SqlParameter parmIMEI = new SqlParameter("@IMEI", SqlDbType.VarChar, 50);
                SqlParameter parmWarrenty = new SqlParameter("@Warrenty", SqlDbType.VarChar, 50);
                SqlParameter parmWarrentyEnd = new SqlParameter("@WarrentyEnd", SqlDbType.Date);
                SqlParameter parmLocation = new SqlParameter("@Location", SqlDbType.VarChar, 50);
                SqlParameter parmDepartment = new SqlParameter("@Department", SqlDbType.VarChar, 50);
                SqlParameter parmUser = new SqlParameter("@User", SqlDbType.VarChar, 50);
                SqlParameter parmStatus = new SqlParameter("@Status", SqlDbType.VarChar, 50);
                SqlParameter parmCompany = new SqlParameter("@Company", SqlDbType.VarChar, 50);
                SqlParameter parmNote = new SqlParameter("@Note", SqlDbType.Text);

                command.Parameters.Add(parmVendorId);
                command.Parameters.Add(parmVendorName);
                command.Parameters.Add(parmPRFNumber);
                command.Parameters.Add(parmPONumber);
                command.Parameters.Add(parmDeliveryDate);
                command.Parameters.Add(parmProductType);
                command.Parameters.Add(parmProductName);
                command.Parameters.Add(parmModel);
                command.Parameters.Add(parmSerialNumber);
                command.Parameters.Add(parmIMEI);
                command.Parameters.Add(parmWarrenty);
                command.Parameters.Add(parmWarrentyEnd);
                command.Parameters.Add(parmLocation);
                command.Parameters.Add(parmDepartment);
                command.Parameters.Add(parmUser);
                command.Parameters.Add(parmStatus);
                command.Parameters.Add(parmCompany);
                command.Parameters.Add(parmNote);

                parmVendorId.Value = txt_vendorId.Text;
                parmVendorName.Value = txt_vendorName.Text;
                parmPRFNumber.Value = txt_PRFNumber.Text;
                parmPONumber.Value = txt_PONumber.Text;
                parmDeliveryDate.Value = deliveryDatepicker.Value;
                parmProductType.Value = productTypeDropdown.selectedValue;
                parmProductName.Value = txt_productName.Text;
                parmModel.Value = txt_model.Text;
                parmSerialNumber.Value = txt_serialNumber.Text;
                parmIMEI.Value = txt_IMEI.Text;
                parmWarrenty.Value = warrentyDropdown.selectedValue;
                parmWarrentyEnd.Value = warrentyEndDatepicker.Value;
                parmLocation.Value = locationDropdown.selectedValue;
                parmDepartment.Value = departmentDropdown.selectedValue;
                parmUser.Value = txt_user.Text;
                parmStatus.Value = statusDropdown.selectedValue;
                parmCompany.Value = companyDropdown.selectedValue;
                parmNote.Value = txt_note.Text;

                connection.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("New record Created");

            }
            catch (Exception er)
            {

                MessageBox.Show(er.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }

            }
            
        }

        private void CheckConnection()
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = DbHelper.ConnectionString;
            try
            {
                connection.Open();
                MessageBox.Show("Open");
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message); ;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        private void menu_grid_Click(object sender, EventArgs e)
        {
            main_panel.Hide();

            panel_search = new Panel();
            panel_search.Size = new Size(1133, 50);
            panel_search.Location = new Point(207, 47);
            panel_search.BorderStyle = BorderStyle.Fixed3D;
            //panel_grid.Anchor = AnchorStyles.Top;
            //panel_grid.Anchor = AnchorStyles.Left;
            //panel_grid.AutoSize = false;
            panel_search.Dock = DockStyle.Fill;

            panel_grid = new Panel();
            panel_grid.Size = new Size(1133, 733);           
            panel_grid.Location = new Point(207, 47);
            panel_grid.BorderStyle = BorderStyle.Fixed3D;
            panel_grid.Anchor = (AnchorStyles.Left | AnchorStyles.Right);
            //panel_grid.Anchor = AnchorStyles.Top;
            //panel_grid.Anchor = AnchorStyles.Left;
            //panel_grid.AutoSize = false;
            panel_grid.Dock = DockStyle.Fill;

            Bunifu.Framework.UI.BunifuMetroTextbox txt_search = new Bunifu.Framework.UI.BunifuMetroTextbox();
            txt_search.Location = new Point(4,10);
            txt_search.AutoSize = true;
            txt_search.BorderStyle = BorderStyle.None;
            txt_search.Anchor = (AnchorStyles.Top | AnchorStyles.Left );


            bunifuDataGrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            //bunifuDataGrid.AutoSize = true;
            //bunifuDataGrid.Res
            bunifuDataGrid.Size = new Size(1800, 350);
            bunifuDataGrid.Location = new Point(4, 70);
            bunifuDataGrid.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);          
            bunifuDataGrid.RowHeadersVisible = true;
            bunifuDataGrid.HeaderForeColor = Color.White;
            bunifuDataGrid.Font = new Font(bunifuDataGrid.Font.FontFamily, 11);
            bunifuDataGrid.Dock = DockStyle.Fill;

            this.Controls.Add(panel_search);
            this.Controls.Add(panel_grid);
            panel_search.Controls.Add(txt_search);
            panel_grid.Controls.Add(bunifuDataGrid);
            panel_search.BringToFront();
            panel_grid.BringToFront();

            //set grid view data from database
            ds = new DataSet();
            da = new SqlDataAdapter("Select *  from InventDetail", DbHelper.ConnectionString);
            da.Fill(ds, "InventDetail");
            dt = ds.Tables["InventDetail"];
            bunifuDataGrid.DataSource = dt;
            
            //add gridview cell clickevent

            bunifuDataGrid.CellDoubleClick += new DataGridViewCellEventHandler(bunifuDataGrid_CellDoubleClick);

        }

        private void menu_add_Click(object sender, EventArgs e)
        {
            main_panel.Show();
            main_panel.BringToFront();
            if (panel_grid != null)
            {
                panel_grid.SendToBack();
            }
           
        }

        private void bunifuDataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //grid cell double click

            DataGridViewRow row = bunifuDataGrid.Rows[e.RowIndex];
            string msg = row.Cells["id"].Value.ToString() + row.Cells["SerialNumber"].Value.ToString();
            MessageBox.Show(e.RowIndex.ToString() + "-" + msg);
            
        }

        private void btn_maximize_Click(object sender, EventArgs e)
        {
            //maximize or mormal form size base on current state
            if (this.WindowState.ToString() == "Maximized")
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
                this.WindowState = FormWindowState.Maximized;
            }
            
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            // minimize the window
            this.WindowState = FormWindowState.Minimized;
        }

        private void warrentyDropdown_onItemSelected(object sender, EventArgs e)
        {
            /*
             * this will calculate the warrenty date for us 
             * 
             * */
            DateTime warrentyStartDate = deliveryDatepicker.Value;
            
            string value = warrentyDropdown.selectedValue;
            if (value == "1 Month")
            {
                DateTime warrentyEndDate = warrentyStartDate.AddMonths(1);
                warrentyEndDatepicker.Value = warrentyEndDate;
            }
            else if (value == "3 Month")
            {
                DateTime warrentyEndDate = warrentyStartDate.AddMonths(3);
                warrentyEndDatepicker.Value = warrentyEndDate;
            }
            else if (value == "6 Month")
            {
                DateTime warrentyEndDate = warrentyStartDate.AddMonths(6);
                warrentyEndDatepicker.Value = warrentyEndDate;
            }
            else if (value == "1 Year")
            {
                DateTime warrentyEndDate = warrentyStartDate.AddYears(1);
                warrentyEndDatepicker.Value = warrentyEndDate;
            }
            else if (value == "2 Year")
            {
                DateTime warrentyEndDate = warrentyStartDate.AddYears(2);
                warrentyEndDatepicker.Value = warrentyEndDate;
            }
            else if (value == "3 Year")
            {
                DateTime warrentyEndDate = warrentyStartDate.AddYears(3);
                warrentyEndDatepicker.Value = warrentyEndDate;
            }
            
        }

        private void dgv_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            

        }
    }
}
