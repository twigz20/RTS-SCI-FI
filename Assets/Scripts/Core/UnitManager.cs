using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RTS.Core
{
    public class UnitManager : MonoBehaviour
    {
        List<Unit> units;

        private void Awake()
        {
            units = new List<Unit>();
        }

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}