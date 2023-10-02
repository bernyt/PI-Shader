using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    [SerializeField]
    private float timer = 15f;
    private TextMeshProUGUI timerSeconds;

    // Start is called before the first frame update
    void Start()
    {
        timerSeconds = GetComponent<TextMeshProUGUI>();    
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        timerSeconds.text = timer.ToString("f0");
        if (timer <= 0)
        {           
            Debug.Log("Vitória!");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}