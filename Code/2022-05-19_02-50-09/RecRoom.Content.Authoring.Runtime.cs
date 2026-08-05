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
	public enum GJPJCPFJLKO
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
	private GJPJCPFJLKO bobAxis;

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
	private float MOBGNEAENED;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private Vector3 PDDMBOPCCHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x4D31A30", Offset = "0x4D30630", VA = "0x184D31A30")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x1A61E30", Offset = "0x1A60A30", VA = "0x181A61E30")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x4D31C00", Offset = "0x4D30800", VA = "0x184D31C00")]
	private void Update()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x4D31D60", Offset = "0x4D30960", VA = "0x184D31D60")]
	public BobbingMotion()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class DisableDuringPlayback : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x18632E0", Offset = "0x1861EE0", VA = "0x1818632E0")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x54FA60", Offset = "0x54E660", VA = "0x18054FA60")]
	public DisableDuringPlayback()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[NativeContainer]
[DefaultMember("Item")]
public struct JGJJCODFJDK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public enum BGMCILEOJIE
	{
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		None,
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		CollapseSubMeshes,
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		CollapseToUniqueMaterials,
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		MergeAll
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct CNIHGKBLLCB : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		[ReadOnly]
		public JGJJCODFJDK EILLMHKBINK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		[ReadOnly]
		public int LFNAJMCMFNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public KHLNGLINKLK PKCBJHJBFHE;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x4D31D70", Offset = "0x4D30970", VA = "0x184D31D70", Slot = "4")]
		public void Execute()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private struct BKMANMGOOMF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public NativeSlice<Vector3> KOJEANMHKGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public NativeSlice<Vector3> OHKOHPDDPOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public NativeSlice<Vector4> KKJMMAGOPHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public NativeSlice<Vector2> JPCAAMENGOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public NativeSlice<Vector2> CLPLKMIFNAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public NativeSlice<Vector2> HCIOCJECKKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public NativeSlice<Vector2> MAJBFFFAJBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public NativeSlice<Color> DPLPPGOJBPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public NativeSlice<BoneWeight> ELCCDHOHPPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public NativeSlice<Matrix4x4> KGHDMDCMIHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public NativeSlice<int> GODALDFNKOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public NativeSlice<int> HBOOFODKIKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public NativeSlice<int> KIEOFNANIBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public NativeSlice<int> NHPPFLGFCKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public NativeSlice<byte> DHCJPBOAOPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public int LPNKHPOOCJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public Matrix4x4 HMOLLMAJNNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public bool JCINANGOAHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public int HFNLJKCCKJP;
	}

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private const int JDBOCAAJHKM = 1;

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private const int AJCCJPOONHN = 0;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public NativeArray<Vector3> KOJEANMHKGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public NativeArray<int> EPEBKPHDJLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public NativeArray<Vector3> OHKOHPDDPOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public NativeArray<Vector4> KKJMMAGOPHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public NativeArray<Vector2> JPCAAMENGOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public NativeArray<Vector2> CLPLKMIFNAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public NativeArray<Vector2> HCIOCJECKKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public NativeArray<Vector2> MAJBFFFAJBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public NativeArray<Color> DPLPPGOJBPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public NativeArray<BoneWeight> ELCCDHOHPPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public NativeArray<int> NHPPFLGFCKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public NativeArray<int> JEIALKHDMCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private NativeArray<int> PADLPPCAAOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private NativeArray<Matrix4x4> KGHDMDCMIHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private NativeArray<int> DIFOKCHMGMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public NativeArray<int> GODALDFNKOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public NativeArray<int> AFAELHNFAPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private NativeArray<Matrix4x4> NHOOBHJHKIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private NativeArray<byte> LCNJBADNJDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private NativeArray<int> GKCOGEENCBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private NativeArray<int> LBHEBMDGAIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private NativeArray<int> KPPPIIKBEEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public NativeArray<sbyte> AGLDKNAKNFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public NativeArray<int> ACNEGHDEEJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public NativeArray<int> KAIPNOFIIPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public NativeArray<byte> DEPGKHDFAOC;

	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private const int FPNEOHCELGI = 0;

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private const int LNOLKHDDJJB = 1;

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private const int HPKBODIIBKO = 2;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private const int DEMAKJNMDJD = 3;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private NativeArray<int> HLCEMDBDPIG;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int GDDJGPFOEPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x4D33810", Offset = "0x4D32410", VA = "0x184D33810")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x4D34220", Offset = "0x4D32E20", VA = "0x184D34220")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int BJPAEALPNNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x4D33A80", Offset = "0x4D32680", VA = "0x184D33A80")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x4D33A90", Offset = "0x4D32690", VA = "0x184D33A90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int KHIHLFPLHBL
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x4D33840", Offset = "0x4D32440", VA = "0x184D33840")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x4D33A70", Offset = "0x4D32670", VA = "0x184D33A70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public BGMCILEOJIE LANFKPPLHJF
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x4D33830", Offset = "0x4D32430", VA = "0x184D33830")]
		get
		{
			return default(BGMCILEOJIE);
		}
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x4D33820", Offset = "0x4D32420", VA = "0x184D33820")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private BKMANMGOOMF KHCFJKNJCLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x4D33AA0", Offset = "0x4D326A0", VA = "0x184D33AA0")]
		get
		{
			return default(BKMANMGOOMF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x4D34230", Offset = "0x4D32E30", VA = "0x184D34230")]
	public JGJJCODFJDK(IList<Mesh> IMMNHMKEAPL, IList<int> FMCMKBPGMJK, IList<int> FBNJDFBELGA, IList<int[]> IIJHIHFMAFD, IList<Matrix4x4> LMBIHOPAGDI, IList<bool> PIIEOOJPMEO, IList<int> IAHOKJELFLP, Allocator GMPKDKMDMBG, BGMCILEOJIE JKHHPHDBMNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x4D340B0", Offset = "0x4D32CB0", VA = "0x184D340B0")]
	public KHLNGLINKLK ODNHFBCGBHJ(int HHKHMHHILPB, Allocator GMPKDKMDMBG)
	{
		return default(KHLNGLINKLK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x4D33850", Offset = "0x4D32450", VA = "0x184D33850", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[NativeContainer]
public struct KHLNGLINKLK : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public NativeArray<Vector3> KOJEANMHKGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public NativeArray<Vector3> OHKOHPDDPOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public NativeArray<Vector4> KKJMMAGOPHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public NativeArray<Vector2> JPCAAMENGOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public NativeArray<Vector2> CLPLKMIFNAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public NativeArray<Vector2> HCIOCJECKKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public NativeArray<Vector2> MAJBFFFAJBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public NativeArray<Color> DPLPPGOJBPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public NativeArray<BoneWeight> ELCCDHOHPPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public NativeArray<Matrix4x4> KGHDMDCMIHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public NativeArray<int> GODALDFNKOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private NativeArray<int> HBOOFODKIKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private NativeArray<int> KIEOFNANIBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private NativeArray<int> HLCEMDBDPIG;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int PLECLJEKIHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x4D35D50", Offset = "0x4D34950", VA = "0x184D35D50")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x4D35E20", Offset = "0x4D34A20", VA = "0x184D35E20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x4D36080", Offset = "0x4D34C80", VA = "0x184D36080")]
	public KHLNGLINKLK(int AJNHCCCDNCC, int EIBDNFFNJKJ, int DKPBDEKGJIM, int HHKHMHHILPB, Allocator GMPKDKMDMBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x4D36130", Offset = "0x4D34D30", VA = "0x184D36130")]
	public KHLNGLINKLK(int AJNHCCCDNCC, int EIBDNFFNJKJ, int DKPBDEKGJIM, int HHKHMHHILPB, Allocator GMPKDKMDMBG, bool[] CEMDKMDPIGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x4D35BD0", Offset = "0x4D347D0", VA = "0x184D35BD0")]
	public void EJJEMNHNNCF(int NAHKDOBJLAI, int BHFOGLICCMI, int GKHAECAMGEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x4D35D60", Offset = "0x4D34960", VA = "0x184D35D60")]
	public int[] LKFONAGFBPC(int NAHKDOBJLAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x4D35CB0", Offset = "0x4D348B0", VA = "0x184D35CB0")]
	private NativeSlice<int> GOHNOCDGLEO(int NAHKDOBJLAI)
	{
		return default(NativeSlice<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x4D35AB0", Offset = "0x4D346B0", VA = "0x184D35AB0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x4D35E30", Offset = "0x4D34A30", VA = "0x184D35E30")]
	public Mesh MPPDCPCIMMK([Optional] string HLOFLODHJNM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class MPNDLJAOMEI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private List<Mesh> EEMJPHCNKEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private List<int> GNHOBFJCGIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private List<bool> FINHGMIOHEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private List<int[]> FJHOENBALPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private List<Matrix4x4> EJILKAJEKPO;

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x4D36640", Offset = "0x4D35240", VA = "0x184D36640")]
	public void OHJPODEPPNG(Mesh NBBCOGHADLE, int[] EOHJMCPJEND, Matrix4x4 ELBBJNBHMFN, bool PIIEOOJPMEO = false, int DKJEMJCFAEC = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x4D36590", Offset = "0x4D35190", VA = "0x184D36590")]
	public JGJJCODFJDK OFLACAMOBOP(Allocator GMPKDKMDMBG, JGJJCODFJDK.BGMCILEOJIE JKHHPHDBMNE, [Optional] IList<int> FBNJDFBELGA, [Optional] IList<int> BIEKLOGBGOF)
	{
		return default(JGJJCODFJDK);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x4D36510", Offset = "0x4D35110", VA = "0x184D36510")]
	private void JNHDJOFFHPK(Mesh NBBCOGHADLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x4D367C0", Offset = "0x4D353C0", VA = "0x184D367C0")]
	public MPNDLJAOMEI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class PlayerWorldCollisionConfig : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	[SerializeField]
	private AKCIEBACNKE playerCollisionType;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public AKCIEBACNKE OMAMKHJOBOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x553470", Offset = "0x552070", VA = "0x180553470")]
		get
		{
			return default(AKCIEBACNKE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x8BB1B0", Offset = "0x8B9DB0", VA = "0x1808BB1B0")]
	public PlayerWorldCollisionConfig()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class ShippingContainer : MonoBehaviour
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	[SerializeField]
	public GameObject[] partRoots;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	[SerializeField]
	public MeshRenderer[] lodRenderers;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool JEOGHBNENKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x4D38590", Offset = "0x4D37190", VA = "0x184D38590")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x54FA60", Offset = "0x54E660", VA = "0x18054FA60")]
	public ShippingContainer()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface EKLOHIKJFJP
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	DNJFLHPLIAG LMNELJKJLKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<DNJFLHPLIAG> FEDCHPJGIKO;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KHPKLBILMOK();
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public enum DNJFLHPLIAG
{
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	Fastest,
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	Simple,
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	Ultra,
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	PS4VR,
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	iOSHigh,
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	PS4Screens,
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	iOSLow,
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	XboxOne,
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	AndroidMobileLow,
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	AndroidMobileHigh,
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	PS5,
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	XboxSeries,
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	Count
}
namespace RecRoom.Utils.Mesh
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[ExecuteInEditMode]
	public class InstanceColor : MonoBehaviour, LNCNKNOKJJK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		[HideInInspector]
		[SerializeField]
		private Color color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public Renderer[] renderers;

		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private static readonly int MONFFACOHFM;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x4D334A0", Offset = "0x4D320A0", VA = "0x184D334A0")]
		private void CHCBAPDNGKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x4D335E0", Offset = "0x4D321E0", VA = "0x184D335E0")]
		private void DOFGBOKIAIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x4D336C0", Offset = "0x4D322C0", VA = "0x184D336C0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x4D336B0", Offset = "0x4D322B0", VA = "0x184D336B0", Slot = "4")]
		public void PrepareImposter(IPDBLAJIMKC DOPNIABFHCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x54FA60", Offset = "0x54E660", VA = "0x18054FA60")]
		public InstanceColor()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public enum AKCIEBACNKE
{
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	DISABLED,
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	HEAD_ONLY,
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	HEAD_AND_BODY
}
namespace RecRoom.Core.Quality
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class DisableMeshShadowsForQualitySetting : ActivationController<bool>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		[SerializeField]
		private Renderer[] AffectedRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private bool PENFKAJCNFC;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		protected override EJMMOKJADLB HKFONDOBJLE
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x77F160", Offset = "0x77DD60", VA = "0x18077F160", Slot = "4")]
			get
			{
				return default(EJMMOKJADLB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x4D33190", Offset = "0x4D31D90", VA = "0x184D33190")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x4D32FD0", Offset = "0x4D31BD0", VA = "0x184D32FD0")]
		private void ALOEOFAEPEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x4D33430", Offset = "0x4D32030", VA = "0x184D33430")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x4D33310", Offset = "0x4D31F10", VA = "0x184D33310")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x4D331B0", Offset = "0x4D31DB0", VA = "0x184D331B0")]
		private void IHJEAKIPHLG(DNJFLHPLIAG CKBALGBMEPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x4D331A0", Offset = "0x4D31DA0", VA = "0x184D331A0", Slot = "8")]
		protected override bool IAHGPCIKIOF(bool FFFAPMFIAMA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x4D332A0", Offset = "0x4D31EA0", VA = "0x184D332A0", Slot = "9")]
		protected override void NOBLIJFPOFL(bool NKMOCOELLNH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x4D33460", Offset = "0x4D32060", VA = "0x184D33460")]
		public DisableMeshShadowsForQualitySetting()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public class ParticleQualityOverride : MonoBehaviour
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		public struct OverrideSettings
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000086")]
			public ParticleQualityLevel particleQuality;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000087")]
			public int maxParticles;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			public bool enableTrails;

			[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			public bool enableCollisions;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			public bool overrideEmissionRate;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			[Range(0f, 1f)]
			public float emissionRateMultiplier;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			public bool overrideLifetime;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			[Range(0f, 2f)]
			public float lifetimeMultiplier;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		[SerializeField]
		[DPPCAMLCCHE(JNPNDJBCKEE.Self, false, false, false)]
		private ParticleSystem particles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		[SerializeField]
		private OverrideSettings[] overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private bool FHDNGFELOGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private int BNIOCEKGJCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private bool KFLGEBFAEPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private bool AHHDLLFKMKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private float DPLCEGCEKFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private float ODEBPBHNLNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private float OIKPNPMDOEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private float FGJMLHPHHAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private float EIIHJJEIDIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private float IGEPFFLJILI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private ParticleSystem.MainModule BBMDJAJOMBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private ParticleSystem.TrailModule LCCOPINAAJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private ParticleSystem.EmissionModule DFMGMHIJOBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private ParticleSystem.CollisionModule NGJHCJNKHAI;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x4D37C80", Offset = "0x4D36880", VA = "0x184D37C80")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x4D37B60", Offset = "0x4D36760", VA = "0x184D37B60")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x4D37500", Offset = "0x4D36100", VA = "0x184D37500")]
		private void IHJEAKIPHLG(DNJFLHPLIAG CKBALGBMEPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x4D368E0", Offset = "0x4D354E0", VA = "0x184D368E0")]
		private void AJMNFJFCGMD(IRecRoomQualityConfigProvider OGJKJDJKHHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x4D372A0", Offset = "0x4D35EA0", VA = "0x184D372A0")]
		private void CBLMFLHFJKE(OverrideSettings HHMNCAPLHNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x4D377F0", Offset = "0x4D363F0", VA = "0x184D377F0")]
		private void NNOMFOJBCFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x4D379A0", Offset = "0x4D365A0", VA = "0x184D379A0")]
		private void NPKFKLKIEDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x4D375D0", Offset = "0x4D361D0", VA = "0x184D375D0")]
		private void JJIDNMEKAIJ(ParticleSystem.MinMaxCurve BDGMCBJBLEN, out float JLAAFKDKHEI, out float NLNNPGEHNOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x4D376E0", Offset = "0x4D362E0", VA = "0x184D376E0")]
		private ParticleSystem.MinMaxCurve LKNLLBPMEJM(ParticleSystem.MinMaxCurve BDGMCBJBLEN, float JLAAFKDKHEI, float NLNNPGEHNOC)
		{
			return default(ParticleSystem.MinMaxCurve);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x54FA60", Offset = "0x54E660", VA = "0x18054FA60")]
		public ParticleQualityOverride()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public abstract class QualityBasedActivationController<T> : ActivationController<T> where T : IConvertible
	{
		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		protected override EJMMOKJADLB HKFONDOBJLE
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x77F160", Offset = "0x77DD60", VA = "0x18077F160", Slot = "4")]
			get
			{
				return default(EJMMOKJADLB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "10")]
		protected abstract T PIJFIILMJEP(IRecRoomQualityConfigProvider GLEMJMFCIMO);

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x3370500", Offset = "0x336F100", VA = "0x183370500")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x3370D40", Offset = "0x336F940", VA = "0x183370D40")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x3370A70", Offset = "0x336F670", VA = "0x183370A70")]
		private void IHJEAKIPHLG(DNJFLHPLIAG CKBALGBMEPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x3370890", Offset = "0x336F490", VA = "0x183370890")]
		private void GLPOFGBDGDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x3370AA0", Offset = "0x336F6A0", VA = "0x183370AA0", Slot = "9")]
		protected override void NOBLIJFPOFL(bool NKMOCOELLNH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x271DB50", Offset = "0x271C750", VA = "0x18271DB50")]
		protected QualityBasedActivationController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public class SetActiveBasedOnAlphaClippingSupport : QualityBasedActivationController<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		private enum CIMOLNOEDMB
		{
			[Cpp2IlInjected.Token(Token = "0x4000090")]
			EnabledIfAlphaClippingSupported,
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			DisabledIfAlphaClippingSupported
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		[SerializeField]
		private CIMOLNOEDMB behavior;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x4D37E90", Offset = "0x4D36A90", VA = "0x184D37E90", Slot = "10")]
		protected override bool PIJFIILMJEP(IRecRoomQualityConfigProvider GLEMJMFCIMO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x4D37E70", Offset = "0x4D36A70", VA = "0x184D37E70", Slot = "8")]
		protected override bool IAHGPCIKIOF(bool FFFAPMFIAMA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x4D37EE0", Offset = "0x4D36AE0", VA = "0x184D37EE0")]
		public SetActiveBasedOnAlphaClippingSupport()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class SetActiveBasedOnClothSimulationEnabled : QualityBasedActivationController<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x2000019")]
		private enum JMJFJNDIDLN
		{
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			EnabledIfClothSimulationEnabled,
			[Cpp2IlInjected.Token(Token = "0x4000095")]
			DisabledIfClothSimulationEnabled
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		[SerializeField]
		private JMJFJNDIDLN behavior;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x4D37F20", Offset = "0x4D36B20", VA = "0x184D37F20", Slot = "10")]
		protected override bool PIJFIILMJEP(IRecRoomQualityConfigProvider GLEMJMFCIMO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x4D37E70", Offset = "0x4D36A70", VA = "0x184D37E70", Slot = "8")]
		protected override bool IAHGPCIKIOF(bool FFFAPMFIAMA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x4D37F70", Offset = "0x4D36B70", VA = "0x184D37F70")]
		public SetActiveBasedOnClothSimulationEnabled()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class SetActiveBasedOnDepthSamplingSupport : QualityBasedActivationController<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		private enum FAEJIAKFJGA
		{
			[Cpp2IlInjected.Token(Token = "0x4000098")]
			EnabledIfDepthSamplingSupported,
			[Cpp2IlInjected.Token(Token = "0x4000099")]
			DisabledIfDepthSamplingSupported
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		[SerializeField]
		private FAEJIAKFJGA behavior;

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x4D37FB0", Offset = "0x4D36BB0", VA = "0x184D37FB0", Slot = "10")]
		protected override bool PIJFIILMJEP(IRecRoomQualityConfigProvider GLEMJMFCIMO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x4D37E70", Offset = "0x4D36A70", VA = "0x184D37E70", Slot = "8")]
		protected override bool IAHGPCIKIOF(bool FFFAPMFIAMA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x4D38000", Offset = "0x4D36C00", VA = "0x184D38000")]
		public SetActiveBasedOnDepthSamplingSupport()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public class SetActiveBasedOnLightingType : QualityBasedActivationController<LightRenderingMode>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		[SerializeField]
		private LightRenderingMode enabledForLightingType;

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x4D38050", Offset = "0x4D36C50", VA = "0x184D38050", Slot = "10")]
		protected override LightRenderingMode PIJFIILMJEP(IRecRoomQualityConfigProvider GLEMJMFCIMO)
		{
			return default(LightRenderingMode);
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x4D38040", Offset = "0x4D36C40", VA = "0x184D38040", Slot = "8")]
		protected override bool IAHGPCIKIOF(LightRenderingMode FFFAPMFIAMA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x4D380B0", Offset = "0x4D36CB0", VA = "0x184D380B0")]
		public SetActiveBasedOnLightingType()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public class SetActiveBasedOnSceneDecorationDetailLevel : QualityBasedActivationController<SceneDecorationDetailLevel>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		[SerializeField]
		private SceneDecorationDetailLevel sceneDecorationDetail;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		[SerializeField]
		private bool activeBelowThreshold;

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x4D38110", Offset = "0x4D36D10", VA = "0x184D38110", Slot = "10")]
		protected override SceneDecorationDetailLevel PIJFIILMJEP(IRecRoomQualityConfigProvider GLEMJMFCIMO)
		{
			return default(SceneDecorationDetailLevel);
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x4D380F0", Offset = "0x4D36CF0", VA = "0x184D380F0", Slot = "8")]
		protected override bool IAHGPCIKIOF(SceneDecorationDetailLevel FFFAPMFIAMA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x4D38160", Offset = "0x4D36D60", VA = "0x184D38160")]
		public SetActiveBasedOnSceneDecorationDetailLevel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class SetActiveBasedOnTransparencyDetailLevel : QualityBasedActivationController<TransparencyDetailLevel>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		[SerializeField]
		private TransparencyDetailLevel transparencyDetailThreshold;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		[SerializeField]
		private bool activeBelowThreshold;

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x4D381C0", Offset = "0x4D36DC0", VA = "0x184D381C0", Slot = "10")]
		protected override TransparencyDetailLevel PIJFIILMJEP(IRecRoomQualityConfigProvider GLEMJMFCIMO)
		{
			return default(TransparencyDetailLevel);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x4D381A0", Offset = "0x4D36DA0", VA = "0x184D381A0", Slot = "8")]
		protected override bool IAHGPCIKIOF(TransparencyDetailLevel FFFAPMFIAMA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x4D38210", Offset = "0x4D36E10", VA = "0x184D38210")]
		public SetActiveBasedOnTransparencyDetailLevel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class SetComponentsActiveBasedOnBackgroundAnimationDetailLevel : ActivationController<BackgroundAnimationDetailLevel>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public BackgroundAnimationDetailLevel MinimumSupportedDetail;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public Behaviour[] components;

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x4D38340", Offset = "0x4D36F40", VA = "0x184D38340", Slot = "8")]
		protected override bool IAHGPCIKIOF(BackgroundAnimationDetailLevel NNJBJHGKCFP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x4D383D0", Offset = "0x4D36FD0", VA = "0x184D383D0", Slot = "9")]
		protected override void NOBLIJFPOFL(bool MDJKNJEHJDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x4D38250", Offset = "0x4D36E50", VA = "0x184D38250")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x4D38460", Offset = "0x4D37060", VA = "0x184D38460")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x4D38550", Offset = "0x4D37150", VA = "0x184D38550")]
		public SetComponentsActiveBasedOnBackgroundAnimationDetailLevel()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[RequireComponent(typeof(Terrain))]
	public class TerrainQualitySettings : ActivationController<TerrainQualityLevel>
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000021")]
		public class Settings
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			public TerrainQualityLevel TerrainQualitySetting;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			public float PixelError;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			public float DetailDistance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			[Range(0f, 1f)]
			public float DetailDensity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000AC")]
			public TreePrefabOverride[] TreePrefabOverrides;

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
			public Settings()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000022")]
		public struct TreePrefabOverride
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AD")]
			public GameObject DefaultTree;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000AE")]
			public GameObject OverrideTree;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public float DefaultPixelError;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public float DefaultDetailDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public float DefaultDetailDensity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public Settings[] QualitySettingOverrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private Terrain CDMLANPEIOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private TerrainData CONNMHOOEOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private TerrainData KGJMAOMLGCP;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		private Terrain FAPKNPNBKLL
		{
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x4D38730", Offset = "0x4D37330", VA = "0x184D38730")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x4D38690", Offset = "0x4D37290", VA = "0x184D38690")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x4D38E90", Offset = "0x4D37A90", VA = "0x184D38E90")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x4D38D70", Offset = "0x4D37970", VA = "0x184D38D70")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x4D38D60", Offset = "0x4D37960", VA = "0x184D38D60")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x4D38BF0", Offset = "0x4D377F0", VA = "0x184D38BF0")]
		private void LMFMPINKDNK(DNJFLHPLIAG CKBALGBMEPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x4D39040", Offset = "0x4D37C40", VA = "0x184D39040", Slot = "7")]
		public override void SetActivation(TerrainQualityLevel APLJAFOFLCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x577CA0", Offset = "0x5768A0", VA = "0x180577CA0", Slot = "8")]
		protected override bool IAHGPCIKIOF(TerrainQualityLevel NNJBJHGKCFP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x54FB30", Offset = "0x54E730", VA = "0x18054FB30", Slot = "9")]
		protected override void NOBLIJFPOFL(bool NKMOCOELLNH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x4D387C0", Offset = "0x4D373C0", VA = "0x184D387C0")]
		private void CNLFMOPOCCP(Settings EFKKMEBLMNM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x4D38920", Offset = "0x4D37520", VA = "0x184D38920")]
		private void KLPGANIKAAL(TreePrefabOverride[] COPLAGONJMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x4D38840", Offset = "0x4D37440", VA = "0x184D38840")]
		private void DPGNAIMDKLJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x4D38CE0", Offset = "0x4D378E0", VA = "0x184D38CE0")]
		private Settings MCELIPOAMJK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x4D392B0", Offset = "0x4D37EB0", VA = "0x184D392B0")]
		public TerrainQualitySettings()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public interface HEKEFOBNBJL
{
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void TrySetDefaultRGBColor(Color PNDHCEJAEEO);
}
namespace RecRoom.Core.Creation.SceneMoods
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public class BackgroundObject : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public MeshRenderer[] coloredRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public bool rotateWithSun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private List<Material> AHADHEMLPON;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public BackgroundObject IGPNCEKPKMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x553080", Offset = "0x551C80", VA = "0x180553080")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x556460", Offset = "0x555060", VA = "0x180556460")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x4D311F0", Offset = "0x4D2FDF0", VA = "0x184D311F0")]
		public void Init(BackgroundObject HKKCOGKDLEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x4D31440", Offset = "0x4D30040", VA = "0x184D31440")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x4D31560", Offset = "0x4D30160", VA = "0x184D31560")]
		public void SetBlendValue(float DDJNAOHPHPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x4D316C0", Offset = "0x4D302C0", VA = "0x184D316C0")]
		public void SetColor(Color PNDHCEJAEEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x4D317D0", Offset = "0x4D303D0", VA = "0x184D317D0")]
		public void SetRotation(float BLNKJFCBDII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x4D319C0", Offset = "0x4D305C0", VA = "0x184D319C0")]
		public BackgroundObject()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public interface BHDJECJCCMP
{
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface LMKDMKILHNC<T> : BHDJECJCCMP
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	bool EMDEHIKAHIN
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void SetActivation(T NNJBJHGKCFP);
}
namespace RecRoom.Core.Platforms
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public abstract class ActivationController : MonoBehaviour, BHDJECJCCMP
	{
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		public enum EJMMOKJADLB
		{
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			DoNothing,
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			EnableIfAllowed,
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			EnableAlways
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		[SerializeField]
		[JCANANIELGD("OnSceneOrPrefabSaveBehavior", 1)]
		private bool allowSaveAsDisabled;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		protected virtual EJMMOKJADLB HKFONDOBJLE
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x55F6D0", Offset = "0x55E2D0", VA = "0x18055F6D0", Slot = "4")]
			get
			{
				return default(EJMMOKJADLB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x54FA60", Offset = "0x54E660", VA = "0x18054FA60")]
		protected ActivationController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public abstract class ActivationController<T> : ActivationController, global::LMKDMKILHNC<T>, BHDJECJCCMP where T : IConvertible
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		protected bool? OOMFBHLAEME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		protected T BDFNJOPHIOF;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool EMDEHIKAHIN
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x3368EF0", Offset = "0x3367AF0", VA = "0x183368EF0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x3368B60", Offset = "0x3367760", VA = "0x183368B60", Slot = "7")]
		public virtual void SetActivation(T NNJBJHGKCFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "8")]
		protected abstract bool IAHGPCIKIOF(T NNJBJHGKCFP);

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "9")]
		protected abstract void NOBLIJFPOFL(bool NKMOCOELLNH);

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x270F2C0", Offset = "0x270DEC0", VA = "0x18270F2C0")]
		protected ActivationController()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class DFHLNHOECAE
{
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private static byte[] BPCJOEHDNHL;

	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private static int JGOMGPKCOBP;

	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private static int EJPBFKNOMCK;

	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private static BigInteger DKHAKAEJLPK;

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
	public DFHLNHOECAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x4D329E0", Offset = "0x4D315E0", VA = "0x184D329E0")]
	private static string ALAJABKKJNA(byte[] JCHDICMDCKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x4D32AE0", Offset = "0x4D316E0", VA = "0x184D32AE0")]
	public static string NBAPPGOEMPA(byte[] GLAICJAMEED, bool NFOOKAPIMMN)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2)]
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
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
