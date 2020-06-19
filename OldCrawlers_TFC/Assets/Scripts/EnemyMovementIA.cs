using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/***
 * This class models the enemy AI, allowing the enemies to follow the target (in this case the player) anywhere he goes.
 */

public class EnemyMovementIA : MonoBehaviour
{
    /**
     * maxEenemyDistance -> maximum distance between the player and the enemy.
     */
    [SerializeField] private float maxEnemyDistance;

    /**
     * minimum distance between the player and the enemy.
     */
    [SerializeField] private float minEnemyDistance;
    
    /**
     * enemySpeed -> the speed of the enemy movement.
     */
    [SerializeField] private float enemySpeed;
    
    /**
     * enemyAnim -> Animator of the enemy model and animations.
     */
    private Animator enemyAnim;
    
    /**
     * targetFollow -> the target that the enemy will seek (in this case, the player).
     */
    private Transform targetFollow;
    
    /**
     * respawnPosition -> the position that the enemy return when it lost the target.
     */
    public Transform respawnPosition;
    
    
    /***
     * This funcion is called before the first frame updtates. Here we get the Animator of the enemy that is created in
     * the Unity's editor and we said to the editor who is the target. In this case, it is the character's sprite.
     */
    void Start()
    {
        enemyAnim = GetComponent<Animator>();
        targetFollow = FindObjectOfType<PlayerMovement>().transform;
    }
    
    /***
     * This function is called one time per frame. Here we check the distance that the character's sprite is. If the
     * distance is in the limits that we established in the Unity's editor, the enemy will follow the target. If not,
     * the enemy will return to his respawn position.
     */
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
    
    /***
     * This function is used to return the enemy to his respawn point. We transform the position of the current coords,
     * the player's sprite distance and the enemy speed in position, if that conditions are true, we set the boolean of
     * the Unity's animations editor parameter to false, and the enemy will return tho his respawn point.
     */

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

    /***
     * This function allows the enemy to follow the Character's sprite arount the tilemap. Here we set the players coords
     * of the tilemap in the Unity's animations editor, and then we track the sprite.
     */
    public void FollowPlayer()
    {
        enemyAnim.SetBool("isMoving", true);
        enemyAnim.SetFloat("moveX", (targetFollow.position.x - transform.position.x));
        enemyAnim.SetFloat("moveY", (targetFollow.position.y - transform.position.y));
        transform.position = Vector3.MoveTowards(transform.position, targetFollow.transform.position, enemySpeed * Time.deltaTime);
    }
    
    
}
