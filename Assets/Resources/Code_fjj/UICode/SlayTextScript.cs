﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlayTextScript : MonoBehaviour
{
    private int Buf;
    void Start()
    {
        SelfUpdate();
    }

    private void SelfUpdate()
    {
        Buf = DataManager.roleEquipment.GetSlayCount();
        GetComponent<Text>().text = "剩余必杀次数：" + Buf.ToString();
    }

    void Update()
    {
        if (Buf != DataManager.roleEquipment.GetSlayCount())
        {
            SelfUpdate();
        }
    }
}