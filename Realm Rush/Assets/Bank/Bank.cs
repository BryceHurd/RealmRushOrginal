using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;


public class Bank : MonoBehaviour
{
    [SerializeField] int StartingBlance = 150;

    [SerializeField] int currentBalance;
    public int CurrentBalance { get { return currentBalance;  } }

    [SerializeField] TextMeshProUGUI displayBalnce;
    private void Awake()
    {
        currentBalance = StartingBlance;
        UpdateDisplay();
    }

    public void Desposit(int amount)
    {
        currentBalance += Mathf.Abs(amount);
        UpdateDisplay();
    }

    public void Withdraw(int amount)
    {
        currentBalance -= Mathf.Abs(amount);
        if(CurrentBalance < 0)
        {
            //Lose the Game;
            reloadScene();
        }
        UpdateDisplay();
    }

    void UpdateDisplay()
    {
        displayBalnce.text = "Gold: " + currentBalance;        
    }

    void reloadScene()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(currentScene.buildIndex);
    }
}
