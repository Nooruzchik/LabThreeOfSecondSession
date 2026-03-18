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
        public string name { get; set; }
        public string autor {  get; set; }

        public int During
        {
            get {  return during; }
            set
            {
                if (value < 0)
                    throw new Exception();
                during = value;
            }
        }
        public Song(string name, int during, string autor)
        {
            this.name = name;
            this.during = during;
            this.autor = autor;
        }

        public Song()
        {
        }
    }
}
