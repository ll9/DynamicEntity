using DynamicEntity.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DynamicEntity
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            var keyval1 = new KeyValue("key1", "1");
            var keyval1_2 = new KeyValue("key1", "2");
            var keyval2 = new KeyValue("key2", 7);
            var keyval2_2 = new KeyValue("key2", 8);

            var keyValueSchema = new KeyValueSchema("key1", typeof(string).ToString(),
                new List<KeyValue> { keyval1, keyval1_2 });
            var keyValueSchema2 = new KeyValueSchema("key2", typeof(int).ToString(),
                new List<KeyValue> { keyval1, keyval1_2 });

            var row = new Row("p1", "p2", "p3", new List<KeyValue> { keyval1, keyval2 });
            var row2 = new Row("p4", "p5", "p6", new List<KeyValue> { keyval1_2, keyval2_2 });
            var proj = new ProjectTable("t1", new List<Row> { row, row2 }, 
                new List<KeyValueSchema> { keyValueSchema, keyValueSchema2 });


        }


    }
}
