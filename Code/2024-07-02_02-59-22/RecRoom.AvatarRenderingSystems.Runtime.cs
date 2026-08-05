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
using Unity.Profiling;
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
		[Cpp2IlInjected.Address(RVA = "0x6804CC0", Offset = "0x6803CC0", VA = "0x186804CC0", Slot = "4")]
		public override void PIKNDMFIIPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x88F9F0", Offset = "0x88E9F0", VA = "0x18088F9F0")]
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
			[Cpp2IlInjected.Address(RVA = "0x870C70", Offset = "0x86FC70", VA = "0x180870C70", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override string AssetGUID
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x6814A20", Offset = "0x6813A20", VA = "0x186814A20", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6814950", Offset = "0x6813950", VA = "0x186814950", Slot = "17")]
		public override bool RuntimeKeyIsValid()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x68149E0", Offset = "0x68139E0", VA = "0x1868149E0")]
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
			[Cpp2IlInjected.Address(RVA = "0x8687D0", Offset = "0x8677D0", VA = "0x1808687D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x867E00", Offset = "0x866E00", VA = "0x180867E00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public string CacheHash
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x869520", Offset = "0x868520", VA = "0x180869520")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x869500", Offset = "0x868500", VA = "0x180869500")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6814A60", Offset = "0x6813A60", VA = "0x186814A60")]
		public static RecNetCDNKey FGPCAHEBMEP(string NGDAIGBOBFP, string IEBPPBJMBGP = "")
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x60119E0", Offset = "0x60109E0", VA = "0x1860119E0")]
		public void LOLKJDGFLJJ(string LAPNLHJCMCI, string HBFGLPMFMGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6814B60", Offset = "0x6813B60", VA = "0x186814B60")]
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
	[Cpp2IlInjected.Address(RVA = "0x6800650", Offset = "0x67FF650", VA = "0x186800650", Slot = "4")]
	public void DANDGJIFFLG(Mesh NKIMIKOLCFE, Matrix4x4 FCBIJCBGLKM, byte[] ODAPPFPKOJM, bool OJAFILOOFKF = false, BIMEIEHNBAC.FNGDOONFPID IJHLILAANCL = (BIMEIEHNBAC.FNGDOONFPID)0, int HPPGNFMPMKL = -1, bool NLPDLGBBIHC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6800AB0", Offset = "0x67FFAB0", VA = "0x186800AB0", Slot = "5")]
	public void LFONKKPCGPL(Allocator IDMGOAKOEDG, LAHINCAGKJC KKOACLOODHP, byte EFMHDJCLHII, [Optional] IList<int> PKGFLOGCBKN, [Optional] IList<int> FKCCHFIKNNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6800860", Offset = "0x67FF860", VA = "0x186800860")]
	private static void IPJKODAMJAF(Mesh NKIMIKOLCFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6800AF0", Offset = "0x67FFAF0", VA = "0x186800AF0")]
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
	[Cpp2IlInjected.Address(RVA = "0x67FCB30", Offset = "0x67FBB30", VA = "0x1867FCB30", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x6811AC0", Offset = "0x6810AC0", VA = "0x186811AC0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6811D30", Offset = "0x6810D30", VA = "0x186811D30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int JBCNKKCCGNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6811AB0", Offset = "0x6810AB0", VA = "0x186811AB0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6811AA0", Offset = "0x6810AA0", VA = "0x186811AA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int NMONCPEMHKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6811A90", Offset = "0x6810A90", VA = "0x186811A90")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6813430", Offset = "0x6812430", VA = "0x186813430")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int KALCIMJDOIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6811A20", Offset = "0x6810A20", VA = "0x186811A20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6813D70", Offset = "0x6812D70", VA = "0x186813D70")]
	public PCKLALGKHBE(int OMBNHCCNPKK, int NHDHPBAIHEG, int KKFLGOEKKEP, int KJMIOMBPFPJ, Allocator IDMGOAKOEDG, int DBOKLIAHFGN, EPJPFJPNPID GKBHGMIOCMC, bool CEHKKNPIMIB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x68134A0", Offset = "0x68124A0", VA = "0x1868134A0")]
	public void LLHMDAGIEGF(int LLPJHIPCNFD, Vector3 DCMJEJAEEHK, Vector3 HPNFCDLKBEK, Vector4 LBKJPGMAINP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6813940", Offset = "0x6812940", VA = "0x186813940")]
	public void NPNIIDOAGFF(int LLPJHIPCNFD, BoneWeight IHDJAJLIIOF, NativeSlice<byte> ODAPPFPKOJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6811D40", Offset = "0x6810D40", VA = "0x186811D40")]
	public Color EPMEOKECOGH(int LLPJHIPCNFD)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6813530", Offset = "0x6812530", VA = "0x186813530")]
	public void NLBONIANDGB(int LLPJHIPCNFD, Color DDKEAFEIAAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6813080", Offset = "0x6812080", VA = "0x186813080")]
	public void JHFHPJIMKNE(byte AJABMBEHIJO, int LLPJHIPCNFD, Vector2 ICGFDOIKAMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6813930", Offset = "0x6812930", VA = "0x186813930")]
	public void NMAOGAKHJAG(int LLPJHIPCNFD, int IKLLAPMJKNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6813440", Offset = "0x6812440", VA = "0x186813440")]
	public bool LFGJEGHBFLE(int AJABMBEHIJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6812FB0", Offset = "0x6811FB0", VA = "0x186812FB0")]
	public void IHNELMBEEIN(int KIHHGEBKJCM, int ANNLKNNLIGI, int DOIKAIEGGLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6811AD0", Offset = "0x6810AD0", VA = "0x186811AD0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6812070", Offset = "0x6811070", VA = "0x186812070")]
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
		[Cpp2IlInjected.Address(RVA = "0x67FEFD0", Offset = "0x67FDFD0", VA = "0x1867FEFD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int MPEKNNJLCCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x67FF330", Offset = "0x67FE330", VA = "0x1867FF330")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int IIIMKFIPKFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x67FF260", Offset = "0x67FE260", VA = "0x1867FF260")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int FNAIGGBHFLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x67FEFE0", Offset = "0x67FDFE0", VA = "0x1867FEFE0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x67FF420", Offset = "0x67FE420", VA = "0x1867FF420")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int OMMKMGENDMH
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x67FEE50", Offset = "0x67FDE50", VA = "0x1867FEE50")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x67FF000", Offset = "0x67FE000", VA = "0x1867FF000")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int GGCNDDBEIIC
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x67FF430", Offset = "0x67FE430", VA = "0x1867FF430")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x67FF410", Offset = "0x67FE410", VA = "0x1867FF410")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public LAHINCAGKJC MBAFBILDFFB
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x67FF440", Offset = "0x67FE440", VA = "0x1867FF440")]
		get
		{
			return default(LAHINCAGKJC);
		}
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x67FEFF0", Offset = "0x67FDFF0", VA = "0x1867FEFF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public byte IHPLCGHMHNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x67FEE30", Offset = "0x67FDE30", VA = "0x1867FEE30")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x67FEE40", Offset = "0x67FDE40", VA = "0x1867FEE40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public FDKMEADOAEE PGDICMLLHEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x67FF010", Offset = "0x67FE010", VA = "0x1867FF010")]
		get
		{
			return default(FDKMEADOAEE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x67FF450", Offset = "0x67FE450", VA = "0x1867FF450")]
	public EDHGMIDNGDF(IList<Mesh> DOCBHJCMNOC, IList<Matrix4x4> OGCGAFJEFNB, IList<bool> NLPDLGBBIHC, byte EFMHDJCLHII, IList<byte[]> GOLOIFEILNM, IList<int> AIIGHENFNJL, IList<bool> HODOILLLJKB, IList<int> HPPGNFMPMKL, IList<int> PKGFLOGCBKN, IList<int> PDIAAIPEJIO, Allocator IDMGOAKOEDG, LAHINCAGKJC KKOACLOODHP, bool CEHKKNPIMIB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x67FF340", Offset = "0x67FE340", VA = "0x1867FF340")]
	public PCKLALGKHBE FIIPKOMAHKM(Allocator IDMGOAKOEDG, EPJPFJPNPID GKBHGMIOCMC)
	{
		return default(PCKLALGKHBE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x67FEE60", Offset = "0x67FDE60", VA = "0x1867FEE60", Slot = "4")]
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

	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private static readonly ProfilerMarker NKFPPCEGLKO;

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x67FE5E0", Offset = "0x67FD5E0", VA = "0x1867FE5E0")]
	public EDHGMIDNGDF FLKFPEEIEFB()
	{
		return default(EDHGMIDNGDF);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x67FE8A0", Offset = "0x67FD8A0", VA = "0x1867FE8A0")]
	public AOJAGLEIPHI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct FDKMEADOAEE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public Mesh.MeshData CPKKHLEBOBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public NativeSlice<BoneWeight> CIPKIHCEGMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public NativeSlice<byte> CEDABMHNJDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public int BFLAAGIKBGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public Matrix4x4 NHCPLPLJFNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public int IPGLNLKGPHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public NativeSlice<byte> ODAPPFPKOJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public bool EIONHBFAIMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public int NHKMOEANPCL;
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class OBBNDEFFAJC : IIPFAIHICNK
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	private abstract class FOFKAMHNHMK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public readonly CFGFGPACPAK GECIJEJJCEL;

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public virtual bool BLIENMEMHNG
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x8ADFC0", Offset = "0x8ACFC0", VA = "0x1808ADFC0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public virtual bool HNCDFKJJCIM
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x8ADFC0", Offset = "0x8ACFC0", VA = "0x1808ADFC0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public virtual BIMEIEHNBAC.FNGDOONFPID IPGLNLKGPHL
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x866360", Offset = "0x865360", VA = "0x180866360", Slot = "6")]
			get
			{
				return default(BIMEIEHNBAC.FNGDOONFPID);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public bool FJLPOEHOLHC
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x14CE140", Offset = "0x14CD140", VA = "0x1814CE140")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public bool GJABJGHHHKG
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x6800D20", Offset = "0x67FFD20", VA = "0x186800D20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool EKDCFOICDOP
		{
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x6800D30", Offset = "0x67FFD30", VA = "0x186800D30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x86B3A0", Offset = "0x86A3A0", VA = "0x18086B3A0")]
		protected FOFKAMHNHMK(CFGFGPACPAK OKPGPAIFCEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract PGILFKJEHOF GPNKEEJAKHA(int[] BFNICCKIHCO, List<EGGKBNFDHIC> GMDNNGIEGKF, List<EGGKBNFDHIC> CKCNBFJHHAE);

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
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
			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			public FMHOFFFMGIN<GameObject> skinAvatarItemPrefabHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			public GKPLKANOOCB <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
			public DJFDFDGHBII()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x67FEA40", Offset = "0x67FDA40", VA = "0x1867FEA40")]
			internal void JAEFJLCPHMK(GameObject result)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private readonly AvatarSkinAssetItem.LKNLOHCAKLI CFAOIMMJMHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private readonly AssetReference FMBGBLCAIDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private readonly BIMEIEHNBAC.FNGDOONFPID FMGJAAOJKPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private readonly DONNKKJBKEB? OHACGFMGGHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private readonly Material[] AAFKBNEFFEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private SkinnedMeshRenderer[] ENEJONKLBGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private AvatarSkinAssetItem IBBKJAEMOIA;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override BIMEIEHNBAC.FNGDOONFPID IPGLNLKGPHL
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x868830", Offset = "0x867830", VA = "0x180868830", Slot = "6")]
			get
			{
				return default(BIMEIEHNBAC.FNGDOONFPID);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x68035F0", Offset = "0x68025F0", VA = "0x1868035F0")]
		public GKPLKANOOCB(AvatarSkinAssetItem.LKNLOHCAKLI ELHIFKELGNM, AssetReference IOICAJEBIBI, Material LMHAFOANHGI, CFGFGPACPAK CNCOCPFNBNP, BIMEIEHNBAC.FNGDOONFPID AFPLHBFNDBM = (BIMEIEHNBAC.FNGDOONFPID)0, [Optional] DONNKKJBKEB? PPJFJMIHIKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x6803700", Offset = "0x6802700", VA = "0x186803700")]
		public GKPLKANOOCB(AvatarSkinAssetItem.LKNLOHCAKLI ELHIFKELGNM, AssetReference IOICAJEBIBI, Material LMHAFOANHGI, BIMEIEHNBAC.FNGDOONFPID AFPLHBFNDBM = (BIMEIEHNBAC.FNGDOONFPID)0, [Optional] DONNKKJBKEB? PPJFJMIHIKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x68030D0", Offset = "0x68020D0", VA = "0x1868030D0", Slot = "7")]
		public override PGILFKJEHOF GPNKEEJAKHA(int[] BFNICCKIHCO, List<EGGKBNFDHIC> GMDNNGIEGKF, List<EGGKBNFDHIC> CKCNBFJHHAE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x68032A0", Offset = "0x68022A0", VA = "0x1868032A0", Slot = "8")]
		public override BKEHEBPKJOE KHMGPBKEGLP(uint KEAEHEPAPAH, AvatarSkinnedMeshBoneOrderRemapsData BEHPILIPAPM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x6803580", Offset = "0x6802580", VA = "0x186803580", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	private class LEBDDNMMEGE : FOFKAMHNHMK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public readonly MIMKMAGJOLD CKOPMFHINIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private FMHOFFFMGIN<IICDLNLFNKP> DEEBNPOKNLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public IICDLNLFNKP AOFHDALDAKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		private FMHOFFFMGIN<Material[]> NLHNOMIPNFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public List<Material> EAJFFLMADML;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public override bool BLIENMEMHNG
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x880530", Offset = "0x87F530", VA = "0x180880530", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public override bool HNCDFKJJCIM
		{
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x6803C50", Offset = "0x6802C50", VA = "0x186803C50", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x1D41E70", Offset = "0x1D40E70", VA = "0x181D41E70")]
		public LEBDDNMMEGE(CFGFGPACPAK OKPGPAIFCEO, MIMKMAGJOLD DMEBHMGFAOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x6804020", Offset = "0x6803020", VA = "0x186804020", Slot = "7")]
		public override PGILFKJEHOF GPNKEEJAKHA(int[] BFNICCKIHCO, List<EGGKBNFDHIC> GMDNNGIEGKF, List<EGGKBNFDHIC> CKCNBFJHHAE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x6804560", Offset = "0x6803560", VA = "0x186804560", Slot = "8")]
		public override BKEHEBPKJOE KHMGPBKEGLP(uint KEAEHEPAPAH, AvatarSkinnedMeshBoneOrderRemapsData BEHPILIPAPM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x6804690", Offset = "0x6803690", VA = "0x186804690")]
		public BKEHEBPKJOE OFNDLDOIPJD(GameObject DGPMDGGABNO, uint KEAEHEPAPAH, bool BCPIJJBCKPM, bool AKPNBDBMIEN, AvatarSkinnedMeshBoneOrderRemapsData BEHPILIPAPM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x6803CB0", Offset = "0x6802CB0", VA = "0x186803CB0")]
		public static bool GDNNHCHACCA(Renderer[] DMHJBBCAABP, string EPLPEFHHKPH, [Out] Renderer OIHCDHCDINE, [Out] Renderer PIJDAKDFCNB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x6804880", Offset = "0x6803880", VA = "0x186804880", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x6803B80", Offset = "0x6802B80", VA = "0x186803B80")]
		private (FMHOFFFMGIN<IICDLNLFNKP>, FMHOFFFMGIN<Material[]>) ECEDHKOJFOE()
		{
			return default((FMHOFFFMGIN<IICDLNLFNKP>, FMHOFFFMGIN<Material[]>));
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x4317A60", Offset = "0x4316A60", VA = "0x184317A60")]
		[CompilerGenerated]
		private void MCMIABPMJHM(IICDLNLFNKP HJBJAPKPPFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x6804500", Offset = "0x6803500", VA = "0x186804500")]
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
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public OBBNDEFFAJC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public PGGFJFHOMCP buildMeshPromise;

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
		public POKIEBFLPIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x6814880", Offset = "0x6813880", VA = "0x186814880")]
		internal void FNEOJONCPIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x68148A0", Offset = "0x68138A0", VA = "0x1868148A0")]
		internal void FPJMOKCMAPG(string err)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x68147F0", Offset = "0x68137F0", VA = "0x1868147F0")]
		internal void BPNNGPBBJJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x68148C0", Offset = "0x68138C0", VA = "0x1868148C0")]
		internal void ONGBAEAKFDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x869510", Offset = "0x868510", VA = "0x180869510")]
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
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public int lowestPossibleLOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public POKIEBFLPIE CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
		public BMGEEPDBLPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x67FE8B0", Offset = "0x67FD8B0", VA = "0x1867FE8B0")]
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
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public List<PGGFJFHOMCP> innerPromises;

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
		public JGLOFLBIBOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x6803A50", Offset = "0x6802A50", VA = "0x186803A50")]
		internal void KKJGGPKLGAP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class GENENPNAMAF : IEnumerator<MBMMHILCGCA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private MBMMHILCGCA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public OBBNDEFFAJC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public List<FOFKAMHNHMK> parts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public int[] LODs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public List<PGGFJFHOMCP> innerPromises;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public bool isFirstPerson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public Func<int, MDKHCAHBNED> getLayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public OPNKHHPPPLC materialPropertyBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public Material materialInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private int <lodIndex>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		private MBMMHILCGCA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x869510", Offset = "0x868510", VA = "0x180869510", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x869510", Offset = "0x868510", VA = "0x180869510", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x86B3A0", Offset = "0x86A3A0", VA = "0x18086B3A0")]
		[DebuggerHidden]
		public GENENPNAMAF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x6800D50", Offset = "0x67FFD50", VA = "0x186800D50", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x6800F60", Offset = "0x67FFF60", VA = "0x186800F60", Slot = "8")]
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
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public int[] LODs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public OBBNDEFFAJC <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
		public PIDIDAGBKMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x68147A0", Offset = "0x68137A0", VA = "0x1868147A0")]
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
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public MBKHDHMPHNH cancelable;

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
		public MIIKBBAJNEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x984B70", Offset = "0x983B70", VA = "0x180984B70")]
		internal void AHJAFHDOPBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0xA43940", Offset = "0xA42940", VA = "0x180A43940")]
		internal void LOKOIHPCCCO(string err)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class HADOCEDFGLD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public long jobComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public Stopwatch stopwatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public SkinnedMeshRenderer lodRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public long meshComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public string meshName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public long meshCopyComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public OBBNDEFFAJC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public int lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public List<Material> newUniqueMaterials;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public int frameStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public long lodBuildStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public long startCombineBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public long jobScheduled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public Action onFinally;

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
		public HADOCEDFGLD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class HKDIFGPHHHN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public bool waitingForComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public JobHandle lodBuildJobHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public PCKLALGKHBE defaultMeshJobContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public EDHGMIDNGDF defaultAvatarMeshJobGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public HADOCEDFGLD CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
		public HKDIFGPHHHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x6803810", Offset = "0x6802810", VA = "0x186803810")]
		internal void KGEDGJDINDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0xA3C6F0", Offset = "0xA3B6F0", VA = "0x180A3C6F0")]
		internal void IPJEONJOHOK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class ACMGOOLNABL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public bool waitingForComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public JobHandle lodBuildJobHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public MENNLKOLGBA legacyMeshJobContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public OPKGMGJOBGD legacyAvatarMeshJobGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public HADOCEDFGLD CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
		public ACMGOOLNABL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x67FC8F0", Offset = "0x67FB8F0", VA = "0x1867FC8F0")]
		internal void EMIEHFPCMEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0xA43690", Offset = "0xA42690", VA = "0x180A43690")]
		internal void MPEKBMAIKEA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private sealed class LEHPLMNKLJL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public MBKHDHMPHNH cancelablePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public MIMKMAGJOLD avatarItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public OBBNDEFFAJC <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
		public LEHPLMNKLJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x68048D0", Offset = "0x68038D0", VA = "0x1868048D0")]
		internal PGILFKJEHOF EFOOKLONKBK(JLBMGMIIKLH item)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x6804C80", Offset = "0x6803C80", VA = "0x186804C80")]
		internal void MBIANFHPMHK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class CMLBCGGBBIE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		public FMHOFFFMGIN<Texture2D> resourceHandle;

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
		public CMLBCGGBBIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x67FE9F0", Offset = "0x67FD9F0", VA = "0x1867FE9F0")]
		internal void DPIGHOJOLBB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class CFGJOLOCLGG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		public string overrideItemIdentifier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public CFGFGPACPAK overrideBodyPart;

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
		public CFGJOLOCLGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x67FE970", Offset = "0x67FD970", VA = "0x1867FE970")]
		internal bool CEOLKFLDJIL(KeyValuePair<string, MIMKMAGJOLD> entry)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private AvatarConfiguration DBDFBBOBJHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private Transform HBDDLFJCMCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private AssetReference FMBGBLCAIDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private GameObject EEKMEIPKCOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private GameObject AFCMFFFFGGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private SkinnedMeshRenderer JPCPFIGHCJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private AvatarSkinnedMeshBoneOrderRemapsData CDFEONHBODL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private Transform[] HDFDPCKBFPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private Matrix4x4[] OIHFFFBMKDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private Material CNNMBFJELLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private Material EHLPLJADDJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private Material LLKCADFDGKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private Shader IBFNDAJKEAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private Shader GAGPPPDKIHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private Animator LOEJJGILMIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private Renderer[] HJJGJIEHPJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private BIMEIEHNBAC.FNGDOONFPID NPEPABJOEIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private AvatarBodyPartShapesManager AOLKJJCBKNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private IReadOnlyDictionary<string, Transform> GGCDJAGIDKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private AvatarFaceShapeData.EFAMHAMMOFD BECIEGAOCIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private AvatarBodyShapeData.MEJAHDBKBGF DEMJGAKMBHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private bool BDFBBINAKOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB1")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private bool OIIMEDLOFFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private Color KBFIDPBDMDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private Color EJAGIHEBBJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private Color AHGMIGAAIFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private Color? BLNGCEDPBNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private Color? DGDJJBBKMGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10C")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private Color? HDDBJPGIKBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private Color? OJLHLPLFMID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private Texture2D JDNLHNLBHHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private Texture2D JNGJOANPPEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	[CanBeNull]
	private MIMKMAGJOLD ONGGGAPLMCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private Texture GPNBCBMBHHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private Color BMLHCNCBGMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public Dictionary<Renderer, OPNKHHPPPLC> NFOHJEIFMDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private Dictionary<Renderer, OPNKHHPPPLC> NCHDANICLBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private Dictionary<string, List<JJDDAFLFJDM>> PAFBFCJGKGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private Dictionary<string, List<JJDDAFLFJDM>> PMFHNIHIPNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private readonly List<EGGKBNFDHIC> BCFAMJALOMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private readonly List<EGGKBNFDHIC> INDBGIFMMNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly List<EGGKBNFDHIC> GEEBIPIFIKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private readonly List<EGGKBNFDHIC> OOMKHNFMPNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private Dictionary<JJDDAFLFJDM, Material> PHPECINPCBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private Dictionary<JJDDAFLFJDM, Material> DGKHBDJOKEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private SkinnedMeshRenderer[] BEMPKKPMPKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private SkinnedMeshRenderer[] OGDEIFDMLHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private SkinnedMeshRenderer[] DNIJGMGFNKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private SkinnedMeshRenderer[] PEPNCBMOMEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private readonly Dictionary<string, FMHOFFFMGIN<Texture2D>> AOCIJHACDGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private readonly Dictionary<string, FMHOFFFMGIN<Texture2D>> CFLLGGMPKMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private FitMeshHemisphere GLHFDIKIJAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private bool CCNKFAJOOMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private MPNIGMOKBGH NPODIKEHINJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private bool NJNGICGMLHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private AnchorParamsRestrictions CFOLMJAAHGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private bool EBFNNEMJCDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private Transform KDKEGAKFKJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private Transform BGEMMLJIGGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private bool ICBCLJNCNLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x229")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private bool OHGDEIGMGLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x22C")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private Vector3 HGLKKHKNGHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private Quaternion ADIEHJBCJEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private Vector2 LGMGNCJLMAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private FitMeshHemisphere PANPLGMJHAD;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private Material FGBNIFMNPLC;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private Material KPFELLJEJFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private Dictionary<string, MIMKMAGJOLD> IFNNBBHHMKO;

	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private static readonly int NHMKLIBBMDF;

	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private static readonly int KPKPHCFOCGE;

	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private static readonly int NKKNKAOBIFM;

	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private static readonly int GCOMONLDFAN;

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private static readonly int ONHOLNGKMOJ;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private static readonly int GLECGCDGJEJ;

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private static readonly int JHKGBNNMKFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private readonly BGECMLEGDCD KBDOMIEIGGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private readonly BGECMLEGDCD DEICJBLEFDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private bool CHMCMMKMKKG;

	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private static Lazy<IMFFKMNFHIF> BGEOFNKLPEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private Lazy<DPJMDPCIDPO> KBKBHEAMEFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private Lazy<DGIFIPCFAON> PNEMKPOIKOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private KKBDEFJOIBO INBNEPBAMHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private BOAANLGFGMH HOHNNDDLLMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private List<Action> EDDKLONNGCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B0")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private LOIHFDKLGJH GODOKKEDJOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B8")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private SkinnedMeshRenderer[] FOPMOEDJOAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C0")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private int NJEMNCLPKGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C4")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private bool CBODNIDHIPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private int LAFNKHFJHEN;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool NLAOLHLKGKC
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x1915990", Offset = "0x1914990", VA = "0x181915990")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x1904820", Offset = "0x1903820", VA = "0x181904820")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool GMOCGAKGPOG
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x680BDE0", Offset = "0x680ADE0", VA = "0x18680BDE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private Material DOFKEJHKDPO
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x680B300", Offset = "0x680A300", VA = "0x18680B300")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private Material JJIDBJCPPMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x680CB60", Offset = "0x680BB60", VA = "0x18680CB60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	private bool POGADALPHOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x880530", Offset = "0x87F530", VA = "0x180880530")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public PKLKNBHIDDA MIBAHGEAALD
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8E71D0", Offset = "0x8E61D0", VA = "0x1808E71D0", Slot = "21")]
		get
		{
			return default(PKLKNBHIDDA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	private bool AHDCJMMCMCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x680B820", Offset = "0x680A820", VA = "0x18680B820")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private static IMFFKMNFHIF EMPPEOIJCEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6810D80", Offset = "0x680FD80", VA = "0x186810D80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	private DPJMDPCIDPO BHNBOINNCKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x68050C0", Offset = "0x68040C0", VA = "0x1868050C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	private DGIFIPCFAON DMNBKAEIMBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x680F4F0", Offset = "0x680E4F0", VA = "0x18680F4F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	private KKBDEFJOIBO LJADODFIPFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x680C5D0", Offset = "0x680B5D0", VA = "0x18680C5D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	private BOAANLGFGMH AIDMJLFPAII
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x680D0E0", Offset = "0x680C0E0", VA = "0x18680D0E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public BGECMLEGDCD BKMNFFDBPGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0xA1C1E0", Offset = "0xA1B1E0", VA = "0x180A1C1E0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public BGECMLEGDCD LCCKJILIADA
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x13E4050", Offset = "0x13E3050", VA = "0x1813E4050", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public SkinnedMeshRenderer[] NDHLFNJJKAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x12EC280", Offset = "0x12EB280", VA = "0x1812EC280", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public Renderer[] GPLMHBJCFNG
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x86B9D0", Offset = "0x86A9D0", VA = "0x18086B9D0", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public bool IDAEICADNEN
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x680B6B0", Offset = "0x680A6B0", VA = "0x18680B6B0", Slot = "20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public BIMEIEHNBAC.FNGDOONFPID EGOPEJKHIEF
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x86BAD0", Offset = "0x86AAD0", VA = "0x18086BAD0", Slot = "18")]
		get
		{
			return default(BIMEIEHNBAC.FNGDOONFPID);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public int IICPBCOIHNP
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x1916D10", Offset = "0x1915D10", VA = "0x181916D10")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x680C390", Offset = "0x680B390", VA = "0x18680C390")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private bool BLOPNCNIHAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x680D3E0", Offset = "0x680C3E0", VA = "0x18680D3E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	private static bool IPKIBHOHPHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x6808570", Offset = "0x6807570", VA = "0x186808570")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private bool NCCAEGEDMAE
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x680B490", Offset = "0x680A490", VA = "0x18680B490")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x6811100", Offset = "0x6810100", VA = "0x186811100")]
	public OBBNDEFFAJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6805640", Offset = "0x6804640", VA = "0x186805640", Slot = "26")]
	public void BGGINNGCCML(DAPDMFLMPMN LBOBMIHKMAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6810E30", Offset = "0x680FE30", VA = "0x186810E30", Slot = "27")]
	public void POEMMNCIOIO(OHKKPNMKIGD HAEEKGDMECI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x680C390", Offset = "0x680B390", VA = "0x18680C390", Slot = "4")]
	public void PAMFOOKGEPC(int KEAEHEPAPAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x680BB40", Offset = "0x680AB40", VA = "0x18680BB40", Slot = "9")]
	public void HOCICMAJOJI(LBMNBPOBJJP DENBDPFKGHP, Texture2D ODAFHLABAMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x680F540", Offset = "0x680E540", VA = "0x18680F540", Slot = "10")]
	public void NGDGLICFKAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x680ABD0", Offset = "0x6809BD0", VA = "0x18680ABD0", Slot = "11")]
	public bool FFMMPELBIHC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x680BF00", Offset = "0x680AF00", VA = "0x18680BF00", Slot = "8")]
	public void IJHNLIJFIEH(CKCCMOEGBKE ADMNPLCNJPK, Color? MKAJENPGJDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x68077D0", Offset = "0x68067D0", VA = "0x1868077D0")]
	private void BPLMKALDGJM(Action IPPFDIMJGND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x680BE90", Offset = "0x680AE90", VA = "0x18680BE90", Slot = "5")]
	public void IIIPOAMGPJA(MIMKMAGJOLD IPAGCDIHEKL, Texture FEOJHKMEALC, Color PFAGPLDNLGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x1904820", Offset = "0x1903820", VA = "0x181904820", Slot = "6")]
	public void DAODPGMPFFN(bool DAHCEJCMMGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x12E7F60", Offset = "0x12E6F60", VA = "0x1812E7F60", Slot = "7")]
	public void IMHKIKCLNAF(LOIHFDKLGJH LIIDINHCICD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x6805D40", Offset = "0x6804D40", VA = "0x186805D40", Slot = "14")]
	public PGGFJFHOMCP BHPACJFKFMP(AFANGDOOELI LHBLIJABHBB, bool INNEGOEHHCH, int[] EELKGIEHJAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x68078F0", Offset = "0x68068F0", VA = "0x1868078F0", Slot = "15")]
	public void CFAPHJJKPNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x680A150", Offset = "0x6809150", VA = "0x18680A150")]
	private bool DEOHBEHAFBK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x86B9E0", Offset = "0x86A9E0", VA = "0x18086B9E0", Slot = "19")]
	public void HDJJFINOBBI(BIMEIEHNBAC.FNGDOONFPID BIMGGMHAMLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x680A5B0", Offset = "0x68095B0", VA = "0x18680A5B0")]
	private bool DJOBNPMPPFJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x680D460", Offset = "0x680C460", VA = "0x18680D460")]
	private PGGFJFHOMCP LOCNMICNFBD(bool INNEGOEHHCH, List<FOFKAMHNHMK> LAFAGNIFEDF, int[] EELKGIEHJAD, Func<int, MDKHCAHBNED> KGOBOOGNHJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x680CC50", Offset = "0x680BC50", VA = "0x18680CC50")]
	[IteratorStateMachine(typeof(GENENPNAMAF))]
	private IEnumerator<MBMMHILCGCA> JLOFLOLHDNE(bool INNEGOEHHCH, List<FOFKAMHNHMK> LAFAGNIFEDF, int[] EELKGIEHJAD, Func<int, MDKHCAHBNED> KGOBOOGNHJE, OPNKHHPPPLC PEMDCAAGKJL, Material NIDMFFJDBKL, List<PGGFJFHOMCP> GAKMNHEJKME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x68082B0", Offset = "0x68072B0", VA = "0x1868082B0")]
	private PGGFJFHOMCP CLLJFOFMKLJ(List<FOFKAMHNHMK> LAFAGNIFEDF, int[] EELKGIEHJAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6808710", Offset = "0x6807710", VA = "0x186808710")]
	private JMPIHICOHFM DCHGMFOKMDA(List<FOFKAMHNHMK> LAFAGNIFEDF, int KEAEHEPAPAH, bool INNEGOEHHCH, MDKHCAHBNED AHFHOBDDPJH, bool EAFBHPHKAKM, OPNKHHPPPLC PEMDCAAGKJL, Material NIDMFFJDBKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x68054E0", Offset = "0x68044E0", VA = "0x1868054E0", Slot = "22")]
	public void ANCNIAFAGLG(AvatarFaceShape JGIPOPKNCGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x680A290", Offset = "0x6809290", VA = "0x18680A290", Slot = "23")]
	public void DGGJPIDPGHH(AvatarBodyShape KCCBMGFPCKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x680C3B0", Offset = "0x680B3B0", VA = "0x18680C3B0", Slot = "25")]
	public void IOFBDAHBIDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x680C650", Offset = "0x680B650", VA = "0x18680C650", Slot = "24")]
	public void JENBCHKFCKM(bool BGNGCKLJLEB, bool PIHAFFCCEKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x680A7C0", Offset = "0x68097C0", VA = "0x18680A7C0")]
	private void EIGNKJCODMM(SkinnedMeshRenderer GPJFNFKKHDD, int KEAEHEPAPAH, Mesh NKIMIKOLCFE, List<Material> PNAAPIJJLFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x680A910", Offset = "0x6809910", VA = "0x18680A910")]
	private static Material EMGCIKCMIKP(Dictionary<JJDDAFLFJDM, Material> BIHAOADDGGK, Material HMHMIFACNHN, MMBAOPJHELB MMAMFDIECKL, GELMELABMBB NENEKIBFPEN, CFGFGPACPAK CNCOCPFNBNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x680B960", Offset = "0x680A960", VA = "0x18680B960")]
	private static MMBAOPJHELB HJELKKLAEIN(FOFKAMHNHMK POMGLPJJCEO, int IHFGDHGEMHO)
	{
		return default(MMBAOPJHELB);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6805900", Offset = "0x6804900", VA = "0x186805900")]
	private void BGJOICENGPI(int KLDNMGGJDFC, Material EGLABJPOFKK, FOFKAMHNHMK POMGLPJJCEO, [Out] Texture2D DFLAIELNLDA, [Out] Vector4 CGEGHMJPIME, [Out] Texture2D PECIGIOEFGG, [Out] Texture2D MPJNNDPLJKE, [Out] Texture2D FNHFIJAFNND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x680C660", Offset = "0x680B660", VA = "0x18680C660")]
	private void JFMNCGPHGJO(int KLDNMGGJDFC, Material EGLABJPOFKK, FOFKAMHNHMK POMGLPJJCEO, [Out] Color GGNHIPEKBLP, [Out] Color FFDELLMFGAN, [Out] Color MDDCDPMKKLD, [Out] Color HGGOAPGOAEL, [Out] Color OEICKEODEEG, [Out] Color DFFDAGJEFKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x680A350", Offset = "0x6809350", VA = "0x18680A350")]
	private bool DGNOKOFCDLF(Material EGLABJPOFKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6807E50", Offset = "0x6806E50", VA = "0x186807E50")]
	private static Material CKBJAPHKLEI(int KLDNMGGJDFC, LEBDDNMMEGE POMGLPJJCEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x68109A0", Offset = "0x680F9A0", VA = "0x1868109A0")]
	private static GELMELABMBB OMBDIFLBGEB(FOFKAMHNHMK POMGLPJJCEO, int IHFGDHGEMHO)
	{
		return default(GELMELABMBB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6805110", Offset = "0x6804110", VA = "0x186805110")]
	private static void AJCLIFEOIJH(Dictionary<string, List<JJDDAFLFJDM>> JFPGMJFEBIM, FOFKAMHNHMK NAEBBHKLBHC, Material HMHMIFACNHN, MMBAOPJHELB ADMNPLCNJPK, GELMELABMBB DENBDPFKGHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x680FB60", Offset = "0x680EB60", VA = "0x18680FB60")]
	private static SkinnedMeshRenderer NPEHEHPEDKP(Transform AJGPPFKLKHC, Transform HFIDCABJIBE, SkinnedMeshRenderer[] DMHJBBCAABP, int KEAEHEPAPAH, MDKHCAHBNED AHFHOBDDPJH, bool INNEGOEHHCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x680B090", Offset = "0x680A090", VA = "0x18680B090")]
	private void GCGJEBGIKOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6805630", Offset = "0x6804630", VA = "0x186805630")]
	private void BCPFJBDEICD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6810840", Offset = "0x680F840", VA = "0x186810840")]
	private static void OLEGIBDFBOA(Dictionary<JJDDAFLFJDM, Material> BIHAOADDGGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6810A90", Offset = "0x680FA90", VA = "0x186810A90")]
	private static void PBDNJPCCOIB(Dictionary<Renderer, OPNKHHPPPLC> LHBPBIAPOMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x680D1F0", Offset = "0x680C1F0", VA = "0x18680D1F0")]
	private void LEHJJIAMLDD(SkinnedMeshRenderer[] DMHJBBCAABP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6807850", Offset = "0x6806850", VA = "0x186807850")]
	private void CALAIPIENAD(SkinnedMeshRenderer LBPNJIHGJDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6807AF0", Offset = "0x6806AF0", VA = "0x186807AF0")]
	private void CFBCALGIPPD(List<EGGKBNFDHIC> BNHPPFDMGJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x680F280", Offset = "0x680E280", VA = "0x18680F280")]
	private void NCKMPICJLPM(Dictionary<string, FMHOFFFMGIN<Texture2D>> JFPGMJFEBIM, bool MJMDFBNDGLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6805400", Offset = "0x6804400", VA = "0x186805400")]
	private void AJOOHMCPEGG(Dictionary<string, List<JJDDAFLFJDM>> JFPGMJFEBIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x680DF90", Offset = "0x680CF90", VA = "0x18680DF90")]
	private void MFCELEDOFLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6810BF0", Offset = "0x680FBF0", VA = "0x186810BF0")]
	private void PCAHKBNJJOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x680DA40", Offset = "0x680CA40", VA = "0x18680DA40")]
	private void MAMKGHPGHLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x680F400", Offset = "0x680E400", VA = "0x18680F400")]
	private void NDBDMIEBNKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x680D160", Offset = "0x680C160", VA = "0x18680D160")]
	private void LCKLPBLIFKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x680AD80", Offset = "0x6809D80", VA = "0x18680AD80")]
	private void FPBBDDEIJIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x680AB00", Offset = "0x6809B00", VA = "0x18680AB00")]
	private void FBIOAPEGNMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x680BDF0", Offset = "0x680ADF0", VA = "0x18680BDF0")]
	private void IGPICDKELIG(bool JMHOGIJFGPJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x680D310", Offset = "0x680C310", VA = "0x18680D310")]
	private void LIPMLCKAPII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x680B260", Offset = "0x680A260", VA = "0x18680B260")]
	private void GNMHMMMIMKH(bool JMHOGIJFGPJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x6810130", Offset = "0x680F130", VA = "0x186810130")]
	private void OFCBMPGIEGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x6807ED0", Offset = "0x6806ED0", VA = "0x186807ED0")]
	private void CKFDBIGPAEC(Material NIDMFFJDBKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x680F5C0", Offset = "0x680E5C0", VA = "0x18680F5C0")]
	private void NGGALKHCPAN(Material NIDMFFJDBKL, Color FFDELLMFGAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x680CD60", Offset = "0x680BD60", VA = "0x18680CD60")]
	private void JOOFDGNGOBN(Material NIDMFFJDBKL, Color MDDCDPMKKLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x680CE80", Offset = "0x680BE80", VA = "0x18680CE80")]
	private void KOJGPHAACHH(Material NIDMFFJDBKL, Color GGNHIPEKBLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x680FA70", Offset = "0x680EA70", VA = "0x18680FA70")]
	private void NMFADDIIBLM(Material NIDMFFJDBKL, Texture2D ODAFHLABAMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6804F40", Offset = "0x6803F40", VA = "0x186804F40")]
	private void AGJLLADCEIE(Material NIDMFFJDBKL, Texture DHBCPIJDMCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x6804D80", Offset = "0x6803D80", VA = "0x186804D80")]
	private void AEGFLACCPJL(Action<OPNKHHPPPLC> HCKBCCONIJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6807CD0", Offset = "0x6806CD0", VA = "0x186807CD0")]
	private void CGEIACOFJMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x68073F0", Offset = "0x68063F0", VA = "0x1868073F0")]
	private void BMEEFICBGOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x680E110", Offset = "0x680D110", VA = "0x18680E110")]
	private PGGFJFHOMCP MMDAINMIHPI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x6810470", Offset = "0x680F470", VA = "0x186810470")]
	private void OIJOKMNEFKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x680F6B0", Offset = "0x680E6B0", VA = "0x18680F6B0")]
	public void NIOEHFKKBFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x6808240", Offset = "0x6807240", VA = "0x186808240")]
	private void CKHGIKPOION(Vector3 KBHBDHIEKKP, Quaternion JAFLFHHIBJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x680FD90", Offset = "0x680ED90", VA = "0x18680FD90")]
	private void ODEPOKPBCNL(List<FOFKAMHNHMK> DJINLCMLEFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x680E700", Offset = "0x680D700", VA = "0x18680E700")]
	public void MMMLPFAHDEE(MPNIGMOKBGH IHDBJBCCFPK, bool JNFGNCKGPJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x680EC00", Offset = "0x680DC00", VA = "0x18680EC00")]
	public void MMMLPFAHDEE(MPNIGMOKBGH IHDBJBCCFPK, AnchorParamsRestrictions BAGKDLOIAOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0xA087D0", Offset = "0xA077D0", VA = "0x180A087D0")]
	private static void OFNFPLDGAKB(FitMeshHemisphere NCCJLHMFMKH, Transform CPNJAMEEOPJ, MPNIGMOKBGH IHDBJBCCFPK, AnchorParamsRestrictions IDEKHEINMFP, [Out] Vector3 DCBNBHMBGKP, [Out] Quaternion JAFBJNOBENG, [Out] MPNIGMOKBGH LIIHAIPPJNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x680AED0", Offset = "0x6809ED0", VA = "0x18680AED0")]
	public void GBNKAKDFBCC(Vector2 IPLBIJAMABD, Vector3 FPDAAEPPIEJ, Vector3 DIPLBFGLHMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x680CF70", Offset = "0x680BF70", VA = "0x18680CF70")]
	private void LANFCCOOFKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x68055A0", Offset = "0x68045A0", VA = "0x1868055A0")]
	private void ANLJODBGPJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x680AA70", Offset = "0x6809A70", VA = "0x18680AA70")]
	[CompilerGenerated]
	private void EPOHAPNLOIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x680A670", Offset = "0x6809670", VA = "0x18680A670")]
	[CompilerGenerated]
	private void DLJDIFHAJEN(OPNKHHPPPLC GGEKPBNMLCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x680BD50", Offset = "0x680AD50", VA = "0x18680BD50")]
	[CompilerGenerated]
	private void HOKKIAIJCPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x680E0F0", Offset = "0x680D0F0", VA = "0x18680E0F0")]
	[CompilerGenerated]
	private void MFHGIJBKHPO(OPNKHHPPPLC GGEKPBNMLCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x680A730", Offset = "0x6809730", VA = "0x18680A730")]
	[CompilerGenerated]
	private void EGBOAKPHABP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x680F4D0", Offset = "0x680E4D0", VA = "0x18680F4D0")]
	[CompilerGenerated]
	private void NDPMIBDBDKN(OPNKHHPPPLC GGEKPBNMLCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x6807360", Offset = "0x6806360", VA = "0x186807360")]
	[CompilerGenerated]
	private void BJNBPIODFKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x680BA80", Offset = "0x680AA80", VA = "0x18680BA80")]
	[CompilerGenerated]
	private void HKMOGBPDDFK(OPNKHHPPPLC GGEKPBNMLCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x680C300", Offset = "0x680B300", VA = "0x18680C300")]
	[CompilerGenerated]
	private void IKILAFECIDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6804D50", Offset = "0x6803D50", VA = "0x186804D50")]
	[CompilerGenerated]
	private void ABCGLLMPJFB(OPNKHHPPPLC GGEKPBNMLCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x680A6A0", Offset = "0x68096A0", VA = "0x18680A6A0")]
	[CompilerGenerated]
	private void EGBMIHBMFMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x680AD50", Offset = "0x6809D50", VA = "0x18680AD50")]
	[CompilerGenerated]
	private void FOFOFLIIADC(OPNKHHPPPLC GGEKPBNMLCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x6805450", Offset = "0x6804450", VA = "0x186805450")]
	[CompilerGenerated]
	private void AMMEEHNEBAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x680FA40", Offset = "0x680EA40", VA = "0x18680FA40")]
	[CompilerGenerated]
	private void NJPIFHPDFNL(OPNKHHPPPLC GGEKPBNMLCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x6807750", Offset = "0x6806750", VA = "0x186807750")]
	[CompilerGenerated]
	private void BMILKADNOCH(KeyValuePair<string, FMHOFFFMGIN<Texture2D>> KGDKKABCDKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x6805030", Offset = "0x6804030", VA = "0x186805030")]
	[CompilerGenerated]
	private void AHFFHCDGJOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x680CE50", Offset = "0x680BE50", VA = "0x18680CE50")]
	[CompilerGenerated]
	private void KGPEKIIOBKJ(OPNKHHPPPLC GGEKPBNMLCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x680BAB0", Offset = "0x680AAB0", VA = "0x18680BAB0")]
	[CompilerGenerated]
	private void HNFOHNBBMID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x6810E00", Offset = "0x680FE00", VA = "0x186810E00")]
	[CompilerGenerated]
	private void PJFEEGDNALI(OPNKHHPPPLC GGEKPBNMLCN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class GKEHDNDBNEP : KFANBJCCOLL
{
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private static readonly int OANKIHHIOEF;

	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private static readonly int GJNFAHGOAPF;

	[Cpp2IlInjected.Token(Token = "0x4000130")]
	private static readonly int JOAOLCIPJPP;

	[Cpp2IlInjected.Token(Token = "0x4000131")]
	private static readonly int PIKHAKBEKDI;

	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private static readonly int MHMDBGGLNKL;

	[Cpp2IlInjected.Token(Token = "0x4000133")]
	private static readonly int HAACGICEPBC;

	[Cpp2IlInjected.Token(Token = "0x4000134")]
	private static readonly int MPJKMEFJGEN;

	[Cpp2IlInjected.Token(Token = "0x4000135")]
	private static readonly int EJEFBAKFKAH;

	[Cpp2IlInjected.Token(Token = "0x4000136")]
	private static readonly int CAFDAHNNLLM;

	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private static readonly int HHBPKNDNLCG;

	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private static readonly int BCEJJAOKHCO;

	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private static readonly int GECPBNCEDAG;

	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private static readonly int ICBDBFNOKMM;

	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private static readonly int IMGEGNACCDP;

	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private static readonly int BDCMAKJFACL;

	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private static readonly int MEOMHGJEGDB;

	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private static readonly int DNDAACBJPDP;

	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private static readonly int FCNECJHGKMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private Transform JCKNHLHIEGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private Transform JHPKNEHICJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private Transform DDNBDPOOFGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private Transform PBGEJNBDENH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private Transform DGHFGLBHBLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private Transform FBHLAJDONFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private Transform IKINBGOBALK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private ADKNAJDOOKC HLPIAFCOEPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private MaterialPropertyBlock EKNKIPDABHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private SkinnedMeshRenderer[] KMMALKIBAGI;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	private MaterialPropertyBlock FDFNMNALHBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x6800FB0", Offset = "0x67FFFB0", VA = "0x186800FB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool LMMCDOJHLCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x6802BC0", Offset = "0x6801BC0", VA = "0x186802BC0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x6801030", Offset = "0x6800030", VA = "0x186801030", Slot = "7")]
	public void BGGINNGCCML(ADKNAJDOOKC ONHKIOMDBBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x6801300", Offset = "0x6800300", VA = "0x186801300", Slot = "8")]
	public void IDMLCEIDALK(DOCFECFMOIF EJGFFDKGCAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x6802790", Offset = "0x6801790", VA = "0x186802790", Slot = "5")]
	public void LODIIJGINIH(CLGIBKDCNFC MAGAOIBEHJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x68012A0", Offset = "0x68002A0", VA = "0x1868012A0")]
	private Vector2 GNGPBOLBBMN(Vector2 DCGHOCFCBDH)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x6801330", Offset = "0x6800330", VA = "0x186801330", Slot = "6")]
	public void JEFDCCCIICK(MAEONAPIKCA EJGFFDKGCAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x6802440", Offset = "0x6801440", VA = "0x186802440")]
	private void KLHADJGFEAC(MAEONAPIKCA DKPJMJDLHCJ, NOEDMJIDDNK NDFADGMJNIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x6801180", Offset = "0x6800180", VA = "0x186801180")]
	private void DCGGBNPNHKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x6803070", Offset = "0x6802070", VA = "0x186803070")]
	public GKEHDNDBNEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x68010F0", Offset = "0x68000F0", VA = "0x1868010F0")]
	[CompilerGenerated]
	internal static (float, float) BKLGJJCPGBK(float IMHPHKNALBD)
	{
		return default((float, float));
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x6801260", Offset = "0x6800260", VA = "0x186801260")]
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
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private MaterialPropertyBlock HEEOKCGAEGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	public Color? FOIFMFPPKFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	public Color? JNDOIHNFOPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	public Color? PLCFLJKNCGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	public Color? DIPBKEPIAND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	public Color JJBJEBEEFMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	public Color OMMBEDHDBGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	public Color ALKLGCOFFAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	public Texture2D KIADBBDBCIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	public Texture2D DMELJIAOCNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private Dictionary<JJDDAFLFJDM, int> FOKAPEBHHIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private MMBAOPJHELB[] BHCEDJFJIJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private GELMELABMBB[] NEALHNMJHCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	public Vector4[] FAEBGJDAOAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	public Vector4[] LKOLINILEPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	public Vector4[] CIDIHDHCDNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	public Vector4[] FOAOKCFHEKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	public Vector4[] AIBCOEDNKDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	public Vector4[] PLDDCMIMOBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	private List<Texture2D> JMFBDKDOPGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private Vector4[] BDEBCGMOOPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	private List<Texture2D> BOEAIPABIIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	private float[] PFOBEEJBEFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	private Vector4[] ABCFOCJCMPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	private float[] KFHDCHIGNAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	public float[] JOBGECPDOOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	private List<Texture2D> ADJJCMJAAFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private float[] DAIHFAECJDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private List<Texture2D> IPDHAGOABKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private Vector4[] PLMHOKLBBOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	private float[] MBCJLOOOPLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	private Vector4[] DPAOAIODPAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	public float[] GAOIKJCDFAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	public Texture2DArray KIOGFNIOELB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	public Texture2DArray OBCADMOOEOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	public Texture2DArray BNFONNJOHGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	public Texture2DArray NOAANDANPPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	private bool CIFKAOHOIJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x184")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private int OLLLDEIIIAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private Vector2? FKFIGLJOGJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x194")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private TextureFormat ILNDNPEEHKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private Vector2? BGDMKEINHGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A4")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private TextureFormat DAMMAJGFBLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private Vector2? DJIGHADGPKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B4")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private TextureFormat LKHHOEGGCFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private Vector2? LHBOAILPABD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C4")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private TextureFormat DMLCAMLODEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private bool KIHONPKCMEM;

	[Cpp2IlInjected.Token(Token = "0x400017A")]
	private static int BHHBDAPOJDF;

	[Cpp2IlInjected.Token(Token = "0x400017B")]
	private static int LIJEIMBLEPE;

	[Cpp2IlInjected.Token(Token = "0x400017C")]
	private static int EJFEGJHKLGF;

	[Cpp2IlInjected.Token(Token = "0x400017D")]
	private static int PBBAIPKKHIA;

	[Cpp2IlInjected.Token(Token = "0x400017E")]
	private static int NPEBAILBNMC;

	[Cpp2IlInjected.Token(Token = "0x400017F")]
	private static int LFEACGMDHFH;

	[Cpp2IlInjected.Token(Token = "0x4000180")]
	private static int HAJDCMIPCBL;

	[Cpp2IlInjected.Token(Token = "0x4000181")]
	private static int GBFAJFFIABL;

	[Cpp2IlInjected.Token(Token = "0x4000182")]
	private static int KNIENOEJAFJ;

	[Cpp2IlInjected.Token(Token = "0x4000183")]
	private static int HANFDKOLLBL;

	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private static int FHNDIPHJANB;

	[Cpp2IlInjected.Token(Token = "0x4000185")]
	private static int ABDGIEDJOCD;

	[Cpp2IlInjected.Token(Token = "0x4000186")]
	private static int KNHMBJNIBOB;

	[Cpp2IlInjected.Token(Token = "0x4000187")]
	private static int OJBHBBFJMEA;

	[Cpp2IlInjected.Token(Token = "0x4000188")]
	private static int POLKNMDBPEC;

	[Cpp2IlInjected.Token(Token = "0x4000189")]
	private static int IFDPIBEAOIK;

	[Cpp2IlInjected.Token(Token = "0x400018A")]
	private static int PLJHEDDFCHP;

	[Cpp2IlInjected.Token(Token = "0x400018B")]
	private static int BKBGCACMJAC;

	[Cpp2IlInjected.Token(Token = "0x400018C")]
	private static int DCNJMKEEDBG;

	[Cpp2IlInjected.Token(Token = "0x400018D")]
	private static int PBFJAFAGKPE;

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x681E860", Offset = "0x681D860", VA = "0x18681E860")]
	private OPNKHHPPPLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x681E7A0", Offset = "0x681D7A0", VA = "0x18681E7A0")]
	public OPNKHHPPPLC(Color JHIEOOBEFPC, Color PPGBFJHHKGJ, Color CCHMJOAFHFL, Color? LFDMBCMHLLC, Color? NAENLKBPFII, Color? NDPHMKIPNEP, Texture2D JKCKAKBIILK, Texture2D EEPADGEMJJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x681DCD0", Offset = "0x681CCD0", VA = "0x18681DCD0")]
	internal int HAEMPMFIPFH(Material LBNEPCNOGCD, MMBAOPJHELB MMAMFDIECKL, GELMELABMBB NENEKIBFPEN, CFGFGPACPAK CNCOCPFNBNP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x681DC40", Offset = "0x681CC40", VA = "0x18681DC40")]
	private int HAEMPMFIPFH(JJDDAFLFJDM BHEIPBKEDLG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x681CEB0", Offset = "0x681BEB0", VA = "0x18681CEB0")]
	internal int GEAEACKFFOP(Material LBNEPCNOGCD, Color GGNHIPEKBLP, Color FFDELLMFGAN, Color MDDCDPMKKLD, Color HGGOAPGOAEL, Color OEICKEODEEG, Texture2D FAMFHNOBIKN, Vector4 AFEJIBOHCGD, Texture2D LGOHKJBGKFP, Vector4 NACBKLKFHHJ, float NCNHBHJLHEI, float FFIGMKJECCI, Texture2D PBFPGKEJFNI, Vector4 JNAHKBPEFCI, float KELIDNBOCCO, Texture2D FOMJMPJKLBL, Color DFFDAGJEFKG, Vector4 HGFJEPNAJDG, MMBAOPJHELB MMAMFDIECKL, GELMELABMBB NENEKIBFPEN, CFGFGPACPAK CNCOCPFNBNP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x681DA80", Offset = "0x681CA80", VA = "0x18681DA80")]
	private void GJLCHFFDHNI(List<Texture2D> JMFBDKDOPGN, [Out] Texture2DArray GHMOKIGFFHG, [Out] Texture2DArray HNFOJMHAGLI, [Out] Texture2DArray BEJEDBAIMOA, [Out] Texture2DArray FFCJMJIKMKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x681DFC0", Offset = "0x681CFC0", VA = "0x18681DFC0")]
	public void KENKMLNJCOO(Shader FCCOCAFELDO, Renderer APJGPLFHDMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x681C120", Offset = "0x681B120", VA = "0x18681C120")]
	private void BNGGLLHDFCJ(Shader FCCOCAFELDO, Renderer APJGPLFHDMA, int PMLGLBKLAEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x681E210", Offset = "0x681D210", VA = "0x18681E210")]
	private Color PGBPCBJBGPC(Color EIKIIHBPBEB, MMBAOPJHELB ADMNPLCNJPK)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x681DE70", Offset = "0x681CE70", VA = "0x18681DE70")]
	private Color JHCJEDCOCIG(Color GAGEKOLMNPM, MMBAOPJHELB ADMNPLCNJPK)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x681E110", Offset = "0x681D110", VA = "0x18681E110")]
	private bool LEIMCIHAICP(Texture2D IHPGLMHGFHM, GELMELABMBB DENBDPFKGHP, [Out] Texture2D IJLCGGDOBFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x681DDC0", Offset = "0x681CDC0", VA = "0x18681DDC0")]
	private void HPOFKIPIBAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x681CE70", Offset = "0x681BE70", VA = "0x18681CE70", Slot = "4")]
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
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		[Obsolete("Use CombinationId instead!")]
		[SerializeField]
		private string Guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		[SerializeField]
		private SerializedCombinationId combinationId;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		private BHFPKMDNKBO? cachedMaterialCombinationId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		[SerializeField]
		private Material material;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		[SerializeField]
		private Material[] additionalMaterials;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public ENHFLJGMKFD CombinationId
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x6815630", Offset = "0x6814630", VA = "0x186815630")]
			get
			{
				return default(ENHFLJGMKFD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public BHFPKMDNKBO MaterialCombinationId
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x6815680", Offset = "0x6814680", VA = "0x186815680")]
			get
			{
				return default(BHFPKMDNKBO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public Material Material
		{
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x866E50", Offset = "0x865E50", VA = "0x180866E50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public Material[] AdditionalMaterials
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x86BA10", Offset = "0x86AA10", VA = "0x18086BA10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x6815480", Offset = "0x6814480", VA = "0x186815480")]
		public Material[] GKKKOCGGOMO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x68152C0", Offset = "0x68142C0", VA = "0x1868152C0")]
		public static void DBLAPPEGIEL(AvatarItemMaterial KAIEMABEFDP, Material EGLABJPOFKK, int KLDNMGGJDFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x6815560", Offset = "0x6814560", VA = "0x186815560")]
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
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	[ReadOnly]
	public OPKGMGJOBGD OLGCKPOOPDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	[ReadOnly]
	public int CDDEHJEOBHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	public MENNLKOLGBA BBFAHHBIHAE;

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x681ED50", Offset = "0x681DD50", VA = "0x18681ED50", Slot = "4")]
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
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	public NativeArray<Vector3> JAEKADPDMHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	public NativeArray<Vector3> DPOANBHKPCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	public NativeArray<Vector4> JKIIIELNJIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	public NativeArray<Vector2> KEJKHPLGJIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	public NativeArray<Vector2> NEEMHBALCHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	public NativeArray<Vector2> JKIADIKNGJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	public NativeArray<Vector2> AMIFNMANHDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	public NativeArray<Color> MFEGDGLHHKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	public NativeArray<int> HJEHHGIJMEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	public NativeArray<int> OKELJGGKGND;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	private NativeArray<int> DMDHEPNPJHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	private NativeArray<int> CHIJLMGGHIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	public NativeArray<int> EBBGBCCLOEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	public NativeArray<int> LAPPKGFEEHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	public NativeArray<int> MMHJBGBEODK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	public NativeArray<BoneWeight> BCMBODNIDKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private NativeArray<int> LIIDINHCICD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private bool KOMPANFGFOD;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public int OMMKMGENDMH
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x6818C40", Offset = "0x6817C40", VA = "0x186818C40")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x6818E00", Offset = "0x6817E00", VA = "0x186818E00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public int JBCNKKCCGNF
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x6818C30", Offset = "0x6817C30", VA = "0x186818C30")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x6818C20", Offset = "0x6817C20", VA = "0x186818C20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public int NMONCPEMHKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x6818C10", Offset = "0x6817C10", VA = "0x186818C10")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x68193E0", Offset = "0x68183E0", VA = "0x1868193E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x6819660", Offset = "0x6818660", VA = "0x186819660")]
	public MENNLKOLGBA(int OMBNHCCNPKK, int NHDHPBAIHEG, int KKFLGOEKKEP, int KJMIOMBPFPJ, Allocator IDMGOAKOEDG, int DBOKLIAHFGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x6819420", Offset = "0x6818420", VA = "0x186819420")]
	public void LLHMDAGIEGF(int LLPJHIPCNFD, Vector3 DCMJEJAEEHK, Vector3 HPNFCDLKBEK, Vector4 LBKJPGMAINP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x68194C0", Offset = "0x68184C0", VA = "0x1868194C0")]
	public void NPNIIDOAGFF(int LLPJHIPCNFD, BoneWeight IHDJAJLIIOF, NativeSlice<byte> ODAPPFPKOJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x6818E10", Offset = "0x6817E10", VA = "0x186818E10")]
	public Color EPMEOKECOGH(int LLPJHIPCNFD)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x6819490", Offset = "0x6818490", VA = "0x186819490")]
	public void NLBONIANDGB(int LLPJHIPCNFD, Color DDKEAFEIAAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x6819390", Offset = "0x6818390", VA = "0x186819390")]
	public void JHFHPJIMKNE(byte AJABMBEHIJO, int LLPJHIPCNFD, Vector2 ICGFDOIKAMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x68194B0", Offset = "0x68184B0", VA = "0x1868194B0")]
	public void NMAOGAKHJAG(int LLPJHIPCNFD, int IKLLAPMJKNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x68193F0", Offset = "0x68183F0", VA = "0x1868193F0")]
	public bool LFGJEGHBFLE(int AJABMBEHIJO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x68192C0", Offset = "0x68182C0", VA = "0x1868192C0")]
	public void IHNELMBEEIN(int KIHHGEBKJCM, int ANNLKNNLIGI, int DOIKAIEGGLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x6819180", Offset = "0x6818180", VA = "0x186819180")]
	public int[] GGOGAFKBKPC(int KIHHGEBKJCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x6819230", Offset = "0x6818230", VA = "0x186819230")]
	private NativeSlice<int> IFMBCFLAEPO(int KIHHGEBKJCM)
	{
		return default(NativeSlice<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x6818C50", Offset = "0x6817C50", VA = "0x186818C50", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x6818E30", Offset = "0x6817E30", VA = "0x186818E30")]
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
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	public NativeArray<Vector3> JAEKADPDMHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	public NativeArray<Vector3> DPOANBHKPCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	public NativeArray<Vector4> JKIIIELNJIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	public NativeArray<Vector2> KEJKHPLGJIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	public NativeArray<Vector2> NEEMHBALCHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	public NativeArray<Vector2> JKIADIKNGJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	public NativeArray<Vector2> AMIFNMANHDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	public NativeArray<Color> MFEGDGLHHKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	public NativeArray<int> KNFJEIDAPPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	public NativeArray<int> FGAAFIGJFEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	public NativeArray<int> KIFEHGIGHDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	public NativeArray<int> PBIEKKEAOOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	public NativeArray<bool> NLPDLGBBIHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	public NativeArray<int> HPPGNFMPMKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	public NativeArray<int> KMPBFLCJJOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	public NativeArray<BoneWeight> CIPKIHCEGMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	private NativeArray<Matrix4x4> ODKMPLFIGNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	private NativeArray<int> MHPAKEEDPMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	private NativeArray<byte> AGLIEPBGEHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	private NativeArray<int> HDANFBFDLBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	private NativeArray<int> EAHDMNLKGMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	public NativeArray<sbyte> CPCIMPADOPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	public NativeArray<byte> IFHFJNEHNMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	private NativeArray<int> GOEKKDENBGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	private bool KOMPANFGFOD;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public int EBLCECOHDHI
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x1FEFC50", Offset = "0x1FEEC50", VA = "0x181FEFC50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public int MPEKNNJLCCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x101DEC0", Offset = "0x101CEC0", VA = "0x18101DEC0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public int IIIMKFIPKFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x681A780", Offset = "0x6819780", VA = "0x18681A780")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public int FNAIGGBHFLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x681A230", Offset = "0x6819230", VA = "0x18681A230")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x681A890", Offset = "0x6819890", VA = "0x18681A890")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public int OMMKMGENDMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x6819FC0", Offset = "0x6818FC0", VA = "0x186819FC0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x681A250", Offset = "0x6819250", VA = "0x18681A250")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public int GGCNDDBEIIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x681A8A0", Offset = "0x68198A0", VA = "0x18681A8A0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x681A880", Offset = "0x6819880", VA = "0x18681A880")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public LAHINCAGKJC MBAFBILDFFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x681A8B0", Offset = "0x68198B0", VA = "0x18681A8B0")]
		get
		{
			return default(LAHINCAGKJC);
		}
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x681A240", Offset = "0x6819240", VA = "0x18681A240")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public byte IHPLCGHMHNC
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x6819FA0", Offset = "0x6818FA0", VA = "0x186819FA0")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x6819FB0", Offset = "0x6818FB0", VA = "0x186819FB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public NINLMMAKGMP PGDICMLLHEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x681A260", Offset = "0x6819260", VA = "0x18681A260")]
		get
		{
			return default(NINLMMAKGMP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x681A8C0", Offset = "0x68198C0", VA = "0x18681A8C0")]
	public OPKGMGJOBGD(IList<Mesh> DOCBHJCMNOC, IList<Matrix4x4> OGCGAFJEFNB, IList<bool> NLPDLGBBIHC, byte EFMHDJCLHII, IList<byte[]> GOLOIFEILNM, IList<int> AIIGHENFNJL, IList<bool> HODOILLLJKB, IList<int> HPPGNFMPMKL, IList<int> PKGFLOGCBKN, IList<int> PDIAAIPEJIO, Allocator IDMGOAKOEDG, LAHINCAGKJC KKOACLOODHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x681A7B0", Offset = "0x68197B0", VA = "0x18681A7B0")]
	public MENNLKOLGBA FIIPKOMAHKM(Allocator IDMGOAKOEDG)
	{
		return default(MENNLKOLGBA);
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x6819FD0", Offset = "0x6818FD0", VA = "0x186819FD0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[LEDNJNPECJC]
public class KNLFGKFAFIE : FJEOCBOAHBF
{
	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x6818AD0", Offset = "0x6817AD0", VA = "0x186818AD0")]
	public OPKGMGJOBGD FLKFPEEIEFB()
	{
		return default(OPKGMGJOBGD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x67FE8A0", Offset = "0x67FD8A0", VA = "0x1867FE8A0")]
	public KNLFGKFAFIE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public struct NINLMMAKGMP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	public NativeSlice<Vector3> JAEKADPDMHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	public NativeSlice<Vector3> DPOANBHKPCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	public NativeSlice<Vector4> JKIIIELNJIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	public NativeSlice<Vector2> KEJKHPLGJIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	public NativeSlice<Vector2> NEEMHBALCHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	public NativeSlice<Vector2> JKIADIKNGJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	public NativeSlice<Vector2> AMIFNMANHDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	public NativeSlice<Color> MFEGDGLHHKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	public NativeSlice<int> ODIBNOGPEAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	public NativeSlice<int> PBIEKKEAOOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	public NativeSlice<BoneWeight> CIPKIHCEGMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	public NativeSlice<byte> CEDABMHNJDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	public int BFLAAGIKBGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	public Matrix4x4 NHCPLPLJFNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	public int IPGLNLKGPHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	public NativeSlice<byte> ODAPPFPKOJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	public bool EIONHBFAIMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	public int NHKMOEANPCL;
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal readonly struct JJDDAFLFJDM : IEquatable<JJDDAFLFJDM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	internal readonly Material BOCAFGJDKKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	internal readonly MMBAOPJHELB LNLDBKBDKFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	internal readonly GELMELABMBB IBMHLFLEHHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	internal readonly CFGFGPACPAK LFPHNBEKBDE;

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0xA3FB00", Offset = "0xA3EB00", VA = "0x180A3FB00")]
	public JJDDAFLFJDM(Material EGLABJPOFKK, MMBAOPJHELB MMAMFDIECKL, GELMELABMBB NENEKIBFPEN, CFGFGPACPAK CNCOCPFNBNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x68188B0", Offset = "0x68178B0", VA = "0x1868188B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0xA3F6E0", Offset = "0xA3E6E0", VA = "0x180A3F6E0", Slot = "4")]
	public bool Equals(JJDDAFLFJDM LJAAPFIIPOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x6818730", Offset = "0x6817730", VA = "0x186818730", Slot = "0")]
	public override bool Equals(object HBFCGFKGCAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x6818810", Offset = "0x6817810", VA = "0x186818810", Slot = "2")]
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
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		private MBMMHILCGCA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		public JobHandle handle;

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		private MBMMHILCGCA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x869510", Offset = "0x868510", VA = "0x180869510", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x869510", Offset = "0x868510", VA = "0x180869510", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x86B3A0", Offset = "0x86A3A0", VA = "0x18086B3A0")]
		[DebuggerHidden]
		public MCLHCKJGEKP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0xA3D030", Offset = "0xA3C030", VA = "0x180A3D030", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x6818BC0", Offset = "0x6817BC0", VA = "0x186818BC0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350")]
	public static void EEGAEFGDIGJ(string BLCJLIJFBDL, int KEAEHEPAPAH, long CPDKGDGLOFE, long KCGFNBDMFHN, long HOEILIJPPCD, long GMJAKEKPMLH, long MBLIGIGLADA, long EDJEENIKLID, long ENCEAHCLAFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x6817090", Offset = "0x6816090", VA = "0x186817090")]
	public static JMPIHICOHFM POPMILGIBIN(JobHandle AHDDBDMIJGJ, bool MCNOGAFMBGD, bool POGADALPHOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x6817020", Offset = "0x6816020", VA = "0x186817020")]
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
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	private FGFNPOBMNEM IKHFIMGOCHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	private JJJEKPCFLHF BJFAFMKHMFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	private IRecRoomQualityConfigProvider DJOJCNPIHHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	private bool KOMPANFGFOD;

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x6816820", Offset = "0x6815820", VA = "0x186816820")]
	[PECFDJPHGEK(BOIKMOKIOJG.GameOnly)]
	private static void PDECJEAEPFN(DIIANKCHAHD OMDOLEEBJJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x5B3CF20", Offset = "0x5B3BF20", VA = "0x185B3CF20")]
	[UnityEngine.Scripting.Preserve]
	public DIJNPEECGFJ([JFHFHOOOEKP(null)] JJJEKPCFLHF EIEDCFJMHID, [JFHFHOOOEKP(null)] FGFNPOBMNEM OAMDGLJKAGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x6816150", Offset = "0x6815150", VA = "0x186816150")]
	private void EJCEGJOFDKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x68167C0", Offset = "0x68157C0", VA = "0x1868167C0", Slot = "4")]
	public void NGDGLICFKAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x6816300", Offset = "0x6815300", VA = "0x186816300", Slot = "5")]
	public FMHOFFFMGIN<Texture2D> KFOIPANBDJM(JLBMGMIIKLH JPBMLKLCPAJ, [Optional] LOIHFDKLGJH LIIDINHCICD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x68161C0", Offset = "0x68151C0", VA = "0x1868161C0")]
	private uint HNCGEAKLFKO(JLBMGMIIKLH JPBMLKLCPAJ, LOIHFDKLGJH LIIDINHCICD)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public interface MKKMHKLEJAJ
{
	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DANDGJIFFLG(Mesh NKIMIKOLCFE, Matrix4x4 FCBIJCBGLKM, byte[] ODAPPFPKOJM, bool OJAFILOOFKF = false, BIMEIEHNBAC.FNGDOONFPID IJHLILAANCL = (BIMEIEHNBAC.FNGDOONFPID)0, int HPPGNFMPMKL = -1, bool NLPDLGBBIHC = false);

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LFONKKPCGPL(Allocator IDMGOAKOEDG, LAHINCAGKJC KKOACLOODHP, byte EFMHDJCLHII, [Optional] IList<int> PKGFLOGCBKN, [Optional] IList<int> FKCCHFIKNNG);
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public readonly struct IICDLNLFNKP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	public readonly GameObject DGPMDGGABNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	private readonly AvatarItemMaterial EJDGMBLOIPL;

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0xAB8760", Offset = "0xAB7760", VA = "0x180AB8760")]
	public IICDLNLFNKP(GameObject DGPMDGGABNO, AvatarItemMaterial EJDGMBLOIPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x6818170", Offset = "0x6817170", VA = "0x186818170")]
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
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		public AsyncTaskMethodBuilder<(GameObject, AvatarItemMaterial)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		public Task<GameObject> goTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		public Task<AvatarItemMaterial> materialTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		private GameObject <go>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		private TaskAwaiter<GameObject> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		private TaskAwaiter<AvatarItemMaterial> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x6815740", Offset = "0x6814740", VA = "0x186815740", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x6815C40", Offset = "0x6814C40", VA = "0x186815C40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	private FMHOFFFMGIN<GameObject> HPAIJDOJNEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	private FMHOFFFMGIN<AvatarItemMaterial> MCGIANGHJBP;

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x6816F90", Offset = "0x6815F90", VA = "0x186816F90")]
	private DPAMIINLOFL(Task<(GameObject, AvatarItemMaterial)> PEBIPFJADEI, FMHOFFFMGIN<GameObject> PKFKBBEKJBJ, FMHOFFFMGIN<AvatarItemMaterial> DEJMDOGNHAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x68169A0", Offset = "0x68159A0", VA = "0x1868169A0")]
	public static DPAMIINLOFL GIGNPOIHFIA(AssetReference EGJKLBIJOOJ, [Optional] AssetReference ODNGAOHOGEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x6816EF0", Offset = "0x6815EF0", VA = "0x186816EF0", Slot = "11")]
	protected override IICDLNLFNKP NAOBMEPDGHG(Task<(GameObject, AvatarItemMaterial)> MAELDPCECFD)
	{
		return default(IICDLNLFNKP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x6816920", Offset = "0x6815920", VA = "0x186816920", Slot = "12")]
	protected override void DNKELGKLJFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x6816DC0", Offset = "0x6815DC0", VA = "0x186816DC0")]
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
			[Cpp2IlInjected.Token(Token = "0x40001F2")]
			public MaterialEntry entry;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001F3")]
			public string shaderNameToFind;

			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
			public CKBGOEIAGEF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x6815CB0", Offset = "0x6814CB0", VA = "0x186815CB0")]
			internal object HJMPFCOONGF()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0x6815F00", Offset = "0x6814F00", VA = "0x186815F00")]
			internal object JANPOMBIECN()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		private FMHOFFFMGIN<MaterialMapAsset> JNKGLDBBIBB;

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x6819EC0", Offset = "0x6818EC0", VA = "0x186819EC0")]
		public OAIODCBIFAP(FMHOFFFMGIN<MaterialMapAsset> JNKGLDBBIBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x6819DD0", Offset = "0x6818DD0", VA = "0x186819DD0", Slot = "11")]
		protected override Material[] NAOBMEPDGHG(Task<MaterialMapAsset> PEBIPFJADEI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x6819D70", Offset = "0x6818D70", VA = "0x186819D70", Slot = "12")]
		protected override void DNKELGKLJFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x6819AA0", Offset = "0x6818AA0", VA = "0x186819AA0")]
		private Material ACCFODFGECB(MaterialEntry NJHLAOJOAAM)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	private class HFLOAAJAOKM : NAEBCHGCLLJ<Task<Material[]>, Material[]>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		private List<FMHOFFFMGIN<Material>> PJJDBOLIJLO;

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x6817C50", Offset = "0x6816C50", VA = "0x186817C50")]
		public HFLOAAJAOKM(Task<Material[]> PEBIPFJADEI, List<FMHOFFFMGIN<Material>> PJJDBOLIJLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x6817C00", Offset = "0x6816C00", VA = "0x186817C00", Slot = "11")]
		protected override Material[] NAOBMEPDGHG(Task<Material[]> MAELDPCECFD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x6817AC0", Offset = "0x6816AC0", VA = "0x186817AC0", Slot = "12")]
		protected override void DNKELGKLJFP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	private static readonly ICJNMGNJFIN CAJBNIGHKAB;

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x6817CC0", Offset = "0x6816CC0", VA = "0x186817CC0")]
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
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		[AIILLFBIOKD(CKKEEFADMDD.Self, false, false, false)]
		[SerializeField]
		private SkinnedMeshRenderer skinnedMeshRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		[SerializeField]
		private int BoneWeightsDisplayStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		[SerializeField]
		private int BoneWeightsDisplayAmount;

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x681FC60", Offset = "0x681EC60", VA = "0x18681FC60")]
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
			[Cpp2IlInjected.Token(Token = "0x4000207")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000208")]
			public AsyncTaskMethodBuilder<FLPGAIHAKKN> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000209")]
			public FaceStyleSet <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400020A")]
			public int eyeBrows;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x400020B")]
			public int eye;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400020C")]
			public int mouth;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400020D")]
			private TaskAwaiter<FLPGAIHAKKN> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x6818380", Offset = "0x6817380", VA = "0x186818380", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x68186C0", Offset = "0x68176C0", VA = "0x1868186C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		public SymmetricalFaceFeature[] EyeBrows;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		public EyesFaceFeature[] Eyes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		public NoseFaceOption[] Noses;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		public FaceFeature[] Mouths;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		[Header("Default Values")]
		public SymmetricalFaceFeature DefaultEyeBrowsFeature;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		public EyesFaceFeature DefaultEyesFeature;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		public FaceFeature DefaultMouthFeature;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		private Dictionary<DONNKKJBKEB, SymmetricalFaceFeature> eyeBrowFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		private Dictionary<DONNKKJBKEB, EyesFaceFeature> eyeFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		private Dictionary<DONNKKJBKEB, NoseFaceOption> noseOptionsDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		private Dictionary<DONNKKJBKEB, FaceFeature> mouthFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		private readonly Dictionary<DONNKKJBKEB, int> featureToIndexMap;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		private FLPGAIHAKKN _defaultFaceStyle;

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		private bool dictionariesInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x6817A90", Offset = "0x6816A90", VA = "0x186817A90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x6817800", Offset = "0x6816800", VA = "0x186817800")]
		public FLPGAIHAKKN MKFDNIMNEHB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x6817850", Offset = "0x6816850", VA = "0x186817850")]
		[AsyncStateMachine(typeof(JFKJGDFKBLN))]
		public Task<FLPGAIHAKKN> NLFLDGCMPMB(int LDGGMLGGDPB, int IMFCOMGBCPB, int BBGLNIGMGED)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x6817760", Offset = "0x6816760", VA = "0x186817760")]
		public NoseFaceOption MGDLCKJFBDL(int GHHHOBGMPCM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x68171E0", Offset = "0x68161E0", VA = "0x1868171E0")]
		public SelectableFaceOption EGGPAHCJEBL(FaceFeatureType NIFKLDNIBPI, DONNKKJBKEB GDKGGKJFLIO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x6817980", Offset = "0x6816980", VA = "0x186817980")]
		public int PGPLBMGPLAM(DONNKKJBKEB GDKGGKJFLIO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x6817530", Offset = "0x6816530", VA = "0x186817530")]
		private void IMEJFICHPJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x2B118B0", Offset = "0x2B108B0", VA = "0x182B118B0")]
		private void JNIJOLFGHIA<T>(IDictionary<DONNKKJBKEB, T> OLGJECBHAKN, IReadOnlyList<T> HBMOMJIDJED) where T : SelectableFaceOption
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x6817360", Offset = "0x6816360", VA = "0x186817360")]
		public DONNKKJBKEB FNFAOKJFPNE(FaceFeatureType NIFKLDNIBPI)
		{
			return default(DONNKKJBKEB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x6817410", Offset = "0x6816410", VA = "0x186817410")]
		public DONNKKJBKEB GIOLIOMAHPJ(FaceFeatureType NIFKLDNIBPI)
		{
			return default(DONNKKJBKEB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x6817A00", Offset = "0x6816A00", VA = "0x186817A00")]
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
