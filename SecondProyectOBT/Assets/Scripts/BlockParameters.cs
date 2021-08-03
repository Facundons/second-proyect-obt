using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockParameters : MonoBehaviour
{
    private int Number;
    private int Row;
    private int Column;

    public BlockParameters (int Number, int row, int Column)
    {
        this.Number = Number;
        this.Row = row;
        this.Column = Column;
    }

    public int getNumber()
    {
        return this.Number;
    }

    public int getRow()
    {
        return this.Row;
    }
    public int getColumn()
    {
        return this.Column;
    }
}
