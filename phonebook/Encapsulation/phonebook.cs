using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace phonebook.Encapsulation
{
    public struct phonebook
    {
        #region attributes 
        private int[] Numbers;
        //refernce in the stack with 4 bytes refere to null in the heap 
        private string[] Names;
        private int size;
        #endregion

        #region properties 
        //full property for size 
        public int Size
        {
            get 
            {
                return size;
            }
        }
        #endregion

        #region constructor
        public phonebook(int size)
        {
            Names = new string[size];
            Numbers = new int[size];
            this.size = size;
   
        }
        #endregion

        #region Methods 
        //add new person 
        //put another asumption if user enter no value or doesnot pass value to parametrize instructor >>>>
        public void addPerson(int index ,string PName , int PNum)
        {
            if (Names!= null && Numbers != null)
            {
                if (index < Names.Length)
                {
                    Names[index] = PName;
                    Numbers[index] = PNum;
                }
            }

        }
        #region Property_Indexer 
        public int this[string Pname]
        {
            get
            {
                if (Names != null && Numbers != null)
                {
                    for (int i = 0; i < Names.Length; i++)
                    {
                        if (Names[i] == Pname)
                        {
                            return Numbers[i];
                        }
                    }
                }
             
            return -1; 
            }
            set
            {
                if (Names != null && Numbers != null)
                {
                    for (int i = 0; i < Names.Length; i++)
                    {
                        if (Names[i] == Pname)
                        {
                            Numbers[i]=value;
                        }
                    }
                }
            }
        }
        
        public string this[int n]
        {
            get
            {
                return $"name is :{Names[n]}\tyour number is:{Numbers[n]}";
            }
        }
        #endregion

        #region setter and getter(old version) =>Encapsulation
        //public void setNumber(string PName, int PNum)
        //{
        //    if (Names != null && Numbers != null) { }
        //    for (int i = 0; i < Names.Length; i++)
        //    {
        //        if (Names[i] == PName)
        //        {
        //            Numbers[i] = PNum;
        //            break;
        //        }
        //    }
        //}
        //public int GetNumber(string PName)
        //{
        //    if (Names != null && Numbers != null)
        //    {
        //        for (int i = 0; i < Names.Length; ++i)
        //        {
        //            if (Names[i] == PName)
        //            {
        //                return Numbers[i];
        //            }
        //        }
        //    }
        //    return -1;
        //}
        public void print()
        {
            for (int i = 0; i < Names.Length; i++)
            {

                Console.WriteLine($"the name is: {Names[i]} and the Number is: {Numbers[i]}\n");
            }

            #endregion

        }
        #endregion

    }
}
