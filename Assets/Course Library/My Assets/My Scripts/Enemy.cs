using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] float speed = 2.0f;
    private Rigidbody enemyRb;
    private GameObject player;
    [SerializeField] float lowerBound = -5f;
    public ScoreManager scoreManage;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
        scoreManage = FindAnyObjectByType<ScoreManager>();
        
    }

    // Update is called once per frame
    void Update()
    {
       
        Vector3 lookDirection = (player.transform.position - transform.position).normalized;
        enemyRb.AddForce((player.transform.position - transform.position).normalized * speed);
        
        if(transform.position.y < lowerBound)
        {
            Debug.Log("Enemy died");
            scoreManage.AddScore(10);
            Destroy(gameObject);

        }
    }
}
