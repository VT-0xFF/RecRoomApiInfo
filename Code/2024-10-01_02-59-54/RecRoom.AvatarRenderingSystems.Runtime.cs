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
using RecRoom.Avatars.Data.Shared;
using RecRoom.Core.Studio;
using RecRoom.DataLayer.Attributes;
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
	public class LogRegistrationIndex : OACCHOKJOKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6C6CFE0", Offset = "0x6C6C3E0", VA = "0x186C6CFE0", Slot = "4")]
		public override void PFLPBBOAAPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8D4B40", Offset = "0x8D3F40", VA = "0x1808D4B40")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_AvatarRenderingSystems_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : GADMOBJFAOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6C719E0", Offset = "0x6C70DE0", VA = "0x186C719E0", Slot = "8")]
		public override void NALDPPFDOAA(JBGBENDLNHF registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x64A1D70", Offset = "0x64A1170", VA = "0x1864A1D70")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class RecNetCDNAssetReference : AssetReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private RecNetCDNKey key;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override object RuntimeKey
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x8A9D20", Offset = "0x8A9120", VA = "0x1808A9D20", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override string AssetGUID
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x6C71120", Offset = "0x6C70520", VA = "0x186C71120", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6C71040", Offset = "0x6C70440", VA = "0x186C71040", Slot = "17")]
		public override bool RuntimeKeyIsValid()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6C710E0", Offset = "0x6C704E0", VA = "0x186C710E0")]
		public RecNetCDNAssetReference(RecNetCDNKey GMJINMLEEAC)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
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
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x8AA330", Offset = "0x8A9730", VA = "0x1808AA330")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x8AA350", Offset = "0x8A9750", VA = "0x1808AA350")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public string CacheHash
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x8AA340", Offset = "0x8A9740", VA = "0x1808AA340")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x8A9F60", Offset = "0x8A9360", VA = "0x1808A9F60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6C71160", Offset = "0x6C70560", VA = "0x186C71160")]
		public static RecNetCDNKey POMFPEDEMOK(string JGJCAFEOEGB, string GBGLMAMNJOK = "")
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x645B690", Offset = "0x645AA90", VA = "0x18645B690")]
		public void KFCKNPDIMMK(string PPOGIAIKFHA, string EIIBADICFOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6C71260", Offset = "0x6C70660", VA = "0x186C71260")]
		public RecNetCDNKey()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[NFAHBLEIIKC]
public class IEHEEBMCNAH : HIFEFINPBGC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	protected readonly List<Mesh> EINIOGJJGDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	protected readonly List<byte[]> HCOGMAGJJGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	protected readonly List<Matrix4x4> NCCEMIOCFAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	protected readonly List<bool> PHDMEFGLMCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	protected readonly List<int> OJAMOIPBJMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	protected readonly List<bool> MNLMBMMOGPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	protected readonly List<int> NLOCBHFKIPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	protected Allocator DODNLFPLMGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	protected HOGMIIMLKEI PBAGNIBBBAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	protected byte EIBPOHNDHOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	protected IList<int> CNAFLEJFIMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	protected IList<int> LPOFKDKKKHJ;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6C6BEA0", Offset = "0x6C6B2A0", VA = "0x186C6BEA0", Slot = "4")]
	public void NFAIFEDKEOB(Mesh JIPKNCLPFGJ, Matrix4x4 CLELPODBLMJ, byte[] LAIJLNPOIBL, bool FCDDNDDHDGP = false, CLCNDMDBJIL.ACBJNAIFGMN PHPJNPIDFGB = (CLCNDMDBJIL.ACBJNAIFGMN)0, int NOILLGHJOBB = -1, bool BBGLLLCKEBL = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6C6BC10", Offset = "0x6C6B010", VA = "0x186C6BC10", Slot = "5")]
	public void GNPIMCLBNOM(Allocator MGFIHPDNFPH, HOGMIIMLKEI LJHFGKCNDIL, byte PIAOLLLOPGI, [Optional] IList<int> CMNKJKDKNCP, [Optional] IList<int> CJNGCKLANIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6C6BC50", Offset = "0x6C6B050", VA = "0x186C6BC50")]
	private static void MCFNHBDCPAA(Mesh JIPKNCLPFGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6C6C0B0", Offset = "0x6C6B4B0", VA = "0x186C6C0B0")]
	public IEHEEBMCNAH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[NFAHBLEIIKC]
public struct EIOGBDGCJKB : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	[ReadOnly]
	public OGCCKAJDBIA OHDNOKJBFGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	[ReadOnly]
	public int JAFGJMJABKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public AHBAJDECDGN DMBCHNMDNML;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6C69C70", Offset = "0x6C69070", VA = "0x186C69C70", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[NativeContainer]
[NFAHBLEIIKC]
public struct AHBAJDECDGN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct IAIMKCIPNIC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public Vector3 EBEHBHDGHPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public Vector3 JNKEFPKOLCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public Vector4 DELILHLDNMB;
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct HDONGACMDBI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public float AMHPDMMLBFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public float CLIPBHPBBIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public float ELGLBJHABLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public float DKKCFOFDLJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public byte DCAGFHIFMCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public byte JMINNBLNMPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public byte PIFGFFAEDMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public byte IGGBFPBMNJM;
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct FLNPNBEBEDG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public half AMHPDMMLBFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public half CLIPBHPBBIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public half ELGLBJHABLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public half DKKCFOFDLJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public byte DCAGFHIFMCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public byte JMINNBLNMPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public byte PIFGFFAEDMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public byte IGGBFPBMNJM;
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct MIJFMPEIEDL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public half4 DFKHKPKCOFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public half2 POHFDHHLAGN;
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public struct OIFDJHOFAOO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public half4 DFKHKPKCOFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public half2 POHFDHHLAGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public half2 NPKLEPKCGPL;
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct LNMCMEMAAGP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public half4 DFKHKPKCOFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public half2 POHFDHHLAGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public half2 NPKLEPKCGPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public half2 GCLCLNGOBFP;
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public struct HKGMKAKNHBC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public half4 DFKHKPKCOFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public half2 POHFDHHLAGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public half2 NPKLEPKCGPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public half2 GCLCLNGOBFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public half2 ALOJCGKAKBB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public struct JFNAPELNJMM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public float AMHPDMMLBFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public float CLIPBHPBBIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public float ELGLBJHABLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public float DKKCFOFDLJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public int DCAGFHIFMCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public int JMINNBLNMPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public int PIFGFFAEDMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public int IGGBFPBMNJM;
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public struct EEDOHJBEDCO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public Color DFKHKPKCOFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public Vector2 POHFDHHLAGN;
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public struct LKHBOOAJFLI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public Color DFKHKPKCOFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public Vector2 POHFDHHLAGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public Vector2 NPKLEPKCGPL;
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public struct EFAICAEBIPH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public Color DFKHKPKCOFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public Vector2 POHFDHHLAGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public Vector2 NPKLEPKCGPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public Vector2 GCLCLNGOBFP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public struct GCDMDIMCNJK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public Color DFKHKPKCOFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Vector2 POHFDHHLAGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public Vector2 NPKLEPKCGPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public Vector2 GCLCLNGOBFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Vector2 ALOJCGKAKBB;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private bool DFKDFOBLFLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public NativeArray<IAIMKCIPNIC> BONHHJCFBGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public NativeArray<MIJFMPEIEDL> HMHAKGEMOLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public NativeArray<OIFDJHOFAOO> IBBHMNEBIDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public NativeArray<LNMCMEMAAGP> CEHCOIJOAAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public NativeArray<HKGMKAKNHBC> DGFFBGPHAFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public NativeArray<FLNPNBEBEDG> IABEIAMLLKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public NativeArray<HDONGACMDBI> IFFEPHOOJPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public NativeArray<EEDOHJBEDCO> OLIIEHIKNAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public NativeArray<LKHBOOAJFLI> ADAJNIDKMIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public NativeArray<EFAICAEBIPH> CPGCEBOCGEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public NativeArray<GCDMDIMCNJK> COOMMLMNDFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public NativeArray<JFNAPELNJMM> GDHDGOENGME;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public NativeArray<int> EANCDMKBJJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public NativeArray<int> CJCKCFHMOCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private NativeArray<int> PPDPFFBPHNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private NativeArray<int> CELKBPNAMED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public NativeArray<int> HJABOGPHIGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public NativeArray<int> AGHMBAFFJLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public NativeArray<int> GCMKMDGNHCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public NativeArray<BoneWeight> HFOOCANKBBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private NativeArray<int> AFAEKDPMCFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private bool BOPJLCPNBGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x159")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private bool HEKHIHLBLJP;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int OEDNIFABHNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6C5AC80", Offset = "0x6C5A080", VA = "0x186C5AC80")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6C59770", Offset = "0x6C58B70", VA = "0x186C59770")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int BGIJJJLBCKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6C5BAC0", Offset = "0x6C5AEC0", VA = "0x186C5BAC0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6C5B670", Offset = "0x6C5AA70", VA = "0x186C5B670")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int EJODNNEMHJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6C5AC10", Offset = "0x6C5A010", VA = "0x186C5AC10")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6C5AEF0", Offset = "0x6C5A2F0", VA = "0x186C5AEF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int KPOIONFLGJO
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6C59780", Offset = "0x6C58B80", VA = "0x186C59780")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6C5BAD0", Offset = "0x6C5AED0", VA = "0x186C5BAD0")]
	public AHBAJDECDGN(int EFBGMAKMMFP, int IBJMCGKFFLP, int GKFJONKEGIA, int KHCLKDAKNBO, Allocator MGFIHPDNFPH, int FEFHBMLGFAN, CACEEKJFPMO ENPPMNKLCBJ, bool BOPJLCPNBGB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6C5B680", Offset = "0x6C5AA80", VA = "0x186C5B680")]
	public void MMEIIJKMDEC(int AEAHMAMPNLO, Vector3 IDIHIILANOF, Vector3 DNDOEPAKCMB, Vector4 HIKBGGAGLAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6C5B240", Offset = "0x6C5A640", VA = "0x186C5B240")]
	public void HBDHJADPENJ(int AEAHMAMPNLO, BoneWeight JHKDCNBCAIL, NativeSlice<byte> LAIJLNPOIBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6C5AF10", Offset = "0x6C5A310", VA = "0x186C5AF10")]
	public Color GHMGIFIGDEN(int AEAHMAMPNLO)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6C597F0", Offset = "0x6C58BF0", VA = "0x186C597F0")]
	public void BIGBJKCEFFH(int AEAHMAMPNLO, Color HPAGGPJLKCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6C5B710", Offset = "0x6C5AB10", VA = "0x186C5B710")]
	public void PGJGFICNGDI(byte OFGJCDMACKB, int AEAHMAMPNLO, Vector2 KIBNMJBDOIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6C5AF00", Offset = "0x6C5A300", VA = "0x186C5AF00")]
	public void FNJGJMGHEMN(int AEAHMAMPNLO, int CHHDLCDBKOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6C5AC20", Offset = "0x6C5A020", VA = "0x186C5AC20")]
	public bool DDFMGNEHIAI(int OFGJCDMACKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6C5AB40", Offset = "0x6C59F40", VA = "0x186C5AB40")]
	public void CBAENGMMGFM(int MIMLBNAMKDF, int GMCJIJBLJPF, int IDHDBIDGMFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6C5AC90", Offset = "0x6C5A090", VA = "0x186C5AC90", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6C59BF0", Offset = "0x6C58FF0", VA = "0x186C59BF0")]
	public Mesh CAIJLJDCELG([Optional] string DCOHAAJFDDD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[NativeContainer]
[NFAHBLEIIKC]
[DefaultMember("Item")]
public struct OGCCKAJDBIA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public Mesh.MeshDataArray HLNMKLBKMDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public NativeArray<int> JIEDOBONJHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public NativeArray<int> NEJKHGMFIIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public NativeArray<BoneWeight> HFOOCANKBBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private NativeArray<Matrix4x4> JCLKJLCJBDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private NativeArray<int> CFLGCJBKDNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private NativeArray<byte> AEONPLIFPMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private NativeArray<int> FPCCPBEFLFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private NativeArray<int> DADJPCBDBKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public NativeArray<sbyte> ALLLEIPCCFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public NativeArray<byte> CBOHPCADHEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public NativeArray<bool> BBGLLLCKEBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public NativeArray<int> NOILLGHJOBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private bool BOPJLCPNBGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private NativeArray<int> KFGKLJIGEPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private bool HEKHIHLBLJP;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public int LKMHPDCLFHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6C6D7C0", Offset = "0x6C6CBC0", VA = "0x186C6D7C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int LNFCBCFJINJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6C6DA50", Offset = "0x6C6CE50", VA = "0x186C6DA50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int EIMLLNKOAID
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6C6D550", Offset = "0x6C6C950", VA = "0x186C6D550")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int HDHLCJHOPJN
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6C6D460", Offset = "0x6C6C860", VA = "0x186C6D460")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6C6D470", Offset = "0x6C6C870", VA = "0x186C6D470")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int OEDNIFABHNB
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6C6D630", Offset = "0x6C6CA30", VA = "0x186C6D630")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x6C6D450", Offset = "0x6C6C850", VA = "0x186C6D450")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int GCLABMMKGEK
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x6C6D7F0", Offset = "0x6C6CBF0", VA = "0x186C6D7F0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x6C6D7E0", Offset = "0x6C6CBE0", VA = "0x186C6D7E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public HOGMIIMLKEI FFIFJCMJKJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6C6D7D0", Offset = "0x6C6CBD0", VA = "0x186C6D7D0")]
		get
		{
			return default(HOGMIIMLKEI);
		}
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6C6D440", Offset = "0x6C6C840", VA = "0x186C6D440")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public byte GNJEHKAHMFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6C6D7B0", Offset = "0x6C6CBB0", VA = "0x186C6D7B0")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6C6D620", Offset = "0x6C6CA20", VA = "0x186C6D620")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public BNCCKCPKKPL CPCAOKGGKKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6C6D800", Offset = "0x6C6CC00", VA = "0x186C6D800")]
		get
		{
			return default(BNCCKCPKKPL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6C6DA60", Offset = "0x6C6CE60", VA = "0x186C6DA60")]
	public OGCCKAJDBIA(IList<Mesh> FIOEKKGBMLO, IList<Matrix4x4> KIFBOHBJGKO, IList<bool> BBGLLLCKEBL, byte PIAOLLLOPGI, IList<byte[]> PCMPIBKHCLM, IList<int> DFLAOFJNHJC, IList<bool> ECDGLJCDNEA, IList<int> NOILLGHJOBB, IList<int> CMNKJKDKNCP, IList<int> CMCLFIEFBCL, Allocator MGFIHPDNFPH, HOGMIIMLKEI LJHFGKCNDIL, bool BOPJLCPNBGB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6C6D480", Offset = "0x6C6C880", VA = "0x186C6D480")]
	public AHBAJDECDGN CDPPDEPCJDK(Allocator MGFIHPDNFPH, CACEEKJFPMO ENPPMNKLCBJ)
	{
		return default(AHBAJDECDGN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6C6D640", Offset = "0x6C6CA40", VA = "0x186C6D640", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[NFAHBLEIIKC]
public class NPCKDOLHKEL : IEHEEBMCNAH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public bool ICKAHJHJHKD;

	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private static readonly ProfilerMarker MHFAIPMENAA;

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6C6D130", Offset = "0x6C6C530", VA = "0x186C6D130")]
	public OGCCKAJDBIA NAAEKGOAEHK()
	{
		return default(OGCCKAJDBIA);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6C6D430", Offset = "0x6C6C830", VA = "0x186C6D430")]
	public NPCKDOLHKEL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct BNCCKCPKKPL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public Mesh.MeshData OKMDDJMOAGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public NativeSlice<BoneWeight> HFOOCANKBBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public NativeSlice<byte> ANOIAFKLAHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public int MLDAHMCENAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public Matrix4x4 HOECJKKEKMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public int DAHDHEOOPFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public NativeSlice<byte> LAIJLNPOIBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public bool PDPMOPJPFKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public int HPFNGBMFFNN;
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class BIAPNLKMOKL : EGBNLLANDDL
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	private abstract class POEBAPONENH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public readonly KJCIGENAPJO MJKOMGDINNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		protected bool AADOPFGBMKH;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public virtual bool FFECABGGEIO
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x8F3EB0", Offset = "0x8F32B0", VA = "0x1808F3EB0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public virtual bool HLLBFILPEMN
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x8F3EB0", Offset = "0x8F32B0", VA = "0x1808F3EB0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public virtual CLCNDMDBJIL.ACBJNAIFGMN DAHDHEOOPFA
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x8ABE40", Offset = "0x8AB240", VA = "0x1808ABE40", Slot = "6")]
			get
			{
				return default(CLCNDMDBJIL.ACBJNAIFGMN);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public bool CPNEHELOFGP
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0xC21260", Offset = "0xC20660", VA = "0x180C21260")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public bool OCALLMHONIO
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x199DE20", Offset = "0x199D220", VA = "0x18199DE20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public bool MMILHBEAGFE
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x6C71010", Offset = "0x6C70410", VA = "0x186C71010")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public bool FAKHPEDDGPF
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x6C71020", Offset = "0x6C70420", VA = "0x186C71020")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x8AD680", Offset = "0x8ACA80", VA = "0x1808AD680")]
		protected POEBAPONENH(KJCIGENAPJO KMGIIEFCMKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract AOFGCNMIPIP OGNKIFHBMCG(int[] OKHAGJIJEGE, List<PLAOPNDIDAJ> JPHHHHMANCH, List<PLAOPNDIDAJ> MAKOHBDJHAA);

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract LDDIMMPCJHE EIHLKPDKHOJ(uint KFELJFNOKBH, AvatarSkinnedMeshBoneOrderRemapsData AKMMAOHIHCL);
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	private class LNNCLKKMBEG : POEBAPONENH
	{
		[Cpp2IlInjected.Token(Token = "0x200001C")]
		[CompilerGenerated]
		private sealed class EDEJAKOPAPE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000DE")]
			public FLIAEPPCPCN<GameObject> skinAvatarItemPrefabHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000DF")]
			public LNNCLKKMBEG <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
			public EDEJAKOPAPE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x6C69880", Offset = "0x6C68C80", VA = "0x186C69880")]
			internal void ECKNFBKHABJ(GameObject result)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private readonly AvatarSkinAssetItem.OLLNLCGFODJ FEFPPOGDMLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private readonly AssetReference JMHCPDOBAJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private readonly CLCNDMDBJIL.ACBJNAIFGMN FLOBKAIFKIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private readonly LGPPHCHPBNO? IIJDABMDCKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private readonly Material[] LFKGOLKGOFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		private SkinnedMeshRenderer[] GHHFNFOGBJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private AvatarSkinAssetItem CLNEOKAIKLM;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override CLCNDMDBJIL.ACBJNAIFGMN DAHDHEOOPFA
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x8AEC60", Offset = "0x8AE060", VA = "0x1808AEC60", Slot = "6")]
			get
			{
				return default(CLCNDMDBJIL.ACBJNAIFGMN);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x6C6CDC0", Offset = "0x6C6C1C0", VA = "0x186C6CDC0")]
		public LNNCLKKMBEG(AvatarSkinAssetItem.OLLNLCGFODJ PKIKBBLAEMC, AssetReference OJAFOHKLILG, Material LBJFMGCJNMM, KJCIGENAPJO FHPOINKIBOO, CLCNDMDBJIL.ACBJNAIFGMN KENOKEDHMMH = (CLCNDMDBJIL.ACBJNAIFGMN)0, [Optional] LGPPHCHPBNO? KBBOBOKLEJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x6C6CED0", Offset = "0x6C6C2D0", VA = "0x186C6CED0")]
		public LNNCLKKMBEG(AvatarSkinAssetItem.OLLNLCGFODJ PKIKBBLAEMC, AssetReference OJAFOHKLILG, Material LBJFMGCJNMM, CLCNDMDBJIL.ACBJNAIFGMN KENOKEDHMMH = (CLCNDMDBJIL.ACBJNAIFGMN)0, [Optional] LGPPHCHPBNO? KBBOBOKLEJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x6C6CB80", Offset = "0x6C6BF80", VA = "0x186C6CB80", Slot = "7")]
		public override AOFGCNMIPIP OGNKIFHBMCG(int[] OKHAGJIJEGE, List<PLAOPNDIDAJ> JPHHHHMANCH, List<PLAOPNDIDAJ> MAKOHBDJHAA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x6C6C8A0", Offset = "0x6C6BCA0", VA = "0x186C6C8A0", Slot = "8")]
		public override LDDIMMPCJHE EIHLKPDKHOJ(uint KFELJFNOKBH, AvatarSkinnedMeshBoneOrderRemapsData AKMMAOHIHCL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x6C6CD50", Offset = "0x6C6C150", VA = "0x186C6CD50", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	private class BOEKKIEBHIM : POEBAPONENH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public readonly DEAOOHKMGJJ EJFMHEOOKGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private FLIAEPPCPCN<GGDKMGBLBOG> PGFPPILFIOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public GGDKMGBLBOG GCOEFHJPGGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private FLIAEPPCPCN<Material[]> BACKBLDFJHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public Material[] OPAFOHGDDME;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public override bool FFECABGGEIO
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x8C5960", Offset = "0x8C4D60", VA = "0x1808C5960", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override bool HLLBFILPEMN
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x6C691A0", Offset = "0x6C685A0", VA = "0x186C691A0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x6C697A0", Offset = "0x6C68BA0", VA = "0x186C697A0")]
		public BOEKKIEBHIM(KJCIGENAPJO KMGIIEFCMKO, DEAOOHKMGJJ FFJOJPPNMFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x6C692C0", Offset = "0x6C686C0", VA = "0x186C692C0", Slot = "7")]
		public override AOFGCNMIPIP OGNKIFHBMCG(int[] OKHAGJIJEGE, List<PLAOPNDIDAJ> JPHHHHMANCH, List<PLAOPNDIDAJ> MAKOHBDJHAA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x6C68B00", Offset = "0x6C67F00", VA = "0x186C68B00", Slot = "8")]
		public override LDDIMMPCJHE EIHLKPDKHOJ(uint KFELJFNOKBH, AvatarSkinnedMeshBoneOrderRemapsData AKMMAOHIHCL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x6C68C30", Offset = "0x6C68030", VA = "0x186C68C30")]
		public LDDIMMPCJHE GOOLEIKNOID(GameObject HAHMOCFDLHE, uint KFELJFNOKBH, bool JKFJGBLKNCN, bool EICONIPJCPF, AvatarSkinnedMeshBoneOrderRemapsData AKMMAOHIHCL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x6C68E40", Offset = "0x6C68240", VA = "0x186C68E40")]
		public static bool HCAEFHIMMKP(Renderer[] AKDGFCJCAMD, string PLHEJFDLDCM, [Out] Renderer JBFFHPDHCPM, [Out] Renderer FBKLDLCCKKI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x6C69750", Offset = "0x6C68B50", VA = "0x186C69750", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x6C69200", Offset = "0x6C68600", VA = "0x186C69200")]
		private (FLIAEPPCPCN<GGDKMGBLBOG>, FLIAEPPCPCN<Material[]>) LHHDFCLFGKF()
		{
			return default((FLIAEPPCPCN<GGDKMGBLBOG>, FLIAEPPCPCN<Material[]>));
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x4637520", Offset = "0x4636920", VA = "0x184637520")]
		[CompilerGenerated]
		private void KMHFOAJKINN(GGDKMGBLBOG CIFMGKBFCHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x8A9EF0", Offset = "0x8A92F0", VA = "0x1808A9EF0")]
		[CompilerGenerated]
		private void PEAILAJIAEK(Material[] CIFMGKBFCHA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class PLNLHNPEFJH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public PACGBHKHAOH avatarBuildParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public BIAPNLKMOKL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public LMEMMAHKEDK buildMeshPromise;

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public PLNLHNPEFJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x6C70E60", Offset = "0x6C70260", VA = "0x186C70E60")]
		internal bool ANIINKNEEDF(DEAOOHKMGJJ item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x6C70EB0", Offset = "0x6C702B0", VA = "0x186C70EB0")]
		internal void BFKCDIMPHAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x6C70ED0", Offset = "0x6C702D0", VA = "0x186C70ED0")]
		internal void CMIAGHLMNGE(string err)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x6C70F80", Offset = "0x6C70380", VA = "0x186C70F80")]
		internal void ONLIODHGOFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x6C70EF0", Offset = "0x6C702F0", VA = "0x186C70EF0")]
		internal void MFIELDOEDNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x8AA330", Offset = "0x8A9730", VA = "0x1808AA330")]
		internal AOFGCNMIPIP NKGJNKCIBLM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class MMJGDBHLOKI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public int lowestPossibleLOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public PLNLHNPEFJH CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public MMJGDBHLOKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x6C6D070", Offset = "0x6C6C470", VA = "0x186C6D070")]
		internal PJKEKENBJPN FAGLGNAOHOP(int lod)
		{
			return default(PJKEKENBJPN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class IKEHHGIFHNJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public List<LMEMMAHKEDK> innerPromises;

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public IKEHHGIFHNJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x6C6C2E0", Offset = "0x6C6B6E0", VA = "0x186C6C2E0")]
		internal void PDMODLMHGIO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class JKLKAJBGKNE : IEnumerator<BGFGBHFIDBJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private BGFGBHFIDBJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public BIAPNLKMOKL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public List<POEBAPONENH> parts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public int[] LODs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public List<LMEMMAHKEDK> innerPromises;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public bool isFirstPerson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public Func<int, PJKEKENBJPN> getLayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public MNOCKKLFKAN materialPropertyBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public Material materialInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private int <lodIndex>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		private BGFGBHFIDBJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x8A9F10", Offset = "0x8A9310", VA = "0x1808A9F10", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x8A9F10", Offset = "0x8A9310", VA = "0x1808A9F10", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x8AD680", Offset = "0x8ACA80", VA = "0x1808AD680")]
		[DebuggerHidden]
		public JKLKAJBGKNE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x6C6C410", Offset = "0x6C6B810", VA = "0x186C6C410", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x6C6C610", Offset = "0x6C6BA10", VA = "0x186C6C610", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class HCPBGGFCMKG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public int[] LODs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public BIAPNLKMOKL <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public HCPBGGFCMKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x6C6BBC0", Offset = "0x6C6AFC0", VA = "0x186C6BBC0")]
		internal AOFGCNMIPIP MJHLOHDAJEO(POEBAPONENH p)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class MMBBMBFDOBA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public BEKPIOKEOJH cancelable;

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public MMBBMBFDOBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0xA61D30", Offset = "0xA61130", VA = "0x180A61D30")]
		internal void LFEDKIPEFIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0xD37160", Offset = "0xD36560", VA = "0x180D37160")]
		internal void FCBCPPLJBFH(string err)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class BJGJLLOKEAL
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
		public BIAPNLKMOKL <>4__this;

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

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public BJGJLLOKEAL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class LDLCLPFDMPC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public bool waitingForComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public JobHandle lodBuildJobHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public AHBAJDECDGN defaultMeshJobContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public OGCCKAJDBIA defaultAvatarMeshJobGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public BJGJLLOKEAL CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public LDLCLPFDMPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x6C6C660", Offset = "0x6C6BA60", VA = "0x186C6C660")]
		internal void OOLINKGBBCC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0xD3E0D0", Offset = "0xD3D4D0", VA = "0x180D3E0D0")]
		internal void NGAHDPIDHFN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private sealed class AONGMHCNPCE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public bool waitingForComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public JobHandle lodBuildJobHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public CDINAJPLLHP legacyMeshJobContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public IMFELMECEMJ legacyAvatarMeshJobGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public BJGJLLOKEAL CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public AONGMHCNPCE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x6C5C500", Offset = "0x6C5B900", VA = "0x186C5C500")]
		internal void IFECMEHJJPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0xD34600", Offset = "0xD33A00", VA = "0x180D34600")]
		internal void PPNAIFPLBNA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class GGDFLFCNOOB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public KeyValuePair<string, DEAOOHKMGJJ> entry;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public BEKPIOKEOJH cancelablePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public DEAOOHKMGJJ avatarItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public BIAPNLKMOKL <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public GGDFLFCNOOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x6C6B790", Offset = "0x6C6AB90", VA = "0x186C6B790")]
		internal AOFGCNMIPIP OHMFJICLOHG(KHMIFHAEBNK item)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x6C6B750", Offset = "0x6C6AB50", VA = "0x186C6B750")]
		internal void MCBFNECMAIN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class ACCHBDAJFBF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public FLIAEPPCPCN<Texture2D> resourceHandle;

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public ACCHBDAJFBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x6C59720", Offset = "0x6C58B20", VA = "0x186C59720")]
		internal void NOMBODFODCJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class CJGHDCGKAFG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public string overrideItemIdentifier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public KJCIGENAPJO overrideBodyPart;

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public CJGHDCGKAFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x6C69800", Offset = "0x6C68C00", VA = "0x186C69800")]
		internal bool LIOFAEGPKOG(KeyValuePair<string, DEAOOHKMGJJ> entry)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private AvatarConfiguration EPAAIIDKPIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private Transform BJFCCDDEHLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private AssetReference JMHCPDOBAJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private GameObject LLLHAFADOOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private GameObject ALKEKKDMKKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private SkinnedMeshRenderer CMLNBPHMNFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private AvatarSkinnedMeshBoneOrderRemapsData DJJCKGLACGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private Transform[] PHMMONPKHDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private Matrix4x4[] HMLAIMOFFMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private Material BBJFOGMFDED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private Material PEPMEOOGCGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private Material FOAMPCJBBMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private Shader CNHFHMJGHIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private Shader DBPCJPCHOMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private Animator KCEDOIDJDLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private Renderer[] OJCEJMJLLNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private CLCNDMDBJIL.ACBJNAIFGMN OICFIMPBFJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private AvatarBodyPartShapesManager NNJPHHHALDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private IReadOnlyDictionary<string, Transform> BKFGIJDKLFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private AvatarFaceShapeData.MKLPGALLHKN ACFFHNJOKLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private AvatarBodyShapeData.ICIMIPNNLLM NBFJFKGHLDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private bool PCDLMEHIKMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB1")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private bool HPKOEBLLKFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private Color OCKBLAALOPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private Color CFDNBBKIAFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private Color JFPPGIKAKCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private Color? OLPNOLCKMEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private Color? MKFIPGIHLCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10C")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private Color? HJNPJBGEDLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private Color? FGOHGDJGJOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private Texture2D MHPPOCKMCFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private Texture2D JIILAIKDLOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	[CanBeNull]
	private DEAOOHKMGJJ AOGIDCIKAKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private Texture BHOFNAFDCKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private Color EOFCNICEDGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public Dictionary<Renderer, MNOCKKLFKAN> MPLCBMDIMJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private Dictionary<Renderer, MNOCKKLFKAN> DFILLBGEMJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private Dictionary<string, List<DFLGCJKJBHM>> LOFAMFELPON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private Dictionary<string, List<DFLGCJKJBHM>> NENOFJEAIPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private readonly List<PLAOPNDIDAJ> AKGKCHHJIDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private readonly List<PLAOPNDIDAJ> PKDBEBENBGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly List<PLAOPNDIDAJ> MGLBNPCFFHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private readonly List<PLAOPNDIDAJ> PMGEHPFKOOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private Dictionary<DFLGCJKJBHM, Material> DLCKLMDKJLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private Dictionary<DFLGCJKJBHM, Material> BACBNCOOPKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private SkinnedMeshRenderer[] CFBDODHAIJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private SkinnedMeshRenderer[] BGCOAEFJJEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private SkinnedMeshRenderer[] DJLEEBBDJHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private SkinnedMeshRenderer[] NDJJOPLKPAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private readonly Dictionary<string, FLIAEPPCPCN<Texture2D>> KJBHPDMKBGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private readonly Dictionary<string, FLIAEPPCPCN<Texture2D>> GEPMMHPCJFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private AdditionalHatData NKAJOGJMDCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private AdditionalHatData DFCMMCCNCCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private HairData GNIIEPFECDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private HairData BNELCBCJNIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private PIMBILBNCGP PABCOLLGHMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private bool? NBEBGFNCPEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x214")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private PositionAndRotation EDNMCAJHMPJ;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private Material HKIOHBKMMAD;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private Material MIGLMICHKIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private Dictionary<string, DEAOOHKMGJJ> PLLLFIAIMNM;

	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private static readonly int PHLDBHNKPJN;

	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private static readonly int GDNCAHINCJD;

	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private static readonly int BDJCDCBAGIK;

	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private static readonly int IGHNLPPOLKN;

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private static readonly int NELLEMLHAIH;

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private static readonly int JKOKFCGKDGE;

	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private static readonly int BONAHFKAPGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private readonly LKILNMKOKHH KEEHLDOMNHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private readonly LKILNMKOKHH JAJAJBPALKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private bool GAIIKNKCFMB;

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private static Lazy<CCENJGFOMNL> DDEODOKIJEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private Lazy<GALJFDPIMHI> IIOKGKGEFFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private Lazy<FHADNFKMJFJ> EAMIOHLMNLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private KKELKFJEAOL AEBBLHPIMLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private List<Action> CHOEGNAAMLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private LLHBFJIDBOE GFFFEMBPKJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private SkinnedMeshRenderer[] DLENMIOIINO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private int LIAGLEBNJKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x294")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private bool ELKJGMMAKPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private int ACCOKMEJFHE;

	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private static bool LPALFFNEABC;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool NDJPIFOKHJP
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0xCB8140", Offset = "0xCB7540", VA = "0x180CB8140")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xCB89A0", Offset = "0xCB7DA0", VA = "0x180CB89A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private Material PGFNIDFBJPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x6C66F10", Offset = "0x6C66310", VA = "0x186C66F10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private Material LKGCBLAPPEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x6C661E0", Offset = "0x6C655E0", VA = "0x186C661E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private bool GEPDPCPEDGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8C5960", Offset = "0x8C4D60", VA = "0x1808C5960")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public BMFEHMICIHN BCKIDANIFLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x9178F0", Offset = "0x916CF0", VA = "0x1809178F0", Slot = "21")]
		get
		{
			return default(BMFEHMICIHN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	private static CCENJGFOMNL LJNLIKDCHMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6C5E010", Offset = "0x6C5D410", VA = "0x186C5E010")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	private GALJFDPIMHI BNFOFFFMANL
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6C60760", Offset = "0x6C5FB60", VA = "0x186C60760")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private FHADNFKMJFJ CLNAMCCMOIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6C5D590", Offset = "0x6C5C990", VA = "0x186C5D590")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	private KKELKFJEAOL MJJCNGHIIAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6C67CA0", Offset = "0x6C670A0", VA = "0x186C67CA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public LKILNMKOKHH GHCJANNDPBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x95E800", Offset = "0x95DC00", VA = "0x18095E800", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public LKILNMKOKHH DNOCIJPMNBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x95E7D0", Offset = "0x95DBD0", VA = "0x18095E7D0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public SkinnedMeshRenderer[] JCBBFGMPDNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xE1D120", Offset = "0xE1C520", VA = "0x180E1D120", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public Renderer[] KKGLADEPIAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x8AFC40", Offset = "0x8AF040", VA = "0x1808AFC40", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool MIEHGHPNEHD
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6C65CB0", Offset = "0x6C650B0", VA = "0x186C65CB0", Slot = "20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public PositionAndRotation PPBPEOFICID
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6C60730", Offset = "0x6C5FB30", VA = "0x186C60730", Slot = "27")]
		get
		{
			return default(PositionAndRotation);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public CLCNDMDBJIL.ACBJNAIFGMN GDOFEFANHLA
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x8AFC30", Offset = "0x8AF030", VA = "0x1808AFC30", Slot = "18")]
		get
		{
			return default(CLCNDMDBJIL.ACBJNAIFGMN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public int BAKDPFHFIKI
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x1BB26A0", Offset = "0x1BB1AA0", VA = "0x181BB26A0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x6C5D750", Offset = "0x6C5CB50", VA = "0x186C5D750")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	private bool HNHBEHJCIJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x6C68090", Offset = "0x6C67490", VA = "0x186C68090")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private static bool ANFAPBCICOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6C5E3B0", Offset = "0x6C5D7B0", VA = "0x186C5E3B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6C68350", Offset = "0x6C67750", VA = "0x186C68350")]
	public BIAPNLKMOKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x6C60B10", Offset = "0x6C5FF10", VA = "0x186C60B10", Slot = "28")]
	public void JLABJFAHLGH(BAKIGAPKNDG AMDKNOOLHCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6C64060", Offset = "0x6C63460", VA = "0x186C64060", Slot = "29")]
	public void MOEMEFJEFDG(FOEJLBFFBDN DHCACBNDPIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6C5D750", Offset = "0x6C5CB50", VA = "0x186C5D750", Slot = "4")]
	public void CMFGGFHCMJD(int KFELJFNOKBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6C60070", Offset = "0x6C5F470", VA = "0x186C60070", Slot = "9")]
	public void IHFINCHMLDJ(DKIPMGKJIKF OMMLLIIJEJK, Texture2D KDKJOONKNHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6C5DA70", Offset = "0x6C5CE70", VA = "0x186C5DA70", Slot = "10")]
	public void DFMDCDCAPPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6C5E080", Offset = "0x6C5D480", VA = "0x186C5E080", Slot = "11")]
	public bool DNMNHHDPJEC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6C670A0", Offset = "0x6C664A0", VA = "0x186C670A0", Slot = "8")]
	public void OCDPFKHMGLA(HBNJKHMGCLE OMLFOIJINLE, Color? DFKHKPKCOFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6C62F50", Offset = "0x6C62350", VA = "0x186C62F50")]
	private void KPBFLAKLGAD(Action EBEBDNIBCOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x6C5F450", Offset = "0x6C5E850", VA = "0x186C5F450", Slot = "5")]
	public void HAEDBOANFGF(DEAOOHKMGJJ DPLABPCLKDH, Texture FBBMHGNAFMP, Color CDAKAAHGMOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0xCB89A0", Offset = "0xCB7DA0", VA = "0x180CB89A0", Slot = "6")]
	public void ACBODNENHHP(bool MHPHFBKNBGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x1AEB7A0", Offset = "0x1AEABA0", VA = "0x181AEB7A0", Slot = "7")]
	public void EHACMKLFDIN(LLHBFJIDBOE AFAEKDPMCFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6C60DD0", Offset = "0x6C601D0", VA = "0x186C60DD0", Slot = "14")]
	public LMEMMAHKEDK JLNPEKNKMBK(PACGBHKHAOH EJGGILICKOA, bool ILDCEPJDELN, int[] BPPHDCKLBEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6C603C0", Offset = "0x6C5F7C0", VA = "0x186C603C0", Slot = "15")]
	public void IMGLILPEJIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6C66410", Offset = "0x6C65810", VA = "0x186C66410", Slot = "26")]
	public void NPPDDLIKNAB([Optional] PIMBILBNCGP BGBBEPBMPLJ, [Optional] bool? BMGDGHIBNAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6C662D0", Offset = "0x6C656D0", VA = "0x186C662D0")]
	private bool NPJAFHKGJGL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6C5D5E0", Offset = "0x6C5C9E0", VA = "0x186C5D5E0", Slot = "19")]
	public bool BMILLOFEHIP(CLCNDMDBJIL.ACBJNAIFGMN EBNDMJDGNCL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6C62740", Offset = "0x6C61B40", VA = "0x186C62740")]
	private bool KHCIIFFJEJG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6C62950", Offset = "0x6C61D50", VA = "0x186C62950")]
	private LMEMMAHKEDK KNBOLGPJHNC(bool ILDCEPJDELN, List<POEBAPONENH> BAIDNPDGIJG, int[] BPPHDCKLBEK, Func<int, PJKEKENBJPN> GBCEOPGKPPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6C5DC50", Offset = "0x6C5D050", VA = "0x186C5DC50")]
	[IteratorStateMachine(typeof(JKLKAJBGKNE))]
	private IEnumerator<BGFGBHFIDBJ> DGBBHJDKDJD(bool ILDCEPJDELN, List<POEBAPONENH> BAIDNPDGIJG, int[] BPPHDCKLBEK, Func<int, PJKEKENBJPN> GBCEOPGKPPF, MNOCKKLFKAN IMOAFHNPNDO, Material OMOMEKPGALH, List<LMEMMAHKEDK> NPKHICCNKMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6C5E860", Offset = "0x6C5DC60", VA = "0x186C5E860")]
	private LMEMMAHKEDK FBLEOFJELLF(List<POEBAPONENH> BAIDNPDGIJG, int[] BPPHDCKLBEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6C640E0", Offset = "0x6C634E0", VA = "0x186C640E0")]
	private GJOIDBBGEPO MPHECPIKCMF(List<POEBAPONENH> BAIDNPDGIJG, int KFELJFNOKBH, bool ILDCEPJDELN, PJKEKENBJPN NHDCAJADCDM, bool KDBEFOCIMBA, MNOCKKLFKAN IMOAFHNPNDO, Material OMOMEKPGALH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6C5EB20", Offset = "0x6C5DF20", VA = "0x186C5EB20", Slot = "22")]
	public void FDHIMHDPBPC(AvatarFaceShape IGLOIPHHHKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6C5E7A0", Offset = "0x6C5DBA0", VA = "0x186C5E7A0", Slot = "23")]
	public void EMHEHCJGDLM(AvatarBodyShape HKJOMMLIKGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6C5EBE0", Offset = "0x6C5DFE0", VA = "0x186C5EBE0", Slot = "25")]
	public void FGGLPCHOCAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6C67C90", Offset = "0x6C67090", VA = "0x186C67C90", Slot = "24")]
	public void PGHJLOIJPCF(bool PGFHNLCFEBD, bool DCNPDMLOKEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6C60280", Offset = "0x6C5F680", VA = "0x186C60280")]
	private void IJIBKIKMOKF(SkinnedMeshRenderer PHLMOFGMCJA, int KFELJFNOKBH, Mesh JIPKNCLPFGJ, List<Material> NIJMFHIKMEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6C5FBA0", Offset = "0x6C5EFA0", VA = "0x186C5FBA0")]
	private static Material HGMLGJBGMLD(Dictionary<DFLGCJKJBHM, Material> NOFOOFKBCBG, Material NCBPAFGICFA, EIBGBEKFMHK BIDEBPPHFHE, DDJFPPANDLJ GBAOOOOAPOD, KJCIGENAPJO FHPOINKIBOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6C5D0D0", Offset = "0x6C5C4D0", VA = "0x186C5D0D0")]
	private static EIBGBEKFMHK AJFEHMDLHGG(POEBAPONENH OHAPIKEBKGP, int HAEHOEJKIAA)
	{
		return default(EIBGBEKFMHK);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6C5CCC0", Offset = "0x6C5C0C0", VA = "0x186C5CCC0")]
	private void AHKHNIDOCIG(int LJDBIHHEHCK, Material LBOPCEJDNFN, POEBAPONENH OHAPIKEBKGP, [Out] Texture2D NIMGOGOAOOL, [Out] Vector4 KDPHBDOJFNH, [Out] Texture2D INLDKBGIELK, [Out] Texture2D CGCGGLMJPHA, [Out] Texture2D PNBICCECHGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6C5ECE0", Offset = "0x6C5E0E0", VA = "0x186C5ECE0")]
	private void FIHHFCDOJMM(int LJDBIHHEHCK, Material LBOPCEJDNFN, POEBAPONENH OHAPIKEBKGP, [Out] Color ADCBPNFNHGF, [Out] Color ABHIIJAFHFG, [Out] Color OKBMDCNNIKD, [Out] Color APBMEMDDKCL, [Out] Color HPHJJBJJBOO, [Out] Color OAEIENLFIHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6C67660", Offset = "0x6C66A60", VA = "0x186C67660")]
	private bool OLBPKAJGPJG(Material LBOPCEJDNFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6C65C60", Offset = "0x6C65060", VA = "0x186C65C60")]
	private static Material MPHNPBMJFCP(int LJDBIHHEHCK, BOEKKIEBHIM OHAPIKEBKGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6C65EB0", Offset = "0x6C652B0", VA = "0x186C65EB0")]
	private static DDJFPPANDLJ NKCKEBOLGLH(POEBAPONENH OHAPIKEBKGP, int HAEHOEJKIAA)
	{
		return default(DDJFPPANDLJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6C623D0", Offset = "0x6C617D0", VA = "0x186C623D0")]
	private static void KDJMBPFLDEL(Dictionary<string, List<DFLGCJKJBHM>> NBJBCOJNBPF, POEBAPONENH FOFPEKEAEGH, Material NCBPAFGICFA, EIBGBEKFMHK OMLFOIJINLE, DDJFPPANDLJ OMMLLIIJEJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6C65FB0", Offset = "0x6C653B0", VA = "0x186C65FB0")]
	private static SkinnedMeshRenderer NMFHNGMNFGD(Transform DMDDMNFEDCK, Transform INFEONNCCKJ, SkinnedMeshRenderer[] AKDGFCJCAMD, int KFELJFNOKBH, PJKEKENBJPN NHDCAJADCDM, bool ILDCEPJDELN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6C5E1F0", Offset = "0x6C5D5F0", VA = "0x186C5E1F0")]
	private void DOJJAOENJDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6C607B0", Offset = "0x6C5FBB0", VA = "0x186C607B0")]
	private void JDHECDFDBPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6C60850", Offset = "0x6C5FC50", VA = "0x186C60850")]
	private static void JJOMMDLBNEB(Dictionary<DFLGCJKJBHM, Material> NOFOOFKBCBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6C5DAF0", Offset = "0x6C5CEF0", VA = "0x186C5DAF0")]
	private static void DGADPGCLGEM(Dictionary<Renderer, MNOCKKLFKAN> LIDBEPNKKBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6C5F260", Offset = "0x6C5E660", VA = "0x186C5F260")]
	private void GIHNACOEGAA(SkinnedMeshRenderer[] AKDGFCJCAMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6C63E90", Offset = "0x6C63290", VA = "0x186C63E90")]
	private void MFHIHMDFJAO(SkinnedMeshRenderer BMFHJCCNBLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6C5DD60", Offset = "0x6C5D160", VA = "0x186C5DD60")]
	private void DJMOOGDMDML(List<PLAOPNDIDAJ> INBACEPHOPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6C63540", Offset = "0x6C62940", VA = "0x186C63540")]
	private void LKHMHAFCGEF(Dictionary<string, FLIAEPPCPCN<Texture2D>> NBJBCOJNBPF, bool GFIFLFMILIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6C66EC0", Offset = "0x6C662C0", VA = "0x186C66EC0")]
	private void OBCBICCCNAO(Dictionary<string, List<DFLGCJKJBHM>> NBJBCOJNBPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x6C5C740", Offset = "0x6C5BB40", VA = "0x186C5C740")]
	private void ADJOINAGGOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6C5E610", Offset = "0x6C5DA10", VA = "0x186C5E610")]
	private void EKLDGBALEFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6C5F4E0", Offset = "0x6C5E8E0", VA = "0x186C5F4E0")]
	private void HBCKKFCAIAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6C5FAA0", Offset = "0x6C5EEA0", VA = "0x186C5FAA0")]
	private void HDJLCCJCFHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6C5FD00", Offset = "0x6C5F100", VA = "0x186C5FD00")]
	private void HKPJBKPEBAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6C62800", Offset = "0x6C61C00", VA = "0x186C62800")]
	private void KHMAHKLJAEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6C5DF40", Offset = "0x6C5D340", VA = "0x186C5DF40")]
	private void DLIGHCHPPDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x6C5F1C0", Offset = "0x6C5E5C0", VA = "0x186C5F1C0")]
	private void GAPKOPLEAOI(bool GGFCHIBICON = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x6C5FE20", Offset = "0x6C5F220", VA = "0x186C5FE20")]
	private void HPMCDMEOEGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x6C5F3B0", Offset = "0x6C5E7B0", VA = "0x186C5F3B0")]
	private void GODBGCBGIDN(bool GGFCHIBICON = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x6C67D70", Offset = "0x6C67170", VA = "0x186C67D70")]
	private void PMCJJGOAIKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x6C63060", Offset = "0x6C62460", VA = "0x186C63060")]
	private void LGOOINMHMKB(Material OMOMEKPGALH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x6C605C0", Offset = "0x6C5F9C0", VA = "0x186C605C0")]
	private void IMHCLDALDDF(Material OMOMEKPGALH, Color LGDBNMKGICI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6C5D7A0", Offset = "0x6C5CBA0", VA = "0x186C5D7A0")]
	private void DAINACFDEMN(Material OMOMEKPGALH, Color LGDBNMKGICI, Color PMIPLHLCNIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x6C5D600", Offset = "0x6C5CA00", VA = "0x186C5D600")]
	private void CKPFPHHFBEG(Material OMOMEKPGALH, Color ADCBPNFNHGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6C63C90", Offset = "0x6C63090", VA = "0x186C63C90")]
	private void MFDFEMGDJJF(Material OMOMEKPGALH, Texture2D KDKJOONKNHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x6C609B0", Offset = "0x6C5FDB0", VA = "0x186C609B0")]
	private void JKLODPLDBGI(Material OMOMEKPGALH, Texture JJKBGKBNIGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6C674A0", Offset = "0x6C668A0", VA = "0x186C674A0")]
	private void OCPCICMKALI(Action<MNOCKKLFKAN> GFNBHDHMPOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x6C5FEF0", Offset = "0x6C5F2F0", VA = "0x186C5FEF0")]
	private void IADFGPJKFPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6C5C8A0", Offset = "0x6C5BCA0", VA = "0x186C5C8A0")]
	private void AGFFGAEMGIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x6C636C0", Offset = "0x6C62AC0", VA = "0x186C636C0")]
	private LMEMMAHKEDK LLCFJOGACMP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6C678C0", Offset = "0x6C66CC0", VA = "0x186C678C0")]
	private void OOLLIIDLICP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x6C5D200", Offset = "0x6C5C600", VA = "0x186C5D200")]
	public void AKCLDDECEKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x6C5FD90", Offset = "0x6C5F190", VA = "0x186C5FD90")]
	[CompilerGenerated]
	private void HMBKFEPJOGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x6C5E5E0", Offset = "0x6C5D9E0", VA = "0x186C5E5E0")]
	[CompilerGenerated]
	private void EEEJDNADOLC(MNOCKKLFKAN FKLFLBFEGGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6C626B0", Offset = "0x6C61AB0", VA = "0x186C626B0")]
	[CompilerGenerated]
	private void KFBAOHPAKBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6C5F4C0", Offset = "0x6C5E8C0", VA = "0x186C5F4C0")]
	[CompilerGenerated]
	private void HBCBGCPMBOE(MNOCKKLFKAN FKLFLBFEGGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6C607C0", Offset = "0x6C5FBC0", VA = "0x186C607C0")]
	[CompilerGenerated]
	private void JJFJPEKMGBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6C63FC0", Offset = "0x6C633C0", VA = "0x186C63FC0")]
	[CompilerGenerated]
	private void MKLEDCPHKGH(MNOCKKLFKAN FKLFLBFEGGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x6C62FD0", Offset = "0x6C623D0", VA = "0x186C62FD0")]
	[CompilerGenerated]
	private void LEMOMHHFMBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x6C62F20", Offset = "0x6C62320", VA = "0x186C62F20")]
	[CompilerGenerated]
	private void KOJNCFJGNND(MNOCKKLFKAN FKLFLBFEGGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6C65E20", Offset = "0x6C65220", VA = "0x186C65E20")]
	[CompilerGenerated]
	private void NGGFFBNEEME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6C5F380", Offset = "0x6C5E780", VA = "0x186C5F380")]
	[CompilerGenerated]
	private void GNFHDNIGHAL(MNOCKKLFKAN FKLFLBFEGGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6C63F30", Offset = "0x6C63330", VA = "0x186C63F30")]
	[CompilerGenerated]
	private void MICINGLBAID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6C5D770", Offset = "0x6C5CB70", VA = "0x186C5D770")]
	[CompilerGenerated]
	private void COOMPOFIALO(MNOCKKLFKAN FKLFLBFEGGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x6C5D9E0", Offset = "0x6C5CDE0", VA = "0x186C5D9E0")]
	[CompilerGenerated]
	private void DEAICHHCNFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x6C67D40", Offset = "0x6C67140", VA = "0x186C67D40")]
	[CompilerGenerated]
	private void PLEDBEDFIHD(MNOCKKLFKAN FKLFLBFEGGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x6C63FE0", Offset = "0x6C633E0", VA = "0x186C63FE0")]
	[CompilerGenerated]
	private void MLDPBHDFDOF(KeyValuePair<string, FLIAEPPCPCN<Texture2D>> EDICMHINCMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x6C5CC00", Offset = "0x6C5C000", VA = "0x186C5CC00")]
	[CompilerGenerated]
	private void AHECAGELALK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x6C5FB70", Offset = "0x6C5EF70", VA = "0x186C5FB70")]
	[CompilerGenerated]
	private void HGEPECKFGCJ(MNOCKKLFKAN FKLFLBFEGGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6C5E550", Offset = "0x6C5D950", VA = "0x186C5E550")]
	[CompilerGenerated]
	private void EAIHJPLPOOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x6C5CC90", Offset = "0x6C5C090", VA = "0x186C5CC90")]
	[CompilerGenerated]
	private void AHJGMJAFOMA(MNOCKKLFKAN FKLFLBFEGGF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class PHCAJNIHEOH : JPHLGKLALBA
{
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private static readonly int HLEGJKNLIGK;

	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private static readonly int PJMCIOHACMH;

	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private static readonly int LPJKJMGGHHO;

	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private static readonly int KCJOLLHOKGI;

	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private static readonly int LKJHBNKHKNK;

	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private static readonly int INDAPNJCLHP;

	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private static readonly int JIEJIENOMKJ;

	[Cpp2IlInjected.Token(Token = "0x4000130")]
	private static readonly int MPGPIKLJDDM;

	[Cpp2IlInjected.Token(Token = "0x4000131")]
	private static readonly int EFNOKEMFGFN;

	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private static readonly int KGKJCIIFCBP;

	[Cpp2IlInjected.Token(Token = "0x4000133")]
	private static readonly int JEJOJMOBOPH;

	[Cpp2IlInjected.Token(Token = "0x4000134")]
	private static readonly int LIMHJLKEBEL;

	[Cpp2IlInjected.Token(Token = "0x4000135")]
	private static readonly int MBELEMEIAAL;

	[Cpp2IlInjected.Token(Token = "0x4000136")]
	private static readonly int CPEOJPALIEL;

	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private static readonly int OPHKLFJHOOB;

	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private static readonly int HOLLFKHJFJM;

	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private static readonly int OEBJMJDHJIJ;

	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private static readonly int ONLJOHEBDBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private Transform EFFFFPBGBMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private Transform PCDOAIBJHID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private Transform OMHDOANJFKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private Transform CPINMLPCMJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private Transform EBKNOJGGBJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private Transform HIPCIFPPCPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private Transform ABBDIEAIIHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private IIBEGEDGKFE APPHNBPAKDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private MaterialPropertyBlock BOKJPEFFBDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private SkinnedMeshRenderer[] EENNKEFLNCN;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	private MaterialPropertyBlock NJBHPEFKIEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x6C70520", Offset = "0x6C6F920", VA = "0x186C70520")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool NMBIACJCIOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x6C6ED10", Offset = "0x6C6E110", VA = "0x186C6ED10", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x6C70450", Offset = "0x6C6F850", VA = "0x186C70450", Slot = "7")]
	public void JLABJFAHLGH(IIBEGEDGKFE BCOJLKEJKPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x6C6EF20", Offset = "0x6C6E320", VA = "0x186C6EF20", Slot = "8")]
	public void FLHHHMPJJHO(DILPCLIJOMM EAEDABDCCMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x6C705A0", Offset = "0x6C6F9A0", VA = "0x186C705A0", Slot = "5")]
	public void LODLIKHOPEB(GHNJMFAKMLI BMPODAJOEAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x6C70AA0", Offset = "0x6C6FEA0", VA = "0x186C70AA0")]
	private Vector2 OANBHFGODFL(Vector2 MEKPADEBCJC)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x6C6EF50", Offset = "0x6C6E350", VA = "0x186C6EF50", Slot = "6")]
	public void GMMJMDJAEIG(ILOJDILMKBL EAEDABDCCMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x6C70110", Offset = "0x6C6F510", VA = "0x186C70110")]
	private void JJLBBHOBNMO(ILOJDILMKBL NNHHEDIMLDB, IGCPANEJIJL OAJENBADCBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x6C6EC30", Offset = "0x6C6E030", VA = "0x186C6EC30")]
	private void BAKFPBMMDIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x6C70E00", Offset = "0x6C70200", VA = "0x186C70E00")]
	public PHCAJNIHEOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x6C6EE90", Offset = "0x6C6E290", VA = "0x186C6EE90")]
	[CompilerGenerated]
	internal static (float, float) EPJHHAAPFGF(float JNBENGOHNKB)
	{
		return default((float, float));
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x6C700D0", Offset = "0x6C6F4D0", VA = "0x186C700D0")]
	[CompilerGenerated]
	internal static Vector4 HABEHABOPAH(Vector2 MBJNFCDOKCE, Vector2 BJGGPAGHNPO)
	{
		return default(Vector4);
	}
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public class AvatarItemMaterial : ScriptableObject, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		[SerializeField]
		[Obsolete("Use CombinationId instead!")]
		private string Guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		[SerializeField]
		private SerializedCombinationId combinationId;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private BFPCODFKEAD? cachedMaterialCombinationId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		[SerializeField]
		private Material material;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		[SerializeField]
		private Material[] additionalMaterials;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public MLLCBKIBLJC CombinationId
		{
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x6C72100", Offset = "0x6C71500", VA = "0x186C72100")]
			get
			{
				return default(MLLCBKIBLJC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public BFPCODFKEAD MaterialCombinationId
		{
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x6C72130", Offset = "0x6C71530", VA = "0x186C72130")]
			get
			{
				return default(BFPCODFKEAD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public Material Material
		{
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x8ADBA0", Offset = "0x8ACFA0", VA = "0x1808ADBA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public Material[] AdditionalMaterials
		{
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x8ADB80", Offset = "0x8ACF80", VA = "0x1808ADB80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x6C71D60", Offset = "0x6C71160", VA = "0x186C71D60")]
		public Material[] JKFFPPNDPBO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x6C71E50", Offset = "0x6C71250", VA = "0x186C71E50")]
		public static void JPBAMCHAMBA(AvatarItemMaterial MHNONABOLNH, Material LBOPCEJDNFN, int LJDBIHHEHCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x6C71BB0", Offset = "0x6C70FB0", VA = "0x186C71BB0")]
		private static bool FECHMABJBOG(AvatarItemMaterial MHNONABOLNH, int LJDBIHHEHCK, [Out] Material PAOLMGCMJIB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x6C72040", Offset = "0x6C71440", VA = "0x186C72040")]
		public AvatarItemMaterial()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[NFAHBLEIIKC]
public struct HKJPBJGLJPO : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	[ReadOnly]
	public IMFELMECEMJ OHDNOKJBFGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	[ReadOnly]
	public int JAFGJMJABKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	public CDINAJPLLHP DMBCHNMDNML;

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x6C74F50", Offset = "0x6C74350", VA = "0x186C74F50", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[NativeContainer]
[NFAHBLEIIKC]
public struct CDINAJPLLHP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	public NativeArray<Vector3> ICMPCFAJIAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	public NativeArray<Vector3> GNELJAACCHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	public NativeArray<Vector4> PFPBCCHMFMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	public NativeArray<Vector2> JJBOHCPEBCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	public NativeArray<Vector2> GCLCLNGOBFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	public NativeArray<Vector2> ALOJCGKAKBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	public NativeArray<Vector2> MKLDDFODGBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	public NativeArray<Color> NBKFOKGKGPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	public NativeArray<int> EANCDMKBJJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	public NativeArray<int> CJCKCFHMOCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	private NativeArray<int> PPDPFFBPHNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	private NativeArray<int> CELKBPNAMED;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	public NativeArray<int> HJABOGPHIGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	public NativeArray<int> AGHMBAFFJLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	public NativeArray<int> GCMKMDGNHCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	public NativeArray<BoneWeight> KAAKPMACKOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	private NativeArray<int> AFAEKDPMCFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private bool HEKHIHLBLJP;

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public int OEDNIFABHNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x6C728B0", Offset = "0x6C71CB0", VA = "0x186C728B0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x6C722E0", Offset = "0x6C716E0", VA = "0x186C722E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public int BGIJJJLBCKB
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x6C72D20", Offset = "0x6C72120", VA = "0x186C72D20")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x6C72C50", Offset = "0x6C72050", VA = "0x186C72C50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public int EJODNNEMHJF
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x6C72870", Offset = "0x6C71C70", VA = "0x186C72870")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x6C72A70", Offset = "0x6C71E70", VA = "0x186C72A70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x6C72D30", Offset = "0x6C72130", VA = "0x186C72D30")]
	public CDINAJPLLHP(int EFBGMAKMMFP, int IBJMCGKFFLP, int GKFJONKEGIA, int KHCLKDAKNBO, Allocator MGFIHPDNFPH, int FEFHBMLGFAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x6C72C60", Offset = "0x6C72060", VA = "0x186C72C60")]
	public void MMEIIJKMDEC(int AEAHMAMPNLO, Vector3 IDIHIILANOF, Vector3 DNDOEPAKCMB, Vector4 HIKBGGAGLAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x6C72AB0", Offset = "0x6C71EB0", VA = "0x186C72AB0")]
	public void HBDHJADPENJ(int AEAHMAMPNLO, BoneWeight JHKDCNBCAIL, NativeSlice<byte> LAIJLNPOIBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x6C72A90", Offset = "0x6C71E90", VA = "0x186C72A90")]
	public Color GHMGIFIGDEN(int AEAHMAMPNLO)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x6C72380", Offset = "0x6C71780", VA = "0x186C72380")]
	public void BIGBJKCEFFH(int AEAHMAMPNLO, Color HPAGGPJLKCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x6C72CD0", Offset = "0x6C720D0", VA = "0x186C72CD0")]
	public void PGJGFICNGDI(byte OFGJCDMACKB, int AEAHMAMPNLO, Vector2 KIBNMJBDOIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x6C72A80", Offset = "0x6C71E80", VA = "0x186C72A80")]
	public void FNJGJMGHEMN(int AEAHMAMPNLO, int CHHDLCDBKOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x6C72880", Offset = "0x6C71C80", VA = "0x186C72880")]
	public bool DDFMGNEHIAI(int OFGJCDMACKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x6C727A0", Offset = "0x6C71BA0", VA = "0x186C727A0")]
	public void CBAENGMMGFM(int MIMLBNAMKDF, int GMCJIJBLJPF, int IDHDBIDGMFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x6C723A0", Offset = "0x6C717A0", VA = "0x186C723A0")]
	public int[] BOLNBOLDLOP(int MIMLBNAMKDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x6C722F0", Offset = "0x6C716F0", VA = "0x186C722F0")]
	private NativeSlice<int> BHDKPNMEPAA(int MIMLBNAMKDF)
	{
		return default(NativeSlice<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x6C728C0", Offset = "0x6C71CC0", VA = "0x186C728C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x6C72450", Offset = "0x6C71850", VA = "0x186C72450")]
	public Mesh CAIJLJDCELG([Optional] string DCOHAAJFDDD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[DefaultMember("Item")]
[NFAHBLEIIKC]
[NativeContainer]
public struct IMFELMECEMJ : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	public NativeArray<Vector3> ICMPCFAJIAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	public NativeArray<Vector3> GNELJAACCHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	public NativeArray<Vector4> PFPBCCHMFMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	public NativeArray<Vector2> JJBOHCPEBCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	public NativeArray<Vector2> GCLCLNGOBFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	public NativeArray<Vector2> ALOJCGKAKBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	public NativeArray<Vector2> MKLDDFODGBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	public NativeArray<Color> NBKFOKGKGPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	public NativeArray<int> PAKBAAILEMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	public NativeArray<int> CMACMEBHCKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	public NativeArray<int> DAJMINDIEBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	public NativeArray<int> NBHDMAGILGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	public NativeArray<bool> BBGLLLCKEBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	public NativeArray<int> NOILLGHJOBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	public NativeArray<int> NEJKHGMFIIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	public NativeArray<BoneWeight> HFOOCANKBBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	private NativeArray<Matrix4x4> JCLKJLCJBDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private NativeArray<int> CFLGCJBKDNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private NativeArray<byte> AEONPLIFPMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private NativeArray<int> FPCCPBEFLFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private NativeArray<int> DADJPCBDBKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	public NativeArray<sbyte> ALLLEIPCCFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	public NativeArray<byte> CBOHPCADHEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private NativeArray<int> KFGKLJIGEPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private bool HEKHIHLBLJP;

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public int LKMHPDCLFHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x222C340", Offset = "0x222B740", VA = "0x18222C340")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public int LNFCBCFJINJ
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x1337120", Offset = "0x1336520", VA = "0x181337120")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public int EIMLLNKOAID
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x6C767D0", Offset = "0x6C75BD0", VA = "0x186C767D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public int HDHLCJHOPJN
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x6C766E0", Offset = "0x6C75AE0", VA = "0x186C766E0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x6C766F0", Offset = "0x6C75AF0", VA = "0x186C766F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public int OEDNIFABHNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x6C76810", Offset = "0x6C75C10", VA = "0x186C76810")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x6C766D0", Offset = "0x6C75AD0", VA = "0x186C766D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public int GCLABMMKGEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x6C76AB0", Offset = "0x6C75EB0", VA = "0x186C76AB0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x6C76AA0", Offset = "0x6C75EA0", VA = "0x186C76AA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public HOGMIIMLKEI FFIFJCMJKJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x6C76A90", Offset = "0x6C75E90", VA = "0x186C76A90")]
		get
		{
			return default(HOGMIIMLKEI);
		}
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x6C766C0", Offset = "0x6C75AC0", VA = "0x186C766C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public byte GNJEHKAHMFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x6C76A80", Offset = "0x6C75E80", VA = "0x186C76A80")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x6C76800", Offset = "0x6C75C00", VA = "0x186C76800")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public HBNKEJMHHFP CPCAOKGGKKP
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x6C76AC0", Offset = "0x6C75EC0", VA = "0x186C76AC0")]
		get
		{
			return default(HBNKEJMHHFP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x6C76FE0", Offset = "0x6C763E0", VA = "0x186C76FE0")]
	public IMFELMECEMJ(IList<Mesh> FIOEKKGBMLO, IList<Matrix4x4> KIFBOHBJGKO, IList<bool> BBGLLLCKEBL, byte PIAOLLLOPGI, IList<byte[]> PCMPIBKHCLM, IList<int> DFLAOFJNHJC, IList<bool> ECDGLJCDNEA, IList<int> NOILLGHJOBB, IList<int> CMNKJKDKNCP, IList<int> CMCLFIEFBCL, Allocator MGFIHPDNFPH, HOGMIIMLKEI LJHFGKCNDIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x6C76700", Offset = "0x6C75B00", VA = "0x186C76700")]
	public CDINAJPLLHP CDPPDEPCJDK(Allocator MGFIHPDNFPH)
	{
		return default(CDINAJPLLHP);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x6C76820", Offset = "0x6C75C20", VA = "0x186C76820", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[NFAHBLEIIKC]
public class BDEEILECNIF : IEHEEBMCNAH
{
	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x6C721F0", Offset = "0x6C715F0", VA = "0x186C721F0")]
	public IMFELMECEMJ NAAEKGOAEHK()
	{
		return default(IMFELMECEMJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x6C6D430", Offset = "0x6C6C830", VA = "0x186C6D430")]
	public BDEEILECNIF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public struct HBNKEJMHHFP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	public NativeSlice<Vector3> ICMPCFAJIAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	public NativeSlice<Vector3> GNELJAACCHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	public NativeSlice<Vector4> PFPBCCHMFMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	public NativeSlice<Vector2> JJBOHCPEBCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	public NativeSlice<Vector2> GCLCLNGOBFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	public NativeSlice<Vector2> ALOJCGKAKBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	public NativeSlice<Vector2> MKLDDFODGBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	public NativeSlice<Color> NBKFOKGKGPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	public NativeSlice<int> EKEABOHDABK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	public NativeSlice<int> NBHDMAGILGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	public NativeSlice<BoneWeight> HFOOCANKBBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	public NativeSlice<byte> ANOIAFKLAHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	public int MLDAHMCENAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	public Matrix4x4 HOECJKKEKMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	public int DAHDHEOOPFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	public NativeSlice<byte> LAIJLNPOIBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	public bool PDPMOPJPFKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	public int HPFNGBMFFNN;
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal readonly struct DFLGCJKJBHM : IEquatable<DFLGCJKJBHM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	internal readonly Material OHHFCMHKMGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	internal readonly EIBGBEKFMHK CMFAKGDADPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	internal readonly DDJFPPANDLJ BNAFKJIEMJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	internal readonly KJCIGENAPJO AFGMBNKFALA;

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0xD33190", Offset = "0xD32590", VA = "0x180D33190")]
	public DFLGCJKJBHM(Material LBOPCEJDNFN, EIBGBEKFMHK BIDEBPPHFHE, DDJFPPANDLJ GBAOOOOAPOD, KJCIGENAPJO FHPOINKIBOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x6C73320", Offset = "0x6C72720", VA = "0x186C73320", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0xD32E40", Offset = "0xD32240", VA = "0x180D32E40", Slot = "4")]
	public bool Equals(DFLGCJKJBHM OCKBFCIKBEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x6C73190", Offset = "0x6C72590", VA = "0x186C73190", Slot = "0")]
	public override bool Equals(object PBAACPJGKNP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x6C73280", Offset = "0x6C72680", VA = "0x186C73280", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class MNOCKKLFKAN : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	private MaterialPropertyBlock ADPOIOIIDJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	public Color? HBMJKHCBKFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	public Color? PKLDEGBKPDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	public Color? CMBNKLCJDNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	public Color? CJJFPNNJAJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	public Color GOPFNMODFGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	public Color PAAOKFIMGMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	public Color AINJDHJAKCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	public Texture2D GOGNOMBPAGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	public Texture2D AKMMDEKAIPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private Dictionary<DFLGCJKJBHM, int> AAILBGHDKBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	private EIBGBEKFMHK[] BONEGOHIBBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	private DDJFPPANDLJ[] HCJLMAKJEAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	public Vector4[] FEIDBGIIBHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	public Vector4[] GCHPJDEDLAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	public Vector4[] FGAJFFGHIDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	public Vector4[] CFBOBDFODGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	public Vector4[] EKGAKCLPLHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	public Vector4[] NOEIJKFAMFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	private List<Texture2D> ONBLJKFMACI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	private Vector4[] MNAJFADHJDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	private List<Texture2D> LEBEPEECLIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private float[] FGLDLMHHAME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private Vector4[] BBKDHKFJGLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	private float[] LBKBOOLDMDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	public float[] IDJBFOIHHCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	private List<Texture2D> PNLFNMFLILC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	private float[] PGIPBGMEBCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	private List<Texture2D> HELIOLHMLHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	private Vector4[] LBPDMDBMMPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	private float[] BMNIIMDOAEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private Vector4[] DIPCPEJAIPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	public float[] DKMKPHOKMLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	public Texture2DArray NCALPFMIPOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	public Texture2DArray OPPFEAFAACA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	public Texture2DArray BIDOKBMLLGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	public Texture2DArray JLLHGBKPIDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	private bool DJCKMJDMCGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x184")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	private int PGHGACGKGAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	private Vector2? AGCGNHIKOOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x194")]
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	private TextureFormat GHMPLEHEGPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	private Vector2? DBMFIFCPFBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A4")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	private TextureFormat HBAIJAOMJFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	private Vector2? CKILOJGHBFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B4")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	private TextureFormat CHMCACNLCKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	private Vector2? EFCCHOICKCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C4")]
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	private TextureFormat NBDHACABKBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	private bool LNIMNIKGCDA;

	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	private static int IMKCNKAJEBA;

	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	private static int IAHKKJKCEAM;

	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	private static int NONOJCBNDAA;

	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	private static int BMKHOGEPAFN;

	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	private static int MIHHDCDCJEK;

	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	private static int OFCPPCDGNAB;

	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	private static int PDGCKCKFMDF;

	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	private static int KFHLBAONCPE;

	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	private static int EJCKPDKAIGI;

	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	private static int DNFFNKGCDLJ;

	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	private static int GNDAPHOCAJL;

	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	private static int BIDCGDLILNJ;

	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	private static int CJEPNNAIAIH;

	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	private static int CNCNEBCPNJI;

	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	private static int JPFIFCFOOJC;

	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	private static int PCGEFOIAEAL;

	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	private static int MMPEACEIINB;

	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	private static int ALEFMCGMFHB;

	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	private static int HMOPDKPHEKF;

	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	private static int NGJMPLAPICJ;

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x6C7B010", Offset = "0x6C7A410", VA = "0x186C7B010")]
	private MNOCKKLFKAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x6C7AF50", Offset = "0x6C7A350", VA = "0x186C7AF50")]
	public MNOCKKLFKAN(Color DAFLNABDOAF, Color NJNLOCEOGPF, Color JLHPENGLJNL, Color? KPCGCLLDHEC, Color? OJFJCLJCBOH, Color? PKKDGPMBKFD, Texture2D NIAJPHIJCBP, Texture2D HILGCLCOEPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x6C78A90", Offset = "0x6C77E90", VA = "0x186C78A90")]
	internal int ACOKDKGJLPM(Material GBHGNGKGNIB, EIBGBEKFMHK BIDEBPPHFHE, DDJFPPANDLJ GBAOOOOAPOD, KJCIGENAPJO FHPOINKIBOO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x6C78A00", Offset = "0x6C77E00", VA = "0x186C78A00")]
	private int ACOKDKGJLPM(DFLGCJKJBHM GMJINMLEEAC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x6C79D30", Offset = "0x6C79130", VA = "0x186C79D30")]
	internal int LHANLPGBAMI(Material GBHGNGKGNIB, Color ADCBPNFNHGF, Color ABHIIJAFHFG, Color OKBMDCNNIKD, Color APBMEMDDKCL, Color HPHJJBJJBOO, Texture2D IEJPJFDKJEG, Vector4 PCEOIDJJPKN, Texture2D COMBHLPEFNM, Vector4 FGAOOCAFGHK, float BNJAPAEGCFI, float DMGFOHGEIHL, Texture2D GLIIMMPNEIO, Vector4 APEGMNHPKGA, float KIBHCFNNNCP, Texture2D JPFFDNBOOOL, Color OAEIENLFIHO, Vector4 FKFAKJBOOPG, EIBGBEKFMHK BIDEBPPHFHE, DDJFPPANDLJ GBAOOOOAPOD, KJCIGENAPJO FHPOINKIBOO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x6C78BC0", Offset = "0x6C77FC0", VA = "0x186C78BC0")]
	private void HHJGPACNMCE(List<Texture2D> ONBLJKFMACI, [Out] Texture2DArray BPPFNCMLLHA, [Out] Texture2DArray HBIKAILAAFO, [Out] Texture2DArray CDJNFIAMBBL, [Out] Texture2DArray IHGAFNFCPMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x6C79B30", Offset = "0x6C78F30", VA = "0x186C79B30")]
	public void KEEELOJPFJE(Shader NFCOLIKNKJF, Renderer OEGINKHKPKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x6C78ED0", Offset = "0x6C782D0", VA = "0x186C78ED0")]
	private void JOKCDLLACCB(Shader NFCOLIKNKJF, Renderer OEGINKHKPKI, int HLBHGHIDCLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x6C7AA00", Offset = "0x6C79E00", VA = "0x186C7AA00")]
	private Color MEEMJNNIGGJ(Color EAGDKCCGFGE, EIBGBEKFMHK OMLFOIJINLE)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x6C78D80", Offset = "0x6C78180", VA = "0x186C78D80")]
	private Color JCAGJJPIKNG(Color GJOMPOKFJCE, EIBGBEKFMHK OMLFOIJINLE)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x6C7A900", Offset = "0x6C79D00", VA = "0x186C7A900")]
	private bool LPMGAHINDPL(Texture2D JIBBBKONEBN, DDJFPPANDLJ OMMLLIIJEJK, [Out] Texture2D DBJIMICJECG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x6C79C80", Offset = "0x6C79080", VA = "0x186C79C80")]
	private void KOIDNGFFMIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x6C78B80", Offset = "0x6C77F80", VA = "0x186C78B80", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class LIJPMHFPAJE
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private sealed class GHJCFDLMFLC : IEnumerator<BGFGBHFIDBJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		private BGFGBHFIDBJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		public JobHandle handle;

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		private BGFGBHFIDBJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x8A9F10", Offset = "0x8A9310", VA = "0x1808A9F10", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(RVA = "0x8A9F10", Offset = "0x8A9310", VA = "0x1808A9F10", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x8AD680", Offset = "0x8ACA80", VA = "0x1808AD680")]
		[DebuggerHidden]
		public GHJCFDLMFLC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0xD35320", Offset = "0xD34720", VA = "0x180D35320", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x6C74C60", Offset = "0x6C74060", VA = "0x186C74C60", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30")]
	public static void KGODFMJOOHM(string IHELCOHOCAM, int KFELJFNOKBH, long CHJGBMCHKOF, long OOAGEOCLNIK, long BOMGPCPMCLC, long JICJEKFOPDO, long EIIFCIPBBJO, long DOFNDPOMDNN, long GBGMIEJJNDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x6C788B0", Offset = "0x6C77CB0", VA = "0x186C788B0")]
	public static GJOIDBBGEPO MFPBLDFPGPJ(JobHandle IGBMKDLJIFK, bool IGDAFPEJMCP, bool GEPDPCPEDGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x6C78840", Offset = "0x6C77C40", VA = "0x186C78840")]
	[IteratorStateMachine(typeof(GHJCFDLMFLC))]
	private static IEnumerator<BGFGBHFIDBJ> HAPAGDJAHIC(JobHandle PKDPMCLKPHH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public static class GLHMNIKABEL
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public enum MFCCAPPEBNK
	{
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		General,
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		ColoredHair
	}

	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	public static readonly int PKDCLPAOFAG;

	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	public static readonly int IFCMMPAGKAA;

	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	public static readonly int DAKJEGOHPKP;

	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	public static readonly int NLGBOLAEPCB;

	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	public static readonly int LPMIOGPPHEE;

	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	public static readonly int HCMNFAAFEFF;

	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	public static readonly int CIDOMNPFNIB;

	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	public static readonly int EGCCNKEILLB;

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x6C74CB0", Offset = "0x6C740B0", VA = "0x186C74CB0")]
	public static bool FPGLBMGCHBN(Material LBOPCEJDNFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x6C74D20", Offset = "0x6C74120", VA = "0x186C74D20")]
	public static bool OMMBNKOMHFI(Material LBOPCEJDNFN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class IFPJBFNDBNO : FHADNFKMJFJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	private FNCFMNKKDMO LLHJEMILHJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	private KNJPBACPBML HFODKFOLIFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	private IRecRoomQualityConfigProvider BDANHCHEMMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	private bool HEKHIHLBLJP;

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x6C75F30", Offset = "0x6C75330", VA = "0x186C75F30")]
	[FHFMOACGLML.PCGBCKINAAE.IIGHLHFDGPC]
	internal static void EFFHABGGDNG(ACFNHMKNHLL KLAPMCLMAPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x5F814E0", Offset = "0x5F808E0", VA = "0x185F814E0")]
	[UnityEngine.Scripting.Preserve]
	public IFPJBFNDBNO([ACGOIOBGIEE(null)] KNJPBACPBML EKGJNJOPIJE, [ACGOIOBGIEE(null)] FNCFMNKKDMO IEACNLENOCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x6C76030", Offset = "0x6C75430", VA = "0x186C76030")]
	private void IONJKGCJLOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x6C75EB0", Offset = "0x6C752B0", VA = "0x186C75EB0", Slot = "4")]
	public void DFMDCDCAPPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x6C761F0", Offset = "0x6C755F0", VA = "0x186C761F0", Slot = "5")]
	public FLIAEPPCPCN<Texture2D> PABIAIPEGON(KHMIFHAEBNK DABCNNICBCP, [Optional] LLHBFJIDBOE AFAEKDPMCFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x6C760C0", Offset = "0x6C754C0", VA = "0x186C760C0")]
	private uint ONGOCCPFLIK(KHMIFHAEBNK DABCNNICBCP, LLHBFJIDBOE AFAEKDPMCFB)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface HIFEFINPBGC
{
	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NFAIFEDKEOB(Mesh JIPKNCLPFGJ, Matrix4x4 CLELPODBLMJ, byte[] LAIJLNPOIBL, bool FCDDNDDHDGP = false, CLCNDMDBJIL.ACBJNAIFGMN PHPJNPIDFGB = (CLCNDMDBJIL.ACBJNAIFGMN)0, int NOILLGHJOBB = -1, bool BBGLLLCKEBL = false);

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GNPIMCLBNOM(Allocator MGFIHPDNFPH, HOGMIIMLKEI LJHFGKCNDIL, byte PIAOLLLOPGI, [Optional] IList<int> CMNKJKDKNCP, [Optional] IList<int> CJNGCKLANIP);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public readonly struct GGDKMGBLBOG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	public readonly GameObject HAHMOCFDLHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	private readonly AvatarItemMaterial FANLAEDGNPG;

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0xDCF0A0", Offset = "0xDCE4A0", VA = "0x180DCF0A0")]
	public GGDKMGBLBOG(GameObject HAHMOCFDLHE, AvatarItemMaterial FANLAEDGNPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x6C744C0", Offset = "0x6C738C0", VA = "0x186C744C0")]
	public void BOOKBDEABLJ(Material LBOPCEJDNFN, int LJDBIHHEHCK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public class NDMGPDLJHPE : PMDMPHJALAF<Task<(GameObject, AvatarItemMaterial)>, GGDKMGBLBOG>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private struct GGPMPCDLILE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		public AsyncTaskMethodBuilder<(GameObject, AvatarItemMaterial)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		public Task<GameObject> goTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		public Task<AvatarItemMaterial> materialTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		private GameObject <go>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		private TaskAwaiter<GameObject> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		private TaskAwaiter<AvatarItemMaterial> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x6C746F0", Offset = "0x6C73AF0", VA = "0x186C746F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x6C74BF0", Offset = "0x6C73FF0", VA = "0x186C74BF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	private FLIAEPPCPCN<GameObject> KELLEPNLMAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	private FLIAEPPCPCN<AvatarItemMaterial> JHLDKLEJMNB;

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x6C7C000", Offset = "0x6C7B400", VA = "0x186C7C000")]
	private NDMGPDLJHPE(Task<(GameObject, AvatarItemMaterial)> BIDGKFLMMBN, FLIAEPPCPCN<GameObject> JCDENPKNHKG, FLIAEPPCPCN<AvatarItemMaterial> HEDHEBOCOCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x6C7BBF0", Offset = "0x6C7AFF0", VA = "0x186C7BBF0")]
	public static NDMGPDLJHPE LIDOGEGODKP(AssetReference FBHDGFFELJP, [Optional] AssetReference IAKMKBCHMAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x6C7BA20", Offset = "0x6C7AE20", VA = "0x186C7BA20", Slot = "11")]
	protected override GGDKMGBLBOG HIHPHPGPLJL(Task<(GameObject, AvatarItemMaterial)> FIHALOMIDNB)
	{
		return default(GGDKMGBLBOG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x6C7B9A0", Offset = "0x6C7ADA0", VA = "0x186C7B9A0", Slot = "12")]
	protected override void GOIEHLKKJDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x6C7BAC0", Offset = "0x6C7AEC0", VA = "0x186C7BAC0")]
	[AsyncStateMachine(typeof(GGPMPCDLILE))]
	private static Task<(GameObject, AvatarItemMaterial)> JPJILMAJEBO(Task<GameObject> HKAFPFNDGBI, Task<AvatarItemMaterial> JPDLKDIIIKH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class MOCEDAFCOFJ
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	private class NICHPKLDCAE : PMDMPHJALAF<Task<MaterialMapAsset>, Material[]>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		private FLIAEPPCPCN<MaterialMapAsset> PKDPMCLKPHH;

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x6C7C510", Offset = "0x6C7B910", VA = "0x186C7C510")]
		public NICHPKLDCAE(FLIAEPPCPCN<MaterialMapAsset> PKDPMCLKPHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x6C7C0F0", Offset = "0x6C7B4F0", VA = "0x186C7C0F0", Slot = "11")]
		protected override Material[] HIHPHPGPLJL(Task<MaterialMapAsset> BIDGKFLMMBN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x6C7C090", Offset = "0x6C7B490", VA = "0x186C7C090", Slot = "12")]
		protected override void GOIEHLKKJDP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	private class DHOPIEMAFJH : PMDMPHJALAF<Task<Material[]>, Material[]>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		private List<FLIAEPPCPCN<Material>> FGIMIPJFHGE;

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x6C736E0", Offset = "0x6C72AE0", VA = "0x186C736E0")]
		public DHOPIEMAFJH(Task<Material[]> BIDGKFLMMBN, List<FLIAEPPCPCN<Material>> FGIMIPJFHGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x6C73690", Offset = "0x6C72A90", VA = "0x186C73690", Slot = "11")]
		protected override Material[] HIHPHPGPLJL(Task<Material[]> FIHALOMIDNB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x6C73550", Offset = "0x6C72950", VA = "0x186C73550", Slot = "12")]
		protected override void GOIEHLKKJDP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	private static readonly EGGMDNJPOBA DFDLACHAHGJ;

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x6C7B500", Offset = "0x6C7A900", VA = "0x186C7B500")]
	public static FLIAEPPCPCN<Material[]> GKCNNDHOKEF(AssetReference[] HLGNJCJOOAA)
	{
		return null;
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public class SkinnedMeshBonesInspector : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		[GNGJGNLFLFE(GODLKEADDAA.Self, false, false, false)]
		[SerializeField]
		private SkinnedMeshRenderer skinnedMeshRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		[SerializeField]
		private int BoneWeightsDisplayStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		[SerializeField]
		private int BoneWeightsDisplayAmount;

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x6C7C5F0", Offset = "0x6C7B9F0", VA = "0x186C7C5F0")]
		public SkinnedMeshBonesInspector()
		{
		}
	}
}
namespace RecRoom.Avatars.Face
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public sealed class FaceStyleSet : ScriptableObject
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000048")]
		[CompilerGenerated]
		private struct EPLDFOODLBL : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000210")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000211")]
			public AsyncTaskMethodBuilder<LKIFMGPDMFI> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000212")]
			public FaceStyleSet <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000213")]
			public int? eyeBrows;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000214")]
			public int eye;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000215")]
			public int mouth;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000216")]
			private TaskAwaiter<LKIFMGPDMFI> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x6C73750", Offset = "0x6C72B50", VA = "0x186C73750", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x6C73B30", Offset = "0x6C72F30", VA = "0x186C73B30", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		public SymmetricalFaceFeature[] EyeBrows;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		public EyesFaceFeature[] Eyes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		public NoseFaceOption[] Noses;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		public FaceFeature[] Mouths;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		[Header("Default Values")]
		public SymmetricalFaceFeature DefaultEyeBrowsFeature;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		public EyesFaceFeature DefaultEyesFeature;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		public FaceFeature DefaultMouthFeature;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		private Dictionary<LGPPHCHPBNO, SymmetricalFaceFeature> eyeBrowFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		private Dictionary<LGPPHCHPBNO, EyesFaceFeature> eyeFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		private Dictionary<LGPPHCHPBNO, NoseFaceOption> noseOptionsDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		private Dictionary<LGPPHCHPBNO, FaceFeature> mouthFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		private readonly Dictionary<LGPPHCHPBNO, int> featureToIndexMap;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		private LKIFMGPDMFI _defaultFaceStyleLegacyBean;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		private LKIFMGPDMFI _defaultFaceStyleModernBody;

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		private bool dictionariesInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0x6C74490", Offset = "0x6C73890", VA = "0x186C74490")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x6C74250", Offset = "0x6C73650", VA = "0x186C74250")]
		public LKIFMGPDMFI OEMCKMLBGIP(BMFEHMICIHN JEIAKJBAGMN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x6C73C50", Offset = "0x6C73050", VA = "0x186C73C50")]
		[AsyncStateMachine(typeof(EPLDFOODLBL))]
		public Task<LKIFMGPDMFI> BEDLOHLIJAF(int? NNGAHMNGKHC, int ELKBHPACBGK, int MPIHMCCHJNI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x6C73E00", Offset = "0x6C73200", VA = "0x186C73E00")]
		public NoseFaceOption ELKMNJMGJAD(int HMLCAFCFELM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x6C740D0", Offset = "0x6C734D0", VA = "0x186C740D0")]
		public SelectableFaceOption JLAAGHMGGHC(FaceFeatureType CMNNNENKABJ, LGPPHCHPBNO AJNKMDDAJCJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x6C73D80", Offset = "0x6C73180", VA = "0x186C73D80")]
		public int ECMIAIDEEAI(LGPPHCHPBNO AJNKMDDAJCJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x6C73EA0", Offset = "0x6C732A0", VA = "0x186C73EA0")]
		private void ILBIEFMEHPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x2E5F050", Offset = "0x2E5E450", VA = "0x182E5F050")]
		private void MGANIHLGEDI<T>(IDictionary<LGPPHCHPBNO, T> KFEJHMHFKIB, IReadOnlyList<T> LKAEDDHAJEA) where T : SelectableFaceOption
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x6C73BA0", Offset = "0x6C72FA0", VA = "0x186C73BA0")]
		public LGPPHCHPBNO BBKLDJHDELN(FaceFeatureType CMNNNENKABJ)
		{
			return default(LGPPHCHPBNO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x6C742E0", Offset = "0x6C736E0", VA = "0x186C742E0")]
		public LGPPHCHPBNO OJEAGJIHBAF(FaceFeatureType CMNNNENKABJ)
		{
			return default(LGPPHCHPBNO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x6C74400", Offset = "0x6C73800", VA = "0x186C74400")]
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
