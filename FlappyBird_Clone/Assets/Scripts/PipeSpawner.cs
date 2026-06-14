using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    [SerializeField] private float _maxTime = 1.5f;
    [SerializeField] private float _hieghtRange = 0.45f;
    [SerializeField] private GameObject _pipePrefab;

    private float _timer;

    // Start is called before the first frame update
    private void Start()
    {
        SpawnPipe();
        
    }

    // Update is called once per frame
    private void Update()
    {
        if (_timer > _maxTime) 
        {
            SpawnPipe();
            _timer = 0;

        }

        _timer += Time.deltaTime;
    }

    private void SpawnPipe()
    {
        Vector3 spawnPosition = transform.position + new Vector3(0, Random.Range(-_hieghtRange, _hieghtRange));
        GameObject pipePrefab  = Instantiate(_pipePrefab, spawnPosition, Quaternion.identity);

        Destroy(pipePrefab, 10f);

    }
}
