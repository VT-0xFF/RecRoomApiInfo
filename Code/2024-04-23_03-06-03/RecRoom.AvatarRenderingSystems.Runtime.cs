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
	public class LogRegistrationIndex : PPFIOIJOILA
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6178410", Offset = "0x6177410", VA = "0x186178410", Slot = "4")]
		public override void GGEFLGLPFBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7EACF0", Offset = "0x7E9CF0", VA = "0x1807EACF0")]
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
			[Cpp2IlInjected.Address(RVA = "0x7C4300", Offset = "0x7C3300", VA = "0x1807C4300", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override string AssetGUID
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x617A7C0", Offset = "0x61797C0", VA = "0x18617A7C0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x617A6F0", Offset = "0x61796F0", VA = "0x18617A6F0", Slot = "17")]
		public override bool RuntimeKeyIsValid()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x617A780", Offset = "0x6179780", VA = "0x18617A780")]
		public RecNetCDNAssetReference(RecNetCDNKey OHNEPKBBADL)
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
			[Cpp2IlInjected.Address(RVA = "0x7C2D60", Offset = "0x7C1D60", VA = "0x1807C2D60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x7C1DE0", Offset = "0x7C0DE0", VA = "0x1807C1DE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public string CacheHash
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x7C3F20", Offset = "0x7C2F20", VA = "0x1807C3F20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x7C3D80", Offset = "0x7C2D80", VA = "0x1807C3D80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x617A8B0", Offset = "0x61798B0", VA = "0x18617A8B0")]
		public static RecNetCDNKey HLKCOJOALOI(string MAJCODJCLHF, string MMAKIAIKIHI = "")
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x59A1F70", Offset = "0x59A0F70", VA = "0x1859A1F70")]
		public void FAAKOFGOCIP(string IFOJEPJPING, string NDPLPLPKLFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x617A800", Offset = "0x6179800", VA = "0x18617A800")]
		public RecNetCDNKey ECOELIMPFKD(string CBEFLKLOJOM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x617A940", Offset = "0x6179940", VA = "0x18617A940")]
		public RecNetCDNKey()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[GMMEGLMLLJK]
public class ACPLDHMKLOD : HDMALKKDPPJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	protected readonly List<Mesh> CCJIEKPMNFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	protected readonly List<byte[]> GCLIAIPFBGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	protected readonly List<Matrix4x4> MBENMJLNPNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	protected readonly List<bool> CEKDAPPPEOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	protected readonly List<int> EDJBJNEBOPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	protected readonly List<bool> LCIOADGMCCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	protected readonly List<int> ECHJKBMLFME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	protected Allocator DCJLDCIBLEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	protected LLDOGCENKDM JCBCKJCINMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	protected byte LBCIMELOFIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	protected IList<int> ALCHIIHBGJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	protected IList<int> BGFJPAALFBD;

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6163250", Offset = "0x6162250", VA = "0x186163250", Slot = "4")]
	public void OPJPFOEPONM(Mesh GCFMCPMBPPI, Matrix4x4 OIGACIFNLHF, byte[] CMGICLLHFCI, bool GINEDBGPILC = false, FNNENMGHBAG.DJLKMCOMPKG BFDNDNLHLIK = (FNNENMGHBAG.DJLKMCOMPKG)0, int OGKDCFFFKOF = -1, bool PDGJEINJDEJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6163210", Offset = "0x6162210", VA = "0x186163210", Slot = "5")]
	public void IPKKEJIBAPH(Allocator NFBFCGHLHAF, LLDOGCENKDM PEKIIJAJMMD, byte OJMGJAGCIDP, [Optional] IList<int> NMLNGBLGGEC, [Optional] IList<int> GIHNBNDAJNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x61630E0", Offset = "0x61620E0", VA = "0x1861630E0")]
	private static void INAJFFMJMLC(Mesh GCFMCPMBPPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6163680", Offset = "0x6162680", VA = "0x186163680")]
	public ACPLDHMKLOD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[GMMEGLMLLJK]
public struct PKBACDECEFF : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	[ReadOnly]
	public IGIHNIAMOKI MABNHOHIFFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	[ReadOnly]
	public int IGPOEOOOJGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public FCADACJNMEM BDPENIPNEFG;

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x61788E0", Offset = "0x61778E0", VA = "0x1861788E0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[GMMEGLMLLJK]
[NativeContainer]
public struct FCADACJNMEM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct DOPINIEOHFJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public Vector3 OPLHAGFDPEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public Vector3 KMBEHGBELJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public Vector4 JIANBIILENJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct NAKFPKHFMND
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public half EMKHJLICAGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public half DKPLOCAAPGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public half NHPHLLMFFGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public half MFKMMOLIPAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public byte PMCLHMHNKBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public byte PEKJPIPDKCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public byte IJDJIIEHGFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public byte JCLHAHBDBMA;
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct JPMJJIOIDOB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public half4 IODHIPGGADP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public half2 GJEDNCPMKMF;
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct ABKAPBNCBFH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public half4 IODHIPGGADP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public half2 GJEDNCPMKMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public half2 IKDBGAMJNLD;
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct JIMLAHOODHK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public half4 IODHIPGGADP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public half2 GJEDNCPMKMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public half2 IKDBGAMJNLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public half2 CLDGHMCIEHG;
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public struct LMLBBMKLODH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public half4 IODHIPGGADP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public half2 GJEDNCPMKMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public half2 IKDBGAMJNLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public half2 CLDGHMCIEHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public half2 LIDOLNNDIDO;
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct NOIFFKPKNMD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public float EMKHJLICAGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public float DKPLOCAAPGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public float NHPHLLMFFGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public float MFKMMOLIPAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public int PMCLHMHNKBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public int PEKJPIPDKCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public int IJDJIIEHGFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public int JCLHAHBDBMA;
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public struct FENLAFHBPPG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public Color IODHIPGGADP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public Vector2 GJEDNCPMKMF;
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public struct PGBPFOOHDMO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public Color IODHIPGGADP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public Vector2 GJEDNCPMKMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public Vector2 IKDBGAMJNLD;
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public struct JMPKJHBNKPM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public Color IODHIPGGADP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public Vector2 GJEDNCPMKMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public Vector2 IKDBGAMJNLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public Vector2 CLDGHMCIEHG;
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public struct LJBFMBCHCIA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public Color IODHIPGGADP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public Vector2 GJEDNCPMKMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public Vector2 IKDBGAMJNLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public Vector2 CLDGHMCIEHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public Vector2 LIDOLNNDIDO;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private bool HFPCJDHFHDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public NativeArray<DOPINIEOHFJ> CGBJHIIMMCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public NativeArray<JPMJJIOIDOB> DNCOOHAOMNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public NativeArray<ABKAPBNCBFH> PNHLPINOIDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public NativeArray<JIMLAHOODHK> NJMLHAPLOPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public NativeArray<LMLBBMKLODH> GBFHMHCAPLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public NativeArray<NAKFPKHFMND> FJNPMCBKDII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public NativeArray<FENLAFHBPPG> OCGMBNGBDKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public NativeArray<PGBPFOOHDMO> CNKDGJPCHFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public NativeArray<JMPKJHBNKPM> KBHEMPPCJEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public NativeArray<LJBFMBCHCIA> PNBOPNGMFCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public NativeArray<NOIFFKPKNMD> EIEAGMHJHBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public NativeArray<int> OHAGBGJFDKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public NativeArray<int> NBMNMHCPHII;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private NativeArray<int> CLHIHJKLIEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private NativeArray<int> HBLLFBNHBAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public NativeArray<int> BMLMAFJGAPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public NativeArray<int> FJKMIBDMNEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public NativeArray<int> GBIPDILLAEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public NativeArray<BoneWeight> BEMLMNJDOBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private NativeArray<int> FBCKOOIGNJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private bool GHOGBAGIIHL;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int BCHGLKCECFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6170C40", Offset = "0x616FC40", VA = "0x186170C40")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6172200", Offset = "0x6171200", VA = "0x186172200")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int GPDCGJLEACB
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6172220", Offset = "0x6171220", VA = "0x186172220")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6171360", Offset = "0x6170360", VA = "0x186171360")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int JMAIHBBMJMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6171370", Offset = "0x6170370", VA = "0x186171370")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6172210", Offset = "0x6171210", VA = "0x186172210")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int PMNCCMBOHJK
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6172190", Offset = "0x6171190", VA = "0x186172190")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x61729E0", Offset = "0x61719E0", VA = "0x1861729E0")]
	public FCADACJNMEM(int CMIDHCIJCIP, int BNJHCHHFGLD, int CILGFFIHKDE, int PJJIPDOKOKG, Allocator NFBFCGHLHAF, int NGCPPOODCCL, JKJKJGGBMAN DGGIAEOECJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6172950", Offset = "0x6171950", VA = "0x186172950")]
	public void PHHEACFADII(int GPEHCABDGEJ, Vector3 JFNFFLEPNAC, Vector3 MBGPCNKOEPO, Vector4 DCCCOAOAGBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6170910", Offset = "0x616F910", VA = "0x186170910")]
	public void ADDHCHBIJPC(int GPEHCABDGEJ, BoneWeight AOKEJKDDOAB, NativeSlice<byte> CMGICLLHFCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6172230", Offset = "0x6171230", VA = "0x186172230")]
	public Color NFOJJJDIKKP(int GPEHCABDGEJ)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6170F60", Offset = "0x616FF60", VA = "0x186170F60")]
	public void EKIJGBBEGGA(int GPEHCABDGEJ, Color PPMIKHJHPEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x61725B0", Offset = "0x61715B0", VA = "0x1861725B0")]
	public void OHAPJFPOCKN(byte GBDFAIHMEGC, int GPEHCABDGEJ, Vector2 HKNGGDKEMIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6171380", Offset = "0x6170380", VA = "0x186171380")]
	public void JFMIIDLNOPF(int GPEHCABDGEJ, int HKCEPJPCLIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6172550", Offset = "0x6171550", VA = "0x186172550")]
	public bool ODMHOFECLFB(int GBDFAIHMEGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6170E90", Offset = "0x616FE90", VA = "0x186170E90")]
	public void EABDLCDDGGD(int DKIDGNPOAEI, int NGKDOMEFDDB, int GOKGFKKLOOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6170C50", Offset = "0x616FC50", VA = "0x186170C50", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6171390", Offset = "0x6170390", VA = "0x186171390")]
	public Mesh KIOEHOKMEDF([Optional] string PDLOLFGFHEC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[DefaultMember("Item")]
[GMMEGLMLLJK]
[NativeContainer]
public struct IGIHNIAMOKI : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public Mesh.MeshDataArray MDJINPNALPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public NativeArray<int> KPNFHDGHOCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public NativeArray<int> FNEKDGKMHEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public NativeArray<BoneWeight> BEMLMNJDOBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private NativeArray<Matrix4x4> MKLBINGGOFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private NativeArray<int> GCIJJOHHMPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private NativeArray<byte> NAAJJODPHDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private NativeArray<int> IEIIODLBMIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private NativeArray<int> AEMAPOBJALB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public NativeArray<sbyte> NLCDCNNNNCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public NativeArray<byte> IELHMDJEGAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public NativeArray<bool> PDGJEINJDEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public NativeArray<int> OGKDCFFFKOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private NativeArray<int> CMBGJLMNOCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private bool GHOGBAGIIHL;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public int FPJAACGFOOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6174760", Offset = "0x6173760", VA = "0x186174760")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int KJMBLAAJHOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x61749C0", Offset = "0x61739C0", VA = "0x1861749C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int BKNICHFLKJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6174C60", Offset = "0x6173C60", VA = "0x186174C60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int CBMOGFDICKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6174740", Offset = "0x6173740", VA = "0x186174740")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6174900", Offset = "0x6173900", VA = "0x186174900")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int BCHGLKCECFG
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6174750", Offset = "0x6173750", VA = "0x186174750")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x61749E0", Offset = "0x61739E0", VA = "0x1861749E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int AFKPOAGNOEI
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x6174A00", Offset = "0x6173A00", VA = "0x186174A00")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x6174770", Offset = "0x6173770", VA = "0x186174770")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public LLDOGCENKDM MLNDFDCMNNE
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x6174780", Offset = "0x6173780", VA = "0x186174780")]
		get
		{
			return default(LLDOGCENKDM);
		}
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x61749D0", Offset = "0x61739D0", VA = "0x1861749D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public byte HPKBKKAACAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6174D30", Offset = "0x6173D30", VA = "0x186174D30")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x61749F0", Offset = "0x61739F0", VA = "0x1861749F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public ODDMHCDELNB EAGDGAFFDEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6174A10", Offset = "0x6173A10", VA = "0x186174A10")]
		get
		{
			return default(ODDMHCDELNB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6174D40", Offset = "0x6173D40", VA = "0x186174D40")]
	public IGIHNIAMOKI(IList<Mesh> NICBHFFLODF, IList<Matrix4x4> GDBDBPAOFKL, IList<bool> PDGJEINJDEJ, byte OJMGJAGCIDP, IList<byte[]> LOJHFEINCIO, IList<int> IANIIOOKCPJ, IList<bool> KCPODJCIKAE, IList<int> OGKDCFFFKOF, IList<int> NMLNGBLGGEC, IList<int> LMPKJFKPHII, Allocator NFBFCGHLHAF, LLDOGCENKDM PEKIIJAJMMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6174910", Offset = "0x6173910", VA = "0x186174910")]
	public FCADACJNMEM FDHMEEHOOPH(Allocator NFBFCGHLHAF, JKJKJGGBMAN DGGIAEOECJG)
	{
		return default(FCADACJNMEM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6174790", Offset = "0x6173790", VA = "0x186174790", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[GMMEGLMLLJK]
public class FLEOGMEAPIP : ACPLDHMKLOD
{
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6173360", Offset = "0x6172360", VA = "0x186173360")]
	public IGIHNIAMOKI MFMPGPBJENJ()
	{
		return default(IGIHNIAMOKI);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6173450", Offset = "0x6172450", VA = "0x186173450")]
	public FLEOGMEAPIP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct ODDMHCDELNB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public Mesh.MeshData IANENMBJHHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public NativeSlice<BoneWeight> BEMLMNJDOBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public NativeSlice<byte> KGAGAADJKBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public int GKOCNBOLADL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public Matrix4x4 PFKJNGFMKEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public int JJHJMFOKJCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public NativeSlice<byte> CMGICLLHFCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public bool CHIIEAFLLHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public int ABCJEBNOEGK;
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class BAPAEDLJOFB : JBOGDIBCGKA
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	private abstract class HJMAINCPENL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public readonly CNEMEHGENOO KMDPILMJDCN;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public virtual bool JHOHLPCFFKP
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x808C00", Offset = "0x807C00", VA = "0x180808C00", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public virtual bool DKKKIJJCPHC
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x808C00", Offset = "0x807C00", VA = "0x180808C00", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public virtual FNNENMGHBAG.DJLKMCOMPKG JJHJMFOKJCP
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x7C06D0", Offset = "0x7BF6D0", VA = "0x1807C06D0", Slot = "6")]
			get
			{
				return default(FNNENMGHBAG.DJLKMCOMPKG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public bool ACHIHPFNBAC
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x1357C10", Offset = "0x1356C10", VA = "0x181357C10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool HMNEPPPALHK
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x61745E0", Offset = "0x61735E0", VA = "0x1861745E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public bool LLJBBMDDMPC
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x61745F0", Offset = "0x61735F0", VA = "0x1861745F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x7C2AC0", Offset = "0x7C1AC0", VA = "0x1807C2AC0")]
		protected HJMAINCPENL(CNEMEHGENOO AOPHNOMEOHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract PGOMONKDBKH HABFAMNAOHB(int[] MGPMGBFOKFL, List<GHIFGBAJKGA> DGIGEILCPGN, List<GHIFGBAJKGA> DGFFFKGPFAP);

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract BLNJIFONGJJ FIGHLEIIFDF(uint ODIANCNJLNI);
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	private class AKHJNJAHDMG : HJMAINCPENL
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class PBDJFDAJHMK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000CE")]
			public DBHPMDCPDMB<GameObject> skinAvatarItemPrefabHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			public AKHJNJAHDMG <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
			public PBDJFDAJHMK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x61784F0", Offset = "0x61774F0", VA = "0x1861784F0")]
			internal void LCMJNOODMLJ(GameObject result)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private readonly AvatarSkinAssetItem.HELEHAIIDAP CDIJOEIHDPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private readonly AssetReference PDJFIKJIDDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private readonly FNNENMGHBAG.DJLKMCOMPKG OGBKIOPFMPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private readonly FHLAPGIAMKK? NGKOHLBDNCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private readonly Material[] PKPNFFLILED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private SkinnedMeshRenderer[] CKPHNPCHHLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private AvatarSkinAssetItem LPJIIHOMKAO;

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public override FNNENMGHBAG.DJLKMCOMPKG JJHJMFOKJCP
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x7C2D80", Offset = "0x7C1D80", VA = "0x1807C2D80", Slot = "6")]
			get
			{
				return default(FNNENMGHBAG.DJLKMCOMPKG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x6163ED0", Offset = "0x6162ED0", VA = "0x186163ED0")]
		public AKHJNJAHDMG(AvatarSkinAssetItem.HELEHAIIDAP IKCIABDDGOF, AssetReference DGDFIBGMEAA, Material CNCKECEPHJJ, CNEMEHGENOO NACOKOOJCEO, FNNENMGHBAG.DJLKMCOMPKG DBDGKEAIJPE = (FNNENMGHBAG.DJLKMCOMPKG)0, [Optional] FHLAPGIAMKK? OBEJBOMIBKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x6163DC0", Offset = "0x6162DC0", VA = "0x186163DC0")]
		public AKHJNJAHDMG(AvatarSkinAssetItem.HELEHAIIDAP IKCIABDDGOF, AssetReference DGDFIBGMEAA, Material CNCKECEPHJJ, FNNENMGHBAG.DJLKMCOMPKG DBDGKEAIJPE = (FNNENMGHBAG.DJLKMCOMPKG)0, [Optional] FHLAPGIAMKK? OBEJBOMIBKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x6163B80", Offset = "0x6162B80", VA = "0x186163B80", Slot = "7")]
		public override PGOMONKDBKH HABFAMNAOHB(int[] MGPMGBFOKFL, List<GHIFGBAJKGA> DGIGEILCPGN, List<GHIFGBAJKGA> DGFFFKGPFAP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x61638B0", Offset = "0x61628B0", VA = "0x1861638B0", Slot = "8")]
		public override BLNJIFONGJJ FIGHLEIIFDF(uint ODIANCNJLNI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x6163D50", Offset = "0x6162D50", VA = "0x186163D50", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	private class GEIFLDNFNGH : HJMAINCPENL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public readonly DKMBDLGCKIC DEDCGPPPKFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private DBHPMDCPDMB<LHPGIFAAPJB> POKPFJEENMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public LHPGIFAAPJB DPCODEOAJKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private DBHPMDCPDMB<Material>[] KBAKLDOJFJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public List<Material> AEINGDONAEA;

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public override bool JHOHLPCFFKP
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x7DB420", Offset = "0x7DA420", VA = "0x1807DB420", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public override bool DKKKIJJCPHC
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x61741F0", Offset = "0x61731F0", VA = "0x1861741F0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x1B5EBC0", Offset = "0x1B5DBC0", VA = "0x181B5EBC0")]
		public GEIFLDNFNGH(CNEMEHGENOO AOPHNOMEOHO, DKMBDLGCKIC BMEKCCMEJKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x6173720", Offset = "0x6172720", VA = "0x186173720", Slot = "7")]
		public override PGOMONKDBKH HABFAMNAOHB(int[] MGPMGBFOKFL, List<GHIFGBAJKGA> DGIGEILCPGN, List<GHIFGBAJKGA> DGFFFKGPFAP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x61735F0", Offset = "0x61725F0", VA = "0x1861735F0", Slot = "8")]
		public override BLNJIFONGJJ FIGHLEIIFDF(uint ODIANCNJLNI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x6173C90", Offset = "0x6172C90", VA = "0x186173C90")]
		public BLNJIFONGJJ HKAMOEMOEEE(GameObject EMLANGGFJFK, uint ODIANCNJLNI, bool MNAHFFOJAEG, bool FBFFHILPKFL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x6173E80", Offset = "0x6172E80", VA = "0x186173E80")]
		public static bool NGIONMOBDDN(Renderer[] LAGPCDOPHFA, string CEMFIDFFCOH, [Out] Renderer OJKNCNBIFEH, [Out] Renderer MCDHNMFLGIK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x6174510", Offset = "0x6173510", VA = "0x186174510", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x6174370", Offset = "0x6173370", VA = "0x186174370")]
		private (DBHPMDCPDMB<LHPGIFAAPJB>, DBHPMDCPDMB<Material>[]) PGOPPECCNMO()
		{
			return default((DBHPMDCPDMB<LHPGIFAAPJB>, DBHPMDCPDMB<Material>[]));
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x6174250", Offset = "0x6173250", VA = "0x186174250")]
		private DBHPMDCPDMB<Material>[] NMCDJODAAPI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x3E62C90", Offset = "0x3E61C90", VA = "0x183E62C90")]
		[CompilerGenerated]
		private void POJEHLDIPMK(LHPGIFAAPJB NIKEINPNLMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x6173460", Offset = "0x6172460", VA = "0x186173460")]
		[CompilerGenerated]
		private void AMPAPJPMPEK(DBHPMDCPDMB<Material> KHEAHEMBLAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x6173590", Offset = "0x6172590", VA = "0x186173590")]
		[CompilerGenerated]
		private void FBFBHPDKHNC(Material NIKEINPNLMA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class LMCPIIDCHMB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public BAPAEDLJOFB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public HNENBNAEPGI buildMeshPromise;

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		public LMCPIIDCHMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x6178360", Offset = "0x6177360", VA = "0x186178360")]
		internal void JDKPKAMAIEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x6178340", Offset = "0x6177340", VA = "0x186178340")]
		internal void EAPLIOOOEDA(string err)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x6178380", Offset = "0x6177380", VA = "0x186178380")]
		internal void OHCHNNBDHPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x61782B0", Offset = "0x61772B0", VA = "0x1861782B0")]
		internal void CEGPPMGMPDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x7C29D0", Offset = "0x7C19D0", VA = "0x1807C29D0")]
		internal PGOMONKDBKH LKFPAGKOHMF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class POMOFEJBGHM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public int lowestPossibleLOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public LMCPIIDCHMB CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		public POMOFEJBGHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x617A630", Offset = "0x6179630", VA = "0x18617A630")]
		internal OOPMOAHEAAE IHJBCHJIDFD(int lod)
		{
			return default(OOPMOAHEAAE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class IEKBEDJJBNG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public List<HNENBNAEPGI> innerPromises;

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		public IEKBEDJJBNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x6174610", Offset = "0x6173610", VA = "0x186174610")]
		internal void DECDOLAIHHD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class DJLPDGMHGGG : IEnumerator<JHIBCIKJMBL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private JHIBCIKJMBL <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public BAPAEDLJOFB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public List<HJMAINCPENL> parts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public int[] LODs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public List<HNENBNAEPGI> innerPromises;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public bool isFirstPerson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public Func<int, OOPMOAHEAAE> getLayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public JBDICGPJOOE materialPropertyBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public Material materialInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		private int <lodIndex>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		private JHIBCIKJMBL System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x7C29D0", Offset = "0x7C19D0", VA = "0x1807C29D0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x7C29D0", Offset = "0x7C19D0", VA = "0x1807C29D0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x7C2AC0", Offset = "0x7C1AC0", VA = "0x1807C2AC0")]
		[DebuggerHidden]
		public DJLPDGMHGGG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x7C06C0", Offset = "0x7BF6C0", VA = "0x1807C06C0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x61706B0", Offset = "0x616F6B0", VA = "0x1861706B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x61708C0", Offset = "0x616F8C0", VA = "0x1861708C0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class OELGOJKJHNK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public int[] LODs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public BAPAEDLJOFB <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		public OELGOJKJHNK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x61784A0", Offset = "0x61774A0", VA = "0x1861784A0")]
		internal PGOMONKDBKH MDLLIDNAGIJ(HJMAINCPENL p)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class PKCIAAEHGMJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public OMKOEJMCDFF cancelable;

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		public PKCIAAEHGMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x839EF0", Offset = "0x838EF0", VA = "0x180839EF0")]
		internal void PMBDDOOJOGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x8C7E90", Offset = "0x8C6E90", VA = "0x1808C7E90")]
		internal void KPKFFMFHNKD(string err)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class ICBALEAFAAL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public long jobComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public Stopwatch stopwatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public SkinnedMeshRenderer lodRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public long meshComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public string meshName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public long meshCopyComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public BAPAEDLJOFB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public List<Material> newUniqueMaterials;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public int lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public int frameStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public long lodBuildStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public long startCombineBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public long jobScheduled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public Action onFinally;

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		public ICBALEAFAAL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class BOBFMIIFHOL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public bool waitingForComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public JobHandle lodBuildJobHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public FCADACJNMEM defaultMeshJobContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public IGIHNIAMOKI defaultAvatarMeshJobGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public ICBALEAFAAL CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		public BOBFMIIFHOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x6170480", Offset = "0x616F480", VA = "0x186170480")]
		internal void IMANOBIBNNJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x6170410", Offset = "0x616F410", VA = "0x186170410")]
		internal void FLCNINJHONI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class PLGLLMGHMMG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public bool waitingForComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public JobHandle lodBuildJobHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public CAAKOKNPJFC legacyMeshJobContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public DHLCKAHAOKM legacyAvatarMeshJobGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public ICBALEAFAAL CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		public PLGLLMGHMMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x617A400", Offset = "0x6179400", VA = "0x18617A400")]
		internal void IJMKCNBHGAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x617A390", Offset = "0x6179390", VA = "0x18617A390")]
		internal void BFKLLAONBDL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class LBMOPENCLCE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public OMKOEJMCDFF cancelablePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public DKMBDLGCKIC avatarItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public BAPAEDLJOFB <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		public LBMOPENCLCE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x6177F60", Offset = "0x6176F60", VA = "0x186177F60")]
		internal PGOMONKDBKH DMKKFEPFFHH(IGDILKKPPEE item)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x6178270", Offset = "0x6177270", VA = "0x186178270")]
		internal void EHKJDEANAOO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private sealed class BLIFFHAACBG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public DBHPMDCPDMB<Texture2D> resourceHandle;

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		public BLIFFHAACBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x61703C0", Offset = "0x616F3C0", VA = "0x1861703C0")]
		internal void IACFPKEFBBM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class HDDPKGIBPAD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public string overrideItemIdentifier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public CNEMEHGENOO overrideBodyPart;

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		public HDDPKGIBPAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x6174560", Offset = "0x6173560", VA = "0x186174560")]
		internal bool AFPCMBECIEA(KeyValuePair<string, DKMBDLGCKIC> entry)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private AvatarConfiguration BEEJEDMBJIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private Transform LPJDIEPMODJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private AssetReference PDJFIKJIDDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private GameObject KCHJOEJECJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private GameObject KOEKNJJKFFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private SkinnedMeshRenderer GFCOMKDAOCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private Transform[] ODOOHPLGLME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private Matrix4x4[] IEBLBCOBKGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private Material MKICJMGCNLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private Material OGKJIMPCGDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private Material JHFLCHNEHFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private Shader KBNEBLOOGCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private Shader EKDNDNFHJGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private Animator AKBOGOFFOHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private Renderer[] GLAAKIAJJIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private FNNENMGHBAG.DJLKMCOMPKG CGGGJEBJKGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private Color NLBDNPCNBNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private Color LNGEPKDLEMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private Color HIOHNMGOKGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private Color? AOGHNIAHCJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private Color? AICJHDMFKIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private Color? BDGFANONMLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private Color? KOBEMHMJNJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private Texture2D OBMFEGMMFHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private Texture2D NNCLMHLDAAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	[CanBeNull]
	private DKMBDLGCKIC ELPBNLODAPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private Texture HIHPIMHDLLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private Color JAJMHPIDEOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public Dictionary<Renderer, JBDICGPJOOE> PLFEMAPMLIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private Dictionary<Renderer, JBDICGPJOOE> LCCJDFGKEGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private Dictionary<string, List<DKIBHHMPOGM>> JAANJINPLJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private Dictionary<string, List<DKIBHHMPOGM>> CNODLNEKODN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly List<GHIFGBAJKGA> IJEEINFPBGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly List<GHIFGBAJKGA> GOMBNEFHKCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly List<GHIFGBAJKGA> BMNKIFODJPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly List<GHIFGBAJKGA> JBAIMEFAFEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private Dictionary<DKIBHHMPOGM, Material> OJABHKMFJJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private Dictionary<DKIBHHMPOGM, Material> ALPEAKJBLIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private SkinnedMeshRenderer[] BPFBLLHHHHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private SkinnedMeshRenderer[] HOGJKBDJKLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private SkinnedMeshRenderer[] MHOAOLENPMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private SkinnedMeshRenderer[] DAIGNLLDJCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly Dictionary<string, DBHPMDCPDMB<Texture2D>> OMMBLMNKCFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly Dictionary<string, DBHPMDCPDMB<Texture2D>> KMODOCCDPLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private FitMeshHemisphere MOHDNPGODFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private bool JPGNKPEBHMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private EDFIKEGMLOC CAEGFCHFBBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private bool AHJCFJGMOIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private AnchorParamsRestrictions JDCECLDJKCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private bool GMAKCKEOHFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private Transform BFPPAFAAJMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private Transform GLBBPDOGLLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private bool ANEKOOBEION;

	[Cpp2IlInjected.FieldOffset(Offset = "0x201")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private bool ANAFPLJOOLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x204")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private Vector3 CALPHMCEBPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private Quaternion EGODKAGEDIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private Vector2 OLJDAIMOKIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private FitMeshHemisphere NCBJNAMCCCE;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private Material GBFLJFMJKPP;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private Material AHOJIFLHDFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private Dictionary<string, DKMBDLGCKIC> BOMAOIKJOBH;

	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private static readonly int MHALOAMENPG;

	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private static readonly int FDFDNPEMCBD;

	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private static readonly int NHCECMAJEJN;

	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private static readonly int EOFCILACKPH;

	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private static readonly int KPCMFGAMIDM;

	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private static readonly int IIJIGNBOIFE;

	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private static readonly int NBMOJALNGJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private readonly ONDMBBPPJJI FPKHNLNGBKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private readonly ONDMBBPPJJI NLLNCLMDEAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private bool FONFKHKCIMM;

	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private static Lazy<JBCGMADOBCF> PHCNMKHNMDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private Lazy<HBPLCCHFDMJ> MJOBFCPBGAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private Lazy<LHOOOJOFIHI> LCCAEHFKNPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private List<Action> EELHDCCKFHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private AKIKLMHKCBM HHGHHELNJAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private SkinnedMeshRenderer[] CGPCFHOEGLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private int DJGDCLEJPJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28C")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private bool BPIBNMJJCIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private int FCGIGJIFIEH;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool FAAILJHJPEH
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x616CDD0", Offset = "0x616BDD0", VA = "0x18616CDD0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x6164910", Offset = "0x6163910", VA = "0x186164910")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool DAMKDOHBFHF
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0xE5FED0", Offset = "0xE5EED0", VA = "0x180E5FED0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private Material GDFDDOCCNNM
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x6166290", Offset = "0x6165290", VA = "0x186166290")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private Material FICIGEFLNCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x6164680", Offset = "0x6163680", VA = "0x186164680")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	private bool LHFEPHNCHBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7DB420", Offset = "0x7DA420", VA = "0x1807DB420")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	private static JBCGMADOBCF PMLPBEPMGEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x6167D00", Offset = "0x6166D00", VA = "0x186167D00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	private HBPLCCHFDMJ PIEKGBDPNMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6163FE0", Offset = "0x6162FE0", VA = "0x186163FE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private LHOOOJOFIHI JPBDJFIAOAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x61678C0", Offset = "0x61668C0", VA = "0x1861678C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public ONDMBBPPJJI MEHOCNLGIHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x9B7180", Offset = "0x9B6180", VA = "0x1809B7180", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public ONDMBBPPJJI PPIDDAAMDEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x9B6910", Offset = "0x9B5910", VA = "0x1809B6910", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public SkinnedMeshRenderer[] BNMPOAGDGLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x1257670", Offset = "0x1256670", VA = "0x181257670", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public Renderer[] GDIOLJBNEIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x7CB830", Offset = "0x7CA830", VA = "0x1807CB830", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool ALDKMOEAMAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x616C570", Offset = "0x616B570", VA = "0x18616C570", Slot = "20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public FNNENMGHBAG.DJLKMCOMPKG EDLOECKIIID
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0xEAD750", Offset = "0xEAC750", VA = "0x180EAD750", Slot = "18")]
		get
		{
			return default(FNNENMGHBAG.DJLKMCOMPKG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int JFABOAFKOIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x851C30", Offset = "0x850C30", VA = "0x180851C30")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x6164800", Offset = "0x6163800", VA = "0x186164800")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	private bool APGBEMBJDBM
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x6167E10", Offset = "0x6166E10", VA = "0x186167E10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	private static bool POILBFNJABE
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x6167690", Offset = "0x6166690", VA = "0x186167690")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x616FAA0", Offset = "0x616EAA0", VA = "0x18616FAA0")]
	public BAPAEDLJOFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6165B50", Offset = "0x6164B50", VA = "0x186165B50", Slot = "21")]
	public void CJMKLAKCCOG(DFHLMLLLEGL OIBOCGBDCFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6166540", Offset = "0x6165540", VA = "0x186166540", Slot = "22")]
	public void DMPOJHDKGNP(IDCBPBLAGOH LDOCPPMGOOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6164800", Offset = "0x6163800", VA = "0x186164800", Slot = "4")]
	public void HHOPAEFBNEJ(int ODIANCNJLNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x616C1C0", Offset = "0x616B1C0", VA = "0x18616C1C0", Slot = "9")]
	public void MLAGPEMNHLD(CGIAAAPLCFO HFOFOOENJDD, Texture2D JLEFELGPFPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6168260", Offset = "0x6167260", VA = "0x186168260", Slot = "10")]
	public void JCGHPIKEJJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x616F310", Offset = "0x616E310", VA = "0x18616F310", Slot = "11")]
	public bool PGDAGFEDIPA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6169C20", Offset = "0x6168C20", VA = "0x186169C20", Slot = "8")]
	public void LONCLLPKENA(AOCJJEAHFDD ELOKGPPOHEI, Color? IODHIPGGADP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x616EEB0", Offset = "0x616DEB0", VA = "0x18616EEB0")]
	private void PDFGJJEHKNE(Action NECHFPJGBHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6167F20", Offset = "0x6166F20", VA = "0x186167F20", Slot = "5")]
	public void IEKHCNJJGJJ(DKMBDLGCKIC PIKJJIDHPLF, Texture KIOMNHJEMEA, Color GJJOAMKLDKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6164910", Offset = "0x6163910", VA = "0x186164910", Slot = "6")]
	public void BHNIFOFEGLJ(bool DMHCJEHMCDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x9AB7F0", Offset = "0x9AA7F0", VA = "0x1809AB7F0", Slot = "7")]
	public void OFCJIPLOAJC(AKIKLMHKCBM FBCKOOIGNJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x616CEF0", Offset = "0x616BEF0", VA = "0x18616CEF0", Slot = "14")]
	public HNENBNAEPGI OEJCFMIGBPN(JGGPPDNFDLP BABBBFOKLNK, bool HNFIBIFIGGN, int[] CHAKLHHFEMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x616F650", Offset = "0x616E650", VA = "0x18616F650", Slot = "15")]
	public void PPDGMOAGCLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6169810", Offset = "0x6168810", VA = "0x186169810")]
	private bool LIDHCCLKFMC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0xEAD840", Offset = "0xEAC840", VA = "0x180EAD840", Slot = "19")]
	public void JPOAHNGALKA(FNNENMGHBAG.DJLKMCOMPKG DFDECPEFGAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x616EDF0", Offset = "0x616DDF0", VA = "0x18616EDF0")]
	private bool OLDFPIOPNJP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x616BB10", Offset = "0x616AB10", VA = "0x18616BB10")]
	private HNENBNAEPGI MILIALGBGJL(bool HNFIBIFIGGN, List<HJMAINCPENL> LNBBBHBFMPE, int[] CHAKLHHFEMM, Func<int, OOPMOAHEAAE> DGCIPIJICKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x616CDE0", Offset = "0x616BDE0", VA = "0x18616CDE0")]
	[IteratorStateMachine(typeof(DJLPDGMHGGG))]
	private IEnumerator<JHIBCIKJMBL> OCCIABCHCFE(bool HNFIBIFIGGN, List<HJMAINCPENL> LNBBBHBFMPE, int[] CHAKLHHFEMM, Func<int, OOPMOAHEAAE> DGCIPIJICKO, JBDICGPJOOE DBHDHBBEDCL, Material MOICJJDOOPO, List<HNENBNAEPGI> DDOJJPHHJHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x61682E0", Offset = "0x61672E0", VA = "0x1861682E0")]
	private HNENBNAEPGI JFBHCLAFALB(List<HJMAINCPENL> LNBBBHBFMPE, int[] CHAKLHHFEMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x616A020", Offset = "0x6169020", VA = "0x18616A020")]
	private EOCGEKKEBMP LPBAMLDBLGD(List<HJMAINCPENL> LNBBBHBFMPE, int ODIANCNJLNI, bool HNFIBIFIGGN, OOPMOAHEAAE AHMOKAPAGAF, bool AIJDIBIELLO, JBDICGPJOOE DBHDHBBEDCL, Material MOICJJDOOPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6168050", Offset = "0x6167050", VA = "0x186168050")]
	private void IPHPLOFBKID(SkinnedMeshRenderer LNJPBHOHDPC, Mesh GCFMCPMBPPI, List<Material> IFEGPDGHEKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x616CC70", Offset = "0x616BC70", VA = "0x18616CC70")]
	private static Material NMBANKNFENN(Dictionary<DKIBHHMPOGM, Material> JILGADGJGAC, Material JPNMKDFJNPC, JGCMAKPKDNA JHBIJEFOCHH, EAKHHCOPMLP FEPPHNMIEHI, CNEMEHGENOO NACOKOOJCEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6167A70", Offset = "0x6166A70", VA = "0x186167A70")]
	private static JGCMAKPKDNA HPJBAPCPMEJ(HJMAINCPENL ONFKLJKFKCK, int FHEIAMKMCCG)
	{
		return default(JGCMAKPKDNA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6164240", Offset = "0x6163240", VA = "0x186164240")]
	private void AJMAGPPGOOI(int PJHGKEFEHMG, Material JANOPPPMNPE, HJMAINCPENL ONFKLJKFKCK, [Out] Texture2D AOBKJHAJPGI, [Out] Vector4 GCKKLPNPBLH, [Out] Texture2D PBAFPIGJMJB, [Out] Texture2D EGGLCGLEACO, [Out] Texture2D MGOIOCMOBLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6168FC0", Offset = "0x6167FC0", VA = "0x186168FC0")]
	private void LAHBEBHFGIA(int PJHGKEFEHMG, Material JANOPPPMNPE, HJMAINCPENL ONFKLJKFKCK, [Out] Color LNAMMKONBMO, [Out] Color IPOKILNEKNH, [Out] Color FGFEPGDOKJC, [Out] Color BGNHBBOMPGD, [Out] Color ICBLOGFANCL, [Out] Color EFNKBCPGLEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x616EB90", Offset = "0x616DB90", VA = "0x18616EB90")]
	private bool OKJOMKPIFIP(Material JANOPPPMNPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x616F490", Offset = "0x616E490", VA = "0x18616F490")]
	private static Material PHEOOLKJPIH(int PJHGKEFEHMG, GEIFLDNFNGH ONFKLJKFKCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6164820", Offset = "0x6163820", VA = "0x186164820")]
	private static EAKHHCOPMLP BHELOIDIGNC(HJMAINCPENL ONFKLJKFKCK, int FHEIAMKMCCG)
	{
		return default(EAKHHCOPMLP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6166E00", Offset = "0x6165E00", VA = "0x186166E00")]
	private static void FCDILMDJHCN(Dictionary<string, List<DKIBHHMPOGM>> KBBJLBLDOLJ, HJMAINCPENL LCNFIIJKLBK, Material JPNMKDFJNPC, JGCMAKPKDNA ELOKGPPOHEI, EAKHHCOPMLP HFOFOOENJDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x616CA40", Offset = "0x616BA40", VA = "0x18616CA40")]
	private static SkinnedMeshRenderer NLFMELAHIML(Transform DFMLHAEGPAM, Transform PPEGODPPNIJ, SkinnedMeshRenderer[] LAGPCDOPHFA, int ODIANCNJLNI, OOPMOAHEAAE AHMOKAPAGAF, bool HNFIBIFIGGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x616F0F0", Offset = "0x616E0F0", VA = "0x18616F0F0")]
	private void PFBJJDFPFLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6166A10", Offset = "0x6165A10", VA = "0x186166A10")]
	private void ENDFLFCNFCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6167910", Offset = "0x6166910", VA = "0x186167910")]
	private static void HMBCOEADCIL(Dictionary<DKIBHHMPOGM, Material> JILGADGJGAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6164920", Offset = "0x6163920", VA = "0x186164920")]
	private static void BOIECJBPEGM(Dictionary<Renderer, JBDICGPJOOE> JGFPBJEDGIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6169650", Offset = "0x6168650", VA = "0x186169650")]
	private void LGJAHKDMCHF(SkinnedMeshRenderer[] LAGPCDOPHFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6169770", Offset = "0x6168770", VA = "0x186169770")]
	private void LHELNJDBPGL(SkinnedMeshRenderer CLCMCFGELDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6164060", Offset = "0x6163060", VA = "0x186164060")]
	private void AJJMBAMKDBI(List<GHIFGBAJKGA> KAFJJBMJHDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6169A10", Offset = "0x6168A10", VA = "0x186169A10")]
	private void LOEJKGMPLPK(Dictionary<string, DBHPMDCPDMB<Texture2D>> KBBJLBLDOLJ, bool LEPKOGJDBMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x61685A0", Offset = "0x61675A0", VA = "0x1861685A0")]
	private void JHBAFCFCFOK(Dictionary<string, List<DKIBHHMPOGM>> KBBJLBLDOLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x61665C0", Offset = "0x61655C0", VA = "0x1861665C0")]
	private void DPCGIHKMPJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x61694C0", Offset = "0x61684C0", VA = "0x1861694C0")]
	private void LAIIJBIHJBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6165600", Offset = "0x6164600", VA = "0x186165600")]
	private void BPFHKCAPIMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x616C0F0", Offset = "0x616B0F0", VA = "0x18616C0F0")]
	private void MKNPLCCDACN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x61664B0", Offset = "0x61654B0", VA = "0x1861664B0")]
	private void DMNKBBJLAIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x61667D0", Offset = "0x61657D0", VA = "0x1861667D0")]
	private void EEKKDMCGGOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x616F580", Offset = "0x616E580", VA = "0x18616F580")]
	private void POGKGMBHKHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x61686E0", Offset = "0x61676E0", VA = "0x1861686E0")]
	private void JLBEOINDIDJ(bool FOIFHEGACBH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x616BA40", Offset = "0x616AA40", VA = "0x18616BA40")]
	private void MCCPLEINNKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6166D60", Offset = "0x6165D60", VA = "0x186166D60")]
	private void FBCGJMCCIGC(bool FOIFHEGACBH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6166A20", Offset = "0x6165A20", VA = "0x186166A20")]
	private void EOJLJBJDPLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6168C50", Offset = "0x6167C50", VA = "0x186168C50")]
	private void KPCEOPLALLC(Material MOICJJDOOPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6168B60", Offset = "0x6167B60", VA = "0x186168B60")]
	private void KINONDHKMND(Material MOICJJDOOPO, Color IPOKILNEKNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6168170", Offset = "0x6167170", VA = "0x186168170")]
	private void JBCADGAONHC(Material MOICJJDOOPO, Color FGFEPGDOKJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6166920", Offset = "0x6165920", VA = "0x186166920")]
	private void EIABLEEMJMO(Material MOICJJDOOPO, Color LNAMMKONBMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x61685F0", Offset = "0x61675F0", VA = "0x1861685F0")]
	private void JIBDNOBFIHB(Material MOICJJDOOPO, Texture2D JLEFELGPFPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x6165E10", Offset = "0x6164E10", VA = "0x186165E10")]
	private void CNHKKEMBAGN(Material MOICJJDOOPO, Texture GPPLPANKGND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x6167420", Offset = "0x6166420", VA = "0x186167420")]
	private void FIIOJJNGMKP(Action<JBDICGPJOOE> NFMHHHAFKEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x616C3D0", Offset = "0x616B3D0", VA = "0x18616C3D0")]
	private void NGIGNAKALHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x616C6E0", Offset = "0x616B6E0", VA = "0x18616C6E0")]
	private void NKKGBJDODCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x616E5A0", Offset = "0x616D5A0", VA = "0x18616E5A0")]
	private HNENBNAEPGI OJFBNDDJEHO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x61687B0", Offset = "0x61677B0", VA = "0x1861687B0")]
	private void KHCLGHILHCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6165F00", Offset = "0x6164F00", VA = "0x186165F00")]
	public void DBELKACNBBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x616F510", Offset = "0x616E510", VA = "0x18616F510")]
	private void PJBIGOJBCGP(Vector3 IGEPLDPOGMF, Quaternion FOPINBOOFFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x61670D0", Offset = "0x61660D0", VA = "0x1861670D0")]
	private void FEOBNBCILKD(List<HJMAINCPENL> OKGJEEJLCCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x6164A80", Offset = "0x6163A80", VA = "0x186164A80")]
	public void BOLHOJKOKHN(EDFIKEGMLOC FNILPGGFHPJ, bool LENCICCLAAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6164F80", Offset = "0x6163F80", VA = "0x186164F80")]
	public void BOLHOJKOKHN(EDFIKEGMLOC FNILPGGFHPJ, AnchorParamsRestrictions BHOPNFNPPGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x8AFB00", Offset = "0x8AEB00", VA = "0x1808AFB00")]
	private static void LBBAKABHMPK(FitMeshHemisphere IEAAAPHPIMK, Transform DCIPIHNKABE, EDFIKEGMLOC FNILPGGFHPJ, AnchorParamsRestrictions BODDDJFLADL, [Out] Vector3 CMCMKLBCKPK, [Out] Quaternion JOFKHOOOHCD, [Out] EDFIKEGMLOC PECDKBPGKFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x616EF30", Offset = "0x616DF30", VA = "0x18616EF30")]
	public void PEJJJNBLGBJ(Vector2 FPLLEHKNJAC, Vector3 POEENFBKCKJ, Vector3 JIOFGMFFAJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x6167B90", Offset = "0x6166B90", VA = "0x186167B90")]
	private void HPKLIJMAGCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x6167D80", Offset = "0x6166D80", VA = "0x186167D80")]
	private void IBINPBNHGCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x6166420", Offset = "0x6165420", VA = "0x186166420")]
	[CompilerGenerated]
	private void DKJABEIHKON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x6168780", Offset = "0x6167780", VA = "0x186168780")]
	[CompilerGenerated]
	private void KGAJPJKIPDI(JBDICGPJOOE COKEKNPDKAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x6164770", Offset = "0x6163770", VA = "0x186164770")]
	[CompilerGenerated]
	private void APEHDGKLNIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6166720", Offset = "0x6165720", VA = "0x186166720")]
	[CompilerGenerated]
	private void EAOPPCOMDHG(JBDICGPJOOE COKEKNPDKAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6167E90", Offset = "0x6166E90", VA = "0x186167E90")]
	[CompilerGenerated]
	private void IEGEGKIAPBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x616C550", Offset = "0x616B550", VA = "0x18616C550")]
	[CompilerGenerated]
	private void NHPNPHIMCFP(JBDICGPJOOE COKEKNPDKAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x616E510", Offset = "0x616D510", VA = "0x18616E510")]
	[CompilerGenerated]
	private void OINJJFNFMLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x6169950", Offset = "0x6168950", VA = "0x186169950")]
	[CompilerGenerated]
	private void LLNJCABGGKJ(JBDICGPJOOE COKEKNPDKAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x6167830", Offset = "0x6166830", VA = "0x186167830")]
	[CompilerGenerated]
	private void HDMKJLKJPJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x616BA10", Offset = "0x616AA10", VA = "0x18616BA10")]
	[CompilerGenerated]
	private void MADALCKICIF(JBDICGPJOOE COKEKNPDKAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6169980", Offset = "0x6168980", VA = "0x186169980")]
	[CompilerGenerated]
	private void LMMDKPFIKCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6164030", Offset = "0x6163030", VA = "0x186164030")]
	[CompilerGenerated]
	private void AHHFMBNNADA(JBDICGPJOOE COKEKNPDKAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6169B90", Offset = "0x6168B90", VA = "0x186169B90")]
	[CompilerGenerated]
	private void LONBHCLNOMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x61673F0", Offset = "0x61663F0", VA = "0x1861673F0")]
	[CompilerGenerated]
	private void FFHMNFPNFLC(JBDICGPJOOE COKEKNPDKAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x61675E0", Offset = "0x61665E0", VA = "0x1861675E0")]
	[CompilerGenerated]
	private void FLKIILDECGH(KeyValuePair<string, DBHPMDCPDMB<Texture2D>> DJGDAECDKLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x6166740", Offset = "0x6165740", VA = "0x186166740")]
	[CompilerGenerated]
	private void EAPHODHJKNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x6168020", Offset = "0x6167020", VA = "0x186168020")]
	[CompilerGenerated]
	private void IKEDHPMELOH(JBDICGPJOOE COKEKNPDKAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x6167F90", Offset = "0x6166F90", VA = "0x186167F90")]
	[CompilerGenerated]
	private void IKCHFDKHGNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6167660", Offset = "0x6166660", VA = "0x186167660")]
	[CompilerGenerated]
	private void HAGNNOPOMMA(JBDICGPJOOE COKEKNPDKAI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class JIKJGGIPMNK : IDKEEJLCMGB
{
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private static readonly int FPJGBBBPCHJ;

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private static readonly int OLJNCCHPAJK;

	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private static readonly int NKFFCILHOKO;

	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private static readonly int KEGINGKCJAG;

	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private static readonly int ENFEGGJOILA;

	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private static readonly int IHLJGPMLOIE;

	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private static readonly int JEECAKEKDGG;

	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private static readonly int AELGHFIFNEB;

	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private static readonly int NMGPICANLDH;

	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private static readonly int DGCGNKNKICI;

	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private static readonly int IGAOMEHDNNM;

	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private static readonly int AIGMDHPNOBG;

	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private static readonly int NMODAPPAIHC;

	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private static readonly int GKKENHOEKOE;

	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private static readonly int OFFMMACNDDD;

	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private static readonly int AIKBBEBNGCM;

	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private static readonly int NAJLGJEEOGC;

	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private static readonly int NPCECLKPBBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private Transform BNPBECPPODJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private Transform KKKLHFBNBBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private Transform MKFDGOEIEDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private Transform BPEAFOCNGJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private Transform BPECNGKBNJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	private Transform CBAINONABKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	private Transform IODDFDHKEDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private LOJDLDOFCNE NGMOICKCFHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	private MaterialPropertyBlock JGAMABDECME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	private SkinnedMeshRenderer[] CCECCAPIHDH;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	private MaterialPropertyBlock MIAHJGMCKKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x61764B0", Offset = "0x61754B0", VA = "0x1861764B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x6175FC0", Offset = "0x6174FC0", VA = "0x186175FC0", Slot = "6")]
	public void CJMKLAKCCOG(LOJDLDOFCNE OKJFGABHGDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x61765C0", Offset = "0x61755C0", VA = "0x1861765C0", Slot = "7")]
	public void IIKKKBPCALO(ILKKDPDJKAI LDHEOMDLHAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x6176080", Offset = "0x6175080", VA = "0x186176080", Slot = "4")]
	public void GBMLNICOJHE(HDBOEFNBABK FOFLJLOKBGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x6176A20", Offset = "0x6175A20", VA = "0x186176A20")]
	private Vector2 JBFCPDCIIAE(Vector2 OIENDCDGLGJ)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x6176A80", Offset = "0x6175A80", VA = "0x186176A80", Slot = "5")]
	public void KMDBKNJDHHO(JEBHPBONFGK LDHEOMDLHAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x61766D0", Offset = "0x61756D0", VA = "0x1861766D0")]
	private void JAJECEHIPMI(JEBHPBONFGK ACFNGOLAOKB, CBGJBFLAIJK HMLNIEKBFLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x61765F0", Offset = "0x61755F0", VA = "0x1861765F0")]
	private void JAFEBBENEGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x6177F00", Offset = "0x6176F00", VA = "0x186177F00")]
	public JIKJGGIPMNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x6176530", Offset = "0x6175530", VA = "0x186176530")]
	[CompilerGenerated]
	internal static (float, float) HOFJFMOFDCJ(float CAEAEHPNOME)
	{
		return default((float, float));
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x6177B90", Offset = "0x6176B90", VA = "0x186177B90")]
	[CompilerGenerated]
	internal static Vector4 OGPDDOONPGI(Vector2 BJIKBOECFPB, Vector2 GJBNAOHDFNK)
	{
		return default(Vector4);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class JBDICGPJOOE : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	private MaterialPropertyBlock GFLHJOGGJGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	public Color? ILOCAHFKCFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	public Color? NOEIACKKKEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	public Color? ADAHFPCLFDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	public Color? NDCHAJHAKNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	public Color BCMIJPJAMIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	public Color HKHGLIMFFCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	public Color GJCLCBFPLHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	public Texture2D GCCNHHPJCDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	public Texture2D BOPPFNKCLJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private Dictionary<DKIBHHMPOGM, int> IAAJPIGMMDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private JGCMAKPKDNA[] HCNPNBHJJHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private EAKHHCOPMLP[] CLLGCEDGKJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	public Vector4[] GLPHGBKACEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	public Vector4[] FBFGLLBLMMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	public Vector4[] CHBBFOMMJFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	public Vector4[] FDCMOJLFGNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	public Vector4[] GKLHECLGKFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	public Vector4[] JBCAEMAPKHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private List<Texture2D> EGGKNEACGCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private Vector4[] ALECCIGOELP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private List<Texture2D> OKGOAKOCBMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private float[] CJJGJBICEMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private Vector4[] NDFHGNOGADE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private float[] FCGOHLJCJEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	public float[] BFCAIOAIOGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private List<Texture2D> FPILNMFAFEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private float[] PPGGFFCEGOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private List<Texture2D> FEBGCOAAMAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private Vector4[] ODGBNLHALCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private float[] AJPPDIAOOCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private Vector4[] DEBHFKJALPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	public float[] NDFOAKGJCCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	public Texture2DArray FJAJCJIELND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	public Texture2DArray EPOAANJHBLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	public Texture2DArray ILMFFLBCALH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	public Texture2DArray LNJBDHFJKJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	private bool IMONBIEKACA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x184")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private int CJIJINDEENI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	private Vector2? FBPJEKFPHIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x194")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	private TextureFormat PPODKGGFJGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private Vector2? PDAMABANMOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A4")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	private TextureFormat LJBOINJBCKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	private Vector2? GIOGCIFLJHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B4")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	private TextureFormat IMNEPEODFKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	private Vector2? JJIMOLHPIIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C4")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	private TextureFormat LMFADAMCALB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	private bool OBBFCMJHMOD;

	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private static int HDFJNHNOJPE;

	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private static int NAOJNJJDOCH;

	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private static int CCFODEBMHNJ;

	[Cpp2IlInjected.Token(Token = "0x4000168")]
	private static int CELBMGEONIB;

	[Cpp2IlInjected.Token(Token = "0x4000169")]
	private static int CICAOEAMKCH;

	[Cpp2IlInjected.Token(Token = "0x400016A")]
	private static int AJFPNODAKKM;

	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private static int LKLDNEOOEOM;

	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private static int FOOGEOAALLP;

	[Cpp2IlInjected.Token(Token = "0x400016D")]
	private static int AADFLNJAHFI;

	[Cpp2IlInjected.Token(Token = "0x400016E")]
	private static int OIECDAIIOII;

	[Cpp2IlInjected.Token(Token = "0x400016F")]
	private static int LDICJJIGLCH;

	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private static int HBEJAFACHIG;

	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private static int OPDELDPGKHP;

	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private static int JNLBFGCNIHC;

	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private static int PDDMLAECBOM;

	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private static int EGKAGLFKAAA;

	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private static int GHMMBIKODKC;

	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private static int NOOMKLENNOK;

	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private static int BAPIKJBCEJO;

	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private static int OMOFFOHPACP;

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x6184710", Offset = "0x6183710", VA = "0x186184710")]
	private JBDICGPJOOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x6184650", Offset = "0x6183650", VA = "0x186184650")]
	public JBDICGPJOOE(Color LAMJEKJCOIL, Color KKNDEDCHODL, Color FKDJFMEDAGN, Color? OACJBJDCLDJ, Color? FCOBHCFNBMH, Color? KOFMPFCBLLO, Texture2D AMANDGAJLKE, Texture2D BDOBMEMBJEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x6182C30", Offset = "0x6181C30", VA = "0x186182C30")]
	internal int BNMOJAOGHPL(Material LMMFCPEMJNK, JGCMAKPKDNA JHBIJEFOCHH, EAKHHCOPMLP FEPPHNMIEHI, CNEMEHGENOO NACOKOOJCEO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x6182BA0", Offset = "0x6181BA0", VA = "0x186182BA0")]
	private int BNMOJAOGHPL(DKIBHHMPOGM OHNEPKBBADL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x6181FD0", Offset = "0x6180FD0", VA = "0x186181FD0")]
	internal int APIHPKAPPKL(Material LMMFCPEMJNK, Color LNAMMKONBMO, Color IPOKILNEKNH, Color FGFEPGDOKJC, Color BGNHBBOMPGD, Color ICBLOGFANCL, Texture2D IHONBFCDLGD, Vector4 HMEGNGLEHPN, Texture2D FOCDCPBEJNI, Vector4 HAIOBFCNHIF, float KHJKKCKCJAC, float KIKHPLHKNJB, Texture2D FONLNAJHPNL, Vector4 LGIJPKAHFKG, float JJCLAIANNCK, Texture2D CPJHCLNDHMG, Color EFNKBCPGLEB, Vector4 IIGLPDMHLAI, JGCMAKPKDNA JHBIJEFOCHH, EAKHHCOPMLP FEPPHNMIEHI, CNEMEHGENOO NACOKOOJCEO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x61833B0", Offset = "0x61823B0", VA = "0x1861833B0")]
	private void NJOOGBKMBAN(List<Texture2D> EGGKNEACGCA, [Out] Texture2DArray GLJMBFOPJNL, [Out] Texture2DArray IIJFHBLHHHI, [Out] Texture2DArray DEJFGHNJOJG, [Out] Texture2DArray GCKMJJEIOPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x6183260", Offset = "0x6182260", VA = "0x186183260")]
	public void KOMLJOJFHBE(Shader NMGALIJPMLH, Renderer GHMFIGHJGLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x6183570", Offset = "0x6182570", VA = "0x186183570")]
	private void POCAPFFJDPA(Shader NMGALIJPMLH, Renderer GHMFIGHJGLK, int OHFDLNOIJPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x6183060", Offset = "0x6182060", VA = "0x186183060")]
	private Color KEPFHBFFODO(Color MGHBMLLECFD, JGCMAKPKDNA ELOKGPPOHEI)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x6182D20", Offset = "0x6181D20", VA = "0x186182D20")]
	private Color BOOPOCAPLON(Color ILOMFBNGMEM, JGCMAKPKDNA ELOKGPPOHEI)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x6182F60", Offset = "0x6181F60", VA = "0x186182F60")]
	private bool FFDOMELEDCF(Texture2D KDFGFFOBGDI, EAKHHCOPMLP HFOFOOENJDD, [Out] Texture2D INGGBJAJIDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x6182E70", Offset = "0x6181E70", VA = "0x186182E70")]
	private void BPGGLPMMNLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x6182F20", Offset = "0x6181F20", VA = "0x186182F20", Slot = "4")]
	public void Dispose()
	{
	}
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public class AvatarItemMaterial : ScriptableObject, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		[SerializeField]
		[Obsolete("Use CombinationId instead!")]
		private string Guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		[SerializeField]
		private SerializedCombinationId combinationId;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		private FFGEBEJJBKI? cachedMaterialCombinationId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		[SerializeField]
		private Material material;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		[SerializeField]
		private Material[] additionalMaterials;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public MGKJIIAIDFC CombinationId
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x617B470", Offset = "0x617A470", VA = "0x18617B470")]
			get
			{
				return default(MGKJIIAIDFC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public FFGEBEJJBKI MaterialCombinationId
		{
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x617B4C0", Offset = "0x617A4C0", VA = "0x18617B4C0")]
			get
			{
				return default(FFGEBEJJBKI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public Material Material
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x7C7960", Offset = "0x7C6960", VA = "0x1807C7960")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public Material[] AdditionalMaterials
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x7CB7F0", Offset = "0x7CA7F0", VA = "0x1807CB7F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x617B2B0", Offset = "0x617A2B0", VA = "0x18617B2B0")]
		public Material[] JFAGMJHIAEP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x617B0F0", Offset = "0x617A0F0", VA = "0x18617B0F0")]
		public static void FFIBJAODPBL(AvatarItemMaterial MCHNDCIPAFN, Material JANOPPPMNPE, int PJHGKEFEHMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x7C06C0", Offset = "0x7BF6C0", VA = "0x1807C06C0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x7C06C0", Offset = "0x7BF6C0", VA = "0x1807C06C0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x617B3A0", Offset = "0x617A3A0", VA = "0x18617B3A0")]
		public AvatarItemMaterial()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[GMMEGLMLLJK]
public struct HBJBEPCCNOD : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	[ReadOnly]
	public DHLCKAHAOKM MABNHOHIFFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	[ReadOnly]
	public int IGPOEOOOJGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	public CAAKOKNPJFC BDPENIPNEFG;

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x6180640", Offset = "0x617F640", VA = "0x186180640", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[NativeContainer]
[GMMEGLMLLJK]
public struct CAAKOKNPJFC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	public NativeArray<Vector3> MFJKGNNFHMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	public NativeArray<Vector3> BHLPJPCBHMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	public NativeArray<Vector4> MIMPMODPKLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	public NativeArray<Vector2> OBKEBJHFLKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	public NativeArray<Vector2> CLDGHMCIEHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	public NativeArray<Vector2> LIDOLNNDIDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	public NativeArray<Vector2> AJPPGKJFGAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	public NativeArray<Color> MHEELGDFONE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	public NativeArray<int> OHAGBGJFDKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	public NativeArray<int> NBMNMHCPHII;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	private NativeArray<int> CLHIHJKLIEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	private NativeArray<int> HBLLFBNHBAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	public NativeArray<int> BMLMAFJGAPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	public NativeArray<int> FJKMIBDMNEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	public NativeArray<int> GBIPDILLAEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	public NativeArray<BoneWeight> CMDFFIKCFLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	private NativeArray<int> FBCKOOIGNJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	private bool GHOGBAGIIHL;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public int BCHGLKCECFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x617B720", Offset = "0x617A720", VA = "0x18617B720")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x617BE90", Offset = "0x617AE90", VA = "0x18617BE90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public int GPDCGJLEACB
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x617BEB0", Offset = "0x617AEB0", VA = "0x18617BEB0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x617BB10", Offset = "0x617AB10", VA = "0x18617BB10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public int JMAIHBBMJMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x617BB20", Offset = "0x617AB20", VA = "0x18617BB20")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x617BEA0", Offset = "0x617AEA0", VA = "0x18617BEA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x617BFD0", Offset = "0x617AFD0", VA = "0x18617BFD0")]
	public CAAKOKNPJFC(int CMIDHCIJCIP, int BNJHCHHFGLD, int CILGFFIHKDE, int PJJIPDOKOKG, Allocator NFBFCGHLHAF, int NGCPPOODCCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x617BF60", Offset = "0x617AF60", VA = "0x18617BF60")]
	public void PHHEACFADII(int GPEHCABDGEJ, Vector3 JFNFFLEPNAC, Vector3 MBGPCNKOEPO, Vector4 DCCCOAOAGBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x617B580", Offset = "0x617A580", VA = "0x18617B580")]
	public void ADDHCHBIJPC(int GPEHCABDGEJ, BoneWeight AOKEJKDDOAB, NativeSlice<byte> CMGICLLHFCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x617BEC0", Offset = "0x617AEC0", VA = "0x18617BEC0")]
	public Color NFOJJJDIKKP(int GPEHCABDGEJ)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x617BA40", Offset = "0x617AA40", VA = "0x18617BA40")]
	public void EKIJGBBEGGA(int GPEHCABDGEJ, Color PPMIKHJHPEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x617BF10", Offset = "0x617AF10", VA = "0x18617BF10")]
	public void OHAPJFPOCKN(byte GBDFAIHMEGC, int GPEHCABDGEJ, Vector2 HKNGGDKEMIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x617BB30", Offset = "0x617AB30", VA = "0x18617BB30")]
	public void JFMIIDLNOPF(int GPEHCABDGEJ, int HKCEPJPCLIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x617BEE0", Offset = "0x617AEE0", VA = "0x18617BEE0")]
	public bool ODMHOFECLFB(int GBDFAIHMEGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x617B970", Offset = "0x617A970", VA = "0x18617B970")]
	public void EABDLCDDGGD(int DKIDGNPOAEI, int NGKDOMEFDDB, int GOKGFKKLOOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x617BA60", Offset = "0x617AA60", VA = "0x18617BA60")]
	public int[] GNGEIBJGBDA(int DKIDGNPOAEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x617B730", Offset = "0x617A730", VA = "0x18617B730")]
	private NativeSlice<int> BFAKAKJJOMK(int DKIDGNPOAEI)
	{
		return default(NativeSlice<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x617B7C0", Offset = "0x617A7C0", VA = "0x18617B7C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x617BB40", Offset = "0x617AB40", VA = "0x18617BB40")]
	public Mesh KIOEHOKMEDF([Optional] string PDLOLFGFHEC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[NativeContainer]
[DefaultMember("Item")]
[GMMEGLMLLJK]
public struct DHLCKAHAOKM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	public NativeArray<Vector3> MFJKGNNFHMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	public NativeArray<Vector3> BHLPJPCBHMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	public NativeArray<Vector4> MIMPMODPKLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	public NativeArray<Vector2> OBKEBJHFLKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	public NativeArray<Vector2> CLDGHMCIEHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	public NativeArray<Vector2> LIDOLNNDIDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	public NativeArray<Vector2> AJPPGKJFGAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	public NativeArray<Color> MHEELGDFONE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	public NativeArray<int> FPBGFLLMPJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	public NativeArray<int> DFAFGDKJMJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	public NativeArray<int> KCFBBKFNPAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	public NativeArray<int> ANLLPMNOKAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	public NativeArray<bool> PDGJEINJDEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	public NativeArray<int> OGKDCFFFKOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	public NativeArray<int> FNEKDGKMHEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	public NativeArray<BoneWeight> BEMLMNJDOBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	private NativeArray<Matrix4x4> MKLBINGGOFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	private NativeArray<int> GCIJJOHHMPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	private NativeArray<byte> NAAJJODPHDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private NativeArray<int> IEIIODLBMIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private NativeArray<int> AEMAPOBJALB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	public NativeArray<sbyte> NLCDCNNNNCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	public NativeArray<byte> IELHMDJEGAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	private NativeArray<int> CMBGJLMNOCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	private bool GHOGBAGIIHL;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public int FPJAACGFOOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x1E64090", Offset = "0x1E63090", VA = "0x181E64090")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public int KJMBLAAJHOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0xEAD750", Offset = "0xEAC750", VA = "0x180EAD750")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public int BKNICHFLKJB
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x617D8B0", Offset = "0x617C8B0", VA = "0x18617D8B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public int CBMOGFDICKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x617CFD0", Offset = "0x617BFD0", VA = "0x18617CFD0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x617D270", Offset = "0x617C270", VA = "0x18617D270")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public int BCHGLKCECFG
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x617CFE0", Offset = "0x617BFE0", VA = "0x18617CFE0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x617D360", Offset = "0x617C360", VA = "0x18617D360")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public int AFKPOAGNOEI
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x617D380", Offset = "0x617C380", VA = "0x18617D380")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x617CFF0", Offset = "0x617BFF0", VA = "0x18617CFF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public LLDOGCENKDM MLNDFDCMNNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x617D000", Offset = "0x617C000", VA = "0x18617D000")]
		get
		{
			return default(LLDOGCENKDM);
		}
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x617D350", Offset = "0x617C350", VA = "0x18617D350")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public byte HPKBKKAACAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x617D8E0", Offset = "0x617C8E0", VA = "0x18617D8E0")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x617D370", Offset = "0x617C370", VA = "0x18617D370")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public NELBKDIBHNJ EAGDGAFFDEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x617D390", Offset = "0x617C390", VA = "0x18617D390")]
		get
		{
			return default(NELBKDIBHNJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x617D8F0", Offset = "0x617C8F0", VA = "0x18617D8F0")]
	public DHLCKAHAOKM(IList<Mesh> NICBHFFLODF, IList<Matrix4x4> GDBDBPAOFKL, IList<bool> PDGJEINJDEJ, byte OJMGJAGCIDP, IList<byte[]> LOJHFEINCIO, IList<int> IANIIOOKCPJ, IList<bool> KCPODJCIKAE, IList<int> OGKDCFFFKOF, IList<int> NMLNGBLGGEC, IList<int> LMPKJFKPHII, Allocator NFBFCGHLHAF, LLDOGCENKDM PEKIIJAJMMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x617D280", Offset = "0x617C280", VA = "0x18617D280")]
	public CAAKOKNPJFC FDHMEEHOOPH(Allocator NFBFCGHLHAF)
	{
		return default(CAAKOKNPJFC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x617D010", Offset = "0x617C010", VA = "0x18617D010", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[GMMEGLMLLJK]
public class MFKFAOOMKEC : ACPLDHMKLOD
{
	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x6185380", Offset = "0x6184380", VA = "0x186185380")]
	public DHLCKAHAOKM MFMPGPBJENJ()
	{
		return default(DHLCKAHAOKM);
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x6173450", Offset = "0x6172450", VA = "0x186173450")]
	public MFKFAOOMKEC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public struct NELBKDIBHNJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	public NativeSlice<Vector3> MFJKGNNFHMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	public NativeSlice<Vector3> BHLPJPCBHMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	public NativeSlice<Vector4> MIMPMODPKLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	public NativeSlice<Vector2> OBKEBJHFLKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	public NativeSlice<Vector2> CLDGHMCIEHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	public NativeSlice<Vector2> LIDOLNNDIDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	public NativeSlice<Vector2> AJPPGKJFGAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	public NativeSlice<Color> MHEELGDFONE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	public NativeSlice<int> OMGAJAKFBIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	public NativeSlice<int> ANLLPMNOKAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	public NativeSlice<BoneWeight> BEMLMNJDOBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	public NativeSlice<byte> KGAGAADJKBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	public int GKOCNBOLADL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	public Matrix4x4 PFKJNGFMKEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	public int JJHJMFOKJCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	public NativeSlice<byte> CMGICLLHFCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	public bool CHIIEAFLLHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	public int ABCJEBNOEGK;
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
internal readonly struct DKIBHHMPOGM : IEquatable<DKIBHHMPOGM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	internal readonly Material CEALGPHFCPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	internal readonly JGCMAKPKDNA FLBEDCIKOKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	internal readonly EAKHHCOPMLP BCHIBLPGCPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	internal readonly CNEMEHGENOO GPDPGJENFBI;

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x8CADE0", Offset = "0x8C9DE0", VA = "0x1808CADE0")]
	public DKIBHHMPOGM(Material JANOPPPMNPE, JGCMAKPKDNA JHBIJEFOCHH, EAKHHCOPMLP FEPPHNMIEHI, CNEMEHGENOO NACOKOOJCEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x617F430", Offset = "0x617E430", VA = "0x18617F430", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x8CA9A0", Offset = "0x8C99A0", VA = "0x1808CA9A0", Slot = "4")]
	public bool Equals(DKIBHHMPOGM JNHFAFOIKEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x617F2A0", Offset = "0x617E2A0", VA = "0x18617F2A0", Slot = "0")]
	public override bool Equals(object KDEEPMDJGFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x617F390", Offset = "0x617E390", VA = "0x18617F390", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class LDNEPODEBJB
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private sealed class HGGOMOLMBJJ : IEnumerator<JHIBCIKJMBL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		private JHIBCIKJMBL <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		public JobHandle handle;

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		private JHIBCIKJMBL System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x7C29D0", Offset = "0x7C19D0", VA = "0x1807C29D0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0x7C29D0", Offset = "0x7C19D0", VA = "0x1807C29D0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x7C2AC0", Offset = "0x7C1AC0", VA = "0x1807C2AC0")]
		[DebuggerHidden]
		public HGGOMOLMBJJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x7C06C0", Offset = "0x7BF6C0", VA = "0x1807C06C0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x8CAE20", Offset = "0x8C9E20", VA = "0x1808CAE20", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x6181550", Offset = "0x6180550", VA = "0x186181550", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x7C06C0", Offset = "0x7BF6C0", VA = "0x1807C06C0")]
	public static void IBEJAPHJNNI(string JKEKANKKCCC, int ODIANCNJLNI, long PDNDLHFNIIO, long FBCOCJILAAG, long MAABFDMIJLG, long BDNBGKFAKAL, long IJCDLPHIMBF, long FNHIPOLBFAA, long DIDIGMFOBJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x6185020", Offset = "0x6184020", VA = "0x186185020")]
	public static EOCGEKKEBMP LDOJENEECNM(JobHandle BHCKLODDHIJ, bool BDIEMDBGLIE, bool LHFEPHNCHBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x6184FB0", Offset = "0x6183FB0", VA = "0x186184FB0")]
	[IteratorStateMachine(typeof(HGGOMOLMBJJ))]
	private static IEnumerator<JHIBCIKJMBL> GMMHCMKJLON(JobHandle NJADCNCCDAJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public class MILBFHEKPFC : LHOOOJOFIHI, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	private FNDAIJLACFF ILHKKDBKLOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	private MDGJADJAHFM ECJIDIBICIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	private IRecRoomQualityConfigProvider EMMNDAPDLHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	private bool GHOGBAGIIHL;

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x6185B40", Offset = "0x6184B40", VA = "0x186185B40")]
	[ILJDPBHFAFI(DIDBPCEENMM.GameOnly)]
	private static void KDNIGEBECPO(OIEDECFCIPC MJBHKMGKNLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x54E7540", Offset = "0x54E6540", VA = "0x1854E7540")]
	[UnityEngine.Scripting.Preserve]
	public MILBFHEKPFC([POILJEECDED(null)] MDGJADJAHFM MPOBKGPPHNM, [POILJEECDED(null)] FNDAIJLACFF KPOJEJNHEDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x7C06C0", Offset = "0x7BF6C0", VA = "0x1807C06C0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x6185930", Offset = "0x6184930", VA = "0x186185930")]
	private void EOPKFDLLCNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x6185AE0", Offset = "0x6184AE0", VA = "0x186185AE0", Slot = "4")]
	public void JCGHPIKEJJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x6185470", Offset = "0x6184470", VA = "0x186185470", Slot = "5")]
	public DBHPMDCPDMB<Texture2D> BMMICMDLPCL(IGDILKKPPEE CBDLPEGCFDI, [Optional] AKIKLMHKCBM FBCKOOIGNJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x61859A0", Offset = "0x61849A0", VA = "0x1861859A0")]
	private uint GPNLJNJPCPC(IGDILKKPPEE CBDLPEGCFDI, AKIKLMHKCBM FBCKOOIGNJP)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public interface HDMALKKDPPJ
{
	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OPJPFOEPONM(Mesh GCFMCPMBPPI, Matrix4x4 OIGACIFNLHF, byte[] CMGICLLHFCI, bool GINEDBGPILC = false, FNNENMGHBAG.DJLKMCOMPKG BFDNDNLHLIK = (FNNENMGHBAG.DJLKMCOMPKG)0, int OGKDCFFFKOF = -1, bool PDGJEINJDEJ = false);

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IPKKEJIBAPH(Allocator NFBFCGHLHAF, LLDOGCENKDM PEKIIJAJMMD, byte OJMGJAGCIDP, [Optional] IList<int> NMLNGBLGGEC, [Optional] IList<int> GIHNBNDAJNC);
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public readonly struct LHPGIFAAPJB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	public readonly GameObject EMLANGGFJFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	private readonly AvatarItemMaterial DGEHAKFAHIE;

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x948150", Offset = "0x947150", VA = "0x180948150")]
	public LHPGIFAAPJB(GameObject EMLANGGFJFK, AvatarItemMaterial DGEHAKFAHIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x6185170", Offset = "0x6184170", VA = "0x186185170")]
	public void NKKKCIMKNPC(Material JANOPPPMNPE, int PJHGKEFEHMG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class GABINGOJHPA : BJJCGKGJCML<Task<(GameObject, AvatarItemMaterial)>, LHPGIFAAPJB>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private struct IPOLEHAGCMA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		public AsyncTaskMethodBuilder<(GameObject, AvatarItemMaterial)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		public Task<GameObject> goTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		public Task<AvatarItemMaterial> materialTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		private GameObject <go>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		private TaskAwaiter<GameObject> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		private TaskAwaiter<AvatarItemMaterial> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x6181A60", Offset = "0x6180A60", VA = "0x186181A60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x6181F60", Offset = "0x6180F60", VA = "0x186181F60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	private DBHPMDCPDMB<GameObject> MBOJDKJJOME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	private DBHPMDCPDMB<AvatarItemMaterial> HOFHHAGPABO;

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x61805B0", Offset = "0x617F5B0", VA = "0x1861805B0")]
	private GABINGOJHPA(Task<(GameObject, AvatarItemMaterial)> BKJCIFOIBEF, DBHPMDCPDMB<GameObject> POFHDJBNEPL, DBHPMDCPDMB<AvatarItemMaterial> LLJMKMOGNNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x617FF40", Offset = "0x617EF40", VA = "0x18617FF40")]
	public static GABINGOJHPA EOFBBDOECDH(AssetReference EOGACLPLBIM, [Optional] AssetReference DOBANENEGFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x6180360", Offset = "0x617F360", VA = "0x186180360", Slot = "11")]
	protected override LHPGIFAAPJB HPKMFDJLPHL(Task<(GameObject, AvatarItemMaterial)> PLBHIDMHFCE)
	{
		return default(LHPGIFAAPJB);
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x6180400", Offset = "0x617F400", VA = "0x186180400", Slot = "12")]
	protected override void JMIGDEBPOAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x6180480", Offset = "0x617F480", VA = "0x186180480")]
	[AsyncStateMachine(typeof(IPOLEHAGCMA))]
	private static Task<(GameObject, AvatarItemMaterial)> NFLOCMFJIEC(Task<GameObject> IHPCFGHNEHH, Task<AvatarItemMaterial> CEDJLNHGMEA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public class CEGKOODAKPJ : BJJCGKGJCML<Task<(Material, MaterialMapAsset)>, Material>
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class DIIJPMIBPMN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		public Material mat;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		public MaterialEntry entry;

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		public DIIJPMIBPMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x617F230", Offset = "0x617E230", VA = "0x18617F230")]
		internal object POHKKEAMDKB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class IDJIPFLAGMG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		public string shaderNameToFind;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		public DIIJPMIBPMN CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		public IDJIPFLAGMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x61815A0", Offset = "0x61805A0", VA = "0x1861815A0")]
		internal object KKNOAGOEJNL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x6181800", Offset = "0x6180800", VA = "0x186181800")]
		internal object NDDLLDPMNLP()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private struct MCDCDACPGEC<T1, T2> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		public AsyncTaskMethodBuilder<(T1, T2)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		public Task<T1> task1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		public Task<T2> task2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		private T1 <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		private TaskAwaiter<T1> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		private TaskAwaiter<T2> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x401A1F0", Offset = "0x40191F0", VA = "0x18401A1F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x401A8A0", Offset = "0x40198A0", VA = "0x18401A8A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	private static readonly NDLEKAMCBHL LAGKGKDNMJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	private DBHPMDCPDMB<Material> MIGEABDIEBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	private DBHPMDCPDMB<MaterialMapAsset> CMAHOLGMGLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	private bool MFGFAECNEAO;

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x617CA20", Offset = "0x617BA20", VA = "0x18617CA20")]
	public static CEGKOODAKPJ KMBJAMGCNNA(AssetReference HKPLAGDBPJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x617CC60", Offset = "0x617BC60", VA = "0x18617CC60")]
	private static DBHPMDCPDMB<MaterialMapAsset> PILCCPFNNHF(AssetReference HKPLAGDBPJP, [Out] bool MFGFAECNEAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x617CF40", Offset = "0x617BF40", VA = "0x18617CF40")]
	private CEGKOODAKPJ(Task<(Material, MaterialMapAsset)> BKJCIFOIBEF, DBHPMDCPDMB<Material> MIGEABDIEBE, DBHPMDCPDMB<MaterialMapAsset> CALHHBFPEDN, bool MFGFAECNEAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x617C410", Offset = "0x617B410", VA = "0x18617C410", Slot = "11")]
	protected override Material HPKMFDJLPHL(Task<(Material, MaterialMapAsset)> PLBHIDMHFCE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x617C5F0", Offset = "0x617B5F0", VA = "0x18617C5F0")]
	private void IGFIJEOBJOO(Material GDACFBIFECH, MaterialMapAsset KBBJLBLDOLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x617C9C0", Offset = "0x617B9C0", VA = "0x18617C9C0", Slot = "12")]
	protected override void JMIGDEBPOAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x2716A30", Offset = "0x2715A30", VA = "0x182716A30")]
	[AsyncStateMachine(typeof(MCDCDACPGEC<, >))]
	private static Task<(T1, T2)> JCMHFJDCKOD<T1, T2>(Task<T1> BODHCMAGMOA, Task<T2> OKCFHAECKND)
	{
		return null;
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public class SkinnedMeshBonesInspector : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		[SerializeField]
		[KDKBJHCHPNA(PHHCCEMPGEN.Self, false, false, false)]
		private SkinnedMeshRenderer skinnedMeshRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		[SerializeField]
		private int BoneWeightsDisplayStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		[SerializeField]
		private int BoneWeightsDisplayAmount;

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x6185C40", Offset = "0x6184C40", VA = "0x186185C40")]
		public SkinnedMeshBonesInspector()
		{
		}
	}
}
namespace RecRoom.Avatars.Face
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public sealed class FaceStyleSet : ScriptableObject
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000044")]
		[CompilerGenerated]
		private struct JHFGOJKFPHC : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001FD")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001FE")]
			public AsyncTaskMethodBuilder<FJPGEDFHKPN> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001FF")]
			public FaceStyleSet <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000200")]
			public int eyeBrows;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000201")]
			public int eye;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000202")]
			public int mouth;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000203")]
			private TaskAwaiter<FJPGEDFHKPN> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x6184C00", Offset = "0x6183C00", VA = "0x186184C00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0x6184F40", Offset = "0x6183F40", VA = "0x186184F40", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		public SymmetricalFaceFeature[] EyeBrows;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		public EyesFaceFeature[] Eyes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		public NoseFaceOption[] Noses;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		public FaceFeature[] Mouths;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		[Header("Default Values")]
		public SymmetricalFaceFeature DefaultEyeBrowsFeature;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		public EyesFaceFeature DefaultEyesFeature;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		public FaceFeature DefaultMouthFeature;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		private Dictionary<FHLAPGIAMKK, SymmetricalFaceFeature> eyeBrowFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		private Dictionary<FHLAPGIAMKK, EyesFaceFeature> eyeFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		private Dictionary<FHLAPGIAMKK, NoseFaceOption> noseOptionsDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		private Dictionary<FHLAPGIAMKK, FaceFeature> mouthFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		private readonly Dictionary<FHLAPGIAMKK, int> featureToIndexMap;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		private FJPGEDFHKPN _defaultFaceStyle;

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		private bool dictionariesInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x617FF10", Offset = "0x617EF10", VA = "0x18617FF10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x617FD10", Offset = "0x617ED10", VA = "0x18617FD10")]
		public FJPGEDFHKPN IPLDKNBJLNI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x617F9B0", Offset = "0x617E9B0", VA = "0x18617F9B0")]
		[AsyncStateMachine(typeof(JHFGOJKFPHC))]
		public Task<FJPGEDFHKPN> IKCGHPDGAKF(int CDBLFDLDJFA, int DLLCCJIMBKM, int HFFPBJFFDMC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x617F910", Offset = "0x617E910", VA = "0x18617F910")]
		public NoseFaceOption DDNHLMCMIOF(int MAOGKDCOKEK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x617F6E0", Offset = "0x617E6E0", VA = "0x18617F6E0")]
		public SelectableFaceOption BPNELPNAHMG(FaceFeatureType FCEEBJHKJCF, FHLAPGIAMKK IILDOMABJLL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x617F660", Offset = "0x617E660", VA = "0x18617F660")]
		public int ALHMMJHKPHB(FHLAPGIAMKK IILDOMABJLL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x617FAE0", Offset = "0x617EAE0", VA = "0x18617FAE0")]
		private void IPKCFJGDFBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x28B10C0", Offset = "0x28B00C0", VA = "0x1828B10C0")]
		private void FINLHHIBIAL<T>(IDictionary<FHLAPGIAMKK, T> AMCBEDPOHMD, IReadOnlyList<T> MPKMFLBMJIH) where T : SelectableFaceOption
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x617F860", Offset = "0x617E860", VA = "0x18617F860")]
		public FHLAPGIAMKK CBKNCFGEFOF(FaceFeatureType FCEEBJHKJCF)
		{
			return default(FHLAPGIAMKK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x617FD60", Offset = "0x617ED60", VA = "0x18617FD60")]
		public FHLAPGIAMKK OFCDINDEJFM(FaceFeatureType FCEEBJHKJCF)
		{
			return default(FHLAPGIAMKK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x617FE80", Offset = "0x617EE80", VA = "0x18617FE80")]
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
