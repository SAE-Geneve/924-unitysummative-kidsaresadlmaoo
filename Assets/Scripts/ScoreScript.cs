using UnityEngine;

public class ScoreScript : MonoBehaviour
{
    public ScoreManager scoreManager;
    
    void Start()
    {
        scoreManager = GameObject.FindWithTag("scoreManager").GetComponent<ScoreManager>();
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Boxes")
        {
            scoreManager.AddScore(1);
        }
    }
}
