using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class InputManager
{
    private static GameControls _gameControls;
    public static void Init(Player myPlayer)
    {
        _gameControls = new GameControls();

        _gameControls.InGame.Enable();

        _gameControls.InGame.FightVirus.performed += ctx => 
        {
           // myPlayer.FightVirus();
        };
    }

    public static void SetGameControls()
    {
        _gameControls.InGame.Enable();
    }
}

