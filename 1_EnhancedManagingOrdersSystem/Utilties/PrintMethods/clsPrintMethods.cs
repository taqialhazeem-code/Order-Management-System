using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2_BussinessLayer;

namespace _1_EnhancedManagingOrdersSystem.Utilties.PrintMethods
{
	public class clsPrintMethods
	{

		

		public static void PrintQuantityReportIn80mmThermalPrinter(DateTime from, DateTime to)
		{
			try
			{
				DataTable dt = clsOrdersBussiness.GetProductQuantitiesByDateRange(from, to);

				if (dt == null || dt.Rows.Count == 0)
				{
					MessageBox.Show("لا توجد بيانات لطباعتها في هذه الفترة", "تنبيه",
						MessageBoxButtons.OK, MessageBoxIcon.Information);
					return;
				}

				PrintDocument printDoc = new PrintDocument();
				printDoc.DefaultPageSettings.PaperSize = new PaperSize("80mm", 315, 600);
				printDoc.DefaultPageSettings.Margins = new Margins(0, 0, 0, 0);

				int currentRowIndex = 0;
				int currentPage = 1;

				printDoc.PrintPage += (sender, e) =>
				{
					Graphics g = e.Graphics;
					int currentY = 20;
					int leftMargin = 10;
					int lineHeight = 25;
					int pageWidth = e.PageBounds.Width - 20;

					Font headerFont = new Font("Tahoma", 11, FontStyle.Bold);
					Font subHeaderFont = new Font("Tahoma", 8, FontStyle.Regular);
					Font tableHeaderFont = new Font("Tahoma", 9, FontStyle.Bold);
					Font rowFont = new Font("Tahoma", 8, FontStyle.Regular);
					Font footerFont = new Font("Tahoma", 7, FontStyle.Regular);

					StringFormat centerFormat = new StringFormat
					{
						Alignment = StringAlignment.Center,
						FormatFlags = StringFormatFlags.DirectionRightToLeft
					};

					StringFormat rightFormat = new StringFormat
					{
						Alignment = StringAlignment.Far,
						FormatFlags = StringFormatFlags.DirectionRightToLeft
					};

					// العنوان
					g.DrawString("تقرير كميات المنتجات", headerFont, Brushes.Black,
						new RectangleF(leftMargin, currentY, pageWidth, lineHeight), centerFormat);
					currentY += lineHeight + 10;

					// الفترة الزمنية
					g.DrawString($"من: {from:yyyy/MM/dd hh:mm tt}", subHeaderFont, Brushes.Black,
						new RectangleF(leftMargin, currentY, pageWidth, lineHeight), rightFormat);
					currentY += lineHeight - 5;

					g.DrawString($"إلى: {to:yyyy/MM/dd hh:mm tt}", subHeaderFont, Brushes.Black,
						new RectangleF(leftMargin, currentY, pageWidth, lineHeight), rightFormat);
					currentY += lineHeight + 5;

					// خط فاصل
					g.DrawLine(Pens.Black, leftMargin, currentY, leftMargin + pageWidth, currentY);
					currentY += 10;

					// رؤوس الأعمدة
					int col1Width = (int)(pageWidth * 0.7);
					int col2Width = (int)(pageWidth * 0.3);

					g.DrawString("اسم المنتج", tableHeaderFont, Brushes.Black,
						new RectangleF(leftMargin + col2Width, currentY, col1Width, lineHeight), rightFormat);
					g.DrawString("الكمية", tableHeaderFont, Brushes.Black,
						new RectangleF(leftMargin, currentY, col2Width, lineHeight), centerFormat);

					currentY += lineHeight;
					g.DrawLine(Pens.Black, leftMargin, currentY, leftMargin + pageWidth, currentY);
					currentY += 8;

					// البيانات
					int rowsPerPage = 20;
					int rowsPrinted = 0;

					while (currentRowIndex < dt.Rows.Count && rowsPrinted < rowsPerPage)
					{
						DataRow row = dt.Rows[currentRowIndex];
						string productName = row["اسم المنتج"]?.ToString() ?? "";
						string totalQty = row["اجمالي_الكميه"]?.ToString() ?? "0";

						if (productName.Length > 25)
							productName = productName.Substring(0, 22) + "...";

						g.DrawString(productName, rowFont, Brushes.Black,
							new RectangleF(leftMargin + col2Width, currentY, col1Width, lineHeight), rightFormat);
						g.DrawString(totalQty, rowFont, Brushes.Black,
							new RectangleF(leftMargin, currentY, col2Width, lineHeight), centerFormat);

						currentY += lineHeight;
						currentRowIndex++;
						rowsPrinted++;
					}

					// خط فاصل نهائي
					currentY += 5;
					g.DrawLine(Pens.Black, leftMargin, currentY, leftMargin + pageWidth, currentY);
					currentY += 10;

					// الإجماليات في الصفحة الأخيرة
					if (currentRowIndex >= dt.Rows.Count)
					{
						int grandTotal = 0;
						foreach (DataRow row in dt.Rows)
						{
							if (int.TryParse(row["اجمالي_الكميه"]?.ToString(), out int qty))
								grandTotal += qty;
						}

						g.DrawString($"إجمالي الأصناف: {dt.Rows.Count}", tableHeaderFont, Brushes.Black,
							new RectangleF(leftMargin, currentY, pageWidth, lineHeight), rightFormat);
						currentY += lineHeight;

						g.DrawString($"إجمالي الكميات: {grandTotal}", tableHeaderFont, Brushes.Black,
							new RectangleF(leftMargin, currentY, pageWidth, lineHeight), rightFormat);
						currentY += lineHeight + 10;
					}

					// معلومات الصفحة
					g.DrawString($"صفحة {currentPage}", footerFont, Brushes.Black,
						new RectangleF(leftMargin, currentY, pageWidth / 2, lineHeight), rightFormat);
					g.DrawString($"{DateTime.Now:yyyy/MM/dd HH:mm}", footerFont, Brushes.Black,
						new RectangleF(leftMargin + pageWidth / 2, currentY, pageWidth / 2, lineHeight), rightFormat);

					e.HasMorePages = currentRowIndex < dt.Rows.Count;
					if (e.HasMorePages) currentPage++;

					// تحرير الموارد
					headerFont.Dispose();
					subHeaderFont.Dispose();
					tableHeaderFont.Dispose();
					rowFont.Dispose();
					footerFont.Dispose();
				};

				printDoc.Print();
			}
			catch (Exception ex)
			{
				MessageBox.Show($"خطأ في الطباعة: {ex.Message}", "خطأ",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		public static void PrintOrderDetailsOn80mmThermalPrinter(int orderId)
		{
			try
			{
				// إعلان متغيرات لحفظ معلومات الطلب
				string customerName = "", customerPhone = "", deliveryLocation = "", notes = "";
				DateTime orderDate = DateTime.MinValue, deliveryDate = DateTime.MinValue;
				int orderStatus = 0;
				bool mortgageStatus = false;
				decimal mortgagePaid = 0, productsPaid = 0, totalPaid = 0, totalRequired = 0;
				decimal requiredMortgage = 0, requiredProducts = 0;
				DataTable orderDetails = new DataTable();

				// استخراج جميع معلومات الطلب
				if (!clsOrdersBussiness.GetOrderInfo(orderId, ref customerName, ref customerPhone, ref deliveryLocation, ref notes,
					ref orderDate, ref deliveryDate, ref orderStatus, ref mortgageStatus, ref mortgagePaid, ref productsPaid,
					ref totalPaid, ref totalRequired, ref requiredMortgage, ref requiredProducts, ref orderDetails))
				{
					MessageBox.Show("تعذر العثور على الطلب المطلوب.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				if (orderDetails == null || orderDetails.Rows.Count == 0)
				{
					MessageBox.Show("لا توجد تفاصيل منتجات لهذا الطلب.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
					return;
				}

				PrintDocument printDoc = new PrintDocument();
				printDoc.DefaultPageSettings.PaperSize = new PaperSize("80mm", 315, 1200);
				printDoc.DefaultPageSettings.Margins = new Margins(0, 0, 0, 0);

				int currentRowIndex = 0;

				printDoc.PrintPage += (sender, e) =>
				{
					Graphics g = e.Graphics;
					float yPos = 15f;
					int leftMargin = 2;
					int rightMargin = 2;
					// تقليل عرض النص بمقدار 1 سم (حوالي 38 بكسل)
					int pageWidth = e.PageBounds.Width - (leftMargin + rightMargin) - 38;
					float lineHeight = 18f;

					// تعريف الخطوط
					Font titleFont = new Font("Tahoma", 11, FontStyle.Bold);
					Font headerFont = new Font("Tahoma", 9, FontStyle.Bold);
					Font bodyFont = new Font("Tahoma", 8, FontStyle.Regular);
					Font smallFont = new Font("Tahoma", 7, FontStyle.Regular);
					Font footerFont = new Font("Tahoma", 6, FontStyle.Italic);

					// تنسيق النصوص للمحاذاة اليمنى
					StringFormat centerFormat = new StringFormat
					{
						Alignment = StringAlignment.Center
					};
					StringFormat rightFormat = new StringFormat
					{
						Alignment = StringAlignment.Far
					};

					// === رأس الفاتورة ===
					g.DrawString("فاتورة طلب", titleFont, Brushes.Black, new RectangleF(leftMargin, yPos, pageWidth, 25), centerFormat);
					yPos += 35;

					// معلومات الطلب الأساسية - محاذاة يمنى
					g.DrawString($"رقم الطلب: {orderId}", bodyFont, Brushes.Black, new RectangleF(leftMargin, yPos, pageWidth, lineHeight), rightFormat);
					yPos += lineHeight;
					g.DrawString($"تاريخ الطلب: {orderDate:yyyy/MM/dd hh:mm tt}", bodyFont, Brushes.Black, new RectangleF(leftMargin, yPos, pageWidth, lineHeight), rightFormat);
					yPos += lineHeight;
					g.DrawString($"تاريخ التسليم: {deliveryDate:yyyy/MM/dd hh:mm tt}", bodyFont, Brushes.Black, new RectangleF(leftMargin, yPos, pageWidth, lineHeight), rightFormat);
					yPos += lineHeight;

					// حالة الطلب
					string statusText = orderStatus == 0 ? "قيد التسليم" : orderStatus == 1 ? "مكتمل" : "ملغي";
					g.DrawString($"حالة الطلب: {statusText}", bodyFont, Brushes.Black, new RectangleF(leftMargin, yPos, pageWidth, lineHeight), rightFormat);
					yPos += lineHeight + 5;

					// معلومات العميل
					g.DrawString("معلومات العميل:", headerFont, Brushes.Black, new RectangleF(leftMargin, yPos, pageWidth, lineHeight), rightFormat);
					yPos += lineHeight;
					g.DrawString($"الاسم: {customerName}", bodyFont, Brushes.Black, new RectangleF(leftMargin, yPos, pageWidth, lineHeight), rightFormat);
					yPos += lineHeight;
					g.DrawString($"الهاتف: {customerPhone}", bodyFont, Brushes.Black, new RectangleF(leftMargin, yPos, pageWidth, lineHeight), rightFormat);
					yPos += lineHeight;
					g.DrawString($"مكان التوصيل: {deliveryLocation}", bodyFont, Brushes.Black, new RectangleF(leftMargin, yPos, pageWidth, lineHeight), rightFormat);
					yPos += lineHeight + 10;

					// === جدول المنتجات ===
					g.DrawLine(Pens.Black, leftMargin, yPos, leftMargin + pageWidth, yPos);
					yPos += 5;

					// تعريف عروض الأعمدة
					int priceColWidth = 42; // تقليل قليل بسبب زيادة التضييق
					int qtyColWidth = 52;   // تقليل قليل بسبب زيادة التضييق
					int productColWidth = pageWidth - priceColWidth - qtyColWidth - 5; // مساحة أمان صغيرة

					// مواضع الأعمدة من اليمين إلى اليسار: المنتج، الكمية، السعر
					int priceColX = leftMargin; // السعر في أقصى اليسار
					int qtyColX = priceColX + priceColWidth; // الكمية في الوسط
					int productColX = qtyColX + qtyColWidth; // المنتج في اليمين

					// رؤوس الأعمدة - ترتيب من اليمين لليسار
					g.DrawString("المنتج", headerFont, Brushes.Black, new RectangleF(productColX, yPos, productColWidth, 18), rightFormat);
					g.DrawString("الكمية", headerFont, Brushes.Black, new RectangleF(qtyColX, yPos, qtyColWidth, 18), rightFormat);
					g.DrawString("السعر", headerFont, Brushes.Black, new RectangleF(priceColX, yPos, priceColWidth, 18), rightFormat);
					yPos += 18;
					g.DrawLine(Pens.Black, leftMargin, yPos, leftMargin + pageWidth, yPos);
					yPos += 3;

					// بيانات المنتجات
					int itemsPerPage = 20;
					int itemsPrinted = 0;
					while (currentRowIndex < orderDetails.Rows.Count && itemsPrinted < itemsPerPage)
					{
						DataRow row = orderDetails.Rows[currentRowIndex];
						string productName = row["اسم المنتج"].ToString();
						if (productName.Length > 36) productName = productName.Substring(0, 13) + "..."; // تقليل قليل بسبب زيادة التضييق

						decimal unitPrice = Convert.ToDecimal(row["سعر الوحده"]);
						int quantity = Convert.ToInt32(row["الكميه"]);

						// طباعة البيانات مع المحاذاة اليمنى
						g.DrawString(productName, smallFont, Brushes.Black, new RectangleF(productColX, yPos, productColWidth, 16), rightFormat);
						g.DrawString(quantity.ToString(), smallFont, Brushes.Black, new RectangleF(qtyColX, yPos, qtyColWidth, 16), rightFormat);
						g.DrawString($"{unitPrice:F2}", smallFont, Brushes.Black, new RectangleF(priceColX, yPos, priceColWidth, 16), rightFormat);

						yPos += 16;
						currentRowIndex++;
						itemsPrinted++;
					}

					// === الإجماليات (في الصفحة الأخيرة فقط) ===
					if (currentRowIndex >= orderDetails.Rows.Count)
					{
						yPos += 5;
						g.DrawLine(Pens.Black, leftMargin, yPos, leftMargin + pageWidth, yPos);
						yPos += 10;

						// الملخص المالي - محاذاة يمنى
						g.DrawString($"قيمة المنتجات المطلوبة: {requiredProducts:F2}", bodyFont, Brushes.Black, new RectangleF(leftMargin, yPos, pageWidth, lineHeight), rightFormat);
						yPos += lineHeight;
						g.DrawString($"قيمة الرهن المطلوب: {requiredMortgage:F2}", bodyFont, Brushes.Black, new RectangleF(leftMargin, yPos, pageWidth, lineHeight), rightFormat);
						yPos += lineHeight;
						g.DrawString($"المبلغ الإجمالي المطلوب: {totalRequired:F2}", headerFont, Brushes.Black, new RectangleF(leftMargin, yPos, pageWidth, 20), rightFormat);
						yPos += 25;

						g.DrawLine(Pens.Gray, leftMargin, yPos, leftMargin + pageWidth, yPos);
						yPos += 8;

						g.DrawString($"المدفوع للمنتجات: {productsPaid:F2}", bodyFont, Brushes.Black, new RectangleF(leftMargin, yPos, pageWidth, lineHeight), rightFormat);
						yPos += lineHeight;
						g.DrawString($"المدفوع للرهن: {mortgagePaid:F2}", bodyFont, Brushes.Black, new RectangleF(leftMargin, yPos, pageWidth, lineHeight), rightFormat);
						yPos += lineHeight;
						g.DrawString($"إجمالي المدفوع: {totalPaid:F2}", headerFont, Brushes.Black, new RectangleF(leftMargin, yPos, pageWidth, 20), rightFormat);
						yPos += 25;

						// المبلغ المتبقي
						decimal remainingAmount = totalRequired - totalPaid;
						g.DrawString($"المبلغ المتبقي: {remainingAmount:F2}", headerFont, Brushes.Black, new RectangleF(leftMargin, yPos, pageWidth, 20), rightFormat);
						yPos += 30;

						// حالة الرهن
						string mortgageStatusText = mortgageStatus ? "مسترد" : "غير مسترد";
						g.DrawString($"حالة الرهن: {mortgageStatusText}", bodyFont, Brushes.Black, new RectangleF(leftMargin, yPos, pageWidth, lineHeight), rightFormat);
						yPos += 25;

						// الملاحظات
						if (!string.IsNullOrWhiteSpace(notes))
						{
							g.DrawString("ملاحظات:", headerFont, Brushes.Black, new RectangleF(leftMargin, yPos, pageWidth, 18), rightFormat);
							yPos += 18;

							// تقسيم الملاحظات لأسطر متعددة إذا كانت طويلة
							string[] noteLines = SplitTextToLines(notes, 30);
							foreach (string line in noteLines)
							{
								g.DrawString(line, smallFont, Brushes.Black, new RectangleF(leftMargin, yPos, pageWidth, 16), rightFormat);
								yPos += 16;
							}
							yPos += 10;
						}

						// تذييل الفاتورة
						g.DrawLine(Pens.Black, leftMargin, yPos, leftMargin + pageWidth, yPos);
						yPos += 8;
						g.DrawString("شكراً لتعاملكم معنا", footerFont, Brushes.Black, new RectangleF(leftMargin, yPos, pageWidth, 15), centerFormat);
						yPos += 15;
						g.DrawString($"طُبعت في: {DateTime.Now:yyyy/MM/dd hh:mm tt}", footerFont, Brushes.Black, new RectangleF(leftMargin, yPos, pageWidth, 15), centerFormat);
					}

					e.HasMorePages = currentRowIndex < orderDetails.Rows.Count;

					// تحرير الموارد
					titleFont.Dispose();
					headerFont.Dispose();
					bodyFont.Dispose();
					smallFont.Dispose();
					footerFont.Dispose();
				};

				printDoc.Print();
			}
			catch (Exception ex)
			{
				MessageBox.Show($"خطأ في طباعة تفاصيل الطلب: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		// دالة مساعدة لتقسيم النص إلى أسطر
		private static string[] SplitTextToLines(string text, int maxCharsPerLine)
		{
			if (string.IsNullOrEmpty(text)) return new string[0];

			List<string> lines = new List<string>();
			int currentIndex = 0;

			while (currentIndex < text.Length)
			{
				int endIndex = Math.Min(currentIndex + maxCharsPerLine, text.Length);
				string line = text.Substring(currentIndex, endIndex - currentIndex);
				lines.Add(line);
				currentIndex = endIndex;
			}

			return lines.ToArray();
		}

	}
}
