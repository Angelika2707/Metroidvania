﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour
{
    bool can = true;
    void Start()
    {
        
    }
    // Start is called before the first frame update
    void OnTriggerStay2D(Collider2D col)
    {
        if (Input.GetKeyDown(KeyCode.E) && can)
        {
            int x = Random.Range(2, 6);
            col.gameObject.GetComponent<move_player>().Give_money(x);
            can = false;
        }
    }

    // 
}
