using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class SystemData : MonoBehaviour
{
    [SerializeField] private Weapon[] _possibleWeapons;
    [SerializeField] private BulletMovement[] _possibleBulletMovementTypes;
    [SerializeField] private Creature[] _possibleEnemies;
    [SerializeField] private float _sfxVolume = 0.5f;
    [SerializeField] private float _musicVolume = 0.5f;

    private AudioSource _musicSource;
    public Weapon[] PossibleWeapons => _possibleWeapons;
    public BulletMovement[] PossibleBulletMovementTypes => _possibleBulletMovementTypes;
    public Creature[] PossibleEnemies => _possibleEnemies;
    public float SfxVolume => _sfxVolume;
    public float MusicVolume
    {   get 
        {
            return _musicVolume;
        }
        set
        {
            _musicVolume = value;
            _musicSource.volume = _musicVolume;
        }
    }

    public delegate void OnChange(float newValue);
    public event OnChange OnSfxVolumeChage;

    private void Awake()
    {
        _musicSource = GetComponent<AudioSource>();
        var otherData = FindObjectOfType<SystemData>();
        if (otherData != this) Destroy(gameObject);
        DontDestroyOnLoad(this.gameObject);
    }
    public void ApplyChangeSfxVolume(float value)
    {
        _sfxVolume = value;
        OnSfxVolumeChage?.Invoke(value);
    }
    public void ApplyChangeMusicVolume(float value)
    {
        MusicVolume = value;
    }
}
