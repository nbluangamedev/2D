using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuPanel : MonoBehaviour
{
    [SerializeField] private GameObject howToPlayImage;
    [SerializeField] private GameObject howToPlayButton;
    public void OnStartButtonClick()
    {
        if (UIManager.HasInstance)
        {
            UIManager.Instance.ActiveMenuPanel(false);
            UIManager.Instance.ActiveLoadingPanel(true);
        }

        if (AudioManager.HasInstance)
        {
            AudioManager.Instance.PlayBGM(AUDIO.BGM_BGM_02, 0.5f);
        }
    }

    public void OnSettingButtonClick()
    {
        if (UIManager.HasInstance)
        {
            UIManager.Instance.ActiveSettingPanel(true);
        }
    }

    public void OnExitButtonClick()
    {
        if (GameManager.HasInstance)
        {
            GameManager.Instance.EndGame();
        }
    }

    public void OnHowToPlayButtonClick()
    {
        howToPlayImage.SetActive(true);
        howToPlayButton.SetActive(false);
    }

    public void OnHowToPlayButtonImgClick()
    {
        howToPlayImage.SetActive(false);
        howToPlayButton.SetActive(true);
    }
}
