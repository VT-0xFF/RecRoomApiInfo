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
	public class LogRegistrationIndex : HLBHPGBFEKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6C5D740", Offset = "0x6C5CB40", VA = "0x186C5D740", Slot = "4")]
		public override void MHJHNBDIMHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8D39D0", Offset = "0x8D2DD0", VA = "0x1808D39D0")]
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
	public class _AssemblyIndex : PPJBMGKOMFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6C5EB70", Offset = "0x6C5DF70", VA = "0x186C5EB70", Slot = "8")]
		public override void JFOOIIGPHCJ(GHGEJHAEAMC registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x648F4C0", Offset = "0x648E8C0", VA = "0x18648F4C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x8AD4C0", Offset = "0x8AC8C0", VA = "0x1808AD4C0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override string AssetGUID
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x6C5E2B0", Offset = "0x6C5D6B0", VA = "0x186C5E2B0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6C5E1D0", Offset = "0x6C5D5D0", VA = "0x186C5E1D0", Slot = "17")]
		public override bool RuntimeKeyIsValid()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6C5E270", Offset = "0x6C5D670", VA = "0x186C5E270")]
		public RecNetCDNAssetReference(RecNetCDNKey OEOMDKHBDFI)
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
			[Cpp2IlInjected.Address(RVA = "0x8A89D0", Offset = "0x8A7DD0", VA = "0x1808A89D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x8A8A00", Offset = "0x8A7E00", VA = "0x1808A8A00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public string CacheHash
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x8AD890", Offset = "0x8ACC90", VA = "0x1808AD890")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x8AD4B0", Offset = "0x8AC8B0", VA = "0x1808AD4B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6C5E2F0", Offset = "0x6C5D6F0", VA = "0x186C5E2F0")]
		public static RecNetCDNKey FMGAHHJDACA(string MAECPIBFDCJ, string LCMHABIBMOG = "")
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x644BC90", Offset = "0x644B090", VA = "0x18644BC90")]
		public void MEJEJOKNMOC(string MGMEJHJLEHI, string ACNHEEAHLIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6C5E3F0", Offset = "0x6C5D7F0", VA = "0x186C5E3F0")]
		public RecNetCDNKey()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[JEGDMIPNMMJ]
public class FPBDKGBMAMA : EOKKDJGDFIO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	protected readonly List<Mesh> BJPEAOLGONA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	protected readonly List<byte[]> HKJIANMPLAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	protected readonly List<Matrix4x4> BGDDHMGEIKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	protected readonly List<bool> IGECIBPKNHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	protected readonly List<int> EAOAHEDKIBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	protected readonly List<bool> IBMLNCFIEPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	protected readonly List<int> OHKINLBFFOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	protected Allocator KOAHLBKICFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	protected KKJEGBPDAFE NGBLMNHBFML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	protected byte ANEIJAPJHHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	protected IList<int> JDGPFFBIIKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	protected IList<int> FOBGJIBKBFI;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6C57DF0", Offset = "0x6C571F0", VA = "0x186C57DF0", Slot = "4")]
	public void DFIKDMNGJDM(Mesh NJMNIJFLOJJ, Matrix4x4 IDJCNBIJKPI, byte[] BCHEPNJELLJ, bool MHGNBPPCDAG = false, GKIFLDBNEKK.AOOMGKPMPMM HIJMMGHEDAN = (GKIFLDBNEKK.AOOMGKPMPMM)0, int OBKKOMFHNGG = -1, bool FDOHCBLPNNC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6C58000", Offset = "0x6C57400", VA = "0x186C58000", Slot = "5")]
	public void EHEOECNKEFE(Allocator HPLNAKONHEI, KKJEGBPDAFE LCNEKKDMOMP, byte CPDLADMMBGC, [Optional] IList<int> AOGMMABHBBI, [Optional] IList<int> GBCEKFOIAKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6C58040", Offset = "0x6C57440", VA = "0x186C58040")]
	private static void MPCDNDEHFNJ(Mesh NJMNIJFLOJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6C582A0", Offset = "0x6C576A0", VA = "0x186C582A0")]
	public FPBDKGBMAMA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[JEGDMIPNMMJ]
public struct AHKBDLDNNMD : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	[ReadOnly]
	public LFLFDABGEBM EFLNLDNKONN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	[ReadOnly]
	public int ENAEADCFINE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public ACMIMFDCLBM DAKJBCLGOFE;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6C49800", Offset = "0x6C48C00", VA = "0x186C49800", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[NativeContainer]
[JEGDMIPNMMJ]
public struct ACMIMFDCLBM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct CMDPCEKHHPP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public Vector3 BHFBOJGFAFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public Vector3 KENGOPLODLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public Vector4 NEOICEEMOHM;
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct DOGMMEPKEMD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public float ADNMGAHPJFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public float JLADJGGMINO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public float OMCBIGPPHFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public float ELJONNKLHPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public byte PIIDMDMBJCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public byte JGIHDFNDIHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public byte DJOELCKOBJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public byte EIIDIELPEFJ;
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct GJEKPMGEACC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public half ADNMGAHPJFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public half JLADJGGMINO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public half OMCBIGPPHFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public half ELJONNKLHPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public byte PIIDMDMBJCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public byte JGIHDFNDIHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public byte DJOELCKOBJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public byte EIIDIELPEFJ;
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct MDOADCCDCLG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public half4 KLMDPLMNJMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public half2 MLMJJDLPLJM;
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public struct JJFHIMABIFN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public half4 KLMDPLMNJMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public half2 MLMJJDLPLJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public half2 PILOECNPMJJ;
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct IEPDPGLJHAN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public half4 KLMDPLMNJMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public half2 MLMJJDLPLJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public half2 PILOECNPMJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public half2 BMGKALBFEEG;
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public struct LOHPOBGNDBI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public half4 KLMDPLMNJMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public half2 MLMJJDLPLJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public half2 PILOECNPMJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public half2 BMGKALBFEEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public half2 CPNMEHMNCNK;
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public struct NLPLONKMGPI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public float ADNMGAHPJFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public float JLADJGGMINO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public float OMCBIGPPHFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public float ELJONNKLHPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public int PIIDMDMBJCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public int JGIHDFNDIHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public int DJOELCKOBJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public int EIIDIELPEFJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public struct BBGCLKDNFLF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public Color KLMDPLMNJMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public Vector2 MLMJJDLPLJM;
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public struct PFOEDCPJCFC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public Color KLMDPLMNJMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public Vector2 MLMJJDLPLJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public Vector2 PILOECNPMJJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public struct EPJLBJJPMIE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public Color KLMDPLMNJMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public Vector2 MLMJJDLPLJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public Vector2 PILOECNPMJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public Vector2 BMGKALBFEEG;
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public struct ACNBCMFIGGM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public Color KLMDPLMNJMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Vector2 MLMJJDLPLJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public Vector2 PILOECNPMJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public Vector2 BMGKALBFEEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Vector2 CPNMEHMNCNK;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private bool FGNFFOAIOCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public NativeArray<CMDPCEKHHPP> GEAFLGFGJCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public NativeArray<MDOADCCDCLG> GEIMENJACCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public NativeArray<JJFHIMABIFN> IFAAAHLKEFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public NativeArray<IEPDPGLJHAN> MNJKKBKMODI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public NativeArray<LOHPOBGNDBI> NHBFFFLDDMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public NativeArray<GJEKPMGEACC> OGHKKDLFKJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public NativeArray<DOGMMEPKEMD> AFNPKINAFBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public NativeArray<BBGCLKDNFLF> INFHBHCINPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public NativeArray<PFOEDCPJCFC> KHDFFPLFHAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public NativeArray<EPJLBJJPMIE> PIGJONAIPOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public NativeArray<ACNBCMFIGGM> BLPAIJKGLOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public NativeArray<NLPLONKMGPI> JIOBMKDOPID;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public NativeArray<int> HKAPENBKAGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public NativeArray<int> KGLJEDNLHHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private NativeArray<int> GGAKEKHLJGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private NativeArray<int> FJMGIPIJGAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public NativeArray<int> MFKDCDFHHPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public NativeArray<int> HPKFGHGPBLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public NativeArray<int> EBDMNMBEAAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public NativeArray<BoneWeight> JKCMICELJIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private NativeArray<int> BJGOCALJFKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private bool IIFPMJBBPGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x159")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private bool DKLPHMCHPJM;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int KDIAKEFBLDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6C46940", Offset = "0x6C45D40", VA = "0x186C46940")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6C47040", Offset = "0x6C46440", VA = "0x186C47040")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int GDJMBJEJDCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6C48B80", Offset = "0x6C47F80", VA = "0x186C48B80")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6C47050", Offset = "0x6C46450", VA = "0x186C47050")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int IPEBLBKMPMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6C46930", Offset = "0x6C45D30", VA = "0x186C46930")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6C48B70", Offset = "0x6C47F70", VA = "0x186C48B70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int MECFLNJEFGA
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6C468C0", Offset = "0x6C45CC0", VA = "0x186C468C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6C48C20", Offset = "0x6C48020", VA = "0x186C48C20")]
	public ACMIMFDCLBM(int EBLPIEFGCOB, int GKEPBDHAEBP, int OEFOGGEOCNL, int FCGFDCFPJNA, Allocator HPLNAKONHEI, int DANKCNFEGEM, JEIPKIBEAJE OBIAJJKMLMB, bool IIFPMJBBPGH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6C48B90", Offset = "0x6C47F90", VA = "0x186C48B90")]
	public void NNENLJGCNNJ(int HAJICDLBEKC, Vector3 IFLBFOHFIEP, Vector3 AFMDDDNOHPC, Vector4 KBFPLGGGODF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6C46C10", Offset = "0x6C46010", VA = "0x186C46C10")]
	public void EGMFDNFIIHC(int HAJICDLBEKC, BoneWeight CKDNHBKAFJG, NativeSlice<byte> BCHEPNJELLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6C47060", Offset = "0x6C46460", VA = "0x186C47060")]
	public Color GGDALLAPDFB(int HAJICDLBEKC)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6C47390", Offset = "0x6C46790", VA = "0x186C47390")]
	public void HHMPKAKJEAP(int HAJICDLBEKC, Color JEGEADOBKMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6C487C0", Offset = "0x6C47BC0", VA = "0x186C487C0")]
	public void JMGPOHINFFB(byte EAJKFEKJHKG, int HAJICDLBEKC, Vector2 OJPKKNBGCBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6C47860", Offset = "0x6C46C60", VA = "0x186C47860")]
	public void INMGMHIKLKM(int HAJICDLBEKC, int IMFGMPANDMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6C46950", Offset = "0x6C45D50", VA = "0x186C46950")]
	public bool DCFJJCFNBOP(int EAJKFEKJHKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6C47790", Offset = "0x6C46B90", VA = "0x186C47790")]
	public void IBFINFHIDLF(int IFPNIOEKKCD, int OLMEFNCLGNG, int LOKMFEIHLAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6C469B0", Offset = "0x6C45DB0", VA = "0x186C469B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6C47870", Offset = "0x6C46C70", VA = "0x186C47870")]
	public Mesh JGKGBHOHBEF([Optional] string DOLFCFEJJFK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[NativeContainer]
[JEGDMIPNMMJ]
[DefaultMember("Item")]
public struct LFLFDABGEBM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public Mesh.MeshDataArray NCJIEPKOMHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public NativeArray<int> NDBKIHPPHJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public NativeArray<int> GCFGJMKLHHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public NativeArray<BoneWeight> JKCMICELJIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private NativeArray<Matrix4x4> BPJOCFAPOKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private NativeArray<int> DIIDHPIFHOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private NativeArray<byte> OELFPKFGJIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private NativeArray<int> AHKMFJMFKPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private NativeArray<int> KMFEDKBKNDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public NativeArray<sbyte> OBANEHFCJNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public NativeArray<byte> PCFHGJJHOKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public NativeArray<bool> FDOHCBLPNNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public NativeArray<int> OBKKOMFHNGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private bool IIFPMJBBPGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private NativeArray<int> HEANGJGKJHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private bool DKLPHMCHPJM;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public int KICMEOGDMFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6C5A010", Offset = "0x6C59410", VA = "0x186C5A010")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int LPNKMDDDAJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6C59F00", Offset = "0x6C59300", VA = "0x186C59F00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int OCBMKBBKPJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6C59C70", Offset = "0x6C59070", VA = "0x186C59C70")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int DEONJCFNKLI
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6C59F10", Offset = "0x6C59310", VA = "0x186C59F10")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6C59EE0", Offset = "0x6C592E0", VA = "0x186C59EE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int KDIAKEFBLDB
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6C59D40", Offset = "0x6C59140", VA = "0x186C59D40")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x6C59EF0", Offset = "0x6C592F0", VA = "0x186C59EF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int BJOEIKBMEOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x6C5A020", Offset = "0x6C59420", VA = "0x186C5A020")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x6C5A000", Offset = "0x6C59400", VA = "0x186C5A000")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public KKJEGBPDAFE BBLHPNHIBPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6C59D50", Offset = "0x6C59150", VA = "0x186C59D50")]
		get
		{
			return default(KKJEGBPDAFE);
		}
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6C5A280", Offset = "0x6C59680", VA = "0x186C5A280")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public byte LEFHNEBBILP
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6C59ED0", Offset = "0x6C592D0", VA = "0x186C59ED0")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6C59FF0", Offset = "0x6C593F0", VA = "0x186C59FF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public ANCDMFOMKKP MGACFGHHFEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6C5A030", Offset = "0x6C59430", VA = "0x186C5A030")]
		get
		{
			return default(ANCDMFOMKKP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6C5A290", Offset = "0x6C59690", VA = "0x186C5A290")]
	public LFLFDABGEBM(IList<Mesh> NNHFIFEBCDF, IList<Matrix4x4> GDAPAHEOJNI, IList<bool> FDOHCBLPNNC, byte CPDLADMMBGC, IList<byte[]> FPCADPAGEHD, IList<int> LGLEHOAKFIA, IList<bool> NJKJIIENGBL, IList<int> OBKKOMFHNGG, IList<int> AOGMMABHBBI, IList<int> INMBELHNKDN, Allocator HPLNAKONHEI, KKJEGBPDAFE LCNEKKDMOMP, bool IIFPMJBBPGH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6C59F20", Offset = "0x6C59320", VA = "0x186C59F20")]
	public ACMIMFDCLBM IAGAAEJIJGG(Allocator HPLNAKONHEI, JEIPKIBEAJE OBIAJJKMLMB)
	{
		return default(ACMIMFDCLBM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6C59D60", Offset = "0x6C59160", VA = "0x186C59D60", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[JEGDMIPNMMJ]
public class PBMOJPNMBDD : FPBDKGBMAMA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public bool LMHLGOLLPDG;

	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private static readonly ProfilerMarker BLJJNIJKIGD;

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6C5DEC0", Offset = "0x6C5D2C0", VA = "0x186C5DEC0")]
	public LFLFDABGEBM KGNHMMEKNCG()
	{
		return default(LFLFDABGEBM);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6C5E1C0", Offset = "0x6C5D5C0", VA = "0x186C5E1C0")]
	public PBMOJPNMBDD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct ANCDMFOMKKP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public Mesh.MeshData AEHMILMACEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public NativeSlice<BoneWeight> JKCMICELJIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public NativeSlice<byte> KIIKPJJOHPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public int DJCPLFAHABC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public Matrix4x4 OJOPIAJPKAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public int EDNEEBBIDNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public NativeSlice<byte> BCHEPNJELLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public bool JPFJOKNGKGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public int NEDDAENJMPK;
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class BAJDMDMLFIB : HOKJPOPDING
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	private abstract class OOCPEJIGCDC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public readonly IMEAMGPJJIG HFILAEENIKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		protected bool JGJHMHPGKMP;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public virtual bool BADFFHBGELC
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x8F2CF0", Offset = "0x8F20F0", VA = "0x1808F2CF0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public virtual bool CGJDLMAJPNF
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x8F2CF0", Offset = "0x8F20F0", VA = "0x1808F2CF0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public virtual GKIFLDBNEKK.AOOMGKPMPMM EDNEEBBIDNA
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x8AA280", Offset = "0x8A9680", VA = "0x1808AA280", Slot = "6")]
			get
			{
				return default(GKIFLDBNEKK.AOOMGKPMPMM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public bool BAPBPBCBEBE
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0xBE3D50", Offset = "0xBE3150", VA = "0x180BE3D50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public bool JFNAEOCIOCA
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x1966540", Offset = "0x1965940", VA = "0x181966540")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public bool EJLIOGICOLM
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x6C5DC40", Offset = "0x6C5D040", VA = "0x186C5DC40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public bool MKBEHNBNHIF
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x6C5DC50", Offset = "0x6C5D050", VA = "0x186C5DC50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x8B2270", Offset = "0x8B1670", VA = "0x1808B2270")]
		protected OOCPEJIGCDC(IMEAMGPJJIG BIDGLNHAOCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract GELPMBCHBBO BBGJAAMLELK(int[] BPPBFPBBIPC, List<NDCHECJCLID> HIHJNFGJBME, List<NDCHECJCLID> FONIIBCCBMF);

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract AFGBEBLIKGN IFOHIAEIMBH(uint LBPCGMGCBGG, AvatarSkinnedMeshBoneOrderRemapsData ODBFJLDLLLB);
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	private class IJLNEKELOKE : OOCPEJIGCDC
	{
		[Cpp2IlInjected.Token(Token = "0x200001C")]
		[CompilerGenerated]
		private sealed class CBGJNPIICCO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000DE")]
			public GHMLKDLFDEG<GameObject> skinAvatarItemPrefabHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000DF")]
			public IJLNEKELOKE <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
			public CBGJNPIICCO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x6C57770", Offset = "0x6C56B70", VA = "0x186C57770")]
			internal void NLEBNFKFHFM(GameObject result)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private readonly AvatarSkinAssetItem.PDLPMLPIPNO HCJAHGFHNIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private readonly AssetReference CAFGLDMMBAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private readonly GKIFLDBNEKK.AOOMGKPMPMM DGKJKNFMHCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private readonly OBBAPCJJCDJ? BEJJIFFBENK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private readonly Material[] FDIJOAOBOOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		private SkinnedMeshRenderer[] LJAJKKLIMJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private AvatarSkinAssetItem DNNHPPHFDHP;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override GKIFLDBNEKK.AOOMGKPMPMM EDNEEBBIDNA
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x8A8A30", Offset = "0x8A7E30", VA = "0x1808A8A30", Slot = "6")]
			get
			{
				return default(GKIFLDBNEKK.AOOMGKPMPMM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x6C589E0", Offset = "0x6C57DE0", VA = "0x186C589E0")]
		public IJLNEKELOKE(AvatarSkinAssetItem.PDLPMLPIPNO KFONNCKAEBK, AssetReference PGLAOGOCANK, Material OPLBKIMAINL, IMEAMGPJJIG COCDOPPFGOL, GKIFLDBNEKK.AOOMGKPMPMM HLFPEBFLCEF = (GKIFLDBNEKK.AOOMGKPMPMM)0, [Optional] OBBAPCJJCDJ? KNPGEIPOCNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x6C58AF0", Offset = "0x6C57EF0", VA = "0x186C58AF0")]
		public IJLNEKELOKE(AvatarSkinAssetItem.PDLPMLPIPNO KFONNCKAEBK, AssetReference PGLAOGOCANK, Material OPLBKIMAINL, GKIFLDBNEKK.AOOMGKPMPMM HLFPEBFLCEF = (GKIFLDBNEKK.AOOMGKPMPMM)0, [Optional] OBBAPCJJCDJ? KNPGEIPOCNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x6C584D0", Offset = "0x6C578D0", VA = "0x186C584D0", Slot = "7")]
		public override GELPMBCHBBO BBGJAAMLELK(int[] BPPBFPBBIPC, List<NDCHECJCLID> HIHJNFGJBME, List<NDCHECJCLID> FONIIBCCBMF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x6C586A0", Offset = "0x6C57AA0", VA = "0x186C586A0", Slot = "8")]
		public override AFGBEBLIKGN IFOHIAEIMBH(uint LBPCGMGCBGG, AvatarSkinnedMeshBoneOrderRemapsData ODBFJLDLLLB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x6C58970", Offset = "0x6C57D70", VA = "0x186C58970", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	private class JBJMAPAEOKE : OOCPEJIGCDC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public readonly IJIAHPGOAKB EJDKGNEJMOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private GHMLKDLFDEG<JEHBKEBENNL> MGFDPCINHIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public JEHBKEBENNL LOJPFHFLDJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private GHMLKDLFDEG<Material[]> DEGBEPOOBBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public Material[] IFFFNCCJLEM;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public override bool BADFFHBGELC
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x8C4810", Offset = "0x8C3C10", VA = "0x1808C4810", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override bool CGJDLMAJPNF
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x6C59730", Offset = "0x6C58B30", VA = "0x186C59730", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x6C598A0", Offset = "0x6C58CA0", VA = "0x186C598A0")]
		public JBJMAPAEOKE(IMEAMGPJJIG BIDGLNHAOCC, IJIAHPGOAKB NJAHHMCBING)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x6C58C00", Offset = "0x6C58000", VA = "0x186C58C00", Slot = "7")]
		public override GELPMBCHBBO BBGJAAMLELK(int[] BPPBFPBBIPC, List<NDCHECJCLID> HIHJNFGJBME, List<NDCHECJCLID> FONIIBCCBMF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x6C59600", Offset = "0x6C58A00", VA = "0x186C59600", Slot = "8")]
		public override AFGBEBLIKGN IFOHIAEIMBH(uint LBPCGMGCBGG, AvatarSkinnedMeshBoneOrderRemapsData ODBFJLDLLLB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x6C593F0", Offset = "0x6C587F0", VA = "0x186C593F0")]
		public AFGBEBLIKGN DINFOGJCNAG(GameObject GDJGHDDILHJ, uint LBPCGMGCBGG, bool DKPEGLKDGNH, bool OBOCFBCDDPC, AvatarSkinnedMeshBoneOrderRemapsData ODBFJLDLLLB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x6C59090", Offset = "0x6C58490", VA = "0x186C59090")]
		public static bool COJIBBJPKBC(Renderer[] OHMPGGFLDOJ, string LIILILEECJM, [Out] Renderer MLBEPLPPLNI, [Out] Renderer DDDAKACJBMA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x6C59850", Offset = "0x6C58C50", VA = "0x186C59850", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x6C59790", Offset = "0x6C58B90", VA = "0x186C59790")]
		private (GHMLKDLFDEG<JEHBKEBENNL>, GHMLKDLFDEG<Material[]>) LGGKGEIGPGL()
		{
			return default((GHMLKDLFDEG<JEHBKEBENNL>, GHMLKDLFDEG<Material[]>));
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x45FA830", Offset = "0x45F9C30", VA = "0x1845FA830")]
		[CompilerGenerated]
		private void KLAJJIHFOJK(JEHBKEBENNL IPNDOKDOGDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x8ADA40", Offset = "0x8ACE40", VA = "0x1808ADA40")]
		[CompilerGenerated]
		private void KDPNHOELIGC(Material[] IPNDOKDOGDG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class AFPJPHIMGCE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public MCKGMIOBLPO avatarBuildParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public BAJDMDMLFIB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public OIBEFKNOBGF buildMeshPromise;

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public AFPJPHIMGCE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x6C49650", Offset = "0x6C48A50", VA = "0x186C49650")]
		internal bool BJLPOJGKLIN(IJIAHPGOAKB item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x6C49750", Offset = "0x6C48B50", VA = "0x186C49750")]
		internal void EENNIBFFKBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x6C49730", Offset = "0x6C48B30", VA = "0x186C49730")]
		internal void DIDJMDLBNBG(string err)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x6C496A0", Offset = "0x6C48AA0", VA = "0x186C496A0")]
		internal void BOLFJAHCDDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x6C49770", Offset = "0x6C48B70", VA = "0x186C49770")]
		internal void MOFIKKAHMCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x8A89D0", Offset = "0x8A7DD0", VA = "0x1808A89D0")]
		internal GELPMBCHBBO IGJMLFFDKAC()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class AMJIIALKCOG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public int lowestPossibleLOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public AFPJPHIMGCE CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public AMJIIALKCOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x6C4B2E0", Offset = "0x6C4A6E0", VA = "0x186C4B2E0")]
		internal PJMJJMFIGKK OPNMGPIOKIP(int lod)
		{
			return default(PJMJJMFIGKK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class KIGGOHHMEEH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public List<OIBEFKNOBGF> innerPromises;

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public KIGGOHHMEEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x6C59B40", Offset = "0x6C58F40", VA = "0x186C59B40")]
		internal void EHOPMHGGLOI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class PANABIOGEMF : IEnumerator<DNOIEDKBBPN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private DNOIEDKBBPN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public BAJDMDMLFIB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public List<OOCPEJIGCDC> parts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public int[] LODs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public List<OIBEFKNOBGF> innerPromises;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public bool isFirstPerson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public Func<int, PJMJJMFIGKK> getLayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public NKIDBPJKEGH materialPropertyBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public Material materialInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private int <lodIndex>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		private DNOIEDKBBPN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x8A89C0", Offset = "0x8A7DC0", VA = "0x1808A89C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x8A89C0", Offset = "0x8A7DC0", VA = "0x1808A89C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x8B2270", Offset = "0x8B1670", VA = "0x1808B2270")]
		[DebuggerHidden]
		public PANABIOGEMF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x6C5DC70", Offset = "0x6C5D070", VA = "0x186C5DC70", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x6C5DE70", Offset = "0x6C5D270", VA = "0x186C5DE70", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class CNDNHKKEPEI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public int[] LODs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public BAJDMDMLFIB <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public CNDNHKKEPEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x6C57B60", Offset = "0x6C56F60", VA = "0x186C57B60")]
		internal GELPMBCHBBO APLPCGCBMPP(OOCPEJIGCDC p)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class MPNMMJPOHMI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public GBCOAMHMLKP cancelable;

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public MPNMMJPOHMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0xA5DDF0", Offset = "0xA5D1F0", VA = "0x180A5DDF0")]
		internal void MJCEIEJMKHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0xCFDF70", Offset = "0xCFD370", VA = "0x180CFDF70")]
		internal void BNMIJMDILPD(string err)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class KFOHNAGGKGD
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
		public BAJDMDMLFIB <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public KFOHNAGGKGD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class FOJOHLFKODB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public bool waitingForComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public JobHandle lodBuildJobHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public ACMIMFDCLBM defaultMeshJobContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public LFLFDABGEBM defaultAvatarMeshJobGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public KFOHNAGGKGD CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public FOJOHLFKODB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x6C57BB0", Offset = "0x6C56FB0", VA = "0x186C57BB0")]
		internal void GFJANCKONLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0xCFF660", Offset = "0xCFEA60", VA = "0x180CFF660")]
		internal void CIOLFGPCIHO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private sealed class JKFDPIEONGC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public bool waitingForComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public JobHandle lodBuildJobHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public NJCIBGKMEOI legacyMeshJobContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public CDLFPNFBION legacyAvatarMeshJobGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public KFOHNAGGKGD CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public JKFDPIEONGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x6C59900", Offset = "0x6C58D00", VA = "0x186C59900")]
		internal void OGDMCAGMCBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0xCFF3B0", Offset = "0xCFE7B0", VA = "0x180CFF3B0")]
		internal void FJAOHMBKBOD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class NDCACBMAGML
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public KeyValuePair<string, IJIAHPGOAKB> entry;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public GBCOAMHMLKP cancelablePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public IJIAHPGOAKB avatarItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public BAJDMDMLFIB <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public NDCACBMAGML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x6C5D810", Offset = "0x6C5CC10", VA = "0x186C5D810")]
		internal GELPMBCHBBO IEFPDCCNFIH(IFFPFMJLDIO item)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x6C5D7D0", Offset = "0x6C5CBD0", VA = "0x186C5D7D0")]
		internal void CPMCODICFEH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class LICKBGNBLDB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public GHMLKDLFDEG<Texture2D> resourceHandle;

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public LICKBGNBLDB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x6C5D6F0", Offset = "0x6C5CAF0", VA = "0x186C5D6F0")]
		internal void AFLKHJLFGMH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class LICFKNDFJGI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public string overrideItemIdentifier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public IMEAMGPJJIG overrideBodyPart;

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public LICFKNDFJGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x6C5D670", Offset = "0x6C5CA70", VA = "0x186C5D670")]
		internal bool OOPKPHOJIJF(KeyValuePair<string, IJIAHPGOAKB> entry)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private AvatarConfiguration BNEBPBGFAEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private Transform GPKIMNOCIEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private AssetReference CAFGLDMMBAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private GameObject ICDDBJFANIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private GameObject FFEGBADDNHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private SkinnedMeshRenderer FILIOJAJFDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private AvatarSkinnedMeshBoneOrderRemapsData BKLEPJJGEAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private Transform[] OPJHLDFBDGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private Matrix4x4[] BLDMPCODLAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private Material EPNMCBMHBCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private Material PHDFLFGCAIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private Material DLCCICIFCBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private Shader ILDCJLJIOEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private Shader DCBMDEGMJHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private Animator ECKABNKLGLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private Renderer[] DENPJHKFGNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private GKIFLDBNEKK.AOOMGKPMPMM AIIPEBOIFJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private AvatarBodyPartShapesManager PPHODKNCEJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private IReadOnlyDictionary<string, Transform> MJKMILLPPEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private AvatarFaceShapeData.AOGGGPOLIIA MPOCLDLMMLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private AvatarBodyShapeData.BGCCKPJDFLO JEFHFKMENNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private bool GGNGBPAJLOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB1")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private bool NNMBGONOKNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private Color MAHFADCMMOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private Color MPGHINOMDCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private Color EIGDIDFDFPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private Color? JOFCBPJJCLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private Color? GNCOONLPCJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10C")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private Color? JPDCDHIHPEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private Color? HPBDCHACENG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private Texture2D COFJBDECGHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private Texture2D PFNHACJHDHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	[CanBeNull]
	private IJIAHPGOAKB AOGAHEDFHNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private Texture DIILAGPOPDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private Color ELMKNBFKPBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public Dictionary<Renderer, NKIDBPJKEGH> PDFNANHPMLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private Dictionary<Renderer, NKIDBPJKEGH> AHBLKMHANPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private Dictionary<string, List<EIKFFMODGOE>> MHCCLCJNOLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private Dictionary<string, List<EIKFFMODGOE>> POGEGELIDIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private readonly List<NDCHECJCLID> PPOAFGBJGGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private readonly List<NDCHECJCLID> HBJGBCAOHNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly List<NDCHECJCLID> NDMNHJMEKKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private readonly List<NDCHECJCLID> LEPMOCGLNBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private Dictionary<EIKFFMODGOE, Material> ANECCFIMMPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private Dictionary<EIKFFMODGOE, Material> BMDMPAFGGMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private SkinnedMeshRenderer[] ICJGMELOJNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private SkinnedMeshRenderer[] BGIMANPLIPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private SkinnedMeshRenderer[] LMBFNGJBNEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private SkinnedMeshRenderer[] GCFDFIBKJPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private readonly Dictionary<string, GHMLKDLFDEG<Texture2D>> GNMJCKGJCBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private readonly Dictionary<string, GHMLKDLFDEG<Texture2D>> KFPPDLHKBJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private AdditionalHatData AEPOHOPNBJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private AdditionalHatData CAHCEACEKFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private HairData NNNPJCJJAHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private HairData FDJAEMJOCCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private FFMFOGNHMIP OEMGBIBBHKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private bool? GJCHPLNMBGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x214")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private PositionAndRotation PHCMLKMHGEK;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private Material ADCDLOEDGMG;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private Material NLFKGKKLDNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private Dictionary<string, IJIAHPGOAKB> DMGIIPDPKBH;

	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private static readonly int NOGOJCBKPEB;

	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private static readonly int IGDAFDEJDBL;

	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private static readonly int LAFPMFAMKKN;

	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private static readonly int BNEPCLJPCFA;

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private static readonly int PKJBCNCBIDN;

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private static readonly int CEBAIBCLBEN;

	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private static readonly int LKIBLJMHHKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private readonly LDNMACGBDLI NPPLNIPBEFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private readonly LDNMACGBDLI KPCIKAFENLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private bool GGALJBPGIBH;

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private static Lazy<OMPFDBLPBEP> HLAMINIEJOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private Lazy<MCKKBBHAPNN> OGGDCJLANJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private Lazy<HCLPMJBBIMK> AADGMDKBKGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private AOCBOCJDGCN NEAIHGDNFNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private List<Action> HPNEDONCOCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private CHCAPIDJDOC JENLKPDACOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private SkinnedMeshRenderer[] FCKNAHJBMLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private int EHCEFCMMFEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x294")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private bool MOMKGAIDPNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private int JBEBFEBOPFH;

	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private static bool FJMIAKNNPBD;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool MOMMCINFMCN
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0xC7E9E0", Offset = "0xC7DDE0", VA = "0x180C7E9E0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xC7E9C0", Offset = "0xC7DDC0", VA = "0x180C7E9C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private Material NFNNCAJLIIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x6C4D9E0", Offset = "0x6C4CDE0", VA = "0x186C4D9E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private Material OOPNEKCIGAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x6C51230", Offset = "0x6C50630", VA = "0x186C51230")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private bool NCHDMKPBJEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8C4810", Offset = "0x8C3C10", VA = "0x1808C4810")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public OJHEMGLCFCA AGBPFEMKBEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x938250", Offset = "0x937650", VA = "0x180938250", Slot = "21")]
		get
		{
			return default(OJHEMGLCFCA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	private static OMPFDBLPBEP HEFFGHBGHBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6C54800", Offset = "0x6C53C00", VA = "0x186C54800")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	private MCKKBBHAPNN BAPMFMKOOCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6C55950", Offset = "0x6C54D50", VA = "0x186C55950")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private HCLPMJBBIMK MOBFNLKNLBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6C50350", Offset = "0x6C4F750", VA = "0x186C50350")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	private AOCBOCJDGCN FKMOFFAKIJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6C4D7F0", Offset = "0x6C4CBF0", VA = "0x186C4D7F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public LDNMACGBDLI EOIBLPNIDED
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x921F60", Offset = "0x921360", VA = "0x180921F60", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public LDNMACGBDLI IGJNNBBMHHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x921F30", Offset = "0x921330", VA = "0x180921F30", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public SkinnedMeshRenderer[] HGBFEMNMGKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x1AE9410", Offset = "0x1AE8810", VA = "0x181AE9410", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public Renderer[] PDPMCNBDBMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x8AFC80", Offset = "0x8AF080", VA = "0x1808AFC80", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool IMGCGJCAPJE
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6C4FF50", Offset = "0x6C4F350", VA = "0x186C4FF50", Slot = "20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public PositionAndRotation OODKACJADDI
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6C50320", Offset = "0x6C4F720", VA = "0x186C50320", Slot = "27")]
		get
		{
			return default(PositionAndRotation);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public GKIFLDBNEKK.AOOMGKPMPMM HGOGFKIHGEN
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x8AFC90", Offset = "0x8AF090", VA = "0x1808AFC90", Slot = "18")]
		get
		{
			return default(GKIFLDBNEKK.AOOMGKPMPMM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public int PMCKGDIGKOA
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x1B81950", Offset = "0x1B80D50", VA = "0x181B81950")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x6C4E1C0", Offset = "0x6C4D5C0", VA = "0x186C4E1C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	private bool PDPPFEBKCND
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x6C4FED0", Offset = "0x6C4F2D0", VA = "0x186C4FED0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private static bool FKMMLFOPKGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6C50180", Offset = "0x6C4F580", VA = "0x186C50180")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6C56FC0", Offset = "0x6C563C0", VA = "0x186C56FC0")]
	public BAJDMDMLFIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x6C4DF00", Offset = "0x6C4D300", VA = "0x186C4DF00", Slot = "28")]
	public void CGCFJDLGJFP(KGENCGFINOE HGOOHDFFPKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6C4FA50", Offset = "0x6C4EE50", VA = "0x186C4FA50", Slot = "29")]
	public void EBELDMFHNMM(CDPHGAGLOME IBAOJNOIDIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6C4E1C0", Offset = "0x6C4D5C0", VA = "0x186C4E1C0", Slot = "4")]
	public void CGCIHDFPOMF(int LBPCGMGCBGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6C54D90", Offset = "0x6C54190", VA = "0x186C54D90", Slot = "9")]
	public void LPOCCJDMPIG(EPBMIKDDMPL EJBLJPIFEAB, Texture2D NAKFIPIKBBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6C54780", Offset = "0x6C53B80", VA = "0x186C54780", Slot = "10")]
	public void LADBAIBOLGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6C50460", Offset = "0x6C4F860", VA = "0x186C50460", Slot = "11")]
	public bool GEJDCBJDNNJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6C51D30", Offset = "0x6C51130", VA = "0x186C51D30", Slot = "8")]
	public void JMHFGAFFMCM(BICLHCKJMDO MDMODPKLACI, Color? KLMDPLMNJMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6C55A70", Offset = "0x6C54E70", VA = "0x186C55A70")]
	private void OAFGHLMIBPD(Action GEHDJDJBEPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x6C4DE90", Offset = "0x6C4D290", VA = "0x186C4DE90", Slot = "5")]
	public void CBFKKCCMNEA(IJIAHPGOAKB MMNKINILOHN, Texture CPKKDCABMEA, Color GHLPAHFLHMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0xC7E9C0", Offset = "0xC7DDC0", VA = "0x180C7E9C0", Slot = "6")]
	public void KEIBJADHHNK(bool GFBMFJPMPDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x1AB45D0", Offset = "0x1AB39D0", VA = "0x181AB45D0", Slot = "7")]
	public void HCPLDEKJHMA(CHCAPIDJDOC BJGOCALJFKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6C53170", Offset = "0x6C52570", VA = "0x186C53170", Slot = "14")]
	public OIBEFKNOBGF KPLAGGGNHLH(MCKGMIOBLPO GNGCPHAOKCD, bool BANPJLMOKLL, int[] KIPHMBCDNJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6C52D10", Offset = "0x6C52110", VA = "0x186C52D10", Slot = "15")]
	public void KIHOFGDHGPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6C4ECA0", Offset = "0x6C4E0A0", VA = "0x186C4ECA0", Slot = "26")]
	public void DIFLKOEPANG([Optional] FFMFOGNHMIP KPJNCLNNBDL, [Optional] bool? HMIJLEDNEDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6C527B0", Offset = "0x6C51BB0", VA = "0x186C527B0")]
	private bool KEIALEKGMGI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6C54A60", Offset = "0x6C53E60", VA = "0x186C54A60", Slot = "19")]
	public bool LGEOCNNMDFJ(GKIFLDBNEKK.AOOMGKPMPMM DCKDDPPHEHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6C500C0", Offset = "0x6C4F4C0", VA = "0x186C500C0")]
	private bool EKFIFFIGEDB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6C55FF0", Offset = "0x6C553F0", VA = "0x186C55FF0")]
	private OIBEFKNOBGF PAENDFNPNMO(bool BANPJLMOKLL, List<OOCPEJIGCDC> OMFJPOFAJNA, int[] KIPHMBCDNJM, Func<int, PJMJJMFIGKK> KJBDCPJEKBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6C51120", Offset = "0x6C50520", VA = "0x186C51120")]
	[IteratorStateMachine(typeof(PANABIOGEMF))]
	private IEnumerator<DNOIEDKBBPN> IKOLLFHNNDA(bool BANPJLMOKLL, List<OOCPEJIGCDC> OMFJPOFAJNA, int[] KIPHMBCDNJM, Func<int, PJMJJMFIGKK> KJBDCPJEKBO, NKIDBPJKEGH JALGBDJHIME, Material IHANKILIANB, List<OIBEFKNOBGF> JMJLOIFPDCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6C55D30", Offset = "0x6C55130", VA = "0x186C55D30")]
	private OIBEFKNOBGF PADCNBHCIIP(List<OOCPEJIGCDC> OMFJPOFAJNA, int[] KIPHMBCDNJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6C4B500", Offset = "0x6C4A900", VA = "0x186C4B500")]
	private NFIGMHBJPEE AHKIJHDNGOB(List<OOCPEJIGCDC> OMFJPOFAJNA, int LBPCGMGCBGG, bool BANPJLMOKLL, PJMJJMFIGKK JCGJDGGDBAD, bool JCDFGLIEDOO, NKIDBPJKEGH JALGBDJHIME, Material IHANKILIANB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6C503A0", Offset = "0x6C4F7A0", VA = "0x186C503A0", Slot = "22")]
	public void FMOEGNJGDGB(AvatarFaceShape KODEIFEFKAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6C50E50", Offset = "0x6C50250", VA = "0x186C50E50", Slot = "23")]
	public void HBLBMGMEFJG(AvatarBodyShape KOCHFEMBACP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6C569A0", Offset = "0x6C55DA0", VA = "0x186C569A0", Slot = "25")]
	public void PMFNBMPBIHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6C50F10", Offset = "0x6C50310", VA = "0x186C50F10", Slot = "24")]
	public void HDGNICIFDIK(bool KOHCHEDDGJI, bool AEANAEGACPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6C50FE0", Offset = "0x6C503E0", VA = "0x186C50FE0")]
	private void IGPMGEBDPIL(SkinnedMeshRenderer JMCIHJFDBOB, int LBPCGMGCBGG, Mesh NJMNIJFLOJJ, List<Material> GNPODEGJGLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6C52F10", Offset = "0x6C52310", VA = "0x186C52F10")]
	private static Material KKLLIIBGIPL(Dictionary<EIKFFMODGOE, Material> FFEMEOOMBKN, Material JKOBCHDPCBP, LAKFFHJCLPB KHCHAMPMAAE, DLCALALIIEI CDFKAOBGJFG, IMEAMGPJJIG COCDOPPFGOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6C505F0", Offset = "0x6C4F9F0", VA = "0x186C505F0")]
	private static LAKFFHJCLPB GKLOCIDKNGG(OOCPEJIGCDC HKNPIHNDDDF, int NILONGLCGNA)
	{
		return default(LAKFFHJCLPB);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6C528F0", Offset = "0x6C51CF0", VA = "0x186C528F0")]
	private void KGINLEHLDCA(int HNPMNLHIFMJ, Material PBHLFFKCLKK, OOCPEJIGCDC HKNPIHNDDDF, [Out] Texture2D BIJMJNLIOKH, [Out] Vector4 OANNBMJKCFL, [Out] Texture2D HILEOJNLLDC, [Out] Texture2D OBFGMDLKLJN, [Out] Texture2D MOHDNOHEJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6C55030", Offset = "0x6C54430", VA = "0x186C55030")]
	private void MLMKKBHBLNO(int HNPMNLHIFMJ, Material PBHLFFKCLKK, OOCPEJIGCDC HKNPIHNDDDF, [Out] Color CENFBBIKNGC, [Out] Color JIBFIPNOONF, [Out] Color CFLCPNAMEEN, [Out] Color LHEMDHHPADK, [Out] Color KBADANLMPEC, [Out] Color OJMPBJIBIMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6C55510", Offset = "0x6C54910", VA = "0x186C55510")]
	private bool MMGHOJDBFJI(Material PBHLFFKCLKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6C54D40", Offset = "0x6C54140", VA = "0x186C54D40")]
	private static Material LJNGBMDMDCO(int HNPMNLHIFMJ, JBJMAPAEOKE HKNPIHNDDDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6C53070", Offset = "0x6C52470", VA = "0x186C53070")]
	private static DLCALALIIEI KLOMEFOGPJE(OOCPEJIGCDC HKNPIHNDDDF, int NILONGLCGNA)
	{
		return default(DLCALALIIEI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6C4D080", Offset = "0x6C4C480", VA = "0x186C4D080")]
	private static void AHLANLCPMOM(Dictionary<string, List<EIKFFMODGOE>> JBDFBNJNGAL, OOCPEJIGCDC HGPKJALKCIB, Material JKOBCHDPCBP, LAKFFHJCLPB MDMODPKLACI, DLCALALIIEI EJBLJPIFEAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6C565C0", Offset = "0x6C559C0", VA = "0x186C565C0")]
	private static SkinnedMeshRenderer PDEHILBKMLM(Transform BDCAAONCKOH, Transform DJMGBMEEGOJ, SkinnedMeshRenderer[] OHMPGGFLDOJ, int LBPCGMGCBGG, PJMJJMFIGKK JCGJDGGDBAD, bool BANPJLMOKLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6C548A0", Offset = "0x6C53CA0", VA = "0x186C548A0")]
	private void LEPLEMMGLKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6C567F0", Offset = "0x6C55BF0", VA = "0x186C567F0")]
	private void PEDGNHNKCCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6C54A80", Offset = "0x6C53E80", VA = "0x186C54A80")]
	private static void LHMEEEOGDLE(Dictionary<EIKFFMODGOE, Material> FFEMEOOMBKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6C52590", Offset = "0x6C51990", VA = "0x186C52590")]
	private static void KEAANIINJOA(Dictionary<Renderer, NKIDBPJKEGH> KPHFADADNEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6C55AF0", Offset = "0x6C54EF0", VA = "0x186C55AF0")]
	private void OBFIGLHJFEA(SkinnedMeshRenderer[] OHMPGGFLDOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6C55C10", Offset = "0x6C55010", VA = "0x186C55C10")]
	private void OIKFLNCDIHD(SkinnedMeshRenderer JHEJCCDHJNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6C51A10", Offset = "0x6C50E10", VA = "0x186C51A10")]
	private void JIAOGCCIDGE(List<NDCHECJCLID> PFJIGKDOMAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6C50CD0", Offset = "0x6C500D0", VA = "0x186C50CD0")]
	private void HBGEDDDMKID(Dictionary<string, GHMLKDLFDEG<Texture2D>> JBDFBNJNGAL, bool CCBHKIOMNNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6C55770", Offset = "0x6C54B70", VA = "0x186C55770")]
	private void MPAFEOJGIML(Dictionary<string, List<EIKFFMODGOE>> JBDFBNJNGAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x6C56AA0", Offset = "0x6C55EA0", VA = "0x186C56AA0")]
	private void PMMLAJEPIDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6C557C0", Offset = "0x6C54BC0", VA = "0x186C557C0")]
	private void NBBMCOGOAPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6C50710", Offset = "0x6C4FB10", VA = "0x186C50710")]
	private void GMOLDIAJKKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6C559A0", Offset = "0x6C54DA0", VA = "0x186C559A0")]
	private void NMNJJCOJIIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6C4D560", Offset = "0x6C4C960", VA = "0x186C4D560")]
	private void APCCIFBDPCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6C4D890", Offset = "0x6C4CC90", VA = "0x186C4D890")]
	private void BOIHDMDEIJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6C4D400", Offset = "0x6C4C800", VA = "0x186C4D400")]
	private void AKEKGCHGLLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x6C4FAD0", Offset = "0x6C4EED0", VA = "0x186C4FAD0")]
	private void EBMCLFGLAIG(bool CHMCIDHLICE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x6C4B430", Offset = "0x6C4A830", VA = "0x186C4B430")]
	private void AELCOPDGJPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x6C4D360", Offset = "0x6C4C760", VA = "0x186C4D360")]
	private void AIDLKEMCJNF(bool CHMCIDHLICE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x6C4DB70", Offset = "0x6C4CF70", VA = "0x186C4DB70")]
	private void BPOAGFIEKDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x6C4E7C0", Offset = "0x6C4DBC0", VA = "0x186C4E7C0")]
	private void DHFBADFODMK(Material IHANKILIANB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x6C56800", Offset = "0x6C55C00", VA = "0x186C56800")]
	private void PHIPKIEPFFM(Material IHANKILIANB, Color PIAMCBHCJBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6C4F750", Offset = "0x6C4EB50", VA = "0x186C4F750")]
	private void DLIFPMEBDFF(Material IHANKILIANB, Color PIAMCBHCJBE, Color CDHIOKLGICG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x6C51BE0", Offset = "0x6C50FE0", VA = "0x186C51BE0")]
	private void JIBNMOPPLOB(Material IHANKILIANB, Color CENFBBIKNGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6C4D5F0", Offset = "0x6C4C9F0", VA = "0x186C4D5F0")]
	private void BBIPFLIPPCA(Material IHANKILIANB, Texture2D NAKFIPIKBBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x6C54BE0", Offset = "0x6C53FE0", VA = "0x186C54BE0")]
	private void LJJOIEEAHMP(Material IHANKILIANB, Texture NCJGKFLHKME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6C4E600", Offset = "0x6C4DA00", VA = "0x186C4E600")]
	private void DGNFALOHNDD(Action<NKIDBPJKEGH> DGJLAIFOAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x6C56C00", Offset = "0x6C56000", VA = "0x186C56C00")]
	private void PMPBLLMJGOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6C4FB70", Offset = "0x6C4EF70", VA = "0x186C4FB70")]
	private void EHNKFDGJMOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x6C513B0", Offset = "0x6C507B0", VA = "0x186C513B0")]
	private OIBEFKNOBGF JHIBEHDFNCA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6C521C0", Offset = "0x6C515C0", VA = "0x186C521C0")]
	private void KACGIIJAAKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x6C4E1E0", Offset = "0x6C4D5E0", VA = "0x186C4E1E0")]
	public void CLGICNBINKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x6C51320", Offset = "0x6C50720", VA = "0x186C51320")]
	[CompilerGenerated]
	private void JHFOELHDOMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x6C54870", Offset = "0x6C53C70", VA = "0x186C54870")]
	[CompilerGenerated]
	private void LEEBOEOBNFD(NKIDBPJKEGH DDKHBNMBLGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6C4D4D0", Offset = "0x6C4C8D0", VA = "0x186C4D4D0")]
	[CompilerGenerated]
	private void AOHCIPBIJLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6C505D0", Offset = "0x6C4F9D0", VA = "0x186C505D0")]
	[CompilerGenerated]
	private void GHCCGFFIODD(NKIDBPJKEGH DDKHBNMBLGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6C51980", Offset = "0x6C50D80", VA = "0x186C51980")]
	[CompilerGenerated]
	private void JHJAFILOOBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6C55010", Offset = "0x6C54410", VA = "0x186C55010")]
	[CompilerGenerated]
	private void MKDCKNLBOED(NKIDBPJKEGH DDKHBNMBLGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x6C526F0", Offset = "0x6C51AF0", VA = "0x186C526F0")]
	[CompilerGenerated]
	private void KEDHPOGKCLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x6C52780", Offset = "0x6C51B80", VA = "0x186C52780")]
	[CompilerGenerated]
	private void KEHBAGAOAJK(NKIDBPJKEGH DDKHBNMBLGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6C4B3A0", Offset = "0x6C4A7A0", VA = "0x186C4B3A0")]
	[CompilerGenerated]
	private void ACOPIKKMMFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6C54FE0", Offset = "0x6C543E0", VA = "0x186C54FE0")]
	[CompilerGenerated]
	private void MJHLIDGALJL(NKIDBPJKEGH DDKHBNMBLGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6C4F990", Offset = "0x6C4ED90", VA = "0x186C4F990")]
	[CompilerGenerated]
	private void DMLKAIBFCAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6C54FB0", Offset = "0x6C543B0", VA = "0x186C54FB0")]
	[CompilerGenerated]
	private void MDLPBNDJHBO(NKIDBPJKEGH DDKHBNMBLGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x6C50F20", Offset = "0x6C50320", VA = "0x186C50F20")]
	[CompilerGenerated]
	private void HINGMLGONMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x6C4FA20", Offset = "0x6C4EE20", VA = "0x186C4FA20")]
	[CompilerGenerated]
	private void EAEKHNJFOIB(NKIDBPJKEGH DDKHBNMBLGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x6C55CB0", Offset = "0x6C550B0", VA = "0x186C55CB0")]
	[CompilerGenerated]
	private void OOOMLHDAMMM(KeyValuePair<string, GHMLKDLFDEG<Texture2D>> IHDPJLNMCJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x6C4E570", Offset = "0x6C4D970", VA = "0x186C4E570")]
	[CompilerGenerated]
	private void CLOMBNPEDDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x6C56970", Offset = "0x6C55D70", VA = "0x186C56970")]
	[CompilerGenerated]
	private void PIPDBKLLOKA(NKIDBPJKEGH DDKHBNMBLGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6C52130", Offset = "0x6C51530", VA = "0x186C52130")]
	[CompilerGenerated]
	private void JMOOFLODNAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x6C50FB0", Offset = "0x6C503B0", VA = "0x186C50FB0")]
	[CompilerGenerated]
	private void ICPNEMDNKAN(NKIDBPJKEGH DDKHBNMBLGB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class LHAALAHCKGK : FHKAGHFDKOE
{
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private static readonly int ICAJGCLMNEC;

	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private static readonly int FLKHKLHMEIL;

	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private static readonly int MMMOEMHLMOP;

	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private static readonly int NHFNJAAPKEA;

	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private static readonly int DGCFJPJABGA;

	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private static readonly int KBFILNLHNHH;

	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private static readonly int NFLFDCCFAKK;

	[Cpp2IlInjected.Token(Token = "0x4000130")]
	private static readonly int GPBACFKIBHO;

	[Cpp2IlInjected.Token(Token = "0x4000131")]
	private static readonly int AGNOICOFLBN;

	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private static readonly int DIEGOFGHEFL;

	[Cpp2IlInjected.Token(Token = "0x4000133")]
	private static readonly int BNHEOACMNIL;

	[Cpp2IlInjected.Token(Token = "0x4000134")]
	private static readonly int HOOLCLGJBLC;

	[Cpp2IlInjected.Token(Token = "0x4000135")]
	private static readonly int KDAEHHNCAOK;

	[Cpp2IlInjected.Token(Token = "0x4000136")]
	private static readonly int BLIKFAFDEKL;

	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private static readonly int NHCADDJEPJF;

	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private static readonly int ODEFFEAMNGI;

	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private static readonly int NFHJPMGIPLP;

	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private static readonly int KDPBGACACMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private Transform ECNNINGFPHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private Transform PGCJNBLHJHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private Transform OEFPIOAKBOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private Transform NKEFPHBBCIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private Transform DCPOANBHIOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private Transform BIIGCMIHGBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private Transform NEPGHNFFLEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private HKJKHMABGHP HCLPDPDMGCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private MaterialPropertyBlock JKKLIKFBJDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private SkinnedMeshRenderer[] FLBHBJPGKNB;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	private MaterialPropertyBlock FBJCLPDINAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x6C5D290", Offset = "0x6C5C690", VA = "0x186C5D290")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool BCAMLDHBAPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x6C5D110", Offset = "0x6C5C510", VA = "0x186C5D110", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x6C5B4A0", Offset = "0x6C5A8A0", VA = "0x186C5B4A0", Slot = "7")]
	public void CGCFJDLGJFP(HKJKHMABGHP HGHNKBINKHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x6C5B8B0", Offset = "0x6C5ACB0", VA = "0x186C5B8B0", Slot = "8")]
	public void FACOBEBBPKF(MKGNEIAMIIO FPCPCDFPMLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x6C5CBD0", Offset = "0x6C5BFD0", VA = "0x186C5CBD0", Slot = "5")]
	public void GOLJBDJNHDD(KJHCHEIKGKN DPBNKKOFMGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x6C5B440", Offset = "0x6C5A840", VA = "0x186C5B440")]
	private Vector2 CCMLBGIOCFM(Vector2 ELCLGKGMIDD)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x6C5BA50", Offset = "0x6C5AE50", VA = "0x186C5BA50", Slot = "6")]
	public void GMFBOEEEOMI(GNJBBAKOPAF FPCPCDFPMLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x6C5B570", Offset = "0x6C5A970", VA = "0x186C5B570")]
	private void CNFKELINAIJ(GNJBBAKOPAF IAEHPJHOOKH, ENKDIHLAMPK ADLEELLCBNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x6C5B970", Offset = "0x6C5AD70", VA = "0x186C5B970")]
	private void GBNMIIMBCFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x6C5D610", Offset = "0x6C5CA10", VA = "0x186C5D610")]
	public LHAALAHCKGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x6C5B8E0", Offset = "0x6C5ACE0", VA = "0x186C5B8E0")]
	[CompilerGenerated]
	internal static (float, float) FBNJNBIHEIA(float IMENGJGJEAO)
	{
		return default((float, float));
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x6C5D0D0", Offset = "0x6C5C4D0", VA = "0x186C5D0D0")]
	[CompilerGenerated]
	internal static Vector4 LLNFMFMBBDN(Vector2 CLHMEGFDOKF, Vector2 KFNOLBCIBOH)
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
		private ECPOMHDNIMA? cachedMaterialCombinationId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		[SerializeField]
		private Material material;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		[SerializeField]
		private Material[] additionalMaterials;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public MHELINGPEEM CombinationId
		{
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x6C5F290", Offset = "0x6C5E690", VA = "0x186C5F290")]
			get
			{
				return default(MHELINGPEEM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public ECPOMHDNIMA MaterialCombinationId
		{
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x6C5F2C0", Offset = "0x6C5E6C0", VA = "0x186C5F2C0")]
			get
			{
				return default(ECPOMHDNIMA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public Material Material
		{
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x8ACAF0", Offset = "0x8ABEF0", VA = "0x1808ACAF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public Material[] AdditionalMaterials
		{
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x8ACB50", Offset = "0x8ABF50", VA = "0x1808ACB50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x6C5EEF0", Offset = "0x6C5E2F0", VA = "0x186C5EEF0")]
		public Material[] JNKLNJFIKBH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x6C5EFE0", Offset = "0x6C5E3E0", VA = "0x186C5EFE0")]
		public static void MNLPFLFBAJJ(AvatarItemMaterial LCOHEHJECHD, Material PBHLFFKCLKK, int HNPMNLHIFMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x6C5ED40", Offset = "0x6C5E140", VA = "0x186C5ED40")]
		private static bool IIKKMHKADFA(AvatarItemMaterial LCOHEHJECHD, int HNPMNLHIFMJ, [Out] Material BOCHDFJKDHD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x6C5F1D0", Offset = "0x6C5E5D0", VA = "0x186C5F1D0")]
		public AvatarItemMaterial()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[JEGDMIPNMMJ]
public struct KNKLOHONCCN : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	[ReadOnly]
	public CDLFPNFBION EFLNLDNKONN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	[ReadOnly]
	public int ENAEADCFINE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	public NJCIBGKMEOI DAKJBCLGOFE;

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x6C64E30", Offset = "0x6C64230", VA = "0x186C64E30", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[NativeContainer]
[JEGDMIPNMMJ]
public struct NJCIBGKMEOI : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	public NativeArray<Vector3> MCLKEMPMBIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	public NativeArray<Vector3> FIKIFPNLGLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	public NativeArray<Vector4> EMINGACIBCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	public NativeArray<Vector2> LACNJIMIAGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	public NativeArray<Vector2> BMGKALBFEEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	public NativeArray<Vector2> CPNMEHMNCNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	public NativeArray<Vector2> KGLIDFGKMFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	public NativeArray<Color> BICKGKPMNFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	public NativeArray<int> HKAPENBKAGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	public NativeArray<int> KGLJEDNLHHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	private NativeArray<int> GGAKEKHLJGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	private NativeArray<int> FJMGIPIJGAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	public NativeArray<int> MFKDCDFHHPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	public NativeArray<int> HPKFGHGPBLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	public NativeArray<int> EBDMNMBEAAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	public NativeArray<BoneWeight> DCOBLIFOHNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	private NativeArray<int> BJGOCALJFKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private bool DKLPHMCHPJM;

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public int KDIAKEFBLDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x6C65DA0", Offset = "0x6C651A0", VA = "0x186C65DA0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x6C66130", Offset = "0x6C65530", VA = "0x186C66130")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public int GDJMBJEJDCE
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x6C66760", Offset = "0x6C65B60", VA = "0x186C66760")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x6C66140", Offset = "0x6C65540", VA = "0x186C66140")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public int IPEBLBKMPMF
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x6C65D90", Offset = "0x6C65190", VA = "0x186C65D90")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x6C666C0", Offset = "0x6C65AC0", VA = "0x186C666C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x6C667E0", Offset = "0x6C65BE0", VA = "0x186C667E0")]
	public NJCIBGKMEOI(int EBLPIEFGCOB, int GKEPBDHAEBP, int OEFOGGEOCNL, int FCGFDCFPJNA, Allocator HPLNAKONHEI, int DANKCNFEGEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x6C66770", Offset = "0x6C65B70", VA = "0x186C66770")]
	public void NNENLJGCNNJ(int HAJICDLBEKC, Vector3 IFLBFOHFIEP, Vector3 AFMDDDNOHPC, Vector4 KBFPLGGGODF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x6C65F90", Offset = "0x6C65390", VA = "0x186C65F90")]
	public void EGMFDNFIIHC(int HAJICDLBEKC, BoneWeight CKDNHBKAFJG, NativeSlice<byte> BCHEPNJELLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x6C66200", Offset = "0x6C65600", VA = "0x186C66200")]
	public Color GGDALLAPDFB(int HAJICDLBEKC)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x6C66220", Offset = "0x6C65620", VA = "0x186C66220")]
	public void HHMPKAKJEAP(int HAJICDLBEKC, Color JEGEADOBKMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x6C66670", Offset = "0x6C65A70", VA = "0x186C66670")]
	public void JMGPOHINFFB(byte EAJKFEKJHKG, int HAJICDLBEKC, Vector2 OJPKKNBGCBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x6C66310", Offset = "0x6C65710", VA = "0x186C66310")]
	public void INMGMHIKLKM(int HAJICDLBEKC, int IMFGMPANDMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x6C65DB0", Offset = "0x6C651B0", VA = "0x186C65DB0")]
	public bool DCFJJCFNBOP(int EAJKFEKJHKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x6C66240", Offset = "0x6C65640", VA = "0x186C66240")]
	public void IBFINFHIDLF(int IFPNIOEKKCD, int OLMEFNCLGNG, int LOKMFEIHLAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x6C66150", Offset = "0x6C65550", VA = "0x186C66150")]
	public int[] GEHKFAOLFNB(int IFPNIOEKKCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x6C666D0", Offset = "0x6C65AD0", VA = "0x186C666D0")]
	private NativeSlice<int> NEMOJPKNPOO(int IFPNIOEKKCD)
	{
		return default(NativeSlice<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x6C65DE0", Offset = "0x6C651E0", VA = "0x186C65DE0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x6C66320", Offset = "0x6C65720", VA = "0x186C66320")]
	public Mesh JGKGBHOHBEF([Optional] string DOLFCFEJJFK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[DefaultMember("Item")]
[JEGDMIPNMMJ]
[NativeContainer]
public struct CDLFPNFBION : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	public NativeArray<Vector3> MCLKEMPMBIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	public NativeArray<Vector3> FIKIFPNLGLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	public NativeArray<Vector4> EMINGACIBCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	public NativeArray<Vector2> LACNJIMIAGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	public NativeArray<Vector2> BMGKALBFEEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	public NativeArray<Vector2> CPNMEHMNCNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	public NativeArray<Vector2> KGLIDFGKMFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	public NativeArray<Color> BICKGKPMNFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	public NativeArray<int> KCJJKMOAGLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	public NativeArray<int> ICIGCAOFOOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	public NativeArray<int> ACPOHAAJGGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	public NativeArray<int> EJBCNCLCJKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	public NativeArray<bool> FDOHCBLPNNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	public NativeArray<int> OBKKOMFHNGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	public NativeArray<int> GCFGJMKLHHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	public NativeArray<BoneWeight> JKCMICELJIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	private NativeArray<Matrix4x4> BPJOCFAPOKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private NativeArray<int> DIIDHPIFHOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private NativeArray<byte> OELFPKFGJIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private NativeArray<int> AHKMFJMFKPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private NativeArray<int> KMFEDKBKNDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	public NativeArray<sbyte> OBANEHFCJNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	public NativeArray<byte> PCFHGJJHOKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private NativeArray<int> HEANGJGKJHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private bool DKLPHMCHPJM;

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public int KICMEOGDMFL
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x2224730", Offset = "0x2223B30", VA = "0x182224730")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public int LPNKMDDDAJI
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x1304600", Offset = "0x1303A00", VA = "0x181304600")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public int OCBMKBBKPJB
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x6C5F990", Offset = "0x6C5ED90", VA = "0x186C5F990")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public int DEONJCFNKLI
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x6C5FC70", Offset = "0x6C5F070", VA = "0x186C5FC70")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x6C5FC50", Offset = "0x6C5F050", VA = "0x186C5FC50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public int KDIAKEFBLDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x6C5F9C0", Offset = "0x6C5EDC0", VA = "0x186C5F9C0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x6C5FC60", Offset = "0x6C5F060", VA = "0x186C5FC60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public int BJOEIKBMEOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x6C5FD70", Offset = "0x6C5F170", VA = "0x186C5FD70")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x6C5FD60", Offset = "0x6C5F160", VA = "0x186C5FD60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public KKJEGBPDAFE BBLHPNHIBPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x6C5F9D0", Offset = "0x6C5EDD0", VA = "0x186C5F9D0")]
		get
		{
			return default(KKJEGBPDAFE);
		}
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x6C602A0", Offset = "0x6C5F6A0", VA = "0x186C602A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public byte LEFHNEBBILP
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x6C5FC40", Offset = "0x6C5F040", VA = "0x186C5FC40")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x6C5FD50", Offset = "0x6C5F150", VA = "0x186C5FD50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public EDIHLIOFCPL MGACFGHHFEH
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x6C5FD80", Offset = "0x6C5F180", VA = "0x186C5FD80")]
		get
		{
			return default(EDIHLIOFCPL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x6C602B0", Offset = "0x6C5F6B0", VA = "0x186C602B0")]
	public CDLFPNFBION(IList<Mesh> NNHFIFEBCDF, IList<Matrix4x4> GDAPAHEOJNI, IList<bool> FDOHCBLPNNC, byte CPDLADMMBGC, IList<byte[]> FPCADPAGEHD, IList<int> LGLEHOAKFIA, IList<bool> NJKJIIENGBL, IList<int> OBKKOMFHNGG, IList<int> AOGMMABHBBI, IList<int> INMBELHNKDN, Allocator HPLNAKONHEI, KKJEGBPDAFE LCNEKKDMOMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x6C5FC80", Offset = "0x6C5F080", VA = "0x186C5FC80")]
	public NJCIBGKMEOI IAGAAEJIJGG(Allocator HPLNAKONHEI)
	{
		return default(NJCIBGKMEOI);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x6C5F9E0", Offset = "0x6C5EDE0", VA = "0x186C5F9E0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[JEGDMIPNMMJ]
public class EJOMCDOIBEN : FPBDKGBMAMA
{
	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x6C625E0", Offset = "0x6C619E0", VA = "0x186C625E0")]
	public CDLFPNFBION KGNHMMEKNCG()
	{
		return default(CDLFPNFBION);
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x6C5E1C0", Offset = "0x6C5D5C0", VA = "0x186C5E1C0")]
	public EJOMCDOIBEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public struct EDIHLIOFCPL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	public NativeSlice<Vector3> MCLKEMPMBIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	public NativeSlice<Vector3> FIKIFPNLGLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	public NativeSlice<Vector4> EMINGACIBCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	public NativeSlice<Vector2> LACNJIMIAGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	public NativeSlice<Vector2> BMGKALBFEEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	public NativeSlice<Vector2> CPNMEHMNCNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	public NativeSlice<Vector2> KGLIDFGKMFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	public NativeSlice<Color> BICKGKPMNFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	public NativeSlice<int> NFCLOMCFDDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	public NativeSlice<int> EJBCNCLCJKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	public NativeSlice<BoneWeight> JKCMICELJIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	public NativeSlice<byte> KIIKPJJOHPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	public int DJCPLFAHABC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	public Matrix4x4 OJOPIAJPKAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	public int EDNEEBBIDNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	public NativeSlice<byte> BCHEPNJELLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	public bool JPFJOKNGKGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	public int NEDDAENJMPK;
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal readonly struct EIKFFMODGOE : IEquatable<EIKFFMODGOE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	internal readonly Material DLKIFPPKHGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	internal readonly LAKFFHJCLPB FDNOBPEAPPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	internal readonly DLCALALIIEI OIIFEBLPBNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	internal readonly IMEAMGPJJIG KKBLBMKMKMP;

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0xCFCDB0", Offset = "0xCFC1B0", VA = "0x180CFCDB0")]
	public EIKFFMODGOE(Material PBHLFFKCLKK, LAKFFHJCLPB KHCHAMPMAAE, DLCALALIIEI CDFKAOBGJFG, IMEAMGPJJIG COCDOPPFGOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x6C623B0", Offset = "0x6C617B0", VA = "0x186C623B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0xCFCA60", Offset = "0xCFBE60", VA = "0x180CFCA60", Slot = "4")]
	public bool Equals(EIKFFMODGOE KNLMODPGFOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x6C62220", Offset = "0x6C61620", VA = "0x186C62220", Slot = "0")]
	public override bool Equals(object FMAFBHGACNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x6C62310", Offset = "0x6C61710", VA = "0x186C62310", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class NKIDBPJKEGH : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	private MaterialPropertyBlock FHJGDNPPBPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	public Color? CFBEDLJPGEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	public Color? EIDMKNKPBBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	public Color? PPMDJHEOEPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	public Color? FBAMBHNLPBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	public Color AKKODLKDKKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	public Color ODGPKGJJGFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	public Color OBBEFKOKOAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	public Texture2D NCNFAJFAMAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	public Texture2D CLOCLCJNCHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	private Dictionary<EIKFFMODGOE, int> NOJOGFBGKIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	private LAKFFHJCLPB[] BNKPIIMGACK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	private DLCALALIIEI[] CNCEOGCGPJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	public Vector4[] LIMNIDBFNDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	public Vector4[] FNKFNEAMFHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	public Vector4[] PEKFBIBGGNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	public Vector4[] BDAEBDEDOFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	public Vector4[] AGECKDFLCAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	public Vector4[] GALHMJBMBKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	private List<Texture2D> BBCNJNGMFFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	private Vector4[] CGINBCLKGKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	private List<Texture2D> LFLIIJLHADP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private float[] KBCFHIDBHBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private Vector4[] BOMLJPPDMPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	private float[] LACIBDILLKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	public float[] PHBDCBDCPEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	private List<Texture2D> KAKAGGKJFGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	private float[] FIDLJMOHGAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	private List<Texture2D> KPCPNEDICMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	private Vector4[] CCKCKMCPLPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	private float[] APBPBKFCCEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private Vector4[] OOCILCGMHEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	public float[] CIPJMOLHCCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	public Texture2DArray KBBKGILEGOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	public Texture2DArray EBDEOCAFNPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	public Texture2DArray MFFKNDKBDDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	public Texture2DArray OKFOJAGLIEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	private bool BAJLLIEAMBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x184")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	private int IMODNGHJOJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	private Vector2? GFNHNLBPFPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x194")]
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	private TextureFormat GOJFGPLOBKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	private Vector2? ILOMIHNGJMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A4")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	private TextureFormat NFJLAOADIIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	private Vector2? IJCIKJEFFBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B4")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	private TextureFormat PKGJDBNHFIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	private Vector2? NGIMPOLGFJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C4")]
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	private TextureFormat PKDMGNPAELL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	private bool NLOIKEFMMEI;

	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	private static int BGOBJGENOOD;

	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	private static int DNKPOHGFPOA;

	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	private static int ELKMNJLMFFC;

	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	private static int KODOLJFKEFB;

	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	private static int LOJFEPDMJAO;

	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	private static int JBJNJDDNFEI;

	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	private static int FICCANFPCOK;

	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	private static int CJODDLOCEEI;

	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	private static int KOICDKOIGDA;

	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	private static int EBCBCCDBNCJ;

	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	private static int NODLAGIDCLL;

	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	private static int JFOPHAADMCP;

	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	private static int APIAEFMKPDG;

	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	private static int MFMLIJDFKMD;

	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	private static int MOENKGOCABB;

	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	private static int DAKBHBNCCGI;

	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	private static int OJFJADEKCOD;

	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	private static int FEONJAOBPAJ;

	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	private static int OKGOHODMMDH;

	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	private static int MCOFGGFLAIA;

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x6C69190", Offset = "0x6C68590", VA = "0x186C69190")]
	private NKIDBPJKEGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x6C69680", Offset = "0x6C68A80", VA = "0x186C69680")]
	public NKIDBPJKEGH(Color NBBGLFCNKMA, Color EJPAGCLPHLG, Color ONHKHKNFNBJ, Color? EOLJNOPADDE, Color? IFKMHGPCBMP, Color? FJFEAGMDDGK, Texture2D LOGIJKKBJAG, Texture2D PCKPNJOLBLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x6C68C00", Offset = "0x6C68000", VA = "0x186C68C00")]
	internal int MFNIPJGKOHM(Material GNCFCKCJGLH, LAKFFHJCLPB KHCHAMPMAAE, DLCALALIIEI CDFKAOBGJFG, IMEAMGPJJIG COCDOPPFGOL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x6C68B70", Offset = "0x6C67F70", VA = "0x186C68B70")]
	private int MFNIPJGKOHM(EIKFFMODGOE OEOMDKHBDFI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x6C67D30", Offset = "0x6C67130", VA = "0x186C67D30")]
	internal int FOFLMHPNKGO(Material GNCFCKCJGLH, Color CENFBBIKNGC, Color JIBFIPNOONF, Color CFLCPNAMEEN, Color LHEMDHHPADK, Color KBADANLMPEC, Texture2D MINEFPLGADL, Vector4 OBEFOCFFLEC, Texture2D LGFCPBEAOOM, Vector4 HFPJMACBOIC, float JAHPFEHLPIK, float CBMBJKPIHBC, Texture2D GNHLHIGAEBC, Vector4 FLIHCNECJKD, float LDOKEPFHIGO, Texture2D FEDHIADNFEO, Color OJMPBJIBIMF, Vector4 CFOBNDCCBPE, LAKFFHJCLPB KHCHAMPMAAE, DLCALALIIEI CDFKAOBGJFG, IMEAMGPJJIG COCDOPPFGOL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x6C68900", Offset = "0x6C67D00", VA = "0x186C68900")]
	private void IKOJCOMHDLA(List<Texture2D> BBCNJNGMFFF, [Out] Texture2DArray NPGDCKLPEIL, [Out] Texture2DArray HBJANNHOIGE, [Out] Texture2DArray LKJLOAHMMEK, [Out] Texture2DArray HEBHBJDECAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x6C68CF0", Offset = "0x6C680F0", VA = "0x186C68CF0")]
	public void NDFPEBJAGJE(Shader FEJMFPPMJEH, Renderer OMALFJOLMMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x6C66F40", Offset = "0x6C66340", VA = "0x186C66F40")]
	private void DGDAJGADCMH(Shader FEJMFPPMJEH, Renderer OMALFJOLMMP, int HBOHNOALLNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x6C66D40", Offset = "0x6C66140", VA = "0x186C66D40")]
	private Color DCDFAOOCPOC(Color JAACLKKECKM, LAKFFHJCLPB MDMODPKLACI)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x6C67BE0", Offset = "0x6C66FE0", VA = "0x186C67BE0")]
	private Color EDGPCEDMJKI(Color OIDOGDOOLFN, LAKFFHJCLPB MDMODPKLACI)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x6C66C40", Offset = "0x6C66040", VA = "0x186C66C40")]
	private bool AOJODPCJHGC(Texture2D LCBFKIOGHBL, DLCALALIIEI EJBLJPIFEAB, [Out] Texture2D EPGAMACLGFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x6C68AC0", Offset = "0x6C67EC0", VA = "0x186C68AC0")]
	private void KGNLIFDDPLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x6C67BA0", Offset = "0x6C66FA0", VA = "0x186C67BA0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class BFOHIMJJOHG
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private sealed class CIPOKJHNKEC : IEnumerator<DNOIEDKBBPN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		private DNOIEDKBBPN <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		public JobHandle handle;

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		private DNOIEDKBBPN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x8A89C0", Offset = "0x8A7DC0", VA = "0x1808A89C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x8A89C0", Offset = "0x8A7DC0", VA = "0x1808A89C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x8B2270", Offset = "0x8B1670", VA = "0x1808B2270")]
		[DebuggerHidden]
		public CIPOKJHNKEC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0xD05060", Offset = "0xD04460", VA = "0x180D05060", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x6C61AE0", Offset = "0x6C60EE0", VA = "0x186C61AE0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270")]
	public static void JPCCJKMHFBF(string NKPCGMJMEIE, int LBPCGMGCBGG, long IAMBKGBKEFA, long LBNNJMLEEDH, long GIOJHNFCDDB, long AGKIOPBCOHJ, long IBBJMFKHPIA, long PDJCBJNOBJL, long MCFINGPOBHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x6C5F3F0", Offset = "0x6C5E7F0", VA = "0x186C5F3F0")]
	public static NFIGMHBJPEE MFAMDCNFJGM(JobHandle GCEMFECNNHJ, bool AFHMOBDOCCG, bool NCHDMKPBJEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x6C5F380", Offset = "0x6C5E780", VA = "0x186C5F380")]
	[IteratorStateMachine(typeof(CIPOKJHNKEC))]
	private static IEnumerator<DNOIEDKBBPN> KCIKFHGADCO(JobHandle KNOJBNNAGCL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public static class EMLJNMPDMEB
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public enum IOAOILGHFLG
	{
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		General,
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		ColoredHair
	}

	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	public static readonly int HNJFBEPPMHI;

	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	public static readonly int GGKFCJONEPE;

	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	public static readonly int JCEJEIELPGN;

	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	public static readonly int MHCHNODNJCD;

	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	public static readonly int NCEGHNKLKKM;

	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	public static readonly int EDFFGMIHBPL;

	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	public static readonly int CLLHIGFALIL;

	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	public static readonly int BCPIELCDJFI;

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x6C626D0", Offset = "0x6C61AD0", VA = "0x186C626D0")]
	public static bool AOJGIPLHNHN(Material PBHLFFKCLKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x6C62740", Offset = "0x6C61B40", VA = "0x186C62740")]
	public static bool LENLKEIGKNE(Material PBHLFFKCLKK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class IJGPOOGNGGD : HCLPMJBBIMK, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	private CKFELKNMNFN LPMNJCKOGHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	private HLDPCPPHLKC LBOBINKAJON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	private IRecRoomQualityConfigProvider LGOGDDOBCKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	private bool DKLPHMCHPJM;

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x6C64A00", Offset = "0x6C63E00", VA = "0x186C64A00")]
	[OAJAKDHKADM.LHNCMMKCKFL.AGBJBPFJEIM]
	internal static void KHFJJNELCMN(LBNNADLFMIK FKEBHAJCLGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x5F6F980", Offset = "0x5F6ED80", VA = "0x185F6F980")]
	[UnityEngine.Scripting.Preserve]
	public IJGPOOGNGGD([CCLHMIDBCEM(null)] HLDPCPPHLKC CNLFICJLICP, [CCLHMIDBCEM(null)] CKFELKNMNFN PNFNNPLFDIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x6C64B70", Offset = "0x6C63F70", VA = "0x186C64B70")]
	private void PLPJAEJFMJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x6C64AF0", Offset = "0x6C63EF0", VA = "0x186C64AF0", Slot = "4")]
	public void LADBAIBOLGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x6C64540", Offset = "0x6C63940", VA = "0x186C64540", Slot = "5")]
	public GHMLKDLFDEG<Texture2D> JLCEDCNADBC(IFFPFMJLDIO NGLEELLEIOL, [Optional] CHCAPIDJDOC BJGOCALJFKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x6C64410", Offset = "0x6C63810", VA = "0x186C64410")]
	private uint FIALAOHJNMO(IFFPFMJLDIO NGLEELLEIOL, CHCAPIDJDOC BJGOCALJFKP)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface EOKKDJGDFIO
{
	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DFIKDMNGJDM(Mesh NJMNIJFLOJJ, Matrix4x4 IDJCNBIJKPI, byte[] BCHEPNJELLJ, bool MHGNBPPCDAG = false, GKIFLDBNEKK.AOOMGKPMPMM HIJMMGHEDAN = (GKIFLDBNEKK.AOOMGKPMPMM)0, int OBKKOMFHNGG = -1, bool FDOHCBLPNNC = false);

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EHEOECNKEFE(Allocator HPLNAKONHEI, KKJEGBPDAFE LCNEKKDMOMP, byte CPDLADMMBGC, [Optional] IList<int> AOGMMABHBBI, [Optional] IList<int> GBCEKFOIAKP);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public readonly struct JEHBKEBENNL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E8")]
	public readonly GameObject GDJGHDDILHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001E9")]
	private readonly AvatarItemMaterial NFJADIDPMNI;

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0xD74C00", Offset = "0xD74000", VA = "0x180D74C00")]
	public JEHBKEBENNL(GameObject GDJGHDDILHJ, AvatarItemMaterial NFJADIDPMNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x6C64C00", Offset = "0x6C64000", VA = "0x186C64C00")]
	public void CCOHBNBJKNN(Material PBHLFFKCLKK, int HNPMNLHIFMJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public class DKOPEBCPKFK : PIJMIAHNECG<Task<(GameObject, AvatarItemMaterial)>, JEHBKEBENNL>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private struct GOOHLANDIIB : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6C63EA0", Offset = "0x6C632A0", VA = "0x186C63EA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x6C643A0", Offset = "0x6C637A0", VA = "0x186C643A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001EA")]
	private GHMLKDLFDEG<GameObject> EFMODFLDELH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001EB")]
	private GHMLKDLFDEG<AvatarItemMaterial> OMPIGDIGGGH;

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x6C62190", Offset = "0x6C61590", VA = "0x186C62190")]
	private DKOPEBCPKFK(Task<(GameObject, AvatarItemMaterial)> IALOMLEGCDH, GHMLKDLFDEG<GameObject> FALNHNEJGHL, GHMLKDLFDEG<AvatarItemMaterial> KPKGDEAFEBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x6C61BD0", Offset = "0x6C60FD0", VA = "0x186C61BD0")]
	public static DKOPEBCPKFK JMOKCOIDHBC(AssetReference GJGKBPLDOMD, [Optional] AssetReference AKPAMDIANCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x6C61B30", Offset = "0x6C60F30", VA = "0x186C61B30", Slot = "11")]
	protected override JEHBKEBENNL IILEIHFANKH(Task<(GameObject, AvatarItemMaterial)> KKJNDDBELMF)
	{
		return default(JEHBKEBENNL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x6C62110", Offset = "0x6C61510", VA = "0x186C62110", Slot = "12")]
	protected override void PKGFFKOHEMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x6C61FE0", Offset = "0x6C613E0", VA = "0x186C61FE0")]
	[AsyncStateMachine(typeof(GOOHLANDIIB))]
	private static Task<(GameObject, AvatarItemMaterial)> OHIBCBPFLOD(Task<GameObject> NGMKHBPLFBJ, Task<AvatarItemMaterial> GGMJKBPFDND)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class GNMBODDPJOP
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	private class GAEKPCJHKIP : PIJMIAHNECG<Task<MaterialMapAsset>, Material[]>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		private GHMLKDLFDEG<MaterialMapAsset> KNOJBNNAGCL;

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x6C63910", Offset = "0x6C62D10", VA = "0x186C63910")]
		public GAEKPCJHKIP(GHMLKDLFDEG<MaterialMapAsset> KNOJBNNAGCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x6C63490", Offset = "0x6C62890", VA = "0x186C63490", Slot = "11")]
		protected override Material[] IILEIHFANKH(Task<MaterialMapAsset> IALOMLEGCDH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x6C638B0", Offset = "0x6C62CB0", VA = "0x186C638B0", Slot = "12")]
		protected override void PKGFFKOHEMB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	private class FJJFIBPDGCO : PIJMIAHNECG<Task<Material[]>, Material[]>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		private List<GHMLKDLFDEG<Material>> PBBPAIDOHGB;

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x6C62B00", Offset = "0x6C61F00", VA = "0x186C62B00")]
		public FJJFIBPDGCO(Task<Material[]> IALOMLEGCDH, List<GHMLKDLFDEG<Material>> PBBPAIDOHGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x6C62970", Offset = "0x6C61D70", VA = "0x186C62970", Slot = "11")]
		protected override Material[] IILEIHFANKH(Task<Material[]> KKJNDDBELMF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x6C629C0", Offset = "0x6C61DC0", VA = "0x186C629C0", Slot = "12")]
		protected override void PKGFFKOHEMB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40001F6")]
	private static readonly FLILHMOBPPM APPINHJJCPL;

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x6C639F0", Offset = "0x6C62DF0", VA = "0x186C639F0")]
	public static GHMLKDLFDEG<Material[]> MAMBAIHHDGA(AssetReference[] HLNEBHILCKD)
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
		[AIBPGBFCHJI(OPJKPNFINLK.Self, false, false, false)]
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
		[Cpp2IlInjected.Address(RVA = "0x6C69740", Offset = "0x6C68B40", VA = "0x186C69740")]
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
		private struct BJLJFMIMKHJ : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000210")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000211")]
			public AsyncTaskMethodBuilder<CMFGFFKIING> <>t__builder;

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
			private TaskAwaiter<CMFGFFKIING> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x6C5F540", Offset = "0x6C5E940", VA = "0x186C5F540", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x6C5F920", Offset = "0x6C5ED20", VA = "0x186C5F920", Slot = "5")]
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
		private Dictionary<OBBAPCJJCDJ, SymmetricalFaceFeature> eyeBrowFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		private Dictionary<OBBAPCJJCDJ, EyesFaceFeature> eyeFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		private Dictionary<OBBAPCJJCDJ, NoseFaceOption> noseOptionsDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		private Dictionary<OBBAPCJJCDJ, FaceFeature> mouthFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		private readonly Dictionary<OBBAPCJJCDJ, int> featureToIndexMap;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		private CMFGFFKIING _defaultFaceStyleLegacyBean;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		private CMFGFFKIING _defaultFaceStyleModernBody;

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		private bool dictionariesInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0x6C63460", Offset = "0x6C62860", VA = "0x186C63460")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x6C63340", Offset = "0x6C62740", VA = "0x186C63340")]
		public CMFGFFKIING LOMBFHBCMNJ(OJHEMGLCFCA OFELOJDHFHP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x6C630F0", Offset = "0x6C624F0", VA = "0x186C630F0")]
		[AsyncStateMachine(typeof(BJLJFMIMKHJ))]
		public Task<CMFGFFKIING> COHNKBFJHNM(int? PAOFBNIINNF, int MFNHJHDDGAH, int GFIPHDEEFDJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x6C62FA0", Offset = "0x6C623A0", VA = "0x186C62FA0")]
		public NoseFaceOption ANKLNBHMLAL(int JHHBHLOGEFP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x6C62B70", Offset = "0x6C61F70", VA = "0x186C62B70")]
		public SelectableFaceOption AAPKNANJEFH(FaceFeatureType FMEOGNKJNMN, OBBAPCJJCDJ KOMOKMALBJK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x6C62CF0", Offset = "0x6C620F0", VA = "0x186C62CF0")]
		public int AJBNCELKCAJ(OBBAPCJJCDJ KOMOKMALBJK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x6C62D70", Offset = "0x6C62170", VA = "0x186C62D70")]
		private void AJJPDDNHLCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x2E54000", Offset = "0x2E53400", VA = "0x182E54000")]
		private void IPDFNJHCJDM<T>(IDictionary<OBBAPCJJCDJ, T> BNDGLAGJGHN, IReadOnlyList<T> EJNPDEIKADA) where T : SelectableFaceOption
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x6C63040", Offset = "0x6C62440", VA = "0x186C63040")]
		public OBBAPCJJCDJ BEKBFOGFJJP(FaceFeatureType FMEOGNKJNMN)
		{
			return default(OBBAPCJJCDJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x6C63220", Offset = "0x6C62620", VA = "0x186C63220")]
		public OBBAPCJJCDJ DOKDLHMIKIF(FaceFeatureType FMEOGNKJNMN)
		{
			return default(OBBAPCJJCDJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x6C633D0", Offset = "0x6C627D0", VA = "0x186C633D0")]
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
