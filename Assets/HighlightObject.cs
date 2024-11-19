using TMPro;
using UnityEngine;

public class HighlightObject : MonoBehaviour
{
    private Renderer objectRenderer;
    private Color[] originalColors;
    private Color highlightColor = Color.yellow; // Цвет подсветки

    private void Start()
    {
        // Получаем рендерер объекта
        objectRenderer = GetComponent<Renderer>();

        // Запоминаем изначальные цвета всех материалов рендерера
        Material[] materials = objectRenderer.materials;
        originalColors = new Color[materials.Length];
        for (int i = 0; i < materials.Length; i++)
        {
            originalColors[i] = materials[i].color;
        }
    }

    private void OnMouseEnter()
    {
        // Изменяем цвет всех материалов при наведении
        Material[] materials = objectRenderer.materials;
        for (int i = 0; i < materials.Length; i++)
        {
            materials[i].color = highlightColor;
        }
    }

    private void OnMouseExit()
    {
        // Возвращаем изначальные цвета всех материалов при уходе с объекта
        Material[] materials = objectRenderer.materials;
        for (int i = 0; i < materials.Length; i++)
        {
            materials[i].color = originalColors[i];
        }
    }
}
