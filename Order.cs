using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management_System
{
    // ده كلاس بيمثل الطلب ككل
    public class Order
    {
        public int OrderId { get; set; }  // ده المعرف الفريد للطلب
        public DateTime OrderDate { get; set; }  // تاريخ ووقت الطلب
        public string Name { get; set; }  // اسم العميل أو اسم الطلب نفسه
        public double Price { get; set; }  // ده السعر الكلي للطلب (ممكن يكون مجموع سعر كل الحاجات)
        public int Quantity { get; set; }  // الكمية اللي طلبها العميل (ممكن تكون عدد الأصناف في الطلب)
        public double TotalPrice { get; set; }  // السعر الكلي للطلب، يعني سعر كل الأصناف مع الكميات
        public double Paid { get; set; }  // المبلغ المدفوع من العميل
        public double Change => Paid - TotalPrice;  // هنا بنحسب التغيير اللي لازم يرجع للعميل (المبلغ المدفوع - السعر الكلي)

        // دي لستة بكل الحاجات اللي طلبها العميل
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();  // لستة العناصر في الطلب (مثال: أصناف الطعام أو المشروبات)
    }

    // ده كلاس بيمثل العنصر الواحد في الطلب (يعني كل صنف طلبه العميل)
    public class OrderItem
    {
        public string Name { get; set; }  // اسم العنصر (مثال: نوع الطعام أو المشروب)
        public double Price { get; set; }  // سعر العنصر الواحد
        public int Quantity { get; set; }  // الكمية المطلوبة من العنصر ده
        public string Category { get; set; }  // الفئة اللي ينتمي ليها العنصر (مثال: طعام، مشروبات، أو غيرها)

        // ده سعر العنصر الكلي بناءً على السعر والكمية
        public double TotalPrice => Price * Quantity;

        public object Option { get; internal set; }
    }
}
