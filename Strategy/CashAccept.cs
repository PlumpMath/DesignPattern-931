using System;
using System.Windows.Forms;

namespace Strategy
{
    public partial class CashAccept : Form
    {
        public decimal TotalMoney { get; set; }

        public CashAccept()
        {
            InitializeComponent();
            cbType.SelectedIndex = 0;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            //BaseCashAccept cash = new CashAcceptFactory().Create(cbType.Text);
            //decimal money = cash.GetResult(decimal.Parse(textPrice.Text) * decimal.Parse(textNum.Text));
            //lboxResult.Items.Add("数量：" + textNum.Text + "   单价：" + textPrice.Text + "  总价：" + money);
            //TotalMoney += money;
            //lbTotal.Text = TotalMoney.ToString();
            CashContext context = new CashContext(cbType.Text);
            decimal money = context.AcceptCash(decimal.Parse(textPrice.Text) * decimal.Parse(textNum.Text));
            lboxResult.Items.Add("数量：" + textNum.Text + "   单价：" + textPrice.Text + "  总价：" + money);
            TotalMoney += money;
            lbTotal.Text = TotalMoney.ToString();
        }
    }
}
