using UnityEngine;

[RequireComponent(typeof(Animator))]
public class OptionsWindow : MonoBehaviour
{
    private Animator _animator;
    private SystemData _systemData;

    private readonly int openKey = Animator.StringToHash("open");
    private readonly int closeKey = Animator.StringToHash("close");

    private void Awake()
    {
        _systemData = FindObjectOfType<SystemData>();
        _animator = GetComponent<Animator>();
        Cursor.visible = true;
    }
    private void OnBecameVisible()
    {
        _systemData = FindObjectOfType<SystemData>();
    }
    public void ChangeSfxVolume(float value)
    {
        _systemData.ApplyChangeSfxVolume(value);
    }
    public void ChangeMusicVolume(float value)
    {
        _systemData.MusicVolume =value;
    }
    public void Open()
    {
        _animator.SetTrigger(openKey);
    }
    public void Close()
    {
        _animator.SetTrigger(closeKey);
    }
}
