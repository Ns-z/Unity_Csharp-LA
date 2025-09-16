using UnityEngine;

public class Params : MonoBehaviour
{
    void Start()
    {

        StringReturner("enes-string");
        StringReturner("enes-string", "hasan-string");

        StringReturnerParams("hasan-String", "enes-String", "yusuf-string"); // using params string 

    }


    private void StringReturner (string strReturner) {

        Debug.Log (strReturner);
    }

    private void StringReturner(string strReturner, string strReturner2) {

        Debug.Log (strReturner + strReturner2);

    }


    private void StringReturnerParams(params string[] strReturnerParams) {

        Debug.Log (strReturnerParams);
    }



}
