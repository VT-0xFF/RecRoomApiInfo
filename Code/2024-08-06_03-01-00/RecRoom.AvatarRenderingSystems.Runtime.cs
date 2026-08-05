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
	public class LogRegistrationIndex : MHGCIIOBNMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x684DFD0", Offset = "0x684C5D0", VA = "0x18684DFD0", Slot = "4")]
		public override void OOMCOBOGONK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8878E0", Offset = "0x885EE0", VA = "0x1808878E0")]
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
			[Cpp2IlInjected.Address(RVA = "0x8632E0", Offset = "0x8618E0", VA = "0x1808632E0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override string AssetGUID
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x68512D0", Offset = "0x684F8D0", VA = "0x1868512D0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6851200", Offset = "0x684F800", VA = "0x186851200", Slot = "17")]
		public override bool RuntimeKeyIsValid()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6851290", Offset = "0x684F890", VA = "0x186851290")]
		public RecNetCDNAssetReference(RecNetCDNKey MNBFPOFIDHA)
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
			[Cpp2IlInjected.Address(RVA = "0x85F450", Offset = "0x85DA50", VA = "0x18085F450")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x85F460", Offset = "0x85DA60", VA = "0x18085F460")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public string CacheHash
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x860D20", Offset = "0x85F320", VA = "0x180860D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x860CF0", Offset = "0x85F2F0", VA = "0x180860CF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6851310", Offset = "0x684F910", VA = "0x186851310")]
		public static RecNetCDNKey DHDNPJEHKAP(string EBIENMNOLOM, string MBKOBJAKOPH = "")
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6052AE0", Offset = "0x60510E0", VA = "0x186052AE0")]
		public void PKLNMJGOLKM(string MFFAAMFBNHF, string CMIFMCLDAIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6851410", Offset = "0x684FA10", VA = "0x186851410")]
		public RecNetCDNKey()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[GJMIOABHJEG]
public class GMGOKEDFEGG : MBIACJGCFMA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	protected readonly List<Mesh> HNKKGJKOPIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	protected readonly List<byte[]> KMMJDMOBDFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	protected readonly List<Matrix4x4> KPJBABGNFEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	protected readonly List<bool> JFCGOFMKIHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	protected readonly List<int> OIBKEJGBMEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	protected readonly List<bool> MGPJDEJHKDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	protected readonly List<int> PPMMFFIKABI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	protected Allocator FBCEMDKJIIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	protected JFKHKMCOFGG ACIGDDAELHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	protected byte NDOGGALGAOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	protected IList<int> IINBHBPEDEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	protected IList<int> KDAFCIIKKCI;

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6849D60", Offset = "0x6848360", VA = "0x186849D60", Slot = "4")]
	public void MDMMLBIOPGC(Mesh GOBEKKOCOLP, Matrix4x4 ICJCNEJJMNK, byte[] IMAKAICAGGG, bool IMOKLMECJDK = false, LIBDCJLAIAP.JPKJJHCECFA LBCIEIGLEDJ = (LIBDCJLAIAP.JPKJJHCECFA)0, int IONPKDLJCBO = -1, bool CBOJOFHPECI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6849D20", Offset = "0x6848320", VA = "0x186849D20", Slot = "5")]
	public void JNDCNBAODLG(Allocator JKHEKCINHDP, JFKHKMCOFGG EPNKPGGDMBK, byte CFEDIPKKDLI, [Optional] IList<int> MNIJLMICPLA, [Optional] IList<int> MEGDFBDLGHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6849AD0", Offset = "0x68480D0", VA = "0x186849AD0")]
	private static void ADHIDFDFCAJ(Mesh GOBEKKOCOLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6849F70", Offset = "0x6848570", VA = "0x186849F70")]
	public GMGOKEDFEGG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[GJMIOABHJEG]
public struct EJJPODLPDBO : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	[ReadOnly]
	public EFIADNNKLPN OMLPEKINJOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	[ReadOnly]
	public int JDDOFOEBLOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public NCKMCGBHHKJ CGMJEJIJELG;

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6847B80", Offset = "0x6846180", VA = "0x186847B80", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[GJMIOABHJEG]
[NativeContainer]
public struct NCKMCGBHHKJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct CEHODAALLGC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public Vector3 NBLFEBAFGEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public Vector3 FKPHICIEEGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public Vector4 KJNPDPIAHBA;
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct OHHKBGGNIIH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public float INAABIPOKGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public float AHICHNFBNIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public float GBOGHGAHIJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public float NBADGGMFIOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public byte OKFHGCMGJBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public byte AFEOOHHLOGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public byte CIGBCHOEAKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public byte DJCMCOOJHED;
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct NDPJEDAEJJE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public half INAABIPOKGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public half AHICHNFBNIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public half GBOGHGAHIJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public half NBADGGMFIOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public byte OKFHGCMGJBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public byte AFEOOHHLOGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public byte CIGBCHOEAKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public byte DJCMCOOJHED;
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct EEPNGAOKMJB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public half4 KOEHPNBNNJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public half2 CDCJKOEHPOL;
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct JFKBELMNNBN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public half4 KOEHPNBNNJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public half2 CDCJKOEHPOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public half2 NHNIIJGJBMB;
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public struct LMAPKFHFPHK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public half4 KOEHPNBNNJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public half2 CDCJKOEHPOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public half2 NHNIIJGJBMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public half2 CGCFHIACNAE;
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct LIMEPGAJLIM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public half4 KOEHPNBNNJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public half2 CDCJKOEHPOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public half2 NHNIIJGJBMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public half2 CGCFHIACNAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public half2 KOLJHPJAPNM;
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public struct KPOGFMDEIDB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public float INAABIPOKGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public float AHICHNFBNIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public float GBOGHGAHIJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public float NBADGGMFIOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public int OKFHGCMGJBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public int AFEOOHHLOGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public int CIGBCHOEAKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public int DJCMCOOJHED;
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public struct OKPJPFDDFMK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public Color KOEHPNBNNJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public Vector2 CDCJKOEHPOL;
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public struct GPMDLMOOKIK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public Color KOEHPNBNNJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public Vector2 CDCJKOEHPOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public Vector2 NHNIIJGJBMB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public struct AMGNABKIACI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public Color KOEHPNBNNJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public Vector2 CDCJKOEHPOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public Vector2 NHNIIJGJBMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public Vector2 CGCFHIACNAE;
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public struct PNOEBHLIINF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public Color KOEHPNBNNJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Vector2 CDCJKOEHPOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public Vector2 NHNIIJGJBMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public Vector2 CGCFHIACNAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Vector2 KOLJHPJAPNM;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private bool CKEJFENPLAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public NativeArray<CEHODAALLGC> JHNICENFHBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public NativeArray<EEPNGAOKMJB> HHMPFJBJHNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public NativeArray<JFKBELMNNBN> LBKIKJBIIAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public NativeArray<LMAPKFHFPHK> LFCMCOMIAHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public NativeArray<LIMEPGAJLIM> HDOLOMONMMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public NativeArray<NDPJEDAEJJE> IEDDDCJNIEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public NativeArray<OHHKBGGNIIH> ANMCGHJOJKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public NativeArray<OKPJPFDDFMK> BMEJIKOGMGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public NativeArray<GPMDLMOOKIK> OKFNCFCLHLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public NativeArray<AMGNABKIACI> CFIECNNJBFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public NativeArray<PNOEBHLIINF> FBJFLEBBFAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public NativeArray<KPOGFMDEIDB> KEMADIOOFBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public NativeArray<int> NKLCHGOEEDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public NativeArray<int> DOOAEHJPJEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private NativeArray<int> NIBBCIAIEAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private NativeArray<int> LNCJLAPGNCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public NativeArray<int> EJJCNCIGJDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public NativeArray<int> BPNNLIJNLJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public NativeArray<int> FMFFJLGOEJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public NativeArray<BoneWeight> PEJKEEAMCML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private NativeArray<int> MBKNFOKFHJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private bool ECCPIKDJDGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x159")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private bool GNGCAHFGDNF;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int FPPFNJPGCOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x684F830", Offset = "0x684DE30", VA = "0x18684F830")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x684F1F0", Offset = "0x684D7F0", VA = "0x18684F1F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int LLKECIDLMGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x684E210", Offset = "0x684C810", VA = "0x18684E210")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x684FC70", Offset = "0x684E270", VA = "0x18684FC70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int FPIDJGAKDCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6850550", Offset = "0x684EB50", VA = "0x186850550")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x684F470", Offset = "0x684DA70", VA = "0x18684F470")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int LBBPEHLDFFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x68500E0", Offset = "0x684E6E0", VA = "0x1868500E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6850560", Offset = "0x684EB60", VA = "0x186850560")]
	public NCKMCGBHHKJ(int INFGCCAIILB, int GDPPGIECEMD, int PHAIIFLCAPO, int AMNCMEGLLMN, Allocator JKHEKCINHDP, int IOFBKPBJGMH, IJLPEOAKFLI PCIBFMNNFKM, bool ECCPIKDJDGA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x684F160", Offset = "0x684D760", VA = "0x18684F160")]
	public void CEKHLDBAAHE(int EBDMAJMOJLN, Vector3 ONOKCMNNMGN, Vector3 DMAHMKCJEMH, Vector4 GJMDIBEDCBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x684F840", Offset = "0x684DE40", VA = "0x18684F840")]
	public void JPNIBLOFMHF(int EBDMAJMOJLN, BoneWeight FPNKJPHGNPB, NativeSlice<byte> IMAKAICAGGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x684FC80", Offset = "0x684E280", VA = "0x18684FC80")]
	public Color KEIJIFENGCD(int EBDMAJMOJLN)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6850150", Offset = "0x684E750", VA = "0x186850150")]
	public void NBIJEOFIGMG(int EBDMAJMOJLN, Color EIFPFLKPFCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x684F480", Offset = "0x684DA80", VA = "0x18684F480")]
	public void GAKFDLBBFNC(byte MILCODCFPBM, int EBDMAJMOJLN, Vector2 OFLKJDKEKDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x684F200", Offset = "0x684D800", VA = "0x18684F200")]
	public void CLEDHFEDCPI(int EBDMAJMOJLN, int ACJKJJIBBDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6850080", Offset = "0x684E680", VA = "0x186850080")]
	public bool MKDHJDJDDCI(int MILCODCFPBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x684FFB0", Offset = "0x684E5B0", VA = "0x18684FFB0")]
	public void MHHLGPGKMBG(int AIGEDCCMDCH, int LHOLHMCKPEO, int KDDFOIMAIHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x684F210", Offset = "0x684D810", VA = "0x18684F210", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x684E220", Offset = "0x684C820", VA = "0x18684E220")]
	public Mesh BKCPHBDCCNI([Optional] string LEEGOJNNBBK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[NativeContainer]
[GJMIOABHJEG]
[DefaultMember("Item")]
public struct EFIADNNKLPN : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public Mesh.MeshDataArray HJCIMCKJFCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public NativeArray<int> BHFBAKGGJJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public NativeArray<int> MEIDABKJMEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public NativeArray<BoneWeight> PEJKEEAMCML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private NativeArray<Matrix4x4> LGMLBAFEEND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private NativeArray<int> HBKACDCMLKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private NativeArray<byte> ODEJPPFMPBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private NativeArray<int> NKIBANFCNIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private NativeArray<int> GBONJDLFJBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public NativeArray<sbyte> MLIDNNCMCLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public NativeArray<byte> MHDOMBGDOCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public NativeArray<bool> CBOJOFHPECI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public NativeArray<int> IONPKDLJCBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private bool ECCPIKDJDGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private NativeArray<int> IMIDEGNLOPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private bool GNGCAHFGDNF;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public int JGMIEBHOMEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x683A550", Offset = "0x6838B50", VA = "0x18683A550")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int GPNDGLIEGIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x683A010", Offset = "0x6838610", VA = "0x18683A010")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int NGEOFNGDPBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x683A560", Offset = "0x6838B60", VA = "0x18683A560")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int FLFGNGIJGFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x683A2C0", Offset = "0x68388C0", VA = "0x18683A2C0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x683A120", Offset = "0x6838720", VA = "0x18683A120")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int FPPFNJPGCOK
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x683A2D0", Offset = "0x68388D0", VA = "0x18683A2D0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x683A030", Offset = "0x6838630", VA = "0x18683A030")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int PAAEHGOJJHP
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x683A2A0", Offset = "0x68388A0", VA = "0x18683A2A0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x683A020", Offset = "0x6838620", VA = "0x18683A020")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public JFKHKMCOFGG GNHLNPPJBBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x683A2B0", Offset = "0x68388B0", VA = "0x18683A2B0")]
		get
		{
			return default(JFKHKMCOFGG);
		}
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x683A2E0", Offset = "0x68388E0", VA = "0x18683A2E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public byte AGNNDEEDFBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x683A2F0", Offset = "0x68388F0", VA = "0x18683A2F0")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x683A110", Offset = "0x6838710", VA = "0x18683A110")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public OODJEDAFHAL ECHCHHAAKAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x683A300", Offset = "0x6838900", VA = "0x18683A300")]
		get
		{
			return default(OODJEDAFHAL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x683A630", Offset = "0x6838C30", VA = "0x18683A630")]
	public EFIADNNKLPN(IList<Mesh> ABCGPOLADKD, IList<Matrix4x4> IJEIGIKCPLO, IList<bool> CBOJOFHPECI, byte CFEDIPKKDLI, IList<byte[]> EKFJNKPHEBI, IList<int> LFAFPPBICGF, IList<bool> PCBLLKDJHGG, IList<int> IONPKDLJCBO, IList<int> MNIJLMICPLA, IList<int> LOHGCBNDHFH, Allocator JKHEKCINHDP, JFKHKMCOFGG EPNKPGGDMBK, bool ECCPIKDJDGA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x683A040", Offset = "0x6838640", VA = "0x18683A040")]
	public NCKMCGBHHKJ CHPCPPCOADD(Allocator JKHEKCINHDP, IJLPEOAKFLI PCIBFMNNFKM)
	{
		return default(NCKMCGBHHKJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x683A130", Offset = "0x6838730", VA = "0x18683A130", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[GJMIOABHJEG]
public class GKPALHPLFLC : GMGOKEDFEGG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public bool LLCGCFPBJKG;

	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private static readonly ProfilerMarker GHLJCIIJDBA;

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x68497C0", Offset = "0x6847DC0", VA = "0x1868497C0")]
	public EFIADNNKLPN NDDLJFOAPJA()
	{
		return default(EFIADNNKLPN);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6849AC0", Offset = "0x68480C0", VA = "0x186849AC0")]
	public GKPALHPLFLC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct OODJEDAFHAL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public Mesh.MeshData KIKEJADKJFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public NativeSlice<BoneWeight> PEJKEEAMCML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public NativeSlice<byte> EAJOOIJKJPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public int CFAABHEDIBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public Matrix4x4 JBNIANGODNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public int COLJDKPLIAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public NativeSlice<byte> IMAKAICAGGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public bool JDFPAOKBOCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public int BHNHDPHGJAI;
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class EHLNPKOGLLO : MACHNDAPHEN
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	private abstract class NIFDOOJAHEC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public readonly PAHGFPMKCPO HJEFMIBIAOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		protected bool CGJDNOALJNJ;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public virtual bool LFPFJODPMNE
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x8A6190", Offset = "0x8A4790", VA = "0x1808A6190", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public virtual bool LGDLOFONADJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x8A6190", Offset = "0x8A4790", VA = "0x1808A6190", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public virtual LIBDCJLAIAP.JPKJJHCECFA COLJDKPLIAC
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x85E9F0", Offset = "0x85CFF0", VA = "0x18085E9F0", Slot = "6")]
			get
			{
				return default(LIBDCJLAIAP.JPKJJHCECFA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public bool JMGBCKAIMMC
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0xA08B20", Offset = "0xA07120", VA = "0x180A08B20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public bool FMNIPBAPKHL
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x15B30A0", Offset = "0x15B16A0", VA = "0x1815B30A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public bool ODGHDGINAKI
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x6850F90", Offset = "0x684F590", VA = "0x186850F90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public bool FFHKPOFIGFE
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x6850FA0", Offset = "0x684F5A0", VA = "0x186850FA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x864580", Offset = "0x862B80", VA = "0x180864580")]
		protected NIFDOOJAHEC(PAHGFPMKCPO NCNDFPOFHOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract MKEIEIBMPOE DEDDKIAFLHB(int[] NBGDKCDGMIM, List<IPNLIBBOHIC> KKEHJJKOBOA, List<IPNLIBBOHIC> AJMACJIBDGK);

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract DHKHNPGCKHB AKGEDLCCKEE(uint FALHCGACGOI, AvatarSkinnedMeshBoneOrderRemapsData NHNIGGPJCLA);
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	private class LLCOAHNKBLO : NIFDOOJAHEC
	{
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		[CompilerGenerated]
		private sealed class EIHJPPMEAEG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000E1")]
			public JPDJGJBEGGO<GameObject> skinAvatarItemPrefabHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000E2")]
			public LLCOAHNKBLO <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
			public EIHJPPMEAEG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x6847790", Offset = "0x6845D90", VA = "0x186847790")]
			internal void PILOADEBDCM(GameObject result)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private readonly AvatarSkinAssetItem.EDGIEPPOLCB BGELLLEDICO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private readonly AssetReference KHFFPAFFFCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		private readonly LIBDCJLAIAP.JPKJJHCECFA AJMLGCFLANF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private readonly CIFJPJIKLJC? KILGANBENDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private readonly Material[] ELPDJHEPHNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private SkinnedMeshRenderer[] FJDCOCDFJMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private AvatarSkinAssetItem HDEKJHDKIPI;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override LIBDCJLAIAP.JPKJJHCECFA COLJDKPLIAC
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x85F440", Offset = "0x85DA40", VA = "0x18085F440", Slot = "6")]
			get
			{
				return default(LIBDCJLAIAP.JPKJJHCECFA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x684DDB0", Offset = "0x684C3B0", VA = "0x18684DDB0")]
		public LLCOAHNKBLO(AvatarSkinAssetItem.EDGIEPPOLCB LACHNGFPHJC, AssetReference GIBCBJCLFFF, Material CGKNPBIOKPK, PAHGFPMKCPO JCPMBIEAGBM, LIBDCJLAIAP.JPKJJHCECFA HFDHLDAHPKE = (LIBDCJLAIAP.JPKJJHCECFA)0, [Optional] CIFJPJIKLJC? FHDONLGLEPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x684DEC0", Offset = "0x684C4C0", VA = "0x18684DEC0")]
		public LLCOAHNKBLO(AvatarSkinAssetItem.EDGIEPPOLCB LACHNGFPHJC, AssetReference GIBCBJCLFFF, Material CGKNPBIOKPK, LIBDCJLAIAP.JPKJJHCECFA HFDHLDAHPKE = (LIBDCJLAIAP.JPKJJHCECFA)0, [Optional] CIFJPJIKLJC? FHDONLGLEPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x684DB70", Offset = "0x684C170", VA = "0x18684DB70", Slot = "7")]
		public override MKEIEIBMPOE DEDDKIAFLHB(int[] NBGDKCDGMIM, List<IPNLIBBOHIC> KKEHJJKOBOA, List<IPNLIBBOHIC> AJMACJIBDGK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x684D890", Offset = "0x684BE90", VA = "0x18684D890", Slot = "8")]
		public override DHKHNPGCKHB AKGEDLCCKEE(uint FALHCGACGOI, AvatarSkinnedMeshBoneOrderRemapsData NHNIGGPJCLA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x684DD40", Offset = "0x684C340", VA = "0x18684DD40", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	private class JBAJIKLNLIE : NIFDOOJAHEC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public readonly LGAGFAHPGOJ BGLOBBNLMEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private JPDJGJBEGGO<AHPPPJJGNMJ> KFFPFDOIAOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public AHPPPJJGNMJ HIKJELAFPME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private JPDJGJBEGGO<Material[]> ILECGCHIPDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public Material[] FEEOKAEGMEK;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public override bool LFPFJODPMNE
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x878510", Offset = "0x876B10", VA = "0x180878510", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override bool LGDLOFONADJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x684B4A0", Offset = "0x6849AA0", VA = "0x18684B4A0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x684B760", Offset = "0x6849D60", VA = "0x18684B760")]
		public JBAJIKLNLIE(PAHGFPMKCPO NCNDFPOFHOE, LGAGFAHPGOJ EONPLNDIMBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x684ACB0", Offset = "0x68492B0", VA = "0x18684ACB0", Slot = "7")]
		public override MKEIEIBMPOE DEDDKIAFLHB(int[] NBGDKCDGMIM, List<IPNLIBBOHIC> KKEHJJKOBOA, List<IPNLIBBOHIC> AJMACJIBDGK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x684AAC0", Offset = "0x68490C0", VA = "0x18684AAC0", Slot = "8")]
		public override DHKHNPGCKHB AKGEDLCCKEE(uint FALHCGACGOI, AvatarSkinnedMeshBoneOrderRemapsData NHNIGGPJCLA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x684B500", Offset = "0x6849B00", VA = "0x18684B500")]
		public DHKHNPGCKHB LPMAJCMKDPE(GameObject OCDFFLABAAF, uint FALHCGACGOI, bool BMLGDIAHHGH, bool FAMBGNNFHGC, AvatarSkinnedMeshBoneOrderRemapsData NHNIGGPJCLA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x684B140", Offset = "0x6849740", VA = "0x18684B140")]
		public static bool GIGFAOKDLBI(Renderer[] HOHMNOCOOOI, string CPNIFDIBJMJ, [Out] Renderer CPMHFAGBOII, [Out] Renderer OFFBOJMMDHO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x684B710", Offset = "0x6849D10", VA = "0x18684B710", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x684ABF0", Offset = "0x68491F0", VA = "0x18684ABF0")]
		private (JPDJGJBEGGO<AHPPPJJGNMJ>, JPDJGJBEGGO<Material[]>) BELFOAMJPIL()
		{
			return default((JPDJGJBEGGO<AHPPPJJGNMJ>, JPDJGJBEGGO<Material[]>));
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x430DD40", Offset = "0x430C340", VA = "0x18430DD40")]
		[CompilerGenerated]
		private void PAIENHADAPJ(AHPPPJJGNMJ JKLHKLABFHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x8632D0", Offset = "0x8618D0", VA = "0x1808632D0")]
		[CompilerGenerated]
		private void HNGPAJFMDFH(Material[] JKLHKLABFHH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class MFJNAEPMEBI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public EBBIKFBEAOE avatarBuildParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public EHLNPKOGLLO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public JIMPAEGGIFL buildMeshPromise;

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public MFJNAEPMEBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x684E130", Offset = "0x684C730", VA = "0x18684E130")]
		internal bool KPKNDDLLGLE(LGAGFAHPGOJ item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x684E110", Offset = "0x684C710", VA = "0x18684E110")]
		internal void EOOLJBEGDGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x684E0F0", Offset = "0x684C6F0", VA = "0x18684E0F0")]
		internal void CNOGAHKJPON(string err)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x684E060", Offset = "0x684C660", VA = "0x18684E060")]
		internal void CICANFEHLIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x684E180", Offset = "0x684C780", VA = "0x18684E180")]
		internal void MPCOMEKALDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x85F450", Offset = "0x85DA50", VA = "0x18085F450")]
		internal MKEIEIBMPOE GJMOIGANFGF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class FANHMOLFIBL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public int lowestPossibleLOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public MFJNAEPMEBI CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public FANHMOLFIBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x6849680", Offset = "0x6847C80", VA = "0x186849680")]
		internal DHCIFDNKALA LDKEFCHLBMJ(int lod)
		{
			return default(DHCIFDNKALA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class BCALOFFCDHF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public List<JIMPAEGGIFL> innerPromises;

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public BCALOFFCDHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x6839E90", Offset = "0x6838490", VA = "0x186839E90")]
		internal void INFPDBOCFAL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class HPAPHNMJCJO : IEnumerator<FDDBCEBEBAE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private FDDBCEBEBAE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public EHLNPKOGLLO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public List<NIFDOOJAHEC> parts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public int[] LODs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public List<JIMPAEGGIFL> innerPromises;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public bool isFirstPerson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public Func<int, DHCIFDNKALA> getLayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public MOIOBCBGMNP materialPropertyBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public Material materialInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private int <lodIndex>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		private FDDBCEBEBAE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x85F4F0", Offset = "0x85DAF0", VA = "0x18085F4F0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x85F4F0", Offset = "0x85DAF0", VA = "0x18085F4F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x864580", Offset = "0x862B80", VA = "0x180864580")]
		[DebuggerHidden]
		public HPAPHNMJCJO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x684A1A0", Offset = "0x68487A0", VA = "0x18684A1A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x684A3A0", Offset = "0x68489A0", VA = "0x18684A3A0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class DMIANNNOMFC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public int[] LODs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public EHLNPKOGLLO <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public DMIANNNOMFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x6839FC0", Offset = "0x68385C0", VA = "0x186839FC0")]
		internal MKEIEIBMPOE BPPHLJLLEGJ(NIFDOOJAHEC p)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class EDOMKOFIMDO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public BBJCIAFCPAB cancelable;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public EDOMKOFIMDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x8B1CE0", Offset = "0x8B02E0", VA = "0x1808B1CE0")]
		internal void GKKCLBENBOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0xB1AFB0", Offset = "0xB195B0", VA = "0x180B1AFB0")]
		internal void JKGJDIAKCFI(string err)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class EILCDDLOKEL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public long jobComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public Stopwatch stopwatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public SkinnedMeshRenderer lodRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public long meshComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public string meshName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public long meshCopyComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public EHLNPKOGLLO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public int lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public List<Material> newUniqueMaterials;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public int frameStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public long lodBuildStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public long startCombineBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public long jobScheduled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public Action onFinally;

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public EILCDDLOKEL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class OMIJBDEIALN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public bool waitingForComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public JobHandle lodBuildJobHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public NCKMCGBHHKJ defaultMeshJobContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public EFIADNNKLPN defaultAvatarMeshJobGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public EILCDDLOKEL CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public OMIJBDEIALN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x6850FC0", Offset = "0x684F5C0", VA = "0x186850FC0")]
		internal void IGCJKCHAMBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0xB16680", Offset = "0xB14C80", VA = "0x180B16680")]
		internal void NIOKFIHFMKB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class IOEOADFJNFP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public bool waitingForComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public JobHandle lodBuildJobHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public BGGDPHJHNLG legacyMeshJobContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public GHJHAKPIFIP legacyAvatarMeshJobGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public EILCDDLOKEL CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public IOEOADFJNFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x684A880", Offset = "0x6848E80", VA = "0x18684A880")]
		internal void CPDGAEELHMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0xB1B210", Offset = "0xB19810", VA = "0x180B1B210")]
		internal void BEFANGIJLHB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private sealed class IDNIDANBMMK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public KeyValuePair<string, LGAGFAHPGOJ> entry;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public BBJCIAFCPAB cancelablePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public LGAGFAHPGOJ avatarItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public EHLNPKOGLLO <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public IDNIDANBMMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x684A430", Offset = "0x6848A30", VA = "0x18684A430")]
		internal MKEIEIBMPOE KMJFKLFMJOI(DLFMDPGBKAM item)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x684A3F0", Offset = "0x68489F0", VA = "0x18684A3F0")]
		internal void BPKHPCDOEDB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class EMCGAGNFGPH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public JPDJGJBEGGO<Texture2D> resourceHandle;

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public EMCGAGNFGPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x6849630", Offset = "0x6847C30", VA = "0x186849630")]
		internal void KECKBLHOFIH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class FHBKDDCMMBL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public string overrideItemIdentifier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		public PAHGFPMKCPO overrideBodyPart;

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x8692F0", Offset = "0x8678F0", VA = "0x1808692F0")]
		public FHBKDDCMMBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x6849740", Offset = "0x6847D40", VA = "0x186849740")]
		internal bool GMOMFKFNMNE(KeyValuePair<string, LGAGFAHPGOJ> entry)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private AvatarConfiguration JDCEDPGJBBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private Transform IDELJDPGODD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private AssetReference KHFFPAFFFCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private GameObject OEKGNDJNDNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private GameObject IEFENHPBNGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private SkinnedMeshRenderer HJAGOEJIOII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private AvatarSkinnedMeshBoneOrderRemapsData OLEPHGDDBDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private Transform[] AKFIDPMLKNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private Matrix4x4[] PMIGJOPBPNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private Material AIAENONDHBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private Material MKJEPNHHGJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private Material INBEPGCNNNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private Shader GPIKCAOGMPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private Shader IKGLIPJNHCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private Animator AGOJIJBHPID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private Renderer[] HKFEHOHGMEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private LIBDCJLAIAP.JPKJJHCECFA AIPGDGEJBPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private AvatarBodyPartShapesManager HMDJAGBKKHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private IReadOnlyDictionary<string, Transform> MIIMDMHBIMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private AvatarFaceShapeData.FKNPFCANNDA JNPJOJILDAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private AvatarBodyShapeData.JIFHJLHLALN MGMJGHPKECH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private bool DCMMNEPKFKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB1")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private bool DDCDEMENLLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private Color EJADJHDHDKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private Color ACDPMDHOHOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private Color MBPGEGKKJIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private Color? DFJLDFFOPNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private Color? MKEHIKHNELO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10C")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private Color? HIMABFOFLIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private Color? DPGBMFJEKJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private Texture2D LKNBALFOAKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private Texture2D EKLPALNMBAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	[CanBeNull]
	private LGAGFAHPGOJ EFFLPLDBGJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private Texture NDNNFAOMPJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private Color AABIJNAGNEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public Dictionary<Renderer, MOIOBCBGMNP> CDGKILLAPLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private Dictionary<Renderer, MOIOBCBGMNP> GDHMOIJFNIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private Dictionary<string, List<CJOACIGFKAM>> PHNOLDLLHJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private Dictionary<string, List<CJOACIGFKAM>> CELEHJAAEFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private readonly List<IPNLIBBOHIC> HEEDPOOIEOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private readonly List<IPNLIBBOHIC> CCGMLBFJDBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly List<IPNLIBBOHIC> BAIKLCIFFMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private readonly List<IPNLIBBOHIC> NEBFHPKPPIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private Dictionary<CJOACIGFKAM, Material> JJOGJDGNLIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private Dictionary<CJOACIGFKAM, Material> FOCEBBBFCKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private SkinnedMeshRenderer[] PBFILHCFMKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private SkinnedMeshRenderer[] EBOPAOCNIOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private SkinnedMeshRenderer[] COBOFANMKJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private SkinnedMeshRenderer[] MNLOGPMIOHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private readonly Dictionary<string, JPDJGJBEGGO<Texture2D>> HNPDHLGLPAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private readonly Dictionary<string, JPDJGJBEGGO<Texture2D>> KHJNJCLOJCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private AdditionalHatData HHMEKEGGIOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private PBNEKNMOCAD GJLLFPAGBJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private FitMeshHemisphere EPPIGMMLFLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private PositionAndRotation GPBJLELKMNE;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private Material CFCDKBAEMCD;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private Material BNNNKDDPAOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private Dictionary<string, LGAGFAHPGOJ> FIAMABGECLO;

	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private static readonly int OIFAPPDGAOG;

	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private static readonly int DKMCLNHENPD;

	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private static readonly int KIKKHOOFFPM;

	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private static readonly int BFNDFFELGPD;

	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private static readonly int BIMIGNGOCHH;

	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private static readonly int GEBNMHCHIIL;

	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private static readonly int HMDCLKCALBP;

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private static readonly int BAOJOFNLDEF;

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private static readonly int OJNPHCCLKME;

	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private static readonly int MKHBKMEJMAF;

	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private static readonly int JCLPOPFKDDD;

	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private static readonly int HMAPGMFONGP;

	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private static readonly int JFOIELMDBHO;

	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private static readonly int KMMACLAJDJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private readonly CLOBMDANPDK CBMMAGOFNGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private readonly CLOBMDANPDK MNNGLBFBIKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private bool ICFNKIDCLMP;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private static Lazy<FJMADKKFIAE> GKBHNNBPEJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private Lazy<ODDAJGNDHLB> CELINMPLMPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private Lazy<HEBHDJDFDPB> DBNHGOKPALC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private MADIJKNICIM MMDJNGHALPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private List<Action> GKMIGGMBGDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private DNHBLDMMNNO BKKMMPDOJKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private SkinnedMeshRenderer[] OFEGOOCJIBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private int MNDEEHFMGBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x284")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private bool LHGBAPMJOON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private int OFODKDBOEME;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool NDIPACOPDAF
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xA8DCC0", Offset = "0xA8C2C0", VA = "0x180A8DCC0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0xA8D010", Offset = "0xA8B610", VA = "0x180A8D010")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private Material JHMPIMBBOGF
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x6842B70", Offset = "0x6841170", VA = "0x186842B70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private Material ADFDBFBFHKD
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x6843EB0", Offset = "0x68424B0", VA = "0x186843EB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private bool DCAJFDFKBPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x878510", Offset = "0x876B10", VA = "0x180878510")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public MKCGKHDCIPE IGBLMFIDNCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x9BD990", Offset = "0x9BBF90", VA = "0x1809BD990", Slot = "21")]
		get
		{
			return default(MKCGKHDCIPE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	private static FJMADKKFIAE IAIHNIPAOFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x6844F90", Offset = "0x6843590", VA = "0x186844F90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	private ODDAJGNDHLB FGACIDNOKJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x68449D0", Offset = "0x6842FD0", VA = "0x1868449D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private HEBHDJDFDPB FBHANDEKBKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6840440", Offset = "0x683EA40", VA = "0x186840440")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	private MADIJKNICIM CBAEJNPMGEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x683B870", Offset = "0x6839E70", VA = "0x18683B870")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public CLOBMDANPDK JPKPBFKEJID
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xC6E3B0", Offset = "0xC6C9B0", VA = "0x180C6E3B0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public CLOBMDANPDK CBMEGHNIBKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xA8E9F0", Offset = "0xA8CFF0", VA = "0x180A8E9F0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public SkinnedMeshRenderer[] KGFIAECHOPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x14CEB70", Offset = "0x14CD170", VA = "0x1814CEB70", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public Renderer[] NHHIPONBPCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x861ED0", Offset = "0x8604D0", VA = "0x180861ED0", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool KDHFCBJMLBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6844570", Offset = "0x6842B70", VA = "0x186844570", Slot = "20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public PositionAndRotation IALBKHLCAEM
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x683D0C0", Offset = "0x683B6C0", VA = "0x18683D0C0", Slot = "27")]
		get
		{
			return default(PositionAndRotation);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public LIBDCJLAIAP.JPKJJHCECFA NAOLCOBGGJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x861F10", Offset = "0x860510", VA = "0x180861F10", Slot = "18")]
		get
		{
			return default(LIBDCJLAIAP.JPKJJHCECFA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public int INCOOKMIGOP
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x2246C00", Offset = "0x2245200", VA = "0x182246C00")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6840F90", Offset = "0x683F590", VA = "0x186840F90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	private bool JJGENJKIIID
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x683EED0", Offset = "0x683D4D0", VA = "0x18683EED0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private static bool ABEFKBIEKHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x683CA30", Offset = "0x683B030", VA = "0x18683CA30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6846FE0", Offset = "0x68455E0", VA = "0x186846FE0")]
	public EHLNPKOGLLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x683F8A0", Offset = "0x683DEA0", VA = "0x18683F8A0", Slot = "28")]
	public void HGDANEHJCNG(GMHBGOLIPKM CLGOGFAKGMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x683D2D0", Offset = "0x683B8D0", VA = "0x18683D2D0", Slot = "29")]
	public void FDJHNDOCOED(CPAJFNAHJIL NACPMONJOAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x6840F90", Offset = "0x683F590", VA = "0x186840F90", Slot = "4")]
	public void MLEDKBHAICI(int FALHCGACGOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x683F110", Offset = "0x683D710", VA = "0x18683F110", Slot = "9")]
	public void GBBNKMINHHA(DBAMAAOKFAL DABMDLBJBKL, Texture2D HMBKEPDDPFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x683CDE0", Offset = "0x683B3E0", VA = "0x18683CDE0", Slot = "10")]
	public void DPJNAAJEJEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6842560", Offset = "0x6840B60", VA = "0x186842560", Slot = "11")]
	public bool LFKJICACKDJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6840040", Offset = "0x683E640", VA = "0x186840040", Slot = "8")]
	public void IIOPMMIKIIN(NEGAFMHKAPM IJEJJFPFEDL, Color? KOEHPNBNNJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x683D250", Offset = "0x683B850", VA = "0x18683D250")]
	private void FABGJIGJNOF(Action NGNBPDFEAMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x683BD90", Offset = "0x683A390", VA = "0x18683BD90", Slot = "5")]
	public void ALAECFGIMMA(LGAGFAHPGOJ LIIGDACMPMJ, Texture NIMHMJPBKIO, Color EJAPBENMOKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0xA8D010", Offset = "0xA8B610", VA = "0x180A8D010", Slot = "6")]
	public void HCIBPOGBDLI(bool AAELHBLKEFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0xBE93F0", Offset = "0xBE79F0", VA = "0x180BE93F0", Slot = "7")]
	public void OMALLGICFMO(DNHBLDMMNNO MBKNFOKFHJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x683D900", Offset = "0x683BF00", VA = "0x18683D900", Slot = "14")]
	public JIMPAEGGIFL FJGDNGNLEAJ(EBBIKFBEAOE GFPHHGDCOLD, bool DFCGLOPAHGF, int[] JNLGHNBFJJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x683F3A0", Offset = "0x683D9A0", VA = "0x18683F3A0", Slot = "15")]
	public void GMBCHGJGFOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6842EE0", Offset = "0x68414E0", VA = "0x186842EE0", Slot = "26")]
	public void NCGPIINPCMF([Optional] PBNEKNMOCAD MLJEPCBHLNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6844710", Offset = "0x6842D10", VA = "0x186844710")]
	private bool OLHDHKDDGHH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x683BD70", Offset = "0x683A370", VA = "0x18683BD70", Slot = "19")]
	public bool AHKLNIELLHA(LIBDCJLAIAP.JPKJJHCECFA LPFNCOBFEKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6840490", Offset = "0x683EA90", VA = "0x186840490")]
	private bool ILGEJBIENJK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6843FA0", Offset = "0x68425A0", VA = "0x186843FA0")]
	private JIMPAEGGIFL NMFGINFKCHB(bool DFCGLOPAHGF, List<NIFDOOJAHEC> MEMOKDJFEBO, int[] JNLGHNBFJJG, Func<int, DHCIFDNKALA> IILGJHCJENI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6841180", Offset = "0x683F780", VA = "0x186841180")]
	[IteratorStateMachine(typeof(HPAPHNMJCJO))]
	private IEnumerator<FDDBCEBEBAE> JMGKJMOEELI(bool DFCGLOPAHGF, List<NIFDOOJAHEC> MEMOKDJFEBO, int[] JNLGHNBFJJG, Func<int, DHCIFDNKALA> IILGJHCJENI, MOIOBCBGMNP IOBLNEFIEBD, Material GIHGNFNLOFB, List<JIMPAEGGIFL> ALJJCIJECOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x683C4D0", Offset = "0x683AAD0", VA = "0x18683C4D0")]
	private JIMPAEGGIFL CGBHMDHEFAB(List<NIFDOOJAHEC> MEMOKDJFEBO, int[] JNLGHNBFJJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x68450D0", Offset = "0x68436D0", VA = "0x1868450D0")]
	private MCOHGCAFPBM PMANGLFAMEP(List<NIFDOOJAHEC> MEMOKDJFEBO, int FALHCGACGOI, bool DFCGLOPAHGF, DHCIFDNKALA ILAGHFEIHOD, bool BCEDCEAEJAA, MOIOBCBGMNP IOBLNEFIEBD, Material GIHGNFNLOFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6840D80", Offset = "0x683F380", VA = "0x186840D80", Slot = "22")]
	public void JBKNDKFAOFD(AvatarFaceShape DPOJGDLHMLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x683B8F0", Offset = "0x6839EF0", VA = "0x18683B8F0", Slot = "23")]
	public void AEEBHEGMHOJ(AvatarBodyShape KCDAHIAAEPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x683D350", Offset = "0x683B950", VA = "0x18683D350", Slot = "25")]
	public void FEHMJOGKPBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x683CBD0", Offset = "0x683B1D0", VA = "0x18683CBD0", Slot = "24")]
	public void DIMMONOCJJK(bool ICMMFCCAKFF, bool CPOGNINABGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6840FB0", Offset = "0x683F5B0", VA = "0x186840FB0")]
	private void JMCIOFIFHKJ(SkinnedMeshRenderer JBCBHHKNJAG, int FALHCGACGOI, Mesh GOBEKKOCOLP, List<Material> GEPLILJIALF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x683FE80", Offset = "0x683E480", VA = "0x18683FE80")]
	private static Material IEOJBGDJMLA(Dictionary<CJOACIGFKAM, Material> BNFAELLBCBI, Material NLCHCBMMNJP, GJOEFCDBKNJ MHIHIGAKEGO, HKBDNHJCEAK PDOMNFDJDNM, PAHGFPMKCPO JCPMBIEAGBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6842D00", Offset = "0x6841300", VA = "0x186842D00")]
	private static GJOEFCDBKNJ MMNBMJPFGIO(NIFDOOJAHEC CKEMNPDIPPL, int ABFLGGCIOEB)
	{
		return default(GJOEFCDBKNJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x683D460", Offset = "0x683BA60", VA = "0x18683D460")]
	private void FHACLMILPKI(int CKMGAKMKFDL, Material JFOAGNGANHG, NIFDOOJAHEC CKEMNPDIPPL, [Out] Texture2D LOJFHMKDMME, [Out] Vector4 MHKPPNALHMN, [Out] Texture2D OIEHMNACCGB, [Out] Texture2D BOAGJOJFHCH, [Out] Texture2D JHIJNFFCCDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6842080", Offset = "0x6840680", VA = "0x186842080")]
	private void LFAGODMDGHJ(int CKMGAKMKFDL, Material JFOAGNGANHG, NIFDOOJAHEC CKEMNPDIPPL, [Out] Color FJLGHDOEFAO, [Out] Color PJPDLIJOMPE, [Out] Color MEELNFCIGJF, [Out] Color AJBAHOMHEMC, [Out] Color GKALBDKDNLN, [Out] Color GKOJEMKMKDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x683CE60", Offset = "0x683B460", VA = "0x18683CE60")]
	private bool ECMJNKCAFFJ(Material JFOAGNGANHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x683F350", Offset = "0x683D950", VA = "0x18683F350")]
	private static Material GFDBIKDLFDJ(int CKMGAKMKFDL, JBAJIKLNLIE CKEMNPDIPPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x683EF50", Offset = "0x683D550", VA = "0x18683EF50")]
	private static HKBDNHJCEAK FLBLHFPEGCP(NIFDOOJAHEC CKEMNPDIPPL, int ABFLGGCIOEB)
	{
		return default(HKBDNHJCEAK);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x683F5A0", Offset = "0x683DBA0", VA = "0x18683F5A0")]
	private static void GOAKJCECCJO(Dictionary<string, List<CJOACIGFKAM>> DJDHJPFPAPK, NIFDOOJAHEC HOHPJJMJEHF, Material NLCHCBMMNJP, GJOEFCDBKNJ IJEJJFPFEDL, HKBDNHJCEAK DABMDLBJBKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6844D60", Offset = "0x6843360", VA = "0x186844D60")]
	private static SkinnedMeshRenderer PHFAKPODLGD(Transform GHAHHFPKKID, Transform FBDJBMEENFL, SkinnedMeshRenderer[] HOHMNOCOOOI, int FALHCGACGOI, DHCIFDNKALA ILAGHFEIHOD, bool DFCGLOPAHGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6843CF0", Offset = "0x68422F0", VA = "0x186843CF0")]
	private void NKCPJENKCEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x683D450", Offset = "0x683BA50", VA = "0x18683D450")]
	private void FGHFOGDLCEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x683C370", Offset = "0x683A970", VA = "0x18683C370")]
	private static void CFCAPABOMDM(Dictionary<CJOACIGFKAM, Material> BNFAELLBCBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x683C210", Offset = "0x683A810", VA = "0x18683C210")]
	private static void CECEPCFKPBE(Dictionary<Renderer, MOIOBCBGMNP> PNDAPJHBHDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x683FCD0", Offset = "0x683E2D0", VA = "0x18683FCD0")]
	private void HMPNKMOAFCN(SkinnedMeshRenderer[] HOHMNOCOOOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6846C10", Offset = "0x6845210", VA = "0x186846C10")]
	private void PPMDCCHHGBB(SkinnedMeshRenderer EPLHIKMFICF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6842830", Offset = "0x6840E30", VA = "0x186842830")]
	private void MEOHBIOLAGC(List<IPNLIBBOHIC> CNNHJLMPEOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6844850", Offset = "0x6842E50", VA = "0x186844850")]
	private void OONKOOJLLDB(Dictionary<string, JPDJGJBEGGO<Texture2D>> DJDHJPFPAPK, bool AGKCBAAKCOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x683C1C0", Offset = "0x683A7C0", VA = "0x18683C1C0")]
	private void BKJLCCCEFCK(Dictionary<string, List<CJOACIGFKAM>> DJDHJPFPAPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x683D0F0", Offset = "0x683B6F0", VA = "0x18683D0F0")]
	private void EILPLHPOLOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x68417E0", Offset = "0x683FDE0", VA = "0x1868417E0")]
	private void KCDFOGNBJAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6841290", Offset = "0x683F890", VA = "0x186841290")]
	private void KCAOHHPMEAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x683F040", Offset = "0x683D640", VA = "0x18683F040")]
	private void FOPGJKFJBHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x683D870", Offset = "0x683BE70", VA = "0x18683D870")]
	private void FJGCCIDAKAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x683C8B0", Offset = "0x683AEB0", VA = "0x18683C8B0")]
	private void CNIPKEHOHPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6845000", Offset = "0x6843600", VA = "0x186845000")]
	private void PKJJFMCGLFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x68426D0", Offset = "0x6840CD0", VA = "0x1868426D0")]
	private void LHAMMPCMNMN(bool KBHLBBHBIMP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x683C0F0", Offset = "0x683A6F0", VA = "0x18683C0F0")]
	private void BFBEOLHAMJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x6842E40", Offset = "0x6841440", VA = "0x186842E40")]
	private void NBFHFFLPELF(bool KBHLBBHBIMP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x6844A20", Offset = "0x6843020", VA = "0x186844A20")]
	private void PHADKIHHCJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x68408B0", Offset = "0x683EEB0", VA = "0x1868408B0")]
	private void JBDBOPNKBLJ(Material GIHGNFNLOFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x683FB60", Offset = "0x683E160", VA = "0x18683FB60")]
	private void HIBLCIOCIKL(Material GIHGNFNLOFB, Color JLMLNMDBMKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x683BE00", Offset = "0x683A400", VA = "0x18683BE00")]
	private void ALEEDNDIDHE(Material GIHGNFNLOFB, Color BMIMHOADLJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x6842A00", Offset = "0x6841000", VA = "0x186842A00")]
	private void MJHAEGCPOJO(Material GIHGNFNLOFB, Color FJLGHDOEFAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x683CBE0", Offset = "0x683B1E0", VA = "0x18683CBE0")]
	private void DMNKLNEPFBO(Material GIHGNFNLOFB, Texture2D HMBKEPDDPFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x6840E40", Offset = "0x683F440", VA = "0x186840E40")]
	private void JCAGOOEMPFM(Material GIHGNFNLOFB, Texture JPHIJFMMIIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x68436D0", Offset = "0x6841CD0", VA = "0x1868436D0")]
	private void NFDPFAAJHCG(Action<MOIOBCBGMNP> BNCIMDPGLKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x683BF70", Offset = "0x683A570", VA = "0x18683BF70")]
	private void ALEKIOJJNFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6840550", Offset = "0x683EB50", VA = "0x186840550")]
	private void JAFNNNFMION()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x6841970", Offset = "0x683FF70", VA = "0x186841970")]
	private JIMPAEGGIFL KOPKJAAKPMH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6843890", Offset = "0x6841E90", VA = "0x186843890")]
	private void NFIDCNHPMJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x683B9B0", Offset = "0x6839FB0", VA = "0x18683B9B0")]
	public void AFJJCGKGGOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x683FDF0", Offset = "0x683E3F0", VA = "0x18683FDF0")]
	[CompilerGenerated]
	private void IBDAAKHDGAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x683CA00", Offset = "0x683B000", VA = "0x18683CA00")]
	[CompilerGenerated]
	private void CPJHOOCDOKL(MOIOBCBGMNP EDLBKILJCNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x683C820", Offset = "0x683AE20", VA = "0x18683C820")]
	[CompilerGenerated]
	private void CLHLEFNPJFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x6842E20", Offset = "0x6841420", VA = "0x186842E20")]
	[CompilerGenerated]
	private void MNFCPLIMFJE(MOIOBCBGMNP EDLBKILJCNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6841FF0", Offset = "0x68405F0", VA = "0x186841FF0")]
	[CompilerGenerated]
	private void LEJDFLKEBAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x683F880", Offset = "0x683DE80", VA = "0x18683F880")]
	[CompilerGenerated]
	private void GPHLKEFBDIM(MOIOBCBGMNP EDLBKILJCNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6843C60", Offset = "0x6842260", VA = "0x186843C60")]
	[CompilerGenerated]
	private void NJNLIBECMLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6840010", Offset = "0x683E610", VA = "0x186840010")]
	[CompilerGenerated]
	private void IGMBKAAHKFO(MOIOBCBGMNP EDLBKILJCNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x683B7E0", Offset = "0x6839DE0", VA = "0x18683B7E0")]
	[CompilerGenerated]
	private void ABLLENFGFCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x683FFE0", Offset = "0x683E5E0", VA = "0x18683FFE0")]
	[CompilerGenerated]
	private void IFCJLPFOIOG(MOIOBCBGMNP EDLBKILJCNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x683C790", Offset = "0x683AD90", VA = "0x18683C790")]
	[CompilerGenerated]
	private void CKGEKKBDFCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x68446E0", Offset = "0x6842CE0", VA = "0x1868446E0")]
	[CompilerGenerated]
	private void OJLNKJGJPPM(MOIOBCBGMNP EDLBKILJCNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6841F60", Offset = "0x6840560", VA = "0x186841F60")]
	[CompilerGenerated]
	private void LBGKIHJDDPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x683F320", Offset = "0x683D920", VA = "0x18683F320")]
	[CompilerGenerated]
	private void GCNBKKMPIJO(MOIOBCBGMNP EDLBKILJCNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x683CD60", Offset = "0x683B360", VA = "0x18683CD60")]
	[CompilerGenerated]
	private void DNLMNJDEIMM(KeyValuePair<string, JPDJGJBEGGO<Texture2D>> NGLGOJFDCHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x6842770", Offset = "0x6840D70", VA = "0x186842770")]
	[CompilerGenerated]
	private void LLKPBELNMCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x683BD40", Offset = "0x683A340", VA = "0x18683BD40")]
	[CompilerGenerated]
	private void AHFMCLHCCEH(MOIOBCBGMNP EDLBKILJCNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x68410F0", Offset = "0x683F6F0", VA = "0x1868410F0")]
	[CompilerGenerated]
	private void JMGGIBJMAGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x6842800", Offset = "0x6840E00", VA = "0x186842800")]
	[CompilerGenerated]
	private void LPOLBMIPKLK(MOIOBCBGMNP EDLBKILJCNB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class KMBEPBFDGBK : LJDPCPONGBK
{
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private static readonly int MDKIHHLAGHN;

	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private static readonly int NHLBMPAHAJC;

	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private static readonly int MDECNGPCJKC;

	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private static readonly int GFFNOFCGNCD;

	[Cpp2IlInjected.Token(Token = "0x4000130")]
	private static readonly int COBOLGDHOHB;

	[Cpp2IlInjected.Token(Token = "0x4000131")]
	private static readonly int CJDOEIJPEDH;

	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private static readonly int GNDMMOHOFKP;

	[Cpp2IlInjected.Token(Token = "0x4000133")]
	private static readonly int OENAKFMHPDN;

	[Cpp2IlInjected.Token(Token = "0x4000134")]
	private static readonly int CFPJNMOOCAN;

	[Cpp2IlInjected.Token(Token = "0x4000135")]
	private static readonly int JEADOFADNHN;

	[Cpp2IlInjected.Token(Token = "0x4000136")]
	private static readonly int GCNDHDLPJFD;

	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private static readonly int PEDDGDINGJL;

	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private static readonly int KONMJJHGMCD;

	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private static readonly int ANJIJCAEMND;

	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private static readonly int DOCNKANCHID;

	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private static readonly int EKKJJDHKDPN;

	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private static readonly int MCHDCEPIMKP;

	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private static readonly int KMBKIFHFILC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private Transform NABKBGCBNNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private Transform AMPHGPEKFCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private Transform CAOHLNJFIPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private Transform OGBHPBJPKML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private Transform HLKNOFMELKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private Transform GGNMBKMFDAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private Transform BCOEGLPIBNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private FAIFPEGDEPG HDJOCPPADAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private MaterialPropertyBlock EMJAIIKINLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private SkinnedMeshRenderer[] BDAAFNMHNLK;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	private MaterialPropertyBlock HJLLLGIJNNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x684D0A0", Offset = "0x684B6A0", VA = "0x18684D0A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool JJGAJOKOGGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x684CA30", Offset = "0x684B030", VA = "0x18684CA30", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x684C970", Offset = "0x684AF70", VA = "0x18684C970", Slot = "7")]
	public void HGDANEHJCNG(FAIFPEGDEPG FMEOMCLBFAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x684C940", Offset = "0x684AF40", VA = "0x18684C940", Slot = "8")]
	public void FNOFMOKKHKO(GPGKGAIBADN GHNGAPLEBLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x684CBB0", Offset = "0x684B1B0", VA = "0x18684CBB0", Slot = "5")]
	public void JCEAKGPFKJC(GANCGFPKNOE LOPPBPPOGHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x684B7C0", Offset = "0x6849DC0", VA = "0x18684B7C0")]
	private Vector2 AHJJJMIDNLM(Vector2 NEJLKGCCIOP)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x684B820", Offset = "0x6849E20", VA = "0x18684B820", Slot = "6")]
	public void DKMBHJCCMAI(JEBFMEMAPLC GHNGAPLEBLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x684D160", Offset = "0x684B760", VA = "0x18684D160")]
	private void OAEHKHPMECN(JEBFMEMAPLC NIODIMIPJHP, ANOBNMBDHAM FIHBAPBENED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x684CFC0", Offset = "0x684B5C0", VA = "0x18684CFC0")]
	private void JJIIPFJAMCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x684D830", Offset = "0x684BE30", VA = "0x18684D830")]
	public KMBEPBFDGBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x684D4A0", Offset = "0x684BAA0", VA = "0x18684D4A0")]
	[CompilerGenerated]
	internal static (float, float) PCBCPMJBLHM(float EHDPADPHGPK)
	{
		return default((float, float));
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x684D120", Offset = "0x684B720", VA = "0x18684D120")]
	[CompilerGenerated]
	internal static Vector4 MFOKNIBLAIH(Vector2 LPBGBJBIAOJ, Vector2 JAGNHLKKADJ)
	{
		return default(Vector4);
	}
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public class AvatarItemMaterial : ScriptableObject, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		[Obsolete("Use CombinationId instead!")]
		[SerializeField]
		private string Guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		[SerializeField]
		private SerializedCombinationId combinationId;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		private PDKNDOAIJGM? cachedMaterialCombinationId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		[SerializeField]
		private Material material;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		[SerializeField]
		private Material[] additionalMaterials;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public NHDGGCIBEGO CombinationId
		{
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x6852FC0", Offset = "0x68515C0", VA = "0x186852FC0")]
			get
			{
				return default(NHDGGCIBEGO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public PDKNDOAIJGM MaterialCombinationId
		{
			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x6852FF0", Offset = "0x68515F0", VA = "0x186852FF0")]
			get
			{
				return default(PDKNDOAIJGM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public Material Material
		{
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x861750", Offset = "0x85FD50", VA = "0x180861750")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public Material[] AdditionalMaterials
		{
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x861770", Offset = "0x85FD70", VA = "0x180861770")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x6852C60", Offset = "0x6851260", VA = "0x186852C60")]
		public Material[] EIBAPNEMJMG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x6852D40", Offset = "0x6851340", VA = "0x186852D40")]
		public static void KMMCMFFIFCI(AvatarItemMaterial NDEFLGHIIKP, Material JFOAGNGANHG, int CKMGAKMKFDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x6852F00", Offset = "0x6851500", VA = "0x186852F00")]
		public AvatarItemMaterial()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[GJMIOABHJEG]
public struct ACMGPHNPEAK : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	[ReadOnly]
	public GHJHAKPIFIP OMLPEKINJOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	[ReadOnly]
	public int JDDOFOEBLOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	public BGGDPHJHNLG CGMJEJIJELG;

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x6851B40", Offset = "0x6850140", VA = "0x186851B40", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[NativeContainer]
[GJMIOABHJEG]
public struct BGGDPHJHNLG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	public NativeArray<Vector3> KCLIPGBDGJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	public NativeArray<Vector3> JDHABOMIFGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	public NativeArray<Vector4> CMOHCJFAEON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	public NativeArray<Vector2> LFHHJFADOGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	public NativeArray<Vector2> CGCFHIACNAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	public NativeArray<Vector2> KOLJHPJAPNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	public NativeArray<Vector2> IMNGFOIGFAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	public NativeArray<Color> COAIIIPAOFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	public NativeArray<int> NKLCHGOEEDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	public NativeArray<int> DOOAEHJPJEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	private NativeArray<int> NIBBCIAIEAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private NativeArray<int> LNCJLAPGNCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	public NativeArray<int> EJJCNCIGJDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	public NativeArray<int> BPNNLIJNLJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	public NativeArray<int> FMFFJLGOEJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	public NativeArray<BoneWeight> PBECDHGFPLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	private NativeArray<int> MBKNFOKFHJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	private bool GNGCAHFGDNF;

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public int FPPFNJPGCOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x6853740", Offset = "0x6851D40", VA = "0x186853740")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x6853480", Offset = "0x6851A80", VA = "0x186853480")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public int LLKECIDLMGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x68530B0", Offset = "0x68516B0", VA = "0x1868530B0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x68539A0", Offset = "0x6851FA0", VA = "0x1868539A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public int FPIDJGAKDCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x6853AF0", Offset = "0x68520F0", VA = "0x186853AF0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x68536E0", Offset = "0x6851CE0", VA = "0x1868536E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x6853B00", Offset = "0x6852100", VA = "0x186853B00")]
	public BGGDPHJHNLG(int INFGCCAIILB, int GDPPGIECEMD, int PHAIIFLCAPO, int AMNCMEGLLMN, Allocator JKHEKCINHDP, int IOFBKPBJGMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x6853410", Offset = "0x6851A10", VA = "0x186853410")]
	public void CEKHLDBAAHE(int EBDMAJMOJLN, Vector3 ONOKCMNNMGN, Vector3 DMAHMKCJEMH, Vector4 GJMDIBEDCBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x6853750", Offset = "0x6851D50", VA = "0x186853750")]
	public void JPNIBLOFMHF(int EBDMAJMOJLN, BoneWeight FPNKJPHGNPB, NativeSlice<byte> IMAKAICAGGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x68539B0", Offset = "0x6851FB0", VA = "0x1868539B0")]
	public Color KEIJIFENGCD(int EBDMAJMOJLN)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x6853AD0", Offset = "0x68520D0", VA = "0x186853AD0")]
	public void NBIJEOFIGMG(int EBDMAJMOJLN, Color EIFPFLKPFCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x68536F0", Offset = "0x6851CF0", VA = "0x1868536F0")]
	public void GAKFDLBBFNC(byte MILCODCFPBM, int EBDMAJMOJLN, Vector2 OFLKJDKEKDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x6853490", Offset = "0x6851A90", VA = "0x186853490")]
	public void CLEDHFEDCPI(int EBDMAJMOJLN, int ACJKJJIBBDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x6853AA0", Offset = "0x68520A0", VA = "0x186853AA0")]
	public bool MKDHJDJDDCI(int MILCODCFPBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x68539D0", Offset = "0x6851FD0", VA = "0x1868539D0")]
	public void MHHLGPGKMBG(int AIGEDCCMDCH, int LHOLHMCKPEO, int KDDFOIMAIHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x68538F0", Offset = "0x6851EF0", VA = "0x1868538F0")]
	public int[] KDFMHEJIBJP(int AIGEDCCMDCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x68534A0", Offset = "0x6851AA0", VA = "0x1868534A0")]
	private NativeSlice<int> DPCDGMGGNON(int AIGEDCCMDCH)
	{
		return default(NativeSlice<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x6853530", Offset = "0x6851B30", VA = "0x186853530", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x68530C0", Offset = "0x68516C0", VA = "0x1868530C0")]
	public Mesh BKCPHBDCCNI([Optional] string LEEGOJNNBBK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[NativeContainer]
[DefaultMember("Item")]
[GJMIOABHJEG]
public struct GHJHAKPIFIP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	public NativeArray<Vector3> KCLIPGBDGJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	public NativeArray<Vector3> JDHABOMIFGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	public NativeArray<Vector4> CMOHCJFAEON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	public NativeArray<Vector2> LFHHJFADOGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	public NativeArray<Vector2> CGCFHIACNAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	public NativeArray<Vector2> KOLJHPJAPNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	public NativeArray<Vector2> IMNGFOIGFAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	public NativeArray<Color> COAIIIPAOFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	public NativeArray<int> CGGJENKDBLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	public NativeArray<int> PJLGFMJDLKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	public NativeArray<int> ENFHMFBIFIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	public NativeArray<int> PHKBFCHHOJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	public NativeArray<bool> CBOJOFHPECI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	public NativeArray<int> IONPKDLJCBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	public NativeArray<int> MEIDABKJMEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	public NativeArray<BoneWeight> PEJKEEAMCML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private NativeArray<Matrix4x4> LGMLBAFEEND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private NativeArray<int> HBKACDCMLKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private NativeArray<byte> ODEJPPFMPBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private NativeArray<int> NKIBANFCNIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private NativeArray<int> GBONJDLFJBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	public NativeArray<sbyte> MLIDNNCMCLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	public NativeArray<byte> MHDOMBGDOCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private NativeArray<int> IMIDEGNLOPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	private bool GNGCAHFGDNF;

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public int JGMIEBHOMEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x200ADE0", Offset = "0x20093E0", VA = "0x18200ADE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public int GPNDGLIEGIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x10EB850", Offset = "0x10E9E50", VA = "0x1810EB850")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public int NGEOFNGDPBC
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x68563B0", Offset = "0x68549B0", VA = "0x1868563B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public int FLFGNGIJGFC
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x6855E50", Offset = "0x6854450", VA = "0x186855E50")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x6855BC0", Offset = "0x68541C0", VA = "0x186855BC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public int FPPFNJPGCOK
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x6855E60", Offset = "0x6854460", VA = "0x186855E60")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x6855AD0", Offset = "0x68540D0", VA = "0x186855AD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public int PAAEHGOJJHP
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x6855E30", Offset = "0x6854430", VA = "0x186855E30")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x6855AC0", Offset = "0x68540C0", VA = "0x186855AC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public JFKHKMCOFGG GNHLNPPJBBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x6855E40", Offset = "0x6854440", VA = "0x186855E40")]
		get
		{
			return default(JFKHKMCOFGG);
		}
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x6855E70", Offset = "0x6854470", VA = "0x186855E70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public byte AGNNDEEDFBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x6855E80", Offset = "0x6854480", VA = "0x186855E80")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x6855BB0", Offset = "0x68541B0", VA = "0x186855BB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public BFOGFOAEMGF ECHCHHAAKAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x6855E90", Offset = "0x6854490", VA = "0x186855E90")]
		get
		{
			return default(BFOGFOAEMGF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x68563E0", Offset = "0x68549E0", VA = "0x1868563E0")]
	public GHJHAKPIFIP(IList<Mesh> ABCGPOLADKD, IList<Matrix4x4> IJEIGIKCPLO, IList<bool> CBOJOFHPECI, byte CFEDIPKKDLI, IList<byte[]> EKFJNKPHEBI, IList<int> LFAFPPBICGF, IList<bool> PCBLLKDJHGG, IList<int> IONPKDLJCBO, IList<int> MNIJLMICPLA, IList<int> LOHGCBNDHFH, Allocator JKHEKCINHDP, JFKHKMCOFGG EPNKPGGDMBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x6855AE0", Offset = "0x68540E0", VA = "0x186855AE0")]
	public BGGDPHJHNLG CHPCPPCOADD(Allocator JKHEKCINHDP)
	{
		return default(BGGDPHJHNLG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x6855BD0", Offset = "0x68541D0", VA = "0x186855BD0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[GJMIOABHJEG]
public class DGENKHAKCHE : GMGOKEDFEGG
{
	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x6854840", Offset = "0x6852E40", VA = "0x186854840")]
	public GHJHAKPIFIP NDDLJFOAPJA()
	{
		return default(GHJHAKPIFIP);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x6849AC0", Offset = "0x68480C0", VA = "0x186849AC0")]
	public DGENKHAKCHE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public struct BFOGFOAEMGF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	public NativeSlice<Vector3> KCLIPGBDGJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	public NativeSlice<Vector3> JDHABOMIFGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	public NativeSlice<Vector4> CMOHCJFAEON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	public NativeSlice<Vector2> LFHHJFADOGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	public NativeSlice<Vector2> CGCFHIACNAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	public NativeSlice<Vector2> KOLJHPJAPNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	public NativeSlice<Vector2> IMNGFOIGFAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	public NativeSlice<Color> COAIIIPAOFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	public NativeSlice<int> MIJEIKDICNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	public NativeSlice<int> PHKBFCHHOJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	public NativeSlice<BoneWeight> PEJKEEAMCML;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	public NativeSlice<byte> EAJOOIJKJPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	public int CFAABHEDIBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	public Matrix4x4 JBNIANGODNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	public int COLJDKPLIAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	public NativeSlice<byte> IMAKAICAGGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	public bool JDFPAOKBOCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	public int BHNHDPHGJAI;
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
internal readonly struct CJOACIGFKAM : IEquatable<CJOACIGFKAM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	internal readonly Material CNCBBBNCHFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	internal readonly GJOEFCDBKNJ AHMIDJCBLPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	internal readonly HKBDNHJCEAK MMDKIIOCDDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	internal readonly PAHGFPMKCPO JJLIFNGFIBD;

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0xB11F40", Offset = "0xB10540", VA = "0x180B11F40")]
	public CJOACIGFKAM(Material JFOAGNGANHG, GJOEFCDBKNJ MHIHIGAKEGO, HKBDNHJCEAK PDOMNFDJDNM, PAHGFPMKCPO JCPMBIEAGBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x6854620", Offset = "0x6852C20", VA = "0x186854620", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0xB11CA0", Offset = "0xB102A0", VA = "0x180B11CA0", Slot = "4")]
	public bool Equals(CJOACIGFKAM OGEIJLCLBIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x68544A0", Offset = "0x6852AA0", VA = "0x1868544A0", Slot = "0")]
	public override bool Equals(object CDBNFNMIHPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x6854580", Offset = "0x6852B80", VA = "0x186854580", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public class MOIOBCBGMNP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	private MaterialPropertyBlock FHLCIAMMIMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	public Color? NELNFIOHMHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	public Color? GPCOGAOIKGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	public Color? JKJMBAONAGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	public Color? JABOOEPGMIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	public Color OGCGNFFJGEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	public Color ELIFPECMBIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	public Color JKBPGMOAKBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	public Texture2D LMCGLIENMFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	public Texture2D NOBANGKHHPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	private Dictionary<CJOACIGFKAM, int> OFIJEGLHMCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private GJOEFCDBKNJ[] ANKGLLEIGFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private HKBDNHJCEAK[] POHDGIDAMDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	public Vector4[] FNDDJBDJNMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	public Vector4[] PLAKABLEFKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	public Vector4[] FMPDIKGBBCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	public Vector4[] CMLPCBKOPOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	public Vector4[] AKNDEHMELPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	public Vector4[] LLMPIDMJKGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private List<Texture2D> DEJLNBJJBNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private Vector4[] PPOIIBPPHJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	private List<Texture2D> JBCBOKKNKKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	private float[] ICKADKOKLFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	private Vector4[] EADCELGAFFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	private float[] GBBEGLKECCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	public float[] FIOEHAHBJOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	private List<Texture2D> DIEGOCIEINE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	private float[] ALHNENOFJPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private List<Texture2D> MOIDLKKEEGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	private Vector4[] LLLFLNMKEJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	private float[] NOFOHNJPMLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	private Vector4[] LJOLNILJIEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	public float[] OCMLOAAKEFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	public Texture2DArray MMKOPIFODDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	public Texture2DArray IINOGDGAFIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	public Texture2DArray IFIKEKIDBJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	public Texture2DArray LGHMPOHLKOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	private bool JMBBGJOJFEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x184")]
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	private int FCJEGCBNKMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	private Vector2? HMGCOGFCLAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x194")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	private TextureFormat DPMDNCBFJPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	private Vector2? OKDOFLCDCIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A4")]
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	private TextureFormat IDDDFHFKNHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	private Vector2? ENINMEPLMEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B4")]
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	private TextureFormat BNOAFJLHJCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	private Vector2? OOKCKJKPKOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C4")]
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	private TextureFormat JOMHNPGNDGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	private bool PCNGABNNECG;

	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	private static int IINAKMMHGPD;

	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	private static int FGDKKGMFNHC;

	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	private static int LCDLMIFONAC;

	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	private static int KNABNPOKHCL;

	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	private static int JDOMBFPNIJL;

	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	private static int HPOKGIMLANL;

	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	private static int DNOKOOOELNO;

	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	private static int ACIFCILAGPO;

	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	private static int PHFCJKEDJAF;

	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	private static int ENADGPOHOFC;

	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	private static int EFCEBCJADLL;

	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	private static int PHKNPOLGJLH;

	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	private static int MKDGOMPEMBC;

	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	private static int DBKGBHMGJEI;

	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	private static int PIJMLFPPIJJ;

	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	private static int CJBPGBHLMLB;

	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	private static int DBOOMJGLFFE;

	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	private static int JGMIIMDOLHN;

	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	private static int NFEGNLPBHBB;

	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	private static int PNILMLHGIIE;

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x685AA30", Offset = "0x6859030", VA = "0x18685AA30")]
	private MOIOBCBGMNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x685A970", Offset = "0x6858F70", VA = "0x18685A970")]
	public MOIOBCBGMNP(Color PIOALIEOIMD, Color CGKJAPLNAKC, Color JLFFJABNJNJ, Color? LKNHELBFJBP, Color? NDFKDDGOACI, Color? GOGEDIFFMLH, Texture2D PJJNCKPCAPO, Texture2D COKAOGBBGJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x68592C0", Offset = "0x68578C0", VA = "0x1868592C0")]
	internal int FKHPONNCKLG(Material BACLIMGCLBJ, GJOEFCDBKNJ MHIHIGAKEGO, HKBDNHJCEAK PDOMNFDJDNM, PAHGFPMKCPO JCPMBIEAGBM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x68593B0", Offset = "0x68579B0", VA = "0x1868593B0")]
	private int FKHPONNCKLG(CJOACIGFKAM MNBFPOFIDHA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x6859600", Offset = "0x6857C00", VA = "0x186859600")]
	internal int JGGKKAOKNEG(Material BACLIMGCLBJ, Color FJLGHDOEFAO, Color PJPDLIJOMPE, Color MEELNFCIGJF, Color AJBAHOMHEMC, Color GKALBDKDNLN, Texture2D KLCPGGMHNFM, Vector4 DIIKBGOCGAB, Texture2D HGFKBGLMLPG, Vector4 KPDHIJEPDPC, float GNENGKBPAFI, float HFFKANGEIAC, Texture2D JGDILDCBGFH, Vector4 PGJDBNDJNAE, float MKONEKOIIGC, Texture2D KCKLHLCCNIK, Color GKOJEMKMKDB, Vector4 MCELJBFDBGG, GJOEFCDBKNJ MHIHIGAKEGO, HKBDNHJCEAK PDOMNFDJDNM, PAHGFPMKCPO JCPMBIEAGBM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x6859440", Offset = "0x6857A40", VA = "0x186859440")]
	private void HKJKEKBMJNF(List<Texture2D> DEJLNBJJBNN, [Out] Texture2DArray DPACIKEPLGG, [Out] Texture2DArray BFIJBFCLPKO, [Out] Texture2DArray AAMCHGDIICO, [Out] Texture2DArray CBLADCDLOFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x685A380", Offset = "0x6858980", VA = "0x18685A380")]
	public void NLMICAPJGCO(Shader PNBHMGDFMLE, Renderer AEAIBJINKNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x6858370", Offset = "0x6856970", VA = "0x186858370")]
	private void DNGHLJPGLLL(Shader PNBHMGDFMLE, Renderer AEAIBJINKNK, int JICHBEDOBFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x68590C0", Offset = "0x68576C0", VA = "0x1868590C0")]
	private Color FGJIIJKFHMN(Color FOJPIEFLCOE, GJOEFCDBKNJ IJEJJFPFEDL)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x685A4D0", Offset = "0x6858AD0", VA = "0x18685A4D0")]
	private Color PJPHAAOLBML(Color PHDPLIFJGOH, GJOEFCDBKNJ IJEJJFPFEDL)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x685A1D0", Offset = "0x68587D0", VA = "0x18685A1D0")]
	private bool KPKJHNEPMJN(Texture2D DBJOHHEBGEP, HKBDNHJCEAK DABMDLBJBKL, [Out] Texture2D CICCBCJBDHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x685A2D0", Offset = "0x68588D0", VA = "0x18685A2D0")]
	private void NHKKPNLPACH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x6859080", Offset = "0x6857680", VA = "0x186859080", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class FIHCBHIGHJM
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private sealed class NOKBMNGNCLA : IEnumerator<FDDBCEBEBAE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		private FDDBCEBEBAE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		public JobHandle handle;

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		private FDDBCEBEBAE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0x85F4F0", Offset = "0x85DAF0", VA = "0x18085F4F0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x85F4F0", Offset = "0x85DAF0", VA = "0x18085F4F0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x864580", Offset = "0x862B80", VA = "0x180864580")]
		[DebuggerHidden]
		public NOKBMNGNCLA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0xB11100", Offset = "0xB0F700", VA = "0x180B11100", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x685B3B0", Offset = "0x68599B0", VA = "0x18685B3B0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0")]
	public static void AHNDIEAKFOH(string KAGKMEDPMHO, int FALHCGACGOI, long AOMICJAKFHA, long OGBJOPGPEOB, long EBEFCOAOIEB, long EKAIHEMBJKN, long MNEDCJMFGPE, long DACCAHNPBIH, long JJEAAAGMLGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x6855020", Offset = "0x6853620", VA = "0x186855020")]
	public static MCOHGCAFPBM DODLKFGNEFM(JobHandle BMLEDHGELDD, bool LDINGOJEINO, bool DCAJFDFKBPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x6855170", Offset = "0x6853770", VA = "0x186855170")]
	[IteratorStateMachine(typeof(NOKBMNGNCLA))]
	private static IEnumerator<FDDBCEBEBAE> IJHJBOHJDGC(JobHandle NNBIOLHDGAK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public class JHJGCNNCIMC : HEBHDJDFDPB, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	private GMLAGENPDDM FGMDHHIPJGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	private DAOLOEOHPCJ CLOLNNJFFDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	private IRecRoomQualityConfigProvider CMGKPBIDDPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	private bool GNGCAHFGDNF;

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x6857D70", Offset = "0x6856370", VA = "0x186857D70")]
	[CCEDJDOPMOE(CFIDNIINJOK.GameOnly)]
	private static void HMNFMEGJEJO(JJHPIOCMJGA CEJMOFAPBGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x5B7F8D0", Offset = "0x5B7DED0", VA = "0x185B7F8D0")]
	[UnityEngine.Scripting.Preserve]
	public JHJGCNNCIMC([JLPFJOFFNLM(null)] DAOLOEOHPCJ LNMCHAKOHAA, [JLPFJOFFNLM(null)] GMLAGENPDDM OLCDMGGIJHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x85E9E0", Offset = "0x85CFE0", VA = "0x18085E9E0", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x6858300", Offset = "0x6856900", VA = "0x186858300")]
	private void PJOFGEKLBNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x6857BE0", Offset = "0x68561E0", VA = "0x186857BE0", Slot = "4")]
	public void DPJNAAJEJEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x6857E60", Offset = "0x6856460", VA = "0x186857E60", Slot = "5")]
	public JPDJGJBEGGO<Texture2D> ILBFGFNBDDK(DLFMDPGBKAM GPBFCBABBFA, [Optional] DNHBLDMMNNO MBKNFOKFHJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x6857C40", Offset = "0x6856240", VA = "0x186857C40")]
	private uint EILLGIJNEMF(DLFMDPGBKAM GPBFCBABBFA, DNHBLDMMNNO MBKNFOKFHJD)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public interface MBIACJGCFMA
{
	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MDMMLBIOPGC(Mesh GOBEKKOCOLP, Matrix4x4 ICJCNEJJMNK, byte[] IMAKAICAGGG, bool IMOKLMECJDK = false, LIBDCJLAIAP.JPKJJHCECFA LBCIEIGLEDJ = (LIBDCJLAIAP.JPKJJHCECFA)0, int IONPKDLJCBO = -1, bool CBOJOFHPECI = false);

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JNDCNBAODLG(Allocator JKHEKCINHDP, JFKHKMCOFGG EPNKPGGDMBK, byte CFEDIPKKDLI, [Optional] IList<int> MNIJLMICPLA, [Optional] IList<int> MEGDFBDLGHD);
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public readonly struct AHPPPJJGNMJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	public readonly GameObject OCDFFLABAAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	private readonly AvatarItemMaterial PGHONNJHHKK;

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0xB912D0", Offset = "0xB8F8D0", VA = "0x180B912D0")]
	public AHPPPJJGNMJ(GameObject OCDFFLABAAF, AvatarItemMaterial PGHONNJHHKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x6852A50", Offset = "0x6851050", VA = "0x186852A50")]
	public void MMAAKMLPNIL(Material JFOAGNGANHG, int CKMGAKMKFDL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class EJLGAGCMFBL : BHFGOAJJHAJ<Task<(GameObject, AvatarItemMaterial)>, AHPPPJJGNMJ>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private struct OFDIEJNJNKJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		public AsyncTaskMethodBuilder<(GameObject, AvatarItemMaterial)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		public Task<GameObject> goTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		public Task<AvatarItemMaterial> materialTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		private GameObject <go>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		private TaskAwaiter<GameObject> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		private TaskAwaiter<AvatarItemMaterial> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x685B400", Offset = "0x6859A00", VA = "0x18685B400", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x685B900", Offset = "0x6859F00", VA = "0x18685B900", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	private JPDJGJBEGGO<GameObject> NNDPEKEJKBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	private JPDJGJBEGGO<AvatarItemMaterial> HPKNGABINEP;

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x6854F90", Offset = "0x6853590", VA = "0x186854F90")]
	private EJLGAGCMFBL(Task<(GameObject, AvatarItemMaterial)> OOOMFPPINLE, JPDJGJBEGGO<GameObject> OIJBKNNOECF, JPDJGJBEGGO<AvatarItemMaterial> NPCDLEBBLDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x6854B80", Offset = "0x6853180", VA = "0x186854B80")]
	public static EJLGAGCMFBL KKJEMJBKDLP(AssetReference GKKMENDEFNB, [Optional] AssetReference GGBCGEGAOMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x68549B0", Offset = "0x6852FB0", VA = "0x1868549B0", Slot = "11")]
	protected override AHPPPJJGNMJ CFEHEPKABBF(Task<(GameObject, AvatarItemMaterial)> PGJMIAFJKLJ)
	{
		return default(AHPPPJJGNMJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x6854930", Offset = "0x6852F30", VA = "0x186854930", Slot = "12")]
	protected override void AHBMJEGDPFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x6854A50", Offset = "0x6853050", VA = "0x186854A50")]
	[AsyncStateMachine(typeof(OFDIEJNJNKJ))]
	private static Task<(GameObject, AvatarItemMaterial)> FDJDOHNPNIM(Task<GameObject> MJHPLOCEGEB, Task<AvatarItemMaterial> JPJCNFPEPFN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class NEDEOIOOMHG
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	private class BPDDOJIEGLI : BHFGOAJJHAJ<Task<MaterialMapAsset>, Material[]>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		private JPDJGJBEGGO<MaterialMapAsset> NNBIOLHDGAK;

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x68543C0", Offset = "0x68529C0", VA = "0x1868543C0")]
		public BPDDOJIEGLI(JPDJGJBEGGO<MaterialMapAsset> NNBIOLHDGAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x6853FA0", Offset = "0x68525A0", VA = "0x186853FA0", Slot = "11")]
		protected override Material[] CFEHEPKABBF(Task<MaterialMapAsset> OOOMFPPINLE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x6853F40", Offset = "0x6852540", VA = "0x186853F40", Slot = "12")]
		protected override void AHBMJEGDPFO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	private class PECEEAOILBG : BHFGOAJJHAJ<Task<Material[]>, Material[]>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		private List<JPDJGJBEGGO<Material>> HPALBJPGOHP;

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x685BB00", Offset = "0x685A100", VA = "0x18685BB00")]
		public PECEEAOILBG(Task<Material[]> OOOMFPPINLE, List<JPDJGJBEGGO<Material>> HPALBJPGOHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x685BAB0", Offset = "0x685A0B0", VA = "0x18685BAB0", Slot = "11")]
		protected override Material[] CFEHEPKABBF(Task<Material[]> PGJMIAFJKLJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x685B970", Offset = "0x6859F70", VA = "0x18685B970", Slot = "12")]
		protected override void AHBMJEGDPFO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	private static readonly CHNLCLDOCNE CNCAEGCNGHI;

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x685AF20", Offset = "0x6859520", VA = "0x18685AF20")]
	public static JPDJGJBEGGO<Material[]> FLBNNECHCON(AssetReference[] BEHLJLIOMFB)
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
		[FOAPFLEFDGH(NABHOIFJJJN.Self, false, false, false)]
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

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x685BF20", Offset = "0x685A520", VA = "0x18685BF20")]
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
		private struct PINFNFOAMAB : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000207")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000208")]
			public AsyncTaskMethodBuilder<LJOKFJLCIAC> <>t__builder;

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
			private TaskAwaiter<LJOKFJLCIAC> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x685BB70", Offset = "0x685A170", VA = "0x18685BB70", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x685BEB0", Offset = "0x685A4B0", VA = "0x18685BEB0", Slot = "5")]
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
		private Dictionary<CIFJPJIKLJC, SymmetricalFaceFeature> eyeBrowFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		private Dictionary<CIFJPJIKLJC, EyesFaceFeature> eyeFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		private Dictionary<CIFJPJIKLJC, NoseFaceOption> noseOptionsDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		private Dictionary<CIFJPJIKLJC, FaceFeature> mouthFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		private readonly Dictionary<CIFJPJIKLJC, int> featureToIndexMap;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		private LJOKFJLCIAC _defaultFaceStyle;

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		private bool dictionariesInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0x6855A90", Offset = "0x6854090", VA = "0x186855A90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x68559B0", Offset = "0x6853FB0", VA = "0x1868559B0")]
		public LJOKFJLCIAC PAHKDKBDCNB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x6855880", Offset = "0x6853E80", VA = "0x186855880")]
		[AsyncStateMachine(typeof(PINFNFOAMAB))]
		public Task<LJOKFJLCIAC> OMDJNPFLMKL(int CFKINGPBCCM, int CEHBFCHDDBL, int KHGIGMPBGND)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x68555B0", Offset = "0x6853BB0", VA = "0x1868555B0")]
		public NoseFaceOption MNJJBLJGKFE(int PKLGBFGJMJE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x6855430", Offset = "0x6853A30", VA = "0x186855430")]
		public SelectableFaceOption FHEHLDINOEM(FaceFeatureType MIFBKNINPMA, CIFJPJIKLJC EONEMELHLNG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x68553B0", Offset = "0x68539B0", VA = "0x1868553B0")]
		public int EFPAMGLICNO(CIFJPJIKLJC EONEMELHLNG)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x6855650", Offset = "0x6853C50", VA = "0x186855650")]
		private void NNAEGFNBNFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x2B61180", Offset = "0x2B5F780", VA = "0x182B61180")]
		private void FMDLMIHDEPA<T>(IDictionary<CIFJPJIKLJC, T> LPGLBEOCAPG, IReadOnlyList<T> HEIMCLKFHKJ) where T : SelectableFaceOption
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x6855300", Offset = "0x6853900", VA = "0x186855300")]
		public CIFJPJIKLJC BAOMOEEJPEG(FaceFeatureType MIFBKNINPMA)
		{
			return default(CIFJPJIKLJC);
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x68551E0", Offset = "0x68537E0", VA = "0x1868551E0")]
		public CIFJPJIKLJC AEBDOCLLDIF(FaceFeatureType MIFBKNINPMA)
		{
			return default(CIFJPJIKLJC);
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x6855A00", Offset = "0x6854000", VA = "0x186855A00")]
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
