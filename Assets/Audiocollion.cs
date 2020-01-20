using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audiocollion : MonoBehaviour
{
    
    public float Volume;
    public float Reward;
    public float DecreaseSpeed;
    public AudioSource AudioTrack;
    public Color Disable;
    public Color Enable;
    public GameObject[] m_bars;
    public SpriteRenderer bar1;
    public SpriteRenderer bar2;
    public SpriteRenderer bar3;
    void Update()
    {
        if (_active+_timealive< Time.time&& AudioTrack.volume>Volume)
        {
            AudioTrack.volume -= 0.1f * Time.deltaTime;
        }
        if (AudioTrack.volume >= 0.3f)
        {
            bar1.color = Enable;
        }
        else
        {
            bar1.color = Disable;
        }

        if (AudioTrack.volume >= 0.6f)
        {
            bar2.color = Enable;
        }
        else
        {
            bar2.color = Disable;
        }
        if (AudioTrack.volume >= 0.9f)
        {
            bar3.color = Enable;
        }
        else
        {
            bar3.color = Disable;
        }
    }

     void OnTriggerEnter2D(Collider2D col)
    {
     if(AudioTrack.volume <1.0f)
        {
            AudioTrack.volume += 0.1f;
            _active = Time.time;
            
        }
    }
    private float _timealive = 2f;
    private float _active = 0f;
}
