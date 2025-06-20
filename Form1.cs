using System.Diagnostics;
using System.Text;
using System.Windows.Forms;
using static Restaurant_Management_System.Enums;


namespace Restaurant_Management_System
{
    public partial class Form1 : Form
    {
        // تعريف المتغيرات
        private Order currentOrder;  // لتخزين تفاصيل الطلب الحالي
        private SauceOption[] sauceOptions;  // لتخزين خيارات الصوص (Vanilla, Strawberry, إلخ)
        private object itemDetails;   
        private object[] category;  // لتخزين فئات المنتجات)

        // كونستركتور النموذج
        public Form1()
        {
            InitializeComponent();  // تهيئة المكونات
                                    // تهيئة خيارات الصوص مع الربط بين الاسم والـ RadioButton
            sauceOptions = new SauceOption[]
            {
            new SauceOption { Name = "Vanilla", RadioButton = radbtnVanilla },
            new SauceOption { Name = "Strawberry", RadioButton = radbtnStrawberry },
            new SauceOption { Name = "Chocolate", RadioButton = radbtnChocolate },
            new SauceOption { Name = "Blueberry", RadioButton = radbtnBlueberry }
            };
        }

        // تعريف الـ class الخاص بخيارات الصوص
        public class SauceOption
        {
            public string Name { get; set; }  // اسم الصوص
            public RadioButton RadioButton { get; set; }  // الـ RadioButton المتعلق بالصوص
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // ربط الـ ComboBox بالقيم من الـ Enum
            cmbCategory.DataSource = Enum.GetValues(typeof(Enums.Category));

            // تعيين العنصر الافتراضي إلى -1 (لا شيء مُختار)
            cmbCategory.SelectedIndex = -1;

            // إخفاء جميع الـ GroupBoxes في البداية
            groupbxFlavors.Visible = false;
            groupbxSauce.Visible = false;
            groupbxDrinksize.Visible = false;
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            // لو الـ ComboBox مش مختار حاجة (العنصر الافتراضي -1)، نخرج
            if (cmbCategory.SelectedIndex == -1) return;

            // ناخد الفئة اللي اختارها المستخدم
            Enums.Category selectedCategory = (Enums.Category)cmbCategory.SelectedItem;

            // نظهر الجروب المناسب ونخفي الباقي
            // لو اخترت Desserts، نظهر الـ Sauce
            groupbxSauce.Visible = selectedCategory == Enums.Category.Desserts;
            // لو اخترت Drinks، نظهر الـ Drinksize
            groupbxDrinksize.Visible = selectedCategory == Enums.Category.Drinks;
            // لو اخترت Appetizer أو Main Course، نظهر الـ Flavors
            groupbxFlavors.Visible = selectedCategory == Enums.Category.Appetizer || selectedCategory == Enums.Category.MainCourse;
        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {

            // 1. أول حاجة بنتأكد إن في بيانات متضافة في الجدول (DataGridView)
            if (dataGridView1.Rows.Count == 0 || dataGridView1.Rows[0].IsNewRow)
            {
                MessageBox.Show("No Added Rows!", "Error", MessageBoxButtons.OK);
                return;
            }
            // 2. بنبدأ نجهز طلب جديد (Object من Order)
            Order order = new Order()
            {
                OrderDate = DateTime.Now// بنسجل الوقت والتاريخ الحاليين
            };

            //3. نجهز تفاصيل الطلب علشان نعرضها بعدين في رسالة
            StringBuilder itemsDetails = new StringBuilder();
            itemsDetails.AppendLine($"Date: {DateTime.Now:yyyy/MM/dd}");
            itemsDetails.AppendLine($"Time: {DateTime.Now:HH:mm:ss}");
            itemsDetails.AppendLine($"--------------------------------");
            itemsDetails.AppendLine("Order Details:");

            // 4. نلف على كل صف في الجدول علشان نضيف العناصر للطلب
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow && row.Cells["Item"].Value != null)
                {
                    string itemName = row.Cells["Item"].Value?.ToString() ?? "";
                    string option = row.Cells["Option"].Value?.ToString() ?? "";
                    string category = row.Cells["Category"].Value?.ToString() ?? "";

                    //  5. بنبدأ نتحقق من صحة كل صف

                    if (string.IsNullOrWhiteSpace(itemName))
                    {
                        MessageBox.Show("Item Name is Required", "Error", MessageBoxButtons.OK);
                        continue;
                    }
                    // التحقق من اختيار الـ Option
                    if (string.IsNullOrWhiteSpace(option))
                    {
                        MessageBox.Show($"Option is Required for item: {itemName}", "Error", MessageBoxButtons.OK);
                        continue; //نعدي للصف اللي بعده لو فيه مشكلة
                    }

                    // التحقق من اختيار الـ Category
                    if (string.IsNullOrWhiteSpace(category))
                    {
                        MessageBox.Show($"Category is Required for item: {itemName}", "Error", MessageBoxButtons.OK);
                        continue;
                    }

                    if (!double.TryParse(row.Cells["Price"].Value?.ToString(), out double price) || price <= 0)
                    {
                        MessageBox.Show($"Price is Wrong: {itemName}", "Error", MessageBoxButtons.OK);
                        continue;
                    }

                    if (!int.TryParse(row.Cells["Quantity"].Value?.ToString(), out int quantity) || quantity <= 0)
                    {
                        MessageBox.Show($"Quantity is Wrong: {itemName}", "Error", MessageBoxButtons.OK);
                        continue;
                    }

                    // 6. لو البيانات كلها صح، نضيف العنصر للطلب
                    order.Items.Add(new OrderItem()
                    {
                        Name = itemName,
                        Option = option,
                        Category = category,
                        Price = price,
                        Quantity = quantity
                    });

                    // 7. عرض تفاصيل العنصر في الرسالة
                    itemsDetails.AppendLine($"Item: {itemName}");
                    itemsDetails.AppendLine($"  Category: {category}");
                    itemsDetails.AppendLine($"  Option: {option}");
                    itemsDetails.AppendLine($"  Price: {price:C} × {quantity} = {price * quantity:C}");
                    itemsDetails.AppendLine(); //سطر فاصل بين كل عنصر والتاني
                }
            }

            // 8. لو مفيش ولا عنصر اتضاف بعد الفحص، نوقف وننبه المستخدم
            if (order.Items.Count == 0)
            {
                MessageBox.Show("No Items Added!", "Error", MessageBoxButtons.OK);
                return;
            }

            // 9. حساب المجموع
            order.TotalPrice = order.Items.Sum(item => item.Price * item.Quantity);

            // 10. عرض رسالة التأكيد
            MessageBox.Show(
                $"{itemsDetails}\nTotal Price: {order.TotalPrice:C}",
                "Order Confirmation",
                MessageBoxButtons.OK
            );
        }
                                                              // File Handling
        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files (*.txt)|*.txt";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                menu.Items.Clear(); // امسح البيانات القديمة

                using (StreamReader reader = new StreamReader(openFileDialog.FileName))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        // قسّم السطر إلى الأعمدة
                        string[] parts = line.Split('|');

                        if (parts.Length == 4)
                        {
                            ListViewItem item = new ListViewItem(parts[0]); // Category
                            item.SubItems.Add(parts[1]); // Item
                            item.SubItems.Add(parts[2]); // Price
                            item.SubItems.Add(parts[3]); // Options

                            menu.Items.Add(item);
                        }
                    }
                }

                MessageBox.Show("Data loaded successfully!");
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                {
                    foreach (ListViewItem item in menu.Items)
                    {
                        // هنفصل كل عمود بعلامة |
                        string line = item.SubItems[0].Text+ '|' +item.SubItems[1].Text+'|' +item.SubItems[2].Text+ '|'+ item.SubItems[3].Text;
                        writer.WriteLine(line);
                    }
                }

                MessageBox.Show("Data saved successfully!");
            }



        }                                                  //Bill Section
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // بنحصل على القيم المدخلة من الـ TextBox
            string item = txtItem.Text;
            string price = txtPrice.Text;
            string quantity = txtQuantity.Text;

            // Get selected category
            string? category = cmbCategory.SelectedItem != null ? cmbCategory.SelectedItem.ToString() : "";
            // نتأكد إن المستخدم اختار فئة من الـ ComboBox
            if (cmbCategory.SelectedItem == null)
            {
                MessageBox.Show("Please select a category.");
                return;
            }

            // ناخد الفئة المختارة من الـ ComboBox
            Enums.Category selectedCategory = (Enums.Category)cmbCategory.SelectedItem;
            string option = ""; // هنحفظ الخيار هنا

            // لو الفئة هي Appetizer أو MainCourse
            if (selectedCategory == Enums.Category.Appetizer || selectedCategory == Enums.Category.MainCourse)
            {
                // نتحقق من الراديو بوتون المفعّل (Mild أو Spicy)
                if (radbtnMild.Checked)
                    option = radbtnMild.Text;
                else if (radbtnSpicy.Checked)
                    option = radbtnSpicy.Text;
                else
                {
                    MessageBox.Show("Please select an option (Mild or Spicy).");
                    return;
                }
            }
            // لو الفئة هي Dessert
            else if (selectedCategory == Enums.Category.Desserts)
            {
                // نتحقق من النكهة المختارة (Vanilla, Chocolate, Strawberry, Blueberry)
                if (radbtnVanilla.Checked)
                    option = radbtnVanilla.Text;
                else if (radbtnChocolate.Checked)
                    option = radbtnChocolate.Text;
                else if (radbtnStrawberry.Checked)
                    option = radbtnStrawberry.Text;
                else if (radbtnBlueberry.Checked)
                    option = radbtnBlueberry.Text;
                else
                {
                    MessageBox.Show("Please select a sauce option.");
                    return;
                }
            }
            // لو الفئة هي Drinks
            else if (selectedCategory == Enums.Category.Drinks)
            {
                // نتحقق من الحجم المختار (Small, Medium, Large)
                if (radbtnSmall.Checked)
                    option = radbtnSmall.Text;
                else if (radbtnMedium.Checked)
                    option = radbtnMedium.Text;
                else if (radbtnLarge.Checked)
                    option = radbtnLarge.Text;
                else
                {
                    MessageBox.Show("Please select a drink size.");
                    return;
                }
            }


            // نتأكد إن مفيش خانات فاضية
            if (!string.IsNullOrWhiteSpace(item) && !string.IsNullOrWhiteSpace(price) && !string.IsNullOrWhiteSpace(quantity))
            {
               //هنا بنضيف سطر جديد في الجريد بالقيم اللي دخلها اليوزرل
                dataGridView1.Rows.Add(category, option, item, price, quantity);
                // تفريغ الحقول بعد الإضافة
                ClearForm();
            }
            else
            {
                MessageBox.Show("Please fill all required fields.");
            }
            
        }
        private void btnUpdate1_Click_1(object sender, EventArgs e)
        {
            // لو مفيش صف مختار، نعرض رسالة
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to update.");
                return;
            }

            // باخد القيم اللي اليوزر دخلها وأخزنها في متغير 
            string item = txtItem.Text;
            string price = txtPrice.Text;
            string quantity = txtQuantity.Text;

            // نتأكد من اختيار فئة من الـ ComboBox
            if (cmbCategory.SelectedItem == null)
            {
                MessageBox.Show("Please select a category.");
                return;
            }

            Enums.Category selectedCategory = (Enums.Category)cmbCategory.SelectedItem;
            string option = ""; //هنا عملت متغير فاضي عشان هنملاه بعدين
       

           // نفس الإجراءات بتاعة الإضافة بس للتحديث
            if (selectedCategory == Enums.Category.Appetizer || selectedCategory == Enums.Category.MainCourse)
            {
                if (radbtnMild.Checked)
                    option = radbtnMild.Text;
                else if (radbtnSpicy.Checked)
                    option = radbtnSpicy.Text;
                else
                {
                    MessageBox.Show("Please select an option (Mild or Spicy).");
                    return;
                }
            }
            else if (selectedCategory == Enums.Category.Desserts)
            {
                if (radbtnVanilla.Checked)
                    option = radbtnVanilla.Text;
                else if (radbtnChocolate.Checked)
                    option = radbtnChocolate.Text;
                else if (radbtnStrawberry.Checked)
                    option = radbtnStrawberry.Text;
                else if (radbtnBlueberry.Checked)
                    option = radbtnBlueberry.Text;
                else
                {
                    MessageBox.Show("Please select a sauce option.");
                    return;
                }
            }
            else if (selectedCategory == Enums.Category.Drinks)
            {
                if (radbtnSmall.Checked)
                    option = radbtnSmall.Text;
                else if (radbtnMedium.Checked)
                    option = radbtnMedium.Text;
                else if (radbtnLarge.Checked)
                    option = radbtnLarge.Text;
                else
                {
                    MessageBox.Show("Please select a drink size.");
                    return;
                }
            }


            // نتأكد إن كل الحقول مليانة
            if (string.IsNullOrWhiteSpace(item) || string.IsNullOrWhiteSpace(price) || string.IsNullOrWhiteSpace(quantity))
            {
                MessageBox.Show("Please fill all required fields.");
                return;
            }

            // نحدث الصف المختار
            DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
            selectedRow.Cells["Category"].Value = selectedCategory.ToString();
            selectedRow.Cells["Option"].Value = option;
            selectedRow.Cells["Item"].Value = item;
            selectedRow.Cells["Price"].Value = price;
            selectedRow.Cells["Quantity"].Value = quantity;


            // نفضي الحقول بعد التحديث
            ClearForm();
        }
        private void ClearForm()
        {
            txtItem.Clear();
            txtPrice.Clear();
            txtQuantity.Clear();
            cmbCategory.SelectedIndex = -1;

            radbtnMild.Checked = false;
            radbtnSpicy.Checked = false;
            radbtnVanilla.Checked = false;
            radbtnChocolate.Checked = false;
            radbtnStrawberry.Checked = false;
            radbtnBlueberry.Checked = false;
            radbtnSmall.Checked = false;
            radbtnMedium.Checked = false;
            radbtnLarge.Checked = false;
        }

        private void btnRemove_Click(object sender, EventArgs e)
            //بيتأكد إن اليوزر اختار صف على الأقل من الجدول 
        {    // لو مفيش صف مختار، نعرض رسالة
            if (dataGridView1.SelectedRows.Count > 0)
            {
                //بيجيب رقم الصف اللي اليوزر اختاره.
                int selectedIndex = dataGridView1.SelectedRows[0].Index;

                // لو الصف مش فاضي، نعرض تأكيد الحذف
                if (!dataGridView1.Rows[selectedIndex].IsNewRow)
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to remove this item?", "Confirm Remove", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        dataGridView1.Rows.RemoveAt(selectedIndex);
                    }
                }
                else
                {
                    MessageBox.Show("You cannot remove an empty row.");
                }
            }
            else
            {
                MessageBox.Show("Please select a row to remove.");
            }
        }
        private void btnRemove_MouseEnter_1(object sender, EventArgs e)
        {
            btnRemove.BackColor = Color.DarkRed;
        }
        private void btnRemove_MouseLeave_1(object sender, EventArgs e)
        {
            btnRemove.BackColor = Color.FromArgb(198, 40, 40);
        }

        // السماح بالحروف والمسافات بس في خانة الـ Item
        private void txtItem_KeyPress(object sender, KeyPressEventArgs e)
        {
           

            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true; // بمنع الحرف إنه يظهر في التيكست بوكس
                lblWarning.Text = "Please enter letters only!";
                lblWarning.Visible = true;
                return;
            }

            // لو كل حاجة تمام، نخفي التحذير
            lblWarning.Visible = false;
        }

        // السماح بالأرقام ونقطة عشرية واحدة في خانة السعر
        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            // بنسمح بالأرقام، والنقطة العشرية، وحروف الكنترول (زي Backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true; //بمنع اللي هو دخله من إنه يظهر
                lblWarning.Text = "Price must be a valid number!";
                lblWarning.Visible = true;
                return;
            }

            // بنمنع المستخدم من إنه يدخل أكتر من نقطة عشرية
            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains(".")) // هنا بقوله اعتبر (sender) كأنه textbox عشان أقدر أدخل جواه
            {
                e.Handled = true;
                lblWarning.Text = "Only one decimal point allowed!";
                lblWarning.Visible = true;
                return;
            }

            lblWarning.Visible = false;
        }

        // السماح بالأرقام فقط في خانة الكمية
        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            // بنمنع أي حاجة غير أرقام وحروف الكنترول
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                lblWarning.Text = "Quantity must be numeric only!";
                lblWarning.Visible = true;
                return;
            }

            lblWarning.Visible = false;
        }
                                                         // Menu Section
        private void btnAdd2_Click(object sender, EventArgs e)
        {
            // هنا بنعمل عنصر جديد في الليست فيو، وبنحط فيه البيانات اللي المستخدم كتبها
            ListViewItem item = new ListViewItem(categorytxt.Text); // بنحط أول حاجة الكاتيجوري
            item.SubItems.Add(itemtxt.Text); // بعد كده اسم الأكلة 
            item.SubItems.Add(pricetxt.Text); // السعر
            item.SubItems.Add(optionstxt.Text); // وأي اختيارات إضافية
            menu.Items.Add(item); // بنضيف العنصر في الليست فيو

            // بنفضي الخانات بعد ما نضيف العنصر علشان المستخدم يكتب بيانات جديدة
            categorytxt.Clear();
            itemtxt.Clear();
            pricetxt.Clear();
            optionstxt.Clear();
        }

        private void btnEdit2_Click(object sender, EventArgs e)
        {
            // لو المستخدم اختار عنصر من الليست فيو
            if (menu.SelectedItems.Count > 0)
            {
                // بنجيب العنصر اللي اتحدد
                ListViewItem selectedItem = menu.SelectedItems[0];

                // بنرجع البيانات من الليست فيو للتيكست بوكس علشان المستخدم يقدر يعدل عليها
                categorytxt.Text = selectedItem.SubItems[0].Text;
                itemtxt.Text = selectedItem.SubItems[1].Text;
                pricetxt.Text = selectedItem.SubItems[2].Text;
                optionstxt.Text = selectedItem.SubItems[3].Text;
            }
            else
            {
                // لو المستخدم ما اختارش حاجة، نطلّع له رسالة تنبيه
                MessageBox.Show("Please select an item to edit.");
            }
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            // لو المستخدم مختار عنصر
            if (menu.SelectedItems.Count > 0)
            {
                // بنجيب العنصر اللي عايزين نحدّثه
                ListViewItem selectedItem = menu.SelectedItems[0];

                // بنحدّث بياناته بالقيم الجديدة اللي المستخدم كتبها
                selectedItem.SubItems[0].Text = categorytxt.Text;
                selectedItem.SubItems[1].Text = itemtxt.Text;
                selectedItem.SubItems[2].Text = pricetxt.Text;
                selectedItem.SubItems[3].Text = optionstxt.Text;

                // بنفضي الخانات بعد التحديث
                categorytxt.Clear();
                itemtxt.Clear();
                pricetxt.Clear();
                optionstxt.Clear();
            }
            else
            {
                // لو مفيش عنصر متحدد، نطلع تنبيه
                MessageBox.Show("Please select an item to update.");
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            // لو المستخدم مختار عنصر من الليست
            if (menu.SelectedItems.Count > 0)
            {
                // بنشيله من الليست
                ListViewItem selected = menu.SelectedItems[0];
                menu.Items.Remove(selected);
            }
            else
            {
                // لو مفيش حاجة متحددة، نطلّع رسالة
                MessageBox.Show("Please select an item to remove.");
            }
        }

        private void pricetxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            // هنا بنسمح للمستخدم إنه يكتب أرقام ونقطة عشرية بس في خانة السعر
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                // لو كتب أي حاجة غير رقم أو نقطة، بنمنع الكتابة ونظهر رسالة تحذير
                e.Handled = true;
                lblWarning2.Text = "Price must be a valid number!";
                lblWarning2.Visible = true;
                return;
            }

            // بنمنع المستخدم من إنه يكتب أكتر من نقطة عشرية
            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains("."))
            {
                e.Handled = true;
                lblWarning2.Text = "Only one decimal point allowed!";
                lblWarning2.Visible = true;
                return;
            }

            // لو كل حاجة تمام، نخفي التحذير
            lblWarning2.Visible = false;
        }

        private void categorytxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            // هنا بنسمح بس بالحروف والمسافة، وبنمنع أي حاجة تانية
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
                lblWarning2.Text = "Please enter letters!";
                lblWarning2.Visible = true;
                return;
            }

            // لو الإدخال سليم، نخفي التحذير
            lblWarning2.Visible = false;
        }

        private void itemtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            // نفس الفكرة، بنسمح بالحروف والمسافات بس
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
                lblWarning2.Text = "Please enter letters only!";
                lblWarning2.Visible = true;
                return;
            }

            // هنا بنخفي التنبيه
            lblWarning2.Visible = false;
        }

        private void optionstxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            // بنسمح بالحروف، المسافات، والـ "/" كمان )
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != '/')
            {
                e.Handled = true;
                lblWarning2.Text = "Please enter letters only!";
                lblWarning2.Visible = true;
                return;
            }

            // هنا بنخفي التنبيه
            lblWarning2.Visible = false;
        }



        private void txtItem_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupbxOptions_Enter(object sender, EventArgs e)
        {

        }

        private void menu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


       

        private void categorytxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblWarning_Click(object sender, EventArgs e)
        {

        }


        private void optionstxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRemove_MouseHover(object sender, EventArgs e)
        {

        }

        private void itemtxt_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void pricetxt_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
