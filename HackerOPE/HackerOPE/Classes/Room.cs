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

        #region public methods

        public void Describe()
        {

        }

        public void ShowTitle()
        {

        }

        public Item GetItem(string itemName)
        {
            return null;
        }

        public void AddExits(string direction)
        {
            
        }

        public void RemoveExits(string direction)
        {

        }

        public bool CanExit(string name)
        {
            return false;
        }

        #endregion

        //Private Methods

        private string GetItemList()
        {
            return "";
        }

        private string GetExitList()
        {
            return "";
        }

        private string GetCoordinates()
        {
            return "";
        }
    }
}
