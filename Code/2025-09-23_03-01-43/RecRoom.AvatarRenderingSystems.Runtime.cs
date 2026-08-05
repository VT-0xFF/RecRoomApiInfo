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
	public class LogRegistrationIndex : DHBOPDJGFAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8319420", Offset = "0x8317A20", VA = "0x188319420", Slot = "4")]
		public override void NCEHDCEOICJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xAD1210", Offset = "0xACF810", VA = "0x180AD1210")]
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
			[Cpp2IlInjected.Address(RVA = "0xAA5620", Offset = "0xAA3C20", VA = "0x180AA5620", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override string AssetGUID
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x83279A0", Offset = "0x8325FA0", VA = "0x1883279A0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8327930", Offset = "0x8325F30", VA = "0x188327930", Slot = "17")]
		public override bool RuntimeKeyIsValid()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8327960", Offset = "0x8325F60", VA = "0x188327960")]
		public RecNetCDNAssetReference(RecNetCDNKey HAELBKGFDIJ)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class RecNetCDNKey
	{
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public enum JAKCOLMHLJG : byte
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
			[Cpp2IlInjected.Address(RVA = "0xAA5610", Offset = "0xAA3C10", VA = "0x180AA5610")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xAA55F0", Offset = "0xAA3BF0", VA = "0x180AA55F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public string UniqueItemIdentifier
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xAA55C0", Offset = "0xAA3BC0", VA = "0x180AA55C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public string CacheHash
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xAA70C0", Offset = "0xAA56C0", VA = "0x180AA70C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xAA70F0", Offset = "0xAA56F0", VA = "0x180AA70F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RecNetCDNKey Dependency
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0xAA5560", Offset = "0xAA3B60", VA = "0x180AA5560")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0xAA9ED0", Offset = "0xAA84D0", VA = "0x180AA9ED0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool AttemptPrecacheLookup
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xAD4490", Offset = "0xAD2A90", VA = "0x180AD4490")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xAD43F0", Offset = "0xAD29F0", VA = "0x180AD43F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public JAKCOLMHLJG PathHint
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xF77430", Offset = "0xF75A30", VA = "0x180F77430")]
			[CompilerGenerated]
			get
			{
				return default(JAKCOLMHLJG);
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x1618980", Offset = "0x1616F80", VA = "0x181618980")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string ItemPath
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x8327AB0", Offset = "0x83260B0", VA = "0x188327AB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x83279E0", Offset = "0x8325FE0", VA = "0x1883279E0")]
		public static RecNetCDNKey FPKFCEEBPFE(string DFPKCJEAJCG, JAKCOLMHLJG GAEANAHOGCA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8327A60", Offset = "0x8326060", VA = "0x188327A60")]
		public void HKGFCLPHLIG(string CPINHIOIBEB, string MBMNKPPCEJE, bool INCPJEKMFIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public RecNetCDNKey()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[OEHADFBFMEG]
public class ENJLBDKACJJ : DPKAMKLEMCD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	protected readonly List<Mesh> POHKGOHNLBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	protected readonly List<IReadOnlyList<byte>> JFJLAOMCHOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	protected readonly List<Matrix4x4> EMELOADKEPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	protected readonly List<bool> LENJJKDJCOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	protected readonly List<long> DFEGJKMFFGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	protected readonly List<bool> HHGIEKKFHPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	protected readonly List<int> JCBAEHMDKHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	protected Allocator GANCDADDJCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	protected PBNAJDPJKEO GGGMCLGFCNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	protected byte FBNJFJGCMKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	protected IList<int> CEFEKGFEFPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	protected IList<int> DCAFNBEAHKN;

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x8312560", Offset = "0x8310B60", VA = "0x188312560", Slot = "4")]
	public void HFDCDKHCCMI(Mesh KNHPHEPPGOL, Matrix4x4 HILGEEKPAKM, IReadOnlyList<byte> KDDKFGLOION, bool HHIKEDLEAKF = false, EDHDPNHKKLO.IBJCDOEDFHO FFAGOFKLCLM = (EDHDPNHKKLO.IBJCDOEDFHO)0L, int BJLMNNIEFKO = -1, bool MLFJMELEAEN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x83122C0", Offset = "0x83108C0", VA = "0x1883122C0", Slot = "5")]
	public void DIMIOEOAFCL(Allocator EEDCBHBBPKF, PBNAJDPJKEO KCOEFNNKEBI, byte AJNJHCGFPCI, [Optional] IList<int> EAIPEOLBKAN, [Optional] IList<int> OELAAMCPAHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x8312300", Offset = "0x8310900", VA = "0x188312300")]
	private static void GCNDINEIKBK(Mesh KNHPHEPPGOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x8312890", Offset = "0x8310E90", VA = "0x188312890")]
	public ENJLBDKACJJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[OEHADFBFMEG]
public struct EPGIHJPKJLE : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	[ReadOnly]
	public FANCAPDKMEO CEBDADFPNFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	[ReadOnly]
	public int OJMKAHINJAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public JCGOPOLMGGJ CHJHNBODKPD;

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x8312AE0", Offset = "0x83110E0", VA = "0x188312AE0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[OEHADFBFMEG]
[NativeContainer]
public struct JCGOPOLMGGJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct KLLECMDHNGF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public Vector3 EIHOEFBKPKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public Vector3 EPCDDFCHPMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public Vector4 BDLBKPEDGPL;
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct DPJAGKHBGON
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public float EPCFGGDIOJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public float DMFEFOOPEKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public float MDKACNKOAML;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public float MPJPGDHEAJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public byte IOHJCMLMOMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public byte EJPDMKMONMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public byte HFGKPLNOOHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public byte GCBOHNAIHAP;
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct FDDAODPKGLA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public half EPCFGGDIOJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public half DMFEFOOPEKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public half MDKACNKOAML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public half MPJPGDHEAJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public byte IOHJCMLMOMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public byte EJPDMKMONMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public byte HFGKPLNOOHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public byte GCBOHNAIHAP;
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct GFFOAAMIJGJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public half4 FPHNLEHIJEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public half2 FHJHBHLEFHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public half4 FAMOIOIKODI;
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public struct CIMIBPHDMGL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public half4 FPHNLEHIJEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public half2 FHJHBHLEFHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public half2 CMKFCBOANHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public half4 FAMOIOIKODI;
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct GOHJEOLBGNM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public half4 FPHNLEHIJEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public half2 FHJHBHLEFHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public half2 CMKFCBOANHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public half2 EIHIFIGLOOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public half4 FAMOIOIKODI;
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public struct IIDOIEFEGPC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public half4 FPHNLEHIJEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public half2 FHJHBHLEFHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public half2 CMKFCBOANHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public half2 EIHIFIGLOOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public half2 EEOMOGHICCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public half4 FAMOIOIKODI;
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public struct OLHLGGJEHHJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public float EPCFGGDIOJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public float DMFEFOOPEKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public float MDKACNKOAML;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public float MPJPGDHEAJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public int IOHJCMLMOMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public int EJPDMKMONMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public int HFGKPLNOOHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public int GCBOHNAIHAP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public struct BBCEGMNEBGG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public Color FPHNLEHIJEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Vector2 FHJHBHLEFHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public Vector4 FAMOIOIKODI;
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public struct PGFIIIDMIDM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public Color FPHNLEHIJEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Vector2 FHJHBHLEFHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public Vector2 CMKFCBOANHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public Vector4 FAMOIOIKODI;
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public struct EBDNPNKBFNK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public Color FPHNLEHIJEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public Vector2 FHJHBHLEFHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public Vector2 CMKFCBOANHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public Vector2 EIHIFIGLOOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public Vector4 FAMOIOIKODI;
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public struct PBHNEMNKLGP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public Color FPHNLEHIJEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public Vector2 FHJHBHLEFHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public Vector2 CMKFCBOANHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public Vector2 EIHIFIGLOOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public Vector2 EEOMOGHICCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public Vector4 FAMOIOIKODI;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private bool DPNFFIIPPAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public NativeArray<KLLECMDHNGF> GNBJNGBMDJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public NativeArray<GFFOAAMIJGJ> JCCIFKHENLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public NativeArray<CIMIBPHDMGL> BGBPCBDFJND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public NativeArray<GOHJEOLBGNM> GIKBHKLJHDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public NativeArray<IIDOIEFEGPC> HEGDCONAGGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public NativeArray<FDDAODPKGLA> CGEMHGLDAGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public NativeArray<DPJAGKHBGON> IFILHCKDMMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public NativeArray<BBCEGMNEBGG> HIKKGAOCKDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public NativeArray<PGFIIIDMIDM> HLGLEGHIALJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public NativeArray<EBDNPNKBFNK> MKCPMMDCEED;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public NativeArray<PBHNEMNKLGP> LNEJGIPADCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public NativeArray<OLHLGGJEHHJ> LJENIMAODND;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public NativeArray<int> DANHLOKNMGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public NativeArray<int> JGCEFABFPMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private NativeArray<int> BIPDAKDCOIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private NativeArray<int> JGIJGMCAFNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public NativeArray<int> BCDBCHBMANO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public NativeArray<int> AGPAGAEOAAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public NativeArray<int> JOFNJLFNDOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public NativeArray<BoneWeight> HJICDHINFKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private NativeArray<int> ENMBHGMENHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private bool IADNBFBDNIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x159")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private bool AFOOKDMEFGC;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int FPDLJMEDBFI
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x83178D0", Offset = "0x8315ED0", VA = "0x1883178D0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x83178C0", Offset = "0x8315EC0", VA = "0x1883178C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int FLADGJKALCE
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8316040", Offset = "0x8314640", VA = "0x188316040")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8317D10", Offset = "0x8316310", VA = "0x188317D10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int EGMHNADOANC
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8316050", Offset = "0x8314650", VA = "0x188316050")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8316020", Offset = "0x8314620", VA = "0x188316020")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int POKPMLPPIAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x83175A0", Offset = "0x8315BA0", VA = "0x1883175A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x8318450", Offset = "0x8316A50", VA = "0x188318450")]
	public JCGOPOLMGGJ(int GKGKGGEBPGO, int AGCLNJDAAKB, int JPLMCDONONK, int EBAPHFNCPKF, Allocator EEDCBHBBPKF, int JLLLOEJIGMJ, FKEENDEHMAP PGKBOKKFLEN, bool IADNBFBDNIF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x8317670", Offset = "0x8315C70", VA = "0x188317670")]
	public void INJIAGLNPBO(int PMIGBJGNLLP, Vector3 KMDIJJMODFC, Vector3 FMCINJJNLDO, Vector4 DHDFDKFCOJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x83178E0", Offset = "0x8315EE0", VA = "0x1883178E0")]
	public void NDGJGOBGFGH(int PMIGBJGNLLP, BoneWeight GHLLBGJKDFN, NativeSlice<byte> KDDKFGLOION)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x8318130", Offset = "0x8316730", VA = "0x188318130")]
	public Color PPGHFDOPNOH(int PMIGBJGNLLP)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x8315BF0", Offset = "0x83141F0", VA = "0x188315BF0")]
	public void ACJBNKLLAFI(int PMIGBJGNLLP, Color KGDLOJHDMHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x83177D0", Offset = "0x8315DD0", VA = "0x1883177D0")]
	public void JNBCFNKPIMJ(int PMIGBJGNLLP, Vector3 ALFMKPLFANJ, Vector3 HHEJFNGGKFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x8316060", Offset = "0x8314660", VA = "0x188316060")]
	public void DKLLHEOINOP(int PMIGBJGNLLP, half4 EKJDJGOBDAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x8316410", Offset = "0x8314A10", VA = "0x188316410")]
	public void EHGIMFPPNNP(int PMIGBJGNLLP, Vector3 EKJDJGOBDAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x8317D20", Offset = "0x8316320", VA = "0x188317D20")]
	public void OJDAIMNFCOK(byte OAJOILEMDHC, int PMIGBJGNLLP, Vector2 EKJDJGOBDAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x8316030", Offset = "0x8314630", VA = "0x188316030")]
	public void CKAGFLICGLP(int PMIGBJGNLLP, int IADKMLOABCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x8317610", Offset = "0x8315C10", VA = "0x188317610")]
	public bool HAFGEGFAOPI(int OAJOILEMDHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x8317700", Offset = "0x8315D00", VA = "0x188317700")]
	public void INOOJBOBOHE(int GFJIJMGIAAD, int PIOCNHLFCNE, int NODGHDHCBPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x83161B0", Offset = "0x83147B0", VA = "0x1883161B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x8316660", Offset = "0x8314C60", VA = "0x188316660")]
	public Mesh FBOGBBEECIH([Optional] string JPKCEBKHLFB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[DefaultMember("Item")]
[OEHADFBFMEG]
[NativeContainer]
public struct FANCAPDKMEO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public Mesh.MeshDataArray OOKNNHAMJIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public NativeArray<int> CHFMAEOCALG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public NativeArray<int> DBLANJLAAJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public NativeArray<BoneWeight> HJICDHINFKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private NativeArray<Matrix4x4> HBLFGPKAKMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private NativeArray<long> CEOAACBPCJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private NativeArray<byte> KCFDKFCEGPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private NativeArray<int> KEGBNJGKHIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private NativeArray<int> GELLBAEGGIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public NativeArray<sbyte> PKAIBLGCGOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public NativeArray<byte> FJBEHIAMHMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public NativeArray<bool> MLFJMELEAEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public NativeArray<int> BJLMNNIEFKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private bool IADNBFBDNIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private NativeArray<int> IMIPIFBNPGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private bool AFOOKDMEFGC;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int JEKHEBOPPBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8314610", Offset = "0x8312C10", VA = "0x188314610")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int DCILBKAJFMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8314600", Offset = "0x8312C00", VA = "0x188314600")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int MILJHKJKEBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x83149C0", Offset = "0x8312FC0", VA = "0x1883149C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int MKIFEEEANFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x8314A90", Offset = "0x8313090", VA = "0x188314A90")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8314470", Offset = "0x8312A70", VA = "0x188314470")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int FPDLJMEDBFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x8314730", Offset = "0x8312D30", VA = "0x188314730")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8314710", Offset = "0x8312D10", VA = "0x188314710")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public int AHGLBHBBEMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x83149B0", Offset = "0x8312FB0", VA = "0x1883149B0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8314740", Offset = "0x8312D40", VA = "0x188314740")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public PBNAJDPJKEO CHCJNLFEBOM
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8314720", Offset = "0x8312D20", VA = "0x188314720")]
		get
		{
			return default(PBNAJDPJKEO);
		}
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x8314620", Offset = "0x8312C20", VA = "0x188314620")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public byte EJJJFCDJAED
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8314750", Offset = "0x8312D50", VA = "0x188314750")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8314630", Offset = "0x8312C30", VA = "0x188314630")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public IKOEJAPABLL LAJHLDAJFPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8314760", Offset = "0x8312D60", VA = "0x188314760")]
		get
		{
			return default(IKOEJAPABLL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x8314AA0", Offset = "0x83130A0", VA = "0x188314AA0")]
	public FANCAPDKMEO(IList<Mesh> MDEKHCCPNPI, IList<Matrix4x4> CJHJDPFHPIA, IList<bool> MLFJMELEAEN, byte AJNJHCGFPCI, IList<IReadOnlyList<byte>> DCGEFKMNDEL, IList<long> BAOMINLGLFN, IList<bool> JLADMNICBMH, IList<int> BJLMNNIEFKO, IList<int> EAIPEOLBKAN, IList<int> EGOIGFDKCOE, Allocator EEDCBHBBPKF, PBNAJDPJKEO KCOEFNNKEBI, bool IADNBFBDNIF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x8314640", Offset = "0x8312C40", VA = "0x188314640")]
	public JCGOPOLMGGJ JFCBEHCFMFC(Allocator EEDCBHBBPKF, FKEENDEHMAP PGKBOKKFLEN)
	{
		return default(JCGOPOLMGGJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x8314480", Offset = "0x8312A80", VA = "0x188314480", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[OEHADFBFMEG]
public class OFFDNNPFOLF : ENJLBDKACJJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public bool MDODNEDOGJH;

	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private static readonly ProfilerMarker JKKALGLCKJI;

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x83194B0", Offset = "0x8317AB0", VA = "0x1883194B0")]
	public FANCAPDKMEO KFAAECBNLFI()
	{
		return default(FANCAPDKMEO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x8319770", Offset = "0x8317D70", VA = "0x188319770")]
	public OFFDNNPFOLF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct IKOEJAPABLL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public Mesh.MeshData CIECKOGKBKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public NativeSlice<BoneWeight> HJICDHINFKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public NativeSlice<byte> GDJGHPNMMHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public int CBJHFPLLEGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public Matrix4x4 MDGMCJLPBLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public long JAMMMNNAFBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public NativeSlice<byte> KDDKFGLOION;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public bool MAAEFIEEHAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public int CNMACADNBJM;
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[DisallowMultipleComponent]
	public class AvatarDisplayBase : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000019")]
		public enum IPLLKJAEHNO : byte
		{
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			All,
			[Cpp2IlInjected.Token(Token = "0x400009E")]
			LOD0Only,
			[Cpp2IlInjected.Token(Token = "0x400009F")]
			EditorToolAll
		}

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		public struct JFIDMELCAAJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			public bool HFOMNBPIPBA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000A1")]
			public long EIJIDGHNNNL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000A2")]
			public int GGAINBCGOFF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40000A3")]
			public float FBAHOEJJHAD;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		[CompilerGenerated]
		private Action BuildCompleted;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public JFIDMELCAAJ[] lodInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public AHNGGBKKFOE DistanceBand;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		protected IPLLKJAEHNO _currentLODSelection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		protected int[] _currentLODs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public int requestedLod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		protected int _manualLod;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public readonly SkinnedMeshRenderer[] CurrentDefaultSkinnedMeshRenderers;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public readonly SkinnedMeshRenderer[] NextDefaultSkinnedMeshRenderers;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public readonly SkinnedMeshRenderer[] CurrentVisibleInFirstPersonSkinnedMeshRenderers;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public readonly SkinnedMeshRenderer[] NextVisibleInFirstPersonSkinnedMeshRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public float bboxDiameterInMeters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		protected EEDAILNAJPO _displaySystem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		protected PKCNIKPNNOM _currentPromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		protected (bool isLodForced, int forcedLOD) _forceLod;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public virtual int MNGOHBAJIOG
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0xAC5010", Offset = "0xAC3610", VA = "0x180AC5010", Slot = "6")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x178F650", Offset = "0x178DC50", VA = "0x18178F650", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public bool FMJENALPIHC
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x8311CD0", Offset = "0x83102D0", VA = "0x188311CD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public virtual bool JBKDCLFGNGE
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0xAF14E0", Offset = "0xAEFAE0", VA = "0x180AF14E0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public static bool ALMDNPJMJJO
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x8311C90", Offset = "0x8310290", VA = "0x188311C90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public EEDAILNAJPO GCIKGFAOGKA
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xAA5600", Offset = "0xAA3C00", VA = "0x180AA5600")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x8311D80", Offset = "0x8310380", VA = "0x188311D80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		protected PKCNIKPNNOM JBPHLCMKNIO
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0xAA5730", Offset = "0xAA3D30", VA = "0x180AA5730")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x8311570", Offset = "0x830FB70", VA = "0x188311570")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public int PPNOBKHNEMP
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x83120B0", Offset = "0x83106B0", VA = "0x1883120B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public KHBAENPMODP AHHJBCFGMOK
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x8311C40", Offset = "0x8310240", VA = "0x188311C40")]
			get
			{
				return default(KHBAENPMODP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public virtual event Action CHBNALIKEJG
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x8311BA0", Offset = "0x83101A0", VA = "0x188311BA0", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x8311CE0", Offset = "0x83102E0", VA = "0x188311CE0", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8311880", Offset = "0x830FE80", VA = "0x188311880", Slot = "8")]
		public virtual (bool, bool, bool) WhichLodsAreResident()
		{
			return default((bool, bool, bool));
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x8311670", Offset = "0x830FC70", VA = "0x188311670", Slot = "9")]
		public virtual (int, long, int) GetDisplayedLodInfo()
		{
			return default((int, long, int));
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0xFFA310", Offset = "0xFF8910", VA = "0x180FFA310")]
		protected void JDGFENFKGCK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x83116D0", Offset = "0x830FCD0", VA = "0x1883116D0")]
		protected void LGKFKPILPFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x1009380", Offset = "0x1007980", VA = "0x181009380")]
		protected void IPICAHDBKKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x8311450", Offset = "0x830FA50", VA = "0x188311450", Slot = "11")]
		public virtual Task CompleteBuildAsync()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x8311500", Offset = "0x830FB00", VA = "0x188311500")]
		protected void GLKPABBHLFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x8311390", Offset = "0x830F990", VA = "0x188311390", Slot = "12")]
		protected virtual void AOPFDNIKPLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x83117D0", Offset = "0x830FDD0", VA = "0x1883117D0")]
		public int MeshesAtLODCount(int APDIAKFDAFG)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x8311AA0", Offset = "0x83100A0", VA = "0x188311AA0")]
		public AvatarDisplayBase()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class OKPOGMNNJNF : EEDAILNAJPO
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class LBGLLOFLLBI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public bool hideTorsoInFirstPersonBeanMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public OKPOGMNNJNF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public PKCNIKPNNOM buildMeshPromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public Action<KeyValuePair<string, OFBDOHFHPFI<Texture2D>>> <>9__19;

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public LBGLLOFLLBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x83192B0", Offset = "0x83178B0", VA = "0x1883192B0")]
		internal bool HDGJLPJMKBE(BPGFEBKMGNH item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x8319340", Offset = "0x8317940", VA = "0x188319340")]
		internal void LMNBAOLFFJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x8319170", Offset = "0x8317770", VA = "0x188319170")]
		internal void HONCHKLHBPM(string err)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x8319340", Offset = "0x8317940", VA = "0x188319340")]
		internal void JILDOFDMLJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x8319170", Offset = "0x8317770", VA = "0x188319170")]
		internal void ABEBGPIBFLO(string err)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x8319280", Offset = "0x8317880", VA = "0x188319280")]
		internal void EHCEGFDLACC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x8319250", Offset = "0x8317850", VA = "0x188319250")]
		internal void DLOMDOAJEBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x8319360", Offset = "0x8317960", VA = "0x188319360")]
		internal void LJFBOBPHGOO(Dictionary<string, OFBDOHFHPFI<Texture2D>> resourceHandleDictionary)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x8319190", Offset = "0x8317790", VA = "0x188319190")]
		internal void CLFFAGGHMAA(KeyValuePair<string, OFBDOHFHPFI<Texture2D>> kvp)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0xAA70C0", Offset = "0xAA56C0", VA = "0x180AA70C0")]
		internal FBCJGBABFLH GHGAFBIJMFK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class CGEEKPNMDEG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public int lowestPossibleLOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public LBGLLOFLLBI CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public CGEEKPNMDEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x8312200", Offset = "0x8310800", VA = "0x188312200")]
		internal JCDONCAJBHI DLJPCGMHLJK(int lod)
		{
			return default(JCDONCAJBHI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class BOFFFNIKBDG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public EEOEHGFNDGC<Dictionary<string, OFBDOHFHPFI<Texture2D>>> ugcTextureDictionaryPromise;

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public BOFFFNIKBDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0xAA5610", Offset = "0xAA3C10", VA = "0x180AA5610")]
		internal EEOEHGFNDGC<Dictionary<string, OFBDOHFHPFI<Texture2D>>> LGCICDALKOJ()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class CGCAJLPFOBM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public List<PKCNIKPNNOM> innerPromises;

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public CGCAJLPFOBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x83120D0", Offset = "0x83106D0", VA = "0x1883120D0")]
		internal void FEMIPKAGAPD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class KKMAHKFJMFI : IEnumerator<KAIBAKBEOHB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		private KAIBAKBEOHB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public bool shouldWait;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public OKPOGMNNJNF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public List<DAIGDIJNDNF> parts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public List<PKCNIKPNNOM> innerPromises;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public int[] LODs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public bool isFirstPerson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public Func<int, JCDONCAJBHI> getLayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public JKGDAGKNFBJ materialPropertyBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public Material materialInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private int <lodIndex>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		private KAIBAKBEOHB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0xAA5480", Offset = "0xAA3A80", VA = "0x180AA5480")]
		[DebuggerHidden]
		public KKMAHKFJMFI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x8318E80", Offset = "0x8317480", VA = "0x188318E80", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x8319120", Offset = "0x8317720", VA = "0x188319120", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class CFFIIOKLFCH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		public List<LPJMHNKFBLM> _nextPrefabHandles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public List<LPJMHNKFBLM> _nextMaterialHandles;

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public CFFIIOKLFCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x832D350", Offset = "0x832B950", VA = "0x18832D350")]
		internal FBCJGBABFLH LPLFENBBGKN(DAIGDIJNDNF p)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class NDDIDJIIGBB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public KDGIFMHIDMP cancelable;

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public NDDIDJIIGBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0xC06C40", Offset = "0xC05240", VA = "0x180C06C40")]
		internal void AFEMMNOOIEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0xE94280", Offset = "0xE92880", VA = "0x180E94280")]
		internal void AHNGNBLBFEO(string err)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class JNPADNABHED
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public KDGIFMHIDMP cancelable;

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public JNPADNABHED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0xC06C40", Offset = "0xC05240", VA = "0x180C06C40")]
		internal void AFEMMNOOIEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0xE94280", Offset = "0xE92880", VA = "0x180E94280")]
		internal void AHNGNBLBFEO(string err)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class NFPMGOOLBBE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public long jobComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public Stopwatch stopwatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public SkinnedMeshRenderer lodRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public long meshComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public string meshName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public long meshCopyComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public OKPOGMNNJNF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public int lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public List<Material> newUniqueMaterials;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public List<(int mat, int part)> avatarItemMaterialPartIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public List<Bounds> avatarPartMeshBounds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public int frameStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public long lodBuildStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public long startCombineBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public long jobScheduled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public Action onFinally;

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public NFPMGOOLBBE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class GPENJCHCIJE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public bool waitingForComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public JobHandle lodBuildJobHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public JCGOPOLMGGJ defaultMeshJobContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public FANCAPDKMEO defaultAvatarMeshJobGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public NFPMGOOLBBE CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public GPENJCHCIJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x8331D60", Offset = "0x8330360", VA = "0x188331D60")]
		internal void GLFCHCDGFAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x149CDC0", Offset = "0x149B3C0", VA = "0x18149CDC0")]
		internal void ECBMDHBALFD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class MGDGLAIFBFP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public bool waitingForComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public JobHandle lodBuildJobHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		public KIALNBAOHBF legacyMeshJobContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		public NLDGPJLDBCP legacyAvatarMeshJobGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public NFPMGOOLBBE CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public MGDGLAIFBFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x8338F10", Offset = "0x8337510", VA = "0x188338F10")]
		internal void KGKEOCBMPNN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x149D070", Offset = "0x149B670", VA = "0x18149D070")]
		internal void FPCPFDCFKJP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private sealed class GIAHJAOCPHA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public OKPOGMNNJNF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		public float power;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public Color color;

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public GIAHJAOCPHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x8331D20", Offset = "0x8330320", VA = "0x188331D20")]
		internal void ALEKIBCBFKP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class DBCNGOOOBDD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public string overrideItemIdentifier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public APMGGBJHHPH overrideBodyPart;

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public DBCNGOOOBDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x832DC10", Offset = "0x832C210", VA = "0x18832DC10")]
		internal bool NFDJPLEPKID(KeyValuePair<string, BPGFEBKMGNH> entry)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private readonly HLLOFHFLNHG BGGBJFBNDJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private readonly HLLOFHFLNHG AFKHBPLKHDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private Dictionary<HPNDMCEAMMG, float> NKCKJAAKLEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private Dictionary<NDGBJFEEFKP, float> GJPKHIAIKOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private Dictionary<KOJCADMGFGP, float> IAMAOGNJPOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private IReadOnlyDictionary<string, GJPADHOELOH> LOMJAIGDMPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private Dictionary<string, GJPADHOELOH> DKMAHEOGCNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private Dictionary<string, GJPADHOELOH> KDPHILNBPLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private Dictionary<string, GJPADHOELOH> NECEDNCFLJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private CFMMIIKBBEM CAFECGHLONA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private CFMMIIKBBEM CHICEEAHIOG;

	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private static float LIFEHNOECML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private bool? DANCNDPDBGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x62")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private bool? NELNLAABMOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private bool? BDHKCICAEPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x66")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private bool? OHBPLACBKNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private AvatarConfiguration AILHIMFPKGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private Transform JAFIGDOJOLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private AvatarSkinAssetItem AGCPONMMJDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private AssetReference LBOCCBEELMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private AssetReference BELOPJCKJPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private AssetReference MMGBMBMDJAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private AssetReference CMKCNAGJFAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private GameObject LPPOHDBCKKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private GameObject AAEPIPOPBJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private GameObject KKLNCOIMGPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private SkinnedMeshRenderer JMPNCCMLHAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private AvatarSkinnedMeshBoneOrderRemapsData HLCKANLDIHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private Transform[] ILJNDLGFHGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private Matrix4x4[] OAFEFMBIEMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private Material MOPCLDFDCOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private Material MEIDIHCBJCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private Material OCEGABCABMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private Material LHGODLGMACE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private Material HJDDHEGDKMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private Shader CDNMAODJJIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private Shader HPHAAJMMHIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private Animator PBBJJNPEEGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private Renderer[] CEENLDKPCHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private EDHDPNHKKLO.IBJCDOEDFHO JJHGLALPGKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private AvatarBodyPartShapesManager IOGFJNMFACK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private IReadOnlyDictionary<string, Transform> IEBIMLLHLIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private AvatarFaceShapeData.MPDCGGPHANC AFIGCOEIIPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13C")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private AvatarBodyShapeData.FBJJGKGEEGN MAMLMKCACKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private FHGFAGJLMJA ABPDPHJCKPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x144")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private bool HJGKGNPHDDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x145")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private bool KIMEEKLLMDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private Color LFBBAGJBKOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private Color CODBONNMILO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private Color AAKGIJGKLNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private Color? KPJMNHMGBND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18C")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private Color? NMOIPPIJEIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private Color? KGMMGLJOLOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B4")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private Color? ACBHBHNDIGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private Texture2D AKNLMICDFFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private Texture2D NANEFAHBGGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	[CanBeNull]
	private BPGFEBKMGNH OFBMDJHBPOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private Texture GAAMOLGFNLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private Color BIJHPMHJFAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	public Dictionary<Renderer, JKGDAGKNFBJ> LCKFGAFKKPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private Dictionary<Renderer, JKGDAGKNFBJ> HEFBHMKHNIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private Dictionary<string, List<ODDFEGJEICB>> MCHMHBKHILK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private Dictionary<string, List<ODDFEGJEICB>> FABGPHONLJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private readonly List<LPJMHNKFBLM> JDFHLNLPKOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private readonly List<LPJMHNKFBLM> LNLLBAFLDCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private readonly List<LPJMHNKFBLM> HIKOHBMGIMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private readonly List<LPJMHNKFBLM> EOJMKAAOGEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private Dictionary<ODDFEGJEICB, Material> LOAOICBPGCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private Dictionary<ODDFEGJEICB, Material> ANFONNGGABK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private SkinnedMeshRenderer[] HLLCEKOCGPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private SkinnedMeshRenderer[] EKJNLOCHEHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private SkinnedMeshRenderer[] FOEIAIMHFPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private SkinnedMeshRenderer[] INKAOKOALLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private readonly Dictionary<string, OFBDOHFHPFI<Texture2D>> KEOHHNPKNMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private readonly Dictionary<string, OFBDOHFHPFI<Texture2D>> GKJDBFHONJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private AdditionalHatData CLHNDOHGEBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private AdditionalHatData NMPFKBCEGJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private HairData MAJPAKOJNID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private HairData MCNDKDMEOMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private FKKFOGDLKNE HFPKDLCICCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private bool? DFILJJHEINC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A4")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private PositionAndRotation AHEOINFMFON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C0")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private Transform CLLGFAOHBDM;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private Material DDPFEGPFAPO;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x2D0")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private Material NNELGKPFDPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D8")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private Dictionary<string, BPGFEBKMGNH> JGBJOFAPEAL;

	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private static readonly int IKNLNFMMAFK;

	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private static readonly int DHNAAPOHNPG;

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private static readonly int CEGLANPFJCC;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private static readonly int HAHKEACLLPM;

	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private static readonly int LMKNOOPLONA;

	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private static readonly int DKAGGCEHJDL;

	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private static readonly int NEBECPAIIIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E0")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private bool AMDJPAJLJAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E8")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private List<Action> OEGFHEPOFMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F0")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private BOMGODHADIP MDFACHGJANM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F8")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private SkinnedMeshRenderer[] LMBNHPHJEGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x300")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private int IKFGNEFLNBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x304")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private bool JAECCCCOEKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x308")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private int MJDIKAOMPPJ;

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public HLLOFHFLNHG KEPDAIIPBMM
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0xAA5610", Offset = "0xAA3C10", VA = "0x180AA5610", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public HLLOFHFLNHG EMOHKKKGJHN
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390", Slot = "14")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	private DGLAIFNIHGO IGAOGNODFFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x831D4C0", Offset = "0x831BAC0", VA = "0x18831D4C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	private bool DOGKKCBLJKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x8323B50", Offset = "0x8322150", VA = "0x188323B50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	private bool CEOLIAJKDKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x831FC70", Offset = "0x831E270", VA = "0x18831FC70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private bool HNGDKEAOIHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x83234F0", Offset = "0x8321AF0", VA = "0x1883234F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private bool FCMKMBOFCCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x831D9F0", Offset = "0x831BFF0", VA = "0x18831D9F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public AvatarConfiguration KMINAOBEJGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0xAA5600", Offset = "0xAA3C00", VA = "0x180AA5600", Slot = "25")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool ICNGPLADKOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x8321590", Offset = "0x831FB90", VA = "0x188321590")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x83199D0", Offset = "0x8317FD0", VA = "0x1883199D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private Material MDHAIMNJMDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x8323700", Offset = "0x8321D00", VA = "0x188323700")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	private Material JEAFGHPPGIA
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x831CB10", Offset = "0x831B110", VA = "0x18831CB10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	private bool HPOKPHCIOOB
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0xAC1E50", Offset = "0xAC0450", VA = "0x180AC1E50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public KHBAENPMODP NDENOABEINE
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x83277B0", Offset = "0x8325DB0", VA = "0x1883277B0", Slot = "24")]
		[CompilerGenerated]
		get
		{
			return default(KHBAENPMODP);
		}
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x831D240", Offset = "0x831B840", VA = "0x18831D240")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public Material LKEPELGHEFK
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xB34C40", Offset = "0xB33240", VA = "0x180B34C40", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public SkinnedMeshRenderer[] ODIKECFDBGF
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0xBBB320", Offset = "0xBB9920", VA = "0x180BBB320", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public Renderer[] CJGNOGFCBKA
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0xB0B1E0", Offset = "0xB097E0", VA = "0x180B0B1E0", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool CDNOEKJCEAD
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x83277C0", Offset = "0x8325DC0", VA = "0x1883277C0", Slot = "23")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public EDHDPNHKKLO.IBJCDOEDFHO HPDHJKPIEFL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0xC26960", Offset = "0xC24F60", VA = "0x180C26960", Slot = "21")]
		get
		{
			return default(EDHDPNHKKLO.IBJCDOEDFHO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public int MNGOHBAJIOG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x8323C30", Offset = "0x8322230", VA = "0x188323C30")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x831AA90", Offset = "0x8319090", VA = "0x18831AA90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	private bool MILIKHGEJKN
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x831D3B0", Offset = "0x831B9B0", VA = "0x18831D3B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	private static bool GJOBEFEOAMA
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0xAF14E0", Offset = "0xAEFAE0", VA = "0x180AF14E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x831AA60", Offset = "0x8319060", VA = "0x18831AA60", Slot = "16")]
	public PKCNIKPNNOM BuildPotatoAvatar(CGDJPODOFHN EBKGCPCGAKO, bool DOCIKBFPHOO, int[] MNCOMJENCFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x831AA30", Offset = "0x8319030", VA = "0x18831AA30", Slot = "15")]
	public PKCNIKPNNOM BuildAvatarMeshes(CGDJPODOFHN EBKGCPCGAKO, bool DOCIKBFPHOO, int[] MNCOMJENCFE, Func<Dictionary<string, BPGFEBKMGNH>, (PKCNIKPNNOM, EEOEHGFNDGC<Dictionary<string, OFBDOHFHPFI<Texture2D>>>)> NMAFPMPGFJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x83215A0", Offset = "0x831FBA0", VA = "0x1883215A0")]
	public PKCNIKPNNOM MGEFCGMGACC(CGDJPODOFHN EBKGCPCGAKO, bool DOCIKBFPHOO, int[] MNCOMJENCFE, bool GILAINPGMMH, CFMMIIKBBEM APNNFAOKAHH, [Optional] Func<Dictionary<string, BPGFEBKMGNH>, (PKCNIKPNNOM, EEOEHGFNDGC<Dictionary<string, OFBDOHFHPFI<Texture2D>>>)> NMAFPMPGFJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x8320ED0", Offset = "0x831F4D0", VA = "0x188320ED0")]
	private bool KMNJEGGEPJE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x831A440", Offset = "0x8318A40", VA = "0x18831A440")]
	private PKCNIKPNNOM BLJBBIKHBIN(bool DOCIKBFPHOO, List<DAIGDIJNDNF> GMKAKOONEJO, int[] MNCOMJENCFE, Func<int, JCDONCAJBHI> PPJHBDODIHB, bool GILAINPGMMH = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x831C4F0", Offset = "0x831AAF0", VA = "0x18831C4F0")]
	[IteratorStateMachine(typeof(KKMAHKFJMFI))]
	private IEnumerator<KAIBAKBEOHB> EFMPOJMEOMH(bool DOCIKBFPHOO, List<DAIGDIJNDNF> GMKAKOONEJO, int[] MNCOMJENCFE, Func<int, JCDONCAJBHI> PPJHBDODIHB, JKGDAGKNFBJ MBMJCJMHIPI, Material HAILDBLADDM, List<PKCNIKPNNOM> OJDNNAHCGGK, bool FHAAMLAHPOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x831CC00", Offset = "0x831B200", VA = "0x18831CC00")]
	public static void FAFNOMFOOJH(List<DAIGDIJNDNF> GMKAKOONEJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x831F500", Offset = "0x831DB00", VA = "0x18831F500")]
	public static PKCNIKPNNOM HJGFHEEHCPJ(List<DAIGDIJNDNF> GMKAKOONEJO, List<LPJMHNKFBLM> JDFHLNLPKOI, List<LPJMHNKFBLM> HIKOHBMGIMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x831F2B0", Offset = "0x831D8B0", VA = "0x18831F2B0")]
	public PKCNIKPNNOM HJGFHEEHCPJ(List<DAIGDIJNDNF> GMKAKOONEJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x831DFD0", Offset = "0x831C5D0", VA = "0x18831DFD0")]
	private FAKIPBKLGEB HEPMNPDJOAM(List<DAIGDIJNDNF> GMKAKOONEJO, int OCNFNIGMAEF, bool DOCIKBFPHOO, JCDONCAJBHI MBOGBFPKKHM, bool DMGFIEGJAGF, JKGDAGKNFBJ MBMJCJMHIPI, Material HAILDBLADDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x8324A40", Offset = "0x8323040", VA = "0x188324A40", Slot = "28")]
	public void SetBodyProperty(HPNDMCEAMMG BLGGOEFFIEA, float KOPHBHGIACG, bool EGBOIPKPDOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x8324FF0", Offset = "0x83235F0", VA = "0x188324FF0", Slot = "30")]
	public void SetFaceProperty(NDGBJFEEFKP NNIDCIBEFOA, float KOPHBHGIACG, bool HPGGLOLDJDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x8325190", Offset = "0x8323790", VA = "0x188325190", Slot = "31")]
	public void SetNoseProperty(KOJCADMGFGP FLNABNLNPEE, float KOPHBHGIACG, bool OBLCONKNJFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x8319C40", Offset = "0x8318240", VA = "0x188319C40", Slot = "29")]
	public void ApplyBodyProperties(bool PCFJPAJAEHM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x8319CA0", Offset = "0x83182A0", VA = "0x188319CA0", Slot = "32")]
	public void ApplyFaceProperties(bool PCFJPAJAEHM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x8319D60", Offset = "0x8318360", VA = "0x188319D60", Slot = "33")]
	public void ApplyNoseProperties(bool PCFJPAJAEHM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x8320640", Offset = "0x831EC40", VA = "0x188320640")]
	private void JKKPOHNOIAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x831D810", Offset = "0x831BE10", VA = "0x18831D810")]
	private void GFBJFCILIAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x831F9E0", Offset = "0x831DFE0", VA = "0x18831F9E0")]
	private void HPOAOKDHFDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x83250D0", Offset = "0x83236D0", VA = "0x1883250D0", Slot = "26")]
	public void SetFaceShape(AvatarFaceShape AGJLFNPCGBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x8324B20", Offset = "0x8323120", VA = "0x188324B20", Slot = "27")]
	public void SetBodyShape(AvatarBodyShape KOEKNECKIJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x8325280", Offset = "0x8323880", VA = "0x188325280", Slot = "34")]
	public void SetNoseType(FHGFAGJLMJA HKICDDGHPEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x8325870", Offset = "0x8323E70", VA = "0x188325870", Slot = "36")]
	public void UpdateFaceAndBodyShapes()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x8326AA0", Offset = "0x83250A0", VA = "0x188326AA0", Slot = "42")]
	public void UpdateNoseShape()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x8324FE0", Offset = "0x83235E0", VA = "0x188324FE0", Slot = "35")]
	public void SetDeformation(bool KCJHENGGFOA, bool BALONDGKHME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x831F890", Offset = "0x831DE90", VA = "0x18831F890")]
	private void HPNLDHBBACK(SkinnedMeshRenderer CJLILAGKCED, int OCNFNIGMAEF, Mesh KNHPHEPPGOL, List<Material> KFFFHPCNJDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x831D250", Offset = "0x831B850", VA = "0x18831D250")]
	public static Material FFLILKFGEOB(Dictionary<ODDFEGJEICB, Material> GIDEFKLBAOM, Material ILAHFGDDGLI, HLEKEOKMBGI KABLBJCDPCG, MLBFLLBPHIC MLLLJAGOJFM, APMGGBJHHPH HODHODILEKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x831AD00", Offset = "0x8319300", VA = "0x18831AD00")]
	public static HLEKEOKMBGI CIIKCDKAKKE(DAIGDIJNDNF MOMJEGOGPIN, int NBHCFOGKANE)
	{
		return default(HLEKEOKMBGI);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x831BD00", Offset = "0x831A300", VA = "0x18831BD00")]
	private void EENEGBAPJCA(int JJCENJEBMDL, Material PFHPGDKJCCC, DAIGDIJNDNF MOMJEGOGPIN, [Out] Texture2D DNNBCKKMNDL, [Out] Vector4 FICJFIJJPMD, [Out] Texture2D FLLMJNHJOMP, [Out] Texture2D IGIABAPOCIM, [Out] Texture2D CHNJIMEHDAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x831B3C0", Offset = "0x83199C0", VA = "0x18831B3C0")]
	private void DIPNFMCNNNJ(int JJCENJEBMDL, Material PFHPGDKJCCC, DAIGDIJNDNF MOMJEGOGPIN, [Out] Color NFEJPKHFMJO, [Out] Color ICMHNDNCEOD, [Out] Color KMPNODPEACK, [Out] Color KPBPNJMJJMG, [Out] Color IMBNPHNCDAC, [Out] Color CILGEIEMLNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x83247C0", Offset = "0x8322DC0", VA = "0x1883247C0")]
	private bool PPGOMFEFEEK(Material PFHPGDKJCCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x83238A0", Offset = "0x8321EA0", VA = "0x1883238A0")]
	private static Material OEPBEJAFNMC(int JJCENJEBMDL, GDKGMDNKPOG MOMJEGOGPIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x831FB90", Offset = "0x831E190", VA = "0x18831FB90")]
	public static MLBFLLBPHIC IILAJMHICGN(DAIGDIJNDNF MOMJEGOGPIN, int NBHCFOGKANE)
	{
		return default(MLBFLLBPHIC);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x8323DC0", Offset = "0x83223C0", VA = "0x188323DC0")]
	private static void PDAOIEHPMHC(Dictionary<string, List<ODDFEGJEICB>> PLDHKFPNKBN, DAIGDIJNDNF OGMEKLELBIH, Material ILAHFGDDGLI, HLEKEOKMBGI NJNDMFEOFPN, MLBFLLBPHIC BIPAANANOIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x831D530", Offset = "0x831BB30", VA = "0x18831D530")]
	public static SkinnedMeshRenderer FMKAPNMCKKL(Transform CDNFLEJGAOP, Transform BMPBJLKFACD, SkinnedMeshRenderer[] GGHAEDDHNJA, int OCNFNIGMAEF, JCDONCAJBHI MBOGBFPKKHM, bool DOCIKBFPHOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x8326DF0", Offset = "0x83253F0", VA = "0x188326DF0")]
	public OKPOGMNNJNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x831FDE0", Offset = "0x831E3E0", VA = "0x18831FDE0")]
	public void Initialize([In] LEDOAMFGAKI NLMJMBAEIOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x8324740", Offset = "0x8322D40", VA = "0x188324740")]
	public void Setup([In] GLGIJFFPFKH DEAFMHOIKBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x831AA90", Offset = "0x8319090", VA = "0x18831AA90", Slot = "6")]
	public void SetManualLOD(int OCNFNIGMAEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x8325290", Offset = "0x8323890", VA = "0x188325290", Slot = "11")]
	public void SetTexture(KMNKJGEMAHF BIPAANANOIM, Texture2D BDFJHOHMCFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0xAC1E50", Offset = "0xAC0450", VA = "0x180AC1E50")]
	public static bool AHGLHHCDJMB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x8319DC0", Offset = "0x83183C0", VA = "0x188319DC0", Slot = "12")]
	public bool AreMeshesBuilt()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x8324BE0", Offset = "0x83231E0", VA = "0x188324BE0", Slot = "10")]
	public void SetColor(FJBBFEDHBEJ NJNDMFEOFPN, Color? FPHNLEHIJEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x831B940", Offset = "0x8319F40", VA = "0x18831B940")]
	private void DOOIHHKKFLG(Action AMOENHLBNHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x83254B0", Offset = "0x8323AB0", VA = "0x1883254B0", Slot = "7")]
	public void SetUgcItemVisualOverrides(BPGFEBKMGNH DBPGIKDEGHA, Texture KMMMJBIBGNK, Color OGKNJKMJCPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x83199D0", Offset = "0x8317FD0", VA = "0x1883199D0", Slot = "8")]
	public void SetWaitForUgcTextureLoads(bool FHAAMLAHPOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0xB34070", Offset = "0xB32670", VA = "0x180B34070", Slot = "9")]
	public void SetUgcTextureParameters(BOMGODHADIP ENMBHGMENHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x8325520", Offset = "0x8323B20", VA = "0x188325520", Slot = "17")]
	public void Teardown()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x8319D00", Offset = "0x8318300", VA = "0x188319D00", Slot = "37")]
	public void ApplyHatAdjustments()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x8325C50", Offset = "0x8324250", VA = "0x188325C50", Slot = "38")]
	public void UpdateHatPivot([Optional] FKKFOGDLKNE HDLCOAOKNBE, [Optional] bool? FDOJDJOAPMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x831B130", Offset = "0x8319730", VA = "0x18831B130")]
	private bool CPFPODHLAHO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x8324A20", Offset = "0x8323020", VA = "0x188324A20", Slot = "22")]
	public bool SetBaseSkinCullingMask(EDHDPNHKKLO.IBJCDOEDFHO AIEPFHPGBNF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x8325710", Offset = "0x8323D10", VA = "0x188325710", Slot = "40")]
	public void UpdateEmissiveEffect(float AABBEGCOEFP, Color FPHNLEHIJEM, bool CABKJKKNCBK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x83202B0", Offset = "0x831E8B0", VA = "0x1883202B0")]
	public void JHMBCEFDHIG(float AABBEGCOEFP, Color FPHNLEHIJEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x831AE10", Offset = "0x8319410", VA = "0x18831AE10")]
	private static bool CJIKGIIAFLJ(Material HAILDBLADDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x8326BF0", Offset = "0x83251F0", VA = "0x188326BF0", Slot = "41")]
	public void UpdateTextureEffect(BEKIONOCHAD HMLGLDGBDGL, EOLPCGIEELC HELGFPMCPBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x831D7F0", Offset = "0x831BDF0", VA = "0x18831D7F0")]
	private static bool GDNHMNIGAID(ODDFEGJEICB HAELBKGFDIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x8323930", Offset = "0x8321F30", VA = "0x188323930")]
	public void OFKGAHPOPFB(BEKIONOCHAD CBMANBCLGLE, EOLPCGIEELC CDLHAHBLPOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x831FA60", Offset = "0x831E060", VA = "0x18831FA60", Slot = "39")]
	public void HideAvatarMeshes(bool GJIIKLOKJMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x8319800", Offset = "0x8317E00", VA = "0x188319800")]
	private void ADLBMMGHAEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x8320CD0", Offset = "0x831F2D0", VA = "0x188320CD0")]
	private void KIGFDOFIMFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x3F7DB70", Offset = "0x3F7C170", VA = "0x183F7DB70")]
	public static void HDKEIILKMGO<T>(Dictionary<T, Material> GIDEFKLBAOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x831AF00", Offset = "0x8319500", VA = "0x18831AF00")]
	private static void CKHKDHIKHNM(Dictionary<Renderer, JKGDAGKNFBJ> MNNGCOFMJLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x831B270", Offset = "0x8319870", VA = "0x18831B270")]
	public static void DHDGFMFHKLK(SkinnedMeshRenderer[] GGHAEDDHNJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x831F7F0", Offset = "0x831DDF0", VA = "0x18831F7F0")]
	public static void HPCLHKGIOGG(SkinnedMeshRenderer NNCHINPECMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x831A260", Offset = "0x8318860", VA = "0x18831A260")]
	public static void BKONPJNGOIH(List<LPJMHNKFBLM> FNNPDHDBGAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x8320D50", Offset = "0x831F350", VA = "0x188320D50")]
	private void KJGECCENHMA(Dictionary<string, OFBDOHFHPFI<Texture2D>> PLDHKFPNKBN, bool HPDPFLAHABA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x8320860", Offset = "0x831EE60", VA = "0x188320860")]
	private void JNHJLEJNLGN(Dictionary<string, List<ODDFEGJEICB>> PLDHKFPNKBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x831D890", Offset = "0x831BE90", VA = "0x18831D890")]
	private void GFHMIFOAGOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x8319AB0", Offset = "0x83180B0", VA = "0x188319AB0")]
	private void AOPFDNIKPLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x8324120", Offset = "0x8322720", VA = "0x188324120")]
	private void PGLCGIAENKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x8320BD0", Offset = "0x831F1D0", VA = "0x188320BD0")]
	private void KGLNJGAMCLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x8324090", Offset = "0x8322690", VA = "0x188324090")]
	private void PENLOENLPDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x831B9C0", Offset = "0x8319FC0", VA = "0x18831B9C0")]
	private void DPLPNLHFNOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x83199E0", Offset = "0x8317FE0", VA = "0x1883199E0")]
	private void AKGKCAPGEMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x831C610", Offset = "0x831AC10", VA = "0x18831C610")]
	private void EOAHEDABMBK(bool INCJIDDDNBE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x8323420", Offset = "0x8321A20", VA = "0x188323420")]
	private void MIAENHJIFAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x831B050", Offset = "0x8319650", VA = "0x18831B050")]
	private void CKPIIKLJBMH(bool INCJIDDDNBE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x83208B0", Offset = "0x831EEB0", VA = "0x1883208B0")]
	private void KDHEBANENGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x831DAD0", Offset = "0x831C0D0", VA = "0x18831DAD0")]
	private void HDBAIGNPKAM(Material HAILDBLADDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x8321030", Offset = "0x831F630", VA = "0x188321030")]
	private void MAOJHCCELLH(Material HAILDBLADDM, Color BPNJFBEHPGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x831AAB0", Offset = "0x83190B0", VA = "0x18831AAB0")]
	private void CBOLCCMBGHG(Material HAILDBLADDM, Color BPNJFBEHPGL, Color AFPKJICMOEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x83206C0", Offset = "0x831ECC0", VA = "0x1883206C0")]
	private void JLJJEPGMOIJ(Material HAILDBLADDM, Color NFEJPKHFMJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x831BB10", Offset = "0x831A110", VA = "0x18831BB10")]
	private void ECGECMPKPKK(Material HAILDBLADDM, Texture2D BDFJHOHMCFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x8319F40", Offset = "0x8318540", VA = "0x188319F40")]
	private void BBJCHLKBMNM(Material HAILDBLADDM, Texture LCKMLNOINFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x8323C60", Offset = "0x8322260", VA = "0x188323C60")]
	private void ONFPDNDOHGN(Action<JKGDAGKNFBJ> JHFAPOFONGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x831A0D0", Offset = "0x83186D0", VA = "0x18831A0D0")]
	private void BFLONJKGEJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x831C6F0", Offset = "0x831ACF0", VA = "0x18831C6F0")]
	private void EPENOECMBJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x83211B0", Offset = "0x831F7B0", VA = "0x1883211B0")]
	private void MCANABMBAHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x831C140", Offset = "0x831A740", VA = "0x18831C140")]
	public void EFGNDJDDBFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x831A250", Offset = "0x8318850", VA = "0x18831A250", Slot = "4")]
	private void BGOPCPIDBEG([In] LEDOAMFGAKI NLMJMBAEIOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x8324740", Offset = "0x8322D40", VA = "0x188324740", Slot = "5")]
	private void PNCBCANEADP([In] GLGIJFFPFKH DEAFMHOIKBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x83235D0", Offset = "0x8321BD0", VA = "0x1883235D0")]
	[CompilerGenerated]
	private FBCJGBABFLH MPINNEAEJML(DAIGDIJNDNF OKHLJECLMJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x831D430", Offset = "0x831BA30", VA = "0x18831D430")]
	[CompilerGenerated]
	private void FINLPGDGPOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x831F7C0", Offset = "0x831DDC0", VA = "0x18831F7C0")]
	[CompilerGenerated]
	private void HLFJJLACIKA(JKGDAGKNFBJ CLGICGKMAGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x8320FA0", Offset = "0x831F5A0", VA = "0x188320FA0")]
	[CompilerGenerated]
	private void KPOCLACNLLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x831A0B0", Offset = "0x83186B0", VA = "0x18831A0B0")]
	[CompilerGenerated]
	private void BCKGCMLDBKE(JKGDAGKNFBJ CLGICGKMAGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x831FD50", Offset = "0x831E350", VA = "0x18831FD50")]
	[CompilerGenerated]
	private void ILCLJBDBBOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x8323C40", Offset = "0x8322240", VA = "0x188323C40")]
	[CompilerGenerated]
	private void OIDGDDNNHGA(JKGDAGKNFBJ CLGICGKMAGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x831B8B0", Offset = "0x8319EB0", VA = "0x18831B8B0")]
	[CompilerGenerated]
	private void DNGBGFCLDEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x8320280", Offset = "0x831E880", VA = "0x188320280")]
	[CompilerGenerated]
	private void JGBKDEBKNGI(JKGDAGKNFBJ CLGICGKMAGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x83201F0", Offset = "0x831E7F0", VA = "0x1883201F0")]
	[CompilerGenerated]
	private void JCAFEHPCHGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x8320CA0", Offset = "0x831F2A0", VA = "0x188320CA0")]
	[CompilerGenerated]
	private void KICPHFIAPHH(JKGDAGKNFBJ CLGICGKMAGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x8323610", Offset = "0x8321C10", VA = "0x188323610")]
	[CompilerGenerated]
	private void NBIPMDPDIIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x83236D0", Offset = "0x8321CD0", VA = "0x1883236D0")]
	[CompilerGenerated]
	private void NPNNMMADOAN(JKGDAGKNFBJ CLGICGKMAGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x831D760", Offset = "0x831BD60", VA = "0x18831D760")]
	[CompilerGenerated]
	private void FOAKKJFFOAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x8324710", Offset = "0x8322D10", VA = "0x188324710")]
	[CompilerGenerated]
	private void PLMPOHOFGHM(JKGDAGKNFBJ CLGICGKMAGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x8319780", Offset = "0x8317D80", VA = "0x188319780")]
	[CompilerGenerated]
	private void ABGJDLGOBJI(KeyValuePair<string, OFBDOHFHPFI<Texture2D>> AHEEBNJILJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x8324700", Offset = "0x8322D00", VA = "0x188324700")]
	[CompilerGenerated]
	private void PJMABBOKNOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x83236A0", Offset = "0x8321CA0", VA = "0x1883236A0")]
	[CompilerGenerated]
	private void NJHFOPNNIGD(JKGDAGKNFBJ CLGICGKMAGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x8321580", Offset = "0x831FB80", VA = "0x188321580")]
	[CompilerGenerated]
	private void MFELHGBAJOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x8320D20", Offset = "0x831F320", VA = "0x188320D20")]
	[CompilerGenerated]
	private void KIOHFJAGIGH(JKGDAGKNFBJ CLGICGKMAGL)
	{
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public class AvatarElbowBendHelperController : MonoBehaviour, ECBPBNMJDJF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		[SerializeField]
		[OOBMCMDIFDG(GJFENOMGFMJ.Self, false, false, false)]
		private Transform ElbowHelperBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		[SerializeField]
		private Transform UpperArmBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		[SerializeField]
		private Transform LowerArmBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		[SerializeField]
		private float MinAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		[SerializeField]
		private float MaxAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		[FormerlySerializedAs("MinScaleValues")]
		[Header("Scale")]
		[SerializeField]
		private Vector3 ScaleValuesAtMinAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		[SerializeField]
		[FormerlySerializedAs("MaxScaleValues")]
		private Vector3 ScaleValuesAtMaxAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		[FormerlySerializedAs("MinLocalPositionalOffset")]
		[Header("Positional Offset")]
		[SerializeField]
		private Vector3 PositionalOffsetAtMinAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		[FormerlySerializedAs("MaxLocalPositionOffset")]
		[SerializeField]
		private Vector3 PositionalOffsetAtMaxAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private Vector3? CGHPIBFKANK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private bool LOANBMJOEMI;

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x83293F0", Offset = "0x83279F0", VA = "0x1883293F0", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x8329A20", Offset = "0x8328020", VA = "0x188329A20", Slot = "4")]
		public void UpdateController(float KJDBPOBDAMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0xDCDD50", Offset = "0xDCC350", VA = "0x180DCDD50", Slot = "6")]
		public void SetEnabled(bool KOPHBHGIACG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x83294D0", Offset = "0x8327AD0", VA = "0x1883294D0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x8329E40", Offset = "0x8328440", VA = "0x188329E40")]
		public AvatarElbowBendHelperController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public class AvatarElbowBendTargetController : MonoBehaviour, ECBPBNMJDJF
	{
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private const float PCNIIKDCFLN = 45f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		[SerializeField]
		[OOBMCMDIFDG(GJFENOMGFMJ.Self, false, false, false)]
		private Transform ElbowBendTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		[SerializeField]
		private Transform NeckBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		[SerializeField]
		private Transform UpperArmBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		[SerializeField]
		private Transform HandBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		[SerializeField]
		private bool Left;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		[SerializeField]
		private float MinTwist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		[SerializeField]
		private float MaxTwist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		[SerializeField]
		private float TwistWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		[SerializeField]
		private float ElbowSmoothTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		[SerializeField]
		private float RestTwist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		[SerializeField]
		private float RestTwistWhenClose;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		[SerializeField]
		private float RestTwistDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private Vector3 OJLAPNGBLBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		private Vector3 FHPDHMKCCDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		private bool LOANBMJOEMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private float LPLEOOGGKDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		private float HCIAPBGLPOI;

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x832A1C0", Offset = "0x83287C0", VA = "0x18832A1C0", Slot = "4")]
		public void UpdateController(float KJDBPOBDAMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x1048D30", Offset = "0x1047330", VA = "0x181048D30", Slot = "6")]
		public void SetEnabled(bool KOPHBHGIACG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x8329EE0", Offset = "0x83284E0", VA = "0x188329EE0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x832AC80", Offset = "0x8329280", VA = "0x18832AC80")]
		public AvatarElbowBendTargetController()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class FOPEDFDPFDB : NCFHMNIFFNK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private static readonly int GPFEDCDIBAE;

	[Cpp2IlInjected.Token(Token = "0x400016D")]
	private static readonly int LJDGFIPLGHD;

	[Cpp2IlInjected.Token(Token = "0x400016E")]
	private static readonly int LPGMGPGDCCM;

	[Cpp2IlInjected.Token(Token = "0x400016F")]
	private static readonly int OKGCLEDCMMI;

	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private static readonly int JCLMHLJPCIP;

	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private static readonly int MFFCBOBPNIL;

	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private static readonly int GKMFHEKOBCP;

	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private static readonly int ELNCBKLLFDP;

	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private static readonly int IPNFDAGJJLM;

	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private static readonly int ICCLNLDPNJI;

	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private static readonly int PGIKHMDJKHH;

	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private static readonly int EAPIMHFANCJ;

	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private static readonly int KGNHHGGGGFB;

	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private static readonly int LBLIOPJBMII;

	[Cpp2IlInjected.Token(Token = "0x400017A")]
	private static readonly int GIIJNJEJDAI;

	[Cpp2IlInjected.Token(Token = "0x400017B")]
	private static readonly int NPEILAIJIIE;

	[Cpp2IlInjected.Token(Token = "0x400017C")]
	private static readonly int GBDPLMGDPLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	private Transform PCNMOPFNAOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	private Transform ILDILKHFEDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	private Transform DEKIAOECDCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	private Transform DICALJFCAPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	private Transform BJAFJFAHMKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	private Transform GKGNALLBEPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private HKJMEHKLLLF FEDLNAFAJBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	private Material ONLCECNBEKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	private SkinnedMeshRenderer[] NEOBHKICOIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	private readonly List<Material> NGAIBPOJNJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	private PCDBIIDHCHM NDAIDLAMMLK;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public HLLOFHFLNHG CAFDKCPFANF
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0xAA5610", Offset = "0xAA3C10", VA = "0x180AA5610", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	private PCDBIIDHCHM ILPBFKEOBBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x832FE70", Offset = "0x832E470", VA = "0x18832FE70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public bool NMKMFLCMAEH
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x832E330", Offset = "0x832C930", VA = "0x18832E330", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x832DF70", Offset = "0x832C570", VA = "0x18832DF70")]
	public void BDBKJLHAGCA([In] HKJMEHKLLLF BCLPFDPBICL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x832EB10", Offset = "0x832D110", VA = "0x18832EB10")]
	public void ELHAIEPFKLN([In] KFOMLDIPALL EJNPFBPOPCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x832E480", Offset = "0x832CA80", VA = "0x18832E480", Slot = "6")]
	public void DHLLHEIKBOG(LGILIPFMCDH ENAEBPKNCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x832FF50", Offset = "0x832E550", VA = "0x18832FF50")]
	private Vector2 ODELIJOLGGM(Vector2 IKOKKFFMFNG)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x832EBB0", Offset = "0x832D1B0", VA = "0x18832EBB0")]
	public void EOEAPADBPCE([In] JHFBKLPOPCP EJNPFBPOPCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x832FAA0", Offset = "0x832E0A0", VA = "0x18832FAA0")]
	private void GCJDNFKNNDP(IFNNENEAPBI CHIOAENJDPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x832E020", Offset = "0x832C620", VA = "0x18832E020")]
	private void BJODJFLBMMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x832E9B0", Offset = "0x832CFB0", VA = "0x18832E9B0")]
	private void NMECEHHFNNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x832E9B0", Offset = "0x832CFB0", VA = "0x18832E9B0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x83302C0", Offset = "0x832E8C0", VA = "0x1883302C0")]
	public FOPEDFDPFDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x832EB10", Offset = "0x832D110", VA = "0x18832EB10", Slot = "5")]
	private void MHEJJCILFOM([In] KFOMLDIPALL EJNPFBPOPCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x832FF30", Offset = "0x832E530", VA = "0x18832FF30", Slot = "7")]
	private void MOJGHOKMIOG([In] JHFBKLPOPCP EJNPFBPOPCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x832FF40", Offset = "0x832E540", VA = "0x18832FF40")]
	[CompilerGenerated]
	internal static float NIOOCKJECKB(float KOPHBHGIACG, float HLHHHKKPLIG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x832EA20", Offset = "0x832D020", VA = "0x18832EA20")]
	[CompilerGenerated]
	internal static void EFKOCINCEIE(Vector2 IAJPGBLEAMI, Vector2 LEOHFKIOGBL, Vector2 KCJLCGFEBMJ, Vector2 KECGAHAPFAB, Vector2 GAEHKCHAJDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x832FEF0", Offset = "0x832E4F0", VA = "0x18832FEF0")]
	[CompilerGenerated]
	internal static Vector4 JDODLBFBNAF(Vector2 APHHGJIDDCM, Vector2 EAHAEIJNIMH)
	{
		return default(Vector4);
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public class AvatarForearmRollController : MonoBehaviour, ECBPBNMJDJF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		[SerializeField]
		private Transform TwistBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		[SerializeField]
		private Transform HandBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		[SerializeField]
		private Transform LowerArmTwistBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		[SerializeField]
		private Transform UpperArmTwistBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		[SerializeField]
		private Transform ElbowTwistBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		[SerializeField]
		private float RollTowardsWristAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		[SerializeField]
		private float RollSoftMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		[SerializeField]
		private float RollSoftMax;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		[SerializeField]
		private float LowerArmTwistAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		[SerializeField]
		private float UpperArmTwistAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		[SerializeField]
		private float ElbowTwistAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		private float LPLEOOGGKDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		private bool LOANBMJOEMI;

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x832ACB0", Offset = "0x83292B0", VA = "0x18832ACB0", Slot = "4")]
		public void UpdateController(float KJDBPOBDAMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x18D1E70", Offset = "0x18D0470", VA = "0x1818D1E70", Slot = "6")]
		public void SetEnabled(bool KOPHBHGIACG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x832B520", Offset = "0x8329B20", VA = "0x18832B520")]
		public AvatarForearmRollController()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public class AvatarHandDisplaySettings
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200002F")]
		public class AnimationOverride
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000198")]
			[Tooltip("Name of animation original state to override")]
			public string OriginalName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000199")]
			[Tooltip("Name of animation state to use as an override")]
			public string OverrideName;

			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
			public AnimationOverride()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		[SerializeField]
		private AnimationOverride[] HandStateOverrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		private Dictionary<int, int> _animationOverrides;

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x832B5C0", Offset = "0x8329BC0", VA = "0x18832B5C0")]
		public void HAKAIDJFGEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x832B550", Offset = "0x8329B50", VA = "0x18832B550")]
		public int BPMIJANKLAD(int JJEFLPECABO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public AvatarHandDisplaySettings()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class IJDEGEOEGKG : NBFHGPDBINN
{
	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x83336F0", Offset = "0x8331CF0", VA = "0x1883336F0", Slot = "24")]
	public override float MHJFOHNOMOF()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x8333740", Offset = "0x8331D40", VA = "0x188333740")]
	public IJDEGEOEGKG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public class NBFHGPDBINN : GDGKEFFDPOH
{
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private static int BCDNDNANPOJ;

	[Cpp2IlInjected.Token(Token = "0x400019B")]
	private static int LCBDHMCIKJI;

	[Cpp2IlInjected.Token(Token = "0x400019C")]
	private static int JNBPMGNOPEF;

	[Cpp2IlInjected.Token(Token = "0x400019D")]
	private static int HHKFOHPPLNB;

	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private static int IACKFFKAKLG;

	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private static int AJLABIILMKK;

	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	private static int CKMGECKBLGB;

	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	private static int[] FDJDPLCBOCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	private BGEPFAFDJNL FEDLNAFAJBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private KDCONFAIPJK OCDFCJCHLCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private int BKGIGPNDNLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	private float OFIIGPNMIAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	protected Animator PBBJJNPEEGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	protected AvatarConfiguration EIAINHLIKBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	protected int DCKBPDMEOEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	private int DLNDBADBFPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	private int IOLJNKDGPAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	private bool DDLFLKPBMPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private EPHGGGPKBOO EFJBOBDHKJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	private int GECKKFNFKLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	private float JEAADFAFFLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	private AvatarHandDisplaySettings ILKLKBMKAAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	private KHBAENPMODP ECJCNMDGPFF;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public Transform AMADDICNIIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0xAA5610", Offset = "0xAA3C10", VA = "0x180AA5610")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0xAA55F0", Offset = "0xAA3BF0", VA = "0x180AA55F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public Vector3 CHOOIKOILGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x19DD180", Offset = "0x19DB780", VA = "0x1819DD180")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x19DD060", Offset = "0x19DB660", VA = "0x1819DD060")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public Quaternion LGGOLKPGCEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0xEC0BE0", Offset = "0xEBF1E0", VA = "0x180EC0BE0")]
		[CompilerGenerated]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x10CD4F0", Offset = "0x10CBAF0", VA = "0x1810CD4F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool POPGCMDCBEA
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x8339580", Offset = "0x8337B80", VA = "0x188339580")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x8339990", Offset = "0x8337F90", VA = "0x188339990")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool AFJPNBBMEJB
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0xB2DC50", Offset = "0xB2C250", VA = "0x180B2DC50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public Vector3 PGJNOKFNLNK
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0xAD3C50", Offset = "0xAD2250", VA = "0x180AD3C50", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0xAD3D90", Offset = "0xAD2390", VA = "0x180AD3D90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public Quaternion KAOPJEOHHPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x12C9FB0", Offset = "0x12C85B0", VA = "0x1812C9FB0", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x176C0B0", Offset = "0x176A6B0", VA = "0x18176C0B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public ALNHBAFPCMB ECDBAEBHODP
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0xB61F50", Offset = "0xB60550", VA = "0x180B61F50", Slot = "21")]
		[CompilerGenerated]
		get
		{
			return default(ALNHBAFPCMB);
		}
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0xB61630", Offset = "0xB5FC30", VA = "0x180B61630", Slot = "4")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public ALNHBAFPCMB NHOKADIDOKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0xB61F40", Offset = "0xB60540", VA = "0x180B61F40", Slot = "22")]
		[CompilerGenerated]
		get
		{
			return default(ALNHBAFPCMB);
		}
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0xB61E10", Offset = "0xB60410", VA = "0x180B61E10", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public float NOOIHNIMLJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0xC2EB20", Offset = "0xC2D120", VA = "0x180C2EB20", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x10E0B80", Offset = "0x10DF180", VA = "0x1810E0B80", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public bool OAHMDGEBAFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x8339C90", Offset = "0x8338290", VA = "0x188339C90", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x8339A60", Offset = "0x8338060", VA = "0x188339A60", Slot = "9")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public bool AIPFODMDKEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x8339CC0", Offset = "0x83382C0", VA = "0x188339CC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public bool IHCNKJMCOOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x8339330", Offset = "0x8337930", VA = "0x188339330")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public bool KAOIPNFHOAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x8339CB0", Offset = "0x83382B0", VA = "0x188339CB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public bool DPLPPNCNPLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x8339CA0", Offset = "0x83382A0", VA = "0x188339CA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x8339190", Offset = "0x8337790", VA = "0x188339190", Slot = "23")]
	public void BDBKJLHAGCA(BGEPFAFDJNL BCLPFDPBICL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x8339A10", Offset = "0x8338010", VA = "0x188339A10")]
	public void IPEDOAPGAEI(KDCONFAIPJK GIIEKBECBEK, AvatarHandDisplaySettings CJEINKGIPEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x8339A70", Offset = "0x8338070", VA = "0x188339A70", Slot = "14")]
	public void JLCEDOLDDKA(bool ALDDDKDADPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x83395B0", Offset = "0x8337BB0", VA = "0x1883395B0", Slot = "13")]
	public void FPJACBNHIJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0xC2EB20", Offset = "0xC2D120", VA = "0x180C2EB20", Slot = "24")]
	public virtual float MHJFOHNOMOF()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x8339B00", Offset = "0x8338100", VA = "0x188339B00")]
	private int JNLEGFKMFMK(ALNHBAFPCMB AFMNMICPFJF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x83393C0", Offset = "0x83379C0", VA = "0x1883393C0")]
	private void BOHIMJFLMHO(int AGCIMJNMJCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x8339390", Offset = "0x8337990", VA = "0x188339390", Slot = "15")]
	public bool BNMEDMNJAFA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x83393B0", Offset = "0x83379B0", VA = "0x1883393B0", Slot = "16")]
	public bool BODCNMLPFLI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x8339340", Offset = "0x8337940", VA = "0x188339340")]
	private ALNHBAFPCMB BHAGOIHPGGN()
	{
		return default(ALNHBAFPCMB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x1F811A0", Offset = "0x1F7F7A0", VA = "0x181F811A0", Slot = "17")]
	public void GEKCDLGABON(bool ALDDDKDADPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x83399C0", Offset = "0x8337FC0", VA = "0x1883399C0", Slot = "12")]
	public void HNCKMODMDJL(int AGCIMJNMJCM, float JCBGOLALMOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x8339920", Offset = "0x8337F20", VA = "0x188339920", Slot = "10")]
	public void GDOJHDAMKFO(EPHGGGPKBOO HFPFCKAPBFI, bool KAHLPNCEPBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x8339A00", Offset = "0x8338000", VA = "0x188339A00", Slot = "11")]
	public void ILKODCDHLDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x8339940", Offset = "0x8337F40", VA = "0x188339940", Slot = "18")]
	public void GKPAMPNCCKF(Transform BEBONNCPGLF, Vector3 PCIIEEHIJJE, Quaternion EBJLNLFPLGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x8339FA0", Offset = "0x83385A0", VA = "0x188339FA0")]
	public NBFHGPDBINN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public class GDKGMDNKPOG : DAIGDIJNDNF
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private sealed class NLDLMCLDFPL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		public GDKGMDNKPOG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		public List<LPJMHNKFBLM> prefabHandles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		public List<LPJMHNKFBLM> materialHandles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		public OFBDOHFHPFI<Material[]> loadMaterialsHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		public OFBDOHFHPFI<JHAPPKMEGOK> loadPrefabHandle;

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public NLDLMCLDFPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x833C0D0", Offset = "0x833A6D0", VA = "0x18833C0D0")]
		internal FBCJGBABFLH FKGGEDKIBPH(string error)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	public BPGFEBKMGNH CCNIKECADBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	public JHAPPKMEGOK CIDMNIBFGGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	private OFBDOHFHPFI<JHAPPKMEGOK> EGJOCPELHJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	private OFBDOHFHPFI<Material[]> EAIGNOBLOPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	public Material[] KDPMKBGGBKI;

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public bool GLFJGOKKHCC
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0xAFF680", Offset = "0xAFDC80", VA = "0x180AFF680")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0xAFF560", Offset = "0xAFDB60", VA = "0x180AFF560")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public EDHDPNHKKLO.IBJCDOEDFHO GIPDCPFLAIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0xAA5620", Offset = "0xAA3C20", VA = "0x180AA5620")]
		[CompilerGenerated]
		get
		{
			return default(EDHDPNHKKLO.IBJCDOEDFHO);
		}
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0xFE1000", Offset = "0xFDF600", VA = "0x180FE1000")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x8331AF0", Offset = "0x83300F0", VA = "0x188331AF0")]
	public GDKGMDNKPOG(OKAGCDDNEAC LDGAJCEIEAM, BPGFEBKMGNH PNJLMMKNNBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x8330710", Offset = "0x832ED10", VA = "0x188330710", Slot = "6")]
	public override FBCJGBABFLH CMPDJIDKNFC(List<LPJMHNKFBLM> BCDHLMJBKII, List<LPJMHNKFBLM> HHOOABDNEED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x8330BC0", Offset = "0x832F1C0", VA = "0x188330BC0")]
	public FBCJGBABFLH CNEDMEHLLOJ(List<LPJMHNKFBLM> BCDHLMJBKII, List<LPJMHNKFBLM> HHOOABDNEED, OFBDOHFHPFI<Material[]> EAIGNOBLOPP, [Optional] OFBDOHFHPFI<JHAPPKMEGOK> GMOKNLLINCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x83310C0", Offset = "0x832F6C0", VA = "0x1883310C0")]
	public (OFBDOHFHPFI<Material[]>, OFBDOHFHPFI<JHAPPKMEGOK>) DBNGNHPLBFO(List<LPJMHNKFBLM> BCDHLMJBKII, List<LPJMHNKFBLM> HHOOABDNEED)
	{
		return default((OFBDOHFHPFI<Material[]>, OFBDOHFHPFI<JHAPPKMEGOK>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x8330EC0", Offset = "0x832F4C0", VA = "0x188330EC0", Slot = "7")]
	public override LHMNOCEEDDP COPLEELKADA(uint OCNFNIGMAEF, AvatarSkinnedMeshBoneOrderRemapsData PABKCDJBDNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x8331890", Offset = "0x832FE90", VA = "0x188331890")]
	public LHMNOCEEDDP PNJFBAKOOEP(GameObject LBHFPIDKJKB, uint OCNFNIGMAEF, bool LCCEJAIOIPC, bool KMCMDJHNGED, AvatarSkinnedMeshBoneOrderRemapsData PABKCDJBDNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x8331500", Offset = "0x832FB00", VA = "0x188331500")]
	public static bool IKKCPPLNJGF(Renderer[] GGHAEDDHNJA, string KLJODBKOKFD, [Out] Renderer JFCPPLMKCGC, [Out] Renderer FHDMCJJFJDM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x8331AA0", Offset = "0x83300A0", VA = "0x188331AA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x8331440", Offset = "0x832FA40", VA = "0x188331440")]
	private (OFBDOHFHPFI<JHAPPKMEGOK>, OFBDOHFHPFI<Material[]>) HGFIAGJJPBB()
	{
		return default((OFBDOHFHPFI<JHAPPKMEGOK>, OFBDOHFHPFI<Material[]>));
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x8331870", Offset = "0x832FE70", VA = "0x188331870")]
	[CompilerGenerated]
	private void MBPIMFAJPAP(JHAPPKMEGOK FAKHJBCPGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0xAA5520", Offset = "0xAA3B20", VA = "0x180AA5520")]
	[CompilerGenerated]
	private void KAAGDCCFDHN(Material[] FAKHJBCPGHO)
	{
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public class AvatarKneeBendTargetController : MonoBehaviour, ECBPBNMJDJF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		[OOBMCMDIFDG(GJFENOMGFMJ.Self, false, false, false)]
		[SerializeField]
		private Transform KneeBendTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		[SerializeField]
		private Transform RootSpineBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		[SerializeField]
		private Transform ThighBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		[SerializeField]
		private Transform FootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		[SerializeField]
		private float WeightToFootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		[SerializeField]
		private Vector3 BendTargetOffsetFromHipToFootMidPoint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		[SerializeField]
		private Bounds KneeTargetConstrainedBox;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		private Vector3 OJLAPNGBLBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		private Vector3 GOJLIAMOOKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		private Vector3 AAGOOGCOANJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		private Matrix4x4 LKEGPCLFHLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		private bool LOANBMJOEMI;

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x832BB50", Offset = "0x832A150", VA = "0x18832BB50", Slot = "4")]
		public void UpdateController(float KJDBPOBDAMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x832BB40", Offset = "0x832A140", VA = "0x18832BB40", Slot = "6")]
		public void SetEnabled(bool KOPHBHGIACG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x832B6E0", Offset = "0x8329CE0", VA = "0x18832B6E0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x832C210", Offset = "0x832A810", VA = "0x18832C210")]
		public AvatarKneeBendTargetController()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[OEHADFBFMEG]
public struct IFMJLEHJIBC : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	[ReadOnly]
	public NLDGPJLDBCP CEBDADFPNFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	[ReadOnly]
	public int OJMKAHINJAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	public KIALNBAOHBF CHJHNBODKPD;

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x8332770", Offset = "0x8330D70", VA = "0x188332770", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[NativeContainer]
[OEHADFBFMEG]
public struct KIALNBAOHBF : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	public NativeArray<Vector3> LALEEIMONBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	public NativeArray<Vector3> IBCJGILIPIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	public NativeArray<Vector4> BEFJOCFHEMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	public NativeArray<Vector2> GDAGDHJJCMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	public NativeArray<Vector2> EIHIFIGLOOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	public NativeArray<Vector2> EEOMOGHICCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	public NativeArray<Vector2> GJHDIBIMNBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	public NativeArray<Color> IDACBLNBNBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	public NativeArray<int> DANHLOKNMGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	public NativeArray<int> JGCEFABFPMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	private NativeArray<int> BIPDAKDCOIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	private NativeArray<int> JGIJGMCAFNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	public NativeArray<int> BCDBCHBMANO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	public NativeArray<int> AGPAGAEOAAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	public NativeArray<int> JOFNJLFNDOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	public NativeArray<BoneWeight> DGPHCGMEPPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	private NativeArray<int> ENMBHGMENHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	private bool AFOOKDMEFGC;

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public int FPDLJMEDBFI
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x8338590", Offset = "0x8336B90", VA = "0x188338590")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x8338580", Offset = "0x8336B80", VA = "0x188338580")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public int FLADGJKALCE
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x8337DB0", Offset = "0x83363B0", VA = "0x188337DB0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x8338740", Offset = "0x8336D40", VA = "0x188338740")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public int EGMHNADOANC
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x8337DC0", Offset = "0x83363C0", VA = "0x188337DC0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x8337D90", Offset = "0x8336390", VA = "0x188337D90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x83387C0", Offset = "0x8336DC0", VA = "0x1883387C0")]
	public KIALNBAOHBF(int GKGKGGEBPGO, int AGCLNJDAAKB, int JPLMCDONONK, int EBAPHFNCPKF, Allocator EEDCBHBBPKF, int JLLLOEJIGMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x8338440", Offset = "0x8336A40", VA = "0x188338440")]
	public void INJIAGLNPBO(int PMIGBJGNLLP, Vector3 KMDIJJMODFC, Vector3 FMCINJJNLDO, Vector4 DHDFDKFCOJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x83385A0", Offset = "0x8336BA0", VA = "0x1883385A0")]
	public void NDGJGOBGFGH(int PMIGBJGNLLP, BoneWeight GHLLBGJKDFN, NativeSlice<byte> KDDKFGLOION)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x83387A0", Offset = "0x8336DA0", VA = "0x1883387A0")]
	public Color PPGHFDOPNOH(int PMIGBJGNLLP)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x8337D70", Offset = "0x8336370", VA = "0x188337D70")]
	public void ACJBNKLLAFI(int PMIGBJGNLLP, Color KGDLOJHDMHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x8338750", Offset = "0x8336D50", VA = "0x188338750")]
	public void OJDAIMNFCOK(byte OAJOILEMDHC, int PMIGBJGNLLP, Vector2 EKJDJGOBDAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x8337DA0", Offset = "0x83363A0", VA = "0x188337DA0")]
	public void CKAGFLICGLP(int PMIGBJGNLLP, int IADKMLOABCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x8338410", Offset = "0x8336A10", VA = "0x188338410")]
	public bool HAFGEGFAOPI(int OAJOILEMDHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x83384B0", Offset = "0x8336AB0", VA = "0x1883384B0")]
	public void INOOJBOBOHE(int GFJIJMGIAAD, int PIOCNHLFCNE, int NODGHDHCBPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x8337DD0", Offset = "0x83363D0", VA = "0x188337DD0")]
	public int[] DOBGNPPECFB(int GFJIJMGIAAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x8338380", Offset = "0x8336980", VA = "0x188338380")]
	private NativeSlice<int> GCAFKGDONEA(int GFJIJMGIAAD)
	{
		return default(NativeSlice<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x8337E80", Offset = "0x8336480", VA = "0x188337E80", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x8338030", Offset = "0x8336630", VA = "0x188338030")]
	public Mesh FBOGBBEECIH([Optional] string JPKCEBKHLFB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[DefaultMember("Item")]
[OEHADFBFMEG]
[NativeContainer]
public struct NLDGPJLDBCP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	public NativeArray<Vector3> LALEEIMONBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	public NativeArray<Vector3> IBCJGILIPIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	public NativeArray<Vector4> BEFJOCFHEMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	public NativeArray<Vector2> GDAGDHJJCMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	public NativeArray<Vector2> EIHIFIGLOOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	public NativeArray<Vector2> EEOMOGHICCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	public NativeArray<Vector2> GJHDIBIMNBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001F2")]
	public NativeArray<Color> IDACBLNBNBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001F3")]
	public NativeArray<int> GKOPOKBACKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001F4")]
	public NativeArray<int> CLPLBBKDGHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001F5")]
	public NativeArray<int> NHJMHMDLKPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	public NativeArray<int> CPICAAIBKLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001F7")]
	public NativeArray<bool> MLFJMELEAEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40001F8")]
	public NativeArray<int> BJLMNNIEFKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40001F9")]
	public NativeArray<int> DBLANJLAAJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40001FA")]
	public NativeArray<BoneWeight> HJICDHINFKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40001FB")]
	private NativeArray<Matrix4x4> HBLFGPKAKMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40001FC")]
	private NativeArray<long> CEOAACBPCJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40001FD")]
	private NativeArray<byte> KCFDKFCEGPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40001FE")]
	private NativeArray<int> KEGBNJGKHIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40001FF")]
	private NativeArray<int> GELLBAEGGIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000200")]
	public NativeArray<sbyte> PKAIBLGCGOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000201")]
	public NativeArray<byte> FJBEHIAMHMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000202")]
	private NativeArray<int> IMIPIFBNPGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x4000203")]
	private bool AFOOKDMEFGC;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public int JEKHEBOPPBM
	{
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0xF79720", Offset = "0xF77D20", VA = "0x180F79720")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public int DCILBKAJFMI
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0xDD08D0", Offset = "0xDCEED0", VA = "0x180DD08D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public int MILJHKJKEBK
	{
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x833A8C0", Offset = "0x8338EC0", VA = "0x18833A8C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public int MKIFEEEANFO
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x833A8F0", Offset = "0x8338EF0", VA = "0x18833A8F0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x8339FC0", Offset = "0x83385C0", VA = "0x188339FC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public int FPDLJMEDBFI
	{
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x833A350", Offset = "0x8338950", VA = "0x18833A350")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x833A330", Offset = "0x8338930", VA = "0x18833A330")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public int AHGLBHBBEMH
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x833A8B0", Offset = "0x8338EB0", VA = "0x18833A8B0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x833A360", Offset = "0x8338960", VA = "0x18833A360")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public PBNAJDPJKEO CHCJNLFEBOM
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x833A340", Offset = "0x8338940", VA = "0x18833A340")]
		get
		{
			return default(PBNAJDPJKEO);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x833A240", Offset = "0x8338840", VA = "0x18833A240")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public byte EJJJFCDJAED
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x833A370", Offset = "0x8338970", VA = "0x18833A370")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x833A250", Offset = "0x8338850", VA = "0x18833A250")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public KJMJIJOGGEM LAJHLDAJFPK
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x833A380", Offset = "0x8338980", VA = "0x18833A380")]
		get
		{
			return default(KJMJIJOGGEM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x833A900", Offset = "0x8338F00", VA = "0x18833A900")]
	public NLDGPJLDBCP(IList<Mesh> MDEKHCCPNPI, IList<Matrix4x4> CJHJDPFHPIA, IList<bool> MLFJMELEAEN, byte AJNJHCGFPCI, IList<IReadOnlyList<byte>> DCGEFKMNDEL, IList<long> BAOMINLGLFN, IList<bool> JLADMNICBMH, IList<int> BJLMNNIEFKO, IList<int> EAIPEOLBKAN, IList<int> EGOIGFDKCOE, Allocator EEDCBHBBPKF, PBNAJDPJKEO KCOEFNNKEBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x833A260", Offset = "0x8338860", VA = "0x18833A260")]
	public KIALNBAOHBF JFCBEHCFMFC(Allocator EEDCBHBBPKF)
	{
		return default(KIALNBAOHBF);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x8339FD0", Offset = "0x83385D0", VA = "0x188339FD0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
[OEHADFBFMEG]
public class CNHOJJFMCJL : ENJLBDKACJJ
{
	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x832D900", Offset = "0x832BF00", VA = "0x18832D900")]
	public NLDGPJLDBCP KFAAECBNLFI()
	{
		return default(NLDGPJLDBCP);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x8319770", Offset = "0x8317D70", VA = "0x188319770")]
	public CNHOJJFMCJL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public struct KJMJIJOGGEM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000204")]
	public NativeSlice<Vector3> LALEEIMONBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000205")]
	public NativeSlice<Vector3> IBCJGILIPIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000206")]
	public NativeSlice<Vector4> BEFJOCFHEMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000207")]
	public NativeSlice<Vector2> GDAGDHJJCMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000208")]
	public NativeSlice<Vector2> EIHIFIGLOOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000209")]
	public NativeSlice<Vector2> EEOMOGHICCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400020A")]
	public NativeSlice<Vector2> GJHDIBIMNBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400020B")]
	public NativeSlice<Color> IDACBLNBNBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400020C")]
	public NativeSlice<int> KOHJMIELJJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400020D")]
	public NativeSlice<int> CPICAAIBKLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400020E")]
	public NativeSlice<BoneWeight> HJICDHINFKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400020F")]
	public NativeSlice<byte> GDJGHPNMMHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000210")]
	public int CBJHFPLLEGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x4000211")]
	public Matrix4x4 MDGMCJLPBLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000212")]
	public long JAMMMNNAFBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000213")]
	public NativeSlice<byte> KDDKFGLOION;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000214")]
	public bool MAAEFIEEHAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
	[Cpp2IlInjected.Token(Token = "0x4000215")]
	public int CNMACADNBJM;
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public readonly struct ODDFEGJEICB : IEquatable<ODDFEGJEICB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000216")]
	internal readonly Material GOHKLGDEHHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000217")]
	internal readonly HLEKEOKMBGI AGMKAMMIDLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000218")]
	internal readonly MLBFLLBPHIC AFDCMGIIDGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000219")]
	internal readonly APMGGBJHHPH ODGBELDFKMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x400021A")]
	internal readonly bool LGLNCBKBDKI;

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x833CD10", Offset = "0x833B310", VA = "0x18833CD10")]
	public ODDFEGJEICB(Material PFHPGDKJCCC, HLEKEOKMBGI KABLBJCDPCG, MLBFLLBPHIC MLLLJAGOJFM, APMGGBJHHPH HODHODILEKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x833CA70", Offset = "0x833B070", VA = "0x18833CA70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x833C7D0", Offset = "0x833ADD0", VA = "0x18833C7D0", Slot = "4")]
	public bool Equals(ODDFEGJEICB AAGCKLPFJME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x833C860", Offset = "0x833AE60", VA = "0x18833C860", Slot = "0")]
	public override bool Equals(object MPIDDJPOOMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x833C960", Offset = "0x833AF60", VA = "0x18833C960", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[DisallowMultipleComponent]
	public class AvatarModernBodyDisplayBehaviour : MonoBehaviour, LKOPKJAFICM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		[Header("Configuration")]
		[SerializeField]
		protected AvatarConfiguration configuration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		[SerializeField]
		protected Animator skeletonAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		[SerializeField]
		protected Renderer[] watchRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		[Header("Configuration")]
		[SerializeField]
		private KHBAENPMODP avatarBodyType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400021F")]
		[SerializeField]
		private AvatarSkinAssetItem potatoAvatarSkinAssetItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		[SerializeField]
		[FormerlySerializedAs("avatarSkinAsset")]
		private AssetReference avatarSkinAssetReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		[SerializeField]
		private AssetReference torsoModestyAssetReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		[SerializeField]
		private AssetReference legsModestyAssetReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		[SerializeField]
		private AssetReference torsoValidationAssetReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		[SerializeField]
		private GameObject allBodyMeshContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		[SerializeField]
		private GameObject firstPersonMeshContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		[SerializeField]
		public GameObject thirdPersonMeshContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		[SerializeField]
		private GameObject[] hideInFirstPerson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		[SerializeField]
		protected Transform headAdditiveBaseBoneTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		[SerializeField]
		[FormerlySerializedAs("BodyMaterial")]
		private Material BodyMaterialSkinGradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		[SerializeField]
		private Material BodyMaterialNonGradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		[SerializeField]
		private Material ModestyAndValidationMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		[SerializeField]
		private Material FaceMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		[SerializeField]
		private Material DefaultAvatarItemMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		[SerializeField]
		private Shader AvatarDefaultShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400022F")]
		[SerializeField]
		private Shader AvatarUberShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		[SerializeField]
		private Transform DeformRigRootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000231")]
		[SerializeField]
		private SkinnedMeshRenderer BaseSkinnedMeshRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000232")]
		[SerializeField]
		protected AvatarSkinnedMeshBoneOrderRemapsData BoneOrderRemapsData;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000233")]
		[SerializeField]
		[Header("Arm Animation Controllers")]
		private AvatarForearmRollController LeftForearmRollController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000234")]
		[SerializeField]
		private AvatarElbowBendHelperController LeftElbowBendHelperController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000235")]
		[SerializeField]
		private AvatarElbowBendTargetController LeftElbowBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000236")]
		[SerializeField]
		private AvatarKneeBendTargetController LeftKneeBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000237")]
		[SerializeField]
		private AvatarForearmRollController RightForearmRollController;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000238")]
		[SerializeField]
		private AvatarElbowBendHelperController RightElbowBendHelperController;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000239")]
		[SerializeField]
		private AvatarElbowBendTargetController RightElbowBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400023A")]
		[SerializeField]
		private AvatarKneeBendTargetController RightKneeBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x400023B")]
		[SerializeField]
		private Transform LeftEyeBrowBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x400023C")]
		[SerializeField]
		private Transform LeftEyeBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x400023D")]
		[SerializeField]
		private Transform RightEyeBrowBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x400023E")]
		[SerializeField]
		private Transform RightEyeBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x400023F")]
		[SerializeField]
		private Transform NoseMoveTweakBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000240")]
		[SerializeField]
		private Transform MouthBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x4000241")]
		[SerializeField]
		private AvatarBodyPartShapesManager avatarBodyPartShapesManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4000242")]
		[SerializeField]
		private Transform HatAnchorBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4000243")]
		[SerializeField]
		private Transform LeftHandWatchAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4000244")]
		[SerializeField]
		private Transform RightHandWatchAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4000245")]
		[SerializeField]
		private GameObject LeftHandWatchVisuals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x4000246")]
		[SerializeField]
		private GameObject RightHandWatchVisuals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x4000247")]
		private EEDAILNAJPO AGOOCBCLJJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x4000248")]
		private NCFHMNIFFNK JBBEODNHJLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x4000249")]
		private GDGKEFFDPOH PPJFIDMGLNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x400024A")]
		private GDGKEFFDPOH AHOAKKEGICN;

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public EEDAILNAJPO BCNBIJEMCBK
		{
			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(RVA = "0x832D1F0", Offset = "0x832B7F0", VA = "0x18832D1F0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public NCFHMNIFFNK KBAFMJLOMGK
		{
			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(RVA = "0x832D240", Offset = "0x832B840", VA = "0x18832D240", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public GDGKEFFDPOH HNDCHFIGPGP
		{
			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0x832D290", Offset = "0x832B890", VA = "0x18832D290", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public GDGKEFFDPOH OJFIAGIEMEE
		{
			[Cpp2IlInjected.Token(Token = "0x60001BA")]
			[Cpp2IlInjected.Address(RVA = "0x832D2E0", Offset = "0x832B8E0", VA = "0x18832D2E0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public Transform HCAAIKKCAEN
		{
			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0x832D330", Offset = "0x832B930", VA = "0x18832D330", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public KHBAENPMODP KEECKLLMACN
		{
			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0xAAA0E0", Offset = "0xAA86E0", VA = "0x180AAA0E0", Slot = "12")]
			get
			{
				return default(KHBAENPMODP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x832C220", Offset = "0x832A820", VA = "0x18832C220")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x832CD10", Offset = "0x832B310", VA = "0x18832CD10")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x832C590", Offset = "0x832AB90", VA = "0x18832C590", Slot = "8")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x832CD10", Offset = "0x832B310", VA = "0x18832CD10", Slot = "9")]
		public void TeardownAvatarDisplaySystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x832C260", Offset = "0x832A860", VA = "0x18832C260", Slot = "10")]
		public bool CleanupDisplayMeshes()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x832D100", Offset = "0x832B700", VA = "0x18832D100")]
		public void UpdatePostIKAnimControllers(float KJDBPOBDAMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x832C860", Offset = "0x832AE60", VA = "0x18832C860")]
		private void LMKCLEEMHKA(GameObject MPIDDJPOOMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x832C8F0", Offset = "0x832AEF0", VA = "0x18832C8F0")]
		private EEDAILNAJPO OGHIKGMMCIK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x832CDC0", Offset = "0x832B3C0", VA = "0x18832CDC0")]
		private NCFHMNIFFNK PFBOPFLLOBN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x832C5D0", Offset = "0x832ABD0", VA = "0x18832C5D0")]
		private GDGKEFFDPOH LKPLKLDPFDA(JKDJCOOGOJL DHCBIDEGLHB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x832D1E0", Offset = "0x832B7E0", VA = "0x18832D1E0")]
		public AvatarModernBodyDisplayBehaviour()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public class JKGDAGKNFBJ : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400024B")]
	private MaterialPropertyBlock KDOGKGHJHKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400024C")]
	public Color? LFFCPPIIGDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400024D")]
	public Color? IAPHFPLPKPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400024E")]
	public Color? MHIKDLAHNEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x400024F")]
	public Color? HNKCGLFNNOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000250")]
	public Color DDNEMGACOII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000251")]
	public Color EMCGFGCFBNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000252")]
	public Color CNEHJOCGIKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000253")]
	public float NHFGCCEOEKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000254")]
	public Texture2D JMKMMGBBCBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000255")]
	public Texture2D OFMCEMGPGBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000256")]
	private Dictionary<ODDFEGJEICB, int> HLFENNFMLBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000257")]
	private HLEKEOKMBGI[] IPDJMKFHDJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000258")]
	private MLBFLLBPHIC[] DHMDFFPPPFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000259")]
	public Vector4[] GLFJBKIDKNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400025A")]
	public Vector4[] NANOFOGGEPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400025B")]
	public Vector4[] FKCBKCFAMEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x400025C")]
	public Vector4[] NNLDILIGDNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400025D")]
	public Vector4[] INGGJHPKGHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400025E")]
	public Vector4[] BAMIACDJNKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400025F")]
	private List<Texture2D> HNJECEDFKCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000260")]
	private Vector4[] OPLANIBEOAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000261")]
	private List<Texture2D> IFMJMNNKNPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000262")]
	private float[] NDODACEFBGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000263")]
	private Vector4[] MNMNLMOLJDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000264")]
	private float[] HLBAGAAEPKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000265")]
	public float[] IFODCONJJFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000266")]
	private List<Texture2D> FKNCMFOGNLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x4000267")]
	private float[] JCEINLIPIPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x4000268")]
	private List<Texture2D> DDCODKOBLCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x4000269")]
	private Vector4[] OJHDNFCGEGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x400026A")]
	private float[] HOCFBCCHOLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x400026B")]
	private Vector4[] EEPJFBMKKOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x400026C")]
	public float[] FHAIMFHNEHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x400026D")]
	public Texture2DArray CDBAOCBNBOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x400026E")]
	public Texture2DArray EKDMLCMHGOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x400026F")]
	public Texture2DArray ENPEHEBCAIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x4000270")]
	public Texture2DArray HAJDLODDDEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x4000271")]
	private bool FOOJHDMMBKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18C")]
	[Cpp2IlInjected.Token(Token = "0x4000272")]
	private int AEDCHBDCKFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x4000273")]
	private Vector2? EKBMMDCOMBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19C")]
	[Cpp2IlInjected.Token(Token = "0x4000274")]
	private TextureFormat KIHADGEHKKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x4000275")]
	private Vector2? OEENPAMMFGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1AC")]
	[Cpp2IlInjected.Token(Token = "0x4000276")]
	private TextureFormat HOFNGGBBPJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x4000277")]
	private Vector2? BLBCLGJDDDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1BC")]
	[Cpp2IlInjected.Token(Token = "0x4000278")]
	private TextureFormat INKEGFHLGHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x4000279")]
	private Vector2? FEJGKNNIDBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1CC")]
	[Cpp2IlInjected.Token(Token = "0x400027A")]
	private TextureFormat GGPJNBKGMMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
	[Cpp2IlInjected.Token(Token = "0x400027B")]
	private bool AHFHMNIBLBI;

	[Cpp2IlInjected.Token(Token = "0x400027C")]
	private static int ACFNAILNCGH;

	[Cpp2IlInjected.Token(Token = "0x400027D")]
	private static int CFIFLFPNCKI;

	[Cpp2IlInjected.Token(Token = "0x400027E")]
	private static int FKNIGAKJBGD;

	[Cpp2IlInjected.Token(Token = "0x400027F")]
	private static int GDMOMOAIKBN;

	[Cpp2IlInjected.Token(Token = "0x4000280")]
	private static int EJGNOEAJPBC;

	[Cpp2IlInjected.Token(Token = "0x4000281")]
	private static int OLCPAEGEBEE;

	[Cpp2IlInjected.Token(Token = "0x4000282")]
	private static int AECLDPDBNDA;

	[Cpp2IlInjected.Token(Token = "0x4000283")]
	private static int CKPDHJOKBBL;

	[Cpp2IlInjected.Token(Token = "0x4000284")]
	private static int AGFHHPANGFB;

	[Cpp2IlInjected.Token(Token = "0x4000285")]
	private static int OIIEJPEIOAL;

	[Cpp2IlInjected.Token(Token = "0x4000286")]
	private static int OAFDNNNGKJA;

	[Cpp2IlInjected.Token(Token = "0x4000287")]
	private static int JGBGDAEHAJO;

	[Cpp2IlInjected.Token(Token = "0x4000288")]
	private static int LKBJAODOJCP;

	[Cpp2IlInjected.Token(Token = "0x4000289")]
	private static int INHJMCLDHLG;

	[Cpp2IlInjected.Token(Token = "0x400028A")]
	private static int ILMPJEBDLID;

	[Cpp2IlInjected.Token(Token = "0x400028B")]
	private static int NFIKCLLLPHH;

	[Cpp2IlInjected.Token(Token = "0x400028C")]
	private static int FBKFFCEBPIG;

	[Cpp2IlInjected.Token(Token = "0x400028D")]
	private static int HCJHHEOPCCH;

	[Cpp2IlInjected.Token(Token = "0x400028E")]
	private static int NPBKAPLLDAD;

	[Cpp2IlInjected.Token(Token = "0x400028F")]
	private static int CKMFFACNMOK;

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x8336FE0", Offset = "0x83355E0", VA = "0x188336FE0")]
	private JKGDAGKNFBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x83374E0", Offset = "0x8335AE0", VA = "0x1883374E0")]
	public JKGDAGKNFBJ(Color DKMPFPDNJAH, Color NACBAIHDHON, Color MCCJNHKBBMA, Color? PDMMLMNLHJO, Color? BENCIEJODOF, Color? BCNPHJMGANA, Texture2D FIJDNLOIKOH, Texture2D IJNAPCKPICN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x8336AF0", Offset = "0x83350F0", VA = "0x188336AF0")]
	internal int JMCLDPEMNPE(Material IOADAPHPPDH, HLEKEOKMBGI KABLBJCDPCG, MLBFLLBPHIC MLLLJAGOJFM, APMGGBJHHPH HODHODILEKM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x8336BC0", Offset = "0x83351C0", VA = "0x188336BC0")]
	private int JMCLDPEMNPE(ODDFEGJEICB HAELBKGFDIJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x8334F40", Offset = "0x8333540", VA = "0x188334F40")]
	internal int DNBLMOJFKHG(Material IOADAPHPPDH, Color NFEJPKHFMJO, Color ICMHNDNCEOD, Color KMPNODPEACK, Color KPBPNJMJJMG, Color IMBNPHNCDAC, Texture2D CABJABOCAIA, Vector4 HAMKHBDJHLL, Texture2D IMEBLFKEAHA, Vector4 HIAOEMIMHAM, float KBDCMFMELIB, float JINAAIDAACF, Texture2D GGFHOMLNCFE, Vector4 HEJBOCEBNIM, float AJJFNBOGGFJ, Texture2D DNDNBAADKBD, Color CILGEIEMLNM, Vector4 IAFABHMOOON, HLEKEOKMBGI KABLBJCDPCG, MLBFLLBPHIC MLLLJAGOJFM, APMGGBJHHPH HODHODILEKM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x8334980", Offset = "0x8332F80", VA = "0x188334980")]
	private void AICOHKJMBCB(List<Texture2D> HNJECEDFKCB, [Out] Texture2DArray OEHIMBCHIFA, [Out] Texture2DArray DEPDGEMJHOB, [Out] Texture2DArray KBGAAKJGAJB, [Out] Texture2DArray KCPGBOCDPKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x8334B40", Offset = "0x8333140", VA = "0x188334B40")]
	public void CBOPCCLAFCC(Shader IPNKHMNLLAF, Renderer MAFJPEPPLNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x8335B50", Offset = "0x8334150", VA = "0x188335B50")]
	private void EFECIMHFFJI(Shader IPNKHMNLLAF, Renderer MAFJPEPPLNH, int EGLDCLMMOFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x8336840", Offset = "0x8334E40", VA = "0x188336840")]
	private Color FAOOCAAEMID(Color HFHABGJIPIO, HLEKEOKMBGI NJNDMFEOFPN)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x8334DF0", Offset = "0x83333F0", VA = "0x188334DF0")]
	private Color DFLDEHMKHJL(Color OBOFEJDMDII, HLEKEOKMBGI NJNDMFEOFPN)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x8334C90", Offset = "0x8333290", VA = "0x188334C90")]
	private bool DFENGAJOJGG(Texture2D JJGEKCDGFMJ, MLBFLLBPHIC BIPAANANOIM, [Out] Texture2D ABCCECIOIFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x8336A40", Offset = "0x8335040", VA = "0x188336A40")]
	private void HMMGJOPJFHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x8335B10", Offset = "0x8334110", VA = "0x188335B10", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public abstract class DAIGDIJNDNF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000293")]
	public readonly OKAGCDDNEAC ODGBELDFKMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000294")]
	protected bool FKNPCCBDHLM;

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public bool LFLIGBAEIDP
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0xAFE8C0", Offset = "0xAFCEC0", VA = "0x180AFE8C0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0xB82B90", Offset = "0xB81190", VA = "0x180B82B90")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public bool FHPCCEFBNDM
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0xB82BB0", Offset = "0xB811B0", VA = "0x180B82BB0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0xB82BA0", Offset = "0xB811A0", VA = "0x180B82BA0")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public virtual EDHDPNHKKLO.IBJCDOEDFHO JAMMMNNAFBF
	{
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(EDHDPNHKKLO.IBJCDOEDFHO);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0xE15260", Offset = "0xE13860", VA = "0x180E15260", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public bool JGBKHMEFGKF
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0xC58290", Offset = "0xC56890", VA = "0x180C58290")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public bool OCGGHPJIBPN
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x832DB60", Offset = "0x832C160", VA = "0x18832DB60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public bool BGHBPACHNJM
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x832D9F0", Offset = "0x832BFF0", VA = "0x18832D9F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public bool JDCLBEPGHCF
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x832DA70", Offset = "0x832C070", VA = "0x18832DA70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x832DBE0", Offset = "0x832C1E0", VA = "0x18832DBE0")]
	protected DAIGDIJNDNF(OKAGCDDNEAC LDGAJCEIEAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract FBCJGBABFLH CMPDJIDKNFC(List<LPJMHNKFBLM> BCDHLMJBKII, List<LPJMHNKFBLM> HHOOABDNEED);

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract LHMNOCEEDDP COPLEELKADA(uint OCNFNIGMAEF, AvatarSkinnedMeshBoneOrderRemapsData PABKCDJBDNP);
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public class HDOFLOMMNNE : KDFNADEHHNN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000295")]
	private AvatarSkinAssetItem AGCPONMMJDK;

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x8332620", Offset = "0x8330C20", VA = "0x188332620")]
	public HDOFLOMMNNE(AvatarSkinAssetItem HEOBPCFBKNH, AvatarSkinAssetItem.BMMBGKODCFA ACINOFMPCLC, OKAGCDDNEAC HODHODILEKM, [Optional] KKNCLIFJEEB? IINNCIEJMKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x83323B0", Offset = "0x83309B0", VA = "0x1883323B0", Slot = "6")]
	public override FBCJGBABFLH CMPDJIDKNFC(List<LPJMHNKFBLM> BCDHLMJBKII, List<LPJMHNKFBLM> HHOOABDNEED)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class GACMHFJJJLO
{
	[Cpp2IlInjected.Token(Token = "0x4000296")]
	private static readonly int[] BBKDGLDIFHL;

	[Cpp2IlInjected.Token(Token = "0x4000297")]
	private static readonly int[] ONNFJHLCHKL;

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public static int[] NOFCFNFGJNM
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x8330470", Offset = "0x832EA70", VA = "0x188330470")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x83304D0", Offset = "0x832EAD0", VA = "0x1883304D0")]
	public static int[] CBMGNJNNDLL(bool MKPPJKOOECM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x8330580", Offset = "0x832EB80", VA = "0x188330580")]
	public static int CNNGMJGIKEP(AHNGGBKKFOE BACPIDGGNGA, bool MKPPJKOOECM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x83304C0", Offset = "0x832EAC0", VA = "0x1883304C0")]
	private static int BPBMEEMENEG(AHNGGBKKFOE BACPIDGGNGA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x8330560", Offset = "0x832EB60", VA = "0x188330560")]
	private static int CFCNMPIHFLN(AHNGGBKKFOE BACPIDGGNGA)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class GFECKNICIAB
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private sealed class IFEJHGNMCCN : IEnumerator<KAIBAKBEOHB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000298")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000299")]
		private KAIBAKBEOHB <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400029A")]
		public JobHandle handle;

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		private KAIBAKBEOHB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0xAA5480", Offset = "0xAA3A80", VA = "0x180AA5480")]
		[DebuggerHidden]
		public IFEJHGNMCCN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x1575770", Offset = "0x1573D70", VA = "0x181575770", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x8332720", Offset = "0x8330D20", VA = "0x188332720", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980")]
	public static void JCEMCICJEJE(string NMILEMOAODL, int OCNFNIGMAEF, long JOBIPDCGAJB, long GHIFALEIIHL, long KKDCKNIDBEK, long LNDCNBOBELO, long BECENCENCDN, long AMLNEEDKJEE, long MLIDHJNFMGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x8331BD0", Offset = "0x83301D0", VA = "0x188331BD0")]
	public static FAKIPBKLGEB EEEFJKKKBMP(JobHandle LPKPEBMHBPM, bool PLNMIGPEEPK, bool HPOKPHCIOOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x8331B60", Offset = "0x8330160", VA = "0x188331B60")]
	[IteratorStateMachine(typeof(IFEJHGNMCCN))]
	private static IEnumerator<KAIBAKBEOHB> BAHDOMMJEME(JobHandle MNHLJANEAIO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class JCGJHNMCNMB
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public enum BFJPIPCKLHG
	{
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		General,
		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		ColoredHair
	}

	[Cpp2IlInjected.Token(Token = "0x400029B")]
	public static readonly int LOEGHAJDNNH;

	[Cpp2IlInjected.Token(Token = "0x400029C")]
	public static readonly int FGMLMMJGCDJ;

	[Cpp2IlInjected.Token(Token = "0x400029D")]
	public static readonly int CDMOCHHAAPN;

	[Cpp2IlInjected.Token(Token = "0x400029E")]
	public static readonly int BEAOFGOBHKC;

	[Cpp2IlInjected.Token(Token = "0x400029F")]
	public static readonly int OEHGBCNEDKG;

	[Cpp2IlInjected.Token(Token = "0x40002A0")]
	public static readonly int JNIKHNKCACJ;

	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	public static readonly int PGDCDOBOPNC;

	[Cpp2IlInjected.Token(Token = "0x40002A2")]
	public static readonly int EJNPDIMDAOA;

	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	public static readonly int OLHIPDKCEAD;

	[Cpp2IlInjected.Token(Token = "0x40002A4")]
	public static readonly int NGKDHLNMODA;

	[Cpp2IlInjected.Token(Token = "0x40002A5")]
	public static readonly int MBHMNJLMNEA;

	[Cpp2IlInjected.Token(Token = "0x40002A6")]
	public static readonly int FFNKMACCKMC;

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x83337A0", Offset = "0x8331DA0", VA = "0x1883337A0")]
	public static bool KPONBEEFCPC(Material PFHPGDKJCCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x8333810", Offset = "0x8331E10", VA = "0x188333810")]
	public static bool OMPHHKGHKME(Material PFHPGDKJCCC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public class KDFNADEHHNN : DAIGDIJNDNF
{
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private sealed class OGJAEFILPDK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		public OFBDOHFHPFI<GameObject> skinAvatarItemPrefabHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		public KDFNADEHHNN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		public Action<string> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public OGJAEFILPDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x833CE50", Offset = "0x833B450", VA = "0x18833CE50")]
		internal void BNNCLDLBKLF(GameObject result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x833D2A0", Offset = "0x833B8A0", VA = "0x18833D2A0")]
		internal void FKGGEDKIBPH(string error)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002AB")]
	protected AvatarSkinAssetItem IBFODDJIOED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40002AC")]
	protected Material[] CNMIHCBFANJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40002AD")]
	private readonly AvatarSkinAssetItem.BMMBGKODCFA JBCJAIIHKMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40002AE")]
	private readonly AssetReference LBOCCBEELMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40002AF")]
	private readonly KKNCLIFJEEB? EPLOGLIJOAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40002B0")]
	private SkinnedMeshRenderer[] CAONACPABLP;

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public override EDHDPNHKKLO.IBJCDOEDFHO JAMMMNNAFBF
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0xAA5720", Offset = "0xAA3D20", VA = "0x180AA5720", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(EDHDPNHKKLO.IBJCDOEDFHO);
		}
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0xAA54E0", Offset = "0xAA3AE0", VA = "0x180AA54E0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x8337C40", Offset = "0x8336240", VA = "0x188337C40")]
	public KDFNADEHHNN(AvatarSkinAssetItem.BMMBGKODCFA ACINOFMPCLC, AssetReference JKALABANPKK, Material GDGEMOKCHIA, OKAGCDDNEAC HODHODILEKM, EDHDPNHKKLO.IBJCDOEDFHO GBHGNJODGFN = (EDHDPNHKKLO.IBJCDOEDFHO)0L, [Optional] KKNCLIFJEEB? IINNCIEJMKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x8337A40", Offset = "0x8336040", VA = "0x188337A40")]
	public KDFNADEHHNN(AvatarSkinAssetItem.BMMBGKODCFA ACINOFMPCLC, AssetReference JKALABANPKK, Material GDGEMOKCHIA, EDHDPNHKKLO.IBJCDOEDFHO GBHGNJODGFN = (EDHDPNHKKLO.IBJCDOEDFHO)0L, [Optional] KKNCLIFJEEB? IINNCIEJMKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x8337BA0", Offset = "0x83361A0", VA = "0x188337BA0")]
	public KDFNADEHHNN(AvatarSkinAssetItem.BMMBGKODCFA ACINOFMPCLC, AssetReference JKALABANPKK, Material[] FEFJHLAPLBC, OKAGCDDNEAC HODHODILEKM, EDHDPNHKKLO.IBJCDOEDFHO GBHGNJODGFN = (EDHDPNHKKLO.IBJCDOEDFHO)0L, [Optional] KKNCLIFJEEB? IINNCIEJMKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x83375A0", Offset = "0x8335BA0", VA = "0x1883375A0", Slot = "6")]
	public override FBCJGBABFLH CMPDJIDKNFC(List<LPJMHNKFBLM> BCDHLMJBKII, List<LPJMHNKFBLM> HHOOABDNEED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x8337770", Offset = "0x8335D70", VA = "0x188337770", Slot = "7")]
	public override LHMNOCEEDDP COPLEELKADA(uint OCNFNIGMAEF, AvatarSkinnedMeshBoneOrderRemapsData PABKCDJBDNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x83379D0", Offset = "0x8335FD0", VA = "0x1883379D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x8337980", Offset = "0x8335F80", VA = "0x188337980")]
	protected void EBKFLMECBDO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public class ANFPJNHPPAP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002B4")]
	private List<int> BHOCKBFLFFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002B5")]
	private List<NMNKCFEGEMN> KGCCKFMBCOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002B6")]
	private HashSet<Transform> IFCCBKLHGLC;

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x8329130", Offset = "0x8327730", VA = "0x188329130")]
	public static ANFPJNHPPAP KGHJPFOILIC(Transform DHDFDKFCOJK, Dictionary<Transform, OutfitType?> FMDFEKHEFKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x8328890", Offset = "0x8326E90", VA = "0x188328890")]
	private void CNOCPGKKJCI(Transform DHDFDKFCOJK, APMGGBJHHPH HODHODILEKM, Dictionary<Transform, OutfitType?> FMDFEKHEFKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x8328BB0", Offset = "0x83271B0", VA = "0x188328BB0")]
	private void EEJAIJFMEIA(Transform IHKHMPACMNB, APMGGBJHHPH HODHODILEKM, bool ELBBHBCGDNG, OutfitType? EAOCJHMJCEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x8328D40", Offset = "0x8327340", VA = "0x188328D40")]
	public JGEHHEHBIDG IIKDGCFMAKH(HashSet<string> GHIDAFLEGNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x83292C0", Offset = "0x83278C0", VA = "0x1883292C0")]
	public ANFPJNHPPAP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public class JGEHHEHBIDG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40002B7")]
	private List<NMNKCFEGEMN> KGCCKFMBCOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40002B8")]
	private List<Matrix4x4> DMGJJDIPCEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40002B9")]
	private Transform[] OHMIJDEBCAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40002BA")]
	private Matrix4x4[] MOEMKMNEAJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002BB")]
	private Dictionary<ELNBDMNFODJ, int> AOOAKGAFALN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002BC")]
	private List<MFGKAHHCCLJ> EOBKFLPLGEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40002BD")]
	private bool EBOOPDCMOGB;

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public int EEGOGBABKAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x8334430", Offset = "0x8332A30", VA = "0x188334430")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public Transform[] BBDLELKBHBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x83342C0", Offset = "0x83328C0", VA = "0x1883342C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public Matrix4x4[] GCFHLLEEPNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x8334620", Offset = "0x8332C20", VA = "0x188334620")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x8333F70", Offset = "0x8332570", VA = "0x188333F70")]
	public void EEJAIJFMEIA(Transform IHKHMPACMNB, APMGGBJHHPH HODHODILEKM, OutfitType? EAOCJHMJCEG, bool JIENBBIPFHL = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x8333C00", Offset = "0x8332200", VA = "0x188333C00")]
	private void EEJAIJFMEIA(Transform IHKHMPACMNB, APMGGBJHHPH HODHODILEKM, OutfitType? EAOCJHMJCEG, bool JIENBBIPFHL, Matrix4x4 KICEGKCMMPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x8334470", Offset = "0x8332A70", VA = "0x188334470")]
	public int KPOFNCKAPNJ(ELNBDMNFODJ HAELBKGFDIJ, bool IDFGCJOIMDM, [Optional] OutfitType? EAOCJHMJCEG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x8333B00", Offset = "0x8332100", VA = "0x188333B00")]
	public int CIBAAFIOKBI(APMGGBJHHPH HODHODILEKM, [Optional] OutfitType? EAOCJHMJCEG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x8334690", Offset = "0x8332C90", VA = "0x188334690")]
	public void LKMDJNLFIFC(ELNBDMNFODJ HAELBKGFDIJ, Matrix4x4 ALJLMBLJKAL, bool IDFGCJOIMDM = false, [Optional] OutfitType? EAOCJHMJCEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x8334170", Offset = "0x8332770", VA = "0x188334170")]
	public Matrix4x4 EFALFABBJLP(ELNBDMNFODJ HAELBKGFDIJ, bool IDFGCJOIMDM, [Optional] OutfitType? EAOCJHMJCEG)
	{
		return default(Matrix4x4);
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x12AD750", Offset = "0x12ABD50", VA = "0x1812AD750")]
	public void CFPAHHLFABL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x8334780", Offset = "0x8332D80", VA = "0x188334780")]
	public JGEHHEHBIDG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public struct ELNBDMNFODJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002C1")]
	public readonly string BCHPLGONBMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40002C2")]
	public readonly APMGGBJHHPH ODGBELDFKMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40002C3")]
	public readonly OutfitType? CEHOHPPJFOK;

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x832DF30", Offset = "0x832C530", VA = "0x18832DF30")]
	public ELNBDMNFODJ(string AOLGENGICKA, APMGGBJHHPH HODHODILEKM, [Optional] OutfitType? EAOCJHMJCEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x832DE80", Offset = "0x832C480", VA = "0x18832DE80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x832DD50", Offset = "0x832C350", VA = "0x18832DD50")]
	public bool GIDJLDBOFOE(ELNBDMNFODJ AAGCKLPFJME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x832DCB0", Offset = "0x832C2B0", VA = "0x18832DCB0", Slot = "0")]
	public override bool Equals(object MPIDDJPOOMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x832DE10", Offset = "0x832C410", VA = "0x18832DE10", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public struct MFGKAHHCCLJ : IEquatable<MFGKAHHCCLJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002C4")]
	public readonly APMGGBJHHPH ODGBELDFKMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40002C5")]
	public readonly OutfitType? HCKFCPDDLPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40002C6")]
	public readonly int MJNFOHFFKKB;

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x8338F00", Offset = "0x8337500", VA = "0x188338F00")]
	public MFGKAHHCCLJ(APMGGBJHHPH HODHODILEKM, int IEHPBPMJMDD, [Optional] OutfitType? CHMPOKDKMII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x8338E30", Offset = "0x8337430", VA = "0x188338E30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x74DB0C0", Offset = "0x74D96C0", VA = "0x1874DB0C0")]
	public bool OJNCJOFJANN(APMGGBJHHPH HODHODILEKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x8338DB0", Offset = "0x83373B0", VA = "0x188338DB0")]
	public bool OOAAJCAPOKL(OutfitType? CHMPOKDKMII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x8338D10", Offset = "0x8337310", VA = "0x188338D10", Slot = "4")]
	public bool Equals(MFGKAHHCCLJ AAGCKLPFJME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x8338C20", Offset = "0x8337220", VA = "0x188338C20", Slot = "0")]
	public override bool Equals(object MPIDDJPOOMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x8338D60", Offset = "0x8337360", VA = "0x188338D60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public struct NMNKCFEGEMN : IEquatable<NMNKCFEGEMN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002C7")]
	public readonly Transform NHHBFEFIAAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40002C8")]
	public readonly bool NNEFCEPIMBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x40002C9")]
	public readonly APMGGBJHHPH DEFPMLCHIAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40002CA")]
	public readonly OutfitType? CEHOHPPJFOK;

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x833C780", Offset = "0x833AD80", VA = "0x18833C780")]
	public NMNKCFEGEMN(Transform IHKHMPACMNB, bool ELBBHBCGDNG, APMGGBJHHPH GFHFKJIEGCL, [Optional] OutfitType? BIBPMDOLNHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x833C570", Offset = "0x833AB70", VA = "0x18833C570", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x833C310", Offset = "0x833A910", VA = "0x18833C310", Slot = "4")]
	public bool Equals(NMNKCFEGEMN AAGCKLPFJME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x833C410", Offset = "0x833AA10", VA = "0x18833C410", Slot = "0")]
	public override bool Equals(object MPIDDJPOOMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x833C4F0", Offset = "0x833AAF0", VA = "0x18833C4F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[ExecuteInEditMode]
	public class FitMeshHemisphereUpdater : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		public const float DEFAULT_Y_POSITION_OFFSET = 0.04f;

		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		public const float MAX_HEMISPHERE_POSITION_OFFSET = 0.05f;

		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		public const float MAX_HEMISPHERE_ROTATION_OFFSET = 45f;

		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		public const float MAX_HEMISPHERE_SCALE = 2f;

		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		public const float MIN_HEMISPHERE_SCALE = 0.75f;

		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		public const float MAX_HEMISPHERE_RADIUS = 0.25f;

		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		public const float MIN_HEMISPHERE_RADIUS = 0.125f;

		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		public static GameObject ContainerGO;

		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		public static GameObject CurrentHairHemisphereGO;

		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		public static Transform CurrentHairHemisphereMeshTransform;

		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		public static FitMeshHemisphereUpdater CurrentHairHemisphereUpdater;

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x8330400", Offset = "0x832EA00", VA = "0x188330400")]
		public static void DespawnHairHemisphere()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980")]
		public void UpdateValues()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0xAA8970", Offset = "0xAA6F70", VA = "0x180AA8970")]
		public FitMeshHemisphereUpdater()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public interface DPKAMKLEMCD
{
	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HFDCDKHCCMI(Mesh KNHPHEPPGOL, Matrix4x4 HILGEEKPAKM, IReadOnlyList<byte> KDDKFGLOION, bool HHIKEDLEAKF = false, EDHDPNHKKLO.IBJCDOEDFHO FFAGOFKLCLM = (EDHDPNHKKLO.IBJCDOEDFHO)0L, int BJLMNNIEFKO = -1, bool MLFJMELEAEN = false);

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DIMIOEOAFCL(Allocator EEDCBHBBPKF, PBNAJDPJKEO KCOEFNNKEBI, byte AJNJHCGFPCI, [Optional] IList<int> EAIPEOLBKAN, [Optional] IList<int> OELAAMCPAHL);
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public readonly struct JHAPPKMEGOK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002D6")]
	public readonly GameObject LBHFPIDKJKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40002D7")]
	private readonly AvatarItemMaterial LPNPJGELFLL;

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0xC5DA70", Offset = "0xC5C070", VA = "0x180C5DA70")]
	public JHAPPKMEGOK(GameObject LBHFPIDKJKB, AvatarItemMaterial LPNPJGELFLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x83348F0", Offset = "0x8332EF0", VA = "0x1883348F0")]
	public void GMKBPMNJMPM(Material PFHPGDKJCCC, int JJCENJEBMDL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public class AMKCEFOOLAF : FBGJMBJJPEA<Task<(GameObject, AvatarItemMaterial)>, JHAPPKMEGOK>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private struct CHIHEDIGOEC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		public AsyncTaskMethodBuilder<(GameObject, AvatarItemMaterial)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		public Task<GameObject> goTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		public Task<AvatarItemMaterial> materialTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		private GameObject <go>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		private TaskAwaiter<GameObject> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		private TaskAwaiter<AvatarItemMaterial> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x832D390", Offset = "0x832B990", VA = "0x18832D390", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x832D890", Offset = "0x832BE90", VA = "0x18832D890", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002D8")]
	private OFBDOHFHPFI<GameObject> KHGDFAFAAEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002D9")]
	private OFBDOHFHPFI<AvatarItemMaterial> GAMKFIMPLKA;

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x8328800", Offset = "0x8326E00", VA = "0x188328800")]
	private AMKCEFOOLAF(Task<(GameObject, AvatarItemMaterial)> DIAHJIAKEPB, OFBDOHFHPFI<GameObject> NJEPKJJMFNO, OFBDOHFHPFI<AvatarItemMaterial> MEECFKEHEKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x8328210", Offset = "0x8326810", VA = "0x188328210")]
	public static AMKCEFOOLAF CEAHGFMKGJD(AssetReference BPNAECHHKON, [Optional] AssetReference GDEGADLHOIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x8328630", Offset = "0x8326C30", VA = "0x188328630", Slot = "11")]
	protected override JHAPPKMEGOK HBBFAMFHPNI(Task<(GameObject, AvatarItemMaterial)> FHOJKIEPBJI)
	{
		return default(JHAPPKMEGOK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x8328190", Offset = "0x8326790", VA = "0x188328190", Slot = "12")]
	protected override void ACDKHOBEFKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x83286D0", Offset = "0x8326CD0", VA = "0x1883286D0")]
	[AsyncStateMachine(typeof(CHIHEDIGOEC))]
	private static Task<(GameObject, AvatarItemMaterial)> MKEIJEFGFND(Task<GameObject> BNEFPNCONOF, Task<AvatarItemMaterial> OHJMECGACCA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public static class LAGDFLNNHJE
{
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	private class FOGFJOLDIKD : FBGJMBJJPEA<Task<MaterialMapAsset>, Material[]>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		private OFBDOHFHPFI<MaterialMapAsset> MNHLJANEAIO;

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x8343410", Offset = "0x8341A10", VA = "0x188343410")]
		public FOGFJOLDIKD(OFBDOHFHPFI<MaterialMapAsset> MNHLJANEAIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x8342FA0", Offset = "0x83415A0", VA = "0x188342FA0", Slot = "11")]
		protected override Material[] HBBFAMFHPNI(Task<MaterialMapAsset> DIAHJIAKEPB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x8342F40", Offset = "0x8341540", VA = "0x188342F40", Slot = "12")]
		protected override void ACDKHOBEFKK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	private class BHIJLMFKPPK : FBGJMBJJPEA<Task<Material[]>, Material[]>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		private List<OFBDOHFHPFI<Material>> NMIBJADALJH;

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x833DBC0", Offset = "0x833C1C0", VA = "0x18833DBC0")]
		public BHIJLMFKPPK(Task<Material[]> DIAHJIAKEPB, List<OFBDOHFHPFI<Material>> NMIBJADALJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x833DB70", Offset = "0x833C170", VA = "0x18833DB70", Slot = "11")]
		protected override Material[] HBBFAMFHPNI(Task<Material[]> FHOJKIEPBJI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x833DA30", Offset = "0x833C030", VA = "0x18833DA30", Slot = "12")]
		protected override void ACDKHOBEFKK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40002E4")]
	private static readonly IPHNFELODMJ AMCHCCAPJNG;

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x8343DC0", Offset = "0x83423C0", VA = "0x188343DC0")]
	public static OFBDOHFHPFI<Material[]> GIGLECMDCCD(AssetReference[] PONJBHHLFEO)
	{
		return null;
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[DisallowMultipleComponent]
	public class PlayerAvatarDisplayBase : AvatarDisplayBase
	{
		[Cpp2IlInjected.Token(Token = "0x2000059")]
		public enum KAMFIAAGGBP
		{
			[Cpp2IlInjected.Token(Token = "0x400036B")]
			None,
			[Cpp2IlInjected.Token(Token = "0x400036C")]
			TeamItem,
			[Cpp2IlInjected.Token(Token = "0x400036D")]
			SkinColor,
			[Cpp2IlInjected.Token(Token = "0x400036E")]
			HairColor,
			[Cpp2IlInjected.Token(Token = "0x400036F")]
			BeardColor,
			[Cpp2IlInjected.Token(Token = "0x4000370")]
			UGCShirtColor
		}

		[Cpp2IlInjected.Token(Token = "0x200005A")]
		public enum KPFMJGHNFJH
		{
			[Cpp2IlInjected.Token(Token = "0x4000372")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4000373")]
			HairTexture,
			[Cpp2IlInjected.Token(Token = "0x4000374")]
			BeardTexture,
			[Cpp2IlInjected.Token(Token = "0x4000375")]
			UGCShirtTexture
		}

		[Cpp2IlInjected.Token(Token = "0x200005B")]
		public struct GCFLMGHLGCI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000376")]
			public readonly Material GOHKLGDEHHJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000377")]
			public readonly KAMFIAAGGBP AGMKAMMIDLH;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x4000378")]
			public readonly KPFMJGHNFJH AFDCMGIIDGA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000379")]
			public readonly APMGGBJHHPH ODGBELDFKMH;

			[Cpp2IlInjected.Token(Token = "0x600030B")]
			[Cpp2IlInjected.Address(RVA = "0x8343CB0", Offset = "0x83422B0", VA = "0x188343CB0")]
			public GCFLMGHLGCI(Material PFHPGDKJCCC, KAMFIAAGGBP KABLBJCDPCG, KPFMJGHNFJH MLLLJAGOJFM, APMGGBJHHPH HODHODILEKM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600030C")]
			[Cpp2IlInjected.Address(RVA = "0x8343A90", Offset = "0x8342090", VA = "0x188343A90", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600030D")]
			[Cpp2IlInjected.Address(RVA = "0x8343970", Offset = "0x8341F70", VA = "0x188343970")]
			public bool GIDJLDBOFOE(GCFLMGHLGCI AAGCKLPFJME)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600030E")]
			[Cpp2IlInjected.Address(RVA = "0x8343890", Offset = "0x8341E90", VA = "0x188343890", Slot = "0")]
			public override bool Equals(object MPIDDJPOOMJ)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600030F")]
			[Cpp2IlInjected.Address(RVA = "0x83439F0", Offset = "0x8341FF0", VA = "0x1883439F0", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005C")]
		protected class NOHPIMMAGAI : IComparable<NOHPIMMAGAI>, IEquatable<NOHPIMMAGAI>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400037A")]
			public int KIPPINPBCBC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400037B")]
			public PlayerAvatarDisplayBase GAEFJPMCOGL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400037C")]
			public IList<HODKDMLKKBH> KINPNFKBLIM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400037D")]
			public AvatarItemBodyType IPEFDMCFGPC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x400037E")]
			public CFMMIIKBBEM JMAMGOHBNFC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400037F")]
			public bool CGOGONAKFAP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
			[Cpp2IlInjected.Token(Token = "0x4000380")]
			public bool DOPOLJMIAFA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000381")]
			public int[] MNCOMJENCFE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000382")]
			public float KEBNPPLDLHH;

			[Cpp2IlInjected.Token(Token = "0x6000310")]
			[Cpp2IlInjected.Address(RVA = "0x83449C0", Offset = "0x8342FC0", VA = "0x1883449C0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000311")]
			[Cpp2IlInjected.Address(RVA = "0x8344870", Offset = "0x8342E70", VA = "0x188344870", Slot = "4")]
			public int CompareTo(NOHPIMMAGAI AAGCKLPFJME)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000312")]
			[Cpp2IlInjected.Address(RVA = "0x83448A0", Offset = "0x8342EA0", VA = "0x1883448A0", Slot = "5")]
			public bool Equals(NOHPIMMAGAI AAGCKLPFJME)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000313")]
			[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
			public NOHPIMMAGAI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005D")]
		protected abstract class PLKBMGKOFGP
		{
			[Cpp2IlInjected.Token(Token = "0x200005E")]
			public class DDFHKOGODNL
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000386")]
				public readonly Mesh HKDGDFCCOMP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000387")]
				public readonly Material[] BNHCLFADNBC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000388")]
				public readonly Transform[] PHACHMENJNI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000389")]
				public readonly Matrix4x4[] HLELBHFPEOK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400038A")]
				public readonly Transform FEGJHDGAEDL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x400038B")]
				public readonly bool EFFCLDOKNCB;

				[Cpp2IlInjected.Token(Token = "0x600031B")]
				[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
				protected DDFHKOGODNL()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600031C")]
				[Cpp2IlInjected.Address(RVA = "0x833E250", Offset = "0x833C850", VA = "0x18833E250")]
				public DDFHKOGODNL(Mesh KNHPHEPPGOL, Material[] JNAIMIDPAFJ, bool EHBNBGGFCCG, Transform[] DNOKDGOLJFF, Transform ANMAAHKNJHO, Matrix4x4[] LIGEBDPAPAD)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600031D")]
				[Cpp2IlInjected.Address(RVA = "0x833E700", Offset = "0x833CD00", VA = "0x18833E700")]
				private DDFHKOGODNL(SkinnedMeshRenderer NNCHINPECMF, Material[] MNMHEEDEJCB)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600031E")]
				[Cpp2IlInjected.Address(RVA = "0x833E7C0", Offset = "0x833CDC0", VA = "0x18833E7C0")]
				private DDFHKOGODNL(MeshRenderer CPBJOPKEKBH, Transform ANMAAHKNJHO, Material[] MNMHEEDEJCB)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600031F")]
				[Cpp2IlInjected.Address(RVA = "0x833DF20", Offset = "0x833C520", VA = "0x18833DF20")]
				public static DDFHKOGODNL JIDPHBEPENH(Renderer MAFJPEPPLNH, Material[] MNMHEEDEJCB)
				{
					return null;
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000383")]
			public readonly APMGGBJHHPH ODGBELDFKMH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000384")]
			public readonly Transform JLLHCIGNDDG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000385")]
			public readonly bool ECDMNBDCBOE;

			[Cpp2IlInjected.Token(Token = "0x17000091")]
			public virtual bool LFLIGBAEIDP
			{
				[Cpp2IlInjected.Token(Token = "0x6000314")]
				[Cpp2IlInjected.Address(RVA = "0xAF14E0", Offset = "0xAEFAE0", VA = "0x180AF14E0", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000092")]
			public virtual bool FHPCCEFBNDM
			{
				[Cpp2IlInjected.Token(Token = "0x6000315")]
				[Cpp2IlInjected.Address(RVA = "0xAF14E0", Offset = "0xAEFAE0", VA = "0x180AF14E0", Slot = "5")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000093")]
			public virtual EDHDPNHKKLO.IBJCDOEDFHO JAMMMNNAFBF
			{
				[Cpp2IlInjected.Token(Token = "0x6000316")]
				[Cpp2IlInjected.Address(RVA = "0xAA8990", Offset = "0xAA6F90", VA = "0x180AA8990", Slot = "6")]
				get
				{
					return default(EDHDPNHKKLO.IBJCDOEDFHO);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000094")]
			public bool MAAEFIEEHAC
			{
				[Cpp2IlInjected.Token(Token = "0x6000317")]
				[Cpp2IlInjected.Address(RVA = "0x8345030", Offset = "0x8343630", VA = "0x188345030")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000318")]
			[Cpp2IlInjected.Address(RVA = "0x8345040", Offset = "0x8343640", VA = "0x188345040")]
			protected PLKBMGKOFGP(APMGGBJHHPH HODHODILEKM, Transform MCCKFNCNLEF, bool IHDGKGFIJJJ = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000319")]
			[Cpp2IlInjected.Address(Slot = "7")]
			public abstract FBCJGBABFLH CMPDJIDKNFC(List<LPJMHNKFBLM> BCDHLMJBKII, List<LPJMHNKFBLM> HHOOABDNEED);

			[Cpp2IlInjected.Token(Token = "0x600031A")]
			[Cpp2IlInjected.Address(Slot = "8")]
			public abstract DDFHKOGODNL COPLEELKADA(int OCNFNIGMAEF, PlayerHandBones HJPFEDEHIOJ);
		}

		[Cpp2IlInjected.Token(Token = "0x200005F")]
		protected class ACLKOJIDKNA : PLKBMGKOFGP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400038C")]
			protected readonly BodyPartLODs CAONACPABLP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400038D")]
			protected readonly Material[] CNMIHCBFANJ;

			[Cpp2IlInjected.Token(Token = "0x6000320")]
			[Cpp2IlInjected.Address(RVA = "0x833D930", Offset = "0x833BF30", VA = "0x18833D930")]
			public ACLKOJIDKNA(APMGGBJHHPH HODHODILEKM, BodyPartLODs OBFMMLJHHAD, Material GDGEMOKCHIA, [Optional] Transform MCCKFNCNLEF, bool IHDGKGFIJJJ = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000321")]
			[Cpp2IlInjected.Address(RVA = "0x833D670", Offset = "0x833BC70", VA = "0x18833D670", Slot = "7")]
			public override FBCJGBABFLH CMPDJIDKNFC(List<LPJMHNKFBLM> BCDHLMJBKII, List<LPJMHNKFBLM> HHOOABDNEED)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000322")]
			[Cpp2IlInjected.Address(RVA = "0x833D700", Offset = "0x833BD00", VA = "0x18833D700", Slot = "8")]
			public override DDFHKOGODNL COPLEELKADA(int OCNFNIGMAEF, PlayerHandBones HJPFEDEHIOJ)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000323")]
			[Cpp2IlInjected.Address(RVA = "0x833D8C0", Offset = "0x833BEC0", VA = "0x18833D8C0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000060")]
		protected class EKJBHFMEMHD : PLKBMGKOFGP
		{
			[Cpp2IlInjected.Token(Token = "0x17000095")]
			public override bool LFLIGBAEIDP
			{
				[Cpp2IlInjected.Token(Token = "0x6000324")]
				[Cpp2IlInjected.Address(RVA = "0xAC1E50", Offset = "0xAC0450", VA = "0x180AC1E50", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000096")]
			public override bool FHPCCEFBNDM
			{
				[Cpp2IlInjected.Token(Token = "0x6000325")]
				[Cpp2IlInjected.Address(RVA = "0x83416F0", Offset = "0x833FCF0", VA = "0x1883416F0", Slot = "5")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000097")]
			public AONMEGFPBGH PIIMBLJHCBJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000326")]
				[Cpp2IlInjected.Address(RVA = "0xAA5560", Offset = "0xAA3B60", VA = "0x180AA5560")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000327")]
				[Cpp2IlInjected.Address(RVA = "0xAA9ED0", Offset = "0xAA84D0", VA = "0x180AA9ED0")]
				[CompilerGenerated]
				protected set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000328")]
			[Cpp2IlInjected.Address(RVA = "0x83417B0", Offset = "0x833FDB0", VA = "0x1883417B0")]
			public EKJBHFMEMHD(APMGGBJHHPH HODHODILEKM, Transform MCCKFNCNLEF, AONMEGFPBGH KIEJPLFJFIG, bool IHDGKGFIJJJ = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000329")]
			[Cpp2IlInjected.Address(RVA = "0x8341660", Offset = "0x833FC60", VA = "0x188341660", Slot = "7")]
			public override FBCJGBABFLH CMPDJIDKNFC(List<LPJMHNKFBLM> BCDHLMJBKII, List<LPJMHNKFBLM> HHOOABDNEED)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600032A")]
			[Cpp2IlInjected.Address(RVA = "0xAA8990", Offset = "0xAA6F90", VA = "0x180AA8990", Slot = "8")]
			public override DDFHKOGODNL COPLEELKADA(int OCNFNIGMAEF, PlayerHandBones HJPFEDEHIOJ)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600032B")]
			[Cpp2IlInjected.Address(RVA = "0x8341740", Offset = "0x833FD40", VA = "0x188341740", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000061")]
		public class FJFHBAFPHLO
		{
			[Cpp2IlInjected.Token(Token = "0x2000062")]
			public enum NPJNAPECDOM
			{
				[Cpp2IlInjected.Token(Token = "0x400039F")]
				PLAYER_PUPPET,
				[Cpp2IlInjected.Token(Token = "0x40003A0")]
				PLAYER_DISPLAY_POSER,
				[Cpp2IlInjected.Token(Token = "0x40003A1")]
				PLAYER_HAND,
				[Cpp2IlInjected.Token(Token = "0x40003A2")]
				STNMONSTERCOSTUME_OPTION_HIDE_EXCEPT_UI,
				[Cpp2IlInjected.Token(Token = "0x40003A3")]
				PLAYER_HAND_POINTING,
				[Cpp2IlInjected.Token(Token = "0x40003A4")]
				STNMONSTERCOSTUME_OPTION_ALWAYS_HIDE,
				[Cpp2IlInjected.Token(Token = "0x40003A5")]
				EDITOR
			}

			[Cpp2IlInjected.Token(Token = "0x400038F")]
			public static readonly int ILDKJEEGBDO;

			[Cpp2IlInjected.Token(Token = "0x4000390")]
			public static readonly int IGBNFHOOEKI;

			[Cpp2IlInjected.Token(Token = "0x4000391")]
			public static readonly int IBGKECKHILJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000392")]
			protected readonly JKDJCOOGOJL DHCBIDEGLHB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000393")]
			protected readonly AIMIDGCLOIF EINGMHCJAEC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000394")]
			protected readonly Animator INEKGJDFCGP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000395")]
			protected readonly Transform PHHOMHNGFCD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000396")]
			public Vector3 GGECHLJPNOF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000397")]
			protected readonly Transform AIFNACCMCBM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000398")]
			public Vector3 IMBFFMJNOPM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x4000399")]
			protected bool KMFHFEMCEHP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400039A")]
			protected GDGKEFFDPOH DEKJLNLNHHE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400039B")]
			protected bool APNLPCFPEPA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
			[Cpp2IlInjected.Token(Token = "0x400039C")]
			protected float KLIJGMGGDKG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x400039D")]
			protected JKOPAHCCABD<ALNHBAFPCMB> ELBMJPMLHBJ;

			[Cpp2IlInjected.Token(Token = "0x17000098")]
			public GDGKEFFDPOH BAJCPIPBLFF
			{
				[Cpp2IlInjected.Token(Token = "0x600032C")]
				[Cpp2IlInjected.Address(RVA = "0xAA54C0", Offset = "0xAA3AC0", VA = "0x180AA54C0")]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600032D")]
				[Cpp2IlInjected.Address(RVA = "0xAA5570", Offset = "0xAA3B70", VA = "0x180AA5570")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000099")]
			public bool ADADMGJIHKG
			{
				[Cpp2IlInjected.Token(Token = "0x600032E")]
				[Cpp2IlInjected.Address(RVA = "0xD841F0", Offset = "0xD827F0", VA = "0x180D841F0")]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x600032F")]
				[Cpp2IlInjected.Address(RVA = "0x8341F50", Offset = "0x8340550", VA = "0x188341F50")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009A")]
			public bool NILMLEHKEFG
			{
				[Cpp2IlInjected.Token(Token = "0x6000330")]
				[Cpp2IlInjected.Address(RVA = "0xAA5550", Offset = "0xAA3B50", VA = "0x180AA5550")]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x6000331")]
				[Cpp2IlInjected.Address(RVA = "0x8342190", Offset = "0x8340790", VA = "0x188342190")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009B")]
			public float BDAJIGKFNFO
			{
				[Cpp2IlInjected.Token(Token = "0x6000332")]
				[Cpp2IlInjected.Address(RVA = "0xE36840", Offset = "0xE34E40", VA = "0x180E36840")]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x6000333")]
				[Cpp2IlInjected.Address(RVA = "0x8341E10", Offset = "0x8340410", VA = "0x188341E10")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009C")]
			public ALNHBAFPCMB NMAKPPFGFLG
			{
				[Cpp2IlInjected.Token(Token = "0x6000334")]
				[Cpp2IlInjected.Address(RVA = "0x8342610", Offset = "0x8340C10", VA = "0x188342610")]
				get
				{
					return default(ALNHBAFPCMB);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000335")]
			[Cpp2IlInjected.Address(RVA = "0x8342080", Offset = "0x8340680", VA = "0x188342080")]
			public bool ECKEJBCALCB(ALNHBAFPCMB LGECLDCIIPL, object INEEADCBMPK, NPJNAPECDOM EOENKBEJCMN)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000336")]
			[Cpp2IlInjected.Address(RVA = "0x8341D10", Offset = "0x8340310", VA = "0x188341D10")]
			public bool CEPOJEEKKEJ(object INEEADCBMPK)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000337")]
			[Cpp2IlInjected.Address(RVA = "0x8342EB0", Offset = "0x83414B0", VA = "0x188342EB0")]
			protected FJFHBAFPHLO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000338")]
			[Cpp2IlInjected.Address(RVA = "0x83428C0", Offset = "0x8340EC0", VA = "0x1883428C0")]
			public FJFHBAFPHLO(JKDJCOOGOJL DHCBIDEGLHB, GDGKEFFDPOH BMEKACOPEEE, Animator INEKGJDFCGP, Transform PHHOMHNGFCD, Transform AIFNACCMCBM, Vector3 GGECHLJPNOF, Vector3 IMBFFMJNOPM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000339")]
			[Cpp2IlInjected.Address(RVA = "0x8342650", Offset = "0x8340C50", VA = "0x188342650")]
			private void PGOAKIDGMJM(ushort AMPDFGHFIID, ushort PCMALFILIJA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600033A")]
			[Cpp2IlInjected.Address(RVA = "0x8341C20", Offset = "0x8340220", VA = "0x188341C20")]
			protected void BOKPFMDIJOO(ushort AMPDFGHFIID, ushort PCMALFILIJA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600033B")]
			[Cpp2IlInjected.Address(RVA = "0x8342430", Offset = "0x8340A30", VA = "0x188342430")]
			protected void MMFPPIPONBI(ushort AMPDFGHFIID, ushort PCMALFILIJA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600033C")]
			[Cpp2IlInjected.Address(RVA = "0x8342300", Offset = "0x8340900", VA = "0x188342300")]
			protected void MHJDHKMPOPL(ushort AMPDFGHFIID, ushort PCMALFILIJA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600033D")]
			[Cpp2IlInjected.Address(RVA = "0x8342700", Offset = "0x8340D00", VA = "0x188342700")]
			protected void PJOLDLELCGN(ushort AMPDFGHFIID, ushort PCMALFILIJA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600033E")]
			[Cpp2IlInjected.Address(RVA = "0x8342020", Offset = "0x8340620", VA = "0x188342020")]
			protected void DCPLMBHNEHB(ushort AMPDFGHFIID, ushort PCMALFILIJA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600033F")]
			[Cpp2IlInjected.Address(RVA = "0x83422B0", Offset = "0x83408B0", VA = "0x1883422B0")]
			protected void MAGBAJPDHMN(ushort AMPDFGHFIID, ushort PCMALFILIJA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000340")]
			[Cpp2IlInjected.Address(RVA = "0x8342260", Offset = "0x8340860", VA = "0x188342260")]
			protected void FEJNIFLGBJJ(ushort AMPDFGHFIID, ushort PCMALFILIJA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000341")]
			[Cpp2IlInjected.Address(RVA = "0x83424F0", Offset = "0x8340AF0", VA = "0x1883424F0")]
			protected void OHIDOAAJIHO(ushort AMPDFGHFIID, ushort PCMALFILIJA)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000063")]
		public class EEIIADDAJMP : IDisposable
		{
			[Cpp2IlInjected.Token(Token = "0x40003A6")]
			public const int PKLDAGDAAHG = 16;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003A7")]
			protected MaterialPropertyBlock KDOGKGHJHKO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003A8")]
			public Color? LFFCPPIIGDO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40003A9")]
			public Color? MHIKDLAHNEA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40003AA")]
			public Color? HNKCGLFNNOI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x40003AB")]
			public Color DDNEMGACOII;

			[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
			[Cpp2IlInjected.Token(Token = "0x40003AC")]
			public Color EMCGFGCFBNJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
			[Cpp2IlInjected.Token(Token = "0x40003AD")]
			public Color CNEHJOCGIKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x40003AE")]
			public Texture2D JMKMMGBBCBC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x40003AF")]
			public Texture2D OFMCEMGPGBL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x40003B0")]
			protected Dictionary<GCFLMGHLGCI, int> HLFENNFMLBE;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x40003B1")]
			protected KAMFIAAGGBP[] IPDJMKFHDJH;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x40003B2")]
			public Vector4[] GLFJBKIDKNO;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x40003B3")]
			public Vector4[] NANOFOGGEPL;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x40003B4")]
			public Vector4[] FKCBKCFAMEG;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x40003B5")]
			public Vector4[] NNLDILIGDNI;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
			[Cpp2IlInjected.Token(Token = "0x40003B6")]
			public Vector4[] INGGJHPKGHA;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
			[Cpp2IlInjected.Token(Token = "0x40003B7")]
			public Vector4[] BAMIACDJNKI;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x40003B8")]
			protected List<Texture2D> HNJECEDFKCB;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x40003B9")]
			protected Vector4[] OPLANIBEOAP;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
			[Cpp2IlInjected.Token(Token = "0x40003BA")]
			protected List<Texture2D> IFMJMNNKNPJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
			[Cpp2IlInjected.Token(Token = "0x40003BB")]
			protected float[] NDODACEFBGL;

			[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
			[Cpp2IlInjected.Token(Token = "0x40003BC")]
			protected Vector4[] MNMNLMOLJDF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
			[Cpp2IlInjected.Token(Token = "0x40003BD")]
			protected float[] HLBAGAAEPKA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
			[Cpp2IlInjected.Token(Token = "0x40003BE")]
			public float[] IFODCONJJFD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
			[Cpp2IlInjected.Token(Token = "0x40003BF")]
			protected List<Texture2D> FKNCMFOGNLE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
			[Cpp2IlInjected.Token(Token = "0x40003C0")]
			protected float[] JCEINLIPIPF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
			[Cpp2IlInjected.Token(Token = "0x40003C1")]
			protected List<Texture2D> DDCODKOBLCG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
			[Cpp2IlInjected.Token(Token = "0x40003C2")]
			protected Vector4[] OJHDNFCGEGF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
			[Cpp2IlInjected.Token(Token = "0x40003C3")]
			protected float[] HOCFBCCHOLD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
			[Cpp2IlInjected.Token(Token = "0x40003C4")]
			protected Vector4[] EEPJFBMKKOK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
			[Cpp2IlInjected.Token(Token = "0x40003C5")]
			public float[] FHAIMFHNEHM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
			[Cpp2IlInjected.Token(Token = "0x40003C6")]
			public Texture2DArray CDBAOCBNBOL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
			[Cpp2IlInjected.Token(Token = "0x40003C7")]
			public Texture2DArray EKDMLCMHGOM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
			[Cpp2IlInjected.Token(Token = "0x40003C8")]
			public Texture2DArray ENPEHEBCAIP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
			[Cpp2IlInjected.Token(Token = "0x40003C9")]
			public Texture2DArray HAJDLODDDEF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
			[Cpp2IlInjected.Token(Token = "0x40003CA")]
			protected bool FOOJHDMMBKB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x16C")]
			[Cpp2IlInjected.Token(Token = "0x40003CB")]
			protected int AEDCHBDCKFJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
			[Cpp2IlInjected.Token(Token = "0x40003CC")]
			protected Vector2? EKBMMDCOMBO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x17C")]
			[Cpp2IlInjected.Token(Token = "0x40003CD")]
			protected TextureFormat KIHADGEHKKO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
			[Cpp2IlInjected.Token(Token = "0x40003CE")]
			protected Vector2? OEENPAMMFGH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18C")]
			[Cpp2IlInjected.Token(Token = "0x40003CF")]
			protected TextureFormat HOFNGGBBPJF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
			[Cpp2IlInjected.Token(Token = "0x40003D0")]
			protected Vector2? BLBCLGJDDDL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x19C")]
			[Cpp2IlInjected.Token(Token = "0x40003D1")]
			protected TextureFormat INKEGFHLGHJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
			[Cpp2IlInjected.Token(Token = "0x40003D2")]
			protected Vector2? FEJGKNNIDBB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1AC")]
			[Cpp2IlInjected.Token(Token = "0x40003D3")]
			protected TextureFormat GGPJNBKGMMC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
			[Cpp2IlInjected.Token(Token = "0x40003D4")]
			protected bool AHFHMNIBLBI;

			[Cpp2IlInjected.Token(Token = "0x40003D5")]
			protected static int ACFNAILNCGH;

			[Cpp2IlInjected.Token(Token = "0x40003D6")]
			protected static int CFIFLFPNCKI;

			[Cpp2IlInjected.Token(Token = "0x40003D7")]
			protected static int FKNIGAKJBGD;

			[Cpp2IlInjected.Token(Token = "0x40003D8")]
			protected static int GDMOMOAIKBN;

			[Cpp2IlInjected.Token(Token = "0x40003D9")]
			protected static int EJGNOEAJPBC;

			[Cpp2IlInjected.Token(Token = "0x40003DA")]
			protected static int OLCPAEGEBEE;

			[Cpp2IlInjected.Token(Token = "0x40003DB")]
			protected static int AECLDPDBNDA;

			[Cpp2IlInjected.Token(Token = "0x40003DC")]
			protected static int CKPDHJOKBBL;

			[Cpp2IlInjected.Token(Token = "0x40003DD")]
			protected static int AGFHHPANGFB;

			[Cpp2IlInjected.Token(Token = "0x40003DE")]
			protected static int OIIEJPEIOAL;

			[Cpp2IlInjected.Token(Token = "0x40003DF")]
			protected static int OAFDNNNGKJA;

			[Cpp2IlInjected.Token(Token = "0x40003E0")]
			protected static int JGBGDAEHAJO;

			[Cpp2IlInjected.Token(Token = "0x40003E1")]
			protected static int LKBJAODOJCP;

			[Cpp2IlInjected.Token(Token = "0x40003E2")]
			protected static int INHJMCLDHLG;

			[Cpp2IlInjected.Token(Token = "0x40003E3")]
			protected static int ILMPJEBDLID;

			[Cpp2IlInjected.Token(Token = "0x40003E4")]
			protected static int NFIKCLLLPHH;

			[Cpp2IlInjected.Token(Token = "0x40003E5")]
			protected static int FBKFFCEBPIG;

			[Cpp2IlInjected.Token(Token = "0x40003E6")]
			protected static int HCJHHEOPCCH;

			[Cpp2IlInjected.Token(Token = "0x40003E7")]
			protected static int NPBKAPLLDAD;

			[Cpp2IlInjected.Token(Token = "0x40003E8")]
			protected static int CKMFFACNMOK;

			[Cpp2IlInjected.Token(Token = "0x6000343")]
			[Cpp2IlInjected.Address(RVA = "0x83411A0", Offset = "0x833F7A0", VA = "0x1883411A0")]
			protected EEIIADDAJMP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000344")]
			[Cpp2IlInjected.Address(RVA = "0x8341110", Offset = "0x833F710", VA = "0x188341110")]
			public EEIIADDAJMP(Color DKMPFPDNJAH, Color NACBAIHDHON, Color MCCJNHKBBMA, Color? PDMMLMNLHJO, Color? BENCIEJODOF, Color? BCNPHJMGANA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000345")]
			[Cpp2IlInjected.Address(RVA = "0x8340C90", Offset = "0x833F290", VA = "0x188340C90")]
			public int JMCLDPEMNPE(Material IOADAPHPPDH, KAMFIAAGGBP KABLBJCDPCG, KPFMJGHNFJH MLLLJAGOJFM, APMGGBJHHPH HODHODILEKM)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000346")]
			[Cpp2IlInjected.Address(RVA = "0x8340C00", Offset = "0x833F200", VA = "0x188340C00")]
			public int JMCLDPEMNPE(GCFLMGHLGCI HAELBKGFDIJ)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000347")]
			[Cpp2IlInjected.Address(RVA = "0x833F120", Offset = "0x833D720", VA = "0x18833F120")]
			public int DNBLMOJFKHG(Material IOADAPHPPDH, Color NFEJPKHFMJO, Color ICMHNDNCEOD, Color KMPNODPEACK, Color KPBPNJMJJMG, Color IMBNPHNCDAC, Texture2D CABJABOCAIA, Vector4 HAMKHBDJHLL, Texture2D IMEBLFKEAHA, Vector4 HIAOEMIMHAM, float KBDCMFMELIB, float JINAAIDAACF, Texture2D GGFHOMLNCFE, Vector4 HEJBOCEBNIM, float AJJFNBOGGFJ, Texture2D DNDNBAADKBD, float EGPLMOBCFEP, Color CILGEIEMLNM, Vector4 IAFABHMOOON, KAMFIAAGGBP KABLBJCDPCG, KPFMJGHNFJH MLLLJAGOJFM, APMGGBJHHPH HODHODILEKM)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000348")]
			[Cpp2IlInjected.Address(RVA = "0x833EBA0", Offset = "0x833D1A0", VA = "0x18833EBA0")]
			protected void AICOHKJMBCB([Out] Texture2DArray OEHIMBCHIFA, [Out] Texture2DArray DEPDGEMJHOB, [Out] Texture2DArray KBGAAKJGAJB, [Out] Texture2DArray KCPGBOCDPKO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000349")]
			[Cpp2IlInjected.Address(RVA = "0x833EEB0", Offset = "0x833D4B0", VA = "0x18833EEB0")]
			public void CBOPCCLAFCC(PlayerAvatarDisplayBase OKAPNHDFMBA, Renderer MAFJPEPPLNH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034A")]
			[Cpp2IlInjected.Address(RVA = "0x833FE60", Offset = "0x833E460", VA = "0x18833FE60")]
			protected void EFECIMHFFJI(PlayerAvatarDisplayBase OKAPNHDFMBA, Renderer MAFJPEPPLNH, int EGLDCLMMOFJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034B")]
			[Cpp2IlInjected.Address(RVA = "0x8340980", Offset = "0x833EF80", VA = "0x188340980")]
			private Color FAOOCAAEMID(Color HFHABGJIPIO, KAMFIAAGGBP NJNDMFEOFPN)
			{
				return default(Color);
			}

			[Cpp2IlInjected.Token(Token = "0x600034C")]
			[Cpp2IlInjected.Address(RVA = "0x833ED60", Offset = "0x833D360", VA = "0x18833ED60")]
			private Color ANHDEFBIADL(Color OKFNBCEJCBA, KAMFIAAGGBP NJNDMFEOFPN)
			{
				return default(Color);
			}

			[Cpp2IlInjected.Token(Token = "0x600034D")]
			[Cpp2IlInjected.Address(RVA = "0x8340B70", Offset = "0x833F170", VA = "0x188340B70")]
			protected void HMMGJOPJFHP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034E")]
			[Cpp2IlInjected.Address(RVA = "0x833FE20", Offset = "0x833E420", VA = "0x18833FE20", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000064")]
		public struct PlayerHandBones
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003E9")]
			public Transform[] LeftHandBones;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003EA")]
			public Transform LeftHandRoot;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003EB")]
			public Transform[] RightHandBones;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003EC")]
			public Transform RightHandRoot;

			[Cpp2IlInjected.Token(Token = "0x6000350")]
			[Cpp2IlInjected.Address(RVA = "0x835A380", Offset = "0x8358980", VA = "0x18835A380")]
			public void PHHMPOMMACK(APMGGBJHHPH HODHODILEKM, [Out] Transform BOCNDANOLJJ, [Out] Transform[] DNOKDGOLJFF)
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000065")]
		protected struct BodyPartLODs
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003ED")]
			public Mesh[] LODs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003EE")]
			public bool UseHandBones;
		}

		[Cpp2IlInjected.Token(Token = "0x2000067")]
		[CompilerGenerated]
		private sealed class NMAKHMCHNHM : IEnumerable<SkinnedMeshRenderer>, IEnumerable, IEnumerator<SkinnedMeshRenderer>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003F6")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003F7")]
			private SkinnedMeshRenderer <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003F8")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003F9")]
			public PlayerAvatarDisplayBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003FA")]
			private SkinnedMeshRenderer[] <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003FB")]
			private int <>7__wrap2;

			[Cpp2IlInjected.Token(Token = "0x1700009D")]
			SkinnedMeshRenderer IEnumerator<SkinnedMeshRenderer>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600035C")]
				[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009E")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600035E")]
				[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000359")]
			[Cpp2IlInjected.Address(RVA = "0xBF4940", Offset = "0xBF2F40", VA = "0x180BF4940")]
			[DebuggerHidden]
			public NMAKHMCHNHM(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600035A")]
			[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600035B")]
			[Cpp2IlInjected.Address(RVA = "0x83445A0", Offset = "0x8342BA0", VA = "0x1883445A0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600035D")]
			[Cpp2IlInjected.Address(RVA = "0x8344820", Offset = "0x8342E20", VA = "0x188344820", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600035F")]
			[Cpp2IlInjected.Address(RVA = "0x8344770", Offset = "0x8342D70", VA = "0x188344770", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<SkinnedMeshRenderer> IEnumerable<SkinnedMeshRenderer>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000360")]
			[Cpp2IlInjected.Address(RVA = "0x8344770", Offset = "0x8342D70", VA = "0x188344770", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000068")]
		[CompilerGenerated]
		private sealed class ICPABKAKLNP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003FC")]
			public PlayerAvatarDisplayBase display;

			[Cpp2IlInjected.Token(Token = "0x6000361")]
			[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
			public ICPABKAKLNP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000362")]
			[Cpp2IlInjected.Address(RVA = "0x8343CF0", Offset = "0x83422F0", VA = "0x188343CF0")]
			internal bool ONFFDIMOJNA()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000069")]
		[CompilerGenerated]
		private sealed class GAEDIEKBBOC : IEnumerator<KAIBAKBEOHB>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003FD")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003FE")]
			private KAIBAKBEOHB <>2__current;

			[Cpp2IlInjected.Token(Token = "0x1700009F")]
			private KAIBAKBEOHB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000366")]
				[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000A0")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000368")]
				[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000363")]
			[Cpp2IlInjected.Address(RVA = "0xAA5480", Offset = "0xAA3A80", VA = "0x180AA5480")]
			[DebuggerHidden]
			public GAEDIEKBBOC(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000364")]
			[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000365")]
			[Cpp2IlInjected.Address(RVA = "0x83434F0", Offset = "0x8341AF0", VA = "0x1883434F0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000367")]
			[Cpp2IlInjected.Address(RVA = "0x8343840", Offset = "0x8341E40", VA = "0x188343840", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200006A")]
		[CompilerGenerated]
		private struct FIPEFGBPCCE : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003FF")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000400")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000401")]
			public PlayerAvatarDisplayBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000402")]
			public HBDFLCGDPFO avatarData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000403")]
			private bool <forceRebuild>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000404")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000369")]
			[Cpp2IlInjected.Address(RVA = "0x8341820", Offset = "0x833FE20", VA = "0x188341820", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600036A")]
			[Cpp2IlInjected.Address(RVA = "0x8341BC0", Offset = "0x83401C0", VA = "0x188341BC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006B")]
		[CompilerGenerated]
		private sealed class ELCEDPFGLBM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000405")]
			public string overrideIdentifier;

			[Cpp2IlInjected.Token(Token = "0x600036B")]
			[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
			public ELCEDPFGLBM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600036C")]
			[Cpp2IlInjected.Address(RVA = "0x1576730", Offset = "0x1574D30", VA = "0x181576730")]
			internal bool NFDJPLEPKID(HODKDMLKKBH selection)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006C")]
		[CompilerGenerated]
		private sealed class OEHGMCFLICA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000406")]
			public PlayerAvatarDisplayBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000407")]
			public AvatarItemBodyType avatarItemBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000408")]
			public Func<EEOEHGFNDGC<Dictionary<string, OFBDOHFHPFI<Texture2D>>>> <>9__2;

			[Cpp2IlInjected.Token(Token = "0x600036D")]
			[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
			public OEHGMCFLICA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600036E")]
			[Cpp2IlInjected.Address(RVA = "0x8344B80", Offset = "0x8343180", VA = "0x188344B80")]
			internal (PKCNIKPNNOM, EEOEHGFNDGC<Dictionary<string, OFBDOHFHPFI<Texture2D>>>) EKBALNGCOBJ(Dictionary<string, BPGFEBKMGNH> avatarItems)
			{
				return default((PKCNIKPNNOM, EEOEHGFNDGC<Dictionary<string, OFBDOHFHPFI<Texture2D>>>));
			}

			[Cpp2IlInjected.Token(Token = "0x600036F")]
			[Cpp2IlInjected.Address(RVA = "0x8344B10", Offset = "0x8343110", VA = "0x188344B10")]
			internal EEOEHGFNDGC<Dictionary<string, OFBDOHFHPFI<Texture2D>>> BAKLHEHNBFD()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000370")]
			[Cpp2IlInjected.Address(RVA = "0x8344D80", Offset = "0x8343380", VA = "0x188344D80")]
			internal void PGJAPMDJKGK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006D")]
		[CompilerGenerated]
		private sealed class DCAIMCMNHHC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000409")]
			public Transform transformToCheck;

			[Cpp2IlInjected.Token(Token = "0x6000371")]
			[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
			public DCAIMCMNHHC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000372")]
			[Cpp2IlInjected.Address(RVA = "0x833DE70", Offset = "0x833C470", VA = "0x18833DE70")]
			internal bool PHAPEGIHMAB(SkinnedMeshRenderer x)
			{
				return default(bool);
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200006E")]
		[CompilerGenerated]
		private struct LKOMKCKBGIN : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400040A")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400040B")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400040C")]
			public PlayerAvatarDisplayBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400040D")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000373")]
			[Cpp2IlInjected.Address(RVA = "0x8344260", Offset = "0x8342860", VA = "0x188344260", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000374")]
			[Cpp2IlInjected.Address(RVA = "0x8344540", Offset = "0x8342B40", VA = "0x188344540", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		protected static readonly int DHNAAPOHNPG;

		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		protected static readonly int CEGLANPFJCC;

		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		protected static readonly int HAHKEACLLPM;

		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		protected static readonly int LMKNOOPLONA;

		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		protected static readonly int DKAGGCEHJDL;

		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		protected static readonly int NEBECPAIIIN;

		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		protected static readonly int[] PPCKGFLJMMB;

		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		protected static readonly int[] PDGBADCACAN;

		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		protected static readonly int[] CNDHMHADNJO;

		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		protected static readonly int[] IBFMNFECEAM;

		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		protected static readonly int[] FJJABAKEHFJ;

		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		protected static readonly int[] JDIIEKCBKJD;

		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		protected static List<PlayerAvatarDisplayBase> CMDPKIJBFPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		protected INLNEMFBLHB JIGFBDHNCPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		protected bool KCJHENGGFOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA5")]
		[Cpp2IlInjected.Token(Token = "0x4000300")]
		protected bool BALONDGKHME;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000301")]
		[SerializeField]
		public AvatarBodyShapeVault BodyShapeVault;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000302")]
		[SerializeField]
		public AvatarFaceShapeVault FaceShapeVault;

		[Cpp2IlInjected.Token(Token = "0x4000303")]
		protected static readonly int[] DFOCAILDMJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		[SerializeField]
		protected Material bodyPartMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		protected Dictionary<GCFLMGHLGCI, Material> OBGIJLGNKLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		protected Dictionary<GCFLMGHLGCI, Material> CDPJMPCAMDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		[SerializeField]
		protected bool ignorePlayerMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000309")]
		[SerializeField]
		protected Transform trackingSpace;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400030A")]
		[SerializeField]
		protected BodyPartLODs Head;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400030B")]
		[SerializeField]
		protected BodyPartLODs Ear;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400030C")]
		[SerializeField]
		protected BodyPartLODs Torso;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x400030D")]
		[SerializeField]
		protected BodyPartLODs Hand;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x400030E")]
		[SerializeField]
		protected BodyPartLODs HandPointing;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x400030F")]
		[SerializeField]
		public PlayerHandBones HandBones;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4000310")]
		[SerializeField]
		public Transform remoteMeshBase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4000311")]
		[SerializeField]
		public Transform firstPersonMeshBase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4000312")]
		[SerializeField]
		protected Shader uberShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x4000313")]
		[SerializeField]
		protected Shader agAvatarShader;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x4000314")]
		protected Material DDPFEGPFAPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x4000315")]
		private GDGKEFFDPOH PPJFIDMGLNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		private GDGKEFFDPOH AHOAKKEGICN;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x4000317")]
		protected Material NNELGKPFDPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x4000318")]
		[SerializeField]
		protected Transform headPropAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x4000319")]
		[SerializeField]
		protected Transform hatAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x400031A")]
		[SerializeField]
		public Transform hemisphereBase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x400031B")]
		protected FitMeshHemisphere OKIDPEHFMKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x400031C")]
		protected bool DKHIKHBJLAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x400031D")]
		protected FKKFOGDLKNE GHHFNJBAHNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x400031E")]
		protected bool CODHHFNKABO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x400031F")]
		protected AnchorParamsRestrictions ALFMAJAHBLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x4000320")]
		protected bool NBBKKPHMECD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x4000321")]
		protected Transform FFPFHFAALBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x4000322")]
		protected bool LDOFCJCKKLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E9")]
		[Cpp2IlInjected.Token(Token = "0x4000323")]
		protected bool DMCFELIENMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1EC")]
		[Cpp2IlInjected.Token(Token = "0x4000324")]
		protected Vector3 BDBANGDOACC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
		[Cpp2IlInjected.Token(Token = "0x4000325")]
		protected Quaternion BFOJDKCIHEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
		[Cpp2IlInjected.Token(Token = "0x4000326")]
		protected Vector2 GBFLAHBFBNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
		[Cpp2IlInjected.Token(Token = "0x4000327")]
		protected FitMeshHemisphere JNDNIBKEEEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
		[Cpp2IlInjected.Token(Token = "0x4000328")]
		[OOBMCMDIFDG(GJFENOMGFMJ.SelfAndChildren, false, false, false)]
		[SerializeField]
		protected PlayerFacialAnimatorBase facialAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
		[Cpp2IlInjected.Token(Token = "0x4000329")]
		[SerializeField]
		protected Transform torsoPropAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
		[Cpp2IlInjected.Token(Token = "0x400032A")]
		[SerializeField]
		protected Transform torsoRootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
		[Cpp2IlInjected.Token(Token = "0x400032B")]
		[SerializeField]
		protected Transform headRootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
		[Cpp2IlInjected.Token(Token = "0x400032C")]
		[SerializeField]
		protected Transform leftHandRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
		[Cpp2IlInjected.Token(Token = "0x400032D")]
		[SerializeField]
		protected Transform leftHandDefaultScaleRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
		[Cpp2IlInjected.Token(Token = "0x400032E")]
		[SerializeField]
		protected Transform rightHandRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
		[Cpp2IlInjected.Token(Token = "0x400032F")]
		[SerializeField]
		protected Transform rightHandDefaultScaleRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
		[Cpp2IlInjected.Token(Token = "0x4000330")]
		[SerializeField]
		protected Animator leftHandAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x4000331")]
		[SerializeField]
		protected Animator rightHandAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
		[Cpp2IlInjected.Token(Token = "0x4000332")]
		[SerializeField]
		protected Transform leftHandPointingRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
		[Cpp2IlInjected.Token(Token = "0x4000333")]
		[SerializeField]
		protected Transform rightHandPointingRoot;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x4000334")]
		protected Collider[] KPKBPEKHJLC;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
		[Cpp2IlInjected.Token(Token = "0x4000335")]
		protected Collider[] MOKHOKHGJNC;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
		[Cpp2IlInjected.Token(Token = "0x4000336")]
		protected FJFHBAFPHLO[] ELHJJFNOLEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
		[Cpp2IlInjected.Token(Token = "0x4000337")]
		[SerializeField]
		protected Mesh faceMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
		[Cpp2IlInjected.Token(Token = "0x4000338")]
		public Dictionary<Renderer, EEIIADDAJMP> currentPropertyBlocks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
		[Cpp2IlInjected.Token(Token = "0x4000339")]
		protected Dictionary<Renderer, EEIIADDAJMP> CFAPKGBMHFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
		[Cpp2IlInjected.Token(Token = "0x400033A")]
		protected ANFPJNHPPAP HPGOMEPOIIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B0")]
		[Cpp2IlInjected.Token(Token = "0x400033B")]
		protected JKOPAHCCABD<AIMIDGCLOIF> ELBMJPMLHBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B8")]
		[Cpp2IlInjected.Token(Token = "0x400033C")]
		protected bool MCBKNFAJDKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C0")]
		[Cpp2IlInjected.Token(Token = "0x400033E")]
		protected Dictionary<HODKDMLKKBH, List<GCFLMGHLGCI>> INNFAGJNFBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
		[Cpp2IlInjected.Token(Token = "0x400033F")]
		protected Dictionary<HODKDMLKKBH, List<GCFLMGHLGCI>> NOANPLPDADO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D0")]
		[Cpp2IlInjected.Token(Token = "0x4000340")]
		protected readonly Dictionary<string, OFBDOHFHPFI<Texture2D>> JNHMJMAILBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D8")]
		[Cpp2IlInjected.Token(Token = "0x4000341")]
		protected readonly Dictionary<string, OFBDOHFHPFI<Texture2D>> FELFIGKDBOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E0")]
		[Cpp2IlInjected.Token(Token = "0x4000342")]
		protected bool DGHEKHGDOPK;

		[Cpp2IlInjected.Token(Token = "0x4000344")]
		protected static int OIFOIGFHDOD;

		[Cpp2IlInjected.Token(Token = "0x4000345")]
		protected static List<NOHPIMMAGAI> JCGOJEBMLPF;

		[Cpp2IlInjected.Token(Token = "0x4000346")]
		protected static List<NOHPIMMAGAI> EMBGNKFBNDN;

		[Cpp2IlInjected.Token(Token = "0x4000347")]
		protected static FAKIPBKLGEB CPGDCPKLLCP;

		[Cpp2IlInjected.Token(Token = "0x4000348")]
		protected static Func<List<NOHPIMMAGAI>, NOHPIMMAGAI> JONCDKAABKC;

		[Cpp2IlInjected.Token(Token = "0x4000349")]
		protected static bool FGBEIBDFFJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2F0")]
		[Cpp2IlInjected.Token(Token = "0x400034A")]
		protected Color? JMPEGAMANFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x304")]
		[Cpp2IlInjected.Token(Token = "0x400034B")]
		protected bool FLKIEJDBFLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x308")]
		[Cpp2IlInjected.Token(Token = "0x400034C")]
		protected Color CJLLICADOKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x318")]
		[Cpp2IlInjected.Token(Token = "0x400034D")]
		protected Color HCHHOPNGHKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x328")]
		[Cpp2IlInjected.Token(Token = "0x400034E")]
		protected Color DMPLBBCPCOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x338")]
		[Cpp2IlInjected.Token(Token = "0x400034F")]
		protected AvatarHairPattern PLLGEHNCCME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x340")]
		[Cpp2IlInjected.Token(Token = "0x4000350")]
		protected AONMEGFPBGH ALPCHPMMACO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x348")]
		[Cpp2IlInjected.Token(Token = "0x4000351")]
		protected Color DPKGDJBAHDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x358")]
		[Cpp2IlInjected.Token(Token = "0x4000352")]
		protected Color CHGJFEHAAAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x368")]
		[Cpp2IlInjected.Token(Token = "0x4000353")]
		protected AvatarHairPattern MDBLIDNDJHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x370")]
		[Cpp2IlInjected.Token(Token = "0x4000354")]
		protected AONMEGFPBGH LJGFAIPGLPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x378")]
		[Cpp2IlInjected.Token(Token = "0x4000355")]
		protected AONMEGFPBGH KHMKDCKECOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x380")]
		[Cpp2IlInjected.Token(Token = "0x4000356")]
		protected Color KDDDIFCEGJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x390")]
		[Cpp2IlInjected.Token(Token = "0x4000357")]
		private AdditionalFeetData GFMFCBCJLHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x398")]
		[Cpp2IlInjected.Token(Token = "0x4000358")]
		protected HODKDMLKKBH? CLMCCJMNIKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3B0")]
		[Cpp2IlInjected.Token(Token = "0x4000359")]
		protected Texture FACGMOPIPCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3B8")]
		[Cpp2IlInjected.Token(Token = "0x400035A")]
		protected Color EFCCDIPOKIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C8")]
		[Cpp2IlInjected.Token(Token = "0x400035B")]
		protected readonly IList<HODKDMLKKBH> BKAPKKHIMAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D0")]
		[Cpp2IlInjected.Token(Token = "0x400035C")]
		protected readonly IList<HODKDMLKKBH> BKICOFEAKFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D8")]
		[Cpp2IlInjected.Token(Token = "0x400035D")]
		private AvatarItemBodyType HHELEBJJIKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3E0")]
		[Cpp2IlInjected.Token(Token = "0x400035E")]
		[SerializeField]
		protected AvatarFaceShape _currentFaceShape;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3E8")]
		[Cpp2IlInjected.Token(Token = "0x400035F")]
		[SerializeField]
		protected AvatarBodyShape _currentBodyShape;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3F0")]
		[Cpp2IlInjected.Token(Token = "0x4000360")]
		[SerializeField]
		protected FHGFAGJLMJA _currentNoseType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3F4")]
		[Cpp2IlInjected.Token(Token = "0x4000361")]
		[SerializeField]
		protected bool _hideEars;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3F5")]
		[Cpp2IlInjected.Token(Token = "0x4000362")]
		protected bool PFIKIDDENFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3F8")]
		[Cpp2IlInjected.Token(Token = "0x4000363")]
		protected int[] AKGODFOMOAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x400")]
		[Cpp2IlInjected.Token(Token = "0x4000364")]
		protected bool HAAJEHONBEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x401")]
		[Cpp2IlInjected.Token(Token = "0x4000365")]
		protected bool DIJAHIIABOL;

		[Cpp2IlInjected.Token(Token = "0x4000366")]
		private static readonly EDHDPNHKKLO.IBJCDOEDFHO GGBJCCGOANF;

		[Cpp2IlInjected.Token(Token = "0x4000367")]
		private static readonly EDHDPNHKKLO.IBJCDOEDFHO NACDCICDCFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x402")]
		[Cpp2IlInjected.Token(Token = "0x4000368")]
		protected bool PDKECJMGFEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x408")]
		[Cpp2IlInjected.Token(Token = "0x4000369")]
		protected BOMGODHADIP MDFACHGJANM;

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public string JNCIFNPDLJK
		{
			[Cpp2IlInjected.Token(Token = "0x600024E")]
			[Cpp2IlInjected.Address(RVA = "0xAB0450", Offset = "0xAAEA50", VA = "0x180AB0450")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600024F")]
			[Cpp2IlInjected.Address(RVA = "0xAB0480", Offset = "0xAAEA80", VA = "0x180AB0480")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public bool ICNGPLADKOB
		{
			[Cpp2IlInjected.Token(Token = "0x6000251")]
			[Cpp2IlInjected.Address(RVA = "0xE20620", Offset = "0xE1EC20", VA = "0x180E20620")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000252")]
			[Cpp2IlInjected.Address(RVA = "0xE1EB40", Offset = "0xE1D140", VA = "0x180E1EB40")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public virtual bool BJGDCPPABLN
		{
			[Cpp2IlInjected.Token(Token = "0x6000253")]
			[Cpp2IlInjected.Address(RVA = "0xAF14E0", Offset = "0xAEFAE0", VA = "0x180AF14E0", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public bool IKCCAPIGEAF
		{
			[Cpp2IlInjected.Token(Token = "0x6000254")]
			[Cpp2IlInjected.Address(RVA = "0x8352D70", Offset = "0x8351370", VA = "0x188352D70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public virtual bool BNGCDFJDCLO
		{
			[Cpp2IlInjected.Token(Token = "0x6000255")]
			[Cpp2IlInjected.Address(RVA = "0xAC1E50", Offset = "0xAC0450", VA = "0x180AC1E50", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public virtual bool OIFKAMDNIHH
		{
			[Cpp2IlInjected.Token(Token = "0x6000256")]
			[Cpp2IlInjected.Address(RVA = "0xAF14E0", Offset = "0xAEFAE0", VA = "0x180AF14E0", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public virtual bool EOKPPIBBJCO
		{
			[Cpp2IlInjected.Token(Token = "0x6000257")]
			[Cpp2IlInjected.Address(RVA = "0xAF14E0", Offset = "0xAEFAE0", VA = "0x180AF14E0", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public GDGKEFFDPOH HNDCHFIGPGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000259")]
			[Cpp2IlInjected.Address(RVA = "0xC1BAC0", Offset = "0xC1A0C0", VA = "0x180C1BAC0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600025A")]
			[Cpp2IlInjected.Address(RVA = "0x83534E0", Offset = "0x8351AE0", VA = "0x1883534E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public GDGKEFFDPOH OJFIAGIEMEE
		{
			[Cpp2IlInjected.Token(Token = "0x600025B")]
			[Cpp2IlInjected.Address(RVA = "0xC351E0", Offset = "0xC337E0", VA = "0x180C351E0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600025C")]
			[Cpp2IlInjected.Address(RVA = "0x8353790", Offset = "0x8351D90", VA = "0x188353790")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		protected Material MDHAIMNJMDB
		{
			[Cpp2IlInjected.Token(Token = "0x600025D")]
			[Cpp2IlInjected.Address(RVA = "0x834C9D0", Offset = "0x834AFD0", VA = "0x18834C9D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		protected Material JEAFGHPPGIA
		{
			[Cpp2IlInjected.Token(Token = "0x600025E")]
			[Cpp2IlInjected.Address(RVA = "0x8349A20", Offset = "0x8348020", VA = "0x188349A20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public bool AANKDJOPMDE
		{
			[Cpp2IlInjected.Token(Token = "0x600025F")]
			[Cpp2IlInjected.Address(RVA = "0xB80E20", Offset = "0xB7F420", VA = "0x180B80E20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public PlayerFacialAnimatorBase NCEFLJOIDAJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000263")]
			[Cpp2IlInjected.Address(RVA = "0xC3B040", Offset = "0xC39640", VA = "0x180C3B040")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public FJFHBAFPHLO[] FMMFIBLJCEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000264")]
			[Cpp2IlInjected.Address(RVA = "0x83528F0", Offset = "0x8350EF0", VA = "0x1883528F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public FJFHBAFPHLO JFEMEOCLMJN
		{
			[Cpp2IlInjected.Token(Token = "0x6000265")]
			[Cpp2IlInjected.Address(RVA = "0x8352F60", Offset = "0x8351560", VA = "0x188352F60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public FJFHBAFPHLO OGPFDEDGFGG
		{
			[Cpp2IlInjected.Token(Token = "0x6000266")]
			[Cpp2IlInjected.Address(RVA = "0x8352F90", Offset = "0x8351590", VA = "0x188352F90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public Mesh GFAEPFMBPDG
		{
			[Cpp2IlInjected.Token(Token = "0x6000267")]
			[Cpp2IlInjected.Address(RVA = "0xC3BAA0", Offset = "0xC3A0A0", VA = "0x180C3BAA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		protected ANFPJNHPPAP IAOCJIDEADB
		{
			[Cpp2IlInjected.Token(Token = "0x6000268")]
			[Cpp2IlInjected.Address(RVA = "0x834A970", Offset = "0x8348F70", VA = "0x18834A970")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		protected bool HPOKPHCIOOB
		{
			[Cpp2IlInjected.Token(Token = "0x6000269")]
			[Cpp2IlInjected.Address(RVA = "0xAC1E50", Offset = "0xAC0450", VA = "0x180AC1E50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public override int MNGOHBAJIOG
		{
			[Cpp2IlInjected.Token(Token = "0x600026A")]
			[Cpp2IlInjected.Address(RVA = "0xAC5010", Offset = "0xAC3610", VA = "0x180AC5010", Slot = "6")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600026B")]
			[Cpp2IlInjected.Address(RVA = "0x83536F0", Offset = "0x8351CF0", VA = "0x1883536F0", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		protected virtual bool KCEBACELNMG
		{
			[Cpp2IlInjected.Token(Token = "0x600026C")]
			[Cpp2IlInjected.Address(RVA = "0xAF14E0", Offset = "0xAEFAE0", VA = "0x180AF14E0", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		protected virtual int[] GIKHHBJJOOK
		{
			[Cpp2IlInjected.Token(Token = "0x600026D")]
			[Cpp2IlInjected.Address(RVA = "0x834AB50", Offset = "0x8349150", VA = "0x18834AB50", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		protected bool MILIKHGEJKN
		{
			[Cpp2IlInjected.Token(Token = "0x600026E")]
			[Cpp2IlInjected.Address(RVA = "0x8349D60", Offset = "0x8348360", VA = "0x188349D60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		protected static bool GJOBEFEOAMA
		{
			[Cpp2IlInjected.Token(Token = "0x600026F")]
			[Cpp2IlInjected.Address(RVA = "0xAF14E0", Offset = "0xAEFAE0", VA = "0x180AF14E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public bool LGJNJOPHHMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000270")]
			[Cpp2IlInjected.Address(RVA = "0x8352FC0", Offset = "0x83515C0", VA = "0x188352FC0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000271")]
			[Cpp2IlInjected.Address(RVA = "0x83539A0", Offset = "0x8351FA0", VA = "0x1883539A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public IEnumerable<SkinnedMeshRenderer> ALMDKKDPOKA
		{
			[Cpp2IlInjected.Token(Token = "0x6000272")]
			[Cpp2IlInjected.Address(RVA = "0x83527D0", Offset = "0x8350DD0", VA = "0x1883527D0")]
			[IteratorStateMachine(typeof(NMAKHMCHNHM))]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		public bool NMKMFLCMAEH
		{
			[Cpp2IlInjected.Token(Token = "0x6000273")]
			[Cpp2IlInjected.Address(RVA = "0x8352F50", Offset = "0x8351550", VA = "0x188352F50")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000274")]
			[Cpp2IlInjected.Address(RVA = "0x8345DF0", Offset = "0x83443F0", VA = "0x188345DF0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		public new static bool ALMDNPJMJJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000292")]
			[Cpp2IlInjected.Address(RVA = "0x8352CA0", Offset = "0x83512A0", VA = "0x188352CA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		protected static FAKIPBKLGEB EGLBAMOOCMN
		{
			[Cpp2IlInjected.Token(Token = "0x6000293")]
			[Cpp2IlInjected.Address(RVA = "0x83495E0", Offset = "0x8347BE0", VA = "0x1883495E0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000294")]
			[Cpp2IlInjected.Address(RVA = "0x834DB20", Offset = "0x834C120", VA = "0x18834DB20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		protected Color MHIKDLAHNEA
		{
			[Cpp2IlInjected.Token(Token = "0x60002AE")]
			[Cpp2IlInjected.Address(RVA = "0x8349E30", Offset = "0x8348430", VA = "0x188349E30")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		protected Color HNKCGLFNNOI
		{
			[Cpp2IlInjected.Token(Token = "0x60002AF")]
			[Cpp2IlInjected.Address(RVA = "0x8348E60", Offset = "0x8347460", VA = "0x188348E60")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		protected Texture2D OFLAKDEOHDC
		{
			[Cpp2IlInjected.Token(Token = "0x60002B0")]
			[Cpp2IlInjected.Address(RVA = "0x834BD30", Offset = "0x834A330", VA = "0x18834BD30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		public Color DDNEMGACOII
		{
			[Cpp2IlInjected.Token(Token = "0x60002B6")]
			[Cpp2IlInjected.Address(RVA = "0x83528A0", Offset = "0x8350EA0", VA = "0x1883528A0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		protected Color EMCGFGCFBNJ
		{
			[Cpp2IlInjected.Token(Token = "0x60002B7")]
			[Cpp2IlInjected.Address(RVA = "0x834C980", Offset = "0x834AF80", VA = "0x18834C980")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		public AONMEGFPBGH HAJOCBIHEBG
		{
			[Cpp2IlInjected.Token(Token = "0x60002B8")]
			[Cpp2IlInjected.Address(RVA = "0x8352860", Offset = "0x8350E60", VA = "0x188352860")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		protected Texture2D IIJHDOGBBCB
		{
			[Cpp2IlInjected.Token(Token = "0x60002B9")]
			[Cpp2IlInjected.Address(RVA = "0x834AE10", Offset = "0x8349410", VA = "0x18834AE10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		public float CJBEGAOAHEK
		{
			[Cpp2IlInjected.Token(Token = "0x60002C0")]
			[Cpp2IlInjected.Address(RVA = "0x8352880", Offset = "0x8350E80", VA = "0x188352880")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		public float CKIAMEKOAML
		{
			[Cpp2IlInjected.Token(Token = "0x60002C1")]
			[Cpp2IlInjected.Address(RVA = "0x8352D50", Offset = "0x8351350", VA = "0x188352D50")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		public bool IPIPCDNPICO
		{
			[Cpp2IlInjected.Token(Token = "0x60002F3")]
			[Cpp2IlInjected.Address(RVA = "0x8352850", Offset = "0x8350E50", VA = "0x188352850")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002F4")]
			[Cpp2IlInjected.Address(RVA = "0x83532A0", Offset = "0x83518A0", VA = "0x1883532A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action IPDNCNCDFKB
		{
			[Cpp2IlInjected.Token(Token = "0x6000248")]
			[Cpp2IlInjected.Address(RVA = "0x8352500", Offset = "0x8350B00", VA = "0x188352500")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000249")]
			[Cpp2IlInjected.Address(RVA = "0x8352FD0", Offset = "0x83515D0", VA = "0x188352FD0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action KOGOKOICHEO
		{
			[Cpp2IlInjected.Token(Token = "0x600024A")]
			[Cpp2IlInjected.Address(RVA = "0x83525B0", Offset = "0x8350BB0", VA = "0x1883525B0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0x8353080", Offset = "0x8351680", VA = "0x188353080")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action KGJIDFDBNIK
		{
			[Cpp2IlInjected.Token(Token = "0x600024C")]
			[Cpp2IlInjected.Address(RVA = "0x8352660", Offset = "0x8350C60", VA = "0x188352660")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600024D")]
			[Cpp2IlInjected.Address(RVA = "0x8353130", Offset = "0x8351730", VA = "0x188353130")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<JKDJCOOGOJL, ALNHBAFPCMB> NNDCBHPOODG
		{
			[Cpp2IlInjected.Token(Token = "0x6000286")]
			[Cpp2IlInjected.Address(RVA = "0x8352710", Offset = "0x8350D10", VA = "0x188352710")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000287")]
			[Cpp2IlInjected.Address(RVA = "0x83531E0", Offset = "0x83517E0", VA = "0x1883531E0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x834E9F0", Offset = "0x834CFF0", VA = "0x18834E9F0")]
		public bool SetDeformation(bool KCJHENGGFOA, bool BALONDGKHME)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x8349C10", Offset = "0x8348210", VA = "0x188349C10")]
		protected static Material FFLILKFGEOB(Dictionary<GCFLMGHLGCI, Material> GIDEFKLBAOM, Material ILAHFGDDGLI, KAMFIAAGGBP KABLBJCDPCG, KPFMJGHNFJH MLLLJAGOJFM, APMGGBJHHPH HODHODILEKM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x834C860", Offset = "0x834AE60", VA = "0x18834C860")]
		protected void NNJAIKCLCOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x83491C0", Offset = "0x83477C0", VA = "0x1883491C0")]
		protected bool DKHGLKCOKDB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x834C0C0", Offset = "0x834A6C0", VA = "0x18834C0C0")]
		protected void MFJIJDEMOEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x834D310", Offset = "0x834B910", VA = "0x18834D310")]
		protected static void PDAOIEHPMHC(Dictionary<HODKDMLKKBH, List<GCFLMGHLGCI>> PLDHKFPNKBN, PLKBMGKOFGP OGMEKLELBIH, Material ILAHFGDDGLI, KAMFIAAGGBP NJNDMFEOFPN, KPFMJGHNFJH BIPAANANOIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x8345B50", Offset = "0x8344150", VA = "0x188345B50")]
		protected void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x834C150", Offset = "0x834A750", VA = "0x18834C150")]
		protected void MHFINAAFIEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x834D070", Offset = "0x834B670", VA = "0x18834D070")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "19")]
		protected virtual void EMHEDKIKKJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x834A430", Offset = "0x8348A30", VA = "0x18834A430")]
		protected static void HBGHNDFIDNJ(List<Material> NLKJANMAKHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x834A7F0", Offset = "0x8348DF0", VA = "0x18834A7F0")]
		protected static void HDKEIILKMGO(Dictionary<GCFLMGHLGCI, Material> GIDEFKLBAOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x8348310", Offset = "0x8346910", VA = "0x188348310")]
		protected static void CKHKDHIKHNM(Dictionary<Renderer, EEIIADDAJMP> MNNGCOFMJLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x8348F50", Offset = "0x8347550", VA = "0x188348F50")]
		protected void DHDGFMFHKLK(SkinnedMeshRenderer[] GGHAEDDHNJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x834A990", Offset = "0x8348F90", VA = "0x18834A990")]
		protected void HPCLHKGIOGG(SkinnedMeshRenderer NNCHINPECMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x834AA30", Offset = "0x8349030", VA = "0x18834AA30")]
		protected void HPCLHKGIOGG(MeshRenderer CPBJOPKEKBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x8346380", Offset = "0x8344980", VA = "0x188346380")]
		protected void BKONPJNGOIH(List<LPJMHNKFBLM> FNNPDHDBGAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x834BA60", Offset = "0x834A060", VA = "0x18834BA60")]
		protected void KJGECCENHMA(Dictionary<string, OFBDOHFHPFI<Texture2D>> PLDHKFPNKBN, bool HPDPFLAHABA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x8347F00", Offset = "0x8346500", VA = "0x188347F00")]
		protected void CHOJDEFPLHB(Dictionary<HODKDMLKKBH, List<GCFLMGHLGCI>> PLDHKFPNKBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x834A300", Offset = "0x8348900", VA = "0x18834A300")]
		public float GetHandOpenClosedAxis(JKDJCOOGOJL DHCBIDEGLHB)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x834F290", Offset = "0x834D890", VA = "0x18834F290")]
		public void SetHandOpenClosedAxis(JKDJCOOGOJL DHCBIDEGLHB, float AIKEDGOAINM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x834A340", Offset = "0x8348940", VA = "0x18834A340")]
		public ALNHBAFPCMB GetHandVisualState(JKDJCOOGOJL DHCBIDEGLHB)
		{
			return default(ALNHBAFPCMB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x83451C0", Offset = "0x83437C0", VA = "0x1883451C0")]
		public bool AddHandVisualStateToken(JKDJCOOGOJL DHCBIDEGLHB, ALNHBAFPCMB PGANGDJCAML, object INEEADCBMPK, FJFHBAFPHLO.NPJNAPECDOM EOENKBEJCMN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x8350DD0", Offset = "0x834F3D0", VA = "0x188350DD0")]
		public void SetWatchHand(JKDJCOOGOJL DHCBIDEGLHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x8350E90", Offset = "0x834F490", VA = "0x188350E90")]
		public void SetWatchHands(bool KJAGEIIHMFI, bool ECIMKOMLHKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x834DFC0", Offset = "0x834C5C0", VA = "0x18834DFC0")]
		public bool RemoveHandVisualStateToken(JKDJCOOGOJL DHCBIDEGLHB, object INEEADCBMPK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x834A3F0", Offset = "0x83489F0", VA = "0x18834A3F0")]
		public bool GetThumbsUpActive(JKDJCOOGOJL DHCBIDEGLHB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x8350730", Offset = "0x834ED30", VA = "0x188350730")]
		public void SetThumbsUpActive(JKDJCOOGOJL DHCBIDEGLHB, bool IKOCHLPNEHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x834A3B0", Offset = "0x83489B0", VA = "0x18834A3B0")]
		public bool GetHandshakeActive(JKDJCOOGOJL DHCBIDEGLHB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x834F400", Offset = "0x834DA00", VA = "0x18834F400")]
		public void SetHandshakeActive(JKDJCOOGOJL DHCBIDEGLHB, bool DPIDONGNBMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x8349DE0", Offset = "0x83483E0", VA = "0x188349DE0")]
		public void ForceUpdateHandsVisualState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x8350CC0", Offset = "0x834F2C0", VA = "0x188350CC0")]
		public void SetUseClassicBeanHandScale(bool KOPHBHGIACG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x8348C70", Offset = "0x8347270", VA = "0x188348C70")]
		public static void ClearQueuedBuilds()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x8348540", Offset = "0x8346B40", VA = "0x188348540")]
		private static void CNCLCANGOED(Scene BLFJNFOGIPN, LoadSceneMode IBLGEJEKAPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x8349B10", Offset = "0x8348110", VA = "0x188349B10")]
		protected static void FCNOGAKFIFE(PlayerAvatarDisplayBase MMCMGJHCBNK, List<NOHPIMMAGAI> INMFHOODJJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x834DCF0", Offset = "0x834C2F0", VA = "0x18834DCF0")]
		public FBCJGBABFLH Rebuild()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x834C460", Offset = "0x834AA60", VA = "0x18834C460")]
		protected FBCJGBABFLH MJNJIEFCMOI(bool BGEHLJIJIIB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x834C4C0", Offset = "0x834AAC0", VA = "0x18834C4C0", Slot = "20")]
		protected virtual FBCJGBABFLH MJNJIEFCMOI(IList<HODKDMLKKBH> LCHCIKNPANL, AvatarItemBodyType IBKFAEDAFDO, bool DOCIKBFPHOO, bool PBEBBJBCPOA, int[] DAOJLCEOKNP, bool BGEHLJIJIIB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x8346560", Offset = "0x8344B60", VA = "0x188346560")]
		protected static FBCJGBABFLH BLKFBLAECCM(NOHPIMMAGAI MAKOEMFAGLA, List<NOHPIMMAGAI> INMFHOODJJI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x8347E10", Offset = "0x8346410", VA = "0x188347E10")]
		[IteratorStateMachine(typeof(GAEDIEKBBOC))]
		protected static IEnumerator<KAIBAKBEOHB> CELAFKBJBJD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x834B480", Offset = "0x8349A80", VA = "0x18834B480")]
		protected static NOHPIMMAGAI JOCFCEKJEIJ(List<NOHPIMMAGAI> INMFHOODJJI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x834EB00", Offset = "0x834D100", VA = "0x18834EB00")]
		[AsyncStateMachine(typeof(FIPEFGBPCCE))]
		public Task SetFaceCustomizationSettings(HBDFLCGDPFO CBMCGBCNLPB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x8350FF0", Offset = "0x834F5F0", VA = "0x188350FF0")]
		public bool UpdateFaceAndBodyCustomizationSettings(HBDFLCGDPFO CBMCGBCNLPB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x834AF10", Offset = "0x8349510", VA = "0x18834AF10")]
		public void InitializeFaceFeatures(AvatarConfiguration MJDEHMHOFAC, KHBAENPMODP INLGMINCMAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x8350490", Offset = "0x834EA90", VA = "0x188350490")]
		public void SetTeamColors(Color? BCNPHJMGANA, bool GODBHIPPAFK, Color JGIIDFEEEDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x15B31B0", Offset = "0x15B17B0", VA = "0x1815B31B0")]
		private static void DFNMIKHENEJ(Material PFHPGDKJCCC, Color KOPHBHGIACG, params int[] EKKEMAPMGNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x15B4910", Offset = "0x15B2F10", VA = "0x1815B4910")]
		private static void OIFFOIPPHEN(Material PFHPGDKJCCC, Texture KOPHBHGIACG, params int[] EKKEMAPMGNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x834A570", Offset = "0x8348B70", VA = "0x18834A570")]
		protected void HDBAIGNPKAM(Material HAILDBLADDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x834BE20", Offset = "0x834A420", VA = "0x18834BE20")]
		protected void MAOJHCCELLH(Material HAILDBLADDM, Color BPNJFBEHPGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x8347C20", Offset = "0x8346220", VA = "0x188347C20")]
		protected void CBOLCCMBGHG(Material HAILDBLADDM, Color BPNJFBEHPGL, Color AFPKJICMOEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x8347F50", Offset = "0x8346550", VA = "0x188347F50")]
		protected void CHOPLGCEFCH(Material HAILDBLADDM, Texture2D BDFJHOHMCFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x8345CE0", Offset = "0x83442E0", VA = "0x188345CE0")]
		protected void BBJCHLKBMNM(Material HAILDBLADDM, Texture LCKMLNOINFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x834CE70", Offset = "0x834B470", VA = "0x18834CE70")]
		protected void ONFPDNDOHGN(Action<EEIIADDAJMP> JHFAPOFONGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x834B590", Offset = "0x8349B90", VA = "0x18834B590")]
		protected void KDHEBANENGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x8345E90", Offset = "0x8344490", VA = "0x188345E90")]
		protected void BFLONJKGEJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x83496C0", Offset = "0x8347CC0", VA = "0x1883496C0")]
		protected void EPENOECMBJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x83455D0", Offset = "0x8343BD0", VA = "0x1883455D0")]
		public void ApplyUgcItemOverrides()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x834E470", Offset = "0x834CA70", VA = "0x18834E470")]
		public void SetBeardPrimaryColor([Optional] Color? JNNOMBNKELL, bool NIEGOOFKBAF = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x834E690", Offset = "0x834CC90", VA = "0x18834E690")]
		public void SetBeardSecondaryColor([Optional] Color? JNNOMBNKELL, bool NIEGOOFKBAF = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x834E340", Offset = "0x834C940", VA = "0x18834E340")]
		public void SetBeardPattern([Optional] AvatarHairPattern JAHMDEIDBOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x834CC10", Offset = "0x834B210", VA = "0x18834CC10")]
		private void OENFEBALAMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x834B2C0", Offset = "0x83498C0", VA = "0x18834B2C0")]
		private bool JDOKHCPJJCH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x834EE70", Offset = "0x834D470", VA = "0x18834EE70")]
		public void SetHairPrimaryColor([Optional] Color? GFJEDDCCJBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x834F080", Offset = "0x834D680", VA = "0x18834F080")]
		public void SetHairSecondaryColor([Optional] Color? GFJEDDCCJBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x834ED40", Offset = "0x834D340", VA = "0x18834ED40")]
		public void SetHairPattern([Optional] AvatarHairPattern JAHMDEIDBOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x834DE60", Offset = "0x834C460", VA = "0x18834DE60")]
		public void RefreshHair()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x8349E80", Offset = "0x8348480", VA = "0x188349E80")]
		private bool GKJHGJKDJOH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x83502D0", Offset = "0x834E8D0", VA = "0x1883502D0")]
		public void SetSkinColor(Color DKMPFPDNJAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x8350840", Offset = "0x834EE40", VA = "0x188350840")]
		public void SetUgcItemVisualOverrides(HODKDMLKKBH DBPGIKDEGHA, KHBAENPMODP INLGMINCMAD, Texture FOECDLFNPKC, Color DMOKLEFHBDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x8348D40", Offset = "0x8347340", VA = "0x188348D40")]
		public void ClearUgcItemVisualOverrides()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x834EC00", Offset = "0x834D200", VA = "0x18834EC00")]
		public bool SetFaceShape(AvatarFaceShape AGJLFNPCGBE, bool FLCLNLNENJL = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x834DA80", Offset = "0x834C080", VA = "0x18834DA80")]
		private void PGNEMNOMFBN(HPNDMCEAMMG BLGGOEFFIEA, float KOPHBHGIACG, bool EGBOIPKPDOL = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x8349F40", Offset = "0x8348540", VA = "0x188349F40")]
		private void GKKBCFCHHFF(AOMOKPIGOCD FIGIHAMCDCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x8348EB0", Offset = "0x83474B0", VA = "0x188348EB0")]
		private void DEGECLLGKDJ(NDGBJFEEFKP NNIDCIBEFOA, float KOPHBHGIACG, bool HPGGLOLDJDO = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x834BF40", Offset = "0x834A540", VA = "0x18834BF40")]
		private void MBKNFDJINJG(KOJCADMGFGP FLNABNLNPEE, float KOPHBHGIACG, bool OBLCONKNJFP = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x834B370", Offset = "0x8349970", VA = "0x18834B370")]
		private void JLAAOHPFNKB(MOBFGAHDHOK IAAGMOKHHHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x834C330", Offset = "0x834A930", VA = "0x18834C330")]
		private void MIBFPLFCECA(PCLDPPABHFM ABGIOFNKAJD, float PJNJBHPEBJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x834E8B0", Offset = "0x834CEB0", VA = "0x18834E8B0")]
		public bool SetBodyShape(AvatarBodyShape KOEKNECKIJG, bool FLCLNLNENJL = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x8350140", Offset = "0x834E740", VA = "0x188350140")]
		public bool SetNoseType(FHGFAGJLMJA HKICDDGHPEE, bool FLCLNLNENJL = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x8351860", Offset = "0x834FE60", VA = "0x188351860")]
		public bool UpdateFaceAndBodyShapes()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x8350120", Offset = "0x834E720", VA = "0x188350120")]
		public bool SetHideEars(bool CDFMPBEFDKN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x8350100", Offset = "0x834E700", VA = "0x188350100")]
		public bool SetHelmetHair(INLNEMFBLHB LNPHPFPHIMO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x834F510", Offset = "0x834DB10", VA = "0x18834F510")]
		public void SetHatAnchorParameters(FKKFOGDLKNE ODLOLCNOGEO, bool OLGLOELGIBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x83502B0", Offset = "0x834E8B0", VA = "0x1883502B0")]
		public bool SetShowModestyAndValidationGuidelines(bool AFOANLAPODK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x8350F60", Offset = "0x834F560", VA = "0x188350F60")]
		public void SetupDisplayLODs(IPLLKJAEHNO AAFEIHKJNHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x834B7D0", Offset = "0x8349DD0", VA = "0x18834B7D0")]
		protected int[] KEMCELOICBI(IPLLKJAEHNO AAFEIHKJNHF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x8350270", Offset = "0x834E870", VA = "0x188350270")]
		public void SetOutfitSelections(IList<HODKDMLKKBH> LCHCIKNPANL, AvatarItemBodyType IBKFAEDAFDO, bool PBEBBJBCPOA, bool BGEHLJIJIIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x8350220", Offset = "0x834E820", VA = "0x188350220")]
		public void SetOutfitSelections(IList<HODKDMLKKBH> LCHCIKNPANL, AvatarItemBodyType IBKFAEDAFDO, bool DOCIKBFPHOO, bool PBEBBJBCPOA, bool BGEHLJIJIIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x83501E0", Offset = "0x834E7E0", VA = "0x1883501E0")]
		public FBCJGBABFLH SetOutfitSelections(IList<HODKDMLKKBH> LCHCIKNPANL, AvatarItemBodyType IBKFAEDAFDO, IPLLKJAEHNO AAFEIHKJNHF, bool DOCIKBFPHOO, bool PBEBBJBCPOA, bool FLCLNLNENJL = false, bool BGEHLJIJIIB = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x834C5F0", Offset = "0x834ABF0", VA = "0x18834C5F0", Slot = "21")]
		protected virtual FBCJGBABFLH MKDFOGFNEFP(IList<HODKDMLKKBH> LCHCIKNPANL, AvatarItemBodyType IBKFAEDAFDO, bool DOCIKBFPHOO, bool PBEBBJBCPOA, IPLLKJAEHNO AAFEIHKJNHF, bool FLCLNLNENJL, bool BGEHLJIJIIB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x834A1B0", Offset = "0x83487B0", VA = "0x18834A1B0")]
		protected int[] GMLKNDHBFEH(IPLLKJAEHNO AAFEIHKJNHF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0xAA8990", Offset = "0xAA6F90", VA = "0x180AA8990", Slot = "22")]
		protected virtual PKCNIKPNNOM FGAKNIADNJD(AvatarItemBodyType OOFIPNOLEJN, Dictionary<string, BPGFEBKMGNH> HKJNOIMKCKI, Dictionary<string, OFBDOHFHPFI<Texture2D>> GNLPLOOHCHN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x834AFF0", Offset = "0x83495F0", VA = "0x18834AFF0", Slot = "23")]
		protected virtual FBCJGBABFLH JCNDAIIJCGO(IList<HODKDMLKKBH> LCHCIKNPANL, AvatarItemBodyType IBKFAEDAFDO, bool DOCIKBFPHOO, bool PBEBBJBCPOA, int[] MNCOMJENCFE, CFMMIIKBBEM DJOGLPPFGAJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x834D5D0", Offset = "0x834BBD0", VA = "0x18834D5D0", Slot = "24")]
		protected virtual BPGFEBKMGNH PEFFLOMKOOJ(AONMEGFPBGH KIEJPLFJFIG, AvatarItemBodyType OOFIPNOLEJN, APMGGBJHHPH HODHODILEKM, BPGFEBKMGNH HBLLEBMMOND)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0xAA8990", Offset = "0xAA6F90", VA = "0x180AA8990", Slot = "25")]
		protected virtual BPGFEBKMGNH DIKAACMACGL(AvatarItemBodyType OOFIPNOLEJN, APMGGBJHHPH HODHODILEKM, GJKHMDGLBLA AJLGIFGJLEI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x834B510", Offset = "0x8349B10", VA = "0x18834B510")]
		protected void KCMBJIOBCHI(CGDJPODOFHN NEMKBNMKLMO, EDHDPNHKKLO.IBJCDOEDFHO GIHIBOEKHNM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x83450B0", Offset = "0x83436B0", VA = "0x1883450B0")]
		protected void AMBILCLCJDK(CGDJPODOFHN NEMKBNMKLMO, EDHDPNHKKLO.IBJCDOEDFHO GIHIBOEKHNM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0xB0AB10", Offset = "0xB09110", VA = "0x180B0AB10", Slot = "26")]
		protected virtual CGDJPODOFHN HKMBFANINAA(CGDJPODOFHN NEMKBNMKLMO, HelmetHairStyle CPHCKOEFNGC, bool CMFIMHBJNNH, AvatarItemBodyType IBKFAEDAFDO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x8346B80", Offset = "0x8345180", VA = "0x188346B80")]
		protected CGDJPODOFHN BOOECPBFOJK(IList<HODKDMLKKBH> LCHCIKNPANL, AvatarItemBodyType GKHGIABNKPC, bool PBEBBJBCPOA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x8348B50", Offset = "0x8347150", VA = "0x188348B50")]
		public void CleanupDisplayResources()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x834C020", Offset = "0x834A620", VA = "0x18834C020")]
		protected void MBNEEMFDLHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x8346050", Offset = "0x8344650", VA = "0x188346050")]
		protected void BIOKODJOMLP(Transform OPFBDHKHHMN, IEnumerable<SkinnedMeshRenderer> OOKNCADPMCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x834A0F0", Offset = "0x83486F0", VA = "0x18834A0F0")]
		protected EDHDPNHKKLO.IBJCDOEDFHO GMIKLKDOFEK(EDHDPNHKKLO.IBJCDOEDFHO AIEPFHPGBNF, APMGGBJHHPH LDGAJCEIEAM)
		{
			return default(EDHDPNHKKLO.IBJCDOEDFHO);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x8348D90", Offset = "0x8347390", VA = "0x188348D90", Slot = "11")]
		[AsyncStateMachine(typeof(LKOMKCKBGIN))]
		public override Task CompleteBuildAsync()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x8348170", Offset = "0x8346770", VA = "0x188348170")]
		protected static KAMFIAAGGBP CIIKCDKAKKE(PLKBMGKOFGP MOMJEGOGPIN, int NBHCFOGKANE)
		{
			return default(KAMFIAAGGBP);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x834AC30", Offset = "0x8349230", VA = "0x18834AC30")]
		protected static KPFMJGHNFJH IILAJMHICGN(PLKBMGKOFGP MOMJEGOGPIN, int NBHCFOGKANE)
		{
			return default(KPFMJGHNFJH);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(RVA = "0x834A2B0", Offset = "0x83488B0", VA = "0x18834A2B0")]
		protected Transform GOAHIILDJOO(APMGGBJHHPH HODHODILEKM, OutfitType EAOCJHMJCEG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(RVA = "0x83493E0", Offset = "0x83479E0", VA = "0x1883493E0")]
		protected void EENEGBAPJCA(int JJCENJEBMDL, Material PFHPGDKJCCC, PLKBMGKOFGP MOMJEGOGPIN, [Out] Texture2D DNNBCKKMNDL, [Out] Vector4 FICJFIJJPMD, [Out] Texture2D FLLMJNHJOMP, [Out] Texture2D IGIABAPOCIM, [Out] Texture2D CHNJIMEHDAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x8349070", Offset = "0x8347670", VA = "0x188349070")]
		protected void DIPNFMCNNNJ(int JJCENJEBMDL, Material PFHPGDKJCCC, PLKBMGKOFGP MOMJEGOGPIN, [Out] Color NFEJPKHFMJO, [Out] Color ICMHNDNCEOD, [Out] Color KMPNODPEACK, [Out] Color KPBPNJMJJMG, [Out] Color IMBNPHNCDAC, [Out] Color CILGEIEMLNM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x834BBE0", Offset = "0x834A1E0", VA = "0x18834BBE0")]
		protected void KKAOGLKFHMD(Vector3 PGBNPPMBLDB, Quaternion BGKDKGECOAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x834FAB0", Offset = "0x834E0B0", VA = "0x18834FAB0")]
		public void SetHatAnchorParameters(FKKFOGDLKNE ODLOLCNOGEO, AnchorParamsRestrictions OGJIFEPOKGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x8348670", Offset = "0x8346C70", VA = "0x188348670")]
		public static void CalculateHatAnchorParams(FitMeshHemisphere OKIDPEHFMKP, Transform FFPFHFAALBN, FKKFOGDLKNE ODLOLCNOGEO, AnchorParamsRestrictions ALFMAJAHBLE, [Out] Vector3 GDEKJEBPHAB, [Out] Quaternion JJIKKLJGABK, [Out] FKKFOGDLKNE CPGEKHNAPPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x834E1D0", Offset = "0x834C7D0", VA = "0x18834E1D0")]
		public void ResetHatAnchor(Vector2 MHHLDKKBCPM, Vector3 JAIBPBNIDCL, Vector3 EJGLJGDJPKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0xC3A9E0", Offset = "0xC38FE0", VA = "0x180C3A9E0")]
		public LEILHBJODCF GetAnchorParamsRestrictions()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0x8345400", Offset = "0x8343A00", VA = "0x188345400")]
		public void ApplyBlocks()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x8345540", Offset = "0x8343B40", VA = "0x188345540")]
		public void ApplyHairPattern()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x8345370", Offset = "0x8343970", VA = "0x188345370")]
		public void ApplyBeardPattern()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x8350F90", Offset = "0x834F590", VA = "0x188350F90", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x834CDA0", Offset = "0x834B3A0", VA = "0x18834CDA0")]
		protected void OLNEEPPMHIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x8350D50", Offset = "0x834F350", VA = "0x188350D50")]
		public void SetWaitForUgcTextureLoads(bool FHAAMLAHPOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x8350BD0", Offset = "0x834F1D0", VA = "0x188350BD0")]
		public void SetUgcTextureParameters(BOMGODHADIP ENMBHGMENHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x8351FC0", Offset = "0x83505C0", VA = "0x188351FC0")]
		public PlayerAvatarDisplayBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x83484B0", Offset = "0x8346AB0", VA = "0x1883484B0")]
		[CompilerGenerated]
		private void CKJAOBKHMMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x834CD70", Offset = "0x834B370", VA = "0x18834CD70")]
		[CompilerGenerated]
		private void OHHAMICOODH(EEIIADDAJMP CLGICGKMAGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x8345E00", Offset = "0x8344400", VA = "0x188345E00")]
		[CompilerGenerated]
		private void BCLEIKECFKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x834BC90", Offset = "0x834A290", VA = "0x18834BC90")]
		[CompilerGenerated]
		private void LBMLBPHBFOA(EEIIADDAJMP CLGICGKMAGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x8347E70", Offset = "0x8346470", VA = "0x188347E70")]
		[CompilerGenerated]
		private void CFHCIGDGMNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x834CFD0", Offset = "0x834B5D0", VA = "0x18834CFD0")]
		[CompilerGenerated]
		private void OPFBEKIGJAM(EEIIADDAJMP CLGICGKMAGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x8349630", Offset = "0x8347C30", VA = "0x188349630")]
		[CompilerGenerated]
		private void EOECJMEMPMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x834ABE0", Offset = "0x83491E0", VA = "0x18834ABE0")]
		[CompilerGenerated]
		private void IFHCAJPMMCA(EEIIADDAJMP CLGICGKMAGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x8345130", Offset = "0x8343730", VA = "0x188345130")]
		[CompilerGenerated]
		private void AMNCCDOAKGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x834AB00", Offset = "0x8349100", VA = "0x18834AB00")]
		[CompilerGenerated]
		private void IALIJONJAPM(EEIIADDAJMP CLGICGKMAGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x834AD80", Offset = "0x8349380", VA = "0x18834AD80")]
		[CompilerGenerated]
		private void IKJBBCJHELK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x834A950", Offset = "0x8348F50", VA = "0x18834A950")]
		[CompilerGenerated]
		private void HLABBLFFMLA(EEIIADDAJMP CLGICGKMAGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x834B980", Offset = "0x8349F80", VA = "0x18834B980")]
		[CompilerGenerated]
		internal static bool KGNCGNLHGFP(Transform NNKAEEOEMEC, IEnumerable<SkinnedMeshRenderer> POHKGOHNLBE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x83450A0", Offset = "0x83436A0", VA = "0x1883450A0")]
		[DebuggerHidden]
		[CompilerGenerated]
		private Task AELAFCJECGD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x834BC50", Offset = "0x834A250", VA = "0x18834BC50")]
		[CompilerGenerated]
		private void KODNLBHDHKH(EEIIADDAJMP CLGICGKMAGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x834BFE0", Offset = "0x834A5E0", VA = "0x18834BFE0")]
		[CompilerGenerated]
		private void MBKOJNICJHA(EEIIADDAJMP CLGICGKMAGL)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[ExecuteAlways]
	public class PlayerFacialAnimatorBase : MonoBehaviour, AKDIJPFDGAK
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000070")]
		[CompilerGenerated]
		private struct DIHNECGFCBI : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000486")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000487")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000488")]
			public HBDFLCGDPFO avatarData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000489")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400048A")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003BE")]
			[Cpp2IlInjected.Address(RVA = "0x833E8B0", Offset = "0x833CEB0", VA = "0x18833E8B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003BF")]
			[Cpp2IlInjected.Address(RVA = "0x833EB40", Offset = "0x833D140", VA = "0x18833EB40", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000071")]
		[CompilerGenerated]
		private struct DAMCJFPGFIP : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400048B")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400048C")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400048D")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400048E")]
			public int eyeSelection;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x400048F")]
			public int eyeBrowSelection;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000490")]
			public int noseSelection;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000491")]
			public int mouthSelection;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000492")]
			public KHBAENPMODP avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000493")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003C0")]
			[Cpp2IlInjected.Address(RVA = "0x833DC30", Offset = "0x833C230", VA = "0x18833DC30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003C1")]
			[Cpp2IlInjected.Address(RVA = "0x833DE10", Offset = "0x833C410", VA = "0x18833DE10", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000072")]
		[CompilerGenerated]
		private struct LFEIGHBIINH : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000494")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000495")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000496")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000497")]
			public FaceFeatureType featureType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000498")]
			public int selectionIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000499")]
			public KHBAENPMODP avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400049A")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003C2")]
			[Cpp2IlInjected.Address(RVA = "0x835C100", Offset = "0x835A700", VA = "0x18835C100", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003C3")]
			[Cpp2IlInjected.Address(RVA = "0x835C2A0", Offset = "0x835A8A0", VA = "0x18835C2A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000073")]
		[CompilerGenerated]
		private struct EDMLKOBPOKM : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400049B")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400049C")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400049D")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400049E")]
			public HBDFLCGDPFO avatarData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400049F")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003C4")]
			[Cpp2IlInjected.Address(RVA = "0x835B0D0", Offset = "0x83596D0", VA = "0x18835B0D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003C5")]
			[Cpp2IlInjected.Address(RVA = "0x835B280", Offset = "0x8359880", VA = "0x18835B280", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000074")]
		[CompilerGenerated]
		private struct FGBFANKEPOC : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004A0")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40004A1")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004A2")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004A3")]
			public KHBAENPMODP avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004A4")]
			private TaskAwaiter<NOIPIIJFMBC> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003C6")]
			[Cpp2IlInjected.Address(RVA = "0x835B2E0", Offset = "0x83598E0", VA = "0x18835B2E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003C7")]
			[Cpp2IlInjected.Address(RVA = "0x835B720", Offset = "0x8359D20", VA = "0x18835B720", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000075")]
		[CompilerGenerated]
		private struct DPLMNGIJCJC : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004A5")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40004A6")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004A7")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004A8")]
			public bool forceRebuild;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40004A9")]
			public KHBAENPMODP avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004AA")]
			private FaceStyleSet <styleSet>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40004AB")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003C8")]
			[Cpp2IlInjected.Address(RVA = "0x835A7F0", Offset = "0x8358DF0", VA = "0x18835A7F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003C9")]
			[Cpp2IlInjected.Address(RVA = "0x835AB30", Offset = "0x8359130", VA = "0x18835AB30", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400040E")]
		protected const float KOFNLBNDHFF = 0.5f;

		[Cpp2IlInjected.Token(Token = "0x400040F")]
		protected const int AFCCPABOHMA = 5;

		[Cpp2IlInjected.Token(Token = "0x4000410")]
		private static readonly int GPFEDCDIBAE;

		[Cpp2IlInjected.Token(Token = "0x4000411")]
		private static readonly int LJDGFIPLGHD;

		[Cpp2IlInjected.Token(Token = "0x4000412")]
		private static readonly int OKGCLEDCMMI;

		[Cpp2IlInjected.Token(Token = "0x4000413")]
		public static readonly int IdleID;

		[Cpp2IlInjected.Token(Token = "0x4000414")]
		public static readonly int SmileID;

		[Cpp2IlInjected.Token(Token = "0x4000415")]
		public static readonly int HugeSmileID;

		[Cpp2IlInjected.Token(Token = "0x4000416")]
		public static readonly int ScoreID;

		[Cpp2IlInjected.Token(Token = "0x4000417")]
		public static readonly int SadID;

		[Cpp2IlInjected.Token(Token = "0x4000418")]
		public static readonly int DisgustID;

		[Cpp2IlInjected.Token(Token = "0x4000419")]
		public static readonly int HitID;

		[Cpp2IlInjected.Token(Token = "0x400041A")]
		public static readonly int ConcentrateID;

		[Cpp2IlInjected.Token(Token = "0x400041B")]
		public static readonly int KissID;

		[Cpp2IlInjected.Token(Token = "0x400041C")]
		public static readonly int TalkingID;

		[Cpp2IlInjected.Token(Token = "0x400041D")]
		public static readonly int MuteID;

		[Cpp2IlInjected.Token(Token = "0x400041E")]
		public static readonly int AFKID;

		[Cpp2IlInjected.Token(Token = "0x400041F")]
		public static readonly int HappyID;

		[Cpp2IlInjected.Token(Token = "0x4000420")]
		public static readonly int EmoteFlatID;

		[Cpp2IlInjected.Token(Token = "0x4000421")]
		public static readonly int EmoteHappyID;

		[Cpp2IlInjected.Token(Token = "0x4000422")]
		public static readonly int EmoteSadID;

		[Cpp2IlInjected.Token(Token = "0x4000423")]
		public static readonly int EmoteLoveID;

		[Cpp2IlInjected.Token(Token = "0x4000424")]
		public static readonly int EmoteAngryID;

		[Cpp2IlInjected.Token(Token = "0x4000425")]
		public static readonly int EmoteLaughID;

		[Cpp2IlInjected.Token(Token = "0x4000426")]
		public static readonly int EmoteTongueOutID;

		[Cpp2IlInjected.Token(Token = "0x4000427")]
		public static readonly int EmoteGrimacingID;

		[Cpp2IlInjected.Token(Token = "0x4000428")]
		public static readonly int EmoteWinkID;

		[Cpp2IlInjected.Token(Token = "0x4000429")]
		public static readonly int EmoteShockedID;

		[Cpp2IlInjected.Token(Token = "0x400042A")]
		public static readonly int EmoteNauseatedID;

		[Cpp2IlInjected.Token(Token = "0x400042B")]
		public static readonly int EmoteSmileSweatID;

		[Cpp2IlInjected.Token(Token = "0x400042C")]
		public static readonly int EmoteSleepingID;

		[Cpp2IlInjected.Token(Token = "0x400042D")]
		public static readonly int EmoteThinkingID;

		[Cpp2IlInjected.Token(Token = "0x400042E")]
		public static readonly int EmoteSmirkID;

		[Cpp2IlInjected.Token(Token = "0x400042F")]
		public static readonly int EmoteSmileID;

		[Cpp2IlInjected.Token(Token = "0x4000430")]
		protected static readonly Dictionary<KFLHIOEOHJB.LBNDHKLEJNK, int> HKALMAPOGIO;

		[Cpp2IlInjected.Token(Token = "0x4000431")]
		[CanBeNull]
		protected static IEnumerable<FaceFeatureType> PDCLIFNGJDL;

		[Cpp2IlInjected.Token(Token = "0x4000432")]
		protected static readonly int CDMFFHHKONL;

		[Cpp2IlInjected.Token(Token = "0x4000433")]
		protected static readonly int PANEGIFDBCA;

		[Cpp2IlInjected.Token(Token = "0x4000434")]
		protected static readonly int ELKHGDDFOBN;

		[Cpp2IlInjected.Token(Token = "0x4000435")]
		protected static readonly int LMFHDDMIDPG;

		[Cpp2IlInjected.Token(Token = "0x4000436")]
		protected static readonly int NPEILAIJIIE;

		[Cpp2IlInjected.Token(Token = "0x4000437")]
		protected static Vector2 LBFIKCLPIEF;

		[Cpp2IlInjected.Token(Token = "0x4000438")]
		protected static Vector2 PHNBJFJFKKO;

		[Cpp2IlInjected.Token(Token = "0x4000439")]
		protected static Vector2 LCCHFAAJDEF;

		[Cpp2IlInjected.Token(Token = "0x400043A")]
		protected static Vector2 COOBFJDFJCP;

		[Cpp2IlInjected.Token(Token = "0x400043B")]
		protected static Vector2 BEBLLCLMKMG;

		[Cpp2IlInjected.Token(Token = "0x400043C")]
		protected static Vector2 LLIJLHMNBHI;

		[Cpp2IlInjected.Token(Token = "0x400043D")]
		protected static Vector2 HHIMCFLBHHB;

		[Cpp2IlInjected.Token(Token = "0x400043E")]
		protected static Vector2 ABDHDKCCEMJ;

		[Cpp2IlInjected.Token(Token = "0x400043F")]
		protected static Vector2 DPHOEJNGLME;

		[Cpp2IlInjected.Token(Token = "0x4000440")]
		protected static Vector2 ANCIIIEOFCF;

		[Cpp2IlInjected.Token(Token = "0x4000441")]
		protected static Vector2 OFNKAFHMBCB;

		[Cpp2IlInjected.Token(Token = "0x4000442")]
		protected static Vector2 BFGDAGBPCNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000443")]
		[SerializeField]
		[OOBMCMDIFDG(GJFENOMGFMJ.Self, false, false, false)]
		public Animator animator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000444")]
		[SerializeField]
		[Header("Rendering")]
		public FaceStyleSet faceStyleSet;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000445")]
		[SerializeField]
		protected Renderer faceRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000446")]
		[SerializeField]
		protected float jitterFPS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000447")]
		[Header("Emotes")]
		[SerializeField]
		public Renderer[] emoteEffectRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000448")]
		[FormerlySerializedAs("fullBodyFaceStyleSet")]
		[Header("Modern Avatar Facial Features")]
		[SerializeField]
		public FaceStyleSet modernBodyFaceStyleSet;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000449")]
		private KHBAENPMODP CKHOACDFLLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400044A")]
		private FaceStyleSet DMHKJEEJEDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400044B")]
		[SerializeField]
		protected bool debugEyeJitterInEditor;

		[Cpp2IlInjected.Token(Token = "0x400044C")]
		protected const int OKGMKMOMPLE = -1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400044D")]
		protected int MIEJMLHLIOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400044E")]
		protected int LLHGEIFANEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400044F")]
		protected int GMLLFINJJON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000450")]
		protected int EBKGGAOMKFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000451")]
		protected Vector2 MAMMHBJDOAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000452")]
		protected float CKLJIOPFAKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000453")]
		protected float CJKPFMLAFOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4000454")]
		protected float OFFCCEGJGAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000455")]
		protected Vector2 CIOHGLMJFCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000456")]
		protected float IKAGOIMFKAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x4000457")]
		protected float DPKMKAPHMNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000458")]
		protected float MBEGPAABNOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x4000459")]
		protected Vector2 JPPFEAMGJFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x400045A")]
		protected float GIKFGMICNHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400045B")]
		protected float CGGKMCNGIAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x400045C")]
		protected float KBCKIKMLHOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400045D")]
		protected Vector2 KFOJILHJHMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400045E")]
		protected float OADPMLMKLOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x400045F")]
		protected float LAHMIKMADMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000460")]
		protected float JJNOFGHDJHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000461")]
		protected List<SelectableFaceOption> LGLEEKHOOOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000462")]
		protected List<SelectableFaceOption> CJHNGOLFHOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000463")]
		protected List<SelectableFaceOption> KLDPOBKKLED;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000464")]
		protected List<SelectableFaceOption> HJGJHDNIPLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000465")]
		protected Coroutine GBFNPGBDGGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000466")]
		protected int? LICNCKLPOOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000467")]
		protected int NMDFIMBAIME;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
		[Cpp2IlInjected.Token(Token = "0x4000468")]
		protected int IAMENLABHCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000469")]
		protected int ODBDJJEMBKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
		[Cpp2IlInjected.Token(Token = "0x400046A")]
		protected int GPONJDBCNOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400046B")]
		protected Sprite LPJGBLDLNGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400046C")]
		protected Sprite IIKKHPFBDGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400046D")]
		protected Sprite NEPHKHIGLBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x400046E")]
		protected Sprite EIANOLFJDNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x400046F")]
		protected bool FBDCPICOAEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000471")]
		protected string MKFKIKNMGHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000472")]
		protected string PAHCDJLOOAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000473")]
		protected string KALGKGFABKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x4000474")]
		protected string NDAPPLFIEJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4000475")]
		[ReadOnlyField]
		public Sprite eyeSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4000476")]
		[ReadOnlyField]
		public Sprite leftEyeOnlySprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4000477")]
		[ReadOnlyField]
		public Sprite rightEyeOnlySprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4000478")]
		public Color leftEyeColorTint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x4000479")]
		public Color leftEyeGleamColorTint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x400047A")]
		public Color rightEyeColorTint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x400047B")]
		public Color rightEyeGleamColorTint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x400047C")]
		[ReadOnlyField]
		public Sprite mouthSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x4000480")]
		protected AvatarConfiguration MJDEHMHOFAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x4000481")]
		protected NOIPIIJFMBC ICKAOOFGLGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x4000483")]
		private readonly List<Material> NGAIBPOJNJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x4000484")]
		protected PCDBIIDHCHM DDMKBIGLKGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x4000485")]
		protected Dictionary<string, int> KBJOFNBDJJA;

		[Cpp2IlInjected.Token(Token = "0x170000A1")]
		public FaceStyleSet EBKCIDFONIF
		{
			[Cpp2IlInjected.Token(Token = "0x6000375")]
			[Cpp2IlInjected.Address(RVA = "0x835A0D0", Offset = "0x83586D0", VA = "0x18835A0D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A2")]
		public bool MEGELOEHMPG
		{
			[Cpp2IlInjected.Token(Token = "0x6000378")]
			[Cpp2IlInjected.Address(RVA = "0xB5ACF0", Offset = "0xB592F0", VA = "0x180B5ACF0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000379")]
			[Cpp2IlInjected.Address(RVA = "0x278E940", Offset = "0x278CF40", VA = "0x18278E940")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A3")]
		protected virtual bool CJDIICLHAFA
		{
			[Cpp2IlInjected.Token(Token = "0x600037A")]
			[Cpp2IlInjected.Address(RVA = "0xAF14E0", Offset = "0xAEFAE0", VA = "0x180AF14E0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A4")]
		protected virtual bool KPBDNIMPGLC
		{
			[Cpp2IlInjected.Token(Token = "0x600037B")]
			[Cpp2IlInjected.Address(RVA = "0xAC1E50", Offset = "0xAC0450", VA = "0x180AC1E50", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		protected int CBEBKDCPCPH
		{
			[Cpp2IlInjected.Token(Token = "0x600037C")]
			[Cpp2IlInjected.Address(RVA = "0x8354BB0", Offset = "0x83531B0", VA = "0x188354BB0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A6")]
		public Renderer PGNMCCGIKEN
		{
			[Cpp2IlInjected.Token(Token = "0x600037D")]
			[Cpp2IlInjected.Address(RVA = "0xAA5560", Offset = "0xAA3B60", VA = "0x180AA5560")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A7")]
		public bool KGKLMPPOJFE
		{
			[Cpp2IlInjected.Token(Token = "0x600037E")]
			[Cpp2IlInjected.Address(RVA = "0x13F61B0", Offset = "0x13F47B0", VA = "0x1813F61B0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600037F")]
			[Cpp2IlInjected.Address(RVA = "0x2794190", Offset = "0x2792790", VA = "0x182794190")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A8")]
		public Renderer[] KFOEGLPMIPO
		{
			[Cpp2IlInjected.Token(Token = "0x6000380")]
			[Cpp2IlInjected.Address(RVA = "0xAA54B0", Offset = "0xAA3AB0", VA = "0x180AA54B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A9")]
		public bool HBNEOLNMCBI
		{
			[Cpp2IlInjected.Token(Token = "0x6000381")]
			[Cpp2IlInjected.Address(RVA = "0x835A120", Offset = "0x8358720", VA = "0x18835A120")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000382")]
			[Cpp2IlInjected.Address(RVA = "0x835A2E0", Offset = "0x83588E0", VA = "0x18835A2E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AA")]
		protected int NDNBLLLBEFG
		{
			[Cpp2IlInjected.Token(Token = "0x6000383")]
			[Cpp2IlInjected.Address(RVA = "0x83551E0", Offset = "0x83537E0", VA = "0x1883551E0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AB")]
		protected int PPFEJHIMEMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000384")]
			[Cpp2IlInjected.Address(RVA = "0x8356B60", Offset = "0x8355160", VA = "0x188356B60")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AC")]
		public float GEOIBLBBPPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000385")]
			[Cpp2IlInjected.Address(RVA = "0x835A100", Offset = "0x8358700", VA = "0x18835A100")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000386")]
			[Cpp2IlInjected.Address(RVA = "0x835A2C0", Offset = "0x83588C0", VA = "0x18835A2C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AD")]
		public NCFHMNIFFNK KBAFMJLOMGK
		{
			[Cpp2IlInjected.Token(Token = "0x6000387")]
			[Cpp2IlInjected.Address(RVA = "0xC3B8B0", Offset = "0xC39EB0", VA = "0x180C3B8B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000388")]
			[Cpp2IlInjected.Address(RVA = "0xC81210", Offset = "0xC7F810", VA = "0x180C81210")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AE")]
		public NOIPIIJFMBC FONDHFHGPEF
		{
			[Cpp2IlInjected.Token(Token = "0x60003A4")]
			[Cpp2IlInjected.Address(RVA = "0xB80E60", Offset = "0xB7F460", VA = "0x180B80E60")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003A5")]
			[Cpp2IlInjected.Address(RVA = "0x835A240", Offset = "0x8358840", VA = "0x18835A240")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AF")]
		public NoseFaceOption BKOJJCKLIJP
		{
			[Cpp2IlInjected.Token(Token = "0x60003A6")]
			[Cpp2IlInjected.Address(RVA = "0xC3A9E0", Offset = "0xC38FE0", VA = "0x180C3A9E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003A7")]
			[Cpp2IlInjected.Address(RVA = "0xC1FA70", Offset = "0xC1E070", VA = "0x180C1FA70")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B0")]
		protected PCDBIIDHCHM ILPBFKEOBBG
		{
			[Cpp2IlInjected.Token(Token = "0x60003A8")]
			[Cpp2IlInjected.Address(RVA = "0x8354CE0", Offset = "0x83532E0", VA = "0x188354CE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action FEIGINBCKGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000376")]
			[Cpp2IlInjected.Address(RVA = "0x835A020", Offset = "0x8358620", VA = "0x18835A020")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000377")]
			[Cpp2IlInjected.Address(RVA = "0x835A190", Offset = "0x8358790", VA = "0x18835A190")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x8356A60", Offset = "0x8355060", VA = "0x188356A60")]
		public void LocalPlayEmote(KFLHIOEOHJB.LBNDHKLEJNK OIALPCPCDIJ, float GLGDNNNINMK = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x8355770", Offset = "0x8353D70", VA = "0x188355770")]
		public bool IsEmotePlaying(KFLHIOEOHJB.LBNDHKLEJNK OIALPCPCDIJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x8357F40", Offset = "0x8356540", VA = "0x188357F40")]
		public void SetIdleHappy(bool HBMJOMNBKIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x8354880", Offset = "0x8352E80", VA = "0x188354880")]
		protected void DDPDBCLINIA(bool AOHHJPIIFJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x8354A50", Offset = "0x8353050", VA = "0x188354A50")]
		protected void FCBGFFHFNMJ(bool GKIJEOBPCGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x8354900", Offset = "0x8352F00", VA = "0x188354900")]
		protected void DGJHDBGHCBG(APMGGBJHHPH HODHODILEKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x8353A80", Offset = "0x8352080", VA = "0x188353A80")]
		protected void ACAIFCIIDEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x8357610", Offset = "0x8355C10", VA = "0x188357610")]
		public void PlayExpression(int GFKCIEFDCGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x8355890", Offset = "0x8353E90", VA = "0x188355890")]
		protected void JCAKOIHCEEE(bool LAIMGGIAKLL, bool CEDNIIEFKEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x8355020", Offset = "0x8353620", VA = "0x188355020")]
		public List<SelectableFaceOption> GetAvailableFeatures(FaceFeatureType PALJILABNBA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x8355240", Offset = "0x8353840", VA = "0x188355240")]
		public void InitializeFaceFeatureRanges(AvatarConfiguration MJDEHMHOFAC, KHBAENPMODP INLGMINCMAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x8357D10", Offset = "0x8356310", VA = "0x188357D10")]
		[AsyncStateMachine(typeof(DIHNECGFCBI))]
		public Task SetFaceSettings(HBDFLCGDPFO CBMCGBCNLPB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x8357BE0", Offset = "0x83561E0", VA = "0x188357BE0")]
		[AsyncStateMachine(typeof(DAMCJFPGFIP))]
		public Task SetFaceSettings(int CJAAJMHKCMO, int DDPCMAJOAAE, int KBCBEDIDOLG, int BJGIMEAJMCL, KHBAENPMODP INLGMINCMAD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x8357FC0", Offset = "0x83565C0", VA = "0x188357FC0")]
		[AsyncStateMachine(typeof(LFEIGHBIINH))]
		public Task SetSelectedFaceFeatureAndBuildFaceStyle(FaceFeatureType PALJILABNBA, int BHPMBCAOLNI, KHBAENPMODP INLGMINCMAD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x8355950", Offset = "0x8353F50", VA = "0x188355950")]
		protected void JFDJACEDMEN(FaceFeatureType PALJILABNBA, KKNCLIFJEEB HCOABHBCMNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x8353EC0", Offset = "0x83524C0", VA = "0x188353EC0")]
		protected void BFEPCFEOBCI(FaceFeatureType PALJILABNBA, int BHPMBCAOLNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x8354E40", Offset = "0x8353440", VA = "0x188354E40")]
		public static IEnumerable<FaceFeatureType> GetAllFaceFeatureTypes()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x8356BC0", Offset = "0x83551C0", VA = "0x188356BC0")]
		[AsyncStateMachine(typeof(EDMLKOBPOKM))]
		protected Task NMCIHNDDBNA(HBDFLCGDPFO CBMCGBCNLPB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x8356CB0", Offset = "0x83552B0", VA = "0x188356CB0")]
		protected void ODJBMEABEMA(HBDFLCGDPFO CBMCGBCNLPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x8357470", Offset = "0x8355A70", VA = "0x188357470")]
		protected static void PNAOBCCNCMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x8353AF0", Offset = "0x83520F0", VA = "0x188353AF0")]
		private void AMICIHGGBHL(bool BFIGNGDALBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x83566D0", Offset = "0x8354CD0", VA = "0x1883566D0")]
		protected void KOPPKKCANOP(FaceFeatureType PALJILABNBA, Vector2 DLBHDMMHIFL, KHBAENPMODP INLGMINCMAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x8357630", Offset = "0x8355C30", VA = "0x188357630")]
		public void SetFaceFeatureNormalizedPositionOffset(FaceFeatureType PALJILABNBA, Vector2 EICMGKJEBLK, KHBAENPMODP INLGMINCMAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x8354600", Offset = "0x8352C00", VA = "0x188354600")]
		protected void BJMDADFIPMO(FaceFeatureType PALJILABNBA, float FIFCNJCDJDC, KHBAENPMODP INLGMINCMAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x8355060", Offset = "0x8353660", VA = "0x188355060")]
		protected void HFEAPGACNPC(FaceFeatureType PALJILABNBA, float LDAEEKEKDJC, KHBAENPMODP INLGMINCMAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x8355AD0", Offset = "0x83540D0", VA = "0x188355AD0")]
		protected void JIKCDLGBGGC(FaceFeatureType PALJILABNBA, float HLHHHKKPLIG, KHBAENPMODP INLGMINCMAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x83579C0", Offset = "0x8355FC0", VA = "0x1883579C0")]
		public void SetFaceFeatureNormalizedScaleOffset(FaceFeatureType PALJILABNBA, float KLAOKDAFDIN, KHBAENPMODP INLGMINCMAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x8354970", Offset = "0x8352F70", VA = "0x188354970")]
		[AsyncStateMachine(typeof(FGBFANKEPOC))]
		protected Task DKONEMIKPIB(KHBAENPMODP INLGMINCMAD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0x8355560", Offset = "0x8353B60", VA = "0x188355560")]
		public void InitializeFaceFeatureStyleSet(KHBAENPMODP INLGMINCMAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0x8354D60", Offset = "0x8353360", VA = "0x188354D60")]
		protected bool GMBKAINFCNL(string DCFJKBOFFEJ, [Out] int PMIGBJGNLLP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x8353D80", Offset = "0x8352380", VA = "0x188353D80")]
		protected void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x83580D0", Offset = "0x83566D0", VA = "0x1883580D0", Slot = "8")]
		protected virtual void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x8357170", Offset = "0x8355770", VA = "0x188357170")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x83590D0", Offset = "0x83576D0", VA = "0x1883590D0")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x8354780", Offset = "0x8352D80", VA = "0x188354780")]
		[AsyncStateMachine(typeof(DPLMNGIJCJC))]
		public Task BuildFaceStyleAsyncIfChanged(KHBAENPMODP INLGMINCMAD, bool FLCLNLNENJL = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x83589E0", Offset = "0x8356FE0", VA = "0x1883589E0")]
		public void UpdateFaceDisplays(bool GNJKECDABIG = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x8355DD0", Offset = "0x83543D0", VA = "0x188355DD0")]
		protected bool JLIJIOOBIEN(bool GNJKECDABIG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x8358740", Offset = "0x8356D40", VA = "0x188358740")]
		public void UpdateFaceDisplayFeatureTextures()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x8357E00", Offset = "0x8356400", VA = "0x188357E00")]
		public void SetFaceSpriteIndices(string EDOGHEDECKN, string KFMIKAEAGAI, string EOBAKPCCNLH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x83580E0", Offset = "0x83566E0", VA = "0x1883580E0")]
		public void UpdateFaceDisplayFeaturePositions()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x8358C00", Offset = "0x8357200", VA = "0x188358C00")]
		public void UpdateFaceJitterMultiplier()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x8358DF0", Offset = "0x83573F0", VA = "0x188358DF0")]
		public bool UpdateLegacyFaceVectors()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x8357380", Offset = "0x8355980", VA = "0x188357380")]
		protected void PAJCHFDOPKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x8355BA0", Offset = "0x83541A0", VA = "0x188355BA0")]
		private void JJAFMAGPEON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x8356520", Offset = "0x8354B20", VA = "0x188356520")]
		private void JOAGBBAODON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x8359DC0", Offset = "0x83583C0", VA = "0x188359DC0")]
		public PlayerFacialAnimatorBase()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0xAD3D60", Offset = "0xAD2360", VA = "0x180AD3D60", Slot = "4")]
		private bool IPGDOMHPEAO()
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public struct DGMAACIFOHI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004AC")]
	public string EEABAFMMHKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004AD")]
	public int HMNNHOPLICJ;
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	[ExecuteInEditMode]
	[SelectionBase]
	public class PlayerModernBodyEditorAvatarValidator : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000079")]
		[CompilerGenerated]
		private struct ONMLIIPMMOJ : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000511")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000512")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000513")]
			public PlayerModernBodyEditorAvatarValidator <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000514")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003FD")]
			[Cpp2IlInjected.Address(RVA = "0x835C380", Offset = "0x835A980", VA = "0x18835C380", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003FE")]
			[Cpp2IlInjected.Address(RVA = "0xB035A0", Offset = "0xB01BA0", VA = "0x180B035A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200007A")]
		[CompilerGenerated]
		private struct DPOLDDFJFAB : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000515")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000516")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000517")]
			public PlayerModernBodyEditorAvatarValidator <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000518")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003FF")]
			[Cpp2IlInjected.Address(RVA = "0x835AB90", Offset = "0x8359190", VA = "0x18835AB90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000400")]
			[Cpp2IlInjected.Address(RVA = "0x835B070", Offset = "0x8359670", VA = "0x18835B070", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		public const string IDLE_ANIM_NAME = "Idle";

		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		public const string A_POSE_ANIM_NAME = "A Pose";

		[Cpp2IlInjected.Token(Token = "0x40004B0")]
		public const string ANIMATION_OVERRIDE_STATE_NAME = "Override";

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004B1")]
		public KHBAENPMODP avatarBodyType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40004B3")]
		public Color hairPrimaryColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40004B4")]
		public Color hairSecondaryColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40004B5")]
		public Color beardPrimaryColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40004B6")]
		public Color beardSecondaryColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x40004B7")]
		public Color skinColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x40004B8")]
		public int faceShapeIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40004B9")]
		public int bodyShapeIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x40004BA")]
		public int hairPatternIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40004BB")]
		public int beardPatternIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40004BC")]
		public AvatarFaceShape[] faceShapes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40004BD")]
		public AvatarBodyShape[] bodyShapes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40004BE")]
		public AvatarHairPattern[] hairPatterns;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40004BF")]
		public float _avatarScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x40004C0")]
		public bool enablePosing;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40004C1")]
		public int poseIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40004C2")]
		public AnimationClip animationOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40004C3")]
		[Range(0f, 4f)]
		public float animationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x40004C4")]
		public bool hideEars;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40004C5")]
		public INLNEMFBLHB useHelmetHair;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40004C6")]
		public FKKFOGDLKNE hatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40004C7")]
		public LEILHBJODCF HatAnchorRestrictions;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40004C8")]
		public bool UseHairFitMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD1")]
		[Cpp2IlInjected.Token(Token = "0x40004C9")]
		public bool usesHatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40004CA")]
		public GameObject hatPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40004CB")]
		public GameObject hairPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40004CC")]
		public GameObject earPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40004CD")]
		public GameObject eyePrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40004CE")]
		public GameObject mouthPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40004CF")]
		public GameObject neckPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40004D0")]
		public GameObject shirtPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40004D1")]
		public GameObject beltPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40004D2")]
		public GameObject shoulderPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40004D3")]
		public GameObject rightHandPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40004D4")]
		public GameObject leftHandPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40004D5")]
		public GameObject legsPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40004D6")]
		public GameObject feetPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40004D7")]
		public GameObject torsoModestyPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40004D8")]
		public GameObject legsModestyPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40004D9")]
		public GameObject validationPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40004DA")]
		public bool showModestyAndValidationGuidelines;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40004DB")]
		public long baseSkinCullingMask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40004DC")]
		[OOBMCMDIFDG(GJFENOMGFMJ.Self, false, false, false)]
		[SerializeField]
		public PlayerAvatarDisplayBase _avatarDisplay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40004DD")]
		private LKOPKJAFICM BDHLDJDMHGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40004DE")]
		[SerializeField]
		[OOBMCMDIFDG(GJFENOMGFMJ.Self, false, false, false)]
		public PlayerFacialAnimatorBase facialAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x40004DF")]
		public Animator animator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x40004E0")]
		public AnimationClip animationClipToOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x40004E1")]
		private AnimatorOverrideController NFDPIINGFCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x40004E2")]
		private List<KeyValuePair<AnimationClip, AnimationClip>> BIKGFHFDPOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x40004E3")]
		public Transform headIKEffector;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x40004E4")]
		public Transform leftHandIKEffector;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x40004E5")]
		public Transform rightHandIKEffector;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x40004E6")]
		[Range(0f, 2f)]
		public int lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1BC")]
		[Cpp2IlInjected.Token(Token = "0x40004E7")]
		public int rightHandGestureStateIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x40004E8")]
		[Range(0f, 1f)]
		public float rightHandCurl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C4")]
		[Cpp2IlInjected.Token(Token = "0x40004E9")]
		public int leftHandGestureStateIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x40004EA")]
		[Range(0f, 1f)]
		public float leftHandCurl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1CC")]
		[Cpp2IlInjected.Token(Token = "0x40004EB")]
		public int eyeBrowSelection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x40004EC")]
		public int eyeSelection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D4")]
		[Cpp2IlInjected.Token(Token = "0x40004ED")]
		public int noseSelection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x40004EE")]
		public int mouthSelection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1DC")]
		[Cpp2IlInjected.Token(Token = "0x40004EF")]
		public float eyeBrowPositionOffsetHorizontal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x40004F0")]
		public float eyeBrowPositionOffsetVertical;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E4")]
		[Cpp2IlInjected.Token(Token = "0x40004F1")]
		public float eyeBrowScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x40004F2")]
		public float eyePositionOffsetHorizontal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1EC")]
		[Cpp2IlInjected.Token(Token = "0x40004F3")]
		public float eyePositionOffsetVertical;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
		[Cpp2IlInjected.Token(Token = "0x40004F4")]
		public float eyeScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F4")]
		[Cpp2IlInjected.Token(Token = "0x40004F5")]
		public float nosePositionOffsetVertical;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
		[Cpp2IlInjected.Token(Token = "0x40004F6")]
		public float noseScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1FC")]
		[Cpp2IlInjected.Token(Token = "0x40004F7")]
		public float mouthPositionOffsetHorizontal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
		[Cpp2IlInjected.Token(Token = "0x40004F8")]
		public float mouthPositionOffsetVertical;

		[Cpp2IlInjected.FieldOffset(Offset = "0x204")]
		[Cpp2IlInjected.Token(Token = "0x40004F9")]
		public float mouthScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
		[Cpp2IlInjected.Token(Token = "0x40004FA")]
		public float hatNormalizedPositionX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20C")]
		[Cpp2IlInjected.Token(Token = "0x40004FB")]
		public float hatNormalizedPositionY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
		[Cpp2IlInjected.Token(Token = "0x40004FC")]
		public Vector3 hatHemispherePositionOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21C")]
		[Cpp2IlInjected.Token(Token = "0x40004FD")]
		public Vector3 hatHemisphereRotationOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
		[Cpp2IlInjected.Token(Token = "0x40004FE")]
		public int facialExpressionIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x22C")]
		[Cpp2IlInjected.Token(Token = "0x40004FF")]
		[Range(0f, 1f)]
		public float normalizedTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
		[Cpp2IlInjected.Token(Token = "0x4000500")]
		public readonly DGMAACIFOHI[] FacialExpressions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
		[Cpp2IlInjected.Token(Token = "0x4000501")]
		public readonly string[] BodyPoses;

		[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
		[Cpp2IlInjected.Token(Token = "0x4000502")]
		public readonly (string, ALNHBAFPCMB)[] HandPoses;

		[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
		[Cpp2IlInjected.Token(Token = "0x4000503")]
		public bool hideLeftWatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x249")]
		[Cpp2IlInjected.Token(Token = "0x4000504")]
		public bool hideRightWatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24A")]
		[Cpp2IlInjected.Token(Token = "0x4000505")]
		protected bool AFOOKDMEFGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24C")]
		[Cpp2IlInjected.Token(Token = "0x4000506")]
		protected Guid HCEBBNNIFGK;

		[Cpp2IlInjected.Token(Token = "0x4000507")]
		protected static Guid FEDFNCBEPDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x4000508")]
		private EEDAILNAJPO AGOOCBCLJJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
		[Cpp2IlInjected.Token(Token = "0x4000509")]
		private NCFHMNIFFNK JBBEODNHJLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
		[Cpp2IlInjected.Token(Token = "0x400050A")]
		private GDGKEFFDPOH PPJFIDMGLNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x400050B")]
		private GDGKEFFDPOH AHOAKKEGICN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
		[Cpp2IlInjected.Token(Token = "0x400050C")]
		private AdditionalHatData FOONLHKDBBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
		[Cpp2IlInjected.Token(Token = "0x400050D")]
		private readonly Dictionary<GameObject, AONMEGFPBGH> IPBKCEEDBCO;

		[Cpp2IlInjected.Token(Token = "0x170000B1")]
		public static Func<GJKHMDGLBLA> NCAKGCJBFEJ
		{
			[Cpp2IlInjected.Token(Token = "0x60003CB")]
			[Cpp2IlInjected.Address(RVA = "0x8361490", Offset = "0x835FA90", VA = "0x188361490")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003CC")]
			[Cpp2IlInjected.Address(RVA = "0x8361AD0", Offset = "0x83600D0", VA = "0x188361AD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B2")]
		public bool GKJHGJKDJOH
		{
			[Cpp2IlInjected.Token(Token = "0x60003CD")]
			[Cpp2IlInjected.Address(RVA = "0x83615F0", Offset = "0x835FBF0", VA = "0x1883615F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B3")]
		public bool JDOKHCPJJCH
		{
			[Cpp2IlInjected.Token(Token = "0x60003CE")]
			[Cpp2IlInjected.Address(RVA = "0x83614E0", Offset = "0x835FAE0", VA = "0x1883614E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B4")]
		public PlayerAvatarDisplayBase OKAPNHDFMBA
		{
			[Cpp2IlInjected.Token(Token = "0x60003D0")]
			[Cpp2IlInjected.Address(RVA = "0xC1DC00", Offset = "0xC1C200", VA = "0x180C1DC00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B5")]
		protected static Guid IKGEIFNDMMJ
		{
			[Cpp2IlInjected.Token(Token = "0x60003D1")]
			[Cpp2IlInjected.Address(RVA = "0x835E560", Offset = "0x835CB60", VA = "0x18835E560")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B6")]
		public (GameObject, APMGGBJHHPH)[] DFELMFEKMPL
		{
			[Cpp2IlInjected.Token(Token = "0x60003E7")]
			[Cpp2IlInjected.Address(RVA = "0x8361700", Offset = "0x835FD00", VA = "0x188361700")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x835F180", Offset = "0x835D780", VA = "0x18835F180")]
		[ContextMenu("Refresh Avatar")]
		private void RebuildTestAvatarContextMenu()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x835ED10", Offset = "0x835D310", VA = "0x18835ED10")]
		private IEnumerable<GameObject> PEAFILLGGBC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x835F6A0", Offset = "0x835DCA0", VA = "0x18835F6A0")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x835EA60", Offset = "0x835D060", VA = "0x18835EA60")]
		private void LJBCOEHIOCP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x1595410", Offset = "0x1593A10", VA = "0x181595410")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x835DE60", Offset = "0x835C460", VA = "0x18835DE60")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x835F6B0", Offset = "0x835DCB0", VA = "0x18835F6B0")]
		public void Teardown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x835F4C0", Offset = "0x835DAC0", VA = "0x18835F4C0")]
		public void ShowPose(AnimationClip OMEKNHIGCGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x835F670", Offset = "0x835DC70", VA = "0x18835F670")]
		public void ShowPose(string OIMCINLCOPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x835F2F0", Offset = "0x835D8F0", VA = "0x18835F2F0")]
		public void ResetPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x835F190", Offset = "0x835D790", VA = "0x18835F190")]
		public void ResetHandPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x8360160", Offset = "0x835E760", VA = "0x188360160")]
		public void UpdateHandAnimation()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x835FFC0", Offset = "0x835E5C0", VA = "0x18835FFC0")]
		public void UpdateFaceAndBodyShapes(bool FLCLNLNENJL = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x8360580", Offset = "0x835EB80", VA = "0x188360580")]
		public void UpdateNoseShape(FHGFAGJLMJA HKICDDGHPEE, bool FLCLNLNENJL = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x8360540", Offset = "0x835EB40", VA = "0x188360540")]
		public void UpdateLODOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x835D610", Offset = "0x835BC10", VA = "0x18835D610", Slot = "4")]
		protected virtual void GKJFOOGCJJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x835D3A0", Offset = "0x835B9A0", VA = "0x18835D3A0", Slot = "5")]
		protected virtual void GKFKHHDGPMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x835C740", Offset = "0x835AD40", VA = "0x18835C740")]
		public void ApplyHatData(AdditionalHatData LOJJLPFKNDP, bool OGPHEGKLOMH = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x835C580", Offset = "0x835AB80", VA = "0x18835C580")]
		public void ApplyHatAdjustmentsToHatAnchorParams()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x835CAA0", Offset = "0x835B0A0", VA = "0x18835CAA0")]
		public void ApplyHatUVOverride(Vector2 DAAMLGKMPFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E4")]
		[Cpp2IlInjected.Address(RVA = "0x835C9C0", Offset = "0x835AFC0", VA = "0x18835C9C0")]
		public void ApplyHatPositionAdjustment(Vector3 AGBNJGPEBPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(RVA = "0x835CA30", Offset = "0x835B030", VA = "0x18835CA30")]
		public void ApplyHatRotationAdjustment(Vector3 GJHFMEPAKPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E6")]
		[Cpp2IlInjected.Address(RVA = "0x835CB10", Offset = "0x835B110", VA = "0x18835CB10")]
		public HODKDMLKKBH BuildAvatarItemSelection(GameObject ABFFGEEFIIE, KHBAENPMODP OOFIPNOLEJN, APMGGBJHHPH PKEPAGIAPCB)
		{
			return default(HODKDMLKKBH);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(RVA = "0x835CBB0", Offset = "0x835B1B0", VA = "0x18835CBB0")]
		public void BuildAvatar(bool FLCLNLNENJL = false, bool OGPHEGKLOMH = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E9")]
		[Cpp2IlInjected.Address(RVA = "0x835FA00", Offset = "0x835E000", VA = "0x18835FA00")]
		public void UpdateColors()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EA")]
		[Cpp2IlInjected.Address(RVA = "0x835C6C0", Offset = "0x835ACC0", VA = "0x18835C6C0")]
		public void ApplyHatAnchor()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EB")]
		[Cpp2IlInjected.Address(RVA = "0x8360390", Offset = "0x835E990", VA = "0x188360390")]
		public void UpdateHatAnchor(bool OGPHEGKLOMH = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EC")]
		[Cpp2IlInjected.Address(RVA = "0x83600B0", Offset = "0x835E6B0", VA = "0x1883600B0")]
		[AsyncStateMachine(typeof(ONMLIIPMMOJ))]
		public void UpdateFaceFeatures()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003ED")]
		[Cpp2IlInjected.Address(RVA = "0x835D220", Offset = "0x835B820", VA = "0x18835D220")]
		[AsyncStateMachine(typeof(DPOLDDFJFAB))]
		private Task DGKNGGFPBFG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003EE")]
		[Cpp2IlInjected.Address(RVA = "0x835EC20", Offset = "0x835D220", VA = "0x18835EC20")]
		private void OHDCLGOMGEM(FaceFeatureType MLPIBMFGLMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x835E650", Offset = "0x835CC50", VA = "0x18835E650")]
		private void JHNOCGLJPMJ(FaceFeatureType MLPIBMFGLMC, [Out] float KBACFNODLOC, [Out] float BHMMLFKDCHF, [Out] float EAHAEIJNIMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x835FE80", Offset = "0x835E480", VA = "0x18835FE80")]
		public void UpdateEmote()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x83601F0", Offset = "0x835E7F0", VA = "0x1883601F0")]
		public void UpdateHandPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x835D930", Offset = "0x835BF30", VA = "0x18835D930")]
		private void GLIEOAPKHKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980")]
		private void HDBJEOHMMIH(AONMEGFPBGH KIEJPLFJFIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980")]
		private void DIHILFACPNN(AONMEGFPBGH KIEJPLFJFIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(RVA = "0x835E6E0", Offset = "0x835CCE0", VA = "0x18835E6E0")]
		private void LCCKKHGHFCP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(RVA = "0x8360610", Offset = "0x835EC10", VA = "0x188360610")]
		public PlayerModernBodyEditorAvatarValidator()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(RVA = "0x835D2F0", Offset = "0x835B8F0", VA = "0x18835D2F0")]
		[CompilerGenerated]
		private HODKDMLKKBH GEGMMPNFLEJ((GameObject, APMGGBJHHPH) HEMEFNDFAOD)
		{
			return default(HODKDMLKKBH);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public class SkinnedMeshBonesInspector : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000519")]
		[SerializeField]
		[OOBMCMDIFDG(GJFENOMGFMJ.Self, false, false, false)]
		private SkinnedMeshRenderer skinnedMeshRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400051A")]
		[SerializeField]
		private int BoneWeightsDisplayStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400051B")]
		[SerializeField]
		private int BoneWeightsDisplayAmount;

		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0xAA8970", Offset = "0xAA6F70", VA = "0x180AA8970")]
		public SkinnedMeshBonesInspector()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public struct HODKDMLKKBH
{
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	[CompilerGenerated]
	private sealed class KKAOAKGFPBH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400051E")]
		public IEnumerable<OutfitType> otherOutfitTypes;

		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public KKAOAKGFPBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x835C080", Offset = "0x835A680", VA = "0x18835C080")]
		internal bool KKKLAHCCFKL(OutfitType outfitType)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400051C")]
	private AONMEGFPBGH ONKLAOJGDBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400051D")]
	private APMGGBJHHPH FNGLGDKLPFD;

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public AONMEGFPBGH PIIMBLJHCBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0xB562C0", Offset = "0xB548C0", VA = "0x180B562C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public APMGGBJHHPH ODGBELDFKMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0xECF560", Offset = "0xECDB60", VA = "0x180ECF560")]
		get
		{
			return default(APMGGBJHHPH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public string NPCMGBMOJAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x835B780", Offset = "0x8359D80", VA = "0x18835B780")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public bool HCFJJFMNDFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000405")]
		[Cpp2IlInjected.Address(RVA = "0x835BC00", Offset = "0x835A200", VA = "0x18835BC00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public bool EDFHLOLECNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0x835BBB0", Offset = "0x835A1B0", VA = "0x18835BBB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x1B0CD90", Offset = "0x1B0B390", VA = "0x181B0CD90")]
	public HODKDMLKKBH(AONMEGFPBGH KIEJPLFJFIG, APMGGBJHHPH HODHODILEKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x835B8F0", Offset = "0x8359EF0", VA = "0x18835B8F0")]
	public bool EGNMAHKLBPE(OutfitType BOKNCCDDKIL, APMGGBJHHPH NIOLBIPHIFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x835BC50", Offset = "0x835A250", VA = "0x18835BC50")]
	public bool PCMIJLMABJD(OutfitType BOKNCCDDKIL, APMGGBJHHPH NIOLBIPHIFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(RVA = "0x835B9C0", Offset = "0x8359FC0", VA = "0x18835B9C0")]
	public bool GCBPAJDGDLI(HODKDMLKKBH AOJCIEOKBPM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public class IAKFFDOBDCF
{
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	[CompilerGenerated]
	private sealed class MJEDNDCBEPP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000523")]
		public IEnumerable<OutfitType> otherOutfitTypes;

		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public MJEDNDCBEPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x835C300", Offset = "0x835A900", VA = "0x18835C300")]
		internal bool KKKLAHCCFKL(OutfitType outfitType)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400051F")]
	private AONMEGFPBGH ONKLAOJGDBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000520")]
	private NNHECNKHCLL FNGLGDKLPFD;

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public AONMEGFPBGH PIIMBLJHCBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0xAA5610", Offset = "0xAA3C10", VA = "0x180AA5610")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public NNHECNKHCLL ODGBELDFKMH
	{
		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0xAB04F0", Offset = "0xAAEAF0", VA = "0x180AB04F0")]
		get
		{
			return default(NNHECNKHCLL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public Color? CAPMFCMMIDO
	{
		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0xAB0460", Offset = "0xAAEA60", VA = "0x180AB0460")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000410")]
		[Cpp2IlInjected.Address(RVA = "0xAB0520", Offset = "0xAAEB20", VA = "0x180AB0520")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public Vector3? BGKDKGECOAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000411")]
		[Cpp2IlInjected.Address(RVA = "0xF75380", Offset = "0xF73980", VA = "0x180F75380")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0xF74BF0", Offset = "0xF731F0", VA = "0x180F74BF0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x835C010", Offset = "0x835A610", VA = "0x18835C010")]
	public IAKFFDOBDCF(AONMEGFPBGH KIEJPLFJFIG, NNHECNKHCLL HODHODILEKM, Color? FPHNLEHIJEM, Vector3? LDAEEKEKDJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x835BEE0", Offset = "0x835A4E0", VA = "0x18835BEE0")]
	public bool GCBPAJDGDLI(IAKFFDOBDCF AOJCIEOKBPM)
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
