using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropdownManager : MonoBehaviour
{
    public string fruitSize;
    public string spawnRate;
    public string gravity;
    public string timer;

    public void FruitSize()
    {
        switch (fruitSize)
        {
            case "Regular":
                break;

            case "Small":
                break;
        }
    }

    public void FruitSpawnRate()
    {
        switch (spawnRate)
        {
            case "Regular":
                FruitSpawner.minDelay = .1f;
                FruitSpawner.maxDelay = 1f;
                break;

            case "Slow":
                FruitSpawner.minDelay = .5f;
                FruitSpawner.maxDelay = 2f;
                break;

            case "Fast":
                FruitSpawner.minDelay = .1f;
                FruitSpawner.maxDelay = .5f;
                break;
        }
    }

    public void Gravity()
    {
        switch (gravity)
        {
            case "Regular":
                break;

            case "Low":
                break;
        }
    }

    public void Time()
    {
        switch (timer)
        {
            case "30 Seconds":
                Score.time = 30f;
                break;

            case "1 Minute":
                Score.time = 60f;
                break;
        }
    }

}
