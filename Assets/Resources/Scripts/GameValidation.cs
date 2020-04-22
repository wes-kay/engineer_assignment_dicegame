using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameValidation : MonoBehaviour
{
    protected void CheckComponent(object obj)
    {
        if (obj.IsGameObjectSet())
        {
            Debug.LogError($"{this.name} is missing a component, please check the inspector for required component.");
        }
    }
}
