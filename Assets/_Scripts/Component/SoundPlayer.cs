using System;
using UnityEngine;

public class SoundPlayer : MonoBehaviour
{
    [SerializeField] private AudioSource _source;
    [SerializeField] private AudioData[] _sounds;
    public float sdfsada;
    private SystemData _systemData;
    private void Awake()
    {
        _systemData = FindObjectOfType<SystemData>();
        _source.volume = _systemData.SfxVolume;
    }
    private void ChangeVolume(float value)
    {
        _source.volume = value;
        Debug.Log(_source.volume);
    }
    public void Play(string id)
    {
        foreach (var audioData in _sounds)
        {
            if (audioData.Id != id) continue;
            AudioSource.PlayClipAtPoint(audioData.Clip, transform.position);
            break;
        }
    }
    [Serializable]
    public class AudioData
    {
        [SerializeField] private string _id;
        [SerializeField] private AudioClip _clip;

        public string Id => _id;
        public AudioClip Clip => _clip;
    }
}