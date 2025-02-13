using UnityEngine;

public class BoxesSpawn : MonoBehaviour
{
    public GameObject box;
    public float SpawnRate = 5;
    private float timer = 0;
    
    void Start()
    {
        SpawnBox();
    }

    void Update()
    {
        if (timer < SpawnRate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            SpawnBox();
            timer = 0;
        }
    }

    void SpawnBox()
    {
        Instantiate(box, transform.position, transform.rotation);
    }
}
