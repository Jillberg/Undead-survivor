using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartPanel : MonoBehaviour
{

    private Button StartButton;
    void Start()
    {
        StartButton = transform.Find("StartButton").GetComponent<Button>();
        StartButton.onClick.AddListener(StartButtonClick);

    }

    void Update()
    {
        
    }
    private void StartButtonClick()
    {

    }
}
