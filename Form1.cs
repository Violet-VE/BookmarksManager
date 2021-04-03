using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.Xml;

namespace BookmarksManager
{
    public partial class Form_BookMarksManager : Form
    {
        DataTable table = new DataTable();
        public Form_BookMarksManager()
        {
            InitializeComponent();
            //初始化表并绑定，因为如果不绑定手动添加的话清空表比较麻烦
            table.Columns.Add("标题", Type.GetType("System.String"));
            table.Columns.Add("链接", Type.GetType("System.String"));
            view_BookMarks.DataSource = table;
        }

        private void Exit_OnMouseClick(object sender, EventArgs e)
        {
            Application.Exit();//退出
        }

        private void ImportHTML_OnMouseClick(object sender, EventArgs e)
        {
            string openFilePath = string.Empty;//重置为空
            OpenFileDialog openFileWindows = new OpenFileDialog()
            {
                Filter = "Files (*.HTML, *.HTM)|*.HTML;*.HTM"//筛选使用分号
            };
            if (openFileWindows.ShowDialog() == DialogResult.OK) {
                openFilePath = openFileWindows.FileName;//获取文件名，包括完整路径
            }
            table.Clear();//清空表，不然有可能导入时直接加在了后方
            view_BookMarks.DataSource = table;//重新绑定一下，虽然不绑定也可以。保险起见。
            Stream Sbookmarks = new FileStream(openFilePath, FileMode.Open);//把文件加载进输入输出流
            Encoding encode = Encoding.GetEncoding("utf-8");//设置编码
            StreamReader SRbookmarks = new StreamReader(Sbookmarks, encode);//从输入输出流进行读取
            string sbookmarks = SRbookmarks.ReadToEnd();//一直读到流结束
            string urlPattern = "(HREF=\")(.*)(\" ADD.*\">)(.*)(</A>)";//2和4分别是链接和标题，使用edge导出的html测试
            Regex urlRegex = new Regex(urlPattern, RegexOptions.IgnoreCase | RegexOptions.Multiline);//忽略大小写，匹配多行，^和$分别匹配每行的开始和结束
            if (urlRegex.IsMatch(sbookmarks))//匹配返回true
            {
                MatchCollection matchCollection = urlRegex.Matches(sbookmarks);//存储匹配结果
                foreach (Match match in matchCollection)//循环结果
                {
                    table.Rows.Add(match.Groups[4].Value, match.Groups[2].Value);//把值插入表，因为数据绑定，所以gridview也会同步显示
                }
            }
        }

        private void ExportHTML_OnMouseClick(object sender, EventArgs e)
        {
            MessageBox.Show("该功能正在搭建中...", "404!!", 0);//消息弹窗，第一个内容，第二个标题，第三个按钮样式，0就是MessageBoxButtons.OK
        }

        private void OnMouseClick404(object sender, EventArgs e)
        {
            MessageBox.Show("该功能正在搭建中...","404!!",0);
        }

        private void Warn_OnMouseClick(object sender, EventArgs e)
        {
            MessageBox.Show("目前支持任意的网址导入，包括js\n目前暂不支持导入时分文件夹(还没想好用什么来显示)", "注意事项", MessageBoxButtons.OK);
        }
    }
}
