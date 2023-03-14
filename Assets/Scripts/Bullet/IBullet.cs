using UnityEngine;

interface IBullet
{

 
    void SetSpeed(float speed);
    float GetSpeed();
    void Moving();
    void rotation();
    void Limit();
    void collide(Collision collision, string tag);



    












}
