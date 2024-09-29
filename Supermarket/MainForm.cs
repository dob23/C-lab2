using Supermarket.Bussines;
using Supermarket.View;

namespace Supermarket
{
    public partial class MainForm : Form
    {
        internal PayModeDAO payModeDAO;
        public MainForm()
        {
            payModeDAO = new PayModeDAO();
            InitializeComponent();
            payModeDAO.AddPayMode(new Model.PayMode(null, "Cash"));
        }

        private void PayModeMenuItem_Click(object sender, EventArgs e)
        {
            PayModeForm formPayMode = new PayModeForm(ref payModeDAO);
            formPayMode.MdiParent = this;
            formPayMode.Show();
        }
    }
}
