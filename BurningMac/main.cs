using SQLiteMACW;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net;
using System.Threading.Tasks;

namespace BurningMac
{
    public partial class main : Form
    {

        public main()
        {
            InitializeComponent();

            // 初始化显示MAC的listview
            initMACListView();

            // 初始化显示的当前的MAC
            initCurrentMACLable();

            // SystemConfig.parserConfig("configs/SystemConfig.json");
            SystemConfig.parserConfig("configs/system_config.json");
        }

        // 从数据库中获取第一行中的MAC 
        private void initCurrentMACLable()
        {
            // 这里可以从DB中获取第一行，也可通过直接获取ListView中的第一行来表示.
            String mac = MACSQLite.fetchHeadMac("macs");
            if (mac != null && mac.Length != 0)
            {
                currentMAC.Text = mac;
            }
            else
            {
                currentMAC.Text = "00:00:00:00:00:00";
            }
        }

        // 初始化ListView
        private void initMACListView()
        {
            macLV.GridLines = true;     // 表格是否显示网格线
            macLV.FullRowSelect = true; // 是否选中整行

            macLV.View = View.Details;  // 设置显示方式
            macLV.Scrollable = true;    // 是否自动显示滚动条
            macLV.MultiSelect = false;  // 是否可以选择多行

            // 添加表头（列）
            macLV.Columns.Add("ID", -2, HorizontalAlignment.Center);
            macLV.Columns.Add("MAC", -2, HorizontalAlignment.Center);

            MACSQLite.createTable("macs");
            refreshListView();
        }

        // 从数据库中获取所有的MAC，并将MAC在ListView中显示
        private void refreshListView()
        {

            // 清空ListView
            macLV.Items.Clear();

            MACSQLite.queryMacs("macs");
            List<DBIdMAC> macsDB = MACSQLite.macsDB;

            // 添加表格内容
            int count = MACSQLite.queryCount("macs");
            for (int i = 0; i < count; i++)
            {
                ListViewItem item = new ListViewItem();
                item.SubItems.Clear();

                item.SubItems[0].Text = macsDB[i].getId().ToString();
                item.SubItems.Add(macsDB[i].getMac());
                macLV.Items.Add(item);
            }

            // 选中listview第一行，这里会造成自动调用listview的SelectedIndexChanged事件函数；
            // 于是设置当前MAC、QRCode这事情都在macLV_SelectedIndexChanged处理了。
            // initCurrentMACLable()也就没啥用了。
            if (macLV.Items.Count > 0)
            {
                macLV.Items[0].Selected = true;
                macLV.Select();
            }
            // initCurrentMACLable();
        }

        private void addMACClick(object sender, EventArgs e)
        {
            // 校验MAC地址
            string s = @"^([0-9a-fA-F]{2})(([/\s:-][0-9a-fA-F]{2}){5})$";
            Regex r = new Regex(s, RegexOptions.IgnoreCase);
            Match mB = r.Match(macB.Text.Trim());
            Match mE = r.Match(macE.Text.Trim());
            if (!mB.Success || !mE.Success)
            {
                MessageBox.Show("Please Check Your MAC Address.");
                return;
            }

            MACSQLite.generateMacs(macB.Text, macE.Text);
            // MACSQLite.printMacs();

            MACSQLite.createTable("macs");
            MACSQLite.addMacs("macs");

            // MACSQLite.insertMac("macs", "00:11:22:33:44:55");
            // MACSQLite.queryMac("macs");
            // MACSQLite.deleteMac("macs", "00:11:22:33:44:55");
            // MACSQLite.updateMac("macs", 18, "11:22:33:44:55:66");

            refreshListView();
        }

        private void macLV_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 当选择了不同的MAC的时候，对应显示当前选择的MAC和生成对应的QRCode
            if (macLV.SelectedItems.Count > 0)
            {
                currentMAC.Text = ((ListView)sender).SelectedItems[0].SubItems[1].Text;
            }
        }

        private void deleteDB(object sender, EventArgs e)
        {
            Console.WriteLine(currentMAC.Text);
            if (MACSQLite.queryCount("macs") > 0)
            {
                // 删除MAC，并刷新listview
                MACSQLite.deleteMac("macs", currentMAC.Text);
                refreshListView();
            }
            else
            {
                currentMAC.Text = "00:00:00:00:00:00";
            }
        }

        private void cleanAdbCmdShowClick(object sender, EventArgs e)
        {
            // 删除文本内容，并将状态标签颜色设为绿色
            ShowMessage.Text = "";
        }

        private void deleteAllMac_Click(object sender, EventArgs e)
        {
            if (MACSQLite.queryCount("macs") > 0)
            {
                // 删除所：有MAC，并刷新listview
                MACSQLite.deleteAllMac("macs");
                refreshListView();
            }
            else
            {
                currentMAC.Text = "00:00:00:00:00:00";
            }

        }

        private async void HttpWrite_Click(object sender, EventArgs e)
        {
            try
            {
                StringContent stringContent = new StringContent(
                    "{\"categories\":\"MAC\", \"type\": \"set\", \"MAC\":\"" + currentMAC.Text + "\"}", UnicodeEncoding.UTF8, "application/json");
                var handler = new HttpClientHandler() { AutomaticDecompression = DecompressionMethods.None };

                using (var client = new HttpClient(handler))
                {
                    var httpResponseMessage = await client.PostAsync("http://" + IPAddress.Text + ":" + IPPort.Text + "/settings.php", stringContent);
                    if (httpResponseMessage.StatusCode == HttpStatusCode.OK)
                    {
                        // Do something...
                        Console.WriteLine("HttpWrite_Click.");
                        ShowMessage.Text =  await httpResponseMessage.Content.ReadAsStringAsync();
                        Console.WriteLine(httpResponseMessage.ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                
            }

        } 
    }
}
