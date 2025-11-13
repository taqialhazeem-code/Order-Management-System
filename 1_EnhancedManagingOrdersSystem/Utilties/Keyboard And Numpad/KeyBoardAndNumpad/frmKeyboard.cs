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
	public partial class frmKeyboard : Form
	{
		public string _text = "";


		public frmKeyboard(string str)
		{
			InitializeComponent();
			RegisterHandlers();

			_text = str;

			if(str!="غير معروف"&&str!="لا يوجد ملاحظات")
			{
				textBox1.Text = str;
			}

		}

		private void RegisterHandlers()
		{
			// General character/digit keys
			button1.Click += AppendFromButton;
			button2.Click += AppendFromButton;
			button3.Click += AppendFromButton;
			button4.Click += AppendFromButton;
			button5.Click += AppendFromButton;
			button6.Click += AppendFromButton;
			button7.Click += AppendFromButton;
			button8.Click += AppendFromButton;
			button9.Click += AppendFromButton;
			button10.Click += AppendFromButton;

			button11.Click += AppendFromButton;
			button12.Click += AppendFromButton;
			button13.Click += AppendFromButton;
			button14.Click += AppendFromButton;
			button15.Click += AppendFromButton;
			button16.Click += AppendFromButton;
			button17.Click += AppendFromButton;
			button18.Click += AppendFromButton;
			button19.Click += AppendFromButton;
			button20.Click += AppendFromButton;
			button21.Click += AppendFromButton;
			button22.Click += AppendFromButton;
			button23.Click += AppendFromButton;
			button24.Click += AppendFromButton;
			button25.Click += AppendFromButton;
			button26.Click += AppendFromButton;
			button27.Click += AppendFromButton;
			button28.Click += AppendFromButton;
			button29.Click += AppendFromButton;
			button30.Click += AppendFromButton;
			button31.Click += AppendFromButton;
			button32.Click += AppendFromButton;
			button33.Click += AppendFromButton;
			button34.Click += AppendFromButton;
			button35.Click += AppendFromButton;
			button36.Click += AppendFromButton;
			button37.Click += AppendFromButton;
			button38.Click += AppendFromButton;
			button39.Click += AppendFromButton;
			button40.Click += AppendFromButton;
			button41.Click += AppendFromButton;
			button46.Click += AppendFromButton;
			button50.Click += AppendFromButton;

			// button42 is space (special)
			button42.Click += Space_Click;

			// button43 is close
			button43.Click += Close_Click;

			// button44 is delete/backspace
			button44.Click += Backspace_Click;

			// button45 is OK
			button45.Click += Ok_Click;

			// button46 already wired in Designer to button46_Click

			// remaining character keys
			button47.Click += AppendFromButton;
			button48.Click += AppendFromButton;
		}

		private void AppendFromButton(object sender, EventArgs e)
		{
			var btn = sender as Button;
			if (btn == null) return;




			string textToInsert = btn.Text;

			

			int cursorPosition = textBox1.SelectionStart;

			// Insert text at cursor position (or at end if cursor is at the end)
			textBox1.Text = textBox1.Text.Insert(cursorPosition, textToInsert);

			// Move cursor to after the inserted text
			textBox1.SelectionStart = cursorPosition + textToInsert.Length;

			// Focus the textbox to maintain cursor visibility
			textBox1.Focus();
		}

		private void Space_Click(object sender, EventArgs e)
		{
			int cursorPosition = textBox1.SelectionStart;

			// Insert space at cursor position
			textBox1.Text = textBox1.Text.Insert(cursorPosition, " ");

			// Move cursor to after the inserted space
			textBox1.SelectionStart = cursorPosition + 1;

			// Focus the textbox to maintain cursor visibility
			textBox1.Focus();
		}

		private void Backspace_Click(object sender, EventArgs e)
		{
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

		private void Close_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void Ok_Click(object sender, EventArgs e)
		{
			
			_text = textBox1.Text;
			this.Close();
		}

		private void keyboad_Load(object sender, EventArgs e)
		{

		}

		private void button45_Click(object sender, EventArgs e)
		{
			_text = textBox1.Text;
			this.Close();
		}

		

		private void frmKeyboard_Load(object sender, EventArgs e)
		{
			textBox1.SelectionStart = textBox1.Text.Length;
			textBox1.SelectionLength = 0;
		    textBox1.Focus();
		}

		private void button49_Click_1(object sender, EventArgs e)
		{
			textBox1.Clear();
		}

		private void button44_Click(object sender, EventArgs e)
		{

		}
	}
}
