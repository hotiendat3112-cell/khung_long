using UnityEngine;

public class Obstacles : MonoBehaviour
{
    public float leftBoundary = -10f; // The left boundary of the screen
    
    void Update()
    {
        MoveObstacle();
    }
    private void MoveObstacle()
    {
        transform.position+=Vector3.left*GameManager.instance.GetGameSpeed()*Time.deltaTime;
        if (transform.position.x < leftBoundary)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            GameManager.instance.GameOver();
        }
    }
}
