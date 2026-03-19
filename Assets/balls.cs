using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class balls : MonoBehaviour
{
    public TMP_Text score;
    private int scoreint;

    private void Start()
    {
        score = GameObject.FindFirstObjectByType<TMP_Text>();
    }

    public void Goal(Collider other)
    {
        if (other.CompareTag("goal"))
            Debug.Log("гол");
        scoreint ++;
        score.text = scoreint.ToString();
    }
}
