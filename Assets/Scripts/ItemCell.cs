using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Oxygenist
{
    public class ItemCell : MonoBehaviour
    {
        [SerializeField]
        private Image baseImage;

        public void Initialize(Item item)
        {
            baseImage.sprite = item.sprite;
        }
    }
}