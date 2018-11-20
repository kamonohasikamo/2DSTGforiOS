using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour {

    public GameObject explosionPrefab;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(0, 0.2f, 0);

        if (transform.position.y > 5)
        {
            Destroy(gameObject);
        }
	}

    void OnTriggerEnter2D(Collider2D coll)
    {
        // 衝突したときにスコアを更新する
        GameObject.Find("Canvas").GetComponent<UIController>().AddScore();

        // 爆発エフェクトを生成する	
        GameObject effect = Instantiate(explosionPrefab, transform.position, Quaternion.identity) as GameObject;
        Destroy(effect, 1.0f);

        Destroy(coll.gameObject);
        Destroy(gameObject);
    }
}
