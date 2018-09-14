using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TransitionAudioScript : MonoBehaviour
{
    public AudioClip endGameClip;

    public AudioClip titleMusic;
    public AudioClip transitionMusic;
    public AudioClip loseLevelMusic;
    public AudioClip endGameMusic;
    public AudioClip optionsMusic;

    public AudioClip randomMidClip;

    public AudioClip tommy1;
    public AudioClip tommy2;
    public AudioClip tommy3;
    public AudioClip tommy4;


    public AudioClip vic1;
    public AudioClip vic2;
    public AudioClip vic3;

    public AudioClip[] midArray;

    public AudioSource ClipSource;
    public AudioSource MusicSource;

    private int index;
    string sceneName;

    // Use this for initialization
    void Start()
    {     
        playMusic();
        StartCoroutine("playClip");
    }

    // Update is called once per frame
    void Update()
    {
        MusicSource.loop = true;
    }

    IEnumerator playClip()
    {
        int index = SceneManager.GetActiveScene().buildIndex;
        yield return new WaitForSeconds(1f);
        if (index == 5)
            playClipFromVicArray();
        if (index == 6)
            playClipFromTommyArray();
        if (index == 7)
        {
            ClipSource.clip = endGameClip;
            ClipSource.Play();
        }
            


    }


    void playMusic()
    {
        int index = SceneManager.GetActiveScene().buildIndex;
        if (index == 0)
        {
            MusicSource.clip = titleMusic;
            MusicSource.Play();
        }

        if (index == 5)
        {
            MusicSource.clip = transitionMusic;
            MusicSource.Play();
        }
        
        if (index == 6)
        {
            MusicSource.clip = loseLevelMusic;
            MusicSource.Play();
        }

        if (index == 7)
        {
            MusicSource.clip = endGameMusic;
            MusicSource.Play();
        }

        if (index == 8)
        {
            MusicSource.clip = optionsMusic;
            MusicSource.Play();
        }


    }





    void playClipFromTommyArray()
    {
        AudioClip[] midArray = new AudioClip[] { tommy1, tommy2, tommy3, tommy4 };
        index = Random.Range(0, midArray.Length);
        randomMidClip = midArray[index];
        ClipSource.clip = randomMidClip;
        ClipSource.Play();
    }

    void playClipFromVicArray()
    {
        AudioClip[] midArray = new AudioClip[] { vic1, vic2, vic3 };
        index = Random.Range(0, midArray.Length);
        randomMidClip = midArray[index];
        ClipSource.clip = randomMidClip;
        ClipSource.Play();
    }

}

