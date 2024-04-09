using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scanner : MonoBehaviour
{
    public float ScanRange = 6f;

    RaycastHit2D[] targets;
    public  Transform nearesttarget;

    public LayerMask targetLayer; 
    // Start is called before the first frame update
    void FixedUpdate()
    {
        targets = Physics2D.CircleCastAll(transform.position,ScanRange,Vector2.zero,0, targetLayer); //Ô²ÐÄ °ë¾¶ ·½Ïò
        nearesttarget = GetNearest();


    }
    private Transform GetNearest()
    {

        float Distance = 100f;
        Transform result = null;
        foreach (RaycastHit2D t in targets)
        {
            Vector3 myPos = transform.position;
            Vector3 targetPos = t.transform.position;

            float curDisdance = Vector3.Distance(myPos, targetPos);
            if (curDisdance < Distance)
            {
                Distance = curDisdance;
                result = t.transform;
            }
        }
        return result;

    }
}
