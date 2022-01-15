using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 [RequireComponent(typeof(SpriteRenderer))]
public class EnemyAI : MonoBehaviour
{
    public Transform target; //the enemy's target
    private SpriteRenderer enemySR;
    private float dist;
    public float moveSpeed;
    public float howClose;
    private BatSoundController batSound;
    private WolfSoundController wolfSound;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
        batSound = GetComponent<BatSoundController>();
        wolfSound = GetComponent<WolfSoundController>();
    }

    public void Awake()
    {
        this.enemySR = this.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        dist = Vector3.Distance(target.position, transform.position);

        if (dist <= howClose)
        {
            GetComponent<Rigidbody>().AddForce(transform.forward * moveSpeed);
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(target.transform.position.x,transform.position.y,target.transform.position.z),moveSpeed * Time.deltaTime);
        }

        if (dist <= 1.5f)
        {
            //do damage
        }

        this.enemySR.flipX = target.transform.position.x < this.transform.position.x;
    }
}
