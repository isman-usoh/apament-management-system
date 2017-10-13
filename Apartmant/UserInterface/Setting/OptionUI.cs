using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.Common;
using System.IO;
using System.Globalization;
using Apartmant.Database;

namespace Apartmant.UserInterface.Setting
{
    public partial class OptionUI : Form
    {
        private Boolean isCheck = true;
        private Boolean isChecKDB = false;
        private Boolean isChangeFormat = true;

        private String StringFormat = @"{0} {1} {2} {3}Integrated Security={4};Connect Timeout=30;User Instance=True;";
        private String connectionString = "";
        private String username;
        private String password;
        private String instance;
        private String databasename;


        public OptionUI()
        {
            InitializeComponent();
        }

        private void cbxInstance_DropDown(object sender, EventArgs e)
        {
            this.Cursor = Cursors.AppStarting;
            if (cbxInstance.Items.Count == 0 && !isCheck)
            {
                loadServerInstance();
            }
            else if(isCheck)
            {
                loadServerInstance();
                isCheck = false;
            }
            this.Cursor = Cursors.Default;
        }

        private void loadServerInstance()
        {
            List<String> instance = SQLServerHelper.EnumerateServers();
            if (instance != null)
            {
                cbxInstance.Items.Clear();
                cbxInstance.Items.AddRange(instance.ToArray());
                isChecKDB = true;
                cbxFile.Text = "";
                cbxFile.Enabled = true;
                btnBrowserFile.Enabled = true;
            }
            else
            {
                cbxFile.Enabled = false;
                btnBrowserFile.Enabled = false;
            }
        }

        private void btnBrowserFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyComputer);
            openFileDialog1.Filter = "SQL Database File (*.mdf)|*.mdf";
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                cbxFile.Text = openFileDialog1.FileName;
        }

        private void btnConnectTest_Click(object sender, EventArgs e)
        {
            sqlSettingPanel.Enabled = false;
            try
            {
                string provider = "System.Data.SqlClient";
                DbProviderFactory factory = DbProviderFactories.GetFactory(provider);
                using (DbConnection conn = factory.CreateConnection())
                {
                    conn.ConnectionString = getConnectionString();
                    conn.Open();
                    connectionString = conn.ConnectionString;
                    conn.Close();
                    isChecKDB = true;
                    MessageBox.Show("Test connection succeeded.", "Apartment Manage System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cbxFile.Enabled = true;
                    username = tbxUsername.Text;
                    password = tbxPassword.Text;
                    instance = cbxInstance.Text;
                    databasename = cbxFile.Text;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbxFile.Enabled = false;
            }
            finally
            {
                sqlSettingPanel.Enabled = true;
            }

            ApartmentDataSet sd = new ApartmentDataSet();
        }

        private String getConnectionString()
        {
            String con = "";
            String Username = tbxUsername.Text;
            String Password = tbxUsername.Text;
            String Security = "TRUE";
            if (rdoSQL.Checked)
            {
                Username = "UID" + Username + ";";
                Password = "PID" + Password + ";";
                Security = "FALSE";
            }

            if (File.Exists(cbxFile.Text))
            {
                con  = String.Format(StringFormat, "Data Source=" + cbxInstance.Text + ";", "AttachDbFilename=" + cbxFile.Text + ";", tbxUsername.Text, tbxPassword.Text, Security);
            }
            else
            {
                con = String.Format(StringFormat, "Data Source=" + cbxInstance.Text + ";", "Initial Catalog=" + cbxFile.Text + ";", tbxUsername.Text, tbxPassword.Text, Security);
            }
            return con;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Apartmant.Properties.Settings.Default.ciTime = cbxTime.Text;
            Apartmant.Properties.Settings.Default.ConnectionString = connectionString;
            Apartmant.Properties.Settings.Default.DateFormat = cbxFormat.SelectedValue.ToString();
            Apartmant.Properties.Settings.Default.Save();


            CultureInfo cultureInfo = System.Globalization.CultureInfo.GetCultureInfo(Apartmant.Properties.Settings.Default.DateFormat);
            System.Threading.Thread.CurrentThread.CurrentCulture = cultureInfo;
            System.Threading.Thread.CurrentThread.CurrentUICulture = cultureInfo;
            Application.CurrentCulture = cultureInfo;
            this.Close();
        }

        private void OptionUI_Load(object sender, EventArgs e)
        {
            connectionString = Apartmant.Properties.Settings.Default.ConnectionString;
            username = Apartmant.Properties.Settings.Default.dbUsername;
            password = Apartmant.Properties.Settings.Default.dbPassword;
            instance = Apartmant.Properties.Settings.Default.dbInstance;
            databasename = Apartmant.Properties.Settings.Default.dbName;
            

            if (username.Trim().Length > 0 || password.Trim().Length > 0)
            {
                rdoSQL.Checked = true;
                tbxUsername.Text = username;
                tbxPassword.Text = password;
            }
            cbxInstance.Text = instance;
            cbxFile.Text = databasename;
            cbxFile.Enabled = false;
            btnBrowserFile.Enabled = false;


            Dictionary<string, string> format = new Dictionary<string, string>();
            format.Add("th-TH", "Thai (Thailand)");
            format.Add("en-GB", "English (United Kingdom)");
            format.Add("en-US", "English (United States)");


            cbxFormat.DataSource = format.ToList();
            cbxFormat.ValueMember = "Key";
            cbxFormat.DisplayMember = "Value";
            cbxFormat.SelectedValue = Apartmant.Properties.Settings.Default.DateFormat;
            cbxTime.SelectedItem = Apartmant.Properties.Settings.Default.ciTime;
            CheckOptionAuthen();
        }

        private void CheckOptionAuthen()
        {
            if (rdoSQL.Checked)
            {
                tbxPassword.Enabled = true;
                tbxUsername.Enabled = true;
            }
            if (rdoWin.Checked)
            {
                tbxPassword.Enabled = false;
                tbxPassword.Text = "";
                tbxUsername.Enabled = false;
                tbxUsername.Text = "";
            }
        }

        private void rdo_CheckedChanged(object sender, EventArgs e)
        {
            CheckOptionAuthen();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbxFile_DropDown(object sender, EventArgs e)
        {
            this.Cursor = Cursors.AppStarting;
            if (cbxInstance.Text.Trim().Length <= 0)
            {
                MessageBox.Show("กรุณาเลือก SQL Instance ", "ข้อผิดผลาด", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (isChecKDB)
                {
                    List<String> list = SQLServerHelper.EnumerateDatabases(getConnectionString());
                    if (list != null)
                    {
                        cbxFile.Items.Clear();
                        cbxFile.Items.AddRange(list.ToArray());
                    }
                    isChecKDB = false;
                }
            }
            this.Cursor = Cursors.Default;
        }

        private void cbxFormat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isChangeFormat)
            {
                if (!DialogResult.Yes.Equals(MessageBox.Show("การเปลี่ยนแปลง Data Format อาจจะผลต่อข้อมลเก่าได้, คุณยังต้องการเปลี่ยนอีกหรือไม่", "ข้อควรระวัง", MessageBoxButtons.YesNo, MessageBoxIcon.Information)))
                {
                    cbxFormat.SelectedValue = Apartmant.Properties.Settings.Default.DateFormat;
                }
            }
        }
    }
    
    public static class SQLServerHelper
    {
        public static List<String> EnumerateServers()
        {
            var instances = SqlDataSourceEnumerator.Instance.GetDataSources();
            if ((instances == null) || (instances.Rows.Count < 1)) return null;

            var result = new List<String>();
            foreach (DataRow instance in instances.Rows)
            {
                var serverName = instance["ServerName"].ToString();
                var instanceName = instance["InstanceName"].ToString();
                result.Add(String.IsNullOrEmpty(instanceName) ? serverName : String.Format(@"{0}\{1}", serverName, instanceName));
            }
            return result;
        }

        public static List<String> EnumerateDatabases(String connectionString)
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    var databases = connection.GetSchema("Databases");
                    connection.Close();
                    if ((databases == null) || (databases.Rows.Count < 1)) return null;

                    var result = new List<String>();
                    foreach (DataRow database in databases.Rows)
                    {
                        result.Add(database["database_name"].ToString());
                    }
                    return result;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }
    }
}
