using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitArmour {
    //private fields
    int _currentArmour;
    int _maxArmour;

    //properties
    public int Armour {
        get { return _currentArmour; }
        set { _currentArmour = value; }
    }
    public int MaxArmour {
        get { return _maxArmour; }
        set { _maxArmour = value; }
    }

    //constructor
    public UnitArmour(int armour,int maxArmour) {
        _currentArmour = armour;
        _maxArmour = maxArmour;
    }
}
