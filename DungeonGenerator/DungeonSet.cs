using UnityEngine;
using System.Collections;
using System.Collections.Generic;


namespace EL.Dungeon {
    [CreateAssetMenu(fileName = "NewDungeonSet", menuName = "DungeonGenerator/DungeonSet", order = 1)]
    public class DungeonSet : ScriptableObject {

        public string name = "";

        public List<Room> spawns = new List<Room>();
        public List<Room> bosses = new List<Room>();
        public List<Door> doors = new List<Door>();
        public List<Room> roomTemplates = new List<Room>();
        
    }
}
