using UnityEngine;

public class ClassIntermediate_1 : MonoBehaviour
{
    void Start()
    {

        Unit unit = new Unit();
        Character character = new Character("Enes");
        Enemy enemy = new Enemy();

        unit.Move();
        character.Move();
        enemy.Move();

        // ToString function automatically implemented on every class objects.
        // so you can override ToString function
        Debug.Log(character.ToString());
        Debug.Log(character); // ToString Function automatically called.
         
    }

    public class Unit {

        public int speed;
        
        public virtual void Move() {
            Debug.Log("Move");
        }
    }
    
    public class Enemy : Unit {

        public override void Move() {
            Debug.Log("Move Enemy");
        }
    }

    // has a override function Inheritance
    public class Character : Unit {

        public string playerName;

        public Character(string playerName) {
            speed = 5;
            this.playerName = playerName;
        }


        public override void Move() {
            Debug.Log("Move Character");
        }

        // Trying Override ToString Function
        public override string ToString() {
            return "Player: " + playerName;
        }
    }

}


