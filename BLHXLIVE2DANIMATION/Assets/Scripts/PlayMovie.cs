using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class PlayMovie : MonoBehaviour
{
    // public MovieTexture video;
    // public VideoPlayer video;
    // private AudioSource audios;

    void Start()
    {
        // 获取PLane对象的MeshRenderer组件.
        // MeshRenderer meshrenderer = GetComponent<MeshRenderer>();
        // 将MeshRenderer组件的纹理材质替换为MovieTexture类型的视频.
        // meshrenderer.material.mainTexture = video;
        // audios = GetComponent<AudioSource>();
        // 将MovieTexture的音频剪辑赋值给Audio Source组件的clip
        // audios.clip = video.AudioClip;
        // audios.spatialBlend = 0;

        
    }

    void Update()
    {
        // 按下空格键进行播放控制.
        // if (Input.GetKeyDown (KeyCode.Space) && !video.isPlaying && !audios.isPlaying) {
        //     video.Play ();
        //     audios.Play ();
        // } else if (Input.GetKeyDown(KeyCode.Space) && video.isPlaying && audios.isPlaying){
        //     video.Pause ();
        //     audios.Pause();
        // }

    }
}
