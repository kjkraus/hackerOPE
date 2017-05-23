using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerOPE
{
    static class Player
    {
        private static int posX;
        private static int posY;

        private static List<Item> inventoryItems;
        private static int moves = 0;
        private static int weightCapacity;

        #region properties

        public static int PosX
        {
            get { return posX;  }
            set { posX = value; }
        }

        public static int PosY
        {
            get { return posY; }
            set { posY = value; }
        }

        public static int Moves
        {
            get { return moves; }
            set { moves = value; }
        }

        public static int WeightCapacity
        {
            get { return weightCapacity; }
            set { weightCapacity = value; }
        }

        public static int InventoryWeight
        {
            get
            {   
                //TODO: finish inventory weight calculation.
                return 0;
            }
        }


        #endregion
        public static void Move(string direction)
        {

        }

        public static void PickupItem(string itemName)
        {

        }

        public static void DropItem(string itemName)
        {

        }

        public static void DisplayInventory()
        {

        }

        public static Room GetCurrentRoom()
        {
            return null;
        }

        public static Item GetInventoryItem(string itemName)
        {
            return null;
        }



    }
}
