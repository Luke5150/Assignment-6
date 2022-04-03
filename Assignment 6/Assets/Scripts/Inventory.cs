using System.Collections;
using UnityEngine;
using System.Collections.Generic;
namespace Assets.Scripts
{
    public class Inventory : MonoBehaviour
    {
        [SerializeField] private InventoryItem item;
        public List<InventoryItem> inventory;

        // Use this for initialization
        void Start()
        {
            item = new InventoryItem();

        }
        // Update is called once per frame
        void Update()
        {

        }
    }
}