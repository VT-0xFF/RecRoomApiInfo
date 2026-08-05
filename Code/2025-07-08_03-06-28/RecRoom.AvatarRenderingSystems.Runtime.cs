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
	public class LogRegistrationIndex : LLMIPJJKGHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7EE7FC0", Offset = "0x7EE6DC0", VA = "0x187EE7FC0", Slot = "4")]
		public override void HIMDKAKGPHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA82AE0", Offset = "0xA818E0", VA = "0x180A82AE0")]
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
			[Cpp2IlInjected.Address(RVA = "0xA5C4F0", Offset = "0xA5B2F0", VA = "0x180A5C4F0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override string AssetGUID
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x7EF7B70", Offset = "0x7EF6970", VA = "0x187EF7B70", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7EF7B00", Offset = "0x7EF6900", VA = "0x187EF7B00", Slot = "17")]
		public override bool RuntimeKeyIsValid()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7EF7B30", Offset = "0x7EF6930", VA = "0x187EF7B30")]
		public RecNetCDNAssetReference(RecNetCDNKey MAHBBBBCDEL)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class RecNetCDNKey
	{
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public enum KHIKFGMIOOM : byte
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
			[Cpp2IlInjected.Address(RVA = "0xA598A0", Offset = "0xA586A0", VA = "0x180A598A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xA59840", Offset = "0xA58640", VA = "0x180A59840")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public string UniqueItemIdentifier
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xA59870", Offset = "0xA58670", VA = "0x180A59870")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xA595A0", Offset = "0xA583A0", VA = "0x180A595A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public string CacheHash
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xA59860", Offset = "0xA58660", VA = "0x180A59860")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xA595B0", Offset = "0xA583B0", VA = "0x180A595B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RecNetCDNKey Dependency
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0xA59880", Offset = "0xA58680", VA = "0x180A59880")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0xA59830", Offset = "0xA58630", VA = "0x180A59830")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool AttemptPrecacheLookup
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xA86430", Offset = "0xA85230", VA = "0x180A86430")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xA861B0", Offset = "0xA84FB0", VA = "0x180A861B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public KHIKFGMIOOM PathHint
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xEEFDA0", Offset = "0xEEEBA0", VA = "0x180EEFDA0")]
			[CompilerGenerated]
			get
			{
				return default(KHIKFGMIOOM);
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x15145F0", Offset = "0x15133F0", VA = "0x1815145F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string ItemPath
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x7EF7C80", Offset = "0x7EF6A80", VA = "0x187EF7C80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7EF7C00", Offset = "0x7EF6A00", VA = "0x187EF7C00")]
		public static RecNetCDNKey NENMIKBPEEN(string GFJGMJDICBJ, KHIKFGMIOOM JFFEHNDNFAO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7EF7BB0", Offset = "0x7EF69B0", VA = "0x187EF7BB0")]
		public void BKLAEFCKONI(string CFFNDIIMMOA, string MOOBNHLGDMK, bool MOKAGFJGPAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public RecNetCDNKey()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[HCBEFNLCJPF]
public class MIHBGKMEGME : MDMGFDPOPNC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	protected readonly List<Mesh> KIGABCAOLNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	protected readonly List<byte[]> FKHNHOMCGDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	protected readonly List<Matrix4x4> DBLHLLJADEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	protected readonly List<bool> AEIMMGHPAIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	protected readonly List<long> IOPCLHMKDGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	protected readonly List<bool> LJHBCCOIFHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	protected readonly List<int> NDNNGKFHFFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	protected Allocator BCLHFFJENEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	protected JPLNFBHFPMI PANLJECLEOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	protected byte DALIOMNGFJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	protected IList<int> LACGIBBEJKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	protected IList<int> CHPIBPDELFA;

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7EE8090", Offset = "0x7EE6E90", VA = "0x187EE8090", Slot = "4")]
	public void BDONGONABHC(Mesh JLPONKINLEO, Matrix4x4 OEJBOPLGCGK, byte[] PKOGGKHKMCH, bool KNJDCHCMDMA = false, KIECLADILAP.NMBEIOMGMML BOCHMGMBKKO = (KIECLADILAP.NMBEIOMGMML)0L, int LEKJKGJFHHP = -1, bool FHDMKCNLHAF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7EE8050", Offset = "0x7EE6E50", VA = "0x187EE8050", Slot = "5")]
	public void ALFBPEOLLOC(Allocator DFGMDNGNOEN, JPLNFBHFPMI NGKCAGOOJBA, byte ENKJEANPOIA, [Optional] IList<int> FFIMIPGOEJB, [Optional] IList<int> AEJKLDOFPKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7EE83C0", Offset = "0x7EE71C0", VA = "0x187EE83C0")]
	private static void BFFGDGALHPG(Mesh JLPONKINLEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7EE8620", Offset = "0x7EE7420", VA = "0x187EE8620")]
	public MIHBGKMEGME()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[HCBEFNLCJPF]
public struct NDJKKMGHPNN : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	[ReadOnly]
	public HKDBMFAJEIG PHIDGLACEEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	[ReadOnly]
	public int CDGBEFDIKFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public CEKEJAPNDBE PPJFMEHOHBP;

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7EE8870", Offset = "0x7EE7670", VA = "0x187EE8870", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[HCBEFNLCJPF]
[NativeContainer]
public struct CEKEJAPNDBE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct FPDJBGCPHBL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public Vector3 PJCDAJEPDJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public Vector3 LCJFLGICHDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public Vector4 EGEHAJPAGFC;
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct GHHMPDHMGAG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public float CCHOBFODGCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public float FAPCBIHEPDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public float HOJCCNBLIJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public float MNGBODPIFOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public byte OGGNKOHMBEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public byte JMKEGFHJBOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public byte GMEGIMIIONL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public byte KHEAIOKECDB;
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct CNONLIHPFNK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public half CCHOBFODGCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public half FAPCBIHEPDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public half HOJCCNBLIJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public half MNGBODPIFOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public byte OGGNKOHMBEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public byte JMKEGFHJBOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public byte GMEGIMIIONL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public byte KHEAIOKECDB;
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct JOGAHCKLELE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public half4 PFKMCINIKNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public half2 JDEBHEHLKJE;
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public struct GBJCOHLMMPH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public half4 PFKMCINIKNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public half2 JDEBHEHLKJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public half2 OHGFAIANIEL;
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct HLNAAGJDDML
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public half4 PFKMCINIKNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public half2 JDEBHEHLKJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public half2 OHGFAIANIEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public half2 BLEIEAAPGII;
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public struct GBMJEHMBALE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public half4 PFKMCINIKNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public half2 JDEBHEHLKJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public half2 OHGFAIANIEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public half2 BLEIEAAPGII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public half2 KJBPJBAMCCG;
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public struct PGCFLICGMIG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public float CCHOBFODGCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public float FAPCBIHEPDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public float HOJCCNBLIJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public float MNGBODPIFOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public int OGGNKOHMBEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public int JMKEGFHJBOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public int GMEGIMIIONL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public int KHEAIOKECDB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public struct EFMGPALBHGB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public Color PFKMCINIKNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public Vector2 JDEBHEHLKJE;
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public struct OIPFMADOHMO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public Color PFKMCINIKNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public Vector2 JDEBHEHLKJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public Vector2 OHGFAIANIEL;
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public struct IDKLIIANCBG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Color PFKMCINIKNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public Vector2 JDEBHEHLKJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public Vector2 OHGFAIANIEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Vector2 BLEIEAAPGII;
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public struct BPMKLBEFFIE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public Color PFKMCINIKNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public Vector2 JDEBHEHLKJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public Vector2 OHGFAIANIEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public Vector2 BLEIEAAPGII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public Vector2 KJBPJBAMCCG;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private bool OLGGAFAKCMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public NativeArray<FPDJBGCPHBL> IDGPIKELJHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public NativeArray<JOGAHCKLELE> FNJHJBBDCKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public NativeArray<GBJCOHLMMPH> BBKPAFOFNKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public NativeArray<HLNAAGJDDML> LCEHNCLEJFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public NativeArray<GBMJEHMBALE> ICCFDBOBANE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public NativeArray<CNONLIHPFNK> AGFPIGBCMNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public NativeArray<GHHMPDHMGAG> AEEDJMCFBKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public NativeArray<EFMGPALBHGB> FKKDDICOKJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public NativeArray<OIPFMADOHMO> JFLEHOPDOHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public NativeArray<IDKLIIANCBG> NNMAHAKMJNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public NativeArray<BPMKLBEFFIE> LCJMMJFIDAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public NativeArray<PGCFLICGMIG> JHHADMBFGIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public NativeArray<int> KHMKOGLJMLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public NativeArray<int> LMFHFAMPMGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private NativeArray<int> CKJFPHCPHFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private NativeArray<int> OIEGIIHEOCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public NativeArray<int> LDEKPNMIPJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public NativeArray<int> JBNIDJHOAAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public NativeArray<int> NEPIDEFJLHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public NativeArray<BoneWeight> PECGHNGHBGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private NativeArray<int> OAEBFAAHGEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private bool JFGADDECIEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x159")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private bool KHGNHKGFOLO;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int ILCABFAPDIH
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x7EE3030", Offset = "0x7EE1E30", VA = "0x187EE3030")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x7EE36C0", Offset = "0x7EE24C0", VA = "0x187EE36C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int FIFMKNKNKDE
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7EE4AF0", Offset = "0x7EE38F0", VA = "0x187EE4AF0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7EE52D0", Offset = "0x7EE40D0", VA = "0x187EE52D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int GAJCFJMJJJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7EE52C0", Offset = "0x7EE40C0", VA = "0x187EE52C0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7EE4AE0", Offset = "0x7EE38E0", VA = "0x187EE4AE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int DPLPIJBGBJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7EE3650", Offset = "0x7EE2450", VA = "0x187EE3650")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7EE52E0", Offset = "0x7EE40E0", VA = "0x187EE52E0")]
	public CEKEJAPNDBE(int JHMCDMNLPNI, int CMEIMLDBIIB, int HPEFGPDPNPK, int BOPLBCKBBFH, Allocator DFGMDNGNOEN, int KMFHDAKIFNC, IJDOMGFLBLA LIFEJGLLGPN, bool JFGADDECIEC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7EE4E30", Offset = "0x7EE3C30", VA = "0x187EE4E30")]
	public void MDPCGJABOIK(int CKFKPOAGPKN, Vector3 FPJNLHKNPEA, Vector3 GAHCIOCKFAM, Vector4 ODOKMLFIJNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7EE36D0", Offset = "0x7EE24D0", VA = "0x187EE36D0")]
	public void IGKFOBCHDMC(int CKFKPOAGPKN, BoneWeight DOMEONCHNBA, NativeSlice<byte> PKOGGKHKMCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7EE4B00", Offset = "0x7EE3900", VA = "0x187EE4B00")]
	public Color LIMDACHDKJO(int CKFKPOAGPKN)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7EE4EC0", Offset = "0x7EE3CC0", VA = "0x187EE4EC0")]
	public void NIBAFIDCGMI(int CKFKPOAGPKN, Color BEIDDJJHBIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7EE3040", Offset = "0x7EE1E40", VA = "0x187EE3040")]
	public void BJMHJGCOMHJ(byte CCCHHIFANKH, int CKFKPOAGPKN, Vector2 GKPNMBGMLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7EE3B00", Offset = "0x7EE2900", VA = "0x187EE3B00")]
	public void ILBGNNFKNFM(int CKFKPOAGPKN, int DBKHFGOBDLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7EE4A80", Offset = "0x7EE3880", VA = "0x187EE4A80")]
	public bool KJGEPECNDDC(int CCCHHIFANKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7EE49B0", Offset = "0x7EE37B0", VA = "0x187EE49B0")]
	public void JPPAMHCCIKF(int FGHFHPDFCBF, int DOBKAGHAEBK, int IDFEOHMGIAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7EE33F0", Offset = "0x7EE21F0", VA = "0x187EE33F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7EE3B10", Offset = "0x7EE2910", VA = "0x187EE3B10")]
	public Mesh JDFMHAGBLPC([Optional] string IMNHKJGLBPK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[DefaultMember("Item")]
[NativeContainer]
[HCBEFNLCJPF]
public struct HKDBMFAJEIG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public Mesh.MeshDataArray LKPKMHIDIEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public NativeArray<int> IKHKMMAPBJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public NativeArray<int> FMCIIJCKKOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public NativeArray<BoneWeight> PECGHNGHBGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private NativeArray<Matrix4x4> GPBIFEAIEGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private NativeArray<long> ABDLDLPKGOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private NativeArray<byte> BIOHBHEMEOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private NativeArray<int> EGNOOGIPDGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private NativeArray<int> HJJEGOEMBIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public NativeArray<sbyte> ILLHJCIKLNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public NativeArray<byte> FHEEHIIKJAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public NativeArray<bool> FHDMKCNLHAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public NativeArray<int> LEKJKGJFHHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private bool JFGADDECIEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private NativeArray<int> PPJIEIMHMMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private bool KHGNHKGFOLO;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int BBEKONJHCLC
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x7EE66D0", Offset = "0x7EE54D0", VA = "0x187EE66D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int ALLOFGBEMMM
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x7EE6680", Offset = "0x7EE5480", VA = "0x187EE6680")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int KLDJHGHGOKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7EE61B0", Offset = "0x7EE4FB0", VA = "0x187EE61B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int EEHPJFMDFGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x7EE66B0", Offset = "0x7EE54B0", VA = "0x187EE66B0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x7EE6660", Offset = "0x7EE5460", VA = "0x187EE6660")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int ILCABFAPDIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x7EE6190", Offset = "0x7EE4F90", VA = "0x187EE6190")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7EE6670", Offset = "0x7EE5470", VA = "0x187EE6670")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public int GHPNJIGMGKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7EE66A0", Offset = "0x7EE54A0", VA = "0x187EE66A0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7EE61A0", Offset = "0x7EE4FA0", VA = "0x187EE61A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public JPLNFBHFPMI GHECPCPPHBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7EE66C0", Offset = "0x7EE54C0", VA = "0x187EE66C0")]
		get
		{
			return default(JPLNFBHFPMI);
		}
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7EE66E0", Offset = "0x7EE54E0", VA = "0x187EE66E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public byte PJDPMHHGEIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7EE6690", Offset = "0x7EE5490", VA = "0x187EE6690")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7EE6280", Offset = "0x7EE5080", VA = "0x187EE6280")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public ICKPDIJNCDI CBMLGEIEAGG
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7EE6410", Offset = "0x7EE5210", VA = "0x187EE6410")]
		get
		{
			return default(ICKPDIJNCDI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7EE67C0", Offset = "0x7EE55C0", VA = "0x187EE67C0")]
	public HKDBMFAJEIG(IList<Mesh> KNNKEBBLJNP, IList<Matrix4x4> PDPACKOPBOL, IList<bool> FHDMKCNLHAF, byte ENKJEANPOIA, IList<byte[]> FGFICCENOCC, IList<long> PCDJIFICMOG, IList<bool> OKKGKPPCDFC, IList<int> LEKJKGJFHHP, IList<int> FFIMIPGOEJB, IList<int> OIBABHDMFJE, Allocator DFGMDNGNOEN, JPLNFBHFPMI NGKCAGOOJBA, bool JFGADDECIEC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7EE66F0", Offset = "0x7EE54F0", VA = "0x187EE66F0")]
	public CEKEJAPNDBE OJGFCBPPEEF(Allocator DFGMDNGNOEN, IJDOMGFLBLA LIFEJGLLGPN)
	{
		return default(CEKEJAPNDBE);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7EE6290", Offset = "0x7EE5090", VA = "0x187EE6290", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[HCBEFNLCJPF]
public class LABHBLGJECH : MIHBGKMEGME
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public bool AMJHKNCLIFG;

	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private static readonly ProfilerMarker MMCIABJDOAD;

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x7EE7CF0", Offset = "0x7EE6AF0", VA = "0x187EE7CF0")]
	public HKDBMFAJEIG GGNLBLMBGOH()
	{
		return default(HKDBMFAJEIG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7EE7FB0", Offset = "0x7EE6DB0", VA = "0x187EE7FB0")]
	public LABHBLGJECH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct ICKPDIJNCDI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public Mesh.MeshData BKKKJJKOPNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public NativeSlice<BoneWeight> PECGHNGHBGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public NativeSlice<byte> NFJBJHKJHEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public int EPAOIMKNIBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public Matrix4x4 GIHIPNEKFNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public long ODNPBLLKCJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public NativeSlice<byte> PKOGGKHKMCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public bool ONPEIMNCJPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public int JDJIOMGBIKA;
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class PGNJDNMGAEC : DKKDNHKBJLF
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class KCPEFNMMGGD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public bool hideTorsoInFirstPersonBeanMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public PGNJDNMGAEC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public IHGBKKPAEJC buildMeshPromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public Action<KeyValuePair<string, NONKHMPPJIB<Texture2D>>> <>9__19;

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public KCPEFNMMGGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x7EE7A90", Offset = "0x7EE6890", VA = "0x187EE7A90")]
		internal bool AGMEFPBJDIK(MAJDLGCOKCC item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x7EE7C10", Offset = "0x7EE6A10", VA = "0x187EE7C10")]
		internal void NKGLHGEKAJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x7EE7B90", Offset = "0x7EE6990", VA = "0x187EE7B90")]
		internal void OJCGHAJGOMJ(string err)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x7EE7C10", Offset = "0x7EE6A10", VA = "0x187EE7C10")]
		internal void LPNKIBGCPGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x7EE7B90", Offset = "0x7EE6990", VA = "0x187EE7B90")]
		internal void BLBCIAHNMAO(string err)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x7EE7BE0", Offset = "0x7EE69E0", VA = "0x187EE7BE0")]
		internal void JPCDBHBIGKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x7EE7BB0", Offset = "0x7EE69B0", VA = "0x187EE7BB0")]
		internal void IALOJCNKAAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x7EE7AD0", Offset = "0x7EE68D0", VA = "0x187EE7AD0")]
		internal void BBCEJFFGDAJ(Dictionary<string, NONKHMPPJIB<Texture2D>> resourceHandleDictionary)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x7EE7C30", Offset = "0x7EE6A30", VA = "0x187EE7C30")]
		internal void PMIBDBIONNJ(KeyValuePair<string, NONKHMPPJIB<Texture2D>> kvp)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0xA59860", Offset = "0xA58660", VA = "0x180A59860")]
		internal IDGEJBLICGP KMLGGNPPLED()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class JKKAEKEGHEG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public int lowestPossibleLOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public KCPEFNMMGGD CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public JKKAEKEGHEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x7EE7990", Offset = "0x7EE6790", VA = "0x187EE7990")]
		internal LICBNCEOIEB LFGEGDGGFCG(int lod)
		{
			return default(LICBNCEOIEB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class HCIIPNDAEMN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public CEBCBDBEPBJ<Dictionary<string, NONKHMPPJIB<Texture2D>>> ugcTextureDictionaryPromise;

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public HCIIPNDAEMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0xA598A0", Offset = "0xA586A0", VA = "0x180A598A0")]
		internal CEBCBDBEPBJ<Dictionary<string, NONKHMPPJIB<Texture2D>>> PIMDOPMMLMB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class FMIHELOOLFL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public List<IHGBKKPAEJC> innerPromises;

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public FMIHELOOLFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x7EE6060", Offset = "0x7EE4E60", VA = "0x187EE6060")]
		internal void MFKFMKDFAKO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class EBKMOJEPBFA : IEnumerator<DMCHEKCEBGH>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private DMCHEKCEBGH <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public bool shouldWait;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public PGNJDNMGAEC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public List<CEGDNHLGNGK> parts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public List<IHGBKKPAEJC> innerPromises;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public int[] LODs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public bool isFirstPerson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public Func<int, LICBNCEOIEB> getLayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public CNNGGNNJEPE materialPropertyBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public Material materialInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private int <lodIndex>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		private DMCHEKCEBGH System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0xA59870", Offset = "0xA58670", VA = "0x180A59870", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0xA59870", Offset = "0xA58670", VA = "0x180A59870", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0xA5BF60", Offset = "0xA5AD60", VA = "0x180A5BF60")]
		[DebuggerHidden]
		public EBKMOJEPBFA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x7EE5D10", Offset = "0x7EE4B10", VA = "0x187EE5D10", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x7EE5F90", Offset = "0x7EE4D90", VA = "0x187EE5F90", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class OJFMPKPNPGH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public GCGKOGCLEFA cancelable;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public OJFMPKPNPGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0xB99BF0", Offset = "0xB989F0", VA = "0x180B99BF0")]
		internal void APFEDIKPPPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0xE07730", Offset = "0xE06530", VA = "0x180E07730")]
		internal void BCDEJDMKIOK(string err)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class FCIKOKEABFJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public long jobComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public Stopwatch stopwatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public SkinnedMeshRenderer lodRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public long meshComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public string meshName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public long meshCopyComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public PGNJDNMGAEC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public int lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public List<Material> newUniqueMaterials;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public int frameStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public long lodBuildStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public long startCombineBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public long jobScheduled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public Action onFinally;

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public FCIKOKEABFJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class CDOHFAMMBHN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public bool waitingForComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public JobHandle lodBuildJobHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public CEKEJAPNDBE defaultMeshJobContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public HKDBMFAJEIG defaultAvatarMeshJobGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public FCIKOKEABFJ CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public CDOHFAMMBHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x7EE2DF0", Offset = "0x7EE1BF0", VA = "0x187EE2DF0")]
		internal void GNEDOMIIMED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x145F110", Offset = "0x145DF10", VA = "0x18145F110")]
		internal void DHBANNLHKBG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class OLKKHGHDBGN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public bool waitingForComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public JobHandle lodBuildJobHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public MMEOPEHJNGC legacyMeshJobContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public FKCKGJNGFHL legacyAvatarMeshJobGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public FCIKOKEABFJ CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public OLKKHGHDBGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x7EEA330", Offset = "0x7EE9130", VA = "0x187EEA330")]
		internal void LCOCLDKKBCN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x145D8B0", Offset = "0x145C6B0", VA = "0x18145D8B0")]
		internal void OEGPPCFFJKL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class JMAGBKFJLFH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public PGNJDNMGAEC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public float power;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public Color color;

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public JMAGBKFJLFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x7EE7A50", Offset = "0x7EE6850", VA = "0x187EE7A50")]
		internal void GOHFDHMMEOF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class EPLMLAOBMEC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public string overrideItemIdentifier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public EEPOCEICAIB overrideBodyPart;

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public EPLMLAOBMEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x7EE5FE0", Offset = "0x7EE4DE0", VA = "0x187EE5FE0")]
		internal bool MHAKALHECLB(KeyValuePair<string, MAJDLGCOKCC> entry)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly EPBKGABEMJJ LFKPBCDABHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly EPBKGABEMJJ BPJALDMLHEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private Dictionary<BLODKKHJEPD, float> FKPLEGACIPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private Dictionary<KFIOGNHKBDM, float> DACHKIBBNGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private Dictionary<MMHOGHLBOGJ, float> LLBDEOGBEIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private IReadOnlyDictionary<string, HDCLNPHPCJG> HAHHGMBFJNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private Dictionary<string, HDCLNPHPCJG> CPDGPKKJBGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private Dictionary<string, HDCLNPHPCJG> FPKHBCHBCML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private Dictionary<string, HDCLNPHPCJG> KFJJCODEALD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private JBOCHFILNBO JIIJCPBBHDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private JBOCHFILNBO GANHHAJJLGJ;

	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private static float LEECKFBHEAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private bool? FCFMODADFDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x62")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private bool? PBCOCCEOMOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private bool? NIBGMBKPIAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x66")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private bool? BEDIHKAMLKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private AvatarConfiguration IHJCHHDOCMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private Transform FEFEJOAHMPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private AvatarSkinAssetItem PJCFEPGPFJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private AssetReference HDKAAIMGIHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private GameObject JHIJGABKGKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private GameObject AKLPIDPCACP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private SkinnedMeshRenderer IGHKKEHPAHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private AvatarSkinnedMeshBoneOrderRemapsData OFEANOFHNDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private Transform[] IMHHMNAGIGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private Matrix4x4[] CNNNNDPEMBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private Material DCBEPMLPIBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private Material BMPJBMEKCLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private Material DEFLAPHCMGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private Material EDEOOMJPMKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private Shader HNFNLHPEDLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private Shader DKGJBLAOING;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private Animator HACLODKOPJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private Renderer[] DNGBBEAEGOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private KIECLADILAP.NMBEIOMGMML DKHHPFAPMJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private AvatarBodyPartShapesManager KEICOMNIJEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private IReadOnlyDictionary<string, Transform> MLJBMLEOLKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private AvatarFaceShapeData.OKAOPGEJICN GGDHIOJLOKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x114")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private AvatarBodyShapeData.LMFFFLIEJEF LCBGDGCNEHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private BDLLACEJLDO CCONDIOGMKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private bool JPFCCPNHANG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11D")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private bool EHHBJDPLJNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private Color GCEEOKMONFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private Color AMGMCKECJLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private Color JHFDIICPGHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private Color? CGIKJIJDNLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x164")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private Color? DKHAEHJONPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private Color? EJIJKOENOKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18C")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private Color? FCBCILDNNBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private Texture2D BLKPAJPCDEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private Texture2D JGAPCAKAMPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	[CanBeNull]
	private MAJDLGCOKCC MAJBLPEOINM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private Texture MCBOBNGOFOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private Color FNPDJKFEFIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public Dictionary<Renderer, CNNGGNNJEPE> DFOIKHKLPOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private Dictionary<Renderer, CNNGGNNJEPE> AFOEFOFFGDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private Dictionary<string, List<GNMIHPNAIAL>> HHDLAAOKLGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private Dictionary<string, List<GNMIHPNAIAL>> KLJIHNGDDAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private readonly List<ECOKJONDNDB> GDKBLIPJMIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private readonly List<ECOKJONDNDB> KLENMBEOGON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private readonly List<ECOKJONDNDB> JDOJACCHJHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private readonly List<ECOKJONDNDB> NMFDDEHLDBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private Dictionary<GNMIHPNAIAL, Material> BEPAPMGIMND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private Dictionary<GNMIHPNAIAL, Material> MLJDLHIJLNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private SkinnedMeshRenderer[] EEIPELDFKAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private SkinnedMeshRenderer[] FOBNICGAPEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private SkinnedMeshRenderer[] BOFBPDKCEBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private SkinnedMeshRenderer[] KNLGJBODNKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private readonly Dictionary<string, NONKHMPPJIB<Texture2D>> OBPEJDLDLBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private readonly Dictionary<string, NONKHMPPJIB<Texture2D>> CBABDACJGLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private AdditionalHatData DEKODPOFNJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private AdditionalHatData LCPALHJECAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private HairData EFILIJONGIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private HairData IPOMGEGGPAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private BHJLPMKOMMK DJAGEHLBGAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private bool? PJOMLJCLDLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x27C")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private PositionAndRotation FKBNPDFMNEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private Transform CDAPABPDAGM;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private Material GCBCKJLECLE;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private Material EKNPHBDLGIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B0")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private Dictionary<string, MAJDLGCOKCC> KEIPBEFJBCO;

	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private static readonly int IKENIBBOKMD;

	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private static readonly int LLJAIMAADBC;

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private static readonly int HEKOLIKFFED;

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private static readonly int HGODPNENMOD;

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private static readonly int EABOFCKFFBA;

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private static readonly int MNLOBDIKBIC;

	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private static readonly int HAKPAIODNFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B8")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private bool ECGNOOOEDCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C0")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private List<Action> IBKJPOBGBFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private KMFBMBBKEMD NJAIGFFIIOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D0")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private SkinnedMeshRenderer[] OFNFKOABEMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D8")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private int MMDMFCKHDJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2DC")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private bool PIHHOAPOIIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E0")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private int BLMFDPOPNDF;

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public EPBKGABEMJJ JMEIKAKMDNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xA598A0", Offset = "0xA586A0", VA = "0x180A598A0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public EPBKGABEMJJ CFBPOLEEEMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0xA59870", Offset = "0xA58670", VA = "0x180A59870", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private EILEDNOBBBM BMDDNKKDAIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7EED390", Offset = "0x7EEC190", VA = "0x187EED390")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	private bool EMNPNNEMCDL
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x7EEB9A0", Offset = "0x7EEA7A0", VA = "0x187EEB9A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	private bool JFLECLDPCOO
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7EED0C0", Offset = "0x7EEBEC0", VA = "0x187EED0C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	private bool GCEAANJCDCF
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x7EF11D0", Offset = "0x7EEFFD0", VA = "0x187EF11D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	private bool PDMFJGHEHOO
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x7EEB2E0", Offset = "0x7EEA0E0", VA = "0x187EEB2E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public AvatarConfiguration BDODILEIPCP
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xA5F320", Offset = "0xA5E120", VA = "0x180A5F320", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool MEJJIOKFDLP
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x130EA30", Offset = "0x130D830", VA = "0x18130EA30")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x130DD00", Offset = "0x130CB00", VA = "0x18130DD00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	private Material FOEDLEAHPPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x7EF29B0", Offset = "0x7EF17B0", VA = "0x187EF29B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	private Material HGOOJAEDJHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x7EF3220", Offset = "0x7EF2020", VA = "0x187EF3220")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	private bool PHKHFMCHADF
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0xA735B0", Offset = "0xA723B0", VA = "0x180A735B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public PKNFPGJAIIB MEHLKJMNDBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x24CB660", Offset = "0x24CA460", VA = "0x1824CB660", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return default(PKNFPGJAIIB);
		}
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x7EEB3C0", Offset = "0x7EEA1C0", VA = "0x187EEB3C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public Material GCAGEAHFAGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0xB0E460", Offset = "0xB0D260", VA = "0x180B0E460", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public SkinnedMeshRenderer[] OMCBNCDNLFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x1B08590", Offset = "0x1B07390", VA = "0x181B08590", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public Renderer[] BMLPGJCGPNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0xACF330", Offset = "0xACE130", VA = "0x180ACF330", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool FHJACNLOHAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7EF0B50", Offset = "0x7EEF950", VA = "0x187EF0B50", Slot = "22")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public KIECLADILAP.NMBEIOMGMML IGKMHKLONEA
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0xADC5C0", Offset = "0xADB3C0", VA = "0x180ADC5C0", Slot = "20")]
		get
		{
			return default(KIECLADILAP.NMBEIOMGMML);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public int NGPFOLNAFAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x7EEEC50", Offset = "0x7EEDA50", VA = "0x187EEEC50")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x7EEB3D0", Offset = "0x7EEA1D0", VA = "0x187EEB3D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	private bool NLNDFEEENCL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x7EEE340", Offset = "0x7EED140", VA = "0x187EEE340")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	private static bool COLAOPNNIKE
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0xAA3480", Offset = "0xAA2280", VA = "0x180AA3480")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7EF12D0", Offset = "0x7EF00D0", VA = "0x187EF12D0", Slot = "15")]
	public IHGBKKPAEJC KABNGONBPPL(KLFJIDEFFIK EJAEKALFGBJ, bool MJGJPLBFDHO, int[] EKOLFMDDEAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7EF2C30", Offset = "0x7EF1A30", VA = "0x187EF2C30", Slot = "14")]
	public IHGBKKPAEJC LNDJCJIDLCN(KLFJIDEFFIK EJAEKALFGBJ, bool MJGJPLBFDHO, int[] EKOLFMDDEAD, Func<Dictionary<string, MAJDLGCOKCC>, (IHGBKKPAEJC, CEBCBDBEPBJ<Dictionary<string, NONKHMPPJIB<Texture2D>>>)> EJHKPBBDMFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7EF5000", Offset = "0x7EF3E00", VA = "0x187EF5000")]
	public IHGBKKPAEJC OKPDGDJGAKA(KLFJIDEFFIK EJAEKALFGBJ, bool MJGJPLBFDHO, int[] EKOLFMDDEAD, bool DDILEKJDBIB, JBOCHFILNBO OLFEEAJDOBA, [Optional] Func<Dictionary<string, MAJDLGCOKCC>, (IHGBKKPAEJC, CEBCBDBEPBJ<Dictionary<string, NONKHMPPJIB<Texture2D>>>)> EJHKPBBDMFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7EF0370", Offset = "0x7EEF170", VA = "0x187EF0370")]
	private bool JAEDBKLFIFP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7EF13E0", Offset = "0x7EF01E0", VA = "0x187EF13E0")]
	private IHGBKKPAEJC KAPMLJLCLCC(bool MJGJPLBFDHO, List<CEGDNHLGNGK> KPLLBODMJOJ, int[] EKOLFMDDEAD, Func<int, LICBNCEOIEB> GHFGACOGBBI, bool DDILEKJDBIB = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7EEB880", Offset = "0x7EEA680", VA = "0x187EEB880")]
	[IteratorStateMachine(typeof(EBKMOJEPBFA))]
	private IEnumerator<DMCHEKCEBGH> CMIPAJLFBCB(bool MJGJPLBFDHO, List<CEGDNHLGNGK> KPLLBODMJOJ, int[] EKOLFMDDEAD, Func<int, LICBNCEOIEB> GHFGACOGBBI, CNNGGNNJEPE LGKIDBKPILJ, Material KLMAFHHFLEI, List<IHGBKKPAEJC> DJNAEADHJDI, bool LPOJJOFBMEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7EEFD50", Offset = "0x7EEEB50", VA = "0x187EEFD50")]
	private void IPMAAPGPPPN(List<CEGDNHLGNGK> KPLLBODMJOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7EED810", Offset = "0x7EEC610", VA = "0x187EED810")]
	private IHGBKKPAEJC EGCMBGCEPLH(List<CEGDNHLGNGK> KPLLBODMJOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7EF3DE0", Offset = "0x7EF2BE0", VA = "0x187EF3DE0")]
	private IHBKINGAIAD OAAHPDMLAFC(List<CEGDNHLGNGK> KPLLBODMJOJ, int IAOFFAAOAHE, bool MJGJPLBFDHO, LICBNCEOIEB FEMFINBCNMC, bool IADFLHADOIJ, CNNGGNNJEPE LGKIDBKPILJ, Material KLMAFHHFLEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7EF6CA0", Offset = "0x7EF5AA0", VA = "0x187EF6CA0", Slot = "27")]
	public void PEMAACGOMMB(BLODKKHJEPD HNGOMAMNADF, float BNECONOIKOE, bool AEMLKMMMFHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7EF3760", Offset = "0x7EF2560", VA = "0x187EF3760", Slot = "29")]
	public void NICIIKMPGAP(KFIOGNHKBDM CAGKPDNHBMJ, float BNECONOIKOE, bool NNIIFEKBDMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7EEAEC0", Offset = "0x7EE9CC0", VA = "0x187EEAEC0", Slot = "30")]
	public void APEPILCFKPO(MMHOGHLBOGJ OACBPNAGKHA, float BNECONOIKOE, bool LEFAPMEFCPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7EEF5F0", Offset = "0x7EEE3F0", VA = "0x187EEF5F0", Slot = "28")]
	public void IEPJPJHCKEH(bool KCNFAHGIAOK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x7EED400", Offset = "0x7EEC200", VA = "0x187EED400", Slot = "31")]
	public void DOGOJABDIBI(bool KCNFAHGIAOK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7EEFCF0", Offset = "0x7EEEAF0", VA = "0x187EEFCF0", Slot = "32")]
	public void IONBNIBEOOM(bool KCNFAHGIAOK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7EF2E10", Offset = "0x7EF1C10", VA = "0x187EF2E10")]
	private void MGNCIJAOPGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7EEE700", Offset = "0x7EED500", VA = "0x187EEE700")]
	private void GJPNJMOPHIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x7EF2BB0", Offset = "0x7EF19B0", VA = "0x187EF2BB0")]
	private void LMCONOIMCGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7EED750", Offset = "0x7EEC550", VA = "0x187EED750", Slot = "25")]
	public void EDNNEJBECJA(AvatarFaceShape JDNNLNAFKHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7EF1BF0", Offset = "0x7EF09F0", VA = "0x187EF1BF0", Slot = "26")]
	public void KFOIPKKIPNK(AvatarBodyShape MHODDHFLFEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0xBA7730", Offset = "0xBA6530", VA = "0x180BA7730", Slot = "33")]
	public void MBCBFAILLHC(BDLLACEJLDO ANFNFAKDIEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7EEF180", Offset = "0x7EEDF80", VA = "0x187EEF180", Slot = "35")]
	public void HPMJEHJCAHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7EF3310", Offset = "0x7EF2110", VA = "0x187EF3310", Slot = "39")]
	public void MIMDFJHOHJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7EF2B50", Offset = "0x7EF1950", VA = "0x187EF2B50", Slot = "34")]
	public void LFLAPFNNJHK(bool AHODLJHECNM, bool HPCHLDKOPOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7EEEB00", Offset = "0x7EED900", VA = "0x187EEEB00")]
	private void HEKLHCOPJOL(SkinnedMeshRenderer DMCNACCHIFF, int IAOFFAAOAHE, Mesh JLPONKINLEO, List<Material> PHPOEIBDMCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7EEB030", Offset = "0x7EE9E30", VA = "0x187EEB030")]
	private static Material BEFDBBEFHGL(Dictionary<GNMIHPNAIAL, Material> OCAJPENINLF, Material EOEAGHHCHCJ, MGDCHFMJKNI CAHELPONIAF, OCJFAFENDPC GAOELECEKMD, EEPOCEICAIB GPNKMGAJGEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7EEE9D0", Offset = "0x7EED7D0", VA = "0x187EEE9D0")]
	private static MGDCHFMJKNI GNMDJEGJDPD(CEGDNHLGNGK HBFLKMCBGIA, int GBFOBILIDAO)
	{
		return default(MGDCHFMJKNI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7EECCB0", Offset = "0x7EEBAB0", VA = "0x187EECCB0")]
	private void DIFOGELOIGJ(int CABFKOOGELP, Material KKBOKCGIENM, CEGDNHLGNGK HBFLKMCBGIA, [Out] Texture2D NAFEPEHHBEJ, [Out] Vector4 BBNPHMGMFEK, [Out] Texture2D HNNDIMJKFDE, [Out] Texture2D BDGACKDIKIH, [Out] Texture2D NDBOMKGDMKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7EEAA00", Offset = "0x7EE9800", VA = "0x187EEAA00")]
	private void AJOOBNHNIHI(int CABFKOOGELP, Material KKBOKCGIENM, CEGDNHLGNGK HBFLKMCBGIA, [Out] Color OLHDGFDIIOA, [Out] Color OMKJAHDJPJO, [Out] Color EGLAFACDEMC, [Out] Color AFGHJHCHLLB, [Out] Color DELJLGHAGDE, [Out] Color HAIGDEOEOCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x7EF2550", Offset = "0x7EF1350", VA = "0x187EF2550")]
	private bool KNNALCGGGPP(Material KKBOKCGIENM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7EF2B60", Offset = "0x7EF1960", VA = "0x187EF2B60")]
	private static Material LHBDILJFJAG(int CABFKOOGELP, NKGGGOKBFFO HBFLKMCBGIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x7EEE620", Offset = "0x7EED420", VA = "0x187EEE620")]
	private static OCJFAFENDPC GJHHMBBGPFA(CEGDNHLGNGK HBFLKMCBGIA, int GBFOBILIDAO)
	{
		return default(OCJFAFENDPC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x7EF0E50", Offset = "0x7EEFC50", VA = "0x187EF0E50")]
	private static void JJPGLDNPMNK(Dictionary<string, List<GNMIHPNAIAL>> NGHKKFKEBOC, CEGDNHLGNGK CEGDACFKMJE, Material EOEAGHHCHCJ, MGDCHFMJKNI NNNBPPHIPHF, OCJFAFENDPC HGGJDFACBPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7EF1D40", Offset = "0x7EF0B40", VA = "0x187EF1D40")]
	private static SkinnedMeshRenderer KILFKCEONDM(Transform GPNBHKNNLFG, Transform FAIMPNHAGLM, SkinnedMeshRenderer[] AJBKCNNPPKI, int IAOFFAAOAHE, LICBNCEOIEB FEMFINBCNMC, bool MJGJPLBFDHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7EF7140", Offset = "0x7EF5F40", VA = "0x187EF7140")]
	public PGNJDNMGAEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7EEC8E0", Offset = "0x7EEB6E0", VA = "0x187EEC8E0")]
	public void DGPDNICIDDD([In] EDCEPGLIIGB LECLCCLGBEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7EEAFB0", Offset = "0x7EE9DB0", VA = "0x187EEAFB0")]
	public void BEAFHACIJMN([In] LOFAAGOONHO KINOCJFAFKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7EEB3D0", Offset = "0x7EEA1D0", VA = "0x187EEB3D0", Slot = "5")]
	public void CMGLDBAAEEB(int IAOFFAAOAHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7EF19D0", Offset = "0x7EF07D0", VA = "0x187EF19D0", Slot = "10")]
	public void KBIODNMPFAI(EPOJPLJLNGJ HGGJDFACBPH, Texture2D HINEJAGCAOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0xA735B0", Offset = "0xA723B0", VA = "0x180A735B0")]
	public static bool DLMHILGCOIE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x7EEF670", Offset = "0x7EEE470", VA = "0x187EEF670", Slot = "11")]
	public bool IHDEGPFCNCN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x7EEB3F0", Offset = "0x7EEA1F0", VA = "0x187EEB3F0", Slot = "9")]
	public void CHBNBLJKGLE(CIFKFNNENFH NNNBPPHIPHF, Color? PFKMCINIKNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7EF6C20", Offset = "0x7EF5A20", VA = "0x187EF6C20")]
	private void PDBAHLDBGIP(Action OOJPHKAOGAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7EEDEB0", Offset = "0x7EECCB0", VA = "0x187EEDEB0", Slot = "6")]
	public void FLEIGCIBJEB(MAJDLGCOKCC BBIODPFDGJC, Texture NJOINPDPIKP, Color KLMMALADDAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x130DD00", Offset = "0x130CB00", VA = "0x18130DD00", Slot = "7")]
	public void BHLAHEDHPOK(bool LPOJJOFBMEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x1E734F0", Offset = "0x1E722F0", VA = "0x181E734F0", Slot = "8")]
	public void MLNBJHGIAFA(KMFBMBBKEMD OAEBFAAHGEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x7EF27B0", Offset = "0x7EF15B0", VA = "0x187EF27B0", Slot = "16")]
	public void LACCOHLOAMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x7EECC50", Offset = "0x7EEBA50", VA = "0x187EECC50", Slot = "36")]
	public void DHCDECIHKDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x7EEBA90", Offset = "0x7EEA890", VA = "0x187EEBA90", Slot = "37")]
	public void DGMIPCEJJFH([Optional] BHJLPMKOMMK DCDDJLKPLJE, [Optional] bool? EAMFHOBKIOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x7EEA8C0", Offset = "0x7EE96C0", VA = "0x187EEA8C0")]
	private bool AGGPOEFLGDH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x7EEE4A0", Offset = "0x7EED2A0", VA = "0x187EEE4A0", Slot = "21")]
	public bool GGEIEMCLFCA(KIECLADILAP.NMBEIOMGMML LBDBNBGHGEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x7EEDD50", Offset = "0x7EECB50", VA = "0x187EEDD50", Slot = "38")]
	public void FFAHOGCGBDL(float CLMBDHBOBHA, Color PFKMCINIKNC, bool MCOLDCAIODJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x7EEEC60", Offset = "0x7EEDA60", VA = "0x187EEEC60")]
	public void HJMABOFIFCF(float CLMBDHBOBHA, Color PFKMCINIKNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x7EF3670", Offset = "0x7EF2470", VA = "0x187EF3670")]
	private static bool NFGMJMPKBDJ(Material KLMAFHHFLEI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x7EEDA60", Offset = "0x7EEC860", VA = "0x187EEDA60")]
	private void ENAICPIDBKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x7EF12B0", Offset = "0x7EF00B0", VA = "0x187EF12B0")]
	private void JMNIGOFEJAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x7EF2CB0", Offset = "0x7EF1AB0", VA = "0x187EF2CB0")]
	private static void MDMENOMBPEG(Dictionary<GNMIHPNAIAL, Material> OCAJPENINLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x7EEE4C0", Offset = "0x7EED2C0", VA = "0x187EEE4C0")]
	private static void GIHOBPOMLMG(Dictionary<Renderer, CNNGGNNJEPE> DKMBOCNBPPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x7EF6EB0", Offset = "0x7EF5CB0", VA = "0x187EF6EB0")]
	private void PIAGAHIIAJP(SkinnedMeshRenderer[] AJBKCNNPPKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x7EF35D0", Offset = "0x7EF23D0", VA = "0x187EF35D0")]
	private void NCLNGBJCFNJ(SkinnedMeshRenderer OJGKICIDJAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x7EF3C10", Offset = "0x7EF2A10", VA = "0x187EF3C10")]
	private void NPIMCJBMFOE(List<ECOKJONDNDB> DOICCMHGBEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x7EEE850", Offset = "0x7EED650", VA = "0x187EEE850")]
	private void GNKJEFDAKCK(Dictionary<string, NONKHMPPJIB<Texture2D>> NGHKKFKEBOC, bool FEFBEJBLAGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x7EEE3C0", Offset = "0x7EED1C0", VA = "0x187EEE3C0")]
	private void GCDGMCHKBIC(Dictionary<string, List<GNMIHPNAIAL>> NGHKKFKEBOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x7EEB190", Offset = "0x7EE9F90", VA = "0x187EEB190")]
	private void BEGJCNBANAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x7EEEFF0", Offset = "0x7EEDDF0", VA = "0x187EEEFF0")]
	private void HKBEFALFHLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x7EF0440", Offset = "0x7EEF240", VA = "0x187EF0440")]
	private void JBJDBEMFKFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x7EF1100", Offset = "0x7EEFF00", VA = "0x187EF1100")]
	private void JKKPCKIOCBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x7EF1F70", Offset = "0x7EF0D70", VA = "0x187EF1F70")]
	private void KJEIDKIAGNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x7EF0A00", Offset = "0x7EEF800", VA = "0x187EF0A00")]
	private void JEDDDFGLDPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x7EF6D80", Offset = "0x7EF5B80", VA = "0x187EF6D80")]
	private void PFAAPPEMHLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x7EF1300", Offset = "0x7EF0100", VA = "0x187EF1300")]
	private void KAMGJIPIGCP(bool JLPMNALGHFP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x7EEE780", Offset = "0x7EED580", VA = "0x187EEE780")]
	private void GLMJEOCCEFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x7EF4F20", Offset = "0x7EF3D20", VA = "0x187EF4F20")]
	private void OJIOLBFNBAE(bool JLPMNALGHFP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x7EEA5A0", Offset = "0x7EE93A0", VA = "0x187EEA5A0")]
	private void AFLJJMKDBHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x7EEF7F0", Offset = "0x7EEE5F0", VA = "0x187EEF7F0")]
	private void IILMKLKJOPE(Material KLMAFHHFLEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x7EF3A90", Offset = "0x7EF2890", VA = "0x187EF3A90")]
	private void NPBIJIAPHIA(Material KLMAFHHFLEI, Color ENMODPOJIFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x7EF3840", Offset = "0x7EF2640", VA = "0x187EF3840")]
	private void NMOGBDPPNGN(Material KLMAFHHFLEI, Color ENMODPOJIFG, Color DBEEKKIDNLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x7EED4A0", Offset = "0x7EEC2A0", VA = "0x187EED4A0")]
	private void ECCFILKALIK(Material KLMAFHHFLEI, Color OLHDGFDIIOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x7EED1A0", Offset = "0x7EEBFA0", VA = "0x187EED1A0")]
	private void DKKPLEHPJDE(Material KLMAFHHFLEI, Texture2D HINEJAGCAOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x7EF3460", Offset = "0x7EF2260", VA = "0x187EF3460")]
	private void NBIJOAEKOKK(Material KLMAFHHFLEI, Texture KJMIEKBMPOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x7EF0CC0", Offset = "0x7EEFAC0", VA = "0x187EF0CC0")]
	private void JJEPMMAOCAH(Action<CNNGGNNJEPE> AGIEOCKGMNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x7EF2000", Offset = "0x7EF0E00", VA = "0x187EF2000")]
	private void KKAJHEBEEEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x7EEDF20", Offset = "0x7EECD20", VA = "0x187EEDF20")]
	private void FLLMFKPKCEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x7EF2180", Offset = "0x7EF0F80", VA = "0x187EF2180")]
	private void KNMFFILJCGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x7EF2E90", Offset = "0x7EF1C90", VA = "0x187EF2E90")]
	public void MHHFMENGBDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x7EEAFB0", Offset = "0x7EE9DB0", VA = "0x187EEAFB0", Slot = "4")]
	private void DMHPFFBKODL([In] LOFAAGOONHO KINOCJFAFKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x7EED460", Offset = "0x7EEC260", VA = "0x187EED460")]
	[CompilerGenerated]
	private IDGEJBLICGP EBDOEHMFGDD(CEGDNHLGNGK JEDAAEHCPKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x7EEDCC0", Offset = "0x7EECAC0", VA = "0x187EEDCC0")]
	[CompilerGenerated]
	private void EODNBHOKOLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x7EF2C80", Offset = "0x7EF1A80", VA = "0x187EF2C80")]
	[CompilerGenerated]
	private void MDBCBHEMIPF(CNNGGNNJEPE KNDMJPDPKCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x7EED640", Offset = "0x7EEC440", VA = "0x187EED640")]
	[CompilerGenerated]
	private void ECMCJGKPLKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x7EEF650", Offset = "0x7EEE450", VA = "0x187EEF650")]
	[CompilerGenerated]
	private void IGBAIFFKHIE(CNNGGNNJEPE KNDMJPDPKCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x7EEDC30", Offset = "0x7EECA30", VA = "0x187EEDC30")]
	[CompilerGenerated]
	private void ENMPFCBGHKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x7EF2C60", Offset = "0x7EF1A60", VA = "0x187EF2C60")]
	[CompilerGenerated]
	private void MCHFGLLCOGO(CNNGGNNJEPE KNDMJPDPKCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x7EEF560", Offset = "0x7EEE360", VA = "0x187EEF560")]
	[CompilerGenerated]
	private void IADIGPCEPKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x7EF0E20", Offset = "0x7EEFC20", VA = "0x187EF0E20")]
	[CompilerGenerated]
	private void JJLJDIOACNJ(CNNGGNNJEPE KNDMJPDPKCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x7EEB7F0", Offset = "0x7EEA5F0", VA = "0x187EEB7F0")]
	[CompilerGenerated]
	private void CHECBENIJBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x7EF6E50", Offset = "0x7EF5C50", VA = "0x187EF6E50")]
	[CompilerGenerated]
	private void PFOHJOHOEGJ(CNNGGNNJEPE KNDMJPDPKCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x7EF1CB0", Offset = "0x7EF0AB0", VA = "0x187EF1CB0")]
	[CompilerGenerated]
	private void KHGGGJMCCIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x7EEA570", Offset = "0x7EE9370", VA = "0x187EEA570")]
	[CompilerGenerated]
	private void ADCLNNJEAJJ(CNNGGNNJEPE KNDMJPDPKCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x7EEE410", Offset = "0x7EED210", VA = "0x187EEE410")]
	[CompilerGenerated]
	private void GDAAKKEHGOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x7EF6E80", Offset = "0x7EF5C80", VA = "0x187EF6E80")]
	[CompilerGenerated]
	private void PGKLLKNKFPF(CNNGGNNJEPE KNDMJPDPKCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x7EED6D0", Offset = "0x7EEC4D0", VA = "0x187EED6D0")]
	[CompilerGenerated]
	private void EDKFBJCPMMA(KeyValuePair<string, NONKHMPPJIB<Texture2D>> DNMKHJLFBLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x7EEBA80", Offset = "0x7EEA880", VA = "0x187EEBA80")]
	[CompilerGenerated]
	private void DELPPAAIKKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x7EF4EF0", Offset = "0x7EF3CF0", VA = "0x187EF4EF0")]
	[CompilerGenerated]
	private void OCJKPCONKJC(CNNGGNNJEPE KNDMJPDPKCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x7EF12C0", Offset = "0x7EF00C0", VA = "0x187EF12C0")]
	[CompilerGenerated]
	private void JPCLNAEIHEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x7EEEAD0", Offset = "0x7EED8D0", VA = "0x187EEEAD0")]
	[CompilerGenerated]
	private void HANMAIPNEAI(CNNGGNNJEPE KNDMJPDPKCG)
	{
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class AvatarElbowBendHelperController : MonoBehaviour, PGIHJAPDENJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		[LHHMDDGFBKD(NKIOFDIBBLL.Self, false, false, false)]
		[SerializeField]
		private Transform ElbowHelperBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		[SerializeField]
		private Transform UpperArmBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		[SerializeField]
		private Transform LowerArmBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		[SerializeField]
		private float MinAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		[SerializeField]
		private float MaxAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		[FormerlySerializedAs("MinScaleValues")]
		[Header("Scale")]
		[SerializeField]
		private Vector3 ScaleValuesAtMinAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		[FormerlySerializedAs("MaxScaleValues")]
		[SerializeField]
		private Vector3 ScaleValuesAtMaxAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		[SerializeField]
		[FormerlySerializedAs("MinLocalPositionalOffset")]
		[Header("Positional Offset")]
		private Vector3 PositionalOffsetAtMinAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		[FormerlySerializedAs("MaxLocalPositionOffset")]
		[SerializeField]
		private Vector3 PositionalOffsetAtMaxAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private Vector3? FEDIOGKKMKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		private bool IAPPDPNGLBC;

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x7EE1490", Offset = "0x7EE0290", VA = "0x187EE1490", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x7EE1AC0", Offset = "0x7EE08C0", VA = "0x187EE1AC0", Slot = "4")]
		public void UpdateController(float GJELOGAKDKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0xD59690", Offset = "0xD58490", VA = "0x180D59690", Slot = "6")]
		public void SetEnabled(bool BNECONOIKOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x7EE1570", Offset = "0x7EE0370", VA = "0x187EE1570")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x7EE1F80", Offset = "0x7EE0D80", VA = "0x187EE1F80")]
		public AvatarElbowBendHelperController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class AvatarElbowBendTargetController : MonoBehaviour, PGIHJAPDENJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		private const float NDPHLICHBNB = 45f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		[SerializeField]
		[LHHMDDGFBKD(NKIOFDIBBLL.Self, false, false, false)]
		private Transform ElbowBendTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		[SerializeField]
		private Transform NeckBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		[SerializeField]
		private Transform UpperArmBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		[SerializeField]
		private Transform HandBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		[SerializeField]
		private bool Left;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		[SerializeField]
		private float MinTwist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		[SerializeField]
		private float MaxTwist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		[SerializeField]
		private float TwistWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		[SerializeField]
		private float ElbowSmoothTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		[SerializeField]
		private float RestTwist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		[SerializeField]
		private float RestTwistWhenClose;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		[SerializeField]
		private float RestTwistDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		private Vector3 MJOMHCJMAIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		private Vector3 KPFLAICPHBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private bool IAPPDPNGLBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		private float DEAEFIBMJJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		private float EKABEIIMIHB;

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x7EE2300", Offset = "0x7EE1100", VA = "0x187EE2300", Slot = "4")]
		public void UpdateController(float GJELOGAKDKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0xF9FD40", Offset = "0xF9EB40", VA = "0x180F9FD40", Slot = "6")]
		public void SetEnabled(bool BNECONOIKOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x7EE2020", Offset = "0x7EE0E20", VA = "0x187EE2020")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x7EE2DC0", Offset = "0x7EE1BC0", VA = "0x187EE2DC0")]
		public AvatarElbowBendTargetController()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class KOBHOKNFIOJ : GLADMCEDLEP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private static readonly int BMDJMHEFFNO;

	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private static readonly int JDKJIEHPIPA;

	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private static readonly int DNBKJEAJHDG;

	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private static readonly int AFHFHPBOKMD;

	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private static readonly int ILBEMPEAMIK;

	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private static readonly int OLBKBHMPAIC;

	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private static readonly int DBNCJCEAMDI;

	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private static readonly int LOCGKIJEHAI;

	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private static readonly int ALNHHELGPPB;

	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private static readonly int IMDLANCPBNP;

	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private static readonly int OLEOCOFMGLI;

	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private static readonly int CKBHJGGKAGG;

	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private static readonly int JHAMJPPMKHC;

	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private static readonly int LIOOKAMJLNL;

	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private static readonly int KBANOFDBLHD;

	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private static readonly int LEHDPEJNDDP;

	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private static readonly int JJPJDDOFDCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private Transform KLJFEHOICPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	private Transform OFGOEEIHGPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	private Transform JKJPGLJLCEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	private Transform KEPFAICJJIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	private Transform BJHFKMIEPAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private Transform PGGEEGKAKFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	private NHIEONBOHOM NILKJCIONLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	private Material INEEPGGIMJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private SkinnedMeshRenderer[] OIDOFACIAOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	private readonly List<Material> MAAHIEJMFOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	private HPPBEBEADME ELLNNFEEEBM;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public EPBKGABEMJJ JPLJINDCGLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0xA598A0", Offset = "0xA586A0", VA = "0x180A598A0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	private HPPBEBEADME NOANPOONAOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x7F061A0", Offset = "0x7F04FA0", VA = "0x187F061A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool LJEKCHIHJOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x7F04840", Offset = "0x7F03640", VA = "0x187F04840", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x7F046B0", Offset = "0x7F034B0", VA = "0x187F046B0")]
	public void DGPDNICIDDD([In] NHIEONBOHOM HPIMABDBCJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x7F04760", Offset = "0x7F03560", VA = "0x187F04760")]
	public void DHIOIONOJPL([In] CBJMEBCKBKK NMCMNFOPJIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x7F06230", Offset = "0x7F05030", VA = "0x187F06230", Slot = "6")]
	public void PHGOJMKOLAB(OIKNEBEGIMP AHLKHGJGAGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x7F058F0", Offset = "0x7F046F0", VA = "0x187F058F0")]
	private Vector2 FOHNLKDDHDE(Vector2 AFBAAOCLMBP)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x7F04990", Offset = "0x7F03790", VA = "0x187F04990")]
	public void DPBJJFFCIKD([In] NJABEJKMDLB NMCMNFOPJIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x7F05DD0", Offset = "0x7F04BD0", VA = "0x187F05DD0")]
	private void KPFOMNCHJPA(JFDBJABHPOJ OOFPNHLIIAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x7F05950", Offset = "0x7F04750", VA = "0x187F05950")]
	private void HHDDLIGEKIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x7F05880", Offset = "0x7F04680", VA = "0x187F05880")]
	private void LIABPFJKOBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x7F05880", Offset = "0x7F04680", VA = "0x187F05880", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x7F06A70", Offset = "0x7F05870", VA = "0x187F06A70")]
	public KOBHOKNFIOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x7F04760", Offset = "0x7F03560", VA = "0x187F04760", Slot = "5")]
	private void NNBBDDCLMMD([In] CBJMEBCKBKK NMCMNFOPJIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x7F046A0", Offset = "0x7F034A0", VA = "0x187F046A0", Slot = "7")]
	private void ACHAGABJLKP([In] NJABEJKMDLB NMCMNFOPJIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x7F06220", Offset = "0x7F05020", VA = "0x187F06220")]
	[CompilerGenerated]
	internal static float NPJIHLNLNPF(float BNECONOIKOE, float DAECPIPBCGL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x7F05CE0", Offset = "0x7F04AE0", VA = "0x187F05CE0")]
	[CompilerGenerated]
	internal static void KOLAACLFIEN(Vector2 KIJFFLMIFKF, Vector2 HKPBPBFIENF, Vector2 DFCCCGNJINK, Vector2 IIEOAHPEFEA, Vector2 PFNOCLOHBOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x7F04800", Offset = "0x7F03600", VA = "0x187F04800")]
	[CompilerGenerated]
	internal static Vector4 DIIOLIGFFJJ(Vector2 EMECBHNHILC, Vector2 AMJKMJIBGNI)
	{
		return default(Vector4);
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public class AvatarForearmRollController : MonoBehaviour, PGIHJAPDENJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		[SerializeField]
		private Transform TwistBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		[SerializeField]
		private Transform HandBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		[SerializeField]
		private Transform LowerArmTwistBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		[SerializeField]
		private Transform UpperArmTwistBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		[SerializeField]
		private Transform ElbowTwistBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		[SerializeField]
		private float RollTowardsWristAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		[SerializeField]
		private float RollSoftMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		[SerializeField]
		private float RollSoftMax;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		[SerializeField]
		private float LowerArmTwistAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		[SerializeField]
		private float UpperArmTwistAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		[SerializeField]
		private float ElbowTwistAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		private float DEAEFIBMJJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private bool IAPPDPNGLBC;

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x7EF9750", Offset = "0x7EF8550", VA = "0x187EF9750", Slot = "4")]
		public void UpdateController(float GJELOGAKDKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x21B3990", Offset = "0x21B2790", VA = "0x1821B3990", Slot = "6")]
		public void SetEnabled(bool BNECONOIKOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x7EF9FC0", Offset = "0x7EF8DC0", VA = "0x187EF9FC0")]
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
			[Cpp2IlInjected.Token(Token = "0x4000170")]
			[Tooltip("Name of animation original state to override")]
			public string OriginalName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000171")]
			[Tooltip("Name of animation state to use as an override")]
			public string OverrideName;

			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
			public AnimationOverride()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		[SerializeField]
		private AnimationOverride[] HandStateOverrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		private Dictionary<int, int> _animationOverrides;

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x7EFA060", Offset = "0x7EF8E60", VA = "0x187EFA060")]
		public void ONJHMMKMDOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x7EF9FF0", Offset = "0x7EF8DF0", VA = "0x187EF9FF0")]
		public int CFGDEGCNKEC(int GHEEJDCHHNC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public AvatarHandDisplaySettings()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class DAJLNAGNEAO : LEFKGOBLCOL
{
	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x7EFF990", Offset = "0x7EFE790", VA = "0x187EFF990", Slot = "24")]
	public override float FDNNCAGKDHE()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x7EFF9E0", Offset = "0x7EFE7E0", VA = "0x187EFF9E0")]
	public DAJLNAGNEAO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class LEFKGOBLCOL : FKLMPLDDLKB
{
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private static int FIGFLPAGGJA;

	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private static int JPOFDBAHNMC;

	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private static int JIEBCGBLKNK;

	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private static int EOJMJEDCNOH;

	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private static int IAFFMMGJHKF;

	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private static int FKBMKBALHLP;

	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private static int CMCELKDMGMG;

	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private static int[] EHNADOKHAFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	private ENMFPOBIHNB NILKJCIONLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	private DOPNBHJAEIP HLFCBEBMLIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	private int KLMMFNGIFMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	private float LEDECLBPOGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	protected Animator HACLODKOPJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	protected AvatarConfiguration BCDDHODHOKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	protected int OMCCMLKCLJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private int FHLNHHAGECI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	private int EHIDEBCDPLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	private bool HCOFICJIGIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	private DPBJDHGJEHD OHEOFDNJKJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	private int KGEANEGCDKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	private float MLLDDMMGJNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	private AvatarHandDisplaySettings FFPLCGIEOGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	private PKNFPGJAIIB NEGMCCHHNOP;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public Transform PBEMJPIOECG
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0xA598A0", Offset = "0xA586A0", VA = "0x180A598A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0xA59840", Offset = "0xA58640", VA = "0x180A59840")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public Vector3 LIIINGNOIDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x189BC20", Offset = "0x189AA20", VA = "0x18189BC20")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x189BCE0", Offset = "0x189AAE0", VA = "0x18189BCE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public Quaternion IKDKALOAKCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0xE3B650", Offset = "0xE3A450", VA = "0x180E3B650")]
		[CompilerGenerated]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x1019910", Offset = "0x1018710", VA = "0x181019910")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool HEODIHNNPNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x7F076A0", Offset = "0x7F064A0", VA = "0x187F076A0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x7F07030", Offset = "0x7F05E30", VA = "0x187F07030")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool HMBNIDNNJJO
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0xACBBB0", Offset = "0xACA9B0", VA = "0x180ACBBB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public Vector3 PLCOAJDAKAD
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0xA84DA0", Offset = "0xA83BA0", VA = "0x180A84DA0", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0xA85CA0", Offset = "0xA84AA0", VA = "0x180A85CA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public Quaternion GNEDOLEGGLA
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x11F3C70", Offset = "0x11F2A70", VA = "0x1811F3C70", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x16670A0", Offset = "0x1665EA0", VA = "0x1816670A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public GDNBFNJLEDA MPPPJCBBOOM
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0xAFB150", Offset = "0xAF9F50", VA = "0x180AFB150", Slot = "21")]
		[CompilerGenerated]
		get
		{
			return default(GDNBFNJLEDA);
		}
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0xAFAC60", Offset = "0xAF9A60", VA = "0x180AFAC60", Slot = "4")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public GDNBFNJLEDA JIHJJBIOIHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0xAFB140", Offset = "0xAF9F40", VA = "0x180AFB140", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return default(GDNBFNJLEDA);
		}
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0xAFAC50", Offset = "0xAF9A50", VA = "0x180AFAC50", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public float KAFLKMHAOAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0xBA8110", Offset = "0xBA6F10", VA = "0x180BA8110", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x1026D10", Offset = "0x1025B10", VA = "0x181026D10", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool DPMPAFOHDII
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x7F07600", Offset = "0x7F06400", VA = "0x187F07600", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x7F06BB0", Offset = "0x7F059B0", VA = "0x187F06BB0", Slot = "9")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool FFLFOCMAIDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x7F073D0", Offset = "0x7F061D0", VA = "0x187F073D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool GJOFOEHBPDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x7F07660", Offset = "0x7F06460", VA = "0x187F07660")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool EBDODCDBBDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x7F06C00", Offset = "0x7F05A00", VA = "0x187F06C00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public bool OPPDKEKICFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x7F075F0", Offset = "0x7F063F0", VA = "0x187F075F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x7F06C70", Offset = "0x7F05A70", VA = "0x187F06C70", Slot = "23")]
	public void DGPDNICIDDD(ENMFPOBIHNB HPIMABDBCJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x7F075A0", Offset = "0x7F063A0", VA = "0x187F075A0")]
	public void IPDAHOAKDMK(DOPNBHJAEIP BAHBHJFPCLP, AvatarHandDisplaySettings LIKCCDGEANE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x7F06FA0", Offset = "0x7F05DA0", VA = "0x187F06FA0", Slot = "14")]
	public void DLLFNLNEFCG(bool GPJMDAINDNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x7F07060", Offset = "0x7F05E60", VA = "0x187F07060", Slot = "13")]
	public void ECMPJHFENLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0xBA8110", Offset = "0xBA6F10", VA = "0x180BA8110", Slot = "24")]
	public virtual float FDNNCAGKDHE()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x7F06E10", Offset = "0x7F05C10", VA = "0x187F06E10")]
	private int DLANLEJAGBG(GDNBFNJLEDA OGLCGLIABDH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x7F073E0", Offset = "0x7F061E0", VA = "0x187F073E0")]
	private void FFANIDNDKAN(int OKKOAMPNJGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x7F07680", Offset = "0x7F06480", VA = "0x187F07680", Slot = "15")]
	public bool MFBELMCOEAO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x7F07670", Offset = "0x7F06470", VA = "0x187F07670", Slot = "16")]
	public bool MBEDJOFDACE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x7F06C20", Offset = "0x7F05A20", VA = "0x187F06C20")]
	private GDNBFNJLEDA DGFEDGEPKHK()
	{
		return default(GDNBFNJLEDA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x1E2B7B0", Offset = "0x1E2A5B0", VA = "0x181E2B7B0", Slot = "17")]
	public void FOPFNDDDCFE(bool GPJMDAINDNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x7F06BC0", Offset = "0x7F059C0", VA = "0x187F06BC0", Slot = "12")]
	public void BMCAMBGEDBP(int OKKOAMPNJGB, float EMAHMAHMAFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x7F076D0", Offset = "0x7F064D0", VA = "0x187F076D0", Slot = "10")]
	public void OPBAFHJHACM(DPBJDHGJEHD EOMNODKHFBK, bool BAMJEJIELLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x7F06C10", Offset = "0x7F05A10", VA = "0x187F06C10", Slot = "11")]
	public void CJEFLPFGDHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x7F07610", Offset = "0x7F06410", VA = "0x187F07610", Slot = "18")]
	public void KCAJCJDGBDE(Transform CMDMCJGFCDK, Vector3 MIFPACKEOBL, Quaternion FGPGELNPPGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x7F079C0", Offset = "0x7F067C0", VA = "0x187F079C0")]
	public LEFKGOBLCOL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class NKGGGOKBFFO : CEGDNHLGNGK
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class HOLEBFOGEPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		public NKGGGOKBFFO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		public List<ECOKJONDNDB> prefabHandles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public List<ECOKJONDNDB> materialHandles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public NONKHMPPJIB<Material[]> loadMaterialsHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public NONKHMPPJIB<BLMJBKFLGDK> loadPrefabHandle;

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public HOLEBFOGEPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x7F03260", Offset = "0x7F02060", VA = "0x187F03260")]
		internal IDGEJBLICGP BAOFJMLGEOG(string error)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	public MAJDLGCOKCC BIGMGEEDDJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	public BLMJBKFLGDK ABKFNBNOKAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private NONKHMPPJIB<BLMJBKFLGDK> ACNBGHCOOFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private NONKHMPPJIB<Material[]> KFIOBGJPCDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	public Material[] CIMHKPHGHAB;

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool PCFIEIDKMCE
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0xA86430", Offset = "0xA85230", VA = "0x180A86430")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0xA861B0", Offset = "0xA84FB0", VA = "0x180A861B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public KIECLADILAP.NMBEIOMGMML LCONCMEJMDG
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0xA5C130", Offset = "0xA5AF30", VA = "0x180A5C130")]
		[CompilerGenerated]
		get
		{
			return default(KIECLADILAP.NMBEIOMGMML);
		}
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0xA5BF90", Offset = "0xA5AD90", VA = "0x180A5BF90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x7F0A560", Offset = "0x7F09360", VA = "0x187F0A560")]
	public NKGGGOKBFFO(EEPOCEICAIB NPNNBKHKIAK, MAJDLGCOKCC MAIMFJAKNEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x7F09230", Offset = "0x7F08030", VA = "0x187F09230", Slot = "6")]
	public override IDGEJBLICGP ALBFDJMJANI(List<ECOKJONDNDB> LCEFANDJLGA, List<ECOKJONDNDB> EJNELHNHOGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x7F09D40", Offset = "0x7F08B40", VA = "0x187F09D40")]
	public IDGEJBLICGP EEKNFGNILFI(List<ECOKJONDNDB> LCEFANDJLGA, List<ECOKJONDNDB> EJNELHNHOGD, NONKHMPPJIB<Material[]> KFIOBGJPCDK, [Optional] NONKHMPPJIB<BLMJBKFLGDK> GMMIPJMBCJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x7F0A070", Offset = "0x7F08E70", VA = "0x187F0A070")]
	public (NONKHMPPJIB<Material[]>, NONKHMPPJIB<BLMJBKFLGDK>) FNNDNMFAMOP(List<ECOKJONDNDB> LCEFANDJLGA, List<ECOKJONDNDB> EJNELHNHOGD)
	{
		return default((NONKHMPPJIB<Material[]>, NONKHMPPJIB<BLMJBKFLGDK>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x7F0A3E0", Offset = "0x7F091E0", VA = "0x187F0A3E0", Slot = "7")]
	public override FBKAKPJJBLC MHFHPMAPAIH(uint IAOFFAAOAHE, AvatarSkinnedMeshBoneOrderRemapsData BFAPBGJNHBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x7F096F0", Offset = "0x7F084F0", VA = "0x187F096F0")]
	public FBKAKPJJBLC CAEHKJOJPJJ(GameObject AMMDDADMDEL, uint IAOFFAAOAHE, bool GJJNFKNDPHC, bool CJOFNMHNOOK, AvatarSkinnedMeshBoneOrderRemapsData BFAPBGJNHBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x7F099D0", Offset = "0x7F087D0", VA = "0x187F099D0")]
	public static bool DKKKENDPKNN(Renderer[] AJBKCNNPPKI, string GBBFOCLLMPD, [Out] Renderer EJHKENLNABP, [Out] Renderer EAAAACDNBMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x7F0A510", Offset = "0x7F09310", VA = "0x187F0A510", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x7F09900", Offset = "0x7F08700", VA = "0x187F09900")]
	private (NONKHMPPJIB<BLMJBKFLGDK>, NONKHMPPJIB<Material[]>) CGCMPGDKMPI()
	{
		return default((NONKHMPPJIB<BLMJBKFLGDK>, NONKHMPPJIB<Material[]>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x7F0A050", Offset = "0x7F08E50", VA = "0x187F0A050")]
	[CompilerGenerated]
	private void FLJNCBEFADB(BLMJBKFLGDK OHLBIIOAJDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0xA5F350", Offset = "0xA5E150", VA = "0x180A5F350")]
	[CompilerGenerated]
	private void PNKBPCHLKGP(Material[] OHLBIIOAJDL)
	{
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public class AvatarKneeBendTargetController : MonoBehaviour, PGIHJAPDENJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		[SerializeField]
		[LHHMDDGFBKD(NKIOFDIBBLL.Self, false, false, false)]
		private Transform KneeBendTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		[SerializeField]
		private Transform RootSpineBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		[SerializeField]
		private Transform ThighBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		[SerializeField]
		private Transform FootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		[SerializeField]
		private float WeightToFootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		[SerializeField]
		private Vector3 BendTargetOffsetFromHipToFootMidPoint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		[SerializeField]
		private Bounds KneeTargetConstrainedBox;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		private Vector3 MJOMHCJMAIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		private Vector3 ODJHEKGEAPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		private Vector3 MPONIDCIHBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		private Matrix4x4 NFJCOHHBCFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		private bool IAPPDPNGLBC;

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x7EFA5F0", Offset = "0x7EF93F0", VA = "0x187EFA5F0", Slot = "4")]
		public void UpdateController(float GJELOGAKDKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x7EFA5E0", Offset = "0x7EF93E0", VA = "0x187EFA5E0", Slot = "6")]
		public void SetEnabled(bool BNECONOIKOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x7EFA180", Offset = "0x7EF8F80", VA = "0x187EFA180")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x7EFACB0", Offset = "0x7EF9AB0", VA = "0x187EFACB0")]
		public AvatarKneeBendTargetController()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[HCBEFNLCJPF]
public struct PBKGDHGCLHN : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	[ReadOnly]
	public FKCKGJNGFHL PHIDGLACEEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	[ReadOnly]
	public int CDGBEFDIKFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	public MMEOPEHJNGC PPJFMEHOHBP;

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x7F0A6C0", Offset = "0x7F094C0", VA = "0x187F0A6C0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[NativeContainer]
[HCBEFNLCJPF]
public struct MMEOPEHJNGC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	public NativeArray<Vector3> KGIAABJAALK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	public NativeArray<Vector3> LOGPOEEIFMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	public NativeArray<Vector4> DABMBJJEBOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	public NativeArray<Vector2> NBIHODMAPPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	public NativeArray<Vector2> BLEIEAAPGII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	public NativeArray<Vector2> KJBPJBAMCCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	public NativeArray<Vector2> PGPLCNPPJPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	public NativeArray<Color> PMAHFIGLOJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	public NativeArray<int> KHMKOGLJMLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	public NativeArray<int> LMFHFAMPMGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	private NativeArray<int> CKJFPHCPHFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	private NativeArray<int> OIEGIIHEOCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	public NativeArray<int> LDEKPNMIPJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	public NativeArray<int> JBNIDJHOAAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	public NativeArray<int> NEPIDEFJLHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	public NativeArray<BoneWeight> LLNJBOJHGIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	private NativeArray<int> OAEBFAAHGEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	private bool KHGNHKGFOLO;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public int ILCABFAPDIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x7F080E0", Offset = "0x7F06EE0", VA = "0x187F080E0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x7F08430", Offset = "0x7F07230", VA = "0x187F08430")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public int FIFMKNKNKDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x7F08A50", Offset = "0x7F07850", VA = "0x187F08A50")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x7F08B20", Offset = "0x7F07920", VA = "0x187F08B20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public int GAJCFJMJJJN
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x7F08B10", Offset = "0x7F07910", VA = "0x187F08B10")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x7F08A40", Offset = "0x7F07840", VA = "0x187F08A40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x7F08B30", Offset = "0x7F07930", VA = "0x187F08B30")]
	public MMEOPEHJNGC(int JHMCDMNLPNI, int CMEIMLDBIIB, int HPEFGPDPNPK, int BOPLBCKBBFH, Allocator DFGMDNGNOEN, int KMFHDAKIFNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x7F08A80", Offset = "0x7F07880", VA = "0x187F08A80")]
	public void MDPCGJABOIK(int CKFKPOAGPKN, Vector3 FPJNLHKNPEA, Vector3 GAHCIOCKFAM, Vector4 ODOKMLFIJNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x7F08440", Offset = "0x7F07240", VA = "0x187F08440")]
	public void IGKFOBCHDMC(int CKFKPOAGPKN, BoneWeight DOMEONCHNBA, NativeSlice<byte> PKOGGKHKMCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x7F08A60", Offset = "0x7F07860", VA = "0x187F08A60")]
	public Color LIMDACHDKJO(int CKFKPOAGPKN)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x7F08AF0", Offset = "0x7F078F0", VA = "0x187F08AF0")]
	public void NIBAFIDCGMI(int CKFKPOAGPKN, Color BEIDDJJHBIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x7F080F0", Offset = "0x7F06EF0", VA = "0x187F080F0")]
	public void BJMHJGCOMHJ(byte CCCHHIFANKH, int CKFKPOAGPKN, Vector2 GKPNMBGMLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x7F085E0", Offset = "0x7F073E0", VA = "0x187F085E0")]
	public void ILBGNNFKNFM(int CKFKPOAGPKN, int DBKHFGOBDLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x7F08A10", Offset = "0x7F07810", VA = "0x187F08A10")]
	public bool KJGEPECNDDC(int CCCHHIFANKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x7F08940", Offset = "0x7F07740", VA = "0x187F08940")]
	public void JPPAMHCCIKF(int FGHFHPDFCBF, int DOBKAGHAEBK, int IDFEOHMGIAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x7F08140", Offset = "0x7F06F40", VA = "0x187F08140")]
	public int[] CFPKBNONOCM(int FGHFHPDFCBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x7F083A0", Offset = "0x7F071A0", VA = "0x187F083A0")]
	private NativeSlice<int> HGGPMNPLDLL(int FGHFHPDFCBF)
	{
		return default(NativeSlice<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x7F081F0", Offset = "0x7F06FF0", VA = "0x187F081F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x7F085F0", Offset = "0x7F073F0", VA = "0x187F085F0")]
	public Mesh JDFMHAGBLPC([Optional] string IMNHKJGLBPK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[HCBEFNLCJPF]
[DefaultMember("Item")]
[NativeContainer]
public struct FKCKGJNGFHL : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	public NativeArray<Vector3> KGIAABJAALK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	public NativeArray<Vector3> LOGPOEEIFMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	public NativeArray<Vector4> DABMBJJEBOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	public NativeArray<Vector2> NBIHODMAPPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	public NativeArray<Vector2> BLEIEAAPGII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	public NativeArray<Vector2> KJBPJBAMCCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	public NativeArray<Vector2> PGPLCNPPJPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	public NativeArray<Color> PMAHFIGLOJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	public NativeArray<int> HOHBLPIPPEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	public NativeArray<int> KMHBNDIJBGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	public NativeArray<int> MFMHIPEFDAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	public NativeArray<int> FECOGPCJCIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	public NativeArray<bool> FHDMKCNLHAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	public NativeArray<int> LEKJKGJFHHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	public NativeArray<int> FMCIIJCKKOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	public NativeArray<BoneWeight> PECGHNGHBGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	private NativeArray<Matrix4x4> GPBIFEAIEGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	private NativeArray<long> ABDLDLPKGOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	private NativeArray<byte> BIOHBHEMEOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	private NativeArray<int> EGNOOGIPDGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	private NativeArray<int> HJJEGOEMBIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	public NativeArray<sbyte> ILLHJCIKLNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	public NativeArray<byte> FHEEHIIKJAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	private NativeArray<int> PPJIEIMHMMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	private bool KHGNHKGFOLO;

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public int BBEKONJHCLC
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0xEC90A0", Offset = "0xEC7EA0", VA = "0x180EC90A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public int ALLOFGBEMMM
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0xD5C5B0", Offset = "0xD5B3B0", VA = "0x180D5C5B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public int KLDJHGHGOKH
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x7F004A0", Offset = "0x7EFF2A0", VA = "0x187F004A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public int EEHPJFMDFGI
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x7F00CC0", Offset = "0x7EFFAC0", VA = "0x187F00CC0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x7F00C80", Offset = "0x7EFFA80", VA = "0x187F00C80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public int ILCABFAPDIH
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x7F00480", Offset = "0x7EFF280", VA = "0x187F00480")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x7F00C90", Offset = "0x7EFFA90", VA = "0x187F00C90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public int GHPNJIGMGKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x7F00CB0", Offset = "0x7EFFAB0", VA = "0x187F00CB0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x7F00490", Offset = "0x7EFF290", VA = "0x187F00490")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public JPLNFBHFPMI GHECPCPPHBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x7F00CD0", Offset = "0x7EFFAD0", VA = "0x187F00CD0")]
		get
		{
			return default(JPLNFBHFPMI);
		}
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x7F00CE0", Offset = "0x7EFFAE0", VA = "0x187F00CE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public byte PJDPMHHGEIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x7F00CA0", Offset = "0x7EFFAA0", VA = "0x187F00CA0")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x7F004D0", Offset = "0x7EFF2D0", VA = "0x187F004D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public EEEDGBKEEFP CBMLGEIEAGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x7F00750", Offset = "0x7EFF550", VA = "0x187F00750")]
		get
		{
			return default(EEEDGBKEEFP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x7F00DC0", Offset = "0x7EFFBC0", VA = "0x187F00DC0")]
	public FKCKGJNGFHL(IList<Mesh> KNNKEBBLJNP, IList<Matrix4x4> PDPACKOPBOL, IList<bool> FHDMKCNLHAF, byte ENKJEANPOIA, IList<byte[]> FGFICCENOCC, IList<long> PCDJIFICMOG, IList<bool> OKKGKPPCDFC, IList<int> LEKJKGJFHHP, IList<int> FFIMIPGOEJB, IList<int> OIBABHDMFJE, Allocator DFGMDNGNOEN, JPLNFBHFPMI NGKCAGOOJBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x7F00CF0", Offset = "0x7EFFAF0", VA = "0x187F00CF0")]
	public MMEOPEHJNGC OJGFCBPPEEF(Allocator DFGMDNGNOEN)
	{
		return default(MMEOPEHJNGC);
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x7F004E0", Offset = "0x7EFF2E0", VA = "0x187F004E0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[HCBEFNLCJPF]
public class NMNGKEOFMHF : MIHBGKMEGME
{
	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x7F0A5D0", Offset = "0x7F093D0", VA = "0x187F0A5D0")]
	public FKCKGJNGFHL GGNLBLMBGOH()
	{
		return default(FKCKGJNGFHL);
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x7EE7FB0", Offset = "0x7EE6DB0", VA = "0x187EE7FB0")]
	public NMNGKEOFMHF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public struct EEEDGBKEEFP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	public NativeSlice<Vector3> KGIAABJAALK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	public NativeSlice<Vector3> LOGPOEEIFMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	public NativeSlice<Vector4> DABMBJJEBOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	public NativeSlice<Vector2> NBIHODMAPPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	public NativeSlice<Vector2> BLEIEAAPGII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	public NativeSlice<Vector2> KJBPJBAMCCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	public NativeSlice<Vector2> PGPLCNPPJPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	public NativeSlice<Color> PMAHFIGLOJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	public NativeSlice<int> NAMHPFMELJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	public NativeSlice<int> FECOGPCJCIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	public NativeSlice<BoneWeight> PECGHNGHBGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	public NativeSlice<byte> NFJBJHKJHEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	public int EPAOIMKNIBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	public Matrix4x4 GIHIPNEKFNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	public long ODNPBLLKCJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	public NativeSlice<byte> PKOGGKHKMCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	public bool ONPEIMNCJPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	public int JDJIOMGBIKA;
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
internal readonly struct GNMIHPNAIAL : IEquatable<GNMIHPNAIAL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	internal readonly Material OHKKCFOKAEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	internal readonly MGDCHFMJKNI OJGHCJFDIAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	internal readonly OCJFAFENDPC DBAECAGMOHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	internal readonly EEPOCEICAIB NLJJOPOPIOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	internal readonly bool GDGCPLBGDNK;

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x7F03120", Offset = "0x7F01F20", VA = "0x187F03120")]
	public GNMIHPNAIAL(Material KKBOKCGIENM, MGDCHFMJKNI CAHELPONIAF, OCJFAFENDPC GAOELECEKMD, EEPOCEICAIB GPNKMGAJGEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x7F02E80", Offset = "0x7F01C80", VA = "0x187F02E80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x7F02CE0", Offset = "0x7F01AE0", VA = "0x187F02CE0", Slot = "4")]
	public bool Equals(GNMIHPNAIAL LOKLFHKEJPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x7F02BE0", Offset = "0x7F019E0", VA = "0x187F02BE0", Slot = "0")]
	public override bool Equals(object MKPNGAKJFMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x7F02D70", Offset = "0x7F01B70", VA = "0x187F02D70", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[DisallowMultipleComponent]
	public class AvatarModernBodyDisplayBehaviour : MonoBehaviour, POBGJEIDOFF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		[SerializeField]
		[Header("Configuration")]
		protected AvatarConfiguration configuration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		[SerializeField]
		protected Animator skeletonAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		[SerializeField]
		protected Renderer[] watchRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		[Header("Configuration")]
		[SerializeField]
		private PKNFPGJAIIB avatarBodyType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		[SerializeField]
		private AvatarSkinAssetItem potatoAvatarSkinAssetItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		[FormerlySerializedAs("avatarSkinAsset")]
		[SerializeField]
		private AssetReference avatarSkinAssetReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		[SerializeField]
		private GameObject firstPersonMeshContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		[SerializeField]
		public GameObject thirdPersonMeshContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		[SerializeField]
		private GameObject[] hideInFirstPerson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		[SerializeField]
		protected Transform headAdditiveBaseBoneTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		[FormerlySerializedAs("BodyMaterial")]
		[SerializeField]
		private Material BodyMaterialSkinGradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		[SerializeField]
		private Material BodyMaterialNonGradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		[SerializeField]
		private Material FaceMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		[SerializeField]
		private Material DefaultAvatarItemMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		[SerializeField]
		private Shader AvatarDefaultShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		[SerializeField]
		private Shader AvatarUberShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		[SerializeField]
		private Transform DeformRigRootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		[SerializeField]
		private SkinnedMeshRenderer BaseSkinnedMeshRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		[SerializeField]
		protected AvatarSkinnedMeshBoneOrderRemapsData BoneOrderRemapsData;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		[Header("Arm Animation Controllers")]
		[SerializeField]
		private AvatarForearmRollController LeftForearmRollController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		[SerializeField]
		private AvatarElbowBendHelperController LeftElbowBendHelperController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		[SerializeField]
		private AvatarElbowBendTargetController LeftElbowBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		[SerializeField]
		private AvatarKneeBendTargetController LeftKneeBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		[SerializeField]
		private AvatarForearmRollController RightForearmRollController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		[SerializeField]
		private AvatarElbowBendHelperController RightElbowBendHelperController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		[SerializeField]
		private AvatarElbowBendTargetController RightElbowBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		[SerializeField]
		private AvatarKneeBendTargetController RightKneeBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		[SerializeField]
		private Transform LeftEyeBrowBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		[SerializeField]
		private Transform LeftEyeBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		[SerializeField]
		private Transform RightEyeBrowBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		[SerializeField]
		private Transform RightEyeBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		[SerializeField]
		private Transform NoseMoveTweakBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		[SerializeField]
		private Transform MouthBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		[SerializeField]
		private AvatarBodyPartShapesManager avatarBodyPartShapesManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		[SerializeField]
		private Transform HatAnchorBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		[SerializeField]
		private Transform LeftHandWatchAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		[SerializeField]
		private Transform RightHandWatchAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		[SerializeField]
		private GameObject LeftHandWatchVisuals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		[SerializeField]
		private GameObject RightHandWatchVisuals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		private DKKDNHKBJLF NHJJJCHDOBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		private GLADMCEDLEP OHLPKBGMBPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		private FKLMPLDDLKB JPHNDBLNLHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x400021F")]
		private FKLMPLDDLKB NGCMKKEOIFB;

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public DKKDNHKBJLF CHOFCOCIJLK
		{
			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x7EFBC30", Offset = "0x7EFAA30", VA = "0x187EFBC30", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public GLADMCEDLEP MFIOCIPJPMP
		{
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0x7EFBC80", Offset = "0x7EFAA80", VA = "0x187EFBC80", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public FKLMPLDDLKB KDIOOGJEIHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0x7EFBCD0", Offset = "0x7EFAAD0", VA = "0x187EFBCD0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public FKLMPLDDLKB AAFNBMBFOIN
		{
			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x7EFBD20", Offset = "0x7EFAB20", VA = "0x187EFBD20", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public Transform FDBGHPPJADH
		{
			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0x7EFBD70", Offset = "0x7EFAB70", VA = "0x187EFBD70", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public PKNFPGJAIIB NCIHFOBJIHK
		{
			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0xA5C510", Offset = "0xA5B310", VA = "0x180A5C510", Slot = "12")]
			get
			{
				return default(PKNFPGJAIIB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x7EFACC0", Offset = "0x7EF9AC0", VA = "0x187EFACC0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x7EFBA90", Offset = "0x7EFA890", VA = "0x187EFBA90")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x7EFB060", Offset = "0x7EF9E60", VA = "0x187EFB060", Slot = "8")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x7EFBA90", Offset = "0x7EFA890", VA = "0x187EFBA90", Slot = "9")]
		public void TeardownAvatarDisplaySystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x7EFAD30", Offset = "0x7EF9B30", VA = "0x187EFAD30", Slot = "10")]
		public bool CleanupDisplayMeshes()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x7EFBB40", Offset = "0x7EFA940", VA = "0x187EFBB40")]
		public void UpdatePostIKAnimControllers(float GJELOGAKDKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x7EFB0C0", Offset = "0x7EF9EC0", VA = "0x187EFB0C0")]
		private void JOADACEOHDF(GameObject MKPNGAKJFMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x7EFB490", Offset = "0x7EFA290", VA = "0x187EFB490")]
		private DKKDNHKBJLF NIDBMNOPOIE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x7EFB150", Offset = "0x7EF9F50", VA = "0x187EFB150")]
		private GLADMCEDLEP LEOGPLOJGCM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x7EFB800", Offset = "0x7EFA600", VA = "0x187EFB800")]
		private FKLMPLDDLKB OOEABEBGGBA(LOOMHCPHCKH GCHJHJDBJBG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x7EFBC20", Offset = "0x7EFAA20", VA = "0x187EFBC20")]
		public AvatarModernBodyDisplayBehaviour()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class CNNGGNNJEPE : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	private MaterialPropertyBlock ACBMNAAKEPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000221")]
	public Color? HKNLGBHPOII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	public Color? HIAJLELIIOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	public Color? PDMLDJDIMFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	public Color? BOAHGGNDLPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	public Color LAMLBOELEMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	public Color CMPMFIAMBLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	public Color GBIGDINGKGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000228")]
	public float OADKNCGGPPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	public Texture2D HEEINBMJLCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	public Texture2D JCCAHJKGDBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	private Dictionary<GNMIHPNAIAL, int> BDLHCPMEIFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	private MGDCHFMJKNI[] ENNBNNMKAFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	private OCJFAFENDPC[] OAEDFNMDFBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	public Vector4[] OBPJFLNDJCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	public Vector4[] PGCFJJKLHML;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	public Vector4[] ECMBJIHDBEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	public Vector4[] BLMAGBGPOLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	public Vector4[] CCPBMAAHNCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	public Vector4[] DCNFHNEMDFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	private List<Texture2D> FJNNKDBMMND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	private Vector4[] EMMODJIIMFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	private List<Texture2D> OPLGLDDNCJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	private float[] IEHDAHHEFIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	private Vector4[] BJCKOCFMMKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	private float[] MBOECMEMGKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	public float[] LJPLKPCOBJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	private List<Texture2D> MHOOFGHPKDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	private float[] LEPACNIDILB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	private List<Texture2D> NNNCPHOHCCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	private Vector4[] ABFLEIHFCML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	private float[] BOGEDKPPFPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	private Vector4[] MOJOPFKFJPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	public float[] OENLMGOIOHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	public Texture2DArray ENPGELIGIAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	public Texture2DArray LAGEPLCGGIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	public Texture2DArray IFCJCCLLGGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	public Texture2DArray AEAFDMDCJBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	private bool OKPEEMENDDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18C")]
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	private int KFFKCEEMJPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	private Vector2? GHICHACMICL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19C")]
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	private TextureFormat OCMBBLHJPGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	private Vector2? DPLMIELICMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1AC")]
	[Cpp2IlInjected.Token(Token = "0x400024B")]
	private TextureFormat EFHAOIFKPCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	private Vector2? NJFFKHDGCNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1BC")]
	[Cpp2IlInjected.Token(Token = "0x400024D")]
	private TextureFormat HNKLFEFLMJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x400024E")]
	private Vector2? HLIBHGOEICG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1CC")]
	[Cpp2IlInjected.Token(Token = "0x400024F")]
	private TextureFormat KEEEIJLLKMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
	[Cpp2IlInjected.Token(Token = "0x4000250")]
	private bool FOABPIBDEDN;

	[Cpp2IlInjected.Token(Token = "0x4000251")]
	private static int MICKJDAGHFP;

	[Cpp2IlInjected.Token(Token = "0x4000252")]
	private static int ONPBJMJLILI;

	[Cpp2IlInjected.Token(Token = "0x4000253")]
	private static int LOCBAODKMIM;

	[Cpp2IlInjected.Token(Token = "0x4000254")]
	private static int HDBNOFABHIN;

	[Cpp2IlInjected.Token(Token = "0x4000255")]
	private static int MIHDFBCINJA;

	[Cpp2IlInjected.Token(Token = "0x4000256")]
	private static int IPGDNHEGLMF;

	[Cpp2IlInjected.Token(Token = "0x4000257")]
	private static int LLIGOADIBPN;

	[Cpp2IlInjected.Token(Token = "0x4000258")]
	private static int POMMLCAENJA;

	[Cpp2IlInjected.Token(Token = "0x4000259")]
	private static int CNAIHGCFEOE;

	[Cpp2IlInjected.Token(Token = "0x400025A")]
	private static int CPBNELLEDEC;

	[Cpp2IlInjected.Token(Token = "0x400025B")]
	private static int BBACFAKJOEH;

	[Cpp2IlInjected.Token(Token = "0x400025C")]
	private static int DJGMLJPKGLM;

	[Cpp2IlInjected.Token(Token = "0x400025D")]
	private static int PIKOHBEINLH;

	[Cpp2IlInjected.Token(Token = "0x400025E")]
	private static int NBLBIPCEJPD;

	[Cpp2IlInjected.Token(Token = "0x400025F")]
	private static int PLCMCHIOMDL;

	[Cpp2IlInjected.Token(Token = "0x4000260")]
	private static int GFLAOJLFCFG;

	[Cpp2IlInjected.Token(Token = "0x4000261")]
	private static int GGCNLDNCOMH;

	[Cpp2IlInjected.Token(Token = "0x4000262")]
	private static int LFLDGKFJCAE;

	[Cpp2IlInjected.Token(Token = "0x4000263")]
	private static int IHIODKIGKCD;

	[Cpp2IlInjected.Token(Token = "0x4000264")]
	private static int NMDBCMBLOJI;

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x7EFF490", Offset = "0x7EFE290", VA = "0x187EFF490")]
	private CNNGGNNJEPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x7EFF3D0", Offset = "0x7EFE1D0", VA = "0x187EFF3D0")]
	public CNNGGNNJEPE(Color EGFLLNHKBEE, Color AIBNJLDJMHA, Color GJKHLOMECDO, Color? LDKBGEIOEMH, Color? MCFEBIFJCOF, Color? ODLJFGFPDFO, Texture2D HFCHIJDICJJ, Texture2D ENINNMBNANF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x7EFD1F0", Offset = "0x7EFBFF0", VA = "0x187EFD1F0")]
	internal int GBGCGECAGBB(Material AOJDJKDNKND, MGDCHFMJKNI CAHELPONIAF, OCJFAFENDPC GAOELECEKMD, EEPOCEICAIB GPNKMGAJGEB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x7EFD160", Offset = "0x7EFBF60", VA = "0x187EFD160")]
	private int GBGCGECAGBB(GNMIHPNAIAL MAHBBBBCDEL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x7EFD420", Offset = "0x7EFC220", VA = "0x187EFD420")]
	internal int JKCPJOANPPN(Material AOJDJKDNKND, Color OLHDGFDIIOA, Color OMKJAHDJPJO, Color EGLAFACDEMC, Color AFGHJHCHLLB, Color DELJLGHAGDE, Texture2D MCFOJBMAFJJ, Vector4 FHJOOILPKCC, Texture2D KINMKKKAKAB, Vector4 BOEGLDPJFKJ, float HPFPLICMHKN, float LEDGGEDLGAJ, Texture2D AKOMLBAGIDI, Vector4 DGFEDHFHCIO, float NJHCNJOLFDO, Texture2D NOMLKLLNIHH, Color HAIGDEOEOCH, Vector4 HOCHNCDEGMM, MGDCHFMJKNI CAHELPONIAF, OCJFAFENDPC GAOELECEKMD, EEPOCEICAIB GPNKMGAJGEB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x7EFCE50", Offset = "0x7EFBC50", VA = "0x187EFCE50")]
	private void EINJNFEMELG(List<Texture2D> FJNNKDBMMND, [Out] Texture2DArray EDAAENIEFOE, [Out] Texture2DArray MCDELJJELPF, [Out] Texture2DArray FLINOPOFMPJ, [Out] Texture2DArray LLFKIDNBHJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x7EFECF0", Offset = "0x7EFDAF0", VA = "0x187EFECF0")]
	public void NAJLANDFCMB(Shader GILOJGGDGBN, Renderer MIFBMDMJHAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x7EFDFF0", Offset = "0x7EFCDF0", VA = "0x187EFDFF0")]
	private void MJAIIIEIKBO(Shader GILOJGGDGBN, Renderer MIFBMDMJHAH, int GNLEFLJJCGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x7EFEE40", Offset = "0x7EFDC40", VA = "0x187EFEE40")]
	private Color NEGOCGCKKCK(Color ACOCLDLIKCA, MGDCHFMJKNI NNNBPPHIPHF)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x7EFD010", Offset = "0x7EFBE10", VA = "0x187EFD010")]
	private Color ENDHAPIPLFB(Color AOBEHAPEKIE, MGDCHFMJKNI NNNBPPHIPHF)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x7EFD2C0", Offset = "0x7EFC0C0", VA = "0x187EFD2C0")]
	private bool HOAECJOJAAC(Texture2D AIPIPOFEOMC, OCJFAFENDPC HGGJDFACBPH, [Out] Texture2D GLDAIDFOGFE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x7EFCD60", Offset = "0x7EFBB60", VA = "0x187EFCD60")]
	private void BGPIIDDOBJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x7EFCE10", Offset = "0x7EFBC10", VA = "0x187EFCE10", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public abstract class CEGDNHLGNGK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000268")]
	public readonly EEPOCEICAIB PBGOGNDNPFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x4000269")]
	protected bool FEODHGMNKJK;

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public bool BBIBAHHFABO
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0xB2CDD0", Offset = "0xB2BBD0", VA = "0x180B2CDD0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0xB2CE40", Offset = "0xB2BC40", VA = "0x180B2CE40")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public bool OEIEDAMKPNM
	{
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0xB2CE50", Offset = "0xB2BC50", VA = "0x180B2CE50")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0xB2CE60", Offset = "0xB2BC60", VA = "0x180B2CE60")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public virtual KIECLADILAP.NMBEIOMGMML ODNPBLLKCJB
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0xA59870", Offset = "0xA58670", VA = "0x180A59870", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(KIECLADILAP.NMBEIOMGMML);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0xD70690", Offset = "0xD6F490", VA = "0x180D70690", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public bool MJHELNDNEEL
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x14CAA80", Offset = "0x14C9880", VA = "0x1814CAA80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public bool CKAAMMCOIEC
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x7EFCA50", Offset = "0x7EFB850", VA = "0x187EFCA50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public bool DOOOFBDGAHG
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x7EFCA40", Offset = "0x7EFB840", VA = "0x187EFCA40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public bool ECNHHJBODBK
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x7EFCA20", Offset = "0x7EFB820", VA = "0x187EFCA20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x7EFCA60", Offset = "0x7EFB860", VA = "0x187EFCA60")]
	protected CEGDNHLGNGK(EEPOCEICAIB NPNNBKHKIAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract IDGEJBLICGP ALBFDJMJANI(List<ECOKJONDNDB> LCEFANDJLGA, List<ECOKJONDNDB> EJNELHNHOGD);

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract FBKAKPJJBLC MHFHPMAPAIH(uint IAOFFAAOAHE, AvatarSkinnedMeshBoneOrderRemapsData BFAPBGJNHBF);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public class DIHFDFKBLCJ : ALIBAAMACDC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400026A")]
	private AvatarSkinAssetItem PJCFEPGPFJB;

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x7EFFCB0", Offset = "0x7EFEAB0", VA = "0x187EFFCB0")]
	public DIHFDFKBLCJ(AvatarSkinAssetItem DDOIKDHNBBP, AvatarSkinAssetItem.AMCFCIMPEIC HJMFBGHHJCO, EEPOCEICAIB GPNKMGAJGEB, [Optional] JPHJMMINMCH? FDOFNDOCNAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x7EFFA40", Offset = "0x7EFE840", VA = "0x187EFFA40", Slot = "6")]
	public override IDGEJBLICGP ALBFDJMJANI(List<ECOKJONDNDB> LCEFANDJLGA, List<ECOKJONDNDB> EJNELHNHOGD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class NDFFJENGDNP
{
	[Cpp2IlInjected.Token(Token = "0x400026B")]
	private static readonly int[] GCEIAFIPGGF;

	[Cpp2IlInjected.Token(Token = "0x400026C")]
	private static readonly int[] BLBBECPAONI;

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public static int[] MHHPLGDKEPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x7F08F90", Offset = "0x7F07D90", VA = "0x187F08F90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x7F090A0", Offset = "0x7F07EA0", VA = "0x187F090A0")]
	public static int[] HJCPKGLIAOH(bool KEJMGBDPNHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x7F09010", Offset = "0x7F07E10", VA = "0x187F09010")]
	public static int FPIGOHIHHLB(CNPJGKPMCGN MNCFLIDOJHH, bool KEJMGBDPNHO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x7F08FE0", Offset = "0x7F07DE0", VA = "0x187F08FE0")]
	private static int FBCGEAMOGMM(CNPJGKPMCGN MNCFLIDOJHH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x7F08FF0", Offset = "0x7F07DF0", VA = "0x187F08FF0")]
	private static int FLMMNBHOCON(CNPJGKPMCGN MNCFLIDOJHH)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class FDMGKFBGDKF
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class AEGMHMFFKGE : IEnumerator<DMCHEKCEBGH>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		private DMCHEKCEBGH <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400026F")]
		public JobHandle handle;

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		private DMCHEKCEBGH System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0xA59870", Offset = "0xA58670", VA = "0x180A59870", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0xA59870", Offset = "0xA58670", VA = "0x180A59870", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0xA5BF60", Offset = "0xA5AD60", VA = "0x180A5BF60")]
		[DebuggerHidden]
		public AEGMHMFFKGE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x1442800", Offset = "0x1441600", VA = "0x181442800", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x7EF8220", Offset = "0x7EF7020", VA = "0x187EF8220", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410")]
	public static void BDBAINOJKHA(string PPPFBKMGIMA, int IAOFFAAOAHE, long LKHHKKKLAFH, long CMGNPAHDEKL, long AIMPDOBFCIC, long CONPDICCMGJ, long BIDNAPAMGID, long CLKNPFALDLK, long BCBAIMJOLIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x7EFFDB0", Offset = "0x7EFEBB0", VA = "0x187EFFDB0")]
	public static IHBKINGAIAD FAGCMEADDIA(JobHandle MJDNIJECMIP, bool MIFCJLMKPDI, bool PHKHFMCHADF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x7EFFEA0", Offset = "0x7EFECA0", VA = "0x187EFFEA0")]
	[IteratorStateMachine(typeof(AEGMHMFFKGE))]
	private static IEnumerator<DMCHEKCEBGH> OLKPHPOPNNK(JobHandle DADONNGONOC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class BGEMDCDMLJL
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public enum HHOCIHDMMFM
	{
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		General,
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		ColoredHair
	}

	[Cpp2IlInjected.Token(Token = "0x4000270")]
	public static readonly int LBIJEGMBDAL;

	[Cpp2IlInjected.Token(Token = "0x4000271")]
	public static readonly int EDELMNFELEG;

	[Cpp2IlInjected.Token(Token = "0x4000272")]
	public static readonly int HAFKLFMFKIA;

	[Cpp2IlInjected.Token(Token = "0x4000273")]
	public static readonly int NGIFDCKJPKB;

	[Cpp2IlInjected.Token(Token = "0x4000274")]
	public static readonly int MIGIFKLJLDM;

	[Cpp2IlInjected.Token(Token = "0x4000275")]
	public static readonly int JGFDMPAAAAB;

	[Cpp2IlInjected.Token(Token = "0x4000276")]
	public static readonly int GKKLLKDFBDH;

	[Cpp2IlInjected.Token(Token = "0x4000277")]
	public static readonly int FNBKLGGFGKK;

	[Cpp2IlInjected.Token(Token = "0x4000278")]
	public static readonly int EPHBDBJHMLL;

	[Cpp2IlInjected.Token(Token = "0x4000279")]
	public static readonly int IEFHKBAKDMJ;

	[Cpp2IlInjected.Token(Token = "0x400027A")]
	public static readonly int BINDALHFPAL;

	[Cpp2IlInjected.Token(Token = "0x400027B")]
	public static readonly int HHOMCEFDJMA;

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x7EFBE50", Offset = "0x7EFAC50", VA = "0x187EFBE50")]
	public static bool DDPGIPAONFI(Material KKBOKCGIENM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x7EFBD90", Offset = "0x7EFAB90", VA = "0x187EFBD90")]
	public static bool ACDPCBJHMNC(Material KKBOKCGIENM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class ALIBAAMACDC : CEGDNHLGNGK
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private sealed class GKNKMAEBPAB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000286")]
		public NONKHMPPJIB<GameObject> skinAvatarItemPrefabHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000287")]
		public ALIBAAMACDC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		public Action<string> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public GKNKMAEBPAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x7F026D0", Offset = "0x7F014D0", VA = "0x187F026D0")]
		internal void ABKKGGEMBJL(GameObject result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x7F02AA0", Offset = "0x7F018A0", VA = "0x187F02AA0")]
		internal void BAOFJMLGEOG(string error)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000280")]
	protected AvatarSkinAssetItem DOJKKFALJGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000281")]
	protected Material[] MHEGDMKFGBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000282")]
	private readonly AvatarSkinAssetItem.AMCFCIMPEIC CKJIIHJGJHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000283")]
	private readonly AssetReference HDKAAIMGIHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000284")]
	private readonly JPHJMMINMCH? JCGPBBDHPNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000285")]
	private SkinnedMeshRenderer[] JAFJLNJGGOM;

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public override KIECLADILAP.NMBEIOMGMML ODNPBLLKCJB
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0xA59880", Offset = "0xA58680", VA = "0x180A59880", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(KIECLADILAP.NMBEIOMGMML);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0xA60440", Offset = "0xA5F240", VA = "0x180A60440", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x7EF9500", Offset = "0x7EF8300", VA = "0x187EF9500")]
	public ALIBAAMACDC(AvatarSkinAssetItem.AMCFCIMPEIC HJMFBGHHJCO, AssetReference CNMJIKKKINN, Material MJMJLCPKJMB, EEPOCEICAIB GPNKMGAJGEB, KIECLADILAP.NMBEIOMGMML AJOMMOCNAAC = (KIECLADILAP.NMBEIOMGMML)0L, [Optional] JPHJMMINMCH? FDOFNDOCNAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x7EF9630", Offset = "0x7EF8430", VA = "0x187EF9630")]
	public ALIBAAMACDC(AvatarSkinAssetItem.AMCFCIMPEIC HJMFBGHHJCO, AssetReference CNMJIKKKINN, Material MJMJLCPKJMB, KIECLADILAP.NMBEIOMGMML AJOMMOCNAAC = (KIECLADILAP.NMBEIOMGMML)0L, [Optional] JPHJMMINMCH? FDOFNDOCNAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x7EF9060", Offset = "0x7EF7E60", VA = "0x187EF9060", Slot = "6")]
	public override IDGEJBLICGP ALBFDJMJANI(List<ECOKJONDNDB> LCEFANDJLGA, List<ECOKJONDNDB> EJNELHNHOGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x7EF9280", Offset = "0x7EF8080", VA = "0x187EF9280", Slot = "7")]
	public override FBKAKPJJBLC MHFHPMAPAIH(uint IAOFFAAOAHE, AvatarSkinnedMeshBoneOrderRemapsData BFAPBGJNHBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x7EF9490", Offset = "0x7EF8290", VA = "0x187EF9490", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x7EF9230", Offset = "0x7EF8030", VA = "0x187EF9230")]
	protected void ALKENGGCION()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public class IEENAPGNIOK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000289")]
	private List<int> OAIMJFJJAHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400028A")]
	private List<PIKMIFNIAOL> AACJNAHOCCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400028B")]
	private HashSet<Transform> NNKOCOJGBHF;

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x7F039C0", Offset = "0x7F027C0", VA = "0x187F039C0")]
	public static IEENAPGNIOK NIKPFIBDIIP(Transform ODOKMLFIJNG, Dictionary<Transform, OutfitType?> AHACKEIABIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x7F036A0", Offset = "0x7F024A0", VA = "0x187F036A0")]
	private void CDOHLJILJKC(Transform ODOKMLFIJNG, EEPOCEICAIB GPNKMGAJGEB, Dictionary<Transform, OutfitType?> AHACKEIABIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x7F03B50", Offset = "0x7F02950", VA = "0x187F03B50")]
	private void PKMBGIJCIOI(Transform KGECAEKBFAN, EEPOCEICAIB GPNKMGAJGEB, bool MOCKBEPMPOD, OutfitType? LGFKMEIIJCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x7F03CE0", Offset = "0x7F02AE0", VA = "0x187F03CE0")]
	public AFKFFHBDHHP PLBBPKPLHKO(HashSet<string> LBJLLHOJOGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x7F040D0", Offset = "0x7F02ED0", VA = "0x187F040D0")]
	public IEENAPGNIOK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public class AFKFFHBDHHP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400028C")]
	private List<PIKMIFNIAOL> AACJNAHOCCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400028D")]
	private List<Matrix4x4> MLDJDNPDNED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400028E")]
	private Transform[] FPEHDHDHODB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400028F")]
	private Matrix4x4[] DONMLALIBOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000290")]
	private Dictionary<CNAMJNGKPJL, int> HNCFONCKIIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000291")]
	private List<BMPHDKOGIDG> EJECHCEANNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000292")]
	private bool HNDCJANMPNL;

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public int OOJPJFMJCLH
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x7EF8270", Offset = "0x7EF7070", VA = "0x187EF8270")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public Transform[] IPKCCPCACLP
	{
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x7EF82B0", Offset = "0x7EF70B0", VA = "0x187EF82B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public Matrix4x4[] PEFFPMDAAGG
	{
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x7EF8420", Offset = "0x7EF7220", VA = "0x187EF8420")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x7EF8CF0", Offset = "0x7EF7AF0", VA = "0x187EF8CF0")]
	public void PKMBGIJCIOI(Transform KGECAEKBFAN, EEPOCEICAIB GPNKMGAJGEB, OutfitType? LGFKMEIIJCG, bool JOAFGPCHKFJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x7EF8980", Offset = "0x7EF7780", VA = "0x187EF8980")]
	private void PKMBGIJCIOI(Transform KGECAEKBFAN, EEPOCEICAIB GPNKMGAJGEB, OutfitType? LGFKMEIIJCG, bool JOAFGPCHKFJ, Matrix4x4 ADAKGJHPIEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x7EF86D0", Offset = "0x7EF74D0", VA = "0x187EF86D0")]
	public int ONALHDPLCDF(CNAMJNGKPJL MAHBBBBCDEL, bool HFCNGHIJKID, [Optional] OutfitType? LGFKMEIIJCG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x7EF8880", Offset = "0x7EF7680", VA = "0x187EF8880")]
	public int OPJLGIKEJGI(EEPOCEICAIB GPNKMGAJGEB, [Optional] OutfitType? LGFKMEIIJCG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x7EF8490", Offset = "0x7EF7290", VA = "0x187EF8490")]
	public void NFOGJAGGIPK(CNAMJNGKPJL MAHBBBBCDEL, Matrix4x4 PMCEKDPNDNF, bool HFCNGHIJKID = false, [Optional] OutfitType? LGFKMEIIJCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x7EF8580", Offset = "0x7EF7380", VA = "0x187EF8580")]
	public Matrix4x4 OKMJAGCCKEP(CNAMJNGKPJL MAHBBBBCDEL, bool HFCNGHIJKID, [Optional] OutfitType? LGFKMEIIJCG)
	{
		return default(Matrix4x4);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0xDD7270", Offset = "0xDD6070", VA = "0x180DD7270")]
	public void FPLFAKNPIOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x7EF8EF0", Offset = "0x7EF7CF0", VA = "0x187EF8EF0")]
	public AFKFFHBDHHP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public struct CNAMJNGKPJL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000296")]
	public readonly string HLOCEIHJEPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000297")]
	public readonly EEPOCEICAIB NLJJOPOPIOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000298")]
	public readonly OutfitType? BBNLFLCLOLN;

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x7EFCD20", Offset = "0x7EFBB20", VA = "0x187EFCD20")]
	public CNAMJNGKPJL(string GFAKNNDBMFM, EEPOCEICAIB GPNKMGAJGEB, [Optional] OutfitType? LGFKMEIIJCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x7EFCC70", Offset = "0x7EFBA70", VA = "0x187EFCC70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x7EFCBB0", Offset = "0x7EFB9B0", VA = "0x187EFCBB0")]
	public bool IDJKLHLFCIN(CNAMJNGKPJL LOKLFHKEJPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x7EFCA90", Offset = "0x7EFB890", VA = "0x187EFCA90", Slot = "0")]
	public override bool Equals(object MKPNGAKJFMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x7EFCB40", Offset = "0x7EFB940", VA = "0x187EFCB40", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public struct BMPHDKOGIDG : IEquatable<BMPHDKOGIDG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000299")]
	public readonly EEPOCEICAIB NLJJOPOPIOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400029A")]
	public readonly OutfitType? PKOGBMPCPLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400029B")]
	public readonly int GILBNNENONK;

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x7EFC460", Offset = "0x7EFB260", VA = "0x187EFC460")]
	public BMPHDKOGIDG(EEPOCEICAIB GPNKMGAJGEB, int GMMGMKEICAM, [Optional] OutfitType? GIHAPMLPAIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x7EFC390", Offset = "0x7EFB190", VA = "0x187EFC390", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x71030F0", Offset = "0x7101EF0", VA = "0x1871030F0")]
	public bool OMMBJIIMMJL(EEPOCEICAIB GPNKMGAJGEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x7EFC2C0", Offset = "0x7EFB0C0", VA = "0x187EFC2C0")]
	public bool GJLDNCKEHAB(OutfitType? GIHAPMLPAIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x7EFC270", Offset = "0x7EFB070", VA = "0x187EFC270", Slot = "4")]
	public bool Equals(BMPHDKOGIDG LOKLFHKEJPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x7EFC180", Offset = "0x7EFAF80", VA = "0x187EFC180", Slot = "0")]
	public override bool Equals(object MKPNGAKJFMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x7EFC340", Offset = "0x7EFB140", VA = "0x187EFC340", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public struct PIKMIFNIAOL : IEquatable<PIKMIFNIAOL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400029C")]
	public readonly Transform CHFNKJHLMKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400029D")]
	public readonly bool JENLHBIJLNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x400029E")]
	public readonly EEPOCEICAIB LOICMKONIAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400029F")]
	public readonly OutfitType? BBNLFLCLOLN;

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x7F0BAC0", Offset = "0x7F0A8C0", VA = "0x187F0BAC0")]
	public PIKMIFNIAOL(Transform KGECAEKBFAN, bool MOCKBEPMPOD, EEPOCEICAIB GDFNJOEPJMA, [Optional] OutfitType? IJPKEIOAJPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x7F0B8A0", Offset = "0x7F0A6A0", VA = "0x187F0B8A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x7F0B640", Offset = "0x7F0A440", VA = "0x187F0B640", Slot = "4")]
	public bool Equals(PIKMIFNIAOL LOKLFHKEJPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x7F0B740", Offset = "0x7F0A540", VA = "0x187F0B740", Slot = "0")]
	public override bool Equals(object MKPNGAKJFMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x7F0B820", Offset = "0x7F0A620", VA = "0x187F0B820", Slot = "2")]
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
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		public const float DEFAULT_Y_POSITION_OFFSET = 0.04f;

		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		public const float MAX_HEMISPHERE_POSITION_OFFSET = 0.05f;

		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		public const float MAX_HEMISPHERE_ROTATION_OFFSET = 45f;

		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		public const float MAX_HEMISPHERE_SCALE = 2f;

		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		public const float MIN_HEMISPHERE_SCALE = 0.75f;

		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		public const float MAX_HEMISPHERE_RADIUS = 0.25f;

		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		public const float MIN_HEMISPHERE_RADIUS = 0.125f;

		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		public static GameObject ContainerGO;

		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		public static GameObject CurrentHairHemisphereGO;

		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		public static Transform CurrentHairHemisphereMeshTransform;

		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		public static FitMeshHemisphereUpdater CurrentHairHemisphereUpdater;

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x7F02660", Offset = "0x7F01460", VA = "0x187F02660")]
		public static void DespawnHairHemisphere()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410")]
		public void UpdateValues()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0xA58400", Offset = "0xA57200", VA = "0x180A58400")]
		public FitMeshHemisphereUpdater()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public interface MDMGFDPOPNC
{
	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BDONGONABHC(Mesh JLPONKINLEO, Matrix4x4 OEJBOPLGCGK, byte[] PKOGGKHKMCH, bool KNJDCHCMDMA = false, KIECLADILAP.NMBEIOMGMML BOCHMGMBKKO = (KIECLADILAP.NMBEIOMGMML)0L, int LEKJKGJFHHP = -1, bool FHDMKCNLHAF = false);

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ALFBPEOLLOC(Allocator DFGMDNGNOEN, JPLNFBHFPMI NGKCAGOOJBA, byte ENKJEANPOIA, [Optional] IList<int> FFIMIPGOEJB, [Optional] IList<int> AEJKLDOFPKJ);
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public readonly struct BLMJBKFLGDK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002AB")]
	public readonly GameObject AMMDDADMDEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40002AC")]
	private readonly AvatarItemMaterial NJFGHJGAMHO;

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0xBC8270", Offset = "0xBC7070", VA = "0x180BC8270")]
	public BLMJBKFLGDK(GameObject AMMDDADMDEL, AvatarItemMaterial NJFGHJGAMHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x7EFC0F0", Offset = "0x7EFAEF0", VA = "0x187EFC0F0")]
	public void PKADEFALDAG(Material KKBOKCGIENM, int CABFKOOGELP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public class MCPCBGLLENK : PNPGDGKPOAD<Task<(GameObject, AvatarItemMaterial)>, BLMJBKFLGDK>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private struct FFJGHBHPIMD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		public AsyncTaskMethodBuilder<(GameObject, AvatarItemMaterial)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		public Task<GameObject> goTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		public Task<AvatarItemMaterial> materialTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		private GameObject <go>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		private TaskAwaiter<GameObject> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		private TaskAwaiter<AvatarItemMaterial> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x7EFFF10", Offset = "0x7EFED10", VA = "0x187EFFF10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x7F00410", Offset = "0x7EFF210", VA = "0x187F00410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002AD")]
	private NONKHMPPJIB<GameObject> FOBJMDABENC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002AE")]
	private NONKHMPPJIB<AvatarItemMaterial> KMNEIJKKEBA;

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x7F08050", Offset = "0x7F06E50", VA = "0x187F08050")]
	private MCPCBGLLENK(Task<(GameObject, AvatarItemMaterial)> JNOGJECEFDN, NONKHMPPJIB<GameObject> JBGECEHDLLI, NONKHMPPJIB<AvatarItemMaterial> HMIPPAKCLCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x7F07A80", Offset = "0x7F06880", VA = "0x187F07A80")]
	public static MCPCBGLLENK LDFHHMLGJNG(AssetReference DCKFMCEGCDO, [Optional] AssetReference OCAGCNOBKPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x7F079E0", Offset = "0x7F067E0", VA = "0x187F079E0", Slot = "11")]
	protected override BLMJBKFLGDK HONOJPILCNC(Task<(GameObject, AvatarItemMaterial)> EDJHELAPGNK)
	{
		return default(BLMJBKFLGDK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x7F07FD0", Offset = "0x7F06DD0", VA = "0x187F07FD0", Slot = "12")]
	protected override void PIMJEPFJMIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x7F07EA0", Offset = "0x7F06CA0", VA = "0x187F07EA0")]
	[AsyncStateMachine(typeof(FFJGHBHPIMD))]
	private static Task<(GameObject, AvatarItemMaterial)> OIADAKHDJIA(Task<GameObject> MDEMJOGDPOD, Task<AvatarItemMaterial> NCEFIEDPPFH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public static class KCIAOCENGNC
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private class CANIFGJHIFF : PNPGDGKPOAD<Task<MaterialMapAsset>, Material[]>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		private NONKHMPPJIB<MaterialMapAsset> DADONNGONOC;

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x7EFC940", Offset = "0x7EFB740", VA = "0x187EFC940")]
		public CANIFGJHIFF(NONKHMPPJIB<MaterialMapAsset> DADONNGONOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x7EFC470", Offset = "0x7EFB270", VA = "0x187EFC470", Slot = "11")]
		protected override Material[] HONOJPILCNC(Task<MaterialMapAsset> JNOGJECEFDN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x7EFC8E0", Offset = "0x7EFB6E0", VA = "0x187EFC8E0", Slot = "12")]
		protected override void PIMJEPFJMIL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	private class IDDEJDGJIHM : PNPGDGKPOAD<Task<Material[]>, Material[]>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		private List<NONKHMPPJIB<Material>> FLKIPICBFGF;

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x7F03630", Offset = "0x7F02430", VA = "0x187F03630")]
		public IDDEJDGJIHM(Task<Material[]> JNOGJECEFDN, List<NONKHMPPJIB<Material>> FLKIPICBFGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x7F034A0", Offset = "0x7F022A0", VA = "0x187F034A0", Slot = "11")]
		protected override Material[] HONOJPILCNC(Task<Material[]> EDJHELAPGNK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x7F034F0", Offset = "0x7F022F0", VA = "0x187F034F0", Slot = "12")]
		protected override void PIMJEPFJMIL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40002B9")]
	private static readonly PHLHEDGDBJO CFEMPAINFAM;

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x7F04200", Offset = "0x7F03000", VA = "0x187F04200")]
	public static NONKHMPPJIB<Material[]> NGAAFNHCCKN(AssetReference[] ILILAPMIPOA)
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
		public enum NHLNBKPOAGN
		{
			[Cpp2IlInjected.Token(Token = "0x400034B")]
			None,
			[Cpp2IlInjected.Token(Token = "0x400034C")]
			TeamItem,
			[Cpp2IlInjected.Token(Token = "0x400034D")]
			SkinColor,
			[Cpp2IlInjected.Token(Token = "0x400034E")]
			HairColor,
			[Cpp2IlInjected.Token(Token = "0x400034F")]
			BeardColor,
			[Cpp2IlInjected.Token(Token = "0x4000350")]
			UGCShirtColor
		}

		[Cpp2IlInjected.Token(Token = "0x2000057")]
		public enum HEFPCAHEOKB
		{
			[Cpp2IlInjected.Token(Token = "0x4000352")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4000353")]
			HairTexture,
			[Cpp2IlInjected.Token(Token = "0x4000354")]
			BeardTexture,
			[Cpp2IlInjected.Token(Token = "0x4000355")]
			UGCShirtTexture
		}

		[Cpp2IlInjected.Token(Token = "0x2000058")]
		public enum LKBBNBOOBLP : byte
		{
			[Cpp2IlInjected.Token(Token = "0x4000357")]
			All,
			[Cpp2IlInjected.Token(Token = "0x4000358")]
			LOD0Only,
			[Cpp2IlInjected.Token(Token = "0x4000359")]
			EditorToolAll
		}

		[Cpp2IlInjected.Token(Token = "0x2000059")]
		public struct BNIHPDMFJGI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400035A")]
			public readonly Material OHKKCFOKAEM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400035B")]
			public readonly NHLNBKPOAGN OJGHCJFDIAG;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x400035C")]
			public readonly HEFPCAHEOKB DBAECAGMOHN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400035D")]
			public readonly EEPOCEICAIB NLJJOPOPIOB;

			[Cpp2IlInjected.Token(Token = "0x60002F7")]
			[Cpp2IlInjected.Address(RVA = "0x7F1C4A0", Offset = "0x7F1B2A0", VA = "0x187F1C4A0")]
			public BNIHPDMFJGI(Material KKBOKCGIENM, NHLNBKPOAGN CAHELPONIAF, HEFPCAHEOKB GAOELECEKMD, EEPOCEICAIB GPNKMGAJGEB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F8")]
			[Cpp2IlInjected.Address(RVA = "0x7F1C270", Offset = "0x7F1B070", VA = "0x187F1C270", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002F9")]
			[Cpp2IlInjected.Address(RVA = "0x7F1C1F0", Offset = "0x7F1AFF0", VA = "0x187F1C1F0")]
			public bool IDJKLHLFCIN(BNIHPDMFJGI LOKLFHKEJPC)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002FA")]
			[Cpp2IlInjected.Address(RVA = "0x7F1C060", Offset = "0x7F1AE60", VA = "0x187F1C060", Slot = "0")]
			public override bool Equals(object MKPNGAKJFMP)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002FB")]
			[Cpp2IlInjected.Address(RVA = "0x7F1C150", Offset = "0x7F1AF50", VA = "0x187F1C150", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005A")]
		protected class PFELFMBJGMJ : IComparable<PFELFMBJGMJ>, IEquatable<PFELFMBJGMJ>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400035E")]
			public int LJGIDAPNPGK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400035F")]
			public PlayerAvatarDisplayBase KMHKNGKODJN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000360")]
			public IList<GGEFJGKFMHN> MNOGBHGFNOF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000361")]
			public AvatarItemBodyType HJAKKAMHPNG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000362")]
			public JBOCHFILNBO NPEHGPCIOAF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000363")]
			public bool MKCEIGCIOHC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
			[Cpp2IlInjected.Token(Token = "0x4000364")]
			public bool KGLJHPBADFD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000365")]
			public int[] EKOLFMDDEAD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000366")]
			public float CDCBBIHPMMN;

			[Cpp2IlInjected.Token(Token = "0x60002FC")]
			[Cpp2IlInjected.Address(RVA = "0x7F23250", Offset = "0x7F22050", VA = "0x187F23250", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002FD")]
			[Cpp2IlInjected.Address(RVA = "0x7F23100", Offset = "0x7F21F00", VA = "0x187F23100", Slot = "4")]
			public int CompareTo(PFELFMBJGMJ LOKLFHKEJPC)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002FE")]
			[Cpp2IlInjected.Address(RVA = "0x7F23130", Offset = "0x7F21F30", VA = "0x187F23130", Slot = "5")]
			public bool Equals(PFELFMBJGMJ LOKLFHKEJPC)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002FF")]
			[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
			public PFELFMBJGMJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005B")]
		protected abstract class CACEEBPIEBP
		{
			[Cpp2IlInjected.Token(Token = "0x200005C")]
			public class DIANBHHJCHE
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400036A")]
				public readonly Mesh COIEPNIHABN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400036B")]
				public readonly Material[] PGHMFBFLLKF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400036C")]
				public readonly Transform[] PHIEOCKNAEH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400036D")]
				public readonly Matrix4x4[] FGJEPKKPBNI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400036E")]
				public readonly Transform OJMNIOPFOOM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x400036F")]
				public readonly bool JCFOCOLEOGA;

				[Cpp2IlInjected.Token(Token = "0x6000307")]
				[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
				protected DIANBHHJCHE()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000308")]
				[Cpp2IlInjected.Address(RVA = "0x7F1CCB0", Offset = "0x7F1BAB0", VA = "0x187F1CCB0")]
				public DIANBHHJCHE(Mesh JLPONKINLEO, Material[] JJIFGKJAOAK, bool CJIAKOPEPPF, Transform[] HHNJKGDJJAI, Transform ONKLHMGJANL, Matrix4x4[] PIIJACPDFKB)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000309")]
				[Cpp2IlInjected.Address(RVA = "0x7F1D250", Offset = "0x7F1C050", VA = "0x187F1D250")]
				private DIANBHHJCHE(SkinnedMeshRenderer OJGKICIDJAB, Material[] OBPGGJPDFPN)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600030A")]
				[Cpp2IlInjected.Address(RVA = "0x7F1D160", Offset = "0x7F1BF60", VA = "0x187F1D160")]
				private DIANBHHJCHE(MeshRenderer GFEOCBFNCNK, Transform ONKLHMGJANL, Material[] OBPGGJPDFPN)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600030B")]
				[Cpp2IlInjected.Address(RVA = "0x7F1C990", Offset = "0x7F1B790", VA = "0x187F1C990")]
				public static DIANBHHJCHE KFCCEOKLEDB(Renderer MIFBMDMJHAH, Material[] OBPGGJPDFPN)
				{
					return null;
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000367")]
			public readonly EEPOCEICAIB NLJJOPOPIOB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000368")]
			public readonly Transform IEJNKNKALMJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000369")]
			public readonly bool KEHGAEGCEHE;

			[Cpp2IlInjected.Token(Token = "0x1700008F")]
			public virtual bool BBIBAHHFABO
			{
				[Cpp2IlInjected.Token(Token = "0x6000300")]
				[Cpp2IlInjected.Address(RVA = "0xAA3480", Offset = "0xAA2280", VA = "0x180AA3480", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000090")]
			public virtual bool OEIEDAMKPNM
			{
				[Cpp2IlInjected.Token(Token = "0x6000301")]
				[Cpp2IlInjected.Address(RVA = "0xAA3480", Offset = "0xAA2280", VA = "0x180AA3480", Slot = "5")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000091")]
			public virtual KIECLADILAP.NMBEIOMGMML ODNPBLLKCJB
			{
				[Cpp2IlInjected.Token(Token = "0x6000302")]
				[Cpp2IlInjected.Address(RVA = "0xA58420", Offset = "0xA57220", VA = "0x180A58420", Slot = "6")]
				get
				{
					return default(KIECLADILAP.NMBEIOMGMML);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000092")]
			public bool ONPEIMNCJPP
			{
				[Cpp2IlInjected.Token(Token = "0x6000303")]
				[Cpp2IlInjected.Address(RVA = "0x7F1C4E0", Offset = "0x7F1B2E0", VA = "0x187F1C4E0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000304")]
			[Cpp2IlInjected.Address(RVA = "0x7F1C4F0", Offset = "0x7F1B2F0", VA = "0x187F1C4F0")]
			protected CACEEBPIEBP(EEPOCEICAIB GPNKMGAJGEB, Transform HJHDMAIFFEK, bool NBIBNCNHAGL = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000305")]
			[Cpp2IlInjected.Address(Slot = "7")]
			public abstract IDGEJBLICGP ALBFDJMJANI(List<ECOKJONDNDB> LCEFANDJLGA, List<ECOKJONDNDB> EJNELHNHOGD);

			[Cpp2IlInjected.Token(Token = "0x6000306")]
			[Cpp2IlInjected.Address(Slot = "8")]
			public abstract DIANBHHJCHE MHFHPMAPAIH(int IAOFFAAOAHE, PlayerHandBones OIKIBHMEELM);
		}

		[Cpp2IlInjected.Token(Token = "0x200005D")]
		protected class MHFJDGIPIPP : CACEEBPIEBP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000370")]
			protected readonly BodyPartLODs JAFJLNJGGOM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000371")]
			protected readonly Material[] MHEGDMKFGBM;

			[Cpp2IlInjected.Token(Token = "0x600030C")]
			[Cpp2IlInjected.Address(RVA = "0x7F225A0", Offset = "0x7F213A0", VA = "0x187F225A0")]
			public MHFJDGIPIPP(EEPOCEICAIB GPNKMGAJGEB, BodyPartLODs FPNIMNLEJEB, Material MJMJLCPKJMB, [Optional] Transform HJHDMAIFFEK, bool NBIBNCNHAGL = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600030D")]
			[Cpp2IlInjected.Address(RVA = "0x7F222E0", Offset = "0x7F210E0", VA = "0x187F222E0", Slot = "7")]
			public override IDGEJBLICGP ALBFDJMJANI(List<ECOKJONDNDB> LCEFANDJLGA, List<ECOKJONDNDB> EJNELHNHOGD)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600030E")]
			[Cpp2IlInjected.Address(RVA = "0x7F22370", Offset = "0x7F21170", VA = "0x187F22370", Slot = "8")]
			public override DIANBHHJCHE MHFHPMAPAIH(int IAOFFAAOAHE, PlayerHandBones OIKIBHMEELM)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600030F")]
			[Cpp2IlInjected.Address(RVA = "0x7F22530", Offset = "0x7F21330", VA = "0x187F22530", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005E")]
		protected class JKBGFHMJHCJ : CACEEBPIEBP
		{
			[Cpp2IlInjected.Token(Token = "0x17000093")]
			public override bool BBIBAHHFABO
			{
				[Cpp2IlInjected.Token(Token = "0x6000310")]
				[Cpp2IlInjected.Address(RVA = "0xA735B0", Offset = "0xA723B0", VA = "0x180A735B0", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000094")]
			public override bool OEIEDAMKPNM
			{
				[Cpp2IlInjected.Token(Token = "0x6000311")]
				[Cpp2IlInjected.Address(RVA = "0x7F1E520", Offset = "0x7F1D320", VA = "0x187F1E520", Slot = "5")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000095")]
			public OIIBFCOFLED LCKJIHFBOBA
			{
				[Cpp2IlInjected.Token(Token = "0x6000312")]
				[Cpp2IlInjected.Address(RVA = "0xA59880", Offset = "0xA58680", VA = "0x180A59880")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000313")]
				[Cpp2IlInjected.Address(RVA = "0xA59830", Offset = "0xA58630", VA = "0x180A59830")]
				[CompilerGenerated]
				protected set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000314")]
			[Cpp2IlInjected.Address(RVA = "0x7F1E5E0", Offset = "0x7F1D3E0", VA = "0x187F1E5E0")]
			public JKBGFHMJHCJ(EEPOCEICAIB GPNKMGAJGEB, Transform HJHDMAIFFEK, OIIBFCOFLED OCIOFNMNEBB, bool NBIBNCNHAGL = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000315")]
			[Cpp2IlInjected.Address(RVA = "0x7F1E490", Offset = "0x7F1D290", VA = "0x187F1E490", Slot = "7")]
			public override IDGEJBLICGP ALBFDJMJANI(List<ECOKJONDNDB> LCEFANDJLGA, List<ECOKJONDNDB> EJNELHNHOGD)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000316")]
			[Cpp2IlInjected.Address(RVA = "0xA58420", Offset = "0xA57220", VA = "0x180A58420", Slot = "8")]
			public override DIANBHHJCHE MHFHPMAPAIH(int IAOFFAAOAHE, PlayerHandBones OIKIBHMEELM)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000317")]
			[Cpp2IlInjected.Address(RVA = "0x7F1E570", Offset = "0x7F1D370", VA = "0x187F1E570", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005F")]
		public class ABDHJFDNJJI
		{
			[Cpp2IlInjected.Token(Token = "0x2000060")]
			public enum FFHBOALMPDH
			{
				[Cpp2IlInjected.Token(Token = "0x4000383")]
				PLAYER_PUPPET,
				[Cpp2IlInjected.Token(Token = "0x4000384")]
				PLAYER_DISPLAY_POSER,
				[Cpp2IlInjected.Token(Token = "0x4000385")]
				PLAYER_HAND,
				[Cpp2IlInjected.Token(Token = "0x4000386")]
				STNMONSTERCOSTUME_OPTION_HIDE_EXCEPT_UI,
				[Cpp2IlInjected.Token(Token = "0x4000387")]
				PLAYER_HAND_POINTING,
				[Cpp2IlInjected.Token(Token = "0x4000388")]
				STNMONSTERCOSTUME_OPTION_ALWAYS_HIDE,
				[Cpp2IlInjected.Token(Token = "0x4000389")]
				EDITOR
			}

			[Cpp2IlInjected.Token(Token = "0x4000373")]
			public static readonly int KFNLFCNHKHN;

			[Cpp2IlInjected.Token(Token = "0x4000374")]
			public static readonly int GKCBGIPIPHE;

			[Cpp2IlInjected.Token(Token = "0x4000375")]
			public static readonly int HALBHHDLKCH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000376")]
			protected readonly LOOMHCPHCKH GCHJHJDBJBG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000377")]
			protected readonly HJDFGFBBPBO BJBGIAGIFGC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000378")]
			protected readonly Animator NLOMEFIPNDN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000379")]
			protected readonly Transform HAFJDFJHMLG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400037A")]
			public Vector3 AOIGKJHEDAI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400037B")]
			protected readonly Transform CKDPKMIMBMN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400037C")]
			public Vector3 CNFNMELOOBM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x400037D")]
			protected bool KDLLLGJEOGJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400037E")]
			protected FKLMPLDDLKB LNFPFPIOEPI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400037F")]
			protected bool GNICBAFLHPD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
			[Cpp2IlInjected.Token(Token = "0x4000380")]
			protected float KOHDJIHLCCE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000381")]
			protected DDCPOGLAFMM<GDNBFNJLEDA> CGHJMGDOJIB;

			[Cpp2IlInjected.Token(Token = "0x17000096")]
			public FKLMPLDDLKB GKLLDMMBAOL
			{
				[Cpp2IlInjected.Token(Token = "0x6000318")]
				[Cpp2IlInjected.Address(RVA = "0xA5F330", Offset = "0xA5E130", VA = "0x180A5F330")]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000319")]
				[Cpp2IlInjected.Address(RVA = "0xA5F370", Offset = "0xA5E170", VA = "0x180A5F370")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000097")]
			public bool BMNCGOBAOIN
			{
				[Cpp2IlInjected.Token(Token = "0x600031A")]
				[Cpp2IlInjected.Address(RVA = "0xD16540", Offset = "0xD15340", VA = "0x180D16540")]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x600031B")]
				[Cpp2IlInjected.Address(RVA = "0x7F1B2F0", Offset = "0x7F1A0F0", VA = "0x187F1B2F0")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000098")]
			public bool AOLOGADINAK
			{
				[Cpp2IlInjected.Token(Token = "0x600031C")]
				[Cpp2IlInjected.Address(RVA = "0xA604E0", Offset = "0xA5F2E0", VA = "0x180A604E0")]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x600031D")]
				[Cpp2IlInjected.Address(RVA = "0x7F1B860", Offset = "0x7F1A660", VA = "0x187F1B860")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000099")]
			public float AIPELBKILCC
			{
				[Cpp2IlInjected.Token(Token = "0x600031E")]
				[Cpp2IlInjected.Address(RVA = "0xDA13F0", Offset = "0xDA01F0", VA = "0x180DA13F0")]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x600031F")]
				[Cpp2IlInjected.Address(RVA = "0x7F1AD40", Offset = "0x7F19B40", VA = "0x187F1AD40")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009A")]
			public GDNBFNJLEDA JMAPLMHJFEA
			{
				[Cpp2IlInjected.Token(Token = "0x6000320")]
				[Cpp2IlInjected.Address(RVA = "0x7F1B3C0", Offset = "0x7F1A1C0", VA = "0x187F1B3C0")]
				get
				{
					return default(GDNBFNJLEDA);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000321")]
			[Cpp2IlInjected.Address(RVA = "0x7F1AFD0", Offset = "0x7F19DD0", VA = "0x187F1AFD0")]
			public bool BNDMJKDCMEK(GDNBFNJLEDA ABCHEMHPBGJ, object OCGDLEBGIMO, FFHBOALMPDH HNGPPDLEICO)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000322")]
			[Cpp2IlInjected.Address(RVA = "0x7F1B1F0", Offset = "0x7F19FF0", VA = "0x187F1B1F0")]
			public bool DIMBHFJAJGI(object OCGDLEBGIMO)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000323")]
			[Cpp2IlInjected.Address(RVA = "0x7F1B9E0", Offset = "0x7F1A7E0", VA = "0x187F1B9E0")]
			protected ABDHJFDNJJI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000324")]
			[Cpp2IlInjected.Address(RVA = "0x7F1BA70", Offset = "0x7F1A870", VA = "0x187F1BA70")]
			public ABDHJFDNJJI(LOOMHCPHCKH GCHJHJDBJBG, FKLMPLDDLKB IMIGEFHNJBD, Animator NLOMEFIPNDN, Transform HAFJDFJHMLG, Transform CKDPKMIMBMN, Vector3 AOIGKJHEDAI, Vector3 CNFNMELOOBM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000325")]
			[Cpp2IlInjected.Address(RVA = "0x7F1B7B0", Offset = "0x7F1A5B0", VA = "0x187F1B7B0")]
			private void NAHIDBIIILC(ushort BMKPALFHCKE, ushort CDPCNMEMJFF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000326")]
			[Cpp2IlInjected.Address(RVA = "0x7F1AEE0", Offset = "0x7F19CE0", VA = "0x187F1AEE0")]
			protected void ALFCCLOJBIC(ushort BMKPALFHCKE, ushort CDPCNMEMJFF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000327")]
			[Cpp2IlInjected.Address(RVA = "0x7F1B130", Offset = "0x7F19F30", VA = "0x187F1B130")]
			protected void DFMHEKLCHMF(ushort BMKPALFHCKE, ushort CDPCNMEMJFF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000328")]
			[Cpp2IlInjected.Address(RVA = "0x7F1B520", Offset = "0x7F1A320", VA = "0x187F1B520")]
			protected void HHHBDIIIMJH(ushort BMKPALFHCKE, ushort CDPCNMEMJFF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000329")]
			[Cpp2IlInjected.Address(RVA = "0x7F1B650", Offset = "0x7F1A450", VA = "0x187F1B650")]
			protected void JKBHLGLAHLO(ushort BMKPALFHCKE, ushort CDPCNMEMJFF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600032A")]
			[Cpp2IlInjected.Address(RVA = "0x7F1AE80", Offset = "0x7F19C80", VA = "0x187F1AE80")]
			protected void AGCABAPLNBA(ushort BMKPALFHCKE, ushort CDPCNMEMJFF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600032B")]
			[Cpp2IlInjected.Address(RVA = "0x7F1B760", Offset = "0x7F1A560", VA = "0x187F1B760")]
			protected void KGBJFHMGNOJ(ushort BMKPALFHCKE, ushort CDPCNMEMJFF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600032C")]
			[Cpp2IlInjected.Address(RVA = "0x7F1B0E0", Offset = "0x7F19EE0", VA = "0x187F1B0E0")]
			protected void CKJECGALLEF(ushort BMKPALFHCKE, ushort CDPCNMEMJFF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600032D")]
			[Cpp2IlInjected.Address(RVA = "0x7F1B400", Offset = "0x7F1A200", VA = "0x187F1B400")]
			protected void GCDOOHNODMG(ushort BMKPALFHCKE, ushort CDPCNMEMJFF)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000061")]
		public class LMKLNGHHDKI : IDisposable
		{
			[Cpp2IlInjected.Token(Token = "0x400038A")]
			public const int PPKMFADFJPP = 16;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400038B")]
			protected MaterialPropertyBlock ACBMNAAKEPC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400038C")]
			public Color? HKNLGBHPOII;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x400038D")]
			public Color? PDMLDJDIMFF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400038E")]
			public Color? BOAHGGNDLPO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x400038F")]
			public Color LAMLBOELEMF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
			[Cpp2IlInjected.Token(Token = "0x4000390")]
			public Color CMPMFIAMBLA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
			[Cpp2IlInjected.Token(Token = "0x4000391")]
			public Color GBIGDINGKGO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x4000392")]
			public Texture2D HEEINBMJLCA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x4000393")]
			public Texture2D JCCAHJKGDBN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x4000394")]
			protected Dictionary<BNIHPDMFJGI, int> BDLHCPMEIFH;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x4000395")]
			protected NHLNBKPOAGN[] ENNBNNMKAFB;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x4000396")]
			public Vector4[] OBPJFLNDJCL;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x4000397")]
			public Vector4[] PGCFJJKLHML;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x4000398")]
			public Vector4[] ECMBJIHDBEL;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x4000399")]
			public Vector4[] BLMAGBGPOLP;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
			[Cpp2IlInjected.Token(Token = "0x400039A")]
			public Vector4[] CCPBMAAHNCH;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
			[Cpp2IlInjected.Token(Token = "0x400039B")]
			public Vector4[] DCNFHNEMDFD;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x400039C")]
			protected List<Texture2D> FJNNKDBMMND;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x400039D")]
			protected Vector4[] EMMODJIIMFP;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
			[Cpp2IlInjected.Token(Token = "0x400039E")]
			protected List<Texture2D> OPLGLDDNCJN;

			[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
			[Cpp2IlInjected.Token(Token = "0x400039F")]
			protected float[] IEHDAHHEFIN;

			[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
			[Cpp2IlInjected.Token(Token = "0x40003A0")]
			protected Vector4[] BJCKOCFMMKH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
			[Cpp2IlInjected.Token(Token = "0x40003A1")]
			protected float[] MBOECMEMGKC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
			[Cpp2IlInjected.Token(Token = "0x40003A2")]
			public float[] LJPLKPCOBJB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
			[Cpp2IlInjected.Token(Token = "0x40003A3")]
			protected List<Texture2D> MHOOFGHPKDB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
			[Cpp2IlInjected.Token(Token = "0x40003A4")]
			protected float[] LEPACNIDILB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
			[Cpp2IlInjected.Token(Token = "0x40003A5")]
			protected List<Texture2D> NNNCPHOHCCB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
			[Cpp2IlInjected.Token(Token = "0x40003A6")]
			protected Vector4[] ABFLEIHFCML;

			[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
			[Cpp2IlInjected.Token(Token = "0x40003A7")]
			protected float[] BOGEDKPPFPO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
			[Cpp2IlInjected.Token(Token = "0x40003A8")]
			protected Vector4[] MOJOPFKFJPK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
			[Cpp2IlInjected.Token(Token = "0x40003A9")]
			public float[] OENLMGOIOHH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
			[Cpp2IlInjected.Token(Token = "0x40003AA")]
			public Texture2DArray ENPGELIGIAO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
			[Cpp2IlInjected.Token(Token = "0x40003AB")]
			public Texture2DArray LAGEPLCGGIM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
			[Cpp2IlInjected.Token(Token = "0x40003AC")]
			public Texture2DArray IFCJCCLLGGG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
			[Cpp2IlInjected.Token(Token = "0x40003AD")]
			public Texture2DArray AEAFDMDCJBM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
			[Cpp2IlInjected.Token(Token = "0x40003AE")]
			protected bool OKPEEMENDDM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x16C")]
			[Cpp2IlInjected.Token(Token = "0x40003AF")]
			protected int KFFKCEEMJPB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
			[Cpp2IlInjected.Token(Token = "0x40003B0")]
			protected Vector2? GHICHACMICL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x17C")]
			[Cpp2IlInjected.Token(Token = "0x40003B1")]
			protected TextureFormat OCMBBLHJPGC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
			[Cpp2IlInjected.Token(Token = "0x40003B2")]
			protected Vector2? DPLMIELICMO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18C")]
			[Cpp2IlInjected.Token(Token = "0x40003B3")]
			protected TextureFormat EFHAOIFKPCF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
			[Cpp2IlInjected.Token(Token = "0x40003B4")]
			protected Vector2? NJFFKHDGCNG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x19C")]
			[Cpp2IlInjected.Token(Token = "0x40003B5")]
			protected TextureFormat HNKLFEFLMJN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
			[Cpp2IlInjected.Token(Token = "0x40003B6")]
			protected Vector2? HLIBHGOEICG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1AC")]
			[Cpp2IlInjected.Token(Token = "0x40003B7")]
			protected TextureFormat KEEEIJLLKMC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
			[Cpp2IlInjected.Token(Token = "0x40003B8")]
			protected bool FOABPIBDEDN;

			[Cpp2IlInjected.Token(Token = "0x40003B9")]
			protected static int MICKJDAGHFP;

			[Cpp2IlInjected.Token(Token = "0x40003BA")]
			protected static int ONPBJMJLILI;

			[Cpp2IlInjected.Token(Token = "0x40003BB")]
			protected static int LOCBAODKMIM;

			[Cpp2IlInjected.Token(Token = "0x40003BC")]
			protected static int HDBNOFABHIN;

			[Cpp2IlInjected.Token(Token = "0x40003BD")]
			protected static int MIHDFBCINJA;

			[Cpp2IlInjected.Token(Token = "0x40003BE")]
			protected static int IPGDNHEGLMF;

			[Cpp2IlInjected.Token(Token = "0x40003BF")]
			protected static int LLIGOADIBPN;

			[Cpp2IlInjected.Token(Token = "0x40003C0")]
			protected static int POMMLCAENJA;

			[Cpp2IlInjected.Token(Token = "0x40003C1")]
			protected static int CNAIHGCFEOE;

			[Cpp2IlInjected.Token(Token = "0x40003C2")]
			protected static int CPBNELLEDEC;

			[Cpp2IlInjected.Token(Token = "0x40003C3")]
			protected static int BBACFAKJOEH;

			[Cpp2IlInjected.Token(Token = "0x40003C4")]
			protected static int DJGMLJPKGLM;

			[Cpp2IlInjected.Token(Token = "0x40003C5")]
			protected static int PIKOHBEINLH;

			[Cpp2IlInjected.Token(Token = "0x40003C6")]
			protected static int NBLBIPCEJPD;

			[Cpp2IlInjected.Token(Token = "0x40003C7")]
			protected static int PLCMCHIOMDL;

			[Cpp2IlInjected.Token(Token = "0x40003C8")]
			protected static int GFLAOJLFCFG;

			[Cpp2IlInjected.Token(Token = "0x40003C9")]
			protected static int GGCNLDNCOMH;

			[Cpp2IlInjected.Token(Token = "0x40003CA")]
			protected static int LFLDGKFJCAE;

			[Cpp2IlInjected.Token(Token = "0x40003CB")]
			protected static int IHIODKIGKCD;

			[Cpp2IlInjected.Token(Token = "0x40003CC")]
			protected static int NMDBCMBLOJI;

			[Cpp2IlInjected.Token(Token = "0x600032F")]
			[Cpp2IlInjected.Address(RVA = "0x7F21AE0", Offset = "0x7F208E0", VA = "0x187F21AE0")]
			protected LMKLNGHHDKI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000330")]
			[Cpp2IlInjected.Address(RVA = "0x7F21FA0", Offset = "0x7F20DA0", VA = "0x187F21FA0")]
			public LMKLNGHHDKI(Color EGFLLNHKBEE, Color AIBNJLDJMHA, Color GJKHLOMECDO, Color? LDKBGEIOEMH, Color? MCFEBIFJCOF, Color? ODLJFGFPDFO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000331")]
			[Cpp2IlInjected.Address(RVA = "0x7F1F880", Offset = "0x7F1E680", VA = "0x187F1F880")]
			public int GBGCGECAGBB(Material AOJDJKDNKND, NHLNBKPOAGN CAHELPONIAF, HEFPCAHEOKB GAOELECEKMD, EEPOCEICAIB GPNKMGAJGEB)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000332")]
			[Cpp2IlInjected.Address(RVA = "0x7F1F7F0", Offset = "0x7F1E5F0", VA = "0x187F1F7F0")]
			public int GBGCGECAGBB(BNIHPDMFJGI MAHBBBBCDEL)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000333")]
			[Cpp2IlInjected.Address(RVA = "0x7F1F970", Offset = "0x7F1E770", VA = "0x187F1F970")]
			public int JKCPJOANPPN(Material AOJDJKDNKND, Color OLHDGFDIIOA, Color OMKJAHDJPJO, Color EGLAFACDEMC, Color AFGHJHCHLLB, Color DELJLGHAGDE, Texture2D MCFOJBMAFJJ, Vector4 FHJOOILPKCC, Texture2D KINMKKKAKAB, Vector4 BOEGLDPJFKJ, float HPFPLICMHKN, float LEDGGEDLGAJ, Texture2D AKOMLBAGIDI, Vector4 DGFEDHFHCIO, float NJHCNJOLFDO, Texture2D NOMLKLLNIHH, float HPPHNKFDPEG, Color HAIGDEOEOCH, Vector4 HOCHNCDEGMM, NHLNBKPOAGN CAHELPONIAF, HEFPCAHEOKB GAOELECEKMD, EEPOCEICAIB GPNKMGAJGEB)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000334")]
			[Cpp2IlInjected.Address(RVA = "0x7F1F630", Offset = "0x7F1E430", VA = "0x187F1F630")]
			protected void EINJNFEMELG([Out] Texture2DArray EDAAENIEFOE, [Out] Texture2DArray MCDELJJELPF, [Out] Texture2DArray FLINOPOFMPJ, [Out] Texture2DArray LLFKIDNBHJD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000335")]
			[Cpp2IlInjected.Address(RVA = "0x7F212F0", Offset = "0x7F200F0", VA = "0x187F212F0")]
			public void NAJLANDFCMB(PlayerAvatarDisplayBase HEEOBGMPCBG, Renderer MIFBMDMJHAH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000336")]
			[Cpp2IlInjected.Address(RVA = "0x7F207C0", Offset = "0x7F1F5C0", VA = "0x187F207C0")]
			protected void MJAIIIEIKBO(PlayerAvatarDisplayBase HEEOBGMPCBG, Renderer MIFBMDMJHAH, int GNLEFLJJCGN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000337")]
			[Cpp2IlInjected.Address(RVA = "0x7F21560", Offset = "0x7F20360", VA = "0x187F21560")]
			private Color NEGOCGCKKCK(Color ACOCLDLIKCA, NHLNBKPOAGN NNNBPPHIPHF)
			{
				return default(Color);
			}

			[Cpp2IlInjected.Token(Token = "0x6000338")]
			[Cpp2IlInjected.Address(RVA = "0x7F20670", Offset = "0x7F1F470", VA = "0x187F20670")]
			private Color KLJIHKMDDAK(Color JGIKJIADOEM, NHLNBKPOAGN NNNBPPHIPHF)
			{
				return default(Color);
			}

			[Cpp2IlInjected.Token(Token = "0x6000339")]
			[Cpp2IlInjected.Address(RVA = "0x7F1F560", Offset = "0x7F1E360", VA = "0x187F1F560")]
			protected void BGPIIDDOBJK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600033A")]
			[Cpp2IlInjected.Address(RVA = "0x7F1F5F0", Offset = "0x7F1E3F0", VA = "0x187F1F5F0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000062")]
		public struct PlayerHandBones
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003CD")]
			public Transform[] LeftHandBones;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003CE")]
			public Transform LeftHandRoot;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003CF")]
			public Transform[] RightHandBones;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003D0")]
			public Transform RightHandRoot;

			[Cpp2IlInjected.Token(Token = "0x600033C")]
			[Cpp2IlInjected.Address(RVA = "0x7F29BB0", Offset = "0x7F289B0", VA = "0x187F29BB0")]
			public void ABPPEPHNNOD(EEPOCEICAIB GPNKMGAJGEB, [Out] Transform EGPDFGOHLFM, [Out] Transform[] HHNJKGDJJAI)
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000063")]
		protected struct BodyPartLODs
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003D1")]
			public Mesh[] LODs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003D2")]
			public bool UseHandBones;
		}

		[Cpp2IlInjected.Token(Token = "0x2000065")]
		[CompilerGenerated]
		private sealed class KOPELDHDAFH : IEnumerable<SkinnedMeshRenderer>, IEnumerable, IEnumerator<SkinnedMeshRenderer>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003DA")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003DB")]
			private SkinnedMeshRenderer <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003DC")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003DD")]
			public PlayerAvatarDisplayBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003DE")]
			private SkinnedMeshRenderer[] <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003DF")]
			private int <>7__wrap2;

			[Cpp2IlInjected.Token(Token = "0x1700009B")]
			SkinnedMeshRenderer IEnumerator<SkinnedMeshRenderer>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000348")]
				[Cpp2IlInjected.Address(RVA = "0xA59870", Offset = "0xA58670", VA = "0x180A59870", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009C")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600034A")]
				[Cpp2IlInjected.Address(RVA = "0xA59870", Offset = "0xA58670", VA = "0x180A59870", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000345")]
			[Cpp2IlInjected.Address(RVA = "0xF9A0D0", Offset = "0xF98ED0", VA = "0x180F9A0D0")]
			[DebuggerHidden]
			public KOPELDHDAFH(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000346")]
			[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000347")]
			[Cpp2IlInjected.Address(RVA = "0x7F1E9F0", Offset = "0x7F1D7F0", VA = "0x187F1E9F0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000349")]
			[Cpp2IlInjected.Address(RVA = "0x7F1EC70", Offset = "0x7F1DA70", VA = "0x187F1EC70", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034B")]
			[Cpp2IlInjected.Address(RVA = "0x7F1EBC0", Offset = "0x7F1D9C0", VA = "0x187F1EBC0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<SkinnedMeshRenderer> IEnumerable<SkinnedMeshRenderer>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600034C")]
			[Cpp2IlInjected.Address(RVA = "0x7F1EBC0", Offset = "0x7F1D9C0", VA = "0x187F1EBC0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000066")]
		[CompilerGenerated]
		private sealed class OEJDNEMNNAC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003E0")]
			public PlayerAvatarDisplayBase display;

			[Cpp2IlInjected.Token(Token = "0x600034D")]
			[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
			public OEJDNEMNNAC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034E")]
			[Cpp2IlInjected.Address(RVA = "0x7F228B0", Offset = "0x7F216B0", VA = "0x187F228B0")]
			internal bool IDAKEGKPJKC()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000067")]
		[CompilerGenerated]
		private sealed class JKGAIOGNMLL : IEnumerator<DMCHEKCEBGH>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003E1")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003E2")]
			private DMCHEKCEBGH <>2__current;

			[Cpp2IlInjected.Token(Token = "0x1700009D")]
			private DMCHEKCEBGH System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000352")]
				[Cpp2IlInjected.Address(RVA = "0xA59870", Offset = "0xA58670", VA = "0x180A59870", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009E")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000354")]
				[Cpp2IlInjected.Address(RVA = "0xA59870", Offset = "0xA58670", VA = "0x180A59870", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600034F")]
			[Cpp2IlInjected.Address(RVA = "0xA5BF60", Offset = "0xA5AD60", VA = "0x180A5BF60")]
			[DebuggerHidden]
			public JKGAIOGNMLL(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000350")]
			[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000351")]
			[Cpp2IlInjected.Address(RVA = "0x7F1E650", Offset = "0x7F1D450", VA = "0x187F1E650", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000353")]
			[Cpp2IlInjected.Address(RVA = "0x7F1E9A0", Offset = "0x7F1D7A0", VA = "0x187F1E9A0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000068")]
		[CompilerGenerated]
		private struct LIIBDPLMACA : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003E3")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003E4")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003E5")]
			public PlayerAvatarDisplayBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003E6")]
			public MAMJKFCNJKC avatarData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003E7")]
			private bool <forceRebuild>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003E8")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000355")]
			[Cpp2IlInjected.Address(RVA = "0x7F1ECC0", Offset = "0x7F1DAC0", VA = "0x187F1ECC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000356")]
			[Cpp2IlInjected.Address(RVA = "0x7F1F060", Offset = "0x7F1DE60", VA = "0x187F1F060", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000069")]
		[CompilerGenerated]
		private sealed class PODGACCGEEO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003E9")]
			public string overrideIdentifier;

			[Cpp2IlInjected.Token(Token = "0x6000357")]
			[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
			public PODGACCGEEO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000358")]
			[Cpp2IlInjected.Address(RVA = "0x7F233A0", Offset = "0x7F221A0", VA = "0x187F233A0")]
			internal bool MHAKALHECLB(GGEFJGKFMHN selection)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006A")]
		[CompilerGenerated]
		private sealed class MHBAGDPGHNP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003EA")]
			public PlayerAvatarDisplayBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003EB")]
			public AvatarItemBodyType avatarItemBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003EC")]
			public Func<CEBCBDBEPBJ<Dictionary<string, NONKHMPPJIB<Texture2D>>>> <>9__2;

			[Cpp2IlInjected.Token(Token = "0x6000359")]
			[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
			public MHBAGDPGHNP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600035A")]
			[Cpp2IlInjected.Address(RVA = "0x7F220E0", Offset = "0x7F20EE0", VA = "0x187F220E0")]
			internal (IHGBKKPAEJC, CEBCBDBEPBJ<Dictionary<string, NONKHMPPJIB<Texture2D>>>) LLPDJAGHEII(Dictionary<string, MAJDLGCOKCC> avatarItems)
			{
				return default((IHGBKKPAEJC, CEBCBDBEPBJ<Dictionary<string, NONKHMPPJIB<Texture2D>>>));
			}

			[Cpp2IlInjected.Token(Token = "0x600035B")]
			[Cpp2IlInjected.Address(RVA = "0x7F22030", Offset = "0x7F20E30", VA = "0x187F22030")]
			internal CEBCBDBEPBJ<Dictionary<string, NONKHMPPJIB<Texture2D>>> JAKBBPFBAFB()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600035C")]
			[Cpp2IlInjected.Address(RVA = "0x7F220A0", Offset = "0x7F20EA0", VA = "0x187F220A0")]
			internal void LKKAPKBPBMM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006B")]
		[CompilerGenerated]
		private sealed class FAHIINLLMBA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003ED")]
			public Transform transformToCheck;

			[Cpp2IlInjected.Token(Token = "0x600035D")]
			[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
			public FAHIINLLMBA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600035E")]
			[Cpp2IlInjected.Address(RVA = "0x7F1D310", Offset = "0x7F1C110", VA = "0x187F1D310")]
			internal bool LMKAHMEIFOJ(SkinnedMeshRenderer x)
			{
				return default(bool);
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200006C")]
		[CompilerGenerated]
		private struct GNEFMEODFEC : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003EE")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003EF")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003F0")]
			public PlayerAvatarDisplayBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003F1")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600035F")]
			[Cpp2IlInjected.Address(RVA = "0x7F1DFD0", Offset = "0x7F1CDD0", VA = "0x187F1DFD0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000360")]
			[Cpp2IlInjected.Address(RVA = "0x7F1E1A0", Offset = "0x7F1CFA0", VA = "0x187F1E1A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		protected static readonly int LLJAIMAADBC;

		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		protected static readonly int HEKOLIKFFED;

		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		protected static readonly int HGODPNENMOD;

		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		protected static readonly int EABOFCKFFBA;

		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		protected static readonly int MNLOBDIKBIC;

		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		protected static readonly int HAKPAIODNFG;

		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		protected static readonly int[] LJNJBCGLLOF;

		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		protected static readonly int[] NMGOAIDNCIA;

		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		protected static readonly int[] NFMCPECNDBF;

		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		protected static readonly int[] KJFINJNMHJL;

		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		protected static readonly int[] KMAGFCGLJEM;

		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		protected static readonly int[] CPGGANPBENB;

		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		protected static List<PlayerAvatarDisplayBase> OBMBFNFAEAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		protected GFLNPIGKFCH NGMKMJFMOMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		protected bool AHODLJHECNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x45")]
		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		protected bool HPCHLDKOPOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		[SerializeField]
		public AvatarBodyShapeVault BodyShapeVault;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		[SerializeField]
		public AvatarFaceShapeVault FaceShapeVault;

		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		protected static readonly int[] AOJKHDEDLIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		[SerializeField]
		protected Material bodyPartMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		protected Dictionary<BNIHPDMFJGI, Material> EGPALMNNMND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		protected Dictionary<BNIHPDMFJGI, Material> LNDLPAPAKDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		[SerializeField]
		protected bool ignorePlayerMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		[SerializeField]
		protected Transform trackingSpace;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		[SerializeField]
		protected BodyPartLODs Head;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		[SerializeField]
		protected BodyPartLODs Ear;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		[SerializeField]
		protected BodyPartLODs Torso;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		[SerializeField]
		protected BodyPartLODs Hand;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		[SerializeField]
		protected BodyPartLODs HandPointing;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		[SerializeField]
		public PlayerHandBones HandBones;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		[SerializeField]
		public Transform remoteMeshBase;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		public readonly SkinnedMeshRenderer[] CurrentDefaultSkinnedMeshRenderers;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		public readonly SkinnedMeshRenderer[] NextDefaultSkinnedMeshRenderers;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		public readonly SkinnedMeshRenderer[] CurrentVisibleInFirstPersonSkinnedMeshRenderers;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		public readonly SkinnedMeshRenderer[] NextVisibleInFirstPersonSkinnedMeshRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		[SerializeField]
		public Transform firstPersonMeshBase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		[SerializeField]
		protected Shader uberShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		[SerializeField]
		protected Shader agAvatarShader;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		protected Material GCBCKJLECLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		protected DKKDNHKBJLF FFFEFPFLGDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		private FKLMPLDDLKB JPHNDBLNLHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		private FKLMPLDDLKB NGCMKKEOIFB;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		protected Material EKNPHBDLGIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		[SerializeField]
		protected Transform headPropAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		[SerializeField]
		protected Transform hatAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		[SerializeField]
		public Transform hemisphereBase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		protected FitMeshHemisphere NJABDLABMOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		protected bool MICLPCINCBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		protected BHJLPMKOMMK LIKMOFHHMMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		protected bool LOFAONDJIMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		protected AnchorParamsRestrictions OIOOFDNECEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		protected bool OGOBNABGJIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		protected Transform IJNIDAJOHDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		protected bool GAGAGCHBJEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B1")]
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		protected bool ODFGNJNKLGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B4")]
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		protected Vector3 EKLNMHAMBPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x4000300")]
		protected Quaternion CAEOEGFIJMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x4000301")]
		protected Vector2 CJALHJJOJDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x4000302")]
		protected FitMeshHemisphere BCJBBDJDOAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		[SerializeField]
		[LHHMDDGFBKD(NKIOFDIBBLL.SelfAndChildren, false, false, false)]
		protected PlayerFacialAnimatorBase facialAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		[SerializeField]
		protected Transform torsoPropAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		[SerializeField]
		protected Transform torsoRootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		[SerializeField]
		protected Transform headRootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		[SerializeField]
		protected Transform leftHandRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		[SerializeField]
		protected Transform leftHandDefaultScaleRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
		[Cpp2IlInjected.Token(Token = "0x4000309")]
		[SerializeField]
		protected Transform rightHandRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
		[Cpp2IlInjected.Token(Token = "0x400030A")]
		[SerializeField]
		protected Transform rightHandDefaultScaleRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
		[Cpp2IlInjected.Token(Token = "0x400030B")]
		[SerializeField]
		protected Animator leftHandAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
		[Cpp2IlInjected.Token(Token = "0x400030C")]
		[SerializeField]
		protected Animator rightHandAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
		[Cpp2IlInjected.Token(Token = "0x400030D")]
		[SerializeField]
		protected Transform leftHandPointingRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
		[Cpp2IlInjected.Token(Token = "0x400030E")]
		[SerializeField]
		protected Transform rightHandPointingRoot;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
		[Cpp2IlInjected.Token(Token = "0x400030F")]
		protected Collider[] LNEAJIAODOH;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
		[Cpp2IlInjected.Token(Token = "0x4000310")]
		protected Collider[] AMCAOJDMMIK;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
		[Cpp2IlInjected.Token(Token = "0x4000311")]
		protected ABDHJFDNJJI[] DAJNCJLPJDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
		[Cpp2IlInjected.Token(Token = "0x4000312")]
		[SerializeField]
		protected Mesh faceMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x4000313")]
		public Dictionary<Renderer, LMKLNGHHDKI> currentPropertyBlocks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
		[Cpp2IlInjected.Token(Token = "0x4000314")]
		protected Dictionary<Renderer, LMKLNGHHDKI> HPEPLAOGFME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
		[Cpp2IlInjected.Token(Token = "0x4000315")]
		protected IEENAPGNIOK PFEJNIJPMBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		protected IHGBKKPAEJC EMDPLOJMAOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
		[Cpp2IlInjected.Token(Token = "0x4000317")]
		public CNPJGKPMCGN DistanceBand;

		[Cpp2IlInjected.FieldOffset(Offset = "0x284")]
		[Cpp2IlInjected.Token(Token = "0x4000318")]
		protected int BLMFDPOPNDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
		[Cpp2IlInjected.Token(Token = "0x4000319")]
		protected (bool isLodForced, int forcedLOD) BDIMLBJOBNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
		[Cpp2IlInjected.Token(Token = "0x400031A")]
		protected DDCPOGLAFMM<HJDFGFBBPBO> CGHJMGDOJIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
		[Cpp2IlInjected.Token(Token = "0x400031B")]
		protected bool JEEHBMJKJPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
		[Cpp2IlInjected.Token(Token = "0x400031D")]
		protected Dictionary<GGEFJGKFMHN, List<BNIHPDMFJGI>> OGKHCDJPLLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
		[Cpp2IlInjected.Token(Token = "0x400031E")]
		protected Dictionary<GGEFJGKFMHN, List<BNIHPDMFJGI>> KDODBCGKLPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B0")]
		[Cpp2IlInjected.Token(Token = "0x400031F")]
		protected readonly Dictionary<string, NONKHMPPJIB<Texture2D>> GOLAGFBJPCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B8")]
		[Cpp2IlInjected.Token(Token = "0x4000320")]
		protected readonly Dictionary<string, NONKHMPPJIB<Texture2D>> ECCMGOGPLNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C0")]
		[Cpp2IlInjected.Token(Token = "0x4000321")]
		protected bool AFLMJJDENLA;

		[Cpp2IlInjected.Token(Token = "0x4000323")]
		protected static int CFDCKDEDMAH;

		[Cpp2IlInjected.Token(Token = "0x4000324")]
		protected static List<PFELFMBJGMJ> MLCOLOMFMEB;

		[Cpp2IlInjected.Token(Token = "0x4000325")]
		protected static List<PFELFMBJGMJ> LFDDAJLLJLF;

		[Cpp2IlInjected.Token(Token = "0x4000326")]
		protected static IHBKINGAIAD MPKJIJMGBNF;

		[Cpp2IlInjected.Token(Token = "0x4000327")]
		protected static Func<List<PFELFMBJGMJ>, PFELFMBJGMJ> OPGINKNKCLA;

		[Cpp2IlInjected.Token(Token = "0x4000328")]
		protected static bool ADDFJODAAKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D0")]
		[Cpp2IlInjected.Token(Token = "0x4000329")]
		protected Color? EJLDOANKANC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E4")]
		[Cpp2IlInjected.Token(Token = "0x400032A")]
		protected bool HHBNOPPDMGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E8")]
		[Cpp2IlInjected.Token(Token = "0x400032B")]
		protected Color NMHJDFNCMJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2F8")]
		[Cpp2IlInjected.Token(Token = "0x400032C")]
		protected Color KBJGDAPLPBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x308")]
		[Cpp2IlInjected.Token(Token = "0x400032D")]
		protected Color LPPOHFIJBFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x318")]
		[Cpp2IlInjected.Token(Token = "0x400032E")]
		protected AvatarHairPattern NBHHPBJBODN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x320")]
		[Cpp2IlInjected.Token(Token = "0x400032F")]
		protected OIIBFCOFLED OJOLMEPPGOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x328")]
		[Cpp2IlInjected.Token(Token = "0x4000330")]
		protected Color LEINBMEEGBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x338")]
		[Cpp2IlInjected.Token(Token = "0x4000331")]
		protected Color AMOHIFNKKBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x348")]
		[Cpp2IlInjected.Token(Token = "0x4000332")]
		protected AvatarHairPattern GJBPINNFEGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x350")]
		[Cpp2IlInjected.Token(Token = "0x4000333")]
		protected OIIBFCOFLED DIPOMNOBFGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x358")]
		[Cpp2IlInjected.Token(Token = "0x4000334")]
		protected OIIBFCOFLED FLODKACFFGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x360")]
		[Cpp2IlInjected.Token(Token = "0x4000335")]
		protected Color JHKGLMOJBMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x370")]
		[Cpp2IlInjected.Token(Token = "0x4000336")]
		private AdditionalFeetData JMKAEAOCEBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x378")]
		[Cpp2IlInjected.Token(Token = "0x4000337")]
		protected GGEFJGKFMHN? JHIJHLMMODE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x390")]
		[Cpp2IlInjected.Token(Token = "0x4000338")]
		protected Texture GDCEMBDCHOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x398")]
		[Cpp2IlInjected.Token(Token = "0x4000339")]
		protected Color NNDJEIJIJCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A8")]
		[Cpp2IlInjected.Token(Token = "0x400033A")]
		protected readonly IList<GGEFJGKFMHN> AAMPENHCGBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3B0")]
		[Cpp2IlInjected.Token(Token = "0x400033B")]
		protected readonly IList<GGEFJGKFMHN> MLEFNCOIACC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3B8")]
		[Cpp2IlInjected.Token(Token = "0x400033C")]
		private AvatarItemBodyType PLIBFJGKJMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C0")]
		[Cpp2IlInjected.Token(Token = "0x400033D")]
		[SerializeField]
		protected AvatarFaceShape _currentFaceShape;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C8")]
		[Cpp2IlInjected.Token(Token = "0x400033E")]
		[SerializeField]
		protected AvatarBodyShape _currentBodyShape;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D0")]
		[Cpp2IlInjected.Token(Token = "0x400033F")]
		[SerializeField]
		protected BDLLACEJLDO _currentNoseType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D4")]
		[Cpp2IlInjected.Token(Token = "0x4000340")]
		[SerializeField]
		protected bool _hideEars;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D5")]
		[Cpp2IlInjected.Token(Token = "0x4000341")]
		protected LKBBNBOOBLP AKCIBODKCCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D8")]
		[Cpp2IlInjected.Token(Token = "0x4000342")]
		protected int[] DCCAJPOMPHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3E0")]
		[Cpp2IlInjected.Token(Token = "0x4000343")]
		protected bool MFANGDFKNCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3E8")]
		[Cpp2IlInjected.Token(Token = "0x4000344")]
		protected int[] OEJBGGLBPKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3F0")]
		[Cpp2IlInjected.Token(Token = "0x4000345")]
		protected bool GMBAMPNIGAA;

		[Cpp2IlInjected.Token(Token = "0x4000346")]
		private static readonly KIECLADILAP.NMBEIOMGMML OIDFLNLJKHH;

		[Cpp2IlInjected.Token(Token = "0x4000347")]
		private static readonly KIECLADILAP.NMBEIOMGMML DHGIEGNIDIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3F1")]
		[Cpp2IlInjected.Token(Token = "0x4000348")]
		protected bool OFFFFFKJHCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3F8")]
		[Cpp2IlInjected.Token(Token = "0x4000349")]
		protected KMFBMBBKEMD NJAIGFFIIOG;

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public string OMALPIMDAMH
		{
			[Cpp2IlInjected.Token(Token = "0x600022F")]
			[Cpp2IlInjected.Address(RVA = "0xA5C130", Offset = "0xA5AF30", VA = "0x180A5C130")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000230")]
			[Cpp2IlInjected.Address(RVA = "0xA604F0", Offset = "0xA5F2F0", VA = "0x180A604F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public bool MEJJIOKFDLP
		{
			[Cpp2IlInjected.Token(Token = "0x6000232")]
			[Cpp2IlInjected.Address(RVA = "0xD10C20", Offset = "0xD0FA20", VA = "0x180D10C20")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000233")]
			[Cpp2IlInjected.Address(RVA = "0xD10040", Offset = "0xD0EE40", VA = "0x180D10040")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public virtual bool FONHAILMGCH
		{
			[Cpp2IlInjected.Token(Token = "0x6000234")]
			[Cpp2IlInjected.Address(RVA = "0xAA3480", Offset = "0xAA2280", VA = "0x180AA3480", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public bool POIOLCFNEBG
		{
			[Cpp2IlInjected.Token(Token = "0x6000235")]
			[Cpp2IlInjected.Address(RVA = "0x7F196D0", Offset = "0x7F184D0", VA = "0x187F196D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public virtual bool KGNMHEPDEJA
		{
			[Cpp2IlInjected.Token(Token = "0x6000236")]
			[Cpp2IlInjected.Address(RVA = "0xAA3480", Offset = "0xAA2280", VA = "0x180AA3480", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public virtual bool MJFOABELJGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000237")]
			[Cpp2IlInjected.Address(RVA = "0xA735B0", Offset = "0xA723B0", VA = "0x180A735B0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public virtual bool EFGIMADLAHD
		{
			[Cpp2IlInjected.Token(Token = "0x6000238")]
			[Cpp2IlInjected.Address(RVA = "0xAA3480", Offset = "0xAA2280", VA = "0x180AA3480", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public virtual bool GPGEOLKCJLO
		{
			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0xAA3480", Offset = "0xAA2280", VA = "0x180AA3480", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public DKKDNHKBJLF CHEOCMJHINJ
		{
			[Cpp2IlInjected.Token(Token = "0x600023B")]
			[Cpp2IlInjected.Address(RVA = "0xBB6A10", Offset = "0xBB5810", VA = "0x180BB6A10")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600023C")]
			[Cpp2IlInjected.Address(RVA = "0x7F19EA0", Offset = "0x7F18CA0", VA = "0x187F19EA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public FKLMPLDDLKB KDIOOGJEIHK
		{
			[Cpp2IlInjected.Token(Token = "0x600023D")]
			[Cpp2IlInjected.Address(RVA = "0xBAAC50", Offset = "0xBA9A50", VA = "0x180BAAC50")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600023E")]
			[Cpp2IlInjected.Address(RVA = "0x7F1A2A0", Offset = "0x7F190A0", VA = "0x187F1A2A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public FKLMPLDDLKB AAFNBMBFOIN
		{
			[Cpp2IlInjected.Token(Token = "0x600023F")]
			[Cpp2IlInjected.Address(RVA = "0xBC4B60", Offset = "0xBC3960", VA = "0x180BC4B60")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000240")]
			[Cpp2IlInjected.Address(RVA = "0x7F1A570", Offset = "0x7F19370", VA = "0x187F1A570")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		protected Material FOEDLEAHPPN
		{
			[Cpp2IlInjected.Token(Token = "0x6000241")]
			[Cpp2IlInjected.Address(RVA = "0x7F118C0", Offset = "0x7F106C0", VA = "0x187F118C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		protected Material HGOOJAEDJHN
		{
			[Cpp2IlInjected.Token(Token = "0x6000242")]
			[Cpp2IlInjected.Address(RVA = "0x7F132C0", Offset = "0x7F120C0", VA = "0x187F132C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public bool DJHOKKEKGIN
		{
			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0x2434240", Offset = "0x2433040", VA = "0x182434240")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public PlayerFacialAnimatorBase FHHNJLDBMMG
		{
			[Cpp2IlInjected.Token(Token = "0x6000247")]
			[Cpp2IlInjected.Address(RVA = "0xBC4D60", Offset = "0xBC3B60", VA = "0x180BC4D60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public ABDHJFDNJJI[] EJAEFMINIOB
		{
			[Cpp2IlInjected.Token(Token = "0x6000248")]
			[Cpp2IlInjected.Address(RVA = "0x7F19250", Offset = "0x7F18050", VA = "0x187F19250")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public ABDHJFDNJJI LKGLIIBHLBG
		{
			[Cpp2IlInjected.Token(Token = "0x6000249")]
			[Cpp2IlInjected.Address(RVA = "0x7F198D0", Offset = "0x7F186D0", VA = "0x187F198D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public ABDHJFDNJJI LIHGAGJJMIG
		{
			[Cpp2IlInjected.Token(Token = "0x600024A")]
			[Cpp2IlInjected.Address(RVA = "0x7F19910", Offset = "0x7F18710", VA = "0x187F19910")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public Mesh EHDBGIONEDH
		{
			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0xBC54B0", Offset = "0xBC42B0", VA = "0x180BC54B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		protected IEENAPGNIOK FJPOOMHFENA
		{
			[Cpp2IlInjected.Token(Token = "0x600024C")]
			[Cpp2IlInjected.Address(RVA = "0x7F0E170", Offset = "0x7F0CF70", VA = "0x187F0E170")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		protected IHGBKKPAEJC MIMLPGLDACP
		{
			[Cpp2IlInjected.Token(Token = "0x600024D")]
			[Cpp2IlInjected.Address(RVA = "0xBC5840", Offset = "0xBC4640", VA = "0x180BC5840")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600024E")]
			[Cpp2IlInjected.Address(RVA = "0x7F133B0", Offset = "0x7F121B0", VA = "0x187F133B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		protected bool PHKHFMCHADF
		{
			[Cpp2IlInjected.Token(Token = "0x600024F")]
			[Cpp2IlInjected.Address(RVA = "0xA735B0", Offset = "0xA723B0", VA = "0x180A735B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public bool LKKGFJDICAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000250")]
			[Cpp2IlInjected.Address(RVA = "0x7F198C0", Offset = "0x7F186C0", VA = "0x187F198C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public int NGPFOLNAFAM
		{
			[Cpp2IlInjected.Token(Token = "0x6000251")]
			[Cpp2IlInjected.Address(RVA = "0x7F19900", Offset = "0x7F18700", VA = "0x187F19900")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000252")]
			[Cpp2IlInjected.Address(RVA = "0x7F1A4B0", Offset = "0x7F192B0", VA = "0x187F1A4B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public int ACJMNLEBGBP
		{
			[Cpp2IlInjected.Token(Token = "0x6000253")]
			[Cpp2IlInjected.Address(RVA = "0x7F1A1F0", Offset = "0x7F18FF0", VA = "0x187F1A1F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		protected virtual bool CDIGAAJDAJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000254")]
			[Cpp2IlInjected.Address(RVA = "0xAA3480", Offset = "0xAA2280", VA = "0x180AA3480", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		protected virtual int[] POPMOELDDFJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000255")]
			[Cpp2IlInjected.Address(RVA = "0x7F0D890", Offset = "0x7F0C690", VA = "0x187F0D890", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		protected bool NLNDFEEENCL
		{
			[Cpp2IlInjected.Token(Token = "0x6000257")]
			[Cpp2IlInjected.Address(RVA = "0x7F0EB40", Offset = "0x7F0D940", VA = "0x187F0EB40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		protected static bool COLAOPNNIKE
		{
			[Cpp2IlInjected.Token(Token = "0x6000258")]
			[Cpp2IlInjected.Address(RVA = "0xAA3480", Offset = "0xAA2280", VA = "0x180AA3480")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public bool IKBGEOAJCBM
		{
			[Cpp2IlInjected.Token(Token = "0x6000259")]
			[Cpp2IlInjected.Address(RVA = "0x130C9A0", Offset = "0x130B7A0", VA = "0x18130C9A0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600025A")]
			[Cpp2IlInjected.Address(RVA = "0x7F1A790", Offset = "0x7F19590", VA = "0x187F1A790")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public IEnumerable<SkinnedMeshRenderer> LMMHANPGGLJ
		{
			[Cpp2IlInjected.Token(Token = "0x600025B")]
			[Cpp2IlInjected.Address(RVA = "0x7F190D0", Offset = "0x7F17ED0", VA = "0x187F190D0")]
			[IteratorStateMachine(typeof(KOPELDHDAFH))]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public bool LJEKCHIHJOL
		{
			[Cpp2IlInjected.Token(Token = "0x600025C")]
			[Cpp2IlInjected.Address(RVA = "0x130C9E0", Offset = "0x130B7E0", VA = "0x18130C9E0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600025D")]
			[Cpp2IlInjected.Address(RVA = "0x130D710", Offset = "0x130C510", VA = "0x18130D710")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public PKNFPGJAIIB MEHLKJMNDBL
		{
			[Cpp2IlInjected.Token(Token = "0x600025E")]
			[Cpp2IlInjected.Address(RVA = "0x7F19150", Offset = "0x7F17F50", VA = "0x187F19150")]
			get
			{
				return default(PKNFPGJAIIB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public static bool PHODDONDJIF
		{
			[Cpp2IlInjected.Token(Token = "0x600027D")]
			[Cpp2IlInjected.Address(RVA = "0x7F19600", Offset = "0x7F18400", VA = "0x187F19600")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		protected static IHBKINGAIAD BKGGBPCMAOH
		{
			[Cpp2IlInjected.Token(Token = "0x600027E")]
			[Cpp2IlInjected.Address(RVA = "0x7F0F740", Offset = "0x7F0E540", VA = "0x187F0F740")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600027F")]
			[Cpp2IlInjected.Address(RVA = "0x7F145B0", Offset = "0x7F133B0", VA = "0x187F145B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		protected Color PDMLDJDIMFF
		{
			[Cpp2IlInjected.Token(Token = "0x6000299")]
			[Cpp2IlInjected.Address(RVA = "0x7F10360", Offset = "0x7F0F160", VA = "0x187F10360")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		protected Color BOAHGGNDLPO
		{
			[Cpp2IlInjected.Token(Token = "0x600029A")]
			[Cpp2IlInjected.Address(RVA = "0x7F0E790", Offset = "0x7F0D590", VA = "0x187F0E790")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		protected Texture2D CBALKPMCPKG
		{
			[Cpp2IlInjected.Token(Token = "0x600029B")]
			[Cpp2IlInjected.Address(RVA = "0x7F11B10", Offset = "0x7F10910", VA = "0x187F11B10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public Color LAMLBOELEMF
		{
			[Cpp2IlInjected.Token(Token = "0x60002A1")]
			[Cpp2IlInjected.Address(RVA = "0x7F19200", Offset = "0x7F18000", VA = "0x187F19200")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		protected Color CMPMFIAMBLA
		{
			[Cpp2IlInjected.Token(Token = "0x60002A2")]
			[Cpp2IlInjected.Address(RVA = "0x7F0FFB0", Offset = "0x7F0EDB0", VA = "0x187F0FFB0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		public OIIBFCOFLED APFFBCCPMCF
		{
			[Cpp2IlInjected.Token(Token = "0x60002A3")]
			[Cpp2IlInjected.Address(RVA = "0x7F191C0", Offset = "0x7F17FC0", VA = "0x187F191C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		protected Texture2D ONCGKIMEABM
		{
			[Cpp2IlInjected.Token(Token = "0x60002A4")]
			[Cpp2IlInjected.Address(RVA = "0x7F13450", Offset = "0x7F12250", VA = "0x187F13450")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		public float HMCAMDGDHMP
		{
			[Cpp2IlInjected.Token(Token = "0x60002AB")]
			[Cpp2IlInjected.Address(RVA = "0x7F191E0", Offset = "0x7F17FE0", VA = "0x187F191E0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		public float DHFFPNALFGH
		{
			[Cpp2IlInjected.Token(Token = "0x60002AC")]
			[Cpp2IlInjected.Address(RVA = "0x7F196B0", Offset = "0x7F184B0", VA = "0x187F196B0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		public bool NOKGJJNIBEF
		{
			[Cpp2IlInjected.Token(Token = "0x60002E0")]
			[Cpp2IlInjected.Address(RVA = "0x7F191B0", Offset = "0x7F17FB0", VA = "0x187F191B0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002E1")]
			[Cpp2IlInjected.Address(RVA = "0x7F19C80", Offset = "0x7F18A80", VA = "0x187F19C80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action JMEIKAKMDNE
		{
			[Cpp2IlInjected.Token(Token = "0x6000227")]
			[Cpp2IlInjected.Address(RVA = "0x7F18E30", Offset = "0x7F17C30", VA = "0x187F18E30")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000228")]
			[Cpp2IlInjected.Address(RVA = "0x7F199E0", Offset = "0x7F187E0", VA = "0x187F199E0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action BLLKEEFDHMO
		{
			[Cpp2IlInjected.Token(Token = "0x6000229")]
			[Cpp2IlInjected.Address(RVA = "0x7F18D90", Offset = "0x7F17B90", VA = "0x187F18D90")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600022A")]
			[Cpp2IlInjected.Address(RVA = "0x7F19940", Offset = "0x7F18740", VA = "0x187F19940")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action LAEOBHCKNBF
		{
			[Cpp2IlInjected.Token(Token = "0x600022B")]
			[Cpp2IlInjected.Address(RVA = "0x7F18ED0", Offset = "0x7F17CD0", VA = "0x187F18ED0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0x7F19A80", Offset = "0x7F18880", VA = "0x187F19A80")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action LAHCBAIDBEM
		{
			[Cpp2IlInjected.Token(Token = "0x600022D")]
			[Cpp2IlInjected.Address(RVA = "0x7F18F70", Offset = "0x7F17D70", VA = "0x187F18F70")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600022E")]
			[Cpp2IlInjected.Address(RVA = "0x7F19B20", Offset = "0x7F18920", VA = "0x187F19B20")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<LOOMHCPHCKH, GDNBFNJLEDA> CGEECKDLBIA
		{
			[Cpp2IlInjected.Token(Token = "0x6000271")]
			[Cpp2IlInjected.Address(RVA = "0x7F19010", Offset = "0x7F17E10", VA = "0x187F19010")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000272")]
			[Cpp2IlInjected.Address(RVA = "0x7F19BC0", Offset = "0x7F189C0", VA = "0x187F19BC0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x7F15600", Offset = "0x7F14400", VA = "0x187F15600")]
		public bool SetDeformation(bool AHODLJHECNM, bool HPCHLDKOPOO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x7F0CAB0", Offset = "0x7F0B8B0", VA = "0x187F0CAB0")]
		protected static Material BEFDBBEFHGL(Dictionary<BNIHPDMFJGI, Material> OCAJPENINLF, Material EOEAGHHCHCJ, NHLNBKPOAGN CAHELPONIAF, HEFPCAHEOKB GAOELECEKMD, EEPOCEICAIB GPNKMGAJGEB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x7F0BD50", Offset = "0x7F0AB50", VA = "0x187F0BD50")]
		protected void AGCBGDLKDOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x7F12070", Offset = "0x7F10E70", VA = "0x187F12070")]
		protected bool MFHJJGBPKKP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x7F10D40", Offset = "0x7F0FB40", VA = "0x187F10D40")]
		protected void KCABDGNIKKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x7F0FAB0", Offset = "0x7F0E8B0", VA = "0x187F0FAB0", Slot = "11")]
		protected virtual void HKBEFALFHLG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x7F137D0", Offset = "0x7F125D0", VA = "0x187F137D0")]
		public int MeshesAtLODCount(int INBHIGINMMK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x7F109D0", Offset = "0x7F0F7D0", VA = "0x187F109D0")]
		protected static void JJPGLDNPMNK(Dictionary<GGEFJGKFMHN, List<BNIHPDMFJGI>> NGHKKFKEBOC, CACEEBPIEBP CEGDACFKMJE, Material EOEAGHHCHCJ, NHLNBKPOAGN NNNBPPHIPHF, HEFPCAHEOKB HGGJDFACBPH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x7F0C920", Offset = "0x7F0B720", VA = "0x187F0C920")]
		protected void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x7F103B0", Offset = "0x7F0F1B0", VA = "0x187F103B0")]
		protected void JEHIAHBDHMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x7F14300", Offset = "0x7F13100", VA = "0x187F14300")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "12")]
		protected virtual void KIOKIDEMPAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x7F0F2E0", Offset = "0x7F0E0E0", VA = "0x187F0F2E0")]
		protected static void GMOOPLEFEDD(List<Material> DLANIOPDGIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x7F11E00", Offset = "0x7F10C00", VA = "0x187F11E00")]
		protected static void MDMENOMBPEG(Dictionary<BNIHPDMFJGI, Material> OCAJPENINLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x7F0F010", Offset = "0x7F0DE10", VA = "0x187F0F010")]
		protected static void GIHOBPOMLMG(Dictionary<Renderer, LMKLNGHHDKI> DKMBOCNBPPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x7F148B0", Offset = "0x7F136B0", VA = "0x187F148B0")]
		protected void PIAGAHIIAJP(SkinnedMeshRenderer[] AJBKCNNPPKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x7F13A70", Offset = "0x7F12870", VA = "0x187F13A70")]
		protected void NCLNGBJCFNJ(SkinnedMeshRenderer OJGKICIDJAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x7F139A0", Offset = "0x7F127A0", VA = "0x187F139A0")]
		protected void NCLNGBJCFNJ(MeshRenderer GFEOCBFNCNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x7F13F00", Offset = "0x7F12D00", VA = "0x187F13F00")]
		protected void NPIMCJBMFOE(List<ECOKJONDNDB> DOICCMHGBEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x7F0F420", Offset = "0x7F0E220", VA = "0x187F0F420")]
		protected void GNKJEFDAKCK(Dictionary<string, NONKHMPPJIB<Texture2D>> NGHKKFKEBOC, bool FEFBEJBLAGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x7F0ECA0", Offset = "0x7F0DAA0", VA = "0x187F0ECA0")]
		protected void GFKEFANBBME(Dictionary<GGEFJGKFMHN, List<BNIHPDMFJGI>> NGHKKFKEBOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x7F0F790", Offset = "0x7F0E590", VA = "0x187F0F790")]
		public float GetHandOpenClosedAxis(LOOMHCPHCKH GCHJHJDBJBG)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x7F15E90", Offset = "0x7F14C90", VA = "0x187F15E90")]
		public void SetHandOpenClosedAxis(LOOMHCPHCKH GCHJHJDBJBG, float HHLJFIELOKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x7F0F7D0", Offset = "0x7F0E5D0", VA = "0x187F0F7D0")]
		public GDNBFNJLEDA GetHandVisualState(LOOMHCPHCKH GCHJHJDBJBG)
		{
			return default(GDNBFNJLEDA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x7F0C060", Offset = "0x7F0AE60", VA = "0x187F0C060")]
		public bool AddHandVisualStateToken(LOOMHCPHCKH GCHJHJDBJBG, GDNBFNJLEDA BLGHAKKHBJG, object OCGDLEBGIMO, ABDHJFDNJJI.FFHBOALMPDH HNGPPDLEICO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x7F17710", Offset = "0x7F16510", VA = "0x187F17710")]
		public void SetWatchHand(LOOMHCPHCKH GCHJHJDBJBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x7F177D0", Offset = "0x7F165D0", VA = "0x187F177D0")]
		public void SetWatchHands(bool HPMLKOFHJAA, bool EONKCEOOJLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x7F14CC0", Offset = "0x7F13AC0", VA = "0x187F14CC0")]
		public bool RemoveHandVisualStateToken(LOOMHCPHCKH GCHJHJDBJBG, object OCGDLEBGIMO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x7F0F850", Offset = "0x7F0E650", VA = "0x187F0F850")]
		public bool GetThumbsUpActive(LOOMHCPHCKH GCHJHJDBJBG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x7F17120", Offset = "0x7F15F20", VA = "0x187F17120")]
		public void SetThumbsUpActive(LOOMHCPHCKH GCHJHJDBJBG, bool DGJENDFPPEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x7F0F810", Offset = "0x7F0E610", VA = "0x187F0F810")]
		public bool GetHandshakeActive(LOOMHCPHCKH GCHJHJDBJBG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x7F15EE0", Offset = "0x7F14CE0", VA = "0x187F15EE0")]
		public void SetHandshakeActive(LOOMHCPHCKH GCHJHJDBJBG, bool FCFAMPPJIMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x7F0EBC0", Offset = "0x7F0D9C0", VA = "0x187F0EBC0")]
		public void ForceUpdateHandsVisualState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x7F17600", Offset = "0x7F16400", VA = "0x187F17600")]
		public void SetUseClassicBeanHandScale(bool BNECONOIKOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x7F0D770", Offset = "0x7F0C570", VA = "0x187F0D770")]
		public static void ClearQueuedBuilds()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x7F0DFB0", Offset = "0x7F0CDB0", VA = "0x187F0DFB0")]
		private static void EBMHBNCNKOC(Scene DHLFBBHICBC, LoadSceneMode ICPOMAFNIKG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x7F0FDE0", Offset = "0x7F0EBE0", VA = "0x187F0FDE0")]
		protected static void IECHAGBMLFN(PlayerAvatarDisplayBase AHJNEPCIPKD, List<PFELFMBJGMJ> LIACNCBBCFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x7F149D0", Offset = "0x7F137D0", VA = "0x187F149D0")]
		public IDGEJBLICGP Rebuild(bool OLPLDEFIONG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x7F115A0", Offset = "0x7F103A0", VA = "0x187F115A0")]
		protected IDGEJBLICGP KMCCNJJJKBI(bool OLPLDEFIONG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x7F11600", Offset = "0x7F10400", VA = "0x187F11600", Slot = "13")]
		protected virtual IDGEJBLICGP KMCCNJJJKBI(IList<GGEFJGKFMHN> MCCDNGMLIBG, AvatarItemBodyType JAHJCJGODCJ, bool MJGJPLBFDHO, bool BLAAKGFNOHN, int[] LEPDFIEAIIC, bool OLPLDEFIONG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x7F10E90", Offset = "0x7F0FC90", VA = "0x187F10E90")]
		protected static IDGEJBLICGP KHCDLIKCDAI(PFELFMBJGMJ ODBIMACLFHH, List<PFELFMBJGMJ> LIACNCBBCFB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x7F0CD00", Offset = "0x7F0BB00", VA = "0x187F0CD00")]
		[IteratorStateMachine(typeof(JKGAIOGNMLL))]
		protected static IEnumerator<DMCHEKCEBGH> BMIENEFCBJE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x7F0E700", Offset = "0x7F0D500", VA = "0x187F0E700")]
		protected static PFELFMBJGMJ FCOPAAHCIOF(List<PFELFMBJGMJ> LIACNCBBCFB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x7F15700", Offset = "0x7F14500", VA = "0x187F15700")]
		[AsyncStateMachine(typeof(LIIBDPLMACA))]
		public Task SetFaceCustomizationSettings(MAMJKFCNJKC HPAFAKCFFEI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x7F17930", Offset = "0x7F16730", VA = "0x187F17930")]
		public bool UpdateFaceAndBodyCustomizationSettings(MAMJKFCNJKC HPAFAKCFFEI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x7F10280", Offset = "0x7F0F080", VA = "0x187F10280")]
		public void InitializeFaceFeatures(AvatarConfiguration JHKNFPILNDE, PKNFPGJAIIB AFDMCKAKEMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x7F16E80", Offset = "0x7F15C80", VA = "0x187F16E80")]
		public void SetTeamColors(Color? ODLJFGFPDFO, bool DGOKFNPAEPJ, Color MCIJMBAOKKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x1493150", Offset = "0x1491F50", VA = "0x181493150")]
		private static void LGLHKJMAHHA(Material KKBOKCGIENM, Color BNECONOIKOE, params int[] MHEKJNFADGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x14921B0", Offset = "0x1490FB0", VA = "0x1814921B0")]
		private static void DIMPIPCODDH(Material KKBOKCGIENM, Texture BNECONOIKOE, params int[] MHEKJNFADGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x7F10000", Offset = "0x7F0EE00", VA = "0x187F10000")]
		protected void IILMKLKJOPE(Material KLMAFHHFLEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x7F13DE0", Offset = "0x7F12BE0", VA = "0x187F13DE0")]
		protected void NPBIJIAPHIA(Material KLMAFHHFLEI, Color ENMODPOJIFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x7F13BB0", Offset = "0x7F129B0", VA = "0x187F13BB0")]
		protected void NMOGBDPPNGN(Material KLMAFHHFLEI, Color ENMODPOJIFG, Color DBEEKKIDNLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x7F0F890", Offset = "0x7F0E690", VA = "0x187F0F890")]
		protected void HBOANNGEEIH(Material KLMAFHHFLEI, Texture2D HINEJAGCAOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x7F13890", Offset = "0x7F12690", VA = "0x187F13890")]
		protected void NBIJOAEKOKK(Material KLMAFHHFLEI, Texture KJMIEKBMPOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x7F10870", Offset = "0x7F0F670", VA = "0x187F10870")]
		protected void JJEPMMAOCAH(Action<LMKLNGHHDKI> AGIEOCKGMNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x7F0BB10", Offset = "0x7F0A910", VA = "0x187F0BB10")]
		protected void AFLJJMKDBHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x7F113A0", Offset = "0x7F101A0", VA = "0x187F113A0")]
		protected void KKAJHEBEEEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x7F0E7E0", Offset = "0x7F0D5E0", VA = "0x187F0E7E0")]
		protected void FLLMFKPKCEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x7F0C3B0", Offset = "0x7F0B1B0", VA = "0x187F0C3B0")]
		public void ApplyUgcItemOverrides()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x7F15080", Offset = "0x7F13E80", VA = "0x187F15080")]
		public void SetBeardPrimaryColor([Optional] Color? ABCGENBPBNG, bool CFNFMKEBNBM = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x7F152A0", Offset = "0x7F140A0", VA = "0x187F152A0")]
		public void SetBeardSecondaryColor([Optional] Color? ABCGENBPBNG, bool CFNFMKEBNBM = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x7F14F40", Offset = "0x7F13D40", VA = "0x187F14F40")]
		public void SetBeardPattern([Optional] AvatarHairPattern OGMCIIMONBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x7F11C90", Offset = "0x7F10A90", VA = "0x187F11C90")]
		private void LODOENKKICB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x7F14250", Offset = "0x7F13050", VA = "0x187F14250")]
		private bool OOEMCIPFMIC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x7F15A70", Offset = "0x7F14870", VA = "0x187F15A70")]
		public void SetHairPrimaryColor([Optional] Color? DNOINECGGGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x7F15C80", Offset = "0x7F14A80", VA = "0x187F15C80")]
		public void SetHairSecondaryColor([Optional] Color? DNOINECGGGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x7F15940", Offset = "0x7F14740", VA = "0x187F15940")]
		public void SetHairPattern([Optional] AvatarHairPattern OGMCIIMONBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x7F14B60", Offset = "0x7F13960", VA = "0x187F14B60")]
		public void RefreshHair()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x7F11730", Offset = "0x7F10530", VA = "0x187F11730")]
		private bool KMOBJOIFEAE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x7F16CC0", Offset = "0x7F15AC0", VA = "0x187F16CC0")]
		public void SetSkinColor(Color EGFLLNHKBEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x7F17170", Offset = "0x7F15F70", VA = "0x187F17170")]
		public void SetUgcItemVisualOverrides(GGEFJGKFMHN BBIODPFDGJC, PKNFPGJAIIB AFDMCKAKEMD, Texture BHHECNFIJDG, Color NAGCOBHDCHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x7F0D840", Offset = "0x7F0C640", VA = "0x187F0D840")]
		public void ClearUgcItemVisualOverrides()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x7F15800", Offset = "0x7F14600", VA = "0x187F15800")]
		public bool SetFaceShape(AvatarFaceShape JDNNLNAFKHH, bool OJBJGJCDAJO = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x7F14780", Offset = "0x7F13580", VA = "0x187F14780")]
		private void PEMAACGOMMB(BLODKKHJEPD HNGOMAMNADF, float BNECONOIKOE, bool AEMLKMMMFHB = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x7F0CF70", Offset = "0x7F0BD70", VA = "0x187F0CF70")]
		private void CLEGMDKGBEG(ABDOCGIMPHD JIOKEJCGAIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x7F13B10", Offset = "0x7F12910", VA = "0x187F13B10")]
		private void NICIIKMPGAP(KFIOGNHKBDM CAGKPDNHBMJ, float BNECONOIKOE, bool NNIIFEKBDMB = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x7F0BFC0", Offset = "0x7F0ADC0", VA = "0x187F0BFC0")]
		private void APEPILCFKPO(MMHOGHLBOGJ OACBPNAGKHA, float BNECONOIKOE, bool LEFAPMEFCPN = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x7F0CD60", Offset = "0x7F0BB60", VA = "0x187F0CD60")]
		private void CFMIGFLMGAM(NBALJJBDILJ BOAHOIKKENJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x7F14120", Offset = "0x7F12F20", VA = "0x187F14120")]
		private void OIGEIEKBJCN(LMNIGFCPBLI ENGIEPMMOHK, float BAMOGPEOMIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x7F154C0", Offset = "0x7F142C0", VA = "0x187F154C0")]
		public bool SetBodyShape(AvatarBodyShape MHODDHFLFEN, bool OJBJGJCDAJO = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x7F16B50", Offset = "0x7F15950", VA = "0x187F16B50")]
		public bool SetNoseType(BDLLACEJLDO ANFNFAKDIEP, bool OJBJGJCDAJO = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x7F18020", Offset = "0x7F16E20", VA = "0x187F18020")]
		public bool UpdateFaceAndBodyShapes()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x7F16B30", Offset = "0x7F15930", VA = "0x187F16B30")]
		public bool SetHideEars(bool MBPENHOPLOP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x7F16B20", Offset = "0x7F15920", VA = "0x187F16B20")]
		public bool SetHelmetHair(GFLNPIGKFCH NFLDHPBEDIM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x7F15F30", Offset = "0x7F14D30", VA = "0x187F15F30")]
		public void SetHatAnchorParameters(BHJLPMKOMMK EPDFPLAECDM, bool NOMBMIPIHHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x7F178A0", Offset = "0x7F166A0", VA = "0x187F178A0")]
		public void SetupDisplayLODs(LKBBNBOOBLP LIEPIAKJJEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x7F0D9A0", Offset = "0x7F0C7A0", VA = "0x187F0D9A0")]
		protected int[] DFPLEOOBLMC(LKBBNBOOBLP LIEPIAKJJEG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x7F16C40", Offset = "0x7F15A40", VA = "0x187F16C40")]
		public void SetOutfitSelections(IList<GGEFJGKFMHN> MCCDNGMLIBG, AvatarItemBodyType JAHJCJGODCJ, bool BLAAKGFNOHN, bool OLPLDEFIONG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x7F16BF0", Offset = "0x7F159F0", VA = "0x187F16BF0")]
		public void SetOutfitSelections(IList<GGEFJGKFMHN> MCCDNGMLIBG, AvatarItemBodyType JAHJCJGODCJ, bool MJGJPLBFDHO, bool BLAAKGFNOHN, bool OLPLDEFIONG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x7F16C80", Offset = "0x7F15A80", VA = "0x187F16C80")]
		public IDGEJBLICGP SetOutfitSelections(IList<GGEFJGKFMHN> MCCDNGMLIBG, AvatarItemBodyType JAHJCJGODCJ, LKBBNBOOBLP LIEPIAKJJEG, bool MJGJPLBFDHO, bool BLAAKGFNOHN, bool OJBJGJCDAJO = false, bool OLPLDEFIONG = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x7F13550", Offset = "0x7F12350", VA = "0x187F13550", Slot = "14")]
		protected virtual IDGEJBLICGP MNBOMLEEHLF(IList<GGEFJGKFMHN> MCCDNGMLIBG, AvatarItemBodyType JAHJCJGODCJ, bool MJGJPLBFDHO, bool BLAAKGFNOHN, LKBBNBOOBLP LIEPIAKJJEG, bool OJBJGJCDAJO, bool OLPLDEFIONG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x7F0CE70", Offset = "0x7F0BC70", VA = "0x187F0CE70")]
		protected int[] CJMMLCHDGAK(LKBBNBOOBLP LIEPIAKJJEG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0xA58420", Offset = "0xA57220", VA = "0x180A58420", Slot = "15")]
		protected virtual IHGBKKPAEJC JBJOEDNALMC(AvatarItemBodyType ACFNDMMKHAL, Dictionary<string, MAJDLGCOKCC> DLDKHBJKKDE, Dictionary<string, NONKHMPPJIB<Texture2D>> FEBCKMFGMDJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x7F0FB10", Offset = "0x7F0E910", VA = "0x187F0FB10", Slot = "16")]
		protected virtual IDGEJBLICGP HPGOOAEJOIJ(IList<GGEFJGKFMHN> MCCDNGMLIBG, AvatarItemBodyType JAHJCJGODCJ, bool MJGJPLBFDHO, bool BLAAKGFNOHN, int[] EKOLFMDDEAD, JBOCHFILNBO GLNALIDNLJP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x7F0E1E0", Offset = "0x7F0CFE0", VA = "0x187F0E1E0", Slot = "17")]
		protected virtual MAJDLGCOKCC EONICKFDEEN(OIIBFCOFLED OCIOFNMNEBB, AvatarItemBodyType ACFNDMMKHAL, EEPOCEICAIB GPNKMGAJGEB, MAJDLGCOKCC IELGANLGIFG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0xA58420", Offset = "0xA57220", VA = "0x180A58420", Slot = "18")]
		protected virtual MAJDLGCOKCC PFKEHKBADGO(AvatarItemBodyType ACFNDMMKHAL, EEPOCEICAIB GPNKMGAJGEB, PHCJPNHNAJF FHICECHOKKP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x7F0D920", Offset = "0x7F0C720", VA = "0x187F0D920")]
		protected void DAHOECPMPKE(KLFJIDEFFIK MKOEAEAAPMO, KIECLADILAP.NMBEIOMGMML ILIEMGOHEID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x7F11840", Offset = "0x7F10640", VA = "0x187F11840")]
		protected void LDCMLBCPOHE(KLFJIDEFFIK MKOEAEAAPMO, KIECLADILAP.NMBEIOMGMML ILIEMGOHEID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0xAE0DD0", Offset = "0xADFBD0", VA = "0x180AE0DD0", Slot = "19")]
		protected virtual KLFJIDEFFIK EJGHJMJHCMP(KLFJIDEFFIK MKOEAEAAPMO, HelmetHairStyle JPOGACJHNHN, bool EJBPKFGEDHC, AvatarItemBodyType JAHJCJGODCJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x7F12290", Offset = "0x7F11090", VA = "0x187F12290")]
		protected KLFJIDEFFIK MGCCBLNNJMM(IList<GGEFJGKFMHN> MCCDNGMLIBG, AvatarItemBodyType EGOCPHEPIDI, bool BLAAKGFNOHN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x7F0D650", Offset = "0x7F0C450", VA = "0x187F0D650")]
		public void CleanupDisplayResources()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x7F0CC50", Offset = "0x7F0BA50", VA = "0x187F0CC50")]
		protected void BKBJNIHHNOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x7F0ECF0", Offset = "0x7F0DAF0", VA = "0x187F0ECF0")]
		protected void GIAHJOCKKIB(Transform PJJMEBLCKGP, IEnumerable<SkinnedMeshRenderer> HDGMPCBFKMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x7F10DD0", Offset = "0x7F0FBD0", VA = "0x187F10DD0")]
		protected KIECLADILAP.NMBEIOMGMML KFFPLEGNPHO(KIECLADILAP.NMBEIOMGMML LBDBNBGHGEK, EEPOCEICAIB NPNNBKHKIAK)
		{
			return default(KIECLADILAP.NMBEIOMGMML);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x7F11B00", Offset = "0x7F10900", VA = "0x187F11B00")]
		protected void LJDDCFCGIGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x19C5140", Offset = "0x19C3F40", VA = "0x1819C5140")]
		protected void DBLLJNADMBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x7F11F60", Offset = "0x7F10D60", VA = "0x187F11F60")]
		protected void MFGDHBNGPMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x7F0FEE0", Offset = "0x7F0ECE0", VA = "0x187F0FEE0")]
		[AsyncStateMachine(typeof(GNEFMEODFEC))]
		protected Task IFBPHLOGIJM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x7F0F5A0", Offset = "0x7F0E3A0", VA = "0x187F0F5A0")]
		protected static NHLNBKPOAGN GNMDJEGJDPD(CACEEBPIEBP HBFLKMCBGIA, int GBFOBILIDAO)
		{
			return default(NHLNBKPOAGN);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x7F0F170", Offset = "0x7F0DF70", VA = "0x187F0F170")]
		protected static HEFPCAHEOKB GJHHMBBGPFA(CACEEBPIEBP HBFLKMCBGIA, int GBFOBILIDAO)
		{
			return default(HEFPCAHEOKB);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x7F117F0", Offset = "0x7F105F0", VA = "0x187F117F0")]
		protected Transform LALOJHNKDPP(EEPOCEICAIB GPNKMGAJGEB, OutfitType LGFKMEIIJCG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x7F0DB60", Offset = "0x7F0C960", VA = "0x187F0DB60")]
		protected void DIFOGELOIGJ(int CABFKOOGELP, Material KKBOKCGIENM, CACEEBPIEBP HBFLKMCBGIA, [Out] Texture2D NAFEPEHHBEJ, [Out] Vector4 BBNPHMGMFEK, [Out] Texture2D HNNDIMJKFDE, [Out] Texture2D BDGACKDIKIH, [Out] Texture2D NDBOMKGDMKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x7F0BE70", Offset = "0x7F0AC70", VA = "0x187F0BE70")]
		protected void AJOOBNHNIHI(int CABFKOOGELP, Material KKBOKCGIENM, CACEEBPIEBP HBFLKMCBGIA, [Out] Color OLHDGFDIIOA, [Out] Color OMKJAHDJPJO, [Out] Color EGLAFACDEMC, [Out] Color AFGHJHCHLLB, [Out] Color DELJLGHAGDE, [Out] Color HAIGDEOEOCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x7F10800", Offset = "0x7F0F600", VA = "0x187F10800")]
		protected void JIJLIAGIDMB(Vector3 BKNMJONCLIJ, Quaternion DPJLAFKHMOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x7F164D0", Offset = "0x7F152D0", VA = "0x187F164D0")]
		public void SetHatAnchorParameters(BHJLPMKOMMK EPDFPLAECDM, AnchorParamsRestrictions BPNIALLFDGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x7F0D170", Offset = "0x7F0BF70", VA = "0x187F0D170")]
		public static void CalculateHatAnchorParams(FitMeshHemisphere NJABDLABMOC, Transform IJNIDAJOHDI, BHJLPMKOMMK EPDFPLAECDM, AnchorParamsRestrictions OIOOFDNECEO, [Out] Vector3 APDNNMONKGG, [Out] Quaternion MKHKGOGFEPL, [Out] BHJLPMKOMMK MANAHDENDIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x7F14DD0", Offset = "0x7F13BD0", VA = "0x187F14DD0")]
		public void ResetHatAnchor(Vector2 BCODBJEHBNI, Vector3 BOOIPDLBAFC, Vector3 NAMBHOOINPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0xBAE000", Offset = "0xBACE00", VA = "0x180BAE000")]
		public DDKEHICHJJN GetAnchorParamsRestrictions()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x7F0C1E0", Offset = "0x7F0AFE0", VA = "0x187F0C1E0")]
		public void ApplyBlocks()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x7F0C320", Offset = "0x7F0B120", VA = "0x187F0C320")]
		public void ApplyHairPattern()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x7F0C150", Offset = "0x7F0AF50", VA = "0x187F0C150")]
		public void ApplyBeardPattern()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x7F178D0", Offset = "0x7F166D0", VA = "0x187F178D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x7F0DE40", Offset = "0x7F0CC40", VA = "0x187F0DE40")]
		protected void EAFGALOCPJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x7F17690", Offset = "0x7F16490", VA = "0x187F17690")]
		public void SetWaitForUgcTextureLoads(bool LPOJJOFBMEM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x7F17510", Offset = "0x7F16310", VA = "0x187F17510")]
		public void SetUgcTextureParameters(KMFBMBBKEMD OAEBFAAHGEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x7F18780", Offset = "0x7F17580", VA = "0x187F18780")]
		public PlayerAvatarDisplayBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x7F10770", Offset = "0x7F0F570", VA = "0x187F10770")]
		[CompilerGenerated]
		private void JIAODCNJEDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x7F0E6D0", Offset = "0x7F0D4D0", VA = "0x187F0E6D0")]
		[CompilerGenerated]
		private void EOOGNIIOADB(LMKLNGHHDKI KNDMJPDPKCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x7F11C00", Offset = "0x7F10A00", VA = "0x187F11C00")]
		[CompilerGenerated]
		private void LOCGMAKPNJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x7F10CA0", Offset = "0x7F0FAA0", VA = "0x187F10CA0")]
		[CompilerGenerated]
		private void JKKPEJGGLEO(LMKLNGHHDKI KNDMJPDPKCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x7F106E0", Offset = "0x7F0F4E0", VA = "0x187F106E0")]
		[CompilerGenerated]
		private void JHBFJJGMNDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x7F0DF10", Offset = "0x7F0CD10", VA = "0x187F0DF10")]
		[CompilerGenerated]
		private void EBBCGPPHFBJ(LMKLNGHHDKI KNDMJPDPKCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x7F0EC10", Offset = "0x7F0DA10", VA = "0x187F0EC10")]
		[CompilerGenerated]
		private void GDAHGMMCGMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x7F140D0", Offset = "0x7F12ED0", VA = "0x187F140D0")]
		[CompilerGenerated]
		private void OBELOKEMJEK(LMKLNGHHDKI KNDMJPDPKCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x7F0E0E0", Offset = "0x7F0CEE0", VA = "0x187F0E0E0")]
		[CompilerGenerated]
		private void ECMINPBFMOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x7F0E190", Offset = "0x7F0CF90", VA = "0x187F0E190")]
		[CompilerGenerated]
		private void EMNIMCGBNJL(LMKLNGHHDKI KNDMJPDPKCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x7F14820", Offset = "0x7F13620", VA = "0x187F14820")]
		[CompilerGenerated]
		private void PEOCHBNCAGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x7F0F2C0", Offset = "0x7F0E0C0", VA = "0x187F0F2C0")]
		[CompilerGenerated]
		private void GLGAOEPDAMC(LMKLNGHHDKI KNDMJPDPKCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x7F0DD60", Offset = "0x7F0CB60", VA = "0x187F0DD60")]
		[CompilerGenerated]
		internal static bool DOHGAPEAOJH(Transform OFECDLPHFKA, IEnumerable<SkinnedMeshRenderer> KIGABCAOLNN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x7F11560", Offset = "0x7F10360", VA = "0x187F11560")]
		[CompilerGenerated]
		private void KLJFJNBGIGP(LMKLNGHHDKI KNDMJPDPKCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x7F0CC10", Offset = "0x7F0BA10", VA = "0x187F0CC10")]
		[CompilerGenerated]
		private void BEOEMHLEFGF(LMKLNGHHDKI KNDMJPDPKCG)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[ExecuteAlways]
	public class PlayerFacialAnimatorBase : MonoBehaviour, OAGHPAJECPH
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200006E")]
		[CompilerGenerated]
		private struct PCAGJNFJBLK : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400046A")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400046B")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400046C")]
			public MAMJKFCNJKC avatarData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400046D")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400046E")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003AA")]
			[Cpp2IlInjected.Address(RVA = "0x7F22E10", Offset = "0x7F21C10", VA = "0x187F22E10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AB")]
			[Cpp2IlInjected.Address(RVA = "0x7F230A0", Offset = "0x7F21EA0", VA = "0x187F230A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200006F")]
		[CompilerGenerated]
		private struct DFNDFBJCKAM : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400046F")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000470")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000471")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000472")]
			public int eyeSelection;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000473")]
			public int eyeBrowSelection;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000474")]
			public int noseSelection;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000475")]
			public int mouthSelection;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000476")]
			public PKNFPGJAIIB avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000477")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003AC")]
			[Cpp2IlInjected.Address(RVA = "0x7F1C750", Offset = "0x7F1B550", VA = "0x187F1C750", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AD")]
			[Cpp2IlInjected.Address(RVA = "0x7F1C930", Offset = "0x7F1B730", VA = "0x187F1C930", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000070")]
		[CompilerGenerated]
		private struct NFOHBKLLPIM : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000478")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000479")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400047A")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400047B")]
			public FaceFeatureType featureType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x400047C")]
			public int selectionIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400047D")]
			public PKNFPGJAIIB avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400047E")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003AE")]
			[Cpp2IlInjected.Address(RVA = "0x7F226B0", Offset = "0x7F214B0", VA = "0x187F226B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AF")]
			[Cpp2IlInjected.Address(RVA = "0x7F22850", Offset = "0x7F21650", VA = "0x187F22850", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000071")]
		[CompilerGenerated]
		private struct IDOCKBMOGPD : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400047F")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000480")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000481")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000482")]
			public MAMJKFCNJKC avatarData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000483")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003B0")]
			[Cpp2IlInjected.Address(RVA = "0x7F1E280", Offset = "0x7F1D080", VA = "0x187F1E280", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B1")]
			[Cpp2IlInjected.Address(RVA = "0x7F1E430", Offset = "0x7F1D230", VA = "0x187F1E430", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000072")]
		[CompilerGenerated]
		private struct LLADDEKKLDF : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000484")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000485")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000486")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000487")]
			public PKNFPGJAIIB avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000488")]
			private TaskAwaiter<BMBJBMCPIGG> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003B2")]
			[Cpp2IlInjected.Address(RVA = "0x7F1F0C0", Offset = "0x7F1DEC0", VA = "0x187F1F0C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B3")]
			[Cpp2IlInjected.Address(RVA = "0x7F1F500", Offset = "0x7F1E300", VA = "0x187F1F500", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000073")]
		[CompilerGenerated]
		private struct OPIOJAJPLHD : IAsyncStateMachine
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
			public bool forceRebuild;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x400048D")]
			public PKNFPGJAIIB avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400048E")]
			private FaceStyleSet <styleSet>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400048F")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003B4")]
			[Cpp2IlInjected.Address(RVA = "0x7F22990", Offset = "0x7F21790", VA = "0x187F22990", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B5")]
			[Cpp2IlInjected.Address(RVA = "0x7F22DB0", Offset = "0x7F21BB0", VA = "0x187F22DB0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40003F2")]
		protected const float ENCOMDGJHMI = 0.5f;

		[Cpp2IlInjected.Token(Token = "0x40003F3")]
		protected const int EGMKLDIMMBA = 5;

		[Cpp2IlInjected.Token(Token = "0x40003F4")]
		private static readonly int BMDJMHEFFNO;

		[Cpp2IlInjected.Token(Token = "0x40003F5")]
		private static readonly int JDKJIEHPIPA;

		[Cpp2IlInjected.Token(Token = "0x40003F6")]
		private static readonly int AFHFHPBOKMD;

		[Cpp2IlInjected.Token(Token = "0x40003F7")]
		public static readonly int IdleID;

		[Cpp2IlInjected.Token(Token = "0x40003F8")]
		public static readonly int SmileID;

		[Cpp2IlInjected.Token(Token = "0x40003F9")]
		public static readonly int HugeSmileID;

		[Cpp2IlInjected.Token(Token = "0x40003FA")]
		public static readonly int ScoreID;

		[Cpp2IlInjected.Token(Token = "0x40003FB")]
		public static readonly int SadID;

		[Cpp2IlInjected.Token(Token = "0x40003FC")]
		public static readonly int DisgustID;

		[Cpp2IlInjected.Token(Token = "0x40003FD")]
		public static readonly int HitID;

		[Cpp2IlInjected.Token(Token = "0x40003FE")]
		public static readonly int ConcentrateID;

		[Cpp2IlInjected.Token(Token = "0x40003FF")]
		public static readonly int KissID;

		[Cpp2IlInjected.Token(Token = "0x4000400")]
		public static readonly int TalkingID;

		[Cpp2IlInjected.Token(Token = "0x4000401")]
		public static readonly int MuteID;

		[Cpp2IlInjected.Token(Token = "0x4000402")]
		public static readonly int AFKID;

		[Cpp2IlInjected.Token(Token = "0x4000403")]
		public static readonly int HappyID;

		[Cpp2IlInjected.Token(Token = "0x4000404")]
		public static readonly int EmoteFlatID;

		[Cpp2IlInjected.Token(Token = "0x4000405")]
		public static readonly int EmoteHappyID;

		[Cpp2IlInjected.Token(Token = "0x4000406")]
		public static readonly int EmoteSadID;

		[Cpp2IlInjected.Token(Token = "0x4000407")]
		public static readonly int EmoteLoveID;

		[Cpp2IlInjected.Token(Token = "0x4000408")]
		public static readonly int EmoteAngryID;

		[Cpp2IlInjected.Token(Token = "0x4000409")]
		public static readonly int EmoteLaughID;

		[Cpp2IlInjected.Token(Token = "0x400040A")]
		public static readonly int EmoteTongueOutID;

		[Cpp2IlInjected.Token(Token = "0x400040B")]
		public static readonly int EmoteGrimacingID;

		[Cpp2IlInjected.Token(Token = "0x400040C")]
		public static readonly int EmoteWinkID;

		[Cpp2IlInjected.Token(Token = "0x400040D")]
		public static readonly int EmoteShockedID;

		[Cpp2IlInjected.Token(Token = "0x400040E")]
		public static readonly int EmoteNauseatedID;

		[Cpp2IlInjected.Token(Token = "0x400040F")]
		public static readonly int EmoteSmileSweatID;

		[Cpp2IlInjected.Token(Token = "0x4000410")]
		public static readonly int EmoteSleepingID;

		[Cpp2IlInjected.Token(Token = "0x4000411")]
		public static readonly int EmoteThinkingID;

		[Cpp2IlInjected.Token(Token = "0x4000412")]
		public static readonly int EmoteSmirkID;

		[Cpp2IlInjected.Token(Token = "0x4000413")]
		public static readonly int EmoteSmileID;

		[Cpp2IlInjected.Token(Token = "0x4000414")]
		protected static readonly Dictionary<LBLHCCCPDJA.HFLFPLIMCIA, int> JLBKGEMHNOL;

		[Cpp2IlInjected.Token(Token = "0x4000415")]
		[CanBeNull]
		protected static IEnumerable<FaceFeatureType> PECAPLIKKLE;

		[Cpp2IlInjected.Token(Token = "0x4000416")]
		protected static readonly int OEAKMGIIDBK;

		[Cpp2IlInjected.Token(Token = "0x4000417")]
		protected static readonly int LNGABMODNKP;

		[Cpp2IlInjected.Token(Token = "0x4000418")]
		protected static readonly int AIKLBINJAAO;

		[Cpp2IlInjected.Token(Token = "0x4000419")]
		protected static readonly int APPODMCHJHL;

		[Cpp2IlInjected.Token(Token = "0x400041A")]
		protected static readonly int LEHDPEJNDDP;

		[Cpp2IlInjected.Token(Token = "0x400041B")]
		protected static Vector2 LGMOMENNBEN;

		[Cpp2IlInjected.Token(Token = "0x400041C")]
		protected static Vector2 IENKCPCNKFB;

		[Cpp2IlInjected.Token(Token = "0x400041D")]
		protected static Vector2 LMAAHDPJKJN;

		[Cpp2IlInjected.Token(Token = "0x400041E")]
		protected static Vector2 HBPLHNPMOBM;

		[Cpp2IlInjected.Token(Token = "0x400041F")]
		protected static Vector2 MGLDCLEEIHM;

		[Cpp2IlInjected.Token(Token = "0x4000420")]
		protected static Vector2 JILEMHMNECP;

		[Cpp2IlInjected.Token(Token = "0x4000421")]
		protected static Vector2 IEOLPHBDDND;

		[Cpp2IlInjected.Token(Token = "0x4000422")]
		protected static Vector2 JGBCJGDFEDD;

		[Cpp2IlInjected.Token(Token = "0x4000423")]
		protected static Vector2 LMCAPGHMNMC;

		[Cpp2IlInjected.Token(Token = "0x4000424")]
		protected static Vector2 MOJDBPIMCLG;

		[Cpp2IlInjected.Token(Token = "0x4000425")]
		protected static Vector2 BKHAFJDBHCB;

		[Cpp2IlInjected.Token(Token = "0x4000426")]
		protected static Vector2 EAGJDPDCNME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000427")]
		[LHHMDDGFBKD(NKIOFDIBBLL.Self, false, false, false)]
		[SerializeField]
		public Animator animator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000428")]
		[SerializeField]
		[Header("Rendering")]
		public FaceStyleSet faceStyleSet;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000429")]
		[SerializeField]
		protected Renderer faceRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400042A")]
		[SerializeField]
		protected float jitterFPS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400042B")]
		[Header("Emotes")]
		[SerializeField]
		public Renderer[] emoteEffectRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400042C")]
		[SerializeField]
		[Header("Modern Avatar Facial Features")]
		[FormerlySerializedAs("fullBodyFaceStyleSet")]
		public FaceStyleSet modernBodyFaceStyleSet;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400042D")]
		private PKNFPGJAIIB AHLAAENCEJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400042E")]
		private FaceStyleSet ICFBIKFNLDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400042F")]
		[SerializeField]
		protected bool debugEyeJitterInEditor;

		[Cpp2IlInjected.Token(Token = "0x4000430")]
		protected const int PKMGFBBECFJ = -1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000431")]
		protected int PBDDJDEMCHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000432")]
		protected int JHMOHCEDAKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000433")]
		protected int JGNEKKJICBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000434")]
		protected int KNHIADAGMEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000435")]
		protected Vector2 KNOCIMIEBMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000436")]
		protected float GJOFBDLLLEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000437")]
		protected float FDIPACJMKGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4000438")]
		protected float DFEJPEMCMNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000439")]
		protected Vector2 NIOILFNHIKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400043A")]
		protected float OHJEGKBBKOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x400043B")]
		protected float OPHAAKJOENG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400043C")]
		protected float HOGHIJFMDLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x400043D")]
		protected Vector2 FHAKDKOKDGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x400043E")]
		protected float CNABBEHHKED;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400043F")]
		protected float LCLFNDGAOCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x4000440")]
		protected float IBLLEOIPFDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000441")]
		protected Vector2 LKCHCMBMJFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000442")]
		protected float NHMIALOILEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x4000443")]
		protected float FCCBDHCFFAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000444")]
		protected float AELOLOMFDDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000445")]
		protected List<SelectableFaceOption> GIGHGHPBABJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000446")]
		protected List<SelectableFaceOption> IJPMNMDBPHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000447")]
		protected List<SelectableFaceOption> EFAMEEOEFMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000448")]
		protected List<SelectableFaceOption> BICELDFHCGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000449")]
		protected Coroutine DIKNHILODBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400044A")]
		protected int? KDKBENACBII;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400044B")]
		protected int HIEEGOIALDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
		[Cpp2IlInjected.Token(Token = "0x400044C")]
		protected int IDLDAHIEKKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400044D")]
		protected int KECGFPOLMLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
		[Cpp2IlInjected.Token(Token = "0x400044E")]
		protected int DIDAJGLHLBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400044F")]
		protected Sprite FOMPFIHHLBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000450")]
		protected Sprite FNMFKPHBJIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000451")]
		protected Sprite OOIGNDJMCPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000452")]
		protected Sprite AGGPFHPPIDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000453")]
		protected bool MMEKMOFMLBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000455")]
		protected string DGLFLFJHPDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000456")]
		protected string DPLDKHGBGNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000457")]
		protected string NOLGKIIIAPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x4000458")]
		protected string PCABLIOJDMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4000459")]
		[ReadOnlyField]
		public Sprite eyeSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x400045A")]
		[ReadOnlyField]
		public Sprite leftEyeOnlySprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x400045B")]
		[ReadOnlyField]
		public Sprite rightEyeOnlySprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x400045C")]
		public Color leftEyeColorTint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x400045D")]
		public Color leftEyeGleamColorTint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x400045E")]
		public Color rightEyeColorTint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x400045F")]
		public Color rightEyeGleamColorTint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x4000460")]
		[ReadOnlyField]
		public Sprite mouthSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x4000464")]
		protected AvatarConfiguration JHKNFPILNDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x4000465")]
		protected BMBJBMCPIGG KBBMFCDJCKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x4000467")]
		private readonly List<Material> MAAHIEJMFOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x4000468")]
		protected HPPBEBEADME JNONAHHFHEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x4000469")]
		protected Dictionary<string, int> KDBEFGGDENN;

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		public FaceStyleSet BOPLPNHGKMD
		{
			[Cpp2IlInjected.Token(Token = "0x6000361")]
			[Cpp2IlInjected.Address(RVA = "0x7F29900", Offset = "0x7F28700", VA = "0x187F29900")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A0")]
		public bool MFHPJONMPOL
		{
			[Cpp2IlInjected.Token(Token = "0x6000364")]
			[Cpp2IlInjected.Address(RVA = "0xAF3EE0", Offset = "0xAF2CE0", VA = "0x180AF3EE0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000365")]
			[Cpp2IlInjected.Address(RVA = "0x2636C50", Offset = "0x2635A50", VA = "0x182636C50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A1")]
		protected virtual bool KEGPKCDLDBM
		{
			[Cpp2IlInjected.Token(Token = "0x6000366")]
			[Cpp2IlInjected.Address(RVA = "0xAA3480", Offset = "0xAA2280", VA = "0x180AA3480", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A2")]
		protected virtual bool MENMPCDFBKO
		{
			[Cpp2IlInjected.Token(Token = "0x6000367")]
			[Cpp2IlInjected.Address(RVA = "0xA735B0", Offset = "0xA723B0", VA = "0x180A735B0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A3")]
		protected int AMJKPCKHFJI
		{
			[Cpp2IlInjected.Token(Token = "0x6000368")]
			[Cpp2IlInjected.Address(RVA = "0x7F233D0", Offset = "0x7F221D0", VA = "0x187F233D0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A4")]
		public Renderer FCHNKBINGKL
		{
			[Cpp2IlInjected.Token(Token = "0x6000369")]
			[Cpp2IlInjected.Address(RVA = "0xA59880", Offset = "0xA58680", VA = "0x180A59880")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		public bool LDMFEKOENBF
		{
			[Cpp2IlInjected.Token(Token = "0x600036A")]
			[Cpp2IlInjected.Address(RVA = "0x2641120", Offset = "0x263FF20", VA = "0x182641120")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600036B")]
			[Cpp2IlInjected.Address(RVA = "0x2639AC0", Offset = "0x26388C0", VA = "0x182639AC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A6")]
		public Renderer[] JLFNLPDAEMA
		{
			[Cpp2IlInjected.Token(Token = "0x600036C")]
			[Cpp2IlInjected.Address(RVA = "0xA5C130", Offset = "0xA5AF30", VA = "0x180A5C130")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A7")]
		public bool ILIKAJAEIJJ
		{
			[Cpp2IlInjected.Token(Token = "0x600036D")]
			[Cpp2IlInjected.Address(RVA = "0x7F29950", Offset = "0x7F28750", VA = "0x187F29950")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600036E")]
			[Cpp2IlInjected.Address(RVA = "0x7F29B10", Offset = "0x7F28910", VA = "0x187F29B10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A8")]
		protected int OIPNCMKGEMI
		{
			[Cpp2IlInjected.Token(Token = "0x600036F")]
			[Cpp2IlInjected.Address(RVA = "0x7F262F0", Offset = "0x7F250F0", VA = "0x187F262F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A9")]
		protected int ONNHIMCNIJJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000370")]
			[Cpp2IlInjected.Address(RVA = "0x7F25490", Offset = "0x7F24290", VA = "0x187F25490")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AA")]
		public float JEJDKJHJJMD
		{
			[Cpp2IlInjected.Token(Token = "0x6000371")]
			[Cpp2IlInjected.Address(RVA = "0x7F29930", Offset = "0x7F28730", VA = "0x187F29930")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000372")]
			[Cpp2IlInjected.Address(RVA = "0x7F29AF0", Offset = "0x7F288F0", VA = "0x187F29AF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AB")]
		public GLADMCEDLEP MFIOCIPJPMP
		{
			[Cpp2IlInjected.Token(Token = "0x6000373")]
			[Cpp2IlInjected.Address(RVA = "0xBC5C30", Offset = "0xBC4A30", VA = "0x180BC5C30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000374")]
			[Cpp2IlInjected.Address(RVA = "0xBEB4E0", Offset = "0xBEA2E0", VA = "0x180BEB4E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AC")]
		public BMBJBMCPIGG LEKFMNHKIHA
		{
			[Cpp2IlInjected.Token(Token = "0x6000390")]
			[Cpp2IlInjected.Address(RVA = "0xB4BEE0", Offset = "0xB4ACE0", VA = "0x180B4BEE0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000391")]
			[Cpp2IlInjected.Address(RVA = "0x7F29A70", Offset = "0x7F28870", VA = "0x187F29A70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AD")]
		public NoseFaceOption AJFJPBFDMFH
		{
			[Cpp2IlInjected.Token(Token = "0x6000392")]
			[Cpp2IlInjected.Address(RVA = "0xB21390", Offset = "0xB20190", VA = "0x180B21390")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000393")]
			[Cpp2IlInjected.Address(RVA = "0xBB9520", Offset = "0xBB8320", VA = "0x180BB9520")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AE")]
		protected HPPBEBEADME NOANPOONAOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000394")]
			[Cpp2IlInjected.Address(RVA = "0x7F26AD0", Offset = "0x7F258D0", VA = "0x187F26AD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action ADINFGDBILJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000362")]
			[Cpp2IlInjected.Address(RVA = "0x7F29850", Offset = "0x7F28650", VA = "0x187F29850")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000363")]
			[Cpp2IlInjected.Address(RVA = "0x7F299C0", Offset = "0x7F287C0", VA = "0x187F299C0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x7F25F60", Offset = "0x7F24D60", VA = "0x187F25F60")]
		public void LocalPlayEmote(LBLHCCCPDJA.HFLFPLIMCIA OPDIDEGOBPH, float MLBJOEFGEBN = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x7F25BC0", Offset = "0x7F249C0", VA = "0x187F25BC0")]
		public bool IsEmotePlaying(LBLHCCCPDJA.HFLFPLIMCIA OPDIDEGOBPH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x7F27770", Offset = "0x7F26570", VA = "0x187F27770")]
		public void SetIdleHappy(bool PHLEDOJGDKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x7F246F0", Offset = "0x7F234F0", VA = "0x187F246F0")]
		protected void FEEKHLHMEKL(bool OIOAJFMPJFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x7F24770", Offset = "0x7F23570", VA = "0x187F24770")]
		protected void GBLGMOEGGLI(bool LDCEKMKJLAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x7F23A20", Offset = "0x7F22820", VA = "0x187F23A20")]
		protected void BIIMAAFDFPO(EEPOCEICAIB GPNKMGAJGEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x7F242E0", Offset = "0x7F230E0", VA = "0x187F242E0")]
		protected void DCBKFANAIBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x7F26E40", Offset = "0x7F25C40", VA = "0x187F26E40")]
		public void PlayExpression(int LEBCCOGBNIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x7F248D0", Offset = "0x7F236D0", VA = "0x187F248D0")]
		protected void GJFMCLKCFHG(bool NPKKBHOMAGD, bool AAOBLFJGADN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x7F24B70", Offset = "0x7F23970", VA = "0x187F24B70")]
		public List<SelectableFaceOption> GetAvailableFeatures(FaceFeatureType HAKIEFDKDCK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x7F25690", Offset = "0x7F24490", VA = "0x187F25690")]
		public void InitializeFaceFeatureRanges(AvatarConfiguration JHKNFPILNDE, PKNFPGJAIIB AFDMCKAKEMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x7F27410", Offset = "0x7F26210", VA = "0x187F27410")]
		[AsyncStateMachine(typeof(PCAGJNFJBLK))]
		public Task SetFaceSettings(MAMJKFCNJKC HPAFAKCFFEI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x7F27500", Offset = "0x7F26300", VA = "0x187F27500")]
		[AsyncStateMachine(typeof(DFNDFBJCKAM))]
		public Task SetFaceSettings(int LMEGGBPJICP, int KJCIEAFFCKI, int JBPOMHNKPIE, int JOEFDKNMILI, PKNFPGJAIIB AFDMCKAKEMD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x7F277F0", Offset = "0x7F265F0", VA = "0x187F277F0")]
		[AsyncStateMachine(typeof(NFOHBKLLPIM))]
		public Task SetSelectedFaceFeatureAndBuildFaceStyle(FaceFeatureType HAKIEFDKDCK, int MEEJADAMBOF, PKNFPGJAIIB AFDMCKAKEMD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x7F24BB0", Offset = "0x7F239B0", VA = "0x187F24BB0")]
		protected void HBGNBHAAHCG(FaceFeatureType HAKIEFDKDCK, JPHJMMINMCH MKCPHENKFFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x7F24D30", Offset = "0x7F23B30", VA = "0x187F24D30")]
		protected void HHBOEKANNAK(FaceFeatureType HAKIEFDKDCK, int MEEJADAMBOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x7F24990", Offset = "0x7F23790", VA = "0x187F24990")]
		public static IEnumerable<FaceFeatureType> GetAllFaceFeatureTypes()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x7F266E0", Offset = "0x7F254E0", VA = "0x187F266E0")]
		[AsyncStateMachine(typeof(IDOCKBMOGPD))]
		protected Task NDAMKMKODBE(MAMJKFCNJKC HPAFAKCFFEI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x7F267D0", Offset = "0x7F255D0", VA = "0x187F267D0")]
		protected void NEPDMCPNPLN(MAMJKFCNJKC HPAFAKCFFEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x7F254F0", Offset = "0x7F242F0", VA = "0x187F254F0")]
		protected static void IHIBNPIAEFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x7F26060", Offset = "0x7F24E60", VA = "0x187F26060")]
		private void MHOBNFPIKAM(bool PEBEKDGJMOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x7F26350", Offset = "0x7F25150", VA = "0x187F26350")]
		protected void NCLNPLFAKCI(FaceFeatureType HAKIEFDKDCK, Vector2 IAFINMFEHBK, PKNFPGJAIIB AFDMCKAKEMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x7F26E60", Offset = "0x7F25C60", VA = "0x187F26E60")]
		public void SetFaceFeatureNormalizedPositionOffset(FaceFeatureType HAKIEFDKDCK, Vector2 NCMKELAEFBM, PKNFPGJAIIB AFDMCKAKEMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x7F23760", Offset = "0x7F22560", VA = "0x187F23760")]
		protected void ANJNCFFHNON(FaceFeatureType HAKIEFDKDCK, float HDFJJEDGFAC, PKNFPGJAIIB AFDMCKAKEMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x7F235E0", Offset = "0x7F223E0", VA = "0x187F235E0")]
		protected void ANGCBDFBGCA(FaceFeatureType HAKIEFDKDCK, float NOLDGDLLBBL, PKNFPGJAIIB AFDMCKAKEMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x7F25CE0", Offset = "0x7F24AE0", VA = "0x187F25CE0")]
		protected void KBGEEBEIIJK(FaceFeatureType HAKIEFDKDCK, float DAECPIPBCGL, PKNFPGJAIIB AFDMCKAKEMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x7F271F0", Offset = "0x7F25FF0", VA = "0x187F271F0")]
		public void SetFaceFeatureNormalizedScaleOffset(FaceFeatureType HAKIEFDKDCK, float KMDCHHBNKFK, PKNFPGJAIIB AFDMCKAKEMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x7F26B50", Offset = "0x7F25950", VA = "0x187F26B50")]
		[AsyncStateMachine(typeof(LLADDEKKLDF))]
		protected Task NFMIDPLOBPM(PKNFPGJAIIB AFDMCKAKEMD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x7F259B0", Offset = "0x7F247B0", VA = "0x187F259B0")]
		public void InitializeFaceFeatureStyleSet(PKNFPGJAIIB AFDMCKAKEMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x7F23500", Offset = "0x7F22300", VA = "0x187F23500")]
		protected bool AGCGLGMBPPC(string BIDLPLDDGPL, [Out] int CKFKPOAGPKN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x7F238E0", Offset = "0x7F226E0", VA = "0x187F238E0")]
		protected void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x7F27900", Offset = "0x7F26700", VA = "0x187F27900", Slot = "8")]
		protected virtual void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x7F26C30", Offset = "0x7F25A30", VA = "0x187F26C30")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x7F28900", Offset = "0x7F27700", VA = "0x187F28900")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x7F23A90", Offset = "0x7F22890", VA = "0x187F23A90")]
		[AsyncStateMachine(typeof(OPIOJAJPLHD))]
		public Task BuildFaceStyleAsyncIfChanged(PKNFPGJAIIB AFDMCKAKEMD, bool OJBJGJCDAJO = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x7F28210", Offset = "0x7F27010", VA = "0x187F28210")]
		public void UpdateFaceDisplays(bool EOLGLMLNAMA = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x7F23B90", Offset = "0x7F22990", VA = "0x187F23B90")]
		protected bool CJHBOOKOOBJ(bool EOLGLMLNAMA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x7F27F70", Offset = "0x7F26D70", VA = "0x187F27F70")]
		public void UpdateFaceDisplayFeatureTextures()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x7F27630", Offset = "0x7F26430", VA = "0x187F27630")]
		public void SetFaceSpriteIndices(string OHFJCDJNADI, string IBEGIKDACLA, string ACHLMLMGBAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x7F27910", Offset = "0x7F26710", VA = "0x187F27910")]
		public void UpdateFaceDisplayFeaturePositions()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x7F28430", Offset = "0x7F27230", VA = "0x187F28430")]
		public void UpdateFaceJitterMultiplier()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x7F28620", Offset = "0x7F27420", VA = "0x187F28620")]
		public bool UpdateLegacyFaceVectors()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x7F24600", Offset = "0x7F23400", VA = "0x187F24600")]
		protected void EAAPACEEJAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0x7F24350", Offset = "0x7F23150", VA = "0x187F24350")]
		private void DOGOJABDIBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x7F25DB0", Offset = "0x7F24BB0", VA = "0x187F25DB0")]
		private void KNJJOABEEOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x7F295F0", Offset = "0x7F283F0", VA = "0x187F295F0")]
		public PlayerFacialAnimatorBase()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0xA85C10", Offset = "0xA84A10", VA = "0x180A85C10", Slot = "4")]
		private bool JGCGIJJFOGK()
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public struct INEPNDHJMJE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000490")]
	public string OFMLOIDKMDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000491")]
	public int ACHEFDKJDFN;
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	[SelectionBase]
	[ExecuteInEditMode]
	public class PlayerModernBodyEditorAvatarValidator : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000077")]
		[CompilerGenerated]
		private struct CPIEMKIBKGE : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004F1")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40004F2")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004F3")]
			public PlayerModernBodyEditorAvatarValidator <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004F4")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003E9")]
			[Cpp2IlInjected.Address(RVA = "0x7F1C550", Offset = "0x7F1B350", VA = "0x187F1C550", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003EA")]
			[Cpp2IlInjected.Address(RVA = "0xAAD270", Offset = "0xAAC070", VA = "0x180AAD270", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000078")]
		[CompilerGenerated]
		private struct GHBAKGALMFH : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004F5")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40004F6")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004F7")]
			public PlayerModernBodyEditorAvatarValidator <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004F8")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003EB")]
			[Cpp2IlInjected.Address(RVA = "0x7F1DA80", Offset = "0x7F1C880", VA = "0x187F1DA80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003EC")]
			[Cpp2IlInjected.Address(RVA = "0x7F1DF70", Offset = "0x7F1CD70", VA = "0x187F1DF70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000492")]
		public const string IDLE_ANIM_NAME = "Idle";

		[Cpp2IlInjected.Token(Token = "0x4000493")]
		public const string A_POSE_ANIM_NAME = "A Pose";

		[Cpp2IlInjected.Token(Token = "0x4000494")]
		public const string ANIMATION_OVERRIDE_STATE_NAME = "Override";

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000495")]
		public PKNFPGJAIIB avatarBodyType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000497")]
		public Color hairPrimaryColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000498")]
		public Color hairSecondaryColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000499")]
		public Color beardPrimaryColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400049A")]
		public Color beardSecondaryColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400049B")]
		public Color skinColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x400049C")]
		public int faceShapeIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400049D")]
		public int bodyShapeIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x400049E")]
		public int hairPatternIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400049F")]
		public int beardPatternIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		public AvatarFaceShape[] faceShapes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		public AvatarBodyShape[] bodyShapes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		public AvatarHairPattern[] hairPatterns;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		public float _avatarScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x40004A4")]
		public bool enablePosing;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		public int poseIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		public AnimationClip animationOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		[Range(0f, 4f)]
		public float animationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		public bool hideEars;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		public GFLNPIGKFCH useHelmetHair;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40004AA")]
		public BHJLPMKOMMK hatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		public DDKEHICHJJN HatAnchorRestrictions;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		public bool UseHairFitMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD1")]
		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		public bool usesHatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		public GameObject hatPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		public GameObject hairPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40004B0")]
		public GameObject earPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40004B1")]
		public GameObject eyePrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40004B2")]
		public GameObject mouthPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40004B3")]
		public GameObject neckPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40004B4")]
		public GameObject shirtPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40004B5")]
		public GameObject beltPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40004B6")]
		public GameObject shoulderPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40004B7")]
		public GameObject rightHandPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40004B8")]
		public GameObject leftHandPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40004B9")]
		public GameObject legsPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40004BA")]
		public GameObject feetPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40004BB")]
		public long baseSkinCullingMask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40004BC")]
		[LHHMDDGFBKD(NKIOFDIBBLL.Self, false, false, false)]
		[SerializeField]
		public PlayerAvatarDisplayBase _avatarDisplay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40004BD")]
		private POBGJEIDOFF JDJCDHCOIII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40004BE")]
		[LHHMDDGFBKD(NKIOFDIBBLL.Self, false, false, false)]
		[SerializeField]
		public PlayerFacialAnimatorBase facialAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40004BF")]
		public Animator animator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40004C0")]
		public AnimationClip animationClipToOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40004C1")]
		private AnimatorOverrideController GFGMLDINDEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40004C2")]
		private List<KeyValuePair<AnimationClip, AnimationClip>> ILIHLLJIMID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x40004C3")]
		public Transform headIKEffector;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x40004C4")]
		public Transform leftHandIKEffector;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x40004C5")]
		public Transform rightHandIKEffector;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x40004C6")]
		[Range(0f, 2f)]
		public int lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19C")]
		[Cpp2IlInjected.Token(Token = "0x40004C7")]
		public int rightHandGestureStateIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x40004C8")]
		[Range(0f, 1f)]
		public float rightHandCurl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A4")]
		[Cpp2IlInjected.Token(Token = "0x40004C9")]
		public int leftHandGestureStateIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x40004CA")]
		[Range(0f, 1f)]
		public float leftHandCurl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1AC")]
		[Cpp2IlInjected.Token(Token = "0x40004CB")]
		public int eyeBrowSelection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x40004CC")]
		public int eyeSelection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B4")]
		[Cpp2IlInjected.Token(Token = "0x40004CD")]
		public int noseSelection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x40004CE")]
		public int mouthSelection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1BC")]
		[Cpp2IlInjected.Token(Token = "0x40004CF")]
		public float eyeBrowPositionOffsetHorizontal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x40004D0")]
		public float eyeBrowPositionOffsetVertical;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C4")]
		[Cpp2IlInjected.Token(Token = "0x40004D1")]
		public float eyeBrowScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x40004D2")]
		public float eyePositionOffsetHorizontal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1CC")]
		[Cpp2IlInjected.Token(Token = "0x40004D3")]
		public float eyePositionOffsetVertical;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x40004D4")]
		public float eyeScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D4")]
		[Cpp2IlInjected.Token(Token = "0x40004D5")]
		public float nosePositionOffsetVertical;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x40004D6")]
		public float noseScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1DC")]
		[Cpp2IlInjected.Token(Token = "0x40004D7")]
		public float mouthPositionOffsetHorizontal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x40004D8")]
		public float mouthPositionOffsetVertical;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E4")]
		[Cpp2IlInjected.Token(Token = "0x40004D9")]
		public float mouthScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x40004DA")]
		public float hatNormalizedPositionX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1EC")]
		[Cpp2IlInjected.Token(Token = "0x40004DB")]
		public float hatNormalizedPositionY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
		[Cpp2IlInjected.Token(Token = "0x40004DC")]
		public Vector3 hatHemispherePositionOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1FC")]
		[Cpp2IlInjected.Token(Token = "0x40004DD")]
		public Vector3 hatHemisphereRotationOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
		[Cpp2IlInjected.Token(Token = "0x40004DE")]
		public int facialExpressionIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20C")]
		[Cpp2IlInjected.Token(Token = "0x40004DF")]
		[Range(0f, 1f)]
		public float normalizedTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
		[Cpp2IlInjected.Token(Token = "0x40004E0")]
		public readonly INEPNDHJMJE[] FacialExpressions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
		[Cpp2IlInjected.Token(Token = "0x40004E1")]
		public readonly string[] BodyPoses;

		[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
		[Cpp2IlInjected.Token(Token = "0x40004E2")]
		public readonly (string, GDNBFNJLEDA)[] HandPoses;

		[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
		[Cpp2IlInjected.Token(Token = "0x40004E3")]
		public bool hideLeftWatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x229")]
		[Cpp2IlInjected.Token(Token = "0x40004E4")]
		public bool hideRightWatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x22A")]
		[Cpp2IlInjected.Token(Token = "0x40004E5")]
		protected bool KHGNHKGFOLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x22C")]
		[Cpp2IlInjected.Token(Token = "0x40004E6")]
		protected Guid BOKDKAOKBAC;

		[Cpp2IlInjected.Token(Token = "0x40004E7")]
		protected static Guid IFFFDMLKHII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
		[Cpp2IlInjected.Token(Token = "0x40004E8")]
		private DKKDNHKBJLF NHJJJCHDOBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
		[Cpp2IlInjected.Token(Token = "0x40004E9")]
		private GLADMCEDLEP OHLPKBGMBPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
		[Cpp2IlInjected.Token(Token = "0x40004EA")]
		private FKLMPLDDLKB JPHNDBLNLHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
		[Cpp2IlInjected.Token(Token = "0x40004EB")]
		private FKLMPLDDLKB NGCMKKEOIFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x40004EC")]
		private AdditionalHatData ACMFELABNOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
		[Cpp2IlInjected.Token(Token = "0x40004ED")]
		private readonly Dictionary<GameObject, OIIBFCOFLED> OAKBCFBOFCH;

		[Cpp2IlInjected.Token(Token = "0x170000AF")]
		public static Func<PHCJPNHNAJF> BBGOODCILFH
		{
			[Cpp2IlInjected.Token(Token = "0x60003B7")]
			[Cpp2IlInjected.Address(RVA = "0x7F2EBF0", Offset = "0x7F2D9F0", VA = "0x187F2EBF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003B8")]
			[Cpp2IlInjected.Address(RVA = "0x7F2F230", Offset = "0x7F2E030", VA = "0x187F2F230")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B0")]
		public bool KMOBJOIFEAE
		{
			[Cpp2IlInjected.Token(Token = "0x60003B9")]
			[Cpp2IlInjected.Address(RVA = "0x7F2ED50", Offset = "0x7F2DB50", VA = "0x187F2ED50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B1")]
		public bool OOEMCIPFMIC
		{
			[Cpp2IlInjected.Token(Token = "0x60003BA")]
			[Cpp2IlInjected.Address(RVA = "0x7F2EC40", Offset = "0x7F2DA40", VA = "0x187F2EC40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B2")]
		public PlayerAvatarDisplayBase HEEOBGMPCBG
		{
			[Cpp2IlInjected.Token(Token = "0x60003BC")]
			[Cpp2IlInjected.Address(RVA = "0xBAAC50", Offset = "0xBA9A50", VA = "0x180BAAC50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B3")]
		protected static Guid MOFFOODJIPF
		{
			[Cpp2IlInjected.Token(Token = "0x60003BD")]
			[Cpp2IlInjected.Address(RVA = "0x7F2C5C0", Offset = "0x7F2B3C0", VA = "0x187F2C5C0")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B4")]
		public (GameObject, EEPOCEICAIB)[] MBPNPENNBEA
		{
			[Cpp2IlInjected.Token(Token = "0x60003D3")]
			[Cpp2IlInjected.Address(RVA = "0x7F2EE60", Offset = "0x7F2DC60", VA = "0x187F2EE60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x7F2C920", Offset = "0x7F2B720", VA = "0x187F2C920")]
		[ContextMenu("Refresh Avatar")]
		private void RebuildTestAvatarContextMenu()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x7F2ACC0", Offset = "0x7F29AC0", VA = "0x187F2ACC0")]
		private IEnumerable<GameObject> DGGNLNNPJKJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x7F2CDF0", Offset = "0x7F2BBF0", VA = "0x187F2CDF0")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x7F2A500", Offset = "0x7F29300", VA = "0x187F2A500")]
		private void BFMPHOAKMNK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x1475FC0", Offset = "0x1474DC0", VA = "0x181475FC0")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x7F2B990", Offset = "0x7F2A790", VA = "0x187F2B990")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x7F2CE00", Offset = "0x7F2BC00", VA = "0x187F2CE00")]
		public void Teardown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x7F2CC10", Offset = "0x7F2BA10", VA = "0x187F2CC10")]
		public void ShowPose(AnimationClip NBNBHEDGHCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x7F2CDC0", Offset = "0x7F2BBC0", VA = "0x187F2CDC0")]
		public void ShowPose(string FHJBDCEGHDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x7F2CA70", Offset = "0x7F2B870", VA = "0x187F2CA70")]
		public void ResetPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x7F2C930", Offset = "0x7F2B730", VA = "0x187F2C930")]
		public void ResetHandPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x7F2D8D0", Offset = "0x7F2C6D0", VA = "0x187F2D8D0")]
		public void UpdateHandAnimation()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x7F2D720", Offset = "0x7F2C520", VA = "0x187F2D720")]
		public void UpdateFaceAndBodyShapes(bool OJBJGJCDAJO = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x7F2DCD0", Offset = "0x7F2CAD0", VA = "0x187F2DCD0")]
		public void UpdateNoseShape(BDLLACEJLDO ANFNFAKDIEP, bool OJBJGJCDAJO = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x7F2DCA0", Offset = "0x7F2CAA0", VA = "0x187F2DCA0")]
		public void UpdateLODOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x7F2A1F0", Offset = "0x7F28FF0", VA = "0x187F2A1F0", Slot = "4")]
		protected virtual void BDABAKACPKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x7F2C6B0", Offset = "0x7F2B4B0", VA = "0x187F2C6B0", Slot = "5")]
		protected virtual void NIGGPAOIMDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x7F29E20", Offset = "0x7F28C20", VA = "0x187F29E20")]
		public void ApplyHatData(AdditionalHatData BCJEFMGDODD, bool COGMGBHFGMG = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x7F29C60", Offset = "0x7F28A60", VA = "0x187F29C60")]
		public void ApplyHatAdjustmentsToHatAnchorParams()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x7F2A180", Offset = "0x7F28F80", VA = "0x187F2A180")]
		public void ApplyHatUVOverride(Vector2 IIHOGGHFCFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x7F2A0A0", Offset = "0x7F28EA0", VA = "0x187F2A0A0")]
		public void ApplyHatPositionAdjustment(Vector3 NKDHMKNBCAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x7F2A110", Offset = "0x7F28F10", VA = "0x187F2A110")]
		public void ApplyHatRotationAdjustment(Vector3 DGEKDHBHANC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x7F2A5E0", Offset = "0x7F293E0", VA = "0x187F2A5E0")]
		public GGEFJGKFMHN BuildAvatarItemSelection(GameObject ALOLIAIBPPF, PKNFPGJAIIB ACFNDMMKHAL, EEPOCEICAIB JJKILOJLKCI)
		{
			return default(GGEFJGKFMHN);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x7F2A680", Offset = "0x7F29480", VA = "0x187F2A680")]
		public void BuildAvatar(bool OJBJGJCDAJO = false, bool COGMGBHFGMG = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x7F2D160", Offset = "0x7F2BF60", VA = "0x187F2D160")]
		public void UpdateColors()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x7F29DA0", Offset = "0x7F28BA0", VA = "0x187F29DA0")]
		public void ApplyHatAnchor()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x7F2DAF0", Offset = "0x7F2C8F0", VA = "0x187F2DAF0")]
		public void UpdateHatAnchor(bool COGMGBHFGMG = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x7F2D820", Offset = "0x7F2C620", VA = "0x187F2D820")]
		[AsyncStateMachine(typeof(CPIEMKIBKGE))]
		public void UpdateFaceFeatures()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x7F2B200", Offset = "0x7F2A000", VA = "0x187F2B200")]
		[AsyncStateMachine(typeof(GHBAKGALMFH))]
		private Task FLLFLPNGHLJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x7F2B630", Offset = "0x7F2A430", VA = "0x187F2B630")]
		private void GHBKIEPJPBG(FaceFeatureType HNBPPNIGJHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x7F2B900", Offset = "0x7F2A700", VA = "0x187F2B900")]
		private void GILADAHPKON(FaceFeatureType HNBPPNIGJHI, [Out] float NKMFNOEPKKN, [Out] float CFPDLJBNABG, [Out] float AMJKMJIBGNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x7F2D5E0", Offset = "0x7F2C3E0", VA = "0x187F2D5E0")]
		public void UpdateEmote()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x7F2D980", Offset = "0x7F2C780", VA = "0x187F2D980")]
		public void UpdateHandPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x7F2C090", Offset = "0x7F2AE90", VA = "0x187F2C090")]
		private void JEFHDNAIJLB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410")]
		private void COBODDLEEOF(OIIBFCOFLED OCIOFNMNEBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410")]
		private void NEGJDLAJJOM(OIIBFCOFLED OCIOFNMNEBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x7F2B2D0", Offset = "0x7F2A0D0", VA = "0x187F2B2D0")]
		private void GAOFEOIJBAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x7F2DD60", Offset = "0x7F2CB60", VA = "0x187F2DD60")]
		public PlayerModernBodyEditorAvatarValidator()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x7F2B150", Offset = "0x7F29F50", VA = "0x187F2B150")]
		[CompilerGenerated]
		private GGEFJGKFMHN EMNDBCGKILJ((GameObject, EEPOCEICAIB) EDLAJPNMAIC)
		{
			return default(GGEFJGKFMHN);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	public class SkinnedMeshBonesInspector : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004F9")]
		[LHHMDDGFBKD(NKIOFDIBBLL.Self, false, false, false)]
		[SerializeField]
		private SkinnedMeshRenderer skinnedMeshRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004FA")]
		[SerializeField]
		private int BoneWeightsDisplayStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40004FB")]
		[SerializeField]
		private int BoneWeightsDisplayAmount;

		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0xA58400", Offset = "0xA57200", VA = "0x180A58400")]
		public SkinnedMeshBonesInspector()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public struct GGEFJGKFMHN
{
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[CompilerGenerated]
	private sealed class IDIGFMGKHCJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004FE")]
		public IEnumerable<OutfitType> otherOutfitTypes;

		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public IDIGFMGKHCJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x7F1E200", Offset = "0x7F1D000", VA = "0x187F1E200")]
		internal bool OGIFFMJDEGD(OutfitType outfitType)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004FC")]
	private OIIBFCOFLED GJHNMJMECLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004FD")]
	private EEPOCEICAIB JMCPGNBJJIB;

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public OIIBFCOFLED LCKJIHFBOBA
	{
		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0xAE3610", Offset = "0xAE2410", VA = "0x180AE3610")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public EEPOCEICAIB NLJJOPOPIOB
	{
		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0xE3B7D0", Offset = "0xE3A5D0", VA = "0x180E3B7D0")]
		get
		{
			return default(EEPOCEICAIB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public string NHFKAFLKGPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x7F1D3C0", Offset = "0x7F1C1C0", VA = "0x187F1D3C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public bool COGJMJNBIBG
	{
		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x7F1D6A0", Offset = "0x7F1C4A0", VA = "0x187F1D6A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public bool EMHBFHAKJHO
	{
		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x7F1DA30", Offset = "0x7F1C830", VA = "0x187F1DA30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x19D5B50", Offset = "0x19D4950", VA = "0x1819D5B50")]
	public GGEFJGKFMHN(OIIBFCOFLED OCIOFNMNEBB, EEPOCEICAIB GPNKMGAJGEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x7F1D960", Offset = "0x7F1C760", VA = "0x187F1D960")]
	public bool LEBNMDBDKFF(OutfitType LIJIMDBCDEE, EEPOCEICAIB ADECOOGNLMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x7F1D6F0", Offset = "0x7F1C4F0", VA = "0x187F1D6F0")]
	public bool KAGGCNGMILA(OutfitType LIJIMDBCDEE, EEPOCEICAIB ADECOOGNLMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x7F1D4B0", Offset = "0x7F1C2B0", VA = "0x187F1D4B0")]
	public bool DBDCLKFKJBN(GGEFJGKFMHN FGIOGLIBDBH)
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
