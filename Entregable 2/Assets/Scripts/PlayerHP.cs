using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHP : MonoBehaviour
{

    [SerializeField] private bool isGameOver;
    private int playerHP = 150;
    public int damage = 60;
    //Declaracion de las variables "playerHP" y "damage"
    void Start()
    {
        playerHP = playerHP - damage;
    }

    // Update is called once per frame
    void Update()
    {
        if (isGameOver == false && playerHP <= 0)
        {
            Debug.Log("Te has quedado sin vida… GAME OVER");
        } else if (playerHP < 30)

        {
            Debug.Log("¡¡¡Tienes poca vida!!!");
        } else

        {
            Debug.Log($"Vas bien de vida: tienes {playerHP} puntos de vida");
        }

        if (isGameOver != false) 
        {
            Debug.Log("GAME OVER");
        }
    }
}
