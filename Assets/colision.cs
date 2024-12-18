using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colision : MonoBehaviour
{
    [SerializeField] GameObject redRotateSquare;
    [SerializeField] GameObject blueRotateSquare;
    [SerializeField] GameObject redSquare;
    [SerializeField] GameObject blueSquare;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == redSquare && gameObject == redRotateSquare)
        {
            redRotateSquare.GetComponent<SpriteRenderer>().color = Color.magenta;
        }

        if (collision.gameObject == blueSquare && gameObject == blueRotateSquare)
        {
            blueRotateSquare.GetComponent<SpriteRenderer>().color = Color.magenta;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject == redSquare && gameObject == redRotateSquare)
        {
            redRotateSquare.GetComponent<SpriteRenderer>().color = Color.red;
        }

        if (collision.gameObject == blueSquare && gameObject == blueRotateSquare)
        {
            blueRotateSquare.GetComponent<SpriteRenderer>().color = Color.blue;
        }
    }
    private void CheckAndTeleport()
    {
        if (redRotateSquare.GetComponent<SpriteRenderer>().color == Color.magenta &&
            blueRotateSquare.GetComponent<SpriteRenderer>().color == Color.magenta)
        {
            float randomXRedR = Random.Range(-10f, 10f);
            float randomYRedR = Random.Range(-10f, 10f);
            redRotateSquare.transform.position = new Vector2(randomXRedR, randomYRedR);

            float randomXBlueR = Random.Range(-10f, 10f);
            float randomYBlueR = Random.Range(-10f, 10f);
            blueRotateSquare.transform.position = new Vector2(randomXBlueR, randomYBlueR);
        }
    }
}
  