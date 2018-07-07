using System;
using System.Collections.Generic;

namespace CodingFirstUtilityMvc.Models
{
    public class Model
    {
        public Model()
        {
        }

        public string Name
        {
            get;
            set;
        }

        public string SuperClass
        {
            get;
            set;
        }

        public string Description
        {
            get;
            set;
        }

        public string TableName
        {
            get;
            set;
        }

        public IEnumerable<Field> Fields { get; set; }

    }
}
