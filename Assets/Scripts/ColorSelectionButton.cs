using UnityEngine;
using UnityEngine.UI;

public class ColorSelectionButton : MonoBehaviour
{
    public Button uiButton;
    public Image paddleReference;

    public bool isColorPLayer = false;

    public void OnButtonClick()
    {
        paddleReference.color = uiButton.colors.normalColor;

        if (isColorPLayer)
        {
            SaveController.instance.colorPlayer = paddleReference.color;
        }
        else
        {
            SaveController.instance.colorEnemy = paddleReference.color;
        }
    }
}
