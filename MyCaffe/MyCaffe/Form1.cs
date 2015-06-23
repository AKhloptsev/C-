using System;
using System.Linq;
using System.Windows.Forms;

namespace MyCaffe
{
    public partial class Form1 : Form
    {
        private Beverage beverage;

        public Form1()
        {
            InitializeComponent();
        }

        // to order
        private void toOrderButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ваш заказ на сумму: " + beverage.Cost().ToString() + "грн. Вы заказали: " + beverage.GetDescription(), "Спасибо за заказ", MessageBoxButtons.OK);
        }

        // add any additives
        private void buttonForBeverageAdditivesAdd_Click(object sender, EventArgs e)
        {
            if (this.radioButtonForCoffee.Checked)
                beverage = new Coffee();
            if (this.radioButtonForEspresso.Checked)
                beverage = new Espresso();
            if (this.radioButtonForLatte.Checked)
                beverage = new Latte();
            if (this.radioButtonForMineralWater.Checked)
                beverage = new MineralWater();
            if (this.radioButtonForBlackTea.Checked)
                beverage = new BlackTea();
            if (this.radioButtonForGreenTea.Checked)
                beverage = new GreenTea();
            foreach (var cb in this.Controls.OfType<CheckBox>())
            {
                if (cb.Checked)
                {
                    switch (cb.Name)
                    {
                        case "checkBoxForSugar":
                            beverage = new Sugar(beverage);
                            break;

                        case "checkBoxForMilk":
                            beverage = new Milk(beverage);
                            break;

                        case "checkBoxForCream":
                            beverage = new Cream(beverage);
                            break;

                        case "checkBoxForCinnamon":
                            beverage = new Cinnamon(beverage);
                            break;

                        case "checkBoxForMapleSyrup":
                            beverage = new MapleSyrup(beverage);
                            break;
                    }
                }
            }

            foreach (var cb in this.Controls.OfType<CheckBox>())
            {
                if (cb.Checked)
                    cb.Checked = !cb.Checked;
            }
            foreach (var rb in this.Controls.OfType<RadioButton>())
            {
                if (rb.Checked)
                    rb.Checked = !rb.Checked;
            }
        }

        private void radioButtonForTea_CheckedChanged(object sender, EventArgs e)
        {
            this.radioButtonForBlackTea.Checked = true;
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButtonForCoffee.Checked)
                beverage = new Coffee();
            if (this.radioButtonForEspresso.Checked)
                beverage = new Espresso();
            if (this.radioButtonForLatte.Checked)
                beverage = new Latte();
            if (this.radioButtonForMineralWater.Checked)
                beverage = new MineralWater();
            if (this.radioButtonForBlackTea.Checked)
                beverage = new BlackTea();
            if (this.radioButtonForGreenTea.Checked)
                beverage = new GreenTea();
        }
    }
}