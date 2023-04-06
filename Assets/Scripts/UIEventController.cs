using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class UIEventController : MonoBehaviour
{
    Rigidbody[] dynamicObjects;

    [SerializeField] Spawner spawner;
    [SerializeField] Button playButton;
    [SerializeField] Button pauseButton;

    void Start()
    {
        dynamicObjects = FindObjectsOfType<Rigidbody>();

        if (dynamicObjects != null)
            Pause();
    }

    public void OnPlayButtonClicked()
    {
        Play();

        playButton.gameObject.SetActive(false);
        pauseButton.gameObject.SetActive(true);
    }

    public void OnPauseButtonClicked()
    {
        Pause();

        playButton.gameObject.SetActive(true);
        pauseButton.gameObject.SetActive(false);
    }

    public void OnStopButtonClicked()
    {
        Stop();

        playButton.gameObject.SetActive(true);
        pauseButton.gameObject.SetActive(false);
    }

    private void Play()
    {
        Time.timeScale = 1.0f;
    }

    private void Pause()
    {
        Time.timeScale = 0.0f;
    }

    private void Stop()
    {
        Pause();

        spawner.BallReset();
    }
}