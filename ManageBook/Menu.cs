using System;
using System.Collections;

namespace ManageBook
{
    public abstract class Menu
    {
        private ArrayList valueList = new ArrayList();
        private String title = "";
        private Validate validate = new Validate();

        public ArrayList getValueList()
        {
            return valueList;
        }

        public void setTitle(String title)
        {
            this.title = title;
        }

        public void displayMenu()
        {
            Console.WriteLine(title);
            for (int i = 0; i < valueList.Count; i++)
            {
                Console.WriteLine((i + 1) + ". " + valueList[i]);
            }
            Console.WriteLine("-------------------------");
        }


        public int getSelected()
        {
            displayMenu();
            Console.Write("Please select..: ");
            return validate.checkInteger();
        }

        public abstract void execute(int n);

        public void run()
        {
            while (true)
            {
                int n = getSelected();
                execute(n);
                if (n >= valueList.Count) break;
            }
        }
    }
}
