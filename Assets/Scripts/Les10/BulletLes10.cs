using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletLes10 : MonoBehaviour
{
    // Start is called before the first frame update
    void OnEnable()
    {
        Invoke("DestroyBullet", 2f);
    }

   private void DestroyBullet()
    {
        ObjectsPool.Instance.ReturnObject<BulletLes10>(this);
    }
}
