using UnityEngine;
/*
 Importante

OBJs 3D:
- Raycast2D em objetos originalmente 3D: Detecta colisão em objetos 3D e 2D
- Raycast3D em objetos originalmente 3D: Detecta colisão apenas em objetos 3D


OBJs 2D:
- Raycast2D em objetos originalmente 2D: Detecta colisão apenas em objetos 2D
- Raycast3D em objetos originalmente 2D: Detecta colisão apenas em objetos 3D


-> Conclusão, sprites funciona de acordo com o raycast aplicado. Objetos 3D podem ter uma vantagem na utilização de Raycast2D ja que funciona pra qqr tipo de colisão.
 */

public class Ray2D : MonoBehaviour
{
    public Transform origin;
    public LayerMask mask;

    void Update()
    {
        RayModelFour();
    }

    public void RayModelOne()
    {
        //Obs: Não muda a direção do raycast conforme o objeto gira.
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.right, 3);

        Debug.DrawRay(transform.position, Vector2.right * 3, Color.green);

        if (hit.collider != null)
        {
            Debug.Log($"{hit.collider.tag}");
        }
    }
    public void RayModelTwo()
    {
        //Obs: Não muda a direção do raycast conforme o objeto gira.
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.right, 3, mask);

        Debug.DrawRay(transform.position, Vector2.right * 3, Color.green);

        if (hit)
        {
            Debug.Log($"Inimigo encontrado: {hit.collider.name}");
        }
    }
    public void RayModelThree()
    {
        //A direção muda conforme a direção 2D do objeto (esquerda 180 e direita 0)
        Vector2 dir = transform.rotation.y > 0 ? Vector2.left : Vector2.right;
        RaycastHit2D hit = Physics2D.Raycast(origin.position, dir, 3, mask);

        Debug.DrawRay(origin.position, dir * 3, Color.green);

        if (hit)
        {
            Debug.Log($"Inimigo encontrado: {hit.collider.name}");
        }
    }
    public void RayModelFour()
    {
        //Direção do raycast é de acordo com a rotação do obj
        RaycastHit2D hit = Physics2D.Raycast(origin.position, transform.TransformDirection(Vector2.right), 3, mask);

        Debug.DrawRay(origin.position, transform.TransformDirection(Vector2.right) * 3, Color.green);

        if (hit)
        {
            Debug.Log($"Inimigo encontrado: {hit.collider.name}");
        }
    }

}
