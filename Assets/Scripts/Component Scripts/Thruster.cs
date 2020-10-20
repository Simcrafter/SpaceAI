﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thruster : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}

/*This class is what we access when we create a new instance of the prefab,
 * Essentially, we're assigning our own variables, and subsequently values to each prefab, 
 * so that we can change them locally on each new instance of a ship,
 * or component being added to a ship
**/
public class ThrusterTraits
{
    /*Here is where we tell it what var type we want, and whether 
     * it's read-only (get;), write-only (set;), or read-write (get; set;)
    **/
    //Property definitions
    public bool[] validPlace { get; set; } = new bool[4]; //Top, Right, Bottom, Left
    public int mass { get; set; }
    public float acc { get; set; }

    /* Here is where we actually use those previously made definitions
    * And by setting values to them here, we essentially 'construct' them
    * avoiding object null errors when we compile.
    * In addition to increasing the ease with which we can access these variables from other scripts
    **/
    //Instance Constructor
    public ThrusterTraits()
    {
        validPlace = new bool[4] { true, true, false, true }; //Top, Right, Bottom, Left
        mass = 1;
        acc = 0.1f; 
    }
}