using NUnit.Framework.Internal;
using UnityEditor.Build;
using UnityEngine;

public class Structs_1 : MonoBehaviour
{

    //Structs
    //Structs are value type. So in memory they stored in stacks . instead of heaps
    // Stack memory are much more efficient than stack memory. You can use whenever neccessary.
    // Should use in immutable data(data shouldn't change), different pieces of data together. Also better memory performances
    void Start()
    {
        
        // this is Vector3 Struct field 
        transform.position = new Vector3(0, 0, 0); // =5; you cannot assign like this , you can just assign like new Vector3(). -> this is also copy.
        
        // normally struct is immutable but u can change the values like this.
        // creates Vector3 Struct variable and initialize
        Vector3 position = new Vector3(10, 20, 21);
        position.Normalize(); // struct function
        Debug.Log(position);

        //Struct Create 
        WeaponStruct weapon = new WeaponStruct();
        WeaponStruct weapon1 = default; // initalized value type 
        Debug.Log("Struct : " + weapon1); //because structs value type this returns 0. -> initialized 0
        Debug.Log("Struct a: " + weapon.a);
        Debug.Log("Struct a: " + weapon1.a); 

        //using class
        WeaponClass weapon2 = default;   // initialized reference type so --> this is null 
        Debug.Log(weapon2);  // returns null
        Debug.Log("Class a: " + weapon2.a); // becauses of the class object null - there is no field


        /////////////////////
        // Initialize Struct
        WeaponStruct weapon3 = new WeaponStruct();
        WeaponStruct weapon4 = new WeaponStruct() { a = 2 };
        WeaponStruct weapon5 = default;

    }

    // value type, so immutable for fields -> just copying values and creates new ones
    public struct Player {

        public float x; 
        public float y;
    }
   
    // Structs can use Constructor but all field variable must use in Constructor --> C# version higher it changess
    // Also Structs can't use Inheritance
    public struct WeaponStruct {

        public int a;
        
        //Struct Constructor
        public WeaponStruct(int a) {
            this.a = a;
        }
    }

    // Can use Inheritance
    private class WeaponClass: ExampleInheritance {

        public int a;

        //Class Constructor
        public WeaponClass(int a) {
            this.a = a;
        }

    }

    private class ExampleInheritance {

        public int adressValue;
    }
}
