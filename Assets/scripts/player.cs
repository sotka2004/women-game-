using UnityEngine;

public class player : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 10f;
    [SerializeField] private float rotetionSpeed = 10f;


    private void Start()
    {

        
    }

    
    private void Update()
    {
        Vector2 InputVector = new Vector2(0, 0);
        if (Input.GetKey(KeyCode.W))
        {
            InputVector.y = +1;

        }
        if (Input.GetKey(KeyCode.S))
        {
            InputVector.y = -1;

        }
        if (Input.GetKey(KeyCode.A))
        {
            InputVector.x = -1;

        }
        if (Input.GetKey(KeyCode.D))
        {
            InputVector.x = +1;

        }
        InputVector = InputVector.normalized;

        Vector3 moveDir = new Vector3(InputVector.x, 0f, InputVector.y);
        transform.forward = Vector3.Slerp(transform.forward,moveDir, rotetionSpeed*Time.deltaTime);

        transform.position += moveDir* Time.deltaTime* moveSpeed;

        Debug.Log(InputVector);

    }
}
