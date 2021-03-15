using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //实例化model层中 userInfo类用于传递数据
        Model.StaffUser staffUser = new Model.StaffUser();

        //实例化BLL层中 userAccess方法衔接用户输入与数据库匹配
        BLL.UserAccess b_userAccess = new BLL.UserAccess();


        private void button1_Click(object sender, EventArgs e)
        {
            //将用户输入的账号密码 赋值给userInfo类 username、psw属性
            staffUser.Id = textBox1.Text.Trim().ToString();
            staffUser.Password = textBox2.Text.Trim().ToString();

            //如果BLL层中 useLogin调用返回记录条数 大于1 则账号密码正确
            if (b_userAccess.userLogin(staffUser) > 0)
            {
                MessageBox.Show("登录成功");
            }
            else
            {
                MessageBox.Show("登录失败");
            }
        }
    }
}
