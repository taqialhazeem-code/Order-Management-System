using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _1_EnhancedManagingOrdersSystem.Utilties.Keyboard_And_Numpad.KeyBoard;
using Microsoft.IdentityModel.Tokens;

namespace _1_EnhancedManagingOrdersSystem.Utilties.CustomDateTimePicker
{
	public partial class frmCustomDateTimePicker : Form
	{
		public DateTime DT = DateTime.Now;


		// Lists to store buttons for each category
		private List<Button> monthButtons;
		private List<Button> dayButtons;
		private List<Button> hourButtons;
		private List<Button> minuteButtons;
		private List<Button> amPmButtons;
		
		// Colors for button highlighting
		private readonly Color selectedColor = Color.LightGreen;
		private readonly Color defaultColor = SystemColors.Control;

		public frmCustomDateTimePicker()
		{
			InitializeComponent();
			InitializeButtonCollections();
			SetupButtonEvents();
			SetupDateTimePickerFormat();
		}

		private void SetupDateTimePickerFormat()
		{
			// Set custom format to show: Minutes:Hours Day/Month/Year in 12-hour format
			dateTimePicker1.Format = DateTimePickerFormat.Custom;
			dateTimePicker1.CustomFormat = "yyyy/MM/dd h:mm tt"; // Changed from "hh" to "h"
		}

		private void InitializeButtonCollections()
		{
			// Initialize month buttons (1-12)
			monthButtons = new List<Button> 
			{ 
				button1, button2, button3, button4, button5, button6,
				button12, button11, button10, button9, button8, button7 
			};

			// Initialize day buttons (1-31)
			dayButtons = new List<Button> 
			{
				button18, button17, button16, button15, button14, button13,
				button24, button23, button22, button21, button20, button19,
				button30, button29, button28, button27, button26, button25,
				button36, button35, button34, button33, button32, button31,
				button42, button41, button68, button67, button70, button69, button71
			};

			// Initialize hour buttons (1-12)
			hourButtons = new List<Button> 
			{
				button44, button43, button40, button39, button38, button37,
				button50, button49, button48, button47, button46, button45
			};

			// Initialize minute buttons
			minuteButtons = new List<Button> 
			{
				button57, button56, button55, button54, button53, button52,
				button51, button62, button61, button60, button59, button58
			};

			// Initialize AM/PM buttons
			amPmButtons = new List<Button> { button63, button64 };
		}

		private void SetupButtonEvents()
		{
			// Month buttons (1-12)
			button1.Click += (s, e) => { HighlightButton((Button)s, monthButtons); UpdateMonth(1); UpdateDateTimeFormat(); };
			button2.Click += (s, e) => { HighlightButton((Button)s, monthButtons); UpdateMonth(2); UpdateDateTimeFormat(); };
			button3.Click += (s, e) => { HighlightButton((Button)s, monthButtons); UpdateMonth(3); UpdateDateTimeFormat(); };
			button4.Click += (s, e) => { HighlightButton((Button)s, monthButtons); UpdateMonth(4); UpdateDateTimeFormat(); };
			button5.Click += (s, e) => { HighlightButton((Button)s, monthButtons); UpdateMonth(5); UpdateDateTimeFormat(); };
			button6.Click += (s, e) => { HighlightButton((Button)s, monthButtons); UpdateMonth(6); UpdateDateTimeFormat(); };
			button12.Click += (s, e) => { HighlightButton((Button)s, monthButtons); UpdateMonth(7); UpdateDateTimeFormat(); };
			button11.Click += (s, e) => { HighlightButton((Button)s, monthButtons); UpdateMonth(8); UpdateDateTimeFormat(); };
			button10.Click += (s, e) => { HighlightButton((Button)s, monthButtons); UpdateMonth(9); UpdateDateTimeFormat(); };
			button9.Click += (s, e) => { HighlightButton((Button)s, monthButtons); UpdateMonth(10); UpdateDateTimeFormat(); };
			button8.Click += (s, e) => { HighlightButton((Button)s, monthButtons); UpdateMonth(11); UpdateDateTimeFormat(); };
			button7.Click += (s, e) => { HighlightButton((Button)s, monthButtons); UpdateMonth(12); UpdateDateTimeFormat(); };

			// Day buttons (1-31)
			button18.Click += (s, e) => { HighlightButton((Button)s, dayButtons); UpdateDay(1); UpdateDateTimeFormat(); };
			button17.Click += (s, e) => { HighlightButton((Button)s, dayButtons); UpdateDay(2); UpdateDateTimeFormat(); };
			button16.Click += (s, e) => { HighlightButton((Button)s, dayButtons); UpdateDay(3); UpdateDateTimeFormat(); };
			button15.Click += (s, e) => { HighlightButton((Button)s, dayButtons); UpdateDay(4); UpdateDateTimeFormat(); };
			button14.Click += (s, e) => { HighlightButton((Button)s, dayButtons); UpdateDay(5); UpdateDateTimeFormat(); };
			button13.Click += (s, e) => { HighlightButton((Button)s, dayButtons); UpdateDay(6); UpdateDateTimeFormat(); };
			button24.Click += (s, e) => { HighlightButton((Button)s, dayButtons); UpdateDay(7); UpdateDateTimeFormat(); };
			button23.Click += (s, e) => { HighlightButton((Button)s, dayButtons); UpdateDay(8); UpdateDateTimeFormat(); };
			button22.Click += (s, e) => { HighlightButton((Button)s, dayButtons); UpdateDay(9); UpdateDateTimeFormat(); };
			button21.Click += (s, e) => { HighlightButton((Button)s, dayButtons); UpdateDay(10); UpdateDateTimeFormat(); };
			button20.Click += (s, e) => { HighlightButton((Button)s, dayButtons); UpdateDay(11); UpdateDateTimeFormat(); };
			button19.Click += (s, e) => { HighlightButton((Button)s, dayButtons); UpdateDay(12); UpdateDateTimeFormat(); };
			button30.Click += (s, e) => { HighlightButton((Button)s, dayButtons); UpdateDay(13); UpdateDateTimeFormat(); };
			button29.Click += (s, e) => { HighlightButton((Button)s, dayButtons); UpdateDay(14); UpdateDateTimeFormat(); };
			button28.Click += (s, e) => { HighlightButton((Button)s, dayButtons); UpdateDay(15); UpdateDateTimeFormat(); };
			button27.Click += (s, e) => { HighlightButton((Button)s, dayButtons); UpdateDay(16); UpdateDateTimeFormat(); };
			button26.Click += (s, e) => { HighlightButton((Button)s, dayButtons); UpdateDay(17); UpdateDateTimeFormat(); };
			button25.Click += (s, e) => { HighlightButton((Button)s, dayButtons); UpdateDay(18); UpdateDateTimeFormat(); };
			button36.Click += (s, e) => { HighlightButton((Button)s, dayButtons); UpdateDay(19); UpdateDateTimeFormat(); };
			button35.Click += (s, e) => { HighlightButton((Button)s, dayButtons); UpdateDay(20); UpdateDateTimeFormat(); };
			button34.Click += (s, e) => { HighlightButton((Button)s, dayButtons); UpdateDay(21); UpdateDateTimeFormat(); };
			button33.Click += (s, e) => { HighlightButton((Button)s, dayButtons); UpdateDay(22); UpdateDateTimeFormat(); };
			button32.Click += (s, e) => { HighlightButton((Button)s, dayButtons); UpdateDay(23); UpdateDateTimeFormat(); };
			button31.Click += (s, e) => { HighlightButton((Button)s, dayButtons); UpdateDay(24); UpdateDateTimeFormat(); };
			button42.Click += (s, e) => { HighlightButton((Button)s, dayButtons); UpdateDay(25); UpdateDateTimeFormat(); };
			button41.Click += (s, e) => { HighlightButton((Button)s, dayButtons); UpdateDay(26); UpdateDateTimeFormat(); };
			button68.Click += (s, e) => { HighlightButton((Button)s, dayButtons); UpdateDay(27); UpdateDateTimeFormat(); };
			button67.Click += (s, e) => { HighlightButton((Button)s, dayButtons); UpdateDay(28); UpdateDateTimeFormat(); };
			button70.Click += (s, e) => { HighlightButton((Button)s, dayButtons); UpdateDay(29); UpdateDateTimeFormat(); };
			button69.Click += (s, e) => { HighlightButton((Button)s, dayButtons); UpdateDay(30); UpdateDateTimeFormat(); };
			button71.Click += (s, e) => { HighlightButton((Button)s, dayButtons); UpdateDay(31); UpdateDateTimeFormat(); };

			// Hour buttons (1-12)
			button44.Click += (s, e) => { HighlightButton((Button)s, hourButtons); UpdateHour(1); UpdateDateTimeFormat(); };
			button43.Click += (s, e) => { HighlightButton((Button)s, hourButtons); UpdateHour(2); UpdateDateTimeFormat(); };
			button40.Click += (s, e) => { HighlightButton((Button)s, hourButtons); UpdateHour(3); UpdateDateTimeFormat(); };
			button39.Click += (s, e) => { HighlightButton((Button)s, hourButtons); UpdateHour(4); UpdateDateTimeFormat(); };
			button38.Click += (s, e) => { HighlightButton((Button)s, hourButtons); UpdateHour(5); UpdateDateTimeFormat(); };
			button37.Click += (s, e) => { HighlightButton((Button)s, hourButtons); UpdateHour(6); UpdateDateTimeFormat(); };
			button50.Click += (s, e) => { HighlightButton((Button)s, hourButtons); UpdateHour(7); UpdateDateTimeFormat(); };
			button49.Click += (s, e) => { HighlightButton((Button)s, hourButtons); UpdateHour(8); UpdateDateTimeFormat(); };
			button48.Click += (s, e) => { HighlightButton((Button)s, hourButtons); UpdateHour(9); UpdateDateTimeFormat(); };
			button47.Click += (s, e) => { HighlightButton((Button)s, hourButtons); UpdateHour(10); UpdateDateTimeFormat(); };
			button46.Click += (s, e) => { HighlightButton((Button)s, hourButtons); UpdateHour(11); UpdateDateTimeFormat(); };
			button45.Click += (s, e) => { HighlightButton((Button)s, hourButtons); UpdateHour(12); UpdateDateTimeFormat(); };

			// Minute buttons (0, 5, 10, 15, 20, 25, 30, 35, 40, 45, 50, 55)
			button57.Click += (s, e) => { HighlightButton((Button)s, minuteButtons); UpdateMinute(0); UpdateDateTimeFormat(); };
			button56.Click += (s, e) => { HighlightButton((Button)s, minuteButtons); UpdateMinute(5); UpdateDateTimeFormat(); };
			button55.Click += (s, e) => { HighlightButton((Button)s, minuteButtons); UpdateMinute(10); UpdateDateTimeFormat(); };
			button54.Click += (s, e) => { HighlightButton((Button)s, minuteButtons); UpdateMinute(15); UpdateDateTimeFormat(); };
			button53.Click += (s, e) => { HighlightButton((Button)s, minuteButtons); UpdateMinute(20); UpdateDateTimeFormat(); };
			button52.Click += (s, e) => { HighlightButton((Button)s, minuteButtons); UpdateMinute(25); UpdateDateTimeFormat(); };
			button51.Click += (s, e) => { HighlightButton((Button)s, minuteButtons); UpdateMinute(30); UpdateDateTimeFormat(); };
			button62.Click += (s, e) => { HighlightButton((Button)s, minuteButtons); UpdateMinute(35); UpdateDateTimeFormat(); };
			button61.Click += (s, e) => { HighlightButton((Button)s, minuteButtons); UpdateMinute(40); UpdateDateTimeFormat(); };
			button60.Click += (s, e) => { HighlightButton((Button)s, minuteButtons); UpdateMinute(45); UpdateDateTimeFormat(); };
			button59.Click += (s, e) => { HighlightButton((Button)s, minuteButtons); UpdateMinute(50); UpdateDateTimeFormat(); };
			button58.Click += (s, e) => { HighlightButton((Button)s, minuteButtons); UpdateMinute(55); UpdateDateTimeFormat(); };

			// AM/PM buttons
			button63.Click += (s, e) => { HighlightButton((Button)s, amPmButtons); UpdateAmPm(true); UpdateDateTimeFormat(); }; // AM
			button64.Click += (s, e) => { HighlightButton((Button)s, amPmButtons); UpdateAmPm(false); UpdateDateTimeFormat(); }; // PM

			// OK/Cancel buttons
			button65.Click += (s, e) => { this.DialogResult = DialogResult.OK; this.Close(); };
			button66.Click += (s, e) => { this.DialogResult = DialogResult.Cancel; this.Close(); };
		}

		private void UpdateDateTimeFormat()
		{
			// Refresh the DateTimePicker display to show the updated date/time
			dateTimePicker1.Refresh();
		}

		private void HighlightButton(Button selectedButton, List<Button> buttonGroup)
		{
			// Reset all buttons in the group to default color
			foreach (Button btn in buttonGroup)
			{
				btn.BackColor = Color.Moccasin;
				
			}

			// Highlight the selected button
			selectedButton.BackColor = selectedColor;
			selectedButton.UseVisualStyleBackColor = false;
		}

		private void HighlightCurrentSelections()
		{
			try
			{
				var currentDate = dateTimePicker1.Value;

				// Highlight current month
				if (currentDate.Month >= 1 && currentDate.Month <= 12)
				{
					var monthButton = monthButtons[currentDate.Month - 1];
					HighlightButton(monthButton, monthButtons);
				}

				// Highlight current day (ensure day exists in button list)
				if (currentDate.Day >= 1 && currentDate.Day <= dayButtons.Count)
				{
					var dayButton = dayButtons[currentDate.Day - 1];
					HighlightButton(dayButton, dayButtons);
				}

				// Highlight current hour (convert 24-hour to 12-hour)
				var hour12 = currentDate.Hour == 0 ? 12 : (currentDate.Hour > 12 ? currentDate.Hour - 12 : currentDate.Hour);
				if (hour12 >= 1 && hour12 <= 12)
				{
					var hourButton = hourButtons[hour12 - 1];
					HighlightButton(hourButton, hourButtons);
				}

				// Highlight current minute (find closest 5-minute interval)
				var minuteValues = new int[] { 0, 5, 10, 15, 20, 25, 30, 35, 40, 45, 50, 55 };
				var closestMinuteIndex = 0;
				var minDiff = Math.Abs(currentDate.Minute - minuteValues[0]);
				
				for (int i = 1; i < minuteValues.Length; i++)
				{
					var diff = Math.Abs(currentDate.Minute - minuteValues[i]);
					if (diff < minDiff)
					{
						minDiff = diff;
						closestMinuteIndex = i;
					}
				}
				HighlightButton(minuteButtons[closestMinuteIndex], minuteButtons);

				// Highlight AM/PM
				var amPmButton = currentDate.Hour < 12 ? amPmButtons[0] : amPmButtons[1];
				HighlightButton(amPmButton, amPmButtons);
			}
			catch (Exception ex)
			{
				// Ignore highlighting errors but log if needed
				System.Diagnostics.Debug.WriteLine($"Error highlighting current selections: {ex.Message}");
			}
		}

		private void UpdateMonth(int month)
		{
			try
			{
				var currentDate = dateTimePicker1.Value;
				var year = string.IsNullOrEmpty(textBox1.Text) ? currentDate.Year : int.Parse(textBox1.Text);
				
				// Handle days that don't exist in the new month
				var daysInMonth = DateTime.DaysInMonth(year, month);
				var day = currentDate.Day > daysInMonth ? daysInMonth : currentDate.Day;
				
				dateTimePicker1.Value = new DateTime(year, month, day, currentDate.Hour, currentDate.Minute, currentDate.Second);
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error updating month: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void UpdateDay(int day)
		{
			try
			{
				var currentDate = dateTimePicker1.Value;
				var year = string.IsNullOrEmpty(textBox1.Text) ? currentDate.Year : int.Parse(textBox1.Text);
				
				// Check if the day exists in the current month
				var daysInMonth = DateTime.DaysInMonth(year, currentDate.Month);
				if (day > daysInMonth)
				{
					MessageBox.Show($"Day {day} does not exist in {currentDate.ToString("MMMM")} {year}", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}
				
				dateTimePicker1.Value = new DateTime(year, currentDate.Month, day, currentDate.Hour, currentDate.Minute, currentDate.Second);
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error updating day: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void UpdateHour(int hour)
		{
			try
			{
				var currentDate = dateTimePicker1.Value;
				var year = string.IsNullOrEmpty(textBox1.Text) ? currentDate.Year : int.Parse(textBox1.Text);
				
				// Get current AM/PM state from the highlighted button or current time
				bool isPmSelected = false;
				
				// Check which AM/PM button is currently highlighted
				if (amPmButtons[1].BackColor == selectedColor) // PM button is highlighted
				{
					isPmSelected = true;
				}
				else if (amPmButtons[0].BackColor == selectedColor) // AM button is highlighted
				{
					isPmSelected = false;
				}
				else
				{
					// If no AM/PM button is highlighted, use current time's AM/PM
					isPmSelected = currentDate.Hour >= 12;
				}
				
				// Convert 12-hour to 24-hour format
				int actualHour;
				if (isPmSelected) // PM
				{
					if (hour == 12)
						actualHour = 12; // 12 PM = 12
					else
						actualHour = hour + 12; // 1-11 PM = 13-23
				}
				else // AM
				{
					if (hour == 12)
						actualHour = 0; // 12 AM = 0 (midnight)
					else
						actualHour = hour; // 1-11 AM = 1-11
				}
				
				dateTimePicker1.Value = new DateTime(year, currentDate.Month, currentDate.Day, actualHour, currentDate.Minute, currentDate.Second);
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error updating hour: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void UpdateMinute(int minute)
		{
			try
			{
				var currentDate = dateTimePicker1.Value;
				var year = string.IsNullOrEmpty(textBox1.Text) ? currentDate.Year : int.Parse(textBox1.Text);
				
				dateTimePicker1.Value = new DateTime(year, currentDate.Month, currentDate.Day, currentDate.Hour, minute, currentDate.Second);
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error updating minute: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void UpdateAmPm(bool isAm)
		{
			try
			{
				var currentDate = dateTimePicker1.Value;
				var year = string.IsNullOrEmpty(textBox1.Text) ? currentDate.Year : int.Parse(textBox1.Text);
				var currentHour = currentDate.Hour;
				int newHour;

				if (isAm) // AM selected
				{
					// Convert PM hour to AM hour
					if (currentHour >= 12)
						newHour = currentHour - 12;
					else
						newHour = currentHour; // Already AM
				}
				else // PM selected
				{
					// Convert AM hour to PM hour
					if (currentHour < 12)
						newHour = currentHour + 12;
					else
						newHour = currentHour; // Already PM
				}

				dateTimePicker1.Value = new DateTime(year, currentDate.Month, currentDate.Day, newHour, currentDate.Minute, currentDate.Second);
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error updating AM/PM: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void UpdateYear()
		{
			try
			{
				if (!string.IsNullOrEmpty(textBox1.Text))
				{
					var currentDate = dateTimePicker1.Value;
					var year = int.Parse(textBox1.Text);
					
					// Handle leap year for February 29th
					var day = currentDate.Day;
					if (currentDate.Month == 2 && day == 29 && !DateTime.IsLeapYear(year))
					{
						day = 28;
					}
					
					dateTimePicker1.Value = new DateTime(year, currentDate.Month, day, currentDate.Hour, currentDate.Minute, currentDate.Second);
					UpdateDateTimeFormat();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error updating year: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		public DateTime SelectedDateTime
		{
			get { return dateTimePicker1.Value; }
			set { 
				dateTimePicker1.Value = value; 
				textBox1.Text = value.Year.ToString();
				HighlightCurrentSelections(); // Highlight buttons based on the new value
				UpdateDateTimeFormat();
			}
		}

		private void frmCustomDateTimePicker_Load(object sender, EventArgs e)
		{
			try
			{
				// Initialize the year textbox with current year from dateTimePicker1
				textBox1.Text = DateTime.Now.Year.ToString();
				
				// Set dateTimePicker1 to current date/time
				dateTimePicker1.Value = DateTime.Now;
				
				// Add TextChanged event for year textbox
				textBox1.TextChanged += (s, ev) => UpdateYear();

				// **IMPORTANT: Highlight current selections including AM/PM**
				HighlightCurrentSelections();
				
				// Apply the custom format
				UpdateDateTimeFormat();
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error initializing form: {ex.Message}", "Initialization Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void button65_Click(object sender, EventArgs e)
		{
			try
			{
				if (textBox1.Text.IsNullOrEmpty())
				{
					this.Close();
				}
				else
				{
					// Update the public DT property with the selected date/time
					
					DT = dateTimePicker1.Value;

					// Set the dialog result to OK
					this.DialogResult = DialogResult.OK;

					// Close the form
					this.Close();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Error in OK button click: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void textBox1_MouseClick(object sender, MouseEventArgs e)
		{
			Numpad numpad = new Numpad(textBox1.Text);
			numpad.ShowDialog();
		
				textBox1.Text = numpad.NumpadValue;
				UpdateYear(); // Update the year based on the new value
		}
	}
}

