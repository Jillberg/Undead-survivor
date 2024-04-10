using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateBullet : MonoBehaviour
{
    public float RotateSpeed;//Rotating speed(wire)
    public float Radius;//��ת�뾶

    public Vector2 Center;//��תΧ������
    public float _angle;//��ת�Ƕ�

    public float damage;//�����˺�

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //����ת���������Χ�Ƶ�����Ϊ��ҵ�ǰ����
        Center = (Vector2)GameManger.instance.player.transform.position;
        //�Ƕȵı仯������ת�ٶȳ˼��ʱ��
        _angle += RotateSpeed * Time.deltaTime;
        var offset = new Vector2(Mathf.Sin(_angle), Mathf.Cos(_angle))*Radius;
        transform.position = Center + offset;
    }
}
