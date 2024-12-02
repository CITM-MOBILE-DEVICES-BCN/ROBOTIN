using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PauseMenuPopUp : MonoBehaviour
{
    [SerializeField] Button continueButton;
    [SerializeField] Button exitButton;
    private void Start()
    {
        continueButton.onClick.AddListener(OnPauseButtonClicked);
        exitButton.onClick.AddListener(OnExitButtonClicked);
    }

    private void OnPauseButtonClicked()
    {
        GameManager.instance.UnLoadPopUp(gameObject.name);
        //You can add a resume game function here
    }

    private void OnExitButtonClicked()
    {
        GameManager.instance.LoadScene("RobotinMeta");
    }
}
