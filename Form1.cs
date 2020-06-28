using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
	public partial class Form1 : Form
	{
		double op1, op2;
		string lastRes;
		public Form1()
		{
			InitializeComponent();
			rb_add.Checked = true;
			op1 = op2 = 0;
			lastRes = "0";
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}
		private void tx_op1_TextChanged(object sender, EventArgs e)
		{
			try
			{
				op1 = Convert.ToDouble(tx_op1.Text.Trim());
			}
			catch
			{
				logErr("Error: Operrator-1 is not a valid number!");
				op1 = 0;
				return;
			}
			calcRes();
		}
		private void tx_op2_TextChanged(object sender, EventArgs e)
		{
			try
			{
				op2 = Convert.ToDouble(tx_op2.Text.Trim());
			}
			catch
			{
				logErr("Error: Operrator-2 is not a valid number!");
				op2 = 0;
				return;
			}
			calcRes();
		}
		private void lb_out_Click(object sender, EventArgs e)
		{
			if (lb_out.Text == "")
			{
				if (lb_err.Text == "") return;
				Clipboard.SetText(lb_err.Text);
				logErr("Last message is copied to clipboard.");
				return;
			}
			Clipboard.SetText(lastRes);
			if(lb_err.Text != "") lb_history.Text = lb_err.Text + '\n' + lb_history.Text;
			lb_err.Text = lastRes + " (result) copied to clipboard!";
		}
		private void lb_err_Click(object sender, EventArgs e)
		{

		}
		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}
		private void onOperatorChange(object sender, EventArgs e)
		{
			RadioButton rb = (RadioButton)sender;
			if (rb != null && rb.Checked)
			{
				calcRes();
				tx_op2.Focus();
			}
		}

		public RadioButton selectedOperator() {
			return groupBox1.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
		}
		public void logErr(string S)
		{
			logHistory();
			lb_err.Text = S;
		}
		public void logHistory()
		{
			if (lb_err.Text != "")
			{
				lb_history.Text = lb_err.Text + '\n' + lb_history.Text;
				lb_err.Text = "";
			}
			if (lb_out.Text != "")
			{
				lb_history.Text = lb_out.Text + '\n' + lb_history.Text;
				lb_out.Text = "";
			}
		}
		public void logRes(double res)
		{
			logHistory();
			lastRes = res.ToString();
			lb_out.Text = op1.ToString() + " " + selectedOperator().Text + " " + op2.ToString() + " = " + lastRes;
		}
		public void calcRes()
		{
			double res = 0;
			switch (selectedOperator().Text[0])
			{
				case '+':
					res = op1 + op2;
					break;
				case '-':
					res = op1 - op2;
					break;
				case '*':
					res = op1 * op2;
					break;
				case '/':
					if (op2 == 0)
					{
						logErr("Error: Devided by zero!");
						return;
					}
					res = op1 / op2;
					break;
				default:
					logErr("Error: Invalid Operator");
					return;
			}
			logRes(res);
		}
	}
}
