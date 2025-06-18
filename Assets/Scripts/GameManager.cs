using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int round;
    public Text roundNumber;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        round = 1;
    }

    // Update is called once per frame
    void Update()
    {
        roundNumber.text = "Round " + round;
    }
}
