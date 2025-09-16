using UnityEngine;
using System;

public class LearnEnums_1 : MonoBehaviour {

    public void Start() {
        Debug.Log("Starting Enums --> ");


        // Enum.Parse -> enum turune erisebilmek icin using System; kutuphanesi implemente edildi.

        // Enum degerleri stringe cevrildi.
        PlayerActions playerActions1 = PlayerActions.PlayerStart;
        string playerActionString = playerActions1.ToString();
        Debug.Log(playerActionString);
        
        // Burada stringe cevrilmis enum degerlerini tekrar Enuma cevirip yazdiriyoruz
        Debug.Log("ikinci part");
        Debug.Log(Enum.Parse<PlayerActions>(playerActionString));
        
        //  foreach dongusu ile bu sekilde Enum degerlerini dondurebiliriz/
        Debug.Log("third part \\\\");
        foreach (PlayerActions playerActions in Enum.GetValues(typeof(PlayerActions))) {
            Debug.Log(playerActions);

        }
    }

    public enum PlayerActions {
        PlayerStart,
        PlayerPause,
        PlayerResume
    }



}
