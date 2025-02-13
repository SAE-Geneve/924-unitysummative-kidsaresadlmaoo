using UnityEngine;

public class BoxDestroyer : MonoBehaviour
{ 
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Boxes"))
        {
            Destroy(other.gameObject);
        }
    }

}
