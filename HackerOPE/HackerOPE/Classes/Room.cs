using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerOPE
{
    class Room
    {
        private string title;
        private string description;

        private List<string> exits;
        private List<Item> items;

        #region properties
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        
        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public List<Item> Items
        {
            get { return items; }
            set { items = value; }
        }

        #endregion

        //Public Methods

        //Describe()

        //ShowTitle()

        //GetItem()

        //AddExits()

        //RemoveExits()

        //CanExit()

        //Private Methods

        //GetItemList()

        //GetExitList()

        //GetCoordinates()
    }
}
