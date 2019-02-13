using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicEntity.Models
{
    class KeyValueSchema
    {
        public KeyValueSchema(string key, string dataType, ICollection<KeyValue> keyValues)
        {
            Key = key;
            DataType = dataType;
            KeyValues = keyValues;

            foreach (var keyValue in KeyValues)
            {
                keyValue.KeyValueSchema = this;
            }
        }

        public string Key { get; set; }
        public string DataType { get; set; }

        public ICollection<KeyValue> KeyValues { get; set; }
        public ProjectTable ProjectTable { get; set; }
    }
}
