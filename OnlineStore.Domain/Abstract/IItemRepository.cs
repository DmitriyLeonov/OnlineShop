using OnlineStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OnlineStore.Domain.Abstract
{
    public interface IItemRepository
    {
        IEnumerable<Item> Items { get; }
    }
}
