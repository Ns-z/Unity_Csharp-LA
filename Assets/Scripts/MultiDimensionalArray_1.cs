using System;
using UnityEngine;

public class MultiDimensionalArray_1 : MonoBehaviour {
    void Start() {


        int[,] MultiDimensionArray = new int[3, 4]; // initialized 0(zero) all values

        int[][] ArraysOfArray = new int[3][];

        for (int i = 0; i < ArraysOfArray.Length; i++) {
            Debug.Log(ArraysOfArray[i]); // returns null reference types
            
        }

        Debug.Log("finished");


        //jagged array different size 
        ArraysOfArray[0] = new int[3];
        ArraysOfArray[1] = new int[5];

        for (int i = 0; i < MultiDimensionArray.GetLength(0); i++) {
            for (int j = 0; j < MultiDimensionArray.GetLength(1); j++) {
                Debug.Log(MultiDimensionArray[i, j]);
            }

        }
    }

}