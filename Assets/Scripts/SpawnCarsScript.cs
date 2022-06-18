using UnityEngine;

public class SpawnCarsScript : MonoBehaviour
{
    private float _timer = 0f;
    bool _playerReady;

    void FixedUpdate()
    {
        _playerReady = CheckpointSorter._onTrigger;
        if (_timer <= 0f) { CreateCar(); _timer = RandomTime(); }
        else { _timer -= Time.fixedDeltaTime; }
    }


    private void CreateCar()
    {
        GameObject currentCar = Instantiate(_allCars[RandomCar()], transform.position, Quaternion.identity);
        if (RandomPark() && _playerReady) { currentCar.GetComponent<CarsMove>().onPark = true; }
    }


    [SerializeField] private int _minDelay = 1;
    [SerializeField] private int _maxDelay = 3;
    private float RandomTime()
    {
        return Random.Range(_minDelay, _maxDelay);
    }


    [SerializeField] private GameObject[] _allCars;
    private int RandomCar()
    {
        return Random.Range(0, _allCars.Length - 1);
    }


    [SerializeField] private int _probability = 20;
    private bool RandomPark()
    {
        return Random.Range(0, 100) <= _probability ? true : false;
    }
}