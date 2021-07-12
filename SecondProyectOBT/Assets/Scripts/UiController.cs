using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiController : MonoBehaviour
{
    public static event EventHandler onStartGame;
    public static event EventHandler onEndGame;
    [SerializeField] private Text balance;
    [SerializeField] private Text prize;
    private MatrixController matrix;

    private void Awake()
    {
        balance.enabled = true;
        prize.enabled = true;
    }

    private void OnStartGame()
    {
        //TODO: extract balance from a file (should be a database with player stats)
        onStartGame?.Invoke(this, EventArgs.Empty);
    }
}
