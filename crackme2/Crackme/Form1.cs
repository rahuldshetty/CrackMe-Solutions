using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Crackme
{
	[DesignerGenerated]
	public class Form1 : Form
	{
		private static List<WeakReference> __ENCList = new List<WeakReference>();

		private IContainer components;

		[AccessedThroughProperty("btnCheck")]
		private Button _btnCheck;

		[AccessedThroughProperty("txtName")]
		private TextBox _txtName;

		[AccessedThroughProperty("lblName")]
		private Label _lblName;

		[AccessedThroughProperty("lblSerial")]
		private Label _lblSerial;

		[AccessedThroughProperty("txtSerial")]
		private TextBox _txtSerial;

		internal virtual Button btnCheck
		{
			[DebuggerNonUserCode]
			get
			{
				return _btnCheck;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			set
			{
				EventHandler value2 = btnCheck_Click;
				if (_btnCheck != null)
				{
					_btnCheck.Click -= value2;
				}
				_btnCheck = value;
				if (_btnCheck != null)
				{
					_btnCheck.Click += value2;
				}
			}
		}

		internal virtual TextBox txtName
		{
			[DebuggerNonUserCode]
			get
			{
				return _txtName;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			set
			{
				_txtName = value;
			}
		}

		internal virtual Label lblName
		{
			[DebuggerNonUserCode]
			get
			{
				return _lblName;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			set
			{
				_lblName = value;
			}
		}

		internal virtual Label lblSerial
		{
			[DebuggerNonUserCode]
			get
			{
				return _lblSerial;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			set
			{
				_lblSerial = value;
			}
		}

		internal virtual TextBox txtSerial
		{
			[DebuggerNonUserCode]
			get
			{
				return _txtSerial;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			[DebuggerNonUserCode]
			set
			{
				_txtSerial = value;
			}
		}

		[DebuggerNonUserCode]
		public Form1()
		{
			lock (__ENCList)
			{
				__ENCList.Add(new WeakReference(this));
			}
			InitializeComponent();
		}

		[DebuggerNonUserCode]
		protected override void Dispose(bool disposing)
		{
			try
			{
				if ((disposing && components != null) ? true : false)
				{
					components.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		[System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			btnCheck = new System.Windows.Forms.Button();
			txtName = new System.Windows.Forms.TextBox();
			lblName = new System.Windows.Forms.Label();
			lblSerial = new System.Windows.Forms.Label();
			txtSerial = new System.Windows.Forms.TextBox();
			SuspendLayout();
			System.Drawing.Point point2 = btnCheck.Location = new System.Drawing.Point(77, 158);
			btnCheck.Name = "btnCheck";
			System.Drawing.Size size2 = btnCheck.Size = new System.Drawing.Size(123, 61);
			btnCheck.TabIndex = 0;
			btnCheck.Text = "Check";
			btnCheck.UseVisualStyleBackColor = true;
			point2 = (txtName.Location = new System.Drawing.Point(77, 38));
			txtName.Name = "txtName";
			size2 = (txtName.Size = new System.Drawing.Size(123, 20));
			txtName.TabIndex = 1;
			lblName.AutoSize = true;
			point2 = (lblName.Location = new System.Drawing.Point(120, 22));
			lblName.Name = "lblName";
			size2 = (lblName.Size = new System.Drawing.Size(35, 13));
			lblName.TabIndex = 2;
			lblName.Text = "Name";
			lblSerial.AutoSize = true;
			point2 = (lblSerial.Location = new System.Drawing.Point(120, 89));
			lblSerial.Name = "lblSerial";
			size2 = (lblSerial.Size = new System.Drawing.Size(33, 13));
			lblSerial.TabIndex = 4;
			lblSerial.Text = "Serial";
			point2 = (txtSerial.Location = new System.Drawing.Point(77, 105));
			txtSerial.Name = "txtSerial";
			size2 = (txtSerial.Size = new System.Drawing.Size(123, 20));
			txtSerial.TabIndex = 3;
			System.Drawing.SizeF sizeF2 = AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			size2 = (ClientSize = new System.Drawing.Size(292, 266));
			Controls.Add(lblSerial);
			Controls.Add(txtSerial);
			Controls.Add(lblName);
			Controls.Add(txtName);
			Controls.Add(btnCheck);
			Name = "Form1";
			Text = "Crack Me";
			ResumeLayout(false);
			PerformLayout();
		}

		private void btnCheck_Click(object sender, EventArgs e)
		{
			string input = Strings.Trim(txtName.Text);
			string right = Conversions.ToString(Encrypt(input));
			string left = Strings.Trim(txtSerial.Text);
			if (Operators.CompareString(left, right, TextCompare: false) == 0)
			{
				Interaction.MsgBox("You Put In The Right Serial Number");
			}
			else
			{
				Interaction.MsgBox("Try Again");
			}
		}

		private int Encrypt(string Input)
		{
			checked
			{
				int num = Input.Length - 1;
				int num2 = 0;
				int num5 = default(int);
				while (true)
				{
					int num3 = num2;
					int num4 = num;
					if (num3 > num4)
					{
						break;
					}
					char @string = Conversions.ToChar(Input.Substring(num2));
					num5 = (int)Math.Round(Conversions.ToDouble(Conversion.Oct(Strings.Asc(Conversions.ToString(num5))) + Conversion.Oct(Strings.Asc(@string))) + 666.0);
					num2++;
				}
				return num5;
			}
		}
	}
}
