using UnityEngine;

public class Follow_Player : MonoBehaviour
{
    public Transform Player;
    public Vector3 offset;
    void Update()
    {
        //Debug.Log(Player.position);//For checking if player is working properly
        //transform.position = Player.position;//First person view
        //transform.position = Player.position + offset;
        if (Player != null)
        {
            transform.position = Player.position + offset;
        }
    }
}
