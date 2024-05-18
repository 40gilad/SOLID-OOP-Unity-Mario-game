using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SC_GameManager : MonoBehaviour
{
    private PlatformController platformController;
    public SC_MovingPlatform scMovingPlatform;
    public SC_FadePlatform scFadePlatform1;
    public SC_FadePlatform scFadePlatform2;
    public SC_Enemy sc_sliding_player;
    public SC_ResetPosition _reset_position;
    private string ui_wellDone_go_name = "UI_WellDone";



    private void OnEnable()
    {
        SC_Mario.MarioDead += RestartGame;
        SC_Door.OnDoorCollision += FinishGame;
    }


    private void OnDisable()
    {
        SC_Mario.MarioDead -= RestartGame;
        SC_Door.OnDoorCollision -= FinishGame;


    }
    void Start()
    {
        GameObject cameraObject = GameObject.FindWithTag("MainCamera");
        platformController = new PlatformController();
        scMovingPlatform.Activate();
        UiManager.Instance().UnActiveColUI(ui_wellDone_go_name);
        platformController.ActivatePlatform(scFadePlatform1);
        platformController.ActivatePlatform(scFadePlatform2);
    }

    private void FinishGame()
    {
        UiManager.Instance().UnActiveColUI();
        UiManager.Instance().ActiveColUI(ui_wellDone_go_name);
        Time.timeScale = 0f; // Freezes the scene

    }

    private void RestartGame()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex);
    }
    private void ResetPosition()
    {
        _reset_position.OnResetPosition();
    }


}