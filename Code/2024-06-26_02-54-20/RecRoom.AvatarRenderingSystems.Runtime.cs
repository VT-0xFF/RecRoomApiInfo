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
using RecRoom.AssetIds;
using RecRoom.Avatars;
using RecRoom.Core.Studio;
using RecRoom.Logging.Attributes;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Rendering.Universal;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_AvatarRenderingSystems_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : DAMGOKPKJCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x67D5020", Offset = "0x67D3620", VA = "0x1867D5020", Slot = "4")]
		public override void PIKNDMFIIPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x88C9F0", Offset = "0x88AFF0", VA = "0x18088C9F0")]
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
			[Cpp2IlInjected.Address(RVA = "0x86DC70", Offset = "0x86C270", VA = "0x18086DC70", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override string AssetGUID
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x67E4D70", Offset = "0x67E3370", VA = "0x1867E4D70", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x67E4CA0", Offset = "0x67E32A0", VA = "0x1867E4CA0", Slot = "17")]
		public override bool RuntimeKeyIsValid()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x67E4D30", Offset = "0x67E3330", VA = "0x1867E4D30")]
		public RecNetCDNAssetReference(RecNetCDNKey BHEIPBKEDLG)
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
			[Cpp2IlInjected.Address(RVA = "0x8657D0", Offset = "0x863DD0", VA = "0x1808657D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x864E00", Offset = "0x863400", VA = "0x180864E00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public string CacheHash
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x866520", Offset = "0x864B20", VA = "0x180866520")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x866500", Offset = "0x864B00", VA = "0x180866500")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x67E4DB0", Offset = "0x67E33B0", VA = "0x1867E4DB0")]
		public static RecNetCDNKey FGPCAHEBMEP(string NGDAIGBOBFP, string IEBPPBJMBGP = "")
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5FE8C20", Offset = "0x5FE7220", VA = "0x185FE8C20")]
		public void LOLKJDGFLJJ(string LAPNLHJCMCI, string HBFGLPMFMGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x67E4EB0", Offset = "0x67E34B0", VA = "0x1867E4EB0")]
		public RecNetCDNKey()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[LEDNJNPECJC]
public class FJEOCBOAHBF : MKKMHKLEJAJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	protected readonly List<Mesh> OEJJMMBKMNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	protected readonly List<byte[]> NHKJHLHNCPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	protected readonly List<Matrix4x4> KDGIBEDJEGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	protected readonly List<bool> OPJLPMPBIMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	protected readonly List<int> JMANIHKPJOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	protected readonly List<bool> EJOOBAGJLMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	protected readonly List<int> KBAHEADAIKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	protected Allocator JPDGHBPJONP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	protected LAHINCAGKJC FAHOJCIPFLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	protected byte CNLEHOBBOOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	protected IList<int> MDOOLAKFPBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	protected IList<int> GLHIEJNHMOF;

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x67D09C0", Offset = "0x67CEFC0", VA = "0x1867D09C0", Slot = "4")]
	public void DANDGJIFFLG(Mesh NKIMIKOLCFE, Matrix4x4 FCBIJCBGLKM, byte[] ODAPPFPKOJM, bool OJAFILOOFKF = false, BIMEIEHNBAC.FNGDOONFPID IJHLILAANCL = (BIMEIEHNBAC.FNGDOONFPID)0, int HPPGNFMPMKL = -1, bool NLPDLGBBIHC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x67D0E10", Offset = "0x67CF410", VA = "0x1867D0E10", Slot = "5")]
	public void LFONKKPCGPL(Allocator IDMGOAKOEDG, LAHINCAGKJC KKOACLOODHP, byte EFMHDJCLHII, [Optional] IList<int> PKGFLOGCBKN, [Optional] IList<int> FKCCHFIKNNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x67D0CE0", Offset = "0x67CF2E0", VA = "0x1867D0CE0")]
	private static void IPJKODAMJAF(Mesh NKIMIKOLCFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x67D0E50", Offset = "0x67CF450", VA = "0x1867D0E50")]
	public FJEOCBOAHBF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[LEDNJNPECJC]
public struct AKMBLONIFMO : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	[ReadOnly]
	public EDHGMIDNGDF OLGCKPOOPDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	[ReadOnly]
	public int CDDEHJEOBHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public PCKLALGKHBE BBFAHHBIHAE;

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x67CCFB0", Offset = "0x67CB5B0", VA = "0x1867CCFB0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[LEDNJNPECJC]
[NativeContainer]
public struct PCKLALGKHBE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct ALMGOPJGBLK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public Vector3 MPAPKBCMLIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public Vector3 FFJHDFACBIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public Vector4 EKBJDPFKMAM;
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct LFAJELLPNCP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public float MFNKHICDFAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public float KNIKEIDJFNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public float JBBLHLLCFFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public float LFHHAAMAJAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public byte EMFEICDFMHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public byte BMIBABKEGBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public byte BMCFGCOPJNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public byte JMALDAJHOLI;
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct AKLIKKKFGNL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public half MFNKHICDFAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public half KNIKEIDJFNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public half JBBLHLLCFFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public half LFHHAAMAJAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public byte EMFEICDFMHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public byte BMIBABKEGBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public byte BMCFGCOPJNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public byte JMALDAJHOLI;
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct EIPOEIIKGGF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public half4 MKAJENPGJDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public half2 PHEEOFCIHFF;
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct OANNBDIHEAD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public half4 MKAJENPGJDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public half2 PHEEOFCIHFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public half2 IIOGMCLKKLA;
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public struct BNPNFMDGNKM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public half4 MKAJENPGJDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public half2 PHEEOFCIHFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public half2 IIOGMCLKKLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public half2 NEEMHBALCHB;
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct HMJMIGCIDAF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public half4 MKAJENPGJDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public half2 PHEEOFCIHFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public half2 IIOGMCLKKLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public half2 NEEMHBALCHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public half2 JKIADIKNGJB;
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public struct FFMEDHKNMGG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public float MFNKHICDFAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public float KNIKEIDJFNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public float JBBLHLLCFFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public float LFHHAAMAJAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public int EMFEICDFMHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public int BMIBABKEGBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public int BMCFGCOPJNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public int JMALDAJHOLI;
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public struct LAAHPOMPADD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public Color MKAJENPGJDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public Vector2 PHEEOFCIHFF;
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public struct FJKONCGKJNO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public Color MKAJENPGJDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public Vector2 PHEEOFCIHFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public Vector2 IIOGMCLKKLA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public struct EPPJLOFALOO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public Color MKAJENPGJDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public Vector2 PHEEOFCIHFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public Vector2 IIOGMCLKKLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public Vector2 NEEMHBALCHB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public struct BFIIAEELLEC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public Color MKAJENPGJDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Vector2 PHEEOFCIHFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public Vector2 IIOGMCLKKLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public Vector2 NEEMHBALCHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Vector2 JKIADIKNGJB;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private bool FMGDPGOPFEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public NativeArray<ALMGOPJGBLK> PMCOIGEBFBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public NativeArray<EIPOEIIKGGF> NNAKIIIBOCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public NativeArray<OANNBDIHEAD> GIKPLAMBLEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public NativeArray<BNPNFMDGNKM> OLEMPDABBNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public NativeArray<HMJMIGCIDAF> EMLCKOGFLHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public NativeArray<AKLIKKKFGNL> HAGEIECKPFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public NativeArray<LFAJELLPNCP> AFHGBNBPNHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public NativeArray<LAAHPOMPADD> JOJFEGLGGAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public NativeArray<FJKONCGKJNO> CFFHHNMDKOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public NativeArray<EPPJLOFALOO> PLPNACKIOCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public NativeArray<BFIIAEELLEC> HGCCNJLBPJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public NativeArray<FFMEDHKNMGG> POFFAOEGLAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public NativeArray<int> HJEHHGIJMEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public NativeArray<int> OKELJGGKGND;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private NativeArray<int> DMDHEPNPJHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private NativeArray<int> CHIJLMGGHIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public NativeArray<int> EBBGBCCLOEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public NativeArray<int> LAPPKGFEEHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public NativeArray<int> MMHJBGBEODK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public NativeArray<BoneWeight> CIPKIHCEGMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private NativeArray<int> LIIDINHCICD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private bool CEHKKNPIMIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x159")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private bool KOMPANFGFOD;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int OMMKMGENDMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x67E1E10", Offset = "0x67E0410", VA = "0x1867E1E10")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x67E2080", Offset = "0x67E0680", VA = "0x1867E2080")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int JBCNKKCCGNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x67E1E00", Offset = "0x67E0400", VA = "0x1867E1E00")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x67E1DF0", Offset = "0x67E03F0", VA = "0x1867E1DF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int NMONCPEMHKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x67E1DE0", Offset = "0x67E03E0", VA = "0x1867E1DE0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x67E3780", Offset = "0x67E1D80", VA = "0x1867E3780")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int KALCIMJDOIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x67E1D70", Offset = "0x67E0370", VA = "0x1867E1D70")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x67E40C0", Offset = "0x67E26C0", VA = "0x1867E40C0")]
	public PCKLALGKHBE(int OMBNHCCNPKK, int NHDHPBAIHEG, int KKFLGOEKKEP, int KJMIOMBPFPJ, Allocator IDMGOAKOEDG, int DBOKLIAHFGN, EPJPFJPNPID GKBHGMIOCMC, bool CEHKKNPIMIB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x67E37F0", Offset = "0x67E1DF0", VA = "0x1867E37F0")]
	public void LLHMDAGIEGF(int LLPJHIPCNFD, Vector3 DCMJEJAEEHK, Vector3 HPNFCDLKBEK, Vector4 LBKJPGMAINP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x67E3C90", Offset = "0x67E2290", VA = "0x1867E3C90")]
	public void NPNIIDOAGFF(int LLPJHIPCNFD, BoneWeight IHDJAJLIIOF, NativeSlice<byte> ODAPPFPKOJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x67E2090", Offset = "0x67E0690", VA = "0x1867E2090")]
	public Color EPMEOKECOGH(int LLPJHIPCNFD)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x67E3880", Offset = "0x67E1E80", VA = "0x1867E3880")]
	public void NLBONIANDGB(int LLPJHIPCNFD, Color DDKEAFEIAAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x67E33D0", Offset = "0x67E19D0", VA = "0x1867E33D0")]
	public void JHFHPJIMKNE(byte AJABMBEHIJO, int LLPJHIPCNFD, Vector2 ICGFDOIKAMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x67E3C80", Offset = "0x67E2280", VA = "0x1867E3C80")]
	public void NMAOGAKHJAG(int LLPJHIPCNFD, int IKLLAPMJKNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x67E3790", Offset = "0x67E1D90", VA = "0x1867E3790")]
	public bool LFGJEGHBFLE(int AJABMBEHIJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x67E3300", Offset = "0x67E1900", VA = "0x1867E3300")]
	public void IHNELMBEEIN(int KIHHGEBKJCM, int ANNLKNNLIGI, int DOIKAIEGGLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x67E1E20", Offset = "0x67E0420", VA = "0x1867E1E20", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x67E23C0", Offset = "0x67E09C0", VA = "0x1867E23C0")]
	public Mesh FLDAOIJMJNK([Optional] string FDMHAIDHGLE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[NativeContainer]
[LEDNJNPECJC]
[DefaultMember("Item")]
public struct EDHGMIDNGDF : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public Mesh.MeshDataArray OCLGGBNPIOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public NativeArray<int> LDPFBKLKMBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public NativeArray<int> KMPBFLCJJOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public NativeArray<BoneWeight> CIPKIHCEGMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private NativeArray<Matrix4x4> ODKMPLFIGNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private NativeArray<int> MHPAKEEDPMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private NativeArray<byte> AGLIEPBGEHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private NativeArray<int> HDANFBFDLBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private NativeArray<int> EAHDMNLKGMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public NativeArray<sbyte> CPCIMPADOPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public NativeArray<byte> IFHFJNEHNMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public NativeArray<bool> NLPDLGBBIHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public NativeArray<int> HPPGNFMPMKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private bool CEHKKNPIMIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private NativeArray<int> GOEKKDENBGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private bool KOMPANFGFOD;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public int EBLCECOHDHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x67CF2B0", Offset = "0x67CD8B0", VA = "0x1867CF2B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int MPEKNNJLCCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x67CF610", Offset = "0x67CDC10", VA = "0x1867CF610")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int IIIMKFIPKFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x67CF540", Offset = "0x67CDB40", VA = "0x1867CF540")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int FNAIGGBHFLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x67CF2C0", Offset = "0x67CD8C0", VA = "0x1867CF2C0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x67CF700", Offset = "0x67CDD00", VA = "0x1867CF700")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int OMMKMGENDMH
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x67CF130", Offset = "0x67CD730", VA = "0x1867CF130")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x67CF2E0", Offset = "0x67CD8E0", VA = "0x1867CF2E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int GGCNDDBEIIC
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x67CF710", Offset = "0x67CDD10", VA = "0x1867CF710")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x67CF6F0", Offset = "0x67CDCF0", VA = "0x1867CF6F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public LAHINCAGKJC MBAFBILDFFB
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x67CF720", Offset = "0x67CDD20", VA = "0x1867CF720")]
		get
		{
			return default(LAHINCAGKJC);
		}
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x67CF2D0", Offset = "0x67CD8D0", VA = "0x1867CF2D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public byte IHPLCGHMHNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x67CF110", Offset = "0x67CD710", VA = "0x1867CF110")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x67CF120", Offset = "0x67CD720", VA = "0x1867CF120")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public FDKMEADOAEE PGDICMLLHEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x67CF2F0", Offset = "0x67CD8F0", VA = "0x1867CF2F0")]
		get
		{
			return default(FDKMEADOAEE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x67CF730", Offset = "0x67CDD30", VA = "0x1867CF730")]
	public EDHGMIDNGDF(IList<Mesh> DOCBHJCMNOC, IList<Matrix4x4> OGCGAFJEFNB, IList<bool> NLPDLGBBIHC, byte EFMHDJCLHII, IList<byte[]> GOLOIFEILNM, IList<int> AIIGHENFNJL, IList<bool> HODOILLLJKB, IList<int> HPPGNFMPMKL, IList<int> PKGFLOGCBKN, IList<int> PDIAAIPEJIO, Allocator IDMGOAKOEDG, LAHINCAGKJC KKOACLOODHP, bool CEHKKNPIMIB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x67CF620", Offset = "0x67CDC20", VA = "0x1867CF620")]
	public PCKLALGKHBE FIIPKOMAHKM(Allocator IDMGOAKOEDG, EPJPFJPNPID GKBHGMIOCMC)
	{
		return default(PCKLALGKHBE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x67CF140", Offset = "0x67CD740", VA = "0x1867CF140", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[LEDNJNPECJC]
public class AOJAGLEIPHI : FJEOCBOAHBF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public bool BPKOOBJDDEG;

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x67CEA60", Offset = "0x67CD060", VA = "0x1867CEA60")]
	public EDHGMIDNGDF FLKFPEEIEFB()
	{
		return default(EDHGMIDNGDF);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x67CEB80", Offset = "0x67CD180", VA = "0x1867CEB80")]
	public AOJAGLEIPHI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct FDKMEADOAEE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public Mesh.MeshData CPKKHLEBOBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public NativeSlice<BoneWeight> CIPKIHCEGMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public NativeSlice<byte> CEDABMHNJDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public int BFLAAGIKBGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public Matrix4x4 NHCPLPLJFNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public int IPGLNLKGPHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public NativeSlice<byte> ODAPPFPKOJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public bool EIONHBFAIMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public int NHKMOEANPCL;
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class OBBNDEFFAJC : IIPFAIHICNK
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	private abstract class FOFKAMHNHMK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public readonly CFGFGPACPAK GECIJEJJCEL;

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public virtual bool BLIENMEMHNG
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x8AAFC0", Offset = "0x8A95C0", VA = "0x1808AAFC0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public virtual bool HNCDFKJJCIM
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x8AAFC0", Offset = "0x8A95C0", VA = "0x1808AAFC0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public virtual BIMEIEHNBAC.FNGDOONFPID IPGLNLKGPHL
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x863360", Offset = "0x861960", VA = "0x180863360", Slot = "6")]
			get
			{
				return default(BIMEIEHNBAC.FNGDOONFPID);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public bool FJLPOEHOLHC
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x14C62F0", Offset = "0x14C48F0", VA = "0x1814C62F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public bool GJABJGHHHKG
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x67D1080", Offset = "0x67CF680", VA = "0x1867D1080")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool EKDCFOICDOP
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x67D1090", Offset = "0x67CF690", VA = "0x1867D1090")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x8683A0", Offset = "0x8669A0", VA = "0x1808683A0")]
		protected FOFKAMHNHMK(CFGFGPACPAK OKPGPAIFCEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract PGILFKJEHOF GPNKEEJAKHA(int[] BFNICCKIHCO, List<EGGKBNFDHIC> GMDNNGIEGKF, List<EGGKBNFDHIC> CKCNBFJHHAE);

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract BKEHEBPKJOE KHMGPBKEGLP(uint KEAEHEPAPAH, AvatarSkinnedMeshBoneOrderRemapsData BEHPILIPAPM);
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	private class GKPLKANOOCB : FOFKAMHNHMK
	{
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		[CompilerGenerated]
		private sealed class DJFDFDGHBII
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000E3")]
			public FMHOFFFMGIN<GameObject> skinAvatarItemPrefabHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			public GKPLKANOOCB <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
			public DJFDFDGHBII()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x67CED20", Offset = "0x67CD320", VA = "0x1867CED20")]
			internal void JAEFJLCPHMK(GameObject result)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		private readonly AvatarSkinAssetItem.LKNLOHCAKLI CFAOIMMJMHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private readonly AssetReference FMBGBLCAIDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private readonly BIMEIEHNBAC.FNGDOONFPID FMGJAAOJKPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private readonly DONNKKJBKEB? OHACGFMGGHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private readonly Material[] AAFKBNEFFEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private SkinnedMeshRenderer[] ENEJONKLBGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private AvatarSkinAssetItem IBBKJAEMOIA;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override BIMEIEHNBAC.FNGDOONFPID IPGLNLKGPHL
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x865830", Offset = "0x863E30", VA = "0x180865830", Slot = "6")]
			get
			{
				return default(BIMEIEHNBAC.FNGDOONFPID);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x67D3950", Offset = "0x67D1F50", VA = "0x1867D3950")]
		public GKPLKANOOCB(AvatarSkinAssetItem.LKNLOHCAKLI ELHIFKELGNM, AssetReference IOICAJEBIBI, Material LMHAFOANHGI, CFGFGPACPAK CNCOCPFNBNP, BIMEIEHNBAC.FNGDOONFPID AFPLHBFNDBM = (BIMEIEHNBAC.FNGDOONFPID)0, [Optional] DONNKKJBKEB? PPJFJMIHIKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x67D3A60", Offset = "0x67D2060", VA = "0x1867D3A60")]
		public GKPLKANOOCB(AvatarSkinAssetItem.LKNLOHCAKLI ELHIFKELGNM, AssetReference IOICAJEBIBI, Material LMHAFOANHGI, BIMEIEHNBAC.FNGDOONFPID AFPLHBFNDBM = (BIMEIEHNBAC.FNGDOONFPID)0, [Optional] DONNKKJBKEB? PPJFJMIHIKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x67D3430", Offset = "0x67D1A30", VA = "0x1867D3430", Slot = "7")]
		public override PGILFKJEHOF GPNKEEJAKHA(int[] BFNICCKIHCO, List<EGGKBNFDHIC> GMDNNGIEGKF, List<EGGKBNFDHIC> CKCNBFJHHAE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x67D3600", Offset = "0x67D1C00", VA = "0x1867D3600", Slot = "8")]
		public override BKEHEBPKJOE KHMGPBKEGLP(uint KEAEHEPAPAH, AvatarSkinnedMeshBoneOrderRemapsData BEHPILIPAPM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x67D38E0", Offset = "0x67D1EE0", VA = "0x1867D38E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	private class LEBDDNMMEGE : FOFKAMHNHMK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public readonly MIMKMAGJOLD CKOPMFHINIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private FMHOFFFMGIN<IICDLNLFNKP> DEEBNPOKNLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public IICDLNLFNKP AOFHDALDAKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		private FMHOFFFMGIN<Material[]> NLHNOMIPNFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public List<Material> EAJFFLMADML;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override bool BLIENMEMHNG
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x87D530", Offset = "0x87BB30", VA = "0x18087D530", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public override bool HNCDFKJJCIM
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x67D3FB0", Offset = "0x67D25B0", VA = "0x1867D3FB0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x1D34CE0", Offset = "0x1D332E0", VA = "0x181D34CE0")]
		public LEBDDNMMEGE(CFGFGPACPAK OKPGPAIFCEO, MIMKMAGJOLD DMEBHMGFAOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x67D4380", Offset = "0x67D2980", VA = "0x1867D4380", Slot = "7")]
		public override PGILFKJEHOF GPNKEEJAKHA(int[] BFNICCKIHCO, List<EGGKBNFDHIC> GMDNNGIEGKF, List<EGGKBNFDHIC> CKCNBFJHHAE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x67D48C0", Offset = "0x67D2EC0", VA = "0x1867D48C0", Slot = "8")]
		public override BKEHEBPKJOE KHMGPBKEGLP(uint KEAEHEPAPAH, AvatarSkinnedMeshBoneOrderRemapsData BEHPILIPAPM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x67D49F0", Offset = "0x67D2FF0", VA = "0x1867D49F0")]
		public BKEHEBPKJOE OFNDLDOIPJD(GameObject DGPMDGGABNO, uint KEAEHEPAPAH, bool BCPIJJBCKPM, bool AKPNBDBMIEN, AvatarSkinnedMeshBoneOrderRemapsData BEHPILIPAPM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x67D4010", Offset = "0x67D2610", VA = "0x1867D4010")]
		public static bool GDNNHCHACCA(Renderer[] DMHJBBCAABP, string EPLPEFHHKPH, [Out] Renderer OIHCDHCDINE, [Out] Renderer PIJDAKDFCNB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x67D4BE0", Offset = "0x67D31E0", VA = "0x1867D4BE0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x67D3EE0", Offset = "0x67D24E0", VA = "0x1867D3EE0")]
		private (FMHOFFFMGIN<IICDLNLFNKP>, FMHOFFFMGIN<Material[]>) ECEDHKOJFOE()
		{
			return default((FMHOFFFMGIN<IICDLNLFNKP>, FMHOFFFMGIN<Material[]>));
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x42E8E10", Offset = "0x42E7410", VA = "0x1842E8E10")]
		[CompilerGenerated]
		private void MCMIABPMJHM(IICDLNLFNKP HJBJAPKPPFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x67D4860", Offset = "0x67D2E60", VA = "0x1867D4860")]
		[CompilerGenerated]
		private void KEOIAEBKAFN(Material[] HJBJAPKPPFA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class POKIEBFLPIE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public OBBNDEFFAJC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public PGGFJFHOMCP buildMeshPromise;

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
		public POKIEBFLPIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x67E4BD0", Offset = "0x67E31D0", VA = "0x1867E4BD0")]
		internal void FNEOJONCPIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x67E4BF0", Offset = "0x67E31F0", VA = "0x1867E4BF0")]
		internal void FPJMOKCMAPG(string err)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x67E4B40", Offset = "0x67E3140", VA = "0x1867E4B40")]
		internal void BPNNGPBBJJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x67E4C10", Offset = "0x67E3210", VA = "0x1867E4C10")]
		internal void ONGBAEAKFDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x866510", Offset = "0x864B10", VA = "0x180866510")]
		internal PGILFKJEHOF CIHHAGFEFMB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class BMGEEPDBLPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public int lowestPossibleLOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public POKIEBFLPIE CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
		public BMGEEPDBLPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x67CEB90", Offset = "0x67CD190", VA = "0x1867CEB90")]
		internal MDKHCAHBNED EGBPGBADCOG(int lod)
		{
			return default(MDKHCAHBNED);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class JGLOFLBIBOO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public List<PGGFJFHOMCP> innerPromises;

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
		public JGLOFLBIBOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x67D3DB0", Offset = "0x67D23B0", VA = "0x1867D3DB0")]
		internal void KKJGGPKLGAP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class GENENPNAMAF : IEnumerator<MBMMHILCGCA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private MBMMHILCGCA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public OBBNDEFFAJC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public List<FOFKAMHNHMK> parts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public int[] LODs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public List<PGGFJFHOMCP> innerPromises;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public bool isFirstPerson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public Func<int, MDKHCAHBNED> getLayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public OPNKHHPPPLC materialPropertyBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public Material materialInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private int <lodIndex>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		private MBMMHILCGCA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x866510", Offset = "0x864B10", VA = "0x180866510", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x866510", Offset = "0x864B10", VA = "0x180866510", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x8683A0", Offset = "0x8669A0", VA = "0x1808683A0")]
		[DebuggerHidden]
		public GENENPNAMAF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x67D10B0", Offset = "0x67CF6B0", VA = "0x1867D10B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x67D12C0", Offset = "0x67CF8C0", VA = "0x1867D12C0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class PIDIDAGBKMP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public int[] LODs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public OBBNDEFFAJC <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
		public PIDIDAGBKMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x67E4AF0", Offset = "0x67E30F0", VA = "0x1867E4AF0")]
		internal PGILFKJEHOF EDGGJOHALMG(FOFKAMHNHMK p)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class MIIKBBAJNEB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public MBKHDHMPHNH cancelable;

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
		public MIIKBBAJNEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x980AD0", Offset = "0x97F0D0", VA = "0x180980AD0")]
		internal void AHJAFHDOPBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0xA3F4A0", Offset = "0xA3DAA0", VA = "0x180A3F4A0")]
		internal void LOKOIHPCCCO(string err)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class HADOCEDFGLD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public long jobComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public Stopwatch stopwatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public SkinnedMeshRenderer lodRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public long meshComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public string meshName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public long meshCopyComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public OBBNDEFFAJC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public int lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public List<Material> newUniqueMaterials;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public int frameStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public long lodBuildStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public long startCombineBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public long jobScheduled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public Action onFinally;

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
		public HADOCEDFGLD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class HKDIFGPHHHN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public bool waitingForComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public JobHandle lodBuildJobHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public PCKLALGKHBE defaultMeshJobContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public EDHGMIDNGDF defaultAvatarMeshJobGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public HADOCEDFGLD CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
		public HKDIFGPHHHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x67D3B70", Offset = "0x67D2170", VA = "0x1867D3B70")]
		internal void KGEDGJDINDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0xA38250", Offset = "0xA36850", VA = "0x180A38250")]
		internal void IPJEONJOHOK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class ACMGOOLNABL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public bool waitingForComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public JobHandle lodBuildJobHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public MENNLKOLGBA legacyMeshJobContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public OPKGMGJOBGD legacyAvatarMeshJobGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public HADOCEDFGLD CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
		public ACMGOOLNABL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x67CCD70", Offset = "0x67CB370", VA = "0x1867CCD70")]
		internal void EMIEHFPCMEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0xA3F1F0", Offset = "0xA3D7F0", VA = "0x180A3F1F0")]
		internal void MPEKBMAIKEA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private sealed class LEHPLMNKLJL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public MBKHDHMPHNH cancelablePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public MIMKMAGJOLD avatarItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public OBBNDEFFAJC <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
		public LEHPLMNKLJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x67D4C30", Offset = "0x67D3230", VA = "0x1867D4C30")]
		internal PGILFKJEHOF EFOOKLONKBK(JLBMGMIIKLH item)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x67D4FE0", Offset = "0x67D35E0", VA = "0x1867D4FE0")]
		internal void MBIANFHPMHK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class CMLBCGGBBIE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public FMHOFFFMGIN<Texture2D> resourceHandle;

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
		public CMLBCGGBBIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x67CECD0", Offset = "0x67CD2D0", VA = "0x1867CECD0")]
		internal void DPIGHOJOLBB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class CFGJOLOCLGG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		public string overrideItemIdentifier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		public CFGFGPACPAK overrideBodyPart;

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
		public CFGJOLOCLGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x67CEC50", Offset = "0x67CD250", VA = "0x1867CEC50")]
		internal bool CEOLKFLDJIL(KeyValuePair<string, MIMKMAGJOLD> entry)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private AvatarConfiguration DBDFBBOBJHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private Transform HBDDLFJCMCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private AssetReference FMBGBLCAIDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private GameObject EEKMEIPKCOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private GameObject AFCMFFFFGGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private SkinnedMeshRenderer JPCPFIGHCJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private AvatarSkinnedMeshBoneOrderRemapsData CDFEONHBODL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private Transform[] HDFDPCKBFPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private Matrix4x4[] OIHFFFBMKDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private Material CNNMBFJELLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private Material EHLPLJADDJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private Material LLKCADFDGKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private Shader IBFNDAJKEAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private Shader GAGPPPDKIHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private Animator LOEJJGILMIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private Renderer[] HJJGJIEHPJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private BIMEIEHNBAC.FNGDOONFPID NPEPABJOEIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private AvatarBodyPartShapesManager AOLKJJCBKNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private IReadOnlyDictionary<string, Transform> GGCDJAGIDKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private AvatarFaceShapeData.EFAMHAMMOFD BECIEGAOCIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private AvatarBodyShapeData.MEJAHDBKBGF DEMJGAKMBHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private bool BDFBBINAKOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB1")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private bool OIIMEDLOFFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private Color KBFIDPBDMDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private Color EJAGIHEBBJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private Color AHGMIGAAIFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private Color? BLNGCEDPBNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private Color? DGDJJBBKMGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10C")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private Color? HDDBJPGIKBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private Color? OJLHLPLFMID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private Texture2D JDNLHNLBHHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private Texture2D JNGJOANPPEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	[CanBeNull]
	private MIMKMAGJOLD ONGGGAPLMCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private Texture GPNBCBMBHHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private Color BMLHCNCBGMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public Dictionary<Renderer, OPNKHHPPPLC> NFOHJEIFMDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private Dictionary<Renderer, OPNKHHPPPLC> NCHDANICLBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private Dictionary<string, List<JJDDAFLFJDM>> PAFBFCJGKGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private Dictionary<string, List<JJDDAFLFJDM>> PMFHNIHIPNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private readonly List<EGGKBNFDHIC> BCFAMJALOMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private readonly List<EGGKBNFDHIC> INDBGIFMMNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private readonly List<EGGKBNFDHIC> GEEBIPIFIKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly List<EGGKBNFDHIC> OOMKHNFMPNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private Dictionary<JJDDAFLFJDM, Material> PHPECINPCBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private Dictionary<JJDDAFLFJDM, Material> DGKHBDJOKEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private SkinnedMeshRenderer[] BEMPKKPMPKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private SkinnedMeshRenderer[] OGDEIFDMLHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private SkinnedMeshRenderer[] DNIJGMGFNKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private SkinnedMeshRenderer[] PEPNCBMOMEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private readonly Dictionary<string, FMHOFFFMGIN<Texture2D>> AOCIJHACDGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private readonly Dictionary<string, FMHOFFFMGIN<Texture2D>> CFLLGGMPKMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private FitMeshHemisphere GLHFDIKIJAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private bool CCNKFAJOOMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private MPNIGMOKBGH NPODIKEHINJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private bool NJNGICGMLHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private AnchorParamsRestrictions CFOLMJAAHGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private bool EBFNNEMJCDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private Transform KDKEGAKFKJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private Transform BGEMMLJIGGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private bool ICBCLJNCNLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x229")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private bool OHGDEIGMGLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x22C")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private Vector3 HGLKKHKNGHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private Quaternion ADIEHJBCJEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private Vector2 LGMGNCJLMAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private FitMeshHemisphere PANPLGMJHAD;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private Material FGBNIFMNPLC;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private Material KPFELLJEJFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private Dictionary<string, MIMKMAGJOLD> IFNNBBHHMKO;

	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private static readonly int NHMKLIBBMDF;

	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private static readonly int KPKPHCFOCGE;

	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private static readonly int NKKNKAOBIFM;

	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private static readonly int GCOMONLDFAN;

	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private static readonly int ONHOLNGKMOJ;

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private static readonly int GLECGCDGJEJ;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private static readonly int JHKGBNNMKFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private readonly BGECMLEGDCD KBDOMIEIGGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private readonly BGECMLEGDCD DEICJBLEFDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private bool CHMCMMKMKKG;

	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private static Lazy<IMFFKMNFHIF> BGEOFNKLPEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private Lazy<DPJMDPCIDPO> KBKBHEAMEFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private Lazy<DGIFIPCFAON> PNEMKPOIKOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private KKBDEFJOIBO INBNEPBAMHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private BOAANLGFGMH HOHNNDDLLMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private List<Action> EDDKLONNGCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B0")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private LOIHFDKLGJH GODOKKEDJOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B8")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private SkinnedMeshRenderer[] FOPMOEDJOAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C0")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private int NJEMNCLPKGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C4")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private bool CBODNIDHIPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private int LAFNKHFJHEN;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool NLAOLHLKGKC
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x19080D0", Offset = "0x19066D0", VA = "0x1819080D0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x18F6F50", Offset = "0x18F5550", VA = "0x1818F6F50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool GMOCGAKGPOG
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x67DC130", Offset = "0x67DA730", VA = "0x1867DC130")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private Material DOFKEJHKDPO
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x67DB650", Offset = "0x67D9C50", VA = "0x1867DB650")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private Material JJIDBJCPPMA
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x67DCEB0", Offset = "0x67DB4B0", VA = "0x1867DCEB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	private bool POGADALPHOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x87D530", Offset = "0x87BB30", VA = "0x18087D530")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public PKLKNBHIDDA MIBAHGEAALD
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8E43B0", Offset = "0x8E29B0", VA = "0x1808E43B0", Slot = "21")]
		get
		{
			return default(PKLKNBHIDDA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	private bool AHDCJMMCMCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x67DBB70", Offset = "0x67DA170", VA = "0x1867DBB70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private static IMFFKMNFHIF EMPPEOIJCEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x67E10D0", Offset = "0x67DF6D0", VA = "0x1867E10D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	private DPJMDPCIDPO BHNBOINNCKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x67D5420", Offset = "0x67D3A20", VA = "0x1867D5420")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	private DGIFIPCFAON DMNBKAEIMBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x67DF840", Offset = "0x67DDE40", VA = "0x1867DF840")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	private KKBDEFJOIBO LJADODFIPFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x67DC920", Offset = "0x67DAF20", VA = "0x1867DC920")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	private BOAANLGFGMH AIDMJLFPAII
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x67DD430", Offset = "0x67DBA30", VA = "0x1867DD430")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public BGECMLEGDCD BKMNFFDBPGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0xA17D40", Offset = "0xA16340", VA = "0x180A17D40", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public BGECMLEGDCD LCCKJILIADA
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x13DC090", Offset = "0x13DA690", VA = "0x1813DC090", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public SkinnedMeshRenderer[] NDHLFNJJKAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xB03B00", Offset = "0xB02100", VA = "0x180B03B00", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public Renderer[] GPLMHBJCFNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x8689D0", Offset = "0x866FD0", VA = "0x1808689D0", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public bool IDAEICADNEN
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x67DBA00", Offset = "0x67DA000", VA = "0x1867DBA00", Slot = "20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public BIMEIEHNBAC.FNGDOONFPID EGOPEJKHIEF
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x868AD0", Offset = "0x8670D0", VA = "0x180868AD0", Slot = "18")]
		get
		{
			return default(BIMEIEHNBAC.FNGDOONFPID);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public int IICPBCOIHNP
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x1909450", Offset = "0x1907A50", VA = "0x181909450")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x67DC6E0", Offset = "0x67DACE0", VA = "0x1867DC6E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private bool BLOPNCNIHAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x67DD730", Offset = "0x67DBD30", VA = "0x1867DD730")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	private static bool IPKIBHOHPHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x67D88D0", Offset = "0x67D6ED0", VA = "0x1867D88D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private bool NCCAEGEDMAE
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x67DB7E0", Offset = "0x67D9DE0", VA = "0x1867DB7E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x67E1450", Offset = "0x67DFA50", VA = "0x1867E1450")]
	public OBBNDEFFAJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x67D59A0", Offset = "0x67D3FA0", VA = "0x1867D59A0", Slot = "26")]
	public void BGGINNGCCML(DAPDMFLMPMN LBOBMIHKMAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x67E1180", Offset = "0x67DF780", VA = "0x1867E1180", Slot = "27")]
	public void POEMMNCIOIO(OHKKPNMKIGD HAEEKGDMECI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x67DC6E0", Offset = "0x67DACE0", VA = "0x1867DC6E0", Slot = "4")]
	public void PAMFOOKGEPC(int KEAEHEPAPAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x67DBE90", Offset = "0x67DA490", VA = "0x1867DBE90", Slot = "9")]
	public void HOCICMAJOJI(LBMNBPOBJJP DENBDPFKGHP, Texture2D ODAFHLABAMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x67DF890", Offset = "0x67DDE90", VA = "0x1867DF890", Slot = "10")]
	public void NGDGLICFKAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x67DAF20", Offset = "0x67D9520", VA = "0x1867DAF20", Slot = "11")]
	public bool FFMMPELBIHC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x67DC250", Offset = "0x67DA850", VA = "0x1867DC250", Slot = "8")]
	public void IJHNLIJFIEH(CKCCMOEGBKE ADMNPLCNJPK, Color? MKAJENPGJDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x67D7B30", Offset = "0x67D6130", VA = "0x1867D7B30")]
	private void BPLMKALDGJM(Action IPPFDIMJGND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x67DC1E0", Offset = "0x67DA7E0", VA = "0x1867DC1E0", Slot = "5")]
	public void IIIPOAMGPJA(MIMKMAGJOLD IPAGCDIHEKL, Texture FEOJHKMEALC, Color PFAGPLDNLGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x18F6F50", Offset = "0x18F5550", VA = "0x1818F6F50", Slot = "6")]
	public void DAODPGMPFFN(bool DAHCEJCMMGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x12E0960", Offset = "0x12DEF60", VA = "0x1812E0960", Slot = "7")]
	public void IMHKIKCLNAF(LOIHFDKLGJH LIIDINHCICD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x67D60A0", Offset = "0x67D46A0", VA = "0x1867D60A0", Slot = "14")]
	public PGGFJFHOMCP BHPACJFKFMP(AFANGDOOELI LHBLIJABHBB, bool INNEGOEHHCH, int[] EELKGIEHJAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x67D7C50", Offset = "0x67D6250", VA = "0x1867D7C50", Slot = "15")]
	public void CFAPHJJKPNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x67DA4A0", Offset = "0x67D8AA0", VA = "0x1867DA4A0")]
	private bool DEOHBEHAFBK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x8689E0", Offset = "0x866FE0", VA = "0x1808689E0", Slot = "19")]
	public void HDJJFINOBBI(BIMEIEHNBAC.FNGDOONFPID BIMGGMHAMLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x67DA900", Offset = "0x67D8F00", VA = "0x1867DA900")]
	private bool DJOBNPMPPFJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x67DD7B0", Offset = "0x67DBDB0", VA = "0x1867DD7B0")]
	private PGGFJFHOMCP LOCNMICNFBD(bool INNEGOEHHCH, List<FOFKAMHNHMK> LAFAGNIFEDF, int[] EELKGIEHJAD, Func<int, MDKHCAHBNED> KGOBOOGNHJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x67DCFA0", Offset = "0x67DB5A0", VA = "0x1867DCFA0")]
	[IteratorStateMachine(typeof(GENENPNAMAF))]
	private IEnumerator<MBMMHILCGCA> JLOFLOLHDNE(bool INNEGOEHHCH, List<FOFKAMHNHMK> LAFAGNIFEDF, int[] EELKGIEHJAD, Func<int, MDKHCAHBNED> KGOBOOGNHJE, OPNKHHPPPLC PEMDCAAGKJL, Material NIDMFFJDBKL, List<PGGFJFHOMCP> GAKMNHEJKME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x67D8610", Offset = "0x67D6C10", VA = "0x1867D8610")]
	private PGGFJFHOMCP CLLJFOFMKLJ(List<FOFKAMHNHMK> LAFAGNIFEDF, int[] EELKGIEHJAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x67D8A70", Offset = "0x67D7070", VA = "0x1867D8A70")]
	private JMPIHICOHFM DCHGMFOKMDA(List<FOFKAMHNHMK> LAFAGNIFEDF, int KEAEHEPAPAH, bool INNEGOEHHCH, MDKHCAHBNED AHFHOBDDPJH, bool EAFBHPHKAKM, OPNKHHPPPLC PEMDCAAGKJL, Material NIDMFFJDBKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x67D5840", Offset = "0x67D3E40", VA = "0x1867D5840", Slot = "22")]
	public void ANCNIAFAGLG(AvatarFaceShape JGIPOPKNCGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x67DA5E0", Offset = "0x67D8BE0", VA = "0x1867DA5E0", Slot = "23")]
	public void DGGJPIDPGHH(AvatarBodyShape KCCBMGFPCKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x67DC700", Offset = "0x67DAD00", VA = "0x1867DC700", Slot = "25")]
	public void IOFBDAHBIDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x67DC9A0", Offset = "0x67DAFA0", VA = "0x1867DC9A0", Slot = "24")]
	public void JENBCHKFCKM(bool BGNGCKLJLEB, bool PIHAFFCCEKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x67DAB10", Offset = "0x67D9110", VA = "0x1867DAB10")]
	private void EIGNKJCODMM(SkinnedMeshRenderer GPJFNFKKHDD, int KEAEHEPAPAH, Mesh NKIMIKOLCFE, List<Material> PNAAPIJJLFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x67DAC60", Offset = "0x67D9260", VA = "0x1867DAC60")]
	private static Material EMGCIKCMIKP(Dictionary<JJDDAFLFJDM, Material> BIHAOADDGGK, Material HMHMIFACNHN, MMBAOPJHELB MMAMFDIECKL, GELMELABMBB NENEKIBFPEN, CFGFGPACPAK CNCOCPFNBNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x67DBCB0", Offset = "0x67DA2B0", VA = "0x1867DBCB0")]
	private static MMBAOPJHELB HJELKKLAEIN(FOFKAMHNHMK POMGLPJJCEO, int IHFGDHGEMHO)
	{
		return default(MMBAOPJHELB);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x67D5C60", Offset = "0x67D4260", VA = "0x1867D5C60")]
	private void BGJOICENGPI(int KLDNMGGJDFC, Material EGLABJPOFKK, FOFKAMHNHMK POMGLPJJCEO, [Out] Texture2D DFLAIELNLDA, [Out] Vector4 CGEGHMJPIME, [Out] Texture2D PECIGIOEFGG, [Out] Texture2D MPJNNDPLJKE, [Out] Texture2D FNHFIJAFNND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x67DC9B0", Offset = "0x67DAFB0", VA = "0x1867DC9B0")]
	private void JFMNCGPHGJO(int KLDNMGGJDFC, Material EGLABJPOFKK, FOFKAMHNHMK POMGLPJJCEO, [Out] Color GGNHIPEKBLP, [Out] Color FFDELLMFGAN, [Out] Color MDDCDPMKKLD, [Out] Color HGGOAPGOAEL, [Out] Color OEICKEODEEG, [Out] Color DFFDAGJEFKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x67DA6A0", Offset = "0x67D8CA0", VA = "0x1867DA6A0")]
	private bool DGNOKOFCDLF(Material EGLABJPOFKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x67D81B0", Offset = "0x67D67B0", VA = "0x1867D81B0")]
	private static Material CKBJAPHKLEI(int KLDNMGGJDFC, LEBDDNMMEGE POMGLPJJCEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x67E0CF0", Offset = "0x67DF2F0", VA = "0x1867E0CF0")]
	private static GELMELABMBB OMBDIFLBGEB(FOFKAMHNHMK POMGLPJJCEO, int IHFGDHGEMHO)
	{
		return default(GELMELABMBB);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x67D5470", Offset = "0x67D3A70", VA = "0x1867D5470")]
	private static void AJCLIFEOIJH(Dictionary<string, List<JJDDAFLFJDM>> JFPGMJFEBIM, FOFKAMHNHMK NAEBBHKLBHC, Material HMHMIFACNHN, MMBAOPJHELB ADMNPLCNJPK, GELMELABMBB DENBDPFKGHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x67DFEB0", Offset = "0x67DE4B0", VA = "0x1867DFEB0")]
	private static SkinnedMeshRenderer NPEHEHPEDKP(Transform AJGPPFKLKHC, Transform HFIDCABJIBE, SkinnedMeshRenderer[] DMHJBBCAABP, int KEAEHEPAPAH, MDKHCAHBNED AHFHOBDDPJH, bool INNEGOEHHCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x67DB3E0", Offset = "0x67D99E0", VA = "0x1867DB3E0")]
	private void GCGJEBGIKOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x67D5990", Offset = "0x67D3F90", VA = "0x1867D5990")]
	private void BCPFJBDEICD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x67E0B90", Offset = "0x67DF190", VA = "0x1867E0B90")]
	private static void OLEGIBDFBOA(Dictionary<JJDDAFLFJDM, Material> BIHAOADDGGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x67E0DE0", Offset = "0x67DF3E0", VA = "0x1867E0DE0")]
	private static void PBDNJPCCOIB(Dictionary<Renderer, OPNKHHPPPLC> LHBPBIAPOMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x67DD540", Offset = "0x67DBB40", VA = "0x1867DD540")]
	private void LEHJJIAMLDD(SkinnedMeshRenderer[] DMHJBBCAABP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x67D7BB0", Offset = "0x67D61B0", VA = "0x1867D7BB0")]
	private void CALAIPIENAD(SkinnedMeshRenderer LBPNJIHGJDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x67D7E50", Offset = "0x67D6450", VA = "0x1867D7E50")]
	private void CFBCALGIPPD(List<EGGKBNFDHIC> BNHPPFDMGJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x67DF5D0", Offset = "0x67DDBD0", VA = "0x1867DF5D0")]
	private void NCKMPICJLPM(Dictionary<string, FMHOFFFMGIN<Texture2D>> JFPGMJFEBIM, bool MJMDFBNDGLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x67D5760", Offset = "0x67D3D60", VA = "0x1867D5760")]
	private void AJOOHMCPEGG(Dictionary<string, List<JJDDAFLFJDM>> JFPGMJFEBIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x67DE2E0", Offset = "0x67DC8E0", VA = "0x1867DE2E0")]
	private void MFCELEDOFLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x67E0F40", Offset = "0x67DF540", VA = "0x1867E0F40")]
	private void PCAHKBNJJOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x67DDD90", Offset = "0x67DC390", VA = "0x1867DDD90")]
	private void MAMKGHPGHLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x67DF750", Offset = "0x67DDD50", VA = "0x1867DF750")]
	private void NDBDMIEBNKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x67DD4B0", Offset = "0x67DBAB0", VA = "0x1867DD4B0")]
	private void LCKLPBLIFKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x67DB0D0", Offset = "0x67D96D0", VA = "0x1867DB0D0")]
	private void FPBBDDEIJIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x67DAE50", Offset = "0x67D9450", VA = "0x1867DAE50")]
	private void FBIOAPEGNMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x67DC140", Offset = "0x67DA740", VA = "0x1867DC140")]
	private void IGPICDKELIG(bool JMHOGIJFGPJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x67DD660", Offset = "0x67DBC60", VA = "0x1867DD660")]
	private void LIPMLCKAPII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x67DB5B0", Offset = "0x67D9BB0", VA = "0x1867DB5B0")]
	private void GNMHMMMIMKH(bool JMHOGIJFGPJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x67E0480", Offset = "0x67DEA80", VA = "0x1867E0480")]
	private void OFCBMPGIEGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x67D8230", Offset = "0x67D6830", VA = "0x1867D8230")]
	private void CKFDBIGPAEC(Material NIDMFFJDBKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x67DF910", Offset = "0x67DDF10", VA = "0x1867DF910")]
	private void NGGALKHCPAN(Material NIDMFFJDBKL, Color FFDELLMFGAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x67DD0B0", Offset = "0x67DB6B0", VA = "0x1867DD0B0")]
	private void JOOFDGNGOBN(Material NIDMFFJDBKL, Color MDDCDPMKKLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x67DD1D0", Offset = "0x67DB7D0", VA = "0x1867DD1D0")]
	private void KOJGPHAACHH(Material NIDMFFJDBKL, Color GGNHIPEKBLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x67DFDC0", Offset = "0x67DE3C0", VA = "0x1867DFDC0")]
	private void NMFADDIIBLM(Material NIDMFFJDBKL, Texture2D ODAFHLABAMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x67D52A0", Offset = "0x67D38A0", VA = "0x1867D52A0")]
	private void AGJLLADCEIE(Material NIDMFFJDBKL, Texture DHBCPIJDMCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x67D50E0", Offset = "0x67D36E0", VA = "0x1867D50E0")]
	private void AEGFLACCPJL(Action<OPNKHHPPPLC> HCKBCCONIJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x67D8030", Offset = "0x67D6630", VA = "0x1867D8030")]
	private void CGEIACOFJMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x67D7750", Offset = "0x67D5D50", VA = "0x1867D7750")]
	private void BMEEFICBGOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x67DE460", Offset = "0x67DCA60", VA = "0x1867DE460")]
	private PGGFJFHOMCP MMDAINMIHPI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x67E07C0", Offset = "0x67DEDC0", VA = "0x1867E07C0")]
	private void OIJOKMNEFKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x67DFA00", Offset = "0x67DE000", VA = "0x1867DFA00")]
	public void NIOEHFKKBFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x67D85A0", Offset = "0x67D6BA0", VA = "0x1867D85A0")]
	private void CKHGIKPOION(Vector3 KBHBDHIEKKP, Quaternion JAFLFHHIBJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x67E00E0", Offset = "0x67DE6E0", VA = "0x1867E00E0")]
	private void ODEPOKPBCNL(List<FOFKAMHNHMK> DJINLCMLEFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x67DEA50", Offset = "0x67DD050", VA = "0x1867DEA50")]
	public void MMMLPFAHDEE(MPNIGMOKBGH IHDBJBCCFPK, bool JNFGNCKGPJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x67DEF50", Offset = "0x67DD550", VA = "0x1867DEF50")]
	public void MMMLPFAHDEE(MPNIGMOKBGH IHDBJBCCFPK, AnchorParamsRestrictions BAGKDLOIAOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0xA04330", Offset = "0xA02930", VA = "0x180A04330")]
	private static void OFNFPLDGAKB(FitMeshHemisphere NCCJLHMFMKH, Transform CPNJAMEEOPJ, MPNIGMOKBGH IHDBJBCCFPK, AnchorParamsRestrictions IDEKHEINMFP, [Out] Vector3 DCBNBHMBGKP, [Out] Quaternion JAFBJNOBENG, [Out] MPNIGMOKBGH LIIHAIPPJNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x67DB220", Offset = "0x67D9820", VA = "0x1867DB220")]
	public void GBNKAKDFBCC(Vector2 IPLBIJAMABD, Vector3 FPDAAEPPIEJ, Vector3 DIPLBFGLHMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x67DD2C0", Offset = "0x67DB8C0", VA = "0x1867DD2C0")]
	private void LANFCCOOFKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x67D5900", Offset = "0x67D3F00", VA = "0x1867D5900")]
	private void ANLJODBGPJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x67DADC0", Offset = "0x67D93C0", VA = "0x1867DADC0")]
	[CompilerGenerated]
	private void EPOHAPNLOIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x67DA9C0", Offset = "0x67D8FC0", VA = "0x1867DA9C0")]
	[CompilerGenerated]
	private void DLJDIFHAJEN(OPNKHHPPPLC GGEKPBNMLCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x67DC0A0", Offset = "0x67DA6A0", VA = "0x1867DC0A0")]
	[CompilerGenerated]
	private void HOKKIAIJCPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x67DE440", Offset = "0x67DCA40", VA = "0x1867DE440")]
	[CompilerGenerated]
	private void MFHGIJBKHPO(OPNKHHPPPLC GGEKPBNMLCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x67DAA80", Offset = "0x67D9080", VA = "0x1867DAA80")]
	[CompilerGenerated]
	private void EGBOAKPHABP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x67DF820", Offset = "0x67DDE20", VA = "0x1867DF820")]
	[CompilerGenerated]
	private void NDPMIBDBDKN(OPNKHHPPPLC GGEKPBNMLCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x67D76C0", Offset = "0x67D5CC0", VA = "0x1867D76C0")]
	[CompilerGenerated]
	private void BJNBPIODFKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x67DBDD0", Offset = "0x67DA3D0", VA = "0x1867DBDD0")]
	[CompilerGenerated]
	private void HKMOGBPDDFK(OPNKHHPPPLC GGEKPBNMLCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x67DC650", Offset = "0x67DAC50", VA = "0x1867DC650")]
	[CompilerGenerated]
	private void IKILAFECIDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x67D50B0", Offset = "0x67D36B0", VA = "0x1867D50B0")]
	[CompilerGenerated]
	private void ABCGLLMPJFB(OPNKHHPPPLC GGEKPBNMLCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x67DA9F0", Offset = "0x67D8FF0", VA = "0x1867DA9F0")]
	[CompilerGenerated]
	private void EGBMIHBMFMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x67DB0A0", Offset = "0x67D96A0", VA = "0x1867DB0A0")]
	[CompilerGenerated]
	private void FOFOFLIIADC(OPNKHHPPPLC GGEKPBNMLCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x67D57B0", Offset = "0x67D3DB0", VA = "0x1867D57B0")]
	[CompilerGenerated]
	private void AMMEEHNEBAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x67DFD90", Offset = "0x67DE390", VA = "0x1867DFD90")]
	[CompilerGenerated]
	private void NJPIFHPDFNL(OPNKHHPPPLC GGEKPBNMLCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x67D7AB0", Offset = "0x67D60B0", VA = "0x1867D7AB0")]
	[CompilerGenerated]
	private void BMILKADNOCH(KeyValuePair<string, FMHOFFFMGIN<Texture2D>> KGDKKABCDKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x67D5390", Offset = "0x67D3990", VA = "0x1867D5390")]
	[CompilerGenerated]
	private void AHFFHCDGJOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x67DD1A0", Offset = "0x67DB7A0", VA = "0x1867DD1A0")]
	[CompilerGenerated]
	private void KGPEKIIOBKJ(OPNKHHPPPLC GGEKPBNMLCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x67DBE00", Offset = "0x67DA400", VA = "0x1867DBE00")]
	[CompilerGenerated]
	private void HNFOHNBBMID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x67E1150", Offset = "0x67DF750", VA = "0x1867E1150")]
	[CompilerGenerated]
	private void PJFEEGDNALI(OPNKHHPPPLC GGEKPBNMLCN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class GKEHDNDBNEP : KFANBJCCOLL
{
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private static readonly int OANKIHHIOEF;

	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private static readonly int GJNFAHGOAPF;

	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private static readonly int JOAOLCIPJPP;

	[Cpp2IlInjected.Token(Token = "0x4000130")]
	private static readonly int PIKHAKBEKDI;

	[Cpp2IlInjected.Token(Token = "0x4000131")]
	private static readonly int MHMDBGGLNKL;

	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private static readonly int HAACGICEPBC;

	[Cpp2IlInjected.Token(Token = "0x4000133")]
	private static readonly int MPJKMEFJGEN;

	[Cpp2IlInjected.Token(Token = "0x4000134")]
	private static readonly int EJEFBAKFKAH;

	[Cpp2IlInjected.Token(Token = "0x4000135")]
	private static readonly int CAFDAHNNLLM;

	[Cpp2IlInjected.Token(Token = "0x4000136")]
	private static readonly int HHBPKNDNLCG;

	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private static readonly int BCEJJAOKHCO;

	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private static readonly int GECPBNCEDAG;

	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private static readonly int ICBDBFNOKMM;

	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private static readonly int IMGEGNACCDP;

	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private static readonly int BDCMAKJFACL;

	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private static readonly int MEOMHGJEGDB;

	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private static readonly int DNDAACBJPDP;

	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private static readonly int FCNECJHGKMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private Transform JCKNHLHIEGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private Transform JHPKNEHICJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private Transform DDNBDPOOFGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private Transform PBGEJNBDENH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private Transform DGHFGLBHBLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private Transform FBHLAJDONFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private Transform IKINBGOBALK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private ADKNAJDOOKC HLPIAFCOEPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private MaterialPropertyBlock EKNKIPDABHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private SkinnedMeshRenderer[] KMMALKIBAGI;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	private MaterialPropertyBlock FDFNMNALHBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x67D1310", Offset = "0x67CF910", VA = "0x1867D1310")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool LMMCDOJHLCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x67D2F20", Offset = "0x67D1520", VA = "0x1867D2F20", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x67D1390", Offset = "0x67CF990", VA = "0x1867D1390", Slot = "7")]
	public void BGGINNGCCML(ADKNAJDOOKC ONHKIOMDBBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x67D1660", Offset = "0x67CFC60", VA = "0x1867D1660", Slot = "8")]
	public void IDMLCEIDALK(DOCFECFMOIF EJGFFDKGCAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x67D2AF0", Offset = "0x67D10F0", VA = "0x1867D2AF0", Slot = "5")]
	public void LODIIJGINIH(CLGIBKDCNFC MAGAOIBEHJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x67D1600", Offset = "0x67CFC00", VA = "0x1867D1600")]
	private Vector2 GNGPBOLBBMN(Vector2 DCGHOCFCBDH)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x67D1690", Offset = "0x67CFC90", VA = "0x1867D1690", Slot = "6")]
	public void JEFDCCCIICK(MAEONAPIKCA EJGFFDKGCAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x67D27A0", Offset = "0x67D0DA0", VA = "0x1867D27A0")]
	private void KLHADJGFEAC(MAEONAPIKCA DKPJMJDLHCJ, NOEDMJIDDNK NDFADGMJNIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x67D14E0", Offset = "0x67CFAE0", VA = "0x1867D14E0")]
	private void DCGGBNPNHKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x67D33D0", Offset = "0x67D19D0", VA = "0x1867D33D0")]
	public GKEHDNDBNEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x67D1450", Offset = "0x67CFA50", VA = "0x1867D1450")]
	[CompilerGenerated]
	internal static (float, float) BKLGJJCPGBK(float IMHPHKNALBD)
	{
		return default((float, float));
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x67D15C0", Offset = "0x67CFBC0", VA = "0x1867D15C0")]
	[CompilerGenerated]
	internal static Vector4 FEICGNKKBCD(Vector2 MOIICCIPACK, Vector2 GNMLLHFGICG)
	{
		return default(Vector4);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class OPNKHHPPPLC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private MaterialPropertyBlock HEEOKCGAEGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	public Color? FOIFMFPPKFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	public Color? JNDOIHNFOPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	public Color? PLCFLJKNCGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	public Color? DIPBKEPIAND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	public Color JJBJEBEEFMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	public Color OMMBEDHDBGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	public Color ALKLGCOFFAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	public Texture2D KIADBBDBCIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	public Texture2D DMELJIAOCNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private Dictionary<JJDDAFLFJDM, int> FOKAPEBHHIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private MMBAOPJHELB[] BHCEDJFJIJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private GELMELABMBB[] NEALHNMJHCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	public Vector4[] FAEBGJDAOAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	public Vector4[] LKOLINILEPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	public Vector4[] CIDIHDHCDNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	public Vector4[] FOAOKCFHEKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	public Vector4[] AIBCOEDNKDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	public Vector4[] PLDDCMIMOBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	private List<Texture2D> JMFBDKDOPGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	private Vector4[] BDEBCGMOOPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private List<Texture2D> BOEAIPABIIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	private float[] PFOBEEJBEFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	private Vector4[] ABCFOCJCMPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	private float[] KFHDCHIGNAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	public float[] JOBGECPDOOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	private List<Texture2D> ADJJCMJAAFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	private float[] DAIHFAECJDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private List<Texture2D> IPDHAGOABKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private Vector4[] PLMHOKLBBOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private float[] MBCJLOOOPLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	private Vector4[] DPAOAIODPAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	public float[] GAOIKJCDFAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	public Texture2DArray KIOGFNIOELB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	public Texture2DArray OBCADMOOEOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	public Texture2DArray BNFONNJOHGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	public Texture2DArray NOAANDANPPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	private bool CIFKAOHOIJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x184")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	private int OLLLDEIIIAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private Vector2? FKFIGLJOGJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x194")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private TextureFormat ILNDNPEEHKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private Vector2? BGDMKEINHGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A4")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private TextureFormat DAMMAJGFBLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private Vector2? DJIGHADGPKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B4")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private TextureFormat LKHHOEGGCFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private Vector2? LHBOAILPABD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C4")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private TextureFormat DMLCAMLODEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private bool KIHONPKCMEM;

	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private static int BHHBDAPOJDF;

	[Cpp2IlInjected.Token(Token = "0x400017A")]
	private static int LIJEIMBLEPE;

	[Cpp2IlInjected.Token(Token = "0x400017B")]
	private static int EJFEGJHKLGF;

	[Cpp2IlInjected.Token(Token = "0x400017C")]
	private static int PBBAIPKKHIA;

	[Cpp2IlInjected.Token(Token = "0x400017D")]
	private static int NPEBAILBNMC;

	[Cpp2IlInjected.Token(Token = "0x400017E")]
	private static int LFEACGMDHFH;

	[Cpp2IlInjected.Token(Token = "0x400017F")]
	private static int HAJDCMIPCBL;

	[Cpp2IlInjected.Token(Token = "0x4000180")]
	private static int GBFAJFFIABL;

	[Cpp2IlInjected.Token(Token = "0x4000181")]
	private static int KNIENOEJAFJ;

	[Cpp2IlInjected.Token(Token = "0x4000182")]
	private static int HANFDKOLLBL;

	[Cpp2IlInjected.Token(Token = "0x4000183")]
	private static int FHNDIPHJANB;

	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private static int ABDGIEDJOCD;

	[Cpp2IlInjected.Token(Token = "0x4000185")]
	private static int KNHMBJNIBOB;

	[Cpp2IlInjected.Token(Token = "0x4000186")]
	private static int OJBHBBFJMEA;

	[Cpp2IlInjected.Token(Token = "0x4000187")]
	private static int POLKNMDBPEC;

	[Cpp2IlInjected.Token(Token = "0x4000188")]
	private static int IFDPIBEAOIK;

	[Cpp2IlInjected.Token(Token = "0x4000189")]
	private static int PLJHEDDFCHP;

	[Cpp2IlInjected.Token(Token = "0x400018A")]
	private static int BKBGCACMJAC;

	[Cpp2IlInjected.Token(Token = "0x400018B")]
	private static int DCNJMKEEDBG;

	[Cpp2IlInjected.Token(Token = "0x400018C")]
	private static int PBFJAFAGKPE;

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x67EEC90", Offset = "0x67ED290", VA = "0x1867EEC90")]
	private OPNKHHPPPLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x67EEBD0", Offset = "0x67ED1D0", VA = "0x1867EEBD0")]
	public OPNKHHPPPLC(Color JHIEOOBEFPC, Color PPGBFJHHKGJ, Color CCHMJOAFHFL, Color? LFDMBCMHLLC, Color? NAENLKBPFII, Color? NDPHMKIPNEP, Texture2D JKCKAKBIILK, Texture2D EEPADGEMJJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x67EE100", Offset = "0x67EC700", VA = "0x1867EE100")]
	internal int HAEMPMFIPFH(Material LBNEPCNOGCD, MMBAOPJHELB MMAMFDIECKL, GELMELABMBB NENEKIBFPEN, CFGFGPACPAK CNCOCPFNBNP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x67EE070", Offset = "0x67EC670", VA = "0x1867EE070")]
	private int HAEMPMFIPFH(JJDDAFLFJDM BHEIPBKEDLG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x67ED2E0", Offset = "0x67EB8E0", VA = "0x1867ED2E0")]
	internal int GEAEACKFFOP(Material LBNEPCNOGCD, Color GGNHIPEKBLP, Color FFDELLMFGAN, Color MDDCDPMKKLD, Color HGGOAPGOAEL, Color OEICKEODEEG, Texture2D FAMFHNOBIKN, Vector4 AFEJIBOHCGD, Texture2D LGOHKJBGKFP, Vector4 NACBKLKFHHJ, float NCNHBHJLHEI, float FFIGMKJECCI, Texture2D PBFPGKEJFNI, Vector4 JNAHKBPEFCI, float KELIDNBOCCO, Texture2D FOMJMPJKLBL, Color DFFDAGJEFKG, Vector4 HGFJEPNAJDG, MMBAOPJHELB MMAMFDIECKL, GELMELABMBB NENEKIBFPEN, CFGFGPACPAK CNCOCPFNBNP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x67EDEB0", Offset = "0x67EC4B0", VA = "0x1867EDEB0")]
	private void GJLCHFFDHNI(List<Texture2D> JMFBDKDOPGN, [Out] Texture2DArray GHMOKIGFFHG, [Out] Texture2DArray HNFOJMHAGLI, [Out] Texture2DArray BEJEDBAIMOA, [Out] Texture2DArray FFCJMJIKMKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x67EE3F0", Offset = "0x67EC9F0", VA = "0x1867EE3F0")]
	public void KENKMLNJCOO(Shader FCCOCAFELDO, Renderer APJGPLFHDMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x67EC550", Offset = "0x67EAB50", VA = "0x1867EC550")]
	private void BNGGLLHDFCJ(Shader FCCOCAFELDO, Renderer APJGPLFHDMA, int PMLGLBKLAEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x67EE640", Offset = "0x67ECC40", VA = "0x1867EE640")]
	private Color PGBPCBJBGPC(Color EIKIIHBPBEB, MMBAOPJHELB ADMNPLCNJPK)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x67EE2A0", Offset = "0x67EC8A0", VA = "0x1867EE2A0")]
	private Color JHCJEDCOCIG(Color GAGEKOLMNPM, MMBAOPJHELB ADMNPLCNJPK)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x67EE540", Offset = "0x67ECB40", VA = "0x1867EE540")]
	private bool LEIMCIHAICP(Texture2D IHPGLMHGFHM, GELMELABMBB DENBDPFKGHP, [Out] Texture2D IJLCGGDOBFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x67EE1F0", Offset = "0x67EC7F0", VA = "0x1867EE1F0")]
	private void HPOFKIPIBAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x67ED2A0", Offset = "0x67EB8A0", VA = "0x1867ED2A0", Slot = "4")]
	public void Dispose()
	{
	}
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public class AvatarItemMaterial : ScriptableObject, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		[Obsolete("Use CombinationId instead!")]
		[SerializeField]
		private string Guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		[SerializeField]
		private SerializedCombinationId combinationId;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		private BHFPKMDNKBO? cachedMaterialCombinationId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		[SerializeField]
		private Material material;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		[SerializeField]
		private Material[] additionalMaterials;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public ENHFLJGMKFD CombinationId
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x67E5980", Offset = "0x67E3F80", VA = "0x1867E5980")]
			get
			{
				return default(ENHFLJGMKFD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public BHFPKMDNKBO MaterialCombinationId
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x67E59D0", Offset = "0x67E3FD0", VA = "0x1867E59D0")]
			get
			{
				return default(BHFPKMDNKBO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public Material Material
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x863E50", Offset = "0x862450", VA = "0x180863E50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public Material[] AdditionalMaterials
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x868A10", Offset = "0x867010", VA = "0x180868A10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x67E57D0", Offset = "0x67E3DD0", VA = "0x1867E57D0")]
		public Material[] GKKKOCGGOMO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x67E5610", Offset = "0x67E3C10", VA = "0x1867E5610")]
		public static void DBLAPPEGIEL(AvatarItemMaterial KAIEMABEFDP, Material EGLABJPOFKK, int KLDNMGGJDFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x67E58B0", Offset = "0x67E3EB0", VA = "0x1867E58B0")]
		public AvatarItemMaterial()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[LEDNJNPECJC]
public struct PPBILJGPFHN : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	[ReadOnly]
	public OPKGMGJOBGD OLGCKPOOPDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	[ReadOnly]
	public int CDDEHJEOBHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	public MENNLKOLGBA BBFAHHBIHAE;

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x67EF180", Offset = "0x67ED780", VA = "0x1867EF180", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[LEDNJNPECJC]
[NativeContainer]
public struct MENNLKOLGBA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	public NativeArray<Vector3> JAEKADPDMHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	public NativeArray<Vector3> DPOANBHKPCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	public NativeArray<Vector4> JKIIIELNJIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	public NativeArray<Vector2> KEJKHPLGJIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	public NativeArray<Vector2> NEEMHBALCHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	public NativeArray<Vector2> JKIADIKNGJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	public NativeArray<Vector2> AMIFNMANHDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	public NativeArray<Color> MFEGDGLHHKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	public NativeArray<int> HJEHHGIJMEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	public NativeArray<int> OKELJGGKGND;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private NativeArray<int> DMDHEPNPJHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	private NativeArray<int> CHIJLMGGHIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	public NativeArray<int> EBBGBCCLOEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	public NativeArray<int> LAPPKGFEEHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	public NativeArray<int> MMHJBGBEODK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	public NativeArray<BoneWeight> BCMBODNIDKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	private NativeArray<int> LIIDINHCICD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private bool KOMPANFGFOD;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public int OMMKMGENDMH
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x67E8F90", Offset = "0x67E7590", VA = "0x1867E8F90")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x67E9150", Offset = "0x67E7750", VA = "0x1867E9150")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public int JBCNKKCCGNF
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x67E8F80", Offset = "0x67E7580", VA = "0x1867E8F80")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x67E8F70", Offset = "0x67E7570", VA = "0x1867E8F70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public int NMONCPEMHKG
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x67E8F60", Offset = "0x67E7560", VA = "0x1867E8F60")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x67E9730", Offset = "0x67E7D30", VA = "0x1867E9730")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x67E99B0", Offset = "0x67E7FB0", VA = "0x1867E99B0")]
	public MENNLKOLGBA(int OMBNHCCNPKK, int NHDHPBAIHEG, int KKFLGOEKKEP, int KJMIOMBPFPJ, Allocator IDMGOAKOEDG, int DBOKLIAHFGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x67E9770", Offset = "0x67E7D70", VA = "0x1867E9770")]
	public void LLHMDAGIEGF(int LLPJHIPCNFD, Vector3 DCMJEJAEEHK, Vector3 HPNFCDLKBEK, Vector4 LBKJPGMAINP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x67E9810", Offset = "0x67E7E10", VA = "0x1867E9810")]
	public void NPNIIDOAGFF(int LLPJHIPCNFD, BoneWeight IHDJAJLIIOF, NativeSlice<byte> ODAPPFPKOJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x67E9160", Offset = "0x67E7760", VA = "0x1867E9160")]
	public Color EPMEOKECOGH(int LLPJHIPCNFD)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x67E97E0", Offset = "0x67E7DE0", VA = "0x1867E97E0")]
	public void NLBONIANDGB(int LLPJHIPCNFD, Color DDKEAFEIAAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x67E96E0", Offset = "0x67E7CE0", VA = "0x1867E96E0")]
	public void JHFHPJIMKNE(byte AJABMBEHIJO, int LLPJHIPCNFD, Vector2 ICGFDOIKAMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x67E9800", Offset = "0x67E7E00", VA = "0x1867E9800")]
	public void NMAOGAKHJAG(int LLPJHIPCNFD, int IKLLAPMJKNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x67E9740", Offset = "0x67E7D40", VA = "0x1867E9740")]
	public bool LFGJEGHBFLE(int AJABMBEHIJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x67E9610", Offset = "0x67E7C10", VA = "0x1867E9610")]
	public void IHNELMBEEIN(int KIHHGEBKJCM, int ANNLKNNLIGI, int DOIKAIEGGLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x67E94D0", Offset = "0x67E7AD0", VA = "0x1867E94D0")]
	public int[] GGOGAFKBKPC(int KIHHGEBKJCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x67E9580", Offset = "0x67E7B80", VA = "0x1867E9580")]
	private NativeSlice<int> IFMBCFLAEPO(int KIHHGEBKJCM)
	{
		return default(NativeSlice<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x67E8FA0", Offset = "0x67E75A0", VA = "0x1867E8FA0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x67E9180", Offset = "0x67E7780", VA = "0x1867E9180")]
	public Mesh FLDAOIJMJNK([Optional] string FDMHAIDHGLE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[LEDNJNPECJC]
[NativeContainer]
[DefaultMember("Item")]
public struct OPKGMGJOBGD : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	public NativeArray<Vector3> JAEKADPDMHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	public NativeArray<Vector3> DPOANBHKPCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	public NativeArray<Vector4> JKIIIELNJIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	public NativeArray<Vector2> KEJKHPLGJIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	public NativeArray<Vector2> NEEMHBALCHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	public NativeArray<Vector2> JKIADIKNGJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	public NativeArray<Vector2> AMIFNMANHDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	public NativeArray<Color> MFEGDGLHHKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	public NativeArray<int> KNFJEIDAPPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	public NativeArray<int> FGAAFIGJFEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	public NativeArray<int> KIFEHGIGHDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	public NativeArray<int> PBIEKKEAOOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	public NativeArray<bool> NLPDLGBBIHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	public NativeArray<int> HPPGNFMPMKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	public NativeArray<int> KMPBFLCJJOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	public NativeArray<BoneWeight> CIPKIHCEGMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	private NativeArray<Matrix4x4> ODKMPLFIGNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	private NativeArray<int> MHPAKEEDPMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	private NativeArray<byte> AGLIEPBGEHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	private NativeArray<int> HDANFBFDLBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	private NativeArray<int> EAHDMNLKGMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	public NativeArray<sbyte> CPCIMPADOPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	public NativeArray<byte> IFHFJNEHNMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	private NativeArray<int> GOEKKDENBGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	private bool KOMPANFGFOD;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public int EBLCECOHDHI
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x1FE2270", Offset = "0x1FE0870", VA = "0x181FE2270")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public int MPEKNNJLCCB
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x10158A0", Offset = "0x1013EA0", VA = "0x1810158A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public int IIIMKFIPKFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x67EAAD0", Offset = "0x67E90D0", VA = "0x1867EAAD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public int FNAIGGBHFLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x67EA580", Offset = "0x67E8B80", VA = "0x1867EA580")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x67EABE0", Offset = "0x67E91E0", VA = "0x1867EABE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public int OMMKMGENDMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x67EA310", Offset = "0x67E8910", VA = "0x1867EA310")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x67EA5A0", Offset = "0x67E8BA0", VA = "0x1867EA5A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public int GGCNDDBEIIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x67EABF0", Offset = "0x67E91F0", VA = "0x1867EABF0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x67EABD0", Offset = "0x67E91D0", VA = "0x1867EABD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public LAHINCAGKJC MBAFBILDFFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x67EAC00", Offset = "0x67E9200", VA = "0x1867EAC00")]
		get
		{
			return default(LAHINCAGKJC);
		}
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x67EA590", Offset = "0x67E8B90", VA = "0x1867EA590")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public byte IHPLCGHMHNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x67EA2F0", Offset = "0x67E88F0", VA = "0x1867EA2F0")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x67EA300", Offset = "0x67E8900", VA = "0x1867EA300")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public NINLMMAKGMP PGDICMLLHEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x67EA5B0", Offset = "0x67E8BB0", VA = "0x1867EA5B0")]
		get
		{
			return default(NINLMMAKGMP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x67EAC10", Offset = "0x67E9210", VA = "0x1867EAC10")]
	public OPKGMGJOBGD(IList<Mesh> DOCBHJCMNOC, IList<Matrix4x4> OGCGAFJEFNB, IList<bool> NLPDLGBBIHC, byte EFMHDJCLHII, IList<byte[]> GOLOIFEILNM, IList<int> AIIGHENFNJL, IList<bool> HODOILLLJKB, IList<int> HPPGNFMPMKL, IList<int> PKGFLOGCBKN, IList<int> PDIAAIPEJIO, Allocator IDMGOAKOEDG, LAHINCAGKJC KKOACLOODHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x67EAB00", Offset = "0x67E9100", VA = "0x1867EAB00")]
	public MENNLKOLGBA FIIPKOMAHKM(Allocator IDMGOAKOEDG)
	{
		return default(MENNLKOLGBA);
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x67EA320", Offset = "0x67E8920", VA = "0x1867EA320", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[LEDNJNPECJC]
public class KNLFGKFAFIE : FJEOCBOAHBF
{
	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x67E8E20", Offset = "0x67E7420", VA = "0x1867E8E20")]
	public OPKGMGJOBGD FLKFPEEIEFB()
	{
		return default(OPKGMGJOBGD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x67CEB80", Offset = "0x67CD180", VA = "0x1867CEB80")]
	public KNLFGKFAFIE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public struct NINLMMAKGMP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	public NativeSlice<Vector3> JAEKADPDMHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	public NativeSlice<Vector3> DPOANBHKPCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	public NativeSlice<Vector4> JKIIIELNJIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	public NativeSlice<Vector2> KEJKHPLGJIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	public NativeSlice<Vector2> NEEMHBALCHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	public NativeSlice<Vector2> JKIADIKNGJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	public NativeSlice<Vector2> AMIFNMANHDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	public NativeSlice<Color> MFEGDGLHHKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	public NativeSlice<int> ODIBNOGPEAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	public NativeSlice<int> PBIEKKEAOOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	public NativeSlice<BoneWeight> CIPKIHCEGMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	public NativeSlice<byte> CEDABMHNJDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	public int BFLAAGIKBGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	public Matrix4x4 NHCPLPLJFNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	public int IPGLNLKGPHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	public NativeSlice<byte> ODAPPFPKOJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	public bool EIONHBFAIMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	public int NHKMOEANPCL;
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal readonly struct JJDDAFLFJDM : IEquatable<JJDDAFLFJDM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	internal readonly Material BOCAFGJDKKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	internal readonly MMBAOPJHELB LNLDBKBDKFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	internal readonly GELMELABMBB IBMHLFLEHHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	internal readonly CFGFGPACPAK LFPHNBEKBDE;

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0xA3B660", Offset = "0xA39C60", VA = "0x180A3B660")]
	public JJDDAFLFJDM(Material EGLABJPOFKK, MMBAOPJHELB MMAMFDIECKL, GELMELABMBB NENEKIBFPEN, CFGFGPACPAK CNCOCPFNBNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x67E8C00", Offset = "0x67E7200", VA = "0x1867E8C00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0xA3B240", Offset = "0xA39840", VA = "0x180A3B240", Slot = "4")]
	public bool Equals(JJDDAFLFJDM LJAAPFIIPOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x67E8A80", Offset = "0x67E7080", VA = "0x1867E8A80", Slot = "0")]
	public override bool Equals(object HBFCGFKGCAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x67E8B60", Offset = "0x67E7160", VA = "0x1867E8B60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class FOLIAPPBIIL
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private sealed class MCLHCKJGEKP : IEnumerator<MBMMHILCGCA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		private MBMMHILCGCA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		public JobHandle handle;

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		private MBMMHILCGCA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0x866510", Offset = "0x864B10", VA = "0x180866510", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x866510", Offset = "0x864B10", VA = "0x180866510", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x8683A0", Offset = "0x8669A0", VA = "0x1808683A0")]
		[DebuggerHidden]
		public MCLHCKJGEKP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0xA38B90", Offset = "0xA37190", VA = "0x180A38B90", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x67E8F10", Offset = "0x67E7510", VA = "0x1867E8F10", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350")]
	public static void EEGAEFGDIGJ(string BLCJLIJFBDL, int KEAEHEPAPAH, long CPDKGDGLOFE, long KCGFNBDMFHN, long HOEILIJPPCD, long GMJAKEKPMLH, long MBLIGIGLADA, long EDJEENIKLID, long ENCEAHCLAFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x67E73E0", Offset = "0x67E59E0", VA = "0x1867E73E0")]
	public static JMPIHICOHFM POPMILGIBIN(JobHandle AHDDBDMIJGJ, bool MCNOGAFMBGD, bool POGADALPHOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x67E7370", Offset = "0x67E5970", VA = "0x1867E7370")]
	[IteratorStateMachine(typeof(MCLHCKJGEKP))]
	private static IEnumerator<MBMMHILCGCA> ELNENPGKLHF(JobHandle JNKGLDBBIBB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public class DIJNPEECGFJ : DGIFIPCFAON, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	private FGFNPOBMNEM IKHFIMGOCHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	private JJJEKPCFLHF BJFAFMKHMFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	private IRecRoomQualityConfigProvider DJOJCNPIHHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	private bool KOMPANFGFOD;

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x67E6B70", Offset = "0x67E5170", VA = "0x1867E6B70")]
	[PECFDJPHGEK(BOIKMOKIOJG.GameOnly)]
	private static void PDECJEAEPFN(DIIANKCHAHD OMDOLEEBJJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x5B14A00", Offset = "0x5B13000", VA = "0x185B14A00")]
	[UnityEngine.Scripting.Preserve]
	public DIJNPEECGFJ([JFHFHOOOEKP(null)] JJJEKPCFLHF EIEDCFJMHID, [JFHFHOOOEKP(null)] FGFNPOBMNEM OAMDGLJKAGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x67E64A0", Offset = "0x67E4AA0", VA = "0x1867E64A0")]
	private void EJCEGJOFDKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x67E6B10", Offset = "0x67E5110", VA = "0x1867E6B10", Slot = "4")]
	public void NGDGLICFKAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x67E6650", Offset = "0x67E4C50", VA = "0x1867E6650", Slot = "5")]
	public FMHOFFFMGIN<Texture2D> KFOIPANBDJM(JLBMGMIIKLH JPBMLKLCPAJ, [Optional] LOIHFDKLGJH LIIDINHCICD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x67E6510", Offset = "0x67E4B10", VA = "0x1867E6510")]
	private uint HNCGEAKLFKO(JLBMGMIIKLH JPBMLKLCPAJ, LOIHFDKLGJH LIIDINHCICD)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public interface MKKMHKLEJAJ
{
	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DANDGJIFFLG(Mesh NKIMIKOLCFE, Matrix4x4 FCBIJCBGLKM, byte[] ODAPPFPKOJM, bool OJAFILOOFKF = false, BIMEIEHNBAC.FNGDOONFPID IJHLILAANCL = (BIMEIEHNBAC.FNGDOONFPID)0, int HPPGNFMPMKL = -1, bool NLPDLGBBIHC = false);

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LFONKKPCGPL(Allocator IDMGOAKOEDG, LAHINCAGKJC KKOACLOODHP, byte EFMHDJCLHII, [Optional] IList<int> PKGFLOGCBKN, [Optional] IList<int> FKCCHFIKNNG);
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public readonly struct IICDLNLFNKP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	public readonly GameObject DGPMDGGABNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	private readonly AvatarItemMaterial EJDGMBLOIPL;

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0xAB3FA0", Offset = "0xAB25A0", VA = "0x180AB3FA0")]
	public IICDLNLFNKP(GameObject DGPMDGGABNO, AvatarItemMaterial EJDGMBLOIPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x67E84C0", Offset = "0x67E6AC0", VA = "0x1867E84C0")]
	public void MGIDIHABAEE(Material EGLABJPOFKK, int KLDNMGGJDFC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class DPAMIINLOFL : NAEBCHGCLLJ<Task<(GameObject, AvatarItemMaterial)>, IICDLNLFNKP>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private struct BLJAIAMDKKJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		public AsyncTaskMethodBuilder<(GameObject, AvatarItemMaterial)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		public Task<GameObject> goTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		public Task<AvatarItemMaterial> materialTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		private GameObject <go>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		private TaskAwaiter<GameObject> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		private TaskAwaiter<AvatarItemMaterial> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x67E5A90", Offset = "0x67E4090", VA = "0x1867E5A90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x67E5F90", Offset = "0x67E4590", VA = "0x1867E5F90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	private FMHOFFFMGIN<GameObject> HPAIJDOJNEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	private FMHOFFFMGIN<AvatarItemMaterial> MCGIANGHJBP;

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x67E72E0", Offset = "0x67E58E0", VA = "0x1867E72E0")]
	private DPAMIINLOFL(Task<(GameObject, AvatarItemMaterial)> PEBIPFJADEI, FMHOFFFMGIN<GameObject> PKFKBBEKJBJ, FMHOFFFMGIN<AvatarItemMaterial> DEJMDOGNHAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x67E6CF0", Offset = "0x67E52F0", VA = "0x1867E6CF0")]
	public static DPAMIINLOFL GIGNPOIHFIA(AssetReference EGJKLBIJOOJ, [Optional] AssetReference ODNGAOHOGEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x67E7240", Offset = "0x67E5840", VA = "0x1867E7240", Slot = "11")]
	protected override IICDLNLFNKP NAOBMEPDGHG(Task<(GameObject, AvatarItemMaterial)> MAELDPCECFD)
	{
		return default(IICDLNLFNKP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x67E6C70", Offset = "0x67E5270", VA = "0x1867E6C70", Slot = "12")]
	protected override void DNKELGKLJFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x67E7110", Offset = "0x67E5710", VA = "0x1867E7110")]
	[AsyncStateMachine(typeof(BLJAIAMDKKJ))]
	private static Task<(GameObject, AvatarItemMaterial)> MDJGAAAOKBA(Task<GameObject> LLEPDBNBPMF, Task<AvatarItemMaterial> MHAOOOANCIO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class HKOEPOCPFMO
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	private class OAIODCBIFAP : NAEBCHGCLLJ<Task<MaterialMapAsset>, Material[]>
	{
		[Cpp2IlInjected.Token(Token = "0x2000040")]
		[CompilerGenerated]
		private sealed class CKBGOEIAGEF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001F1")]
			public MaterialEntry entry;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001F2")]
			public string shaderNameToFind;

			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
			public CKBGOEIAGEF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0x67E6000", Offset = "0x67E4600", VA = "0x1867E6000")]
			internal object HJMPFCOONGF()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x67E6250", Offset = "0x67E4850", VA = "0x1867E6250")]
			internal object JANPOMBIECN()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		private FMHOFFFMGIN<MaterialMapAsset> JNKGLDBBIBB;

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x67EA210", Offset = "0x67E8810", VA = "0x1867EA210")]
		public OAIODCBIFAP(FMHOFFFMGIN<MaterialMapAsset> JNKGLDBBIBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x67EA120", Offset = "0x67E8720", VA = "0x1867EA120", Slot = "11")]
		protected override Material[] NAOBMEPDGHG(Task<MaterialMapAsset> PEBIPFJADEI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x67EA0C0", Offset = "0x67E86C0", VA = "0x1867EA0C0", Slot = "12")]
		protected override void DNKELGKLJFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x67E9DF0", Offset = "0x67E83F0", VA = "0x1867E9DF0")]
		private Material ACCFODFGECB(MaterialEntry NJHLAOJOAAM)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	private class HFLOAAJAOKM : NAEBCHGCLLJ<Task<Material[]>, Material[]>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		private List<FMHOFFFMGIN<Material>> PJJDBOLIJLO;

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x67E7FA0", Offset = "0x67E65A0", VA = "0x1867E7FA0")]
		public HFLOAAJAOKM(Task<Material[]> PEBIPFJADEI, List<FMHOFFFMGIN<Material>> PJJDBOLIJLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x67E7F50", Offset = "0x67E6550", VA = "0x1867E7F50", Slot = "11")]
		protected override Material[] NAOBMEPDGHG(Task<Material[]> MAELDPCECFD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x67E7E10", Offset = "0x67E6410", VA = "0x1867E7E10", Slot = "12")]
		protected override void DNKELGKLJFP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	private static readonly ICJNMGNJFIN CAJBNIGHKAB;

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x67E8010", Offset = "0x67E6610", VA = "0x1867E8010")]
	public static FMHOFFFMGIN<Material[]> HCKNNHCLCAE(AssetReference[] FJLJHLHKHAC)
	{
		return null;
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public class SkinnedMeshBonesInspector : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		[AIILLFBIOKD(CKKEEFADMDD.Self, false, false, false)]
		[SerializeField]
		private SkinnedMeshRenderer skinnedMeshRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		[SerializeField]
		private int BoneWeightsDisplayStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		[SerializeField]
		private int BoneWeightsDisplayAmount;

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x67F0090", Offset = "0x67EE690", VA = "0x1867F0090")]
		public SkinnedMeshBonesInspector()
		{
		}
	}
}
namespace RecRoom.Avatars.Face
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public sealed class FaceStyleSet : ScriptableObject
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000045")]
		[CompilerGenerated]
		private struct JFKJGDFKBLN : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000206")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000207")]
			public AsyncTaskMethodBuilder<FLPGAIHAKKN> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000208")]
			public FaceStyleSet <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000209")]
			public int eyeBrows;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x400020A")]
			public int eye;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400020B")]
			public int mouth;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400020C")]
			private TaskAwaiter<FLPGAIHAKKN> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x67E86D0", Offset = "0x67E6CD0", VA = "0x1867E86D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x67E8A10", Offset = "0x67E7010", VA = "0x1867E8A10", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		public SymmetricalFaceFeature[] EyeBrows;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		public EyesFaceFeature[] Eyes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		public NoseFaceOption[] Noses;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		public FaceFeature[] Mouths;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		[Header("Default Values")]
		public SymmetricalFaceFeature DefaultEyeBrowsFeature;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		public EyesFaceFeature DefaultEyesFeature;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		public FaceFeature DefaultMouthFeature;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		private Dictionary<DONNKKJBKEB, SymmetricalFaceFeature> eyeBrowFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		private Dictionary<DONNKKJBKEB, EyesFaceFeature> eyeFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		private Dictionary<DONNKKJBKEB, NoseFaceOption> noseOptionsDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		private Dictionary<DONNKKJBKEB, FaceFeature> mouthFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		private readonly Dictionary<DONNKKJBKEB, int> featureToIndexMap;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		private FLPGAIHAKKN _defaultFaceStyle;

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		private bool dictionariesInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x67E7DE0", Offset = "0x67E63E0", VA = "0x1867E7DE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x67E7B50", Offset = "0x67E6150", VA = "0x1867E7B50")]
		public FLPGAIHAKKN MKFDNIMNEHB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x67E7BA0", Offset = "0x67E61A0", VA = "0x1867E7BA0")]
		[AsyncStateMachine(typeof(JFKJGDFKBLN))]
		public Task<FLPGAIHAKKN> NLFLDGCMPMB(int LDGGMLGGDPB, int IMFCOMGBCPB, int BBGLNIGMGED)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x67E7AB0", Offset = "0x67E60B0", VA = "0x1867E7AB0")]
		public NoseFaceOption MGDLCKJFBDL(int GHHHOBGMPCM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x67E7530", Offset = "0x67E5B30", VA = "0x1867E7530")]
		public SelectableFaceOption EGGPAHCJEBL(FaceFeatureType NIFKLDNIBPI, DONNKKJBKEB GDKGGKJFLIO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x67E7CD0", Offset = "0x67E62D0", VA = "0x1867E7CD0")]
		public int PGPLBMGPLAM(DONNKKJBKEB GDKGGKJFLIO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x67E7880", Offset = "0x67E5E80", VA = "0x1867E7880")]
		private void IMEJFICHPJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x2AF8F60", Offset = "0x2AF7560", VA = "0x182AF8F60")]
		private void JNIJOLFGHIA<T>(IDictionary<DONNKKJBKEB, T> OLGJECBHAKN, IReadOnlyList<T> HBMOMJIDJED) where T : SelectableFaceOption
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x67E76B0", Offset = "0x67E5CB0", VA = "0x1867E76B0")]
		public DONNKKJBKEB FNFAOKJFPNE(FaceFeatureType NIFKLDNIBPI)
		{
			return default(DONNKKJBKEB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x67E7760", Offset = "0x67E5D60", VA = "0x1867E7760")]
		public DONNKKJBKEB GIOLIOMAHPJ(FaceFeatureType NIFKLDNIBPI)
		{
			return default(DONNKKJBKEB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x67E7D50", Offset = "0x67E6350", VA = "0x1867E7D50")]
		public FaceStyleSet()
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
