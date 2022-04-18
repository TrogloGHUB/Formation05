using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musique : MonoBehaviour
{
    public AudioClip musiqueJeu;
    private AudioSource musiqueAudio;
    private GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        musiqueAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
