using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp
{
    public partial class Frm_HomeWork_Loan : Form
    {
        public Frm_HomeWork_Loan()
        {
            InitializeComponent();
        }

        private void btnPMT_Click(object sender, EventArgs e)
        {
            //貸款金額
            double TheAmount = double.Parse(txtTheAmount.Text);
            //貸款期數
            double LoanTerm = double.Parse(txtLoanTerm.Text)*12;
            //利率
            double InstersetRate = double.Parse(txtInsterestRate.Text);
            //頭期款
            double DonwPayment = double.Parse(txtDonwPayment.Text);

            //月利率
            double MonthlyInstersetRate = InstersetRate / 1200;

            //平均攤還率算式
            double AmortizationRate = (Math.Pow((1 + MonthlyInstersetRate), LoanTerm)) /
                                                                   (Math.Pow((1 + MonthlyInstersetRate), LoanTerm) - 1);
            //平均每月應攤付本息金額算式
            double MonthlyPayment = (TheAmount - DonwPayment )* MonthlyInstersetRate * AmortizationRate;
            int MonthlyPaymentInt = (int)Math.Round(MonthlyPayment);

            MessageBox.Show("月付額: " + MonthlyPaymentInt + "元");
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            //貸款金額
            double TheAmount = double.Parse(txtTheAmount.Text);
            //貸款期數
            double LoanTerm = double.Parse(txtLoanTerm.Text) * 12;
            //利率
            double InstersetRate = double.Parse(txtInsterestRate.Text);
            //頭期款
            double DonwPayment = double.Parse(txtDonwPayment.Text);

            //月利率
            double MonthlyInstersetRate = InstersetRate / 1200;

            //平均攤還率算式
            double AmortizationRate = (Math.Pow((1 + MonthlyInstersetRate), LoanTerm)) /
                                                                   (Math.Pow((1 + MonthlyInstersetRate), LoanTerm) - 1);
            //平均每月應攤付本息金額算式
            double MonthlyPayment = (TheAmount - DonwPayment) * MonthlyInstersetRate * AmortizationRate;
            int MonthlyPaymentInt = (int)Math.Round(MonthlyPayment);

            //總付款額
            int Total = (int)(MonthlyPaymentInt * LoanTerm);
            MessageBox.Show("總付款: " + Total + "元");
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            Frm_HomeWork_LoanReport  report = new Frm_HomeWork_LoanReport();

            //貸款金額
            double TheAmount = double.Parse(txtTheAmount.Text);
            //貸款期數
            double LoanTerm = double.Parse(txtLoanTerm.Text) * 12;
            //利率
            double InstersetRate = double.Parse(txtInsterestRate.Text);
            //頭期款
            double DonwPayment = double.Parse(txtDonwPayment.Text);

            //月利率
            double MonthlyInstersetRate = InstersetRate / 1200;

            //平均攤還率算式
            double AmortizationRate = (Math.Pow((1 + MonthlyInstersetRate), LoanTerm)) /
                                                                   (Math.Pow((1 + MonthlyInstersetRate), LoanTerm) - 1);
            //平均每月應攤付本息金額算式
            double MonthlyPayment = (TheAmount - DonwPayment) * MonthlyInstersetRate * AmortizationRate;
            int MonthlyPaymentInt = (int)Math.Round(MonthlyPayment);

            //總付款額
            int Total = (int)(MonthlyPaymentInt * LoanTerm);

            //貸款金額
            report.labAmount2.Text = TheAmount.ToString() ;
            //期限
            report.labLoanTerm2.Text = (LoanTerm/12).ToString() ;
            //利率
            report.labInsterestRate2.Text = InstersetRate.ToString();
            //月付款
            report.labMonthlyPayment2.Text= MonthlyPaymentInt.ToString() ;
            //總付款
            report.labTotal2.Text= Total.ToString() ;

            report.Show();
        }
    }
}

