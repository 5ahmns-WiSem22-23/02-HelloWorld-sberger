using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TextController : MonoBehaviour
{
    public TextMeshProUGUI output;
    public InputField input;

    public void ChangeText()
    {
        output.text = input.text;
    }
}
