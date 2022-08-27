using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private GameObject[] _healths;
    private int _healthCount;

    private void Start()
    {
        _healthCount = _healths.Length;
    }

    public void LossHealth()
    {
        _healths[_healthCount].SetActive(false);
        _healthCount -= 1;
        if(_healthCount <= 0)
            Application.LoadLevel(1);
    }
}
