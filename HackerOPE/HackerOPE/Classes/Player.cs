using System.Collections.Generic;

namespace HackerOPE
{
    internal static class Player
    {
        private static int posX;
        private static int posY;

        private static List<Item> inventoryItems;
        private static int moves = 0;
        private static int weightCapacity;

        #region properties

        public static int PosX
        {
            get { return posX; }
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

        #endregion properties

        public static void Move(string direction)
        {
            Room room = Player.GetCurrentRoom();

            if (!room.CanExit(direction))
            {
                TextBuffer.Add("Invalid direction.");
                return;
            }

            Player.moves++;

            switch (direction)
            {
                case Direction.North:  // "north"
                    posY--;
                    break;

                case Direction.South:
                    posY++;
                    break;

                case Direction.East:
                    posX++;
                    break;

                case Direction.West:
                    posX--;
                    break;
            }

            Player.GetCurrentRoom().Describe();
        }

        public static void PickupItem(string itemName)
        {
            Room room = Player.GetCurrentRoom();
            Item item = room.GetItem(itemName);

            if (item != null)
            {
                if (Player.InventoryWeight + item.Weight > Player.weightCapacity)
                {
                    TextBuffer.Add("You must first drop some weight before you can pickup this item.");
                    return;
                }

                room.Items.Remove(item);
                Player.inventoryItems.Add(item);
                TextBuffer.Add(item.PickupText);
            }
            else
                TextBuffer.Add("There is no " + itemName + " in this room.");
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