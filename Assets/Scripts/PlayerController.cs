using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int points;
    
    [SerializeField] private float speed = 1f;

    private void MovePlayer()
    {
        float xMoveValue = speed * Input.GetAxis("Horizontal") * Time.deltaTime;
        float yMoveValue = 0;
        float zMoveValue = speed * Input.GetAxis("Vertical") * Time.deltaTime;

        //Assigns each previously created variable to their respective axis in the Unity Transform
        transform.Translate(xMoveValue, yMoveValue, zMoveValue);
    }

    private void Update()
    {
        MovePlayer();
    }
    
}
