using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multithreading_test
{
    class Book
    {
        List<Sheet> sheets;
        #region Singleton
        static Book theBook;
        public static Book GetBook()
        {
            if(theBook == null)
            {
                theBook = new Book();
            }
            return theBook;
        }
        #endregion
        public Sheet FindSheet(string name)
        {
            Sheet sheet = null;
            if (sheets.Count > 0)
            {
                for (int i = 0; i < sheets.Count; i++)
                {
                    if(sheets[i].GetName() == name)
                    {
                        sheet = sheets[i];
                    }
                }
            }
            return sheet;
        }
        public bool AddSheet(Sheet s)
        {
            string name = s.GetName();
            bool added = false;
            if (!SheetExists(s.GetName()))
            {
                sheets.Add(s);
                added = true;
            }

            return added;
        }
        public bool SheetExists(string name)
        {
            bool hasSheet = false;
            if (sheets.Count > 0)
            {
                for (int i = 0; i < sheets.Count; i++)
                {
                    if (sheets[i].GetName() == name)
                    {
                        hasSheet = true;
                    }
                }
            }
            return hasSheet;
        }
    }
}
