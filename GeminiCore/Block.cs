using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeminiCore
{
    public class Block
    {
        public int valid;
        public int tag;
        public int[] words;

        public Block(int valid, int tag, int[] words)
        {
            this.valid = valid;
            this.tag = tag;
            this.words = words;
        }
    }
}
