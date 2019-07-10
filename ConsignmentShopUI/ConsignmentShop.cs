using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsignmentShopLibrary;


namespace ConsignmentShopUI
{
    public partial class ConsignmentShop : Form
    {
        private Store store = new Store();
        private List<Item> shoppingCartData = new List<Item>();
        BindingSource itemsBinding = new BindingSource();
        BindingSource cartBinding = new BindingSource();
        BindingSource vendorBinding = new BindingSource();
        private decimal storeProfite = 0;
        
        public ConsignmentShop()
        {
            InitializeComponent();
            SetUpData();

            itemsBinding.DataSource = store.Items.Where(x => x.Sold == false).ToList();
            itemsListbox.DataSource = itemsBinding;

            itemsListbox.DisplayMember = "Display";
            itemsListbox.ValueMember = "Display";

            cartBinding.DataSource = shoppingCartData;
            ShoppingCartListBox.DataSource = cartBinding;

            ShoppingCartListBox.DisplayMember = "Display";
            ShoppingCartListBox.ValueMember = "Display";

            vendorBinding.DataSource = store.Vendors;
            VendorListBox.DataSource = vendorBinding;

            VendorListBox.DisplayMember = "Display";
            VendorListBox.ValueMember = "Display";

            cartBinding.ResetBindings(false);
            
        }

        private void SetUpData()
        {
            Vendor demo = new Vendor();
            demo.FirstName = "Smith";
            demo.LastName = "Corey";
            //demo.Commission = .5;

            demo = new Vendor();
            demo.FirstName = "Jack";
            demo.LastName = "Honey";
            //demo.Commission = .5;

            demo = new Vendor();
            demo.FirstName = "Kamal";
            demo.LastName = "Ouhmad";

            store.Vendors.Add(demo);

            //store.Vendors.Add(new Vendor { FirstName = "Smith", LastName = " Corey" });

            store.Items.Add(new Item { Title = "Moby Dick",
                                       Description = "About A Whale",
                                       Price = 4.50M,
                                       Owner = store.Vendors[0] });
            store.Items.Add(new Item { Title = " Antigone",
                                       Description = "Love story",
                                       Price = 3.8M,
                                       Owner = store.Vendors[0] });
            store.Items.Add(new Item { Title = "Jane Eyre",
                                       Description = "A book about a girl",
                                       Price = 1.50M ,
                                       Owner = store.Vendors[0] });

            store.Name = "Seconds Are Better";
        }

        private void AddtoCart_Click(object sender, EventArgs e)
        {
            Item SelectedItem = (Item)itemsListbox.SelectedItem;

            shoppingCartData.Add(SelectedItem);

        }

        private void MakePurchase_Click(object sender, EventArgs e)
        {
            foreach(Item item in shoppingCartData)
            {
                item.Sold = true;
                item.Owner.PaymentDue += (decimal)item.Owner.Commission * item.Price;
                storeProfite += (1 - (decimal)item.Owner.Commission) * item.Price;
            }

            shoppingCartData.Clear();

            itemsBinding.DataSource = store.Items.Where(x => x.Sold == false).ToList();

            storeProfiteValue.Text = string.Format("${0}", storeProfite);
            itemsBinding.ResetBindings(false);
            cartBinding.ResetBindings(false);
            vendorBinding.ResetBindings(false);


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
