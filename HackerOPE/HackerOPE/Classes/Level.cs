using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerOPE
{
    static class Level
    {
        private static Room[,] rooms;

        #region proprerties
        public static Room[,] Rooms
        {
            get { return rooms; }
        }

        #endregion
        public static void Initialize()
        {
            BuildLevel();
        }

        private static void BuildLevel()
        {
            rooms = new Room[2, 2];

            Room room;
            Item item;
            //////////////////////////////////////////////////////////
            // create the RED room
            room = new Room();

            // assign this room to location 0,0
            rooms[0, 0] = room;

            // setup the  room
            room.Title = "Red Room";
            room.Description = "You have entered the red room. There is a locked door to the south.";

            room.AddExit(Direction.East);

            // create a mew item
            item = new Item();

            //setup the item
            item.Title = "Blue Ball";
            item.PickupText = "You just picked up the Blue Ball.";

            // add item to the current room
            room.Items.Add(item);
       
            //////////////////////////////////////////////////////////
            // create a new room
            room = new Room();

            // assign this room to location 1,0
            rooms[1, 0] = room;
            // setup the  room
            room.Title = "Blue Room";
            room.Description = "You have entered the blue room.";
            room.AddExit(Direction.West);
            room.AddExit(Direction.South);

            //create a new item
            item = new Item();

            //setup the item
            item.Title = "Anvil";
            item.PickupText = "You struggle to pick up the Anvil.";
            item.Weight = 6;

            // add item to the current room
            room.Items.Add(item);

            // create a mew item
            item = new Item();

            //setup the item
            item.Title = "Green Ball";
            item.PickupText = "You just picked up the Green Ball.";

            // add item to the current room
            room.Items.Add(item);

            // create a new item - KEY
            item = new Item();

            //setup the item
            item.Title = "Key";
            item.PickupText = "You just picked up the Key.";

            // add item to the current room
            room.Items.Add(item);

            //////////////////////////////////////////////////////////
            // create the YELLOW room
            room = new Room();

            // assign this room to location 1,1
            rooms[1, 1] = room;

            // setup the  room
            room.Title = "Yellow Room";
            room.Description = "You have entered the yellow room.";

            room.AddExit(Direction.North);
            room.AddExit(Direction.West);

            // create a mew item
            item = new Item();

            //setup the item
            item.Title = "Red Ball";
            item.PickupText = "You just picked up the Red Ball.";

            // add item to the current room
            room.Items.Add(item);

            //////////////////////////////////////////////////////////
            // create the Green room
            room = new Room();

            // assign this room to location 0,1
            rooms[0, 1] = room;

            // setup the  room
            room.Title = "Green Room";
            room.Description = "You have entered the green room. There is a locked door to the north.";

            room.AddExit(Direction.East);

            // create a mew item
            item = new Item();

            //setup the item
            item.Title = "Yellow Ball";
            item.PickupText = "You just picked up the Yellow Ball.";

            // add item to the current room
            room.Items.Add(item);

            // place player in starting room
            Player.PosX = 0;
            Player.PosY = 0;
        }


    }
}
