using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabThreeOfSecondSession.Model
{
    internal class Song
    {
        private int during;
        public string Name { get; set; }
        public string Autor {  get; set; }
        public int During
        {
            get {  return during; }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(During));
                during = value;
            }
        }
        public Song(string name, int during, string autor)
        {
            Name = name;
            During = during;
            Autor = autor;
        }

        public Song()
        {
        }
    }
}
