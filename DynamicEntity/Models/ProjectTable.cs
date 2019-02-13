using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicEntity.Models
{
    class ProjectTable
    {
        public ProjectTable(string name, ICollection<Row> rows, ICollection<KeyValueSchema> keyValueSchemas)
        {
            Name = name;
            Rows = rows;
            KeyValueSchemas = keyValueSchemas;
        }

        public string Name { get; set; }

        public ICollection<Row> Rows { get; set; }
        public ICollection<KeyValueSchema> KeyValueSchemas { get; set; }
    }
}
