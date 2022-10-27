using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace WindowsFormsApp5
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void calcButton_Click(object sender, EventArgs e)
		{
			int firstNumber, secondNumber;

			//取得第一個數值
			try
			{
				firstNumber = GetFirstNumber();
			}catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
				return;
			}

			//取得第二個數值
			try
			{
				secondNumber = GetSecondNumber();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return;
			}

			//// 取得計算方式
			string operation;
			try
			{
				operation = GetOperation(); // +-*/
			}catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
				return;
			}

			//// 計算答案
			int result;
			try
			{
				result = Calc(firstNumber, secondNumber, operation);
				resultLabel.Text = result.ToString();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return;
			}

		}

		private int Calc(int firstNumber, int secondNumber, string operation)
		{
			switch (operation)
			{
				case "+":
					return firstNumber + secondNumber;
				case "-":
					return firstNumber - secondNumber;
				case "*":
					return firstNumber * secondNumber;
				case "/":
					return secondNumber==0
						? throw new Exception("兩數相除,分母不能為零") 
						:firstNumber / secondNumber;
			}

			throw new Exception($"不支援這個計算{operation}");
		}

		private int GetSecondNumber()
		{
			TextBox txt = secondNumberTextBox;
			string title = "第二個數字";

			return GetInt(txt, title);
		}

		private int GetFirstNumber()
		{
			TextBox txt = firstNumberTextBox;
			string title = "第一個數字";

			return GetInt(txt, title);
		}
		private int GetInt(TextBox control , string title)
		{
			string value = control.Text;
			bool isInt = int.TryParse(value, out int number);
			return isInt ? number : throw new Exception($"{title}必需填寫數值");
		}


		private string GetOperation()
		{
			ComboBox control = this.optionCboBox;
			object selectedItem = control.SelectedItem; // 若没選,是null

			return selectedItem!=null
					? selectedItem.ToString()
					: throw new Exception("請選擇計算方式");
		}
	}
}
