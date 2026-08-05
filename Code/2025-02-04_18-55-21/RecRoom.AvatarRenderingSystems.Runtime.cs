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
	public class LogRegistrationIndex : CGFLIBNDCKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x70DB750", Offset = "0x70DA550", VA = "0x1870DB750", Slot = "4")]
		public override void EHDMJEMLBPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x9201C0", Offset = "0x91EFC0", VA = "0x1809201C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x8F4330", Offset = "0x8F3130", VA = "0x1808F4330", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override string AssetGUID
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x70DDF00", Offset = "0x70DCD00", VA = "0x1870DDF00", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x70DDE70", Offset = "0x70DCC70", VA = "0x1870DDE70", Slot = "17")]
		public override bool RuntimeKeyIsValid()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x70DDEC0", Offset = "0x70DCCC0", VA = "0x1870DDEC0")]
		public RecNetCDNAssetReference(RecNetCDNKey FFOHLCGHDKA)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class RecNetCDNKey
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public List<RecNetCDNKey> Dependencies;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public string BundleFilename
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x8F4460", Offset = "0x8F3260", VA = "0x1808F4460")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x8F41C0", Offset = "0x8F2FC0", VA = "0x1808F41C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public string ItemPath
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x8F4430", Offset = "0x8F3230", VA = "0x1808F4430")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x8F41E0", Offset = "0x8F2FE0", VA = "0x1808F41E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public string UniqueItemIdentifier
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x8F7B20", Offset = "0x8F6920", VA = "0x1808F7B20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x8F7B10", Offset = "0x8F6910", VA = "0x1808F7B10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public string CacheHash
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x8F41F0", Offset = "0x8F2FF0", VA = "0x1808F41F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x8F7B40", Offset = "0x8F6940", VA = "0x1808F7B40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool AttemptPrecacheLookup
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x922F70", Offset = "0x921D70", VA = "0x180922F70")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x922CF0", Offset = "0x921AF0", VA = "0x180922CF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x70DDF90", Offset = "0x70DCD90", VA = "0x1870DDF90")]
		public static RecNetCDNKey NMEBLLENHEL(string OJDCJGBMEKK, string DPGGOIJPAJC = "")
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x70DDF40", Offset = "0x70DCD40", VA = "0x1870DDF40")]
		public void GPDOAJHGKGE(string KJJDHDJIDEB, string EHFKLAFIBCC, bool PJFAPCKCHOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x70DE090", Offset = "0x70DCE90", VA = "0x1870DE090")]
		public RecNetCDNKey()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[HLDENJBKDHO]
public class AJKMAOEGKOD : HHMNKHEANBM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	protected readonly List<Mesh> HDKBHEDCLJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	protected readonly List<byte[]> FEAOJNDMACL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	protected readonly List<Matrix4x4> MLLPFKPCJIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	protected readonly List<bool> EIACFKDPBCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	protected readonly List<int> COINNGAHBLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	protected readonly List<bool> NMJHJPMOMBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	protected readonly List<int> BGNBJMOHJAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	protected Allocator OBJCJMGJABC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	protected EBGAKLBCDPI ONABKAMKIJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	protected byte APBAJMANNPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	protected IList<int> MIPIECEOLIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	protected IList<int> IOGAKHPGNCM;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x70C6EC0", Offset = "0x70C5CC0", VA = "0x1870C6EC0", Slot = "4")]
	public void LOAEBCFEDBN(Mesh KLMHPHDLFFG, Matrix4x4 LCFEPOMOJLK, byte[] FOKMELOPJDL, bool LAGFFBPANBA = false, HFBLFLDOFLG.KLFEKKPPLNK PHEAACMDOCI = (HFBLFLDOFLG.KLFEKKPPLNK)0, int GPPIONCBAJE = -1, bool HKHJIFBHHCF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x70C6E80", Offset = "0x70C5C80", VA = "0x1870C6E80", Slot = "5")]
	public void GHMPFMCBIMC(Allocator GCNJHJPCIGN, EBGAKLBCDPI NNAIFONDPBO, byte KANGNLBMHIH, [Optional] IList<int> IFFOIOLMLOM, [Optional] IList<int> OIBGFPOHAEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x70C6C20", Offset = "0x70C5A20", VA = "0x1870C6C20")]
	private static void GFDPGAALEJC(Mesh KLMHPHDLFFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x70C70D0", Offset = "0x70C5ED0", VA = "0x1870C70D0")]
	public AJKMAOEGKOD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[HLDENJBKDHO]
public struct KHNILOHKKOL : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	[ReadOnly]
	public HCDLDFCNBEP BJEKLALIJEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	[ReadOnly]
	public int JCAGJMEHFKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public BEDIHAGFNGP INBLGBOGLOH;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x70D9A00", Offset = "0x70D8800", VA = "0x1870D9A00", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[HLDENJBKDHO]
[NativeContainer]
public struct BEDIHAGFNGP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct IPOCDOIOKHF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public Vector3 DMEOAJEDFDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public Vector3 FOPIBLDPFFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public Vector4 JNNHIJLBOAM;
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct LDKBHOJLHDE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public float KCMKMLMOHDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public float DELCABBAJHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public float OEFNNEHCFEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public float NJMEFCGLKDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public byte EHBFAKEMPNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public byte HEEOMBDNNJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public byte FJKNIHCIEMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public byte OLDFBPNOCJJ;
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct LFDBIKKFMLF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public half KCMKMLMOHDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public half DELCABBAJHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public half OEFNNEHCFEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public half NJMEFCGLKDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public byte EHBFAKEMPNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public byte HEEOMBDNNJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public byte FJKNIHCIEMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public byte OLDFBPNOCJJ;
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct BNEABJFMNJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public half4 EDAHAPFCLBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public half2 APLANEJIFBO;
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct CHFPEAJIGJF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public half4 EDAHAPFCLBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public half2 APLANEJIFBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public half2 LJKAEHEGCKK;
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public struct KHJILEFIEOM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public half4 EDAHAPFCLBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public half2 APLANEJIFBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public half2 LJKAEHEGCKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public half2 JHOIILCHPFP;
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct LKPJDKLGPED
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public half4 EDAHAPFCLBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public half2 APLANEJIFBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public half2 LJKAEHEGCKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public half2 JHOIILCHPFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public half2 ILJJKEDMGEM;
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public struct FBLFPBFMFOF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public float KCMKMLMOHDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public float DELCABBAJHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public float OEFNNEHCFEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public float NJMEFCGLKDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public int EHBFAKEMPNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public int HEEOMBDNNJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public int FJKNIHCIEMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public int OLDFBPNOCJJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public struct ICDBFCDHBFC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public Color EDAHAPFCLBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public Vector2 APLANEJIFBO;
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public struct ICFGANPOFGN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public Color EDAHAPFCLBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public Vector2 APLANEJIFBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public Vector2 LJKAEHEGCKK;
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public struct AKFDEPIELKG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public Color EDAHAPFCLBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public Vector2 APLANEJIFBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public Vector2 LJKAEHEGCKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public Vector2 JHOIILCHPFP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public struct ECAKHOCKPCB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Color EDAHAPFCLBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public Vector2 APLANEJIFBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public Vector2 LJKAEHEGCKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Vector2 JHOIILCHPFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public Vector2 ILJJKEDMGEM;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private bool HKPJFICFCCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public NativeArray<IPOCDOIOKHF> MKLCNJBFLON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public NativeArray<BNEABJFMNJO> CALEPOBCJIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public NativeArray<CHFPEAJIGJF> GKBDDNJBLLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public NativeArray<KHJILEFIEOM> MLAPNJNAPME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public NativeArray<LKPJDKLGPED> GHABLFGNMAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public NativeArray<LFDBIKKFMLF> JOCBNAGIMNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public NativeArray<LDKBHOJLHDE> PHABIBKGKEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public NativeArray<ICDBFCDHBFC> LAIHALFFDPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public NativeArray<ICFGANPOFGN> HFMBMIGAFJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public NativeArray<AKFDEPIELKG> ANGOALAPMAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public NativeArray<ECAKHOCKPCB> FFIKOOKLHOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public NativeArray<FBLFPBFMFOF> FHEFONEDKFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public NativeArray<int> JHHNBFHOCKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public NativeArray<int> AFAMFFNKMFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private NativeArray<int> DMEMICMLPEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private NativeArray<int> HCAPAILKNMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public NativeArray<int> IAOACAEIIJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public NativeArray<int> PBEFLJHKEHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public NativeArray<int> PGBOFHDBFOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public NativeArray<BoneWeight> ABCKJCKPNNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private NativeArray<int> KODPGCABALO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private bool ELMACLBMMAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x159")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private bool BMMBPKGMHHK;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int FKBELOAEFGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x70C92D0", Offset = "0x70C80D0", VA = "0x1870C92D0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x70CAAD0", Offset = "0x70C98D0", VA = "0x1870CAAD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public int JEFPEDDKPII
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x70CABA0", Offset = "0x70C99A0", VA = "0x1870CABA0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x70C8C60", Offset = "0x70C7A60", VA = "0x1870C8C60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int JFBKMCEHNEE
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x70CAAE0", Offset = "0x70C98E0", VA = "0x1870CAAE0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x70CAB90", Offset = "0x70C9990", VA = "0x1870CAB90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int AMEFCJCHNDG
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x70C8C70", Offset = "0x70C7A70", VA = "0x1870C8C70")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x70CAFB0", Offset = "0x70C9DB0", VA = "0x1870CAFB0")]
	public BEDIHAGFNGP(int NDHAJEKPDOG, int BLNFPABNKBH, int ACNJIPFGBIB, int LIFAMKGAGAB, Allocator GCNJHJPCIGN, int OMJHJCHCALK, DIJJPEGNHNA EOKKBPIIIML, bool ELMACLBMMAN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x70CAB00", Offset = "0x70C9900", VA = "0x1870CAB00")]
	public void NKFPNLKGBGN(int KNCPCNBMDNF, Vector3 MFHMIEFHEKN, Vector3 PANJCGCFAKM, Vector4 DHJLEBFEJME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x70C93B0", Offset = "0x70C81B0", VA = "0x1870C93B0")]
	public void HCNNIDEMOEL(int KNCPCNBMDNF, BoneWeight PMFDECCNAMF, NativeSlice<byte> FOKMELOPJDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x70C8CE0", Offset = "0x70C7AE0", VA = "0x1870C8CE0")]
	public Color CDMDHCOJOHK(int KNCPCNBMDNF)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x70CABB0", Offset = "0x70C99B0", VA = "0x1870CABB0")]
	public void OMGOBEAOEMM(int KNCPCNBMDNF, Color MKIHPGLMNDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x70CA720", Offset = "0x70C9520", VA = "0x1870CA720")]
	public void JAGELJPHGIC(byte LCHCPAEAJJL, int KNCPCNBMDNF, Vector2 LADGMJPGFIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x70CAAF0", Offset = "0x70C98F0", VA = "0x1870CAAF0")]
	public void NGFAMJIMJBF(int KNCPCNBMDNF, int HBOLPMKJNPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x70C9010", Offset = "0x70C7E10", VA = "0x1870C9010")]
	public bool CMAFIAEPDDB(int LCHCPAEAJJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x70C92E0", Offset = "0x70C80E0", VA = "0x1870C92E0")]
	public void EKDEGNNKFKH(int EDFOAHFPELN, int DACBEFNKNPO, int AIIKLGOLFIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x70C9070", Offset = "0x70C7E70", VA = "0x1870C9070", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x70C97E0", Offset = "0x70C85E0", VA = "0x1870C97E0")]
	public Mesh HIPCBHNDELB([Optional] string CJELMMICOBG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[NativeContainer]
[DefaultMember("Item")]
[HLDENJBKDHO]
public struct HCDLDFCNBEP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public Mesh.MeshDataArray MIDCIBHLJEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public NativeArray<int> LNEBHOKNOIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public NativeArray<int> JPGJPNNENIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public NativeArray<BoneWeight> ABCKJCKPNNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private NativeArray<Matrix4x4> JJCGAPMHMGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private NativeArray<int> GDEIOPNFCIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private NativeArray<byte> OPJONKLNALM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private NativeArray<int> ONBNEMLEHLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private NativeArray<int> FJPGJPOCHON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public NativeArray<sbyte> LGOGKMDCHCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public NativeArray<byte> EBCEPLLPOJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public NativeArray<bool> HKHJIFBHHCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public NativeArray<int> GPPIONCBAJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private bool ELMACLBMMAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private NativeArray<int> ALIOLHHNKCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private bool BMMBPKGMHHK;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int GNOECLLHDIP
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x70D8210", Offset = "0x70D7010", VA = "0x1870D8210")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int BGHGJBLHFJP
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x70D8240", Offset = "0x70D7040", VA = "0x1870D8240")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int OJANEBEFAGA
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x70D8250", Offset = "0x70D7050", VA = "0x1870D8250")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int JMNPJEDLDLC
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x70D8060", Offset = "0x70D6E60", VA = "0x1870D8060")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x70D8320", Offset = "0x70D7120", VA = "0x1870D8320")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int FKBELOAEFGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x70D81E0", Offset = "0x70D6FE0", VA = "0x1870D81E0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x70D8230", Offset = "0x70D7030", VA = "0x1870D8230")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int MDDHBPGJCCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x70D8220", Offset = "0x70D7020", VA = "0x1870D8220")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x70D8580", Offset = "0x70D7380", VA = "0x1870D8580")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public EBGAKLBCDPI MGIIMCHFJAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x70D8050", Offset = "0x70D6E50", VA = "0x1870D8050")]
		get
		{
			return default(EBGAKLBCDPI);
		}
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x70D8200", Offset = "0x70D7000", VA = "0x1870D8200")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public byte JDNBHDFIPOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x70D81F0", Offset = "0x70D6FF0", VA = "0x1870D81F0")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x70D8040", Offset = "0x70D6E40", VA = "0x1870D8040")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public FDNNDGPLAAD FCGIOOCDKLL
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x70D8330", Offset = "0x70D7130", VA = "0x1870D8330")]
		get
		{
			return default(FDNNDGPLAAD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x70D8590", Offset = "0x70D7390", VA = "0x1870D8590")]
	public HCDLDFCNBEP(IList<Mesh> EDNMMACAGLG, IList<Matrix4x4> HNLDCFBPNGL, IList<bool> HKHJIFBHHCF, byte KANGNLBMHIH, IList<byte[]> CCGFKJMKAOI, IList<int> LLMBHAABMFL, IList<bool> FCPFHNMFDEO, IList<int> GPPIONCBAJE, IList<int> IFFOIOLMLOM, IList<int> HDKFDIDELLL, Allocator GCNJHJPCIGN, EBGAKLBCDPI NNAIFONDPBO, bool ELMACLBMMAN = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x70D7F70", Offset = "0x70D6D70", VA = "0x1870D7F70")]
	public BEDIHAGFNGP BBMNJLKJGBJ(Allocator GCNJHJPCIGN, DIJJPEGNHNA EOKKBPIIIML)
	{
		return default(BEDIHAGFNGP);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x70D8070", Offset = "0x70D6E70", VA = "0x1870D8070", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[HLDENJBKDHO]
public class CDEPFOEEIJM : AJKMAOEGKOD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public bool BBMCIMFKEDG;

	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private static readonly ProfilerMarker ALKMFMNFKGA;

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x70D79A0", Offset = "0x70D67A0", VA = "0x1870D79A0")]
	public HCDLDFCNBEP EJDBONHCPIP()
	{
		return default(HCDLDFCNBEP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x70D7C60", Offset = "0x70D6A60", VA = "0x1870D7C60")]
	public CDEPFOEEIJM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct FDNNDGPLAAD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public Mesh.MeshData CMBIGOOMNGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public NativeSlice<BoneWeight> ABCKJCKPNNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public NativeSlice<byte> BJBLPKFFKIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public int OPMMMDFCHKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public Matrix4x4 JGDENEFEGNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public int FPOLJLMJPGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public NativeSlice<byte> FOKMELOPJDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public bool ADAAPODOPAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public int BIHCCDBGPAF;
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class BLEMPJHFGIL : PHGIHCICACD
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class LHAOCBNDKNH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public IKIDNOHIOAL avatarBuildParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public BLEMPJHFGIL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public NAEGINDHOLH buildMeshPromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public Action<KeyValuePair<string, MEPEJIIMKOI<Texture2D>>> <>9__19;

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public LHAOCBNDKNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x70DB500", Offset = "0x70DA300", VA = "0x1870DB500")]
		internal bool DOLPGFBNPMM(EPEMMDIFGGB item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x70DB4E0", Offset = "0x70DA2E0", VA = "0x1870DB4E0")]
		internal void CAHOMNMGJLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x70DB5B0", Offset = "0x70DA3B0", VA = "0x1870DB5B0")]
		internal void NEJCHPGLIMG(string err)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x70DB4E0", Offset = "0x70DA2E0", VA = "0x1870DB4E0")]
		internal void GGKNEDPOFHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x70DB5B0", Offset = "0x70DA3B0", VA = "0x1870DB5B0")]
		internal void PFIHMAANODN(string err)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x70DB580", Offset = "0x70DA380", VA = "0x1870DB580")]
		internal void LFGNPEOAPGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x70DB550", Offset = "0x70DA350", VA = "0x1870DB550")]
		internal void KAOHHMPMIMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x70DB690", Offset = "0x70DA490", VA = "0x1870DB690")]
		internal void PJKDDHIFBPH(Dictionary<string, MEPEJIIMKOI<Texture2D>> resourceHandleDictionary)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x70DB5D0", Offset = "0x70DA3D0", VA = "0x1870DB5D0")]
		internal void NGALMLBHOLD(KeyValuePair<string, MEPEJIIMKOI<Texture2D>> kvp)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x8F7B20", Offset = "0x8F6920", VA = "0x1808F7B20")]
		internal LDHIGNIGDAL JDGIPGMJHOF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class ELFLHIAPGLJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public int lowestPossibleLOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public LHAOCBNDKNH CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public ELFLHIAPGLJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x70D7C70", Offset = "0x70D6A70", VA = "0x1870D7C70")]
		internal GOJOFIEBFEA AEOBDDDEDIO(int lod)
		{
			return default(GOJOFIEBFEA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class PJBGPNJBKHN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public MNHDJBCOCND<Dictionary<string, MEPEJIIMKOI<Texture2D>>> ugcTextureDictionaryPromise;

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public PJBGPNJBKHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x8F4460", Offset = "0x8F3260", VA = "0x1808F4460")]
		internal MNHDJBCOCND<Dictionary<string, MEPEJIIMKOI<Texture2D>>> HJHBLFFFCBE()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[CompilerGenerated]
	private sealed class BHLGENFDEFF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public List<NAEGINDHOLH> innerPromises;

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public BHLGENFDEFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x70CB9E0", Offset = "0x70CA7E0", VA = "0x1870CB9E0")]
		internal void DPLCBOCFJJD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class JMLLNONHHJH : IEnumerator<HLGDLHCLDFE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private HLGDLHCLDFE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public bool shouldWait;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public BLEMPJHFGIL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public List<GHDINHKOOCF> parts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public List<NAEGINDHOLH> innerPromises;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public int[] LODs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public bool isFirstPerson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public Func<int, GOJOFIEBFEA> getLayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public ACOOIKABMPL materialPropertyBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public Material materialInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		private int <lodIndex>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		private HLGDLHCLDFE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x8F4430", Offset = "0x8F3230", VA = "0x1808F4430", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x8F4430", Offset = "0x8F3230", VA = "0x1808F4430", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x8F7AE0", Offset = "0x8F68E0", VA = "0x1808F7AE0")]
		[DebuggerHidden]
		public JMLLNONHHJH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x70D9730", Offset = "0x70D8530", VA = "0x1870D9730", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x70D99B0", Offset = "0x70D87B0", VA = "0x1870D99B0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class FEOBIBAIPLF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public MLDKEGIOPPG cancelable;

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public FEOBIBAIPLF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0xAA19B0", Offset = "0xAA07B0", VA = "0x180AA19B0")]
		internal void BCEPGGFHKME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0xBA3230", Offset = "0xBA2030", VA = "0x180BA3230")]
		internal void KINCHAKJLGE(string err)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class GBODKKIJPBD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public long jobComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public Stopwatch stopwatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public SkinnedMeshRenderer lodRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public long meshComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public string meshName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public long meshCopyComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public BLEMPJHFGIL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public int lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public List<Material> newUniqueMaterials;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public int frameStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public long lodBuildStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public long startCombineBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public long jobScheduled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public Action onFinally;

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public GBODKKIJPBD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class NJCPDFAGCMJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public bool waitingForComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public JobHandle lodBuildJobHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public BEDIHAGFNGP defaultMeshJobContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public HCDLDFCNBEP defaultAvatarMeshJobGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public GBODKKIJPBD CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public NJCPDFAGCMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x70DB860", Offset = "0x70DA660", VA = "0x1870DB860")]
		internal void PKLNCBIBIBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x107D2E0", Offset = "0x107C0E0", VA = "0x18107D2E0")]
		internal void HFLLHJLOFKK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class GKIOEGCBDHE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public bool waitingForComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public JobHandle lodBuildJobHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public PPGJJMIMGAO legacyMeshJobContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public ABAFBKGEJEK legacyAvatarMeshJobGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public GBODKKIJPBD CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public GKIOEGCBDHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x70D7D30", Offset = "0x70D6B30", VA = "0x1870D7D30")]
		internal void CMFJNDHCGOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x1079920", Offset = "0x1078720", VA = "0x181079920")]
		internal void EOLDCAIDAPP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class MLBCLKFBLIF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public string overrideItemIdentifier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public GKHPEMHLGJO overrideBodyPart;

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public MLBCLKFBLIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x70DB7E0", Offset = "0x70DA5E0", VA = "0x1870DB7E0")]
		internal bool FDKOMLOFIDC(KeyValuePair<string, EPEMMDIFGGB> entry)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private readonly GAMKKEJCIBM HEDBOFPBILC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly GAMKKEJCIBM OPINOILKJEA;

	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private static float ADFFFCKNBJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private AvatarConfiguration EFKNKCOFAOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private Transform MANENPDIJOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private AvatarSkinAssetItem KAMIDLKJPKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private AssetReference OLICAEBAFMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private GameObject NJFPJFPAHAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private GameObject KPOFMPGBNHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private SkinnedMeshRenderer HMLALJFDNHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private AvatarSkinnedMeshBoneOrderRemapsData GNPNHJJNOGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private Transform[] ELOIJDAKOGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private Matrix4x4[] MLPFPGDHNKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private Material ICAMHCGNNAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private Material CNIMENBHDDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private Material ALEBPGLOJIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private Shader OGIMGAOPOPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private Shader OEAJJLFJOGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private Animator BDFHJIHHOIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private Renderer[] ENEOFGLGMPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private HFBLFLDOFLG.KLFEKKPPLNK GJMOIGHKLDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private AvatarBodyPartShapesManager BPEKNHMEANG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private IReadOnlyDictionary<string, Transform> LLGBEPLEBGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private AvatarFaceShapeData.LOBAGDNMOOP GDBCHJOAMOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private AvatarBodyShapeData.OONENGFIKHL KKHHDPKINFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private KPICGBGFHFC OHADFGMAMFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private bool PKGCFEOFGKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xCD")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private bool KGCHJJOILMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private Color LMLGOBHAJAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private Color MNAGNIMCINH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private Color AEEKLFIJGPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private Color? OLMJMGNGDBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x114")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private Color? JDFMJEOFCHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private Color? FHBGGENIOPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13C")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private Color? JPOAEEFKMCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private Texture2D HLMPHNIOELC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private Texture2D CHLJMICNKLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	[CanBeNull]
	private EPEMMDIFGGB CDGFLDDCKMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private Texture DPEEOMBNLDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private Color PJCEHFFLFHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public Dictionary<Renderer, ACOOIKABMPL> CJKNKCGLCJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private Dictionary<Renderer, ACOOIKABMPL> MLLADIFEMDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private Dictionary<string, List<JPBDKBJNHGA>> OKFBFIKKOHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private Dictionary<string, List<JPBDKBJNHGA>> EABOIJMLJFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private readonly List<PGIHMBHBFKK> MPMFBCNMBHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private readonly List<PGIHMBHBFKK> NAMIJEIMFFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private readonly List<PGIHMBHBFKK> MNBDJOEDNPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private readonly List<PGIHMBHBFKK> KAFPGJODMHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private Dictionary<JPBDKBJNHGA, Material> FNCDDHFDHJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private Dictionary<JPBDKBJNHGA, Material> INNJMFIOANF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private SkinnedMeshRenderer[] HAJDGDJCKEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private SkinnedMeshRenderer[] HIKMNFPIDJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private SkinnedMeshRenderer[] HEHGFCEBKHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private SkinnedMeshRenderer[] PKBODEGDEGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private readonly Dictionary<string, MEPEJIIMKOI<Texture2D>> PEJJGMPAGOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private readonly Dictionary<string, MEPEJIIMKOI<Texture2D>> HCAHAJAKEPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private PMOAPNPOLPO PNBDDILFGNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x204")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private PMOAPNPOLPO FLPFCBMOCKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private AdditionalHatData JFGBIBKNJIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private AdditionalHatData LPOIJPFPDOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private HairData DHINLEPAEEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private HairData NCHGEFFFHKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private PACDKMEJBDN EAGMPICFBAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private bool? LBPGBLFMJEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x234")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private PositionAndRotation DGIHDGNKHHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private Transform HJJFEBJIANL;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private Material IGKJJBCNIGN;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private Material PAHJPEIGENP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private Dictionary<string, EPEMMDIFGGB> GIGHKAAHFCI;

	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private static readonly int FIKJDMIPKFP;

	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private static readonly int CEPGPGPMKCE;

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private static readonly int PFHMPOABJMI;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private static readonly int MMCKOOGCBGE;

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private static readonly int EEOEBCNCKLL;

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private static readonly int ADFNJMDFIKC;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private static readonly int PLOHCEOOKLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private bool GGJHCEHJGII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private List<Action> CKDAHMKCFIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private KKKMJGNFFIF DECINIBEAIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private SkinnedMeshRenderer[] PPDHKFIPHPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private int HEDICFFFDJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x294")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private bool IPCFAKGKIJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private int JBBKFOCKAOI;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public GAMKKEJCIBM PDJKAGJPFBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8F4460", Offset = "0x8F3260", VA = "0x1808F4460", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public GAMKKEJCIBM PPKELHAEMJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8F4430", Offset = "0x8F3230", VA = "0x1808F4430", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public AvatarConfiguration ECHKFOMFBAO
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x8F7B20", Offset = "0x8F6920", VA = "0x1808F7B20", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool OOAADLMEFHO
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x70D5000", Offset = "0x70D3E00", VA = "0x1870D5000")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x70CC780", Offset = "0x70CB580", VA = "0x1870CC780")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private Material IJMNJMKIACA
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x70D6A70", Offset = "0x70D5870", VA = "0x1870D6A70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	private Material IACJCDMOLLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x70D6EB0", Offset = "0x70D5CB0", VA = "0x1870D6EB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	private bool DMNGMAJLIDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x910AD0", Offset = "0x90F8D0", VA = "0x180910AD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public ENGPMKLLDHI GKBAKCBIEGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xA9F400", Offset = "0xA9E200", VA = "0x180A9F400", Slot = "23")]
		get
		{
			return default(ENGPMKLLDHI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public Material CGNALFBBPKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x8FC440", Offset = "0x8FB240", VA = "0x1808FC440", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public SkinnedMeshRenderer[] APIGHICCDMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x1BC96A0", Offset = "0x1BC84A0", VA = "0x181BC96A0", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public Renderer[] KFOMNNDMPAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0xB9BD70", Offset = "0xB9AB70", VA = "0x180B9BD70", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool GFONPNDEAMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x70CF430", Offset = "0x70CE230", VA = "0x1870CF430", Slot = "22")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public HFBLFLDOFLG.KLFEKKPPLNK GJCFNELOAHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x8FF870", Offset = "0x8FE670", VA = "0x1808FF870", Slot = "20")]
		get
		{
			return default(HFBLFLDOFLG.KLFEKKPPLNK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public int MMNCOEDNPFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x20184E0", Offset = "0x20172E0", VA = "0x1820184E0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x70CCBB0", Offset = "0x70CB9B0", VA = "0x1870CCBB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	private bool BPBCBNAMELH
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x70D70C0", Offset = "0x70D5EC0", VA = "0x1870D70C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private static bool MKGKJINIEAG
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x93EA60", Offset = "0x93D860", VA = "0x18093EA60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x70CCE10", Offset = "0x70CBC10", VA = "0x1870CCE10", Slot = "15")]
	public NAEGINDHOLH CKELMJKGFEK(IKIDNOHIOAL FALKPJPLCMP, bool PALMACBCAAD, int[] EHMHCBIGCAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x70CFD10", Offset = "0x70CEB10", VA = "0x1870CFD10", Slot = "14")]
	public NAEGINDHOLH FAGEODBIBMD(IKIDNOHIOAL FALKPJPLCMP, bool PALMACBCAAD, int[] EHMHCBIGCAB, Func<Dictionary<string, EPEMMDIFGGB>, (NAEGINDHOLH, MNHDJBCOCND<Dictionary<string, MEPEJIIMKOI<Texture2D>>>)> FJJKLPAEBBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x70CD6E0", Offset = "0x70CC4E0", VA = "0x1870CD6E0")]
	public NAEGINDHOLH DKKLCHJNDII(IKIDNOHIOAL FALKPJPLCMP, bool PALMACBCAAD, int[] EHMHCBIGCAB, bool IFMMDGEPAMP, PMOAPNPOLPO MAGBOHMFEFM, [Optional] Func<Dictionary<string, EPEMMDIFGGB>, (NAEGINDHOLH, MNHDJBCOCND<Dictionary<string, MEPEJIIMKOI<Texture2D>>>)> FJJKLPAEBBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x70CCCD0", Offset = "0x70CBAD0", VA = "0x1870CCCD0")]
	private bool CGHJMMLPMPO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x70D0F40", Offset = "0x70CFD40", VA = "0x1870D0F40")]
	private NAEGINDHOLH FAOPNDCAKNC(bool PALMACBCAAD, List<GHDINHKOOCF> BAKIDNBKIHB, int[] EHMHCBIGCAB, Func<int, GOJOFIEBFEA> GMPLHPPNGPI, bool IFMMDGEPAMP = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x70D6760", Offset = "0x70D5560", VA = "0x1870D6760")]
	[IteratorStateMachine(typeof(JMLLNONHHJH))]
	private IEnumerator<HLGDLHCLDFE> OCKHAOOGNDP(bool PALMACBCAAD, List<GHDINHKOOCF> BAKIDNBKIHB, int[] EHMHCBIGCAB, Func<int, GOJOFIEBFEA> GMPLHPPNGPI, ACOOIKABMPL MJAOCOFLEHE, Material GGMFHHKJKGB, List<NAEGINDHOLH> OIPPHHIACNL, bool OKIMEDGOJNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x70CBD70", Offset = "0x70CAB70", VA = "0x1870CBD70")]
	private void ADBODMDLLLO(List<GHDINHKOOCF> BAKIDNBKIHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x70D30D0", Offset = "0x70D1ED0", VA = "0x1870D30D0")]
	private NAEGINDHOLH IJMEPBNFBBF(List<GHDINHKOOCF> BAKIDNBKIHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x70CFD40", Offset = "0x70CEB40", VA = "0x1870CFD40")]
	private CPMKHKOAIIG FAOLBLILPMC(List<GHDINHKOOCF> BAKIDNBKIHB, int DFCGNGEAOFE, bool PALMACBCAAD, GOJOFIEBFEA EMAGOACMMCH, bool EDGKPDJEOCK, ACOOIKABMPL MJAOCOFLEHE, Material GGMFHHKJKGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x70D17E0", Offset = "0x70D05E0", VA = "0x1870D17E0", Slot = "25")]
	public void FDHKDANIDKO(AvatarFaceShape JALDIJBBDFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x70D1E60", Offset = "0x70D0C60", VA = "0x1870D1E60", Slot = "26")]
	public void GNBKKBFMLNG(AvatarBodyShape LGCEJLJELDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0xDAB150", Offset = "0xDA9F50", VA = "0x180DAB150", Slot = "27")]
	public void BAFPJKOHHEC(KPICGBGFHFC CGMNHCNBGPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x70D4AD0", Offset = "0x70D38D0", VA = "0x1870D4AD0", Slot = "29")]
	public void KPPFGKJEILD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x70D65A0", Offset = "0x70D53A0", VA = "0x1870D65A0", Slot = "32")]
	public void OBHKJMKBKNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x70D6C50", Offset = "0x70D5A50", VA = "0x1870D6C50", Slot = "28")]
	public void PDJDIJJEKEI(bool GDPJHHJHODM, bool LNGABLLINFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x70D40E0", Offset = "0x70D2EE0", VA = "0x1870D40E0")]
	private void KDCDHAJNKOL(SkinnedMeshRenderer CCKDFCMDFHH, int DFCGNGEAOFE, Mesh KLMHPHDLFFG, List<Material> IPMKIADHDKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x70CD400", Offset = "0x70CC200", VA = "0x1870CD400")]
	private static Material CPMGDDCPDJL(Dictionary<JPBDKBJNHGA, Material> FNFHGABCBBG, Material BNAGDKCOIPH, OEFGHLPBFDF DFNLJLMBKBN, IMOIFEKEDED APMDGBOOICP, GKHPEMHLGJO DNGHOGLAIFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x70CCBD0", Offset = "0x70CB9D0", VA = "0x1870CCBD0")]
	private static OEFGHLPBFDF CCAEKMNPPPG(GHDINHKOOCF PLDJCJINFEM, int POHBHLBADHD)
	{
		return default(OEFGHLPBFDF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x70D2490", Offset = "0x70D1290", VA = "0x1870D2490")]
	private void IAMAIGINPGJ(int NFIGLLHMKPG, Material FAGGGCGAPOE, GHDINHKOOCF PLDJCJINFEM, [Out] Texture2D CCOFOEMLEIJ, [Out] Vector4 PGIJGGOPKBI, [Out] Texture2D OIJHONLCDFN, [Out] Texture2D OHJIDICBFCD, [Out] Texture2D NOHJJKHCABF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x70D1F50", Offset = "0x70D0D50", VA = "0x1870D1F50")]
	private void HFFELCBBAPI(int NFIGLLHMKPG, Material FAGGGCGAPOE, GHDINHKOOCF PLDJCJINFEM, [Out] Color LGCDNNNCLDG, [Out] Color KIIOEENPCAA, [Out] Color HAICBLLGGMO, [Out] Color PIGPFLDELLK, [Out] Color JEEOCFHBOOG, [Out] Color JJPBBDPMCFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x70CBB10", Offset = "0x70CA910", VA = "0x1870CBB10")]
	private bool AAAADHCHDPH(Material FAGGGCGAPOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x70CD020", Offset = "0x70CBE20", VA = "0x1870CD020")]
	private static Material CLOABGNOCMN(int NFIGLLHMKPG, KMLIPALDANH PLDJCJINFEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x70D3D70", Offset = "0x70D2B70", VA = "0x1870D3D70")]
	private static IMOIFEKEDED JJJLPCDEFAC(GHDINHKOOCF PLDJCJINFEM, int POHBHLBADHD)
	{
		return default(IMOIFEKEDED);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x70D1520", Offset = "0x70D0320", VA = "0x1870D1520")]
	private static void FBKGBJCPOIM(Dictionary<string, List<JPBDKBJNHGA>> CMAKDFMJDKN, GHDINHKOOCF DFJGJCMGPME, Material BNAGDKCOIPH, OEFGHLPBFDF KPBHNCKKDLO, IMOIFEKEDED JGBFJCBFNJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x70D18A0", Offset = "0x70D06A0", VA = "0x1870D18A0")]
	private static SkinnedMeshRenderer FFNALCENCAO(Transform DJKBEHGILJD, Transform GEPHMMEOKHC, SkinnedMeshRenderer[] NAOBDCMABCL, int DFCGNGEAOFE, GOJOFIEBFEA EMAGOACMMCH, bool PALMACBCAAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x70D7410", Offset = "0x70D6210", VA = "0x1870D7410")]
	public BLEMPJHFGIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x70D39B0", Offset = "0x70D27B0", VA = "0x1870D39B0")]
	public void JEELJGCJJCO([In] GADGFBKBCJP MGMAHPGAAFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x70D2410", Offset = "0x70D1210", VA = "0x1870D2410")]
	public void LPEPLKKOAHN([In] IDNCFMHIEGG KKANPIOBMJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x70CCBB0", Offset = "0x70CB9B0", VA = "0x1870CCBB0", Slot = "5")]
	public void BPCBHHGFGNA(int DFCGNGEAOFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x70CFA40", Offset = "0x70CE840", VA = "0x1870CFA40", Slot = "10")]
	public void EFGNHEGAFHG(EGHHDCHNKOL JGBFJCBFNJC, Texture2D CEMDCHNHEAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x910AD0", Offset = "0x90F8D0", VA = "0x180910AD0")]
	public static bool CLBDLPHCKFJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x70D65E0", Offset = "0x70D53E0", VA = "0x1870D65E0", Slot = "11")]
	public bool OCJAGODCAKO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x70D4670", Offset = "0x70D3470", VA = "0x1870D4670", Slot = "9")]
	public void KKJLGMEMAKL(NPEDNBNAKGC KPBHNCKKDLO, Color? EDAHAPFCLBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x70D5080", Offset = "0x70D3E80", VA = "0x1870D5080")]
	private void MKACDMBLJEE(Action OADEBMJDJGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x70D5010", Offset = "0x70D3E10", VA = "0x1870D5010", Slot = "6")]
	public void MIEEAPKGJDN(EPEMMDIFGGB LAIKJNCELMB, Texture LAPFMBNHADH, Color JMEJNOLPAHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x70CC780", Offset = "0x70CB580", VA = "0x1870CC780", Slot = "7")]
	public void HGANPFDIGKE(bool OKIMEDGOJNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x1BE5CD0", Offset = "0x1BE4AD0", VA = "0x181BE5CD0", Slot = "8")]
	public void AGNFLCKONFD(KKKMJGNFFIF KODPGCABALO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x70D43E0", Offset = "0x70D31E0", VA = "0x1870D43E0", Slot = "16")]
	public void KGGPMOEOONL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x70D4A70", Offset = "0x70D3870", VA = "0x1870D4A70", Slot = "30")]
	public void KLDDDKEJCIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x70D5100", Offset = "0x70D3F00", VA = "0x1870D5100", Slot = "31")]
	public void MOCIJLIODEF([Optional] PACDKMEJBDN EPGICENMKCD, [Optional] bool? MEPKPILPCEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x70D4D50", Offset = "0x70D3B50", VA = "0x1870D4D50")]
	private bool LIOCPDBHAEC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x70CFC60", Offset = "0x70CEA60", VA = "0x1870CFC60", Slot = "21")]
	public bool EJJBBPDIHNH(HFBLFLDOFLG.KLFEKKPPLNK DFFKLLOKFME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x70D2E70", Offset = "0x70D1C70", VA = "0x1870D2E70")]
	private void IEOBGPBHEDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x70D1C60", Offset = "0x70D0A60", VA = "0x1870D1C60")]
	private void GGJGANNEJMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x70D1C70", Offset = "0x70D0A70", VA = "0x1870D1C70")]
	private static void GGOKLMGOHNB(Dictionary<JPBDKBJNHGA, Material> FNFHGABCBBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x70D7140", Offset = "0x70D5F40", VA = "0x1870D7140")]
	private static void PMOLOCJJOHK(Dictionary<Renderer, ACOOIKABMPL> FIOCIFDKFIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x70D6FA0", Offset = "0x70D5DA0", VA = "0x1870D6FA0")]
	private void PIHGKBBAIHG(SkinnedMeshRenderer[] NAOBDCMABCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x70D4300", Offset = "0x70D3100", VA = "0x1870D4300")]
	private void KFBMNEAKANM(SkinnedMeshRenderer GHMHFJNFMEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x70D3EE0", Offset = "0x70D2CE0", VA = "0x1870D3EE0")]
	private void JPHMEBIPFFE(List<PGIHMBHBFKK> KDHPOFEEGNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x70D6C60", Offset = "0x70D5A60", VA = "0x1870D6C60")]
	private void PECEGAIJOLF(Dictionary<string, MEPEJIIMKOI<Texture2D>> CMAKDFMJDKN, bool MKOABAOGDBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x70CCDC0", Offset = "0x70CBBC0", VA = "0x1870CCDC0")]
	private void CHJFDGGDBLD(Dictionary<string, List<JPBDKBJNHGA>> CMAKDFMJDKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x70D62D0", Offset = "0x70D50D0", VA = "0x1870D62D0")]
	private void NNGDJDLIAKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x70D3820", Offset = "0x70D2620", VA = "0x1870D3820")]
	private void JCKIKINGMBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x70D28A0", Offset = "0x70D16A0", VA = "0x1870D28A0")]
	private void IBNNBIDOHHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x70CC390", Offset = "0x70CB190", VA = "0x1870CC390")]
	private void ADNIPIEJFEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x70D1DD0", Offset = "0x70D0BD0", VA = "0x1870D1DD0")]
	private void GLMFCIFDKFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x70CD590", Offset = "0x70CC390", VA = "0x1870CD590")]
	private void DGKMEHEMAEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x70CF970", Offset = "0x70CE770", VA = "0x1870CF970")]
	private void EDPIIBLKOCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x70D4220", Offset = "0x70D3020", VA = "0x1870D4220")]
	private void KDIPICBAELL(bool CCNJDLNMLHI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x70D6DE0", Offset = "0x70D5BE0", VA = "0x1870D6DE0")]
	private void PEELDPDGEGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x70D4F20", Offset = "0x70D3D20", VA = "0x1870D4F20")]
	private void LNDHMMBBOHC(bool CCNJDLNMLHI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x70CC460", Offset = "0x70CB260", VA = "0x1870CC460")]
	private void AFDODHKONJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x70D3320", Offset = "0x70D2120", VA = "0x1870D3320")]
	private void JAFHHGMKHBI(Material GGMFHHKJKGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x70D6420", Offset = "0x70D5220", VA = "0x1870D6420")]
	private void NOPEJDBIEJC(Material GGMFHHKJKGB, Color LDBOPKAIIAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x70CC960", Offset = "0x70CB760", VA = "0x1870CC960")]
	private void BOOELCMDEGF(Material GGMFHHKJKGB, Color LDBOPKAIIAE, Color GALHOCBAMGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x70CC7C0", Offset = "0x70CB5C0", VA = "0x1870CC7C0")]
	private void BNODBHHNFDB(Material GGMFHHKJKGB, Color LGCDNNNCLDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x70D6880", Offset = "0x70D5680", VA = "0x1870D6880")]
	private void OMLIIBCFMPC(Material GGMFHHKJKGB, Texture2D CEMDCHNHEAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x70D1AF0", Offset = "0x70D08F0", VA = "0x1870D1AF0")]
	private void FJOMNCLDIEL(Material GGMFHHKJKGB, Texture MNOKCKDAONH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x70CCE40", Offset = "0x70CBC40", VA = "0x1870CCE40")]
	private void CKPIDMBOBAH(Action<ACOOIKABMPL> MEKMMBKMOJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x70D4BD0", Offset = "0x70D39D0", VA = "0x1870D4BD0")]
	private void LBCIHNOOACA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x70D5EB0", Offset = "0x70D4CB0", VA = "0x1870D5EB0")]
	private void NGLFJIPOBDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x70CF5A0", Offset = "0x70CE3A0", VA = "0x1870CF5A0")]
	private void ECIEGBBECCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x70CD070", Offset = "0x70CBE70", VA = "0x1870CD070")]
	public void CMHONIEOFOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x70D2410", Offset = "0x70D1210", VA = "0x1870D2410", Slot = "4")]
	private void HLIDKKBHNKI([In] IDNCFMHIEGG KKANPIOBMJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x70D43A0", Offset = "0x70D31A0", VA = "0x1870D43A0")]
	[CompilerGenerated]
	private LDHIGNIGDAL KFIAECKIAHP(GHDINHKOOCF HLIJNINJIMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x70D3E50", Offset = "0x70D2C50", VA = "0x1870D3E50")]
	[CompilerGenerated]
	private void JPGBCGJHIHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x70CCD90", Offset = "0x70CBB90", VA = "0x1870CCD90")]
	[CompilerGenerated]
	private void CHBDBELKCEL(ACOOIKABMPL DILOMOBFEEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x70D45E0", Offset = "0x70D33E0", VA = "0x1870D45E0")]
	[CompilerGenerated]
	private void KGIIDLOFPAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x70CF380", Offset = "0x70CE180", VA = "0x1870CF380")]
	[CompilerGenerated]
	private void DNMKAKCGGIA(ACOOIKABMPL DILOMOBFEEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x70CF3A0", Offset = "0x70CE1A0", VA = "0x1870CF3A0")]
	[CompilerGenerated]
	private void DOGOOJCENDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x70D1AD0", Offset = "0x70D08D0", VA = "0x1870D1AD0")]
	[CompilerGenerated]
	private void FGDJFEONKFN(ACOOIKABMPL DILOMOBFEEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x70D3040", Offset = "0x70D1E40", VA = "0x1870D3040")]
	[CompilerGenerated]
	private void IIKKEIOCEJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x70D3D40", Offset = "0x70D2B40", VA = "0x1870D3D40")]
	[CompilerGenerated]
	private void JHPBJDBJCBA(ACOOIKABMPL DILOMOBFEEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x70D4E90", Offset = "0x70D3C90", VA = "0x1870D4E90")]
	[CompilerGenerated]
	private void LJOJCODFJIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x70D1F20", Offset = "0x70D0D20", VA = "0x1870D1F20")]
	[CompilerGenerated]
	private void GPDNDIEFPON(ACOOIKABMPL DILOMOBFEEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x70D3CB0", Offset = "0x70D2AB0", VA = "0x1870D3CB0")]
	[CompilerGenerated]
	private void JFEOCAPCFMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x70CC790", Offset = "0x70CB590", VA = "0x1870CC790")]
	[CompilerGenerated]
	private void BCMKFGBKODM(ACOOIKABMPL DILOMOBFEEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x70CFC80", Offset = "0x70CEA80", VA = "0x1870CFC80")]
	[CompilerGenerated]
	private void EJMDFCEMEMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x70CD560", Offset = "0x70CC360", VA = "0x1870CD560")]
	[CompilerGenerated]
	private void DGBEIKPGPOC(ACOOIKABMPL DILOMOBFEEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x70CCFA0", Offset = "0x70CBDA0", VA = "0x1870CCFA0")]
	[CompilerGenerated]
	private void CLCCEGNOACE(KeyValuePair<string, MEPEJIIMKOI<Texture2D>> BCMHAMBOGLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x70D6C40", Offset = "0x70D5A40", VA = "0x1870D6C40")]
	[CompilerGenerated]
	private void PCKGKFCPFBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x70D6C10", Offset = "0x70D5A10", VA = "0x1870D6C10")]
	[CompilerGenerated]
	private void PBFOPDOFFOD(ACOOIKABMPL DILOMOBFEEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x70D5EA0", Offset = "0x70D4CA0", VA = "0x1870D5EA0")]
	[CompilerGenerated]
	private void NEHEKJCEGCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x70D40B0", Offset = "0x70D2EB0", VA = "0x1870D40B0")]
	[CompilerGenerated]
	private void KCEEBDOJPOG(ACOOIKABMPL DILOMOBFEEI)
	{
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public class AvatarElbowBendHelperController : MonoBehaviour, EPMLCLIPPMA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		[SerializeField]
		[EECICDBJENE(ADIKDNKOEBP.Self, false, false, false)]
		private Transform ElbowHelperBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		[SerializeField]
		private Transform UpperArmBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		[SerializeField]
		private Transform LowerArmBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		[SerializeField]
		private float MinAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		[SerializeField]
		private float MaxAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		[SerializeField]
		[FormerlySerializedAs("MinScaleValues")]
		[Header("Scale")]
		private Vector3 ScaleValuesAtMinAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		[SerializeField]
		[FormerlySerializedAs("MaxScaleValues")]
		private Vector3 ScaleValuesAtMaxAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		[Header("Positional Offset")]
		[SerializeField]
		[FormerlySerializedAs("MinLocalPositionalOffset")]
		private Vector3 PositionalOffsetAtMinAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		[FormerlySerializedAs("MaxLocalPositionOffset")]
		[SerializeField]
		private Vector3 PositionalOffsetAtMaxAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		private Vector3? HINNFKOLNEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		private bool MJDDBHMLIHJ;

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x70C7300", Offset = "0x70C6100", VA = "0x1870C7300", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x70C7930", Offset = "0x70C6730", VA = "0x1870C7930", Slot = "4")]
		public void UpdateController(float GLDLKCMKFON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0xB00B50", Offset = "0xAFF950", VA = "0x180B00B50", Slot = "6")]
		public void SetEnabled(bool IPHILEOFJLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x70C73E0", Offset = "0x70C61E0", VA = "0x1870C73E0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x70C7DF0", Offset = "0x70C6BF0", VA = "0x1870C7DF0")]
		public AvatarElbowBendHelperController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class AvatarElbowBendTargetController : MonoBehaviour, EPMLCLIPPMA
	{
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		private const float CBNOJCEDNII = 45f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		[EECICDBJENE(ADIKDNKOEBP.Self, false, false, false)]
		[SerializeField]
		private Transform ElbowBendTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		[SerializeField]
		private Transform NeckBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		[SerializeField]
		private Transform UpperArmBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		[SerializeField]
		private Transform HandBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		[SerializeField]
		private bool Left;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		[SerializeField]
		private float MinTwist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		[SerializeField]
		private float MaxTwist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		[SerializeField]
		private float TwistWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		[SerializeField]
		private float ElbowSmoothTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		[SerializeField]
		private float RestTwist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		[SerializeField]
		private float RestTwistWhenClose;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		[SerializeField]
		private float RestTwistDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private Vector3 HHNAPKGHGKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private Vector3 NCDAKCBJJKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private bool MJDDBHMLIHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		private float OGJMPDJGCIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private float EEHPHGCNOMB;

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x70C8170", Offset = "0x70C6F70", VA = "0x1870C8170", Slot = "4")]
		public void UpdateController(float GLDLKCMKFON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0xFB7540", Offset = "0xFB6340", VA = "0x180FB7540", Slot = "6")]
		public void SetEnabled(bool IPHILEOFJLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x70C7E90", Offset = "0x70C6C90", VA = "0x1870C7E90")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x70C8C30", Offset = "0x70C7A30", VA = "0x1870C8C30")]
		public AvatarElbowBendTargetController()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class PEMELOCIHLO : EKOHFHHJFFI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	private static readonly int PMCFDJBBFFA;

	[Cpp2IlInjected.Token(Token = "0x4000131")]
	private static readonly int OMEBEALNBCF;

	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private static readonly int DCPFACNOEPM;

	[Cpp2IlInjected.Token(Token = "0x4000133")]
	private static readonly int OOFMFIFBMHI;

	[Cpp2IlInjected.Token(Token = "0x4000134")]
	private static readonly int COPDIKMOINN;

	[Cpp2IlInjected.Token(Token = "0x4000135")]
	private static readonly int PJIIFADGGIH;

	[Cpp2IlInjected.Token(Token = "0x4000136")]
	private static readonly int HBLGEDJNOLN;

	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private static readonly int DJHCMDCFNLO;

	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private static readonly int IEKCKGONPJB;

	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private static readonly int MKHKJLILBNE;

	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private static readonly int KIDIAGMOGON;

	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private static readonly int BKNMJJCLHGE;

	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private static readonly int LFOEDNKGOOA;

	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private static readonly int EJCACJJLCBI;

	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private static readonly int LHPDMMMDDEM;

	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private static readonly int GDGIIDHBKAP;

	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private static readonly int CHECMCJFGBM;

	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private static readonly int IIFFNKLBCLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private Transform EJACFAFCKGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private Transform JBEOLJFGDAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private Transform NOCOAFFDGEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private Transform IJGBAHIAFFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private Transform JAHDFMLMOOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private Transform HCFPGPHBIHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private Transform ALPIFAIFGEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private EELCGLKONEG AOMPNCPOCPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private Material BEJIHOMKGIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private SkinnedMeshRenderer[] KFLFLFGBEBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private readonly List<Material> LAPKIELAFDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private DONFNGKIDGE HAAJKMBBBAH;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public GAMKKEJCIBM JCDHMAJHGHL
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x8F4460", Offset = "0x8F3260", VA = "0x1808F4460", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	private DONFNGKIDGE BOJJGIBLIDA
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x70DC0E0", Offset = "0x70DAEE0", VA = "0x1870DC0E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool FIMGNNJILII
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x70DBAA0", Offset = "0x70DA8A0", VA = "0x1870DBAA0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x70DD610", Offset = "0x70DC410", VA = "0x1870DD610")]
	public void JEELJGCJJCO([In] EELCGLKONEG LNFEAFIABKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x70DBFB0", Offset = "0x70DADB0", VA = "0x1870DBFB0")]
	public void CEMOMIJDDCK([In] FLLKJAPFNPO CNKPMEJAGLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x70DD130", Offset = "0x70DBF30", VA = "0x1870DD130", Slot = "6")]
	public void ILEIKOFHHIF(BHNOKIHMHBG CLJNGJJKDJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x70DC1D0", Offset = "0x70DAFD0", VA = "0x1870DC1D0")]
	private Vector2 EADFGKHJHPJ(Vector2 KFLLGLDLNPK)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x70DC230", Offset = "0x70DB030", VA = "0x1870DC230")]
	public void FGIGKHMCJJN([In] ONPNDJNGFJA CNKPMEJAGLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x70DD6E0", Offset = "0x70DC4E0", VA = "0x1870DD6E0")]
	private void KMBEPFOELNN(DFOOGPOFEBC GBHCCAHHNMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x70DBC20", Offset = "0x70DAA20", VA = "0x1870DBC20")]
	private void BEEMCKMGGOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x70DC160", Offset = "0x70DAF60", VA = "0x1870DC160")]
	private void DLAFOIOHJKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x70DC160", Offset = "0x70DAF60", VA = "0x1870DC160", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x70DDD70", Offset = "0x70DCB70", VA = "0x1870DDD70")]
	public PEMELOCIHLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x70DBFB0", Offset = "0x70DADB0", VA = "0x1870DBFB0", Slot = "5")]
	private void CABPBFJCBFH([In] FLLKJAPFNPO CNKPMEJAGLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x70DDA30", Offset = "0x70DC830", VA = "0x1870DDA30", Slot = "7")]
	private void NIBJPOOHGIC([In] ONPNDJNGFJA CNKPMEJAGLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x70DC050", Offset = "0x70DAE50", VA = "0x1870DC050")]
	[CompilerGenerated]
	internal static (float, float) CACKLFCKLJL(float HAJIIALLFKD)
	{
		return default((float, float));
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x70DD0F0", Offset = "0x70DBEF0", VA = "0x1870DD0F0")]
	[CompilerGenerated]
	internal static Vector4 GDBGDDOKALO(Vector2 AKEODPFBHJE, Vector2 KFHMJCONBDC)
	{
		return default(Vector4);
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class AvatarForearmRollController : MonoBehaviour, EPMLCLIPPMA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		[SerializeField]
		private Transform TwistBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		[SerializeField]
		private Transform HandBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		[SerializeField]
		private Transform LowerArmTwistBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		[SerializeField]
		private Transform UpperArmTwistBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		[SerializeField]
		private Transform ElbowTwistBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		[SerializeField]
		private float RollTowardsWristAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		[SerializeField]
		private float RollSoftMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		[SerializeField]
		private float RollSoftMax;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		[SerializeField]
		private float LowerArmTwistAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		[SerializeField]
		private float UpperArmTwistAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		[SerializeField]
		private float ElbowTwistAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private float OGJMPDJGCIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		private bool MJDDBHMLIHJ;

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x70E3890", Offset = "0x70E2690", VA = "0x1870E3890", Slot = "4")]
		public void UpdateController(float GLDLKCMKFON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x1466190", Offset = "0x1464F90", VA = "0x181466190", Slot = "6")]
		public void SetEnabled(bool IPHILEOFJLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x70E4320", Offset = "0x70E3120", VA = "0x1870E4320")]
		public AvatarForearmRollController()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class AvatarHandDisplaySettings
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000029")]
		public class AnimationOverride
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400015E")]
			[Tooltip("Name of animation original state to override")]
			public string OriginalName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400015F")]
			[Tooltip("Name of animation state to use as an override")]
			public string OverrideName;

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
			public AnimationOverride()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		[SerializeField]
		private AnimationOverride[] HandStateOverrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		private Dictionary<int, int> _animationOverrides;

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x70E43C0", Offset = "0x70E31C0", VA = "0x1870E43C0")]
		public void EODJIAICOIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x70E4350", Offset = "0x70E3150", VA = "0x1870E4350")]
		public int AEBBFNCPLEC(int MOLIFGBEJPH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public AvatarHandDisplaySettings()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class LIKFABAHPMB : JHPLIMCMHML
{
	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x70EC000", Offset = "0x70EAE00", VA = "0x1870EC000", Slot = "22")]
	public override float CCHCOLKOCJK()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x70EC050", Offset = "0x70EAE50", VA = "0x1870EC050")]
	public LIKFABAHPMB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class JHPLIMCMHML : CNGDBOGKMMI
{
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	private static int GMLMEEJDGEO;

	[Cpp2IlInjected.Token(Token = "0x4000161")]
	private static int IELPIIDMAFP;

	[Cpp2IlInjected.Token(Token = "0x4000162")]
	private static int LANIKKKDALI;

	[Cpp2IlInjected.Token(Token = "0x4000163")]
	private static int HCECKIGEAAJ;

	[Cpp2IlInjected.Token(Token = "0x4000164")]
	private static int OJNEFMEGDKP;

	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private static int NLAAPHHIPKM;

	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private static int KOPCMPGJMMH;

	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private static int[] LONLICFPKPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private ANABLFKAJDC AOMPNCPOCPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private KPEFDFIMAKD JKLKOKGHPLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	private int KDEONFCMKHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	private float MBPCCDJHCGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	protected Animator BDFHJIHHOIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	protected bool HNLNFKFDCOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	protected AvatarConfiguration OCAKIALOPPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	protected int BAJEMAJPAJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private int LBDMCFMGCLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private int IHALHEALPKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private bool PCKFDCJCFBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private FLAHKEDFHDA AKFHIOHIIDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private int ECJABDMPANC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private float LEOIGKNAIMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private AvatarHandDisplaySettings KMFGPPDGPIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	private ENGPMKLLDHI KPBMFIKGCOO;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public Transform ONPOOODOODH
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x8F4460", Offset = "0x8F3260", VA = "0x1808F4460")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x8F41C0", Offset = "0x8F2FC0", VA = "0x1808F41C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public Vector3 FBKDNNFNLAA
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x1468550", Offset = "0x1467350", VA = "0x181468550")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x1468510", Offset = "0x1467310", VA = "0x181468510")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public Quaternion IPEHHBLHKGK
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0xBE6680", Offset = "0xBE5480", VA = "0x180BE6680")]
		[CompilerGenerated]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x151BE60", Offset = "0x151AC60", VA = "0x18151BE60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public bool NCGOILGKEEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x70EA170", Offset = "0x70E8F70", VA = "0x1870EA170")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x70E9C30", Offset = "0x70E8A30", VA = "0x1870E9C30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public Vector3 BLAHPGPPDKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x70E97E0", Offset = "0x70E85E0", VA = "0x1870E97E0", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x70EA1A0", Offset = "0x70E8FA0", VA = "0x1870EA1A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public Quaternion CECLPOOHNBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x29A0A50", Offset = "0x299F850", VA = "0x1829A0A50", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x29A0A40", Offset = "0x299F840", VA = "0x1829A0A40")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public LFOHJBFCKOA BMEECCNMPHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0xA59440", Offset = "0xA58240", VA = "0x180A59440", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return default(LFOHJBFCKOA);
		}
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0xA59310", Offset = "0xA58110", VA = "0x180A59310", Slot = "4")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public LFOHJBFCKOA FBPLNHLFBMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x21BF3E0", Offset = "0x21BE1E0", VA = "0x1821BF3E0", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return default(LFOHJBFCKOA);
		}
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x21BE370", Offset = "0x21BD170", VA = "0x1821BE370", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public float MGCJANNGHDP
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x12B0050", Offset = "0x12AEE50", VA = "0x1812B0050", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0xDAC550", Offset = "0xDAB350", VA = "0x180DAC550", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool NDDBFCOHGPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x70E9A60", Offset = "0x70E8860", VA = "0x1870E9A60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public bool EFCEFNIGMGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x70EA1C0", Offset = "0x70E8FC0", VA = "0x1870EA1C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool ICCBGPEJBEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x70E9A40", Offset = "0x70E8840", VA = "0x1870E9A40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public bool IHAALMLLLDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x70E9A50", Offset = "0x70E8850", VA = "0x1870E9A50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x70E9A90", Offset = "0x70E8890", VA = "0x1870E9A90", Slot = "21")]
	public void JEELJGCJJCO(ANABLFKAJDC LNFEAFIABKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x70E9820", Offset = "0x70E8620", VA = "0x1870E9820")]
	public void BPKMFCAHILB(KPEFDFIMAKD PMECDIABPOM, AvatarHandDisplaySettings PLJONEDBEPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x70EA1D0", Offset = "0x70E8FD0", VA = "0x1870EA1D0", Slot = "12")]
	public void PKIJFEKNJFG(bool OHPJAPBNBPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x70E9E00", Offset = "0x70E8C00", VA = "0x1870E9E00", Slot = "11")]
	public void LMAGGCLKJPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x12B0050", Offset = "0x12AEE50", VA = "0x1812B0050", Slot = "22")]
	public virtual float CCHCOLKOCJK()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x70E9C70", Offset = "0x70E8A70", VA = "0x1870E9C70")]
	private int LLABAAGLLIF(LFOHJBFCKOA JPLFANFCANH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x70E9880", Offset = "0x70E8680", VA = "0x1870E9880")]
	private void DNCPELAADAO(int NHLDIKCAKKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x70E9800", Offset = "0x70E8600", VA = "0x1870E9800", Slot = "13")]
	public bool BLFJJEFCPKC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x70E9C60", Offset = "0x70E8A60", VA = "0x1870E9C60", Slot = "14")]
	public bool JPJPEEEAOCN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x70E9740", Offset = "0x70E8540", VA = "0x1870E9740")]
	private LFOHJBFCKOA AHOGLHADAAF()
	{
		return default(LFOHJBFCKOA);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x1B453A0", Offset = "0x1B441A0", VA = "0x181B453A0", Slot = "15")]
	public void NCFDBMOHJDM(bool OHPJAPBNBPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x70EA260", Offset = "0x70E9060", VA = "0x1870EA260", Slot = "10")]
	public void PMCMMAHLCDF(int NHLDIKCAKKA, float LNEKNKCELHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x70E9A70", Offset = "0x70E8870", VA = "0x1870E9A70", Slot = "8")]
	public void HNDPHMHMCNH(FLAHKEDFHDA DKNLFDPIIII, bool BNMEJFFHBGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x70E9870", Offset = "0x70E8670", VA = "0x1870E9870", Slot = "9")]
	public void DKMFPJJOKJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x70E9790", Offset = "0x70E8590", VA = "0x1870E9790", Slot = "16")]
	public void AIFGAJKPCKM(Transform IFAMCPHMKIP, Vector3 NGACLEMKAKC, Quaternion OHMOMMHOMGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x70EA570", Offset = "0x70E9370", VA = "0x1870EA570")]
	public JHPLIMCMHML()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class KMLIPALDANH : GHDINHKOOCF
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class HHIMPKJPBGC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public KMLIPALDANH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public List<PGIHMBHBFKK> prefabHandles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public List<PGIHMBHBFKK> materialHandles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		public MEPEJIIMKOI<Material[]> loadMaterialsHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		public MEPEJIIMKOI<HMPJIGGJCHE> loadPrefabHandle;

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public HHIMPKJPBGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x70E8D00", Offset = "0x70E7B00", VA = "0x1870E8D00")]
		internal LDHIGNIGDAL MFPFFBIPBAG(string error)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	public EPEMMDIFGGB MLFKEACAEKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	public HMPJIGGJCHE CMFCHCNBFNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	private MEPEJIIMKOI<HMPJIGGJCHE> EFHOGKLCLPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	private MEPEJIIMKOI<Material[]> MAAJHKCHDDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	public Material[] NOGEBBEKGMD;

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool MHJKPLFHNBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0xCA2000", Offset = "0xCA0E00", VA = "0x180CA2000")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0xCA1EC0", Offset = "0xCA0CC0", VA = "0x180CA1EC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public HFBLFLDOFLG.KLFEKKPPLNK HGLOIHKCJPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0xB48030", Offset = "0xB46E30", VA = "0x180B48030")]
		[CompilerGenerated]
		get
		{
			return default(HFBLFLDOFLG.KLFEKKPPLNK);
		}
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x11C1EA0", Offset = "0x11C0CA0", VA = "0x1811C1EA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x70EBEA0", Offset = "0x70EACA0", VA = "0x1870EBEA0")]
	public KMLIPALDANH(GKHPEMHLGJO EBFHFEGNDFC, EPEMMDIFGGB LLBJFLABKAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x70EB060", Offset = "0x70E9E60", VA = "0x1870EB060", Slot = "6")]
	public override LDHIGNIGDAL BNNGMNLBGEG(List<PGIHMBHBFKK> IFFCILHDEMJ, List<PGIHMBHBFKK> NGBNAKNINHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x70EB6A0", Offset = "0x70EA4A0", VA = "0x1870EB6A0")]
	public LDHIGNIGDAL HHFCDHBOGEL(List<PGIHMBHBFKK> IFFCILHDEMJ, List<PGIHMBHBFKK> NGBNAKNINHL, MEPEJIIMKOI<Material[]> MAAJHKCHDDF, MEPEJIIMKOI<HMPJIGGJCHE> OHBJENKMGLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x70EB9B0", Offset = "0x70EA7B0", VA = "0x1870EB9B0")]
	public (MEPEJIIMKOI<Material[]>, MEPEJIIMKOI<HMPJIGGJCHE>) NILKGDMBBIG(List<PGIHMBHBFKK> IFFCILHDEMJ, List<PGIHMBHBFKK> NGBNAKNINHL)
	{
		return default((MEPEJIIMKOI<Material[]>, MEPEJIIMKOI<HMPJIGGJCHE>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x70EBD20", Offset = "0x70EAB20", VA = "0x1870EBD20", Slot = "7")]
	public override FMDJJFCBLGJ ODKINKMEMCC(uint DFCGNGEAOFE, AvatarSkinnedMeshBoneOrderRemapsData NPKABAIJPKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x70EB470", Offset = "0x70EA270", VA = "0x1870EB470")]
	public FMDJJFCBLGJ FMHMDBLBKFG(GameObject HNOIJEPJCGK, uint DFCGNGEAOFE, bool EKGMHGFAHCE, bool DJNNDGLLOAC, AvatarSkinnedMeshBoneOrderRemapsData NPKABAIJPKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x70EACF0", Offset = "0x70E9AF0", VA = "0x1870EACF0")]
	public static bool BKAFCDMBENC(Renderer[] NAOBDCMABCL, string IIGDLHMBGAA, [Out] Renderer PHPGEFLOEIM, [Out] Renderer OIGMAHMLMFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x70EBE50", Offset = "0x70EAC50", VA = "0x1870EBE50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x70EB3B0", Offset = "0x70EA1B0", VA = "0x1870EB3B0")]
	private (MEPEJIIMKOI<HMPJIGGJCHE>, MEPEJIIMKOI<Material[]>) DJFGOKCONAJ()
	{
		return default((MEPEJIIMKOI<HMPJIGGJCHE>, MEPEJIIMKOI<Material[]>));
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x70EB680", Offset = "0x70EA480", VA = "0x1870EB680")]
	[CompilerGenerated]
	private void GNEOPGMMEJC(HMPJIGGJCHE LDEANEOLAOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x8F4250", Offset = "0x8F3050", VA = "0x1808F4250")]
	[CompilerGenerated]
	private void HPOFEDDOMAJ(Material[] LDEANEOLAOA)
	{
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public class AvatarKneeBendTargetController : MonoBehaviour, EPMLCLIPPMA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		[EECICDBJENE(ADIKDNKOEBP.Self, false, false, false)]
		[SerializeField]
		private Transform KneeBendTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		[SerializeField]
		private Transform RootSpineBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		[SerializeField]
		private Transform ThighBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		[SerializeField]
		private Transform FootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		[SerializeField]
		private float WeightToFootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		[SerializeField]
		private Vector3 BendTargetOffsetFromHipToFootMidPoint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		[SerializeField]
		private Bounds KneeTargetConstrainedBox;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		private Vector3 HHNAPKGHGKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		private Vector3 GMEMFECOGLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		private Vector3 NIOPIPCJMML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		private Matrix4x4 MPCIIBCHDKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		private bool MJDDBHMLIHJ;

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x70E4950", Offset = "0x70E3750", VA = "0x1870E4950", Slot = "4")]
		public void UpdateController(float GLDLKCMKFON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x70E4940", Offset = "0x70E3740", VA = "0x1870E4940", Slot = "6")]
		public void SetEnabled(bool IPHILEOFJLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x70E44E0", Offset = "0x70E32E0", VA = "0x1870E44E0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x70E5010", Offset = "0x70E3E10", VA = "0x1870E5010")]
		public AvatarKneeBendTargetController()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[HLDENJBKDHO]
public struct OIBCHAFODIK : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	[ReadOnly]
	public ABAFBKGEJEK BJEKLALIJEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	[ReadOnly]
	public int JCAGJMEHFKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	public PPGJJMIMGAO INBLGBOGLOH;

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x70ECBB0", Offset = "0x70EB9B0", VA = "0x1870ECBB0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[NativeContainer]
[HLDENJBKDHO]
public struct PPGJJMIMGAO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	public NativeArray<Vector3> OGMLDJHKFDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	public NativeArray<Vector3> PEDGHONACMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	public NativeArray<Vector4> GICFOOJOJFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	public NativeArray<Vector2> BBOBCMBLKLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	public NativeArray<Vector2> JHOIILCHPFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	public NativeArray<Vector2> ILJJKEDMGEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	public NativeArray<Vector2> CABIAKBDKHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	public NativeArray<Color> MNGMIJDCJLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	public NativeArray<int> JHHNBFHOCKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	public NativeArray<int> AFAMFFNKMFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	private NativeArray<int> DMEMICMLPEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	private NativeArray<int> HCAPAILKNMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	public NativeArray<int> IAOACAEIIJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	public NativeArray<int> PBEFLJHKEHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	public NativeArray<int> PGBOFHDBFOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	public NativeArray<BoneWeight> DEGIMDHKKGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private NativeArray<int> KODPGCABALO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	private bool BMMBPKGMHHK;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public int FKBELOAEFGP
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x70EEAC0", Offset = "0x70ED8C0", VA = "0x1870EEAC0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x70EF0E0", Offset = "0x70EDEE0", VA = "0x1870EF0E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public int JEFPEDDKPII
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x70EF220", Offset = "0x70EE020", VA = "0x1870EF220")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x70EE8B0", Offset = "0x70ED6B0", VA = "0x1870EE8B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public int JFBKMCEHNEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x70EF0F0", Offset = "0x70EDEF0", VA = "0x1870EF0F0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x70EF210", Offset = "0x70EE010", VA = "0x1870EF210")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x70EF300", Offset = "0x70EE100", VA = "0x1870EF300")]
	public PPGJJMIMGAO(int NDHAJEKPDOG, int BLNFPABNKBH, int ACNJIPFGBIB, int LIFAMKGAGAB, Allocator GCNJHJPCIGN, int OMJHJCHCALK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x70EF1A0", Offset = "0x70EDFA0", VA = "0x1870EF1A0")]
	public void NKFPNLKGBGN(int KNCPCNBMDNF, Vector3 MFHMIEFHEKN, Vector3 PANJCGCFAKM, Vector4 DHJLEBFEJME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x70EEBA0", Offset = "0x70ED9A0", VA = "0x1870EEBA0")]
	public void HCNNIDEMOEL(int KNCPCNBMDNF, BoneWeight PMFDECCNAMF, NativeSlice<byte> FOKMELOPJDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x70EE8C0", Offset = "0x70ED6C0", VA = "0x1870EE8C0")]
	public Color CDMDHCOJOHK(int KNCPCNBMDNF)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x70EF230", Offset = "0x70EE030", VA = "0x1870EF230")]
	public void OMGOBEAOEMM(int KNCPCNBMDNF, Color MKIHPGLMNDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x70EF090", Offset = "0x70EDE90", VA = "0x1870EF090")]
	public void JAGELJPHGIC(byte LCHCPAEAJJL, int KNCPCNBMDNF, Vector2 LADGMJPGFIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x70EF190", Offset = "0x70EDF90", VA = "0x1870EF190")]
	public void NGFAMJIMJBF(int KNCPCNBMDNF, int HBOLPMKJNPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x70EE8E0", Offset = "0x70ED6E0", VA = "0x1870EE8E0")]
	public bool CMAFIAEPDDB(int LCHCPAEAJJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x70EEAD0", Offset = "0x70ED8D0", VA = "0x1870EEAD0")]
	public void EKDEGNNKFKH(int EDFOAHFPELN, int DACBEFNKNPO, int AIIKLGOLFIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x70EF250", Offset = "0x70EE050", VA = "0x1870EF250")]
	public int[] PICCMECEBKA(int EDFOAHFPELN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x70EF100", Offset = "0x70EDF00", VA = "0x1870EF100")]
	private NativeSlice<int> LHCFEOOCADH(int EDFOAHFPELN)
	{
		return default(NativeSlice<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x70EE910", Offset = "0x70ED710", VA = "0x1870EE910", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x70EED40", Offset = "0x70EDB40", VA = "0x1870EED40")]
	public Mesh HIPCBHNDELB([Optional] string CJELMMICOBG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[NativeContainer]
[HLDENJBKDHO]
[DefaultMember("Item")]
public struct ABAFBKGEJEK : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	public NativeArray<Vector3> OGMLDJHKFDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	public NativeArray<Vector3> PEDGHONACMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	public NativeArray<Vector4> GICFOOJOJFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	public NativeArray<Vector2> BBOBCMBLKLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	public NativeArray<Vector2> JHOIILCHPFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	public NativeArray<Vector2> ILJJKEDMGEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	public NativeArray<Vector2> CABIAKBDKHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	public NativeArray<Color> MNGMIJDCJLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	public NativeArray<int> NMKBICNCACK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	public NativeArray<int> IGKINAMFDND;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	public NativeArray<int> JONNEGBGKLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	public NativeArray<int> ACADJCGIDGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	public NativeArray<bool> HKHJIFBHHCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	public NativeArray<int> GPPIONCBAJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	public NativeArray<int> JPGJPNNENIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	public NativeArray<BoneWeight> ABCKJCKPNNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	private NativeArray<Matrix4x4> JJCGAPMHMGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	private NativeArray<int> GDEIOPNFCIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	private NativeArray<byte> OPJONKLNALM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	private NativeArray<int> ONBNEMLEHLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	private NativeArray<int> FJPGJPOCHON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	public NativeArray<sbyte> LGOGKMDCHCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	public NativeArray<byte> EBCEPLLPOJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	private NativeArray<int> ALIOLHHNKCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	private bool BMMBPKGMHHK;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public int GNOECLLHDIP
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x2533EA0", Offset = "0x2532CA0", VA = "0x182533EA0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public int BGHGJBLHFJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0xB03A60", Offset = "0xB02860", VA = "0x180B03A60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public int OJANEBEFAGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x70DEA10", Offset = "0x70DD810", VA = "0x1870DEA10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public int JMNPJEDLDLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x70DE750", Offset = "0x70DD550", VA = "0x1870DE750")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x70DEA40", Offset = "0x70DD840", VA = "0x1870DEA40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public int FKBELOAEFGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x70DE9C0", Offset = "0x70DD7C0", VA = "0x1870DE9C0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x70DEA00", Offset = "0x70DD800", VA = "0x1870DEA00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public int MDDHBPGJCCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x70DE9F0", Offset = "0x70DD7F0", VA = "0x1870DE9F0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x70DEF70", Offset = "0x70DDD70", VA = "0x1870DEF70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public EBGAKLBCDPI MGIIMCHFJAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x70DE740", Offset = "0x70DD540", VA = "0x1870DE740")]
		get
		{
			return default(EBGAKLBCDPI);
		}
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x70DE9E0", Offset = "0x70DD7E0", VA = "0x1870DE9E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public byte JDNBHDFIPOF
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x70DE9D0", Offset = "0x70DD7D0", VA = "0x1870DE9D0")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x70DE730", Offset = "0x70DD530", VA = "0x1870DE730")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public NDCHDOEFIFK FCGIOOCDKLL
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x70DEA50", Offset = "0x70DD850", VA = "0x1870DEA50")]
		get
		{
			return default(NDCHDOEFIFK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x70DEF80", Offset = "0x70DDD80", VA = "0x1870DEF80")]
	public ABAFBKGEJEK(IList<Mesh> EDNMMACAGLG, IList<Matrix4x4> HNLDCFBPNGL, IList<bool> HKHJIFBHHCF, byte KANGNLBMHIH, IList<byte[]> CCGFKJMKAOI, IList<int> LLMBHAABMFL, IList<bool> FCPFHNMFDEO, IList<int> GPPIONCBAJE, IList<int> IFFOIOLMLOM, IList<int> HDKFDIDELLL, Allocator GCNJHJPCIGN, EBGAKLBCDPI NNAIFONDPBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x70DE660", Offset = "0x70DD460", VA = "0x1870DE660")]
	public PPGJJMIMGAO BBMNJLKJGBJ(Allocator GCNJHJPCIGN)
	{
		return default(PPGJJMIMGAO);
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x70DE760", Offset = "0x70DD560", VA = "0x1870DE760", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[HLDENJBKDHO]
public class KOFLOGAICIH : AJKMAOEGKOD
{
	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x70EBF10", Offset = "0x70EAD10", VA = "0x1870EBF10")]
	public ABAFBKGEJEK EJDBONHCPIP()
	{
		return default(ABAFBKGEJEK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x70D7C60", Offset = "0x70D6A60", VA = "0x1870D7C60")]
	public KOFLOGAICIH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public struct NDCHDOEFIFK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	public NativeSlice<Vector3> OGMLDJHKFDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	public NativeSlice<Vector3> PEDGHONACMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	public NativeSlice<Vector4> GICFOOJOJFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	public NativeSlice<Vector2> BBOBCMBLKLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	public NativeSlice<Vector2> JHOIILCHPFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	public NativeSlice<Vector2> ILJJKEDMGEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	public NativeSlice<Vector2> CABIAKBDKHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	public NativeSlice<Color> MNGMIJDCJLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	public NativeSlice<int> LABHJELAEFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	public NativeSlice<int> ACADJCGIDGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	public NativeSlice<BoneWeight> ABCKJCKPNNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	public NativeSlice<byte> BJBLPKFFKIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	public int OPMMMDFCHKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	public Matrix4x4 JGDENEFEGNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	public int FPOLJLMJPGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	public NativeSlice<byte> FOKMELOPJDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	public bool ADAAPODOPAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	public int BIHCCDBGPAF;
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal readonly struct JPBDKBJNHGA : IEquatable<JPBDKBJNHGA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	internal readonly Material CELLCPCCNAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	internal readonly OEFGHLPBFDF HPKEBCKCIFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	internal readonly IMOIFEKEDED HKPJGMHJCEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	internal readonly GKHPEMHLGJO JABAKEOGIPH;

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x70EACB0", Offset = "0x70E9AB0", VA = "0x1870EACB0")]
	public JPBDKBJNHGA(Material FAGGGCGAPOE, OEFGHLPBFDF DFNLJLMBKBN, IMOIFEKEDED APMDGBOOICP, GKHPEMHLGJO DNGHOGLAIFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x70EAA80", Offset = "0x70E9880", VA = "0x1870EAA80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x70EA870", Offset = "0x70E9670", VA = "0x1870EA870", Slot = "4")]
	public bool Equals(JPBDKBJNHGA LHMPMCLNOPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x70EA8F0", Offset = "0x70E96F0", VA = "0x1870EA8F0", Slot = "0")]
	public override bool Equals(object JOOHPPHJKMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x70EA9E0", Offset = "0x70E97E0", VA = "0x1870EA9E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[DisallowMultipleComponent]
	public class AvatarModernBodyDisplayBehaviour : MonoBehaviour, NJFENNNGEPA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		[Header("Configuration")]
		[SerializeField]
		protected AvatarConfiguration configuration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		[SerializeField]
		protected Animator skeletonAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		[SerializeField]
		protected Renderer[] watchRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		[Header("Configuration")]
		[SerializeField]
		private ENGPMKLLDHI avatarBodyType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		[SerializeField]
		private AvatarSkinAssetItem potatoAvatarSkinAssetItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		[FormerlySerializedAs("avatarSkinAsset")]
		[SerializeField]
		private AssetReference avatarSkinAssetReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		[SerializeField]
		private GameObject firstPersonMeshContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		[SerializeField]
		public GameObject thirdPersonMeshContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		[SerializeField]
		private GameObject[] hideInFirstPerson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		[SerializeField]
		protected Transform headAdditiveBaseBoneTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		[SerializeField]
		private Material BodyMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		[SerializeField]
		private Material FaceMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		[SerializeField]
		private Material DefaultAvatarItemMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		[SerializeField]
		private Shader AvatarDefaultShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		[SerializeField]
		private Shader AvatarUberShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		[SerializeField]
		private Transform DeformRigRootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		[SerializeField]
		private SkinnedMeshRenderer BaseSkinnedMeshRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		[SerializeField]
		protected AvatarSkinnedMeshBoneOrderRemapsData BoneOrderRemapsData;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		[Header("Arm Animation Controllers")]
		[SerializeField]
		private AvatarForearmRollController LeftForearmRollController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		[SerializeField]
		private AvatarElbowBendHelperController LeftElbowBendHelperController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		[SerializeField]
		private AvatarElbowBendTargetController LeftElbowBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		[SerializeField]
		private AvatarKneeBendTargetController LeftKneeBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		[SerializeField]
		private AvatarForearmRollController RightForearmRollController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		[SerializeField]
		private AvatarElbowBendHelperController RightElbowBendHelperController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		[SerializeField]
		private AvatarElbowBendTargetController RightElbowBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		[SerializeField]
		private AvatarKneeBendTargetController RightKneeBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		[SerializeField]
		private Transform LeftEyeBrowBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		[SerializeField]
		private Transform LeftEyeBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		[SerializeField]
		private Transform RightEyeBrowBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		[SerializeField]
		private Transform RightEyeBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		[SerializeField]
		private Transform NoseMoveTweakBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		[SerializeField]
		private Transform NoseScaleTweakBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		[SerializeField]
		private Transform MouthBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		[SerializeField]
		private AvatarBodyPartShapesManager avatarBodyPartShapesManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		[SerializeField]
		private Transform HeadTweakBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		[SerializeField]
		private Transform HatAnchorBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		[SerializeField]
		private Transform LeftHandWatchAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		[SerializeField]
		private Transform RightHandWatchAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		[SerializeField]
		private GameObject LeftHandWatchVisuals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		[SerializeField]
		private GameObject RightHandWatchVisuals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		private PHGIHCICACD OLKPEADKCFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		private EKOHFHHJFFI JAJDLKAKCJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		private CNGDBOGKMMI PAGFBDONEBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		private CNGDBOGKMMI MFHONPEBPPI;

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public PHGIHCICACD DACBPDNLHDK
		{
			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x70E5E40", Offset = "0x70E4C40", VA = "0x1870E5E40", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public EKOHFHHJFFI KIFJIADBJEC
		{
			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x70E5E90", Offset = "0x70E4C90", VA = "0x1870E5E90", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public CNGDBOGKMMI DFMCIHBGFOD
		{
			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x70E60B0", Offset = "0x70E4EB0", VA = "0x1870E60B0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public CNGDBOGKMMI ADDJLEPJAOB
		{
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x70E6100", Offset = "0x70E4F00", VA = "0x1870E6100", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public Transform EGFCCCDKJIC
		{
			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0x70E6150", Offset = "0x70E4F50", VA = "0x1870E6150", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public ENGPMKLLDHI CLECPHMEMPA
		{
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x8F9AC0", Offset = "0x8F88C0", VA = "0x1808F9AC0", Slot = "12")]
			get
			{
				return default(ENGPMKLLDHI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x70E5020", Offset = "0x70E3E20", VA = "0x1870E5020")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x70E5CA0", Offset = "0x70E4AA0", VA = "0x1870E5CA0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x70E55B0", Offset = "0x70E43B0", VA = "0x1870E55B0", Slot = "8")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x70E5CA0", Offset = "0x70E4AA0", VA = "0x1870E5CA0", Slot = "9")]
		public void TeardownAvatarDisplaySystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x70E5090", Offset = "0x70E3E90", VA = "0x1870E5090", Slot = "10")]
		public bool CleanupDisplayMeshes()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x70E5D50", Offset = "0x70E4B50", VA = "0x1870E5D50")]
		public void UpdatePostIKAnimControllers(float GLDLKCMKFON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x70E5610", Offset = "0x70E4410", VA = "0x1870E5610")]
		private void JCBLIOHAMOF(GameObject JOOHPPHJKMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x70E56A0", Offset = "0x70E44A0", VA = "0x1870E56A0")]
		private PHGIHCICACD LFBNBCENHDN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x70E53C0", Offset = "0x70E41C0", VA = "0x1870E53C0")]
		private EKOHFHHJFFI FLMGKFKJNGD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x70E5A10", Offset = "0x70E4810", VA = "0x1870E5A10")]
		private CNGDBOGKMMI OILENGDFCHJ(MHJFMIKGCOJ AOMFNDPKIJK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x70E5E30", Offset = "0x70E4C30", VA = "0x1870E5E30")]
		public AvatarModernBodyDisplayBehaviour()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public class ACOOIKABMPL : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400020E")]
	private MaterialPropertyBlock NHOAJODAIGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400020F")]
	public Color? KAOCJKEHIAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000210")]
	public Color? JDPCJHOMPOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000211")]
	public Color? CEILMDAIBPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000212")]
	public Color? BAGAEHJIAPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000213")]
	public Color BHDLCDDMMIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000214")]
	public Color AEOOOLHGBAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000215")]
	public Color PDPFGKNENFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000216")]
	public Texture2D AMLIHCDHJLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000217")]
	public Texture2D ENAJBDEAHEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000218")]
	private Dictionary<JPBDKBJNHGA, int> APNEFLENEEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000219")]
	private OEFGHLPBFDF[] LIJDHBFNLPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400021A")]
	private IMOIFEKEDED[] GGKOBBAPLAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400021B")]
	public Vector4[] DDNLCJGDCMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400021C")]
	public Vector4[] GLEKNGHGKLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	public Vector4[] MENFGBEAPAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	public Vector4[] DBGOHBNJHJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	public Vector4[] HMDBPHPBOPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	public Vector4[] IOGCJOEKOHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000221")]
	private List<Texture2D> KLHHJDGAPJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	private Vector4[] DLNLCABNMBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	private List<Texture2D> MFBGEGAFNOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	private float[] MFLELHBIHID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	private Vector4[] BOIKKIBGNCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	private float[] BLNCNLJCNIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	public float[] EAEDCPAHILA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000228")]
	private List<Texture2D> DBIMLCDNIKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	private float[] DFBEMDPHDAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	private List<Texture2D> AGKEIANAMKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	private Vector4[] GFLOMDGIELD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	private float[] JMEMOLBLMNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	private Vector4[] LMIMKJLBFDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	public float[] PIKFBLGFDNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	public Texture2DArray CPDODKFMJAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	public Texture2DArray NGHGONLMILB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	public Texture2DArray LOMEJOGGMBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	public Texture2DArray HONPEIFOOGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	private bool LFDDEPHLGIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x184")]
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	private int KOKGHJFBEKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	private Vector2? LAJNNJCAMJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x194")]
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	private TextureFormat KLDJFJCNJGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	private Vector2? NAFPPDDMNPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A4")]
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	private TextureFormat OOFGBMKOCDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	private Vector2? OEIMJFKIMAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B4")]
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	private TextureFormat FPPIFEECMKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	private Vector2? FLHOPPOBOMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C4")]
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	private TextureFormat OKBBIJHHECJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	private bool EICHBLDJPCE;

	[Cpp2IlInjected.Token(Token = "0x400023E")]
	private static int NEDJIGEEMHG;

	[Cpp2IlInjected.Token(Token = "0x400023F")]
	private static int ADCFJOCEOAE;

	[Cpp2IlInjected.Token(Token = "0x4000240")]
	private static int OPFEKNBAFFK;

	[Cpp2IlInjected.Token(Token = "0x4000241")]
	private static int MHDPCKEFKAF;

	[Cpp2IlInjected.Token(Token = "0x4000242")]
	private static int NBHKAMEKGKD;

	[Cpp2IlInjected.Token(Token = "0x4000243")]
	private static int COACPAKBIKI;

	[Cpp2IlInjected.Token(Token = "0x4000244")]
	private static int INEPIIOAJPI;

	[Cpp2IlInjected.Token(Token = "0x4000245")]
	private static int IADFDPGCLHA;

	[Cpp2IlInjected.Token(Token = "0x4000246")]
	private static int EDOINPJPDBN;

	[Cpp2IlInjected.Token(Token = "0x4000247")]
	private static int LHIHCNMNBOD;

	[Cpp2IlInjected.Token(Token = "0x4000248")]
	private static int AFIIGGEBJKI;

	[Cpp2IlInjected.Token(Token = "0x4000249")]
	private static int DHIPOAEPFGN;

	[Cpp2IlInjected.Token(Token = "0x400024A")]
	private static int HGKAINLDPBJ;

	[Cpp2IlInjected.Token(Token = "0x400024B")]
	private static int CNBEAGEBCEA;

	[Cpp2IlInjected.Token(Token = "0x400024C")]
	private static int APLHDMPNKPP;

	[Cpp2IlInjected.Token(Token = "0x400024D")]
	private static int PFJMECBPMNI;

	[Cpp2IlInjected.Token(Token = "0x400024E")]
	private static int DCCMIBAFIPK;

	[Cpp2IlInjected.Token(Token = "0x400024F")]
	private static int JENPLAJPBMH;

	[Cpp2IlInjected.Token(Token = "0x4000250")]
	private static int JDDOMMJAEEL;

	[Cpp2IlInjected.Token(Token = "0x4000251")]
	private static int LANPAAPGLAI;

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x70E33A0", Offset = "0x70E21A0", VA = "0x1870E33A0")]
	private ACOOIKABMPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x70E32E0", Offset = "0x70E20E0", VA = "0x1870E32E0")]
	public ACOOIKABMPL(Color OOBIDMHFNDL, Color BEADAECLGNF, Color JFJNIFAKPFH, Color? IPBGNDLIAEC, Color? IKHMDJLMDPG, Color? EBLEFNBHEAG, Texture2D JAANJLKHMPN, Texture2D OELMFMAJMKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x70E2C60", Offset = "0x70E1A60", VA = "0x1870E2C60")]
	internal int LNPCEEDAAKK(Material JHECEKMKHOO, OEFGHLPBFDF DFNLJLMBKBN, IMOIFEKEDED APMDGBOOICP, GKHPEMHLGJO DNGHOGLAIFK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x70E2BD0", Offset = "0x70E19D0", VA = "0x1870E2BD0")]
	private int LNPCEEDAAKK(JPBDKBJNHGA FFOHLCGHDKA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x70E0E10", Offset = "0x70DFC10", VA = "0x1870E0E10")]
	internal int CMMLOJDDPEO(Material JHECEKMKHOO, Color LGCDNNNCLDG, Color KIIOEENPCAA, Color HAICBLLGGMO, Color PIGPFLDELLK, Color JEEOCFHBOOG, Texture2D EBBGCPKMKOM, Vector4 IBHPDCJEKFF, Texture2D HEBFPOIOFHE, Vector4 MNMHKNJEEDO, float GIAGOKEMHFG, float MJMILDCMFEE, Texture2D NKOMLOFBIDP, Vector4 FOKJLGDPPLK, float LPPEIGPCNON, Texture2D NACBMMDFPFI, Color JJPBBDPMCFH, Vector4 DKEFAHIIJOG, OEFGHLPBFDF DFNLJLMBKBN, IMOIFEKEDED APMDGBOOICP, GKHPEMHLGJO DNGHOGLAIFK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x70E0C50", Offset = "0x70DFA50", VA = "0x1870E0C50")]
	private void BFPGHHIFKHP(List<Texture2D> KLHHJDGAPJB, [Out] Texture2DArray JMPDIDJLFPK, [Out] Texture2DArray EOFOBDPPEMF, [Out] Texture2DArray EKHEBBKJLAA, [Out] Texture2DArray NFCGBHCPGHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x70E2A80", Offset = "0x70E1880", VA = "0x1870E2A80")]
	public void JBNNMAKOALM(Shader ANADEDBFBKO, Renderer ANNHGGDABAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x70E19E0", Offset = "0x70E07E0", VA = "0x1870E19E0")]
	private void DEIPCJOLJKA(Shader ANADEDBFBKO, Renderer ANNHGGDABAO, int JKKAHFDPMBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x70E2D50", Offset = "0x70E1B50", VA = "0x1870E2D50")]
	private Color NNBFONMGDFB(Color BGLEOPHIKLM, OEFGHLPBFDF KPBHNCKKDLO)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x70E27D0", Offset = "0x70E15D0", VA = "0x1870E27D0")]
	private Color HFJLJJLDIIC(Color MHBGBAPPCNF, OEFGHLPBFDF KPBHNCKKDLO)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x70E2920", Offset = "0x70E1720", VA = "0x1870E2920")]
	private bool ICGPGJJMGJA(Texture2D LPFEFKNJCOP, IMOIFEKEDED JGBFJCBFNJC, [Out] Texture2D OPCCKEKPPOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x70E2720", Offset = "0x70E1520", VA = "0x1870E2720")]
	private void GIEMJOGMMLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x70E26E0", Offset = "0x70E14E0", VA = "0x1870E26E0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public abstract class GHDINHKOOCF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000255")]
	public readonly GKHPEMHLGJO HOODDAJBDOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000256")]
	protected bool HMBPGNALBLC;

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public bool DNEBDCHGCNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0xB4A960", Offset = "0xB49760", VA = "0x180B4A960")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0xB4BD60", Offset = "0xB4AB60", VA = "0x180B4BD60")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public bool FNJKPIBLAFA
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0xB4A970", Offset = "0xB49770", VA = "0x180B4A970")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0xB4AB30", Offset = "0xB49930", VA = "0x180B4AB30")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public virtual HFBLFLDOFLG.KLFEKKPPLNK FPOLJLMJPGA
	{
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0xA5E990", Offset = "0xA5D790", VA = "0x180A5E990", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(HFBLFLDOFLG.KLFEKKPPLNK);
		}
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0xB4CBC0", Offset = "0xB4B9C0", VA = "0x180B4CBC0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public bool OGKHCEILGCG
	{
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0xAF38A0", Offset = "0xAF26A0", VA = "0x180AF38A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public bool LALDKOAAOOE
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x1D8D690", Offset = "0x1D8C490", VA = "0x181D8D690")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public bool KHBOFAKGFBI
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x70E8330", Offset = "0x70E7130", VA = "0x1870E8330")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public bool IAPIBKKGHLD
	{
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x70E8340", Offset = "0x70E7140", VA = "0x1870E8340")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x70E8360", Offset = "0x70E7160", VA = "0x1870E8360")]
	protected GHDINHKOOCF(GKHPEMHLGJO EBFHFEGNDFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract LDHIGNIGDAL BNNGMNLBGEG(List<PGIHMBHBFKK> IFFCILHDEMJ, List<PGIHMBHBFKK> NGBNAKNINHL);

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract FMDJJFCBLGJ ODKINKMEMCC(uint DFCGNGEAOFE, AvatarSkinnedMeshBoneOrderRemapsData NPKABAIJPKA);
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class JAIGFGMOEJN : FDGLGGIAPEA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000257")]
	private AvatarSkinAssetItem KAMIDLKJPKB;

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x70E9640", Offset = "0x70E8440", VA = "0x1870E9640")]
	public JAIGFGMOEJN(AvatarSkinAssetItem MJJJHDMIAJN, AvatarSkinAssetItem.NDMAFLJFPFE KKPLLGCCHJK, GKHPEMHLGJO DNGHOGLAIFK, [Optional] PNHNCIGEODL? JIPIPBHCHPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x70E93D0", Offset = "0x70E81D0", VA = "0x1870E93D0", Slot = "6")]
	public override LDHIGNIGDAL BNNGMNLBGEG(List<PGIHMBHBFKK> IFFCILHDEMJ, List<PGIHMBHBFKK> NGBNAKNINHL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class HJPBMGBLLIP
{
	[Cpp2IlInjected.Token(Token = "0x4000258")]
	private static readonly int[] HAALFGILCNE;

	[Cpp2IlInjected.Token(Token = "0x4000259")]
	private static readonly int[] EFMJOLJNEKB;

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public static int[] BLEEGMIFOKM
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x70E8F40", Offset = "0x70E7D40", VA = "0x1870E8F40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x70E9050", Offset = "0x70E7E50", VA = "0x1870E9050")]
	public static int[] OFJKGBAMGGK(bool BEDBKNEOHOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x70E8FC0", Offset = "0x70E7DC0", VA = "0x1870E8FC0")]
	public static int MDFLJDOIJLJ(FMMANLJJECN LDIJGKNEOFF, bool BEDBKNEOHOK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x70E8FB0", Offset = "0x70E7DB0", VA = "0x1870E8FB0")]
	private static int KPLBNCGIKKH(FMMANLJJECN LDIJGKNEOFF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x70E8F90", Offset = "0x70E7D90", VA = "0x1870E8F90")]
	private static int HNFAPPFOGBM(FMMANLJJECN LDIJGKNEOFF)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class IDIIDGDAKGI
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private sealed class NCCIOMIHPCD : IEnumerator<HLGDLHCLDFE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		private HLGDLHCLDFE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		public JobHandle handle;

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		private HLGDLHCLDFE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x8F4430", Offset = "0x8F3230", VA = "0x1808F4430", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0x8F4430", Offset = "0x8F3230", VA = "0x1808F4430", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x8F7AE0", Offset = "0x8F68E0", VA = "0x1808F7AE0")]
		[DebuggerHidden]
		public NCCIOMIHPCD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x10785E0", Offset = "0x10773E0", VA = "0x1810785E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x70ECB60", Offset = "0x70EB960", VA = "0x1870ECB60", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40")]
	public static void HHHJNGMPEJA(string MIFPCBFGGLI, int DFCGNGEAOFE, long KNEGLFGAKCA, long OGOLLLBGEBK, long MIBNKEPCHOB, long OMCEPNOGAGO, long LAMFKEJHJFE, long NDBFNAJMEEB, long IPGPGOLOECM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x70E92E0", Offset = "0x70E80E0", VA = "0x1870E92E0")]
	public static CPMKHKOAIIG OMCNEPFOGAH(JobHandle LCNKGNCOMHA, bool HJEOFMKIMPL, bool DMNGMAJLIDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x70E9270", Offset = "0x70E8070", VA = "0x1870E9270")]
	[IteratorStateMachine(typeof(NCCIOMIHPCD))]
	private static IEnumerator<HLGDLHCLDFE> FKKEMGBBMNB(JobHandle IPNJAOPIHCP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class EAIFHEPLOBD
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public enum DANKOLCABNN
	{
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		General,
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		ColoredHair
	}

	[Cpp2IlInjected.Token(Token = "0x400025D")]
	public static readonly int LLMGLLAEPNK;

	[Cpp2IlInjected.Token(Token = "0x400025E")]
	public static readonly int MLAMKCMHHBF;

	[Cpp2IlInjected.Token(Token = "0x400025F")]
	public static readonly int PJPAPGKIEDG;

	[Cpp2IlInjected.Token(Token = "0x4000260")]
	public static readonly int IBKICMMCNEO;

	[Cpp2IlInjected.Token(Token = "0x4000261")]
	public static readonly int IEJGIDPCIMA;

	[Cpp2IlInjected.Token(Token = "0x4000262")]
	public static readonly int IENEBMIBCHN;

	[Cpp2IlInjected.Token(Token = "0x4000263")]
	public static readonly int OLJACNBGIMP;

	[Cpp2IlInjected.Token(Token = "0x4000264")]
	public static readonly int CLOKFBFMBCN;

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x70E73B0", Offset = "0x70E61B0", VA = "0x1870E73B0")]
	public static bool NBHBJEJKAIG(Material FAGGGCGAPOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x70E72F0", Offset = "0x70E60F0", VA = "0x1870E72F0")]
	public static bool IDKBMGHIEMN(Material FAGGGCGAPOE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public class FDGLGGIAPEA : GHDINHKOOCF
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private sealed class BLIAFOAMKAA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400026F")]
		public MEPEJIIMKOI<GameObject> skinAvatarItemPrefabHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000270")]
		public FDGLGGIAPEA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000271")]
		public Action<string> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public BLIAFOAMKAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x70E66F0", Offset = "0x70E54F0", VA = "0x1870E66F0")]
		internal void AJJEKJFBMFP(GameObject result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x70E6AC0", Offset = "0x70E58C0", VA = "0x1870E6AC0")]
		internal void MFPFFBIPBAG(string error)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000269")]
	protected AvatarSkinAssetItem NMGDKDNJJJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400026A")]
	protected Material[] OANDHNOGNEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400026B")]
	private readonly AvatarSkinAssetItem.NDMAFLJFPFE PLKDOGPICMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400026C")]
	private readonly AssetReference OLICAEBAFMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400026D")]
	private readonly PNHNCIGEODL? OGFLDBJJKGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400026E")]
	private SkinnedMeshRenderer[] MNELBDPCOLB;

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public override HFBLFLDOFLG.KLFEKKPPLNK FPOLJLMJPGA
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0xAB5DD0", Offset = "0xAB4BD0", VA = "0x180AB5DD0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(HFBLFLDOFLG.KLFEKKPPLNK);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0xB4A980", Offset = "0xB49780", VA = "0x180B4A980", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x70E7B00", Offset = "0x70E6900", VA = "0x1870E7B00")]
	public FDGLGGIAPEA(AvatarSkinAssetItem.NDMAFLJFPFE KKPLLGCCHJK, AssetReference GENCJGAFONL, Material KGJDAHPOBIJ, GKHPEMHLGJO DNGHOGLAIFK, HFBLFLDOFLG.KLFEKKPPLNK JCPICEBMIAC = (HFBLFLDOFLG.KLFEKKPPLNK)0, [Optional] PNHNCIGEODL? JIPIPBHCHPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x70E7C30", Offset = "0x70E6A30", VA = "0x1870E7C30")]
	public FDGLGGIAPEA(AvatarSkinAssetItem.NDMAFLJFPFE KKPLLGCCHJK, AssetReference GENCJGAFONL, Material KGJDAHPOBIJ, HFBLFLDOFLG.KLFEKKPPLNK JCPICEBMIAC = (HFBLFLDOFLG.KLFEKKPPLNK)0, [Optional] PNHNCIGEODL? JIPIPBHCHPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x70E75A0", Offset = "0x70E63A0", VA = "0x1870E75A0", Slot = "6")]
	public override LDHIGNIGDAL BNNGMNLBGEG(List<PGIHMBHBFKK> IFFCILHDEMJ, List<PGIHMBHBFKK> NGBNAKNINHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x70E77C0", Offset = "0x70E65C0", VA = "0x1870E77C0", Slot = "7")]
	public override FMDJJFCBLGJ ODKINKMEMCC(uint DFCGNGEAOFE, AvatarSkinnedMeshBoneOrderRemapsData NPKABAIJPKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x70E7A90", Offset = "0x70E6890", VA = "0x1870E7A90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x70E7770", Offset = "0x70E6570", VA = "0x1870E7770")]
	protected void HIIJLIJOBDO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class LLCPIIOEAKE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000272")]
	private List<int> ABBKIIIMMBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000273")]
	private List<HBPAEIMGFMD> NHGGNHBCFNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000274")]
	private HashSet<Transform> MAAKGNAHCDG;

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x70EC0B0", Offset = "0x70EAEB0", VA = "0x1870EC0B0")]
	public static LLCPIIOEAKE ECMDDBPNAPN(Transform DHJLEBFEJME, Dictionary<Transform, OutfitType?> OLFNBFKDMDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x70EC770", Offset = "0x70EB570", VA = "0x1870EC770")]
	private void NLABCAIBDBJ(Transform DHJLEBFEJME, GKHPEMHLGJO DNGHOGLAIFK, Dictionary<Transform, OutfitType?> OLFNBFKDMDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x70EC640", Offset = "0x70EB440", VA = "0x1870EC640")]
	private void MJFHKFGJGJI(Transform DGPFICEJIPC, GKHPEMHLGJO DNGHOGLAIFK, bool JKIGOKLPOII, OutfitType? BFOOEKHPMJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x70EC250", Offset = "0x70EB050", VA = "0x1870EC250")]
	public PLFINBLOOOJ MAGHOPPFGGP(HashSet<string> INHGMOLDJDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x70ECA30", Offset = "0x70EB830", VA = "0x1870ECA30")]
	public LLCPIIOEAKE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public class PLFINBLOOOJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000275")]
	private List<HBPAEIMGFMD> NHGGNHBCFNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000276")]
	private List<Matrix4x4> FNBKGLIGGFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000277")]
	private Transform[] FKPFOJMPENI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000278")]
	private Matrix4x4[] BCIOAJKCCEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000279")]
	private Dictionary<HDLHHPHDHJJ, int> FJDAMBMHKGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400027A")]
	private List<JJPGPGGALFD> DMADPMBBOAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400027B")]
	private bool AKNOMEDNFOJ;

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public int IPKHGMJKDEO
	{
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x70EDB10", Offset = "0x70EC910", VA = "0x1870EDB10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public Transform[] KGFOOPLMMCL
	{
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x70EDB50", Offset = "0x70EC950", VA = "0x1870EDB50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public Matrix4x4[] AECEDGCMACG
	{
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x70EDCC0", Offset = "0x70ECAC0", VA = "0x1870EDCC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x70EE290", Offset = "0x70ED090", VA = "0x1870EE290")]
	public void MJFHKFGJGJI(Transform DGPFICEJIPC, GKHPEMHLGJO DNGHOGLAIFK, OutfitType? BFOOEKHPMJD, bool KEGAGIDJLHO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x70EDF70", Offset = "0x70ECD70", VA = "0x1870EDF70")]
	private void MJFHKFGJGJI(Transform DGPFICEJIPC, GKHPEMHLGJO DNGHOGLAIFK, OutfitType? BFOOEKHPMJD, bool KEGAGIDJLHO, Matrix4x4 OCFPIOOJKNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x70EE490", Offset = "0x70ED290", VA = "0x1870EE490")]
	public int OHHNABGHMEI(HDLHHPHDHJJ FFOHLCGHDKA, bool LMKCPKMMMBK, [Optional] OutfitType? BFOOEKHPMJD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x70EE640", Offset = "0x70ED440", VA = "0x1870EE640")]
	public int PHFHKBGCAAM(GKHPEMHLGJO DNGHOGLAIFK, [Optional] OutfitType? BFOOEKHPMJD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x70EDD30", Offset = "0x70ECB30", VA = "0x1870EDD30")]
	public void JLNPLIKELLH(HDLHHPHDHJJ FFOHLCGHDKA, Matrix4x4 MHOAHFNOHJA, bool LMKCPKMMMBK = false, [Optional] OutfitType? BFOOEKHPMJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x70EDE20", Offset = "0x70ECC20", VA = "0x1870EDE20")]
	public Matrix4x4 LELJIFECKAJ(HDLHHPHDHJJ FFOHLCGHDKA, bool LMKCPKMMMBK, [Optional] OutfitType? BFOOEKHPMJD)
	{
		return default(Matrix4x4);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0xB56A30", Offset = "0xB55830", VA = "0x180B56A30")]
	public void HKELFLJJJHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x70EE740", Offset = "0x70ED540", VA = "0x1870EE740")]
	public PLFINBLOOOJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public struct HDLHHPHDHJJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400027F")]
	public readonly string GNDFPLEAOCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000280")]
	public readonly GKHPEMHLGJO JABAKEOGIPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000281")]
	public readonly OutfitType? EOEHFFJKMKA;

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x70E8CC0", Offset = "0x70E7AC0", VA = "0x1870E8CC0")]
	public HDLHHPHDHJJ(string DMOIKPMDPKF, GKHPEMHLGJO DNGHOGLAIFK, [Optional] OutfitType? BFOOEKHPMJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x70E8C10", Offset = "0x70E7A10", VA = "0x1870E8C10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x70E8A40", Offset = "0x70E7840", VA = "0x1870E8A40")]
	public bool DJBOHCAMMCM(HDLHHPHDHJJ LHMPMCLNOPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x70E8B00", Offset = "0x70E7900", VA = "0x1870E8B00", Slot = "0")]
	public override bool Equals(object JOOHPPHJKMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x70E8BB0", Offset = "0x70E79B0", VA = "0x1870E8BB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public struct JJPGPGGALFD : IEquatable<JJPGPGGALFD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000282")]
	public readonly GKHPEMHLGJO JABAKEOGIPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000283")]
	public readonly OutfitType? POGCGBNIDDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000284")]
	public readonly int ELNLCOANHCM;

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x70EA860", Offset = "0x70E9660", VA = "0x1870EA860")]
	public JJPGPGGALFD(GKHPEMHLGJO DNGHOGLAIFK, int PEGLJMJMDGA, [Optional] OutfitType? HOBLJKFOKHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x70EA7A0", Offset = "0x70E95A0", VA = "0x1870EA7A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x1ED9E60", Offset = "0x1ED8C60", VA = "0x181ED9E60")]
	public bool NAEJHIMJHLI(GKHPEMHLGJO DNGHOGLAIFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x70EA590", Offset = "0x70E9390", VA = "0x1870EA590")]
	public bool EBAFKCHKGEN(OutfitType? HOBLJKFOKHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x70EA700", Offset = "0x70E9500", VA = "0x1870EA700", Slot = "4")]
	public bool Equals(JJPGPGGALFD LHMPMCLNOPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x70EA610", Offset = "0x70E9410", VA = "0x1870EA610", Slot = "0")]
	public override bool Equals(object JOOHPPHJKMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x70EA750", Offset = "0x70E9550", VA = "0x1870EA750", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public struct HBPAEIMGFMD : IEquatable<HBPAEIMGFMD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000285")]
	public readonly Transform IEJIEONAAIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000286")]
	public readonly bool AICPEFNMIAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000287")]
	public readonly GKHPEMHLGJO OFHFGFOLLAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000288")]
	public readonly OutfitType? EOEHFFJKMKA;

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x70E8A00", Offset = "0x70E7800", VA = "0x1870E8A00")]
	public HBPAEIMGFMD(Transform DGPFICEJIPC, bool JKIGOKLPOII, GKHPEMHLGJO PJDKKJFJAOE, [Optional] OutfitType? KOMMCCEMOAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x70E87E0", Offset = "0x70E75E0", VA = "0x1870E87E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x70E8670", Offset = "0x70E7470", VA = "0x1870E8670", Slot = "4")]
	public bool Equals(HBPAEIMGFMD LHMPMCLNOPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x70E8590", Offset = "0x70E7390", VA = "0x1870E8590", Slot = "0")]
	public override bool Equals(object JOOHPPHJKMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x70E8770", Offset = "0x70E7570", VA = "0x1870E8770", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[ExecuteInEditMode]
	public class FitMeshHemisphereUpdater : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x4000289")]
		public const float DEFAULT_Y_POSITION_OFFSET = 0.04f;

		[Cpp2IlInjected.Token(Token = "0x400028A")]
		public const float MAX_HEMISPHERE_POSITION_OFFSET = 0.05f;

		[Cpp2IlInjected.Token(Token = "0x400028B")]
		public const float MAX_HEMISPHERE_ROTATION_OFFSET = 45f;

		[Cpp2IlInjected.Token(Token = "0x400028C")]
		public const float MAX_HEMISPHERE_SCALE = 2f;

		[Cpp2IlInjected.Token(Token = "0x400028D")]
		public const float MIN_HEMISPHERE_SCALE = 0.75f;

		[Cpp2IlInjected.Token(Token = "0x400028E")]
		public const float MAX_HEMISPHERE_RADIUS = 0.25f;

		[Cpp2IlInjected.Token(Token = "0x400028F")]
		public const float MIN_HEMISPHERE_RADIUS = 0.125f;

		[Cpp2IlInjected.Token(Token = "0x4000290")]
		public static GameObject ContainerGO;

		[Cpp2IlInjected.Token(Token = "0x4000291")]
		public static GameObject CurrentHairHemisphereGO;

		[Cpp2IlInjected.Token(Token = "0x4000292")]
		public static Transform CurrentHairHemisphereMeshTransform;

		[Cpp2IlInjected.Token(Token = "0x4000293")]
		public static FitMeshHemisphereUpdater CurrentHairHemisphereUpdater;

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x70E82C0", Offset = "0x70E70C0", VA = "0x1870E82C0")]
		public static void DespawnHairHemisphere()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40")]
		public void UpdateValues()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x8F6D30", Offset = "0x8F5B30", VA = "0x1808F6D30")]
		public FitMeshHemisphereUpdater()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public interface HHMNKHEANBM
{
	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LOAEBCFEDBN(Mesh KLMHPHDLFFG, Matrix4x4 LCFEPOMOJLK, byte[] FOKMELOPJDL, bool LAGFFBPANBA = false, HFBLFLDOFLG.KLFEKKPPLNK PHEAACMDOCI = (HFBLFLDOFLG.KLFEKKPPLNK)0, int GPPIONCBAJE = -1, bool HKHJIFBHHCF = false);

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GHMPFMCBIMC(Allocator GCNJHJPCIGN, EBGAKLBCDPI NNAIFONDPBO, byte KANGNLBMHIH, [Optional] IList<int> IFFOIOLMLOM, [Optional] IList<int> OIBGFPOHAEF);
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public readonly struct HMPJIGGJCHE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000294")]
	public readonly GameObject HNOIJEPJCGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000295")]
	private readonly AvatarItemMaterial CMEKAABGGNH;

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x956F00", Offset = "0x955D00", VA = "0x180956F00")]
	public HMPJIGGJCHE(GameObject HNOIJEPJCGK, AvatarItemMaterial CMEKAABGGNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x70E91E0", Offset = "0x70E7FE0", VA = "0x1870E91E0")]
	public void CPDCEFAODNJ(Material FAGGGCGAPOE, int NFIGLLHMKPG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public class DEOBJKPKEOH : FCDFDNMHKDC<Task<(GameObject, AvatarItemMaterial)>, HMPJIGGJCHE>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private struct FLJLHKHGMKC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400029A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		public AsyncTaskMethodBuilder<(GameObject, AvatarItemMaterial)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		public Task<GameObject> goTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		public Task<AvatarItemMaterial> materialTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		private GameObject <go>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		private TaskAwaiter<GameObject> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		private TaskAwaiter<AvatarItemMaterial> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x70E7D50", Offset = "0x70E6B50", VA = "0x1870E7D50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x70E8250", Offset = "0x70E7050", VA = "0x1870E8250", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000296")]
	private MEPEJIIMKOI<GameObject> IGLMMFACFIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000297")]
	private MEPEJIIMKOI<AvatarItemMaterial> BHEJFCNCAFE;

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x70E7260", Offset = "0x70E6060", VA = "0x1870E7260")]
	private DEOBJKPKEOH(Task<(GameObject, AvatarItemMaterial)> BDCCICFJHCL, MEPEJIIMKOI<GameObject> FNMDFLINEBM, MEPEJIIMKOI<AvatarItemMaterial> BAPOCLLEDAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x70E6D30", Offset = "0x70E5B30", VA = "0x1870E6D30")]
	public static DEOBJKPKEOH DCMOGLEGFAE(AssetReference CFFGGFCDPDN, [Optional] AssetReference EABJCJKMMMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x70E7140", Offset = "0x70E5F40", VA = "0x1870E7140", Slot = "11")]
	protected override HMPJIGGJCHE DLMJJCMNHEA(Task<(GameObject, AvatarItemMaterial)> KGALLFNGBDM)
	{
		return default(HMPJIGGJCHE);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x70E71E0", Offset = "0x70E5FE0", VA = "0x1870E71E0", Slot = "12")]
	protected override void NKDMBLAIKCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x70E6C00", Offset = "0x70E5A00", VA = "0x1870E6C00")]
	[AsyncStateMachine(typeof(FLJLHKHGMKC))]
	private static Task<(GameObject, AvatarItemMaterial)> CJCEAPDMHOA(Task<GameObject> PPKCPAOCMOA, Task<AvatarItemMaterial> DNKFDHANNNP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public static class ABBLDEELBOH
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private class BIPAEDNHNNN : FCDFDNMHKDC<Task<MaterialMapAsset>, Material[]>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		private MEPEJIIMKOI<MaterialMapAsset> IPNJAOPIHCP;

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x70E6610", Offset = "0x70E5410", VA = "0x1870E6610")]
		public BIPAEDNHNNN(MEPEJIIMKOI<MaterialMapAsset> IPNJAOPIHCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x70E6170", Offset = "0x70E4F70", VA = "0x1870E6170", Slot = "11")]
		protected override Material[] DLMJJCMNHEA(Task<MaterialMapAsset> BDCCICFJHCL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x70E65B0", Offset = "0x70E53B0", VA = "0x1870E65B0", Slot = "12")]
		protected override void NKDMBLAIKCO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	private class GNHCEBINOMF : FCDFDNMHKDC<Task<Material[]>, Material[]>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		private List<MEPEJIIMKOI<Material>> GOFFLFBJEKK;

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x70E8520", Offset = "0x70E7320", VA = "0x1870E8520")]
		public GNHCEBINOMF(Task<Material[]> BDCCICFJHCL, List<MEPEJIIMKOI<Material>> GOFFLFBJEKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x70E8390", Offset = "0x70E7190", VA = "0x1870E8390", Slot = "11")]
		protected override Material[] DLMJJCMNHEA(Task<Material[]> KGALLFNGBDM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x70E83E0", Offset = "0x70E71E0", VA = "0x1870E83E0", Slot = "12")]
		protected override void NKDMBLAIKCO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40002A2")]
	private static readonly IMOCAMGHNDM JBCGOBEIKAJ;

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x70E0790", Offset = "0x70DF590", VA = "0x1870E0790")]
	public static MEPEJIIMKOI<Material[]> DLAPBADNFPH(AssetReference[] NBMOFEBKKLN)
	{
		return null;
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[DisallowMultipleComponent]
	public class PlayerAvatarDisplayBase : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000054")]
		public enum FLKMLMEODKN
		{
			[Cpp2IlInjected.Token(Token = "0x400032C")]
			None,
			[Cpp2IlInjected.Token(Token = "0x400032D")]
			TeamItem,
			[Cpp2IlInjected.Token(Token = "0x400032E")]
			SkinColor,
			[Cpp2IlInjected.Token(Token = "0x400032F")]
			HairColor,
			[Cpp2IlInjected.Token(Token = "0x4000330")]
			BeardColor,
			[Cpp2IlInjected.Token(Token = "0x4000331")]
			UGCShirtColor
		}

		[Cpp2IlInjected.Token(Token = "0x2000055")]
		public enum BGGAMFMPBPG
		{
			[Cpp2IlInjected.Token(Token = "0x4000333")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4000334")]
			HairTexture,
			[Cpp2IlInjected.Token(Token = "0x4000335")]
			BeardTexture,
			[Cpp2IlInjected.Token(Token = "0x4000336")]
			UGCShirtTexture
		}

		[Cpp2IlInjected.Token(Token = "0x2000056")]
		public enum INNMNFODGGI : byte
		{
			[Cpp2IlInjected.Token(Token = "0x4000338")]
			All,
			[Cpp2IlInjected.Token(Token = "0x4000339")]
			LOD0Only,
			[Cpp2IlInjected.Token(Token = "0x400033A")]
			EditorToolAll
		}

		[Cpp2IlInjected.Token(Token = "0x2000057")]
		public struct IAKNHOGKPPI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400033B")]
			public readonly Material CELLCPCCNAJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400033C")]
			public readonly FLKMLMEODKN HPKEBCKCIFF;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x400033D")]
			public readonly BGGAMFMPBPG HKPJGMHJCEN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400033E")]
			public readonly GKHPEMHLGJO JABAKEOGIPH;

			[Cpp2IlInjected.Token(Token = "0x60002CB")]
			[Cpp2IlInjected.Address(RVA = "0x70EACB0", Offset = "0x70E9AB0", VA = "0x1870EACB0")]
			public IAKNHOGKPPI(Material FAGGGCGAPOE, FLKMLMEODKN DFNLJLMBKBN, BGGAMFMPBPG APMDGBOOICP, GKHPEMHLGJO DNGHOGLAIFK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002CC")]
			[Cpp2IlInjected.Address(RVA = "0x7101080", Offset = "0x70FFE80", VA = "0x187101080", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002CD")]
			[Cpp2IlInjected.Address(RVA = "0x70EA870", Offset = "0x70E9670", VA = "0x1870EA870")]
			public bool DJBOHCAMMCM(IAKNHOGKPPI LHMPMCLNOPG)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002CE")]
			[Cpp2IlInjected.Address(RVA = "0x7100EF0", Offset = "0x70FFCF0", VA = "0x187100EF0", Slot = "0")]
			public override bool Equals(object JOOHPPHJKMI)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002CF")]
			[Cpp2IlInjected.Address(RVA = "0x7100FE0", Offset = "0x70FFDE0", VA = "0x187100FE0", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000058")]
		protected struct NLLKMOOKNLH : IComparable<NLLKMOOKNLH>, IEquatable<NLLKMOOKNLH>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400033F")]
			public int AJHLMPCOLJA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000340")]
			public PlayerAvatarDisplayBase KMIKCFPGPHL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000341")]
			public IList<ONBJGLMPHMO> KKHFFBDENGB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000342")]
			public AvatarItemBodyType OIEGPBGAPDF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000343")]
			public PMOAPNPOLPO FGINALNGAHM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000344")]
			public bool AKOLPGIGBIF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000345")]
			public int[] EHMHCBIGCAB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000346")]
			public float CKBPAMIEPPI;

			[Cpp2IlInjected.Token(Token = "0x60002D0")]
			[Cpp2IlInjected.Address(RVA = "0x7102310", Offset = "0x7101110", VA = "0x187102310", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002D1")]
			[Cpp2IlInjected.Address(RVA = "0x71021B0", Offset = "0x7100FB0", VA = "0x1871021B0", Slot = "4")]
			public int CompareTo(NLLKMOOKNLH LHMPMCLNOPG)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002D2")]
			[Cpp2IlInjected.Address(RVA = "0x71021D0", Offset = "0x7100FD0", VA = "0x1871021D0", Slot = "5")]
			public bool Equals(NLLKMOOKNLH LHMPMCLNOPG)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000059")]
		protected abstract class LLPCHLCHKLP
		{
			[Cpp2IlInjected.Token(Token = "0x200005A")]
			public class FAEKICLCOPB
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400034A")]
				public readonly Mesh JHBHAOLADFM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400034B")]
				public readonly Material[] OJOCNNNJKEG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400034C")]
				public readonly Transform[] CBHIAHAPEMM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400034D")]
				public readonly Matrix4x4[] JGNPIKLAECK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x400034E")]
				public readonly Transform GNJGGCIFLNE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x400034F")]
				public readonly bool PKEIIBMMFLM;

				[Cpp2IlInjected.Token(Token = "0x60002DA")]
				[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
				protected FAEKICLCOPB()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002DB")]
				[Cpp2IlInjected.Address(RVA = "0x7100600", Offset = "0x70FF400", VA = "0x187100600")]
				public FAEKICLCOPB(Mesh KLMHPHDLFFG, Material[] DLCAJLFHGLF, bool OIPJPFAKPFD, Transform[] GFIFOBCOIKB, Transform IIGOMGGKGEG, Matrix4x4[] HDCBNFNOAFD)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002DC")]
				[Cpp2IlInjected.Address(RVA = "0x7100540", Offset = "0x70FF340", VA = "0x187100540")]
				private FAEKICLCOPB(SkinnedMeshRenderer GHMHFJNFMEI, Material[] NOMEEBDIBLG)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002DD")]
				[Cpp2IlInjected.Address(RVA = "0x7100AB0", Offset = "0x70FF8B0", VA = "0x187100AB0")]
				private FAEKICLCOPB(MeshRenderer IFPDEPBHJDD, Transform IIGOMGGKGEG, Material[] NOMEEBDIBLG)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002DE")]
				[Cpp2IlInjected.Address(RVA = "0x7100220", Offset = "0x70FF020", VA = "0x187100220")]
				public static FAEKICLCOPB AFMHONANKON(Renderer ANNHGGDABAO, Material[] NOMEEBDIBLG)
				{
					return null;
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000347")]
			public readonly GKHPEMHLGJO JABAKEOGIPH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000348")]
			public readonly Transform LBHDEONGDKD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000349")]
			public readonly bool JAECLFGHNDK;

			[Cpp2IlInjected.Token(Token = "0x17000084")]
			public virtual bool DNEBDCHGCNL
			{
				[Cpp2IlInjected.Token(Token = "0x60002D3")]
				[Cpp2IlInjected.Address(RVA = "0x93EA60", Offset = "0x93D860", VA = "0x18093EA60", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000085")]
			public virtual bool FNJKPIBLAFA
			{
				[Cpp2IlInjected.Token(Token = "0x60002D4")]
				[Cpp2IlInjected.Address(RVA = "0x93EA60", Offset = "0x93D860", VA = "0x18093EA60", Slot = "5")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000086")]
			public virtual HFBLFLDOFLG.KLFEKKPPLNK FPOLJLMJPGA
			{
				[Cpp2IlInjected.Token(Token = "0x60002D5")]
				[Cpp2IlInjected.Address(RVA = "0x8F6D50", Offset = "0x8F5B50", VA = "0x1808F6D50", Slot = "6")]
				get
				{
					return default(HFBLFLDOFLG.KLFEKKPPLNK);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000087")]
			public bool ADAAPODOPAI
			{
				[Cpp2IlInjected.Token(Token = "0x60002D6")]
				[Cpp2IlInjected.Address(RVA = "0x7101CE0", Offset = "0x7100AE0", VA = "0x187101CE0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002D7")]
			[Cpp2IlInjected.Address(RVA = "0x7101CF0", Offset = "0x7100AF0", VA = "0x187101CF0")]
			protected LLPCHLCHKLP(GKHPEMHLGJO DNGHOGLAIFK, Transform HLBKIFPBGIO, bool DDBJEBOPMHE = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D8")]
			[Cpp2IlInjected.Address(Slot = "7")]
			public abstract LDHIGNIGDAL BNNGMNLBGEG(List<PGIHMBHBFKK> IFFCILHDEMJ, List<PGIHMBHBFKK> NGBNAKNINHL);

			[Cpp2IlInjected.Token(Token = "0x60002D9")]
			[Cpp2IlInjected.Address(Slot = "8")]
			public abstract FAEKICLCOPB ODKINKMEMCC(int DFCGNGEAOFE, PlayerHandBones NABEMHOLGFN);
		}

		[Cpp2IlInjected.Token(Token = "0x200005B")]
		protected class PHNOPNPPMHC : LLPCHLCHKLP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000350")]
			protected readonly BodyPartLODs MNELBDPCOLB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000351")]
			protected readonly Material[] OANDHNOGNEL;

			[Cpp2IlInjected.Token(Token = "0x60002DF")]
			[Cpp2IlInjected.Address(RVA = "0x7105E80", Offset = "0x7104C80", VA = "0x187105E80")]
			public PHNOPNPPMHC(GKHPEMHLGJO DNGHOGLAIFK, BodyPartLODs CLPBOEIHNED, Material KGJDAHPOBIJ, [Optional] Transform HLBKIFPBGIO, bool DDBJEBOPMHE = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002E0")]
			[Cpp2IlInjected.Address(RVA = "0x7105BC0", Offset = "0x71049C0", VA = "0x187105BC0", Slot = "7")]
			public override LDHIGNIGDAL BNNGMNLBGEG(List<PGIHMBHBFKK> IFFCILHDEMJ, List<PGIHMBHBFKK> NGBNAKNINHL)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002E1")]
			[Cpp2IlInjected.Address(RVA = "0x7105C50", Offset = "0x7104A50", VA = "0x187105C50", Slot = "8")]
			public override FAEKICLCOPB ODKINKMEMCC(int DFCGNGEAOFE, PlayerHandBones NABEMHOLGFN)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002E2")]
			[Cpp2IlInjected.Address(RVA = "0x7105E10", Offset = "0x7104C10", VA = "0x187105E10", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005C")]
		protected class PBHCLOGPEIH : LLPCHLCHKLP
		{
			[Cpp2IlInjected.Token(Token = "0x17000088")]
			public override bool DNEBDCHGCNL
			{
				[Cpp2IlInjected.Token(Token = "0x60002E3")]
				[Cpp2IlInjected.Address(RVA = "0x910AD0", Offset = "0x90F8D0", VA = "0x180910AD0", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000089")]
			public override bool FNJKPIBLAFA
			{
				[Cpp2IlInjected.Token(Token = "0x60002E4")]
				[Cpp2IlInjected.Address(RVA = "0x7105A90", Offset = "0x7104890", VA = "0x187105A90", Slot = "5")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008A")]
			public EBDGGFHMAAD OAJDBJMKDOD
			{
				[Cpp2IlInjected.Token(Token = "0x60002E5")]
				[Cpp2IlInjected.Address(RVA = "0x8F41F0", Offset = "0x8F2FF0", VA = "0x1808F41F0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60002E6")]
				[Cpp2IlInjected.Address(RVA = "0x8F7B40", Offset = "0x8F6940", VA = "0x1808F7B40")]
				[CompilerGenerated]
				protected set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002E7")]
			[Cpp2IlInjected.Address(RVA = "0x7105B50", Offset = "0x7104950", VA = "0x187105B50")]
			public PBHCLOGPEIH(GKHPEMHLGJO DNGHOGLAIFK, Transform HLBKIFPBGIO, EBDGGFHMAAD IHPLBGGEMDP, bool DDBJEBOPMHE = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002E8")]
			[Cpp2IlInjected.Address(RVA = "0x7105A00", Offset = "0x7104800", VA = "0x187105A00", Slot = "7")]
			public override LDHIGNIGDAL BNNGMNLBGEG(List<PGIHMBHBFKK> IFFCILHDEMJ, List<PGIHMBHBFKK> NGBNAKNINHL)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002E9")]
			[Cpp2IlInjected.Address(RVA = "0x8F6D50", Offset = "0x8F5B50", VA = "0x1808F6D50", Slot = "8")]
			public override FAEKICLCOPB ODKINKMEMCC(int DFCGNGEAOFE, PlayerHandBones NABEMHOLGFN)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002EA")]
			[Cpp2IlInjected.Address(RVA = "0x7105AE0", Offset = "0x71048E0", VA = "0x187105AE0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005D")]
		public class EKCGIGDNEEJ
		{
			[Cpp2IlInjected.Token(Token = "0x200005E")]
			public enum DMHLCILDMBO
			{
				[Cpp2IlInjected.Token(Token = "0x4000363")]
				PLAYER_PUPPET,
				[Cpp2IlInjected.Token(Token = "0x4000364")]
				PLAYER_DISPLAY_POSER,
				[Cpp2IlInjected.Token(Token = "0x4000365")]
				PLAYER_HAND,
				[Cpp2IlInjected.Token(Token = "0x4000366")]
				STNMONSTERCOSTUME_OPTION_HIDE_EXCEPT_UI,
				[Cpp2IlInjected.Token(Token = "0x4000367")]
				PLAYER_HAND_POINTING,
				[Cpp2IlInjected.Token(Token = "0x4000368")]
				STNMONSTERCOSTUME_OPTION_ALWAYS_HIDE,
				[Cpp2IlInjected.Token(Token = "0x4000369")]
				EDITOR
			}

			[Cpp2IlInjected.Token(Token = "0x4000353")]
			public static readonly int DLCKNLCPJDE;

			[Cpp2IlInjected.Token(Token = "0x4000354")]
			public static readonly int OOBFJHLEPFN;

			[Cpp2IlInjected.Token(Token = "0x4000355")]
			public static readonly int FPHJMKGHKDG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000356")]
			protected readonly MHJFMIKGCOJ AOMFNDPKIJK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000357")]
			protected readonly LJINGEFMHFC DDBJLPAODGP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000358")]
			protected readonly Animator MLAJJALHBID;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000359")]
			protected readonly Transform FELKNOFNKKJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400035A")]
			protected readonly Vector3 NINHJBMKGOB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400035B")]
			protected readonly Transform EJLCFGDCNKN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400035C")]
			protected readonly Vector3 LKCHKFNLHEB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x400035D")]
			protected bool MIBFKHOKPGK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400035E")]
			protected CNGDBOGKMMI GOHJHNNDABA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400035F")]
			protected bool CBCNCOKECNN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
			[Cpp2IlInjected.Token(Token = "0x4000360")]
			protected float DOENPGHBILB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000361")]
			protected DICKEMDLJAF<LFOHJBFCKOA> ANNAHDDPCEE;

			[Cpp2IlInjected.Token(Token = "0x1700008B")]
			public CNGDBOGKMMI OJFHNBININH
			{
				[Cpp2IlInjected.Token(Token = "0x60002EB")]
				[Cpp2IlInjected.Address(RVA = "0x8F4260", Offset = "0x8F3060", VA = "0x1808F4260")]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60002EC")]
				[Cpp2IlInjected.Address(RVA = "0x8F4470", Offset = "0x8F3270", VA = "0x1808F4470")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008C")]
			public bool PMKPJDBLJGP
			{
				[Cpp2IlInjected.Token(Token = "0x60002ED")]
				[Cpp2IlInjected.Address(RVA = "0xAACE40", Offset = "0xAABC40", VA = "0x180AACE40")]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x60002EE")]
				[Cpp2IlInjected.Address(RVA = "0x70FF2E0", Offset = "0x70FE0E0", VA = "0x1870FF2E0")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008D")]
			public bool EFFDNKPEHNO
			{
				[Cpp2IlInjected.Token(Token = "0x60002EF")]
				[Cpp2IlInjected.Address(RVA = "0x8F4200", Offset = "0x8F3000", VA = "0x1808F4200")]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x60002F0")]
				[Cpp2IlInjected.Address(RVA = "0x70FF400", Offset = "0x70FE200", VA = "0x1870FF400")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008E")]
			public float IKJFLIPMCJA
			{
				[Cpp2IlInjected.Token(Token = "0x60002F1")]
				[Cpp2IlInjected.Address(RVA = "0xB4AB10", Offset = "0xB49910", VA = "0x180B4AB10")]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x60002F2")]
				[Cpp2IlInjected.Address(RVA = "0x70FE9E0", Offset = "0x70FD7E0", VA = "0x1870FE9E0")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008F")]
			public LFOHJBFCKOA OFONGFOIIBC
			{
				[Cpp2IlInjected.Token(Token = "0x60002F3")]
				[Cpp2IlInjected.Address(RVA = "0x70FF2A0", Offset = "0x70FE0A0", VA = "0x1870FF2A0")]
				get
				{
					return default(LFOHJBFCKOA);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002F4")]
			[Cpp2IlInjected.Address(RVA = "0x70FEDA0", Offset = "0x70FDBA0", VA = "0x1870FEDA0")]
			public bool JGNNOKIOHEM(LFOHJBFCKOA ICPKLHBNKNO, object HACFGBHNOCC, DMHLCILDMBO JHPBGABBKOP)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002F5")]
			[Cpp2IlInjected.Address(RVA = "0x70FF4D0", Offset = "0x70FE2D0", VA = "0x1870FF4D0")]
			public bool PGLLKDNJHPJ(object HACFGBHNOCC)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002F6")]
			[Cpp2IlInjected.Address(RVA = "0x70FF680", Offset = "0x70FE480", VA = "0x1870FF680")]
			protected EKCGIGDNEEJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F7")]
			[Cpp2IlInjected.Address(RVA = "0x70FF710", Offset = "0x70FE510", VA = "0x1870FF710")]
			public EKCGIGDNEEJ(MHJFMIKGCOJ AOMFNDPKIJK, CNGDBOGKMMI CFKFFBGOOEM, Animator MLAJJALHBID, Transform FELKNOFNKKJ, Transform EJLCFGDCNKN, Vector3 NINHJBMKGOB, Vector3 LKCHKFNLHEB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F8")]
			[Cpp2IlInjected.Address(RVA = "0x70FEEB0", Offset = "0x70FDCB0", VA = "0x1870FEEB0")]
			private void JJABGCPKNLN(ushort GHJLAACNMGK, ushort GFNEKIIPCPM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002F9")]
			[Cpp2IlInjected.Address(RVA = "0x70FF1B0", Offset = "0x70FDFB0", VA = "0x1870FF1B0")]
			protected void KLOIFJIPPFJ(ushort GHJLAACNMGK, ushort GFNEKIIPCPM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002FA")]
			[Cpp2IlInjected.Address(RVA = "0x70FEB70", Offset = "0x70FD970", VA = "0x1870FEB70")]
			protected void CPHEEGJMBOP(ushort GHJLAACNMGK, ushort GFNEKIIPCPM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002FB")]
			[Cpp2IlInjected.Address(RVA = "0x70FF080", Offset = "0x70FDE80", VA = "0x1870FF080")]
			protected void KEGMLIJOJCH(ushort GHJLAACNMGK, ushort GFNEKIIPCPM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002FC")]
			[Cpp2IlInjected.Address(RVA = "0x70FEC90", Offset = "0x70FDA90", VA = "0x1870FEC90")]
			protected void GPDCOPIPLOL(ushort GHJLAACNMGK, ushort GFNEKIIPCPM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002FD")]
			[Cpp2IlInjected.Address(RVA = "0x70FEC30", Offset = "0x70FDA30", VA = "0x1870FEC30")]
			protected void FDBKILCDDFD(ushort GHJLAACNMGK, ushort GFNEKIIPCPM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002FE")]
			[Cpp2IlInjected.Address(RVA = "0x70FEB20", Offset = "0x70FD920", VA = "0x1870FEB20")]
			protected void CNKFKCHJAPD(ushort GHJLAACNMGK, ushort GFNEKIIPCPM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002FF")]
			[Cpp2IlInjected.Address(RVA = "0x70FF3B0", Offset = "0x70FE1B0", VA = "0x1870FF3B0")]
			protected void OKFPDBIJEKI(ushort GHJLAACNMGK, ushort GFNEKIIPCPM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000300")]
			[Cpp2IlInjected.Address(RVA = "0x70FEF60", Offset = "0x70FDD60", VA = "0x1870FEF60")]
			protected void KABAENJIDFC(ushort GHJLAACNMGK, ushort GFNEKIIPCPM)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005F")]
		public class OKFDGGBIMNI : IDisposable
		{
			[Cpp2IlInjected.Token(Token = "0x400036A")]
			public const int HPHMLKFIKCA = 16;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400036B")]
			protected MaterialPropertyBlock NHOAJODAIGD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400036C")]
			public Color? KAOCJKEHIAF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x400036D")]
			public Color? CEILMDAIBPO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400036E")]
			public Color? BAGAEHJIAPH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x400036F")]
			public Color BHDLCDDMMIA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
			[Cpp2IlInjected.Token(Token = "0x4000370")]
			public Color AEOOOLHGBAA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
			[Cpp2IlInjected.Token(Token = "0x4000371")]
			public Color PDPFGKNENFI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x4000372")]
			public Texture2D AMLIHCDHJLI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x4000373")]
			public Texture2D ENAJBDEAHEE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x4000374")]
			protected Dictionary<IAKNHOGKPPI, int> APNEFLENEEN;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x4000375")]
			protected FLKMLMEODKN[] LIJDHBFNLPF;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x4000376")]
			public Vector4[] DDNLCJGDCMK;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x4000377")]
			public Vector4[] GLEKNGHGKLL;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x4000378")]
			public Vector4[] MENFGBEAPAG;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x4000379")]
			public Vector4[] DBGOHBNJHJK;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
			[Cpp2IlInjected.Token(Token = "0x400037A")]
			public Vector4[] HMDBPHPBOPK;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
			[Cpp2IlInjected.Token(Token = "0x400037B")]
			public Vector4[] IOGCJOEKOHH;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x400037C")]
			protected List<Texture2D> KLHHJDGAPJB;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x400037D")]
			protected Vector4[] DLNLCABNMBE;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
			[Cpp2IlInjected.Token(Token = "0x400037E")]
			protected List<Texture2D> MFBGEGAFNOE;

			[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
			[Cpp2IlInjected.Token(Token = "0x400037F")]
			protected float[] MFLELHBIHID;

			[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
			[Cpp2IlInjected.Token(Token = "0x4000380")]
			protected Vector4[] BOIKKIBGNCF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
			[Cpp2IlInjected.Token(Token = "0x4000381")]
			protected float[] BLNCNLJCNIH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
			[Cpp2IlInjected.Token(Token = "0x4000382")]
			public float[] EAEDCPAHILA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
			[Cpp2IlInjected.Token(Token = "0x4000383")]
			protected List<Texture2D> DBIMLCDNIKC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
			[Cpp2IlInjected.Token(Token = "0x4000384")]
			protected float[] DFBEMDPHDAI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
			[Cpp2IlInjected.Token(Token = "0x4000385")]
			protected List<Texture2D> AGKEIANAMKB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
			[Cpp2IlInjected.Token(Token = "0x4000386")]
			protected Vector4[] GFLOMDGIELD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
			[Cpp2IlInjected.Token(Token = "0x4000387")]
			protected float[] JMEMOLBLMNL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
			[Cpp2IlInjected.Token(Token = "0x4000388")]
			protected Vector4[] LMIMKJLBFDI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
			[Cpp2IlInjected.Token(Token = "0x4000389")]
			public float[] PIKFBLGFDNI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
			[Cpp2IlInjected.Token(Token = "0x400038A")]
			public Texture2DArray CPDODKFMJAM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
			[Cpp2IlInjected.Token(Token = "0x400038B")]
			public Texture2DArray NGHGONLMILB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
			[Cpp2IlInjected.Token(Token = "0x400038C")]
			public Texture2DArray LOMEJOGGMBA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
			[Cpp2IlInjected.Token(Token = "0x400038D")]
			public Texture2DArray HONPEIFOOGE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
			[Cpp2IlInjected.Token(Token = "0x400038E")]
			protected bool LFDDEPHLGIB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x16C")]
			[Cpp2IlInjected.Token(Token = "0x400038F")]
			protected int KOKGHJFBEKF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
			[Cpp2IlInjected.Token(Token = "0x4000390")]
			protected Vector2? LAJNNJCAMJL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x17C")]
			[Cpp2IlInjected.Token(Token = "0x4000391")]
			protected TextureFormat KLDJFJCNJGH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
			[Cpp2IlInjected.Token(Token = "0x4000392")]
			protected Vector2? NAFPPDDMNPF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18C")]
			[Cpp2IlInjected.Token(Token = "0x4000393")]
			protected TextureFormat OOFGBMKOCDI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
			[Cpp2IlInjected.Token(Token = "0x4000394")]
			protected Vector2? OEIMJFKIMAA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x19C")]
			[Cpp2IlInjected.Token(Token = "0x4000395")]
			protected TextureFormat FPPIFEECMKN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
			[Cpp2IlInjected.Token(Token = "0x4000396")]
			protected Vector2? FLHOPPOBOMF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1AC")]
			[Cpp2IlInjected.Token(Token = "0x4000397")]
			protected TextureFormat OKBBIJHHECJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
			[Cpp2IlInjected.Token(Token = "0x4000398")]
			protected bool EICHBLDJPCE;

			[Cpp2IlInjected.Token(Token = "0x4000399")]
			protected static int NEDJIGEEMHG;

			[Cpp2IlInjected.Token(Token = "0x400039A")]
			protected static int ADCFJOCEOAE;

			[Cpp2IlInjected.Token(Token = "0x400039B")]
			protected static int OPFEKNBAFFK;

			[Cpp2IlInjected.Token(Token = "0x400039C")]
			protected static int MHDPCKEFKAF;

			[Cpp2IlInjected.Token(Token = "0x400039D")]
			protected static int NBHKAMEKGKD;

			[Cpp2IlInjected.Token(Token = "0x400039E")]
			protected static int COACPAKBIKI;

			[Cpp2IlInjected.Token(Token = "0x400039F")]
			protected static int INEPIIOAJPI;

			[Cpp2IlInjected.Token(Token = "0x40003A0")]
			protected static int IADFDPGCLHA;

			[Cpp2IlInjected.Token(Token = "0x40003A1")]
			protected static int EDOINPJPDBN;

			[Cpp2IlInjected.Token(Token = "0x40003A2")]
			protected static int LHIHCNMNBOD;

			[Cpp2IlInjected.Token(Token = "0x40003A3")]
			protected static int AFIIGGEBJKI;

			[Cpp2IlInjected.Token(Token = "0x40003A4")]
			protected static int DHIPOAEPFGN;

			[Cpp2IlInjected.Token(Token = "0x40003A5")]
			protected static int HGKAINLDPBJ;

			[Cpp2IlInjected.Token(Token = "0x40003A6")]
			protected static int CNBEAGEBCEA;

			[Cpp2IlInjected.Token(Token = "0x40003A7")]
			protected static int APLHDMPNKPP;

			[Cpp2IlInjected.Token(Token = "0x40003A8")]
			protected static int PFJMECBPMNI;

			[Cpp2IlInjected.Token(Token = "0x40003A9")]
			protected static int DCCMIBAFIPK;

			[Cpp2IlInjected.Token(Token = "0x40003AA")]
			protected static int JENPLAJPBMH;

			[Cpp2IlInjected.Token(Token = "0x40003AB")]
			protected static int JDDOMMJAEEL;

			[Cpp2IlInjected.Token(Token = "0x40003AC")]
			protected static int LANPAAPGLAI;

			[Cpp2IlInjected.Token(Token = "0x6000302")]
			[Cpp2IlInjected.Address(RVA = "0x7104A70", Offset = "0x7103870", VA = "0x187104A70")]
			protected OKFDGGBIMNI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000303")]
			[Cpp2IlInjected.Address(RVA = "0x71049E0", Offset = "0x71037E0", VA = "0x1871049E0")]
			public OKFDGGBIMNI(Color OOBIDMHFNDL, Color BEADAECLGNF, Color JFJNIFAKPFH, Color? IPBGNDLIAEC, Color? IKHMDJLMDPG, Color? EBLEFNBHEAG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000304")]
			[Cpp2IlInjected.Address(RVA = "0x7104220", Offset = "0x7103020", VA = "0x187104220")]
			public int LNPCEEDAAKK(Material JHECEKMKHOO, FLKMLMEODKN DFNLJLMBKBN, BGGAMFMPBPG APMDGBOOICP, GKHPEMHLGJO DNGHOGLAIFK)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000305")]
			[Cpp2IlInjected.Address(RVA = "0x7104190", Offset = "0x7102F90", VA = "0x187104190")]
			public int LNPCEEDAAKK(IAKNHOGKPPI FFOHLCGHDKA)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000306")]
			[Cpp2IlInjected.Address(RVA = "0x7102620", Offset = "0x7101420", VA = "0x187102620")]
			public int CMMLOJDDPEO(Material JHECEKMKHOO, Color LGCDNNNCLDG, Color KIIOEENPCAA, Color HAICBLLGGMO, Color PIGPFLDELLK, Color JEEOCFHBOOG, Texture2D EBBGCPKMKOM, Vector4 IBHPDCJEKFF, Texture2D HEBFPOIOFHE, Vector4 MNMHKNJEEDO, float GIAGOKEMHFG, float MJMILDCMFEE, Texture2D NKOMLOFBIDP, Vector4 FOKJLGDPPLK, float LPPEIGPCNON, Texture2D NACBMMDFPFI, float ILPGCLIFFNL, Color JJPBBDPMCFH, Vector4 DKEFAHIIJOG, FLKMLMEODKN DFNLJLMBKBN, BGGAMFMPBPG APMDGBOOICP, GKHPEMHLGJO DNGHOGLAIFK)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000307")]
			[Cpp2IlInjected.Address(RVA = "0x7102460", Offset = "0x7101260", VA = "0x187102460")]
			protected void BFPGHHIFKHP([Out] Texture2DArray JMPDIDJLFPK, [Out] Texture2DArray EOFOBDPPEMF, [Out] Texture2DArray EKHEBBKJLAA, [Out] Texture2DArray NFCGBHCPGHN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000308")]
			[Cpp2IlInjected.Address(RVA = "0x7103F20", Offset = "0x7102D20", VA = "0x187103F20")]
			public void JBNNMAKOALM(PlayerAvatarDisplayBase OENPCNCMCMG, Renderer ANNHGGDABAO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000309")]
			[Cpp2IlInjected.Address(RVA = "0x7103320", Offset = "0x7102120", VA = "0x187103320")]
			protected void DEIPCJOLJKA(PlayerAvatarDisplayBase OENPCNCMCMG, Renderer ANNHGGDABAO, int JKKAHFDPMBL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600030A")]
			[Cpp2IlInjected.Address(RVA = "0x7104460", Offset = "0x7103260", VA = "0x187104460")]
			private Color NNBFONMGDFB(Color BGLEOPHIKLM, FLKMLMEODKN KPBHNCKKDLO)
			{
				return default(Color);
			}

			[Cpp2IlInjected.Token(Token = "0x600030B")]
			[Cpp2IlInjected.Address(RVA = "0x7104310", Offset = "0x7103110", VA = "0x187104310")]
			private Color LOJBGPOEOKO(Color IDELEKLHOFM, FLKMLMEODKN KPBHNCKKDLO)
			{
				return default(Color);
			}

			[Cpp2IlInjected.Token(Token = "0x600030C")]
			[Cpp2IlInjected.Address(RVA = "0x7103E90", Offset = "0x7102C90", VA = "0x187103E90")]
			protected void GIEMJOGMMLH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600030D")]
			[Cpp2IlInjected.Address(RVA = "0x7103E50", Offset = "0x7102C50", VA = "0x187103E50", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000060")]
		public struct PlayerHandBones
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003AD")]
			public Transform[] LeftHandBones;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003AE")]
			public Transform LeftHandRoot;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003AF")]
			public Transform[] RightHandBones;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003B0")]
			public Transform RightHandRoot;

			[Cpp2IlInjected.Token(Token = "0x600030F")]
			[Cpp2IlInjected.Address(RVA = "0x710BF60", Offset = "0x710AD60", VA = "0x18710BF60")]
			public void LMEPKHIMHMG(GKHPEMHLGJO DNGHOGLAIFK, [Out] Transform DOJENPPADJD, [Out] Transform[] GFIFOBCOIKB)
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000061")]
		protected struct BodyPartLODs
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003B1")]
			public Mesh[] LODs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003B2")]
			public bool UseHandBones;
		}

		[Cpp2IlInjected.Token(Token = "0x2000063")]
		[CompilerGenerated]
		private sealed class GKIANGBLPBL : IEnumerable<SkinnedMeshRenderer>, IEnumerable, IEnumerator<SkinnedMeshRenderer>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003BA")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003BB")]
			private SkinnedMeshRenderer <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003BC")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003BD")]
			public PlayerAvatarDisplayBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003BE")]
			private SkinnedMeshRenderer[] <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003BF")]
			private int <>7__wrap2;

			[Cpp2IlInjected.Token(Token = "0x17000090")]
			SkinnedMeshRenderer IEnumerator<SkinnedMeshRenderer>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600031B")]
				[Cpp2IlInjected.Address(RVA = "0x8F4430", Offset = "0x8F3230", VA = "0x1808F4430", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000091")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600031D")]
				[Cpp2IlInjected.Address(RVA = "0x8F4430", Offset = "0x8F3230", VA = "0x1808F4430", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000318")]
			[Cpp2IlInjected.Address(RVA = "0xC3B4C0", Offset = "0xC3A2C0", VA = "0x180C3B4C0")]
			[DebuggerHidden]
			public GKIANGBLPBL(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000319")]
			[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600031A")]
			[Cpp2IlInjected.Address(RVA = "0x7100C20", Offset = "0x70FFA20", VA = "0x187100C20", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600031C")]
			[Cpp2IlInjected.Address(RVA = "0x7100EA0", Offset = "0x70FFCA0", VA = "0x187100EA0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600031E")]
			[Cpp2IlInjected.Address(RVA = "0x7100DF0", Offset = "0x70FFBF0", VA = "0x187100DF0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<SkinnedMeshRenderer> IEnumerable<SkinnedMeshRenderer>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600031F")]
			[Cpp2IlInjected.Address(RVA = "0x7100DF0", Offset = "0x70FFBF0", VA = "0x187100DF0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000064")]
		[CompilerGenerated]
		private sealed class EEIAKBNBHAK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003C0")]
			public PlayerAvatarDisplayBase display;

			[Cpp2IlInjected.Token(Token = "0x6000320")]
			[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
			public EEIAKBNBHAK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000321")]
			[Cpp2IlInjected.Address(RVA = "0x70FE900", Offset = "0x70FD700", VA = "0x1870FE900")]
			internal bool PPAFFGINKDM()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000065")]
		[CompilerGenerated]
		private sealed class ONBKHOBMPKC : IEnumerator<HLGDLHCLDFE>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003C1")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003C2")]
			private HLGDLHCLDFE <>2__current;

			[Cpp2IlInjected.Token(Token = "0x17000092")]
			private HLGDLHCLDFE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000325")]
				[Cpp2IlInjected.Address(RVA = "0x8F4430", Offset = "0x8F3230", VA = "0x1808F4430", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000093")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000327")]
				[Cpp2IlInjected.Address(RVA = "0x8F4430", Offset = "0x8F3230", VA = "0x1808F4430", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000322")]
			[Cpp2IlInjected.Address(RVA = "0x8F7AE0", Offset = "0x8F68E0", VA = "0x1808F7AE0")]
			[DebuggerHidden]
			public ONBKHOBMPKC(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000323")]
			[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000324")]
			[Cpp2IlInjected.Address(RVA = "0x71055D0", Offset = "0x71043D0", VA = "0x1871055D0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000326")]
			[Cpp2IlInjected.Address(RVA = "0x71059B0", Offset = "0x71047B0", VA = "0x1871059B0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000066")]
		[CompilerGenerated]
		private struct CMEPOOLJFOK : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003C3")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003C4")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003C5")]
			public PlayerAvatarDisplayBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003C6")]
			public IICGJDJAKCL avatarData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003C7")]
			private bool <forceRebuild>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003C8")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000328")]
			[Cpp2IlInjected.Address(RVA = "0x70FDE00", Offset = "0x70FCC00", VA = "0x1870FDE00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000329")]
			[Cpp2IlInjected.Address(RVA = "0x70FE5B0", Offset = "0x70FD3B0", VA = "0x1870FE5B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000067")]
		[CompilerGenerated]
		private sealed class JPCOAAEANJP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003C9")]
			public string overrideIdentifier;

			[Cpp2IlInjected.Token(Token = "0x600032A")]
			[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
			public JPCOAAEANJP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600032B")]
			[Cpp2IlInjected.Address(RVA = "0x7101C00", Offset = "0x7100A00", VA = "0x187101C00")]
			internal bool FDKOMLOFIDC(ONBJGLMPHMO selection)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000068")]
		[CompilerGenerated]
		private sealed class CAAAMEFLEAC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003CA")]
			public PlayerAvatarDisplayBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003CB")]
			public AvatarItemBodyType avatarItemBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003CC")]
			public Func<MNHDJBCOCND<Dictionary<string, MEPEJIIMKOI<Texture2D>>>> <>9__2;

			[Cpp2IlInjected.Token(Token = "0x600032C")]
			[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
			public CAAAMEFLEAC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600032D")]
			[Cpp2IlInjected.Address(RVA = "0x70FDC10", Offset = "0x70FCA10", VA = "0x1870FDC10")]
			internal (NAEGINDHOLH, MNHDJBCOCND<Dictionary<string, MEPEJIIMKOI<Texture2D>>>) OEDBBEIGNAO(Dictionary<string, EPEMMDIFGGB> avatarItems)
			{
				return default((NAEGINDHOLH, MNHDJBCOCND<Dictionary<string, MEPEJIIMKOI<Texture2D>>>));
			}

			[Cpp2IlInjected.Token(Token = "0x600032E")]
			[Cpp2IlInjected.Address(RVA = "0x70FDB60", Offset = "0x70FC960", VA = "0x1870FDB60")]
			internal MNHDJBCOCND<Dictionary<string, MEPEJIIMKOI<Texture2D>>> LPOOGFMPKEN()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600032F")]
			[Cpp2IlInjected.Address(RVA = "0x70FDBD0", Offset = "0x70FC9D0", VA = "0x1870FDBD0")]
			internal void NPFPHJLOFPG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000069")]
		[CompilerGenerated]
		private sealed class LEOJGIEKEPC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003CD")]
			public Transform transformToCheck;

			[Cpp2IlInjected.Token(Token = "0x6000330")]
			[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
			public LEOJGIEKEPC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000331")]
			[Cpp2IlInjected.Address(RVA = "0x7101C30", Offset = "0x7100A30", VA = "0x187101C30")]
			internal bool BCBJFOAGBEJ(SkinnedMeshRenderer x)
			{
				return default(bool);
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200006A")]
		[CompilerGenerated]
		private struct MHJAAIJLPMO : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003CE")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003CF")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003D0")]
			public PlayerAvatarDisplayBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003D1")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000332")]
			[Cpp2IlInjected.Address(RVA = "0x7101D50", Offset = "0x7100B50", VA = "0x187101D50", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000333")]
			[Cpp2IlInjected.Address(RVA = "0x7101F20", Offset = "0x7100D20", VA = "0x187101F20", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		protected static readonly int CEPGPGPMKCE;

		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		protected static readonly int PFHMPOABJMI;

		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		protected static readonly int MMCKOOGCBGE;

		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		protected static readonly int EEOEBCNCKLL;

		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		protected static readonly int ADFNJMDFIKC;

		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		protected static readonly int PLOHCEOOKLH;

		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		protected static readonly int[] OEFHDCIKAFP;

		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		protected static readonly int[] FPCACGEFMEG;

		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		protected static readonly int[] CMLOPGLKOAM;

		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		protected static readonly int[] NEGGJPPDFEN;

		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		protected static readonly int[] FHCCPFNLPGD;

		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		protected static readonly int[] GBKNHOJFFDD;

		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		protected static List<PlayerAvatarDisplayBase> HCDPCOIFJJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		protected IOLJGGGKDHL BHIHPHMDGPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		protected bool GDPJHHJHODM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		protected bool LNGABLLINFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		[SerializeField]
		public AvatarBodyShapeVault BodyShapeVault;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		[SerializeField]
		public AvatarFaceShapeVault FaceShapeVault;

		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		protected static readonly int[] CMMMOHKMICP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		[SerializeField]
		protected Material bodyPartMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		protected Dictionary<IAKNHOGKPPI, Material> HFKNHMOHKFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		protected Dictionary<IAKNHOGKPPI, Material> IIDMDNHEFIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		[SerializeField]
		protected bool ignorePlayerMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		[SerializeField]
		protected Transform trackingSpace;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		[SerializeField]
		protected BodyPartLODs Head;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		[SerializeField]
		protected BodyPartLODs Ear;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		[SerializeField]
		protected BodyPartLODs Torso;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		[SerializeField]
		protected BodyPartLODs Hand;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		[SerializeField]
		protected BodyPartLODs HandPointing;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		[SerializeField]
		public PlayerHandBones HandBones;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		[SerializeField]
		public Transform remoteMeshBase;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		public readonly SkinnedMeshRenderer[] CurrentDefaultSkinnedMeshRenderers;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		public readonly SkinnedMeshRenderer[] NextDefaultSkinnedMeshRenderers;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		public readonly SkinnedMeshRenderer[] CurrentVisibleInFirstPersonSkinnedMeshRenderers;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		public readonly SkinnedMeshRenderer[] NextVisibleInFirstPersonSkinnedMeshRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		[SerializeField]
		public Transform firstPersonMeshBase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		[SerializeField]
		protected Shader uberShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		[SerializeField]
		protected Shader agAvatarShader;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		protected Material IGKJJBCNIGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		protected PHGIHCICACD OFKOPADJKNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		private CNGDBOGKMMI PAGFBDONEBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		private CNGDBOGKMMI MFHONPEBPPI;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		protected Material PAHJPEIGENP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		[SerializeField]
		protected Transform headPropAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		[SerializeField]
		protected Transform hatAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		[SerializeField]
		public Transform hemisphereBase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		protected FitMeshHemisphere DELGPIOABHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		protected bool CEGGPCLMGNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		protected PACDKMEJBDN HEEDCEFGPEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		protected bool NFGCCGEMGHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		protected AnchorParamsRestrictions GEFACINDGLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		protected bool JOPBPIACBJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		protected Transform GOBOLECKGOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		protected bool FJCKLGCLEPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x199")]
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		protected bool ACJEENPJJDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19C")]
		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		protected Vector3 IINDFCGGADL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		protected Quaternion CPFBLMNLPMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		protected Vector2 OPAKKCOBPFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		protected FitMeshHemisphere NHKECJILAEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		[SerializeField]
		[EECICDBJENE(ADIKDNKOEBP.SelfAndChildren, false, false, false)]
		protected PlayerFacialAnimatorBase facialAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		[SerializeField]
		protected Transform torsoPropAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		[SerializeField]
		protected Transform torsoRootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		[SerializeField]
		protected Transform headRootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		[SerializeField]
		protected Transform leftHandRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		[SerializeField]
		protected Transform leftHandDefaultScaleRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		[SerializeField]
		protected Transform rightHandRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		[SerializeField]
		protected Transform rightHandDefaultScaleRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		[SerializeField]
		protected Animator leftHandAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		[SerializeField]
		protected Animator rightHandAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		[SerializeField]
		protected Transform leftHandPointingRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		[SerializeField]
		protected Transform rightHandPointingRoot;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		protected Collider[] MAIJLJFPJHO;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		protected Collider[] DGCDLLHNJLP;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		protected EKCGIGDNEEJ[] GHODDNPMKNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		[SerializeField]
		protected Mesh faceMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		public Dictionary<Renderer, OKFDGGBIMNI> currentPropertyBlocks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		protected Dictionary<Renderer, OKFDGGBIMNI> HJBDCDNGGEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		protected LLCPIIOEAKE MOKGCLCJFOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		protected NAEGINDHOLH KECFNNACIDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		public FMMANLJJECN DistanceBand;

		[Cpp2IlInjected.FieldOffset(Offset = "0x26C")]
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		protected int JBBKFOCKAOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		protected DICKEMDLJAF<LJINGEFMHFC> ANNAHDDPCEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x4000300")]
		protected bool PKBDNPDDDLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
		[Cpp2IlInjected.Token(Token = "0x4000302")]
		protected Dictionary<ONBJGLMPHMO, List<IAKNHOGKPPI>> HIGECKFCCMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		protected Dictionary<ONBJGLMPHMO, List<IAKNHOGKPPI>> HCEMKPLHOFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		protected readonly Dictionary<string, MEPEJIIMKOI<Texture2D>> FALHOGBEKHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		protected readonly Dictionary<string, MEPEJIIMKOI<Texture2D>> PPOBODPKNME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		protected bool MPHHNOHLAJF;

		[Cpp2IlInjected.Token(Token = "0x4000308")]
		protected static int NOJBNNOIJED;

		[Cpp2IlInjected.Token(Token = "0x4000309")]
		protected static List<NLLKMOOKNLH> JDDIGDFICMF;

		[Cpp2IlInjected.Token(Token = "0x400030A")]
		protected static List<NLLKMOOKNLH> EDANOLDCLDD;

		[Cpp2IlInjected.Token(Token = "0x400030B")]
		protected static CPMKHKOAIIG MPMHCNIKMOM;

		[Cpp2IlInjected.Token(Token = "0x400030C")]
		protected static bool JMJIBCKHAIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B0")]
		[Cpp2IlInjected.Token(Token = "0x400030D")]
		protected Color? EPFMFKGMOPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C4")]
		[Cpp2IlInjected.Token(Token = "0x400030E")]
		protected bool GCHFJENADLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
		[Cpp2IlInjected.Token(Token = "0x400030F")]
		protected Color ALNCDFPILAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D8")]
		[Cpp2IlInjected.Token(Token = "0x4000310")]
		protected Color KLGKLEKNICO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E8")]
		[Cpp2IlInjected.Token(Token = "0x4000311")]
		protected Color LGIEJOIIGIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2F8")]
		[Cpp2IlInjected.Token(Token = "0x4000312")]
		protected AvatarHairPattern KDDKMCFDOHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x300")]
		[Cpp2IlInjected.Token(Token = "0x4000313")]
		protected EBDGGFHMAAD BBHONBEOGPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x308")]
		[Cpp2IlInjected.Token(Token = "0x4000314")]
		protected Color DKMMMANNHMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x318")]
		[Cpp2IlInjected.Token(Token = "0x4000315")]
		protected Color DMFHNOMMKCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x328")]
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		protected AvatarHairPattern PKJLDIAOOLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x330")]
		[Cpp2IlInjected.Token(Token = "0x4000317")]
		protected EBDGGFHMAAD FKOMDBBKOJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x338")]
		[Cpp2IlInjected.Token(Token = "0x4000318")]
		protected EBDGGFHMAAD JHPFIHCBLKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x340")]
		[Cpp2IlInjected.Token(Token = "0x4000319")]
		protected Color JGCKMBPOHDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x350")]
		[Cpp2IlInjected.Token(Token = "0x400031A")]
		private AdditionalFeetData KLJMJJJOPKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x358")]
		[Cpp2IlInjected.Token(Token = "0x400031B")]
		protected ONBJGLMPHMO? OGEBFLKFIOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x370")]
		[Cpp2IlInjected.Token(Token = "0x400031C")]
		protected Texture LLLBJCNJPPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x378")]
		[Cpp2IlInjected.Token(Token = "0x400031D")]
		protected Color CDJKALCPNIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x388")]
		[Cpp2IlInjected.Token(Token = "0x400031E")]
		protected readonly IList<ONBJGLMPHMO> FKLCIABGINF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x390")]
		[Cpp2IlInjected.Token(Token = "0x400031F")]
		protected readonly IList<ONBJGLMPHMO> LGFHGHFHNHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x398")]
		[Cpp2IlInjected.Token(Token = "0x4000320")]
		private AvatarItemBodyType OAJMKMFIMFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A0")]
		[Cpp2IlInjected.Token(Token = "0x4000321")]
		[SerializeField]
		protected AvatarFaceShape _currentFaceShape;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A8")]
		[Cpp2IlInjected.Token(Token = "0x4000322")]
		[SerializeField]
		protected AvatarBodyShape _currentBodyShape;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3B0")]
		[Cpp2IlInjected.Token(Token = "0x4000323")]
		[SerializeField]
		protected KPICGBGFHFC _currentNoseType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3B4")]
		[Cpp2IlInjected.Token(Token = "0x4000324")]
		[SerializeField]
		protected bool _hideEars;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3B5")]
		[Cpp2IlInjected.Token(Token = "0x4000325")]
		protected INNMNFODGGI IKIPJBLOKHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3B8")]
		[Cpp2IlInjected.Token(Token = "0x4000326")]
		protected int[] CADDNCOBEEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C0")]
		[Cpp2IlInjected.Token(Token = "0x4000327")]
		protected bool LECHNCPKBKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C8")]
		[Cpp2IlInjected.Token(Token = "0x4000328")]
		protected int[] AOAAPGPPHHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D0")]
		[Cpp2IlInjected.Token(Token = "0x4000329")]
		protected bool JMDDEDNFNNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D8")]
		[Cpp2IlInjected.Token(Token = "0x400032A")]
		protected KKKMJGNFFIF DECINIBEAIH;

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public string GIBDOPNEJNO
		{
			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0x8F7B20", Offset = "0x8F6920", VA = "0x1808F7B20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600020F")]
			[Cpp2IlInjected.Address(RVA = "0x8F7B10", Offset = "0x8F6910", VA = "0x1808F7B10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public bool OOAADLMEFHO
		{
			[Cpp2IlInjected.Token(Token = "0x6000211")]
			[Cpp2IlInjected.Address(RVA = "0xADD5B0", Offset = "0xADC3B0", VA = "0x180ADD5B0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000212")]
			[Cpp2IlInjected.Address(RVA = "0xB56580", Offset = "0xB55380", VA = "0x180B56580")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public virtual bool IBFKHGKKBDJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000213")]
			[Cpp2IlInjected.Address(RVA = "0x93EA60", Offset = "0x93D860", VA = "0x18093EA60", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public bool AEFPHJBEFGN
		{
			[Cpp2IlInjected.Token(Token = "0x6000214")]
			[Cpp2IlInjected.Address(RVA = "0x70FC330", Offset = "0x70FB130", VA = "0x1870FC330")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public virtual bool OJOPCLIGPCJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000215")]
			[Cpp2IlInjected.Address(RVA = "0x93EA60", Offset = "0x93D860", VA = "0x18093EA60", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public virtual bool EIMMHPFKNBK
		{
			[Cpp2IlInjected.Token(Token = "0x6000216")]
			[Cpp2IlInjected.Address(RVA = "0x910AD0", Offset = "0x90F8D0", VA = "0x180910AD0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public virtual bool BPPLNFJMGNK
		{
			[Cpp2IlInjected.Token(Token = "0x6000217")]
			[Cpp2IlInjected.Address(RVA = "0x93EA60", Offset = "0x93D860", VA = "0x18093EA60", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public PHGIHCICACD BIABJLBNCPD
		{
			[Cpp2IlInjected.Token(Token = "0x6000219")]
			[Cpp2IlInjected.Address(RVA = "0x97E860", Offset = "0x97D660", VA = "0x18097E860")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600021A")]
			[Cpp2IlInjected.Address(RVA = "0x70FC910", Offset = "0x70FB710", VA = "0x1870FC910")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public CNGDBOGKMMI DFMCIHBGFOD
		{
			[Cpp2IlInjected.Token(Token = "0x600021B")]
			[Cpp2IlInjected.Address(RVA = "0x9628B0", Offset = "0x9616B0", VA = "0x1809628B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600021C")]
			[Cpp2IlInjected.Address(RVA = "0x70FCC60", Offset = "0x70FBA60", VA = "0x1870FCC60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public CNGDBOGKMMI ADDJLEPJAOB
		{
			[Cpp2IlInjected.Token(Token = "0x600021D")]
			[Cpp2IlInjected.Address(RVA = "0x97DFE0", Offset = "0x97CDE0", VA = "0x18097DFE0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600021E")]
			[Cpp2IlInjected.Address(RVA = "0x70FCF10", Offset = "0x70FBD10", VA = "0x1870FCF10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		protected Material IJMNJMKIACA
		{
			[Cpp2IlInjected.Token(Token = "0x600021F")]
			[Cpp2IlInjected.Address(RVA = "0x70F73D0", Offset = "0x70F61D0", VA = "0x1870F73D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		protected Material IACJCDMOLLO
		{
			[Cpp2IlInjected.Token(Token = "0x6000220")]
			[Cpp2IlInjected.Address(RVA = "0x70F7810", Offset = "0x70F6610", VA = "0x1870F7810")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public bool KMOHMBMMNNK
		{
			[Cpp2IlInjected.Token(Token = "0x6000221")]
			[Cpp2IlInjected.Address(RVA = "0x9AB0C0", Offset = "0x9A9EC0", VA = "0x1809AB0C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public PlayerFacialAnimatorBase EJHLGNKBOOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0x95D170", Offset = "0x95BF70", VA = "0x18095D170")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public EKCGIGDNEEJ[] OHOHCKNPOPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000226")]
			[Cpp2IlInjected.Address(RVA = "0x70FBEF0", Offset = "0x70FACF0", VA = "0x1870FBEF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public EKCGIGDNEEJ LLPGLMLAGCL
		{
			[Cpp2IlInjected.Token(Token = "0x6000227")]
			[Cpp2IlInjected.Address(RVA = "0x70FC530", Offset = "0x70FB330", VA = "0x1870FC530")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public EKCGIGDNEEJ GMFMMFPEKHO
		{
			[Cpp2IlInjected.Token(Token = "0x6000228")]
			[Cpp2IlInjected.Address(RVA = "0x70FC560", Offset = "0x70FB360", VA = "0x1870FC560")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public Mesh DIJOFNCAHPD
		{
			[Cpp2IlInjected.Token(Token = "0x6000229")]
			[Cpp2IlInjected.Address(RVA = "0xC8E870", Offset = "0xC8D670", VA = "0x180C8E870")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		protected LLCPIIOEAKE MMGFOHIBKCP
		{
			[Cpp2IlInjected.Token(Token = "0x600022A")]
			[Cpp2IlInjected.Address(RVA = "0x70F6DE0", Offset = "0x70F5BE0", VA = "0x1870F6DE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		protected NAEGINDHOLH FBOCMBEJNCP
		{
			[Cpp2IlInjected.Token(Token = "0x600022B")]
			[Cpp2IlInjected.Address(RVA = "0xC8E890", Offset = "0xC8D690", VA = "0x180C8E890")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0x70F7EB0", Offset = "0x70F6CB0", VA = "0x1870F7EB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		protected bool DMNGMAJLIDO
		{
			[Cpp2IlInjected.Token(Token = "0x600022D")]
			[Cpp2IlInjected.Address(RVA = "0x910AD0", Offset = "0x90F8D0", VA = "0x180910AD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public bool NDCHGIPFLHL
		{
			[Cpp2IlInjected.Token(Token = "0x600022E")]
			[Cpp2IlInjected.Address(RVA = "0x70FC520", Offset = "0x70FB320", VA = "0x1870FC520")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public int MMNCOEDNPFN
		{
			[Cpp2IlInjected.Token(Token = "0x600022F")]
			[Cpp2IlInjected.Address(RVA = "0x1F7D020", Offset = "0x1F7BE20", VA = "0x181F7D020")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000230")]
			[Cpp2IlInjected.Address(RVA = "0x70FCE70", Offset = "0x70FBC70", VA = "0x1870FCE70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		protected virtual bool OAMIOFNDKGE
		{
			[Cpp2IlInjected.Token(Token = "0x6000231")]
			[Cpp2IlInjected.Address(RVA = "0x93EA60", Offset = "0x93D860", VA = "0x18093EA60", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		protected virtual int[] KCKIGOCBLEN
		{
			[Cpp2IlInjected.Token(Token = "0x6000232")]
			[Cpp2IlInjected.Address(RVA = "0x70F64A0", Offset = "0x70F52A0", VA = "0x1870F64A0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		protected bool BPBCBNAMELH
		{
			[Cpp2IlInjected.Token(Token = "0x6000234")]
			[Cpp2IlInjected.Address(RVA = "0x70F7A20", Offset = "0x70F6820", VA = "0x1870F7A20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		protected static bool MKGKJINIEAG
		{
			[Cpp2IlInjected.Token(Token = "0x6000235")]
			[Cpp2IlInjected.Address(RVA = "0x93EA60", Offset = "0x93D860", VA = "0x18093EA60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public bool OEMMBLLHCFM
		{
			[Cpp2IlInjected.Token(Token = "0x6000236")]
			[Cpp2IlInjected.Address(RVA = "0xFFF500", Offset = "0xFFE300", VA = "0x180FFF500")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000237")]
			[Cpp2IlInjected.Address(RVA = "0x70FD130", Offset = "0x70FBF30", VA = "0x1870FD130")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public IEnumerable<SkinnedMeshRenderer> BNNLMGDOJIN
		{
			[Cpp2IlInjected.Token(Token = "0x6000238")]
			[Cpp2IlInjected.Address(RVA = "0x70FBDC0", Offset = "0x70FABC0", VA = "0x1870FBDC0")]
			[IteratorStateMachine(typeof(GKIANGBLPBL))]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public bool FIMGNNJILII
		{
			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0xFFEFC0", Offset = "0xFFDDC0", VA = "0x180FFEFC0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0xFFEF40", Offset = "0xFFDD40", VA = "0x180FFEF40")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public ENGPMKLLDHI GKBAKCBIEGB
		{
			[Cpp2IlInjected.Token(Token = "0x600023B")]
			[Cpp2IlInjected.Address(RVA = "0x70FBE40", Offset = "0x70FAC40", VA = "0x1870FBE40")]
			get
			{
				return default(ENGPMKLLDHI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public static bool GMJCNABLLFF
		{
			[Cpp2IlInjected.Token(Token = "0x6000259")]
			[Cpp2IlInjected.Address(RVA = "0x70FC2A0", Offset = "0x70FB0A0", VA = "0x1870FC2A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		protected static CPMKHKOAIIG AJDOCLCAMMB
		{
			[Cpp2IlInjected.Token(Token = "0x600025A")]
			[Cpp2IlInjected.Address(RVA = "0x70F6D00", Offset = "0x70F5B00", VA = "0x1870F6D00")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600025B")]
			[Cpp2IlInjected.Address(RVA = "0x70F7B80", Offset = "0x70F6980", VA = "0x1870F7B80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		protected Color CEILMDAIBPO
		{
			[Cpp2IlInjected.Token(Token = "0x6000273")]
			[Cpp2IlInjected.Address(RVA = "0x70F54C0", Offset = "0x70F42C0", VA = "0x1870F54C0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		protected Color BAGAEHJIAPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000274")]
			[Cpp2IlInjected.Address(RVA = "0x70F6700", Offset = "0x70F5500", VA = "0x1870F6700")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		protected Texture2D CBPDIIDCLEB
		{
			[Cpp2IlInjected.Token(Token = "0x6000275")]
			[Cpp2IlInjected.Address(RVA = "0x70F4640", Offset = "0x70F3440", VA = "0x1870F4640")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		protected Color BHDLCDDMMIA
		{
			[Cpp2IlInjected.Token(Token = "0x600027B")]
			[Cpp2IlInjected.Address(RVA = "0x70F22C0", Offset = "0x70F10C0", VA = "0x1870F22C0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		protected Color AEOOOLHGBAA
		{
			[Cpp2IlInjected.Token(Token = "0x600027C")]
			[Cpp2IlInjected.Address(RVA = "0x70F50B0", Offset = "0x70F3EB0", VA = "0x1870F50B0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public EBDGGFHMAAD MGEENODBPJI
		{
			[Cpp2IlInjected.Token(Token = "0x600027D")]
			[Cpp2IlInjected.Address(RVA = "0x70FBEB0", Offset = "0x70FACB0", VA = "0x1870FBEB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		protected Texture2D LBJGFMHNHBJ
		{
			[Cpp2IlInjected.Token(Token = "0x600027E")]
			[Cpp2IlInjected.Address(RVA = "0x70F5CC0", Offset = "0x70F4AC0", VA = "0x1870F5CC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public float FFLILODPGKC
		{
			[Cpp2IlInjected.Token(Token = "0x6000285")]
			[Cpp2IlInjected.Address(RVA = "0x70FBED0", Offset = "0x70FACD0", VA = "0x1870FBED0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public float MDICCLLDJEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000286")]
			[Cpp2IlInjected.Address(RVA = "0x70FC310", Offset = "0x70FB110", VA = "0x1870FC310")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public bool INBFOCOGPEE
		{
			[Cpp2IlInjected.Token(Token = "0x60002B4")]
			[Cpp2IlInjected.Address(RVA = "0x70FBEA0", Offset = "0x70FACA0", VA = "0x1870FBEA0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002B5")]
			[Cpp2IlInjected.Address(RVA = "0x70FC6F0", Offset = "0x70FB4F0", VA = "0x1870FC6F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action PDJKAGJPFBN
		{
			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0x70FBC60", Offset = "0x70FAA60", VA = "0x1870FBC60")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600020D")]
			[Cpp2IlInjected.Address(RVA = "0x70FC590", Offset = "0x70FB390", VA = "0x1870FC590")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<MHJFMIKGCOJ, LFOHJBFCKOA> HEKIACEFPNP
		{
			[Cpp2IlInjected.Token(Token = "0x600024E")]
			[Cpp2IlInjected.Address(RVA = "0x70FBD00", Offset = "0x70FAB00", VA = "0x1870FBD00")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600024F")]
			[Cpp2IlInjected.Address(RVA = "0x70FC630", Offset = "0x70FB430", VA = "0x1870FC630")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x70F8B70", Offset = "0x70F7970", VA = "0x1870F8B70")]
		public bool SetDeformation(bool GDPJHHJHODM, bool LNGABLLINFH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x70F19E0", Offset = "0x70F07E0", VA = "0x1870F19E0")]
		protected static Material CPMGDDCPDJL(Dictionary<IAKNHOGKPPI, Material> FNFHGABCBBG, Material BNAGDKCOIPH, FLKMLMEODKN DFNLJLMBKBN, BGGAMFMPBPG APMDGBOOICP, GKHPEMHLGJO DNGHOGLAIFK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x70F3F90", Offset = "0x70F2D90", VA = "0x1870F3F90")]
		protected void GDEMENBLJME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x70F3CD0", Offset = "0x70F2AD0", VA = "0x1870F3CD0")]
		protected bool FNPEECGHODA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x70F40B0", Offset = "0x70F2EB0", VA = "0x1870F40B0")]
		protected void GFLHKAPBMDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x70F5460", Offset = "0x70F4260", VA = "0x1870F5460", Slot = "10")]
		protected virtual void JCKIKINGMBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x70F6640", Offset = "0x70F5440", VA = "0x1870F6640")]
		public int MeshesAtLODCount(int AADEJBGGGCJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x70F3850", Offset = "0x70F2650", VA = "0x1870F3850")]
		protected static void FBKGBJCPOIM(Dictionary<ONBJGLMPHMO, List<IAKNHOGKPPI>> CMAKDFMJDKN, LLPCHLCHKLP DFJGJCMGPME, Material BNAGDKCOIPH, FLKMLMEODKN KPBHNCKKDLO, BGGAMFMPBPG JGBFJCBFNJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x70F0AA0", Offset = "0x70EF8A0", VA = "0x1870F0AA0")]
		protected void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x70F60C0", Offset = "0x70F4EC0", VA = "0x1870F60C0")]
		protected void MBMDOFLGHCF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x70F7160", Offset = "0x70F5F60", VA = "0x1870F7160")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "11")]
		protected virtual void PLDLFINGLML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x70F6F20", Offset = "0x70F5D20", VA = "0x1870F6F20")]
		protected static void OEIEGLKDIDG(List<Material> KHCIMNHFNKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x70F4180", Offset = "0x70F2F80", VA = "0x1870F4180")]
		protected static void GGOKLMGOHNB(Dictionary<IAKNHOGKPPI, Material> FNFHGABCBBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x70F7D50", Offset = "0x70F6B50", VA = "0x1870F7D50")]
		protected static void PMOLOCJJOHK(Dictionary<Renderer, OKFDGGBIMNI> FIOCIFDKFIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x70F7900", Offset = "0x70F6700", VA = "0x1870F7900")]
		protected void PIHGKBBAIHG(SkinnedMeshRenderer[] NAOBDCMABCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x70F58C0", Offset = "0x70F46C0", VA = "0x1870F58C0")]
		protected void KFBMNEAKANM(SkinnedMeshRenderer GHMHFJNFMEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x70F5960", Offset = "0x70F4760", VA = "0x1870F5960")]
		protected void KFBMNEAKANM(MeshRenderer IFPDEPBHJDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x70F5660", Offset = "0x70F4460", VA = "0x1870F5660")]
		protected void JPHMEBIPFFE(List<PGIHMBHBFKK> KDHPOFEEGNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x70F7690", Offset = "0x70F6490", VA = "0x1870F7690")]
		protected void PECEGAIJOLF(Dictionary<string, MEPEJIIMKOI<Texture2D>> CMAKDFMJDKN, bool MKOABAOGDBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x70F4D50", Offset = "0x70F3B50", VA = "0x1870F4D50")]
		protected void IHFLMPGBPGO(Dictionary<ONBJGLMPHMO, List<IAKNHOGKPPI>> CMAKDFMJDKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x70F4540", Offset = "0x70F3340", VA = "0x1870F4540")]
		public float GetHandOpenClosedAxis(MHJFMIKGCOJ AOMFNDPKIJK)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x70F9400", Offset = "0x70F8200", VA = "0x1870F9400")]
		public void SetHandOpenClosedAxis(MHJFMIKGCOJ AOMFNDPKIJK, float NOFFLEHOPAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x70F4580", Offset = "0x70F3380", VA = "0x1870F4580")]
		public LFOHJBFCKOA GetHandVisualState(MHJFMIKGCOJ AOMFNDPKIJK)
		{
			return default(LFOHJBFCKOA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x70F01E0", Offset = "0x70EEFE0", VA = "0x1870F01E0")]
		public bool AddHandVisualStateToken(MHJFMIKGCOJ AOMFNDPKIJK, LFOHJBFCKOA FKAEIPMFFGJ, object HACFGBHNOCC, EKCGIGDNEEJ.DMHLCILDMBO JHPBGABBKOP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x70FABB0", Offset = "0x70F99B0", VA = "0x1870FABB0")]
		public void SetWatchHand(MHJFMIKGCOJ AOMFNDPKIJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x70FAC70", Offset = "0x70F9A70", VA = "0x1870FAC70")]
		public void SetWatchHands(bool BPLNBEEMCAK, bool EABENLOIFFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x70F8230", Offset = "0x70F7030", VA = "0x1870F8230")]
		public bool RemoveHandVisualStateToken(MHJFMIKGCOJ AOMFNDPKIJK, object HACFGBHNOCC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x70F4600", Offset = "0x70F3400", VA = "0x1870F4600")]
		public bool GetThumbsUpActive(MHJFMIKGCOJ AOMFNDPKIJK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x70FA660", Offset = "0x70F9460", VA = "0x1870FA660")]
		public void SetThumbsUpActive(MHJFMIKGCOJ AOMFNDPKIJK, bool JKNJIDCPADC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x70F45C0", Offset = "0x70F33C0", VA = "0x1870F45C0")]
		public bool GetHandshakeActive(MHJFMIKGCOJ AOMFNDPKIJK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x70F9450", Offset = "0x70F8250", VA = "0x1870F9450")]
		public void SetHandshakeActive(MHJFMIKGCOJ AOMFNDPKIJK, bool EOBALNJNOCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x70F3EF0", Offset = "0x70F2CF0", VA = "0x1870F3EF0")]
		public void ForceUpdateHandsVisualState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x70F2140", Offset = "0x70F0F40", VA = "0x1870F2140")]
		public static void ClearQueuedBuilds()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x70F4A40", Offset = "0x70F3840", VA = "0x1870F4A40")]
		protected static void HPJGAEBFDJF(PlayerAvatarDisplayBase GCGOLMGFKEJ, List<NLLKMOOKNLH> PFGNLDHAHLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x70F7F50", Offset = "0x70F6D50", VA = "0x1870F7F50")]
		public void Rebuild(bool JMABDMBJDBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x70F4EF0", Offset = "0x70F3CF0", VA = "0x1870F4EF0")]
		protected void IKBECLOECBO(bool JMABDMBJDBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x70F4DA0", Offset = "0x70F3BA0", VA = "0x1870F4DA0", Slot = "12")]
		protected virtual LDHIGNIGDAL IKBECLOECBO(IList<ONBJGLMPHMO> FNCGCIJGMIL, AvatarItemBodyType NMHPMOGJBNH, bool PALMACBCAAD, int[] BKBGMMKNDEH, bool JMABDMBJDBL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x70F0CD0", Offset = "0x70EFAD0", VA = "0x1870F0CD0")]
		protected static LDHIGNIGDAL BLKBEHIINCB(NLLKMOOKNLH ABGJHOEJOAO, List<NLLKMOOKNLH> PFGNLDHAHLD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x70F2260", Offset = "0x70F1060", VA = "0x1870F2260")]
		[IteratorStateMachine(typeof(ONBKHOBMPKC))]
		protected static IEnumerator<HLGDLHCLDFE> DEBNIGHIJFD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x70F5E50", Offset = "0x70F4C50", VA = "0x1870F5E50")]
		protected static NLLKMOOKNLH LFFMJGKJCKG(List<NLLKMOOKNLH> PFGNLDHAHLD)
		{
			return default(NLLKMOOKNLH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x70F8C70", Offset = "0x70F7A70", VA = "0x1870F8C70")]
		[AsyncStateMachine(typeof(CMEPOOLJFOK))]
		public Task SetFaceCustomizationSettings(IICGJDJAKCL NDCJJNCPEFJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x70F5100", Offset = "0x70F3F00", VA = "0x1870F5100")]
		public void InitializeFaceFeatures(AvatarConfiguration MAJEBKOFPCO, ENGPMKLLDHI GJAKIONDJGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x70FA3C0", Offset = "0x70F91C0", VA = "0x1870FA3C0")]
		public void SetTeamColors(Color? EBLEFNBHEAG, bool CJDBJGHJANI, Color KHMGAECACKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x10DFE20", Offset = "0x10DEC20", VA = "0x1810DFE20")]
		private static void JDJPEEIKHKH(Material FAGGGCGAPOE, Color IPHILEOFJLB, params int[] CIKALBHLJBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x10DFB00", Offset = "0x10DE900", VA = "0x1810DFB00")]
		private static void GCHPMMDIMEG(Material FAGGGCGAPOE, Texture IPHILEOFJLB, params int[] CIKALBHLJBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x70F51E0", Offset = "0x70F3FE0", VA = "0x1870F51E0")]
		protected void JAFHHGMKHBI(Material GGMFHHKJKGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x70F6E00", Offset = "0x70F5C00", VA = "0x1870F6E00")]
		protected void NOPEJDBIEJC(Material GGMFHHKJKGB, Color LDBOPKAIIAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x70F12F0", Offset = "0x70F00F0", VA = "0x1870F12F0")]
		protected void BOOELCMDEGF(Material GGMFHHKJKGB, Color LDBOPKAIIAE, Color GALHOCBAMGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x70F4320", Offset = "0x70F3120", VA = "0x1870F4320")]
		protected void GMDCFHHIDPA(Material GGMFHHKJKGB, Texture2D CEMDCHNHEAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x70F3BC0", Offset = "0x70F29C0", VA = "0x1870F3BC0")]
		protected void FJOMNCLDIEL(Material GGMFHHKJKGB, Texture MNOKCKDAONH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x70F1880", Offset = "0x70F0680", VA = "0x1870F1880")]
		protected void CKPIDMBOBAH(Action<OKFDGGBIMNI> MEKMMBKMOJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x70EF7F0", Offset = "0x70EE5F0", VA = "0x1870EF7F0")]
		protected void AFDODHKONJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x70F5B00", Offset = "0x70F4900", VA = "0x1870F5B00")]
		protected void LBCIHNOOACA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x70F69A0", Offset = "0x70F57A0", VA = "0x1870F69A0")]
		protected void NGLFJIPOBDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x70F0530", Offset = "0x70EF330", VA = "0x1870F0530")]
		public void ApplyUgcItemOverrides()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x70F85F0", Offset = "0x70F73F0", VA = "0x1870F85F0")]
		public void SetBeardPrimaryColor([Optional] Color? FNGPPLNALFG, bool GFDKBDBOBGN = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x70F8810", Offset = "0x70F7610", VA = "0x1870F8810")]
		public void SetBeardSecondaryColor([Optional] Color? FNGPPLNALFG, bool GFDKBDBOBGN = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x70F84B0", Offset = "0x70F72B0", VA = "0x1870F84B0")]
		public void SetBeardPattern([Optional] AvatarHairPattern LMICBFHMFFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x70F4F40", Offset = "0x70F3D40", VA = "0x1870F4F40")]
		private void INDNLEKCPEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x70F33B0", Offset = "0x70F21B0", VA = "0x1870F33B0")]
		private bool EJFHJKHOOEG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x70F8FE0", Offset = "0x70F7DE0", VA = "0x1870F8FE0")]
		public void SetHairPrimaryColor([Optional] Color? PPOHIMFMJOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x70F91F0", Offset = "0x70F7FF0", VA = "0x1870F91F0")]
		public void SetHairSecondaryColor([Optional] Color? PPOHIMFMJOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x70F8EB0", Offset = "0x70F7CB0", VA = "0x1870F8EB0")]
		public void SetHairPattern([Optional] AvatarHairPattern LMICBFHMFFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x70F80D0", Offset = "0x70F6ED0", VA = "0x1870F80D0")]
		public void RefreshHair()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x70F6580", Offset = "0x70F5380", VA = "0x1870F6580")]
		private bool MPFOEDDHLLM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x70FA200", Offset = "0x70F9000", VA = "0x1870FA200")]
		public void SetSkinColor(Color OOBIDMHFNDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x70FA6B0", Offset = "0x70F94B0", VA = "0x1870FA6B0")]
		public void SetUgcItemVisualOverrides(ONBJGLMPHMO LAIKJNCELMB, ENGPMKLLDHI GJAKIONDJGI, Texture BINCLAAAHNJ, Color PLDFAOCNILB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x70F2210", Offset = "0x70F1010", VA = "0x1870F2210")]
		public void ClearUgcItemVisualOverrides()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x70F8D70", Offset = "0x70F7B70", VA = "0x1870F8D70")]
		public bool SetFaceShape(AvatarFaceShape JALDIJBBDFH, bool BHNACGAPBEO = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x70F8A30", Offset = "0x70F7830", VA = "0x1870F8A30")]
		public bool SetBodyShape(AvatarBodyShape LGCEJLJELDC, bool BHNACGAPBEO = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x70FA0C0", Offset = "0x70F8EC0", VA = "0x1870FA0C0")]
		public bool SetNoseType(KPICGBGFHFC CGMNHCNBGPA, bool BHNACGAPBEO = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x70FADD0", Offset = "0x70F9BD0", VA = "0x1870FADD0")]
		public bool UpdateFaceAndBodyShapes()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x70FA0A0", Offset = "0x70F8EA0", VA = "0x1870FA0A0")]
		public bool SetHideEars(bool AABIPDIAOJP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x70FA090", Offset = "0x70F8E90", VA = "0x1870FA090")]
		public bool SetHelmetHair(IOLJGGGKDHL BCHHCDEKBCC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x70F9AF0", Offset = "0x70F88F0", VA = "0x1870F9AF0")]
		public void SetHatAnchorParameters(PACDKMEJBDN LEKJLGLCEHM, bool ABOPADDHGCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x70FAD40", Offset = "0x70F9B40", VA = "0x1870FAD40")]
		public void SetupDisplayLODs(INNMNFODGGI OKJLNNHELLJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x70F16C0", Offset = "0x70F04C0", VA = "0x1870F16C0")]
		protected int[] CINIJHFDGDK(INNMNFODGGI OKJLNNHELLJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x70FA190", Offset = "0x70F8F90", VA = "0x1870FA190")]
		public void SetOutfitSelections(IList<ONBJGLMPHMO> FNCGCIJGMIL, AvatarItemBodyType NMHPMOGJBNH, bool JMABDMBJDBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x70FA160", Offset = "0x70F8F60", VA = "0x1870FA160")]
		public void SetOutfitSelections(IList<ONBJGLMPHMO> FNCGCIJGMIL, AvatarItemBodyType NMHPMOGJBNH, bool PALMACBCAAD, bool JMABDMBJDBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x70FA1C0", Offset = "0x70F8FC0", VA = "0x1870FA1C0")]
		public LDHIGNIGDAL SetOutfitSelections(IList<ONBJGLMPHMO> FNCGCIJGMIL, AvatarItemBodyType NMHPMOGJBNH, INNMNFODGGI OKJLNNHELLJ, bool PALMACBCAAD, bool BHNACGAPBEO = false, bool JMABDMBJDBL = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x70F6750", Offset = "0x70F5550", VA = "0x1870F6750")]
		private LDHIGNIGDAL NEJKINOHBKE(IList<ONBJGLMPHMO> FNCGCIJGMIL, AvatarItemBodyType NMHPMOGJBNH, bool PALMACBCAAD, INNMNFODGGI OKJLNNHELLJ, bool BHNACGAPBEO, bool JMABDMBJDBL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x70F7060", Offset = "0x70F5E60", VA = "0x1870F7060")]
		protected int[] OEPEDGINKEC(INNMNFODGGI OKJLNNHELLJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x8F6D50", Offset = "0x8F5B50", VA = "0x1808F6D50", Slot = "13")]
		protected virtual NAEGINDHOLH CBFPGFAHGIO(AvatarItemBodyType PFHDLGLIBDB, Dictionary<string, EPEMMDIFGGB> JMCCPJDFJKO, Dictionary<string, MEPEJIIMKOI<Texture2D>> OALMDPOGDGM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x70EFF20", Offset = "0x70EED20", VA = "0x1870EFF20", Slot = "14")]
		protected virtual LDHIGNIGDAL APNPOHGGEDH(IList<ONBJGLMPHMO> FNCGCIJGMIL, AvatarItemBodyType NMHPMOGJBNH, bool PALMACBCAAD, int[] EHMHCBIGCAB, PMOAPNPOLPO CLJMOBECDIJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x70EFA30", Offset = "0x70EE830", VA = "0x1870EFA30", Slot = "15")]
		protected virtual EPEMMDIFGGB AOLGCCPEFNA(EBDGGFHMAAD IHPLBGGEMDP, AvatarItemBodyType PFHDLGLIBDB, GKHPEMHLGJO DNGHOGLAIFK, EPEMMDIFGGB KHELAACCFGF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x8F6D50", Offset = "0x8F5B50", VA = "0x1808F6D50", Slot = "16")]
		protected virtual EPEMMDIFGGB LPMDENGMGHE(AvatarItemBodyType PFHDLGLIBDB, GKHPEMHLGJO DNGHOGLAIFK, FJKDLOCAAGO ONBPKFMECNJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x70F7610", Offset = "0x70F6410", VA = "0x1870F7610")]
		protected void PBCMDCDLPBG(IKIDNOHIOAL LABCEFAKJHJ, HFBLFLDOFLG.KLFEKKPPLNK LAOIKAHHCLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x70F2310", Offset = "0x70F1110", VA = "0x1870F2310")]
		protected void ECHJHNEFCDA(IKIDNOHIOAL LABCEFAKJHJ, HFBLFLDOFLG.KLFEKKPPLNK LAOIKAHHCLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0xCBF660", Offset = "0xCBE460", VA = "0x180CBF660", Slot = "17")]
		protected virtual IKIDNOHIOAL AFEGEFBDCNG(IKIDNOHIOAL LABCEFAKJHJ, HelmetHairStyle CGJLEFFFFHM, bool GKKHEPFJMEJ, AvatarItemBodyType NMHPMOGJBNH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x70F2390", Offset = "0x70F1190", VA = "0x1870F2390")]
		protected IKIDNOHIOAL ECPOEBCLJNG(IList<ONBJGLMPHMO> FNCGCIJGMIL, AvatarItemBodyType LFGKJNNGDFD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x70F2020", Offset = "0x70F0E20", VA = "0x1870F2020")]
		public void CleanupDisplayResources()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x70F48C0", Offset = "0x70F36C0", VA = "0x1870F48C0")]
		protected void HOKFEINPPAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x70F3460", Offset = "0x70F2260", VA = "0x1870F3460")]
		protected void EJJCEJPDHHF(Transform GOIEEOKGAEH, IEnumerable<SkinnedMeshRenderer> LJPOIOHGJOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x70F5A30", Offset = "0x70F4830", VA = "0x1870F5A30")]
		protected HFBLFLDOFLG.KLFEKKPPLNK KHKDPJMJHCJ(HFBLFLDOFLG.KLFEKKPPLNK DFFKLLOKFME, GKHPEMHLGJO EBFHFEGNDFC)
		{
			return default(HFBLFLDOFLG.KLFEKKPPLNK);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x70F5FA0", Offset = "0x70F4DA0", VA = "0x1870F5FA0")]
		protected void LIOIBJFANCI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x1039A40", Offset = "0x1038840", VA = "0x181039A40")]
		protected void BHOHIJMJIBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x70F5FB0", Offset = "0x70F4DB0", VA = "0x1870F5FB0")]
		protected void LMEBDDAKDMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x70F4970", Offset = "0x70F3770", VA = "0x1870F4970")]
		[AsyncStateMachine(typeof(MHJAAIJLPMO))]
		protected Task HONGNKHDCAL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x70F1520", Offset = "0x70F0320", VA = "0x1870F1520")]
		protected static FLKMLMEODKN CCAEKMNPPPG(LLPCHLCHKLP PLDJCJINFEM, int POHBHLBADHD)
		{
			return default(FLKMLMEODKN);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x70F5510", Offset = "0x70F4310", VA = "0x1870F5510")]
		protected static BGGAMFMPBPG JJJLPCDEFAC(LLPCHLCHKLP PLDJCJINFEM, int POHBHLBADHD)
		{
			return default(BGGAMFMPBPG);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x70F42E0", Offset = "0x70F30E0", VA = "0x1870F42E0")]
		protected Transform GIFNDFMKCPE(GKHPEMHLGJO DNGHOGLAIFK, OutfitType BFOOEKHPMJD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x70F4B50", Offset = "0x70F3950", VA = "0x1870F4B50")]
		protected void IAMAIGINPGJ(int NFIGLLHMKPG, Material FAGGGCGAPOE, LLPCHLCHKLP PLDJCJINFEM, [Out] Texture2D CCOFOEMLEIJ, [Out] Vector4 PGIJGGOPKBI, [Out] Texture2D OIJHONLCDFN, [Out] Texture2D OHJIDICBFCD, [Out] Texture2D NOHJJKHCABF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x70F4770", Offset = "0x70F3570", VA = "0x1870F4770")]
		protected void HFFELCBBAPI(int NFIGLLHMKPG, Material FAGGGCGAPOE, LLPCHLCHKLP PLDJCJINFEM, [Out] Color LGCDNNNCLDG, [Out] Color KIIOEENPCAA, [Out] Color HAICBLLGGMO, [Out] Color PIGPFLDELLK, [Out] Color JEEOCFHBOOG, [Out] Color JJPBBDPMCFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x70F0BC0", Offset = "0x70EF9C0", VA = "0x1870F0BC0")]
		protected void BCLGOGPBBJB(Vector3 FJDJKDCINHA, Quaternion FJBLNCDHDGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x70F94A0", Offset = "0x70F82A0", VA = "0x1870F94A0")]
		public void SetHatAnchorParameters(PACDKMEJBDN LEKJLGLCEHM, AnchorParamsRestrictions ILKPKKEMDEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x70F1B40", Offset = "0x70F0940", VA = "0x1870F1B40")]
		public static void CalculateHatAnchorParams(FitMeshHemisphere DELGPIOABHN, Transform GOBOLECKGOJ, PACDKMEJBDN LEKJLGLCEHM, AnchorParamsRestrictions GEFACINDGLG, [Out] Vector3 PFKOKOAMOAJ, [Out] Quaternion ACJIHPAJKOG, [Out] PACDKMEJBDN PNFIHFHKJJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x70F8340", Offset = "0x70F7140", VA = "0x1870F8340")]
		public void ResetHatAnchor(Vector2 ILGCLABPIBF, Vector3 FOGAPCHLMGD, Vector3 AODCFFHHAIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x9696C0", Offset = "0x9684C0", VA = "0x1809696C0")]
		public DLJLECMBPJI GetAnchorParamsRestrictions()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x70F0360", Offset = "0x70EF160", VA = "0x1870F0360")]
		public void ApplyBlocks()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x70F04A0", Offset = "0x70EF2A0", VA = "0x1870F04A0")]
		public void ApplyHairPattern()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x70F02D0", Offset = "0x70EF0D0", VA = "0x1870F02D0")]
		public void ApplyBeardPattern()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x70FAD70", Offset = "0x70F9B70", VA = "0x1870FAD70", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x70F3780", Offset = "0x70F2580", VA = "0x1870F3780")]
		protected void EMGEIGHIDNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x70FAB30", Offset = "0x70F9930", VA = "0x1870FAB30")]
		public void SetWaitForUgcTextureLoads(bool OKIMEDGOJNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x70FAA50", Offset = "0x70F9850", VA = "0x1870FAA50")]
		public void SetUgcTextureParameters(KKKMJGNFFIF KODPGCABALO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x70FB660", Offset = "0x70FA460", VA = "0x1870FB660")]
		public PlayerAvatarDisplayBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x70F5DC0", Offset = "0x70F4BC0", VA = "0x1870F5DC0")]
		[CompilerGenerated]
		private void LCFCMGLEGLF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x70F73A0", Offset = "0x70F61A0", VA = "0x1870F73A0")]
		[CompilerGenerated]
		private void PAKFMABOIPK(OKFDGGBIMNI DILOMOBFEEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x70EF760", Offset = "0x70EE560", VA = "0x1870EF760")]
		[CompilerGenerated]
		private void ABMBACBNKMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x70F0C30", Offset = "0x70EFA30", VA = "0x1870F0C30")]
		[CompilerGenerated]
		private void BJGCCFEEDDA(OKFDGGBIMNI DILOMOBFEEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x70F3B30", Offset = "0x70F2930", VA = "0x1870F3B30")]
		[CompilerGenerated]
		private void FHMHONBJDNN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x70F6400", Offset = "0x70F5200", VA = "0x1870F6400")]
		[CompilerGenerated]
		private void MJKEAAKBCLM(OKFDGGBIMNI DILOMOBFEEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x70F5F10", Offset = "0x70F4D10", VA = "0x1870F5F10")]
		[CompilerGenerated]
		private void LHCDDBHFBKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x70F6530", Offset = "0x70F5330", VA = "0x1870F6530")]
		[CompilerGenerated]
		private void MPFCBAIJIBA(OKFDGGBIMNI DILOMOBFEEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x70F6D50", Offset = "0x70F5B50", VA = "0x1870F6D50")]
		[CompilerGenerated]
		private void NNOKILAJFIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x70F3F40", Offset = "0x70F2D40", VA = "0x1870F3F40")]
		[CompilerGenerated]
		private void GAAIMKJJGGB(OKFDGGBIMNI DILOMOBFEEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x70F5830", Offset = "0x70F4630", VA = "0x1870F5830")]
		[CompilerGenerated]
		private void KAMAHMDPJJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x70F3390", Offset = "0x70F2190", VA = "0x1870F3390")]
		[CompilerGenerated]
		private void EECGNLFGBKJ(OKFDGGBIMNI DILOMOBFEEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x70F7AA0", Offset = "0x70F68A0", VA = "0x1870F7AA0")]
		[CompilerGenerated]
		internal static bool PJLNMMNAOMJ(Transform NJBJJHMNDPE, IEnumerable<SkinnedMeshRenderer> HDKBHEDCLJA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x70F4140", Offset = "0x70F2F40", VA = "0x1870F4140")]
		[CompilerGenerated]
		private void GGLDPHEOJBJ(OKFDGGBIMNI DILOMOBFEEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x70F4730", Offset = "0x70F3530", VA = "0x1870F4730")]
		[CompilerGenerated]
		private void HEGIDEKGJJH(OKFDGGBIMNI DILOMOBFEEI)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[ExecuteAlways]
	public class PlayerFacialAnimatorBase : MonoBehaviour, HECGOLGDACB
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200006C")]
		[CompilerGenerated]
		private struct DKAOKDGHKPA : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000444")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000445")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000446")]
			public IICGJDJAKCL avatarData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000447")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000448")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000379")]
			[Cpp2IlInjected.Address(RVA = "0x70FE610", Offset = "0x70FD410", VA = "0x1870FE610", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600037A")]
			[Cpp2IlInjected.Address(RVA = "0x70FE8A0", Offset = "0x70FD6A0", VA = "0x1870FE8A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200006D")]
		[CompilerGenerated]
		private struct NDBEEMHIGMP : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000449")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400044A")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400044B")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400044C")]
			public int eyeSelection;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x400044D")]
			public int eyeBrowSelection;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400044E")]
			public int noseSelection;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x400044F")]
			public int mouthSelection;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000450")]
			public ENGPMKLLDHI avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000451")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600037B")]
			[Cpp2IlInjected.Address(RVA = "0x7101F80", Offset = "0x7100D80", VA = "0x187101F80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600037C")]
			[Cpp2IlInjected.Address(RVA = "0x7102150", Offset = "0x7100F50", VA = "0x187102150", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200006E")]
		[CompilerGenerated]
		private struct JMEKDMDDIJK : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000452")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000453")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000454")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000455")]
			public FaceFeatureType featureType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000456")]
			public int selectionIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000457")]
			public ENGPMKLLDHI avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000458")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600037D")]
			[Cpp2IlInjected.Address(RVA = "0x7101A00", Offset = "0x7100800", VA = "0x187101A00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600037E")]
			[Cpp2IlInjected.Address(RVA = "0x7101BA0", Offset = "0x71009A0", VA = "0x187101BA0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200006F")]
		[CompilerGenerated]
		private struct OBIGHNIBKPE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000459")]
			public IICGJDJAKCL avatarData;
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000070")]
		[CompilerGenerated]
		private struct IKEIGNOCIEP : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400045A")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400045B")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400045C")]
			public IICGJDJAKCL avatarData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400045D")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400045E")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600037F")]
			[Cpp2IlInjected.Address(RVA = "0x71012B0", Offset = "0x71000B0", VA = "0x1871012B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000380")]
			[Cpp2IlInjected.Address(RVA = "0x71019A0", Offset = "0x71007A0", VA = "0x1871019A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000071")]
		[CompilerGenerated]
		private struct AELPLPHKCFH : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400045F")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000460")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000461")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000462")]
			public ENGPMKLLDHI avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000463")]
			private TaskAwaiter<POAAHJJCJAI> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000381")]
			[Cpp2IlInjected.Address(RVA = "0x70FD6E0", Offset = "0x70FC4E0", VA = "0x1870FD6E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000382")]
			[Cpp2IlInjected.Address(RVA = "0x70FDB00", Offset = "0x70FC900", VA = "0x1870FDB00", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000072")]
		[CompilerGenerated]
		private struct EMKKJHHIMBF : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000464")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000465")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000466")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000467")]
			public ENGPMKLLDHI avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000468")]
			private FaceStyleSet <styleSet>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000469")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000383")]
			[Cpp2IlInjected.Address(RVA = "0x70FFD00", Offset = "0x70FEB00", VA = "0x1870FFD00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000384")]
			[Cpp2IlInjected.Address(RVA = "0x71001C0", Offset = "0x70FEFC0", VA = "0x1871001C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40003D2")]
		protected const float HJGPJHBNOFM = 0.5f;

		[Cpp2IlInjected.Token(Token = "0x40003D3")]
		protected const int LNBPAJIKHEK = 5;

		[Cpp2IlInjected.Token(Token = "0x40003D4")]
		public static readonly int IdleID;

		[Cpp2IlInjected.Token(Token = "0x40003D5")]
		public static readonly int SmileID;

		[Cpp2IlInjected.Token(Token = "0x40003D6")]
		public static readonly int HugeSmileID;

		[Cpp2IlInjected.Token(Token = "0x40003D7")]
		public static readonly int ScoreID;

		[Cpp2IlInjected.Token(Token = "0x40003D8")]
		public static readonly int SadID;

		[Cpp2IlInjected.Token(Token = "0x40003D9")]
		public static readonly int DisgustID;

		[Cpp2IlInjected.Token(Token = "0x40003DA")]
		public static readonly int HitID;

		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		public static readonly int ConcentrateID;

		[Cpp2IlInjected.Token(Token = "0x40003DC")]
		public static readonly int KissID;

		[Cpp2IlInjected.Token(Token = "0x40003DD")]
		public static readonly int TalkingID;

		[Cpp2IlInjected.Token(Token = "0x40003DE")]
		public static readonly int MuteID;

		[Cpp2IlInjected.Token(Token = "0x40003DF")]
		public static readonly int AFKID;

		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		public static readonly int HappyID;

		[Cpp2IlInjected.Token(Token = "0x40003E1")]
		public static readonly int EmoteFlatID;

		[Cpp2IlInjected.Token(Token = "0x40003E2")]
		public static readonly int EmoteHappyID;

		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		public static readonly int EmoteSadID;

		[Cpp2IlInjected.Token(Token = "0x40003E4")]
		public static readonly int EmoteLoveID;

		[Cpp2IlInjected.Token(Token = "0x40003E5")]
		public static readonly int EmoteAngryID;

		[Cpp2IlInjected.Token(Token = "0x40003E6")]
		public static readonly int EmoteLaughID;

		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		public static readonly int EmoteTongueOutID;

		[Cpp2IlInjected.Token(Token = "0x40003E8")]
		public static readonly int EmoteGrimacingID;

		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		public static readonly int EmoteWinkID;

		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		public static readonly int EmoteShockedID;

		[Cpp2IlInjected.Token(Token = "0x40003EB")]
		public static readonly int EmoteNauseatedID;

		[Cpp2IlInjected.Token(Token = "0x40003EC")]
		public static readonly int EmoteSmileSweatID;

		[Cpp2IlInjected.Token(Token = "0x40003ED")]
		public static readonly int EmoteSleepingID;

		[Cpp2IlInjected.Token(Token = "0x40003EE")]
		public static readonly int EmoteThinkingID;

		[Cpp2IlInjected.Token(Token = "0x40003EF")]
		public static readonly int EmoteSmirkID;

		[Cpp2IlInjected.Token(Token = "0x40003F0")]
		public static readonly int EmoteSmileID;

		[Cpp2IlInjected.Token(Token = "0x40003F1")]
		protected static readonly Dictionary<JEHENHGBMFI.GLEHJFEDLEM, int> ABIKHDKLMLL;

		[Cpp2IlInjected.Token(Token = "0x40003F2")]
		[CanBeNull]
		protected static IEnumerable<FaceFeatureType> DJFBOLKDKCL;

		[Cpp2IlInjected.Token(Token = "0x40003F3")]
		protected static readonly int PMCFDJBBFFA;

		[Cpp2IlInjected.Token(Token = "0x40003F4")]
		protected static readonly int OAIJBENBOFO;

		[Cpp2IlInjected.Token(Token = "0x40003F5")]
		protected static readonly int PJIIFADGGIH;

		[Cpp2IlInjected.Token(Token = "0x40003F6")]
		protected static readonly int NIOPFEABCCF;

		[Cpp2IlInjected.Token(Token = "0x40003F7")]
		protected static readonly int BKNMJJCLHGE;

		[Cpp2IlInjected.Token(Token = "0x40003F8")]
		protected static readonly int HEEPDCBJOCK;

		[Cpp2IlInjected.Token(Token = "0x40003F9")]
		protected static readonly int CHECMCJFGBM;

		[Cpp2IlInjected.Token(Token = "0x40003FA")]
		protected static readonly int IIFFNKLBCLD;

		[Cpp2IlInjected.Token(Token = "0x40003FB")]
		protected static Vector2 EPHNMDKDCHM;

		[Cpp2IlInjected.Token(Token = "0x40003FC")]
		protected static Vector2 AONAJPHMAKA;

		[Cpp2IlInjected.Token(Token = "0x40003FD")]
		protected static Vector2 ADKDJNOIAKJ;

		[Cpp2IlInjected.Token(Token = "0x40003FE")]
		protected static Vector2 OPIODNFMPLG;

		[Cpp2IlInjected.Token(Token = "0x40003FF")]
		protected static Vector2 OLLHAOGNDAK;

		[Cpp2IlInjected.Token(Token = "0x4000400")]
		protected static Vector2 IMMHCJMPGGM;

		[Cpp2IlInjected.Token(Token = "0x4000401")]
		protected static Vector2 LGNKNOIGLEP;

		[Cpp2IlInjected.Token(Token = "0x4000402")]
		protected static Vector2 OAIIEMJLBPN;

		[Cpp2IlInjected.Token(Token = "0x4000403")]
		protected static Vector2 JABFMKFEGCI;

		[Cpp2IlInjected.Token(Token = "0x4000404")]
		protected static Vector2 MFFHGHNDNDJ;

		[Cpp2IlInjected.Token(Token = "0x4000405")]
		protected static Vector2 CNEICDHAMMK;

		[Cpp2IlInjected.Token(Token = "0x4000406")]
		protected static Vector2 MKGLGJLLCIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000407")]
		[EECICDBJENE(ADIKDNKOEBP.Self, false, false, false)]
		[SerializeField]
		public Animator animator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000408")]
		[SerializeField]
		[Header("Rendering")]
		public FaceStyleSet faceStyleSet;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000409")]
		[SerializeField]
		protected Renderer faceRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400040A")]
		[SerializeField]
		protected float jitterFPS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400040B")]
		[SerializeField]
		[Header("Emotes")]
		public Renderer[] emoteEffectRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400040C")]
		[FormerlySerializedAs("fullBodyFaceStyleSet")]
		[SerializeField]
		[Header("Modern Avatar Facial Features")]
		public FaceStyleSet modernBodyFaceStyleSet;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400040D")]
		private ENGPMKLLDHI KCBMEHPPKMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400040E")]
		private FaceStyleSet IOBJNLIBCOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400040F")]
		[SerializeField]
		protected bool debugEyeJitterInEditor;

		[Cpp2IlInjected.Token(Token = "0x4000410")]
		protected const int HMNHDJMIJEP = -1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000411")]
		protected int EBIGFEMANIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000412")]
		protected int MPFEILAEFPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000413")]
		protected int DHIEEBOKJLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000414")]
		protected int EMEMPPIHPJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000415")]
		protected Vector2 BGLFFKOCBNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000416")]
		protected float KBAHOIDHKMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000417")]
		protected Vector2 MEAGNNILEIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000418")]
		protected float KNOGCPNOCPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000419")]
		protected Vector2 BFBDEBCHGCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x400041A")]
		protected float JBGEOEOBPCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400041B")]
		protected Vector2 OCPHILKLGFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400041C")]
		protected float DHIBHLGJGJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400041D")]
		protected List<SelectableFaceOption> HOOBNFFIEOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400041E")]
		protected List<SelectableFaceOption> MHFMJIMHBDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400041F")]
		protected List<SelectableFaceOption> CGEHJFMHCAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000420")]
		protected List<SelectableFaceOption> IMMBJHMBLAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000421")]
		protected Coroutine GGHENMFKIKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000422")]
		protected int? MMBCPKENLED;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000423")]
		protected int BPNFPGDFPMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
		[Cpp2IlInjected.Token(Token = "0x4000424")]
		protected int CNCHPBLFAJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000425")]
		protected int DMHMFHOLFCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
		[Cpp2IlInjected.Token(Token = "0x4000426")]
		protected int KICPIBCJJIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000427")]
		protected int JOBPJGNHFBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
		[Cpp2IlInjected.Token(Token = "0x4000428")]
		protected int MDNCOJFKLOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000429")]
		protected Sprite GDNFMKLIKLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400042A")]
		protected Sprite HIEDDNFEKPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400042B")]
		protected Sprite INDHKPMCDBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400042C")]
		protected Sprite AEDBFGGJEBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400042D")]
		protected bool HOONGLIEEHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x400042F")]
		protected string MICCEGNHOHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000430")]
		protected string PIKEDMOOCCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000431")]
		protected string LPOGGFHDAJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000432")]
		protected string PECIOLIAEMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000433")]
		[ReadOnlyField]
		public Sprite eyeSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000434")]
		[ReadOnlyField]
		public Sprite leftEyeOnlySprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x4000435")]
		[ReadOnlyField]
		public Sprite rightEyeOnlySprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4000436")]
		public Color leftEyeColorTint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4000437")]
		public Color leftEyeGleamColorTint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x4000438")]
		public Color rightEyeColorTint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x4000439")]
		public Color rightEyeGleamColorTint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x400043A")]
		[ReadOnlyField]
		public Sprite mouthSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x400043E")]
		protected AvatarConfiguration MAJEBKOFPCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x400043F")]
		protected POAAHJJCJAI GNPKBEMAGKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x4000441")]
		private readonly List<Material> LAPKIELAFDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x4000442")]
		protected DONFNGKIDGE CPDHJHPGGEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x4000443")]
		protected Dictionary<string, int> MIAMICNNPIG;

		[Cpp2IlInjected.Token(Token = "0x17000094")]
		public FaceStyleSet PGKIILLCPAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000334")]
			[Cpp2IlInjected.Address(RVA = "0x710BCC0", Offset = "0x710AAC0", VA = "0x18710BCC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000095")]
		public bool JHOHEJMLBOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000337")]
			[Cpp2IlInjected.Address(RVA = "0x977460", Offset = "0x976260", VA = "0x180977460", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000338")]
			[Cpp2IlInjected.Address(RVA = "0x974BA0", Offset = "0x9739A0", VA = "0x180974BA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000096")]
		protected virtual bool NMPLABGBCHM
		{
			[Cpp2IlInjected.Token(Token = "0x6000339")]
			[Cpp2IlInjected.Address(RVA = "0x93EA60", Offset = "0x93D860", VA = "0x18093EA60", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000097")]
		protected virtual bool IPBIIBDAMFL
		{
			[Cpp2IlInjected.Token(Token = "0x600033A")]
			[Cpp2IlInjected.Address(RVA = "0x910AD0", Offset = "0x90F8D0", VA = "0x180910AD0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000098")]
		protected int LHHODHLLILP
		{
			[Cpp2IlInjected.Token(Token = "0x600033B")]
			[Cpp2IlInjected.Address(RVA = "0x7105F80", Offset = "0x7104D80", VA = "0x187105F80")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000099")]
		public Renderer NPLBPHIODMI
		{
			[Cpp2IlInjected.Token(Token = "0x600033C")]
			[Cpp2IlInjected.Address(RVA = "0x8F41F0", Offset = "0x8F2FF0", VA = "0x1808F41F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009A")]
		public bool CFLIEJOBJNC
		{
			[Cpp2IlInjected.Token(Token = "0x600033D")]
			[Cpp2IlInjected.Address(RVA = "0x12CB270", Offset = "0x12CA070", VA = "0x1812CB270")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600033E")]
			[Cpp2IlInjected.Address(RVA = "0x12CB580", Offset = "0x12CA380", VA = "0x1812CB580")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009B")]
		public Renderer[] DNBJHPKGPCD
		{
			[Cpp2IlInjected.Token(Token = "0x600033F")]
			[Cpp2IlInjected.Address(RVA = "0x8F4490", Offset = "0x8F3290", VA = "0x1808F4490")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009C")]
		public bool CCBNBEBOKGE
		{
			[Cpp2IlInjected.Token(Token = "0x6000340")]
			[Cpp2IlInjected.Address(RVA = "0x710BD00", Offset = "0x710AB00", VA = "0x18710BD00")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000341")]
			[Cpp2IlInjected.Address(RVA = "0x710BEC0", Offset = "0x710ACC0", VA = "0x18710BEC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		protected int DLKMDEKKHDA
		{
			[Cpp2IlInjected.Token(Token = "0x6000342")]
			[Cpp2IlInjected.Address(RVA = "0x71092E0", Offset = "0x71080E0", VA = "0x1871092E0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009E")]
		protected int HDHBOGILFIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000343")]
			[Cpp2IlInjected.Address(RVA = "0x7106EF0", Offset = "0x7105CF0", VA = "0x187106EF0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		public float OCHGBNNMBAG
		{
			[Cpp2IlInjected.Token(Token = "0x6000344")]
			[Cpp2IlInjected.Address(RVA = "0x710BCE0", Offset = "0x710AAE0", VA = "0x18710BCE0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000345")]
			[Cpp2IlInjected.Address(RVA = "0x710BEA0", Offset = "0x710ACA0", VA = "0x18710BEA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A0")]
		public EKOHFHHJFFI KIFJIADBJEC
		{
			[Cpp2IlInjected.Token(Token = "0x6000346")]
			[Cpp2IlInjected.Address(RVA = "0x975AF0", Offset = "0x9748F0", VA = "0x180975AF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000347")]
			[Cpp2IlInjected.Address(RVA = "0xAD9840", Offset = "0xAD8640", VA = "0x180AD9840")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A1")]
		public POAAHJJCJAI LPFGAOLNFPE
		{
			[Cpp2IlInjected.Token(Token = "0x6000360")]
			[Cpp2IlInjected.Address(RVA = "0x95EAA0", Offset = "0x95D8A0", VA = "0x18095EAA0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000361")]
			[Cpp2IlInjected.Address(RVA = "0x710BE20", Offset = "0x710AC20", VA = "0x18710BE20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A2")]
		public NoseFaceOption FIGIIMEOIAD
		{
			[Cpp2IlInjected.Token(Token = "0x6000362")]
			[Cpp2IlInjected.Address(RVA = "0x969770", Offset = "0x968570", VA = "0x180969770")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000363")]
			[Cpp2IlInjected.Address(RVA = "0xAD9820", Offset = "0xAD8620", VA = "0x180AD9820")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A3")]
		protected DONFNGKIDGE BOJJGIBLIDA
		{
			[Cpp2IlInjected.Token(Token = "0x6000364")]
			[Cpp2IlInjected.Address(RVA = "0x7106350", Offset = "0x7105150", VA = "0x187106350")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action EDGIMFGPKMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000335")]
			[Cpp2IlInjected.Address(RVA = "0x710BC10", Offset = "0x710AA10", VA = "0x18710BC10")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000336")]
			[Cpp2IlInjected.Address(RVA = "0x710BD70", Offset = "0x710AB70", VA = "0x18710BD70")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x7108A20", Offset = "0x7107820", VA = "0x187108A20")]
		public void LocalPlayEmote(JEHENHGBMFI.GLEHJFEDLEM EHGFGHDIGNJ, float OAHJFOPNDHC = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x7107D40", Offset = "0x7106B40", VA = "0x187107D40")]
		public bool IsEmotePlaying(JEHENHGBMFI.GLEHJFEDLEM EHGFGHDIGNJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x7109C70", Offset = "0x7108A70", VA = "0x187109C70")]
		public void SetIdleHappy(bool BPNBMBCFCGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x71077E0", Offset = "0x71065E0", VA = "0x1871077E0")]
		protected void IBPMHKBHKFL(bool AOILNBBDJOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x7109340", Offset = "0x7108140", VA = "0x187109340")]
		protected void PJGLHFLHCLI(bool BLPOLLGBJEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x71062E0", Offset = "0x71050E0", VA = "0x1871062E0")]
		protected void CBHABNGNOHM(GKHPEMHLGJO DNGHOGLAIFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x71063D0", Offset = "0x71051D0", VA = "0x1871063D0")]
		protected void DICFKOADKEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x71094A0", Offset = "0x71082A0", VA = "0x1871094A0")]
		public void PlayExpression(int OONPFDOHGEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x7108B20", Offset = "0x7107920", VA = "0x187108B20")]
		protected void MBHJHBCICGD(bool OMMFCAEKGIL, bool KKDJGKLDOEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0x7107510", Offset = "0x7106310", VA = "0x187107510")]
		public List<SelectableFaceOption> GetAvailableFeatures(FaceFeatureType HBIIPNPAJOF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x7107860", Offset = "0x7106660", VA = "0x187107860")]
		public void InitializeFaceFeatureRanges(AvatarConfiguration MAJEBKOFPCO, ENGPMKLLDHI GJAKIONDJGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x7109B80", Offset = "0x7108980", VA = "0x187109B80")]
		[AsyncStateMachine(typeof(DKAOKDGHKPA))]
		public Task SetFaceSettings(IICGJDJAKCL NDCJJNCPEFJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x7109A50", Offset = "0x7108850", VA = "0x187109A50")]
		[AsyncStateMachine(typeof(NDBEEMHIGMP))]
		public Task SetFaceSettings(int MHLEDAHOOCD, int BFMDLBJBHEG, int MEMLKCIKMNL, int AGHGPCHKCKH, ENGPMKLLDHI GJAKIONDJGI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x7109CF0", Offset = "0x7108AF0", VA = "0x187109CF0")]
		[AsyncStateMachine(typeof(JMEKDMDDIJK))]
		public Task SetSelectedFaceFeatureAndBuildFaceStyle(FaceFeatureType HBIIPNPAJOF, int BOJBNENOHNM, ENGPMKLLDHI GJAKIONDJGI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x7108F50", Offset = "0x7107D50", VA = "0x187108F50")]
		protected void OCFJPKJECEA(FaceFeatureType HBIIPNPAJOF, PNHNCIGEODL CGFJDKPEAGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x7106610", Offset = "0x7105410", VA = "0x187106610")]
		protected void FFGCIODDLLB(FaceFeatureType HBIIPNPAJOF, int BOJBNENOHNM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0x7107330", Offset = "0x7106130", VA = "0x187107330")]
		public static IEnumerable<FaceFeatureType> GetAllFaceFeatureTypes()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0x71086B0", Offset = "0x71074B0", VA = "0x1871086B0")]
		[AsyncStateMachine(typeof(IKEIGNOCIEP))]
		protected Task KEHCIEOJBFA(IICGJDJAKCL NDCJJNCPEFJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x7108880", Offset = "0x7107680", VA = "0x187108880")]
		protected static void LNPPPEJJKHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0x7107550", Offset = "0x7106350", VA = "0x187107550")]
		private void HKKLICELJHG(bool BMOHEJKPMPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0x7108BE0", Offset = "0x71079E0", VA = "0x187108BE0")]
		protected void OBDBNFENBIK(FaceFeatureType HBIIPNPAJOF, Vector2 NOIGPPOELEH, ENGPMKLLDHI GJAKIONDJGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x71094C0", Offset = "0x71082C0", VA = "0x1871094C0")]
		public void SetFaceFeatureNormalizedPositionOffset(FaceFeatureType HBIIPNPAJOF, Vector2 JFHHAPLDCIC, ENGPMKLLDHI GJAKIONDJGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x7106D70", Offset = "0x7105B70", VA = "0x187106D70")]
		protected void FINPLPADFCL(FaceFeatureType HBIIPNPAJOF, float FKHIAEDEHMH, ENGPMKLLDHI GJAKIONDJGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x7109830", Offset = "0x7108630", VA = "0x187109830")]
		public void SetFaceFeatureNormalizedScaleOffset(FaceFeatureType HBIIPNPAJOF, float AEPFNKNJJHB, ENGPMKLLDHI GJAKIONDJGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x7106530", Offset = "0x7105330", VA = "0x187106530")]
		[AsyncStateMachine(typeof(AELPLPHKCFH))]
		protected Task EOCDKMAINCD(ENGPMKLLDHI GJAKIONDJGI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x7107B30", Offset = "0x7106930", VA = "0x187107B30")]
		public void InitializeFaceFeatureStyleSet(ENGPMKLLDHI GJAKIONDJGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x71087A0", Offset = "0x71075A0", VA = "0x1871087A0")]
		protected bool KMFHMBJKKLH(string BJIJOMLAFAJ, [Out] int KNCPCNBMDNF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x71060B0", Offset = "0x7104EB0", VA = "0x1871060B0")]
		protected void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x132C1B0", Offset = "0x132AFB0", VA = "0x18132C1B0", Slot = "8")]
		protected virtual void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x71090D0", Offset = "0x7107ED0", VA = "0x1871090D0")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x710ACC0", Offset = "0x7109AC0", VA = "0x18710ACC0")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x71061F0", Offset = "0x7104FF0", VA = "0x1871061F0")]
		[AsyncStateMachine(typeof(EMKKJHHIMBF))]
		public Task BuildFaceStyleAsyncIfChanged(ENGPMKLLDHI GJAKIONDJGI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x710A5F0", Offset = "0x71093F0", VA = "0x18710A5F0")]
		public void UpdateFaceDisplays(bool IECECFOBCAF = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x7107E60", Offset = "0x7106C60", VA = "0x187107E60")]
		protected bool JDLBIAFBCIK(bool IECECFOBCAF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x710A310", Offset = "0x7109110", VA = "0x18710A310")]
		public void UpdateFaceDisplayFeatureTextures()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x7109E00", Offset = "0x7108C00", VA = "0x187109E00")]
		public void UpdateFaceDisplayFeaturePositions()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x710A800", Offset = "0x7109600", VA = "0x18710A800")]
		public void UpdateFaceJitterMultiplier()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x710A9F0", Offset = "0x71097F0", VA = "0x18710A9F0")]
		public bool UpdateLegacyFaceVectors()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x7106440", Offset = "0x7105240", VA = "0x187106440")]
		protected void DMPMEPKHLKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x7106F50", Offset = "0x7105D50", VA = "0x187106F50")]
		private void GGMAMOHDBGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x710B9B0", Offset = "0x710A7B0", VA = "0x18710B9B0")]
		public PlayerFacialAnimatorBase()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x9226D0", Offset = "0x9214D0", VA = "0x1809226D0", Slot = "4")]
		private bool DDBKHOBDKBO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x7107200", Offset = "0x7106000", VA = "0x187107200")]
		[CompilerGenerated]
		internal static KKINHFDAKCH GJMMLGNMKCK(FaceFeatureType HBIIPNPAJOF, OBIGHNIBKPE P_1)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public struct OCLAFIAMLLO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400046A")]
	public string HIGBIGGFHEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400046B")]
	public int OFAGBBGFDNF;
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	[SelectionBase]
	[ExecuteInEditMode]
	public class PlayerModernBodyEditorAvatarValidator : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x400046C")]
		public const string IDLE_ANIM_NAME = "Idle";

		[Cpp2IlInjected.Token(Token = "0x400046D")]
		public const string A_POSE_ANIM_NAME = "A Pose";

		[Cpp2IlInjected.Token(Token = "0x400046E")]
		public const string ANIMATION_OVERRIDE_STATE_NAME = "Override";

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400046F")]
		public ENGPMKLLDHI avatarBodyType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000471")]
		public Color hairPrimaryColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000472")]
		public Color hairSecondaryColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000473")]
		public Color beardPrimaryColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000474")]
		public Color beardSecondaryColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000475")]
		public Color skinColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000476")]
		public int faceShapeIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000477")]
		public int bodyShapeIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000478")]
		public int hairPatternIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000479")]
		public int beardPatternIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400047A")]
		public AvatarFaceShape[] faceShapes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400047B")]
		public AvatarBodyShape[] bodyShapes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400047C")]
		public AvatarHairPattern[] hairPatterns;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400047D")]
		public float _avatarScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x400047E")]
		public bool enablePosing;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400047F")]
		public int poseIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000480")]
		public AnimationClip animationOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000481")]
		[Range(0f, 4f)]
		public float animationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x4000482")]
		public bool hideEars;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000483")]
		public IOLJGGGKDHL useHelmetHair;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000484")]
		public PACDKMEJBDN hatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000485")]
		public DLJLECMBPJI HatAnchorRestrictions;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000486")]
		public bool UseHairFitMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD1")]
		[Cpp2IlInjected.Token(Token = "0x4000487")]
		public bool usesHatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000488")]
		public GameObject hatPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000489")]
		public GameObject hairPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400048A")]
		public GameObject earPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400048B")]
		public GameObject eyePrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400048C")]
		public GameObject mouthPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400048D")]
		public GameObject neckPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400048E")]
		public GameObject shirtPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400048F")]
		public GameObject beltPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000490")]
		public GameObject shoulderPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000491")]
		public GameObject rightHandPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000492")]
		public GameObject leftHandPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000493")]
		public GameObject legsPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000494")]
		public GameObject feetPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000495")]
		public HFBLFLDOFLG.KLFEKKPPLNK baseSkinCullingMask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x4000496")]
		[EECICDBJENE(ADIKDNKOEBP.Self, false, false, false)]
		[SerializeField]
		public PlayerAvatarDisplayBase _avatarDisplay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4000497")]
		private NJFENNNGEPA HCEOCOHKHNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4000498")]
		[SerializeField]
		[EECICDBJENE(ADIKDNKOEBP.Self, false, false, false)]
		public PlayerFacialAnimatorBase facialAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4000499")]
		public Animator animator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x400049A")]
		public AnimationClip animationClipToOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x400049B")]
		private AnimatorOverrideController ALNOKELBELD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x400049C")]
		private List<KeyValuePair<AnimationClip, AnimationClip>> CFGNIAGOCIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x400049D")]
		public Transform headIKEffector;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x400049E")]
		public Transform leftHandIKEffector;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x400049F")]
		public Transform rightHandIKEffector;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		[Range(0f, 2f)]
		public int lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19C")]
		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		public int rightHandGestureStateIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		[Range(0f, 1f)]
		public float rightHandCurl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A4")]
		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		public int leftHandGestureStateIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x40004A4")]
		[Range(0f, 1f)]
		public float leftHandCurl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1AC")]
		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		public int eyeBrowSelection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		public int eyeSelection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B4")]
		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		public int noseSelection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		public int mouthSelection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1BC")]
		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		public float eyeBrowPositionOffsetHorizontal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x40004AA")]
		public float eyeBrowPositionOffsetVertical;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C4")]
		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		public float eyeBrowScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		public float eyePositionOffsetHorizontal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1CC")]
		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		public float eyePositionOffsetVertical;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		public float eyeScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D4")]
		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		public float nosePositionOffsetVertical;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x40004B0")]
		public float noseScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1DC")]
		[Cpp2IlInjected.Token(Token = "0x40004B1")]
		public float mouthPositionOffsetHorizontal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x40004B2")]
		public float mouthPositionOffsetVertical;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E4")]
		[Cpp2IlInjected.Token(Token = "0x40004B3")]
		public float mouthScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x40004B4")]
		public float hatNormalizedPositionX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1EC")]
		[Cpp2IlInjected.Token(Token = "0x40004B5")]
		public float hatNormalizedPositionY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
		[Cpp2IlInjected.Token(Token = "0x40004B6")]
		public Vector3 hatHemispherePositionOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1FC")]
		[Cpp2IlInjected.Token(Token = "0x40004B7")]
		public Vector3 hatHemisphereRotationOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
		[Cpp2IlInjected.Token(Token = "0x40004B8")]
		public int facialExpressionIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20C")]
		[Cpp2IlInjected.Token(Token = "0x40004B9")]
		[Range(0f, 1f)]
		public float normalizedTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
		[Cpp2IlInjected.Token(Token = "0x40004BA")]
		public readonly OCLAFIAMLLO[] FacialExpressions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
		[Cpp2IlInjected.Token(Token = "0x40004BB")]
		public readonly string[] BodyPoses;

		[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
		[Cpp2IlInjected.Token(Token = "0x40004BC")]
		public readonly (string, LFOHJBFCKOA)[] HandPoses;

		[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
		[Cpp2IlInjected.Token(Token = "0x40004BD")]
		public bool hideLeftWatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x229")]
		[Cpp2IlInjected.Token(Token = "0x40004BE")]
		public bool hideRightWatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x22A")]
		[Cpp2IlInjected.Token(Token = "0x40004BF")]
		protected bool BMMBPKGMHHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x22C")]
		[Cpp2IlInjected.Token(Token = "0x40004C0")]
		protected Guid FEIEJDFMOKO;

		[Cpp2IlInjected.Token(Token = "0x40004C1")]
		protected static Guid COMCIOKJNCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
		[Cpp2IlInjected.Token(Token = "0x40004C2")]
		private PHGIHCICACD OLKPEADKCFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
		[Cpp2IlInjected.Token(Token = "0x40004C3")]
		private EKOHFHHJFFI JAJDLKAKCJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
		[Cpp2IlInjected.Token(Token = "0x40004C4")]
		private CNGDBOGKMMI PAGFBDONEBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
		[Cpp2IlInjected.Token(Token = "0x40004C5")]
		private CNGDBOGKMMI MFHONPEBPPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x40004C6")]
		private AdditionalHatData JJIHONGHPCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
		[Cpp2IlInjected.Token(Token = "0x40004C7")]
		private readonly Dictionary<GameObject, EBDGGFHMAAD> LIHLGJNCDDA;

		[Cpp2IlInjected.Token(Token = "0x170000A4")]
		public static Func<FJKDLOCAAGO> CMCAFBHBADL
		{
			[Cpp2IlInjected.Token(Token = "0x6000385")]
			[Cpp2IlInjected.Address(RVA = "0x7110110", Offset = "0x710EF10", VA = "0x187110110")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000386")]
			[Cpp2IlInjected.Address(RVA = "0x7110770", Offset = "0x710F570", VA = "0x187110770")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		public bool MPFOEDDHLLM
		{
			[Cpp2IlInjected.Token(Token = "0x6000387")]
			[Cpp2IlInjected.Address(RVA = "0x7110270", Offset = "0x710F070", VA = "0x187110270")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A6")]
		public bool EJFHJKHOOEG
		{
			[Cpp2IlInjected.Token(Token = "0x6000388")]
			[Cpp2IlInjected.Address(RVA = "0x7110160", Offset = "0x710EF60", VA = "0x187110160")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A7")]
		public PlayerAvatarDisplayBase OENPCNCMCMG
		{
			[Cpp2IlInjected.Token(Token = "0x600038A")]
			[Cpp2IlInjected.Address(RVA = "0x96DA80", Offset = "0x96C880", VA = "0x18096DA80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A8")]
		protected static Guid DNCFPOOEABD
		{
			[Cpp2IlInjected.Token(Token = "0x600038B")]
			[Cpp2IlInjected.Address(RVA = "0x710DA40", Offset = "0x710C840", VA = "0x18710DA40")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A9")]
		public (GameObject, GKHPEMHLGJO)[] CLGIEKIBJOJ
		{
			[Cpp2IlInjected.Token(Token = "0x60003A1")]
			[Cpp2IlInjected.Address(RVA = "0x7110380", Offset = "0x710F180", VA = "0x187110380")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x710DB30", Offset = "0x710C930", VA = "0x18710DB30")]
		private IEnumerable<GameObject> KLEKGDOCBBN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x710EAD0", Offset = "0x710D8D0", VA = "0x18710EAD0")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x710E070", Offset = "0x710CE70", VA = "0x18710E070")]
		private void PAHFNGKKCPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x1092260", Offset = "0x1091060", VA = "0x181092260")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x710D040", Offset = "0x710BE40", VA = "0x18710D040")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x710EAE0", Offset = "0x710D8E0", VA = "0x18710EAE0")]
		public void Teardown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x710E8D0", Offset = "0x710D6D0", VA = "0x18710E8D0")]
		public void ShowPose(AnimationClip CIFLHHLMPAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x710EAA0", Offset = "0x710D8A0", VA = "0x18710EAA0")]
		public void ShowPose(string CFFPILBLIBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x710E850", Offset = "0x710D650", VA = "0x18710E850")]
		public void ResetPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x710E680", Offset = "0x710D480", VA = "0x18710E680")]
		public void ResetHandPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x710EF40", Offset = "0x710DD40", VA = "0x18710EF40")]
		public void UpdateHandAnimation()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x710EE40", Offset = "0x710DC40", VA = "0x18710EE40")]
		public void UpdateFaceAndBodyShapes(bool BHNACGAPBEO = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x710F1D0", Offset = "0x710DFD0", VA = "0x18710F1D0")]
		public void UpdateNoseShape(KPICGBGFHFC CGMNHCNBGPA, bool BHNACGAPBEO = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x710F1A0", Offset = "0x710DFA0", VA = "0x18710F1A0")]
		public void UpdateLODOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x710D740", Offset = "0x710C540", VA = "0x18710D740", Slot = "4")]
		protected virtual void JEGHIFEIDLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x710CDC0", Offset = "0x710BBC0", VA = "0x18710CDC0", Slot = "5")]
		protected virtual void ECFCMHLENMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x710C1D0", Offset = "0x710AFD0", VA = "0x18710C1D0")]
		public void ApplyHatData(AdditionalHatData HNDLLFHHMIE, bool IDBLDOAMONJ = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x710C010", Offset = "0x710AE10", VA = "0x18710C010")]
		public void ApplyHatAdjustmentsToHatAnchorParams()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x710C530", Offset = "0x710B330", VA = "0x18710C530")]
		public void ApplyHatUVOverride(Vector2 NOMGIIBPNJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x710C450", Offset = "0x710B250", VA = "0x18710C450")]
		public void ApplyHatPositionAdjustment(Vector3 IHJPDHBEMJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x710C4C0", Offset = "0x710B2C0", VA = "0x18710C4C0")]
		public void ApplyHatRotationAdjustment(Vector3 BELAEHDIEKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x710C5A0", Offset = "0x710B3A0", VA = "0x18710C5A0")]
		public ONBJGLMPHMO BuildAvatarItemSelection(GameObject MMBGLGBGIFE, ENGPMKLLDHI PFHDLGLIBDB, GKHPEMHLGJO IIMJDGJFDCN)
		{
			return default(ONBJGLMPHMO);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x710C640", Offset = "0x710B440", VA = "0x18710C640")]
		public void BuildAvatar(bool BHNACGAPBEO = false, bool IDBLDOAMONJ = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x710C150", Offset = "0x710AF50", VA = "0x18710C150")]
		public void ApplyHatAnchor()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x710EFF0", Offset = "0x710DDF0", VA = "0x18710EFF0")]
		public void UpdateHatAnchor(bool IDBLDOAMONJ = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0x710E150", Offset = "0x710CF50", VA = "0x18710E150")]
		private void PDFHFHKCHIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40")]
		private void HOKFKJPMFMB(EBDGGFHMAAD IHPLBGGEMDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40")]
		private void JPAMHICEMOF(EBDGGFHMAAD IHPLBGGEMDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0x710D030", Offset = "0x710BE30", VA = "0x18710D030")]
		private void GOCNJBAABJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x710F260", Offset = "0x710E060", VA = "0x18710F260")]
		public PlayerModernBodyEditorAvatarValidator()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0x710DFC0", Offset = "0x710CDC0", VA = "0x18710DFC0")]
		[CompilerGenerated]
		private ONBJGLMPHMO MLMOMCNICKC((GameObject, GKHPEMHLGJO) JBHDOIFICLP)
		{
			return default(ONBJGLMPHMO);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	public class SkinnedMeshBonesInspector : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004CB")]
		[SerializeField]
		[EECICDBJENE(ADIKDNKOEBP.Self, false, false, false)]
		private SkinnedMeshRenderer skinnedMeshRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004CC")]
		[SerializeField]
		private int BoneWeightsDisplayStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40004CD")]
		[SerializeField]
		private int BoneWeightsDisplayAmount;

		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x8F6D30", Offset = "0x8F5B30", VA = "0x1808F6D30")]
		public SkinnedMeshBonesInspector()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public struct ONBJGLMPHMO
{
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	[CompilerGenerated]
	private sealed class GKDCLKBDLDB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004D0")]
		public IEnumerable<OutfitType> otherOutfitTypes;

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public GKDCLKBDLDB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x7100BA0", Offset = "0x70FF9A0", VA = "0x187100BA0")]
		internal bool GEHKOHDDNPC(OutfitType outfitType)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004CE")]
	private EBDGGFHMAAD BBKHHFBMLLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004CF")]
	private GKHPEMHLGJO HOPNBDPIDEO;

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public EBDGGFHMAAD OAJDBJMKDOD
	{
		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0xBE6020", Offset = "0xBE4E20", VA = "0x180BE6020")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public GKHPEMHLGJO JABAKEOGIPH
	{
		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x2533EA0", Offset = "0x2532CA0", VA = "0x182533EA0")]
		get
		{
			return default(GKHPEMHLGJO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public string HHLCFCKFPAL
	{
		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x71054E0", Offset = "0x71042E0", VA = "0x1871054E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public bool BPKANDPIOLI
	{
		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x7104F30", Offset = "0x7103D30", VA = "0x187104F30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public bool AIHNKANEGIM
	{
		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x7104F80", Offset = "0x7103D80", VA = "0x187104F80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0xAFEA80", Offset = "0xAFD880", VA = "0x180AFEA80")]
	public ONBJGLMPHMO(EBDGGFHMAAD IHPLBGGEMDP, GKHPEMHLGJO DNGHOGLAIFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x7104FD0", Offset = "0x7103DD0", VA = "0x187104FD0")]
	public bool GENDHJMMPPH(OutfitType CPOLNKIDINC, GKHPEMHLGJO MKAKOJFEIAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x7105090", Offset = "0x7103E90", VA = "0x187105090")]
	public bool IHNMEPDDMPE(OutfitType CPOLNKIDINC, GKHPEMHLGJO MKAKOJFEIAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x71052F0", Offset = "0x71040F0", VA = "0x1871052F0")]
	public bool OBAIEPIAJNA(ONBJGLMPHMO BMFGGINJOBI)
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
