using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Enemy : TargetScript
{
    public Animator animator;
    public float health = 100;
    public NavMeshAgent navMeshAgent;

    bool isDead;

    float coolDown = 0.5f;
    Transform target;

    public GameObject deadEffect;

//add    
private GameObject[] enemyObjects;
	// private float time = 60;
	public CountDown countdown;


    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {


    float bCount;
    bCount = countdown.time;
    Debug.Log(bCount); //5 

        if (navMeshAgent.remainingDistance < 1 && !isDead)
        {
            animator.SetTrigger("Attack");
        }

        if (isHit && coolDown <= 0 && !isDead)
        {
            // Debug.Log("Hit");
            
            health -= 10;
            coolDown = 0.5f;

            if (health <= 0)
            {
               animator.SetTrigger("Dead"); 
               navMeshAgent.isStopped = true;
               isDead = true;
               StartCoroutine(Dead());
            }
            else
            {
               animator.SetTrigger("Hurt");
               navMeshAgent.isStopped = true;
            }
            isHit = false;

        }
        else if (coolDown <= 0)
        {
            if (!isDead)
            {
                navMeshAgent.isStopped = false;
                navMeshAgent.SetDestination(target.position);
            }
        }
        if (coolDown > 0)
        {
            coolDown -= Time.deltaTime;
        }

// Enemyというタグが付いているオブジェクトのデータを箱の中に入れる。
enemyObjects = GameObject.FindGameObjectsWithTag("Target");

// データの入った箱の数をコンソール画面に表示する。
print(enemyObjects.Length);

if(enemyObjects.Length == 1 || bCount == 0){

// ゲームクリアーシーンに遷移する。
SceneManager.LoadScene("Clear");
    }

if(bCount == 0){
SceneManager.LoadScene("GameOver");

    }

    }
    
    
    
    IEnumerator Dead()
    {
        yield return new WaitForSeconds(1.5f);
        GameObject _effect = Instantiate(deadEffect, transform.position, Quaternion.identity);
        Destroy(_effect, 3f);
        Destroy(gameObject);
    }
}
