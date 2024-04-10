
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject enemy;
    public Transform[] SpawnPoints;
    float timer = 0;

    float timerB = 0f;
    float spawnTime = 1f;
    //float spawnTimeB = 5f;
    // Start is called before the first frame update
    void Awake()
    {
        SpawnPoints = GetComponentsInChildren<Transform>(); //��ȡ��ǰ�ڵ��µ�����ˢ�ֵ�

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer>spawnTime)
        {
            timer = 0;
            Spawn();
        }
        //timerB += Time.deltaTime;
        //if (timerB > spawnTimeB)
        //{
        //    timerB = 0;
        //    SpawnAll();
        //}

    }


    public void Spawn()
    {
        GameObject go = Instantiate(enemy); //ʵ�����������
        go.transform.position = SpawnPoints[Random.Range(1, SpawnPoints.Length)].position;//��������ŵ�ˢ�ֵ�
    }
    //public void SpawnAll()
    //{
    //    GameObject go = Instantiate(enemy); //ʵ�����������
    //    for(int i=1;i<SpawnPoints.Length;i++)
    //    {
           
    //        GameObject goAll = Instantiate(enemy); //ʵ�����������
    //        goAll.transform.position = SpawnPoints[i].position;

    //    }
    //}
}
