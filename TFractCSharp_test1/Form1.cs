using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TFractCSharp_test1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            /*TFract f1 = new TFract(2, 5);
            TFract f2 = new TFract(3, 6);
            TFract f3;
            f3 = (f1 + f2).Reduce();

            textBoxResult.Text = f3.ToString();*/

            /*TFract f1 = new TFract(3, 5);
            TFract f2 = new TFract(3, 2);

            if (f1 > f2) { textBoxResult.Text = f1.ToString() + " is bigger"; };
            if (f1 < f2) { textBoxResult.Text = f2.ToString() + " is bigger"; };*/

            /*try
            {
                TFract f2 = new TFract(3, 0);
            }
            catch(TFractException ex)
            {
                textBoxResult.Text = ex.Message;
            }*/

            /*TFract f1 = new TFract(1, 2);
            TFract f2 = new TFract(2, 3);
            TFract f3 = new TFract(3, 4);
            TFract f4 = new TFract(4, 5);
            TFract f5 = f1 - f2 - f3 - f4;

            textBoxResult.Text = f5.Reduce().ToFloat().ToString();*/

            try
            {
                TFract A = new TFract(Int32.Parse(tBf1_num.Text), Int32.Parse(tBf1_den.Text));
                TFract B = new TFract(Int32.Parse(tBf2_num.Text), Int32.Parse(tBf2_den.Text));
                TFract C;

                if(comboBoxOperation.Text == "+")
                {
                    C = A + B;
                    ResultShowCalc(A, B, C, textBoxResult, comboBoxOperation);
                }

                else

                if (comboBoxOperation.Text == "-")
                {
                    C = A - B;
                    ResultShowCalc(A, B, C, textBoxResult, comboBoxOperation);
                }

                else

                if (comboBoxOperation.Text == "*")
                {
                    C = A * B;
                    ResultShowCalc(A, B, C, textBoxResult, comboBoxOperation);
                }

                else

                if (comboBoxOperation.Text == "/")
                {
                    C = A / B;
                    ResultShowCalc(A, B, C, textBoxResult, comboBoxOperation);
                }

                else

                if (comboBoxOperation.Text == "<")
                {
                    bool r;
                    r = A < B;
                    ResultShowEqual(A, B, r, textBoxResult, comboBoxOperation);
                }

                else

                if (comboBoxOperation.Text == ">")
                {
                    bool r;
                    r = A > B;
                    ResultShowEqual(A, B, r, textBoxResult, comboBoxOperation);
                }

                else

                if (comboBoxOperation.Text == "<=")
                {
                    bool r;
                    r = A <= B;
                    ResultShowEqual(A, B, r, textBoxResult, comboBoxOperation);
                }

                else

                if (comboBoxOperation.Text == ">=")
                {
                    bool r;
                    r = A >= B;
                    ResultShowEqual(A, B, r, textBoxResult, comboBoxOperation);
                }

                else

                if (comboBoxOperation.Text == "=")
                {
                    bool r;
                    r = (A == B);
                    ResultShowEqual(A, B, r, textBoxResult, comboBoxOperation);
                }

            }
            catch(Exception ex)
            {
                textBoxResult.Text += ex.Message + '\r' + '\n' + '\r' + '\n';
            }
        }

        private void tBf1_num_Click(object sender, EventArgs e)
        {
            if (tBf1_num.Text != null)
            {
                tBf1_num.SelectAll();
            }
        }

        private void tBf1_den_Click(object sender, EventArgs e)
        {
            if (tBf1_den.Text != null)
            {
                tBf1_den.SelectAll();
            }
        }

        private void tBf2_num_Click(object sender, EventArgs e)
        {
            if (tBf2_num.Text != null)
            {
                tBf2_num.SelectAll();
            }
        }

        private void tBf2_den_Click(object sender, EventArgs e)
        {
            if (tBf2_den.Text != null)
            {
                tBf2_den.SelectAll();
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxResult.Clear();

            tBf1_num.Text = "1"; tBf1_den.Text = "2";
            tBf2_num.Text = "1"; tBf2_den.Text = "42";            
        }

        private void buttonToFile_Click(object sender, EventArgs e)
        {
            saveAsOwnTextFormat("test.txt", textBoxResult.Text);
        }




        public void ResultShowCalc(TFract A, TFract B, TFract C, TextBox tR, ComboBox cO)
        {
            tR.Text += A.ToString() + " " + cO.Text + " " + B.ToString()
         + " = " + C.ToString()
         + " = " + C.Reduce().ToString()
         + " = " + C.ToFloat().ToString()
         + '\r' + '\n'
         + '\r' + '\n';
        }

        public void ResultShowEqual(TFract A, TFract B, bool C, TextBox tR, ComboBox cO)
        {
            tR.Text += A.ToString() + " " + cO.Text + " " + B.ToString()
         + " is " + C.ToString()
         + '\r' + '\n'
         + '\r' + '\n';
        }

        private void saveAsOwnTextFormat(string filename, string textToSave)
        {
            try
            {
                //Создаём или перезаписываем существующий файл
                StreamWriter sw = File.CreateText(filename);
                //Записываем текст в поток файла
                sw.WriteLine(textToSave);
                //Закрываем файл
                sw.Close();
            }
            catch (Exception ex) //Хэндлим ошибки
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}


