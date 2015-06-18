/*
 * John Gordon & Lauren Wang
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeminiCore
{
    public class LabelLocation 
    {
        public string label;
        public short lineNum;
        
        public LabelLocation(string label, short lineNum)
        {
            this.label = label;
            this.lineNum = lineNum;
        }       
        public override string ToString()
        {
            return label + ", " + lineNum;
        }
        public override bool Equals(object obj)
        {
            LabelLocation loc = obj as LabelLocation;
            return this.label.Equals(loc.label);
        }
        
        public override int GetHashCode()
        {
            return label.GetHashCode();
        } 
    }
}
