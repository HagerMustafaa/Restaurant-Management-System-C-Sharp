using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management_System
{
    // كلاس عام (abstract) يعني مش هنستخدمه مباشرة، بس الكلاسات التانية هتورث منه
    public abstract class Item
    {
        public string Name { get; set; }   // اسم العنصر (زي اسم الأكلة أو المشروب)
        public double Price { get; set; }  // سعر العنصر

        // دالة المُنشئ (Constructor) بتستخدم لتحديد الاسم والسعر لما ننشئ كائن من النوع ده أو من كلاس وارث منه
        public Item(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }

    // كلاس خاص بالمقبلات (Appetizers) وده بيرث من Item
    public class Appitizers : Item
    {
        public string Taste { get; set; }  // طعم الأكلة (مثلاً: حار، حلو)

        // Constructor بيستدعي اللي في Item علشان الاسم والسعر، وبعدين يحدد الطعم
        public Appitizers(string name, double price, string taste) : base(name, price)
        {
            Taste = taste;
        }
    }

    // كلاس خاص بالأطباق الرئيسية (Main Course) وده برضو بيرث من Item
    public class MainCourse : Item
    {
        public string Taste { get; set; }  // الطعم برضو (حار، Mild...)

        // نفس الفكرة، بنمرر البيانات ونستدعي Constructor بتاع الأب
        public MainCourse(string name, double price, string taste) : base(name, price)
        {
            Taste = taste;
        }
    }

    // كلاس للحلويات (Desserts) وبنضيف عليه نوع الصوص المستخدم
    public class Desserts : Item
    {
        public string Sauce { get; set; }  // نوع الصوص (زي: شوكولاتة، فانيليا...)

        // Constructor بيحدد الاسم والسعر والصوص
        public Desserts(string name, double price, string sauce) : base(name, price)
        {
            Sauce = sauce;
        }
    }

    // كلاس للمشروبات (Drinks) وبيحتوي على الحجم
    public class Drinks : Item
    {
        public string Size { get; set; }  // حجم المشروب (Small - Medium - Large)

        // Constructor بيحدد البيانات زي الاسم والسعر والحجم
        public Drinks(string name, double price, string size) : base(name, price)
        {
            Size = size;
        }
    }

}
