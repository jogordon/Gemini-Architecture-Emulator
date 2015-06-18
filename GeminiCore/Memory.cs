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
    public class Memory
    {
        public List<string> instructions;             // Instruction Vector
        public HashSet<LabelLocation> labels;        // Unknown label
        public List<short> binary;
        public int[] memory = new int[256];
        public Block[,] cache;
        public int cacheSize;
        public int blockSize;
        public int associativity;
        public int hitCounter = 0;
        public int missCounter = 0;

        public Memory(string associativity, int cacheSize, int blockSize)
        {
            this.binary = CreateList(100);
            this.labels = new HashSet<LabelLocation>();
            setAssociativity(associativity);
            this.cache = new Block[cacheSize, this.associativity];
            this.cacheSize = cacheSize;
            this.blockSize = blockSize;
        }
        
        public int GetMemoryIndex(int i)
        {
            try
            {
                return this.memory[i];
            }
            catch (Exception e)
            {
                Console.WriteLine("Error in Memory Class");
                return -1;
            }
        }
        public int GetInstructionCount()
        {
            return instructions.Count; 
        }
        public string GetInstruction(int i)
        {
            return instructions[i];
        }
        public void StoreInstructions(string[] instString)
        {
            this.instructions = instString.ToList<string>();
        }
        private static List<short> CreateList(int capacity)
        {
            return Enumerable.Repeat((short)-1, capacity).ToList();
        }
        public int getIndex(int i)
        {
            for (int j = 0; j < associativity; j++)
            {
                Block block = cache[((i / blockSize) % (cacheSize / associativity)), j];
                if (block != null && block.tag == (i / blockSize))
                {
                    hitCounter++;
                    return block.words[i % blockSize];
                }
            }
            int[] newWord = new int[blockSize];
            int value = memory[i];
            for (int k = 0; k < blockSize; k++)
            {
                newWord[k] = memory[(i + k) - (i % blockSize)];
            }
            Block newBlock = new Block(0, (i / blockSize), newWord);
            ReplaceBlock(i, newBlock);
            missCounter++;
            return value;
        }
        public void setIndex(int i, int value)
        {
            for (int j = 0; j < associativity; j++)
            {
                Block block = cache[((i / blockSize) % (cacheSize / associativity)), j];
                if (block != null && block.tag == i / blockSize)
                {
                    hitCounter++;
                    block.valid = 1;
                    block.words[i % blockSize] = value;
                    return;
                }
            }
            missCounter++;
            memory[i] = value;
        }
        private void setAssociativity(string associativity)
        {
            if(associativity.Equals("Two-Way"))
            {
                this.associativity = 2;
            }
            else {
                this.associativity = 1;
            }
        }
        private void ReplaceBlock(int address, Block block)
        {
            Random rand = new Random();
            int index = rand.Next(0, associativity);
            Block b = cache[((address / blockSize) % (cacheSize / associativity)), index];
            if (b != null && b.valid == 1)
            {
                for (int i = 0; i < blockSize; i++)
                {
                        memory[b.tag + i] = b.words[i];
                }
            }
            cache[((address / blockSize) % (cacheSize / associativity)), index] = block;
        }       
    }
}
