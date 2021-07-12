using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

    private void Awake()
    {
        UiController.onStartGame += onStartGame;
    }

    private void onStartGame(object sender, System.EventArgs e)
    {
        //TODO: coroutine to start generating blocks and checking for coincidences
    }

}
