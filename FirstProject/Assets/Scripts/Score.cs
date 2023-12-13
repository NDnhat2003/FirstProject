using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    public TextMeshProUGUI scoreText;
       /* void Start() 
    {
        int start = player.position.z
    {*/
        // Update is called once per frame
        void Update()
    {
        int x = -45;
        scoreText.text = (player.position.z - x).ToString("0");
    }
}
