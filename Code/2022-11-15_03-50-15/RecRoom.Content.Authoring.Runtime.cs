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
	public enum OPMCLKOKEHC
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
	private OPMCLKOKEHC bobAxis;

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
	private float FINNNAGMENA;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private Vector3 HELLGMEDGHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x5E29F30", Offset = "0x5E28930", VA = "0x185E29F30")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0xDD6DA0", Offset = "0xDD57A0", VA = "0x180DD6DA0")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5E2A090", Offset = "0x5E28A90", VA = "0x185E2A090")]
	private void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5E2A290", Offset = "0x5E28C90", VA = "0x185E2A290")]
	public BobbingMotion()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class DisableDuringPlayback : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x82F180", Offset = "0x82DB80", VA = "0x18082F180")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7519E0", Offset = "0x7503E0", VA = "0x1807519E0")]
	public DisableDuringPlayback()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class ImposterBehaviorMaterialAlpha : MonoBehaviour, EMMKNPMEGDI
{
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private const string AHOKILPFAOC = "_BaseColor";

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private const string IKPHHPBDOFD = "_MainColor";

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
	private static List<Material> PHHJPFOBDOG;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static List<Material> PEJMKLPCHIP;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6A0000", Offset = "0x69EA00", VA = "0x1806A0000", Slot = "4")]
	public void PrepareImposter(JBNLBJGPPII INOCFKIFMHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6A0000", Offset = "0x69EA00", VA = "0x1806A0000")]
	public static void CleanUp()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5E2EAE0", Offset = "0x5E2D4E0", VA = "0x185E2EAE0")]
	public ImposterBehaviorMaterialAlpha()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[NativeContainer]
[DefaultMember("Item")]
public struct HGJGPIOMDPN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public enum MADAGCNHIJI
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
	public struct CALPGPKHIIL : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[ReadOnly]
		public HGJGPIOMDPN NHAFLNCJJDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		[ReadOnly]
		public int IGOCKJAFMIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public FAJBDLNCAJL NHFGBBDEAON;

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5E2A2A0", Offset = "0x5E28CA0", VA = "0x185E2A2A0", Slot = "4")]
		public void Execute()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private struct MOALFMLGHDE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public NativeSlice<Vector3> IOPLFLGAFHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public NativeSlice<Vector3> GAKGOOPLNFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public NativeSlice<Vector4> KBMIAKEDKHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public NativeSlice<Vector2> JGADPFKFECM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public NativeSlice<Vector2> JNOJHAOBOML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public NativeSlice<Vector2> IPHNLLBDBGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public NativeSlice<Vector2> MEOCCIIMIHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public NativeSlice<Color> EOIMKEIDNKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public NativeSlice<BoneWeight> EALBBJDLMIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public NativeSlice<Matrix4x4> HDLINFCPBIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public NativeSlice<int> KMLNKLMFOFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public NativeSlice<int> MCNAOPNPJAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public NativeSlice<int> IGECDDNAKFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public NativeSlice<int> NNKHAELAHDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public NativeSlice<byte> BPDMLCPGNIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public int DBAABFBHIDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public Matrix4x4 CPHDBOOEHEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public bool MILBCJPDJEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public int JKEGNAMCIBC;
	}

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private const int KEKPFAJJGBG = 1;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private const int JHHBFJLAFJF = 0;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public NativeArray<Vector3> IOPLFLGAFHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public NativeArray<int> HKIPHDCGNOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public NativeArray<Vector3> GAKGOOPLNFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public NativeArray<Vector4> KBMIAKEDKHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public NativeArray<Vector2> JGADPFKFECM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public NativeArray<Vector2> JNOJHAOBOML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public NativeArray<Vector2> IPHNLLBDBGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public NativeArray<Vector2> MEOCCIIMIHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public NativeArray<Color> EOIMKEIDNKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public NativeArray<BoneWeight> EALBBJDLMIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public NativeArray<int> NNKHAELAHDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public NativeArray<int> AJDCAOHGJAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private NativeArray<int> CEBMNENJBAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private NativeArray<Matrix4x4> HDLINFCPBIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private NativeArray<int> HDFIHLHICAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public NativeArray<int> KMLNKLMFOFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public NativeArray<int> CGIDPOMMLDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private NativeArray<Matrix4x4> IEOLEDFNMDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private NativeArray<byte> LBBJOGGNFOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private NativeArray<int> NFPILDNHING;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private NativeArray<int> FJDFENCECNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private NativeArray<int> NKCGHNIKKFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public NativeArray<sbyte> CGELMJIDDNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public NativeArray<int> KFHEKEPGNNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public NativeArray<int> JMCJDDOPDCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public NativeArray<byte> HMKLHEBMLCL;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private const int OFHIFOKFNED = 0;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private const int DEINIFJCDAD = 1;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private const int CKGJGJICIOA = 2;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private const int CIGHKCPKCGM = 3;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private NativeArray<int> DLBMHHNJCHG;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int JLJBPNHFIIO
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5E2C770", Offset = "0x5E2B170", VA = "0x185E2C770")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5E2C760", Offset = "0x5E2B160", VA = "0x185E2C760")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int NBGDKNEDKGF
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5E2CA30", Offset = "0x5E2B430", VA = "0x185E2CA30")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5E2CA10", Offset = "0x5E2B410", VA = "0x185E2CA10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int EGHOCEDOOEB
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5E2CA40", Offset = "0x5E2B440", VA = "0x185E2CA40")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5E2C750", Offset = "0x5E2B150", VA = "0x185E2C750")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public MADAGCNHIJI LPCJFAMNEBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x5E2CA20", Offset = "0x5E2B420", VA = "0x185E2CA20")]
		get
		{
			return default(MADAGCNHIJI);
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x5E2CA00", Offset = "0x5E2B400", VA = "0x185E2CA00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private MOALFMLGHDE GMLDPDCPAEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x5E2CA50", Offset = "0x5E2B450", VA = "0x185E2CA50")]
		get
		{
			return default(MOALFMLGHDE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5E2D030", Offset = "0x5E2BA30", VA = "0x185E2D030")]
	public HGJGPIOMDPN(IList<Mesh> CMICPFCJPCO, IList<int> HEBDEOANIAE, IList<int> CCDFCEMIOFL, IList<int[]> FMJAILCLLDJ, IList<Matrix4x4> JKAEJCIMDCK, IList<bool> IDGDNCBBCNP, IList<int> GPNECHKGGJC, Allocator FAMNMGKAFPB, MADAGCNHIJI GHDABEFHAPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5E2C5E0", Offset = "0x5E2AFE0", VA = "0x185E2C5E0")]
	public FAJBDLNCAJL CHCLMKCNGJF(int GMKHAANNIEH, Allocator FAMNMGKAFPB)
	{
		return default(FAJBDLNCAJL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5E2C780", Offset = "0x5E2B180", VA = "0x185E2C780", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[NativeContainer]
public struct FAJBDLNCAJL : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public NativeArray<Vector3> IOPLFLGAFHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public NativeArray<Vector3> GAKGOOPLNFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public NativeArray<Vector4> KBMIAKEDKHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public NativeArray<Vector2> JGADPFKFECM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public NativeArray<Vector2> JNOJHAOBOML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public NativeArray<Vector2> IPHNLLBDBGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public NativeArray<Vector2> MEOCCIIMIHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public NativeArray<Color> EOIMKEIDNKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public NativeArray<BoneWeight> EALBBJDLMIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public NativeArray<Matrix4x4> HDLINFCPBIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public NativeArray<int> KMLNKLMFOFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private NativeArray<int> MCNAOPNPJAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private NativeArray<int> IGECDDNAKFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private NativeArray<int> DLBMHHNJCHG;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int FADFHNFCANM
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x5E2B610", Offset = "0x5E2A010", VA = "0x185E2B610")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x5E2BBD0", Offset = "0x5E2A5D0", VA = "0x185E2BBD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5E2BCA0", Offset = "0x5E2A6A0", VA = "0x185E2BCA0")]
	public FAJBDLNCAJL(int ECBAEGGGHMK, int BALFFADCPJC, int EFMABMADJNO, int GMKHAANNIEH, Allocator FAMNMGKAFPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5E2BD60", Offset = "0x5E2A760", VA = "0x185E2BD60")]
	public FAJBDLNCAJL(int ECBAEGGGHMK, int BALFFADCPJC, int EFMABMADJNO, int GMKHAANNIEH, Allocator FAMNMGKAFPB, bool[] KFHPMELIHDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5E2BA40", Offset = "0x5E2A440", VA = "0x185E2BA40")]
	public void HEDFAOJKAIM(int MFIKBHLAGME, int DDIAPGBIJDD, int LOHIKBMAMJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5E2BBE0", Offset = "0x5E2A5E0", VA = "0x185E2BBE0")]
	public int[] OLGEHMNNDIH(int MFIKBHLAGME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5E2BB30", Offset = "0x5E2A530", VA = "0x185E2BB30")]
	private NativeSlice<int> IOLIAKMIGMF(int MFIKBHLAGME)
	{
		return default(NativeSlice<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5E2B620", Offset = "0x5E2A020", VA = "0x185E2B620", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5E2B790", Offset = "0x5E2A190", VA = "0x185E2B790")]
	public Mesh FKFHDKKGBJN([Optional] string JLBMOFOODKH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class FANDOEIDPDB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private List<Mesh> PCHGHNNDJEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private List<int> DLBLAEHELBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private List<bool> CFIMIJCFLDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private List<int[]> LMALHFJOJHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private List<Matrix4x4> DKHDDICOGDI;

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5E2C170", Offset = "0x5E2AB70", VA = "0x185E2C170")]
	public void DCGBHEAAHDO(Mesh LJOHGOPFNGB, int[] FNJCNHBLKIJ, Matrix4x4 IKOPJIPKAGH, bool IDGDNCBBCNP = false, int MINPAFOKAOH = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5E2C3A0", Offset = "0x5E2ADA0", VA = "0x185E2C3A0")]
	public HGJGPIOMDPN FKLELBDFCNN(Allocator FAMNMGKAFPB, HGJGPIOMDPN.MADAGCNHIJI GHDABEFHAPH, [Optional] IList<int> CCDFCEMIOFL, [Optional] IList<int> AEHHFCHCGFD)
	{
		return default(HGJGPIOMDPN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5E2C320", Offset = "0x5E2AD20", VA = "0x185E2C320")]
	private void FHLFLIKOKKI(Mesh LJOHGOPFNGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5E2C450", Offset = "0x5E2AE50", VA = "0x185E2C450")]
	public FANDOEIDPDB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class PlayerHandWorldCollisionConfig : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7519E0", Offset = "0x7503E0", VA = "0x1807519E0")]
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
	private MGNDOCLLPEB playerCollisionType;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public MGNDOCLLPEB HKBKCJHNLJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x748B70", Offset = "0x747570", VA = "0x180748B70")]
		get
		{
			return default(MGNDOCLLPEB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x48C5660", Offset = "0x48C4060", VA = "0x1848C5660")]
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
	[Cpp2IlInjected.Address(RVA = "0x5E30DC0", Offset = "0x5E2F7C0", VA = "0x185E30DC0")]
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
	public bool PGMJALDOIPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x5E31450", Offset = "0x5E2FE50", VA = "0x185E31450")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7519E0", Offset = "0x7503E0", VA = "0x1807519E0")]
	public ShippingContainer()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface OEEJMDCBOEB
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	HHDCHFFOMHL CPNEJKLMAAI
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<HHDCHFFOMHL> LJDACLHKOEL;

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FMPHKKGAJOL();
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public enum HHDCHFFOMHL
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
	Pico,
	[Cpp2IlInjected.Token(Token = "0x4000077")]
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
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		[SerializeField]
		private ParticleSystem targetSystem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		[SerializeField]
		private AnimationCurve intensityCurve;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private Light DLOGHPHECJD;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public Light DOFPFCNGFDH
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x5E30D20", Offset = "0x5E2F720", VA = "0x185E30D20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x5E30BA0", Offset = "0x5E2F5A0", VA = "0x185E30BA0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x5E30CD0", Offset = "0x5E2F6D0", VA = "0x185E30CD0")]
		public ParticleScriptedLight()
		{
		}
	}
}
namespace RecRoom.Utils.Mesh
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[ExecuteInEditMode]
	public class InstanceColor : MonoBehaviour, EMMKNPMEGDI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		[SerializeField]
		[HideInInspector]
		private Color color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public Renderer[] renderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		[SerializeField]
		private bool ignorePrepareImposterBehavior;

		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private static readonly int DAGAKODGNIC;

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x5E2EC40", Offset = "0x5E2D640", VA = "0x185E2EC40")]
		private void NPALOLFFIDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x5E2EB60", Offset = "0x5E2D560", VA = "0x185E2EB60")]
		private void NEHOJOEFNDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x5E2EE00", Offset = "0x5E2D800", VA = "0x185E2EE00")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x5E2ED90", Offset = "0x5E2D790", VA = "0x185E2ED90", Slot = "4")]
		public void PrepareImposter(JBNLBJGPPII INOCFKIFMHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7519E0", Offset = "0x7503E0", VA = "0x1807519E0")]
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
		public delegate void POCAOJIEMOH(ParticleEventListener AADGEAMJACL, Collider BPKBHFMGOOF, IEnumerable<ParticleCollisionEvent> GDGNBKNCMCM);

		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private static readonly List<ParticleCollisionEvent> LPINOCADICG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		[SerializeField]
		[OBEBELAGOGC(FDCMDMMJJJI.Self, false, false, false)]
		private ParticleSystem particles;

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event POCAOJIEMOH IINJFNKNPFL
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x5E2FA30", Offset = "0x5E2E430", VA = "0x185E2FA30")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x5E2FAD0", Offset = "0x5E2E4D0", VA = "0x185E2FAD0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x5E2F690", Offset = "0x5E2E090", VA = "0x185E2F690")]
		private void OnParticleCollision(GameObject BPKBHFMGOOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x7519E0", Offset = "0x7503E0", VA = "0x1807519E0")]
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
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public Component[] SourceObjects;

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7519E0", Offset = "0x7503E0", VA = "0x1807519E0")]
		public StaticBatch()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class StaticBatchManager : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public bool UseSpacePartition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		[MAIILFIGLML("UseSpacePartition")]
		public float SpacePartitionCubeSize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public bool ForceLOD0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public bool OnlyBatchProBuilderMeshes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x22")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public bool SplitOriginalSubmeshes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x23")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public bool StripToJustUV0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		[HideInInspector]
		public List<MeshRenderer> originalAssets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		[HideInInspector]
		public List<LODGroup> originalLodGroups;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		[HideInInspector]
		public List<GameObject> staticBatches;

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x5E31580", Offset = "0x5E2FF80", VA = "0x185E31580")]
		public StaticBatchManager()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class StaticBatchMeshData : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		[HideInInspector]
		public List<Mesh> SubMeshes;

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x5E315A0", Offset = "0x5E2FFA0", VA = "0x185E315A0")]
		public bool KCCHFEBEDKL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x5E316E0", Offset = "0x5E300E0", VA = "0x185E316E0")]
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
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		[SerializeField]
		private Renderer[] AffectedRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private bool NCIHIOCOKFF;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		protected override GFEOFJNACOF NCHOPIDFJAK
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x69D760", Offset = "0x69C160", VA = "0x18069D760", Slot = "4")]
			get
			{
				return default(GFEOFJNACOF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x5E2B240", Offset = "0x5E29C40", VA = "0x185E2B240")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x5E2B2E0", Offset = "0x5E29CE0", VA = "0x185E2B2E0")]
		private void EKNHMPBINAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x5E2B5A0", Offset = "0x5E29FA0", VA = "0x185E2B5A0")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x5E2B4C0", Offset = "0x5E29EC0", VA = "0x185E2B4C0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x5E2B250", Offset = "0x5E29C50", VA = "0x185E2B250")]
		private void DFJBKEBENOK(HHDCHFFOMHL LFHGKFJCMNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x5E2B4B0", Offset = "0x5E29EB0", VA = "0x185E2B4B0", Slot = "8")]
		protected override bool MPBCKGDOHOP(bool EMOMLAIHEFB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x5E2B440", Offset = "0x5E29E40", VA = "0x185E2B440", Slot = "9")]
		protected override void LMFNNCGFNIK(bool EEABMHJBHIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x5E2B5D0", Offset = "0x5E29FD0", VA = "0x185E2B5D0")]
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
			[Cpp2IlInjected.Token(Token = "0x40000A1")]
			public ParticleQualityLevel particleQuality;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40000A2")]
			public int maxParticles;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000A3")]
			public bool enableTrails;

			[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			public bool enableCollisions;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			public bool overrideEmissionRate;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			[Range(0f, 1f)]
			public float emissionRateMultiplier;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			public bool overrideLifetime;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			[Cpp2IlInjected.Attribute(Name = "RangeAttribute", RVA = "0x103C50", Offset = "0x103050")]
			public float lifetimeMultiplier;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		[SerializeField]
		[OBEBELAGOGC(FDCMDMMJJJI.Self, false, false, false)]
		private ParticleSystem particles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		[SerializeField]
		private OverrideSettings[] overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private bool KPMCGCNPANK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private int MMGKJDKGCDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private bool CAIPCGIOMFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private bool ADCMBONPEJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private float DHKADEAOICL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private float AJNMFGIMLMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private float NKGCNHEMCPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private float JHFIBOJHFLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private float FIPLPKJLNMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private float EMAJNCHJMPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private ParticleSystem.MainModule PNGGBEMOJHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private ParticleSystem.TrailModule FNJIHKGFACP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private ParticleSystem.EmissionModule ENFFJIELOAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private ParticleSystem.CollisionModule JCFJMBMMIMH;

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x5E30A10", Offset = "0x5E2F410", VA = "0x185E30A10")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x5E30930", Offset = "0x5E2F330", VA = "0x185E30930")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x5E2FCB0", Offset = "0x5E2E6B0", VA = "0x185E2FCB0")]
		private void DFJBKEBENOK(HHDCHFFOMHL LFHGKFJCMNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x5E2FD10", Offset = "0x5E2E710", VA = "0x185E2FD10")]
		private void EIPGAHLNIEN(IRecRoomQualityConfigProvider GGMDOPKKALN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x5E303D0", Offset = "0x5E2EDD0", VA = "0x185E303D0")]
		private void HEIDJNCFHDJ(OverrideSettings ANMPOOKGNPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x5E30220", Offset = "0x5E2EC20", VA = "0x185E30220")]
		private void HCAMNGMNMPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x5E30770", Offset = "0x5E2F170", VA = "0x185E30770")]
		private void KLAKHJABBJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x5E2FB70", Offset = "0x5E2E570", VA = "0x185E2FB70")]
		private void BMGFJLLGPOE(ParticleSystem.MinMaxCurve KDCDMIJGEGC, out float NFFKNLJEJBP, out float BODOIDBACME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x5E30630", Offset = "0x5E2F030", VA = "0x185E30630")]
		private ParticleSystem.MinMaxCurve HJLKNHCPFPF(ParticleSystem.MinMaxCurve KDCDMIJGEGC, float NFFKNLJEJBP, float BODOIDBACME)
		{
			return default(ParticleSystem.MinMaxCurve);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x7519E0", Offset = "0x7503E0", VA = "0x1807519E0")]
		public ParticleQualityOverride()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public abstract class QualityBasedActivationController<T> : ActivationController<T> where T : IConvertible
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		protected override GFEOFJNACOF NCHOPIDFJAK
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x69D760", Offset = "0x69C160", VA = "0x18069D760", Slot = "4")]
			get
			{
				return default(GFEOFJNACOF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "10")]
		protected abstract T NHGAHGNIPAP(IRecRoomQualityConfigProvider ANHBHKIAIFF);

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x2D4BD10", Offset = "0x2D4A710", VA = "0x182D4BD10")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x2D4C200", Offset = "0x2D4AC00", VA = "0x182D4C200")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x2D4C010", Offset = "0x2D4AA10", VA = "0x182D4C010")]
		private void DFJBKEBENOK(HHDCHFFOMHL LFHGKFJCMNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x2D4C080", Offset = "0x2D4AA80", VA = "0x182D4C080")]
		private void MLLCPGKONPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x2D4C040", Offset = "0x2D4AA40", VA = "0x182D4C040", Slot = "9")]
		protected override void LMFNNCGFNIK(bool EEABMHJBHIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x17166E0", Offset = "0x17150E0", VA = "0x1817166E0")]
		protected QualityBasedActivationController()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
internal static class OJLMEMIABOO
{
	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x5E2F590", Offset = "0x5E2DF90", VA = "0x185E2F590")]
	[PBIPNKEGBNL(MIDPNFMDJEE.None)]
	private static void EPAJNPLDGPI()
	{
	}
}
namespace RecRoom.Core.Quality
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class SetActiveBasedOnAlphaClippingSupport : QualityBasedActivationController<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x2000021")]
		private enum AHPFNLKAGON
		{
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			EnabledIfAlphaClippingSupported,
			[Cpp2IlInjected.Token(Token = "0x40000AC")]
			DisabledIfAlphaClippingSupported
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		[SerializeField]
		private AHPFNLKAGON behavior;

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x5E30E00", Offset = "0x5E2F800", VA = "0x185E30E00", Slot = "10")]
		protected override bool NHGAHGNIPAP(IRecRoomQualityConfigProvider ANHBHKIAIFF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x5E30DE0", Offset = "0x5E2F7E0", VA = "0x185E30DE0", Slot = "8")]
		protected override bool MPBCKGDOHOP(bool EMOMLAIHEFB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x5E30E50", Offset = "0x5E2F850", VA = "0x185E30E50")]
		public SetActiveBasedOnAlphaClippingSupport()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public class SetActiveBasedOnClothSimulationEnabled : QualityBasedActivationController<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x2000023")]
		private enum HKHGOGGNKHB
		{
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			EnabledIfClothSimulationEnabled,
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			DisabledIfClothSimulationEnabled
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		[SerializeField]
		private HKHGOGGNKHB behavior;

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x5E30E90", Offset = "0x5E2F890", VA = "0x185E30E90", Slot = "10")]
		protected override bool NHGAHGNIPAP(IRecRoomQualityConfigProvider ANHBHKIAIFF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x5E30DE0", Offset = "0x5E2F7E0", VA = "0x185E30DE0", Slot = "8")]
		protected override bool MPBCKGDOHOP(bool EMOMLAIHEFB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x5E30EE0", Offset = "0x5E2F8E0", VA = "0x185E30EE0")]
		public SetActiveBasedOnClothSimulationEnabled()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public class SetActiveBasedOnDepthSamplingSupport : QualityBasedActivationController<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x2000025")]
		private enum PPDFEANJDIK
		{
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			EnabledIfDepthSamplingSupported,
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			DisabledIfDepthSamplingSupported
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		[SerializeField]
		private PPDFEANJDIK behavior;

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x5E30F20", Offset = "0x5E2F920", VA = "0x185E30F20", Slot = "10")]
		protected override bool NHGAHGNIPAP(IRecRoomQualityConfigProvider ANHBHKIAIFF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x5E30DE0", Offset = "0x5E2F7E0", VA = "0x185E30DE0", Slot = "8")]
		protected override bool MPBCKGDOHOP(bool EMOMLAIHEFB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x5E30F70", Offset = "0x5E2F970", VA = "0x185E30F70")]
		public SetActiveBasedOnDepthSamplingSupport()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class SetActiveBasedOnLightingType : QualityBasedActivationController<LightRenderingMode>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		[SerializeField]
		private LightRenderingMode enabledForLightingType;

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x5E30FC0", Offset = "0x5E2F9C0", VA = "0x185E30FC0", Slot = "10")]
		protected override LightRenderingMode NHGAHGNIPAP(IRecRoomQualityConfigProvider ANHBHKIAIFF)
		{
			return default(LightRenderingMode);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x5E30FB0", Offset = "0x5E2F9B0", VA = "0x185E30FB0", Slot = "8")]
		protected override bool MPBCKGDOHOP(LightRenderingMode EMOMLAIHEFB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x5E31020", Offset = "0x5E2FA20", VA = "0x185E31020")]
		public SetActiveBasedOnLightingType()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class SetActiveBasedOnSceneDecorationDetailLevel : QualityBasedActivationController<SceneDecorationDetailLevel>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		[SerializeField]
		private SceneDecorationDetailLevel sceneDecorationDetail;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		[SerializeField]
		private bool activeBelowThreshold;

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x5E31080", Offset = "0x5E2FA80", VA = "0x185E31080", Slot = "10")]
		protected override SceneDecorationDetailLevel NHGAHGNIPAP(IRecRoomQualityConfigProvider ANHBHKIAIFF)
		{
			return default(SceneDecorationDetailLevel);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x5E31060", Offset = "0x5E2FA60", VA = "0x185E31060", Slot = "8")]
		protected override bool MPBCKGDOHOP(SceneDecorationDetailLevel EMOMLAIHEFB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x5E310D0", Offset = "0x5E2FAD0", VA = "0x185E310D0")]
		public SetActiveBasedOnSceneDecorationDetailLevel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class SetActiveBasedOnTransparencyDetailLevel : QualityBasedActivationController<TransparencyDetailLevel>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		[SerializeField]
		private TransparencyDetailLevel transparencyDetailThreshold;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		[SerializeField]
		private bool activeBelowThreshold;

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x5E31130", Offset = "0x5E2FB30", VA = "0x185E31130", Slot = "10")]
		protected override TransparencyDetailLevel NHGAHGNIPAP(IRecRoomQualityConfigProvider ANHBHKIAIFF)
		{
			return default(TransparencyDetailLevel);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x5E31110", Offset = "0x5E2FB10", VA = "0x185E31110", Slot = "8")]
		protected override bool MPBCKGDOHOP(TransparencyDetailLevel EMOMLAIHEFB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x5E31180", Offset = "0x5E2FB80", VA = "0x185E31180")]
		public SetActiveBasedOnTransparencyDetailLevel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public class SetComponentsActiveBasedOnBackgroundAnimationDetailLevel : ActivationController<BackgroundAnimationDetailLevel>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public BackgroundAnimationDetailLevel MinimumSupportedDetail;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public Behaviour[] components;

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x5E312E0", Offset = "0x5E2FCE0", VA = "0x185E312E0", Slot = "8")]
		protected override bool MPBCKGDOHOP(BackgroundAnimationDetailLevel FCGPAOHHNDC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x5E31250", Offset = "0x5E2FC50", VA = "0x185E31250", Slot = "9")]
		protected override void LMFNNCGFNIK(bool BGGOFFFFDLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x5E311C0", Offset = "0x5E2FBC0", VA = "0x185E311C0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x5E31380", Offset = "0x5E2FD80", VA = "0x185E31380")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x5E31410", Offset = "0x5E2FE10", VA = "0x185E31410")]
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
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			public TerrainQualityLevel TerrainQualitySetting;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public float PixelError;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public float DetailDistance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			[Range(0f, 1f)]
			public float DetailDensity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			public TreePrefabOverride[] TreePrefabOverrides;

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
			public Settings()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200002C")]
		public struct TreePrefabOverride
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			public GameObject DefaultTree;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			public GameObject OverrideTree;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public float DefaultPixelError;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public float DefaultDetailDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public float DefaultDetailDensity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public Settings[] QualitySettingOverrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private Terrain HJHCHOBHMCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private TerrainData MHPPJPJGICH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private TerrainData POPMIABFKHG;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		private Terrain JHBMLHFEJLD
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x5E31A00", Offset = "0x5E30400", VA = "0x185E31A00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x5E31760", Offset = "0x5E30160", VA = "0x185E31760")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x5E31C10", Offset = "0x5E30610", VA = "0x185E31C10")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x5E31B30", Offset = "0x5E30530", VA = "0x185E31B30")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x5E31B20", Offset = "0x5E30520", VA = "0x185E31B20")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x5E31800", Offset = "0x5E30200", VA = "0x185E31800")]
		private void DCMJKEDKLDB(HHDCHFFOMHL LFHGKFJCMNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x5E32030", Offset = "0x5E30A30", VA = "0x185E32030", Slot = "7")]
		public override void SetActivation(TerrainQualityLevel PAGBIAHJKDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6A32E0", Offset = "0x6A1CE0", VA = "0x1806A32E0", Slot = "8")]
		protected override bool MPBCKGDOHOP(TerrainQualityLevel FCGPAOHHNDC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6A0000", Offset = "0x69EA00", VA = "0x1806A0000", Slot = "9")]
		protected override void LMFNNCGFNIK(bool EEABMHJBHIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x5E31980", Offset = "0x5E30380", VA = "0x185E31980")]
		private void JACHKBFCNHK(Settings AKDFIIKKOCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x5E31D60", Offset = "0x5E30760", VA = "0x185E31D60")]
		private void PJIMANBAEEI(TreePrefabOverride[] HLMLHLHNEKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x5E31890", Offset = "0x5E30290", VA = "0x185E31890")]
		private void HMEJNLIEDDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x5E31AA0", Offset = "0x5E304A0", VA = "0x185E31AA0")]
		private Settings OKALECGHMMC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x5E321F0", Offset = "0x5E30BF0", VA = "0x185E321F0")]
		public TerrainQualitySettings()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public enum MGNDOCLLPEB
{
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	DISABLED,
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	HEAD_ONLY,
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	HEAD_AND_BODY
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface JLHBHLMFIGC
{
	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void TrySetDefaultRGBColor(Color FDMANEGJPBO);
}
namespace RecRoom.Core.Creation.SceneMoods
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public class BackgroundObject : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public MeshRenderer[] coloredRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public bool rotateWithSun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private List<Material> BHEEBKLCBHG;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public BackgroundObject IFAHLGONOAG
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x6A4F10", Offset = "0x6A3910", VA = "0x1806A4F10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x6A4ED0", Offset = "0x6A38D0", VA = "0x1806A4ED0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x5E29730", Offset = "0x5E28130", VA = "0x185E29730")]
		public void Init(BackgroundObject CDBJBIDGEMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x5E299D0", Offset = "0x5E283D0", VA = "0x185E299D0")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x5E29AF0", Offset = "0x5E284F0", VA = "0x185E29AF0")]
		public void SetBlendValue(float MKEOMDMDMFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x5E29C50", Offset = "0x5E28650", VA = "0x185E29C50")]
		public void SetColor(Color FDMANEGJPBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x5E29D60", Offset = "0x5E28760", VA = "0x185E29D60")]
		public void SetRotation(float IOCIEOJKCCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x5E29EB0", Offset = "0x5E288B0", VA = "0x185E29EB0")]
		public BackgroundObject()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public interface EHGNMKLIOEH
{
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface JLHGDALMGPL<T> : EHGNMKLIOEH
{
	[Cpp2IlInjected.Token(Token = "0x17000010")]
	bool FJONCHKHAIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void SetActivation(T FCGPAOHHNDC);
}
namespace RecRoom.Core.Platforms
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public abstract class ActivationController : MonoBehaviour, EHGNMKLIOEH
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		public enum GFEOFJNACOF
		{
			[Cpp2IlInjected.Token(Token = "0x40000D4")]
			DoNothing,
			[Cpp2IlInjected.Token(Token = "0x40000D5")]
			EnableIfAllowed,
			[Cpp2IlInjected.Token(Token = "0x40000D6")]
			EnableAlways
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		[SerializeField]
		[MAIILFIGLML("OnSceneOrPrefabSaveBehavior", 1)]
		private bool allowSaveAsDisabled;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		protected virtual GFEOFJNACOF NCHOPIDFJAK
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x6A0140", Offset = "0x69EB40", VA = "0x1806A0140", Slot = "4")]
			get
			{
				return default(GFEOFJNACOF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x7519E0", Offset = "0x7503E0", VA = "0x1807519E0")]
		protected ActivationController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public abstract class ActivationController<T> : ActivationController, global::JLHGDALMGPL<T>, EHGNMKLIOEH where T : IConvertible
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		protected bool? OHFJPDFEFLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		protected T IFICAKGIOMP;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool FJONCHKHAIO
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x3075E50", Offset = "0x3074850", VA = "0x183075E50", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x3075B50", Offset = "0x3074550", VA = "0x183075B50", Slot = "7")]
		public virtual void SetActivation(T FCGPAOHHNDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(Slot = "8")]
		protected abstract bool MPBCKGDOHOP(T FCGPAOHHNDC);

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(Slot = "9")]
		protected abstract void LMFNNCGFNIK(bool EEABMHJBHIN);

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x1E69C10", Offset = "0x1E68610", VA = "0x181E69C10")]
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
		[Cpp2IlInjected.Address(RVA = "0x7519E0", Offset = "0x7503E0", VA = "0x1807519E0")]
		public AGProBuilderStub()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000037")]
public class LHIPOBGMLKE
{
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private static byte[] PNBNOGIJBMC;

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private static int DGEFGPNJFGJ;

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private static int GBGLKCBJBIA;

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private static BigInteger EPCGLFJDNLL;

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
	public LHIPOBGMLKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x5E2EF60", Offset = "0x5E2D960", VA = "0x185E2EF60")]
	private static string GKOJACPJHAL(byte[] KCHCODPDAGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x5E2F070", Offset = "0x5E2DA70", VA = "0x185E2F070")]
	public static string MEDIDALCMKC(byte[] GHEBPHBJKNK, bool FPEGHFMMINI)
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
		[StructLayout((LayoutKind)2, Pack = 1, Size = 151)]
		[Cpp2IlInjected.Token(Token = "0x2000039")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
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
