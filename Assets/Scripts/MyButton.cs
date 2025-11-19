using UnityEngine;
using UnityEngine.UI;

public class MyButton : MonoBehaviour
{
    [SerializeField] private Button linkedButton; // Ссылка на связанную кнопку на другой картинке
    [SerializeField] private Counter myCounter; // Общий статический счётчик отличий

    private Button myButton;
    private Image myImage;

    void Start()
    {
        myButton = GetComponent<Button>();
        myImage = GetComponent<Image>();
        myButton.onClick.AddListener(ActivateLinkedButton);
    }

    void ActivateLinkedButton()
    {
        // Проверяем, активна ли кнопка, чтобы избежать повторного увеличения счёта
        if (myButton.interactable)
        {
            // Увеличиваем счётчик отличий
            if (myCounter != null)
            {
                myCounter.stock++;
            }

            // Меняем цвет текущей кнопки на белый
            myImage.color = Color.white;

            // Активируем связанную кнопку
            if (linkedButton != null && linkedButton.gameObject.activeInHierarchy)
            {
                // Меняем цвет связанной кнопки на белый
                Image linkedImage = linkedButton.GetComponent<Image>();
                if (linkedImage != null)
                {
                    linkedImage.color = Color.white;
                }

                // Деактивируем связанную кнопку, чтобы она больше не реагировала на нажатия
                linkedButton.interactable = false;
            }

            // Деактивируем текущую кнопку, чтобы она больше не реагировала на нажатия
            myButton.interactable = false;
        }
    }
}