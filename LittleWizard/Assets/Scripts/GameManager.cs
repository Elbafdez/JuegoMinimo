using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private int playerLives = 6;
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject gameOver;
    [SerializeField] public GameObject[] hearts;

    void Update()
    {
        if (playerLives <= 0)
        {
            Destroy(player);
            Time.timeScale = 0;
            gameOver.SetActive(true);
        }
    }

    public void ReducirVida()
    {
        playerLives--;
        Debug.Log("Vidas: " + playerLives);

        if (playerLives <= 0)
        {
            gameOver.SetActive(true);
        }

        RestarVidaUI();
    }

    private void RestarVidaUI()
    {
        hearts[playerLives].SetActive(false);
    }
}
