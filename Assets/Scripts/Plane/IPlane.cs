using System.Collections;
using System.Collections.Generic;
using UnityEngine;

interface IPlane
{

    void SetPositon(Vector3 pos);
    void Moving();
    void SetSpeed(float speed);
    float GetSpeed();
    void Conllider();
    void Limit();
    ObjectPool GetObjectPool();
    void SetObjectPool(ObjectPool objectPool);






}
