using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using YG;


public class BonusButton : MonoBehaviour
{
    [SerializeField] private List<Button> allDifferenceButtons; // Список всех кнопок отличий
    [SerializeField] private Counter myCounter; // Общий статический счётчик отличий

    private Button myButton;

    void Start()
    {
        myButton = GetComponent<Button>();
        myButton.onClick.AddListener(RevealRandomDifference);
    }

    void RevealRandomDifference()
    {
        YandexGame.RewVideoShow(0);
        // Получаем список неактивных кнопок отличий
        var inactiveButtons = allDifferenceButtons.Where(button => button.interactable).ToList();

        // Проверяем, есть ли еще не найденные отличия
        if (inactiveButtons.Count > 0)
        {
            // Выбираем случайное отличие из списка
            var randomButton = inactiveButtons[Random.Range(0, inactiveButtons.Count)];
            // Активируем выбранную кнопку
            randomButton.onClick.Invoke();

            // Увеличиваем счётчик отличий
            if (myCounter != null)
            {
                //ßmyCounter.stock += 0.5f;
            }
        }
        else
        {
            Debug.Log("Все отличия уже найдены!");
        }
    }
}