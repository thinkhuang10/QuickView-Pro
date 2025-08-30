using System.Windows.Forms;

namespace QuickView_Pro
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        // 重写WndProc拦截标题栏双击消息
        // 禁止双击全屏窗体
        protected override void WndProc(ref Message m)
        {
            // WM_NCLBUTTONDBLCLK 消息：标题栏双击
            const int WM_NCLBUTTONDBLCLK = 0xA3;

            // 如果是标题栏双击消息，则不处理
            if (m.Msg == WM_NCLBUTTONDBLCLK)
            {
                return;
            }

            base.WndProc(ref m);
        }

    }
}
