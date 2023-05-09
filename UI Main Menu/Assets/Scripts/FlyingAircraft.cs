using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class FlyingAircraft : MonoBehaviour
{
    [SerializeField] private Vector3[] _waypoints;
    private Tween tween;

    private void Start()
    {
        tween = transform.DOPath(_waypoints, 5, PathType.CatmullRom).SetOptions(true).SetLookAt(0.01f);
        tween.SetEase(Ease.Linear).SetLoops(-1);        
    }

    public void StopMovement()
    {
        tween.Pause();
    }

    public void ResumeMovement()
    {
        tween.Play();
    }
}
