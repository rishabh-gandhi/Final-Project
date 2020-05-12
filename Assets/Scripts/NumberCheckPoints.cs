﻿using UnityEngine;

[ExecuteInEditMode]
public class NumberCheckPoints : MonoBehaviour {

    private void Awake() {

        Transform[] checkPoints = this.GetComponentsInChildren<Transform>();
        int number = 0;

        foreach (Transform cp in checkPoints) {

            if (cp.gameObject != this.gameObject) {
                cp.gameObject.name = "" + number;
                number++;
            }
        }
    }
}
