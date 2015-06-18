/*
 * John Gordon & Lauren Wang
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeminiCore
{
    public class CPU
    {
        public Memory mainMem;
        public int acc;
        public int Aval;
        public int Bval;
        public int PC;
        public int MAR;
        public int MDR;
        public int Temp;
        public int CC;
        public int IR;
        public int zero;
        public int one;

        public CPU(Memory mainMem)
        {
            this.mainMem = mainMem;
            one = 1;
        }
        public void LDA(short val, short flag)
        {
            if (flag == 1) { acc = val; }
            else { acc = mainMem.getIndex(val); }
        }
        public void STA(short val)
        {
            mainMem.setIndex(val, acc);
        }
        public void ADD(short val, short flag)
        {
            if (flag == 1){acc += val;}
            else { acc += mainMem.getIndex(val); }
            if (acc > 0)
            {
                CC = 1;
            }
            else if (acc == 0)
            {
                CC = 0;
            }
            else { CC = -1; }
        }
        public void SUB(short val, short flag)
        {
            if (flag == 1) { acc -= val; }
            else { acc -= mainMem.getIndex(val); }
            if (acc > 0)
            {
                CC = 1;
            }
            else if (acc == 0)
            {
                CC = 0;
            }
            else { CC = -1; }
        }
        public void MUL(short val, short flag)
        {
            if (flag == 1) { acc *= val; }
            else { acc *= mainMem.getIndex(val);}
        }
        public void DIV(short val, short flag)
        {
            if (flag == 1) { acc /= val; }
            else { acc /= mainMem.getIndex(val); }
        }
        public void SHL(short val, short flag)
        {
            if (flag == 1) { acc <<= val;}
            else { acc <<= mainMem.getIndex(val);}
        }
        public void NOTA()
        {
            acc = ~acc;
        }
        public void BA(short val)
        {
            PC = val;
        }
        public void BE(short val)
        {
            if (CC == 0) { PC = val; }

        }
        public void BL(short val)
        {
            if (CC == -1) { PC = val; }
        }
        public void BG(short val)
        {
            if (CC == 1) { PC = val; }
        }
        public void NOP()
        {
            // hi morecraft :D
        }      
        public void AND(short value, short flag)
        {
            if (flag == 1) { acc = (short)(acc & value); }
            else{acc = (short)(acc & mainMem.getIndex(value));}
        }   
        public void OR(short value, short flag)
        {
            if (flag == 1) { acc = (short)acc | value; }
            else { acc = acc | mainMem.getIndex(value); }
        }
    }
}
