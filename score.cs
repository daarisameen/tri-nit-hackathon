using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using TMPro;

public class score : MonoBehaviour
{
    // Start is called before the first frame update

    public TextMeshProUGUI text;
    public Transform player;
    // public Text scoreText;

    // Update is called once per frame
    void Update()
    {
        // scoreText.text =
        text.text = player.position.z.ToString("0");
    }
}
