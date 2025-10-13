using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Techno_Store
{
    internal class Info
    {
        public void TakingCustomerInfo(Customer customer)
        {
            while (true)
            {
                Console.Write("Enter Customer Name: ");
                string name = Console.ReadLine()?.Trim();

                if (string.IsNullOrWhiteSpace(name))
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("⚠️ Name cannot be empty. Try again.\n");
                    Console.ResetColor();
                    continue;
                }

                if (!System.Text.RegularExpressions.Regex.IsMatch(name, @"^[a-zA-Z\s]+$"))
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(
                        "⚠️ Name must contain letters only (no numbers or symbols).\n"
                    );
                    Console.ResetColor();
                    continue;
                }

                if (name.Length < 2)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(
                        "⚠️ Name is too short. It should be at least 2 characters.\n"
                    );
                    Console.ResetColor();
                    continue;
                }

                name = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(
                    name.ToLower()
                );

                customer.Name = name;
                break;
            }

            while (true)
            {
                Console.Write("Enter Customer Phone: ");
                string phone = Console.ReadLine()?.Trim();

                // 1️⃣ التأكد إن الرقم مش فاضي
                if (string.IsNullOrWhiteSpace(phone))
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("⚠️ Phone number cannot be empty. Try again.\n");
                    Console.ResetColor();
                    continue;
                }

                // 2️⃣ التأكد إن فيه أرقام فقط
                if (!System.Text.RegularExpressions.Regex.IsMatch(phone, @"^\d+$"))
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("⚠️ Phone number must contain digits only.\n");
                    Console.ResetColor();
                    continue;
                }

                // 3️⃣ التأكد إن الرقم يبدأ بـ 01
                if (!phone.StartsWith("01"))
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("⚠️ Egyptian phone numbers must start with '01'.\n");
                    Console.ResetColor();
                    continue;
                }

                // 4️⃣ التأكد إن الطول 11 رقم
                if (phone.Length != 11)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("⚠️ Phone number must be exactly 11 digits.\n");
                    Console.ResetColor();
                    continue;
                }

                // ✅ لو كله تمام
                customer.phone = phone;
                break;
            }

            while (true)
            {
                Console.Write("Enter Customer Email: ");
                string email = Console.ReadLine()?.Trim();

                // 1️⃣ التأكد إن الإيميل مش فاضي
                if (string.IsNullOrWhiteSpace(email))
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("⚠️ Email cannot be empty. Try again.\n");
                    Console.ResetColor();
                    continue;
                }

                // 2️⃣ التحقق من الصيغة الصحيحة باستخدام Regex
                string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

                if (!System.Text.RegularExpressions.Regex.IsMatch(email, pattern))
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("⚠️ Invalid email format. Example: example@gmail.com\n");
                    Console.ResetColor();
                    continue;
                }

                // ✅ لو الإيميل سليم
                customer.Email = email;
                break;
            }
        }
    }
}
