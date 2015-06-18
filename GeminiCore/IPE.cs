/*
 * John Gordon & Lauren Wang
 */
using System;
using System.Collections.Generic;
using System.Collections;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GeminiCore
{
    public class IPE
    {
        public Memory mainMem;
        public string FileToParse { get; set; }

        public IPE(string filename, Memory mainMem)
        {
            this.FileToParse = filename;
            this.mainMem = mainMem;
        }

        public void ParseFile()
        {
            mainMem.StoreInstructions(File.ReadAllLines(this.FileToParse));
            short lineCounter = 0;
            List<LabelLocation> noLabel = new List<LabelLocation>();
            foreach (var line in mainMem.instructions)
            {
                Regex instructionFormat = new Regex(@"^\s*((?<comment>!.*)|((?<label>[A-Za-z]+?)\s*:$|(?<command>[A-Za-z]{2,4})\s?(((?<memory>((#\$){1}|\${1}))(?<address>[0-9]{1,3}))|(?<goto>[A-Za-z]*))(\s+!.*|\s*)$))");
                var instructionMatch = instructionFormat.Match(line);
                if (instructionMatch.Success)
                {
                    string comment = instructionMatch.Groups["comment"].Value;
                    string label = instructionMatch.Groups["label"].Value;
                    if (comment.Length > 0) { /*do nothing, its a comment*/}       
                    else if (label.Length > 0)
                    {
                        mainMem.labels.Add(new LabelLocation(label, lineCounter));
                    }
                    else
                    {
                        short lineIndex = -1;
                        short instruction = 0;
                        try
                        {
                            instruction = (short)(getInstruction(instructionMatch.Groups["command"].Value) << 11);
                        }
                        catch (CustomException e)
                        {
                            e.lineNumber = lineCounter;
                            throw e;
                        }
                        string address = instructionMatch.Groups["address"].Value;
                        string gotoLabel = instructionMatch.Groups["goto"].Value;              
                        if (instructionMatch.Groups["memory"].Value.Equals("#$"))
                        {
                            instruction = (short)(instruction | 256);
                        }
                        if (address.Length > 0) 
                        {
                            short adrs = Convert.ToInt16(address);
                            if (adrs > 255)
                            {
                                throw new CustomException(lineCounter, "Out Of Range");
                            }
                            instruction = (short)(instruction | adrs);
                        }
                        if (gotoLabel.Length > 0)
                        {
                            lineIndex = mainMem.labels.Where(x => x.label.Equals(gotoLabel)).Select(x => x.lineNum).FirstOrDefault();
                            if(mainMem.labels.Contains(new LabelLocation(gotoLabel, lineCounter)))
                            {                                
                                instruction = (short)(instruction | lineIndex);
                            }
                            else
                            {
                                noLabel.Add(new LabelLocation(gotoLabel,lineCounter));
                            }
                        }
                        mainMem.binary[lineCounter] = instruction;
                        lineCounter++;
                    }
                }
                else if (line.Length > 0)
                {
                    Console.WriteLine(line);
                    foreach (char c in line)
                    {
                        if (!c.Equals(' '))
                        {
                            throw new CustomException(lineCounter, "Invalid Syntax");
                        }
                    }                
                }
            }
            foreach(LabelLocation labloc in noLabel)
            {
                short index = mainMem.labels.Where(x => x.label.Equals(labloc.label)).Select(x => x.lineNum).First();
                mainMem.binary[labloc.lineNum] = (short)(mainMem.binary[labloc.lineNum] | index);
            }
            WriteToFile(mainMem.binary);
            mainMem.binary.Clear();
        }
        public short getInstruction(string s)
        {
            switch (s.ToUpper())
            {
                case "NOP":  return 0;  // 00000
                case "LDA":  return 1;  // 00001
                case "STA":  return 2;  // 00010
                case "ADD":  return 3;  // 00011
                case "SUB":  return 4;  // 00100
                case "MUL":  return 5;  // 00110
                case "DIV":  return 6;  // 00110;
                case "AND":  return 7;  // 00111;
                case "OR":   return 8;  // 01000;
                case "SHL":  return 9;  // 01001;
                case "NOTA": return 10; // 01010;
                case "BA":   return 11; // 01011;
                case "BE":   return 12; // 01100;
                case "BL":   return 13; // 01101;
                case "BG":   return 14; // 01110;
                case "HLT":  return 15; // 01111;
            }
            throw new CustomException(0, "Command Not supported");
        }
        public void WriteToFile(List<short> s)
        {     
            try
            {
                FileStream writeStream = new FileStream("project2_test1.out", FileMode.Create);
                BinaryWriter bw = new BinaryWriter(writeStream);
                foreach (short u in s)
                {
                    if (u != -1)
                    {
                        bw.Write(u);
                        bw.Flush();
                    }
                }        
                bw.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
