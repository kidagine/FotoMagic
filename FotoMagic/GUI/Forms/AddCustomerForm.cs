using FotoMagic.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FotoMagic
{
    public partial class AddCustomerForm : Form
    {
        private MainModel model;
        private readonly string placeholderFirstName = "Enter the customer's first name";
        private readonly string placeholderLastName = "Enter the customer's last name";
        private readonly string errorEmptyTextField = "You have to fill both fields";
        private bool canAddCustomer;
        

        public AddCustomerForm()
        {
            InitializeComponent();
            model = MainModel.CreateInstance();
            txbCustomerFirstName.Multiline = true;
            txbCustomerFirstName.MinimumSize = new Size(384, 45);
            txbCustomerFirstName.Size = new Size(384, 45);
            txbCustomerFirstName.Multiline = false;
            txbCustomerLastName.Multiline = true;
            txbCustomerLastName.MinimumSize = new Size(384, 45);
            txbCustomerLastName.Size = new Size(384, 45);
            txbCustomerLastName.Multiline = false;
            
        }

        private void TxbCustomerFirstName_Enter(object sender, EventArgs e)
        {
            if (txbCustomerFirstName.Text.Equals(placeholderFirstName))
            {
                txbCustomerFirstName.Text = "";
                txbCustomerFirstName.ForeColor = Color.FromArgb(45, 45, 45);
            }
        }

        private void TxbCustomerLastName_Enter(object sender, EventArgs e)
        {
            if (txbCustomerLastName.Text.Equals(placeholderLastName))
            {
                txbCustomerLastName.Text = "";
                txbCustomerLastName.ForeColor = Color.FromArgb(45, 45, 45);
            }
        }

        private void TxbCustomerFirstName_Leave(object sender, EventArgs e)
        {
            if (txbCustomerFirstName.Text.Trim().Equals(""))
            {
                txbCustomerFirstName.Text = placeholderFirstName;
                txbCustomerFirstName.ForeColor = Color.FromArgb(126, 126, 126);
            }
        }

        private void TxbCustomerLastName_Leave(object sender, EventArgs e)
        {
            if (txbCustomerLastName.Text.Trim().Equals(""))
            {
                txbCustomerLastName.Text = placeholderLastName;
                txbCustomerLastName.ForeColor = Color.FromArgb(126, 126, 126);
            }
        }

        private void TxbCustomerFirstName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txbCustomerLastName.Focus();
            }

        }

        private void TxbCustomerLastName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txbCustomerFirstName.Text.Equals("") || (txbCustomerFirstName.Text.ToLower().Equals(placeholderFirstName)))
                {
                    txbCustomerFirstName.Focus();
                    lblError.Visible = true;
                    lblError.Text = errorEmptyTextField;
                    rctBlueFirst.FillColor = Color.FromArgb(255, 81, 48);
                    rctBlueFirst.BorderColor = Color.FromArgb(255, 81, 48);
                }
                else if (txbCustomerLastName.Text.Equals("") || (txbCustomerLastName.Text.ToLower().Equals(placeholderLastName)))
                {
                    txbCustomerLastName.Focus();
                    lblError.Visible = true;
                    lblError.Text = errorEmptyTextField;
                    rctBlueLast.FillColor = Color.FromArgb(255, 81, 48);
                    rctBlueLast.BorderColor = Color.FromArgb(255, 81, 48);
                }
                else
                {
                    Regex regex = new Regex("^[a-zA-Z ']*$");
                    if (!regex.IsMatch(txbCustomerFirstName.Text))
                    {
                        txbCustomerFirstName.Focus();
                    }
                    else if (!regex.IsMatch(txbCustomerLastName.Text))
                    {
                        txbCustomerLastName.Focus();
                    }
                    else
                    {
                        ConfirmCustomer();
                    }
                }
            }
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            ConfirmCustomer();
        }

        private void ConfirmCustomer()
        {
            if (canAddCustomer)
            {
                if (!txbCustomerFirstName.Text.Equals("") && !txbCustomerLastName.Text.Equals(""))
                {
                    string firstName = txbCustomerFirstName.Text.Trim();
                    string lastName = txbCustomerLastName.Text.Trim();
                    float owedMoney = 0.0f;
                    model.CreateCustomer(firstName, lastName, owedMoney);
                    this.Hide();
                }
            }
            else
            {
                if (txbCustomerFirstName.Text.Equals("") || txbCustomerLastName.Text.Equals("") || txbCustomerFirstName.Text.Equals(placeholderFirstName) || txbCustomerFirstName.Text.Equals(placeholderLastName))
                {
                    lblError.Visible = true;
                    lblError.Text = "The name has to contain letters";
                }
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void TxbCustomerFirstName_TextChanged(object sender, EventArgs e)
        {
            TextBoxToProperCase(txbCustomerFirstName);
            Regex regex = new Regex("^[a-zA-Z ']*$");
            if (!regex.IsMatch(txbCustomerFirstName.Text))
            {
                canAddCustomer = false;
                lblError.Visible = true;
                lblError.Text = "The name cannot contain numbers or symbols.";
                rctBlueFirst.FillColor = Color.FromArgb(255, 81, 48);
                rctBlueFirst.BorderColor = Color.FromArgb(255, 81, 48);
            }
            else
            {
                rctBlueFirst.FillColor = Color.FromArgb(29, 155, 243);
                rctBlueFirst.BorderColor = Color.FromArgb(29, 155, 243);
                if (lblError.Text.Equals(errorEmptyTextField))
                {
                    lblError.Text = "The name cannot contain numbers or symbols.";
                }
                if (regex.IsMatch(txbCustomerLastName.Text))
                {
                    canAddCustomer = true;
                    lblError.Visible = false;
                    lblError.Text = "";
                }
            }
        }

        private void TxbCustomerLastName_TextChanged(object sender, EventArgs e)
        {
            TextBoxToProperCase(txbCustomerLastName);
            Regex regex = new Regex("^[a-zA-Z ']*$");
            if (!regex.IsMatch(txbCustomerLastName.Text))
            {
                canAddCustomer = false;
                lblError.Visible = true;
                lblError.Text = "The name cannot contain numbers or symbols.";
                rctBlueLast.FillColor = Color.FromArgb(255, 81, 48);
                rctBlueLast.BorderColor = Color.FromArgb(255, 81, 48);
            }
            else
            {
                rctBlueLast.FillColor = Color.FromArgb(29, 155, 243);
                rctBlueLast.BorderColor = Color.FromArgb(29, 155, 243);
                if (lblError.Text.Equals(errorEmptyTextField))
                {
                    lblError.Text = "The name cannot contain numbers or symbols.";
                }
                if (regex.IsMatch(txbCustomerFirstName.Text))
                {
                    canAddCustomer = true;
                    lblError.Visible = false;
                    lblError.Text = "";
                }
            }
        }

        private void TextBoxToProperCase(TextBox textBox)
        {
            if (!textBox.Text.Equals(""))
            {
                char[] v = textBox.Text.ToCharArray();
                string s = v[0].ToString().ToUpper();
                for (int b = 1; b < v.Length; b++)
                    s += v[b].ToString().ToLower();
                textBox.Text = s;
                textBox.Select(textBox.Text.Length, 0);
            }
        }

        private void TxbCustomerFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (e.KeyChar == (char)Keys.Space);
        }

        private void TxbCustomerLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (e.KeyChar == (char)Keys.Space);
        }
    }
}
