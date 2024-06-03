using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PullingJamp : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = new Vector3(0, 10, 0);

        }

        if (Input.GetMouseButtonDown(0))
        {
            clickPodition = Input.mousePosition;
        }

        if (Input.GetMouseButtonUp(0))
        {
            //�N���b�N�������W���������W�̍������擾
            Vector3 dist = clickPodition - Input.mousePosition;
            //�N���b�N�ƃ����[�X���������W�Ȃ疳��
            if (dist.sqrMagnitude == 0) { return; }
            //������W�������AjumpPoqwer���������킹���l���ړ��ʂƂ���
            rb.velocity = dist.normalized * jumpPoewr;
        }
    }
    private Rigidbody rb;
    private Vector3 clickPodition;
    [SerializeField]
    private float jumpPoewr = 10;
}
