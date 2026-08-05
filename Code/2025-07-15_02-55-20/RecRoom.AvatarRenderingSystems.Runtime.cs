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
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_AvatarRenderingSystems_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Preserve]
	public class LogRegistrationIndex : MMLLDFGFMPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7F2EE20", Offset = "0x7F2DA20", VA = "0x187F2EE20", Slot = "4")]
		public override void AMHLLDBNIFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA873F0", Offset = "0xA85FF0", VA = "0x180A873F0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA5B600", Offset = "0xA5A200", VA = "0x180A5B600", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override string AssetGUID
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x7F2F770", Offset = "0x7F2E370", VA = "0x187F2F770", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7F2F700", Offset = "0x7F2E300", VA = "0x187F2F700", Slot = "17")]
		public override bool RuntimeKeyIsValid()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7F2F730", Offset = "0x7F2E330", VA = "0x187F2F730")]
		public RecNetCDNAssetReference(RecNetCDNKey DHCHBFGMFFD)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class RecNetCDNKey
	{
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public enum GMGKJPMHBPA : byte
		{
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			Bundle,
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			Prefab,
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			MaterialMap
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public string BundleFilename
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xA5B540", Offset = "0xA5A140", VA = "0x180A5B540")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xA5B460", Offset = "0xA5A060", VA = "0x180A5B460")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public string UniqueItemIdentifier
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xA5B610", Offset = "0xA5A210", VA = "0x180A5B610")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xA5B740", Offset = "0xA5A340", VA = "0x180A5B740")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public string CacheHash
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xA5C790", Offset = "0xA5B390", VA = "0x180A5C790")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xA5C7A0", Offset = "0xA5B3A0", VA = "0x180A5C7A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RecNetCDNKey Dependency
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0xA5B5E0", Offset = "0xA5A1E0", VA = "0x180A5B5E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0xA683D0", Offset = "0xA66FD0", VA = "0x180A683D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool AttemptPrecacheLookup
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xA8A4F0", Offset = "0xA890F0", VA = "0x180A8A4F0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xA8A270", Offset = "0xA88E70", VA = "0x180A8A270")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public GMGKJPMHBPA PathHint
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xEF51A0", Offset = "0xEF3DA0", VA = "0x180EF51A0")]
			[CompilerGenerated]
			get
			{
				return default(GMGKJPMHBPA);
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x152DC00", Offset = "0x152C800", VA = "0x18152DC00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string ItemPath
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x7F2F880", Offset = "0x7F2E480", VA = "0x187F2F880")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7F2F800", Offset = "0x7F2E400", VA = "0x187F2F800")]
		public static RecNetCDNKey NPDKKKGKHJD(string ODOIBNFJMLN, GMGKJPMHBPA IAPEKBDJICH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7F2F7B0", Offset = "0x7F2E3B0", VA = "0x187F2F7B0")]
		public void LFNFDKCMFGB(string KHNJCBABADJ, string FNNEEIFKEML, bool HPHCDDICGJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public RecNetCDNKey()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[GOLNKMGDHKC]
public class JPOOFAHHJOG : IIAOEMEGNGH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	protected readonly List<Mesh> PMCCFCHOJEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	protected readonly List<byte[]> BIKIHBDNOAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	protected readonly List<Matrix4x4> PCGOJIEAMDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	protected readonly List<bool> FCBILHMCHAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	protected readonly List<long> AEFPCHDOFIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	protected readonly List<bool> BEKBOGJCNNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	protected readonly List<int> LBAMLCAGDFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	protected Allocator ONINDDJGFMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	protected CIHDENBNPKK LANNBMMDNEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	protected byte BKMJCBOFEID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	protected IList<int> ONNLFKGAPHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	protected IList<int> AMGMJNEEEBJ;

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7F2E430", Offset = "0x7F2D030", VA = "0x187F2E430", Slot = "4")]
	public void HLLLGCPPBKJ(Mesh MOGMOMKEFJC, Matrix4x4 AGGCBFLHHCC, byte[] OENGCFNKFPA, bool PHEEBAOLCIG = false, NHDGALDIFDN.IAHAFMDMEMA DAOHBBBBAMG = (NHDGALDIFDN.IAHAFMDMEMA)0L, int FCJLMCHKHKO = -1, bool HBKKCNIBIHO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7F2EA50", Offset = "0x7F2D650", VA = "0x187F2EA50", Slot = "5")]
	public void MEKGCOAEBFA(Allocator HPEAGMDCCBL, CIHDENBNPKK JEODCDOAHFC, byte CFAKMEJEFOK, [Optional] IList<int> MLFCBBDJIDF, [Optional] IList<int> FMBLNBOPKOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7F2E7F0", Offset = "0x7F2D3F0", VA = "0x187F2E7F0")]
	private static void JCJBPHCCOMG(Mesh MOGMOMKEFJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7F2EA90", Offset = "0x7F2D690", VA = "0x187F2EA90")]
	public JPOOFAHHJOG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[GOLNKMGDHKC]
public struct DMKIMBILDOC : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	[ReadOnly]
	public BKBAIPDEHOI LECKMIEDHJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	[ReadOnly]
	public int MKAIAOGLBGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public ENCGHKCHDJE IDAJGEAGCFO;

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7F28E30", Offset = "0x7F27A30", VA = "0x187F28E30", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[GOLNKMGDHKC]
[NativeContainer]
public struct ENCGHKCHDJE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct EACFLDBJBFO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public Vector3 MLGLFBJLONM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public Vector3 JMBLGBJKENI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public Vector4 OBHOGLNHLFB;
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct OCAPBLHFGHF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public float BPFOJPOGCJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public float MMFANOMHCOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public float ODEOMKBPFGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public float LHNNBDBOAOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public byte ONCDHNJMEBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public byte BFLBGBAOCKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public byte JJHPMDFJNAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public byte GPIOPBMDBNK;
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct ONAMENHODPE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public half BPFOJPOGCJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public half MMFANOMHCOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public half ODEOMKBPFGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public half LHNNBDBOAOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public byte ONCDHNJMEBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public byte BFLBGBAOCKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public byte JJHPMDFJNAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public byte GPIOPBMDBNK;
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct AMNIICLAOEB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public half4 MGBNCENPLKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public half2 LBCPMAFJAJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public half4 JNDOHFGBEEI;
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public struct PGFGOJBBBGB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public half4 MGBNCENPLKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public half2 LBCPMAFJAJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public half2 BNEEBCFCKLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public half4 JNDOHFGBEEI;
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct EFKBIFJDLLG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public half4 MGBNCENPLKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public half2 LBCPMAFJAJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public half2 BNEEBCFCKLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public half2 EMKELEJFNJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public half4 JNDOHFGBEEI;
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public struct DPKIEFHPNIP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public half4 MGBNCENPLKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public half2 LBCPMAFJAJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public half2 BNEEBCFCKLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public half2 EMKELEJFNJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public half2 AENFOFPJHOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public half4 JNDOHFGBEEI;
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public struct PAHGGOBNBFL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public float BPFOJPOGCJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public float MMFANOMHCOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public float ODEOMKBPFGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public float LHNNBDBOAOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public int ONCDHNJMEBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public int BFLBGBAOCKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public int JJHPMDFJNAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public int GPIOPBMDBNK;
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public struct JOHDIGLDBPG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public Color MGBNCENPLKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Vector2 LBCPMAFJAJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public Vector4 JNDOHFGBEEI;
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public struct NCDGCOBLNJI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public Color MGBNCENPLKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Vector2 LBCPMAFJAJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public Vector2 BNEEBCFCKLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public Vector4 JNDOHFGBEEI;
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public struct OBLJLIFMHEK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public Color MGBNCENPLKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public Vector2 LBCPMAFJAJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public Vector2 BNEEBCFCKLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public Vector2 EMKELEJFNJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public Vector4 JNDOHFGBEEI;
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public struct PEOIMKJGJNI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public Color MGBNCENPLKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public Vector2 LBCPMAFJAJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public Vector2 BNEEBCFCKLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public Vector2 EMKELEJFNJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public Vector2 AENFOFPJHOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public Vector4 JNDOHFGBEEI;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private bool DNBMJFBBNGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public NativeArray<EACFLDBJBFO> KGGFGEGFNPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public NativeArray<AMNIICLAOEB> PAIOBMGKJAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public NativeArray<PGFGOJBBBGB> LONHKJJFGMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public NativeArray<EFKBIFJDLLG> FOIOBLFKHLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public NativeArray<DPKIEFHPNIP> MJFEMFMILEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public NativeArray<ONAMENHODPE> GEGKPKIKMFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public NativeArray<OCAPBLHFGHF> DNLAEHBFPAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public NativeArray<JOHDIGLDBPG> PGKEDAJHIHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public NativeArray<NCDGCOBLNJI> ALGOEBEILCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public NativeArray<OBLJLIFMHEK> IFFNMPCPKED;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public NativeArray<PEOIMKJGJNI> GJGBIIAKPAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public NativeArray<PAHGGOBNBFL> GGKNOMJPIDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public NativeArray<int> OFMKHEFEDDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public NativeArray<int> ADIHIFDFOCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private NativeArray<int> NINBGEHKLIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private NativeArray<int> PJDJOCNBJGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public NativeArray<int> OHHHFHKAHDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public NativeArray<int> EEDBABGHMMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public NativeArray<int> HLFKPKDFCAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public NativeArray<BoneWeight> LKOOEPLBLMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private NativeArray<int> KCHMACEBLIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private bool EBDOLIOMNJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x159")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private bool JBJJEMCJKGN;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int NPMCBCLAGMD
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x7F2ABA0", Offset = "0x7F297A0", VA = "0x187F2ABA0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x7F2B930", Offset = "0x7F2A530", VA = "0x187F2B930")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int OPHBNHMKJGG
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7F2AE10", Offset = "0x7F29A10", VA = "0x187F2AE10")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7F2B920", Offset = "0x7F2A520", VA = "0x187F2B920")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int EFACGIELDOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7F2B6C0", Offset = "0x7F2A2C0", VA = "0x187F2B6C0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7F2AA90", Offset = "0x7F29690", VA = "0x187F2AA90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int BONMJNGHFDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7F2AA20", Offset = "0x7F29620", VA = "0x187F2AA20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7F2D260", Offset = "0x7F2BE60", VA = "0x187F2D260")]
	public ENCGHKCHDJE(int FDEGOECNNNM, int PPDBPOMPAJL, int PENEHGLCKEK, int LAAAPBPPHAE, Allocator HPEAGMDCCBL, int BBELGJAFHEO, CKFJELELPPB AHOKEJGAKDJ, bool EBDOLIOMNJA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7F2C1E0", Offset = "0x7F2ADE0", VA = "0x187F2C1E0")]
	public void JJHHEEDJLGF(int LCCBBMBENOH, Vector3 DNDKHMOJDEM, Vector3 PJNOJDKODDG, Vector4 KJCIKLJPCMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7F2B290", Offset = "0x7F29E90", VA = "0x187F2B290")]
	public void EKOCPLPMAAF(int LCCBBMBENOH, BoneWeight FGAEPMDENBL, NativeSlice<byte> OENGCFNKFPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7F2BEC0", Offset = "0x7F2AAC0", VA = "0x187F2BEC0")]
	public Color INMDDAGLBGP(int LCCBBMBENOH)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7F2B940", Offset = "0x7F2A540", VA = "0x187F2B940")]
	public void GIEPEMIMDLD(int LCCBBMBENOH, Color FBNAMAEDFNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7F2AAB0", Offset = "0x7F296B0", VA = "0x187F2AAB0")]
	public void BDAKPNBDNCA(int LCCBBMBENOH, Vector3 ALEIFNEHIBI, Vector3 CKJNEBCCDKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7F2BD70", Offset = "0x7F2A970", VA = "0x187F2BD70")]
	public void ILJGHOCDIHB(int LCCBBMBENOH, half4 LNIHNHKOFMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7F2B6D0", Offset = "0x7F2A2D0", VA = "0x187F2B6D0")]
	public void FOHHDBHDPBO(int LCCBBMBENOH, Vector3 LNIHNHKOFMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7F2AE20", Offset = "0x7F29A20", VA = "0x187F2AE20")]
	public void EDPPIGIGKFB(byte OCDBEFKJAKH, int LCCBBMBENOH, Vector2 LNIHNHKOFMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7F2AAA0", Offset = "0x7F296A0", VA = "0x187F2AAA0")]
	public void ALLNNHBLLFC(int LCCBBMBENOH, int NKKILGHIOCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7F2B230", Offset = "0x7F29E30", VA = "0x187F2B230")]
	public bool EEIKEMENNBE(int OCDBEFKJAKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7F2C270", Offset = "0x7F2AE70", VA = "0x187F2C270")]
	public void LMMDPIGGNDJ(int GMFCHOAKAHH, int HDEKJKJDEIC, int LBLBECEIAEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x7F2ABB0", Offset = "0x7F297B0", VA = "0x187F2ABB0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7F2C340", Offset = "0x7F2AF40", VA = "0x187F2C340")]
	public Mesh ONBOOKGGHEM([Optional] string GLANGCJHONP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[DefaultMember("Item")]
[GOLNKMGDHKC]
[NativeContainer]
public struct BKBAIPDEHOI : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public Mesh.MeshDataArray HEFHEKEHMEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public NativeArray<int> LDCNOJLLBCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public NativeArray<int> IFPJCCPPHLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public NativeArray<BoneWeight> LKOOEPLBLMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private NativeArray<Matrix4x4> GKJCBAAGPAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private NativeArray<long> IFKODOKBPPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private NativeArray<byte> LOLFHDBBALD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private NativeArray<int> CAAKPCMIDNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private NativeArray<int> PHCHHLNHKJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public NativeArray<sbyte> NAEDFFKKLJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public NativeArray<byte> HDDAJICHGFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public NativeArray<bool> HBKKCNIBIHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public NativeArray<int> FCJLMCHKHKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private bool EBDOLIOMNJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private NativeArray<int> PKEIHKFCLGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private bool JBJJEMCJKGN;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int BFNDCKAAMNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x7F27B20", Offset = "0x7F26720", VA = "0x187F27B20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int FNCDLKAOJIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x7F27B00", Offset = "0x7F26700", VA = "0x187F27B00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int MIALMPOLHDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x7F27B30", Offset = "0x7F26730", VA = "0x187F27B30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int NNHHOKMJLIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7F27AD0", Offset = "0x7F266D0", VA = "0x187F27AD0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7F27AF0", Offset = "0x7F266F0", VA = "0x187F27AF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int NPMCBCLAGMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7F275E0", Offset = "0x7F261E0", VA = "0x187F275E0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7F27780", Offset = "0x7F26380", VA = "0x187F27780")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public int HFIJOOBMAIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7F275D0", Offset = "0x7F261D0", VA = "0x187F275D0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7F27870", Offset = "0x7F26470", VA = "0x187F27870")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public CIHDENBNPKK KMCGENJPOPE
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7F27860", Offset = "0x7F26460", VA = "0x187F27860")]
		get
		{
			return default(CIHDENBNPKK);
		}
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x7F27770", Offset = "0x7F26370", VA = "0x187F27770")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public byte AAMLILPHCEG
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7F27AE0", Offset = "0x7F266E0", VA = "0x187F27AE0")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7F27B10", Offset = "0x7F26710", VA = "0x187F27B10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public JBKKHJBKNKD KLGHGIBKAEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7F27880", Offset = "0x7F26480", VA = "0x187F27880")]
		get
		{
			return default(JBKKHJBKNKD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7F27C00", Offset = "0x7F26800", VA = "0x187F27C00")]
	public BKBAIPDEHOI(IList<Mesh> PFMMCJLNKMP, IList<Matrix4x4> CGOAFHICCJA, IList<bool> HBKKCNIBIHO, byte CFAKMEJEFOK, IList<byte[]> KMMHKDJPAPI, IList<long> DCDBAIBOLNB, IList<bool> BNJPDHPFJND, IList<int> FCJLMCHKHKO, IList<int> MLFCBBDJIDF, IList<int> DBBCEJMJCPB, Allocator HPEAGMDCCBL, CIHDENBNPKK JEODCDOAHFC, bool EBDOLIOMNJA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x7F27790", Offset = "0x7F26390", VA = "0x187F27790")]
	public ENCGHKCHDJE GELAAMKDFIA(Allocator HPEAGMDCCBL, CKFJELELPPB AHOKEJGAKDJ)
	{
		return default(ENCGHKCHDJE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x7F275F0", Offset = "0x7F261F0", VA = "0x187F275F0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[GOLNKMGDHKC]
public class MBAANKFFHBO : JPOOFAHHJOG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public bool JEDNBCNOPKH;

	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private static readonly ProfilerMarker JFKMGEJILOA;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7F2EEB0", Offset = "0x7F2DAB0", VA = "0x187F2EEB0")]
	public BKBAIPDEHOI IOHPCLNJLFF()
	{
		return default(BKBAIPDEHOI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7F2F170", Offset = "0x7F2DD70", VA = "0x187F2F170")]
	public MBAANKFFHBO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct JBKKHJBKNKD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public Mesh.MeshData JONJFPDFHKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public NativeSlice<BoneWeight> LKOOEPLBLMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public NativeSlice<byte> CLDNCAONLIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public int MEJIMPLIMGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public Matrix4x4 HNHBGNAKGOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public long FIDCIFKDNCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public NativeSlice<byte> OENGCFNKFPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public bool JGCCDILKJJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public int JFCDAPIFIHM;
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class AGFBOOANFCD : FNKBCEMJFAH
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class EBLEJACBMDD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public bool hideTorsoInFirstPersonBeanMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public AGFBOOANFCD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public BNKNLGMMDLE buildMeshPromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public Action<KeyValuePair<string, MNDBKMIALLI<Texture2D>>> <>9__19;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public EBLEJACBMDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x7F2A9E0", Offset = "0x7F295E0", VA = "0x187F2A9E0")]
		internal bool NAFDJOGGKAB(BOBAHFBAFHA item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x7F2A990", Offset = "0x7F29590", VA = "0x187F2A990")]
		internal void LGPMGGEMHDB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x7F2A7C0", Offset = "0x7F293C0", VA = "0x187F2A7C0")]
		internal void DKMLKIKICLK(string err)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x7F2A990", Offset = "0x7F29590", VA = "0x187F2A990")]
		internal void NGOCFFODMCG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x7F2A7C0", Offset = "0x7F293C0", VA = "0x187F2A7C0")]
		internal void ANPGMBHNHEN(string err)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x7F2A9B0", Offset = "0x7F295B0", VA = "0x187F2A9B0")]
		internal void MIMCLCBDMPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x7F2A960", Offset = "0x7F29560", VA = "0x187F2A960")]
		internal void LBCJPIIHNNJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x7F2A8A0", Offset = "0x7F294A0", VA = "0x187F2A8A0")]
		internal void KGAFOMGJHOF(Dictionary<string, MNDBKMIALLI<Texture2D>> resourceHandleDictionary)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x7F2A7E0", Offset = "0x7F293E0", VA = "0x187F2A7E0")]
		internal void IMJADEPHDEJ(KeyValuePair<string, MNDBKMIALLI<Texture2D>> kvp)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0xA5C790", Offset = "0xA5B390", VA = "0x180A5C790")]
		internal IPNMFPLCPOG FJOAIMCAIGN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class LGLMOIDEANK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public int lowestPossibleLOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public EBLEJACBMDD CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public LGLMOIDEANK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x7F2ED60", Offset = "0x7F2D960", VA = "0x187F2ED60")]
		internal IOGHDLDCNOM PCEHJAMBOCC(int lod)
		{
			return default(IOGHDLDCNOM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class JJPADCGIOHC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public AIDGEFHMIOM<Dictionary<string, MNDBKMIALLI<Texture2D>>> ugcTextureDictionaryPromise;

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public JJPADCGIOHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0xA5B540", Offset = "0xA5A140", VA = "0x180A5B540")]
		internal AIDGEFHMIOM<Dictionary<string, MNDBKMIALLI<Texture2D>>> IJKBHGGKHPB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class FKIFHBJDPOE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public List<BNKNLGMMDLE> innerPromises;

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public FKIFHBJDPOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x7F2DC90", Offset = "0x7F2C890", VA = "0x187F2DC90")]
		internal void OBKNFBPPLOG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class PLDBKBKCIHK : IEnumerator<LIPOFPKAEIK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private LIPOFPKAEIK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public bool shouldWait;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public AGFBOOANFCD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public List<GDCGFICBEBL> parts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public List<BNKNLGMMDLE> innerPromises;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public int[] LODs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public bool isFirstPerson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public Func<int, IOGHDLDCNOM> getLayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public CDFCEBFFOBN materialPropertyBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public Material materialInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private int <lodIndex>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		private LIPOFPKAEIK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0xA5B610", Offset = "0xA5A210", VA = "0x180A5B610", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0xA5B610", Offset = "0xA5A210", VA = "0x180A5B610", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0xA62C00", Offset = "0xA61800", VA = "0x180A62C00")]
		[DebuggerHidden]
		public PLDBKBKCIHK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x7F2F430", Offset = "0x7F2E030", VA = "0x187F2F430", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x7F2F6B0", Offset = "0x7F2E2B0", VA = "0x187F2F6B0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class DKHBMCCJOAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public EICDEAMHLEB cancelable;

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public DKHBMCCJOAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0xB95AF0", Offset = "0xB946F0", VA = "0x180B95AF0")]
		internal void HHFBAKOIIMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0xE0C330", Offset = "0xE0AF30", VA = "0x180E0C330")]
		internal void AMGFJEDBAJH(string err)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class IHBPEMFFJLH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public long jobComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public Stopwatch stopwatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public SkinnedMeshRenderer lodRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public long meshComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public string meshName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public long meshCopyComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public AGFBOOANFCD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public int lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public List<Material> newUniqueMaterials;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public List<(int mat, int part)> avatarItemMaterialPartIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public List<Bounds> avatarPartMeshBounds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public int frameStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public long lodBuildStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public long startCombineBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public long jobScheduled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public Action onFinally;

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public IHBPEMFFJLH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class GJCMFHCJIEM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public bool waitingForComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public JobHandle lodBuildJobHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public ENCGHKCHDJE defaultMeshJobContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public BKBAIPDEHOI defaultAvatarMeshJobGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public IHBPEMFFJLH CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public GJCMFHCJIEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x7F2DDC0", Offset = "0x7F2C9C0", VA = "0x187F2DDC0")]
		internal void EMKMFFALHFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x7F2E3C0", Offset = "0x7F2CFC0", VA = "0x187F2E3C0")]
		internal void FKMLEENCLLK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class PAEOOHLFBHC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public bool waitingForComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public JobHandle lodBuildJobHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public MGCOBNNGKEB legacyMeshJobContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public CHOKCAPIBKL legacyAvatarMeshJobGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		public IHBPEMFFJLH CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public PAEOOHLFBHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x7F2F1F0", Offset = "0x7F2DDF0", VA = "0x187F2F1F0")]
		internal void FINOCDPHGAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x7F2F180", Offset = "0x7F2DD80", VA = "0x187F2F180")]
		internal void EHPLKAOJOIE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class BKOAAJHLCMJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		public AGFBOOANFCD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public float power;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public Color color;

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public BKOAAJHLCMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x7F28DF0", Offset = "0x7F279F0", VA = "0x187F28DF0")]
		internal void DPLJLPANJCG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class KAOGGLCFPAF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public string overrideItemIdentifier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public FMEODGEFBMO overrideBodyPart;

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public KAOGGLCFPAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x7F2ECE0", Offset = "0x7F2D8E0", VA = "0x187F2ECE0")]
		internal bool JACOMJHDHLG(KeyValuePair<string, BOBAHFBAFHA> entry)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly LKKDMOCNJPN AMFAOGLGJHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly LKKDMOCNJPN DMBDDONEHHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private Dictionary<DCFGNKIDBKM, float> FCBKBJHLHPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private Dictionary<PDFDLMPFEHI, float> EAOPFEEOAKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private Dictionary<MCAPBNLLBJK, float> BIKPEJBBBFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private IReadOnlyDictionary<string, HAOIKOHICEG> HNBNDPHBLBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private Dictionary<string, HAOIKOHICEG> BNKEONGMPOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private Dictionary<string, HAOIKOHICEG> DMMNGKLICBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private Dictionary<string, HAOIKOHICEG> HINIGBKFLFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private NMCGFIKJCCM NHOJGPGLIHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private NMCGFIKJCCM FDCDLBFEBHI;

	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private static float MNOHMOPPNCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private bool? CLGBEFBBAFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x62")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private bool? ALEGGCLGGDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private bool? KFICPDEEAKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x66")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private bool? ACBJMKAHOKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private AvatarConfiguration GPIPPOFMEDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private Transform CAHFDMNNBPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private AvatarSkinAssetItem LMPFJCGAPOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private AssetReference ICFOJFILLFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private GameObject CBKHLAJIJKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private GameObject BBPLGDFGDFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private SkinnedMeshRenderer EHJGKMOHNAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private AvatarSkinnedMeshBoneOrderRemapsData BPBDPAOEOOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private Transform[] FNCDOGHALFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private Matrix4x4[] BOJFHGCIMPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private Material JDNMFLGPMLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private Material JCLOMBKEOBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private Material GGKJPJGMBOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private Material OHNMFOCKPNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private Shader HADMJEBCOND;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private Shader DNGLNBPIFLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private Animator HLBDDPFFPOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private Renderer[] LKENHPNNPKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private NHDGALDIFDN.IAHAFMDMEMA IKBBDPNNHIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private AvatarBodyPartShapesManager EFNLMDIDJIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private IReadOnlyDictionary<string, Transform> GHMLPGNMLHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private AvatarFaceShapeData.ABONKBOCFKJ DKBGCCAEOPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x114")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private AvatarBodyShapeData.OGNJNJLKBGM MMKFEHOAKJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private OMJMBFKGAHG ECPNBBMBEJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private bool HHCGBPCDCJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11D")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private bool MEBGOLOCOFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private Color GCKKBBINDDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private Color BADADKNOEMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private Color IGDCFOLHKMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private Color? JIJPGPFEPOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x164")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private Color? DAPEIGJLFPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private Color? NKPCBAMHEME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18C")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private Color? GLJCECPPLMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private Texture2D HLBDAHGLHFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private Texture2D JMJKIFEEOJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	[CanBeNull]
	private BOBAHFBAFHA NLKFBPLKJDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private Texture MEEFOIGLOPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private Color BBKJAIDBKEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public Dictionary<Renderer, CDFCEBFFOBN> MCACHPHHBPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private Dictionary<Renderer, CDFCEBFFOBN> HCNPFNPKEOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private Dictionary<string, List<DFBBPKLEGFN>> EAKDKOLNPEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private Dictionary<string, List<DFBBPKLEGFN>> OMIPIOHDLEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private readonly List<IGJFGOMAIOE> DOEIELABGGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private readonly List<IGJFGOMAIOE> AEHMIKCOPHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private readonly List<IGJFGOMAIOE> MNEJINGOPJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private readonly List<IGJFGOMAIOE> GIFGMGOCOHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private Dictionary<DFBBPKLEGFN, Material> CPLAAMNEONK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private Dictionary<DFBBPKLEGFN, Material> HPEDEMOJFJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private SkinnedMeshRenderer[] FBDGGBOINAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private SkinnedMeshRenderer[] GOJEMDOKBPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private SkinnedMeshRenderer[] BODJDBFNALA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private SkinnedMeshRenderer[] OEGHHJPINID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private readonly Dictionary<string, MNDBKMIALLI<Texture2D>> MGPMAPIGDCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private readonly Dictionary<string, MNDBKMIALLI<Texture2D>> NOAFIHNHFMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private AdditionalHatData CBMMJFDMCPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private AdditionalHatData OIJJKMNBPAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private HairData PMFJKFIIPJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private HairData KMPBNPOAMHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private PBOEGNLEBIG ONBFPCIGHHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private bool? JBMAMCDMFIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x27C")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private PositionAndRotation OAHHAJHDCPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private Transform EAEADNPBNAE;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private Material EODNGGLKPBK;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private Material PBGFLKCODAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B0")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private Dictionary<string, BOBAHFBAFHA> KGMFMIOIBMJ;

	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private static readonly int GFNGAELJNJA;

	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private static readonly int KFHPJCBCJKI;

	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private static readonly int KADICJBJDBJ;

	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private static readonly int ICBBCCIHNMD;

	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private static readonly int JKAOCIHKLIN;

	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private static readonly int EBJPPHJFLPF;

	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private static readonly int PEJDOOIDFPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B8")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private bool KGAGIHFAIPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C0")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private List<Action> HPNKHAKHADG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private JNFHAACMDFI OKBFFLLEDMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D0")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private SkinnedMeshRenderer[] HDPFNMPIDPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D8")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private int GPNBGLJBMFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2DC")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private bool AGEHDJOOILH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E0")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private int LMNOJBCHKOG;

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public LKKDMOCNJPN NNKKDEMOGKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xA5B540", Offset = "0xA5A140", VA = "0x180A5B540", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public LKKDMOCNJPN FFDMLGGKODC
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0xA5B610", Offset = "0xA5A210", VA = "0x180A5B610", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private CEDFNINGHPN NCAMCGOHDNP
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x7F19DA0", Offset = "0x7F189A0", VA = "0x187F19DA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	private bool EACJLBBDADM
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x7F1BE90", Offset = "0x7F1AA90", VA = "0x187F1BE90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	private bool FKHFJNLDFMK
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x7F1E3A0", Offset = "0x7F1CFA0", VA = "0x187F1E3A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	private bool PBJMKLICLPL
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x7F20870", Offset = "0x7F1F470", VA = "0x187F20870")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	private bool CGBCEBFKJLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x7F23580", Offset = "0x7F22180", VA = "0x187F23580")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public AvatarConfiguration DAFCNNGLNKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0xA5B760", Offset = "0xA5A360", VA = "0x180A5B760", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool OANPDJODHDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x1324230", Offset = "0x1322E30", VA = "0x181324230")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x13251B0", Offset = "0x1323DB0", VA = "0x1813251B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	private Material OPGEABNGJAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7F20B30", Offset = "0x7F1F730", VA = "0x187F20B30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	private Material HFFNLCCLBEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x7F20A00", Offset = "0x7F1F600", VA = "0x187F20A00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	private bool GNCFPAHIKAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0xA77810", Offset = "0xA76410", VA = "0x180A77810")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public ADAOAPJGFHC FBPJOCLKPHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x2508C40", Offset = "0x2507840", VA = "0x182508C40", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return default(ADAOAPJGFHC);
		}
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x7F23570", Offset = "0x7F22170", VA = "0x187F23570")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public Material OEMMDDLGBJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xB0CA20", Offset = "0xB0B620", VA = "0x180B0CA20", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public SkinnedMeshRenderer[] FHFFPLFMJAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x1B26740", Offset = "0x1B25340", VA = "0x181B26740", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public Renderer[] DJNHHGJEFEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0xAD34F0", Offset = "0xAD20F0", VA = "0x180AD34F0", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool GECKKJICLCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7F1BF70", Offset = "0x7F1AB70", VA = "0x187F1BF70", Slot = "22")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public NHDGALDIFDN.IAHAFMDMEMA MDDGJIMHHIG
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xAE08B0", Offset = "0xADF4B0", VA = "0x180AE08B0", Slot = "20")]
		get
		{
			return default(NHDGALDIFDN.IAHAFMDMEMA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public int ECDOFPEMKIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x2509330", Offset = "0x2507F30", VA = "0x182509330")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x7F1BC30", Offset = "0x7F1A830", VA = "0x187F1BC30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	private bool BKININEMAAD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x7F1B370", Offset = "0x7F19F70", VA = "0x187F1B370")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	private static bool HMCFKGDAOCE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0xAA76B0", Offset = "0xAA62B0", VA = "0x180AA76B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7F24810", Offset = "0x7F23410", VA = "0x187F24810", Slot = "15")]
	public BNKNLGMMDLE MIBOCIJFLDO(NOJJHAAHIJD FBPNCEHNJEI, bool ABGFJHENDNP, int[] IBCGOKACOGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7F1FAC0", Offset = "0x7F1E6C0", VA = "0x187F1FAC0", Slot = "14")]
	public BNKNLGMMDLE GFFHKBNHFGI(NOJJHAAHIJD FBPNCEHNJEI, bool ABGFJHENDNP, int[] IBCGOKACOGJ, Func<Dictionary<string, BOBAHFBAFHA>, (BNKNLGMMDLE, AIDGEFHMIOM<Dictionary<string, MNDBKMIALLI<Texture2D>>>)> JIHIBFHMALD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7F21960", Offset = "0x7F20560", VA = "0x187F21960")]
	public BNKNLGMMDLE KFJIIJFKJMG(NOJJHAAHIJD FBPNCEHNJEI, bool ABGFJHENDNP, int[] IBCGOKACOGJ, bool KKHOBAFGFLD, NMCGFIKJCCM JGLNBHFJCJB, [Optional] Func<Dictionary<string, BOBAHFBAFHA>, (BNKNLGMMDLE, AIDGEFHMIOM<Dictionary<string, MNDBKMIALLI<Texture2D>>>)> JIHIBFHMALD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7F20350", Offset = "0x7F1EF50", VA = "0x187F20350")]
	private bool HCAFMIACPBH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7F19520", Offset = "0x7F18120", VA = "0x187F19520")]
	private BNKNLGMMDLE ACOKGMHFMAD(bool ABGFJHENDNP, List<GDCGFICBEBL> BHBMBFBOLDA, int[] IBCGOKACOGJ, Func<int, IOGHDLDCNOM> NKNBAIIKHBL, bool KKHOBAFGFLD = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7F20CD0", Offset = "0x7F1F8D0", VA = "0x187F20CD0")]
	[IteratorStateMachine(typeof(PLDBKBKCIHK))]
	private IEnumerator<LIPOFPKAEIK> IJHKLINOMMP(bool ABGFJHENDNP, List<GDCGFICBEBL> BHBMBFBOLDA, int[] IBCGOKACOGJ, Func<int, IOGHDLDCNOM> NKNBAIIKHBL, CDFCEBFFOBN PMNNKJEDBDM, Material PAODGAKGKGP, List<BNKNLGMMDLE> CEGIJECICEC, bool IOBLNEBHEAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7F23B00", Offset = "0x7F22700", VA = "0x187F23B00")]
	private void LPOEIDBHKAL(List<GDCGFICBEBL> BHBMBFBOLDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7F1E480", Offset = "0x7F1D080", VA = "0x187F1E480")]
	private BNKNLGMMDLE FNAGMELAAED(List<GDCGFICBEBL> BHBMBFBOLDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7F1E800", Offset = "0x7F1D400", VA = "0x187F1E800")]
	private CCGDPHBOCPE GFDOONHAPBE(List<GDCGFICBEBL> BHBMBFBOLDA, int LGKJAMKLNMC, bool ABGFJHENDNP, IOGHDLDCNOM JJKFIBNFCFA, bool FMLLJJDCNHC, CDFCEBFFOBN PMNNKJEDBDM, Material PAODGAKGKGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7F238E0", Offset = "0x7F224E0", VA = "0x187F238E0", Slot = "27")]
	public void KLCEGNBLNKA(DCFGNKIDBKM KPOCAAGAJEK, float BKMPCFIAHIG, bool LAPCJMHOMHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x7F25BC0", Offset = "0x7F247C0", VA = "0x187F25BC0", Slot = "29")]
	public void PPDALCBNMAH(PDFDLMPFEHI DDMBBEGJJML, float BKMPCFIAHIG, bool GILOBBBMGNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7F21870", Offset = "0x7F20470", VA = "0x187F21870", Slot = "30")]
	public void KDPBIGBIMKF(MCAPBNLLBJK GKJCGJOJIAD, float BKMPCFIAHIG, bool ADFALAOOCAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7F25550", Offset = "0x7F24150", VA = "0x187F25550", Slot = "28")]
	public void PDGLCEMNFCP(bool BBAEFNBOBNF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7F1D6B0", Offset = "0x7F1C2B0", VA = "0x187F1D6B0", Slot = "31")]
	public void EFGMALMBDMG(bool BBAEFNBOBNF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x7F24FC0", Offset = "0x7F23BC0", VA = "0x187F24FC0", Slot = "32")]
	public void OFEBCGLKCBJ(bool BBAEFNBOBNF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7F1A8D0", Offset = "0x7F194D0", VA = "0x187F1A8D0")]
	private void BJEKNLJGFLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7F1FEF0", Offset = "0x7F1EAF0", VA = "0x187F1FEF0")]
	private void GINHNGJPPNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7F20980", Offset = "0x7F1F580", VA = "0x187F20980")]
	private void IDBJAPAKGBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7F239C0", Offset = "0x7F225C0", VA = "0x187F239C0", Slot = "25")]
	public void LAJKKBJCEPE(AvatarFaceShape ANAIHICIJOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7F20430", Offset = "0x7F1F030", VA = "0x187F20430", Slot = "26")]
	public void HJDOKEKIFAJ(AvatarBodyShape IFPCBPCNGDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0xBACCF0", Offset = "0xBAB8F0", VA = "0x180BACCF0", Slot = "33")]
	public void BNBBKEJBOHL(OMJMBFKGAHG AIAONFGMGDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7F1FF70", Offset = "0x7F1EB70", VA = "0x187F1FF70", Slot = "35")]
	public void GMIILOJELGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7F1D710", Offset = "0x7F1C310", VA = "0x187F1D710", Slot = "39")]
	public void EGENENNMIJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7F20420", Offset = "0x7F1F020", VA = "0x187F20420", Slot = "34")]
	public void HFCHKEPGDJN(bool MAONCNPJPCP, bool IILENLBNOIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7F1AE50", Offset = "0x7F19A50", VA = "0x187F1AE50")]
	private void BOOCHEFOBPP(SkinnedMeshRenderer LPLKJGCPALF, int LGKJAMKLNMC, Mesh MOGMOMKEFJC, List<Material> NPBCLNJJNFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7F24350", Offset = "0x7F22F50", VA = "0x187F24350")]
	private static Material MGELHNKPKAB(Dictionary<DFBBPKLEGFN, Material> JNDJCHENOOC, Material MANGCODLEBB, PFJLDMNPOID NJNJPMCMHDI, IGNDKCMOLEC CGBIMBKLAJP, FMEODGEFBMO DAMAHFKHDCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x7F25020", Offset = "0x7F23C20", VA = "0x187F25020")]
	private static PFJLDMNPOID OFJJFAKLCMK(GDCGFICBEBL EJKFLMLHEOC, int MOJLJLLOHPM)
	{
		return default(PFJLDMNPOID);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7F212E0", Offset = "0x7F1FEE0", VA = "0x187F212E0")]
	private void JIKLLFNCMDN(int EFJMIKDMGKB, Material CIBNABIMGCK, GDCGFICBEBL EJKFLMLHEOC, [Out] Texture2D NDOJGACHKLP, [Out] Vector4 EPOCDOIKENA, [Out] Texture2D LGHKNNNOBPH, [Out] Texture2D JKINGFDFOPA, [Out] Texture2D HIFJDNHMKNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x7F25640", Offset = "0x7F24240", VA = "0x187F25640")]
	private void PELPOINBMML(int EFJMIKDMGKB, Material CIBNABIMGCK, GDCGFICBEBL EJKFLMLHEOC, [Out] Color HFDHMLDHBON, [Out] Color PKGKBHAFMOB, [Out] Color NCPNPPFPDAJ, [Out] Color MJPALICOCKK, [Out] Color LFBJGGGMMJK, [Out] Color CNKHHILNLEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x7F25120", Offset = "0x7F23D20", VA = "0x187F25120")]
	private bool OHKEMJFNKKK(Material CIBNABIMGCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7F1BBB0", Offset = "0x7F1A7B0", VA = "0x187F1BBB0")]
	private static Material CHKGGIANNBC(int EFJMIKDMGKB, BLHKKPAJCBC EJKFLMLHEOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7F20790", Offset = "0x7F1F390", VA = "0x187F20790")]
	private static IGNDKCMOLEC HMDJDKGBIDC(GDCGFICBEBL EJKFLMLHEOC, int MOJLJLLOHPM)
	{
		return default(IGNDKCMOLEC);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x7F204F0", Offset = "0x7F1F0F0", VA = "0x187F204F0")]
	private static void HJODONPGKFP(Dictionary<string, List<DFBBPKLEGFN>> LDOBEDEHEFO, GDCGFICBEBL NBMLCPEJJIP, Material MANGCODLEBB, PFJLDMNPOID JJPCHCCDGCE, IGNDKCMOLEC LMHDEPDIPLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x7F19FC0", Offset = "0x7F18BC0", VA = "0x187F19FC0")]
	private static SkinnedMeshRenderer BDHCIPPOHOJ(Transform LAFOBEFHNEJ, Transform MOIBADKMOAJ, SkinnedMeshRenderer[] ADNAIABIPDJ, int LGKJAMKLNMC, IOGHDLDCNOM JJKFIBNFCFA, bool ABGFJHENDNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7F26080", Offset = "0x7F24C80", VA = "0x187F26080")]
	public AGFBOOANFCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7F1A1F0", Offset = "0x7F18DF0", VA = "0x187F1A1F0")]
	public void BFHPBJMBKJO([In] IEOHPGBAIFH KJHNKALINND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x7F1DED0", Offset = "0x7F1CAD0", VA = "0x187F1DED0")]
	public void JBBPFHBHKPK([In] GACEJPGCMAE POHEOEEDHDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x7F1BC30", Offset = "0x7F1A830", VA = "0x187F1BC30", Slot = "5")]
	public void HFFHEFAPHDD(int LGKJAMKLNMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x7F19B00", Offset = "0x7F18700", VA = "0x187F19B00", Slot = "10")]
	public void AGECPHEIPFG(KALIHJLPFKP LMHDEPDIPLN, Texture2D PMMGDHEEDKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0xA77810", Offset = "0xA76410", VA = "0x180A77810")]
	public static bool POALFHKOPPO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7F244B0", Offset = "0x7F230B0", VA = "0x187F244B0", Slot = "11")]
	public bool MGGCGKBPAAB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x7F1FAF0", Offset = "0x7F1E6F0", VA = "0x187F1FAF0", Slot = "9")]
	public void GFGHMNGGOEK(CLGFPHECMLG JJPCHCCDGCE, Color? MGBNCENPLKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x7F24120", Offset = "0x7F22D20", VA = "0x187F24120")]
	private void MDOOCONJECI(Action DNNKHPBBOPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x7F23A80", Offset = "0x7F22680", VA = "0x187F23A80", Slot = "6")]
	public void LAKJOLFNPPK(BOBAHFBAFHA LMELNLPCMEL, Texture FBEDCNIPFDH, Color OHMBGOPDDKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x13251B0", Offset = "0x1323DB0", VA = "0x1813251B0", Slot = "7")]
	public void AAKILOKOCOC(bool IOBLNEBHEAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x1EAD940", Offset = "0x1EAC540", VA = "0x181EAD940", Slot = "8")]
	public void FHACBCHNCJO(JNFHAACMDFI KCHMACEBLIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x7F1D1A0", Offset = "0x7F1BDA0", VA = "0x187F1D1A0", Slot = "16")]
	public void EBAJMGOOAMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x7F24840", Offset = "0x7F23440", VA = "0x187F24840", Slot = "36")]
	public void MNJBHFDFHGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x7F1C350", Offset = "0x7F1AF50", VA = "0x187F1C350", Slot = "37")]
	public void DMHJFMCNIFK([Optional] PBOEGNLEBIG KOHBJCLJEFM, [Optional] bool? LGCLICGPADC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x7F193E0", Offset = "0x7F17FE0", VA = "0x187F193E0")]
	private bool AAIOAPPACGH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x7F25530", Offset = "0x7F24130", VA = "0x187F25530", Slot = "21")]
	public bool OLJKCAOACEI(NHDGALDIFDN.IAHAFMDMEMA APHDODEPNMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x7F25CA0", Offset = "0x7F248A0", VA = "0x187F25CA0", Slot = "38")]
	public void PPMCHDBDPMN(float LBJEICFFMFJ, Color MGBNCENPLKH, bool PPIPMBMEHLK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x7F1B3F0", Offset = "0x7F19FF0", VA = "0x187F1B3F0")]
	public void CALHKJHFNBN(float LBJEICFFMFJ, Color MGBNCENPLKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x7F216F0", Offset = "0x7F202F0", VA = "0x187F216F0")]
	private static bool JOANNCEEMJH(Material PAODGAKGKGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x7F1A590", Offset = "0x7F19190", VA = "0x187F1A590")]
	private void BGHJHJMIDEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x7F1DEC0", Offset = "0x7F1CAC0", VA = "0x187F1DEC0")]
	private void ENMOMJKFLDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x7F1D550", Offset = "0x7F1C150", VA = "0x187F1D550")]
	private static void EELHBDPAFAA(Dictionary<DFBBPKLEGFN, Material> JNDJCHENOOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x7F20DF0", Offset = "0x7F1F9F0", VA = "0x187F20DF0")]
	private static void JFJJNOGBDLE(Dictionary<Renderer, CDFCEBFFOBN> OHCMNCCADOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x7F1D3A0", Offset = "0x7F1BFA0", VA = "0x187F1D3A0")]
	private void EBFPJGOMIIN(SkinnedMeshRenderer[] ADNAIABIPDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x7F1DE20", Offset = "0x7F1CA20", VA = "0x187F1DE20")]
	private void EKCCFLIFKIP(SkinnedMeshRenderer HDHHGHHFCGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x7F24630", Offset = "0x7F23230", VA = "0x187F24630")]
	private void MIAFMOGHLLM(List<IGJFGOMAIOE> FGIOFINJGPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x7F253B0", Offset = "0x7F23FB0", VA = "0x187F253B0")]
	private void OLHFALNMPFM(Dictionary<string, MNDBKMIALLI<Texture2D>> LDOBEDEHEFO, bool PKCLMIAGEEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x7F1E7B0", Offset = "0x7F1D3B0", VA = "0x187F1E7B0")]
	private void GAHOGAOKEDH(Dictionary<string, List<DFBBPKLEGFN>> LDOBEDEHEFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x7F248D0", Offset = "0x7F234D0", VA = "0x187F248D0")]
	private void NAJAGMGDEHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x7F1BCE0", Offset = "0x7F1A8E0", VA = "0x187F1BCE0")]
	private void CMPPEELKJJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x7F1D860", Offset = "0x7F1C460", VA = "0x187F1D860")]
	private void EJJBOMLHNGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x7F1C280", Offset = "0x7F1AE80", VA = "0x187F1C280")]
	private void DKGGHEMEKKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x7F1BC50", Offset = "0x7F1A850", VA = "0x187F1BC50")]
	private void CLEEHJHENPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x7F24200", Offset = "0x7F22E00", VA = "0x187F24200")]
	private void MDPAFFELPBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x7F24A20", Offset = "0x7F23620", VA = "0x187F24A20")]
	private void NDAOAIEAMOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x7F1E6D0", Offset = "0x7F1D2D0", VA = "0x187F1E6D0")]
	private void FNKPOMABPLD(bool KEHLLKDCCKG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x7F24DC0", Offset = "0x7F239C0", VA = "0x187F24DC0")]
	private void OABGBNMLDJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x7F1DF50", Offset = "0x7F1CB50", VA = "0x187F1DF50")]
	private void FJGAOPDJCMC(bool KEHLLKDCCKG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x7F24AA0", Offset = "0x7F236A0", VA = "0x187F24AA0")]
	private void NOGDDNBAHLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x7F1A950", Offset = "0x7F19550", VA = "0x187F1A950")]
	private void BNAFFLMMDPF(Material PAODGAKGKGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x7F19E10", Offset = "0x7F18A10", VA = "0x187F19E10")]
	private void APBKHDIEGDO(Material PAODGAKGKGP, Color BOKCNDDFGLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x7F1E0C0", Offset = "0x7F1CCC0", VA = "0x187F1E0C0")]
	private void FLNKKBKCEEE(Material PAODGAKGKGP, Color BOKCNDDFGLI, Color GMFGGJEDDCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x7F1C0E0", Offset = "0x7F1ACE0", VA = "0x187F1C0E0")]
	private void DJKDAAAFOKF(Material PAODGAKGKGP, Color HFDHMLDHBON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x7F23660", Offset = "0x7F22260", VA = "0x187F23660")]
	private void KJPAKAHGMEF(Material PAODGAKGKGP, Texture2D PMMGDHEEDKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x7F1A760", Offset = "0x7F19360", VA = "0x187F1A760")]
	private void BHKHGENKNKA(Material PAODGAKGKGP, Texture ANOCKJNGHDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x7F25DB0", Offset = "0x7F249B0", VA = "0x187F25DB0")]
	private void PPOCIDLNJPB(Action<CDFCEBFFOBN> MMDIJLFNLAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x7F24E40", Offset = "0x7F23A40", VA = "0x187F24E40")]
	private void ODLNPACDGAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x7F1B790", Offset = "0x7F1A390", VA = "0x187F1B790")]
	private void CDCGJFGJHPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x7F1AFA0", Offset = "0x7F19BA0", VA = "0x187F1AFA0")]
	private void BPGOPLGHFDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x7F20F50", Offset = "0x7F1FB50", VA = "0x187F20F50")]
	public void JIEMKELDOGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x7F1DED0", Offset = "0x7F1CAD0", VA = "0x187F1DED0", Slot = "4")]
	private void FJFKAHGDCGP([In] GACEJPGCMAE POHEOEEDHDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x7F20AF0", Offset = "0x7F1F6F0", VA = "0x187F20AF0")]
	[CompilerGenerated]
	private IPNMFPLCPOG IEAMFCLAJGJ(GDCGFICBEBL BOOEFKPMNJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x7F255B0", Offset = "0x7F241B0", VA = "0x187F255B0")]
	[CompilerGenerated]
	private void PELGGNNIDHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x7F25B00", Offset = "0x7F24700", VA = "0x187F25B00")]
	[CompilerGenerated]
	private void PHFKIJMKAOD(CDFCEBFFOBN NDIPIKDGHKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x7F1E310", Offset = "0x7F1CF10", VA = "0x187F1E310")]
	[CompilerGenerated]
	private void FLNLLMDPEIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x7F19D80", Offset = "0x7F18980", VA = "0x187F19D80")]
	[CompilerGenerated]
	private void AJLJHFMGKJO(CDFCEBFFOBN NDIPIKDGHKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x7F217E0", Offset = "0x7F203E0", VA = "0x187F217E0")]
	[CompilerGenerated]
	private void KBIGAAADEEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x7F1BE70", Offset = "0x7F1AA70", VA = "0x187F1BE70")]
	[CompilerGenerated]
	private void DEBEAAFDJCO(CDFCEBFFOBN NDIPIKDGHKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x7F1D4C0", Offset = "0x7F1C0C0", VA = "0x187F1D4C0")]
	[CompilerGenerated]
	private void ECIALOPDOPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x7F20950", Offset = "0x7F1F550", VA = "0x187F20950")]
	[CompilerGenerated]
	private void IADKDDEFDEJ(CDFCEBFFOBN NDIPIKDGHKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x7F23850", Offset = "0x7F22450", VA = "0x187F23850")]
	[CompilerGenerated]
	private void KLAALNKPFNL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x7F19F90", Offset = "0x7F18B90", VA = "0x187F19F90")]
	[CompilerGenerated]
	private void BCJLAGMLDHM(CDFCEBFFOBN NDIPIKDGHKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x7F1E030", Offset = "0x7F1CC30", VA = "0x187F1E030")]
	[CompilerGenerated]
	private void FKOHODMCKPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x7F1BC00", Offset = "0x7F1A800", VA = "0x187F1BC00")]
	[CompilerGenerated]
	private void CHOIPHIEIOD(CDFCEBFFOBN NDIPIKDGHKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x7F25B30", Offset = "0x7F24730", VA = "0x187F25B30")]
	[CompilerGenerated]
	private void PLNGHLNLDEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x7F25380", Offset = "0x7F23F80", VA = "0x187F25380")]
	[CompilerGenerated]
	private void OHNJDDFLNEG(CDFCEBFFOBN NDIPIKDGHKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x7F19D00", Offset = "0x7F18900", VA = "0x187F19D00")]
	[CompilerGenerated]
	private void AILJKNPAOFD(KeyValuePair<string, MNDBKMIALLI<Texture2D>> KGFGMOBGFPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x7F23AF0", Offset = "0x7F226F0", VA = "0x187F23AF0")]
	[CompilerGenerated]
	private void LKBGPFLPGMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x7F248A0", Offset = "0x7F234A0", VA = "0x187F248A0")]
	[CompilerGenerated]
	private void MPFPMLGHOOD(CDFCEBFFOBN NDIPIKDGHKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x7F1B780", Offset = "0x7F1A380", VA = "0x187F1B780")]
	[CompilerGenerated]
	private void CCOEFIFNAFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x7F1A560", Offset = "0x7F19160", VA = "0x187F1A560")]
	[CompilerGenerated]
	private void BGFCDNKPGDJ(CDFCEBFFOBN NDIPIKDGHKM)
	{
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class AvatarElbowBendHelperController : MonoBehaviour, NBBKAEDFNEM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		[SerializeField]
		[IODJOKMKDII(AFILHNGOOLF.Self, false, false, false)]
		private Transform ElbowHelperBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		[SerializeField]
		private Transform UpperArmBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		[SerializeField]
		private Transform LowerArmBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		[SerializeField]
		private float MinAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		[SerializeField]
		private float MaxAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		[SerializeField]
		[Header("Scale")]
		[FormerlySerializedAs("MinScaleValues")]
		private Vector3 ScaleValuesAtMinAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		[FormerlySerializedAs("MaxScaleValues")]
		[SerializeField]
		private Vector3 ScaleValuesAtMaxAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		[SerializeField]
		[Header("Positional Offset")]
		[FormerlySerializedAs("MinLocalPositionalOffset")]
		private Vector3 PositionalOffsetAtMinAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		[SerializeField]
		[FormerlySerializedAs("MaxLocalPositionOffset")]
		private Vector3 PositionalOffsetAtMaxAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		private Vector3? BGPOGPJGFLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		private bool IMMPKJPHIKD;

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x7F26A40", Offset = "0x7F25640", VA = "0x187F26A40", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x7F27070", Offset = "0x7F25C70", VA = "0x187F27070", Slot = "4")]
		public void UpdateController(float EOLAIOLLEBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0xD5F6E0", Offset = "0xD5E2E0", VA = "0x180D5F6E0", Slot = "6")]
		public void SetEnabled(bool BKMPCFIAHIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x7F26B20", Offset = "0x7F25720", VA = "0x187F26B20")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x7F27530", Offset = "0x7F26130", VA = "0x187F27530")]
		public AvatarElbowBendHelperController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class AvatarElbowBendTargetController : MonoBehaviour, NBBKAEDFNEM
	{
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		private const float MDOEBGIMMPB = 45f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		[IODJOKMKDII(AFILHNGOOLF.Self, false, false, false)]
		[SerializeField]
		private Transform ElbowBendTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		[SerializeField]
		private Transform NeckBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		[SerializeField]
		private Transform UpperArmBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		[SerializeField]
		private Transform HandBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		[SerializeField]
		private bool Left;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		[SerializeField]
		private float MinTwist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		[SerializeField]
		private float MaxTwist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		[SerializeField]
		private float TwistWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		[SerializeField]
		private float ElbowSmoothTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		[SerializeField]
		private float RestTwist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		[SerializeField]
		private float RestTwistWhenClose;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		[SerializeField]
		private float RestTwistDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		private Vector3 NNIEPIGKNCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		private Vector3 ADBBPDNJFAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		private bool IMMPKJPHIKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private float MAFIHBEMDNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private float AMFJGEODAJI;

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x7F30950", Offset = "0x7F2F550", VA = "0x187F30950", Slot = "4")]
		public void UpdateController(float EOLAIOLLEBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0xFB5510", Offset = "0xFB4110", VA = "0x180FB5510", Slot = "6")]
		public void SetEnabled(bool BKMPCFIAHIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x7F30670", Offset = "0x7F2F270", VA = "0x187F30670")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x7F31410", Offset = "0x7F30010", VA = "0x187F31410")]
		public AvatarElbowBendTargetController()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class BGHJPDBAAMP : HGPOBCJDMGK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private static readonly int KECPIPAOFKJ;

	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private static readonly int EANANMMCIKG;

	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private static readonly int LCCJHEOHNHG;

	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private static readonly int KOIJMDAGAGA;

	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private static readonly int HBAJDLOFHMK;

	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private static readonly int CBCPEFGCAHM;

	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private static readonly int LGNHANGBPIH;

	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private static readonly int PPAEJADDMJG;

	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private static readonly int PPNMMOPCHBO;

	[Cpp2IlInjected.Token(Token = "0x4000157")]
	private static readonly int CIILOFIMHOF;

	[Cpp2IlInjected.Token(Token = "0x4000158")]
	private static readonly int MOMPCFOODHN;

	[Cpp2IlInjected.Token(Token = "0x4000159")]
	private static readonly int ABECJHDHNPC;

	[Cpp2IlInjected.Token(Token = "0x400015A")]
	private static readonly int PACNGFMOKMF;

	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private static readonly int NDEKFDAINEJ;

	[Cpp2IlInjected.Token(Token = "0x400015C")]
	private static readonly int BAGAPHMFDDH;

	[Cpp2IlInjected.Token(Token = "0x400015D")]
	private static readonly int FNKGGPINJIF;

	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private static readonly int PKBAICNBJOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	private Transform HNKBBLHHPDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	private Transform ALOJPCFACOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	private Transform MGIPJBPKHLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	private Transform GFELPNEGMEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	private Transform AMIDCMJJDMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private Transform BJNIFKBDIPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private BBCEFGDHHFK PFLEHJGLOLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private Material IBMCMJFMOJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	private SkinnedMeshRenderer[] DBAGCHPMAOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	private readonly List<Material> ECECBFHHEOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	private CHEOGLIHFLP DFDLBDKLAJK;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public LKKDMOCNJPN JJCPGNPLICC
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0xA5B540", Offset = "0xA5A140", VA = "0x180A5B540", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	private CHEOGLIHFLP JMHFBFICPGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x7F35B30", Offset = "0x7F34730", VA = "0x187F35B30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool MIILNIMFKPO
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x7F34C10", Offset = "0x7F33810", VA = "0x187F34C10", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x7F33AF0", Offset = "0x7F326F0", VA = "0x187F33AF0")]
	public void BFHPBJMBKJO([In] BBCEFGDHHFK DPOOMHDCPJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x7F33BA0", Offset = "0x7F327A0", VA = "0x187F33BA0")]
	public void BKLDPPOHCAI([In] CPBPCILFBLH EJNBLJMFJGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x7F34DB0", Offset = "0x7F339B0", VA = "0x187F34DB0", Slot = "6")]
	public void HMPKEEFJNFG(NBANHCCEMPI KGPFAFPDIEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x7F33C50", Offset = "0x7F32850", VA = "0x187F33C50")]
	private Vector2 DHOMCHGPFIJ(Vector2 AMECFIBPPPG)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x7F33CB0", Offset = "0x7F328B0", VA = "0x187F33CB0")]
	public void DMDOFOGNBBN([In] FOBJEEDMFJB EJNBLJMFJGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x7F353D0", Offset = "0x7F33FD0", VA = "0x187F353D0")]
	private void LOEKMGKIIGA(MNEGGMHDOFP CHGJLJGPCJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x7F357A0", Offset = "0x7F343A0", VA = "0x187F357A0")]
	private void MJENMGDDFKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x7F34BA0", Offset = "0x7F337A0", VA = "0x187F34BA0")]
	private void HHDGOIIHKIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x7F34BA0", Offset = "0x7F337A0", VA = "0x187F34BA0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x7F35EC0", Offset = "0x7F34AC0", VA = "0x187F35EC0")]
	public BGHJPDBAAMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x7F33BA0", Offset = "0x7F327A0", VA = "0x187F33BA0", Slot = "5")]
	private void MGPPMIFCFOC([In] CPBPCILFBLH EJNBLJMFJGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x7F33C40", Offset = "0x7F32840", VA = "0x187F33C40", Slot = "7")]
	private void CFDPBFCHPGL([In] FOBJEEDMFJB EJNBLJMFJGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x7F34D60", Offset = "0x7F33960", VA = "0x187F34D60")]
	[CompilerGenerated]
	internal static float FEDJIDJAOLM(float BKMPCFIAHIG, float IOENJADIPLP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x7F352E0", Offset = "0x7F33EE0", VA = "0x187F352E0")]
	[CompilerGenerated]
	internal static void KPGHCIFDDBH(Vector2 JJEPJKKKBNK, Vector2 CIMGPJNKCAP, Vector2 PFHGPMHBODB, Vector2 MPPPNIHIBJF, Vector2 ENBPGBPHHMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x7F34D70", Offset = "0x7F33970", VA = "0x187F34D70")]
	[CompilerGenerated]
	internal static Vector4 HIIFAGACNON(Vector2 FEMJLOIOGIK, Vector2 ECJMFFOLCCL)
	{
		return default(Vector4);
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public class AvatarForearmRollController : MonoBehaviour, NBBKAEDFNEM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		[SerializeField]
		private Transform TwistBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		[SerializeField]
		private Transform HandBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		[SerializeField]
		private Transform LowerArmTwistBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		[SerializeField]
		private Transform UpperArmTwistBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		[SerializeField]
		private Transform ElbowTwistBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		[SerializeField]
		private float RollTowardsWristAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		[SerializeField]
		private float RollSoftMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		[SerializeField]
		private float RollSoftMax;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		[SerializeField]
		private float LowerArmTwistAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		[SerializeField]
		private float UpperArmTwistAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		[SerializeField]
		private float ElbowTwistAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		private float MAFIHBEMDNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		private bool IMMPKJPHIKD;

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x7F31440", Offset = "0x7F30040", VA = "0x187F31440", Slot = "4")]
		public void UpdateController(float EOLAIOLLEBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x21EA120", Offset = "0x21E8D20", VA = "0x1821EA120", Slot = "6")]
		public void SetEnabled(bool BKMPCFIAHIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x7F31CB0", Offset = "0x7F308B0", VA = "0x187F31CB0")]
		public AvatarForearmRollController()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public class AvatarHandDisplaySettings
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200002B")]
		public class AnimationOverride
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400017A")]
			[Tooltip("Name of animation original state to override")]
			public string OriginalName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400017B")]
			[Tooltip("Name of animation state to use as an override")]
			public string OverrideName;

			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
			public AnimationOverride()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		[SerializeField]
		private AnimationOverride[] HandStateOverrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		private Dictionary<int, int> _animationOverrides;

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x7F31CE0", Offset = "0x7F308E0", VA = "0x187F31CE0")]
		public void CBACPPGGEHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x7F31E00", Offset = "0x7F30A00", VA = "0x187F31E00")]
		public int HMMPMHAHIBM(int IMGHKDLHKFJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public AvatarHandDisplaySettings()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class AKPKGBFIAOI : GHPKGKDAJHO
{
	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x7F302F0", Offset = "0x7F2EEF0", VA = "0x187F302F0", Slot = "24")]
	public override float LHGHEJHLNMO()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x7F30340", Offset = "0x7F2EF40", VA = "0x187F30340")]
	public AKPKGBFIAOI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class GHPKGKDAJHO : LAJPNBFOHGM
{
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	private static int DLCMFIBDKIG;

	[Cpp2IlInjected.Token(Token = "0x400017D")]
	private static int PJHJMJLAMKG;

	[Cpp2IlInjected.Token(Token = "0x400017E")]
	private static int PDGNDLOGHNM;

	[Cpp2IlInjected.Token(Token = "0x400017F")]
	private static int AICGCIFCMMI;

	[Cpp2IlInjected.Token(Token = "0x4000180")]
	private static int DJBNDOJKKGD;

	[Cpp2IlInjected.Token(Token = "0x4000181")]
	private static int NLMONMDAPNH;

	[Cpp2IlInjected.Token(Token = "0x4000182")]
	private static int ADGOMLGMLFA;

	[Cpp2IlInjected.Token(Token = "0x4000183")]
	private static int[] CFMPCLCIDDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	private LJNLCOAKGPF PFLEHJGLOLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	private IAPHGPJACDF DCLHBCOCAEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	private int JFCJKLPGJKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	private float GDBFIKKDOJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	protected Animator HLBDDPFFPOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	protected AvatarConfiguration DBHOPMOBFGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	protected int EJOLHOENLPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	private int OMNGMMMDEIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	private int CBHAPACGPGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	private bool ANMFPHHIHBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	private KDPJFJOILJL FFMEAKKODHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	private int KBGNEEKBFKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	private float OEGFDFGOOEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	private AvatarHandDisplaySettings KIOILANEHEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private ADAOAPJGFHC NNIKJDODPDA;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public Transform LNMGDHKAPNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0xA5B540", Offset = "0xA5A140", VA = "0x180A5B540")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0xA5B460", Offset = "0xA5A060", VA = "0x180A5B460")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public Vector3 HFPFHLEHFPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x18CA650", Offset = "0x18C9250", VA = "0x1818CA650")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x18CA410", Offset = "0x18C9010", VA = "0x1818CA410")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public Quaternion PDDFDDPJGHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0xE4A4C0", Offset = "0xE490C0", VA = "0x180E4A4C0")]
		[CompilerGenerated]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x10518C0", Offset = "0x10504C0", VA = "0x1810518C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool NDGLJPFGAPO
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x7F3E310", Offset = "0x7F3CF10", VA = "0x187F3E310")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x7F3E580", Offset = "0x7F3D180", VA = "0x187F3E580")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool LBACIKAKDMC
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0xACDD50", Offset = "0xACC950", VA = "0x180ACDD50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public Vector3 LDJMIBFINAF
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0xA88F60", Offset = "0xA87B60", VA = "0x180A88F60", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0xA89D60", Offset = "0xA88960", VA = "0x180A89D60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public Quaternion LHHENGGOGAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x1205800", Offset = "0x1204400", VA = "0x181205800", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x16819D0", Offset = "0x16805D0", VA = "0x1816819D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public IKOIPHKGCMC OCEMKKLFGME
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0xAFFA60", Offset = "0xAFE660", VA = "0x180AFFA60", Slot = "21")]
		[CompilerGenerated]
		get
		{
			return default(IKOIPHKGCMC);
		}
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0xAFF740", Offset = "0xAFE340", VA = "0x180AFF740", Slot = "4")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public IKOIPHKGCMC KAGJMJGKPFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0xAFFA50", Offset = "0xAFE650", VA = "0x180AFFA50", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return default(IKOIPHKGCMC);
		}
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0xAFF560", Offset = "0xAFE160", VA = "0x180AFF560", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public float PHABIMLIEIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0xBAD960", Offset = "0xBAC560", VA = "0x180BAD960", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x1023930", Offset = "0x1022530", VA = "0x181023930", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool GFMNMCPPGHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x7F3E350", Offset = "0x7F3CF50", VA = "0x187F3E350", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x7F3E2F0", Offset = "0x7F3CEF0", VA = "0x187F3E2F0", Slot = "9")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool CLIBKFBEDLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x7F3E280", Offset = "0x7F3CE80", VA = "0x187F3E280")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool BLIDDCMBJNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x7F3E4F0", Offset = "0x7F3D0F0", VA = "0x187F3E4F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool GKHLNHCALOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x7F3E2E0", Offset = "0x7F3CEE0", VA = "0x187F3E2E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public bool KAEDIJPDFGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x7F3E300", Offset = "0x7F3CF00", VA = "0x187F3E300")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x7F3E090", Offset = "0x7F3CC90", VA = "0x187F3E090", Slot = "23")]
	public void BFHPBJMBKJO(LJNLCOAKGPF DPOOMHDCPJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x7F3E290", Offset = "0x7F3CE90", VA = "0x187F3E290")]
	public void CCALGCBOCMP(IAPHGPJACDF BKJOJPBEKLA, AvatarHandDisplaySettings DKFCHCGNBIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x7F3E940", Offset = "0x7F3D540", VA = "0x187F3E940", Slot = "14")]
	public void NJELIMGFOCB(bool MNGLOBMLMGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x7F3E5D0", Offset = "0x7F3D1D0", VA = "0x187F3E5D0", Slot = "13")]
	public void NCGNJONHFIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0xBAD960", Offset = "0xBAC560", VA = "0x180BAD960", Slot = "24")]
	public virtual float LHGHEJHLNMO()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x7F3E360", Offset = "0x7F3CF60", VA = "0x187F3E360")]
	private int HMNDLKIEFBB(IKOIPHKGCMC IDGAHNOJONP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x7F3EA10", Offset = "0x7F3D610", VA = "0x187F3EA10")]
	private void PNJLFCKOEDP(int FLFIOKJPIIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x7F3E550", Offset = "0x7F3D150", VA = "0x187F3E550", Slot = "15")]
	public bool JMOOLBPJJCD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x7F3E570", Offset = "0x7F3D170", VA = "0x187F3E570", Slot = "16")]
	public bool KDENMFCIEGC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x7F3E230", Offset = "0x7F3CE30", VA = "0x187F3E230")]
	private IKOIPHKGCMC BIGBMEGFAGL()
	{
		return default(IKOIPHKGCMC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x1E74A90", Offset = "0x1E73690", VA = "0x181E74A90", Slot = "17")]
	public void LKFMKOBBCKC(bool MNGLOBMLMGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x7F3E9D0", Offset = "0x7F3D5D0", VA = "0x187F3E9D0", Slot = "12")]
	public void OLLPEENMBCF(int FLFIOKJPIIB, float HCOLNMKHBII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x7F3E5B0", Offset = "0x7F3D1B0", VA = "0x187F3E5B0", Slot = "10")]
	public void MHBDCLLJAEH(KDPJFJOILJL EKPDKNLBIHJ, bool MOFPHEHMCLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x7F3E340", Offset = "0x7F3CF40", VA = "0x187F3E340", Slot = "11")]
	public void FGFKBDGMOOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x7F3E500", Offset = "0x7F3D100", VA = "0x187F3E500", Slot = "18")]
	public void JJBOIGFPNAA(Transform IEPNOLIPIDE, Vector3 INBAHEOIMPP, Quaternion MCONLECIECO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x7F3EEA0", Offset = "0x7F3DAA0", VA = "0x187F3EEA0")]
	public GHPKGKDAJHO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class BLHKKPAJCBC : GDCGFICBEBL
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class IKACBCDKFGP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		public BLHKKPAJCBC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		public List<IGJFGOMAIOE> prefabHandles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		public List<IGJFGOMAIOE> materialHandles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		public MNDBKMIALLI<Material[]> loadMaterialsHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		public MNDBKMIALLI<IOAJMCLJGBP> loadPrefabHandle;

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public IKACBCDKFGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x7F3F8A0", Offset = "0x7F3E4A0", VA = "0x187F3F8A0")]
		internal IPNMFPLCPOG MAIPFIAFOMN(string error)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	public BOBAHFBAFHA NMLFIAIHCGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	public IOAJMCLJGBP EKKPLNECAAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	private MNDBKMIALLI<IOAJMCLJGBP> EDCGOGEFDNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	private MNDBKMIALLI<Material[]> DPEODODOPMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	public Material[] KEPHJEHMLEF;

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool KBKPLGIFMON
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0xA8A4F0", Offset = "0xA890F0", VA = "0x180A8A4F0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0xA8A270", Offset = "0xA88E70", VA = "0x180A8A270")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public NHDGALDIFDN.IAHAFMDMEMA APIEHMLGHJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0xA5B560", Offset = "0xA5A160", VA = "0x180A5B560")]
		[CompilerGenerated]
		get
		{
			return default(NHDGALDIFDN.IAHAFMDMEMA);
		}
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0xA681F0", Offset = "0xA66DF0", VA = "0x180A681F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x7F373E0", Offset = "0x7F35FE0", VA = "0x187F373E0")]
	public BLHKKPAJCBC(FMEODGEFBMO BKMCDELDIBP, BOBAHFBAFHA IELPPFMIPII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x7F36000", Offset = "0x7F34C00", VA = "0x187F36000", Slot = "6")]
	public override IPNMFPLCPOG CEPOKNGCKPE(List<IGJFGOMAIOE> HFFIFNAHKHL, List<IGJFGOMAIOE> AOOAIAPGBLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x7F36A50", Offset = "0x7F35650", VA = "0x187F36A50")]
	public IPNMFPLCPOG ICJDAFDFGJG(List<IGJFGOMAIOE> HFFIFNAHKHL, List<IGJFGOMAIOE> AOOAIAPGBLH, MNDBKMIALLI<Material[]> DPEODODOPMF, [Optional] MNDBKMIALLI<IOAJMCLJGBP> PDLELBHEBCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x7F36D60", Offset = "0x7F35960", VA = "0x187F36D60")]
	public (MNDBKMIALLI<Material[]>, MNDBKMIALLI<IOAJMCLJGBP>) MBIBOMPCHOF(List<IGJFGOMAIOE> HFFIFNAHKHL, List<IGJFGOMAIOE> AOOAIAPGBLH)
	{
		return default((MNDBKMIALLI<Material[]>, MNDBKMIALLI<IOAJMCLJGBP>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x7F364C0", Offset = "0x7F350C0", VA = "0x187F364C0", Slot = "7")]
	public override GGNBAGGOAJC EJBDMIJOLKP(uint LGKJAMKLNMC, AvatarSkinnedMeshBoneOrderRemapsData IDFMEHIACGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x7F37180", Offset = "0x7F35D80", VA = "0x187F37180")]
	public GGNBAGGOAJC PCOOFBNAGDN(GameObject OOPPPHNHGDE, uint LGKJAMKLNMC, bool JCCGIANBMLO, bool KMIBOKNEFKL, AvatarSkinnedMeshBoneOrderRemapsData IDFMEHIACGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x7F366E0", Offset = "0x7F352E0", VA = "0x187F366E0")]
	public static bool FMFGPEOMCKJ(Renderer[] ADNAIABIPDJ, string GLEPPJDKKAP, [Out] Renderer IKNMCLCDFDJ, [Out] Renderer GBBNMBBIFJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x7F37390", Offset = "0x7F35F90", VA = "0x187F37390", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x7F365F0", Offset = "0x7F351F0", VA = "0x187F365F0")]
	private (MNDBKMIALLI<IOAJMCLJGBP>, MNDBKMIALLI<Material[]>) ENNMIHPHLMH()
	{
		return default((MNDBKMIALLI<IOAJMCLJGBP>, MNDBKMIALLI<Material[]>));
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x7F366C0", Offset = "0x7F352C0", VA = "0x187F366C0")]
	[CompilerGenerated]
	private void FAEJENGFPNF(IOAJMCLJGBP ABEFNIJCBBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0xA633D0", Offset = "0xA61FD0", VA = "0x180A633D0")]
	[CompilerGenerated]
	private void LJLALCEGGCH(Material[] ABEFNIJCBBN)
	{
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public class AvatarKneeBendTargetController : MonoBehaviour, NBBKAEDFNEM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		[SerializeField]
		[IODJOKMKDII(AFILHNGOOLF.Self, false, false, false)]
		private Transform KneeBendTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		[SerializeField]
		private Transform RootSpineBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		[SerializeField]
		private Transform ThighBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		[SerializeField]
		private Transform FootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		[SerializeField]
		private float WeightToFootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		[SerializeField]
		private Vector3 BendTargetOffsetFromHipToFootMidPoint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		[SerializeField]
		private Bounds KneeTargetConstrainedBox;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		private Vector3 NNIEPIGKNCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		private Vector3 MAHCJACMMKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		private Vector3 PKJKBBHBPBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		private Matrix4x4 NGEKPPDJIKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		private bool IMMPKJPHIKD;

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x7F322E0", Offset = "0x7F30EE0", VA = "0x187F322E0", Slot = "4")]
		public void UpdateController(float EOLAIOLLEBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x7F322D0", Offset = "0x7F30ED0", VA = "0x187F322D0", Slot = "6")]
		public void SetEnabled(bool BKMPCFIAHIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x7F31E70", Offset = "0x7F30A70", VA = "0x187F31E70")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x7F329A0", Offset = "0x7F315A0", VA = "0x187F329A0")]
		public AvatarKneeBendTargetController()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[GOLNKMGDHKC]
public struct MEKLJAAKLLL : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	[ReadOnly]
	public CHOKCAPIBKL LECKMIEDHJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	[ReadOnly]
	public int MKAIAOGLBGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	public MGCOBNNGKEB IDAJGEAGCFO;

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x7F402B0", Offset = "0x7F3EEB0", VA = "0x187F402B0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[GOLNKMGDHKC]
[NativeContainer]
public struct MGCOBNNGKEB : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	public NativeArray<Vector3> CCBCENOFGJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	public NativeArray<Vector3> KFJJHHLCFLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	public NativeArray<Vector4> GGFIECMILLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	public NativeArray<Vector2> GHFLGDGGNDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	public NativeArray<Vector2> EMKELEJFNJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	public NativeArray<Vector2> AENFOFPJHOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	public NativeArray<Vector2> FGCALLCAENB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	public NativeArray<Color> IGNNLCGEFLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	public NativeArray<int> OFMKHEFEDDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	public NativeArray<int> ADIHIFDFOCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	private NativeArray<int> NINBGEHKLIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	private NativeArray<int> PJDJOCNBJGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	public NativeArray<int> OHHHFHKAHDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	public NativeArray<int> EEDBABGHMMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	public NativeArray<int> HLFKPKDFCAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	public NativeArray<BoneWeight> NFKIPKBHNEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	private NativeArray<int> KCHMACEBLIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	private bool JBJJEMCJKGN;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public int NPMCBCLAGMD
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x7F415B0", Offset = "0x7F401B0", VA = "0x187F415B0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x7F41A70", Offset = "0x7F40670", VA = "0x187F41A70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public int OPHBNHMKJGG
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x7F41820", Offset = "0x7F40420", VA = "0x187F41820")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x7F41A60", Offset = "0x7F40660", VA = "0x187F41A60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public int EFACGIELDOF
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x7F41A50", Offset = "0x7F40650", VA = "0x187F41A50")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x7F41590", Offset = "0x7F40190", VA = "0x187F41590")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x7F41FE0", Offset = "0x7F40BE0", VA = "0x187F41FE0")]
	public MGCOBNNGKEB(int FDEGOECNNNM, int PPDBPOMPAJL, int PENEHGLCKEK, int LAAAPBPPHAE, Allocator HPEAGMDCCBL, int BBELGJAFHEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x7F41AC0", Offset = "0x7F406C0", VA = "0x187F41AC0")]
	public void JJHHEEDJLGF(int LCCBBMBENOH, Vector3 DNDKHMOJDEM, Vector3 PJNOJDKODDG, Vector4 KJCIKLJPCMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x7F418B0", Offset = "0x7F404B0", VA = "0x187F418B0")]
	public void EKOCPLPMAAF(int LCCBBMBENOH, BoneWeight FGAEPMDENBL, NativeSlice<byte> OENGCFNKFPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x7F41AA0", Offset = "0x7F406A0", VA = "0x187F41AA0")]
	public Color INMDDAGLBGP(int LCCBBMBENOH)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x7F41A80", Offset = "0x7F40680", VA = "0x187F41A80")]
	public void GIEPEMIMDLD(int LCCBBMBENOH, Color FBNAMAEDFNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x7F41830", Offset = "0x7F40430", VA = "0x187F41830")]
	public void EDPPIGIGKFB(byte OCDBEFKJAKH, int LCCBBMBENOH, Vector2 LNIHNHKOFMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x7F415A0", Offset = "0x7F401A0", VA = "0x187F415A0")]
	public void ALLNNHBLLFC(int LCCBBMBENOH, int NKKILGHIOCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x7F41880", Offset = "0x7F40480", VA = "0x187F41880")]
	public bool EEIKEMENNBE(int OCDBEFKJAKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x7F41BC0", Offset = "0x7F407C0", VA = "0x187F41BC0")]
	public void LMMDPIGGNDJ(int GMFCHOAKAHH, int HDEKJKJDEIC, int LBLBECEIAEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x7F415C0", Offset = "0x7F401C0", VA = "0x187F415C0")]
	public int[] DCIFKLJHLPE(int GMFCHOAKAHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x7F41B30", Offset = "0x7F40730", VA = "0x187F41B30")]
	private NativeSlice<int> KPFKBMEHEIH(int GMFCHOAKAHH)
	{
		return default(NativeSlice<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x7F41670", Offset = "0x7F40270", VA = "0x187F41670", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x7F41C90", Offset = "0x7F40890", VA = "0x187F41C90")]
	public Mesh ONBOOKGGHEM([Optional] string GLANGCJHONP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[DefaultMember("Item")]
[GOLNKMGDHKC]
[NativeContainer]
public struct CHOKCAPIBKL : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	public NativeArray<Vector3> CCBCENOFGJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	public NativeArray<Vector3> KFJJHHLCFLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	public NativeArray<Vector4> GGFIECMILLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	public NativeArray<Vector2> GHFLGDGGNDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	public NativeArray<Vector2> EMKELEJFNJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	public NativeArray<Vector2> AENFOFPJHOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	public NativeArray<Vector2> FGCALLCAENB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	public NativeArray<Color> IGNNLCGEFLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	public NativeArray<int> AEDKLBNJLPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	public NativeArray<int> JJCJKOMDDAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	public NativeArray<int> CLBOBFKFIKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	public NativeArray<int> KLGGKPGHPAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	public NativeArray<bool> HBKKCNIBIHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	public NativeArray<int> FCJLMCHKHKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	public NativeArray<int> IFPJCCPPHLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	public NativeArray<BoneWeight> LKOOEPLBLMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	private NativeArray<Matrix4x4> GKJCBAAGPAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	private NativeArray<long> IFKODOKBPPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	private NativeArray<byte> LOLFHDBBALD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	private NativeArray<int> CAAKPCMIDNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	private NativeArray<int> PHCHHLNHKJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	public NativeArray<sbyte> NAEDFFKKLJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	public NativeArray<byte> HDDAJICHGFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	private NativeArray<int> PKEIHKFCLGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	private bool JBJJEMCJKGN;

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public int BFNDCKAAMNM
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0xEF1340", Offset = "0xEEFF40", VA = "0x180EF1340")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public int FNCDLKAOJIM
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0xD62680", Offset = "0xD61280", VA = "0x180D62680")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public int MIALMPOLHDG
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x7F3A990", Offset = "0x7F39590", VA = "0x187F3A990")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public int NNHHOKMJLIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x7F3A950", Offset = "0x7F39550", VA = "0x187F3A950")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x7F3A970", Offset = "0x7F39570", VA = "0x187F3A970")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public int NPMCBCLAGMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x7F3A090", Offset = "0x7F38C90", VA = "0x187F3A090")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x7F3A320", Offset = "0x7F38F20", VA = "0x187F3A320")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public int HFIJOOBMAIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x7F3A080", Offset = "0x7F38C80", VA = "0x187F3A080")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x7F3A410", Offset = "0x7F39010", VA = "0x187F3A410")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public CIHDENBNPKK KMCGENJPOPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x7F3A400", Offset = "0x7F39000", VA = "0x187F3A400")]
		get
		{
			return default(CIHDENBNPKK);
		}
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x7F3A310", Offset = "0x7F38F10", VA = "0x187F3A310")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public byte AAMLILPHCEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x7F3A960", Offset = "0x7F39560", VA = "0x187F3A960")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x7F3A980", Offset = "0x7F39580", VA = "0x187F3A980")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public FHOOIAKNCLO KLGHGIBKAEH
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x7F3A420", Offset = "0x7F39020", VA = "0x187F3A420")]
		get
		{
			return default(FHOOIAKNCLO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x7F3A9C0", Offset = "0x7F395C0", VA = "0x187F3A9C0")]
	public CHOKCAPIBKL(IList<Mesh> PFMMCJLNKMP, IList<Matrix4x4> CGOAFHICCJA, IList<bool> HBKKCNIBIHO, byte CFAKMEJEFOK, IList<byte[]> KMMHKDJPAPI, IList<long> DCDBAIBOLNB, IList<bool> BNJPDHPFJND, IList<int> FCJLMCHKHKO, IList<int> MLFCBBDJIDF, IList<int> DBBCEJMJCPB, Allocator HPEAGMDCCBL, CIHDENBNPKK JEODCDOAHFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x7F3A330", Offset = "0x7F38F30", VA = "0x187F3A330")]
	public MGCOBNNGKEB GELAAMKDFIA(Allocator HPEAGMDCCBL)
	{
		return default(MGCOBNNGKEB);
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x7F3A0A0", Offset = "0x7F38CA0", VA = "0x187F3A0A0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[GOLNKMGDHKC]
public class LCPJBOPMHJH : JPOOFAHHJOG
{
	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x7F3FED0", Offset = "0x7F3EAD0", VA = "0x187F3FED0")]
	public CHOKCAPIBKL IOHPCLNJLFF()
	{
		return default(CHOKCAPIBKL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x7F2F170", Offset = "0x7F2DD70", VA = "0x187F2F170")]
	public LCPJBOPMHJH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public struct FHOOIAKNCLO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	public NativeSlice<Vector3> CCBCENOFGJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	public NativeSlice<Vector3> KFJJHHLCFLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	public NativeSlice<Vector4> GGFIECMILLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	public NativeSlice<Vector2> GHFLGDGGNDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	public NativeSlice<Vector2> EMKELEJFNJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	public NativeSlice<Vector2> AENFOFPJHOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	public NativeSlice<Vector2> FGCALLCAENB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	public NativeSlice<Color> IGNNLCGEFLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	public NativeSlice<int> GHKGOJHCHFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	public NativeSlice<int> KLGGKPGHPAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	public NativeSlice<BoneWeight> LKOOEPLBLMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	public NativeSlice<byte> CLDNCAONLIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	public int MEJIMPLIMGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	public Matrix4x4 HNHBGNAKGOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	public long FIDCIFKDNCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	public NativeSlice<byte> OENGCFNKFPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	public bool JGCCDILKJJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	public int JFCDAPIFIHM;
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
internal readonly struct DFBBPKLEGFN : IEquatable<DFBBPKLEGFN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	internal readonly Material HLAFGCCNOEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	internal readonly PFJLDMNPOID GOJHPLOIDPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	internal readonly IGNDKCMOLEC OIPCPAEANLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	internal readonly FMEODGEFBMO OABIFIEMPAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	internal readonly bool HIAKLOHGPCA;

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x7F3D030", Offset = "0x7F3BC30", VA = "0x187F3D030")]
	public DFBBPKLEGFN(Material CIBNABIMGCK, PFJLDMNPOID NJNJPMCMHDI, IGNDKCMOLEC CGBIMBKLAJP, FMEODGEFBMO DAMAHFKHDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x7F3CD90", Offset = "0x7F3B990", VA = "0x187F3CD90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x7F3CBF0", Offset = "0x7F3B7F0", VA = "0x187F3CBF0", Slot = "4")]
	public bool Equals(DFBBPKLEGFN IIOGPDPGOLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x7F3CAF0", Offset = "0x7F3B6F0", VA = "0x187F3CAF0", Slot = "0")]
	public override bool Equals(object KOJLNGLNBMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x7F3CC80", Offset = "0x7F3B880", VA = "0x187F3CC80", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[DisallowMultipleComponent]
	public class AvatarModernBodyDisplayBehaviour : MonoBehaviour, BHHFEEPAMEP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		[SerializeField]
		[Header("Configuration")]
		protected AvatarConfiguration configuration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		[SerializeField]
		protected Animator skeletonAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		[SerializeField]
		protected Renderer[] watchRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		[SerializeField]
		[Header("Configuration")]
		private ADAOAPJGFHC avatarBodyType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		[SerializeField]
		private AvatarSkinAssetItem potatoAvatarSkinAssetItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		[FormerlySerializedAs("avatarSkinAsset")]
		[SerializeField]
		private AssetReference avatarSkinAssetReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		[SerializeField]
		private GameObject firstPersonMeshContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		[SerializeField]
		public GameObject thirdPersonMeshContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		[SerializeField]
		private GameObject[] hideInFirstPerson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		[SerializeField]
		protected Transform headAdditiveBaseBoneTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		[FormerlySerializedAs("BodyMaterial")]
		[SerializeField]
		private Material BodyMaterialSkinGradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		[SerializeField]
		private Material BodyMaterialNonGradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		[SerializeField]
		private Material FaceMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		[SerializeField]
		private Material DefaultAvatarItemMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		[SerializeField]
		private Shader AvatarDefaultShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		[SerializeField]
		private Shader AvatarUberShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		[SerializeField]
		private Transform DeformRigRootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		[SerializeField]
		private SkinnedMeshRenderer BaseSkinnedMeshRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		[SerializeField]
		protected AvatarSkinnedMeshBoneOrderRemapsData BoneOrderRemapsData;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		[SerializeField]
		[Header("Arm Animation Controllers")]
		private AvatarForearmRollController LeftForearmRollController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		[SerializeField]
		private AvatarElbowBendHelperController LeftElbowBendHelperController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		[SerializeField]
		private AvatarElbowBendTargetController LeftElbowBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		[SerializeField]
		private AvatarKneeBendTargetController LeftKneeBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		[SerializeField]
		private AvatarForearmRollController RightForearmRollController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		[SerializeField]
		private AvatarElbowBendHelperController RightElbowBendHelperController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		[SerializeField]
		private AvatarElbowBendTargetController RightElbowBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		[SerializeField]
		private AvatarKneeBendTargetController RightKneeBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		[SerializeField]
		private Transform LeftEyeBrowBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		[SerializeField]
		private Transform LeftEyeBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		[SerializeField]
		private Transform RightEyeBrowBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		[SerializeField]
		private Transform RightEyeBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		[SerializeField]
		private Transform NoseMoveTweakBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x400021F")]
		[SerializeField]
		private Transform MouthBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		[SerializeField]
		private AvatarBodyPartShapesManager avatarBodyPartShapesManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		[SerializeField]
		private Transform HatAnchorBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		[SerializeField]
		private Transform LeftHandWatchAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		[SerializeField]
		private Transform RightHandWatchAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		[SerializeField]
		private GameObject LeftHandWatchVisuals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		[SerializeField]
		private GameObject RightHandWatchVisuals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		private FNKBCEMJFAH BGDHOACJNIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		private HGPOBCJDMGK LIKGNCPIJGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		private LAJPNBFOHGM BAOHBKMHGOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		private LAJPNBFOHGM DLMMCNJECOL;

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public FNKBCEMJFAH DGKGJBPJGNJ
		{
			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x7F33990", Offset = "0x7F32590", VA = "0x187F33990", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public HGPOBCJDMGK KCEMAFNKGHO
		{
			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0x7F339E0", Offset = "0x7F325E0", VA = "0x187F339E0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public LAJPNBFOHGM CGPHEOGJJEC
		{
			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x7F33A30", Offset = "0x7F32630", VA = "0x187F33A30", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public LAJPNBFOHGM NJFANICKHGG
		{
			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0x7F33A80", Offset = "0x7F32680", VA = "0x187F33A80", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public Transform KJLFJNIEJCD
		{
			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x7F33AD0", Offset = "0x7F326D0", VA = "0x187F33AD0", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public ADAOAPJGFHC NPJGNLJDDMG
		{
			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0xA681D0", Offset = "0xA66DD0", VA = "0x180A681D0", Slot = "12")]
			get
			{
				return default(ADAOAPJGFHC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x7F329B0", Offset = "0x7F315B0", VA = "0x187F329B0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x7F337F0", Offset = "0x7F323F0", VA = "0x187F337F0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x7F33520", Offset = "0x7F32120", VA = "0x187F33520", Slot = "8")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x7F337F0", Offset = "0x7F323F0", VA = "0x187F337F0", Slot = "9")]
		public void TeardownAvatarDisplaySystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x7F329F0", Offset = "0x7F315F0", VA = "0x187F329F0", Slot = "10")]
		public bool CleanupDisplayMeshes()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x7F338A0", Offset = "0x7F324A0", VA = "0x187F338A0")]
		public void UpdatePostIKAnimControllers(float EOLAIOLLEBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x7F33120", Offset = "0x7F31D20", VA = "0x187F33120")]
		private void GHPAEHINGPC(GameObject KOJLNGLNBMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x7F331B0", Offset = "0x7F31DB0", VA = "0x187F331B0")]
		private FNKBCEMJFAH IOCIALNCFCJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x7F32DE0", Offset = "0x7F319E0", VA = "0x187F32DE0")]
		private HGPOBCJDMGK ENLILPJFLHL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x7F33560", Offset = "0x7F32160", VA = "0x187F33560")]
		private LAJPNBFOHGM MMDODBGDLLO(HFDBLEOKNJB FJDDFMKMNAH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x7F33980", Offset = "0x7F32580", VA = "0x187F33980")]
		public AvatarModernBodyDisplayBehaviour()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class CDFCEBFFOBN : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	private MaterialPropertyBlock AAEPGNLGOCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	public Color? LJBOEBCKBMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	public Color? LDBLPOBMFOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	public Color? OMNLCKLFFFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	public Color? BIDCNEDALNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	public Color KOPJJILCAFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	public Color IAAIBKHMFDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	public Color BJBEMIFEAEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	public float GHDKIHCNHJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	public Texture2D EAOGKHNGLGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	public Texture2D LDIJLOIDKGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	private Dictionary<DFBBPKLEGFN, int> GENHJABGEMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	private PFJLDMNPOID[] EOMGFPFAJCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	private IGNDKCMOLEC[] LEDIBMEMBGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	public Vector4[] OMLDCPLLAKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	public Vector4[] FBBKKEMMOEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	public Vector4[] AKKPEMIAGGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	public Vector4[] NNENGGAGGCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	public Vector4[] FHHDIPHHPPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	public Vector4[] HCPMDFLOLJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	private List<Texture2D> BPOLKKCCEAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	private Vector4[] OFELHCHCHCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	private List<Texture2D> KMIOAHANBON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	private float[] BOIFDALNHLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	private Vector4[] IPHLIBKDGGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	private float[] MNKANCEJFDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	public float[] IOGPMFGJINB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	private List<Texture2D> APPEJMJKMCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	private float[] BBJLAIJLDKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	private List<Texture2D> EJAKHLOIBMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	private Vector4[] CELFNGJNCKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	private float[] JGOAKKLFDDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	private Vector4[] MFBFOHFONGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x400024B")]
	public float[] CHJMNNEAANF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	public Texture2DArray GJALMMNHPPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x400024D")]
	public Texture2DArray GDPJAEJCLGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x400024E")]
	public Texture2DArray COOMJCDKFPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x400024F")]
	public Texture2DArray JAODKGKJBJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x4000250")]
	private bool MEDAJCPFONL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18C")]
	[Cpp2IlInjected.Token(Token = "0x4000251")]
	private int FMCEDIOCNHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x4000252")]
	private Vector2? FDOIIKLMAMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19C")]
	[Cpp2IlInjected.Token(Token = "0x4000253")]
	private TextureFormat INCGHJMOAII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x4000254")]
	private Vector2? KJDEGGNPJCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1AC")]
	[Cpp2IlInjected.Token(Token = "0x4000255")]
	private TextureFormat AHLHOJPHHON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x4000256")]
	private Vector2? FMOBLOGLBPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1BC")]
	[Cpp2IlInjected.Token(Token = "0x4000257")]
	private TextureFormat DODIDIILNFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x4000258")]
	private Vector2? OCLKJHFEOOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1CC")]
	[Cpp2IlInjected.Token(Token = "0x4000259")]
	private TextureFormat BGDOBDMFFDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
	[Cpp2IlInjected.Token(Token = "0x400025A")]
	private bool KBLIMDOOPKN;

	[Cpp2IlInjected.Token(Token = "0x400025B")]
	private static int JBDGHADDEMA;

	[Cpp2IlInjected.Token(Token = "0x400025C")]
	private static int MAGEIEKALDA;

	[Cpp2IlInjected.Token(Token = "0x400025D")]
	private static int IHAPNJICFOE;

	[Cpp2IlInjected.Token(Token = "0x400025E")]
	private static int IKNIDPECHAH;

	[Cpp2IlInjected.Token(Token = "0x400025F")]
	private static int FLHLOJFBLJJ;

	[Cpp2IlInjected.Token(Token = "0x4000260")]
	private static int HMGAFLEBLGC;

	[Cpp2IlInjected.Token(Token = "0x4000261")]
	private static int FMFPKLGCOBN;

	[Cpp2IlInjected.Token(Token = "0x4000262")]
	private static int EAIOHIJELAC;

	[Cpp2IlInjected.Token(Token = "0x4000263")]
	private static int LEGIFDAFIPO;

	[Cpp2IlInjected.Token(Token = "0x4000264")]
	private static int FOKBFCAFMEN;

	[Cpp2IlInjected.Token(Token = "0x4000265")]
	private static int IBGHFFLBPFK;

	[Cpp2IlInjected.Token(Token = "0x4000266")]
	private static int CJNIHIHMHHF;

	[Cpp2IlInjected.Token(Token = "0x4000267")]
	private static int GMFBPNJJDFF;

	[Cpp2IlInjected.Token(Token = "0x4000268")]
	private static int KHOCHDHKODM;

	[Cpp2IlInjected.Token(Token = "0x4000269")]
	private static int DOPBKJKGJJP;

	[Cpp2IlInjected.Token(Token = "0x400026A")]
	private static int CIFHHPMMGPE;

	[Cpp2IlInjected.Token(Token = "0x400026B")]
	private static int DBDKIAGPNFO;

	[Cpp2IlInjected.Token(Token = "0x400026C")]
	private static int IEHJAKNLBGI;

	[Cpp2IlInjected.Token(Token = "0x400026D")]
	private static int NMMLHDNCMFH;

	[Cpp2IlInjected.Token(Token = "0x400026E")]
	private static int FHEKDPDMKLE;

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x7F39B80", Offset = "0x7F38780", VA = "0x187F39B80")]
	private CDFCEBFFOBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x7F39AC0", Offset = "0x7F386C0", VA = "0x187F39AC0")]
	public CDFCEBFFOBN(Color IPMDPNHHNEA, Color BMHHKGCHFPO, Color JHFBHOAEIII, Color? GJHFBLCJOMB, Color? JNKDCIOCBIL, Color? ICEPGJOMBAG, Texture2D JLELFDOIIBH, Texture2D APBMEECKAED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x7F37990", Offset = "0x7F36590", VA = "0x187F37990")]
	internal int ICIIFBKDJKC(Material IMDEKKHNMFK, PFJLDMNPOID NJNJPMCMHDI, IGNDKCMOLEC CGBIMBKLAJP, FMEODGEFBMO DAMAHFKHDCF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x7F37900", Offset = "0x7F36500", VA = "0x187F37900")]
	private int ICIIFBKDJKC(DFBBPKLEGFN DHCHBFGMFFD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x7F38B60", Offset = "0x7F37760", VA = "0x187F38B60")]
	internal int PJIJKGNOILN(Material IMDEKKHNMFK, Color HFDHMLDHBON, Color PKGKBHAFMOB, Color NCPNPPFPDAJ, Color MJPALICOCKK, Color LFBJGGGMMJK, Texture2D GCDEPIPMJIA, Vector4 MKNBOFGAIAI, Texture2D EDJINEAFLLI, Vector4 AOAAKPNAIOK, float MJAKGEBFOEK, float PIEDNHOOJOB, Texture2D CJHHJJIJLLM, Vector4 DECAOKHLJFH, float IKHMCJGJCAM, Texture2D OCJNOMNDILO, Color CNKHHILNLEM, Vector4 FDMMDDEPHAG, PFJLDMNPOID NJNJPMCMHDI, IGNDKCMOLEC CGBIMBKLAJP, FMEODGEFBMO DAMAHFKHDCF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x7F37740", Offset = "0x7F36340", VA = "0x187F37740")]
	private void IAOMDDOLPBO(List<Texture2D> BPOLKKCCEAN, [Out] Texture2DArray EHNJGNFMLHH, [Out] Texture2DArray KBODBMFKJAF, [Out] Texture2DArray PEJGLGJFBLA, [Out] Texture2DArray LAAIJPLFLGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x7F37D10", Offset = "0x7F36910", VA = "0x187F37D10")]
	public void PBBKPLAANFB(Shader IGJEALPNKHC, Renderer NMGNJGPOFCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x7F37E60", Offset = "0x7F36A60", VA = "0x187F37E60")]
	private void PHEEOHGBGPJ(Shader IGJEALPNKHC, Renderer NMGNJGPOFCI, int PMBABFOLNNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x7F37540", Offset = "0x7F36140", VA = "0x187F37540")]
	private Color FJLEMLGNGAD(Color KOHLOJJGEEK, PFJLDMNPOID JJPCHCCDGCE)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x7F37A60", Offset = "0x7F36660", VA = "0x187F37A60")]
	private Color JJNLFIFKPMK(Color LPODMFNECCI, PFJLDMNPOID JJPCHCCDGCE)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x7F37BB0", Offset = "0x7F367B0", VA = "0x187F37BB0")]
	private bool NOLLECMHGHN(Texture2D CKGFKFBPCEO, IGNDKCMOLEC LMHDEPDIPLN, [Out] Texture2D FLLBGDMDMHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x7F37450", Offset = "0x7F36050", VA = "0x187F37450")]
	private void APNDHCMKCMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x7F37500", Offset = "0x7F36100", VA = "0x187F37500", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public abstract class GDCGFICBEBL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000272")]
	public readonly FMEODGEFBMO ABOLJCKJLBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x4000273")]
	protected bool DELGCODELPJ;

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public bool FAKPFMLAPEB
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0xB27800", Offset = "0xB26400", VA = "0x180B27800")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0xB27790", Offset = "0xB26390", VA = "0x180B27790")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public bool IBFPJIMPKDD
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0xB27820", Offset = "0xB26420", VA = "0x180B27820")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0xB27810", Offset = "0xB26410", VA = "0x180B27810")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public virtual NHDGALDIFDN.IAHAFMDMEMA FIDCIFKDNCG
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0xA5B610", Offset = "0xA5A210", VA = "0x180A5B610", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(NHDGALDIFDN.IAHAFMDMEMA);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0xD73220", Offset = "0xD71E20", VA = "0x180D73220", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public bool KOOABLCNGJG
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x14FF3E0", Offset = "0x14FDFE0", VA = "0x1814FF3E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public bool HKPAAAKJDPF
	{
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x7F3E030", Offset = "0x7F3CC30", VA = "0x187F3E030")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public bool CJCLNNIFLFG
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x7F3E020", Offset = "0x7F3CC20", VA = "0x187F3E020")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public bool MGCCBJNNNLK
	{
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x7F3E040", Offset = "0x7F3CC40", VA = "0x187F3E040")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x7F3E060", Offset = "0x7F3CC60", VA = "0x187F3E060")]
	protected GDCGFICBEBL(FMEODGEFBMO BKMCDELDIBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract IPNMFPLCPOG CEPOKNGCKPE(List<IGJFGOMAIOE> HFFIFNAHKHL, List<IGJFGOMAIOE> AOOAIAPGBLH);

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract GGNBAGGOAJC EJBDMIJOLKP(uint LGKJAMKLNMC, AvatarSkinnedMeshBoneOrderRemapsData IDFMEHIACGI);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public class DEOJKEKOKAG : IIFNMACCEJJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000274")]
	private AvatarSkinAssetItem LMPFJCGAPOD;

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x7F3C9F0", Offset = "0x7F3B5F0", VA = "0x187F3C9F0")]
	public DEOJKEKOKAG(AvatarSkinAssetItem MPJHKLMDFMB, AvatarSkinAssetItem.LEPBNAPALIP HAAMKLBNHNC, FMEODGEFBMO DAMAHFKHDCF, [Optional] PFINHFPAAHI? BNDLKCAKBKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x7F3C780", Offset = "0x7F3B380", VA = "0x187F3C780", Slot = "6")]
	public override IPNMFPLCPOG CEPOKNGCKPE(List<IGJFGOMAIOE> HFFIFNAHKHL, List<IGJFGOMAIOE> AOOAIAPGBLH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class IECCKLHIFFO
{
	[Cpp2IlInjected.Token(Token = "0x4000275")]
	private static readonly int[] KKFMLBPNKIB;

	[Cpp2IlInjected.Token(Token = "0x4000276")]
	private static readonly int[] IFCOFPHAPHI;

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public static int[] GLNEDCFIDFK
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x7F3EEC0", Offset = "0x7F3DAC0", VA = "0x187F3EEC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x7F3EFD0", Offset = "0x7F3DBD0", VA = "0x187F3EFD0")]
	public static int[] OLAMMIHHMOO(bool JFHCKBEEMML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x7F3EF20", Offset = "0x7F3DB20", VA = "0x187F3EF20")]
	public static int MNPFCGMKCHJ(AFJPHDDPDEH CDAIJANEPII, bool JFHCKBEEMML)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x7F3EF10", Offset = "0x7F3DB10", VA = "0x187F3EF10")]
	private static int IMKPOMJICEI(AFJPHDDPDEH CDAIJANEPII)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x7F3EFB0", Offset = "0x7F3DBB0", VA = "0x187F3EFB0")]
	private static int NAJDHLKDLHH(AFJPHDDPDEH CDAIJANEPII)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class KGHICJBOLBJ
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class DIJPIPIOBBF : IEnumerator<LIPOFPKAEIK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		private LIPOFPKAEIK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		public JobHandle handle;

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		private LIPOFPKAEIK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0xA5B610", Offset = "0xA5A210", VA = "0x180A5B610", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0xA5B610", Offset = "0xA5A210", VA = "0x180A5B610", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0xA62C00", Offset = "0xA61800", VA = "0x180A62C00")]
		[DebuggerHidden]
		public DIJPIPIOBBF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x14614E0", Offset = "0x14600E0", VA = "0x1814614E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x7F3D170", Offset = "0x7F3BD70", VA = "0x187F3D170", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020")]
	public static void IHCAPJNIOPL(string OIBGADINDDP, int LGKJAMKLNMC, long GDJIEIAFHFC, long OEEDLPDHKLO, long JOBDLIHGCOP, long OOLCOACHLDJ, long MKEHOJCKECF, long MLACHDPKOFG, long BJIOKFPMNMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x7F3FDE0", Offset = "0x7F3E9E0", VA = "0x187F3FDE0")]
	public static CCGDPHBOCPE JFLFHGDOLGI(JobHandle MELNNGOJGKJ, bool CFPKPICEPBB, bool GNCFPAHIKAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x7F3FD70", Offset = "0x7F3E970", VA = "0x187F3FD70")]
	[IteratorStateMachine(typeof(DIJPIPIOBBF))]
	private static IEnumerator<LIPOFPKAEIK> EJMFFFPANCO(JobHandle PHMFHDLJBOO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class MFJMCNEMGJK
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public enum BFGPMAHGEIG
	{
		[Cpp2IlInjected.Token(Token = "0x4000287")]
		General,
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		ColoredHair
	}

	[Cpp2IlInjected.Token(Token = "0x400027A")]
	public static readonly int DCHBEGJBHAA;

	[Cpp2IlInjected.Token(Token = "0x400027B")]
	public static readonly int FOPPPBFJLJG;

	[Cpp2IlInjected.Token(Token = "0x400027C")]
	public static readonly int LKBJFDGNNPH;

	[Cpp2IlInjected.Token(Token = "0x400027D")]
	public static readonly int NBIDLKDOKOM;

	[Cpp2IlInjected.Token(Token = "0x400027E")]
	public static readonly int KNFPLPHOENE;

	[Cpp2IlInjected.Token(Token = "0x400027F")]
	public static readonly int BEOJLNNIMBP;

	[Cpp2IlInjected.Token(Token = "0x4000280")]
	public static readonly int CKGGOAAIIMM;

	[Cpp2IlInjected.Token(Token = "0x4000281")]
	public static readonly int EMEHMPLLNHN;

	[Cpp2IlInjected.Token(Token = "0x4000282")]
	public static readonly int MLNKDCFELGJ;

	[Cpp2IlInjected.Token(Token = "0x4000283")]
	public static readonly int CEABEDMEOCD;

	[Cpp2IlInjected.Token(Token = "0x4000284")]
	public static readonly int DIHJAKHFBOK;

	[Cpp2IlInjected.Token(Token = "0x4000285")]
	public static readonly int BKGBCMLMAME;

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x7F412F0", Offset = "0x7F3FEF0", VA = "0x187F412F0")]
	public static bool DAAKFFJMGHE(Material CIBNABIMGCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x7F41230", Offset = "0x7F3FE30", VA = "0x187F41230")]
	public static bool CAIPGHPBKNM(Material CIBNABIMGCK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class IIFNMACCEJJ : GDCGFICBEBL
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private sealed class DEICJJMKFBI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000290")]
		public MNDBKMIALLI<GameObject> skinAvatarItemPrefabHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000291")]
		public IIFNMACCEJJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000292")]
		public Action<string> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public DEICJJMKFBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x7F3C260", Offset = "0x7F3AE60", VA = "0x187F3C260")]
		internal void IDFJPAEICEK(GameObject result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x7F3C640", Offset = "0x7F3B240", VA = "0x187F3C640")]
		internal void MAIPFIAFOMN(string error)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400028A")]
	protected AvatarSkinAssetItem DEKCNDJCPOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400028B")]
	protected Material[] NEHOLAFBBKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400028C")]
	private readonly AvatarSkinAssetItem.LEPBNAPALIP JLIFCGDAFIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400028D")]
	private readonly AssetReference ICFOJFILLFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400028E")]
	private readonly PFINHFPAAHI? FNLMDBOMIHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400028F")]
	private SkinnedMeshRenderer[] PNOGJCJEOOB;

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public override NHDGALDIFDN.IAHAFMDMEMA FIDCIFKDNCG
	{
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0xA5B5E0", Offset = "0xA5A1E0", VA = "0x180A5B5E0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(NHDGALDIFDN.IAHAFMDMEMA);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0xA5B660", Offset = "0xA5A260", VA = "0x180A5B660", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x7F3F770", Offset = "0x7F3E370", VA = "0x187F3F770")]
	public IIFNMACCEJJ(AvatarSkinAssetItem.LEPBNAPALIP HAAMKLBNHNC, AssetReference DDGAJJHHGIB, Material ANNJOCIGHNI, FMEODGEFBMO DAMAHFKHDCF, NHDGALDIFDN.IAHAFMDMEMA BDCPKIKONCL = (NHDGALDIFDN.IAHAFMDMEMA)0L, [Optional] PFINHFPAAHI? BNDLKCAKBKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x7F3F650", Offset = "0x7F3E250", VA = "0x187F3F650")]
	public IIFNMACCEJJ(AvatarSkinAssetItem.LEPBNAPALIP HAAMKLBNHNC, AssetReference DDGAJJHHGIB, Material ANNJOCIGHNI, NHDGALDIFDN.IAHAFMDMEMA BDCPKIKONCL = (NHDGALDIFDN.IAHAFMDMEMA)0L, [Optional] PFINHFPAAHI? BNDLKCAKBKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x7F3F160", Offset = "0x7F3DD60", VA = "0x187F3F160", Slot = "6")]
	public override IPNMFPLCPOG CEPOKNGCKPE(List<IGJFGOMAIOE> HFFIFNAHKHL, List<IGJFGOMAIOE> AOOAIAPGBLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x7F3F3D0", Offset = "0x7F3DFD0", VA = "0x187F3F3D0", Slot = "7")]
	public override GGNBAGGOAJC EJBDMIJOLKP(uint LGKJAMKLNMC, AvatarSkinnedMeshBoneOrderRemapsData IDFMEHIACGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x7F3F5E0", Offset = "0x7F3E1E0", VA = "0x187F3F5E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x7F3F380", Offset = "0x7F3DF80", VA = "0x187F3F380")]
	protected void CHLJBOCLMBK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public class NNCIIJAOCFJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000293")]
	private List<int> LCBAJFFHLMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000294")]
	private List<ADIGPEJPBAI> BOBIPFKLCOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000295")]
	private HashSet<Transform> LDCAMPNOBHD;

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x7F43210", Offset = "0x7F41E10", VA = "0x187F43210")]
	public static NNCIIJAOCFJ EJIACNKPBJP(Transform KJCIKLJPCMB, Dictionary<Transform, OutfitType?> NBHNCEMNKHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x7F42EF0", Offset = "0x7F41AF0", VA = "0x187F42EF0")]
	private void ANIEGAGBMHH(Transform KJCIKLJPCMB, FMEODGEFBMO DAMAHFKHDCF, Dictionary<Transform, OutfitType?> NBHNCEMNKHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x7F43790", Offset = "0x7F42390", VA = "0x187F43790")]
	private void OKAFHEOEGPG(Transform JIAJBCAPIMI, FMEODGEFBMO DAMAHFKHDCF, bool HFHPBHLLHMJ, OutfitType? ANIIJDINIFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x7F433A0", Offset = "0x7F41FA0", VA = "0x187F433A0")]
	public EPMBEFFPMAF FFJAGJOMAJP(HashSet<string> LPBEOKCCCLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x7F43920", Offset = "0x7F42520", VA = "0x187F43920")]
	public NNCIIJAOCFJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public class EPMBEFFPMAF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000296")]
	private List<ADIGPEJPBAI> BOBIPFKLCOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000297")]
	private List<Matrix4x4> ACPDKEJOLFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000298")]
	private Transform[] FINJLGOFJNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000299")]
	private Matrix4x4[] DKIDPNDLBCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400029A")]
	private Dictionary<AOKMCLFPNBE, int> NKBCKBGGEPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400029B")]
	private List<LNFFBNLNGPL> PEEHHHFGPPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400029C")]
	private bool KEGCLONAGKJ;

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public int POLDAEOLMKF
	{
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x7F3D6D0", Offset = "0x7F3C2D0", VA = "0x187F3D6D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public Transform[] DMKPACOCBIK
	{
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x7F3D560", Offset = "0x7F3C160", VA = "0x187F3D560")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public Matrix4x4[] CIKHPLGGAAL
	{
		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x7F3D710", Offset = "0x7F3C310", VA = "0x187F3D710")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x7F3DAF0", Offset = "0x7F3C6F0", VA = "0x187F3DAF0")]
	public void OKAFHEOEGPG(Transform JIAJBCAPIMI, FMEODGEFBMO DAMAHFKHDCF, OutfitType? ANIIJDINIFH, bool OMKBPCAKFFO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x7F3D780", Offset = "0x7F3C380", VA = "0x187F3D780")]
	private void OKAFHEOEGPG(Transform JIAJBCAPIMI, FMEODGEFBMO DAMAHFKHDCF, OutfitType? ANIIJDINIFH, bool OMKBPCAKFFO, Matrix4x4 HHJHGGKJGKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x7F3D3B0", Offset = "0x7F3BFB0", VA = "0x187F3D3B0")]
	public int DHIEEGLJOLC(AOKMCLFPNBE DHCHBFGMFFD, bool MNCDHIEAIKG, [Optional] OutfitType? ANIIJDINIFH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x7F3D1C0", Offset = "0x7F3BDC0", VA = "0x187F3D1C0")]
	public int AJEDNKICHJE(FMEODGEFBMO DAMAHFKHDCF, [Optional] OutfitType? ANIIJDINIFH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x7F3D2C0", Offset = "0x7F3BEC0", VA = "0x187F3D2C0")]
	public void BIAFFDNFNBN(AOKMCLFPNBE DHCHBFGMFFD, Matrix4x4 GMFPFJAFHMI, bool MNCDHIEAIKG = false, [Optional] OutfitType? ANIIJDINIFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x7F3DCF0", Offset = "0x7F3C8F0", VA = "0x187F3DCF0")]
	public Matrix4x4 PALPDPCLMJP(AOKMCLFPNBE DHCHBFGMFFD, bool MNCDHIEAIKG, [Optional] OutfitType? ANIIJDINIFH)
	{
		return default(Matrix4x4);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0xDDB4C0", Offset = "0xDDA0C0", VA = "0x180DDB4C0")]
	public void NNGEKDNGKLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x7F3DE40", Offset = "0x7F3CA40", VA = "0x187F3DE40")]
	public EPMBEFFPMAF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public struct AOKMCLFPNBE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002A0")]
	public readonly string JDLKEFMHIAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	public readonly FMEODGEFBMO OABIFIEMPAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40002A2")]
	public readonly OutfitType? HGFEIDEMFOF;

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x7F30630", Offset = "0x7F2F230", VA = "0x187F30630")]
	public AOKMCLFPNBE(string FLOCHPNMHBO, FMEODGEFBMO DAMAHFKHDCF, [Optional] OutfitType? ANIIJDINIFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x7F30580", Offset = "0x7F2F180", VA = "0x187F30580", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x7F304C0", Offset = "0x7F2F0C0", VA = "0x187F304C0")]
	public bool PIPOKDEFBMK(AOKMCLFPNBE IIOGPDPGOLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x7F303A0", Offset = "0x7F2EFA0", VA = "0x187F303A0", Slot = "0")]
	public override bool Equals(object KOJLNGLNBMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x7F30450", Offset = "0x7F2F050", VA = "0x187F30450", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public struct LNFFBNLNGPL : IEquatable<LNFFBNLNGPL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	public readonly FMEODGEFBMO OABIFIEMPAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40002A4")]
	public readonly OutfitType? DMFEBPOODCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40002A5")]
	public readonly int AAJAKEHKCDD;

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x7F402A0", Offset = "0x7F3EEA0", VA = "0x187F402A0")]
	public LNFFBNLNGPL(FMEODGEFBMO DAMAHFKHDCF, int IAGCNBOOABC, [Optional] OutfitType? PDGOKPHFBID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x7F401D0", Offset = "0x7F3EDD0", VA = "0x187F401D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x7126370", Offset = "0x7124F70", VA = "0x187126370")]
	public bool GCJCEPEPFIK(FMEODGEFBMO DAMAHFKHDCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x7F40150", Offset = "0x7F3ED50", VA = "0x187F40150")]
	public bool LLENILCIJOJ(OutfitType? PDGOKPHFBID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x7F3FFC0", Offset = "0x7F3EBC0", VA = "0x187F3FFC0", Slot = "4")]
	public bool Equals(LNFFBNLNGPL IIOGPDPGOLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x7F40010", Offset = "0x7F3EC10", VA = "0x187F40010", Slot = "0")]
	public override bool Equals(object KOJLNGLNBMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x7F40100", Offset = "0x7F3ED00", VA = "0x187F40100", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public struct ADIGPEJPBAI : IEquatable<ADIGPEJPBAI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002A6")]
	public readonly Transform DNDOKGMEBOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40002A7")]
	public readonly bool JIDBLMKGIKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x40002A8")]
	public readonly FMEODGEFBMO LPHCHLEFKKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40002A9")]
	public readonly OutfitType? HGFEIDEMFOF;

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x7F302A0", Offset = "0x7F2EEA0", VA = "0x187F302A0")]
	public ADIGPEJPBAI(Transform JIAJBCAPIMI, bool HFHPBHLLHMJ, FMEODGEFBMO EINKPLMMDPJ, [Optional] OutfitType? KNGADKLFMFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x7F30080", Offset = "0x7F2EC80", VA = "0x187F30080", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x7F2FE20", Offset = "0x7F2EA20", VA = "0x187F2FE20", Slot = "4")]
	public bool Equals(ADIGPEJPBAI IIOGPDPGOLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x7F2FF20", Offset = "0x7F2EB20", VA = "0x187F2FF20", Slot = "0")]
	public override bool Equals(object KOJLNGLNBMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x7F30000", Offset = "0x7F2EC00", VA = "0x187F30000", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[ExecuteInEditMode]
	public class FitMeshHemisphereUpdater : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		public const float DEFAULT_Y_POSITION_OFFSET = 0.04f;

		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		public const float MAX_HEMISPHERE_POSITION_OFFSET = 0.05f;

		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		public const float MAX_HEMISPHERE_ROTATION_OFFSET = 45f;

		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		public const float MAX_HEMISPHERE_SCALE = 2f;

		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		public const float MIN_HEMISPHERE_SCALE = 0.75f;

		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		public const float MAX_HEMISPHERE_RADIUS = 0.25f;

		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		public const float MIN_HEMISPHERE_RADIUS = 0.125f;

		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		public static GameObject ContainerGO;

		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		public static GameObject CurrentHairHemisphereGO;

		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		public static Transform CurrentHairHemisphereMeshTransform;

		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		public static FitMeshHemisphereUpdater CurrentHairHemisphereUpdater;

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x7F3DFB0", Offset = "0x7F3CBB0", VA = "0x187F3DFB0")]
		public static void DespawnHairHemisphere()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020")]
		public void UpdateValues()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0xA5E010", Offset = "0xA5CC10", VA = "0x180A5E010")]
		public FitMeshHemisphereUpdater()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public interface IIAOEMEGNGH
{
	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HLLLGCPPBKJ(Mesh MOGMOMKEFJC, Matrix4x4 AGGCBFLHHCC, byte[] OENGCFNKFPA, bool PHEEBAOLCIG = false, NHDGALDIFDN.IAHAFMDMEMA DAOHBBBBAMG = (NHDGALDIFDN.IAHAFMDMEMA)0L, int FCJLMCHKHKO = -1, bool HBKKCNIBIHO = false);

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MEKGCOAEBFA(Allocator HPEAGMDCCBL, CIHDENBNPKK JEODCDOAHFC, byte CFAKMEJEFOK, [Optional] IList<int> MLFCBBDJIDF, [Optional] IList<int> FMBLNBOPKOC);
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public readonly struct IOAJMCLJGBP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002B5")]
	public readonly GameObject OOPPPHNHGDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40002B6")]
	private readonly AvatarItemMaterial MGBLDNGIKEA;

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0xBCEBD0", Offset = "0xBCD7D0", VA = "0x180BCEBD0")]
	public IOAJMCLJGBP(GameObject OOPPPHNHGDE, AvatarItemMaterial MGBLDNGIKEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x7F3FAE0", Offset = "0x7F3E6E0", VA = "0x187F3FAE0")]
	public void EICLEELKMEH(Material CIBNABIMGCK, int EFJMIKDMGKB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public class PAPFAANPPAB : PNFEEGNDFFE<Task<(GameObject, AvatarItemMaterial)>, IOAJMCLJGBP>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private struct POHCPMCLKBI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		public AsyncTaskMethodBuilder<(GameObject, AvatarItemMaterial)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		public Task<GameObject> goTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		public Task<AvatarItemMaterial> materialTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		private GameObject <go>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		private TaskAwaiter<GameObject> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		private TaskAwaiter<AvatarItemMaterial> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x7F44140", Offset = "0x7F42D40", VA = "0x187F44140", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x7F44640", Offset = "0x7F43240", VA = "0x187F44640", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002B7")]
	private MNDBKMIALLI<GameObject> ODMEBBGDDGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002B8")]
	private MNDBKMIALLI<AvatarItemMaterial> NJICOMMFNGB;

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x7F440B0", Offset = "0x7F42CB0", VA = "0x187F440B0")]
	private PAPFAANPPAB(Task<(GameObject, AvatarItemMaterial)> MHGNKNMAFFC, MNDBKMIALLI<GameObject> PHBGDAGKMBA, MNDBKMIALLI<AvatarItemMaterial> DOGJFNIJENM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x7F43A50", Offset = "0x7F42650", VA = "0x187F43A50")]
	public static PAPFAANPPAB FOGKIHKKOLG(AssetReference HCPKEGDAHDJ, [Optional] AssetReference HHCGHKOKABN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x7F43E60", Offset = "0x7F42A60", VA = "0x187F43E60", Slot = "11")]
	protected override IOAJMCLJGBP GPHJGDFDGBP(Task<(GameObject, AvatarItemMaterial)> CPPAFNIPBCD)
	{
		return default(IOAJMCLJGBP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x7F43F00", Offset = "0x7F42B00", VA = "0x187F43F00", Slot = "12")]
	protected override void NPOHFGHHAJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x7F43F80", Offset = "0x7F42B80", VA = "0x187F43F80")]
	[AsyncStateMachine(typeof(POHCPMCLKBI))]
	private static Task<(GameObject, AvatarItemMaterial)> OFNJPCKGCJG(Task<GameObject> IEFMNEEGEIG, Task<AvatarItemMaterial> ONKAKPPMGJL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public static class MJGLLHEPKHP
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private class NJOLGAMGLGM : PNFEEGNDFFE<Task<MaterialMapAsset>, Material[]>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		private MNDBKMIALLI<MaterialMapAsset> PHMFHDLJBOO;

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x7F42E10", Offset = "0x7F41A10", VA = "0x187F42E10")]
		public NJOLGAMGLGM(MNDBKMIALLI<MaterialMapAsset> PHMFHDLJBOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x7F42940", Offset = "0x7F41540", VA = "0x187F42940", Slot = "11")]
		protected override Material[] GPHJGDFDGBP(Task<MaterialMapAsset> MHGNKNMAFFC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x7F42DB0", Offset = "0x7F419B0", VA = "0x187F42DB0", Slot = "12")]
		protected override void NPOHFGHHAJJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private class KDHBFLHEMIC : PNFEEGNDFFE<Task<Material[]>, Material[]>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		private List<MNDBKMIALLI<Material>> PFNBMKKIEIH;

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x7F3FD00", Offset = "0x7F3E900", VA = "0x187F3FD00")]
		public KDHBFLHEMIC(Task<Material[]> MHGNKNMAFFC, List<MNDBKMIALLI<Material>> PFNBMKKIEIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x7F3FB70", Offset = "0x7F3E770", VA = "0x187F3FB70", Slot = "11")]
		protected override Material[] GPHJGDFDGBP(Task<Material[]> CPPAFNIPBCD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x7F3FBC0", Offset = "0x7F3E7C0", VA = "0x187F3FBC0", Slot = "12")]
		protected override void NPOHFGHHAJJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40002C3")]
	private static readonly PEOHNMCPNIJ GDLIBGFAMED;

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x7F42440", Offset = "0x7F41040", VA = "0x187F42440")]
	public static MNDBKMIALLI<Material[]> JDPMOECOLBG(AssetReference[] IIPPMFJKBON)
	{
		return null;
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[DisallowMultipleComponent]
	public class PlayerAvatarDisplayBase : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000056")]
		public enum LCNHBILGNCP
		{
			[Cpp2IlInjected.Token(Token = "0x4000355")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4000356")]
			TeamItem,
			[Cpp2IlInjected.Token(Token = "0x4000357")]
			SkinColor,
			[Cpp2IlInjected.Token(Token = "0x4000358")]
			HairColor,
			[Cpp2IlInjected.Token(Token = "0x4000359")]
			BeardColor,
			[Cpp2IlInjected.Token(Token = "0x400035A")]
			UGCShirtColor
		}

		[Cpp2IlInjected.Token(Token = "0x2000057")]
		public enum FGBMNMMNDIK
		{
			[Cpp2IlInjected.Token(Token = "0x400035C")]
			None,
			[Cpp2IlInjected.Token(Token = "0x400035D")]
			HairTexture,
			[Cpp2IlInjected.Token(Token = "0x400035E")]
			BeardTexture,
			[Cpp2IlInjected.Token(Token = "0x400035F")]
			UGCShirtTexture
		}

		[Cpp2IlInjected.Token(Token = "0x2000058")]
		public enum EHCLJPCILOK : byte
		{
			[Cpp2IlInjected.Token(Token = "0x4000361")]
			All,
			[Cpp2IlInjected.Token(Token = "0x4000362")]
			LOD0Only,
			[Cpp2IlInjected.Token(Token = "0x4000363")]
			EditorToolAll
		}

		[Cpp2IlInjected.Token(Token = "0x2000059")]
		public struct LENHNHJEOJA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000364")]
			public readonly Material HLAFGCCNOEP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000365")]
			public readonly LCNHBILGNCP GOJHPLOIDPF;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x4000366")]
			public readonly FGBMNMMNDIK OIPCPAEANLP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000367")]
			public readonly FMEODGEFBMO OABIFIEMPAN;

			[Cpp2IlInjected.Token(Token = "0x60002FA")]
			[Cpp2IlInjected.Address(RVA = "0x7F583C0", Offset = "0x7F56FC0", VA = "0x187F583C0")]
			public LENHNHJEOJA(Material CIBNABIMGCK, LCNHBILGNCP NJNJPMCMHDI, FGBMNMMNDIK CGBIMBKLAJP, FMEODGEFBMO DAMAHFKHDCF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002FB")]
			[Cpp2IlInjected.Address(RVA = "0x7F58190", Offset = "0x7F56D90", VA = "0x187F58190", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002FC")]
			[Cpp2IlInjected.Address(RVA = "0x7F58110", Offset = "0x7F56D10", VA = "0x187F58110")]
			public bool PIPOKDEFBMK(LENHNHJEOJA IIOGPDPGOLB)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002FD")]
			[Cpp2IlInjected.Address(RVA = "0x7F57F80", Offset = "0x7F56B80", VA = "0x187F57F80", Slot = "0")]
			public override bool Equals(object KOJLNGLNBMH)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002FE")]
			[Cpp2IlInjected.Address(RVA = "0x7F58070", Offset = "0x7F56C70", VA = "0x187F58070", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005A")]
		protected class DIDNBDMFFHM : IComparable<DIDNBDMFFHM>, IEquatable<DIDNBDMFFHM>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000368")]
			public int NMLEEMFACJF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000369")]
			public PlayerAvatarDisplayBase BAMDPIFKGNE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400036A")]
			public IList<OPKKBLJLHPN> PAMAKGAKJII;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400036B")]
			public AvatarItemBodyType LDKGJOHMAJK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x400036C")]
			public NMCGFIKJCCM PJMJDGHNBND;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400036D")]
			public bool OFKBCIPHGEC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
			[Cpp2IlInjected.Token(Token = "0x400036E")]
			public bool MMKAHFLNJKC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400036F")]
			public int[] IBCGOKACOGJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000370")]
			public float LDMAJBAGNJL;

			[Cpp2IlInjected.Token(Token = "0x60002FF")]
			[Cpp2IlInjected.Address(RVA = "0x7F54850", Offset = "0x7F53450", VA = "0x187F54850", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000300")]
			[Cpp2IlInjected.Address(RVA = "0x7F54700", Offset = "0x7F53300", VA = "0x187F54700", Slot = "4")]
			public int CompareTo(DIDNBDMFFHM IIOGPDPGOLB)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000301")]
			[Cpp2IlInjected.Address(RVA = "0x7F54730", Offset = "0x7F53330", VA = "0x187F54730", Slot = "5")]
			public bool Equals(DIDNBDMFFHM IIOGPDPGOLB)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000302")]
			[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
			public DIDNBDMFFHM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005B")]
		protected abstract class LKCMBLIHNDD
		{
			[Cpp2IlInjected.Token(Token = "0x200005C")]
			public class HKBAANMKCCK
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000374")]
				public readonly Mesh BADKGBBIDDE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000375")]
				public readonly Material[] CNMEAGKKLPA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000376")]
				public readonly Transform[] JDGEMGANNFO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000377")]
				public readonly Matrix4x4[] ANJGAGHPJBO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000378")]
				public readonly Transform NDGFBNOBOLK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000379")]
				public readonly bool HPHBKPENCHK;

				[Cpp2IlInjected.Token(Token = "0x600030A")]
				[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
				protected HKBAANMKCCK()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600030B")]
				[Cpp2IlInjected.Address(RVA = "0x7F55D60", Offset = "0x7F54960", VA = "0x187F55D60")]
				public HKBAANMKCCK(Mesh MOGMOMKEFJC, Material[] LHOKNIPAKDG, bool EOGBBJLCDMC, Transform[] EFBCPLLDMDA, Transform ILKEDKCONJG, Matrix4x4[] EDHJAEMPCCC)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600030C")]
				[Cpp2IlInjected.Address(RVA = "0x7F55BB0", Offset = "0x7F547B0", VA = "0x187F55BB0")]
				private HKBAANMKCCK(SkinnedMeshRenderer HDHHGHHFCGB, Material[] JOFMMFDPBBN)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600030D")]
				[Cpp2IlInjected.Address(RVA = "0x7F55C70", Offset = "0x7F54870", VA = "0x187F55C70")]
				private HKBAANMKCCK(MeshRenderer OFKIGCBINDN, Transform ILKEDKCONJG, Material[] JOFMMFDPBBN)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600030E")]
				[Cpp2IlInjected.Address(RVA = "0x7F55890", Offset = "0x7F54490", VA = "0x187F55890")]
				public static HKBAANMKCCK CBMDLNOIFCE(Renderer NMGNJGPOFCI, Material[] JOFMMFDPBBN)
				{
					return null;
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000371")]
			public readonly FMEODGEFBMO OABIFIEMPAN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000372")]
			public readonly Transform KIJPIANMHIP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000373")]
			public readonly bool LLAHKFCOIMO;

			[Cpp2IlInjected.Token(Token = "0x1700008F")]
			public virtual bool FAKPFMLAPEB
			{
				[Cpp2IlInjected.Token(Token = "0x6000303")]
				[Cpp2IlInjected.Address(RVA = "0xAA76B0", Offset = "0xAA62B0", VA = "0x180AA76B0", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000090")]
			public virtual bool IBFPJIMPKDD
			{
				[Cpp2IlInjected.Token(Token = "0x6000304")]
				[Cpp2IlInjected.Address(RVA = "0xAA76B0", Offset = "0xAA62B0", VA = "0x180AA76B0", Slot = "5")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000091")]
			public virtual NHDGALDIFDN.IAHAFMDMEMA FIDCIFKDNCG
			{
				[Cpp2IlInjected.Token(Token = "0x6000305")]
				[Cpp2IlInjected.Address(RVA = "0xA5E030", Offset = "0xA5CC30", VA = "0x180A5E030", Slot = "6")]
				get
				{
					return default(NHDGALDIFDN.IAHAFMDMEMA);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000092")]
			public bool JGCCDILKJJE
			{
				[Cpp2IlInjected.Token(Token = "0x6000306")]
				[Cpp2IlInjected.Address(RVA = "0x7F58870", Offset = "0x7F57470", VA = "0x187F58870")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000307")]
			[Cpp2IlInjected.Address(RVA = "0x7F58880", Offset = "0x7F57480", VA = "0x187F58880")]
			protected LKCMBLIHNDD(FMEODGEFBMO DAMAHFKHDCF, Transform APIFMJLKEFJ, bool PKPLGFNPONH = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000308")]
			[Cpp2IlInjected.Address(Slot = "7")]
			public abstract IPNMFPLCPOG CEPOKNGCKPE(List<IGJFGOMAIOE> HFFIFNAHKHL, List<IGJFGOMAIOE> AOOAIAPGBLH);

			[Cpp2IlInjected.Token(Token = "0x6000309")]
			[Cpp2IlInjected.Address(Slot = "8")]
			public abstract HKBAANMKCCK EJBDMIJOLKP(int LGKJAMKLNMC, PlayerHandBones FNCFLANIFDN);
		}

		[Cpp2IlInjected.Token(Token = "0x200005D")]
		protected class FIBKBGJBILK : LKCMBLIHNDD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400037A")]
			protected readonly BodyPartLODs PNOGJCJEOOB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400037B")]
			protected readonly Material[] NEHOLAFBBKA;

			[Cpp2IlInjected.Token(Token = "0x600030F")]
			[Cpp2IlInjected.Address(RVA = "0x7F54C60", Offset = "0x7F53860", VA = "0x187F54C60")]
			public FIBKBGJBILK(FMEODGEFBMO DAMAHFKHDCF, BodyPartLODs IBDMHKPBNCE, Material ANNJOCIGHNI, [Optional] Transform APIFMJLKEFJ, bool PKPLGFNPONH = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000310")]
			[Cpp2IlInjected.Address(RVA = "0x7F549A0", Offset = "0x7F535A0", VA = "0x187F549A0", Slot = "7")]
			public override IPNMFPLCPOG CEPOKNGCKPE(List<IGJFGOMAIOE> HFFIFNAHKHL, List<IGJFGOMAIOE> AOOAIAPGBLH)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000311")]
			[Cpp2IlInjected.Address(RVA = "0x7F54A30", Offset = "0x7F53630", VA = "0x187F54A30", Slot = "8")]
			public override HKBAANMKCCK EJBDMIJOLKP(int LGKJAMKLNMC, PlayerHandBones FNCFLANIFDN)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000312")]
			[Cpp2IlInjected.Address(RVA = "0x7F54BF0", Offset = "0x7F537F0", VA = "0x187F54BF0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005E")]
		protected class LIIGLHKGBNA : LKCMBLIHNDD
		{
			[Cpp2IlInjected.Token(Token = "0x17000093")]
			public override bool FAKPFMLAPEB
			{
				[Cpp2IlInjected.Token(Token = "0x6000313")]
				[Cpp2IlInjected.Address(RVA = "0xA77810", Offset = "0xA76410", VA = "0x180A77810", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000094")]
			public override bool IBFPJIMPKDD
			{
				[Cpp2IlInjected.Token(Token = "0x6000314")]
				[Cpp2IlInjected.Address(RVA = "0x7F58740", Offset = "0x7F57340", VA = "0x187F58740", Slot = "5")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000095")]
			public OBOPCOPCCAH BJIIKPBAPDG
			{
				[Cpp2IlInjected.Token(Token = "0x6000315")]
				[Cpp2IlInjected.Address(RVA = "0xA5B5E0", Offset = "0xA5A1E0", VA = "0x180A5B5E0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000316")]
				[Cpp2IlInjected.Address(RVA = "0xA683D0", Offset = "0xA66FD0", VA = "0x180A683D0")]
				[CompilerGenerated]
				protected set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000317")]
			[Cpp2IlInjected.Address(RVA = "0x7F58800", Offset = "0x7F57400", VA = "0x187F58800")]
			public LIIGLHKGBNA(FMEODGEFBMO DAMAHFKHDCF, Transform APIFMJLKEFJ, OBOPCOPCCAH BFAKLNDJFBH, bool PKPLGFNPONH = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000318")]
			[Cpp2IlInjected.Address(RVA = "0x7F586B0", Offset = "0x7F572B0", VA = "0x187F586B0", Slot = "7")]
			public override IPNMFPLCPOG CEPOKNGCKPE(List<IGJFGOMAIOE> HFFIFNAHKHL, List<IGJFGOMAIOE> AOOAIAPGBLH)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000319")]
			[Cpp2IlInjected.Address(RVA = "0xA5E030", Offset = "0xA5CC30", VA = "0x180A5E030", Slot = "8")]
			public override HKBAANMKCCK EJBDMIJOLKP(int LGKJAMKLNMC, PlayerHandBones FNCFLANIFDN)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600031A")]
			[Cpp2IlInjected.Address(RVA = "0x7F58790", Offset = "0x7F57390", VA = "0x187F58790", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005F")]
		public class KEDBGABIIJL
		{
			[Cpp2IlInjected.Token(Token = "0x2000060")]
			public enum AJJCKCCBPOG
			{
				[Cpp2IlInjected.Token(Token = "0x400038D")]
				PLAYER_PUPPET,
				[Cpp2IlInjected.Token(Token = "0x400038E")]
				PLAYER_DISPLAY_POSER,
				[Cpp2IlInjected.Token(Token = "0x400038F")]
				PLAYER_HAND,
				[Cpp2IlInjected.Token(Token = "0x4000390")]
				STNMONSTERCOSTUME_OPTION_HIDE_EXCEPT_UI,
				[Cpp2IlInjected.Token(Token = "0x4000391")]
				PLAYER_HAND_POINTING,
				[Cpp2IlInjected.Token(Token = "0x4000392")]
				STNMONSTERCOSTUME_OPTION_ALWAYS_HIDE,
				[Cpp2IlInjected.Token(Token = "0x4000393")]
				EDITOR
			}

			[Cpp2IlInjected.Token(Token = "0x400037D")]
			public static readonly int NMBDFPJEABP;

			[Cpp2IlInjected.Token(Token = "0x400037E")]
			public static readonly int AMKFKJJLAGK;

			[Cpp2IlInjected.Token(Token = "0x400037F")]
			public static readonly int GOMCGOHCNHF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000380")]
			protected readonly HFDBLEOKNJB FJDDFMKMNAH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000381")]
			protected readonly BHILPPFHJPD MEILKNFOKCC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000382")]
			protected readonly Animator JCIIPPJBBBO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000383")]
			protected readonly Transform BDCDEMOBEBO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000384")]
			public Vector3 PKOFHKOIEEK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000385")]
			protected readonly Transform DHBNEEFLFAC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000386")]
			public Vector3 GHHANKJFNAC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x4000387")]
			protected bool EICGFGOGOGC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000388")]
			protected LAJPNBFOHGM GPHGGNJECND;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000389")]
			protected bool GMPOPHABDBK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
			[Cpp2IlInjected.Token(Token = "0x400038A")]
			protected float FJEGEAHFPMC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x400038B")]
			protected ENGNEPIGOEM<IKOIPHKGCMC> ECFGPBEJBNP;

			[Cpp2IlInjected.Token(Token = "0x17000096")]
			public LAJPNBFOHGM JFCBLONGAII
			{
				[Cpp2IlInjected.Token(Token = "0x600031B")]
				[Cpp2IlInjected.Address(RVA = "0xA5B530", Offset = "0xA5A130", VA = "0x180A5B530")]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600031C")]
				[Cpp2IlInjected.Address(RVA = "0xA5B780", Offset = "0xA5A380", VA = "0x180A5B780")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000097")]
			public bool FLILFIJFFPO
			{
				[Cpp2IlInjected.Token(Token = "0x600031D")]
				[Cpp2IlInjected.Address(RVA = "0xD1C170", Offset = "0xD1AD70", VA = "0x180D1C170")]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x600031E")]
				[Cpp2IlInjected.Address(RVA = "0x7F56E40", Offset = "0x7F55A40", VA = "0x187F56E40")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000098")]
			public bool PNLMOHBGCCB
			{
				[Cpp2IlInjected.Token(Token = "0x600031F")]
				[Cpp2IlInjected.Address(RVA = "0xA5B5F0", Offset = "0xA5A1F0", VA = "0x180A5B5F0")]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x6000320")]
				[Cpp2IlInjected.Address(RVA = "0x7F56D70", Offset = "0x7F55970", VA = "0x187F56D70")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000099")]
			public float DDPLBMEBNOI
			{
				[Cpp2IlInjected.Token(Token = "0x6000321")]
				[Cpp2IlInjected.Address(RVA = "0xDAA020", Offset = "0xDA8C20", VA = "0x180DAA020")]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x6000322")]
				[Cpp2IlInjected.Address(RVA = "0x7F56F50", Offset = "0x7F55B50", VA = "0x187F56F50")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009A")]
			public IKOIPHKGCMC IHONIBBIJDO
			{
				[Cpp2IlInjected.Token(Token = "0x6000323")]
				[Cpp2IlInjected.Address(RVA = "0x7F56F10", Offset = "0x7F55B10", VA = "0x187F56F10")]
				get
				{
					return default(IKOIPHKGCMC);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000324")]
			[Cpp2IlInjected.Address(RVA = "0x7F56C60", Offset = "0x7F55860", VA = "0x187F56C60")]
			public bool ABKIHGDJOPG(IKOIPHKGCMC JFHAPJGHCAG, object DANCOEFIHDF, AJJCKCCBPOG PBEMDBEINCB)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000325")]
			[Cpp2IlInjected.Address(RVA = "0x7F570E0", Offset = "0x7F55CE0", VA = "0x187F570E0")]
			public bool HBOGINMGPLF(object DANCOEFIHDF)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000326")]
			[Cpp2IlInjected.Address(RVA = "0x7F57EF0", Offset = "0x7F56AF0", VA = "0x187F57EF0")]
			protected KEDBGABIIJL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000327")]
			[Cpp2IlInjected.Address(RVA = "0x7F57900", Offset = "0x7F56500", VA = "0x187F57900")]
			public KEDBGABIIJL(HFDBLEOKNJB FJDDFMKMNAH, LAJPNBFOHGM EKECOKDHPKI, Animator JCIIPPJBBBO, Transform BDCDEMOBEBO, Transform DHBNEEFLFAC, Vector3 PKOFHKOIEEK, Vector3 GHHANKJFNAC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000328")]
			[Cpp2IlInjected.Address(RVA = "0x7F57490", Offset = "0x7F56090", VA = "0x187F57490")]
			private void MBOKFPBGDGJ(ushort ILFGHNPHOOE, ushort AMMJLEHKKNO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000329")]
			[Cpp2IlInjected.Address(RVA = "0x7F57760", Offset = "0x7F56360", VA = "0x187F57760")]
			protected void PNBHBMKDNIB(ushort ILFGHNPHOOE, ushort AMMJLEHKKNO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600032A")]
			[Cpp2IlInjected.Address(RVA = "0x7F57650", Offset = "0x7F56250", VA = "0x187F57650")]
			protected void MNJPMKNMHGK(ushort ILFGHNPHOOE, ushort AMMJLEHKKNO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600032B")]
			[Cpp2IlInjected.Address(RVA = "0x7F571E0", Offset = "0x7F55DE0", VA = "0x187F571E0")]
			protected void HHFCJKFEAOA(ushort ILFGHNPHOOE, ushort AMMJLEHKKNO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600032C")]
			[Cpp2IlInjected.Address(RVA = "0x7F57540", Offset = "0x7F56140", VA = "0x187F57540")]
			protected void MGOAKGBPMOH(ushort ILFGHNPHOOE, ushort AMMJLEHKKNO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600032D")]
			[Cpp2IlInjected.Address(RVA = "0x7F57430", Offset = "0x7F56030", VA = "0x187F57430")]
			protected void KLCIBKBGKGK(ushort ILFGHNPHOOE, ushort AMMJLEHKKNO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600032E")]
			[Cpp2IlInjected.Address(RVA = "0x7F57090", Offset = "0x7F55C90", VA = "0x187F57090")]
			protected void GAKNNPMHLOE(ushort ILFGHNPHOOE, ushort AMMJLEHKKNO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600032F")]
			[Cpp2IlInjected.Address(RVA = "0x7F57710", Offset = "0x7F56310", VA = "0x187F57710")]
			protected void MPMOODNBAKL(ushort ILFGHNPHOOE, ushort AMMJLEHKKNO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000330")]
			[Cpp2IlInjected.Address(RVA = "0x7F57310", Offset = "0x7F55F10", VA = "0x187F57310")]
			protected void JCOBNHPGOMO(ushort ILFGHNPHOOE, ushort AMMJLEHKKNO)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000061")]
		public class LKNKINEHDKB : IDisposable
		{
			[Cpp2IlInjected.Token(Token = "0x4000394")]
			public const int NKAKINAHAEN = 16;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000395")]
			protected MaterialPropertyBlock AAEPGNLGOCA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000396")]
			public Color? LJBOEBCKBMA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000397")]
			public Color? OMNLCKLFFFJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000398")]
			public Color? BIDCNEDALNM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x4000399")]
			public Color KOPJJILCAFG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
			[Cpp2IlInjected.Token(Token = "0x400039A")]
			public Color IAAIBKHMFDG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
			[Cpp2IlInjected.Token(Token = "0x400039B")]
			public Color BJBEMIFEAEB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x400039C")]
			public Texture2D EAOGKHNGLGH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x400039D")]
			public Texture2D LDIJLOIDKGF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x400039E")]
			protected Dictionary<LENHNHJEOJA, int> GENHJABGEMI;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x400039F")]
			protected LCNHBILGNCP[] EOMGFPFAJCF;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x40003A0")]
			public Vector4[] OMLDCPLLAKP;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x40003A1")]
			public Vector4[] FBBKKEMMOEH;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x40003A2")]
			public Vector4[] AKKPEMIAGGP;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x40003A3")]
			public Vector4[] NNENGGAGGCG;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
			[Cpp2IlInjected.Token(Token = "0x40003A4")]
			public Vector4[] FHHDIPHHPPB;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
			[Cpp2IlInjected.Token(Token = "0x40003A5")]
			public Vector4[] HCPMDFLOLJH;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x40003A6")]
			protected List<Texture2D> BPOLKKCCEAN;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x40003A7")]
			protected Vector4[] OFELHCHCHCK;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
			[Cpp2IlInjected.Token(Token = "0x40003A8")]
			protected List<Texture2D> KMIOAHANBON;

			[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
			[Cpp2IlInjected.Token(Token = "0x40003A9")]
			protected float[] BOIFDALNHLP;

			[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
			[Cpp2IlInjected.Token(Token = "0x40003AA")]
			protected Vector4[] IPHLIBKDGGH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
			[Cpp2IlInjected.Token(Token = "0x40003AB")]
			protected float[] MNKANCEJFDD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
			[Cpp2IlInjected.Token(Token = "0x40003AC")]
			public float[] IOGPMFGJINB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
			[Cpp2IlInjected.Token(Token = "0x40003AD")]
			protected List<Texture2D> APPEJMJKMCJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
			[Cpp2IlInjected.Token(Token = "0x40003AE")]
			protected float[] BBJLAIJLDKI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
			[Cpp2IlInjected.Token(Token = "0x40003AF")]
			protected List<Texture2D> EJAKHLOIBMD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
			[Cpp2IlInjected.Token(Token = "0x40003B0")]
			protected Vector4[] CELFNGJNCKG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
			[Cpp2IlInjected.Token(Token = "0x40003B1")]
			protected float[] JGOAKKLFDDG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
			[Cpp2IlInjected.Token(Token = "0x40003B2")]
			protected Vector4[] MFBFOHFONGF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
			[Cpp2IlInjected.Token(Token = "0x40003B3")]
			public float[] CHJMNNEAANF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
			[Cpp2IlInjected.Token(Token = "0x40003B4")]
			public Texture2DArray GJALMMNHPPA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
			[Cpp2IlInjected.Token(Token = "0x40003B5")]
			public Texture2DArray GDPJAEJCLGC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
			[Cpp2IlInjected.Token(Token = "0x40003B6")]
			public Texture2DArray COOMJCDKFPF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
			[Cpp2IlInjected.Token(Token = "0x40003B7")]
			public Texture2DArray JAODKGKJBJL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
			[Cpp2IlInjected.Token(Token = "0x40003B8")]
			protected bool MEDAJCPFONL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x16C")]
			[Cpp2IlInjected.Token(Token = "0x40003B9")]
			protected int FMCEDIOCNHI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
			[Cpp2IlInjected.Token(Token = "0x40003BA")]
			protected Vector2? FDOIIKLMAMF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x17C")]
			[Cpp2IlInjected.Token(Token = "0x40003BB")]
			protected TextureFormat INCGHJMOAII;

			[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
			[Cpp2IlInjected.Token(Token = "0x40003BC")]
			protected Vector2? KJDEGGNPJCD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18C")]
			[Cpp2IlInjected.Token(Token = "0x40003BD")]
			protected TextureFormat AHLHOJPHHON;

			[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
			[Cpp2IlInjected.Token(Token = "0x40003BE")]
			protected Vector2? FMOBLOGLBPD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x19C")]
			[Cpp2IlInjected.Token(Token = "0x40003BF")]
			protected TextureFormat DODIDIILNFL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
			[Cpp2IlInjected.Token(Token = "0x40003C0")]
			protected Vector2? OCLKJHFEOOM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1AC")]
			[Cpp2IlInjected.Token(Token = "0x40003C1")]
			protected TextureFormat BGDOBDMFFDE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
			[Cpp2IlInjected.Token(Token = "0x40003C2")]
			protected bool KBLIMDOOPKN;

			[Cpp2IlInjected.Token(Token = "0x40003C3")]
			protected static int JBDGHADDEMA;

			[Cpp2IlInjected.Token(Token = "0x40003C4")]
			protected static int MAGEIEKALDA;

			[Cpp2IlInjected.Token(Token = "0x40003C5")]
			protected static int IHAPNJICFOE;

			[Cpp2IlInjected.Token(Token = "0x40003C6")]
			protected static int IKNIDPECHAH;

			[Cpp2IlInjected.Token(Token = "0x40003C7")]
			protected static int FLHLOJFBLJJ;

			[Cpp2IlInjected.Token(Token = "0x40003C8")]
			protected static int HMGAFLEBLGC;

			[Cpp2IlInjected.Token(Token = "0x40003C9")]
			protected static int FMFPKLGCOBN;

			[Cpp2IlInjected.Token(Token = "0x40003CA")]
			protected static int EAIOHIJELAC;

			[Cpp2IlInjected.Token(Token = "0x40003CB")]
			protected static int LEGIFDAFIPO;

			[Cpp2IlInjected.Token(Token = "0x40003CC")]
			protected static int FOKBFCAFMEN;

			[Cpp2IlInjected.Token(Token = "0x40003CD")]
			protected static int IBGHFFLBPFK;

			[Cpp2IlInjected.Token(Token = "0x40003CE")]
			protected static int CJNIHIHMHHF;

			[Cpp2IlInjected.Token(Token = "0x40003CF")]
			protected static int GMFBPNJJDFF;

			[Cpp2IlInjected.Token(Token = "0x40003D0")]
			protected static int KHOCHDHKODM;

			[Cpp2IlInjected.Token(Token = "0x40003D1")]
			protected static int DOPBKJKGJJP;

			[Cpp2IlInjected.Token(Token = "0x40003D2")]
			protected static int CIFHHPMMGPE;

			[Cpp2IlInjected.Token(Token = "0x40003D3")]
			protected static int DBDKIAGPNFO;

			[Cpp2IlInjected.Token(Token = "0x40003D4")]
			protected static int IEHJAKNLBGI;

			[Cpp2IlInjected.Token(Token = "0x40003D5")]
			protected static int NMMLHDNCMFH;

			[Cpp2IlInjected.Token(Token = "0x40003D6")]
			protected static int FHEKDPDMKLE;

			[Cpp2IlInjected.Token(Token = "0x6000332")]
			[Cpp2IlInjected.Address(RVA = "0x7F5AE60", Offset = "0x7F59A60", VA = "0x187F5AE60")]
			protected LKNKINEHDKB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000333")]
			[Cpp2IlInjected.Address(RVA = "0x7F5B320", Offset = "0x7F59F20", VA = "0x187F5B320")]
			public LKNKINEHDKB(Color IPMDPNHHNEA, Color BMHHKGCHFPO, Color JHFBHOAEIII, Color? GJHFBLCJOMB, Color? JNKDCIOCBIL, Color? ICEPGJOMBAG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000334")]
			[Cpp2IlInjected.Address(RVA = "0x7F58F40", Offset = "0x7F57B40", VA = "0x187F58F40")]
			public int ICIIFBKDJKC(Material IMDEKKHNMFK, LCNHBILGNCP NJNJPMCMHDI, FGBMNMMNDIK CGBIMBKLAJP, FMEODGEFBMO DAMAHFKHDCF)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000335")]
			[Cpp2IlInjected.Address(RVA = "0x7F58EB0", Offset = "0x7F57AB0", VA = "0x187F58EB0")]
			public int ICIIFBKDJKC(LENHNHJEOJA DHCHBFGMFFD)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000336")]
			[Cpp2IlInjected.Address(RVA = "0x7F59DD0", Offset = "0x7F589D0", VA = "0x187F59DD0")]
			public int PJIJKGNOILN(Material IMDEKKHNMFK, Color HFDHMLDHBON, Color PKGKBHAFMOB, Color NCPNPPFPDAJ, Color MJPALICOCKK, Color LFBJGGGMMJK, Texture2D GCDEPIPMJIA, Vector4 MKNBOFGAIAI, Texture2D EDJINEAFLLI, Vector4 AOAAKPNAIOK, float MJAKGEBFOEK, float PIEDNHOOJOB, Texture2D CJHHJJIJLLM, Vector4 DECAOKHLJFH, float IKHMCJGJCAM, Texture2D OCJNOMNDILO, float DGJFAMIKDFD, Color CNKHHILNLEM, Vector4 FDMMDDEPHAG, LCNHBILGNCP NJNJPMCMHDI, FGBMNMMNDIK CGBIMBKLAJP, FMEODGEFBMO DAMAHFKHDCF)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000337")]
			[Cpp2IlInjected.Address(RVA = "0x7F58CF0", Offset = "0x7F578F0", VA = "0x187F58CF0")]
			protected void IAOMDDOLPBO([Out] Texture2DArray EHNJGNFMLHH, [Out] Texture2DArray KBODBMFKJAF, [Out] Texture2DArray PEJGLGJFBLA, [Out] Texture2DArray LAAIJPLFLGB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000338")]
			[Cpp2IlInjected.Address(RVA = "0x7F59030", Offset = "0x7F57C30", VA = "0x187F59030")]
			public void PBBKPLAANFB(PlayerAvatarDisplayBase JLCBIDDGHHF, Renderer NMGNJGPOFCI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000339")]
			[Cpp2IlInjected.Address(RVA = "0x7F592A0", Offset = "0x7F57EA0", VA = "0x187F592A0")]
			protected void PHEEOHGBGPJ(PlayerAvatarDisplayBase JLCBIDDGHHF, Renderer NMGNJGPOFCI, int PMBABFOLNNI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600033A")]
			[Cpp2IlInjected.Address(RVA = "0x7F58B00", Offset = "0x7F57700", VA = "0x187F58B00")]
			private Color FJLEMLGNGAD(Color KOHLOJJGEEK, LCNHBILGNCP JJPCHCCDGCE)
			{
				return default(Color);
			}

			[Cpp2IlInjected.Token(Token = "0x600033B")]
			[Cpp2IlInjected.Address(RVA = "0x7F589B0", Offset = "0x7F575B0", VA = "0x187F589B0")]
			private Color FDAMHPEPAID(Color PKGBEKIHFMF, LCNHBILGNCP JJPCHCCDGCE)
			{
				return default(Color);
			}

			[Cpp2IlInjected.Token(Token = "0x600033C")]
			[Cpp2IlInjected.Address(RVA = "0x7F588E0", Offset = "0x7F574E0", VA = "0x187F588E0")]
			protected void APNDHCMKCMF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600033D")]
			[Cpp2IlInjected.Address(RVA = "0x7F58970", Offset = "0x7F57570", VA = "0x187F58970", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000062")]
		public struct PlayerHandBones
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003D7")]
			public Transform[] LeftHandBones;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003D8")]
			public Transform LeftHandRoot;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003D9")]
			public Transform[] RightHandBones;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003DA")]
			public Transform RightHandRoot;

			[Cpp2IlInjected.Token(Token = "0x600033F")]
			[Cpp2IlInjected.Address(RVA = "0x7F62A00", Offset = "0x7F61600", VA = "0x187F62A00")]
			public void MAFDNPOABMF(FMEODGEFBMO DAMAHFKHDCF, [Out] Transform OLIIIAEGOLD, [Out] Transform[] EFBCPLLDMDA)
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000063")]
		protected struct BodyPartLODs
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003DB")]
			public Mesh[] LODs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003DC")]
			public bool UseHandBones;
		}

		[Cpp2IlInjected.Token(Token = "0x2000065")]
		[CompilerGenerated]
		private sealed class MLGCMPMNFLD : IEnumerable<SkinnedMeshRenderer>, IEnumerable, IEnumerator<SkinnedMeshRenderer>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003E4")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003E5")]
			private SkinnedMeshRenderer <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003E6")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003E7")]
			public PlayerAvatarDisplayBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003E8")]
			private SkinnedMeshRenderer[] <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003E9")]
			private int <>7__wrap2;

			[Cpp2IlInjected.Token(Token = "0x1700009B")]
			SkinnedMeshRenderer IEnumerator<SkinnedMeshRenderer>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600034B")]
				[Cpp2IlInjected.Address(RVA = "0xA5B610", Offset = "0xA5A210", VA = "0x180A5B610", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009C")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600034D")]
				[Cpp2IlInjected.Address(RVA = "0xA5B610", Offset = "0xA5A210", VA = "0x180A5B610", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000348")]
			[Cpp2IlInjected.Address(RVA = "0xF91620", Offset = "0xF90220", VA = "0x180F91620")]
			[DebuggerHidden]
			public MLGCMPMNFLD(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000349")]
			[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034A")]
			[Cpp2IlInjected.Address(RVA = "0x7F5B3B0", Offset = "0x7F59FB0", VA = "0x187F5B3B0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600034C")]
			[Cpp2IlInjected.Address(RVA = "0x7F5B630", Offset = "0x7F5A230", VA = "0x187F5B630", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034E")]
			[Cpp2IlInjected.Address(RVA = "0x7F5B580", Offset = "0x7F5A180", VA = "0x187F5B580", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<SkinnedMeshRenderer> IEnumerable<SkinnedMeshRenderer>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600034F")]
			[Cpp2IlInjected.Address(RVA = "0x7F5B580", Offset = "0x7F5A180", VA = "0x187F5B580", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000066")]
		[CompilerGenerated]
		private sealed class HFLBONIPAII
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003EA")]
			public PlayerAvatarDisplayBase display;

			[Cpp2IlInjected.Token(Token = "0x6000350")]
			[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
			public HFLBONIPAII()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000351")]
			[Cpp2IlInjected.Address(RVA = "0x7F555B0", Offset = "0x7F541B0", VA = "0x187F555B0")]
			internal bool NJPFOLEBGMD()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000067")]
		[CompilerGenerated]
		private sealed class IEHLCHKMAEP : IEnumerator<LIPOFPKAEIK>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003EB")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003EC")]
			private LIPOFPKAEIK <>2__current;

			[Cpp2IlInjected.Token(Token = "0x1700009D")]
			private LIPOFPKAEIK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000355")]
				[Cpp2IlInjected.Address(RVA = "0xA5B610", Offset = "0xA5A210", VA = "0x180A5B610", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009E")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000357")]
				[Cpp2IlInjected.Address(RVA = "0xA5B610", Offset = "0xA5A210", VA = "0x180A5B610", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000352")]
			[Cpp2IlInjected.Address(RVA = "0xA62C00", Offset = "0xA61800", VA = "0x180A62C00")]
			[DebuggerHidden]
			public IEHLCHKMAEP(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000353")]
			[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000354")]
			[Cpp2IlInjected.Address(RVA = "0x7F56610", Offset = "0x7F55210", VA = "0x187F56610", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000356")]
			[Cpp2IlInjected.Address(RVA = "0x7F56960", Offset = "0x7F55560", VA = "0x187F56960", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000068")]
		[CompilerGenerated]
		private struct HMHCIKKJDHJ : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003ED")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003EE")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003EF")]
			public PlayerAvatarDisplayBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003F0")]
			public DNHFACAJPBE avatarData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003F1")]
			private bool <forceRebuild>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003F2")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000358")]
			[Cpp2IlInjected.Address(RVA = "0x7F56210", Offset = "0x7F54E10", VA = "0x187F56210", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000359")]
			[Cpp2IlInjected.Address(RVA = "0x7F565B0", Offset = "0x7F551B0", VA = "0x187F565B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000069")]
		[CompilerGenerated]
		private sealed class OJBHDMALBOK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003F3")]
			public string overrideIdentifier;

			[Cpp2IlInjected.Token(Token = "0x600035A")]
			[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
			public OJBHDMALBOK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600035B")]
			[Cpp2IlInjected.Address(RVA = "0x7F5BAD0", Offset = "0x7F5A6D0", VA = "0x187F5BAD0")]
			internal bool JACOMJHDHLG(OPKKBLJLHPN selection)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006A")]
		[CompilerGenerated]
		private sealed class LIHLGOLNPLP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003F4")]
			public PlayerAvatarDisplayBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003F5")]
			public AvatarItemBodyType avatarItemBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003F6")]
			public Func<AIDGEFHMIOM<Dictionary<string, MNDBKMIALLI<Texture2D>>>> <>9__2;

			[Cpp2IlInjected.Token(Token = "0x600035C")]
			[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
			public LIHLGOLNPLP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600035D")]
			[Cpp2IlInjected.Address(RVA = "0x7F58400", Offset = "0x7F57000", VA = "0x187F58400")]
			internal (BNKNLGMMDLE, AIDGEFHMIOM<Dictionary<string, MNDBKMIALLI<Texture2D>>>) HADMHJCJNHK(Dictionary<string, BOBAHFBAFHA> avatarItems)
			{
				return default((BNKNLGMMDLE, AIDGEFHMIOM<Dictionary<string, MNDBKMIALLI<Texture2D>>>));
			}

			[Cpp2IlInjected.Token(Token = "0x600035E")]
			[Cpp2IlInjected.Address(RVA = "0x7F58640", Offset = "0x7F57240", VA = "0x187F58640")]
			internal AIDGEFHMIOM<Dictionary<string, MNDBKMIALLI<Texture2D>>> PDOGBOKDGMA()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600035F")]
			[Cpp2IlInjected.Address(RVA = "0x7F58600", Offset = "0x7F57200", VA = "0x187F58600")]
			internal void NANLHBABHJG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006B")]
		[CompilerGenerated]
		private sealed class BOBBCKGKHCO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003F7")]
			public Transform transformToCheck;

			[Cpp2IlInjected.Token(Token = "0x6000360")]
			[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
			public BOBBCKGKHCO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000361")]
			[Cpp2IlInjected.Address(RVA = "0x7F54360", Offset = "0x7F52F60", VA = "0x187F54360")]
			internal bool IMHCJJOOPKI(SkinnedMeshRenderer x)
			{
				return default(bool);
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200006C")]
		[CompilerGenerated]
		private struct JCJAJPGFFCD : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003F8")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003F9")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003FA")]
			public PlayerAvatarDisplayBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003FB")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000362")]
			[Cpp2IlInjected.Address(RVA = "0x7F56A30", Offset = "0x7F55630", VA = "0x187F56A30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000363")]
			[Cpp2IlInjected.Address(RVA = "0x7F56C00", Offset = "0x7F55800", VA = "0x187F56C00", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		protected static readonly int KFHPJCBCJKI;

		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		protected static readonly int KADICJBJDBJ;

		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		protected static readonly int ICBBCCIHNMD;

		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		protected static readonly int JKAOCIHKLIN;

		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		protected static readonly int EBJPPHJFLPF;

		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		protected static readonly int PEJDOOIDFPK;

		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		protected static readonly int[] NFDEEGDEOOO;

		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		protected static readonly int[] EFLGGBBNOPM;

		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		protected static readonly int[] MBHIKBNMOEP;

		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		protected static readonly int[] DJGJGHNFGFC;

		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		protected static readonly int[] GJCGPHHMNGC;

		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		protected static readonly int[] IDKAGIFDALM;

		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		protected static List<PlayerAvatarDisplayBase> OFPOPGMGELM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		protected LFBJHFHIBPH APBIKJEAFPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		protected bool MAONCNPJPCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x45")]
		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		protected bool IILENLBNOIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		[SerializeField]
		public AvatarBodyShapeVault BodyShapeVault;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		[SerializeField]
		public AvatarFaceShapeVault FaceShapeVault;

		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		protected static readonly int[] OEILHDPNJID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		[SerializeField]
		protected Material bodyPartMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		protected Dictionary<LENHNHJEOJA, Material> EBIIKEDNKBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		protected Dictionary<LENHNHJEOJA, Material> LBBOEOOOMMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		[SerializeField]
		protected bool ignorePlayerMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		[SerializeField]
		protected Transform trackingSpace;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		[SerializeField]
		protected BodyPartLODs Head;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		[SerializeField]
		protected BodyPartLODs Ear;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		[SerializeField]
		protected BodyPartLODs Torso;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		[SerializeField]
		protected BodyPartLODs Hand;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		[SerializeField]
		protected BodyPartLODs HandPointing;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		[SerializeField]
		public PlayerHandBones HandBones;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		[SerializeField]
		public Transform remoteMeshBase;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		public readonly SkinnedMeshRenderer[] CurrentDefaultSkinnedMeshRenderers;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		public readonly SkinnedMeshRenderer[] NextDefaultSkinnedMeshRenderers;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		public readonly SkinnedMeshRenderer[] CurrentVisibleInFirstPersonSkinnedMeshRenderers;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		public readonly SkinnedMeshRenderer[] NextVisibleInFirstPersonSkinnedMeshRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		[SerializeField]
		public Transform firstPersonMeshBase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		[SerializeField]
		protected Shader uberShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		[SerializeField]
		protected Shader agAvatarShader;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		protected Material EODNGGLKPBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		protected FNKBCEMJFAH HAPLOFGAFIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		private LAJPNBFOHGM BAOHBKMHGOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		private LAJPNBFOHGM DLMMCNJECOL;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		protected Material PBGFLKCODAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		[SerializeField]
		protected Transform headPropAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		[SerializeField]
		protected Transform hatAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		[SerializeField]
		public Transform hemisphereBase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x4000300")]
		protected FitMeshHemisphere MCOEAJKFOEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x4000301")]
		protected bool LDKCCOGCIMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x4000302")]
		protected PBOEGNLEBIG FHNGCFDNOMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		protected bool GLNBMMDFLNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		protected AnchorParamsRestrictions FGKPPEDJOKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		protected bool ACKBHNJAMPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		protected Transform NHFBJGNGKBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		protected bool BJPKGBMLGHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B1")]
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		protected bool KKJIJNFHOPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B4")]
		[Cpp2IlInjected.Token(Token = "0x4000309")]
		protected Vector3 HBGBDMPKGMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x400030A")]
		protected Quaternion HAJCGCEKMAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x400030B")]
		protected Vector2 ICPNJPJKCMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x400030C")]
		protected FitMeshHemisphere DFKIBBANKFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x400030D")]
		[SerializeField]
		[IODJOKMKDII(AFILHNGOOLF.SelfAndChildren, false, false, false)]
		protected PlayerFacialAnimatorBase facialAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x400030E")]
		[SerializeField]
		protected Transform torsoPropAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
		[Cpp2IlInjected.Token(Token = "0x400030F")]
		[SerializeField]
		protected Transform torsoRootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
		[Cpp2IlInjected.Token(Token = "0x4000310")]
		[SerializeField]
		protected Transform headRootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
		[Cpp2IlInjected.Token(Token = "0x4000311")]
		[SerializeField]
		protected Transform leftHandRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
		[Cpp2IlInjected.Token(Token = "0x4000312")]
		[SerializeField]
		protected Transform leftHandDefaultScaleRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
		[Cpp2IlInjected.Token(Token = "0x4000313")]
		[SerializeField]
		protected Transform rightHandRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
		[Cpp2IlInjected.Token(Token = "0x4000314")]
		[SerializeField]
		protected Transform rightHandDefaultScaleRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
		[Cpp2IlInjected.Token(Token = "0x4000315")]
		[SerializeField]
		protected Animator leftHandAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		[SerializeField]
		protected Animator rightHandAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
		[Cpp2IlInjected.Token(Token = "0x4000317")]
		[SerializeField]
		protected Transform leftHandPointingRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
		[Cpp2IlInjected.Token(Token = "0x4000318")]
		[SerializeField]
		protected Transform rightHandPointingRoot;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
		[Cpp2IlInjected.Token(Token = "0x4000319")]
		protected Collider[] GLHHKIDLGML;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
		[Cpp2IlInjected.Token(Token = "0x400031A")]
		protected Collider[] BMIGOGACIFJ;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
		[Cpp2IlInjected.Token(Token = "0x400031B")]
		protected KEDBGABIIJL[] PLAIPNBLMMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
		[Cpp2IlInjected.Token(Token = "0x400031C")]
		[SerializeField]
		protected Mesh faceMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x400031D")]
		public Dictionary<Renderer, LKNKINEHDKB> currentPropertyBlocks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
		[Cpp2IlInjected.Token(Token = "0x400031E")]
		protected Dictionary<Renderer, LKNKINEHDKB> OKPMBJPILCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
		[Cpp2IlInjected.Token(Token = "0x400031F")]
		protected NNCIIJAOCFJ FDBDNMHGLCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x4000320")]
		protected BNKNLGMMDLE LLDAHMHCODC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
		[Cpp2IlInjected.Token(Token = "0x4000321")]
		public AFJPHDDPDEH DistanceBand;

		[Cpp2IlInjected.FieldOffset(Offset = "0x284")]
		[Cpp2IlInjected.Token(Token = "0x4000322")]
		protected int LMNOJBCHKOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
		[Cpp2IlInjected.Token(Token = "0x4000323")]
		protected (bool isLodForced, int forcedLOD) ONDIMPFDDDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
		[Cpp2IlInjected.Token(Token = "0x4000324")]
		protected ENGNEPIGOEM<BHILPPFHJPD> ECFGPBEJBNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
		[Cpp2IlInjected.Token(Token = "0x4000325")]
		protected bool JEPIAOOOPIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
		[Cpp2IlInjected.Token(Token = "0x4000327")]
		protected Dictionary<OPKKBLJLHPN, List<LENHNHJEOJA>> DKFLONKGKED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
		[Cpp2IlInjected.Token(Token = "0x4000328")]
		protected Dictionary<OPKKBLJLHPN, List<LENHNHJEOJA>> DKEMHNMOCGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B0")]
		[Cpp2IlInjected.Token(Token = "0x4000329")]
		protected readonly Dictionary<string, MNDBKMIALLI<Texture2D>> IHHFNKPFJMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B8")]
		[Cpp2IlInjected.Token(Token = "0x400032A")]
		protected readonly Dictionary<string, MNDBKMIALLI<Texture2D>> FBJPKHKFHHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C0")]
		[Cpp2IlInjected.Token(Token = "0x400032B")]
		protected bool GJLONPHCHDG;

		[Cpp2IlInjected.Token(Token = "0x400032D")]
		protected static int GFGNNNJLCHN;

		[Cpp2IlInjected.Token(Token = "0x400032E")]
		protected static List<DIDNBDMFFHM> OFELHMACALF;

		[Cpp2IlInjected.Token(Token = "0x400032F")]
		protected static List<DIDNBDMFFHM> MOCAIKHKCLB;

		[Cpp2IlInjected.Token(Token = "0x4000330")]
		protected static CCGDPHBOCPE DIPIGJJLENH;

		[Cpp2IlInjected.Token(Token = "0x4000331")]
		protected static Func<List<DIDNBDMFFHM>, DIDNBDMFFHM> HABHEDOHFAO;

		[Cpp2IlInjected.Token(Token = "0x4000332")]
		protected static bool LFCHBBLPBKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D0")]
		[Cpp2IlInjected.Token(Token = "0x4000333")]
		protected Color? INHHEJFAFPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E4")]
		[Cpp2IlInjected.Token(Token = "0x4000334")]
		protected bool JHCEHNHLIMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E8")]
		[Cpp2IlInjected.Token(Token = "0x4000335")]
		protected Color PGKMBOPDMIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2F8")]
		[Cpp2IlInjected.Token(Token = "0x4000336")]
		protected Color OMFOMCJICFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x308")]
		[Cpp2IlInjected.Token(Token = "0x4000337")]
		protected Color PNDMEKLGBID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x318")]
		[Cpp2IlInjected.Token(Token = "0x4000338")]
		protected AvatarHairPattern BBAOLKCNFHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x320")]
		[Cpp2IlInjected.Token(Token = "0x4000339")]
		protected OBOPCOPCCAH HNCPOMBFAJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x328")]
		[Cpp2IlInjected.Token(Token = "0x400033A")]
		protected Color EBCNIADPGOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x338")]
		[Cpp2IlInjected.Token(Token = "0x400033B")]
		protected Color FOBBMBNLHIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x348")]
		[Cpp2IlInjected.Token(Token = "0x400033C")]
		protected AvatarHairPattern MIAAGGLGLHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x350")]
		[Cpp2IlInjected.Token(Token = "0x400033D")]
		protected OBOPCOPCCAH GFBNJBHGMAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x358")]
		[Cpp2IlInjected.Token(Token = "0x400033E")]
		protected OBOPCOPCCAH JLMBAKMLIPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x360")]
		[Cpp2IlInjected.Token(Token = "0x400033F")]
		protected Color JEKMCCEKOCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x370")]
		[Cpp2IlInjected.Token(Token = "0x4000340")]
		private AdditionalFeetData KDCLEHDLLGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x378")]
		[Cpp2IlInjected.Token(Token = "0x4000341")]
		protected OPKKBLJLHPN? GDLPJEMDNHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x390")]
		[Cpp2IlInjected.Token(Token = "0x4000342")]
		protected Texture AEKPEAFMIMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x398")]
		[Cpp2IlInjected.Token(Token = "0x4000343")]
		protected Color PKLIICFAMND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A8")]
		[Cpp2IlInjected.Token(Token = "0x4000344")]
		protected readonly IList<OPKKBLJLHPN> MDHOOHFJIBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3B0")]
		[Cpp2IlInjected.Token(Token = "0x4000345")]
		protected readonly IList<OPKKBLJLHPN> LKOEGLHNKMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3B8")]
		[Cpp2IlInjected.Token(Token = "0x4000346")]
		private AvatarItemBodyType NDMPHFNKKIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C0")]
		[Cpp2IlInjected.Token(Token = "0x4000347")]
		[SerializeField]
		protected AvatarFaceShape _currentFaceShape;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C8")]
		[Cpp2IlInjected.Token(Token = "0x4000348")]
		[SerializeField]
		protected AvatarBodyShape _currentBodyShape;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D0")]
		[Cpp2IlInjected.Token(Token = "0x4000349")]
		[SerializeField]
		protected OMJMBFKGAHG _currentNoseType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D4")]
		[Cpp2IlInjected.Token(Token = "0x400034A")]
		[SerializeField]
		protected bool _hideEars;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D5")]
		[Cpp2IlInjected.Token(Token = "0x400034B")]
		protected EHCLJPCILOK IHGDFDCAIHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D8")]
		[Cpp2IlInjected.Token(Token = "0x400034C")]
		protected int[] FLOGLCCMLMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3E0")]
		[Cpp2IlInjected.Token(Token = "0x400034D")]
		protected bool KGFIPLOFOCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3E8")]
		[Cpp2IlInjected.Token(Token = "0x400034E")]
		protected int[] ADLMMMBIAIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3F0")]
		[Cpp2IlInjected.Token(Token = "0x400034F")]
		protected bool NLGGGCCBNEP;

		[Cpp2IlInjected.Token(Token = "0x4000350")]
		private static readonly NHDGALDIFDN.IAHAFMDMEMA ADPCMPDCBBF;

		[Cpp2IlInjected.Token(Token = "0x4000351")]
		private static readonly NHDGALDIFDN.IAHAFMDMEMA LLOIDNDLIKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3F1")]
		[Cpp2IlInjected.Token(Token = "0x4000352")]
		protected bool CCDBHPHKPEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3F8")]
		[Cpp2IlInjected.Token(Token = "0x4000353")]
		protected JNFHAACMDFI OKBFFLLEDMB;

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public string NAEOJEFFLAJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000232")]
			[Cpp2IlInjected.Address(RVA = "0xA5B560", Offset = "0xA5A160", VA = "0x180A5B560")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000233")]
			[Cpp2IlInjected.Address(RVA = "0xA5B5D0", Offset = "0xA5A1D0", VA = "0x180A5B5D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public bool OANPDJODHDH
		{
			[Cpp2IlInjected.Token(Token = "0x6000235")]
			[Cpp2IlInjected.Address(RVA = "0xD120D0", Offset = "0xD10CD0", VA = "0x180D120D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000236")]
			[Cpp2IlInjected.Address(RVA = "0xD11710", Offset = "0xD10310", VA = "0x180D11710")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public virtual bool LMGMDAFELMD
		{
			[Cpp2IlInjected.Token(Token = "0x6000237")]
			[Cpp2IlInjected.Address(RVA = "0xAA76B0", Offset = "0xAA62B0", VA = "0x180AA76B0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public bool EPLHNHGOFCE
		{
			[Cpp2IlInjected.Token(Token = "0x6000238")]
			[Cpp2IlInjected.Address(RVA = "0x7F522F0", Offset = "0x7F50EF0", VA = "0x187F522F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public virtual bool FIOMDEJHFCO
		{
			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0xAA76B0", Offset = "0xAA62B0", VA = "0x180AA76B0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public virtual bool FOFFJKKBNGL
		{
			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0xA77810", Offset = "0xA76410", VA = "0x180A77810", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public virtual bool IOAEEAEAFEN
		{
			[Cpp2IlInjected.Token(Token = "0x600023B")]
			[Cpp2IlInjected.Address(RVA = "0xAA76B0", Offset = "0xAA62B0", VA = "0x180AA76B0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public virtual bool NKLOIMIFKKK
		{
			[Cpp2IlInjected.Token(Token = "0x600023C")]
			[Cpp2IlInjected.Address(RVA = "0xAA76B0", Offset = "0xAA62B0", VA = "0x180AA76B0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public FNKBCEMJFAH ELLOKCFLAOF
		{
			[Cpp2IlInjected.Token(Token = "0x600023E")]
			[Cpp2IlInjected.Address(RVA = "0xBB7E40", Offset = "0xBB6A40", VA = "0x180BB7E40")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600023F")]
			[Cpp2IlInjected.Address(RVA = "0x7F52AE0", Offset = "0x7F516E0", VA = "0x187F52AE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public LAJPNBFOHGM CGPHEOGJJEC
		{
			[Cpp2IlInjected.Token(Token = "0x6000240")]
			[Cpp2IlInjected.Address(RVA = "0xBB96F0", Offset = "0xBB82F0", VA = "0x180BB96F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000241")]
			[Cpp2IlInjected.Address(RVA = "0x7F52EE0", Offset = "0x7F51AE0", VA = "0x187F52EE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public LAJPNBFOHGM NJFANICKHGG
		{
			[Cpp2IlInjected.Token(Token = "0x6000242")]
			[Cpp2IlInjected.Address(RVA = "0xBCA2C0", Offset = "0xBC8EC0", VA = "0x180BCA2C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0x7F531B0", Offset = "0x7F51DB0", VA = "0x187F531B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		protected Material OPGEABNGJAN
		{
			[Cpp2IlInjected.Token(Token = "0x6000244")]
			[Cpp2IlInjected.Address(RVA = "0x7F496C0", Offset = "0x7F482C0", VA = "0x187F496C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		protected Material HFFNLCCLBEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000245")]
			[Cpp2IlInjected.Address(RVA = "0x7F495D0", Offset = "0x7F481D0", VA = "0x187F495D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public bool LNHOCBNGEFJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000246")]
			[Cpp2IlInjected.Address(RVA = "0x246D670", Offset = "0x246C270", VA = "0x18246D670")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public PlayerFacialAnimatorBase ENCBKOCIMON
		{
			[Cpp2IlInjected.Token(Token = "0x600024A")]
			[Cpp2IlInjected.Address(RVA = "0xBCA4C0", Offset = "0xBC90C0", VA = "0x180BCA4C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public KEDBGABIIJL[] FLIMMEGIIOI
		{
			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0x7F51E70", Offset = "0x7F50A70", VA = "0x187F51E70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public KEDBGABIIJL MIKENGPGLBP
		{
			[Cpp2IlInjected.Token(Token = "0x600024C")]
			[Cpp2IlInjected.Address(RVA = "0x7F52500", Offset = "0x7F51100", VA = "0x187F52500")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public KEDBGABIIJL BKGAELLDHEA
		{
			[Cpp2IlInjected.Token(Token = "0x600024D")]
			[Cpp2IlInjected.Address(RVA = "0x7F52540", Offset = "0x7F51140", VA = "0x187F52540")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public Mesh PIDBOOHKJCC
		{
			[Cpp2IlInjected.Token(Token = "0x600024E")]
			[Cpp2IlInjected.Address(RVA = "0xBCAC10", Offset = "0xBC9810", VA = "0x180BCAC10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		protected NNCIIJAOCFJ MPJAFCINEPH
		{
			[Cpp2IlInjected.Token(Token = "0x600024F")]
			[Cpp2IlInjected.Address(RVA = "0x7F4CAA0", Offset = "0x7F4B6A0", VA = "0x187F4CAA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		protected BNKNLGMMDLE KPKDPKKDGHH
		{
			[Cpp2IlInjected.Token(Token = "0x6000250")]
			[Cpp2IlInjected.Address(RVA = "0xBCAFA0", Offset = "0xBC9BA0", VA = "0x180BCAFA0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000251")]
			[Cpp2IlInjected.Address(RVA = "0x7F47120", Offset = "0x7F45D20", VA = "0x187F47120")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		protected bool GNCFPAHIKAH
		{
			[Cpp2IlInjected.Token(Token = "0x6000252")]
			[Cpp2IlInjected.Address(RVA = "0xA77810", Offset = "0xA76410", VA = "0x180A77810")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public bool MGCPPFFHMAG
		{
			[Cpp2IlInjected.Token(Token = "0x6000253")]
			[Cpp2IlInjected.Address(RVA = "0x7F524F0", Offset = "0x7F510F0", VA = "0x187F524F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public int ECDOFPEMKIJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000254")]
			[Cpp2IlInjected.Address(RVA = "0x7F52530", Offset = "0x7F51130", VA = "0x187F52530")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000255")]
			[Cpp2IlInjected.Address(RVA = "0x7F530F0", Offset = "0x7F51CF0", VA = "0x187F530F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public int LAKJMJGEAPO
		{
			[Cpp2IlInjected.Token(Token = "0x6000256")]
			[Cpp2IlInjected.Address(RVA = "0x7F52E30", Offset = "0x7F51A30", VA = "0x187F52E30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		protected virtual bool PKBMIOJDPJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000257")]
			[Cpp2IlInjected.Address(RVA = "0xAA76B0", Offset = "0xAA62B0", VA = "0x180AA76B0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		protected virtual int[] LPDIANECGHP
		{
			[Cpp2IlInjected.Token(Token = "0x6000258")]
			[Cpp2IlInjected.Address(RVA = "0x7F46790", Offset = "0x7F45390", VA = "0x187F46790", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		protected bool BKININEMAAD
		{
			[Cpp2IlInjected.Token(Token = "0x600025A")]
			[Cpp2IlInjected.Address(RVA = "0x7F45F80", Offset = "0x7F44B80", VA = "0x187F45F80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		protected static bool HMCFKGDAOCE
		{
			[Cpp2IlInjected.Token(Token = "0x600025B")]
			[Cpp2IlInjected.Address(RVA = "0xAA76B0", Offset = "0xAA62B0", VA = "0x180AA76B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public bool JLPEGJGNGJG
		{
			[Cpp2IlInjected.Token(Token = "0x600025C")]
			[Cpp2IlInjected.Address(RVA = "0x7F52570", Offset = "0x7F51170", VA = "0x187F52570")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600025D")]
			[Cpp2IlInjected.Address(RVA = "0x7F533D0", Offset = "0x7F51FD0", VA = "0x187F533D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public IEnumerable<SkinnedMeshRenderer> PDJONKGMPIC
		{
			[Cpp2IlInjected.Token(Token = "0x600025E")]
			[Cpp2IlInjected.Address(RVA = "0x7F51CF0", Offset = "0x7F508F0", VA = "0x187F51CF0")]
			[IteratorStateMachine(typeof(MLGCMPMNFLD))]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public bool MIILNIMFKPO
		{
			[Cpp2IlInjected.Token(Token = "0x600025F")]
			[Cpp2IlInjected.Address(RVA = "0x7F524E0", Offset = "0x7F510E0", VA = "0x187F524E0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000260")]
			[Cpp2IlInjected.Address(RVA = "0x7F4CF40", Offset = "0x7F4BB40", VA = "0x187F4CF40")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public ADAOAPJGFHC FBPJOCLKPHL
		{
			[Cpp2IlInjected.Token(Token = "0x6000261")]
			[Cpp2IlInjected.Address(RVA = "0x7F51D70", Offset = "0x7F50970", VA = "0x187F51D70")]
			get
			{
				return default(ADAOAPJGFHC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public static bool DCAAKAMDBCL
		{
			[Cpp2IlInjected.Token(Token = "0x6000280")]
			[Cpp2IlInjected.Address(RVA = "0x7F52220", Offset = "0x7F50E20", VA = "0x187F52220")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		protected static CCGDPHBOCPE IFNGKECGBDM
		{
			[Cpp2IlInjected.Token(Token = "0x6000281")]
			[Cpp2IlInjected.Address(RVA = "0x7F470A0", Offset = "0x7F45CA0", VA = "0x187F470A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000282")]
			[Cpp2IlInjected.Address(RVA = "0x7F48190", Offset = "0x7F46D90", VA = "0x187F48190")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		protected Color OMNLCKLFFFJ
		{
			[Cpp2IlInjected.Token(Token = "0x600029C")]
			[Cpp2IlInjected.Address(RVA = "0x7F4CAC0", Offset = "0x7F4B6C0", VA = "0x187F4CAC0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		protected Color BIDCNEDALNM
		{
			[Cpp2IlInjected.Token(Token = "0x600029D")]
			[Cpp2IlInjected.Address(RVA = "0x7F4BD40", Offset = "0x7F4A940", VA = "0x187F4BD40")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		protected Texture2D PGFOONBGHBC
		{
			[Cpp2IlInjected.Token(Token = "0x600029E")]
			[Cpp2IlInjected.Address(RVA = "0x7F48AA0", Offset = "0x7F476A0", VA = "0x187F48AA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public Color KOPJJILCAFG
		{
			[Cpp2IlInjected.Token(Token = "0x60002A4")]
			[Cpp2IlInjected.Address(RVA = "0x7F51E20", Offset = "0x7F50A20", VA = "0x187F51E20")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		protected Color IAAIBKHMFDG
		{
			[Cpp2IlInjected.Token(Token = "0x60002A5")]
			[Cpp2IlInjected.Address(RVA = "0x7F4AE40", Offset = "0x7F49A40", VA = "0x187F4AE40")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		public OBOPCOPCCAH NMHJGKOKPOD
		{
			[Cpp2IlInjected.Token(Token = "0x60002A6")]
			[Cpp2IlInjected.Address(RVA = "0x7F51DE0", Offset = "0x7F509E0", VA = "0x187F51DE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		protected Texture2D IPJOPCAABKJ
		{
			[Cpp2IlInjected.Token(Token = "0x60002A7")]
			[Cpp2IlInjected.Address(RVA = "0x7F46820", Offset = "0x7F45420", VA = "0x187F46820")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		public float EPICMKKOMNE
		{
			[Cpp2IlInjected.Token(Token = "0x60002AE")]
			[Cpp2IlInjected.Address(RVA = "0x7F51E00", Offset = "0x7F50A00", VA = "0x187F51E00")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		public float BCEMLHJNEEE
		{
			[Cpp2IlInjected.Token(Token = "0x60002AF")]
			[Cpp2IlInjected.Address(RVA = "0x7F522D0", Offset = "0x7F50ED0", VA = "0x187F522D0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		public bool EEAPDCIHDFM
		{
			[Cpp2IlInjected.Token(Token = "0x60002E3")]
			[Cpp2IlInjected.Address(RVA = "0x7F51DD0", Offset = "0x7F509D0", VA = "0x187F51DD0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002E4")]
			[Cpp2IlInjected.Address(RVA = "0x7F528C0", Offset = "0x7F514C0", VA = "0x187F528C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action NNKKDEMOGKO
		{
			[Cpp2IlInjected.Token(Token = "0x600022A")]
			[Cpp2IlInjected.Address(RVA = "0x7F51A50", Offset = "0x7F50650", VA = "0x187F51A50")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600022B")]
			[Cpp2IlInjected.Address(RVA = "0x7F52620", Offset = "0x7F51220", VA = "0x187F52620")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action PHLNKNFKJAE
		{
			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0x7F519B0", Offset = "0x7F505B0", VA = "0x187F519B0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600022D")]
			[Cpp2IlInjected.Address(RVA = "0x7F52580", Offset = "0x7F51180", VA = "0x187F52580")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action BEMBOEBKDOL
		{
			[Cpp2IlInjected.Token(Token = "0x600022E")]
			[Cpp2IlInjected.Address(RVA = "0x7F51AF0", Offset = "0x7F506F0", VA = "0x187F51AF0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600022F")]
			[Cpp2IlInjected.Address(RVA = "0x7F526C0", Offset = "0x7F512C0", VA = "0x187F526C0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action IDHACHBAACF
		{
			[Cpp2IlInjected.Token(Token = "0x6000230")]
			[Cpp2IlInjected.Address(RVA = "0x7F51B90", Offset = "0x7F50790", VA = "0x187F51B90")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000231")]
			[Cpp2IlInjected.Address(RVA = "0x7F52760", Offset = "0x7F51360", VA = "0x187F52760")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<HFDBLEOKNJB, IKOIPHKGCMC> HKDHPPHHCLB
		{
			[Cpp2IlInjected.Token(Token = "0x6000274")]
			[Cpp2IlInjected.Address(RVA = "0x7F51C30", Offset = "0x7F50830", VA = "0x187F51C30")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000275")]
			[Cpp2IlInjected.Address(RVA = "0x7F52800", Offset = "0x7F51400", VA = "0x187F52800")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x7F4E1F0", Offset = "0x7F4CDF0", VA = "0x187F4E1F0")]
		public bool SetDeformation(bool MAONCNPJPCP, bool IILENLBNOIJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x7F4BD90", Offset = "0x7F4A990", VA = "0x187F4BD90")]
		protected static Material MGELHNKPKAB(Dictionary<LENHNHJEOJA, Material> JNDJCHENOOC, Material MANGCODLEBB, LCNHBILGNCP NJNJPMCMHDI, FGBMNMMNDIK CGBIMBKLAJP, FMEODGEFBMO DAMAHFKHDCF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x7F4B7F0", Offset = "0x7F4A3F0", VA = "0x187F4B7F0")]
		protected void KNPGJHBEEOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x7F4A920", Offset = "0x7F49520", VA = "0x187F4A920")]
		protected bool ILNNDCFOLJM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x7F47870", Offset = "0x7F46470", VA = "0x187F47870")]
		protected void EAPNLDPPPED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x7F46920", Offset = "0x7F45520", VA = "0x187F46920", Slot = "11")]
		protected virtual void CMPPEELKJJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x7F4C0D0", Offset = "0x7F4ACD0", VA = "0x187F4C0D0")]
		public int MeshesAtLODCount(int HLHCIOEGJIP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x7F48EC0", Offset = "0x7F47AC0", VA = "0x187F48EC0")]
		protected static void HJODONPGKFP(Dictionary<OPKKBLJLHPN, List<LENHNHJEOJA>> LDOBEDEHEFO, LKCMBLIHNDD NBMLCPEJJIP, Material MANGCODLEBB, LCNHBILGNCP JJPCHCCDGCE, FGBMNMMNDIK LMHDEPDIPLN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x7F45540", Offset = "0x7F44140", VA = "0x187F45540")]
		protected void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x7F4BA10", Offset = "0x7F4A610", VA = "0x187F4BA10")]
		protected void MAFHGKEIAMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x7F4CC90", Offset = "0x7F4B890", VA = "0x187F4CC90")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "12")]
		protected virtual void OMBIDNOIPDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x7F48BE0", Offset = "0x7F477E0", VA = "0x187F48BE0")]
		protected static void GEHEEOILOKI(List<Material> NNKKPPJHABJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x7F47B70", Offset = "0x7F46770", VA = "0x187F47B70")]
		protected static void EELHBDPAFAA(Dictionary<LENHNHJEOJA, Material> JNDJCHENOOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x7F4AF60", Offset = "0x7F49B60", VA = "0x187F4AF60")]
		protected static void JFJJNOGBDLE(Dictionary<Renderer, LKNKINEHDKB> OHCMNCCADOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x7F47900", Offset = "0x7F46500", VA = "0x187F47900")]
		protected void EBFPJGOMIIN(SkinnedMeshRenderer[] ADNAIABIPDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x7F480F0", Offset = "0x7F46CF0", VA = "0x187F480F0")]
		protected void EKCCFLIFKIP(SkinnedMeshRenderer HDHHGHHFCGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x7F48020", Offset = "0x7F46C20", VA = "0x187F48020")]
		protected void EKCCFLIFKIP(MeshRenderer OFKIGCBINDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x7F4BEF0", Offset = "0x7F4AAF0", VA = "0x187F4BEF0")]
		protected void MIAFMOGHLLM(List<IGJFGOMAIOE> FGIOFINJGPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x7F4CB10", Offset = "0x7F4B710", VA = "0x187F4CB10")]
		protected void OLHFALNMPFM(Dictionary<string, MNDBKMIALLI<Texture2D>> LDOBEDEHEFO, bool PKCLMIAGEEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x7F48400", Offset = "0x7F47000", VA = "0x187F48400")]
		protected void FAEFBFBCFFF(Dictionary<OPKKBLJLHPN, List<LENHNHJEOJA>> LDOBEDEHEFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x7F48DC0", Offset = "0x7F479C0", VA = "0x187F48DC0")]
		public float GetHandOpenClosedAxis(HFDBLEOKNJB FJDDFMKMNAH)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x7F4EA90", Offset = "0x7F4D690", VA = "0x187F4EA90")]
		public void SetHandOpenClosedAxis(HFDBLEOKNJB FJDDFMKMNAH, float KEMIGJGDEPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x7F48E00", Offset = "0x7F47A00", VA = "0x187F48E00")]
		public IKOIPHKGCMC GetHandVisualState(HFDBLEOKNJB FJDDFMKMNAH)
		{
			return default(IKOIPHKGCMC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x7F44C80", Offset = "0x7F43880", VA = "0x187F44C80")]
		public bool AddHandVisualStateToken(HFDBLEOKNJB FJDDFMKMNAH, IKOIPHKGCMC IIOOHEBIHLN, object DANCOEFIHDF, KEDBGABIIJL.AJJCKCCBPOG PBEMDBEINCB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x7F50330", Offset = "0x7F4EF30", VA = "0x187F50330")]
		public void SetWatchHand(HFDBLEOKNJB FJDDFMKMNAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x7F503F0", Offset = "0x7F4EFF0", VA = "0x187F503F0")]
		public void SetWatchHands(bool KEFECGMCCOG, bool MKKFJMLIDMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x7F4D8B0", Offset = "0x7F4C4B0", VA = "0x187F4D8B0")]
		public bool RemoveHandVisualStateToken(HFDBLEOKNJB FJDDFMKMNAH, object DANCOEFIHDF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x7F48E80", Offset = "0x7F47A80", VA = "0x187F48E80")]
		public bool GetThumbsUpActive(HFDBLEOKNJB FJDDFMKMNAH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x7F4FD40", Offset = "0x7F4E940", VA = "0x187F4FD40")]
		public void SetThumbsUpActive(HFDBLEOKNJB FJDDFMKMNAH, bool BIFDAOIINDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x7F48E40", Offset = "0x7F47A40", VA = "0x187F48E40")]
		public bool GetHandshakeActive(HFDBLEOKNJB FJDDFMKMNAH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x7F4EAE0", Offset = "0x7F4D6E0", VA = "0x187F4EAE0")]
		public void SetHandshakeActive(HFDBLEOKNJB FJDDFMKMNAH, bool IONMCHIGOHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x7F48B90", Offset = "0x7F47790", VA = "0x187F48B90")]
		public void ForceUpdateHandsVisualState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x7F50220", Offset = "0x7F4EE20", VA = "0x187F50220")]
		public void SetUseClassicBeanHandScale(bool BKMPCFIAHIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x7F46F80", Offset = "0x7F45B80", VA = "0x187F46F80")]
		public static void ClearQueuedBuilds()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x7F4B520", Offset = "0x7F4A120", VA = "0x187F4B520")]
		private static void KFKPPAHMJMA(Scene CMBCIMNOCEH, LoadSceneMode CEBNHJNKAJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x7F4B6F0", Offset = "0x7F4A2F0", VA = "0x187F4B6F0")]
		protected static void KNNBJEAMCPE(PlayerAvatarDisplayBase KPLDCOCEOFJ, List<DIDNBDMFFHM> LPFHBNBOKPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x7F4D5C0", Offset = "0x7F4C1C0", VA = "0x187F4D5C0")]
		public IPNMFPLCPOG Rebuild(bool HKFCLMCPNJM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x7F44B00", Offset = "0x7F43700", VA = "0x187F44B00")]
		protected IPNMFPLCPOG AMEMBMONPHA(bool HKFCLMCPNJM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x7F449D0", Offset = "0x7F435D0", VA = "0x187F449D0", Slot = "13")]
		protected virtual IPNMFPLCPOG AMEMBMONPHA(IList<OPKKBLJLHPN> KCKPKLHIMHP, AvatarItemBodyType CMBEJDJCOKH, bool ABGFJHENDNP, bool LLLBNKNHNFC, int[] EGHIHCEELMF, bool HKFCLMCPNJM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x7F47310", Offset = "0x7F45F10", VA = "0x187F47310")]
		protected static IPNMFPLCPOG DOLHFAAPLOH(DIDNBDMFFHM FHHCJMLKFHC, List<DIDNBDMFFHM> LPFHBNBOKPE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x7F48450", Offset = "0x7F47050", VA = "0x187F48450")]
		[IteratorStateMachine(typeof(IEHLCHKMAEP))]
		protected static IEnumerator<LIPOFPKAEIK> FCDKHFGMMCK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x7F47AE0", Offset = "0x7F466E0", VA = "0x187F47AE0")]
		protected static DIDNBDMFFHM EDLNLDNELEM(List<DIDNBDMFFHM> LPFHBNBOKPE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x7F4E300", Offset = "0x7F4CF00", VA = "0x187F4E300")]
		[AsyncStateMachine(typeof(HMHCIKKJDHJ))]
		public Task SetFaceCustomizationSettings(DNHFACAJPBE LBEKEMPAKCH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x7F50550", Offset = "0x7F4F150", VA = "0x187F50550")]
		public bool UpdateFaceAndBodyCustomizationSettings(DNHFACAJPBE LBEKEMPAKCH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x7F4AD60", Offset = "0x7F49960", VA = "0x187F4AD60")]
		public void InitializeFaceFeatures(AvatarConfiguration ONBOCFICLND, ADAOAPJGFHC ODLFGIBLFNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x7F4FA90", Offset = "0x7F4E690", VA = "0x187F4FA90")]
		public void SetTeamColors(Color? ICEPGJOMBAG, bool EJBBHFIMOPM, Color IAAJBABACOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x14AB430", Offset = "0x14AA030", VA = "0x1814AB430")]
		private static void KGGDOKPMBOE(Material CIBNABIMGCK, Color BKMPCFIAHIG, params int[] MNBEIGDKNNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x14AB4D0", Offset = "0x14AA0D0", VA = "0x1814AB4D0")]
		private static void KKKBCEOFONK(Material CIBNABIMGCK, Texture BKMPCFIAHIG, params int[] MNBEIGDKNNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x7F45D00", Offset = "0x7F44900", VA = "0x187F45D00")]
		protected void BNAFFLMMDPF(Material PAODGAKGKGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x7F44B60", Offset = "0x7F43760", VA = "0x187F44B60")]
		protected void APBKHDIEGDO(Material PAODGAKGKGP, Color BOKCNDDFGLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x7F48540", Offset = "0x7F47140", VA = "0x187F48540")]
		protected void FLNKKBKCEEE(Material PAODGAKGKGP, Color BOKCNDDFGLI, Color GMFGGJEDDCB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x7F4AB40", Offset = "0x7F49740", VA = "0x187F4AB40")]
		protected void IPAIGCHIPEC(Material PAODGAKGKGP, Texture2D PMMGDHEEDKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x7F45770", Offset = "0x7F44370", VA = "0x187F45770")]
		protected void BHKHGENKNKA(Material PAODGAKGKGP, Texture ANOCKJNGHDF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x7F4D460", Offset = "0x7F4C060", VA = "0x187F4D460")]
		protected void PPOCIDLNJPB(Action<LKNKINEHDKB> MMDIJLFNLAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x7F4C390", Offset = "0x7F4AF90", VA = "0x187F4C390")]
		protected void NOGDDNBAHLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x7F4C740", Offset = "0x7F4B340", VA = "0x187F4C740")]
		protected void ODLNPACDGAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x7F46160", Offset = "0x7F44D60", VA = "0x187F46160")]
		protected void CDCGJFGJHPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x7F44FD0", Offset = "0x7F43BD0", VA = "0x187F44FD0")]
		public void ApplyUgcItemOverrides()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x7F4DC70", Offset = "0x7F4C870", VA = "0x187F4DC70")]
		public void SetBeardPrimaryColor([Optional] Color? BCCFGEAJOCF, bool IHPBEGNNGFD = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x7F4DE90", Offset = "0x7F4CA90", VA = "0x187F4DE90")]
		public void SetBeardSecondaryColor([Optional] Color? BCCFGEAJOCF, bool IHPBEGNNGFD = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x7F4DB30", Offset = "0x7F4C730", VA = "0x187F4DB30")]
		public void SetBeardPattern([Optional] AvatarHairPattern ALDNJECENBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x7F4C5D0", Offset = "0x7F4B1D0", VA = "0x187F4C5D0")]
		private void NOOAPDFDPNJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x7F460B0", Offset = "0x7F44CB0", VA = "0x187F460B0")]
		private bool CCEFOEPHCME()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x7F4E670", Offset = "0x7F4D270", VA = "0x187F4E670")]
		public void SetHairPrimaryColor([Optional] Color? PAPLMADBAEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x7F4E880", Offset = "0x7F4D480", VA = "0x187F4E880")]
		public void SetHairSecondaryColor([Optional] Color? PAPLMADBAEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x7F4E540", Offset = "0x7F4D140", VA = "0x187F4E540")]
		public void SetHairPattern([Optional] AvatarHairPattern ALDNJECENBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x7F4D750", Offset = "0x7F4C350", VA = "0x187F4D750")]
		public void RefreshHair()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x7F47250", Offset = "0x7F45E50", VA = "0x187F47250")]
		private bool DOKGGLNJAIG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x7F4F8D0", Offset = "0x7F4E4D0", VA = "0x187F4F8D0")]
		public void SetSkinColor(Color IPMDPNHHNEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x7F4FD90", Offset = "0x7F4E990", VA = "0x187F4FD90")]
		public void SetUgcItemVisualOverrides(OPKKBLJLHPN LMELNLPCMEL, ADAOAPJGFHC ODLFGIBLFNK, Texture EMEJPDBDDLM, Color MEBKAKPBGEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x7F47050", Offset = "0x7F45C50", VA = "0x187F47050")]
		public void ClearUgcItemVisualOverrides()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x7F4E400", Offset = "0x7F4D000", VA = "0x187F4E400")]
		public bool SetFaceShape(AvatarFaceShape ANAIHICIJOH, bool PIGLABJPCAC = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x7F4B650", Offset = "0x7F4A250", VA = "0x187F4B650")]
		private void KLCEGNBLNKA(DCFGNKIDBKM KPOCAAGAJEK, float BKMPCFIAHIG, bool LAPCJMHOMHE = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x7F4C190", Offset = "0x7F4AD90", VA = "0x187F4C190")]
		private void NILKKJKKEDI(HBKGPDEOJBL EAGAANLHOGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x7F4D3C0", Offset = "0x7F4BFC0", VA = "0x187F4D3C0")]
		private void PPDALCBNMAH(PDFDLMPFEHI DDMBBEGJJML, float BKMPCFIAHIG, bool GILOBBBMGNH = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x7F4B480", Offset = "0x7F4A080", VA = "0x187F4B480")]
		private void KDPBIGBIMKF(MCAPBNLLBJK GKJCGJOJIAD, float BKMPCFIAHIG, bool ADFALAOOCAM = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x7F4D1D0", Offset = "0x7F4BDD0", VA = "0x187F4D1D0")]
		private void PLFFIDOLIMM(JDDHIHBAJAK BOMICACHNEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x7F47D60", Offset = "0x7F46960", VA = "0x187F47D60")]
		private void EGMJPPGHHJH(AIEGLBFMBCD KPOOCCLMOGN, float CJEJCNKCAJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x7F4E0B0", Offset = "0x7F4CCB0", VA = "0x187F4E0B0")]
		public bool SetBodyShape(AvatarBodyShape IFPCBPCNGDA, bool PIGLABJPCAC = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x7F4F760", Offset = "0x7F4E360", VA = "0x187F4F760")]
		public bool SetNoseType(OMJMBFKGAHG AIAONFGMGDB, bool PIGLABJPCAC = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x7F50C40", Offset = "0x7F4F840", VA = "0x187F50C40")]
		public bool UpdateFaceAndBodyShapes()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x7F4F740", Offset = "0x7F4E340", VA = "0x187F4F740")]
		public bool SetHideEars(bool CMNCAJBIIDK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x7F4F730", Offset = "0x7F4E330", VA = "0x187F4F730")]
		public bool SetHelmetHair(LFBJHFHIBPH ICNCNLMKJGG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x7F4F180", Offset = "0x7F4DD80", VA = "0x187F4F180")]
		public void SetHatAnchorParameters(PBOEGNLEBIG LCDHAPJGDKL, bool OMFBDFPDEKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x7F504C0", Offset = "0x7F4F0C0", VA = "0x187F504C0")]
		public void SetupDisplayLODs(EHCLJPCILOK HMLCHDHFDEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x7F44780", Offset = "0x7F43380", VA = "0x187F44780")]
		protected int[] AHJFGKINOKG(EHCLJPCILOK HMLCHDHFDEJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x7F4F800", Offset = "0x7F4E400", VA = "0x187F4F800")]
		public void SetOutfitSelections(IList<OPKKBLJLHPN> KCKPKLHIMHP, AvatarItemBodyType CMBEJDJCOKH, bool LLLBNKNHNFC, bool HKFCLMCPNJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x7F4F880", Offset = "0x7F4E480", VA = "0x187F4F880")]
		public void SetOutfitSelections(IList<OPKKBLJLHPN> KCKPKLHIMHP, AvatarItemBodyType CMBEJDJCOKH, bool ABGFJHENDNP, bool LLLBNKNHNFC, bool HKFCLMCPNJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x7F4F840", Offset = "0x7F4E440", VA = "0x187F4F840")]
		public IPNMFPLCPOG SetOutfitSelections(IList<OPKKBLJLHPN> KCKPKLHIMHP, AvatarItemBodyType CMBEJDJCOKH, EHCLJPCILOK HMLCHDHFDEJ, bool ABGFJHENDNP, bool LLLBNKNHNFC, bool PIGLABJPCAC = false, bool HKFCLMCPNJM = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x7F49350", Offset = "0x7F47F50", VA = "0x187F49350", Slot = "14")]
		protected virtual IPNMFPLCPOG HNNHFAEPEBL(IList<OPKKBLJLHPN> KCKPKLHIMHP, AvatarItemBodyType CMBEJDJCOKH, bool ABGFJHENDNP, bool LLLBNKNHNFC, EHCLJPCILOK HMLCHDHFDEJ, bool PIGLABJPCAC, bool HKFCLMCPNJM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x7F4B910", Offset = "0x7F4A510", VA = "0x187F4B910")]
		protected int[] LJHHODJEING(EHCLJPCILOK HMLCHDHFDEJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0xA5E030", Offset = "0xA5CC30", VA = "0x180A5E030", Slot = "15")]
		protected virtual BNKNLGMMDLE FALBAGPGCGN(AvatarItemBodyType KLJENMLFIKH, Dictionary<string, BOBAHFBAFHA> FBGDNKLDFEO, Dictionary<string, MNDBKMIALLI<Texture2D>> DJCEBAOOMNB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x7F464C0", Offset = "0x7F450C0", VA = "0x187F464C0", Slot = "16")]
		protected virtual IPNMFPLCPOG CEOIHCICJII(IList<OPKKBLJLHPN> KCKPKLHIMHP, AvatarItemBodyType CMBEJDJCOKH, bool ABGFJHENDNP, bool LLLBNKNHNFC, int[] IBCGOKACOGJ, NMCGFIKJCCM IABGOOLPBIO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x7F45880", Offset = "0x7F44480", VA = "0x187F45880", Slot = "17")]
		protected virtual BOBAHFBAFHA BMPCOMANOLP(OBOPCOPCCAH BFAKLNDJFBH, AvatarItemBodyType KLJENMLFIKH, FMEODGEFBMO DAMAHFKHDCF, BOBAHFBAFHA MGDHCFBBDJJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0xA5E030", Offset = "0xA5CC30", VA = "0x180A5E030", Slot = "18")]
		protected virtual BOBAHFBAFHA JPGKEEDDJKH(AvatarItemBodyType KLJENMLFIKH, FMEODGEFBMO DAMAHFKHDCF, IAPEOEACMJI IEAEJIDPCDO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x7F4B3B0", Offset = "0x7F49FB0", VA = "0x187F4B3B0")]
		protected void JOMIJMDLLDD(NOJJHAAHIJD KFHNELKHMKE, NHDGALDIFDN.IAHAFMDMEMA CCDPMHONKPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x7F47E90", Offset = "0x7F46A90", VA = "0x187F47E90")]
		protected void EIAEOAIDJLC(NOJJHAAHIJD KFHNELKHMKE, NHDGALDIFDN.IAHAFMDMEMA CCDPMHONKPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0xAE5310", Offset = "0xAE3F10", VA = "0x180AE5310", Slot = "19")]
		protected virtual NOJJHAAHIJD ECMNNNJIACJ(NOJJHAAHIJD KFHNELKHMKE, HelmetHairStyle AHKEODJJHIJ, bool AIFILNACFBG, AvatarItemBodyType CMBEJDJCOKH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x7F49900", Offset = "0x7F48500", VA = "0x187F49900")]
		protected NOJJHAAHIJD IKDNGIENBPO(IList<OPKKBLJLHPN> KCKPKLHIMHP, AvatarItemBodyType EHMFCNCKHJI, bool LLLBNKNHNFC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x7F46E60", Offset = "0x7F45A60", VA = "0x187F46E60")]
		public void CleanupDisplayResources()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x7F46000", Offset = "0x7F44C00", VA = "0x187F46000")]
		protected void CAOHFAMLDNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x7F48770", Offset = "0x7F47370", VA = "0x187F48770")]
		protected void FMKGJGIDIGE(Transform JLPIHONLNEF, IEnumerable<SkinnedMeshRenderer> HHFMJABGOFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x7F47A20", Offset = "0x7F46620", VA = "0x187F47A20")]
		protected NHDGALDIFDN.IAHAFMDMEMA EBJEBFEOHKB(NHDGALDIFDN.IAHAFMDMEMA APHDODEPNMI, FMEODGEFBMO BKMCDELDIBP)
		{
			return default(NHDGALDIFDN.IAHAFMDMEMA);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x7F48DB0", Offset = "0x7F479B0", VA = "0x187F48DB0")]
		protected void GIGDPFNPPAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x19DF360", Offset = "0x19DDF60", VA = "0x1819DF360")]
		protected void PMLLKLGPHHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x7F47F10", Offset = "0x7F46B10", VA = "0x187F47F10")]
		protected void EKAHMNBPAFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x7F446B0", Offset = "0x7F432B0", VA = "0x187F446B0")]
		[AsyncStateMachine(typeof(JCJAJPGFFCD))]
		protected Task AAJBCMNMLFP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x7F4C900", Offset = "0x7F4B500", VA = "0x187F4C900")]
		protected static LCNHBILGNCP OFJJFAKLCMK(LKCMBLIHNDD EJKFLMLHEOC, int MOJLJLLOHPM)
		{
			return default(LCNHBILGNCP);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x7F49190", Offset = "0x7F47D90", VA = "0x187F49190")]
		protected static FGBMNMMNDIK HMDJDKGBIDC(LKCMBLIHNDD EJKFLMLHEOC, int MOJLJLLOHPM)
		{
			return default(FGBMNMMNDIK);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x7F484B0", Offset = "0x7F470B0", VA = "0x187F484B0")]
		protected Transform FDIOCOGEPOF(FMEODGEFBMO DAMAHFKHDCF, OutfitType ANIIJDINIFH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x7F4B0C0", Offset = "0x7F49CC0", VA = "0x187F4B0C0")]
		protected void JIKLLFNCMDN(int EFJMIKDMGKB, Material CIBNABIMGCK, LKCMBLIHNDD EJKFLMLHEOC, [Out] Texture2D NDOJGACHKLP, [Out] Vector4 EPOCDOIKENA, [Out] Texture2D LGHKNNNOBPH, [Out] Texture2D JKINGFDFOPA, [Out] Texture2D HIFJDNHMKNH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x7F4CF50", Offset = "0x7F4BB50", VA = "0x187F4CF50")]
		protected void PELPOINBMML(int EFJMIKDMGKB, Material CIBNABIMGCK, LKCMBLIHNDD EJKFLMLHEOC, [Out] Color HFDHMLDHBON, [Out] Color PKGKBHAFMOB, [Out] Color NCPNPPFPDAJ, [Out] Color MJPALICOCKK, [Out] Color LFBJGGGMMJK, [Out] Color CNKHHILNLEM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x7F492E0", Offset = "0x7F47EE0", VA = "0x187F492E0")]
		protected void HNKFFEKFEEB(Vector3 BCBKGNPANPG, Quaternion EFKBKJCNDBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x7F4EB30", Offset = "0x7F4D730", VA = "0x187F4EB30")]
		public void SetHatAnchorParameters(PBOEGNLEBIG LCDHAPJGDKL, AnchorParamsRestrictions LLFNLEMKOEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x7F46980", Offset = "0x7F45580", VA = "0x187F46980")]
		public static void CalculateHatAnchorParams(FitMeshHemisphere MCOEAJKFOEC, Transform NHFBJGNGKBP, PBOEGNLEBIG LCDHAPJGDKL, AnchorParamsRestrictions FGKPPEDJOKO, [Out] Vector3 COLBAOBOGCI, [Out] Quaternion BFDIJLLKGHN, [Out] PBOEGNLEBIG EEHOCBDEENM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x7F4D9C0", Offset = "0x7F4C5C0", VA = "0x187F4D9C0")]
		public void ResetHatAnchor(Vector2 JAMBMDBCMJC, Vector3 AOCFJJDJMOP, Vector3 HFEHNPHEJLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0xBB31F0", Offset = "0xBB1DF0", VA = "0x180BB31F0")]
		public GALGOPAILFE GetAnchorParamsRestrictions()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x7F44E00", Offset = "0x7F43A00", VA = "0x187F44E00")]
		public void ApplyBlocks()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x7F44F40", Offset = "0x7F43B40", VA = "0x187F44F40")]
		public void ApplyHairPattern()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x7F44D70", Offset = "0x7F43970", VA = "0x187F44D70")]
		public void ApplyBeardPattern()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x7F504F0", Offset = "0x7F4F0F0", VA = "0x187F504F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x7F4B2E0", Offset = "0x7F49EE0", VA = "0x187F4B2E0")]
		protected void JOCLPNEDPNP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x7F502B0", Offset = "0x7F4EEB0", VA = "0x187F502B0")]
		public void SetWaitForUgcTextureLoads(bool IOBLNEBHEAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x7F50130", Offset = "0x7F4ED30", VA = "0x187F50130")]
		public void SetUgcTextureParameters(JNFHAACMDFI KCHMACEBLIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x7F513A0", Offset = "0x7F4FFA0", VA = "0x187F513A0")]
		public PlayerAvatarDisplayBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x7F4AE90", Offset = "0x7F49A90", VA = "0x187F4AE90")]
		[CompilerGenerated]
		private void JEKOCJBJNDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x7F470F0", Offset = "0x7F45CF0", VA = "0x187F470F0")]
		[CompilerGenerated]
		private void DELLEEJCAAM(LKNKINEHDKB NDIPIKDGHKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x7F48D20", Offset = "0x7F47920", VA = "0x187F48D20")]
		[CompilerGenerated]
		private void GGOHJPLHCAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x7F4D0A0", Offset = "0x7F4BCA0", VA = "0x187F4D0A0")]
		[CompilerGenerated]
		private void PGPHKIGHPKN(LKNKINEHDKB NDIPIKDGHKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x7F47CD0", Offset = "0x7F468D0", VA = "0x187F47CD0")]
		[CompilerGenerated]
		private void EFCEDBJNDBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x7F48360", Offset = "0x7F46F60", VA = "0x187F48360")]
		[CompilerGenerated]
		private void ENLJCBCEKOO(LKNKINEHDKB NDIPIKDGHKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x7F4D140", Offset = "0x7F4BD40", VA = "0x187F4D140")]
		[CompilerGenerated]
		private void PHMJJLHENHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x7F45720", Offset = "0x7F44320", VA = "0x187F45720")]
		[CompilerGenerated]
		private void BDFANAKNGDM(LKNKINEHDKB NDIPIKDGHKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x7F44940", Offset = "0x7F43540", VA = "0x187F44940")]
		[CompilerGenerated]
		private void AKOLCCPANEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x7F4B430", Offset = "0x7F4A030", VA = "0x187F4B430")]
		[CompilerGenerated]
		private void KAHFLBHNKKL(LKNKINEHDKB NDIPIKDGHKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x7F471C0", Offset = "0x7F45DC0", VA = "0x187F471C0")]
		[CompilerGenerated]
		private void DNNEIGCPOMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x7F4B2C0", Offset = "0x7F49EC0", VA = "0x187F4B2C0")]
		[CompilerGenerated]
		private void JMHFBIHFGGK(LKNKINEHDKB NDIPIKDGHKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x7F4D2E0", Offset = "0x7F4BEE0", VA = "0x187F4D2E0")]
		[CompilerGenerated]
		internal static bool PNBBEIAADDH(Transform OHMBFKANFEA, IEnumerable<SkinnedMeshRenderer> PMCCFCHOJEC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x7F48500", Offset = "0x7F47100", VA = "0x187F48500")]
		[CompilerGenerated]
		private void FGAJFBIJOCO(LKNKINEHDKB NDIPIKDGHKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x7F4AF20", Offset = "0x7F49B20", VA = "0x187F4AF20")]
		[CompilerGenerated]
		private void JFCGJHJNIBD(LKNKINEHDKB NDIPIKDGHKM)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[ExecuteAlways]
	public class PlayerFacialAnimatorBase : MonoBehaviour, HKJBNPOGLFP
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200006E")]
		[CompilerGenerated]
		private struct COMDJOOLEIF : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000474")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000475")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000476")]
			public DNHFACAJPBE avatarData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000477")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000478")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003AD")]
			[Cpp2IlInjected.Address(RVA = "0x7F54410", Offset = "0x7F53010", VA = "0x187F54410", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AE")]
			[Cpp2IlInjected.Address(RVA = "0x7F546A0", Offset = "0x7F532A0", VA = "0x187F546A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200006F")]
		[CompilerGenerated]
		private struct NIFCBHGEPFO : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000479")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400047A")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400047B")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400047C")]
			public int eyeSelection;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x400047D")]
			public int eyeBrowSelection;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400047E")]
			public int noseSelection;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x400047F")]
			public int mouthSelection;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000480")]
			public ADAOAPJGFHC avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000481")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003AF")]
			[Cpp2IlInjected.Address(RVA = "0x7F5B890", Offset = "0x7F5A490", VA = "0x187F5B890", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B0")]
			[Cpp2IlInjected.Address(RVA = "0x7F5BA70", Offset = "0x7F5A670", VA = "0x187F5BA70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000070")]
		[CompilerGenerated]
		private struct HHKENGLJAIH : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000482")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000483")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000484")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000485")]
			public FaceFeatureType featureType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000486")]
			public int selectionIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000487")]
			public ADAOAPJGFHC avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000488")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003B1")]
			[Cpp2IlInjected.Address(RVA = "0x7F55690", Offset = "0x7F54290", VA = "0x187F55690", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B2")]
			[Cpp2IlInjected.Address(RVA = "0x7F55830", Offset = "0x7F54430", VA = "0x187F55830", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000071")]
		[CompilerGenerated]
		private struct NBMCOEAFGNN : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000489")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400048A")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400048B")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400048C")]
			public DNHFACAJPBE avatarData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400048D")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003B3")]
			[Cpp2IlInjected.Address(RVA = "0x7F5B680", Offset = "0x7F5A280", VA = "0x187F5B680", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B4")]
			[Cpp2IlInjected.Address(RVA = "0x7F5B830", Offset = "0x7F5A430", VA = "0x187F5B830", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000072")]
		[CompilerGenerated]
		private struct GNJGFDPMAGG : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400048E")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400048F")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000490")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000491")]
			public ADAOAPJGFHC avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000492")]
			private TaskAwaiter<DIDPGDAHHCN> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003B5")]
			[Cpp2IlInjected.Address(RVA = "0x7F55110", Offset = "0x7F53D10", VA = "0x187F55110", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B6")]
			[Cpp2IlInjected.Address(RVA = "0x7F55550", Offset = "0x7F54150", VA = "0x187F55550", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000073")]
		[CompilerGenerated]
		private struct AHJAAMGMHHE : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000493")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000494")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000495")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000496")]
			public bool forceRebuild;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000497")]
			public ADAOAPJGFHC avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000498")]
			private FaceStyleSet <styleSet>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000499")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003B7")]
			[Cpp2IlInjected.Address(RVA = "0x7F53980", Offset = "0x7F52580", VA = "0x187F53980", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B8")]
			[Cpp2IlInjected.Address(RVA = "0x7F53DA0", Offset = "0x7F529A0", VA = "0x187F53DA0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40003FC")]
		protected const float MDENKDMLDIE = 0.5f;

		[Cpp2IlInjected.Token(Token = "0x40003FD")]
		protected const int JGAHPPOANPP = 5;

		[Cpp2IlInjected.Token(Token = "0x40003FE")]
		private static readonly int KECPIPAOFKJ;

		[Cpp2IlInjected.Token(Token = "0x40003FF")]
		private static readonly int EANANMMCIKG;

		[Cpp2IlInjected.Token(Token = "0x4000400")]
		private static readonly int KOIJMDAGAGA;

		[Cpp2IlInjected.Token(Token = "0x4000401")]
		public static readonly int IdleID;

		[Cpp2IlInjected.Token(Token = "0x4000402")]
		public static readonly int SmileID;

		[Cpp2IlInjected.Token(Token = "0x4000403")]
		public static readonly int HugeSmileID;

		[Cpp2IlInjected.Token(Token = "0x4000404")]
		public static readonly int ScoreID;

		[Cpp2IlInjected.Token(Token = "0x4000405")]
		public static readonly int SadID;

		[Cpp2IlInjected.Token(Token = "0x4000406")]
		public static readonly int DisgustID;

		[Cpp2IlInjected.Token(Token = "0x4000407")]
		public static readonly int HitID;

		[Cpp2IlInjected.Token(Token = "0x4000408")]
		public static readonly int ConcentrateID;

		[Cpp2IlInjected.Token(Token = "0x4000409")]
		public static readonly int KissID;

		[Cpp2IlInjected.Token(Token = "0x400040A")]
		public static readonly int TalkingID;

		[Cpp2IlInjected.Token(Token = "0x400040B")]
		public static readonly int MuteID;

		[Cpp2IlInjected.Token(Token = "0x400040C")]
		public static readonly int AFKID;

		[Cpp2IlInjected.Token(Token = "0x400040D")]
		public static readonly int HappyID;

		[Cpp2IlInjected.Token(Token = "0x400040E")]
		public static readonly int EmoteFlatID;

		[Cpp2IlInjected.Token(Token = "0x400040F")]
		public static readonly int EmoteHappyID;

		[Cpp2IlInjected.Token(Token = "0x4000410")]
		public static readonly int EmoteSadID;

		[Cpp2IlInjected.Token(Token = "0x4000411")]
		public static readonly int EmoteLoveID;

		[Cpp2IlInjected.Token(Token = "0x4000412")]
		public static readonly int EmoteAngryID;

		[Cpp2IlInjected.Token(Token = "0x4000413")]
		public static readonly int EmoteLaughID;

		[Cpp2IlInjected.Token(Token = "0x4000414")]
		public static readonly int EmoteTongueOutID;

		[Cpp2IlInjected.Token(Token = "0x4000415")]
		public static readonly int EmoteGrimacingID;

		[Cpp2IlInjected.Token(Token = "0x4000416")]
		public static readonly int EmoteWinkID;

		[Cpp2IlInjected.Token(Token = "0x4000417")]
		public static readonly int EmoteShockedID;

		[Cpp2IlInjected.Token(Token = "0x4000418")]
		public static readonly int EmoteNauseatedID;

		[Cpp2IlInjected.Token(Token = "0x4000419")]
		public static readonly int EmoteSmileSweatID;

		[Cpp2IlInjected.Token(Token = "0x400041A")]
		public static readonly int EmoteSleepingID;

		[Cpp2IlInjected.Token(Token = "0x400041B")]
		public static readonly int EmoteThinkingID;

		[Cpp2IlInjected.Token(Token = "0x400041C")]
		public static readonly int EmoteSmirkID;

		[Cpp2IlInjected.Token(Token = "0x400041D")]
		public static readonly int EmoteSmileID;

		[Cpp2IlInjected.Token(Token = "0x400041E")]
		protected static readonly Dictionary<CHENLFDHHPB.KDMLMMEPJPI, int> MNFHIKKKHHJ;

		[Cpp2IlInjected.Token(Token = "0x400041F")]
		[CanBeNull]
		protected static IEnumerable<FaceFeatureType> JFNLDLPCIFP;

		[Cpp2IlInjected.Token(Token = "0x4000420")]
		protected static readonly int JCJIMGDBPIC;

		[Cpp2IlInjected.Token(Token = "0x4000421")]
		protected static readonly int MDHOALIAIFE;

		[Cpp2IlInjected.Token(Token = "0x4000422")]
		protected static readonly int KDHBGMMNOOE;

		[Cpp2IlInjected.Token(Token = "0x4000423")]
		protected static readonly int IBDLFMKDCJG;

		[Cpp2IlInjected.Token(Token = "0x4000424")]
		protected static readonly int FNKGGPINJIF;

		[Cpp2IlInjected.Token(Token = "0x4000425")]
		protected static Vector2 BCHFFILAAFA;

		[Cpp2IlInjected.Token(Token = "0x4000426")]
		protected static Vector2 HDOJMOALEGG;

		[Cpp2IlInjected.Token(Token = "0x4000427")]
		protected static Vector2 AGMOLPOAKKP;

		[Cpp2IlInjected.Token(Token = "0x4000428")]
		protected static Vector2 CLJHLKHECGB;

		[Cpp2IlInjected.Token(Token = "0x4000429")]
		protected static Vector2 GIDHAHOLNAO;

		[Cpp2IlInjected.Token(Token = "0x400042A")]
		protected static Vector2 KONHFLMMDCO;

		[Cpp2IlInjected.Token(Token = "0x400042B")]
		protected static Vector2 IFCMHIFHMBI;

		[Cpp2IlInjected.Token(Token = "0x400042C")]
		protected static Vector2 GLDLNJMHBPP;

		[Cpp2IlInjected.Token(Token = "0x400042D")]
		protected static Vector2 AOHOJNGNKNF;

		[Cpp2IlInjected.Token(Token = "0x400042E")]
		protected static Vector2 MCBOGOEEDAD;

		[Cpp2IlInjected.Token(Token = "0x400042F")]
		protected static Vector2 LFGEBJABGNA;

		[Cpp2IlInjected.Token(Token = "0x4000430")]
		protected static Vector2 KEIFCKBCHBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000431")]
		[SerializeField]
		[IODJOKMKDII(AFILHNGOOLF.Self, false, false, false)]
		public Animator animator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000432")]
		[Header("Rendering")]
		[SerializeField]
		public FaceStyleSet faceStyleSet;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000433")]
		[SerializeField]
		protected Renderer faceRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000434")]
		[SerializeField]
		protected float jitterFPS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000435")]
		[SerializeField]
		[Header("Emotes")]
		public Renderer[] emoteEffectRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000436")]
		[SerializeField]
		[FormerlySerializedAs("fullBodyFaceStyleSet")]
		[Header("Modern Avatar Facial Features")]
		public FaceStyleSet modernBodyFaceStyleSet;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000437")]
		private ADAOAPJGFHC PKFDOPDHADB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000438")]
		private FaceStyleSet DEKNKLOOBHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000439")]
		[SerializeField]
		protected bool debugEyeJitterInEditor;

		[Cpp2IlInjected.Token(Token = "0x400043A")]
		protected const int DCDMAHEGKGF = -1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400043B")]
		protected int IHBHHCJLIKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400043C")]
		protected int CGJMAJNFOMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400043D")]
		protected int ECAJLOMLKHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400043E")]
		protected int NOCNKDCKNFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x400043F")]
		protected Vector2 NMBADMFELKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000440")]
		protected float FGEGIDDDGMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000441")]
		protected float PAEEPHMJEMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4000442")]
		protected float CDNBMEHDBFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000443")]
		protected Vector2 ODGLGCDCODB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000444")]
		protected float OCPFOHCBPGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x4000445")]
		protected float MNIHKFELCHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000446")]
		protected float OFGKOOOGOLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x4000447")]
		protected Vector2 NPOEPAPJAPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x4000448")]
		protected float OILDFNLEDHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000449")]
		protected float LNFKILNKPKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x400044A")]
		protected float JEMAPOPIAHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400044B")]
		protected Vector2 BGOKLAJDOCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400044C")]
		protected float NJEBDKACDKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x400044D")]
		protected float OHOFHFOBIBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400044E")]
		protected float IOBINNPPBPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400044F")]
		protected List<SelectableFaceOption> EEPFKBJCGLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000450")]
		protected List<SelectableFaceOption> LABJFEMKAII;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000451")]
		protected List<SelectableFaceOption> ADEEBMPMODO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000452")]
		protected List<SelectableFaceOption> EODFNAMOPJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000453")]
		protected Coroutine HLPPPKBMBIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000454")]
		protected int? FNIFHABHOLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000455")]
		protected int CEOCEELPMHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
		[Cpp2IlInjected.Token(Token = "0x4000456")]
		protected int ACIHDKHAHFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000457")]
		protected int JNMPFALIEGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
		[Cpp2IlInjected.Token(Token = "0x4000458")]
		protected int DJPOKDCKAHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000459")]
		protected Sprite NFFJPKKGGCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400045A")]
		protected Sprite OMDIAOFLENB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400045B")]
		protected Sprite OFOCOBAJFIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x400045C")]
		protected Sprite CCKJNDBNCCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x400045D")]
		protected bool LEBMCMABEOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x400045F")]
		protected string GDMJJLKPFEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000460")]
		protected string EIEEBNIOOHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000461")]
		protected string LCGIKHPECJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x4000462")]
		protected string BJIJJLMCMOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4000463")]
		[ReadOnlyField]
		public Sprite eyeSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4000464")]
		[ReadOnlyField]
		public Sprite leftEyeOnlySprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4000465")]
		[ReadOnlyField]
		public Sprite rightEyeOnlySprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4000466")]
		public Color leftEyeColorTint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x4000467")]
		public Color leftEyeGleamColorTint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x4000468")]
		public Color rightEyeColorTint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x4000469")]
		public Color rightEyeGleamColorTint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x400046A")]
		[ReadOnlyField]
		public Sprite mouthSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x400046E")]
		protected AvatarConfiguration ONBOCFICLND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x400046F")]
		protected DIDPGDAHHCN BAANGEFNHCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x4000471")]
		private readonly List<Material> ECECBFHHEOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x4000472")]
		protected CHEOGLIHFLP KDLABOLMIGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x4000473")]
		protected Dictionary<string, int> AKNJIAMHOLP;

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		public FaceStyleSet FIGHCNOHHJG
		{
			[Cpp2IlInjected.Token(Token = "0x6000364")]
			[Cpp2IlInjected.Address(RVA = "0x7F62750", Offset = "0x7F61350", VA = "0x187F62750")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A0")]
		public bool LODEDLFDNDA
		{
			[Cpp2IlInjected.Token(Token = "0x6000367")]
			[Cpp2IlInjected.Address(RVA = "0xAF87C0", Offset = "0xAF73C0", VA = "0x180AF87C0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000368")]
			[Cpp2IlInjected.Address(RVA = "0x26770E0", Offset = "0x2675CE0", VA = "0x1826770E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A1")]
		protected virtual bool AGCHBPHJCPI
		{
			[Cpp2IlInjected.Token(Token = "0x6000369")]
			[Cpp2IlInjected.Address(RVA = "0xAA76B0", Offset = "0xAA62B0", VA = "0x180AA76B0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A2")]
		protected virtual bool LHFHGKJLDPC
		{
			[Cpp2IlInjected.Token(Token = "0x600036A")]
			[Cpp2IlInjected.Address(RVA = "0xA77810", Offset = "0xA76410", VA = "0x180A77810", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A3")]
		protected int LMLIEHJOBCN
		{
			[Cpp2IlInjected.Token(Token = "0x600036B")]
			[Cpp2IlInjected.Address(RVA = "0x7F5D2C0", Offset = "0x7F5BEC0", VA = "0x187F5D2C0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A4")]
		public Renderer NFOJOKFONIF
		{
			[Cpp2IlInjected.Token(Token = "0x600036C")]
			[Cpp2IlInjected.Address(RVA = "0xA5B5E0", Offset = "0xA5A1E0", VA = "0x180A5B5E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		public bool NAJLGIGOHJM
		{
			[Cpp2IlInjected.Token(Token = "0x600036D")]
			[Cpp2IlInjected.Address(RVA = "0x2680530", Offset = "0x267F130", VA = "0x182680530")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600036E")]
			[Cpp2IlInjected.Address(RVA = "0x2675170", Offset = "0x2673D70", VA = "0x182675170")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A6")]
		public Renderer[] NGPLFDALODP
		{
			[Cpp2IlInjected.Token(Token = "0x600036F")]
			[Cpp2IlInjected.Address(RVA = "0xA5B560", Offset = "0xA5A160", VA = "0x180A5B560")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A7")]
		public bool GGBEGFIBDHC
		{
			[Cpp2IlInjected.Token(Token = "0x6000370")]
			[Cpp2IlInjected.Address(RVA = "0x7F627A0", Offset = "0x7F613A0", VA = "0x187F627A0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000371")]
			[Cpp2IlInjected.Address(RVA = "0x7F62960", Offset = "0x7F61560", VA = "0x187F62960")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A8")]
		protected int AOPEGGMMIDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000372")]
			[Cpp2IlInjected.Address(RVA = "0x7F5D760", Offset = "0x7F5C360", VA = "0x187F5D760")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A9")]
		protected int BOJALACHPNN
		{
			[Cpp2IlInjected.Token(Token = "0x6000373")]
			[Cpp2IlInjected.Address(RVA = "0x7F5F9B0", Offset = "0x7F5E5B0", VA = "0x187F5F9B0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AA")]
		public float GPFKLGKDILB
		{
			[Cpp2IlInjected.Token(Token = "0x6000374")]
			[Cpp2IlInjected.Address(RVA = "0x7F62780", Offset = "0x7F61380", VA = "0x187F62780")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000375")]
			[Cpp2IlInjected.Address(RVA = "0x7F62940", Offset = "0x7F61540", VA = "0x187F62940")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AB")]
		public HGPOBCJDMGK KCEMAFNKGHO
		{
			[Cpp2IlInjected.Token(Token = "0x6000376")]
			[Cpp2IlInjected.Address(RVA = "0xB1BEA0", Offset = "0xB1AAA0", VA = "0x180B1BEA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000377")]
			[Cpp2IlInjected.Address(RVA = "0xB193F0", Offset = "0xB17FF0", VA = "0x180B193F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AC")]
		public DIDPGDAHHCN FFIJPLLLAGE
		{
			[Cpp2IlInjected.Token(Token = "0x6000393")]
			[Cpp2IlInjected.Address(RVA = "0xB51340", Offset = "0xB4FF40", VA = "0x180B51340")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000394")]
			[Cpp2IlInjected.Address(RVA = "0x7F628C0", Offset = "0x7F614C0", VA = "0x187F628C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AD")]
		public NoseFaceOption OBPJGCKMDHD
		{
			[Cpp2IlInjected.Token(Token = "0x6000395")]
			[Cpp2IlInjected.Address(RVA = "0xB262A0", Offset = "0xB24EA0", VA = "0x180B262A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000396")]
			[Cpp2IlInjected.Address(RVA = "0xBBA510", Offset = "0xBB9110", VA = "0x180BBA510")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AE")]
		protected CHEOGLIHFLP JMHFBFICPGL
		{
			[Cpp2IlInjected.Token(Token = "0x6000397")]
			[Cpp2IlInjected.Address(RVA = "0x7F5FC20", Offset = "0x7F5E820", VA = "0x187F5FC20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action EKPEKLPGAJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000365")]
			[Cpp2IlInjected.Address(RVA = "0x7F626A0", Offset = "0x7F612A0", VA = "0x187F626A0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000366")]
			[Cpp2IlInjected.Address(RVA = "0x7F62810", Offset = "0x7F61410", VA = "0x187F62810")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x7F5E650", Offset = "0x7F5D250", VA = "0x187F5E650")]
		public void LocalPlayEmote(CHENLFDHHPB.KDMLMMEPJPI DEIFCGKHLIB, float FFPHGGNCGBI = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x7F5DFE0", Offset = "0x7F5CBE0", VA = "0x187F5DFE0")]
		public bool IsEmotePlaying(CHENLFDHHPB.KDMLMMEPJPI DEIFCGKHLIB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x7F605D0", Offset = "0x7F5F1D0", VA = "0x187F605D0")]
		public void SetIdleHappy(bool EPEMGLFNEJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x7F5E280", Offset = "0x7F5CE80", VA = "0x187F5E280")]
		protected void JJGLAJHGIJE(bool PFEDPILDEEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x7F5CEB0", Offset = "0x7F5BAB0", VA = "0x187F5CEB0")]
		protected void CHAPGLKBAMB(bool KCAAJOFOJMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x7F5F050", Offset = "0x7F5DC50", VA = "0x187F5F050")]
		protected void NLOMCECDJMK(FMEODGEFBMO DAMAHFKHDCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x7F5C240", Offset = "0x7F5AE40", VA = "0x187F5C240")]
		protected void ADIPKDNNNEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x7F5FCA0", Offset = "0x7F5E8A0", VA = "0x187F5FCA0")]
		public void PlayExpression(int INODGBOFFPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x7F5C430", Offset = "0x7F5B030", VA = "0x187F5C430")]
		protected void AHDNLLPILEA(bool OMBGFIAMGBK, bool PHICIBDHDGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x7F5D9A0", Offset = "0x7F5C5A0", VA = "0x187F5D9A0")]
		public List<SelectableFaceOption> GetAvailableFeatures(FaceFeatureType EOBOKFIMLEO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x7F5DAB0", Offset = "0x7F5C6B0", VA = "0x187F5DAB0")]
		public void InitializeFaceFeatureRanges(AvatarConfiguration ONBOCFICLND, ADAOAPJGFHC ODLFGIBLFNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x7F603A0", Offset = "0x7F5EFA0", VA = "0x187F603A0")]
		[AsyncStateMachine(typeof(COMDJOOLEIF))]
		public Task SetFaceSettings(DNHFACAJPBE LBEKEMPAKCH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x7F60270", Offset = "0x7F5EE70", VA = "0x187F60270")]
		[AsyncStateMachine(typeof(NIFCBHGEPFO))]
		public Task SetFaceSettings(int PKFPPNOOIFI, int EHHKBGCPPHA, int JPNLPPCCFOG, int PCOENNKAJGA, ADAOAPJGFHC ODLFGIBLFNK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x7F60650", Offset = "0x7F5F250", VA = "0x187F60650")]
		[AsyncStateMachine(typeof(HHKENGLJAIH))]
		public Task SetSelectedFaceFeatureAndBuildFaceStyle(FaceFeatureType EOBOKFIMLEO, int GICGIBHEEEL, ADAOAPJGFHC ODLFGIBLFNK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x7F5E100", Offset = "0x7F5CD00", VA = "0x187F5E100")]
		protected void JHDAPDFJELF(FaceFeatureType EOBOKFIMLEO, PFINHFPAAHI ICLLPKAEHAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x7F5E750", Offset = "0x7F5D350", VA = "0x187F5E750")]
		protected void MLMKIAPHMLF(FaceFeatureType EOBOKFIMLEO, int GICGIBHEEEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x7F5D7C0", Offset = "0x7F5C3C0", VA = "0x187F5D7C0")]
		public static IEnumerable<FaceFeatureType> GetAllFaceFeatureTypes()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x7F5E300", Offset = "0x7F5CF00", VA = "0x187F5E300")]
		[AsyncStateMachine(typeof(NBMCOEAFGNN))]
		protected Task KFJBGOKIEKO(DNHFACAJPBE LBEKEMPAKCH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x7F5CBB0", Offset = "0x7F5B7B0", VA = "0x187F5CBB0")]
		protected void CCJHNKJKECL(DNHFACAJPBE LBEKEMPAKCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x7F5EEB0", Offset = "0x7F5DAB0", VA = "0x187F5EEB0")]
		protected static void NKIDAHGEKJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x7F5D4D0", Offset = "0x7F5C0D0", VA = "0x187F5D4D0")]
		private void FFLCFPEKDBE(bool MENJECGAKNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x7F5C4F0", Offset = "0x7F5B0F0", VA = "0x187F5C4F0")]
		protected void AJONNLFOPLH(FaceFeatureType EOBOKFIMLEO, Vector2 OEGLMCMECBL, ADAOAPJGFHC ODLFGIBLFNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x7F5FCC0", Offset = "0x7F5E8C0", VA = "0x187F5FCC0")]
		public void SetFaceFeatureNormalizedPositionOffset(FaceFeatureType EOBOKFIMLEO, Vector2 MIAICHNDLHG, ADAOAPJGFHC ODLFGIBLFNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x7F5C2B0", Offset = "0x7F5AEB0", VA = "0x187F5C2B0")]
		protected void ADMDCACCOLC(FaceFeatureType EOBOKFIMLEO, float JHIOFLALIPO, ADAOAPJGFHC ODLFGIBLFNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x7F5E4D0", Offset = "0x7F5D0D0", VA = "0x187F5E4D0")]
		protected void KOKJCGEAEPG(FaceFeatureType EOBOKFIMLEO, float DINDLKHALMD, ADAOAPJGFHC ODLFGIBLFNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x7F5D9E0", Offset = "0x7F5C5E0", VA = "0x187F5D9E0")]
		protected void HDKKLDINEHC(FaceFeatureType EOBOKFIMLEO, float IOENJADIPLP, ADAOAPJGFHC ODLFGIBLFNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x7F60050", Offset = "0x7F5EC50", VA = "0x187F60050")]
		public void SetFaceFeatureNormalizedScaleOffset(FaceFeatureType EOBOKFIMLEO, float KPGDEJIAKLJ, ADAOAPJGFHC ODLFGIBLFNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x7F5D3F0", Offset = "0x7F5BFF0", VA = "0x187F5D3F0")]
		[AsyncStateMachine(typeof(GNJGFDPMAGG))]
		protected Task FDFJGNGEAHD(ADAOAPJGFHC ODLFGIBLFNK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x7F5DDD0", Offset = "0x7F5C9D0", VA = "0x187F5DDD0")]
		public void InitializeFaceFeatureStyleSet(ADAOAPJGFHC ODLFGIBLFNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x7F5E3F0", Offset = "0x7F5CFF0", VA = "0x187F5E3F0")]
		protected bool KKFFALDOOGG(string HGEEOIECMEK, [Out] int LCCBBMBENOH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x7F5C880", Offset = "0x7F5B480", VA = "0x187F5C880")]
		protected void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x7F60760", Offset = "0x7F5F360", VA = "0x187F60760", Slot = "8")]
		protected virtual void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x7F5FA10", Offset = "0x7F5E610", VA = "0x187F5FA10")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x7F61750", Offset = "0x7F60350", VA = "0x187F61750")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x7F5CAB0", Offset = "0x7F5B6B0", VA = "0x187F5CAB0")]
		[AsyncStateMachine(typeof(AHJAAMGMHHE))]
		public Task BuildFaceStyleAsyncIfChanged(ADAOAPJGFHC ODLFGIBLFNK, bool PIGLABJPCAC = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x7F61060", Offset = "0x7F5FC60", VA = "0x187F61060")]
		public void UpdateFaceDisplays(bool ALOCMPKLDKG = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x7F5F270", Offset = "0x7F5DE70", VA = "0x187F5F270")]
		protected bool ODPHKCHBKPF(bool ALOCMPKLDKG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x7F60DC0", Offset = "0x7F5F9C0", VA = "0x187F60DC0")]
		public void UpdateFaceDisplayFeatureTextures()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x7F60490", Offset = "0x7F5F090", VA = "0x187F60490")]
		public void SetFaceSpriteIndices(string GFMIBMKEKOL, string EHJPNAIEAGL, string CGCKHNHJPFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x7F60770", Offset = "0x7F5F370", VA = "0x187F60770")]
		public void UpdateFaceDisplayFeaturePositions()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0x7F61280", Offset = "0x7F5FE80", VA = "0x187F61280")]
		public void UpdateFaceJitterMultiplier()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x7F61470", Offset = "0x7F60070", VA = "0x187F61470")]
		public bool UpdateLegacyFaceVectors()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x7F5C9C0", Offset = "0x7F5B5C0", VA = "0x187F5C9C0")]
		protected void BOFNBHPDGMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0x7F5D010", Offset = "0x7F5BC10", VA = "0x187F5D010")]
		private void EFGMALMBDMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x7F5F0C0", Offset = "0x7F5DCC0", VA = "0x187F5F0C0")]
		private void NMMKLGDKICO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0x7F62440", Offset = "0x7F61040", VA = "0x187F62440")]
		public PlayerFacialAnimatorBase()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0xA89010", Offset = "0xA87C10", VA = "0x180A89010", Slot = "4")]
		private bool JHHMLKIFGCE()
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public struct ILEAEBJMFMN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400049A")]
	public string FEGHCLOCPPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400049B")]
	public int CKHNJNJFACM;
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	[ExecuteInEditMode]
	[SelectionBase]
	public class PlayerModernBodyEditorAvatarValidator : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000077")]
		[CompilerGenerated]
		private struct GIICNAAAEJJ : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004FB")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40004FC")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004FD")]
			public PlayerModernBodyEditorAvatarValidator <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004FE")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003EC")]
			[Cpp2IlInjected.Address(RVA = "0x7F54F10", Offset = "0x7F53B10", VA = "0x187F54F10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003ED")]
			[Cpp2IlInjected.Address(RVA = "0xAB3320", Offset = "0xAB1F20", VA = "0x180AB3320", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000078")]
		[CompilerGenerated]
		private struct BALJDCNMFCK : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004FF")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000500")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000501")]
			public PlayerModernBodyEditorAvatarValidator <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000502")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003EE")]
			[Cpp2IlInjected.Address(RVA = "0x7F53E00", Offset = "0x7F52A00", VA = "0x187F53E00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003EF")]
			[Cpp2IlInjected.Address(RVA = "0x7F54300", Offset = "0x7F52F00", VA = "0x187F54300", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400049C")]
		public const string IDLE_ANIM_NAME = "Idle";

		[Cpp2IlInjected.Token(Token = "0x400049D")]
		public const string A_POSE_ANIM_NAME = "A Pose";

		[Cpp2IlInjected.Token(Token = "0x400049E")]
		public const string ANIMATION_OVERRIDE_STATE_NAME = "Override";

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400049F")]
		public ADAOAPJGFHC avatarBodyType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		public Color hairPrimaryColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		public Color hairSecondaryColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		public Color beardPrimaryColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40004A4")]
		public Color beardSecondaryColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		public Color skinColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		public int faceShapeIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		public int bodyShapeIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		public int hairPatternIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		public int beardPatternIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004AA")]
		public AvatarFaceShape[] faceShapes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		public AvatarBodyShape[] bodyShapes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		public AvatarHairPattern[] hairPatterns;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		public float _avatarScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		public bool enablePosing;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		public int poseIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40004B0")]
		public AnimationClip animationOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40004B1")]
		[Range(0f, 4f)]
		public float animationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x40004B2")]
		public bool hideEars;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40004B3")]
		public LFBJHFHIBPH useHelmetHair;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40004B4")]
		public PBOEGNLEBIG hatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40004B5")]
		public GALGOPAILFE HatAnchorRestrictions;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40004B6")]
		public bool UseHairFitMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD1")]
		[Cpp2IlInjected.Token(Token = "0x40004B7")]
		public bool usesHatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40004B8")]
		public GameObject hatPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40004B9")]
		public GameObject hairPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40004BA")]
		public GameObject earPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40004BB")]
		public GameObject eyePrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40004BC")]
		public GameObject mouthPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40004BD")]
		public GameObject neckPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40004BE")]
		public GameObject shirtPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40004BF")]
		public GameObject beltPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40004C0")]
		public GameObject shoulderPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40004C1")]
		public GameObject rightHandPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40004C2")]
		public GameObject leftHandPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40004C3")]
		public GameObject legsPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40004C4")]
		public GameObject feetPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40004C5")]
		public long baseSkinCullingMask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40004C6")]
		[IODJOKMKDII(AFILHNGOOLF.Self, false, false, false)]
		[SerializeField]
		public PlayerAvatarDisplayBase _avatarDisplay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40004C7")]
		private BHHFEEPAMEP IIFJPJGMNGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40004C8")]
		[SerializeField]
		[IODJOKMKDII(AFILHNGOOLF.Self, false, false, false)]
		public PlayerFacialAnimatorBase facialAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40004C9")]
		public Animator animator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40004CA")]
		public AnimationClip animationClipToOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40004CB")]
		private AnimatorOverrideController HEMIILCOGJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40004CC")]
		private List<KeyValuePair<AnimationClip, AnimationClip>> AMEBOGECCAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x40004CD")]
		public Transform headIKEffector;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x40004CE")]
		public Transform leftHandIKEffector;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x40004CF")]
		public Transform rightHandIKEffector;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x40004D0")]
		[Range(0f, 2f)]
		public int lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19C")]
		[Cpp2IlInjected.Token(Token = "0x40004D1")]
		public int rightHandGestureStateIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x40004D2")]
		[Range(0f, 1f)]
		public float rightHandCurl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A4")]
		[Cpp2IlInjected.Token(Token = "0x40004D3")]
		public int leftHandGestureStateIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x40004D4")]
		[Range(0f, 1f)]
		public float leftHandCurl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1AC")]
		[Cpp2IlInjected.Token(Token = "0x40004D5")]
		public int eyeBrowSelection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x40004D6")]
		public int eyeSelection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B4")]
		[Cpp2IlInjected.Token(Token = "0x40004D7")]
		public int noseSelection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x40004D8")]
		public int mouthSelection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1BC")]
		[Cpp2IlInjected.Token(Token = "0x40004D9")]
		public float eyeBrowPositionOffsetHorizontal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x40004DA")]
		public float eyeBrowPositionOffsetVertical;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C4")]
		[Cpp2IlInjected.Token(Token = "0x40004DB")]
		public float eyeBrowScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x40004DC")]
		public float eyePositionOffsetHorizontal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1CC")]
		[Cpp2IlInjected.Token(Token = "0x40004DD")]
		public float eyePositionOffsetVertical;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x40004DE")]
		public float eyeScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D4")]
		[Cpp2IlInjected.Token(Token = "0x40004DF")]
		public float nosePositionOffsetVertical;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x40004E0")]
		public float noseScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1DC")]
		[Cpp2IlInjected.Token(Token = "0x40004E1")]
		public float mouthPositionOffsetHorizontal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x40004E2")]
		public float mouthPositionOffsetVertical;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E4")]
		[Cpp2IlInjected.Token(Token = "0x40004E3")]
		public float mouthScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x40004E4")]
		public float hatNormalizedPositionX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1EC")]
		[Cpp2IlInjected.Token(Token = "0x40004E5")]
		public float hatNormalizedPositionY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
		[Cpp2IlInjected.Token(Token = "0x40004E6")]
		public Vector3 hatHemispherePositionOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1FC")]
		[Cpp2IlInjected.Token(Token = "0x40004E7")]
		public Vector3 hatHemisphereRotationOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
		[Cpp2IlInjected.Token(Token = "0x40004E8")]
		public int facialExpressionIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20C")]
		[Cpp2IlInjected.Token(Token = "0x40004E9")]
		[Range(0f, 1f)]
		public float normalizedTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
		[Cpp2IlInjected.Token(Token = "0x40004EA")]
		public readonly ILEAEBJMFMN[] FacialExpressions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
		[Cpp2IlInjected.Token(Token = "0x40004EB")]
		public readonly string[] BodyPoses;

		[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
		[Cpp2IlInjected.Token(Token = "0x40004EC")]
		public readonly (string, IKOIPHKGCMC)[] HandPoses;

		[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
		[Cpp2IlInjected.Token(Token = "0x40004ED")]
		public bool hideLeftWatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x229")]
		[Cpp2IlInjected.Token(Token = "0x40004EE")]
		public bool hideRightWatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x22A")]
		[Cpp2IlInjected.Token(Token = "0x40004EF")]
		protected bool JBJJEMCJKGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x22C")]
		[Cpp2IlInjected.Token(Token = "0x40004F0")]
		protected Guid MGCPAFLCELL;

		[Cpp2IlInjected.Token(Token = "0x40004F1")]
		protected static Guid ELNEAKPALIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
		[Cpp2IlInjected.Token(Token = "0x40004F2")]
		private FNKBCEMJFAH BGDHOACJNIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
		[Cpp2IlInjected.Token(Token = "0x40004F3")]
		private HGPOBCJDMGK LIKGNCPIJGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
		[Cpp2IlInjected.Token(Token = "0x40004F4")]
		private LAJPNBFOHGM BAOHBKMHGOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
		[Cpp2IlInjected.Token(Token = "0x40004F5")]
		private LAJPNBFOHGM DLMMCNJECOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x40004F6")]
		private AdditionalHatData BHMAKBIACCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
		[Cpp2IlInjected.Token(Token = "0x40004F7")]
		private readonly Dictionary<GameObject, OBOPCOPCCAH> CDENMHKPJDH;

		[Cpp2IlInjected.Token(Token = "0x170000AF")]
		public static Func<IAPEOEACMJI> OEPPFNKCEGP
		{
			[Cpp2IlInjected.Token(Token = "0x60003BA")]
			[Cpp2IlInjected.Address(RVA = "0x7F67A10", Offset = "0x7F66610", VA = "0x187F67A10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003BB")]
			[Cpp2IlInjected.Address(RVA = "0x7F68050", Offset = "0x7F66C50", VA = "0x187F68050")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B0")]
		public bool DOKGGLNJAIG
		{
			[Cpp2IlInjected.Token(Token = "0x60003BC")]
			[Cpp2IlInjected.Address(RVA = "0x7F67B70", Offset = "0x7F66770", VA = "0x187F67B70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B1")]
		public bool CCEFOEPHCME
		{
			[Cpp2IlInjected.Token(Token = "0x60003BD")]
			[Cpp2IlInjected.Address(RVA = "0x7F67A60", Offset = "0x7F66660", VA = "0x187F67A60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B2")]
		public PlayerAvatarDisplayBase JLCBIDDGHHF
		{
			[Cpp2IlInjected.Token(Token = "0x60003BF")]
			[Cpp2IlInjected.Address(RVA = "0xBB96F0", Offset = "0xBB82F0", VA = "0x180BB96F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B3")]
		protected static Guid MDHCPKCMFHI
		{
			[Cpp2IlInjected.Token(Token = "0x60003C0")]
			[Cpp2IlInjected.Address(RVA = "0x7F64DA0", Offset = "0x7F639A0", VA = "0x187F64DA0")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B4")]
		public (GameObject, FMEODGEFBMO)[] ELNHLNLJPMB
		{
			[Cpp2IlInjected.Token(Token = "0x60003D6")]
			[Cpp2IlInjected.Address(RVA = "0x7F67C80", Offset = "0x7F66880", VA = "0x187F67C80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x7F65740", Offset = "0x7F64340", VA = "0x187F65740")]
		[ContextMenu("Refresh Avatar")]
		private void RebuildTestAvatarContextMenu()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x7F638A0", Offset = "0x7F624A0", VA = "0x187F638A0")]
		private IEnumerable<GameObject> COOEMFBLLDO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x7F65C10", Offset = "0x7F64810", VA = "0x187F65C10")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x7F63710", Offset = "0x7F62310", VA = "0x187F63710")]
		private void CEEIJLOACGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x148F1E0", Offset = "0x148DDE0", VA = "0x18148F1E0")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x7F64430", Offset = "0x7F63030", VA = "0x187F64430")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x7F65C20", Offset = "0x7F64820", VA = "0x187F65C20")]
		public void Teardown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x7F65A30", Offset = "0x7F64630", VA = "0x187F65A30")]
		public void ShowPose(AnimationClip DLDHFIENAGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x7F65BE0", Offset = "0x7F647E0", VA = "0x187F65BE0")]
		public void ShowPose(string FFOOGIIIDLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x7F65890", Offset = "0x7F64490", VA = "0x187F65890")]
		public void ResetPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x7F65750", Offset = "0x7F64350", VA = "0x187F65750")]
		public void ResetHandPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x7F666F0", Offset = "0x7F652F0", VA = "0x187F666F0")]
		public void UpdateHandAnimation()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x7F66540", Offset = "0x7F65140", VA = "0x187F66540")]
		public void UpdateFaceAndBodyShapes(bool PIGLABJPCAC = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x7F66AF0", Offset = "0x7F656F0", VA = "0x187F66AF0")]
		public void UpdateNoseShape(OMJMBFKGAHG AIAONFGMGDB, bool PIGLABJPCAC = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x7F66AC0", Offset = "0x7F656C0", VA = "0x187F66AC0")]
		public void UpdateLODOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x7F64F20", Offset = "0x7F63B20", VA = "0x187F64F20", Slot = "4")]
		protected virtual void OBDPIMEADMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x7F64B30", Offset = "0x7F63730", VA = "0x187F64B30", Slot = "5")]
		protected virtual void JBKKLDDEOAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x7F62C70", Offset = "0x7F61870", VA = "0x187F62C70")]
		public void ApplyHatData(AdditionalHatData PPNAIDDEOON, bool GMDEJLPPJAH = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x7F62AB0", Offset = "0x7F616B0", VA = "0x187F62AB0")]
		public void ApplyHatAdjustmentsToHatAnchorParams()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x7F62FD0", Offset = "0x7F61BD0", VA = "0x187F62FD0")]
		public void ApplyHatUVOverride(Vector2 HGNLIPLJGMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x7F62EF0", Offset = "0x7F61AF0", VA = "0x187F62EF0")]
		public void ApplyHatPositionAdjustment(Vector3 AKNBINOCBMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x7F62F60", Offset = "0x7F61B60", VA = "0x187F62F60")]
		public void ApplyHatRotationAdjustment(Vector3 FKFMCBICMIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x7F63040", Offset = "0x7F61C40", VA = "0x187F63040")]
		public OPKKBLJLHPN BuildAvatarItemSelection(GameObject KGKNJFAJPCP, ADAOAPJGFHC KLJENMLFIKH, FMEODGEFBMO APECMGHDCNK)
		{
			return default(OPKKBLJLHPN);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x7F630E0", Offset = "0x7F61CE0", VA = "0x187F630E0")]
		public void BuildAvatar(bool PIGLABJPCAC = false, bool GMDEJLPPJAH = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x7F65F80", Offset = "0x7F64B80", VA = "0x187F65F80")]
		public void UpdateColors()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x7F62BF0", Offset = "0x7F617F0", VA = "0x187F62BF0")]
		public void ApplyHatAnchor()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x7F66910", Offset = "0x7F65510", VA = "0x187F66910")]
		public void UpdateHatAnchor(bool GMDEJLPPJAH = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x7F66640", Offset = "0x7F65240", VA = "0x187F66640")]
		[AsyncStateMachine(typeof(GIICNAAAEJJ))]
		public void UpdateFaceFeatures()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x7F64000", Offset = "0x7F62C00", VA = "0x187F64000")]
		[AsyncStateMachine(typeof(BALJDCNMFCK))]
		private Task DDBIALGJEHH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x7F63D30", Offset = "0x7F62930", VA = "0x187F63D30")]
		private void DBJPAIAMMAC(FaceFeatureType ECOBAHJDEJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x7F64E90", Offset = "0x7F63A90", VA = "0x187F64E90")]
		private void KMNAMFJLMJL(FaceFeatureType ECOBAHJDEJN, [Out] float GAJLLNLBHEJ, [Out] float AGMDNCCGMDD, [Out] float ECJMFFOLCCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x7F66400", Offset = "0x7F65000", VA = "0x187F66400")]
		public void UpdateEmote()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x7F667A0", Offset = "0x7F653A0", VA = "0x187F667A0")]
		public void UpdateHandPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x7F65220", Offset = "0x7F63E20", VA = "0x187F65220")]
		private void OMBGNOECFIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020")]
		private void POFEBKPJMBC(OBOPCOPCCAH BFAKLNDJFBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020")]
		private void DDPPLHLEGPF(OBOPCOPCCAH BFAKLNDJFBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x7F640D0", Offset = "0x7F62CD0", VA = "0x187F640D0")]
		private void HOEJLNKNHJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x7F66B80", Offset = "0x7F65780", VA = "0x187F66B80")]
		public PlayerModernBodyEditorAvatarValidator()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E7")]
		[Cpp2IlInjected.Address(RVA = "0x7F637F0", Offset = "0x7F623F0", VA = "0x187F637F0")]
		[CompilerGenerated]
		private OPKKBLJLHPN CGHFAAPLMHM((GameObject, FMEODGEFBMO) FFCPPMJAHBH)
		{
			return default(OPKKBLJLHPN);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	public class SkinnedMeshBonesInspector : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000503")]
		[SerializeField]
		[IODJOKMKDII(AFILHNGOOLF.Self, false, false, false)]
		private SkinnedMeshRenderer skinnedMeshRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000504")]
		[SerializeField]
		private int BoneWeightsDisplayStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000505")]
		[SerializeField]
		private int BoneWeightsDisplayAmount;

		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0xA5E010", Offset = "0xA5CC10", VA = "0x180A5E010")]
		public SkinnedMeshBonesInspector()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public struct OPKKBLJLHPN
{
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[CompilerGenerated]
	private sealed class IEPBDBCMJDI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000508")]
		public IEnumerable<OutfitType> otherOutfitTypes;

		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public IEPBDBCMJDI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(RVA = "0x7F569B0", Offset = "0x7F555B0", VA = "0x187F569B0")]
		internal bool MFMALFBFFCP(OutfitType outfitType)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000506")]
	private OBOPCOPCCAH MOEDDMPPFBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000507")]
	private FMEODGEFBMO KJLKMHBKPOJ;

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public OBOPCOPCCAH BJIIKPBAPDG
	{
		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0xAF3D70", Offset = "0xAF2970", VA = "0x180AF3D70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public FMEODGEFBMO OABIFIEMPAN
	{
		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0xE4EA70", Offset = "0xE4D670", VA = "0x180E4EA70")]
		get
		{
			return default(FMEODGEFBMO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public string GKEADFCHBNL
	{
		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0x7F5BE90", Offset = "0x7F5AA90", VA = "0x187F5BE90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public bool JIABHMKFODA
	{
		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0x7F5BF80", Offset = "0x7F5AB80", VA = "0x187F5BF80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public bool PFLPAMPBEDL
	{
		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x7F5BB80", Offset = "0x7F5A780", VA = "0x187F5BB80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x19E6500", Offset = "0x19E5100", VA = "0x1819E6500")]
	public OPKKBLJLHPN(OBOPCOPCCAH BFAKLNDJFBH, FMEODGEFBMO DAMAHFKHDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x7F5BBD0", Offset = "0x7F5A7D0", VA = "0x187F5BBD0")]
	public bool BJADEJGAACC(OutfitType ANMIHPHLJMJ, FMEODGEFBMO LJJLBOBEHBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x7F5BFD0", Offset = "0x7F5ABD0", VA = "0x187F5BFD0")]
	public bool NNEILNJEBBI(OutfitType ANMIHPHLJMJ, FMEODGEFBMO LJJLBOBEHBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(RVA = "0x7F5BCA0", Offset = "0x7F5A8A0", VA = "0x187F5BCA0")]
	public bool DLDBAJPPMGH(OPKKBLJLHPN KNPOHOKDBEA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public class FMLLAGDOMHP
{
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	[CompilerGenerated]
	private sealed class OJCMLIJNPLC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400050D")]
		public IEnumerable<OutfitType> otherOutfitTypes;

		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public OJCMLIJNPLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x7F5BB00", Offset = "0x7F5A700", VA = "0x187F5BB00")]
		internal bool MFMALFBFFCP(OutfitType outfitType)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000509")]
	private OBOPCOPCCAH MOEDDMPPFBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400050A")]
	private MMLMAHNDNOJ KJLKMHBKPOJ;

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public OBOPCOPCCAH BJIIKPBAPDG
	{
		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(RVA = "0xA5B540", Offset = "0xA5A140", VA = "0x180A5B540")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public MMLMAHNDNOJ OABIFIEMPAN
	{
		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0xAB4C80", Offset = "0xAB3880", VA = "0x180AB4C80")]
		get
		{
			return default(MMLMAHNDNOJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public Color MEHMDJKIAJL
	{
		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0xE27AC0", Offset = "0xE266C0", VA = "0x180E27AC0")]
		[CompilerGenerated]
		get
		{
			return default(Color);
		}
		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0xE27940", Offset = "0xE26540", VA = "0x180E27940")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public Vector3 EFKBKJCNDBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0xE40DF0", Offset = "0xE3F9F0", VA = "0x180E40DF0")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0xE40F30", Offset = "0xE3FB30", VA = "0x180E40F30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x7F54EA0", Offset = "0x7F53AA0", VA = "0x187F54EA0")]
	public FMLLAGDOMHP(OBOPCOPCCAH BFAKLNDJFBH, MMLMAHNDNOJ DAMAHFKHDCF, Color MGBNCENPLKH, Vector3 DINDLKHALMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x7F54D70", Offset = "0x7F53970", VA = "0x187F54D70")]
	public bool DLDBAJPPMGH(FMLLAGDOMHP KNPOHOKDBEA)
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
