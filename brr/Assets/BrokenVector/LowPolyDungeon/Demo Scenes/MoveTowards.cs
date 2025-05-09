using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTowards : MonoBehavior
{
    [SerializeField] Transform Player;
    [SerializeField] int speed = 1;
    Vector3 playerPosition;

    void Update()
    {


      playerPosition = Player.transform.position;
      transform.position = Vector3.MoveTowards(transform.Position, playerPosition, speed * Time.deltaTime);



    }


    void Start()
    {
        playerPosition = Player.transform.position;
    }




}
