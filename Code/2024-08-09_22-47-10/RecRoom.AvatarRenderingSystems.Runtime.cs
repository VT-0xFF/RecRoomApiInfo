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
	public class LogRegistrationIndex : DLJCNHBICIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x67924E0", Offset = "0x67918E0", VA = "0x1867924E0", Slot = "4")]
		public override void NLGJOIAOEAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x875650", Offset = "0x874A50", VA = "0x180875650")]
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
			[Cpp2IlInjected.Address(RVA = "0x857620", Offset = "0x856A20", VA = "0x180857620", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override string AssetGUID
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x6794A40", Offset = "0x6793E40", VA = "0x186794A40", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6794970", Offset = "0x6793D70", VA = "0x186794970", Slot = "17")]
		public override bool RuntimeKeyIsValid()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6794A00", Offset = "0x6793E00", VA = "0x186794A00")]
		public RecNetCDNAssetReference(RecNetCDNKey PEDCMDADFIN)
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
			[Cpp2IlInjected.Address(RVA = "0x84D8A0", Offset = "0x84CCA0", VA = "0x18084D8A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x84D8D0", Offset = "0x84CCD0", VA = "0x18084D8D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public string CacheHash
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x8527F0", Offset = "0x851BF0", VA = "0x1808527F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x852800", Offset = "0x851C00", VA = "0x180852800")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6794A80", Offset = "0x6793E80", VA = "0x186794A80")]
		public static RecNetCDNKey GNHOBKMFHEK(string JEJNOLLFEJE, string DKDEFKLIFPH = "")
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5F82980", Offset = "0x5F81D80", VA = "0x185F82980")]
		public void KDNOCIODACH(string MHPKFLOMHAC, string KMHAFMEHDIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6794B80", Offset = "0x6793F80", VA = "0x186794B80")]
		public RecNetCDNKey()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[NIMGPLGMLPL]
public class BDMLPIMFHML : NBBFHNFBOBL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	protected readonly List<Mesh> DDOIECOIIKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	protected readonly List<byte[]> MAMFIMLGEHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	protected readonly List<Matrix4x4> BKKPNGNNPNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	protected readonly List<bool> MNBOIICDMIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	protected readonly List<int> NDLGOMBOGEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	protected readonly List<bool> GLMKHBAEPFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	protected readonly List<int> JOBOABKEBEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	protected Allocator GOHLOJEGCAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	protected ICJADOOFKCH BCKCICGILNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	protected byte GENLIHENBKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	protected IList<int> KDCKKBNIELP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	protected IList<int> BFHKLDCFMAH;

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x677DD30", Offset = "0x677D130", VA = "0x18677DD30", Slot = "4")]
	public void HBJCEBHMBFK(Mesh GFKLPJBCEPF, Matrix4x4 PKBJLHJLLKK, byte[] KJCIPADJJIC, bool ONIFLIHFDKH = false, GAGIPHDMFOM.EKBGBPNADEI HBBAANAOEGL = (GAGIPHDMFOM.EKBGBPNADEI)0, int HBFDHHLHBIF = -1, bool GBOHPFPLMPL = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x677DF40", Offset = "0x677D340", VA = "0x18677DF40", Slot = "5")]
	public void JAGHOAKDCIH(Allocator EIFDLGAHDFC, ICJADOOFKCH ELOFBBBPKNP, byte KAOBAGCNPGB, [Optional] IList<int> KBAEKMCNIPB, [Optional] IList<int> NGAJOKINGGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x677DAE0", Offset = "0x677CEE0", VA = "0x18677DAE0")]
	private static void FLBMCJJENAJ(Mesh GFKLPJBCEPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x677DF80", Offset = "0x677D380", VA = "0x18677DF80")]
	public BDMLPIMFHML()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[NIMGPLGMLPL]
public struct LDFMKIIFPEJ : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	[ReadOnly]
	public HECBEHBCCPM LKMCHGFKAFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	[ReadOnly]
	public int MOHBBMAMMMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public IDOFJIOKBLI INPIOCELPPG;

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6790640", Offset = "0x678FA40", VA = "0x186790640", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[NIMGPLGMLPL]
[NativeContainer]
public struct IDOFJIOKBLI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct AGEJOJMHDNC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public Vector3 DICONDLJEJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public Vector3 EKOLOLBNIGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public Vector4 GOFLBGENOOE;
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct HFMLADKAJMK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public float DCLCBOPOOCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public float CPFLHKKGPKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public float NOPIELGEGLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public float EJOOIFMBJLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public byte AMNKDBIOPJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public byte ECFEPBGLAAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public byte GGAHLBDLKHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public byte PCEMEMICKLE;
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct MEMNANPBGGK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public half DCLCBOPOOCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public half CPFLHKKGPKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public half NOPIELGEGLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public half EJOOIFMBJLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public byte AMNKDBIOPJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public byte ECFEPBGLAAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public byte GGAHLBDLKHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public byte PCEMEMICKLE;
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct JEFHCBNLJBF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public half4 IGDDAGDAAIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public half2 NHCANOLFNMH;
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct ENCFIGOGHLE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public half4 IGDDAGDAAIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public half2 NHCANOLFNMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public half2 MFHEOLEGIFI;
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public struct PMGKDBOEHCF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public half4 IGDDAGDAAIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public half2 NHCANOLFNMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public half2 MFHEOLEGIFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public half2 DMMCIGAOCPI;
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct JLOGFPKBFGL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public half4 IGDDAGDAAIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public half2 NHCANOLFNMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public half2 MFHEOLEGIFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public half2 DMMCIGAOCPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public half2 MLICMINAEEA;
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public struct NPIHOGOPFDO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public float DCLCBOPOOCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public float CPFLHKKGPKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public float NOPIELGEGLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public float EJOOIFMBJLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public int AMNKDBIOPJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public int ECFEPBGLAAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public int GGAHLBDLKHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public int PCEMEMICKLE;
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public struct EPELHPCIJNI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public Color IGDDAGDAAIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public Vector2 NHCANOLFNMH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public struct EGEJCGEIECO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public Color IGDDAGDAAIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public Vector2 NHCANOLFNMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public Vector2 MFHEOLEGIFI;
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public struct FGGPHBGNCFP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public Color IGDDAGDAAIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public Vector2 NHCANOLFNMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public Vector2 MFHEOLEGIFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public Vector2 DMMCIGAOCPI;
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public struct LBDNDGEGOKF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public Color IGDDAGDAAIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Vector2 NHCANOLFNMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public Vector2 MFHEOLEGIFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public Vector2 DMMCIGAOCPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Vector2 MLICMINAEEA;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private bool EHBKILJFBMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public NativeArray<AGEJOJMHDNC> IGGJCJJKLGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public NativeArray<JEFHCBNLJBF> DLDBHEDJNAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public NativeArray<ENCFIGOGHLE> IDIDBGDDOHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public NativeArray<PMGKDBOEHCF> PHNBGPDMIGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public NativeArray<JLOGFPKBFGL> LBJKAMFMINC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public NativeArray<MEMNANPBGGK> AKANNJGIDMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public NativeArray<HFMLADKAJMK> DDDCEHLJPLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public NativeArray<EPELHPCIJNI> IEABCHDJLLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public NativeArray<EGEJCGEIECO> FKCPLGJMKKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public NativeArray<FGGPHBGNCFP> AFNMKEJIOOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public NativeArray<LBDNDGEGOKF> PKDOPBLABKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public NativeArray<NPIHOGOPFDO> EFBNGJHDCIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public NativeArray<int> IMLILNNHEDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public NativeArray<int> DEAOPIAKJCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private NativeArray<int> OPKJIDFNJPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private NativeArray<int> NOACHPGEKAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public NativeArray<int> KJDMGKHIGIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public NativeArray<int> MJAAONCAEFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public NativeArray<int> PHNEBDHEEIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public NativeArray<BoneWeight> DJFJNIPEHNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private NativeArray<int> GLODDHJJLAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private bool KFOONJIIPAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x159")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private bool CHLFILHHNEE;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int FHKJKCGHLIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x678D880", Offset = "0x678CC80", VA = "0x18678D880")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x678DBE0", Offset = "0x678CFE0", VA = "0x18678DBE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int ECPPOFDHOIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x678F310", Offset = "0x678E710", VA = "0x18678F310")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x678F3A0", Offset = "0x678E7A0", VA = "0x18678F3A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int HHDHDEEBDEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x678F320", Offset = "0x678E720", VA = "0x18678F320")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x678EB20", Offset = "0x678DF20", VA = "0x18678EB20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int LIFMNGCFEPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x678F330", Offset = "0x678E730", VA = "0x18678F330")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x678FAE0", Offset = "0x678EEE0", VA = "0x18678FAE0")]
	public IDOFJIOKBLI(int BBMNGDOIKIH, int OKIGBPGAEIB, int OIGPBLANKNK, int NBDCELFHEGL, Allocator EIFDLGAHDFC, int JMAIJAHDLJB, MLBJFNJLJHD ODAENCLNAMJ, bool KFOONJIIPAH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x678D8F0", Offset = "0x678CCF0", VA = "0x18678D8F0")]
	public void DFLCDCODGKE(int AGAGKNBDCIG, Vector3 LMJDILMPEPB, Vector3 DMNNLPDGIGJ, Vector4 JILAKCNFFBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x678EB30", Offset = "0x678DF30", VA = "0x18678EB30")]
	public void JANFGNLCJBL(int AGAGKNBDCIG, BoneWeight MPHNKKEBPGA, NativeSlice<byte> KJCIPADJJIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x678F3B0", Offset = "0x678E7B0", VA = "0x18678F3B0")]
	public Color OKFLGKKMJHG(int AGAGKNBDCIG)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x678F6E0", Offset = "0x678EAE0", VA = "0x18678F6E0")]
	public void PPOOEJBIHGJ(int AGAGKNBDCIG, Color HHIGDOHOLEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x678EF60", Offset = "0x678E360", VA = "0x18678EF60")]
	public void JCCGJBKLDAK(byte LAGIOKBKBMB, int AGAGKNBDCIG, Vector2 HPBLGJLGFAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x678EB10", Offset = "0x678DF10", VA = "0x18678EB10")]
	public void GJIHGKINBIJ(int AGAGKNBDCIG, int HGHNPOJIEAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x678D890", Offset = "0x678CC90", VA = "0x18678D890")]
	public bool COHNDDCIIGM(int LAGIOKBKBMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x678D7B0", Offset = "0x678CBB0", VA = "0x18678D7B0")]
	public void BEKDEDINMFK(int KJIGLBLGECK, int BILMLHHHLMM, int CHJNEOPKHME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x678D980", Offset = "0x678CD80", VA = "0x18678D980", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x678DBF0", Offset = "0x678CFF0", VA = "0x18678DBF0")]
	public Mesh FEMBDCBNPMJ([Optional] string AFJGFPMGFOJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[NativeContainer]
[NIMGPLGMLPL]
[DefaultMember("Item")]
public struct HECBEHBCCPM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public Mesh.MeshDataArray HPNLJAPLGPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public NativeArray<int> FPAGEGNAPEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public NativeArray<int> DALPMGGDMPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public NativeArray<BoneWeight> DJFJNIPEHNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private NativeArray<Matrix4x4> MJAKJDGBFOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private NativeArray<int> DOLECNENCON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private NativeArray<byte> ICINLDGHAIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private NativeArray<int> NEABIDHDOEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private NativeArray<int> IBABPDJLIHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public NativeArray<sbyte> ACIFPALKEOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public NativeArray<byte> JEEEMHBKGJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public NativeArray<bool> GBOHPFPLMPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public NativeArray<int> HBFDHHLHBIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private bool KFOONJIIPAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private NativeArray<int> HCCFDENHFCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private bool CHLFILHHNEE;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public int NIACGEHODMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x678C200", Offset = "0x678B600", VA = "0x18678C200")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int EJJAOGECFMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x678C590", Offset = "0x678B990", VA = "0x18678C590")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int PHEANAPGKHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x678BFB0", Offset = "0x678B3B0", VA = "0x18678BFB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int GPAEMEFDLEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x678C550", Offset = "0x678B950", VA = "0x18678C550")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x678C570", Offset = "0x678B970", VA = "0x18678C570")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int FHKJKCGHLIO
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x678BF90", Offset = "0x678B390", VA = "0x18678BF90")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x678C1F0", Offset = "0x678B5F0", VA = "0x18678C1F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int DMLBADJOKNM
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x678C5A0", Offset = "0x678B9A0", VA = "0x18678C5A0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x678C560", Offset = "0x678B960", VA = "0x18678C560")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public ICJADOOFKCH KDJPAAAJLEI
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x678C210", Offset = "0x678B610", VA = "0x18678C210")]
		get
		{
			return default(ICJADOOFKCH);
		}
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x678C580", Offset = "0x678B980", VA = "0x18678C580")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public byte HOIOPPPMKOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x678BFA0", Offset = "0x678B3A0", VA = "0x18678BFA0")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x678C220", Offset = "0x678B620", VA = "0x18678C220")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public ECDMNGMGNLG OKOJIGDPPIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x678C230", Offset = "0x678B630", VA = "0x18678C230")]
		get
		{
			return default(ECDMNGMGNLG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x678C5B0", Offset = "0x678B9B0", VA = "0x18678C5B0")]
	public HECBEHBCCPM(IList<Mesh> KOKOMEOODDI, IList<Matrix4x4> AMGLMBAKHKG, IList<bool> GBOHPFPLMPL, byte KAOBAGCNPGB, IList<byte[]> LNMAIOINAKK, IList<int> AADGFOCDNDE, IList<bool> HGAMDHIOIOE, IList<int> HBFDHHLHBIF, IList<int> KBAEKMCNIPB, IList<int> KPEKDFAIFKO, Allocator EIFDLGAHDFC, ICJADOOFKCH ELOFBBBPKNP, bool KFOONJIIPAH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x678C480", Offset = "0x678B880", VA = "0x18678C480")]
	public IDOFJIOKBLI HPPIHHILIPC(Allocator EIFDLGAHDFC, MLBJFNJLJHD ODAENCLNAMJ)
	{
		return default(IDOFJIOKBLI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x678C080", Offset = "0x678B480", VA = "0x18678C080", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[NIMGPLGMLPL]
public class BOICNPHKNDP : BDMLPIMFHML
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public bool INDDCIEPAAO;

	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private static readonly ProfilerMarker JGNGNMHBCCF;

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x677E3F0", Offset = "0x677D7F0", VA = "0x18677E3F0")]
	public HECBEHBCCPM HIHDABEPNLF()
	{
		return default(HECBEHBCCPM);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x677E6B0", Offset = "0x677DAB0", VA = "0x18677E6B0")]
	public BOICNPHKNDP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct ECDMNGMGNLG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public Mesh.MeshData ACGMICEJGCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public NativeSlice<BoneWeight> DJFJNIPEHNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public NativeSlice<byte> GKODPMIEKEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public int FPCAHPMDEMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public Matrix4x4 HDMHGMMJCJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public int EDJPIHDBCHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public NativeSlice<byte> KJCIPADJJIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public bool MBEDBOJCJOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public int KOJJDIMLAON;
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class GNHNIHPGAII : DJPJDDCJGDP
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	private abstract class FPKIACLDBGE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public readonly EPOJMBFGCMA IDDLHOPAABA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		protected bool PBPCHGCFFFF;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public virtual bool MLOCAJFGEON
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x894960", Offset = "0x893D60", VA = "0x180894960", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public virtual bool FMGHEEGJKCG
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x894960", Offset = "0x893D60", VA = "0x180894960", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public virtual GAGIPHDMFOM.EKBGBPNADEI EDJPIHDBCHH
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x84C230", Offset = "0x84B630", VA = "0x18084C230", Slot = "6")]
			get
			{
				return default(GAGIPHDMFOM.EKBGBPNADEI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public bool ADOKJINMDKC
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x9F3850", Offset = "0x9F2C50", VA = "0x1809F3850")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public bool JBDCFNKKAFN
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x15B1E00", Offset = "0x15B1200", VA = "0x1815B1E00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public bool DCJNINKGBNI
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x677FD60", Offset = "0x677F160", VA = "0x18677FD60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public bool IPIAHABKFLG
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x677FD70", Offset = "0x677F170", VA = "0x18677FD70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x8527C0", Offset = "0x851BC0", VA = "0x1808527C0")]
		protected FPKIACLDBGE(EPOJMBFGCMA FEFEPIDHDMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract FFCFPAFMHJP EPEKFFHBPJO(int[] OKAMBHKEIDC, List<AAJBDCMNIBJ> HEHCCPALJPH, List<AAJBDCMNIBJ> DKONGOKOKAB);

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract ICFJLMPAGGH FIECEGMDAPC(uint DDIIAJHFBBE, AvatarSkinnedMeshBoneOrderRemapsData HDHIOINDDLB);
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	private class FEBJNFCANMN : FPKIACLDBGE
	{
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		[CompilerGenerated]
		private sealed class LGHJCEJECOE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000E1")]
			public LEENANICOKB<GameObject> skinAvatarItemPrefabHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000E2")]
			public FEBJNFCANMN <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
			public LGHJCEJECOE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x67920F0", Offset = "0x67914F0", VA = "0x1867920F0")]
			internal void INOKGEOFCKB(GameObject result)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private readonly AvatarSkinAssetItem.JPODIGMNLIO LBGBNLCCPEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private readonly AssetReference OFABPKPGGMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		private readonly GAGIPHDMFOM.EKBGBPNADEI PGLHLKHGFMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private readonly NNBLNMLCNGB? KBHNJCFOBDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private readonly Material[] MCNHPMJDFMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private SkinnedMeshRenderer[] KOPOKHLKBKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private AvatarSkinAssetItem PINEKONBEEK;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override GAGIPHDMFOM.EKBGBPNADEI EDJPIHDBCHH
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x84D8E0", Offset = "0x84CCE0", VA = "0x18084D8E0", Slot = "6")]
			get
			{
				return default(GAGIPHDMFOM.EKBGBPNADEI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x677EF40", Offset = "0x677E340", VA = "0x18677EF40")]
		public FEBJNFCANMN(AvatarSkinAssetItem.JPODIGMNLIO BPPIGMMOGIM, AssetReference BAIHJOCMHAH, Material FHNBBMGCKGG, EPOJMBFGCMA CBBPPBKJBOP, GAGIPHDMFOM.EKBGBPNADEI FIAIJKHGDEF = (GAGIPHDMFOM.EKBGBPNADEI)0, [Optional] NNBLNMLCNGB? NHEIMAEBLAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x677EE30", Offset = "0x677E230", VA = "0x18677EE30")]
		public FEBJNFCANMN(AvatarSkinAssetItem.JPODIGMNLIO BPPIGMMOGIM, AssetReference BAIHJOCMHAH, Material FHNBBMGCKGG, GAGIPHDMFOM.EKBGBPNADEI FIAIJKHGDEF = (GAGIPHDMFOM.EKBGBPNADEI)0, [Optional] NNBLNMLCNGB? NHEIMAEBLAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x677E910", Offset = "0x677DD10", VA = "0x18677E910", Slot = "7")]
		public override FFCFPAFMHJP EPEKFFHBPJO(int[] OKAMBHKEIDC, List<AAJBDCMNIBJ> HEHCCPALJPH, List<AAJBDCMNIBJ> DKONGOKOKAB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x677EAE0", Offset = "0x677DEE0", VA = "0x18677EAE0", Slot = "8")]
		public override ICFJLMPAGGH FIECEGMDAPC(uint DDIIAJHFBBE, AvatarSkinnedMeshBoneOrderRemapsData HDHIOINDDLB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x677EDC0", Offset = "0x677E1C0", VA = "0x18677EDC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	private class FJIAPKGBPCJ : FPKIACLDBGE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public readonly JLLBFADABDE LAOGMEAJLLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private LEENANICOKB<COJNOJJJGMH> LKMFMGDHIOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public COJNOJJJGMH KKEDIGKLHCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private LEENANICOKB<Material[]> FFFFDAPELKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public Material[] BFCBCMCAIKC;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public override bool MLOCAJFGEON
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x8665B0", Offset = "0x8659B0", VA = "0x1808665B0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override bool FMGHEEGJKCG
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x677FC50", Offset = "0x677F050", VA = "0x18677FC50", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x677FD00", Offset = "0x677F100", VA = "0x18677FD00")]
		public FJIAPKGBPCJ(EPOJMBFGCMA FEFEPIDHDMA, JLLBFADABDE NBJCADGBLCB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x677F260", Offset = "0x677E660", VA = "0x18677F260", Slot = "7")]
		public override FFCFPAFMHJP EPEKFFHBPJO(int[] OKAMBHKEIDC, List<AAJBDCMNIBJ> HEHCCPALJPH, List<AAJBDCMNIBJ> DKONGOKOKAB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x677F6F0", Offset = "0x677EAF0", VA = "0x18677F6F0", Slot = "8")]
		public override ICFJLMPAGGH FIECEGMDAPC(uint DDIIAJHFBBE, AvatarSkinnedMeshBoneOrderRemapsData HDHIOINDDLB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x677F050", Offset = "0x677E450", VA = "0x18677F050")]
		public ICFJLMPAGGH DGFLMAFGFBJ(GameObject HFLJABFFMMG, uint DDIIAJHFBBE, bool KGNNAFNNMAD, bool BDAMGIODDDN, AvatarSkinnedMeshBoneOrderRemapsData HDHIOINDDLB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x677F820", Offset = "0x677EC20", VA = "0x18677F820")]
		public static bool IIBHGJNLLNJ(Renderer[] BHEJEKHNEBF, string ACKFAKMKIAA, [Out] Renderer KLMFBEGGNFB, [Out] Renderer FLDNGFKDPJO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x677FCB0", Offset = "0x677F0B0", VA = "0x18677FCB0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x677FB90", Offset = "0x677EF90", VA = "0x18677FB90")]
		private (LEENANICOKB<COJNOJJJGMH>, LEENANICOKB<Material[]>) NAOOAPCIHDE()
		{
			return default((LEENANICOKB<COJNOJJJGMH>, LEENANICOKB<Material[]>));
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x4278430", Offset = "0x4277830", VA = "0x184278430")]
		[CompilerGenerated]
		private void ONBOGEDDJDM(COJNOJJJGMH LLANANCGECL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x8541D0", Offset = "0x8535D0", VA = "0x1808541D0")]
		[CompilerGenerated]
		private void ILANGNPONKJ(Material[] LLANANCGECL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class DFDIIMFHGKO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public DBNDCIJFKKN avatarBuildParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public GNHNIHPGAII <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public FCIMHBPMHFO buildMeshPromise;

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
		public DFDIIMFHGKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x677E6E0", Offset = "0x677DAE0", VA = "0x18677E6E0")]
		internal bool HAJPFNGCLNM(JLLBFADABDE item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x677E7C0", Offset = "0x677DBC0", VA = "0x18677E7C0")]
		internal void JOLAKHNJDFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x677E6C0", Offset = "0x677DAC0", VA = "0x18677E6C0")]
		internal void CDMGHKJMMEM(string err)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x677E7E0", Offset = "0x677DBE0", VA = "0x18677E7E0")]
		internal void PHJAHDDDHPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x677E730", Offset = "0x677DB30", VA = "0x18677E730")]
		internal void IGECJOLGKCB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x84D8A0", Offset = "0x84CCA0", VA = "0x18084D8A0")]
		internal FFCFPAFMHJP IDJHGBHNDEF()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class HBIIOENMBJB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public int lowestPossibleLOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public DFDIIMFHGKO CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
		public HBIIOENMBJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x678BED0", Offset = "0x678B2D0", VA = "0x18678BED0")]
		internal LICGHJMHIAG LGODEEOJHFC(int lod)
		{
			return default(LICGHJMHIAG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class KABFGFLJIFA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public List<FCIMHBPMHFO> innerPromises;

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
		public KABFGFLJIFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x6790510", Offset = "0x678F910", VA = "0x186790510")]
		internal void MIEBEKMBJCC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class AHKOICDJJMN : IEnumerator<PKLKPEJFEBK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private PKLKPEJFEBK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public GNHNIHPGAII <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public List<FPKIACLDBGE> parts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public int[] LODs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public List<FCIMHBPMHFO> innerPromises;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public bool isFirstPerson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public Func<int, LICGHJMHIAG> getLayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public KAPLCENLDMN materialPropertyBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public Material materialInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private int <lodIndex>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		private PKLKPEJFEBK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x84D900", Offset = "0x84CD00", VA = "0x18084D900", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x84D900", Offset = "0x84CD00", VA = "0x18084D900", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x8527C0", Offset = "0x851BC0", VA = "0x1808527C0")]
		[DebuggerHidden]
		public AHKOICDJJMN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x677D400", Offset = "0x677C800", VA = "0x18677D400", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x677D600", Offset = "0x677CA00", VA = "0x18677D600", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class DNDMOKJLFEM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public int[] LODs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public GNHNIHPGAII <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
		public DNDMOKJLFEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x677E8C0", Offset = "0x677DCC0", VA = "0x18677E8C0")]
		internal FFCFPAFMHJP IKGNDODBOAJ(FPKIACLDBGE p)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class FLJFPMMANCK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public BNLJAFHHJEE cancelable;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
		public FLJFPMMANCK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x8A35E0", Offset = "0x8A29E0", VA = "0x1808A35E0")]
		internal void BAEJBNBIMFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0xB02910", Offset = "0xB01D10", VA = "0x180B02910")]
		internal void HJCFPKBFPNN(string err)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class ILFIOANJNDH
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
		public GNHNIHPGAII <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
		public ILFIOANJNDH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class OOOOAMAFKMJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public bool waitingForComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public JobHandle lodBuildJobHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public IDOFJIOKBLI defaultMeshJobContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public HECBEHBCCPM defaultAvatarMeshJobGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public ILFIOANJNDH CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
		public OOOOAMAFKMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x67925F0", Offset = "0x67919F0", VA = "0x1867925F0")]
		internal void IJFEIBNKDOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0xB0C930", Offset = "0xB0BD30", VA = "0x180B0C930")]
		internal void IEMHNOGIKHF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class BMKOADMKINO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public bool waitingForComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public JobHandle lodBuildJobHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public EAOPPDHCNGB legacyMeshJobContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public BAPADEBDJGL legacyAvatarMeshJobGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public ILFIOANJNDH CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
		public BMKOADMKINO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x677E1B0", Offset = "0x677D5B0", VA = "0x18677E1B0")]
		internal void NLDBEHKFGEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0xB05150", Offset = "0xB04550", VA = "0x180B05150")]
		internal void IKDKNBJGBPB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private sealed class AKKHGHKPCLL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public KeyValuePair<string, JLLBFADABDE> entry;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public BNLJAFHHJEE cancelablePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public JLLBFADABDE avatarItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public GNHNIHPGAII <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
		public AKKHGHKPCLL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x677D690", Offset = "0x677CA90", VA = "0x18677D690")]
		internal FFCFPAFMHJP PKNALGIMCEH(POPLCJGIGAJ item)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x677D650", Offset = "0x677CA50", VA = "0x18677D650")]
		internal void PDKPBCMBLKB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class DGLIOEHDDOO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public LEENANICOKB<Texture2D> resourceHandle;

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
		public DGLIOEHDDOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x677E870", Offset = "0x677DC70", VA = "0x18677E870")]
		internal void CGBMNAJNOPK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class OEHKCINAFLB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public string overrideItemIdentifier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		public EPOJMBFGCMA overrideBodyPart;

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
		public OEHKCINAFLB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x6792570", Offset = "0x6791970", VA = "0x186792570")]
		internal bool HLGAPOFDBGE(KeyValuePair<string, JLLBFADABDE> entry)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private AvatarConfiguration CCNOIPCHMLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private Transform BHPMGGLNPBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private AssetReference OFABPKPGGMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private GameObject JMECPGBABCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private GameObject OMJCKAMILFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private SkinnedMeshRenderer PGOJDJLGEJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private AvatarSkinnedMeshBoneOrderRemapsData FBAOOGDLFDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private Transform[] ALDNFBFKHCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private Matrix4x4[] EKMOIBPCKCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private Material ELOHCEBEGKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private Material BECFIDOKAEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private Material DMOPPBCJKBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private Shader MLICACNIINE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private Shader COLHCHPGDJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private Animator NCFPKPCIKGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private Renderer[] DPKDCMOLEKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private GAGIPHDMFOM.EKBGBPNADEI OGKLPCJBBBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private AvatarBodyPartShapesManager BILBKKPLPII;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private IReadOnlyDictionary<string, Transform> NMOECJAHKIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private AvatarFaceShapeData.JFEMBCNEGBN AFKEFHFFDLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private AvatarBodyShapeData.JCJGKIGIMPB EIIMAENFDFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private bool LPPMFNMEOKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB1")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private bool MFDIPFMDHEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private Color EKFKEGCEOCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private Color KFBMOCDABDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private Color KJOADDNGMLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private Color? CJGKGFJIJDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private Color? MPPINPFNPIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10C")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private Color? MJACHALJNHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private Color? LEEGKPFNCJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private Texture2D DJNLEMNDONC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private Texture2D LJHCLCIKEDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	[CanBeNull]
	private JLLBFADABDE FAANJAKHIFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private Texture PBIHEIBLOHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private Color NBEMFHLINJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public Dictionary<Renderer, KAPLCENLDMN> JFLKPNOEAMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private Dictionary<Renderer, KAPLCENLDMN> HNNLCMLFPAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private Dictionary<string, List<DHDACKKCKPC>> MIMDJAHOMEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private Dictionary<string, List<DHDACKKCKPC>> AIHKMBHKGCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private readonly List<AAJBDCMNIBJ> HDHJMCCOJLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private readonly List<AAJBDCMNIBJ> HBFMJEEEJBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly List<AAJBDCMNIBJ> AKGHOPDDPHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private readonly List<AAJBDCMNIBJ> HIAJKLJGHMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private Dictionary<DHDACKKCKPC, Material> AALCOODFGNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private Dictionary<DHDACKKCKPC, Material> GHAHFEBIPOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private SkinnedMeshRenderer[] LOABEDMJJGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private SkinnedMeshRenderer[] CAEHKAKEFAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private SkinnedMeshRenderer[] CGEGBMBAEBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private SkinnedMeshRenderer[] FGFEBOCGHKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private readonly Dictionary<string, LEENANICOKB<Texture2D>> BOEALBOIJME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private readonly Dictionary<string, LEENANICOKB<Texture2D>> GAIOHNDOIMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private AdditionalHatData ECGMOFBNNPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private HKJKDJMCLJK FOMGCIGAJBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private FitMeshHemisphere JKMKPKKDEED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private PositionAndRotation ALAIOMDDDDI;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private Material KDGOMHLNIDE;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private Material ILEMGJCNIND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private Dictionary<string, JLLBFADABDE> IKEANLIBIPL;

	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private static readonly int PIBBNJJBIPH;

	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private static readonly int LKCAIGCEOEN;

	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private static readonly int KJBKANNBCDP;

	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private static readonly int HELKJBJJNBH;

	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private static readonly int EHIBFOEELNP;

	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private static readonly int OIJINCAGGDN;

	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private static readonly int OHPLEMKFPHJ;

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private static readonly int NCEHOLEIOOF;

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private static readonly int IMBKKLCPCIC;

	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private static readonly int KDHIPAHPJKM;

	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private static readonly int CLDKDDEBGJK;

	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private static readonly int CGNFBMHDGFF;

	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private static readonly int BHPMOKIIOGC;

	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private static readonly int EACHIFAIMMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private readonly IDDBOOGKPOH KKGEECGNBNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private readonly IDDBOOGKPOH AKBGNFMAEPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private bool NDIGEDALLOP;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private static Lazy<FACPJOPGGAA> EPCEOLGCCKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private Lazy<BFFDNJILNKK> IPPEMKCNMON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private Lazy<CHBMJHGCEHK> FNJMJKDILPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private COGJHCPAIGF IELKOFIOEDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private List<Action> KLJJCBOFADD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private JIHJOGGPCJB BLKMJBKAFKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private SkinnedMeshRenderer[] PADNLAGHHCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private int IJCHPHDJMEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x284")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private bool CNNIGMFPOOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private int OBDOALPDEHN;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool ABHAGMAGCJG
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xA80120", Offset = "0xA7F520", VA = "0x180A80120")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0xA7FFC0", Offset = "0xA7F3C0", VA = "0x180A7FFC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private Material ACELEFEOHCA
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x67845A0", Offset = "0x67839A0", VA = "0x1867845A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private Material EDGNAIENAID
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x6784090", Offset = "0x6783490", VA = "0x186784090")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private bool KLKCKFFGGFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8665B0", Offset = "0x8659B0", VA = "0x1808665B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public DBODHIJMFKE CCFMEPIOLNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x9A10D0", Offset = "0x9A04D0", VA = "0x1809A10D0", Slot = "21")]
		get
		{
			return default(DBODHIJMFKE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	private static FACPJOPGGAA DGMAEGODNIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x678A290", Offset = "0x6789690", VA = "0x18678A290")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	private BFFDNJILNKK ONIDJLPCBPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x6787B80", Offset = "0x6786F80", VA = "0x186787B80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private CHBMJHGCEHK DHKGEODKPJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6781460", Offset = "0x6780860", VA = "0x186781460")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	private COGJHCPAIGF OCFGGAKEPEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x67809E0", Offset = "0x677FDE0", VA = "0x1867809E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public IDDBOOGKPOH NIKLFMFCFLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xC65E20", Offset = "0xC65220", VA = "0x180C65E20", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public IDDBOOGKPOH DJPCPJDGKBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xA80890", Offset = "0xA7FC90", VA = "0x180A80890", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public SkinnedMeshRenderer[] MOLKLNOLGME
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x14CCCB0", Offset = "0x14CC0B0", VA = "0x1814CCCB0", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public Renderer[] EJILBODDHCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x855F10", Offset = "0x855310", VA = "0x180855F10", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool PHPGMDPKFDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6788AE0", Offset = "0x6787EE0", VA = "0x186788AE0", Slot = "20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public PositionAndRotation LLILLPKIEJD
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x67853F0", Offset = "0x67847F0", VA = "0x1867853F0", Slot = "27")]
		get
		{
			return default(PositionAndRotation);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public GAGIPHDMFOM.EKBGBPNADEI NNHKCAFKLAO
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x855FC0", Offset = "0x8553C0", VA = "0x180855FC0", Slot = "18")]
		get
		{
			return default(GAGIPHDMFOM.EKBGBPNADEI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public int LGNLIHOBBAF
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x2255040", Offset = "0x2254440", VA = "0x182255040")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6783180", Offset = "0x6782580", VA = "0x186783180")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	private bool IJHNHNPDAAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x67822A0", Offset = "0x67816A0", VA = "0x1867822A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private static bool KEKMMPCCMFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6784180", Offset = "0x6783580", VA = "0x186784180")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x678B700", Offset = "0x678AB00", VA = "0x18678B700")]
	public GNHNIHPGAII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x67884B0", Offset = "0x67878B0", VA = "0x1867884B0", Slot = "28")]
	public void MGIGIPLLEKC(IPIMOJAFBJN JMKHHNCNODF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x678B2A0", Offset = "0x678A6A0", VA = "0x18678B2A0", Slot = "29")]
	public void PMFOGEPMGPC(OLBIDEIKGOD FPOMDJCLIJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x6783180", Offset = "0x6782580", VA = "0x186783180", Slot = "4")]
	public void FFDKKANCBIP(int DDIIAJHFBBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x678ADC0", Offset = "0x678A1C0", VA = "0x18678ADC0", Slot = "9")]
	public void OOHKCOHEAGG(EEJEIIHELMG FAHOFPBLFHO, Texture2D LPJKOFKCGGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6787B00", Offset = "0x6786F00", VA = "0x186787B00", Slot = "10")]
	public void KAENBIBKPJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6785270", Offset = "0x6784670", VA = "0x186785270", Slot = "11")]
	public bool ILOALLEDIGB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6785450", Offset = "0x6784850", VA = "0x186785450", Slot = "8")]
	public void JDMOONJGEKB(HCOKPGCFMAO KBECHBLJMAC, Color? IGDDAGDAAIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x678A340", Offset = "0x6789740", VA = "0x18678A340")]
	private void OKKLLNMKLOP(Action LGALBHCDFIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x67880E0", Offset = "0x67874E0", VA = "0x1867880E0", Slot = "5")]
	public void LLDFDAONEAP(JLLBFADABDE GDLJKJIHHNG, Texture CHMDCLFHKBC, Color MGDKFOIKAPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0xA7FFC0", Offset = "0xA7F3C0", VA = "0x180A7FFC0", Slot = "6")]
	public void JAHJEMJKMNJ(bool MAOIKJJOCCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0xBE13E0", Offset = "0xBE07E0", VA = "0x180BE13E0", Slot = "7")]
	public void PCLFHFMALBK(JIHJOGGPCJB GLODDHJJLAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6788C50", Offset = "0x6788050", VA = "0x186788C50", Slot = "14")]
	public FCIMHBPMHFO NHOJLEFDNBD(DBNDCIJFKKN ELOLBBBCNFD, bool LIKIFNBCLHC, int[] DMKICCFLCHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x6781BD0", Offset = "0x6780FD0", VA = "0x186781BD0", Slot = "15")]
	public void EGPPFONICEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x67848F0", Offset = "0x6783CF0", VA = "0x1867848F0", Slot = "26")]
	public void IHKHLEAONBB([Optional] HKJKDJMCLJK LAAJMMOKPBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6788340", Offset = "0x6787740", VA = "0x186788340")]
	private bool MEDKLOJHHDN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6787E90", Offset = "0x6787290", VA = "0x186787E90", Slot = "19")]
	public bool LJJNAHJLINE(GAGIPHDMFOM.EKBGBPNADEI GMINEGIMBEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x67850F0", Offset = "0x67844F0", VA = "0x1867850F0")]
	private bool IJDMNEKAOGL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6782320", Offset = "0x6781720", VA = "0x186782320")]
	private FCIMHBPMHFO EOAJKHJFCMO(bool LIKIFNBCLHC, List<FPKIACLDBGE> DBDKKAKACOK, int[] DMKICCFLCHC, Func<int, LICGHJMHIAG> CENPOBHEBCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6780590", Offset = "0x677F990", VA = "0x186780590")]
	[IteratorStateMachine(typeof(AHKOICDJJMN))]
	private IEnumerator<PKLKPEJFEBK> AMJNLDGCCMF(bool LIKIFNBCLHC, List<FPKIACLDBGE> DBDKKAKACOK, int[] DMKICCFLCHC, Func<int, LICGHJMHIAG> CENPOBHEBCF, KAPLCENLDMN GMHBLNBDCNO, Material MEBPFJILBOA, List<FCIMHBPMHFO> BKJEEJHDJPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x67817B0", Offset = "0x6780BB0", VA = "0x1867817B0")]
	private FCIMHBPMHFO EAFADADJGNE(List<FPKIACLDBGE> DBDKKAKACOK, int[] DMKICCFLCHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x67858E0", Offset = "0x6784CE0", VA = "0x1867858E0")]
	private DAODDLKDJDG JGMNGKIGMHB(List<FPKIACLDBGE> DBDKKAKACOK, int DDIIAJHFBBE, bool LIKIFNBCLHC, LICGHJMHIAG OMHGPEMHKCO, bool HOPHJNMFNJN, KAPLCENLDMN GMHBLNBDCNO, Material MEBPFJILBOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6783EB0", Offset = "0x67832B0", VA = "0x186783EB0", Slot = "22")]
	public void GOJEGJAHBMG(AvatarFaceShape HNNABHFKBCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x67851B0", Offset = "0x67845B0", VA = "0x1867851B0", Slot = "23")]
	public void IKBHPACMHIB(AvatarBodyShape LBCEEGLACPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6781550", Offset = "0x6780950", VA = "0x186781550", Slot = "25")]
	public void DCNKECIAACC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6787BD0", Offset = "0x6786FD0", VA = "0x186787BD0", Slot = "24")]
	public void KGINCKMBDFP(bool IMOHINJPIAO, bool OFOBAGFEPCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6788790", Offset = "0x6787B90", VA = "0x186788790")]
	private void MJCFDIPBLAB(SkinnedMeshRenderer NOCPADGMFHE, int DDIIAJHFBBE, Mesh GFKLPJBCEPF, List<Material> MAPDGOIABAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6781650", Offset = "0x6780A50", VA = "0x186781650")]
	private static Material DMNDDFMOCCN(Dictionary<DHDACKKCKPC, Material> LIPJDPIMNJH, Material HMAKICIFGNA, FKHGIMLBPNH LIFGJKDMPPF, DOGPPKACJCI PACPDHCMPJA, EPOJMBFGCMA CBBPPBKJBOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6788150", Offset = "0x6787550", VA = "0x186788150")]
	private static FKHGIMLBPNH LNNLIONAHHA(FPKIACLDBGE GNJKKEICJME, int FPFHDOPGCFK)
	{
		return default(FKHGIMLBPNH);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6780180", Offset = "0x677F580", VA = "0x186780180")]
	private void AGFCEAFHIFI(int AODCLDOHEBI, Material JOFMGPCHADM, FPKIACLDBGE GNJKKEICJME, [Out] Texture2D BKLILDHFJKK, [Out] Vector4 MJKLAKPKKPN, [Out] Texture2D PAJJHLNMGPI, [Out] Texture2D LJHAIODFIOE, [Out] Texture2D EMILEDBPPJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x67839D0", Offset = "0x6782DD0", VA = "0x1867839D0")]
	private void GKENECAOOGJ(int AODCLDOHEBI, Material JOFMGPCHADM, FPKIACLDBGE GNJKKEICJME, [Out] Color AJFKMCACAOP, [Out] Color EJKFGIHMGHD, [Out] Color CPJNOMBMEIG, [Out] Color PJBIBIFCCMA, [Out] Color CNEBCBLGBOI, [Out] Color PGBKNALLEAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6781200", Offset = "0x6780600", VA = "0x186781200")]
	private bool BPCEMFFAEKE(Material JOFMGPCHADM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6787E40", Offset = "0x6787240", VA = "0x186787E40")]
	private static Material LJJACGLNDEO(int AODCLDOHEBI, FJIAPKGBPCJ GNJKKEICJME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x67838E0", Offset = "0x6782CE0", VA = "0x1867838E0")]
	private static DOGPPKACJCI GEFMJJOJMHK(FPKIACLDBGE GNJKKEICJME, int FPFHDOPGCFK)
	{
		return default(DOGPPKACJCI);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x67831A0", Offset = "0x67825A0", VA = "0x1867831A0")]
	private static void FFIMFFMNIAA(Dictionary<string, List<DHDACKKCKPC>> DBKGMGAJNAJ, FPKIACLDBGE PLOHDEBLPAE, Material HMAKICIFGNA, FKHGIMLBPNH KBECHBLJMAC, DOGPPKACJCI FAHOFPBLFHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6787EB0", Offset = "0x67872B0", VA = "0x186787EB0")]
	private static SkinnedMeshRenderer LJLFGCMMFDO(Transform BMNIIAKCKGB, Transform MEFGDNGONKK, SkinnedMeshRenderer[] BHEJEKHNEBF, int DDIIAJHFBBE, LICGHJMHIAG OMHGPEMHKCO, bool LIKIFNBCLHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6783670", Offset = "0x6782A70", VA = "0x186783670")]
	private void FPBHIHGIPEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6782C90", Offset = "0x6782090", VA = "0x186782C90")]
	private void FCLPGABKFKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x67875D0", Offset = "0x67869D0", VA = "0x1867875D0")]
	private static void JIPHCEHKNGA(Dictionary<DHDACKKCKPC, Material> LIPJDPIMNJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6784440", Offset = "0x6783840", VA = "0x186784440")]
	private static void HKBPAKKOPEB(Dictionary<Renderer, KAPLCENLDMN> ONLFKLICLND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6783F70", Offset = "0x6783370", VA = "0x186783F70")]
	private void GPJDOIGNOEH(SkinnedMeshRenderer[] BHEJEKHNEBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x67847C0", Offset = "0x6783BC0", VA = "0x1867847C0")]
	private void IGMHLCPHEED(SkinnedMeshRenderer KELIGFNCHNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6788900", Offset = "0x6787D00", VA = "0x186788900")]
	private void MNNNIMDIJOE(List<AAJBDCMNIBJ> FHCPCFJHBPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x678A580", Offset = "0x6789980", VA = "0x18678A580")]
	private void OMGGLBBKIIO(Dictionary<string, LEENANICOKB<Texture2D>> DBKGMGAJNAJ, bool KEFNKHEEIJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6780A60", Offset = "0x677FE60", VA = "0x186780A60")]
	private void BBCPIMLIHLK(Dictionary<string, List<DHDACKKCKPC>> DBKGMGAJNAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6781A70", Offset = "0x6780E70", VA = "0x186781A70")]
	private void EFDBAFIBJLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x678B080", Offset = "0x678A480", VA = "0x18678B080")]
	private void PDMOCNFKKMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x678A700", Offset = "0x6789B00", VA = "0x18678A700")]
	private void OMPLILFAMFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6787CE0", Offset = "0x67870E0", VA = "0x186787CE0")]
	private void LFAHPIDPIBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6784320", Offset = "0x6783720", VA = "0x186784320")]
	private void HDFMIILHDAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6783520", Offset = "0x6782920", VA = "0x186783520")]
	private void FNNELDOAOLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6787C10", Offset = "0x6787010", VA = "0x186787C10")]
	private void LBPOAOEBIIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6783840", Offset = "0x6782C40", VA = "0x186783840")]
	private void GDHGECEKIFO(bool DPGAKDOJNOD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6788270", Offset = "0x6787670", VA = "0x186788270")]
	private void MDMFCFHDPNJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x67814B0", Offset = "0x67808B0", VA = "0x1867814B0")]
	private void DCGALLGHCLI(bool DPGAKDOJNOD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x67806A0", Offset = "0x677FAA0", VA = "0x1867806A0")]
	private void ANHAGLGABDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x6782CA0", Offset = "0x67820A0", VA = "0x186782CA0")]
	private void FELHNLODADC(Material MEBPFJILBOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x6781DD0", Offset = "0x67811D0", VA = "0x186781DD0")]
	private void EHGCGEPNLBL(Material MEBPFJILBOA, Color DILGJKHMHDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x678AC50", Offset = "0x678A050", VA = "0x18678AC50")]
	private void ONENEGKKAEL(Material MEBPFJILBOA, Color ANMNNDJIHFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x677FE80", Offset = "0x677F280", VA = "0x18677FE80")]
	private void ADLIDIHPKMD(Material MEBPFJILBOA, Color AJFKMCACAOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6787440", Offset = "0x6786840", VA = "0x186787440")]
	private void JHLOJJJHBKH(Material MEBPFJILBOA, Texture2D LPJKOFKCGGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x6780AB0", Offset = "0x677FEB0", VA = "0x186780AB0")]
	private void BDDPDIADMAL(Material MEBPFJILBOA, Texture CCOKDGNIPBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x678A3C0", Offset = "0x67897C0", VA = "0x18678A3C0")]
	private void OKPDBLKKGMP(Action<KAPLCENLDMN> JLNDPLFFCKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x6780000", Offset = "0x677F400", VA = "0x186780000")]
	private void AFBHEHOPBOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6781F40", Offset = "0x6781340", VA = "0x186781F40")]
	private void EMBHINCKGFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x6780C10", Offset = "0x6780010", VA = "0x186780C10")]
	private FCIMHBPMHFO BKLJBGNFDAE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6787730", Offset = "0x6786B30", VA = "0x186787730")]
	private void JMKKKINNMLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x6782900", Offset = "0x6781D00", VA = "0x186782900")]
	public void EPJOPKIMFFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x678B210", Offset = "0x678A610", VA = "0x18678B210")]
	[CompilerGenerated]
	private void PELMJMJENIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x6787BE0", Offset = "0x6786FE0", VA = "0x186787BE0")]
	[CompilerGenerated]
	private void KIAAJCENPMK(KAPLCENLDMN MPEIFFOGJJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x6784860", Offset = "0x6783C60", VA = "0x186784860")]
	[CompilerGenerated]
	private void IHEDBIKNAMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x678B060", Offset = "0x678A460", VA = "0x18678B060")]
	[CompilerGenerated]
	private void PCKKFLBIHCE(KAPLCENLDMN MPEIFFOGJJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x678AFD0", Offset = "0x678A3D0", VA = "0x18678AFD0")]
	[CompilerGenerated]
	private void PCJMLOAEEIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6788770", Offset = "0x6787B70", VA = "0x186788770")]
	[CompilerGenerated]
	private void MIOEFKMPGKL(KAPLCENLDMN MPEIFFOGJJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6787DB0", Offset = "0x67871B0", VA = "0x186787DB0")]
	[CompilerGenerated]
	private void LGBJHLBGILP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x677FD90", Offset = "0x677F190", VA = "0x18677FD90")]
	[CompilerGenerated]
	private void ABHHJIDKAMJ(KAPLCENLDMN MPEIFFOGJJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x67843B0", Offset = "0x67837B0", VA = "0x1867843B0")]
	[CompilerGenerated]
	private void HDMABOMODKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x678A310", Offset = "0x6789710", VA = "0x18678A310")]
	[CompilerGenerated]
	private void OBCMAFDLHHI(KAPLCENLDMN MPEIFFOGJJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6784730", Offset = "0x6783B30", VA = "0x186784730")]
	[CompilerGenerated]
	private void IGGHAKHJEIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6788480", Offset = "0x6787880", VA = "0x186788480")]
	[CompilerGenerated]
	private void MFIHEPEDNCI(KAPLCENLDMN MPEIFFOGJJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6785850", Offset = "0x6784C50", VA = "0x186785850")]
	[CompilerGenerated]
	private void JGADOFJFPPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6785420", Offset = "0x6784820", VA = "0x186785420")]
	[CompilerGenerated]
	private void IPDHFFMIAFA(KAPLCENLDMN MPEIFFOGJJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x678B320", Offset = "0x678A720", VA = "0x18678B320")]
	[CompilerGenerated]
	private void PNALDBAIHMM(KeyValuePair<string, LEENANICOKB<Texture2D>> KMCHOKDACPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x6783490", Offset = "0x6782890", VA = "0x186783490")]
	[CompilerGenerated]
	private void FIKBPACGLAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x677FDC0", Offset = "0x677F1C0", VA = "0x18677FDC0")]
	[CompilerGenerated]
	private void ABLGLIJOMGD(KAPLCENLDMN MPEIFFOGJJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x677FDF0", Offset = "0x677F1F0", VA = "0x18677FDF0")]
	[CompilerGenerated]
	private void ABNMAENFGOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x67888D0", Offset = "0x6787CD0", VA = "0x1867888D0")]
	[CompilerGenerated]
	private void MNBMKPECOHG(KAPLCENLDMN MPEIFFOGJJN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class OPPLJAHMLKF : AAHJCJJEOLB
{
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private static readonly int IDIGDBPFHLF;

	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private static readonly int BCGKCNPLNIJ;

	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private static readonly int JKOMCPKIEEJ;

	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private static readonly int ECPEKFFEJIN;

	[Cpp2IlInjected.Token(Token = "0x4000130")]
	private static readonly int KJJFMODOAAE;

	[Cpp2IlInjected.Token(Token = "0x4000131")]
	private static readonly int FKLGKAJEMCA;

	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private static readonly int OGJOOHNAGDC;

	[Cpp2IlInjected.Token(Token = "0x4000133")]
	private static readonly int OFLICEAJOMG;

	[Cpp2IlInjected.Token(Token = "0x4000134")]
	private static readonly int HLGGNBGLOLE;

	[Cpp2IlInjected.Token(Token = "0x4000135")]
	private static readonly int IDBMHLOMFBK;

	[Cpp2IlInjected.Token(Token = "0x4000136")]
	private static readonly int DEIMCOFOFFG;

	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private static readonly int JAKILPIHCDL;

	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private static readonly int MOHJEGNNKAB;

	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private static readonly int NACDCIIPAPD;

	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private static readonly int HOMMKIPIJOG;

	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private static readonly int LBFIOIPFBJO;

	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private static readonly int GPFENNPCODI;

	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private static readonly int OHPAOFEEGKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private Transform FOGNJJPAPKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private Transform FLFHKMMDAEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private Transform LAJIPNDFFKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private Transform HOKKBLJAFGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private Transform MHMCJBAMIBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private Transform FMICDAHOAJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private Transform CIEBNBMJJEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private FGJBFEGGOLH HJDKIAHCKFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private MaterialPropertyBlock KAAOOBPAIAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private SkinnedMeshRenderer[] HHAKLOEJPAJ;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	private MaterialPropertyBlock APGCMGDCAPG
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x6792BB0", Offset = "0x6791FB0", VA = "0x186792BB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool ADBLGJPBPPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x6794270", Offset = "0x6793670", VA = "0x186794270", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x6794430", Offset = "0x6793830", VA = "0x186794430", Slot = "7")]
	public void MGIGIPLLEKC(FGJBFEGGOLH BBHKLJEMHGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x6792830", Offset = "0x6791C30", VA = "0x186792830", Slot = "8")]
	public void AEEGNGGEIHJ(NLHFIIFDHFF LFPKLHPINIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x6792D10", Offset = "0x6792110", VA = "0x186792D10", Slot = "5")]
	public void HLDNMFIGNCL(CGEECGJAMAK DMCKCIMILHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x67944F0", Offset = "0x67938F0", VA = "0x1867944F0")]
	private Vector2 OKPCELJJHNB(Vector2 KEKPNKBOKFP)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x6793140", Offset = "0x6792540", VA = "0x186793140", Slot = "6")]
	public void IBEJECIMBAB(ONOHANILGCF LFPKLHPINIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x6792860", Offset = "0x6791C60", VA = "0x186792860")]
	private void BBAGFFJOAMB(ONOHANILGCF NHLEDIMMPAG, AFJFNDIDDOH JAKJNFJFOMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x6792C30", Offset = "0x6792030", VA = "0x186792C30")]
	private void FCPAHJPAPMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x6794910", Offset = "0x6793D10", VA = "0x186794910")]
	public OPPLJAHMLKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x6794550", Offset = "0x6793950", VA = "0x186794550")]
	[CompilerGenerated]
	internal static (float, float) PCCIDEABIEE(float MBDMONMJNBJ)
	{
		return default((float, float));
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x67943F0", Offset = "0x67937F0", VA = "0x1867943F0")]
	[CompilerGenerated]
	internal static Vector4 LEFJBFDBDDL(Vector2 HBGADHMDPAD, Vector2 MFGJMFBCPKM)
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
		private ACJEOEJGGDE? cachedMaterialCombinationId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		[SerializeField]
		private Material material;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		[SerializeField]
		private Material[] additionalMaterials;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public IMNBCOOFJKJ CombinationId
		{
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x6795650", Offset = "0x6794A50", VA = "0x186795650")]
			get
			{
				return default(IMNBCOOFJKJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public ACJEOEJGGDE MaterialCombinationId
		{
			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x6795680", Offset = "0x6794A80", VA = "0x186795680")]
			get
			{
				return default(ACJEOEJGGDE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public Material Material
		{
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x8507B0", Offset = "0x84FBB0", VA = "0x1808507B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public Material[] AdditionalMaterials
		{
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x8507C0", Offset = "0x84FBC0", VA = "0x1808507C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x67952E0", Offset = "0x67946E0", VA = "0x1867952E0")]
		public Material[] AEMANFGHIMP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x67953C0", Offset = "0x67947C0", VA = "0x1867953C0")]
		public static void BAKOFFFNCLG(AvatarItemMaterial HMANJHCFAKI, Material JOFMGPCHADM, int AODCLDOHEBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x6795580", Offset = "0x6794980", VA = "0x186795580")]
		public AvatarItemMaterial()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[NIMGPLGMLPL]
public struct MDGJJDCBDJM : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	[ReadOnly]
	public BAPADEBDJGL LKMCHGFKAFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	[ReadOnly]
	public int MOHBBMAMMMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	public EAOPPDHCNGB INPIOCELPPG;

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x679E1B0", Offset = "0x679D5B0", VA = "0x18679E1B0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[NativeContainer]
[NIMGPLGMLPL]
public struct EAOPPDHCNGB : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	public NativeArray<Vector3> HHNBPNGLIHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	public NativeArray<Vector3> EEAPKKFGPAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	public NativeArray<Vector4> AAPLLALEIMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	public NativeArray<Vector2> DIBNEJGMGGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	public NativeArray<Vector2> DMMCIGAOCPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	public NativeArray<Vector2> MLICMINAEEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	public NativeArray<Vector2> GICAAMPCMIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	public NativeArray<Color> BMNCICHDAJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	public NativeArray<int> IMLILNNHEDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	public NativeArray<int> DEAOPIAKJCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	private NativeArray<int> OPKJIDFNJPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private NativeArray<int> NOACHPGEKAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	public NativeArray<int> KJDMGKHIGIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	public NativeArray<int> MJAAONCAEFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	public NativeArray<int> PHNEBDHEEIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	public NativeArray<BoneWeight> DIOHBMIEPHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	private NativeArray<int> GLODDHJJLAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	private bool CHLFILHHNEE;

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public int FHKJKCGHLIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x67985B0", Offset = "0x67979B0", VA = "0x1867985B0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x67988A0", Offset = "0x6797CA0", VA = "0x1867988A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public int ECPPOFDHOIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x6798EC0", Offset = "0x67982C0", VA = "0x186798EC0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x6798EE0", Offset = "0x67982E0", VA = "0x186798EE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public int HHDHDEEBDEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x6798ED0", Offset = "0x67982D0", VA = "0x186798ED0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x6798CC0", Offset = "0x67980C0", VA = "0x186798CC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x6798F30", Offset = "0x6798330", VA = "0x186798F30")]
	public EAOPPDHCNGB(int BBMNGDOIKIH, int OKIGBPGAEIB, int OIGPBLANKNK, int NBDCELFHEGL, Allocator EIFDLGAHDFC, int JMAIJAHDLJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x67985F0", Offset = "0x67979F0", VA = "0x1867985F0")]
	public void DFLCDCODGKE(int AGAGKNBDCIG, Vector3 LMJDILMPEPB, Vector3 DMNNLPDGIGJ, Vector4 JILAKCNFFBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x6798CD0", Offset = "0x67980D0", VA = "0x186798CD0")]
	public void JANFGNLCJBL(int AGAGKNBDCIG, BoneWeight MPHNKKEBPGA, NativeSlice<byte> KJCIPADJJIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x6798EF0", Offset = "0x67982F0", VA = "0x186798EF0")]
	public Color OKFLGKKMJHG(int AGAGKNBDCIG)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x6798F10", Offset = "0x6798310", VA = "0x186798F10")]
	public void PPOOEJBIHGJ(int AGAGKNBDCIG, Color HHIGDOHOLEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x6798E70", Offset = "0x6798270", VA = "0x186798E70")]
	public void JCCGJBKLDAK(byte LAGIOKBKBMB, int AGAGKNBDCIG, Vector2 HPBLGJLGFAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x6798CB0", Offset = "0x67980B0", VA = "0x186798CB0")]
	public void GJIHGKINBIJ(int AGAGKNBDCIG, int HGHNPOJIEAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x67985C0", Offset = "0x67979C0", VA = "0x1867985C0")]
	public bool COHNDDCIIGM(int LAGIOKBKBMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x67984E0", Offset = "0x67978E0", VA = "0x1867984E0")]
	public void BEKDEDINMFK(int KJIGLBLGECK, int BILMLHHHLMM, int CHJNEOPKHME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x6798C00", Offset = "0x6798000", VA = "0x186798C00")]
	public int[] FGGOBNOLDCJ(int KJIGLBLGECK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x6798810", Offset = "0x6797C10", VA = "0x186798810")]
	private NativeSlice<int> EGFEIFFCNOD(int KJIGLBLGECK)
	{
		return default(NativeSlice<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x6798660", Offset = "0x6797A60", VA = "0x186798660", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x67988B0", Offset = "0x6797CB0", VA = "0x1867988B0")]
	public Mesh FEMBDCBNPMJ([Optional] string AFJGFPMGFOJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[NativeContainer]
[DefaultMember("Item")]
[NIMGPLGMLPL]
public struct BAPADEBDJGL : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	public NativeArray<Vector3> HHNBPNGLIHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	public NativeArray<Vector3> EEAPKKFGPAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	public NativeArray<Vector4> AAPLLALEIMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	public NativeArray<Vector2> DIBNEJGMGGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	public NativeArray<Vector2> DMMCIGAOCPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	public NativeArray<Vector2> MLICMINAEEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	public NativeArray<Vector2> GICAAMPCMIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	public NativeArray<Color> BMNCICHDAJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	public NativeArray<int> JKBMIJIGDPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	public NativeArray<int> LDAJCLPHGJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	public NativeArray<int> DAOOMLHIGLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	public NativeArray<int> IDGFOMKDDMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	public NativeArray<bool> GBOHPFPLMPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	public NativeArray<int> HBFDHHLHBIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	public NativeArray<int> DALPMGGDMPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	public NativeArray<BoneWeight> DJFJNIPEHNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private NativeArray<Matrix4x4> MJAKJDGBFOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private NativeArray<int> DOLECNENCON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private NativeArray<byte> ICINLDGHAIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private NativeArray<int> NEABIDHDOEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private NativeArray<int> IBABPDJLIHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	public NativeArray<sbyte> ACIFPALKEOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	public NativeArray<byte> JEEEMHBKGJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private NativeArray<int> HCCFDENHFCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	private bool CHLFILHHNEE;

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public int NIACGEHODMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x201B700", Offset = "0x201AB00", VA = "0x18201B700")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public int EJJAOGECFMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x10E4720", Offset = "0x10E3B20", VA = "0x1810E4720")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public int PHEANAPGKHN
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x6795920", Offset = "0x6794D20", VA = "0x186795920")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public int GPAEMEFDLEA
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x67961D0", Offset = "0x67955D0", VA = "0x1867961D0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x67961F0", Offset = "0x67955F0", VA = "0x1867961F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public int FHKJKCGHLIO
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x6795900", Offset = "0x6794D00", VA = "0x186795900")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x6795BB0", Offset = "0x6794FB0", VA = "0x186795BB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public int DMLBADJOKNM
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x6796210", Offset = "0x6795610", VA = "0x186796210")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x67961E0", Offset = "0x67955E0", VA = "0x1867961E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public ICJADOOFKCH KDJPAAAJLEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x6795BC0", Offset = "0x6794FC0", VA = "0x186795BC0")]
		get
		{
			return default(ICJADOOFKCH);
		}
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x6796200", Offset = "0x6795600", VA = "0x186796200")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public byte HOIOPPPMKOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x6795910", Offset = "0x6794D10", VA = "0x186795910")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x6795BD0", Offset = "0x6794FD0", VA = "0x186795BD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public HMMHOKNPKGO OKOJIGDPPIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x6795BE0", Offset = "0x6794FE0", VA = "0x186795BE0")]
		get
		{
			return default(HMMHOKNPKGO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x6796220", Offset = "0x6795620", VA = "0x186796220")]
	public BAPADEBDJGL(IList<Mesh> KOKOMEOODDI, IList<Matrix4x4> AMGLMBAKHKG, IList<bool> GBOHPFPLMPL, byte KAOBAGCNPGB, IList<byte[]> LNMAIOINAKK, IList<int> AADGFOCDNDE, IList<bool> HGAMDHIOIOE, IList<int> HBFDHHLHBIF, IList<int> KBAEKMCNIPB, IList<int> KPEKDFAIFKO, Allocator EIFDLGAHDFC, ICJADOOFKCH ELOFBBBPKNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x6796100", Offset = "0x6795500", VA = "0x186796100")]
	public EAOPPDHCNGB HPPIHHILIPC(Allocator EIFDLGAHDFC)
	{
		return default(EAOPPDHCNGB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x6795950", Offset = "0x6794D50", VA = "0x186795950", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[NIMGPLGMLPL]
public class FHGOONONDBJ : BDMLPIMFHML
{
	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x6799720", Offset = "0x6798B20", VA = "0x186799720")]
	public BAPADEBDJGL HIHDABEPNLF()
	{
		return default(BAPADEBDJGL);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x677E6B0", Offset = "0x677DAB0", VA = "0x18677E6B0")]
	public FHGOONONDBJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public struct HMMHOKNPKGO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	public NativeSlice<Vector3> HHNBPNGLIHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	public NativeSlice<Vector3> EEAPKKFGPAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	public NativeSlice<Vector4> AAPLLALEIMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	public NativeSlice<Vector2> DIBNEJGMGGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	public NativeSlice<Vector2> DMMCIGAOCPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	public NativeSlice<Vector2> MLICMINAEEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	public NativeSlice<Vector2> GICAAMPCMIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	public NativeSlice<Color> BMNCICHDAJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	public NativeSlice<int> AOCCODICOMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	public NativeSlice<int> IDGFOMKDDMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	public NativeSlice<BoneWeight> DJFJNIPEHNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	public NativeSlice<byte> GKODPMIEKEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	public int FPCAHPMDEMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	public Matrix4x4 HDMHGMMJCJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	public int EDJPIHDBCHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	public NativeSlice<byte> KJCIPADJJIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	public bool MBEDBOJCJOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	public int KOJJDIMLAON;
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
internal readonly struct DHDACKKCKPC : IEquatable<DHDACKKCKPC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	internal readonly Material KEAFBLNCKGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	internal readonly FKHGIMLBPNH PIPPMHEHCBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	internal readonly DOGPPKACJCI PCENOEIMHDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	internal readonly EPOJMBFGCMA KOBECLEFHFE;

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0xB09AB0", Offset = "0xB08EB0", VA = "0x180B09AB0")]
	public DHDACKKCKPC(Material JOFMGPCHADM, FKHGIMLBPNH LIFGJKDMPPF, DOGPPKACJCI PACPDHCMPJA, EPOJMBFGCMA CBBPPBKJBOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x67982C0", Offset = "0x67976C0", VA = "0x1867982C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0xB09810", Offset = "0xB08C10", VA = "0x180B09810", Slot = "4")]
	public bool Equals(DHDACKKCKPC IEDCHGMDIML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x6798140", Offset = "0x6797540", VA = "0x186798140", Slot = "0")]
	public override bool Equals(object LALIGKIKEBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x6798220", Offset = "0x6797620", VA = "0x186798220", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public class KAPLCENLDMN : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	private MaterialPropertyBlock LHNNPEDIGOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	public Color? LDGIFPEOENJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	public Color? LCAOAHIJAFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	public Color? AGENEEBABDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	public Color? GEDBPIIBDPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	public Color BIPGMCDGEHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	public Color JLDLPGNEAFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	public Color AOKJBDIAKCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	public Texture2D GPBKFGAHPKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	public Texture2D EFBBMOEEEFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	private Dictionary<DHDACKKCKPC, int> JACEJAPODNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private FKHGIMLBPNH[] CIGGPFFEEHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private DOGPPKACJCI[] FAAKGLJNAAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	public Vector4[] FBBAICGECNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	public Vector4[] AMBMDEHJKIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	public Vector4[] JDHODHLAKDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	public Vector4[] CEKJNIMEMOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	public Vector4[] GBICJOGDIAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	public Vector4[] LPAKLBIBBAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private List<Texture2D> GLBMLDAJENI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private Vector4[] NACAIKDPODI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	private List<Texture2D> EIJAPDCAFEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	private float[] NJMDAKCMJNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	private Vector4[] JABGOBJLAPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	private float[] HBCGODCPILH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	public float[] DECCKGGJFPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	private List<Texture2D> FJIMIKIDJDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	private float[] AJCLMPNFDJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private List<Texture2D> AKPOCCMIPDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	private Vector4[] EGEKDJNKGPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	private float[] AAJDGONEAPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	private Vector4[] OIGKBMBOFPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	public float[] CFGFKKACGDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	public Texture2DArray AGMAHJPAGKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	public Texture2DArray CCLAMMJLPDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	public Texture2DArray DOKMDBEJDHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	public Texture2DArray BCJKJLJBCOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	private bool DLFIGGEBCIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x184")]
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	private int BOMLKHOCGAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	private Vector2? PJNADDKHJIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x194")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	private TextureFormat LHKBAJNCKGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	private Vector2? IMGEADGHOMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A4")]
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	private TextureFormat JHMHNLBFLAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	private Vector2? EKBNPKFPIBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B4")]
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	private TextureFormat GGCMFMGHOBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	private Vector2? LDFNOOFGBIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C4")]
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	private TextureFormat BFKBFGJHPHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	private bool OFBHCPGMGBM;

	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	private static int MNNGFPAFMHO;

	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	private static int NABBHJNOJHF;

	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	private static int JNOPLIKMIBH;

	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	private static int PDJABIJCNBE;

	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	private static int OCHDJPCDONK;

	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	private static int OHDHEBFOJGJ;

	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	private static int PPPABNEMFEN;

	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	private static int JCANBOKPJEG;

	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	private static int MNBLBHEKPIK;

	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	private static int FCPICHAEGEG;

	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	private static int HFOMMNHANNK;

	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	private static int ECFLIELOFKJ;

	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	private static int AKDGMMFLANM;

	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	private static int DHIBLGMFJDN;

	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	private static int PLLPNIACPPL;

	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	private static int FGIKFJLBLPL;

	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	private static int HGPPFGKGOOP;

	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	private static int EIGGEJMKCAK;

	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	private static int LELDLDAHDIF;

	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	private static int CGKEEKMOHBD;

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x679CE70", Offset = "0x679C270", VA = "0x18679CE70")]
	private KAPLCENLDMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x679D360", Offset = "0x679C760", VA = "0x18679D360")]
	public KAPLCENLDMN(Color ANJOCNNPNJA, Color IFKDEDABICC, Color FNCPEDMNKKE, Color? KINEJBODIJI, Color? CGBBLIJJIHG, Color? JPFACCDONNI, Texture2D INEJNCNPPFJ, Texture2D MJCJPNIFJGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x679C8A0", Offset = "0x679BCA0", VA = "0x18679C8A0")]
	internal int PELNFDHFIBM(Material IKLCMJKBAKK, FKHGIMLBPNH LIFGJKDMPPF, DOGPPKACJCI PACPDHCMPJA, EPOJMBFGCMA CBBPPBKJBOP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x679C810", Offset = "0x679BC10", VA = "0x18679C810")]
	private int PELNFDHFIBM(DHDACKKCKPC PEDCMDADFIN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x679B6D0", Offset = "0x679AAD0", VA = "0x18679B6D0")]
	internal int HHPPBKELGAI(Material IKLCMJKBAKK, Color AJFKMCACAOP, Color EJKFGIHMGHD, Color CPJNOMBMEIG, Color PJBIBIFCCMA, Color CNEBCBLGBOI, Texture2D KLINFEPGJJN, Vector4 AFGFHIPNDBC, Texture2D BPBPJKKHFBF, Vector4 MOCJBKMJPFP, float EOGPKFABMJB, float NAPIGMGIMDK, Texture2D OLMCGCPIDMO, Vector4 LPFOCENEKKM, float HCAPBHMKIOO, Texture2D BOJICDDPDFK, Color PGBKNALLEAM, Vector4 MPBIFBBADPA, FKHGIMLBPNH LIFGJKDMPPF, DOGPPKACJCI PACPDHCMPJA, EPOJMBFGCMA CBBPPBKJBOP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x679C4A0", Offset = "0x679B8A0", VA = "0x18679C4A0")]
	private void LAKODEGMDBE(List<Texture2D> GLBMLDAJENI, [Out] Texture2DArray DAKGNGFNPFP, [Out] Texture2DArray GLIIBHIJHJN, [Out] Texture2DArray PDEALGLLKKF, [Out] Texture2DArray GJPAOFKNILF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x679C990", Offset = "0x679BD90", VA = "0x18679C990")]
	public void PKDIFADEKGO(Shader DFACEPFFCAL, Renderer CODANAEIMCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x679A7F0", Offset = "0x6799BF0", VA = "0x18679A7F0")]
	private void CLONPDEBOHI(Shader DFACEPFFCAL, Renderer CODANAEIMCO, int BGHJMLFPMKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x679C2A0", Offset = "0x679B6A0", VA = "0x18679C2A0")]
	private Color IMAPCBMMHHK(Color DLHLONLGMLN, FKHGIMLBPNH KBECHBLJMAC)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x679B540", Offset = "0x679A940", VA = "0x18679B540")]
	private Color DAGNDJLHINN(Color ECICKDFDHOH, FKHGIMLBPNH KBECHBLJMAC)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x679C710", Offset = "0x679BB10", VA = "0x18679C710")]
	private bool ODLEIFNOHHA(Texture2D LBEEFDNJBBK, DOGPPKACJCI FAHOFPBLFHO, [Out] Texture2D LCNNFBLOCDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x679C660", Offset = "0x679BA60", VA = "0x18679C660")]
	private void NDAILGGPOHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x679B690", Offset = "0x679AA90", VA = "0x18679B690", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class BAFOGJNFNPB
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private sealed class KKDFPEJFNKB : IEnumerator<PKLKPEJFEBK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		private PKLKPEJFEBK <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		public JobHandle handle;

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		private PKLKPEJFEBK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0x84D900", Offset = "0x84CD00", VA = "0x18084D900", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x84D900", Offset = "0x84CD00", VA = "0x18084D900", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x8527C0", Offset = "0x851BC0", VA = "0x1808527C0")]
		[DebuggerHidden]
		public KKDFPEJFNKB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0xB095E0", Offset = "0xB089E0", VA = "0x180B095E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x679E160", Offset = "0x679D560", VA = "0x18679E160", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220")]
	public static void DABONGBJCNP(string GNBDDFJPEIA, int DDIIAJHFBBE, long LMCGCGLMHFC, long OLCENFHOHLP, long OKCDOMKPABL, long AMNLGFABHNM, long BPGJMMMGNNL, long BLEKKHGPIKA, long GGIPGGFKGJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x6795740", Offset = "0x6794B40", VA = "0x186795740")]
	public static DAODDLKDJDG GCLPADOJHLM(JobHandle ELDJPBLDBOF, bool CBNJALHEBDN, bool KLKCKFFGGFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x6795890", Offset = "0x6794C90", VA = "0x186795890")]
	[IteratorStateMachine(typeof(KKDFPEJFNKB))]
	private static IEnumerator<PKLKPEJFEBK> HCJJPJIIPBB(JobHandle EELBLNNILCF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public class KCKLCAHOKPH : CHBMJHGCEHK, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	private EJAIBLLNAOI NNLILFKFKPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	private DOLNHIBBKOB BFGCAOKPHJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	private IRecRoomQualityConfigProvider GHMOMDMOMBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	private bool CHLFILHHNEE;

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x679DAF0", Offset = "0x679CEF0", VA = "0x18679DAF0")]
	[EAMANMFIEOM(NBICBCAKHEI.GameOnly)]
	private static void PBAIMDHFLHJ(NFLAEHJHNPL IFELLLJKHDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x5AA9CE0", Offset = "0x5AA90E0", VA = "0x185AA9CE0")]
	[UnityEngine.Scripting.Preserve]
	public KCKLCAHOKPH([NCPIDBJOPHL(null)] DOLNHIBBKOB FNNINDOFAKO, [NCPIDBJOPHL(null)] EJAIBLLNAOI AEOMOPECKPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x84C220", Offset = "0x84B620", VA = "0x18084C220", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x679D8E0", Offset = "0x679CCE0", VA = "0x18679D8E0")]
	private void EFDINGGMKDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x679DA90", Offset = "0x679CE90", VA = "0x18679DA90", Slot = "4")]
	public void KAENBIBKPJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x679D420", Offset = "0x679C820", VA = "0x18679D420", Slot = "5")]
	public LEENANICOKB<Texture2D> COJHPICIKPM(POPLCJGIGAJ BHGLBOMIOCA, [Optional] JIHJOGGPCJB GLODDHJJLAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x679D950", Offset = "0x679CD50", VA = "0x18679D950")]
	private uint GPNAMLJDIEE(POPLCJGIGAJ BHGLBOMIOCA, JIHJOGGPCJB GLODDHJJLAG)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public interface NBBFHNFBOBL
{
	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HBJCEBHMBFK(Mesh GFKLPJBCEPF, Matrix4x4 PKBJLHJLLKK, byte[] KJCIPADJJIC, bool ONIFLIHFDKH = false, GAGIPHDMFOM.EKBGBPNADEI HBBAANAOEGL = (GAGIPHDMFOM.EKBGBPNADEI)0, int HBFDHHLHBIF = -1, bool GBOHPFPLMPL = false);

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JAGHOAKDCIH(Allocator EIFDLGAHDFC, ICJADOOFKCH ELOFBBBPKNP, byte KAOBAGCNPGB, [Optional] IList<int> KBAEKMCNIPB, [Optional] IList<int> NGAJOKINGGA);
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public readonly struct COJNOJJJGMH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	public readonly GameObject HFLJABFFMMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	private readonly AvatarItemMaterial EHKGJAJLBLO;

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0xB83E50", Offset = "0xB83250", VA = "0x180B83E50")]
	public COJNOJJJGMH(GameObject HFLJABFFMMG, AvatarItemMaterial EHKGJAJLBLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x6797A80", Offset = "0x6796E80", VA = "0x186797A80")]
	public void NEHLAOAIPGG(Material JOFMGPCHADM, int AODCLDOHEBI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class JCLBIPKMBIB : AAHNHJJMCHN<Task<(GameObject, AvatarItemMaterial)>, COJNOJJJGMH>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private struct KEDNJPAIEOJ : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x679DBF0", Offset = "0x679CFF0", VA = "0x18679DBF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x679E0F0", Offset = "0x679D4F0", VA = "0x18679E0F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	private LEENANICOKB<GameObject> BLADDHKLIHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	private LEENANICOKB<AvatarItemMaterial> EODMAFJOJMG;

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x679A760", Offset = "0x6799B60", VA = "0x18679A760")]
	private JCLBIPKMBIB(Task<(GameObject, AvatarItemMaterial)> LKENJOBMDDP, LEENANICOKB<GameObject> JKDEANNGPCB, LEENANICOKB<AvatarItemMaterial> EPDCEJINDIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x679A210", Offset = "0x6799610", VA = "0x18679A210")]
	public static JCLBIPKMBIB IBMNHJIAJMD(AssetReference BPMLJKGKKCH, [Optional] AssetReference AFJPBPNDJEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x679A0F0", Offset = "0x67994F0", VA = "0x18679A0F0", Slot = "11")]
	protected override COJNOJJJGMH AMLEKBCPMFG(Task<(GameObject, AvatarItemMaterial)> INNGIFCLJJK)
	{
		return default(COJNOJJJGMH);
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x679A190", Offset = "0x6799590", VA = "0x18679A190", Slot = "12")]
	protected override void GHLAODMOCOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x679A630", Offset = "0x6799A30", VA = "0x18679A630")]
	[AsyncStateMachine(typeof(KEDNJPAIEOJ))]
	private static Task<(GameObject, AvatarItemMaterial)> OCPBDEGMHIH(Task<GameObject> AJEHDIHDIHA, Task<AvatarItemMaterial> CIDGHNOLGJM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class DEFMHPMKBLN
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	private class OLILNHILHDM : AAHNHJJMCHN<Task<MaterialMapAsset>, Material[]>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		private LEENANICOKB<MaterialMapAsset> EELBLNNILCF;

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x679F760", Offset = "0x679EB60", VA = "0x18679F760")]
		public OLILNHILHDM(LEENANICOKB<MaterialMapAsset> EELBLNNILCF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x679F2C0", Offset = "0x679E6C0", VA = "0x18679F2C0", Slot = "11")]
		protected override Material[] AMLEKBCPMFG(Task<MaterialMapAsset> LKENJOBMDDP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x679F700", Offset = "0x679EB00", VA = "0x18679F700", Slot = "12")]
		protected override void GHLAODMOCOE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	private class MFCKIHNMPMP : AAHNHJJMCHN<Task<Material[]>, Material[]>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		private List<LEENANICOKB<Material>> FOJJDKCKDEE;

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x679F250", Offset = "0x679E650", VA = "0x18679F250")]
		public MFCKIHNMPMP(Task<Material[]> LKENJOBMDDP, List<LEENANICOKB<Material>> FOJJDKCKDEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x679F0C0", Offset = "0x679E4C0", VA = "0x18679F0C0", Slot = "11")]
		protected override Material[] AMLEKBCPMFG(Task<Material[]> INNGIFCLJJK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x679F110", Offset = "0x679E510", VA = "0x18679F110", Slot = "12")]
		protected override void GHLAODMOCOE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	private static readonly BADOKLEEAHE MMCLBKHCHDA;

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x6797C90", Offset = "0x6797090", VA = "0x186797C90")]
	public static LEENANICOKB<Material[]> IDMMCNGBBEB(AssetReference[] GFBCGELGJDP)
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
		[FKKHMOHLHBN(HNCPNLMMHNP.Self, false, false, false)]
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
		[Cpp2IlInjected.Address(RVA = "0x679F840", Offset = "0x679EC40", VA = "0x18679F840")]
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
		private struct FGDMBDCKIDM : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000207")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000208")]
			public AsyncTaskMethodBuilder<IGBKCKLFAIA> <>t__builder;

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
			private TaskAwaiter<IGBKCKLFAIA> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x6799370", Offset = "0x6798770", VA = "0x186799370", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x67996B0", Offset = "0x6798AB0", VA = "0x1867996B0", Slot = "5")]
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
		private Dictionary<NNBLNMLCNGB, SymmetricalFaceFeature> eyeBrowFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		private Dictionary<NNBLNMLCNGB, EyesFaceFeature> eyeFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		private Dictionary<NNBLNMLCNGB, NoseFaceOption> noseOptionsDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		private Dictionary<NNBLNMLCNGB, FaceFeature> mouthFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		private readonly Dictionary<NNBLNMLCNGB, int> featureToIndexMap;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		private IGBKCKLFAIA _defaultFaceStyle;

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		private bool dictionariesInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0x679A0C0", Offset = "0x67994C0", VA = "0x18679A0C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x6799F60", Offset = "0x6799360", VA = "0x186799F60")]
		public IGBKCKLFAIA PCFKBBMDGMM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x6799B90", Offset = "0x6798F90", VA = "0x186799B90")]
		[AsyncStateMachine(typeof(FGDMBDCKIDM))]
		public Task<IGBKCKLFAIA> IGBACLMHDAM(int GPGFMMHIBBP, int BJHICIJHIOP, int JBJPMOJGKBC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x6799810", Offset = "0x6798C10", VA = "0x186799810")]
		public NoseFaceOption CDMOKGDFOCD(int JADMFEIHANF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x6799DE0", Offset = "0x67991E0", VA = "0x186799DE0")]
		public SelectableFaceOption NHOBMEILBOF(FaceFeatureType OKMBEALBKHJ, NNBLNMLCNGB GNGGKCJFNFE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x6799FB0", Offset = "0x67993B0", VA = "0x186799FB0")]
		public int PKAJOLLLNHF(NNBLNMLCNGB GNGGKCJFNFE)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x67998B0", Offset = "0x6798CB0", VA = "0x1867998B0")]
		private void EOKBNHNDCHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x2B58B00", Offset = "0x2B57F00", VA = "0x182B58B00")]
		private void DEBDCKNPPDF<T>(IDictionary<NNBLNMLCNGB, T> HLFLEOMHHLN, IReadOnlyList<T> JBODNNEGIDN) where T : SelectableFaceOption
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x6799AE0", Offset = "0x6798EE0", VA = "0x186799AE0")]
		public NNBLNMLCNGB FBIPDLODEOF(FaceFeatureType OKMBEALBKHJ)
		{
			return default(NNBLNMLCNGB);
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x6799CC0", Offset = "0x67990C0", VA = "0x186799CC0")]
		public NNBLNMLCNGB KIDNHJGLFLK(FaceFeatureType OKMBEALBKHJ)
		{
			return default(NNBLNMLCNGB);
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x679A030", Offset = "0x6799430", VA = "0x18679A030")]
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
