﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hurtbox : MonoBehaviour {
    public HitboxManager associatedMeleeMechanics;
    #region monobehaviour methods
    private void Awake()
    {
        associatedMeleeMechanics.AddAssociateHurtbox(this);
    }

    private void OnDestroy()
    {
        associatedMeleeMechanics.RemoveAssociatedHurtbox(this);
    }
    #endregion monobehaviour methods


}
