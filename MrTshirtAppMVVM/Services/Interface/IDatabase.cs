using MrTshirtAppMVVM.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MrTshirtAppMVVM.Services.Interface
{
    public interface IDatabase
    {
        Task<TShirttable> GetLatestTShirttable();
        Task<int> DeleteProduct(TShirttable TShirttable);

        Task<int> UpdateProduct(TShirttable TShirttable);

        Task<List<TShirttable>> GetSortedData();



    }
}
