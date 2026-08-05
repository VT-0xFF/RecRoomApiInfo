using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Mono.Math;
using RecRoom.Core.Platforms;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;
using UnityEngine;
using UnityEngine.Rendering.Universal;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[ExecuteInEditMode]
public class BobbingMotion : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public enum JAJCJEDOPNG
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
	private JAJCJEDOPNG bobAxis;

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
	private float FMBLFIEAPFH;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private Vector3 CLDIGNAHCFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x5766300", Offset = "0x5764F00", VA = "0x185766300")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0xFBAA90", Offset = "0xFB9690", VA = "0x180FBAA90")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x57664D0", Offset = "0x57650D0", VA = "0x1857664D0")]
	private void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5766630", Offset = "0x5765230", VA = "0x185766630")]
	public BobbingMotion()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class DisableDuringPlayback : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xE6A0F0", Offset = "0xE68CF0", VA = "0x180E6A0F0")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0xE6E9A0", Offset = "0xE6D5A0", VA = "0x180E6E9A0")]
	public DisableDuringPlayback()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class ImposterBehaviorMaterialAlpha : MonoBehaviour, JBJHFKIJGPN
{
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private const string JBDDDBFPFMC = "_BaseColor";

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private const string DKBIPJEHKMI = "_MainColor";

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
	private static List<Material> FJOJPIDOECM;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static List<Material> DEGHFKBAAIK;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5ECE80", Offset = "0x5EBA80", VA = "0x1805ECE80", Slot = "4")]
	public void PrepareImposter(HCHCHAGJBNM BEMMPFFAJLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x5ECE80", Offset = "0x5EBA80", VA = "0x1805ECE80")]
	public static void CleanUp()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5767B60", Offset = "0x5766760", VA = "0x185767B60")]
	public ImposterBehaviorMaterialAlpha()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[NativeContainer]
[DefaultMember("Item")]
public struct PMDFKACECEM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public enum EEPGHPAFKJB
	{
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		CollapseSubMeshes,
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		CollapseToUniqueMaterials,
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		MergeAll
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct KJAPBFDIGKI : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[ReadOnly]
		public PMDFKACECEM KJLNLCGMIHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		[ReadOnly]
		public int GKCLFJHNHOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public HIALLIAGDJM AGFPCMJAPCI;

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5767FA0", Offset = "0x5766BA0", VA = "0x185767FA0", Slot = "4")]
		public void Execute()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private struct MGGDAAOCIAJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public NativeSlice<Vector3> JDKPDCKAOPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public NativeSlice<Vector3> FBGMCPJMJJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public NativeSlice<Vector4> GPNKKIGOFJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public NativeSlice<Vector2> GDKEDLGPJHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public NativeSlice<Vector2> DIGDIFJNLKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public NativeSlice<Vector2> GLPFJABKFNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public NativeSlice<Vector2> CNBJKGHBNDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public NativeSlice<Color> AJDIKHBMOPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public NativeSlice<BoneWeight> OONFIFDPPMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public NativeSlice<Matrix4x4> DMDBBJCLLLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public NativeSlice<int> ADBFHJLNFNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public NativeSlice<int> KHNGOGKACHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public NativeSlice<int> MLPAGGELPHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public NativeSlice<int> NIBLFPLLBJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public NativeSlice<byte> OIIIJIGDEDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public int PCIAHFIIOJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public Matrix4x4 EAAEPKCCJFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public bool NJMLLFFEHBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public int HGKLGKKPJMJ;
	}

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private const int FNHJNJJHNKM = 1;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private const int JIILMIKCHKP = 0;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public NativeArray<Vector3> JDKPDCKAOPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public NativeArray<int> MJDHBGBGPLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public NativeArray<Vector3> FBGMCPJMJJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public NativeArray<Vector4> GPNKKIGOFJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public NativeArray<Vector2> GDKEDLGPJHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public NativeArray<Vector2> DIGDIFJNLKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public NativeArray<Vector2> GLPFJABKFNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public NativeArray<Vector2> CNBJKGHBNDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public NativeArray<Color> AJDIKHBMOPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public NativeArray<BoneWeight> OONFIFDPPMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public NativeArray<int> NIBLFPLLBJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public NativeArray<int> GIOKHJKEHJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private NativeArray<int> ABIPAKACHFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private NativeArray<Matrix4x4> DMDBBJCLLLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private NativeArray<int> CAEECAMEPLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public NativeArray<int> ADBFHJLNFNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public NativeArray<int> JKMFLLPPBFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private NativeArray<Matrix4x4> MDOODKIDAFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private NativeArray<byte> DAHGEOIIKGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private NativeArray<int> EODHPFLNDOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private NativeArray<int> MEBJOMDABCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private NativeArray<int> FEEDCADEFDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public NativeArray<sbyte> AECHMIKLGKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public NativeArray<int> HICBHNMMLDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public NativeArray<int> KKPFAHFHALC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public NativeArray<byte> HDOIJBCHIHC;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private const int CAALFMBDLCH = 0;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private const int GNFKABHKLML = 1;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private const int GGEJBCEMHGL = 2;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private const int IKNNJOAIFDD = 3;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private NativeArray<int> KEPLKJAOPJH;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int JKHGFKCKPKM
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5768FE0", Offset = "0x5767BE0", VA = "0x185768FE0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5769830", Offset = "0x5768430", VA = "0x185769830")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int ANAPCDIHIIM
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x57699E0", Offset = "0x57685E0", VA = "0x1857699E0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x57699D0", Offset = "0x57685D0", VA = "0x1857699D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int NLFLMPFGINL
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5769840", Offset = "0x5768440", VA = "0x185769840")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5769850", Offset = "0x5768450", VA = "0x185769850")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public EEPGHPAFKJB NICHAAGLHDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x5769210", Offset = "0x5767E10", VA = "0x185769210")]
		get
		{
			return default(EEPGHPAFKJB);
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x57699F0", Offset = "0x57685F0", VA = "0x1857699F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private MGGDAAOCIAJ GKKCENAEOFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x5769220", Offset = "0x5767E20", VA = "0x185769220")]
		get
		{
			return default(MGGDAAOCIAJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5769A00", Offset = "0x5768600", VA = "0x185769A00")]
	public PMDFKACECEM(IList<Mesh> ODIJOHGOOGK, IList<int> KKCFOJIMFML, IList<int> ODHKOLMOEEL, IList<int[]> CFKPDKKIMKD, IList<Matrix4x4> BMNHOLPHLHI, IList<bool> DFAJOJNENFB, IList<int> NCMGCCOLNLB, Allocator HGKGLCNFHPJ, EEPGHPAFKJB MCOHOJPDAKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5769860", Offset = "0x5768460", VA = "0x185769860")]
	public HIALLIAGDJM JCPMKOHBOCC(int LBFFKNCNNKB, Allocator HGKGLCNFHPJ)
	{
		return default(HIALLIAGDJM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5768FF0", Offset = "0x5767BF0", VA = "0x185768FF0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[NativeContainer]
public struct HIALLIAGDJM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public NativeArray<Vector3> JDKPDCKAOPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public NativeArray<Vector3> FBGMCPJMJJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public NativeArray<Vector4> GPNKKIGOFJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public NativeArray<Vector2> GDKEDLGPJHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public NativeArray<Vector2> DIGDIFJNLKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public NativeArray<Vector2> GLPFJABKFNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public NativeArray<Vector2> CNBJKGHBNDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public NativeArray<Color> AJDIKHBMOPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public NativeArray<BoneWeight> OONFIFDPPMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public NativeArray<Matrix4x4> DMDBBJCLLLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public NativeArray<int> ADBFHJLNFNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private NativeArray<int> KHNGOGKACHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private NativeArray<int> MLPAGGELPHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private NativeArray<int> KEPLKJAOPJH;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int MFBGBBIFLLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x5767140", Offset = "0x5765D40", VA = "0x185767140")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x5767310", Offset = "0x5765F10", VA = "0x185767310")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5767630", Offset = "0x5766230", VA = "0x185767630")]
	public HIALLIAGDJM(int BKHJKHDKFLK, int PBLMAKLHMIM, int AJIKMPDCIDL, int LBFFKNCNNKB, Allocator HGKGLCNFHPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x57676E0", Offset = "0x57662E0", VA = "0x1857676E0")]
	public HIALLIAGDJM(int BKHJKHDKFLK, int PBLMAKLHMIM, int AJIKMPDCIDL, int LBFFKNCNNKB, Allocator HGKGLCNFHPJ, bool[] ECKHKAEPMKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5767060", Offset = "0x5765C60", VA = "0x185767060")]
	public void AKMALJNCLLM(int JHONIHCKIMJ, int FPKCCNCOJGI, int LEHFCNIEMMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5767320", Offset = "0x5765F20", VA = "0x185767320")]
	public int[] LPFDEABBAPJ(int JHONIHCKIMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5767150", Offset = "0x5765D50", VA = "0x185767150")]
	private NativeSlice<int> BIJOIPGBLGB(int JHONIHCKIMJ)
	{
		return default(NativeSlice<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x57671F0", Offset = "0x5765DF0", VA = "0x1857671F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x57673E0", Offset = "0x5765FE0", VA = "0x1857673E0")]
	public Mesh PLBHMJFMFHM([Optional] string DOLOPHGKKDG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class OLACMDJBNBL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private List<Mesh> PHCNFFBEEGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private List<int> JPJOGJDADJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private List<bool> PJLLBKHIAFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private List<int[]> GLFGMOIPHCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private List<Matrix4x4> MOKCNACNCLO;

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5768D40", Offset = "0x5767940", VA = "0x185768D40")]
	public void MFFKHDAMFFF(Mesh NIFBJJIIANL, int[] LEJEHPBAMOC, Matrix4x4 DHPDAFKFNJJ, bool DFAJOJNENFB = false, int FFANMPMKEPE = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5768C10", Offset = "0x5767810", VA = "0x185768C10")]
	public PMDFKACECEM BHPJOLJPNHP(Allocator HGKGLCNFHPJ, PMDFKACECEM.EEPGHPAFKJB MCOHOJPDAKN, [Optional] IList<int> ODHKOLMOEEL, [Optional] IList<int> LOECPPJBEKN)
	{
		return default(PMDFKACECEM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5768CC0", Offset = "0x57678C0", VA = "0x185768CC0")]
	private void DGMHGBPJNJM(Mesh NIFBJJIIANL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5768EC0", Offset = "0x5767AC0", VA = "0x185768EC0")]
	public OLACMDJBNBL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class PlayerHandWorldCollisionConfig : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0xE6E9A0", Offset = "0xE6D5A0", VA = "0x180E6E9A0")]
	public PlayerHandWorldCollisionConfig()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class PlayerWorldCollisionConfig : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	[SerializeField]
	private CGLMANCCNDH playerCollisionType;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public CGLMANCCNDH KKGNEDBBHKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x678670", Offset = "0x677270", VA = "0x180678670")]
		get
		{
			return default(CGLMANCCNDH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x2B7B850", Offset = "0x2B7A450", VA = "0x182B7B850")]
	public PlayerWorldCollisionConfig()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[RequireComponent(typeof(Camera))]
public class ScreenshotGenerator : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public int Width;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public int Height;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public int AntiAliasLevel;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public bool UseAlpha;

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x576CD30", Offset = "0x576B930", VA = "0x18576CD30")]
	public ScreenshotGenerator()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class ShippingContainer : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	[SerializeField]
	public GameObject[] partRoots;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	[SerializeField]
	public MeshRenderer[] lodRenderers;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool FMNECMHJFPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x576D390", Offset = "0x576BF90", VA = "0x18576D390")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0xE6E9A0", Offset = "0xE6D5A0", VA = "0x180E6E9A0")]
	public ShippingContainer()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface NDDMLHFBGGN
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	PBBNGPIPAMJ KOGGDFPMLLG
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<PBBNGPIPAMJ> BGOEAJGPJJH;

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OJBLDDIDBKB();
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public enum PBBNGPIPAMJ
{
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	Fastest,
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	Simple,
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	Ultra,
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	PS4VR,
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	iOSHigh,
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	PS4Screens,
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	iOSLow,
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	XboxOne,
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	AndroidMobileLow,
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	AndroidMobileHigh,
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	PS5,
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	XboxSeries,
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	Count
}
namespace RecRoom.VFX
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Light))]
	public class ParticleScriptedLight : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		[SerializeField]
		private ParticleSystem targetSystem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		[SerializeField]
		private AnimationCurve intensityCurve;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private Light MHFCNHFJLIN;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Light BBFIKPDOBCL
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x576CCA0", Offset = "0x576B8A0", VA = "0x18576CCA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x576CB00", Offset = "0x576B700", VA = "0x18576CB00")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x576CC50", Offset = "0x576B850", VA = "0x18576CC50")]
		public ParticleScriptedLight()
		{
		}
	}
}
namespace RecRoom.Utils.Mesh
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[ExecuteInEditMode]
	public class InstanceColor : MonoBehaviour, JBJHFKIJGPN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		[HideInInspector]
		[SerializeField]
		private Color color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public Renderer[] renderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		[SerializeField]
		private bool ignorePrepareImposterBehavior;

		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private static readonly int BCEMNFGEJOK;

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x5767CA0", Offset = "0x57668A0", VA = "0x185767CA0")]
		private void DDGLDMMPCJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x5767BD0", Offset = "0x57667D0", VA = "0x185767BD0")]
		private void DAOHFIFHELL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x5767E50", Offset = "0x5766A50", VA = "0x185767E50")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x5767DE0", Offset = "0x57669E0", VA = "0x185767DE0", Slot = "4")]
		public void PrepareImposter(HCHCHAGJBNM BEMMPFFAJLN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0xE6E9A0", Offset = "0xE6D5A0", VA = "0x180E6E9A0")]
		public InstanceColor()
		{
		}
	}
}
namespace RecRoom.Core
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class ParticleEventListener : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000016")]
		public delegate void LDLMDDIKKBG(ParticleEventListener OFOFNIBOLBA, Collider NPKIIGGBCCI, IEnumerable<ParticleCollisionEvent> MNPNDMJOIJI);

		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private static readonly List<ParticleCollisionEvent> EMJJCNJBLCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		[SerializeField]
		[FKJMAODFHJL(GIPDBINLIND.Self, false, false, false)]
		private ParticleSystem particles;

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event LDLMDDIKKBG LPIPOPGNKCM
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x576B5C0", Offset = "0x576A1C0", VA = "0x18576B5C0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x576B660", Offset = "0x576A260", VA = "0x18576B660")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x576B280", Offset = "0x5769E80", VA = "0x18576B280")]
		private void OnParticleCollision(GameObject NPKIIGGBCCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xE6E9A0", Offset = "0xE6D5A0", VA = "0x180E6E9A0")]
		public ParticleEventListener()
		{
		}
	}
}
namespace RecRoom.Core.StaticBatching
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class StaticBatch : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public Component[] SourceObjects;

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xE6E9A0", Offset = "0xE6D5A0", VA = "0x180E6E9A0")]
		public StaticBatch()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class StaticBatchManager : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public bool UseSpacePartition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		[AJJNMLLIOHF("UseSpacePartition")]
		public float SpacePartitionCubeSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public bool ForceLOD0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public bool OnlyBatchProBuilderMeshes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x22")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public bool SplitOriginalSubmeshes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x23")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public bool StripToJustUV0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		[HideInInspector]
		public List<MeshRenderer> originalAssets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		[HideInInspector]
		public List<LODGroup> originalLodGroups;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		[HideInInspector]
		public List<GameObject> staticBatches;

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x576D490", Offset = "0x576C090", VA = "0x18576D490")]
		public StaticBatchManager()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class StaticBatchMeshData : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		[HideInInspector]
		public List<Mesh> SubMeshes;

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x576D4B0", Offset = "0x576C0B0", VA = "0x18576D4B0")]
		public bool JJKNCPBBBIG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x576D5C0", Offset = "0x576C1C0", VA = "0x18576D5C0")]
		public StaticBatchMeshData()
		{
		}
	}
}
namespace RecRoom.Core.Quality
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class DisableMeshShadowsForQualitySetting : ActivationController<bool>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		[SerializeField]
		private Renderer[] AffectedRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private bool PDCKKEBPHNK;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		protected override OKMCEOABECL NNDGIAHLECP
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x6D1030", Offset = "0x6CFC30", VA = "0x1806D1030", Slot = "4")]
			get
			{
				return default(OKMCEOABECL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x5766640", Offset = "0x5765240", VA = "0x185766640")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x5766740", Offset = "0x5765340", VA = "0x185766740")]
		private void EDBAEMLCDEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x5766910", Offset = "0x5765510", VA = "0x185766910")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x5766860", Offset = "0x5765460", VA = "0x185766860")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x5766650", Offset = "0x5765250", VA = "0x185766650")]
		private void CBLDONPMOLL(PBBNGPIPAMJ AGGNFJKBBCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x5766850", Offset = "0x5765450", VA = "0x185766850", Slot = "8")]
		protected override bool HPIEJADGBLO(bool PCGBHDEEADI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x57666D0", Offset = "0x57652D0", VA = "0x1857666D0", Slot = "9")]
		protected override void DKKMMIMGFBJ(bool EMMLEAJIEPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x5766940", Offset = "0x5765540", VA = "0x185766940")]
		public DisableMeshShadowsForQualitySetting()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public class ParticleQualityOverride : MonoBehaviour
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		public struct OverrideSettings
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			public ParticleQualityLevel particleQuality;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40000A1")]
			public int maxParticles;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000A2")]
			public bool enableTrails;

			[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
			[Cpp2IlInjected.Token(Token = "0x40000A3")]
			public bool enableCollisions;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			public bool overrideEmissionRate;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			[Range(0f, 1f)]
			public float emissionRateMultiplier;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			public bool overrideLifetime;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			[Range(0f, 2f)]
			public float lifetimeMultiplier;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		[SerializeField]
		[FKJMAODFHJL(GIPDBINLIND.Self, false, false, false)]
		private ParticleSystem particles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		[SerializeField]
		private OverrideSettings[] overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private bool BFDNKOIJDHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private int CCIIPEIKKPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private bool KOHDLIKGIJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private bool FMJEILLPDMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private float CDJKMCNHGEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private float FMPFAIDFOMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private float OOAEGNKMEPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private float ACFBKIPIGEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private float PMKIFFINPDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private float MDNINNLGKAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private ParticleSystem.MainModule KPCPEEOFJKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private ParticleSystem.TrailModule LPECJGGOHBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private ParticleSystem.EmissionModule HGGNMEBGBAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private ParticleSystem.CollisionModule PJMAKOALNLO;

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x576C9C0", Offset = "0x576B5C0", VA = "0x18576C9C0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x576C800", Offset = "0x576B400", VA = "0x18576C800")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x576B8C0", Offset = "0x576A4C0", VA = "0x18576B8C0")]
		private void CBLDONPMOLL(PBBNGPIPAMJ AGGNFJKBBCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x576B920", Offset = "0x576A520", VA = "0x18576B920")]
		private void CIEEBKPEHCJ(IRecRoomQualityConfigProvider MJJPCIEJCOI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x576C5A0", Offset = "0x576B1A0", VA = "0x18576C5A0")]
		private void LDBELNLLMFL(OverrideSettings FEKOLEDNHNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x576C3F0", Offset = "0x576AFF0", VA = "0x18576C3F0")]
		private void JALJEDKGIIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x576B700", Offset = "0x576A300", VA = "0x18576B700")]
		private void CADHOAOAHFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x576C2E0", Offset = "0x576AEE0", VA = "0x18576C2E0")]
		private void HMLIMHMMFIP(ParticleSystem.MinMaxCurve CFLPPDOPHEO, out float FKMDGLGJEAG, out float EHHGIOFCPCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x576C8B0", Offset = "0x576B4B0", VA = "0x18576C8B0")]
		private ParticleSystem.MinMaxCurve PJFLLFNDKHC(ParticleSystem.MinMaxCurve CFLPPDOPHEO, float FKMDGLGJEAG, float EHHGIOFCPCI)
		{
			return default(ParticleSystem.MinMaxCurve);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xE6E9A0", Offset = "0xE6D5A0", VA = "0x180E6E9A0")]
		public ParticleQualityOverride()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public abstract class QualityBasedActivationController<T> : ActivationController<T> where T : IConvertible
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		protected override OKMCEOABECL NNDGIAHLECP
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x6D1030", Offset = "0x6CFC30", VA = "0x1806D1030", Slot = "4")]
			get
			{
				return default(OKMCEOABECL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "10")]
		protected abstract T AEKIFNNOFIG(IRecRoomQualityConfigProvider BFIEABDMJAJ);

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x2194D90", Offset = "0x2193990", VA = "0x182194D90")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x21952C0", Offset = "0x2193EC0", VA = "0x1821952C0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x2194F50", Offset = "0x2193B50", VA = "0x182194F50")]
		private void CBLDONPMOLL(PBBNGPIPAMJ AGGNFJKBBCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x2194FC0", Offset = "0x2193BC0", VA = "0x182194FC0")]
		private void NBDMECJNIEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x2194F80", Offset = "0x2193B80", VA = "0x182194F80", Slot = "9")]
		protected override void DKKMMIMGFBJ(bool EMMLEAJIEPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x1EB3BB0", Offset = "0x1EB27B0", VA = "0x181EB3BB0")]
		protected QualityBasedActivationController()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
internal static class GPGBDLNLEHB
{
	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x5766F70", Offset = "0x5765B70", VA = "0x185766F70")]
	[GFJPFDCIFKC(GLALKNGODNM.None)]
	private static void PCMHCKAGAOP()
	{
	}
}
namespace RecRoom.Core.Quality
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class SetActiveBasedOnAlphaClippingSupport : QualityBasedActivationController<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x2000021")]
		private enum FGJKOCPDAOP
		{
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			EnabledIfAlphaClippingSupported,
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			DisabledIfAlphaClippingSupported
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		[SerializeField]
		private FGJKOCPDAOP behavior;

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x576CD50", Offset = "0x576B950", VA = "0x18576CD50", Slot = "10")]
		protected override bool AEKIFNNOFIG(IRecRoomQualityConfigProvider BFIEABDMJAJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x576CDA0", Offset = "0x576B9A0", VA = "0x18576CDA0", Slot = "8")]
		protected override bool HPIEJADGBLO(bool PCGBHDEEADI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x576CDC0", Offset = "0x576B9C0", VA = "0x18576CDC0")]
		public SetActiveBasedOnAlphaClippingSupport()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public class SetActiveBasedOnClothSimulationEnabled : QualityBasedActivationController<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x2000023")]
		private enum BPIFPPJBMJJ
		{
			[Cpp2IlInjected.Token(Token = "0x40000AE")]
			EnabledIfClothSimulationEnabled,
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			DisabledIfClothSimulationEnabled
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		[SerializeField]
		private BPIFPPJBMJJ behavior;

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x576CE00", Offset = "0x576BA00", VA = "0x18576CE00", Slot = "10")]
		protected override bool AEKIFNNOFIG(IRecRoomQualityConfigProvider BFIEABDMJAJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x576CDA0", Offset = "0x576B9A0", VA = "0x18576CDA0", Slot = "8")]
		protected override bool HPIEJADGBLO(bool PCGBHDEEADI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x576CE50", Offset = "0x576BA50", VA = "0x18576CE50")]
		public SetActiveBasedOnClothSimulationEnabled()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public class SetActiveBasedOnDepthSamplingSupport : QualityBasedActivationController<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x2000025")]
		private enum KEEJFAEDLHB
		{
			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			EnabledIfDepthSamplingSupported,
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			DisabledIfDepthSamplingSupported
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		[SerializeField]
		private KEEJFAEDLHB behavior;

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x576CE90", Offset = "0x576BA90", VA = "0x18576CE90", Slot = "10")]
		protected override bool AEKIFNNOFIG(IRecRoomQualityConfigProvider BFIEABDMJAJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x576CDA0", Offset = "0x576B9A0", VA = "0x18576CDA0", Slot = "8")]
		protected override bool HPIEJADGBLO(bool PCGBHDEEADI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x576CEE0", Offset = "0x576BAE0", VA = "0x18576CEE0")]
		public SetActiveBasedOnDepthSamplingSupport()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class SetActiveBasedOnLightingType : QualityBasedActivationController<LightRenderingMode>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		[SerializeField]
		private LightRenderingMode enabledForLightingType;

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x576CF20", Offset = "0x576BB20", VA = "0x18576CF20", Slot = "10")]
		protected override LightRenderingMode AEKIFNNOFIG(IRecRoomQualityConfigProvider BFIEABDMJAJ)
		{
			return default(LightRenderingMode);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x576CF80", Offset = "0x576BB80", VA = "0x18576CF80", Slot = "8")]
		protected override bool HPIEJADGBLO(LightRenderingMode PCGBHDEEADI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x576CF90", Offset = "0x576BB90", VA = "0x18576CF90")]
		public SetActiveBasedOnLightingType()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class SetActiveBasedOnSceneDecorationDetailLevel : QualityBasedActivationController<SceneDecorationDetailLevel>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		[SerializeField]
		private SceneDecorationDetailLevel sceneDecorationDetail;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		[SerializeField]
		private bool activeBelowThreshold;

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x576CFD0", Offset = "0x576BBD0", VA = "0x18576CFD0", Slot = "10")]
		protected override SceneDecorationDetailLevel AEKIFNNOFIG(IRecRoomQualityConfigProvider BFIEABDMJAJ)
		{
			return default(SceneDecorationDetailLevel);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x576D020", Offset = "0x576BC20", VA = "0x18576D020", Slot = "8")]
		protected override bool HPIEJADGBLO(SceneDecorationDetailLevel PCGBHDEEADI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x576D040", Offset = "0x576BC40", VA = "0x18576D040")]
		public SetActiveBasedOnSceneDecorationDetailLevel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class SetActiveBasedOnTransparencyDetailLevel : QualityBasedActivationController<TransparencyDetailLevel>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		[SerializeField]
		private TransparencyDetailLevel transparencyDetailThreshold;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		[SerializeField]
		private bool activeBelowThreshold;

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x576D080", Offset = "0x576BC80", VA = "0x18576D080", Slot = "10")]
		protected override TransparencyDetailLevel AEKIFNNOFIG(IRecRoomQualityConfigProvider BFIEABDMJAJ)
		{
			return default(TransparencyDetailLevel);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x576D0D0", Offset = "0x576BCD0", VA = "0x18576D0D0", Slot = "8")]
		protected override bool HPIEJADGBLO(TransparencyDetailLevel PCGBHDEEADI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x576D0F0", Offset = "0x576BCF0", VA = "0x18576D0F0")]
		public SetActiveBasedOnTransparencyDetailLevel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public class SetComponentsActiveBasedOnBackgroundAnimationDetailLevel : ActivationController<BackgroundAnimationDetailLevel>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public BackgroundAnimationDetailLevel MinimumSupportedDetail;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public Behaviour[] components;

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x576D240", Offset = "0x576BE40", VA = "0x18576D240", Slot = "8")]
		protected override bool HPIEJADGBLO(BackgroundAnimationDetailLevel ILHPDMJDPKE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x576D1B0", Offset = "0x576BDB0", VA = "0x18576D1B0", Slot = "9")]
		protected override void DKKMMIMGFBJ(bool MPECIKDKPDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x576D130", Offset = "0x576BD30", VA = "0x18576D130")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x576D2D0", Offset = "0x576BED0", VA = "0x18576D2D0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x576D350", Offset = "0x576BF50", VA = "0x18576D350")]
		public SetComponentsActiveBasedOnBackgroundAnimationDetailLevel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[RequireComponent(typeof(Terrain))]
	public class TerrainQualitySettings : ActivationController<TerrainQualityLevel>
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200002B")]
		public class Settings
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public TerrainQualityLevel TerrainQualitySetting;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			public float PixelError;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public float DetailDistance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			[Range(0f, 1f)]
			public float DetailDensity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			public TreePrefabOverride[] TreePrefabOverrides;

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
			public Settings()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200002C")]
		public struct TreePrefabOverride
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			public GameObject DefaultTree;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			public GameObject OverrideTree;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public float DefaultPixelError;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public float DefaultDetailDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public float DefaultDetailDensity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public Settings[] QualitySettingOverrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private Terrain COOBOFHJHEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private TerrainData KECLHBDJLLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private TerrainData EMOFDDGPLJB;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		private Terrain MIODDHHBHAO
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x576DA20", Offset = "0x576C620", VA = "0x18576DA20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x576D630", Offset = "0x576C230", VA = "0x18576D630")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x576DD50", Offset = "0x576C950", VA = "0x18576DD50")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x576DCA0", Offset = "0x576C8A0", VA = "0x18576DCA0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x576DC90", Offset = "0x576C890", VA = "0x18576DC90")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x576DC10", Offset = "0x576C810", VA = "0x18576DC10")]
		private void LCENBHNHFBE(PBBNGPIPAMJ AGGNFJKBBCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x576DE50", Offset = "0x576CA50", VA = "0x18576DE50", Slot = "7")]
		public override void SetActivation(TerrainQualityLevel HLICOACLELG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x5ECFE0", Offset = "0x5EBBE0", VA = "0x1805ECFE0", Slot = "8")]
		protected override bool HPIEJADGBLO(TerrainQualityLevel ILHPDMJDPKE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x5ECE80", Offset = "0x5EBA80", VA = "0x1805ECE80", Slot = "9")]
		protected override void DKKMMIMGFBJ(bool EMMLEAJIEPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x576D9A0", Offset = "0x576C5A0", VA = "0x18576D9A0")]
		private void BOHPPLEKPJA(Settings CDLGMMLBEDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x576D6D0", Offset = "0x576C2D0", VA = "0x18576D6D0")]
		private void BFFMDFMGDJL(TreePrefabOverride[] DPABGDENFCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x576DAB0", Offset = "0x576C6B0", VA = "0x18576DAB0")]
		private void EGKIBIBBJFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x576DB90", Offset = "0x576C790", VA = "0x18576DB90")]
		private Settings JMCMBADDGKO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x576E0C0", Offset = "0x576CCC0", VA = "0x18576E0C0")]
		public TerrainQualitySettings()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public enum CGLMANCCNDH
{
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	DISABLED,
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	HEAD_ONLY,
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	HEAD_AND_BODY
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface CKCADAMAJDG
{
	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void TrySetDefaultRGBColor(Color OKGJEMGBDBL);
}
namespace RecRoom.Core.Creation.SceneMoods
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public class BackgroundObject : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public MeshRenderer[] coloredRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public bool rotateWithSun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private List<Material> NMDEHLOLOIM;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public BackgroundObject DDFMCGOBKNB
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x5EC1C0", Offset = "0x5EADC0", VA = "0x1805EC1C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x5EC4A0", Offset = "0x5EB0A0", VA = "0x1805EC4A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x5765AC0", Offset = "0x57646C0", VA = "0x185765AC0")]
		public void Init(BackgroundObject PAMDOGALOKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x5765D10", Offset = "0x5764910", VA = "0x185765D10")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x5765E30", Offset = "0x5764A30", VA = "0x185765E30")]
		public void SetBlendValue(float ELBOIIFIDCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x5765F90", Offset = "0x5764B90", VA = "0x185765F90")]
		public void SetColor(Color OKGJEMGBDBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x57660A0", Offset = "0x5764CA0", VA = "0x1857660A0")]
		public void SetRotation(float AHDCMPCBKHJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x5766290", Offset = "0x5764E90", VA = "0x185766290")]
		public BackgroundObject()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public interface KBFLFJKADDD
{
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface AHIHAAGKHEL<T> : KBFLFJKADDD
{
	[Cpp2IlInjected.Token(Token = "0x17000010")]
	bool GEOIJNGEBLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void SetActivation(T ILHPDMJDPKE);
}
namespace RecRoom.Core.Platforms
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public abstract class ActivationController : MonoBehaviour, KBFLFJKADDD
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		public enum OKMCEOABECL
		{
			[Cpp2IlInjected.Token(Token = "0x40000D3")]
			DoNothing,
			[Cpp2IlInjected.Token(Token = "0x40000D4")]
			EnableIfAllowed,
			[Cpp2IlInjected.Token(Token = "0x40000D5")]
			EnableAlways
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		[SerializeField]
		[AJJNMLLIOHF("OnSceneOrPrefabSaveBehavior", 1)]
		private bool allowSaveAsDisabled;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		protected virtual OKMCEOABECL NNDGIAHLECP
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x619E80", Offset = "0x618A80", VA = "0x180619E80", Slot = "4")]
			get
			{
				return default(OKMCEOABECL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0xE6E9A0", Offset = "0xE6D5A0", VA = "0x180E6E9A0")]
		protected ActivationController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public abstract class ActivationController<T> : ActivationController, global::AHIHAAGKHEL<T>, KBFLFJKADDD where T : IConvertible
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		protected bool? HKNEDHPFANB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		protected T DFMAJDKJOKE;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool GEOIJNGEBLK
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x218C750", Offset = "0x218B350", VA = "0x18218C750", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x218C3C0", Offset = "0x218AFC0", VA = "0x18218C3C0", Slot = "7")]
		public virtual void SetActivation(T ILHPDMJDPKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "8")]
		protected abstract bool HPIEJADGBLO(T ILHPDMJDPKE);

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "9")]
		protected abstract void DKKMMIMGFBJ(bool EMMLEAJIEPD);

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x1EAF060", Offset = "0x1EADC60", VA = "0x181EAF060")]
		protected ActivationController()
		{
		}
	}
}
namespace RecRoom.ProBuilder
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[AddComponentMenu("")]
	public class AGProBuilderStub : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0xE6E9A0", Offset = "0xE6D5A0", VA = "0x180E6E9A0")]
		public AGProBuilderStub()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000037")]
public class GGMACBOFMDA
{
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private static byte[] HNILJCLIGCF;

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private static int MHDNNHPLAAF;

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private static int JKLLCIMILJG;

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private static BigInteger JLHIBEKHFGK;

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
	public GGMACBOFMDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x5766CB0", Offset = "0x57658B0", VA = "0x185766CB0")]
	private static string PBMOEILNFIF(byte[] EDLPJGEPJPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x5766980", Offset = "0x5765580", VA = "0x185766980")]
	public static string EICDLCDOCAE(byte[] IAIFCDOPKGE, bool LFDDCGMHEMH)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2)]
		[Cpp2IlInjected.Token(Token = "0x2000039")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public class __BB_OBFUSCATOR_VERSION_3_8_2
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
