using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KitchenManager : MonoBehaviour
{

    // Starting time for all racers
    [SerializeField]
    private Vector3 startTime = new Vector3(0, 0, 20);

    [SerializeField]
    private int TotalCustomersThisRound;

    [SerializeField]
    private int TotalSpawnedCustomers;

    [SerializeField]
    private int LostCustomers;

    [SerializeField]
    private int MaxLostCustomers;

    [SerializeField]
    private float currentTime = 0;

    [SerializeField]
    private Text timerDisplay;

    // Start is called before the first frame update
    void Start()
    {

        SetupGame();

    }

    public void SetupGame()
    {

        float hoursInSeconds = startTime.x * 3600;
        float minutesInSeconds = startTime.y * 60;
        float seconds = startTime.z;

        currentTime += hoursInSeconds + minutesInSeconds + seconds;

    }

    // Update is called once per frame
    void Update()
    {

        Countdown();

        if (LostCustomers > MaxLostCustomers)
        {

            EndGame();

        }

    }

    public void Countdown()
    {

        // Start losing time
        currentTime -= Time.deltaTime;

        if (currentTime <= 0) EndGame(); // EndGame when timer reaches 0
        else UpdateDisplayTimer(); // Update display timer with current time

    }

    public void EndGame()
    {


        // Show cursor 
        Cursor.lockState = CursorLockMode.None;

    }

    public void UpdateDisplayTimer()
    {

        // Declare temp integeres
        int hours = 0, minutes = 0, seconds = 0;

        // Convert total time into HMS format
        hours = (int)(currentTime / 3600);
        minutes = ((int)currentTime - (hours * 60)) / 60;
        seconds = ((int)currentTime - (minutes * 60));

        if (seconds < 0) seconds = 0;

        // Put all integers into a string
        string timeToDisplay = string.Format("{0}:{1}:{2}", hours, minutes, seconds);

        // Update string to display
        timerDisplay.text = timeToDisplay;

    }

}
