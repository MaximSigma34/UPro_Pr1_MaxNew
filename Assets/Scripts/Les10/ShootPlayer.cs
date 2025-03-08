using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootPlayer : MonoBehaviour
{
    [SerializeField] private BulletLes10 bullet;
    private bool isShoot = true;

    private void ActiveShoot()
    {
        isShoot = true;
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetMouseButtonDown(0) && isShoot)
        {
            isShoot = false;
            Invoke("ActiveShoot", 0.25f);
            GameObject obj = ObjectsPool.Instance.GetObject<BulletLes10>(bullet);
            obj.transform.position = transform.position;
            obj.transform.localRotation = transform.localRotation;
            obj.GetComponent<Rigidbody>().AddForce(obj.transform.forward * 100);
        }
    }
}
