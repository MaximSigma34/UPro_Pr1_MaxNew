using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntryPointLes10 : MonoBehaviour
{
    [SerializeField] private BulletLes10 bullet;

    // Start is called before the first frame update
    void Start()
    {
        ObjectsPool.Instance.AddObjects<BulletLes10>(bullet, 10);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
