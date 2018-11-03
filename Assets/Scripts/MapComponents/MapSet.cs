using UnityEngine;
using System.Collections;

namespace MapComponents
{
    [CreateAssetMenu(fileName = "map_set", menuName = "Map Set")]
    public class MapSet : ScriptableObject
    {
        public GameObject doorUpDown;
        public GameObject doorLeftRight;
        public GameObject corridorTurnUpLeft;
        public GameObject corridorTurnUpRight;
        public GameObject corridorTurnDownLeft;
        public GameObject corridorTurnDownRight;
        public GameObject cooridorStraightLeftRight;
        public GameObject corridorStraightUpDown;
        public GameObject cooridor4Way;
        public GameObject startRoom;
        public GameObject endRoom;
        public GameObject[] rooms;
    }

}