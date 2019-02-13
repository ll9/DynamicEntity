using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicEntity.Models
{
    class Row
    {
        public Row(string basciProperty1, string basciProperty2, string basciProperty3, ICollection<KeyValue> keyValues)
        {
            BasciProperty1 = basciProperty1;
            BasciProperty2 = basciProperty2;
            BasciProperty3 = basciProperty3;
            KeyValues = keyValues;
        }

        public string BasciProperty1 { get; set; }
        public string BasciProperty2 { get; set; }
        public string BasciProperty3 { get; set; }

        public ICollection<KeyValue> KeyValues { get; set; }
    }
}
