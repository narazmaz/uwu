using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class pick_up : MonoBehaviour
{
    float score = 0;
    [SerializeField] float speed = 2;
    [SerializeField]AudioSource audioSource;
    [SerializeField]AudioClip clip;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Coin")
        {
            audioSource.PlayOneShot(clip);
            StartCoroutine(MoveToPlayer(other.transform, transform, speed));
            score++;
            Debug.Log("Twoj wynik to" + score);
        
            }     
    }
    IEnumerator MoveToPlayer(Transform coin, Transform Player, float speed)
    {
        float duration = 3.0f;
        float time = 0;


        while(time < duration)
        {
            coin.position = Vector3.MoveTowards(coin.position, Player.position, speed*Time.deltaTime);
            time += Time.deltaTime; //nasz licznik czasu
            yield return null; //odstêp czasowy - stop 1 klatka
        }
       

        Destroy(coin.gameObject);
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Coin")
        {
            Destroy(collision.gameObject);
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}
