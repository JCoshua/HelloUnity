using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalBehavior : MonoBehaviour
{
    [SerializeField]
    public Material FailMaterial;
    private int _enemyCount = 0;

    public int EnemyCount
    {
        get { return _enemyCount; }
        set { _enemyCount = value; }
    }

    private void Update()
    {
        if(_enemyCount >= 7)
        {
            MeshRenderer renderer = GetComponent<MeshRenderer>();
            if (renderer)
                renderer.material = FailMaterial;
        }
    }
}
