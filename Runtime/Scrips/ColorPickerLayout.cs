using UnityEngine;
using MPewsey.HexagonalUI;


namespace Runette
{
    namespace ColorPalette 
    {   
        public class ColorPickerLayout : HexLayoutGroup
        {
            public int NumberOfColors;
            public GameObject ColorPrefab;

            protected override void Start()
            {
                base.Start();
                for (int i = 0; i < NumberOfColors; i++)
                {
                    Instantiate(ColorPrefab, transform);
                }
            }
        }
    }
}