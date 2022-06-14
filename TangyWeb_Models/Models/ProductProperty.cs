using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tangy_Models.Models
{
    public class ProductProperty
    {
        private string _key = "";
        private string _value = "";

        public ProductProperty()
        {
            Id = 1;
            Key = "";
            Value = "";
        }

        public ProductProperty(int id, string key, string value)
        {
            Id = id;
            Key = key;
            Value = value;
        }

        public int Id { get; set; }
        public string Key { get => _key; set => _key = value; }
        public string Value { get => _value; set => _value = value; }
    }
}
