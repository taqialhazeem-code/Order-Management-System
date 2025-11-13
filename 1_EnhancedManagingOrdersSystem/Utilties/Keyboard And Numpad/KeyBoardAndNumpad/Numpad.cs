using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_EnhancedManagingOrdersSystem.Utilties.Keyboard_And_Numpad.KeyBoard
{
	public partial class Numpad : Form
	{

		public string NumpadValue = "";

		public Numpad(string str)
		{
			InitializeComponent();

			button1.Click += AllButtons_Click;
			button2.Click += AllButtons_Click;
			button3.Click += AllButtons_Click;
			button4.Click += AllButtons_Click;
			button5.Click += AllButtons_Click;
			button6.Click += AllButtons_Click;
			button7.Click += AllButtons_Click;
			button8.Click += AllButtons_Click;
			button9.Click += AllButtons_Click;
			button10.Click += AllButtons_Click;
			button11.Click += AllButtons_Click;
			button12.Click += AllButtons_Click;
			button13.Click += AllButtons_Click;
			button14.Click += AllButtons_Click;

			NumpadValue = str;


			if (str != "غير معروف" && str != "لا يوجد ملاحظات")
			{
				textBox1.Text = str;
			}

		}

		private void button11_Click(object sender, EventArgs e)
		{

		}

		private void button10_Click(object sender, EventArgs e)
		{

		}

		private void button9_Click(object sender, EventArgs e)
		{

		}

		private void button8_Click(object sender, EventArgs e)
		{

		}

		private void button7_Click(object sender, EventArgs e)
		{

		}

		private void button6_Click(object sender, EventArgs e)
		{

		}

		private void button5_Click(object sender, EventArgs e)
		{

		}

		private void button4_Click(object sender, EventArgs e)
		{

		}

		private void button3_Click(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{

		}

		private void AllButtons_Click(object sender, EventArgs e)
		{
			Button button = sender as Button;
			if (button != null)
			{
				if (button.Text == "ادخال")
				{
					NumpadValue = textBox1.Text;
					this.DialogResult = DialogResult.OK;
					this.Close();
				}
				else if (button.Text == "مسح")
				{
					textBox1.Clear();
				}
				else if (button.Text == "حذف" || button.Text == "←" || button.Text == "⌫") // Add your delete button text here
				{
					// Delete functionality - same as keyboard
					if (!string.IsNullOrEmpty(textBox1.Text))
					{
						int cursorPosition = textBox1.SelectionStart;

						if (cursorPosition > 0)
						{
							// Remove the character before the cursor
							textBox1.Text = textBox1.Text.Remove(cursorPosition - 1, 1);

							// Set the cursor position back to where it was (after the deletion)
							textBox1.SelectionStart = cursorPosition - 1;
						}
						else
						{
							// If cursor is at position 0 or no cursor, delete from the end
							textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
						}

						// Focus the textbox to maintain cursor visibility
						textBox1.Focus();
					}
				}
				else
				{
					// Insert text at cursor position instead of appending
					int cursorPosition = textBox1.SelectionStart;

					// Insert the button text at cursor position
					textBox1.Text = textBox1.Text.Insert(cursorPosition, button.Text);

					// Move cursor to after the inserted text
					textBox1.SelectionStart = cursorPosition + button.Text.Length;

					// Focus the textbox to maintain cursor visibility
					textBox1.Focus();
				}
			}
		}

		private void Numpad_Load(object sender, EventArgs e)
		{
			textBox1.SelectionStart = textBox1.Text.Length;
			textBox1.SelectionLength = 0;
			textBox1.Focus();
		}

		private void button12_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{

		}
	}
}
