using UnityEngine;

public class ReferenceTypes_ValueTypes : MonoBehaviour
{

    //Value Types :  (contains their data )
    // int, float, bool, enum, struct
    // Reference Types : (store references to their Data )
    // class , object, array, string
    void Start() {

        // Class Reference Type -> so when we initialize myClass2 , actually giving reference adress of myClass.
        MyClass myClass = new MyClass();
        myClass.a = 1;
        MyClass myClass2 = myClass;
        myClass2.a = 2;

        Debug.Log("Class Result: " + myClass.a); // gives = 2 for changing myClass.a

        // Struct Value Type -> this time we initialize myStruct2 we giving copy of the myStruct , not the adress of the actual object , just different copy object.
        MyStruct myStruct = new MyStruct();
        myStruct.a = 1;
        MyStruct myStruct2 = myStruct;
        myStruct2.a = 2;

        Debug.Log("Struct Result: " + myStruct.a); // gives = 1 for not changing myStruct.a

        //Same value Type

        int a = 3;
        int b = a;
        b = 5;

        Debug.Log("value of b: " + b);
        Debug.Log("value of a: " + a);


        // Another Value - Reference Type Action
        int c = 6;
        int[] intArray = new int[] { 7 };  // initalized with 7

        MyFunction(c, intArray);
        Debug.Log("c: " + c + " intArray[]: " + intArray[0]); // -> c : 6  intArray[0] : 5

    }

    private void MyFunction(int c, int[] intArray) {

        c = 5;
        intArray[0] = 5;
    }

    private class MyClass
    {

        public int a;
    }

    private struct MyStruct
    {

        public int a;
    }

    

}
