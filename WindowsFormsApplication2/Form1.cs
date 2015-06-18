/*
 * John Gordon & Lauren Wang
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using GeminiCore;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public CPU myCPU;
        public Memory mainMem;
        public int linenumber;
        public string ErrorMsg;
        public bool halt;
        public Form1()
        {
            InitializeComponent();
            LoadCacheDropDown();
            LoadBlockDropDown();
            LoadAssociativityDropDown();
            loadFileButton.Enabled = false;
            CacheSize.Enabled = false;
            BlockSize.Enabled = false;
        }

        #region Events
        private void loadFileButton_Click(object sender, EventArgs e)
        {
            mainMem = new Memory(Associativity.Text,Convert.ToInt32(CacheSize.Text), Convert.ToInt32(BlockSize.Text));
            myCPU = new CPU(mainMem);
            ResetButton_Click(sender, e);
            using (var ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    try
                    {
                        var ipe = new IPE(ofd.FileName, mainMem);
                        ipe.ParseFile();
                    }
                    catch (CustomException err)
                    {
                        linenumber = err.lineNumber;
                        ErrorMsg = err.Message;
                        this.ErrMsg.Text = "Error Message: " + ErrorMsg + " @ line: " + linenumber;
                        halt = true;
                        return;
                    }
                }
                ReadBinary("project2_test1.out");
            }
        }
        #endregion
        
        private void nextInstructionButton_Click(object sender, EventArgs e)
        {
            if (myCPU.PC < mainMem.binary.Count && !halt)
            {
                int pcCheck = myCPU.PC;
                short instruction = mainMem.binary[myCPU.PC];
                myCPU.IR = instruction;
                short value = (short)(instruction % 256);
                short reserved = (short)((instruction >> 8) % 8);
                short opcode = (short)(instruction >> 11);
                interpretCmd(value, reserved, opcode);
                this.setCPUValuesToView();
                if (myCPU.PC == pcCheck) { myCPU.PC++; };
            }
        }

        private void interpretCmd(short value, short reserved, short opcode)
        {
            switch (opcode)
            {
                case 0 : myCPU.NOP();  // NOP
                    break;
                case 1 : myCPU.LDA(value, reserved);  // LDA
                    break;
                case 2 : myCPU.STA(value);  // STA
                    break;
                case 3 : myCPU.ADD(value, reserved);  // ADD
                    break;
                case 4 : myCPU.SUB(value, reserved);  // SUB
                    break;
                case 5 : myCPU.MUL(value, reserved);  // MUL
                    break;
                case 6 : myCPU.DIV(value, reserved);  // DIV;
                    break;
                case 7 : myCPU.AND(value, reserved);  // AND;
                    break;
                case 8 : myCPU.OR(value, reserved);  // OR;
                    break;
                case 9 : myCPU.SHL(value, reserved);  // SHL;
                    break;
                case 10: myCPU.NOTA(); // NOTA;
                    break;
                case 11 : myCPU.BA(value); // BA;
                    break;
                case 12 : myCPU.BE(value); // BE;
                    break;
                case 13 : myCPU.BL(value); // BL;
                    break;
                case 14 : myCPU.BG(value); // BG
                    break;
                case 15: halt = true ; // HLT;
                    break;
            }
        }

        public void setCPUValuesToView()
        {
            this.accLabel.Text = ConvertToBinary(this.myCPU.acc);
            this.AVal.Text = ConvertToBinary(this.myCPU.Aval);
            this.BVal.Text = ConvertToBinary(this.myCPU.Bval);
            this.PCVal.Text = ConvertToBinary(this.myCPU.PC);
            this.MARVal.Text = ConvertToBinary(this.myCPU.MAR);
            this.MDRVal.Text = ConvertToBinary(this.myCPU.MDR);
            this.TempVal.Text = ConvertToBinary(this.myCPU.Temp);
            this.IRVal.Text = ConvertToBinary(this.myCPU.IR);
            this.CCVal.Text = ConvertToBinary(this.myCPU.CC);
            this.zero.Text = ConvertToBinary(this.myCPU.zero);
            this.one.Text = ConvertToBinary(this.myCPU.one);
            this.hitLabel.Text = Convert.ToString(this.mainMem.hitCounter);
            this.missLabel.Text = Convert.ToString(this.mainMem.missCounter);
        }
        public string ConvertToBinary(int value)
        {
            string binary = Convert.ToString(value, 2);
            int zeros = 16 - binary.Length;
            string result = "";
            for (int i = 0; i < zeros; i++)
            {
                result += "0";
            }
            return result + binary;
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            myCPU.acc = 0;
            myCPU.Aval = 0;
            myCPU.Bval = 0;
            myCPU.CC = 0;
            myCPU.MAR = 0;
            myCPU.MDR = 0;
            myCPU.PC = 0;
            myCPU.IR = 0;
            myCPU.Temp = 0;
            ErrorMsg = "Error:";
            AVal.ResetText();
            BVal.ResetText();
            accLabel.ResetText();
            PCVal.ResetText();
            MARVal.ResetText();
            MDRVal.ResetText();
            TempVal.ResetText();
            IRVal.ResetText();
            CCVal.ResetText();
            ErrMsg.ResetText();
            one.ResetText();
            zero.ResetText();
            hitLabel.ResetText();
            missLabel.ResetText();
            halt = false;
            for (int i = 0; i < mainMem.memory.Length; i++)
            {
                mainMem.memory[i] = 0;
            }
            mainMem.labels.Clear();
        }

        private void RunToEndButton_Click(object sender, EventArgs e)
        {
            while (myCPU.PC < mainMem.binary.Count)
            { 
                nextInstructionButton_Click( sender,  e); 
            }
        }
        private void CacheSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            BlockSize.Enabled = true;
        }

        private void LoadCacheDropDown()
        {
            for (int i = 2; i < 17; i++)
            {
                CacheSize.Items.Add(Convert.ToString(i));
            }
        }
        private void BlockSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadFileButton.Enabled = true;
        }  
        private void LoadBlockDropDown()
        {
            BlockSize.Items.Add(Convert.ToString(1));
            BlockSize.Items.Add(Convert.ToString(2));
        }
        private void Associativity_SelectedIndexChanged(object sender, EventArgs e)
        {
            CacheSize.Enabled = true;
        } 
        private void LoadAssociativityDropDown()
        {
            Associativity.Items.Add("One-Way");
            Associativity.Items.Add("Two-Way");
        }
        private void ReadBinary(string filename)
        {
            FileStream readStream = new FileStream(filename, FileMode.Open);
            BinaryReader br = new BinaryReader(readStream);
            mainMem.binary = new List<short>();
            br.BaseStream.Seek(0, SeekOrigin.Begin);
            int pos = 0;
            int length = (int)br.BaseStream.Length;
            while (pos < length)
            {
                mainMem.binary.Add(br.ReadInt16());
                pos += sizeof(short);
            }
        }
    }
}
