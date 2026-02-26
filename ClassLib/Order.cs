using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
    public class Order
    {
        private BindingList<OrderRecord> records = new BindingList<OrderRecord>();

        public void AddRecord(OrderRecord record)
        {
            records.Add(record);
        }

        public BindingList<OrderRecord> GetRecords()
        {
            return records;
        }

        public void RemoveRecord(int index)
        {
            records.RemoveAt(index);
        }
    }
}
