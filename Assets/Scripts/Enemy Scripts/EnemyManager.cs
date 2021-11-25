using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public static EnemyManager instance;

    [SerializeField]

    void Awake()
    {

    }

    void MakeInstance()
    {
        if (instance == null)
        {

        }
    }
}
