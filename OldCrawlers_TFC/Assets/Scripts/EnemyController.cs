using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] private float maxEnemyDistance;

    [SerializeField] private float minEnemyDistance;
    
    [SerializeField] private float enemySpeed;
    
    private Animator enemyAnim;
    private Transform targetFollow;
    public Transform respawnPosition;
    
    // Start is called before the first frame update
    void Start()
    {
        enemyAnim = GetComponent<Animator>();
        targetFollow = FindObjectOfType<PlayerMovement>().transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(targetFollow.position, transform.position) <= maxEnemyDistance && Vector3.Distance(targetFollow.position, transform.position) >= minEnemyDistance)
        {
            FollowPlayer();     
        }
        else if(Vector3.Distance(targetFollow.position, transform.position) >= maxEnemyDistance)
        {
            RespawnEnemy();
        }
       
    }

    public void RespawnEnemy()
    {
        transform.position = Vector3.MoveTowards(transform.position, respawnPosition.position, enemySpeed * Time.deltaTime);
        enemyAnim.SetFloat("moveX", (targetFollow.position.x - transform.position.x));
        enemyAnim.SetFloat("moveY", (targetFollow.position.y - transform.position.y));
        transform.position = Vector3.MoveTowards(transform.position, targetFollow.transform.position, enemySpeed * Time.deltaTime);

        if (Vector3.Distance(transform.position, respawnPosition.position) == 0)
        {
            enemyAnim.SetBool("isMoving", false);
        }
    }

    public void FollowPlayer()
    {
        enemyAnim.SetBool("isMoving", true);
        enemyAnim.SetFloat("moveX", (targetFollow.position.x - transform.position.x));
        enemyAnim.SetFloat("moveY", (targetFollow.position.y - transform.position.y));
        transform.position = Vector3.MoveTowards(transform.position, targetFollow.transform.position, enemySpeed * Time.deltaTime);
    }
    
    
}
