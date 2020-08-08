using EmeraldAI;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RTS.Core
{
    public class Unit : MonoBehaviour
    {
        EmeraldAISystem emeraldAI;

        private string id;
        private bool selected = false;

        [Serializable]
        public struct AbilityRangeTransform
        {
            public string name;
            public Transform rangedTransform;
        }
        [SerializeField] AbilityRangeTransform[] rangeTransforms;

        private void Awake()
        {
            id = UnityEditor.GUID.Generate().ToString();
            emeraldAI = GetComponent<EmeraldAISystem>();
        }

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            
        }

        public void OnAbilityUsed()
        {
            foreach (AbilityRangeTransform abilityRangeTransform in rangeTransforms)
            {
                if (abilityRangeTransform.name == emeraldAI.m_EmeraldAIAbility.name)
                {
                    emeraldAI.RangedAttackTransform = abilityRangeTransform.rangedTransform;
                    break;
                }
            }
        }

        public string GetID()
        {
            return id;
        }

        public bool IsSelected()
        {
            return selected;
        }

        public void SetSelected(bool selected)
        {
            this.selected = selected;
        }
    }
}