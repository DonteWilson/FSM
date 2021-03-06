﻿using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace FSM_Test
{
    [Serializable]
    [XmlRoot("Party")]
    public class Party
    {
        public Party()
        {
            _units = new List<Unit>();
        }
    
        private List<Unit> _units;
        [XmlArray("Party"), XmlArrayItem(typeof(Unit), ElementName = "Unit")]
        public List<Unit> units
        {
            get
            {
                return _units;
            }
            set
            {
                _units = value;
            }
        }
    }
}
