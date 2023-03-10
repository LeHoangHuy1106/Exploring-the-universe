using UnityEngine;

interface IBullet
{
    
    void SetSpeed(float speed);
    float GetSpeed();
    void setPosition(Vector3 pos);
    void Moving();
    void rotation();

    void Limit();

    void collide(Collision collision, string tag);

    ObjectPool GetObjectPool();
    












}
