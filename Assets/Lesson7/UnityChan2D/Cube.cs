using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        this.audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        audioSource.Play();

        //ユニティちゃんが接触したら音はならない
        if (collision.gameObject.tag == "UnityChan2D")
        {
            audioSource.Stop();
        }
    }
}