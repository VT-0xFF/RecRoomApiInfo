using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using JetBrains.Annotations;
using RecRoom.Attributes;
using RecRoom.Avatars;
using RecRoom.Avatars.Data.Shared;
using RecRoom.Avatars.Face;
using RecRoom.Core.Studio;
using RecRoom.Logging.Attributes;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;
using Unity.Mathematics;
using Unity.Profiling;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Serialization;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_AvatarRenderingSystems_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Preserve]
	public class LogRegistrationIndex : IMPGLFODBJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6E5A620", Offset = "0x6E59A20", VA = "0x186E5A620", Slot = "4")]
		public override void EMOBGIHOLPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8F0CF0", Offset = "0x8F00F0", VA = "0x1808F0CF0")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public class RecNetCDNAssetReference : AssetReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private RecNetCDNKey key;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override object RuntimeKey
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x8C7DA0", Offset = "0x8C71A0", VA = "0x1808C7DA0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override string AssetGUID
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x6E5D130", Offset = "0x6E5C530", VA = "0x186E5D130", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6E5D050", Offset = "0x6E5C450", VA = "0x186E5D050", Slot = "17")]
		public override bool RuntimeKeyIsValid()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6E5D0F0", Offset = "0x6E5C4F0", VA = "0x186E5D0F0")]
		public RecNetCDNAssetReference(RecNetCDNKey LDCKBFKFIKC)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class RecNetCDNKey
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public string bundleUrl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public string itemPath;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public List<RecNetCDNKey> Dependencies;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public string UniqueItemIdentifier
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x8C7980", Offset = "0x8C6D80", VA = "0x1808C7980")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x8C7990", Offset = "0x8C6D90", VA = "0x1808C7990")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public string CacheHash
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x8C7960", Offset = "0x8C6D60", VA = "0x1808C7960")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x8C7DD0", Offset = "0x8C71D0", VA = "0x1808C7DD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6E5D170", Offset = "0x6E5C570", VA = "0x186E5D170")]
		public static RecNetCDNKey DNDAIJBJJGN(string OGKODNIKDAJ, string OONLBMMIMIM = "")
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x660E890", Offset = "0x660DC90", VA = "0x18660E890")]
		public void OIHDKFBJLHF(string GNLLIANIPLI, string GKJBBOELMJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6E5D270", Offset = "0x6E5C670", VA = "0x186E5D270")]
		public RecNetCDNKey()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[GFHMGJFENGN]
public class MLOBKEODGIF : OLKDEJHCEBA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	protected readonly List<Mesh> MAFGMBPJPCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	protected readonly List<byte[]> FKGKFONINJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	protected readonly List<Matrix4x4> JJPKKNNIDLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	protected readonly List<bool> ICIJEFNHPBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	protected readonly List<int> IPLNANJABNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	protected readonly List<bool> DPGBIKJBNAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	protected readonly List<int> ANMAABJMJLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	protected Allocator IBAKBPBLFMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	protected PFKOJMLNIIH OHOHDALFJPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	protected byte GEOFOLDGJJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	protected IList<int> DIOLHDKDNIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	protected IList<int> NLKHJEGCEIJ;

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6E5A6B0", Offset = "0x6E59AB0", VA = "0x186E5A6B0", Slot = "4")]
	public void BGLDCBDOKKD(Mesh DFFOPHDLMNO, Matrix4x4 ABONPPAKJEF, byte[] LCCDEJPLMLE, bool KOCLJANCGAD = false, IBBAPAKLKFF.JPAHGGFNNNL PGJNHPHAFJO = (IBBAPAKLKFF.JPAHGGFNNNL)0, int GOJDHBJNJBL = -1, bool JIGIDJKKACP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6E5AB20", Offset = "0x6E59F20", VA = "0x186E5AB20", Slot = "5")]
	public void MFKJBIJHOOK(Allocator MEFLJHAPKJF, PFKOJMLNIIH NALGFAKHAFL, byte CBFLFGIPIGC, [Optional] IList<int> JLIOANDMMEL, [Optional] IList<int> EBLGMCKCCCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6E5A8C0", Offset = "0x6E59CC0", VA = "0x186E5A8C0")]
	private static void JJPAKBMBOPF(Mesh DFFOPHDLMNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6E5AB60", Offset = "0x6E59F60", VA = "0x186E5AB60")]
	public MLOBKEODGIF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[GFHMGJFENGN]
public struct NFGFENGNADB : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	[ReadOnly]
	public AHIDMKEGMDF HOEIPNIFPJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	[ReadOnly]
	public int MKBACEGHBHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public IJOMOALBFFG OAGHMHLKOJA;

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6E5AFD0", Offset = "0x6E5A3D0", VA = "0x186E5AFD0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[GFHMGJFENGN]
[NativeContainer]
public struct IJOMOALBFFG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct IAGLKHEEIDN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public Vector3 ECIPPKKIGOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public Vector3 ADDIIGBEIBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public Vector4 DKOKMOABENA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct JAGFNALINAN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public float MIIOFCBJABM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public float INLJKEJFMEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public float CIKDOOBEPOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public float OPCCIMLOJKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public byte BCNJIPLBKIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public byte JNFGLJADFHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public byte EOBPOLACIIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public byte HBDOAICJJLF;
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct FLGKNKPOAIO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public half MIIOFCBJABM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public half INLJKEJFMEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public half CIKDOOBEPOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public half OPCCIMLOJKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public byte BCNJIPLBKIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public byte JNFGLJADFHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public byte EOBPOLACIIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public byte HBDOAICJJLF;
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct LMABJIJJPAC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public half4 IGJDLCJEHCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public half2 CJIEOECNIJC;
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct GGJGMCNDNJH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public half4 IGJDLCJEHCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public half2 CJIEOECNIJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public half2 FDIHAGOOMEL;
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public struct LMHEHLFLKLI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public half4 IGJDLCJEHCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public half2 CJIEOECNIJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public half2 FDIHAGOOMEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public half2 DPKBHAAPOBM;
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct KJMJKJGNEOA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public half4 IGJDLCJEHCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public half2 CJIEOECNIJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public half2 FDIHAGOOMEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public half2 DPKBHAAPOBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public half2 MPNCCNAJIKC;
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public struct FNDHDIAMPLD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public float MIIOFCBJABM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public float INLJKEJFMEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public float CIKDOOBEPOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public float OPCCIMLOJKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public int BCNJIPLBKIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public int JNFGLJADFHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public int EOBPOLACIIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public int HBDOAICJJLF;
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public struct PDEPAPEJNEA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public Color IGJDLCJEHCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public Vector2 CJIEOECNIJC;
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public struct ICFPPJKHAOF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public Color IGJDLCJEHCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public Vector2 CJIEOECNIJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public Vector2 FDIHAGOOMEL;
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public struct JJDBMJCBBOH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public Color IGJDLCJEHCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public Vector2 CJIEOECNIJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public Vector2 FDIHAGOOMEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public Vector2 DPKBHAAPOBM;
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public struct AGIOHADOBMA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public Color IGJDLCJEHCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Vector2 CJIEOECNIJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public Vector2 FDIHAGOOMEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public Vector2 DPKBHAAPOBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Vector2 MPNCCNAJIKC;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private bool NJIEPANOEMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public NativeArray<IAGLKHEEIDN> COPOOINLHIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public NativeArray<LMABJIJJPAC> GNAKEGDCPKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public NativeArray<GGJGMCNDNJH> GKPLBEODIEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public NativeArray<LMHEHLFLKLI> LKHAMBIDPLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public NativeArray<KJMJKJGNEOA> OCJOANHKBAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public NativeArray<FLGKNKPOAIO> MDOMOCOJDHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public NativeArray<JAGFNALINAN> PKDOLNOEGON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public NativeArray<PDEPAPEJNEA> BDGHHMHNJCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public NativeArray<ICFPPJKHAOF> IIGLJPGGFPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public NativeArray<JJDBMJCBBOH> MPLABAIPNPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public NativeArray<AGIOHADOBMA> ICOKNJGKJBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public NativeArray<FNDHDIAMPLD> EODMBPDKPLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public NativeArray<int> IEBNCFKAEFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public NativeArray<int> BGFCJINGKMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private NativeArray<int> IKOIJEJNNAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private NativeArray<int> KKLHKJJKJGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public NativeArray<int> BOJAJFIIJKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public NativeArray<int> PCLHGDIKKKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public NativeArray<int> PPFIAFJLBDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public NativeArray<BoneWeight> JDDKMDOGDNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private NativeArray<int> OKAMEPDCJCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private bool AFIAAKPBIKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x159")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private bool AIJNEPHAKLO;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int PJPHKLOBMDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6E57F80", Offset = "0x6E57380", VA = "0x186E57F80")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6E56880", Offset = "0x6E55C80", VA = "0x186E56880")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int MJAEICLAMJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6E56890", Offset = "0x6E55C90", VA = "0x186E56890")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6E57F70", Offset = "0x6E57370", VA = "0x186E57F70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int JBFALKAKNFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6E57F60", Offset = "0x6E57360", VA = "0x186E57F60")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6E563E0", Offset = "0x6E557E0", VA = "0x186E563E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int OMFIGFHINIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6E56BE0", Offset = "0x6E55FE0", VA = "0x186E56BE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6E58740", Offset = "0x6E57B40", VA = "0x186E58740")]
	public IJOMOALBFFG(int KFMOBELLJBM, int FOLNFHDJIBA, int PLEBKHGPNKF, int JAAPMADAGKC, Allocator MEFLJHAPKJF, int DLKGKOAHJFA, HJGINDPFFLG NKNPGMMLHBM, bool AFIAAKPBIKM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6E57BA0", Offset = "0x6E56FA0", VA = "0x186E57BA0")]
	public void HPALFFHHPJP(int IIACLAMOIEE, Vector3 LLKDJGHBOID, Vector3 NKCIADHLFMI, Vector4 OPGNNMINDKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6E563F0", Offset = "0x6E557F0", VA = "0x186E563F0")]
	public void AMFFEACCBEN(int IIACLAMOIEE, BoneWeight FGLLIFMAIPJ, NativeSlice<byte> LCCDEJPLMLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6E57C30", Offset = "0x6E57030", VA = "0x186E57C30")]
	public Color JAHOPEPECPA(int IIACLAMOIEE)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6E57F90", Offset = "0x6E57390", VA = "0x186E57F90")]
	public void NMGMAFPFPLJ(int IIACLAMOIEE, Color DGDCPDOCKCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6E58390", Offset = "0x6E57790", VA = "0x186E58390")]
	public void PNEAEAGNBMJ(byte MKPOIMOOAOL, int IIACLAMOIEE, Vector2 PFEJFGPJOLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6E56B00", Offset = "0x6E55F00", VA = "0x186E56B00")]
	public void FGDKJMJMJAH(int IIACLAMOIEE, int BCCLADJEMOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6E56820", Offset = "0x6E55C20", VA = "0x186E56820")]
	public bool BLMLNNDNDML(int MKPOIMOOAOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6E56B10", Offset = "0x6E55F10", VA = "0x186E56B10")]
	public void FLDPFMMPMAA(int EEHEINNHDOC, int LHBPAMEKCBO, int OIPEPMJNPGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6E568A0", Offset = "0x6E55CA0", VA = "0x186E568A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6E56C50", Offset = "0x6E56050", VA = "0x186E56C50")]
	public Mesh FPDFCEGKPNE([Optional] string GEFCLEKKGCD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[NativeContainer]
[DefaultMember("Item")]
[GFHMGJFENGN]
public struct AHIDMKEGMDF : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public Mesh.MeshDataArray PEODDALKMBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public NativeArray<int> KEEFJPKOHMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public NativeArray<int> GPNMFNBMCPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public NativeArray<BoneWeight> JDDKMDOGDNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private NativeArray<Matrix4x4> LCHHGPMJEEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private NativeArray<int> MCDFCLNKPII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private NativeArray<byte> DIFODJCOECF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private NativeArray<int> EOEJGABOIDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private NativeArray<int> EHBCAOFAEMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public NativeArray<sbyte> PCNJEBIGHIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public NativeArray<byte> GJKIGJECHHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public NativeArray<bool> JIGIDJKKACP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public NativeArray<int> GOJDHBJNJBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private bool AFIAAKPBIKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private NativeArray<int> NKPBNLBFJEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private bool AIJNEPHAKLO;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public int OPMLNMGIJKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x6E46A60", Offset = "0x6E45E60", VA = "0x186E46A60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int BEHFMOPAIKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6E46A70", Offset = "0x6E45E70", VA = "0x186E46A70")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int CONHCLAFGLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6E46970", Offset = "0x6E45D70", VA = "0x186E46970")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int DFPGJJOIIOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6E46950", Offset = "0x6E45D50", VA = "0x186E46950")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6E46A80", Offset = "0x6E45E80", VA = "0x186E46A80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int PJPHKLOBMDP
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6E46A40", Offset = "0x6E45E40", VA = "0x186E46A40")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6E46480", Offset = "0x6E45880", VA = "0x186E46480")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int PCJMCGMHAKA
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6E46470", Offset = "0x6E45870", VA = "0x186E46470")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x6E46490", Offset = "0x6E45890", VA = "0x186E46490")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public PFKOJMLNIIH PPMEEHIIMDB
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x6E46610", Offset = "0x6E45A10", VA = "0x186E46610")]
		get
		{
			return default(PFKOJMLNIIH);
		}
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x6E46A50", Offset = "0x6E45E50", VA = "0x186E46A50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public byte LNBNDBJHMEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6E46960", Offset = "0x6E45D60", VA = "0x186E46960")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6E466F0", Offset = "0x6E45AF0", VA = "0x186E466F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public LCPICCPJHJC EEEHKFENLEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6E46700", Offset = "0x6E45B00", VA = "0x186E46700")]
		get
		{
			return default(LCPICCPJHJC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6E46A90", Offset = "0x6E45E90", VA = "0x186E46A90")]
	public AHIDMKEGMDF(IList<Mesh> CBPBGCLDGGO, IList<Matrix4x4> LDJACKPOOFG, IList<bool> JIGIDJKKACP, byte CBFLFGIPIGC, IList<byte[]> JFJIHGPKJFN, IList<int> HAJHICHLDFO, IList<bool> HAHNKMFGDNJ, IList<int> GOJDHBJNJBL, IList<int> JLIOANDMMEL, IList<int> CCIIJNBLCAJ, Allocator MEFLJHAPKJF, PFKOJMLNIIH NALGFAKHAFL, bool AFIAAKPBIKM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6E46620", Offset = "0x6E45A20", VA = "0x186E46620")]
	public IJOMOALBFFG FNGCLCGPAJO(Allocator MEFLJHAPKJF, HJGINDPFFLG NKNPGMMLHBM)
	{
		return default(IJOMOALBFFG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6E464A0", Offset = "0x6E458A0", VA = "0x186E464A0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[GFHMGJFENGN]
public class DIJPMBFICNN : MLOBKEODGIF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public bool JIOMAOBIBBH;

	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private static readonly ProfilerMarker BPALHHEKOFB;

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6E55B00", Offset = "0x6E54F00", VA = "0x186E55B00")]
	public AHIDMKEGMDF PJAJGILGDNA()
	{
		return default(AHIDMKEGMDF);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6E55E00", Offset = "0x6E55200", VA = "0x186E55E00")]
	public DIJPMBFICNN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct LCPICCPJHJC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public Mesh.MeshData LDFPKKBJFIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public NativeSlice<BoneWeight> JDDKMDOGDNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public NativeSlice<byte> BGIFBFJOHBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public int HBACABBHKHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public Matrix4x4 MNDDFLDFHKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public int DNMJFODFMIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public NativeSlice<byte> LCCDEJPLMLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public bool NMIPPECKMCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public int CKCLHOHLJDJ;
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class AvatarElbowBendHelperController : MonoBehaviour, POJABNNNJLM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		[SerializeField]
		[KAIMDEABLJJ(PGGKFLBMAKK.Self, false, false, false)]
		private Transform ElbowHelperBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		[SerializeField]
		private Transform UpperArmBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		[SerializeField]
		private Transform LowerArmBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		[SerializeField]
		private float MinAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		[SerializeField]
		private float MaxAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		[Header("Scale")]
		[FormerlySerializedAs("MinScaleValues")]
		[SerializeField]
		private Vector3 ScaleValuesAtMinAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		[SerializeField]
		[FormerlySerializedAs("MaxScaleValues")]
		private Vector3 ScaleValuesAtMaxAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		[Header("Positional Offset")]
		[FormerlySerializedAs("MinLocalPositionalOffset")]
		[SerializeField]
		private Vector3 PositionalOffsetAtMinAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		[FormerlySerializedAs("MaxLocalPositionOffset")]
		[SerializeField]
		private Vector3 PositionalOffsetAtMaxAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private Vector3? LLCCLJDIFNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private bool IIOJAGFOMAH;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x6E47C20", Offset = "0x6E47020", VA = "0x186E47C20", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x6E48240", Offset = "0x6E47640", VA = "0x186E48240", Slot = "4")]
		public void UpdateController(float GNOIEGLKNOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0xA34A40", Offset = "0xA33E40", VA = "0x180A34A40", Slot = "6")]
		public void SetEnabled(bool HCPAOILCJCB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x6E47D00", Offset = "0x6E47100", VA = "0x186E47D00")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x6E48700", Offset = "0x6E47B00", VA = "0x186E48700")]
		public AvatarElbowBendHelperController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class AvatarElbowBendTargetController : MonoBehaviour, POJABNNNJLM
	{
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private const float JIJNKIPPMAB = 45f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		[SerializeField]
		[KAIMDEABLJJ(PGGKFLBMAKK.Self, false, false, false)]
		private Transform ElbowBendTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		[SerializeField]
		private Transform NeckBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		[SerializeField]
		private Transform UpperArmBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		[SerializeField]
		private Transform HandBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		[SerializeField]
		private bool Left;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		[SerializeField]
		private float MinTwist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		[SerializeField]
		private float MaxTwist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		[SerializeField]
		private float TwistWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		[SerializeField]
		private float ElbowSmoothTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		[SerializeField]
		private float RestTwist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		[SerializeField]
		private float RestTwistWhenClose;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		[SerializeField]
		private float RestTwistDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private Vector3 BMNEHNFALML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private Vector3 GJFJGIFMMPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private bool IIOJAGFOMAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private float NMDFMKBMPAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private float GDIPCIMHPBF;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x6E48A80", Offset = "0x6E47E80", VA = "0x186E48A80", Slot = "4")]
		public void UpdateController(float GNOIEGLKNOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xD1F730", Offset = "0xD1EB30", VA = "0x180D1F730", Slot = "6")]
		public void SetEnabled(bool HCPAOILCJCB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6E487A0", Offset = "0x6E47BA0", VA = "0x186E487A0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6E49540", Offset = "0x6E48940", VA = "0x186E49540")]
		public AvatarElbowBendTargetController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class AvatarForearmRollController : MonoBehaviour, POJABNNNJLM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		[SerializeField]
		private Transform TwistBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		[SerializeField]
		private Transform HandBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		[SerializeField]
		private Transform LowerArmTwistBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		[SerializeField]
		private Transform UpperArmTwistBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		[SerializeField]
		private Transform ElbowTwistBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		[SerializeField]
		private float RollTowardsWristAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		[SerializeField]
		private float RollSoftMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		[SerializeField]
		private float RollSoftMax;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		[SerializeField]
		private float LowerArmTwistAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		[SerializeField]
		private float UpperArmTwistAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		[SerializeField]
		private float ElbowTwistAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private float NMDFMKBMPAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private bool IIOJAGFOMAH;

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6E49570", Offset = "0x6E48970", VA = "0x186E49570", Slot = "4")]
		public void UpdateController(float GNOIEGLKNOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x11C9A10", Offset = "0x11C8E10", VA = "0x1811C9A10", Slot = "6")]
		public void SetEnabled(bool HCPAOILCJCB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6E49FF0", Offset = "0x6E493F0", VA = "0x186E49FF0")]
		public AvatarForearmRollController()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class CPNADMDACOD : BIPIJKDNBKE
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	private abstract class OEMBNNIKJFA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public readonly HAPHCDJNHOG IHKKAGFPMDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		protected bool NMFAIFPCJBI;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool ILNFCODDIJI
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x9617B0", Offset = "0x960BB0", VA = "0x1809617B0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x96FE20", Offset = "0x96F220", VA = "0x18096FE20")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public bool JKEGDJCIDDN
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0xF5E030", Offset = "0xF5D430", VA = "0x180F5E030")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0xF5E020", Offset = "0xF5D420", VA = "0x180F5E020")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public virtual IBBAPAKLKFF.JPAHGGFNNNL DNMJFODFMIN
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0xA9C950", Offset = "0xA9BD50", VA = "0x180A9C950", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(IBBAPAKLKFF.JPAHGGFNNNL);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0xA9C960", Offset = "0xA9BD60", VA = "0x180A9C960", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public bool MIBELCCPDOI
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x96F830", Offset = "0x96EC30", VA = "0x18096F830")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public bool KJFEKEKJIBG
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x19A2250", Offset = "0x19A1650", VA = "0x1819A2250")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public bool BDKPACNNDEF
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x6E5CFF0", Offset = "0x6E5C3F0", VA = "0x186E5CFF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool GLHKABLPECA
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x6E5D000", Offset = "0x6E5C400", VA = "0x186E5D000")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x6E5D020", Offset = "0x6E5C420", VA = "0x186E5D020")]
		protected OEMBNNIKJFA(HAPHCDJNHOG LKBMPHHJDGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract CLHPIMOBJFN AJOOIBLMDPG(List<KMJKLFGFJJB> HEJEHEAIAKG, List<KMJKLFGFJJB> DCECOKJEMKM);

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract APBDOJKLLPH JCHJEMKBNHO(uint JGOIAEJPNGK, AvatarSkinnedMeshBoneOrderRemapsData JCEGLOFLGDG);
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	private class ABCLLIBKMMP : OEMBNNIKJFA
	{
		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class NJFNBGDFMGH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000107")]
			public PLBFKJMGACI<GameObject> skinAvatarItemPrefabHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000108")]
			public ABCLLIBKMMP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000109")]
			public Action<string> <>9__1;

			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
			public NJFNBGDFMGH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x6E5CAB0", Offset = "0x6E5BEB0", VA = "0x186E5CAB0")]
			internal void CBKIDPELFDK(GameObject result)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x6E5CEB0", Offset = "0x6E5C2B0", VA = "0x186E5CEB0")]
			internal void OPGMJDKMCDK(string error)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private readonly AvatarSkinAssetItem.GJDKIDCMJGA PJJOAAJMCLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private readonly AssetReference NOINAIPCABC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private readonly DPJDJGPLJGE? AOJJAJDKDBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		private readonly Material[] AHMBCDGKBNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private SkinnedMeshRenderer[] FDIFKKLGOAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private AvatarSkinAssetItem LFADCEJFEEN;

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public override IBBAPAKLKFF.JPAHGGFNNNL DNMJFODFMIN
		{
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x968260", Offset = "0x967660", VA = "0x180968260", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(IBBAPAKLKFF.JPAHGGFNNNL);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x96FA40", Offset = "0x96EE40", VA = "0x18096FA40", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x6E46230", Offset = "0x6E45630", VA = "0x186E46230")]
		public ABCLLIBKMMP(AvatarSkinAssetItem.GJDKIDCMJGA KJJIHLBEEEG, AssetReference IFDPCDJOJOO, Material OKFLDPLMBEI, HAPHCDJNHOG JBCPDKGINNI, IBBAPAKLKFF.JPAHGGFNNNL EOEFINIJEJD = (IBBAPAKLKFF.JPAHGGFNNNL)0, [Optional] DPJDJGPLJGE? ECDKKILMJJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x6E46350", Offset = "0x6E45750", VA = "0x186E46350")]
		public ABCLLIBKMMP(AvatarSkinAssetItem.GJDKIDCMJGA KJJIHLBEEEG, AssetReference IFDPCDJOJOO, Material OKFLDPLMBEI, IBBAPAKLKFF.JPAHGGFNNNL EOEFINIJEJD = (IBBAPAKLKFF.JPAHGGFNNNL)0, [Optional] DPJDJGPLJGE? ECDKKILMJJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x6E45D20", Offset = "0x6E45120", VA = "0x186E45D20", Slot = "6")]
		public override CLHPIMOBJFN AJOOIBLMDPG(List<KMJKLFGFJJB> HEJEHEAIAKG, List<KMJKLFGFJJB> DCECOKJEMKM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x6E45EF0", Offset = "0x6E452F0", VA = "0x186E45EF0", Slot = "7")]
		public override APBDOJKLLPH JCHJEMKBNHO(uint JGOIAEJPNGK, AvatarSkinnedMeshBoneOrderRemapsData JCEGLOFLGDG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x6E461C0", Offset = "0x6E455C0", VA = "0x186E461C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	private class LPIAIEPAPDE : OEMBNNIKJFA
	{
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		[CompilerGenerated]
		private sealed class NAFMJHODFPK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000111")]
			public LPIAIEPAPDE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000112")]
			public List<KMJKLFGFJJB> prefabHandles;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000113")]
			public List<KMJKLFGFJJB> materialHandles;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000114")]
			public PLBFKJMGACI<Material[]> loadMaterialsHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000115")]
			public PLBFKJMGACI<FEKKKGIMDBJ> loadPrefabHandle;

			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
			public NAFMJHODFPK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x6E5AD90", Offset = "0x6E5A190", VA = "0x186E5AD90")]
			internal CLHPIMOBJFN OPGMJDKMCDK(string error)
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public FMNHOILILHF HKGDOKEOJPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public FEKKKGIMDBJ JHBCBPAJBNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private PLBFKJMGACI<FEKKKGIMDBJ> LIAGLPFGICD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private PLBFKJMGACI<Material[]> CEMCDNPKHFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public Material[] CIIJMBGOJBL;

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public bool DKAHJFAGNIE
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0xA02880", Offset = "0xA01C80", VA = "0x180A02880")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0xA02750", Offset = "0xA01B50", VA = "0x180A02750")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public IBBAPAKLKFF.JPAHGGFNNNL GDIAPJPBLIJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0xCF6F40", Offset = "0xCF6340", VA = "0x180CF6F40")]
			[CompilerGenerated]
			get
			{
				return default(IBBAPAKLKFF.JPAHGGFNNNL);
			}
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0xF464D0", Offset = "0xF458D0", VA = "0x180F464D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x6E5A570", Offset = "0x6E59970", VA = "0x186E5A570")]
		public LPIAIEPAPDE(HAPHCDJNHOG LKBMPHHJDGE, FMNHOILILHF BPNJHOLHOJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x6E593E0", Offset = "0x6E587E0", VA = "0x186E593E0", Slot = "6")]
		public override CLHPIMOBJFN AJOOIBLMDPG(List<KMJKLFGFJJB> HEJEHEAIAKG, List<KMJKLFGFJJB> DCECOKJEMKM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x6E59EB0", Offset = "0x6E592B0", VA = "0x186E59EB0")]
		public CLHPIMOBJFN JOPFLAJAGGJ(List<KMJKLFGFJJB> HEJEHEAIAKG, List<KMJKLFGFJJB> DCECOKJEMKM, PLBFKJMGACI<Material[]> CEMCDNPKHFK, PLBFKJMGACI<FEKKKGIMDBJ> KOPGHHNAHLH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x6E5A1B0", Offset = "0x6E595B0", VA = "0x186E5A1B0")]
		public (PLBFKJMGACI<Material[]>, PLBFKJMGACI<FEKKKGIMDBJ>) LJJNKKALGGB(List<KMJKLFGFJJB> HEJEHEAIAKG, List<KMJKLFGFJJB> DCECOKJEMKM)
		{
			return default((PLBFKJMGACI<Material[]>, PLBFKJMGACI<FEKKKGIMDBJ>));
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x6E59D80", Offset = "0x6E59180", VA = "0x186E59D80", Slot = "7")]
		public override APBDOJKLLPH JCHJEMKBNHO(uint JGOIAEJPNGK, AvatarSkinnedMeshBoneOrderRemapsData JCEGLOFLGDG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x6E59B70", Offset = "0x6E58F70", VA = "0x186E59B70")]
		public APBDOJKLLPH HFJEBLEEGBH(GameObject GEDKLECMMOE, uint JGOIAEJPNGK, bool IIEJJDNMDDB, bool EICHNMPLKBL, AvatarSkinnedMeshBoneOrderRemapsData JCEGLOFLGDG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x6E59810", Offset = "0x6E58C10", VA = "0x186E59810")]
		public static bool GDENONEKIJM(Renderer[] KJDELDJCJHB, string ILFHCFFNCJA, [Out] Renderer CLONNLPJIML, [Out] Renderer LOBMEPPCNMK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x6E5A520", Offset = "0x6E59920", VA = "0x186E5A520", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x6E59740", Offset = "0x6E58B40", VA = "0x186E59740")]
		private (PLBFKJMGACI<FEKKKGIMDBJ>, PLBFKJMGACI<Material[]>) FNCBKLIOKDA()
		{
			return default((PLBFKJMGACI<FEKKKGIMDBJ>, PLBFKJMGACI<Material[]>));
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x6E59720", Offset = "0x6E58B20", VA = "0x186E59720")]
		[CompilerGenerated]
		private void EGOGCJKAILJ(FEKKKGIMDBJ CEDDFJCBLGM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x8CAEB0", Offset = "0x8CA2B0", VA = "0x1808CAEB0")]
		[CompilerGenerated]
		private void BGLBAALOCIO(Material[] CEDDFJCBLGM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class LNIBEDEFNOF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public GFPNMGNNANK avatarBuildParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public CPNADMDACOD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public AMMGOODCICE<Dictionary<string, PLBFKJMGACI<Texture2D>>> ugcTextureDictionaryPromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public JNDAODDCIHF buildMeshPromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public Action<KeyValuePair<string, PLBFKJMGACI<Texture2D>>> <>9__17;

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public LNIBEDEFNOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x6E59350", Offset = "0x6E58750", VA = "0x186E59350")]
		internal bool JALHBGCIMHE(FMNHOILILHF item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x6E593A0", Offset = "0x6E587A0", VA = "0x186E593A0")]
		internal void NNLEBCDJPJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x6E593C0", Offset = "0x6E587C0", VA = "0x186E593C0")]
		internal void NOADEBBFLAA(string err)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x6E59170", Offset = "0x6E58570", VA = "0x186E59170")]
		internal void BIHFKFEFOKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x6E59260", Offset = "0x6E58660", VA = "0x186E59260")]
		internal void EEEEMGGPDFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x8C7980", Offset = "0x8C6D80", VA = "0x1808C7980")]
		internal AMMGOODCICE<Dictionary<string, PLBFKJMGACI<Texture2D>>> BOAMGKNFBBI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x6E59290", Offset = "0x6E58690", VA = "0x186E59290")]
		internal void IPNNDBJNLKB(Dictionary<string, PLBFKJMGACI<Texture2D>> resourceHandleDictionary)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x6E591A0", Offset = "0x6E585A0", VA = "0x186E591A0")]
		internal void ECBFIGCBLKF(KeyValuePair<string, PLBFKJMGACI<Texture2D>> kvp)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x8C7960", Offset = "0x8C6D60", VA = "0x1808C7960")]
		internal CLHPIMOBJFN KPDKLKEPOLI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class DBJGLIJBPID
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		public int lowestPossibleLOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		public LNIBEDEFNOF CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public DBJGLIJBPID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x6E55A40", Offset = "0x6E54E40", VA = "0x186E55A40")]
		internal KBALOKDMGKA PJBHJCEMIOF(int lod)
		{
			return default(KBALOKDMGKA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class BAOIJFGIKLN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public List<JNDAODDCIHF> innerPromises;

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public BAOIJFGIKLN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x6E4A020", Offset = "0x6E49420", VA = "0x186E4A020")]
		internal void ECHKAMIKOIK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class EFOJOKCMKKL : IEnumerator<ONHNFKGBFKG>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private ONHNFKGBFKG <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public CPNADMDACOD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public List<OEMBNNIKJFA> parts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public List<JNDAODDCIHF> innerPromises;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public int[] LODs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public bool isFirstPerson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public Func<int, KBALOKDMGKA> getLayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public PNDNHBHPDNO materialPropertyBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public Material materialInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		private int <lodIndex>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		private ONHNFKGBFKG System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x8C7D90", Offset = "0x8C7190", VA = "0x1808C7D90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x8C7D90", Offset = "0x8C7190", VA = "0x1808C7D90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x8CAD70", Offset = "0x8CA170", VA = "0x1808CAD70")]
		[DebuggerHidden]
		public EFOJOKCMKKL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x6E55E10", Offset = "0x6E55210", VA = "0x186E55E10", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x6E56010", Offset = "0x6E55410", VA = "0x186E56010", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class IAOAMEFGEBE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public GJOGJLGKKGK cancelable;

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public IAOAMEFGEBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x9389E0", Offset = "0x937DE0", VA = "0x1809389E0")]
		internal void KNOIBNJAPJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x9389C0", Offset = "0x937DC0", VA = "0x1809389C0")]
		internal void AHGNCBEMIAB(string err)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private sealed class MLJKEBDKEPM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public long jobComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public Stopwatch stopwatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public SkinnedMeshRenderer lodRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public long meshComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public string meshName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public long meshCopyComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public CPNADMDACOD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public int lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public List<Material> newUniqueMaterials;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public int frameStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public long lodBuildStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public long startCombineBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public long jobScheduled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		public Action onFinally;

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public MLJKEBDKEPM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class FHJIGJIMCEP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		public bool waitingForComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public JobHandle lodBuildJobHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public IJOMOALBFFG defaultMeshJobContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		public AHIDMKEGMDF defaultAvatarMeshJobGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public MLJKEBDKEPM CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public FHJIGJIMCEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x6E56060", Offset = "0x6E55460", VA = "0x186E56060")]
		internal void EGGNHBGNGCC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0xDF5E30", Offset = "0xDF5230", VA = "0x180DF5E30")]
		internal void LIEIELEOJIO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class ADCLBFBOKOD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public bool waitingForComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public JobHandle lodBuildJobHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public JPGMLEONDJM legacyMeshJobContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public IDBJHBMHDDD legacyAvatarMeshJobGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public MLJKEBDKEPM CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public ADCLBFBOKOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x6E5DA40", Offset = "0x6E5CE40", VA = "0x186E5DA40")]
		internal void JNEAKJGLMMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0xDF7050", Offset = "0xDF6450", VA = "0x180DF7050")]
		internal void AIABBNPEDCH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class AEGHCJDIIDG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public string overrideItemIdentifier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public HAPHCDJNHOG overrideBodyPart;

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public AEGHCJDIIDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x6E5DCC0", Offset = "0x6E5D0C0", VA = "0x186E5DCC0")]
		internal bool IHJALBLIKKL(KeyValuePair<string, FMNHOILILHF> entry)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private AvatarConfiguration PBKLAHLPMHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private Transform OFLOKKHAEFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private AssetReference NOINAIPCABC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private GameObject OIJPBJKGMEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private GameObject ANJHDNBCMKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private SkinnedMeshRenderer IEJCODAIMHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private AvatarSkinnedMeshBoneOrderRemapsData ECLOOHKBACF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private Transform[] CMAHHOOCLKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private Matrix4x4[] IAPJDMLFKBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private Material OCALEJCHLBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private Material COAHOMDBCEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private Material AMFPNKHPDMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private Shader JLCCNFPMILA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private Shader GDCDKHFAODC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private Animator MDABFEDCJCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private Renderer[] NOFOPEMCNII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private IBBAPAKLKFF.JPAHGGFNNNL PINCAOAPGEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private AvatarBodyPartShapesManager BIBLMPGOBNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private IReadOnlyDictionary<string, Transform> DLMGFMPOLCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private AvatarFaceShapeData.GJJLMEHLBKI HJAFCJBHAJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private AvatarBodyShapeData.FKMGOBJLAAK EPFCHNCLBOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private bool MHNNFKBKFHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB1")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private bool MHCALCFDMED;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private Color JHGKDOEHOEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private Color MNHCIMAAKPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private Color NKELPJHGBGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private Color? HIMDANFGGAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private Color? BHPLMHKFHOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10C")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private Color? OEJOOJJBMLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private Color? PGGPLCAHNMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private Texture2D GBOOCIAMMHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private Texture2D HJMMKMCFDFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	[CanBeNull]
	private FMNHOILILHF JGLJEICIIFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private Texture HMCCFCJFKGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private Color ELPONAIHHNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public Dictionary<Renderer, PNDNHBHPDNO> OBJDLBIGHCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private Dictionary<Renderer, PNDNHBHPDNO> HIICNCAGAFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private Dictionary<string, List<GDOEIOPOLMM>> GDDMMKCCPPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private Dictionary<string, List<GDOEIOPOLMM>> BAFOHKGOECP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private readonly List<KMJKLFGFJJB> DCAAAHNMCGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private readonly List<KMJKLFGFJJB> KPBIIFDAGCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private readonly List<KMJKLFGFJJB> JAHJKNDMCNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private readonly List<KMJKLFGFJJB> AENEPOMHLAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private Dictionary<GDOEIOPOLMM, Material> PAGAEKKHFMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private Dictionary<GDOEIOPOLMM, Material> KMGBMJIFJGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private SkinnedMeshRenderer[] JJMJJJEPDGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private SkinnedMeshRenderer[] OIFDIJDFGDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private SkinnedMeshRenderer[] DECKKGPGEBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private SkinnedMeshRenderer[] BHAPLLPCLOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private readonly Dictionary<string, PLBFKJMGACI<Texture2D>> GOFNEAAEPCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private readonly Dictionary<string, PLBFKJMGACI<Texture2D>> DPMBFOHGFLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private AdditionalHatData AJCJJJONPIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private AdditionalHatData HBELMBBFMJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private HairData HFFEAMNKBIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private HairData LELIEOMGAJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private NBNLNGHNGFL JCKBEKEPELK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private bool? EICKPJOCNKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x214")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private PositionAndRotation AFOGPHGBNDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private Transform AMNJMJGHLHH;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private Material JNIBBGJIBKO;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private Material PANKLCHBBHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private Dictionary<string, FMNHOILILHF> ECPNHEKJJPG;

	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private static readonly int NDNEKOOLKLJ;

	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private static readonly int NPAMKBMIFHD;

	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private static readonly int FCIGODFMFCM;

	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private static readonly int LGECBDPJACJ;

	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private static readonly int LCMDOGINFDM;

	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private static readonly int HLIJEBBMKKN;

	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private static readonly int PDDJJCIBLAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private readonly MIPKPFFHABJ FEFGAOLANJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private readonly MIPKPFFHABJ JGNODOKBMFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private bool FBDHEGMJPAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private List<Action> DONEMCNKKJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private LDNADNDABII MAFCMMOJFON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private SkinnedMeshRenderer[] ODDNBMELPCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private int MNHAIGLAHEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x284")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private bool JIIMHIDGPGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private int DDELMOPNCLM;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public AvatarConfiguration HNBHDFLFLIE
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8C7B90", Offset = "0x8C6F90", VA = "0x1808C7B90", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool CHDENMOBENM
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0xD75B50", Offset = "0xD74F50", VA = "0x180D75B50")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0xD75F30", Offset = "0xD75330", VA = "0x180D75F30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private Material JEPOLIEDKHD
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x6E50990", Offset = "0x6E4FD90", VA = "0x186E50990")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private Material ELNJJAPINEF
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x6E4C660", Offset = "0x6E4BA60", VA = "0x186E4C660")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	private bool BLOFPAADMOE
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x8E1B40", Offset = "0x8E0F40", VA = "0x1808E1B40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public EOPKGKNJKFM EHLHHMKPKAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x93EBD0", Offset = "0x93DFD0", VA = "0x18093EBD0", Slot = "21")]
		get
		{
			return default(EOPKGKNJKFM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public MIPKPFFHABJ FCEAHFLLIGN
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x9EBAA0", Offset = "0x9EAEA0", VA = "0x1809EBAA0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public MIPKPFFHABJ GLIDNNGGEAG
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x9EB9D0", Offset = "0x9EADD0", VA = "0x1809EB9D0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public SkinnedMeshRenderer[] IGMMIDAPLGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x1928880", Offset = "0x1927C80", VA = "0x181928880", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public Renderer[] DHDDBPGBLPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x8CFA20", Offset = "0x8CEE20", VA = "0x1808CFA20", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public bool KGBJIAFHLPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6E4F2E0", Offset = "0x6E4E6E0", VA = "0x186E4F2E0", Slot = "20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public IBBAPAKLKFF.JPAHGGFNNNL NHLALBMDAED
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x8CFB00", Offset = "0x8CEF00", VA = "0x1808CFB00", Slot = "18")]
		get
		{
			return default(IBBAPAKLKFF.JPAHGGFNNNL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int IFLEIGIAMCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x1BCBBD0", Offset = "0x1BCAFD0", VA = "0x181BCBBD0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x6E52210", Offset = "0x6E51610", VA = "0x186E52210")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	private bool IAHJKCONDMI
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x6E54CE0", Offset = "0x6E540E0", VA = "0x186E54CE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	private static bool MFLFAEOICNL
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x90FCA0", Offset = "0x90F0A0", VA = "0x18090FCA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x6E55470", Offset = "0x6E54870", VA = "0x186E55470")]
	public CPNADMDACOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6E54D60", Offset = "0x6E54160", VA = "0x186E54D60", Slot = "29")]
	public void OOJJEJPOBFE(KOOOKPFBECF JDMAODADKII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6E4FE80", Offset = "0x6E4F280", VA = "0x186E4FE80", Slot = "4")]
	public void GONHHJMDKMK(AHLOKNAGOBG NAMHONJCNFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6E52210", Offset = "0x6E51610", VA = "0x186E52210", Slot = "5")]
	public void OBHFKGCFDBO(int JGOIAEJPNGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x6E515B0", Offset = "0x6E509B0", VA = "0x186E515B0", Slot = "10")]
	public void KOPJLMNFOKJ(GIEOMBNNLBI NMDHFEECAKH, Texture2D EPCABFKFFHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x8E1B40", Offset = "0x8E0F40", VA = "0x1808E1B40")]
	public static bool HLNNMHKLFCO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6E51060", Offset = "0x6E50460", VA = "0x186E51060", Slot = "11")]
	public bool JJDJHNKEBEN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6E4B2E0", Offset = "0x6E4A6E0", VA = "0x186E4B2E0", Slot = "9")]
	public void CANPFNGNKKF(OGGFNBOMCOK PBKGBNNFEAK, Color? IGJDLCJEHCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6E50850", Offset = "0x6E4FC50", VA = "0x186E50850")]
	private void HLPMICFICGC(Action OGBBIDLGAGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6E517D0", Offset = "0x6E50BD0", VA = "0x186E517D0", Slot = "6")]
	public void KPBKCBECIKP(FMNHOILILHF ADCDKBJDONE, Texture PIDCFCCGJNN, Color BELPJJANHOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0xD75F30", Offset = "0xD75330", VA = "0x180D75F30", Slot = "7")]
	public void LHECPABOOPP(bool KCDKCAOPAED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0xED2100", Offset = "0xED1500", VA = "0x180ED2100", Slot = "8")]
	public void JCICKIHPODH(LDNADNDABII OKAMEPDCJCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6E533B0", Offset = "0x6E527B0", VA = "0x186E533B0", Slot = "14")]
	public JNDAODDCIHF OHFEDKMGFGM(GFPNMGNNANK BCIDJCFONPA, bool JFPIADMBAJL, int[] AFKFLDLEHCG, Func<Dictionary<string, FMNHOILILHF>, (JNDAODDCIHF, AMMGOODCICE<Dictionary<string, PLBFKJMGACI<Texture2D>>>)> IDAICBCMIBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6E55110", Offset = "0x6E54510", VA = "0x186E55110", Slot = "15")]
	public void PEJIOBKOAAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6E4F8E0", Offset = "0x6E4ECE0", VA = "0x186E4F8E0", Slot = "27")]
	public void FBLEEJACCLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6E4B6F0", Offset = "0x6E4AAF0", VA = "0x186E4B6F0", Slot = "28")]
	public void CCNPPMHAFNF([Optional] NBNLNGHNGFL OGPPAFCOOFN, [Optional] bool? DCDBINAOPIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6E54BA0", Offset = "0x6E53FA0", VA = "0x186E54BA0")]
	private bool OLDFHHDOJCO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6E51590", Offset = "0x6E50990", VA = "0x186E51590", Slot = "19")]
	public bool KOJMEMPACGH(IBBAPAKLKFF.JPAHGGFNNNL OHBHKPKMKCD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6E4C490", Offset = "0x6E4B890", VA = "0x186E4C490")]
	private bool CEOKNKPNDJA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6E4EA40", Offset = "0x6E4DE40", VA = "0x186E4EA40")]
	private JNDAODDCIHF DJADPNFJGNA(bool JFPIADMBAJL, List<OEMBNNIKJFA> KEKHAJLLNEN, int[] AFKFLDLEHCG, Func<int, KBALOKDMGKA> MHJIEJHDMEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6E505E0", Offset = "0x6E4F9E0", VA = "0x186E505E0")]
	[IteratorStateMachine(typeof(EFOJOKCMKKL))]
	private IEnumerator<ONHNFKGBFKG> HFCDMOCNHJM(bool JFPIADMBAJL, List<OEMBNNIKJFA> KEKHAJLLNEN, int[] AFKFLDLEHCG, Func<int, KBALOKDMGKA> MHJIEJHDMEN, PNDNHBHPDNO EJDEBBDCLBH, Material HOJIELBCNNA, List<JNDAODDCIHF> LJNKFHKOFIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6E52550", Offset = "0x6E51950", VA = "0x186E52550")]
	private void ODIMMFJAHII(List<OEMBNNIKJFA> KEKHAJLLNEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6E4F450", Offset = "0x6E4E850", VA = "0x186E4F450")]
	private JNDAODDCIHF EGJBGGHIBCE(List<OEMBNNIKJFA> KEKHAJLLNEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6E4C750", Offset = "0x6E4BB50", VA = "0x186E4C750")]
	private GLHJGEGNDCM CNEOLJFEJKD(List<OEMBNNIKJFA> KEKHAJLLNEN, int JGOIAEJPNGK, bool JFPIADMBAJL, KBALOKDMGKA HOGNIHDLFAI, bool NMBDKJLPAEK, PNDNHBHPDNO EJDEBBDCLBH, Material HOJIELBCNNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6E508D0", Offset = "0x6E4FCD0", VA = "0x186E508D0", Slot = "23")]
	public void IAIIENNAEFO(AvatarFaceShape GGNFBJIMGIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6E4DA30", Offset = "0x6E4CE30", VA = "0x186E4DA30", Slot = "24")]
	public void COKNMKIMIEK(AvatarBodyShape BBCFFNPPDGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6E51D20", Offset = "0x6E51120", VA = "0x186E51D20", Slot = "26")]
	public void MEHLCAJFIJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6E4E0A0", Offset = "0x6E4D4A0", VA = "0x186E4E0A0", Slot = "25")]
	public void DDCPLHOLHGG(bool LAPAKCLPKFA, bool OOGBJCNDKJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6E4A600", Offset = "0x6E49A00", VA = "0x186E4A600")]
	private void AFJKLJFLDNL(SkinnedMeshRenderer IFHCMODCFHN, int JGOIAEJPNGK, Mesh DFFOPHDLMNO, List<Material> LMBCGBKHPOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6E502D0", Offset = "0x6E4F6D0", VA = "0x186E502D0")]
	private static Material HBHHIHKMIOJ(Dictionary<GDOEIOPOLMM, Material> EKNCNMFMFAH, Material ACMOCJHPAPG, NLIABPACMCI COILFOKBAOH, PIABCGLBJDM MMNLEBJJFJM, HAPHCDJNHOG JBCPDKGINNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6E4C550", Offset = "0x6E4B950", VA = "0x186E4C550")]
	private static NLIABPACMCI CFGPFEKJDFM(OEMBNNIKJFA IOCFOFNHLGL, int ENJNOOMIJHL)
	{
		return default(NLIABPACMCI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6E4E210", Offset = "0x6E4D610", VA = "0x186E4E210")]
	private void DGEHKEIAEEI(int PPFEFFLJILL, Material BEDNCOELNMN, OEMBNNIKJFA IOCFOFNHLGL, [Out] Texture2D BJPKOBPINGN, [Out] Vector4 DENKLKFNJOH, [Out] Texture2D HDKNDCCOKJO, [Out] Texture2D DNFBLHPCHBG, [Out] Texture2D DBHFBOKFILI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6E4A150", Offset = "0x6E49550", VA = "0x186E4A150")]
	private void ACLPFIOKFKP(int PPFEFFLJILL, Material BEDNCOELNMN, OEMBNNIKJFA IOCFOFNHLGL, [Out] Color ECAGNHGBBCA, [Out] Color BFAPBFOOOGH, [Out] Color HOGNAKEHJDH, [Out] Color CFHJFJKNMAJ, [Out] Color ADEDFOABBKP, [Out] Color GFIDKOEHBFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6E4B080", Offset = "0x6E4A480", VA = "0x186E4B080")]
	private bool BPLMOAMGHBL(Material BEDNCOELNMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6E51A00", Offset = "0x6E50E00", VA = "0x186E51A00")]
	private static Material LILKLEOAELK(int PPFEFFLJILL, LPIAIEPAPDE IOCFOFNHLGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6E4D950", Offset = "0x6E4CD50", VA = "0x186E4D950")]
	private static PIABCGLBJDM CNJOPKJJIII(OEMBNNIKJFA IOCFOFNHLGL, int ENJNOOMIJHL)
	{
		return default(PIABCGLBJDM);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6E50D20", Offset = "0x6E50120", VA = "0x186E50D20")]
	private static void JIGNDIPBIPN(Dictionary<string, List<GDOEIOPOLMM>> EMGPAFNJJMN, OEMBNNIKJFA GCFLODGDDHG, Material ACMOCJHPAPG, NLIABPACMCI PBKGBNNFEAK, PIABCGLBJDM NMDHFEECAKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x6E511D0", Offset = "0x6E505D0", VA = "0x186E511D0")]
	private static SkinnedMeshRenderer JOIKIKPMGGF(Transform BKFEOFAIPKM, Transform AINCMEBLPCN, SkinnedMeshRenderer[] KJDELDJCJHB, int JGOIAEJPNGK, KBALOKDMGKA HOGNIHDLFAI, bool JFPIADMBAJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x6E51840", Offset = "0x6E50C40", VA = "0x186E51840")]
	private void LCKJFBFKOCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6E52CD0", Offset = "0x6E520D0", VA = "0x186E52CD0")]
	private void OECLLEGAOPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6E4E0B0", Offset = "0x6E4D4B0", VA = "0x186E4E0B0")]
	private static void DFNLMEICEBF(Dictionary<GDOEIOPOLMM, Material> EKNCNMFMFAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6E4F940", Offset = "0x6E4ED40", VA = "0x186E4F940")]
	private static void FENAGAOMFDC(Dictionary<Renderer, PNDNHBHPDNO> EMLDELHEHLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6E51AE0", Offset = "0x6E50EE0", VA = "0x186E51AE0")]
	private void LPNJDONJCMG(SkinnedMeshRenderer[] KJDELDJCJHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6E4A9B0", Offset = "0x6E49DB0", VA = "0x186E4A9B0")]
	private void BDPBJJPKHND(SkinnedMeshRenderer BMCELCCICHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6E51EE0", Offset = "0x6E512E0", VA = "0x186E51EE0")]
	private void NAINDFIJHDD(List<KMJKLFGFJJB> DNCNKHCKPCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6E4FC30", Offset = "0x6E4F030", VA = "0x186E4FC30")]
	private void GCHBMOGCDBO(Dictionary<string, PLBFKJMGACI<Texture2D>> EMGPAFNJJMN, bool AGCLKFFFHPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x6E50590", Offset = "0x6E4F990", VA = "0x186E50590")]
	private void HBOMMJJFCHK(Dictionary<string, List<GDOEIOPOLMM>> EMGPAFNJJMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x6E50430", Offset = "0x6E4F830", VA = "0x186E50430")]
	private void HBLFALGJPDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x6E4FAA0", Offset = "0x6E4EEA0", VA = "0x186E4FAA0")]
	private void FNBAJANAOMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x6E4DAF0", Offset = "0x6E4CEF0", VA = "0x186E4DAF0")]
	private void DBNBLFOIEFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6E4F780", Offset = "0x6E4EB80", VA = "0x186E4F780")]
	private void EIEJMDFLJJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x6E4E9B0", Offset = "0x6E4DDB0", VA = "0x186E4E9B0")]
	private void DIEJAELDCCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6E53260", Offset = "0x6E52660", VA = "0x186E53260")]
	private void OHAKHICAFBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x6E506F0", Offset = "0x6E4FAF0", VA = "0x186E506F0")]
	private void HHMMILPBIPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6E51C40", Offset = "0x6E51040", VA = "0x186E51C40")]
	private void MDPHAOEKFCJ(bool CMKIIHFKALB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x6E520B0", Offset = "0x6E514B0", VA = "0x186E520B0")]
	private void NFAFFJDMNJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6E4F6A0", Offset = "0x6E4EAA0", VA = "0x186E4F6A0")]
	private void EHCIDNDAHLN(bool CMKIIHFKALB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x6E52230", Offset = "0x6E51630", VA = "0x186E52230")]
	private void OBOGFNIOJGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6E4ABA0", Offset = "0x6E49FA0", VA = "0x186E4ABA0")]
	private void BJNOCJAEDOK(Material HOJIELBCNNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x6E51400", Offset = "0x6E50800", VA = "0x186E51400")]
	private void KDGOOHALJBD(Material HOJIELBCNNA, Color HOHJPBPCNAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x6E4F0A0", Offset = "0x6E4E4A0", VA = "0x186E4F0A0")]
	private void DNIOFOOPNHJ(Material HOJIELBCNNA, Color HOHJPBPCNAE, Color ICKNPCPMCJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x6E4AA50", Offset = "0x6E49E50", VA = "0x186E4AA50")]
	private void BEOMNFBEOEM(Material HOJIELBCNNA, Color ECAGNHGBBCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x6E50B20", Offset = "0x6E4FF20", VA = "0x186E50B20")]
	private void JCGOBGOIJEI(Material HOJIELBCNNA, Texture2D EPCABFKFFHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x6E53100", Offset = "0x6E52500", VA = "0x186E53100")]
	private void OFBMICJNKKG(Material HOJIELBCNNA, Texture DKDCLABLEKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x6E52B70", Offset = "0x6E51F70", VA = "0x186E52B70")]
	private void ODNNKCMPEHB(Action<PNDNHBHPDNO> ILGCNMBIIEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6E4A7A0", Offset = "0x6E49BA0", VA = "0x186E4A7A0")]
	private void BANPMJMHIGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6E52CE0", Offset = "0x6E520E0", VA = "0x186E52CE0")]
	private void OEMDMJCGDME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6E4FF00", Offset = "0x6E4F300", VA = "0x186E4FF00")]
	private void GPPNPMGFEAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6E4E620", Offset = "0x6E4DA20", VA = "0x186E4E620")]
	public void DIDHOFMCDGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6E4F010", Offset = "0x6E4E410", VA = "0x186E4F010")]
	[CompilerGenerated]
	private void DLAFOPEANHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6E51C10", Offset = "0x6E51010", VA = "0x186E51C10")]
	[CompilerGenerated]
	private void MBJPCPBNLKO(PNDNHBHPDNO BKLGHHEEOKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6E4F850", Offset = "0x6E4EC50", VA = "0x186E4F850")]
	[CompilerGenerated]
	private void EINHELGFGKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x6E55310", Offset = "0x6E54710", VA = "0x186E55310")]
	[CompilerGenerated]
	private void PEPKFLOELIP(PNDNHBHPDNO BKLGHHEEOKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x6E51E50", Offset = "0x6E51250", VA = "0x186E51E50")]
	[CompilerGenerated]
	private void MLPMNNOBKMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x6E51570", Offset = "0x6E50970", VA = "0x186E51570")]
	[CompilerGenerated]
	private void KJAOJDCFEAO(PNDNHBHPDNO BKLGHHEEOKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x6E507C0", Offset = "0x6E4FBC0", VA = "0x186E507C0")]
	[CompilerGenerated]
	private void HJBBEACPKCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x6E4A740", Offset = "0x6E49B40", VA = "0x186E4A740")]
	[CompilerGenerated]
	private void AGNGHJJFKEH(PNDNHBHPDNO BKLGHHEEOKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6E4FDB0", Offset = "0x6E4F1B0", VA = "0x186E4FDB0")]
	[CompilerGenerated]
	private void GHOONGIHCBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x6E51E20", Offset = "0x6E51220", VA = "0x186E51E20")]
	[CompilerGenerated]
	private void MJEMGJIKGBE(PNDNHBHPDNO BKLGHHEEOKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x6E4A920", Offset = "0x6E49D20", VA = "0x186E4A920")]
	[CompilerGenerated]
	private void BDDOBIMFDJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x6E521E0", Offset = "0x6E515E0", VA = "0x186E521E0")]
	[CompilerGenerated]
	private void NNCKGNINPBJ(PNDNHBHPDNO BKLGHHEEOKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x6E51A50", Offset = "0x6E50E50", VA = "0x186E51A50")]
	[CompilerGenerated]
	private void LMLGEIJFADL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x6E521B0", Offset = "0x6E515B0", VA = "0x186E521B0")]
	[CompilerGenerated]
	private void NMDKDJFKHPF(PNDNHBHPDNO BKLGHHEEOKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x6E4FE40", Offset = "0x6E4F240", VA = "0x186E4FE40")]
	[CompilerGenerated]
	private CLHPIMOBJFN GJFNDOIKCOD(OEMBNNIKJFA AHHPGJOEACI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x6E50FE0", Offset = "0x6E503E0", VA = "0x186E50FE0")]
	[CompilerGenerated]
	private void JIIAMKPLKJL(KeyValuePair<string, PLBFKJMGACI<Texture2D>> NHPNFMBOIAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x6E4B6E0", Offset = "0x6E4AAE0", VA = "0x186E4B6E0")]
	[CompilerGenerated]
	private void CBAKLNBIAHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x6E4A770", Offset = "0x6E49B70", VA = "0x186E4A770")]
	[CompilerGenerated]
	private void BACBMDJJKDL(PNDNHBHPDNO BKLGHHEEOKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x6E51C00", Offset = "0x6E51000", VA = "0x186E51C00")]
	[CompilerGenerated]
	private void MBEEFLGACCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x6E52180", Offset = "0x6E51580", VA = "0x186E52180")]
	[CompilerGenerated]
	private void NLGMDKBDEKF(PNDNHBHPDNO BKLGHHEEOKG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class LHMDEBIIJAK : OOOHMBDIILN
{
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private static readonly int KMEFIFHABKE;

	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private static readonly int EBDIMKNGOOG;

	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private static readonly int AINDIACMLIE;

	[Cpp2IlInjected.Token(Token = "0x4000157")]
	private static readonly int IOIHNCIDFKL;

	[Cpp2IlInjected.Token(Token = "0x4000158")]
	private static readonly int DCMOHNJAPLG;

	[Cpp2IlInjected.Token(Token = "0x4000159")]
	private static readonly int MOJFICGODEC;

	[Cpp2IlInjected.Token(Token = "0x400015A")]
	private static readonly int AOEEMDKFCKN;

	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private static readonly int PGBGPOHDDLG;

	[Cpp2IlInjected.Token(Token = "0x400015C")]
	private static readonly int FAIPIIKEHIO;

	[Cpp2IlInjected.Token(Token = "0x400015D")]
	private static readonly int GJIAMMLNFJI;

	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private static readonly int EEFIKGAOODK;

	[Cpp2IlInjected.Token(Token = "0x400015F")]
	private static readonly int NBBKNDGAPLM;

	[Cpp2IlInjected.Token(Token = "0x4000160")]
	private static readonly int IGFKJDFJHBM;

	[Cpp2IlInjected.Token(Token = "0x4000161")]
	private static readonly int DKIFGMMPGJG;

	[Cpp2IlInjected.Token(Token = "0x4000162")]
	private static readonly int MCCAFOEDNMJ;

	[Cpp2IlInjected.Token(Token = "0x4000163")]
	private static readonly int IIBCNNJLNFO;

	[Cpp2IlInjected.Token(Token = "0x4000164")]
	private static readonly int OFNMENGIFKN;

	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private static readonly int ELKDJBBBHLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private Transform AHHPPLFJBPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private Transform IDDLGMAJAOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	private Transform HGFJJPIAJLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	private Transform APMAGIDAKDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	private Transform FFFKPJIIAIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private Transform DFDJKKEKFIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private Transform DAANIKDEJMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	private FLHGGBPPJEI BEGHDNGILKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	private MaterialPropertyBlock GDIFAINCJAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	private SkinnedMeshRenderer[] LHJBPDGJEEO;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	private MaterialPropertyBlock NAEJPHLHDNB
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x6E66310", Offset = "0x6E65710", VA = "0x186E66310")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public bool MAIEPNIBMOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x6E66880", Offset = "0x6E65C80", VA = "0x186E66880", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x6E66A60", Offset = "0x6E65E60", VA = "0x186E66A60", Slot = "8")]
	public void OOJJEJPOBFE(FLHGGBPPJEI HDKLOMDOHCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x6E66B30", Offset = "0x6E65F30", VA = "0x186E66B30", Slot = "5")]
	public void PAEOPNMILDI(PPLALAJDHPJ OFEIBONNCGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x6E65E10", Offset = "0x6E65210", VA = "0x186E65E10", Slot = "6")]
	public void CEKMHNBGOIH(EFLOOBFILBH DMCBNIEOEKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x6E66A00", Offset = "0x6E65E00", VA = "0x186E66A00")]
	private Vector2 MDDMKLALDKE(Vector2 LFDDDNDMDJC)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x6E64C70", Offset = "0x6E64070", VA = "0x186E64C70", Slot = "7")]
	public void CDCOLCOOIND(IDEHKBOPCCH OFEIBONNCGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x6E66470", Offset = "0x6E65870", VA = "0x186E66470")]
	private void GLILNFIDKNG(IDEHKBOPCCH GMBEBIEAMDD, EIANMHNFANG ADLGKEKHBOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x6E66390", Offset = "0x6E65790", VA = "0x186E66390")]
	private void GHNHFNDDNLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x6E66E60", Offset = "0x6E66260", VA = "0x186E66E60")]
	public LHMDEBIIJAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x6E667F0", Offset = "0x6E65BF0", VA = "0x186E667F0")]
	[CompilerGenerated]
	internal static (float, float) IJACCFGEJEK(float KADKJHPNPAB)
	{
		return default((float, float));
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x6E667B0", Offset = "0x6E65BB0", VA = "0x186E667B0")]
	[CompilerGenerated]
	internal static Vector4 GMEFCBBPIBM(Vector2 CPGMOBFHDAC, Vector2 BMGLFPFGJFF)
	{
		return default(Vector4);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class BHOLPDLEKNJ : NPKMIHPKIEM
{
	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x6E5FEF0", Offset = "0x6E5F2F0", VA = "0x186E5FEF0", Slot = "22")]
	public override float CINLGCHABGO()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x6E5FF40", Offset = "0x6E5F340", VA = "0x186E5FF40")]
	public void HKEPPEMBMMN(float OIFJGHIHKJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x6E5FF70", Offset = "0x6E5F370", VA = "0x186E5FF70")]
	public BHOLPDLEKNJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class NPKMIHPKIEM : IGIKALHDICH
{
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private static int NGFNNMACIJI;

	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private static int PKGLMHIOFBO;

	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private static int FNNLCEFMPAG;

	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private static int AAJBJEKPOGE;

	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private static int NDBJMMOKFEN;

	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private static int GBLJDDJJJLF;

	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private static int LOEEEMOHIHJ;

	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private static int[] DAKHKFHHEHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	private PIPGHHMNOIN BEGHDNGILKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	private AAEIJMJHPIL DINPKJOOELD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	private int CNEFLCDFAIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	private float HNAHLMOGGLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	protected Animator MDABFEDCJCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	protected bool BDKFBCLPJIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	protected AvatarConfiguration GOKPPEJNCLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	protected int FHMLDJMOGIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	private int LAEHLPEGLJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private int KOBNEDPIKAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	private bool PKBOPBOBAOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	private NONLBFLNOBA FMLOAFIBHEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	private int HKMAMGAMFGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	private float HILOLGPBDEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	private AvatarHandDisplaySettings NIPGNAGIHLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	private EOPKGKNJKFM KIALBFGDPFE;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public Transform NJPCEMHEHCP
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x8C7B90", Offset = "0x8C6F90", VA = "0x1808C7B90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x8C7DB0", Offset = "0x8C71B0", VA = "0x1808C7DB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public Vector3 EMGEAPOECLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x11DC080", Offset = "0x11DB480", VA = "0x1811DC080")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x11DC290", Offset = "0x11DB690", VA = "0x1811DC290")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public Quaternion JEGKKIPOBIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x968230", Offset = "0x967630", VA = "0x180968230")]
		[CompilerGenerated]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x12789C0", Offset = "0x1277DC0", VA = "0x1812789C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool IDCECLNOBAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x6E68090", Offset = "0x6E67490", VA = "0x186E68090")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x6E68670", Offset = "0x6E67A70", VA = "0x186E68670")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public Vector3 OMNAPBDKAAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x6E68290", Offset = "0x6E67690", VA = "0x186E68290", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x6E68140", Offset = "0x6E67540", VA = "0x186E68140")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public Quaternion BNCKLEMAKKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x6E680C0", Offset = "0x6E674C0", VA = "0x186E680C0", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x6E68110", Offset = "0x6E67510", VA = "0x186E68110")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public LICKDOCMADF JGDNKCOGDEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x19D8BB0", Offset = "0x19D7FB0", VA = "0x1819D8BB0", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return default(LICKDOCMADF);
		}
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x1D1D240", Offset = "0x1D1C640", VA = "0x181D1D240", Slot = "4")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public LICKDOCMADF MCKCEABKDHD
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x1DF4140", Offset = "0x1DF3540", VA = "0x181DF4140", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return default(LICKDOCMADF);
		}
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x1DF2820", Offset = "0x1DF1C20", VA = "0x181DF2820", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public float HEFBFFHKIPK
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0xF0B790", Offset = "0xF0AB90", VA = "0x180F0B790", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0xB1C8C0", Offset = "0xB1BCC0", VA = "0x180B1C8C0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public bool CEOCABHCLNK
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x6E680D0", Offset = "0x6E674D0", VA = "0x186E680D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public bool BMPEKLOAJJD
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x6E68100", Offset = "0x6E67500", VA = "0x186E68100")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public bool OKDPMFFMJBF
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x6E68130", Offset = "0x6E67530", VA = "0x186E68130")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool LHBKMGFIGBG
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x2716CF0", Offset = "0x27160F0", VA = "0x182716CF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x6E68A10", Offset = "0x6E67E10", VA = "0x186E68A10", Slot = "21")]
	public void OOJJEJPOBFE(PIPGHHMNOIN HDKLOMDOHCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x6E682B0", Offset = "0x6E676B0", VA = "0x186E682B0")]
	public void KIPNFEPLFAK(AAEIJMJHPIL ECIDMJFABIF, AvatarHandDisplaySettings EKNFDHMIMOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x6E681B0", Offset = "0x6E675B0", VA = "0x186E681B0", Slot = "11")]
	public void IEIINGGGJMM(bool GLCFJLGEAHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x6E68300", Offset = "0x6E67700", VA = "0x186E68300", Slot = "10")]
	public void MDNEJCMFMAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0xF0B790", Offset = "0xF0AB90", VA = "0x180F0B790", Slot = "22")]
	public virtual float CINLGCHABGO()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x6E68880", Offset = "0x6E67C80", VA = "0x186E68880")]
	private int OILKMCINEOJ(LICKDOCMADF OMBEPFICNBE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x6E686C0", Offset = "0x6E67AC0", VA = "0x186E686C0")]
	private void NJLMEHLMDFM(int NOFMBHNNHPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x6E686A0", Offset = "0x6E67AA0", VA = "0x186E686A0", Slot = "12")]
	public bool NFHFLMHKGED()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x6E68A00", Offset = "0x6E67E00", VA = "0x186E68A00", Slot = "13")]
	public bool OOHAFAHOIIC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x6E68160", Offset = "0x6E67560", VA = "0x186E68160")]
	private LICKDOCMADF FNAKMOEFGKP()
	{
		return default(LICKDOCMADF);
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x178AEC0", Offset = "0x178A2C0", VA = "0x18178AEC0", Slot = "14")]
	public void JJJBCOBKDMM(bool GLCFJLGEAHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x6E68BB0", Offset = "0x6E67FB0", VA = "0x186E68BB0", Slot = "9")]
	public void POFPNFPBDCJ(int NOFMBHNNHPO, float BKHNNLGGOHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x6E680E0", Offset = "0x6E674E0", VA = "0x186E680E0", Slot = "7")]
	public void BMONDPGBOAE(NONLBFLNOBA MPLALBADMNL, bool PBDMKBICHHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x6E68120", Offset = "0x6E67520", VA = "0x186E68120", Slot = "8")]
	public void DKHNAKMHIFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x6E68240", Offset = "0x6E67640", VA = "0x186E68240", Slot = "15")]
	public void KEODPJOCHAB(Transform AMMKPAGCALK, Vector3 HMHMIMEGLPH, Quaternion GLJEGNDMFOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x6E68E80", Offset = "0x6E68280", VA = "0x186E68E80")]
	public NPKMIHPKIEM()
	{
	}
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public class AvatarHandDisplaySettings
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000030")]
		public class AnimationOverride
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000193")]
			[Tooltip("Name of animation original state to override")]
			public string OriginalName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000194")]
			[Tooltip("Name of animation state to use as an override")]
			public string OverrideName;

			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
			public AnimationOverride()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		[SerializeField]
		private AnimationOverride[] HandStateOverrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		private Dictionary<int, int> _animationOverrides;

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x6E5E250", Offset = "0x6E5D650", VA = "0x186E5E250")]
		public void LKOIGPCFEMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x6E5E1E0", Offset = "0x6E5D5E0", VA = "0x186E5E1E0")]
		public int FHEMDFBPLLB(int KKLIFDKLJIA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public AvatarHandDisplaySettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public class AvatarKneeBendTargetController : MonoBehaviour, POJABNNNJLM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		[SerializeField]
		[KAIMDEABLJJ(PGGKFLBMAKK.Self, false, false, false)]
		private Transform KneeBendTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		[SerializeField]
		private Transform RootSpineBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		[SerializeField]
		private Transform ThighBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		[SerializeField]
		private Transform FootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		[SerializeField]
		private float WeightToFootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		[SerializeField]
		private Vector3 BendTargetOffsetFromHipToFootMidPoint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		[SerializeField]
		private Bounds KneeTargetConstrainedBox;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		private Vector3 BMNEHNFALML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		private Vector3 KJLBAIOABDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		private Vector3 IAIKCNNBJFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		private Matrix4x4 HAAFDPJKKIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		private bool IIOJAGFOMAH;

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x6E5E7E0", Offset = "0x6E5DBE0", VA = "0x186E5E7E0", Slot = "4")]
		public void UpdateController(float GNOIEGLKNOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x6E5E7D0", Offset = "0x6E5DBD0", VA = "0x186E5E7D0", Slot = "6")]
		public void SetEnabled(bool HCPAOILCJCB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x6E5E370", Offset = "0x6E5D770", VA = "0x186E5E370")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x6E5EEA0", Offset = "0x6E5E2A0", VA = "0x186E5EEA0")]
		public AvatarKneeBendTargetController()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[GFHMGJFENGN]
public struct PKJNCNJIFML : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	[ReadOnly]
	public IDBJHBMHDDD HOEIPNIFPJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	[ReadOnly]
	public int MKBACEGHBHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	public JPGMLEONDJM OAGHMHLKOJA;

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x6E6A380", Offset = "0x6E69780", VA = "0x186E6A380", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[NativeContainer]
[GFHMGJFENGN]
public struct JPGMLEONDJM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	public NativeArray<Vector3> LIKOBINCHDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	public NativeArray<Vector3> PGHHNGHEIGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	public NativeArray<Vector4> AALJHENCIJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	public NativeArray<Vector2> CJMJLLMGHAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	public NativeArray<Vector2> DPKBHAAPOBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	public NativeArray<Vector2> MPNCCNAJIKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	public NativeArray<Vector2> CJOPBGEDOPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	public NativeArray<Color> AJNPNIPCAKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	public NativeArray<int> IEBNCFKAEFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	public NativeArray<int> BGFCJINGKMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	private NativeArray<int> IKOIJEJNNAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private NativeArray<int> KKLHKJJKJGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	public NativeArray<int> BOJAJFIIJKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	public NativeArray<int> PCLHGDIKKKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	public NativeArray<int> PPFIAFJLBDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	public NativeArray<BoneWeight> EDLKAHKHDII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	private NativeArray<int> OKAMEPDCJCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	private bool AIJNEPHAKLO;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public int PJPHKLOBMDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x6E64700", Offset = "0x6E63B00", VA = "0x186E64700")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x6E64050", Offset = "0x6E63450", VA = "0x186E64050")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public int MJAEICLAMJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x6E64060", Offset = "0x6E63460", VA = "0x186E64060")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x6E646F0", Offset = "0x6E63AF0", VA = "0x186E646F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public int JBFALKAKNFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x6E646E0", Offset = "0x6E63AE0", VA = "0x186E646E0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x6E63DC0", Offset = "0x6E631C0", VA = "0x186E63DC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x6E64810", Offset = "0x6E63C10", VA = "0x186E64810")]
	public JPGMLEONDJM(int KFMOBELLJBM, int FOLNFHDJIBA, int PLEBKHGPNKF, int JAAPMADAGKC, Allocator MEFLJHAPKJF, int DLKGKOAHJFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x6E64650", Offset = "0x6E63A50", VA = "0x186E64650")]
	public void HPALFFHHPJP(int IIACLAMOIEE, Vector3 LLKDJGHBOID, Vector3 NKCIADHLFMI, Vector4 OPGNNMINDKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x6E63DD0", Offset = "0x6E631D0", VA = "0x186E63DD0")]
	public void AMFFEACCBEN(int IIACLAMOIEE, BoneWeight FGLLIFMAIPJ, NativeSlice<byte> LCCDEJPLMLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x6E646C0", Offset = "0x6E63AC0", VA = "0x186E646C0")]
	public Color JAHOPEPECPA(int IIACLAMOIEE)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x6E647A0", Offset = "0x6E63BA0", VA = "0x186E647A0")]
	public void NMGMAFPFPLJ(int IIACLAMOIEE, Color DGDCPDOCKCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x6E647C0", Offset = "0x6E63BC0", VA = "0x186E647C0")]
	public void PNEAEAGNBMJ(byte MKPOIMOOAOL, int IIACLAMOIEE, Vector2 PFEJFGPJOLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x6E64220", Offset = "0x6E63620", VA = "0x186E64220")]
	public void FGDKJMJMJAH(int IIACLAMOIEE, int BCCLADJEMOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x6E63F70", Offset = "0x6E63370", VA = "0x186E63F70")]
	public bool BLMLNNDNDML(int MKPOIMOOAOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x6E64230", Offset = "0x6E63630", VA = "0x186E64230")]
	public void FLDPFMMPMAA(int EEHEINNHDOC, int LHBPAMEKCBO, int OIPEPMJNPGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x6E63FA0", Offset = "0x6E633A0", VA = "0x186E63FA0")]
	public int[] CAFKIDGAEKJ(int EEHEINNHDOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x6E64710", Offset = "0x6E63B10", VA = "0x186E64710")]
	private NativeSlice<int> NKGEDGBGOMO(int EEHEINNHDOC)
	{
		return default(NativeSlice<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x6E64070", Offset = "0x6E63470", VA = "0x186E64070", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x6E64300", Offset = "0x6E63700", VA = "0x186E64300")]
	public Mesh FPDFCEGKPNE([Optional] string GEFCLEKKGCD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[GFHMGJFENGN]
[DefaultMember("Item")]
[NativeContainer]
public struct IDBJHBMHDDD : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	public NativeArray<Vector3> LIKOBINCHDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	public NativeArray<Vector3> PGHHNGHEIGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	public NativeArray<Vector4> AALJHENCIJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	public NativeArray<Vector2> CJMJLLMGHAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	public NativeArray<Vector2> DPKBHAAPOBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	public NativeArray<Vector2> MPNCCNAJIKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	public NativeArray<Vector2> CJOPBGEDOPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	public NativeArray<Color> AJNPNIPCAKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	public NativeArray<int> FIMFAOICFIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	public NativeArray<int> FEKKCJNAPDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	public NativeArray<int> GPAEPGFACDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	public NativeArray<int> JBOHGBKLKII;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	public NativeArray<bool> JIGIDJKKACP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	public NativeArray<int> GOJDHBJNJBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	public NativeArray<int> GPNMFNBMCPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	public NativeArray<BoneWeight> JDDKMDOGDNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	private NativeArray<Matrix4x4> LCHHGPMJEEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	private NativeArray<int> MCDFCLNKPII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	private NativeArray<byte> DIFODJCOECF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	private NativeArray<int> EOEJGABOIDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	private NativeArray<int> EHBCAOFAEMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	public NativeArray<sbyte> PCNJEBIGHIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	public NativeArray<byte> GJKIGJECHHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	private NativeArray<int> NKPBNLBFJEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	private bool AIJNEPHAKLO;

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public int OPMLNMGIJKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x232B450", Offset = "0x232A850", VA = "0x18232B450")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public int BEHFMOPAIKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x13F9F00", Offset = "0x13F9300", VA = "0x1813F9F00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public int CONHCLAFGLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x6E622C0", Offset = "0x6E616C0", VA = "0x186E622C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public int DFPGJJOIIOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x6E622A0", Offset = "0x6E616A0", VA = "0x186E622A0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x6E62310", Offset = "0x6E61710", VA = "0x186E62310")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public int PJPHKLOBMDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x6E622F0", Offset = "0x6E616F0", VA = "0x186E622F0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x6E61A10", Offset = "0x6E60E10", VA = "0x186E61A10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public int PCJMCGMHAKA
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x6E61A00", Offset = "0x6E60E00", VA = "0x186E61A00")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x6E61A20", Offset = "0x6E60E20", VA = "0x186E61A20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public PFKOJMLNIIH PPMEEHIIMDB
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x6E61C90", Offset = "0x6E61090", VA = "0x186E61C90")]
		get
		{
			return default(PFKOJMLNIIH);
		}
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x6E62300", Offset = "0x6E61700", VA = "0x186E62300")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public byte LNBNDBJHMEG
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x6E622B0", Offset = "0x6E616B0", VA = "0x186E622B0")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x6E61D70", Offset = "0x6E61170", VA = "0x186E61D70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public GEFBGOLHJND EEEHKFENLEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x6E61D80", Offset = "0x6E61180", VA = "0x186E61D80")]
		get
		{
			return default(GEFBGOLHJND);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x6E62320", Offset = "0x6E61720", VA = "0x186E62320")]
	public IDBJHBMHDDD(IList<Mesh> CBPBGCLDGGO, IList<Matrix4x4> LDJACKPOOFG, IList<bool> JIGIDJKKACP, byte CBFLFGIPIGC, IList<byte[]> JFJIHGPKJFN, IList<int> HAJHICHLDFO, IList<bool> HAHNKMFGDNJ, IList<int> GOJDHBJNJBL, IList<int> JLIOANDMMEL, IList<int> CCIIJNBLCAJ, Allocator MEFLJHAPKJF, PFKOJMLNIIH NALGFAKHAFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x6E61CA0", Offset = "0x6E610A0", VA = "0x186E61CA0")]
	public JPGMLEONDJM FNGCLCGPAJO(Allocator MEFLJHAPKJF)
	{
		return default(JPGMLEONDJM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x6E61A30", Offset = "0x6E60E30", VA = "0x186E61A30", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[GFHMGJFENGN]
public class FIKAKMIMNFL : MLOBKEODGIF
{
	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x6E61040", Offset = "0x6E60440", VA = "0x186E61040")]
	public IDBJHBMHDDD PJAJGILGDNA()
	{
		return default(IDBJHBMHDDD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x6E55E00", Offset = "0x6E55200", VA = "0x186E55E00")]
	public FIKAKMIMNFL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public struct GEFBGOLHJND
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	public NativeSlice<Vector3> LIKOBINCHDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	public NativeSlice<Vector3> PGHHNGHEIGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	public NativeSlice<Vector4> AALJHENCIJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	public NativeSlice<Vector2> CJMJLLMGHAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	public NativeSlice<Vector2> DPKBHAAPOBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	public NativeSlice<Vector2> MPNCCNAJIKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	public NativeSlice<Vector2> CJOPBGEDOPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	public NativeSlice<Color> AJNPNIPCAKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	public NativeSlice<int> PLOIDLPIMKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	public NativeSlice<int> JBOHGBKLKII;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	public NativeSlice<BoneWeight> JDDKMDOGDNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	public NativeSlice<byte> BGIFBFJOHBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	public int HBACABBHKHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	public Matrix4x4 MNDDFLDFHKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	public int DNMJFODFMIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	public NativeSlice<byte> LCCDEJPLMLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	public bool NMIPPECKMCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	public int CKCLHOHLJDJ;
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
internal readonly struct GDOEIOPOLMM : IEquatable<GDOEIOPOLMM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	internal readonly Material DPDBIOCNEDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	internal readonly NLIABPACMCI FDBLAHBDIGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	internal readonly PIABCGLBJDM PPIMMAHEKFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	internal readonly HAPHCDJNHOG HJDCAEMFHOD;

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x6E615B0", Offset = "0x6E609B0", VA = "0x186E615B0")]
	public GDOEIOPOLMM(Material BEDNCOELNMN, NLIABPACMCI COILFOKBAOH, PIABCGLBJDM MMNLEBJJFJM, HAPHCDJNHOG JBCPDKGINNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x6E61390", Offset = "0x6E60790", VA = "0x186E61390", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x6E61190", Offset = "0x6E60590", VA = "0x186E61190", Slot = "4")]
	public bool Equals(GDOEIOPOLMM BMKPAKCEMFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x6E61210", Offset = "0x6E60610", VA = "0x186E61210", Slot = "0")]
	public override bool Equals(object NCHBKHMIMGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x6E612F0", Offset = "0x6E606F0", VA = "0x186E612F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[DisallowMultipleComponent]
	public class AvatarModernBodyDisplayBehaviour : MonoBehaviour, MEIFIDFNJPL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		[SerializeField]
		[Header("Configuration")]
		protected AvatarConfiguration configuration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		[SerializeField]
		protected Animator skeletonAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		[SerializeField]
		protected Renderer[] watchRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		[Header("Configuration")]
		[SerializeField]
		private EOPKGKNJKFM avatarBodyType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		[SerializeField]
		private AssetReference avatarSkinAsset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		[SerializeField]
		private GameObject firstPersonMeshContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		[SerializeField]
		public GameObject thirdPersonMeshContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		[SerializeField]
		private GameObject[] hideInFirstPerson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		[SerializeField]
		protected Transform headAdditiveBaseBoneTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		[SerializeField]
		private Material BodyMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		[SerializeField]
		private Material FaceMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		[SerializeField]
		private Material DefaultAvatarItemMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		[SerializeField]
		private Shader AvatarDefaultShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		[SerializeField]
		private Shader AvatarUberShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		[SerializeField]
		private Transform DeformRigRootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		[SerializeField]
		private SkinnedMeshRenderer BaseSkinnedMeshRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		[SerializeField]
		protected AvatarSkinnedMeshBoneOrderRemapsData BoneOrderRemapsData;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		[SerializeField]
		[Header("Arm Animation Controllers")]
		private AvatarForearmRollController LeftForearmRollController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		[SerializeField]
		private AvatarElbowBendHelperController LeftElbowBendHelperController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		[SerializeField]
		private AvatarElbowBendTargetController LeftElbowBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		[SerializeField]
		private AvatarKneeBendTargetController LeftKneeBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		[SerializeField]
		private AvatarForearmRollController RightForearmRollController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		[SerializeField]
		private AvatarElbowBendHelperController RightElbowBendHelperController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		[SerializeField]
		private AvatarElbowBendTargetController RightElbowBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		[SerializeField]
		private AvatarKneeBendTargetController RightKneeBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		[SerializeField]
		private Transform LeftEyeBrowBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		[SerializeField]
		private Transform LeftEyeBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		[SerializeField]
		private Transform RightEyeBrowBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		[SerializeField]
		private Transform RightEyeBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		[SerializeField]
		private Transform NoseMoveTweakBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		[SerializeField]
		private Transform NoseScaleTweakBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		[SerializeField]
		private Transform MouthBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		[SerializeField]
		private AvatarBodyPartShapesManager avatarBodyPartShapesManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		[SerializeField]
		private Transform HeadTweakBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		[SerializeField]
		private Transform HatAnchorBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		[SerializeField]
		private Transform LeftHandWatchAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		[SerializeField]
		private Transform RightHandWatchAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		[SerializeField]
		private GameObject LeftHandWatchVisuals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		[SerializeField]
		private GameObject RightHandWatchVisuals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		private BIPIJKDNBKE BPIADJKJLFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		private OOOHMBDIILN CNNEGJCNIAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		private IGIKALHDICH BKCIOFKLNEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		private IGIKALHDICH IJDMCEGKIBA;

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public BIPIJKDNBKE LFDJCCEEGPL
		{
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x6E5FD90", Offset = "0x6E5F190", VA = "0x186E5FD90", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public OOOHMBDIILN BPDFLHFCCBA
		{
			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0x6E5FDE0", Offset = "0x6E5F1E0", VA = "0x186E5FDE0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public IGIKALHDICH KKGGLHKOHII
		{
			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x6E5FE30", Offset = "0x6E5F230", VA = "0x186E5FE30", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public IGIKALHDICH NNNCHJPKGIO
		{
			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0x6E5FE80", Offset = "0x6E5F280", VA = "0x186E5FE80", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public Transform PMCJPANKADC
		{
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x6E5FED0", Offset = "0x6E5F2D0", VA = "0x186E5FED0", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public EOPKGKNJKFM FLBOGODJCKM
		{
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0x8C7B70", Offset = "0x8C6F70", VA = "0x1808C7B70", Slot = "12")]
			get
			{
				return default(EOPKGKNJKFM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x6E5EEB0", Offset = "0x6E5E2B0", VA = "0x186E5EEB0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x6E5FC30", Offset = "0x6E5F030", VA = "0x186E5FC30")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x6E5F610", Offset = "0x6E5EA10", VA = "0x186E5F610", Slot = "8")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x6E5FC30", Offset = "0x6E5F030", VA = "0x186E5FC30", Slot = "9")]
		public void TeardownAvatarDisplaySystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x6E5EF40", Offset = "0x6E5E340", VA = "0x186E5EF40", Slot = "10")]
		public bool CleanupDisplayMeshes()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x6E5FCA0", Offset = "0x6E5F0A0", VA = "0x186E5FCA0")]
		public void UpdatePostIKAnimControllers(float GNOIEGLKNOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x6E5F580", Offset = "0x6E5E980", VA = "0x186E5F580")]
		private void IGAJJEOCDMF(GameObject NCHBKHMIMGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x6E5F270", Offset = "0x6E5E670", VA = "0x186E5F270")]
		private BIPIJKDNBKE DDAHKICLNIK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x6E5F930", Offset = "0x6E5ED30", VA = "0x186E5F930")]
		private OOOHMBDIILN MNBEDEHEAPC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x6E5F6A0", Offset = "0x6E5EAA0", VA = "0x186E5F6A0")]
		private IGIKALHDICH MMACDGAOEEN(HEIHCLNBOCO LBHEFJKPGBJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x6E5FD80", Offset = "0x6E5F180", VA = "0x186E5FD80")]
		public AvatarModernBodyDisplayBehaviour()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class PNDNHBHPDNO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000212")]
	private MaterialPropertyBlock BAGNGADDOGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000213")]
	public Color? NEFAJGBFKMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000214")]
	public Color? MODOLOPFDBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000215")]
	public Color? FADPAKFLEOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000216")]
	public Color? LHPDMLELBJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000217")]
	public Color PGODDBGJAKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000218")]
	public Color FKPHGGJBPMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000219")]
	public Color EPHHJIBDGMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400021A")]
	public Texture2D MDGGKGAMNLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400021B")]
	public Texture2D NNMKFFBGLDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400021C")]
	private Dictionary<GDOEIOPOLMM, int> FDENBAECNJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	private NLIABPACMCI[] BJEIPFICFMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	private PIABCGLBJDM[] FHEPFECFKFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	public Vector4[] HBKLODFGPNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	public Vector4[] OFPHHBGCHJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000221")]
	public Vector4[] EEFALBGDJPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	public Vector4[] HGGPIMNHOFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	public Vector4[] PONKNKDGLDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	public Vector4[] IKMDNNHJGNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	private List<Texture2D> PANJGBBMENA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	private Vector4[] LAKONOACIIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	private List<Texture2D> CFGBKHMGPDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000228")]
	private float[] CJKPHPHDNBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	private Vector4[] JOGJBKIDCJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	private float[] NHOCDOJDHFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	public float[] BEPNJLPKHLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	private List<Texture2D> HGMDHAFHHDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	private float[] PJNJCJPAJEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	private List<Texture2D> IPNJAMPCPAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	private Vector4[] DMCFMKJCFBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	private float[] CNCBLAPEMBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	private Vector4[] ELIMAEKIOKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	public float[] LFJEHLNIMCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	public Texture2DArray CGOPHKHILON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	public Texture2DArray FFHCMGAAPHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	public Texture2DArray FHNCECGCFAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	public Texture2DArray NBANBOLMDIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	private bool IHIOOAJDENC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x184")]
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	private int JOAOBKOKJGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	private Vector2? HHLEIMBPHJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x194")]
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	private TextureFormat BOMFDPPMNPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	private Vector2? PFPLAKOFOBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A4")]
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	private TextureFormat PCFMOMONKMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	private Vector2? MOPNCDGCNCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B4")]
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	private TextureFormat IJKMFFONHPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	private Vector2? AKKIBJIMKCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C4")]
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	private TextureFormat CGINCOAKDJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	private bool NDHHFMKHGIO;

	[Cpp2IlInjected.Token(Token = "0x4000242")]
	private static int CFOOKPGPKDE;

	[Cpp2IlInjected.Token(Token = "0x4000243")]
	private static int OLKHMFMBGJJ;

	[Cpp2IlInjected.Token(Token = "0x4000244")]
	private static int MDMNIPNKFFE;

	[Cpp2IlInjected.Token(Token = "0x4000245")]
	private static int GIJLIIGGEPD;

	[Cpp2IlInjected.Token(Token = "0x4000246")]
	private static int DLEFKHJPKGF;

	[Cpp2IlInjected.Token(Token = "0x4000247")]
	private static int BMNLMDFHMPK;

	[Cpp2IlInjected.Token(Token = "0x4000248")]
	private static int FDPGAGFJJDG;

	[Cpp2IlInjected.Token(Token = "0x4000249")]
	private static int CKEAFLDBKFE;

	[Cpp2IlInjected.Token(Token = "0x400024A")]
	private static int BBHKLAHOJPD;

	[Cpp2IlInjected.Token(Token = "0x400024B")]
	private static int MPMBENOIFOA;

	[Cpp2IlInjected.Token(Token = "0x400024C")]
	private static int DLFFIDMIGOP;

	[Cpp2IlInjected.Token(Token = "0x400024D")]
	private static int DAFMAJIKHIA;

	[Cpp2IlInjected.Token(Token = "0x400024E")]
	private static int JICMICMLGBP;

	[Cpp2IlInjected.Token(Token = "0x400024F")]
	private static int EFJHEALNMAO;

	[Cpp2IlInjected.Token(Token = "0x4000250")]
	private static int DMBBKEKGAGP;

	[Cpp2IlInjected.Token(Token = "0x4000251")]
	private static int LKFINHMCFJC;

	[Cpp2IlInjected.Token(Token = "0x4000252")]
	private static int LNNLPBKFPKJ;

	[Cpp2IlInjected.Token(Token = "0x4000253")]
	private static int DIPOCNGGBFK;

	[Cpp2IlInjected.Token(Token = "0x4000254")]
	private static int AMJOKBDPADF;

	[Cpp2IlInjected.Token(Token = "0x4000255")]
	private static int EJFANAHBEFB;

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x6E6D9B0", Offset = "0x6E6CDB0", VA = "0x186E6D9B0")]
	private PNDNHBHPDNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x6E6D8F0", Offset = "0x6E6CCF0", VA = "0x186E6D8F0")]
	public PNDNHBHPDNO(Color CHJKFNKNDDM, Color LKOOFJKIION, Color NJFKCBMLMJO, Color? GDOIOFNNJIJ, Color? GFNPHNBCPCI, Color? JKGCKCPHJHL, Texture2D NGDGKALPNAE, Texture2D DHEFFJPEMDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x6E6BFA0", Offset = "0x6E6B3A0", VA = "0x186E6BFA0")]
	internal int BGEKAAOJMGJ(Material NHPFPMFEOAA, NLIABPACMCI COILFOKBAOH, PIABCGLBJDM MMNLEBJJFJM, HAPHCDJNHOG JBCPDKGINNI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x6E6C090", Offset = "0x6E6B490", VA = "0x186E6C090")]
	private int BGEKAAOJMGJ(GDOEIOPOLMM LDCKBFKFIKC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x6E6C730", Offset = "0x6E6BB30", VA = "0x186E6C730")]
	internal int MEGLIHNJMDI(Material NHPFPMFEOAA, Color ECAGNHGBBCA, Color BFAPBFOOOGH, Color HOGNAKEHJDH, Color CFHJFJKNMAJ, Color ADEDFOABBKP, Texture2D POGKBFFLDOB, Vector4 CPNLGFINPAJ, Texture2D JCAFGDLEIFC, Vector4 OBLKLPJEBBN, float BDFDHGOBNMH, float DLCCABLODHM, Texture2D MGBJEGGMNLI, Vector4 OKGACHBKAOI, float PCJKLEMCADA, Texture2D KJENGNEDDIB, Color GFIDKOEHBFB, Vector4 DGHGCCKKOHP, NLIABPACMCI COILFOKBAOH, PIABCGLBJDM MMNLEBJJFJM, HAPHCDJNHOG JBCPDKGINNI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x6E6C570", Offset = "0x6E6B970", VA = "0x186E6C570")]
	private void KFMJGNHHMAF(List<Texture2D> PANJGBBMENA, [Out] Texture2DArray KLKNIIEMHJB, [Out] Texture2DArray BKALAOHJIEN, [Out] Texture2DArray MIBANDGJHMP, [Out] Texture2DArray GHNIPNECLJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x6E6D300", Offset = "0x6E6C700", VA = "0x186E6D300")]
	public void NBGLLCKPAMC(Shader CEIILJOBJDM, Renderer IEBCHEIKEKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x6E6B2E0", Offset = "0x6E6A6E0", VA = "0x186E6B2E0")]
	private void ABEGJDEHJLG(Shader CEIILJOBJDM, Renderer IEBCHEIKEKK, int KFGMONBNAFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x6E6C370", Offset = "0x6E6B770", VA = "0x186E6C370")]
	private Color ICKCKGICBKP(Color ECLIAJFIJFP, NLIABPACMCI PBKGBNNFEAK)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x6E6D450", Offset = "0x6E6C850", VA = "0x186E6D450")]
	private Color PPNMCOHBCFN(Color LNHCIJPCKJD, NLIABPACMCI PBKGBNNFEAK)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x6E6C210", Offset = "0x6E6B610", VA = "0x186E6C210")]
	private bool EPGFNNNCAHK(Texture2D NHOMKMJCPHJ, PIABCGLBJDM NMDHFEECAKH, [Out] Texture2D GJJEGFABOPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x6E6C160", Offset = "0x6E6B560", VA = "0x186E6C160")]
	private void EKOJHADNAGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x6E6C120", Offset = "0x6E6B520", VA = "0x186E6C120", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class JHLLBLPOHJB
{
	[Cpp2IlInjected.Token(Token = "0x4000256")]
	private static readonly int[] FCIMHKNIAAK;

	[Cpp2IlInjected.Token(Token = "0x4000257")]
	private static readonly int[] IAGFKCELIBC;

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public static int[] EIAEJFJKBCA
	{
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x6E63B30", Offset = "0x6E62F30", VA = "0x186E63B30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x6E63BA0", Offset = "0x6E62FA0", VA = "0x186E63BA0")]
	public static int[] GGDEDLNGLJJ(bool LOHHACGFBOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x6E63C20", Offset = "0x6E63020", VA = "0x186E63C20")]
	public static int JCGCBDLPGDL(HODEOENILDN COMKBDFINAL, bool LOHHACGFBOC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x6E63CB0", Offset = "0x6E630B0", VA = "0x186E63CB0")]
	private static int JLIFLJHPEFD(HODEOENILDN COMKBDFINAL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x6E63B80", Offset = "0x6E62F80", VA = "0x186E63B80")]
	private static int GDIOHKHOIMK(HODEOENILDN COMKBDFINAL)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class HEMBDILEDDG
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private sealed class DEDNCKNEEJH : IEnumerator<ONHNFKGBFKG>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		private ONHNFKGBFKG <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		public JobHandle handle;

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		private ONHNFKGBFKG System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x8C7D90", Offset = "0x8C7190", VA = "0x1808C7D90", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x8C7D90", Offset = "0x8C7190", VA = "0x1808C7D90", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x8CAD70", Offset = "0x8CA170", VA = "0x1808CAD70")]
		[DebuggerHidden]
		public DEDNCKNEEJH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0xDF7E50", Offset = "0xDF7250", VA = "0x180DF7E50", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x6E602B0", Offset = "0x6E5F6B0", VA = "0x186E602B0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80")]
	public static void BPFHCMNBHLC(string LPMIIFILJPI, int JGOIAEJPNGK, long KHGBOBAGGOB, long FLODHOAHKBO, long BCFDBCEMNFP, long IPKJMJBNDEH, long MOGALMIDAKD, long OGCNEMGOEFM, long BKJOPKIOEEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x6E61910", Offset = "0x6E60D10", VA = "0x186E61910")]
	public static GLHJGEGNDCM KOCIHBOFILD(JobHandle CECMHNBEIHC, bool GCJFCAJNFDC, bool BLOFPAADMOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x6E618A0", Offset = "0x6E60CA0", VA = "0x186E618A0")]
	[IteratorStateMachine(typeof(DEDNCKNEEJH))]
	private static IEnumerator<ONHNFKGBFKG> FOMAMIGBNFO(JobHandle KADPKBIGPFN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class EMHJELIGIII
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public enum PDGBAJKCOOL
	{
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		General,
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		ColoredHair
	}

	[Cpp2IlInjected.Token(Token = "0x400025B")]
	public static readonly int MEGEIMHEPLF;

	[Cpp2IlInjected.Token(Token = "0x400025C")]
	public static readonly int KPFIDJCNPEF;

	[Cpp2IlInjected.Token(Token = "0x400025D")]
	public static readonly int JNGKCDPEKJM;

	[Cpp2IlInjected.Token(Token = "0x400025E")]
	public static readonly int JNBDFFIEMKM;

	[Cpp2IlInjected.Token(Token = "0x400025F")]
	public static readonly int AIPBLLLFHKP;

	[Cpp2IlInjected.Token(Token = "0x4000260")]
	public static readonly int IEGJIOLGOEF;

	[Cpp2IlInjected.Token(Token = "0x4000261")]
	public static readonly int PODJOMCEMKH;

	[Cpp2IlInjected.Token(Token = "0x4000262")]
	public static readonly int NBONHMPOELD;

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x6E60DD0", Offset = "0x6E601D0", VA = "0x186E60DD0")]
	public static bool FFMAMNJDLLC(Material BEDNCOELNMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x6E60D10", Offset = "0x6E60110", VA = "0x186E60D10")]
	public static bool AAMNEPCBPLJ(Material BEDNCOELNMN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public class MOBCEOHADLA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000266")]
	private List<int> NNJFMDDDJPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000267")]
	private List<ANNJKMDEILH> CAIFJBIOMAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000268")]
	private HashSet<Transform> AJPACGHNLKK;

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x6E678A0", Offset = "0x6E66CA0", VA = "0x186E678A0")]
	public static MOBCEOHADLA EHMPIKENAJF(Transform OPGNNMINDKO, Dictionary<Transform, OutfitType?> NOCHCELNEJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x6E675E0", Offset = "0x6E669E0", VA = "0x186E675E0")]
	private void CANDOJLLMIG(Transform OPGNNMINDKO, HAPHCDJNHOG JBCPDKGINNI, Dictionary<Transform, OutfitType?> NOCHCELNEJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x6E67E30", Offset = "0x6E67230", VA = "0x186E67E30")]
	private void PKOGABFHLCM(Transform HACJKEOIMJC, HAPHCDJNHOG JBCPDKGINNI, bool KOAJMPJDPLF, OutfitType? HKNHLPOKHIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x6E67A40", Offset = "0x6E66E40", VA = "0x186E67A40")]
	public PBCIAPGAKBH IEJJLKMCMEN(HashSet<string> NLJJPMDBMPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x6E67F60", Offset = "0x6E67360", VA = "0x186E67F60")]
	public MOBCEOHADLA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class PBCIAPGAKBH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000269")]
	private List<ANNJKMDEILH> CAIFJBIOMAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400026A")]
	private List<Matrix4x4> LMFBMEDIIJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400026B")]
	private Transform[] BCLHLNKPBBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400026C")]
	private Matrix4x4[] ILMKHOFHHIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400026D")]
	private Dictionary<HDKDHAFIKOB, int> GFIGNBJHPKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400026E")]
	private List<BPOMEEFOKGA> ACLEAKJEIBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400026F")]
	private bool OEIHEBJBINJ;

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public int MKHKOEAGNJG
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x6E69A40", Offset = "0x6E68E40", VA = "0x186E69A40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public Transform[] DACACKNBCEA
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x6E696B0", Offset = "0x6E68AB0", VA = "0x186E696B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public Matrix4x4[] DOJGHJJGGPM
	{
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x6E69A80", Offset = "0x6E68E80", VA = "0x186E69A80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x6E69AF0", Offset = "0x6E68EF0", VA = "0x186E69AF0")]
	public void PKOGABFHLCM(Transform HACJKEOIMJC, HAPHCDJNHOG JBCPDKGINNI, OutfitType? HKNHLPOKHIK, bool OJAOBECEJGK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x6E69CE0", Offset = "0x6E690E0", VA = "0x186E69CE0")]
	private void PKOGABFHLCM(Transform HACJKEOIMJC, HAPHCDJNHOG JBCPDKGINNI, OutfitType? HKNHLPOKHIK, bool OJAOBECEJGK, Matrix4x4 KKLAEHJNGAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x6E69500", Offset = "0x6E68900", VA = "0x186E69500")]
	public int FIEIDCMMCPM(HDKDHAFIKOB LDCKBFKFIKC, bool DGIILHOGOBP, [Optional] OutfitType? HKNHLPOKHIK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x6E69400", Offset = "0x6E68800", VA = "0x186E69400")]
	public int EBKKIJMICML(HAPHCDJNHOG JBCPDKGINNI, [Optional] OutfitType? HKNHLPOKHIK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x6E69810", Offset = "0x6E68C10", VA = "0x186E69810")]
	public void IMLGNHDEEDF(HDKDHAFIKOB LDCKBFKFIKC, Matrix4x4 FGJFCPNFNED, bool DGIILHOGOBP = false, [Optional] OutfitType? HKNHLPOKHIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x6E69900", Offset = "0x6E68D00", VA = "0x186E69900")]
	public Matrix4x4 MMNCAPFEBDC(HDKDHAFIKOB LDCKBFKFIKC, bool DGIILHOGOBP, [Optional] OutfitType? HKNHLPOKHIK)
	{
		return default(Matrix4x4);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0xEB9670", Offset = "0xEB8A70", VA = "0x180EB9670")]
	public void JBEJFENIPHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x6E6A010", Offset = "0x6E69410", VA = "0x186E6A010")]
	public PBCIAPGAKBH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public struct HDKDHAFIKOB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000273")]
	public readonly string IFFNHPDANFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000274")]
	public readonly HAPHCDJNHOG HJDCAEMFHOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000275")]
	public readonly OutfitType? FMAGCDGDCPD;

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x6E61860", Offset = "0x6E60C60", VA = "0x186E61860")]
	public HDKDHAFIKOB(string JLKBGEHOOHK, HAPHCDJNHOG JBCPDKGINNI, [Optional] OutfitType? HKNHLPOKHIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x6E617B0", Offset = "0x6E60BB0", VA = "0x186E617B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x6E61690", Offset = "0x6E60A90", VA = "0x186E61690")]
	public bool FIEJHAMNHHO(HDKDHAFIKOB BMKPAKCEMFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x6E615F0", Offset = "0x6E609F0", VA = "0x186E615F0", Slot = "0")]
	public override bool Equals(object NCHBKHMIMGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x6E61750", Offset = "0x6E60B50", VA = "0x186E61750", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public struct BPOMEEFOKGA : IEquatable<BPOMEEFOKGA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000276")]
	public readonly HAPHCDJNHOG HJDCAEMFHOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000277")]
	public readonly OutfitType? ECHEFBLCCGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000278")]
	public readonly int FDBMLMAHMNH;

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x6E602A0", Offset = "0x6E5F6A0", VA = "0x186E602A0")]
	public BPOMEEFOKGA(HAPHCDJNHOG JBCPDKGINNI, int LICLOOCBCHD, [Optional] OutfitType? ODLBGGDOGFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x6E601E0", Offset = "0x6E5F5E0", VA = "0x186E601E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x1B28B80", Offset = "0x1B27F80", VA = "0x181B28B80")]
	public bool OAEIIILKMGC(HAPHCDJNHOG JBCPDKGINNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x6E60160", Offset = "0x6E5F560", VA = "0x186E60160")]
	public bool HNEPKOOIAMJ(OutfitType? ODLBGGDOGFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x6E5FFD0", Offset = "0x6E5F3D0", VA = "0x186E5FFD0", Slot = "4")]
	public bool Equals(BPOMEEFOKGA BMKPAKCEMFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x6E60020", Offset = "0x6E5F420", VA = "0x186E60020", Slot = "0")]
	public override bool Equals(object NCHBKHMIMGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x6E60110", Offset = "0x6E5F510", VA = "0x186E60110", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public struct ANNJKMDEILH : IEquatable<ANNJKMDEILH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000279")]
	public readonly Transform AMJNILHCCDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400027A")]
	public readonly bool CONHKEHCLDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400027B")]
	public readonly HAPHCDJNHOG AKOGAIIICGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400027C")]
	public readonly OutfitType? FMAGCDGDCPD;

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x6E5E1A0", Offset = "0x6E5D5A0", VA = "0x186E5E1A0")]
	public ANNJKMDEILH(Transform HACJKEOIMJC, bool KOAJMPJDPLF, HAPHCDJNHOG NANFGNLLCDH, [Optional] OutfitType? OKLOOBAFOCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x6E5DF90", Offset = "0x6E5D390", VA = "0x186E5DF90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x6E5DD40", Offset = "0x6E5D140", VA = "0x186E5DD40", Slot = "4")]
	public bool Equals(ANNJKMDEILH BMKPAKCEMFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x6E5DE40", Offset = "0x6E5D240", VA = "0x186E5DE40", Slot = "0")]
	public override bool Equals(object NCHBKHMIMGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x6E5DF20", Offset = "0x6E5D320", VA = "0x186E5DF20", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[ExecuteInEditMode]
	public class FitMeshHemisphereUpdater : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		public const float DEFAULT_Y_POSITION_OFFSET = 0.04f;

		[Cpp2IlInjected.Token(Token = "0x400027E")]
		public const float MAX_HEMISPHERE_POSITION_OFFSET = 0.05f;

		[Cpp2IlInjected.Token(Token = "0x400027F")]
		public const float MAX_HEMISPHERE_ROTATION_OFFSET = 45f;

		[Cpp2IlInjected.Token(Token = "0x4000280")]
		public const float MAX_HEMISPHERE_SCALE = 2f;

		[Cpp2IlInjected.Token(Token = "0x4000281")]
		public const float MIN_HEMISPHERE_SCALE = 0.75f;

		[Cpp2IlInjected.Token(Token = "0x4000282")]
		public const float MAX_HEMISPHERE_RADIUS = 0.25f;

		[Cpp2IlInjected.Token(Token = "0x4000283")]
		public const float MIN_HEMISPHERE_RADIUS = 0.125f;

		[Cpp2IlInjected.Token(Token = "0x4000284")]
		public static GameObject ContainerGO;

		[Cpp2IlInjected.Token(Token = "0x4000285")]
		public static GameObject CurrentHairHemisphereGO;

		[Cpp2IlInjected.Token(Token = "0x4000286")]
		public static Transform CurrentHairHemisphereMeshTransform;

		[Cpp2IlInjected.Token(Token = "0x4000287")]
		public static FitMeshHemisphereUpdater CurrentHairHemisphereUpdater;

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x6E61130", Offset = "0x6E60530", VA = "0x186E61130")]
		public static void DespawnHairHemisphere()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80")]
		public void UpdateValues()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x8C6D70", Offset = "0x8C6170", VA = "0x1808C6D70")]
		public FitMeshHemisphereUpdater()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public interface OLKDEJHCEBA
{
	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BGLDCBDOKKD(Mesh DFFOPHDLMNO, Matrix4x4 ABONPPAKJEF, byte[] LCCDEJPLMLE, bool KOCLJANCGAD = false, IBBAPAKLKFF.JPAHGGFNNNL PGJNHPHAFJO = (IBBAPAKLKFF.JPAHGGFNNNL)0, int GOJDHBJNJBL = -1, bool JIGIDJKKACP = false);

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MFKJBIJHOOK(Allocator MEFLJHAPKJF, PFKOJMLNIIH NALGFAKHAFL, byte CBFLFGIPIGC, [Optional] IList<int> JLIOANDMMEL, [Optional] IList<int> EBLGMCKCCCJ);
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public readonly struct FEKKKGIMDBJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000288")]
	public readonly GameObject GEDKLECMMOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000289")]
	private readonly AvatarItemMaterial CBNDANAHEEK;

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0xE8EEE0", Offset = "0xE8E2E0", VA = "0x180E8EEE0")]
	public FEKKKGIMDBJ(GameObject GEDKLECMMOE, AvatarItemMaterial CBNDANAHEEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x6E60FB0", Offset = "0x6E603B0", VA = "0x186E60FB0")]
	public void GIABNHANFCN(Material BEDNCOELNMN, int PPFEFFLJILL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class MNBOJCMJHOP : FILEOLKLPCE<Task<(GameObject, AvatarItemMaterial)>, FEKKKGIMDBJ>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private struct DLJPGHEENLH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400028E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400028F")]
		public AsyncTaskMethodBuilder<(GameObject, AvatarItemMaterial)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000290")]
		public Task<GameObject> goTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000291")]
		public Task<AvatarItemMaterial> materialTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000292")]
		private GameObject <go>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000293")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000294")]
		private TaskAwaiter<GameObject> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000295")]
		private TaskAwaiter<AvatarItemMaterial> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x6E60300", Offset = "0x6E5F700", VA = "0x186E60300", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x6E60800", Offset = "0x6E5FC00", VA = "0x186E60800", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400028A")]
	private PLBFKJMGACI<GameObject> KHHCGODFHCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400028B")]
	private PLBFKJMGACI<AvatarItemMaterial> DJIKIMEHGFA;

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x6E67550", Offset = "0x6E66950", VA = "0x186E67550")]
	private MNBOJCMJHOP(Task<(GameObject, AvatarItemMaterial)> LCFJPCOMAFL, PLBFKJMGACI<GameObject> IPNDGJNGPBK, PLBFKJMGACI<AvatarItemMaterial> HFPFOPPCKMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x6E67150", Offset = "0x6E66550", VA = "0x186E67150")]
	public static MNBOJCMJHOP KOPOAAAOIOD(AssetReference AMHKMDDLKNE, [Optional] AssetReference LNMNBHGMMIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x6E66F00", Offset = "0x6E66300", VA = "0x186E66F00", Slot = "11")]
	protected override FEKKKGIMDBJ DJNCEBAIGDD(Task<(GameObject, AvatarItemMaterial)> CBHNDEPAMOL)
	{
		return default(FEKKKGIMDBJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x6E670D0", Offset = "0x6E664D0", VA = "0x186E670D0", Slot = "12")]
	protected override void EAPJADGDHFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x6E66FA0", Offset = "0x6E663A0", VA = "0x186E66FA0")]
	[AsyncStateMachine(typeof(DLJPGHEENLH))]
	private static Task<(GameObject, AvatarItemMaterial)> DLKCPLECGON(Task<GameObject> JFIHBECKPEA, Task<AvatarItemMaterial> ONABNMMJGEA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public static class DMDLLNPEHNM
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	private class OBCOPHCMODK : FILEOLKLPCE<Task<MaterialMapAsset>, Material[]>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000297")]
		private PLBFKJMGACI<MaterialMapAsset> KADPKBIGPFN;

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x6E69320", Offset = "0x6E68720", VA = "0x186E69320")]
		public OBCOPHCMODK(PLBFKJMGACI<MaterialMapAsset> KADPKBIGPFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x6E68EA0", Offset = "0x6E682A0", VA = "0x186E68EA0", Slot = "11")]
		protected override Material[] DJNCEBAIGDD(Task<MaterialMapAsset> LCFJPCOMAFL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x6E692C0", Offset = "0x6E686C0", VA = "0x186E692C0", Slot = "12")]
		protected override void EAPJADGDHFK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private class PEILGHJIGKH : FILEOLKLPCE<Task<Material[]>, Material[]>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		private List<PLBFKJMGACI<Material>> BLENOGEPAEK;

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x6E6A310", Offset = "0x6E69710", VA = "0x186E6A310")]
		public PEILGHJIGKH(Task<Material[]> LCFJPCOMAFL, List<PLBFKJMGACI<Material>> BLENOGEPAEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x6E6A180", Offset = "0x6E69580", VA = "0x186E6A180", Slot = "11")]
		protected override Material[] DJNCEBAIGDD(Task<Material[]> CBHNDEPAMOL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x6E6A1D0", Offset = "0x6E695D0", VA = "0x186E6A1D0", Slot = "12")]
		protected override void EAPJADGDHFK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000296")]
	private static readonly GKOKEEMOOFG GGCNADGKGHO;

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x6E60870", Offset = "0x6E5FC70", VA = "0x186E60870")]
	public static PLBFKJMGACI<Material[]> MBAAGDGPKDA(AssetReference[] HIHKJKCLCDF)
	{
		return null;
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[DisallowMultipleComponent]
	public class PlayerAvatarDisplayBase : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000052")]
		public enum ENEGMIMINPJ
		{
			[Cpp2IlInjected.Token(Token = "0x400031D")]
			None,
			[Cpp2IlInjected.Token(Token = "0x400031E")]
			TeamItem,
			[Cpp2IlInjected.Token(Token = "0x400031F")]
			SkinColor,
			[Cpp2IlInjected.Token(Token = "0x4000320")]
			HairColor,
			[Cpp2IlInjected.Token(Token = "0x4000321")]
			BeardColor,
			[Cpp2IlInjected.Token(Token = "0x4000322")]
			UGCShirtColor
		}

		[Cpp2IlInjected.Token(Token = "0x2000053")]
		public enum CCEHNAIIODM
		{
			[Cpp2IlInjected.Token(Token = "0x4000324")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4000325")]
			HairTexture,
			[Cpp2IlInjected.Token(Token = "0x4000326")]
			BeardTexture,
			[Cpp2IlInjected.Token(Token = "0x4000327")]
			UGCShirtTexture
		}

		[Cpp2IlInjected.Token(Token = "0x2000054")]
		public enum KGBMOAGMOHJ : byte
		{
			[Cpp2IlInjected.Token(Token = "0x4000329")]
			All,
			[Cpp2IlInjected.Token(Token = "0x400032A")]
			LOD0Only,
			[Cpp2IlInjected.Token(Token = "0x400032B")]
			EditorToolAll
		}

		[Cpp2IlInjected.Token(Token = "0x2000055")]
		public struct BNDEMEMEPME
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400032C")]
			public readonly Material DPDBIOCNEDO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400032D")]
			public readonly ENEGMIMINPJ FDBLAHBDIGE;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x400032E")]
			public readonly CCEHNAIIODM PPIMMAHEKFE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400032F")]
			public readonly HAPHCDJNHOG HJDCAEMFHOD;

			[Cpp2IlInjected.Token(Token = "0x60002B4")]
			[Cpp2IlInjected.Address(RVA = "0x6E615B0", Offset = "0x6E609B0", VA = "0x186E615B0")]
			public BNDEMEMEPME(Material BEDNCOELNMN, ENEGMIMINPJ COILFOKBAOH, CCEHNAIIODM MMNLEBJJFJM, HAPHCDJNHOG JBCPDKGINNI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002B5")]
			[Cpp2IlInjected.Address(RVA = "0x6E7BA00", Offset = "0x6E7AE00", VA = "0x186E7BA00", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002B6")]
			[Cpp2IlInjected.Address(RVA = "0x6E61190", Offset = "0x6E60590", VA = "0x186E61190")]
			public bool FIEJHAMNHHO(BNDEMEMEPME BMKPAKCEMFK)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002B7")]
			[Cpp2IlInjected.Address(RVA = "0x6E7B880", Offset = "0x6E7AC80", VA = "0x186E7B880", Slot = "0")]
			public override bool Equals(object NCHBKHMIMGJ)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002B8")]
			[Cpp2IlInjected.Address(RVA = "0x6E7B960", Offset = "0x6E7AD60", VA = "0x186E7B960", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000056")]
		protected struct BPJAODFLPAN : IComparable<BPJAODFLPAN>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000330")]
			public int EHHEJJCOJMM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000331")]
			public PlayerAvatarDisplayBase MMDDBBBPGKC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000332")]
			public IList<NCBGGKADNMM> EAJBAOGFBMH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000333")]
			public AvatarItemBodyType EMEIDCCKJPN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000334")]
			public bool IMPGEJIIAPN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000335")]
			public int[] AFKFLDLEHCG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000336")]
			public float HAKPHKPNEMN;

			[Cpp2IlInjected.Token(Token = "0x60002B9")]
			[Cpp2IlInjected.Address(RVA = "0x6E7BC40", Offset = "0x6E7B040", VA = "0x186E7BC40", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002BA")]
			[Cpp2IlInjected.Address(RVA = "0x6E7BC20", Offset = "0x6E7B020", VA = "0x186E7BC20", Slot = "4")]
			public int CompareTo(BPJAODFLPAN BMKPAKCEMFK)
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000057")]
		protected abstract class PJLCAFJDINA
		{
			[Cpp2IlInjected.Token(Token = "0x2000058")]
			public class PDEENPGEBKL
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400033A")]
				public readonly Mesh JONPDEDOKJJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400033B")]
				public readonly Material[] HCIKPPHADLL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400033C")]
				public readonly Transform[] IFIBKFPPIDA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400033D")]
				public readonly Matrix4x4[] PEKJAFFHAJD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400033E")]
				public readonly Transform EOGCOFHIBKH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x400033F")]
				public readonly bool MMFINMEMBOK;

				[Cpp2IlInjected.Token(Token = "0x60002C2")]
				[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
				protected PDEENPGEBKL()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002C3")]
				[Cpp2IlInjected.Address(RVA = "0x6E83260", Offset = "0x6E82660", VA = "0x186E83260")]
				public PDEENPGEBKL(Mesh DFFOPHDLMNO, Material[] FGFPMJMIMKP, bool ABINCFMPPFI, Transform[] LOJHGCGFDGH, Transform KFHFFGEJEGM, Matrix4x4[] CFDKBOCAGJN)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002C4")]
				[Cpp2IlInjected.Address(RVA = "0x6E831A0", Offset = "0x6E825A0", VA = "0x186E831A0")]
				private PDEENPGEBKL(SkinnedMeshRenderer BMCELCCICHP, Material[] AJLAJJKBICB)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002C5")]
				[Cpp2IlInjected.Address(RVA = "0x6E830B0", Offset = "0x6E824B0", VA = "0x186E830B0")]
				private PDEENPGEBKL(MeshRenderer PBLNNEJCONP, Transform KFHFFGEJEGM, Material[] AJLAJJKBICB)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002C6")]
				[Cpp2IlInjected.Address(RVA = "0x6E82D90", Offset = "0x6E82190", VA = "0x186E82D90")]
				public static PDEENPGEBKL GEMJINEFLHL(Renderer IEBCHEIKEKK, Material[] AJLAJJKBICB)
				{
					return null;
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000337")]
			public readonly HAPHCDJNHOG HJDCAEMFHOD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000338")]
			public readonly Transform CKJFMIMIJJJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000339")]
			public readonly bool CIFGOBEMNBB;

			[Cpp2IlInjected.Token(Token = "0x1700007F")]
			public virtual bool ILNFCODDIJI
			{
				[Cpp2IlInjected.Token(Token = "0x60002BB")]
				[Cpp2IlInjected.Address(RVA = "0x90FCA0", Offset = "0x90F0A0", VA = "0x18090FCA0", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000080")]
			public virtual bool JKEGDJCIDDN
			{
				[Cpp2IlInjected.Token(Token = "0x60002BC")]
				[Cpp2IlInjected.Address(RVA = "0x90FCA0", Offset = "0x90F0A0", VA = "0x18090FCA0", Slot = "5")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000081")]
			public virtual IBBAPAKLKFF.JPAHGGFNNNL DNMJFODFMIN
			{
				[Cpp2IlInjected.Token(Token = "0x60002BD")]
				[Cpp2IlInjected.Address(RVA = "0x8C6D90", Offset = "0x8C6190", VA = "0x1808C6D90", Slot = "6")]
				get
				{
					return default(IBBAPAKLKFF.JPAHGGFNNNL);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000082")]
			public bool NMIPPECKMCM
			{
				[Cpp2IlInjected.Token(Token = "0x60002BE")]
				[Cpp2IlInjected.Address(RVA = "0x6E83710", Offset = "0x6E82B10", VA = "0x186E83710")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002BF")]
			[Cpp2IlInjected.Address(RVA = "0x6E83720", Offset = "0x6E82B20", VA = "0x186E83720")]
			protected PJLCAFJDINA(HAPHCDJNHOG JBCPDKGINNI, Transform KODBOPJDJNI, bool IBDNPIKCNCD = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C0")]
			[Cpp2IlInjected.Address(Slot = "7")]
			public abstract CLHPIMOBJFN AJOOIBLMDPG(List<KMJKLFGFJJB> HEJEHEAIAKG, List<KMJKLFGFJJB> DCECOKJEMKM);

			[Cpp2IlInjected.Token(Token = "0x60002C1")]
			[Cpp2IlInjected.Address(Slot = "8")]
			public abstract PDEENPGEBKL JCHJEMKBNHO(int JGOIAEJPNGK, PlayerHandBones GBELHLJGPOM);
		}

		[Cpp2IlInjected.Token(Token = "0x2000059")]
		protected class IOPBOFBJFHD : PJLCAFJDINA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000340")]
			protected readonly BodyPartLODs FDIFKKLGOAD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000341")]
			protected readonly Material[] AHMBCDGKBNJ;

			[Cpp2IlInjected.Token(Token = "0x60002C7")]
			[Cpp2IlInjected.Address(RVA = "0x6E7DC60", Offset = "0x6E7D060", VA = "0x186E7DC60")]
			public IOPBOFBJFHD(HAPHCDJNHOG JBCPDKGINNI, BodyPartLODs COJFNOOPDNH, Material OKFLDPLMBEI, [Optional] Transform KODBOPJDJNI, bool IBDNPIKCNCD = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002C8")]
			[Cpp2IlInjected.Address(RVA = "0x6E7D9A0", Offset = "0x6E7CDA0", VA = "0x186E7D9A0", Slot = "7")]
			public override CLHPIMOBJFN AJOOIBLMDPG(List<KMJKLFGFJJB> HEJEHEAIAKG, List<KMJKLFGFJJB> DCECOKJEMKM)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002C9")]
			[Cpp2IlInjected.Address(RVA = "0x6E7DA30", Offset = "0x6E7CE30", VA = "0x186E7DA30", Slot = "8")]
			public override PDEENPGEBKL JCHJEMKBNHO(int JGOIAEJPNGK, PlayerHandBones GBELHLJGPOM)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002CA")]
			[Cpp2IlInjected.Address(RVA = "0x6E7DBF0", Offset = "0x6E7CFF0", VA = "0x186E7DBF0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005A")]
		protected class MKIGKKEKOOI : PJLCAFJDINA
		{
			[Cpp2IlInjected.Token(Token = "0x17000083")]
			public override bool ILNFCODDIJI
			{
				[Cpp2IlInjected.Token(Token = "0x60002CB")]
				[Cpp2IlInjected.Address(RVA = "0x8E1B40", Offset = "0x8E0F40", VA = "0x1808E1B40", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000084")]
			public override bool JKEGDJCIDDN
			{
				[Cpp2IlInjected.Token(Token = "0x60002CC")]
				[Cpp2IlInjected.Address(RVA = "0x6E80D30", Offset = "0x6E80130", VA = "0x186E80D30", Slot = "5")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000085")]
			public AMLFLFEOPIJ MCGICMKBBOM
			{
				[Cpp2IlInjected.Token(Token = "0x60002CD")]
				[Cpp2IlInjected.Address(RVA = "0x8C7960", Offset = "0x8C6D60", VA = "0x1808C7960")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60002CE")]
				[Cpp2IlInjected.Address(RVA = "0x8C7DD0", Offset = "0x8C71D0", VA = "0x1808C7DD0")]
				[CompilerGenerated]
				protected set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002CF")]
			[Cpp2IlInjected.Address(RVA = "0x6E80DF0", Offset = "0x6E801F0", VA = "0x186E80DF0")]
			public MKIGKKEKOOI(HAPHCDJNHOG JBCPDKGINNI, Transform KODBOPJDJNI, AMLFLFEOPIJ NKJAMFONIBA, bool IBDNPIKCNCD = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D0")]
			[Cpp2IlInjected.Address(RVA = "0x6E80CA0", Offset = "0x6E800A0", VA = "0x186E80CA0", Slot = "7")]
			public override CLHPIMOBJFN AJOOIBLMDPG(List<KMJKLFGFJJB> HEJEHEAIAKG, List<KMJKLFGFJJB> DCECOKJEMKM)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002D1")]
			[Cpp2IlInjected.Address(RVA = "0x8C6D90", Offset = "0x8C6190", VA = "0x1808C6D90", Slot = "8")]
			public override PDEENPGEBKL JCHJEMKBNHO(int JGOIAEJPNGK, PlayerHandBones GBELHLJGPOM)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002D2")]
			[Cpp2IlInjected.Address(RVA = "0x6E80D80", Offset = "0x6E80180", VA = "0x186E80D80", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005B")]
		public class NAKHFBENBFF
		{
			[Cpp2IlInjected.Token(Token = "0x200005C")]
			public enum MDJFLELDIPM
			{
				[Cpp2IlInjected.Token(Token = "0x4000353")]
				PLAYER_PUPPET,
				[Cpp2IlInjected.Token(Token = "0x4000354")]
				PLAYER_DISPLAY_POSER,
				[Cpp2IlInjected.Token(Token = "0x4000355")]
				PLAYER_HAND,
				[Cpp2IlInjected.Token(Token = "0x4000356")]
				STNMONSTERCOSTUME_OPTION_HIDE_EXCEPT_UI,
				[Cpp2IlInjected.Token(Token = "0x4000357")]
				PLAYER_HAND_POINTING,
				[Cpp2IlInjected.Token(Token = "0x4000358")]
				STNMONSTERCOSTUME_OPTION_ALWAYS_HIDE,
				[Cpp2IlInjected.Token(Token = "0x4000359")]
				EDITOR
			}

			[Cpp2IlInjected.Token(Token = "0x4000343")]
			public static readonly int JKGLKIFMDIJ;

			[Cpp2IlInjected.Token(Token = "0x4000344")]
			public static readonly int LFCNJPHFFEG;

			[Cpp2IlInjected.Token(Token = "0x4000345")]
			public static readonly int JKGIKPKKJFE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000346")]
			protected readonly HEIHCLNBOCO LBHEFJKPGBJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000347")]
			protected readonly EBGMDAPFGGA GNMOFOOJLDC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000348")]
			protected readonly Animator GNPPIHFIHKF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000349")]
			protected readonly Transform BJJDNKEOMBG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400034A")]
			protected readonly Vector3 GAENEALAHEH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400034B")]
			protected readonly Transform IDOMCOPNPGJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400034C")]
			protected readonly Vector3 EDPHBKIAJMJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x400034D")]
			protected bool PBNOKBIEKHN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400034E")]
			protected IGIKALHDICH JBLPMCEICAA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400034F")]
			protected bool BFFKNOPCPAI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
			[Cpp2IlInjected.Token(Token = "0x4000350")]
			protected float GBBDOPAPNDD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000351")]
			protected PMGDGCHNEPM<LICKDOCMADF> MEHGOIECEAJ;

			[Cpp2IlInjected.Token(Token = "0x17000086")]
			public IGIKALHDICH CAEGIJMKMDG
			{
				[Cpp2IlInjected.Token(Token = "0x60002D3")]
				[Cpp2IlInjected.Address(RVA = "0x8CAEC0", Offset = "0x8CA2C0", VA = "0x1808CAEC0")]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60002D4")]
				[Cpp2IlInjected.Address(RVA = "0x8CAF30", Offset = "0x8CA330", VA = "0x1808CAF30")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000087")]
			public bool BBGBDIBOPAH
			{
				[Cpp2IlInjected.Token(Token = "0x60002D5")]
				[Cpp2IlInjected.Address(RVA = "0xAB1FD0", Offset = "0xAB13D0", VA = "0x180AB1FD0")]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x60002D6")]
				[Cpp2IlInjected.Address(RVA = "0x6E81350", Offset = "0x6E80750", VA = "0x186E81350")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000088")]
			public bool OLMEPKKEEJN
			{
				[Cpp2IlInjected.Token(Token = "0x60002D7")]
				[Cpp2IlInjected.Address(RVA = "0x8D0DC0", Offset = "0x8D01C0", VA = "0x1808D0DC0")]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x60002D8")]
				[Cpp2IlInjected.Address(RVA = "0x6E80FA0", Offset = "0x6E803A0", VA = "0x186E80FA0")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000089")]
			public float IKCAIEPMOGO
			{
				[Cpp2IlInjected.Token(Token = "0x60002D9")]
				[Cpp2IlInjected.Address(RVA = "0xC80050", Offset = "0xC7F450", VA = "0x180C80050")]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x60002DA")]
				[Cpp2IlInjected.Address(RVA = "0x6E81120", Offset = "0x6E80520", VA = "0x186E81120")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008A")]
			public LICKDOCMADF ECLGFLBOAGE
			{
				[Cpp2IlInjected.Token(Token = "0x60002DB")]
				[Cpp2IlInjected.Address(RVA = "0x6E80F60", Offset = "0x6E80360", VA = "0x186E80F60")]
				get
				{
					return default(LICKDOCMADF);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002DC")]
			[Cpp2IlInjected.Address(RVA = "0x6E81530", Offset = "0x6E80930", VA = "0x186E81530")]
			public bool KCHBOPABFAN(LICKDOCMADF EPLAGBOKLNB, object CMNJCPJBHGE, MDJFLELDIPM HPFPPNDKBPG)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002DD")]
			[Cpp2IlInjected.Address(RVA = "0x6E80E60", Offset = "0x6E80260", VA = "0x186E80E60")]
			public bool CFFHBIHKPFF(object CMNJCPJBHGE)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002DE")]
			[Cpp2IlInjected.Address(RVA = "0x6E81AE0", Offset = "0x6E80EE0", VA = "0x186E81AE0")]
			protected NAKHFBENBFF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002DF")]
			[Cpp2IlInjected.Address(RVA = "0x6E81B70", Offset = "0x6E80F70", VA = "0x186E81B70")]
			public NAKHFBENBFF(HEIHCLNBOCO LBHEFJKPGBJ, IGIKALHDICH KDCEFDKFHMA, Animator GNPPIHFIHKF, Transform BJJDNKEOMBG, Transform IDOMCOPNPGJ, Vector3 GAENEALAHEH, Vector3 EDPHBKIAJMJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002E0")]
			[Cpp2IlInjected.Address(RVA = "0x6E81070", Offset = "0x6E80470", VA = "0x186E81070")]
			private void FLDHCEHOCED(ushort HNENDOBJNJB, ushort NPCMPMHPOBH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002E1")]
			[Cpp2IlInjected.Address(RVA = "0x6E81260", Offset = "0x6E80660", VA = "0x186E81260")]
			protected void HPEJPKHJAEO(ushort HNENDOBJNJB, ushort NPCMPMHPOBH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002E2")]
			[Cpp2IlInjected.Address(RVA = "0x6E81860", Offset = "0x6E80C60", VA = "0x186E81860")]
			protected void NDJFHELEKJK(ushort HNENDOBJNJB, ushort NPCMPMHPOBH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002E3")]
			[Cpp2IlInjected.Address(RVA = "0x6E81640", Offset = "0x6E80A40", VA = "0x186E81640")]
			protected void KFKFINKGCKO(ushort HNENDOBJNJB, ushort NPCMPMHPOBH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002E4")]
			[Cpp2IlInjected.Address(RVA = "0x6E81420", Offset = "0x6E80820", VA = "0x186E81420")]
			protected void JOEEKIFOPGI(ushort HNENDOBJNJB, ushort NPCMPMHPOBH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002E5")]
			[Cpp2IlInjected.Address(RVA = "0x6E81760", Offset = "0x6E80B60", VA = "0x186E81760")]
			protected void KLMANFCDPNA(ushort HNENDOBJNJB, ushort NPCMPMHPOBH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002E6")]
			[Cpp2IlInjected.Address(RVA = "0x6E817C0", Offset = "0x6E80BC0", VA = "0x186E817C0")]
			protected void KMHBHBNFEJH(ushort HNENDOBJNJB, ushort NPCMPMHPOBH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002E7")]
			[Cpp2IlInjected.Address(RVA = "0x6E81810", Offset = "0x6E80C10", VA = "0x186E81810")]
			protected void LJAPFGFGDHH(ushort HNENDOBJNJB, ushort NPCMPMHPOBH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002E8")]
			[Cpp2IlInjected.Address(RVA = "0x6E81920", Offset = "0x6E80D20", VA = "0x186E81920")]
			protected void OFNIEJDGCEF(ushort HNENDOBJNJB, ushort NPCMPMHPOBH)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005D")]
		public class KMAKPFEJINM : IDisposable
		{
			[Cpp2IlInjected.Token(Token = "0x400035A")]
			public const int MLBCGMBIEKL = 16;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400035B")]
			protected MaterialPropertyBlock BAGNGADDOGA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400035C")]
			public Color? NEFAJGBFKMM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x400035D")]
			public Color? FADPAKFLEOG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400035E")]
			public Color? LHPDMLELBJE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x400035F")]
			public Color PGODDBGJAKI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
			[Cpp2IlInjected.Token(Token = "0x4000360")]
			public Color FKPHGGJBPMH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
			[Cpp2IlInjected.Token(Token = "0x4000361")]
			public Color EPHHJIBDGMD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x4000362")]
			public Texture2D MDGGKGAMNLF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x4000363")]
			public Texture2D NNMKFFBGLDA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x4000364")]
			protected Dictionary<BNDEMEMEPME, int> FDENBAECNJB;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x4000365")]
			protected ENEGMIMINPJ[] BJEIPFICFMI;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x4000366")]
			public Vector4[] HBKLODFGPNM;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x4000367")]
			public Vector4[] OFPHHBGCHJG;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x4000368")]
			public Vector4[] EEFALBGDJPM;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x4000369")]
			public Vector4[] HGGPIMNHOFC;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
			[Cpp2IlInjected.Token(Token = "0x400036A")]
			public Vector4[] PONKNKDGLDC;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
			[Cpp2IlInjected.Token(Token = "0x400036B")]
			public Vector4[] IKMDNNHJGNJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x400036C")]
			protected List<Texture2D> PANJGBBMENA;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x400036D")]
			protected Vector4[] LAKONOACIIO;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
			[Cpp2IlInjected.Token(Token = "0x400036E")]
			protected List<Texture2D> CFGBKHMGPDH;

			[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
			[Cpp2IlInjected.Token(Token = "0x400036F")]
			protected float[] CJKPHPHDNBK;

			[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
			[Cpp2IlInjected.Token(Token = "0x4000370")]
			protected Vector4[] JOGJBKIDCJN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
			[Cpp2IlInjected.Token(Token = "0x4000371")]
			protected float[] NHOCDOJDHFG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
			[Cpp2IlInjected.Token(Token = "0x4000372")]
			public float[] BEPNJLPKHLP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
			[Cpp2IlInjected.Token(Token = "0x4000373")]
			protected List<Texture2D> HGMDHAFHHDG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
			[Cpp2IlInjected.Token(Token = "0x4000374")]
			protected float[] PJNJCJPAJEI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
			[Cpp2IlInjected.Token(Token = "0x4000375")]
			protected List<Texture2D> IPNJAMPCPAJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
			[Cpp2IlInjected.Token(Token = "0x4000376")]
			protected Vector4[] DMCFMKJCFBH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
			[Cpp2IlInjected.Token(Token = "0x4000377")]
			protected float[] CNCBLAPEMBK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
			[Cpp2IlInjected.Token(Token = "0x4000378")]
			protected Vector4[] ELIMAEKIOKK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
			[Cpp2IlInjected.Token(Token = "0x4000379")]
			public float[] LFJEHLNIMCM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
			[Cpp2IlInjected.Token(Token = "0x400037A")]
			public Texture2DArray CGOPHKHILON;

			[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
			[Cpp2IlInjected.Token(Token = "0x400037B")]
			public Texture2DArray FFHCMGAAPHN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
			[Cpp2IlInjected.Token(Token = "0x400037C")]
			public Texture2DArray FHNCECGCFAP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
			[Cpp2IlInjected.Token(Token = "0x400037D")]
			public Texture2DArray NBANBOLMDIA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
			[Cpp2IlInjected.Token(Token = "0x400037E")]
			protected bool IHIOOAJDENC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x16C")]
			[Cpp2IlInjected.Token(Token = "0x400037F")]
			protected int JOAOBKOKJGO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
			[Cpp2IlInjected.Token(Token = "0x4000380")]
			protected Vector2? HHLEIMBPHJP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x17C")]
			[Cpp2IlInjected.Token(Token = "0x4000381")]
			protected TextureFormat BOMFDPPMNPM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
			[Cpp2IlInjected.Token(Token = "0x4000382")]
			protected Vector2? PFPLAKOFOBD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18C")]
			[Cpp2IlInjected.Token(Token = "0x4000383")]
			protected TextureFormat PCFMOMONKMP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
			[Cpp2IlInjected.Token(Token = "0x4000384")]
			protected Vector2? MOPNCDGCNCO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x19C")]
			[Cpp2IlInjected.Token(Token = "0x4000385")]
			protected TextureFormat IJKMFFONHPB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
			[Cpp2IlInjected.Token(Token = "0x4000386")]
			protected Vector2? AKKIBJIMKCO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1AC")]
			[Cpp2IlInjected.Token(Token = "0x4000387")]
			protected TextureFormat CGINCOAKDJP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
			[Cpp2IlInjected.Token(Token = "0x4000388")]
			protected bool NDHHFMKHGIO;

			[Cpp2IlInjected.Token(Token = "0x4000389")]
			protected static int CFOOKPGPKDE;

			[Cpp2IlInjected.Token(Token = "0x400038A")]
			protected static int OLKHMFMBGJJ;

			[Cpp2IlInjected.Token(Token = "0x400038B")]
			protected static int MDMNIPNKFFE;

			[Cpp2IlInjected.Token(Token = "0x400038C")]
			protected static int GIJLIIGGEPD;

			[Cpp2IlInjected.Token(Token = "0x400038D")]
			protected static int DLEFKHJPKGF;

			[Cpp2IlInjected.Token(Token = "0x400038E")]
			protected static int BMNLMDFHMPK;

			[Cpp2IlInjected.Token(Token = "0x400038F")]
			protected static int FDPGAGFJJDG;

			[Cpp2IlInjected.Token(Token = "0x4000390")]
			protected static int CKEAFLDBKFE;

			[Cpp2IlInjected.Token(Token = "0x4000391")]
			protected static int BBHKLAHOJPD;

			[Cpp2IlInjected.Token(Token = "0x4000392")]
			protected static int MPMBENOIFOA;

			[Cpp2IlInjected.Token(Token = "0x4000393")]
			protected static int DLFFIDMIGOP;

			[Cpp2IlInjected.Token(Token = "0x4000394")]
			protected static int DAFMAJIKHIA;

			[Cpp2IlInjected.Token(Token = "0x4000395")]
			protected static int JICMICMLGBP;

			[Cpp2IlInjected.Token(Token = "0x4000396")]
			protected static int EFJHEALNMAO;

			[Cpp2IlInjected.Token(Token = "0x4000397")]
			protected static int DMBBKEKGAGP;

			[Cpp2IlInjected.Token(Token = "0x4000398")]
			protected static int LKFINHMCFJC;

			[Cpp2IlInjected.Token(Token = "0x4000399")]
			protected static int LNNLPBKFPKJ;

			[Cpp2IlInjected.Token(Token = "0x400039A")]
			protected static int DIPOCNGGBFK;

			[Cpp2IlInjected.Token(Token = "0x400039B")]
			protected static int AMJOKBDPADF;

			[Cpp2IlInjected.Token(Token = "0x400039C")]
			protected static int EJFANAHBEFB;

			[Cpp2IlInjected.Token(Token = "0x60002EA")]
			[Cpp2IlInjected.Address(RVA = "0x6E80240", Offset = "0x6E7F640", VA = "0x186E80240")]
			protected KMAKPFEJINM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002EB")]
			[Cpp2IlInjected.Address(RVA = "0x6E80700", Offset = "0x6E7FB00", VA = "0x186E80700")]
			public KMAKPFEJINM(Color CHJKFNKNDDM, Color LKOOFJKIION, Color NJFKCBMLMJO, Color? GDOIOFNNJIJ, Color? GFNPHNBCPCI, Color? JKGCKCPHJHL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002EC")]
			[Cpp2IlInjected.Address(RVA = "0x6E7E850", Offset = "0x6E7DC50", VA = "0x186E7E850")]
			public int BGEKAAOJMGJ(Material NHPFPMFEOAA, ENEGMIMINPJ COILFOKBAOH, CCEHNAIIODM MMNLEBJJFJM, HAPHCDJNHOG JBCPDKGINNI)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002ED")]
			[Cpp2IlInjected.Address(RVA = "0x6E7E940", Offset = "0x6E7DD40", VA = "0x186E7E940")]
			public int BGEKAAOJMGJ(BNDEMEMEPME LDCKBFKFIKC)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002EE")]
			[Cpp2IlInjected.Address(RVA = "0x6E7EFA0", Offset = "0x6E7E3A0", VA = "0x186E7EFA0")]
			public int MEGLIHNJMDI(Material NHPFPMFEOAA, Color ECAGNHGBBCA, Color BFAPBFOOOGH, Color HOGNAKEHJDH, Color CFHJFJKNMAJ, Color ADEDFOABBKP, Texture2D POGKBFFLDOB, Vector4 CPNLGFINPAJ, Texture2D JCAFGDLEIFC, Vector4 OBLKLPJEBBN, float BDFDHGOBNMH, float DLCCABLODHM, Texture2D MGBJEGGMNLI, Vector4 OKGACHBKAOI, float PCJKLEMCADA, Texture2D KJENGNEDDIB, float HJOLJBJKFLE, Color GFIDKOEHBFB, Vector4 DGHGCCKKOHP, ENEGMIMINPJ COILFOKBAOH, CCEHNAIIODM MMNLEBJJFJM, HAPHCDJNHOG JBCPDKGINNI)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002EF")]
			[Cpp2IlInjected.Address(RVA = "0x6E7EDE0", Offset = "0x6E7E1E0", VA = "0x186E7EDE0")]
			protected void KFMJGNHHMAF([Out] Texture2DArray KLKNIIEMHJB, [Out] Texture2DArray BKALAOHJIEN, [Out] Texture2DArray MIBANDGJHMP, [Out] Texture2DArray GHNIPNECLJA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F0")]
			[Cpp2IlInjected.Address(RVA = "0x6E7FC90", Offset = "0x6E7F090", VA = "0x186E7FC90")]
			public void NBGLLCKPAMC(PlayerAvatarDisplayBase DPAMOENLNKM, Renderer IEBCHEIKEKK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F1")]
			[Cpp2IlInjected.Address(RVA = "0x6E7DD60", Offset = "0x6E7D160", VA = "0x186E7DD60")]
			protected void ABEGJDEHJLG(PlayerAvatarDisplayBase DPAMOENLNKM, Renderer IEBCHEIKEKK, int KFGMONBNAFF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F2")]
			[Cpp2IlInjected.Address(RVA = "0x6E7EBF0", Offset = "0x6E7DFF0", VA = "0x186E7EBF0")]
			private Color ICKCKGICBKP(Color ECLIAJFIJFP, ENEGMIMINPJ PBKGBNNFEAK)
			{
				return default(Color);
			}

			[Cpp2IlInjected.Token(Token = "0x60002F3")]
			[Cpp2IlInjected.Address(RVA = "0x6E7EA10", Offset = "0x6E7DE10", VA = "0x186E7EA10")]
			private Color EKDJLCFHGAC(Color JMHDLLGLCAA, ENEGMIMINPJ PBKGBNNFEAK)
			{
				return default(Color);
			}

			[Cpp2IlInjected.Token(Token = "0x60002F4")]
			[Cpp2IlInjected.Address(RVA = "0x6E7EB60", Offset = "0x6E7DF60", VA = "0x186E7EB60")]
			protected void EKOJHADNAGJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F5")]
			[Cpp2IlInjected.Address(RVA = "0x6E7E9D0", Offset = "0x6E7DDD0", VA = "0x186E7E9D0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200005E")]
		public struct PlayerHandBones
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400039D")]
			public Transform[] LeftHandBones;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400039E")]
			public Transform LeftHandRoot;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400039F")]
			public Transform[] RightHandBones;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003A0")]
			public Transform RightHandRoot;

			[Cpp2IlInjected.Token(Token = "0x60002F7")]
			[Cpp2IlInjected.Address(RVA = "0x6E89670", Offset = "0x6E88A70", VA = "0x186E89670")]
			public void DHJNDONNHHF(HAPHCDJNHOG JBCPDKGINNI, [Out] Transform NIMLNKDMKHI, [Out] Transform[] LOJHGCGFDGH)
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200005F")]
		protected struct BodyPartLODs
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003A1")]
			public Mesh[] LODs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003A2")]
			public bool UseHandBones;
		}

		[Cpp2IlInjected.Token(Token = "0x2000061")]
		[CompilerGenerated]
		private sealed class FGDGAAPLIGF : IEnumerable<SkinnedMeshRenderer>, IEnumerable, IEnumerator<SkinnedMeshRenderer>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003AA")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003AB")]
			private SkinnedMeshRenderer <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003AC")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003AD")]
			public PlayerAvatarDisplayBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003AE")]
			private SkinnedMeshRenderer[] <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003AF")]
			private int <>7__wrap2;

			[Cpp2IlInjected.Token(Token = "0x1700008B")]
			SkinnedMeshRenderer IEnumerator<SkinnedMeshRenderer>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000303")]
				[Cpp2IlInjected.Address(RVA = "0x8C7D90", Offset = "0x8C7190", VA = "0x1808C7D90", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008C")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000305")]
				[Cpp2IlInjected.Address(RVA = "0x8C7D90", Offset = "0x8C7190", VA = "0x1808C7D90", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000300")]
			[Cpp2IlInjected.Address(RVA = "0xADC3A0", Offset = "0xADB7A0", VA = "0x180ADC3A0")]
			[DebuggerHidden]
			public FGDGAAPLIGF(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000301")]
			[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000302")]
			[Cpp2IlInjected.Address(RVA = "0x6E7C9B0", Offset = "0x6E7BDB0", VA = "0x186E7C9B0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000304")]
			[Cpp2IlInjected.Address(RVA = "0x6E7CC30", Offset = "0x6E7C030", VA = "0x186E7CC30", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000306")]
			[Cpp2IlInjected.Address(RVA = "0x6E7CB80", Offset = "0x6E7BF80", VA = "0x186E7CB80", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<SkinnedMeshRenderer> IEnumerable<SkinnedMeshRenderer>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000307")]
			[Cpp2IlInjected.Address(RVA = "0x6E7CB80", Offset = "0x6E7BF80", VA = "0x186E7CB80", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000062")]
		[CompilerGenerated]
		private sealed class PCFIIBKFMCE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003B0")]
			public PlayerAvatarDisplayBase display;

			[Cpp2IlInjected.Token(Token = "0x6000308")]
			[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
			public PCFIIBKFMCE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000309")]
			[Cpp2IlInjected.Address(RVA = "0x6E82CB0", Offset = "0x6E820B0", VA = "0x186E82CB0")]
			internal bool KIMMFDMIOHB()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000063")]
		[CompilerGenerated]
		private sealed class MFFDBLLIIAP : IEnumerator<ONHNFKGBFKG>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003B1")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003B2")]
			private ONHNFKGBFKG <>2__current;

			[Cpp2IlInjected.Token(Token = "0x1700008D")]
			private ONHNFKGBFKG System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600030D")]
				[Cpp2IlInjected.Address(RVA = "0x8C7D90", Offset = "0x8C7190", VA = "0x1808C7D90", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008E")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600030F")]
				[Cpp2IlInjected.Address(RVA = "0x8C7D90", Offset = "0x8C7190", VA = "0x1808C7D90", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600030A")]
			[Cpp2IlInjected.Address(RVA = "0x8CAD70", Offset = "0x8CA170", VA = "0x1808CAD70")]
			[DebuggerHidden]
			public MFFDBLLIIAP(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600030B")]
			[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600030C")]
			[Cpp2IlInjected.Address(RVA = "0x6E809C0", Offset = "0x6E7FDC0", VA = "0x186E809C0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600030E")]
			[Cpp2IlInjected.Address(RVA = "0x6E80C50", Offset = "0x6E80050", VA = "0x186E80C50", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000064")]
		[CompilerGenerated]
		private struct HFMOCHBJKLJ : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003B3")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003B4")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003B5")]
			public PlayerAvatarDisplayBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003B6")]
			public KKGOEONLCJM avatarData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003B7")]
			private bool <forceRebuild>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003B8")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000310")]
			[Cpp2IlInjected.Address(RVA = "0x6E7CFA0", Offset = "0x6E7C3A0", VA = "0x186E7CFA0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000311")]
			[Cpp2IlInjected.Address(RVA = "0x6E7D650", Offset = "0x6E7CA50", VA = "0x186E7D650", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000065")]
		[CompilerGenerated]
		private sealed class NLDBLFKGMMD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003B9")]
			public string overrideIdentifier;

			[Cpp2IlInjected.Token(Token = "0x6000312")]
			[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
			public NLDBLFKGMMD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000313")]
			[Cpp2IlInjected.Address(RVA = "0x6E82800", Offset = "0x6E81C00", VA = "0x186E82800")]
			internal bool IHJALBLIKKL(NCBGGKADNMM selection)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000066")]
		[CompilerGenerated]
		private sealed class HCLMLCHCJGL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003BA")]
			public PlayerAvatarDisplayBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003BB")]
			public AvatarItemBodyType avatarItemBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003BC")]
			public Func<AMMGOODCICE<Dictionary<string, PLBFKJMGACI<Texture2D>>>> <>9__2;

			[Cpp2IlInjected.Token(Token = "0x6000314")]
			[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
			public HCLMLCHCJGL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000315")]
			[Cpp2IlInjected.Address(RVA = "0x6E7CD00", Offset = "0x6E7C100", VA = "0x186E7CD00")]
			internal (JNDAODDCIHF, AMMGOODCICE<Dictionary<string, PLBFKJMGACI<Texture2D>>>) AAONOHGCNOG(Dictionary<string, FMNHOILILHF> avatarItems)
			{
				return default((JNDAODDCIHF, AMMGOODCICE<Dictionary<string, PLBFKJMGACI<Texture2D>>>));
			}

			[Cpp2IlInjected.Token(Token = "0x6000316")]
			[Cpp2IlInjected.Address(RVA = "0x6E7CF30", Offset = "0x6E7C330", VA = "0x186E7CF30")]
			internal AMMGOODCICE<Dictionary<string, PLBFKJMGACI<Texture2D>>> EIEJHGILHJN()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000317")]
			[Cpp2IlInjected.Address(RVA = "0x6E7CEF0", Offset = "0x6E7C2F0", VA = "0x186E7CEF0")]
			internal void AFIPMKELAFD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000067")]
		[CompilerGenerated]
		private sealed class EBIDFBANBKE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003BD")]
			public Transform transformToCheck;

			[Cpp2IlInjected.Token(Token = "0x6000318")]
			[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
			public EBIDFBANBKE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000319")]
			[Cpp2IlInjected.Address(RVA = "0x6E7C700", Offset = "0x6E7BB00", VA = "0x186E7C700")]
			internal bool BPDNPHDFHCN(SkinnedMeshRenderer x)
			{
				return default(bool);
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000068")]
		[CompilerGenerated]
		private struct LIOOMEGKOKH : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003BE")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003BF")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003C0")]
			public PlayerAvatarDisplayBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003C1")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600031A")]
			[Cpp2IlInjected.Address(RVA = "0x6E80790", Offset = "0x6E7FB90", VA = "0x186E80790", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600031B")]
			[Cpp2IlInjected.Address(RVA = "0x6E80960", Offset = "0x6E7FD60", VA = "0x186E80960", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400029F")]
		protected static readonly int NPAMKBMIFHD;

		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		protected static readonly int FCIGODFMFCM;

		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		protected static readonly int LGECBDPJACJ;

		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		protected static readonly int LCMDOGINFDM;

		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		protected static readonly int HLIJEBBMKKN;

		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		protected static readonly int PDDJJCIBLAE;

		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		protected static readonly int[] IADFHMDIIAF;

		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		protected static readonly int[] MFLHDMLJCHB;

		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		protected static readonly int[] OMIHODIKGKN;

		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		protected static readonly int[] HMGGFKKEFCG;

		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		protected static readonly int[] INFDKHAMJAE;

		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		protected static readonly int[] MCNDDFKJKOB;

		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		protected static List<PlayerAvatarDisplayBase> ALBOOOMKJJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		protected JGADMJKLMAM CIGONMOECHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		protected bool LAPAKCLPKFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		protected bool OOGBJCNDKJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		[SerializeField]
		public AvatarBodyShapeVault BodyShapeVault;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		[SerializeField]
		public AvatarFaceShapeVault FaceShapeVault;

		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		protected static readonly int[] DCBJICCHFMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		[SerializeField]
		protected Material bodyPartMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		protected Dictionary<BNDEMEMEPME, Material> HJEJAFEGOPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		protected Dictionary<BNDEMEMEPME, Material> CMMMEKHOOBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		[SerializeField]
		protected bool ignorePlayerMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		[SerializeField]
		protected Transform trackingSpace;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		[SerializeField]
		protected BodyPartLODs Head;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		[SerializeField]
		protected BodyPartLODs Ear;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		[SerializeField]
		protected BodyPartLODs Torso;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		[SerializeField]
		protected BodyPartLODs Hand;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		[SerializeField]
		protected BodyPartLODs HandPointing;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		[SerializeField]
		public PlayerHandBones HandBones;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		[SerializeField]
		public Transform remoteMeshBase;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		public readonly SkinnedMeshRenderer[] CurrentDefaultSkinnedMeshRenderers;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		public readonly SkinnedMeshRenderer[] NextDefaultSkinnedMeshRenderers;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		public readonly SkinnedMeshRenderer[] CurrentVisibleInFirstPersonSkinnedMeshRenderers;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		public readonly SkinnedMeshRenderer[] NextVisibleInFirstPersonSkinnedMeshRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		[SerializeField]
		public Transform firstPersonMeshBase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		[SerializeField]
		protected Shader uberShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		[SerializeField]
		protected Shader agAvatarShader;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		protected Material JNIBBGJIBKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		protected BIPIJKDNBKE PJKDCAGAOFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		private IGIKALHDICH BKCIOFKLNEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		private IGIKALHDICH IJDMCEGKIBA;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		protected Material PANKLCHBBHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		[SerializeField]
		protected Transform headPropAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		[SerializeField]
		protected Transform hatAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		[SerializeField]
		public Transform hemisphereBase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		protected FitMeshHemisphere EOHGOCKFLCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		protected bool IOBGBEJPLPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		protected NBNLNGHNGFL EFMBOFGFAFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		protected bool JAGJILAHGOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		protected AnchorParamsRestrictions HHDPCHGHNHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		protected bool FKCEABHGLJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		protected Transform OKOGDAEEKKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		protected bool HPDPGIHFLGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x199")]
		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		protected bool NELGCDKAHHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19C")]
		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		protected Vector3 BFOHMONCLJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		protected Quaternion IKEAHHKENPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		protected Vector2 BDJONPIIJLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		protected FitMeshHemisphere HMBANPAALAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		[SerializeField]
		[KAIMDEABLJJ(PGGKFLBMAKK.SelfAndChildren, false, false, false)]
		protected PlayerFacialAnimatorBase facialAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		[SerializeField]
		protected Transform torsoPropAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		[SerializeField]
		protected Transform torsoRootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		[SerializeField]
		protected Transform headRootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		[SerializeField]
		protected Transform leftHandRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		[SerializeField]
		protected Transform leftHandDefaultScaleRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		[SerializeField]
		protected Transform rightHandRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		[SerializeField]
		protected Transform rightHandDefaultScaleRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		[SerializeField]
		protected Animator leftHandAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		[SerializeField]
		protected Animator rightHandAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		[SerializeField]
		protected Transform leftHandPointingRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		[SerializeField]
		protected Transform rightHandPointingRoot;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		protected Collider[] MGLMMIKMDJB;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		protected Collider[] AACBPEMMDHO;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		protected NAKHFBENBFF[] IBHAJPPECCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		[SerializeField]
		protected Mesh faceMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		public Dictionary<Renderer, KMAKPFEJINM> currentPropertyBlocks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		protected Dictionary<Renderer, KMAKPFEJINM> NNNFIBNCKNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		protected MOBCEOHADLA MKDHKJGILFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		protected JNDAODDCIHF MHNDDCBPGMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		public HODEOENILDN DistanceBand;

		[Cpp2IlInjected.FieldOffset(Offset = "0x26C")]
		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		protected int DDELMOPNCLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		protected PMGDGCHNEPM<EBGMDAPFGGA> MEHGOIECEAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		protected bool HEOGHACBFMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		protected Dictionary<NCBGGKADNMM, List<BNDEMEMEPME>> IAJALKKAFJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		protected Dictionary<NCBGGKADNMM, List<BNDEMEMEPME>> LCNOJLBGNNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		protected readonly Dictionary<string, PLBFKJMGACI<Texture2D>> LCEFJEKHMKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		protected readonly Dictionary<string, PLBFKJMGACI<Texture2D>> AIEAGHKIMEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		protected bool EFGPNEIOAMA;

		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		protected static int MPFGGGDFIEA;

		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		protected static List<BPJAODFLPAN> NFPMHPFMLKD;

		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		protected static GLHJGEGNDCM DMNHLENJCED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B0")]
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		protected Color? MGJGLAHHPKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C4")]
		[Cpp2IlInjected.Token(Token = "0x4000300")]
		protected bool NIMNNKBOEKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
		[Cpp2IlInjected.Token(Token = "0x4000301")]
		protected Color BHENNGEKEJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D8")]
		[Cpp2IlInjected.Token(Token = "0x4000302")]
		protected Color CGNJMABAEOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E8")]
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		protected Color FNPHPJIDOCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2F8")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		protected AvatarHairPattern ONGGOALNFJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x300")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		protected AMLFLFEOPIJ ILHGFIEPPND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x308")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		protected Color KDOJIJNGMAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x318")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		protected Color BJDNBIBMOAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x328")]
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		protected AvatarHairPattern AAPCEOCABDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x330")]
		[Cpp2IlInjected.Token(Token = "0x4000309")]
		protected AMLFLFEOPIJ HOFHOIBDIFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x338")]
		[Cpp2IlInjected.Token(Token = "0x400030A")]
		protected AMLFLFEOPIJ FNMKDMHJFDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x340")]
		[Cpp2IlInjected.Token(Token = "0x400030B")]
		protected Color OLMMBGNGGOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x350")]
		[Cpp2IlInjected.Token(Token = "0x400030C")]
		private AdditionalFeetData OLFLDFBFFAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x358")]
		[Cpp2IlInjected.Token(Token = "0x400030D")]
		protected NCBGGKADNMM? EEHJMMFHPJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x370")]
		[Cpp2IlInjected.Token(Token = "0x400030E")]
		protected Texture MPEGBPOMDAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x378")]
		[Cpp2IlInjected.Token(Token = "0x400030F")]
		protected Color MDEIAKGHFCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x388")]
		[Cpp2IlInjected.Token(Token = "0x4000310")]
		protected readonly IList<NCBGGKADNMM> NDDOHJLJDAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x390")]
		[Cpp2IlInjected.Token(Token = "0x4000311")]
		protected readonly IList<NCBGGKADNMM> KBEKLJOHKJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x398")]
		[Cpp2IlInjected.Token(Token = "0x4000312")]
		private AvatarItemBodyType FKDNBBEIHGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A0")]
		[Cpp2IlInjected.Token(Token = "0x4000313")]
		[SerializeField]
		protected AvatarFaceShape _currentFaceShape;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A8")]
		[Cpp2IlInjected.Token(Token = "0x4000314")]
		[SerializeField]
		protected AvatarBodyShape _currentBodyShape;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3B0")]
		[Cpp2IlInjected.Token(Token = "0x4000315")]
		[SerializeField]
		protected bool _hideEars;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3B1")]
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		protected KGBMOAGMOHJ BEIGCIPAIOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3B8")]
		[Cpp2IlInjected.Token(Token = "0x4000317")]
		protected int[] AELJEOHDCEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C0")]
		[Cpp2IlInjected.Token(Token = "0x4000318")]
		protected bool OBKGFKLJADO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C8")]
		[Cpp2IlInjected.Token(Token = "0x4000319")]
		protected int[] OFPBHPGNMFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D0")]
		[Cpp2IlInjected.Token(Token = "0x400031A")]
		protected bool JLHHCJKAHJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D8")]
		[Cpp2IlInjected.Token(Token = "0x400031B")]
		protected LDNADNDABII MAFCMMOJFON;

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public string FBMBLNLDPND
		{
			[Cpp2IlInjected.Token(Token = "0x60001F8")]
			[Cpp2IlInjected.Address(RVA = "0x8C7980", Offset = "0x8C6D80", VA = "0x1808C7980")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001F9")]
			[Cpp2IlInjected.Address(RVA = "0x8C7990", Offset = "0x8C6D90", VA = "0x1808C7990")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public bool CHDENMOBENM
		{
			[Cpp2IlInjected.Token(Token = "0x60001FB")]
			[Cpp2IlInjected.Address(RVA = "0x942EF0", Offset = "0x9422F0", VA = "0x180942EF0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001FC")]
			[Cpp2IlInjected.Address(RVA = "0x942390", Offset = "0x941790", VA = "0x180942390")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public virtual bool JKBLOJGFDNE
		{
			[Cpp2IlInjected.Token(Token = "0x60001FD")]
			[Cpp2IlInjected.Address(RVA = "0x90FCA0", Offset = "0x90F0A0", VA = "0x18090FCA0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public bool KBINEAAIENG
		{
			[Cpp2IlInjected.Token(Token = "0x60001FE")]
			[Cpp2IlInjected.Address(RVA = "0x6E7A660", Offset = "0x6E79A60", VA = "0x186E7A660")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public virtual bool HFJOBGCGBGD
		{
			[Cpp2IlInjected.Token(Token = "0x60001FF")]
			[Cpp2IlInjected.Address(RVA = "0x90FCA0", Offset = "0x90F0A0", VA = "0x18090FCA0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public virtual bool NAFFHHJGAEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000200")]
			[Cpp2IlInjected.Address(RVA = "0x8E1B40", Offset = "0x8E0F40", VA = "0x1808E1B40", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public virtual bool PFHPGGDLIOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000201")]
			[Cpp2IlInjected.Address(RVA = "0x90FCA0", Offset = "0x90F0A0", VA = "0x18090FCA0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public BIPIJKDNBKE LAKGDODDMDL
		{
			[Cpp2IlInjected.Token(Token = "0x6000203")]
			[Cpp2IlInjected.Address(RVA = "0x9EBB00", Offset = "0x9EAF00", VA = "0x1809EBB00")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000204")]
			[Cpp2IlInjected.Address(RVA = "0x6E7AC40", Offset = "0x6E7A040", VA = "0x186E7AC40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public IGIKALHDICH KKGGLHKOHII
		{
			[Cpp2IlInjected.Token(Token = "0x6000205")]
			[Cpp2IlInjected.Address(RVA = "0x9EBB10", Offset = "0x9EAF10", VA = "0x1809EBB10")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000206")]
			[Cpp2IlInjected.Address(RVA = "0x6E7AF90", Offset = "0x6E7A390", VA = "0x186E7AF90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public IGIKALHDICH NNNCHJPKGIO
		{
			[Cpp2IlInjected.Token(Token = "0x6000207")]
			[Cpp2IlInjected.Address(RVA = "0x9EBB20", Offset = "0x9EAF20", VA = "0x1809EBB20")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000208")]
			[Cpp2IlInjected.Address(RVA = "0x6E7B240", Offset = "0x6E7A640", VA = "0x186E7B240")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		protected Material JEPOLIEDKHD
		{
			[Cpp2IlInjected.Token(Token = "0x6000209")]
			[Cpp2IlInjected.Address(RVA = "0x6E73570", Offset = "0x6E72970", VA = "0x186E73570")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		protected Material ELNJJAPINEF
		{
			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0x6E70A50", Offset = "0x6E6FE50", VA = "0x186E70A50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public bool DKACPMDNKCB
		{
			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0x19C3D60", Offset = "0x19C3160", VA = "0x1819C3D60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public PlayerFacialAnimatorBase IBAJONHGOCK
		{
			[Cpp2IlInjected.Token(Token = "0x600020F")]
			[Cpp2IlInjected.Address(RVA = "0x9EBCC0", Offset = "0x9EB0C0", VA = "0x1809EBCC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public NAKHFBENBFF[] PGIIMNCOJAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(RVA = "0x6E7A230", Offset = "0x6E79630", VA = "0x186E7A230")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public NAKHFBENBFF COOLKFLCDAF
		{
			[Cpp2IlInjected.Token(Token = "0x6000211")]
			[Cpp2IlInjected.Address(RVA = "0x6E7A860", Offset = "0x6E79C60", VA = "0x186E7A860")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public NAKHFBENBFF BIBNHDGLAPG
		{
			[Cpp2IlInjected.Token(Token = "0x6000212")]
			[Cpp2IlInjected.Address(RVA = "0x6E7A890", Offset = "0x6E79C90", VA = "0x186E7A890")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public Mesh OMLHJGPANLP
		{
			[Cpp2IlInjected.Token(Token = "0x6000213")]
			[Cpp2IlInjected.Address(RVA = "0x9EBA80", Offset = "0x9EAE80", VA = "0x1809EBA80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		protected MOBCEOHADLA BOJFFJEIFNO
		{
			[Cpp2IlInjected.Token(Token = "0x6000214")]
			[Cpp2IlInjected.Address(RVA = "0x6E74AD0", Offset = "0x6E73ED0", VA = "0x186E74AD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		protected JNDAODDCIHF JJNPBGJEGDH
		{
			[Cpp2IlInjected.Token(Token = "0x6000215")]
			[Cpp2IlInjected.Address(RVA = "0x9EBAC0", Offset = "0x9EAEC0", VA = "0x1809EBAC0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000216")]
			[Cpp2IlInjected.Address(RVA = "0x6E747A0", Offset = "0x6E73BA0", VA = "0x186E747A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		protected bool BLOFPAADMOE
		{
			[Cpp2IlInjected.Token(Token = "0x6000217")]
			[Cpp2IlInjected.Address(RVA = "0x8E1B40", Offset = "0x8E0F40", VA = "0x1808E1B40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public bool MFOOBIPKNAP
		{
			[Cpp2IlInjected.Token(Token = "0x6000218")]
			[Cpp2IlInjected.Address(RVA = "0x6E7A850", Offset = "0x6E79C50", VA = "0x186E7A850")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public int IFLEIGIAMCM
		{
			[Cpp2IlInjected.Token(Token = "0x6000219")]
			[Cpp2IlInjected.Address(RVA = "0x1BCBC10", Offset = "0x1BCB010", VA = "0x181BCBC10")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600021A")]
			[Cpp2IlInjected.Address(RVA = "0x6E7B1A0", Offset = "0x6E7A5A0", VA = "0x186E7B1A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		protected virtual bool HFPFOMIELDI
		{
			[Cpp2IlInjected.Token(Token = "0x600021B")]
			[Cpp2IlInjected.Address(RVA = "0x90FCA0", Offset = "0x90F0A0", VA = "0x18090FCA0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		protected virtual int[] OBJJHKEDAPE
		{
			[Cpp2IlInjected.Token(Token = "0x600021C")]
			[Cpp2IlInjected.Address(RVA = "0x6E71670", Offset = "0x6E70A70", VA = "0x186E71670", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		protected bool IAHJKCONDMI
		{
			[Cpp2IlInjected.Token(Token = "0x600021E")]
			[Cpp2IlInjected.Address(RVA = "0x6E758D0", Offset = "0x6E74CD0", VA = "0x186E758D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		protected static bool MFLFAEOICNL
		{
			[Cpp2IlInjected.Token(Token = "0x600021F")]
			[Cpp2IlInjected.Address(RVA = "0x90FCA0", Offset = "0x90F0A0", VA = "0x18090FCA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public bool KNABOAHMBHO
		{
			[Cpp2IlInjected.Token(Token = "0x6000220")]
			[Cpp2IlInjected.Address(RVA = "0x26B5270", Offset = "0x26B4670", VA = "0x1826B5270")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000221")]
			[Cpp2IlInjected.Address(RVA = "0x6E7B450", Offset = "0x6E7A850", VA = "0x186E7B450")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public IEnumerable<SkinnedMeshRenderer> JNEGJMMHKEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000222")]
			[Cpp2IlInjected.Address(RVA = "0x6E7A110", Offset = "0x6E79510", VA = "0x186E7A110")]
			[IteratorStateMachine(typeof(FGDGAAPLIGF))]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public bool MAIEPNIBMOG
		{
			[Cpp2IlInjected.Token(Token = "0x6000223")]
			[Cpp2IlInjected.Address(RVA = "0x6E7A840", Offset = "0x6E79C40", VA = "0x186E7A840")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000224")]
			[Cpp2IlInjected.Address(RVA = "0x6E74EB0", Offset = "0x6E742B0", VA = "0x186E74EB0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public EOPKGKNJKFM EHLHHMKPKAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0x6E7A190", Offset = "0x6E79590", VA = "0x186E7A190")]
			get
			{
				return default(EOPKGKNJKFM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public static bool LFGPAIIPNKP
		{
			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0x6E7A5D0", Offset = "0x6E799D0", VA = "0x186E7A5D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		protected static GLHJGEGNDCM OAIGMCJLMEJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000244")]
			[Cpp2IlInjected.Address(RVA = "0x6E75FA0", Offset = "0x6E753A0", VA = "0x186E75FA0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000245")]
			[Cpp2IlInjected.Address(RVA = "0x6E72160", Offset = "0x6E71560", VA = "0x186E72160")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		protected Color FADPAKFLEOG
		{
			[Cpp2IlInjected.Token(Token = "0x600025D")]
			[Cpp2IlInjected.Address(RVA = "0x6E6E2D0", Offset = "0x6E6D6D0", VA = "0x186E6E2D0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		protected Color LHPDMLELBJE
		{
			[Cpp2IlInjected.Token(Token = "0x600025E")]
			[Cpp2IlInjected.Address(RVA = "0x6E71610", Offset = "0x6E70A10", VA = "0x186E71610")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		protected Texture2D OGLEDNGHOGC
		{
			[Cpp2IlInjected.Token(Token = "0x600025F")]
			[Cpp2IlInjected.Address(RVA = "0x6E6DEA0", Offset = "0x6E6D2A0", VA = "0x186E6DEA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		protected Color PGODDBGJAKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000265")]
			[Cpp2IlInjected.Address(RVA = "0x6E73300", Offset = "0x6E72700", VA = "0x186E73300")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		protected Color FKPHGGJBPMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000266")]
			[Cpp2IlInjected.Address(RVA = "0x6E72320", Offset = "0x6E71720", VA = "0x186E72320")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public AMLFLFEOPIJ LAPHNDKIHAC
		{
			[Cpp2IlInjected.Token(Token = "0x6000267")]
			[Cpp2IlInjected.Address(RVA = "0x6E7A1F0", Offset = "0x6E795F0", VA = "0x186E7A1F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		protected Texture2D EJBDDFEFLMC
		{
			[Cpp2IlInjected.Token(Token = "0x6000268")]
			[Cpp2IlInjected.Address(RVA = "0x6E706F0", Offset = "0x6E6FAF0", VA = "0x186E706F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public float GDDBMEHMNJB
		{
			[Cpp2IlInjected.Token(Token = "0x600026F")]
			[Cpp2IlInjected.Address(RVA = "0x6E7A210", Offset = "0x6E79610", VA = "0x186E7A210")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public float LOEBDJDNPGJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000270")]
			[Cpp2IlInjected.Address(RVA = "0x6E7A640", Offset = "0x6E79A40", VA = "0x186E7A640")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public bool EALFDIOFHPK
		{
			[Cpp2IlInjected.Token(Token = "0x600029D")]
			[Cpp2IlInjected.Address(RVA = "0xEDDAF0", Offset = "0xEDCEF0", VA = "0x180EDDAF0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600029E")]
			[Cpp2IlInjected.Address(RVA = "0x6E7AA20", Offset = "0x6E79E20", VA = "0x186E7AA20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action FCEAHFLLIGN
		{
			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0x6E79FB0", Offset = "0x6E793B0", VA = "0x186E79FB0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001F7")]
			[Cpp2IlInjected.Address(RVA = "0x6E7A8C0", Offset = "0x6E79CC0", VA = "0x186E7A8C0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<HEIHCLNBOCO, LICKDOCMADF> PFIJPGKJHOC
		{
			[Cpp2IlInjected.Token(Token = "0x6000238")]
			[Cpp2IlInjected.Address(RVA = "0x6E7A050", Offset = "0x6E79450", VA = "0x186E7A050")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0x6E7A960", Offset = "0x6E79D60", VA = "0x186E7A960")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x6E77080", Offset = "0x6E76480", VA = "0x186E77080")]
		public bool SetDeformation(bool LAPAKCLPKFA, bool OOGBJCNDKJB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x6E72E90", Offset = "0x6E72290", VA = "0x186E72E90")]
		protected static Material HBHHIHKMIOJ(Dictionary<BNDEMEMEPME, Material> EKNCNMFMFAH, Material ACMOCJHPAPG, ENEGMIMINPJ COILFOKBAOH, CCEHNAIIODM MMNLEBJJFJM, HAPHCDJNHOG JBCPDKGINNI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x6E73D10", Offset = "0x6E73110", VA = "0x186E73D10")]
		protected void JPPHBMIFBFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x6E73350", Offset = "0x6E72750", VA = "0x186E73350")]
		protected bool IHLDCFFPIPD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x6E74EC0", Offset = "0x6E742C0", VA = "0x186E74EC0")]
		protected void NMOCPPCDAIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x6E723C0", Offset = "0x6E717C0", VA = "0x186E723C0", Slot = "10")]
		protected virtual void FNBAJANAOMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x6E74840", Offset = "0x6E73C40", VA = "0x186E74840")]
		public int MeshesAtLODCount(int CFJAJKLFHPK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x6E73920", Offset = "0x6E72D20", VA = "0x186E73920")]
		protected static void JIGNDIPBIPN(Dictionary<NCBGGKADNMM, List<BNDEMEMEPME>> EMGPAFNJJMN, PJLCAFJDINA GCFLODGDDHG, Material ACMOCJHPAPG, ENEGMIMINPJ PBKGBNNFEAK, CCEHNAIIODM NMDHFEECAKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x6E6EBE0", Offset = "0x6E6DFE0", VA = "0x186E6EBE0")]
		protected void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x6E74AF0", Offset = "0x6E73EF0", VA = "0x186E74AF0")]
		protected void NDOJFKDKDIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x6E759F0", Offset = "0x6E74DF0", VA = "0x186E759F0")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80", Slot = "11")]
		protected virtual void BPBIHKMJJFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x6E6DF90", Offset = "0x6E6D390", VA = "0x186E6DF90")]
		protected static void ABHHKAPFDFF(List<Material> ADHOGIPNGMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x6E71700", Offset = "0x6E70B00", VA = "0x186E71700")]
		protected static void DFNLMEICEBF(Dictionary<BNDEMEMEPME, Material> EKNCNMFMFAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x6E72000", Offset = "0x6E71400", VA = "0x186E72000")]
		protected static void FENAGAOMFDC(Dictionary<Renderer, KMAKPFEJINM> EMLDELHEHLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x6E74680", Offset = "0x6E73A80", VA = "0x186E74680")]
		protected void LPNJDONJCMG(SkinnedMeshRenderer[] KJDELDJCJHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x6E6FE90", Offset = "0x6E6F290", VA = "0x186E6FE90")]
		protected void BDPBJJPKHND(SkinnedMeshRenderer BMCELCCICHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x6E6FF30", Offset = "0x6E6F330", VA = "0x186E6FF30")]
		protected void BDPBJJPKHND(MeshRenderer PBLNNEJCONP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x6E74900", Offset = "0x6E73D00", VA = "0x186E74900")]
		protected void NAINDFIJHDD(List<KMJKLFGFJJB> DNCNKHCKPCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x6E724C0", Offset = "0x6E718C0", VA = "0x186E724C0")]
		protected void GCHBMOGCDBO(Dictionary<string, PLBFKJMGACI<Texture2D>> EMGPAFNJJMN, bool AGCLKFFFHPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x6E72370", Offset = "0x6E71770", VA = "0x186E72370")]
		protected void FLOFAIDLEJO(Dictionary<NCBGGKADNMM, List<BNDEMEMEPME>> EMGPAFNJJMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x6E72D90", Offset = "0x6E72190", VA = "0x186E72D90")]
		public float GetHandOpenClosedAxis(HEIHCLNBOCO LBHEFJKPGBJ)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x6E77910", Offset = "0x6E76D10", VA = "0x186E77910")]
		public void SetHandOpenClosedAxis(HEIHCLNBOCO LBHEFJKPGBJ, float CLOMLOJCKNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x6E72DD0", Offset = "0x6E721D0", VA = "0x186E72DD0")]
		public LICKDOCMADF GetHandVisualState(HEIHCLNBOCO LBHEFJKPGBJ)
		{
			return default(LICKDOCMADF);
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x6E6E320", Offset = "0x6E6D720", VA = "0x186E6E320")]
		public bool AddHandVisualStateToken(HEIHCLNBOCO LBHEFJKPGBJ, LICKDOCMADF PJFJPICLFGL, object CMNJCPJBHGE, NAKHFBENBFF.MDJFLELDIPM HPFPPNDKBPG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x6E78FF0", Offset = "0x6E783F0", VA = "0x186E78FF0")]
		public void SetWatchHand(HEIHCLNBOCO LBHEFJKPGBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x6E790B0", Offset = "0x6E784B0", VA = "0x186E790B0")]
		public void SetWatchHands(bool FEMHHELOFCD, bool OMOOHAHNCGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x6E76740", Offset = "0x6E75B40", VA = "0x186E76740")]
		public bool RemoveHandVisualStateToken(HEIHCLNBOCO LBHEFJKPGBJ, object CMNJCPJBHGE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x6E72E50", Offset = "0x6E72250", VA = "0x186E72E50")]
		public bool GetThumbsUpActive(HEIHCLNBOCO LBHEFJKPGBJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x6E78AB0", Offset = "0x6E77EB0", VA = "0x186E78AB0")]
		public void SetThumbsUpActive(HEIHCLNBOCO LBHEFJKPGBJ, bool FJJKIMHMFOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x6E72E10", Offset = "0x6E72210", VA = "0x186E72E10")]
		public bool GetHandshakeActive(HEIHCLNBOCO LBHEFJKPGBJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x6E77960", Offset = "0x6E76D60", VA = "0x186E77960")]
		public void SetHandshakeActive(HEIHCLNBOCO LBHEFJKPGBJ, bool PFDLHODKGHJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x6E72420", Offset = "0x6E71820", VA = "0x186E72420")]
		public void ForceUpdateHandsVisualState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x6E71530", Offset = "0x6E70930", VA = "0x186E71530")]
		public static void ClearQueuedBuilds()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x6E70000", Offset = "0x6E6F400", VA = "0x186E70000")]
		protected static void BFNMPDCHIMB(PlayerAvatarDisplayBase LHJAOGPELMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x6E76480", Offset = "0x6E75880", VA = "0x186E76480")]
		public void Rebuild()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x6E74320", Offset = "0x6E73720", VA = "0x186E74320")]
		protected void LGJOAGNDBND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x6E74200", Offset = "0x6E73600", VA = "0x186E74200", Slot = "12")]
		protected virtual CLHPIMOBJFN LGJOAGNDBND(IList<NCBGGKADNMM> BJECJPBJBPG, AvatarItemBodyType ILCEKBEDHPL, bool JFPIADMBAJL, int[] KMDMDJCKFAK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x6E75FF0", Offset = "0x6E753F0", VA = "0x186E75FF0")]
		protected static CLHPIMOBJFN PMDMDPEKGBK(BPJAODFLPAN FBMPNCIPPMD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x6E70EA0", Offset = "0x6E702A0", VA = "0x186E70EA0")]
		[IteratorStateMachine(typeof(MFFDBLLIIAP))]
		protected static IEnumerator<ONHNFKGBFKG> CODNELJPHIF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x6E707F0", Offset = "0x6E6FBF0", VA = "0x186E707F0")]
		protected static BPJAODFLPAN CBFIMJNABBK(List<BPJAODFLPAN> JNLPMGLIDGE)
		{
			return default(BPJAODFLPAN);
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x6E77180", Offset = "0x6E76580", VA = "0x186E77180")]
		[AsyncStateMachine(typeof(HFMOCHBJKLJ))]
		public Task SetFaceCustomizationSettings(KKGOEONLCJM MHDNNLLPNCF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x6E737B0", Offset = "0x6E72BB0", VA = "0x186E737B0")]
		public void InitializeFaceFeatures(AvatarConfiguration ABDJNFJEKPB, EOPKGKNJKFM AAIBGMJAOGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x6E78810", Offset = "0x6E77C10", VA = "0x186E78810")]
		public void SetTeamColors(Color? JKGCKCPHJHL, bool KFIDFKHDGKH, Color FLHHIJLHGKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0xE482D0", Offset = "0xE476D0", VA = "0x180E482D0")]
		private static void FELOEANIDEA(Material BEDNCOELNMN, Color HCPAOILCJCB, params int[] BHDJFEMENCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0xE48370", Offset = "0xE47770", VA = "0x180E48370")]
		private static void GGLCAMNENKG(Material BEDNCOELNMN, Texture HCPAOILCJCB, params int[] BHDJFEMENCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x6E70170", Offset = "0x6E6F570", VA = "0x186E70170")]
		protected void BJNOCJAEDOK(Material HOJIELBCNNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x6E73E30", Offset = "0x6E73230", VA = "0x186E73E30")]
		protected void KDGOOHALJBD(Material HOJIELBCNNA, Color HOHJPBPCNAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x6E71B30", Offset = "0x6E70F30", VA = "0x186E71B30")]
		protected void DNIOFOOPNHJ(Material HOJIELBCNNA, Color HOHJPBPCNAE, Color ICKNPCPMCJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x6E70B40", Offset = "0x6E6FF40", VA = "0x186E70B40")]
		protected void CGCDBPFOJOF(Material HOJIELBCNNA, Texture2D EPCABFKFFHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x6E75700", Offset = "0x6E74B00", VA = "0x186E75700")]
		protected void OFBMICJNKKG(Material HOJIELBCNNA, Texture DKDCLABLEKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x6E75240", Offset = "0x6E74640", VA = "0x186E75240")]
		protected void ODNNKCMPEHB(Action<KMAKPFEJINM> ILGCNMBIIEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x6E74F50", Offset = "0x6E74350", VA = "0x186E74F50")]
		protected void OBOGFNIOJGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x6E6ECF0", Offset = "0x6E6E0F0", VA = "0x186E6ECF0")]
		protected void BANPMJMHIGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x6E753A0", Offset = "0x6E747A0", VA = "0x186E753A0")]
		protected void OEMDMJCGDME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x6E6E670", Offset = "0x6E6DA70", VA = "0x186E6E670")]
		public void ApplyUgcItemOverrides()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x6E76B00", Offset = "0x6E75F00", VA = "0x186E76B00")]
		public void SetBeardPrimaryColor([Optional] Color? DEOFOLHLCCK, bool IGHMCMOHLID = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x6E76D20", Offset = "0x6E76120", VA = "0x186E76D20")]
		public void SetBeardSecondaryColor([Optional] Color? DEOFOLHLCCK, bool IGHMCMOHLID = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x6E769C0", Offset = "0x6E75DC0", VA = "0x186E769C0")]
		public void SetBeardPattern([Optional] AvatarHairPattern DBDLADHEGOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x6E74090", Offset = "0x6E73490", VA = "0x186E74090")]
		private void LALEDCFNIDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x6E75190", Offset = "0x6E74590", VA = "0x186E75190")]
		private bool ODLJJGDCHOO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x6E774F0", Offset = "0x6E768F0", VA = "0x186E774F0")]
		public void SetHairPrimaryColor([Optional] Color? BHPDEAIHGMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x6E77700", Offset = "0x6E76B00", VA = "0x186E77700")]
		public void SetHairSecondaryColor([Optional] Color? BHPDEAIHGMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x6E773C0", Offset = "0x6E767C0", VA = "0x186E773C0")]
		public void SetHairPattern([Optional] AvatarHairPattern DBDLADHEGOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x6E765E0", Offset = "0x6E759E0", VA = "0x186E765E0")]
		public void RefreshHair()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x6E75810", Offset = "0x6E74C10", VA = "0x186E75810")]
		private bool OFOAOKKLIGL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x6E78650", Offset = "0x6E77A50", VA = "0x186E78650")]
		public void SetSkinColor(Color CHJKFNKNDDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x6E78B00", Offset = "0x6E77F00", VA = "0x186E78B00")]
		public void SetUgcItemVisualOverrides(NCBGGKADNMM ADCDKBJDONE, EOPKGKNJKFM AAIBGMJAOGB, Texture KFJNPDDEHNP, Color IKNGLNPJOEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x6E715C0", Offset = "0x6E709C0", VA = "0x186E715C0")]
		public void ClearUgcItemVisualOverrides()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x6E77280", Offset = "0x6E76680", VA = "0x186E77280")]
		public bool SetFaceShape(AvatarFaceShape GGNFBJIMGIB, bool HFMGCPKDCHN = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x6E76F40", Offset = "0x6E76340", VA = "0x186E76F40")]
		public bool SetBodyShape(AvatarBodyShape BBCFFNPPDGB, bool HFMGCPKDCHN = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x6E79210", Offset = "0x6E78610", VA = "0x186E79210")]
		public bool UpdateFaceAndBodyShapes()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x6E785A0", Offset = "0x6E779A0", VA = "0x186E785A0")]
		public bool SetHideEars(bool HCLFEOLPJOG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x6E78590", Offset = "0x6E77990", VA = "0x186E78590")]
		public bool SetHelmetHair(JGADMJKLMAM FJHGOKNOFOJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x6E78000", Offset = "0x6E77400", VA = "0x186E78000")]
		public void SetHatAnchorParameters(NBNLNGHNGFL ECFDCCGNALB, bool NPHNNLJJMCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x6E79180", Offset = "0x6E78580", VA = "0x186E79180")]
		public void SetupDisplayLODs(KGBMOAGMOHJ GNEGMJCKKKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x6E71E50", Offset = "0x6E71250", VA = "0x186E71E50")]
		protected int[] ENLOKBBKGMN(KGBMOAGMOHJ GNEGMJCKKKM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x6E785C0", Offset = "0x6E779C0", VA = "0x186E785C0")]
		public void SetOutfitSelections(IList<NCBGGKADNMM> BJECJPBJBPG, AvatarItemBodyType ILCEKBEDHPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x6E785F0", Offset = "0x6E779F0", VA = "0x186E785F0")]
		public void SetOutfitSelections(IList<NCBGGKADNMM> BJECJPBJBPG, AvatarItemBodyType ILCEKBEDHPL, bool JFPIADMBAJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x6E78620", Offset = "0x6E77A20", VA = "0x186E78620")]
		public CLHPIMOBJFN SetOutfitSelections(IList<NCBGGKADNMM> BJECJPBJBPG, AvatarItemBodyType ILCEKBEDHPL, KGBMOAGMOHJ GNEGMJCKKKM, bool JFPIADMBAJL, bool HFMGCPKDCHN = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x6E74370", Offset = "0x6E73770", VA = "0x186E74370")]
		private CLHPIMOBJFN LOLOCNJEAAK(IList<NCBGGKADNMM> BJECJPBJBPG, AvatarItemBodyType ILCEKBEDHPL, bool JFPIADMBAJL, KGBMOAGMOHJ GNEGMJCKKKM, bool HFMGCPKDCHN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x6E71D50", Offset = "0x6E71150", VA = "0x186E71D50")]
		protected int[] ENBGMJCFMBK(KGBMOAGMOHJ GNEGMJCKKKM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x8C6D90", Offset = "0x8C6190", VA = "0x1808C6D90", Slot = "13")]
		protected virtual JNDAODDCIHF EHMNCAEOPGL(AvatarItemBodyType APNBNFCFAMM, Dictionary<string, FMNHOILILHF> AHHJLHBLEFJ, Dictionary<string, PLBFKJMGACI<Texture2D>> CPBHKPGMAHE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x6E704D0", Offset = "0x6E6F8D0", VA = "0x186E704D0", Slot = "14")]
		protected virtual CLHPIMOBJFN BLPGADJEMNO(IList<NCBGGKADNMM> BJECJPBJBPG, AvatarItemBodyType ILCEKBEDHPL, bool JFPIADMBAJL, int[] AFKFLDLEHCG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x6E726D0", Offset = "0x6E71AD0", VA = "0x186E726D0", Slot = "15")]
		protected virtual FMNHOILILHF GGHDGMNMABI(AMLFLFEOPIJ NKJAMFONIBA, AvatarItemBodyType APNBNFCFAMM, HAPHCDJNHOG JBCPDKGINNI, FMNHOILILHF DEDLPHCMAAA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x8C6D90", Offset = "0x8C6190", VA = "0x1808C6D90", Slot = "16")]
		protected virtual FMNHOILILHF HIGFJGDOGAE(AvatarItemBodyType APNBNFCFAMM, HAPHCDJNHOG JBCPDKGINNI, GIKHNEIMEFL OGOGOLFFADO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x6E73010", Offset = "0x6E72410", VA = "0x186E73010")]
		protected void HHPMCMNKKFF(GFPNMGNNANK IBLMFDBNDHI, IBBAPAKLKFF.JPAHGGFNNNL GLNNKNKGFOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x6E74E30", Offset = "0x6E74230", VA = "0x186E74E30")]
		protected void NEPFMAACINF(GFPNMGNNANK IBLMFDBNDHI, IBBAPAKLKFF.JPAHGGFNNNL GLNNKNKGFOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0xA49C90", Offset = "0xA49090", VA = "0x180A49C90", Slot = "17")]
		protected virtual GFPNMGNNANK BCHAFPEDIPL(GFPNMGNNANK IBLMFDBNDHI, HelmetHairStyle HFIPIHJPMND, bool JLEGKGDPIPD, AvatarItemBodyType ILCEKBEDHPL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x6E6EEB0", Offset = "0x6E6E2B0", VA = "0x186E6EEB0")]
		protected GFPNMGNNANK BBBOIEHMCGJ(IList<NCBGGKADNMM> BJECJPBJBPG, AvatarItemBodyType BEHBGFEELPF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x6E71410", Offset = "0x6E70810", VA = "0x186E71410")]
		public void CleanupDisplayResources()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x6E73FE0", Offset = "0x6E733E0", VA = "0x186E73FE0")]
		protected void KNIBHLENGEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x6E75C30", Offset = "0x6E75030", VA = "0x186E75C30")]
		protected void PEHEELDIPKF(Transform MOKLAOCNKIJ, IEnumerable<SkinnedMeshRenderer> PMMKPBHPFAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x6E72CC0", Offset = "0x6E720C0", VA = "0x186E72CC0")]
		protected IBBAPAKLKFF.JPAHGGFNNNL GODOJHGMHFD(IBBAPAKLKFF.JPAHGGFNNNL OHBHKPKMKCD, HAPHCDJNHOG LKBMPHHJDGE)
		{
			return default(IBBAPAKLKFF.JPAHGGFNNNL);
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x6E71660", Offset = "0x6E70A60", VA = "0x186E71660")]
		protected void DBKDICKDNGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0xDB90B0", Offset = "0xDB84B0", VA = "0x180DB90B0")]
		protected void BMBIKMCMDIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x6E73C00", Offset = "0x6E73000", VA = "0x186E73C00")]
		protected void JPEMKBEOHOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x6E71860", Offset = "0x6E70C60", VA = "0x186E71860")]
		[AsyncStateMachine(typeof(LIOOMEGKOKH))]
		protected Task DFNNCCBHKIH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x6E708B0", Offset = "0x6E6FCB0", VA = "0x186E708B0")]
		protected static ENEGMIMINPJ CFGPFEKJDFM(PJLCAFJDINA IOCFOFNHLGL, int ENJNOOMIJHL)
		{
			return default(ENEGMIMINPJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x6E70D50", Offset = "0x6E70150", VA = "0x186E70D50")]
		protected static CCEHNAIIODM CNJOPKJJIII(PJLCAFJDINA IOCFOFNHLGL, int ENJNOOMIJHL)
		{
			return default(CCEHNAIIODM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x6E73280", Offset = "0x6E72680", VA = "0x186E73280")]
		protected Transform HPAEBDPHJPN(HAPHCDJNHOG JBCPDKGINNI, OutfitType HKNHLPOKHIK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x6E71930", Offset = "0x6E70D30", VA = "0x186E71930")]
		protected void DGEHKEIAEEI(int PPFEFFLJILL, Material BEDNCOELNMN, PJLCAFJDINA IOCFOFNHLGL, [Out] Texture2D BJPKOBPINGN, [Out] Vector4 DENKLKFNJOH, [Out] Texture2D HDKNDCCOKJO, [Out] Texture2D DNFBLHPCHBG, [Out] Texture2D DBHFBOKFILI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x6E6E0D0", Offset = "0x6E6D4D0", VA = "0x186E6E0D0")]
		protected void ACLPFIOKFKP(int PPFEFFLJILL, Material BEDNCOELNMN, PJLCAFJDINA IOCFOFNHLGL, [Out] Color ECAGNHGBBCA, [Out] Color BFAPBFOOOGH, [Out] Color HOGNAKEHJDH, [Out] Color CFHJFJKNMAJ, [Out] Color ADEDFOABBKP, [Out] Color GFIDKOEHBFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x6E6E260", Offset = "0x6E6D660", VA = "0x186E6E260")]
		protected void AODLINPOHFO(Vector3 FGALHLKMLDD, Quaternion IKGAHCGJKHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x6E779B0", Offset = "0x6E76DB0", VA = "0x186E779B0")]
		public void SetHatAnchorParameters(NBNLNGHNGFL ECFDCCGNALB, AnchorParamsRestrictions AEOKEDJHBKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x6E70F30", Offset = "0x6E70330", VA = "0x186E70F30")]
		public static void CalculateHatAnchorParams(FitMeshHemisphere EOHGOCKFLCI, Transform OKOGDAEEKKH, NBNLNGHNGFL ECFDCCGNALB, AnchorParamsRestrictions HHDPCHGHNHL, [Out] Vector3 ENJPHPPLHAI, [Out] Quaternion HONHOJHJMHK, [Out] NBNLNGHNGFL MFDIBIHFOGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x6E76850", Offset = "0x6E75C50", VA = "0x186E76850")]
		public void ResetHatAnchor(Vector2 OLDFCKKIOKM, Vector3 HFHLJCPKBCG, Vector3 AHNDJINOPFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x9EB9B0", Offset = "0x9EADB0", VA = "0x1809EB9B0")]
		public IOCNHDDOGGE GetAnchorParamsRestrictions()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x6E6E4A0", Offset = "0x6E6D8A0", VA = "0x186E6E4A0")]
		public void ApplyBlocks()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x6E6E5E0", Offset = "0x6E6D9E0", VA = "0x186E6E5E0")]
		public void ApplyHairPattern()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x6E6E410", Offset = "0x6E6D810", VA = "0x186E6E410")]
		public void ApplyBeardPattern()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x6E791B0", Offset = "0x6E785B0", VA = "0x186E791B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x6E731C0", Offset = "0x6E725C0", VA = "0x186E731C0")]
		protected void HOLLBBAOILA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x6E78F70", Offset = "0x6E78370", VA = "0x186E78F70")]
		public void SetWaitForUgcTextureLoads(bool KCDKCAOPAED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x6E78E90", Offset = "0x6E78290", VA = "0x186E78E90")]
		public void SetUgcTextureParameters(LDNADNDABII OKAMEPDCJCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x6E799C0", Offset = "0x6E78DC0", VA = "0x186E799C0")]
		public PlayerAvatarDisplayBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x6E72640", Offset = "0x6E71A40", VA = "0x186E72640")]
		[CompilerGenerated]
		private void GFHBOPFGHLB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x6E70F00", Offset = "0x6E70300", VA = "0x186E70F00")]
		[CompilerGenerated]
		private void CPFKLNCMAHB(KMAKPFEJINM BKLGHHEEOKG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x6E72C30", Offset = "0x6E72030", VA = "0x186E72C30")]
		[CompilerGenerated]
		private void GKLMGFHNIAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x6E75950", Offset = "0x6E74D50", VA = "0x186E75950")]
		[CompilerGenerated]
		private void OOOICEOJPDH(KMAKPFEJINM BKLGHHEEOKG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x6E73890", Offset = "0x6E72C90", VA = "0x186E73890")]
		[CompilerGenerated]
		private void JIBOBNHAENL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x6E73090", Offset = "0x6E72490", VA = "0x186E73090")]
		[CompilerGenerated]
		private void HJLBKDMJIJN(KMAKPFEJINM BKLGHHEEOKG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x6E745F0", Offset = "0x6E739F0", VA = "0x186E745F0")]
		[CompilerGenerated]
		private void LPBKLBENPIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x6E75F50", Offset = "0x6E75350", VA = "0x186E75F50")]
		[CompilerGenerated]
		private void PFNIKCJADEN(KMAKPFEJINM BKLGHHEEOKG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x6E73130", Offset = "0x6E72530", VA = "0x186E73130")]
		[CompilerGenerated]
		private void HMBPOGMACBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x6E72470", Offset = "0x6E71870", VA = "0x186E72470")]
		[CompilerGenerated]
		private void GCBNLBJIMME(KMAKPFEJINM BKLGHHEEOKG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x6E73F50", Offset = "0x6E73350", VA = "0x186E73F50")]
		[CompilerGenerated]
		private void KEMPILMAMKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x6E72FF0", Offset = "0x6E723F0", VA = "0x186E72FF0")]
		[CompilerGenerated]
		private void HCNGIANJLFD(KMAKPFEJINM BKLGHHEEOKG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x6E703F0", Offset = "0x6E6F7F0", VA = "0x186E703F0")]
		[CompilerGenerated]
		internal static bool BLGHEFHPEHN(Transform CBLHAJOJFNN, IEnumerable<SkinnedMeshRenderer> MAFGMBPJPCO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x6E6E220", Offset = "0x6E6D620", VA = "0x186E6E220")]
		[CompilerGenerated]
		private void AGPCHHCMIFM(KMAKPFEJINM BKLGHHEEOKG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x6E732C0", Offset = "0x6E726C0", VA = "0x186E732C0")]
		[CompilerGenerated]
		private void ICGLLKPGMNK(KMAKPFEJINM BKLGHHEEOKG)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[ExecuteAlways]
	public class PlayerFacialAnimatorBase : MonoBehaviour, FAMNLLOHBEJ
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200006A")]
		[CompilerGenerated]
		private struct ILDOJLOADPM : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000433")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000434")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000435")]
			public KKGOEONLCJM avatarData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000436")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000437")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000360")]
			[Cpp2IlInjected.Address(RVA = "0x6E7D6B0", Offset = "0x6E7CAB0", VA = "0x186E7D6B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000361")]
			[Cpp2IlInjected.Address(RVA = "0x6E7D940", Offset = "0x6E7CD40", VA = "0x186E7D940", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200006B")]
		[CompilerGenerated]
		private struct DFDDKHMNEKD : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000438")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000439")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400043A")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400043B")]
			public int eyeSelection;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x400043C")]
			public int eyeBrowSelection;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400043D")]
			public int noseSelection;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x400043E")]
			public int mouthSelection;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400043F")]
			public EOPKGKNJKFM avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000440")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000362")]
			[Cpp2IlInjected.Address(RVA = "0x6E7C4D0", Offset = "0x6E7B8D0", VA = "0x186E7C4D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000363")]
			[Cpp2IlInjected.Address(RVA = "0x6E7C6A0", Offset = "0x6E7BAA0", VA = "0x186E7C6A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200006C")]
		[CompilerGenerated]
		private struct EOKIBPCBKNI : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000441")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000442")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000443")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000444")]
			public FaceFeatureType featureType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000445")]
			public int selectionIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000446")]
			public EOPKGKNJKFM avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000447")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000364")]
			[Cpp2IlInjected.Address(RVA = "0x6E7C7B0", Offset = "0x6E7BBB0", VA = "0x186E7C7B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000365")]
			[Cpp2IlInjected.Address(RVA = "0x6E7C950", Offset = "0x6E7BD50", VA = "0x186E7C950", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200006D")]
		[CompilerGenerated]
		private struct GJKMAJOFIPO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000448")]
			public KKGOEONLCJM avatarData;
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200006E")]
		[CompilerGenerated]
		private struct CAEDJOOBCKB : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000449")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400044A")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400044B")]
			public KKGOEONLCJM avatarData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400044C")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400044D")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000366")]
			[Cpp2IlInjected.Address(RVA = "0x6E7BD90", Offset = "0x6E7B190", VA = "0x186E7BD90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000367")]
			[Cpp2IlInjected.Address(RVA = "0x6E7C470", Offset = "0x6E7B870", VA = "0x186E7C470", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200006F")]
		[CompilerGenerated]
		private struct ODPEHDNKPFB : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400044E")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400044F")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000450")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000451")]
			public EOPKGKNJKFM avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000452")]
			private TaskAwaiter<FAIDKKHGCGD> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000368")]
			[Cpp2IlInjected.Address(RVA = "0x6E82830", Offset = "0x6E81C30", VA = "0x186E82830", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000369")]
			[Cpp2IlInjected.Address(RVA = "0x6E82C50", Offset = "0x6E82050", VA = "0x186E82C50", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000070")]
		[CompilerGenerated]
		private struct PKAPDJJFBLF : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000453")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000454")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000455")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000456")]
			public EOPKGKNJKFM avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000457")]
			private FaceStyleSet <styleSet>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000458")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600036A")]
			[Cpp2IlInjected.Address(RVA = "0x6E83780", Offset = "0x6E82B80", VA = "0x186E83780", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600036B")]
			[Cpp2IlInjected.Address(RVA = "0x6E83C60", Offset = "0x6E83060", VA = "0x186E83C60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40003C2")]
		protected const float HKOBFOMGGJG = 0.5f;

		[Cpp2IlInjected.Token(Token = "0x40003C3")]
		protected const int EPBPGKBAHOP = 5;

		[Cpp2IlInjected.Token(Token = "0x40003C4")]
		public static readonly int IdleID;

		[Cpp2IlInjected.Token(Token = "0x40003C5")]
		public static readonly int SmileID;

		[Cpp2IlInjected.Token(Token = "0x40003C6")]
		public static readonly int HugeSmileID;

		[Cpp2IlInjected.Token(Token = "0x40003C7")]
		public static readonly int ScoreID;

		[Cpp2IlInjected.Token(Token = "0x40003C8")]
		public static readonly int SadID;

		[Cpp2IlInjected.Token(Token = "0x40003C9")]
		public static readonly int DisgustID;

		[Cpp2IlInjected.Token(Token = "0x40003CA")]
		public static readonly int HitID;

		[Cpp2IlInjected.Token(Token = "0x40003CB")]
		public static readonly int ConcentrateID;

		[Cpp2IlInjected.Token(Token = "0x40003CC")]
		public static readonly int KissID;

		[Cpp2IlInjected.Token(Token = "0x40003CD")]
		public static readonly int TalkingID;

		[Cpp2IlInjected.Token(Token = "0x40003CE")]
		public static readonly int MuteID;

		[Cpp2IlInjected.Token(Token = "0x40003CF")]
		public static readonly int AFKID;

		[Cpp2IlInjected.Token(Token = "0x40003D0")]
		public static readonly int HappyID;

		[Cpp2IlInjected.Token(Token = "0x40003D1")]
		public static readonly int EmoteFlatID;

		[Cpp2IlInjected.Token(Token = "0x40003D2")]
		public static readonly int EmoteHappyID;

		[Cpp2IlInjected.Token(Token = "0x40003D3")]
		public static readonly int EmoteSadID;

		[Cpp2IlInjected.Token(Token = "0x40003D4")]
		public static readonly int EmoteLoveID;

		[Cpp2IlInjected.Token(Token = "0x40003D5")]
		public static readonly int EmoteAngryID;

		[Cpp2IlInjected.Token(Token = "0x40003D6")]
		public static readonly int EmoteLaughID;

		[Cpp2IlInjected.Token(Token = "0x40003D7")]
		public static readonly int EmoteTongueOutID;

		[Cpp2IlInjected.Token(Token = "0x40003D8")]
		public static readonly int EmoteGrimacingID;

		[Cpp2IlInjected.Token(Token = "0x40003D9")]
		public static readonly int EmoteWinkID;

		[Cpp2IlInjected.Token(Token = "0x40003DA")]
		public static readonly int EmoteShockedID;

		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		public static readonly int EmoteNauseatedID;

		[Cpp2IlInjected.Token(Token = "0x40003DC")]
		public static readonly int EmoteSmileSweatID;

		[Cpp2IlInjected.Token(Token = "0x40003DD")]
		public static readonly int EmoteSleepingID;

		[Cpp2IlInjected.Token(Token = "0x40003DE")]
		public static readonly int EmoteThinkingID;

		[Cpp2IlInjected.Token(Token = "0x40003DF")]
		public static readonly int EmoteSmirkID;

		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		public static readonly int EmoteSmileID;

		[Cpp2IlInjected.Token(Token = "0x40003E1")]
		protected static readonly Dictionary<PLNKHDFAHFD.GFOEIHGPCGD, int> GELKAPKOHNJ;

		[Cpp2IlInjected.Token(Token = "0x40003E2")]
		[CanBeNull]
		protected static IEnumerable<FaceFeatureType> AFGAFJFCNDJ;

		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		protected static readonly int KMEFIFHABKE;

		[Cpp2IlInjected.Token(Token = "0x40003E4")]
		protected static readonly int FIIEINGCDFB;

		[Cpp2IlInjected.Token(Token = "0x40003E5")]
		protected static readonly int MOJFICGODEC;

		[Cpp2IlInjected.Token(Token = "0x40003E6")]
		protected static readonly int CIBHMGOLKJM;

		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		protected static readonly int NBBKNDGAPLM;

		[Cpp2IlInjected.Token(Token = "0x40003E8")]
		protected static readonly int CEIJNICOJCL;

		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		protected static readonly int OFNMENGIFKN;

		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		protected static readonly int ELKDJBBBHLB;

		[Cpp2IlInjected.Token(Token = "0x40003EB")]
		protected static Vector2 FGDLIJJLDBL;

		[Cpp2IlInjected.Token(Token = "0x40003EC")]
		protected static Vector2 LNAPCAJBIJH;

		[Cpp2IlInjected.Token(Token = "0x40003ED")]
		protected static Vector2 OLILLDAILKK;

		[Cpp2IlInjected.Token(Token = "0x40003EE")]
		protected static Vector2 JPFPMEIEEKO;

		[Cpp2IlInjected.Token(Token = "0x40003EF")]
		protected static Vector2 GLPEHONALNP;

		[Cpp2IlInjected.Token(Token = "0x40003F0")]
		protected static Vector2 AMNHMPFCFPD;

		[Cpp2IlInjected.Token(Token = "0x40003F1")]
		protected static Vector2 AIAPDFPPOGD;

		[Cpp2IlInjected.Token(Token = "0x40003F2")]
		protected static Vector2 BCKLIDCGPHO;

		[Cpp2IlInjected.Token(Token = "0x40003F3")]
		protected static Vector2 MOMIGBLBMGB;

		[Cpp2IlInjected.Token(Token = "0x40003F4")]
		protected static Vector2 OOCMBJKLPDP;

		[Cpp2IlInjected.Token(Token = "0x40003F5")]
		protected static Vector2 BNJGHANHPFC;

		[Cpp2IlInjected.Token(Token = "0x40003F6")]
		protected static Vector2 BKBLJCJEHIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40003F7")]
		[KAIMDEABLJJ(PGGKFLBMAKK.Self, false, false, false)]
		[SerializeField]
		public Animator animator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40003F8")]
		[Header("Rendering")]
		[SerializeField]
		public FaceStyleSet faceStyleSet;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40003F9")]
		[SerializeField]
		protected Renderer faceRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40003FA")]
		[SerializeField]
		protected float jitterFPS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40003FB")]
		[Header("Emotes")]
		[SerializeField]
		public Renderer[] emoteEffectRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40003FC")]
		[SerializeField]
		[Header("Modern Avatar Facial Features")]
		[FormerlySerializedAs("fullBodyFaceStyleSet")]
		public FaceStyleSet modernBodyFaceStyleSet;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40003FD")]
		private EOPKGKNJKFM OPKLIJBKLMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40003FE")]
		private FaceStyleSet HDCCJLEDFLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40003FF")]
		[SerializeField]
		protected bool debugEyeJitterInEditor;

		[Cpp2IlInjected.Token(Token = "0x4000400")]
		protected const int HFKLGPCOJIN = -1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000401")]
		protected int JFCJDHCABOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000402")]
		protected int KLKNOFLKMLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000403")]
		protected int OKMNIPMOOLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000404")]
		protected int AJFLDBDDBLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000405")]
		protected Vector2 EOMHOINEJOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000406")]
		protected float ADOIMNCOEPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000407")]
		protected Vector2 MJHFIPOOHGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000408")]
		protected float GIDFACJJHBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000409")]
		protected Vector2 AAEMIEKOEPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x400040A")]
		protected float JJJAKDBAPOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400040B")]
		protected Vector2 CNNNCIFCODD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400040C")]
		protected float FAFCBOFHAHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400040D")]
		protected List<SelectableFaceOption> EFININAJJBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400040E")]
		protected List<SelectableFaceOption> JAPEOODKOBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400040F")]
		protected List<SelectableFaceOption> FGBAPFAEOKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000410")]
		protected List<SelectableFaceOption> PJEKLJFBDAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000411")]
		protected Coroutine FHJGEICMNPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000412")]
		protected int? MIHPFIPKEJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000413")]
		protected int KJKFPGMEHBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
		[Cpp2IlInjected.Token(Token = "0x4000414")]
		protected int KEIIFBDOCBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000415")]
		protected int HBJDDLPOPJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
		[Cpp2IlInjected.Token(Token = "0x4000416")]
		protected int LDOHGAHECGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000417")]
		protected int LAALAKAFEFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
		[Cpp2IlInjected.Token(Token = "0x4000418")]
		protected int OIDFKEKBHNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000419")]
		protected Sprite NDIGCMPNILM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400041A")]
		protected Sprite EIAKHBBPOAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400041B")]
		protected Sprite INEAIIGAPIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400041C")]
		protected Sprite GAJNLBBKFEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400041D")]
		protected bool FBFGIHNMDIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x400041F")]
		protected string HOLNEGMHGGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000420")]
		protected string GHHIKBKHHAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000421")]
		protected string GJMFPANOKKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000422")]
		protected string HNBDCGHAIBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000423")]
		[ReadOnlyField]
		public Sprite eyeSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000424")]
		[ReadOnlyField]
		public Sprite leftEyeOnlySprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x4000425")]
		[ReadOnlyField]
		public Sprite rightEyeOnlySprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4000426")]
		public Color leftEyeColorTint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4000427")]
		public Color leftEyeGleamColorTint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x4000428")]
		public Color rightEyeColorTint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x4000429")]
		public Color rightEyeGleamColorTint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x400042A")]
		[ReadOnlyField]
		public Sprite mouthSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x400042E")]
		protected AvatarConfiguration ABDJNFJEKPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x400042F")]
		protected FAIDKKHGCGD IAJPJCMAPKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x4000431")]
		protected MaterialPropertyBlock PDOIHPPFOOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x4000432")]
		protected Dictionary<string, int> BMBKNIOHKLJ;

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		public FaceStyleSet BAIKIDMEMJD
		{
			[Cpp2IlInjected.Token(Token = "0x600031C")]
			[Cpp2IlInjected.Address(RVA = "0x6E893D0", Offset = "0x6E887D0", VA = "0x186E893D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		public bool BBLEIKONDCC
		{
			[Cpp2IlInjected.Token(Token = "0x600031F")]
			[Cpp2IlInjected.Address(RVA = "0x104F5A0", Offset = "0x104E9A0", VA = "0x18104F5A0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000320")]
			[Cpp2IlInjected.Address(RVA = "0x104AD40", Offset = "0x104A140", VA = "0x18104AD40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		protected virtual bool NFIJECAJBHB
		{
			[Cpp2IlInjected.Token(Token = "0x6000321")]
			[Cpp2IlInjected.Address(RVA = "0x90FCA0", Offset = "0x90F0A0", VA = "0x18090FCA0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000092")]
		protected virtual bool PAKKEFGLCHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000322")]
			[Cpp2IlInjected.Address(RVA = "0x8E1B40", Offset = "0x8E0F40", VA = "0x1808E1B40", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000093")]
		protected int MJJOHDALAKA
		{
			[Cpp2IlInjected.Token(Token = "0x6000323")]
			[Cpp2IlInjected.Address(RVA = "0x6E86B50", Offset = "0x6E85F50", VA = "0x186E86B50")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000094")]
		public Renderer JBCMDDPNKBI
		{
			[Cpp2IlInjected.Token(Token = "0x6000324")]
			[Cpp2IlInjected.Address(RVA = "0x8C7960", Offset = "0x8C6D60", VA = "0x1808C7960")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000095")]
		public bool CEHKCKDMICG
		{
			[Cpp2IlInjected.Token(Token = "0x6000325")]
			[Cpp2IlInjected.Address(RVA = "0x104F710", Offset = "0x104EB10", VA = "0x18104F710")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000326")]
			[Cpp2IlInjected.Address(RVA = "0x104FA00", Offset = "0x104EE00", VA = "0x18104FA00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000096")]
		public Renderer[] BEFBBMJPBMJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000327")]
			[Cpp2IlInjected.Address(RVA = "0x8C7970", Offset = "0x8C6D70", VA = "0x1808C7970")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000097")]
		public bool OLLBJPAOGIA
		{
			[Cpp2IlInjected.Token(Token = "0x6000328")]
			[Cpp2IlInjected.Address(RVA = "0x6E89410", Offset = "0x6E88810", VA = "0x186E89410")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000329")]
			[Cpp2IlInjected.Address(RVA = "0x6E895D0", Offset = "0x6E889D0", VA = "0x186E895D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000098")]
		protected int IFADNOINLPP
		{
			[Cpp2IlInjected.Token(Token = "0x600032A")]
			[Cpp2IlInjected.Address(RVA = "0x6E86C80", Offset = "0x6E86080", VA = "0x186E86C80")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000099")]
		protected int LOGBCAGHLIH
		{
			[Cpp2IlInjected.Token(Token = "0x600032B")]
			[Cpp2IlInjected.Address(RVA = "0x6E86530", Offset = "0x6E85930", VA = "0x186E86530")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009A")]
		public float IMPOLAEPEEJ
		{
			[Cpp2IlInjected.Token(Token = "0x600032C")]
			[Cpp2IlInjected.Address(RVA = "0x6E893F0", Offset = "0x6E887F0", VA = "0x186E893F0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600032D")]
			[Cpp2IlInjected.Address(RVA = "0x6E895B0", Offset = "0x6E889B0", VA = "0x186E895B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009B")]
		public OOOHMBDIILN BPDFLHFCCBA
		{
			[Cpp2IlInjected.Token(Token = "0x600032E")]
			[Cpp2IlInjected.Address(RVA = "0x9EBCB0", Offset = "0x9EB0B0", VA = "0x1809EBCB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600032F")]
			[Cpp2IlInjected.Address(RVA = "0xF76970", Offset = "0xF75D70", VA = "0x180F76970")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009C")]
		public FAIDKKHGCGD DMHLCNOOBNI
		{
			[Cpp2IlInjected.Token(Token = "0x6000348")]
			[Cpp2IlInjected.Address(RVA = "0x9EBCF0", Offset = "0x9EB0F0", VA = "0x1809EBCF0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000349")]
			[Cpp2IlInjected.Address(RVA = "0x6E89530", Offset = "0x6E88930", VA = "0x186E89530")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		public NoseFaceOption NEPKAHCCDPE
		{
			[Cpp2IlInjected.Token(Token = "0x600034A")]
			[Cpp2IlInjected.Address(RVA = "0x9EBCE0", Offset = "0x9EB0E0", VA = "0x1809EBCE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600034B")]
			[Cpp2IlInjected.Address(RVA = "0xF76A10", Offset = "0xF75E10", VA = "0x180F76A10")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009E")]
		protected MaterialPropertyBlock NAEJPHLHDNB
		{
			[Cpp2IlInjected.Token(Token = "0x600034C")]
			[Cpp2IlInjected.Address(RVA = "0x6E84800", Offset = "0x6E83C00", VA = "0x186E84800")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action PACAHJEIHDB
		{
			[Cpp2IlInjected.Token(Token = "0x600031D")]
			[Cpp2IlInjected.Address(RVA = "0x6E89320", Offset = "0x6E88720", VA = "0x186E89320")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600031E")]
			[Cpp2IlInjected.Address(RVA = "0x6E89480", Offset = "0x6E88880", VA = "0x186E89480")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x6E86590", Offset = "0x6E85990", VA = "0x186E86590")]
		public void LocalPlayEmote(PLNKHDFAHFD.GFOEIHGPCGD NJMBEEDLFGJ, float OAJHKMHAKHJ = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x6E85B40", Offset = "0x6E84F40", VA = "0x186E85B40")]
		public bool IsEmotePlaying(PLNKHDFAHFD.GFOEIHGPCGD NJMBEEDLFGJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x6E874B0", Offset = "0x6E868B0", VA = "0x186E874B0")]
		public void SetIdleHappy(bool DIHJBCNJLLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x6E851B0", Offset = "0x6E845B0", VA = "0x186E851B0")]
		protected void GKAHDECELMN(bool ODPPNDHPMLM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x6E85440", Offset = "0x6E84840", VA = "0x186E85440")]
		protected void HOIMIPBGHOG(bool PNDLBOFILLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x6E868E0", Offset = "0x6E85CE0", VA = "0x186E868E0")]
		protected void OBAKIHICCFH(HAPHCDJNHOG JBCPDKGINNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x6E85D80", Offset = "0x6E85180", VA = "0x186E85D80")]
		protected void KOIEHKEFNAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x6E86CE0", Offset = "0x6E860E0", VA = "0x186E86CE0")]
		public void PlayExpression(int LJIIGBHMEFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x6E84660", Offset = "0x6E83A60", VA = "0x186E84660")]
		protected void BJAIBNDEKNA(bool NFALIGDCLIL, bool LNAADLIDCHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x6E85400", Offset = "0x6E84800", VA = "0x186E85400")]
		public List<SelectableFaceOption> GetAvailableFeatures(FaceFeatureType DDFKNGIOCCC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x6E85680", Offset = "0x6E84A80", VA = "0x186E85680")]
		public void InitializeFaceFeatureRanges(AvatarConfiguration ABDJNFJEKPB, EOPKGKNJKFM AAIBGMJAOGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x6E873C0", Offset = "0x6E867C0", VA = "0x186E873C0")]
		[AsyncStateMachine(typeof(ILDOJLOADPM))]
		public Task SetFaceSettings(KKGOEONLCJM MHDNNLLPNCF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x6E87290", Offset = "0x6E86690", VA = "0x186E87290")]
		[AsyncStateMachine(typeof(DFDDKHMNEKD))]
		public Task SetFaceSettings(int FDHLABPCKBK, int OPMMNBJECPN, int JOCLMKPCNHK, int FLDABKFIIMM, EOPKGKNJKFM AAIBGMJAOGB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x6E87530", Offset = "0x6E86930", VA = "0x186E87530")]
		[AsyncStateMachine(typeof(EOKIBPCBKNI))]
		public Task SetSelectedFaceFeatureAndBuildFaceStyle(FaceFeatureType DDFKNGIOCCC, int NGLPODDHKFP, EOPKGKNJKFM AAIBGMJAOGB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x6E84E70", Offset = "0x6E84270", VA = "0x186E84E70")]
		protected void DLKLPJGOHBK(FaceFeatureType DDFKNGIOCCC, DPJDJGPLJGE OGDMIANPJAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x6E85DF0", Offset = "0x6E851F0", VA = "0x186E85DF0")]
		protected void LCCAPMFBHMJ(FaceFeatureType DDFKNGIOCCC, int NGLPODDHKFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x6E85230", Offset = "0x6E84630", VA = "0x186E85230")]
		public static IEnumerable<FaceFeatureType> GetAllFaceFeatureTypes()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x6E84FE0", Offset = "0x6E843E0", VA = "0x186E84FE0")]
		[AsyncStateMachine(typeof(CAEDJOOBCKB))]
		protected Task EDFAHFBHBAJ(KKGOEONLCJM MHDNNLLPNCF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x6E84BF0", Offset = "0x6E83FF0", VA = "0x186E84BF0")]
		protected static void CPGAIGKHEHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x6E86680", Offset = "0x6E85A80", VA = "0x186E86680")]
		private void NPLNAACKFFK(bool BJDLNAHAMJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x6E84880", Offset = "0x6E83C80", VA = "0x186E84880")]
		protected void CJHGHCOILJH(FaceFeatureType DDFKNGIOCCC, Vector2 HOKKAJJAAEN, EOPKGKNJKFM AAIBGMJAOGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x6E86D00", Offset = "0x6E86100", VA = "0x186E86D00")]
		public void SetFaceFeatureNormalizedPositionOffset(FaceFeatureType DDFKNGIOCCC, Vector2 LOKPEKLHCJG, EOPKGKNJKFM AAIBGMJAOGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x6E869D0", Offset = "0x6E85DD0", VA = "0x186E869D0")]
		protected void PADDAJFKMJL(FaceFeatureType DDFKNGIOCCC, float CLHFJDEKJBA, EOPKGKNJKFM AAIBGMJAOGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x6E87070", Offset = "0x6E86470", VA = "0x186E87070")]
		public void SetFaceFeatureNormalizedScaleOffset(FaceFeatureType DDFKNGIOCCC, float HFEIGFHIPHG, EOPKGKNJKFM AAIBGMJAOGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x6E855A0", Offset = "0x6E849A0", VA = "0x186E855A0")]
		[AsyncStateMachine(typeof(ODPEHDNKPFB))]
		protected Task IGJPEGDJOEH(EOPKGKNJKFM AAIBGMJAOGB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x6E85930", Offset = "0x6E84D30", VA = "0x186E85930")]
		public void InitializeFaceFeatureStyleSet(EOPKGKNJKFM AAIBGMJAOGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x6E850D0", Offset = "0x6E844D0", VA = "0x186E850D0")]
		protected bool GGKCPBOINLP(string ODALBCJIIAM, [Out] int IIACLAMOIEE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x6E84520", Offset = "0x6E83920", VA = "0x186E84520")]
		protected void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0x10AB820", Offset = "0x10AAC20", VA = "0x1810AB820", Slot = "8")]
		protected virtual void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x6E86950", Offset = "0x6E85D50", VA = "0x186E86950")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x6E88510", Offset = "0x6E87910", VA = "0x186E88510")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x6E84710", Offset = "0x6E83B10", VA = "0x186E84710")]
		[AsyncStateMachine(typeof(PKAPDJJFBLF))]
		public Task BuildFaceStyleAsyncIfChanged(EOPKGKNJKFM AAIBGMJAOGB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x6E87E20", Offset = "0x6E87220", VA = "0x186E87E20")]
		public void UpdateFaceDisplays(bool BHOGDGADLAD = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x6E83CC0", Offset = "0x6E830C0", VA = "0x186E83CC0")]
		protected bool ABNMAOLMINJ(bool BHOGDGADLAD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x6E87B40", Offset = "0x6E86F40", VA = "0x186E87B40")]
		public void UpdateFaceDisplayFeatureTextures()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0x6E87640", Offset = "0x6E86A40", VA = "0x186E87640")]
		public void UpdateFaceDisplayFeaturePositions()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0x6E88050", Offset = "0x6E87450", VA = "0x186E88050")]
		public void UpdateFaceJitterMultiplier()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x6E88240", Offset = "0x6E87640", VA = "0x186E88240")]
		public bool UpdateLegacyFaceVectors()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0x6E84D80", Offset = "0x6E84180", VA = "0x186E84D80")]
		protected void DBHEIBLDIBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0x6E89120", Offset = "0x6E88520", VA = "0x186E89120")]
		public PlayerFacialAnimatorBase()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x8F2B70", Offset = "0x8F1F70", VA = "0x1808F2B70", Slot = "4")]
		private bool HKCAABAJPPK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x6E85C50", Offset = "0x6E85050", VA = "0x186E85C50")]
		[CompilerGenerated]
		internal static PLPKIICCMFB JGAFPEHGDAG(FaceFeatureType DDFKNGIOCCC, GJKMAJOFIPO P_1)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public struct LMECNGKDFGG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000459")]
	public string DKCJKHANLJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400045A")]
	public int ODDAFMAOMHH;
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[SelectionBase]
	[ExecuteInEditMode]
	public class PlayerModernBodyEditorAvatarValidator : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x400045B")]
		public const string IDLE_ANIM_NAME = "Idle";

		[Cpp2IlInjected.Token(Token = "0x400045C")]
		public const string A_POSE_ANIM_NAME = "A Pose";

		[Cpp2IlInjected.Token(Token = "0x400045D")]
		public const string ANIMATION_OVERRIDE_STATE_NAME = "Override";

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400045E")]
		public EOPKGKNJKFM avatarBodyType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000460")]
		public Color hairPrimaryColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000461")]
		public Color hairSecondaryColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000462")]
		public Color beardPrimaryColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000463")]
		public Color beardSecondaryColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000464")]
		public Color skinColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000465")]
		public int faceShapeIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000466")]
		public int bodyShapeIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000467")]
		public int hairPatternIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000468")]
		public int beardPatternIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000469")]
		public AvatarFaceShape[] faceShapes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400046A")]
		public AvatarBodyShape[] bodyShapes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400046B")]
		public AvatarHairPattern[] hairPatterns;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400046C")]
		public float _avatarScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x400046D")]
		public bool enablePosing;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400046E")]
		public int poseIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400046F")]
		public AnimationClip animationOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000470")]
		[Range(0f, 4f)]
		public float animationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x4000471")]
		public bool hideEars;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000472")]
		public JGADMJKLMAM useHelmetHair;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000473")]
		public NBNLNGHNGFL hatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000474")]
		public IOCNHDDOGGE HatAnchorRestrictions;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000475")]
		public bool UseHairFitMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD1")]
		[Cpp2IlInjected.Token(Token = "0x4000476")]
		public bool usesHatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000477")]
		public GameObject hatPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000478")]
		public GameObject hairPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000479")]
		public GameObject earPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400047A")]
		public GameObject eyePrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400047B")]
		public GameObject mouthPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400047C")]
		public GameObject neckPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400047D")]
		public GameObject shirtPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400047E")]
		public GameObject beltPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x400047F")]
		public GameObject shoulderPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000480")]
		public GameObject rightHandPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000481")]
		public GameObject leftHandPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000482")]
		public GameObject legsPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000483")]
		public GameObject feetPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000484")]
		public IBBAPAKLKFF.JPAHGGFNNNL baseSkinCullingMask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x4000485")]
		[SerializeField]
		[KAIMDEABLJJ(PGGKFLBMAKK.Self, false, false, false)]
		public PlayerAvatarDisplayBase _avatarDisplay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4000486")]
		private MEIFIDFNJPL OIPMEBHFECA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4000487")]
		[SerializeField]
		[KAIMDEABLJJ(PGGKFLBMAKK.Self, false, false, false)]
		public PlayerFacialAnimatorBase facialAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4000488")]
		public Animator animator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4000489")]
		public AnimationClip animationClipToOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x400048A")]
		private AnimatorOverrideController OGNJABKIBEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x400048B")]
		private List<KeyValuePair<AnimationClip, AnimationClip>> JCFDAIMHFGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x400048C")]
		public Transform headIKEffector;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x400048D")]
		public Transform leftHandIKEffector;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x400048E")]
		public Transform rightHandIKEffector;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x400048F")]
		[Range(0f, 2f)]
		public int lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19C")]
		[Cpp2IlInjected.Token(Token = "0x4000490")]
		public int rightHandGestureStateIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x4000491")]
		[Range(0f, 1f)]
		public float rightHandCurl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A4")]
		[Cpp2IlInjected.Token(Token = "0x4000492")]
		public int leftHandGestureStateIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x4000493")]
		[Range(0f, 1f)]
		public float leftHandCurl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1AC")]
		[Cpp2IlInjected.Token(Token = "0x4000494")]
		public int eyeBrowSelection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x4000495")]
		public int eyeSelection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B4")]
		[Cpp2IlInjected.Token(Token = "0x4000496")]
		public int noseSelection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x4000497")]
		public int mouthSelection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1BC")]
		[Cpp2IlInjected.Token(Token = "0x4000498")]
		public float eyeBrowPositionOffsetHorizontal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x4000499")]
		public float eyeBrowPositionOffsetVertical;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C4")]
		[Cpp2IlInjected.Token(Token = "0x400049A")]
		public float eyeBrowScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x400049B")]
		public float eyePositionOffsetHorizontal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1CC")]
		[Cpp2IlInjected.Token(Token = "0x400049C")]
		public float eyePositionOffsetVertical;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x400049D")]
		public float eyeScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D4")]
		[Cpp2IlInjected.Token(Token = "0x400049E")]
		public float nosePositionOffsetVertical;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x400049F")]
		public float noseScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1DC")]
		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		public float mouthPositionOffsetHorizontal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		public float mouthPositionOffsetVertical;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E4")]
		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		public float mouthScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		public float hatNormalizedPositionX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1EC")]
		[Cpp2IlInjected.Token(Token = "0x40004A4")]
		public float hatNormalizedPositionY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		public Vector3 hatHemispherePositionOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1FC")]
		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		public Vector3 hatHemisphereRotationOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		public int facialExpressionIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20C")]
		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		[Range(0f, 1f)]
		public float normalizedTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		public readonly LMECNGKDFGG[] FacialExpressions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
		[Cpp2IlInjected.Token(Token = "0x40004AA")]
		public readonly string[] BodyPoses;

		[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		public readonly (string, LICKDOCMADF)[] HandPoses;

		[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		public bool hideLeftWatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x229")]
		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		public bool hideRightWatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x22A")]
		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		protected bool AIJNEPHAKLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x22C")]
		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		protected Guid NBOFGCPCLEB;

		[Cpp2IlInjected.Token(Token = "0x40004B0")]
		protected static Guid GDIKHLJHKBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
		[Cpp2IlInjected.Token(Token = "0x40004B1")]
		private BIPIJKDNBKE BPIADJKJLFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
		[Cpp2IlInjected.Token(Token = "0x40004B2")]
		private OOOHMBDIILN CNNEGJCNIAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
		[Cpp2IlInjected.Token(Token = "0x40004B3")]
		private IGIKALHDICH BKCIOFKLNEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
		[Cpp2IlInjected.Token(Token = "0x40004B4")]
		private IGIKALHDICH IJDMCEGKIBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x40004B5")]
		private AdditionalHatData MBFCCOGHPAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
		[Cpp2IlInjected.Token(Token = "0x40004B6")]
		private readonly Dictionary<GameObject, AMLFLFEOPIJ> KNCBFBHBKJH;

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		public static Func<GIKHNEIMEFL> MLFCAONEHAO
		{
			[Cpp2IlInjected.Token(Token = "0x600036C")]
			[Cpp2IlInjected.Address(RVA = "0x6E8D680", Offset = "0x6E8CA80", VA = "0x186E8D680")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600036D")]
			[Cpp2IlInjected.Address(RVA = "0x6E8DCE0", Offset = "0x6E8D0E0", VA = "0x186E8DCE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A0")]
		public bool OFOAOKKLIGL
		{
			[Cpp2IlInjected.Token(Token = "0x600036E")]
			[Cpp2IlInjected.Address(RVA = "0x6E8D7E0", Offset = "0x6E8CBE0", VA = "0x186E8D7E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A1")]
		public bool ODLJJGDCHOO
		{
			[Cpp2IlInjected.Token(Token = "0x600036F")]
			[Cpp2IlInjected.Address(RVA = "0x6E8D6D0", Offset = "0x6E8CAD0", VA = "0x186E8D6D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A2")]
		public PlayerAvatarDisplayBase DPAMOENLNKM
		{
			[Cpp2IlInjected.Token(Token = "0x6000371")]
			[Cpp2IlInjected.Address(RVA = "0x985B20", Offset = "0x984F20", VA = "0x180985B20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A3")]
		protected static Guid IGMEEDPMHIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000372")]
			[Cpp2IlInjected.Address(RVA = "0x6E8A660", Offset = "0x6E89A60", VA = "0x186E8A660")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A4")]
		public (GameObject, HAPHCDJNHOG)[] AMNEDIIPPHE
		{
			[Cpp2IlInjected.Token(Token = "0x6000387")]
			[Cpp2IlInjected.Address(RVA = "0x6E8D8F0", Offset = "0x6E8CCF0", VA = "0x186E8D8F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x6E8AF40", Offset = "0x6E8A340", VA = "0x186E8AF40")]
		private IEnumerable<GameObject> JANLMANLAHH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x6E8C0E0", Offset = "0x6E8B4E0", VA = "0x186E8C0E0")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x6E8A750", Offset = "0x6E89B50", VA = "0x186E8A750")]
		private void DLLLCPIIBPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0xE0F400", Offset = "0xE0E800", VA = "0x180E0F400")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x6E8A840", Offset = "0x6E89C40", VA = "0x186E8A840")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x6E8C0F0", Offset = "0x6E8B4F0", VA = "0x186E8C0F0")]
		public void Teardown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x6E8BEE0", Offset = "0x6E8B2E0", VA = "0x186E8BEE0")]
		public void ShowPose(AnimationClip HIMFFIEJFLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x6E8C0B0", Offset = "0x6E8B4B0", VA = "0x186E8C0B0")]
		public void ShowPose(string NPJMOFHGBAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x6E8BE60", Offset = "0x6E8B260", VA = "0x186E8BE60")]
		public void ResetPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x6E8BC90", Offset = "0x6E8B090", VA = "0x186E8BC90")]
		public void ResetHandPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x6E8C550", Offset = "0x6E8B950", VA = "0x186E8C550")]
		public void UpdateHandAnimation()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x6E8C450", Offset = "0x6E8B850", VA = "0x186E8C450")]
		public void UpdateFaceAndBodyShapes(bool HFMGCPKDCHN = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x6E8C7B0", Offset = "0x6E8BBB0", VA = "0x186E8C7B0")]
		public void UpdateLODOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x6E8B990", Offset = "0x6E8AD90", VA = "0x186E8B990", Slot = "4")]
		protected virtual void PNFFKKNLDOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x6E8A4B0", Offset = "0x6E898B0", VA = "0x186E8A4B0", Slot = "5")]
		protected virtual void DBOALHLFKKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x6E898E0", Offset = "0x6E88CE0", VA = "0x186E898E0")]
		public void ApplyHatData(AdditionalHatData CJHEGPDCGMP, bool KLHKKNFFDOB = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x6E89720", Offset = "0x6E88B20", VA = "0x186E89720")]
		public void ApplyHatAdjustmentsToHatAnchorParams()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x6E89C40", Offset = "0x6E89040", VA = "0x186E89C40")]
		public void ApplyHatUVOverride(Vector2 IHCFKJBABOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x6E89B60", Offset = "0x6E88F60", VA = "0x186E89B60")]
		public void ApplyHatPositionAdjustment(Vector3 CMIGDGGGCKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x6E89BD0", Offset = "0x6E88FD0", VA = "0x186E89BD0")]
		public void ApplyHatRotationAdjustment(Vector3 KINPOPLOOPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x6E89CB0", Offset = "0x6E890B0", VA = "0x186E89CB0")]
		public NCBGGKADNMM BuildAvatarItemSelection(GameObject LHIJDKCFGIO, EOPKGKNJKFM APNBNFCFAMM, HAPHCDJNHOG AEJLBPBOCPI)
		{
			return default(NCBGGKADNMM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x6E89D50", Offset = "0x6E89150", VA = "0x186E89D50")]
		public void BuildAvatar(bool HFMGCPKDCHN = false, bool KLHKKNFFDOB = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x6E89860", Offset = "0x6E88C60", VA = "0x186E89860")]
		public void ApplyHatAnchor()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x6E8C600", Offset = "0x6E8BA00", VA = "0x186E8C600")]
		public void UpdateHatAnchor(bool KLHKKNFFDOB = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x6E8B3B0", Offset = "0x6E8A7B0", VA = "0x186E8B3B0")]
		private void NKGLBNBFBBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80")]
		private void HIBMDMHOGKD(AMLFLFEOPIJ NKJAMFONIBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x8C6D80", Offset = "0x8C6180", VA = "0x1808C6D80")]
		private void IGPCMHHLJFN(AMLFLFEOPIJ NKJAMFONIBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x6E8A830", Offset = "0x6E89C30", VA = "0x186E8A830")]
		private void EFJLDBAMDOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x6E8C830", Offset = "0x6E8BC30", VA = "0x186E8C830")]
		public PlayerModernBodyEditorAvatarValidator()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x6E8B8E0", Offset = "0x6E8ACE0", VA = "0x186E8B8E0")]
		[CompilerGenerated]
		private NCBGGKADNMM PGEBHPBPGIK((GameObject, HAPHCDJNHOG) GJHEOAPDDOL)
		{
			return default(NCBGGKADNMM);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public class SkinnedMeshBonesInspector : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004BA")]
		[SerializeField]
		[KAIMDEABLJJ(PGGKFLBMAKK.Self, false, false, false)]
		private SkinnedMeshRenderer skinnedMeshRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004BB")]
		[SerializeField]
		private int BoneWeightsDisplayStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40004BC")]
		[SerializeField]
		private int BoneWeightsDisplayAmount;

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x8C6D70", Offset = "0x8C6170", VA = "0x1808C6D70")]
		public SkinnedMeshBonesInspector()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public struct NCBGGKADNMM
{
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	[CompilerGenerated]
	private sealed class GBDCFAOHLHA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004BF")]
		public IEnumerable<OutfitType> otherOutfitTypes;

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public GBDCFAOHLHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x6E7CC80", Offset = "0x6E7C080", VA = "0x186E7CC80")]
		internal bool CAMAHEJECKK(OutfitType outfitType)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004BD")]
	private AMLFLFEOPIJ FHIJAOKAIDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004BE")]
	private HAPHCDJNHOG LBHGIBJJCNC;

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public AMLFLFEOPIJ MCGICMKBBOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x96ABE0", Offset = "0x969FE0", VA = "0x18096ABE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public HAPHCDJNHOG HJDCAEMFHOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x232B450", Offset = "0x232A850", VA = "0x18232B450")]
		get
		{
			return default(HAPHCDJNHOG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public string PDOKGKDEEKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x6E82520", Offset = "0x6E81920", VA = "0x186E82520")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public bool AHELCPIGPKD
	{
		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x6E824D0", Offset = "0x6E818D0", VA = "0x186E824D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public bool FEIHIMMMDPK
	{
		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x6E82480", Offset = "0x6E81880", VA = "0x186E82480")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x9AFA10", Offset = "0x9AEE10", VA = "0x1809AFA10")]
	public NCBGGKADNMM(AMLFLFEOPIJ NKJAMFONIBA, HAPHCDJNHOG JBCPDKGINNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x6E823C0", Offset = "0x6E817C0", VA = "0x186E823C0")]
	public bool COKKLKKIBFD(OutfitType INGMPLNFCHN, HAPHCDJNHOG IJLDBAIGIBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x6E82160", Offset = "0x6E81560", VA = "0x186E82160")]
	public bool ANFNJOAFGFN(OutfitType INGMPLNFCHN, HAPHCDJNHOG IJLDBAIGIBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x6E82610", Offset = "0x6E81A10", VA = "0x186E82610")]
	public bool NHPOHHNLPAD(NCBGGKADNMM DBODKKLFGKF)
	{
		return default(bool);
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
