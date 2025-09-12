using UnityEngine;

public class Recursion_1 : MonoBehaviour {
    void Start() {


        //TestRecursion(); // infinite loop stack overflow error

        Debug.Log(RecursionIncrementer(0));
        Debug.Log(RecursionIncrementer2(0, 5, 1)); // same results
    }

    private static void TestRecursion() {
        TestRecursion();
    }

    private static int RecursionIncrementer(int number) {
        if (number < 5) {
            return RecursionIncrementer(number + 1);
        }
        else {
            return number;
        }

    }

    private static int RecursionIncrementer2(int number, int numberMax, int incrementer) {
        if (number < numberMax) {
            return RecursionIncrementer2(number + incrementer, numberMax, incrementer);
        }
        else {
            return number;
        }

    }
}