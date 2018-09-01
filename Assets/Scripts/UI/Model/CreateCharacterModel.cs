using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UI.Model
{
    public class CreateCharacterModel
    {
        public struct CreateCharacterViewModel
        {
            public uint raceID { get; set; }
            public string raceName { get; set; }
            public string raceDes { get; set; }
            public string initValue { get; set; }
            public string growthValue { get; set; }
            public string raceAbilityOne { get; set; }
            public string raceAbilityTwo { get; set; }
        }

        private List<CreateCharacterViewModel> m_createCharacterViewModels;

        public List<CreateCharacterViewModel> createCharacterViewModels
        {
            get
            {
                return m_createCharacterViewModels;
            }

            set
            {
                m_createCharacterViewModels = value;
            }
        }

    }
    

}
