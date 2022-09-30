using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformTranslate : MonoBehaviour
{
    [SerializeField] private Vector3 direction;
    [SerializeField] private bool manualT, autoSelf, autoWorld;
    [SerializeField] private float speed;
    private void FixedUpdate()
    {
        //public void Translate(Vector3 translation, Space relativeTo = Space.Self);

        if (manualT) ManualTransformTranslate();

        if (autoSelf) AutoMoveSpaceSelf();

        if (autoWorld) AutoMoveSpaceWorld();
    }

    private void ManualTransformTranslate()
    {
        transform.Translate((direction * speed) * Time.deltaTime, Space.Self);
    }


    //Eixo Z indica a direção que o objeto irá seguir
    //Ao rotacionar o obj(y-90), é possível notar a diferença na movimentação
    //Self seguirá na direção relativa ao eixo do obj
    //World seguirá na direção relativa ao eixo do world
    private void AutoMoveSpaceSelf()
    {
        transform.Translate(Vector3.forward * Time.deltaTime, Space.Self);
    }
    
    private void AutoMoveSpaceWorld()
    {
        transform.Translate(Vector3.forward * Time.deltaTime, Space.World);
    }

}
