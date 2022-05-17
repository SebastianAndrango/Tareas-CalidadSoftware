using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea1
{
    class CTriangle
    {
        private int mA, mB, mC;
        private string mTypeTriangle;

        public CTriangle()
        {
            InitializeData();
        }

        public void InitializeData()
        {
            mA = 0; mB = 0; mC = 0; mTypeTriangle = "";
        }

        public void InitializeData(TextBox txtSideA,
                                   TextBox txtSideB,
                                   TextBox txtSideC,
                                   TextBox txtTypeTriangle
                                  )
        {

            
            mA = 0; mB = 0; mC = 0; mTypeTriangle = "";

            
            txtSideA.Text = "";// las comillas dobles es equivalente a (BLANK)
            txtSideB.Text = "";
            txtSideC.Text = "";
            txtTypeTriangle.Text = "";
          
            txtSideA.Focus();
        }

        public void ReadData(TextBox txtSideA, TextBox txtSideB, TextBox txtSideC)
        {
            if(String.IsNullOrWhiteSpace(txtSideA.Text))
            {
                MessageBox.Show("No se han ingresado todos los datos", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                mA = int.Parse(txtSideA.Text);
            }

            if (String.IsNullOrWhiteSpace(txtSideB.Text))
            {
                MessageBox.Show("No se han ingresado todos los datos", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                mB = int.Parse(txtSideB.Text);
            }

            if (String.IsNullOrWhiteSpace(txtSideC.Text))
            {
                MessageBox.Show("No se han ingresado todos los datos", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                mC = int.Parse(txtSideC.Text);
            }

            

          


        }

        public void TypeTriangle(TextBox txtTypeTriangle)
        {
            if (mA == mB && mB == mC)
            {
                mTypeTriangle = "Triángulo Equilatero";
                txtTypeTriangle.Text = mTypeTriangle;
            }
            else if (mA == mC || mA == mB || mB == mC)
            {
                mTypeTriangle = "Triángulo Isosceles";
                txtTypeTriangle.Text = mTypeTriangle;
            }
            else
            {
                mTypeTriangle = "Triángulo Escaleno";
                txtTypeTriangle.Text = mTypeTriangle;
            } 
               
        }
        public bool CheckTriangle()
        {
            if ((mA + mB > mC) && (mA + mC > mB) && (mB + mC > mA))
            {
                return (true);
            }
            else 
            {
                return (false);
            }
        }

        public bool CheckBlank(TextBox txtSideA,
                                   TextBox txtSideB,
                                   TextBox txtSideC)
        {
            if (txtSideA.Text == "" || txtSideB.Text == "" || txtSideC.Text == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
