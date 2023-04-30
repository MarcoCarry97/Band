using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pair
{
    public int X { get; set; }
    public int Y { get; set; }

    public override string ToString()
    {
        return JsonConvert.SerializeObject(this);
    }
}
