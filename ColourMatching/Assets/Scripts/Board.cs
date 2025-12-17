using UnityEngine;

public class Board : MonoBehaviour
{
    public int width;
    public int height;
    public GameObject tilePrefab;
    private TIleBackground[,] tiles;

    void Start()
    {
        tiles = new TIleBackground[width, height];

        Setup();
    }

    void Setup()
    {
        for(int i = 0;i<width;i++)
        {
            for(int j = 0;j<height;j++)
            {
                Vector2 tempPosition = new Vector2(i,j);
                Instantiate(tilePrefab, tempPosition, Quaternion.identity);
            }
        }
    }
}
