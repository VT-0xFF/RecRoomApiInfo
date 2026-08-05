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
	public class LogRegistrationIndex : LGGBAGMLBKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x74471F0", Offset = "0x74463F0", VA = "0x1874471F0", Slot = "4")]
		public override void COGNOIDNGPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x98C9C0", Offset = "0x98BBC0", VA = "0x18098C9C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x96A6B0", Offset = "0x9698B0", VA = "0x18096A6B0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override string AssetGUID
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x744C8A0", Offset = "0x744BAA0", VA = "0x18744C8A0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x744C830", Offset = "0x744BA30", VA = "0x18744C830", Slot = "17")]
		public override bool RuntimeKeyIsValid()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x744C860", Offset = "0x744BA60", VA = "0x18744C860")]
		public RecNetCDNAssetReference(RecNetCDNKey MBDBONINAPC)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class RecNetCDNKey
	{
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public enum ALADFIFICBD : byte
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
			[Cpp2IlInjected.Address(RVA = "0x964520", Offset = "0x963720", VA = "0x180964520")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x964780", Offset = "0x963980", VA = "0x180964780")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public string UniqueItemIdentifier
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x963A50", Offset = "0x962C50", VA = "0x180963A50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x9642A0", Offset = "0x9634A0", VA = "0x1809642A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public string CacheHash
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x968CD0", Offset = "0x967ED0", VA = "0x180968CD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x9642B0", Offset = "0x9634B0", VA = "0x1809642B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RecNetCDNKey Dependency
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x964CD0", Offset = "0x963ED0", VA = "0x180964CD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x968CF0", Offset = "0x967EF0", VA = "0x180968CF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool AttemptPrecacheLookup
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x990150", Offset = "0x98F350", VA = "0x180990150")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x98FED0", Offset = "0x98F0D0", VA = "0x18098FED0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public ALADFIFICBD PathHint
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xCBD0F0", Offset = "0xCBC2F0", VA = "0x180CBD0F0")]
			[CompilerGenerated]
			get
			{
				return default(ALADFIFICBD);
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x117A190", Offset = "0x1179390", VA = "0x18117A190")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string ItemPath
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x744C9B0", Offset = "0x744BBB0", VA = "0x18744C9B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x744C930", Offset = "0x744BB30", VA = "0x18744C930")]
		public static RecNetCDNKey DBCDPKGCNED(string MIGNMIHDBBO, ALADFIFICBD DMKAKGEADMN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x744C8E0", Offset = "0x744BAE0", VA = "0x18744C8E0")]
		public void BDPHNHJKGJD(string PDIHGIECHAD, string HFFPIBBOHEG, bool MJJGCEDFPDF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public RecNetCDNKey()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[ALDPDJHMICB]
public class EEPCDGKFKEA : IGNLPILKDPP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	protected readonly List<Mesh> GCAHLGCBAKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	protected readonly List<byte[]> IOBPHDKBFFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	protected readonly List<Matrix4x4> DDIMOBHGHDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	protected readonly List<bool> DPKNHIFJGAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	protected readonly List<long> KBKGFFCBLLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	protected readonly List<bool> CIJEKDKIOGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	protected readonly List<int> FKCKENEOAOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	protected Allocator AGEDCBGBNPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	protected BLMBBPOKJAO OLONKOMBKCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	protected byte PPONPIPJPGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	protected IList<int> KCONHDICBEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	protected IList<int> AOLBBFFCOOA;

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7444A40", Offset = "0x7443C40", VA = "0x187444A40", Slot = "4")]
	public void PFKMDIMHHCC(Mesh CJONLLGJGEO, Matrix4x4 EFNEGKKDIBM, byte[] NAIGDGBKDKE, bool IFHAHFBNENO = false, LHOPHOECLDF.PDNJAPAFAJM BBAGJPCMNKP = (LHOPHOECLDF.PDNJAPAFAJM)0L, int CBDGCFPMAHH = -1, bool CPJFHANIEMP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7444A00", Offset = "0x7443C00", VA = "0x187444A00", Slot = "5")]
	public void CCEOAAHHJIC(Allocator JNKCCGKBKPB, BLMBBPOKJAO PPACCKPNLPD, byte DFLIPJOGBFK, [Optional] IList<int> EKIEKAIOCLB, [Optional] IList<int> BKJEJDBNILE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x74447A0", Offset = "0x74439A0", VA = "0x1874447A0")]
	private static void BHJDIPNDBFI(Mesh CJONLLGJGEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7444CC0", Offset = "0x7443EC0", VA = "0x187444CC0")]
	public EEPCDGKFKEA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[ALDPDJHMICB]
public struct GFMNCFIGEBE : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	[ReadOnly]
	public AICPLKKCMOI PLHACJMEGPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	[ReadOnly]
	public int DILDJBEKPIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public NIDMEFBMMHO JBKBLFKGLCF;

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7445150", Offset = "0x7444350", VA = "0x187445150", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[ALDPDJHMICB]
[NativeContainer]
public struct NIDMEFBMMHO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct EIIAPMEKBNE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public Vector3 LFHBOMIKKKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public Vector3 HFFGEMAKAAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public Vector4 ACHJDMDOAAN;
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct FBFCHIIFCJE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public float OCLHJBJBCHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public float HBHJFAPGKNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public float KLBODKGPKJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public float LMBMHEEMMMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public byte CPNKDCADAGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public byte BCAAKFOPPDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public byte OIOODMBAENO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public byte AGAMGCMBIAD;
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct MHDKDCKFCGI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public half OCLHJBJBCHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public half HBHJFAPGKNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public half KLBODKGPKJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public half LMBMHEEMMMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public byte CPNKDCADAGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public byte BCAAKFOPPDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public byte OIOODMBAENO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public byte AGAMGCMBIAD;
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct PHHFBCLHBMK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public half4 JLNFDAODDKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public half2 INMNDOAJIMM;
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public struct JLKKMGLLGBE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public half4 JLNFDAODDKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public half2 INMNDOAJIMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public half2 PJDPBKIPHKH;
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct GBOACDOOEJA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public half4 JLNFDAODDKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public half2 INMNDOAJIMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public half2 PJDPBKIPHKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public half2 INEOKHIIMPM;
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public struct DJJBLJLPMKD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public half4 JLNFDAODDKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public half2 INMNDOAJIMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public half2 PJDPBKIPHKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public half2 INEOKHIIMPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public half2 BHPJFNKAFEO;
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public struct INNNNPKPHID
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public float OCLHJBJBCHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public float HBHJFAPGKNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public float KLBODKGPKJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public float LMBMHEEMMMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public int CPNKDCADAGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public int BCAAKFOPPDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public int OIOODMBAENO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public int AGAMGCMBIAD;
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public struct CCLPCHAJBPI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public Color JLNFDAODDKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public Vector2 INMNDOAJIMM;
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public struct GEMEDPHPNOM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public Color JLNFDAODDKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public Vector2 INMNDOAJIMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public Vector2 PJDPBKIPHKH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public struct HJJDAALLCOA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Color JLNFDAODDKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public Vector2 INMNDOAJIMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public Vector2 PJDPBKIPHKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Vector2 INEOKHIIMPM;
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public struct DFPBOLIFPHJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public Color JLNFDAODDKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public Vector2 INMNDOAJIMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public Vector2 PJDPBKIPHKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public Vector2 INEOKHIIMPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public Vector2 BHPJFNKAFEO;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private bool POCLOGAIIJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public NativeArray<EIIAPMEKBNE> GHKBPKEMMAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public NativeArray<PHHFBCLHBMK> CALNOMCNAMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public NativeArray<JLKKMGLLGBE> DLGCJCPPOJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public NativeArray<GBOACDOOEJA> GMMAJINJDGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public NativeArray<DJJBLJLPMKD> MKIMHGGNNBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public NativeArray<MHDKDCKFCGI> HFHLAIKELHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public NativeArray<FBFCHIIFCJE> LNACCFJDMDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public NativeArray<CCLPCHAJBPI> CBKJAJIKALB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public NativeArray<GEMEDPHPNOM> DIKEEGOABGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public NativeArray<HJJDAALLCOA> FLBKNDEPLKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public NativeArray<DFPBOLIFPHJ> BCJMGJCMFBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public NativeArray<INNNNPKPHID> PJEJBMHKEPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public NativeArray<int> DMPMHLMJBPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public NativeArray<int> HBDINGOAHJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private NativeArray<int> PNIOHGKDPMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private NativeArray<int> OEJLFOLFGCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public NativeArray<int> LBKPKOMHIAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public NativeArray<int> AFFOIHACOAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public NativeArray<int> FEFACPKMOEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public NativeArray<BoneWeight> CJCAIPLKDNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private NativeArray<int> BNHLGDBCCDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private bool GDINGIGOMKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x159")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private bool BDELFOAOOCO;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int DGFKEIKJCEA
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x7448A00", Offset = "0x7447C00", VA = "0x187448A00")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x74496E0", Offset = "0x74488E0", VA = "0x1874496E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int MCCAGBNPBNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7448AF0", Offset = "0x7447CF0", VA = "0x187448AF0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7448780", Offset = "0x7447980", VA = "0x187448780")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int PMPGFOILDBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7448AE0", Offset = "0x7447CE0", VA = "0x187448AE0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x74489F0", Offset = "0x7447BF0", VA = "0x1874489F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int EGMAMDKEMPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7448710", Offset = "0x7447910", VA = "0x187448710")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x74496F0", Offset = "0x74488F0", VA = "0x1874496F0")]
	public NIDMEFBMMHO(int GLNPICAEGCC, int ENKLLGHGADN, int ONOEKEMEAEM, int PMBFNKDJDLL, Allocator JNKCCGKBKPB, int DIAKOBOIBBA, OIGLHBBAAEA HFNENPCPBCN, bool GDINGIGOMKH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7449650", Offset = "0x7448850", VA = "0x187449650")]
	public void MKOLFLLNMAK(int KOOLKCPAFBB, Vector3 OKAELCMAFHA, Vector3 NEFHNGEGIGC, Vector4 FDDEDLKEPIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x74482E0", Offset = "0x74474E0", VA = "0x1874482E0")]
	public void BDNPCJPHIDK(int KOOLKCPAFBB, BoneWeight KDLGFLNPLMN, NativeSlice<byte> NAIGDGBKDKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7449320", Offset = "0x7448520", VA = "0x187449320")]
	public Color MCIMJMFGOGF(int KOOLKCPAFBB)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7448EC0", Offset = "0x74480C0", VA = "0x187448EC0")]
	public void JHIMLBMOHMK(int KOOLKCPAFBB, Color CPCFIJBFPJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7448B10", Offset = "0x7447D10", VA = "0x187448B10")]
	public void GJKOOANPPCD(byte KJFLIKNIGLM, int KOOLKCPAFBB, Vector2 CDKBLKPMKKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7448B00", Offset = "0x7447D00", VA = "0x187448B00")]
	public void GEBCOFBKNKC(int KOOLKCPAFBB, int JNFDLDEJOPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x74492C0", Offset = "0x74484C0", VA = "0x1874492C0")]
	public bool KDGKMPJIGFA(int KJFLIKNIGLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7448A10", Offset = "0x7447C10", VA = "0x187448A10")]
	public void EMDICFPAFFG(int KBNCKPFMHIH, int DCNPLBBIONO, int EEBDBIBAAFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7448790", Offset = "0x7447990", VA = "0x187448790", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x74473B0", Offset = "0x74465B0", VA = "0x1874473B0")]
	public Mesh AIKFBCEJJOA([Optional] string CAKHFJDLLPN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[DefaultMember("Item")]
[NativeContainer]
[ALDPDJHMICB]
public struct AICPLKKCMOI : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public Mesh.MeshDataArray PKIIKCINFFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public NativeArray<int> KFGDEAJMFGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public NativeArray<int> FENJECILFIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public NativeArray<BoneWeight> CJCAIPLKDNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private NativeArray<Matrix4x4> DGJOPAICLEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private NativeArray<long> DIADAIDMBNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private NativeArray<byte> EIFCMNINHEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private NativeArray<int> CCDHFEIPJNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private NativeArray<int> PGMFBFLMJLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public NativeArray<sbyte> IJEKENCHCCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public NativeArray<byte> MPKFJIELMPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public NativeArray<bool> CPJFHANIEMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public NativeArray<int> CBDGCFPMAHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private bool GDINGIGOMKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private NativeArray<int> PFPOMGKPMNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private bool BDELFOAOOCO;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int PMIFAECFMLL
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x7434890", Offset = "0x7433A90", VA = "0x187434890")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int IADFCPOPALM
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x7434DA0", Offset = "0x7433FA0", VA = "0x187434DA0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int BHGHFNKAGNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7434A30", Offset = "0x7433C30", VA = "0x187434A30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int EAOCGFDEHBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x7434B00", Offset = "0x7433D00", VA = "0x187434B00")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x7434D80", Offset = "0x7433F80", VA = "0x187434D80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int DGFKEIKJCEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x7434A20", Offset = "0x7433C20", VA = "0x187434A20")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7434DB0", Offset = "0x7433FB0", VA = "0x187434DB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public int DFNFFJNMJIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7434870", Offset = "0x7433A70", VA = "0x187434870")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7434D70", Offset = "0x7433F70", VA = "0x187434D70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public BLMBBPOKJAO LIFMKAFJKNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7434D90", Offset = "0x7433F90", VA = "0x187434D90")]
		get
		{
			return default(BLMBBPOKJAO);
		}
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7434880", Offset = "0x7433A80", VA = "0x187434880")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public byte LKBADKEEFDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7434D60", Offset = "0x7433F60", VA = "0x187434D60")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7434860", Offset = "0x7433A60", VA = "0x187434860")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public KGMKJGHBPHO EPCJHJAGLJO
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7434B10", Offset = "0x7433D10", VA = "0x187434B10")]
		get
		{
			return default(KGMKJGHBPHO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7434E90", Offset = "0x7434090", VA = "0x187434E90")]
	public AICPLKKCMOI(IList<Mesh> IPMIEOJADNO, IList<Matrix4x4> ABAMGDCKBOO, IList<bool> CPJFHANIEMP, byte DFLIPJOGBFK, IList<byte[]> EELADDDDBMC, IList<long> MJBEIKNPNPH, IList<bool> FGJGFKJIFAC, IList<int> CBDGCFPMAHH, IList<int> EKIEKAIOCLB, IList<int> NPALLMKFPPN, Allocator JNKCCGKBKPB, BLMBBPOKJAO PPACCKPNLPD, bool GDINGIGOMKH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7434DC0", Offset = "0x7433FC0", VA = "0x187434DC0")]
	public NIDMEFBMMHO OMDJHECDLGI(Allocator JNKCCGKBKPB, OIGLHBBAAEA HFNENPCPBCN)
	{
		return default(NIDMEFBMMHO);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x74348A0", Offset = "0x7433AA0", VA = "0x1874348A0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[ALDPDJHMICB]
public class JHBPJBAKOGM : EEPCDGKFKEA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public bool NKIIPIFKKJG;

	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private static readonly ProfilerMarker AAMCFINGIGC;

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x7446EE0", Offset = "0x74460E0", VA = "0x187446EE0")]
	public AICPLKKCMOI GGLGPDFFLAO()
	{
		return default(AICPLKKCMOI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x74471E0", Offset = "0x74463E0", VA = "0x1874471E0")]
	public JHBPJBAKOGM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct KGMKJGHBPHO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public Mesh.MeshData BKHGMOGKDPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public NativeSlice<BoneWeight> CJCAIPLKDNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public NativeSlice<byte> FCINPFNIOPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public int JHFBMFCFKKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public Matrix4x4 CJMNHOEBING;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public long CMLOPFCKCPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public NativeSlice<byte> NAIGDGBKDKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public bool KJKJONMLIBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public int EBIOGBBOJGN;
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class AJDHBHPBHBB : BMAGGMLBMKH
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class PJJJFCJNGAD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public NNBPLOEBEJG avatarBuildParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public AJDHBHPBHBB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public EMKGHLOECBM buildMeshPromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public Action<KeyValuePair<string, CAFFOJNOKAH<Texture2D>>> <>9__19;

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public PJJJFCJNGAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x744C6F0", Offset = "0x744B8F0", VA = "0x18744C6F0")]
		internal bool KBMIJPDKKMH(JCNHDNCLCIK item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x744C5E0", Offset = "0x744B7E0", VA = "0x18744C5E0")]
		internal void KCMJMINGAGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x744C5C0", Offset = "0x744B7C0", VA = "0x18744C5C0")]
		internal void ALPPNMNEACM(string err)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x744C5E0", Offset = "0x744B7E0", VA = "0x18744C5E0")]
		internal void GLNLHJJKPBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x744C5C0", Offset = "0x744B7C0", VA = "0x18744C5C0")]
		internal void GKNAKIBCBLO(string err)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x744C800", Offset = "0x744BA00", VA = "0x18744C800")]
		internal void MDOPFBNPCOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x744C6C0", Offset = "0x744B8C0", VA = "0x18744C6C0")]
		internal void JDAGAGEAPJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x744C600", Offset = "0x744B800", VA = "0x18744C600")]
		internal void HHPCMFCJBNN(Dictionary<string, CAFFOJNOKAH<Texture2D>> resourceHandleDictionary)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x744C740", Offset = "0x744B940", VA = "0x18744C740")]
		internal void LDHMGPPMPIF(KeyValuePair<string, CAFFOJNOKAH<Texture2D>> kvp)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x968CD0", Offset = "0x967ED0", VA = "0x180968CD0")]
		internal LHBFOPKLGGA KOMKCJHGDMB()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class BEMMKDMBMLE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public int lowestPossibleLOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public PJJJFCJNGAD CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public BEMMKDMBMLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x7444420", Offset = "0x7443620", VA = "0x187444420")]
		internal LEMEGGAADFP JFMEEKINGGN(int lod)
		{
			return default(LEMEGGAADFP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class HCMPOFDNOAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public JBBNLHPJHLB<Dictionary<string, CAFFOJNOKAH<Texture2D>>> ugcTextureDictionaryPromise;

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public HCMPOFDNOAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x964520", Offset = "0x963720", VA = "0x180964520")]
		internal JBBNLHPJHLB<Dictionary<string, CAFFOJNOKAH<Texture2D>>> JODNAGMMHMN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class NBAMJDDNHEJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public List<EMKGHLOECBM> innerPromises;

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public NBAMJDDNHEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x7447280", Offset = "0x7446480", VA = "0x187447280")]
		internal void HFDDONCIPJP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class HDMCBBHCBKK : IEnumerator<DEPLMKJKOMK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private DEPLMKJKOMK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public bool shouldWait;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public AJDHBHPBHBB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public List<HAILHKLIACP> parts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public List<EMKGHLOECBM> innerPromises;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public int[] LODs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public bool isFirstPerson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public Func<int, LEMEGGAADFP> getLayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public MEKDMIMMDLJ materialPropertyBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public Material materialInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		private int <lodIndex>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		private DEPLMKJKOMK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x963A50", Offset = "0x962C50", VA = "0x180963A50", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x963A50", Offset = "0x962C50", VA = "0x180963A50", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x963B40", Offset = "0x962D40", VA = "0x180963B40")]
		[DebuggerHidden]
		public HDMCBBHCBKK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x7446C10", Offset = "0x7445E10", VA = "0x187446C10", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x7446E90", Offset = "0x7446090", VA = "0x187446E90", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class CCAEKECNMFM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public JFIFLFLLDOF cancelable;

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public CCAEKECNMFM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0xAC5AD0", Offset = "0xAC4CD0", VA = "0x180AC5AD0")]
		internal void GKOJIPOMKHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0xBE2530", Offset = "0xBE1730", VA = "0x180BE2530")]
		internal void MMKPEMBGIDH(string err)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class JICNAHIBOMC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public long jobComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public Stopwatch stopwatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public SkinnedMeshRenderer lodRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public long meshComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public string meshName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public long meshCopyComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public AJDHBHPBHBB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public int lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public List<Material> newUniqueMaterials;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public int frameStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public long lodBuildStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public long startCombineBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public long jobScheduled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public Action onFinally;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public JICNAHIBOMC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class EIICMNFPHDA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public bool waitingForComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public JobHandle lodBuildJobHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public NIDMEFBMMHO defaultMeshJobContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public AICPLKKCMOI defaultAvatarMeshJobGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public JICNAHIBOMC CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public EIICMNFPHDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x7444F10", Offset = "0x7444110", VA = "0x187444F10")]
		internal void IKKKFKALPPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x10C2790", Offset = "0x10C1990", VA = "0x1810C2790")]
		internal void FIHAAOFPMGN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class EBPJFMNGLOE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public bool waitingForComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public JobHandle lodBuildJobHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public NCCFCLBBEJJ legacyMeshJobContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public IJPINHBEHCL legacyAvatarMeshJobGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public JICNAHIBOMC CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public EBPJFMNGLOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x7444560", Offset = "0x7443760", VA = "0x187444560")]
		internal void BMDAMOIOLJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x10C1E00", Offset = "0x10C1000", VA = "0x1810C1E00")]
		internal void OKMECAKLOJK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class BKCJCDKFPBE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public string overrideItemIdentifier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public OCHNHLJBAPP overrideBodyPart;

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public BKCJCDKFPBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x74444E0", Offset = "0x74436E0", VA = "0x1874444E0")]
		internal bool GNMJHNFDOCK(KeyValuePair<string, JCNHDNCLCIK> entry)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly MIOEGIOIKAG BNHHKDEIFGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly MIOEGIOIKAG JNMPCFAANJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private Dictionary<OBFILAGNCOE, float> BDOBLNHOBPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private Dictionary<PNKEOEACGPH, float> PFLHOPFKIHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private IReadOnlyDictionary<string, HCGNCEABOJF> JDLDENBDJAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private Dictionary<string, HCGNCEABOJF> JKCBPPGBBGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private Dictionary<string, HCGNCEABOJF> GHFCEOKCLDE;

	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private static float AHPFAEFCHJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private bool? GPHGBCNPEBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4A")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private bool? CMJKCMENNAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private bool? IEKLAFCNLLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private AvatarConfiguration OAOBGDECHJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private Transform DELAAKMAABI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private AvatarSkinAssetItem PIBLIEFEOIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private AssetReference IDNHONMNKKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private GameObject FFODOJFIENL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private GameObject CMBHPAEIFIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private SkinnedMeshRenderer GAFGNDHHJNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private AvatarSkinnedMeshBoneOrderRemapsData FMJIPHJNLCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private Transform[] POMGJGFNLKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private Matrix4x4[] JGMOEFABMFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private Material GLNKOHABLPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private Material KENMJPMBEEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private Material DJLPGHMODHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private Shader BIEMJDBPCFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private Shader HIGMFJAFOMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private Animator LACLBOFJHFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private Renderer[] HJODCEEOPCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private LHOPHOECLDF.PDNJAPAFAJM LFLIGMIBIFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private AvatarBodyPartShapesManager ILPJNCCIHLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private IReadOnlyDictionary<string, Transform> AKFFIJNBBHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private AvatarFaceShapeData.OHOBBJFCMNG NEGGPFJIPAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private AvatarBodyShapeData.KNPAADGPPLD NCIKOGJPCDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private MKBBPKEHLCL ACBHBFINNJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private bool IJIKEFLOGCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFD")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private bool ONMPCFKHEBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private Color LOCBHFNHAOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private Color KABKFLAOCCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private Color JDGKGIBHCJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private Color? BINPLNNCHKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x144")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private Color? IGCFENKPDJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private Color? FBLKHMAPDNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x16C")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private Color? DKLMNMECBKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private Texture2D KPGGJMJBMOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private Texture2D BDDHJPKEACD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	[CanBeNull]
	private JCNHDNCLCIK OPDOGCNPNHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private Texture PCFIGBCEAHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private Color ALCIBEMOHNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public Dictionary<Renderer, MEKDMIMMDLJ> DFMMJGMEGAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private Dictionary<Renderer, MEKDMIMMDLJ> KFONNIOBODP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private Dictionary<string, List<FDPNLIIEJJD>> PMJBINLOGAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private Dictionary<string, List<FDPNLIIEJJD>> FJCCCMLAPGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private readonly List<DIPMDJLELCL> AJNKMLPCIEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private readonly List<DIPMDJLELCL> HIIHKLAPDOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private readonly List<DIPMDJLELCL> GEALDJMPCII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private readonly List<DIPMDJLELCL> GEIOKEHLDEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private Dictionary<FDPNLIIEJJD, Material> AMMAGDNDNAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private Dictionary<FDPNLIIEJJD, Material> PMHIMNBGPGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private SkinnedMeshRenderer[] GEJBMFKKEOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private SkinnedMeshRenderer[] BDHIFPPDKIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private SkinnedMeshRenderer[] DCIBFNCDDPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private SkinnedMeshRenderer[] HEGLDBHJECF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private readonly Dictionary<string, CAFFOJNOKAH<Texture2D>> FEDFKEONMLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private readonly Dictionary<string, CAFFOJNOKAH<Texture2D>> NNCCDMCLDDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private DKFIILHCHMC GCACBAPEEJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x234")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private DKFIILHCHMC AIGJPIFECJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private AdditionalHatData AHHOBLLCHEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private AdditionalHatData IMFFGDMAMHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private HairData BAEMNFLDMCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private HairData NGLCIHEANGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private FJJMJDFJPJG GDFHENEFINB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private bool? IPBDJEGOMHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x264")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private PositionAndRotation CCKJMCPMBHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private Transform LEBAODFMDPO;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private Material OLBGANKADLA;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private Material OAOMDFNKBMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private Dictionary<string, JCNHDNCLCIK> OAIAFCHHAMA;

	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private static readonly int HEFPBILANIE;

	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private static readonly int GNNHCIIKNIP;

	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private static readonly int NABBKJPANEI;

	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private static readonly int NAPJDJFGJFM;

	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private static readonly int CLNAONEBEPO;

	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private static readonly int FLNLNOBCALD;

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private static readonly int NOCCEJCBHDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private bool HLAMINCCENJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private List<Action> BKLCOMEEALJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B0")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private LFIOEJONFIO CMFDGLFDBPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B8")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private SkinnedMeshRenderer[] GNAOBFDBHIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C0")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private int IICHLJGGJDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C4")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private bool JFJNJOEPLLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private int BAOOJBGANJB;

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public MIOEGIOIKAG PMKKBBPACHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x964520", Offset = "0x963720", VA = "0x180964520", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public MIOEGIOIKAG MNAEBGDNGFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x963A50", Offset = "0x962C50", VA = "0x180963A50", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private JDFJKMABMDJ PGKELCELKPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x743FBC0", Offset = "0x743EDC0", VA = "0x18743FBC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	private bool MCBKPLHALKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x743F590", Offset = "0x743E790", VA = "0x18743F590")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	private bool GGNALCPFNJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x7440A30", Offset = "0x743FC30", VA = "0x187440A30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	private bool IECGMFPFGOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7439D90", Offset = "0x7438F90", VA = "0x187439D90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public AvatarConfiguration IGAFFCFOMBD
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x961630", Offset = "0x960830", VA = "0x180961630", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool FFEJEGKKNNF
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x11E3850", Offset = "0x11E2A50", VA = "0x1811E3850")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x74392B0", Offset = "0x74384B0", VA = "0x1874392B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	private Material BOCCPNBLCEN
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x7439FE0", Offset = "0x74391E0", VA = "0x187439FE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	private Material CFLIFHADBPG
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x743E710", Offset = "0x743D910", VA = "0x18743E710")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	private bool NCBBCCIDDMG
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x97D6F0", Offset = "0x97C8F0", VA = "0x18097D6F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public KJAEMCJAGMO AJLNOJKOLBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x10553D0", Offset = "0x10545D0", VA = "0x1810553D0", Slot = "23")]
		[CompilerGenerated]
		get
		{
			return default(KJAEMCJAGMO);
		}
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x10553E0", Offset = "0x10545E0", VA = "0x1810553E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public Material EOGOPPPMFOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x969760", Offset = "0x968960", VA = "0x180969760", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public SkinnedMeshRenderer[] IGJAPOEDBFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x1A3BD40", Offset = "0x1A3AF40", VA = "0x181A3BD40", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public Renderer[] OOEPAOPIIGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0xA96D70", Offset = "0xA95F70", VA = "0x180A96D70", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public bool OMAOJJPBOLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x74392C0", Offset = "0x74384C0", VA = "0x1874392C0", Slot = "22")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public LHOPHOECLDF.PDNJAPAFAJM LCGOOIEJEKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x969710", Offset = "0x968910", VA = "0x180969710", Slot = "20")]
		get
		{
			return default(LHOPHOECLDF.PDNJAPAFAJM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public int CFJPLNFAADC
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x1055A20", Offset = "0x1054C20", VA = "0x181055A20")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x743B510", Offset = "0x743A710", VA = "0x18743B510")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	private bool KIMHLGPCDGN
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x7436500", Offset = "0x7435700", VA = "0x187436500")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	private static bool ICINJDJHLPN
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x9ACBB0", Offset = "0x9ABDB0", VA = "0x1809ACBB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7440390", Offset = "0x743F590", VA = "0x187440390", Slot = "15")]
	public EMKGHLOECBM PCAHAHDAHNN(NNBPLOEBEJG NKCNLBKCJJD, bool IJNFAEOBAJD, int[] HJHBOOCCGFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7439450", Offset = "0x7438650", VA = "0x187439450", Slot = "14")]
	public EMKGHLOECBM DENGKEKBILG(NNBPLOEBEJG NKCNLBKCJJD, bool IJNFAEOBAJD, int[] HJHBOOCCGFN, Func<Dictionary<string, JCNHDNCLCIK>, (EMKGHLOECBM, JBBNLHPJHLB<Dictionary<string, CAFFOJNOKAH<Texture2D>>>)> EDIHCKIIKPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7436830", Offset = "0x7435A30", VA = "0x187436830")]
	public EMKGHLOECBM BDOMLEIKCOF(NNBPLOEBEJG NKCNLBKCJJD, bool IJNFAEOBAJD, int[] HJHBOOCCGFN, bool LJGDLEKOLBM, DKFIILHCHMC BJBODNCGPFF, [Optional] Func<Dictionary<string, JCNHDNCLCIK>, (EMKGHLOECBM, JBBNLHPJHLB<Dictionary<string, CAFFOJNOKAH<Texture2D>>>)> EDIHCKIIKPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7440970", Offset = "0x743FB70", VA = "0x187440970")]
	private bool PDMCLGFOKIO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7438890", Offset = "0x7437A90", VA = "0x187438890")]
	private EMKGHLOECBM BFHHIDDHMEH(bool IJNFAEOBAJD, List<HAILHKLIACP> NLLEGKHPKCA, int[] HJHBOOCCGFN, Func<int, LEMEGGAADFP> HNNKAMAHGKB, bool LJGDLEKOLBM = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7436580", Offset = "0x7435780", VA = "0x187436580")]
	[IteratorStateMachine(typeof(HDMCBBHCBKK))]
	private IEnumerator<DEPLMKJKOMK> ANFEMJPIGMM(bool IJNFAEOBAJD, List<HAILHKLIACP> NLLEGKHPKCA, int[] HJHBOOCCGFN, Func<int, LEMEGGAADFP> HNNKAMAHGKB, MEKDMIMMDLJ KJMCDDDEPKC, Material BGBKGHHFFCI, List<EMKGHLOECBM> IJJNNGNPDIK, bool EICOJLKCCCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x743B530", Offset = "0x743A730", VA = "0x18743B530")]
	private void GMMKLBIEKPC(List<HAILHKLIACP> NLLEGKHPKCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x743D610", Offset = "0x743C810", VA = "0x18743D610")]
	private EMKGHLOECBM KKDFHOALOEG(List<HAILHKLIACP> NLLEGKHPKCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7440F90", Offset = "0x7440190", VA = "0x187440F90")]
	private PHFJKNHMAKK PNKNAKGCAOJ(List<HAILHKLIACP> NLLEGKHPKCA, int KADDNMPDABI, bool IJNFAEOBAJD, LEMEGGAADFP HBBGNKHGPFB, bool DLGILHIFOHD, MEKDMIMMDLJ KJMCDDDEPKC, Material BGBKGHHFFCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x743F670", Offset = "0x743E870", VA = "0x18743F670", Slot = "27")]
	public void NHCHGPJFIDP(OBFILAGNCOE MLGJBLMEBNO, float OMFJNFBDJCA, bool OEGKJAPAFDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7439480", Offset = "0x7438680", VA = "0x187439480", Slot = "29")]
	public void DGKEMENHPIK(PNKEOEACGPH AEKMGAIBEPJ, float OMFJNFBDJCA, bool EKHKCMAHEJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x743BC70", Offset = "0x743AE70", VA = "0x18743BC70", Slot = "28")]
	public void HCKPPKEMPAH(bool BIHLPJIDCPI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x743D430", Offset = "0x743C630", VA = "0x18743D430", Slot = "30")]
	public void KGGHHHEGNPN(bool BIHLPJIDCPI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x7439560", Offset = "0x7438760", VA = "0x187439560")]
	private void DGOLMNFCJKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x74391B0", Offset = "0x74383B0", VA = "0x1874391B0")]
	private void BLMNAKBHHKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x743F4D0", Offset = "0x743E6D0", VA = "0x18743F4D0", Slot = "25")]
	public void NEJGGLAPGPA(AvatarFaceShape HIHFLIMLNAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x743F410", Offset = "0x743E610", VA = "0x18743F410", Slot = "26")]
	public void NCIKJJLEGPK(AvatarBodyShape HAANFMKKEGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x13EDBD0", Offset = "0x13ECDD0", VA = "0x1813EDBD0", Slot = "31")]
	public void DMEGIAMLANC(MKBBPKEHLCL OIMBBJJFICP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7436120", Offset = "0x7435320", VA = "0x187436120", Slot = "33")]
	public void ABJOBHHPGKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7438850", Offset = "0x7437A50", VA = "0x187438850", Slot = "36")]
	public void BEPDMHECFAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x743B4B0", Offset = "0x743A6B0", VA = "0x18743B4B0", Slot = "32")]
	public void GCIJOAFFHJJ(bool CJONAGMJDFE, bool AAMDLCFKKJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x743EF20", Offset = "0x743E120", VA = "0x18743EF20")]
	private void MLKCPDAMPHG(SkinnedMeshRenderer EPOJOBDOFAC, int KADDNMPDABI, Mesh CJONLLGJGEO, List<Material> BNAFBEFIBIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x74401A0", Offset = "0x743F3A0", VA = "0x1874401A0")]
	private static Material OOGAIKMJMAA(Dictionary<FDPNLIIEJJD, Material> MBGPPIFNMEP, Material EFGNFHFGFEI, KIIFJEJNJJE DPFKBPIHFJH, NAFNGOKLEPP AMGIDDIOEEA, OCHNHLJBAPP GPIHEODLCOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7440E00", Offset = "0x7440000", VA = "0x187440E00")]
	private static KIIFJEJNJJE PNAPJCHOIPJ(HAILHKLIACP MMPLJLGLJGA, int ACEOMHNKNFC)
	{
		return default(KIIFJEJNJJE);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x74396B0", Offset = "0x74388B0", VA = "0x1874396B0")]
	private void DNIEJHLCBDN(int DGMNCEHCMDA, Material MDMIJJAMBMD, HAILHKLIACP MMPLJLGLJGA, [Out] Texture2D CMNCEOKACKI, [Out] Vector4 IBKHBBNMANF, [Out] Texture2D HOLKMOFHIIN, [Out] Texture2D OGAPLKAJBHL, [Out] Texture2D CNBNJNIDNND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x743C150", Offset = "0x743B350", VA = "0x18743C150")]
	private void IBFLLBOMABH(int DGMNCEHCMDA, Material MDMIJJAMBMD, HAILHKLIACP MMPLJLGLJGA, [Out] Color FJNKCFIGEIG, [Out] Color CKHPLMFFILE, [Out] Color OJMACNHOPBN, [Out] Color PLEADIFOMEI, [Out] Color PLHAMHNCCDP, [Out] Color IDBMGFOMLLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7440B10", Offset = "0x743FD10", VA = "0x187440B10")]
	private bool PMAFAJIHEAI(Material MDMIJJAMBMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x743C9B0", Offset = "0x743BBB0", VA = "0x18743C9B0")]
	private static Material IKOBAONKEKA(int DGMNCEHCMDA, HBJJFHIJLJA MMPLJLGLJGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x743FAE0", Offset = "0x743ECE0", VA = "0x18743FAE0")]
	private static NAFNGOKLEPP OEJJHILJIGH(HAILHKLIACP MMPLJLGLJGA, int ACEOMHNKNFC)
	{
		return default(NAFNGOKLEPP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x743E800", Offset = "0x743DA00", VA = "0x18743E800")]
	private static void MBMKDBKIAMA(Dictionary<string, List<FDPNLIIEJJD>> INMHGMBPIOL, HAILHKLIACP LMBJBPDGNBA, Material EFGNFHFGFEI, KIIFJEJNJJE IMLCDJMGLCP, NAFNGOKLEPP KFDPGMCILKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x743A180", Offset = "0x7439380", VA = "0x18743A180")]
	private static SkinnedMeshRenderer FCFIDANAKMG(Transform GPGKOFMFEDC, Transform CFDELNPKBIL, SkinnedMeshRenderer[] FBPNFECAIOM, int KADDNMPDABI, LEMEGGAADFP HBBGNKHGPFB, bool IJNFAEOBAJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7442280", Offset = "0x7441480", VA = "0x187442280")]
	public AJDHBHPBHBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x7440630", Offset = "0x743F830", VA = "0x187440630")]
	public void PDAIGIIELDH([In] JJDGBHOOCOI PJGAADAGELL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7439230", Offset = "0x7438430", VA = "0x187439230")]
	public void BLPFNDJDHHM([In] GLDJAABLEOP NMNJGCMKKBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x743B510", Offset = "0x743A710", VA = "0x18743B510", Slot = "5")]
	public void HOKMFNNMMDN(int KADDNMPDABI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x74403C0", Offset = "0x743F5C0", VA = "0x1874403C0", Slot = "10")]
	public void PCILHGEBPKB(GOIEIHKFCEA KFDPGMCILKC, Texture2D GOADEEFLEJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x97D6F0", Offset = "0x97C8F0", VA = "0x18097D6F0")]
	public static bool DAIKAMIHEFI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x743AD80", Offset = "0x7439F80", VA = "0x18743AD80", Slot = "11")]
	public bool FIDIHFLKHDK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x743A980", Offset = "0x7439B80", VA = "0x18743A980", Slot = "9")]
	public void FHIMPCCCGHA(PMIBLKPEJKC IMLCDJMGLCP, Color? JLNFDAODDKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x743F7E0", Offset = "0x743E9E0", VA = "0x18743F7E0")]
	private void NMDGHJDDJBO(Action DBAJEMCIOIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x743E6A0", Offset = "0x743D8A0", VA = "0x18743E6A0", Slot = "6")]
	public void LDBEEOMGKPC(JCNHDNCLCIK GJEPDIBGLJH, Texture ONFAPBFDABD, Color KJAAOIGMECN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x74392B0", Offset = "0x74384B0", VA = "0x1874392B0", Slot = "7")]
	public void PCNAIPCOHOK(bool EICOJLKCCCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x1A2EE30", Offset = "0x1A2E030", VA = "0x181A2EE30", Slot = "8")]
	public void BFLFJNCLHFN(LFIOEJONFIO BNHLGDBCCDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x743BF50", Offset = "0x743B150", VA = "0x18743BF50", Slot = "16")]
	public void HKICOJPGJID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x743A3B0", Offset = "0x74395B0", VA = "0x18743A3B0", Slot = "34")]
	public void FDJDIMLCDNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x743D860", Offset = "0x743CA60", VA = "0x18743D860", Slot = "35")]
	public void KPGEEAKIHKA([Optional] FJJMJDFJPJG EHNIJMNMNAM, [Optional] bool? OMHDHOEFNLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x7439E70", Offset = "0x7439070", VA = "0x187439E70")]
	private bool EIKBBNIKDDO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x743BF30", Offset = "0x743B130", VA = "0x18743BF30", Slot = "21")]
	public bool HJKEDKIMHNP(LHOPHOECLDF.PDNJAPAFAJM JGFFAFKCIPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x743AF60", Offset = "0x743A160", VA = "0x18743AF60")]
	private void FNJHJHALAJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x743D1E0", Offset = "0x743C3E0", VA = "0x18743D1E0")]
	private void JNPKCJFDIMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x743EC40", Offset = "0x743DE40", VA = "0x18743EC40")]
	private static void MKKLEEHHMJM(Dictionary<FDPNLIIEJJD, Material> MBGPPIFNMEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x743F2B0", Offset = "0x743E4B0", VA = "0x18743F2B0")]
	private static void MPEMHOENLFG(Dictionary<Renderer, MEKDMIMMDLJ> MKGBBDJCHOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x743BB50", Offset = "0x743AD50", VA = "0x18743BB50")]
	private void HAOGDLFMFIA(SkinnedMeshRenderer[] FBPNFECAIOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x7436080", Offset = "0x7435280", VA = "0x187436080")]
	private void ABHHPMKJCGJ(SkinnedMeshRenderer MEFKAPPLHEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x7438E70", Offset = "0x7438070", VA = "0x187438E70")]
	private void BGBDFHMGJHG(List<DIPMDJLELCL> MFHPFJEJFHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x743EDA0", Offset = "0x743DFA0", VA = "0x18743EDA0")]
	private void MKLBIINJHCO(Dictionary<string, CAFFOJNOKAH<Texture2D>> INMHGMBPIOL, bool HOBBCFPJFJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x74405E0", Offset = "0x743F7E0", VA = "0x1874405E0")]
	private void PCNLKECAICN(Dictionary<string, List<FDPNLIIEJJD>> INMHGMBPIOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x743D000", Offset = "0x743C200", VA = "0x18743D000")]
	private void JKCKLEPMIJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x74366A0", Offset = "0x74358A0", VA = "0x1874366A0")]
	private void AODPJCIFCBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x743CA00", Offset = "0x743BC00", VA = "0x18743CA00")]
	private void IOHLMNHEBBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x743BD00", Offset = "0x743AF00", VA = "0x18743BD00")]
	private void HGLJCLHIPNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x743D150", Offset = "0x743C350", VA = "0x18743D150")]
	private void JNJNCNPPGPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x743A410", Offset = "0x7439610", VA = "0x18743A410")]
	private void FEOEEKIHDKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x74395E0", Offset = "0x74387E0", VA = "0x1874395E0")]
	private void DIJALPFPEFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x743FA00", Offset = "0x743EC00", VA = "0x18743FA00")]
	private void OCALLBBNMHF(bool JKJOPFLHHHG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x743BE60", Offset = "0x743B060", VA = "0x18743BE60")]
	private void HIJEPLLPHCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x743D350", Offset = "0x743C550", VA = "0x18743D350")]
	private void KBCGFDOFGHE(bool JKJOPFLHHHG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x743C610", Offset = "0x743B810", VA = "0x18743C610")]
	private void ICEGFDDKOGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x743FC30", Offset = "0x743EE30", VA = "0x18743FC30")]
	private void OGNBINMICCJ(Material BGBKGHHFFCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x743F890", Offset = "0x743EA90", VA = "0x18743F890")]
	private void OALBICOMHGF(Material BGBKGHHFFCI, Color AFLELGACFJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x743F070", Offset = "0x743E270", VA = "0x18743F070")]
	private void MNOEFDCFIPE(Material BGBKGHHFFCI, Color AFLELGACFJG, Color CKIPBGMFLLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x743EAB0", Offset = "0x743DCB0", VA = "0x18743EAB0")]
	private void MGCMKMOIMDF(Material BGBKGHHFFCI, Color FJNKCFIGEIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x7439B10", Offset = "0x7438D10", VA = "0x187439B10")]
	private void ECBGFFDMJNJ(Material BGBKGHHFFCI, Texture2D GOADEEFLEJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x743D1F0", Offset = "0x743C3F0", VA = "0x18743D1F0")]
	private void JOEJLEPJMBL(Material BGBKGHHFFCI, Texture ADFCDCAMPLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x7439050", Offset = "0x7438250", VA = "0x187439050")]
	private void BJFPANLAPIE(Action<MEKDMIMMDLJ> JCMBKOOLBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x743D490", Offset = "0x743C690", VA = "0x18743D490")]
	private void KJCDNLJGMMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x743A560", Offset = "0x7439760", VA = "0x18743A560")]
	private void FFEMPJLLJAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x7438480", Offset = "0x7437680", VA = "0x187438480")]
	private void BECCEOCHGAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x743B120", Offset = "0x743A320", VA = "0x18743B120")]
	public void FOBDHKGMJKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x7439230", Offset = "0x7438430", VA = "0x187439230", Slot = "4")]
	private void EJGJLBKEAKL([In] GLDJAABLEOP NMNJGCMKKBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x743AEF0", Offset = "0x743A0F0", VA = "0x18743AEF0")]
	[CompilerGenerated]
	private LHBFOPKLGGA FLHGPDAGDGA(HAILHKLIACP FGNDNDOCBOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x7440F00", Offset = "0x7440100", VA = "0x187440F00")]
	[CompilerGenerated]
	private void PNBNKNKNJIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x743BCD0", Offset = "0x743AED0", VA = "0x18743BCD0")]
	[CompilerGenerated]
	private void HFPOMHECDBE(MEKDMIMMDLJ PNEPAOOMCOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x7440300", Offset = "0x743F500", VA = "0x187440300")]
	[CompilerGenerated]
	private void PBFKDJHPJJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x7439AF0", Offset = "0x7438CF0", VA = "0x187439AF0")]
	[CompilerGenerated]
	private void EBFLKGLNOHH(MEKDMIMMDLJ PNEPAOOMCOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x7439D00", Offset = "0x7438F00", VA = "0x187439D00")]
	[CompilerGenerated]
	private void EDEJMKCKHDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x743B4F0", Offset = "0x743A6F0", VA = "0x18743B4F0")]
	[CompilerGenerated]
	private void GHOOAPLJPNH(MEKDMIMMDLJ PNEPAOOMCOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x7440110", Offset = "0x743F310", VA = "0x187440110")]
	[CompilerGenerated]
	private void OJDHDEMFCDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x7439AC0", Offset = "0x7438CC0", VA = "0x187439AC0")]
	[CompilerGenerated]
	private void EALLICBEFEJ(MEKDMIMMDLJ PNEPAOOMCOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x7440D70", Offset = "0x743FF70", VA = "0x187440D70")]
	[CompilerGenerated]
	private void PMIJEDKLCHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x743F860", Offset = "0x743EA60", VA = "0x18743F860")]
	[CompilerGenerated]
	private void NNMOCIEPOKF(MEKDMIMMDLJ PNEPAOOMCOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x743BDD0", Offset = "0x743AFD0", VA = "0x18743BDD0")]
	[CompilerGenerated]
	private void HIBEKHJNMJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x743AF30", Offset = "0x743A130", VA = "0x18743AF30")]
	[CompilerGenerated]
	private void FMHAAHKMKBC(MEKDMIMMDLJ PNEPAOOMCOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x743F750", Offset = "0x743E950", VA = "0x18743F750")]
	[CompilerGenerated]
	private void NLKEEAFGDGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x743CFD0", Offset = "0x743C1D0", VA = "0x18743CFD0")]
	[CompilerGenerated]
	private void JBBEFAOOCNB(MEKDMIMMDLJ PNEPAOOMCOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x743C930", Offset = "0x743BB30", VA = "0x18743C930")]
	[CompilerGenerated]
	private void IEPDOIHIJIF(KeyValuePair<string, CAFFOJNOKAH<Texture2D>> FFKJOAKBCNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x7439440", Offset = "0x7438640", VA = "0x187439440")]
	[CompilerGenerated]
	private void DECFJBBEILN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x7439FB0", Offset = "0x74391B0", VA = "0x187439FB0")]
	[CompilerGenerated]
	private void EPGNAJBGALH(MEKDMIMMDLJ PNEPAOOMCOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x7439430", Offset = "0x7438630", VA = "0x187439430")]
	[CompilerGenerated]
	private void CNOLCMIKKFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x743B4C0", Offset = "0x743A6C0", VA = "0x18743B4C0")]
	[CompilerGenerated]
	private void GEHMDNOPNIG(MEKDMIMMDLJ PNEPAOOMCOF)
	{
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class AvatarElbowBendHelperController : MonoBehaviour, HAMJLODNHGB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		[SerializeField]
		[KPPBIEPJJJL(ADOEJJMOABO.Self, false, false, false)]
		private Transform ElbowHelperBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		[SerializeField]
		private Transform UpperArmBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		[SerializeField]
		private Transform LowerArmBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		[SerializeField]
		private float MinAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		[SerializeField]
		private float MaxAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		[Header("Scale")]
		[FormerlySerializedAs("MinScaleValues")]
		[SerializeField]
		private Vector3 ScaleValuesAtMinAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		[FormerlySerializedAs("MaxScaleValues")]
		[SerializeField]
		private Vector3 ScaleValuesAtMaxAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		[Header("Positional Offset")]
		[FormerlySerializedAs("MinLocalPositionalOffset")]
		[SerializeField]
		private Vector3 PositionalOffsetAtMinAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		[FormerlySerializedAs("MaxLocalPositionOffset")]
		[SerializeField]
		private Vector3 PositionalOffsetAtMaxAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		private Vector3? DCEPCJKIGBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private bool GDHLMHEMHPF;

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x7442AD0", Offset = "0x7441CD0", VA = "0x187442AD0", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x74430F0", Offset = "0x74422F0", VA = "0x1874430F0", Slot = "4")]
		public void UpdateController(float JMHDFCLJGBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0xB52D70", Offset = "0xB51F70", VA = "0x180B52D70", Slot = "6")]
		public void SetEnabled(bool OMFJNFBDJCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x7442BB0", Offset = "0x7441DB0", VA = "0x187442BB0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x74435B0", Offset = "0x74427B0", VA = "0x1874435B0")]
		public AvatarElbowBendHelperController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class AvatarElbowBendTargetController : MonoBehaviour, HAMJLODNHGB
	{
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private const float BDIKJJIMONJ = 45f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		[SerializeField]
		[KPPBIEPJJJL(ADOEJJMOABO.Self, false, false, false)]
		private Transform ElbowBendTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		[SerializeField]
		private Transform NeckBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		[SerializeField]
		private Transform UpperArmBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		[SerializeField]
		private Transform HandBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		[SerializeField]
		private bool Left;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		[SerializeField]
		private float MinTwist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		[SerializeField]
		private float MaxTwist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		[SerializeField]
		private float TwistWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		[SerializeField]
		private float ElbowSmoothTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		[SerializeField]
		private float RestTwist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		[SerializeField]
		private float RestTwistWhenClose;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		[SerializeField]
		private float RestTwistDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		private Vector3 AHFGDKFKKCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		private Vector3 CFEBLPFGIHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		private bool GDHLMHEMHPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		private float IKGPFJFEGEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		private float KOLDJKCPIOB;

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x7443930", Offset = "0x7442B30", VA = "0x187443930", Slot = "4")]
		public void UpdateController(float JMHDFCLJGBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0xFFAFE0", Offset = "0xFFA1E0", VA = "0x180FFAFE0", Slot = "6")]
		public void SetEnabled(bool OMFJNFBDJCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x7443650", Offset = "0x7442850", VA = "0x187443650")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x74443F0", Offset = "0x74435F0", VA = "0x1874443F0")]
		public AvatarElbowBendTargetController()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class PFPPBPEEKPK : EIDCFIKENAJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private static readonly int HIHOFKKECHL;

	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private static readonly int NIDEPPKKMPI;

	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private static readonly int PDEBIOKKIBM;

	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private static readonly int PNEKMIDEPNA;

	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private static readonly int CDJLJDLJAOP;

	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private static readonly int MLHBALKPNIO;

	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private static readonly int LNHMLHPPDCE;

	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private static readonly int IMGAEIFBFOC;

	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private static readonly int DPOEBAALPFA;

	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private static readonly int OHHEDFJKCOM;

	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private static readonly int NIHPLGHAONC;

	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private static readonly int NLKPKKGOKMO;

	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private static readonly int JBPHBOHCFFE;

	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private static readonly int CCMNBAIJAIG;

	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private static readonly int GCEFNBMLCEI;

	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private static readonly int FPBFEIAIBLL;

	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private static readonly int EPGIDKGAJII;

	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private static readonly int OABDOACBLJM;

	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private static readonly int PPGBPEKFMML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private Transform GHGOEJKNBPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private Transform ECFKIDLAKED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private Transform HHBHNHGHGDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private Transform PGCCFOGOGDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private Transform EHIJEALIPDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private Transform CILGPDBIGGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	private Transform AANHOKGGJNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	private LIDPOGBHMII GLHKOCGNGIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	private Material BDKIPOOLFCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	private SkinnedMeshRenderer[] DCOJHOOMMFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private readonly List<Material> BMLIJIHDNPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	private AONHDHEBBAB HENMEJODEHP;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public MIOEGIOIKAG JIDJLKOPPDL
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x964520", Offset = "0x963720", VA = "0x180964520", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	private AONHDHEBBAB PDCAIKCLAHO
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x744B3F0", Offset = "0x744A5F0", VA = "0x18744B3F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool OBBODMNOFFK
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x744A120", Offset = "0x7449320", VA = "0x18744A120", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x744C0C0", Offset = "0x744B2C0", VA = "0x18744C0C0")]
	public void PDAIGIIELDH([In] LIDPOGBHMII CEKOKBEAHGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x744B350", Offset = "0x744A550", VA = "0x18744B350")]
	public void NKGOBLGKJIJ([In] BNDENANPNPM MIFEOHCLCHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x744B470", Offset = "0x744A670", VA = "0x18744B470", Slot = "6")]
	public void MFDJCMMPIPK(JOBMFOONMEJ JENJJLGGFPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x744A3B0", Offset = "0x74495B0", VA = "0x18744A3B0")]
	private Vector2 FMFPKBMPNPD(Vector2 FNBKGHMGJGI)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x744A410", Offset = "0x7449610", VA = "0x18744A410")]
	public void GHACHNCNJBI([In] CNAHKIMNGOM MIFEOHCLCHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x744B970", Offset = "0x744AB70", VA = "0x18744B970")]
	private void NPKEIAHKBLO(OAGBJLJEEOE PFKHJCEFJJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x744BD30", Offset = "0x744AF30", VA = "0x18744BD30")]
	private void PBPCJNEFMOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x744A340", Offset = "0x7449540", VA = "0x18744A340")]
	private void HNJNLDEGPPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x744A340", Offset = "0x7449540", VA = "0x18744A340", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x744C4C0", Offset = "0x744B6C0", VA = "0x18744C4C0")]
	public PFPPBPEEKPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x744B350", Offset = "0x744A550", VA = "0x18744B350", Slot = "5")]
	private void JDBCBPDCAGN([In] BNDENANPNPM MIFEOHCLCHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x744A330", Offset = "0x7449530", VA = "0x18744A330", Slot = "7")]
	private void DMLNONBBHKG([In] CNAHKIMNGOM MIFEOHCLCHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x744C190", Offset = "0x744B390", VA = "0x18744C190")]
	[CompilerGenerated]
	internal static float PJAPJNEKMEI(float OMFJNFBDJCA, float ONFBOIMHMFP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x744A2A0", Offset = "0x74494A0", VA = "0x18744A2A0")]
	[CompilerGenerated]
	internal static (float, float) BJNLOPHPPIH(float LHMLJOJCHMH)
	{
		return default((float, float));
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x744B930", Offset = "0x744AB30", VA = "0x18744B930")]
	[CompilerGenerated]
	internal static Vector4 NAGMOFMNFMD(Vector2 LBPAIJGCICL, Vector2 DIOKPOCPBHH)
	{
		return default(Vector4);
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class AvatarForearmRollController : MonoBehaviour, HAMJLODNHGB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		[SerializeField]
		private Transform TwistBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		[SerializeField]
		private Transform HandBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		[SerializeField]
		private Transform LowerArmTwistBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		[SerializeField]
		private Transform UpperArmTwistBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		[SerializeField]
		private Transform ElbowTwistBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		[SerializeField]
		private float RollTowardsWristAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		[SerializeField]
		private float RollSoftMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		[SerializeField]
		private float RollSoftMax;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		[SerializeField]
		private float LowerArmTwistAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		[SerializeField]
		private float UpperArmTwistAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		[SerializeField]
		private float ElbowTwistAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		private float IKGPFJFEGEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		private bool GDHLMHEMHPF;

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x744D600", Offset = "0x744C800", VA = "0x18744D600", Slot = "4")]
		public void UpdateController(float JMHDFCLJGBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x14D2B90", Offset = "0x14D1D90", VA = "0x1814D2B90", Slot = "6")]
		public void SetEnabled(bool OMFJNFBDJCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x744E080", Offset = "0x744D280", VA = "0x18744E080")]
		public AvatarForearmRollController()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public class AvatarHandDisplaySettings
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200002A")]
		public class AnimationOverride
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400016C")]
			[Tooltip("Name of animation original state to override")]
			public string OriginalName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400016D")]
			[Tooltip("Name of animation state to use as an override")]
			public string OverrideName;

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
			public AnimationOverride()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		[SerializeField]
		private AnimationOverride[] HandStateOverrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		private Dictionary<int, int> _animationOverrides;

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x744E0B0", Offset = "0x744D2B0", VA = "0x18744E0B0")]
		public void EMBIHAFPMPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x744E1D0", Offset = "0x744D3D0", VA = "0x18744E1D0")]
		public int HCCGJFBHDHD(int HMALIAKMOFF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public AvatarHandDisplaySettings()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class INBOMMMFAFB : GNCKNEGDAMF
{
	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x74564B0", Offset = "0x74556B0", VA = "0x1874564B0", Slot = "22")]
	public override float ILNHIGGNKPJ()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x7456500", Offset = "0x7455700", VA = "0x187456500")]
	public INBOMMMFAFB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class GNCKNEGDAMF : CPPODONDALD
{
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	private static int CIOFMNCAFPE;

	[Cpp2IlInjected.Token(Token = "0x400016F")]
	private static int KEJLKINCDLK;

	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private static int AKDIBGCDGLI;

	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private static int BLHHELENFHD;

	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private static int MGNGKCOACPG;

	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private static int OFDILECKMIA;

	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private static int EHPCGOFKODJ;

	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private static int[] FAKELKHNGGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private GELLFOBOELB GLHKOCGNGIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	private OLJDBGPHCEI FACDMHBPGFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	private int GFPBIKELIFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	private float IFICBLGDKJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	protected Animator LACLBOFJHFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	protected bool OBJJHHBMGIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	protected AvatarConfiguration CKFIPDHLMFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	protected int ENKGEACODLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	private int FEHAHJPDBDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	private int DAGJNCHPIEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	private bool LEKCLEHADJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private HLOEDBDLCNI NEGBINDAMCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	private int MIMPGEKKBBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	private float HLKHNCDFMIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	private AvatarHandDisplaySettings MBFOCINBJJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	private KJAEMCJAGMO CJBGFLJFKAD;

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public Transform KHNBHPFMFLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x964520", Offset = "0x963720", VA = "0x180964520")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x964780", Offset = "0x963980", VA = "0x180964780")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public Vector3 HMOBBMBOFFC
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x14BB8D0", Offset = "0x14BAAD0", VA = "0x1814BB8D0")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x14BB920", Offset = "0x14BAB20", VA = "0x1814BB920")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public Quaternion NIHJBOFEDIP
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0xC20F70", Offset = "0xC20170", VA = "0x180C20F70")]
		[CompilerGenerated]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0xDE17F0", Offset = "0xDE09F0", VA = "0x180DE17F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool DFLMHHCMOJA
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x7452260", Offset = "0x7451460", VA = "0x187452260")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x74524E0", Offset = "0x74516E0", VA = "0x1874524E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public Vector3 PMIHGPCKKJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x7452510", Offset = "0x7451710", VA = "0x187452510", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x74526D0", Offset = "0x74518D0", VA = "0x1874526D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public Quaternion AMNJEEOJEGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x7452010", Offset = "0x7451210", VA = "0x187452010", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x7451BD0", Offset = "0x7450DD0", VA = "0x187451BD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public LJHHNJNPPBE BNDEELKHMHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0xAA7250", Offset = "0xAA6450", VA = "0x180AA7250", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return default(LJHHNJNPPBE);
		}
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0xAA6CB0", Offset = "0xAA5EB0", VA = "0x180AA6CB0", Slot = "4")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public LJHHNJNPPBE GFGEMLNHMPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x228ADC0", Offset = "0x2289FC0", VA = "0x18228ADC0", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return default(LJHHNJNPPBE);
		}
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x2289660", Offset = "0x2288860", VA = "0x182289660", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public float JKFBIFOKANK
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x1302970", Offset = "0x1301B70", VA = "0x181302970", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0xDF7AB0", Offset = "0xDF6CB0", VA = "0x180DF7AB0", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public bool PFCDBDOFEOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x7452250", Offset = "0x7451450", VA = "0x187452250")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public bool HDGCJHMBDLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x74522F0", Offset = "0x74514F0", VA = "0x1874522F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool JELCBDDKEAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x7451F60", Offset = "0x7451160", VA = "0x187451F60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public bool HAADBNOLMJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x74521F0", Offset = "0x74513F0", VA = "0x1874521F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x7452530", Offset = "0x7451730", VA = "0x187452530", Slot = "21")]
	public void PDAIGIIELDH(GELLFOBOELB CEKOKBEAHGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x74526F0", Offset = "0x74518F0", VA = "0x1874526F0")]
	public void PNBJDODGFML(OLJDBGPHCEI JELKJGHFJKB, AvatarHandDisplaySettings KNCIOLDEMIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x7451F70", Offset = "0x7451170", VA = "0x187451F70", Slot = "12")]
	public void EFFEDAPAADH(bool ADOLAHFFGEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x7451BE0", Offset = "0x7450DE0", VA = "0x187451BE0", Slot = "11")]
	public void CEIFGDBOPCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x1302970", Offset = "0x1301B70", VA = "0x181302970", Slot = "22")]
	public virtual float ILNHIGGNKPJ()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x7452020", Offset = "0x7451220", VA = "0x187452020")]
	private int JEMCOBDPCLD(LJHHNJNPPBE IKOLDLKBFEC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x7452300", Offset = "0x7451500", VA = "0x187452300")]
	private void MHDCAMDBKNM(int IGFALDMFPBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x74524C0", Offset = "0x74516C0", VA = "0x1874524C0", Slot = "13")]
	public bool NHANACGNLDB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x7452000", Offset = "0x7451200", VA = "0x187452000", Slot = "14")]
	public bool GOKJIBDIKMN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x7452200", Offset = "0x7451400", VA = "0x187452200")]
	private LJHHNJNPPBE KDEEAGMMMDI()
	{
		return default(LJHHNJNPPBE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x1BC3C50", Offset = "0x1BC2E50", VA = "0x181BC3C50", Slot = "15")]
	public void BGBAPOJOAEM(bool ADOLAHFFGEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x7452290", Offset = "0x7451490", VA = "0x187452290", Slot = "10")]
	public void LGMEMPJNJHC(int IGFALDMFPBG, float HHMJIEABGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x74522D0", Offset = "0x74514D0", VA = "0x1874522D0", Slot = "8")]
	public void LLFNPEJJEEJ(HLOEDBDLCNI LEOMHHEDCFC, bool NNBKKFCHIFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x7451F50", Offset = "0x7451150", VA = "0x187451F50", Slot = "9")]
	public void CPNDPMCKIGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x74521A0", Offset = "0x74513A0", VA = "0x1874521A0", Slot = "16")]
	public void JHPLCCJBGHI(Transform JNGEIJHHFEP, Vector3 AGLFFJJMOBJ, Quaternion FLOHBLGOFHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x74529D0", Offset = "0x7451BD0", VA = "0x1874529D0")]
	public GNCKNEGDAMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class HBJJFHIJLJA : HAILHKLIACP
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class OPELDKANEAN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		public HBJJFHIJLJA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		public List<DIPMDJLELCL> prefabHandles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		public List<DIPMDJLELCL> materialHandles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		public CAFFOJNOKAH<Material[]> loadMaterialsHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		public CAFFOJNOKAH<FCFMFJCIPMP> loadPrefabHandle;

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public OPELDKANEAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x745D9A0", Offset = "0x745CBA0", VA = "0x18745D9A0")]
		internal LHBFOPKLGGA MBICIMJKJOE(string error)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	public JCNHDNCLCIK LEFFFFJJJHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	public FCFMFJCIPMP KEAGDNNCOEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	private CAFFOJNOKAH<FCFMFJCIPMP> MMJMDACMKEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	private CAFFOJNOKAH<Material[]> FMHKACHDPBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	public Material[] BNKLDHGKDKE;

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public bool AIMBEALKKAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x990150", Offset = "0x98F350", VA = "0x180990150")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x98FED0", Offset = "0x98F0D0", VA = "0x18098FED0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public LHOPHOECLDF.PDNJAPAFAJM AHANEJBIGHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x964F30", Offset = "0x964130", VA = "0x180964F30")]
		[CompilerGenerated]
		get
		{
			return default(LHOPHOECLDF.PDNJAPAFAJM);
		}
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x96EC10", Offset = "0x96DE10", VA = "0x18096EC10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x7453D90", Offset = "0x7452F90", VA = "0x187453D90")]
	public HBJJFHIJLJA(OCHNHLJBAPP PAJCAJDCMMO, JCNHDNCLCIK AGFNJGKKJFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x7452C70", Offset = "0x7451E70", VA = "0x187452C70", Slot = "6")]
	public override LHBFOPKLGGA GFPJKHKOLEM(List<DIPMDJLELCL> PABLELPNMNM, List<DIPMDJLELCL> MNPGNNGNHOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x7453A30", Offset = "0x7452C30", VA = "0x187453A30")]
	public LHBFOPKLGGA PAJIKOHIEHE(List<DIPMDJLELCL> PABLELPNMNM, List<DIPMDJLELCL> MNPGNNGNHOM, CAFFOJNOKAH<Material[]> FMHKACHDPBG, [Optional] CAFFOJNOKAH<FCFMFJCIPMP> GPOMBAJELIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x7453270", Offset = "0x7452470", VA = "0x187453270")]
	public (CAFFOJNOKAH<Material[]>, CAFFOJNOKAH<FCFMFJCIPMP>) MMNBACBIOCF(List<DIPMDJLELCL> PABLELPNMNM, List<DIPMDJLELCL> MNPGNNGNHOM)
	{
		return default((CAFFOJNOKAH<Material[]>, CAFFOJNOKAH<FCFMFJCIPMP>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x7453120", Offset = "0x7452320", VA = "0x187453120", Slot = "7")]
	public override MNJBDICHJBL KAKPICLEIMM(uint KADDNMPDABI, AvatarSkinnedMeshBoneOrderRemapsData ALMFCKJJPKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x7452A60", Offset = "0x7451C60", VA = "0x187452A60")]
	public MNJBDICHJBL FJCICJFGPKD(GameObject CJFKKJCHCIP, uint KADDNMPDABI, bool AHKPCFNGNGI, bool PAAGPDNPDIO, AvatarSkinnedMeshBoneOrderRemapsData ALMFCKJJPKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x74536D0", Offset = "0x74528D0", VA = "0x1874536D0")]
	public static bool NAJIPHCLBOM(Renderer[] FBPNFECAIOM, string OAMOCNFLNHG, [Out] Renderer CEGKCDLKOOE, [Out] Renderer ELKAINLDOMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x7453D40", Offset = "0x7452F40", VA = "0x187453D40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x7453600", Offset = "0x7452800", VA = "0x187453600")]
	private (CAFFOJNOKAH<FCFMFJCIPMP>, CAFFOJNOKAH<Material[]>) MPGNFEMGEOO()
	{
		return default((CAFFOJNOKAH<FCFMFJCIPMP>, CAFFOJNOKAH<Material[]>));
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x7453250", Offset = "0x7452450", VA = "0x187453250")]
	[CompilerGenerated]
	private void LIBLBACMGHG(FCFMFJCIPMP CMLOHOMLNDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x961660", Offset = "0x960860", VA = "0x180961660")]
	[CompilerGenerated]
	private void EMKMFOCOAAB(Material[] CMLOHOMLNDL)
	{
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public class AvatarKneeBendTargetController : MonoBehaviour, HAMJLODNHGB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		[SerializeField]
		[KPPBIEPJJJL(ADOEJJMOABO.Self, false, false, false)]
		private Transform KneeBendTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		[SerializeField]
		private Transform RootSpineBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		[SerializeField]
		private Transform ThighBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		[SerializeField]
		private Transform FootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		[SerializeField]
		private float WeightToFootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		[SerializeField]
		private Vector3 BendTargetOffsetFromHipToFootMidPoint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		[SerializeField]
		private Bounds KneeTargetConstrainedBox;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		private Vector3 AHFGDKFKKCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		private Vector3 HNPMKHBIDBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		private Vector3 CBOHGNPEBAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		private Matrix4x4 JNCHOOCIBCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		private bool GDHLMHEMHPF;

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x744E6B0", Offset = "0x744D8B0", VA = "0x18744E6B0", Slot = "4")]
		public void UpdateController(float JMHDFCLJGBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x744E6A0", Offset = "0x744D8A0", VA = "0x18744E6A0", Slot = "6")]
		public void SetEnabled(bool OMFJNFBDJCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x744E240", Offset = "0x744D440", VA = "0x18744E240")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x744ED70", Offset = "0x744DF70", VA = "0x18744ED70")]
		public AvatarKneeBendTargetController()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[ALDPDJHMICB]
public struct KOAFNAADJDB : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	[ReadOnly]
	public IJPINHBEHCL PLHACJMEGPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	[ReadOnly]
	public int DILDJBEKPIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	public NCCFCLBBEJJ JBKBLFKGLCF;

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x74572B0", Offset = "0x74564B0", VA = "0x1874572B0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[NativeContainer]
[ALDPDJHMICB]
public struct NCCFCLBBEJJ : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	public NativeArray<Vector3> HLPFGEDNMLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	public NativeArray<Vector3> DHMMABEGPCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	public NativeArray<Vector4> HJMODDLPPCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	public NativeArray<Vector2> COELIICNKMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	public NativeArray<Vector2> INEOKHIIMPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	public NativeArray<Vector2> BHPJFNKAFEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	public NativeArray<Vector2> MKJHMDHHFNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	public NativeArray<Color> DNMLFCEFJGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	public NativeArray<int> DMPMHLMJBPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	public NativeArray<int> HBDINGOAHJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	private NativeArray<int> PNIOHGKDPMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	private NativeArray<int> OEJLFOLFGCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	public NativeArray<int> LBKPKOMHIAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	public NativeArray<int> AFFOIHACOAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	public NativeArray<int> FEFACPKMOEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	public NativeArray<BoneWeight> NEGHJJBDHEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	private NativeArray<int> BNHLGDBCCDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	private bool BDELFOAOOCO;

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public int DGFKEIKJCEA
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x745BC70", Offset = "0x745AE70", VA = "0x18745BC70")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x745BFF0", Offset = "0x745B1F0", VA = "0x18745BFF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public int MCCAGBNPBNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x745BD60", Offset = "0x745AF60", VA = "0x18745BD60")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x745BAA0", Offset = "0x745ACA0", VA = "0x18745BAA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public int PMPGFOILDBH
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x745BD50", Offset = "0x745AF50", VA = "0x18745BD50")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x745BC60", Offset = "0x745AE60", VA = "0x18745BC60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x745C000", Offset = "0x745B200", VA = "0x18745C000")]
	public NCCFCLBBEJJ(int GLNPICAEGCC, int ENKLLGHGADN, int ONOEKEMEAEM, int PMBFNKDJDLL, Allocator JNKCCGKBKPB, int DIAKOBOIBBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x745BED0", Offset = "0x745B0D0", VA = "0x18745BED0")]
	public void MKOLFLLNMAK(int KOOLKCPAFBB, Vector3 OKAELCMAFHA, Vector3 NEFHNGEGIGC, Vector4 FDDEDLKEPIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x745B900", Offset = "0x745AB00", VA = "0x18745B900")]
	public void BDNPCJPHIDK(int KOOLKCPAFBB, BoneWeight KDLGFLNPLMN, NativeSlice<byte> NAIGDGBKDKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x745BEB0", Offset = "0x745B0B0", VA = "0x18745BEB0")]
	public Color MCIMJMFGOGF(int KOOLKCPAFBB)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x745BDD0", Offset = "0x745AFD0", VA = "0x18745BDD0")]
	public void JHIMLBMOHMK(int KOOLKCPAFBB, Color CPCFIJBFPJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x745BD80", Offset = "0x745AF80", VA = "0x18745BD80")]
	public void GJKOOANPPCD(byte KJFLIKNIGLM, int KOOLKCPAFBB, Vector2 CDKBLKPMKKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x745BD70", Offset = "0x745AF70", VA = "0x18745BD70")]
	public void GEBCOFBKNKC(int KOOLKCPAFBB, int JNFDLDEJOPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x745BDF0", Offset = "0x745AFF0", VA = "0x18745BDF0")]
	public bool KDGKMPJIGFA(int KJFLIKNIGLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x745BC80", Offset = "0x745AE80", VA = "0x18745BC80")]
	public void EMDICFPAFFG(int KBNCKPFMHIH, int DCNPLBBIONO, int EEBDBIBAAFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x745BF40", Offset = "0x745B140", VA = "0x18745BF40")]
	public int[] NCFCJLMIPCL(int KBNCKPFMHIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x745BE20", Offset = "0x745B020", VA = "0x18745BE20")]
	private NativeSlice<int> KKMEKGKMNHJ(int KBNCKPFMHIH)
	{
		return default(NativeSlice<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x745BAB0", Offset = "0x745ACB0", VA = "0x18745BAB0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x745B5B0", Offset = "0x745A7B0", VA = "0x18745B5B0")]
	public Mesh AIKFBCEJJOA([Optional] string CAKHFJDLLPN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[NativeContainer]
[DefaultMember("Item")]
[ALDPDJHMICB]
public struct IJPINHBEHCL : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	public NativeArray<Vector3> HLPFGEDNMLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	public NativeArray<Vector3> DHMMABEGPCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	public NativeArray<Vector4> HJMODDLPPCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	public NativeArray<Vector2> COELIICNKMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	public NativeArray<Vector2> INEOKHIIMPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	public NativeArray<Vector2> BHPJFNKAFEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	public NativeArray<Vector2> MKJHMDHHFNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	public NativeArray<Color> DNMLFCEFJGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	public NativeArray<int> CMBOPALIEPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	public NativeArray<int> NMMNOJHLBIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	public NativeArray<int> AEJKHEGILNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	public NativeArray<int> MIHKANGMBOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	public NativeArray<bool> CPJFHANIEMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	public NativeArray<int> CBDGCFPMAHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	public NativeArray<int> FENJECILFIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	public NativeArray<BoneWeight> CJCAIPLKDNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	private NativeArray<Matrix4x4> DGJOPAICLEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	private NativeArray<long> DIADAIDMBNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	private NativeArray<byte> EIFCMNINHEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	private NativeArray<int> CCDHFEIPJNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	private NativeArray<int> PGMFBFLMJLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	public NativeArray<sbyte> IJEKENCHCCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	public NativeArray<byte> MPKFJIELMPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	private NativeArray<int> PFPOMGKPMNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	private bool BDELFOAOOCO;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public int PMIFAECFMLL
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x25BDAC0", Offset = "0x25BCCC0", VA = "0x1825BDAC0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public int IADFCPOPALM
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0xB55F80", Offset = "0xB55180", VA = "0x180B55F80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public int BHGHFNKAGNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x7454580", Offset = "0x7453780", VA = "0x187454580")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public int EAOCGFDEHBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x74545B0", Offset = "0x74537B0", VA = "0x1874545B0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x7454B10", Offset = "0x7453D10", VA = "0x187454B10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public int DGFKEIKJCEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x7454570", Offset = "0x7453770", VA = "0x187454570")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x7454B30", Offset = "0x7453D30", VA = "0x187454B30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public int DFNFFJNMJIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x74542E0", Offset = "0x74534E0", VA = "0x1874542E0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x7454B00", Offset = "0x7453D00", VA = "0x187454B00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public BLMBBPOKJAO LIFMKAFJKNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x7454B20", Offset = "0x7453D20", VA = "0x187454B20")]
		get
		{
			return default(BLMBBPOKJAO);
		}
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x74542F0", Offset = "0x74534F0", VA = "0x1874542F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public byte LKBADKEEFDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x7454AF0", Offset = "0x7453CF0", VA = "0x187454AF0")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x74542D0", Offset = "0x74534D0", VA = "0x1874542D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public LMEJNLEKAKG EPCJHJAGLJO
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x74545C0", Offset = "0x74537C0", VA = "0x1874545C0")]
		get
		{
			return default(LMEJNLEKAKG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x7454C10", Offset = "0x7453E10", VA = "0x187454C10")]
	public IJPINHBEHCL(IList<Mesh> IPMIEOJADNO, IList<Matrix4x4> ABAMGDCKBOO, IList<bool> CPJFHANIEMP, byte DFLIPJOGBFK, IList<byte[]> EELADDDDBMC, IList<long> MJBEIKNPNPH, IList<bool> FGJGFKJIFAC, IList<int> CBDGCFPMAHH, IList<int> EKIEKAIOCLB, IList<int> NPALLMKFPPN, Allocator JNKCCGKBKPB, BLMBBPOKJAO PPACCKPNLPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x7454B40", Offset = "0x7453D40", VA = "0x187454B40")]
	public NCCFCLBBEJJ OMDJHECDLGI(Allocator JNKCCGKBKPB)
	{
		return default(NCCFCLBBEJJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x7454300", Offset = "0x7453500", VA = "0x187454300", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[ALDPDJHMICB]
public class PLNFPHFAGBF : EEPCDGKFKEA
{
	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x745DBE0", Offset = "0x745CDE0", VA = "0x18745DBE0")]
	public IJPINHBEHCL GGLGPDFFLAO()
	{
		return default(IJPINHBEHCL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x74471E0", Offset = "0x74463E0", VA = "0x1874471E0")]
	public PLNFPHFAGBF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public struct LMEJNLEKAKG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	public NativeSlice<Vector3> HLPFGEDNMLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	public NativeSlice<Vector3> DHMMABEGPCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	public NativeSlice<Vector4> HJMODDLPPCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	public NativeSlice<Vector2> COELIICNKMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	public NativeSlice<Vector2> INEOKHIIMPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	public NativeSlice<Vector2> BHPJFNKAFEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	public NativeSlice<Vector2> MKJHMDHHFNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	public NativeSlice<Color> DNMLFCEFJGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	public NativeSlice<int> OKNGMHEMFMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	public NativeSlice<int> MIHKANGMBOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	public NativeSlice<BoneWeight> CJCAIPLKDNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	public NativeSlice<byte> FCINPFNIOPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001E6")]
	public int JHFBMFCFKKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x40001E7")]
	public Matrix4x4 CJMNHOEBING;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	public long CMLOPFCKCPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	public NativeSlice<byte> NAIGDGBKDKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	public bool KJKJONMLIBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	public int EBIOGBBOJGN;
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal readonly struct FDPNLIIEJJD : IEquatable<FDPNLIIEJJD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001EC")]
	internal readonly Material ECAGAIIDDPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001ED")]
	internal readonly KIIFJEJNJJE OGNLPFDOGFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	internal readonly NAFNGOKLEPP AJHMGAGKGIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001EF")]
	internal readonly OCHNHLJBAPP CIIHACDOPKC;

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x7451740", Offset = "0x7450940", VA = "0x187451740")]
	public FDPNLIIEJJD(Material MDMIJJAMBMD, KIIFJEJNJJE DPFKBPIHFJH, NAFNGOKLEPP AMGIDDIOEEA, OCHNHLJBAPP GPIHEODLCOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x7451510", Offset = "0x7450710", VA = "0x187451510", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x74513F0", Offset = "0x74505F0", VA = "0x1874513F0", Slot = "4")]
	public bool Equals(FDPNLIIEJJD LDKNLBHIGFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x7451300", Offset = "0x7450500", VA = "0x187451300", Slot = "0")]
	public override bool Equals(object ONELFPFEALD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x7451470", Offset = "0x7450670", VA = "0x187451470", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[DisallowMultipleComponent]
	public class AvatarModernBodyDisplayBehaviour : MonoBehaviour, BAAIIIPELKG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		[Header("Configuration")]
		[SerializeField]
		protected AvatarConfiguration configuration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		[SerializeField]
		protected Animator skeletonAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		[SerializeField]
		protected Renderer[] watchRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		[Header("Configuration")]
		[SerializeField]
		private KJAEMCJAGMO avatarBodyType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		[SerializeField]
		private AvatarSkinAssetItem potatoAvatarSkinAssetItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		[FormerlySerializedAs("avatarSkinAsset")]
		[SerializeField]
		private AssetReference avatarSkinAssetReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		[SerializeField]
		private GameObject firstPersonMeshContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		[SerializeField]
		public GameObject thirdPersonMeshContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		[SerializeField]
		private GameObject[] hideInFirstPerson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		[SerializeField]
		protected Transform headAdditiveBaseBoneTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		[SerializeField]
		private Material BodyMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		[SerializeField]
		private Material FaceMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		[SerializeField]
		private Material DefaultAvatarItemMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		[SerializeField]
		private Shader AvatarDefaultShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		[SerializeField]
		private Shader AvatarUberShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		[SerializeField]
		private Transform DeformRigRootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		[SerializeField]
		private SkinnedMeshRenderer BaseSkinnedMeshRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		[SerializeField]
		protected AvatarSkinnedMeshBoneOrderRemapsData BoneOrderRemapsData;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		[Header("Arm Animation Controllers")]
		[SerializeField]
		private AvatarForearmRollController LeftForearmRollController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		[SerializeField]
		private AvatarElbowBendHelperController LeftElbowBendHelperController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		[SerializeField]
		private AvatarElbowBendTargetController LeftElbowBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		[SerializeField]
		private AvatarKneeBendTargetController LeftKneeBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		[SerializeField]
		private AvatarForearmRollController RightForearmRollController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		[SerializeField]
		private AvatarElbowBendHelperController RightElbowBendHelperController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		[SerializeField]
		private AvatarElbowBendTargetController RightElbowBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		[SerializeField]
		private AvatarKneeBendTargetController RightKneeBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		[SerializeField]
		private Transform LeftEyeBrowBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		[SerializeField]
		private Transform LeftEyeBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		[SerializeField]
		private Transform RightEyeBrowBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		[SerializeField]
		private Transform RightEyeBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		[SerializeField]
		private Transform NoseMoveTweakBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		[SerializeField]
		private Transform NoseScaleTweakBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		[SerializeField]
		private Transform MouthBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		[SerializeField]
		private AvatarBodyPartShapesManager avatarBodyPartShapesManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		[SerializeField]
		private Transform HatAnchorBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		[SerializeField]
		private Transform LeftHandWatchAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		[SerializeField]
		private Transform RightHandWatchAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		[SerializeField]
		private GameObject LeftHandWatchVisuals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		[SerializeField]
		private GameObject RightHandWatchVisuals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		private BMAGGMLBMKH JKJOHCMJNBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		private EIDCFIKENAJ EPHPNFIPCIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		private CPPODONDALD CAEGAOAPMBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		private CPPODONDALD BEOIOEAFMKL;

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public BMAGGMLBMKH AGEGJDAJBBH
		{
			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x744FBE0", Offset = "0x744EDE0", VA = "0x18744FBE0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public EIDCFIKENAJ AHMHLAKDHIF
		{
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x744FC30", Offset = "0x744EE30", VA = "0x18744FC30", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public CPPODONDALD DCGHPIACIGP
		{
			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x744FE50", Offset = "0x744F050", VA = "0x18744FE50", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public CPPODONDALD FENJBOAOJGC
		{
			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x744FEA0", Offset = "0x744F0A0", VA = "0x18744FEA0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public Transform CKICFMIEDBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0x744FEF0", Offset = "0x744F0F0", VA = "0x18744FEF0", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public KJAEMCJAGMO HFIFGIEOKLC
		{
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x96EC20", Offset = "0x96DE20", VA = "0x18096EC20", Slot = "12")]
			get
			{
				return default(KJAEMCJAGMO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x744ED80", Offset = "0x744DF80", VA = "0x18744ED80")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x744FA40", Offset = "0x744EC40", VA = "0x18744FA40")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x744F3A0", Offset = "0x744E5A0", VA = "0x18744F3A0", Slot = "8")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x744FA40", Offset = "0x744EC40", VA = "0x18744FA40", Slot = "9")]
		public void TeardownAvatarDisplaySystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x744EDF0", Offset = "0x744DFF0", VA = "0x18744EDF0", Slot = "10")]
		public bool CleanupDisplayMeshes()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x744FAF0", Offset = "0x744ECF0", VA = "0x18744FAF0")]
		public void UpdatePostIKAnimControllers(float JMHDFCLJGBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x744F120", Offset = "0x744E320", VA = "0x18744F120")]
		private void FACDNNIBAMG(GameObject ONELFPFEALD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x744F400", Offset = "0x744E600", VA = "0x18744F400")]
		private BMAGGMLBMKH NIJMLLJPPLM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x744F1B0", Offset = "0x744E3B0", VA = "0x18744F1B0")]
		private EIDCFIKENAJ FNCNBJGFPHD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x744F7B0", Offset = "0x744E9B0", VA = "0x18744F7B0")]
		private CPPODONDALD OCHODLNHDGD(HELPMFJLADN PMFEAPOHPML)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x744FBD0", Offset = "0x744EDD0", VA = "0x18744FBD0")]
		public AvatarModernBodyDisplayBehaviour()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public class MEKDMIMMDLJ : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400021B")]
	private MaterialPropertyBlock OGHJMJDLDFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400021C")]
	public Color? GCEFCGAIJJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	public Color? PBPHKCIDIJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	public Color? CCBODCPCMNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	public Color? FHNCPLKKEOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	public Color HGEKGDFDKBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000221")]
	public Color IALCCDNBIAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	public Color IDDPPNIJNEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	public Texture2D ENNBANJBCDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	public Texture2D CJMJIOIANGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	private Dictionary<FDPNLIIEJJD, int> OOLBNFKLBPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	private KIIFJEJNJJE[] MOAKODEGHEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	private NAFNGOKLEPP[] NKPJDLHKMJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000228")]
	public Vector4[] LCMOHGDHPNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	public Vector4[] FOLOFHOGAEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	public Vector4[] EONECLMHJHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	public Vector4[] HBOCMIKHFHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	public Vector4[] MJDPMLICNGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	public Vector4[] HFNIJGCLPEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	private List<Texture2D> KBBGOGCOIDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	private Vector4[] OGFHBPBCJAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	private List<Texture2D> FEFDNHKGHOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	private float[] BOENCEGOBJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	private Vector4[] BOBGOCMADFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	private float[] LAJJOCAFNEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	public float[] COGCFEFDHCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	private List<Texture2D> HDDKKEDICPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	private float[] CDNNLGBAEIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	private List<Texture2D> IJCIKNHMNAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	private Vector4[] OLOPMLKHCCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	private float[] NFFGLFNLNMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	private Vector4[] OINDNPIMIIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	public float[] JBPEHGMGAID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	public Texture2DArray HFIILBJIKHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	public Texture2DArray FHBPOOFEAHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	public Texture2DArray GGENDOMMHAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	public Texture2DArray NFKBILDDGOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	private bool FJFKABNMGGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x184")]
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	private int ABELEPELGFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x4000242")]
	private Vector2? AAFCOCOMLCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x194")]
	[Cpp2IlInjected.Token(Token = "0x4000243")]
	private TextureFormat PELCNCLFOBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x4000244")]
	private Vector2? HIFINNAEDNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A4")]
	[Cpp2IlInjected.Token(Token = "0x4000245")]
	private TextureFormat GCEONIDCPEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x4000246")]
	private Vector2? IIACJJMNKFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B4")]
	[Cpp2IlInjected.Token(Token = "0x4000247")]
	private TextureFormat OALKBMIIEFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x4000248")]
	private Vector2? MIFFELPHNOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C4")]
	[Cpp2IlInjected.Token(Token = "0x4000249")]
	private TextureFormat DMAKECJBGEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
	[Cpp2IlInjected.Token(Token = "0x400024A")]
	private bool FEHOKBMGFLG;

	[Cpp2IlInjected.Token(Token = "0x400024B")]
	private static int MIIOELEHHGM;

	[Cpp2IlInjected.Token(Token = "0x400024C")]
	private static int LCEOLDINFBG;

	[Cpp2IlInjected.Token(Token = "0x400024D")]
	private static int HMENEDMHGOC;

	[Cpp2IlInjected.Token(Token = "0x400024E")]
	private static int NKCCGCOBINI;

	[Cpp2IlInjected.Token(Token = "0x400024F")]
	private static int KGCELLGJJOD;

	[Cpp2IlInjected.Token(Token = "0x4000250")]
	private static int IFMPGECEHOI;

	[Cpp2IlInjected.Token(Token = "0x4000251")]
	private static int PJGLMGMHBML;

	[Cpp2IlInjected.Token(Token = "0x4000252")]
	private static int MJBCPELIPPP;

	[Cpp2IlInjected.Token(Token = "0x4000253")]
	private static int EIBKOHKNONK;

	[Cpp2IlInjected.Token(Token = "0x4000254")]
	private static int EKMFCAHEEAL;

	[Cpp2IlInjected.Token(Token = "0x4000255")]
	private static int EOFLHBAJPEH;

	[Cpp2IlInjected.Token(Token = "0x4000256")]
	private static int JCFBMDJFJBB;

	[Cpp2IlInjected.Token(Token = "0x4000257")]
	private static int GHCMJGKODFM;

	[Cpp2IlInjected.Token(Token = "0x4000258")]
	private static int ODJFFFIPBFI;

	[Cpp2IlInjected.Token(Token = "0x4000259")]
	private static int FDMPGGNBIHB;

	[Cpp2IlInjected.Token(Token = "0x400025A")]
	private static int GPKELIAAJBM;

	[Cpp2IlInjected.Token(Token = "0x400025B")]
	private static int JJNJJCOOLJG;

	[Cpp2IlInjected.Token(Token = "0x400025C")]
	private static int EDHKCOIBGPI;

	[Cpp2IlInjected.Token(Token = "0x400025D")]
	private static int NJNHJIEHBAN;

	[Cpp2IlInjected.Token(Token = "0x400025E")]
	private static int GCEOMDGCPHA;

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x745B000", Offset = "0x745A200", VA = "0x18745B000")]
	private MEKDMIMMDLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x745B4F0", Offset = "0x745A6F0", VA = "0x18745B4F0")]
	public MEKDMIMMDLJ(Color OKIAKDLMDOK, Color PABPMNJIBFI, Color JEJKMNLJMII, Color? LBONJJCJKMG, Color? OPEAIFLIHIB, Color? EEHBPKPODPE, Texture2D FPFCKEBDJGN, Texture2D JJHOOAKOBCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x74599F0", Offset = "0x7458BF0", VA = "0x1874599F0")]
	internal int FFBAKLFPJCD(Material MFAJMGKEOBO, KIIFJEJNJJE DPFKBPIHFJH, NAFNGOKLEPP AMGIDDIOEEA, OCHNHLJBAPP GPIHEODLCOO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x7459960", Offset = "0x7458B60", VA = "0x187459960")]
	private int FFBAKLFPJCD(FDPNLIIEJJD MBDBONINAPC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x7458BF0", Offset = "0x7457DF0", VA = "0x187458BF0")]
	internal int CIJEALFFIDO(Material MFAJMGKEOBO, Color FJNKCFIGEIG, Color CKHPLMFFILE, Color OJMACNHOPBN, Color PLEADIFOMEI, Color PLHAMHNCCDP, Texture2D MPKOJBFJDFG, Vector4 KHPJIKPBNIC, Texture2D HIAEEEPDHJF, Vector4 IDBFMCLIJCN, float HPMAEKBHOBO, float CIBJAENDLJD, Texture2D PEFDNJBFAFO, Vector4 BEANGOKMGBE, float HJKIDJBNDBF, Texture2D PFOOAODEKBC, Color IDBMGFOMLLP, Vector4 KNILKPKEDCL, KIIFJEJNJJE DPFKBPIHFJH, NAFNGOKLEPP AMGIDDIOEEA, OCHNHLJBAPP GPIHEODLCOO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x7459AE0", Offset = "0x7458CE0", VA = "0x187459AE0")]
	private void GHHADAFHLJP(List<Texture2D> KBBGOGCOIDE, [Out] Texture2DArray JJHNMBNHNKH, [Out] Texture2DArray GCNMEDEMIID, [Out] Texture2DArray NMOGGKEPNKN, [Out] Texture2DArray AFJGFENOENL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x74589F0", Offset = "0x7457BF0", VA = "0x1874589F0")]
	public void AJDOIPAJICC(Shader BCGMEGKGEOH, Renderer MONNLFCGBEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x7459EA0", Offset = "0x74590A0", VA = "0x187459EA0")]
	private void HIDCDNCPDIE(Shader BCGMEGKGEOH, Renderer MONNLFCGBEF, int NAJMPKDICAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x7459CA0", Offset = "0x7458EA0", VA = "0x187459CA0")]
	private Color GIPOOAOOGEE(Color DPPFMNEPKCG, KIIFJEJNJJE IMLCDJMGLCP)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x745AB60", Offset = "0x7459D60", VA = "0x18745AB60")]
	private Color ICHPEFBIAOL(Color EAICFABGGAP, KIIFJEJNJJE IMLCDJMGLCP)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x7459800", Offset = "0x7458A00", VA = "0x187459800")]
	private bool EEEOHNLOGJI(Texture2D KHMMPCPLLEF, NAFNGOKLEPP KFDPGMCILKC, [Out] Texture2D OKFGDAPGOFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x7458B40", Offset = "0x7457D40", VA = "0x187458B40")]
	private void BNEJHILOOOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x74597C0", Offset = "0x74589C0", VA = "0x1874597C0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public abstract class HAILHKLIACP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000262")]
	public readonly OCHNHLJBAPP DKHIKOCMKIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x4000263")]
	protected bool PAIKFDJFJMD;

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public bool PNGLIBAMPKF
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0xB96CC0", Offset = "0xB95EC0", VA = "0x180B96CC0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0xB96CD0", Offset = "0xB95ED0", VA = "0x180B96CD0")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public bool COJAEPNFJFP
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0xB97590", Offset = "0xB96790", VA = "0x180B97590")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0xB97730", Offset = "0xB96930", VA = "0x180B97730")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public virtual LHOPHOECLDF.PDNJAPAFAJM CMLOPFCKCPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x963A50", Offset = "0x962C50", VA = "0x180963A50", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(LHOPHOECLDF.PDNJAPAFAJM);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0xB62B50", Offset = "0xB61D50", VA = "0x180B62B50", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public bool FHHAPCIDAGN
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x11667E0", Offset = "0x11659E0", VA = "0x1811667E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public bool BFMJCGMEEAF
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x7452A20", Offset = "0x7451C20", VA = "0x187452A20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public bool BECBNKGIAAG
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x7452A10", Offset = "0x7451C10", VA = "0x187452A10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public bool GEGBELDLGPA
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x74529F0", Offset = "0x7451BF0", VA = "0x1874529F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x7452A30", Offset = "0x7451C30", VA = "0x187452A30")]
	protected HAILHKLIACP(OCHNHLJBAPP PAJCAJDCMMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract LHBFOPKLGGA GFPJKHKOLEM(List<DIPMDJLELCL> PABLELPNMNM, List<DIPMDJLELCL> MNPGNNGNHOM);

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract MNJBDICHJBL KAKPICLEIMM(uint KADDNMPDABI, AvatarSkinnedMeshBoneOrderRemapsData ALMFCKJJPKH);
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class FBAFMLLDPHE : OLPEDGELNDF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000264")]
	private AvatarSkinAssetItem PIBLIEFEOIA;

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x7451170", Offset = "0x7450370", VA = "0x187451170")]
	public FBAFMLLDPHE(AvatarSkinAssetItem ILLMFMBMCDD, AvatarSkinAssetItem.OFCNNHONCHK PKPKGOGGFIO, OCHNHLJBAPP GPIHEODLCOO, [Optional] FKCADKOIAIJ? OOADGOCNDBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x7450F10", Offset = "0x7450110", VA = "0x187450F10", Slot = "6")]
	public override LHBFOPKLGGA GFPJKHKOLEM(List<DIPMDJLELCL> PABLELPNMNM, List<DIPMDJLELCL> MNPGNNGNHOM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class FJPGPIHAIJE
{
	[Cpp2IlInjected.Token(Token = "0x4000265")]
	private static readonly int[] OAGCAMPAMJK;

	[Cpp2IlInjected.Token(Token = "0x4000266")]
	private static readonly int[] BNEOPNFAIDN;

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public static int[] HKDJKJFELIK
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x74518E0", Offset = "0x7450AE0", VA = "0x1874518E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x7451930", Offset = "0x7450B30", VA = "0x187451930")]
	public static int[] GPMPJEPAANB(bool BNIMAJKCIKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x74519E0", Offset = "0x7450BE0", VA = "0x1874519E0")]
	public static int OLDAENODENL(OJGJEEMDGCF AGNDHLNFBOL, bool BNIMAJKCIKG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x74519D0", Offset = "0x7450BD0", VA = "0x1874519D0")]
	private static int NLLBLCJDMLN(OJGJEEMDGCF AGNDHLNFBOL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x74519B0", Offset = "0x7450BB0", VA = "0x1874519B0")]
	private static int KJFKNAAELIB(OJGJEEMDGCF AGNDHLNFBOL)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class FHLJCJFJIPA
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private sealed class HPCLKIHCHNB : IEnumerator<DEPLMKJKOMK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		private DEPLMKJKOMK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		public JobHandle handle;

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		private DEPLMKJKOMK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x963A50", Offset = "0x962C50", VA = "0x180963A50", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x963A50", Offset = "0x962C50", VA = "0x180963A50", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x963B40", Offset = "0x962D40", VA = "0x180963B40")]
		[DebuggerHidden]
		public HPCLKIHCHNB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x10C72D0", Offset = "0x10C64D0", VA = "0x1810C72D0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x7454280", Offset = "0x7453480", VA = "0x187454280", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00")]
	public static void JKPJHCOAFJK(string JDNOHHGIHEO, int KADDNMPDABI, long OOMJEHNOGLP, long BBLFPFAJMIL, long LBOADCGFABD, long EIOFJFDFEFL, long NEIHOLCEAIO, long NGJAJKBABBF, long PGAMMHCEMBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x7451780", Offset = "0x7450980", VA = "0x187451780")]
	public static PHFJKNHMAKK CBCIHCCFICC(JobHandle OBOONABAPDM, bool HFMNHOLAPBN, bool NCBBCCIDDMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x7451870", Offset = "0x7450A70", VA = "0x187451870")]
	[IteratorStateMachine(typeof(HPCLKIHCHNB))]
	private static IEnumerator<DEPLMKJKOMK> KNNIDAKDNNG(JobHandle PBLKLOBKEHJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class PMNCKCFAFID
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public enum HMDAHLBKHAA
	{
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		General,
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		ColoredHair
	}

	[Cpp2IlInjected.Token(Token = "0x400026A")]
	public static readonly int MGMOLAPCNOG;

	[Cpp2IlInjected.Token(Token = "0x400026B")]
	public static readonly int LHFPNECPINH;

	[Cpp2IlInjected.Token(Token = "0x400026C")]
	public static readonly int HKIDFLDMBCO;

	[Cpp2IlInjected.Token(Token = "0x400026D")]
	public static readonly int HGMBGHAGLHB;

	[Cpp2IlInjected.Token(Token = "0x400026E")]
	public static readonly int ANAHEDCOGDB;

	[Cpp2IlInjected.Token(Token = "0x400026F")]
	public static readonly int BGHMJNFMJBI;

	[Cpp2IlInjected.Token(Token = "0x4000270")]
	public static readonly int HHNFKHDJOLF;

	[Cpp2IlInjected.Token(Token = "0x4000271")]
	public static readonly int FKCHAPKFGFF;

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x745DD90", Offset = "0x745CF90", VA = "0x18745DD90")]
	public static bool GIENHIDAIOH(Material MDMIJJAMBMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x745DCD0", Offset = "0x745CED0", VA = "0x18745DCD0")]
	public static bool CGAMECKCKOJ(Material MDMIJJAMBMD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class OLPEDGELNDF : HAILHKLIACP
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private sealed class KENGEIFECFH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		public CAFFOJNOKAH<GameObject> skinAvatarItemPrefabHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		public OLPEDGELNDF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		public Action<string> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public KENGEIFECFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x7456560", Offset = "0x7455760", VA = "0x187456560")]
		internal void HPCDJPBCHPD(GameObject result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x7456930", Offset = "0x7455B30", VA = "0x187456930")]
		internal void MBICIMJKJOE(string error)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000276")]
	protected AvatarSkinAssetItem IMNFEOKDDNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000277")]
	protected Material[] IOBAIGKPPLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000278")]
	private readonly AvatarSkinAssetItem.OFCNNHONCHK CLKCHCLODCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000279")]
	private readonly AssetReference IDNHONMNKKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400027A")]
	private readonly FKCADKOIAIJ? NHIPHJLOPGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400027B")]
	private SkinnedMeshRenderer[] PAHOCIFPOFJ;

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public override LHOPHOECLDF.PDNJAPAFAJM CMLOPFCKCPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x964CD0", Offset = "0x963ED0", VA = "0x180964CD0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(LHOPHOECLDF.PDNJAPAFAJM);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x964ED0", Offset = "0x9640D0", VA = "0x180964ED0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x745D870", Offset = "0x745CA70", VA = "0x18745D870")]
	public OLPEDGELNDF(AvatarSkinAssetItem.OFCNNHONCHK PKPKGOGGFIO, AssetReference EJLCNEGAALL, Material AHHACPFBDPO, OCHNHLJBAPP GPIHEODLCOO, LHOPHOECLDF.PDNJAPAFAJM BJJILHHDION = (LHOPHOECLDF.PDNJAPAFAJM)0L, [Optional] FKCADKOIAIJ? OOADGOCNDBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x745D750", Offset = "0x745C950", VA = "0x18745D750")]
	public OLPEDGELNDF(AvatarSkinAssetItem.OFCNNHONCHK PKPKGOGGFIO, AssetReference EJLCNEGAALL, Material AHHACPFBDPO, LHOPHOECLDF.PDNJAPAFAJM BJJILHHDION = (LHOPHOECLDF.PDNJAPAFAJM)0L, [Optional] FKCADKOIAIJ? OOADGOCNDBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x745D240", Offset = "0x745C440", VA = "0x18745D240", Slot = "6")]
	public override LHBFOPKLGGA GFPJKHKOLEM(List<DIPMDJLELCL> PABLELPNMNM, List<DIPMDJLELCL> MNPGNNGNHOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x745D410", Offset = "0x745C610", VA = "0x18745D410", Slot = "7")]
	public override MNJBDICHJBL KAKPICLEIMM(uint KADDNMPDABI, AvatarSkinnedMeshBoneOrderRemapsData ALMFCKJJPKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x745D6E0", Offset = "0x745C8E0", VA = "0x18745D6E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x745D1F0", Offset = "0x745C3F0", VA = "0x18745D1F0")]
	protected void CFAHPMFCOBK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public class BIECMGJDPME
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400027F")]
	private List<int> MDLPCOJPGLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000280")]
	private List<LDNACMIHNBG> KBPNAFGEIMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000281")]
	private HashSet<Transform> OBDFPGAJANN;

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x7450C50", Offset = "0x744FE50", VA = "0x187450C50")]
	public static BIECMGJDPME FPJIODCJNDN(Transform FDDEDLKEPIJ, Dictionary<Transform, OutfitType?> EIANMIJHBKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x7450470", Offset = "0x744F670", VA = "0x187450470")]
	private void AMDDBGFINBB(Transform FDDEDLKEPIJ, OCHNHLJBAPP GPIHEODLCOO, Dictionary<Transform, OutfitType?> EIANMIJHBKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x7450B20", Offset = "0x744FD20", VA = "0x187450B20")]
	private void EJKMLALJCFO(Transform IFMEPLLJIOM, OCHNHLJBAPP GPIHEODLCOO, bool PCFDGPBCPMP, OutfitType? GFOBCJGOIFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x7450730", Offset = "0x744F930", VA = "0x187450730")]
	public OKDBFAGABAL CIPOPKLAACF(HashSet<string> IPAJLKBEIAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x7450DE0", Offset = "0x744FFE0", VA = "0x187450DE0")]
	public BIECMGJDPME()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public class OKDBFAGABAL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000282")]
	private List<LDNACMIHNBG> KBPNAFGEIMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000283")]
	private List<Matrix4x4> ENIBKEACLDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000284")]
	private Transform[] EEDHFOEIGAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000285")]
	private Matrix4x4[] CGIGIIBGJPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000286")]
	private Dictionary<KNLCFGHEHCF, int> HFKOCKINCBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000287")]
	private List<LJIBHDKCHCP> NMFGLCNEELG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000288")]
	private bool OJNFNPGILOL;

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public int ABNMPHLJIIM
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x745CE00", Offset = "0x745C000", VA = "0x18745CE00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public Transform[] HGNJJEPIHCA
	{
		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x745C990", Offset = "0x745BB90", VA = "0x18745C990")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public Matrix4x4[] OGOKFOHCJJE
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x745CD90", Offset = "0x745BF90", VA = "0x18745CD90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x745C460", Offset = "0x745B660", VA = "0x18745C460")]
	public void EJKMLALJCFO(Transform IFMEPLLJIOM, OCHNHLJBAPP GPIHEODLCOO, OutfitType? GFOBCJGOIFM, bool JDOFMMABNPN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x745C650", Offset = "0x745B850", VA = "0x18745C650")]
	private void EJKMLALJCFO(Transform IFMEPLLJIOM, OCHNHLJBAPP GPIHEODLCOO, OutfitType? GFOBCJGOIFM, bool JDOFMMABNPN, Matrix4x4 PFAODJAFFPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x745CAF0", Offset = "0x745BCF0", VA = "0x18745CAF0")]
	public int EMNFKCLKILD(KNLCFGHEHCF MBDBONINAPC, bool KIOANMNMFEN, [Optional] OutfitType? GFOBCJGOIFM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x745CE40", Offset = "0x745C040", VA = "0x18745CE40")]
	public int ONHEKLNAMID(OCHNHLJBAPP GPIHEODLCOO, [Optional] OutfitType? GFOBCJGOIFM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x745CCA0", Offset = "0x745BEA0", VA = "0x18745CCA0")]
	public void ILCFCCFNFFN(KNLCFGHEHCF MBDBONINAPC, Matrix4x4 DEPGMNGDKJL, bool KIOANMNMFEN = false, [Optional] OutfitType? GFOBCJGOIFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x745CF40", Offset = "0x745C140", VA = "0x18745CF40")]
	public Matrix4x4 PMKEJEOIIIE(KNLCFGHEHCF MBDBONINAPC, bool KIOANMNMFEN, [Optional] OutfitType? GFOBCJGOIFM)
	{
		return default(Matrix4x4);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x119C2E0", Offset = "0x119B4E0", VA = "0x18119C2E0")]
	public void AGMEPDMFLIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x745D080", Offset = "0x745C280", VA = "0x18745D080")]
	public OKDBFAGABAL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public struct KNLCFGHEHCF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400028C")]
	public readonly string NDIJMAPCAOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400028D")]
	public readonly OCHNHLJBAPP CIIHACDOPKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400028E")]
	public readonly OutfitType? ABJGFKIIHIG;

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x7457270", Offset = "0x7456470", VA = "0x187457270")]
	public KNLCFGHEHCF(string EHJOJGAKEMP, OCHNHLJBAPP GPIHEODLCOO, [Optional] OutfitType? GFOBCJGOIFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x74571C0", Offset = "0x74563C0", VA = "0x1874571C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x7456FE0", Offset = "0x74561E0", VA = "0x187456FE0")]
	public bool DIOHPIOIANM(KNLCFGHEHCF LDKNLBHIGFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x74570A0", Offset = "0x74562A0", VA = "0x1874570A0", Slot = "0")]
	public override bool Equals(object ONELFPFEALD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x7457150", Offset = "0x7456350", VA = "0x187457150", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public struct LJIBHDKCHCP : IEquatable<LJIBHDKCHCP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400028F")]
	public readonly OCHNHLJBAPP CIIHACDOPKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000290")]
	public readonly OutfitType? GPIHNDAECAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000291")]
	public readonly int DBBJDAHLEEO;

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x74589E0", Offset = "0x7457BE0", VA = "0x1874589E0")]
	public LJIBHDKCHCP(OCHNHLJBAPP GPIHEODLCOO, int FKNPONCIHDE, [Optional] OutfitType? JBCFLENOECE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x7458910", Offset = "0x7457B10", VA = "0x187458910", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x6741F20", Offset = "0x6741120", VA = "0x186741F20")]
	public bool NDEFJEANPEG(OCHNHLJBAPP GPIHEODLCOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x7458700", Offset = "0x7457900", VA = "0x187458700")]
	public bool EMIKBIMMDJA(OutfitType? JBCFLENOECE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x7458780", Offset = "0x7457980", VA = "0x187458780", Slot = "4")]
	public bool Equals(LJIBHDKCHCP LDKNLBHIGFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x74587D0", Offset = "0x74579D0", VA = "0x1874587D0", Slot = "0")]
	public override bool Equals(object ONELFPFEALD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x74588C0", Offset = "0x7457AC0", VA = "0x1874588C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public struct LDNACMIHNBG : IEquatable<LDNACMIHNBG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000292")]
	public readonly Transform HIBBPPHBBPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000293")]
	public readonly bool NKDLHFLEKDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x4000294")]
	public readonly OCHNHLJBAPP APKIFELBAFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000295")]
	public readonly OutfitType? ABJGFKIIHIG;

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x74586B0", Offset = "0x74578B0", VA = "0x1874586B0")]
	public LDNACMIHNBG(Transform IFMEPLLJIOM, bool PCFDGPBCPMP, OCHNHLJBAPP MMFDBCMEMIG, [Optional] OutfitType? NAKLBCJGDBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x7458490", Offset = "0x7457690", VA = "0x187458490", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x7458230", Offset = "0x7457430", VA = "0x187458230", Slot = "4")]
	public bool Equals(LDNACMIHNBG LDKNLBHIGFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x7458330", Offset = "0x7457530", VA = "0x187458330", Slot = "0")]
	public override bool Equals(object ONELFPFEALD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x7458410", Offset = "0x7457610", VA = "0x187458410", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[ExecuteInEditMode]
	public class FitMeshHemisphereUpdater : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x4000296")]
		public const float DEFAULT_Y_POSITION_OFFSET = 0.04f;

		[Cpp2IlInjected.Token(Token = "0x4000297")]
		public const float MAX_HEMISPHERE_POSITION_OFFSET = 0.05f;

		[Cpp2IlInjected.Token(Token = "0x4000298")]
		public const float MAX_HEMISPHERE_ROTATION_OFFSET = 45f;

		[Cpp2IlInjected.Token(Token = "0x4000299")]
		public const float MAX_HEMISPHERE_SCALE = 2f;

		[Cpp2IlInjected.Token(Token = "0x400029A")]
		public const float MIN_HEMISPHERE_SCALE = 0.75f;

		[Cpp2IlInjected.Token(Token = "0x400029B")]
		public const float MAX_HEMISPHERE_RADIUS = 0.25f;

		[Cpp2IlInjected.Token(Token = "0x400029C")]
		public const float MIN_HEMISPHERE_RADIUS = 0.125f;

		[Cpp2IlInjected.Token(Token = "0x400029D")]
		public static GameObject ContainerGO;

		[Cpp2IlInjected.Token(Token = "0x400029E")]
		public static GameObject CurrentHairHemisphereGO;

		[Cpp2IlInjected.Token(Token = "0x400029F")]
		public static Transform CurrentHairHemisphereMeshTransform;

		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		public static FitMeshHemisphereUpdater CurrentHairHemisphereUpdater;

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x7451B70", Offset = "0x7450D70", VA = "0x187451B70")]
		public static void DespawnHairHemisphere()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00")]
		public void UpdateValues()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x962DF0", Offset = "0x961FF0", VA = "0x180962DF0")]
		public FitMeshHemisphereUpdater()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public interface IGNLPILKDPP
{
	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PFKMDIMHHCC(Mesh CJONLLGJGEO, Matrix4x4 EFNEGKKDIBM, byte[] NAIGDGBKDKE, bool IFHAHFBNENO = false, LHOPHOECLDF.PDNJAPAFAJM BBAGJPCMNKP = (LHOPHOECLDF.PDNJAPAFAJM)0L, int CBDGCFPMAHH = -1, bool CPJFHANIEMP = false);

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CCEOAAHHJIC(Allocator JNKCCGKBKPB, BLMBBPOKJAO PPACCKPNLPD, byte DFLIPJOGBFK, [Optional] IList<int> EKIEKAIOCLB, [Optional] IList<int> BKJEJDBNILE);
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public readonly struct FCFMFJCIPMP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40002A1")]
	public readonly GameObject CJFKKJCHCIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40002A2")]
	private readonly AvatarItemMaterial MBFGFMCCELH;

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x9E2EE0", Offset = "0x9E20E0", VA = "0x1809E2EE0")]
	public FCFMFJCIPMP(GameObject CJFKKJCHCIP, AvatarItemMaterial MBFGFMCCELH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x7451270", Offset = "0x7450470", VA = "0x187451270")]
	public void JPJMIHJFJGC(Material MDMIJJAMBMD, int DGMNCEHCMDA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public class ACLLHLJOJDM : IDBBBBEBFDN<Task<(GameObject, AvatarItemMaterial)>, FCFMFJCIPMP>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private struct KGBNMCIKHGP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		public AsyncTaskMethodBuilder<(GameObject, AvatarItemMaterial)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		public Task<GameObject> goTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		public Task<AvatarItemMaterial> materialTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		private GameObject <go>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		private TaskAwaiter<GameObject> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		private TaskAwaiter<AvatarItemMaterial> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x7456A70", Offset = "0x7455C70", VA = "0x187456A70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x7456F70", Offset = "0x7456170", VA = "0x187456F70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40002A3")]
	private CAFFOJNOKAH<GameObject> MNLNFKNBGON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40002A4")]
	private CAFFOJNOKAH<AvatarItemMaterial> LHGHCELGGKC;

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x744D570", Offset = "0x744C770", VA = "0x18744D570")]
	private ACLLHLJOJDM(Task<(GameObject, AvatarItemMaterial)> JJCLBODJJAC, CAFFOJNOKAH<GameObject> HBKKJAJFHGP, CAFFOJNOKAH<AvatarItemMaterial> EFGNBOODCJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x744D0C0", Offset = "0x744C2C0", VA = "0x18744D0C0")]
	public static ACLLHLJOJDM JENMMFKNHKF(AssetReference BPNDIBLCFAE, [Optional] AssetReference HBBIHGBIFLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x744D4D0", Offset = "0x744C6D0", VA = "0x18744D4D0", Slot = "11")]
	protected override FCFMFJCIPMP KENMNOPMMMD(Task<(GameObject, AvatarItemMaterial)> NEPFHLFNEFB)
	{
		return default(FCFMFJCIPMP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x744CF10", Offset = "0x744C110", VA = "0x18744CF10", Slot = "12")]
	protected override void AHCOAACLOKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x744CF90", Offset = "0x744C190", VA = "0x18744CF90")]
	[AsyncStateMachine(typeof(KGBNMCIKHGP))]
	private static Task<(GameObject, AvatarItemMaterial)> ECLLGLLHKPD(Task<GameObject> KNNCOBBBFCJ, Task<AvatarItemMaterial> OAFGBJKLIDC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class HJMCKGKNIIC
{
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	private class BGNAHCCFGHN : IDBBBBEBFDN<Task<MaterialMapAsset>, Material[]>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		private CAFFOJNOKAH<MaterialMapAsset> PBLKLOBKEHJ;

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x7450390", Offset = "0x744F590", VA = "0x187450390")]
		public BGNAHCCFGHN(CAFFOJNOKAH<MaterialMapAsset> PBLKLOBKEHJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x744FF70", Offset = "0x744F170", VA = "0x18744FF70", Slot = "11")]
		protected override Material[] KENMNOPMMMD(Task<MaterialMapAsset> JJCLBODJJAC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x744FF10", Offset = "0x744F110", VA = "0x18744FF10", Slot = "12")]
		protected override void AHCOAACLOKB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private class PPBBEDJFDMH : IDBBBBEBFDN<Task<Material[]>, Material[]>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		private List<CAFFOJNOKAH<Material>> OPEHJJPEJMB;

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x745E100", Offset = "0x745D300", VA = "0x18745E100")]
		public PPBBEDJFDMH(Task<Material[]> JJCLBODJJAC, List<CAFFOJNOKAH<Material>> OPEHJJPEJMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x745E0B0", Offset = "0x745D2B0", VA = "0x18745E0B0", Slot = "11")]
		protected override Material[] KENMNOPMMMD(Task<Material[]> NEPFHLFNEFB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x745DF70", Offset = "0x745D170", VA = "0x18745DF70", Slot = "12")]
		protected override void AHCOAACLOKB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40002AF")]
	private static readonly PBBCGFNIILA NPAEAIAJLAP;

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x7453E00", Offset = "0x7453000", VA = "0x187453E00")]
	public static CAFFOJNOKAH<Material[]> MGPBHNHLKBE(AssetReference[] APBFHMDLPAD)
	{
		return null;
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[DisallowMultipleComponent]
	public class PlayerAvatarDisplayBase : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000055")]
		public enum JGAOFPOEOPC
		{
			[Cpp2IlInjected.Token(Token = "0x400033E")]
			None,
			[Cpp2IlInjected.Token(Token = "0x400033F")]
			TeamItem,
			[Cpp2IlInjected.Token(Token = "0x4000340")]
			SkinColor,
			[Cpp2IlInjected.Token(Token = "0x4000341")]
			HairColor,
			[Cpp2IlInjected.Token(Token = "0x4000342")]
			BeardColor,
			[Cpp2IlInjected.Token(Token = "0x4000343")]
			UGCShirtColor
		}

		[Cpp2IlInjected.Token(Token = "0x2000056")]
		public enum BMAKHAEDKCP
		{
			[Cpp2IlInjected.Token(Token = "0x4000345")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4000346")]
			HairTexture,
			[Cpp2IlInjected.Token(Token = "0x4000347")]
			BeardTexture,
			[Cpp2IlInjected.Token(Token = "0x4000348")]
			UGCShirtTexture
		}

		[Cpp2IlInjected.Token(Token = "0x2000057")]
		public enum JJMDMOBMJDH : byte
		{
			[Cpp2IlInjected.Token(Token = "0x400034A")]
			All,
			[Cpp2IlInjected.Token(Token = "0x400034B")]
			LOD0Only,
			[Cpp2IlInjected.Token(Token = "0x400034C")]
			EditorToolAll
		}

		[Cpp2IlInjected.Token(Token = "0x2000058")]
		public struct ADNODJGELIP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400034D")]
			public readonly Material ECAGAIIDDPB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400034E")]
			public readonly JGAOFPOEOPC OGNLPFDOGFM;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x400034F")]
			public readonly BMAKHAEDKCP AJHMGAGKGIC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000350")]
			public readonly OCHNHLJBAPP CIIHACDOPKC;

			[Cpp2IlInjected.Token(Token = "0x60002E4")]
			[Cpp2IlInjected.Address(RVA = "0x7451740", Offset = "0x7450940", VA = "0x187451740")]
			public ADNODJGELIP(Material MDMIJJAMBMD, JGAOFPOEOPC DPFKBPIHFJH, BMAKHAEDKCP AMGIDDIOEEA, OCHNHLJBAPP GPIHEODLCOO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002E5")]
			[Cpp2IlInjected.Address(RVA = "0x746CD90", Offset = "0x746BF90", VA = "0x18746CD90", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002E6")]
			[Cpp2IlInjected.Address(RVA = "0x74513F0", Offset = "0x74505F0", VA = "0x1874513F0")]
			public bool DIOHPIOIANM(ADNODJGELIP LDKNLBHIGFL)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002E7")]
			[Cpp2IlInjected.Address(RVA = "0x746CC00", Offset = "0x746BE00", VA = "0x18746CC00", Slot = "0")]
			public override bool Equals(object ONELFPFEALD)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002E8")]
			[Cpp2IlInjected.Address(RVA = "0x746CCF0", Offset = "0x746BEF0", VA = "0x18746CCF0", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000059")]
		protected struct NLBCGPDDAHC : IComparable<NLBCGPDDAHC>, IEquatable<NLBCGPDDAHC>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000351")]
			public int MLCKMINCELO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000352")]
			public PlayerAvatarDisplayBase JBKGPNGEPEM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000353")]
			public IList<LFLMMHMGMIH> BCBKNCNIOMA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000354")]
			public AvatarItemBodyType OHJFAAABPHG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000355")]
			public DKFIILHCHMC CPLJKOIHLJE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000356")]
			public bool HHDIANHAMIB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000357")]
			public int[] HJHBOOCCGFN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000358")]
			public float JPKMCCPDGPB;

			[Cpp2IlInjected.Token(Token = "0x60002E9")]
			[Cpp2IlInjected.Address(RVA = "0x74748B0", Offset = "0x7473AB0", VA = "0x1874748B0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002EA")]
			[Cpp2IlInjected.Address(RVA = "0x7474750", Offset = "0x7473950", VA = "0x187474750", Slot = "4")]
			public int CompareTo(NLBCGPDDAHC LDKNLBHIGFL)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002EB")]
			[Cpp2IlInjected.Address(RVA = "0x7474770", Offset = "0x7473970", VA = "0x187474770", Slot = "5")]
			public bool Equals(NLBCGPDDAHC LDKNLBHIGFL)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005A")]
		protected abstract class DFILGOFENKI
		{
			[Cpp2IlInjected.Token(Token = "0x200005B")]
			public class ODCOHHFKKKH
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400035C")]
				public readonly Mesh HEBENAMLBPM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400035D")]
				public readonly Material[] MBIBGAPAHEB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400035E")]
				public readonly Transform[] KHPCKNPBIMG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400035F")]
				public readonly Matrix4x4[] PJIENPJDECH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000360")]
				public readonly Transform DOLHKMGFGBG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000361")]
				public readonly bool NKCEHFGODEC;

				[Cpp2IlInjected.Token(Token = "0x60002F3")]
				[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
				protected ODCOHHFKKKH()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002F4")]
				[Cpp2IlInjected.Address(RVA = "0x7474ED0", Offset = "0x74740D0", VA = "0x187474ED0")]
				public ODCOHHFKKKH(Mesh CJONLLGJGEO, Material[] MAHEDCCGGMJ, bool AGLDJPBBAPG, Transform[] GILMLJNJOPM, Transform CAIJMCNEAFC, Matrix4x4[] GAEMIDICMEP)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002F5")]
				[Cpp2IlInjected.Address(RVA = "0x7474E10", Offset = "0x7474010", VA = "0x187474E10")]
				private ODCOHHFKKKH(SkinnedMeshRenderer MEFKAPPLHEA, Material[] CAJLNIEKKLL)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002F6")]
				[Cpp2IlInjected.Address(RVA = "0x7474D20", Offset = "0x7473F20", VA = "0x187474D20")]
				private ODCOHHFKKKH(MeshRenderer MODDOMKCPEA, Transform CAIJMCNEAFC, Material[] CAJLNIEKKLL)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002F7")]
				[Cpp2IlInjected.Address(RVA = "0x7474A00", Offset = "0x7473C00", VA = "0x187474A00")]
				public static ODCOHHFKKKH DGAGAMKBNBF(Renderer MONNLFCGBEF, Material[] CAJLNIEKKLL)
				{
					return null;
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000359")]
			public readonly OCHNHLJBAPP CIIHACDOPKC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400035A")]
			public readonly Transform MPJBCCLDJIM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400035B")]
			public readonly bool IACNOCDPCMO;

			[Cpp2IlInjected.Token(Token = "0x1700008B")]
			public virtual bool PNGLIBAMPKF
			{
				[Cpp2IlInjected.Token(Token = "0x60002EC")]
				[Cpp2IlInjected.Address(RVA = "0x9ACBB0", Offset = "0x9ABDB0", VA = "0x1809ACBB0", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008C")]
			public virtual bool COJAEPNFJFP
			{
				[Cpp2IlInjected.Token(Token = "0x60002ED")]
				[Cpp2IlInjected.Address(RVA = "0x9ACBB0", Offset = "0x9ABDB0", VA = "0x1809ACBB0", Slot = "5")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008D")]
			public virtual LHOPHOECLDF.PDNJAPAFAJM CMLOPFCKCPJ
			{
				[Cpp2IlInjected.Token(Token = "0x60002EE")]
				[Cpp2IlInjected.Address(RVA = "0x962E10", Offset = "0x962010", VA = "0x180962E10", Slot = "6")]
				get
				{
					return default(LHOPHOECLDF.PDNJAPAFAJM);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008E")]
			public bool KJKJONMLIBA
			{
				[Cpp2IlInjected.Token(Token = "0x60002EF")]
				[Cpp2IlInjected.Address(RVA = "0x746FDC0", Offset = "0x746EFC0", VA = "0x18746FDC0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002F0")]
			[Cpp2IlInjected.Address(RVA = "0x746FDD0", Offset = "0x746EFD0", VA = "0x18746FDD0")]
			protected DFILGOFENKI(OCHNHLJBAPP GPIHEODLCOO, Transform CIMEOLGFJFN, bool AMOEOAMDICC = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F1")]
			[Cpp2IlInjected.Address(Slot = "7")]
			public abstract LHBFOPKLGGA GFPJKHKOLEM(List<DIPMDJLELCL> PABLELPNMNM, List<DIPMDJLELCL> MNPGNNGNHOM);

			[Cpp2IlInjected.Token(Token = "0x60002F2")]
			[Cpp2IlInjected.Address(Slot = "8")]
			public abstract ODCOHHFKKKH KAKPICLEIMM(int KADDNMPDABI, PlayerHandBones LFMNMLGBOPN);
		}

		[Cpp2IlInjected.Token(Token = "0x200005C")]
		protected class DCKNDIAJFHC : DFILGOFENKI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000362")]
			protected readonly BodyPartLODs PAHOCIFPOFJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000363")]
			protected readonly Material[] IOBAIGKPPLG;

			[Cpp2IlInjected.Token(Token = "0x60002F8")]
			[Cpp2IlInjected.Address(RVA = "0x746FCB0", Offset = "0x746EEB0", VA = "0x18746FCB0")]
			public DCKNDIAJFHC(OCHNHLJBAPP GPIHEODLCOO, BodyPartLODs PKBPLKJIPNN, Material AHHACPFBDPO, [Optional] Transform CIMEOLGFJFN, bool AMOEOAMDICC = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F9")]
			[Cpp2IlInjected.Address(RVA = "0x746F9F0", Offset = "0x746EBF0", VA = "0x18746F9F0", Slot = "7")]
			public override LHBFOPKLGGA GFPJKHKOLEM(List<DIPMDJLELCL> PABLELPNMNM, List<DIPMDJLELCL> MNPGNNGNHOM)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002FA")]
			[Cpp2IlInjected.Address(RVA = "0x746FA80", Offset = "0x746EC80", VA = "0x18746FA80", Slot = "8")]
			public override ODCOHHFKKKH KAKPICLEIMM(int KADDNMPDABI, PlayerHandBones LFMNMLGBOPN)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002FB")]
			[Cpp2IlInjected.Address(RVA = "0x746FC40", Offset = "0x746EE40", VA = "0x18746FC40", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005D")]
		protected class IGNCLOKCJPK : DFILGOFENKI
		{
			[Cpp2IlInjected.Token(Token = "0x1700008F")]
			public override bool PNGLIBAMPKF
			{
				[Cpp2IlInjected.Token(Token = "0x60002FC")]
				[Cpp2IlInjected.Address(RVA = "0x97D6F0", Offset = "0x97C8F0", VA = "0x18097D6F0", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000090")]
			public override bool COJAEPNFJFP
			{
				[Cpp2IlInjected.Token(Token = "0x60002FD")]
				[Cpp2IlInjected.Address(RVA = "0x7471BE0", Offset = "0x7470DE0", VA = "0x187471BE0", Slot = "5")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000091")]
			public HJICPBDJEDM NECGMAGNOMH
			{
				[Cpp2IlInjected.Token(Token = "0x60002FE")]
				[Cpp2IlInjected.Address(RVA = "0x964CD0", Offset = "0x963ED0", VA = "0x180964CD0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60002FF")]
				[Cpp2IlInjected.Address(RVA = "0x968CF0", Offset = "0x967EF0", VA = "0x180968CF0")]
				[CompilerGenerated]
				protected set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000300")]
			[Cpp2IlInjected.Address(RVA = "0x7471CA0", Offset = "0x7470EA0", VA = "0x187471CA0")]
			public IGNCLOKCJPK(OCHNHLJBAPP GPIHEODLCOO, Transform CIMEOLGFJFN, HJICPBDJEDM PBBIHNAENOI, bool AMOEOAMDICC = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000301")]
			[Cpp2IlInjected.Address(RVA = "0x7471B50", Offset = "0x7470D50", VA = "0x187471B50", Slot = "7")]
			public override LHBFOPKLGGA GFPJKHKOLEM(List<DIPMDJLELCL> PABLELPNMNM, List<DIPMDJLELCL> MNPGNNGNHOM)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000302")]
			[Cpp2IlInjected.Address(RVA = "0x962E10", Offset = "0x962010", VA = "0x180962E10", Slot = "8")]
			public override ODCOHHFKKKH KAKPICLEIMM(int KADDNMPDABI, PlayerHandBones LFMNMLGBOPN)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000303")]
			[Cpp2IlInjected.Address(RVA = "0x7471C30", Offset = "0x7470E30", VA = "0x187471C30", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005E")]
		public class FALLAAMPMDG
		{
			[Cpp2IlInjected.Token(Token = "0x200005F")]
			public enum HDOGMKAKIAB
			{
				[Cpp2IlInjected.Token(Token = "0x4000375")]
				PLAYER_PUPPET,
				[Cpp2IlInjected.Token(Token = "0x4000376")]
				PLAYER_DISPLAY_POSER,
				[Cpp2IlInjected.Token(Token = "0x4000377")]
				PLAYER_HAND,
				[Cpp2IlInjected.Token(Token = "0x4000378")]
				STNMONSTERCOSTUME_OPTION_HIDE_EXCEPT_UI,
				[Cpp2IlInjected.Token(Token = "0x4000379")]
				PLAYER_HAND_POINTING,
				[Cpp2IlInjected.Token(Token = "0x400037A")]
				STNMONSTERCOSTUME_OPTION_ALWAYS_HIDE,
				[Cpp2IlInjected.Token(Token = "0x400037B")]
				EDITOR
			}

			[Cpp2IlInjected.Token(Token = "0x4000365")]
			public static readonly int CACMOCDHCHJ;

			[Cpp2IlInjected.Token(Token = "0x4000366")]
			public static readonly int ECHNHEHDLPD;

			[Cpp2IlInjected.Token(Token = "0x4000367")]
			public static readonly int LEIPNHBKIJK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000368")]
			protected readonly HELPMFJLADN PMFEAPOHPML;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000369")]
			protected readonly ILKCAEGHIBJ BEJAHJNPNPB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400036A")]
			protected readonly Animator MPOHPFPKMMP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400036B")]
			protected readonly Transform EJJEPPMIJAD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400036C")]
			protected readonly Vector3 MCGCHHPCIMC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400036D")]
			protected readonly Transform LLNLGAJEIGC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400036E")]
			protected readonly Vector3 CFNHLDNMAAK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x400036F")]
			protected bool HBEDEKGPGAA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000370")]
			protected CPPODONDALD ICELHEHFMKL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000371")]
			protected bool AOLEIAHFHBA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
			[Cpp2IlInjected.Token(Token = "0x4000372")]
			protected float EHPPLOAGNBH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000373")]
			protected GODAFHEHLEH<LJHHNJNPPBE> GKHIDGGENOD;

			[Cpp2IlInjected.Token(Token = "0x17000092")]
			public CPPODONDALD EAKHGCHGANB
			{
				[Cpp2IlInjected.Token(Token = "0x6000304")]
				[Cpp2IlInjected.Address(RVA = "0x961620", Offset = "0x960820", VA = "0x180961620")]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x6000305")]
				[Cpp2IlInjected.Address(RVA = "0x961640", Offset = "0x960840", VA = "0x180961640")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000093")]
			public bool EGCPOCMOCJI
			{
				[Cpp2IlInjected.Token(Token = "0x6000306")]
				[Cpp2IlInjected.Address(RVA = "0xAF8030", Offset = "0xAF7230", VA = "0x180AF8030")]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x6000307")]
				[Cpp2IlInjected.Address(RVA = "0x746FE30", Offset = "0x746F030", VA = "0x18746FE30")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000094")]
			public bool DJALAPABIFM
			{
				[Cpp2IlInjected.Token(Token = "0x6000308")]
				[Cpp2IlInjected.Address(RVA = "0x96A740", Offset = "0x969940", VA = "0x18096A740")]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x6000309")]
				[Cpp2IlInjected.Address(RVA = "0x7470830", Offset = "0x746FA30", VA = "0x187470830")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000095")]
			public float LJEHAOBJOGA
			{
				[Cpp2IlInjected.Token(Token = "0x600030A")]
				[Cpp2IlInjected.Address(RVA = "0xB97500", Offset = "0xB96700", VA = "0x180B97500")]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x600030B")]
				[Cpp2IlInjected.Address(RVA = "0x7470540", Offset = "0x746F740", VA = "0x187470540")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000096")]
			public LJHHNJNPPBE NOICLOPFPIE
			{
				[Cpp2IlInjected.Token(Token = "0x600030C")]
				[Cpp2IlInjected.Address(RVA = "0x7470220", Offset = "0x746F420", VA = "0x187470220")]
				get
				{
					return default(LJHHNJNPPBE);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600030D")]
			[Cpp2IlInjected.Address(RVA = "0x7470310", Offset = "0x746F510", VA = "0x187470310")]
			public bool GKKADGFEDCD(LJHHNJNPPBE BKILADAHDOL, object GIIKHLJPAKH, HDOGMKAKIAB JHJIKIHJMOH)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600030E")]
			[Cpp2IlInjected.Address(RVA = "0x7470730", Offset = "0x746F930", VA = "0x187470730")]
			public bool MKMPHKOAKFL(object GIIKHLJPAKH)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600030F")]
			[Cpp2IlInjected.Address(RVA = "0x7470AB0", Offset = "0x746FCB0", VA = "0x187470AB0")]
			protected FALLAAMPMDG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000310")]
			[Cpp2IlInjected.Address(RVA = "0x7470B40", Offset = "0x746FD40", VA = "0x187470B40")]
			public FALLAAMPMDG(HELPMFJLADN PMFEAPOHPML, CPPODONDALD OJAGLBPPOJC, Animator MPOHPFPKMMP, Transform EJJEPPMIJAD, Transform LLNLGAJEIGC, Vector3 MCGCHHPCIMC, Vector3 CFNHLDNMAAK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000311")]
			[Cpp2IlInjected.Address(RVA = "0x7470680", Offset = "0x746F880", VA = "0x187470680")]
			private void MEGDNFMFHDP(ushort DEGDEPHCOJL, ushort AMIMHEEMMPK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000312")]
			[Cpp2IlInjected.Address(RVA = "0x746FFC0", Offset = "0x746F1C0", VA = "0x18746FFC0")]
			protected void BOFMKLDBJCB(ushort DEGDEPHCOJL, ushort AMIMHEEMMPK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000313")]
			[Cpp2IlInjected.Address(RVA = "0x746FF00", Offset = "0x746F100", VA = "0x18746FF00")]
			protected void BLNDNBNIAKD(ushort DEGDEPHCOJL, ushort AMIMHEEMMPK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000314")]
			[Cpp2IlInjected.Address(RVA = "0x7470100", Offset = "0x746F300", VA = "0x187470100")]
			protected void EAGCJHKPDLM(ushort DEGDEPHCOJL, ushort AMIMHEEMMPK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000315")]
			[Cpp2IlInjected.Address(RVA = "0x7470900", Offset = "0x746FB00", VA = "0x187470900")]
			protected void OAFIMFJNEFJ(ushort DEGDEPHCOJL, ushort AMIMHEEMMPK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000316")]
			[Cpp2IlInjected.Address(RVA = "0x7470260", Offset = "0x746F460", VA = "0x187470260")]
			protected void EPFIEMHIHHB(ushort DEGDEPHCOJL, ushort AMIMHEEMMPK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000317")]
			[Cpp2IlInjected.Address(RVA = "0x74702C0", Offset = "0x746F4C0", VA = "0x1874702C0")]
			protected void FIFLHPDFDNC(ushort DEGDEPHCOJL, ushort AMIMHEEMMPK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000318")]
			[Cpp2IlInjected.Address(RVA = "0x74700B0", Offset = "0x746F2B0", VA = "0x1874700B0")]
			protected void DGEGLCCLKEO(ushort DEGDEPHCOJL, ushort AMIMHEEMMPK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000319")]
			[Cpp2IlInjected.Address(RVA = "0x7470420", Offset = "0x746F620", VA = "0x187470420")]
			protected void HCBFCILMLPH(ushort DEGDEPHCOJL, ushort AMIMHEEMMPK)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000060")]
		public class BNIDAJFPCBE : IDisposable
		{
			[Cpp2IlInjected.Token(Token = "0x400037C")]
			public const int IDGNKHJKEDL = 16;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400037D")]
			protected MaterialPropertyBlock OGHJMJDLDFL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400037E")]
			public Color? GCEFCGAIJJP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x400037F")]
			public Color? CCBODCPCMNB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000380")]
			public Color? FHNCPLKKEOP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x4000381")]
			public Color HGEKGDFDKBE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
			[Cpp2IlInjected.Token(Token = "0x4000382")]
			public Color IALCCDNBIAG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
			[Cpp2IlInjected.Token(Token = "0x4000383")]
			public Color IDDPPNIJNEL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x4000384")]
			public Texture2D ENNBANJBCDE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x4000385")]
			public Texture2D CJMJIOIANGI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x4000386")]
			protected Dictionary<ADNODJGELIP, int> OOLBNFKLBPD;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x4000387")]
			protected JGAOFPOEOPC[] MOAKODEGHEC;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x4000388")]
			public Vector4[] LCMOHGDHPNK;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x4000389")]
			public Vector4[] FOLOFHOGAEK;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x400038A")]
			public Vector4[] EONECLMHJHO;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x400038B")]
			public Vector4[] HBOCMIKHFHC;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
			[Cpp2IlInjected.Token(Token = "0x400038C")]
			public Vector4[] MJDPMLICNGL;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
			[Cpp2IlInjected.Token(Token = "0x400038D")]
			public Vector4[] HFNIJGCLPEG;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x400038E")]
			protected List<Texture2D> KBBGOGCOIDE;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x400038F")]
			protected Vector4[] OGFHBPBCJAE;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
			[Cpp2IlInjected.Token(Token = "0x4000390")]
			protected List<Texture2D> FEFDNHKGHOK;

			[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
			[Cpp2IlInjected.Token(Token = "0x4000391")]
			protected float[] BOENCEGOBJI;

			[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
			[Cpp2IlInjected.Token(Token = "0x4000392")]
			protected Vector4[] BOBGOCMADFG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
			[Cpp2IlInjected.Token(Token = "0x4000393")]
			protected float[] LAJJOCAFNEA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
			[Cpp2IlInjected.Token(Token = "0x4000394")]
			public float[] COGCFEFDHCH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
			[Cpp2IlInjected.Token(Token = "0x4000395")]
			protected List<Texture2D> HDDKKEDICPA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
			[Cpp2IlInjected.Token(Token = "0x4000396")]
			protected float[] CDNNLGBAEIL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
			[Cpp2IlInjected.Token(Token = "0x4000397")]
			protected List<Texture2D> IJCIKNHMNAL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
			[Cpp2IlInjected.Token(Token = "0x4000398")]
			protected Vector4[] OLOPMLKHCCH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
			[Cpp2IlInjected.Token(Token = "0x4000399")]
			protected float[] NFFGLFNLNMC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
			[Cpp2IlInjected.Token(Token = "0x400039A")]
			protected Vector4[] OINDNPIMIIA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
			[Cpp2IlInjected.Token(Token = "0x400039B")]
			public float[] JBPEHGMGAID;

			[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
			[Cpp2IlInjected.Token(Token = "0x400039C")]
			public Texture2DArray HFIILBJIKHH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
			[Cpp2IlInjected.Token(Token = "0x400039D")]
			public Texture2DArray FHBPOOFEAHL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
			[Cpp2IlInjected.Token(Token = "0x400039E")]
			public Texture2DArray GGENDOMMHAH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
			[Cpp2IlInjected.Token(Token = "0x400039F")]
			public Texture2DArray NFKBILDDGOH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
			[Cpp2IlInjected.Token(Token = "0x40003A0")]
			protected bool FJFKABNMGGD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x16C")]
			[Cpp2IlInjected.Token(Token = "0x40003A1")]
			protected int ABELEPELGFI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
			[Cpp2IlInjected.Token(Token = "0x40003A2")]
			protected Vector2? AAFCOCOMLCO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x17C")]
			[Cpp2IlInjected.Token(Token = "0x40003A3")]
			protected TextureFormat PELCNCLFOBL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
			[Cpp2IlInjected.Token(Token = "0x40003A4")]
			protected Vector2? HIFINNAEDNP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18C")]
			[Cpp2IlInjected.Token(Token = "0x40003A5")]
			protected TextureFormat GCEONIDCPEP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
			[Cpp2IlInjected.Token(Token = "0x40003A6")]
			protected Vector2? IIACJJMNKFJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x19C")]
			[Cpp2IlInjected.Token(Token = "0x40003A7")]
			protected TextureFormat OALKBMIIEFO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
			[Cpp2IlInjected.Token(Token = "0x40003A8")]
			protected Vector2? MIFFELPHNOB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1AC")]
			[Cpp2IlInjected.Token(Token = "0x40003A9")]
			protected TextureFormat DMAKECJBGEJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
			[Cpp2IlInjected.Token(Token = "0x40003AA")]
			protected bool FEHOKBMGFLG;

			[Cpp2IlInjected.Token(Token = "0x40003AB")]
			protected static int MIIOELEHHGM;

			[Cpp2IlInjected.Token(Token = "0x40003AC")]
			protected static int LCEOLDINFBG;

			[Cpp2IlInjected.Token(Token = "0x40003AD")]
			protected static int HMENEDMHGOC;

			[Cpp2IlInjected.Token(Token = "0x40003AE")]
			protected static int NKCCGCOBINI;

			[Cpp2IlInjected.Token(Token = "0x40003AF")]
			protected static int KGCELLGJJOD;

			[Cpp2IlInjected.Token(Token = "0x40003B0")]
			protected static int IFMPGECEHOI;

			[Cpp2IlInjected.Token(Token = "0x40003B1")]
			protected static int PJGLMGMHBML;

			[Cpp2IlInjected.Token(Token = "0x40003B2")]
			protected static int MJBCPELIPPP;

			[Cpp2IlInjected.Token(Token = "0x40003B3")]
			protected static int EIBKOHKNONK;

			[Cpp2IlInjected.Token(Token = "0x40003B4")]
			protected static int EKMFCAHEEAL;

			[Cpp2IlInjected.Token(Token = "0x40003B5")]
			protected static int EOFLHBAJPEH;

			[Cpp2IlInjected.Token(Token = "0x40003B6")]
			protected static int JCFBMDJFJBB;

			[Cpp2IlInjected.Token(Token = "0x40003B7")]
			protected static int GHCMJGKODFM;

			[Cpp2IlInjected.Token(Token = "0x40003B8")]
			protected static int ODJFFFIPBFI;

			[Cpp2IlInjected.Token(Token = "0x40003B9")]
			protected static int FDMPGGNBIHB;

			[Cpp2IlInjected.Token(Token = "0x40003BA")]
			protected static int GPKELIAAJBM;

			[Cpp2IlInjected.Token(Token = "0x40003BB")]
			protected static int JJNJJCOOLJG;

			[Cpp2IlInjected.Token(Token = "0x40003BC")]
			protected static int EDHKCOIBGPI;

			[Cpp2IlInjected.Token(Token = "0x40003BD")]
			protected static int NJNHJIEHBAN;

			[Cpp2IlInjected.Token(Token = "0x40003BE")]
			protected static int GCEOMDGCPHA;

			[Cpp2IlInjected.Token(Token = "0x600031B")]
			[Cpp2IlInjected.Address(RVA = "0x746F530", Offset = "0x746E730", VA = "0x18746F530")]
			protected BNIDAJFPCBE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600031C")]
			[Cpp2IlInjected.Address(RVA = "0x746F4A0", Offset = "0x746E6A0", VA = "0x18746F4A0")]
			public BNIDAJFPCBE(Color OKIAKDLMDOK, Color PABPMNJIBFI, Color JEJKMNLJMII, Color? LBONJJCJKMG, Color? OPEAIFLIHIB, Color? EEHBPKPODPE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600031D")]
			[Cpp2IlInjected.Address(RVA = "0x746DFE0", Offset = "0x746D1E0", VA = "0x18746DFE0")]
			public int FFBAKLFPJCD(Material MFAJMGKEOBO, JGAOFPOEOPC DPFKBPIHFJH, BMAKHAEDKCP AMGIDDIOEEA, OCHNHLJBAPP GPIHEODLCOO)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600031E")]
			[Cpp2IlInjected.Address(RVA = "0x746E0D0", Offset = "0x746D2D0", VA = "0x18746E0D0")]
			public int FFBAKLFPJCD(ADNODJGELIP MBDBONINAPC)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600031F")]
			[Cpp2IlInjected.Address(RVA = "0x746D2B0", Offset = "0x746C4B0", VA = "0x18746D2B0")]
			public int CIJEALFFIDO(Material MFAJMGKEOBO, Color FJNKCFIGEIG, Color CKHPLMFFILE, Color OJMACNHOPBN, Color PLEADIFOMEI, Color PLHAMHNCCDP, Texture2D MPKOJBFJDFG, Vector4 KHPJIKPBNIC, Texture2D HIAEEEPDHJF, Vector4 IDBFMCLIJCN, float HPMAEKBHOBO, float CIBJAENDLJD, Texture2D PEFDNJBFAFO, Vector4 BEANGOKMGBE, float HJKIDJBNDBF, Texture2D PFOOAODEKBC, float MBEIELNFJDG, Color IDBMGFOMLLP, Vector4 KNILKPKEDCL, JGAOFPOEOPC DPFKBPIHFJH, BMAKHAEDKCP AMGIDDIOEEA, OCHNHLJBAPP GPIHEODLCOO)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000320")]
			[Cpp2IlInjected.Address(RVA = "0x746E160", Offset = "0x746D360", VA = "0x18746E160")]
			protected void GHHADAFHLJP([Out] Texture2DArray JJHNMBNHNKH, [Out] Texture2DArray GCNMEDEMIID, [Out] Texture2DArray NMOGGKEPNKN, [Out] Texture2DArray AFJGFENOENL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000321")]
			[Cpp2IlInjected.Address(RVA = "0x746CFC0", Offset = "0x746C1C0", VA = "0x18746CFC0")]
			public void AJDOIPAJICC(PlayerAvatarDisplayBase OIBCJNBHBHB, Renderer MONNLFCGBEF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000322")]
			[Cpp2IlInjected.Address(RVA = "0x746E660", Offset = "0x746D860", VA = "0x18746E660")]
			protected void HIDCDNCPDIE(PlayerAvatarDisplayBase OIBCJNBHBHB, Renderer MONNLFCGBEF, int NAJMPKDICAP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000323")]
			[Cpp2IlInjected.Address(RVA = "0x746E320", Offset = "0x746D520", VA = "0x18746E320")]
			private Color GIPOOAOOGEE(Color DPPFMNEPKCG, JGAOFPOEOPC IMLCDJMGLCP)
			{
				return default(Color);
			}

			[Cpp2IlInjected.Token(Token = "0x6000324")]
			[Cpp2IlInjected.Address(RVA = "0x746E510", Offset = "0x746D710", VA = "0x18746E510")]
			private Color HANMMDCENAM(Color JDKPHGIOJNB, JGAOFPOEOPC IMLCDJMGLCP)
			{
				return default(Color);
			}

			[Cpp2IlInjected.Token(Token = "0x6000325")]
			[Cpp2IlInjected.Address(RVA = "0x746D220", Offset = "0x746C420", VA = "0x18746D220")]
			protected void BNEJHILOOOD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000326")]
			[Cpp2IlInjected.Address(RVA = "0x746DFA0", Offset = "0x746D1A0", VA = "0x18746DFA0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000061")]
		public struct PlayerHandBones
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003BF")]
			public Transform[] LeftHandBones;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003C0")]
			public Transform LeftHandRoot;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003C1")]
			public Transform[] RightHandBones;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003C2")]
			public Transform RightHandRoot;

			[Cpp2IlInjected.Token(Token = "0x6000328")]
			[Cpp2IlInjected.Address(RVA = "0x747B7D0", Offset = "0x747A9D0", VA = "0x18747B7D0")]
			public void NIPHGDGPFKJ(OCHNHLJBAPP GPIHEODLCOO, [Out] Transform BFPPPKIAFBG, [Out] Transform[] GILMLJNJOPM)
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000062")]
		protected struct BodyPartLODs
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003C3")]
			public Mesh[] LODs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003C4")]
			public bool UseHandBones;
		}

		[Cpp2IlInjected.Token(Token = "0x2000064")]
		[CompilerGenerated]
		private sealed class INLMEFAAGNP : IEnumerable<SkinnedMeshRenderer>, IEnumerable, IEnumerator<SkinnedMeshRenderer>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003CC")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003CD")]
			private SkinnedMeshRenderer <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003CE")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003CF")]
			public PlayerAvatarDisplayBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003D0")]
			private SkinnedMeshRenderer[] <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003D1")]
			private int <>7__wrap2;

			[Cpp2IlInjected.Token(Token = "0x17000097")]
			SkinnedMeshRenderer IEnumerator<SkinnedMeshRenderer>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000334")]
				[Cpp2IlInjected.Address(RVA = "0x963A50", Offset = "0x962C50", VA = "0x180963A50", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000098")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000336")]
				[Cpp2IlInjected.Address(RVA = "0x963A50", Offset = "0x962C50", VA = "0x180963A50", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000331")]
			[Cpp2IlInjected.Address(RVA = "0xD7DCC0", Offset = "0xD7CEC0", VA = "0x180D7DCC0")]
			[DebuggerHidden]
			public INLMEFAAGNP(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000332")]
			[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000333")]
			[Cpp2IlInjected.Address(RVA = "0x7471D10", Offset = "0x7470F10", VA = "0x187471D10", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000335")]
			[Cpp2IlInjected.Address(RVA = "0x7471F90", Offset = "0x7471190", VA = "0x187471F90", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000337")]
			[Cpp2IlInjected.Address(RVA = "0x7471EE0", Offset = "0x74710E0", VA = "0x187471EE0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<SkinnedMeshRenderer> IEnumerable<SkinnedMeshRenderer>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000338")]
			[Cpp2IlInjected.Address(RVA = "0x7471EE0", Offset = "0x74710E0", VA = "0x187471EE0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000065")]
		[CompilerGenerated]
		private sealed class NEOKCGJGEBB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003D2")]
			public PlayerAvatarDisplayBase display;

			[Cpp2IlInjected.Token(Token = "0x6000339")]
			[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
			public NEOKCGJGEBB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600033A")]
			[Cpp2IlInjected.Address(RVA = "0x7474670", Offset = "0x7473870", VA = "0x187474670")]
			internal bool FLMNCPMECCB()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000066")]
		[CompilerGenerated]
		private sealed class MBBBPHLKBEE : IEnumerator<DEPLMKJKOMK>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003D3")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003D4")]
			private DEPLMKJKOMK <>2__current;

			[Cpp2IlInjected.Token(Token = "0x17000099")]
			private DEPLMKJKOMK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600033E")]
				[Cpp2IlInjected.Address(RVA = "0x963A50", Offset = "0x962C50", VA = "0x180963A50", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009A")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000340")]
				[Cpp2IlInjected.Address(RVA = "0x963A50", Offset = "0x962C50", VA = "0x180963A50", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600033B")]
			[Cpp2IlInjected.Address(RVA = "0x963B40", Offset = "0x962D40", VA = "0x180963B40")]
			[DebuggerHidden]
			public MBBBPHLKBEE(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600033C")]
			[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600033D")]
			[Cpp2IlInjected.Address(RVA = "0x7473E10", Offset = "0x7473010", VA = "0x187473E10", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600033F")]
			[Cpp2IlInjected.Address(RVA = "0x74741E0", Offset = "0x74733E0", VA = "0x1874741E0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000067")]
		[CompilerGenerated]
		private struct LEAKBDHAMIL : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003D5")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003D6")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003D7")]
			public PlayerAvatarDisplayBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003D8")]
			public CDBIINFMANM avatarData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003D9")]
			private bool <forceRebuild>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003DA")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000341")]
			[Cpp2IlInjected.Address(RVA = "0x7472720", Offset = "0x7471920", VA = "0x187472720", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000342")]
			[Cpp2IlInjected.Address(RVA = "0x7472F00", Offset = "0x7472100", VA = "0x187472F00", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000068")]
		[CompilerGenerated]
		private sealed class OLOJMKLLLHD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003DB")]
			public string overrideIdentifier;

			[Cpp2IlInjected.Token(Token = "0x6000343")]
			[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
			public OLOJMKLLLHD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000344")]
			[Cpp2IlInjected.Address(RVA = "0x7475380", Offset = "0x7474580", VA = "0x187475380")]
			internal bool GNMJHNFDOCK(LFLMMHMGMIH selection)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000069")]
		[CompilerGenerated]
		private sealed class ACNPANAILGP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003DC")]
			public PlayerAvatarDisplayBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003DD")]
			public AvatarItemBodyType avatarItemBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003DE")]
			public Func<JBBNLHPJHLB<Dictionary<string, CAFFOJNOKAH<Texture2D>>>> <>9__2;

			[Cpp2IlInjected.Token(Token = "0x6000345")]
			[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
			public ACNPANAILGP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000346")]
			[Cpp2IlInjected.Address(RVA = "0x746C950", Offset = "0x746BB50", VA = "0x18746C950")]
			internal (EMKGHLOECBM, JBBNLHPJHLB<Dictionary<string, CAFFOJNOKAH<Texture2D>>>) JDOKKBPHHMC(Dictionary<string, JCNHDNCLCIK> avatarItems)
			{
				return default((EMKGHLOECBM, JBBNLHPJHLB<Dictionary<string, CAFFOJNOKAH<Texture2D>>>));
			}

			[Cpp2IlInjected.Token(Token = "0x6000347")]
			[Cpp2IlInjected.Address(RVA = "0x746CB50", Offset = "0x746BD50", VA = "0x18746CB50")]
			internal JBBNLHPJHLB<Dictionary<string, CAFFOJNOKAH<Texture2D>>> NIDGPCBINOC()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000348")]
			[Cpp2IlInjected.Address(RVA = "0x746CBC0", Offset = "0x746BDC0", VA = "0x18746CBC0")]
			internal void PCOGGPGICPC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006A")]
		[CompilerGenerated]
		private sealed class LMGOIANOEKN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003DF")]
			public Transform transformToCheck;

			[Cpp2IlInjected.Token(Token = "0x6000349")]
			[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
			public LMGOIANOEKN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034A")]
			[Cpp2IlInjected.Address(RVA = "0x7473800", Offset = "0x7472A00", VA = "0x187473800")]
			internal bool ONOHLGOEGBN(SkinnedMeshRenderer x)
			{
				return default(bool);
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200006B")]
		[CompilerGenerated]
		private struct IBEBGIEJFBA : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003E0")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003E1")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003E2")]
			public PlayerAvatarDisplayBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003E3")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600034B")]
			[Cpp2IlInjected.Address(RVA = "0x7471920", Offset = "0x7470B20", VA = "0x187471920", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034C")]
			[Cpp2IlInjected.Address(RVA = "0x7471AF0", Offset = "0x7470CF0", VA = "0x187471AF0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		protected static readonly int GNNHCIIKNIP;

		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		protected static readonly int NABBKJPANEI;

		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		protected static readonly int NAPJDJFGJFM;

		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		protected static readonly int CLNAONEBEPO;

		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		protected static readonly int FLNLNOBCALD;

		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		protected static readonly int NOCCEJCBHDN;

		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		protected static readonly int[] HADBFIMEGKD;

		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		protected static readonly int[] IHEGCDGPLJE;

		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		protected static readonly int[] CLNBJFCLOGI;

		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		protected static readonly int[] CIECMEGBIOK;

		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		protected static readonly int[] OMGDFMGJNGG;

		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		protected static readonly int[] GMNMJJAFMHD;

		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		protected static List<PlayerAvatarDisplayBase> HIFPINNNJMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		protected PAOLLJPJFIC POMCCLLEFKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		protected bool CJONAGMJDFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		protected bool AAMDLCFKKJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		[SerializeField]
		public AvatarBodyShapeVault BodyShapeVault;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		[SerializeField]
		public AvatarFaceShapeVault FaceShapeVault;

		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		protected static readonly int[] PDHGDAEACHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		[SerializeField]
		protected Material bodyPartMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		protected Dictionary<ADNODJGELIP, Material> PILACIPNOMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		protected Dictionary<ADNODJGELIP, Material> EMEPLHJALBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		[SerializeField]
		protected bool ignorePlayerMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		[SerializeField]
		protected Transform trackingSpace;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		[SerializeField]
		protected BodyPartLODs Head;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		[SerializeField]
		protected BodyPartLODs Ear;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		[SerializeField]
		protected BodyPartLODs Torso;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		[SerializeField]
		protected BodyPartLODs Hand;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		[SerializeField]
		protected BodyPartLODs HandPointing;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		[SerializeField]
		public PlayerHandBones HandBones;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		[SerializeField]
		public Transform remoteMeshBase;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		public readonly SkinnedMeshRenderer[] CurrentDefaultSkinnedMeshRenderers;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		public readonly SkinnedMeshRenderer[] NextDefaultSkinnedMeshRenderers;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		public readonly SkinnedMeshRenderer[] CurrentVisibleInFirstPersonSkinnedMeshRenderers;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		public readonly SkinnedMeshRenderer[] NextVisibleInFirstPersonSkinnedMeshRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		[SerializeField]
		public Transform firstPersonMeshBase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		[SerializeField]
		protected Shader uberShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		[SerializeField]
		protected Shader agAvatarShader;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		protected Material OLBGANKADLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		protected BMAGGMLBMKH LDPOPKBJHLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		private CPPODONDALD CAEGAOAPMBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		private CPPODONDALD BEOIOEAFMKL;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		protected Material OAOMDFNKBMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		[SerializeField]
		protected Transform headPropAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		[SerializeField]
		protected Transform hatAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		[SerializeField]
		public Transform hemisphereBase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		protected FitMeshHemisphere DKGMPMJHGMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		protected bool BNHEAAIHCBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		protected FJJMJDFJPJG FNCCLLILEHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		protected bool HIGMEAJEKGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		protected AnchorParamsRestrictions GCICGHHHLFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		protected bool LHJIBCNJAOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		protected Transform IKNBHOFINLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		protected bool CEBJPNDEFGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A9")]
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		protected bool GNFIJEALLPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1AC")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		protected Vector3 DFCFMAMIDMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		protected Quaternion EIAOPCFMNBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		protected Vector2 BFMGGNKDLEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		protected FitMeshHemisphere COACOBEHNOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		[SerializeField]
		[KPPBIEPJJJL(ADOEJJMOABO.SelfAndChildren, false, false, false)]
		protected PlayerFacialAnimatorBase facialAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		[SerializeField]
		protected Transform torsoPropAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		[SerializeField]
		protected Transform torsoRootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		[SerializeField]
		protected Transform headRootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		[SerializeField]
		protected Transform leftHandRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		[SerializeField]
		protected Transform leftHandDefaultScaleRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		[SerializeField]
		protected Transform rightHandRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		[SerializeField]
		protected Transform rightHandDefaultScaleRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
		[Cpp2IlInjected.Token(Token = "0x4000300")]
		[SerializeField]
		protected Animator leftHandAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
		[Cpp2IlInjected.Token(Token = "0x4000301")]
		[SerializeField]
		protected Animator rightHandAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
		[Cpp2IlInjected.Token(Token = "0x4000302")]
		[SerializeField]
		protected Transform leftHandPointingRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		[SerializeField]
		protected Transform rightHandPointingRoot;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		protected Collider[] GNGIKABEKEA;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		protected Collider[] ELFMJBAMEHM;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		protected FALLAAMPMDG[] PGEEGKPBIHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		[SerializeField]
		protected Mesh faceMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		public Dictionary<Renderer, BNIDAJFPCBE> currentPropertyBlocks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x4000309")]
		protected Dictionary<Renderer, BNIDAJFPCBE> IANEFAGMKPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
		[Cpp2IlInjected.Token(Token = "0x400030A")]
		protected BIECMGJDPME LODKIGIINHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
		[Cpp2IlInjected.Token(Token = "0x400030B")]
		protected EMKGHLOECBM PDHIBAGDGLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x400030C")]
		public OJGJEEMDGCF DistanceBand;

		[Cpp2IlInjected.FieldOffset(Offset = "0x27C")]
		[Cpp2IlInjected.Token(Token = "0x400030D")]
		protected int BAOOJBGANJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
		[Cpp2IlInjected.Token(Token = "0x400030E")]
		protected (bool isLodForced, int forcedLOD) APMABIOONBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
		[Cpp2IlInjected.Token(Token = "0x400030F")]
		protected GODAFHEHLEH<ILKCAEGHIBJ> GKHIDGGENOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
		[Cpp2IlInjected.Token(Token = "0x4000310")]
		protected bool DGIBKNFPPDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
		[Cpp2IlInjected.Token(Token = "0x4000312")]
		protected Dictionary<LFLMMHMGMIH, List<ADNODJGELIP>> AGKPJIGCLGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
		[Cpp2IlInjected.Token(Token = "0x4000313")]
		protected Dictionary<LFLMMHMGMIH, List<ADNODJGELIP>> MBAIJOMNIML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
		[Cpp2IlInjected.Token(Token = "0x4000314")]
		protected readonly Dictionary<string, CAFFOJNOKAH<Texture2D>> LGCBEEDPCML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B0")]
		[Cpp2IlInjected.Token(Token = "0x4000315")]
		protected readonly Dictionary<string, CAFFOJNOKAH<Texture2D>> DEIOEJLJHHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B8")]
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		protected bool JDDACEFLJCJ;

		[Cpp2IlInjected.Token(Token = "0x4000318")]
		protected static int CGELPNCDBMG;

		[Cpp2IlInjected.Token(Token = "0x4000319")]
		protected static List<NLBCGPDDAHC> MDJEKBKKFFF;

		[Cpp2IlInjected.Token(Token = "0x400031A")]
		protected static List<NLBCGPDDAHC> JNCOAPOAGHM;

		[Cpp2IlInjected.Token(Token = "0x400031B")]
		protected static PHFJKNHMAKK DGPBKKOOBEC;

		[Cpp2IlInjected.Token(Token = "0x400031C")]
		protected static bool NLACNJJHPLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
		[Cpp2IlInjected.Token(Token = "0x400031D")]
		protected Color? DFFHDDCANDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2DC")]
		[Cpp2IlInjected.Token(Token = "0x400031E")]
		protected bool HBABHGOPCPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E0")]
		[Cpp2IlInjected.Token(Token = "0x400031F")]
		protected Color EBDNDDOLMGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2F0")]
		[Cpp2IlInjected.Token(Token = "0x4000320")]
		protected Color NMIKOHBDIEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x300")]
		[Cpp2IlInjected.Token(Token = "0x4000321")]
		protected Color NICLEJBHOOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x310")]
		[Cpp2IlInjected.Token(Token = "0x4000322")]
		protected AvatarHairPattern CNANPMHIDAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x318")]
		[Cpp2IlInjected.Token(Token = "0x4000323")]
		protected HJICPBDJEDM DEPLCJEAAKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x320")]
		[Cpp2IlInjected.Token(Token = "0x4000324")]
		protected Color MCOJPELGKNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x330")]
		[Cpp2IlInjected.Token(Token = "0x4000325")]
		protected Color CKIBIIBNFLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x340")]
		[Cpp2IlInjected.Token(Token = "0x4000326")]
		protected AvatarHairPattern NDBMLPAEHNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x348")]
		[Cpp2IlInjected.Token(Token = "0x4000327")]
		protected HJICPBDJEDM MCEMNCCBBHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x350")]
		[Cpp2IlInjected.Token(Token = "0x4000328")]
		protected HJICPBDJEDM ODBFKFIDNEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x358")]
		[Cpp2IlInjected.Token(Token = "0x4000329")]
		protected Color HNJIFPLOOLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x368")]
		[Cpp2IlInjected.Token(Token = "0x400032A")]
		private AdditionalFeetData LCKBAABHPKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x370")]
		[Cpp2IlInjected.Token(Token = "0x400032B")]
		protected LFLMMHMGMIH? LAPHADAAEBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x388")]
		[Cpp2IlInjected.Token(Token = "0x400032C")]
		protected Texture EGOOODNKFBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x390")]
		[Cpp2IlInjected.Token(Token = "0x400032D")]
		protected Color PBJCAMLEMOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A0")]
		[Cpp2IlInjected.Token(Token = "0x400032E")]
		protected readonly IList<LFLMMHMGMIH> GNKMDIPBPIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A8")]
		[Cpp2IlInjected.Token(Token = "0x400032F")]
		protected readonly IList<LFLMMHMGMIH> ODKDHLHGOMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3B0")]
		[Cpp2IlInjected.Token(Token = "0x4000330")]
		private AvatarItemBodyType IIFFAECKJDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3B8")]
		[Cpp2IlInjected.Token(Token = "0x4000331")]
		[SerializeField]
		protected AvatarFaceShape _currentFaceShape;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C0")]
		[Cpp2IlInjected.Token(Token = "0x4000332")]
		[SerializeField]
		protected AvatarBodyShape _currentBodyShape;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C8")]
		[Cpp2IlInjected.Token(Token = "0x4000333")]
		[SerializeField]
		protected MKBBPKEHLCL _currentNoseType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3CC")]
		[Cpp2IlInjected.Token(Token = "0x4000334")]
		[SerializeField]
		protected bool _hideEars;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3CD")]
		[Cpp2IlInjected.Token(Token = "0x4000335")]
		protected JJMDMOBMJDH AJJHJGIFBFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D0")]
		[Cpp2IlInjected.Token(Token = "0x4000336")]
		protected int[] PMNKPMOHMOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D8")]
		[Cpp2IlInjected.Token(Token = "0x4000337")]
		protected bool PBNGDGBLFON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3E0")]
		[Cpp2IlInjected.Token(Token = "0x4000338")]
		protected int[] OEMGLOJEPIA;

		[Cpp2IlInjected.Token(Token = "0x4000339")]
		private static readonly LHOPHOECLDF.PDNJAPAFAJM MJOPJKOFJAO;

		[Cpp2IlInjected.Token(Token = "0x400033A")]
		private static readonly LHOPHOECLDF.PDNJAPAFAJM IFIBLCKILCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3E8")]
		[Cpp2IlInjected.Token(Token = "0x400033B")]
		protected bool LGIMNCGIBJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3F0")]
		[Cpp2IlInjected.Token(Token = "0x400033C")]
		protected LFIOEJONFIO CMFDGLFDBPN;

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public string GABKCNLODIP
		{
			[Cpp2IlInjected.Token(Token = "0x6000221")]
			[Cpp2IlInjected.Address(RVA = "0x964EC0", Offset = "0x9640C0", VA = "0x180964EC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000222")]
			[Cpp2IlInjected.Address(RVA = "0x968CE0", Offset = "0x967EE0", VA = "0x180968CE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public bool FFEJEGKKNNF
		{
			[Cpp2IlInjected.Token(Token = "0x6000224")]
			[Cpp2IlInjected.Address(RVA = "0xB62A00", Offset = "0xB61C00", VA = "0x180B62A00")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0xB629F0", Offset = "0xB61BF0", VA = "0x180B629F0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public virtual bool PFJJENKOCGM
		{
			[Cpp2IlInjected.Token(Token = "0x6000226")]
			[Cpp2IlInjected.Address(RVA = "0x9ACBB0", Offset = "0x9ABDB0", VA = "0x1809ACBB0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public bool FKIIAGGOEGK
		{
			[Cpp2IlInjected.Token(Token = "0x6000227")]
			[Cpp2IlInjected.Address(RVA = "0x746B400", Offset = "0x746A600", VA = "0x18746B400")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public virtual bool AOMFCAOHNIJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000228")]
			[Cpp2IlInjected.Address(RVA = "0x9ACBB0", Offset = "0x9ABDB0", VA = "0x1809ACBB0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public virtual bool FAEFKDKGKEN
		{
			[Cpp2IlInjected.Token(Token = "0x6000229")]
			[Cpp2IlInjected.Address(RVA = "0x97D6F0", Offset = "0x97C8F0", VA = "0x18097D6F0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public virtual bool PHJHDJODDHJ
		{
			[Cpp2IlInjected.Token(Token = "0x600022A")]
			[Cpp2IlInjected.Address(RVA = "0x9ACBB0", Offset = "0x9ABDB0", VA = "0x1809ACBB0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public BMAGGMLBMKH COLMPENOLMC
		{
			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0x9D6A10", Offset = "0x9D5C10", VA = "0x1809D6A10")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600022D")]
			[Cpp2IlInjected.Address(RVA = "0x746BB20", Offset = "0x746AD20", VA = "0x18746BB20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public CPPODONDALD DCGHPIACIGP
		{
			[Cpp2IlInjected.Token(Token = "0x600022E")]
			[Cpp2IlInjected.Address(RVA = "0x9D9EE0", Offset = "0x9D90E0", VA = "0x1809D9EE0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600022F")]
			[Cpp2IlInjected.Address(RVA = "0x746BF20", Offset = "0x746B120", VA = "0x18746BF20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public CPPODONDALD FENJBOAOJGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000230")]
			[Cpp2IlInjected.Address(RVA = "0x9DB040", Offset = "0x9DA240", VA = "0x1809DB040")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000231")]
			[Cpp2IlInjected.Address(RVA = "0x746C1F0", Offset = "0x746B3F0", VA = "0x18746C1F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		protected Material BOCCPNBLCEN
		{
			[Cpp2IlInjected.Token(Token = "0x6000232")]
			[Cpp2IlInjected.Address(RVA = "0x74619A0", Offset = "0x7460BA0", VA = "0x1874619A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		protected Material CFLIFHADBPG
		{
			[Cpp2IlInjected.Token(Token = "0x6000233")]
			[Cpp2IlInjected.Address(RVA = "0x7463C50", Offset = "0x7462E50", VA = "0x187463C50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public bool HPOEFBOGCAP
		{
			[Cpp2IlInjected.Token(Token = "0x6000234")]
			[Cpp2IlInjected.Address(RVA = "0x9EAB20", Offset = "0x9E9D20", VA = "0x1809EAB20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public PlayerFacialAnimatorBase FCAJEPBMPMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000238")]
			[Cpp2IlInjected.Address(RVA = "0x9EAAA0", Offset = "0x9E9CA0", VA = "0x1809EAAA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public FALLAAMPMDG[] PJLJDOIPOCF
		{
			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0x746AFD0", Offset = "0x746A1D0", VA = "0x18746AFD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public FALLAAMPMDG PAOKPOOCBPK
		{
			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0x746B600", Offset = "0x746A800", VA = "0x18746B600")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public FALLAAMPMDG KONJFADKOOO
		{
			[Cpp2IlInjected.Token(Token = "0x600023B")]
			[Cpp2IlInjected.Address(RVA = "0x746B630", Offset = "0x746A830", VA = "0x18746B630")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public Mesh HEOPFLAHAAK
		{
			[Cpp2IlInjected.Token(Token = "0x600023C")]
			[Cpp2IlInjected.Address(RVA = "0xCD64B0", Offset = "0xCD56B0", VA = "0x180CD64B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		protected BIECMGJDPME PJIHOGPJPFA
		{
			[Cpp2IlInjected.Token(Token = "0x600023D")]
			[Cpp2IlInjected.Address(RVA = "0x74626E0", Offset = "0x74618E0", VA = "0x1874626E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		protected EMKGHLOECBM LMPNNOLCGAP
		{
			[Cpp2IlInjected.Token(Token = "0x600023E")]
			[Cpp2IlInjected.Address(RVA = "0x1C48410", Offset = "0x1C47610", VA = "0x181C48410")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600023F")]
			[Cpp2IlInjected.Address(RVA = "0x74603B0", Offset = "0x745F5B0", VA = "0x1874603B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		protected bool NCBBCCIDDMG
		{
			[Cpp2IlInjected.Token(Token = "0x6000240")]
			[Cpp2IlInjected.Address(RVA = "0x97D6F0", Offset = "0x97C8F0", VA = "0x18097D6F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public bool DBCIFLNINIM
		{
			[Cpp2IlInjected.Token(Token = "0x6000241")]
			[Cpp2IlInjected.Address(RVA = "0x746B5F0", Offset = "0x746A7F0", VA = "0x18746B5F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public int CFJPLNFAADC
		{
			[Cpp2IlInjected.Token(Token = "0x6000242")]
			[Cpp2IlInjected.Address(RVA = "0x2016750", Offset = "0x2015950", VA = "0x182016750")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0x746C130", Offset = "0x746B330", VA = "0x18746C130")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public int PNLCGIKOGKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000244")]
			[Cpp2IlInjected.Address(RVA = "0x746BE70", Offset = "0x746B070", VA = "0x18746BE70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		protected virtual bool ABNDMHGLLAJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000245")]
			[Cpp2IlInjected.Address(RVA = "0x9ACBB0", Offset = "0x9ABDB0", VA = "0x1809ACBB0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		protected virtual int[] KNJEEIOPBDN
		{
			[Cpp2IlInjected.Token(Token = "0x6000246")]
			[Cpp2IlInjected.Address(RVA = "0x7462700", Offset = "0x7461900", VA = "0x187462700", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		protected bool KIMHLGPCDGN
		{
			[Cpp2IlInjected.Token(Token = "0x6000248")]
			[Cpp2IlInjected.Address(RVA = "0x745E2E0", Offset = "0x745D4E0", VA = "0x18745E2E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		protected static bool ICINJDJHLPN
		{
			[Cpp2IlInjected.Token(Token = "0x6000249")]
			[Cpp2IlInjected.Address(RVA = "0x9ACBB0", Offset = "0x9ABDB0", VA = "0x1809ACBB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public bool OPJNFHFOGCL
		{
			[Cpp2IlInjected.Token(Token = "0x600024A")]
			[Cpp2IlInjected.Address(RVA = "0xA7D910", Offset = "0xA7CB10", VA = "0x180A7D910")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0x746C400", Offset = "0x746B600", VA = "0x18746C400")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public IEnumerable<SkinnedMeshRenderer> BFKEECJFDKG
		{
			[Cpp2IlInjected.Token(Token = "0x600024C")]
			[Cpp2IlInjected.Address(RVA = "0x746AEB0", Offset = "0x746A0B0", VA = "0x18746AEB0")]
			[IteratorStateMachine(typeof(INLMEFAAGNP))]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public bool OBBODMNOFFK
		{
			[Cpp2IlInjected.Token(Token = "0x600024D")]
			[Cpp2IlInjected.Address(RVA = "0x746B5E0", Offset = "0x746A7E0", VA = "0x18746B5E0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600024E")]
			[Cpp2IlInjected.Address(RVA = "0x74611D0", Offset = "0x74603D0", VA = "0x1874611D0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public KJAEMCJAGMO AJLNOJKOLBG
		{
			[Cpp2IlInjected.Token(Token = "0x600024F")]
			[Cpp2IlInjected.Address(RVA = "0x746AF30", Offset = "0x746A130", VA = "0x18746AF30")]
			get
			{
				return default(KJAEMCJAGMO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public static bool IIMKFPPHCHF
		{
			[Cpp2IlInjected.Token(Token = "0x600026D")]
			[Cpp2IlInjected.Address(RVA = "0x746B370", Offset = "0x746A570", VA = "0x18746B370")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		protected static PHFJKNHMAKK GAPEEMLGBJP
		{
			[Cpp2IlInjected.Token(Token = "0x600026E")]
			[Cpp2IlInjected.Address(RVA = "0x7462790", Offset = "0x7461990", VA = "0x187462790")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600026F")]
			[Cpp2IlInjected.Address(RVA = "0x745E360", Offset = "0x745D560", VA = "0x18745E360")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		protected Color CCBODCPCMNB
		{
			[Cpp2IlInjected.Token(Token = "0x6000288")]
			[Cpp2IlInjected.Address(RVA = "0x7463B20", Offset = "0x7462D20", VA = "0x187463B20")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		protected Color FHNCPLKKEOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000289")]
			[Cpp2IlInjected.Address(RVA = "0x7463790", Offset = "0x7462990", VA = "0x187463790")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		protected Texture2D KNKPNLBNEDP
		{
			[Cpp2IlInjected.Token(Token = "0x600028A")]
			[Cpp2IlInjected.Address(RVA = "0x7462310", Offset = "0x7461510", VA = "0x187462310")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		protected Color HGEKGDFDKBE
		{
			[Cpp2IlInjected.Token(Token = "0x6000290")]
			[Cpp2IlInjected.Address(RVA = "0x7463C00", Offset = "0x7462E00", VA = "0x187463C00")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		protected Color IALCCDNBIAG
		{
			[Cpp2IlInjected.Token(Token = "0x6000291")]
			[Cpp2IlInjected.Address(RVA = "0x7462270", Offset = "0x7461470", VA = "0x187462270")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		public HJICPBDJEDM HPECBGECBHN
		{
			[Cpp2IlInjected.Token(Token = "0x6000292")]
			[Cpp2IlInjected.Address(RVA = "0x746AF90", Offset = "0x746A190", VA = "0x18746AF90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		protected Texture2D INLJJGFIGIM
		{
			[Cpp2IlInjected.Token(Token = "0x6000293")]
			[Cpp2IlInjected.Address(RVA = "0x74627E0", Offset = "0x74619E0", VA = "0x1874627E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public float OOABOEGHIGO
		{
			[Cpp2IlInjected.Token(Token = "0x600029A")]
			[Cpp2IlInjected.Address(RVA = "0x746AFB0", Offset = "0x746A1B0", VA = "0x18746AFB0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		public float DFJOGGDANBF
		{
			[Cpp2IlInjected.Token(Token = "0x600029B")]
			[Cpp2IlInjected.Address(RVA = "0x746B3E0", Offset = "0x746A5E0", VA = "0x18746B3E0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		public bool GOJHCHKLBOK
		{
			[Cpp2IlInjected.Token(Token = "0x60002CD")]
			[Cpp2IlInjected.Address(RVA = "0x58EB7F0", Offset = "0x58EA9F0", VA = "0x1858EB7F0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002CE")]
			[Cpp2IlInjected.Address(RVA = "0x746B900", Offset = "0x746AB00", VA = "0x18746B900")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action PMKKBBPACHI
		{
			[Cpp2IlInjected.Token(Token = "0x600021B")]
			[Cpp2IlInjected.Address(RVA = "0x746ACB0", Offset = "0x7469EB0", VA = "0x18746ACB0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600021C")]
			[Cpp2IlInjected.Address(RVA = "0x746B700", Offset = "0x746A900", VA = "0x18746B700")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action BILDFALDCIB
		{
			[Cpp2IlInjected.Token(Token = "0x600021D")]
			[Cpp2IlInjected.Address(RVA = "0x746AC10", Offset = "0x7469E10", VA = "0x18746AC10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600021E")]
			[Cpp2IlInjected.Address(RVA = "0x746B660", Offset = "0x746A860", VA = "0x18746B660")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action IDABCGHPKOF
		{
			[Cpp2IlInjected.Token(Token = "0x600021F")]
			[Cpp2IlInjected.Address(RVA = "0x746AD50", Offset = "0x7469F50", VA = "0x18746AD50")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000220")]
			[Cpp2IlInjected.Address(RVA = "0x746B7A0", Offset = "0x746A9A0", VA = "0x18746B7A0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action<HELPMFJLADN, LJHHNJNPPBE> ACIGDJHHDGB
		{
			[Cpp2IlInjected.Token(Token = "0x6000262")]
			[Cpp2IlInjected.Address(RVA = "0x746ADF0", Offset = "0x7469FF0", VA = "0x18746ADF0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000263")]
			[Cpp2IlInjected.Address(RVA = "0x746B840", Offset = "0x746AA40", VA = "0x18746B840")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x7467AF0", Offset = "0x7466CF0", VA = "0x187467AF0")]
		public bool SetDeformation(bool CJONAGMJDFE, bool AAMDLCFKKJB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x74653F0", Offset = "0x74645F0", VA = "0x1874653F0")]
		protected static Material OOGAIKMJMAA(Dictionary<ADNODJGELIP, Material> MBGPPIFNMEP, Material EFGNFHFGFEI, JGAOFPOEOPC DPFKBPIHFJH, BMAKHAEDKCP AMGIDDIOEEA, OCHNHLJBAPP GPIHEODLCOO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x7461BE0", Offset = "0x7460DE0", VA = "0x187461BE0")]
		protected void FBIOJOOHGIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x74612A0", Offset = "0x74604A0", VA = "0x1874612A0")]
		protected bool DGIKKNBHJEP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x7461900", Offset = "0x7460B00", VA = "0x187461900")]
		protected void EKCCJACDJAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x745E5E0", Offset = "0x745D7E0", VA = "0x18745E5E0", Slot = "10")]
		protected virtual void AODPJCIFCBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x74649B0", Offset = "0x7463BB0", VA = "0x1874649B0")]
		public int MeshesAtLODCount(int BFFLKICOKPI)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x7464080", Offset = "0x7463280", VA = "0x187464080")]
		protected static void MBMKDBKIAMA(Dictionary<LFLMMHMGMIH, List<ADNODJGELIP>> INMHGMBPIOL, DFILGOFENKI LMBJBPDGNBA, Material EFGNFHFGFEI, JGAOFPOEOPC IMLCDJMGLCP, BMAKHAEDKCP KFDPGMCILKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x745EF00", Offset = "0x745E100", VA = "0x18745EF00")]
		protected void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x7460780", Offset = "0x745F980", VA = "0x187460780")]
		protected void CPGBKOAJJGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x74655B0", Offset = "0x74647B0", VA = "0x1874655B0")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00", Slot = "11")]
		protected virtual void OAHADOAFCON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x7462C70", Offset = "0x7461E70", VA = "0x187462C70")]
		protected static void IDPOACGKNEK(List<Material> JIOHGJBBMJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x7464350", Offset = "0x7463550", VA = "0x187464350")]
		protected static void MKKLEEHHMJM(Dictionary<ADNODJGELIP, Material> MBGPPIFNMEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x7464850", Offset = "0x7463A50", VA = "0x187464850")]
		protected static void MPEMHOENLFG(Dictionary<Renderer, BNIDAJFPCBE> MKGBBDJCHOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x74625C0", Offset = "0x74617C0", VA = "0x1874625C0")]
		protected void HAOGDLFMFIA(SkinnedMeshRenderer[] FBPNFECAIOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x745E170", Offset = "0x745D370", VA = "0x18745E170")]
		protected void ABHHPMKJCGJ(SkinnedMeshRenderer MEFKAPPLHEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x745E210", Offset = "0x745D410", VA = "0x18745E210")]
		protected void ABHHPMKJCGJ(MeshRenderer MODDOMKCPEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x745F280", Offset = "0x745E480", VA = "0x18745F280")]
		protected void BGBDFHMGJHG(List<DIPMDJLELCL> MFHPFJEJFHJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x74644B0", Offset = "0x74636B0", VA = "0x1874644B0")]
		protected void MKLBIINJHCO(Dictionary<string, CAFFOJNOKAH<Texture2D>> INMHGMBPIOL, bool HOBBCFPJFJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x7460360", Offset = "0x745F560", VA = "0x187460360")]
		protected void CLHKBLMKPAF(Dictionary<LFLMMHMGMIH, List<ADNODJGELIP>> INMHGMBPIOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x7462400", Offset = "0x7461600", VA = "0x187462400")]
		public float GetHandOpenClosedAxis(HELPMFJLADN PMFEAPOHPML)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x7468390", Offset = "0x7467590", VA = "0x187468390")]
		public void SetHandOpenClosedAxis(HELPMFJLADN PMFEAPOHPML, float ILJOBKAEEIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x7462440", Offset = "0x7461640", VA = "0x187462440")]
		public LJHHNJNPPBE GetHandVisualState(HELPMFJLADN PMFEAPOHPML)
		{
			return default(LJHHNJNPPBE);
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x745E640", Offset = "0x745D840", VA = "0x18745E640")]
		public bool AddHandVisualStateToken(HELPMFJLADN PMFEAPOHPML, LJHHNJNPPBE JPDKHIAMBLC, object GIIKHLJPAKH, FALLAAMPMDG.HDOGMKAKIAB JHJIKIHJMOH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x7469B90", Offset = "0x7468D90", VA = "0x187469B90")]
		public void SetWatchHand(HELPMFJLADN PMFEAPOHPML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x7469C50", Offset = "0x7468E50", VA = "0x187469C50")]
		public void SetWatchHands(bool NFDHCFOBCAI, bool AKONKPDKODD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x74671B0", Offset = "0x74663B0", VA = "0x1874671B0")]
		public bool RemoveHandVisualStateToken(HELPMFJLADN PMFEAPOHPML, object GIIKHLJPAKH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x74624C0", Offset = "0x74616C0", VA = "0x1874624C0")]
		public bool GetThumbsUpActive(HELPMFJLADN PMFEAPOHPML)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x7469630", Offset = "0x7468830", VA = "0x187469630")]
		public void SetThumbsUpActive(HELPMFJLADN PMFEAPOHPML, bool EJMEPHBKLFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x7462480", Offset = "0x7461680", VA = "0x187462480")]
		public bool GetHandshakeActive(HELPMFJLADN PMFEAPOHPML)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x74683E0", Offset = "0x74675E0", VA = "0x1874683E0")]
		public void SetHandshakeActive(HELPMFJLADN PMFEAPOHPML, bool FDCPKLEGDFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x74622C0", Offset = "0x74614C0", VA = "0x1874622C0")]
		public void ForceUpdateHandsVisualState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x74610B0", Offset = "0x74602B0", VA = "0x1874610B0")]
		public static void ClearQueuedBuilds()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x7463D40", Offset = "0x7462F40", VA = "0x187463D40")]
		private static void LONDHPCFLOP(Scene ILIEDPLAPMG, LoadSceneMode PCJPKAENIHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x74617F0", Offset = "0x74609F0", VA = "0x1874617F0")]
		protected static void EGOPBNJDPPI(PlayerAvatarDisplayBase FGPEAFPGHDC, List<NLBCGPDDAHC> LNKMFNJEGPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x7466ED0", Offset = "0x74660D0", VA = "0x187466ED0")]
		public void Rebuild(bool EEPJMPHOHHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x7465180", Offset = "0x7464380", VA = "0x187465180")]
		protected void OLLCPJDIFOB(bool EEPJMPHOHHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x74651D0", Offset = "0x74643D0", VA = "0x1874651D0", Slot = "12")]
		protected virtual LHBFOPKLGGA OLLCPJDIFOB(IList<LFLMMHMGMIH> BKMOJNOFJMD, AvatarItemBodyType HHKPCMCCFNJ, bool IJNFAEOBAJD, int[] KAFPEFJIMHE, bool EEPJMPHOHHP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x745F8F0", Offset = "0x745EAF0", VA = "0x18745F8F0")]
		protected static LHBFOPKLGGA BNBMPJJFPAE(NLBCGPDDAHC MFHAIAAMCAE, List<NLBCGPDDAHC> LNKMFNJEGPG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x7465550", Offset = "0x7464750", VA = "0x187465550")]
		[IteratorStateMachine(typeof(MBBBPHLKBEE))]
		protected static IEnumerator<DEPLMKJKOMK> OOPIKLJLFEM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x7462500", Offset = "0x7461700", VA = "0x187462500")]
		protected static NLBCGPDDAHC HAKMBKOCLDB(List<NLBCGPDDAHC> LNKMFNJEGPG)
		{
			return default(NLBCGPDDAHC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x7467C00", Offset = "0x7466E00", VA = "0x187467C00")]
		[AsyncStateMachine(typeof(LEAKBDHAMIL))]
		public Task SetFaceCustomizationSettings(CDBIINFMANM PHMGCMMAOFN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x7462F50", Offset = "0x7462150", VA = "0x187462F50")]
		public void InitializeFaceFeatures(AvatarConfiguration DKJOEIJKMHK, KJAEMCJAGMO PJNNOBDKNHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x7469380", Offset = "0x7468580", VA = "0x187469380")]
		public void SetTeamColors(Color? EEHBPKPODPE, bool NOMDBCBILIA, Color POHFJINGGBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x1129D30", Offset = "0x1128F30", VA = "0x181129D30")]
		private static void JFFCGJPMKAE(Material MDMIJJAMBMD, Color OMFJNFBDJCA, params int[] KKLHJFODPPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x112A7A0", Offset = "0x11299A0", VA = "0x18112A7A0")]
		private static void NAKBHBODHDA(Material MDMIJJAMBMD, Texture OMFJNFBDJCA, params int[] KKLHJFODPPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x7464F00", Offset = "0x7464100", VA = "0x187464F00")]
		protected void OGNBINMICCJ(Material BGBKGHHFFCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x7464C40", Offset = "0x7463E40", VA = "0x187464C40")]
		protected void OALBICOMHGF(Material BGBKGHHFFCI, Color AFLELGACFJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x7464630", Offset = "0x7463830", VA = "0x187464630")]
		protected void MNOEFDCFIPE(Material BGBKGHHFFCI, Color AFLELGACFJG, Color CKIPBGMFLLN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x7463E70", Offset = "0x7463070", VA = "0x187463E70")]
		protected void MBEGDANAMMO(Material BGBKGHHFFCI, Texture2D GOADEEFLEJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x7463680", Offset = "0x7462880", VA = "0x187463680")]
		protected void JOEJLEPJMBL(Material BGBKGHHFFCI, Texture ADFCDCAMPLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x745F460", Offset = "0x745E660", VA = "0x18745F460")]
		protected void BJFPANLAPIE(Action<BNIDAJFPCBE> JCMBKOOLBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x7462A30", Offset = "0x7461C30", VA = "0x187462A30")]
		protected void ICEGFDDKOGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x7463920", Offset = "0x7462B20", VA = "0x187463920")]
		protected void KJCDNLJGMMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x7461D00", Offset = "0x7460F00", VA = "0x187461D00")]
		protected void FFEMPJLLJAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x745E990", Offset = "0x745DB90", VA = "0x18745E990")]
		public void ApplyUgcItemOverrides()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x7467570", Offset = "0x7466770", VA = "0x187467570")]
		public void SetBeardPrimaryColor([Optional] Color? FHFPNCIBDCC, bool LJBBHBILKKM = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x7467790", Offset = "0x7466990", VA = "0x187467790")]
		public void SetBeardSecondaryColor([Optional] Color? FHFPNCIBDCC, bool LJBBHBILKKM = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x7467430", Offset = "0x7466630", VA = "0x187467430")]
		public void SetBeardPattern([Optional] AvatarHairPattern IMOKKNEFIJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x7462060", Offset = "0x7461260", VA = "0x187462060")]
		private void FGIHGNLALOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x74637E0", Offset = "0x74629E0", VA = "0x1874637E0")]
		private bool KEEABGHCMMH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x7467F70", Offset = "0x7467170", VA = "0x187467F70")]
		public void SetHairPrimaryColor([Optional] Color? BBHEDOAFIKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x7468180", Offset = "0x7467380", VA = "0x187468180")]
		public void SetHairSecondaryColor([Optional] Color? BBHEDOAFIKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x7467E40", Offset = "0x7467040", VA = "0x187467E40")]
		public void SetHairPattern([Optional] AvatarHairPattern IMOKKNEFIJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x7467050", Offset = "0x7466250", VA = "0x187467050")]
		public void RefreshHair()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x74611E0", Offset = "0x74603E0", VA = "0x1874611E0")]
		private bool DCOIDCNJLCM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x74691C0", Offset = "0x74683C0", VA = "0x1874691C0")]
		public void SetSkinColor(Color OKIAKDLMDOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x7469680", Offset = "0x7468880", VA = "0x187469680")]
		public void SetUgcItemVisualOverrides(LFLMMHMGMIH GJEPDIBGLJH, KJAEMCJAGMO PJNNOBDKNHH, Texture BMDANBIIDCM, Color PMKBMMJPEIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x7461180", Offset = "0x7460380", VA = "0x187461180")]
		public void ClearUgcItemVisualOverrides()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x7467D00", Offset = "0x7466F00", VA = "0x187467D00")]
		public bool SetFaceShape(AvatarFaceShape HIHFLIMLNAB, bool KIOFDLCOPFF = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x7464B00", Offset = "0x7463D00", VA = "0x187464B00")]
		private void NHCHGPJFIDP(OBFILAGNCOE MLGJBLMEBNO, float OMFJNFBDJCA, bool OEGKJAPAFDO = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x745F080", Offset = "0x745E280", VA = "0x18745F080")]
		private void BCNPBGFLEON(AMFAMDDEACH CHPDDIEAKOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x74614C0", Offset = "0x74606C0", VA = "0x1874614C0")]
		private void DGKEMENHPIK(PNKEOEACGPH AEKMGAIBEPJ, float OMFJNFBDJCA, bool EKHKCMAHEJL = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x7466890", Offset = "0x7465A90", VA = "0x187466890")]
		private void PGOBAOOFHBC(JIBLNOFNNNI KGNGHFGCLOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x74679B0", Offset = "0x7466BB0", VA = "0x1874679B0")]
		public bool SetBodyShape(AvatarBodyShape HAANFMKKEGO, bool KIOFDLCOPFF = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x7469050", Offset = "0x7468250", VA = "0x187469050")]
		public bool SetNoseType(MKBBPKEHLCL OIMBBJJFICP, bool KIOFDLCOPFF = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x7469DB0", Offset = "0x7468FB0", VA = "0x187469DB0")]
		public bool UpdateFaceAndBodyShapes()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x7469030", Offset = "0x7468230", VA = "0x187469030")]
		public bool SetHideEars(bool DOGGOMCADAK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x7469020", Offset = "0x7468220", VA = "0x187469020")]
		public bool SetHelmetHair(PAOLLJPJFIC DAECHCGKMED)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x7468430", Offset = "0x7467630", VA = "0x187468430")]
		public void SetHatAnchorParameters(FJJMJDFJPJG ODBLHHBGHFN, bool JKPJIALHFJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x7469D20", Offset = "0x7468F20", VA = "0x187469D20")]
		public void SetupDisplayLODs(JJMDMOBMJDH IMGHADIDAEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x74600A0", Offset = "0x745F2A0", VA = "0x1874600A0")]
		protected int[] CJGDCCKDKEK(JJMDMOBMJDH IMGHADIDAEH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x7469180", Offset = "0x7468380", VA = "0x187469180")]
		public void SetOutfitSelections(IList<LFLMMHMGMIH> BKMOJNOFJMD, AvatarItemBodyType HHKPCMCCFNJ, bool EEPJMPHOHHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x74690F0", Offset = "0x74682F0", VA = "0x1874690F0")]
		public void SetOutfitSelections(IList<LFLMMHMGMIH> BKMOJNOFJMD, AvatarItemBodyType HHKPCMCCFNJ, bool IJNFAEOBAJD, bool EEPJMPHOHHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x7469130", Offset = "0x7468330", VA = "0x187469130")]
		public LHBFOPKLGGA SetOutfitSelections(IList<LFLMMHMGMIH> BKMOJNOFJMD, AvatarItemBodyType HHKPCMCCFNJ, JJMDMOBMJDH IMGHADIDAEH, bool IJNFAEOBAJD, bool KIOFDLCOPFF = false, bool EEPJMPHOHHP = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x745F5C0", Offset = "0x745E7C0", VA = "0x18745F5C0", Slot = "13")]
		protected virtual LHBFOPKLGGA BLONODNMALL(IList<LFLMMHMGMIH> BKMOJNOFJMD, AvatarItemBodyType HHKPCMCCFNJ, bool IJNFAEOBAJD, JJMDMOBMJDH IMGHADIDAEH, bool KIOFDLCOPFF, bool EEPJMPHOHHP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x7462DE0", Offset = "0x7461FE0", VA = "0x187462DE0")]
		protected int[] INANCHACNDP(JJMDMOBMJDH IMGHADIDAEH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x962E10", Offset = "0x962010", VA = "0x180962E10", Slot = "14")]
		protected virtual EMKGHLOECBM CMCLBNNCFJG(AvatarItemBodyType FPNGNOPBJOG, Dictionary<string, JCNHDNCLCIK> PGCGIJJFLGM, Dictionary<string, CAFFOJNOKAH<Texture2D>> GAADKPCAHDJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x7466C00", Offset = "0x7465E00", VA = "0x187466C00", Slot = "15")]
		protected virtual LHBFOPKLGGA PNEMOEBMKHP(IList<LFLMMHMGMIH> BKMOJNOFJMD, AvatarItemBodyType HHKPCMCCFNJ, bool IJNFAEOBAJD, int[] HJHBOOCCGFN, DKFIILHCHMC CBLFJBODFLK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x7463200", Offset = "0x7462400", VA = "0x187463200", Slot = "16")]
		protected virtual JCNHDNCLCIK JLNFCNKGBDO(HJICPBDJEDM PBBIHNAENOI, AvatarItemBodyType FPNGNOPBJOG, OCHNHLJBAPP GPIHEODLCOO, JCNHDNCLCIK BPJAHLJHFMN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x962E10", Offset = "0x962010", VA = "0x180962E10", Slot = "17")]
		protected virtual JCNHDNCLCIK FCKFCNPJGFJ(AvatarItemBodyType FPNGNOPBJOG, OCHNHLJBAPP GPIHEODLCOO, GABBAEJFCLA OCNNBPCACIL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x7463100", Offset = "0x7462300", VA = "0x187463100")]
		protected void JDBGEFOLINN(NNBPLOEBEJG FMGDMOPMBDP, LHOPHOECLDF.PDNJAPAFAJM FLCAJGHBDJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x7463180", Offset = "0x7462380", VA = "0x187463180")]
		protected void JLJEFHDJFDP(NNBPLOEBEJG FMGDMOPMBDP, LHOPHOECLDF.PDNJAPAFAJM FLCAJGHBDJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0xD042D0", Offset = "0xD034D0", VA = "0x180D042D0", Slot = "18")]
		protected virtual NNBPLOEBEJG ILBGGFALANH(NNBPLOEBEJG FMGDMOPMBDP, HelmetHairStyle CJFHPLKFJGL, bool GGDGEHLJKJL, AvatarItemBodyType HHKPCMCCFNJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x7465870", Offset = "0x7464A70", VA = "0x187465870")]
		protected NNBPLOEBEJG PDODFJHDKCE(IList<LFLMMHMGMIH> BKMOJNOFJMD, AvatarItemBodyType CPDPFMCLHPG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x7460F90", Offset = "0x7460190", VA = "0x187460F90")]
		public void CleanupDisplayResources()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x745FFF0", Offset = "0x745F1F0", VA = "0x18745FFF0")]
		protected void CIMMFAIGPDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x7460450", Offset = "0x745F650", VA = "0x187460450")]
		protected void CPCLOHKGMGK(Transform DLCOMCDOOBP, IEnumerable<SkinnedMeshRenderer> CFBHHLCNBGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x745E520", Offset = "0x745D720", VA = "0x18745E520")]
		protected LHOPHOECLDF.PDNJAPAFAJM ALLAHFHNINE(LHOPHOECLDF.PDNJAPAFAJM JGFFAFKCIPK, OCHNHLJBAPP PAJCAJDCMMO)
		{
			return default(LHOPHOECLDF.PDNJAPAFAJM);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x7461990", Offset = "0x7460B90", VA = "0x187461990")]
		protected void EMAFNPBANCF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x10814A0", Offset = "0x10806A0", VA = "0x1810814A0")]
		protected void POIFPFGINCG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x7460250", Offset = "0x745F450", VA = "0x187460250")]
		protected void CLFHGDNLAIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x7463030", Offset = "0x7462230", VA = "0x187463030")]
		[AsyncStateMachine(typeof(IBEBGIEJFBA))]
		protected Task JCMIFFHLJMG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x7466A60", Offset = "0x7465C60", VA = "0x187466A60")]
		protected static JGAOFPOEOPC PNAPJCHOIPJ(DFILGOFENKI MMPLJLGLJGA, int ACEOMHNKNFC)
		{
			return default(JGAOFPOEOPC);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x7464D60", Offset = "0x7463F60", VA = "0x187464D60")]
		protected static BMAKHAEDKCP OEJJHILJIGH(DFILGOFENKI MMPLJLGLJGA, int ACEOMHNKNFC)
		{
			return default(BMAKHAEDKCP);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x74653A0", Offset = "0x74645A0", VA = "0x1874653A0")]
		protected Transform OOBJBMJDKIF(OCHNHLJBAPP GPIHEODLCOO, OutfitType GFOBCJGOIFM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x7461560", Offset = "0x7460760", VA = "0x187461560")]
		protected void DNIEJHLCBDN(int DGMNCEHCMDA, Material MDMIJJAMBMD, DFILGOFENKI MMPLJLGLJGA, [Out] Texture2D CMNCEOKACKI, [Out] Vector4 IBKHBBNMANF, [Out] Texture2D HOLKMOFHIIN, [Out] Texture2D OGAPLKAJBHL, [Out] Texture2D CNBNJNIDNND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x74628E0", Offset = "0x7461AE0", VA = "0x1874628E0")]
		protected void IBFLLBOMABH(int DGMNCEHCMDA, Material MDMIJJAMBMD, DFILGOFENKI MMPLJLGLJGA, [Out] Color FJNKCFIGEIG, [Out] Color CKHPLMFFILE, [Out] Color OJMACNHOPBN, [Out] Color PLEADIFOMEI, [Out] Color PLHAMHNCCDP, [Out] Color IDBMGFOMLLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x7462EE0", Offset = "0x74620E0", VA = "0x187462EE0")]
		protected void IPKHICAHGDF(Vector3 LAHGFMKGHMK, Quaternion NEDOKMKIJNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x74689D0", Offset = "0x7467BD0", VA = "0x1874689D0")]
		public void SetHatAnchorParameters(FJJMJDFJPJG ODBLHHBGHFN, AnchorParamsRestrictions NBKGDEHIHPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x7460AB0", Offset = "0x745FCB0", VA = "0x187460AB0")]
		public static void CalculateHatAnchorParams(FitMeshHemisphere DKGMPMJHGMH, Transform IKNBHOFINLK, FJJMJDFJPJG ODBLHHBGHFN, AnchorParamsRestrictions GCICGHHHLFL, [Out] Vector3 CHBIEDJMOLB, [Out] Quaternion OAJCDGBGAPA, [Out] FJJMJDFJPJG CDMIHIHCLAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x74672C0", Offset = "0x74664C0", VA = "0x1874672C0")]
		public void ResetHatAnchor(Vector2 ODLMAJJABCC, Vector3 CLMIKENBGKJ, Vector3 NFIDKIBCEOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x9CADA0", Offset = "0x9C9FA0", VA = "0x1809CADA0")]
		public ELFKCADAIPA GetAnchorParamsRestrictions()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x745E7C0", Offset = "0x745D9C0", VA = "0x18745E7C0")]
		public void ApplyBlocks()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x745E900", Offset = "0x745DB00", VA = "0x18745E900")]
		public void ApplyHairPattern()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x745E730", Offset = "0x745D930", VA = "0x18745E730")]
		public void ApplyBeardPattern()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x7469D50", Offset = "0x7468F50", VA = "0x187469D50", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x74669A0", Offset = "0x7465BA0", VA = "0x1874669A0")]
		protected void PKPDKBNDLPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x7469B10", Offset = "0x7468D10", VA = "0x187469B10")]
		public void SetWaitForUgcTextureLoads(bool EICOJLKCCCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x7469A20", Offset = "0x7468C20", VA = "0x187469A20")]
		public void SetUgcTextureParameters(LFIOEJONFIO BNHLGDBCCDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x746A610", Offset = "0x7469810", VA = "0x18746A610")]
		public PlayerAvatarDisplayBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x7465310", Offset = "0x7464510", VA = "0x187465310")]
		[CompilerGenerated]
		private void OMCPJOMLGFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x7462DB0", Offset = "0x7461FB0", VA = "0x187462DB0")]
		[CompilerGenerated]
		private void ILEDGLHAHEN(BNIDAJFPCBE PNEPAOOMCOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x7463B70", Offset = "0x7462D70", VA = "0x187463B70")]
		[CompilerGenerated]
		private void LKIPEFBHCBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0x74621D0", Offset = "0x74613D0", VA = "0x1874621D0")]
		[CompilerGenerated]
		private void FLNPDFLHPCN(BNIDAJFPCBE PNEPAOOMCOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(RVA = "0x7464A70", Offset = "0x7463C70", VA = "0x187464A70")]
		[CompilerGenerated]
		private void NCODBODOCEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x7464BA0", Offset = "0x7463DA0", VA = "0x187464BA0")]
		[CompilerGenerated]
		private void NNEBEFKIBIP(BNIDAJFPCBE PNEPAOOMCOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x7463890", Offset = "0x7462A90", VA = "0x187463890")]
		[CompilerGenerated]
		private void KEMAEKJKPIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x7464EB0", Offset = "0x74640B0", VA = "0x187464EB0")]
		[CompilerGenerated]
		private void OGCAPLOANHI(BNIDAJFPCBE PNEPAOOMCOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x7461760", Offset = "0x7460960", VA = "0x187461760")]
		[CompilerGenerated]
		private void EBFJKLLIOKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x745FFA0", Offset = "0x745F1A0", VA = "0x18745FFA0")]
		[CompilerGenerated]
		private void CIAEAGNOIIN(BNIDAJFPCBE PNEPAOOMCOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x745FF10", Offset = "0x745F110", VA = "0x18745FF10")]
		[CompilerGenerated]
		private void CCHILEJAHHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x7465850", Offset = "0x7464A50", VA = "0x187465850")]
		[CompilerGenerated]
		private void PBGPAFPAPNE(BNIDAJFPCBE PNEPAOOMCOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x745F810", Offset = "0x745EA10", VA = "0x18745F810")]
		[CompilerGenerated]
		internal static bool BMDEJJMKPMK(Transform NJEAAOKFIKM, IEnumerable<SkinnedMeshRenderer> GCAHLGCBAKI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x7463AE0", Offset = "0x7462CE0", VA = "0x187463AE0")]
		[CompilerGenerated]
		private void LGEAKPNPCKJ(BNIDAJFPCBE PNEPAOOMCOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x7466850", Offset = "0x7465A50", VA = "0x187466850")]
		[CompilerGenerated]
		private void PGJAFMAEJHE(BNIDAJFPCBE PNEPAOOMCOF)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[ExecuteAlways]
	public class PlayerFacialAnimatorBase : MonoBehaviour, LCCLDLHOIOG
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200006D")]
		[CompilerGenerated]
		private struct FBGLKMFOAON : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400045E")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400045F")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000460")]
			public CDBIINFMANM avatarData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000461")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000462")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000394")]
			[Cpp2IlInjected.Address(RVA = "0x74715B0", Offset = "0x74707B0", VA = "0x1874715B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000395")]
			[Cpp2IlInjected.Address(RVA = "0x7471840", Offset = "0x7470A40", VA = "0x187471840", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200006E")]
		[CompilerGenerated]
		private struct MGPKLBLOFJH : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000463")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000464")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000465")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000466")]
			public int eyeSelection;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000467")]
			public int eyeBrowSelection;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000468")]
			public int noseSelection;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000469")]
			public int mouthSelection;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400046A")]
			public KJAEMCJAGMO avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400046B")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000396")]
			[Cpp2IlInjected.Address(RVA = "0x7474230", Offset = "0x7473430", VA = "0x187474230", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000397")]
			[Cpp2IlInjected.Address(RVA = "0x7474410", Offset = "0x7473610", VA = "0x187474410", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200006F")]
		[CompilerGenerated]
		private struct NEEBDBONJAD : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400046C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400046D")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400046E")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400046F")]
			public FaceFeatureType featureType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000470")]
			public int selectionIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000471")]
			public KJAEMCJAGMO avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000472")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000398")]
			[Cpp2IlInjected.Address(RVA = "0x7474470", Offset = "0x7473670", VA = "0x187474470", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000399")]
			[Cpp2IlInjected.Address(RVA = "0x7474610", Offset = "0x7473810", VA = "0x187474610", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000070")]
		[CompilerGenerated]
		private struct KBBELELKJFH : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000473")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000474")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000475")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000476")]
			public CDBIINFMANM avatarData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000477")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600039A")]
			[Cpp2IlInjected.Address(RVA = "0x7472510", Offset = "0x7471710", VA = "0x187472510", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600039B")]
			[Cpp2IlInjected.Address(RVA = "0x74726C0", Offset = "0x74718C0", VA = "0x1874726C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000071")]
		[CompilerGenerated]
		private struct FALNHBFAMGF : IAsyncStateMachine
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
			public KJAEMCJAGMO avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400047C")]
			private TaskAwaiter<PJNKFCCNBHG> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600039C")]
			[Cpp2IlInjected.Address(RVA = "0x7471130", Offset = "0x7470330", VA = "0x187471130", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600039D")]
			[Cpp2IlInjected.Address(RVA = "0x7471550", Offset = "0x7470750", VA = "0x187471550", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000072")]
		[CompilerGenerated]
		private struct JPKIDLFJLJO : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400047D")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400047E")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400047F")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000480")]
			public bool forceRebuild;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000481")]
			public KJAEMCJAGMO avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000482")]
			private FaceStyleSet <styleSet>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000483")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600039E")]
			[Cpp2IlInjected.Address(RVA = "0x7471FE0", Offset = "0x74711E0", VA = "0x187471FE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600039F")]
			[Cpp2IlInjected.Address(RVA = "0x74724B0", Offset = "0x74716B0", VA = "0x1874724B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40003E4")]
		protected const float DLICDLDGHJN = 0.5f;

		[Cpp2IlInjected.Token(Token = "0x40003E5")]
		protected const int LCPPIPHBKKD = 5;

		[Cpp2IlInjected.Token(Token = "0x40003E6")]
		public static readonly int IdleID;

		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		public static readonly int SmileID;

		[Cpp2IlInjected.Token(Token = "0x40003E8")]
		public static readonly int HugeSmileID;

		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		public static readonly int ScoreID;

		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		public static readonly int SadID;

		[Cpp2IlInjected.Token(Token = "0x40003EB")]
		public static readonly int DisgustID;

		[Cpp2IlInjected.Token(Token = "0x40003EC")]
		public static readonly int HitID;

		[Cpp2IlInjected.Token(Token = "0x40003ED")]
		public static readonly int ConcentrateID;

		[Cpp2IlInjected.Token(Token = "0x40003EE")]
		public static readonly int KissID;

		[Cpp2IlInjected.Token(Token = "0x40003EF")]
		public static readonly int TalkingID;

		[Cpp2IlInjected.Token(Token = "0x40003F0")]
		public static readonly int MuteID;

		[Cpp2IlInjected.Token(Token = "0x40003F1")]
		public static readonly int AFKID;

		[Cpp2IlInjected.Token(Token = "0x40003F2")]
		public static readonly int HappyID;

		[Cpp2IlInjected.Token(Token = "0x40003F3")]
		public static readonly int EmoteFlatID;

		[Cpp2IlInjected.Token(Token = "0x40003F4")]
		public static readonly int EmoteHappyID;

		[Cpp2IlInjected.Token(Token = "0x40003F5")]
		public static readonly int EmoteSadID;

		[Cpp2IlInjected.Token(Token = "0x40003F6")]
		public static readonly int EmoteLoveID;

		[Cpp2IlInjected.Token(Token = "0x40003F7")]
		public static readonly int EmoteAngryID;

		[Cpp2IlInjected.Token(Token = "0x40003F8")]
		public static readonly int EmoteLaughID;

		[Cpp2IlInjected.Token(Token = "0x40003F9")]
		public static readonly int EmoteTongueOutID;

		[Cpp2IlInjected.Token(Token = "0x40003FA")]
		public static readonly int EmoteGrimacingID;

		[Cpp2IlInjected.Token(Token = "0x40003FB")]
		public static readonly int EmoteWinkID;

		[Cpp2IlInjected.Token(Token = "0x40003FC")]
		public static readonly int EmoteShockedID;

		[Cpp2IlInjected.Token(Token = "0x40003FD")]
		public static readonly int EmoteNauseatedID;

		[Cpp2IlInjected.Token(Token = "0x40003FE")]
		public static readonly int EmoteSmileSweatID;

		[Cpp2IlInjected.Token(Token = "0x40003FF")]
		public static readonly int EmoteSleepingID;

		[Cpp2IlInjected.Token(Token = "0x4000400")]
		public static readonly int EmoteThinkingID;

		[Cpp2IlInjected.Token(Token = "0x4000401")]
		public static readonly int EmoteSmirkID;

		[Cpp2IlInjected.Token(Token = "0x4000402")]
		public static readonly int EmoteSmileID;

		[Cpp2IlInjected.Token(Token = "0x4000403")]
		protected static readonly Dictionary<DBLEPMOEFKC.KHDAOMFDEGN, int> LANCLHPEIOJ;

		[Cpp2IlInjected.Token(Token = "0x4000404")]
		[CanBeNull]
		protected static IEnumerable<FaceFeatureType> PNFDCPGBFOK;

		[Cpp2IlInjected.Token(Token = "0x4000405")]
		protected static readonly int HIHOFKKECHL;

		[Cpp2IlInjected.Token(Token = "0x4000406")]
		protected static readonly int PBPLGPKHOHH;

		[Cpp2IlInjected.Token(Token = "0x4000407")]
		protected static readonly int MLHBALKPNIO;

		[Cpp2IlInjected.Token(Token = "0x4000408")]
		protected static readonly int CMOCKMCFPHF;

		[Cpp2IlInjected.Token(Token = "0x4000409")]
		protected static readonly int NLKPKKGOKMO;

		[Cpp2IlInjected.Token(Token = "0x400040A")]
		protected static readonly int GIIPMEBDIJA;

		[Cpp2IlInjected.Token(Token = "0x400040B")]
		protected static readonly int EPGIDKGAJII;

		[Cpp2IlInjected.Token(Token = "0x400040C")]
		protected static readonly int OABDOACBLJM;

		[Cpp2IlInjected.Token(Token = "0x400040D")]
		protected static Vector2 JOAABAIDKHK;

		[Cpp2IlInjected.Token(Token = "0x400040E")]
		protected static Vector2 GIFKHKGPMNM;

		[Cpp2IlInjected.Token(Token = "0x400040F")]
		protected static Vector2 OFHHAKKPLDB;

		[Cpp2IlInjected.Token(Token = "0x4000410")]
		protected static Vector2 MAPAOCGOFBO;

		[Cpp2IlInjected.Token(Token = "0x4000411")]
		protected static Vector2 JALINMLDLHP;

		[Cpp2IlInjected.Token(Token = "0x4000412")]
		protected static Vector2 PLLOMDCLBEL;

		[Cpp2IlInjected.Token(Token = "0x4000413")]
		protected static Vector2 IJNIDHAMFEC;

		[Cpp2IlInjected.Token(Token = "0x4000414")]
		protected static Vector2 FFLKPJIGCGC;

		[Cpp2IlInjected.Token(Token = "0x4000415")]
		protected static Vector2 JBAPECHODEK;

		[Cpp2IlInjected.Token(Token = "0x4000416")]
		protected static Vector2 NCPENIDDAIB;

		[Cpp2IlInjected.Token(Token = "0x4000417")]
		protected static Vector2 BGLEPEFIBGP;

		[Cpp2IlInjected.Token(Token = "0x4000418")]
		protected static Vector2 DNFEGFGLGMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000419")]
		[SerializeField]
		[KPPBIEPJJJL(ADOEJJMOABO.Self, false, false, false)]
		public Animator animator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400041A")]
		[Header("Rendering")]
		[SerializeField]
		public FaceStyleSet faceStyleSet;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400041B")]
		[SerializeField]
		protected Renderer faceRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400041C")]
		[SerializeField]
		protected float jitterFPS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400041D")]
		[Header("Emotes")]
		[SerializeField]
		public Renderer[] emoteEffectRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400041E")]
		[FormerlySerializedAs("fullBodyFaceStyleSet")]
		[Header("Modern Avatar Facial Features")]
		[SerializeField]
		public FaceStyleSet modernBodyFaceStyleSet;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400041F")]
		private KJAEMCJAGMO OMEFPNKKHMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000420")]
		private FaceStyleSet BKPMPLHMKOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000421")]
		[SerializeField]
		protected bool debugEyeJitterInEditor;

		[Cpp2IlInjected.Token(Token = "0x4000422")]
		protected const int PFKJIFAPJDI = -1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000423")]
		protected int DNNCCOMNIMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000424")]
		protected int BLGGFFBJBFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000425")]
		protected int AJGGNOKKGGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000426")]
		protected int DHAFKJMEKOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000427")]
		protected Vector2 KAIMEILJDBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000428")]
		protected float HMGHKOOHHCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000429")]
		protected float BGCABDGFKAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x400042A")]
		protected float CLOKCILIGAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400042B")]
		protected Vector2 DLJHMMJKDGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400042C")]
		protected float OLKMAFMICLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x400042D")]
		protected float BDDBDFFLIJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400042E")]
		protected float OAKINFNKAEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x400042F")]
		protected Vector2 OHKBIMDFBPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x4000430")]
		protected float DFFHEDGPOMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000431")]
		protected float LMOKFBODHHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x4000432")]
		protected float LOEHBODOIOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000433")]
		protected Vector2 AGGHFAHCMHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000434")]
		protected float HDNJKBGLCDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x4000435")]
		protected float KILGDPAAPOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000436")]
		protected float DCPBHBMOFCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000437")]
		protected List<SelectableFaceOption> DAJMBIIBBHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000438")]
		protected List<SelectableFaceOption> PFDPOAEILLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000439")]
		protected List<SelectableFaceOption> KEECJNGNCOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400043A")]
		protected List<SelectableFaceOption> FIFKIHDLDDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400043B")]
		protected Coroutine KGAKAFKJCKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400043C")]
		protected int? KAICPDNAJMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400043D")]
		protected int BFKPPNFNEIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
		[Cpp2IlInjected.Token(Token = "0x400043E")]
		protected int FEMNJHGHJNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400043F")]
		protected int JJIGLEBLCCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
		[Cpp2IlInjected.Token(Token = "0x4000440")]
		protected int IHADJEFIJJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000441")]
		protected int KOCHBPHJEGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
		[Cpp2IlInjected.Token(Token = "0x4000442")]
		protected int OCOGKLNFEPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000443")]
		protected Sprite FMOBBHLCDJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000444")]
		protected Sprite EGPGFOPFHIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000445")]
		protected Sprite PCCOPONBOHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000446")]
		protected Sprite IDCEKNKIPMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000447")]
		protected bool OENLKAMEJHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000449")]
		protected string IJACIFFGDKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x400044A")]
		protected string AECMHPPAIOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x400044B")]
		protected string OPPCKNLCIEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x400044C")]
		protected string EJALGCFIJMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x400044D")]
		[ReadOnlyField]
		public Sprite eyeSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x400044E")]
		[ReadOnlyField]
		public Sprite leftEyeOnlySprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x400044F")]
		[ReadOnlyField]
		public Sprite rightEyeOnlySprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x4000450")]
		public Color leftEyeColorTint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x4000451")]
		public Color leftEyeGleamColorTint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x4000452")]
		public Color rightEyeColorTint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x4000453")]
		public Color rightEyeGleamColorTint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x4000454")]
		[ReadOnlyField]
		public Sprite mouthSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x4000458")]
		protected AvatarConfiguration DKJOEIJKMHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x4000459")]
		protected PJNKFCCNBHG MPODBPKLJAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x400045B")]
		private readonly List<Material> BMLIJIHDNPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x400045C")]
		protected AONHDHEBBAB CGOKCLMHALM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
		[Cpp2IlInjected.Token(Token = "0x400045D")]
		protected Dictionary<string, int> FAIDNJCBKJE;

		[Cpp2IlInjected.Token(Token = "0x1700009B")]
		public FaceStyleSet JJLKLPGFHJE
		{
			[Cpp2IlInjected.Token(Token = "0x600034D")]
			[Cpp2IlInjected.Address(RVA = "0x747B520", Offset = "0x747A720", VA = "0x18747B520")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009C")]
		public bool HJKOOPCMMKN
		{
			[Cpp2IlInjected.Token(Token = "0x6000350")]
			[Cpp2IlInjected.Address(RVA = "0x9D2250", Offset = "0x9D1450", VA = "0x1809D2250", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000351")]
			[Cpp2IlInjected.Address(RVA = "0x1FDB260", Offset = "0x1FDA460", VA = "0x181FDB260")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		protected virtual bool GDGAMGGAAFB
		{
			[Cpp2IlInjected.Token(Token = "0x6000352")]
			[Cpp2IlInjected.Address(RVA = "0x9ACBB0", Offset = "0x9ABDB0", VA = "0x1809ACBB0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009E")]
		protected virtual bool JJCGJCMADAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000353")]
			[Cpp2IlInjected.Address(RVA = "0x97D6F0", Offset = "0x97C8F0", VA = "0x18097D6F0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		protected int OHCJMGMFMPE
		{
			[Cpp2IlInjected.Token(Token = "0x6000354")]
			[Cpp2IlInjected.Address(RVA = "0x74768D0", Offset = "0x7475AD0", VA = "0x1874768D0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A0")]
		public Renderer IKJAKIENOPN
		{
			[Cpp2IlInjected.Token(Token = "0x6000355")]
			[Cpp2IlInjected.Address(RVA = "0x964CD0", Offset = "0x963ED0", VA = "0x180964CD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A1")]
		public bool PCDILMJEMKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000356")]
			[Cpp2IlInjected.Address(RVA = "0x9D5D30", Offset = "0x9D4F30", VA = "0x1809D5D30")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000357")]
			[Cpp2IlInjected.Address(RVA = "0x747B7C0", Offset = "0x747A9C0", VA = "0x18747B7C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A2")]
		public Renderer[] EPAGKKKOFMN
		{
			[Cpp2IlInjected.Token(Token = "0x6000358")]
			[Cpp2IlInjected.Address(RVA = "0x964F30", Offset = "0x964130", VA = "0x180964F30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A3")]
		public bool FEMOLFBBFGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000359")]
			[Cpp2IlInjected.Address(RVA = "0x747B560", Offset = "0x747A760", VA = "0x18747B560")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600035A")]
			[Cpp2IlInjected.Address(RVA = "0x747B720", Offset = "0x747A920", VA = "0x18747B720")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A4")]
		protected int COOGNONKBKO
		{
			[Cpp2IlInjected.Token(Token = "0x600035B")]
			[Cpp2IlInjected.Address(RVA = "0x7478620", Offset = "0x7477820", VA = "0x187478620")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		protected int GNEJFANFPMF
		{
			[Cpp2IlInjected.Token(Token = "0x600035C")]
			[Cpp2IlInjected.Address(RVA = "0x7477C90", Offset = "0x7476E90", VA = "0x187477C90")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A6")]
		public float PJOBPNEEFFG
		{
			[Cpp2IlInjected.Token(Token = "0x600035D")]
			[Cpp2IlInjected.Address(RVA = "0x747B540", Offset = "0x747A740", VA = "0x18747B540")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600035E")]
			[Cpp2IlInjected.Address(RVA = "0x747B700", Offset = "0x747A900", VA = "0x18747B700")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A7")]
		public EIDCFIKENAJ AHMHLAKDHIF
		{
			[Cpp2IlInjected.Token(Token = "0x600035F")]
			[Cpp2IlInjected.Address(RVA = "0x9CC0E0", Offset = "0x9CB2E0", VA = "0x1809CC0E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000360")]
			[Cpp2IlInjected.Address(RVA = "0x9EAE10", Offset = "0x9EA010", VA = "0x1809EAE10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A8")]
		public PJNKFCCNBHG AEMHBDONLLI
		{
			[Cpp2IlInjected.Token(Token = "0x600037C")]
			[Cpp2IlInjected.Address(RVA = "0x9D7460", Offset = "0x9D6660", VA = "0x1809D7460")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600037D")]
			[Cpp2IlInjected.Address(RVA = "0x747B680", Offset = "0x747A880", VA = "0x18747B680")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A9")]
		public NoseFaceOption MIBACHBENIN
		{
			[Cpp2IlInjected.Token(Token = "0x600037E")]
			[Cpp2IlInjected.Address(RVA = "0x9EAAA0", Offset = "0x9E9CA0", VA = "0x1809EAAA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600037F")]
			[Cpp2IlInjected.Address(RVA = "0xA4C9E0", Offset = "0xA4BBE0", VA = "0x180A4C9E0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AA")]
		protected AONHDHEBBAB PDCAIKCLAHO
		{
			[Cpp2IlInjected.Token(Token = "0x6000380")]
			[Cpp2IlInjected.Address(RVA = "0x74778F0", Offset = "0x7476AF0", VA = "0x1874778F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action PFEAPPCNGIE
		{
			[Cpp2IlInjected.Token(Token = "0x600034E")]
			[Cpp2IlInjected.Address(RVA = "0x747B470", Offset = "0x747A670", VA = "0x18747B470")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600034F")]
			[Cpp2IlInjected.Address(RVA = "0x747B5D0", Offset = "0x747A7D0", VA = "0x18747B5D0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x7477CF0", Offset = "0x7476EF0", VA = "0x187477CF0")]
		public void LocalPlayEmote(DBLEPMOEFKC.KHDAOMFDEGN NPLKPHGKGPH, float BKGDLCKLIBB = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x7477330", Offset = "0x7476530", VA = "0x187477330")]
		public bool IsEmotePlaying(DBLEPMOEFKC.KHDAOMFDEGN NPLKPHGKGPH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x7479470", Offset = "0x7478670", VA = "0x187479470")]
		public void SetIdleHappy(bool GPAPJMJGMJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x7475750", Offset = "0x7474950", VA = "0x187475750")]
		protected void BEIIOMALJEF(bool CBFHGMIJBBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x7476D00", Offset = "0x7475F00", VA = "0x187476D00")]
		protected void IKLENCPHPHF(bool AKHIOCHAKNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x7476860", Offset = "0x7475A60", VA = "0x187476860")]
		protected void DOCGKNINHNF(OCHNHLJBAPP GPIHEODLCOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x7477970", Offset = "0x7476B70", VA = "0x187477970")]
		protected void KGADCFILCID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x7478C80", Offset = "0x7477E80", VA = "0x187478C80")]
		public void PlayExpression(int ECGILBOGPDF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x74757D0", Offset = "0x74749D0", VA = "0x1874757D0")]
		protected void BIPPPKPHEBN(bool KNHGLPBKEJD, bool OCHDKHOPBOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x7476BD0", Offset = "0x7475DD0", VA = "0x187476BD0")]
		public List<SelectableFaceOption> GetAvailableFeatures(FaceFeatureType MKEBMFCLGPB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x7476E60", Offset = "0x7476060", VA = "0x187476E60")]
		public void InitializeFaceFeatureRanges(AvatarConfiguration DKJOEIJKMHK, KJAEMCJAGMO PJNNOBDKNHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x7479380", Offset = "0x7478580", VA = "0x187479380")]
		[AsyncStateMachine(typeof(FBGLKMFOAON))]
		public Task SetFaceSettings(CDBIINFMANM PHMGCMMAOFN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x7479250", Offset = "0x7478450", VA = "0x187479250")]
		[AsyncStateMachine(typeof(MGPKLBLOFJH))]
		public Task SetFaceSettings(int NGMIEFKEDFP, int KEBJMLBCKPF, int OMGOJNFCOBG, int MCOFGDIANIG, KJAEMCJAGMO PJNNOBDKNHH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x74794F0", Offset = "0x74786F0", VA = "0x1874794F0")]
		[AsyncStateMachine(typeof(NEEBDBONJAD))]
		public Task SetSelectedFaceFeatureAndBuildFaceStyle(FaceFeatureType MKEBMFCLGPB, int BGJPDMFHPKF, KJAEMCJAGMO PJNNOBDKNHH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x7478970", Offset = "0x7477B70", VA = "0x187478970")]
		protected void PMMCKAIJKIN(FaceFeatureType MKEBMFCLGPB, FKCADKOIAIJ NEKBMPMCJNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x7476010", Offset = "0x7475210", VA = "0x187476010")]
		protected void CLDBFJAFNJD(FaceFeatureType MKEBMFCLGPB, int BGJPDMFHPKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x7476A00", Offset = "0x7475C00", VA = "0x187476A00")]
		public static IEnumerable<FaceFeatureType> GetAllFaceFeatureTypes()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x7476C10", Offset = "0x7475E10", VA = "0x187476C10")]
		[AsyncStateMachine(typeof(KBBELELKJFH))]
		protected Task IKEOAEDGPLO(CDBIINFMANM PHMGCMMAOFN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x7477520", Offset = "0x7476720", VA = "0x187477520")]
		protected void JFDAEONELJJ(CDBIINFMANM PHMGCMMAOFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x7478AF0", Offset = "0x7477CF0", VA = "0x187478AF0")]
		protected static void POADPHKEOGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x74753B0", Offset = "0x74745B0", VA = "0x1874753B0")]
		private void AAELHFKNEFH(bool PIOGAKIEFEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x7475C80", Offset = "0x7474E80", VA = "0x187475C80")]
		protected void CKIOMAAIHNE(FaceFeatureType MKEBMFCLGPB, Vector2 AMJLEEFMHCK, KJAEMCJAGMO PJNNOBDKNHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x7478CA0", Offset = "0x7477EA0", VA = "0x187478CA0")]
		public void SetFaceFeatureNormalizedPositionOffset(FaceFeatureType MKEBMFCLGPB, Vector2 DLANGGNMABL, KJAEMCJAGMO PJNNOBDKNHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x7475B00", Offset = "0x7474D00", VA = "0x187475B00")]
		protected void CJOOFBOHJJE(FaceFeatureType MKEBMFCLGPB, float DICDCKDEFAH, KJAEMCJAGMO PJNNOBDKNHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x7475880", Offset = "0x7474A80", VA = "0x187475880")]
		protected void BJKBCMEJAHB(FaceFeatureType MKEBMFCLGPB, float GLMEOLPKLCA, KJAEMCJAGMO PJNNOBDKNHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x7477820", Offset = "0x7476A20", VA = "0x187477820")]
		protected void JIDKKOPJEFB(FaceFeatureType MKEBMFCLGPB, float ONFBOIMHMFP, KJAEMCJAGMO PJNNOBDKNHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x7479030", Offset = "0x7478230", VA = "0x187479030")]
		public void SetFaceFeatureNormalizedScaleOffset(FaceFeatureType MKEBMFCLGPB, float FMKMNEKCLJL, KJAEMCJAGMO PJNNOBDKNHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x7478890", Offset = "0x7477A90", VA = "0x187478890")]
		[AsyncStateMachine(typeof(FALNHBFAMGF))]
		protected Task PAOLAHMNNKM(KJAEMCJAGMO PJNNOBDKNHH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x7477120", Offset = "0x7476320", VA = "0x187477120")]
		public void InitializeFaceFeatureStyleSet(KJAEMCJAGMO PJNNOBDKNHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x7477440", Offset = "0x7476640", VA = "0x187477440")]
		protected bool JBCAMHNHINC(string MLHKKCPGJGE, [Out] int KOOLKCPAFBB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x7475610", Offset = "0x7474810", VA = "0x187475610")]
		protected void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x14701C0", Offset = "0x146F3C0", VA = "0x1814701C0", Slot = "8")]
		protected virtual void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x7478680", Offset = "0x7477880", VA = "0x187478680")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x747A610", Offset = "0x7479810", VA = "0x18747A610")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x7475A00", Offset = "0x7474C00", VA = "0x187475A00")]
		[AsyncStateMachine(typeof(JPKIDLFJLJO))]
		public Task BuildFaceStyleAsyncIfChanged(KJAEMCJAGMO PJNNOBDKNHH, bool KIOFDLCOPFF = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x7479F30", Offset = "0x7479130", VA = "0x187479F30")]
		public void UpdateFaceDisplays(bool IGELLDLAFBM = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x7477DE0", Offset = "0x7476FE0", VA = "0x187477DE0")]
		protected bool NGIAFOIGBDA(bool IGELLDLAFBM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x7479C50", Offset = "0x7478E50", VA = "0x187479C50")]
		public void UpdateFaceDisplayFeatureTextures()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x7479600", Offset = "0x7478800", VA = "0x187479600")]
		public void UpdateFaceDisplayFeaturePositions()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x747A140", Offset = "0x7479340", VA = "0x18747A140")]
		public void UpdateFaceJitterMultiplier()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x747A330", Offset = "0x7479530", VA = "0x18747A330")]
		public bool UpdateLegacyFaceVectors()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x7476770", Offset = "0x7475970", VA = "0x187476770")]
		protected void DKPMGPNPCDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x74779E0", Offset = "0x7476BE0", VA = "0x1874779E0")]
		private void KGGHHHEGNPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x747B220", Offset = "0x747A420", VA = "0x18747B220")]
		public PlayerFacialAnimatorBase()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x98F840", Offset = "0x98EA40", VA = "0x18098F840", Slot = "4")]
		private bool CMAJBKMNFCF()
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public struct GJIAHJBLMIN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000484")]
	public string FOBFABOAOEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000485")]
	public int HOJBPJFAOFL;
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	[SelectionBase]
	[ExecuteInEditMode]
	public class PlayerModernBodyEditorAvatarValidator : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000076")]
		[CompilerGenerated]
		private struct LKFCNCHNIOI : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004E5")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40004E6")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004E7")]
			public PlayerModernBodyEditorAvatarValidator <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004E8")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003D3")]
			[Cpp2IlInjected.Address(RVA = "0x7473600", Offset = "0x7472800", VA = "0x187473600", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003D4")]
			[Cpp2IlInjected.Address(RVA = "0x9C8C70", Offset = "0x9C7E70", VA = "0x1809C8C70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000077")]
		[CompilerGenerated]
		private struct MAHGPEINFBA : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004E9")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40004EA")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004EB")]
			public PlayerModernBodyEditorAvatarValidator <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004EC")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003D5")]
			[Cpp2IlInjected.Address(RVA = "0x74738B0", Offset = "0x7472AB0", VA = "0x1874738B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003D6")]
			[Cpp2IlInjected.Address(RVA = "0x7473DB0", Offset = "0x7472FB0", VA = "0x187473DB0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000486")]
		public const string IDLE_ANIM_NAME = "Idle";

		[Cpp2IlInjected.Token(Token = "0x4000487")]
		public const string A_POSE_ANIM_NAME = "A Pose";

		[Cpp2IlInjected.Token(Token = "0x4000488")]
		public const string ANIMATION_OVERRIDE_STATE_NAME = "Override";

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000489")]
		public KJAEMCJAGMO avatarBodyType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400048B")]
		public Color hairPrimaryColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400048C")]
		public Color hairSecondaryColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400048D")]
		public Color beardPrimaryColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400048E")]
		public Color beardSecondaryColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400048F")]
		public Color skinColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000490")]
		public int faceShapeIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000491")]
		public int bodyShapeIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000492")]
		public int hairPatternIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000493")]
		public int beardPatternIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000494")]
		public AvatarFaceShape[] faceShapes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000495")]
		public AvatarBodyShape[] bodyShapes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000496")]
		public AvatarHairPattern[] hairPatterns;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000497")]
		public float _avatarScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x4000498")]
		public bool enablePosing;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000499")]
		public int poseIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400049A")]
		public AnimationClip animationOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400049B")]
		[Range(0f, 4f)]
		public float animationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x400049C")]
		public bool hideEars;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400049D")]
		public PAOLLJPJFIC useHelmetHair;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400049E")]
		public FJJMJDFJPJG hatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400049F")]
		public ELFKCADAIPA HatAnchorRestrictions;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		public bool UseHairFitMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD1")]
		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		public bool usesHatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		public GameObject hatPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		public GameObject hairPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40004A4")]
		public GameObject earPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		public GameObject eyePrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		public GameObject mouthPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		public GameObject neckPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		public GameObject shirtPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		public GameObject beltPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40004AA")]
		public GameObject shoulderPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		public GameObject rightHandPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		public GameObject leftHandPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		public GameObject legsPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		public GameObject feetPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		public long baseSkinCullingMask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40004B0")]
		[KPPBIEPJJJL(ADOEJJMOABO.Self, false, false, false)]
		[SerializeField]
		public PlayerAvatarDisplayBase _avatarDisplay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40004B1")]
		private BAAIIIPELKG DMFLLGEFAMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40004B2")]
		[KPPBIEPJJJL(ADOEJJMOABO.Self, false, false, false)]
		[SerializeField]
		public PlayerFacialAnimatorBase facialAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40004B3")]
		public Animator animator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40004B4")]
		public AnimationClip animationClipToOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40004B5")]
		private AnimatorOverrideController MGHFKKDGKMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40004B6")]
		private List<KeyValuePair<AnimationClip, AnimationClip>> EMFFJJFDNPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x40004B7")]
		public Transform headIKEffector;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x40004B8")]
		public Transform leftHandIKEffector;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x40004B9")]
		public Transform rightHandIKEffector;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x40004BA")]
		[Range(0f, 2f)]
		public int lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19C")]
		[Cpp2IlInjected.Token(Token = "0x40004BB")]
		public int rightHandGestureStateIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x40004BC")]
		[Range(0f, 1f)]
		public float rightHandCurl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A4")]
		[Cpp2IlInjected.Token(Token = "0x40004BD")]
		public int leftHandGestureStateIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x40004BE")]
		[Range(0f, 1f)]
		public float leftHandCurl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1AC")]
		[Cpp2IlInjected.Token(Token = "0x40004BF")]
		public int eyeBrowSelection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x40004C0")]
		public int eyeSelection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B4")]
		[Cpp2IlInjected.Token(Token = "0x40004C1")]
		public int noseSelection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x40004C2")]
		public int mouthSelection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1BC")]
		[Cpp2IlInjected.Token(Token = "0x40004C3")]
		public float eyeBrowPositionOffsetHorizontal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x40004C4")]
		public float eyeBrowPositionOffsetVertical;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C4")]
		[Cpp2IlInjected.Token(Token = "0x40004C5")]
		public float eyeBrowScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x40004C6")]
		public float eyePositionOffsetHorizontal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1CC")]
		[Cpp2IlInjected.Token(Token = "0x40004C7")]
		public float eyePositionOffsetVertical;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x40004C8")]
		public float eyeScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D4")]
		[Cpp2IlInjected.Token(Token = "0x40004C9")]
		public float nosePositionOffsetVertical;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x40004CA")]
		public float noseScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1DC")]
		[Cpp2IlInjected.Token(Token = "0x40004CB")]
		public float mouthPositionOffsetHorizontal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x40004CC")]
		public float mouthPositionOffsetVertical;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E4")]
		[Cpp2IlInjected.Token(Token = "0x40004CD")]
		public float mouthScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x40004CE")]
		public float hatNormalizedPositionX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1EC")]
		[Cpp2IlInjected.Token(Token = "0x40004CF")]
		public float hatNormalizedPositionY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
		[Cpp2IlInjected.Token(Token = "0x40004D0")]
		public Vector3 hatHemispherePositionOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1FC")]
		[Cpp2IlInjected.Token(Token = "0x40004D1")]
		public Vector3 hatHemisphereRotationOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
		[Cpp2IlInjected.Token(Token = "0x40004D2")]
		public int facialExpressionIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20C")]
		[Cpp2IlInjected.Token(Token = "0x40004D3")]
		[Range(0f, 1f)]
		public float normalizedTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
		[Cpp2IlInjected.Token(Token = "0x40004D4")]
		public readonly GJIAHJBLMIN[] FacialExpressions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
		[Cpp2IlInjected.Token(Token = "0x40004D5")]
		public readonly string[] BodyPoses;

		[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
		[Cpp2IlInjected.Token(Token = "0x40004D6")]
		public readonly (string, LJHHNJNPPBE)[] HandPoses;

		[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
		[Cpp2IlInjected.Token(Token = "0x40004D7")]
		public bool hideLeftWatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x229")]
		[Cpp2IlInjected.Token(Token = "0x40004D8")]
		public bool hideRightWatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x22A")]
		[Cpp2IlInjected.Token(Token = "0x40004D9")]
		protected bool BDELFOAOOCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x22C")]
		[Cpp2IlInjected.Token(Token = "0x40004DA")]
		protected Guid KCLLMOEBJPN;

		[Cpp2IlInjected.Token(Token = "0x40004DB")]
		protected static Guid AMBKKPDKCFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
		[Cpp2IlInjected.Token(Token = "0x40004DC")]
		private BMAGGMLBMKH JKJOHCMJNBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
		[Cpp2IlInjected.Token(Token = "0x40004DD")]
		private EIDCFIKENAJ EPHPNFIPCIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
		[Cpp2IlInjected.Token(Token = "0x40004DE")]
		private CPPODONDALD CAEGAOAPMBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
		[Cpp2IlInjected.Token(Token = "0x40004DF")]
		private CPPODONDALD BEOIOEAFMKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x40004E0")]
		private AdditionalHatData GBDKHBMGMNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
		[Cpp2IlInjected.Token(Token = "0x40004E1")]
		private readonly Dictionary<GameObject, HJICPBDJEDM> AIGAOOJADDH;

		[Cpp2IlInjected.Token(Token = "0x170000AB")]
		public static Func<GABBAEJFCLA> HEIAFIPCNNL
		{
			[Cpp2IlInjected.Token(Token = "0x60003A1")]
			[Cpp2IlInjected.Address(RVA = "0x7480760", Offset = "0x747F960", VA = "0x187480760")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003A2")]
			[Cpp2IlInjected.Address(RVA = "0x7480DA0", Offset = "0x747FFA0", VA = "0x187480DA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AC")]
		public bool DCOIDCNJLCM
		{
			[Cpp2IlInjected.Token(Token = "0x60003A3")]
			[Cpp2IlInjected.Address(RVA = "0x74808C0", Offset = "0x747FAC0", VA = "0x1874808C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AD")]
		public bool KEEABGHCMMH
		{
			[Cpp2IlInjected.Token(Token = "0x60003A4")]
			[Cpp2IlInjected.Address(RVA = "0x74807B0", Offset = "0x747F9B0", VA = "0x1874807B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AE")]
		public PlayerAvatarDisplayBase OIBCJNBHBHB
		{
			[Cpp2IlInjected.Token(Token = "0x60003A6")]
			[Cpp2IlInjected.Address(RVA = "0x9DB040", Offset = "0x9DA240", VA = "0x1809DB040")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AF")]
		protected static Guid JCLICNPMENE
		{
			[Cpp2IlInjected.Token(Token = "0x60003A7")]
			[Cpp2IlInjected.Address(RVA = "0x747BE10", Offset = "0x747B010", VA = "0x18747BE10")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B0")]
		public (GameObject, OCHNHLJBAPP)[] DGKDFNCBCFB
		{
			[Cpp2IlInjected.Token(Token = "0x60003BD")]
			[Cpp2IlInjected.Address(RVA = "0x74809D0", Offset = "0x747FBD0", VA = "0x1874809D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x747E4D0", Offset = "0x747D6D0", VA = "0x18747E4D0")]
		[ContextMenu("Refresh Avatar")]
		private void RebuildTestAvatarContextMenu()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0x747DC60", Offset = "0x747CE60", VA = "0x18747DC60")]
		private IEnumerable<GameObject> PKJMDCFNDMC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0x747E9C0", Offset = "0x747DBC0", VA = "0x18747E9C0")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x747E3F0", Offset = "0x747D5F0", VA = "0x18747E3F0")]
		private void POFDHHHBEIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0x10DB330", Offset = "0x10DA530", VA = "0x1810DB330")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0x747D120", Offset = "0x747C320", VA = "0x18747D120")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x747E9D0", Offset = "0x747DBD0", VA = "0x18747E9D0")]
		public void Teardown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x747E7C0", Offset = "0x747D9C0", VA = "0x18747E7C0")]
		public void ShowPose(AnimationClip BCKDPBDOEKG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x747E990", Offset = "0x747DB90", VA = "0x18747E990")]
		public void ShowPose(string EHGGKHCINCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x747E620", Offset = "0x747D820", VA = "0x18747E620")]
		public void ResetPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x747E4E0", Offset = "0x747D6E0", VA = "0x18747E4E0")]
		public void ResetHandPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x747F4A0", Offset = "0x747E6A0", VA = "0x18747F4A0")]
		public void UpdateHandAnimation()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x747F2F0", Offset = "0x747E4F0", VA = "0x18747F2F0")]
		public void UpdateFaceAndBodyShapes(bool KIOFDLCOPFF = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x747F8A0", Offset = "0x747EAA0", VA = "0x18747F8A0")]
		public void UpdateNoseShape(MKBBPKEHLCL OIMBBJJFICP, bool KIOFDLCOPFF = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x747F870", Offset = "0x747EA70", VA = "0x18747F870")]
		public void UpdateLODOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x747E0F0", Offset = "0x747D2F0", VA = "0x18747E0F0", Slot = "4")]
		protected virtual void PMDFJKDCAEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x747C900", Offset = "0x747BB00", VA = "0x18747C900", Slot = "5")]
		protected virtual void EGGDEINOPFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x747BA40", Offset = "0x747AC40", VA = "0x18747BA40")]
		public void ApplyHatData(AdditionalHatData JAJLAJABOFP, bool LKIOPIKIOHE = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x747B880", Offset = "0x747AA80", VA = "0x18747B880")]
		public void ApplyHatAdjustmentsToHatAnchorParams()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x747BDA0", Offset = "0x747AFA0", VA = "0x18747BDA0")]
		public void ApplyHatUVOverride(Vector2 ILAEOEJOPHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x747BCC0", Offset = "0x747AEC0", VA = "0x18747BCC0")]
		public void ApplyHatPositionAdjustment(Vector3 NBPPFOAKECH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x747BD30", Offset = "0x747AF30", VA = "0x18747BD30")]
		public void ApplyHatRotationAdjustment(Vector3 BBPDNANONFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x747BF00", Offset = "0x747B100", VA = "0x18747BF00")]
		public LFLMMHMGMIH BuildAvatarItemSelection(GameObject IPFCDNMNPKO, KJAEMCJAGMO FPNGNOPBJOG, OCHNHLJBAPP MAEDABBOOIF)
		{
			return default(LFLMMHMGMIH);
		}

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x747BFA0", Offset = "0x747B1A0", VA = "0x18747BFA0")]
		public void BuildAvatar(bool KIOFDLCOPFF = false, bool LKIOPIKIOHE = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x747ED30", Offset = "0x747DF30", VA = "0x18747ED30")]
		public void UpdateColors()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x747B9C0", Offset = "0x747ABC0", VA = "0x18747B9C0")]
		public void ApplyHatAnchor()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x747F6C0", Offset = "0x747E8C0", VA = "0x18747F6C0")]
		public void UpdateHatAnchor(bool LKIOPIKIOHE = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x747F3F0", Offset = "0x747E5F0", VA = "0x18747F3F0")]
		[AsyncStateMachine(typeof(LKFCNCHNIOI))]
		public void UpdateFaceFeatures()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x747D820", Offset = "0x747CA20", VA = "0x18747D820")]
		[AsyncStateMachine(typeof(MAHGPEINFBA))]
		private Task KJIIDAJLBDM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x747D9A0", Offset = "0x747CBA0", VA = "0x18747D9A0")]
		private void PAPOBFMCLLK(FaceFeatureType GDOCGKIIGKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x747D090", Offset = "0x747C290", VA = "0x18747D090")]
		private void IGKAOCHECNL(FaceFeatureType GDOCGKIIGKM, [Out] float NPPOHCALENF, [Out] float DGNPNMMHBMN, [Out] float DIOKPOCPBHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x747F1B0", Offset = "0x747E3B0", VA = "0x18747F1B0")]
		public void UpdateEmote()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x747F550", Offset = "0x747E750", VA = "0x18747F550")]
		public void UpdateHandPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x747CB70", Offset = "0x747BD70", VA = "0x18747CB70")]
		private void HKCCFLHLEDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00")]
		private void EHFLDIEAPED(HJICPBDJEDM PBBIHNAENOI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x962E00", Offset = "0x962000", VA = "0x180962E00")]
		private void ACJHALMEBCA(HJICPBDJEDM PBBIHNAENOI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x747C5A0", Offset = "0x747B7A0", VA = "0x18747C5A0")]
		private void EBJPBBNJNIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x747F920", Offset = "0x747EB20", VA = "0x18747F920")]
		public PlayerModernBodyEditorAvatarValidator()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x747D8F0", Offset = "0x747CAF0", VA = "0x18747D8F0")]
		[CompilerGenerated]
		private LFLMMHMGMIH OOPPLIBFEDF((GameObject, OCHNHLJBAPP) BEPFMMBBCAF)
		{
			return default(LFLMMHMGMIH);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	public class SkinnedMeshBonesInspector : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004ED")]
		[KPPBIEPJJJL(ADOEJJMOABO.Self, false, false, false)]
		[SerializeField]
		private SkinnedMeshRenderer skinnedMeshRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004EE")]
		[SerializeField]
		private int BoneWeightsDisplayStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40004EF")]
		[SerializeField]
		private int BoneWeightsDisplayAmount;

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x962DF0", Offset = "0x961FF0", VA = "0x180962DF0")]
		public SkinnedMeshBonesInspector()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public struct LFLMMHMGMIH
{
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	[CompilerGenerated]
	private sealed class FDBMLCKOABJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004F2")]
		public IEnumerable<OutfitType> otherOutfitTypes;

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x9684B0", Offset = "0x9676B0", VA = "0x1809684B0")]
		public FDBMLCKOABJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x74718A0", Offset = "0x7470AA0", VA = "0x1874718A0")]
		internal bool NKICHDIDEAA(OutfitType outfitType)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004F0")]
	private HJICPBDJEDM JMFPKODKDOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004F1")]
	private OCHNHLJBAPP OFNNBEFGFBD;

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public HJICPBDJEDM NECGMAGNOMH
	{
		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0xC1A5B0", Offset = "0xC197B0", VA = "0x180C1A5B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public OCHNHLJBAPP CIIHACDOPKC
	{
		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0xC1A5D0", Offset = "0xC197D0", VA = "0x180C1A5D0")]
		get
		{
			return default(OCHNHLJBAPP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public string CAFJGGNHHDG
	{
		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x74732B0", Offset = "0x74724B0", VA = "0x1874732B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public bool DCGEKFJGDID
	{
		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x7473260", Offset = "0x7472460", VA = "0x187473260")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public bool DEMNLCJKIMG
	{
		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x7472F60", Offset = "0x7472160", VA = "0x187472F60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x15EF900", Offset = "0x15EEB00", VA = "0x1815EF900")]
	public LFLMMHMGMIH(HJICPBDJEDM PBBIHNAENOI, OCHNHLJBAPP GPIHEODLCOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x74731A0", Offset = "0x74723A0", VA = "0x1874731A0")]
	public bool DBNLFOGKJFL(OutfitType NJNNIFEKGKO, OCHNHLJBAPP IPAOAIHLCML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x74733A0", Offset = "0x74725A0", VA = "0x1874733A0")]
	public bool PLPDEKNHAON(OutfitType NJNNIFEKGKO, OCHNHLJBAPP IPAOAIHLCML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x7472FB0", Offset = "0x74721B0", VA = "0x187472FB0")]
	public bool CMDBIILMPDA(LFLMMHMGMIH NCLFNBEBJAH)
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
