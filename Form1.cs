using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormAdv32
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void 새창ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 다음찾ㄱ기ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 글꼬ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void 끝내기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 새로만들기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Text = "새로 만들기 메뉴를 선택하였습니다.";
        }

        private void 도움말보기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://support.microsoft.com/ko-kr/windows/%EB%A9%94%EB%AA%A8%EC%9E%A5%EC%9D%98-%EB%8F%84%EC%9B%80%EB%A7%90-4d68c388-2ff2-0e7f-b706-35fb2ab88a8c");

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void 열기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "텍스트 파일(*.txt)|*.txt|모든 파일(*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = System.IO.File.ReadAllText(ofd.FileName);
            }

        }
    }
}
