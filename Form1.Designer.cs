namespace Calculator
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rb_div = new System.Windows.Forms.RadioButton();
			this.rb_sub = new System.Windows.Forms.RadioButton();
			this.rb_mul = new System.Windows.Forms.RadioButton();
			this.rb_add = new System.Windows.Forms.RadioButton();
			this.tx_op1 = new System.Windows.Forms.TextBox();
			this.tx_op2 = new System.Windows.Forms.TextBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.lb_out = new System.Windows.Forms.Label();
			this.lb_err = new System.Windows.Forms.Label();
			this.lb_history = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.groupBox1.AutoSize = true;
			this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.groupBox1.Controls.Add(this.rb_div);
			this.groupBox1.Controls.Add(this.rb_sub);
			this.groupBox1.Controls.Add(this.rb_mul);
			this.groupBox1.Controls.Add(this.rb_add);
			this.groupBox1.Location = new System.Drawing.Point(248, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(86, 118);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
			// 
			// rb_div
			// 
			this.rb_div.Appearance = System.Windows.Forms.Appearance.Button;
			this.rb_div.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.rb_div.Location = new System.Drawing.Point(46, 62);
			this.rb_div.Name = "rb_div";
			this.rb_div.Size = new System.Drawing.Size(34, 35);
			this.rb_div.TabIndex = 3;
			this.rb_div.TabStop = true;
			this.rb_div.Text = "/";
			this.rb_div.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.rb_div.UseVisualStyleBackColor = true;
			this.rb_div.CheckedChanged += new System.EventHandler(this.onOperatorChange);
			// 
			// rb_sub
			// 
			this.rb_sub.Appearance = System.Windows.Forms.Appearance.Button;
			this.rb_sub.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.rb_sub.Location = new System.Drawing.Point(46, 21);
			this.rb_sub.Name = "rb_sub";
			this.rb_sub.Size = new System.Drawing.Size(34, 35);
			this.rb_sub.TabIndex = 1;
			this.rb_sub.TabStop = true;
			this.rb_sub.Text = "-";
			this.rb_sub.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.rb_sub.UseVisualStyleBackColor = true;
			this.rb_sub.CheckedChanged += new System.EventHandler(this.onOperatorChange);
			// 
			// rb_mul
			// 
			this.rb_mul.Appearance = System.Windows.Forms.Appearance.Button;
			this.rb_mul.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.rb_mul.Location = new System.Drawing.Point(6, 62);
			this.rb_mul.Name = "rb_mul";
			this.rb_mul.Size = new System.Drawing.Size(34, 35);
			this.rb_mul.TabIndex = 2;
			this.rb_mul.TabStop = true;
			this.rb_mul.Text = "*";
			this.rb_mul.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.rb_mul.UseVisualStyleBackColor = true;
			this.rb_mul.CheckedChanged += new System.EventHandler(this.onOperatorChange);
			// 
			// rb_add
			// 
			this.rb_add.Appearance = System.Windows.Forms.Appearance.Button;
			this.rb_add.AutoSize = true;
			this.rb_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.rb_add.Location = new System.Drawing.Point(6, 21);
			this.rb_add.Name = "rb_add";
			this.rb_add.Size = new System.Drawing.Size(34, 35);
			this.rb_add.TabIndex = 0;
			this.rb_add.TabStop = true;
			this.rb_add.Text = "+";
			this.rb_add.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.rb_add.UseVisualStyleBackColor = true;
			this.rb_add.CheckedChanged += new System.EventHandler(this.onOperatorChange);
			// 
			// tx_op1
			// 
			this.tx_op1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.tx_op1.Location = new System.Drawing.Point(12, 58);
			this.tx_op1.Name = "tx_op1";
			this.tx_op1.Size = new System.Drawing.Size(230, 30);
			this.tx_op1.TabIndex = 0;
			this.tx_op1.TextChanged += new System.EventHandler(this.tx_op1_TextChanged);
			// 
			// tx_op2
			// 
			this.tx_op2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.tx_op2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.tx_op2.Location = new System.Drawing.Point(340, 58);
			this.tx_op2.Name = "tx_op2";
			this.tx_op2.Size = new System.Drawing.Size(230, 30);
			this.tx_op2.TabIndex = 2;
			this.tx_op2.TextChanged += new System.EventHandler(this.tx_op2_TextChanged);
			// 
			// groupBox2
			// 
			this.groupBox2.AutoSize = true;
			this.groupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.groupBox2.Controls.Add(this.tx_op2);
			this.groupBox2.Controls.Add(this.groupBox1);
			this.groupBox2.Controls.Add(this.tx_op1);
			this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBox2.Location = new System.Drawing.Point(0, 0);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(582, 151);
			this.groupBox2.TabIndex = 0;
			this.groupBox2.TabStop = false;
			// 
			// lb_out
			// 
			this.lb_out.AutoSize = true;
			this.lb_out.CausesValidation = false;
			this.lb_out.Dock = System.Windows.Forms.DockStyle.Top;
			this.lb_out.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.lb_out.Location = new System.Drawing.Point(0, 151);
			this.lb_out.Name = "lb_out";
			this.lb_out.Size = new System.Drawing.Size(23, 25);
			this.lb_out.TabIndex = 1;
			this.lb_out.Text = "0";
			this.lb_out.Click += new System.EventHandler(this.lb_out_Click);
			// 
			// lb_err
			// 
			this.lb_err.AutoSize = true;
			this.lb_err.CausesValidation = false;
			this.lb_err.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.lb_err.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.lb_err.ForeColor = System.Drawing.Color.Red;
			this.lb_err.Location = new System.Drawing.Point(0, 333);
			this.lb_err.Name = "lb_err";
			this.lb_err.Size = new System.Drawing.Size(0, 20);
			this.lb_err.TabIndex = 3;
			this.lb_err.Click += new System.EventHandler(this.lb_err_Click);
			// 
			// lb_history
			// 
			this.lb_history.AutoSize = true;
			this.lb_history.CausesValidation = false;
			this.lb_history.Dock = System.Windows.Forms.DockStyle.Top;
			this.lb_history.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.lb_history.ForeColor = System.Drawing.Color.Gray;
			this.lb_history.Location = new System.Drawing.Point(0, 176);
			this.lb_history.MaximumSize = new System.Drawing.Size(0, 60);
			this.lb_history.Name = "lb_history";
			this.lb_history.Size = new System.Drawing.Size(0, 20);
			this.lb_history.TabIndex = 2;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(582, 353);
			this.Controls.Add(this.lb_history);
			this.Controls.Add(this.lb_err);
			this.Controls.Add(this.lb_out);
			this.Controls.Add(this.groupBox2);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.Text = "Calculator - by tz.man";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton rb_div;
		private System.Windows.Forms.RadioButton rb_sub;
		private System.Windows.Forms.RadioButton rb_mul;
		private System.Windows.Forms.RadioButton rb_add;
		private System.Windows.Forms.TextBox tx_op1;
		private System.Windows.Forms.TextBox tx_op2;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label lb_out;
		private System.Windows.Forms.Label lb_err;
		private System.Windows.Forms.Label lb_history;
	}
}

