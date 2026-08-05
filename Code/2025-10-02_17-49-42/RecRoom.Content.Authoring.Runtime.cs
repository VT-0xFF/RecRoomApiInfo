using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.Core.Platforms;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.Logging.Attributes;
using RecRoom.NoEngine.Common;
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
	public enum GPJLOOLFPMP
	{
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		X,
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		Y,
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		Z
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	[SerializeField]
	private GPJLOOLFPMP bobAxis;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	[SerializeField]
	private float scaleBobAmount;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	[SerializeField]
	private float scaleBobSpeed;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	[SerializeField]
	private bool inWorldSpace;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private float AHPIODJAPAN;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private Vector3 OGFJPMLHNHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8414DA0", Offset = "0x84137A0", VA = "0x188414DA0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x8414D60", Offset = "0x8413760", VA = "0x188414D60")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x8414F90", Offset = "0x8413990", VA = "0x188414F90")]
	private void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x84151D0", Offset = "0x8413BD0", VA = "0x1884151D0")]
	public BobbingMotion()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class DisableDuringPlayback : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x16207E0", Offset = "0x161F1E0", VA = "0x1816207E0")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0xAAFC10", Offset = "0xAAE610", VA = "0x180AAFC10")]
	public DisableDuringPlayback()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class ImposterBehaviorMaterialAlpha : MonoBehaviour, ICCPABBNNCM
{
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private const string FEEHAEMHJNA = "_BaseColor";

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private const string OBEBKDHDKKI = "_MainColor";

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	[SerializeField]
	[Tooltip("List of Renderers to increase color alpha")]
	private List<Renderer> imposterRenderers;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[SerializeField]
	[Range(0f, 1f)]
	private float imposterAlpha;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static List<Material> HJONAGGLHPP;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static List<Material> ACGBANGANAM;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "4")]
	public void PrepareImposter(NJBJGAIKJEP PDCLAJMPOEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x84186F0", Offset = "0x84170F0", VA = "0x1884186F0")]
	public ImposterBehaviorMaterialAlpha()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[ExecuteInEditMode]
[UnityEngine.Scripting.Preserve]
public class InstancedMeshGroup : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	[FormerlySerializedAs("me")]
	public Mesh mesh;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	[FormerlySerializedAs("ma")]
	public Material material;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	[FormerlySerializedAs("trs")]
	public Matrix4x4[] MatricesTRS;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public Component[] componentsToHide;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x8418B50", Offset = "0x8417550", VA = "0x188418B50")]
	private void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x8418BF0", Offset = "0x84175F0", VA = "0x188418BF0")]
	public void initialize(Mesh KFMDIGDKNNB, Material NPMNFMAPBPG, Matrix4x4[] NINMAMDHDIA, Component[] NOLJNCKFLLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0xAAFC10", Offset = "0xAAE610", VA = "0x180AAFC10")]
	public InstancedMeshGroup()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[DefaultMember("Item")]
[NativeContainer]
public struct CCAEBALKLPG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public enum CMBPEMIDPKJ
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
	public struct ONDCBILINBO : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		[ReadOnly]
		public CCAEBALKLPG HONCCLOHNPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		[ReadOnly]
		public int DFHKGKGFNHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public KMJFAECNHMN KFDLDGPHBHH;

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8419E50", Offset = "0x8418850", VA = "0x188419E50", Slot = "4")]
		public void Execute()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private struct JDMBMMONOKL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public NativeSlice<Vector3> KHNGGHMDDHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public NativeSlice<Vector3> DOPNICCPBOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public NativeSlice<Vector4> KEIDKJECCPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public NativeSlice<Vector2> OAIMFEAFOFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public NativeSlice<Vector2> PGFIIPCFHEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public NativeSlice<Vector2> FONAINCBCCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public NativeSlice<Vector2> MGCEFHBFOAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public NativeSlice<Color> PMGDAAKKEGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public NativeSlice<BoneWeight> EECFNOMGELB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public NativeSlice<Matrix4x4> LILCKJNIDEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public NativeSlice<int> IHDDFPGEMHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public NativeSlice<int> PCGEDHHGAJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public NativeSlice<int> PMKKAIJBGMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public NativeSlice<int> MLNAPLJGBCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public NativeSlice<byte> HHGIBLLCMDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public int LJMHOJELONP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public Matrix4x4 EFGNJAODGMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public bool GODGFICPAMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public int NGOFMAICIHM;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public NativeArray<Vector3> KHNGGHMDDHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public NativeArray<int> ELNLKEOKKMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public NativeArray<Vector3> DOPNICCPBOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public NativeArray<Vector4> KEIDKJECCPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public NativeArray<Vector2> OAIMFEAFOFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public NativeArray<Vector2> PGFIIPCFHEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public NativeArray<Vector2> FONAINCBCCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public NativeArray<Vector2> MGCEFHBFOAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public NativeArray<Color> PMGDAAKKEGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public NativeArray<BoneWeight> EECFNOMGELB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public NativeArray<int> MLNAPLJGBCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public NativeArray<int> NHHHOENDOAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private NativeArray<int> MGANDINAPJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private NativeArray<Matrix4x4> LILCKJNIDEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private NativeArray<int> BHAGKJFFAKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public NativeArray<int> IHDDFPGEMHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public NativeArray<int> LBABKBLOFKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private NativeArray<Matrix4x4> MAONPADOAMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private NativeArray<byte> MOCEOIIHKPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private NativeArray<int> GJFCDLDLDNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private NativeArray<int> FHNJEIAJBGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private NativeArray<int> EOELDEHJDLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public NativeArray<sbyte> MIHBEINGOAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public NativeArray<int> JDNCBNBDEFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public NativeArray<int> IKAKCAIBJAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public NativeArray<byte> ACNJFOLIOEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private NativeArray<int> BNJPBJILKDN;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int JEKFFOMLIKC
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8415BD0", Offset = "0x84145D0", VA = "0x188415BD0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8415BE0", Offset = "0x84145E0", VA = "0x188415BE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int GKKHECINGBD
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8415BA0", Offset = "0x84145A0", VA = "0x188415BA0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x84151E0", Offset = "0x8413BE0", VA = "0x1884151E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int NEGEBCIBDMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x84155B0", Offset = "0x8413FB0", VA = "0x1884155B0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8415BC0", Offset = "0x84145C0", VA = "0x188415BC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public CMBPEMIDPKJ PLIGKHPBMDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8415BB0", Offset = "0x84145B0", VA = "0x188415BB0")]
		get
		{
			return default(CMBPEMIDPKJ);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x84151F0", Offset = "0x8413BF0", VA = "0x1884151F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private JDMBMMONOKL PCCJLFHFGOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x84155C0", Offset = "0x8413FC0", VA = "0x1884155C0")]
		get
		{
			return default(JDMBMMONOKL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x8415BF0", Offset = "0x84145F0", VA = "0x188415BF0")]
	public CCAEBALKLPG(IList<Mesh> LLJGIONICIL, IList<int> NEBBNDFPCDI, IList<int> OBLFKHKFEFA, IList<int[]> FJIPPNFJCPB, IList<Matrix4x4> NCOMDPKDFCB, IList<bool> MFBKBIBKKBL, IList<int> JLFNLPNBIEB, Allocator EIOOMONCLID, CMBPEMIDPKJ PHEKDHCLLIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x8415200", Offset = "0x8413C00", VA = "0x188415200")]
	public KMJFAECNHMN CPPDOMEFIBA(int IAAOEOBBFNF, Allocator EIOOMONCLID)
	{
		return default(KMJFAECNHMN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x8415330", Offset = "0x8413D30", VA = "0x188415330", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[NativeContainer]
public struct KMJFAECNHMN : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public NativeArray<Vector3> KHNGGHMDDHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public NativeArray<Vector3> DOPNICCPBOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public NativeArray<Vector4> KEIDKJECCPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public NativeArray<Vector2> OAIMFEAFOFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public NativeArray<Vector2> PGFIIPCFHEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public NativeArray<Vector2> FONAINCBCCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public NativeArray<Vector2> MGCEFHBFOAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public NativeArray<Color> PMGDAAKKEGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public NativeArray<BoneWeight> EECFNOMGELB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public NativeArray<Matrix4x4> LILCKJNIDEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public NativeArray<int> IHDDFPGEMHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private NativeArray<int> PCGEDHHGAJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private NativeArray<int> PMKKAIJBGMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private NativeArray<int> BNJPBJILKDN;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int IPGENHHGOEO
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8419240", Offset = "0x8417C40", VA = "0x188419240")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x8418D60", Offset = "0x8417760", VA = "0x188418D60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x84193B0", Offset = "0x8417DB0", VA = "0x1884193B0")]
	public KMJFAECNHMN(int EHCMPHBOHMC, int COCDKCIIDED, int HPAPCCFJNDA, int IAAOEOBBFNF, Allocator EIOOMONCLID, bool[] NFHCDHBALNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x84192E0", Offset = "0x8417CE0", VA = "0x1884192E0")]
	public void JMKFOPJAENK(int IPMHCEACDJA, int JBCPGNDLJHB, int AJDEGEPLAEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x8419190", Offset = "0x8417B90", VA = "0x188419190")]
	public int[] EILKEMJNEPH(int IPMHCEACDJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x8419250", Offset = "0x8417C50", VA = "0x188419250")]
	private NativeSlice<int> JKENAJIDKGA(int IPMHCEACDJA)
	{
		return default(NativeSlice<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x8419020", Offset = "0x8417A20", VA = "0x188419020", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x8418D70", Offset = "0x8417770", VA = "0x188418D70")]
	public Mesh CGBJLGFAJJM([Optional] string ABJJBLBNHAL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class APBBEENGCIP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private List<Mesh> PDECOBINNMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private List<int> FOFKIPOKMAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private List<bool> JJKMNENMAHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private List<int[]> GJADIDOIIBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private List<Matrix4x4> NPEOFHIIGJK;

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x84140B0", Offset = "0x8412AB0", VA = "0x1884140B0")]
	public void ODAIGGCAFEJ(Mesh KGGOMLADPBD, int[] CIPHJFJACJO, Matrix4x4 ONMPCJHMCMI, bool MFBKBIBKKBL = false, int JCILFKFDKDO = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x8414000", Offset = "0x8412A00", VA = "0x188414000")]
	public CCAEBALKLPG LMDAOJECCPH(Allocator EIOOMONCLID, CCAEBALKLPG.CMBPEMIDPKJ PHEKDHCLLIA, [Optional] IList<int> OBLFKHKFEFA, [Optional] IList<int> PPNDDAAAJCN)
	{
		return default(CCAEBALKLPG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x8413DA0", Offset = "0x84127A0", VA = "0x188413DA0")]
	private static void EBBPELIEOJM(Mesh KGGOMLADPBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x8414300", Offset = "0x8412D00", VA = "0x188414300")]
	public APBBEENGCIP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[RequireComponent(typeof(ParticleSystem))]
[DisallowMultipleComponent]
public class ParticleSystemTextureStreamerTag : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private static readonly OLFEOKKCIEG JHGFKLHHPJD;

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x841C4C0", Offset = "0x841AEC0", VA = "0x18841C4C0")]
	private void Start()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x841C420", Offset = "0x841AE20", VA = "0x18841C420")]
	private void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x841C260", Offset = "0x841AC60", VA = "0x18841C260")]
	private bool OEFDLCCFFFO([Out] LCCONECPPLI KFMMGFEJHFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0xAAFC10", Offset = "0xAAE610", VA = "0x180AAFC10")]
	public ParticleSystemTextureStreamerTag()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class PlayerHandWorldCollisionConfig : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0xAAFC10", Offset = "0xAAE610", VA = "0x180AAFC10")]
	public PlayerHandWorldCollisionConfig()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class PlayerWorldCollisionConfig : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	[SerializeField]
	private OCOHDBLPEKJ playerCollisionType;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public OCOHDBLPEKJ JBPFPBBHLCN
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xAB3B20", Offset = "0xAB2520", VA = "0x180AB3B20")]
		get
		{
			return default(OCOHDBLPEKJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x77E4900", Offset = "0x77E3300", VA = "0x1877E4900")]
	public PlayerWorldCollisionConfig()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[Obsolete("Use the ScreenshotGeneratorWindow instead")]
[RequireComponent(typeof(Camera))]
public class ScreenshotGenerator : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public int Width;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public int Height;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public int AntiAliasLevel;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public bool UseAlpha;

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x841C620", Offset = "0x841B020", VA = "0x18841C620")]
	public ScreenshotGenerator()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class ShippingContainer : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	[SerializeField]
	public GameObject[] partRoots;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	[SerializeField]
	public MeshRenderer[] lodRenderers;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool DAAACNJGNAF
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x841CCD0", Offset = "0x841B6D0", VA = "0x18841CCD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0xAAFC10", Offset = "0xAAE610", VA = "0x180AAFC10")]
	public ShippingContainer()
	{
	}
}
namespace _LogRegistration.RecRoom_Content_Authoring_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : OPBNGIPOJLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x84197A0", Offset = "0x84181A0", VA = "0x1884197A0", Slot = "4")]
		public override void NFFNLBFBLBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0xAD77F0", Offset = "0xAD61F0", VA = "0x180AD77F0")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_Content_Authoring_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x841DEA0", Offset = "0x841C8A0", VA = "0x18841DEA0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x29CDED0", Offset = "0x29CC8D0", VA = "0x1829CDED0")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public interface BBEHHOEJGCC
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	JKNBAKAELJG FGDJDHLKAEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	AHDLCNFLGGK<JKNBAKAELJG> PHBDEJFNMML
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public enum JKNBAKAELJG
{
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	Fastest,
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	Simple,
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	Ultra,
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	PS4VR,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	iOSHigh,
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	PS4Screens,
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	iOSLow,
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	XboxOne,
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	AndroidMobileLow,
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	AndroidMobileHigh,
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	PS5,
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	XboxSeries,
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	Pico,
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	Switch,
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	Count
}
namespace RecRoom.VFX
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[RequireComponent(typeof(Light))]
	[ExecuteInEditMode]
	public class ParticleScriptedLight : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		[SerializeField]
		private ParticleSystem targetSystem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		[SerializeField]
		private AnimationCurve intensityCurve;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private Light PELNGKIKCEH;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public Light DONNCAOLCOO
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x841C1D0", Offset = "0x841ABD0", VA = "0x18841C1D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x841C060", Offset = "0x841AA60", VA = "0x18841C060")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x841C180", Offset = "0x841AB80", VA = "0x18841C180")]
		public ParticleScriptedLight()
		{
		}
	}
}
namespace RecRoom.Utils.Mesh
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[ExecuteInEditMode]
	public class InstanceColor : MonoBehaviour, ICCPABBNNCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		[SerializeField]
		[HideInInspector]
		private Color color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		[IHBEENDFBCJ(EAHEBLGAGFP.SelfAndParent, false, false, false)]
		private BAMDHHAALFK MBCKKLALHNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public Renderer[] renderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		[SerializeField]
		private bool ignorePrepareImposterBehavior;

		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private static readonly int KKNKCADDNHL;

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8418780", Offset = "0x8417180", VA = "0x188418780")]
		private void BAEOBNAPOHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x84188C0", Offset = "0x84172C0", VA = "0x1884188C0")]
		private void PGEMGDFPNCP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8418A00", Offset = "0x8417400", VA = "0x188418A00")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8418990", Offset = "0x8417390", VA = "0x188418990", Slot = "4")]
		public void PrepareImposter(NJBJGAIKJEP PDCLAJMPOEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xAAFC10", Offset = "0xAAE610", VA = "0x180AAFC10")]
		public InstanceColor()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class MaterialInstance : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public Renderer[] renderers;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x8419830", Offset = "0x8418230", VA = "0x188419830")]
		public void ClearProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8419900", Offset = "0x8418300", VA = "0x188419900")]
		public void SetColor(string IELIBBNCJAC, Color KMAFNKGMDCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x8419A10", Offset = "0x8418410", VA = "0x188419A10")]
		public void SetFloat(string IELIBBNCJAC, float KMAFNKGMDCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x8419D40", Offset = "0x8418740", VA = "0x188419D40")]
		public void SetVector(string IELIBBNCJAC, Vector4 KMAFNKGMDCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x8419C10", Offset = "0x8418610", VA = "0x188419C10")]
		public void SetVector(string IELIBBNCJAC, float FKPKEFAKAOE, float KEEMKILMOML, float JLNCPHFMCKO, float LIPBKGAOLBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x8419B10", Offset = "0x8418510", VA = "0x188419B10")]
		public void SetTexture(string IELIBBNCJAC, Texture2D KMAFNKGMDCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xAAFC10", Offset = "0xAAE610", VA = "0x180AAFC10")]
		public MaterialInstance()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface LGOAJNHKECF
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int GetDesiredMipLevel();
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface LCCONECPPLI
{
	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OAGMHNDKDAP(LGOAJNHKECF FCKAJJKCEKN, Texture2D JBOOEIGKOID);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FEFGJHOHHDO(LGOAJNHKECF FCKAJJKCEKN, Texture2D JBOOEIGKOID);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void COIJJNJNAOJ(ParticleSystem LDKFOKHKBNA);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JPJIHBOPAAG(ParticleSystem LDKFOKHKBNA);
}
namespace RecRoom.Core
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public class ParticleEventListener : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		public delegate void IPLHJBOFPML(ParticleEventListener MBFPBKDOJPD, Collider GOCNHGEHNFD, IEnumerable<ParticleCollisionEvent> KPCGAMGLCEM);

		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private static readonly List<ParticleCollisionEvent> BFIPHBEEBCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		[IHBEENDFBCJ(EAHEBLGAGFP.Self, false, false, false)]
		[SerializeField]
		private ParticleSystem particles;

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event IPLHJBOFPML FNCEEOIMANC
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x841AF10", Offset = "0x8419910", VA = "0x18841AF10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x841AFB0", Offset = "0x84199B0", VA = "0x18841AFB0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x841ABA0", Offset = "0x84195A0", VA = "0x18841ABA0")]
		private void OnParticleCollision(GameObject GOCNHGEHNFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xAAFC10", Offset = "0xAAE610", VA = "0x180AAFC10")]
		public ParticleEventListener()
		{
		}
	}
}
namespace RecRoom.Core.StaticBatching
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class StaticBatch : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public Component[] SourceObjects;

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0xAAFC10", Offset = "0xAAE610", VA = "0x180AAFC10")]
		public StaticBatch()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class StaticBatchManager : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public bool UseSpacePartition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		[FFBOEEGEIOD("UseSpacePartition")]
		public float SpacePartitionCubeSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public bool ForceLOD0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public bool OnlyBatchProBuilderMeshes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x22")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public bool SplitOriginalSubmeshes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x23")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public bool StripToJustUV0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		[Tooltip("If true, the StaticBatcher will not generate batches that only contain 1 Renderer. Disabling this can be useful for debugging why certain objects cannot batch. This setting does not affect LOD groups: batches of 1 LOD group are never created.")]
		public bool RemoveBatchesOfOneRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		[HideInInspector]
		public List<MeshRenderer> originalAssets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		[HideInInspector]
		public List<LODGroup> originalLodGroups;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		[HideInInspector]
		public List<GameObject> staticBatches;

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x841CDF0", Offset = "0x841B7F0", VA = "0x18841CDF0")]
		public StaticBatchManager()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class StaticBatchMeshData : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		[HideInInspector]
		public List<Mesh> SubMeshes;

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x841CE10", Offset = "0x841B810", VA = "0x18841CE10")]
		public bool PMNIBHGJNBG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x841CF40", Offset = "0x841B940", VA = "0x18841CF40")]
		public StaticBatchMeshData()
		{
		}
	}
}
namespace RecRoom.Core.Quality
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public class DisableMeshShadowsForQualitySetting : ActivationController<bool>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		[SerializeField]
		private Renderer[] AffectedRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private bool OMJJKOOLPIH;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		protected override OGJPOLNCBLM HKMFNLPCEGF
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0xC56A80", Offset = "0xC55480", VA = "0x180C56A80", Slot = "4")]
			get
			{
				return default(OGJPOLNCBLM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x8418210", Offset = "0x8416C10", VA = "0x188418210")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x84182D0", Offset = "0x8416CD0", VA = "0x1884182D0")]
		private void NMGMBNNFAKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x8418590", Offset = "0x8416F90", VA = "0x188418590")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x8418470", Offset = "0x8416E70", VA = "0x188418470")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x8418220", Offset = "0x8416C20", VA = "0x188418220")]
		private void GOFCLFIOAIH(JKNBAKAELJG EABPLBKIBKG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x20F8150", Offset = "0x20F6B50", VA = "0x1820F8150", Slot = "7")]
		protected override bool JJMGHHDNHJB(bool JKIEJMBMIOK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x84181A0", Offset = "0x8416BA0", VA = "0x1884181A0", Slot = "8")]
		protected override void APLILBNLFPJ(bool BNKFAODIANJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x84185C0", Offset = "0x8416FC0", VA = "0x1884185C0")]
		public DisableMeshShadowsForQualitySetting()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public class ParticleQualityOverride : MonoBehaviour
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000024")]
		public struct OverrideSettings
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			public ParticleQualityLevel particleQuality;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			public int maxParticles;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			public bool enableTrails;

			[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			public bool enableCollisions;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			public bool overrideEmissionRate;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			[Range(0f, 1f)]
			public float emissionRateMultiplier;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			public bool overrideLifetime;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			[Range(0f, 2f)]
			public float lifetimeMultiplier;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		[IHBEENDFBCJ(EAHEBLGAGFP.Self, false, false, false)]
		[SerializeField]
		private ParticleSystem particles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		[SerializeField]
		private OverrideSettings[] overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private bool BGPIKJENLJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private int PLGHCMAKELK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private bool ICAEGBLGDAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private bool HPBCMPIHKJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private float HGOJBENBDAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private float DMJDJJCOBHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private float OPJAEPKFJGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private float CHBFPBFCEFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private float BIEELEJHAJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private float GNLFKKIDEHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private ParticleSystem.MainModule DFEEIBCGGHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private ParticleSystem.TrailModule PCJIDMNNFJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private ParticleSystem.EmissionModule LJPPLKPMMHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private ParticleSystem.CollisionModule POLMHLEMONJ;

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x841BEA0", Offset = "0x841A8A0", VA = "0x18841BEA0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x841BD90", Offset = "0x841A790", VA = "0x18841BD90")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x841B9C0", Offset = "0x841A3C0", VA = "0x18841B9C0")]
		private void GOFCLFIOAIH(JKNBAKAELJG EABPLBKIBKG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x841B050", Offset = "0x8419A50", VA = "0x18841B050")]
		private void BGGJGNLKJOC(IRecRoomQualityConfigProvider OINEAODAACF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x841BA40", Offset = "0x841A440", VA = "0x18841BA40")]
		private void MHIFFOOFKAE(OverrideSettings ABFPKLOIOEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x841B550", Offset = "0x8419F50", VA = "0x18841B550")]
		private void EKADNFEBDGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x841B820", Offset = "0x841A220", VA = "0x18841B820")]
		private void GOAEOOBKAEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x841B6F0", Offset = "0x841A0F0", VA = "0x18841B6F0")]
		private void FHOKEFNCHDP(ParticleSystem.MinMaxCurve PFJGKMEEDOH, [Out] float HAPOLLKMNMF, [Out] float MDDLFEPIHEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x841BC50", Offset = "0x841A650", VA = "0x18841BC50")]
		private ParticleSystem.MinMaxCurve OBKNMEDGCNE(ParticleSystem.MinMaxCurve PFJGKMEEDOH, float HAPOLLKMNMF, float MDDLFEPIHEF)
		{
			return default(ParticleSystem.MinMaxCurve);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xAAFC10", Offset = "0xAAE610", VA = "0x180AAFC10")]
		public ParticleQualityOverride()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public abstract class QualityBasedActivationController<T> : ActivationController<T> where T : IConvertible
	{
		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		protected override OGJPOLNCBLM HKMFNLPCEGF
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xC56A80", Offset = "0xC55480", VA = "0x180C56A80", Slot = "4")]
			get
			{
				return default(OGJPOLNCBLM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "9")]
		protected abstract T LMFCNDDMBEL(IRecRoomQualityConfigProvider HKAIOBBCBGO);

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x5D11180", Offset = "0x5D0FB80", VA = "0x185D11180")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x5D11860", Offset = "0x5D10260", VA = "0x185D11860")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x5D11720", Offset = "0x5D10120", VA = "0x185D11720")]
		private void GOFCLFIOAIH(JKNBAKAELJG EABPLBKIBKG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x5D11540", Offset = "0x5D0FF40", VA = "0x185D11540")]
		private void CNIOOEGMKLL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x5D11140", Offset = "0x5D0FB40", VA = "0x185D11140", Slot = "8")]
		protected override void APLILBNLFPJ(bool BNKFAODIANJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x4AE4D30", Offset = "0x4AE3730", VA = "0x184AE4D30")]
		protected QualityBasedActivationController()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal static class AGPHMGIOIDE
{
	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x8413CB0", Offset = "0x84126B0", VA = "0x188413CB0")]
	[DMKNBLIJJON.EGFDFBOLNDK]
	internal static void CCKCOACOBKL(JBJKIIKOACK KLIEGJHNGPK)
	{
	}
}
namespace RecRoom.Core.Quality
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class SetActiveBasedOnAlphaClippingSupport : QualityBasedActivationController<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		private enum NKOBIGIBHIL
		{
			[Cpp2IlInjected.Token(Token = "0x40000AE")]
			EnabledIfAlphaClippingSupported,
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			DisabledIfAlphaClippingSupported
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		[SerializeField]
		private NKOBIGIBHIL behavior;

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x841C660", Offset = "0x841B060", VA = "0x18841C660", Slot = "9")]
		protected override bool LMFCNDDMBEL(IRecRoomQualityConfigProvider HKAIOBBCBGO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x841C640", Offset = "0x841B040", VA = "0x18841C640", Slot = "7")]
		protected override bool JJMGHHDNHJB(bool JKIEJMBMIOK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x841C6B0", Offset = "0x841B0B0", VA = "0x18841C6B0")]
		public SetActiveBasedOnAlphaClippingSupport()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public class SetActiveBasedOnClothSimulationEnabled : QualityBasedActivationController<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x200002A")]
		private enum EKIMFKBOOKK
		{
			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			EnabledIfClothSimulationEnabled,
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			DisabledIfClothSimulationEnabled
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		[SerializeField]
		private EKIMFKBOOKK behavior;

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x841C6F0", Offset = "0x841B0F0", VA = "0x18841C6F0", Slot = "9")]
		protected override bool LMFCNDDMBEL(IRecRoomQualityConfigProvider HKAIOBBCBGO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x841C640", Offset = "0x841B040", VA = "0x18841C640", Slot = "7")]
		protected override bool JJMGHHDNHJB(bool JKIEJMBMIOK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x841C740", Offset = "0x841B140", VA = "0x18841C740")]
		public SetActiveBasedOnClothSimulationEnabled()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public class SetActiveBasedOnDepthSamplingSupport : QualityBasedActivationController<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x200002C")]
		private enum KGAOCIOBBDB
		{
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			EnabledIfDepthSamplingSupported,
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			DisabledIfDepthSamplingSupported
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		[SerializeField]
		private KGAOCIOBBDB behavior;

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x841C780", Offset = "0x841B180", VA = "0x18841C780", Slot = "9")]
		protected override bool LMFCNDDMBEL(IRecRoomQualityConfigProvider HKAIOBBCBGO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x841C640", Offset = "0x841B040", VA = "0x18841C640", Slot = "7")]
		protected override bool JJMGHHDNHJB(bool JKIEJMBMIOK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x841C7D0", Offset = "0x841B1D0", VA = "0x18841C7D0")]
		public SetActiveBasedOnDepthSamplingSupport()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public class SetActiveBasedOnLightingType : QualityBasedActivationController<LightRenderingMode>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		[SerializeField]
		private LightRenderingMode enabledForLightingType;

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x841C820", Offset = "0x841B220", VA = "0x18841C820", Slot = "9")]
		protected override LightRenderingMode LMFCNDDMBEL(IRecRoomQualityConfigProvider HKAIOBBCBGO)
		{
			return default(LightRenderingMode);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x841C810", Offset = "0x841B210", VA = "0x18841C810", Slot = "7")]
		protected override bool JJMGHHDNHJB(LightRenderingMode JKIEJMBMIOK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x841C880", Offset = "0x841B280", VA = "0x18841C880")]
		public SetActiveBasedOnLightingType()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public class SetActiveBasedOnSceneDecorationDetailLevel : QualityBasedActivationController<SceneDecorationDetailLevel>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		[SerializeField]
		private SceneDecorationDetailLevel sceneDecorationDetail;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		[SerializeField]
		private bool activeBelowThreshold;

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x841C8E0", Offset = "0x841B2E0", VA = "0x18841C8E0", Slot = "9")]
		protected override SceneDecorationDetailLevel LMFCNDDMBEL(IRecRoomQualityConfigProvider HKAIOBBCBGO)
		{
			return default(SceneDecorationDetailLevel);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x841C8C0", Offset = "0x841B2C0", VA = "0x18841C8C0", Slot = "7")]
		protected override bool JJMGHHDNHJB(SceneDecorationDetailLevel JKIEJMBMIOK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x841C930", Offset = "0x841B330", VA = "0x18841C930")]
		public SetActiveBasedOnSceneDecorationDetailLevel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public class SetActiveBasedOnTransparencyDetailLevel : QualityBasedActivationController<TransparencyDetailLevel>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		[SerializeField]
		private TransparencyDetailLevel transparencyDetailThreshold;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		[SerializeField]
		private bool activeBelowThreshold;

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x841C990", Offset = "0x841B390", VA = "0x18841C990", Slot = "9")]
		protected override TransparencyDetailLevel LMFCNDDMBEL(IRecRoomQualityConfigProvider HKAIOBBCBGO)
		{
			return default(TransparencyDetailLevel);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x841C970", Offset = "0x841B370", VA = "0x18841C970", Slot = "7")]
		protected override bool JJMGHHDNHJB(TransparencyDetailLevel JKIEJMBMIOK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x841C9E0", Offset = "0x841B3E0", VA = "0x18841C9E0")]
		public SetActiveBasedOnTransparencyDetailLevel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public class SetComponentsActiveBasedOnBackgroundAnimationDetailLevel : ActivationController<BackgroundAnimationDetailLevel>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public BackgroundAnimationDetailLevel MinimumSupportedDetail;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public Behaviour[] components;

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x841CB50", Offset = "0x841B550", VA = "0x18841CB50", Slot = "7")]
		protected override bool JJMGHHDNHJB(BackgroundAnimationDetailLevel KKLHEBHPJBA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x841CA20", Offset = "0x841B420", VA = "0x18841CA20", Slot = "8")]
		protected override void APLILBNLFPJ(bool JNNEMJKMKNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x841CAA0", Offset = "0x841B4A0", VA = "0x18841CAA0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x841CBE0", Offset = "0x841B5E0", VA = "0x18841CBE0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x841CC90", Offset = "0x841B690", VA = "0x18841CC90")]
		public SetComponentsActiveBasedOnBackgroundAnimationDetailLevel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[RequireComponent(typeof(Terrain))]
	public class TerrainQualitySettings : ActivationController<TerrainQualityLevel>
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000032")]
		public class Settings
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			public TerrainQualityLevel TerrainQualitySetting;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			public float PixelError;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			public float DetailDistance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			[Range(0f, 1f)]
			public float DetailDensity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000CD")]
			public TreePrefabOverride[] TreePrefabOverrides;

			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
			public Settings()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		public struct TreePrefabOverride
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CE")]
			public GameObject DefaultTree;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			public GameObject OverrideTree;
		}

		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private static Dictionary<TerrainQualityLevel, Settings> NIBLAHKPOCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public float DefaultPixelError;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public float DefaultDetailDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public float DefaultDetailDensity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public Settings[] QualitySettingOverrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		private Terrain FKCHPGFIPCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private IRecRoomQualityConfigProvider PNMEGMOJIJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private BBEHHOEJGCC NELGJCLIBCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private TerrainData NEMJBCCFIEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private TerrainData AJMPFHDBEOC;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private Terrain MGMBKEFCLGM
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x841D6D0", Offset = "0x841C0D0", VA = "0x18841D6D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x841CFD0", Offset = "0x841B9D0", VA = "0x18841CFD0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x841D8C0", Offset = "0x841C2C0", VA = "0x18841D8C0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x841D7F0", Offset = "0x841C1F0", VA = "0x18841D7F0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x841D7E0", Offset = "0x841C1E0", VA = "0x18841D7E0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x841D460", Offset = "0x841BE60", VA = "0x18841D460")]
		private void IMGPIJGLKBN(JKNBAKAELJG EABPLBKIBKG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x841D9D0", Offset = "0x841C3D0", VA = "0x18841D9D0", Slot = "6")]
		public override void SetActivation(TerrainQualityLevel LHEFPJOJGIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0xAC8240", Offset = "0xAC6C40", VA = "0x180AC8240", Slot = "7")]
		protected override bool JJMGHHDNHJB(TerrainQualityLevel KKLHEBHPJBA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "8")]
		protected override void APLILBNLFPJ(bool BNKFAODIANJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x841D4C0", Offset = "0x841BEC0", VA = "0x18841D4C0")]
		private void KNNEDPFBBMA(Settings ANGOOFAAJMM, TerrainQualityLevel LHEFPJOJGIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x841D1D0", Offset = "0x841BBD0", VA = "0x18841D1D0")]
		private void HEKKGMLNGKI(TreePrefabOverride[] HPLKMKGBKPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x841D100", Offset = "0x841BB00", VA = "0x18841D100")]
		private void BFDJLHAIKCI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x841D760", Offset = "0x841C160", VA = "0x18841D760")]
		private Settings MGMIIACPLLH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x841DD00", Offset = "0x841C700", VA = "0x18841DD00")]
		public TerrainQualitySettings()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public enum OCOHDBLPEKJ
{
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	DISABLED,
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	HEAD_ONLY,
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	HEAD_AND_BODY
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface BAMDHHAALFK
{
	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void TrySetDefaultRGBColor(Color EOGEFFOIIOP);
}
namespace RecRoom.Core.Creation.SceneMoods
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public class BackgroundObject : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public MeshRenderer[] coloredRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public bool rotateWithSun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private List<Material> PCAFIIJABAB;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public BackgroundObject LDLLHDKCOFG
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0xAAE180", Offset = "0xAACB80", VA = "0x180AAE180")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x84144C0", Offset = "0x8412EC0", VA = "0x1884144C0")]
		public void Init(BackgroundObject IGAKMAMDNNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x8414710", Offset = "0x8413110", VA = "0x188414710")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x8414830", Offset = "0x8413230", VA = "0x188414830")]
		public void SetBlendValue(float EDNNNOBIPNE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x84149A0", Offset = "0x84133A0", VA = "0x1884149A0")]
		public void SetColor(Color EOGEFFOIIOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x8414AD0", Offset = "0x84134D0", VA = "0x188414AD0")]
		public void SetRotation(float AMHDLJKDJBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x8414CA0", Offset = "0x84136A0", VA = "0x188414CA0")]
		public BackgroundObject()
		{
		}
	}
}
namespace RecRoom.Core.Platforms
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public abstract class ActivationController : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000038")]
		public enum OGJPOLNCBLM
		{
			[Cpp2IlInjected.Token(Token = "0x40000DA")]
			DoNothing,
			[Cpp2IlInjected.Token(Token = "0x40000DB")]
			EnableIfAllowed,
			[Cpp2IlInjected.Token(Token = "0x40000DC")]
			EnableAlways
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		[SerializeField]
		[FFBOEEGEIOD("OnSceneOrPrefabSaveBehavior", OGJPOLNCBLM.EnableIfAllowed)]
		private bool allowSaveAsDisabled;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		protected virtual OGJPOLNCBLM HKMFNLPCEGF
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0xAAD570", Offset = "0xAABF70", VA = "0x180AAD570", Slot = "4")]
			get
			{
				return default(OGJPOLNCBLM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0xAAFC10", Offset = "0xAAE610", VA = "0x180AAFC10")]
		protected ActivationController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public abstract class ActivationController<T> : ActivationController where T : IConvertible
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		protected bool? MAGIOKNOGHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		protected T EGAFBFNLDHK;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool APGOPGJOAIK
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x5752680", Offset = "0x5751080", VA = "0x185752680", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x5752310", Offset = "0x5750D10", VA = "0x185752310", Slot = "6")]
		public virtual void SetActivation(T KKLHEBHPJBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(Slot = "7")]
		protected abstract bool JJMGHHDNHJB(T KKLHEBHPJBA);

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(Slot = "8")]
		protected abstract void APLILBNLFPJ(bool BNKFAODIANJ);

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0xAC9DF0", Offset = "0xAC87F0", VA = "0x180AC9DF0")]
		protected ActivationController()
		{
		}
	}
}
namespace RecRoom.CullableBatching
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[UnityEngine.Scripting.Preserve]
	public class CullableBatchLOD : MonoBehaviour, MFMLODIOEBD
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200003B")]
		public class BatchedRenderer
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000EC")]
			public Renderer renderer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000ED")]
			public bool visibleInBatch;

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			public bool Enabled
			{
				[Cpp2IlInjected.Token(Token = "0x60000BA")]
				[Cpp2IlInjected.Address(RVA = "0x8414D30", Offset = "0x8413730", VA = "0x188414D30")]
				set
				{
				}
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public BatchedRenderer[] revealableRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public LODGroup[] revealableLodGroups;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public BatchedRenderer[] nonRevealableRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public LODGroup[] nonRevealableLodGroups;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		[SerializeField]
		public int subMeshCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		[SerializeField]
		public int startRenderableSubmshIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		[SerializeField]
		private ACOJACDAJIP toggleBand;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private Bounds KAKALMLAPHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private Material PJPBFBIEGMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		private JPLAFIDIIOO<CullableBatchLOD> CAEHNKCPHDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		private Mesh KGGOMLADPBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		private bool PIJKAANMPFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		private bool CEHGICBFJKH;

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x8417670", Offset = "0x8416070", VA = "0x188417670")]
		public void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x8417AE0", Offset = "0x84164E0", VA = "0x188417AE0")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x84174D0", Offset = "0x8415ED0", VA = "0x1884174D0")]
		private static float EGAOMJINCMA(Vector3 JNGAOHODOLH)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x84175E0", Offset = "0x8415FE0", VA = "0x1884175E0")]
		public void SetContentsVisibility(bool CHBOIDADBNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x84174F0", Offset = "0x8415EF0", VA = "0x1884174F0", Slot = "5")]
		public void OnChangedDistanceBand(ACOJACDAJIP KBLNLHCDNNB, ACOJACDAJIP GHJCHGJCFJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "6")]
		public void OnChangedVisibility(bool JCIGGBOEPEM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x8417520", Offset = "0x8415F20", VA = "0x188417520")]
		public void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x8417D70", Offset = "0x8416770", VA = "0x188417D70")]
		public CullableBatchLOD()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0xAD6730", Offset = "0xAD5130", VA = "0x180AD6730", Slot = "4")]
		private Transform INFEMIIPFBB()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[ExecuteInEditMode]
	[RecRoom.NoEngine.Common.Preserve]
	public class CullableBatchLODMaterialData : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public Vector4[] baseColors;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public Vector4[] specColors;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public Vector4[] emissionColors;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public Vector4[] halfProperties;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public Vector4[] textureTransforms;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public Vector4[] secondaryTextureTransforms;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		[FormerlySerializedAs("renderer")]
		public MeshRenderer targetRenderer;

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0xAAFC10", Offset = "0xAAE610", VA = "0x180AAFC10")]
		public CullableBatchLODMaterialData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[ExecuteInEditMode]
	[RecRoom.NoEngine.Common.Preserve]
	public class CullableBatchShaderManager : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x8417D90", Offset = "0x8416790", VA = "0x188417D90")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0xAAFC10", Offset = "0xAAE610", VA = "0x180AAFC10")]
		public CullableBatchShaderManager()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[RecRoom.NoEngine.Common.Preserve]
	[ExecuteInEditMode]
	public class RunTimeTextureAtlasData : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public Vector4[] textureTransforms;

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x841C5E0", Offset = "0x841AFE0", VA = "0x18841C5E0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x841C5E0", Offset = "0x841AFE0", VA = "0x18841C5E0")]
		private void IKKLMFKPOMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0xAAFC10", Offset = "0xAAE610", VA = "0x180AAFC10")]
		public RunTimeTextureAtlasData()
		{
		}
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
