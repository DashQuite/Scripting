using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Missile : MonoBehaviour
{
    //—корость полЄта огненного шара
    public float speed;

    void Update()
    {
        // аждый кадр позици€ шара обновл€етс€ на произведение вектора движени€ вперЄд (0,0,1),
        //скорости движени€ шара и значение разницы в секундах между последним и текущим кадрами
        transform.position += transform.forward * speed * Time.deltaTime;
    }

    void OnTriggerEnter(Collider other)
    {

        //¬раг уничтожаетс€
        Enemy enemy = other.GetComponent<Enemy>();
        Destroy(enemy.gameObject);

        //—нар€д уничтожаетс€
        Destroy(gameObject);
    }

}
