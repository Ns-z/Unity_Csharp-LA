using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class NestedLoops_1 : MonoBehaviour {
    void Start() {


        // BREAK AND CONTINUE can be use with any kind of loop for, foreach , do-while 

        int[,] array1 = new int[3, 4];

        for (int i = 0; i < array1.GetLength(0); i++) {
            for (int j = 0; j < array1.GetLength(1); j++) {

                Debug.Log(array1[i, j]);

                if (i == 0) {

                    // break; // breaks inner loop
                    continue; // skips next phase
                }
            }
        }


        Game game = new Game();

        game.playerList = new List<Player>();
        game.playerList.Add(game.specialPlayer);
        game.playerList.Add(new Player());
        game.playerList.Add(new Player());

        foreach (Player playerType in game.playerList) {
            if (playerType == game.specialPlayer) {
                continue; // we can continue like this times. skips this cycle

            }
            Debug.Log(playerType);
        }
    }

     public class Game {

        public Player specialPlayer = new Player();
        public List<Player> playerList = new List<Player>();


    }

    public class Player {

        public int id;
    }
}
