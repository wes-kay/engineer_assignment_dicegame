using UnityEngine;


public class EventHandler : GameValidation
{
    [SerializeField]
    Canvas canvas;

    [SerializeField]
    RectTransform mainUI, statsUI, gameUI;

    [SerializeField]
    StatsView statsView;

    [SerializeField]
    RectTransform backButton;

    [SerializeField]
    RectTransform reroll, tapToRoll;

    bool _isRolling;
    public bool IsRolling
    {
        get
        {
            return _isRolling;
        }
        set
        {
            tapToRoll.gameObject.SetActive(value);
            _isRolling = value;
        }
    }

    RectTransform currentView, lastView;
    public void Start()
    {
        GameManager.eventHandler = this;
        CheckComponent(mainUI);
        CheckComponent(statsUI);
        CheckComponent(gameUI);
        CheckComponent(statsView);
        CheckComponent(backButton);
        CheckComponent(reroll);
        CheckComponent(tapToRoll);

        currentView = mainUI;
        ShowUI();
        statsUI.gameObject.SetActive(false);
        gameUI.gameObject.SetActive(false);
    }

    public void ShowUI(bool value = true) => canvas.enabled = value;

    public void InvokedEventPlay()
    {
        CloseUIElement(gameUI);
        GameManager.game.StartGame();
    }

    public void InvokedEventStats()
    {
        CloseUIElement(statsUI);
        statsView.SetStats(GameManager.game.player, GameManager.game.bot);
    }
    public void CloseUIElement()
    {
        CloseUIElement(lastView);
        backButton.gameObject.SetActive(false);
    }

    public void InvokeReroll()
    {

    }
    public void CloseUIElement(RectTransform rectTransform)
    {
        currentView.gameObject.SetActive(false);
        lastView = currentView;
        currentView = rectTransform;
        currentView.gameObject.SetActive(true);
        backButton.gameObject.SetActive(true);
    }
}
