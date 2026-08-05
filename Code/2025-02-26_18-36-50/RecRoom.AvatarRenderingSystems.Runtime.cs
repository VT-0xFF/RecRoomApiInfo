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
	public class LogRegistrationIndex : EIAOKFHFGKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x72B56B0", Offset = "0x72B4AB0", VA = "0x1872B56B0", Slot = "4")]
		public override void OCICFIBHEPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x9748B0", Offset = "0x973CB0", VA = "0x1809748B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x94B9D0", Offset = "0x94ADD0", VA = "0x18094B9D0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override string AssetGUID
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x72BBF70", Offset = "0x72BB370", VA = "0x1872BBF70", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x72BBF00", Offset = "0x72BB300", VA = "0x1872BBF00", Slot = "17")]
		public override bool RuntimeKeyIsValid()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x72BBF30", Offset = "0x72BB330", VA = "0x1872BBF30")]
		public RecNetCDNAssetReference(RecNetCDNKey LKMGECEEGEE)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class RecNetCDNKey
	{
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public enum HCDEKIODBAJ : byte
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
			[Cpp2IlInjected.Address(RVA = "0x949410", Offset = "0x948810", VA = "0x180949410")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x949400", Offset = "0x948800", VA = "0x180949400")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public string UniqueItemIdentifier
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x94B6B0", Offset = "0x94AAB0", VA = "0x18094B6B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x94B9B0", Offset = "0x94ADB0", VA = "0x18094B9B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public string CacheHash
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x94B800", Offset = "0x94AC00", VA = "0x18094B800")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x94BA00", Offset = "0x94AE00", VA = "0x18094BA00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RecNetCDNKey Dependency
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x94B9E0", Offset = "0x94ADE0", VA = "0x18094B9E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x94B7E0", Offset = "0x94ABE0", VA = "0x18094B7E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool AttemptPrecacheLookup
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x978140", Offset = "0x977540", VA = "0x180978140")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x977EC0", Offset = "0x9772C0", VA = "0x180977EC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public HCDEKIODBAJ PathHint
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xC3E0F0", Offset = "0xC3D4F0", VA = "0x180C3E0F0")]
			[CompilerGenerated]
			get
			{
				return default(HCDEKIODBAJ);
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x11075F0", Offset = "0x11069F0", VA = "0x1811075F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string ItemPath
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x72BC080", Offset = "0x72BB480", VA = "0x1872BC080")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x72BC000", Offset = "0x72BB400", VA = "0x1872BC000")]
		public static RecNetCDNKey HNDKJCJHHIB(string GIBLLGOENJK, HCDEKIODBAJ MJNGGKMDGNO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x72BBFB0", Offset = "0x72BB3B0", VA = "0x1872BBFB0")]
		public void FHEGHKAAMBH(string HODIIHGJIOP, string MGPEIJNPFNJ, bool JJEFKMNMPJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public RecNetCDNKey()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[GAFKBMEFLIK]
public class NJGDPEGMCOM : HPHBLHCBCNN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	protected readonly List<Mesh> IEJIBIKPCAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	protected readonly List<byte[]> CPCIAGOBCCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	protected readonly List<Matrix4x4> AMJPKONOOLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	protected readonly List<bool> HGDAJCAMMOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	protected readonly List<int> MCNGCOAMNBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	protected readonly List<bool> DLENPHMHHMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	protected readonly List<int> KAIKEDPEFMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	protected Allocator MEAIHGPJCLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	protected LDBIEKJHPFI LNKNIMJBKIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	protected byte BGMDNHPGKFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	protected IList<int> CJICBPPNIIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	protected IList<int> MKPIEEOMKOK;

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x72B9FA0", Offset = "0x72B93A0", VA = "0x1872B9FA0", Slot = "4")]
	public void BMFCBKCPPJP(Mesh LCGHOEMEOEK, Matrix4x4 OGMKAOPLLDA, byte[] FFEHGHDGBPA, bool CBFKEKGDGGD = false, KBAIGJMAONF.FALICHFPADL IPOKALCDIKI = (KBAIGJMAONF.FALICHFPADL)0, int ELAEEHODNCP = -1, bool MBLBPIKGHBL = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x72BA1B0", Offset = "0x72B95B0", VA = "0x1872BA1B0", Slot = "5")]
	public void JKGNMOLLMOL(Allocator LEILKJFLDFN, LDBIEKJHPFI KKPPEJOKKDF, byte DDBNJCIKGBE, [Optional] IList<int> MPNCJGPMPPN, [Optional] IList<int> KKBDINDOJJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x72BA1F0", Offset = "0x72B95F0", VA = "0x1872BA1F0")]
	private static void PGMACMDMPGL(Mesh LCGHOEMEOEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x72BA450", Offset = "0x72B9850", VA = "0x1872BA450")]
	public NJGDPEGMCOM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[GAFKBMEFLIK]
public struct NHGBMFDPIOK : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	[ReadOnly]
	public PDBKIDCBHPE FBAIBDOFCNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	[ReadOnly]
	public int JHFADOMOOGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public MMONHKFFOCH DFGJCDCKNNI;

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x72B84C0", Offset = "0x72B78C0", VA = "0x1872B84C0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[NativeContainer]
[GAFKBMEFLIK]
public struct MMONHKFFOCH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct FENLDKNBJMO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public Vector3 PEFHDEMGOJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public Vector3 FGKLFPNFOKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public Vector4 OBJCIKCFCIL;
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct JPPLFJGMGBB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public float BPMIJIOPKPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public float HMNGDNCOFNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public float EJKNFNJHGFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public float KBFFAEGPFMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public byte PGNOEJKIGDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public byte JCKEALEEMEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public byte ACCOEAACPBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public byte NNLPLAAANEG;
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct NCAMJABCDGD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public half BPMIJIOPKPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public half HMNGDNCOFNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public half EJKNFNJHGFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public half KBFFAEGPFMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public byte PGNOEJKIGDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public byte JCKEALEEMEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public byte ACCOEAACPBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public byte NNLPLAAANEG;
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct NPLLLLHJHMD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public half4 NHCBHMJDLHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public half2 MGPEGLKOEGN;
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public struct BDCBPFOIIKB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public half4 NHCBHMJDLHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public half2 MGPEGLKOEGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public half2 BIKBGJJMFED;
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct BMOOIMCBCLP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public half4 NHCBHMJDLHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public half2 MGPEGLKOEGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public half2 BIKBGJJMFED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public half2 PJLCOIJPIGL;
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public struct DFHMFJJOADF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public half4 NHCBHMJDLHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public half2 MGPEGLKOEGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public half2 BIKBGJJMFED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public half2 PJLCOIJPIGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public half2 NOHDKIBMBNK;
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public struct FDLMMHLCMIH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public float BPMIJIOPKPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public float HMNGDNCOFNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public float EJKNFNJHGFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public float KBFFAEGPFMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public int PGNOEJKIGDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public int JCKEALEEMEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public int ACCOEAACPBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public int NNLPLAAANEG;
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public struct LOBMBCDOEOO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public Color NHCBHMJDLHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public Vector2 MGPEGLKOEGN;
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public struct FPEMFCJJAAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public Color NHCBHMJDLHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public Vector2 MGPEGLKOEGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public Vector2 BIKBGJJMFED;
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public struct DJEEEGJBOKO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Color NHCBHMJDLHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public Vector2 MGPEGLKOEGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public Vector2 BIKBGJJMFED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Vector2 PJLCOIJPIGL;
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public struct FOBJDEFLOAG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public Color NHCBHMJDLHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public Vector2 MGPEGLKOEGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public Vector2 BIKBGJJMFED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public Vector2 PJLCOIJPIGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public Vector2 NOHDKIBMBNK;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private bool FMOGDINNGMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public NativeArray<FENLDKNBJMO> OCAIDAJALBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public NativeArray<NPLLLLHJHMD> EAAMPDCGNNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public NativeArray<BDCBPFOIIKB> MCEGJJPLMBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public NativeArray<BMOOIMCBCLP> JLKNIFIODMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public NativeArray<DFHMFJJOADF> JLPEMAAECEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public NativeArray<NCAMJABCDGD> CIPEGAFJKHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public NativeArray<JPPLFJGMGBB> AJDPBINIIGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public NativeArray<LOBMBCDOEOO> MGKNOKEGHBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public NativeArray<FPEMFCJJAAM> COEOELAJKMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public NativeArray<DJEEEGJBOKO> HDHPHCCMEHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public NativeArray<FOBJDEFLOAG> DPAOENLAEEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public NativeArray<FDLMMHLCMIH> NGLAKHNONKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public NativeArray<int> BJHAHFBHIIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public NativeArray<int> JGLDDBAALLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private NativeArray<int> HAMIKIAMKCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private NativeArray<int> GNFLPDPHGLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public NativeArray<int> PBAPNCFANJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public NativeArray<int> PBBOIIKEKLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public NativeArray<int> ABEBHMJIFGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public NativeArray<BoneWeight> DCJEJNMJFBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private NativeArray<int> FJJOKDBOKAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private bool ACAFJGKPGAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x159")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private bool LAMMAOBONGB;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int GMBBBJCHFML
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x72B5FF0", Offset = "0x72B53F0", VA = "0x1872B5FF0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x72B6700", Offset = "0x72B5B00", VA = "0x1872B6700")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int FKDAOBCELNH
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x72B66E0", Offset = "0x72B5AE0", VA = "0x1872B66E0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x72B57A0", Offset = "0x72B4BA0", VA = "0x1872B57A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int BIJLPBFCEML
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x72B5880", Offset = "0x72B4C80", VA = "0x1872B5880")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x72B66F0", Offset = "0x72B5AF0", VA = "0x1872B66F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int MCPONCKMDGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x72B5AF0", Offset = "0x72B4EF0", VA = "0x1872B5AF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x72B7A90", Offset = "0x72B6E90", VA = "0x1872B7A90")]
	public MMONHKFFOCH(int DCAPCHJBFBL, int KIJGJIIFKFG, int JGOLOKHACFH, int KMLBPKIICHM, Allocator LEILKJFLDFN, int PJIBNECOEEF, NNBGPGNKBMB CBJDPLCEFOH, bool ACAFJGKPGAH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x72B5F60", Offset = "0x72B5360", VA = "0x1872B5F60")]
	public void HHPMHFMNAJF(int EAHKFAJBNDN, Vector3 EFDAGALIIFI, Vector3 EOJJAMCHAEH, Vector4 CHBEBLKFDBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x72B6710", Offset = "0x72B5B10", VA = "0x1872B6710")]
	public void OKJKLFJLGAK(int EAHKFAJBNDN, BoneWeight OMGFMBIBPEF, NativeSlice<byte> FFEHGHDGBPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x72B63B0", Offset = "0x72B57B0", VA = "0x1872B63B0")]
	public Color JNLBMPGFNHP(int EAHKFAJBNDN)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x72B5B60", Offset = "0x72B4F60", VA = "0x1872B5B60")]
	public void HEJAGELOGAE(int EAHKFAJBNDN, Color OPLPABIPAJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x72B6000", Offset = "0x72B5400", VA = "0x1872B6000")]
	public void HPCGJKIOAEP(byte PNAPGIMAEDK, int EAHKFAJBNDN, Vector2 JLECHKDJMOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x72B6B40", Offset = "0x72B5F40", VA = "0x1872B6B40")]
	public void ONEPFBFBNOF(int EAHKFAJBNDN, int LFPNFLHKPCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x72B5740", Offset = "0x72B4B40", VA = "0x1872B5740")]
	public bool ABJNLCGOEJM(int PNAPGIMAEDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x72B57B0", Offset = "0x72B4BB0", VA = "0x1872B57B0")]
	public void APGKCNCJEMG(int GCNALCOKJIM, int FDJGEFDKBBO, int GIGAFKHMOHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x72B5890", Offset = "0x72B4C90", VA = "0x1872B5890", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x72B6B50", Offset = "0x72B5F50", VA = "0x1872B6B50")]
	public Mesh PCNJPGHJCAK([Optional] string IHJJNKIBIDE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[DefaultMember("Item")]
[GAFKBMEFLIK]
[NativeContainer]
public struct PDBKIDCBHPE : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public Mesh.MeshDataArray BABMALAMNBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public NativeArray<int> ECICEFOMBEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public NativeArray<int> HJCAIMNKFOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public NativeArray<BoneWeight> DCJEJNMJFBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private NativeArray<Matrix4x4> IEGPKLJFIPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private NativeArray<int> PCGCNHMBOII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private NativeArray<byte> MNDAPPCMLNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private NativeArray<int> BGDEOHHMEIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private NativeArray<int> GPIMJGLPKAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public NativeArray<sbyte> CBPNDGKJKKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public NativeArray<byte> IMBLHDMFKOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public NativeArray<bool> MBLBPIKGHBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public NativeArray<int> ELAEEHODNCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private bool ACAFJGKPGAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private NativeArray<int> LJCGAEHNNDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private bool LAMMAOBONGB;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int AILANCGLNEN
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x72BA9A0", Offset = "0x72B9DA0", VA = "0x1872BA9A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int IPNIHLGMKHD
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x72BA7F0", Offset = "0x72B9BF0", VA = "0x1872BA7F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int AKEIDLPADKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x72BAC50", Offset = "0x72BA050", VA = "0x1872BAC50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int NGNEIPBLGEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x72BA9B0", Offset = "0x72B9DB0", VA = "0x1872BA9B0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x72BAC30", Offset = "0x72BA030", VA = "0x1872BAC30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int GMBBBJCHFML
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x72BA990", Offset = "0x72B9D90", VA = "0x1872BA990")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x72BAC20", Offset = "0x72BA020", VA = "0x1872BAC20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public int KLOCEPDAPGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x72BA700", Offset = "0x72B9B00", VA = "0x1872BA700")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x72BA7E0", Offset = "0x72B9BE0", VA = "0x1872BA7E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public LDBIEKJHPFI NEICIGCPFDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x72BAC40", Offset = "0x72BA040", VA = "0x1872BAC40")]
		get
		{
			return default(LDBIEKJHPFI);
		}
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x72BA970", Offset = "0x72B9D70", VA = "0x1872BA970")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public byte PEEONGELKEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x72BA980", Offset = "0x72B9D80", VA = "0x1872BA980")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x72BAC10", Offset = "0x72BA010", VA = "0x1872BAC10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public MNOIKDLBMCH NMMCMNBCFHB
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x72BA9C0", Offset = "0x72B9DC0", VA = "0x1872BA9C0")]
		get
		{
			return default(MNOIKDLBMCH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x72BAD20", Offset = "0x72BA120", VA = "0x1872BAD20")]
	public PDBKIDCBHPE(IList<Mesh> JMIOOBAANOC, IList<Matrix4x4> AIGFAHJHCPH, IList<bool> MBLBPIKGHBL, byte DDBNJCIKGBE, IList<byte[]> ONOJOCHFGBF, IList<int> AJBCMOLPIAF, IList<bool> OKLIGHJAMIK, IList<int> ELAEEHODNCP, IList<int> MPNCJGPMPPN, IList<int> LDFOIFFKFJH, Allocator LEILKJFLDFN, LDBIEKJHPFI KKPPEJOKKDF, bool ACAFJGKPGAH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x72BA710", Offset = "0x72B9B10", VA = "0x1872BA710")]
	public MMONHKFFOCH AODCLOLHDIH(Allocator LEILKJFLDFN, NNBGPGNKBMB CBJDPLCEFOH)
	{
		return default(MMONHKFFOCH);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x72BA800", Offset = "0x72B9C00", VA = "0x1872BA800", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[GAFKBMEFLIK]
public class GAEFGNAFKLA : NJGDPEGMCOM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public bool HONIAHGAFOK;

	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private static readonly ProfilerMarker KHCBEMHIPOA;

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x72B4E00", Offset = "0x72B4200", VA = "0x1872B4E00")]
	public PDBKIDCBHPE PCKDJDEKJBB()
	{
		return default(PDBKIDCBHPE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x72B50C0", Offset = "0x72B44C0", VA = "0x1872B50C0")]
	public GAEFGNAFKLA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct MNOIKDLBMCH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public Mesh.MeshData PCOEENEIHAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public NativeSlice<BoneWeight> DCJEJNMJFBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public NativeSlice<byte> OPHBJCBBLNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public int OCJOEDICIGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public Matrix4x4 ABJKIHNEOGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public int JIJOKOIODIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public NativeSlice<byte> FFEHGHDGBPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public bool CEPINDKOFMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public int CMNAJANMPNF;
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class ADOHCHALOBL : AHBNJGDEGOO
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class HNONMIMPPOI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public HNNBNAMEAIG avatarBuildParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public ADOHCHALOBL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public AEIHFJALFJE buildMeshPromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		public Action<KeyValuePair<string, EBHOPDBMNPK<Texture2D>>> <>9__19;

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public HNONMIMPPOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x72B51E0", Offset = "0x72B45E0", VA = "0x1872B51E0")]
		internal bool FCJGJPONKNF(LJKKDAKGHIG item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x72B51C0", Offset = "0x72B45C0", VA = "0x1872B51C0")]
		internal void EKJFJKNGIDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x72B52F0", Offset = "0x72B46F0", VA = "0x1872B52F0")]
		internal void LHCPKADLJAB(string err)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x72B51C0", Offset = "0x72B45C0", VA = "0x1872B51C0")]
		internal void FKDBKPOAGKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x72B52F0", Offset = "0x72B46F0", VA = "0x1872B52F0")]
		internal void OADCENNENPD(string err)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x72B5190", Offset = "0x72B4590", VA = "0x1872B5190")]
		internal void DNAJNDJKDBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x72B5310", Offset = "0x72B4710", VA = "0x1872B5310")]
		internal void NBMEFOCDKOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x72B5230", Offset = "0x72B4630", VA = "0x1872B5230")]
		internal void GEKEBGLBEEA(Dictionary<string, EBHOPDBMNPK<Texture2D>> resourceHandleDictionary)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x72B50D0", Offset = "0x72B44D0", VA = "0x1872B50D0")]
		internal void ALKBBAIFBNB(KeyValuePair<string, EBHOPDBMNPK<Texture2D>> kvp)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x94B800", Offset = "0x94AC00", VA = "0x18094B800")]
		internal HJOKANJAKGB KCCAMEFCJLD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class EFMBLAELIOP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public int lowestPossibleLOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public HNONMIMPPOI CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public EFMBLAELIOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x72B4D40", Offset = "0x72B4140", VA = "0x1872B4D40")]
		internal CLDEBNIPJAK JEGAGGLNGBE(int lod)
		{
			return default(CLDEBNIPJAK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class EIHKNFDHLAF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public NEEPBAPEEOL<Dictionary<string, EBHOPDBMNPK<Texture2D>>> ugcTextureDictionaryPromise;

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public EIHKNFDHLAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x949410", Offset = "0x948810", VA = "0x180949410")]
		internal NEEPBAPEEOL<Dictionary<string, EBHOPDBMNPK<Texture2D>>> PBHMBBGAHEK()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class IMNPAHOJOFL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public List<AEIHFJALFJE> innerPromises;

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public IMNPAHOJOFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x72B5340", Offset = "0x72B4740", VA = "0x1872B5340")]
		internal void CLACDCHEKMM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class ANINFLCFGJB : IEnumerator<FBLKJCIOKGP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		private FBLKJCIOKGP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public bool shouldWait;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public ADOHCHALOBL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public List<CEHPNHHBNNM> parts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public List<AEIHFJALFJE> innerPromises;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public int[] LODs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public bool isFirstPerson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public Func<int, CLDEBNIPJAK> getLayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public MIGKACJGENE materialPropertyBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public Material materialInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		private int <lodIndex>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		private FBLKJCIOKGP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x94B6B0", Offset = "0x94AAB0", VA = "0x18094B6B0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x94B6B0", Offset = "0x94AAB0", VA = "0x18094B6B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x94B7A0", Offset = "0x94ABA0", VA = "0x18094B7A0")]
		[DebuggerHidden]
		public ANINFLCFGJB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x72B0B00", Offset = "0x72AFF00", VA = "0x1872B0B00", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x72B0D80", Offset = "0x72B0180", VA = "0x1872B0D80", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class EMCLHFGELGL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public CLHPMPABOAJ cancelable;

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public EMCLHFGELGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0xA67DB0", Offset = "0xA671B0", VA = "0x180A67DB0")]
		internal void CJHFNNHEHCG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0xB65A50", Offset = "0xB64E50", VA = "0x180B65A50")]
		internal void GKDDJNMAEJL(string err)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class MKGCBBBKAEK
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
		public ADOHCHALOBL <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public MKGCBBBKAEK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class CAHDFNILDHN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public bool waitingForComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public JobHandle lodBuildJobHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public MMONHKFFOCH defaultMeshJobContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public PDBKIDCBHPE defaultAvatarMeshJobGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public MKGCBBBKAEK CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public CAHDFNILDHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x72B4B00", Offset = "0x72B3F00", VA = "0x1872B4B00")]
		internal void OFCOLPDEBKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x1054850", Offset = "0x1053C50", VA = "0x181054850")]
		internal void HKNAPPEKAJH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class JNEDFKIFKBM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public bool waitingForComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public JobHandle lodBuildJobHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public NHEMOJHNGLC legacyMeshJobContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public PFCDOEJMIDA legacyAvatarMeshJobGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public MKGCBBBKAEK CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public JNEDFKIFKBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x72B5470", Offset = "0x72B4870", VA = "0x1872B5470")]
		internal void PKNAGMNPLDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x1056180", Offset = "0x1055580", VA = "0x181056180")]
		internal void BIPDCGEIEKE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class OJOMDMACAPG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public string overrideItemIdentifier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public OBJHNMCDGDL overrideBodyPart;

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public OJOMDMACAPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x72BA680", Offset = "0x72B9A80", VA = "0x1872BA680")]
		internal bool PMJJGPMCPGP(KeyValuePair<string, LJKKDAKGHIG> entry)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly FKDOIPNGGAF LPIMHGFKHBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly FKDOIPNGGAF MNDIGFMGIOB;

	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private static float FLKNNLDFOEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private AvatarConfiguration KKLCLENFPKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private Transform LECEGBEGODE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private AvatarSkinAssetItem BBCPEMJPNHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private AssetReference MFCJFMIOAIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private GameObject KBAHLOMKKPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private GameObject KCAEABMDGFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private SkinnedMeshRenderer FMOLKKFBKNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private AvatarSkinnedMeshBoneOrderRemapsData HMPHGIKKCHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private Transform[] OMKDLOFLNAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private Matrix4x4[] CPMMFLLAOKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private Material EILPOGCGFPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private Material PABGJMMHGGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private Material BBPEFDGPLED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private Shader LADOIPHNDNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private Shader HENLIHMFHIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private Animator EJJCIBPIAHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private Renderer[] OGDHLGKLDMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private KBAIGJMAONF.FALICHFPADL ACJCGODKLIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private AvatarBodyPartShapesManager KGCNKDKLAPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private IReadOnlyDictionary<string, Transform> FILEAMKALPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private AvatarFaceShapeData.NFLOKLBCILG GHINLBGNMEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private AvatarBodyShapeData.BKBJCOHDGGC MMELNFGKBEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private EHLDDELHBFB EMNGJFNFECE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private bool JFDONDNABBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xCD")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private bool HCCOIJLNDIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private Color DAGJLDLMCHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private Color JMKCHGNFHPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private Color MCPLMEPMMLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private Color? NLFDIBDJPAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x114")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private Color? PFKGJOBAALK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private Color? NBJGONEDKCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13C")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private Color? OIEKNDJIDFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private Texture2D LDBBMEJOIHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private Texture2D HOHLFDPPEPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	[CanBeNull]
	private LJKKDAKGHIG FDBGEIJGPBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private Texture ALHEGKGOEEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private Color BIIEBCKIDPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public Dictionary<Renderer, MIGKACJGENE> BGMJAEEPDEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private Dictionary<Renderer, MIGKACJGENE> BADIABDKJJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private Dictionary<string, List<IMJMIIIPNLF>> ONEDBDFCKCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private Dictionary<string, List<IMJMIIIPNLF>> IHFAFHCNCAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private readonly List<BELJNJGLPJA> GFIECIAKOMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private readonly List<BELJNJGLPJA> DCHBJMMMJDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private readonly List<BELJNJGLPJA> OHNMOGHPOHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private readonly List<BELJNJGLPJA> CNIIEIOFJDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private Dictionary<IMJMIIIPNLF, Material> HGBHOMEPAAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private Dictionary<IMJMIIIPNLF, Material> IIPOBONAJDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private SkinnedMeshRenderer[] GFGHAHLCDOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private SkinnedMeshRenderer[] NNACCEKFCBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private SkinnedMeshRenderer[] KFJGJHNLIGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private SkinnedMeshRenderer[] CBEECFOHHDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private readonly Dictionary<string, EBHOPDBMNPK<Texture2D>> GJODDODIDOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private readonly Dictionary<string, EBHOPDBMNPK<Texture2D>> KEIPCMPJLDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private IIFAJIGINPD NCPNEHANKDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x204")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private IIFAJIGINPD NJEBJIJCCBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private AdditionalHatData NLAPCHMOKAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private AdditionalHatData PLPOCHJOOLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private HairData ENLFHMLFOJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private HairData EHMJDIAKGFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private KOIFPCMFICK BBAPNNFAODH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private bool? FHIAJODCCFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x234")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private PositionAndRotation HMOBLCNFKBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private Transform KMGDPDKNDEL;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private Material KLPAIIMPKMH;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private Material IFAHJHJIBEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private Dictionary<string, LJKKDAKGHIG> IEECIKDJPME;

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private static readonly int HNJJHJPBPOB;

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private static readonly int EENGMNKCIPB;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private static readonly int DBFMBBCPHAL;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private static readonly int AJEDMGPCFNL;

	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private static readonly int JOECFFLEBJE;

	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private static readonly int GBCMFLNPEMM;

	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private static readonly int HAFGEAALIDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private bool CIBJIMPMFKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private List<Action> NNCDPIDIOMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private IKKEFGFKHCN PKLGHJOCJJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private SkinnedMeshRenderer[] HAIEBPOHPME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private int DOIJDHJLOIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x294")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private bool LMOLOABGPHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private int HPJIMKEBIGA;

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public FKDOIPNGGAF DMIIGPCLCJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x949410", Offset = "0x948810", VA = "0x180949410", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public FKDOIPNGGAF DMCLJIPCDNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x94B6B0", Offset = "0x94AAB0", VA = "0x18094B6B0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public AvatarConfiguration LJNPOLOCLOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x94B800", Offset = "0x94AC00", VA = "0x18094B800", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public bool BIJDDCNCAGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x72ACCB0", Offset = "0x72AC0B0", VA = "0x1872ACCB0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x72A9EE0", Offset = "0x72A92E0", VA = "0x1872A9EE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	private Material ICLFDEAAPPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x72A5760", Offset = "0x72A4B60", VA = "0x1872A5760")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	private Material PNFKECHGNEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x72ACBC0", Offset = "0x72ABFC0", VA = "0x1872ACBC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	private bool KNAMMMJKBJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x965500", Offset = "0x964900", VA = "0x180965500")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public PKOOKMMPLDP CBKHCHACMEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xA6BC50", Offset = "0xA6B050", VA = "0x180A6BC50", Slot = "23")]
		get
		{
			return default(PKOOKMMPLDP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public Material BHJJGIONPII
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x955550", Offset = "0x954950", VA = "0x180955550", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public SkinnedMeshRenderer[] CGDMKJBOCEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x9D6730", Offset = "0x9D5B30", VA = "0x1809D6730", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public Renderer[] MACMNPGKNND
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0xB83C50", Offset = "0xB83050", VA = "0x180B83C50", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public bool MMHJEADAFHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x72ADE90", Offset = "0x72AD290", VA = "0x1872ADE90", Slot = "22")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public KBAIGJMAONF.FALICHFPADL OBJPNGNOONK
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x94F5D0", Offset = "0x94E9D0", VA = "0x18094F5D0", Slot = "20")]
		get
		{
			return default(KBAIGJMAONF.FALICHFPADL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public int DMLAADHPPMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x72ABFA0", Offset = "0x72AB3A0", VA = "0x1872ABFA0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x72A4FF0", Offset = "0x72A43F0", VA = "0x1872A4FF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private bool MAFFHLMNBPK
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x72AE4D0", Offset = "0x72AD8D0", VA = "0x1872AE4D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	private static bool OGFKAKDJLFF
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x993CC0", Offset = "0x9930C0", VA = "0x180993CC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x72AFF70", Offset = "0x72AF370", VA = "0x1872AFF70", Slot = "15")]
	public AEIHFJALFJE POGJIFLHOJD(HNNBNAMEAIG MLFKDAKANJM, bool IEOMHDBLFBH, int[] MOFBLKNOEOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x72A50A0", Offset = "0x72A44A0", VA = "0x1872A50A0", Slot = "14")]
	public AEIHFJALFJE BDBBCCPEGHA(HNNBNAMEAIG MLFKDAKANJM, bool IEOMHDBLFBH, int[] MOFBLKNOEOE, Func<Dictionary<string, LJKKDAKGHIG>, (AEIHFJALFJE, NEEPBAPEEOL<Dictionary<string, EBHOPDBMNPK<Texture2D>>>)> BBCBCLNEBCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x72A7170", Offset = "0x72A6570", VA = "0x1872A7170")]
	public AEIHFJALFJE DBJIBOMOEPG(HNNBNAMEAIG MLFKDAKANJM, bool IEOMHDBLFBH, int[] MOFBLKNOEOE, bool JEPIIFHOIHA, IIFAJIGINPD AAADLNMKLFC, [Optional] Func<Dictionary<string, LJKKDAKGHIG>, (AEIHFJALFJE, NEEPBAPEEOL<Dictionary<string, EBHOPDBMNPK<Texture2D>>>)> BBCBCLNEBCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x72AA5D0", Offset = "0x72A99D0", VA = "0x1872AA5D0")]
	private bool GAPMAJAPGDG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x72A5F20", Offset = "0x72A5320", VA = "0x1872A5F20")]
	private AEIHFJALFJE CGHEDJLJCHJ(bool IEOMHDBLFBH, List<CEHPNHHBNNM> OBBNKCEMAMM, int[] MOFBLKNOEOE, Func<int, CLDEBNIPJAK> ODCKOKNKPGI, bool JEPIIFHOIHA = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x72AF3C0", Offset = "0x72AE7C0", VA = "0x1872AF3C0")]
	[IteratorStateMachine(typeof(ANINFLCFGJB))]
	private IEnumerator<FBLKJCIOKGP> PGKDBLFLLCN(bool IEOMHDBLFBH, List<CEHPNHHBNNM> OBBNKCEMAMM, int[] MOFBLKNOEOE, Func<int, CLDEBNIPJAK> ODCKOKNKPGI, MIGKACJGENE BBIJHOEALAG, Material PFHJOFPFGCD, List<AEIHFJALFJE> JCONMNAEBLJ, bool OENELICLIHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x72AED50", Offset = "0x72AE150", VA = "0x1872AED50")]
	private void PFGFPMOEOGJ(List<CEHPNHHBNNM> OBBNKCEMAMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x72AC970", Offset = "0x72ABD70", VA = "0x1872AC970")]
	private AEIHFJALFJE JAMEIILFMKE(List<CEHPNHHBNNM> OBBNKCEMAMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x72AAD80", Offset = "0x72AA180", VA = "0x1872AAD80")]
	private HPLGDNGCOKN GMLEPOHMBKP(List<CEHPNHHBNNM> OBBNKCEMAMM, int GNAJNFCKONF, bool IEOMHDBLFBH, CLDEBNIPJAK GKKHJGBAALN, bool JGIAELKDBPI, MIGKACJGENE BBIJHOEALAG, Material PFHJOFPFGCD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x72AE390", Offset = "0x72AD790", VA = "0x1872AE390", Slot = "25")]
	public void NFCHKCGEBJJ(AvatarFaceShape NGODEJMKEBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x72AD6B0", Offset = "0x72ACAB0", VA = "0x1872AD6B0", Slot = "26")]
	public void LEKEMDKGABJ(AvatarBodyShape LJFANJBKMBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0xD71B20", Offset = "0xD70F20", VA = "0x180D71B20", Slot = "27")]
	public void NHPFIPHCDNK(EHLDDELHBFB DIKOIBEAEJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x72A50D0", Offset = "0x72A44D0", VA = "0x1872A50D0", Slot = "29")]
	public void BDOLLGIJEOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x72AF380", Offset = "0x72AE780", VA = "0x1872AF380", Slot = "32")]
	public void PFOKONAMMGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x72A4E70", Offset = "0x72A4270", VA = "0x1872A4E70", Slot = "28")]
	public void AKNGCJGIMNF(bool KHFOHCPJDLH, bool EPFJHEKEEKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x72AEC10", Offset = "0x72AE010", VA = "0x1872AEC10")]
	private void PFAGFAHHDAD(SkinnedMeshRenderer GCOMIOEIBEI, int GNAJNFCKONF, Mesh LCGHOEMEOEK, List<Material> INAPLHEDMCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x72AA390", Offset = "0x72A9790", VA = "0x1872AA390")]
	private static Material FNBMMPFEOGN(Dictionary<IMJMIIIPNLF, Material> FMPOBMMKKCL, Material EAOFNOHCOIK, BJGDFBKEINK PIEGLLCHINN, DDOKGHHJODE IPEPMKFNFHH, OBJHNMCDGDL DBDEIKJCEBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x72A7060", Offset = "0x72A6460", VA = "0x1872A7060")]
	private static BJGDFBKEINK DBDPHCDEDDD(CEHPNHHBNNM FAHICGIKPOG, int MFCLFEPKGAD)
	{
		return default(BJGDFBKEINK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x72AC4D0", Offset = "0x72AB8D0", VA = "0x1872AC4D0")]
	private void IILLJHAHBOI(int CLLOKPKIGEH, Material HJCEHLILOIG, CEHPNHHBNNM FAHICGIKPOG, [Out] Texture2D KNJHLLDKNBN, [Out] Vector4 LEBIOKJNNBM, [Out] Texture2D HCBHLHALDCK, [Out] Texture2D AOLJNNMDFDK, [Out] Texture2D OIPGNFEPIAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x72AF4E0", Offset = "0x72AE8E0", VA = "0x1872AF4E0")]
	private void PIKIKHNHLMM(int CLLOKPKIGEH, Material HJCEHLILOIG, CEHPNHHBNNM FAHICGIKPOG, [Out] Color KDBCFKGNGJP, [Out] Color OJKPDPFPHGP, [Out] Color EKKHNINCDDG, [Out] Color AJJDBGBBOLB, [Out] Color CEJFGPJEHDN, [Out] Color DDPMLLMDLNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x72A5A80", Offset = "0x72A4E80", VA = "0x1872A5A80")]
	private bool CALGCLAMBEH(Material HJCEHLILOIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x72A5CE0", Offset = "0x72A50E0", VA = "0x1872A5CE0")]
	private static Material CDLCCIALEGJ(int CLLOKPKIGEH, IMMLCIEBDAG FAHICGIKPOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x72A9CC0", Offset = "0x72A90C0", VA = "0x1872A9CC0")]
	private static DDOKGHHJODE EFGPFDDOCGO(CEHPNHHBNNM FAHICGIKPOG, int MFCLFEPKGAD)
	{
		return default(DDOKGHHJODE);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x72AD190", Offset = "0x72AC590", VA = "0x1872AD190")]
	private static void KGKDIECJCLK(Dictionary<string, List<IMJMIIIPNLF>> JAGFBALGAPL, CEHPNHHBNNM GCHFPPMPGNO, Material EAOFNOHCOIK, BJGDFBKEINK PIKKFHOHKHL, DDOKGHHJODE CJLDBFGOACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x72A6500", Offset = "0x72A5900", VA = "0x1872A6500")]
	private static SkinnedMeshRenderer CHBPAFEELOA(Transform HBHDBMDKCGC, Transform CBIJFIEIFAK, SkinnedMeshRenderer[] LGCGHBBEHDN, int GNAJNFCKONF, CLDEBNIPJAK GKKHJGBAALN, bool IEOMHDBLFBH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x72B0570", Offset = "0x72AF970", VA = "0x1872B0570")]
	public ADOHCHALOBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x72ABFB0", Offset = "0x72AB3B0", VA = "0x1872ABFB0")]
	public void HPHCPPKCEKM([In] CFPFBPBKEJA KMDGKLFIKLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x72A9E60", Offset = "0x72A9260", VA = "0x1872A9E60")]
	public void PMBMMACDLKD([In] ADGPJAEELJF AMOHALPGLJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x72A4FF0", Offset = "0x72A43F0", VA = "0x1872A4FF0", Slot = "5")]
	public void AMMEFDJGJNP(int GNAJNFCKONF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x72AC2B0", Offset = "0x72AB6B0", VA = "0x1872AC2B0", Slot = "10")]
	public void HPHIDJEIAKN(LHELENKBGMO CJLDBFGOACG, Texture2D IHOMIJNFMIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x965500", Offset = "0x964900", VA = "0x180965500")]
	public static bool MANMJDMEOGH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x72A6730", Offset = "0x72A5B30", VA = "0x1872A6730", Slot = "11")]
	public bool CIJGIEJAKCE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x72ACCF0", Offset = "0x72AC0F0", VA = "0x1872ACCF0", Slot = "9")]
	public void KEBKKELILPK(GOEIDDHPLEF PIKKFHOHKHL, Color? NHCBHMJDLHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x72ABF20", Offset = "0x72AB320", VA = "0x1872ABF20")]
	private void HBKJDGHELGJ(Action GHJKPFPLGEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x72A4CA0", Offset = "0x72A40A0", VA = "0x1872A4CA0", Slot = "6")]
	public void ACMOENGJDMC(LJKKDAKGHIG JKFGJFHCKPG, Texture HBJIGNEMNAE, Color MIFGFNOKIJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x72A9EE0", Offset = "0x72A92E0", VA = "0x1872A9EE0", Slot = "7")]
	public void FHFEHAGHIGE(bool OENELICLIHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0xA13F50", Offset = "0xA13350", VA = "0x180A13F50", Slot = "8")]
	public void KADGANNDBCN(IKKEFGFKHCN FJJOKDBOKAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x72AE9C0", Offset = "0x72ADDC0", VA = "0x1872AE9C0", Slot = "16")]
	public void ONKGPPOKPJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x72AE450", Offset = "0x72AD850", VA = "0x1872AE450", Slot = "30")]
	public void NHGCNFNGFLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x72A8E00", Offset = "0x72A8200", VA = "0x1872A8E00", Slot = "31")]
	public void DENPBNBCMIF([Optional] KOIFPCMFICK KOIJGLMEEHK, [Optional] bool? JFFMIJPCLEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x72ADB60", Offset = "0x72ACF60", VA = "0x1872ADB60")]
	private bool MDBPECIGIGF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x72AEBF0", Offset = "0x72ADFF0", VA = "0x1872AEBF0", Slot = "21")]
	public bool PFABJPBEEBP(KBAIGJMAONF.FALICHFPADL NOAAJJKCHIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x72AA1C0", Offset = "0x72A95C0", VA = "0x1872AA1C0")]
	private void FMOGAMFFKEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x72AC8E0", Offset = "0x72ABCE0", VA = "0x1872AC8E0")]
	private void IKNANBHBDAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x72AAC20", Offset = "0x72AA020", VA = "0x1872AAC20")]
	private static void GLEFBGGLDOE(Dictionary<IMJMIIIPNLF, Material> FMPOBMMKKCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x72ADD30", Offset = "0x72AD130", VA = "0x1872ADD30")]
	private static void MJJBIKBIJAJ(Dictionary<Renderer, MIGKACJGENE> GEMDCFELCIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x72A9F20", Offset = "0x72A9320", VA = "0x1872A9F20")]
	private void FKCLIPAIKLH(SkinnedMeshRenderer[] LGCGHBBEHDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x72AD0F0", Offset = "0x72AC4F0", VA = "0x1872AD0F0")]
	private void KFIADIGLLCL(SkinnedMeshRenderer BNBIMMBDEGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x72A54B0", Offset = "0x72A48B0", VA = "0x1872A54B0")]
	private void BHFKGFPBMHJ(List<BELJNJGLPJA> MNMNOHFPEEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x72A5900", Offset = "0x72A4D00", VA = "0x1872A5900")]
	private void CAIEKJGOFML(Dictionary<string, EBHOPDBMNPK<Texture2D>> JAGFBALGAPL, bool EFJOBKAGFFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x72A68B0", Offset = "0x72A5CB0", VA = "0x1872A68B0")]
	private void CLLAHGOCKNB(Dictionary<string, List<IMJMIIIPNLF>> JAGFBALGAPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x72AE550", Offset = "0x72AD950", VA = "0x1872AE550")]
	private void ODCMPKEKNCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x72AD840", Offset = "0x72ACC40", VA = "0x1872AD840")]
	private void LPBEFJCMGJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x72A6A90", Offset = "0x72A5E90", VA = "0x1872A6A90")]
	private void DBAIAPIILEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x72AD770", Offset = "0x72ACB70", VA = "0x1872AD770")]
	private void LFKMMFOACNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x72A51D0", Offset = "0x72A45D0", VA = "0x1872A51D0")]
	private void BFIMLPECHEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x72A6900", Offset = "0x72A5D00", VA = "0x1872A6900")]
	private void CMDJHDLPEJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x72A9BD0", Offset = "0x72A8FD0", VA = "0x1872A9BD0")]
	private void ECNGNBJDNCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x72AA4F0", Offset = "0x72A98F0", VA = "0x1872AA4F0")]
	private void GAIFEHJDNPM(bool HNDDCLFFMIK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x72A5690", Offset = "0x72A4A90", VA = "0x1872A5690")]
	private void BJHIEHKBHFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x72A4F10", Offset = "0x72A4310", VA = "0x1872A4F10")]
	private void ALGJOIFHCLL(bool HNDDCLFFMIK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x72AE6A0", Offset = "0x72ADAA0", VA = "0x1872AE6A0")]
	private void OEIPAJKFPDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x72AA690", Offset = "0x72A9A90", VA = "0x1872AA690")]
	private void GFFKCEINPGG(Material PFHJOFPFGCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x72AD9D0", Offset = "0x72ACDD0", VA = "0x1872AD9D0")]
	private void LPOKHIGGAFD(Material PFHJOFPFGCD, Color MHFFAABGINO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x72A5260", Offset = "0x72A4660", VA = "0x1872A5260")]
	private void BHDHMDFKPKI(Material PFHJOFPFGCD, Color MHFFAABGINO, Color OCMCDEJGILI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x72AF9B0", Offset = "0x72AEDB0", VA = "0x1872AF9B0")]
	private void PJAIJHDGNNK(Material PFHJOFPFGCD, Color KDBCFKGNGJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x72A5D30", Offset = "0x72A5130", VA = "0x1872A5D30")]
	private void CECPCFJCCGD(Material PFHJOFPFGCD, Texture2D IHOMIJNFMIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x72AD540", Offset = "0x72AC940", VA = "0x1872AD540")]
	private void LDBPDDIDAKN(Material PFHJOFPFGCD, Texture NCEMIDDEIKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x72A4D10", Offset = "0x72A4110", VA = "0x1872A4D10")]
	private void AGKEIJHGJBH(Action<MIGKACJGENE> EGIANMPBNKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x72AA040", Offset = "0x72A9440", VA = "0x1872AA040")]
	private void FKJKJIHKKKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x72AFB50", Offset = "0x72AEF50", VA = "0x1872AFB50")]
	private void PMMHFCAJJJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x72B0030", Offset = "0x72AF430", VA = "0x1872B0030")]
	private void PPBJFNHBJDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x72AE000", Offset = "0x72AD400", VA = "0x1872AE000")]
	public void NBNLELFONJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x72A9E60", Offset = "0x72A9260", VA = "0x1872A9E60", Slot = "4")]
	private void EONHMMPPIIL([In] ADGPJAEELJF AMOHALPGLJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x72A6A50", Offset = "0x72A5E50", VA = "0x1872A6A50")]
	[CompilerGenerated]
	private HJOKANJAKGB CPADLDMGOFM(CEHPNHHBNNM FCEAHINHNGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x72A9DA0", Offset = "0x72A91A0", VA = "0x1872A9DA0")]
	[CompilerGenerated]
	private void EIPOIDBOFFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x72AD510", Offset = "0x72AC910", VA = "0x1872AD510")]
	[CompilerGenerated]
	private void LAOCJPIBLOJ(MIGKACJGENE AKHBEIJLAGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x72AAB90", Offset = "0x72A9F90", VA = "0x1872AAB90")]
	[CompilerGenerated]
	private void GIGHGNKAAFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x72AE4B0", Offset = "0x72AD8B0", VA = "0x1872AE4B0")]
	[CompilerGenerated]
	private void NIGCAHBHNCC(MIGKACJGENE AKHBEIJLAGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x72A5010", Offset = "0x72A4410", VA = "0x1872A5010")]
	[CompilerGenerated]
	private void AOEADKKCEPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x72A9CA0", Offset = "0x72A90A0", VA = "0x1872A9CA0")]
	[CompilerGenerated]
	private void EDBLKDENHHC(MIGKACJGENE AKHBEIJLAGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x72AFFA0", Offset = "0x72AF3A0", VA = "0x1872AFFA0")]
	[CompilerGenerated]
	private void POHGANLIFNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x72ACCC0", Offset = "0x72AC0C0", VA = "0x1872ACCC0")]
	[CompilerGenerated]
	private void KAPOLEPPEFP(MIGKACJGENE AKHBEIJLAGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x72ADCA0", Offset = "0x72AD0A0", VA = "0x1872ADCA0")]
	[CompilerGenerated]
	private void MEHPPFLKEEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x72AD4E0", Offset = "0x72AC8E0", VA = "0x1872AD4E0")]
	[CompilerGenerated]
	private void KOPIOOCMBMJ(MIGKACJGENE AKHBEIJLAGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x72AD450", Offset = "0x72AC850", VA = "0x1872AD450")]
	[CompilerGenerated]
	private void KONHMHCMBEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x72AEBC0", Offset = "0x72ADFC0", VA = "0x1872AEBC0")]
	[CompilerGenerated]
	private void PCPHBMOKBLL(MIGKACJGENE AKHBEIJLAGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x72A4E80", Offset = "0x72A4280", VA = "0x1872A4E80")]
	[CompilerGenerated]
	private void ALFHKDEIBMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x72A9E30", Offset = "0x72A9230", VA = "0x1872A9E30")]
	[CompilerGenerated]
	private void EJGKGAGLHBF(MIGKACJGENE AKHBEIJLAGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x72AC8F0", Offset = "0x72ABCF0", VA = "0x1872AC8F0")]
	[CompilerGenerated]
	private void IPMBLPPCDPI(KeyValuePair<string, EBHOPDBMNPK<Texture2D>> ONFJMGPMMKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x72AF9A0", Offset = "0x72AEDA0", VA = "0x1872AF9A0")]
	[CompilerGenerated]
	private void PILFGEEPCPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x72A9EF0", Offset = "0x72A92F0", VA = "0x1872A9EF0")]
	[CompilerGenerated]
	private void FIIJDONDBMF(MIGKACJGENE AKHBEIJLAGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x72ADB50", Offset = "0x72ACF50", VA = "0x1872ADB50")]
	[CompilerGenerated]
	private void MCJOELCMLDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x72A9BA0", Offset = "0x72A8FA0", VA = "0x1872A9BA0")]
	[CompilerGenerated]
	private void ECMFNHNKCDG(MIGKACJGENE AKHBEIJLAGO)
	{
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class AvatarElbowBendHelperController : MonoBehaviour, GGHNALLMHEG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		[ALEFAIIJNEI(KCNGGJNCENB.Self, false, false, false)]
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
		[Header("Scale")]
		[SerializeField]
		[FormerlySerializedAs("MinScaleValues")]
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
		[SerializeField]
		[FormerlySerializedAs("MaxLocalPositionOffset")]
		private Vector3 PositionalOffsetAtMaxAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		private Vector3? GANOPDCMOMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		private bool NOMGHFOBMPE;

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x72B31A0", Offset = "0x72B25A0", VA = "0x1872B31A0", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x72B37D0", Offset = "0x72B2BD0", VA = "0x1872B37D0", Slot = "4")]
		public void UpdateController(float HIBCBLOKLEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0xADD930", Offset = "0xADCD30", VA = "0x180ADD930", Slot = "6")]
		public void SetEnabled(bool KBGCCIOIGBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x72B3280", Offset = "0x72B2680", VA = "0x1872B3280")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x72B3C90", Offset = "0x72B3090", VA = "0x1872B3C90")]
		public AvatarElbowBendHelperController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class AvatarElbowBendTargetController : MonoBehaviour, GGHNALLMHEG
	{
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private const float OKCJLFHHIEE = 45f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		[ALEFAIIJNEI(KCNGGJNCENB.Self, false, false, false)]
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
		private Vector3 AHCEBGJJBDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private Vector3 EBNHCOCJNCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		private bool NOMGHFOBMPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		private float LFEPJIIJABL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		private float CIFJOMCFDKC;

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x72B4010", Offset = "0x72B3410", VA = "0x1872B4010", Slot = "4")]
		public void UpdateController(float HIBCBLOKLEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0xF7A2B0", Offset = "0xF796B0", VA = "0x180F7A2B0", Slot = "6")]
		public void SetEnabled(bool KBGCCIOIGBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x72B3D30", Offset = "0x72B3130", VA = "0x1872B3D30")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x72B4AD0", Offset = "0x72B3ED0", VA = "0x1872B4AD0")]
		public AvatarElbowBendTargetController()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class APDDFGMKIOL : JGOJAJEODNM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	private static readonly int IBFGCGCFPBP;

	[Cpp2IlInjected.Token(Token = "0x4000135")]
	private static readonly int GPAFEDGFKPO;

	[Cpp2IlInjected.Token(Token = "0x4000136")]
	private static readonly int AMNJFDJKANF;

	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private static readonly int FIOJCHLFMNC;

	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private static readonly int FIOFPOGEFAO;

	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private static readonly int AGFCBCFADAI;

	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private static readonly int DHMMGKGJKKD;

	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private static readonly int JJJGJKLIDJA;

	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private static readonly int MNNEDHLIKFG;

	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private static readonly int BNOLNCMPKDM;

	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private static readonly int OFHLLPFGONH;

	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private static readonly int AIJNMDMEGKG;

	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private static readonly int KBAKEIEOCBJ;

	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private static readonly int PFFANECHCDF;

	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private static readonly int FGIDBHPEKBP;

	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private static readonly int LHBNHJJFIBG;

	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private static readonly int IDHKHCAGJBL;

	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private static readonly int MEPJFDNIMPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private Transform GDMCHKLBOGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private Transform IPKKODOFLLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private Transform BGLMCNONJAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private Transform LBFOFALKNGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private Transform NEDHPLMMHCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private Transform JMFEKECIDKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private Transform NGKMLAFOBII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private HCEOCPHCBKP GCHMGNNGODI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private Material MDKPPEMMGGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private SkinnedMeshRenderer[] IGOAMNMIHOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private readonly List<Material> IMMNOELIFLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private ANAHCJOGKFH AIEEDLJCECF;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public FKDOIPNGGAF HNELGOJBNPM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x949410", Offset = "0x948810", VA = "0x180949410", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	private ANAHCJOGKFH LLDPFCIIMIA
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x72B1E20", Offset = "0x72B1220", VA = "0x1872B1E20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public bool KFMLNKJFEGL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x72B17C0", Offset = "0x72B0BC0", VA = "0x1872B17C0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x72B1360", Offset = "0x72B0760", VA = "0x1872B1360")]
	public void HPHCPPKCEKM([In] HCEOCPHCBKP JGMKPBHIMFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x72B0DD0", Offset = "0x72B01D0", VA = "0x1872B0DD0")]
	public void HCAEKEIHCKK([In] EBEGNBNODAH FOGHNNFMDBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x72B1940", Offset = "0x72B0D40", VA = "0x1872B1940", Slot = "6")]
	public void JLBPJMLBHDM(LJHCODOFFPO OANFHMCJHEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x72B1300", Offset = "0x72B0700", VA = "0x1872B1300")]
	private Vector2 FILCJHCAKBD(Vector2 FEMIJKGPBOF)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x72B1EB0", Offset = "0x72B12B0", VA = "0x1872B1EB0")]
	public void OIKAMCFDLFG([In] KJFGCCOFHCI FOGHNNFMDBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x72B0FB0", Offset = "0x72B03B0", VA = "0x1872B0FB0")]
	private void FIAHCJICMKH(PJLHDFEOPIO GNENFLCKOEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x72B1430", Offset = "0x72B0830", VA = "0x1872B1430")]
	private void IFNFMHLBFID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x72B0F40", Offset = "0x72B0340", VA = "0x1872B0F40")]
	private void HIAEKHLABAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x72B0F40", Offset = "0x72B0340", VA = "0x1872B0F40", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x72B30A0", Offset = "0x72B24A0", VA = "0x1872B30A0")]
	public APDDFGMKIOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x72B0DD0", Offset = "0x72B01D0", VA = "0x1872B0DD0", Slot = "5")]
	private void BEPIMAKFNFN([In] EBEGNBNODAH FOGHNNFMDBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x72B1EA0", Offset = "0x72B12A0", VA = "0x1872B1EA0", Slot = "7")]
	private void LHBJKAFFFBB([In] KJFGCCOFHCI FOGHNNFMDBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x72B0E70", Offset = "0x72B0270", VA = "0x1872B0E70")]
	[CompilerGenerated]
	internal static (float, float) DACBKLPBOHD(float JNINICKAAEA)
	{
		return default((float, float));
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x72B0F00", Offset = "0x72B0300", VA = "0x1872B0F00")]
	[CompilerGenerated]
	internal static Vector4 DBGLCGOPDGG(Vector2 NDADPNJPMFO, Vector2 JJCKONKIIAI)
	{
		return default(Vector4);
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class AvatarForearmRollController : MonoBehaviour, GGHNALLMHEG
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
		private float LFEPJIIJABL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private bool NOMGHFOBMPE;

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x72BCAC0", Offset = "0x72BBEC0", VA = "0x1872BCAC0", Slot = "4")]
		public void UpdateController(float HIBCBLOKLEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x1460FD0", Offset = "0x14603D0", VA = "0x181460FD0", Slot = "6")]
		public void SetEnabled(bool KBGCCIOIGBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x72BD550", Offset = "0x72BC950", VA = "0x1872BD550")]
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
			[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x72BD580", Offset = "0x72BC980", VA = "0x1872BD580")]
		public void CIDIOEOELJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x72BD6A0", Offset = "0x72BCAA0", VA = "0x1872BD6A0")]
		public int JDPBEDLFJKE(int CCOKICHEIDB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public AvatarHandDisplaySettings()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class MNJGAOGMOGO : MMBJEOAHHDI
{
	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x72C8630", Offset = "0x72C7A30", VA = "0x1872C8630", Slot = "22")]
	public override float EBDMMHCFIAE()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x72C8680", Offset = "0x72C7A80", VA = "0x1872C8680")]
	public MNJGAOGMOGO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class MMBJEOAHHDI : ODFMHACHCFM
{
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	private static int LOGPJIFCGOO;

	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private static int OMOOFGINEAH;

	[Cpp2IlInjected.Token(Token = "0x4000166")]
	private static int MCICBJKDIBC;

	[Cpp2IlInjected.Token(Token = "0x4000167")]
	private static int LANGJNOKKOJ;

	[Cpp2IlInjected.Token(Token = "0x4000168")]
	private static int OLLDOJHKJJE;

	[Cpp2IlInjected.Token(Token = "0x4000169")]
	private static int MHOPBAGDJDK;

	[Cpp2IlInjected.Token(Token = "0x400016A")]
	private static int PJDJBGIJOBM;

	[Cpp2IlInjected.Token(Token = "0x400016B")]
	private static int[] HJAAIAKFBBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	private IGLCKFKINMF GCHMGNNGODI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private EJIHPHLOCCI AAKOPGCJKCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private int GJHCLAJLJBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private float CAJDOHBGPHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	protected Animator EJJCIBPIAHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	protected bool LOFMAMCHNDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	protected AvatarConfiguration EIDMBNPDBFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	protected int MNKANOBGEMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private int LJECJCNMOHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private int OPDBNIEBOCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private bool LJEMCLEEPBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	private BDFIOIHGFPK EPIFEAPMJOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	private int BDPEKAOKCJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	private float MIDEJGJADPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	private AvatarHandDisplaySettings PFPGBAJIFEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	private PKOOKMMPLDP IEKFNPGCMLH;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public Transform KGNNJLOOJEN
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x949410", Offset = "0x948810", VA = "0x180949410")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x949400", Offset = "0x948800", VA = "0x180949400")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public Vector3 PPNHFIJIFMH
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x1446EA0", Offset = "0x14462A0", VA = "0x181446EA0")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x1446E90", Offset = "0x1446290", VA = "0x181446E90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public Quaternion AJLIFHAIEDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0xBC3BE0", Offset = "0xBC2FE0", VA = "0x180BC3BE0")]
		[CompilerGenerated]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x1510570", Offset = "0x150F970", VA = "0x181510570")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public bool POEAFFIIBMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x72C8310", Offset = "0x72C7710", VA = "0x1872C8310")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x72C7CA0", Offset = "0x72C70A0", VA = "0x1872C7CA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public Vector3 MMLBMEAMOJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x72C7810", Offset = "0x72C6C10", VA = "0x1872C7810", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x72C7DE0", Offset = "0x72C71E0", VA = "0x1872C7DE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public Quaternion MKEJBNNGPFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x72C7CD0", Offset = "0x72C70D0", VA = "0x1872C7CD0", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x72C7F90", Offset = "0x72C7390", VA = "0x1872C7F90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public BKMINCPGJKF AIIFODLIICG
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0xA3AE80", Offset = "0xA3A280", VA = "0x180A3AE80", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return default(BKMINCPGJKF);
		}
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0xA3A7A0", Offset = "0xA39BA0", VA = "0x180A3A7A0", Slot = "4")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public BKMINCPGJKF ODIPAAPDCBF
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x21E4160", Offset = "0x21E3560", VA = "0x1821E4160", Slot = "20")]
		[CompilerGenerated]
		get
		{
			return default(BKMINCPGJKF);
		}
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x21E30D0", Offset = "0x21E24D0", VA = "0x1821E30D0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public float FGHNCMHKPHK
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x1291F10", Offset = "0x1291310", VA = "0x181291F10", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0xD72BB0", Offset = "0xD71FB0", VA = "0x180D72BB0", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public bool CBOOKLCDGIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x72C7D40", Offset = "0x72C7140", VA = "0x1872C7D40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public bool JPPNIHOEPLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x72C7AE0", Offset = "0x72C6EE0", VA = "0x1872C7AE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool JJEGJBBEDPD
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x72C7C90", Offset = "0x72C7090", VA = "0x1872C7C90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public bool KIHHPHKKEAF
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x72C78F0", Offset = "0x72C6CF0", VA = "0x1872C78F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x72C7AF0", Offset = "0x72C6EF0", VA = "0x1872C7AF0", Slot = "21")]
	public void HPHCPPKCEKM(IGLCKFKINMF JGMKPBHIMFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x72C77C0", Offset = "0x72C6BC0", VA = "0x1872C77C0")]
	public void ADCJCMBAKIL(EJIHPHLOCCI HEFCMACDPLN, AvatarHandDisplaySettings KPGGOJINIFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x72C7850", Offset = "0x72C6C50", VA = "0x1872C7850", Slot = "12")]
	public void EDAHKMEMLOP(bool BDDPPMGPFHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x72C7FA0", Offset = "0x72C73A0", VA = "0x1872C7FA0", Slot = "11")]
	public void OMAKKDABCOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x1291F10", Offset = "0x1291310", VA = "0x181291F10", Slot = "22")]
	public virtual float EBDMMHCFIAE()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x72C7E00", Offset = "0x72C7200", VA = "0x1872C7E00")]
	private int NDPCOEKEMOD(BKMINCPGJKF FBELANIEJHJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x72C7900", Offset = "0x72C6D00", VA = "0x1872C7900")]
	private void FDJFOKPCBEP(int DLKPDCFEICC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x72C7AC0", Offset = "0x72C6EC0", VA = "0x1872C7AC0", Slot = "13")]
	public bool GHMCGLBCKEN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x72C78E0", Offset = "0x72C6CE0", VA = "0x1872C78E0", Slot = "14")]
	public bool EDGPGBLGCEG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x72C7D50", Offset = "0x72C7150", VA = "0x1872C7D50")]
	private BKMINCPGJKF LGJAGLKANJM()
	{
		return default(BKMINCPGJKF);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x1B3B960", Offset = "0x1B3AD60", VA = "0x181B3B960", Slot = "15")]
	public void PNMEIICHOJD(bool BDDPPMGPFHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x72C7DA0", Offset = "0x72C71A0", VA = "0x1872C7DA0", Slot = "10")]
	public void LPAJNDKNONK(int DLKPDCFEICC, float NONELKGPFBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x72C7830", Offset = "0x72C6C30", VA = "0x1872C7830", Slot = "8")]
	public void CEBEGADHIPH(BDFIOIHGFPK CEGAGHAOIDD, bool IMLBMCFLIEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x72C7CE0", Offset = "0x72C70E0", VA = "0x1872C7CE0", Slot = "9")]
	public void JMNCFNELJHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x72C7CF0", Offset = "0x72C70F0", VA = "0x1872C7CF0", Slot = "16")]
	public void KCNGJAFNLMF(Transform LDIAONMHHPK, Vector3 ELJHIGPGIBG, Quaternion ODOBDLNNBLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x72C8610", Offset = "0x72C7A10", VA = "0x1872C8610")]
	public MMBJEOAHHDI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class IMMLCIEBDAG : CEHPNHHBNNM
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private sealed class CHLLADLMKPE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		public IMMLCIEBDAG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public List<BELJNJGLPJA> prefabHandles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		public List<BELJNJGLPJA> materialHandles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		public EBHOPDBMNPK<Material[]> loadMaterialsHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		public EBHOPDBMNPK<FMPJGLDDHNE> loadPrefabHandle;

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public CHLLADLMKPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x72BFB70", Offset = "0x72BEF70", VA = "0x1872BFB70")]
		internal HJOKANJAKGB LOGAJHNFGKB(string error)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	public LJKKDAKGHIG PFICMLEHNHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	public FMPJGLDDHNE CCNGHIHCOMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	private EBHOPDBMNPK<FMPJGLDDHNE> LIJEDLKIJCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	private EBHOPDBMNPK<Material[]> GBNOEKKHCEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	public Material[] PKMHMAPNIDB;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public bool IPKEKBKAGEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0xC81F60", Offset = "0xC81360", VA = "0x180C81F60")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0xC81E50", Offset = "0xC81250", VA = "0x180C81E50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public KBAIGJMAONF.FALICHFPADL ONDEFDKNLBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0xB00470", Offset = "0xAFF870", VA = "0x180B00470")]
		[CompilerGenerated]
		get
		{
			return default(KBAIGJMAONF.FALICHFPADL);
		}
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x11A9A30", Offset = "0x11A8E30", VA = "0x1811A9A30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x72C34B0", Offset = "0x72C28B0", VA = "0x1872C34B0")]
	public IMMLCIEBDAG(OBJHNMCDGDL MKJCGACHDHK, LJKKDAKGHIG GLBBLAAJPLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x72C2240", Offset = "0x72C1640", VA = "0x1872C2240", Slot = "6")]
	public override HJOKANJAKGB EJFPOGPKNJP(List<BELJNJGLPJA> NJNODBJNKGK, List<BELJNJGLPJA> CFOHIHHANCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x72C2F40", Offset = "0x72C2340", VA = "0x1872C2F40")]
	public HJOKANJAKGB OPLBBAGBMLP(List<BELJNJGLPJA> NJNODBJNKGK, List<BELJNJGLPJA> CFOHIHHANCN, EBHOPDBMNPK<Material[]> GBNOEKKHCEM, [Optional] EBHOPDBMNPK<FMPJGLDDHNE> GJJHPPJIBFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x72C2700", Offset = "0x72C1B00", VA = "0x1872C2700")]
	public (EBHOPDBMNPK<Material[]>, EBHOPDBMNPK<FMPJGLDDHNE>) EOJKJNHONLL(List<BELJNJGLPJA> NJNODBJNKGK, List<BELJNJGLPJA> CFOHIHHANCN)
	{
		return default((EBHOPDBMNPK<Material[]>, EBHOPDBMNPK<FMPJGLDDHNE>));
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x72C2DF0", Offset = "0x72C21F0", VA = "0x1872C2DF0", Slot = "7")]
	public override KIFHJDJPHPE HHCBKNFBCHD(uint GNAJNFCKONF, AvatarSkinnedMeshBoneOrderRemapsData MINBMMFMOIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x72C3250", Offset = "0x72C2650", VA = "0x1872C3250")]
	public KIFHJDJPHPE PLLNNKHCJDO(GameObject MOCILOCGFBE, uint GNAJNFCKONF, bool IHELEDGMCLB, bool HCEJKJKCPLD, AvatarSkinnedMeshBoneOrderRemapsData MINBMMFMOIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x72C2A80", Offset = "0x72C1E80", VA = "0x1872C2A80")]
	public static bool FAGEKODAMGL(Renderer[] LGCGHBBEHDN, string ANKMHOKKNFA, [Out] Renderer AKCIMNHMBGI, [Out] Renderer LKGPDOBPHMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x72C3460", Offset = "0x72C2860", VA = "0x1872C3460", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x72C2180", Offset = "0x72C1580", VA = "0x1872C2180")]
	private (EBHOPDBMNPK<FMPJGLDDHNE>, EBHOPDBMNPK<Material[]>) AMMOKNKHOIK()
	{
		return default((EBHOPDBMNPK<FMPJGLDDHNE>, EBHOPDBMNPK<Material[]>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x72C2F20", Offset = "0x72C2320", VA = "0x1872C2F20")]
	[CompilerGenerated]
	private void IGIINABNLPD(FMPJGLDDHNE BIEIOPPGBOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x94FB10", Offset = "0x94EF10", VA = "0x18094FB10")]
	[CompilerGenerated]
	private void BGPILGIKGCI(Material[] BIEIOPPGBOB)
	{
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public class AvatarKneeBendTargetController : MonoBehaviour, GGHNALLMHEG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		[SerializeField]
		[ALEFAIIJNEI(KCNGGJNCENB.Self, false, false, false)]
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
		private Vector3 AHCEBGJJBDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		private Vector3 EFNPGILCGPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		private Vector3 NAJFLODHIIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		private Matrix4x4 HBCBOEGDBAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		private bool NOMGHFOBMPE;

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x72BDB80", Offset = "0x72BCF80", VA = "0x1872BDB80", Slot = "4")]
		public void UpdateController(float HIBCBLOKLEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x72BDB70", Offset = "0x72BCF70", VA = "0x1872BDB70", Slot = "6")]
		public void SetEnabled(bool KBGCCIOIGBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x72BD710", Offset = "0x72BCB10", VA = "0x1872BD710")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x72BE240", Offset = "0x72BD640", VA = "0x1872BE240")]
		public AvatarKneeBendTargetController()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[GAFKBMEFLIK]
public struct NIBFLFKMMAG : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	[ReadOnly]
	public PFCDOEJMIDA FBAIBDOFCNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	[ReadOnly]
	public int JHFADOMOOGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	public NHEMOJHNGLC DFGJCDCKNNI;

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x72C9590", Offset = "0x72C8990", VA = "0x1872C9590", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[NativeContainer]
[GAFKBMEFLIK]
public struct NHEMOJHNGLC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	public NativeArray<Vector3> PJPHLIICOIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	public NativeArray<Vector3> MFHDKAJNHGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	public NativeArray<Vector4> EAGILGGDNGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	public NativeArray<Vector2> ALODLBEKEAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	public NativeArray<Vector2> PJLCOIJPIGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	public NativeArray<Vector2> NOHDKIBMBNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	public NativeArray<Vector2> CNBIBBCOKBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	public NativeArray<Color> OFGJFMEFBHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	public NativeArray<int> BJHAHFBHIIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	public NativeArray<int> JGLDDBAALLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	private NativeArray<int> HAMIKIAMKCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	private NativeArray<int> GNFLPDPHGLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	public NativeArray<int> PBAPNCFANJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	public NativeArray<int> PBBOIIKEKLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	public NativeArray<int> ABEBHMJIFGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	public NativeArray<BoneWeight> EECFMIFBEOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	private NativeArray<int> FJJOKDBOKAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	private bool LAMMAOBONGB;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public int GMBBBJCHFML
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x72C8B80", Offset = "0x72C7F80", VA = "0x1872C8B80")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x72C8C20", Offset = "0x72C8020", VA = "0x1872C8C20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public int FKDAOBCELNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x72C8C00", Offset = "0x72C8000", VA = "0x1872C8C00")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x72C8710", Offset = "0x72C7B10", VA = "0x1872C8710")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public int BIJLPBFCEML
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x72C8930", Offset = "0x72C7D30", VA = "0x1872C8930")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x72C8C10", Offset = "0x72C8010", VA = "0x1872C8C10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x72C9130", Offset = "0x72C8530", VA = "0x1872C9130")]
	public NHEMOJHNGLC(int DCAPCHJBFBL, int KIJGJIIFKFG, int JGOLOKHACFH, int KMLBPKIICHM, Allocator LEILKJFLDFN, int PJIBNECOEEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x72C8B10", Offset = "0x72C7F10", VA = "0x1872C8B10")]
	public void HHPMHFMNAJF(int EAHKFAJBNDN, Vector3 EFDAGALIIFI, Vector3 EOJJAMCHAEH, Vector4 CHBEBLKFDBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x72C8C30", Offset = "0x72C8030", VA = "0x1872C8C30")]
	public void OKJKLFJLGAK(int EAHKFAJBNDN, BoneWeight OMGFMBIBPEF, NativeSlice<byte> FFEHGHDGBPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x72C8BE0", Offset = "0x72C7FE0", VA = "0x1872C8BE0")]
	public Color JNLBMPGFNHP(int EAHKFAJBNDN)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x72C8AF0", Offset = "0x72C7EF0", VA = "0x1872C8AF0")]
	public void HEJAGELOGAE(int EAHKFAJBNDN, Color OPLPABIPAJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x72C8B90", Offset = "0x72C7F90", VA = "0x1872C8B90")]
	public void HPCGJKIOAEP(byte PNAPGIMAEDK, int EAHKFAJBNDN, Vector2 JLECHKDJMOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x72C8DD0", Offset = "0x72C81D0", VA = "0x1872C8DD0")]
	public void ONEPFBFBNOF(int EAHKFAJBNDN, int LFPNFLHKPCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x72C86E0", Offset = "0x72C7AE0", VA = "0x1872C86E0")]
	public bool ABJNLCGOEJM(int PNAPGIMAEDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x72C87D0", Offset = "0x72C7BD0", VA = "0x1872C87D0")]
	public void APGKCNCJEMG(int GCNALCOKJIM, int FDJGEFDKBBO, int GIGAFKHMOHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x72C8720", Offset = "0x72C7B20", VA = "0x1872C8720")]
	public int[] APFFNBBENFP(int GCNALCOKJIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x72C88A0", Offset = "0x72C7CA0", VA = "0x1872C88A0")]
	private NativeSlice<int> BGDJEAFBDKM(int GCNALCOKJIM)
	{
		return default(NativeSlice<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x72C8940", Offset = "0x72C7D40", VA = "0x1872C8940", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x72C8DE0", Offset = "0x72C81E0", VA = "0x1872C8DE0")]
	public Mesh PCNJPGHJCAK([Optional] string IHJJNKIBIDE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[NativeContainer]
[GAFKBMEFLIK]
[DefaultMember("Item")]
public struct PFCDOEJMIDA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	public NativeArray<Vector3> PJPHLIICOIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	public NativeArray<Vector3> MFHDKAJNHGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	public NativeArray<Vector4> EAGILGGDNGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	public NativeArray<Vector2> ALODLBEKEAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	public NativeArray<Vector2> PJLCOIJPIGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	public NativeArray<Vector2> NOHDKIBMBNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	public NativeArray<Vector2> CNBIBBCOKBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	public NativeArray<Color> OFGJFMEFBHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	public NativeArray<int> AMKEHPEMAPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	public NativeArray<int> EONDMLIJCFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	public NativeArray<int> OFMEBMPMPHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	public NativeArray<int> FDODPKLBOFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	public NativeArray<bool> MBLBPIKGHBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	public NativeArray<int> ELAEEHODNCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	public NativeArray<int> HJCAIMNKFOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	public NativeArray<BoneWeight> DCJEJNMJFBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	private NativeArray<Matrix4x4> IEGPKLJFIPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	private NativeArray<int> PCGCNHMBOII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	private NativeArray<byte> MNDAPPCMLNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	private NativeArray<int> BGDEOHHMEIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	private NativeArray<int> GPIMJGLPKAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	public NativeArray<sbyte> CBPNDGKJKKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	public NativeArray<byte> IMBLHDMFKOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	private NativeArray<int> LJCGAEHNNDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	private bool LAMMAOBONGB;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public int AILANCGLNEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x2555060", Offset = "0x2554460", VA = "0x182555060")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public int IPNIHLGMKHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0xAE0340", Offset = "0xADF740", VA = "0x180AE0340")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public int AKEIDLPADKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x72CBD50", Offset = "0x72CB150", VA = "0x1872CBD50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public int NGNEIPBLGEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x72CB7E0", Offset = "0x72CABE0", VA = "0x1872CB7E0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x72CBD30", Offset = "0x72CB130", VA = "0x1872CBD30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public int GMBBBJCHFML
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x72CB7D0", Offset = "0x72CABD0", VA = "0x1872CB7D0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x72CBD20", Offset = "0x72CB120", VA = "0x1872CBD20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public int KLOCEPDAPGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x72CB460", Offset = "0x72CA860", VA = "0x1872CB460")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x72CB540", Offset = "0x72CA940", VA = "0x1872CB540")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public LDBIEKJHPFI NEICIGCPFDL
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x72CBD40", Offset = "0x72CB140", VA = "0x1872CBD40")]
		get
		{
			return default(LDBIEKJHPFI);
		}
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x72CB7B0", Offset = "0x72CABB0", VA = "0x1872CB7B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public byte PEEONGELKEH
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x72CB7C0", Offset = "0x72CABC0", VA = "0x1872CB7C0")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x72CBD10", Offset = "0x72CB110", VA = "0x1872CBD10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public BMIFNDOJLHO NMMCMNBCFHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x72CB7F0", Offset = "0x72CABF0", VA = "0x1872CB7F0")]
		get
		{
			return default(BMIFNDOJLHO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x72CBD80", Offset = "0x72CB180", VA = "0x1872CBD80")]
	public PFCDOEJMIDA(IList<Mesh> JMIOOBAANOC, IList<Matrix4x4> AIGFAHJHCPH, IList<bool> MBLBPIKGHBL, byte DDBNJCIKGBE, IList<byte[]> ONOJOCHFGBF, IList<int> AJBCMOLPIAF, IList<bool> OKLIGHJAMIK, IList<int> ELAEEHODNCP, IList<int> MPNCJGPMPPN, IList<int> LDFOIFFKFJH, Allocator LEILKJFLDFN, LDBIEKJHPFI KKPPEJOKKDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x72CB470", Offset = "0x72CA870", VA = "0x1872CB470")]
	public NHEMOJHNGLC AODCLOLHDIH(Allocator LEILKJFLDFN)
	{
		return default(NHEMOJHNGLC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x72CB550", Offset = "0x72CA950", VA = "0x1872CB550", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[GAFKBMEFLIK]
public class DPCLJJNJOGA : NJGDPEGMCOM
{
	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x72C0060", Offset = "0x72BF460", VA = "0x1872C0060")]
	public PFCDOEJMIDA PCKDJDEKJBB()
	{
		return default(PFCDOEJMIDA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x72B50C0", Offset = "0x72B44C0", VA = "0x1872B50C0")]
	public DPCLJJNJOGA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public struct BMIFNDOJLHO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	public NativeSlice<Vector3> PJPHLIICOIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	public NativeSlice<Vector3> MFHDKAJNHGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	public NativeSlice<Vector4> EAGILGGDNGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	public NativeSlice<Vector2> ALODLBEKEAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	public NativeSlice<Vector2> PJLCOIJPIGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	public NativeSlice<Vector2> NOHDKIBMBNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	public NativeSlice<Vector2> CNBIBBCOKBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	public NativeSlice<Color> OFGJFMEFBHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	public NativeSlice<int> GOOIBFEMHJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	public NativeSlice<int> FDODPKLBOFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	public NativeSlice<BoneWeight> DCJEJNMJFBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	public NativeSlice<byte> OPHBJCBBLNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	public int OCJOEDICIGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	public Matrix4x4 ABJKIHNEOGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
	[Cpp2IlInjected.Token(Token = "0x40001DE")]
	public int JIJOKOIODIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40001DF")]
	public NativeSlice<byte> FFEHGHDGBPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	public bool CEPINDKOFMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	public int CMNAJANMPNF;
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
internal readonly struct IMJMIIIPNLF : IEquatable<IMJMIIIPNLF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	internal readonly Material IAODGAIPHAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	internal readonly BJGDFBKEINK ACJJLKFOJDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40001E4")]
	internal readonly DDOKGHHJODE AOAFMIIPOPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001E5")]
	internal readonly OBJHNMCDGDL IDLHGNGCIKJ;

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x72C2140", Offset = "0x72C1540", VA = "0x1872C2140")]
	public IMJMIIIPNLF(Material HJCEHLILOIG, BJGDFBKEINK PIEGLLCHINN, DDOKGHHJODE IPEPMKFNFHH, OBJHNMCDGDL DBDEIKJCEBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x72C1F10", Offset = "0x72C1310", VA = "0x1872C1F10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x72C1D00", Offset = "0x72C1100", VA = "0x1872C1D00", Slot = "4")]
	public bool Equals(IMJMIIIPNLF OKCHLIEAIJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x72C1D80", Offset = "0x72C1180", VA = "0x1872C1D80", Slot = "0")]
	public override bool Equals(object GMFKPONAANG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x72C1E70", Offset = "0x72C1270", VA = "0x1872C1E70", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[DisallowMultipleComponent]
	public class AvatarModernBodyDisplayBehaviour : MonoBehaviour, DDFBFAJGEGF
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
		private PKOOKMMPLDP avatarBodyType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		[SerializeField]
		private AvatarSkinAssetItem potatoAvatarSkinAssetItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		[SerializeField]
		[FormerlySerializedAs("avatarSkinAsset")]
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
		[SerializeField]
		[Header("Arm Animation Controllers")]
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
		private AHBNJGDEGOO CLLKMBMJEFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		private JGOJAJEODNM GMIJCCPBOIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		private ODFMHACHCFM PKJKEKAGLJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		private ODFMHACHCFM CLFKCPDLIKB;

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public AHBNJGDEGOO HBMMMILEKCF
		{
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x72BF070", Offset = "0x72BE470", VA = "0x1872BF070", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public JGOJAJEODNM MJHKIHENJIA
		{
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x72BF0C0", Offset = "0x72BE4C0", VA = "0x1872BF0C0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public ODFMHACHCFM DIHHKCLABAM
		{
			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0x72BF2E0", Offset = "0x72BE6E0", VA = "0x1872BF2E0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public ODFMHACHCFM NKCLBCHHOOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x72BF330", Offset = "0x72BE730", VA = "0x1872BF330", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public Transform CDCDMNLCAEH
		{
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x72BF380", Offset = "0x72BE780", VA = "0x1872BF380", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public PKOOKMMPLDP MFJBHKOKOAD
		{
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x94BDE0", Offset = "0x94B1E0", VA = "0x18094BDE0", Slot = "12")]
			get
			{
				return default(PKOOKMMPLDP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x72BE250", Offset = "0x72BD650", VA = "0x1872BE250")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x72BEED0", Offset = "0x72BE2D0", VA = "0x1872BEED0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x72BEBF0", Offset = "0x72BDFF0", VA = "0x1872BEBF0", Slot = "8")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x72BEED0", Offset = "0x72BE2D0", VA = "0x1872BEED0", Slot = "9")]
		public void TeardownAvatarDisplaySystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x72BE2C0", Offset = "0x72BD6C0", VA = "0x1872BE2C0", Slot = "10")]
		public bool CleanupDisplayMeshes()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x72BEF80", Offset = "0x72BE380", VA = "0x1872BEF80")]
		public void UpdatePostIKAnimControllers(float HIBCBLOKLEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x72BEE40", Offset = "0x72BE240", VA = "0x1872BEE40")]
		private void KDBGCODNDJN(GameObject GMFKPONAANG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x72BE880", Offset = "0x72BDC80", VA = "0x1872BE880")]
		private AHBNJGDEGOO HCJDDKGGCMI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x72BEC50", Offset = "0x72BE050", VA = "0x1872BEC50")]
		private JGOJAJEODNM JAPDDEELOII()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x72BE5F0", Offset = "0x72BD9F0", VA = "0x1872BE5F0")]
		private ODFMHACHCFM FFKBENDIDNF(ALIFPIFLCBK PHOLKKAAHFB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x72BF060", Offset = "0x72BE460", VA = "0x1872BF060")]
		public AvatarModernBodyDisplayBehaviour()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public class MIGKACJGENE : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000212")]
	private MaterialPropertyBlock POJMKDMPEIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000213")]
	public Color? DBFOGHLDJED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000214")]
	public Color? LKEIBHMGPLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000215")]
	public Color? ECJHEDNAHDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000216")]
	public Color? KKEFJABJJAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000217")]
	public Color NGGONCEKJCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000218")]
	public Color GKNLPPDHKEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000219")]
	public Color JHGGCJMNIIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400021A")]
	public Texture2D PEMJGFCGPDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400021B")]
	public Texture2D OJMNJIKGIAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400021C")]
	private Dictionary<IMJMIIIPNLF, int> EDEDDIPBAKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400021D")]
	private BJGDFBKEINK[] OLGAPGAFCHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400021E")]
	private DDOKGHHJODE[] MLMMHJBIJCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400021F")]
	public Vector4[] HOJBCIMGAAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000220")]
	public Vector4[] BDBEABPMDEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000221")]
	public Vector4[] KJIEKGGINDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000222")]
	public Vector4[] JFGADDKDPFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000223")]
	public Vector4[] HFBGOEODNAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000224")]
	public Vector4[] JAEKGDEJLIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000225")]
	private List<Texture2D> OPOKJAJLMNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000226")]
	private Vector4[] BNGCKLBFOHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000227")]
	private List<Texture2D> JLAFFJPDHMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000228")]
	private float[] NDBEGEBBMCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000229")]
	private Vector4[] BGPBFAMDCNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400022A")]
	private float[] GKIAFCDHIHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x400022B")]
	public float[] EBGAFMNGHCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x400022C")]
	private List<Texture2D> FEMNFDNOCAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x400022D")]
	private float[] OBHLACGDJEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x400022E")]
	private List<Texture2D> MJPMAEAHEFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x400022F")]
	private Vector4[] IOJLMDDLGIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x4000230")]
	private float[] MNPJFHPKEJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000231")]
	private Vector4[] KEILFGELNAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x4000232")]
	public float[] NBOOGPMEMPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000233")]
	public Texture2DArray KPEGGKDEHEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x4000234")]
	public Texture2DArray GFPLLCKOODK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000235")]
	public Texture2DArray EGAPGMHFKMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x4000236")]
	public Texture2DArray NAPIIOFHDCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x4000237")]
	private bool DBKFKABAANI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x184")]
	[Cpp2IlInjected.Token(Token = "0x4000238")]
	private int INGGKPCIDHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x4000239")]
	private Vector2? JBBELKDHKLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x194")]
	[Cpp2IlInjected.Token(Token = "0x400023A")]
	private TextureFormat NGMJABNEGJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x400023B")]
	private Vector2? CADHEHGAHML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A4")]
	[Cpp2IlInjected.Token(Token = "0x400023C")]
	private TextureFormat HAIDPOCPDLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x400023D")]
	private Vector2? CKIKGHGFLIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B4")]
	[Cpp2IlInjected.Token(Token = "0x400023E")]
	private TextureFormat NDKEFKCMEDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x400023F")]
	private Vector2? ELNCKGGCOLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C4")]
	[Cpp2IlInjected.Token(Token = "0x4000240")]
	private TextureFormat NCBKONCKIGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
	[Cpp2IlInjected.Token(Token = "0x4000241")]
	private bool LIABCKHNDHI;

	[Cpp2IlInjected.Token(Token = "0x4000242")]
	private static int JBBPANEJIAG;

	[Cpp2IlInjected.Token(Token = "0x4000243")]
	private static int HJAJBKIFOCD;

	[Cpp2IlInjected.Token(Token = "0x4000244")]
	private static int BBCJEOJMLAJ;

	[Cpp2IlInjected.Token(Token = "0x4000245")]
	private static int MJGPALFPDEM;

	[Cpp2IlInjected.Token(Token = "0x4000246")]
	private static int CGCHFBIFEOG;

	[Cpp2IlInjected.Token(Token = "0x4000247")]
	private static int OAAIHKJABCD;

	[Cpp2IlInjected.Token(Token = "0x4000248")]
	private static int NMLGBBJNHCH;

	[Cpp2IlInjected.Token(Token = "0x4000249")]
	private static int MBFFNHDMPCD;

	[Cpp2IlInjected.Token(Token = "0x400024A")]
	private static int GEAGJCFCCAK;

	[Cpp2IlInjected.Token(Token = "0x400024B")]
	private static int HNDKJNBCNPP;

	[Cpp2IlInjected.Token(Token = "0x400024C")]
	private static int OPEGEMNONGG;

	[Cpp2IlInjected.Token(Token = "0x400024D")]
	private static int JLAMHKENNND;

	[Cpp2IlInjected.Token(Token = "0x400024E")]
	private static int GAHBGIPKNBC;

	[Cpp2IlInjected.Token(Token = "0x400024F")]
	private static int LOEMIFOJCBL;

	[Cpp2IlInjected.Token(Token = "0x4000250")]
	private static int PGCKGHEENJP;

	[Cpp2IlInjected.Token(Token = "0x4000251")]
	private static int HAPMHMNCHHB;

	[Cpp2IlInjected.Token(Token = "0x4000252")]
	private static int EGNOEHCMCKC;

	[Cpp2IlInjected.Token(Token = "0x4000253")]
	private static int HLMHFCCNEFI;

	[Cpp2IlInjected.Token(Token = "0x4000254")]
	private static int LMLBKGIEJBB;

	[Cpp2IlInjected.Token(Token = "0x4000255")]
	private static int KLPBMFFPJAO;

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x72C7210", Offset = "0x72C6610", VA = "0x1872C7210")]
	private MIGKACJGENE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x72C7700", Offset = "0x72C6B00", VA = "0x1872C7700")]
	public MIGKACJGENE(Color IEBFENEMEIK, Color LOAJNIGDFIE, Color EAPIHGGHMMD, Color? AINKANFBEBP, Color? IHKBKDHEBPP, Color? LMMBMHGICJK, Texture2D NEKCGAHBFJF, Texture2D DJCPDCPKMGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x72C6D00", Offset = "0x72C6100", VA = "0x1872C6D00")]
	internal int OMBEAPDGBME(Material GAOIEHMCMOL, BJGDFBKEINK PIEGLLCHINN, DDOKGHHJODE IPEPMKFNFHH, OBJHNMCDGDL DBDEIKJCEBF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x72C6DF0", Offset = "0x72C61F0", VA = "0x1872C6DF0")]
	private int OMBEAPDGBME(IMJMIIIPNLF LKMGECEEGEE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x72C5880", Offset = "0x72C4C80", VA = "0x1872C5880")]
	internal int DBKADKAPBAC(Material GAOIEHMCMOL, Color KDBCFKGNGJP, Color OJKPDPFPHGP, Color EKKHNINCDDG, Color AJJDBGBBOLB, Color CEJFGPJEHDN, Texture2D PEJBFDIAPAA, Vector4 PHIIPKGLPLE, Texture2D DOJBPMEJOBE, Vector4 IFCCKHDPJEB, float FJNCKBNFJAI, float IGLGBOOJJAK, Texture2D IDDFMOLLGGE, Vector4 BAIJHFDMEEF, float HPGDACJJKHN, Texture2D BOEADKHPNCM, Color DDPMLLMDLNO, Vector4 HBDHPJCLBEB, BJGDFBKEINK PIEGLLCHINN, DDOKGHHJODE IPEPMKFNFHH, OBJHNMCDGDL DBDEIKJCEBF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x72C67E0", Offset = "0x72C5BE0", VA = "0x1872C67E0")]
	private void IKMNPHEGCBH(List<Texture2D> OPOKJAJLMNK, [Out] Texture2DArray DHCFOIPLAJB, [Out] Texture2DArray AKKHPCLFJAI, [Out] Texture2DArray CPKNNGHENAK, [Out] Texture2DArray GNGDKHFMOBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x72C6A50", Offset = "0x72C5E50", VA = "0x1872C6A50")]
	public void MCPMPJFJMIF(Shader KLLALGPLCJG, Renderer EHMEICJAGNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x72C4B80", Offset = "0x72C3F80", VA = "0x1872C4B80")]
	private void ALIOBPFNCIG(Shader KLLALGPLCJG, Renderer EHMEICJAGNO, int EJODJKFNBCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x72C65E0", Offset = "0x72C59E0", VA = "0x1872C65E0")]
	private Color EHOAOMHALFA(Color OIICHJCCJLN, BJGDFBKEINK PIKKFHOHKHL)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x72C6450", Offset = "0x72C5850", VA = "0x1872C6450")]
	private Color DHOIBNHFPKO(Color GPOLAKINJJB, BJGDFBKEINK PIKKFHOHKHL)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x72C6BA0", Offset = "0x72C5FA0", VA = "0x1872C6BA0")]
	private bool OFFJCKDDIFP(Texture2D GEMLMEAOFCE, DDOKGHHJODE CJLDBFGOACG, [Out] Texture2D HHDJOOBGCLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x72C69A0", Offset = "0x72C5DA0", VA = "0x1872C69A0")]
	private void LFLFHOBPLME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x72C65A0", Offset = "0x72C59A0", VA = "0x1872C65A0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public abstract class CEHPNHHBNNM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000259")]
	public readonly OBJHNMCDGDL CHEMOMFDFNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
	[Cpp2IlInjected.Token(Token = "0x400025A")]
	protected bool BKPFFCNLCBE;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public bool FBIBJGKLKIG
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0xB39EB0", Offset = "0xB392B0", VA = "0x180B39EB0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0xB396D0", Offset = "0xB38AD0", VA = "0x180B396D0")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public bool CNPLEMFMLHF
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0xB39640", Offset = "0xB38A40", VA = "0x180B39640")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0xB39E20", Offset = "0xB39220", VA = "0x180B39E20")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public virtual KBAIGJMAONF.FALICHFPADL JIJOKOIODIH
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0xA2E4D0", Offset = "0xA2D8D0", VA = "0x180A2E4D0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(KBAIGJMAONF.FALICHFPADL);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0xAEB110", Offset = "0xAEA510", VA = "0x180AEB110", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public bool PHFBELMLHIB
	{
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0xE938B0", Offset = "0xE92CB0", VA = "0x180E938B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public bool LHOBEADACPN
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x706E350", Offset = "0x706D750", VA = "0x18706E350")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public bool PGJNPMBMKFF
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x72BFB10", Offset = "0x72BEF10", VA = "0x1872BFB10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public bool NNIMFLNNHBI
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x72BFB20", Offset = "0x72BEF20", VA = "0x1872BFB20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x72BFB40", Offset = "0x72BEF40", VA = "0x1872BFB40")]
	protected CEHPNHHBNNM(OBJHNMCDGDL MKJCGACHDHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract HJOKANJAKGB EJFPOGPKNJP(List<BELJNJGLPJA> NJNODBJNKGK, List<BELJNJGLPJA> CFOHIHHANCN);

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract KIFHJDJPHPE HHCBKNFBCHD(uint GNAJNFCKONF, AvatarSkinnedMeshBoneOrderRemapsData MINBMMFMOIL);
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class PMLAJDCJGNF : DPJCMIHGKMA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400025B")]
	private AvatarSkinAssetItem BBCPEMJPNHM;

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x72CD860", Offset = "0x72CCC60", VA = "0x1872CD860")]
	public PMLAJDCJGNF(AvatarSkinAssetItem NKOJECCKCBD, AvatarSkinAssetItem.MBKPHICBOOJ GHHKFIEAPCG, OBJHNMCDGDL DBDEIKJCEBF, [Optional] EJPJNNNFMKK? IFJJNEIHMGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x72CD5F0", Offset = "0x72CC9F0", VA = "0x1872CD5F0", Slot = "6")]
	public override HJOKANJAKGB EJFPOGPKNJP(List<BELJNJGLPJA> NJNODBJNKGK, List<BELJNJGLPJA> CFOHIHHANCN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class BAIMMPILMAD
{
	[Cpp2IlInjected.Token(Token = "0x400025C")]
	private static readonly int[] FDIAGOKLIOI;

	[Cpp2IlInjected.Token(Token = "0x400025D")]
	private static readonly int[] PMBIKBOLCGJ;

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public static int[] JBLEEOFMNMH
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x72BF3B0", Offset = "0x72BE7B0", VA = "0x1872BF3B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x72BF400", Offset = "0x72BE800", VA = "0x1872BF400")]
	public static int[] HBMIGFKHDLI(bool EABGLLFKNPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x72BF490", Offset = "0x72BE890", VA = "0x1872BF490")]
	public static int NBCNDKGMCEH(OINJBHOKJEJ FGGAKOCECCL, bool EABGLLFKNPC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x72BF3A0", Offset = "0x72BE7A0", VA = "0x1872BF3A0")]
	private static int CJCAKKHJJBJ(OINJBHOKJEJ FGGAKOCECCL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x72BF520", Offset = "0x72BE920", VA = "0x1872BF520")]
	private static int ONKGCCMOKLH(OINJBHOKJEJ FGGAKOCECCL)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class LAMKJEPHICD
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private sealed class LFABBMJKEGE : IEnumerator<FBLKJCIOKGP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400025F")]
		private FBLKJCIOKGP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000260")]
		public JobHandle handle;

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		private FBLKJCIOKGP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(RVA = "0x94B6B0", Offset = "0x94AAB0", VA = "0x18094B6B0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x94B6B0", Offset = "0x94AAB0", VA = "0x18094B6B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x94B7A0", Offset = "0x94ABA0", VA = "0x18094B7A0")]
		[DebuggerHidden]
		public LFABBMJKEGE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x1055810", Offset = "0x1054C10", VA = "0x181055810", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x72C3680", Offset = "0x72C2A80", VA = "0x1872C3680", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60")]
	public static void AFGLAHBJJPN(string KGHCKLKGJKM, int GNAJNFCKONF, long ELBKCAMKOII, long GJDKAECMJLH, long MNKMGFLAHEK, long PIBDMPFGMDF, long MCFPHOIIJBC, long KAMECLDLOEA, long JLFPLKEMDAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x72C3520", Offset = "0x72C2920", VA = "0x1872C3520")]
	public static HPLGDNGCOKN NIPFIIPJNEF(JobHandle KICDBOCICCM, bool LKAJPOPBDDB, bool KNAMMMJKBJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x72C3610", Offset = "0x72C2A10", VA = "0x1872C3610")]
	[IteratorStateMachine(typeof(LFABBMJKEGE))]
	private static IEnumerator<FBLKJCIOKGP> PFDOBBKHJHB(JobHandle ILIIBOPHLDK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class CINMGFGDHMK
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public enum BMMGEMCPDOE
	{
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		General,
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		ColoredHair
	}

	[Cpp2IlInjected.Token(Token = "0x4000261")]
	public static readonly int FIKMOLOIHHO;

	[Cpp2IlInjected.Token(Token = "0x4000262")]
	public static readonly int COAOBHCKNMD;

	[Cpp2IlInjected.Token(Token = "0x4000263")]
	public static readonly int AJADFOAGDFH;

	[Cpp2IlInjected.Token(Token = "0x4000264")]
	public static readonly int POCMBLGAEFE;

	[Cpp2IlInjected.Token(Token = "0x4000265")]
	public static readonly int HOKNBKGKLJB;

	[Cpp2IlInjected.Token(Token = "0x4000266")]
	public static readonly int KDGNJNEBPOC;

	[Cpp2IlInjected.Token(Token = "0x4000267")]
	public static readonly int GDELFCKFKMB;

	[Cpp2IlInjected.Token(Token = "0x4000268")]
	public static readonly int PJHNPDNNFPC;

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x72BFE70", Offset = "0x72BF270", VA = "0x1872BFE70")]
	public static bool KDIILKEKEJN(Material HJCEHLILOIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x72BFDB0", Offset = "0x72BF1B0", VA = "0x1872BFDB0")]
	public static bool JAOJJAGOILA(Material HJCEHLILOIG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class DPJCMIHGKMA : CEHPNHHBNNM
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private sealed class HBNFPPJNMMC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		public EBHOPDBMNPK<GameObject> skinAvatarItemPrefabHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		public DPJCMIHGKMA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		public Action<string> <>9__1;

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public HBNFPPJNMMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x72C14F0", Offset = "0x72C08F0", VA = "0x1872C14F0")]
		internal void AHCJACCJBEC(GameObject result)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x72C18D0", Offset = "0x72C0CD0", VA = "0x1872C18D0")]
		internal void LOGAJHNFGKB(string error)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400026D")]
	protected AvatarSkinAssetItem EHEPODAOOLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400026E")]
	protected Material[] IOHJEFICLMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400026F")]
	private readonly AvatarSkinAssetItem.MBKPHICBOOJ GLNNBBEPJGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000270")]
	private readonly AssetReference MFCJFMIOAIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000271")]
	private readonly EJPJNNNFMKK? MAMGJOHCPPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000272")]
	private SkinnedMeshRenderer[] AGCBOMOEKBK;

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public override KBAIGJMAONF.FALICHFPADL JIJOKOIODIH
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0xA836D0", Offset = "0xA82AD0", VA = "0x180A836D0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(KBAIGJMAONF.FALICHFPADL);
		}
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0xB39280", Offset = "0xB38680", VA = "0x180B39280", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x72C06B0", Offset = "0x72BFAB0", VA = "0x1872C06B0")]
	public DPJCMIHGKMA(AvatarSkinAssetItem.MBKPHICBOOJ GHHKFIEAPCG, AssetReference CEFBPHKNGKO, Material IFINEEFKJJB, OBJHNMCDGDL DBDEIKJCEBF, KBAIGJMAONF.FALICHFPADL FOGBHKGEFLC = (KBAIGJMAONF.FALICHFPADL)0, [Optional] EJPJNNNFMKK? IFJJNEIHMGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x72C07E0", Offset = "0x72BFBE0", VA = "0x1872C07E0")]
	public DPJCMIHGKMA(AvatarSkinAssetItem.MBKPHICBOOJ GHHKFIEAPCG, AssetReference CEFBPHKNGKO, Material IFINEEFKJJB, KBAIGJMAONF.FALICHFPADL FOGBHKGEFLC = (KBAIGJMAONF.FALICHFPADL)0, [Optional] EJPJNNNFMKK? IFJJNEIHMGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x72C0150", Offset = "0x72BF550", VA = "0x1872C0150", Slot = "6")]
	public override HJOKANJAKGB EJFPOGPKNJP(List<BELJNJGLPJA> NJNODBJNKGK, List<BELJNJGLPJA> CFOHIHHANCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x72C0320", Offset = "0x72BF720", VA = "0x1872C0320", Slot = "7")]
	public override KIFHJDJPHPE HHCBKNFBCHD(uint GNAJNFCKONF, AvatarSkinnedMeshBoneOrderRemapsData MINBMMFMOIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x72C0640", Offset = "0x72BFA40", VA = "0x1872C0640", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x72C05F0", Offset = "0x72BF9F0", VA = "0x1872C05F0")]
	protected void NCGEAFKKDHH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public class ODNKPFEIMKD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000276")]
	private List<int> PEGKHMDIJEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000277")]
	private List<BAMEFJKOEPC> GNAKNOBFNDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000278")]
	private HashSet<Transform> OOODODAECPI;

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x72CB1A0", Offset = "0x72CA5A0", VA = "0x1872CB1A0")]
	public static ODNKPFEIMKD PDELBJIKOKA(Transform CHBEBLKFDBC, Dictionary<Transform, OutfitType?> OFMFEKNJICE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x72CA9C0", Offset = "0x72C9DC0", VA = "0x1872CA9C0")]
	private void BNCMGNIEPMI(Transform CHBEBLKFDBC, OBJHNMCDGDL DBDEIKJCEBF, Dictionary<Transform, OutfitType?> OFMFEKNJICE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x72CB070", Offset = "0x72CA470", VA = "0x1872CB070")]
	private void GDNJHFCNBCN(Transform JCFEMBBMLPO, OBJHNMCDGDL DBDEIKJCEBF, bool CHKLMCBNHGI, OutfitType? CNBEFNFJEEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x72CAC80", Offset = "0x72CA080", VA = "0x1872CAC80")]
	public LJJJGEKILBB CFIOBLMMGOG(HashSet<string> PEKMMPLCJOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x72CB330", Offset = "0x72CA730", VA = "0x1872CB330")]
	public ODNKPFEIMKD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public class LJJJGEKILBB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000279")]
	private List<BAMEFJKOEPC> GNAKNOBFNDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400027A")]
	private List<Matrix4x4> PADOINEHBLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400027B")]
	private Transform[] OGJHKALBBCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400027C")]
	private Matrix4x4[] NFKBIMNKJDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400027D")]
	private Dictionary<OADOAICIFLN, int> JFLKCCJFEON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400027E")]
	private List<IHLJLBIIEIJ> IJEOMNDNCDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400027F")]
	private bool EMNIGDBNJHL;

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public int AGHLCEGEAOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x72C42E0", Offset = "0x72C36E0", VA = "0x1872C42E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public Transform[] AKNFNJGGNLO
	{
		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x72C36D0", Offset = "0x72C2AD0", VA = "0x1872C36D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public Matrix4x4[] CMPKBJJLILP
	{
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x72C4030", Offset = "0x72C3430", VA = "0x1872C4030")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x72C3E30", Offset = "0x72C3230", VA = "0x1872C3E30")]
	public void GDNJHFCNBCN(Transform JCFEMBBMLPO, OBJHNMCDGDL DBDEIKJCEBF, OutfitType? CNBEFNFJEEJ, bool KIKFLHBEBPF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x72C3AF0", Offset = "0x72C2EF0", VA = "0x1872C3AF0")]
	private void GDNJHFCNBCN(Transform JCFEMBBMLPO, OBJHNMCDGDL DBDEIKJCEBF, OutfitType? CNBEFNFJEEJ, bool KIKFLHBEBPF, Matrix4x4 BMEGOLAAOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x72C3840", Offset = "0x72C2C40", VA = "0x1872C3840")]
	public int EFMFAHFBCHL(OADOAICIFLN LKMGECEEGEE, bool PJGFKPDOMOM, [Optional] OutfitType? CNBEFNFJEEJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x72C39F0", Offset = "0x72C2DF0", VA = "0x1872C39F0")]
	public int FNPOCFABELO(OBJHNMCDGDL DBDEIKJCEBF, [Optional] OutfitType? CNBEFNFJEEJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x72C41F0", Offset = "0x72C35F0", VA = "0x1872C41F0")]
	public void OGFOGPHFLLF(OADOAICIFLN LKMGECEEGEE, Matrix4x4 FFCKKKAIOMF, bool PJGFKPDOMOM = false, [Optional] OutfitType? CNBEFNFJEEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x72C40A0", Offset = "0x72C34A0", VA = "0x1872C40A0")]
	public Matrix4x4 JCCBGHCDFIN(OADOAICIFLN LKMGECEEGEE, bool PJGFKPDOMOM, [Optional] OutfitType? CNBEFNFJEEJ)
	{
		return default(Matrix4x4);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x1134990", Offset = "0x1133D90", VA = "0x181134990")]
	public void IPLHNBAJKNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x72C4320", Offset = "0x72C3720", VA = "0x1872C4320")]
	public LJJJGEKILBB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public struct OADOAICIFLN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000283")]
	public readonly string MPOOIKLEGIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000284")]
	public readonly OBJHNMCDGDL IDLHGNGCIKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000285")]
	public readonly OutfitType? GHHMKNNILOF;

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x72CA780", Offset = "0x72C9B80", VA = "0x1872CA780")]
	public OADOAICIFLN(string MHIJJLMKFIP, OBJHNMCDGDL DBDEIKJCEBF, [Optional] OutfitType? CNBEFNFJEEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x72CA6D0", Offset = "0x72C9AD0", VA = "0x1872CA6D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x72CA610", Offset = "0x72C9A10", VA = "0x1872CA610")]
	public bool ONNLACEOLHH(OADOAICIFLN OKCHLIEAIJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x72CA4F0", Offset = "0x72C98F0", VA = "0x1872CA4F0", Slot = "0")]
	public override bool Equals(object GMFKPONAANG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x72CA5A0", Offset = "0x72C99A0", VA = "0x1872CA5A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public struct IHLJLBIIEIJ : IEquatable<IHLJLBIIEIJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000286")]
	public readonly OBJHNMCDGDL IDLHGNGCIKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000287")]
	public readonly OutfitType? OMLPHCLBOPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000288")]
	public readonly int CNHJEMEDEKG;

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x72C1CF0", Offset = "0x72C10F0", VA = "0x1872C1CF0")]
	public IHLJLBIIEIJ(OBJHNMCDGDL DBDEIKJCEBF, int HKKLOAOPFED, [Optional] OutfitType? LGHIBMHGALF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x72C1C20", Offset = "0x72C1020", VA = "0x1872C1C20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x65EC4D0", Offset = "0x65EB8D0", VA = "0x1865EC4D0")]
	public bool IMMNOKNDIIE(OBJHNMCDGDL DBDEIKJCEBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x72C1B50", Offset = "0x72C0F50", VA = "0x1872C1B50")]
	public bool GBFEDJGHMNP(OutfitType? LGHIBMHGALF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x72C1A10", Offset = "0x72C0E10", VA = "0x1872C1A10", Slot = "4")]
	public bool Equals(IHLJLBIIEIJ OKCHLIEAIJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x72C1A60", Offset = "0x72C0E60", VA = "0x1872C1A60", Slot = "0")]
	public override bool Equals(object GMFKPONAANG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x72C1BD0", Offset = "0x72C0FD0", VA = "0x1872C1BD0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public struct BAMEFJKOEPC : IEquatable<BAMEFJKOEPC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000289")]
	public readonly Transform LDHGIKPHDPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400028A")]
	public readonly bool HPOLAEKJMMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x400028B")]
	public readonly OBJHNMCDGDL CCHPAJJHHMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400028C")]
	public readonly OutfitType? GHHMKNNILOF;

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x72BFAC0", Offset = "0x72BEEC0", VA = "0x1872BFAC0")]
	public BAMEFJKOEPC(Transform JCFEMBBMLPO, bool CHKLMCBNHGI, OBJHNMCDGDL GOMFDEPAONA, [Optional] OutfitType? GMBCGJHDMJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x72BF8A0", Offset = "0x72BECA0", VA = "0x1872BF8A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x72BF720", Offset = "0x72BEB20", VA = "0x1872BF720", Slot = "4")]
	public bool Equals(BAMEFJKOEPC OKCHLIEAIJP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x72BF640", Offset = "0x72BEA40", VA = "0x1872BF640", Slot = "0")]
	public override bool Equals(object GMFKPONAANG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x72BF820", Offset = "0x72BEC20", VA = "0x1872BF820", Slot = "2")]
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
		[Cpp2IlInjected.Address(RVA = "0x72C0F00", Offset = "0x72C0300", VA = "0x1872C0F00")]
		public static void DespawnHairHemisphere()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60")]
		public void UpdateValues()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x94AA50", Offset = "0x949E50", VA = "0x18094AA50")]
		public FitMeshHemisphereUpdater()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public interface HPHBLHCBCNN
{
	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BMFCBKCPPJP(Mesh LCGHOEMEOEK, Matrix4x4 OGMKAOPLLDA, byte[] FFEHGHDGBPA, bool CBFKEKGDGGD = false, KBAIGJMAONF.FALICHFPADL IPOKALCDIKI = (KBAIGJMAONF.FALICHFPADL)0, int ELAEEHODNCP = -1, bool MBLBPIKGHBL = false);

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JKGNMOLLMOL(Allocator LEILKJFLDFN, LDBIEKJHPFI KKPPEJOKKDF, byte DDBNJCIKGBE, [Optional] IList<int> MPNCJGPMPPN, [Optional] IList<int> KKBDINDOJJG);
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public readonly struct FMPJGLDDHNE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000298")]
	public readonly GameObject MOCILOCGFBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000299")]
	private readonly AvatarItemMaterial PBNNLPIPCPF;

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x9AB3A0", Offset = "0x9AA7A0", VA = "0x1809AB3A0")]
	public FMPJGLDDHNE(GameObject MOCILOCGFBE, AvatarItemMaterial PBNNLPIPCPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x72C0E70", Offset = "0x72C0270", VA = "0x1872C0E70")]
	public void PFHMKKDCKDH(Material HJCEHLILOIG, int CLLOKPKIGEH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public class LPFPHDKGGJG : IDPINFFBPGI<Task<(GameObject, AvatarItemMaterial)>, FMPJGLDDHNE>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private struct ENJJIOMJDME : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x72C0900", Offset = "0x72BFD00", VA = "0x1872C0900", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x72C0E00", Offset = "0x72C0200", VA = "0x1872C0E00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400029A")]
	private EBHOPDBMNPK<GameObject> HOFKJJADEFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400029B")]
	private EBHOPDBMNPK<AvatarItemMaterial> BHKJEPJJCIP;

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x72C4AF0", Offset = "0x72C3EF0", VA = "0x1872C4AF0")]
	private LPFPHDKGGJG(Task<(GameObject, AvatarItemMaterial)> CBPINBDBDCO, EBHOPDBMNPK<GameObject> MEOBHAMACOG, EBHOPDBMNPK<AvatarItemMaterial> MNCBGJFMKJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x72C46E0", Offset = "0x72C3AE0", VA = "0x1872C46E0")]
	public static LPFPHDKGGJG OILMBKHFGKP(AssetReference LMDMGMLONEC, [Optional] AssetReference ACDEDFBKHJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x72C4640", Offset = "0x72C3A40", VA = "0x1872C4640", Slot = "11")]
	protected override FMPJGLDDHNE DHKALHEMICK(Task<(GameObject, AvatarItemMaterial)> OJHAAGOGBNE)
	{
		return default(FMPJGLDDHNE);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x72C45C0", Offset = "0x72C39C0", VA = "0x1872C45C0", Slot = "12")]
	protected override void DHGLNKNCHGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x72C4490", Offset = "0x72C3890", VA = "0x1872C4490")]
	[AsyncStateMachine(typeof(ENJJIOMJDME))]
	private static Task<(GameObject, AvatarItemMaterial)> AFFKPBEPIMJ(Task<GameObject> MMNIJOAIEHF, Task<AvatarItemMaterial> LMKPFKONONH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class AOEELEIHHCK
{
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	private class GHKKKGCCDOD : IDPINFFBPGI<Task<MaterialMapAsset>, Material[]>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		private EBHOPDBMNPK<MaterialMapAsset> ILIIBOPHLDK;

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x72C1410", Offset = "0x72C0810", VA = "0x1872C1410")]
		public GHKKKGCCDOD(EBHOPDBMNPK<MaterialMapAsset> ILIIBOPHLDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x72C0FD0", Offset = "0x72C03D0", VA = "0x1872C0FD0", Slot = "11")]
		protected override Material[] DHKALHEMICK(Task<MaterialMapAsset> CBPINBDBDCO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x72C0F70", Offset = "0x72C0370", VA = "0x1872C0F70", Slot = "12")]
		protected override void DHGLNKNCHGP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	private class OBLKMDKGADC : IDPINFFBPGI<Task<Material[]>, Material[]>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		private List<EBHOPDBMNPK<Material>> FEJHOLHIAPJ;

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x72CA950", Offset = "0x72C9D50", VA = "0x1872CA950")]
		public OBLKMDKGADC(Task<Material[]> CBPINBDBDCO, List<EBHOPDBMNPK<Material>> FEJHOLHIAPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x72CA900", Offset = "0x72C9D00", VA = "0x1872CA900", Slot = "11")]
		protected override Material[] DHKALHEMICK(Task<Material[]> OJHAAGOGBNE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x72CA7C0", Offset = "0x72C9BC0", VA = "0x1872CA7C0", Slot = "12")]
		protected override void DHGLNKNCHGP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40002A6")]
	private static readonly IBCMILIKEJG DDKJAEALMGF;

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x72BC620", Offset = "0x72BBA20", VA = "0x1872BC620")]
	public static EBHOPDBMNPK<Material[]> BEEHOLIHOKH(AssetReference[] NMFPEOHKCGN)
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
		public enum ELDJGACMLPI
		{
			[Cpp2IlInjected.Token(Token = "0x4000331")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4000332")]
			TeamItem,
			[Cpp2IlInjected.Token(Token = "0x4000333")]
			SkinColor,
			[Cpp2IlInjected.Token(Token = "0x4000334")]
			HairColor,
			[Cpp2IlInjected.Token(Token = "0x4000335")]
			BeardColor,
			[Cpp2IlInjected.Token(Token = "0x4000336")]
			UGCShirtColor
		}

		[Cpp2IlInjected.Token(Token = "0x2000056")]
		public enum FKJFCNDMIGG
		{
			[Cpp2IlInjected.Token(Token = "0x4000338")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4000339")]
			HairTexture,
			[Cpp2IlInjected.Token(Token = "0x400033A")]
			BeardTexture,
			[Cpp2IlInjected.Token(Token = "0x400033B")]
			UGCShirtTexture
		}

		[Cpp2IlInjected.Token(Token = "0x2000057")]
		public enum BKKKDFDJABB : byte
		{
			[Cpp2IlInjected.Token(Token = "0x400033D")]
			All,
			[Cpp2IlInjected.Token(Token = "0x400033E")]
			LOD0Only,
			[Cpp2IlInjected.Token(Token = "0x400033F")]
			EditorToolAll
		}

		[Cpp2IlInjected.Token(Token = "0x2000058")]
		public struct LNEMEGHNMGK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000340")]
			public readonly Material IAODGAIPHAL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000341")]
			public readonly ELDJGACMLPI ACJJLKFOJDE;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x4000342")]
			public readonly FKJFCNDMIGG AOAFMIIPOPC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000343")]
			public readonly OBJHNMCDGDL IDLHGNGCIKJ;

			[Cpp2IlInjected.Token(Token = "0x60002CF")]
			[Cpp2IlInjected.Address(RVA = "0x72C2140", Offset = "0x72C1540", VA = "0x1872C2140")]
			public LNEMEGHNMGK(Material HJCEHLILOIG, ELDJGACMLPI PIEGLLCHINN, FKJFCNDMIGG IPEPMKFNFHH, OBJHNMCDGDL DBDEIKJCEBF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002D0")]
			[Cpp2IlInjected.Address(RVA = "0x72E2D00", Offset = "0x72E2100", VA = "0x1872E2D00", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002D1")]
			[Cpp2IlInjected.Address(RVA = "0x72C1D00", Offset = "0x72C1100", VA = "0x1872C1D00")]
			public bool ONNLACEOLHH(LNEMEGHNMGK OKCHLIEAIJP)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002D2")]
			[Cpp2IlInjected.Address(RVA = "0x72E2B70", Offset = "0x72E1F70", VA = "0x1872E2B70", Slot = "0")]
			public override bool Equals(object GMFKPONAANG)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002D3")]
			[Cpp2IlInjected.Address(RVA = "0x72E2C60", Offset = "0x72E2060", VA = "0x1872E2C60", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000059")]
		protected struct MJOIPLEFGEK : IComparable<MJOIPLEFGEK>, IEquatable<MJOIPLEFGEK>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000344")]
			public int KMLDDFPOOAF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000345")]
			public PlayerAvatarDisplayBase BBCHEHFFEBG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000346")]
			public IList<DKLBEPIMGOL> OGOKKEIDLED;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000347")]
			public AvatarItemBodyType CIIOLIKMEAI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000348")]
			public IIFAJIGINPD IFCKEGGHKCC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000349")]
			public bool FIHAFEEGAGA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400034A")]
			public int[] MOFBLKNOEOE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400034B")]
			public float MOEAGHOMEOM;

			[Cpp2IlInjected.Token(Token = "0x60002D4")]
			[Cpp2IlInjected.Address(RVA = "0x72E3090", Offset = "0x72E2490", VA = "0x1872E3090", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002D5")]
			[Cpp2IlInjected.Address(RVA = "0x72E2F30", Offset = "0x72E2330", VA = "0x1872E2F30", Slot = "4")]
			public int CompareTo(MJOIPLEFGEK OKCHLIEAIJP)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60002D6")]
			[Cpp2IlInjected.Address(RVA = "0x72E2F50", Offset = "0x72E2350", VA = "0x1872E2F50", Slot = "5")]
			public bool Equals(MJOIPLEFGEK OKCHLIEAIJP)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005A")]
		protected abstract class OGMDKFDFBIB
		{
			[Cpp2IlInjected.Token(Token = "0x200005B")]
			public class GIEBLOPMBKG
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400034F")]
				public readonly Mesh KFDGIAJINED;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000350")]
				public readonly Material[] KNEEJKFKEII;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000351")]
				public readonly Transform[] GMLOJIKNGNI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000352")]
				public readonly Matrix4x4[] NPKOJEOEIDO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000353")]
				public readonly Transform GIEMGBAOEND;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x4000354")]
				public readonly bool FNHHMLAJPBC;

				[Cpp2IlInjected.Token(Token = "0x60002DE")]
				[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
				protected GIEBLOPMBKG()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002DF")]
				[Cpp2IlInjected.Address(RVA = "0x72DCE20", Offset = "0x72DC220", VA = "0x1872DCE20")]
				public GIEBLOPMBKG(Mesh LCGHOEMEOEK, Material[] JHJJAFEAONB, bool HMLEKJDHBAO, Transform[] BLNGGKCOHMF, Transform FHNGLJKKLGK, Matrix4x4[] HFMNNJGNFEK)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002E0")]
				[Cpp2IlInjected.Address(RVA = "0x72DCD60", Offset = "0x72DC160", VA = "0x1872DCD60")]
				private GIEBLOPMBKG(SkinnedMeshRenderer BNBIMMBDEGH, Material[] GDFHBJLKHMG)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002E1")]
				[Cpp2IlInjected.Address(RVA = "0x72DD2D0", Offset = "0x72DC6D0", VA = "0x1872DD2D0")]
				private GIEBLOPMBKG(MeshRenderer AADKLBCKCDD, Transform FHNGLJKKLGK, Material[] GDFHBJLKHMG)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60002E2")]
				[Cpp2IlInjected.Address(RVA = "0x72DCA30", Offset = "0x72DBE30", VA = "0x1872DCA30")]
				public static GIEBLOPMBKG DBGIJHFGGDN(Renderer EHMEICJAGNO, Material[] GDFHBJLKHMG)
				{
					return null;
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400034C")]
			public readonly OBJHNMCDGDL IDLHGNGCIKJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400034D")]
			public readonly Transform BHCNCFIOPCN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400034E")]
			public readonly bool IGFKONMHBPM;

			[Cpp2IlInjected.Token(Token = "0x17000087")]
			public virtual bool FBIBJGKLKIG
			{
				[Cpp2IlInjected.Token(Token = "0x60002D7")]
				[Cpp2IlInjected.Address(RVA = "0x993CC0", Offset = "0x9930C0", VA = "0x180993CC0", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000088")]
			public virtual bool CNPLEMFMLHF
			{
				[Cpp2IlInjected.Token(Token = "0x60002D8")]
				[Cpp2IlInjected.Address(RVA = "0x993CC0", Offset = "0x9930C0", VA = "0x180993CC0", Slot = "5")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000089")]
			public virtual KBAIGJMAONF.FALICHFPADL JIJOKOIODIH
			{
				[Cpp2IlInjected.Token(Token = "0x60002D9")]
				[Cpp2IlInjected.Address(RVA = "0x94AA70", Offset = "0x949E70", VA = "0x18094AA70", Slot = "6")]
				get
				{
					return default(KBAIGJMAONF.FALICHFPADL);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008A")]
			public bool CEPINDKOFMB
			{
				[Cpp2IlInjected.Token(Token = "0x60002DA")]
				[Cpp2IlInjected.Address(RVA = "0x72E3860", Offset = "0x72E2C60", VA = "0x1872E3860")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002DB")]
			[Cpp2IlInjected.Address(RVA = "0x72E3870", Offset = "0x72E2C70", VA = "0x1872E3870")]
			protected OGMDKFDFBIB(OBJHNMCDGDL DBDEIKJCEBF, Transform AALAFJLGDAL, bool JPPIHJIOHKC = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002DC")]
			[Cpp2IlInjected.Address(Slot = "7")]
			public abstract HJOKANJAKGB EJFPOGPKNJP(List<BELJNJGLPJA> NJNODBJNKGK, List<BELJNJGLPJA> CFOHIHHANCN);

			[Cpp2IlInjected.Token(Token = "0x60002DD")]
			[Cpp2IlInjected.Address(Slot = "8")]
			public abstract GIEBLOPMBKG HHCBKNFBCHD(int GNAJNFCKONF, PlayerHandBones OKCCOEOJCAI);
		}

		[Cpp2IlInjected.Token(Token = "0x200005C")]
		protected class EGNICOOMJBK : OGMDKFDFBIB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000355")]
			protected readonly BodyPartLODs AGCBOMOEKBK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000356")]
			protected readonly Material[] IOHJEFICLMF;

			[Cpp2IlInjected.Token(Token = "0x60002E3")]
			[Cpp2IlInjected.Address(RVA = "0x72DC810", Offset = "0x72DBC10", VA = "0x1872DC810")]
			public EGNICOOMJBK(OBJHNMCDGDL DBDEIKJCEBF, BodyPartLODs DJJJKBGJECN, Material IFINEEFKJJB, [Optional] Transform AALAFJLGDAL, bool JPPIHJIOHKC = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002E4")]
			[Cpp2IlInjected.Address(RVA = "0x72DC550", Offset = "0x72DB950", VA = "0x1872DC550", Slot = "7")]
			public override HJOKANJAKGB EJFPOGPKNJP(List<BELJNJGLPJA> NJNODBJNKGK, List<BELJNJGLPJA> CFOHIHHANCN)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002E5")]
			[Cpp2IlInjected.Address(RVA = "0x72DC5E0", Offset = "0x72DB9E0", VA = "0x1872DC5E0", Slot = "8")]
			public override GIEBLOPMBKG HHCBKNFBCHD(int GNAJNFCKONF, PlayerHandBones OKCCOEOJCAI)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002E6")]
			[Cpp2IlInjected.Address(RVA = "0x72DC7A0", Offset = "0x72DBBA0", VA = "0x1872DC7A0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005D")]
		protected class KONAGGEKGFJ : OGMDKFDFBIB
		{
			[Cpp2IlInjected.Token(Token = "0x1700008B")]
			public override bool FBIBJGKLKIG
			{
				[Cpp2IlInjected.Token(Token = "0x60002E7")]
				[Cpp2IlInjected.Address(RVA = "0x965500", Offset = "0x964900", VA = "0x180965500", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008C")]
			public override bool CNPLEMFMLHF
			{
				[Cpp2IlInjected.Token(Token = "0x60002E8")]
				[Cpp2IlInjected.Address(RVA = "0x72E2A40", Offset = "0x72E1E40", VA = "0x1872E2A40", Slot = "5")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008D")]
			public LBKMHAIBEMP HCAGBBDPLIN
			{
				[Cpp2IlInjected.Token(Token = "0x60002E9")]
				[Cpp2IlInjected.Address(RVA = "0x94B9E0", Offset = "0x94ADE0", VA = "0x18094B9E0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60002EA")]
				[Cpp2IlInjected.Address(RVA = "0x94B7E0", Offset = "0x94ABE0", VA = "0x18094B7E0")]
				[CompilerGenerated]
				protected set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002EB")]
			[Cpp2IlInjected.Address(RVA = "0x72E2B00", Offset = "0x72E1F00", VA = "0x1872E2B00")]
			public KONAGGEKGFJ(OBJHNMCDGDL DBDEIKJCEBF, Transform AALAFJLGDAL, LBKMHAIBEMP HBNIICBFICF, bool JPPIHJIOHKC = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002EC")]
			[Cpp2IlInjected.Address(RVA = "0x72E29B0", Offset = "0x72E1DB0", VA = "0x1872E29B0", Slot = "7")]
			public override HJOKANJAKGB EJFPOGPKNJP(List<BELJNJGLPJA> NJNODBJNKGK, List<BELJNJGLPJA> CFOHIHHANCN)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002ED")]
			[Cpp2IlInjected.Address(RVA = "0x94AA70", Offset = "0x949E70", VA = "0x18094AA70", Slot = "8")]
			public override GIEBLOPMBKG HHCBKNFBCHD(int GNAJNFCKONF, PlayerHandBones OKCCOEOJCAI)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002EE")]
			[Cpp2IlInjected.Address(RVA = "0x72E2A90", Offset = "0x72E1E90", VA = "0x1872E2A90", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005E")]
		public class HEGIBBBEJHN
		{
			[Cpp2IlInjected.Token(Token = "0x200005F")]
			public enum CLFGADHCMLH
			{
				[Cpp2IlInjected.Token(Token = "0x4000368")]
				PLAYER_PUPPET,
				[Cpp2IlInjected.Token(Token = "0x4000369")]
				PLAYER_DISPLAY_POSER,
				[Cpp2IlInjected.Token(Token = "0x400036A")]
				PLAYER_HAND,
				[Cpp2IlInjected.Token(Token = "0x400036B")]
				STNMONSTERCOSTUME_OPTION_HIDE_EXCEPT_UI,
				[Cpp2IlInjected.Token(Token = "0x400036C")]
				PLAYER_HAND_POINTING,
				[Cpp2IlInjected.Token(Token = "0x400036D")]
				STNMONSTERCOSTUME_OPTION_ALWAYS_HIDE,
				[Cpp2IlInjected.Token(Token = "0x400036E")]
				EDITOR
			}

			[Cpp2IlInjected.Token(Token = "0x4000358")]
			public static readonly int BIDKNBGNPMO;

			[Cpp2IlInjected.Token(Token = "0x4000359")]
			public static readonly int BNHBEOLDEBD;

			[Cpp2IlInjected.Token(Token = "0x400035A")]
			public static readonly int BPIBMDKJCHH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400035B")]
			protected readonly ALIFPIFLCBK PHOLKKAAHFB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400035C")]
			protected readonly GGAINOJCJPJ PBBHHFJDGGI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400035D")]
			protected readonly Animator IEACKBDAGDE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400035E")]
			protected readonly Transform FJGLBBJIGOO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400035F")]
			protected readonly Vector3 JFOFOHGOEAF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000360")]
			protected readonly Transform PMLHOOBBPAB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000361")]
			protected readonly Vector3 JHABGBAOAJH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x4000362")]
			protected bool MLJDAKCNCHC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000363")]
			protected ODFMHACHCFM LONFFBLGCLL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000364")]
			protected bool KNFLLHIMAIM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
			[Cpp2IlInjected.Token(Token = "0x4000365")]
			protected float ACODDJADCDO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000366")]
			protected GJKLJJDNPDD<BKMINCPGJKF> NCKEEFGIMMN;

			[Cpp2IlInjected.Token(Token = "0x1700008E")]
			public ODFMHACHCFM GIHFFLGNHCM
			{
				[Cpp2IlInjected.Token(Token = "0x60002EF")]
				[Cpp2IlInjected.Address(RVA = "0x94FCC0", Offset = "0x94F0C0", VA = "0x18094FCC0")]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60002F0")]
				[Cpp2IlInjected.Address(RVA = "0x94FD40", Offset = "0x94F140", VA = "0x18094FD40")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700008F")]
			public bool BNCGLLGIOGP
			{
				[Cpp2IlInjected.Token(Token = "0x60002F1")]
				[Cpp2IlInjected.Address(RVA = "0xA994E0", Offset = "0xA988E0", VA = "0x180A994E0")]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x60002F2")]
				[Cpp2IlInjected.Address(RVA = "0x72DDC60", Offset = "0x72DD060", VA = "0x1872DDC60")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000090")]
			public bool ILDDEFJEBNP
			{
				[Cpp2IlInjected.Token(Token = "0x60002F3")]
				[Cpp2IlInjected.Address(RVA = "0x94FC70", Offset = "0x94F070", VA = "0x18094FC70")]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x60002F4")]
				[Cpp2IlInjected.Address(RVA = "0x72DDD30", Offset = "0x72DD130", VA = "0x1872DDD30")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000091")]
			public float BAAJDGOAOJO
			{
				[Cpp2IlInjected.Token(Token = "0x60002F5")]
				[Cpp2IlInjected.Address(RVA = "0xB39E10", Offset = "0xB39210", VA = "0x180B39E10")]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x60002F6")]
				[Cpp2IlInjected.Address(RVA = "0x72DE240", Offset = "0x72DD640", VA = "0x1872DE240")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000092")]
			public BKMINCPGJKF CKDJDBNIEEN
			{
				[Cpp2IlInjected.Token(Token = "0x60002F7")]
				[Cpp2IlInjected.Address(RVA = "0x72DE200", Offset = "0x72DD600", VA = "0x1872DE200")]
				get
				{
					return default(BKMINCPGJKF);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60002F8")]
			[Cpp2IlInjected.Address(RVA = "0x72DE380", Offset = "0x72DD780", VA = "0x1872DE380")]
			public bool PHPDOJMIPBP(BKMINCPGJKF DNIICHOJIOP, object LAAJFAFNFCN, CLFGADHCMLH DKBNIPNLNJH)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002F9")]
			[Cpp2IlInjected.Address(RVA = "0x72DE0A0", Offset = "0x72DD4A0", VA = "0x1872DE0A0")]
			public bool JIIFKOJEADH(object LAAJFAFNFCN)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002FA")]
			[Cpp2IlInjected.Address(RVA = "0x72DE540", Offset = "0x72DD940", VA = "0x1872DE540")]
			protected HEGIBBBEJHN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002FB")]
			[Cpp2IlInjected.Address(RVA = "0x72DE5D0", Offset = "0x72DD9D0", VA = "0x1872DE5D0")]
			public HEGIBBBEJHN(ALIFPIFLCBK PHOLKKAAHFB, ODFMHACHCFM OKBAPKKKGCK, Animator IEACKBDAGDE, Transform FJGLBBJIGOO, Transform PMLHOOBBPAB, Vector3 JFOFOHGOEAF, Vector3 JHABGBAOAJH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002FC")]
			[Cpp2IlInjected.Address(RVA = "0x72DDAF0", Offset = "0x72DCEF0", VA = "0x1872DDAF0")]
			private void DAFLBNBPLCJ(ushort OPEDKOMLKHD, ushort AKLNHNJLKBM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002FD")]
			[Cpp2IlInjected.Address(RVA = "0x72DDF60", Offset = "0x72DD360", VA = "0x1872DDF60")]
			protected void HHEMFNDFFJP(ushort OPEDKOMLKHD, ushort AKLNHNJLKBM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002FE")]
			[Cpp2IlInjected.Address(RVA = "0x72DDBA0", Offset = "0x72DCFA0", VA = "0x1872DDBA0")]
			protected void DMDBIBHKHKB(ushort OPEDKOMLKHD, ushort AKLNHNJLKBM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002FF")]
			[Cpp2IlInjected.Address(RVA = "0x72DD9C0", Offset = "0x72DCDC0", VA = "0x1872DD9C0")]
			protected void CLKPBDEKAAL(ushort OPEDKOMLKHD, ushort AKLNHNJLKBM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000300")]
			[Cpp2IlInjected.Address(RVA = "0x72DDE50", Offset = "0x72DD250", VA = "0x1872DDE50")]
			protected void GAMMOOCBILB(ushort OPEDKOMLKHD, ushort AKLNHNJLKBM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000301")]
			[Cpp2IlInjected.Address(RVA = "0x72DE1A0", Offset = "0x72DD5A0", VA = "0x1872DE1A0")]
			protected void LCBMJCGFEMF(ushort OPEDKOMLKHD, ushort AKLNHNJLKBM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000302")]
			[Cpp2IlInjected.Address(RVA = "0x72DE050", Offset = "0x72DD450", VA = "0x1872DE050")]
			protected void IFCPLFNPENG(ushort OPEDKOMLKHD, ushort AKLNHNJLKBM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000303")]
			[Cpp2IlInjected.Address(RVA = "0x72DDE00", Offset = "0x72DD200", VA = "0x1872DDE00")]
			protected void FLNMFPCGLCJ(ushort OPEDKOMLKHD, ushort AKLNHNJLKBM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000304")]
			[Cpp2IlInjected.Address(RVA = "0x72DD8A0", Offset = "0x72DCCA0", VA = "0x1872DD8A0")]
			protected void CAMNKKOEFDP(ushort OPEDKOMLKHD, ushort AKLNHNJLKBM)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000060")]
		public class KNJLNBBJAHG : IDisposable
		{
			[Cpp2IlInjected.Token(Token = "0x400036F")]
			public const int HPKJLGGJEKO = 16;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000370")]
			protected MaterialPropertyBlock POJMKDMPEIN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000371")]
			public Color? DBFOGHLDJED;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000372")]
			public Color? ECJHEDNAHDI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000373")]
			public Color? KKEFJABJJAL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x4000374")]
			public Color NGGONCEKJCA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
			[Cpp2IlInjected.Token(Token = "0x4000375")]
			public Color GKNLPPDHKEM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
			[Cpp2IlInjected.Token(Token = "0x4000376")]
			public Color JHGGCJMNIIB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x4000377")]
			public Texture2D PEMJGFCGPDM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x4000378")]
			public Texture2D OJMNJIKGIAF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x4000379")]
			protected Dictionary<LNEMEGHNMGK, int> EDEDDIPBAKP;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x400037A")]
			protected ELDJGACMLPI[] OLGAPGAFCHK;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x400037B")]
			public Vector4[] HOJBCIMGAAB;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x400037C")]
			public Vector4[] BDBEABPMDEL;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x400037D")]
			public Vector4[] KJIEKGGINDM;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x400037E")]
			public Vector4[] JFGADDKDPFL;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
			[Cpp2IlInjected.Token(Token = "0x400037F")]
			public Vector4[] HFBGOEODNAK;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
			[Cpp2IlInjected.Token(Token = "0x4000380")]
			public Vector4[] JAEKGDEJLIH;

			[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
			[Cpp2IlInjected.Token(Token = "0x4000381")]
			protected List<Texture2D> OPOKJAJLMNK;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
			[Cpp2IlInjected.Token(Token = "0x4000382")]
			protected Vector4[] BNGCKLBFOHA;

			[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
			[Cpp2IlInjected.Token(Token = "0x4000383")]
			protected List<Texture2D> JLAFFJPDHMO;

			[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
			[Cpp2IlInjected.Token(Token = "0x4000384")]
			protected float[] NDBEGEBBMCO;

			[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
			[Cpp2IlInjected.Token(Token = "0x4000385")]
			protected Vector4[] BGPBFAMDCNF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
			[Cpp2IlInjected.Token(Token = "0x4000386")]
			protected float[] GKIAFCDHIHI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
			[Cpp2IlInjected.Token(Token = "0x4000387")]
			public float[] EBGAFMNGHCE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
			[Cpp2IlInjected.Token(Token = "0x4000388")]
			protected List<Texture2D> FEMNFDNOCAA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
			[Cpp2IlInjected.Token(Token = "0x4000389")]
			protected float[] OBHLACGDJEB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
			[Cpp2IlInjected.Token(Token = "0x400038A")]
			protected List<Texture2D> MJPMAEAHEFC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
			[Cpp2IlInjected.Token(Token = "0x400038B")]
			protected Vector4[] IOJLMDDLGIN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
			[Cpp2IlInjected.Token(Token = "0x400038C")]
			protected float[] MNPJFHPKEJM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
			[Cpp2IlInjected.Token(Token = "0x400038D")]
			protected Vector4[] KEILFGELNAJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
			[Cpp2IlInjected.Token(Token = "0x400038E")]
			public float[] NBOOGPMEMPE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
			[Cpp2IlInjected.Token(Token = "0x400038F")]
			public Texture2DArray KPEGGKDEHEC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
			[Cpp2IlInjected.Token(Token = "0x4000390")]
			public Texture2DArray GFPLLCKOODK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
			[Cpp2IlInjected.Token(Token = "0x4000391")]
			public Texture2DArray EGAPGMHFKMF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
			[Cpp2IlInjected.Token(Token = "0x4000392")]
			public Texture2DArray NAPIIOFHDCL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
			[Cpp2IlInjected.Token(Token = "0x4000393")]
			protected bool DBKFKABAANI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x16C")]
			[Cpp2IlInjected.Token(Token = "0x4000394")]
			protected int INGGKPCIDHC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
			[Cpp2IlInjected.Token(Token = "0x4000395")]
			protected Vector2? JBBELKDHKLP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x17C")]
			[Cpp2IlInjected.Token(Token = "0x4000396")]
			protected TextureFormat NGMJABNEGJE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
			[Cpp2IlInjected.Token(Token = "0x4000397")]
			protected Vector2? CADHEHGAHML;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18C")]
			[Cpp2IlInjected.Token(Token = "0x4000398")]
			protected TextureFormat HAIDPOCPDLI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
			[Cpp2IlInjected.Token(Token = "0x4000399")]
			protected Vector2? CKIKGHGFLIC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x19C")]
			[Cpp2IlInjected.Token(Token = "0x400039A")]
			protected TextureFormat NDKEFKCMEDB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
			[Cpp2IlInjected.Token(Token = "0x400039B")]
			protected Vector2? ELNCKGGCOLK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1AC")]
			[Cpp2IlInjected.Token(Token = "0x400039C")]
			protected TextureFormat NCBKONCKIGC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
			[Cpp2IlInjected.Token(Token = "0x400039D")]
			protected bool LIABCKHNDHI;

			[Cpp2IlInjected.Token(Token = "0x400039E")]
			protected static int JBBPANEJIAG;

			[Cpp2IlInjected.Token(Token = "0x400039F")]
			protected static int HJAJBKIFOCD;

			[Cpp2IlInjected.Token(Token = "0x40003A0")]
			protected static int BBCJEOJMLAJ;

			[Cpp2IlInjected.Token(Token = "0x40003A1")]
			protected static int MJGPALFPDEM;

			[Cpp2IlInjected.Token(Token = "0x40003A2")]
			protected static int CGCHFBIFEOG;

			[Cpp2IlInjected.Token(Token = "0x40003A3")]
			protected static int OAAIHKJABCD;

			[Cpp2IlInjected.Token(Token = "0x40003A4")]
			protected static int NMLGBBJNHCH;

			[Cpp2IlInjected.Token(Token = "0x40003A5")]
			protected static int MBFFNHDMPCD;

			[Cpp2IlInjected.Token(Token = "0x40003A6")]
			protected static int GEAGJCFCCAK;

			[Cpp2IlInjected.Token(Token = "0x40003A7")]
			protected static int HNDKJNBCNPP;

			[Cpp2IlInjected.Token(Token = "0x40003A8")]
			protected static int OPEGEMNONGG;

			[Cpp2IlInjected.Token(Token = "0x40003A9")]
			protected static int JLAMHKENNND;

			[Cpp2IlInjected.Token(Token = "0x40003AA")]
			protected static int GAHBGIPKNBC;

			[Cpp2IlInjected.Token(Token = "0x40003AB")]
			protected static int LOEMIFOJCBL;

			[Cpp2IlInjected.Token(Token = "0x40003AC")]
			protected static int PGCKGHEENJP;

			[Cpp2IlInjected.Token(Token = "0x40003AD")]
			protected static int HAPMHMNCHHB;

			[Cpp2IlInjected.Token(Token = "0x40003AE")]
			protected static int EGNOEHCMCKC;

			[Cpp2IlInjected.Token(Token = "0x40003AF")]
			protected static int HLMHFCCNEFI;

			[Cpp2IlInjected.Token(Token = "0x40003B0")]
			protected static int LMLBKGIEJBB;

			[Cpp2IlInjected.Token(Token = "0x40003B1")]
			protected static int KLPBMFFPJAO;

			[Cpp2IlInjected.Token(Token = "0x6000306")]
			[Cpp2IlInjected.Address(RVA = "0x72E24F0", Offset = "0x72E18F0", VA = "0x1872E24F0")]
			protected KNJLNBBJAHG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000307")]
			[Cpp2IlInjected.Address(RVA = "0x72E2460", Offset = "0x72E1860", VA = "0x1872E2460")]
			public KNJLNBBJAHG(Color IEBFENEMEIK, Color LOAJNIGDFIE, Color EAPIHGGHMMD, Color? AINKANFBEBP, Color? IHKBKDHEBPP, Color? LMMBMHGICJK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000308")]
			[Cpp2IlInjected.Address(RVA = "0x72E1F50", Offset = "0x72E1350", VA = "0x1872E1F50")]
			public int OMBEAPDGBME(Material GAOIEHMCMOL, ELDJGACMLPI PIEGLLCHINN, FKJFCNDMIGG IPEPMKFNFHH, OBJHNMCDGDL DBDEIKJCEBF)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000309")]
			[Cpp2IlInjected.Address(RVA = "0x72E2040", Offset = "0x72E1440", VA = "0x1872E2040")]
			public int OMBEAPDGBME(LNEMEGHNMGK LKMGECEEGEE)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600030A")]
			[Cpp2IlInjected.Address(RVA = "0x72E0A10", Offset = "0x72DFE10", VA = "0x1872E0A10")]
			public int DBKADKAPBAC(Material GAOIEHMCMOL, Color KDBCFKGNGJP, Color OJKPDPFPHGP, Color EKKHNINCDDG, Color AJJDBGBBOLB, Color CEJFGPJEHDN, Texture2D PEJBFDIAPAA, Vector4 PHIIPKGLPLE, Texture2D DOJBPMEJOBE, Vector4 IFCCKHDPJEB, float FJNCKBNFJAI, float IGLGBOOJJAK, Texture2D IDDFMOLLGGE, Vector4 BAIJHFDMEEF, float HPGDACJJKHN, Texture2D BOEADKHPNCM, float OBCJIGFDOBJ, Color DDPMLLMDLNO, Vector4 HBDHPJCLBEB, ELDJGACMLPI PIEGLLCHINN, FKJFCNDMIGG IPEPMKFNFHH, OBJHNMCDGDL DBDEIKJCEBF)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600030B")]
			[Cpp2IlInjected.Address(RVA = "0x72E1A90", Offset = "0x72E0E90", VA = "0x1872E1A90")]
			protected void IKMNPHEGCBH([Out] Texture2DArray DHCFOIPLAJB, [Out] Texture2DArray AKKHPCLFJAI, [Out] Texture2DArray CPKNNGHENAK, [Out] Texture2DArray GNGDKHFMOBP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600030C")]
			[Cpp2IlInjected.Address(RVA = "0x72E1CE0", Offset = "0x72E10E0", VA = "0x1872E1CE0")]
			public void MCPMPJFJMIF(PlayerAvatarDisplayBase HEGOBJEGDKO, Renderer EHMEICJAGNO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600030D")]
			[Cpp2IlInjected.Address(RVA = "0x72DFEE0", Offset = "0x72DF2E0", VA = "0x1872DFEE0")]
			protected void ALIOBPFNCIG(PlayerAvatarDisplayBase HEGOBJEGDKO, Renderer EHMEICJAGNO, int EJODJKFNBCN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600030E")]
			[Cpp2IlInjected.Address(RVA = "0x72E18A0", Offset = "0x72E0CA0", VA = "0x1872E18A0")]
			private Color EHOAOMHALFA(Color OIICHJCCJLN, ELDJGACMLPI PIKKFHOHKHL)
			{
				return default(Color);
			}

			[Cpp2IlInjected.Token(Token = "0x600030F")]
			[Cpp2IlInjected.Address(RVA = "0x72E1750", Offset = "0x72E0B50", VA = "0x1872E1750")]
			private Color EFACPGNNAKD(Color AMIJDAKAKKP, ELDJGACMLPI PIKKFHOHKHL)
			{
				return default(Color);
			}

			[Cpp2IlInjected.Token(Token = "0x6000310")]
			[Cpp2IlInjected.Address(RVA = "0x72E1C50", Offset = "0x72E1050", VA = "0x1872E1C50")]
			protected void LFLFHOBPLME()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000311")]
			[Cpp2IlInjected.Address(RVA = "0x72E1710", Offset = "0x72E0B10", VA = "0x1872E1710", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000061")]
		public struct PlayerHandBones
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003B2")]
			public Transform[] LeftHandBones;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003B3")]
			public Transform LeftHandRoot;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003B4")]
			public Transform[] RightHandBones;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003B5")]
			public Transform RightHandRoot;

			[Cpp2IlInjected.Token(Token = "0x6000313")]
			[Cpp2IlInjected.Address(RVA = "0x72EA8D0", Offset = "0x72E9CD0", VA = "0x1872EA8D0")]
			public void JBFLGMNOKGA(OBJHNMCDGDL DBDEIKJCEBF, [Out] Transform JGHOOBNHEJB, [Out] Transform[] BLNGGKCOHMF)
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000062")]
		protected struct BodyPartLODs
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003B6")]
			public Mesh[] LODs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003B7")]
			public bool UseHandBones;
		}

		[Cpp2IlInjected.Token(Token = "0x2000064")]
		[CompilerGenerated]
		private sealed class KEGFCCLEJOJ : IEnumerable<SkinnedMeshRenderer>, IEnumerable, IEnumerator<SkinnedMeshRenderer>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003BF")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003C0")]
			private SkinnedMeshRenderer <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003C1")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003C2")]
			public PlayerAvatarDisplayBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003C3")]
			private SkinnedMeshRenderer[] <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003C4")]
			private int <>7__wrap2;

			[Cpp2IlInjected.Token(Token = "0x17000093")]
			SkinnedMeshRenderer IEnumerator<SkinnedMeshRenderer>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600031F")]
				[Cpp2IlInjected.Address(RVA = "0x94B6B0", Offset = "0x94AAB0", VA = "0x18094B6B0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000094")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000321")]
				[Cpp2IlInjected.Address(RVA = "0x94B6B0", Offset = "0x94AAB0", VA = "0x18094B6B0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600031C")]
			[Cpp2IlInjected.Address(RVA = "0xD230D0", Offset = "0xD224D0", VA = "0x180D230D0")]
			[DebuggerHidden]
			public KEGFCCLEJOJ(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600031D")]
			[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600031E")]
			[Cpp2IlInjected.Address(RVA = "0x72DF7E0", Offset = "0x72DEBE0", VA = "0x1872DF7E0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000320")]
			[Cpp2IlInjected.Address(RVA = "0x72DFA60", Offset = "0x72DEE60", VA = "0x1872DFA60", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000322")]
			[Cpp2IlInjected.Address(RVA = "0x72DF9B0", Offset = "0x72DEDB0", VA = "0x1872DF9B0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<SkinnedMeshRenderer> IEnumerable<SkinnedMeshRenderer>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000323")]
			[Cpp2IlInjected.Address(RVA = "0x72DF9B0", Offset = "0x72DEDB0", VA = "0x1872DF9B0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000065")]
		[CompilerGenerated]
		private sealed class FCDMGLNKNCM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003C5")]
			public PlayerAvatarDisplayBase display;

			[Cpp2IlInjected.Token(Token = "0x6000324")]
			[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
			public FCDMGLNKNCM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000325")]
			[Cpp2IlInjected.Address(RVA = "0x72DC920", Offset = "0x72DBD20", VA = "0x1872DC920")]
			internal bool LKOEBPHGGCO()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000066")]
		[CompilerGenerated]
		private sealed class KJFGLLDBDOA : IEnumerator<FBLKJCIOKGP>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003C6")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003C7")]
			private FBLKJCIOKGP <>2__current;

			[Cpp2IlInjected.Token(Token = "0x17000095")]
			private FBLKJCIOKGP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000329")]
				[Cpp2IlInjected.Address(RVA = "0x94B6B0", Offset = "0x94AAB0", VA = "0x18094B6B0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000096")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600032B")]
				[Cpp2IlInjected.Address(RVA = "0x94B6B0", Offset = "0x94AAB0", VA = "0x18094B6B0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000326")]
			[Cpp2IlInjected.Address(RVA = "0x94B7A0", Offset = "0x94ABA0", VA = "0x18094B7A0")]
			[DebuggerHidden]
			public KJFGLLDBDOA(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000327")]
			[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000328")]
			[Cpp2IlInjected.Address(RVA = "0x72DFAB0", Offset = "0x72DEEB0", VA = "0x1872DFAB0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600032A")]
			[Cpp2IlInjected.Address(RVA = "0x72DFE90", Offset = "0x72DF290", VA = "0x1872DFE90", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000067")]
		[CompilerGenerated]
		private struct PGIMNFDFKOP : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003C8")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003C9")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003CA")]
			public PlayerAvatarDisplayBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003CB")]
			public PHGEAGLPDDM avatarData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003CC")]
			private bool <forceRebuild>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003CD")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600032C")]
			[Cpp2IlInjected.Address(RVA = "0x72E40E0", Offset = "0x72E34E0", VA = "0x1872E40E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600032D")]
			[Cpp2IlInjected.Address(RVA = "0x72E4890", Offset = "0x72E3C90", VA = "0x1872E4890", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000068")]
		[CompilerGenerated]
		private sealed class FGCLCAPIEBE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003CE")]
			public string overrideIdentifier;

			[Cpp2IlInjected.Token(Token = "0x600032E")]
			[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
			public FGCLCAPIEBE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600032F")]
			[Cpp2IlInjected.Address(RVA = "0x72DCA00", Offset = "0x72DBE00", VA = "0x1872DCA00")]
			internal bool PMJJGPMCPGP(DKLBEPIMGOL selection)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000069")]
		[CompilerGenerated]
		private sealed class GJEMNMIEHEI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003CF")]
			public PlayerAvatarDisplayBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003D0")]
			public AvatarItemBodyType avatarItemBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003D1")]
			public Func<NEEPBAPEEOL<Dictionary<string, EBHOPDBMNPK<Texture2D>>>> <>9__2;

			[Cpp2IlInjected.Token(Token = "0x6000330")]
			[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
			public GJEMNMIEHEI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000331")]
			[Cpp2IlInjected.Address(RVA = "0x72DD3C0", Offset = "0x72DC7C0", VA = "0x1872DD3C0")]
			internal (AEIHFJALFJE, NEEPBAPEEOL<Dictionary<string, EBHOPDBMNPK<Texture2D>>>) FNHBAMPONEP(Dictionary<string, LJKKDAKGHIG> avatarItems)
			{
				return default((AEIHFJALFJE, NEEPBAPEEOL<Dictionary<string, EBHOPDBMNPK<Texture2D>>>));
			}

			[Cpp2IlInjected.Token(Token = "0x6000332")]
			[Cpp2IlInjected.Address(RVA = "0x72DD600", Offset = "0x72DCA00", VA = "0x1872DD600")]
			internal NEEPBAPEEOL<Dictionary<string, EBHOPDBMNPK<Texture2D>>> HDJPIMHPMDD()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000333")]
			[Cpp2IlInjected.Address(RVA = "0x72DD5C0", Offset = "0x72DC9C0", VA = "0x1872DD5C0")]
			internal void HAJDKDPHGOG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006A")]
		[CompilerGenerated]
		private sealed class IDGBNDIABLP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003D2")]
			public Transform transformToCheck;

			[Cpp2IlInjected.Token(Token = "0x6000334")]
			[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
			public IDGBNDIABLP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000335")]
			[Cpp2IlInjected.Address(RVA = "0x72DF120", Offset = "0x72DE520", VA = "0x1872DF120")]
			internal bool JOOKCDDJKKP(SkinnedMeshRenderer x)
			{
				return default(bool);
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200006B")]
		[CompilerGenerated]
		private struct DFGCHIGLELG : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003D3")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003D4")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003D5")]
			public PlayerAvatarDisplayBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003D6")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000336")]
			[Cpp2IlInjected.Address(RVA = "0x72DBC60", Offset = "0x72DB060", VA = "0x1872DBC60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000337")]
			[Cpp2IlInjected.Address(RVA = "0x72DBE30", Offset = "0x72DB230", VA = "0x1872DBE30", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		protected static readonly int EENGMNKCIPB;

		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		protected static readonly int DBFMBBCPHAL;

		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		protected static readonly int AJEDMGPCFNL;

		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		protected static readonly int JOECFFLEBJE;

		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		protected static readonly int GBCMFLNPEMM;

		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		protected static readonly int HAFGEAALIDC;

		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		protected static readonly int[] MMPPDPODECL;

		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		protected static readonly int[] DOHBKMNICMB;

		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		protected static readonly int[] GCHBGCIKEDA;

		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		protected static readonly int[] DKPBCEHDAKP;

		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		protected static readonly int[] IODDJNAMABK;

		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		protected static readonly int[] LELFALJLLNF;

		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		protected static List<PlayerAvatarDisplayBase> LFCMPEDEBBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		protected MLFKPMGCMHF LCPEEIIIFPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		protected bool KHFOHCPJDLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D")]
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		protected bool EPFJHEKEEKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		[SerializeField]
		public AvatarBodyShapeVault BodyShapeVault;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		[SerializeField]
		public AvatarFaceShapeVault FaceShapeVault;

		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		protected static readonly int[] HMEMLCPNLNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		[SerializeField]
		protected Material bodyPartMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		protected Dictionary<LNEMEGHNMGK, Material> LLMDMJGLMHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		protected Dictionary<LNEMEGHNMGK, Material> EDOHPICCECH;

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
		protected Material KLPAIIMPKMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		protected AHBNJGDEGOO HHDIOHFFFHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		private ODFMHACHCFM PKJKEKAGLJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		private ODFMHACHCFM CLFKCPDLIKB;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		protected Material IFAHJHJIBEB;

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
		protected FitMeshHemisphere AGNPDMHKOEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		protected bool EMMPNBIAECL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		protected KOIFPCMFICK FCEFAPAPCKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		protected bool CELFBFMLIEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		protected AnchorParamsRestrictions HBMDEFKGEPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		protected bool ELPOACHIOLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		protected Transform JHGKNCGAJBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		protected bool PCBPKJDPPFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x199")]
		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		protected bool KHAFCCBICNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19C")]
		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		protected Vector3 OKFBHKFPILO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		protected Quaternion BNKBCEIFNND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		protected Vector2 ICFJIMJLGKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		protected FitMeshHemisphere GHIJIOECEKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		[ALEFAIIJNEI(KCNGGJNCENB.SelfAndChildren, false, false, false)]
		[SerializeField]
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
		protected Collider[] PPLBIFPAJFH;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		protected Collider[] PBLHPOKEKLE;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		protected HEGIBBBEJHN[] GMLMCDNOIGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		[SerializeField]
		protected Mesh faceMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		public Dictionary<Renderer, KNJLNBBJAHG> currentPropertyBlocks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		protected Dictionary<Renderer, KNJLNBBJAHG> PMLBLGLJEJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		protected ODNKPFEIMKD JHBLIAABOCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x4000300")]
		protected AEIHFJALFJE DFECPEFMFJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
		[Cpp2IlInjected.Token(Token = "0x4000301")]
		public OINJBHOKJEJ DistanceBand;

		[Cpp2IlInjected.FieldOffset(Offset = "0x26C")]
		[Cpp2IlInjected.Token(Token = "0x4000302")]
		protected int HPJIMKEBIGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
		[Cpp2IlInjected.Token(Token = "0x4000303")]
		protected (bool isLodForced, int forcedLOD) DJJOPGFPBHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		protected GJKLJJDNPDD<GGAINOJCJPJ> NCKEEFGIMMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		protected bool FBMHPFAFMCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		protected Dictionary<DKLBEPIMGOL, List<LNEMEGHNMGK>> ALDJPGNOHJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		protected Dictionary<DKLBEPIMGOL, List<LNEMEGHNMGK>> NAPDMGCNNAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
		[Cpp2IlInjected.Token(Token = "0x4000309")]
		protected readonly Dictionary<string, EBHOPDBMNPK<Texture2D>> EAKKDLJOPCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
		[Cpp2IlInjected.Token(Token = "0x400030A")]
		protected readonly Dictionary<string, EBHOPDBMNPK<Texture2D>> KNKAHNBLHBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
		[Cpp2IlInjected.Token(Token = "0x400030B")]
		protected bool PKEDEKCJODK;

		[Cpp2IlInjected.Token(Token = "0x400030D")]
		protected static int FOBNELMHBNG;

		[Cpp2IlInjected.Token(Token = "0x400030E")]
		protected static List<MJOIPLEFGEK> KGKDPLCBKDJ;

		[Cpp2IlInjected.Token(Token = "0x400030F")]
		protected static List<MJOIPLEFGEK> JJFMHDJCKHP;

		[Cpp2IlInjected.Token(Token = "0x4000310")]
		protected static HPLGDNGCOKN ANKJECKPPBO;

		[Cpp2IlInjected.Token(Token = "0x4000311")]
		protected static bool OBACEFNPEEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B8")]
		[Cpp2IlInjected.Token(Token = "0x4000312")]
		protected Color? HBBBAGKEGCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2CC")]
		[Cpp2IlInjected.Token(Token = "0x4000313")]
		protected bool NDEIJGBMGBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D0")]
		[Cpp2IlInjected.Token(Token = "0x4000314")]
		protected Color MDCPKLLCLGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2E0")]
		[Cpp2IlInjected.Token(Token = "0x4000315")]
		protected Color EAIAPJMFKLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2F0")]
		[Cpp2IlInjected.Token(Token = "0x4000316")]
		protected Color BFBIOPJMJHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x300")]
		[Cpp2IlInjected.Token(Token = "0x4000317")]
		protected AvatarHairPattern MNGNHFEBPHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x308")]
		[Cpp2IlInjected.Token(Token = "0x4000318")]
		protected LBKMHAIBEMP JGKCMNOENLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x310")]
		[Cpp2IlInjected.Token(Token = "0x4000319")]
		protected Color JNNKCABDFKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x320")]
		[Cpp2IlInjected.Token(Token = "0x400031A")]
		protected Color LGJNGKFIDGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x330")]
		[Cpp2IlInjected.Token(Token = "0x400031B")]
		protected AvatarHairPattern HDPDGCIMGLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x338")]
		[Cpp2IlInjected.Token(Token = "0x400031C")]
		protected LBKMHAIBEMP ENFACHIIAOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x340")]
		[Cpp2IlInjected.Token(Token = "0x400031D")]
		protected LBKMHAIBEMP FGFKBLPLAIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x348")]
		[Cpp2IlInjected.Token(Token = "0x400031E")]
		protected Color AAOAAOIMDNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x358")]
		[Cpp2IlInjected.Token(Token = "0x400031F")]
		private AdditionalFeetData MINMJKBNHDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x360")]
		[Cpp2IlInjected.Token(Token = "0x4000320")]
		protected DKLBEPIMGOL? GCMKDMLPHNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x378")]
		[Cpp2IlInjected.Token(Token = "0x4000321")]
		protected Texture JKJNMFGIDKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x380")]
		[Cpp2IlInjected.Token(Token = "0x4000322")]
		protected Color OFHKFHNNOEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x390")]
		[Cpp2IlInjected.Token(Token = "0x4000323")]
		protected readonly IList<DKLBEPIMGOL> FNGNAHPKIHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x398")]
		[Cpp2IlInjected.Token(Token = "0x4000324")]
		protected readonly IList<DKLBEPIMGOL> ALONNONBDKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A0")]
		[Cpp2IlInjected.Token(Token = "0x4000325")]
		private AvatarItemBodyType GHGKJMFKKGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3A8")]
		[Cpp2IlInjected.Token(Token = "0x4000326")]
		[SerializeField]
		protected AvatarFaceShape _currentFaceShape;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3B0")]
		[Cpp2IlInjected.Token(Token = "0x4000327")]
		[SerializeField]
		protected AvatarBodyShape _currentBodyShape;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3B8")]
		[Cpp2IlInjected.Token(Token = "0x4000328")]
		[SerializeField]
		protected EHLDDELHBFB _currentNoseType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3BC")]
		[Cpp2IlInjected.Token(Token = "0x4000329")]
		[SerializeField]
		protected bool _hideEars;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3BD")]
		[Cpp2IlInjected.Token(Token = "0x400032A")]
		protected BKKKDFDJABB CJLPKDANKGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C0")]
		[Cpp2IlInjected.Token(Token = "0x400032B")]
		protected int[] ICOIDHHEILP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C8")]
		[Cpp2IlInjected.Token(Token = "0x400032C")]
		protected bool GFEFHPNLECK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D0")]
		[Cpp2IlInjected.Token(Token = "0x400032D")]
		protected int[] IMMKFBHAGAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3D8")]
		[Cpp2IlInjected.Token(Token = "0x400032E")]
		protected bool PPPBJHOPPJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3E0")]
		[Cpp2IlInjected.Token(Token = "0x400032F")]
		protected IKKEFGFKHCN PKLGHJOCJJJ;

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public string MKIPMCLEPNK
		{
			[Cpp2IlInjected.Token(Token = "0x6000211")]
			[Cpp2IlInjected.Address(RVA = "0x94B800", Offset = "0x94AC00", VA = "0x18094B800")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000212")]
			[Cpp2IlInjected.Address(RVA = "0x94BA00", Offset = "0x94AE00", VA = "0x18094BA00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public bool BIJDDCNCAGO
		{
			[Cpp2IlInjected.Token(Token = "0x6000214")]
			[Cpp2IlInjected.Address(RVA = "0xAA6A10", Offset = "0xAA5E10", VA = "0x180AA6A10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000215")]
			[Cpp2IlInjected.Address(RVA = "0xBA0880", Offset = "0xB9FC80", VA = "0x180BA0880")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public virtual bool GHJLMJIOCHO
		{
			[Cpp2IlInjected.Token(Token = "0x6000216")]
			[Cpp2IlInjected.Address(RVA = "0x993CC0", Offset = "0x9930C0", VA = "0x180993CC0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public bool AFHCNNBELPG
		{
			[Cpp2IlInjected.Token(Token = "0x6000217")]
			[Cpp2IlInjected.Address(RVA = "0x72DA5C0", Offset = "0x72D99C0", VA = "0x1872DA5C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public virtual bool GFOONPMPDLI
		{
			[Cpp2IlInjected.Token(Token = "0x6000218")]
			[Cpp2IlInjected.Address(RVA = "0x993CC0", Offset = "0x9930C0", VA = "0x180993CC0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public virtual bool PHGHEPMAOMN
		{
			[Cpp2IlInjected.Token(Token = "0x6000219")]
			[Cpp2IlInjected.Address(RVA = "0x965500", Offset = "0x964900", VA = "0x180965500", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public virtual bool KNEHHDCHNJN
		{
			[Cpp2IlInjected.Token(Token = "0x600021A")]
			[Cpp2IlInjected.Address(RVA = "0x993CC0", Offset = "0x9930C0", VA = "0x180993CC0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public AHBNJGDEGOO LMEODEAOMEN
		{
			[Cpp2IlInjected.Token(Token = "0x600021C")]
			[Cpp2IlInjected.Address(RVA = "0x9BB8D0", Offset = "0x9BACD0", VA = "0x1809BB8D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600021D")]
			[Cpp2IlInjected.Address(RVA = "0x72DABC0", Offset = "0x72D9FC0", VA = "0x1872DABC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public ODFMHACHCFM DIHHKCLABAM
		{
			[Cpp2IlInjected.Token(Token = "0x600021E")]
			[Cpp2IlInjected.Address(RVA = "0x9B9F30", Offset = "0x9B9330", VA = "0x1809B9F30")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600021F")]
			[Cpp2IlInjected.Address(RVA = "0x72DAFC0", Offset = "0x72DA3C0", VA = "0x1872DAFC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public ODFMHACHCFM NKCLBCHHOOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000220")]
			[Cpp2IlInjected.Address(RVA = "0x9BA830", Offset = "0x9B9C30", VA = "0x1809BA830")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000221")]
			[Cpp2IlInjected.Address(RVA = "0x72DB290", Offset = "0x72DA690", VA = "0x1872DB290")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		protected Material ICLFDEAAPPN
		{
			[Cpp2IlInjected.Token(Token = "0x6000222")]
			[Cpp2IlInjected.Address(RVA = "0x72D0530", Offset = "0x72CF930", VA = "0x1872D0530")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		protected Material PNFKECHGNEL
		{
			[Cpp2IlInjected.Token(Token = "0x6000223")]
			[Cpp2IlInjected.Address(RVA = "0x72D3A00", Offset = "0x72D2E00", VA = "0x1872D3A00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public bool CNNEOJNPHOE
		{
			[Cpp2IlInjected.Token(Token = "0x6000224")]
			[Cpp2IlInjected.Address(RVA = "0x1C1E860", Offset = "0x1C1DC60", VA = "0x181C1E860")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public PlayerFacialAnimatorBase IKKFFJALPEB
		{
			[Cpp2IlInjected.Token(Token = "0x6000228")]
			[Cpp2IlInjected.Address(RVA = "0xC48710", Offset = "0xC47B10", VA = "0x180C48710")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public HEGIBBBEJHN[] GNIEKCGFAEO
		{
			[Cpp2IlInjected.Token(Token = "0x6000229")]
			[Cpp2IlInjected.Address(RVA = "0x72DA180", Offset = "0x72D9580", VA = "0x1872DA180")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public HEGIBBBEJHN PEFMKDMKOCB
		{
			[Cpp2IlInjected.Token(Token = "0x600022A")]
			[Cpp2IlInjected.Address(RVA = "0x72DA7D0", Offset = "0x72D9BD0", VA = "0x1872DA7D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public HEGIBBBEJHN CGHDLOOBEPC
		{
			[Cpp2IlInjected.Token(Token = "0x600022B")]
			[Cpp2IlInjected.Address(RVA = "0x72DA800", Offset = "0x72D9C00", VA = "0x1872DA800")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public Mesh IACIMEKIMKE
		{
			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0xA151F0", Offset = "0xA145F0", VA = "0x180A151F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		protected ODNKPFEIMKD EIPFKLNLHNE
		{
			[Cpp2IlInjected.Token(Token = "0x600022D")]
			[Cpp2IlInjected.Address(RVA = "0x72D42A0", Offset = "0x72D36A0", VA = "0x1872D42A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		protected AEIHFJALFJE JDBNIPDFEHO
		{
			[Cpp2IlInjected.Token(Token = "0x600022E")]
			[Cpp2IlInjected.Address(RVA = "0xC48640", Offset = "0xC47A40", VA = "0x180C48640")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600022F")]
			[Cpp2IlInjected.Address(RVA = "0x72D48C0", Offset = "0x72D3CC0", VA = "0x1872D48C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		protected bool KNAMMMJKBJE
		{
			[Cpp2IlInjected.Token(Token = "0x6000230")]
			[Cpp2IlInjected.Address(RVA = "0x965500", Offset = "0x964900", VA = "0x180965500")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public bool OLIDFCMCDJE
		{
			[Cpp2IlInjected.Token(Token = "0x6000231")]
			[Cpp2IlInjected.Address(RVA = "0x72DA7C0", Offset = "0x72D9BC0", VA = "0x1872DA7C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public int DMLAADHPPMO
		{
			[Cpp2IlInjected.Token(Token = "0x6000232")]
			[Cpp2IlInjected.Address(RVA = "0x1F7DD40", Offset = "0x1F7D140", VA = "0x181F7DD40")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000233")]
			[Cpp2IlInjected.Address(RVA = "0x72DB1D0", Offset = "0x72DA5D0", VA = "0x1872DB1D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public int HEEHNPCCAID
		{
			[Cpp2IlInjected.Token(Token = "0x6000234")]
			[Cpp2IlInjected.Address(RVA = "0x72DAF10", Offset = "0x72DA310", VA = "0x1872DAF10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		protected virtual bool BOPMHFGJLMK
		{
			[Cpp2IlInjected.Token(Token = "0x6000235")]
			[Cpp2IlInjected.Address(RVA = "0x993CC0", Offset = "0x9930C0", VA = "0x180993CC0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		protected virtual int[] EPCDBJMNNKB
		{
			[Cpp2IlInjected.Token(Token = "0x6000236")]
			[Cpp2IlInjected.Address(RVA = "0x72D2070", Offset = "0x72D1470", VA = "0x1872D2070", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		protected bool MAFFHLMNBPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000238")]
			[Cpp2IlInjected.Address(RVA = "0x72D50E0", Offset = "0x72D44E0", VA = "0x1872D50E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		protected static bool OGFKAKDJLFF
		{
			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0x993CC0", Offset = "0x9930C0", VA = "0x180993CC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public bool MLAMHGNHHOO
		{
			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0x72DA830", Offset = "0x72D9C30", VA = "0x1872DA830")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600023B")]
			[Cpp2IlInjected.Address(RVA = "0x72DB4B0", Offset = "0x72DA8B0", VA = "0x1872DB4B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public IEnumerable<SkinnedMeshRenderer> PGEENBIKCFM
		{
			[Cpp2IlInjected.Token(Token = "0x600023C")]
			[Cpp2IlInjected.Address(RVA = "0x72DA060", Offset = "0x72D9460", VA = "0x1872DA060")]
			[IteratorStateMachine(typeof(KEGFCCLEJOJ))]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public bool KFMLNKJFEGL
		{
			[Cpp2IlInjected.Token(Token = "0x600023D")]
			[Cpp2IlInjected.Address(RVA = "0x72DA7B0", Offset = "0x72D9BB0", VA = "0x1872DA7B0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600023E")]
			[Cpp2IlInjected.Address(RVA = "0x72D0A00", Offset = "0x72CFE00", VA = "0x1872D0A00")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public PKOOKMMPLDP CBKHCHACMEJ
		{
			[Cpp2IlInjected.Token(Token = "0x600023F")]
			[Cpp2IlInjected.Address(RVA = "0x72DA0E0", Offset = "0x72D94E0", VA = "0x1872DA0E0")]
			get
			{
				return default(PKOOKMMPLDP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public static bool KLKFMDFKAEJ
		{
			[Cpp2IlInjected.Token(Token = "0x600025D")]
			[Cpp2IlInjected.Address(RVA = "0x72DA530", Offset = "0x72D9930", VA = "0x1872DA530")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		protected static HPLGDNGCOKN AGNJOELKFFM
		{
			[Cpp2IlInjected.Token(Token = "0x600025E")]
			[Cpp2IlInjected.Address(RVA = "0x72D5C40", Offset = "0x72D5040", VA = "0x1872D5C40")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600025F")]
			[Cpp2IlInjected.Address(RVA = "0x72CE010", Offset = "0x72CD410", VA = "0x1872CE010")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		protected Color ECJHEDNAHDI
		{
			[Cpp2IlInjected.Token(Token = "0x6000277")]
			[Cpp2IlInjected.Address(RVA = "0x72D5BF0", Offset = "0x72D4FF0", VA = "0x1872D5BF0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		protected Color KKEFJABJJAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000278")]
			[Cpp2IlInjected.Address(RVA = "0x72D32A0", Offset = "0x72D26A0", VA = "0x1872D32A0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		protected Texture2D KGAIHADCCCK
		{
			[Cpp2IlInjected.Token(Token = "0x6000279")]
			[Cpp2IlInjected.Address(RVA = "0x72CDD70", Offset = "0x72CD170", VA = "0x1872CDD70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		protected Color NGGONCEKJCA
		{
			[Cpp2IlInjected.Token(Token = "0x600027F")]
			[Cpp2IlInjected.Address(RVA = "0x72D47E0", Offset = "0x72D3BE0", VA = "0x1872D47E0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		protected Color GKNLPPDHKEM
		{
			[Cpp2IlInjected.Token(Token = "0x6000280")]
			[Cpp2IlInjected.Address(RVA = "0x72CEC30", Offset = "0x72CE030", VA = "0x1872CEC30")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public LBKMHAIBEMP EINLPAIDPLC
		{
			[Cpp2IlInjected.Token(Token = "0x6000281")]
			[Cpp2IlInjected.Address(RVA = "0x72DA140", Offset = "0x72D9540", VA = "0x1872DA140")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		protected Texture2D CBNMELCECPI
		{
			[Cpp2IlInjected.Token(Token = "0x6000282")]
			[Cpp2IlInjected.Address(RVA = "0x72D5930", Offset = "0x72D4D30", VA = "0x1872D5930")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		public float FFOICMBMFFB
		{
			[Cpp2IlInjected.Token(Token = "0x6000289")]
			[Cpp2IlInjected.Address(RVA = "0x72DA160", Offset = "0x72D9560", VA = "0x1872DA160")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		public float NNLEPEFBAEO
		{
			[Cpp2IlInjected.Token(Token = "0x600028A")]
			[Cpp2IlInjected.Address(RVA = "0x72DA5A0", Offset = "0x72D99A0", VA = "0x1872DA5A0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		public bool EDHJJAAPPEI
		{
			[Cpp2IlInjected.Token(Token = "0x60002B8")]
			[Cpp2IlInjected.Address(RVA = "0x115CB00", Offset = "0x115BF00", VA = "0x18115CB00")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002B9")]
			[Cpp2IlInjected.Address(RVA = "0x72DA9A0", Offset = "0x72D9DA0", VA = "0x1872DA9A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action DMIIGPCLCJE
		{
			[Cpp2IlInjected.Token(Token = "0x600020F")]
			[Cpp2IlInjected.Address(RVA = "0x72D9F00", Offset = "0x72D9300", VA = "0x1872D9F00")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(RVA = "0x72DA840", Offset = "0x72D9C40", VA = "0x1872DA840")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action<ALIFPIFLCBK, BKMINCPGJKF> GLONJACJJGN
		{
			[Cpp2IlInjected.Token(Token = "0x6000252")]
			[Cpp2IlInjected.Address(RVA = "0x72D9FA0", Offset = "0x72D93A0", VA = "0x1872D9FA0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000253")]
			[Cpp2IlInjected.Address(RVA = "0x72DA8E0", Offset = "0x72D9CE0", VA = "0x1872DA8E0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x72D6D60", Offset = "0x72D6160", VA = "0x1872D6D60")]
		public bool SetDeformation(bool KHFOHCPJDLH, bool EPFJHEKEEKH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x72D29A0", Offset = "0x72D1DA0", VA = "0x1872D29A0")]
		protected static Material FNBMMPFEOGN(Dictionary<LNEMEGHNMGK, Material> FMPOBMMKKCL, Material EAOFNOHCOIK, ELDJGACMLPI PIEGLLCHINN, FKJFCNDMIGG IPEPMKFNFHH, OBJHNMCDGDL DBDEIKJCEBF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x72D25A0", Offset = "0x72D19A0", VA = "0x1872D25A0")]
		protected void FJNBIIPIADI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x72CDAD0", Offset = "0x72CCED0", VA = "0x1872CDAD0")]
		protected bool AEPHKEKAMPK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x72D3530", Offset = "0x72D2930", VA = "0x1872D3530")]
		protected void ICMNMJNLBIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x72D4960", Offset = "0x72D3D60", VA = "0x1872D4960", Slot = "10")]
		protected virtual void LPBEFJCMGJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x72D4E80", Offset = "0x72D4280", VA = "0x1872D4E80")]
		public int MeshesAtLODCount(int OOKKGNGNINK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x72D3FC0", Offset = "0x72D33C0", VA = "0x1872D3FC0")]
		protected static void KGKDIECJCLK(Dictionary<DKLBEPIMGOL, List<LNEMEGHNMGK>> JAGFBALGAPL, OGMDKFDFBIB GCHFPPMPGNO, Material EAOFNOHCOIK, ELDJGACMLPI PIKKFHOHKHL, FKJFCNDMIGG CJLDBFGOACG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x72CEAA0", Offset = "0x72CDEA0", VA = "0x1872CEAA0")]
		protected void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x72D4310", Offset = "0x72D3710", VA = "0x1872D4310")]
		protected void KPHFFEGGHFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x72D56F0", Offset = "0x72D4AF0", VA = "0x1872D56F0")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "11")]
		protected virtual void OMJNJIDJPGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x72D3B90", Offset = "0x72D2F90", VA = "0x1872D3B90")]
		protected static void JJCKJLADAIN(List<Material> CFAAEHNEANO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x72D3040", Offset = "0x72D2440", VA = "0x1872D3040")]
		protected static void GLEFBGGLDOE(Dictionary<LNEMEGHNMGK, Material> FMPOBMMKKCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x72D4C60", Offset = "0x72D4060", VA = "0x1872D4C60")]
		protected static void MJJBIKBIJAJ(Dictionary<Renderer, KNJLNBBJAHG> GEMDCFELCIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x72D26C0", Offset = "0x72D1AC0", VA = "0x1872D26C0")]
		protected void FKCLIPAIKLH(SkinnedMeshRenderer[] LGCGHBBEHDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x72D3F20", Offset = "0x72D3320", VA = "0x1872D3F20")]
		protected void KFIADIGLLCL(SkinnedMeshRenderer BNBIMMBDEGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x72D3E50", Offset = "0x72D3250", VA = "0x1872D3E50")]
		protected void KFIADIGLLCL(MeshRenderer AADKLBCKCDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x72CEEB0", Offset = "0x72CE2B0", VA = "0x1872CEEB0")]
		protected void BHFKGFPBMHJ(List<BELJNJGLPJA> MNMNOHFPEEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x72D0770", Offset = "0x72CFB70", VA = "0x1872D0770")]
		protected void CAIEKJGOFML(Dictionary<string, EBHOPDBMNPK<Texture2D>> JAGFBALGAPL, bool EFJOBKAGFFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x72D1130", Offset = "0x72D0530", VA = "0x1872D1130")]
		protected void DANIGJMLNHN(Dictionary<DKLBEPIMGOL, List<LNEMEGHNMGK>> JAGFBALGAPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x72D31A0", Offset = "0x72D25A0", VA = "0x1872D31A0")]
		public float GetHandOpenClosedAxis(ALIFPIFLCBK PHOLKKAAHFB)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x72D7600", Offset = "0x72D6A00", VA = "0x1872D7600")]
		public void SetHandOpenClosedAxis(ALIFPIFLCBK PHOLKKAAHFB, float OGFACIKBBAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x72D31E0", Offset = "0x72D25E0", VA = "0x1872D31E0")]
		public BKMINCPGJKF GetHandVisualState(ALIFPIFLCBK PHOLKKAAHFB)
		{
			return default(BKMINCPGJKF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x72CE1E0", Offset = "0x72CD5E0", VA = "0x1872CE1E0")]
		public bool AddHandVisualStateToken(ALIFPIFLCBK PHOLKKAAHFB, BKMINCPGJKF OJIBKECALBM, object LAAJFAFNFCN, HEGIBBBEJHN.CLFGADHCMLH DKBNIPNLNJH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x72D8E10", Offset = "0x72D8210", VA = "0x1872D8E10")]
		public void SetWatchHand(ALIFPIFLCBK PHOLKKAAHFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x72D8ED0", Offset = "0x72D82D0", VA = "0x1872D8ED0")]
		public void SetWatchHands(bool HMBIFHBADHN, bool OIBIBKAIBBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x72D6420", Offset = "0x72D5820", VA = "0x1872D6420")]
		public bool RemoveHandVisualStateToken(ALIFPIFLCBK PHOLKKAAHFB, object LAAJFAFNFCN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x72D3260", Offset = "0x72D2660", VA = "0x1872D3260")]
		public bool GetThumbsUpActive(ALIFPIFLCBK PHOLKKAAHFB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x72D88B0", Offset = "0x72D7CB0", VA = "0x1872D88B0")]
		public void SetThumbsUpActive(ALIFPIFLCBK PHOLKKAAHFB, bool LGBGBEDLGBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x72D3220", Offset = "0x72D2620", VA = "0x1872D3220")]
		public bool GetHandshakeActive(ALIFPIFLCBK PHOLKKAAHFB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x72D7650", Offset = "0x72D6A50", VA = "0x1872D7650")]
		public void SetHandshakeActive(ALIFPIFLCBK PHOLKKAAHFB, bool JCIGOMMGHAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x72D2C10", Offset = "0x72D2010", VA = "0x1872D2C10")]
		public void ForceUpdateHandsVisualState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x72D1010", Offset = "0x72D0410", VA = "0x1872D1010")]
		public static void ClearQueuedBuilds()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x72D08F0", Offset = "0x72CFCF0", VA = "0x1872D08F0")]
		protected static void CGHMDGGCEFB(PlayerAvatarDisplayBase NLNHILLAAMF, List<MJOIPLEFGEK> JIKCGAPMJJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x72D6140", Offset = "0x72D5540", VA = "0x1872D6140")]
		public void Rebuild(bool FODJBNONHDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x72D5090", Offset = "0x72D4490", VA = "0x1872D5090")]
		protected void NGEDDFMLLCJ(bool FODJBNONHDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x72D4F40", Offset = "0x72D4340", VA = "0x1872D4F40", Slot = "12")]
		protected virtual HJOKANJAKGB NGEDDFMLLCJ(IList<DKLBEPIMGOL> BPMBLMHNOME, AvatarItemBodyType BLKBJOMPGJP, bool IEOMHDBLFBH, int[] KJEOHKIHMLH, bool FODJBNONHDP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x72D1830", Offset = "0x72D0C30", VA = "0x1872D1830")]
		protected static HJOKANJAKGB EFODKCHDFOH(MJOIPLEFGEK GANIPEBACIC, List<MJOIPLEFGEK> JIKCGAPMJJP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x72D4BA0", Offset = "0x72D3FA0", VA = "0x1872D4BA0")]
		[IteratorStateMachine(typeof(KJFGLLDBDOA))]
		protected static IEnumerator<FBLKJCIOKGP> MGBLCJFHGAM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x72D4DC0", Offset = "0x72D41C0", VA = "0x1872D4DC0")]
		protected static MJOIPLEFGEK MMIBKMADJJC(List<MJOIPLEFGEK> JIKCGAPMJJP)
		{
			return default(MJOIPLEFGEK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x72D6E70", Offset = "0x72D6270", VA = "0x1872D6E70")]
		[AsyncStateMachine(typeof(PGIMNFDFKOP))]
		public Task SetFaceCustomizationSettings(PHGEAGLPDDM ALBFPGNJIFO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x72D3920", Offset = "0x72D2D20", VA = "0x1872D3920")]
		public void InitializeFaceFeatures(AvatarConfiguration BFMGDLDGOKJ, PKOOKMMPLDP HMKELMICGGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x72D8600", Offset = "0x72D7A00", VA = "0x1872D8600")]
		public void SetTeamColors(Color? LMMBMHGICJK, bool HLFKDFPEEPH, Color IDFEHJNHPEM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x10A4700", Offset = "0x10A3B00", VA = "0x1810A4700")]
		private static void GACHLMJBBBN(Material HJCEHLILOIG, Color KBGCCIOIGBD, params int[] NFHNBPEAEMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x10A5A40", Offset = "0x10A4E40", VA = "0x1810A5A40")]
		private static void OEEIOGMPIJG(Material HJCEHLILOIG, Texture KBGCCIOIGBD, params int[] NFHNBPEAEMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x72D2C60", Offset = "0x72D2060", VA = "0x1872D2C60")]
		protected void GFFKCEINPGG(Material PFHJOFPFGCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x72D49C0", Offset = "0x72D3DC0", VA = "0x1872D49C0")]
		protected void LPOKHIGGAFD(Material PFHJOFPFGCD, Color MHFFAABGINO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x72CEC80", Offset = "0x72CE080", VA = "0x1872CEC80")]
		protected void BHDHMDFKPKI(Material PFHJOFPFGCD, Color MHFFAABGINO, Color OCMCDEJGILI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000270")]
		[Cpp2IlInjected.Address(RVA = "0x72D1E50", Offset = "0x72D1250", VA = "0x1872D1E50")]
		protected void EGHFCEGEMFF(Material PFHJOFPFGCD, Texture2D IHOMIJNFMIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000271")]
		[Cpp2IlInjected.Address(RVA = "0x72D46D0", Offset = "0x72D3AD0", VA = "0x1872D46D0")]
		protected void LDBPDDIDAKN(Material PFHJOFPFGCD, Texture NCEMIDDEIKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0x72CDE60", Offset = "0x72CD260", VA = "0x1872CDE60")]
		protected void AGKEIJHGJBH(Action<KNJLNBBJAHG> EGIANMPBNKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x72D51E0", Offset = "0x72D45E0", VA = "0x1872D51E0")]
		protected void OEIPAJKFPDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x72D27E0", Offset = "0x72D1BE0", VA = "0x1872D27E0")]
		protected void FKJKJIHKKKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x72D5DE0", Offset = "0x72D51E0", VA = "0x1872D5DE0")]
		protected void PMMHFCAJJJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x72CE530", Offset = "0x72CD930", VA = "0x1872CE530")]
		public void ApplyUgcItemOverrides()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x72D67E0", Offset = "0x72D5BE0", VA = "0x1872D67E0")]
		public void SetBeardPrimaryColor([Optional] Color? HJAEBGNBNJK, bool AGDIGGIAMFA = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x72D6A00", Offset = "0x72D5E00", VA = "0x1872D6A00")]
		public void SetBeardSecondaryColor([Optional] Color? HJAEBGNBNJK, bool AGDIGGIAMFA = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x72D66A0", Offset = "0x72D5AA0", VA = "0x1872D66A0")]
		public void SetBeardPattern([Optional] AvatarHairPattern EHGMFMGLMKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x72CD960", Offset = "0x72CCD60", VA = "0x1872CD960")]
		private void ABFBMPOPFAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(RVA = "0x72D32F0", Offset = "0x72D26F0", VA = "0x1872D32F0")]
		private bool HLJIHMLMLKA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x72D71E0", Offset = "0x72D65E0", VA = "0x1872D71E0")]
		public void SetHairPrimaryColor([Optional] Color? LGOBFMBCGCB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x72D73F0", Offset = "0x72D67F0", VA = "0x1872D73F0")]
		public void SetHairSecondaryColor([Optional] Color? LGOBFMBCGCB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x72D70B0", Offset = "0x72D64B0", VA = "0x1872D70B0")]
		public void SetHairPattern([Optional] AvatarHairPattern EHGMFMGLMKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x72D62C0", Offset = "0x72D56C0", VA = "0x1872D62C0")]
		public void RefreshHair()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x72D4AE0", Offset = "0x72D3EE0", VA = "0x1872D4AE0")]
		private bool MFOIJFPIBNO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x72D8440", Offset = "0x72D7840", VA = "0x1872D8440")]
		public void SetSkinColor(Color IEBFENEMEIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x72D8900", Offset = "0x72D7D00", VA = "0x1872D8900")]
		public void SetUgcItemVisualOverrides(DKLBEPIMGOL JKFGJFHCKPG, PKOOKMMPLDP HMKELMICGGI, Texture EMFNIBFKLLM, Color JKCDHFCOFMM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x72D10E0", Offset = "0x72D04E0", VA = "0x1872D10E0")]
		public void ClearUgcItemVisualOverrides()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x72D6F70", Offset = "0x72D6370", VA = "0x1872D6F70")]
		public bool SetFaceShape(AvatarFaceShape NGODEJMKEBN, bool KPBEAEKPEMK = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x72D6C20", Offset = "0x72D6020", VA = "0x1872D6C20")]
		public bool SetBodyShape(AvatarBodyShape LJFANJBKMBL, bool KPBEAEKPEMK = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x72D82D0", Offset = "0x72D76D0", VA = "0x1872D82D0")]
		public bool SetNoseType(EHLDDELHBFB DIKOIBEAEJB, bool KPBEAEKPEMK = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x72D9030", Offset = "0x72D8430", VA = "0x1872D9030")]
		public bool UpdateFaceAndBodyShapes()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x72D82B0", Offset = "0x72D76B0", VA = "0x1872D82B0")]
		public bool SetHideEars(bool LFAHIFJFEJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x72D82A0", Offset = "0x72D76A0", VA = "0x1872D82A0")]
		public bool SetHelmetHair(MLFKPMGCMHF EAMLADKEKOI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x72D7CF0", Offset = "0x72D70F0", VA = "0x1872D7CF0")]
		public void SetHatAnchorParameters(KOIFPCMFICK OHNHANMMLDL, bool FAGLCHKMIHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x72D8FA0", Offset = "0x72D83A0", VA = "0x1872D8FA0")]
		public void SetupDisplayLODs(BKKKDFDJABB MFGNEKGKMHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x72D5A30", Offset = "0x72D4E30", VA = "0x1872D5A30")]
		protected int[] PCOBANKJNPD(BKKKDFDJABB MFGNEKGKMHE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x72D8400", Offset = "0x72D7800", VA = "0x1872D8400")]
		public void SetOutfitSelections(IList<DKLBEPIMGOL> BPMBLMHNOME, AvatarItemBodyType BLKBJOMPGJP, bool FODJBNONHDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x72D8370", Offset = "0x72D7770", VA = "0x1872D8370")]
		public void SetOutfitSelections(IList<DKLBEPIMGOL> BPMBLMHNOME, AvatarItemBodyType BLKBJOMPGJP, bool IEOMHDBLFBH, bool FODJBNONHDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x72D83B0", Offset = "0x72D77B0", VA = "0x1872D83B0")]
		public HJOKANJAKGB SetOutfitSelections(IList<DKLBEPIMGOL> BPMBLMHNOME, AvatarItemBodyType BLKBJOMPGJP, BKKKDFDJABB MFGNEKGKMHE, bool IEOMHDBLFBH, bool KPBEAEKPEMK = false, bool FODJBNONHDP = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x72D1400", Offset = "0x72D0800", VA = "0x1872D1400", Slot = "13")]
		protected virtual HJOKANJAKGB DIPPIEKDJDM(IList<DKLBEPIMGOL> BPMBLMHNOME, AvatarItemBodyType BLKBJOMPGJP, bool IEOMHDBLFBH, BKKKDFDJABB MFGNEKGKMHE, bool KPBEAEKPEMK, bool FODJBNONHDP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x72D33A0", Offset = "0x72D27A0", VA = "0x1872D33A0")]
		protected int[] HONFGHFAPDM(BKKKDFDJABB MFGNEKGKMHE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x94AA70", Offset = "0x949E70", VA = "0x18094AA70", Slot = "14")]
		protected virtual AEIHFJALFJE EDNGGAPCMBB(AvatarItemBodyType KJBFEELDPAB, Dictionary<string, LJKKDAKGHIG> KAPNBAIJLON, Dictionary<string, EBHOPDBMNPK<Texture2D>> MENIIIJDJEG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x72D5420", Offset = "0x72D4820", VA = "0x1872D5420", Slot = "15")]
		protected virtual HJOKANJAKGB OJGIPBAICDE(IList<DKLBEPIMGOL> BPMBLMHNOME, AvatarItemBodyType BLKBJOMPGJP, bool IEOMHDBLFBH, int[] MOFBLKNOEOE, IIFAJIGINPD ANIFCCOAEDH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x72D00B0", Offset = "0x72CF4B0", VA = "0x1872D00B0", Slot = "16")]
		protected virtual LJKKDAKGHIG BMPOGOIJGLF(LBKMHAIBEMP HBNIICBFICF, AvatarItemBodyType KJBFEELDPAB, OBJHNMCDGDL DBDEIKJCEBF, LJKKDAKGHIG KHODDMLOMPP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x94AA70", Offset = "0x949E70", VA = "0x18094AA70", Slot = "17")]
		protected virtual LJKKDAKGHIG HOLKKBAMALH(AvatarItemBodyType KJBFEELDPAB, OBJHNMCDGDL DBDEIKJCEBF, AONNKEALKEA KPHLIDJMEFA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x72D5160", Offset = "0x72D4560", VA = "0x1872D5160")]
		protected void NPMOACPKFGN(HNNBNAMEAIG IKFNLEDAJJD, KBAIGJMAONF.FALICHFPADL CBLJOJGPCHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x72CDCF0", Offset = "0x72CD0F0", VA = "0x1872CDCF0")]
		protected void AGAINFEELAH(HNNBNAMEAIG IKFNLEDAJJD, KBAIGJMAONF.FALICHFPADL CBLJOJGPCHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0xCBABF0", Offset = "0xCB9FF0", VA = "0x180CBABF0", Slot = "18")]
		protected virtual HNNBNAMEAIG IIICKCFHEAO(HNNBNAMEAIG IKFNLEDAJJD, HelmetHairStyle JHGKHIPKPEO, bool AKJEDGEFLEH, AvatarItemBodyType BLKBJOMPGJP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x72CF090", Offset = "0x72CE490", VA = "0x1872CF090")]
		protected HNNBNAMEAIG BJHMHEKGOJJ(IList<DKLBEPIMGOL> BPMBLMHNOME, AvatarItemBodyType OFEJGACFKNP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0x72D0EF0", Offset = "0x72D02F0", VA = "0x1872D0EF0")]
		public void CleanupDisplayResources()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x72D3CD0", Offset = "0x72D30D0", VA = "0x1872D3CD0")]
		protected void KCABLCPBMLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x72D21A0", Offset = "0x72D15A0", VA = "0x1872D21A0")]
		protected void FBOAEMGGFOH(Transform ODFJLPNINFC, IEnumerable<SkinnedMeshRenderer> FGAGLOGNLAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x72D3850", Offset = "0x72D2C50", VA = "0x1872D3850")]
		protected KBAIGJMAONF.FALICHFPADL IMGJJICADOD(KBAIGJMAONF.FALICHFPADL NOAAJJKCHIA, OBJHNMCDGDL MKJCGACHDHK)
		{
			return default(KBAIGJMAONF.FALICHFPADL);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x72D4C00", Offset = "0x72D4000", VA = "0x1872D4C00")]
		protected void MGIKIJNKDOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x1015CD0", Offset = "0x10150D0", VA = "0x181015CD0")]
		protected void HNBHDJGFKEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x72D2B00", Offset = "0x72D1F00", VA = "0x1872D2B00")]
		protected void FPPBIBACHGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x72D2EE0", Offset = "0x72D22E0", VA = "0x1872D2EE0")]
		[AsyncStateMachine(typeof(DFGCHIGLELG))]
		protected Task GHJJLNJPPAJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x72D1180", Offset = "0x72D0580", VA = "0x1872D1180")]
		protected static ELDJGACMLPI DBDPHCDEDDD(OGMDKFDFBIB FAHICGIKPOG, int MFCLFEPKGAD)
		{
			return default(ELDJGACMLPI);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x72D16E0", Offset = "0x72D0AE0", VA = "0x1872D16E0")]
		protected static FKJFCNDMIGG EFGPFDDOCGO(OGMDKFDFBIB FAHICGIKPOG, int MFCLFEPKGAD)
		{
			return default(FKJFCNDMIGG);
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x72CDFC0", Offset = "0x72CD3C0", VA = "0x1872CDFC0")]
		protected Transform AHNLNLMNGJJ(OBJHNMCDGDL DBDEIKJCEBF, OutfitType CNBEFNFJEEJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x72D35E0", Offset = "0x72D29E0", VA = "0x1872D35E0")]
		protected void IILLJHAHBOI(int CLLOKPKIGEH, Material HJCEHLILOIG, OGMDKFDFBIB FAHICGIKPOG, [Out] Texture2D KNJHLLDKNBN, [Out] Vector4 LEBIOKJNNBM, [Out] Texture2D HCBHLHALDCK, [Out] Texture2D AOLJNNMDFDK, [Out] Texture2D OIPGNFEPIAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x72D5C90", Offset = "0x72D5090", VA = "0x1872D5C90")]
		protected void PIKIKHNHLMM(int CLLOKPKIGEH, Material HJCEHLILOIG, OGMDKFDFBIB FAHICGIKPOG, [Out] Color KDBCFKGNGJP, [Out] Color OJKPDPFPHGP, [Out] Color EKKHNINCDDG, [Out] Color AJJDBGBBOLB, [Out] Color CEJFGPJEHDN, [Out] Color DDPMLLMDLNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x72D37E0", Offset = "0x72D2BE0", VA = "0x1872D37E0")]
		protected void ILHEGNOANEF(Vector3 NAMOIOBECGF, Quaternion KGCMOGJCFFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x72D76A0", Offset = "0x72D6AA0", VA = "0x1872D76A0")]
		public void SetHatAnchorParameters(KOIFPCMFICK OHNHANMMLDL, AnchorParamsRestrictions OMNAKBCJIBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x72D0A10", Offset = "0x72CFE10", VA = "0x1872D0A10")]
		public static void CalculateHatAnchorParams(FitMeshHemisphere AGNPDMHKOEB, Transform JHGKNCGAJBG, KOIFPCMFICK OHNHANMMLDL, AnchorParamsRestrictions HBMDEFKGEPA, [Out] Vector3 IJNCCGADGJC, [Out] Quaternion BALNGIJIBOK, [Out] KOIFPCMFICK DIFMNIOEHOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x72D6530", Offset = "0x72D5930", VA = "0x1872D6530")]
		public void ResetHatAnchor(Vector2 OGFKPOHFILO, Vector3 GFMEDHAJNFG, Vector3 AAOMFNIJCFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0x9B6380", Offset = "0x9B5780", VA = "0x1809B6380")]
		public BOEIPLPALDB GetAnchorParamsRestrictions()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0x72CE360", Offset = "0x72CD760", VA = "0x1872CE360")]
		public void ApplyBlocks()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x72CE4A0", Offset = "0x72CD8A0", VA = "0x1872CE4A0")]
		public void ApplyHairPattern()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x72CE2D0", Offset = "0x72CD6D0", VA = "0x1872CE2D0")]
		public void ApplyBeardPattern()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0x72D8FD0", Offset = "0x72D83D0", VA = "0x1872D8FD0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x72D24D0", Offset = "0x72D18D0", VA = "0x1872D24D0")]
		protected void FCLPNKDFAJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x72D8D90", Offset = "0x72D8190", VA = "0x1872D8D90")]
		public void SetWaitForUgcTextureLoads(bool OENELICLIHC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x72D8CA0", Offset = "0x72D80A0", VA = "0x1872D8CA0")]
		public void SetUgcTextureParameters(IKKEFGFKHCN FJJOKDBOKAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002BE")]
		[Cpp2IlInjected.Address(RVA = "0x72D98D0", Offset = "0x72D8CD0", VA = "0x1872D98D0")]
		public PlayerAvatarDisplayBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(RVA = "0x72D2FB0", Offset = "0x72D23B0", VA = "0x1872D2FB0")]
		[CompilerGenerated]
		private void GKHCHAPFHFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(RVA = "0x72CEBC0", Offset = "0x72CDFC0", VA = "0x1872CEBC0")]
		[CompilerGenerated]
		private void BCLOIJIJDNE(KNJLNBBJAHG AKHBEIJLAGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x72D4640", Offset = "0x72D3A40", VA = "0x1872D4640")]
		[CompilerGenerated]
		private void LANCKAJDDDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x72D3AF0", Offset = "0x72D2EF0", VA = "0x1872D3AF0")]
		[CompilerGenerated]
		private void JIBAFKFKEGM(KNJLNBBJAHG AKHBEIJLAGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x72D3D80", Offset = "0x72D3180", VA = "0x1872D3D80")]
		[CompilerGenerated]
		private void KCLGLHGCCEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x72D2100", Offset = "0x72D1500", VA = "0x1872D2100")]
		[CompilerGenerated]
		private void EKKMJANOKHC(KNJLNBBJAHG AKHBEIJLAGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x72D34A0", Offset = "0x72D28A0", VA = "0x1872D34A0")]
		[CompilerGenerated]
		private void HPAIHOGPPLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x72D42C0", Offset = "0x72D36C0", VA = "0x1872D42C0")]
		[CompilerGenerated]
		private void KMCMKOAKCAM(KNJLNBBJAHG AKHBEIJLAGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x72D4830", Offset = "0x72D3C30", VA = "0x1872D4830")]
		[CompilerGenerated]
		private void LLKMNKLEOID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x72D4C10", Offset = "0x72D4010", VA = "0x1872D4C10")]
		[CompilerGenerated]
		private void MGKLBBENOFE(KNJLNBBJAHG AKHBEIJLAGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x72D1650", Offset = "0x72D0A50", VA = "0x1872D1650")]
		[CompilerGenerated]
		private void DNEPHAEJCIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x72D35C0", Offset = "0x72D29C0", VA = "0x1872D35C0")]
		[CompilerGenerated]
		private void IDBCDFDHICN(KNJLNBBJAHG AKHBEIJLAGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x72D1320", Offset = "0x72D0720", VA = "0x1872D1320")]
		[CompilerGenerated]
		internal static bool DCPINLBMNDF(Transform OJFPEIKDIBB, IEnumerable<SkinnedMeshRenderer> IEJIBIKPCAM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x72CEBF0", Offset = "0x72CDFF0", VA = "0x1872CEBF0")]
		[CompilerGenerated]
		private void BDBAPKAKNFM(KNJLNBBJAHG AKHBEIJLAGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x72D3E10", Offset = "0x72D3210", VA = "0x1872D3E10")]
		[CompilerGenerated]
		private void KDKHNMIEAAP(KNJLNBBJAHG AKHBEIJLAGO)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[ExecuteAlways]
	public class PlayerFacialAnimatorBase : MonoBehaviour, NFEDKEMNHKL
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200006D")]
		[CompilerGenerated]
		private struct ONEIKGJMGAL : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000449")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400044A")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400044B")]
			public PHGEAGLPDDM avatarData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400044C")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400044D")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600037D")]
			[Cpp2IlInjected.Address(RVA = "0x72E38D0", Offset = "0x72E2CD0", VA = "0x1872E38D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600037E")]
			[Cpp2IlInjected.Address(RVA = "0x72E3B60", Offset = "0x72E2F60", VA = "0x1872E3B60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200006E")]
		[CompilerGenerated]
		private struct HABCCFPALLI : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400044E")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400044F")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000450")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000451")]
			public int eyeSelection;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000452")]
			public int eyeBrowSelection;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000453")]
			public int noseSelection;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000454")]
			public int mouthSelection;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000455")]
			public PKOOKMMPLDP avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000456")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600037F")]
			[Cpp2IlInjected.Address(RVA = "0x72DD670", Offset = "0x72DCA70", VA = "0x1872DD670", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000380")]
			[Cpp2IlInjected.Address(RVA = "0x72DD840", Offset = "0x72DCC40", VA = "0x1872DD840", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200006F")]
		[CompilerGenerated]
		private struct ALNHEFGIJKO : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000457")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000458")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000459")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400045A")]
			public FaceFeatureType featureType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x400045B")]
			public int selectionIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400045C")]
			public PKOOKMMPLDP avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400045D")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000381")]
			[Cpp2IlInjected.Address(RVA = "0x72DBA60", Offset = "0x72DAE60", VA = "0x1872DBA60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000382")]
			[Cpp2IlInjected.Address(RVA = "0x72DBC00", Offset = "0x72DB000", VA = "0x1872DBC00", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000070")]
		[CompilerGenerated]
		private struct DDKHNKOEJIO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400045E")]
			public PHGEAGLPDDM avatarData;
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000071")]
		[CompilerGenerated]
		private struct JCNMFENPGAO : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400045F")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000460")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000461")]
			public PHGEAGLPDDM avatarData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000462")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000463")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000383")]
			[Cpp2IlInjected.Address(RVA = "0x72DF1D0", Offset = "0x72DE5D0", VA = "0x1872DF1D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000384")]
			[Cpp2IlInjected.Address(RVA = "0x72DF700", Offset = "0x72DEB00", VA = "0x1872DF700", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000072")]
		[CompilerGenerated]
		private struct NEDPBEGPIOA : IAsyncStateMachine
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
			public PKOOKMMPLDP avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000468")]
			private TaskAwaiter<JCJBPDFIOHA> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000385")]
			[Cpp2IlInjected.Address(RVA = "0x72E31E0", Offset = "0x72E25E0", VA = "0x1872E31E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000386")]
			[Cpp2IlInjected.Address(RVA = "0x72E3600", Offset = "0x72E2A00", VA = "0x1872E3600", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000073")]
		[CompilerGenerated]
		private struct PCKGCEMPDPN : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000469")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400046A")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400046B")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400046C")]
			public PKOOKMMPLDP avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400046D")]
			private FaceStyleSet <styleSet>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400046E")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000387")]
			[Cpp2IlInjected.Address(RVA = "0x72E3BC0", Offset = "0x72E2FC0", VA = "0x1872E3BC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000388")]
			[Cpp2IlInjected.Address(RVA = "0x72E4080", Offset = "0x72E3480", VA = "0x1872E4080", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40003D7")]
		protected const float GAIBFLDFBCB = 0.5f;

		[Cpp2IlInjected.Token(Token = "0x40003D8")]
		protected const int MAOJDMAEAFG = 5;

		[Cpp2IlInjected.Token(Token = "0x40003D9")]
		public static readonly int IdleID;

		[Cpp2IlInjected.Token(Token = "0x40003DA")]
		public static readonly int SmileID;

		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		public static readonly int HugeSmileID;

		[Cpp2IlInjected.Token(Token = "0x40003DC")]
		public static readonly int ScoreID;

		[Cpp2IlInjected.Token(Token = "0x40003DD")]
		public static readonly int SadID;

		[Cpp2IlInjected.Token(Token = "0x40003DE")]
		public static readonly int DisgustID;

		[Cpp2IlInjected.Token(Token = "0x40003DF")]
		public static readonly int HitID;

		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		public static readonly int ConcentrateID;

		[Cpp2IlInjected.Token(Token = "0x40003E1")]
		public static readonly int KissID;

		[Cpp2IlInjected.Token(Token = "0x40003E2")]
		public static readonly int TalkingID;

		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		public static readonly int MuteID;

		[Cpp2IlInjected.Token(Token = "0x40003E4")]
		public static readonly int AFKID;

		[Cpp2IlInjected.Token(Token = "0x40003E5")]
		public static readonly int HappyID;

		[Cpp2IlInjected.Token(Token = "0x40003E6")]
		public static readonly int EmoteFlatID;

		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		public static readonly int EmoteHappyID;

		[Cpp2IlInjected.Token(Token = "0x40003E8")]
		public static readonly int EmoteSadID;

		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		public static readonly int EmoteLoveID;

		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		public static readonly int EmoteAngryID;

		[Cpp2IlInjected.Token(Token = "0x40003EB")]
		public static readonly int EmoteLaughID;

		[Cpp2IlInjected.Token(Token = "0x40003EC")]
		public static readonly int EmoteTongueOutID;

		[Cpp2IlInjected.Token(Token = "0x40003ED")]
		public static readonly int EmoteGrimacingID;

		[Cpp2IlInjected.Token(Token = "0x40003EE")]
		public static readonly int EmoteWinkID;

		[Cpp2IlInjected.Token(Token = "0x40003EF")]
		public static readonly int EmoteShockedID;

		[Cpp2IlInjected.Token(Token = "0x40003F0")]
		public static readonly int EmoteNauseatedID;

		[Cpp2IlInjected.Token(Token = "0x40003F1")]
		public static readonly int EmoteSmileSweatID;

		[Cpp2IlInjected.Token(Token = "0x40003F2")]
		public static readonly int EmoteSleepingID;

		[Cpp2IlInjected.Token(Token = "0x40003F3")]
		public static readonly int EmoteThinkingID;

		[Cpp2IlInjected.Token(Token = "0x40003F4")]
		public static readonly int EmoteSmirkID;

		[Cpp2IlInjected.Token(Token = "0x40003F5")]
		public static readonly int EmoteSmileID;

		[Cpp2IlInjected.Token(Token = "0x40003F6")]
		protected static readonly Dictionary<BCOAPANBCBE.AHFGMPCCCPM, int> IJKIGAOCIGL;

		[Cpp2IlInjected.Token(Token = "0x40003F7")]
		[CanBeNull]
		protected static IEnumerable<FaceFeatureType> PKFHMEDHDIB;

		[Cpp2IlInjected.Token(Token = "0x40003F8")]
		protected static readonly int IBFGCGCFPBP;

		[Cpp2IlInjected.Token(Token = "0x40003F9")]
		protected static readonly int IGPCGFGGPPE;

		[Cpp2IlInjected.Token(Token = "0x40003FA")]
		protected static readonly int AGFCBCFADAI;

		[Cpp2IlInjected.Token(Token = "0x40003FB")]
		protected static readonly int KKHHFBGELCM;

		[Cpp2IlInjected.Token(Token = "0x40003FC")]
		protected static readonly int AIJNMDMEGKG;

		[Cpp2IlInjected.Token(Token = "0x40003FD")]
		protected static readonly int DMOAGAGMAPJ;

		[Cpp2IlInjected.Token(Token = "0x40003FE")]
		protected static readonly int IDHKHCAGJBL;

		[Cpp2IlInjected.Token(Token = "0x40003FF")]
		protected static readonly int MEPJFDNIMPB;

		[Cpp2IlInjected.Token(Token = "0x4000400")]
		protected static Vector2 OPIDIKAHHGI;

		[Cpp2IlInjected.Token(Token = "0x4000401")]
		protected static Vector2 KMLGDBGGKAB;

		[Cpp2IlInjected.Token(Token = "0x4000402")]
		protected static Vector2 DPBODDCJCKD;

		[Cpp2IlInjected.Token(Token = "0x4000403")]
		protected static Vector2 GHNLFDMFKCH;

		[Cpp2IlInjected.Token(Token = "0x4000404")]
		protected static Vector2 LCGFIACGKAN;

		[Cpp2IlInjected.Token(Token = "0x4000405")]
		protected static Vector2 DNBJOIFEPEA;

		[Cpp2IlInjected.Token(Token = "0x4000406")]
		protected static Vector2 NBGEEMDLFMG;

		[Cpp2IlInjected.Token(Token = "0x4000407")]
		protected static Vector2 EEBADFNPJIF;

		[Cpp2IlInjected.Token(Token = "0x4000408")]
		protected static Vector2 IIDJMBJDPGC;

		[Cpp2IlInjected.Token(Token = "0x4000409")]
		protected static Vector2 HGIJHPAFBFJ;

		[Cpp2IlInjected.Token(Token = "0x400040A")]
		protected static Vector2 AJLFHEJIAHF;

		[Cpp2IlInjected.Token(Token = "0x400040B")]
		protected static Vector2 NEDJAFKGFJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400040C")]
		[SerializeField]
		[ALEFAIIJNEI(KCNGGJNCENB.Self, false, false, false)]
		public Animator animator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400040D")]
		[Header("Rendering")]
		[SerializeField]
		public FaceStyleSet faceStyleSet;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400040E")]
		[SerializeField]
		protected Renderer faceRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400040F")]
		[SerializeField]
		protected float jitterFPS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000410")]
		[SerializeField]
		[Header("Emotes")]
		public Renderer[] emoteEffectRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000411")]
		[Header("Modern Avatar Facial Features")]
		[SerializeField]
		[FormerlySerializedAs("fullBodyFaceStyleSet")]
		public FaceStyleSet modernBodyFaceStyleSet;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000412")]
		private PKOOKMMPLDP FMFHJPKDHPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000413")]
		private FaceStyleSet JKOGIGIPIGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000414")]
		[SerializeField]
		protected bool debugEyeJitterInEditor;

		[Cpp2IlInjected.Token(Token = "0x4000415")]
		protected const int LFAAKLBAMEB = -1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000416")]
		protected int CIALEKGBMME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000417")]
		protected int HCOFPIFPNDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000418")]
		protected int PLBFBDJADCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000419")]
		protected int BKCNPAGGBDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x400041A")]
		protected Vector2 KKOPDFHOHFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x400041B")]
		protected float DCKFENLCPAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400041C")]
		protected Vector2 KGMANAKAPEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400041D")]
		protected float KMNFAGBPPDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x400041E")]
		protected Vector2 PFPIELJCBEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x400041F")]
		protected float PKLDNLECFPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000420")]
		protected Vector2 AEHAJBLNCIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000421")]
		protected float IFOMOCEHLGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000422")]
		protected List<SelectableFaceOption> OMEKOMCKFLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000423")]
		protected List<SelectableFaceOption> DHLNKHAMHKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000424")]
		protected List<SelectableFaceOption> JBAKPMJBJFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000425")]
		protected List<SelectableFaceOption> NDPJIFPFDGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000426")]
		protected Coroutine JPPAHFBBDMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000427")]
		protected int? NCFLMILHKKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000428")]
		protected int KOAAOOGGGKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
		[Cpp2IlInjected.Token(Token = "0x4000429")]
		protected int COAEBLGAJNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400042A")]
		protected int CBEFCPHNIMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
		[Cpp2IlInjected.Token(Token = "0x400042B")]
		protected int MDNDPLDNJEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400042C")]
		protected int CJKKOAAFKGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
		[Cpp2IlInjected.Token(Token = "0x400042D")]
		protected int NOGGIMHDECG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400042E")]
		protected Sprite EKGPAAOCPAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400042F")]
		protected Sprite KMMDBFBKMPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000430")]
		protected Sprite NIINKNAEBMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000431")]
		protected Sprite KHGBBJMMFDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000432")]
		protected bool LDKJGBFHFKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000434")]
		protected string LBCFNOPDNDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000435")]
		protected string PPADBNMMODO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000436")]
		protected string DLEMFHHKHHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000437")]
		protected string MGBIIPNPIPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000438")]
		[ReadOnlyField]
		public Sprite eyeSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000439")]
		[ReadOnlyField]
		public Sprite leftEyeOnlySprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x400043A")]
		[ReadOnlyField]
		public Sprite rightEyeOnlySprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x400043B")]
		public Color leftEyeColorTint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x400043C")]
		public Color leftEyeGleamColorTint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x400043D")]
		public Color rightEyeColorTint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x400043E")]
		public Color rightEyeGleamColorTint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x400043F")]
		[ReadOnlyField]
		public Sprite mouthSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x4000443")]
		protected AvatarConfiguration BFMGDLDGOKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x4000444")]
		protected JCJBPDFIOHA PNIPJOANAPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x4000446")]
		private readonly List<Material> IMMNOELIFLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x4000447")]
		protected ANAHCJOGKFH JAIKFIODDHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x4000448")]
		protected Dictionary<string, int> GLMELDMFGEA;

		[Cpp2IlInjected.Token(Token = "0x17000097")]
		public FaceStyleSet PNFJAMBMPBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000338")]
			[Cpp2IlInjected.Address(RVA = "0x72EA630", Offset = "0x72E9A30", VA = "0x1872EA630")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000098")]
		public bool KOOLCCHMOJA
		{
			[Cpp2IlInjected.Token(Token = "0x600033B")]
			[Cpp2IlInjected.Address(RVA = "0xA20170", Offset = "0xA1F570", VA = "0x180A20170", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600033C")]
			[Cpp2IlInjected.Address(RVA = "0x12A7A60", Offset = "0x12A6E60", VA = "0x1812A7A60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000099")]
		protected virtual bool BGPDLKFPHKC
		{
			[Cpp2IlInjected.Token(Token = "0x600033D")]
			[Cpp2IlInjected.Address(RVA = "0x993CC0", Offset = "0x9930C0", VA = "0x180993CC0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009A")]
		protected virtual bool JKLLANMPCAJ
		{
			[Cpp2IlInjected.Token(Token = "0x600033E")]
			[Cpp2IlInjected.Address(RVA = "0x965500", Offset = "0x964900", VA = "0x180965500", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009B")]
		protected int KBMFHPMJGLO
		{
			[Cpp2IlInjected.Token(Token = "0x600033F")]
			[Cpp2IlInjected.Address(RVA = "0x72E6CC0", Offset = "0x72E60C0", VA = "0x1872E6CC0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009C")]
		public Renderer KDJCCOHJKGF
		{
			[Cpp2IlInjected.Token(Token = "0x6000340")]
			[Cpp2IlInjected.Address(RVA = "0x94B9E0", Offset = "0x94ADE0", VA = "0x18094B9E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		public bool DDCNEJOLHGH
		{
			[Cpp2IlInjected.Token(Token = "0x6000341")]
			[Cpp2IlInjected.Address(RVA = "0x12AD400", Offset = "0x12AC800", VA = "0x1812AD400")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000342")]
			[Cpp2IlInjected.Address(RVA = "0x12AD710", Offset = "0x12ACB10", VA = "0x1812AD710")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009E")]
		public Renderer[] JKLHKJKLCGG
		{
			[Cpp2IlInjected.Token(Token = "0x6000343")]
			[Cpp2IlInjected.Address(RVA = "0x94BDD0", Offset = "0x94B1D0", VA = "0x18094BDD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		public bool EANFPCLCALE
		{
			[Cpp2IlInjected.Token(Token = "0x6000344")]
			[Cpp2IlInjected.Address(RVA = "0x72EA670", Offset = "0x72E9A70", VA = "0x1872EA670")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000345")]
			[Cpp2IlInjected.Address(RVA = "0x72EA830", Offset = "0x72E9C30", VA = "0x1872EA830")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A0")]
		protected int JFHLEBLJIHC
		{
			[Cpp2IlInjected.Token(Token = "0x6000346")]
			[Cpp2IlInjected.Address(RVA = "0x72E76B0", Offset = "0x72E6AB0", VA = "0x1872E76B0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A1")]
		protected int FGJNKMJMPFP
		{
			[Cpp2IlInjected.Token(Token = "0x6000347")]
			[Cpp2IlInjected.Address(RVA = "0x72E64C0", Offset = "0x72E58C0", VA = "0x1872E64C0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A2")]
		public float CPDMPGIHPBC
		{
			[Cpp2IlInjected.Token(Token = "0x6000348")]
			[Cpp2IlInjected.Address(RVA = "0x72EA650", Offset = "0x72E9A50", VA = "0x1872EA650")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000349")]
			[Cpp2IlInjected.Address(RVA = "0x72EA810", Offset = "0x72E9C10", VA = "0x1872EA810")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A3")]
		public JGOJAJEODNM MJHKIHENJIA
		{
			[Cpp2IlInjected.Token(Token = "0x600034A")]
			[Cpp2IlInjected.Address(RVA = "0xAB4F90", Offset = "0xAB4390", VA = "0x180AB4F90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600034B")]
			[Cpp2IlInjected.Address(RVA = "0xA292B0", Offset = "0xA286B0", VA = "0x180A292B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A4")]
		public JCJBPDFIOHA FJJPIOPJPCJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000364")]
			[Cpp2IlInjected.Address(RVA = "0xAB53B0", Offset = "0xAB47B0", VA = "0x180AB53B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000365")]
			[Cpp2IlInjected.Address(RVA = "0x72EA790", Offset = "0x72E9B90", VA = "0x1872EA790")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		public NoseFaceOption NLOOKDPHIOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000366")]
			[Cpp2IlInjected.Address(RVA = "0xA1F150", Offset = "0xA1E550", VA = "0x180A1F150")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000367")]
			[Cpp2IlInjected.Address(RVA = "0x9B1390", Offset = "0x9B0790", VA = "0x1809B1390")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A6")]
		protected ANAHCJOGKFH LLDPFCIIMIA
		{
			[Cpp2IlInjected.Token(Token = "0x6000368")]
			[Cpp2IlInjected.Address(RVA = "0x72E6DF0", Offset = "0x72E61F0", VA = "0x1872E6DF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action AEEEEOOMLCH
		{
			[Cpp2IlInjected.Token(Token = "0x6000339")]
			[Cpp2IlInjected.Address(RVA = "0x72EA580", Offset = "0x72E9980", VA = "0x1872EA580")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600033A")]
			[Cpp2IlInjected.Address(RVA = "0x72EA6E0", Offset = "0x72E9AE0", VA = "0x1872EA6E0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x72E7790", Offset = "0x72E6B90", VA = "0x1872E7790")]
		public void LocalPlayEmote(BCOAPANBCBE.AHFGMPCCCPM HKHPHIHDFNO, float JJAFHIAMAAF = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x72E6BA0", Offset = "0x72E5FA0", VA = "0x1872E6BA0")]
		public bool IsEmotePlaying(BCOAPANBCBE.AHFGMPCCCPM HKHPHIHDFNO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x72E85E0", Offset = "0x72E79E0", VA = "0x1872E85E0")]
		public void SetIdleHappy(bool IEPOOEEAEDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x72E7710", Offset = "0x72E6B10", VA = "0x1872E7710")]
		protected void KJNLMDLMDAP(bool MIAODPIBFGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x72E48F0", Offset = "0x72E3CF0", VA = "0x1872E48F0")]
		protected void AHEABNLCCAG(bool HELMHCNHIKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0x72E53A0", Offset = "0x72E47A0", VA = "0x1872E53A0")]
		protected void EPOLAPJNIGO(OBJHNMCDGDL DBDEIKJCEBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x72E62B0", Offset = "0x72E56B0", VA = "0x1872E62B0")]
		protected void HKBLOMONFPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x72E7E10", Offset = "0x72E7210", VA = "0x1872E7E10")]
		public void PlayExpression(int JPCDKLCCAEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(RVA = "0x72E6400", Offset = "0x72E5800", VA = "0x1872E6400")]
		protected void HONHDAKIJCN(bool PCNLIOPPHCO, bool EJEMIGMMNAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(RVA = "0x72E6270", Offset = "0x72E5670", VA = "0x1872E6270")]
		public List<SelectableFaceOption> GetAvailableFeatures(FaceFeatureType EFKOOGECDHL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(RVA = "0x72E66C0", Offset = "0x72E5AC0", VA = "0x1872E66C0")]
		public void InitializeFaceFeatureRanges(AvatarConfiguration BFMGDLDGOKJ, PKOOKMMPLDP HMKELMICGGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(RVA = "0x72E84F0", Offset = "0x72E78F0", VA = "0x1872E84F0")]
		[AsyncStateMachine(typeof(ONEIKGJMGAL))]
		public Task SetFaceSettings(PHGEAGLPDDM ALBFPGNJIFO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0x72E83C0", Offset = "0x72E77C0", VA = "0x1872E83C0")]
		[AsyncStateMachine(typeof(HABCCFPALLI))]
		public Task SetFaceSettings(int OOOGIGINOPD, int DHABPCBKOAL, int KONEGDNJDKO, int IBOLAKHKLGO, PKOOKMMPLDP HMKELMICGGI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0x72E8660", Offset = "0x72E7A60", VA = "0x1872E8660")]
		[AsyncStateMachine(typeof(ALNHEFGIJKO))]
		public Task SetSelectedFaceFeatureAndBuildFaceStyle(FaceFeatureType EFKOOGECDHL, int JJCKEDNCFKB, PKOOKMMPLDP HMKELMICGGI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(RVA = "0x72E5540", Offset = "0x72E4940", VA = "0x1872E5540")]
		protected void FDOKAJCEGOG(FaceFeatureType EFKOOGECDHL, EJPJNNNFMKK EKOKNCCJHCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(RVA = "0x72E6F50", Offset = "0x72E6350", VA = "0x1872E6F50")]
		protected void KDNLLKNFAFK(FaceFeatureType EFKOOGECDHL, int JJCKEDNCFKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(RVA = "0x72E6090", Offset = "0x72E5490", VA = "0x1872E6090")]
		public static IEnumerable<FaceFeatureType> GetAllFaceFeatureTypes()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(RVA = "0x72E51C0", Offset = "0x72E45C0", VA = "0x1872E51C0")]
		[AsyncStateMachine(typeof(JCNMFENPGAO))]
		protected Task DKHINJDMOEE(PHGEAGLPDDM ALBFPGNJIFO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(RVA = "0x72E6520", Offset = "0x72E5920", VA = "0x1872E6520")]
		protected static void IFFBHOIIFEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x72E4A50", Offset = "0x72E3E50", VA = "0x1872E4A50")]
		private void AJEBOJDPJGA(bool CLGFOHGAOFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x72E7AA0", Offset = "0x72E6EA0", VA = "0x1872E7AA0")]
		protected void PPKKCDFDKGO(FaceFeatureType EFKOOGECDHL, Vector2 ILINMNBKBOG, PKOOKMMPLDP HMKELMICGGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x72E7E30", Offset = "0x72E7230", VA = "0x1872E7E30")]
		public void SetFaceFeatureNormalizedPositionOffset(FaceFeatureType EFKOOGECDHL, Vector2 BACDHEGGABN, PKOOKMMPLDP HMKELMICGGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x72E56C0", Offset = "0x72E4AC0", VA = "0x1872E56C0")]
		protected void FJHKNDPHIPJ(FaceFeatureType EFKOOGECDHL, float DHIKJADGNNJ, PKOOKMMPLDP HMKELMICGGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(RVA = "0x72E81A0", Offset = "0x72E75A0", VA = "0x1872E81A0")]
		public void SetFaceFeatureNormalizedScaleOffset(FaceFeatureType EFKOOGECDHL, float OIJMFADLAHH, PKOOKMMPLDP HMKELMICGGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x72E6320", Offset = "0x72E5720", VA = "0x1872E6320")]
		[AsyncStateMachine(typeof(NEDPBEGPIOA))]
		protected Task HNLKFLNPLIN(PKOOKMMPLDP HMKELMICGGI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x72E6990", Offset = "0x72E5D90", VA = "0x1872E6990")]
		public void InitializeFaceFeatureStyleSet(PKOOKMMPLDP HMKELMICGGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x72E6E70", Offset = "0x72E6270", VA = "0x1872E6E70")]
		protected bool KCLNGNJBOKN(string BHDEFAKNALA, [Out] int EAHKFAJBNDN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x72E4CE0", Offset = "0x72E40E0", VA = "0x1872E4CE0")]
		protected void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(RVA = "0x13155D0", Offset = "0x13149D0", VA = "0x1813155D0", Slot = "8")]
		protected virtual void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x72E7890", Offset = "0x72E6C90", VA = "0x1872E7890")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x72E9630", Offset = "0x72E8A30", VA = "0x1872E9630")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x72E4E20", Offset = "0x72E4220", VA = "0x1872E4E20")]
		[AsyncStateMachine(typeof(PCKGCEMPDPN))]
		public Task BuildFaceStyleAsyncIfChanged(PKOOKMMPLDP HMKELMICGGI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x72E8F60", Offset = "0x72E8360", VA = "0x1872E8F60")]
		public void UpdateFaceDisplays(bool DPEALEDPIGL = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x72E5840", Offset = "0x72E4C40", VA = "0x1872E5840")]
		protected bool GCGMHOAPEKC(bool DPEALEDPIGL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x72E8C80", Offset = "0x72E8080", VA = "0x1872E8C80")]
		public void UpdateFaceDisplayFeatureTextures()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x72E8770", Offset = "0x72E7B70", VA = "0x1872E8770")]
		public void UpdateFaceDisplayFeaturePositions()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x72E9170", Offset = "0x72E8570", VA = "0x1872E9170")]
		public void UpdateFaceJitterMultiplier()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x72E9360", Offset = "0x72E8760", VA = "0x1872E9360")]
		public bool UpdateLegacyFaceVectors()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x72E52B0", Offset = "0x72E46B0", VA = "0x1872E52B0")]
		protected void DOMGPDHKOJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x72E4F10", Offset = "0x72E4310", VA = "0x1872E4F10")]
		private void CKDOABAJBMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x72EA320", Offset = "0x72E9720", VA = "0x1872EA320")]
		public PlayerFacialAnimatorBase()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x976B50", Offset = "0x975F50", VA = "0x180976B50", Slot = "4")]
		private bool GIDEPICAEBC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x72E5410", Offset = "0x72E4810", VA = "0x1872E5410")]
		[CompilerGenerated]
		internal static DALAGIAKGMF FCCCPEOOFMJ(FaceFeatureType EFKOOGECDHL, DDKHNKOEJIO P_1)
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public struct MOCNMPCJEFJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400046F")]
	public string OPDMIMOEGEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000470")]
	public int AOALABMLPFM;
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
		private struct NFJDDLMHNFI : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004D0")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40004D1")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004D2")]
			public PlayerModernBodyEditorAvatarValidator <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004D3")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003BB")]
			[Cpp2IlInjected.Address(RVA = "0x72E3660", Offset = "0x72E2A60", VA = "0x1872E3660", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003BC")]
			[Cpp2IlInjected.Address(RVA = "0xA48F40", Offset = "0xA48340", VA = "0x180A48F40", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000078")]
		[CompilerGenerated]
		private struct HMDGEEJHLPK : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004D4")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40004D5")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004D6")]
			public PlayerModernBodyEditorAvatarValidator <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004D7")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003BD")]
			[Cpp2IlInjected.Address(RVA = "0x72DEBC0", Offset = "0x72DDFC0", VA = "0x1872DEBC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003BE")]
			[Cpp2IlInjected.Address(RVA = "0x72DF0C0", Offset = "0x72DE4C0", VA = "0x1872DF0C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000471")]
		public const string IDLE_ANIM_NAME = "Idle";

		[Cpp2IlInjected.Token(Token = "0x4000472")]
		public const string A_POSE_ANIM_NAME = "A Pose";

		[Cpp2IlInjected.Token(Token = "0x4000473")]
		public const string ANIMATION_OVERRIDE_STATE_NAME = "Override";

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000474")]
		public PKOOKMMPLDP avatarBodyType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000476")]
		public Color hairPrimaryColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000477")]
		public Color hairSecondaryColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000478")]
		public Color beardPrimaryColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000479")]
		public Color beardSecondaryColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400047A")]
		public Color skinColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x400047B")]
		public int faceShapeIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400047C")]
		public int bodyShapeIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x400047D")]
		public int hairPatternIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400047E")]
		public int beardPatternIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400047F")]
		public AvatarFaceShape[] faceShapes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000480")]
		public AvatarBodyShape[] bodyShapes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000481")]
		public AvatarHairPattern[] hairPatterns;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000482")]
		public float _avatarScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x4000483")]
		public bool enablePosing;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000484")]
		public int poseIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000485")]
		public AnimationClip animationOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000486")]
		[Range(0f, 4f)]
		public float animationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x4000487")]
		public bool hideEars;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000488")]
		public MLFKPMGCMHF useHelmetHair;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000489")]
		public KOIFPCMFICK hatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400048A")]
		public BOEIPLPALDB HatAnchorRestrictions;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400048B")]
		public bool UseHairFitMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD1")]
		[Cpp2IlInjected.Token(Token = "0x400048C")]
		public bool usesHatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400048D")]
		public GameObject hatPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400048E")]
		public GameObject hairPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400048F")]
		public GameObject earPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000490")]
		public GameObject eyePrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000491")]
		public GameObject mouthPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000492")]
		public GameObject neckPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000493")]
		public GameObject shirtPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000494")]
		public GameObject beltPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000495")]
		public GameObject shoulderPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000496")]
		public GameObject rightHandPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000497")]
		public GameObject leftHandPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000498")]
		public GameObject legsPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000499")]
		public GameObject feetPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x400049A")]
		public KBAIGJMAONF.FALICHFPADL baseSkinCullingMask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x400049B")]
		[SerializeField]
		[ALEFAIIJNEI(KCNGGJNCENB.Self, false, false, false)]
		public PlayerAvatarDisplayBase _avatarDisplay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x400049C")]
		private DDFBFAJGEGF OFAGHFPPCNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x400049D")]
		[ALEFAIIJNEI(KCNGGJNCENB.Self, false, false, false)]
		[SerializeField]
		public PlayerFacialAnimatorBase facialAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x400049E")]
		public Animator animator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x400049F")]
		public AnimationClip animationClipToOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		private AnimatorOverrideController OPJKFGNMPMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		private List<KeyValuePair<AnimationClip, AnimationClip>> NCHFKHFCPNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		public Transform headIKEffector;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		public Transform leftHandIKEffector;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x40004A4")]
		public Transform rightHandIKEffector;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		[Range(0f, 2f)]
		public int lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19C")]
		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		public int rightHandGestureStateIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		[Range(0f, 1f)]
		public float rightHandCurl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A4")]
		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		public int leftHandGestureStateIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		[Range(0f, 1f)]
		public float leftHandCurl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1AC")]
		[Cpp2IlInjected.Token(Token = "0x40004AA")]
		public int eyeBrowSelection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		public int eyeSelection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B4")]
		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		public int noseSelection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		public int mouthSelection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1BC")]
		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		public float eyeBrowPositionOffsetHorizontal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		public float eyeBrowPositionOffsetVertical;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C4")]
		[Cpp2IlInjected.Token(Token = "0x40004B0")]
		public float eyeBrowScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x40004B1")]
		public float eyePositionOffsetHorizontal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1CC")]
		[Cpp2IlInjected.Token(Token = "0x40004B2")]
		public float eyePositionOffsetVertical;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x40004B3")]
		public float eyeScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D4")]
		[Cpp2IlInjected.Token(Token = "0x40004B4")]
		public float nosePositionOffsetVertical;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x40004B5")]
		public float noseScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1DC")]
		[Cpp2IlInjected.Token(Token = "0x40004B6")]
		public float mouthPositionOffsetHorizontal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x40004B7")]
		public float mouthPositionOffsetVertical;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E4")]
		[Cpp2IlInjected.Token(Token = "0x40004B8")]
		public float mouthScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x40004B9")]
		public float hatNormalizedPositionX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1EC")]
		[Cpp2IlInjected.Token(Token = "0x40004BA")]
		public float hatNormalizedPositionY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
		[Cpp2IlInjected.Token(Token = "0x40004BB")]
		public Vector3 hatHemispherePositionOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1FC")]
		[Cpp2IlInjected.Token(Token = "0x40004BC")]
		public Vector3 hatHemisphereRotationOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
		[Cpp2IlInjected.Token(Token = "0x40004BD")]
		public int facialExpressionIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20C")]
		[Cpp2IlInjected.Token(Token = "0x40004BE")]
		[Range(0f, 1f)]
		public float normalizedTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
		[Cpp2IlInjected.Token(Token = "0x40004BF")]
		public readonly MOCNMPCJEFJ[] FacialExpressions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
		[Cpp2IlInjected.Token(Token = "0x40004C0")]
		public readonly string[] BodyPoses;

		[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
		[Cpp2IlInjected.Token(Token = "0x40004C1")]
		public readonly (string, BKMINCPGJKF)[] HandPoses;

		[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
		[Cpp2IlInjected.Token(Token = "0x40004C2")]
		public bool hideLeftWatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x229")]
		[Cpp2IlInjected.Token(Token = "0x40004C3")]
		public bool hideRightWatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x22A")]
		[Cpp2IlInjected.Token(Token = "0x40004C4")]
		protected bool LAMMAOBONGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x22C")]
		[Cpp2IlInjected.Token(Token = "0x40004C5")]
		protected Guid FDGBFEGPCMF;

		[Cpp2IlInjected.Token(Token = "0x40004C6")]
		protected static Guid KHJIFHCAIJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
		[Cpp2IlInjected.Token(Token = "0x40004C7")]
		private AHBNJGDEGOO CLLKMBMJEFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
		[Cpp2IlInjected.Token(Token = "0x40004C8")]
		private JGOJAJEODNM GMIJCCPBOIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
		[Cpp2IlInjected.Token(Token = "0x40004C9")]
		private ODFMHACHCFM PKJKEKAGLJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
		[Cpp2IlInjected.Token(Token = "0x40004CA")]
		private ODFMHACHCFM CLFKCPDLIKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x40004CB")]
		private AdditionalHatData MCHOHKJPFNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
		[Cpp2IlInjected.Token(Token = "0x40004CC")]
		private readonly Dictionary<GameObject, LBKMHAIBEMP> KFGINMFPHBJ;

		[Cpp2IlInjected.Token(Token = "0x170000A7")]
		public static Func<AONNKEALKEA> LLAPFKCOLHI
		{
			[Cpp2IlInjected.Token(Token = "0x6000389")]
			[Cpp2IlInjected.Address(RVA = "0x72EF900", Offset = "0x72EED00", VA = "0x1872EF900")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600038A")]
			[Cpp2IlInjected.Address(RVA = "0x72EFF40", Offset = "0x72EF340", VA = "0x1872EFF40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A8")]
		public bool MFOIJFPIBNO
		{
			[Cpp2IlInjected.Token(Token = "0x600038B")]
			[Cpp2IlInjected.Address(RVA = "0x72EFA60", Offset = "0x72EEE60", VA = "0x1872EFA60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A9")]
		public bool HLJIHMLMLKA
		{
			[Cpp2IlInjected.Token(Token = "0x600038C")]
			[Cpp2IlInjected.Address(RVA = "0x72EF950", Offset = "0x72EED50", VA = "0x1872EF950")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AA")]
		public PlayerAvatarDisplayBase HEGOBJEGDKO
		{
			[Cpp2IlInjected.Token(Token = "0x600038E")]
			[Cpp2IlInjected.Address(RVA = "0x9B9610", Offset = "0x9B8A10", VA = "0x1809B9610")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AB")]
		protected static Guid CJDPAOLNINN
		{
			[Cpp2IlInjected.Token(Token = "0x600038F")]
			[Cpp2IlInjected.Address(RVA = "0x72EA980", Offset = "0x72E9D80", VA = "0x1872EA980")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AC")]
		public (GameObject, OBJHNMCDGDL)[] GCHABNKDIAC
		{
			[Cpp2IlInjected.Token(Token = "0x60003A5")]
			[Cpp2IlInjected.Address(RVA = "0x72EFB70", Offset = "0x72EEF70", VA = "0x1872EFB70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x72EB6B0", Offset = "0x72EAAB0", VA = "0x1872EB6B0")]
		private IEnumerable<GameObject> DCHBIHHKGDN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x72EDAE0", Offset = "0x72ECEE0", VA = "0x1872EDAE0")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x72EC7B0", Offset = "0x72EBBB0", VA = "0x1872EC7B0")]
		private void KDGCCNBOEIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x106E040", Offset = "0x106D440", VA = "0x18106E040")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x72EC0B0", Offset = "0x72EB4B0", VA = "0x1872EC0B0")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x72EDAF0", Offset = "0x72ECEF0", VA = "0x1872EDAF0")]
		public void Teardown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x72ED8E0", Offset = "0x72ECCE0", VA = "0x1872ED8E0")]
		public void ShowPose(AnimationClip HGFICPLCPIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x72EDAB0", Offset = "0x72ECEB0", VA = "0x1872EDAB0")]
		public void ShowPose(string NMBMLLGENAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x72ED740", Offset = "0x72ECB40", VA = "0x1872ED740")]
		public void ResetPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x72ED600", Offset = "0x72ECA00", VA = "0x1872ED600")]
		public void ResetHandPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x72EE5C0", Offset = "0x72ED9C0", VA = "0x1872EE5C0")]
		public void UpdateHandAnimation()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x72EE410", Offset = "0x72ED810", VA = "0x1872EE410")]
		public void UpdateFaceAndBodyShapes(bool KPBEAEKPEMK = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x72EE9C0", Offset = "0x72EDDC0", VA = "0x1872EE9C0")]
		public void UpdateNoseShape(EHLDDELHBFB DIKOIBEAEJB, bool KPBEAEKPEMK = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x72EE990", Offset = "0x72EDD90", VA = "0x1872EE990")]
		public void UpdateLODOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x72ED2F0", Offset = "0x72EC6F0", VA = "0x1872ED2F0", Slot = "4")]
		protected virtual void PNLLALKHHFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x72ECDB0", Offset = "0x72EC1B0", VA = "0x1872ECDB0", Slot = "5")]
		protected virtual void MFEAIHHGKJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x72EAC30", Offset = "0x72EA030", VA = "0x1872EAC30")]
		public void ApplyHatData(AdditionalHatData APEPHNGDACL, bool IGBOBDIMGID = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x72EAA70", Offset = "0x72E9E70", VA = "0x1872EAA70")]
		public void ApplyHatAdjustmentsToHatAnchorParams()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x72EAF90", Offset = "0x72EA390", VA = "0x1872EAF90")]
		public void ApplyHatUVOverride(Vector2 ALKJAKPMJBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x72EAEB0", Offset = "0x72EA2B0", VA = "0x1872EAEB0")]
		public void ApplyHatPositionAdjustment(Vector3 GCLMENIDEGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x72EAF20", Offset = "0x72EA320", VA = "0x1872EAF20")]
		public void ApplyHatRotationAdjustment(Vector3 FGMOOGCBIJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x72EB000", Offset = "0x72EA400", VA = "0x1872EB000")]
		public DKLBEPIMGOL BuildAvatarItemSelection(GameObject PIDIJCCONEO, PKOOKMMPLDP KJBFEELDPAB, OBJHNMCDGDL OGNNAFLGGHA)
		{
			return default(DKLBEPIMGOL);
		}

		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x72EB0A0", Offset = "0x72EA4A0", VA = "0x1872EB0A0")]
		public void BuildAvatar(bool KPBEAEKPEMK = false, bool IGBOBDIMGID = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x72EDE50", Offset = "0x72ED250", VA = "0x1872EDE50")]
		public void UpdateColors()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0x72EABB0", Offset = "0x72E9FB0", VA = "0x1872EABB0")]
		public void ApplyHatAnchor()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x72EE7E0", Offset = "0x72EDBE0", VA = "0x1872EE7E0")]
		public void UpdateHatAnchor(bool IGBOBDIMGID = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0x72EE510", Offset = "0x72ED910", VA = "0x1872EE510")]
		[AsyncStateMachine(typeof(NFJDDLMHNFI))]
		public void UpdateFaceFeatures()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0x72EBBD0", Offset = "0x72EAFD0", VA = "0x1872EBBD0")]
		[AsyncStateMachine(typeof(HMDGEEJHLPK))]
		private Task FPKFEJGALAL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x72ED020", Offset = "0x72EC420", VA = "0x1872ED020")]
		private void MIGEPAHCFBF(FaceFeatureType KGLDHIDPHPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x72EBB40", Offset = "0x72EAF40", VA = "0x1872EBB40")]
		private void FLPGOLBHFJH(FaceFeatureType KGLDHIDPHPP, [Out] float OLLMNLIBPHC, [Out] float NLNEKEMHMBN, [Out] float JJCKONKIIAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x72EE2D0", Offset = "0x72ED6D0", VA = "0x1872EE2D0")]
		public void UpdateEmote()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x72EE670", Offset = "0x72EDA70", VA = "0x1872EE670")]
		public void UpdateHandPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x72EC890", Offset = "0x72EBC90", VA = "0x1872EC890")]
		private void LABOFNPDNFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60")]
		private void OGJLPIBEODD(LBKMHAIBEMP HBNIICBFICF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60")]
		private void MCDFBLLOEPI(LBKMHAIBEMP HBNIICBFICF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x72EBCA0", Offset = "0x72EB0A0", VA = "0x1872EBCA0")]
		private void HDEGADBHPJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x72EEA50", Offset = "0x72EDE50", VA = "0x1872EEA50")]
		public PlayerModernBodyEditorAvatarValidator()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x72EC000", Offset = "0x72EB400", VA = "0x1872EC000")]
		[CompilerGenerated]
		private DKLBEPIMGOL HJGMBOALFML((GameObject, OBJHNMCDGDL) NPILLJODNJH)
		{
			return default(DKLBEPIMGOL);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	public class SkinnedMeshBonesInspector : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004D8")]
		[SerializeField]
		[ALEFAIIJNEI(KCNGGJNCENB.Self, false, false, false)]
		private SkinnedMeshRenderer skinnedMeshRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004D9")]
		[SerializeField]
		private int BoneWeightsDisplayStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40004DA")]
		[SerializeField]
		private int BoneWeightsDisplayAmount;

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x94AA50", Offset = "0x949E50", VA = "0x18094AA50")]
		public SkinnedMeshBonesInspector()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public struct DKLBEPIMGOL
{
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[CompilerGenerated]
	private sealed class JMHJDLAJJOB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004DD")]
		public IEnumerable<OutfitType> otherOutfitTypes;

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public JMHJDLAJJOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x72DF760", Offset = "0x72DEB60", VA = "0x1872DF760")]
		internal bool POHIIMCBOBL(OutfitType outfitType)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40004DB")]
	private LBKMHAIBEMP PFFFJAKBOKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40004DC")]
	private OBJHNMCDGDL JFACDOPDKFB;

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public LBKMHAIBEMP HCAGBBDPLIN
	{
		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0xBCD970", Offset = "0xBCCD70", VA = "0x180BCD970")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public OBJHNMCDGDL IDLHGNGCIKJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0xBCD960", Offset = "0xBCCD60", VA = "0x180BCD960")]
		get
		{
			return default(OBJHNMCDGDL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public string BAFPMMNNIMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x72DC2F0", Offset = "0x72DB6F0", VA = "0x1872DC2F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public bool FDDABPHKDNI
	{
		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x72DC4B0", Offset = "0x72DB8B0", VA = "0x1872DC4B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public bool HHKBBIPLOGC
	{
		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x72DC500", Offset = "0x72DB900", VA = "0x1872DC500")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x155CB70", Offset = "0x155BF70", VA = "0x18155CB70")]
	public DKLBEPIMGOL(LBKMHAIBEMP HBNIICBFICF, OBJHNMCDGDL DBDEIKJCEBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x72DC3E0", Offset = "0x72DB7E0", VA = "0x1872DC3E0")]
	public bool MKIANMGHHGB(OutfitType FOJNKLEFICC, OBJHNMCDGDL LHJANIHNMOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x72DBE90", Offset = "0x72DB290", VA = "0x1872DBE90")]
	public bool AIFJNMEPIAN(OutfitType FOJNKLEFICC, OBJHNMCDGDL LHJANIHNMOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x72DC100", Offset = "0x72DB500", VA = "0x1872DC100")]
	public bool KBKGMJEFENJ(DKLBEPIMGOL FOOBNAALELG)
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
