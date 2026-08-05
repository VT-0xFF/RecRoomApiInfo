using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom;
using RecRoom.Attributes;
using RecRoom.Core;
using RecRoom.Core.Creation;
using RecRoom.Core.Culling;
using RecRoom.Core.Imposters;
using RecRoom.Core.Locomotion;
using RecRoom.Core.Platforms;
using RecRoom.DataLayer;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.Initialization;
using RecRoom.Logging;
using RecRoom.Logging.Attributes;
using RecRoom.NoEngine.Common;
using RecRoom.Settings;
using UJect;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.Scripting;
using UnityEngine.Serialization;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[ExecuteInEditMode]
public class BobbingMotion : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public enum Axis
	{
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		X,
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		Y,
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		Z
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	[SerializeField]
	private Axis bobAxis;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	[SerializeField]
	private float scaleBobAmount;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	[SerializeField]
	private float scaleBobSpeed;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	[SerializeField]
	private bool inWorldSpace;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private float SECWODJDQNU;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private Vector3 QQISDWWAITK
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x81AED90", Offset = "0x81AE190", VA = "0x1881AED90")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x81AED50", Offset = "0x81AE150", VA = "0x1881AED50")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x81AEF70", Offset = "0x81AE370", VA = "0x1881AEF70")]
	private void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x81AF1A0", Offset = "0x81AE5A0", VA = "0x1881AF1A0")]
	public BobbingMotion()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class DisableDuringPlayback : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x130B550", Offset = "0x130A950", VA = "0x18130B550")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0xAA4900", Offset = "0xAA3D00", VA = "0x180AA4900")]
	public DisableDuringPlayback()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class ImposterBehaviorMaterialAlpha : MonoBehaviour, ZRXOIRCMEVF
{
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private const string BAQQCWYADVN = "_BaseColor";

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private const string CJHUVYEHTGP = "_MainColor";

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	[SerializeField]
	[TooltipAttribute("List of Renderers to increase color alpha")]
	private List<Renderer> imposterRenderers;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[SerializeField]
	[Range(0f, 1f)]
	private float imposterAlpha;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static List<Material> BPZWHMBPRAJ;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static List<Material> BSORSYAPFZL;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "4")]
	public void PrepareImposter(ImposterParameters parameters)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x81B0370", Offset = "0x81AF770", VA = "0x1881B0370")]
	public ImposterBehaviorMaterialAlpha()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[ExecuteInEditMode]
[UnityEngine.Scripting.Preserve]
public class InstancedMeshGroup : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	[FormerlySerializedAs("me")]
	public Mesh mesh;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	[FormerlySerializedAs("ma")]
	public Material material;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	[FormerlySerializedAs("trs")]
	public Matrix4x4[] MatricesTRS;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public Component[] componentsToHide;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x81B07E0", Offset = "0x81AFBE0", VA = "0x1881B07E0")]
	private void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x81B0880", Offset = "0x81AFC80", VA = "0x1881B0880")]
	public void initialize(Mesh _mesh, Material _material, Matrix4x4[] _xforms, Component[] _ComponentsToHide)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0xAA4900", Offset = "0xAA3D00", VA = "0x180AA4900")]
	public InstancedMeshGroup()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[NativeContainer]
public struct JobMeshGroup : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public enum MeshMergeModes
	{
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		CollapseSubMeshes,
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		CollapseToUniqueMaterials,
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		MergeAll
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct MeshCombineJob : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		[ReadOnly]
		public JobMeshGroup JobMeshesGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		[ReadOnly]
		public int MaxUberIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public JobMesh NewMesh;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x81B1B70", Offset = "0x81B0F70", VA = "0x1881B1B70", Slot = "4")]
		public void Execute()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private struct JobMeshSlice
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public NativeSlice<Vector3> vertices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public NativeSlice<Vector3> normals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public NativeSlice<Vector4> tangents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public NativeSlice<Vector2> uv;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public NativeSlice<Vector2> uv2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public NativeSlice<Vector2> uv3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public NativeSlice<Vector2> uv4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public NativeSlice<Color> colors;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public NativeSlice<BoneWeight> boneWeights;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public NativeSlice<Matrix4x4> bindPoses;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public NativeSlice<int> triangles;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public NativeSlice<int> subMeshTriOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public NativeSlice<int> subMeshLengths;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public NativeSlice<int> boneIndexLookups;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public NativeSlice<byte> materialIDs;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public int BoneWeightOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public Matrix4x4 MeshTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public bool FlipTris;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public int NumSubMeshes;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public NativeArray<Vector3> vertices;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public NativeArray<int> meshVertStarts;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public NativeArray<Vector3> normals;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public NativeArray<Vector4> tangents;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public NativeArray<Vector2> uv;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public NativeArray<Vector2> uv2;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public NativeArray<Vector2> uv3;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public NativeArray<Vector2> uv4;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public NativeArray<Color> colors;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public NativeArray<BoneWeight> boneWeights;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public NativeArray<int> boneIndexLookups;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public NativeArray<int> boneIndexOffsets;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private NativeArray<int> meshNumBones;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private NativeArray<Matrix4x4> bindPoses;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private NativeArray<int> bindPoseStarts;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public NativeArray<int> triangles;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public NativeArray<int> meshTriStarts;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private NativeArray<Matrix4x4> meshTransforms;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private NativeArray<byte> meshFlipTris;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private NativeArray<int> meshBoneWeightOverrides;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private NativeArray<int> meshNumSubMeshes;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private NativeArray<int> meshGlobalSubMeshIndex;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public NativeArray<sbyte> subMeshUberMaterialIndices;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public NativeArray<int> subMeshTriStarts;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public NativeArray<int> subMeshTriLengths;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public NativeArray<byte> subMeshMaterialIds;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private NativeArray<int> Params;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int FGTFCNJBPQK
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x81B0CA0", Offset = "0x81B00A0", VA = "0x1881B0CA0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int DIWJMTKXOJO
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x81B0C70", Offset = "0x81B0070", VA = "0x1881B0C70")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int PAAESJMABYH
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x81B0C90", Offset = "0x81B0090", VA = "0x1881B0C90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public MeshMergeModes RVAVSJYIDNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x81B0C80", Offset = "0x81B0080", VA = "0x1881B0C80")]
		get
		{
			return default(MeshMergeModes);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private JobMeshSlice this[int meshIndex]
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x81B0CB0", Offset = "0x81B00B0", VA = "0x1881B0CB0")]
		get
		{
			return default(JobMeshSlice);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x81B09F0", Offset = "0x81AFDF0", VA = "0x1881B09F0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[NativeContainer]
public struct JobMesh : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public NativeArray<Vector3> vertices;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public NativeArray<Vector3> normals;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public NativeArray<Vector4> tangents;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public NativeArray<Vector2> uv;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public NativeArray<Vector2> uv2;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public NativeArray<Vector2> uv3;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public NativeArray<Vector2> uv4;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public NativeArray<Color> colors;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public NativeArray<BoneWeight> boneWeights;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public NativeArray<Matrix4x4> bindPoses;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public NativeArray<int> triangles;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private NativeArray<int> subMeshTriOffsets;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private NativeArray<int> subMeshLengths;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private NativeArray<int> Params;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int BXCSXFVGHFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x81B1400", Offset = "0x81B0800", VA = "0x1881B1400")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x81B1410", Offset = "0x81B0810", VA = "0x1881B1410")]
	public void ZJVRFPBIJRR(int a, int b, int c)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x81B1290", Offset = "0x81B0690", VA = "0x1881B1290", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[RequireComponent(typeof(ParticleSystem))]
[DisallowMultipleComponent]
public class ParticleSystemTextureStreamerTag : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private static readonly Log HONKOTEDSFS;

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x81B41A0", Offset = "0x81B35A0", VA = "0x1881B41A0")]
	private void Start()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x81B3F50", Offset = "0x81B3350", VA = "0x1881B3F50")]
	private void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x81B3FF0", Offset = "0x81B33F0", VA = "0x1881B3FF0")]
	private bool PHUQZSHWLEM([Out] AACGBZVGLWC a)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0xAA4900", Offset = "0xAA3D00", VA = "0x180AA4900")]
	public ParticleSystemTextureStreamerTag()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class PlayerHandWorldCollisionConfig : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0xAA4900", Offset = "0xAA3D00", VA = "0x180AA4900")]
	public PlayerHandWorldCollisionConfig()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class PlayerWorldCollisionConfig : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	[SerializeField]
	private RoomScaleCollisionType playerCollisionType;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public RoomScaleCollisionType ALWWRTQJJFD
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xAB5660", Offset = "0xAB4A60", VA = "0x180AB5660")]
		get
		{
			return default(RoomScaleCollisionType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x75B1760", Offset = "0x75B0B60", VA = "0x1875B1760")]
	public PlayerWorldCollisionConfig()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[Obsolete("Use the ScreenshotGeneratorWindow instead")]
[RequireComponent(typeof(Camera))]
public class ScreenshotGenerator : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public int Width;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public int Height;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public int AntiAliasLevel;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public bool UseAlpha;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x81B42F0", Offset = "0x81B36F0", VA = "0x1881B42F0")]
	public ScreenshotGenerator()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class ShippingContainer : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	[SerializeField]
	public GameObject[] partRoots;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	[SerializeField]
	public MeshRenderer[] lodRenderers;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool KZLAGPRPFJT
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x81B49A0", Offset = "0x81B3DA0", VA = "0x1881B49A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0xAA4900", Offset = "0xAA3D00", VA = "0x180AA4900")]
	public ShippingContainer()
	{
	}
}
namespace _LogRegistration.RecRoom_Content_Authoring_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	[Obfuscation(ApplyToMembers = false)]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : RecRoom.Logging.LogRegistrationIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x81B14D0", Offset = "0x81B08D0", VA = "0x1881B14D0", Slot = "4")]
		public override void SHWXSEAJSCT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xACE190", Offset = "0xACD590", VA = "0x180ACE190")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_Content_Authoring_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	[Obfuscation(ApplyToMembers = false)]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x81B5C00", Offset = "0x81B5000", VA = "0x1881B5C00", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x26F2710", Offset = "0x26F1B10", VA = "0x1826F2710")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.Settings
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public interface XHPBROBAIBI
	{
		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		RecRoomQualitySetting PBGHKSAGKPT
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		KBLPOZGJAAH<RecRoomQualitySetting> FAQFFMMCEAP
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public enum RecRoomQualitySetting
	{
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		Fastest,
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		Simple,
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		Ultra,
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		PS4VR,
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		iOSHigh,
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		PS4Screens,
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		iOSLow,
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		XboxOne,
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		AndroidMobileLow,
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		AndroidMobileHigh,
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		PS5,
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		XboxSeries,
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		Pico,
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		Switch,
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		Count
	}
}
namespace RecRoom.VFX
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[RequireComponent(typeof(Light))]
	[ExecuteInEditMode]
	public class ParticleScriptedLight : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		[SerializeField]
		private ParticleSystem targetSystem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		[SerializeField]
		private AnimationCurve intensityCurve;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private Light CQXOGSJLNOB;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public Light HCDPDLWVKCF
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x81B3EC0", Offset = "0x81B32C0", VA = "0x1881B3EC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x81B3D50", Offset = "0x81B3150", VA = "0x1881B3D50")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x81B3E70", Offset = "0x81B3270", VA = "0x1881B3E70")]
		public ParticleScriptedLight()
		{
		}
	}
}
namespace RecRoom.Utils.Mesh
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[ExecuteInEditMode]
	public class InstanceColor : MonoBehaviour, ZRXOIRCMEVF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		[SerializeField]
		[HideInInspector]
		private Color color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		[Autofill(AutofillType.SelfAndParent, false, false, false)]
		private CYCCEEGNHOX RESATHOTDUI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public Renderer[] renderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		[SerializeField]
		private bool ignorePrepareImposterBehavior;

		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private static readonly int PAIJJUSQLTH;

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x81B04C0", Offset = "0x81AF8C0", VA = "0x1881B04C0")]
		private void LSSAGUVGUNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x81B03F0", Offset = "0x81AF7F0", VA = "0x1881B03F0")]
		private void HESZPPHCWKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x81B0670", Offset = "0x81AFA70", VA = "0x1881B0670")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x81B0600", Offset = "0x81AFA00", VA = "0x1881B0600", Slot = "4")]
		public void PrepareImposter(ImposterParameters parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xAA4900", Offset = "0xAA3D00", VA = "0x180AA4900")]
		public InstanceColor()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class MaterialInstance : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public Renderer[] renderers;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x81B1550", Offset = "0x81B0950", VA = "0x1881B1550")]
		public void ClearProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x81B1620", Offset = "0x81B0A20", VA = "0x1881B1620")]
		public void SetColor(string name, Color value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x81B1730", Offset = "0x81B0B30", VA = "0x1881B1730")]
		public void SetFloat(string name, float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x81B1A60", Offset = "0x81B0E60", VA = "0x1881B1A60")]
		public void SetVector(string name, Vector4 value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x81B1930", Offset = "0x81B0D30", VA = "0x1881B1930")]
		public void SetVector(string name, float x, float y, float z, float w)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x81B1830", Offset = "0x81B0C30", VA = "0x1881B1830")]
		public void SetTexture(string name, Texture2D value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xAA4900", Offset = "0xAA3D00", VA = "0x180AA4900")]
		public MaterialInstance()
		{
		}
	}
}
namespace RecRoom.Core
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public interface ZEXFMPWHIYD
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int GetDesiredMipLevel();
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public interface AACGBZVGLWC
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool WDVWZPHOAWA(ZEXFMPWHIYD a, Texture2D b, [Out] int c);

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void CKGUKEGUJET(ZEXFMPWHIYD a, int b);

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void EFBVRJOJFKD(ParticleSystem a);

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void YKJAQBLGKPU(ParticleSystem a);
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class ParticleEventListener : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200001C")]
		public delegate void ParticleCollision(ParticleEventListener listener, Collider other, IEnumerable<ParticleCollisionEvent> collisions);

		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private static readonly List<ParticleCollisionEvent> KYHQPJVFBXP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		[Autofill(AutofillType.Self, false, false, false)]
		[SerializeField]
		private ParticleSystem particles;

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event ParticleCollision SKCONOMZAQC
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x81B2C10", Offset = "0x81B2010", VA = "0x1881B2C10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x81B2CB0", Offset = "0x81B20B0", VA = "0x1881B2CB0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x81B28C0", Offset = "0x81B1CC0", VA = "0x1881B28C0")]
		private void OnParticleCollision(GameObject other)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0xAA4900", Offset = "0xAA3D00", VA = "0x180AA4900")]
		public ParticleEventListener()
		{
		}
	}
}
namespace RecRoom.Core.StaticBatching
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public class StaticBatch : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public Component[] SourceObjects;

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xAA4900", Offset = "0xAA3D00", VA = "0x180AA4900")]
		public StaticBatch()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class StaticBatchManager : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public bool UseSpacePartition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		[ConditionalField("UseSpacePartition")]
		public float SpacePartitionCubeSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public bool ForceLOD0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public bool OnlyBatchProBuilderMeshes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public bool SplitOriginalSubmeshes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public bool StripToJustUV0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		[TooltipAttribute("If true, the StaticBatcher will not generate batches that only contain 1 Renderer. Disabling this can be useful for debugging why certain objects cannot batch. This setting does not affect LOD groups: batches of 1 LOD group are never created.")]
		public bool RemoveBatchesOfOneRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		[HideInInspector]
		public List<MeshRenderer> originalAssets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		[HideInInspector]
		public List<LODGroup> originalLodGroups;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		[HideInInspector]
		public List<GameObject> staticBatches;

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x81B4AB0", Offset = "0x81B3EB0", VA = "0x1881B4AB0")]
		public StaticBatchManager()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class StaticBatchMeshData : ScriptableObject
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public List<Mesh> RTIXPRJVPGN
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0xAAA880", Offset = "0xAA9C80", VA = "0x180AAA880")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x81B4AD0", Offset = "0x81B3ED0", VA = "0x1881B4AD0")]
		public bool ClearNullMeshes()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x81B4BF0", Offset = "0x81B3FF0", VA = "0x1881B4BF0")]
		public StaticBatchMeshData()
		{
		}
	}
}
namespace RecRoom.Core.Quality
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class DisableMeshShadowsForQualitySetting : ActivationController<bool>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		[SerializeField]
		private Renderer[] AffectedRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private bool ZFIWQTWPVEQ;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		protected override OnSceneOrPrefabSaveBehaviorType SPIBWBWEUNT
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xAFEDD0", Offset = "0xAFE1D0", VA = "0x180AFEDD0", Slot = "4")]
			get
			{
				return default(OnSceneOrPrefabSaveBehaviorType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x81AFE50", Offset = "0x81AF250", VA = "0x1881AFE50")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x81B00D0", Offset = "0x81AF4D0", VA = "0x1881B00D0")]
		private void YUEEMKUUYFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x81B00A0", Offset = "0x81AF4A0", VA = "0x1881B00A0")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x81AFED0", Offset = "0x81AF2D0", VA = "0x1881AFED0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x81AFFF0", Offset = "0x81AF3F0", VA = "0x1881AFFF0")]
		private void OnQualitySettingChanged(RecRoomQualitySetting setting)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x1106790", Offset = "0x1105B90", VA = "0x181106790", Slot = "7")]
		protected override bool MOLSDPJKVSO(bool a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x81AFE60", Offset = "0x81AF260", VA = "0x1881AFE60", Slot = "8")]
		protected override void HAROVKPPMTY(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x81B0260", Offset = "0x81AF660", VA = "0x1881B0260")]
		public DisableMeshShadowsForQualitySetting()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public class ParticleQualityOverride : MonoBehaviour
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000023")]
		public struct OverrideSettings
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009F")]
			public ParticleQualityLevel particleQuality;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			public int maxParticles;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000A1")]
			public bool enableTrails;

			[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
			[Cpp2IlInjected.Token(Token = "0x40000A2")]
			public bool enableCollisions;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
			[Cpp2IlInjected.Token(Token = "0x40000A3")]
			public bool overrideEmissionRate;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			[Range(0f, 1f)]
			public float emissionRateMultiplier;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			public bool overrideLifetime;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			[Range(0f, 2f)]
			public float lifetimeMultiplier;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		[Autofill(AutofillType.Self, false, false, false)]
		[SerializeField]
		private ParticleSystem particles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		[SerializeField]
		private OverrideSettings[] overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private bool WVBSPMUZMTF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private int PCYOPDQEJLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private bool QWIEEIASNYX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private bool CZKNATGYEAX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private float VAQKOGJCWDQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private float LLYOJGUJKWO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private float ECWALOOLFQE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private float AZBPZXNQSNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private float CCWMVWOYUZQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private float NUBNCUORRBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private ParticleSystem.MainModule LGAYYQUKLDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private ParticleSystem.TrailModule KBJISCFHIVM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private ParticleSystem.EmissionModule OJMBKQOMDDT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private ParticleSystem.CollisionModule OSLPUCVMLCK;

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x81B3B90", Offset = "0x81B2F90", VA = "0x1881B3B90")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x81B3730", Offset = "0x81B2B30", VA = "0x1881B3730")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x81B3840", Offset = "0x81B2C40", VA = "0x1881B3840")]
		private void OnQualitySettingChanged(RecRoomQualitySetting setting)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x81B2F60", Offset = "0x81B2360", VA = "0x1881B2F60")]
		private void IEZBNUGWCVH(IRecRoomQualityConfigProvider a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x81B2D50", Offset = "0x81B2150", VA = "0x1881B2D50")]
		private void FRDHLNUZOWX(OverrideSettings a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x81B3460", Offset = "0x81B2860", VA = "0x1881B3460")]
		private void IMOSMUKXGCY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x81B38C0", Offset = "0x81B2CC0", VA = "0x1881B38C0")]
		private void PHHHVSBUIWV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x81B3600", Offset = "0x81B2A00", VA = "0x1881B3600")]
		private void MHXEZSOUAZH(ParticleSystem.MinMaxCurve a, [Out] float b, [Out] float c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x81B3A60", Offset = "0x81B2E60", VA = "0x1881B3A60")]
		private ParticleSystem.MinMaxCurve QIEXNMQEYVX(ParticleSystem.MinMaxCurve a, float b, float c)
		{
			return default(ParticleSystem.MinMaxCurve);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xAA4900", Offset = "0xAA3D00", VA = "0x180AA4900")]
		public ParticleQualityOverride()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public abstract class QualityBasedActivationController<T> : ActivationController<T> where T : IConvertible
	{
		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		protected override OnSceneOrPrefabSaveBehaviorType SPIBWBWEUNT
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0xAFEDD0", Offset = "0xAFE1D0", VA = "0x180AFEDD0", Slot = "4")]
			get
			{
				return default(OnSceneOrPrefabSaveBehaviorType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "9")]
		protected abstract T NWHKHBTKCKV(IRecRoomQualityConfigProvider a);

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x5AF48E0", Offset = "0x5AF3CE0", VA = "0x185AF48E0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x5AF50C0", Offset = "0x5AF44C0", VA = "0x185AF50C0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x5AF5330", Offset = "0x5AF4730", VA = "0x185AF5330")]
		private void OnQualitySettingChanged(RecRoomQualitySetting setting)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x5AF4EC0", Offset = "0x5AF42C0", VA = "0x185AF4EC0")]
		private void CIUSTYNBEJW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x5AF4F60", Offset = "0x5AF4360", VA = "0x185AF4F60", Slot = "8")]
		protected override void HAROVKPPMTY(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x5AF5340", Offset = "0x5AF4740", VA = "0x185AF5340")]
		protected QualityBasedActivationController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	internal static class ZHLAJFPQYPE
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x81B5B10", Offset = "0x81B4F10", VA = "0x1881B5B10")]
		[CVOOPLRRRUK.Root]
		internal static void UUDUQLMHCPR(XRSJVGYQFTW a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class SetActiveBasedOnAlphaClippingSupport : QualityBasedActivationController<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x2000027")]
		private enum Behavior
		{
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			EnabledIfAlphaClippingSupported,
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			DisabledIfAlphaClippingSupported
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		[SerializeField]
		private Behavior behavior;

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x81B4330", Offset = "0x81B3730", VA = "0x1881B4330", Slot = "9")]
		protected override bool NWHKHBTKCKV(IRecRoomQualityConfigProvider a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x81B4310", Offset = "0x81B3710", VA = "0x1881B4310", Slot = "7")]
		protected override bool MOLSDPJKVSO(bool a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x81B4380", Offset = "0x81B3780", VA = "0x1881B4380")]
		public SetActiveBasedOnAlphaClippingSupport()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class SetActiveBasedOnClothSimulationEnabled : QualityBasedActivationController<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x2000029")]
		private enum Behavior
		{
			[Cpp2IlInjected.Token(Token = "0x40000AD")]
			EnabledIfClothSimulationEnabled,
			[Cpp2IlInjected.Token(Token = "0x40000AE")]
			DisabledIfClothSimulationEnabled
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		[SerializeField]
		private Behavior behavior;

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x81B43C0", Offset = "0x81B37C0", VA = "0x1881B43C0", Slot = "9")]
		protected override bool NWHKHBTKCKV(IRecRoomQualityConfigProvider a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x81B4310", Offset = "0x81B3710", VA = "0x1881B4310", Slot = "7")]
		protected override bool MOLSDPJKVSO(bool a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x81B4410", Offset = "0x81B3810", VA = "0x1881B4410")]
		public SetActiveBasedOnClothSimulationEnabled()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public class SetActiveBasedOnDepthSamplingSupport : QualityBasedActivationController<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x200002B")]
		private enum Behavior
		{
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			EnabledIfDepthSamplingSupported,
			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			DisabledIfDepthSamplingSupported
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		[SerializeField]
		private Behavior behavior;

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x81B4450", Offset = "0x81B3850", VA = "0x1881B4450", Slot = "9")]
		protected override bool NWHKHBTKCKV(IRecRoomQualityConfigProvider a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x81B4310", Offset = "0x81B3710", VA = "0x1881B4310", Slot = "7")]
		protected override bool MOLSDPJKVSO(bool a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x81B44A0", Offset = "0x81B38A0", VA = "0x1881B44A0")]
		public SetActiveBasedOnDepthSamplingSupport()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public class SetActiveBasedOnLightingType : QualityBasedActivationController<LightRenderingMode>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		[SerializeField]
		private LightRenderingMode enabledForLightingType;

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x81B44F0", Offset = "0x81B38F0", VA = "0x1881B44F0", Slot = "9")]
		protected override LightRenderingMode NWHKHBTKCKV(IRecRoomQualityConfigProvider a)
		{
			return default(LightRenderingMode);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x81B44E0", Offset = "0x81B38E0", VA = "0x1881B44E0", Slot = "7")]
		protected override bool MOLSDPJKVSO(LightRenderingMode a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x81B4550", Offset = "0x81B3950", VA = "0x1881B4550")]
		public SetActiveBasedOnLightingType()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public class SetActiveBasedOnSceneDecorationDetailLevel : QualityBasedActivationController<SceneDecorationDetailLevel>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		[SerializeField]
		private SceneDecorationDetailLevel sceneDecorationDetail;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		[SerializeField]
		private bool activeBelowThreshold;

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x81B45B0", Offset = "0x81B39B0", VA = "0x1881B45B0", Slot = "9")]
		protected override SceneDecorationDetailLevel NWHKHBTKCKV(IRecRoomQualityConfigProvider a)
		{
			return default(SceneDecorationDetailLevel);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x81B4590", Offset = "0x81B3990", VA = "0x1881B4590", Slot = "7")]
		protected override bool MOLSDPJKVSO(SceneDecorationDetailLevel a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x81B4600", Offset = "0x81B3A00", VA = "0x1881B4600")]
		public SetActiveBasedOnSceneDecorationDetailLevel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public class SetActiveBasedOnTransparencyDetailLevel : QualityBasedActivationController<TransparencyDetailLevel>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		[SerializeField]
		private TransparencyDetailLevel transparencyDetailThreshold;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		[SerializeField]
		private bool activeBelowThreshold;

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x81B4660", Offset = "0x81B3A60", VA = "0x1881B4660", Slot = "9")]
		protected override TransparencyDetailLevel NWHKHBTKCKV(IRecRoomQualityConfigProvider a)
		{
			return default(TransparencyDetailLevel);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x81B4640", Offset = "0x81B3A40", VA = "0x1881B4640", Slot = "7")]
		protected override bool MOLSDPJKVSO(TransparencyDetailLevel a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x81B46B0", Offset = "0x81B3AB0", VA = "0x1881B46B0")]
		public SetActiveBasedOnTransparencyDetailLevel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public class SetComponentsActiveBasedOnBackgroundAnimationDetailLevel : ActivationController<BackgroundAnimationDetailLevel>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public BackgroundAnimationDetailLevel MinimumSupportedDetail;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public Behaviour[] components;

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x81B4820", Offset = "0x81B3C20", VA = "0x1881B4820", Slot = "7")]
		protected override bool MOLSDPJKVSO(BackgroundAnimationDetailLevel a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x81B47A0", Offset = "0x81B3BA0", VA = "0x1881B47A0", Slot = "8")]
		protected override void HAROVKPPMTY(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x81B46F0", Offset = "0x81B3AF0", VA = "0x1881B46F0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x81B48B0", Offset = "0x81B3CB0", VA = "0x1881B48B0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x81B4960", Offset = "0x81B3D60", VA = "0x1881B4960")]
		public SetComponentsActiveBasedOnBackgroundAnimationDetailLevel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[RequireComponent(typeof(Terrain))]
	public class TerrainQualitySettings : ActivationController<TerrainQualityLevel>
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		public class Settings
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public TerrainQualityLevel TerrainQualitySetting;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public float PixelError;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			public float DetailDistance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			[Range(0f, 1f)]
			public float DetailDensity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			public TreePrefabOverride[] TreePrefabOverrides;

			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public Settings()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000032")]
		public struct TreePrefabOverride
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			public GameObject DefaultTree;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			public GameObject OverrideTree;
		}

		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private static Dictionary<TerrainQualityLevel, Settings> WUOPCODQKZW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public float DefaultPixelError;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public float DefaultDetailDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public float DefaultDetailDensity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public Settings[] QualitySettingOverrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private Terrain JAPWGFAZKEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private IRecRoomQualityConfigProvider QONKBCXPWMY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private XHPBROBAIBI EBHTBUOOZQR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private TerrainData GWRARLAVUMU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		private TerrainData CWHTKGCIYRF;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		private Terrain QIOEBPVOIJV
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x81B4C70", Offset = "0x81B4070", VA = "0x1881B4C70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x81B4D00", Offset = "0x81B4100", VA = "0x1881B4D00")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x81B4F60", Offset = "0x81B4360", VA = "0x1881B4F60")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x81B4EA0", Offset = "0x81B42A0", VA = "0x1881B4EA0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x81B4E90", Offset = "0x81B4290", VA = "0x1881B4E90")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x81B4E30", Offset = "0x81B4230", VA = "0x1881B4E30")]
		private void GBUVYCFGOKG(RecRoomQualitySetting a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x81B5380", Offset = "0x81B4780", VA = "0x1881B5380", Slot = "6")]
		public override void SetActivation(TerrainQualityLevel currentQualitySetting)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0xABEDC0", Offset = "0xABE1C0", VA = "0x180ABEDC0", Slot = "7")]
		protected override bool MOLSDPJKVSO(TerrainQualityLevel a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "8")]
		protected override void HAROVKPPMTY(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x81B5520", Offset = "0x81B4920", VA = "0x1881B5520")]
		private void TKMQYRHELIH(Settings a, TerrainQualityLevel b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x81B50F0", Offset = "0x81B44F0", VA = "0x1881B50F0")]
		private void RQCCSIBFKGV(TreePrefabOverride[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x81B5720", Offset = "0x81B4B20", VA = "0x1881B5720")]
		private void WMKJWOZGEPX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x81B5070", Offset = "0x81B4470", VA = "0x1881B5070")]
		private Settings RJWLCXKPUIS()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x81B5990", Offset = "0x81B4D90", VA = "0x1881B5990")]
		public TerrainQualitySettings()
		{
		}
	}
}
namespace RecRoom.Core.Locomotion
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public enum RoomScaleCollisionType
	{
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		DISABLED,
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		HEAD_ONLY,
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		HEAD_AND_BODY
	}
}
namespace RecRoom.Core.Creation
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public interface CYCCEEGNHOX
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void TrySetDefaultRGBColor(Color color);
	}
}
namespace RecRoom.Core.Creation.SceneMoods
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public class BackgroundObject : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public MeshRenderer[] coloredRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public bool rotateWithSun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private List<Material> TRFKOIMCBME;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public BackgroundObject JZJNTNVKONC
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1C0", Offset = "0xAAA5C0", VA = "0x180AAB1C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0xAA67C0", Offset = "0xAA5BC0", VA = "0x180AA67C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x81AE4C0", Offset = "0x81AD8C0", VA = "0x1881AE4C0")]
		public void Init(BackgroundObject prefab)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x81AE710", Offset = "0x81ADB10", VA = "0x1881AE710")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x81AE830", Offset = "0x81ADC30", VA = "0x1881AE830")]
		public void SetBlendValue(float blendValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x81AE9A0", Offset = "0x81ADDA0", VA = "0x1881AE9A0")]
		public void SetColor(Color color)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x81AEAD0", Offset = "0x81ADED0", VA = "0x1881AEAD0")]
		public void SetRotation(float rotation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x81AECA0", Offset = "0x81AE0A0", VA = "0x1881AECA0")]
		public BackgroundObject()
		{
		}
	}
}
namespace RecRoom.Core.Platforms
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public abstract class ActivationController : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000037")]
		public enum OnSceneOrPrefabSaveBehaviorType
		{
			[Cpp2IlInjected.Token(Token = "0x40000D5")]
			DoNothing,
			[Cpp2IlInjected.Token(Token = "0x40000D6")]
			EnableIfAllowed,
			[Cpp2IlInjected.Token(Token = "0x40000D7")]
			EnableAlways
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		[SerializeField]
		[ConditionalField("OnSceneOrPrefabSaveBehavior", OnSceneOrPrefabSaveBehaviorType.EnableIfAllowed)]
		private bool allowSaveAsDisabled;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		protected virtual OnSceneOrPrefabSaveBehaviorType SPIBWBWEUNT
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0xAA4920", Offset = "0xAA3D20", VA = "0x180AA4920", Slot = "4")]
			get
			{
				return default(OnSceneOrPrefabSaveBehaviorType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0xAA4900", Offset = "0xAA3D00", VA = "0x180AA4900")]
		protected ActivationController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public abstract class ActivationController<T> : ActivationController where T : IConvertible
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		protected bool? EPJGLWWAICJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		protected T XDTRAYHDXLO;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool SYLZHPOSPNQ
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x56971A0", Offset = "0x56965A0", VA = "0x1856971A0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x5696C90", Offset = "0x5696090", VA = "0x185696C90", Slot = "6")]
		public virtual void SetActivation(T activationCriteria)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(Slot = "7")]
		protected abstract bool MOLSDPJKVSO(T a);

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "8")]
		protected abstract void HAROVKPPMTY(bool a);

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0xAC0960", Offset = "0xABFD60", VA = "0x180AC0960")]
		protected ActivationController()
		{
		}
	}
}
namespace RecRoom.CullableBatching
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[UnityEngine.Scripting.Preserve]
	public class CullableBatchLOD : MonoBehaviour, JUXEBJYBFAS
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200003A")]
		public class BatchedRenderer
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000E7")]
			public Renderer renderer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			public bool visibleInBatch;

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			public bool Enabled
			{
				[Cpp2IlInjected.Token(Token = "0x60000AC")]
				[Cpp2IlInjected.Address(RVA = "0x81AED20", Offset = "0x81AE120", VA = "0x1881AED20")]
				set
				{
				}
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public BatchedRenderer[] revealableRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public LODGroup[] revealableLodGroups;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public BatchedRenderer[] nonRevealableRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public LODGroup[] nonRevealableLodGroups;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		[SerializeField]
		public int subMeshCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		[SerializeField]
		public int startRenderableSubmshIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		[SerializeField]
		private UpdateLOD toggleBand;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private Bounds TMXFHPJGPVB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private Material OECLGOBUSBR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private FDHEFNSYZKU<CullableBatchLOD> ISWOYAUQWZP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private Mesh FQBRAHPLIZV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private bool ZXYUMWIRYWY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x81")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private bool QUTJKYPQGDM;

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x81AF330", Offset = "0x81AE730", VA = "0x1881AF330")]
		public void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x81AF760", Offset = "0x81AEB60", VA = "0x1881AF760")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x81AFA00", Offset = "0x81AEE00", VA = "0x1881AFA00")]
		private static float WCFFVZTIMAP(Vector3 a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x81AF2A0", Offset = "0x81AE6A0", VA = "0x1881AF2A0")]
		public void SetContentsVisibility(bool isRevealed)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x81AF1B0", Offset = "0x81AE5B0", VA = "0x1881AF1B0", Slot = "5")]
		public void OnChangedDistanceBand(UpdateLOD oldDistanceBand, UpdateLOD newDistanceBand)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0xAA4910", Offset = "0xAA3D10", VA = "0x180AA4910", Slot = "6")]
		public void OnChangedVisibility(bool isVisible)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x81AF1E0", Offset = "0x81AE5E0", VA = "0x1881AF1E0")]
		public void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x81AFA20", Offset = "0x81AEE20", VA = "0x1881AFA20")]
		public CullableBatchLOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0xACD3F0", Offset = "0xACC7F0", VA = "0x180ACD3F0", Slot = "4")]
		private Transform EDJHBQUDTGB()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[ExecuteInEditMode]
	[RecRoom.NoEngine.Common.Preserve]
	public class CullableBatchLODMaterialData : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public Vector4[] baseColors;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public Vector4[] specColors;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public Vector4[] emissionColors;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public Vector4[] halfProperties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public Vector4[] textureTransforms;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public Vector4[] secondaryTextureTransforms;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		[FormerlySerializedAs("renderer")]
		public MeshRenderer targetRenderer;

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0xAA4900", Offset = "0xAA3D00", VA = "0x180AA4900")]
		public CullableBatchLODMaterialData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[ExecuteInEditMode]
	[RecRoom.NoEngine.Common.Preserve]
	public class CullableBatchShaderManager : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x81AFA40", Offset = "0x81AEE40", VA = "0x1881AFA40")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0xAA4900", Offset = "0xAA3D00", VA = "0x180AA4900")]
		public CullableBatchShaderManager()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[RecRoom.NoEngine.Common.Preserve]
	[ExecuteInEditMode]
	public class RunTimeTextureAtlasData : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public Vector4[] textureTransforms;

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x81B42B0", Offset = "0x81B36B0", VA = "0x1881B42B0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x81B42B0", Offset = "0x81B36B0", VA = "0x1881B42B0")]
		private void PNTIZERKJZG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0xAA4900", Offset = "0xAA3D00", VA = "0x180AA4900")]
		public RunTimeTextureAtlasData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
[Unity.Jobs.DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__3357596788
{
	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x81B5DD0", Offset = "0x81B51D0", VA = "0x1881B5DD0")]
	public static void ZKRXGWNKWSY()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x81B5DC0", Offset = "0x81B51C0", VA = "0x1881B5DC0")]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
	public static void EarlyInit()
	{
	}
}
namespace Cpp2IlInjected
{
	internal class AddressAttribute : Attribute
	{
		public string RVA;

		public string Offset;

		public string VA;

		public string Slot;
	}
	internal class FieldOffsetAttribute : Attribute
	{
		public string Offset;
	}
	internal class AttributeAttribute : Attribute
	{
		public string Name;

		public string RVA;

		public string Offset;
	}
	internal class MetadataOffsetAttribute : Attribute
	{
		public string Offset;
	}
	internal class TokenAttribute : Attribute
	{
		public string Token;
	}
	internal class AnalysisFailedException : Exception
	{
		public AnalysisFailedException(string message)
			: base(message)
		{
		}
	}
}
