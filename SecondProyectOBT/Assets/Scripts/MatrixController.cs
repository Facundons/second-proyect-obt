using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatrixController : MonoBehaviour
{
    private int[,] matrix = new int[3, 3];
    private void Awake()
    {
        UiController.onStartGame += onStartGame;
        GenerateMatrix();
        CheckForCoincidencesOnMatrix();
    }

    private void onStartGame(object sender, System.EventArgs e)
    {
        GenerateMatrix();
    }

    private void GenerateMatrix()
    {
        for (int row = 0 ; row <= 2; row++)
        {
            for (int column = 0; column <= 2; column++)
            {
                matrix[row, column] = Random.Range(0, 8);
            }
        }
    }

    private void CheckForCoincidencesOnMatrix()
    {
        int row = 0;
        int column = 0;

        //Column 1
        if(matrix[row, column] == matrix [row+1,column])
        {
            if(matrix[row, column] == matrix[row+2, column])
            {
                Debug.Log("There is a coincidence in first column!");
            }
        }

        column = 1;
        //Column 2
        if (matrix[row, column] == matrix[row + 1, column])
        {
            if (matrix[row, column] == matrix[row + 2, column])
            {
                Debug.Log("There is a coincidence in second column!");
            }
        }

        column = 2;
        // Column 3
        if (matrix[row, column] == matrix[row + 1, column])
        {
            if (matrix[row, column] == matrix[row + 2, column])
            {
                Debug.Log("There is a coincidence in third column!");
            }
        }

        column = 0;
        row = 0;

        //row 1
        if (matrix[row, column] == matrix[row , column + 1])
        {
            if (matrix[row, column] == matrix[row, column + 2])
            {
                Debug.Log("There is a coincidence in first row!");
            }
        }

        row = 1;
        //row 2
        if (matrix[row, column] == matrix[row, column + 1])
        {
            if (matrix[row, column] == matrix[row, column + 2])
            {
                Debug.Log("There is a coincidence in second row!");
            }
        }

        row = 2;
        //row 3
        if (matrix[row, column] == matrix[row, column + 1])
        {
            if (matrix[row, column] == matrix[row, column + 2])
            {
                Debug.Log("There is a coincidence in third row!");
            }
        }
    }

}
