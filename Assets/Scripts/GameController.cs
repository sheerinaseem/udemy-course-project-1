using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {
    [SerializeField]
    private InputField input;

    void Awake()
    {
        //input = GameObject.Find("InputField").GetComponent<InputField>();
    }

    public void GetInput(string guess)
    {
        Debug.Log("You Entered " + guess);
        input.text = "";
    }
}
