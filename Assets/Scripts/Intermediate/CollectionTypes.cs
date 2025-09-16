using System.Collections.Generic;
using UnityEngine;

public class CollectionTypes : MonoBehaviour {
    void Start() {


        // Stack First In Last Out 
        Stack<string> nameStack = new Stack<string>();
        nameStack.Push("Enes");
        nameStack.Push("Mehmet");
        nameStack.Push("Hasan");


        Debug.Log(nameStack.Pop()); // pops last item/ string in this -> Hasan  

        // Queue First in First Out
        Queue<string> nameQueue = new Queue<string>();
        nameQueue.Enqueue("Enes-Queue");
        nameQueue.Enqueue("Hasan-Queue");
        
        Debug.Log(nameQueue.Dequeue());

        // Hashset using on unique elements - Every item should be unique
        HashSet<string> namesHashset = new HashSet<string>();
        namesHashset.Add("Enes-Hash");
        namesHashset.Add("Enes-Hash");
        namesHashset.Add("Hasan-Hash");

        Debug.Log(namesHashset.Count); // should be unique so answer is -> this has 2 elements.


    }





}
