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
	public class LogRegistrationIndex : NELPCBNCFHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7306940", Offset = "0x7305540", VA = "0x187306940", Slot = "4")]
		public override void CHOGICNNBDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x9827A0", Offset = "0x9813A0", VA = "0x1809827A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x961640", Offset = "0x960240", VA = "0x180961640", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override string AssetGUID
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x7309B40", Offset = "0x7308740", VA = "0x187309B40", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7309AD0", Offset = "0x73086D0", VA = "0x187309AD0", Slot = "17")]
		public override bool RuntimeKeyIsValid()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7309B00", Offset = "0x7308700", VA = "0x187309B00")]
		public RecNetCDNAssetReference(RecNetCDNKey NKANGPLHEGE)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class RecNetCDNKey
	{
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public enum KJOJFNPDGFC : byte
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
			[Cpp2IlInjected.Address(RVA = "0x9574F0", Offset = "0x9560F0", VA = "0x1809574F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x957520", Offset = "0x956120", VA = "0x180957520")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public string UniqueItemIdentifier
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x957530", Offset = "0x956130", VA = "0x180957530")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x957510", Offset = "0x956110", VA = "0x180957510")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public string CacheHash
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x957550", Offset = "0x956150", VA = "0x180957550")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x957500", Offset = "0x956100", VA = "0x180957500")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RecNetCDNKey Dependency
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x9574C0", Offset = "0x9560C0", VA = "0x1809574C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x957540", Offset = "0x956140", VA = "0x180957540")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool AttemptPrecacheLookup
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x986300", Offset = "0x984F00", VA = "0x180986300")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x986080", Offset = "0x984C80", VA = "0x180986080")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public KJOJFNPDGFC PathHint
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xC46300", Offset = "0xC44F00", VA = "0x180C46300")]
			[CompilerGenerated]
			get
			{
				return default(KJOJFNPDGFC);
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x110F670", Offset = "0x110E270", VA = "0x18110F670")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string ItemPath
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x7309C50", Offset = "0x7308850", VA = "0x187309C50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7309B80", Offset = "0x7308780", VA = "0x187309B80")]
		public static RecNetCDNKey EAOHEECJKMH(string JOKOMAEFOGI, KJOJFNPDGFC DGLOPBNOAPB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7309C00", Offset = "0x7308800", VA = "0x187309C00")]
		public void FLCIMAGEAGD(string NNGJFKMPINB, string DGGBCMIMPNF, bool GKINGPAPDHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public RecNetCDNKey()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[HJLLPMMDIEM]
public class ALKEEKEEKID : LFMBFJBLPIK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	protected readonly List<Mesh> KCHLEJLBNGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	protected readonly List<byte[]> LLEAMPMHLDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	protected readonly List<Matrix4x4> DLGAPPEKLKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	protected readonly List<bool> BLFGGLHBJCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	protected readonly List<int> KPNMLGOKEJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	protected readonly List<bool> EGBMLKCBBGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	protected readonly List<int> MBFGAHAKFOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	protected Allocator PEFJBJOMGDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	protected ABNAKGGCIGD GHCKJBGKPKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	protected byte LIPABFLBGJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	protected IList<int> GPJEGDHLFHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	protected IList<int> BNGCGABFJFD;

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x72F4FE0", Offset = "0x72F3BE0", VA = "0x1872F4FE0", Slot = "4")]
	public void EHELNEBBIJL(Mesh LDLKDBPEDDB, Matrix4x4 JPFDOKKBGAJ, byte[] PPILEPCMECA, bool GEGPLJPEHBM = false, AMLHELBFOLA.MCCCALMIAAN EMDJELIKDIM = (AMLHELBFOLA.MCCCALMIAAN)0, int ABMOOHKGBNI = -1, bool FDIKBOJGENP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x72F4D40", Offset = "0x72F3940", VA = "0x1872F4D40", Slot = "5")]
	public void DFOLJHINGAC(Allocator LNBNGBBFCIG, ABNAKGGCIGD KMFJEABAPAF, byte PEAGCEPBIOD, [Optional] IList<int> FPNCFPCFPOP, [Optional] IList<int> LMHHCDHKGEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x72F4D80", Offset = "0x72F3980", VA = "0x1872F4D80")]
	private static void DGFGOOHBHGO(Mesh LDLKDBPEDDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x72F51F0", Offset = "0x72F3DF0", VA = "0x1872F51F0")]
	public ALKEEKEEKID()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[HJLLPMMDIEM]
public struct HKLDMIHLBIO : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	[ReadOnly]
	public EMCKCEKCFFO BDCBIEOAJPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	[ReadOnly]
	public int JAMNLFBPEHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public PHDKHNOELOF OMMGPDPHJOH;

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7304B70", Offset = "0x7303770", VA = "0x187304B70", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[NativeContainer]
[HJLLPMMDIEM]
public struct PHDKHNOELOF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct KEPKOFLDAIN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public Vector3 BBHBPHKHGPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public Vector3 HKFKAONALCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public Vector4 HKGBGNDLOKM;
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct DBMMCLDIKDK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public float IAFAPGINJLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public float NJPJNGOBNOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public float LLLBNBHMHBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public float GBIHGNMDCED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public byte KBFBDAFJLJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public byte BFBDPJFDKOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public byte MOHBLDHAFIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public byte DKAFAMHMOKG;
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct OPBHDCBOHNC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public half IAFAPGINJLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public half NJPJNGOBNOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public half LLLBNBHMHBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public half GBIHGNMDCED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public byte KBFBDAFJLJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public byte BFBDPJFDKOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public byte MOHBLDHAFIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public byte DKAFAMHMOKG;
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct CNBLKEDKHJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public half4 PFOKHHCFPNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public half2 MCDGIFOKHCK;
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public struct NLMNBLLJGJP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public half4 PFOKHHCFPNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public half2 MCDGIFOKHCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public half2 EHJBJNGBNJJ;
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct NPGBGDDBBKD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public half4 PFOKHHCFPNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public half2 MCDGIFOKHCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public half2 EHJBJNGBNJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public half2 CMONBCCBPPI;
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public struct OPPDKIENGJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public half4 PFOKHHCFPNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public half2 MCDGIFOKHCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public half2 EHJBJNGBNJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public half2 CMONBCCBPPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public half2 AOCKBMMEPCF;
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public struct PJFEAMPPCEL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public float IAFAPGINJLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public float NJPJNGOBNOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public float LLLBNBHMHBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public float GBIHGNMDCED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public int KBFBDAFJLJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public int BFBDPJFDKOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public int MOHBLDHAFIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public int DKAFAMHMOKG;
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public struct GFLNFEONAAO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public Color PFOKHHCFPNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public Vector2 MCDGIFOKHCK;
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public struct BGCJIDMDJJL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public Color PFOKHHCFPNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public Vector2 MCDGIFOKHCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public Vector2 EHJBJNGBNJJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public struct LCNMMKPKGBB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Color PFOKHHCFPNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public Vector2 MCDGIFOKHCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public Vector2 EHJBJNGBNJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Vector2 CMONBCCBPPI;
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public struct CNDPGJCECHF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public Color PFOKHHCFPNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public Vector2 MCDGIFOKHCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public Vector2 EHJBJNGBNJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public Vector2 CMONBCCBPPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public Vector2 AOCKBMMEPCF;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private bool DFPNGBKHNMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public NativeArray<KEPKOFLDAIN> CAAGPECHAPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public NativeArray<CNBLKEDKHJO> DBGMOJMPIKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public NativeArray<NLMNBLLJGJP> GFJAMALAPEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public NativeArray<NPGBGDDBBKD> JDHPBKEEIGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public NativeArray<OPPDKIENGJO> IGODMDECNCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public NativeArray<OPBHDCBOHNC> FEJDFLHJHJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public NativeArray<DBMMCLDIKDK> EOHCHEDOPBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public NativeArray<GFLNFEONAAO> BBAFALKFPOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public NativeArray<BGCJIDMDJJL> ODPMPONMEMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public NativeArray<LCNMMKPKGBB> PKKMLDBHEFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public NativeArray<CNDPGJCECHF> COBCCGNHICE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public NativeArray<PJFEAMPPCEL> KKFBOOMLEGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public NativeArray<int> GHPBPCFJCBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public NativeArray<int> GPMLFBALMAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private NativeArray<int> INEAAKMPFBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private NativeArray<int> HDJHGPAINBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public NativeArray<int> GABMCNKDOJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public NativeArray<int> GGDFMCGACMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public NativeArray<int> DPFFMOJKMHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public NativeArray<BoneWeight> ECDOPKNJNOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private NativeArray<int> KNNHCEBFGKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private bool CHNMMEBCKPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x159")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private bool HCJHBFOPPPA;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int AFGJOGMDBNO
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x7306D40", Offset = "0x7305940", VA = "0x187306D40")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x7306D50", Offset = "0x7305950", VA = "0x187306D50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int CDOEPAJFLMO
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7307FA0", Offset = "0x7306BA0", VA = "0x187307FA0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7308900", Offset = "0x7307500", VA = "0x187308900")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int IMKCGAHELML
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7308110", Offset = "0x7306D10", VA = "0x187308110")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7307FB0", Offset = "0x7306BB0", VA = "0x187307FB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int LPOPOAMPBMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x73080A0", Offset = "0x7306CA0", VA = "0x1873080A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x73090A0", Offset = "0x7307CA0", VA = "0x1873090A0")]
	public PHDKHNOELOF(int KCCIFMGNDOH, int NIANDGCDDCM, int ABKFDEBJCMA, int KCPKBLKNFBO, Allocator LNBNGBBFCIG, int FGFGEBAIILL, OMHFBPEABJI HJEKGNBCHGL, bool CHNMMEBCKPF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7306D60", Offset = "0x7305960", VA = "0x187306D60")]
	public void AOELJFOPABD(int BIEEMEKMINN, Vector3 FABNDDIHAPL, Vector3 MHDGHBLPNDO, Vector4 LDIBCOFKEDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x73084D0", Offset = "0x73070D0", VA = "0x1873084D0")]
	public void NEAKDFHEGMP(int BIEEMEKMINN, BoneWeight IMJJLAEDKLG, NativeSlice<byte> PPILEPCMECA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7308910", Offset = "0x7307510", VA = "0x187308910")]
	public Color PEKFAPHEKAI(int BIEEMEKMINN)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7308C40", Offset = "0x7307840", VA = "0x187308C40")]
	public void PGAOCCPFHBF(int BIEEMEKMINN, Color NFEBCHCLBIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7308120", Offset = "0x7306D20", VA = "0x187308120")]
	public void NBLFAPGGFGB(byte CKLCMMKDCCP, int BIEEMEKMINN, Vector2 AAIOGAHABKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7307FC0", Offset = "0x7306BC0", VA = "0x187307FC0")]
	public void HGIAALMNPIN(int BIEEMEKMINN, int ILJKACIFDFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7309040", Offset = "0x7307C40", VA = "0x187309040")]
	public bool PNAELEDLOAK(int CKLCMMKDCCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7307FD0", Offset = "0x7306BD0", VA = "0x187307FD0")]
	public void JLDIJGHJHPB(int AFHHOBAMLCC, int KKHFKGIPICC, int OKLDJMDCMFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7307D40", Offset = "0x7306940", VA = "0x187307D40", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7306DF0", Offset = "0x73059F0", VA = "0x187306DF0")]
	public Mesh DEPIMNPHGKJ([Optional] string PINOIMCHMKF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[DefaultMember("Item")]
[HJLLPMMDIEM]
[NativeContainer]
public struct EMCKCEKCFFO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public Mesh.MeshDataArray LMBFKHOBICC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public NativeArray<int> IOKBFMNBJLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public NativeArray<int> ANIBDPACKBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public NativeArray<BoneWeight> ECDOPKNJNOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private NativeArray<Matrix4x4> HLMKDILNBDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private NativeArray<int> BCAIPEDGKFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private NativeArray<byte> BGMMNGAAGPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private NativeArray<int> KAKDBELCIIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private NativeArray<int> OHNOPGOIGJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public NativeArray<sbyte> HOBOGPCIIOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public NativeArray<byte> ANMPMLOACJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public NativeArray<bool> FDIKBOJGENP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public NativeArray<int> ABMOOHKGBNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private bool CHNMMEBCKPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private NativeArray<int> MIGPBCIGDFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private bool HCJHBFOPPPA;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int FGALBLNDILH
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x73034C0", Offset = "0x73020C0", VA = "0x1873034C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int DFNNOGMDIIN
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x73034E0", Offset = "0x73020E0", VA = "0x1873034E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int PLHILNPABHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7303740", Offset = "0x7302340", VA = "0x187303740")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int IAMOLHKJDBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x7303460", Offset = "0x7302060", VA = "0x187303460")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x73034D0", Offset = "0x73020D0", VA = "0x1873034D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int AFGJOGMDBNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x73032C0", Offset = "0x7301EC0", VA = "0x1873032C0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x73032D0", Offset = "0x7301ED0", VA = "0x1873032D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public int HGGOOGCNPCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7303470", Offset = "0x7302070", VA = "0x187303470")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x73034A0", Offset = "0x73020A0", VA = "0x1873034A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public ABNAKGGCIGD BAFEHGMCMID
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7303490", Offset = "0x7302090", VA = "0x187303490")]
		get
		{
			return default(ABNAKGGCIGD);
		}
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7303480", Offset = "0x7302080", VA = "0x187303480")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public byte LCHOJOEKNAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x73034B0", Offset = "0x73020B0", VA = "0x1873034B0")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x73032E0", Offset = "0x7301EE0", VA = "0x1873032E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public BDNFIKMDLID MPDHFMNHCEB
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x73034F0", Offset = "0x73020F0", VA = "0x1873034F0")]
		get
		{
			return default(BDNFIKMDLID);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x73038E0", Offset = "0x73024E0", VA = "0x1873038E0")]
	public EMCKCEKCFFO(IList<Mesh> FJNMEBFIEGK, IList<Matrix4x4> PPIGBODLEBL, IList<bool> FDIKBOJGENP, byte PEAGCEPBIOD, IList<byte[]> OACFDBGHBHB, IList<int> ILLNHGBIJON, IList<bool> CCJKFEPIACP, IList<int> ABMOOHKGBNI, IList<int> FPNCFPCFPOP, IList<int> KIAOCHOOBOI, Allocator LNBNGBBFCIG, ABNAKGGCIGD KMFJEABAPAF, bool CHNMMEBCKPF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7303810", Offset = "0x7302410", VA = "0x187303810")]
	public PHDKHNOELOF PFGHLFEDICK(Allocator LNBNGBBFCIG, OMHFBPEABJI HJEKGNBCHGL)
	{
		return default(PHDKHNOELOF);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x73032F0", Offset = "0x7301EF0", VA = "0x1873032F0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[HJLLPMMDIEM]
public class DPLGCLLPPFB : ALKEEKEEKID
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public bool FFMALALOCND;

	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private static readonly ProfilerMarker OKLGHKHAPGB;

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x7302FB0", Offset = "0x7301BB0", VA = "0x187302FB0")]
	public EMCKCEKCFFO JMJIPCCLPBA()
	{
		return default(EMCKCEKCFFO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x73032B0", Offset = "0x7301EB0", VA = "0x1873032B0")]
	public DPLGCLLPPFB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct BDNFIKMDLID
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public Mesh.MeshData BNNEDOBIGOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public NativeSlice<BoneWeight> ECDOPKNJNOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public NativeSlice<byte> MAAIHPBMCOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public int FMENGMDGGPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public Matrix4x4 CHHLEBLMMJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public int LKJFHAKIEND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public NativeSlice<byte> PPILEPCMECA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public bool JIICNKEOCHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public int BFEKBOBMGAO;
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class BIMECJEBEMD : DDHFIFHCKBI
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class IHMAOHOEAHH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public FBHCKABCILC avatarBuildParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public BIMECJEBEMD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public FIJFJANJAHF buildMeshPromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		public Action<KeyValuePair<string, OBLFPJIHAJD<Texture2D>>> <>9__19;

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public IHMAOHOEAHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x73066C0", Offset = "0x73052C0", VA = "0x1873066C0")]
		internal bool AJEKACHADAK(NKBLHOBAPGG item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x73066A0", Offset = "0x73052A0", VA = "0x1873066A0")]
		internal void ENEMGDFLNJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x7306680", Offset = "0x7305280", VA = "0x187306680")]
		internal void CJNOOMJNMIE(string err)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x73066A0", Offset = "0x73052A0", VA = "0x1873066A0")]
		internal void AJBFCBMELEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x7306680", Offset = "0x7305280", VA = "0x187306680")]
		internal void AINFDCLHEMH(string err)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x7306890", Offset = "0x7305490", VA = "0x187306890")]
		internal void KKOPBPJLJOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x7306650", Offset = "0x7305250", VA = "0x187306650")]
		internal void AAPNDHKNPML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x73067D0", Offset = "0x73053D0", VA = "0x1873067D0")]
		internal void GCBFEDLKBLN(Dictionary<string, OBLFPJIHAJD<Texture2D>> resourceHandleDictionary)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x7306710", Offset = "0x7305310", VA = "0x187306710")]
		internal void CKKKNBHKFKH(KeyValuePair<string, OBLFPJIHAJD<Texture2D>> kvp)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x957550", Offset = "0x956150", VA = "0x180957550")]
		internal HAGJNGKFIOK EDGDGMNKCJN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class GIKOEBCBBMM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public int lowestPossibleLOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public IHMAOHOEAHH CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public GIKOEBCBBMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x7304AB0", Offset = "0x73036B0", VA = "0x187304AB0")]
		internal DHNFFNOLOCP LMMMILAHBPP(int lod)
		{
			return default(DHNFFNOLOCP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class PAKPOLIODOH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public JOIICJDLMNO<Dictionary<string, OBLFPJIHAJD<Texture2D>>> ugcTextureDictionaryPromise;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public PAKPOLIODOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x9574F0", Offset = "0x9560F0", VA = "0x1809574F0")]
		internal JOIICJDLMNO<Dictionary<string, OBLFPJIHAJD<Texture2D>>> OMFGJCMMMCP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class PCAOLECEPMA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public List<FIJFJANJAHF> innerPromises;

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public PCAOLECEPMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x7306C10", Offset = "0x7305810", VA = "0x187306C10")]
		internal void OGOHDIIEPLN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class CCBBKACGIBP : IEnumerator<LNKBBFODFEI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		private LNKBBFODFEI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public bool shouldWait;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public BIMECJEBEMD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public List<HMOAKJMFGMN> parts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public List<FIJFJANJAHF> innerPromises;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public int[] LODs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public bool isFirstPerson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public Func<int, DHNFFNOLOCP> getLayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public GMMGHMNCAKG materialPropertyBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public Material materialInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private int <lodIndex>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		private LNKBBFODFEI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x957530", Offset = "0x956130", VA = "0x180957530", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x957530", Offset = "0x956130", VA = "0x180957530", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x958500", Offset = "0x957100", VA = "0x180958500")]
		[DebuggerHidden]
		public CCBBKACGIBP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x7302CE0", Offset = "0x73018E0", VA = "0x187302CE0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x7302F60", Offset = "0x7301B60", VA = "0x187302F60", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class AKLDCGOOJEA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public GMJMLPOPHPE cancelable;

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public AKLDCGOOJEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0xA7D200", Offset = "0xA7BE00", VA = "0x180A7D200")]
		internal void DFJPAABLHEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0xB76DE0", Offset = "0xB759E0", VA = "0x180B76DE0")]
		internal void DGEAJIKPLCH(string err)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class PIPEDFJAOAB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public long jobComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public Stopwatch stopwatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public SkinnedMeshRenderer lodRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public long meshComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public string meshName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public long meshCopyComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public BIMECJEBEMD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public int lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public List<Material> newUniqueMaterials;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public int frameStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public long lodBuildStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public long startCombineBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public long jobScheduled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public Action onFinally;

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public PIPEDFJAOAB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class BHDEHIJNBDM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public bool waitingForComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public JobHandle lodBuildJobHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public PHDKHNOELOF defaultMeshJobContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public EMCKCEKCFFO defaultAvatarMeshJobGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public PIPEDFJAOAB CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public BHDEHIJNBDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x72F6D70", Offset = "0x72F5970", VA = "0x1872F6D70")]
		internal void BNKNEFGGLAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x105BE30", Offset = "0x105AA30", VA = "0x18105BE30")]
		internal void DKAFCFEDJAB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class OIKDDNPEFHC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public bool waitingForComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public JobHandle lodBuildJobHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public LLIFOHNPNBO legacyMeshJobContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public LOCKCLICDIA legacyAvatarMeshJobGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public PIPEDFJAOAB CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public OIKDDNPEFHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x73069D0", Offset = "0x73055D0", VA = "0x1873069D0")]
		internal void DAAEACIIBHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x105DD50", Offset = "0x105C950", VA = "0x18105DD50")]
		internal void DNEGAIFDFLF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class JGGGKDDHKNG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public string overrideItemIdentifier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public MNMFJNIJMID overrideBodyPart;

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public JGGGKDDHKNG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x73068C0", Offset = "0x73054C0", VA = "0x1873068C0")]
		internal bool NJBKCOLLPDH(KeyValuePair<string, NKBLHOBAPGG> entry)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly NCEKLMPIJLO BIMDPDLHMCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly NCEKLMPIJLO MGPLKJJCPGO;

	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private static float IDCLBJMAEIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private AvatarConfiguration IFILDIJKNGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private Transform AGKJJBBBHHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private AvatarSkinAssetItem MLLDFFHKECG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private AssetReference LLEBGNDKEGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private GameObject IOBFGHKKGMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private GameObject HMEDNLPBBOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private SkinnedMeshRenderer OMGALNDKLJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private AvatarSkinnedMeshBoneOrderRemapsData COLPIKKLANG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private Transform[] POLBLBBMGEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private Matrix4x4[] GPEEOCBDAOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private Material BGKOMBDBHHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private Material FHMHHKLMLCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private Material PJBELAPMLKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private Shader GABKGPIDIIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private Shader HJMIEDOEABD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private Animator HOGFOCPDIGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private Renderer[] MDJDDLACGGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private AMLHELBFOLA.MCCCALMIAAN DMILFMLFOBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private AvatarBodyPartShapesManager AMGLCLFPEBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private IReadOnlyDictionary<string, Transform> HNADLNALEEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private AvatarFaceShapeData.KLONBOKOJJP ANDACDNDJML;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private AvatarBodyShapeData.ADDONLGHHMM NNADMCDNJMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private FHEDEKPEKPL NDLFOEPDKLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private bool GHOJNPAFHNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xCD")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private bool KKBOPMNAAJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private Color FEPPEFHJKGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private Color LKGNKBAAHOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private Color KCGIEKGFAOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private Color? KJJKBBCHFCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x114")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private Color? NJKMICNPONC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private Color? JLNIPCCIOOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13C")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private Color? POHICNPMLJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private Texture2D LBIFPBJEOFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private Texture2D EIKHCFBJNNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	[CanBeNull]
	private NKBLHOBAPGG FNIKNCBFNJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private Texture AJKOPAJIHAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private Color BLGKGLEPKNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public Dictionary<Renderer, GMMGHMNCAKG> EJFJLDLBCHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private Dictionary<Renderer, GMMGHMNCAKG> MHBJPHHDFDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private Dictionary<string, List<AAAMBHIPKAC>> IDEIJGMFKGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private Dictionary<string, List<AAAMBHIPKAC>> NIIMPMCAAOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private readonly List<OLBLCJOKKJF> BEAFGAPBDMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private readonly List<OLBLCJOKKJF> GLPOLOKCONJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private readonly List<OLBLCJOKKJF> OMMFEOAAGLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private readonly List<OLBLCJOKKJF> LAIJOIGNODD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private Dictionary<AAAMBHIPKAC, Material> EIPJKHNFKJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private Dictionary<AAAMBHIPKAC, Material> KLOHDHOCGLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private SkinnedMeshRenderer[] KAJLMHBFOID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private SkinnedMeshRenderer[] NLKBDMAHBCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private SkinnedMeshRenderer[] EGJMOLCMJIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private SkinnedMeshRenderer[] JGOIPHGOFGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private readonly Dictionary<string, OBLFPJIHAJD<Texture2D>> GEECABPGIAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private readonly Dictionary<string, OBLFPJIHAJD<Texture2D>> ANMMBHACPNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private PJOLDHGJJNF OLAPBDBHJHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x204")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private PJOLDHGJJNF NCBHOJHCMKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private AdditionalHatData EMOOKLIDJAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private AdditionalHatData HAFEKOLNJMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private HairData FBMHIDJKIPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private HairData PJBNGKBDMBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private IFMFMHOGADG PGHOEAJONID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private bool? KMHKOFIGDNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x234")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private PositionAndRotation GMLKOIECIJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private Transform BJLFHDMACOP;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private Material LFEGFBDCNKC;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private Material GJJNGMJJDJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private Dictionary<string, NKBLHOBAPGG> IGJEMFABHLO;

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private static readonly int FNDMDNOJBCJ;

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private static readonly int FFOMIENPGOE;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private static readonly int ABPHKMIKNPP;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private static readonly int DCNHCJFPIOG;

	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private static readonly int ICDDGAHELPN;

	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private static readonly int EPPFFMPOALO;

	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private static readonly int NBEEDOKANOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private bool NPNIMMMHCOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private List<Action> ADCEOMMKOEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private MIIODELFBFL LIONBNANHJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private SkinnedMeshRenderer[] AIBKAKALDAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private int CBDHCNJKAFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x294")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private bool GGCKNHPCDAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private int MEAENBGLNGK;

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public NCEKLMPIJLO BFENJKEBMMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x9574F0", Offset = "0x9560F0", VA = "0x1809574F0", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public NCEKLMPIJLO AAEDLODNOBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x957530", Offset = "0x956130", VA = "0x180957530", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public AvatarConfiguration ENPPDODKLDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x957550", Offset = "0x956150", VA = "0x180957550", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public bool OIMPENCIHJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x72FD870", Offset = "0x72FC470", VA = "0x1872FD870")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x72F7E20", Offset = "0x72F6A20", VA = "0x1872F7E20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	private Material DBDNLNEJALP
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x72FFBF0", Offset = "0x72FE7F0", VA = "0x1872FFBF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	private Material ECAHOIOPJEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x7300830", Offset = "0x72FF430", VA = "0x187300830")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	private bool CGMPNHKKHIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x9735C0", Offset = "0x9721C0", VA = "0x1809735C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public CDKJOLAGBOC BBAMKKFOGEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xA78B70", Offset = "0xA77770", VA = "0x180A78B70", Slot = "23")]
		get
		{
			return default(CDKJOLAGBOC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public Material NOHFLBCFOJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x963230", Offset = "0x961E30", VA = "0x180963230", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public SkinnedMeshRenderer[] HHNDBAICNPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0xA00A90", Offset = "0x9FF690", VA = "0x180A00A90", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public Renderer[] INEBIGHDKAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0xB8FC30", Offset = "0xB8E830", VA = "0x180B8FC30", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public bool GMJAJFBPHCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x72F8F10", Offset = "0x72F7B10", VA = "0x1872F8F10", Slot = "22")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public AMLHELBFOLA.MCCCALMIAAN AJMBKIOODKC
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x9629A0", Offset = "0x9615A0", VA = "0x1809629A0", Slot = "20")]
		get
		{
			return default(AMLHELBFOLA.MCCCALMIAAN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public int AFJDMEHFJMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x72FD9E0", Offset = "0x72FC5E0", VA = "0x1872FD9E0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x72FAFF0", Offset = "0x72F9BF0", VA = "0x1872FAFF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private bool PMGHJOAJHML
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x72FD960", Offset = "0x72FC560", VA = "0x1872FD960")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	private static bool BEKOFBMAHPE
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x9A1F50", Offset = "0x9A0B50", VA = "0x1809A1F50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7300800", Offset = "0x72FF400", VA = "0x187300800", Slot = "15")]
	public FIJFJANJAHF PFAKOMJBIBO(FBHCKABCILC BCNDMMOCNDB, bool BGMJKGBODOI, int[] JEFKDIBLFBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x72FFA00", Offset = "0x72FE600", VA = "0x1872FFA00", Slot = "14")]
	public FIJFJANJAHF NGABBFLGFMN(FBHCKABCILC BCNDMMOCNDB, bool BGMJKGBODOI, int[] JEFKDIBLFBG, Func<Dictionary<string, NKBLHOBAPGG>, (FIJFJANJAHF, JOIICJDLMNO<Dictionary<string, OBLFPJIHAJD<Texture2D>>>)> CGFJAODOPGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7300920", Offset = "0x72FF520", VA = "0x187300920")]
	public FIJFJANJAHF PKBEAOPKNAA(FBHCKABCILC BCNDMMOCNDB, bool BGMJKGBODOI, int[] JEFKDIBLFBG, bool NOKMEHGDCKA, PJOLDHGJJNF DGNAGMLCJGL, [Optional] Func<Dictionary<string, NKBLHOBAPGG>, (FIJFJANJAHF, JOIICJDLMNO<Dictionary<string, OBLFPJIHAJD<Texture2D>>>)> CGFJAODOPGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x72F8200", Offset = "0x72F6E00", VA = "0x1872F8200")]
	private bool APMCALEPFGN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x72FFDC0", Offset = "0x72FE9C0", VA = "0x1872FFDC0")]
	private FIJFJANJAHF ODEEFBBLNDM(bool BGMJKGBODOI, List<HMOAKJMFGMN> BFBIAOAKNKH, int[] JEFKDIBLFBG, Func<int, DHNFFNOLOCP> HMNNELIFIGP, bool NOKMEHGDCKA = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x72FED00", Offset = "0x72FD900", VA = "0x1872FED00")]
	[IteratorStateMachine(typeof(CCBBKACGIBP))]
	private IEnumerator<LNKBBFODFEI> LOEIJPOPAKH(bool BGMJKGBODOI, List<HMOAKJMFGMN> BFBIAOAKNKH, int[] JEFKDIBLFBG, Func<int, DHNFFNOLOCP> HMNNELIFIGP, GMMGHMNCAKG BIONPCGDGNO, Material JIKIFLJBLEC, List<FIJFJANJAHF> OPDGLLDAEFP, bool OHOHODNFOIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x72FEE20", Offset = "0x72FDA20", VA = "0x1872FEE20")]
	private void LPIEIDNAMEL(List<HMOAKJMFGMN> BFBIAOAKNKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x72FC2D0", Offset = "0x72FAED0", VA = "0x1872FC2D0")]
	private FIJFJANJAHF HLBEGFDFKOD(List<HMOAKJMFGMN> BFBIAOAKNKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x72F9420", Offset = "0x72F8020", VA = "0x1872F9420")]
	private NAEMDCMJKFJ DPDAMLFFDON(List<HMOAKJMFGMN> BFBIAOAKNKH, int IMJJMIHFOFD, bool BGMJKGBODOI, DHNFFNOLOCP ONGOOIJKOLB, bool BCPBKNKDHFH, GMMGHMNCAKG BIONPCGDGNO, Material JIKIFLJBLEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x72FEC40", Offset = "0x72FD840", VA = "0x1872FEC40", Slot = "25")]
	public void LIPDIJDCONK(AvatarFaceShape OKKAHIPLGNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x72F8E50", Offset = "0x72F7A50", VA = "0x1872F8E50", Slot = "26")]
	public void CDALOPEJIOL(AvatarBodyShape PKCJFGCDJGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0xD74740", Offset = "0xD73340", VA = "0x180D74740", Slot = "27")]
	public void NFFADFIPLEC(FHEDEKPEKPL ONBMAEJIILK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x72FD2F0", Offset = "0x72FBEF0", VA = "0x1872FD2F0", Slot = "29")]
	public void IGHOLNBLGNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x72FBFD0", Offset = "0x72FABD0", VA = "0x1872FBFD0", Slot = "32")]
	public void HGOBOJGHGOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x72FFA30", Offset = "0x72FE630", VA = "0x1872FFA30", Slot = "28")]
	public void NGKJHECEFFC(bool MKLNPIDOOHF, bool JLIKANANNGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x72FB700", Offset = "0x72FA300", VA = "0x1872FB700")]
	private void GHMPGBLBBEL(SkinnedMeshRenderer PDKJIOIDLKO, int IMJJMIHFOFD, Mesh LDLKDBPEDDB, List<Material> KCIJJFFCHLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x72F9100", Offset = "0x72F7D00", VA = "0x1872F9100")]
	private static Material CNBJFNKKNAA(Dictionary<AAAMBHIPKAC, Material> AFBLANJNKFB, Material ACMNHGANFGB, CEFKCOLGIKD KILFBEBJIBA, PHCAMDLLKGD FHALJNEGEEC, MNMFJNIJMID PPCPNOAGMNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x72FAAF0", Offset = "0x72F96F0", VA = "0x1872FAAF0")]
	private static CEFKCOLGIKD EFFOMHHPFBD(HMOAKJMFGMN IJKBHHKLGIB, int ACFLBNHOCJE)
	{
		return default(CEFKCOLGIKD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x72FDD00", Offset = "0x72FC900", VA = "0x1872FDD00")]
	private void JLEMCABNGLH(int BKINGOGMOFL, Material LBEFIBKFEIP, HMOAKJMFGMN IJKBHHKLGIB, [Out] Texture2D COHDECKLLCC, [Out] Vector4 ODCKMOJIAPM, [Out] Texture2D HNAHOFMECLP, [Out] Texture2D HHKONJIJDDI, [Out] Texture2D FIJHBHGFKLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x72F8990", Offset = "0x72F7590", VA = "0x1872F8990")]
	private void CBOOHHLGNEN(int BKINGOGMOFL, Material LBEFIBKFEIP, HMOAKJMFGMN IJKBHHKLGIB, [Out] Color FMNFHGKALNC, [Out] Color GIPDLBKFMAH, [Out] Color LPPFDBCOMHH, [Out] Color BKILCAINLKE, [Out] Color IAHCAAHFMKC, [Out] Color EKEIMHEACMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x72FF440", Offset = "0x72FE040", VA = "0x1872FF440")]
	private bool MIHJDHKJJCJ(Material LBEFIBKFEIP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x72FE2F0", Offset = "0x72FCEF0", VA = "0x1872FE2F0")]
	private static Material JPHNILGACGN(int BKINGOGMOFL, KAOCGKMOGLL IJKBHHKLGIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x72FE490", Offset = "0x72FD090", VA = "0x1872FE490")]
	private static PHCAMDLLKGD KDAADNGPLMO(HMOAKJMFGMN IJKBHHKLGIB, int ACFLBNHOCJE)
	{
		return default(PHCAMDLLKGD);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x72FC010", Offset = "0x72FAC10", VA = "0x1872FC010")]
	private static void HICKHOAFMCH(Dictionary<string, List<AAAMBHIPKAC>> LIJANAIJBCD, HMOAKJMFGMN HFFJCCNDJBP, Material ACMNHGANFGB, CEFKCOLGIKD NGKFBOHKKBK, PHCAMDLLKGD HBKFOKHPJHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x72FE9F0", Offset = "0x72FD5F0", VA = "0x1872FE9F0")]
	private static SkinnedMeshRenderer LEAPNNLNLJD(Transform KNPAGANALOK, Transform NEMDELOKMAF, SkinnedMeshRenderer[] DGCLIIOGPDO, int IMJJMIHFOFD, DHNFFNOLOCP ONGOOIJKOLB, bool BGMJKGBODOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7302750", Offset = "0x7301350", VA = "0x187302750")]
	public BIMECJEBEMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x72F77B0", Offset = "0x72F63B0", VA = "0x1872F77B0")]
	public void AIMKJDEKJHN([In] LLKDDMJIILO EDAAFOMBCNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x72F9080", Offset = "0x72F7C80", VA = "0x1872F9080")]
	public void CIKLMOOKNGA([In] KPJLDFNNMPL EOKNBPMAKED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x72FAFF0", Offset = "0x72F9BF0", VA = "0x1872FAFF0", Slot = "5")]
	public void IOOKHFLCEJG(int IMJJMIHFOFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x72FA5B0", Offset = "0x72F91B0", VA = "0x1872FA5B0", Slot = "10")]
	public void EDHPGCLOJBP(OGIEPPBFMDG HBKFOKHPJHJ, Texture2D AIKPMCHDKOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x9735C0", Offset = "0x9721C0", VA = "0x1809735C0")]
	public static bool MIKNFFGNFBG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x72FE110", Offset = "0x72FCD10", VA = "0x1872FE110", Slot = "11")]
	public bool JMGIBJPFNJP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x72FABF0", Offset = "0x72F97F0", VA = "0x1872FABF0", Slot = "9")]
	public void EIDEKJGGHAJ(ABKOOFOCNGG NGKFBOHKKBK, Color? PFOKHHCFPNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x72F75E0", Offset = "0x72F61E0", VA = "0x1872F75E0")]
	private void AFLODEBAPDG(Action BKFONABGGKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x72FE280", Offset = "0x72FCE80", VA = "0x1872FE280", Slot = "6")]
	public void JNCJKIGCLDH(NKBLHOBAPGG KAIJBIHLKGC, Texture FAIDPJNLPOO, Color AEHPAHCLIIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x72F7E20", Offset = "0x72F6A20", VA = "0x1872F7E20", Slot = "7")]
	public void BAMPJLIGBAM(bool OHOHODNFOIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0xA0EF60", Offset = "0xA0DB60", VA = "0x180A0EF60", Slot = "8")]
	public void OCKNIOPNALP(MIIODELFBFL KNNHCEBFGKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x72FF770", Offset = "0x72FE370", VA = "0x1872FF770", Slot = "16")]
	public void NEJOEANMGBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x72F7580", Offset = "0x72F6180", VA = "0x1872F7580", Slot = "30")]
	public void ADJMDCNHOAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x72FC550", Offset = "0x72FB150", VA = "0x1872FC550", Slot = "31")]
	public void IGGNLNDCCFK([Optional] IFMFMHOGADG BFFCFPPKGGI, [Optional] bool? MBEAALPGLPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x72F9290", Offset = "0x72F7E90", VA = "0x1872F9290")]
	private bool DFLBFJHECLD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x72FD400", Offset = "0x72FC000", VA = "0x1872FD400", Slot = "21")]
	public bool ILOJFCKDBHN(AMLHELBFOLA.MCCCALMIAAN APDIJKJLNBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x72F8600", Offset = "0x72F7200", VA = "0x1872F8600")]
	private void BIMFFKJPMHD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x72FD3F0", Offset = "0x72FBFF0", VA = "0x1872FD3F0")]
	private void IKJEDAHPMPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x72FB5A0", Offset = "0x72FA1A0", VA = "0x1872FB5A0")]
	private static void GGGKANFLNBH(Dictionary<AAAMBHIPKAC, Material> AFBLANJNKFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x72FB3D0", Offset = "0x72F9FD0", VA = "0x1872FB3D0")]
	private static void EOEDJEAODCB(Dictionary<Renderer, GMMGHMNCAKG> INDDBACGDPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x72FFA40", Offset = "0x72FE640", VA = "0x1872FFA40")]
	private void NGMMGPIBAJF(SkinnedMeshRenderer[] DGCLIIOGPDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x7302560", Offset = "0x7301160", VA = "0x187302560")]
	private void PMJNHHFOHMJ(SkinnedMeshRenderer FJFJGIGGCON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x72F8420", Offset = "0x72F7020", VA = "0x1872F8420")]
	private void BCDCDDBJEOK(List<OLBLCJOKKJF> FEBGJMGNMMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x72F87C0", Offset = "0x72F73C0", VA = "0x1872F87C0")]
	private void BMHHJEGMNPB(Dictionary<string, OBLFPJIHAJD<Texture2D>> LIJANAIJBCD, bool PEFADKIMGHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x72F93D0", Offset = "0x72F7FD0", VA = "0x1872F93D0")]
	private void DIINOKPFHHN(Dictionary<string, List<AAAMBHIPKAC>> LIJANAIJBCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x72F7660", Offset = "0x72F6260", VA = "0x1872F7660")]
	private void AFPEMILFKBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x72F7B30", Offset = "0x72F6730", VA = "0x1872F7B30")]
	private void AMOEHJOIFGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x72F6FB0", Offset = "0x72F5BB0", VA = "0x1872F6FB0")]
	private void ABKGMFGNHAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x72FD9F0", Offset = "0x72FC5F0", VA = "0x1872FD9F0")]
	private void JHLGKCNEPLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x72F82C0", Offset = "0x72F6EC0", VA = "0x1872F82C0")]
	private void APMNKNPDPMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x72FE340", Offset = "0x72FCF40", VA = "0x1872FE340")]
	private void KBKOABHDBCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x72FF6A0", Offset = "0x72FE2A0", VA = "0x1872FF6A0")]
	private void MMMBPAPDHBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x72FD880", Offset = "0x72FC480", VA = "0x1872FD880")]
	private void JAMALMGJKPK(bool PHOICBBEMHJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x72F8350", Offset = "0x72F6F50", VA = "0x1872F8350")]
	private void BADOKIEGFKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x72FDAC0", Offset = "0x72FC6C0", VA = "0x1872FDAC0")]
	private void JICJNCELJAL(bool PHOICBBEMHJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x72FA7D0", Offset = "0x72F93D0", VA = "0x1872FA7D0")]
	private void EFDGMENINKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x72FBA60", Offset = "0x72FA660", VA = "0x1872FBA60")]
	private void HGEIDNLMNOJ(Material JIKIFLJBLEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x72FE7F0", Offset = "0x72FD3F0", VA = "0x1872FE7F0")]
	private void LDHHKCHCGOG(Material JIKIFLJBLEC, Color OOCNCCDFAMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x7300530", Offset = "0x72FF130", VA = "0x187300530")]
	private void OHEAEIMAPOC(Material JIKIFLJBLEC, Color OOCNCCDFAMF, Color MPODOJJJNHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x73003A0", Offset = "0x72FEFA0", VA = "0x1873003A0")]
	private void OGAGOBCCAEN(Material JIKIFLJBLEC, Color FMNFHGKALNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x72FE570", Offset = "0x72FD170", VA = "0x1872FE570")]
	private void KHDMKDOIMNB(Material JIKIFLJBLEC, Texture2D AIKPMCHDKOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x72FDBA0", Offset = "0x72FC7A0", VA = "0x1872FDBA0")]
	private void JLEFNLLCGMO(Material JIKIFLJBLEC, Texture NPMDMFNLBJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x72F7CC0", Offset = "0x72F68C0", VA = "0x1872F7CC0")]
	private void ANJDDAHGJEA(Action<GMMGHMNCAKG> NDCBLGFCFHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x72FB8D0", Offset = "0x72FA4D0", VA = "0x1872FB8D0")]
	private void HBCHPIEBJIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x72FD450", Offset = "0x72FC050", VA = "0x1872FD450")]
	private void IOEGCKKHIGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x72F7E30", Offset = "0x72F6A30", VA = "0x1872F7E30")]
	private void AOPKPCIGEAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x72FB010", Offset = "0x72F9C10", VA = "0x1872FB010")]
	public void EMIDKOKJNMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x72F9080", Offset = "0x72F7C80", VA = "0x1872F9080", Slot = "4")]
	private void DCBLEACLAGE([In] KPJLDFNNMPL EOKNBPMAKED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x72FB530", Offset = "0x72FA130", VA = "0x1872FB530")]
	[CompilerGenerated]
	private HAGJNGKFIOK FEJFNOKNPGO(HMOAKJMFGMN NKBNDBLIKOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x72FB840", Offset = "0x72FA440", VA = "0x1872FB840")]
	[CompilerGenerated]
	private void GJLPFBLFGEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x72F8960", Offset = "0x72F7560", VA = "0x1872F8960")]
	[CompilerGenerated]
	private void BPBJJKNAFNJ(GMMGHMNCAKG FPEMANHHEDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x72FE960", Offset = "0x72FD560", VA = "0x1872FE960")]
	[CompilerGenerated]
	private void LDNKACHPACG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x72FEC20", Offset = "0x72FD820", VA = "0x1872FEC20")]
	[CompilerGenerated]
	private void LEPADLFONEC(GMMGHMNCAKG FPEMANHHEDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x72FBF40", Offset = "0x72FAB40", VA = "0x1872FBF40")]
	[CompilerGenerated]
	private void HGGBEGMPFOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x72F8940", Offset = "0x72F7540", VA = "0x1872F8940")]
	[CompilerGenerated]
	private void BNDIHHDPHKL(GMMGHMNCAKG FPEMANHHEDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x72FF970", Offset = "0x72FE570", VA = "0x1872FF970")]
	[CompilerGenerated]
	private void NENJNCJOCAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x72FB570", Offset = "0x72FA170", VA = "0x1872FB570")]
	[CompilerGenerated]
	private void FEKIHBEAEGA(GMMGHMNCAKG FPEMANHHEDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x72FFB60", Offset = "0x72FE760", VA = "0x1872FFB60")]
	[CompilerGenerated]
	private void NKGDKFLJFLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x72F9260", Offset = "0x72F7E60", VA = "0x1872F9260")]
	[CompilerGenerated]
	private void DBGKEDLOOFK(GMMGHMNCAKG FPEMANHHEDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x7300770", Offset = "0x72FF370", VA = "0x187300770")]
	[CompilerGenerated]
	private void PEIPBGBJDNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x72FFD90", Offset = "0x72FE990", VA = "0x1872FFD90")]
	[CompilerGenerated]
	private void NKJADBEJELB(GMMGHMNCAKG FPEMANHHEDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x72FE760", Offset = "0x72FD360", VA = "0x1872FE760")]
	[CompilerGenerated]
	private void KMFIEKBGKBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x72FD420", Offset = "0x72FC020", VA = "0x1872FD420")]
	[CompilerGenerated]
	private void IMHKFPOMDJH(GMMGHMNCAKG FPEMANHHEDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x72F7AB0", Offset = "0x72F66B0", VA = "0x1872F7AB0")]
	[CompilerGenerated]
	private void ALBCOFMJPGG(KeyValuePair<string, OBLFPJIHAJD<Texture2D>> CHENLDDPOOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x7302550", Offset = "0x7301150", VA = "0x187302550")]
	[CompilerGenerated]
	private void PLFENNJGDFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x72FB3A0", Offset = "0x72F9FA0", VA = "0x1872FB3A0")]
	[CompilerGenerated]
	private void EODNBIJNNPD(GMMGHMNCAKG FPEMANHHEDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x72FBA50", Offset = "0x72FA650", VA = "0x1872FBA50")]
	[CompilerGenerated]
	private void HBNDJLPEEPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x72FC520", Offset = "0x72FB120", VA = "0x1872FC520")]
	[CompilerGenerated]
	private void HLNHGJHAAHK(GMMGHMNCAKG FPEMANHHEDD)
	{
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class AvatarElbowBendHelperController : MonoBehaviour, LNDEJBPIJIN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		[NEHJBMHDGNH(EGFPEOBPDHA.Self, false, false, false)]
		[SerializeField]
		private Transform ElbowHelperBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		[SerializeField]
		private Transform UpperArmBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		[SerializeField]
		private Transform LowerArmBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		[SerializeField]
		private float MinAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		[SerializeField]
		private float MaxAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		[FormerlySerializedAs("MinScaleValues")]
		[SerializeField]
		[Header("Scale")]
		private Vector3 ScaleValuesAtMinAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		[SerializeField]
		[FormerlySerializedAs("MaxScaleValues")]
		private Vector3 ScaleValuesAtMaxAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		[FormerlySerializedAs("MinLocalPositionalOffset")]
		[Header("Positional Offset")]
		[SerializeField]
		private Vector3 PositionalOffsetAtMinAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		[FormerlySerializedAs("MaxLocalPositionOffset")]
		[SerializeField]
		private Vector3 PositionalOffsetAtMaxAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		private Vector3? LEFKMIHIIJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		private bool NMINJBKFFFC;

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x72F5420", Offset = "0x72F4020", VA = "0x1872F5420", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x72F5A40", Offset = "0x72F4640", VA = "0x1872F5A40", Slot = "4")]
		public void UpdateController(float BLINLOHDAAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0xAEA6A0", Offset = "0xAE92A0", VA = "0x180AEA6A0", Slot = "6")]
		public void SetEnabled(bool MPDLOLIOGJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x72F5500", Offset = "0x72F4100", VA = "0x1872F5500")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x72F5F00", Offset = "0x72F4B00", VA = "0x1872F5F00")]
		public AvatarElbowBendHelperController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class AvatarElbowBendTargetController : MonoBehaviour, LNDEJBPIJIN
	{
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private const float HFGEEOMPLNH = 45f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		[NEHJBMHDGNH(EGFPEOBPDHA.Self, false, false, false)]
		[SerializeField]
		private Transform ElbowBendTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		[SerializeField]
		private Transform NeckBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		[SerializeField]
		private Transform UpperArmBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		[SerializeField]
		private Transform HandBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		[SerializeField]
		private bool Left;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		[SerializeField]
		private float MinTwist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		[SerializeField]
		private float MaxTwist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		[SerializeField]
		private float TwistWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		[SerializeField]
		private float ElbowSmoothTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		[SerializeField]
		private float RestTwist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		[SerializeField]
		private float RestTwistWhenClose;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		[SerializeField]
		private float RestTwistDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private Vector3 GEHGHGKDNFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private Vector3 DJFFHNDLNEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		private bool NMINJBKFFFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		private float NIEOPIOAJDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		private float LKIFCDKLFOK;

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x72F6280", Offset = "0x72F4E80", VA = "0x1872F6280", Slot = "4")]
		public void UpdateController(float BLINLOHDAAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0xF80320", Offset = "0xF7EF20", VA = "0x180F80320", Slot = "6")]
		public void SetEnabled(bool MPDLOLIOGJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x72F5FA0", Offset = "0x72F4BA0", VA = "0x1872F5FA0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x72F6D40", Offset = "0x72F5940", VA = "0x1872F6D40")]
		public AvatarElbowBendTargetController()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class AJJOHEHAHEK : ANLIIOJHHOE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	private static readonly int CBDGMKIJNGJ;

	[Cpp2IlInjected.Token(Token = "0x4000135")]
	private static readonly int OGEKNAAFNJN;

	[Cpp2IlInjected.Token(Token = "0x4000136")]
	private static readonly int BDDGLNDJMOM;

	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private static readonly int IAFKDAGAFJH;

	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private static readonly int ALDCEJLEOPB;

	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private static readonly int FCKEJCKALCK;

	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private static readonly int PKAOKOANMNN;

	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private static readonly int CMFHEINGJLJ;

	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private static readonly int ACNDBHNCFPL;

	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private static readonly int NJFFBPDHBOA;

	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private static readonly int CBNKDAIICFG;

	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private static readonly int MDCDLIJBCMK;

	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private static readonly int FPFFPHHHJLN;

	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private static readonly int OMPFEEPHFMH;

	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private static readonly int BKINAJEEHHG;

	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private static readonly int IKMCFKMCAMK;

	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private static readonly int HGNDIIALPBD;

	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private static readonly int GLGILDGKNMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private Transform LEFHBPBPMHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private Transform IECPFJLPHNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private Transform NIIKMIINBPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private Transform MIJEHBPIHBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private Transform KLIHEECAMBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private Transform FNPKAPABHNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private Transform COBLBIGLFFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private DBHGPPICPLH IBHDKPPEAHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private Material EHEODHMIFNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private SkinnedMeshRenderer[] HDBGIDPBPAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private readonly List<Material> NLCEEJMINBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private KFJGEEEJJOL OIMMGOAKOJO;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public NCEKLMPIJLO EIKKPLNKCME
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x9574F0", Offset = "0x9560F0", VA = "0x1809574F0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	private KFJGEEEJJOL FPDMHIMCPDM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x72F30B0", Offset = "0x72F1CB0", VA = "0x1872F30B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public bool DFIMOLGJAJB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x72F2B10", Offset = "0x72F1710", VA = "0x1872F2B10", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x72F29D0", Offset = "0x72F15D0", VA = "0x1872F29D0")]
	public void AIMKJDEKJHN([In] DBHGPPICPLH OJNCLPOICBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x72F2FD0", Offset = "0x72F1BD0", VA = "0x1872F2FD0")]
	public void EIPMOHGHECF([In] NLJBLJJCGAA JIKKEDAFPKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x72F40E0", Offset = "0x72F2CE0", VA = "0x1872F40E0", Slot = "6")]
	public void JMHIDLKPCKN(EDFLAGCICJA NFAADLDFNLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x72F4080", Offset = "0x72F2C80", VA = "0x1872F4080")]
	private Vector2 JJNKLJLPBAP(Vector2 EDEFCFNIOLD)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x72F3130", Offset = "0x72F1D30", VA = "0x1872F3130")]
	public void IHLDLGIINFM([In] JENANNIHDEK JIKKEDAFPKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x72F2C90", Offset = "0x72F1890", VA = "0x1872F2C90")]
	private void CAIGFAMGICH(DOALEONFJPP NIBHIJBBBBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x72F45B0", Offset = "0x72F31B0", VA = "0x1872F45B0")]
	private void PJOPMHCDFDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x72F2AA0", Offset = "0x72F16A0", VA = "0x1872F2AA0")]
	private void BKDELOCEDLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x72F2AA0", Offset = "0x72F16A0", VA = "0x1872F2AA0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x72F4C40", Offset = "0x72F3840", VA = "0x1872F4C40")]
	public AJJOHEHAHEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x72F2FD0", Offset = "0x72F1BD0", VA = "0x1872F2FD0", Slot = "5")]
	private void ONJFIIEBJIF([In] NLJBLJJCGAA JIKKEDAFPKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x72F45A0", Offset = "0x72F31A0", VA = "0x1872F45A0", Slot = "7")]
	private void MFIDMEIOAFK([In] JENANNIHDEK JIKKEDAFPKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x72F3FF0", Offset = "0x72F2BF0", VA = "0x1872F3FF0")]
	[CompilerGenerated]
	internal static (float, float) IMCOEKHABKH(float CJKDKNPKOFD)
	{
		return default((float, float));
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x72F3070", Offset = "0x72F1C70", VA = "0x1872F3070")]
	[CompilerGenerated]
	internal static Vector4 FNNPLPMHLEG(Vector2 FCININPMBGJ, Vector2 PCNANBOKIPD)
	{
		return default(Vector4);
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class AvatarForearmRollController : MonoBehaviour, LNDEJBPIJIN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		[SerializeField]
		private Transform TwistBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		[SerializeField]
		private Transform HandBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		[SerializeField]
		private Transform LowerArmTwistBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		[SerializeField]
		private Transform UpperArmTwistBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		[SerializeField]
		private Transform ElbowTwistBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		[SerializeField]
		private float RollTowardsWristAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		[SerializeField]
		private float RollSoftMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		[SerializeField]
		private float RollSoftMax;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		[SerializeField]
		private float LowerArmTwistAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		[SerializeField]
		private float UpperArmTwistAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		[SerializeField]
		private float ElbowTwistAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		private float NIEOPIOAJDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private bool NMINJBKFFFC;

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x730A650", Offset = "0x7309250", VA = "0x18730A650", Slot = "4")]
		public void UpdateController(float BLINLOHDAAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x146DC10", Offset = "0x146C810", VA = "0x18146DC10", Slot = "6")]
		public void SetEnabled(bool MPDLOLIOGJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x730B0D0", Offset = "0x7309CD0", VA = "0x18730B0D0")]
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
			[Cpp2IlInjected.Token(Token = "0x4000162")]
			[Tooltip("Name of animation original state to override")]
			public string OriginalName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000163")]
			[Tooltip("Name of animation state to use as an override")]
			public string OverrideName;

			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
			public AnimationOverride()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		[SerializeField]
		private AnimationOverride[] HandStateOverrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		private Dictionary<int, int> _animationOverrides;

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x730B170", Offset = "0x7309D70", VA = "0x18730B170")]
		public void HGFFJCPBDPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x730B100", Offset = "0x7309D00", VA = "0x18730B100")]
		public int BMDCHLHMLAH(int PNFFDAHMKGF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public AvatarHandDisplaySettings()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class EOLPLJIAMOM : FLNHJANMJEF
{
	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x730E0A0", Offset = "0x730CCA0", VA = "0x18730E0A0", Slot = "22")]
	public override float HDHBOMNGJHP()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x730E0F0", Offset = "0x730CCF0", VA = "0x18730E0F0")]
	public EOLPLJIAMOM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class FLNHJANMJEF : FLDOCHEELKL
{
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	private static int BOJJADEKDHC;

	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private static int NNBOMIKHHHO;

	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private static int FBJFJILILKN;

	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private static int FLGFOPJHJFA;

	[Cpp2IlInjected.Token(Token = "0x4000168")]
	private static int POHEMKEEJEB;

	[Cpp2IlInjected.Token(Token = "0x4000169")]
	private static int FJNEIHKOAOP;

	[Cpp2IlInjected.Token(Token = "0x400016A")]
	private static int JLEAHKNNAJO;

	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private static int[] FKOAOMEKIKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	private IIDDHECLHJM IBHDKPPEAHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private EBFIKJABKPH EENGCJMLIPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private int PHFKKLODAIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private float MPCPMPFCHEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	protected Animator HOGFOCPDIGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	protected bool ABHHAJFEDIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	protected AvatarConfiguration HPMJKIGGLMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	protected int LPNOMABNELF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private int OOLMADHBEAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private int BNNEDJGIEDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private bool PFHJDJAEKJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	private BHMEOAFKEML ANCCFCEKIED;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	private int MLEAGLPLMBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	private float NOHKEFJAKMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	private AvatarHandDisplaySettings LOMEAAGILMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	private CDKJOLAGBOC AGPDEGJADHI;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public Transform CFCCKIHCMJL
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x9574F0", Offset = "0x9560F0", VA = "0x1809574F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x957520", Offset = "0x956120", VA = "0x180957520")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public Vector3 KJOJJIJBNBH
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x14501F0", Offset = "0x144EDF0", VA = "0x1814501F0")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x14501E0", Offset = "0x144EDE0", VA = "0x1814501E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public Quaternion KDFPBDLIMKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0xBD4690", Offset = "0xBD3290", VA = "0x180BD4690")]
		[CompilerGenerated]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x1510340", Offset = "0x150EF40", VA = "0x181510340")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool DFAGFABJGKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x730E600", Offset = "0x730D200", VA = "0x18730E600")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x730E5D0", Offset = "0x730D1D0", VA = "0x18730E5D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public Vector3 MJHKJDNBBGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x730E790", Offset = "0x730D390", VA = "0x18730E790", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x730E690", Offset = "0x730D290", VA = "0x18730E690")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public Quaternion OFHFBGBJNGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x730E420", Offset = "0x730D020", VA = "0x18730E420", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x730E9F0", Offset = "0x730D5F0", VA = "0x18730E9F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public PMDBBMEEGON MJMFHMAJFIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0xA48F00", Offset = "0xA47B00", VA = "0x180A48F00", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return default(PMDBBMEEGON);
		}
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0xA48490", Offset = "0xA47090", VA = "0x180A48490", Slot = "4")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public PMDBBMEEGON LKGGFFKDPID
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x21CFAC0", Offset = "0x21CE6C0", VA = "0x1821CFAC0", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return default(PMDBBMEEGON);
		}
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x21CE530", Offset = "0x21CD130", VA = "0x1821CE530", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public float KKINJNDCGKD
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x1294320", Offset = "0x1292F20", VA = "0x181294320", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0xD75000", Offset = "0xD73C00", VA = "0x180D75000", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool LDNDLEGBBCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x730E7B0", Offset = "0x730D3B0", VA = "0x18730E7B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public bool FCMOMNIEEFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x730E410", Offset = "0x730D010", VA = "0x18730E410")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool DHCLIFBAEHM
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x730ED80", Offset = "0x730D980", VA = "0x18730ED80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public bool CPBCDELHMIO
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x730E680", Offset = "0x730D280", VA = "0x18730E680")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x730E430", Offset = "0x730D030", VA = "0x18730E430", Slot = "21")]
	public void AIMKJDEKJHN(IIDDHECLHJM OJNCLPOICBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x730EF10", Offset = "0x730DB10", VA = "0x18730EF10")]
	public void PAFHFKJAMAI(EBFIKJABKPH MIHCMDHLMNK, AvatarHandDisplaySettings DGEAKNFBBOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x730E700", Offset = "0x730D300", VA = "0x18730E700", Slot = "12")]
	public void FKPIMMDMIJF(bool KOGJFECFIAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x730EA00", Offset = "0x730D600", VA = "0x18730EA00", Slot = "11")]
	public void KIJGACDBBKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x1294320", Offset = "0x1292F20", VA = "0x181294320", Slot = "22")]
	public virtual float HDHBOMNGJHP()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x730ED90", Offset = "0x730D990", VA = "0x18730ED90")]
	private int OJLBNMHILKH(PMDBBMEEGON JJAAMJFLMBJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x730E7C0", Offset = "0x730D3C0", VA = "0x18730E7C0")]
	private void GPHDHEKHMOJ(int DPJADBLLPJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x730E9D0", Offset = "0x730D5D0", VA = "0x18730E9D0", Slot = "13")]
	public bool INDHJJPMFAM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x730E6F0", Offset = "0x730D2F0", VA = "0x18730E6F0", Slot = "14")]
	public bool FFHPHLDNJKE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x730E630", Offset = "0x730D230", VA = "0x18730E630")]
	private PMDBBMEEGON BPMFJONAHAK()
	{
		return default(PMDBBMEEGON);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x1B36480", Offset = "0x1B35080", VA = "0x181B36480", Slot = "15")]
	public void DDJCOBGEMJH(bool KOGJFECFIAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x730E6B0", Offset = "0x730D2B0", VA = "0x18730E6B0", Slot = "10")]
	public void EHNJAJDIPEH(int DPJADBLLPJN, float NIGBPFPEKGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x730EF60", Offset = "0x730DB60", VA = "0x18730EF60", Slot = "8")]
	public void PJOIPNNAGOA(BHMEOAFKEML CMPEMMPBPLC, bool LBOHKFHGEJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x730ED70", Offset = "0x730D970", VA = "0x18730ED70", Slot = "9")]
	public void MJNBCMJGCGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x730E980", Offset = "0x730D580", VA = "0x18730E980", Slot = "16")]
	public void IJMIAPIHHHE(Transform KOIBCEOILEL, Vector3 HGHCCCONBNM, Quaternion KAKNFBNMLJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x730F210", Offset = "0x730DE10", VA = "0x18730F210")]
	public FLNHJANMJEF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class KAOCGKMOGLL : HMOAKJMFGMN
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class NECPJPDEADJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		public KAOCGKMOGLL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public List<OLBLCJOKKJF> prefabHandles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		public List<OLBLCJOKKJF> materialHandles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		public OBLFPJIHAJD<Material[]> loadMaterialsHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		public OBLFPJIHAJD<IAPOMOGPFDN> loadPrefabHandle;

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public NECPJPDEADJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x731A370", Offset = "0x7318F70", VA = "0x18731A370")]
		internal HAGJNGKFIOK KEDLGGMFNLH(string error)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	public NKBLHOBAPGG OCFMIKDHLCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	public IAPOMOGPFDN GDHDLODOHPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	private OBLFPJIHAJD<IAPOMOGPFDN> LLPACLKILKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	private OBLFPJIHAJD<Material[]> FHMJGMAJKBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	public Material[] ICBKHGKEDBK;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public bool GDMBCJEAOHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0xC76630", Offset = "0xC75230", VA = "0x180C76630")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0xC764F0", Offset = "0xC750F0", VA = "0x180C764F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public AMLHELBFOLA.MCCCALMIAAN NHGBEOPAMHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0xB0EFA0", Offset = "0xB0DBA0", VA = "0x180B0EFA0")]
		[CompilerGenerated]
		get
		{
			return default(AMLHELBFOLA.MCCCALMIAAN);
		}
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x11ACF20", Offset = "0x11ABB20", VA = "0x1811ACF20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x7315E70", Offset = "0x7314A70", VA = "0x187315E70")]
	public KAOCGKMOGLL(MNMFJNIJMID BMEMNPNGOMO, NKBLHOBAPGG HKPHNIFOEKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x7314B70", Offset = "0x7313770", VA = "0x187314B70", Slot = "6")]
	public override HAGJNGKFIOK BBKIONBPOJF(List<OLBLCJOKKJF> KFICPCNGIBF, List<OLBLCJOKKJF> ABCGFAPJPNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x7315370", Offset = "0x7313F70", VA = "0x187315370")]
	public HAGJNGKFIOK EKCCFBPECEC(List<OLBLCJOKKJF> KFICPCNGIBF, List<OLBLCJOKKJF> ABCGFAPJPNN, OBLFPJIHAJD<Material[]> FHMJGMAJKBM, [Optional] OBLFPJIHAJD<IAPOMOGPFDN> IMILLNAJEHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x7315680", Offset = "0x7314280", VA = "0x187315680")]
	public (OBLFPJIHAJD<Material[]>, OBLFPJIHAJD<IAPOMOGPFDN>) FFMMOCGODNN(List<OLBLCJOKKJF> KFICPCNGIBF, List<OLBLCJOKKJF> ABCGFAPJPNN)
	{
		return default((OBLFPJIHAJD<Material[]>, OBLFPJIHAJD<IAPOMOGPFDN>));
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x7315CD0", Offset = "0x73148D0", VA = "0x187315CD0", Slot = "7")]
	public override FILDODHCCNJ NCGIFKAMMMJ(uint IMJJMIHFOFD, AvatarSkinnedMeshBoneOrderRemapsData FPNAOHNCPOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x7315AC0", Offset = "0x73146C0", VA = "0x187315AC0")]
	public FILDODHCCNJ MEOMOKJKPLP(GameObject LDPAGDKMKCN, uint IMJJMIHFOFD, bool GIPADDIGKOH, bool MKLGCIEDINM, AvatarSkinnedMeshBoneOrderRemapsData FPNAOHNCPOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x7315010", Offset = "0x7313C10", VA = "0x187315010")]
	public static bool EFAFAGDPPOJ(Renderer[] DGCLIIOGPDO, string PFNILIPKFEN, [Out] Renderer PEAFKIHLEKB, [Out] Renderer AFCOAJOBMJE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x7315E20", Offset = "0x7314A20", VA = "0x187315E20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x7315A00", Offset = "0x7314600", VA = "0x187315A00")]
	private (OBLFPJIHAJD<IAPOMOGPFDN>, OBLFPJIHAJD<Material[]>) FPGOKINPPDG()
	{
		return default((OBLFPJIHAJD<IAPOMOGPFDN>, OBLFPJIHAJD<Material[]>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x7315E00", Offset = "0x7314A00", VA = "0x187315E00")]
	[CompilerGenerated]
	private void NHDPAIELDNF(IAPOMOGPFDN HBANOBDOKBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x95EFF0", Offset = "0x95DBF0", VA = "0x18095EFF0")]
	[CompilerGenerated]
	private void EFPDABLDGGI(Material[] HBANOBDOKBJ)
	{
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public class AvatarKneeBendTargetController : MonoBehaviour, LNDEJBPIJIN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		[SerializeField]
		[NEHJBMHDGNH(EGFPEOBPDHA.Self, false, false, false)]
		private Transform KneeBendTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		[SerializeField]
		private Transform RootSpineBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		[SerializeField]
		private Transform ThighBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		[SerializeField]
		private Transform FootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		[SerializeField]
		private float WeightToFootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		[SerializeField]
		private Vector3 BendTargetOffsetFromHipToFootMidPoint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		[SerializeField]
		private Bounds KneeTargetConstrainedBox;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		private Vector3 GEHGHGKDNFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		private Vector3 FMJIEMHCGAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		private Vector3 FOKJPBMGMHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		private Matrix4x4 ILKEGGEIKLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		private bool NMINJBKFFFC;

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x730B700", Offset = "0x730A300", VA = "0x18730B700", Slot = "4")]
		public void UpdateController(float BLINLOHDAAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x730B6F0", Offset = "0x730A2F0", VA = "0x18730B6F0", Slot = "6")]
		public void SetEnabled(bool MPDLOLIOGJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x730B290", Offset = "0x7309E90", VA = "0x18730B290")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x730BDC0", Offset = "0x730A9C0", VA = "0x18730BDC0")]
		public AvatarKneeBendTargetController()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[HJLLPMMDIEM]
public struct LHEGMIMGDGK : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	[ReadOnly]
	public LOCKCLICDIA BDCBIEOAJPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	[ReadOnly]
	public int JAMNLFBPEHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	public LLIFOHNPNBO OMMGPDPHJOH;

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x7315F30", Offset = "0x7314B30", VA = "0x187315F30", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[NativeContainer]
[HJLLPMMDIEM]
public struct LLIFOHNPNBO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	public NativeArray<Vector3> JMNBHJDFIGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	public NativeArray<Vector3> JFHHEEHGGMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	public NativeArray<Vector4> AEJHMBMGGJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	public NativeArray<Vector2> PIBBOBAECIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	public NativeArray<Vector2> CMONBCCBPPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	public NativeArray<Vector2> AOCKBMMEPCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	public NativeArray<Vector2> JOPPFKCCMGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	public NativeArray<Color> LKBCBAGEEDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	public NativeArray<int> GHPBPCFJCBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	public NativeArray<int> GPMLFBALMAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	private NativeArray<int> INEAAKMPFBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	private NativeArray<int> HDJHGPAINBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	public NativeArray<int> GABMCNKDOJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	public NativeArray<int> GGDFMCGACMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	public NativeArray<int> DPFFMOJKMHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	public NativeArray<BoneWeight> FFHNDFMEKIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	private NativeArray<int> KNNHCEBFGKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	private bool HCJHBFOPPPA;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public int AFGJOGMDBNO
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x7316E90", Offset = "0x7315A90", VA = "0x187316E90")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x7316EA0", Offset = "0x7315AA0", VA = "0x187316EA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public int CDOEPAJFLMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x73174D0", Offset = "0x73160D0", VA = "0x1873174D0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x7317860", Offset = "0x7316460", VA = "0x187317860")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public int IMKCGAHELML
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x73175D0", Offset = "0x73161D0", VA = "0x1873175D0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x73174E0", Offset = "0x73160E0", VA = "0x1873174E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x73178E0", Offset = "0x73164E0", VA = "0x1873178E0")]
	public LLIFOHNPNBO(int KCCIFMGNDOH, int NIANDGCDDCM, int ABKFDEBJCMA, int KCPKBLKNFBO, Allocator LNBNGBBFCIG, int FGFGEBAIILL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x7316EB0", Offset = "0x7315AB0", VA = "0x187316EB0")]
	public void AOELJFOPABD(int BIEEMEKMINN, Vector3 FABNDDIHAPL, Vector3 MHDGHBLPNDO, Vector4 LDIBCOFKEDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x7317630", Offset = "0x7316230", VA = "0x187317630")]
	public void NEAKDFHEGMP(int BIEEMEKMINN, BoneWeight IMJJLAEDKLG, NativeSlice<byte> PPILEPCMECA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x7317870", Offset = "0x7316470", VA = "0x187317870")]
	public Color PEKFAPHEKAI(int BIEEMEKMINN)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x7317890", Offset = "0x7316490", VA = "0x187317890")]
	public void PGAOCCPFHBF(int BIEEMEKMINN, Color NFEBCHCLBIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x73175E0", Offset = "0x73161E0", VA = "0x1873175E0")]
	public void NBLFAPGGFGB(byte CKLCMMKDCCP, int BIEEMEKMINN, Vector2 AAIOGAHABKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x73174F0", Offset = "0x73160F0", VA = "0x1873174F0")]
	public void HGIAALMNPIN(int BIEEMEKMINN, int ILJKACIFDFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x73178B0", Offset = "0x73164B0", VA = "0x1873178B0")]
	public bool PNAELEDLOAK(int CKLCMMKDCCP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x7317500", Offset = "0x7316100", VA = "0x187317500")]
	public void JLDIJGHJHPB(int AFHHOBAMLCC, int KKHFKGIPICC, int OKLDJMDCMFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x7316F20", Offset = "0x7315B20", VA = "0x187316F20")]
	public int[] BHCHIFPGKDO(int AFHHOBAMLCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x73177D0", Offset = "0x73163D0", VA = "0x1873177D0")]
	private NativeSlice<int> OLHGDODLGEF(int AFHHOBAMLCC)
	{
		return default(NativeSlice<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x7317320", Offset = "0x7315F20", VA = "0x187317320", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x7316FD0", Offset = "0x7315BD0", VA = "0x187316FD0")]
	public Mesh DEPIMNPHGKJ([Optional] string PINOIMCHMKF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[NativeContainer]
[HJLLPMMDIEM]
[DefaultMember("Item")]
public struct LOCKCLICDIA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	public NativeArray<Vector3> JMNBHJDFIGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	public NativeArray<Vector3> JFHHEEHGGMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	public NativeArray<Vector4> AEJHMBMGGJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	public NativeArray<Vector2> PIBBOBAECIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	public NativeArray<Vector2> CMONBCCBPPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	public NativeArray<Vector2> AOCKBMMEPCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	public NativeArray<Vector2> JOPPFKCCMGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	public NativeArray<Color> LKBCBAGEEDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	public NativeArray<int> FCCDDCADPBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	public NativeArray<int> JACHAICIBAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	public NativeArray<int> CNFMPPPEBJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	public NativeArray<int> CFNBBGJPODL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	public NativeArray<bool> FDIKBOJGENP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	public NativeArray<int> ABMOOHKGBNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	public NativeArray<int> ANIBDPACKBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	public NativeArray<BoneWeight> ECDOPKNJNOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	private NativeArray<Matrix4x4> HLMKDILNBDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	private NativeArray<int> BCAIPEDGKFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	private NativeArray<byte> BGMMNGAAGPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	private NativeArray<int> KAKDBELCIIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	private NativeArray<int> OHNOPGOIGJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	public NativeArray<sbyte> HOBOGPCIIOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	public NativeArray<byte> ANMPMLOACJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	private NativeArray<int> MIGPBCIGDFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	private bool HCJHBFOPPPA;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public int FGALBLNDILH
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x2538D50", Offset = "0x2537950", VA = "0x182538D50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public int DFNNOGMDIIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0xAED610", Offset = "0xAEC210", VA = "0x180AED610")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public int PLHILNPABHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x7318A10", Offset = "0x7317610", VA = "0x187318A10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public int IAMOLHKJDBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x7318480", Offset = "0x7317080", VA = "0x187318480")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x73184E0", Offset = "0x73170E0", VA = "0x1873184E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public int AFGJOGMDBNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x73181F0", Offset = "0x7316DF0", VA = "0x1873181F0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x7318200", Offset = "0x7316E00", VA = "0x187318200")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public int HGGOOGCNPCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x7318490", Offset = "0x7317090", VA = "0x187318490")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x73184C0", Offset = "0x73170C0", VA = "0x1873184C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public ABNAKGGCIGD BAFEHGMCMID
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x73184B0", Offset = "0x73170B0", VA = "0x1873184B0")]
		get
		{
			return default(ABNAKGGCIGD);
		}
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x73184A0", Offset = "0x73170A0", VA = "0x1873184A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public byte LCHOJOEKNAD
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x73184D0", Offset = "0x73170D0", VA = "0x1873184D0")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x7318210", Offset = "0x7316E10", VA = "0x187318210")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public ONODIIKMHAE MPDHFMNHCEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x73184F0", Offset = "0x73170F0", VA = "0x1873184F0")]
		get
		{
			return default(ONODIIKMHAE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x7318B10", Offset = "0x7317710", VA = "0x187318B10")]
	public LOCKCLICDIA(IList<Mesh> FJNMEBFIEGK, IList<Matrix4x4> PPIGBODLEBL, IList<bool> FDIKBOJGENP, byte PEAGCEPBIOD, IList<byte[]> OACFDBGHBHB, IList<int> ILLNHGBIJON, IList<bool> CCJKFEPIACP, IList<int> ABMOOHKGBNI, IList<int> FPNCFPCFPOP, IList<int> KIAOCHOOBOI, Allocator LNBNGBBFCIG, ABNAKGGCIGD KMFJEABAPAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x7318A40", Offset = "0x7317640", VA = "0x187318A40")]
	public LLIFOHNPNBO PFGHLFEDICK(Allocator LNBNGBBFCIG)
	{
		return default(LLIFOHNPNBO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x7318220", Offset = "0x7316E20", VA = "0x187318220", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[HJLLPMMDIEM]
public class EAKFHCLIKDG : ALKEEKEEKID
{
	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x730D6A0", Offset = "0x730C2A0", VA = "0x18730D6A0")]
	public LOCKCLICDIA JMJIPCCLPBA()
	{
		return default(LOCKCLICDIA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x73032B0", Offset = "0x7301EB0", VA = "0x1873032B0")]
	public EAKFHCLIKDG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public struct ONODIIKMHAE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	public NativeSlice<Vector3> JMNBHJDFIGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	public NativeSlice<Vector3> JFHHEEHGGMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	public NativeSlice<Vector4> AEJHMBMGGJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	public NativeSlice<Vector2> PIBBOBAECIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	public NativeSlice<Vector2> CMONBCCBPPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	public NativeSlice<Vector2> AOCKBMMEPCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	public NativeSlice<Vector2> JOPPFKCCMGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	public NativeSlice<Color> LKBCBAGEEDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	public NativeSlice<int> COIHBEFNNPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	public NativeSlice<int> CFNBBGJPODL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	public NativeSlice<BoneWeight> ECDOPKNJNOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	public NativeSlice<byte> MAAIHPBMCOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	public int FMENGMDGGPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	public Matrix4x4 CHHLEBLMMJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	public int LKJFHAKIEND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	public NativeSlice<byte> PPILEPCMECA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	public bool JIICNKEOCHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	public int BFEKBOBMGAO;
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal readonly struct AAAMBHIPKAC : IEquatable<AAAMBHIPKAC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	internal readonly Material IAFLIEJMLFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	internal readonly CEFKCOLGIKD EBLCKIEHAPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	internal readonly PHCAMDLLKGD IJIHEHADKND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	internal readonly MNMFJNIJMID AHLPEEMEPKB;

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x730A610", Offset = "0x7309210", VA = "0x18730A610")]
	public AAAMBHIPKAC(Material LBEFIBKFEIP, CEFKCOLGIKD KILFBEBJIBA, PHCAMDLLKGD FHALJNEGEEC, MNMFJNIJMID PPCPNOAGMNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x730A3E0", Offset = "0x7308FE0", VA = "0x18730A3E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x730A2C0", Offset = "0x7308EC0", VA = "0x18730A2C0", Slot = "4")]
	public bool Equals(AAAMBHIPKAC PELBNOCGOOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x730A1D0", Offset = "0x7308DD0", VA = "0x18730A1D0", Slot = "0")]
	public override bool Equals(object CFMCKCBBBKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x730A340", Offset = "0x7308F40", VA = "0x18730A340", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[DisallowMultipleComponent]
	public class AvatarModernBodyDisplayBehaviour : MonoBehaviour, NGJPFIHJGDI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		[SerializeField]
		[Header("Configuration")]
		protected AvatarConfiguration configuration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		[SerializeField]
		protected Animator skeletonAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		[SerializeField]
		protected Renderer[] watchRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		[Header("Configuration")]
		[SerializeField]
		private CDKJOLAGBOC avatarBodyType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		[SerializeField]
		private AvatarSkinAssetItem potatoAvatarSkinAssetItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		[FormerlySerializedAs("avatarSkinAsset")]
		[SerializeField]
		private AssetReference avatarSkinAssetReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		[SerializeField]
		private GameObject firstPersonMeshContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		[SerializeField]
		public GameObject thirdPersonMeshContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		[SerializeField]
		private GameObject[] hideInFirstPerson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		[SerializeField]
		protected Transform headAdditiveBaseBoneTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		[SerializeField]
		private Material BodyMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		[SerializeField]
		private Material FaceMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		[SerializeField]
		private Material DefaultAvatarItemMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		[SerializeField]
		private Shader AvatarDefaultShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		[SerializeField]
		private Shader AvatarUberShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		[SerializeField]
		private Transform DeformRigRootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		[SerializeField]
		private SkinnedMeshRenderer BaseSkinnedMeshRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		[SerializeField]
		protected AvatarSkinnedMeshBoneOrderRemapsData BoneOrderRemapsData;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		[Header("Arm Animation Controllers")]
		[SerializeField]
		private AvatarForearmRollController LeftForearmRollController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		[SerializeField]
		private AvatarElbowBendHelperController LeftElbowBendHelperController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		[SerializeField]
		private AvatarElbowBendTargetController LeftElbowBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		[SerializeField]
		private AvatarKneeBendTargetController LeftKneeBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		[SerializeField]
		private AvatarForearmRollController RightForearmRollController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		[SerializeField]
		private AvatarElbowBendHelperController RightElbowBendHelperController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		[SerializeField]
		private AvatarElbowBendTargetController RightElbowBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		[SerializeField]
		private AvatarKneeBendTargetController RightKneeBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		[SerializeField]
		private Transform LeftEyeBrowBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		[SerializeField]
		private Transform LeftEyeBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		[SerializeField]
		private Transform RightEyeBrowBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		[SerializeField]
		private Transform RightEyeBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		[SerializeField]
		private Transform NoseMoveTweakBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		[SerializeField]
		private Transform NoseScaleTweakBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		[SerializeField]
		private Transform MouthBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		[SerializeField]
		private AvatarBodyPartShapesManager avatarBodyPartShapesManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		[SerializeField]
		private Transform HeadTweakBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		[SerializeField]
		private Transform HatAnchorBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		[SerializeField]
		private Transform LeftHandWatchAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		[SerializeField]
		private Transform RightHandWatchAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		[SerializeField]
		private GameObject LeftHandWatchVisuals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		[SerializeField]
		private GameObject RightHandWatchVisuals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		private DDHFIFHCKBI EACGEPEHNOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		private ANLIIOJHHOE CPBIJACNNKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		private FLDOCHEELKL NDAPCOAAION;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		private FLDOCHEELKL GFGHCLJABKJ;

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public DDHFIFHCKBI NAONHGPOCOG
		{
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x730CBF0", Offset = "0x730B7F0", VA = "0x18730CBF0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public ANLIIOJHHOE DEKALDBMGOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x730CC40", Offset = "0x730B840", VA = "0x18730CC40", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public FLDOCHEELKL BCHJNJPCBMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0x730CE60", Offset = "0x730BA60", VA = "0x18730CE60", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public FLDOCHEELKL IPBLPMJAFMJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x730CEB0", Offset = "0x730BAB0", VA = "0x18730CEB0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public Transform CHOIPFKKCPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x730CF00", Offset = "0x730BB00", VA = "0x18730CF00", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public CDKJOLAGBOC MLGPOAJKFCJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x966260", Offset = "0x964E60", VA = "0x180966260", Slot = "12")]
			get
			{
				return default(CDKJOLAGBOC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x730BDD0", Offset = "0x730A9D0", VA = "0x18730BDD0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x730CA50", Offset = "0x730B650", VA = "0x18730CA50")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x730C960", Offset = "0x730B560", VA = "0x18730C960", Slot = "8")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x730CA50", Offset = "0x730B650", VA = "0x18730CA50", Slot = "9")]
		public void TeardownAvatarDisplaySystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x730C030", Offset = "0x730AC30", VA = "0x18730C030", Slot = "10")]
		public bool CleanupDisplayMeshes()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x730CB00", Offset = "0x730B700", VA = "0x18730CB00")]
		public void UpdatePostIKAnimControllers(float BLINLOHDAAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x730C9C0", Offset = "0x730B5C0", VA = "0x18730C9C0")]
		private void LEKGGMPLEAE(GameObject CFMCKCBBBKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x730C5F0", Offset = "0x730B1F0", VA = "0x18730C5F0")]
		private DDHFIFHCKBI HGNDHCBGPAI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x730BE40", Offset = "0x730AA40", VA = "0x18730BE40")]
		private ANLIIOJHHOE BLKEFGDKGLC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x730C360", Offset = "0x730AF60", VA = "0x18730C360")]
		private FLDOCHEELKL DOGJCNPOEIA(HMLPHKJFFOG LBDNHDCDGHG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x730CBE0", Offset = "0x730B7E0", VA = "0x18730CBE0")]
		public AvatarModernBodyDisplayBehaviour()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public class GMMGHMNCAKG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000212")]
	private MaterialPropertyBlock PABICGHFCFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000213")]
	public Color? NCIMGLFFOBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000214")]
	public Color? LMAGLCGOOMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000215")]
	public Color? FNKJFOGKNNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000216")]
	public Color? LDPHBNGHKAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000217")]
	public Color PLIBJNMCMBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000218")]
	public Color IHLHCCOCHDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000219")]
	public Color NJCAJDKBCFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400021A")]
	public Texture2D IEDNIINDEDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400021B")]
	public Texture2D KJMOFOJEEKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400021C")]
	private Dictionary<AAAMBHIPKAC, int> LGMIMGGGPIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	private CEFKCOLGIKD[] GPILJAJINLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	private PHCAMDLLKGD[] EIEDANLDAMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	public Vector4[] MEIJCEGHKAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	public Vector4[] IBABNDCCDDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000221")]
	public Vector4[] OJGNCEBOPEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	public Vector4[] OJMCOLMLDHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	public Vector4[] NAAKGFACAEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	public Vector4[] INCDDMIKCEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	private List<Texture2D> ADJHMGPGLOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	private Vector4[] CMMGICCHKHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	private List<Texture2D> ELHLFHPPKKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000228")]
	private float[] NBOJEEAEAGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	private Vector4[] BEOCOOHPIHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	private float[] ADFDLPCMHLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	public float[] IGEIEBGEGEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	private List<Texture2D> PPNABLODFJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	private float[] NOECPNLKGJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	private List<Texture2D> EJEJKGIKBHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	private Vector4[] MENCMBJGOMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	private float[] FHHCHHNHGAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	private Vector4[] INCAHHNBPAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	public float[] NHONBIOECME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	public Texture2DArray KLDLBJAGMPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	public Texture2DArray AEMEOIHIKIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	public Texture2DArray KOGKABPFDGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	public Texture2DArray LPALEAABBBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	private bool PJMIGGNGNKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x184")]
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	private int GMLEFPFKHDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	private Vector2? HJHDFCGHHME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x194")]
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	private TextureFormat PFFJHCJDGPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	private Vector2? LCACJKNBBLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A4")]
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	private TextureFormat LBLMELJEPEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	private Vector2? CCMHABHEEOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B4")]
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	private TextureFormat ANJABLLIPGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	private Vector2? FLAAMHOJOII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C4")]
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	private TextureFormat FAFAHHLBNGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	private bool BPEPOBJKFCM;

	[Cpp2IlInjected.Token(Token = "0x4000242")]
	private static int OBELGHMMHBG;

	[Cpp2IlInjected.Token(Token = "0x4000243")]
	private static int NHPKAALDEPH;

	[Cpp2IlInjected.Token(Token = "0x4000244")]
	private static int HEGBOKPFIEP;

	[Cpp2IlInjected.Token(Token = "0x4000245")]
	private static int JEEMKMMNDDO;

	[Cpp2IlInjected.Token(Token = "0x4000246")]
	private static int MOGBCGNAPEJ;

	[Cpp2IlInjected.Token(Token = "0x4000247")]
	private static int EKOEKNMCOGO;

	[Cpp2IlInjected.Token(Token = "0x4000248")]
	private static int AEFDFMAKGNH;

	[Cpp2IlInjected.Token(Token = "0x4000249")]
	private static int JOPDMJHDAGE;

	[Cpp2IlInjected.Token(Token = "0x400024A")]
	private static int CDCMFNMGMPB;

	[Cpp2IlInjected.Token(Token = "0x400024B")]
	private static int ADGOBDPCBAA;

	[Cpp2IlInjected.Token(Token = "0x400024C")]
	private static int CGKAFELKKMG;

	[Cpp2IlInjected.Token(Token = "0x400024D")]
	private static int IGMFMHHNKFG;

	[Cpp2IlInjected.Token(Token = "0x400024E")]
	private static int JGFNDAPLIJN;

	[Cpp2IlInjected.Token(Token = "0x400024F")]
	private static int CGILKIBAAAP;

	[Cpp2IlInjected.Token(Token = "0x4000250")]
	private static int IOGFEGBFDCO;

	[Cpp2IlInjected.Token(Token = "0x4000251")]
	private static int GPPFLMCFIJN;

	[Cpp2IlInjected.Token(Token = "0x4000252")]
	private static int OEPBPAAGHFE;

	[Cpp2IlInjected.Token(Token = "0x4000253")]
	private static int PDKJDPHNGFJ;

	[Cpp2IlInjected.Token(Token = "0x4000254")]
	private static int BIMKGGOBOOH;

	[Cpp2IlInjected.Token(Token = "0x4000255")]
	private static int IKMEGCNLEBG;

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x7311B30", Offset = "0x7310730", VA = "0x187311B30")]
	private GMMGHMNCAKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x7312020", Offset = "0x7310C20", VA = "0x187312020")]
	public GMMGHMNCAKG(Color AJPMMGMIGAL, Color FKLKMFKEPDO, Color MEOJPBMHJIH, Color? BOKPECBEAPF, Color? EEOADJOOFKC, Color? GENHKKNGDJC, Texture2D BLJHMGGJCJP, Texture2D LLKNILBCPKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x730F9C0", Offset = "0x730E5C0", VA = "0x18730F9C0")]
	internal int GMGKAFOGJFO(Material OEOOBCBFMBO, CEFKCOLGIKD KILFBEBJIBA, PHCAMDLLKGD FHALJNEGEEC, MNMFJNIJMID PPCPNOAGMNJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x730F930", Offset = "0x730E530", VA = "0x18730F930")]
	private int GMGKAFOGJFO(AAAMBHIPKAC NKANGPLHEGE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x73108C0", Offset = "0x730F4C0", VA = "0x1873108C0")]
	internal int IMDGCPPFIKG(Material OEOOBCBFMBO, Color FMNFHGKALNC, Color GIPDLBKFMAH, Color LPPFDBCOMHH, Color BKILCAINLKE, Color IAHCAAHFMKC, Texture2D IAJCLBLDEAJ, Vector4 MIIICJBOEON, Texture2D DDFIBJHPIDK, Vector4 GPDBKNACNEO, float CEBPNAMJKCE, float NDNCAAAMDEE, Texture2D OKCNKNJCKCO, Vector4 AGKEGKHBCBF, float GOOBOLHCJNI, Texture2D KFBHBCGHDCD, Color EKEIMHEACMH, Vector4 JIMCEBNNIKM, CEFKCOLGIKD KILFBEBJIBA, PHCAMDLLKGD FHALJNEGEEC, MNMFJNIJMID PPCPNOAGMNJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x730F520", Offset = "0x730E120", VA = "0x18730F520")]
	private void CMJMBGJPJGC(List<Texture2D> ADJHMGPGLOD, [Out] Texture2DArray NHDJHBOJFDG, [Out] Texture2DArray GIBNGELJGPO, [Out] Texture2DArray IIIALMHAPNP, [Out] Texture2DArray BGCKLLHGGDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x7311690", Offset = "0x7310290", VA = "0x187311690")]
	public void NCKIKIDGHND(Shader PJAGMELINEL, Renderer HHBLCPHFAAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x730FC00", Offset = "0x730E800", VA = "0x18730FC00")]
	private void HMJDINNPEBJ(Shader PJAGMELINEL, Renderer HHBLCPHFAAG, int FDBCPPMIBGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x7311490", Offset = "0x7310090", VA = "0x187311490")]
	private Color NCJBHFBEEPJ(Color COAFLOEFJMP, CEFKCOLGIKD NGKFBOHKKBK)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x730FAB0", Offset = "0x730E6B0", VA = "0x18730FAB0")]
	private Color HLECLHKFEFB(Color BKKCIEJGEAN, CEFKCOLGIKD NGKFBOHKKBK)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x730F6E0", Offset = "0x730E2E0", VA = "0x18730F6E0")]
	private bool DIGJIAOAGKG(Texture2D MDMJIDKLFMF, PHCAMDLLKGD HBKFOKHPJHJ, [Out] Texture2D MKOLMEGPJLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x730F880", Offset = "0x730E480", VA = "0x18730F880")]
	private void ENKOFKJDIMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x730F840", Offset = "0x730E440", VA = "0x18730F840", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public abstract class HMOAKJMFGMN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000259")]
	public readonly MNMFJNIJMID OJIGKNFDJGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400025A")]
	protected bool BEFFFHNLKBK;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public bool AKCGIDNBMAG
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0xB435D0", Offset = "0xB421D0", VA = "0x180B435D0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0xB43A50", Offset = "0xB42650", VA = "0x180B43A50")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public bool KDAGMNOCDFG
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0xB44370", Offset = "0xB42F70", VA = "0x180B44370")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0xB42EC0", Offset = "0xB41AC0", VA = "0x180B42EC0")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public virtual AMLHELBFOLA.MCCCALMIAAN LKJFHAKIEND
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0xA3A0A0", Offset = "0xA38CA0", VA = "0x180A3A0A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(AMLHELBFOLA.MCCCALMIAAN);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0xAFA930", Offset = "0xAF9530", VA = "0x180AFA930", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public bool NFKFLKCONFD
	{
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0xB251F0", Offset = "0xB23DF0", VA = "0x180B251F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public bool DALDOGENKPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x1D7C1F0", Offset = "0x1D7ADF0", VA = "0x181D7C1F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public bool GPNEGIECFCG
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x7312670", Offset = "0x7311270", VA = "0x187312670")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public bool DEBHCNLONHI
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x7312650", Offset = "0x7311250", VA = "0x187312650")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x7312680", Offset = "0x7311280", VA = "0x187312680")]
	protected HMOAKJMFGMN(MNMFJNIJMID BMEMNPNGOMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract HAGJNGKFIOK BBKIONBPOJF(List<OLBLCJOKKJF> KFICPCNGIBF, List<OLBLCJOKKJF> ABCGFAPJPNN);

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract FILDODHCCNJ NCGIFKAMMMJ(uint IMJJMIHFOFD, AvatarSkinnedMeshBoneOrderRemapsData FPNAOHNCPOC);
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class OLGMODFGEJI : EBNKCGIKINE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400025B")]
	private AvatarSkinAssetItem MLLDFFHKECG;

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x731A810", Offset = "0x7319410", VA = "0x18731A810")]
	public OLGMODFGEJI(AvatarSkinAssetItem IGBDOHLNLHG, AvatarSkinAssetItem.OJBEMILLFBP CJJGLNPLAMF, MNMFJNIJMID PPCPNOAGMNJ, [Optional] NLHBBDJJAEA? CHAMFDKKHBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x731A5B0", Offset = "0x73191B0", VA = "0x18731A5B0", Slot = "6")]
	public override HAGJNGKFIOK BBKIONBPOJF(List<OLBLCJOKKJF> KFICPCNGIBF, List<OLBLCJOKKJF> ABCGFAPJPNN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class GHLMCGJJFDJ
{
	[Cpp2IlInjected.Token(Token = "0x400025C")]
	private static readonly int[] GNNBHGECMGE;

	[Cpp2IlInjected.Token(Token = "0x400025D")]
	private static readonly int[] FLGOJALIPHJ;

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public static int[] IDEOCEPKBBN
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x730F2A0", Offset = "0x730DEA0", VA = "0x18730F2A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x730F2F0", Offset = "0x730DEF0", VA = "0x18730F2F0")]
	public static int[] HFMAPOECCBC(bool KKDJHNJJAKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x730F390", Offset = "0x730DF90", VA = "0x18730F390")]
	public static int PCFHJKEFHPD(CKBJHKOEDDL NMFOIJCHPNH, bool KKDJHNJJAKM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x730F290", Offset = "0x730DE90", VA = "0x18730F290")]
	private static int BNGFLKFLCJD(CKBJHKOEDDL NMFOIJCHPNH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x730F370", Offset = "0x730DF70", VA = "0x18730F370")]
	private static int MFPAEFJPPPB(CKBJHKOEDDL NMFOIJCHPNH)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class EIMAODHLPCA
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private sealed class KDKMGJGGALA : IEnumerator<LNKBBFODFEI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400025F")]
		private LNKBBFODFEI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000260")]
		public JobHandle handle;

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		private LNKBBFODFEI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(RVA = "0x957530", Offset = "0x956130", VA = "0x180957530", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001B9")]
			[Cpp2IlInjected.Address(RVA = "0x957530", Offset = "0x956130", VA = "0x180957530", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x958500", Offset = "0x957100", VA = "0x180958500")]
		[DebuggerHidden]
		public KDKMGJGGALA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x1059EC0", Offset = "0x1058AC0", VA = "0x181059EC0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x7315EE0", Offset = "0x7314AE0", VA = "0x187315EE0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0")]
	public static void DMMMBDINDJN(string HGEMPDBGGBJ, int IMJJMIHFOFD, long OAMOKOGAPFD, long LFOPKMEMIKG, long MPMCDELKCCG, long OLCLJGLDONK, long NNOCPCKFOEC, long AEFOMOMBHNN, long HBMLPEDIFOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x730DFB0", Offset = "0x730CBB0", VA = "0x18730DFB0")]
	public static NAEMDCMJKFJ CGFMPMLCHJP(JobHandle LADKMBJCCPK, bool MDEODMAEGJB, bool CGMPNHKKHIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x730DF40", Offset = "0x730CB40", VA = "0x18730DF40")]
	[IteratorStateMachine(typeof(KDKMGJGGALA))]
	private static IEnumerator<LNKBBFODFEI> ABJJGFHDKJB(JobHandle EHNDIPGCOKP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class DCAKIIHBGOM
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public enum NBBJIAJHIMO
	{
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		General,
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		ColoredHair
	}

	[Cpp2IlInjected.Token(Token = "0x4000261")]
	public static readonly int MPMAOKBKOLO;

	[Cpp2IlInjected.Token(Token = "0x4000262")]
	public static readonly int CGJPJLIIGNF;

	[Cpp2IlInjected.Token(Token = "0x4000263")]
	public static readonly int LFAAEAFIAAJ;

	[Cpp2IlInjected.Token(Token = "0x4000264")]
	public static readonly int PHMMFHLFBMA;

	[Cpp2IlInjected.Token(Token = "0x4000265")]
	public static readonly int IGPFGEECIDN;

	[Cpp2IlInjected.Token(Token = "0x4000266")]
	public static readonly int FEBGIGNGIFC;

	[Cpp2IlInjected.Token(Token = "0x4000267")]
	public static readonly int OPNMPOEKHHM;

	[Cpp2IlInjected.Token(Token = "0x4000268")]
	public static readonly int JONLOBICPIA;

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x730D400", Offset = "0x730C000", VA = "0x18730D400")]
	public static bool FCDOIEAKMAI(Material LBEFIBKFEIP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x730D470", Offset = "0x730C070", VA = "0x18730D470")]
	public static bool LHLIKJIOOBF(Material LBEFIBKFEIP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class EBNKCGIKINE : HMOAKJMFGMN
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private sealed class IMHHLHPENBA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		public OBLFPJIHAJD<GameObject> skinAvatarItemPrefabHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		public EBNKCGIKINE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		public Action<string> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public IMHHLHPENBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x7312E30", Offset = "0x7311A30", VA = "0x187312E30")]
		internal void HGHFNEAMHBE(GameObject result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x7313200", Offset = "0x7311E00", VA = "0x187313200")]
		internal void KEDLGGMFNLH(string error)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400026D")]
	protected AvatarSkinAssetItem OMIKBOOEOIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400026E")]
	protected Material[] OBEBJBKIALJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400026F")]
	private readonly AvatarSkinAssetItem.OJBEMILLFBP PFNDIKJPOCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000270")]
	private readonly AssetReference LLEBGNDKEGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000271")]
	private readonly NLHBBDJJAEA? BMKMJCPIOOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000272")]
	private SkinnedMeshRenderer[] CGIJPIBMNIF;

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public override AMLHELBFOLA.MCCCALMIAAN LKJFHAKIEND
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0xA90E00", Offset = "0xA8FA00", VA = "0x180A90E00", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(AMLHELBFOLA.MCCCALMIAAN);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0xB42EE0", Offset = "0xB41AE0", VA = "0x180B42EE0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x730DE10", Offset = "0x730CA10", VA = "0x18730DE10")]
	public EBNKCGIKINE(AvatarSkinAssetItem.OJBEMILLFBP CJJGLNPLAMF, AssetReference BOAIMCNHHCB, Material PDAIHMAIADE, MNMFJNIJMID PPCPNOAGMNJ, AMLHELBFOLA.MCCCALMIAAN AGLHPHGJKJM = (AMLHELBFOLA.MCCCALMIAAN)0, [Optional] NLHBBDJJAEA? CHAMFDKKHBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x730DCF0", Offset = "0x730C8F0", VA = "0x18730DCF0")]
	public EBNKCGIKINE(AvatarSkinAssetItem.OJBEMILLFBP CJJGLNPLAMF, AssetReference BOAIMCNHHCB, Material PDAIHMAIADE, AMLHELBFOLA.MCCCALMIAAN AGLHPHGJKJM = (AMLHELBFOLA.MCCCALMIAAN)0, [Optional] NLHBBDJJAEA? CHAMFDKKHBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x730D790", Offset = "0x730C390", VA = "0x18730D790", Slot = "6")]
	public override HAGJNGKFIOK BBKIONBPOJF(List<OLBLCJOKKJF> KFICPCNGIBF, List<OLBLCJOKKJF> ABCGFAPJPNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x730D9B0", Offset = "0x730C5B0", VA = "0x18730D9B0", Slot = "7")]
	public override FILDODHCCNJ NCGIFKAMMMJ(uint IMJJMIHFOFD, AvatarSkinnedMeshBoneOrderRemapsData FPNAOHNCPOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x730DC80", Offset = "0x730C880", VA = "0x18730DC80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x730D960", Offset = "0x730C560", VA = "0x18730D960")]
	protected void MLHDMJNMPHA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public class JPABGGMNKLE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000276")]
	private List<int> DNGLGAKOBHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000277")]
	private List<LNANGLGPAGE> JGKMAKANJEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000278")]
	private HashSet<Transform> ELKIINCNCHK;

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x73140C0", Offset = "0x7312CC0", VA = "0x1873140C0")]
	public static JPABGGMNKLE DEBGEGLIDJD(Transform LDIBCOFKEDC, Dictionary<Transform, OutfitType?> FHGMHCENAOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x7314780", Offset = "0x7313380", VA = "0x187314780")]
	private void PEOABFHDKPD(Transform LDIBCOFKEDC, MNMFJNIJMID PPCPNOAGMNJ, Dictionary<Transform, OutfitType?> FHGMHCENAOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x7314650", Offset = "0x7313250", VA = "0x187314650")]
	private void HEOABKJAABG(Transform OMDFMLICADD, MNMFJNIJMID PPCPNOAGMNJ, bool COBMNGKOCEA, OutfitType? NMFCBJMEKFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x7314260", Offset = "0x7312E60", VA = "0x187314260")]
	public JFNODEHLLGI DHIHIEKIOGG(HashSet<string> CADJGNJJDBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x7314A40", Offset = "0x7313640", VA = "0x187314A40")]
	public JPABGGMNKLE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public class JFNODEHLLGI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000279")]
	private List<LNANGLGPAGE> JGKMAKANJEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400027A")]
	private List<Matrix4x4> GBAKPFFPLIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400027B")]
	private Transform[] MADHMHEDDGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400027C")]
	private Matrix4x4[] FCDENMAAKNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400027D")]
	private Dictionary<FICLJBAFKAF, int> OLCDOPNEEPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400027E")]
	private List<BCKLGJDAAFC> EMKNFFNIGEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400027F")]
	private bool CAKMKFKFBLE;

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public int PHJGKILIPGP
	{
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x73133B0", Offset = "0x7311FB0", VA = "0x1873133B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public Transform[] FCBCOMEBJDK
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x73133F0", Offset = "0x7311FF0", VA = "0x1873133F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public Matrix4x4[] HODLMFBJBJF
	{
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x7313340", Offset = "0x7311F40", VA = "0x187313340")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x7313880", Offset = "0x7312480", VA = "0x187313880")]
	public void HEOABKJAABG(Transform OMDFMLICADD, MNMFJNIJMID PPCPNOAGMNJ, OutfitType? NMFCBJMEKFG, bool CNEIHBPCFIA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x7313550", Offset = "0x7312150", VA = "0x187313550")]
	private void HEOABKJAABG(Transform OMDFMLICADD, MNMFJNIJMID PPCPNOAGMNJ, OutfitType? NMFCBJMEKFG, bool CNEIHBPCFIA, Matrix4x4 NNAKKKNABDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x7313A70", Offset = "0x7312670", VA = "0x187313A70")]
	public int HHAAMEHIGMH(FICLJBAFKAF NKANGPLHEGE, bool FHHJGHBMPNP, [Optional] OutfitType? NMFCBJMEKFG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x7313E50", Offset = "0x7312A50", VA = "0x187313E50")]
	public int NDEENGLJOMB(MNMFJNIJMID PPCPNOAGMNJ, [Optional] OutfitType? NMFCBJMEKFG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x7313C20", Offset = "0x7312820", VA = "0x187313C20")]
	public void KHBANCFCMFD(FICLJBAFKAF NKANGPLHEGE, Matrix4x4 AGGLCAJPJDP, bool FHHJGHBMPNP = false, [Optional] OutfitType? NMFCBJMEKFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x7313D10", Offset = "0x7312910", VA = "0x187313D10")]
	public Matrix4x4 KLNMHJOGJKC(FICLJBAFKAF NKANGPLHEGE, bool FHHJGHBMPNP, [Optional] OutfitType? NMFCBJMEKFG)
	{
		return default(Matrix4x4);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x11381D0", Offset = "0x1136DD0", VA = "0x1811381D0")]
	public void LLNPMOGHKHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x7313F50", Offset = "0x7312B50", VA = "0x187313F50")]
	public JFNODEHLLGI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public struct FICLJBAFKAF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000283")]
	public readonly string HCEHDDKFHPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000284")]
	public readonly MNMFJNIJMID AHLPEEMEPKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000285")]
	public readonly OutfitType? MHFEBANAEDB;

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x730E3D0", Offset = "0x730CFD0", VA = "0x18730E3D0")]
	public FICLJBAFKAF(string HIPPPGOHLBF, MNMFJNIJMID PPCPNOAGMNJ, [Optional] OutfitType? NMFCBJMEKFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x730E320", Offset = "0x730CF20", VA = "0x18730E320", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x730E260", Offset = "0x730CE60", VA = "0x18730E260")]
	public bool HJJPGDONMOM(FICLJBAFKAF PELBNOCGOOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x730E150", Offset = "0x730CD50", VA = "0x18730E150", Slot = "0")]
	public override bool Equals(object CFMCKCBBBKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x730E200", Offset = "0x730CE00", VA = "0x18730E200", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public struct BCKLGJDAAFC : IEquatable<BCKLGJDAAFC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000286")]
	public readonly MNMFJNIJMID AHLPEEMEPKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000287")]
	public readonly OutfitType? FEIOEGKPBIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000288")]
	public readonly int MDAIDNCKGFN;

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x730D1F0", Offset = "0x730BDF0", VA = "0x18730D1F0")]
	public BCKLGJDAAFC(MNMFJNIJMID PPCPNOAGMNJ, int PJMJMNIPMHD, [Optional] OutfitType? PJOOPPILPPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x730D130", Offset = "0x730BD30", VA = "0x18730D130", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x1ECB340", Offset = "0x1EC9F40", VA = "0x181ECB340")]
	public bool MOEDKGDGCJH(MNMFJNIJMID PPCPNOAGMNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x730CF20", Offset = "0x730BB20", VA = "0x18730CF20")]
	public bool EFHKIBEFEKM(OutfitType? PJOOPPILPPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x730D090", Offset = "0x730BC90", VA = "0x18730D090", Slot = "4")]
	public bool Equals(BCKLGJDAAFC PELBNOCGOOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x730CFA0", Offset = "0x730BBA0", VA = "0x18730CFA0", Slot = "0")]
	public override bool Equals(object CFMCKCBBBKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x730D0E0", Offset = "0x730BCE0", VA = "0x18730D0E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public struct LNANGLGPAGE : IEquatable<LNANGLGPAGE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000289")]
	public readonly Transform JFEMAAOODPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400028A")]
	public readonly bool CMHGLNNBDAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400028B")]
	public readonly MNMFJNIJMID GEBGOHMOAGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400028C")]
	public readonly OutfitType? MHFEBANAEDB;

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x73181B0", Offset = "0x7316DB0", VA = "0x1873181B0")]
	public LNANGLGPAGE(Transform OMDFMLICADD, bool COBMNGKOCEA, MNMFJNIJMID CHAFBPMMGPO, [Optional] OutfitType? ALGKJIOKNIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x7317F90", Offset = "0x7316B90", VA = "0x187317F90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x7317E20", Offset = "0x7316A20", VA = "0x187317E20", Slot = "4")]
	public bool Equals(LNANGLGPAGE PELBNOCGOOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x7317D40", Offset = "0x7316940", VA = "0x187317D40", Slot = "0")]
	public override bool Equals(object CFMCKCBBBKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x7317F20", Offset = "0x7316B20", VA = "0x187317F20", Slot = "2")]
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
		[Cpp2IlInjected.Token(Token = "0x400028D")]
		public const float DEFAULT_Y_POSITION_OFFSET = 0.04f;

		[Cpp2IlInjected.Token(Token = "0x400028E")]
		public const float MAX_HEMISPHERE_POSITION_OFFSET = 0.05f;

		[Cpp2IlInjected.Token(Token = "0x400028F")]
		public const float MAX_HEMISPHERE_ROTATION_OFFSET = 45f;

		[Cpp2IlInjected.Token(Token = "0x4000290")]
		public const float MAX_HEMISPHERE_SCALE = 2f;

		[Cpp2IlInjected.Token(Token = "0x4000291")]
		public const float MIN_HEMISPHERE_SCALE = 0.75f;

		[Cpp2IlInjected.Token(Token = "0x4000292")]
		public const float MAX_HEMISPHERE_RADIUS = 0.25f;

		[Cpp2IlInjected.Token(Token = "0x4000293")]
		public const float MIN_HEMISPHERE_RADIUS = 0.125f;

		[Cpp2IlInjected.Token(Token = "0x4000294")]
		public static GameObject ContainerGO;

		[Cpp2IlInjected.Token(Token = "0x4000295")]
		public static GameObject CurrentHairHemisphereGO;

		[Cpp2IlInjected.Token(Token = "0x4000296")]
		public static Transform CurrentHairHemisphereMeshTransform;

		[Cpp2IlInjected.Token(Token = "0x4000297")]
		public static FitMeshHemisphereUpdater CurrentHairHemisphereUpdater;

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x730F230", Offset = "0x730DE30", VA = "0x18730F230")]
		public static void DespawnHairHemisphere()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0")]
		public void UpdateValues()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x959590", Offset = "0x958190", VA = "0x180959590")]
		public FitMeshHemisphereUpdater()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public interface LFMBFJBLPIK
{
	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EHELNEBBIJL(Mesh LDLKDBPEDDB, Matrix4x4 JPFDOKKBGAJ, byte[] PPILEPCMECA, bool GEGPLJPEHBM = false, AMLHELBFOLA.MCCCALMIAAN EMDJELIKDIM = (AMLHELBFOLA.MCCCALMIAAN)0, int ABMOOHKGBNI = -1, bool FDIKBOJGENP = false);

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DFOLJHINGAC(Allocator LNBNGBBFCIG, ABNAKGGCIGD KMFJEABAPAF, byte PEAGCEPBIOD, [Optional] IList<int> FPNCFPCFPOP, [Optional] IList<int> LMHHCDHKGEH);
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public readonly struct IAPOMOGPFDN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000298")]
	public readonly GameObject LDPAGDKMKCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000299")]
	private readonly AvatarItemMaterial PMODPGACLCJ;

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x9DD890", Offset = "0x9DC490", VA = "0x1809DD890")]
	public IAPOMOGPFDN(GameObject LDPAGDKMKCN, AvatarItemMaterial PMODPGACLCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x73126B0", Offset = "0x73112B0", VA = "0x1873126B0")]
	public void NOIPDMHBFAM(Material LBEFIBKFEIP, int BKINGOGMOFL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public class IGOOINPLLON : ANEOOMKOHBG<Task<(GameObject, AvatarItemMaterial)>, IAPOMOGPFDN>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private struct HHJJEHMJBIB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		public AsyncTaskMethodBuilder<(GameObject, AvatarItemMaterial)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		public Task<GameObject> goTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		public Task<AvatarItemMaterial> materialTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		private GameObject <go>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		private TaskAwaiter<GameObject> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		private TaskAwaiter<AvatarItemMaterial> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x73120E0", Offset = "0x7310CE0", VA = "0x1873120E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x73125E0", Offset = "0x73111E0", VA = "0x1873125E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400029A")]
	private OBLFPJIHAJD<GameObject> IDBOGCBAMPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400029B")]
	private OBLFPJIHAJD<AvatarItemMaterial> CPBNOBIMDLP;

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x7312DA0", Offset = "0x73119A0", VA = "0x187312DA0")]
	private IGOOINPLLON(Task<(GameObject, AvatarItemMaterial)> LFJIOJDNNEN, OBLFPJIHAJD<GameObject> KFNGHENADJI, OBLFPJIHAJD<AvatarItemMaterial> JPBFGLMFHKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x7312870", Offset = "0x7311470", VA = "0x187312870")]
	public static IGOOINPLLON EPPBBCFCJMI(AssetReference OBPEPPACOIG, [Optional] AssetReference PPACKFPCCPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x7312D00", Offset = "0x7311900", VA = "0x187312D00", Slot = "11")]
	protected override IAPOMOGPFDN PIEPOLPLKDF(Task<(GameObject, AvatarItemMaterial)> GOFCIKMELLJ)
	{
		return default(IAPOMOGPFDN);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x7312C80", Offset = "0x7311880", VA = "0x187312C80", Slot = "12")]
	protected override void LDPKOMCCOKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x7312740", Offset = "0x7311340", VA = "0x187312740")]
	[AsyncStateMachine(typeof(HHJJEHMJBIB))]
	private static Task<(GameObject, AvatarItemMaterial)> CMGMJPOBKKN(Task<GameObject> JOEDPFCJNPO, Task<AvatarItemMaterial> JOAHPDBDGEL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class ONAGMPNHIDC
{
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	private class OMLNIEGHLJM : ANEOOMKOHBG<Task<MaterialMapAsset>, Material[]>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		private OBLFPJIHAJD<MaterialMapAsset> EHNDIPGCOKP;

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x731AD90", Offset = "0x7319990", VA = "0x18731AD90")]
		public OMLNIEGHLJM(OBLFPJIHAJD<MaterialMapAsset> EHNDIPGCOKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x731A970", Offset = "0x7319570", VA = "0x18731A970", Slot = "11")]
		protected override Material[] PIEPOLPLKDF(Task<MaterialMapAsset> LFJIOJDNNEN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x731A910", Offset = "0x7319510", VA = "0x18731A910", Slot = "12")]
		protected override void LDPKOMCCOKH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private class CHFPCBNPGCE : ANEOOMKOHBG<Task<Material[]>, Material[]>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		private List<OBLFPJIHAJD<Material>> ICGBHNFFINL;

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x730D390", Offset = "0x730BF90", VA = "0x18730D390")]
		public CHFPCBNPGCE(Task<Material[]> LFJIOJDNNEN, List<OBLFPJIHAJD<Material>> ICGBHNFFINL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x730D340", Offset = "0x730BF40", VA = "0x18730D340", Slot = "11")]
		protected override Material[] PIEPOLPLKDF(Task<Material[]> GOFCIKMELLJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x730D200", Offset = "0x730BE00", VA = "0x18730D200", Slot = "12")]
		protected override void LDPKOMCCOKH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40002A6")]
	private static readonly NDNFAPMFFIF DFFCPCMIFOD;

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x731AE70", Offset = "0x7319A70", VA = "0x18731AE70")]
	public static OBLFPJIHAJD<Material[]> KINPPDBGHJA(AssetReference[] NDJMIPCOFOB)
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
		public enum JFHILDAKNOJ
		{
			[Cpp2IlInjected.Token(Token = "0x4000330")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4000331")]
			TeamItem,
			[Cpp2IlInjected.Token(Token = "0x4000332")]
			SkinColor,
			[Cpp2IlInjected.Token(Token = "0x4000333")]
			HairColor,
			[Cpp2IlInjected.Token(Token = "0x4000334")]
			BeardColor,
			[Cpp2IlInjected.Token(Token = "0x4000335")]
			UGCShirtColor
		}

		[Cpp2IlInjected.Token(Token = "0x2000056")]
		public enum IDFLKBOHAEM
		{
			[Cpp2IlInjected.Token(Token = "0x4000337")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4000338")]
			HairTexture,
			[Cpp2IlInjected.Token(Token = "0x4000339")]
			BeardTexture,
			[Cpp2IlInjected.Token(Token = "0x400033A")]
			UGCShirtTexture
		}

		[Cpp2IlInjected.Token(Token = "0x2000057")]
		public enum NMDGNLLKPPH : byte
		{
			[Cpp2IlInjected.Token(Token = "0x400033C")]
			All,
			[Cpp2IlInjected.Token(Token = "0x400033D")]
			LOD0Only,
			[Cpp2IlInjected.Token(Token = "0x400033E")]
			EditorToolAll
		}

		[Cpp2IlInjected.Token(Token = "0x2000058")]
		public struct PFDEAFPHBIN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400033F")]
			public readonly Material IAFLIEJMLFA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000340")]
			public readonly JFHILDAKNOJ EBLCKIEHAPH;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x4000341")]
			public readonly IDFLKBOHAEM IJIHEHADKND;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000342")]
			public readonly MNMFJNIJMID AHLPEEMEPKB;

			[Cpp2IlInjected.Token(Token = "0x60002CE")]
			[Cpp2IlInjected.Address(RVA = "0x730A610", Offset = "0x7309210", VA = "0x18730A610")]
			public PFDEAFPHBIN(Material LBEFIBKFEIP, JFHILDAKNOJ KILFBEBJIBA, IDFLKBOHAEM FHALJNEGEEC, MNMFJNIJMID PPCPNOAGMNJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002CF")]
			[Cpp2IlInjected.Address(RVA = "0x73313E0", Offset = "0x732FFE0", VA = "0x1873313E0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002D0")]
			[Cpp2IlInjected.Address(RVA = "0x730A2C0", Offset = "0x7308EC0", VA = "0x18730A2C0")]
			public bool HJJPGDONMOM(PFDEAFPHBIN PELBNOCGOOJ)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002D1")]
			[Cpp2IlInjected.Address(RVA = "0x7331250", Offset = "0x732FE50", VA = "0x187331250", Slot = "0")]
			public override bool Equals(object CFMCKCBBBKK)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002D2")]
			[Cpp2IlInjected.Address(RVA = "0x7331340", Offset = "0x732FF40", VA = "0x187331340", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000059")]
		protected struct AGDKLLPDNEC : IComparable<AGDKLLPDNEC>, IEquatable<AGDKLLPDNEC>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000343")]
			public int FOIHAAHBOOG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000344")]
			public PlayerAvatarDisplayBase CNPDCBKGCII;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000345")]
			public IList<GDANPJFMKLK> EOKOHLJAPPL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000346")]
			public AvatarItemBodyType JBPPJGJDFMP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000347")]
			public PJOLDHGJJNF BJLJGJKAACL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000348")]
			public bool EANIKLIDDHE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000349")]
			public int[] JEFKDIBLFBG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400034A")]
			public float EKAHNEHFJDM;

			[Cpp2IlInjected.Token(Token = "0x60002D3")]
			[Cpp2IlInjected.Address(RVA = "0x7329320", Offset = "0x7327F20", VA = "0x187329320", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002D4")]
			[Cpp2IlInjected.Address(RVA = "0x73291C0", Offset = "0x7327DC0", VA = "0x1873291C0", Slot = "4")]
			public int CompareTo(AGDKLLPDNEC PELBNOCGOOJ)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002D5")]
			[Cpp2IlInjected.Address(RVA = "0x73291E0", Offset = "0x7327DE0", VA = "0x1873291E0", Slot = "5")]
			public bool Equals(AGDKLLPDNEC PELBNOCGOOJ)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005A")]
		protected abstract class CNFDEFLBKGE
		{
			[Cpp2IlInjected.Token(Token = "0x200005B")]
			public class LHFIFDBLLJN
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400034E")]
				public readonly Mesh KLEEECCOFDA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400034F")]
				public readonly Material[] EELACFJAFBJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000350")]
				public readonly Transform[] FJEFIADGMOC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000351")]
				public readonly Matrix4x4[] KOLCPCPLNNO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000352")]
				public readonly Transform BKCFKMDOKIO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000353")]
				public readonly bool BBPOILENIBA;

				[Cpp2IlInjected.Token(Token = "0x60002DD")]
				[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
				protected LHFIFDBLLJN()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002DE")]
				[Cpp2IlInjected.Address(RVA = "0x732FDB0", Offset = "0x732E9B0", VA = "0x18732FDB0")]
				public LHFIFDBLLJN(Mesh LDLKDBPEDDB, Material[] DDGBMNHBAJO, bool NLFFPILKMHM, Transform[] JJNNFMINDGB, Transform HNKBIIDLHCB, Matrix4x4[] JIKALBFMKJO)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002DF")]
				[Cpp2IlInjected.Address(RVA = "0x732FC00", Offset = "0x732E800", VA = "0x18732FC00")]
				private LHFIFDBLLJN(SkinnedMeshRenderer FJFJGIGGCON, Material[] ONNNCNPBOOP)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002E0")]
				[Cpp2IlInjected.Address(RVA = "0x732FCC0", Offset = "0x732E8C0", VA = "0x18732FCC0")]
				private LHFIFDBLLJN(MeshRenderer FBBMMBKMCOK, Transform HNKBIIDLHCB, Material[] ONNNCNPBOOP)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002E1")]
				[Cpp2IlInjected.Address(RVA = "0x732F8E0", Offset = "0x732E4E0", VA = "0x18732F8E0")]
				public static LHFIFDBLLJN PEOOCKELHDM(Renderer HHBLCPHFAAG, Material[] ONNNCNPBOOP)
				{
					return null;
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400034B")]
			public readonly MNMFJNIJMID AHLPEEMEPKB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400034C")]
			public readonly Transform KINAFDIFOHI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400034D")]
			public readonly bool MHFILHHIDMP;

			[Cpp2IlInjected.Token(Token = "0x17000086")]
			public virtual bool AKCGIDNBMAG
			{
				[Cpp2IlInjected.Token(Token = "0x60002D6")]
				[Cpp2IlInjected.Address(RVA = "0x9A1F50", Offset = "0x9A0B50", VA = "0x1809A1F50", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000087")]
			public virtual bool KDAGMNOCDFG
			{
				[Cpp2IlInjected.Token(Token = "0x60002D7")]
				[Cpp2IlInjected.Address(RVA = "0x9A1F50", Offset = "0x9A0B50", VA = "0x1809A1F50", Slot = "5")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000088")]
			public virtual AMLHELBFOLA.MCCCALMIAAN LKJFHAKIEND
			{
				[Cpp2IlInjected.Token(Token = "0x60002D8")]
				[Cpp2IlInjected.Address(RVA = "0x9595B0", Offset = "0x9581B0", VA = "0x1809595B0", Slot = "6")]
				get
				{
					return default(AMLHELBFOLA.MCCCALMIAAN);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000089")]
			public bool JIICNKEOCHP
			{
				[Cpp2IlInjected.Token(Token = "0x60002D9")]
				[Cpp2IlInjected.Address(RVA = "0x7329C60", Offset = "0x7328860", VA = "0x187329C60")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002DA")]
			[Cpp2IlInjected.Address(RVA = "0x7329C70", Offset = "0x7328870", VA = "0x187329C70")]
			protected CNFDEFLBKGE(MNMFJNIJMID PPCPNOAGMNJ, Transform HNABPPHJNPO, bool KABJCLOLIMD = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002DB")]
			[Cpp2IlInjected.Address(Slot = "7")]
			public abstract HAGJNGKFIOK BBKIONBPOJF(List<OLBLCJOKKJF> KFICPCNGIBF, List<OLBLCJOKKJF> ABCGFAPJPNN);

			[Cpp2IlInjected.Token(Token = "0x60002DC")]
			[Cpp2IlInjected.Address(Slot = "8")]
			public abstract LHFIFDBLLJN NCGIFKAMMMJ(int IMJJMIHFOFD, PlayerHandBones BDJFOKCNFBF);
		}

		[Cpp2IlInjected.Token(Token = "0x200005C")]
		protected class DJAINMHABBG : CNFDEFLBKGE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000354")]
			protected readonly BodyPartLODs CGIJPIBMNIF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000355")]
			protected readonly Material[] OBEBJBKIALJ;

			[Cpp2IlInjected.Token(Token = "0x60002E2")]
			[Cpp2IlInjected.Address(RVA = "0x732A2C0", Offset = "0x7328EC0", VA = "0x18732A2C0")]
			public DJAINMHABBG(MNMFJNIJMID PPCPNOAGMNJ, BodyPartLODs OBHPPLEICHI, Material PDAIHMAIADE, [Optional] Transform HNABPPHJNPO, bool KABJCLOLIMD = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002E3")]
			[Cpp2IlInjected.Address(RVA = "0x732A000", Offset = "0x7328C00", VA = "0x18732A000", Slot = "7")]
			public override HAGJNGKFIOK BBKIONBPOJF(List<OLBLCJOKKJF> KFICPCNGIBF, List<OLBLCJOKKJF> ABCGFAPJPNN)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002E4")]
			[Cpp2IlInjected.Address(RVA = "0x732A090", Offset = "0x7328C90", VA = "0x18732A090", Slot = "8")]
			public override LHFIFDBLLJN NCGIFKAMMMJ(int IMJJMIHFOFD, PlayerHandBones BDJFOKCNFBF)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002E5")]
			[Cpp2IlInjected.Address(RVA = "0x732A250", Offset = "0x7328E50", VA = "0x18732A250", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005D")]
		protected class PKFMIOPEDND : CNFDEFLBKGE
		{
			[Cpp2IlInjected.Token(Token = "0x1700008A")]
			public override bool AKCGIDNBMAG
			{
				[Cpp2IlInjected.Token(Token = "0x60002E6")]
				[Cpp2IlInjected.Address(RVA = "0x9735C0", Offset = "0x9721C0", VA = "0x1809735C0", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008B")]
			public override bool KDAGMNOCDFG
			{
				[Cpp2IlInjected.Token(Token = "0x60002E7")]
				[Cpp2IlInjected.Address(RVA = "0x73316A0", Offset = "0x73302A0", VA = "0x1873316A0", Slot = "5")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008C")]
			public JGMJCPJCOGN OMFCCEKPEKB
			{
				[Cpp2IlInjected.Token(Token = "0x60002E8")]
				[Cpp2IlInjected.Address(RVA = "0x9574C0", Offset = "0x9560C0", VA = "0x1809574C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60002E9")]
				[Cpp2IlInjected.Address(RVA = "0x957540", Offset = "0x956140", VA = "0x180957540")]
				[CompilerGenerated]
				protected set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002EA")]
			[Cpp2IlInjected.Address(RVA = "0x7331760", Offset = "0x7330360", VA = "0x187331760")]
			public PKFMIOPEDND(MNMFJNIJMID PPCPNOAGMNJ, Transform HNABPPHJNPO, JGMJCPJCOGN AFGAPBEIFIA, bool KABJCLOLIMD = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002EB")]
			[Cpp2IlInjected.Address(RVA = "0x7331610", Offset = "0x7330210", VA = "0x187331610", Slot = "7")]
			public override HAGJNGKFIOK BBKIONBPOJF(List<OLBLCJOKKJF> KFICPCNGIBF, List<OLBLCJOKKJF> ABCGFAPJPNN)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002EC")]
			[Cpp2IlInjected.Address(RVA = "0x9595B0", Offset = "0x9581B0", VA = "0x1809595B0", Slot = "8")]
			public override LHFIFDBLLJN NCGIFKAMMMJ(int IMJJMIHFOFD, PlayerHandBones BDJFOKCNFBF)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002ED")]
			[Cpp2IlInjected.Address(RVA = "0x73316F0", Offset = "0x73302F0", VA = "0x1873316F0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005E")]
		public class LBGJKCLCIHK
		{
			[Cpp2IlInjected.Token(Token = "0x200005F")]
			public enum PJCGBGHKBCL
			{
				[Cpp2IlInjected.Token(Token = "0x4000367")]
				PLAYER_PUPPET,
				[Cpp2IlInjected.Token(Token = "0x4000368")]
				PLAYER_DISPLAY_POSER,
				[Cpp2IlInjected.Token(Token = "0x4000369")]
				PLAYER_HAND,
				[Cpp2IlInjected.Token(Token = "0x400036A")]
				STNMONSTERCOSTUME_OPTION_HIDE_EXCEPT_UI,
				[Cpp2IlInjected.Token(Token = "0x400036B")]
				PLAYER_HAND_POINTING,
				[Cpp2IlInjected.Token(Token = "0x400036C")]
				STNMONSTERCOSTUME_OPTION_ALWAYS_HIDE,
				[Cpp2IlInjected.Token(Token = "0x400036D")]
				EDITOR
			}

			[Cpp2IlInjected.Token(Token = "0x4000357")]
			public static readonly int PGMPLKAMECF;

			[Cpp2IlInjected.Token(Token = "0x4000358")]
			public static readonly int OELJLCCMNOC;

			[Cpp2IlInjected.Token(Token = "0x4000359")]
			public static readonly int COOGDNOOHAP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400035A")]
			protected readonly HMLPHKJFFOG LBDNHDCDGHG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400035B")]
			protected readonly MKBKBOKOBAG DLBKMOKJOHN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400035C")]
			protected readonly Animator LFGNJHJJLEN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400035D")]
			protected readonly Transform AKFGGMPPDHC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400035E")]
			protected readonly Vector3 NEKONMMLPPK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400035F")]
			protected readonly Transform PKLGBMLEGOH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000360")]
			protected readonly Vector3 MCOCNKIHMPN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x4000361")]
			protected bool FOIEFEPHNDD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000362")]
			protected FLDOCHEELKL JHGLHHKJDDL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000363")]
			protected bool INFBAFEBOJG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
			[Cpp2IlInjected.Token(Token = "0x4000364")]
			protected float GHGDKFBLJFK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000365")]
			protected GOPCCLCPPEB<PMDBBMEEGON> OFAPEJJKCNC;

			[Cpp2IlInjected.Token(Token = "0x1700008D")]
			public FLDOCHEELKL KJMMCIEEBKP
			{
				[Cpp2IlInjected.Token(Token = "0x60002EE")]
				[Cpp2IlInjected.Address(RVA = "0x95F010", Offset = "0x95DC10", VA = "0x18095F010")]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60002EF")]
				[Cpp2IlInjected.Address(RVA = "0x95F040", Offset = "0x95DC40", VA = "0x18095F040")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008E")]
			public bool OPKCFGKCFKD
			{
				[Cpp2IlInjected.Token(Token = "0x60002F0")]
				[Cpp2IlInjected.Address(RVA = "0xAA6B20", Offset = "0xAA5720", VA = "0x180AA6B20")]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x60002F1")]
				[Cpp2IlInjected.Address(RVA = "0x732EA30", Offset = "0x732D630", VA = "0x18732EA30")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008F")]
			public bool AHOANMLFJBF
			{
				[Cpp2IlInjected.Token(Token = "0x60002F2")]
				[Cpp2IlInjected.Address(RVA = "0x961670", Offset = "0x960270", VA = "0x180961670")]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x60002F3")]
				[Cpp2IlInjected.Address(RVA = "0x732EB00", Offset = "0x732D700", VA = "0x18732EB00")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000090")]
			public float DKCHPJIEMHI
			{
				[Cpp2IlInjected.Token(Token = "0x60002F4")]
				[Cpp2IlInjected.Address(RVA = "0xB42ED0", Offset = "0xB41AD0", VA = "0x180B42ED0")]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x60002F5")]
				[Cpp2IlInjected.Address(RVA = "0x732E630", Offset = "0x732D230", VA = "0x18732E630")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000091")]
			public PMDBBMEEGON IDKICPMAPGH
			{
				[Cpp2IlInjected.Token(Token = "0x60002F6")]
				[Cpp2IlInjected.Address(RVA = "0x732F010", Offset = "0x732DC10", VA = "0x18732F010")]
				get
				{
					return default(PMDBBMEEGON);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002F7")]
			[Cpp2IlInjected.Address(RVA = "0x732EBD0", Offset = "0x732D7D0", VA = "0x18732EBD0")]
			public bool LCPBNENHBAN(PMDBBMEEGON EECLCJGGEOB, object IKLHDHMJFFL, PJCGBGHKBCL NCDDNNAKJAH)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002F8")]
			[Cpp2IlInjected.Address(RVA = "0x732E930", Offset = "0x732D530", VA = "0x18732E930")]
			public bool FFIOCMLADAO(object IKLHDHMJFFL)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002F9")]
			[Cpp2IlInjected.Address(RVA = "0x732F850", Offset = "0x732E450", VA = "0x18732F850")]
			protected LBGJKCLCIHK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002FA")]
			[Cpp2IlInjected.Address(RVA = "0x732F260", Offset = "0x732DE60", VA = "0x18732F260")]
			public LBGJKCLCIHK(HMLPHKJFFOG LBDNHDCDGHG, FLDOCHEELKL AAAMHFMABPH, Animator LFGNJHJJLEN, Transform AKFGGMPPDHC, Transform PKLGBMLEGOH, Vector3 NEKONMMLPPK, Vector3 MCOCNKIHMPN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002FB")]
			[Cpp2IlInjected.Address(RVA = "0x732E880", Offset = "0x732D480", VA = "0x18732E880")]
			private void DKDDHNNHOMN(ushort JCMHFGKMEIN, ushort NEMNCBIPDLB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002FC")]
			[Cpp2IlInjected.Address(RVA = "0x732EF20", Offset = "0x732DB20", VA = "0x18732EF20")]
			protected void OIJMDHFCOOB(ushort JCMHFGKMEIN, ushort NEMNCBIPDLB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002FD")]
			[Cpp2IlInjected.Address(RVA = "0x732E7C0", Offset = "0x732D3C0", VA = "0x18732E7C0")]
			protected void COGMBLNDJIP(ushort JCMHFGKMEIN, ushort NEMNCBIPDLB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002FE")]
			[Cpp2IlInjected.Address(RVA = "0x732EE00", Offset = "0x732DA00", VA = "0x18732EE00")]
			protected void MNNINKCDPPL(ushort JCMHFGKMEIN, ushort NEMNCBIPDLB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002FF")]
			[Cpp2IlInjected.Address(RVA = "0x732F050", Offset = "0x732DC50", VA = "0x18732F050")]
			protected void OMMKPAJLIFD(ushort JCMHFGKMEIN, ushort NEMNCBIPDLB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000300")]
			[Cpp2IlInjected.Address(RVA = "0x732F160", Offset = "0x732DD60", VA = "0x18732F160")]
			protected void PPOJLHCEINH(ushort JCMHFGKMEIN, ushort NEMNCBIPDLB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000301")]
			[Cpp2IlInjected.Address(RVA = "0x732E770", Offset = "0x732D370", VA = "0x18732E770")]
			protected void CFOEAJAFIFM(ushort JCMHFGKMEIN, ushort NEMNCBIPDLB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000302")]
			[Cpp2IlInjected.Address(RVA = "0x732E5E0", Offset = "0x732D1E0", VA = "0x18732E5E0")]
			protected void AGOMOJNAFMF(ushort JCMHFGKMEIN, ushort NEMNCBIPDLB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000303")]
			[Cpp2IlInjected.Address(RVA = "0x732ECE0", Offset = "0x732D8E0", VA = "0x18732ECE0")]
			protected void LPHJFPHFBDO(ushort JCMHFGKMEIN, ushort NEMNCBIPDLB)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000060")]
		public class JBNLFNAALJB : IDisposable
		{
			[Cpp2IlInjected.Token(Token = "0x400036E")]
			public const int DCMFDKBEENA = 16;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400036F")]
			protected MaterialPropertyBlock PABICGHFCFH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000370")]
			public Color? NCIMGLFFOBC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000371")]
			public Color? FNKJFOGKNNB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000372")]
			public Color? LDPHBNGHKAA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x4000373")]
			public Color PLIBJNMCMBC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
			[Cpp2IlInjected.Token(Token = "0x4000374")]
			public Color IHLHCCOCHDO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
			[Cpp2IlInjected.Token(Token = "0x4000375")]
			public Color NJCAJDKBCFK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x4000376")]
			public Texture2D IEDNIINDEDB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x4000377")]
			public Texture2D KJMOFOJEEKJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x4000378")]
			protected Dictionary<PFDEAFPHBIN, int> LGMIMGGGPIJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x4000379")]
			protected JFHILDAKNOJ[] GPILJAJINLA;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x400037A")]
			public Vector4[] MEIJCEGHKAA;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x400037B")]
			public Vector4[] IBABNDCCDDA;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x400037C")]
			public Vector4[] OJGNCEBOPEJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x400037D")]
			public Vector4[] OJMCOLMLDHC;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
			[Cpp2IlInjected.Token(Token = "0x400037E")]
			public Vector4[] NAAKGFACAEL;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
			[Cpp2IlInjected.Token(Token = "0x400037F")]
			public Vector4[] INCDDMIKCEB;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000380")]
			protected List<Texture2D> ADJHMGPGLOD;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000381")]
			protected Vector4[] CMMGICCHKHA;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
			[Cpp2IlInjected.Token(Token = "0x4000382")]
			protected List<Texture2D> ELHLFHPPKKH;

			[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
			[Cpp2IlInjected.Token(Token = "0x4000383")]
			protected float[] NBOJEEAEAGF;

			[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
			[Cpp2IlInjected.Token(Token = "0x4000384")]
			protected Vector4[] BEOCOOHPIHM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
			[Cpp2IlInjected.Token(Token = "0x4000385")]
			protected float[] ADFDLPCMHLP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
			[Cpp2IlInjected.Token(Token = "0x4000386")]
			public float[] IGEIEBGEGEG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
			[Cpp2IlInjected.Token(Token = "0x4000387")]
			protected List<Texture2D> PPNABLODFJO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
			[Cpp2IlInjected.Token(Token = "0x4000388")]
			protected float[] NOECPNLKGJF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
			[Cpp2IlInjected.Token(Token = "0x4000389")]
			protected List<Texture2D> EJEJKGIKBHF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
			[Cpp2IlInjected.Token(Token = "0x400038A")]
			protected Vector4[] MENCMBJGOMB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
			[Cpp2IlInjected.Token(Token = "0x400038B")]
			protected float[] FHHCHHNHGAJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
			[Cpp2IlInjected.Token(Token = "0x400038C")]
			protected Vector4[] INCAHHNBPAH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
			[Cpp2IlInjected.Token(Token = "0x400038D")]
			public float[] NHONBIOECME;

			[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
			[Cpp2IlInjected.Token(Token = "0x400038E")]
			public Texture2DArray KLDLBJAGMPL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
			[Cpp2IlInjected.Token(Token = "0x400038F")]
			public Texture2DArray AEMEOIHIKIL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
			[Cpp2IlInjected.Token(Token = "0x4000390")]
			public Texture2DArray KOGKABPFDGG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
			[Cpp2IlInjected.Token(Token = "0x4000391")]
			public Texture2DArray LPALEAABBBM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
			[Cpp2IlInjected.Token(Token = "0x4000392")]
			protected bool PJMIGGNGNKO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x16C")]
			[Cpp2IlInjected.Token(Token = "0x4000393")]
			protected int GMLEFPFKHDK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
			[Cpp2IlInjected.Token(Token = "0x4000394")]
			protected Vector2? HJHDFCGHHME;

			[Cpp2IlInjected.FieldOffset(Offset = "0x17C")]
			[Cpp2IlInjected.Token(Token = "0x4000395")]
			protected TextureFormat PFFJHCJDGPN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
			[Cpp2IlInjected.Token(Token = "0x4000396")]
			protected Vector2? LCACJKNBBLI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18C")]
			[Cpp2IlInjected.Token(Token = "0x4000397")]
			protected TextureFormat LBLMELJEPEK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
			[Cpp2IlInjected.Token(Token = "0x4000398")]
			protected Vector2? CCMHABHEEOF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x19C")]
			[Cpp2IlInjected.Token(Token = "0x4000399")]
			protected TextureFormat ANJABLLIPGF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
			[Cpp2IlInjected.Token(Token = "0x400039A")]
			protected Vector2? FLAAMHOJOII;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1AC")]
			[Cpp2IlInjected.Token(Token = "0x400039B")]
			protected TextureFormat FAFAHHLBNGE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
			[Cpp2IlInjected.Token(Token = "0x400039C")]
			protected bool BPEPOBJKFCM;

			[Cpp2IlInjected.Token(Token = "0x400039D")]
			protected static int OBELGHMMHBG;

			[Cpp2IlInjected.Token(Token = "0x400039E")]
			protected static int NHPKAALDEPH;

			[Cpp2IlInjected.Token(Token = "0x400039F")]
			protected static int HEGBOKPFIEP;

			[Cpp2IlInjected.Token(Token = "0x40003A0")]
			protected static int JEEMKMMNDDO;

			[Cpp2IlInjected.Token(Token = "0x40003A1")]
			protected static int MOGBCGNAPEJ;

			[Cpp2IlInjected.Token(Token = "0x40003A2")]
			protected static int EKOEKNMCOGO;

			[Cpp2IlInjected.Token(Token = "0x40003A3")]
			protected static int AEFDFMAKGNH;

			[Cpp2IlInjected.Token(Token = "0x40003A4")]
			protected static int JOPDMJHDAGE;

			[Cpp2IlInjected.Token(Token = "0x40003A5")]
			protected static int CDCMFNMGMPB;

			[Cpp2IlInjected.Token(Token = "0x40003A6")]
			protected static int ADGOBDPCBAA;

			[Cpp2IlInjected.Token(Token = "0x40003A7")]
			protected static int CGKAFELKKMG;

			[Cpp2IlInjected.Token(Token = "0x40003A8")]
			protected static int IGMFMHHNKFG;

			[Cpp2IlInjected.Token(Token = "0x40003A9")]
			protected static int JGFNDAPLIJN;

			[Cpp2IlInjected.Token(Token = "0x40003AA")]
			protected static int CGILKIBAAAP;

			[Cpp2IlInjected.Token(Token = "0x40003AB")]
			protected static int IOGFEGBFDCO;

			[Cpp2IlInjected.Token(Token = "0x40003AC")]
			protected static int GPPFLMCFIJN;

			[Cpp2IlInjected.Token(Token = "0x40003AD")]
			protected static int OEPBPAAGHFE;

			[Cpp2IlInjected.Token(Token = "0x40003AE")]
			protected static int PDKJDPHNGFJ;

			[Cpp2IlInjected.Token(Token = "0x40003AF")]
			protected static int BIMKGGOBOOH;

			[Cpp2IlInjected.Token(Token = "0x40003B0")]
			protected static int IKMEGCNLEBG;

			[Cpp2IlInjected.Token(Token = "0x6000305")]
			[Cpp2IlInjected.Address(RVA = "0x732DC70", Offset = "0x732C870", VA = "0x18732DC70")]
			protected JBNLFNAALJB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000306")]
			[Cpp2IlInjected.Address(RVA = "0x732E130", Offset = "0x732CD30", VA = "0x18732E130")]
			public JBNLFNAALJB(Color AJPMMGMIGAL, Color FKLKMFKEPDO, Color MEOJPBMHJIH, Color? BOKPECBEAPF, Color? EEOADJOOFKC, Color? GENHKKNGDJC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000307")]
			[Cpp2IlInjected.Address(RVA = "0x732BC00", Offset = "0x732A800", VA = "0x18732BC00")]
			public int GMGKAFOGJFO(Material OEOOBCBFMBO, JFHILDAKNOJ KILFBEBJIBA, IDFLKBOHAEM FHALJNEGEEC, MNMFJNIJMID PPCPNOAGMNJ)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000308")]
			[Cpp2IlInjected.Address(RVA = "0x732BB70", Offset = "0x732A770", VA = "0x18732BB70")]
			public int GMGKAFOGJFO(PFDEAFPHBIN NKANGPLHEGE)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000309")]
			[Cpp2IlInjected.Address(RVA = "0x732C7E0", Offset = "0x732B3E0", VA = "0x18732C7E0")]
			public int IMDGCPPFIKG(Material OEOOBCBFMBO, Color FMNFHGKALNC, Color GIPDLBKFMAH, Color LPPFDBCOMHH, Color BKILCAINLKE, Color IAHCAAHFMKC, Texture2D IAJCLBLDEAJ, Vector4 MIIICJBOEON, Texture2D DDFIBJHPIDK, Vector4 GPDBKNACNEO, float CEBPNAMJKCE, float NDNCAAAMDEE, Texture2D OKCNKNJCKCO, Vector4 AGKEGKHBCBF, float GOOBOLHCJNI, Texture2D KFBHBCGHDCD, float OGCCDCDPLPL, Color EKEIMHEACMH, Vector4 JIMCEBNNIKM, JFHILDAKNOJ KILFBEBJIBA, IDFLKBOHAEM FHALJNEGEEC, MNMFJNIJMID PPCPNOAGMNJ)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600030A")]
			[Cpp2IlInjected.Address(RVA = "0x732B790", Offset = "0x732A390", VA = "0x18732B790")]
			protected void CMJMBGJPJGC([Out] Texture2DArray NHDJHBOJFDG, [Out] Texture2DArray GIBNGELJGPO, [Out] Texture2DArray IIIALMHAPNP, [Out] Texture2DArray BGCKLLHGGDE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600030B")]
			[Cpp2IlInjected.Address(RVA = "0x732D6C0", Offset = "0x732C2C0", VA = "0x18732D6C0")]
			public void NCKIKIDGHND(PlayerAvatarDisplayBase JGCKKIGKPBG, Renderer HHBLCPHFAAG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600030C")]
			[Cpp2IlInjected.Address(RVA = "0x732BCF0", Offset = "0x732A8F0", VA = "0x18732BCF0")]
			protected void HMJDINNPEBJ(PlayerAvatarDisplayBase JGCKKIGKPBG, Renderer HHBLCPHFAAG, int FDBCPPMIBGE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600030D")]
			[Cpp2IlInjected.Address(RVA = "0x732D4D0", Offset = "0x732C0D0", VA = "0x18732D4D0")]
			private Color NCJBHFBEEPJ(Color COAFLOEFJMP, JFHILDAKNOJ NGKFBOHKKBK)
			{
				return default(Color);
			}

			[Cpp2IlInjected.Token(Token = "0x600030E")]
			[Cpp2IlInjected.Address(RVA = "0x732BA20", Offset = "0x732A620", VA = "0x18732BA20")]
			private Color ENONBGMLODL(Color FKNPOJMLLON, JFHILDAKNOJ NGKFBOHKKBK)
			{
				return default(Color);
			}

			[Cpp2IlInjected.Token(Token = "0x600030F")]
			[Cpp2IlInjected.Address(RVA = "0x732B990", Offset = "0x732A590", VA = "0x18732B990")]
			protected void ENKOFKJDIMM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000310")]
			[Cpp2IlInjected.Address(RVA = "0x732B950", Offset = "0x732A550", VA = "0x18732B950", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000061")]
		public struct PlayerHandBones
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003B1")]
			public Transform[] LeftHandBones;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003B2")]
			public Transform LeftHandRoot;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003B3")]
			public Transform[] RightHandBones;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003B4")]
			public Transform RightHandRoot;

			[Cpp2IlInjected.Token(Token = "0x6000312")]
			[Cpp2IlInjected.Address(RVA = "0x7337C90", Offset = "0x7336890", VA = "0x187337C90")]
			public void MOPANFNOMBO(MNMFJNIJMID PPCPNOAGMNJ, [Out] Transform EBMDCHEPJIM, [Out] Transform[] JJNNFMINDGB)
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000062")]
		protected struct BodyPartLODs
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003B5")]
			public Mesh[] LODs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003B6")]
			public bool UseHandBones;
		}

		[Cpp2IlInjected.Token(Token = "0x2000064")]
		[CompilerGenerated]
		private sealed class AKNICCIBCPG : IEnumerable<SkinnedMeshRenderer>, IEnumerable, IEnumerator<SkinnedMeshRenderer>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003BE")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003BF")]
			private SkinnedMeshRenderer <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003C0")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003C1")]
			public PlayerAvatarDisplayBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003C2")]
			private SkinnedMeshRenderer[] <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003C3")]
			private int <>7__wrap2;

			[Cpp2IlInjected.Token(Token = "0x17000092")]
			SkinnedMeshRenderer IEnumerator<SkinnedMeshRenderer>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600031E")]
				[Cpp2IlInjected.Address(RVA = "0x957530", Offset = "0x956130", VA = "0x180957530", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000093")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000320")]
				[Cpp2IlInjected.Address(RVA = "0x957530", Offset = "0x956130", VA = "0x180957530", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600031B")]
			[Cpp2IlInjected.Address(RVA = "0xD30330", Offset = "0xD2EF30", VA = "0x180D30330")]
			[DebuggerHidden]
			public AKNICCIBCPG(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600031C")]
			[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600031D")]
			[Cpp2IlInjected.Address(RVA = "0x7329470", Offset = "0x7328070", VA = "0x187329470", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600031F")]
			[Cpp2IlInjected.Address(RVA = "0x73296F0", Offset = "0x73282F0", VA = "0x1873296F0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000321")]
			[Cpp2IlInjected.Address(RVA = "0x7329640", Offset = "0x7328240", VA = "0x187329640", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<SkinnedMeshRenderer> IEnumerable<SkinnedMeshRenderer>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000322")]
			[Cpp2IlInjected.Address(RVA = "0x7329640", Offset = "0x7328240", VA = "0x187329640", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000065")]
		[CompilerGenerated]
		private sealed class AFFEECJLHBL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003C4")]
			public PlayerAvatarDisplayBase display;

			[Cpp2IlInjected.Token(Token = "0x6000323")]
			[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
			public AFFEECJLHBL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000324")]
			[Cpp2IlInjected.Address(RVA = "0x73290E0", Offset = "0x7327CE0", VA = "0x1873290E0")]
			internal bool LLFEEFGFKOP()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000066")]
		[CompilerGenerated]
		private sealed class KKECKKAJFDJ : IEnumerator<LNKBBFODFEI>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003C5")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003C6")]
			private LNKBBFODFEI <>2__current;

			[Cpp2IlInjected.Token(Token = "0x17000094")]
			private LNKBBFODFEI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000328")]
				[Cpp2IlInjected.Address(RVA = "0x957530", Offset = "0x956130", VA = "0x180957530", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000095")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600032A")]
				[Cpp2IlInjected.Address(RVA = "0x957530", Offset = "0x956130", VA = "0x180957530", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000325")]
			[Cpp2IlInjected.Address(RVA = "0x958500", Offset = "0x957100", VA = "0x180958500")]
			[DebuggerHidden]
			public KKECKKAJFDJ(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000326")]
			[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000327")]
			[Cpp2IlInjected.Address(RVA = "0x732E1C0", Offset = "0x732CDC0", VA = "0x18732E1C0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000329")]
			[Cpp2IlInjected.Address(RVA = "0x732E590", Offset = "0x732D190", VA = "0x18732E590", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000067")]
		[CompilerGenerated]
		private struct NNGIOJMDJCA : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003C7")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003C8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003C9")]
			public PlayerAvatarDisplayBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003CA")]
			public DIKMCPOCMGD avatarData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003CB")]
			private bool <forceRebuild>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003CC")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600032B")]
			[Cpp2IlInjected.Address(RVA = "0x7330A50", Offset = "0x732F650", VA = "0x187330A50", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600032C")]
			[Cpp2IlInjected.Address(RVA = "0x73311F0", Offset = "0x732FDF0", VA = "0x1873311F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000068")]
		[CompilerGenerated]
		private sealed class LJGMMCFMEAP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003CD")]
			public string overrideIdentifier;

			[Cpp2IlInjected.Token(Token = "0x600032D")]
			[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
			public LJGMMCFMEAP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600032E")]
			[Cpp2IlInjected.Address(RVA = "0x7330260", Offset = "0x732EE60", VA = "0x187330260")]
			internal bool NJBKCOLLPDH(GDANPJFMKLK selection)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000069")]
		[CompilerGenerated]
		private sealed class DIPEKCGLHCC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003CE")]
			public PlayerAvatarDisplayBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003CF")]
			public AvatarItemBodyType avatarItemBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003D0")]
			public Func<JOIICJDLMNO<Dictionary<string, OBLFPJIHAJD<Texture2D>>>> <>9__2;

			[Cpp2IlInjected.Token(Token = "0x600032F")]
			[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
			public DIPEKCGLHCC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000330")]
			[Cpp2IlInjected.Address(RVA = "0x7329E00", Offset = "0x7328A00", VA = "0x187329E00")]
			internal (FIJFJANJAHF, JOIICJDLMNO<Dictionary<string, OBLFPJIHAJD<Texture2D>>>) NLLHMDKJIFH(Dictionary<string, NKBLHOBAPGG> avatarItems)
			{
				return default((FIJFJANJAHF, JOIICJDLMNO<Dictionary<string, OBLFPJIHAJD<Texture2D>>>));
			}

			[Cpp2IlInjected.Token(Token = "0x6000331")]
			[Cpp2IlInjected.Address(RVA = "0x7329D90", Offset = "0x7328990", VA = "0x187329D90")]
			internal JOIICJDLMNO<Dictionary<string, OBLFPJIHAJD<Texture2D>>> KPKLNLLGOCE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000332")]
			[Cpp2IlInjected.Address(RVA = "0x7329D50", Offset = "0x7328950", VA = "0x187329D50")]
			internal void BGKAHBLJFIH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006A")]
		[CompilerGenerated]
		private sealed class DMEEOGCNLCH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003D1")]
			public Transform transformToCheck;

			[Cpp2IlInjected.Token(Token = "0x6000333")]
			[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
			public DMEEOGCNLCH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000334")]
			[Cpp2IlInjected.Address(RVA = "0x732A3C0", Offset = "0x7328FC0", VA = "0x18732A3C0")]
			internal bool AGKAEHCBMME(SkinnedMeshRenderer x)
			{
				return default(bool);
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200006B")]
		[CompilerGenerated]
		private struct NCEIJGKAMLH : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003D2")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003D3")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003D4")]
			public PlayerAvatarDisplayBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003D5")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000335")]
			[Cpp2IlInjected.Address(RVA = "0x7330820", Offset = "0x732F420", VA = "0x187330820", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000336")]
			[Cpp2IlInjected.Address(RVA = "0x73309F0", Offset = "0x732F5F0", VA = "0x1873309F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		protected static readonly int FFOMIENPGOE;

		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		protected static readonly int ABPHKMIKNPP;

		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		protected static readonly int DCNHCJFPIOG;

		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		protected static readonly int ICDDGAHELPN;

		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		protected static readonly int EPPFFMPOALO;

		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		protected static readonly int NBEEDOKANOO;

		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		protected static readonly int[] BAOFHHDDIAI;

		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		protected static readonly int[] FKBPELAONDD;

		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		protected static readonly int[] AHCCFIACJCN;

		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		protected static readonly int[] HNLBNPGKPGH;

		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		protected static readonly int[] DLEFPELPPML;

		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		protected static readonly int[] JCDFMHJFOFL;

		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		protected static List<PlayerAvatarDisplayBase> CBPOCDKJJBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		protected GBOFEGMEOKI DBCMFPHPELP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		protected bool MKLNPIDOOHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		protected bool JLIKANANNGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		[SerializeField]
		public AvatarBodyShapeVault BodyShapeVault;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		[SerializeField]
		public AvatarFaceShapeVault FaceShapeVault;

		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		protected static readonly int[] OOPDEFJMKMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		[SerializeField]
		protected Material bodyPartMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		protected Dictionary<PFDEAFPHBIN, Material> ACMOJPGPIFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		protected Dictionary<PFDEAFPHBIN, Material> OICMIJGLPGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		[SerializeField]
		protected bool ignorePlayerMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		[SerializeField]
		protected Transform trackingSpace;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		[SerializeField]
		protected BodyPartLODs Head;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		[SerializeField]
		protected BodyPartLODs Ear;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		[SerializeField]
		protected BodyPartLODs Torso;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		[SerializeField]
		protected BodyPartLODs Hand;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		[SerializeField]
		protected BodyPartLODs HandPointing;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		[SerializeField]
		public PlayerHandBones HandBones;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		[SerializeField]
		public Transform remoteMeshBase;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		public readonly SkinnedMeshRenderer[] CurrentDefaultSkinnedMeshRenderers;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		public readonly SkinnedMeshRenderer[] NextDefaultSkinnedMeshRenderers;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		public readonly SkinnedMeshRenderer[] CurrentVisibleInFirstPersonSkinnedMeshRenderers;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		public readonly SkinnedMeshRenderer[] NextVisibleInFirstPersonSkinnedMeshRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		[SerializeField]
		public Transform firstPersonMeshBase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		[SerializeField]
		protected Shader uberShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		[SerializeField]
		protected Shader agAvatarShader;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		protected Material LFEGFBDCNKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		protected DDHFIFHCKBI MEGGPACIFAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		private FLDOCHEELKL NDAPCOAAION;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		private FLDOCHEELKL GFGHCLJABKJ;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		protected Material GJJNGMJJDJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		[SerializeField]
		protected Transform headPropAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		[SerializeField]
		protected Transform hatAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		[SerializeField]
		public Transform hemisphereBase;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		protected FitMeshHemisphere ACLBJFJECIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		protected bool LFONFKFGDDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		protected IFMFMHOGADG MBNFFJLKFIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		protected bool EGPFNNAEHFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		protected AnchorParamsRestrictions PDDKAHPGKGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		protected bool OPNBNPEKJOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		protected Transform HGLGEHMNHOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		protected bool JFCNDPGJIHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x199")]
		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		protected bool EFGOKNEOEEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19C")]
		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		protected Vector3 HNIOJJPFLBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		protected Quaternion CNGONGHMBHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		protected Vector2 NDMEDKILOJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		protected FitMeshHemisphere HAEDANGIENL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		[SerializeField]
		[NEHJBMHDGNH(EGFPEOBPDHA.SelfAndChildren, false, false, false)]
		protected PlayerFacialAnimatorBase facialAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		[SerializeField]
		protected Transform torsoPropAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		[SerializeField]
		protected Transform torsoRootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		[SerializeField]
		protected Transform headRootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		[SerializeField]
		protected Transform leftHandRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		[SerializeField]
		protected Transform leftHandDefaultScaleRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		[SerializeField]
		protected Transform rightHandRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		[SerializeField]
		protected Transform rightHandDefaultScaleRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		[SerializeField]
		protected Animator leftHandAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		[SerializeField]
		protected Animator rightHandAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		[SerializeField]
		protected Transform leftHandPointingRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		[SerializeField]
		protected Transform rightHandPointingRoot;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		protected Collider[] AGNFHCKAJFA;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		protected Collider[] EMDAKJPGJCJ;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		protected LBGJKCLCIHK[] ONOIMFKDFGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		[SerializeField]
		protected Mesh faceMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		public Dictionary<Renderer, JBNLFNAALJB> currentPropertyBlocks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		protected Dictionary<Renderer, JBNLFNAALJB> HEBBLPBJGIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		protected JPABGGMNKLE CCOKKEGMKKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x4000300")]
		protected FIJFJANJAHF LDJGFEHDNLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
		[Cpp2IlInjected.Token(Token = "0x4000301")]
		public CKBJHKOEDDL DistanceBand;

		[Cpp2IlInjected.FieldOffset(Offset = "0x26C")]
		[Cpp2IlInjected.Token(Token = "0x4000302")]
		protected int MEAENBGLNGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		protected GOPCCLCPPEB<MKBKBOKOBAG> OFAPEJJKCNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		protected bool PCPJGKBHHEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		protected Dictionary<GDANPJFMKLK, List<PFDEAFPHBIN>> BMLAHJPBIIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		protected Dictionary<GDANPJFMKLK, List<PFDEAFPHBIN>> HCACFJBFLLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		protected readonly Dictionary<string, OBLFPJIHAJD<Texture2D>> LBEAKDJJDNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
		[Cpp2IlInjected.Token(Token = "0x4000309")]
		protected readonly Dictionary<string, OBLFPJIHAJD<Texture2D>> KECNEDKKECI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
		[Cpp2IlInjected.Token(Token = "0x400030A")]
		protected bool HBGLHHJNECK;

		[Cpp2IlInjected.Token(Token = "0x400030C")]
		protected static int HNPMHBKJABG;

		[Cpp2IlInjected.Token(Token = "0x400030D")]
		protected static List<AGDKLLPDNEC> JHCHOKOLDMF;

		[Cpp2IlInjected.Token(Token = "0x400030E")]
		protected static List<AGDKLLPDNEC> NBBDFGLCBDC;

		[Cpp2IlInjected.Token(Token = "0x400030F")]
		protected static NAEMDCMJKFJ CPJMHBBPPGF;

		[Cpp2IlInjected.Token(Token = "0x4000310")]
		protected static bool KGMLABPODCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B0")]
		[Cpp2IlInjected.Token(Token = "0x4000311")]
		protected Color? FLGIMHEJMEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C4")]
		[Cpp2IlInjected.Token(Token = "0x4000312")]
		protected bool APNPBICDOJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
		[Cpp2IlInjected.Token(Token = "0x4000313")]
		protected Color CFPPOKMCDHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D8")]
		[Cpp2IlInjected.Token(Token = "0x4000314")]
		protected Color DIKMBBBEJMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E8")]
		[Cpp2IlInjected.Token(Token = "0x4000315")]
		protected Color BIJMMDGHNEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2F8")]
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		protected AvatarHairPattern OFGKCPEAMEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x300")]
		[Cpp2IlInjected.Token(Token = "0x4000317")]
		protected JGMJCPJCOGN JLCADNNGDGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x308")]
		[Cpp2IlInjected.Token(Token = "0x4000318")]
		protected Color PJBLIDHCBLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x318")]
		[Cpp2IlInjected.Token(Token = "0x4000319")]
		protected Color OFDGPLMJNEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x328")]
		[Cpp2IlInjected.Token(Token = "0x400031A")]
		protected AvatarHairPattern IJGCOOEOIDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x330")]
		[Cpp2IlInjected.Token(Token = "0x400031B")]
		protected JGMJCPJCOGN CFBIFMOKNEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x338")]
		[Cpp2IlInjected.Token(Token = "0x400031C")]
		protected JGMJCPJCOGN NNFKFJIGKNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x340")]
		[Cpp2IlInjected.Token(Token = "0x400031D")]
		protected Color GNHJABIFGME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x350")]
		[Cpp2IlInjected.Token(Token = "0x400031E")]
		private AdditionalFeetData JCIAPHINHCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x358")]
		[Cpp2IlInjected.Token(Token = "0x400031F")]
		protected GDANPJFMKLK? DJHBJOEBEFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x370")]
		[Cpp2IlInjected.Token(Token = "0x4000320")]
		protected Texture PLODJCGOAGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x378")]
		[Cpp2IlInjected.Token(Token = "0x4000321")]
		protected Color PFHBHKFEONF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x388")]
		[Cpp2IlInjected.Token(Token = "0x4000322")]
		protected readonly IList<GDANPJFMKLK> HMJPIBNBFJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x390")]
		[Cpp2IlInjected.Token(Token = "0x4000323")]
		protected readonly IList<GDANPJFMKLK> KDBAMNLBOMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x398")]
		[Cpp2IlInjected.Token(Token = "0x4000324")]
		private AvatarItemBodyType AOCKLNGJMHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A0")]
		[Cpp2IlInjected.Token(Token = "0x4000325")]
		[SerializeField]
		protected AvatarFaceShape _currentFaceShape;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A8")]
		[Cpp2IlInjected.Token(Token = "0x4000326")]
		[SerializeField]
		protected AvatarBodyShape _currentBodyShape;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3B0")]
		[Cpp2IlInjected.Token(Token = "0x4000327")]
		[SerializeField]
		protected FHEDEKPEKPL _currentNoseType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3B4")]
		[Cpp2IlInjected.Token(Token = "0x4000328")]
		[SerializeField]
		protected bool _hideEars;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3B5")]
		[Cpp2IlInjected.Token(Token = "0x4000329")]
		protected NMDGNLLKPPH LLCCBDHJJFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3B8")]
		[Cpp2IlInjected.Token(Token = "0x400032A")]
		protected int[] JFGCLBOJMMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C0")]
		[Cpp2IlInjected.Token(Token = "0x400032B")]
		protected bool DDGJNPCCKIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C8")]
		[Cpp2IlInjected.Token(Token = "0x400032C")]
		protected int[] IHOFCFHFGMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D0")]
		[Cpp2IlInjected.Token(Token = "0x400032D")]
		protected bool EJIAMNEFLFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D8")]
		[Cpp2IlInjected.Token(Token = "0x400032E")]
		protected MIIODELFBFL LIONBNANHJL;

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public string LKLGDNNENCA
		{
			[Cpp2IlInjected.Token(Token = "0x6000211")]
			[Cpp2IlInjected.Address(RVA = "0x957550", Offset = "0x956150", VA = "0x180957550")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000212")]
			[Cpp2IlInjected.Address(RVA = "0x957500", Offset = "0x956100", VA = "0x180957500")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public bool OIMPENCIHJK
		{
			[Cpp2IlInjected.Token(Token = "0x6000214")]
			[Cpp2IlInjected.Address(RVA = "0xAB3FC0", Offset = "0xAB2BC0", VA = "0x180AB3FC0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000215")]
			[Cpp2IlInjected.Address(RVA = "0xBAC4A0", Offset = "0xBAB0A0", VA = "0x180BAC4A0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public virtual bool NNBEFPHFJIC
		{
			[Cpp2IlInjected.Token(Token = "0x6000216")]
			[Cpp2IlInjected.Address(RVA = "0x9A1F50", Offset = "0x9A0B50", VA = "0x1809A1F50", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public bool ANPEGNDEDKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000217")]
			[Cpp2IlInjected.Address(RVA = "0x7327DB0", Offset = "0x73269B0", VA = "0x187327DB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public virtual bool DKNKMMFCACJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000218")]
			[Cpp2IlInjected.Address(RVA = "0x9A1F50", Offset = "0x9A0B50", VA = "0x1809A1F50", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public virtual bool OJLPHJFJEHD
		{
			[Cpp2IlInjected.Token(Token = "0x6000219")]
			[Cpp2IlInjected.Address(RVA = "0x9735C0", Offset = "0x9721C0", VA = "0x1809735C0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public virtual bool OEJGJAMHFLL
		{
			[Cpp2IlInjected.Token(Token = "0x600021A")]
			[Cpp2IlInjected.Address(RVA = "0x9A1F50", Offset = "0x9A0B50", VA = "0x1809A1F50", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public DDHFIFHCKBI APJFNONAKNJ
		{
			[Cpp2IlInjected.Token(Token = "0x600021C")]
			[Cpp2IlInjected.Address(RVA = "0x9C0930", Offset = "0x9BF530", VA = "0x1809C0930")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600021D")]
			[Cpp2IlInjected.Address(RVA = "0x7328380", Offset = "0x7326F80", VA = "0x187328380")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public FLDOCHEELKL BCHJNJPCBMM
		{
			[Cpp2IlInjected.Token(Token = "0x600021E")]
			[Cpp2IlInjected.Address(RVA = "0x9B9B30", Offset = "0x9B8730", VA = "0x1809B9B30")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600021F")]
			[Cpp2IlInjected.Address(RVA = "0x73286D0", Offset = "0x73272D0", VA = "0x1873286D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public FLDOCHEELKL IPBLPMJAFMJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000220")]
			[Cpp2IlInjected.Address(RVA = "0x9C0B50", Offset = "0x9BF750", VA = "0x1809C0B50")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000221")]
			[Cpp2IlInjected.Address(RVA = "0x7328980", Offset = "0x7327580", VA = "0x187328980")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		protected Material DBDNLNEJALP
		{
			[Cpp2IlInjected.Token(Token = "0x6000222")]
			[Cpp2IlInjected.Address(RVA = "0x7322B80", Offset = "0x7321780", VA = "0x187322B80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		protected Material ECAHOIOPJEK
		{
			[Cpp2IlInjected.Token(Token = "0x6000223")]
			[Cpp2IlInjected.Address(RVA = "0x73237B0", Offset = "0x73223B0", VA = "0x1873237B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public bool BAALOCDMLGM
		{
			[Cpp2IlInjected.Token(Token = "0x6000224")]
			[Cpp2IlInjected.Address(RVA = "0x1C14B10", Offset = "0x1C13710", VA = "0x181C14B10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public PlayerFacialAnimatorBase FEGDENGAGJL
		{
			[Cpp2IlInjected.Token(Token = "0x6000228")]
			[Cpp2IlInjected.Address(RVA = "0xC4F4C0", Offset = "0xC4E0C0", VA = "0x180C4F4C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public LBGJKCLCIHK[] FNPGIJHJIAH
		{
			[Cpp2IlInjected.Token(Token = "0x6000229")]
			[Cpp2IlInjected.Address(RVA = "0x7327980", Offset = "0x7326580", VA = "0x187327980")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public LBGJKCLCIHK IIOFCMNNDEO
		{
			[Cpp2IlInjected.Token(Token = "0x600022A")]
			[Cpp2IlInjected.Address(RVA = "0x7327FA0", Offset = "0x7326BA0", VA = "0x187327FA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public LBGJKCLCIHK PBPMGIJOKNB
		{
			[Cpp2IlInjected.Token(Token = "0x600022B")]
			[Cpp2IlInjected.Address(RVA = "0x7327FD0", Offset = "0x7326BD0", VA = "0x187327FD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public Mesh CEFECPOGNKG
		{
			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0xA0CDB0", Offset = "0xA0B9B0", VA = "0x180A0CDB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		protected JPABGGMNKLE KMLFKLANDEF
		{
			[Cpp2IlInjected.Token(Token = "0x600022D")]
			[Cpp2IlInjected.Address(RVA = "0x731E720", Offset = "0x731D320", VA = "0x18731E720")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		protected FIJFJANJAHF GAIHJIGCMAE
		{
			[Cpp2IlInjected.Token(Token = "0x600022E")]
			[Cpp2IlInjected.Address(RVA = "0xC4F3F0", Offset = "0xC4DFF0", VA = "0x180C4F3F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600022F")]
			[Cpp2IlInjected.Address(RVA = "0x73213E0", Offset = "0x731FFE0", VA = "0x1873213E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		protected bool CGMPNHKKHIB
		{
			[Cpp2IlInjected.Token(Token = "0x6000230")]
			[Cpp2IlInjected.Address(RVA = "0x9735C0", Offset = "0x9721C0", VA = "0x1809735C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public bool ALBOFDIIOKO
		{
			[Cpp2IlInjected.Token(Token = "0x6000231")]
			[Cpp2IlInjected.Address(RVA = "0x7327F90", Offset = "0x7326B90", VA = "0x187327F90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public int AFJDMEHFJMD
		{
			[Cpp2IlInjected.Token(Token = "0x6000232")]
			[Cpp2IlInjected.Address(RVA = "0x1F6FD50", Offset = "0x1F6E950", VA = "0x181F6FD50")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000233")]
			[Cpp2IlInjected.Address(RVA = "0x73288E0", Offset = "0x73274E0", VA = "0x1873288E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		protected virtual bool GLJNENPICLK
		{
			[Cpp2IlInjected.Token(Token = "0x6000234")]
			[Cpp2IlInjected.Address(RVA = "0x9A1F50", Offset = "0x9A0B50", VA = "0x1809A1F50", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		protected virtual int[] JIHKKHECPNJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000235")]
			[Cpp2IlInjected.Address(RVA = "0x731FCD0", Offset = "0x731E8D0", VA = "0x18731FCD0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		protected bool PMGHJOAJHML
		{
			[Cpp2IlInjected.Token(Token = "0x6000237")]
			[Cpp2IlInjected.Address(RVA = "0x7320660", Offset = "0x731F260", VA = "0x187320660")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		protected static bool BEKOFBMAHPE
		{
			[Cpp2IlInjected.Token(Token = "0x6000238")]
			[Cpp2IlInjected.Address(RVA = "0x9A1F50", Offset = "0x9A0B50", VA = "0x1809A1F50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public bool IOBKBHGGMKN
		{
			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0xFEF310", Offset = "0xFEDF10", VA = "0x180FEF310")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0x7328B90", Offset = "0x7327790", VA = "0x187328B90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public IEnumerable<SkinnedMeshRenderer> EDNFIJJAGPB
		{
			[Cpp2IlInjected.Token(Token = "0x600023B")]
			[Cpp2IlInjected.Address(RVA = "0x7327850", Offset = "0x7326450", VA = "0x187327850")]
			[IteratorStateMachine(typeof(AKNICCIBCPG))]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public bool DFIMOLGJAJB
		{
			[Cpp2IlInjected.Token(Token = "0x600023C")]
			[Cpp2IlInjected.Address(RVA = "0xFF0D30", Offset = "0xFEF930", VA = "0x180FF0D30")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600023D")]
			[Cpp2IlInjected.Address(RVA = "0xFF07E0", Offset = "0xFEF3E0", VA = "0x180FF07E0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public CDKJOLAGBOC BBAMKKFOGEP
		{
			[Cpp2IlInjected.Token(Token = "0x600023E")]
			[Cpp2IlInjected.Address(RVA = "0x73278D0", Offset = "0x73264D0", VA = "0x1873278D0")]
			get
			{
				return default(CDKJOLAGBOC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public static bool IDFIAGHFGLH
		{
			[Cpp2IlInjected.Token(Token = "0x600025C")]
			[Cpp2IlInjected.Address(RVA = "0x7327D20", Offset = "0x7326920", VA = "0x187327D20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		protected static NAEMDCMJKFJ CBBNPPKGJIJ
		{
			[Cpp2IlInjected.Token(Token = "0x600025D")]
			[Cpp2IlInjected.Address(RVA = "0x731DCC0", Offset = "0x731C8C0", VA = "0x18731DCC0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600025E")]
			[Cpp2IlInjected.Address(RVA = "0x7321480", Offset = "0x7320080", VA = "0x187321480")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		protected Color FNKJFOGKNNB
		{
			[Cpp2IlInjected.Token(Token = "0x6000276")]
			[Cpp2IlInjected.Address(RVA = "0x7320E30", Offset = "0x731FA30", VA = "0x187320E30")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		protected Color LDPHBNGHKAA
		{
			[Cpp2IlInjected.Token(Token = "0x6000277")]
			[Cpp2IlInjected.Address(RVA = "0x7322DC0", Offset = "0x73219C0", VA = "0x187322DC0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		protected Texture2D BDOJDBLGPAM
		{
			[Cpp2IlInjected.Token(Token = "0x6000278")]
			[Cpp2IlInjected.Address(RVA = "0x731C970", Offset = "0x731B570", VA = "0x18731C970")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		protected Color PLIBJNMCMBC
		{
			[Cpp2IlInjected.Token(Token = "0x600027E")]
			[Cpp2IlInjected.Address(RVA = "0x7321330", Offset = "0x731FF30", VA = "0x187321330")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		protected Color IHLHCCOCHDO
		{
			[Cpp2IlInjected.Token(Token = "0x600027F")]
			[Cpp2IlInjected.Address(RVA = "0x7321380", Offset = "0x731FF80", VA = "0x187321380")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public JGMJCPJCOGN OCGJDCBALFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000280")]
			[Cpp2IlInjected.Address(RVA = "0x7327940", Offset = "0x7326540", VA = "0x187327940")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		protected Texture2D OKFMHMEDLLE
		{
			[Cpp2IlInjected.Token(Token = "0x6000281")]
			[Cpp2IlInjected.Address(RVA = "0x731C4A0", Offset = "0x731B0A0", VA = "0x18731C4A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public float EBODGLJGDPG
		{
			[Cpp2IlInjected.Token(Token = "0x6000288")]
			[Cpp2IlInjected.Address(RVA = "0x7327960", Offset = "0x7326560", VA = "0x187327960")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		public float JLKHAHDPAFO
		{
			[Cpp2IlInjected.Token(Token = "0x6000289")]
			[Cpp2IlInjected.Address(RVA = "0x7327D90", Offset = "0x7326990", VA = "0x187327D90")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		public bool DMPDNAECPCM
		{
			[Cpp2IlInjected.Token(Token = "0x60002B7")]
			[Cpp2IlInjected.Address(RVA = "0x7327930", Offset = "0x7326530", VA = "0x187327930")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002B8")]
			[Cpp2IlInjected.Address(RVA = "0x7328160", Offset = "0x7326D60", VA = "0x187328160")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action BFENJKEBMMI
		{
			[Cpp2IlInjected.Token(Token = "0x600020F")]
			[Cpp2IlInjected.Address(RVA = "0x73276F0", Offset = "0x73262F0", VA = "0x1873276F0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(RVA = "0x7328000", Offset = "0x7326C00", VA = "0x187328000")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<HMLPHKJFFOG, PMDBBMEEGON> OPBNHMDHPAF
		{
			[Cpp2IlInjected.Token(Token = "0x6000251")]
			[Cpp2IlInjected.Address(RVA = "0x7327790", Offset = "0x7326390", VA = "0x187327790")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000252")]
			[Cpp2IlInjected.Address(RVA = "0x73280A0", Offset = "0x7326CA0", VA = "0x1873280A0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x7324630", Offset = "0x7323230", VA = "0x187324630")]
		public bool SetDeformation(bool MKLNPIDOOHF, bool JLIKANANNGN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x731CBF0", Offset = "0x731B7F0", VA = "0x18731CBF0")]
		protected static Material CNBJFNKKNAA(Dictionary<PFDEAFPHBIN, Material> AFBLANJNKFB, Material ACMNHGANFGB, JFHILDAKNOJ KILFBEBJIBA, IDFLKBOHAEM FHALJNEGEEC, MNMFJNIJMID PPCPNOAGMNJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x73227F0", Offset = "0x73213F0", VA = "0x1873227F0")]
		protected void NBDKMBLJFKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x73202E0", Offset = "0x731EEE0", VA = "0x1873202E0")]
		protected bool IPCIDANFOMP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x7322AF0", Offset = "0x73216F0", VA = "0x187322AF0")]
		protected void NIANNAFMMNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x731B630", Offset = "0x731A230", VA = "0x18731B630", Slot = "10")]
		protected virtual void AMOEHJOIFGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x7322730", Offset = "0x7321330", VA = "0x187322730")]
		public int MeshesAtLODCount(int KIAFLABOCJF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x731F840", Offset = "0x731E440", VA = "0x18731F840")]
		protected static void HICKHOAFMCH(Dictionary<GDANPJFMKLK, List<PFDEAFPHBIN>> LIJANAIJBCD, CNFDEFLBKGE HFFJCCNDJBP, Material ACMNHGANFGB, JFHILDAKNOJ NGKFBOHKKBK, IDFLKBOHAEM HBKFOKHPJHJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x731C0B0", Offset = "0x731ACB0", VA = "0x18731C0B0")]
		protected void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x731B2F0", Offset = "0x7319EF0", VA = "0x18731B2F0")]
		protected void AGMHLCODAEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x73234A0", Offset = "0x73220A0", VA = "0x1873234A0")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "11")]
		protected virtual void FAFPAPMCNNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x731E8A0", Offset = "0x731D4A0", VA = "0x18731E8A0")]
		protected static void GGHOCGNOBLA(List<Material> IIAGOFNALCO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x731E740", Offset = "0x731D340", VA = "0x18731E740")]
		protected static void GGGKANFLNBH(Dictionary<PFDEAFPHBIN, Material> AFBLANJNKFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x731DB60", Offset = "0x731C760", VA = "0x18731DB60")]
		protected static void EOEDJEAODCB(Dictionary<Renderer, JBNLFNAALJB> INDDBACGDPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x73229D0", Offset = "0x73215D0", VA = "0x1873229D0")]
		protected void NGMMGPIBAJF(SkinnedMeshRenderer[] DGCLIIOGPDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x7323970", Offset = "0x7322570", VA = "0x187323970")]
		protected void PMJNHHFOHMJ(SkinnedMeshRenderer FJFJGIGGCON)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x73238A0", Offset = "0x73224A0", VA = "0x1873238A0")]
		protected void PMJNHHFOHMJ(MeshRenderer FBBMMBKMCOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x731C1C0", Offset = "0x731ADC0", VA = "0x18731C1C0")]
		protected void BCDCDDBJEOK(List<OLBLCJOKKJF> FEBGJMGNMMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x731C5A0", Offset = "0x731B1A0", VA = "0x18731C5A0")]
		protected void BMHHJEGMNPB(Dictionary<string, OBLFPJIHAJD<Texture2D>> LIJANAIJBCD, bool PEFADKIMGHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x7323030", Offset = "0x7321C30", VA = "0x187323030")]
		protected void OHOCBHDLMHM(Dictionary<GDANPJFMKLK, List<PFDEAFPHBIN>> LIJANAIJBCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x731ED70", Offset = "0x731D970", VA = "0x18731ED70")]
		public float GetHandOpenClosedAxis(HMLPHKJFFOG LBDNHDCDGHG)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x7324ED0", Offset = "0x7323AD0", VA = "0x187324ED0")]
		public void SetHandOpenClosedAxis(HMLPHKJFFOG LBDNHDCDGHG, float AGLJHGDBMLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x731EDB0", Offset = "0x731D9B0", VA = "0x18731EDB0")]
		public PMDBBMEEGON GetHandVisualState(HMLPHKJFFOG LBDNHDCDGHG)
		{
			return default(PMDBBMEEGON);
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x731B7F0", Offset = "0x731A3F0", VA = "0x18731B7F0")]
		public bool AddHandVisualStateToken(HMLPHKJFFOG LBDNHDCDGHG, PMDBBMEEGON HBECOPJLMDG, object IKLHDHMJFFL, LBGJKCLCIHK.PJCGBGHKBCL NCDDNNAKJAH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x73266C0", Offset = "0x73252C0", VA = "0x1873266C0")]
		public void SetWatchHand(HMLPHKJFFOG LBDNHDCDGHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x7326780", Offset = "0x7325380", VA = "0x187326780")]
		public void SetWatchHands(bool OGHCDEJDDEP, bool JCNELMPDMIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x7323CF0", Offset = "0x73228F0", VA = "0x187323CF0")]
		public bool RemoveHandVisualStateToken(HMLPHKJFFOG LBDNHDCDGHG, object IKLHDHMJFFL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x731EE30", Offset = "0x731DA30", VA = "0x18731EE30")]
		public bool GetThumbsUpActive(HMLPHKJFFOG LBDNHDCDGHG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x7326170", Offset = "0x7324D70", VA = "0x187326170")]
		public void SetThumbsUpActive(HMLPHKJFFOG LBDNHDCDGHG, bool HDLJMHNLMCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x731EDF0", Offset = "0x731D9F0", VA = "0x18731EDF0")]
		public bool GetHandshakeActive(HMLPHKJFFOG LBDNHDCDGHG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x7324F20", Offset = "0x7323B20", VA = "0x187324F20")]
		public void SetHandshakeActive(HMLPHKJFFOG LBDNHDCDGHG, bool FODGLAFMBOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x731E6D0", Offset = "0x731D2D0", VA = "0x18731E6D0")]
		public void ForceUpdateHandsVisualState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(RVA = "0x731D350", Offset = "0x731BF50", VA = "0x18731D350")]
		public static void ClearQueuedBuilds()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x731E450", Offset = "0x731D050", VA = "0x18731E450")]
		protected static void FFKBLLEKHAG(PlayerAvatarDisplayBase IHOFNLIALFA, List<AGDKLLPDNEC> FLAAFFLGPHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x7323A10", Offset = "0x7322610", VA = "0x187323A10")]
		public void Rebuild(bool OMCEONHBACA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x7323080", Offset = "0x7321C80", VA = "0x187323080")]
		protected void OICHJCPPJAI(bool OMCEONHBACA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x73230D0", Offset = "0x7321CD0", VA = "0x1873230D0", Slot = "12")]
		protected virtual HAGJNGKFIOK OICHJCPPJAI(IList<GDANPJFMKLK> OFABKEBGBBI, AvatarItemBodyType MDGPOHOEPAF, bool BGMJKGBODOI, int[] PCKKMFOHDIK, bool OMCEONHBACA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x731DE30", Offset = "0x731CA30", VA = "0x18731DE30")]
		protected static HAGJNGKFIOK FDMONPLELGM(AGDKLLPDNEC OBLMMDCNBGL, List<AGDKLLPDNEC> FLAAFFLGPHG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x731E9E0", Offset = "0x731D5E0", VA = "0x18731E9E0")]
		[IteratorStateMachine(typeof(KKECKKAJFDJ))]
		protected static IEnumerator<LNKBBFODFEI> GJOHGHGHICM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x731D550", Offset = "0x731C150", VA = "0x18731D550")]
		protected static AGDKLLPDNEC DOPDDHMFBMN(List<AGDKLLPDNEC> FLAAFFLGPHG)
		{
			return default(AGDKLLPDNEC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x7324740", Offset = "0x7323340", VA = "0x187324740")]
		[AsyncStateMachine(typeof(NNGIOJMDJCA))]
		public Task SetFaceCustomizationSettings(DIKMCPOCMGD MLDPAOODPLJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x7320500", Offset = "0x731F100", VA = "0x187320500")]
		public void InitializeFaceFeatures(AvatarConfiguration BPAOABMFDGK, CDKJOLAGBOC IKFGPFGPALL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x7325EC0", Offset = "0x7324AC0", VA = "0x187325EC0")]
		public void SetTeamColors(Color? GENHKKNGDJC, bool OALOJKHJOGA, Color DMMKNAKJHNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x10A9510", Offset = "0x10A8110", VA = "0x1810A9510")]
		private static void DGLCCHNGJHC(Material LBEFIBKFEIP, Color MPDLOLIOGJL, params int[] PGGLKBIOGJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x10A9280", Offset = "0x10A7E80", VA = "0x1810A9280")]
		private static void BCEFOENNIFH(Material LBEFIBKFEIP, Texture MPDLOLIOGJL, params int[] PGGLKBIOGJC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x731F5C0", Offset = "0x731E1C0", VA = "0x18731F5C0")]
		protected void HGEIDNLMNOJ(Material JIKIFLJBLEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x7321210", Offset = "0x731FE10", VA = "0x187321210")]
		protected void LDHHKCHCGOG(Material JIKIFLJBLEC, Color OOCNCCDFAMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x7322E10", Offset = "0x7321A10", VA = "0x187322E10")]
		protected void OHEAEIMAPOC(Material JIKIFLJBLEC, Color OOCNCCDFAMF, Color MPODOJJJNHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x73206E0", Offset = "0x731F2E0", VA = "0x1873206E0")]
		protected void JDOKNCDPEGH(Material JIKIFLJBLEC, Texture2D AIKPMCHDKOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x7320920", Offset = "0x731F520", VA = "0x187320920")]
		protected void JLEFNLLCGMO(Material JIKIFLJBLEC, Texture NPMDMFNLBJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x731B690", Offset = "0x731A290", VA = "0x18731B690")]
		protected void ANJDDAHGJEA(Action<JBNLFNAALJB> NDCBLGFCFHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x731D610", Offset = "0x731C210", VA = "0x18731D610")]
		protected void EFDGMENINKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x731EE70", Offset = "0x731DA70", VA = "0x18731EE70")]
		protected void HBCHPIEBJIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x731FF30", Offset = "0x731EB30", VA = "0x18731FF30")]
		protected void IOEGCKKHIGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x731BB40", Offset = "0x731A740", VA = "0x18731BB40")]
		public void ApplyUgcItemOverrides()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x73240B0", Offset = "0x7322CB0", VA = "0x1873240B0")]
		public void SetBeardPrimaryColor([Optional] Color? CPEIPMFPJAB, bool LHKDALAHIPC = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x73242D0", Offset = "0x7322ED0", VA = "0x1873242D0")]
		public void SetBeardSecondaryColor([Optional] Color? CPEIPMFPJAB, bool LHKDALAHIPC = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x7323F70", Offset = "0x7322B70", VA = "0x187323F70")]
		public void SetBeardPattern([Optional] AvatarHairPattern PLHNPKOHJEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x731E560", Offset = "0x731D160", VA = "0x18731E560")]
		private void FGNFKFNAIKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x731FE80", Offset = "0x731EA80", VA = "0x18731FE80")]
		private bool ILMIIAPLBBJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x7324AB0", Offset = "0x73236B0", VA = "0x187324AB0")]
		public void SetHairPrimaryColor([Optional] Color? HEKIGCPAEMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x7324CC0", Offset = "0x73238C0", VA = "0x187324CC0")]
		public void SetHairSecondaryColor([Optional] Color? HEKIGCPAEMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x7324980", Offset = "0x7323580", VA = "0x187324980")]
		public void SetHairPattern([Optional] AvatarHairPattern PLHNPKOHJEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x7323B90", Offset = "0x7322790", VA = "0x187323B90")]
		public void RefreshHair()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x7322910", Offset = "0x7321510", VA = "0x187322910")]
		private bool NFBHCFLGNEK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x7325D00", Offset = "0x7324900", VA = "0x187325D00")]
		public void SetSkinColor(Color AJPMMGMIGAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x73261C0", Offset = "0x7324DC0", VA = "0x1873261C0")]
		public void SetUgcItemVisualOverrides(GDANPJFMKLK KAIJBIHLKGC, CDKJOLAGBOC IKFGPFGPALL, Texture PKPFNBAJHOE, Color KEGADFJLPOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x731D420", Offset = "0x731C020", VA = "0x18731D420")]
		public void ClearUgcItemVisualOverrides()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x7324840", Offset = "0x7323440", VA = "0x187324840")]
		public bool SetFaceShape(AvatarFaceShape OKKAHIPLGNB, bool MAPCCPLDLID = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x73244F0", Offset = "0x73230F0", VA = "0x1873244F0")]
		public bool SetBodyShape(AvatarBodyShape PKCJFGCDJGM, bool MAPCCPLDLID = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x7325B90", Offset = "0x7324790", VA = "0x187325B90")]
		public bool SetNoseType(FHEDEKPEKPL ONBMAEJIILK, bool MAPCCPLDLID = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x73268E0", Offset = "0x73254E0", VA = "0x1873268E0")]
		public bool UpdateFaceAndBodyShapes()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x7325B70", Offset = "0x7324770", VA = "0x187325B70")]
		public bool SetHideEars(bool JHHEHKGEDCO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x7325B60", Offset = "0x7324760", VA = "0x187325B60")]
		public bool SetHelmetHair(GBOFEGMEOKI IBHJKHCKDKK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x7324F70", Offset = "0x7323B70", VA = "0x187324F70")]
		public void SetHatAnchorParameters(IFMFMHOGADG KOEPBBHINCK, bool PMDAKNCGFJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x7326850", Offset = "0x7325450", VA = "0x187326850")]
		public void SetupDisplayLODs(NMDGNLLKPPH MEKPAMAGBPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x731FB20", Offset = "0x731E720", VA = "0x18731FB20")]
		protected int[] HOLHJLMNIPD(NMDGNLLKPPH MEKPAMAGBPJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x7325C30", Offset = "0x7324830", VA = "0x187325C30")]
		public void SetOutfitSelections(IList<GDANPJFMKLK> OFABKEBGBBI, AvatarItemBodyType MDGPOHOEPAF, bool OMCEONHBACA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x7325CC0", Offset = "0x73248C0", VA = "0x187325CC0")]
		public void SetOutfitSelections(IList<GDANPJFMKLK> OFABKEBGBBI, AvatarItemBodyType MDGPOHOEPAF, bool BGMJKGBODOI, bool OMCEONHBACA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x7325C70", Offset = "0x7324870", VA = "0x187325C70")]
		public HAGJNGKFIOK SetOutfitSelections(IList<GDANPJFMKLK> OFABKEBGBBI, AvatarItemBodyType MDGPOHOEPAF, NMDGNLLKPPH MEKPAMAGBPJ, bool BGMJKGBODOI, bool MAPCCPLDLID = false, bool OMCEONHBACA = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x7323210", Offset = "0x7321E10", VA = "0x187323210", Slot = "13")]
		protected virtual HAGJNGKFIOK OINLBGHEEIM(IList<GDANPJFMKLK> OFABKEBGBBI, AvatarItemBodyType MDGPOHOEPAF, bool BGMJKGBODOI, NMDGNLLKPPH MEKPAMAGBPJ, bool MAPCCPLDLID, bool OMCEONHBACA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x731C870", Offset = "0x731B470", VA = "0x18731C870")]
		protected int[] CCLIIAKHDNE(NMDGNLLKPPH MEKPAMAGBPJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x9595B0", Offset = "0x9581B0", VA = "0x1809595B0", Slot = "14")]
		protected virtual FIJFJANJAHF NICLGLAPLJJ(AvatarItemBodyType KKOJCMMPONK, Dictionary<string, NKBLHOBAPGG> KJIGAAKHOEG, Dictionary<string, OBLFPJIHAJD<Texture2D>> DCIFLKKLLCL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x7320F40", Offset = "0x731FB40", VA = "0x187320F40", Slot = "15")]
		protected virtual HAGJNGKFIOK LAIAJHLKOPE(IList<GDANPJFMKLK> OFABKEBGBBI, AvatarItemBodyType MDGPOHOEPAF, bool BGMJKGBODOI, int[] JEFKDIBLFBG, PJOLDHGJJNF DKBMCMHBBJE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x731F140", Offset = "0x731DD40", VA = "0x18731F140", Slot = "16")]
		protected virtual NKBLHOBAPGG HFBPPNKAOGA(JGMJCPJCOGN AFGAPBEIFIA, AvatarItemBodyType KKOJCMMPONK, MNMFJNIJMID PPCPNOAGMNJ, NKBLHOBAPGG HDJPOAMOJLL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x9595B0", Offset = "0x9581B0", VA = "0x1809595B0", Slot = "17")]
		protected virtual NKBLHOBAPGG JMMMLGIFOCC(AvatarItemBodyType KKOJCMMPONK, MNMFJNIJMID PPCPNOAGMNJ, BHEPFEOINOK ENEHENBPLMA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x73205E0", Offset = "0x731F1E0", VA = "0x1873205E0")]
		protected void JAHIJADLEKK(FBHCKABCILC OCHBNPHNEHI, AMLHELBFOLA.MCCCALMIAAN OBAJALOOAFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x7322620", Offset = "0x7321220", VA = "0x187322620")]
		protected void MHPLJHKHCKH(FBHCKABCILC OCHBNPHNEHI, AMLHELBFOLA.MCCCALMIAAN OBAJALOOAFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0xCBC760", Offset = "0xCBB360", VA = "0x180CBC760", Slot = "18")]
		protected virtual FBHCKABCILC NHHEKBLIBAK(FBHCKABCILC OCHBNPHNEHI, HelmetHairStyle BJKBKOJFGHG, bool NJANPBFCKOI, AvatarItemBodyType MDGPOHOEPAF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x7321640", Offset = "0x7320240", VA = "0x187321640")]
		protected FBHCKABCILC MDKDPBIEOJN(IList<GDANPJFMKLK> OFABKEBGBBI, AvatarItemBodyType MJGLODFFLDC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x731D230", Offset = "0x731BE30", VA = "0x18731D230")]
		public void CleanupDisplayResources()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x7320C30", Offset = "0x731F830", VA = "0x187320C30")]
		protected void JMMEDJEDCMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x731EA40", Offset = "0x731D640", VA = "0x18731EA40")]
		protected void GOLNOAHCLHJ(Transform FNPKBFMHEBI, IEnumerable<SkinnedMeshRenderer> CMFFMPPBAJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x731CA60", Offset = "0x731B660", VA = "0x18731CA60")]
		protected AMLHELBFOLA.MCCCALMIAAN CJFEBIHCMHH(AMLHELBFOLA.MCCCALMIAAN APDIJKJLNBM, MNMFJNIJMID BMEMNPNGOMO)
		{
			return default(AMLHELBFOLA.MCCCALMIAAN);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x73213D0", Offset = "0x731FFD0", VA = "0x1873213D0")]
		protected void LKNAOIBDFJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x101B9B0", Offset = "0x101A5B0", VA = "0x18101B9B0")]
		protected void JJKGCPPIGLB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x731F030", Offset = "0x731DC30", VA = "0x18731F030")]
		protected void HCHFLLHCLBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x731FD60", Offset = "0x731E960", VA = "0x18731FD60")]
		[AsyncStateMachine(typeof(NCEIJGKAMLH))]
		protected Task IGEADHHDFDH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x731D850", Offset = "0x731C450", VA = "0x18731D850")]
		protected static JFHILDAKNOJ EFFOMHHPFBD(CNFDEFLBKGE IJKBHHKLGIB, int ACFLBNHOCJE)
		{
			return default(JFHILDAKNOJ);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x7320CE0", Offset = "0x731F8E0", VA = "0x187320CE0")]
		protected static IDFLKBOHAEM KDAADNGPLMO(CNFDEFLBKGE IJKBHHKLGIB, int ACFLBNHOCJE)
		{
			return default(IDFLKBOHAEM);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x7323770", Offset = "0x7322370", VA = "0x187323770")]
		protected Transform PBEJPBMEGLM(MNMFJNIJMID PPCPNOAGMNJ, OutfitType NMFCBJMEKFG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x7320A30", Offset = "0x731F630", VA = "0x187320A30")]
		protected void JLEMCABNGLH(int BKINGOGMOFL, Material LBEFIBKFEIP, CNFDEFLBKGE IJKBHHKLGIB, [Out] Texture2D COHDECKLLCC, [Out] Vector4 ODCKMOJIAPM, [Out] Texture2D HNAHOFMECLP, [Out] Texture2D HHKONJIJDDI, [Out] Texture2D FIJHBHGFKLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x731C720", Offset = "0x731B320", VA = "0x18731C720")]
		protected void CBOOHHLGNEN(int BKINGOGMOFL, Material LBEFIBKFEIP, CNFDEFLBKGE IJKBHHKLGIB, [Out] Color FMNFHGKALNC, [Out] Color GIPDLBKFMAH, [Out] Color LPPFDBCOMHH, [Out] Color BKILCAINLKE, [Out] Color IAHCAAHFMKC, [Out] Color EKEIMHEACMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x731C430", Offset = "0x731B030", VA = "0x18731C430")]
		protected void BJJCHPFOHLC(Vector3 JCCKFLFINHG, Quaternion BLLDMMJBALA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x7325510", Offset = "0x7324110", VA = "0x187325510")]
		public void SetHatAnchorParameters(IFMFMHOGADG KOEPBBHINCK, AnchorParamsRestrictions AEOGOBDIFGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x731CD50", Offset = "0x731B950", VA = "0x18731CD50")]
		public static void CalculateHatAnchorParams(FitMeshHemisphere ACLBJFJECIP, Transform HGLGEHMNHOJ, IFMFMHOGADG KOEPBBHINCK, AnchorParamsRestrictions PDDKAHPGKGD, [Out] Vector3 DDPAPHFNFJI, [Out] Quaternion CIDNHFONBIJ, [Out] IFMFMHOGADG JOAJNNDABLM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x7323E00", Offset = "0x7322A00", VA = "0x187323E00")]
		public void ResetHatAnchor(Vector2 OEFEIBMNBLF, Vector3 MNELEMHHBKM, Vector3 KKKFMBELFLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x9C68A0", Offset = "0x9C54A0", VA = "0x1809C68A0")]
		public AOEHHBOAGNP GetAnchorParamsRestrictions()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x731B970", Offset = "0x731A570", VA = "0x18731B970")]
		public void ApplyBlocks()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x731BAB0", Offset = "0x731A6B0", VA = "0x18731BAB0")]
		public void ApplyHairPattern()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x731B8E0", Offset = "0x731A4E0", VA = "0x18731B8E0")]
		public void ApplyBeardPattern()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0x7326880", Offset = "0x7325480", VA = "0x187326880", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x7320E80", Offset = "0x731FA80", VA = "0x187320E80")]
		protected void KHFGEFAPAOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x7326640", Offset = "0x7325240", VA = "0x187326640")]
		public void SetWaitForUgcTextureLoads(bool OHOHODNFOIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x7326550", Offset = "0x7325150", VA = "0x187326550")]
		public void SetUgcTextureParameters(MIIODELFBFL KNNHCEBFGKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x7327100", Offset = "0x7325D00", VA = "0x187327100")]
		public PlayerAvatarDisplayBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x731C3A0", Offset = "0x731AFA0", VA = "0x18731C3A0")]
		[CompilerGenerated]
		private void BHDOGBBLIDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x73208F0", Offset = "0x731F4F0", VA = "0x1873208F0")]
		[CompilerGenerated]
		private void JJICPEFEJNG(JBNLFNAALJB FPEMANHHEDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x731DD10", Offset = "0x731C910", VA = "0x18731DD10")]
		[CompilerGenerated]
		private void FAAPFOKBLPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x731CB30", Offset = "0x731B730", VA = "0x18731CB30")]
		[CompilerGenerated]
		private void CKHCDJKADOJ(JBNLFNAALJB FPEMANHHEDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x731DAD0", Offset = "0x731C6D0", VA = "0x18731DAD0")]
		[CompilerGenerated]
		private void EMKKJDOEKFM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x731D9F0", Offset = "0x731C5F0", VA = "0x18731D9F0")]
		[CompilerGenerated]
		private void EHKIIONKGPE(JBNLFNAALJB FPEMANHHEDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x73236E0", Offset = "0x73222E0", VA = "0x1873236E0")]
		[CompilerGenerated]
		private void PAIEFHEHJCG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x7320290", Offset = "0x731EE90", VA = "0x187320290")]
		[CompilerGenerated]
		private void IOJLFKEPOHM(JBNLFNAALJB FPEMANHHEDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x73226A0", Offset = "0x73212A0", VA = "0x1873226A0")]
		[CompilerGenerated]
		private void MLBNNDCDPDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x731FE30", Offset = "0x731EA30", VA = "0x18731FE30")]
		[CompilerGenerated]
		private void ILFDHONHBPE(JBNLFNAALJB FPEMANHHEDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x731DDA0", Offset = "0x731C9A0", VA = "0x18731DDA0")]
		[CompilerGenerated]
		private void FDMAOJOLDHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x731CBD0", Offset = "0x731B7D0", VA = "0x18731CBD0")]
		[CompilerGenerated]
		private void CLNEAIAIEHG(JBNLFNAALJB FPEMANHHEDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x731D470", Offset = "0x731C070", VA = "0x18731D470")]
		[CompilerGenerated]
		internal static bool DHMJGDHJBNI(Transform ECDNHGNGBPB, IEnumerable<SkinnedMeshRenderer> KCHLEJLBNGI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x7323460", Offset = "0x7322060", VA = "0x187323460")]
		[CompilerGenerated]
		private void ONIJPBJPNOL(JBNLFNAALJB FPEMANHHEDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x731DA90", Offset = "0x731C690", VA = "0x18731DA90")]
		[CompilerGenerated]
		private void EMCPCJLNNEI(JBNLFNAALJB FPEMANHHEDD)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[ExecuteAlways]
	public class PlayerFacialAnimatorBase : MonoBehaviour, PMHAEKLGAHN
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200006D")]
		[CompilerGenerated]
		private struct JAGPCKLCEPK : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000448")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000449")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400044A")]
			public DIKMCPOCMGD avatarData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400044B")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400044C")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600037C")]
			[Cpp2IlInjected.Address(RVA = "0x732B4A0", Offset = "0x732A0A0", VA = "0x18732B4A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600037D")]
			[Cpp2IlInjected.Address(RVA = "0x732B730", Offset = "0x732A330", VA = "0x18732B730", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200006E")]
		[CompilerGenerated]
		private struct HKINPOPPIHP : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400044D")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400044E")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400044F")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000450")]
			public int eyeSelection;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000451")]
			public int eyeBrowSelection;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000452")]
			public int noseSelection;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000453")]
			public int mouthSelection;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000454")]
			public CDKJOLAGBOC avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000455")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600037E")]
			[Cpp2IlInjected.Address(RVA = "0x732B270", Offset = "0x7329E70", VA = "0x18732B270", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600037F")]
			[Cpp2IlInjected.Address(RVA = "0x732B440", Offset = "0x732A040", VA = "0x18732B440", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200006F")]
		[CompilerGenerated]
		private struct FOLKICOBEPP : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000456")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000457")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000458")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000459")]
			public FaceFeatureType featureType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x400045A")]
			public int selectionIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400045B")]
			public CDKJOLAGBOC avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400045C")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000380")]
			[Cpp2IlInjected.Address(RVA = "0x732A470", Offset = "0x7329070", VA = "0x18732A470", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000381")]
			[Cpp2IlInjected.Address(RVA = "0x732A610", Offset = "0x7329210", VA = "0x18732A610", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000070")]
		[CompilerGenerated]
		private struct CINBPIHKEKA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400045D")]
			public DIKMCPOCMGD avatarData;
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000071")]
		[CompilerGenerated]
		private struct MIMOFNFHCAJ : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400045E")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400045F")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000460")]
			public DIKMCPOCMGD avatarData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000461")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000462")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000382")]
			[Cpp2IlInjected.Address(RVA = "0x7330290", Offset = "0x732EE90", VA = "0x187330290", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000383")]
			[Cpp2IlInjected.Address(RVA = "0x73307C0", Offset = "0x732F3C0", VA = "0x1873307C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000072")]
		[CompilerGenerated]
		private struct PKNBBFBINFD : IAsyncStateMachine
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
			public CDKJOLAGBOC avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000467")]
			private TaskAwaiter<PLIBLNJGEOH> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000384")]
			[Cpp2IlInjected.Address(RVA = "0x73317D0", Offset = "0x73303D0", VA = "0x1873317D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000385")]
			[Cpp2IlInjected.Address(RVA = "0x7331BF0", Offset = "0x73307F0", VA = "0x187331BF0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000073")]
		[CompilerGenerated]
		private struct BIMPMJLPKBG : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000468")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000469")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400046A")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400046B")]
			public CDKJOLAGBOC avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400046C")]
			private FaceStyleSet <styleSet>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400046D")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000386")]
			[Cpp2IlInjected.Address(RVA = "0x7329740", Offset = "0x7328340", VA = "0x187329740", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000387")]
			[Cpp2IlInjected.Address(RVA = "0x7329C00", Offset = "0x7328800", VA = "0x187329C00", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40003D6")]
		protected const float MAIHFLKJDNM = 0.5f;

		[Cpp2IlInjected.Token(Token = "0x40003D7")]
		protected const int KIHKKDOGHND = 5;

		[Cpp2IlInjected.Token(Token = "0x40003D8")]
		public static readonly int IdleID;

		[Cpp2IlInjected.Token(Token = "0x40003D9")]
		public static readonly int SmileID;

		[Cpp2IlInjected.Token(Token = "0x40003DA")]
		public static readonly int HugeSmileID;

		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		public static readonly int ScoreID;

		[Cpp2IlInjected.Token(Token = "0x40003DC")]
		public static readonly int SadID;

		[Cpp2IlInjected.Token(Token = "0x40003DD")]
		public static readonly int DisgustID;

		[Cpp2IlInjected.Token(Token = "0x40003DE")]
		public static readonly int HitID;

		[Cpp2IlInjected.Token(Token = "0x40003DF")]
		public static readonly int ConcentrateID;

		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		public static readonly int KissID;

		[Cpp2IlInjected.Token(Token = "0x40003E1")]
		public static readonly int TalkingID;

		[Cpp2IlInjected.Token(Token = "0x40003E2")]
		public static readonly int MuteID;

		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		public static readonly int AFKID;

		[Cpp2IlInjected.Token(Token = "0x40003E4")]
		public static readonly int HappyID;

		[Cpp2IlInjected.Token(Token = "0x40003E5")]
		public static readonly int EmoteFlatID;

		[Cpp2IlInjected.Token(Token = "0x40003E6")]
		public static readonly int EmoteHappyID;

		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		public static readonly int EmoteSadID;

		[Cpp2IlInjected.Token(Token = "0x40003E8")]
		public static readonly int EmoteLoveID;

		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		public static readonly int EmoteAngryID;

		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		public static readonly int EmoteLaughID;

		[Cpp2IlInjected.Token(Token = "0x40003EB")]
		public static readonly int EmoteTongueOutID;

		[Cpp2IlInjected.Token(Token = "0x40003EC")]
		public static readonly int EmoteGrimacingID;

		[Cpp2IlInjected.Token(Token = "0x40003ED")]
		public static readonly int EmoteWinkID;

		[Cpp2IlInjected.Token(Token = "0x40003EE")]
		public static readonly int EmoteShockedID;

		[Cpp2IlInjected.Token(Token = "0x40003EF")]
		public static readonly int EmoteNauseatedID;

		[Cpp2IlInjected.Token(Token = "0x40003F0")]
		public static readonly int EmoteSmileSweatID;

		[Cpp2IlInjected.Token(Token = "0x40003F1")]
		public static readonly int EmoteSleepingID;

		[Cpp2IlInjected.Token(Token = "0x40003F2")]
		public static readonly int EmoteThinkingID;

		[Cpp2IlInjected.Token(Token = "0x40003F3")]
		public static readonly int EmoteSmirkID;

		[Cpp2IlInjected.Token(Token = "0x40003F4")]
		public static readonly int EmoteSmileID;

		[Cpp2IlInjected.Token(Token = "0x40003F5")]
		protected static readonly Dictionary<ADCIIIFLNIO.NCBKJGFCDIO, int> MIAHMHFPGHO;

		[Cpp2IlInjected.Token(Token = "0x40003F6")]
		[CanBeNull]
		protected static IEnumerable<FaceFeatureType> BIEOCKEAMNN;

		[Cpp2IlInjected.Token(Token = "0x40003F7")]
		protected static readonly int CBDGMKIJNGJ;

		[Cpp2IlInjected.Token(Token = "0x40003F8")]
		protected static readonly int PJFGEMGHNCB;

		[Cpp2IlInjected.Token(Token = "0x40003F9")]
		protected static readonly int FCKEJCKALCK;

		[Cpp2IlInjected.Token(Token = "0x40003FA")]
		protected static readonly int CKACLAOEDJO;

		[Cpp2IlInjected.Token(Token = "0x40003FB")]
		protected static readonly int MDCDLIJBCMK;

		[Cpp2IlInjected.Token(Token = "0x40003FC")]
		protected static readonly int KEAHJFAHKLD;

		[Cpp2IlInjected.Token(Token = "0x40003FD")]
		protected static readonly int HGNDIIALPBD;

		[Cpp2IlInjected.Token(Token = "0x40003FE")]
		protected static readonly int GLGILDGKNMG;

		[Cpp2IlInjected.Token(Token = "0x40003FF")]
		protected static Vector2 GODJFGOBEPB;

		[Cpp2IlInjected.Token(Token = "0x4000400")]
		protected static Vector2 JGNHNJHOHKI;

		[Cpp2IlInjected.Token(Token = "0x4000401")]
		protected static Vector2 CHKOMAHANMM;

		[Cpp2IlInjected.Token(Token = "0x4000402")]
		protected static Vector2 HEGFGINEMEP;

		[Cpp2IlInjected.Token(Token = "0x4000403")]
		protected static Vector2 GCEPEEMBIJP;

		[Cpp2IlInjected.Token(Token = "0x4000404")]
		protected static Vector2 OOLDENABIKI;

		[Cpp2IlInjected.Token(Token = "0x4000405")]
		protected static Vector2 EDHEKMPFJBO;

		[Cpp2IlInjected.Token(Token = "0x4000406")]
		protected static Vector2 MJDHGPCGDOE;

		[Cpp2IlInjected.Token(Token = "0x4000407")]
		protected static Vector2 NPDICEANMBH;

		[Cpp2IlInjected.Token(Token = "0x4000408")]
		protected static Vector2 JBDOJIPDODK;

		[Cpp2IlInjected.Token(Token = "0x4000409")]
		protected static Vector2 DCPDEBMJCPO;

		[Cpp2IlInjected.Token(Token = "0x400040A")]
		protected static Vector2 NFADIPMFJMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400040B")]
		[NEHJBMHDGNH(EGFPEOBPDHA.Self, false, false, false)]
		[SerializeField]
		public Animator animator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400040C")]
		[SerializeField]
		[Header("Rendering")]
		public FaceStyleSet faceStyleSet;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400040D")]
		[SerializeField]
		protected Renderer faceRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400040E")]
		[SerializeField]
		protected float jitterFPS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400040F")]
		[SerializeField]
		[Header("Emotes")]
		public Renderer[] emoteEffectRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000410")]
		[SerializeField]
		[Header("Modern Avatar Facial Features")]
		[FormerlySerializedAs("fullBodyFaceStyleSet")]
		public FaceStyleSet modernBodyFaceStyleSet;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000411")]
		private CDKJOLAGBOC EPILAJABBLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000412")]
		private FaceStyleSet HDBJPHMNLHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000413")]
		[SerializeField]
		protected bool debugEyeJitterInEditor;

		[Cpp2IlInjected.Token(Token = "0x4000414")]
		protected const int IAGMKFMCIFA = -1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000415")]
		protected int PADMDDANENO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000416")]
		protected int AEPEADGDOMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000417")]
		protected int DAOFGFICMAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000418")]
		protected int JFEPDIKFJMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000419")]
		protected Vector2 DAOAIAHIFOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x400041A")]
		protected float NOGMGJLINOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400041B")]
		protected Vector2 HHDBLMNNAGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400041C")]
		protected float GDPPNMGBGGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x400041D")]
		protected Vector2 EKJOHEIABGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x400041E")]
		protected float MDCGOAJLEBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400041F")]
		protected Vector2 MJCLIFKAODA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000420")]
		protected float OHONDHMGFKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000421")]
		protected List<SelectableFaceOption> BGBLPBCFPLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000422")]
		protected List<SelectableFaceOption> PKDFLMAGDKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000423")]
		protected List<SelectableFaceOption> JGHDODIPEGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000424")]
		protected List<SelectableFaceOption> LEIKOGLOEKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000425")]
		protected Coroutine OPJEANCCDPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000426")]
		protected int? DFFLAOLOLNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000427")]
		protected int APKIHBMNCEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
		[Cpp2IlInjected.Token(Token = "0x4000428")]
		protected int NJKOHHLPBHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000429")]
		protected int IHMIBGKILJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
		[Cpp2IlInjected.Token(Token = "0x400042A")]
		protected int JOGJLNFGLIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400042B")]
		protected int MJKNNLBFENN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
		[Cpp2IlInjected.Token(Token = "0x400042C")]
		protected int ONDGGOAKFCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400042D")]
		protected Sprite OLBFBBELPJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400042E")]
		protected Sprite FFNMOOCBCFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400042F")]
		protected Sprite AHIMJLEOCLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000430")]
		protected Sprite DONJFHIBFGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000431")]
		protected bool HHPAIEAKODG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000433")]
		protected string ILBFEEPIFPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000434")]
		protected string JNJBNBDIHPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000435")]
		protected string OLJGODIGGGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000436")]
		protected string DNHHIGKHMGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000437")]
		[ReadOnlyField]
		public Sprite eyeSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000438")]
		[ReadOnlyField]
		public Sprite leftEyeOnlySprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x4000439")]
		[ReadOnlyField]
		public Sprite rightEyeOnlySprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x400043A")]
		public Color leftEyeColorTint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x400043B")]
		public Color leftEyeGleamColorTint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x400043C")]
		public Color rightEyeColorTint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x400043D")]
		public Color rightEyeGleamColorTint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x400043E")]
		[ReadOnlyField]
		public Sprite mouthSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x4000442")]
		protected AvatarConfiguration BPAOABMFDGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x4000443")]
		protected PLIBLNJGEOH DEDKDIAEBAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x4000445")]
		private readonly List<Material> NLCEEJMINBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x4000446")]
		protected KFJGEEEJJOL ODHCMAHPJCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x4000447")]
		protected Dictionary<string, int> IOPIDALIBGG;

		[Cpp2IlInjected.Token(Token = "0x17000096")]
		public FaceStyleSet CIDOCCCKECA
		{
			[Cpp2IlInjected.Token(Token = "0x6000337")]
			[Cpp2IlInjected.Address(RVA = "0x73379F0", Offset = "0x73365F0", VA = "0x1873379F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000097")]
		public bool OHHMMIABLJG
		{
			[Cpp2IlInjected.Token(Token = "0x600033A")]
			[Cpp2IlInjected.Address(RVA = "0xA28470", Offset = "0xA27070", VA = "0x180A28470", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600033B")]
			[Cpp2IlInjected.Address(RVA = "0x12AD670", Offset = "0x12AC270", VA = "0x1812AD670")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000098")]
		protected virtual bool NOPBJMPLHAN
		{
			[Cpp2IlInjected.Token(Token = "0x600033C")]
			[Cpp2IlInjected.Address(RVA = "0x9A1F50", Offset = "0x9A0B50", VA = "0x1809A1F50", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000099")]
		protected virtual bool DPKGAMEFICJ
		{
			[Cpp2IlInjected.Token(Token = "0x600033D")]
			[Cpp2IlInjected.Address(RVA = "0x9735C0", Offset = "0x9721C0", VA = "0x1809735C0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009A")]
		protected int IAJBNJCCGLB
		{
			[Cpp2IlInjected.Token(Token = "0x600033E")]
			[Cpp2IlInjected.Address(RVA = "0x73341E0", Offset = "0x7332DE0", VA = "0x1873341E0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009B")]
		public Renderer NPKHBEDANMP
		{
			[Cpp2IlInjected.Token(Token = "0x600033F")]
			[Cpp2IlInjected.Address(RVA = "0x9574C0", Offset = "0x9560C0", VA = "0x1809574C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009C")]
		public bool NIEAHCIJDJG
		{
			[Cpp2IlInjected.Token(Token = "0x6000340")]
			[Cpp2IlInjected.Address(RVA = "0x12B0230", Offset = "0x12AEE30", VA = "0x1812B0230")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000341")]
			[Cpp2IlInjected.Address(RVA = "0x12B0540", Offset = "0x12AF140", VA = "0x1812B0540")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		public Renderer[] COGKHBCCCMP
		{
			[Cpp2IlInjected.Token(Token = "0x6000342")]
			[Cpp2IlInjected.Address(RVA = "0x95CEF0", Offset = "0x95BAF0", VA = "0x18095CEF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009E")]
		public bool GBCNAOOPDIJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000343")]
			[Cpp2IlInjected.Address(RVA = "0x7337A30", Offset = "0x7336630", VA = "0x187337A30")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000344")]
			[Cpp2IlInjected.Address(RVA = "0x7337BF0", Offset = "0x73367F0", VA = "0x187337BF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		protected int ALBJNOFPMIO
		{
			[Cpp2IlInjected.Token(Token = "0x6000345")]
			[Cpp2IlInjected.Address(RVA = "0x7333B60", Offset = "0x7332760", VA = "0x187333B60")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A0")]
		protected int ENMEACPJALF
		{
			[Cpp2IlInjected.Token(Token = "0x6000346")]
			[Cpp2IlInjected.Address(RVA = "0x7332000", Offset = "0x7330C00", VA = "0x187332000")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A1")]
		public float PHFDHGFOGFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000347")]
			[Cpp2IlInjected.Address(RVA = "0x7337A10", Offset = "0x7336610", VA = "0x187337A10")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000348")]
			[Cpp2IlInjected.Address(RVA = "0x7337BD0", Offset = "0x73367D0", VA = "0x187337BD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A2")]
		public ANLIIOJHHOE DEKALDBMGOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000349")]
			[Cpp2IlInjected.Address(RVA = "0xAC2510", Offset = "0xAC1110", VA = "0x180AC2510")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600034A")]
			[Cpp2IlInjected.Address(RVA = "0xA29BF0", Offset = "0xA287F0", VA = "0x180A29BF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A3")]
		public PLIBLNJGEOH MABHDEBFBKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000363")]
			[Cpp2IlInjected.Address(RVA = "0xAC2930", Offset = "0xAC1530", VA = "0x180AC2930")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000364")]
			[Cpp2IlInjected.Address(RVA = "0x7337B50", Offset = "0x7336750", VA = "0x187337B50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A4")]
		public NoseFaceOption MHKNFDBKJBM
		{
			[Cpp2IlInjected.Token(Token = "0x6000365")]
			[Cpp2IlInjected.Address(RVA = "0xA29B80", Offset = "0xA28780", VA = "0x180A29B80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000366")]
			[Cpp2IlInjected.Address(RVA = "0x9C0680", Offset = "0x9BF280", VA = "0x1809C0680")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		protected KFJGEEEJJOL FPDMHIMCPDM
		{
			[Cpp2IlInjected.Token(Token = "0x6000367")]
			[Cpp2IlInjected.Address(RVA = "0x7332D90", Offset = "0x7331990", VA = "0x187332D90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action IMOGNHCAEKN
		{
			[Cpp2IlInjected.Token(Token = "0x6000338")]
			[Cpp2IlInjected.Address(RVA = "0x7337940", Offset = "0x7336540", VA = "0x187337940")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000339")]
			[Cpp2IlInjected.Address(RVA = "0x7337AA0", Offset = "0x73366A0", VA = "0x187337AA0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x7333A70", Offset = "0x7332670", VA = "0x187333A70")]
		public void LocalPlayEmote(ADCIIIFLNIO.NCBKJGFCDIO BNBLBPPDHED, float BDNCBNNPOCL = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x73337E0", Offset = "0x73323E0", VA = "0x1873337E0")]
		public bool IsEmotePlaying(ADCIIIFLNIO.NCBKJGFCDIO BNBLBPPDHED)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x7335A90", Offset = "0x7334690", VA = "0x187335A90")]
		public void SetIdleHappy(bool AALIEMGAKCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x7334580", Offset = "0x7333180", VA = "0x187334580")]
		protected void OLJPKOCBALC(bool NNBBBIFBBHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x73330D0", Offset = "0x7331CD0", VA = "0x1873330D0")]
		protected void IEHFKPMGEJO(bool CGGJDAEPIDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x73328B0", Offset = "0x73314B0", VA = "0x1873328B0")]
		protected void DMGDLDLFKAM(MNMFJNIJMID PPCPNOAGMNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0x7331E50", Offset = "0x7330A50", VA = "0x187331E50")]
		protected void APPBAFCEGOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x73352C0", Offset = "0x7333EC0", VA = "0x1873352C0")]
		public void PlayExpression(int LLJMLPGJEKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x7333020", Offset = "0x7331C20", VA = "0x187333020")]
		protected void HINDJKLEEBM(bool PLCKMPGDFFG, bool KJMOAACKFPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x7332FE0", Offset = "0x7331BE0", VA = "0x187332FE0")]
		public List<SelectableFaceOption> GetAvailableFeatures(FaceFeatureType BPDKFEDCAFI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x7333320", Offset = "0x7331F20", VA = "0x187333320")]
		public void InitializeFaceFeatureRanges(AvatarConfiguration BPAOABMFDGK, CDKJOLAGBOC IKFGPFGPALL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x7335870", Offset = "0x7334470", VA = "0x187335870")]
		[AsyncStateMachine(typeof(JAGPCKLCEPK))]
		public Task SetFaceSettings(DIKMCPOCMGD MLDPAOODPLJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x7335960", Offset = "0x7334560", VA = "0x187335960")]
		[AsyncStateMachine(typeof(HKINPOPPIHP))]
		public Task SetFaceSettings(int CDLEIBMBLAC, int IHJMJMFIDFC, int GJFPAOHHDKF, int CMMJLMKMGLA, CDKJOLAGBOC IKFGPFGPALL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0x7335B10", Offset = "0x7334710", VA = "0x187335B10")]
		[AsyncStateMachine(typeof(FOLKICOBEPP))]
		public Task SetSelectedFaceFeatureAndBuildFaceStyle(FaceFeatureType BPDKFEDCAFI, int HMOIECHLBGC, CDKJOLAGBOC IKFGPFGPALL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0x7335140", Offset = "0x7333D40", VA = "0x187335140")]
		protected void POKPJDGLHBF(FaceFeatureType BPDKFEDCAFI, NLHBBDJJAEA OBONKPCJCHL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x7332150", Offset = "0x7330D50", VA = "0x187332150")]
		protected void CJJGAOLGCIH(FaceFeatureType BPDKFEDCAFI, int HMOIECHLBGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0x7332E10", Offset = "0x7331A10", VA = "0x187332E10")]
		public static IEnumerable<FaceFeatureType> GetAllFaceFeatureTypes()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0x7334E40", Offset = "0x7333A40", VA = "0x187334E40")]
		[AsyncStateMachine(typeof(MIMOFNFHCAJ))]
		protected Task OOLMILLHHFP(DIKMCPOCMGD MLDPAOODPLJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x7334310", Offset = "0x7332F10", VA = "0x187334310")]
		protected static void OHGKBJPNKCF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x7332A50", Offset = "0x7331650", VA = "0x187332A50")]
		private void EFBBMELFBMN(bool GABBEKGKABE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x7333E70", Offset = "0x7332A70", VA = "0x187333E70")]
		protected void NAHHAENOOOP(FaceFeatureType BPDKFEDCAFI, Vector2 PFCHJINOOCB, CDKJOLAGBOC IKFGPFGPALL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x73352E0", Offset = "0x7333EE0", VA = "0x1873352E0")]
		public void SetFaceFeatureNormalizedPositionOffset(FaceFeatureType BPDKFEDCAFI, Vector2 EMJBPHDOBOM, CDKJOLAGBOC IKFGPFGPALL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x73338F0", Offset = "0x73324F0", VA = "0x1873338F0")]
		protected void JEJHOMDJEHC(FaceFeatureType BPDKFEDCAFI, float IEEJKDCNOLD, CDKJOLAGBOC IKFGPFGPALL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x7335650", Offset = "0x7334250", VA = "0x187335650")]
		public void SetFaceFeatureNormalizedScaleOffset(FaceFeatureType BPDKFEDCAFI, float JLLADDIKABO, CDKJOLAGBOC IKFGPFGPALL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(RVA = "0x73344A0", Offset = "0x73330A0", VA = "0x1873344A0")]
		[AsyncStateMachine(typeof(PKNBBFBINFD))]
		protected Task OJJOHLMKACA(CDKJOLAGBOC IKFGPFGPALL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x73335D0", Offset = "0x73321D0", VA = "0x1873335D0")]
		public void InitializeFaceFeatureStyleSet(CDKJOLAGBOC IKFGPFGPALL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x7332CB0", Offset = "0x73318B0", VA = "0x187332CB0")]
		protected bool GJJNIHFGLMM(string CPMGMCKJIEH, [Out] int BIEEMEKMINN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x7331EC0", Offset = "0x7330AC0", VA = "0x187331EC0")]
		protected void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x1314150", Offset = "0x1312D50", VA = "0x181314150", Slot = "8")]
		protected virtual void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x7334F30", Offset = "0x7333B30", VA = "0x187334F30")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x7336AE0", Offset = "0x73356E0", VA = "0x187336AE0")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x7332060", Offset = "0x7330C60", VA = "0x187332060")]
		[AsyncStateMachine(typeof(BIMPMJLPKBG))]
		public Task BuildFaceStyleAsyncIfChanged(CDKJOLAGBOC IKFGPFGPALL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x7336410", Offset = "0x7335010", VA = "0x187336410")]
		public void UpdateFaceDisplays(bool KPABIMOBDKJ = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x7334600", Offset = "0x7333200", VA = "0x187334600")]
		protected bool OMPKKIMIFFN(bool KPABIMOBDKJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x7336130", Offset = "0x7334D30", VA = "0x187336130")]
		public void UpdateFaceDisplayFeatureTextures()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x7335C20", Offset = "0x7334820", VA = "0x187335C20")]
		public void UpdateFaceDisplayFeaturePositions()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x7336620", Offset = "0x7335220", VA = "0x187336620")]
		public void UpdateFaceJitterMultiplier()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x7336810", Offset = "0x7335410", VA = "0x187336810")]
		public bool UpdateLegacyFaceVectors()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x7333230", Offset = "0x7331E30", VA = "0x187333230")]
		protected void IKEKAGDDALM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x7333BC0", Offset = "0x73327C0", VA = "0x187333BC0")]
		private void NACGNMECLPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x73376F0", Offset = "0x73362F0", VA = "0x1873376F0")]
		public PlayerFacialAnimatorBase()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x985A00", Offset = "0x984600", VA = "0x180985A00", Slot = "4")]
		private bool DGIDCMLKFAK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x7332920", Offset = "0x7331520", VA = "0x187332920")]
		[CompilerGenerated]
		internal static BHIKMOBHGNK EEHGLBIEMFD(FaceFeatureType BPDKFEDCAFI, CINBPIHKEKA P_1)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public struct IGPJOBFGDEI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400046E")]
	public string NMFKAOGOELC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400046F")]
	public int BJDOFIJCIKK;
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
		private struct POHDIBHEPFF : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004CF")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40004D0")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004D1")]
			public PlayerModernBodyEditorAvatarValidator <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004D2")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003BA")]
			[Cpp2IlInjected.Address(RVA = "0x7331C50", Offset = "0x7330850", VA = "0x187331C50", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003BB")]
			[Cpp2IlInjected.Address(RVA = "0xA47DB0", Offset = "0xA469B0", VA = "0x180A47DB0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000078")]
		[CompilerGenerated]
		private struct HAJCIGHKJEF : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004D3")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40004D4")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004D5")]
			public PlayerModernBodyEditorAvatarValidator <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004D6")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003BC")]
			[Cpp2IlInjected.Address(RVA = "0x732AD10", Offset = "0x7329910", VA = "0x18732AD10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003BD")]
			[Cpp2IlInjected.Address(RVA = "0x732B210", Offset = "0x7329E10", VA = "0x18732B210", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000470")]
		public const string IDLE_ANIM_NAME = "Idle";

		[Cpp2IlInjected.Token(Token = "0x4000471")]
		public const string A_POSE_ANIM_NAME = "A Pose";

		[Cpp2IlInjected.Token(Token = "0x4000472")]
		public const string ANIMATION_OVERRIDE_STATE_NAME = "Override";

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000473")]
		public CDKJOLAGBOC avatarBodyType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000475")]
		public Color hairPrimaryColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000476")]
		public Color hairSecondaryColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000477")]
		public Color beardPrimaryColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000478")]
		public Color beardSecondaryColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000479")]
		public Color skinColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x400047A")]
		public int faceShapeIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400047B")]
		public int bodyShapeIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x400047C")]
		public int hairPatternIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400047D")]
		public int beardPatternIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400047E")]
		public AvatarFaceShape[] faceShapes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400047F")]
		public AvatarBodyShape[] bodyShapes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000480")]
		public AvatarHairPattern[] hairPatterns;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000481")]
		public float _avatarScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x4000482")]
		public bool enablePosing;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000483")]
		public int poseIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000484")]
		public AnimationClip animationOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000485")]
		[Range(0f, 4f)]
		public float animationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x4000486")]
		public bool hideEars;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000487")]
		public GBOFEGMEOKI useHelmetHair;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000488")]
		public IFMFMHOGADG hatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000489")]
		public AOEHHBOAGNP HatAnchorRestrictions;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400048A")]
		public bool UseHairFitMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD1")]
		[Cpp2IlInjected.Token(Token = "0x400048B")]
		public bool usesHatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400048C")]
		public GameObject hatPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400048D")]
		public GameObject hairPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400048E")]
		public GameObject earPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400048F")]
		public GameObject eyePrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000490")]
		public GameObject mouthPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000491")]
		public GameObject neckPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000492")]
		public GameObject shirtPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000493")]
		public GameObject beltPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000494")]
		public GameObject shoulderPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000495")]
		public GameObject rightHandPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000496")]
		public GameObject leftHandPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000497")]
		public GameObject legsPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000498")]
		public GameObject feetPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000499")]
		public AMLHELBFOLA.MCCCALMIAAN baseSkinCullingMask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x400049A")]
		[SerializeField]
		[NEHJBMHDGNH(EGFPEOBPDHA.Self, false, false, false)]
		public PlayerAvatarDisplayBase _avatarDisplay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x400049B")]
		private NGJPFIHJGDI JCDCGHJELJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x400049C")]
		[SerializeField]
		[NEHJBMHDGNH(EGFPEOBPDHA.Self, false, false, false)]
		public PlayerFacialAnimatorBase facialAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x400049D")]
		public Animator animator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x400049E")]
		public AnimationClip animationClipToOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x400049F")]
		private AnimatorOverrideController BDPMBOMBPCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		private List<KeyValuePair<AnimationClip, AnimationClip>> JHPOCENEBPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		public Transform headIKEffector;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		public Transform leftHandIKEffector;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		public Transform rightHandIKEffector;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x40004A4")]
		[Range(0f, 2f)]
		public int lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19C")]
		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		public int rightHandGestureStateIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		[Range(0f, 1f)]
		public float rightHandCurl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A4")]
		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		public int leftHandGestureStateIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		[Range(0f, 1f)]
		public float leftHandCurl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1AC")]
		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		public int eyeBrowSelection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x40004AA")]
		public int eyeSelection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B4")]
		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		public int noseSelection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		public int mouthSelection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1BC")]
		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		public float eyeBrowPositionOffsetHorizontal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		public float eyeBrowPositionOffsetVertical;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C4")]
		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		public float eyeBrowScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x40004B0")]
		public float eyePositionOffsetHorizontal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1CC")]
		[Cpp2IlInjected.Token(Token = "0x40004B1")]
		public float eyePositionOffsetVertical;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x40004B2")]
		public float eyeScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D4")]
		[Cpp2IlInjected.Token(Token = "0x40004B3")]
		public float nosePositionOffsetVertical;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x40004B4")]
		public float noseScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1DC")]
		[Cpp2IlInjected.Token(Token = "0x40004B5")]
		public float mouthPositionOffsetHorizontal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x40004B6")]
		public float mouthPositionOffsetVertical;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E4")]
		[Cpp2IlInjected.Token(Token = "0x40004B7")]
		public float mouthScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x40004B8")]
		public float hatNormalizedPositionX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1EC")]
		[Cpp2IlInjected.Token(Token = "0x40004B9")]
		public float hatNormalizedPositionY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
		[Cpp2IlInjected.Token(Token = "0x40004BA")]
		public Vector3 hatHemispherePositionOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1FC")]
		[Cpp2IlInjected.Token(Token = "0x40004BB")]
		public Vector3 hatHemisphereRotationOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
		[Cpp2IlInjected.Token(Token = "0x40004BC")]
		public int facialExpressionIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20C")]
		[Cpp2IlInjected.Token(Token = "0x40004BD")]
		[Range(0f, 1f)]
		public float normalizedTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
		[Cpp2IlInjected.Token(Token = "0x40004BE")]
		public readonly IGPJOBFGDEI[] FacialExpressions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
		[Cpp2IlInjected.Token(Token = "0x40004BF")]
		public readonly string[] BodyPoses;

		[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
		[Cpp2IlInjected.Token(Token = "0x40004C0")]
		public readonly (string, PMDBBMEEGON)[] HandPoses;

		[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
		[Cpp2IlInjected.Token(Token = "0x40004C1")]
		public bool hideLeftWatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x229")]
		[Cpp2IlInjected.Token(Token = "0x40004C2")]
		public bool hideRightWatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x22A")]
		[Cpp2IlInjected.Token(Token = "0x40004C3")]
		protected bool HCJHBFOPPPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x22C")]
		[Cpp2IlInjected.Token(Token = "0x40004C4")]
		protected Guid BFDLEBGGMDI;

		[Cpp2IlInjected.Token(Token = "0x40004C5")]
		protected static Guid NIGNHJNHHJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
		[Cpp2IlInjected.Token(Token = "0x40004C6")]
		private DDHFIFHCKBI EACGEPEHNOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
		[Cpp2IlInjected.Token(Token = "0x40004C7")]
		private ANLIIOJHHOE CPBIJACNNKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
		[Cpp2IlInjected.Token(Token = "0x40004C8")]
		private FLDOCHEELKL NDAPCOAAION;

		[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
		[Cpp2IlInjected.Token(Token = "0x40004C9")]
		private FLDOCHEELKL GFGHCLJABKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x40004CA")]
		private AdditionalHatData PEPANFDOCIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
		[Cpp2IlInjected.Token(Token = "0x40004CB")]
		private readonly Dictionary<GameObject, JGMJCPJCOGN> LGDBMAAHPFG;

		[Cpp2IlInjected.Token(Token = "0x170000A6")]
		public static Func<BHEPFEOINOK> DBEJJJCBFHO
		{
			[Cpp2IlInjected.Token(Token = "0x6000388")]
			[Cpp2IlInjected.Address(RVA = "0x733CC40", Offset = "0x733B840", VA = "0x18733CC40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000389")]
			[Cpp2IlInjected.Address(RVA = "0x733D2A0", Offset = "0x733BEA0", VA = "0x18733D2A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A7")]
		public bool NFBHCFLGNEK
		{
			[Cpp2IlInjected.Token(Token = "0x600038A")]
			[Cpp2IlInjected.Address(RVA = "0x733CDA0", Offset = "0x733B9A0", VA = "0x18733CDA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A8")]
		public bool ILMIIAPLBBJ
		{
			[Cpp2IlInjected.Token(Token = "0x600038B")]
			[Cpp2IlInjected.Address(RVA = "0x733CC90", Offset = "0x733B890", VA = "0x18733CC90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A9")]
		public PlayerAvatarDisplayBase JGCKKIGKPBG
		{
			[Cpp2IlInjected.Token(Token = "0x600038D")]
			[Cpp2IlInjected.Address(RVA = "0x9BA060", Offset = "0x9B8C60", VA = "0x1809BA060")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AA")]
		protected static Guid BGLDBIKIPMD
		{
			[Cpp2IlInjected.Token(Token = "0x600038E")]
			[Cpp2IlInjected.Address(RVA = "0x733A4A0", Offset = "0x73390A0", VA = "0x18733A4A0")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AB")]
		public (GameObject, MNMFJNIJMID)[] HEMKKEFBJMC
		{
			[Cpp2IlInjected.Token(Token = "0x60003A4")]
			[Cpp2IlInjected.Address(RVA = "0x733CEB0", Offset = "0x733BAB0", VA = "0x18733CEB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x7338260", Offset = "0x7336E60", VA = "0x187338260")]
		private IEnumerable<GameObject> AOILLGMHFCC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x733AE70", Offset = "0x7339A70", VA = "0x18733AE70")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x733A8B0", Offset = "0x73394B0", VA = "0x18733A8B0")]
		private void PFAAHDJOHCC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x10735B0", Offset = "0x10721B0", VA = "0x1810735B0")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x7339D10", Offset = "0x7338910", VA = "0x187339D10")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x733AE80", Offset = "0x7339A80", VA = "0x18733AE80")]
		public void Teardown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x733AC70", Offset = "0x7339870", VA = "0x18733AC70")]
		public void ShowPose(AnimationClip CBPEDMNKLFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x733AE40", Offset = "0x7339A40", VA = "0x18733AE40")]
		public void ShowPose(string OCMHCIJMIHJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x733AAD0", Offset = "0x73396D0", VA = "0x18733AAD0")]
		public void ResetPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x733A990", Offset = "0x7339590", VA = "0x18733A990")]
		public void ResetHandPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x733B950", Offset = "0x733A550", VA = "0x18733B950")]
		public void UpdateHandAnimation()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x733B7A0", Offset = "0x733A3A0", VA = "0x18733B7A0")]
		public void UpdateFaceAndBodyShapes(bool MAPCCPLDLID = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x733BD50", Offset = "0x733A950", VA = "0x18733BD50")]
		public void UpdateNoseShape(FHEDEKPEKPL ONBMAEJIILK, bool MAPCCPLDLID = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x733BD20", Offset = "0x733A920", VA = "0x18733BD20")]
		public void UpdateLODOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x7338C80", Offset = "0x7337880", VA = "0x187338C80", Slot = "4")]
		protected virtual void BBNCEECKCLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x733A640", Offset = "0x7339240", VA = "0x18733A640", Slot = "5")]
		protected virtual void ONPGNEADMOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x73388B0", Offset = "0x73374B0", VA = "0x1873388B0")]
		public void ApplyHatData(AdditionalHatData NKPFILBGHPO, bool JLIPINBKOME = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x73386F0", Offset = "0x73372F0", VA = "0x1873386F0")]
		public void ApplyHatAdjustmentsToHatAnchorParams()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x7338C10", Offset = "0x7337810", VA = "0x187338C10")]
		public void ApplyHatUVOverride(Vector2 NDKBOFMNICD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x7338B30", Offset = "0x7337730", VA = "0x187338B30")]
		public void ApplyHatPositionAdjustment(Vector3 MIOCMGGGEMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x7338BA0", Offset = "0x73377A0", VA = "0x187338BA0")]
		public void ApplyHatRotationAdjustment(Vector3 JDEENLMLIDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x7338F80", Offset = "0x7337B80", VA = "0x187338F80")]
		public GDANPJFMKLK BuildAvatarItemSelection(GameObject FGGCALODLFC, CDKJOLAGBOC KKOJCMMPONK, MNMFJNIJMID MABMNACPLLH)
		{
			return default(GDANPJFMKLK);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0x7339020", Offset = "0x7337C20", VA = "0x187339020")]
		public void BuildAvatar(bool MAPCCPLDLID = false, bool JLIPINBKOME = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x733B1E0", Offset = "0x7339DE0", VA = "0x18733B1E0")]
		public void UpdateColors()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x7338830", Offset = "0x7337430", VA = "0x187338830")]
		public void ApplyHatAnchor()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0x733BB70", Offset = "0x733A770", VA = "0x18733BB70")]
		public void UpdateHatAnchor(bool JLIPINBKOME = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x733B8A0", Offset = "0x733A4A0", VA = "0x18733B8A0")]
		[AsyncStateMachine(typeof(POHDIBHEPFF))]
		public void UpdateFaceFeatures()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0x7339620", Offset = "0x7338220", VA = "0x187339620")]
		[AsyncStateMachine(typeof(HAJCIGHKJEF))]
		private Task GLKAJJNIGIL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0x7339A50", Offset = "0x7338650", VA = "0x187339A50")]
		private void INJNNMANJDC(FaceFeatureType FACNBFFLCDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x733A410", Offset = "0x7339010", VA = "0x18733A410")]
		private void KAFLMPHKBMD(FaceFeatureType FACNBFFLCDI, [Out] float OOCJBICOPMB, [Out] float JCDMPCDPOOO, [Out] float PCNANBOKIPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x733B660", Offset = "0x733A260", VA = "0x18733B660")]
		public void UpdateEmote()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x733BA00", Offset = "0x733A600", VA = "0x18733BA00")]
		public void UpdateHandPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x7337D40", Offset = "0x7336940", VA = "0x187337D40")]
		private void ANJKLIHLMHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0")]
		private void AHJMKGDFBOJ(JGMJCPJCOGN AFGAPBEIFIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0")]
		private void HOKJDDJINDF(JGMJCPJCOGN AFGAPBEIFIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x73396F0", Offset = "0x73382F0", VA = "0x1873396F0")]
		private void IDIHIDHBKFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x733BDD0", Offset = "0x733A9D0", VA = "0x18733BDD0")]
		public PlayerModernBodyEditorAvatarValidator()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x733A590", Offset = "0x7339190", VA = "0x18733A590")]
		[CompilerGenerated]
		private GDANPJFMKLK KMJLMLGGJIJ((GameObject, MNMFJNIJMID) JPKPPBCDJMB)
		{
			return default(GDANPJFMKLK);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	public class SkinnedMeshBonesInspector : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004D7")]
		[SerializeField]
		[NEHJBMHDGNH(EGFPEOBPDHA.Self, false, false, false)]
		private SkinnedMeshRenderer skinnedMeshRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004D8")]
		[SerializeField]
		private int BoneWeightsDisplayStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40004D9")]
		[SerializeField]
		private int BoneWeightsDisplayAmount;

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x959590", Offset = "0x958190", VA = "0x180959590")]
		public SkinnedMeshBonesInspector()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public struct GDANPJFMKLK
{
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[CompilerGenerated]
	private sealed class DBACLLBLFGE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004DC")]
		public IEnumerable<OutfitType> otherOutfitTypes;

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public DBACLLBLFGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x7329CD0", Offset = "0x73288D0", VA = "0x187329CD0")]
		internal bool JKIGAPLLBEB(OutfitType outfitType)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004DA")]
	private JGMJCPJCOGN JDJODECPFFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004DB")]
	private MNMFJNIJMID EKOCIKHJDNB;

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public JGMJCPJCOGN OMFCCEKPEKB
	{
		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0xBDB480", Offset = "0xBDA080", VA = "0x180BDB480")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public MNMFJNIJMID AHLPEEMEPKB
	{
		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x2538D50", Offset = "0x2537950", VA = "0x182538D50")]
		get
		{
			return default(MNMFJNIJMID);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public string LOAPAONIPPO
	{
		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x732A730", Offset = "0x7329330", VA = "0x18732A730")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public bool OGHILHNNDNI
	{
		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x732AAD0", Offset = "0x73296D0", VA = "0x18732AAD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public bool CBJOPPLICNC
	{
		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x732AA80", Offset = "0x7329680", VA = "0x18732AA80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0xAB5D40", Offset = "0xAB4940", VA = "0x180AB5D40")]
	public GDANPJFMKLK(JGMJCPJCOGN AFGAPBEIFIA, MNMFJNIJMID PPCPNOAGMNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x732A670", Offset = "0x7329270", VA = "0x18732A670")]
	public bool AMJMILHFEAF(OutfitType EDLPLIKJJGA, MNMFJNIJMID GJCEONLLHNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x732A820", Offset = "0x7329420", VA = "0x18732A820")]
	public bool JAECGEAGLHK(OutfitType EDLPLIKJJGA, MNMFJNIJMID GJCEONLLHNE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x732AB20", Offset = "0x7329720", VA = "0x18732AB20")]
	public bool PMJDFJAGPFO(GDANPJFMKLK PBKMNJEKGKD)
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
