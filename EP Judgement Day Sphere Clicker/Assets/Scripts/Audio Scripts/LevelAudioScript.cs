using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelAudioScript : MonoBehaviour {

    public AudioClip endGameClip;

    public AudioClip randomMidClip;

    public AudioClip level1Music;

    public AudioClip mid1, mid2, mid3, mid4, mid5, mid6, mid7, mid8, mid9, mid10, mid11, mid12, mid13, mid14, mid15, mid16, mid17;

    public AudioClip[] midArray;


    public AudioSource ClipSource;
    public AudioSource MusicSource;

    private int index;

	// Use this for initialization
	void Start () {
        MusicSource.clip = level1Music;
        MusicSource.Play();
        StartCoroutine("playClip");
    }

    // Update is called once per frame
    void Update()
    {
        if (MusicSource.time > 37f)
        {
            MusicSource.Stop();
        }
    }

    IEnumerator playClip()
    {
        yield return new WaitForSeconds(7f);
        playClipFromArray();
        yield return new WaitForSeconds(7f);
        playClipFromArray();
        yield return new WaitForSeconds(7f);
        playClipFromArray();
        yield return new WaitForSeconds(7f);
        playClipFromArray();
    }

    IEnumerator playMusic()
    {
        MusicSource.clip = level1Music;
        yield return new WaitForSeconds(3f);
        MusicSource.Play();
    }

    void playClipFromArray()
    {
        AudioClip[] midArray = new AudioClip[] { mid1, mid2, mid3, mid4, mid5, mid6, mid7, mid8, mid9, mid10, mid11, mid12, mid13,
                                                 mid14, mid15, mid16, mid17};
        index = Random.Range(0, midArray.Length);
        randomMidClip = midArray[index];
        ClipSource.clip = randomMidClip;
        ClipSource.Play();
    }



}
