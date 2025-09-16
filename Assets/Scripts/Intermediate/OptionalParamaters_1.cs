using UnityEngine;

public class OptionalParamaters_1 : MonoBehaviour
{

    void Start() {

        //Function Call
        SpawnUnit(new Vector3(0, 0, 1), UnitType.Melee, Quaternion.identity, 100);
        //Function Call - with Default Values so there is no need to call last parameter 
        SpawnUnit2(new Vector3(0, 0, 1), UnitType.Melee, Quaternion.identity);
        // another function call
        SpawnUnit3(health: 60);
    }

    private enum UnitType {

        Melee,
        Ranged,
        Wizard
    }


    void SpawnUnit(Vector3 spawnPosition, UnitType unitType, Quaternion spawnRotation, int health) {

        Debug.Log("Spawn Position: " + spawnPosition + "UnitType: " +  unitType + "Spawn Rotation: " + "Health: " + health);
    }

    //Default value assigned for Health parameter
    // Optional parameters must appear last item 
    void SpawnUnit2(Vector3 spawnPosition, UnitType unitType, Quaternion spawnRotation, int health = 100) { 

        Debug.Log("Spawn Position: " + spawnPosition + "UnitType: " + unitType + "Spawn Rotation: " + "Health: " + health);
    }
    
    // All parameters Has default value 
    void SpawnUnit3(
        Vector3 spawnPosition = default , 
        UnitType unitType = UnitType.Melee, 
        Quaternion spawnRotation = default,    // Quaternion.identity, // not compile time constant 
        int health = 100) {

        Debug.Log("Spawn Position: " + spawnPosition + "UnitType: " + unitType + "Spawn Rotation: " + "Health: " + health);
    }
}
