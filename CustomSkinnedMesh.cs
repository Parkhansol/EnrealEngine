using UnityEngine;
using System.Collections;

public class CustomSkinnedMesh : MonoBehaviour {

    public Material mat;
    public Transform[] bones;

    void Start() {
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
            // 몸통
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

        m.bindposes = new Matrix4x4[]
        {
            bones[0].worldToLocalMatrix * transform.localToWorldMatrix,
            bones[1].worldToLocalMatrix * transform.localToWorldMatrix
        };

        m.boneWeights = new BoneWeight[]
        {
            new BoneWeight() { boneIndex0 = 0, weight0 = 1f },  
            new BoneWeight() { boneIndex0 = 0, weight0 = 1f },
            new BoneWeight() {boneIndex0 = 0, weight0 = 1f },

            new BoneWeight() { boneIndex0 = 1, weight0 = 1f },
            new BoneWeight() { boneIndex0 = 2, weight0 = 1f },
            new BoneWeight() {boneIndex0 = 3, weight0 = 1f },

            new BoneWeight() { boneIndex0 = 2, weight0 = 1f },
            new BoneWeight() {boneIndex0 = 2, weight0 = 1f },

            new BoneWeight() {boneIndex0 = 3, weight0 = 1f },
            new BoneWeight() {boneIndex0 = 3, weight0 = 1f },

            new BoneWeight() {boneIndex0 = 1, weight0 = 1f },
            new BoneWeight() {boneIndex0 = 1, weight0 = 1f },
        };

        SkinnedMeshRenderer smr = GetComponent<SkinnedMeshRenderer>();
        smr.sharedMesh = m;
        smr.sharedMaterial = mat;
        smr.bones = bones;
        smr.rootBone = transform;
        smr.quality = SkinQuality.Bone2;
    }
	
	void Update () {
	
	}
}
