using UnityEngine;
using System;



public class Properties_1 : MonoBehaviour {




    public class Enes {

        // properties not variables
        public string MyName { get; set; }
        public string MyDescription { get; private set; } = "0x163";
        public string MyType { private get; set; }


        // properties how actually work ==-- Same thing on top -- 
        private string variable;
        
        // variable returns in VariableProperty
        public string VariableProperty {
            get 
            {
                return variable;
            }
            set
            {

                variable = value;

                
            }
        }



        // You can add Extra Logic to your property 
        public string VariablePropertyExtraLogic {
            get
            {
                if (variable == null) {
                    return "Unknown Variable";
                }
                else
                    return variable;
            }
            set
            {
                if (value == "Lizard") {
                    
                    //Error Message
                    throw new Exception("Cannot Named as Lizard");
                }
                else {
                    variable = value;
                }


            }

        }
    }

    // another property implementation
    private static string playerNameOfClass {  get; set; }

    private static void SetPlayerName(string name) {
        
        playerNameOfClass = name;

    }

    private static string GetPlayerName() {
        return Properties_1.playerNameOfClass;
    }


    // and also u can use on Singleton Implementation - any other class can be get but just can be set in just this class.
    public static Properties_1 Instance { get; private set; }


    void Start() {

        Enes enes1 = new Enes();
        enes1.MyName = "enes";
        Debug.Log(enes1.MyName);
        Debug.Log(enes1.MyDescription);
        enes1.MyType = "Tall";

        //Debug.Log(enes1.MyType); // error property has a private sets
        
        
        enes1.VariablePropertyExtraLogic = "Crocodile";
        Debug.Log(enes1.VariablePropertyExtraLogic);

        // error exception - so code stops running
        enes1.VariablePropertyExtraLogic = "Lizard";
        Debug.Log(enes1.VariablePropertyExtraLogic);
       

    }



}

