using UnityEngine;

public class Player : MonoBehaviour
{
    public bool isLanding; //是否着陆（只有在着陆时才能起跳）

    private const float JumpSpeed = 15.0f; //设置起跳速度

    // Start is called before the first frame update
    private void Start()
    {
        isLanding = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isLanding)
        {
            // 点击鼠标左键触发
            if (Input.GetMouseButtonDown(0))
            {
                isLanding = false;
                GetComponent<Rigidbody>().velocity = Vector3.up * JumpSpeed; //设定向上速度
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Floor"))
        {
            isLanding = true;
        }
    }
}