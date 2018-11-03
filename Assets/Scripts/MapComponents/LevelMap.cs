using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MapComponents
{
    public class LevelMap : MonoBehaviour
    {

        public int width = 0;
        public int height = 0;
        public int mapComponentTileSize = 6;

        public enum MapComponent { Empty = 0, Corridor = 1, Room = 2, Door = 3 }

        private MapComponent[,] mapLayout;

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
    }

}