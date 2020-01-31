using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioTestManager : MonoBehaviour
{

    /// <summary>
    /// オーディオ再生管理
    /// </summary>
    public AudioSource playAudioSource;

    /// <summary>
    /// メインBGMクリップ
    /// </summary>
    public AudioClip mainBgmClip;

    /// <summary>
    /// 
    /// </summary>
    void Start()
    {
        playAudioSource = GetComponent<AudioSource>();
        
    }


    /// <summary>
    /// 
    /// </summary>
    void Update()
    {
        
    }

    /// <summary>
    /// MainBgm再生テスト
    /// </summary>
    public void MainBgmTest() {
        if (!playAudioSource.isPlaying) {
            playAudioSource.PlayOneShot(mainBgmClip);
        }
    }


}
