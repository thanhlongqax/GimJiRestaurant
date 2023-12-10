using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Configuration;
using Newtonsoft.Json;

namespace Gimji.DTO
{
    internal class CartItemManager
    {
        public static List<CartItem> GetCartItems()
        {
            string cartItemsJson = ConfigurationManager.AppSettings["cartItems"];
            if (string.IsNullOrEmpty(cartItemsJson) || cartItemsJson.Equals("null", StringComparison.OrdinalIgnoreCase))
            {
                return new List<CartItem>();
            }

            return JsonConvert.DeserializeObject<List<CartItem>>(cartItemsJson);
        }

        public static void SaveCartItems(List<CartItem> cartItems)
        {
            string cartItemsJson = JsonConvert.SerializeObject(cartItems);

            // Sử dụng một cấu hình mới để tránh sự nhầm lẫn với cấu hình chung của ứng dụng
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            // Ensure that AppSettings is not null
            if (config.AppSettings != null)
            {
                // Check if the key exists before accessing Settings
                if (config.AppSettings.Settings["cartItems"] != null)
                {
                    // Set the value
                    config.AppSettings.Settings["cartItems"].Value = cartItemsJson;

                    // Save the changes
                    config.Save(ConfigurationSaveMode.Modified);
                    ConfigurationManager.RefreshSection("appSettings");
                }
                else
                {
                    // Handle the case where "cartItems" key doesn't exist
                    Console.WriteLine("The 'cartItems' key does not exist in appSettings.");
                }
            }
            else
            {
                // Handle the case where AppSettings is null
                Console.WriteLine("AppSettings is null.");
            }
        }

    }
}
