using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CGold : MonoBehaviour
{

    Rigidbody2D rigidbody;

    public float speed;

    private float cost;

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        // 골드 획득량 임시
        cost = CDataManager.instance.GetCurrentStage() * 10f;

        Vector2 direction;
        direction.x = Random.Range(-0.45f, 0.45f);
        direction.y = Random.Range(0.45f, 1.0f);

        rigidbody.AddForce(direction * speed, ForceMode2D.Impulse);

        StartCoroutine(Destroy());
    }

    IEnumerator Destroy()
    {
        yield return new WaitForSeconds(2.0f);
        CDataManager.instance.AddMyGold(cost);
        Destroy(this.gameObject);
    }

    private void OnTriggerEnter2D()
    {
    }

}
