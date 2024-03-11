using System.Drawing.Text;

namespace ORDERING_SYSTEM_NI_TOM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        private double total;
        private double amount;
        private void totals()
        {
            double cantonPrice = 0;
            double drinkPrice = 0;

            try
            {
                drinkPrice = double.Parse(label6.Text);
            }
            catch { }

            try
            {
                cantonPrice = double.Parse(label5.Text);
            }
            catch { }
            total = cantonPrice + drinkPrice;
            double tax = total * 0.12;
            lbt.Text = tax.ToString("F2");
            lbtotal.Text = total.ToString();
        }

        private void cb1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cb1.Text)
            {
                case "NISSIN RAMEN CREAMY SEAFOOD":
                    label5.Text = "16";
                    break;
                case "SAMYANG CARBONARA HOT CHICKEN RAMEN":
                    label5.Text = "33";
                    break;
                case "LUCKY ME PANCIT CANTON CHILI-MANSI":
                    label5.Text = "33";
                    break;
                case "LUCKY ME PANCIT CANTON KALAMANSI":
                    label5.Text = "33";
                    break;
                case "NISSIN YAKISOBA SPICY CHICKEN":
                    label5.Text = "33";
                    break;
            }
            totals();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void cb2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cb2.Text)
            {
                case "ROYAL":
                    label6.Text = "13";
                    break;
                case "COCA-COLA":
                    label6.Text = "12";
                    break;
                case "SPRITE":
                    label6.Text = "14";
                    break;
                case "STING":
                    label6.Text = "22";
                    break;
                case "COBRA":
                    label6.Text = "19";
                    break;
                case "MOUNTAIN DEW":
                    label6.Text = "20";
                    break;
            }
            totals();
        }

        private void txtamount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                amount = double.Parse(txtamount.Text);
            }
            catch
            {
                amount = 0;
            }
            if (amount >= total)
            {
                bconfirm.Enabled = true;
            }
            else
            {
                bconfirm.Enabled = false;
            }
        }

        private void bvoid_Click(object sender, EventArgs e)
        {
            label5.Text = null;
            label6.Text = null;
            bconfirm.Enabled = false;
            cb1.Text = null;
            cb2.Text = null;
            txtamount.Text = null;
        }

        private void bconfirm_Click(object sender, EventArgs e)
        {
            double change = amount - total;
            label11.Text = change.ToString();
        }
    }
}
