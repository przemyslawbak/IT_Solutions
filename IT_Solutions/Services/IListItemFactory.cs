using IT_Solutions.Models;
using System.Collections.Generic;

namespace IT_Solutions.Services
{
    public interface IListItemFactory
    {
        List<ListItemModel> GetAllServices();
        List<ListItemModel> GetAllTechnologies();
    }
}