using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public float damage;
    public float damageRate;
    public float pushBackForce;
    private float nextDamage;
    // Start is called before the first frame update
    void Start()
    {
        nextDamage = Time.time;
    }

    private void OnTriggerStay2D(Collider2D otherStay)
    {
        if(otherStay.tag == "Player" && nextDamage < Time.time)
        {
            //Do Something
            PlayerHealth thePlayerHealth = otherStay.gameObject.GetComponent<PlayerHealth>();
            thePlayerHealth.AddDamage(damage);
            nextDamage = Time.time + damageRate;
            PushBack(otherStay.transform);
        }
    }

    void PushBack(Transform pushedObject)
    {
        Vector2 pushDirection = new Vector2(0f, (pushedObject.position.y - transform.position.y)).normalized;
        pushDirection *= pushBackForce;
        Rigidbody2D pushRB = pushedObject.gameObject.GetComponent<Rigidbody2D>();
        pushRB.velocity = Vector2.zero;
        pushRB.AddForce(pushDirection, ForceMode2D.Impulse);
    }

}
