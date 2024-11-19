using TMPro;
using UnityEngine;

public class HighlightObject : MonoBehaviour
{
    private Renderer objectRenderer;
    private Color[] originalColors;
    private Color highlightColor = Color.yellow; // ���� ���������

    private void Start()
    {
        // �������� �������� �������
        objectRenderer = GetComponent<Renderer>();

        // ���������� ����������� ����� ���� ���������� ���������
        Material[] materials = objectRenderer.materials;
        originalColors = new Color[materials.Length];
        for (int i = 0; i < materials.Length; i++)
        {
            originalColors[i] = materials[i].color;
        }
    }

    private void OnMouseEnter()
    {
        // �������� ���� ���� ���������� ��� ���������
        Material[] materials = objectRenderer.materials;
        for (int i = 0; i < materials.Length; i++)
        {
            materials[i].color = highlightColor;
        }
    }

    private void OnMouseExit()
    {
        // ���������� ����������� ����� ���� ���������� ��� ����� � �������
        Material[] materials = objectRenderer.materials;
        for (int i = 0; i < materials.Length; i++)
        {
            materials[i].color = originalColors[i];
        }
    }
}
