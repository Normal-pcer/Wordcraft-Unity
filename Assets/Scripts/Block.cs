using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block
{
    public string blockId;
    public string character;
    public (int, int, int) color;

    public Block(string block_id, string character, (int, int, int) color)
    {
        this.blockId = block_id;
        this.character = character;
        this.color = color;
    }
}
