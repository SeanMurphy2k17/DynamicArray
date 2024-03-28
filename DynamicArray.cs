using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;

public class DynamicArray
{   
    //GameObject array resizing
    private static GameObject[] TempAddGameObjectToArray;
    private static GameObject[] NewArrayAddGameObjectToArray;
    public static void AddGameObjectToArray(ref GameObject[] PrevArray, GameObject NewObj)
    {
        if (PrevArray == null)
        {
            PrevArray = new GameObject[0];
        }
        TempAddGameObjectToArray = PrevArray;
        NewArrayAddGameObjectToArray = new GameObject[TempAddGameObjectToArray.Length + 1];
        for (int i = 0; i < NewArrayAddGameObjectToArray.Length; i++)
        {
            if (i < TempAddGameObjectToArray.Length)
            {
                NewArrayAddGameObjectToArray[i] = TempAddGameObjectToArray[i];
            }
            else
            {
                NewArrayAddGameObjectToArray[i] = NewObj;
            }
        }
        PrevArray = NewArrayAddGameObjectToArray;
        //return NewArray;
    }
    private static GameObject[] NewArrayAddGameObjectToArrayAtIndex;
    public static void AddGameObjectToArrayAtIndex(ref GameObject[] Prev, GameObject NewInput, int Index)
    {
        NewArrayAddGameObjectToArrayAtIndex = new GameObject[Prev.Length + 1];
        for (int i = 0; i < NewArrayAddGameObjectToArrayAtIndex.Length; i++)
        {
            if (i < Index)
            {
                NewArrayAddGameObjectToArrayAtIndex[i] = Prev[i];
            }
            if (i == Index)
            {
                NewArrayAddGameObjectToArrayAtIndex[i] = NewInput;
            }
            if (i > Index)
            {
                NewArrayAddGameObjectToArrayAtIndex[i] = Prev[i - 1];
            }
        }
        Prev = NewArrayAddGameObjectToArrayAtIndex;
        //return NewArray;
    }
    private static GameObject[] TempAddGameObjectArrayToArray;//= PrevArray;
    private static GameObject[] NewArrayAddGameObjectArrayToArray;// = new GameObject[Temp.Length + NewObj.Length];
    public static void AddGameObjectArrayToArray(ref GameObject[] PrevArray, GameObject[] NewObj)
    {
        TempAddGameObjectArrayToArray = PrevArray;
        NewArrayAddGameObjectArrayToArray = new GameObject[TempAddGameObjectArrayToArray.Length + NewObj.Length];
        for (int i = 0, i_ = 0; i < NewArrayAddGameObjectArrayToArray.Length; i++)
        {
            if (i < TempAddGameObjectArrayToArray.Length)
            {
                NewArrayAddGameObjectArrayToArray[i] = TempAddGameObjectArrayToArray[i];
            }
            else
            {
                NewArrayAddGameObjectArrayToArray[i] = NewObj[i_++];
            }
        }
        PrevArray = NewArrayAddGameObjectArrayToArray;
    }
    private static GameObject[] NewArrayCleanGameObjectArray;// = new GameObject[0];
    public static void CleanGameObjectArray(ref GameObject[] Prev)// Removes nulls from array
    {
        NewArrayCleanGameObjectArray = new GameObject[0];
        for (int i = 0; i < Prev.Length; i++)
        {
            if (Prev[i])
            {
                AddGameObjectToArray(ref NewArrayCleanGameObjectArray, Prev[i]);
            }
        }
        Prev = NewArrayCleanGameObjectArray;
    }
    private static GameObject[] NewArrayRemoveGameObjectByIndex;
    public static void RemoveGameObjectByIndex(ref GameObject[] Prev, int Remove)// Removes nulls from array
    {
        NewArrayRemoveGameObjectByIndex = new GameObject[0];
        for (int i = 0; i < Prev.Length; i++)
        {
            if (i != Remove)
            {
                AddGameObjectToArray(ref NewArrayRemoveGameObjectByIndex, Prev[i]);
            }
        }
        Prev = NewArrayRemoveGameObjectByIndex;
    }
    //Transform 

    private static Transform[] TempAddTransformToArray;
    private static Transform[] NewArrayAddTransformToArray;
    public static void AddTransformToArray(ref Transform[] PrevArray, Transform NewObj)
    {
        if (PrevArray == null)
        {
            PrevArray = new Transform[0];
        }
        TempAddTransformToArray = PrevArray;
        NewArrayAddTransformToArray = new Transform[TempAddTransformToArray.Length + 1];
        for (int i = 0; i < NewArrayAddTransformToArray.Length; i++)
        {
            if (i < TempAddTransformToArray.Length)
            {
                NewArrayAddTransformToArray[i] = TempAddTransformToArray[i];
            }
            else
            {
                NewArrayAddTransformToArray[i] = NewObj;
            }
        }
        PrevArray = NewArrayAddTransformToArray;
    }
    private static Transform[] NewArrayAddTransformToArrayAtIndex;// = new Transform[Prev.Length + 1];
    public static void AddTransformToArrayAtIndex(ref Transform[] Prev, Transform NewInput, int Index)
    {
        NewArrayAddTransformToArrayAtIndex = new Transform[Prev.Length + 1];
        for (int i = 0; i < NewArrayAddTransformToArrayAtIndex.Length; i++)
        {
            if (i < Index)
            {
                NewArrayAddTransformToArrayAtIndex[i] = Prev[i];
            }
            if (i == Index)
            {
                NewArrayAddTransformToArrayAtIndex[i] = NewInput;
            }
            if (i > Index)
            {
                NewArrayAddTransformToArrayAtIndex[i] = Prev[i - 1];
            }
        }
        Prev = NewArrayAddTransformToArrayAtIndex;
    }
    private static Transform[] TempAddTransformArrayToArray;// = PrevArray;
    private static Transform[] NewArrayAddTransformArrayToArray;//= new Transform[Temp.Length + NewObj.Length];
    public static void AddTransformArrayToArray(ref Transform[] PrevArray, Transform[] NewObj)
    {
        TempAddTransformArrayToArray = PrevArray;
        NewArrayAddTransformArrayToArray = new Transform[TempAddTransformArrayToArray.Length + NewObj.Length];
        for (int i = 0, i_ = 0; i < NewArrayAddTransformArrayToArray.Length; i++)
        {
            if (i < TempAddTransformArrayToArray.Length)
            {
                NewArrayAddTransformArrayToArray[i] = TempAddTransformArrayToArray[i];
            }
            else
            {
                NewArrayAddTransformArrayToArray[i] = NewObj[i_++];
            }
        }
        PrevArray = NewArrayAddTransformArrayToArray;
    }
    private static Transform[] NewArrayCleanTransformArray = new Transform[0];
    public static void CleanTransformArray(ref Transform[] Prev)// Removes nulls from array
    {
        NewArrayCleanTransformArray = new Transform[0];
        for (int i = 0; i < Prev.Length; i++)
        {
            if (Prev[i])
            {
                AddTransformToArray(ref NewArrayCleanTransformArray, Prev[i]);
            }
        }
        Prev = NewArrayCleanTransformArray;
    }
    private static Transform[] NewArrayRemoveTransformByIndex = new Transform[0];
    public static void RemoveTransformByIndex(ref Transform[] Prev, int Remove)// Removes nulls from array
    {
        NewArrayRemoveTransformByIndex = new Transform[0];
        for (int i = 0; i < Prev.Length; i++)
        {
            if (i != Remove)
            {
                AddTransformToArray(ref NewArrayRemoveTransformByIndex, Prev[i]);
            }
        }
        Prev = NewArrayRemoveTransformByIndex;
    }
    //
    private static float[] NewArrayAddFloatToArray;// = new float[Prev.Length + 1];
    public static float[] AddFloatToArray(float[] Prev, float NewFloat)
    {
        NewArrayAddFloatToArray = new float[Prev.Length + 1];
        for (int i = 0; i < NewArrayAddFloatToArray.Length; i++)
        {
            if (i < Prev.Length)
            {
                NewArrayAddFloatToArray[i] = Prev[i];
            }
            else
            {
                NewArrayAddFloatToArray[i] = NewFloat;
            }
        }
        return NewArrayAddFloatToArray;
    }
    private static float[] NewArrayAddFloatToArrayAtIndex;// = new float[Prev.Length + 1];
    public static float[] AddFloatToArrayAtIndex(float[] Prev, float NewInput, int Index)
    {
        NewArrayAddFloatToArrayAtIndex = new float[Prev.Length + 1];
        for (int i = 0; i < NewArrayAddFloatToArrayAtIndex.Length; i++)
        {
            if (i < Index)
            {
                NewArrayAddFloatToArrayAtIndex[i] = Prev[i];
            }
            if (i == Index)
            {
                NewArrayAddFloatToArrayAtIndex[i] = NewInput;
            }
            if (i > Index)
            {
                NewArrayAddFloatToArrayAtIndex[i] = Prev[i - 1];
            }
        }
        return NewArrayAddFloatToArrayAtIndex;
    }
    private static float[] NewArrayAddFloatArrayToArray;
    public static float[] AddFloatArrayToArray(float[] Prev, float[] NewInput)
    {
        NewArrayAddFloatArrayToArray = new float[Prev.Length + NewInput.Length];
        for (int i = 0, i_ = 0; i < NewArrayAddFloatArrayToArray.Length; i++)
        {
            if (i < Prev.Length)
            {
                NewArrayAddFloatArrayToArray[i] = Prev[i];
            }
            else
            {
                NewArrayAddFloatArrayToArray[i] = NewInput[i_++];
            }
        }
        return NewArrayAddFloatArrayToArray;
    }
    private static float[] NewArrayCleanFloatArray;
    public static float[] CleanFloatArray(float[] Prev, float RemoveValue)
    {
        NewArrayCleanFloatArray = new float[0];
        for (int i = 0; i < Prev.Length; i++)
        {
            if (Prev[i] != RemoveValue)
            {
                NewArrayCleanFloatArray = AddFloatToArray(NewArrayCleanFloatArray, Prev[i]);
            }
        }
        return NewArrayCleanFloatArray;
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
    public static void AddIntToArray(ref int[] Prev, int NewInt)
    {
        if(Prev == null)
        {
            Prev = new int[0];
        }
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
        Prev = NewArray;
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
        int[] NewArray = new int[Prev.Length + NewInput.Length];
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
    public static void CleanIntArray(ref int[] Prev, int RemoveValue)
    {
        int[] NewArray = new int[0];
        for (int i = 0; i < Prev.Length; i++)
        {
            if (Prev[i] != RemoveValue)
            {
                /*NewArray =*/ AddIntToArray(ref NewArray, Prev[i]);
            }
        }
        Prev = NewArray;
    }
    public static int[] RemoveIntByIndex(int[] Prev, int RemoveValue)
    {
        int[] NewArray = new int[0];
        for (int i = 0; i < Prev.Length; i++)
        {
            if (i != RemoveValue)
            {
                /*NewArray =*/ AddIntToArray(ref NewArray, Prev[i]);
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
        Vector2[] NewArray = new Vector2[Prev.Length + NewInput.Length];
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
        Vector3[] NewArray = new Vector3[Prev.Length + NewInput.Length];
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
        Quaternion[] NewArray = new Quaternion[Prev.Length + NewInput.Length];
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
        string[] NewArray = new string[Prev.Length + NewInput.Length];
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
        if(Prev == null)
        {
            Prev = new MeshFilter[0];
        }
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
        MeshFilter[] NewArray = new MeshFilter[Prev.Length + NewInput.Length];
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
        Material[] NewArray = new Material[Prev.Length + NewInput.Length];
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
        MeshRenderer[] NewArray = new MeshRenderer[Prev.Length + NewInput.Length];
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
  
   
}
