using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea1
{
    public partial class Tarea1 : Form
    {
        private CTriangle ObjCTriangle = new CTriangle();
        public Tarea1()
        {
            InitializeComponent();
        }

        private void Tarea1_Load(object sender, EventArgs e)
        {
            ObjCTriangle.InitializeData(txtSideA, txtSideB, txtSideC, txtTypeTriangle);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            bool check = false;
            ObjCTriangle.ReadData(txtSideA, txtSideB, txtSideC);
            check = ObjCTriangle.CheckTriangle();
            if (check == true)
            {

                ObjCTriangle.TypeTriangle(txtTypeTriangle);
            }
            else
            {
                MessageBox.Show("Error... el triangulo no existe ", "Mensaje de error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ObjCTriangle.InitializeData(txtSideA, txtSideB, txtSideC, txtTypeTriangle);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtTypeTriangle_KeyPress(object sender, KeyPressEventArgs e)
        {
            

        }

        private void txtSideA_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if((e.KeyChar >= 32 && e.KeyChar <= 48) || (e.KeyChar>=58 && e.KeyChar<=255))
            {
                MessageBox.Show("Solo se permiten números enteros positivos", "Advertencia", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtSideB_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if ((e.KeyChar >= 32 && e.KeyChar <= 48) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se permiten números enteros positivos", "Advertencia", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtSideC_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            if ((e.KeyChar >= 32 && e.KeyChar <= 48) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se permiten números enteros positivos", "Advertencia", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }

        }
    }
}

