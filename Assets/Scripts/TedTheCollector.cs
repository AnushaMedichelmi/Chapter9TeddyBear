using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TedTheCollector : MonoBehaviour
{
    #region Fields
    List<GameObject> pickups = new List<GameObject>();
    #endregion
    #region Properties
    /// <summary>
    /// Gets the next target pickup for the teddy bear to collect
    /// </summary>
    /// <value>target pickup</value>
    public GameObject TargetPickup
    {
        get { return null; }
    }
    #endregion
    
    /// <summary>
    /// Update is called once per frame
    /// </summary>
    void Update()
    {
    }
    /// <summary>
    /// Removes the given pickup from the game
    /// </summary>
    /// <param name="pickup">the pickup to remove</param>
    /// 
   
    public void RemovePickup(GameObject pickup)
    {
    }
    
}


