using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public static class Extensions
{
    /// <summary>
    /// Checks to see if the component in the inspector is set, use on anything that must have the component to warn of any changes to the system.
    /// </summary>
    /// <param name="gameObj"></param>
    public static bool IsGameObjectSet(this object gameObj) => gameObj.Equals(null);
}

