using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DynamicArray
{
    //GameObject array resizing
    public static GameObject[] AddGameObjectToArray(GameObject[] PrevArray, GameObject NewObj)
    {
        GameObject[] Temp = PrevArray;
        GameObject[] NewArray = new GameObject[Temp.Length + 1];
        for (int i = 0; i < NewArray.Length; i++)
        {
            if (i < Temp.Length)
            {
                NewArray[i] = Temp[i];
            }
            else
            {
                NewArray[i] = NewObj;
            }
        }
        return NewArray;
    }
    public static GameObject[] AddGameObjectToArrayAtIndex(GameObject[] Prev, GameObject NewInput, int Index)
    {
        GameObject[] NewArray = new GameObject[Prev.Length + 1];
        for (int i = 0; i < NewArray.Length; i++)
        {
            if (i < Index)
            {
                NewArray[i] = Prev[i];
            }
            if (i == Index)
            {
                NewArray[i] = NewInput;
            }
            if (i > Index)
            {
                NewArray[i] = Prev[i - 1];
            }
        }
        return NewArray;
    }
    public static GameObject[] AddGameObjectArrayToArray(GameObject[] PrevArray, GameObject[] NewObj)
    {
        GameObject[] Temp = PrevArray;
        GameObject[] NewArray = new GameObject[Temp.Length + 1];
        for (int i = 0, i_ = 0; i < NewArray.Length; i++)
        {
            if (i < Temp.Length)
            {
                NewArray[i] = Temp[i];
            }
            else
            {
                NewArray[i] = NewObj[i_++];
            }
        }
        return NewArray;
    }
    public static GameObject[] CleanGameObjectArray(GameObject[] Prev)// Removes nulls from array
    {
        GameObject[] NewArray = new GameObject[0];
        for (int i = 0; i < Prev.Length; i++)
        {
            if (Prev[i])
            {
                NewArray = AddGameObjectToArray(NewArray, Prev[i]);
            }
        }
        return NewArray;
    }
    public static GameObject[] RemoveGameObjectByIndex(GameObject[] Prev, int Remove)// Removes nulls from array
    {
        GameObject[] NewArray = new GameObject[0];
        for (int i = 0; i < Prev.Length; i++)
        {
            if (i != Remove)
            {
                NewArray = AddGameObjectToArray(NewArray, Prev[i]);
            }
        }
        return NewArray;
    }
    public static float[] AddFloatToArray(float[] Prev, float NewFloat)
    {
        float[] NewArray = new float[Prev.Length + 1];
        for (int i = 0; i < NewArray.Length; i++)
        {
            if (i < Prev.Length)
            {
                NewArray[i] = Prev[i];
            }
            else
            {
                NewArray[i] = NewFloat;
            }
        }
        return NewArray;
    }
    public static float[] AddFloatToArrayAtIndex(float[] Prev, float NewInput, int Index)
    {
        float[] NewArray = new float[Prev.Length + 1];
        for (int i = 0; i < NewArray.Length; i++)
        {
            if (i < Index)
            {
                NewArray[i] = Prev[i];
            }
            if (i == Index)
            {
                NewArray[i] = NewInput;
            }
            if (i > Index)
            {
                NewArray[i] = Prev[i - 1];
            }
        }
        return NewArray;
    }
    public static float[] AddFloatArrayToArray(float[] Prev, float[] NewInput)
    {
        float[] NewArray = new float[Prev.Length + 1];
        for (int i = 0, i_ = 0; i < NewArray.Length; i++)
        {
            if (i < Prev.Length)
            {
                NewArray[i] = Prev[i];
            }
            else
            {
                NewArray[i] = NewInput[i_++];
            }
        }
        return NewArray;
    }
    public static float[] CleanFloatArray(float[] Prev, float RemoveValue)
    {
        float[] NewArray = new float[0];
        for (int i = 0; i < Prev.Length; i++)
        {
            if (Prev[i] != RemoveValue)
            {
                NewArray = AddFloatToArray(NewArray, Prev[i]);
            }
        }
        return NewArray;
    }
    public static float[] RemoveFloatByIndex(float[] Prev, float RemoveValue)
    {
        float[] NewArray = new float[0];
        for (int i = 0; i < Prev.Length; i++)
        {
            if (i != RemoveValue)
            {
                NewArray = AddFloatToArray(NewArray, Prev[i]);
            }
        }
        return NewArray;
    }
    public static int[] AddIntToArray(int[] Prev, int NewInt)
    {
        int[] NewArray = new int[Prev.Length + 1];
        for (int i = 0; i < NewArray.Length; i++)
        {
            if (i < Prev.Length)
            {
                NewArray[i] = Prev[i];
            }
            else
            {
                NewArray[i] = NewInt;
            }
        }
        return NewArray;
    }
    public static int[] AddIntToArrayAtIndex(int[] Prev, int NewInput, int Index)
    {
        int[] NewArray = new int[Prev.Length + 1];
        for (int i = 0; i < NewArray.Length; i++)
        {
            if (i < Index)
            {
                NewArray[i] = Prev[i];
            }
            if (i == Index)
            {
                NewArray[i] = NewInput;
            }
            if (i > Index)
            {
                NewArray[i] = Prev[i - 1];
            }
        }
        return NewArray;
    }

    public static int[] AddIntArrayToArray(int[] Prev, int[] NewInput)
    {
        int[] NewArray = new int[Prev.Length + 1];
        for (int i = 0, i_ = 0; i < NewArray.Length; i++)
        {
            if (i < Prev.Length)
            {
                NewArray[i] = Prev[i];
            }
            else
            {
                NewArray[i] = NewInput[i_++];
            }
        }
        return NewArray;
    }
    public static int[] CleanIntArray(int[] Prev, int RemoveValue)
    {
        int[] NewArray = new int[0];
        for (int i = 0; i < Prev.Length; i++)
        {
            if (Prev[i] != RemoveValue)
            {
                NewArray = AddIntToArray(NewArray, Prev[i]);
            }
        }
        return NewArray;
    }
    public static int[] RemoveIntByIndex(int[] Prev, int RemoveValue)
    {
        int[] NewArray = new int[0];
        for (int i = 0; i < Prev.Length; i++)
        {
            if (i != RemoveValue)
            {
                NewArray = AddIntToArray(NewArray, Prev[i]);
            }
        }
        return NewArray;
    }
    public static Vector2[] AddVector2ToArray(Vector2[] Prev, Vector2 NewInput)
    {
        Vector2[] NewArray = new Vector2[Prev.Length + 1];
        for (int i = 0; i < NewArray.Length; i++)
        {
            if (i < Prev.Length)
            {
                NewArray[i] = Prev[i];
            }
            else
            {
                NewArray[i] = NewInput;
            }
        }
        return NewArray;
    }
    public static Vector2[] AddVector2ToArrayAtIndex(Vector2[] Prev, Vector2 NewInput, int Index)
    {
        Vector2[] NewArray = new Vector2[Prev.Length + 1];
        for (int i = 0; i < NewArray.Length; i++)
        {
            if (i < Index)
            {
                NewArray[i] = Prev[i];
            }
            if (i == Index)
            {
                NewArray[i] = NewInput;
            }
            if (i > Index)
            {
                NewArray[i] = Prev[i - 1];
            }
        }
        return NewArray;
    }
    public static Vector2[] AddVector2ArrayToArray(Vector2[] Prev, Vector2[] NewInput)
    {
        Vector2[] NewArray = new Vector2[Prev.Length + 1];
        for (int i = 0, i_ = 0; i < NewArray.Length; i++)
        {
            if (i < Prev.Length)
            {
                NewArray[i] = Prev[i];
            }
            else
            {
                NewArray[i] = NewInput[i_++];
            }
        }
        return NewArray;
    }
    public static Vector2[] CleanVector2Array(Vector2[] Prev, Vector2 RemoveValue)
    {
        Vector2[] NewArray = new Vector2[0];
        for (int i = 0; i < Prev.Length; i++)
        {
            if (Prev[i] != RemoveValue)
            {
                NewArray = AddVector2ToArray(NewArray, Prev[i]);
            }
        }
        return NewArray;
    }
    public static Vector2[] RemoveVector2ByIndex (Vector2[] Prev, int Remove)
    {
        Vector2[] NewArray = new Vector2[0];
        for (int i = 0; i < Prev.Length; i++)
        {
            if (i != Remove)
            {
                NewArray = AddVector2ToArray(NewArray, Prev[i]);
            }
        }
        return NewArray;
    }
    public static Vector3[] AddVector3ToArray(Vector3[] Prev, Vector3 NewInput)
    {
        Vector3[] NewArray = new Vector3[Prev.Length + 1];
        for (int i = 0; i < NewArray.Length; i++)
        {
            if (i < Prev.Length)
            {
                NewArray[i] = Prev[i];
            }
            else
            {
                NewArray[i] = NewInput;
            }
        }
        return NewArray;
    }
    public static Vector3[] AddVector3ToArrayAtIndex(Vector3[] Prev, Vector3 NewInput, int Index)
    {
        Vector3[] NewArray = new Vector3[Prev.Length + 1];
        for (int i = 0; i < NewArray.Length; i++)
        {
            if(i < Index)
            {
                NewArray[i] = Prev[i];
            }
            if(i == Index)
            {
                NewArray[i] = NewInput;
            }
            if(i > Index)
            {
                NewArray[i] = Prev[i - 1];
            }
        }
        return NewArray;
    }
    public static Vector3[] AddVector3ArrayToArray(Vector3[] Prev, Vector3[] NewInput)
    {
        Vector3[] NewArray = new Vector3[Prev.Length + 1];
        for (int i = 0, i_ = 0; i < NewArray.Length; i++)
        {
            if (i < Prev.Length)
            {
                NewArray[i] = Prev[i];
            }
            else
            {
                NewArray[i] = NewInput[i_++];
            }
        }
        return NewArray;
    }
    public static Vector3[] CleanVector3Array(Vector3[] Prev, Vector3 RemoveValue)
    {
        Vector3[] NewArray = new Vector3[0];
        for (int i = 0; i < Prev.Length; i++)
        {
            if (Prev[i] != RemoveValue)
            {
                NewArray = AddVector3ToArray(NewArray, Prev[i]);
            }
        }
        return NewArray;
    }
    public static Vector3[] RemoveVector3ByIndex(Vector3[] Prev, int Remove)
    {
        Vector3[] NewArray = new Vector3[0];
        for (int i = 0; i < Prev.Length; i++)
        {
            if (i != Remove)
            {
                NewArray = AddVector3ToArray(NewArray, Prev[i]);
            }
        }
        return NewArray;
    }
    //
    public static Quaternion[] AddQuaternionToArray(Quaternion[] Prev, Quaternion NewInput)
    {
        Quaternion[] NewArray = new Quaternion[Prev.Length + 1];
        for (int i = 0; i < NewArray.Length; i++)
        {
            if (i < Prev.Length)
            {
                NewArray[i] = Prev[i];
            }
            else
            {
                NewArray[i] = NewInput;
            }
        }
        return NewArray;
    }
    public static Quaternion[] AddQuaternionToArrayAtIndex(Quaternion[] Prev, Quaternion NewInput, int Index)
    {
        Quaternion[] NewArray = new Quaternion[Prev.Length + 1];
        for (int i = 0; i < NewArray.Length; i++)
        {
            if (i < Index)
            {
                NewArray[i] = Prev[i];
            }
            if (i == Index)
            {
                NewArray[i] = NewInput;
            }
            if (i > Index)
            {
                NewArray[i] = Prev[i - 1];
            }
        }
        return NewArray;
    }
    public static Quaternion[] AddQuaternionArrayToArray(Quaternion[] Prev, Quaternion[] NewInput)
    {
        Quaternion[] NewArray = new Quaternion[Prev.Length + 1];
        for (int i = 0, i_ = 0; i < NewArray.Length; i++)
        {
            if (i < Prev.Length)
            {
                NewArray[i] = Prev[i];
            }
            else
            {
                NewArray[i] = NewInput[i_++];
            }
        }
        return NewArray;
    }
    public static Quaternion[] CleanQuaternionArray(Quaternion[] Prev, Quaternion RemoveValue)
    {
        Quaternion[] NewArray = new Quaternion[0];
        for (int i = 0; i < Prev.Length; i++)
        {
            if (Prev[i] != RemoveValue)
            {
                NewArray = AddQuaternionToArray(NewArray, Prev[i]);
            }
        }
        return NewArray;
    }
    public static Quaternion[] RemoveQuaternionByIndex(Quaternion[] Prev, int Remove)
    {
        Quaternion[] NewArray = new Quaternion[0];
        for (int i = 0; i < Prev.Length; i++)
        {
            if (i != Remove)
            {
                NewArray = AddQuaternionToArray(NewArray, Prev[i]);
            }
        }
        return NewArray;
    }
    public static string[] AddStringToArray(string[] Prev, string NewInput)
    {
        string[] NewArray = new string[Prev.Length + 1];
        for (int i = 0; i < NewArray.Length; i++)
        {
            if (i < Prev.Length)
            {
                NewArray[i] = Prev[i];
            }
            else
            {
                NewArray[i] = NewInput;
            }
        }
        return NewArray;
    }
    public static string[] AddStringToArrayAtIndex(string[] Prev, string NewInput, int Index)
    {
        string[] NewArray = new string[Prev.Length + 1];
        for (int i = 0; i < NewArray.Length; i++)
        {
            if (i < Index)
            {
                NewArray[i] = Prev[i];
            }
            if (i == Index)
            {
                NewArray[i] = NewInput;
            }
            if (i > Index)
            {
                NewArray[i] = Prev[i - 1];
            }
        }
        return NewArray;
    }
    public static string[] AddStringArrayToArray(string[] Prev, string[] NewInput)
    {
        string[] NewArray = new string[Prev.Length + 1];
        for (int i = 0, i_ = 0; i < NewArray.Length; i++)
        {
            if (i < Prev.Length)
            {
                NewArray[i] = Prev[i];
            }
            else
            {
                NewArray[i] = NewInput[i_++];
            }
        }
        return NewArray;
    }
    public static string[] CleanStringArray(string[] Prev, string RemoveValue)
    {
        string[] NewArray = new string[0];
        for (int i = 0; i < Prev.Length; i++)
        {
            if (Prev[i] != RemoveValue)
            {
                NewArray = AddStringToArray(NewArray, Prev[i]);
            }
        }
        return NewArray;
    }
    public static string[] RemoveStringByIndex(string[] Prev, int Remove)
    {
        string[] NewArray = new string[0];
        for (int i = 0; i < Prev.Length; i++)
        {
            if (i != Remove)
            {
                NewArray = AddStringToArray(NewArray, Prev[i]);
            }
        }
        return NewArray;
    }
    /// mesh filter
    public static MeshFilter[] AddMeshFilterToArray(MeshFilter[] Prev, MeshFilter NewInput)
    {
        MeshFilter[] NewArray = new MeshFilter[Prev.Length + 1];
        for (int i = 0; i<NewArray.Length; i++)
        {
            if (i<Prev.Length)
            {
                NewArray[i] = Prev[i];
            }
            else
            {
                NewArray[i] = NewInput;
            }
        }
        return NewArray;
    }
    public static MeshFilter[] AddMeshFilterToArrayAtIndex(MeshFilter[] Prev, MeshFilter NewInput, int Index)
{
        MeshFilter[] NewArray = new MeshFilter[Prev.Length + 1];
    for (int i = 0; i < NewArray.Length; i++)
    {
        if (i < Index)
        {
            NewArray[i] = Prev[i];
        }
        if (i == Index)
        {
            NewArray[i] = NewInput;
        }
        if (i > Index)
        {
            NewArray[i] = Prev[i - 1];
        }
    }
    return NewArray;
}
public static MeshFilter[] AddMeshFilterArrayToArray(MeshFilter[] Prev, MeshFilter[] NewInput)
{
        MeshFilter[] NewArray = new MeshFilter[Prev.Length + 1];
    for (int i = 0, i_ = 0; i < NewArray.Length; i++)
    {
        if (i < Prev.Length)
        {
            NewArray[i] = Prev[i];
        }
        else
        {
            NewArray[i] = NewInput[i_++];
        }
    }
    return NewArray;
}
public static MeshFilter[] CleanMeshFilterArray(MeshFilter[] Prev, MeshFilter RemoveValue)
{
        MeshFilter[] NewArray = new MeshFilter[0];
    for (int i = 0; i < Prev.Length; i++)
    {
        if (Prev[i] != RemoveValue)
        {
            NewArray = AddMeshFilterToArray(NewArray, Prev[i]);
        }
    }
    return NewArray;
}
public static MeshFilter[] RemoveMeshFilterByIndex(MeshFilter[] Prev, int Remove)
{
    MeshFilter[] NewArray = new MeshFilter[0];
    for (int i = 0; i < Prev.Length; i++)
    {
        if (i != Remove)
        {
            NewArray = AddMeshFilterToArray(NewArray, Prev[i]);
        }
    }
    return NewArray;
}
    /// Material
    public static Material[] AddMaterialToArray(Material[] Prev, Material NewInput)
    {
        Material[] NewArray = new Material[Prev.Length + 1];
        for (int i = 0; i < NewArray.Length; i++)
        {
            if (i < Prev.Length)
            {
                NewArray[i] = Prev[i];
            }
            else
            {
                NewArray[i] = NewInput;
            }
        }
        return NewArray;
    }
    public static Material[] AddMaterialToArrayAtIndex(Material[] Prev, Material NewInput, int Index)
    {
        Material[] NewArray = new Material[Prev.Length + 1];
        for (int i = 0; i < NewArray.Length; i++)
        {
            if (i < Index)
            {
                NewArray[i] = Prev[i];
            }
            if (i == Index)
            {
                NewArray[i] = NewInput;
            }
            if (i > Index)
            {
                NewArray[i] = Prev[i - 1];
            }
        }
        return NewArray;
    }
    public static Material[] AddMaterialArrayToArray(Material[] Prev, Material[] NewInput)
    {
        Material[] NewArray = new Material[Prev.Length + 1];
        for (int i = 0, i_ = 0; i < NewArray.Length; i++)
        {
            if (i < Prev.Length)
            {
                NewArray[i] = Prev[i];
            }
            else
            {
                NewArray[i] = NewInput[i_++];
            }
        }
        return NewArray;
    }
    public static Material[] CleanMaterialArray(Material[] Prev, Material RemoveValue)
    {
        Material[] NewArray = new Material[0];
        for (int i = 0; i < Prev.Length; i++)
        {
            if (Prev[i] != RemoveValue)
            {
                NewArray = AddMaterialToArray(NewArray, Prev[i]);
            }
        }
        return NewArray;
    }
    public static Material[] RemoveMaterialByIndex(Material[] Prev, int Remove)
    {
        Material[] NewArray = new Material[0];
        for (int i = 0; i < Prev.Length; i++)
        {
            if (i != Remove)
            {
                NewArray = AddMaterialToArray(NewArray, Prev[i]);
            }
        }
        return NewArray;

    }
    /// Material
    public static MeshRenderer[] AddMeshRendererToArray(MeshRenderer[] Prev, MeshRenderer NewInput)
    {
        MeshRenderer[] NewArray = new MeshRenderer[Prev.Length + 1];
        for (int i = 0; i < NewArray.Length; i++)
        {
            if (i < Prev.Length)
            {
                NewArray[i] = Prev[i];
            }
            else
            {
                NewArray[i] = NewInput;
            }
        }
        return NewArray;
    }
    public static MeshRenderer[] AddMeshRendererToArrayAtIndex(MeshRenderer[] Prev, MeshRenderer NewInput, int Index)
    {
        MeshRenderer[] NewArray = new MeshRenderer[Prev.Length + 1];
        for (int i = 0; i < NewArray.Length; i++)
        {
            if (i < Index)
            {
                NewArray[i] = Prev[i];
            }
            if (i == Index)
            {
                NewArray[i] = NewInput;
            }
            if (i > Index)
            {
                NewArray[i] = Prev[i - 1];
            }
        }
        return NewArray;
    }
    public static MeshRenderer[] AddMeshRendererArrayToArray(MeshRenderer[] Prev, MeshRenderer[] NewInput)
    {
        MeshRenderer[] NewArray = new MeshRenderer[Prev.Length + 1];
        for (int i = 0, i_ = 0; i < NewArray.Length; i++)
        {
            if (i < Prev.Length)
            {
                NewArray[i] = Prev[i];
            }
            else
            {
                NewArray[i] = NewInput[i_++];
            }
        }
        return NewArray;
    }
    public static MeshRenderer[] CleanMeshRendererArray(MeshRenderer[] Prev, MeshRenderer RemoveValue)
    {
        MeshRenderer[] NewArray = new MeshRenderer[0];
        for (int i = 0; i < Prev.Length; i++)
        {
            if (Prev[i] != RemoveValue)
            {
                NewArray = AddMeshRendererToArray(NewArray, Prev[i]);
            }
        }
        return NewArray;
    }
    public static MeshRenderer[] RemoveMaterialByIndex(MeshRenderer[] Prev, int Remove)
    {
        MeshRenderer[] NewArray = new MeshRenderer[0];
        for (int i = 0; i < Prev.Length; i++)
        {
            if (i != Remove)
            {
                NewArray = AddMeshRendererToArray(NewArray, Prev[i]);
            }
        }
        return NewArray;
    }
}
