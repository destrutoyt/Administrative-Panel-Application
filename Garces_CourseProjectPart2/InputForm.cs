using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Garces_CourseProjectPart2
{
    public partial class InputForm : Form
    {
        public InputForm()
        {
            InitializeComponent();
        }

        private void FirstNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Hide();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Hide();

        }

        private void titlelabel_NoUse_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void FirstNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void InputForm_Load(object sender, EventArgs e)
        {

        }

        private void HourlyRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (HourlyRadioButton.Checked)
            {
                //hide
                SalaryLabel.Visible = false;
                SalaryTextBox.Visible = false;

                //show
                HourlyPayTextBox.Visible = true;
                HourlyRateLabel.Visible = true;
                HoursWorkedLabel.Visible = true;
                HoursWorkedTextBox.Visible = true;
            }
        }

        private void SalaryRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (SalaryRadioButton.Checked)
            {
                //hide
                SalaryLabel.Visible = true;
                SalaryTextBox.Visible = true;

                //show
                HourlyPayTextBox.Visible = false;
                HourlyRateLabel.Visible = false;
                HoursWorkedLabel.Visible = false;
                HoursWorkedTextBox.Visible = false;
            }
        }
    }
}
