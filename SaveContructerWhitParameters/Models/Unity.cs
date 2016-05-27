using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SaveContructerWhitParameters.Models
{
    public class Unity
    {
        public Guid UnityId { get; set; }
        public string Abreviation { get; set; }
        public string Description { get; set; }

        public Unity(string abreviation, string description)
        {
            UnityId = Guid.NewGuid();
            Abreviation = abreviation;
            Description = description;
        }

        public Unity() { }
    }
}