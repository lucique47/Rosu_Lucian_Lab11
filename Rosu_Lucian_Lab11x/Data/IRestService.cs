using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rosu_Lucian_Lab11x.Models;

namespace Rosu_Lucian_Lab11x.Data
{
    public interface IRestService
    {
        Task<List<ShopList>> RefreshDataAsync();
        Task SaveShopListAsync(ShopList item, bool isNewItem);
        Task DeleteShopListAsync(int id);
    }
}

public class ShopList
{
    public int ID { get; set; }
    public required string Description { get; set; }
    public DateTime Date { get; set; }
}
