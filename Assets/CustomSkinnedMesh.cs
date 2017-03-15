using UnityEngine;
using System.Collections;

public class CustomSkinnedMesh : MonoBehaviour
{

    public Material mat;
    public Transform[] bones;

    void Start()
    {
        Mesh m = new Mesh();

        m.vertices = new Vector3[]
        {
               //머리
               new Vector3(0.0f,6.0f,0.0f),
               new Vector3(-4.0f,10.0f,0.0f),
               new Vector3(4.0f,10.0f,0.0f),

               //몸통
               new Vector3(0.0f,0.0f,0.0f),
               new Vector3(-5.0f,6.0f,0.0f),
               new Vector3(5.0f,6.0f,0.0f),

               //왼팔
               new Vector3(-5.0f,0.0f,0.0f),
               new Vector3(-7.0f,0.0f,0.0f),

               // 오른팔
               new Vector3(7.0f,0.0f,0.0f),
               new Vector3(5.0f,0.0f,0.0f),

               //골반
               new Vector3(3.0f,-3.0f,0.0f),
               new Vector3(-3.0f,-3.0f,0.0f),

               // 왼발
               new Vector3(-3.0f,-10.0f,0.0f),
               new Vector3(-6.0f,-10.0f,0.0f),

               // 오른발
               new Vector3(6.0f,-10.0f,0.0f),
               new Vector3(3.0f,-10.0f,0.0f),

        };

        m.triangles = new int[]
        {
               // 머리
               0,1,2,
               //몸통
               3,4,5,
               //왼팔
               6,7,4,
               //오른팔
               8,9,5,
               //골반
               10,11,3,
               //왼다리
               12,13,11,
               //오른다리
               14,15,10,
        };

        m.colors = new Color[]
        {
            Color.white,
            Color.red,
            Color.red,

            Color.gray,
            Color.green,
            Color.green,

            Color.blue,
            Color.blue,

            Color.blue,
            Color.blue,

            Color.yellow,
            Color.yellow,

            Color.blue,
            Color.blue,

            Color.blue,
            Color.blue,
        };

        m.bindposes = new Matrix4x4[]
        {
            bones[0].worldToLocalMatrix * transform.localToWorldMatrix,
            bones[1].worldToLocalMatrix * transform.localToWorldMatrix,
            bones[2].worldToLocalMatrix * transform.localToWorldMatrix,
            bones[3].worldToLocalMatrix * transform.localToWorldMatrix,
            bones[4].worldToLocalMatrix * transform.localToWorldMatrix,
            bones[5].worldToLocalMatrix * transform.localToWorldMatrix,
            bones[6].worldToLocalMatrix * transform.localToWorldMatrix,
            bones[7].worldToLocalMatrix * transform.localToWorldMatrix,
            bones[8].worldToLocalMatrix * transform.localToWorldMatrix,
            bones[9].worldToLocalMatrix * transform.localToWorldMatrix,
            bones[10].worldToLocalMatrix * transform.localToWorldMatrix,
        };

        m.boneWeights = new BoneWeight[]
        {
            // 0~2
            new BoneWeight() { boneIndex0 = 1, weight0 = 0.4f, boneIndex1 = 3, weight1 = 0.3f, boneIndex2 = 4 , weight2 = 0.3f },
            new BoneWeight() { boneIndex0 = 0, weight0 = 1f },
            new BoneWeight() { boneIndex0 = 0, weight0 = 1f },

            // 3~5
            new BoneWeight() { boneIndex0 = 2, weight0 = 1f },
            new BoneWeight() { boneIndex0 = 1, weight0 = 0.5f, boneIndex1 =  3, weight1 = 0.5f},
            new BoneWeight() {boneIndex0 = 1, weight0 = 0.5f, boneIndex1 = 4, weight1 = 0.5f },

            // 6,7
            new BoneWeight() { boneIndex0 = 5, weight0 = 0.5f, boneIndex1 = 3, weight1 = 0.5f },
            new BoneWeight() {boneIndex0 = 5, weight0 = 0.5f, boneIndex1 = 3, weight1 = 0.5f },

            // 8,9
            new BoneWeight() {boneIndex0 = 4, weight0 = 0.5f, boneIndex1 = 6,  weight1 = 0.5f},
            new BoneWeight() {boneIndex0 = 4, weight0 = 0.5f, boneIndex1 = 6, weight1 = 0.5f },

            // 10, 11
            new BoneWeight() {boneIndex0 = 7, weight0 = 1f },
            new BoneWeight() {boneIndex0 = 8, weight0 = 1f },

            // 12, 13
            new BoneWeight() {boneIndex0 = 8, weight0 = 0.5f, boneIndex1 = 9, weight1 = 0.5f},
            new BoneWeight() {boneIndex0 = 9, weight0 = 1f },

            // 14, 15
            new BoneWeight() {boneIndex0 = 10, weight0 = 1f },
            new BoneWeight() {boneIndex0 = 10, weight0 = 0.5f, boneIndex1 = 7, weight1 = 0.5f },


        };

        SkinnedMeshRenderer smr = GetComponent<SkinnedMeshRenderer>();
        smr.sharedMesh = m;
        smr.sharedMaterial = mat;
        smr.bones = bones;
        smr.rootBone = transform;
        smr.quality = SkinQuality.Bone4;
    }

    void Update()
    {

    }
}
