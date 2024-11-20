using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MetaScreen : MonoBehaviour
{
    [SerializeField] Button shopButton;
    [SerializeField] Button backToMenuButton;
    [SerializeField] Button world1Button;
    [SerializeField] Button world2Button;
    [SerializeField] Button world3Button;

    [SerializeField] GameObject shopScreen;
    [SerializeField] GameObject world1;
    [SerializeField] GameObject world2;
    [SerializeField] GameObject world3;

    private void Start()
    {
        shopButton.onClick.AddListener(OnShopButtonClicked);
        backToMenuButton.onClick.AddListener(OnBackToMenuButtonClicked);
        world1Button.onClick.AddListener(OnWorld1ButtonClicked);
        world2Button.onClick.AddListener(OnWorld2ButtonClicked);
        world3Button.onClick.AddListener(OnWorld3ButtonClicked);

    }

    private void OnShopButtonClicked()
    {
        GameManager.instance.LoadScreen(shopScreen);
    }

    private void OnBackToMenuButtonClicked()
    {
        GameManager.instance.LoadScene("Lobby");
    }

    private void OnWorld1ButtonClicked() 
    {
        GameManager.instance.LoadScreen(world1);
    }

    private void OnWorld2ButtonClicked()
    {
        GameManager.instance.LoadScreen(world2);
    }

    private void OnWorld3ButtonClicked()
    {
        GameManager.instance.LoadScreen(world3);
    }
}